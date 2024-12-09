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
    let v30 : char list = []
    let v31 : char list = '/' :: v30 
    let v34 : char list = ' ' :: v31 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v6.TrimEnd v38 
    v41
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
            let v94 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v95 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v96 : Async<unit> = v95 v89
            let _v94 = v96 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v97 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v98 : Async<unit> = v97 v89
            let _v94 = v98 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v99 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v100 : Async<unit> = v99 v89
            let _v94 = v100 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v101 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v102 : Async<unit> = v101 v89
            let _v94 = v102 
            #endif
#if FABLE_COMPILER_PYTHON
            let v103 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v104 : Async<unit> = v103 v89
            let _v94 = v104 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v105 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v106 : Async<unit> = v105 v89
            let _v94 = v106 
            #endif
#else
            let v107 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v108 : Async<unit> = v107 v89
            let _v94 = v108 
            #endif
            let v109 : Async<unit> = _v94 
            do! v109 
            return true 
            with ex ->
                let v114 : exn = ex
                let v115 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v116 : string = $"%A{v114}"
                let _v115 = v116 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v119 : string = $"%A{v114}"
                let _v115 = v119 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v122 : string = $"%A{v114}"
                let _v115 = v122 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v125 : string = $"%A{v114}"
                let _v115 = v125 
                #endif
#if FABLE_COMPILER_PYTHON
                let v128 : string = $"%A{v114}"
                let _v115 = v128 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v131 : string = $"%A{v114}"
                let _v115 = v131 
                #endif
#else
                let v134 : string = $"{v114.GetType ()}: {v114.Message}"
                let _v115 = v134 
                #endif
                let v135 : string = _v115 
                let v140 : unit = ()
                let v141 : (unit -> unit) = closure5(v1, v135)
                let v142 : unit = (fun () -> v141 (); v140) ()
                return false 
                (*
                ()
            *)
            (*
            let v182 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v351 : Async<bool> = _v12 
    let _v2 = v351 
    #endif
#if FABLE_COMPILER_PYTHON
    let v352 : unit = ()
    let _v352 =
        async {
            let v355 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v355 = v355 
            let v356 : System.Threading.CancellationToken = v355 
            let v357 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v358 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v357 = v358 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v361 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v357 = v361 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v364 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v357 = v364 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v367 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v357 = v367 
            #endif
#if FABLE_COMPILER_PYTHON
            let v370 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v357 = v370 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v373 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v357 = v373 
            #endif
#else
            let v376 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v357 = v376 
            #endif
            let v377 : System_Net_Sockets_TcpClient = _v357 
            use v377 = v377 
            let v382 : System_Net_Sockets_TcpClient = v377 
            try
            let v383 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v384 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v383 = v384 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v387 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v383 = v387 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v390 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v383 = v390 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v393 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v383 = v393 
            #endif
#if FABLE_COMPILER_PYTHON
            let v396 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v383 = v396 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v399 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v383 = v399 
            #endif
#else
            let v402 : System.Threading.Tasks.ValueTask = v382.ConnectAsync (v0, v1, v356)
            let _v383 = v402 
            #endif
            let v403 : System.Threading.Tasks.ValueTask = _v383 
            let v408 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v409 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v408 = v409 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v412 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v408 = v412 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v415 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v408 = v415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v418 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v408 = v418 
            #endif
#if FABLE_COMPILER_PYTHON
            let v421 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v408 = v421 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v424 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v408 = v424 
            #endif
#else
            let v427 : (unit -> System.Threading.Tasks.Task) = v403.AsTask
            let v428 : System.Threading.Tasks.Task = v427 ()
            let _v408 = v428 
            #endif
            let v429 : System.Threading.Tasks.Task = _v408 
            let v434 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v435 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v436 : Async<unit> = v435 v429
            let _v434 = v436 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v437 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v438 : Async<unit> = v437 v429
            let _v434 = v438 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v439 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v440 : Async<unit> = v439 v429
            let _v434 = v440 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v441 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v442 : Async<unit> = v441 v429
            let _v434 = v442 
            #endif
#if FABLE_COMPILER_PYTHON
            let v443 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v444 : Async<unit> = v443 v429
            let _v434 = v444 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v445 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v446 : Async<unit> = v445 v429
            let _v434 = v446 
            #endif
#else
            let v447 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v448 : Async<unit> = v447 v429
            let _v434 = v448 
            #endif
            let v449 : Async<unit> = _v434 
            do! v449 
            return true 
            with ex ->
                let v454 : exn = ex
                let v455 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v456 : string = $"%A{v454}"
                let _v455 = v456 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v459 : string = $"%A{v454}"
                let _v455 = v459 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v462 : string = $"%A{v454}"
                let _v455 = v462 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v465 : string = $"%A{v454}"
                let _v455 = v465 
                #endif
#if FABLE_COMPILER_PYTHON
                let v468 : string = $"%A{v454}"
                let _v455 = v468 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v471 : string = $"%A{v454}"
                let _v455 = v471 
                #endif
#else
                let v474 : string = $"{v454.GetType ()}: {v454.Message}"
                let _v455 = v474 
                #endif
                let v475 : string = _v455 
                let v480 : unit = ()
                let v481 : (unit -> unit) = closure5(v1, v475)
                let v482 : unit = (fun () -> v481 (); v480) ()
                return false 
                (*
                ()
            *)
            (*
            let v522 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v691 : Async<bool> = _v352 
    let _v2 = v691 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v692 : unit = ()
    let _v692 =
        async {
            let v695 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v695 = v695 
            let v696 : System.Threading.CancellationToken = v695 
            let v697 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v698 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v697 = v698 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v701 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v697 = v701 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v704 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v697 = v704 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v707 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v697 = v707 
            #endif
#if FABLE_COMPILER_PYTHON
            let v710 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v697 = v710 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v713 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v697 = v713 
            #endif
#else
            let v716 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v697 = v716 
            #endif
            let v717 : System_Net_Sockets_TcpClient = _v697 
            use v717 = v717 
            let v722 : System_Net_Sockets_TcpClient = v717 
            try
            let v723 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v724 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v723 = v724 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v727 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v723 = v727 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v730 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v723 = v730 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v733 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v723 = v733 
            #endif
#if FABLE_COMPILER_PYTHON
            let v736 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v723 = v736 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v739 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v723 = v739 
            #endif
#else
            let v742 : System.Threading.Tasks.ValueTask = v722.ConnectAsync (v0, v1, v696)
            let _v723 = v742 
            #endif
            let v743 : System.Threading.Tasks.ValueTask = _v723 
            let v748 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v749 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v748 = v749 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v752 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v748 = v752 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v755 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v748 = v755 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v758 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v748 = v758 
            #endif
#if FABLE_COMPILER_PYTHON
            let v761 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v748 = v761 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v764 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v748 = v764 
            #endif
#else
            let v767 : (unit -> System.Threading.Tasks.Task) = v743.AsTask
            let v768 : System.Threading.Tasks.Task = v767 ()
            let _v748 = v768 
            #endif
            let v769 : System.Threading.Tasks.Task = _v748 
            let v774 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v775 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v776 : Async<unit> = v775 v769
            let _v774 = v776 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v777 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v778 : Async<unit> = v777 v769
            let _v774 = v778 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v779 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v780 : Async<unit> = v779 v769
            let _v774 = v780 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v781 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v782 : Async<unit> = v781 v769
            let _v774 = v782 
            #endif
#if FABLE_COMPILER_PYTHON
            let v783 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v784 : Async<unit> = v783 v769
            let _v774 = v784 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v785 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v786 : Async<unit> = v785 v769
            let _v774 = v786 
            #endif
#else
            let v787 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v788 : Async<unit> = v787 v769
            let _v774 = v788 
            #endif
            let v789 : Async<unit> = _v774 
            do! v789 
            return true 
            with ex ->
                let v794 : exn = ex
                let v795 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v796 : string = $"%A{v794}"
                let _v795 = v796 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v799 : string = $"%A{v794}"
                let _v795 = v799 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v802 : string = $"%A{v794}"
                let _v795 = v802 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v805 : string = $"%A{v794}"
                let _v795 = v805 
                #endif
#if FABLE_COMPILER_PYTHON
                let v808 : string = $"%A{v794}"
                let _v795 = v808 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v811 : string = $"%A{v794}"
                let _v795 = v811 
                #endif
#else
                let v814 : string = $"{v794.GetType ()}: {v794.Message}"
                let _v795 = v814 
                #endif
                let v815 : string = _v795 
                let v820 : unit = ()
                let v821 : (unit -> unit) = closure5(v1, v815)
                let v822 : unit = (fun () -> v821 (); v820) ()
                return false 
                (*
                ()
            *)
            (*
            let v862 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1031 : Async<bool> = _v692 
    let _v2 = v1031 
    #endif
#else
    let v1032 : unit = ()
    let _v1032 =
        async {
            let v1035 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v1035 = v1035 
            let v1036 : System.Threading.CancellationToken = v1035 
            let v1037 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1038 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1037 = v1038 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1041 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1037 = v1041 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1044 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1037 = v1044 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1047 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1037 = v1047 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1050 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1037 = v1050 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1053 : System_Net_Sockets_TcpClient = null |> unbox<System_Net_Sockets_TcpClient>
            let _v1037 = v1053 
            #endif
#else
            let v1056 : System_Net_Sockets_TcpClient = new System_Net_Sockets_TcpClient ()
            let _v1037 = v1056 
            #endif
            let v1057 : System_Net_Sockets_TcpClient = _v1037 
            use v1057 = v1057 
            let v1062 : System_Net_Sockets_TcpClient = v1057 
            try
            let v1063 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1064 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1063 = v1064 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1067 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1063 = v1067 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1070 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1063 = v1070 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1073 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1063 = v1073 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1076 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1063 = v1076 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1079 : System.Threading.Tasks.ValueTask = null |> unbox<System.Threading.Tasks.ValueTask>
            let _v1063 = v1079 
            #endif
#else
            let v1082 : System.Threading.Tasks.ValueTask = v1062.ConnectAsync (v0, v1, v1036)
            let _v1063 = v1082 
            #endif
            let v1083 : System.Threading.Tasks.ValueTask = _v1063 
            let v1088 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1089 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1088 = v1089 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1092 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1088 = v1092 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1095 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1088 = v1095 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1098 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1088 = v1098 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1101 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1088 = v1101 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1104 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
            let _v1088 = v1104 
            #endif
#else
            let v1107 : (unit -> System.Threading.Tasks.Task) = v1083.AsTask
            let v1108 : System.Threading.Tasks.Task = v1107 ()
            let _v1088 = v1108 
            #endif
            let v1109 : System.Threading.Tasks.Task = _v1088 
            let v1114 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1115 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1116 : Async<unit> = v1115 v1109
            let _v1114 = v1116 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1117 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1118 : Async<unit> = v1117 v1109
            let _v1114 = v1118 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1119 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1120 : Async<unit> = v1119 v1109
            let _v1114 = v1120 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1121 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1122 : Async<unit> = v1121 v1109
            let _v1114 = v1122 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1123 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1124 : Async<unit> = v1123 v1109
            let _v1114 = v1124 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1125 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1126 : Async<unit> = v1125 v1109
            let _v1114 = v1126 
            #endif
#else
            let v1127 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
            let v1128 : Async<unit> = v1127 v1109
            let _v1114 = v1128 
            #endif
            let v1129 : Async<unit> = _v1114 
            do! v1129 
            return true 
            with ex ->
                let v1134 : exn = ex
                let v1135 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1136 : string = $"%A{v1134}"
                let _v1135 = v1136 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1139 : string = $"%A{v1134}"
                let _v1135 = v1139 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1142 : string = $"%A{v1134}"
                let _v1135 = v1142 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1145 : string = $"%A{v1134}"
                let _v1135 = v1145 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1148 : string = $"%A{v1134}"
                let _v1135 = v1148 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v1151 : string = $"%A{v1134}"
                let _v1135 = v1151 
                #endif
#else
                let v1154 : string = $"{v1134.GetType ()}: {v1134.Message}"
                let _v1135 = v1154 
                #endif
                let v1155 : string = _v1135 
                let v1160 : unit = ()
                let v1161 : (unit -> unit) = closure5(v1, v1155)
                let v1162 : unit = (fun () -> v1161 (); v1160) ()
                return false 
                (*
                ()
            *)
            (*
            let v1202 : bool = *)
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1371 : Async<bool> = _v1032 
    let _v2 = v1371 
    #endif
    let v1372 : Async<bool> = _v2 
    v1372
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
            let v16 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v16 = v17 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v16 = v20 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v23 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v16 = v23 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v26 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16 = v26 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16 = v27 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v28 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16 = v28 
            #endif
#else
            let v29 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16 = v29 
            #endif
            let v30 : Async<Async<bool>> = _v16 
            let! v30 = v30 
            let v35 : Async<bool> = v30 
            let v36 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v37 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38 : Async<Choice<bool, exn>> = v37 v35
            let _v36 = v38 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v39 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v40 : Async<Choice<bool, exn>> = v39 v35
            let _v36 = v40 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v41 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v42 : Async<Choice<bool, exn>> = v41 v35
            let _v36 = v42 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v43 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v44 : Async<Choice<bool, exn>> = v43 v35
            let _v36 = v44 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v46 : Async<Choice<bool, exn>> = v45 v35
            let _v36 = v46 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v47 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v48 : Async<Choice<bool, exn>> = v47 v35
            let _v36 = v48 
            #endif
#else
            let v49 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v50 : Async<Choice<bool, exn>> = v49 v35
            let _v36 = v50 
            #endif
            let v51 : Async<Choice<bool, exn>> = _v36 
            let v56 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v57 : Async<US7> = null |> unbox<Async<US7>>
            let _v56 = v57 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v60 : Async<US7> = null |> unbox<Async<US7>>
            let _v56 = v60 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v63 : Async<US7> = null |> unbox<Async<US7>>
            let _v56 = v63 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v66 : unit = ()
            let _v66 =
                async {
                    let! v51 = v51 
                    let v69 : Choice<bool, exn> = v51 
                    let v70 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v71 : US7 = null |> unbox<US7>
                    let _v70 = v71 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v74 : US7 = null |> unbox<US7>
                    let _v70 = v74 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v77 : US7 = null |> unbox<US7>
                    let _v70 = v77 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v80 : US7 = null |> unbox<US7>
                    let _v70 = v80 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v83 : US7 = null |> unbox<US7>
                    let _v70 = v83 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v86 : (bool -> US7) = method22()
                    let v87 : (exn -> US7) = method23()
                    let v88 : US7 = match v69 with Choice1Of2 x -> v86 x | Choice2Of2 x -> v87 x
                    let _v70 = v88 
                    #endif
#else
                    let v89 : (bool -> US7) = method22()
                    let v90 : (exn -> US7) = method23()
                    let v91 : US7 = match v69 with Choice1Of2 x -> v89 x | Choice2Of2 x -> v90 x
                    let _v70 = v91 
                    #endif
                    let v92 : US7 = _v70 
                    return v92 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v125 : Async<US7> = _v66 
            let _v56 = v125 
            #endif
#if FABLE_COMPILER_PYTHON
            let v126 : unit = ()
            let _v126 =
                async {
                    let! v51 = v51 
                    let v129 : Choice<bool, exn> = v51 
                    let v130 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v131 : US7 = null |> unbox<US7>
                    let _v130 = v131 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v134 : US7 = null |> unbox<US7>
                    let _v130 = v134 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v137 : US7 = null |> unbox<US7>
                    let _v130 = v137 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v140 : US7 = null |> unbox<US7>
                    let _v130 = v140 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v143 : US7 = null |> unbox<US7>
                    let _v130 = v143 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v146 : (bool -> US7) = method22()
                    let v147 : (exn -> US7) = method23()
                    let v148 : US7 = match v129 with Choice1Of2 x -> v146 x | Choice2Of2 x -> v147 x
                    let _v130 = v148 
                    #endif
#else
                    let v149 : (bool -> US7) = method22()
                    let v150 : (exn -> US7) = method23()
                    let v151 : US7 = match v129 with Choice1Of2 x -> v149 x | Choice2Of2 x -> v150 x
                    let _v130 = v151 
                    #endif
                    let v152 : US7 = _v130 
                    return v152 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v185 : Async<US7> = _v126 
            let _v56 = v185 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v186 : unit = ()
            let _v186 =
                async {
                    let! v51 = v51 
                    let v189 : Choice<bool, exn> = v51 
                    let v190 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v191 : US7 = null |> unbox<US7>
                    let _v190 = v191 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v194 : US7 = null |> unbox<US7>
                    let _v190 = v194 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v197 : US7 = null |> unbox<US7>
                    let _v190 = v197 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v200 : US7 = null |> unbox<US7>
                    let _v190 = v200 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v203 : US7 = null |> unbox<US7>
                    let _v190 = v203 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v206 : (bool -> US7) = method22()
                    let v207 : (exn -> US7) = method23()
                    let v208 : US7 = match v189 with Choice1Of2 x -> v206 x | Choice2Of2 x -> v207 x
                    let _v190 = v208 
                    #endif
#else
                    let v209 : (bool -> US7) = method22()
                    let v210 : (exn -> US7) = method23()
                    let v211 : US7 = match v189 with Choice1Of2 x -> v209 x | Choice2Of2 x -> v210 x
                    let _v190 = v211 
                    #endif
                    let v212 : US7 = _v190 
                    return v212 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v245 : Async<US7> = _v186 
            let _v56 = v245 
            #endif
#else
            let v246 : unit = ()
            let _v246 =
                async {
                    let! v51 = v51 
                    let v249 : Choice<bool, exn> = v51 
                    let v250 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v251 : US7 = null |> unbox<US7>
                    let _v250 = v251 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v254 : US7 = null |> unbox<US7>
                    let _v250 = v254 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : US7 = null |> unbox<US7>
                    let _v250 = v257 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v260 : US7 = null |> unbox<US7>
                    let _v250 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v263 : US7 = null |> unbox<US7>
                    let _v250 = v263 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v266 : (bool -> US7) = method22()
                    let v267 : (exn -> US7) = method23()
                    let v268 : US7 = match v249 with Choice1Of2 x -> v266 x | Choice2Of2 x -> v267 x
                    let _v250 = v268 
                    #endif
#else
                    let v269 : (bool -> US7) = method22()
                    let v270 : (exn -> US7) = method23()
                    let v271 : US7 = match v249 with Choice1Of2 x -> v269 x | Choice2Of2 x -> v270 x
                    let _v250 = v271 
                    #endif
                    let v272 : US7 = _v250 
                    return v272 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v305 : Async<US7> = _v246 
            let _v56 = v305 
            #endif
            let v306 : Async<US7> = _v56 
            let v368 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v369 : Async<US8> = null |> unbox<Async<US8>>
            let _v368 = v369 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v372 : Async<US8> = null |> unbox<Async<US8>>
            let _v368 = v372 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v375 : Async<US8> = null |> unbox<Async<US8>>
            let _v368 = v375 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v378 : unit = ()
            let _v378 =
                async {
                    let! v306 = v306 
                    let v381 : US7 = v306 
                    let v387 : US8 =
                        match v381 with
                        | US7_0(v382) -> (* C1of2 *)
                            US8_0(v382)
                        | US7_1(v384) -> (* C2of2 *)
                            US8_1(v384)
                    return v387 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v395 : Async<US8> = _v378 
            let _v368 = v395 
            #endif
#if FABLE_COMPILER_PYTHON
            let v396 : unit = ()
            let _v396 =
                async {
                    let! v306 = v306 
                    let v399 : US7 = v306 
                    let v405 : US8 =
                        match v399 with
                        | US7_0(v400) -> (* C1of2 *)
                            US8_0(v400)
                        | US7_1(v402) -> (* C2of2 *)
                            US8_1(v402)
                    return v405 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v413 : Async<US8> = _v396 
            let _v368 = v413 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v414 : unit = ()
            let _v414 =
                async {
                    let! v306 = v306 
                    let v417 : US7 = v306 
                    let v423 : US8 =
                        match v417 with
                        | US7_0(v418) -> (* C1of2 *)
                            US8_0(v418)
                        | US7_1(v420) -> (* C2of2 *)
                            US8_1(v420)
                    return v423 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v431 : Async<US8> = _v414 
            let _v368 = v431 
            #endif
#else
            let v432 : unit = ()
            let _v432 =
                async {
                    let! v306 = v306 
                    let v435 : US7 = v306 
                    let v441 : US8 =
                        match v435 with
                        | US7_0(v436) -> (* C1of2 *)
                            US8_0(v436)
                        | US7_1(v438) -> (* C2of2 *)
                            US8_1(v438)
                    return v441 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v449 : Async<US8> = _v432 
            let _v368 = v449 
            #endif
            let v450 : Async<US8> = _v368 
            let v470 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v471 : Async<US6> = null |> unbox<Async<US6>>
            let _v470 = v471 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v474 : Async<US6> = null |> unbox<Async<US6>>
            let _v470 = v474 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v477 : Async<US6> = null |> unbox<Async<US6>>
            let _v470 = v477 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v480 : unit = ()
            let _v480 =
                async {
                    let! v450 = v450 
                    let v483 : US8 = v450 
                    let v607 : US6 =
                        match v483 with
                        | US8_1(v486) -> (* Error *)
                            let v487 : string = $"%A{v486}"
                            let v490 : string = "System.TimeoutException"
                            let v491 : bool = v487.Contains v490 
                            if v491 then
                                let v494 : unit = ()
                                let v495 : (unit -> unit) = closure16(v0)
                                let v496 : unit = (fun () -> v495 (); v494) ()
                                US6_1
                            else
                                let v537 : unit = ()
                                let v538 : (unit -> unit) = closure17(v0, v486)
                                let v539 : unit = (fun () -> v538 (); v537) ()
                                US6_1
                        | US8_0(v484) -> (* Ok *)
                            US6_0(v484)
                    return v607 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v733 : Async<US6> = _v480 
            let _v470 = v733 
            #endif
#if FABLE_COMPILER_PYTHON
            let v734 : unit = ()
            let _v734 =
                async {
                    let! v450 = v450 
                    let v737 : US8 = v450 
                    let v861 : US6 =
                        match v737 with
                        | US8_1(v740) -> (* Error *)
                            let v741 : string = $"%A{v740}"
                            let v744 : string = "System.TimeoutException"
                            let v745 : bool = v741.Contains v744 
                            if v745 then
                                let v748 : unit = ()
                                let v749 : (unit -> unit) = closure16(v0)
                                let v750 : unit = (fun () -> v749 (); v748) ()
                                US6_1
                            else
                                let v791 : unit = ()
                                let v792 : (unit -> unit) = closure17(v0, v740)
                                let v793 : unit = (fun () -> v792 (); v791) ()
                                US6_1
                        | US8_0(v738) -> (* Ok *)
                            US6_0(v738)
                    return v861 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v987 : Async<US6> = _v734 
            let _v470 = v987 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v988 : unit = ()
            let _v988 =
                async {
                    let! v450 = v450 
                    let v991 : US8 = v450 
                    let v1115 : US6 =
                        match v991 with
                        | US8_1(v994) -> (* Error *)
                            let v995 : string = $"%A{v994}"
                            let v998 : string = "System.TimeoutException"
                            let v999 : bool = v995.Contains v998 
                            if v999 then
                                let v1002 : unit = ()
                                let v1003 : (unit -> unit) = closure16(v0)
                                let v1004 : unit = (fun () -> v1003 (); v1002) ()
                                US6_1
                            else
                                let v1045 : unit = ()
                                let v1046 : (unit -> unit) = closure17(v0, v994)
                                let v1047 : unit = (fun () -> v1046 (); v1045) ()
                                US6_1
                        | US8_0(v992) -> (* Ok *)
                            US6_0(v992)
                    return v1115 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1241 : Async<US6> = _v988 
            let _v470 = v1241 
            #endif
#else
            let v1242 : unit = ()
            let _v1242 =
                async {
                    let! v450 = v450 
                    let v1245 : US8 = v450 
                    let v1369 : US6 =
                        match v1245 with
                        | US8_1(v1248) -> (* Error *)
                            let v1249 : string = $"%A{v1248}"
                            let v1252 : string = "System.TimeoutException"
                            let v1253 : bool = v1249.Contains v1252 
                            if v1253 then
                                let v1256 : unit = ()
                                let v1257 : (unit -> unit) = closure16(v0)
                                let v1258 : unit = (fun () -> v1257 (); v1256) ()
                                US6_1
                            else
                                let v1299 : unit = ()
                                let v1300 : (unit -> unit) = closure17(v0, v1248)
                                let v1301 : unit = (fun () -> v1300 (); v1299) ()
                                US6_1
                        | US8_0(v1246) -> (* Ok *)
                            US6_0(v1246)
                    return v1369 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1495 : Async<US6> = _v1242 
            let _v470 = v1495 
            #endif
            let v1496 : Async<US6> = _v470 
            return! v1496 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3488 : Async<US6> = _v13 
    let _v3 = v3488 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3489 : unit = ()
    let _v3489 =
        async {
            let v3492 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3493 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3492 = v3493 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3496 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3492 = v3496 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3499 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v3492 = v3499 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3502 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3492 = v3502 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3503 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3492 = v3503 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3504 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3492 = v3504 
            #endif
#else
            let v3505 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3492 = v3505 
            #endif
            let v3506 : Async<Async<bool>> = _v3492 
            let! v3506 = v3506 
            let v3511 : Async<bool> = v3506 
            let v3512 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3513 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3514 : Async<Choice<bool, exn>> = v3513 v3511
            let _v3512 = v3514 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3515 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3516 : Async<Choice<bool, exn>> = v3515 v3511
            let _v3512 = v3516 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3517 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3518 : Async<Choice<bool, exn>> = v3517 v3511
            let _v3512 = v3518 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3519 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3520 : Async<Choice<bool, exn>> = v3519 v3511
            let _v3512 = v3520 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3521 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3522 : Async<Choice<bool, exn>> = v3521 v3511
            let _v3512 = v3522 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3523 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3524 : Async<Choice<bool, exn>> = v3523 v3511
            let _v3512 = v3524 
            #endif
#else
            let v3525 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3526 : Async<Choice<bool, exn>> = v3525 v3511
            let _v3512 = v3526 
            #endif
            let v3527 : Async<Choice<bool, exn>> = _v3512 
            let v3532 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3533 : Async<US7> = null |> unbox<Async<US7>>
            let _v3532 = v3533 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3536 : Async<US7> = null |> unbox<Async<US7>>
            let _v3532 = v3536 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3539 : Async<US7> = null |> unbox<Async<US7>>
            let _v3532 = v3539 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3542 : unit = ()
            let _v3542 =
                async {
                    let! v3527 = v3527 
                    let v3545 : Choice<bool, exn> = v3527 
                    let v3546 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3547 : US7 = null |> unbox<US7>
                    let _v3546 = v3547 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3550 : US7 = null |> unbox<US7>
                    let _v3546 = v3550 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3553 : US7 = null |> unbox<US7>
                    let _v3546 = v3553 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3556 : US7 = null |> unbox<US7>
                    let _v3546 = v3556 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3559 : US7 = null |> unbox<US7>
                    let _v3546 = v3559 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3562 : (bool -> US7) = method22()
                    let v3563 : (exn -> US7) = method23()
                    let v3564 : US7 = match v3545 with Choice1Of2 x -> v3562 x | Choice2Of2 x -> v3563 x
                    let _v3546 = v3564 
                    #endif
#else
                    let v3565 : (bool -> US7) = method22()
                    let v3566 : (exn -> US7) = method23()
                    let v3567 : US7 = match v3545 with Choice1Of2 x -> v3565 x | Choice2Of2 x -> v3566 x
                    let _v3546 = v3567 
                    #endif
                    let v3568 : US7 = _v3546 
                    return v3568 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3601 : Async<US7> = _v3542 
            let _v3532 = v3601 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3602 : unit = ()
            let _v3602 =
                async {
                    let! v3527 = v3527 
                    let v3605 : Choice<bool, exn> = v3527 
                    let v3606 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3607 : US7 = null |> unbox<US7>
                    let _v3606 = v3607 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3610 : US7 = null |> unbox<US7>
                    let _v3606 = v3610 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3613 : US7 = null |> unbox<US7>
                    let _v3606 = v3613 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3616 : US7 = null |> unbox<US7>
                    let _v3606 = v3616 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3619 : US7 = null |> unbox<US7>
                    let _v3606 = v3619 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3622 : (bool -> US7) = method22()
                    let v3623 : (exn -> US7) = method23()
                    let v3624 : US7 = match v3605 with Choice1Of2 x -> v3622 x | Choice2Of2 x -> v3623 x
                    let _v3606 = v3624 
                    #endif
#else
                    let v3625 : (bool -> US7) = method22()
                    let v3626 : (exn -> US7) = method23()
                    let v3627 : US7 = match v3605 with Choice1Of2 x -> v3625 x | Choice2Of2 x -> v3626 x
                    let _v3606 = v3627 
                    #endif
                    let v3628 : US7 = _v3606 
                    return v3628 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3661 : Async<US7> = _v3602 
            let _v3532 = v3661 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3662 : unit = ()
            let _v3662 =
                async {
                    let! v3527 = v3527 
                    let v3665 : Choice<bool, exn> = v3527 
                    let v3666 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3667 : US7 = null |> unbox<US7>
                    let _v3666 = v3667 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3670 : US7 = null |> unbox<US7>
                    let _v3666 = v3670 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3673 : US7 = null |> unbox<US7>
                    let _v3666 = v3673 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3676 : US7 = null |> unbox<US7>
                    let _v3666 = v3676 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3679 : US7 = null |> unbox<US7>
                    let _v3666 = v3679 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3682 : (bool -> US7) = method22()
                    let v3683 : (exn -> US7) = method23()
                    let v3684 : US7 = match v3665 with Choice1Of2 x -> v3682 x | Choice2Of2 x -> v3683 x
                    let _v3666 = v3684 
                    #endif
#else
                    let v3685 : (bool -> US7) = method22()
                    let v3686 : (exn -> US7) = method23()
                    let v3687 : US7 = match v3665 with Choice1Of2 x -> v3685 x | Choice2Of2 x -> v3686 x
                    let _v3666 = v3687 
                    #endif
                    let v3688 : US7 = _v3666 
                    return v3688 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3721 : Async<US7> = _v3662 
            let _v3532 = v3721 
            #endif
#else
            let v3722 : unit = ()
            let _v3722 =
                async {
                    let! v3527 = v3527 
                    let v3725 : Choice<bool, exn> = v3527 
                    let v3726 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3727 : US7 = null |> unbox<US7>
                    let _v3726 = v3727 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3730 : US7 = null |> unbox<US7>
                    let _v3726 = v3730 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3733 : US7 = null |> unbox<US7>
                    let _v3726 = v3733 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3736 : US7 = null |> unbox<US7>
                    let _v3726 = v3736 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3739 : US7 = null |> unbox<US7>
                    let _v3726 = v3739 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3742 : (bool -> US7) = method22()
                    let v3743 : (exn -> US7) = method23()
                    let v3744 : US7 = match v3725 with Choice1Of2 x -> v3742 x | Choice2Of2 x -> v3743 x
                    let _v3726 = v3744 
                    #endif
#else
                    let v3745 : (bool -> US7) = method22()
                    let v3746 : (exn -> US7) = method23()
                    let v3747 : US7 = match v3725 with Choice1Of2 x -> v3745 x | Choice2Of2 x -> v3746 x
                    let _v3726 = v3747 
                    #endif
                    let v3748 : US7 = _v3726 
                    return v3748 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3781 : Async<US7> = _v3722 
            let _v3532 = v3781 
            #endif
            let v3782 : Async<US7> = _v3532 
            let v3844 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3845 : Async<US8> = null |> unbox<Async<US8>>
            let _v3844 = v3845 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3848 : Async<US8> = null |> unbox<Async<US8>>
            let _v3844 = v3848 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3851 : Async<US8> = null |> unbox<Async<US8>>
            let _v3844 = v3851 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3854 : unit = ()
            let _v3854 =
                async {
                    let! v3782 = v3782 
                    let v3857 : US7 = v3782 
                    let v3863 : US8 =
                        match v3857 with
                        | US7_0(v3858) -> (* C1of2 *)
                            US8_0(v3858)
                        | US7_1(v3860) -> (* C2of2 *)
                            US8_1(v3860)
                    return v3863 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3871 : Async<US8> = _v3854 
            let _v3844 = v3871 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3872 : unit = ()
            let _v3872 =
                async {
                    let! v3782 = v3782 
                    let v3875 : US7 = v3782 
                    let v3881 : US8 =
                        match v3875 with
                        | US7_0(v3876) -> (* C1of2 *)
                            US8_0(v3876)
                        | US7_1(v3878) -> (* C2of2 *)
                            US8_1(v3878)
                    return v3881 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3889 : Async<US8> = _v3872 
            let _v3844 = v3889 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3890 : unit = ()
            let _v3890 =
                async {
                    let! v3782 = v3782 
                    let v3893 : US7 = v3782 
                    let v3899 : US8 =
                        match v3893 with
                        | US7_0(v3894) -> (* C1of2 *)
                            US8_0(v3894)
                        | US7_1(v3896) -> (* C2of2 *)
                            US8_1(v3896)
                    return v3899 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3907 : Async<US8> = _v3890 
            let _v3844 = v3907 
            #endif
#else
            let v3908 : unit = ()
            let _v3908 =
                async {
                    let! v3782 = v3782 
                    let v3911 : US7 = v3782 
                    let v3917 : US8 =
                        match v3911 with
                        | US7_0(v3912) -> (* C1of2 *)
                            US8_0(v3912)
                        | US7_1(v3914) -> (* C2of2 *)
                            US8_1(v3914)
                    return v3917 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3925 : Async<US8> = _v3908 
            let _v3844 = v3925 
            #endif
            let v3926 : Async<US8> = _v3844 
            let v3946 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3947 : Async<US6> = null |> unbox<Async<US6>>
            let _v3946 = v3947 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3950 : Async<US6> = null |> unbox<Async<US6>>
            let _v3946 = v3950 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3953 : Async<US6> = null |> unbox<Async<US6>>
            let _v3946 = v3953 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3956 : unit = ()
            let _v3956 =
                async {
                    let! v3926 = v3926 
                    let v3959 : US8 = v3926 
                    let v4083 : US6 =
                        match v3959 with
                        | US8_1(v3962) -> (* Error *)
                            let v3963 : string = $"%A{v3962}"
                            let v3966 : string = "System.TimeoutException"
                            let v3967 : bool = v3963.Contains v3966 
                            if v3967 then
                                let v3970 : unit = ()
                                let v3971 : (unit -> unit) = closure16(v0)
                                let v3972 : unit = (fun () -> v3971 (); v3970) ()
                                US6_1
                            else
                                let v4013 : unit = ()
                                let v4014 : (unit -> unit) = closure17(v0, v3962)
                                let v4015 : unit = (fun () -> v4014 (); v4013) ()
                                US6_1
                        | US8_0(v3960) -> (* Ok *)
                            US6_0(v3960)
                    return v4083 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4209 : Async<US6> = _v3956 
            let _v3946 = v4209 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4210 : unit = ()
            let _v4210 =
                async {
                    let! v3926 = v3926 
                    let v4213 : US8 = v3926 
                    let v4337 : US6 =
                        match v4213 with
                        | US8_1(v4216) -> (* Error *)
                            let v4217 : string = $"%A{v4216}"
                            let v4220 : string = "System.TimeoutException"
                            let v4221 : bool = v4217.Contains v4220 
                            if v4221 then
                                let v4224 : unit = ()
                                let v4225 : (unit -> unit) = closure16(v0)
                                let v4226 : unit = (fun () -> v4225 (); v4224) ()
                                US6_1
                            else
                                let v4267 : unit = ()
                                let v4268 : (unit -> unit) = closure17(v0, v4216)
                                let v4269 : unit = (fun () -> v4268 (); v4267) ()
                                US6_1
                        | US8_0(v4214) -> (* Ok *)
                            US6_0(v4214)
                    return v4337 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4463 : Async<US6> = _v4210 
            let _v3946 = v4463 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4464 : unit = ()
            let _v4464 =
                async {
                    let! v3926 = v3926 
                    let v4467 : US8 = v3926 
                    let v4591 : US6 =
                        match v4467 with
                        | US8_1(v4470) -> (* Error *)
                            let v4471 : string = $"%A{v4470}"
                            let v4474 : string = "System.TimeoutException"
                            let v4475 : bool = v4471.Contains v4474 
                            if v4475 then
                                let v4478 : unit = ()
                                let v4479 : (unit -> unit) = closure16(v0)
                                let v4480 : unit = (fun () -> v4479 (); v4478) ()
                                US6_1
                            else
                                let v4521 : unit = ()
                                let v4522 : (unit -> unit) = closure17(v0, v4470)
                                let v4523 : unit = (fun () -> v4522 (); v4521) ()
                                US6_1
                        | US8_0(v4468) -> (* Ok *)
                            US6_0(v4468)
                    return v4591 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4717 : Async<US6> = _v4464 
            let _v3946 = v4717 
            #endif
#else
            let v4718 : unit = ()
            let _v4718 =
                async {
                    let! v3926 = v3926 
                    let v4721 : US8 = v3926 
                    let v4845 : US6 =
                        match v4721 with
                        | US8_1(v4724) -> (* Error *)
                            let v4725 : string = $"%A{v4724}"
                            let v4728 : string = "System.TimeoutException"
                            let v4729 : bool = v4725.Contains v4728 
                            if v4729 then
                                let v4732 : unit = ()
                                let v4733 : (unit -> unit) = closure16(v0)
                                let v4734 : unit = (fun () -> v4733 (); v4732) ()
                                US6_1
                            else
                                let v4775 : unit = ()
                                let v4776 : (unit -> unit) = closure17(v0, v4724)
                                let v4777 : unit = (fun () -> v4776 (); v4775) ()
                                US6_1
                        | US8_0(v4722) -> (* Ok *)
                            US6_0(v4722)
                    return v4845 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4971 : Async<US6> = _v4718 
            let _v3946 = v4971 
            #endif
            let v4972 : Async<US6> = _v3946 
            return! v4972 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v6964 : Async<US6> = _v3489 
    let _v3 = v6964 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v6965 : unit = ()
    let _v6965 =
        async {
            let v6968 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6969 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6968 = v6969 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6972 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6968 = v6972 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6975 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v6968 = v6975 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6978 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6968 = v6978 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6979 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6968 = v6979 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6980 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6968 = v6980 
            #endif
#else
            let v6981 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6968 = v6981 
            #endif
            let v6982 : Async<Async<bool>> = _v6968 
            let! v6982 = v6982 
            let v6987 : Async<bool> = v6982 
            let v6988 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6989 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6990 : Async<Choice<bool, exn>> = v6989 v6987
            let _v6988 = v6990 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6991 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6992 : Async<Choice<bool, exn>> = v6991 v6987
            let _v6988 = v6992 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6993 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6994 : Async<Choice<bool, exn>> = v6993 v6987
            let _v6988 = v6994 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6995 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6996 : Async<Choice<bool, exn>> = v6995 v6987
            let _v6988 = v6996 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6997 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6998 : Async<Choice<bool, exn>> = v6997 v6987
            let _v6988 = v6998 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6999 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7000 : Async<Choice<bool, exn>> = v6999 v6987
            let _v6988 = v7000 
            #endif
#else
            let v7001 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7002 : Async<Choice<bool, exn>> = v7001 v6987
            let _v6988 = v7002 
            #endif
            let v7003 : Async<Choice<bool, exn>> = _v6988 
            let v7008 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7009 : Async<US7> = null |> unbox<Async<US7>>
            let _v7008 = v7009 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7012 : Async<US7> = null |> unbox<Async<US7>>
            let _v7008 = v7012 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7015 : Async<US7> = null |> unbox<Async<US7>>
            let _v7008 = v7015 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7018 : unit = ()
            let _v7018 =
                async {
                    let! v7003 = v7003 
                    let v7021 : Choice<bool, exn> = v7003 
                    let v7022 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7023 : US7 = null |> unbox<US7>
                    let _v7022 = v7023 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7026 : US7 = null |> unbox<US7>
                    let _v7022 = v7026 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7029 : US7 = null |> unbox<US7>
                    let _v7022 = v7029 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7032 : US7 = null |> unbox<US7>
                    let _v7022 = v7032 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7035 : US7 = null |> unbox<US7>
                    let _v7022 = v7035 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7038 : (bool -> US7) = method22()
                    let v7039 : (exn -> US7) = method23()
                    let v7040 : US7 = match v7021 with Choice1Of2 x -> v7038 x | Choice2Of2 x -> v7039 x
                    let _v7022 = v7040 
                    #endif
#else
                    let v7041 : (bool -> US7) = method22()
                    let v7042 : (exn -> US7) = method23()
                    let v7043 : US7 = match v7021 with Choice1Of2 x -> v7041 x | Choice2Of2 x -> v7042 x
                    let _v7022 = v7043 
                    #endif
                    let v7044 : US7 = _v7022 
                    return v7044 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7077 : Async<US7> = _v7018 
            let _v7008 = v7077 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7078 : unit = ()
            let _v7078 =
                async {
                    let! v7003 = v7003 
                    let v7081 : Choice<bool, exn> = v7003 
                    let v7082 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7083 : US7 = null |> unbox<US7>
                    let _v7082 = v7083 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7086 : US7 = null |> unbox<US7>
                    let _v7082 = v7086 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7089 : US7 = null |> unbox<US7>
                    let _v7082 = v7089 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7092 : US7 = null |> unbox<US7>
                    let _v7082 = v7092 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7095 : US7 = null |> unbox<US7>
                    let _v7082 = v7095 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7098 : (bool -> US7) = method22()
                    let v7099 : (exn -> US7) = method23()
                    let v7100 : US7 = match v7081 with Choice1Of2 x -> v7098 x | Choice2Of2 x -> v7099 x
                    let _v7082 = v7100 
                    #endif
#else
                    let v7101 : (bool -> US7) = method22()
                    let v7102 : (exn -> US7) = method23()
                    let v7103 : US7 = match v7081 with Choice1Of2 x -> v7101 x | Choice2Of2 x -> v7102 x
                    let _v7082 = v7103 
                    #endif
                    let v7104 : US7 = _v7082 
                    return v7104 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7137 : Async<US7> = _v7078 
            let _v7008 = v7137 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7138 : unit = ()
            let _v7138 =
                async {
                    let! v7003 = v7003 
                    let v7141 : Choice<bool, exn> = v7003 
                    let v7142 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7143 : US7 = null |> unbox<US7>
                    let _v7142 = v7143 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7146 : US7 = null |> unbox<US7>
                    let _v7142 = v7146 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7149 : US7 = null |> unbox<US7>
                    let _v7142 = v7149 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7152 : US7 = null |> unbox<US7>
                    let _v7142 = v7152 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7155 : US7 = null |> unbox<US7>
                    let _v7142 = v7155 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7158 : (bool -> US7) = method22()
                    let v7159 : (exn -> US7) = method23()
                    let v7160 : US7 = match v7141 with Choice1Of2 x -> v7158 x | Choice2Of2 x -> v7159 x
                    let _v7142 = v7160 
                    #endif
#else
                    let v7161 : (bool -> US7) = method22()
                    let v7162 : (exn -> US7) = method23()
                    let v7163 : US7 = match v7141 with Choice1Of2 x -> v7161 x | Choice2Of2 x -> v7162 x
                    let _v7142 = v7163 
                    #endif
                    let v7164 : US7 = _v7142 
                    return v7164 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7197 : Async<US7> = _v7138 
            let _v7008 = v7197 
            #endif
#else
            let v7198 : unit = ()
            let _v7198 =
                async {
                    let! v7003 = v7003 
                    let v7201 : Choice<bool, exn> = v7003 
                    let v7202 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7203 : US7 = null |> unbox<US7>
                    let _v7202 = v7203 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7206 : US7 = null |> unbox<US7>
                    let _v7202 = v7206 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7209 : US7 = null |> unbox<US7>
                    let _v7202 = v7209 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7212 : US7 = null |> unbox<US7>
                    let _v7202 = v7212 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7215 : US7 = null |> unbox<US7>
                    let _v7202 = v7215 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7218 : (bool -> US7) = method22()
                    let v7219 : (exn -> US7) = method23()
                    let v7220 : US7 = match v7201 with Choice1Of2 x -> v7218 x | Choice2Of2 x -> v7219 x
                    let _v7202 = v7220 
                    #endif
#else
                    let v7221 : (bool -> US7) = method22()
                    let v7222 : (exn -> US7) = method23()
                    let v7223 : US7 = match v7201 with Choice1Of2 x -> v7221 x | Choice2Of2 x -> v7222 x
                    let _v7202 = v7223 
                    #endif
                    let v7224 : US7 = _v7202 
                    return v7224 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7257 : Async<US7> = _v7198 
            let _v7008 = v7257 
            #endif
            let v7258 : Async<US7> = _v7008 
            let v7320 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7321 : Async<US8> = null |> unbox<Async<US8>>
            let _v7320 = v7321 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7324 : Async<US8> = null |> unbox<Async<US8>>
            let _v7320 = v7324 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7327 : Async<US8> = null |> unbox<Async<US8>>
            let _v7320 = v7327 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7330 : unit = ()
            let _v7330 =
                async {
                    let! v7258 = v7258 
                    let v7333 : US7 = v7258 
                    let v7339 : US8 =
                        match v7333 with
                        | US7_0(v7334) -> (* C1of2 *)
                            US8_0(v7334)
                        | US7_1(v7336) -> (* C2of2 *)
                            US8_1(v7336)
                    return v7339 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7347 : Async<US8> = _v7330 
            let _v7320 = v7347 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7348 : unit = ()
            let _v7348 =
                async {
                    let! v7258 = v7258 
                    let v7351 : US7 = v7258 
                    let v7357 : US8 =
                        match v7351 with
                        | US7_0(v7352) -> (* C1of2 *)
                            US8_0(v7352)
                        | US7_1(v7354) -> (* C2of2 *)
                            US8_1(v7354)
                    return v7357 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7365 : Async<US8> = _v7348 
            let _v7320 = v7365 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7366 : unit = ()
            let _v7366 =
                async {
                    let! v7258 = v7258 
                    let v7369 : US7 = v7258 
                    let v7375 : US8 =
                        match v7369 with
                        | US7_0(v7370) -> (* C1of2 *)
                            US8_0(v7370)
                        | US7_1(v7372) -> (* C2of2 *)
                            US8_1(v7372)
                    return v7375 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7383 : Async<US8> = _v7366 
            let _v7320 = v7383 
            #endif
#else
            let v7384 : unit = ()
            let _v7384 =
                async {
                    let! v7258 = v7258 
                    let v7387 : US7 = v7258 
                    let v7393 : US8 =
                        match v7387 with
                        | US7_0(v7388) -> (* C1of2 *)
                            US8_0(v7388)
                        | US7_1(v7390) -> (* C2of2 *)
                            US8_1(v7390)
                    return v7393 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7401 : Async<US8> = _v7384 
            let _v7320 = v7401 
            #endif
            let v7402 : Async<US8> = _v7320 
            let v7422 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7423 : Async<US6> = null |> unbox<Async<US6>>
            let _v7422 = v7423 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7426 : Async<US6> = null |> unbox<Async<US6>>
            let _v7422 = v7426 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7429 : Async<US6> = null |> unbox<Async<US6>>
            let _v7422 = v7429 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7432 : unit = ()
            let _v7432 =
                async {
                    let! v7402 = v7402 
                    let v7435 : US8 = v7402 
                    let v7559 : US6 =
                        match v7435 with
                        | US8_1(v7438) -> (* Error *)
                            let v7439 : string = $"%A{v7438}"
                            let v7442 : string = "System.TimeoutException"
                            let v7443 : bool = v7439.Contains v7442 
                            if v7443 then
                                let v7446 : unit = ()
                                let v7447 : (unit -> unit) = closure16(v0)
                                let v7448 : unit = (fun () -> v7447 (); v7446) ()
                                US6_1
                            else
                                let v7489 : unit = ()
                                let v7490 : (unit -> unit) = closure17(v0, v7438)
                                let v7491 : unit = (fun () -> v7490 (); v7489) ()
                                US6_1
                        | US8_0(v7436) -> (* Ok *)
                            US6_0(v7436)
                    return v7559 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7685 : Async<US6> = _v7432 
            let _v7422 = v7685 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7686 : unit = ()
            let _v7686 =
                async {
                    let! v7402 = v7402 
                    let v7689 : US8 = v7402 
                    let v7813 : US6 =
                        match v7689 with
                        | US8_1(v7692) -> (* Error *)
                            let v7693 : string = $"%A{v7692}"
                            let v7696 : string = "System.TimeoutException"
                            let v7697 : bool = v7693.Contains v7696 
                            if v7697 then
                                let v7700 : unit = ()
                                let v7701 : (unit -> unit) = closure16(v0)
                                let v7702 : unit = (fun () -> v7701 (); v7700) ()
                                US6_1
                            else
                                let v7743 : unit = ()
                                let v7744 : (unit -> unit) = closure17(v0, v7692)
                                let v7745 : unit = (fun () -> v7744 (); v7743) ()
                                US6_1
                        | US8_0(v7690) -> (* Ok *)
                            US6_0(v7690)
                    return v7813 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7939 : Async<US6> = _v7686 
            let _v7422 = v7939 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7940 : unit = ()
            let _v7940 =
                async {
                    let! v7402 = v7402 
                    let v7943 : US8 = v7402 
                    let v8067 : US6 =
                        match v7943 with
                        | US8_1(v7946) -> (* Error *)
                            let v7947 : string = $"%A{v7946}"
                            let v7950 : string = "System.TimeoutException"
                            let v7951 : bool = v7947.Contains v7950 
                            if v7951 then
                                let v7954 : unit = ()
                                let v7955 : (unit -> unit) = closure16(v0)
                                let v7956 : unit = (fun () -> v7955 (); v7954) ()
                                US6_1
                            else
                                let v7997 : unit = ()
                                let v7998 : (unit -> unit) = closure17(v0, v7946)
                                let v7999 : unit = (fun () -> v7998 (); v7997) ()
                                US6_1
                        | US8_0(v7944) -> (* Ok *)
                            US6_0(v7944)
                    return v8067 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8193 : Async<US6> = _v7940 
            let _v7422 = v8193 
            #endif
#else
            let v8194 : unit = ()
            let _v8194 =
                async {
                    let! v7402 = v7402 
                    let v8197 : US8 = v7402 
                    let v8321 : US6 =
                        match v8197 with
                        | US8_1(v8200) -> (* Error *)
                            let v8201 : string = $"%A{v8200}"
                            let v8204 : string = "System.TimeoutException"
                            let v8205 : bool = v8201.Contains v8204 
                            if v8205 then
                                let v8208 : unit = ()
                                let v8209 : (unit -> unit) = closure16(v0)
                                let v8210 : unit = (fun () -> v8209 (); v8208) ()
                                US6_1
                            else
                                let v8251 : unit = ()
                                let v8252 : (unit -> unit) = closure17(v0, v8200)
                                let v8253 : unit = (fun () -> v8252 (); v8251) ()
                                US6_1
                        | US8_0(v8198) -> (* Ok *)
                            US6_0(v8198)
                    return v8321 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8447 : Async<US6> = _v8194 
            let _v7422 = v8447 
            #endif
            let v8448 : Async<US6> = _v7422 
            return! v8448 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v10440 : Async<US6> = _v6965 
    let _v3 = v10440 
    #endif
#else
    let v10441 : unit = ()
    let _v10441 =
        async {
            let v10444 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10445 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v10444 = v10445 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10448 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v10444 = v10448 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10451 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v10444 = v10451 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10454 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10444 = v10454 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10455 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10444 = v10455 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10456 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10444 = v10456 
            #endif
#else
            let v10457 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10444 = v10457 
            #endif
            let v10458 : Async<Async<bool>> = _v10444 
            let! v10458 = v10458 
            let v10463 : Async<bool> = v10458 
            let v10464 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10465 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10466 : Async<Choice<bool, exn>> = v10465 v10463
            let _v10464 = v10466 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10467 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10468 : Async<Choice<bool, exn>> = v10467 v10463
            let _v10464 = v10468 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10469 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10470 : Async<Choice<bool, exn>> = v10469 v10463
            let _v10464 = v10470 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10471 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10472 : Async<Choice<bool, exn>> = v10471 v10463
            let _v10464 = v10472 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10473 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10474 : Async<Choice<bool, exn>> = v10473 v10463
            let _v10464 = v10474 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10475 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10476 : Async<Choice<bool, exn>> = v10475 v10463
            let _v10464 = v10476 
            #endif
#else
            let v10477 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10478 : Async<Choice<bool, exn>> = v10477 v10463
            let _v10464 = v10478 
            #endif
            let v10479 : Async<Choice<bool, exn>> = _v10464 
            let v10484 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10485 : Async<US7> = null |> unbox<Async<US7>>
            let _v10484 = v10485 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10488 : Async<US7> = null |> unbox<Async<US7>>
            let _v10484 = v10488 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10491 : Async<US7> = null |> unbox<Async<US7>>
            let _v10484 = v10491 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10494 : unit = ()
            let _v10494 =
                async {
                    let! v10479 = v10479 
                    let v10497 : Choice<bool, exn> = v10479 
                    let v10498 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10499 : US7 = null |> unbox<US7>
                    let _v10498 = v10499 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10502 : US7 = null |> unbox<US7>
                    let _v10498 = v10502 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10505 : US7 = null |> unbox<US7>
                    let _v10498 = v10505 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10508 : US7 = null |> unbox<US7>
                    let _v10498 = v10508 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10511 : US7 = null |> unbox<US7>
                    let _v10498 = v10511 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10514 : (bool -> US7) = method22()
                    let v10515 : (exn -> US7) = method23()
                    let v10516 : US7 = match v10497 with Choice1Of2 x -> v10514 x | Choice2Of2 x -> v10515 x
                    let _v10498 = v10516 
                    #endif
#else
                    let v10517 : (bool -> US7) = method22()
                    let v10518 : (exn -> US7) = method23()
                    let v10519 : US7 = match v10497 with Choice1Of2 x -> v10517 x | Choice2Of2 x -> v10518 x
                    let _v10498 = v10519 
                    #endif
                    let v10520 : US7 = _v10498 
                    return v10520 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10553 : Async<US7> = _v10494 
            let _v10484 = v10553 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10554 : unit = ()
            let _v10554 =
                async {
                    let! v10479 = v10479 
                    let v10557 : Choice<bool, exn> = v10479 
                    let v10558 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10559 : US7 = null |> unbox<US7>
                    let _v10558 = v10559 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10562 : US7 = null |> unbox<US7>
                    let _v10558 = v10562 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10565 : US7 = null |> unbox<US7>
                    let _v10558 = v10565 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10568 : US7 = null |> unbox<US7>
                    let _v10558 = v10568 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10571 : US7 = null |> unbox<US7>
                    let _v10558 = v10571 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10574 : (bool -> US7) = method22()
                    let v10575 : (exn -> US7) = method23()
                    let v10576 : US7 = match v10557 with Choice1Of2 x -> v10574 x | Choice2Of2 x -> v10575 x
                    let _v10558 = v10576 
                    #endif
#else
                    let v10577 : (bool -> US7) = method22()
                    let v10578 : (exn -> US7) = method23()
                    let v10579 : US7 = match v10557 with Choice1Of2 x -> v10577 x | Choice2Of2 x -> v10578 x
                    let _v10558 = v10579 
                    #endif
                    let v10580 : US7 = _v10558 
                    return v10580 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10613 : Async<US7> = _v10554 
            let _v10484 = v10613 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10614 : unit = ()
            let _v10614 =
                async {
                    let! v10479 = v10479 
                    let v10617 : Choice<bool, exn> = v10479 
                    let v10618 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10619 : US7 = null |> unbox<US7>
                    let _v10618 = v10619 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10622 : US7 = null |> unbox<US7>
                    let _v10618 = v10622 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10625 : US7 = null |> unbox<US7>
                    let _v10618 = v10625 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10628 : US7 = null |> unbox<US7>
                    let _v10618 = v10628 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10631 : US7 = null |> unbox<US7>
                    let _v10618 = v10631 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10634 : (bool -> US7) = method22()
                    let v10635 : (exn -> US7) = method23()
                    let v10636 : US7 = match v10617 with Choice1Of2 x -> v10634 x | Choice2Of2 x -> v10635 x
                    let _v10618 = v10636 
                    #endif
#else
                    let v10637 : (bool -> US7) = method22()
                    let v10638 : (exn -> US7) = method23()
                    let v10639 : US7 = match v10617 with Choice1Of2 x -> v10637 x | Choice2Of2 x -> v10638 x
                    let _v10618 = v10639 
                    #endif
                    let v10640 : US7 = _v10618 
                    return v10640 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10673 : Async<US7> = _v10614 
            let _v10484 = v10673 
            #endif
#else
            let v10674 : unit = ()
            let _v10674 =
                async {
                    let! v10479 = v10479 
                    let v10677 : Choice<bool, exn> = v10479 
                    let v10678 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10679 : US7 = null |> unbox<US7>
                    let _v10678 = v10679 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10682 : US7 = null |> unbox<US7>
                    let _v10678 = v10682 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10685 : US7 = null |> unbox<US7>
                    let _v10678 = v10685 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10688 : US7 = null |> unbox<US7>
                    let _v10678 = v10688 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10691 : US7 = null |> unbox<US7>
                    let _v10678 = v10691 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10694 : (bool -> US7) = method22()
                    let v10695 : (exn -> US7) = method23()
                    let v10696 : US7 = match v10677 with Choice1Of2 x -> v10694 x | Choice2Of2 x -> v10695 x
                    let _v10678 = v10696 
                    #endif
#else
                    let v10697 : (bool -> US7) = method22()
                    let v10698 : (exn -> US7) = method23()
                    let v10699 : US7 = match v10677 with Choice1Of2 x -> v10697 x | Choice2Of2 x -> v10698 x
                    let _v10678 = v10699 
                    #endif
                    let v10700 : US7 = _v10678 
                    return v10700 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10733 : Async<US7> = _v10674 
            let _v10484 = v10733 
            #endif
            let v10734 : Async<US7> = _v10484 
            let v10796 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10797 : Async<US8> = null |> unbox<Async<US8>>
            let _v10796 = v10797 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10800 : Async<US8> = null |> unbox<Async<US8>>
            let _v10796 = v10800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10803 : Async<US8> = null |> unbox<Async<US8>>
            let _v10796 = v10803 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10806 : unit = ()
            let _v10806 =
                async {
                    let! v10734 = v10734 
                    let v10809 : US7 = v10734 
                    let v10815 : US8 =
                        match v10809 with
                        | US7_0(v10810) -> (* C1of2 *)
                            US8_0(v10810)
                        | US7_1(v10812) -> (* C2of2 *)
                            US8_1(v10812)
                    return v10815 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10823 : Async<US8> = _v10806 
            let _v10796 = v10823 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10824 : unit = ()
            let _v10824 =
                async {
                    let! v10734 = v10734 
                    let v10827 : US7 = v10734 
                    let v10833 : US8 =
                        match v10827 with
                        | US7_0(v10828) -> (* C1of2 *)
                            US8_0(v10828)
                        | US7_1(v10830) -> (* C2of2 *)
                            US8_1(v10830)
                    return v10833 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10841 : Async<US8> = _v10824 
            let _v10796 = v10841 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10842 : unit = ()
            let _v10842 =
                async {
                    let! v10734 = v10734 
                    let v10845 : US7 = v10734 
                    let v10851 : US8 =
                        match v10845 with
                        | US7_0(v10846) -> (* C1of2 *)
                            US8_0(v10846)
                        | US7_1(v10848) -> (* C2of2 *)
                            US8_1(v10848)
                    return v10851 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10859 : Async<US8> = _v10842 
            let _v10796 = v10859 
            #endif
#else
            let v10860 : unit = ()
            let _v10860 =
                async {
                    let! v10734 = v10734 
                    let v10863 : US7 = v10734 
                    let v10869 : US8 =
                        match v10863 with
                        | US7_0(v10864) -> (* C1of2 *)
                            US8_0(v10864)
                        | US7_1(v10866) -> (* C2of2 *)
                            US8_1(v10866)
                    return v10869 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10877 : Async<US8> = _v10860 
            let _v10796 = v10877 
            #endif
            let v10878 : Async<US8> = _v10796 
            let v10898 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10899 : Async<US6> = null |> unbox<Async<US6>>
            let _v10898 = v10899 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10902 : Async<US6> = null |> unbox<Async<US6>>
            let _v10898 = v10902 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10905 : Async<US6> = null |> unbox<Async<US6>>
            let _v10898 = v10905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10908 : unit = ()
            let _v10908 =
                async {
                    let! v10878 = v10878 
                    let v10911 : US8 = v10878 
                    let v11035 : US6 =
                        match v10911 with
                        | US8_1(v10914) -> (* Error *)
                            let v10915 : string = $"%A{v10914}"
                            let v10918 : string = "System.TimeoutException"
                            let v10919 : bool = v10915.Contains v10918 
                            if v10919 then
                                let v10922 : unit = ()
                                let v10923 : (unit -> unit) = closure16(v0)
                                let v10924 : unit = (fun () -> v10923 (); v10922) ()
                                US6_1
                            else
                                let v10965 : unit = ()
                                let v10966 : (unit -> unit) = closure17(v0, v10914)
                                let v10967 : unit = (fun () -> v10966 (); v10965) ()
                                US6_1
                        | US8_0(v10912) -> (* Ok *)
                            US6_0(v10912)
                    return v11035 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11161 : Async<US6> = _v10908 
            let _v10898 = v11161 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11162 : unit = ()
            let _v11162 =
                async {
                    let! v10878 = v10878 
                    let v11165 : US8 = v10878 
                    let v11289 : US6 =
                        match v11165 with
                        | US8_1(v11168) -> (* Error *)
                            let v11169 : string = $"%A{v11168}"
                            let v11172 : string = "System.TimeoutException"
                            let v11173 : bool = v11169.Contains v11172 
                            if v11173 then
                                let v11176 : unit = ()
                                let v11177 : (unit -> unit) = closure16(v0)
                                let v11178 : unit = (fun () -> v11177 (); v11176) ()
                                US6_1
                            else
                                let v11219 : unit = ()
                                let v11220 : (unit -> unit) = closure17(v0, v11168)
                                let v11221 : unit = (fun () -> v11220 (); v11219) ()
                                US6_1
                        | US8_0(v11166) -> (* Ok *)
                            US6_0(v11166)
                    return v11289 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11415 : Async<US6> = _v11162 
            let _v10898 = v11415 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11416 : unit = ()
            let _v11416 =
                async {
                    let! v10878 = v10878 
                    let v11419 : US8 = v10878 
                    let v11543 : US6 =
                        match v11419 with
                        | US8_1(v11422) -> (* Error *)
                            let v11423 : string = $"%A{v11422}"
                            let v11426 : string = "System.TimeoutException"
                            let v11427 : bool = v11423.Contains v11426 
                            if v11427 then
                                let v11430 : unit = ()
                                let v11431 : (unit -> unit) = closure16(v0)
                                let v11432 : unit = (fun () -> v11431 (); v11430) ()
                                US6_1
                            else
                                let v11473 : unit = ()
                                let v11474 : (unit -> unit) = closure17(v0, v11422)
                                let v11475 : unit = (fun () -> v11474 (); v11473) ()
                                US6_1
                        | US8_0(v11420) -> (* Ok *)
                            US6_0(v11420)
                    return v11543 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11669 : Async<US6> = _v11416 
            let _v10898 = v11669 
            #endif
#else
            let v11670 : unit = ()
            let _v11670 =
                async {
                    let! v10878 = v10878 
                    let v11673 : US8 = v10878 
                    let v11797 : US6 =
                        match v11673 with
                        | US8_1(v11676) -> (* Error *)
                            let v11677 : string = $"%A{v11676}"
                            let v11680 : string = "System.TimeoutException"
                            let v11681 : bool = v11677.Contains v11680 
                            if v11681 then
                                let v11684 : unit = ()
                                let v11685 : (unit -> unit) = closure16(v0)
                                let v11686 : unit = (fun () -> v11685 (); v11684) ()
                                US6_1
                            else
                                let v11727 : unit = ()
                                let v11728 : (unit -> unit) = closure17(v0, v11676)
                                let v11729 : unit = (fun () -> v11728 (); v11727) ()
                                US6_1
                        | US8_0(v11674) -> (* Ok *)
                            US6_0(v11674)
                    return v11797 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11923 : Async<US6> = _v11670 
            let _v10898 = v11923 
            #endif
            let v11924 : Async<US6> = _v10898 
            return! v11924 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v13916 : Async<US6> = _v10441 
    let _v3 = v13916 
    #endif
    let v13917 : Async<US6> = _v3 
    let _v2 = v13917 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17395 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17396 : Async<US6> = null |> unbox<Async<US6>>
    let _v17395 = v17396 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17399 : Async<US6> = null |> unbox<Async<US6>>
    let _v17395 = v17399 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17402 : Async<US6> = null |> unbox<Async<US6>>
    let _v17395 = v17402 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17405 : unit = ()
    let _v17405 =
        async {
            let v17408 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17409 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v17408 = v17409 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17412 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v17408 = v17412 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17415 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v17408 = v17415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17418 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17408 = v17418 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17419 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17408 = v17419 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17420 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17408 = v17420 
            #endif
#else
            let v17421 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17408 = v17421 
            #endif
            let v17422 : Async<Async<bool>> = _v17408 
            let! v17422 = v17422 
            let v17427 : Async<bool> = v17422 
            let v17428 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17429 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17430 : Async<Choice<bool, exn>> = v17429 v17427
            let _v17428 = v17430 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17431 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17432 : Async<Choice<bool, exn>> = v17431 v17427
            let _v17428 = v17432 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17433 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17434 : Async<Choice<bool, exn>> = v17433 v17427
            let _v17428 = v17434 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17435 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17436 : Async<Choice<bool, exn>> = v17435 v17427
            let _v17428 = v17436 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17437 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17438 : Async<Choice<bool, exn>> = v17437 v17427
            let _v17428 = v17438 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17439 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17440 : Async<Choice<bool, exn>> = v17439 v17427
            let _v17428 = v17440 
            #endif
#else
            let v17441 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17442 : Async<Choice<bool, exn>> = v17441 v17427
            let _v17428 = v17442 
            #endif
            let v17443 : Async<Choice<bool, exn>> = _v17428 
            let v17448 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17449 : Async<US7> = null |> unbox<Async<US7>>
            let _v17448 = v17449 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17452 : Async<US7> = null |> unbox<Async<US7>>
            let _v17448 = v17452 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17455 : Async<US7> = null |> unbox<Async<US7>>
            let _v17448 = v17455 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17458 : unit = ()
            let _v17458 =
                async {
                    let! v17443 = v17443 
                    let v17461 : Choice<bool, exn> = v17443 
                    let v17462 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17463 : US7 = null |> unbox<US7>
                    let _v17462 = v17463 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17466 : US7 = null |> unbox<US7>
                    let _v17462 = v17466 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17469 : US7 = null |> unbox<US7>
                    let _v17462 = v17469 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17472 : US7 = null |> unbox<US7>
                    let _v17462 = v17472 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17475 : US7 = null |> unbox<US7>
                    let _v17462 = v17475 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17478 : (bool -> US7) = method22()
                    let v17479 : (exn -> US7) = method23()
                    let v17480 : US7 = match v17461 with Choice1Of2 x -> v17478 x | Choice2Of2 x -> v17479 x
                    let _v17462 = v17480 
                    #endif
#else
                    let v17481 : (bool -> US7) = method22()
                    let v17482 : (exn -> US7) = method23()
                    let v17483 : US7 = match v17461 with Choice1Of2 x -> v17481 x | Choice2Of2 x -> v17482 x
                    let _v17462 = v17483 
                    #endif
                    let v17484 : US7 = _v17462 
                    return v17484 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17517 : Async<US7> = _v17458 
            let _v17448 = v17517 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17518 : unit = ()
            let _v17518 =
                async {
                    let! v17443 = v17443 
                    let v17521 : Choice<bool, exn> = v17443 
                    let v17522 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17523 : US7 = null |> unbox<US7>
                    let _v17522 = v17523 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17526 : US7 = null |> unbox<US7>
                    let _v17522 = v17526 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17529 : US7 = null |> unbox<US7>
                    let _v17522 = v17529 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17532 : US7 = null |> unbox<US7>
                    let _v17522 = v17532 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17535 : US7 = null |> unbox<US7>
                    let _v17522 = v17535 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17538 : (bool -> US7) = method22()
                    let v17539 : (exn -> US7) = method23()
                    let v17540 : US7 = match v17521 with Choice1Of2 x -> v17538 x | Choice2Of2 x -> v17539 x
                    let _v17522 = v17540 
                    #endif
#else
                    let v17541 : (bool -> US7) = method22()
                    let v17542 : (exn -> US7) = method23()
                    let v17543 : US7 = match v17521 with Choice1Of2 x -> v17541 x | Choice2Of2 x -> v17542 x
                    let _v17522 = v17543 
                    #endif
                    let v17544 : US7 = _v17522 
                    return v17544 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17577 : Async<US7> = _v17518 
            let _v17448 = v17577 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17578 : unit = ()
            let _v17578 =
                async {
                    let! v17443 = v17443 
                    let v17581 : Choice<bool, exn> = v17443 
                    let v17582 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17583 : US7 = null |> unbox<US7>
                    let _v17582 = v17583 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17586 : US7 = null |> unbox<US7>
                    let _v17582 = v17586 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17589 : US7 = null |> unbox<US7>
                    let _v17582 = v17589 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17592 : US7 = null |> unbox<US7>
                    let _v17582 = v17592 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17595 : US7 = null |> unbox<US7>
                    let _v17582 = v17595 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17598 : (bool -> US7) = method22()
                    let v17599 : (exn -> US7) = method23()
                    let v17600 : US7 = match v17581 with Choice1Of2 x -> v17598 x | Choice2Of2 x -> v17599 x
                    let _v17582 = v17600 
                    #endif
#else
                    let v17601 : (bool -> US7) = method22()
                    let v17602 : (exn -> US7) = method23()
                    let v17603 : US7 = match v17581 with Choice1Of2 x -> v17601 x | Choice2Of2 x -> v17602 x
                    let _v17582 = v17603 
                    #endif
                    let v17604 : US7 = _v17582 
                    return v17604 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17637 : Async<US7> = _v17578 
            let _v17448 = v17637 
            #endif
#else
            let v17638 : unit = ()
            let _v17638 =
                async {
                    let! v17443 = v17443 
                    let v17641 : Choice<bool, exn> = v17443 
                    let v17642 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17643 : US7 = null |> unbox<US7>
                    let _v17642 = v17643 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17646 : US7 = null |> unbox<US7>
                    let _v17642 = v17646 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17649 : US7 = null |> unbox<US7>
                    let _v17642 = v17649 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17652 : US7 = null |> unbox<US7>
                    let _v17642 = v17652 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17655 : US7 = null |> unbox<US7>
                    let _v17642 = v17655 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17658 : (bool -> US7) = method22()
                    let v17659 : (exn -> US7) = method23()
                    let v17660 : US7 = match v17641 with Choice1Of2 x -> v17658 x | Choice2Of2 x -> v17659 x
                    let _v17642 = v17660 
                    #endif
#else
                    let v17661 : (bool -> US7) = method22()
                    let v17662 : (exn -> US7) = method23()
                    let v17663 : US7 = match v17641 with Choice1Of2 x -> v17661 x | Choice2Of2 x -> v17662 x
                    let _v17642 = v17663 
                    #endif
                    let v17664 : US7 = _v17642 
                    return v17664 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17697 : Async<US7> = _v17638 
            let _v17448 = v17697 
            #endif
            let v17698 : Async<US7> = _v17448 
            let v17760 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17761 : Async<US8> = null |> unbox<Async<US8>>
            let _v17760 = v17761 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17764 : Async<US8> = null |> unbox<Async<US8>>
            let _v17760 = v17764 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17767 : Async<US8> = null |> unbox<Async<US8>>
            let _v17760 = v17767 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17770 : unit = ()
            let _v17770 =
                async {
                    let! v17698 = v17698 
                    let v17773 : US7 = v17698 
                    let v17779 : US8 =
                        match v17773 with
                        | US7_0(v17774) -> (* C1of2 *)
                            US8_0(v17774)
                        | US7_1(v17776) -> (* C2of2 *)
                            US8_1(v17776)
                    return v17779 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17787 : Async<US8> = _v17770 
            let _v17760 = v17787 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17788 : unit = ()
            let _v17788 =
                async {
                    let! v17698 = v17698 
                    let v17791 : US7 = v17698 
                    let v17797 : US8 =
                        match v17791 with
                        | US7_0(v17792) -> (* C1of2 *)
                            US8_0(v17792)
                        | US7_1(v17794) -> (* C2of2 *)
                            US8_1(v17794)
                    return v17797 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17805 : Async<US8> = _v17788 
            let _v17760 = v17805 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17806 : unit = ()
            let _v17806 =
                async {
                    let! v17698 = v17698 
                    let v17809 : US7 = v17698 
                    let v17815 : US8 =
                        match v17809 with
                        | US7_0(v17810) -> (* C1of2 *)
                            US8_0(v17810)
                        | US7_1(v17812) -> (* C2of2 *)
                            US8_1(v17812)
                    return v17815 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17823 : Async<US8> = _v17806 
            let _v17760 = v17823 
            #endif
#else
            let v17824 : unit = ()
            let _v17824 =
                async {
                    let! v17698 = v17698 
                    let v17827 : US7 = v17698 
                    let v17833 : US8 =
                        match v17827 with
                        | US7_0(v17828) -> (* C1of2 *)
                            US8_0(v17828)
                        | US7_1(v17830) -> (* C2of2 *)
                            US8_1(v17830)
                    return v17833 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17841 : Async<US8> = _v17824 
            let _v17760 = v17841 
            #endif
            let v17842 : Async<US8> = _v17760 
            let v17862 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17863 : Async<US6> = null |> unbox<Async<US6>>
            let _v17862 = v17863 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17866 : Async<US6> = null |> unbox<Async<US6>>
            let _v17862 = v17866 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17869 : Async<US6> = null |> unbox<Async<US6>>
            let _v17862 = v17869 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17872 : unit = ()
            let _v17872 =
                async {
                    let! v17842 = v17842 
                    let v17875 : US8 = v17842 
                    let v17999 : US6 =
                        match v17875 with
                        | US8_1(v17878) -> (* Error *)
                            let v17879 : string = $"%A{v17878}"
                            let v17882 : string = "System.TimeoutException"
                            let v17883 : bool = v17879.Contains v17882 
                            if v17883 then
                                let v17886 : unit = ()
                                let v17887 : (unit -> unit) = closure16(v0)
                                let v17888 : unit = (fun () -> v17887 (); v17886) ()
                                US6_1
                            else
                                let v17929 : unit = ()
                                let v17930 : (unit -> unit) = closure17(v0, v17878)
                                let v17931 : unit = (fun () -> v17930 (); v17929) ()
                                US6_1
                        | US8_0(v17876) -> (* Ok *)
                            US6_0(v17876)
                    return v17999 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18125 : Async<US6> = _v17872 
            let _v17862 = v18125 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18126 : unit = ()
            let _v18126 =
                async {
                    let! v17842 = v17842 
                    let v18129 : US8 = v17842 
                    let v18253 : US6 =
                        match v18129 with
                        | US8_1(v18132) -> (* Error *)
                            let v18133 : string = $"%A{v18132}"
                            let v18136 : string = "System.TimeoutException"
                            let v18137 : bool = v18133.Contains v18136 
                            if v18137 then
                                let v18140 : unit = ()
                                let v18141 : (unit -> unit) = closure16(v0)
                                let v18142 : unit = (fun () -> v18141 (); v18140) ()
                                US6_1
                            else
                                let v18183 : unit = ()
                                let v18184 : (unit -> unit) = closure17(v0, v18132)
                                let v18185 : unit = (fun () -> v18184 (); v18183) ()
                                US6_1
                        | US8_0(v18130) -> (* Ok *)
                            US6_0(v18130)
                    return v18253 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18379 : Async<US6> = _v18126 
            let _v17862 = v18379 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18380 : unit = ()
            let _v18380 =
                async {
                    let! v17842 = v17842 
                    let v18383 : US8 = v17842 
                    let v18507 : US6 =
                        match v18383 with
                        | US8_1(v18386) -> (* Error *)
                            let v18387 : string = $"%A{v18386}"
                            let v18390 : string = "System.TimeoutException"
                            let v18391 : bool = v18387.Contains v18390 
                            if v18391 then
                                let v18394 : unit = ()
                                let v18395 : (unit -> unit) = closure16(v0)
                                let v18396 : unit = (fun () -> v18395 (); v18394) ()
                                US6_1
                            else
                                let v18437 : unit = ()
                                let v18438 : (unit -> unit) = closure17(v0, v18386)
                                let v18439 : unit = (fun () -> v18438 (); v18437) ()
                                US6_1
                        | US8_0(v18384) -> (* Ok *)
                            US6_0(v18384)
                    return v18507 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18633 : Async<US6> = _v18380 
            let _v17862 = v18633 
            #endif
#else
            let v18634 : unit = ()
            let _v18634 =
                async {
                    let! v17842 = v17842 
                    let v18637 : US8 = v17842 
                    let v18761 : US6 =
                        match v18637 with
                        | US8_1(v18640) -> (* Error *)
                            let v18641 : string = $"%A{v18640}"
                            let v18644 : string = "System.TimeoutException"
                            let v18645 : bool = v18641.Contains v18644 
                            if v18645 then
                                let v18648 : unit = ()
                                let v18649 : (unit -> unit) = closure16(v0)
                                let v18650 : unit = (fun () -> v18649 (); v18648) ()
                                US6_1
                            else
                                let v18691 : unit = ()
                                let v18692 : (unit -> unit) = closure17(v0, v18640)
                                let v18693 : unit = (fun () -> v18692 (); v18691) ()
                                US6_1
                        | US8_0(v18638) -> (* Ok *)
                            US6_0(v18638)
                    return v18761 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18887 : Async<US6> = _v18634 
            let _v17862 = v18887 
            #endif
            let v18888 : Async<US6> = _v17862 
            return! v18888 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v20880 : Async<US6> = _v17405 
    let _v17395 = v20880 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20881 : unit = ()
    let _v20881 =
        async {
            let v20884 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20885 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v20884 = v20885 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20888 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v20884 = v20888 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20891 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v20884 = v20891 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20894 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20884 = v20894 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20895 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20884 = v20895 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20896 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20884 = v20896 
            #endif
#else
            let v20897 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20884 = v20897 
            #endif
            let v20898 : Async<Async<bool>> = _v20884 
            let! v20898 = v20898 
            let v20903 : Async<bool> = v20898 
            let v20904 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20905 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20906 : Async<Choice<bool, exn>> = v20905 v20903
            let _v20904 = v20906 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20907 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20908 : Async<Choice<bool, exn>> = v20907 v20903
            let _v20904 = v20908 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20909 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20910 : Async<Choice<bool, exn>> = v20909 v20903
            let _v20904 = v20910 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20911 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20912 : Async<Choice<bool, exn>> = v20911 v20903
            let _v20904 = v20912 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20913 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20914 : Async<Choice<bool, exn>> = v20913 v20903
            let _v20904 = v20914 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20915 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20916 : Async<Choice<bool, exn>> = v20915 v20903
            let _v20904 = v20916 
            #endif
#else
            let v20917 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20918 : Async<Choice<bool, exn>> = v20917 v20903
            let _v20904 = v20918 
            #endif
            let v20919 : Async<Choice<bool, exn>> = _v20904 
            let v20924 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20925 : Async<US7> = null |> unbox<Async<US7>>
            let _v20924 = v20925 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20928 : Async<US7> = null |> unbox<Async<US7>>
            let _v20924 = v20928 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20931 : Async<US7> = null |> unbox<Async<US7>>
            let _v20924 = v20931 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20934 : unit = ()
            let _v20934 =
                async {
                    let! v20919 = v20919 
                    let v20937 : Choice<bool, exn> = v20919 
                    let v20938 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20939 : US7 = null |> unbox<US7>
                    let _v20938 = v20939 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20942 : US7 = null |> unbox<US7>
                    let _v20938 = v20942 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20945 : US7 = null |> unbox<US7>
                    let _v20938 = v20945 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20948 : US7 = null |> unbox<US7>
                    let _v20938 = v20948 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20951 : US7 = null |> unbox<US7>
                    let _v20938 = v20951 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20954 : (bool -> US7) = method22()
                    let v20955 : (exn -> US7) = method23()
                    let v20956 : US7 = match v20937 with Choice1Of2 x -> v20954 x | Choice2Of2 x -> v20955 x
                    let _v20938 = v20956 
                    #endif
#else
                    let v20957 : (bool -> US7) = method22()
                    let v20958 : (exn -> US7) = method23()
                    let v20959 : US7 = match v20937 with Choice1Of2 x -> v20957 x | Choice2Of2 x -> v20958 x
                    let _v20938 = v20959 
                    #endif
                    let v20960 : US7 = _v20938 
                    return v20960 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20993 : Async<US7> = _v20934 
            let _v20924 = v20993 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20994 : unit = ()
            let _v20994 =
                async {
                    let! v20919 = v20919 
                    let v20997 : Choice<bool, exn> = v20919 
                    let v20998 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20999 : US7 = null |> unbox<US7>
                    let _v20998 = v20999 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v21002 : US7 = null |> unbox<US7>
                    let _v20998 = v21002 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v21005 : US7 = null |> unbox<US7>
                    let _v20998 = v21005 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v21008 : US7 = null |> unbox<US7>
                    let _v20998 = v21008 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v21011 : US7 = null |> unbox<US7>
                    let _v20998 = v21011 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v21014 : (bool -> US7) = method22()
                    let v21015 : (exn -> US7) = method23()
                    let v21016 : US7 = match v20997 with Choice1Of2 x -> v21014 x | Choice2Of2 x -> v21015 x
                    let _v20998 = v21016 
                    #endif
#else
                    let v21017 : (bool -> US7) = method22()
                    let v21018 : (exn -> US7) = method23()
                    let v21019 : US7 = match v20997 with Choice1Of2 x -> v21017 x | Choice2Of2 x -> v21018 x
                    let _v20998 = v21019 
                    #endif
                    let v21020 : US7 = _v20998 
                    return v21020 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21053 : Async<US7> = _v20994 
            let _v20924 = v21053 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v21054 : unit = ()
            let _v21054 =
                async {
                    let! v20919 = v20919 
                    let v21057 : Choice<bool, exn> = v20919 
                    let v21058 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v21059 : US7 = null |> unbox<US7>
                    let _v21058 = v21059 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v21062 : US7 = null |> unbox<US7>
                    let _v21058 = v21062 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v21065 : US7 = null |> unbox<US7>
                    let _v21058 = v21065 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v21068 : US7 = null |> unbox<US7>
                    let _v21058 = v21068 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v21071 : US7 = null |> unbox<US7>
                    let _v21058 = v21071 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v21074 : (bool -> US7) = method22()
                    let v21075 : (exn -> US7) = method23()
                    let v21076 : US7 = match v21057 with Choice1Of2 x -> v21074 x | Choice2Of2 x -> v21075 x
                    let _v21058 = v21076 
                    #endif
#else
                    let v21077 : (bool -> US7) = method22()
                    let v21078 : (exn -> US7) = method23()
                    let v21079 : US7 = match v21057 with Choice1Of2 x -> v21077 x | Choice2Of2 x -> v21078 x
                    let _v21058 = v21079 
                    #endif
                    let v21080 : US7 = _v21058 
                    return v21080 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21113 : Async<US7> = _v21054 
            let _v20924 = v21113 
            #endif
#else
            let v21114 : unit = ()
            let _v21114 =
                async {
                    let! v20919 = v20919 
                    let v21117 : Choice<bool, exn> = v20919 
                    let v21118 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v21119 : US7 = null |> unbox<US7>
                    let _v21118 = v21119 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v21122 : US7 = null |> unbox<US7>
                    let _v21118 = v21122 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v21125 : US7 = null |> unbox<US7>
                    let _v21118 = v21125 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v21128 : US7 = null |> unbox<US7>
                    let _v21118 = v21128 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v21131 : US7 = null |> unbox<US7>
                    let _v21118 = v21131 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v21134 : (bool -> US7) = method22()
                    let v21135 : (exn -> US7) = method23()
                    let v21136 : US7 = match v21117 with Choice1Of2 x -> v21134 x | Choice2Of2 x -> v21135 x
                    let _v21118 = v21136 
                    #endif
#else
                    let v21137 : (bool -> US7) = method22()
                    let v21138 : (exn -> US7) = method23()
                    let v21139 : US7 = match v21117 with Choice1Of2 x -> v21137 x | Choice2Of2 x -> v21138 x
                    let _v21118 = v21139 
                    #endif
                    let v21140 : US7 = _v21118 
                    return v21140 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21173 : Async<US7> = _v21114 
            let _v20924 = v21173 
            #endif
            let v21174 : Async<US7> = _v20924 
            let v21236 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v21237 : Async<US8> = null |> unbox<Async<US8>>
            let _v21236 = v21237 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v21240 : Async<US8> = null |> unbox<Async<US8>>
            let _v21236 = v21240 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21243 : Async<US8> = null |> unbox<Async<US8>>
            let _v21236 = v21243 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v21246 : unit = ()
            let _v21246 =
                async {
                    let! v21174 = v21174 
                    let v21249 : US7 = v21174 
                    let v21255 : US8 =
                        match v21249 with
                        | US7_0(v21250) -> (* C1of2 *)
                            US8_0(v21250)
                        | US7_1(v21252) -> (* C2of2 *)
                            US8_1(v21252)
                    return v21255 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21263 : Async<US8> = _v21246 
            let _v21236 = v21263 
            #endif
#if FABLE_COMPILER_PYTHON
            let v21264 : unit = ()
            let _v21264 =
                async {
                    let! v21174 = v21174 
                    let v21267 : US7 = v21174 
                    let v21273 : US8 =
                        match v21267 with
                        | US7_0(v21268) -> (* C1of2 *)
                            US8_0(v21268)
                        | US7_1(v21270) -> (* C2of2 *)
                            US8_1(v21270)
                    return v21273 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21281 : Async<US8> = _v21264 
            let _v21236 = v21281 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v21282 : unit = ()
            let _v21282 =
                async {
                    let! v21174 = v21174 
                    let v21285 : US7 = v21174 
                    let v21291 : US8 =
                        match v21285 with
                        | US7_0(v21286) -> (* C1of2 *)
                            US8_0(v21286)
                        | US7_1(v21288) -> (* C2of2 *)
                            US8_1(v21288)
                    return v21291 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21299 : Async<US8> = _v21282 
            let _v21236 = v21299 
            #endif
#else
            let v21300 : unit = ()
            let _v21300 =
                async {
                    let! v21174 = v21174 
                    let v21303 : US7 = v21174 
                    let v21309 : US8 =
                        match v21303 with
                        | US7_0(v21304) -> (* C1of2 *)
                            US8_0(v21304)
                        | US7_1(v21306) -> (* C2of2 *)
                            US8_1(v21306)
                    return v21309 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21317 : Async<US8> = _v21300 
            let _v21236 = v21317 
            #endif
            let v21318 : Async<US8> = _v21236 
            let v21338 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v21339 : Async<US6> = null |> unbox<Async<US6>>
            let _v21338 = v21339 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v21342 : Async<US6> = null |> unbox<Async<US6>>
            let _v21338 = v21342 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21345 : Async<US6> = null |> unbox<Async<US6>>
            let _v21338 = v21345 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v21348 : unit = ()
            let _v21348 =
                async {
                    let! v21318 = v21318 
                    let v21351 : US8 = v21318 
                    let v21475 : US6 =
                        match v21351 with
                        | US8_1(v21354) -> (* Error *)
                            let v21355 : string = $"%A{v21354}"
                            let v21358 : string = "System.TimeoutException"
                            let v21359 : bool = v21355.Contains v21358 
                            if v21359 then
                                let v21362 : unit = ()
                                let v21363 : (unit -> unit) = closure16(v0)
                                let v21364 : unit = (fun () -> v21363 (); v21362) ()
                                US6_1
                            else
                                let v21405 : unit = ()
                                let v21406 : (unit -> unit) = closure17(v0, v21354)
                                let v21407 : unit = (fun () -> v21406 (); v21405) ()
                                US6_1
                        | US8_0(v21352) -> (* Ok *)
                            US6_0(v21352)
                    return v21475 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21601 : Async<US6> = _v21348 
            let _v21338 = v21601 
            #endif
#if FABLE_COMPILER_PYTHON
            let v21602 : unit = ()
            let _v21602 =
                async {
                    let! v21318 = v21318 
                    let v21605 : US8 = v21318 
                    let v21729 : US6 =
                        match v21605 with
                        | US8_1(v21608) -> (* Error *)
                            let v21609 : string = $"%A{v21608}"
                            let v21612 : string = "System.TimeoutException"
                            let v21613 : bool = v21609.Contains v21612 
                            if v21613 then
                                let v21616 : unit = ()
                                let v21617 : (unit -> unit) = closure16(v0)
                                let v21618 : unit = (fun () -> v21617 (); v21616) ()
                                US6_1
                            else
                                let v21659 : unit = ()
                                let v21660 : (unit -> unit) = closure17(v0, v21608)
                                let v21661 : unit = (fun () -> v21660 (); v21659) ()
                                US6_1
                        | US8_0(v21606) -> (* Ok *)
                            US6_0(v21606)
                    return v21729 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v21855 : Async<US6> = _v21602 
            let _v21338 = v21855 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v21856 : unit = ()
            let _v21856 =
                async {
                    let! v21318 = v21318 
                    let v21859 : US8 = v21318 
                    let v21983 : US6 =
                        match v21859 with
                        | US8_1(v21862) -> (* Error *)
                            let v21863 : string = $"%A{v21862}"
                            let v21866 : string = "System.TimeoutException"
                            let v21867 : bool = v21863.Contains v21866 
                            if v21867 then
                                let v21870 : unit = ()
                                let v21871 : (unit -> unit) = closure16(v0)
                                let v21872 : unit = (fun () -> v21871 (); v21870) ()
                                US6_1
                            else
                                let v21913 : unit = ()
                                let v21914 : (unit -> unit) = closure17(v0, v21862)
                                let v21915 : unit = (fun () -> v21914 (); v21913) ()
                                US6_1
                        | US8_0(v21860) -> (* Ok *)
                            US6_0(v21860)
                    return v21983 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v22109 : Async<US6> = _v21856 
            let _v21338 = v22109 
            #endif
#else
            let v22110 : unit = ()
            let _v22110 =
                async {
                    let! v21318 = v21318 
                    let v22113 : US8 = v21318 
                    let v22237 : US6 =
                        match v22113 with
                        | US8_1(v22116) -> (* Error *)
                            let v22117 : string = $"%A{v22116}"
                            let v22120 : string = "System.TimeoutException"
                            let v22121 : bool = v22117.Contains v22120 
                            if v22121 then
                                let v22124 : unit = ()
                                let v22125 : (unit -> unit) = closure16(v0)
                                let v22126 : unit = (fun () -> v22125 (); v22124) ()
                                US6_1
                            else
                                let v22167 : unit = ()
                                let v22168 : (unit -> unit) = closure17(v0, v22116)
                                let v22169 : unit = (fun () -> v22168 (); v22167) ()
                                US6_1
                        | US8_0(v22114) -> (* Ok *)
                            US6_0(v22114)
                    return v22237 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v22363 : Async<US6> = _v22110 
            let _v21338 = v22363 
            #endif
            let v22364 : Async<US6> = _v21338 
            return! v22364 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v24356 : Async<US6> = _v20881 
    let _v17395 = v24356 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v24357 : unit = ()
    let _v24357 =
        async {
            let v24360 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24361 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v24360 = v24361 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v24364 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v24360 = v24364 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24367 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v24360 = v24367 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24370 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v24360 = v24370 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24371 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v24360 = v24371 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v24372 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v24360 = v24372 
            #endif
#else
            let v24373 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v24360 = v24373 
            #endif
            let v24374 : Async<Async<bool>> = _v24360 
            let! v24374 = v24374 
            let v24379 : Async<bool> = v24374 
            let v24380 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24381 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24382 : Async<Choice<bool, exn>> = v24381 v24379
            let _v24380 = v24382 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v24383 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24384 : Async<Choice<bool, exn>> = v24383 v24379
            let _v24380 = v24384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24385 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24386 : Async<Choice<bool, exn>> = v24385 v24379
            let _v24380 = v24386 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24387 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24388 : Async<Choice<bool, exn>> = v24387 v24379
            let _v24380 = v24388 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24389 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24390 : Async<Choice<bool, exn>> = v24389 v24379
            let _v24380 = v24390 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v24391 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24392 : Async<Choice<bool, exn>> = v24391 v24379
            let _v24380 = v24392 
            #endif
#else
            let v24393 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v24394 : Async<Choice<bool, exn>> = v24393 v24379
            let _v24380 = v24394 
            #endif
            let v24395 : Async<Choice<bool, exn>> = _v24380 
            let v24400 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24401 : Async<US7> = null |> unbox<Async<US7>>
            let _v24400 = v24401 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v24404 : Async<US7> = null |> unbox<Async<US7>>
            let _v24400 = v24404 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24407 : Async<US7> = null |> unbox<Async<US7>>
            let _v24400 = v24407 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24410 : unit = ()
            let _v24410 =
                async {
                    let! v24395 = v24395 
                    let v24413 : Choice<bool, exn> = v24395 
                    let v24414 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v24415 : US7 = null |> unbox<US7>
                    let _v24414 = v24415 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v24418 : US7 = null |> unbox<US7>
                    let _v24414 = v24418 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v24421 : US7 = null |> unbox<US7>
                    let _v24414 = v24421 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v24424 : US7 = null |> unbox<US7>
                    let _v24414 = v24424 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v24427 : US7 = null |> unbox<US7>
                    let _v24414 = v24427 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v24430 : (bool -> US7) = method22()
                    let v24431 : (exn -> US7) = method23()
                    let v24432 : US7 = match v24413 with Choice1Of2 x -> v24430 x | Choice2Of2 x -> v24431 x
                    let _v24414 = v24432 
                    #endif
#else
                    let v24433 : (bool -> US7) = method22()
                    let v24434 : (exn -> US7) = method23()
                    let v24435 : US7 = match v24413 with Choice1Of2 x -> v24433 x | Choice2Of2 x -> v24434 x
                    let _v24414 = v24435 
                    #endif
                    let v24436 : US7 = _v24414 
                    return v24436 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24469 : Async<US7> = _v24410 
            let _v24400 = v24469 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24470 : unit = ()
            let _v24470 =
                async {
                    let! v24395 = v24395 
                    let v24473 : Choice<bool, exn> = v24395 
                    let v24474 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v24475 : US7 = null |> unbox<US7>
                    let _v24474 = v24475 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v24478 : US7 = null |> unbox<US7>
                    let _v24474 = v24478 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v24481 : US7 = null |> unbox<US7>
                    let _v24474 = v24481 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v24484 : US7 = null |> unbox<US7>
                    let _v24474 = v24484 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v24487 : US7 = null |> unbox<US7>
                    let _v24474 = v24487 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v24490 : (bool -> US7) = method22()
                    let v24491 : (exn -> US7) = method23()
                    let v24492 : US7 = match v24473 with Choice1Of2 x -> v24490 x | Choice2Of2 x -> v24491 x
                    let _v24474 = v24492 
                    #endif
#else
                    let v24493 : (bool -> US7) = method22()
                    let v24494 : (exn -> US7) = method23()
                    let v24495 : US7 = match v24473 with Choice1Of2 x -> v24493 x | Choice2Of2 x -> v24494 x
                    let _v24474 = v24495 
                    #endif
                    let v24496 : US7 = _v24474 
                    return v24496 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24529 : Async<US7> = _v24470 
            let _v24400 = v24529 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v24530 : unit = ()
            let _v24530 =
                async {
                    let! v24395 = v24395 
                    let v24533 : Choice<bool, exn> = v24395 
                    let v24534 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v24535 : US7 = null |> unbox<US7>
                    let _v24534 = v24535 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v24538 : US7 = null |> unbox<US7>
                    let _v24534 = v24538 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v24541 : US7 = null |> unbox<US7>
                    let _v24534 = v24541 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v24544 : US7 = null |> unbox<US7>
                    let _v24534 = v24544 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v24547 : US7 = null |> unbox<US7>
                    let _v24534 = v24547 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v24550 : (bool -> US7) = method22()
                    let v24551 : (exn -> US7) = method23()
                    let v24552 : US7 = match v24533 with Choice1Of2 x -> v24550 x | Choice2Of2 x -> v24551 x
                    let _v24534 = v24552 
                    #endif
#else
                    let v24553 : (bool -> US7) = method22()
                    let v24554 : (exn -> US7) = method23()
                    let v24555 : US7 = match v24533 with Choice1Of2 x -> v24553 x | Choice2Of2 x -> v24554 x
                    let _v24534 = v24555 
                    #endif
                    let v24556 : US7 = _v24534 
                    return v24556 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24589 : Async<US7> = _v24530 
            let _v24400 = v24589 
            #endif
#else
            let v24590 : unit = ()
            let _v24590 =
                async {
                    let! v24395 = v24395 
                    let v24593 : Choice<bool, exn> = v24395 
                    let v24594 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v24595 : US7 = null |> unbox<US7>
                    let _v24594 = v24595 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v24598 : US7 = null |> unbox<US7>
                    let _v24594 = v24598 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v24601 : US7 = null |> unbox<US7>
                    let _v24594 = v24601 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v24604 : US7 = null |> unbox<US7>
                    let _v24594 = v24604 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v24607 : US7 = null |> unbox<US7>
                    let _v24594 = v24607 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v24610 : (bool -> US7) = method22()
                    let v24611 : (exn -> US7) = method23()
                    let v24612 : US7 = match v24593 with Choice1Of2 x -> v24610 x | Choice2Of2 x -> v24611 x
                    let _v24594 = v24612 
                    #endif
#else
                    let v24613 : (bool -> US7) = method22()
                    let v24614 : (exn -> US7) = method23()
                    let v24615 : US7 = match v24593 with Choice1Of2 x -> v24613 x | Choice2Of2 x -> v24614 x
                    let _v24594 = v24615 
                    #endif
                    let v24616 : US7 = _v24594 
                    return v24616 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24649 : Async<US7> = _v24590 
            let _v24400 = v24649 
            #endif
            let v24650 : Async<US7> = _v24400 
            let v24712 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24713 : Async<US8> = null |> unbox<Async<US8>>
            let _v24712 = v24713 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v24716 : Async<US8> = null |> unbox<Async<US8>>
            let _v24712 = v24716 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24719 : Async<US8> = null |> unbox<Async<US8>>
            let _v24712 = v24719 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24722 : unit = ()
            let _v24722 =
                async {
                    let! v24650 = v24650 
                    let v24725 : US7 = v24650 
                    let v24731 : US8 =
                        match v24725 with
                        | US7_0(v24726) -> (* C1of2 *)
                            US8_0(v24726)
                        | US7_1(v24728) -> (* C2of2 *)
                            US8_1(v24728)
                    return v24731 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24739 : Async<US8> = _v24722 
            let _v24712 = v24739 
            #endif
#if FABLE_COMPILER_PYTHON
            let v24740 : unit = ()
            let _v24740 =
                async {
                    let! v24650 = v24650 
                    let v24743 : US7 = v24650 
                    let v24749 : US8 =
                        match v24743 with
                        | US7_0(v24744) -> (* C1of2 *)
                            US8_0(v24744)
                        | US7_1(v24746) -> (* C2of2 *)
                            US8_1(v24746)
                    return v24749 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24757 : Async<US8> = _v24740 
            let _v24712 = v24757 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v24758 : unit = ()
            let _v24758 =
                async {
                    let! v24650 = v24650 
                    let v24761 : US7 = v24650 
                    let v24767 : US8 =
                        match v24761 with
                        | US7_0(v24762) -> (* C1of2 *)
                            US8_0(v24762)
                        | US7_1(v24764) -> (* C2of2 *)
                            US8_1(v24764)
                    return v24767 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24775 : Async<US8> = _v24758 
            let _v24712 = v24775 
            #endif
#else
            let v24776 : unit = ()
            let _v24776 =
                async {
                    let! v24650 = v24650 
                    let v24779 : US7 = v24650 
                    let v24785 : US8 =
                        match v24779 with
                        | US7_0(v24780) -> (* C1of2 *)
                            US8_0(v24780)
                        | US7_1(v24782) -> (* C2of2 *)
                            US8_1(v24782)
                    return v24785 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v24793 : Async<US8> = _v24776 
            let _v24712 = v24793 
            #endif
            let v24794 : Async<US8> = _v24712 
            let v24814 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24815 : Async<US6> = null |> unbox<Async<US6>>
            let _v24814 = v24815 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v24818 : Async<US6> = null |> unbox<Async<US6>>
            let _v24814 = v24818 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v24821 : Async<US6> = null |> unbox<Async<US6>>
            let _v24814 = v24821 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24824 : unit = ()
            let _v24824 =
                async {
                    let! v24794 = v24794 
                    let v24827 : US8 = v24794 
                    let v24951 : US6 =
                        match v24827 with
                        | US8_1(v24830) -> (* Error *)
                            let v24831 : string = $"%A{v24830}"
                            let v24834 : string = "System.TimeoutException"
                            let v24835 : bool = v24831.Contains v24834 
                            if v24835 then
                                let v24838 : unit = ()
                                let v24839 : (unit -> unit) = closure16(v0)
                                let v24840 : unit = (fun () -> v24839 (); v24838) ()
                                US6_1
                            else
                                let v24881 : unit = ()
                                let v24882 : (unit -> unit) = closure17(v0, v24830)
                                let v24883 : unit = (fun () -> v24882 (); v24881) ()
                                US6_1
                        | US8_0(v24828) -> (* Ok *)
                            US6_0(v24828)
                    return v24951 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v25077 : Async<US6> = _v24824 
            let _v24814 = v25077 
            #endif
#if FABLE_COMPILER_PYTHON
            let v25078 : unit = ()
            let _v25078 =
                async {
                    let! v24794 = v24794 
                    let v25081 : US8 = v24794 
                    let v25205 : US6 =
                        match v25081 with
                        | US8_1(v25084) -> (* Error *)
                            let v25085 : string = $"%A{v25084}"
                            let v25088 : string = "System.TimeoutException"
                            let v25089 : bool = v25085.Contains v25088 
                            if v25089 then
                                let v25092 : unit = ()
                                let v25093 : (unit -> unit) = closure16(v0)
                                let v25094 : unit = (fun () -> v25093 (); v25092) ()
                                US6_1
                            else
                                let v25135 : unit = ()
                                let v25136 : (unit -> unit) = closure17(v0, v25084)
                                let v25137 : unit = (fun () -> v25136 (); v25135) ()
                                US6_1
                        | US8_0(v25082) -> (* Ok *)
                            US6_0(v25082)
                    return v25205 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v25331 : Async<US6> = _v25078 
            let _v24814 = v25331 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v25332 : unit = ()
            let _v25332 =
                async {
                    let! v24794 = v24794 
                    let v25335 : US8 = v24794 
                    let v25459 : US6 =
                        match v25335 with
                        | US8_1(v25338) -> (* Error *)
                            let v25339 : string = $"%A{v25338}"
                            let v25342 : string = "System.TimeoutException"
                            let v25343 : bool = v25339.Contains v25342 
                            if v25343 then
                                let v25346 : unit = ()
                                let v25347 : (unit -> unit) = closure16(v0)
                                let v25348 : unit = (fun () -> v25347 (); v25346) ()
                                US6_1
                            else
                                let v25389 : unit = ()
                                let v25390 : (unit -> unit) = closure17(v0, v25338)
                                let v25391 : unit = (fun () -> v25390 (); v25389) ()
                                US6_1
                        | US8_0(v25336) -> (* Ok *)
                            US6_0(v25336)
                    return v25459 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v25585 : Async<US6> = _v25332 
            let _v24814 = v25585 
            #endif
#else
            let v25586 : unit = ()
            let _v25586 =
                async {
                    let! v24794 = v24794 
                    let v25589 : US8 = v24794 
                    let v25713 : US6 =
                        match v25589 with
                        | US8_1(v25592) -> (* Error *)
                            let v25593 : string = $"%A{v25592}"
                            let v25596 : string = "System.TimeoutException"
                            let v25597 : bool = v25593.Contains v25596 
                            if v25597 then
                                let v25600 : unit = ()
                                let v25601 : (unit -> unit) = closure16(v0)
                                let v25602 : unit = (fun () -> v25601 (); v25600) ()
                                US6_1
                            else
                                let v25643 : unit = ()
                                let v25644 : (unit -> unit) = closure17(v0, v25592)
                                let v25645 : unit = (fun () -> v25644 (); v25643) ()
                                US6_1
                        | US8_0(v25590) -> (* Ok *)
                            US6_0(v25590)
                    return v25713 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v25839 : Async<US6> = _v25586 
            let _v24814 = v25839 
            #endif
            let v25840 : Async<US6> = _v24814 
            return! v25840 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v27832 : Async<US6> = _v24357 
    let _v17395 = v27832 
    #endif
#else
    let v27833 : unit = ()
    let _v27833 =
        async {
            let v27836 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27837 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v27836 = v27837 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27840 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v27836 = v27840 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v27843 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v27836 = v27843 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27846 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v27836 = v27846 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27847 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v27836 = v27847 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v27848 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v27836 = v27848 
            #endif
#else
            let v27849 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v27836 = v27849 
            #endif
            let v27850 : Async<Async<bool>> = _v27836 
            let! v27850 = v27850 
            let v27855 : Async<bool> = v27850 
            let v27856 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27857 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27858 : Async<Choice<bool, exn>> = v27857 v27855
            let _v27856 = v27858 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27859 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27860 : Async<Choice<bool, exn>> = v27859 v27855
            let _v27856 = v27860 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v27861 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27862 : Async<Choice<bool, exn>> = v27861 v27855
            let _v27856 = v27862 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27863 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27864 : Async<Choice<bool, exn>> = v27863 v27855
            let _v27856 = v27864 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27865 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27866 : Async<Choice<bool, exn>> = v27865 v27855
            let _v27856 = v27866 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v27867 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27868 : Async<Choice<bool, exn>> = v27867 v27855
            let _v27856 = v27868 
            #endif
#else
            let v27869 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v27870 : Async<Choice<bool, exn>> = v27869 v27855
            let _v27856 = v27870 
            #endif
            let v27871 : Async<Choice<bool, exn>> = _v27856 
            let v27876 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v27877 : Async<US7> = null |> unbox<Async<US7>>
            let _v27876 = v27877 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27880 : Async<US7> = null |> unbox<Async<US7>>
            let _v27876 = v27880 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v27883 : Async<US7> = null |> unbox<Async<US7>>
            let _v27876 = v27883 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v27886 : unit = ()
            let _v27886 =
                async {
                    let! v27871 = v27871 
                    let v27889 : Choice<bool, exn> = v27871 
                    let v27890 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v27891 : US7 = null |> unbox<US7>
                    let _v27890 = v27891 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v27894 : US7 = null |> unbox<US7>
                    let _v27890 = v27894 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v27897 : US7 = null |> unbox<US7>
                    let _v27890 = v27897 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v27900 : US7 = null |> unbox<US7>
                    let _v27890 = v27900 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v27903 : US7 = null |> unbox<US7>
                    let _v27890 = v27903 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v27906 : (bool -> US7) = method22()
                    let v27907 : (exn -> US7) = method23()
                    let v27908 : US7 = match v27889 with Choice1Of2 x -> v27906 x | Choice2Of2 x -> v27907 x
                    let _v27890 = v27908 
                    #endif
#else
                    let v27909 : (bool -> US7) = method22()
                    let v27910 : (exn -> US7) = method23()
                    let v27911 : US7 = match v27889 with Choice1Of2 x -> v27909 x | Choice2Of2 x -> v27910 x
                    let _v27890 = v27911 
                    #endif
                    let v27912 : US7 = _v27890 
                    return v27912 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v27945 : Async<US7> = _v27886 
            let _v27876 = v27945 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27946 : unit = ()
            let _v27946 =
                async {
                    let! v27871 = v27871 
                    let v27949 : Choice<bool, exn> = v27871 
                    let v27950 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v27951 : US7 = null |> unbox<US7>
                    let _v27950 = v27951 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v27954 : US7 = null |> unbox<US7>
                    let _v27950 = v27954 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v27957 : US7 = null |> unbox<US7>
                    let _v27950 = v27957 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v27960 : US7 = null |> unbox<US7>
                    let _v27950 = v27960 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v27963 : US7 = null |> unbox<US7>
                    let _v27950 = v27963 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v27966 : (bool -> US7) = method22()
                    let v27967 : (exn -> US7) = method23()
                    let v27968 : US7 = match v27949 with Choice1Of2 x -> v27966 x | Choice2Of2 x -> v27967 x
                    let _v27950 = v27968 
                    #endif
#else
                    let v27969 : (bool -> US7) = method22()
                    let v27970 : (exn -> US7) = method23()
                    let v27971 : US7 = match v27949 with Choice1Of2 x -> v27969 x | Choice2Of2 x -> v27970 x
                    let _v27950 = v27971 
                    #endif
                    let v27972 : US7 = _v27950 
                    return v27972 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28005 : Async<US7> = _v27946 
            let _v27876 = v28005 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v28006 : unit = ()
            let _v28006 =
                async {
                    let! v27871 = v27871 
                    let v28009 : Choice<bool, exn> = v27871 
                    let v28010 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v28011 : US7 = null |> unbox<US7>
                    let _v28010 = v28011 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v28014 : US7 = null |> unbox<US7>
                    let _v28010 = v28014 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v28017 : US7 = null |> unbox<US7>
                    let _v28010 = v28017 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v28020 : US7 = null |> unbox<US7>
                    let _v28010 = v28020 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v28023 : US7 = null |> unbox<US7>
                    let _v28010 = v28023 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v28026 : (bool -> US7) = method22()
                    let v28027 : (exn -> US7) = method23()
                    let v28028 : US7 = match v28009 with Choice1Of2 x -> v28026 x | Choice2Of2 x -> v28027 x
                    let _v28010 = v28028 
                    #endif
#else
                    let v28029 : (bool -> US7) = method22()
                    let v28030 : (exn -> US7) = method23()
                    let v28031 : US7 = match v28009 with Choice1Of2 x -> v28029 x | Choice2Of2 x -> v28030 x
                    let _v28010 = v28031 
                    #endif
                    let v28032 : US7 = _v28010 
                    return v28032 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28065 : Async<US7> = _v28006 
            let _v27876 = v28065 
            #endif
#else
            let v28066 : unit = ()
            let _v28066 =
                async {
                    let! v27871 = v27871 
                    let v28069 : Choice<bool, exn> = v27871 
                    let v28070 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v28071 : US7 = null |> unbox<US7>
                    let _v28070 = v28071 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v28074 : US7 = null |> unbox<US7>
                    let _v28070 = v28074 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v28077 : US7 = null |> unbox<US7>
                    let _v28070 = v28077 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v28080 : US7 = null |> unbox<US7>
                    let _v28070 = v28080 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v28083 : US7 = null |> unbox<US7>
                    let _v28070 = v28083 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v28086 : (bool -> US7) = method22()
                    let v28087 : (exn -> US7) = method23()
                    let v28088 : US7 = match v28069 with Choice1Of2 x -> v28086 x | Choice2Of2 x -> v28087 x
                    let _v28070 = v28088 
                    #endif
#else
                    let v28089 : (bool -> US7) = method22()
                    let v28090 : (exn -> US7) = method23()
                    let v28091 : US7 = match v28069 with Choice1Of2 x -> v28089 x | Choice2Of2 x -> v28090 x
                    let _v28070 = v28091 
                    #endif
                    let v28092 : US7 = _v28070 
                    return v28092 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28125 : Async<US7> = _v28066 
            let _v27876 = v28125 
            #endif
            let v28126 : Async<US7> = _v27876 
            let v28188 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28189 : Async<US8> = null |> unbox<Async<US8>>
            let _v28188 = v28189 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28192 : Async<US8> = null |> unbox<Async<US8>>
            let _v28188 = v28192 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28195 : Async<US8> = null |> unbox<Async<US8>>
            let _v28188 = v28195 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v28198 : unit = ()
            let _v28198 =
                async {
                    let! v28126 = v28126 
                    let v28201 : US7 = v28126 
                    let v28207 : US8 =
                        match v28201 with
                        | US7_0(v28202) -> (* C1of2 *)
                            US8_0(v28202)
                        | US7_1(v28204) -> (* C2of2 *)
                            US8_1(v28204)
                    return v28207 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28215 : Async<US8> = _v28198 
            let _v28188 = v28215 
            #endif
#if FABLE_COMPILER_PYTHON
            let v28216 : unit = ()
            let _v28216 =
                async {
                    let! v28126 = v28126 
                    let v28219 : US7 = v28126 
                    let v28225 : US8 =
                        match v28219 with
                        | US7_0(v28220) -> (* C1of2 *)
                            US8_0(v28220)
                        | US7_1(v28222) -> (* C2of2 *)
                            US8_1(v28222)
                    return v28225 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28233 : Async<US8> = _v28216 
            let _v28188 = v28233 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v28234 : unit = ()
            let _v28234 =
                async {
                    let! v28126 = v28126 
                    let v28237 : US7 = v28126 
                    let v28243 : US8 =
                        match v28237 with
                        | US7_0(v28238) -> (* C1of2 *)
                            US8_0(v28238)
                        | US7_1(v28240) -> (* C2of2 *)
                            US8_1(v28240)
                    return v28243 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28251 : Async<US8> = _v28234 
            let _v28188 = v28251 
            #endif
#else
            let v28252 : unit = ()
            let _v28252 =
                async {
                    let! v28126 = v28126 
                    let v28255 : US7 = v28126 
                    let v28261 : US8 =
                        match v28255 with
                        | US7_0(v28256) -> (* C1of2 *)
                            US8_0(v28256)
                        | US7_1(v28258) -> (* C2of2 *)
                            US8_1(v28258)
                    return v28261 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28269 : Async<US8> = _v28252 
            let _v28188 = v28269 
            #endif
            let v28270 : Async<US8> = _v28188 
            let v28290 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v28291 : Async<US6> = null |> unbox<Async<US6>>
            let _v28290 = v28291 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v28294 : Async<US6> = null |> unbox<Async<US6>>
            let _v28290 = v28294 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28297 : Async<US6> = null |> unbox<Async<US6>>
            let _v28290 = v28297 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v28300 : unit = ()
            let _v28300 =
                async {
                    let! v28270 = v28270 
                    let v28303 : US8 = v28270 
                    let v28427 : US6 =
                        match v28303 with
                        | US8_1(v28306) -> (* Error *)
                            let v28307 : string = $"%A{v28306}"
                            let v28310 : string = "System.TimeoutException"
                            let v28311 : bool = v28307.Contains v28310 
                            if v28311 then
                                let v28314 : unit = ()
                                let v28315 : (unit -> unit) = closure16(v0)
                                let v28316 : unit = (fun () -> v28315 (); v28314) ()
                                US6_1
                            else
                                let v28357 : unit = ()
                                let v28358 : (unit -> unit) = closure17(v0, v28306)
                                let v28359 : unit = (fun () -> v28358 (); v28357) ()
                                US6_1
                        | US8_0(v28304) -> (* Ok *)
                            US6_0(v28304)
                    return v28427 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28553 : Async<US6> = _v28300 
            let _v28290 = v28553 
            #endif
#if FABLE_COMPILER_PYTHON
            let v28554 : unit = ()
            let _v28554 =
                async {
                    let! v28270 = v28270 
                    let v28557 : US8 = v28270 
                    let v28681 : US6 =
                        match v28557 with
                        | US8_1(v28560) -> (* Error *)
                            let v28561 : string = $"%A{v28560}"
                            let v28564 : string = "System.TimeoutException"
                            let v28565 : bool = v28561.Contains v28564 
                            if v28565 then
                                let v28568 : unit = ()
                                let v28569 : (unit -> unit) = closure16(v0)
                                let v28570 : unit = (fun () -> v28569 (); v28568) ()
                                US6_1
                            else
                                let v28611 : unit = ()
                                let v28612 : (unit -> unit) = closure17(v0, v28560)
                                let v28613 : unit = (fun () -> v28612 (); v28611) ()
                                US6_1
                        | US8_0(v28558) -> (* Ok *)
                            US6_0(v28558)
                    return v28681 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v28807 : Async<US6> = _v28554 
            let _v28290 = v28807 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v28808 : unit = ()
            let _v28808 =
                async {
                    let! v28270 = v28270 
                    let v28811 : US8 = v28270 
                    let v28935 : US6 =
                        match v28811 with
                        | US8_1(v28814) -> (* Error *)
                            let v28815 : string = $"%A{v28814}"
                            let v28818 : string = "System.TimeoutException"
                            let v28819 : bool = v28815.Contains v28818 
                            if v28819 then
                                let v28822 : unit = ()
                                let v28823 : (unit -> unit) = closure16(v0)
                                let v28824 : unit = (fun () -> v28823 (); v28822) ()
                                US6_1
                            else
                                let v28865 : unit = ()
                                let v28866 : (unit -> unit) = closure17(v0, v28814)
                                let v28867 : unit = (fun () -> v28866 (); v28865) ()
                                US6_1
                        | US8_0(v28812) -> (* Ok *)
                            US6_0(v28812)
                    return v28935 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v29061 : Async<US6> = _v28808 
            let _v28290 = v29061 
            #endif
#else
            let v29062 : unit = ()
            let _v29062 =
                async {
                    let! v28270 = v28270 
                    let v29065 : US8 = v28270 
                    let v29189 : US6 =
                        match v29065 with
                        | US8_1(v29068) -> (* Error *)
                            let v29069 : string = $"%A{v29068}"
                            let v29072 : string = "System.TimeoutException"
                            let v29073 : bool = v29069.Contains v29072 
                            if v29073 then
                                let v29076 : unit = ()
                                let v29077 : (unit -> unit) = closure16(v0)
                                let v29078 : unit = (fun () -> v29077 (); v29076) ()
                                US6_1
                            else
                                let v29119 : unit = ()
                                let v29120 : (unit -> unit) = closure17(v0, v29068)
                                let v29121 : unit = (fun () -> v29120 (); v29119) ()
                                US6_1
                        | US8_0(v29066) -> (* Ok *)
                            US6_0(v29066)
                    return v29189 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v29315 : Async<US6> = _v29062 
            let _v28290 = v29315 
            #endif
            let v29316 : Async<US6> = _v28290 
            return! v29316 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v31308 : Async<US6> = _v27833 
    let _v17395 = v31308 
    #endif
    let v31309 : Async<US6> = _v17395 
    let _v2 = v31309 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34787 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34788 : Async<US6> = null |> unbox<Async<US6>>
    let _v34787 = v34788 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v34791 : Async<US6> = null |> unbox<Async<US6>>
    let _v34787 = v34791 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34794 : Async<US6> = null |> unbox<Async<US6>>
    let _v34787 = v34794 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v34797 : unit = ()
    let _v34797 =
        async {
            let v34800 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34801 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v34800 = v34801 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v34804 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v34800 = v34804 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v34807 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v34800 = v34807 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v34810 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v34800 = v34810 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34811 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v34800 = v34811 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v34812 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v34800 = v34812 
            #endif
#else
            let v34813 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v34800 = v34813 
            #endif
            let v34814 : Async<Async<bool>> = _v34800 
            let! v34814 = v34814 
            let v34819 : Async<bool> = v34814 
            let v34820 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34821 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34822 : Async<Choice<bool, exn>> = v34821 v34819
            let _v34820 = v34822 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v34823 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34824 : Async<Choice<bool, exn>> = v34823 v34819
            let _v34820 = v34824 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v34825 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34826 : Async<Choice<bool, exn>> = v34825 v34819
            let _v34820 = v34826 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v34827 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34828 : Async<Choice<bool, exn>> = v34827 v34819
            let _v34820 = v34828 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34829 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34830 : Async<Choice<bool, exn>> = v34829 v34819
            let _v34820 = v34830 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v34831 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34832 : Async<Choice<bool, exn>> = v34831 v34819
            let _v34820 = v34832 
            #endif
#else
            let v34833 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34834 : Async<Choice<bool, exn>> = v34833 v34819
            let _v34820 = v34834 
            #endif
            let v34835 : Async<Choice<bool, exn>> = _v34820 
            let v34840 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v34841 : Async<US7> = null |> unbox<Async<US7>>
            let _v34840 = v34841 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v34844 : Async<US7> = null |> unbox<Async<US7>>
            let _v34840 = v34844 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v34847 : Async<US7> = null |> unbox<Async<US7>>
            let _v34840 = v34847 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v34850 : unit = ()
            let _v34850 =
                async {
                    let! v34835 = v34835 
                    let v34853 : Choice<bool, exn> = v34835 
                    let v34854 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v34855 : US7 = null |> unbox<US7>
                    let _v34854 = v34855 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v34858 : US7 = null |> unbox<US7>
                    let _v34854 = v34858 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v34861 : US7 = null |> unbox<US7>
                    let _v34854 = v34861 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v34864 : US7 = null |> unbox<US7>
                    let _v34854 = v34864 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v34867 : US7 = null |> unbox<US7>
                    let _v34854 = v34867 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v34870 : (bool -> US7) = method22()
                    let v34871 : (exn -> US7) = method23()
                    let v34872 : US7 = match v34853 with Choice1Of2 x -> v34870 x | Choice2Of2 x -> v34871 x
                    let _v34854 = v34872 
                    #endif
#else
                    let v34873 : (bool -> US7) = method22()
                    let v34874 : (exn -> US7) = method23()
                    let v34875 : US7 = match v34853 with Choice1Of2 x -> v34873 x | Choice2Of2 x -> v34874 x
                    let _v34854 = v34875 
                    #endif
                    let v34876 : US7 = _v34854 
                    return v34876 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v34909 : Async<US7> = _v34850 
            let _v34840 = v34909 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34910 : unit = ()
            let _v34910 =
                async {
                    let! v34835 = v34835 
                    let v34913 : Choice<bool, exn> = v34835 
                    let v34914 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v34915 : US7 = null |> unbox<US7>
                    let _v34914 = v34915 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v34918 : US7 = null |> unbox<US7>
                    let _v34914 = v34918 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v34921 : US7 = null |> unbox<US7>
                    let _v34914 = v34921 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v34924 : US7 = null |> unbox<US7>
                    let _v34914 = v34924 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v34927 : US7 = null |> unbox<US7>
                    let _v34914 = v34927 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v34930 : (bool -> US7) = method22()
                    let v34931 : (exn -> US7) = method23()
                    let v34932 : US7 = match v34913 with Choice1Of2 x -> v34930 x | Choice2Of2 x -> v34931 x
                    let _v34914 = v34932 
                    #endif
#else
                    let v34933 : (bool -> US7) = method22()
                    let v34934 : (exn -> US7) = method23()
                    let v34935 : US7 = match v34913 with Choice1Of2 x -> v34933 x | Choice2Of2 x -> v34934 x
                    let _v34914 = v34935 
                    #endif
                    let v34936 : US7 = _v34914 
                    return v34936 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v34969 : Async<US7> = _v34910 
            let _v34840 = v34969 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v34970 : unit = ()
            let _v34970 =
                async {
                    let! v34835 = v34835 
                    let v34973 : Choice<bool, exn> = v34835 
                    let v34974 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v34975 : US7 = null |> unbox<US7>
                    let _v34974 = v34975 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v34978 : US7 = null |> unbox<US7>
                    let _v34974 = v34978 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v34981 : US7 = null |> unbox<US7>
                    let _v34974 = v34981 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v34984 : US7 = null |> unbox<US7>
                    let _v34974 = v34984 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v34987 : US7 = null |> unbox<US7>
                    let _v34974 = v34987 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v34990 : (bool -> US7) = method22()
                    let v34991 : (exn -> US7) = method23()
                    let v34992 : US7 = match v34973 with Choice1Of2 x -> v34990 x | Choice2Of2 x -> v34991 x
                    let _v34974 = v34992 
                    #endif
#else
                    let v34993 : (bool -> US7) = method22()
                    let v34994 : (exn -> US7) = method23()
                    let v34995 : US7 = match v34973 with Choice1Of2 x -> v34993 x | Choice2Of2 x -> v34994 x
                    let _v34974 = v34995 
                    #endif
                    let v34996 : US7 = _v34974 
                    return v34996 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35029 : Async<US7> = _v34970 
            let _v34840 = v35029 
            #endif
#else
            let v35030 : unit = ()
            let _v35030 =
                async {
                    let! v34835 = v34835 
                    let v35033 : Choice<bool, exn> = v34835 
                    let v35034 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v35035 : US7 = null |> unbox<US7>
                    let _v35034 = v35035 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v35038 : US7 = null |> unbox<US7>
                    let _v35034 = v35038 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v35041 : US7 = null |> unbox<US7>
                    let _v35034 = v35041 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v35044 : US7 = null |> unbox<US7>
                    let _v35034 = v35044 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v35047 : US7 = null |> unbox<US7>
                    let _v35034 = v35047 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v35050 : (bool -> US7) = method22()
                    let v35051 : (exn -> US7) = method23()
                    let v35052 : US7 = match v35033 with Choice1Of2 x -> v35050 x | Choice2Of2 x -> v35051 x
                    let _v35034 = v35052 
                    #endif
#else
                    let v35053 : (bool -> US7) = method22()
                    let v35054 : (exn -> US7) = method23()
                    let v35055 : US7 = match v35033 with Choice1Of2 x -> v35053 x | Choice2Of2 x -> v35054 x
                    let _v35034 = v35055 
                    #endif
                    let v35056 : US7 = _v35034 
                    return v35056 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35089 : Async<US7> = _v35030 
            let _v34840 = v35089 
            #endif
            let v35090 : Async<US7> = _v34840 
            let v35152 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v35153 : Async<US8> = null |> unbox<Async<US8>>
            let _v35152 = v35153 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v35156 : Async<US8> = null |> unbox<Async<US8>>
            let _v35152 = v35156 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v35159 : Async<US8> = null |> unbox<Async<US8>>
            let _v35152 = v35159 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v35162 : unit = ()
            let _v35162 =
                async {
                    let! v35090 = v35090 
                    let v35165 : US7 = v35090 
                    let v35171 : US8 =
                        match v35165 with
                        | US7_0(v35166) -> (* C1of2 *)
                            US8_0(v35166)
                        | US7_1(v35168) -> (* C2of2 *)
                            US8_1(v35168)
                    return v35171 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35179 : Async<US8> = _v35162 
            let _v35152 = v35179 
            #endif
#if FABLE_COMPILER_PYTHON
            let v35180 : unit = ()
            let _v35180 =
                async {
                    let! v35090 = v35090 
                    let v35183 : US7 = v35090 
                    let v35189 : US8 =
                        match v35183 with
                        | US7_0(v35184) -> (* C1of2 *)
                            US8_0(v35184)
                        | US7_1(v35186) -> (* C2of2 *)
                            US8_1(v35186)
                    return v35189 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35197 : Async<US8> = _v35180 
            let _v35152 = v35197 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v35198 : unit = ()
            let _v35198 =
                async {
                    let! v35090 = v35090 
                    let v35201 : US7 = v35090 
                    let v35207 : US8 =
                        match v35201 with
                        | US7_0(v35202) -> (* C1of2 *)
                            US8_0(v35202)
                        | US7_1(v35204) -> (* C2of2 *)
                            US8_1(v35204)
                    return v35207 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35215 : Async<US8> = _v35198 
            let _v35152 = v35215 
            #endif
#else
            let v35216 : unit = ()
            let _v35216 =
                async {
                    let! v35090 = v35090 
                    let v35219 : US7 = v35090 
                    let v35225 : US8 =
                        match v35219 with
                        | US7_0(v35220) -> (* C1of2 *)
                            US8_0(v35220)
                        | US7_1(v35222) -> (* C2of2 *)
                            US8_1(v35222)
                    return v35225 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35233 : Async<US8> = _v35216 
            let _v35152 = v35233 
            #endif
            let v35234 : Async<US8> = _v35152 
            let v35254 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v35255 : Async<US6> = null |> unbox<Async<US6>>
            let _v35254 = v35255 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v35258 : Async<US6> = null |> unbox<Async<US6>>
            let _v35254 = v35258 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v35261 : Async<US6> = null |> unbox<Async<US6>>
            let _v35254 = v35261 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v35264 : unit = ()
            let _v35264 =
                async {
                    let! v35234 = v35234 
                    let v35267 : US8 = v35234 
                    let v35391 : US6 =
                        match v35267 with
                        | US8_1(v35270) -> (* Error *)
                            let v35271 : string = $"%A{v35270}"
                            let v35274 : string = "System.TimeoutException"
                            let v35275 : bool = v35271.Contains v35274 
                            if v35275 then
                                let v35278 : unit = ()
                                let v35279 : (unit -> unit) = closure16(v0)
                                let v35280 : unit = (fun () -> v35279 (); v35278) ()
                                US6_1
                            else
                                let v35321 : unit = ()
                                let v35322 : (unit -> unit) = closure17(v0, v35270)
                                let v35323 : unit = (fun () -> v35322 (); v35321) ()
                                US6_1
                        | US8_0(v35268) -> (* Ok *)
                            US6_0(v35268)
                    return v35391 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35517 : Async<US6> = _v35264 
            let _v35254 = v35517 
            #endif
#if FABLE_COMPILER_PYTHON
            let v35518 : unit = ()
            let _v35518 =
                async {
                    let! v35234 = v35234 
                    let v35521 : US8 = v35234 
                    let v35645 : US6 =
                        match v35521 with
                        | US8_1(v35524) -> (* Error *)
                            let v35525 : string = $"%A{v35524}"
                            let v35528 : string = "System.TimeoutException"
                            let v35529 : bool = v35525.Contains v35528 
                            if v35529 then
                                let v35532 : unit = ()
                                let v35533 : (unit -> unit) = closure16(v0)
                                let v35534 : unit = (fun () -> v35533 (); v35532) ()
                                US6_1
                            else
                                let v35575 : unit = ()
                                let v35576 : (unit -> unit) = closure17(v0, v35524)
                                let v35577 : unit = (fun () -> v35576 (); v35575) ()
                                US6_1
                        | US8_0(v35522) -> (* Ok *)
                            US6_0(v35522)
                    return v35645 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v35771 : Async<US6> = _v35518 
            let _v35254 = v35771 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v35772 : unit = ()
            let _v35772 =
                async {
                    let! v35234 = v35234 
                    let v35775 : US8 = v35234 
                    let v35899 : US6 =
                        match v35775 with
                        | US8_1(v35778) -> (* Error *)
                            let v35779 : string = $"%A{v35778}"
                            let v35782 : string = "System.TimeoutException"
                            let v35783 : bool = v35779.Contains v35782 
                            if v35783 then
                                let v35786 : unit = ()
                                let v35787 : (unit -> unit) = closure16(v0)
                                let v35788 : unit = (fun () -> v35787 (); v35786) ()
                                US6_1
                            else
                                let v35829 : unit = ()
                                let v35830 : (unit -> unit) = closure17(v0, v35778)
                                let v35831 : unit = (fun () -> v35830 (); v35829) ()
                                US6_1
                        | US8_0(v35776) -> (* Ok *)
                            US6_0(v35776)
                    return v35899 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v36025 : Async<US6> = _v35772 
            let _v35254 = v36025 
            #endif
#else
            let v36026 : unit = ()
            let _v36026 =
                async {
                    let! v35234 = v35234 
                    let v36029 : US8 = v35234 
                    let v36153 : US6 =
                        match v36029 with
                        | US8_1(v36032) -> (* Error *)
                            let v36033 : string = $"%A{v36032}"
                            let v36036 : string = "System.TimeoutException"
                            let v36037 : bool = v36033.Contains v36036 
                            if v36037 then
                                let v36040 : unit = ()
                                let v36041 : (unit -> unit) = closure16(v0)
                                let v36042 : unit = (fun () -> v36041 (); v36040) ()
                                US6_1
                            else
                                let v36083 : unit = ()
                                let v36084 : (unit -> unit) = closure17(v0, v36032)
                                let v36085 : unit = (fun () -> v36084 (); v36083) ()
                                US6_1
                        | US8_0(v36030) -> (* Ok *)
                            US6_0(v36030)
                    return v36153 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v36279 : Async<US6> = _v36026 
            let _v35254 = v36279 
            #endif
            let v36280 : Async<US6> = _v35254 
            return! v36280 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v38272 : Async<US6> = _v34797 
    let _v34787 = v38272 
    #endif
#if FABLE_COMPILER_PYTHON
    let v38273 : unit = ()
    let _v38273 =
        async {
            let v38276 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38277 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v38276 = v38277 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v38280 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v38276 = v38280 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38283 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v38276 = v38283 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38286 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v38276 = v38286 
            #endif
#if FABLE_COMPILER_PYTHON
            let v38287 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v38276 = v38287 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v38288 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v38276 = v38288 
            #endif
#else
            let v38289 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v38276 = v38289 
            #endif
            let v38290 : Async<Async<bool>> = _v38276 
            let! v38290 = v38290 
            let v38295 : Async<bool> = v38290 
            let v38296 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38297 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38298 : Async<Choice<bool, exn>> = v38297 v38295
            let _v38296 = v38298 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v38299 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38300 : Async<Choice<bool, exn>> = v38299 v38295
            let _v38296 = v38300 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38301 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38302 : Async<Choice<bool, exn>> = v38301 v38295
            let _v38296 = v38302 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38303 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38304 : Async<Choice<bool, exn>> = v38303 v38295
            let _v38296 = v38304 
            #endif
#if FABLE_COMPILER_PYTHON
            let v38305 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38306 : Async<Choice<bool, exn>> = v38305 v38295
            let _v38296 = v38306 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v38307 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38308 : Async<Choice<bool, exn>> = v38307 v38295
            let _v38296 = v38308 
            #endif
#else
            let v38309 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38310 : Async<Choice<bool, exn>> = v38309 v38295
            let _v38296 = v38310 
            #endif
            let v38311 : Async<Choice<bool, exn>> = _v38296 
            let v38316 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38317 : Async<US7> = null |> unbox<Async<US7>>
            let _v38316 = v38317 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v38320 : Async<US7> = null |> unbox<Async<US7>>
            let _v38316 = v38320 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38323 : Async<US7> = null |> unbox<Async<US7>>
            let _v38316 = v38323 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38326 : unit = ()
            let _v38326 =
                async {
                    let! v38311 = v38311 
                    let v38329 : Choice<bool, exn> = v38311 
                    let v38330 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v38331 : US7 = null |> unbox<US7>
                    let _v38330 = v38331 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v38334 : US7 = null |> unbox<US7>
                    let _v38330 = v38334 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v38337 : US7 = null |> unbox<US7>
                    let _v38330 = v38337 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v38340 : US7 = null |> unbox<US7>
                    let _v38330 = v38340 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v38343 : US7 = null |> unbox<US7>
                    let _v38330 = v38343 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v38346 : (bool -> US7) = method22()
                    let v38347 : (exn -> US7) = method23()
                    let v38348 : US7 = match v38329 with Choice1Of2 x -> v38346 x | Choice2Of2 x -> v38347 x
                    let _v38330 = v38348 
                    #endif
#else
                    let v38349 : (bool -> US7) = method22()
                    let v38350 : (exn -> US7) = method23()
                    let v38351 : US7 = match v38329 with Choice1Of2 x -> v38349 x | Choice2Of2 x -> v38350 x
                    let _v38330 = v38351 
                    #endif
                    let v38352 : US7 = _v38330 
                    return v38352 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38385 : Async<US7> = _v38326 
            let _v38316 = v38385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v38386 : unit = ()
            let _v38386 =
                async {
                    let! v38311 = v38311 
                    let v38389 : Choice<bool, exn> = v38311 
                    let v38390 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v38391 : US7 = null |> unbox<US7>
                    let _v38390 = v38391 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v38394 : US7 = null |> unbox<US7>
                    let _v38390 = v38394 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v38397 : US7 = null |> unbox<US7>
                    let _v38390 = v38397 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v38400 : US7 = null |> unbox<US7>
                    let _v38390 = v38400 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v38403 : US7 = null |> unbox<US7>
                    let _v38390 = v38403 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v38406 : (bool -> US7) = method22()
                    let v38407 : (exn -> US7) = method23()
                    let v38408 : US7 = match v38389 with Choice1Of2 x -> v38406 x | Choice2Of2 x -> v38407 x
                    let _v38390 = v38408 
                    #endif
#else
                    let v38409 : (bool -> US7) = method22()
                    let v38410 : (exn -> US7) = method23()
                    let v38411 : US7 = match v38389 with Choice1Of2 x -> v38409 x | Choice2Of2 x -> v38410 x
                    let _v38390 = v38411 
                    #endif
                    let v38412 : US7 = _v38390 
                    return v38412 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38445 : Async<US7> = _v38386 
            let _v38316 = v38445 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v38446 : unit = ()
            let _v38446 =
                async {
                    let! v38311 = v38311 
                    let v38449 : Choice<bool, exn> = v38311 
                    let v38450 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v38451 : US7 = null |> unbox<US7>
                    let _v38450 = v38451 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v38454 : US7 = null |> unbox<US7>
                    let _v38450 = v38454 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v38457 : US7 = null |> unbox<US7>
                    let _v38450 = v38457 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v38460 : US7 = null |> unbox<US7>
                    let _v38450 = v38460 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v38463 : US7 = null |> unbox<US7>
                    let _v38450 = v38463 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v38466 : (bool -> US7) = method22()
                    let v38467 : (exn -> US7) = method23()
                    let v38468 : US7 = match v38449 with Choice1Of2 x -> v38466 x | Choice2Of2 x -> v38467 x
                    let _v38450 = v38468 
                    #endif
#else
                    let v38469 : (bool -> US7) = method22()
                    let v38470 : (exn -> US7) = method23()
                    let v38471 : US7 = match v38449 with Choice1Of2 x -> v38469 x | Choice2Of2 x -> v38470 x
                    let _v38450 = v38471 
                    #endif
                    let v38472 : US7 = _v38450 
                    return v38472 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38505 : Async<US7> = _v38446 
            let _v38316 = v38505 
            #endif
#else
            let v38506 : unit = ()
            let _v38506 =
                async {
                    let! v38311 = v38311 
                    let v38509 : Choice<bool, exn> = v38311 
                    let v38510 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v38511 : US7 = null |> unbox<US7>
                    let _v38510 = v38511 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v38514 : US7 = null |> unbox<US7>
                    let _v38510 = v38514 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v38517 : US7 = null |> unbox<US7>
                    let _v38510 = v38517 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v38520 : US7 = null |> unbox<US7>
                    let _v38510 = v38520 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v38523 : US7 = null |> unbox<US7>
                    let _v38510 = v38523 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v38526 : (bool -> US7) = method22()
                    let v38527 : (exn -> US7) = method23()
                    let v38528 : US7 = match v38509 with Choice1Of2 x -> v38526 x | Choice2Of2 x -> v38527 x
                    let _v38510 = v38528 
                    #endif
#else
                    let v38529 : (bool -> US7) = method22()
                    let v38530 : (exn -> US7) = method23()
                    let v38531 : US7 = match v38509 with Choice1Of2 x -> v38529 x | Choice2Of2 x -> v38530 x
                    let _v38510 = v38531 
                    #endif
                    let v38532 : US7 = _v38510 
                    return v38532 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38565 : Async<US7> = _v38506 
            let _v38316 = v38565 
            #endif
            let v38566 : Async<US7> = _v38316 
            let v38628 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38629 : Async<US8> = null |> unbox<Async<US8>>
            let _v38628 = v38629 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v38632 : Async<US8> = null |> unbox<Async<US8>>
            let _v38628 = v38632 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38635 : Async<US8> = null |> unbox<Async<US8>>
            let _v38628 = v38635 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38638 : unit = ()
            let _v38638 =
                async {
                    let! v38566 = v38566 
                    let v38641 : US7 = v38566 
                    let v38647 : US8 =
                        match v38641 with
                        | US7_0(v38642) -> (* C1of2 *)
                            US8_0(v38642)
                        | US7_1(v38644) -> (* C2of2 *)
                            US8_1(v38644)
                    return v38647 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38655 : Async<US8> = _v38638 
            let _v38628 = v38655 
            #endif
#if FABLE_COMPILER_PYTHON
            let v38656 : unit = ()
            let _v38656 =
                async {
                    let! v38566 = v38566 
                    let v38659 : US7 = v38566 
                    let v38665 : US8 =
                        match v38659 with
                        | US7_0(v38660) -> (* C1of2 *)
                            US8_0(v38660)
                        | US7_1(v38662) -> (* C2of2 *)
                            US8_1(v38662)
                    return v38665 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38673 : Async<US8> = _v38656 
            let _v38628 = v38673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v38674 : unit = ()
            let _v38674 =
                async {
                    let! v38566 = v38566 
                    let v38677 : US7 = v38566 
                    let v38683 : US8 =
                        match v38677 with
                        | US7_0(v38678) -> (* C1of2 *)
                            US8_0(v38678)
                        | US7_1(v38680) -> (* C2of2 *)
                            US8_1(v38680)
                    return v38683 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38691 : Async<US8> = _v38674 
            let _v38628 = v38691 
            #endif
#else
            let v38692 : unit = ()
            let _v38692 =
                async {
                    let! v38566 = v38566 
                    let v38695 : US7 = v38566 
                    let v38701 : US8 =
                        match v38695 with
                        | US7_0(v38696) -> (* C1of2 *)
                            US8_0(v38696)
                        | US7_1(v38698) -> (* C2of2 *)
                            US8_1(v38698)
                    return v38701 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38709 : Async<US8> = _v38692 
            let _v38628 = v38709 
            #endif
            let v38710 : Async<US8> = _v38628 
            let v38730 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v38731 : Async<US6> = null |> unbox<Async<US6>>
            let _v38730 = v38731 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v38734 : Async<US6> = null |> unbox<Async<US6>>
            let _v38730 = v38734 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v38737 : Async<US6> = null |> unbox<Async<US6>>
            let _v38730 = v38737 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v38740 : unit = ()
            let _v38740 =
                async {
                    let! v38710 = v38710 
                    let v38743 : US8 = v38710 
                    let v38867 : US6 =
                        match v38743 with
                        | US8_1(v38746) -> (* Error *)
                            let v38747 : string = $"%A{v38746}"
                            let v38750 : string = "System.TimeoutException"
                            let v38751 : bool = v38747.Contains v38750 
                            if v38751 then
                                let v38754 : unit = ()
                                let v38755 : (unit -> unit) = closure16(v0)
                                let v38756 : unit = (fun () -> v38755 (); v38754) ()
                                US6_1
                            else
                                let v38797 : unit = ()
                                let v38798 : (unit -> unit) = closure17(v0, v38746)
                                let v38799 : unit = (fun () -> v38798 (); v38797) ()
                                US6_1
                        | US8_0(v38744) -> (* Ok *)
                            US6_0(v38744)
                    return v38867 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v38993 : Async<US6> = _v38740 
            let _v38730 = v38993 
            #endif
#if FABLE_COMPILER_PYTHON
            let v38994 : unit = ()
            let _v38994 =
                async {
                    let! v38710 = v38710 
                    let v38997 : US8 = v38710 
                    let v39121 : US6 =
                        match v38997 with
                        | US8_1(v39000) -> (* Error *)
                            let v39001 : string = $"%A{v39000}"
                            let v39004 : string = "System.TimeoutException"
                            let v39005 : bool = v39001.Contains v39004 
                            if v39005 then
                                let v39008 : unit = ()
                                let v39009 : (unit -> unit) = closure16(v0)
                                let v39010 : unit = (fun () -> v39009 (); v39008) ()
                                US6_1
                            else
                                let v39051 : unit = ()
                                let v39052 : (unit -> unit) = closure17(v0, v39000)
                                let v39053 : unit = (fun () -> v39052 (); v39051) ()
                                US6_1
                        | US8_0(v38998) -> (* Ok *)
                            US6_0(v38998)
                    return v39121 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v39247 : Async<US6> = _v38994 
            let _v38730 = v39247 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v39248 : unit = ()
            let _v39248 =
                async {
                    let! v38710 = v38710 
                    let v39251 : US8 = v38710 
                    let v39375 : US6 =
                        match v39251 with
                        | US8_1(v39254) -> (* Error *)
                            let v39255 : string = $"%A{v39254}"
                            let v39258 : string = "System.TimeoutException"
                            let v39259 : bool = v39255.Contains v39258 
                            if v39259 then
                                let v39262 : unit = ()
                                let v39263 : (unit -> unit) = closure16(v0)
                                let v39264 : unit = (fun () -> v39263 (); v39262) ()
                                US6_1
                            else
                                let v39305 : unit = ()
                                let v39306 : (unit -> unit) = closure17(v0, v39254)
                                let v39307 : unit = (fun () -> v39306 (); v39305) ()
                                US6_1
                        | US8_0(v39252) -> (* Ok *)
                            US6_0(v39252)
                    return v39375 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v39501 : Async<US6> = _v39248 
            let _v38730 = v39501 
            #endif
#else
            let v39502 : unit = ()
            let _v39502 =
                async {
                    let! v38710 = v38710 
                    let v39505 : US8 = v38710 
                    let v39629 : US6 =
                        match v39505 with
                        | US8_1(v39508) -> (* Error *)
                            let v39509 : string = $"%A{v39508}"
                            let v39512 : string = "System.TimeoutException"
                            let v39513 : bool = v39509.Contains v39512 
                            if v39513 then
                                let v39516 : unit = ()
                                let v39517 : (unit -> unit) = closure16(v0)
                                let v39518 : unit = (fun () -> v39517 (); v39516) ()
                                US6_1
                            else
                                let v39559 : unit = ()
                                let v39560 : (unit -> unit) = closure17(v0, v39508)
                                let v39561 : unit = (fun () -> v39560 (); v39559) ()
                                US6_1
                        | US8_0(v39506) -> (* Ok *)
                            US6_0(v39506)
                    return v39629 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v39755 : Async<US6> = _v39502 
            let _v38730 = v39755 
            #endif
            let v39756 : Async<US6> = _v38730 
            return! v39756 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v41748 : Async<US6> = _v38273 
    let _v34787 = v41748 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v41749 : unit = ()
    let _v41749 =
        async {
            let v41752 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41753 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v41752 = v41753 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v41756 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v41752 = v41756 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v41759 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v41752 = v41759 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v41762 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v41752 = v41762 
            #endif
#if FABLE_COMPILER_PYTHON
            let v41763 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v41752 = v41763 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v41764 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v41752 = v41764 
            #endif
#else
            let v41765 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v41752 = v41765 
            #endif
            let v41766 : Async<Async<bool>> = _v41752 
            let! v41766 = v41766 
            let v41771 : Async<bool> = v41766 
            let v41772 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41773 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41774 : Async<Choice<bool, exn>> = v41773 v41771
            let _v41772 = v41774 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v41775 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41776 : Async<Choice<bool, exn>> = v41775 v41771
            let _v41772 = v41776 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v41777 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41778 : Async<Choice<bool, exn>> = v41777 v41771
            let _v41772 = v41778 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v41779 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41780 : Async<Choice<bool, exn>> = v41779 v41771
            let _v41772 = v41780 
            #endif
#if FABLE_COMPILER_PYTHON
            let v41781 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41782 : Async<Choice<bool, exn>> = v41781 v41771
            let _v41772 = v41782 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v41783 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41784 : Async<Choice<bool, exn>> = v41783 v41771
            let _v41772 = v41784 
            #endif
#else
            let v41785 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v41786 : Async<Choice<bool, exn>> = v41785 v41771
            let _v41772 = v41786 
            #endif
            let v41787 : Async<Choice<bool, exn>> = _v41772 
            let v41792 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41793 : Async<US7> = null |> unbox<Async<US7>>
            let _v41792 = v41793 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v41796 : Async<US7> = null |> unbox<Async<US7>>
            let _v41792 = v41796 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v41799 : Async<US7> = null |> unbox<Async<US7>>
            let _v41792 = v41799 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v41802 : unit = ()
            let _v41802 =
                async {
                    let! v41787 = v41787 
                    let v41805 : Choice<bool, exn> = v41787 
                    let v41806 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v41807 : US7 = null |> unbox<US7>
                    let _v41806 = v41807 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v41810 : US7 = null |> unbox<US7>
                    let _v41806 = v41810 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v41813 : US7 = null |> unbox<US7>
                    let _v41806 = v41813 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v41816 : US7 = null |> unbox<US7>
                    let _v41806 = v41816 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v41819 : US7 = null |> unbox<US7>
                    let _v41806 = v41819 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v41822 : (bool -> US7) = method22()
                    let v41823 : (exn -> US7) = method23()
                    let v41824 : US7 = match v41805 with Choice1Of2 x -> v41822 x | Choice2Of2 x -> v41823 x
                    let _v41806 = v41824 
                    #endif
#else
                    let v41825 : (bool -> US7) = method22()
                    let v41826 : (exn -> US7) = method23()
                    let v41827 : US7 = match v41805 with Choice1Of2 x -> v41825 x | Choice2Of2 x -> v41826 x
                    let _v41806 = v41827 
                    #endif
                    let v41828 : US7 = _v41806 
                    return v41828 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v41861 : Async<US7> = _v41802 
            let _v41792 = v41861 
            #endif
#if FABLE_COMPILER_PYTHON
            let v41862 : unit = ()
            let _v41862 =
                async {
                    let! v41787 = v41787 
                    let v41865 : Choice<bool, exn> = v41787 
                    let v41866 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v41867 : US7 = null |> unbox<US7>
                    let _v41866 = v41867 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v41870 : US7 = null |> unbox<US7>
                    let _v41866 = v41870 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v41873 : US7 = null |> unbox<US7>
                    let _v41866 = v41873 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v41876 : US7 = null |> unbox<US7>
                    let _v41866 = v41876 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v41879 : US7 = null |> unbox<US7>
                    let _v41866 = v41879 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v41882 : (bool -> US7) = method22()
                    let v41883 : (exn -> US7) = method23()
                    let v41884 : US7 = match v41865 with Choice1Of2 x -> v41882 x | Choice2Of2 x -> v41883 x
                    let _v41866 = v41884 
                    #endif
#else
                    let v41885 : (bool -> US7) = method22()
                    let v41886 : (exn -> US7) = method23()
                    let v41887 : US7 = match v41865 with Choice1Of2 x -> v41885 x | Choice2Of2 x -> v41886 x
                    let _v41866 = v41887 
                    #endif
                    let v41888 : US7 = _v41866 
                    return v41888 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v41921 : Async<US7> = _v41862 
            let _v41792 = v41921 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v41922 : unit = ()
            let _v41922 =
                async {
                    let! v41787 = v41787 
                    let v41925 : Choice<bool, exn> = v41787 
                    let v41926 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v41927 : US7 = null |> unbox<US7>
                    let _v41926 = v41927 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v41930 : US7 = null |> unbox<US7>
                    let _v41926 = v41930 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v41933 : US7 = null |> unbox<US7>
                    let _v41926 = v41933 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v41936 : US7 = null |> unbox<US7>
                    let _v41926 = v41936 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v41939 : US7 = null |> unbox<US7>
                    let _v41926 = v41939 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v41942 : (bool -> US7) = method22()
                    let v41943 : (exn -> US7) = method23()
                    let v41944 : US7 = match v41925 with Choice1Of2 x -> v41942 x | Choice2Of2 x -> v41943 x
                    let _v41926 = v41944 
                    #endif
#else
                    let v41945 : (bool -> US7) = method22()
                    let v41946 : (exn -> US7) = method23()
                    let v41947 : US7 = match v41925 with Choice1Of2 x -> v41945 x | Choice2Of2 x -> v41946 x
                    let _v41926 = v41947 
                    #endif
                    let v41948 : US7 = _v41926 
                    return v41948 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v41981 : Async<US7> = _v41922 
            let _v41792 = v41981 
            #endif
#else
            let v41982 : unit = ()
            let _v41982 =
                async {
                    let! v41787 = v41787 
                    let v41985 : Choice<bool, exn> = v41787 
                    let v41986 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v41987 : US7 = null |> unbox<US7>
                    let _v41986 = v41987 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v41990 : US7 = null |> unbox<US7>
                    let _v41986 = v41990 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v41993 : US7 = null |> unbox<US7>
                    let _v41986 = v41993 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v41996 : US7 = null |> unbox<US7>
                    let _v41986 = v41996 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v41999 : US7 = null |> unbox<US7>
                    let _v41986 = v41999 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v42002 : (bool -> US7) = method22()
                    let v42003 : (exn -> US7) = method23()
                    let v42004 : US7 = match v41985 with Choice1Of2 x -> v42002 x | Choice2Of2 x -> v42003 x
                    let _v41986 = v42004 
                    #endif
#else
                    let v42005 : (bool -> US7) = method22()
                    let v42006 : (exn -> US7) = method23()
                    let v42007 : US7 = match v41985 with Choice1Of2 x -> v42005 x | Choice2Of2 x -> v42006 x
                    let _v41986 = v42007 
                    #endif
                    let v42008 : US7 = _v41986 
                    return v42008 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42041 : Async<US7> = _v41982 
            let _v41792 = v42041 
            #endif
            let v42042 : Async<US7> = _v41792 
            let v42104 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42105 : Async<US8> = null |> unbox<Async<US8>>
            let _v42104 = v42105 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v42108 : Async<US8> = null |> unbox<Async<US8>>
            let _v42104 = v42108 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v42111 : Async<US8> = null |> unbox<Async<US8>>
            let _v42104 = v42111 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v42114 : unit = ()
            let _v42114 =
                async {
                    let! v42042 = v42042 
                    let v42117 : US7 = v42042 
                    let v42123 : US8 =
                        match v42117 with
                        | US7_0(v42118) -> (* C1of2 *)
                            US8_0(v42118)
                        | US7_1(v42120) -> (* C2of2 *)
                            US8_1(v42120)
                    return v42123 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42131 : Async<US8> = _v42114 
            let _v42104 = v42131 
            #endif
#if FABLE_COMPILER_PYTHON
            let v42132 : unit = ()
            let _v42132 =
                async {
                    let! v42042 = v42042 
                    let v42135 : US7 = v42042 
                    let v42141 : US8 =
                        match v42135 with
                        | US7_0(v42136) -> (* C1of2 *)
                            US8_0(v42136)
                        | US7_1(v42138) -> (* C2of2 *)
                            US8_1(v42138)
                    return v42141 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42149 : Async<US8> = _v42132 
            let _v42104 = v42149 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v42150 : unit = ()
            let _v42150 =
                async {
                    let! v42042 = v42042 
                    let v42153 : US7 = v42042 
                    let v42159 : US8 =
                        match v42153 with
                        | US7_0(v42154) -> (* C1of2 *)
                            US8_0(v42154)
                        | US7_1(v42156) -> (* C2of2 *)
                            US8_1(v42156)
                    return v42159 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42167 : Async<US8> = _v42150 
            let _v42104 = v42167 
            #endif
#else
            let v42168 : unit = ()
            let _v42168 =
                async {
                    let! v42042 = v42042 
                    let v42171 : US7 = v42042 
                    let v42177 : US8 =
                        match v42171 with
                        | US7_0(v42172) -> (* C1of2 *)
                            US8_0(v42172)
                        | US7_1(v42174) -> (* C2of2 *)
                            US8_1(v42174)
                    return v42177 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42185 : Async<US8> = _v42168 
            let _v42104 = v42185 
            #endif
            let v42186 : Async<US8> = _v42104 
            let v42206 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v42207 : Async<US6> = null |> unbox<Async<US6>>
            let _v42206 = v42207 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v42210 : Async<US6> = null |> unbox<Async<US6>>
            let _v42206 = v42210 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v42213 : Async<US6> = null |> unbox<Async<US6>>
            let _v42206 = v42213 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v42216 : unit = ()
            let _v42216 =
                async {
                    let! v42186 = v42186 
                    let v42219 : US8 = v42186 
                    let v42343 : US6 =
                        match v42219 with
                        | US8_1(v42222) -> (* Error *)
                            let v42223 : string = $"%A{v42222}"
                            let v42226 : string = "System.TimeoutException"
                            let v42227 : bool = v42223.Contains v42226 
                            if v42227 then
                                let v42230 : unit = ()
                                let v42231 : (unit -> unit) = closure16(v0)
                                let v42232 : unit = (fun () -> v42231 (); v42230) ()
                                US6_1
                            else
                                let v42273 : unit = ()
                                let v42274 : (unit -> unit) = closure17(v0, v42222)
                                let v42275 : unit = (fun () -> v42274 (); v42273) ()
                                US6_1
                        | US8_0(v42220) -> (* Ok *)
                            US6_0(v42220)
                    return v42343 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42469 : Async<US6> = _v42216 
            let _v42206 = v42469 
            #endif
#if FABLE_COMPILER_PYTHON
            let v42470 : unit = ()
            let _v42470 =
                async {
                    let! v42186 = v42186 
                    let v42473 : US8 = v42186 
                    let v42597 : US6 =
                        match v42473 with
                        | US8_1(v42476) -> (* Error *)
                            let v42477 : string = $"%A{v42476}"
                            let v42480 : string = "System.TimeoutException"
                            let v42481 : bool = v42477.Contains v42480 
                            if v42481 then
                                let v42484 : unit = ()
                                let v42485 : (unit -> unit) = closure16(v0)
                                let v42486 : unit = (fun () -> v42485 (); v42484) ()
                                US6_1
                            else
                                let v42527 : unit = ()
                                let v42528 : (unit -> unit) = closure17(v0, v42476)
                                let v42529 : unit = (fun () -> v42528 (); v42527) ()
                                US6_1
                        | US8_0(v42474) -> (* Ok *)
                            US6_0(v42474)
                    return v42597 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42723 : Async<US6> = _v42470 
            let _v42206 = v42723 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v42724 : unit = ()
            let _v42724 =
                async {
                    let! v42186 = v42186 
                    let v42727 : US8 = v42186 
                    let v42851 : US6 =
                        match v42727 with
                        | US8_1(v42730) -> (* Error *)
                            let v42731 : string = $"%A{v42730}"
                            let v42734 : string = "System.TimeoutException"
                            let v42735 : bool = v42731.Contains v42734 
                            if v42735 then
                                let v42738 : unit = ()
                                let v42739 : (unit -> unit) = closure16(v0)
                                let v42740 : unit = (fun () -> v42739 (); v42738) ()
                                US6_1
                            else
                                let v42781 : unit = ()
                                let v42782 : (unit -> unit) = closure17(v0, v42730)
                                let v42783 : unit = (fun () -> v42782 (); v42781) ()
                                US6_1
                        | US8_0(v42728) -> (* Ok *)
                            US6_0(v42728)
                    return v42851 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v42977 : Async<US6> = _v42724 
            let _v42206 = v42977 
            #endif
#else
            let v42978 : unit = ()
            let _v42978 =
                async {
                    let! v42186 = v42186 
                    let v42981 : US8 = v42186 
                    let v43105 : US6 =
                        match v42981 with
                        | US8_1(v42984) -> (* Error *)
                            let v42985 : string = $"%A{v42984}"
                            let v42988 : string = "System.TimeoutException"
                            let v42989 : bool = v42985.Contains v42988 
                            if v42989 then
                                let v42992 : unit = ()
                                let v42993 : (unit -> unit) = closure16(v0)
                                let v42994 : unit = (fun () -> v42993 (); v42992) ()
                                US6_1
                            else
                                let v43035 : unit = ()
                                let v43036 : (unit -> unit) = closure17(v0, v42984)
                                let v43037 : unit = (fun () -> v43036 (); v43035) ()
                                US6_1
                        | US8_0(v42982) -> (* Ok *)
                            US6_0(v42982)
                    return v43105 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v43231 : Async<US6> = _v42978 
            let _v42206 = v43231 
            #endif
            let v43232 : Async<US6> = _v42206 
            return! v43232 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v45224 : Async<US6> = _v41749 
    let _v34787 = v45224 
    #endif
#else
    let v45225 : unit = ()
    let _v45225 =
        async {
            let v45228 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45229 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v45228 = v45229 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45232 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v45228 = v45232 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45235 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v45228 = v45235 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45238 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v45228 = v45238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45239 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v45228 = v45239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v45240 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v45228 = v45240 
            #endif
#else
            let v45241 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v45228 = v45241 
            #endif
            let v45242 : Async<Async<bool>> = _v45228 
            let! v45242 = v45242 
            let v45247 : Async<bool> = v45242 
            let v45248 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45249 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45250 : Async<Choice<bool, exn>> = v45249 v45247
            let _v45248 = v45250 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45251 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45252 : Async<Choice<bool, exn>> = v45251 v45247
            let _v45248 = v45252 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45253 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45254 : Async<Choice<bool, exn>> = v45253 v45247
            let _v45248 = v45254 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45255 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45256 : Async<Choice<bool, exn>> = v45255 v45247
            let _v45248 = v45256 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45257 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45258 : Async<Choice<bool, exn>> = v45257 v45247
            let _v45248 = v45258 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v45259 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45260 : Async<Choice<bool, exn>> = v45259 v45247
            let _v45248 = v45260 
            #endif
#else
            let v45261 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v45262 : Async<Choice<bool, exn>> = v45261 v45247
            let _v45248 = v45262 
            #endif
            let v45263 : Async<Choice<bool, exn>> = _v45248 
            let v45268 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45269 : Async<US7> = null |> unbox<Async<US7>>
            let _v45268 = v45269 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45272 : Async<US7> = null |> unbox<Async<US7>>
            let _v45268 = v45272 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45275 : Async<US7> = null |> unbox<Async<US7>>
            let _v45268 = v45275 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45278 : unit = ()
            let _v45278 =
                async {
                    let! v45263 = v45263 
                    let v45281 : Choice<bool, exn> = v45263 
                    let v45282 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v45283 : US7 = null |> unbox<US7>
                    let _v45282 = v45283 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v45286 : US7 = null |> unbox<US7>
                    let _v45282 = v45286 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v45289 : US7 = null |> unbox<US7>
                    let _v45282 = v45289 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v45292 : US7 = null |> unbox<US7>
                    let _v45282 = v45292 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v45295 : US7 = null |> unbox<US7>
                    let _v45282 = v45295 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v45298 : (bool -> US7) = method22()
                    let v45299 : (exn -> US7) = method23()
                    let v45300 : US7 = match v45281 with Choice1Of2 x -> v45298 x | Choice2Of2 x -> v45299 x
                    let _v45282 = v45300 
                    #endif
#else
                    let v45301 : (bool -> US7) = method22()
                    let v45302 : (exn -> US7) = method23()
                    let v45303 : US7 = match v45281 with Choice1Of2 x -> v45301 x | Choice2Of2 x -> v45302 x
                    let _v45282 = v45303 
                    #endif
                    let v45304 : US7 = _v45282 
                    return v45304 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45337 : Async<US7> = _v45278 
            let _v45268 = v45337 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45338 : unit = ()
            let _v45338 =
                async {
                    let! v45263 = v45263 
                    let v45341 : Choice<bool, exn> = v45263 
                    let v45342 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v45343 : US7 = null |> unbox<US7>
                    let _v45342 = v45343 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v45346 : US7 = null |> unbox<US7>
                    let _v45342 = v45346 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v45349 : US7 = null |> unbox<US7>
                    let _v45342 = v45349 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v45352 : US7 = null |> unbox<US7>
                    let _v45342 = v45352 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v45355 : US7 = null |> unbox<US7>
                    let _v45342 = v45355 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v45358 : (bool -> US7) = method22()
                    let v45359 : (exn -> US7) = method23()
                    let v45360 : US7 = match v45341 with Choice1Of2 x -> v45358 x | Choice2Of2 x -> v45359 x
                    let _v45342 = v45360 
                    #endif
#else
                    let v45361 : (bool -> US7) = method22()
                    let v45362 : (exn -> US7) = method23()
                    let v45363 : US7 = match v45341 with Choice1Of2 x -> v45361 x | Choice2Of2 x -> v45362 x
                    let _v45342 = v45363 
                    #endif
                    let v45364 : US7 = _v45342 
                    return v45364 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45397 : Async<US7> = _v45338 
            let _v45268 = v45397 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v45398 : unit = ()
            let _v45398 =
                async {
                    let! v45263 = v45263 
                    let v45401 : Choice<bool, exn> = v45263 
                    let v45402 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v45403 : US7 = null |> unbox<US7>
                    let _v45402 = v45403 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v45406 : US7 = null |> unbox<US7>
                    let _v45402 = v45406 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v45409 : US7 = null |> unbox<US7>
                    let _v45402 = v45409 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v45412 : US7 = null |> unbox<US7>
                    let _v45402 = v45412 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v45415 : US7 = null |> unbox<US7>
                    let _v45402 = v45415 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v45418 : (bool -> US7) = method22()
                    let v45419 : (exn -> US7) = method23()
                    let v45420 : US7 = match v45401 with Choice1Of2 x -> v45418 x | Choice2Of2 x -> v45419 x
                    let _v45402 = v45420 
                    #endif
#else
                    let v45421 : (bool -> US7) = method22()
                    let v45422 : (exn -> US7) = method23()
                    let v45423 : US7 = match v45401 with Choice1Of2 x -> v45421 x | Choice2Of2 x -> v45422 x
                    let _v45402 = v45423 
                    #endif
                    let v45424 : US7 = _v45402 
                    return v45424 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45457 : Async<US7> = _v45398 
            let _v45268 = v45457 
            #endif
#else
            let v45458 : unit = ()
            let _v45458 =
                async {
                    let! v45263 = v45263 
                    let v45461 : Choice<bool, exn> = v45263 
                    let v45462 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v45463 : US7 = null |> unbox<US7>
                    let _v45462 = v45463 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v45466 : US7 = null |> unbox<US7>
                    let _v45462 = v45466 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v45469 : US7 = null |> unbox<US7>
                    let _v45462 = v45469 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v45472 : US7 = null |> unbox<US7>
                    let _v45462 = v45472 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v45475 : US7 = null |> unbox<US7>
                    let _v45462 = v45475 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v45478 : (bool -> US7) = method22()
                    let v45479 : (exn -> US7) = method23()
                    let v45480 : US7 = match v45461 with Choice1Of2 x -> v45478 x | Choice2Of2 x -> v45479 x
                    let _v45462 = v45480 
                    #endif
#else
                    let v45481 : (bool -> US7) = method22()
                    let v45482 : (exn -> US7) = method23()
                    let v45483 : US7 = match v45461 with Choice1Of2 x -> v45481 x | Choice2Of2 x -> v45482 x
                    let _v45462 = v45483 
                    #endif
                    let v45484 : US7 = _v45462 
                    return v45484 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45517 : Async<US7> = _v45458 
            let _v45268 = v45517 
            #endif
            let v45518 : Async<US7> = _v45268 
            let v45580 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45581 : Async<US8> = null |> unbox<Async<US8>>
            let _v45580 = v45581 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45584 : Async<US8> = null |> unbox<Async<US8>>
            let _v45580 = v45584 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45587 : Async<US8> = null |> unbox<Async<US8>>
            let _v45580 = v45587 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45590 : unit = ()
            let _v45590 =
                async {
                    let! v45518 = v45518 
                    let v45593 : US7 = v45518 
                    let v45599 : US8 =
                        match v45593 with
                        | US7_0(v45594) -> (* C1of2 *)
                            US8_0(v45594)
                        | US7_1(v45596) -> (* C2of2 *)
                            US8_1(v45596)
                    return v45599 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45607 : Async<US8> = _v45590 
            let _v45580 = v45607 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45608 : unit = ()
            let _v45608 =
                async {
                    let! v45518 = v45518 
                    let v45611 : US7 = v45518 
                    let v45617 : US8 =
                        match v45611 with
                        | US7_0(v45612) -> (* C1of2 *)
                            US8_0(v45612)
                        | US7_1(v45614) -> (* C2of2 *)
                            US8_1(v45614)
                    return v45617 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45625 : Async<US8> = _v45608 
            let _v45580 = v45625 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v45626 : unit = ()
            let _v45626 =
                async {
                    let! v45518 = v45518 
                    let v45629 : US7 = v45518 
                    let v45635 : US8 =
                        match v45629 with
                        | US7_0(v45630) -> (* C1of2 *)
                            US8_0(v45630)
                        | US7_1(v45632) -> (* C2of2 *)
                            US8_1(v45632)
                    return v45635 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45643 : Async<US8> = _v45626 
            let _v45580 = v45643 
            #endif
#else
            let v45644 : unit = ()
            let _v45644 =
                async {
                    let! v45518 = v45518 
                    let v45647 : US7 = v45518 
                    let v45653 : US8 =
                        match v45647 with
                        | US7_0(v45648) -> (* C1of2 *)
                            US8_0(v45648)
                        | US7_1(v45650) -> (* C2of2 *)
                            US8_1(v45650)
                    return v45653 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45661 : Async<US8> = _v45644 
            let _v45580 = v45661 
            #endif
            let v45662 : Async<US8> = _v45580 
            let v45682 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v45683 : Async<US6> = null |> unbox<Async<US6>>
            let _v45682 = v45683 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v45686 : Async<US6> = null |> unbox<Async<US6>>
            let _v45682 = v45686 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45689 : Async<US6> = null |> unbox<Async<US6>>
            let _v45682 = v45689 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v45692 : unit = ()
            let _v45692 =
                async {
                    let! v45662 = v45662 
                    let v45695 : US8 = v45662 
                    let v45819 : US6 =
                        match v45695 with
                        | US8_1(v45698) -> (* Error *)
                            let v45699 : string = $"%A{v45698}"
                            let v45702 : string = "System.TimeoutException"
                            let v45703 : bool = v45699.Contains v45702 
                            if v45703 then
                                let v45706 : unit = ()
                                let v45707 : (unit -> unit) = closure16(v0)
                                let v45708 : unit = (fun () -> v45707 (); v45706) ()
                                US6_1
                            else
                                let v45749 : unit = ()
                                let v45750 : (unit -> unit) = closure17(v0, v45698)
                                let v45751 : unit = (fun () -> v45750 (); v45749) ()
                                US6_1
                        | US8_0(v45696) -> (* Ok *)
                            US6_0(v45696)
                    return v45819 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v45945 : Async<US6> = _v45692 
            let _v45682 = v45945 
            #endif
#if FABLE_COMPILER_PYTHON
            let v45946 : unit = ()
            let _v45946 =
                async {
                    let! v45662 = v45662 
                    let v45949 : US8 = v45662 
                    let v46073 : US6 =
                        match v45949 with
                        | US8_1(v45952) -> (* Error *)
                            let v45953 : string = $"%A{v45952}"
                            let v45956 : string = "System.TimeoutException"
                            let v45957 : bool = v45953.Contains v45956 
                            if v45957 then
                                let v45960 : unit = ()
                                let v45961 : (unit -> unit) = closure16(v0)
                                let v45962 : unit = (fun () -> v45961 (); v45960) ()
                                US6_1
                            else
                                let v46003 : unit = ()
                                let v46004 : (unit -> unit) = closure17(v0, v45952)
                                let v46005 : unit = (fun () -> v46004 (); v46003) ()
                                US6_1
                        | US8_0(v45950) -> (* Ok *)
                            US6_0(v45950)
                    return v46073 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v46199 : Async<US6> = _v45946 
            let _v45682 = v46199 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v46200 : unit = ()
            let _v46200 =
                async {
                    let! v45662 = v45662 
                    let v46203 : US8 = v45662 
                    let v46327 : US6 =
                        match v46203 with
                        | US8_1(v46206) -> (* Error *)
                            let v46207 : string = $"%A{v46206}"
                            let v46210 : string = "System.TimeoutException"
                            let v46211 : bool = v46207.Contains v46210 
                            if v46211 then
                                let v46214 : unit = ()
                                let v46215 : (unit -> unit) = closure16(v0)
                                let v46216 : unit = (fun () -> v46215 (); v46214) ()
                                US6_1
                            else
                                let v46257 : unit = ()
                                let v46258 : (unit -> unit) = closure17(v0, v46206)
                                let v46259 : unit = (fun () -> v46258 (); v46257) ()
                                US6_1
                        | US8_0(v46204) -> (* Ok *)
                            US6_0(v46204)
                    return v46327 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v46453 : Async<US6> = _v46200 
            let _v45682 = v46453 
            #endif
#else
            let v46454 : unit = ()
            let _v46454 =
                async {
                    let! v45662 = v45662 
                    let v46457 : US8 = v45662 
                    let v46581 : US6 =
                        match v46457 with
                        | US8_1(v46460) -> (* Error *)
                            let v46461 : string = $"%A{v46460}"
                            let v46464 : string = "System.TimeoutException"
                            let v46465 : bool = v46461.Contains v46464 
                            if v46465 then
                                let v46468 : unit = ()
                                let v46469 : (unit -> unit) = closure16(v0)
                                let v46470 : unit = (fun () -> v46469 (); v46468) ()
                                US6_1
                            else
                                let v46511 : unit = ()
                                let v46512 : (unit -> unit) = closure17(v0, v46460)
                                let v46513 : unit = (fun () -> v46512 (); v46511) ()
                                US6_1
                        | US8_0(v46458) -> (* Ok *)
                            US6_0(v46458)
                    return v46581 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v46707 : Async<US6> = _v46454 
            let _v45682 = v46707 
            #endif
            let v46708 : Async<US6> = _v45682 
            return! v46708 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v48700 : Async<US6> = _v45225 
    let _v34787 = v48700 
    #endif
    let v48701 : Async<US6> = _v34787 
    let _v2 = v48701 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52179 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52180 : Async<US6> = null |> unbox<Async<US6>>
    let _v52179 = v52180 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v52183 : Async<US6> = null |> unbox<Async<US6>>
    let _v52179 = v52183 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v52186 : Async<US6> = null |> unbox<Async<US6>>
    let _v52179 = v52186 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v52189 : unit = ()
    let _v52189 =
        async {
            let v52192 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52193 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v52192 = v52193 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52196 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v52192 = v52196 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52199 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v52192 = v52199 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52202 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v52192 = v52202 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52203 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v52192 = v52203 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52204 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v52192 = v52204 
            #endif
#else
            let v52205 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v52192 = v52205 
            #endif
            let v52206 : Async<Async<bool>> = _v52192 
            let! v52206 = v52206 
            let v52211 : Async<bool> = v52206 
            let v52212 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52213 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52214 : Async<Choice<bool, exn>> = v52213 v52211
            let _v52212 = v52214 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52215 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52216 : Async<Choice<bool, exn>> = v52215 v52211
            let _v52212 = v52216 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52217 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52218 : Async<Choice<bool, exn>> = v52217 v52211
            let _v52212 = v52218 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52219 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52220 : Async<Choice<bool, exn>> = v52219 v52211
            let _v52212 = v52220 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52221 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52222 : Async<Choice<bool, exn>> = v52221 v52211
            let _v52212 = v52222 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52223 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52224 : Async<Choice<bool, exn>> = v52223 v52211
            let _v52212 = v52224 
            #endif
#else
            let v52225 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v52226 : Async<Choice<bool, exn>> = v52225 v52211
            let _v52212 = v52226 
            #endif
            let v52227 : Async<Choice<bool, exn>> = _v52212 
            let v52232 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52233 : Async<US7> = null |> unbox<Async<US7>>
            let _v52232 = v52233 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52236 : Async<US7> = null |> unbox<Async<US7>>
            let _v52232 = v52236 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52239 : Async<US7> = null |> unbox<Async<US7>>
            let _v52232 = v52239 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52242 : unit = ()
            let _v52242 =
                async {
                    let! v52227 = v52227 
                    let v52245 : Choice<bool, exn> = v52227 
                    let v52246 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v52247 : US7 = null |> unbox<US7>
                    let _v52246 = v52247 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v52250 : US7 = null |> unbox<US7>
                    let _v52246 = v52250 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v52253 : US7 = null |> unbox<US7>
                    let _v52246 = v52253 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v52256 : US7 = null |> unbox<US7>
                    let _v52246 = v52256 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v52259 : US7 = null |> unbox<US7>
                    let _v52246 = v52259 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v52262 : (bool -> US7) = method22()
                    let v52263 : (exn -> US7) = method23()
                    let v52264 : US7 = match v52245 with Choice1Of2 x -> v52262 x | Choice2Of2 x -> v52263 x
                    let _v52246 = v52264 
                    #endif
#else
                    let v52265 : (bool -> US7) = method22()
                    let v52266 : (exn -> US7) = method23()
                    let v52267 : US7 = match v52245 with Choice1Of2 x -> v52265 x | Choice2Of2 x -> v52266 x
                    let _v52246 = v52267 
                    #endif
                    let v52268 : US7 = _v52246 
                    return v52268 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52301 : Async<US7> = _v52242 
            let _v52232 = v52301 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52302 : unit = ()
            let _v52302 =
                async {
                    let! v52227 = v52227 
                    let v52305 : Choice<bool, exn> = v52227 
                    let v52306 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v52307 : US7 = null |> unbox<US7>
                    let _v52306 = v52307 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v52310 : US7 = null |> unbox<US7>
                    let _v52306 = v52310 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v52313 : US7 = null |> unbox<US7>
                    let _v52306 = v52313 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v52316 : US7 = null |> unbox<US7>
                    let _v52306 = v52316 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v52319 : US7 = null |> unbox<US7>
                    let _v52306 = v52319 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v52322 : (bool -> US7) = method22()
                    let v52323 : (exn -> US7) = method23()
                    let v52324 : US7 = match v52305 with Choice1Of2 x -> v52322 x | Choice2Of2 x -> v52323 x
                    let _v52306 = v52324 
                    #endif
#else
                    let v52325 : (bool -> US7) = method22()
                    let v52326 : (exn -> US7) = method23()
                    let v52327 : US7 = match v52305 with Choice1Of2 x -> v52325 x | Choice2Of2 x -> v52326 x
                    let _v52306 = v52327 
                    #endif
                    let v52328 : US7 = _v52306 
                    return v52328 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52361 : Async<US7> = _v52302 
            let _v52232 = v52361 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52362 : unit = ()
            let _v52362 =
                async {
                    let! v52227 = v52227 
                    let v52365 : Choice<bool, exn> = v52227 
                    let v52366 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v52367 : US7 = null |> unbox<US7>
                    let _v52366 = v52367 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v52370 : US7 = null |> unbox<US7>
                    let _v52366 = v52370 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v52373 : US7 = null |> unbox<US7>
                    let _v52366 = v52373 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v52376 : US7 = null |> unbox<US7>
                    let _v52366 = v52376 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v52379 : US7 = null |> unbox<US7>
                    let _v52366 = v52379 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v52382 : (bool -> US7) = method22()
                    let v52383 : (exn -> US7) = method23()
                    let v52384 : US7 = match v52365 with Choice1Of2 x -> v52382 x | Choice2Of2 x -> v52383 x
                    let _v52366 = v52384 
                    #endif
#else
                    let v52385 : (bool -> US7) = method22()
                    let v52386 : (exn -> US7) = method23()
                    let v52387 : US7 = match v52365 with Choice1Of2 x -> v52385 x | Choice2Of2 x -> v52386 x
                    let _v52366 = v52387 
                    #endif
                    let v52388 : US7 = _v52366 
                    return v52388 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52421 : Async<US7> = _v52362 
            let _v52232 = v52421 
            #endif
#else
            let v52422 : unit = ()
            let _v52422 =
                async {
                    let! v52227 = v52227 
                    let v52425 : Choice<bool, exn> = v52227 
                    let v52426 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v52427 : US7 = null |> unbox<US7>
                    let _v52426 = v52427 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v52430 : US7 = null |> unbox<US7>
                    let _v52426 = v52430 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v52433 : US7 = null |> unbox<US7>
                    let _v52426 = v52433 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v52436 : US7 = null |> unbox<US7>
                    let _v52426 = v52436 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v52439 : US7 = null |> unbox<US7>
                    let _v52426 = v52439 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v52442 : (bool -> US7) = method22()
                    let v52443 : (exn -> US7) = method23()
                    let v52444 : US7 = match v52425 with Choice1Of2 x -> v52442 x | Choice2Of2 x -> v52443 x
                    let _v52426 = v52444 
                    #endif
#else
                    let v52445 : (bool -> US7) = method22()
                    let v52446 : (exn -> US7) = method23()
                    let v52447 : US7 = match v52425 with Choice1Of2 x -> v52445 x | Choice2Of2 x -> v52446 x
                    let _v52426 = v52447 
                    #endif
                    let v52448 : US7 = _v52426 
                    return v52448 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52481 : Async<US7> = _v52422 
            let _v52232 = v52481 
            #endif
            let v52482 : Async<US7> = _v52232 
            let v52544 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52545 : Async<US8> = null |> unbox<Async<US8>>
            let _v52544 = v52545 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52548 : Async<US8> = null |> unbox<Async<US8>>
            let _v52544 = v52548 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52551 : Async<US8> = null |> unbox<Async<US8>>
            let _v52544 = v52551 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52554 : unit = ()
            let _v52554 =
                async {
                    let! v52482 = v52482 
                    let v52557 : US7 = v52482 
                    let v52563 : US8 =
                        match v52557 with
                        | US7_0(v52558) -> (* C1of2 *)
                            US8_0(v52558)
                        | US7_1(v52560) -> (* C2of2 *)
                            US8_1(v52560)
                    return v52563 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52571 : Async<US8> = _v52554 
            let _v52544 = v52571 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52572 : unit = ()
            let _v52572 =
                async {
                    let! v52482 = v52482 
                    let v52575 : US7 = v52482 
                    let v52581 : US8 =
                        match v52575 with
                        | US7_0(v52576) -> (* C1of2 *)
                            US8_0(v52576)
                        | US7_1(v52578) -> (* C2of2 *)
                            US8_1(v52578)
                    return v52581 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52589 : Async<US8> = _v52572 
            let _v52544 = v52589 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52590 : unit = ()
            let _v52590 =
                async {
                    let! v52482 = v52482 
                    let v52593 : US7 = v52482 
                    let v52599 : US8 =
                        match v52593 with
                        | US7_0(v52594) -> (* C1of2 *)
                            US8_0(v52594)
                        | US7_1(v52596) -> (* C2of2 *)
                            US8_1(v52596)
                    return v52599 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52607 : Async<US8> = _v52590 
            let _v52544 = v52607 
            #endif
#else
            let v52608 : unit = ()
            let _v52608 =
                async {
                    let! v52482 = v52482 
                    let v52611 : US7 = v52482 
                    let v52617 : US8 =
                        match v52611 with
                        | US7_0(v52612) -> (* C1of2 *)
                            US8_0(v52612)
                        | US7_1(v52614) -> (* C2of2 *)
                            US8_1(v52614)
                    return v52617 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52625 : Async<US8> = _v52608 
            let _v52544 = v52625 
            #endif
            let v52626 : Async<US8> = _v52544 
            let v52646 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52647 : Async<US6> = null |> unbox<Async<US6>>
            let _v52646 = v52647 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52650 : Async<US6> = null |> unbox<Async<US6>>
            let _v52646 = v52650 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52653 : Async<US6> = null |> unbox<Async<US6>>
            let _v52646 = v52653 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52656 : unit = ()
            let _v52656 =
                async {
                    let! v52626 = v52626 
                    let v52659 : US8 = v52626 
                    let v52783 : US6 =
                        match v52659 with
                        | US8_1(v52662) -> (* Error *)
                            let v52663 : string = $"%A{v52662}"
                            let v52666 : string = "System.TimeoutException"
                            let v52667 : bool = v52663.Contains v52666 
                            if v52667 then
                                let v52670 : unit = ()
                                let v52671 : (unit -> unit) = closure16(v0)
                                let v52672 : unit = (fun () -> v52671 (); v52670) ()
                                US6_1
                            else
                                let v52713 : unit = ()
                                let v52714 : (unit -> unit) = closure17(v0, v52662)
                                let v52715 : unit = (fun () -> v52714 (); v52713) ()
                                US6_1
                        | US8_0(v52660) -> (* Ok *)
                            US6_0(v52660)
                    return v52783 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52909 : Async<US6> = _v52656 
            let _v52646 = v52909 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52910 : unit = ()
            let _v52910 =
                async {
                    let! v52626 = v52626 
                    let v52913 : US8 = v52626 
                    let v53037 : US6 =
                        match v52913 with
                        | US8_1(v52916) -> (* Error *)
                            let v52917 : string = $"%A{v52916}"
                            let v52920 : string = "System.TimeoutException"
                            let v52921 : bool = v52917.Contains v52920 
                            if v52921 then
                                let v52924 : unit = ()
                                let v52925 : (unit -> unit) = closure16(v0)
                                let v52926 : unit = (fun () -> v52925 (); v52924) ()
                                US6_1
                            else
                                let v52967 : unit = ()
                                let v52968 : (unit -> unit) = closure17(v0, v52916)
                                let v52969 : unit = (fun () -> v52968 (); v52967) ()
                                US6_1
                        | US8_0(v52914) -> (* Ok *)
                            US6_0(v52914)
                    return v53037 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v53163 : Async<US6> = _v52910 
            let _v52646 = v53163 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v53164 : unit = ()
            let _v53164 =
                async {
                    let! v52626 = v52626 
                    let v53167 : US8 = v52626 
                    let v53291 : US6 =
                        match v53167 with
                        | US8_1(v53170) -> (* Error *)
                            let v53171 : string = $"%A{v53170}"
                            let v53174 : string = "System.TimeoutException"
                            let v53175 : bool = v53171.Contains v53174 
                            if v53175 then
                                let v53178 : unit = ()
                                let v53179 : (unit -> unit) = closure16(v0)
                                let v53180 : unit = (fun () -> v53179 (); v53178) ()
                                US6_1
                            else
                                let v53221 : unit = ()
                                let v53222 : (unit -> unit) = closure17(v0, v53170)
                                let v53223 : unit = (fun () -> v53222 (); v53221) ()
                                US6_1
                        | US8_0(v53168) -> (* Ok *)
                            US6_0(v53168)
                    return v53291 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v53417 : Async<US6> = _v53164 
            let _v52646 = v53417 
            #endif
#else
            let v53418 : unit = ()
            let _v53418 =
                async {
                    let! v52626 = v52626 
                    let v53421 : US8 = v52626 
                    let v53545 : US6 =
                        match v53421 with
                        | US8_1(v53424) -> (* Error *)
                            let v53425 : string = $"%A{v53424}"
                            let v53428 : string = "System.TimeoutException"
                            let v53429 : bool = v53425.Contains v53428 
                            if v53429 then
                                let v53432 : unit = ()
                                let v53433 : (unit -> unit) = closure16(v0)
                                let v53434 : unit = (fun () -> v53433 (); v53432) ()
                                US6_1
                            else
                                let v53475 : unit = ()
                                let v53476 : (unit -> unit) = closure17(v0, v53424)
                                let v53477 : unit = (fun () -> v53476 (); v53475) ()
                                US6_1
                        | US8_0(v53422) -> (* Ok *)
                            US6_0(v53422)
                    return v53545 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v53671 : Async<US6> = _v53418 
            let _v52646 = v53671 
            #endif
            let v53672 : Async<US6> = _v52646 
            return! v53672 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v55664 : Async<US6> = _v52189 
    let _v52179 = v55664 
    #endif
#if FABLE_COMPILER_PYTHON
    let v55665 : unit = ()
    let _v55665 =
        async {
            let v55668 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55669 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v55668 = v55669 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v55672 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v55668 = v55672 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v55675 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v55668 = v55675 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v55678 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v55668 = v55678 
            #endif
#if FABLE_COMPILER_PYTHON
            let v55679 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v55668 = v55679 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v55680 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v55668 = v55680 
            #endif
#else
            let v55681 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v55668 = v55681 
            #endif
            let v55682 : Async<Async<bool>> = _v55668 
            let! v55682 = v55682 
            let v55687 : Async<bool> = v55682 
            let v55688 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55689 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55690 : Async<Choice<bool, exn>> = v55689 v55687
            let _v55688 = v55690 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v55691 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55692 : Async<Choice<bool, exn>> = v55691 v55687
            let _v55688 = v55692 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v55693 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55694 : Async<Choice<bool, exn>> = v55693 v55687
            let _v55688 = v55694 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v55695 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55696 : Async<Choice<bool, exn>> = v55695 v55687
            let _v55688 = v55696 
            #endif
#if FABLE_COMPILER_PYTHON
            let v55697 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55698 : Async<Choice<bool, exn>> = v55697 v55687
            let _v55688 = v55698 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v55699 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55700 : Async<Choice<bool, exn>> = v55699 v55687
            let _v55688 = v55700 
            #endif
#else
            let v55701 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v55702 : Async<Choice<bool, exn>> = v55701 v55687
            let _v55688 = v55702 
            #endif
            let v55703 : Async<Choice<bool, exn>> = _v55688 
            let v55708 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v55709 : Async<US7> = null |> unbox<Async<US7>>
            let _v55708 = v55709 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v55712 : Async<US7> = null |> unbox<Async<US7>>
            let _v55708 = v55712 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v55715 : Async<US7> = null |> unbox<Async<US7>>
            let _v55708 = v55715 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v55718 : unit = ()
            let _v55718 =
                async {
                    let! v55703 = v55703 
                    let v55721 : Choice<bool, exn> = v55703 
                    let v55722 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v55723 : US7 = null |> unbox<US7>
                    let _v55722 = v55723 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v55726 : US7 = null |> unbox<US7>
                    let _v55722 = v55726 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v55729 : US7 = null |> unbox<US7>
                    let _v55722 = v55729 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v55732 : US7 = null |> unbox<US7>
                    let _v55722 = v55732 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v55735 : US7 = null |> unbox<US7>
                    let _v55722 = v55735 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v55738 : (bool -> US7) = method22()
                    let v55739 : (exn -> US7) = method23()
                    let v55740 : US7 = match v55721 with Choice1Of2 x -> v55738 x | Choice2Of2 x -> v55739 x
                    let _v55722 = v55740 
                    #endif
#else
                    let v55741 : (bool -> US7) = method22()
                    let v55742 : (exn -> US7) = method23()
                    let v55743 : US7 = match v55721 with Choice1Of2 x -> v55741 x | Choice2Of2 x -> v55742 x
                    let _v55722 = v55743 
                    #endif
                    let v55744 : US7 = _v55722 
                    return v55744 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v55777 : Async<US7> = _v55718 
            let _v55708 = v55777 
            #endif
#if FABLE_COMPILER_PYTHON
            let v55778 : unit = ()
            let _v55778 =
                async {
                    let! v55703 = v55703 
                    let v55781 : Choice<bool, exn> = v55703 
                    let v55782 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v55783 : US7 = null |> unbox<US7>
                    let _v55782 = v55783 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v55786 : US7 = null |> unbox<US7>
                    let _v55782 = v55786 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v55789 : US7 = null |> unbox<US7>
                    let _v55782 = v55789 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v55792 : US7 = null |> unbox<US7>
                    let _v55782 = v55792 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v55795 : US7 = null |> unbox<US7>
                    let _v55782 = v55795 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v55798 : (bool -> US7) = method22()
                    let v55799 : (exn -> US7) = method23()
                    let v55800 : US7 = match v55781 with Choice1Of2 x -> v55798 x | Choice2Of2 x -> v55799 x
                    let _v55782 = v55800 
                    #endif
#else
                    let v55801 : (bool -> US7) = method22()
                    let v55802 : (exn -> US7) = method23()
                    let v55803 : US7 = match v55781 with Choice1Of2 x -> v55801 x | Choice2Of2 x -> v55802 x
                    let _v55782 = v55803 
                    #endif
                    let v55804 : US7 = _v55782 
                    return v55804 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v55837 : Async<US7> = _v55778 
            let _v55708 = v55837 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v55838 : unit = ()
            let _v55838 =
                async {
                    let! v55703 = v55703 
                    let v55841 : Choice<bool, exn> = v55703 
                    let v55842 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v55843 : US7 = null |> unbox<US7>
                    let _v55842 = v55843 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v55846 : US7 = null |> unbox<US7>
                    let _v55842 = v55846 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v55849 : US7 = null |> unbox<US7>
                    let _v55842 = v55849 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v55852 : US7 = null |> unbox<US7>
                    let _v55842 = v55852 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v55855 : US7 = null |> unbox<US7>
                    let _v55842 = v55855 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v55858 : (bool -> US7) = method22()
                    let v55859 : (exn -> US7) = method23()
                    let v55860 : US7 = match v55841 with Choice1Of2 x -> v55858 x | Choice2Of2 x -> v55859 x
                    let _v55842 = v55860 
                    #endif
#else
                    let v55861 : (bool -> US7) = method22()
                    let v55862 : (exn -> US7) = method23()
                    let v55863 : US7 = match v55841 with Choice1Of2 x -> v55861 x | Choice2Of2 x -> v55862 x
                    let _v55842 = v55863 
                    #endif
                    let v55864 : US7 = _v55842 
                    return v55864 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v55897 : Async<US7> = _v55838 
            let _v55708 = v55897 
            #endif
#else
            let v55898 : unit = ()
            let _v55898 =
                async {
                    let! v55703 = v55703 
                    let v55901 : Choice<bool, exn> = v55703 
                    let v55902 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v55903 : US7 = null |> unbox<US7>
                    let _v55902 = v55903 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v55906 : US7 = null |> unbox<US7>
                    let _v55902 = v55906 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v55909 : US7 = null |> unbox<US7>
                    let _v55902 = v55909 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v55912 : US7 = null |> unbox<US7>
                    let _v55902 = v55912 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v55915 : US7 = null |> unbox<US7>
                    let _v55902 = v55915 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v55918 : (bool -> US7) = method22()
                    let v55919 : (exn -> US7) = method23()
                    let v55920 : US7 = match v55901 with Choice1Of2 x -> v55918 x | Choice2Of2 x -> v55919 x
                    let _v55902 = v55920 
                    #endif
#else
                    let v55921 : (bool -> US7) = method22()
                    let v55922 : (exn -> US7) = method23()
                    let v55923 : US7 = match v55901 with Choice1Of2 x -> v55921 x | Choice2Of2 x -> v55922 x
                    let _v55902 = v55923 
                    #endif
                    let v55924 : US7 = _v55902 
                    return v55924 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v55957 : Async<US7> = _v55898 
            let _v55708 = v55957 
            #endif
            let v55958 : Async<US7> = _v55708 
            let v56020 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56021 : Async<US8> = null |> unbox<Async<US8>>
            let _v56020 = v56021 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v56024 : Async<US8> = null |> unbox<Async<US8>>
            let _v56020 = v56024 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v56027 : Async<US8> = null |> unbox<Async<US8>>
            let _v56020 = v56027 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v56030 : unit = ()
            let _v56030 =
                async {
                    let! v55958 = v55958 
                    let v56033 : US7 = v55958 
                    let v56039 : US8 =
                        match v56033 with
                        | US7_0(v56034) -> (* C1of2 *)
                            US8_0(v56034)
                        | US7_1(v56036) -> (* C2of2 *)
                            US8_1(v56036)
                    return v56039 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56047 : Async<US8> = _v56030 
            let _v56020 = v56047 
            #endif
#if FABLE_COMPILER_PYTHON
            let v56048 : unit = ()
            let _v56048 =
                async {
                    let! v55958 = v55958 
                    let v56051 : US7 = v55958 
                    let v56057 : US8 =
                        match v56051 with
                        | US7_0(v56052) -> (* C1of2 *)
                            US8_0(v56052)
                        | US7_1(v56054) -> (* C2of2 *)
                            US8_1(v56054)
                    return v56057 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56065 : Async<US8> = _v56048 
            let _v56020 = v56065 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v56066 : unit = ()
            let _v56066 =
                async {
                    let! v55958 = v55958 
                    let v56069 : US7 = v55958 
                    let v56075 : US8 =
                        match v56069 with
                        | US7_0(v56070) -> (* C1of2 *)
                            US8_0(v56070)
                        | US7_1(v56072) -> (* C2of2 *)
                            US8_1(v56072)
                    return v56075 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56083 : Async<US8> = _v56066 
            let _v56020 = v56083 
            #endif
#else
            let v56084 : unit = ()
            let _v56084 =
                async {
                    let! v55958 = v55958 
                    let v56087 : US7 = v55958 
                    let v56093 : US8 =
                        match v56087 with
                        | US7_0(v56088) -> (* C1of2 *)
                            US8_0(v56088)
                        | US7_1(v56090) -> (* C2of2 *)
                            US8_1(v56090)
                    return v56093 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56101 : Async<US8> = _v56084 
            let _v56020 = v56101 
            #endif
            let v56102 : Async<US8> = _v56020 
            let v56122 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v56123 : Async<US6> = null |> unbox<Async<US6>>
            let _v56122 = v56123 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v56126 : Async<US6> = null |> unbox<Async<US6>>
            let _v56122 = v56126 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v56129 : Async<US6> = null |> unbox<Async<US6>>
            let _v56122 = v56129 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v56132 : unit = ()
            let _v56132 =
                async {
                    let! v56102 = v56102 
                    let v56135 : US8 = v56102 
                    let v56259 : US6 =
                        match v56135 with
                        | US8_1(v56138) -> (* Error *)
                            let v56139 : string = $"%A{v56138}"
                            let v56142 : string = "System.TimeoutException"
                            let v56143 : bool = v56139.Contains v56142 
                            if v56143 then
                                let v56146 : unit = ()
                                let v56147 : (unit -> unit) = closure16(v0)
                                let v56148 : unit = (fun () -> v56147 (); v56146) ()
                                US6_1
                            else
                                let v56189 : unit = ()
                                let v56190 : (unit -> unit) = closure17(v0, v56138)
                                let v56191 : unit = (fun () -> v56190 (); v56189) ()
                                US6_1
                        | US8_0(v56136) -> (* Ok *)
                            US6_0(v56136)
                    return v56259 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56385 : Async<US6> = _v56132 
            let _v56122 = v56385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v56386 : unit = ()
            let _v56386 =
                async {
                    let! v56102 = v56102 
                    let v56389 : US8 = v56102 
                    let v56513 : US6 =
                        match v56389 with
                        | US8_1(v56392) -> (* Error *)
                            let v56393 : string = $"%A{v56392}"
                            let v56396 : string = "System.TimeoutException"
                            let v56397 : bool = v56393.Contains v56396 
                            if v56397 then
                                let v56400 : unit = ()
                                let v56401 : (unit -> unit) = closure16(v0)
                                let v56402 : unit = (fun () -> v56401 (); v56400) ()
                                US6_1
                            else
                                let v56443 : unit = ()
                                let v56444 : (unit -> unit) = closure17(v0, v56392)
                                let v56445 : unit = (fun () -> v56444 (); v56443) ()
                                US6_1
                        | US8_0(v56390) -> (* Ok *)
                            US6_0(v56390)
                    return v56513 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56639 : Async<US6> = _v56386 
            let _v56122 = v56639 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v56640 : unit = ()
            let _v56640 =
                async {
                    let! v56102 = v56102 
                    let v56643 : US8 = v56102 
                    let v56767 : US6 =
                        match v56643 with
                        | US8_1(v56646) -> (* Error *)
                            let v56647 : string = $"%A{v56646}"
                            let v56650 : string = "System.TimeoutException"
                            let v56651 : bool = v56647.Contains v56650 
                            if v56651 then
                                let v56654 : unit = ()
                                let v56655 : (unit -> unit) = closure16(v0)
                                let v56656 : unit = (fun () -> v56655 (); v56654) ()
                                US6_1
                            else
                                let v56697 : unit = ()
                                let v56698 : (unit -> unit) = closure17(v0, v56646)
                                let v56699 : unit = (fun () -> v56698 (); v56697) ()
                                US6_1
                        | US8_0(v56644) -> (* Ok *)
                            US6_0(v56644)
                    return v56767 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v56893 : Async<US6> = _v56640 
            let _v56122 = v56893 
            #endif
#else
            let v56894 : unit = ()
            let _v56894 =
                async {
                    let! v56102 = v56102 
                    let v56897 : US8 = v56102 
                    let v57021 : US6 =
                        match v56897 with
                        | US8_1(v56900) -> (* Error *)
                            let v56901 : string = $"%A{v56900}"
                            let v56904 : string = "System.TimeoutException"
                            let v56905 : bool = v56901.Contains v56904 
                            if v56905 then
                                let v56908 : unit = ()
                                let v56909 : (unit -> unit) = closure16(v0)
                                let v56910 : unit = (fun () -> v56909 (); v56908) ()
                                US6_1
                            else
                                let v56951 : unit = ()
                                let v56952 : (unit -> unit) = closure17(v0, v56900)
                                let v56953 : unit = (fun () -> v56952 (); v56951) ()
                                US6_1
                        | US8_0(v56898) -> (* Ok *)
                            US6_0(v56898)
                    return v57021 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v57147 : Async<US6> = _v56894 
            let _v56122 = v57147 
            #endif
            let v57148 : Async<US6> = _v56122 
            return! v57148 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v59140 : Async<US6> = _v55665 
    let _v52179 = v59140 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v59141 : unit = ()
    let _v59141 =
        async {
            let v59144 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v59145 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v59144 = v59145 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59148 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v59144 = v59148 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59151 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v59144 = v59151 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59154 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v59144 = v59154 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59155 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v59144 = v59155 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v59156 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v59144 = v59156 
            #endif
#else
            let v59157 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v59144 = v59157 
            #endif
            let v59158 : Async<Async<bool>> = _v59144 
            let! v59158 = v59158 
            let v59163 : Async<bool> = v59158 
            let v59164 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v59165 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59166 : Async<Choice<bool, exn>> = v59165 v59163
            let _v59164 = v59166 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59167 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59168 : Async<Choice<bool, exn>> = v59167 v59163
            let _v59164 = v59168 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59169 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59170 : Async<Choice<bool, exn>> = v59169 v59163
            let _v59164 = v59170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59171 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59172 : Async<Choice<bool, exn>> = v59171 v59163
            let _v59164 = v59172 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59173 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59174 : Async<Choice<bool, exn>> = v59173 v59163
            let _v59164 = v59174 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v59175 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59176 : Async<Choice<bool, exn>> = v59175 v59163
            let _v59164 = v59176 
            #endif
#else
            let v59177 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v59178 : Async<Choice<bool, exn>> = v59177 v59163
            let _v59164 = v59178 
            #endif
            let v59179 : Async<Choice<bool, exn>> = _v59164 
            let v59184 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v59185 : Async<US7> = null |> unbox<Async<US7>>
            let _v59184 = v59185 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59188 : Async<US7> = null |> unbox<Async<US7>>
            let _v59184 = v59188 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59191 : Async<US7> = null |> unbox<Async<US7>>
            let _v59184 = v59191 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59194 : unit = ()
            let _v59194 =
                async {
                    let! v59179 = v59179 
                    let v59197 : Choice<bool, exn> = v59179 
                    let v59198 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v59199 : US7 = null |> unbox<US7>
                    let _v59198 = v59199 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v59202 : US7 = null |> unbox<US7>
                    let _v59198 = v59202 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v59205 : US7 = null |> unbox<US7>
                    let _v59198 = v59205 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v59208 : US7 = null |> unbox<US7>
                    let _v59198 = v59208 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v59211 : US7 = null |> unbox<US7>
                    let _v59198 = v59211 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v59214 : (bool -> US7) = method22()
                    let v59215 : (exn -> US7) = method23()
                    let v59216 : US7 = match v59197 with Choice1Of2 x -> v59214 x | Choice2Of2 x -> v59215 x
                    let _v59198 = v59216 
                    #endif
#else
                    let v59217 : (bool -> US7) = method22()
                    let v59218 : (exn -> US7) = method23()
                    let v59219 : US7 = match v59197 with Choice1Of2 x -> v59217 x | Choice2Of2 x -> v59218 x
                    let _v59198 = v59219 
                    #endif
                    let v59220 : US7 = _v59198 
                    return v59220 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59253 : Async<US7> = _v59194 
            let _v59184 = v59253 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59254 : unit = ()
            let _v59254 =
                async {
                    let! v59179 = v59179 
                    let v59257 : Choice<bool, exn> = v59179 
                    let v59258 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v59259 : US7 = null |> unbox<US7>
                    let _v59258 = v59259 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v59262 : US7 = null |> unbox<US7>
                    let _v59258 = v59262 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v59265 : US7 = null |> unbox<US7>
                    let _v59258 = v59265 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v59268 : US7 = null |> unbox<US7>
                    let _v59258 = v59268 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v59271 : US7 = null |> unbox<US7>
                    let _v59258 = v59271 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v59274 : (bool -> US7) = method22()
                    let v59275 : (exn -> US7) = method23()
                    let v59276 : US7 = match v59257 with Choice1Of2 x -> v59274 x | Choice2Of2 x -> v59275 x
                    let _v59258 = v59276 
                    #endif
#else
                    let v59277 : (bool -> US7) = method22()
                    let v59278 : (exn -> US7) = method23()
                    let v59279 : US7 = match v59257 with Choice1Of2 x -> v59277 x | Choice2Of2 x -> v59278 x
                    let _v59258 = v59279 
                    #endif
                    let v59280 : US7 = _v59258 
                    return v59280 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59313 : Async<US7> = _v59254 
            let _v59184 = v59313 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v59314 : unit = ()
            let _v59314 =
                async {
                    let! v59179 = v59179 
                    let v59317 : Choice<bool, exn> = v59179 
                    let v59318 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v59319 : US7 = null |> unbox<US7>
                    let _v59318 = v59319 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v59322 : US7 = null |> unbox<US7>
                    let _v59318 = v59322 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v59325 : US7 = null |> unbox<US7>
                    let _v59318 = v59325 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v59328 : US7 = null |> unbox<US7>
                    let _v59318 = v59328 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v59331 : US7 = null |> unbox<US7>
                    let _v59318 = v59331 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v59334 : (bool -> US7) = method22()
                    let v59335 : (exn -> US7) = method23()
                    let v59336 : US7 = match v59317 with Choice1Of2 x -> v59334 x | Choice2Of2 x -> v59335 x
                    let _v59318 = v59336 
                    #endif
#else
                    let v59337 : (bool -> US7) = method22()
                    let v59338 : (exn -> US7) = method23()
                    let v59339 : US7 = match v59317 with Choice1Of2 x -> v59337 x | Choice2Of2 x -> v59338 x
                    let _v59318 = v59339 
                    #endif
                    let v59340 : US7 = _v59318 
                    return v59340 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59373 : Async<US7> = _v59314 
            let _v59184 = v59373 
            #endif
#else
            let v59374 : unit = ()
            let _v59374 =
                async {
                    let! v59179 = v59179 
                    let v59377 : Choice<bool, exn> = v59179 
                    let v59378 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v59379 : US7 = null |> unbox<US7>
                    let _v59378 = v59379 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v59382 : US7 = null |> unbox<US7>
                    let _v59378 = v59382 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v59385 : US7 = null |> unbox<US7>
                    let _v59378 = v59385 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v59388 : US7 = null |> unbox<US7>
                    let _v59378 = v59388 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v59391 : US7 = null |> unbox<US7>
                    let _v59378 = v59391 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v59394 : (bool -> US7) = method22()
                    let v59395 : (exn -> US7) = method23()
                    let v59396 : US7 = match v59377 with Choice1Of2 x -> v59394 x | Choice2Of2 x -> v59395 x
                    let _v59378 = v59396 
                    #endif
#else
                    let v59397 : (bool -> US7) = method22()
                    let v59398 : (exn -> US7) = method23()
                    let v59399 : US7 = match v59377 with Choice1Of2 x -> v59397 x | Choice2Of2 x -> v59398 x
                    let _v59378 = v59399 
                    #endif
                    let v59400 : US7 = _v59378 
                    return v59400 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59433 : Async<US7> = _v59374 
            let _v59184 = v59433 
            #endif
            let v59434 : Async<US7> = _v59184 
            let v59496 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v59497 : Async<US8> = null |> unbox<Async<US8>>
            let _v59496 = v59497 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59500 : Async<US8> = null |> unbox<Async<US8>>
            let _v59496 = v59500 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59503 : Async<US8> = null |> unbox<Async<US8>>
            let _v59496 = v59503 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59506 : unit = ()
            let _v59506 =
                async {
                    let! v59434 = v59434 
                    let v59509 : US7 = v59434 
                    let v59515 : US8 =
                        match v59509 with
                        | US7_0(v59510) -> (* C1of2 *)
                            US8_0(v59510)
                        | US7_1(v59512) -> (* C2of2 *)
                            US8_1(v59512)
                    return v59515 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59523 : Async<US8> = _v59506 
            let _v59496 = v59523 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59524 : unit = ()
            let _v59524 =
                async {
                    let! v59434 = v59434 
                    let v59527 : US7 = v59434 
                    let v59533 : US8 =
                        match v59527 with
                        | US7_0(v59528) -> (* C1of2 *)
                            US8_0(v59528)
                        | US7_1(v59530) -> (* C2of2 *)
                            US8_1(v59530)
                    return v59533 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59541 : Async<US8> = _v59524 
            let _v59496 = v59541 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v59542 : unit = ()
            let _v59542 =
                async {
                    let! v59434 = v59434 
                    let v59545 : US7 = v59434 
                    let v59551 : US8 =
                        match v59545 with
                        | US7_0(v59546) -> (* C1of2 *)
                            US8_0(v59546)
                        | US7_1(v59548) -> (* C2of2 *)
                            US8_1(v59548)
                    return v59551 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59559 : Async<US8> = _v59542 
            let _v59496 = v59559 
            #endif
#else
            let v59560 : unit = ()
            let _v59560 =
                async {
                    let! v59434 = v59434 
                    let v59563 : US7 = v59434 
                    let v59569 : US8 =
                        match v59563 with
                        | US7_0(v59564) -> (* C1of2 *)
                            US8_0(v59564)
                        | US7_1(v59566) -> (* C2of2 *)
                            US8_1(v59566)
                    return v59569 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59577 : Async<US8> = _v59560 
            let _v59496 = v59577 
            #endif
            let v59578 : Async<US8> = _v59496 
            let v59598 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v59599 : Async<US6> = null |> unbox<Async<US6>>
            let _v59598 = v59599 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v59602 : Async<US6> = null |> unbox<Async<US6>>
            let _v59598 = v59602 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v59605 : Async<US6> = null |> unbox<Async<US6>>
            let _v59598 = v59605 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v59608 : unit = ()
            let _v59608 =
                async {
                    let! v59578 = v59578 
                    let v59611 : US8 = v59578 
                    let v59735 : US6 =
                        match v59611 with
                        | US8_1(v59614) -> (* Error *)
                            let v59615 : string = $"%A{v59614}"
                            let v59618 : string = "System.TimeoutException"
                            let v59619 : bool = v59615.Contains v59618 
                            if v59619 then
                                let v59622 : unit = ()
                                let v59623 : (unit -> unit) = closure16(v0)
                                let v59624 : unit = (fun () -> v59623 (); v59622) ()
                                US6_1
                            else
                                let v59665 : unit = ()
                                let v59666 : (unit -> unit) = closure17(v0, v59614)
                                let v59667 : unit = (fun () -> v59666 (); v59665) ()
                                US6_1
                        | US8_0(v59612) -> (* Ok *)
                            US6_0(v59612)
                    return v59735 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v59861 : Async<US6> = _v59608 
            let _v59598 = v59861 
            #endif
#if FABLE_COMPILER_PYTHON
            let v59862 : unit = ()
            let _v59862 =
                async {
                    let! v59578 = v59578 
                    let v59865 : US8 = v59578 
                    let v59989 : US6 =
                        match v59865 with
                        | US8_1(v59868) -> (* Error *)
                            let v59869 : string = $"%A{v59868}"
                            let v59872 : string = "System.TimeoutException"
                            let v59873 : bool = v59869.Contains v59872 
                            if v59873 then
                                let v59876 : unit = ()
                                let v59877 : (unit -> unit) = closure16(v0)
                                let v59878 : unit = (fun () -> v59877 (); v59876) ()
                                US6_1
                            else
                                let v59919 : unit = ()
                                let v59920 : (unit -> unit) = closure17(v0, v59868)
                                let v59921 : unit = (fun () -> v59920 (); v59919) ()
                                US6_1
                        | US8_0(v59866) -> (* Ok *)
                            US6_0(v59866)
                    return v59989 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v60115 : Async<US6> = _v59862 
            let _v59598 = v60115 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v60116 : unit = ()
            let _v60116 =
                async {
                    let! v59578 = v59578 
                    let v60119 : US8 = v59578 
                    let v60243 : US6 =
                        match v60119 with
                        | US8_1(v60122) -> (* Error *)
                            let v60123 : string = $"%A{v60122}"
                            let v60126 : string = "System.TimeoutException"
                            let v60127 : bool = v60123.Contains v60126 
                            if v60127 then
                                let v60130 : unit = ()
                                let v60131 : (unit -> unit) = closure16(v0)
                                let v60132 : unit = (fun () -> v60131 (); v60130) ()
                                US6_1
                            else
                                let v60173 : unit = ()
                                let v60174 : (unit -> unit) = closure17(v0, v60122)
                                let v60175 : unit = (fun () -> v60174 (); v60173) ()
                                US6_1
                        | US8_0(v60120) -> (* Ok *)
                            US6_0(v60120)
                    return v60243 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v60369 : Async<US6> = _v60116 
            let _v59598 = v60369 
            #endif
#else
            let v60370 : unit = ()
            let _v60370 =
                async {
                    let! v59578 = v59578 
                    let v60373 : US8 = v59578 
                    let v60497 : US6 =
                        match v60373 with
                        | US8_1(v60376) -> (* Error *)
                            let v60377 : string = $"%A{v60376}"
                            let v60380 : string = "System.TimeoutException"
                            let v60381 : bool = v60377.Contains v60380 
                            if v60381 then
                                let v60384 : unit = ()
                                let v60385 : (unit -> unit) = closure16(v0)
                                let v60386 : unit = (fun () -> v60385 (); v60384) ()
                                US6_1
                            else
                                let v60427 : unit = ()
                                let v60428 : (unit -> unit) = closure17(v0, v60376)
                                let v60429 : unit = (fun () -> v60428 (); v60427) ()
                                US6_1
                        | US8_0(v60374) -> (* Ok *)
                            US6_0(v60374)
                    return v60497 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v60623 : Async<US6> = _v60370 
            let _v59598 = v60623 
            #endif
            let v60624 : Async<US6> = _v59598 
            return! v60624 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v62616 : Async<US6> = _v59141 
    let _v52179 = v62616 
    #endif
#else
    let v62617 : unit = ()
    let _v62617 =
        async {
            let v62620 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62621 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v62620 = v62621 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62624 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v62620 = v62624 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62627 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v62620 = v62627 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v62630 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v62620 = v62630 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62631 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v62620 = v62631 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v62632 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v62620 = v62632 
            #endif
#else
            let v62633 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v62620 = v62633 
            #endif
            let v62634 : Async<Async<bool>> = _v62620 
            let! v62634 = v62634 
            let v62639 : Async<bool> = v62634 
            let v62640 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62641 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62642 : Async<Choice<bool, exn>> = v62641 v62639
            let _v62640 = v62642 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62643 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62644 : Async<Choice<bool, exn>> = v62643 v62639
            let _v62640 = v62644 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62645 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62646 : Async<Choice<bool, exn>> = v62645 v62639
            let _v62640 = v62646 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v62647 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62648 : Async<Choice<bool, exn>> = v62647 v62639
            let _v62640 = v62648 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62649 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62650 : Async<Choice<bool, exn>> = v62649 v62639
            let _v62640 = v62650 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v62651 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62652 : Async<Choice<bool, exn>> = v62651 v62639
            let _v62640 = v62652 
            #endif
#else
            let v62653 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v62654 : Async<Choice<bool, exn>> = v62653 v62639
            let _v62640 = v62654 
            #endif
            let v62655 : Async<Choice<bool, exn>> = _v62640 
            let v62660 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62661 : Async<US7> = null |> unbox<Async<US7>>
            let _v62660 = v62661 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62664 : Async<US7> = null |> unbox<Async<US7>>
            let _v62660 = v62664 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62667 : Async<US7> = null |> unbox<Async<US7>>
            let _v62660 = v62667 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v62670 : unit = ()
            let _v62670 =
                async {
                    let! v62655 = v62655 
                    let v62673 : Choice<bool, exn> = v62655 
                    let v62674 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v62675 : US7 = null |> unbox<US7>
                    let _v62674 = v62675 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v62678 : US7 = null |> unbox<US7>
                    let _v62674 = v62678 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v62681 : US7 = null |> unbox<US7>
                    let _v62674 = v62681 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v62684 : US7 = null |> unbox<US7>
                    let _v62674 = v62684 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v62687 : US7 = null |> unbox<US7>
                    let _v62674 = v62687 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v62690 : (bool -> US7) = method22()
                    let v62691 : (exn -> US7) = method23()
                    let v62692 : US7 = match v62673 with Choice1Of2 x -> v62690 x | Choice2Of2 x -> v62691 x
                    let _v62674 = v62692 
                    #endif
#else
                    let v62693 : (bool -> US7) = method22()
                    let v62694 : (exn -> US7) = method23()
                    let v62695 : US7 = match v62673 with Choice1Of2 x -> v62693 x | Choice2Of2 x -> v62694 x
                    let _v62674 = v62695 
                    #endif
                    let v62696 : US7 = _v62674 
                    return v62696 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v62729 : Async<US7> = _v62670 
            let _v62660 = v62729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v62730 : unit = ()
            let _v62730 =
                async {
                    let! v62655 = v62655 
                    let v62733 : Choice<bool, exn> = v62655 
                    let v62734 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v62735 : US7 = null |> unbox<US7>
                    let _v62734 = v62735 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v62738 : US7 = null |> unbox<US7>
                    let _v62734 = v62738 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v62741 : US7 = null |> unbox<US7>
                    let _v62734 = v62741 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v62744 : US7 = null |> unbox<US7>
                    let _v62734 = v62744 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v62747 : US7 = null |> unbox<US7>
                    let _v62734 = v62747 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v62750 : (bool -> US7) = method22()
                    let v62751 : (exn -> US7) = method23()
                    let v62752 : US7 = match v62733 with Choice1Of2 x -> v62750 x | Choice2Of2 x -> v62751 x
                    let _v62734 = v62752 
                    #endif
#else
                    let v62753 : (bool -> US7) = method22()
                    let v62754 : (exn -> US7) = method23()
                    let v62755 : US7 = match v62733 with Choice1Of2 x -> v62753 x | Choice2Of2 x -> v62754 x
                    let _v62734 = v62755 
                    #endif
                    let v62756 : US7 = _v62734 
                    return v62756 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v62789 : Async<US7> = _v62730 
            let _v62660 = v62789 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v62790 : unit = ()
            let _v62790 =
                async {
                    let! v62655 = v62655 
                    let v62793 : Choice<bool, exn> = v62655 
                    let v62794 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v62795 : US7 = null |> unbox<US7>
                    let _v62794 = v62795 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v62798 : US7 = null |> unbox<US7>
                    let _v62794 = v62798 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v62801 : US7 = null |> unbox<US7>
                    let _v62794 = v62801 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v62804 : US7 = null |> unbox<US7>
                    let _v62794 = v62804 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v62807 : US7 = null |> unbox<US7>
                    let _v62794 = v62807 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v62810 : (bool -> US7) = method22()
                    let v62811 : (exn -> US7) = method23()
                    let v62812 : US7 = match v62793 with Choice1Of2 x -> v62810 x | Choice2Of2 x -> v62811 x
                    let _v62794 = v62812 
                    #endif
#else
                    let v62813 : (bool -> US7) = method22()
                    let v62814 : (exn -> US7) = method23()
                    let v62815 : US7 = match v62793 with Choice1Of2 x -> v62813 x | Choice2Of2 x -> v62814 x
                    let _v62794 = v62815 
                    #endif
                    let v62816 : US7 = _v62794 
                    return v62816 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v62849 : Async<US7> = _v62790 
            let _v62660 = v62849 
            #endif
#else
            let v62850 : unit = ()
            let _v62850 =
                async {
                    let! v62655 = v62655 
                    let v62853 : Choice<bool, exn> = v62655 
                    let v62854 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v62855 : US7 = null |> unbox<US7>
                    let _v62854 = v62855 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v62858 : US7 = null |> unbox<US7>
                    let _v62854 = v62858 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v62861 : US7 = null |> unbox<US7>
                    let _v62854 = v62861 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v62864 : US7 = null |> unbox<US7>
                    let _v62854 = v62864 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v62867 : US7 = null |> unbox<US7>
                    let _v62854 = v62867 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v62870 : (bool -> US7) = method22()
                    let v62871 : (exn -> US7) = method23()
                    let v62872 : US7 = match v62853 with Choice1Of2 x -> v62870 x | Choice2Of2 x -> v62871 x
                    let _v62854 = v62872 
                    #endif
#else
                    let v62873 : (bool -> US7) = method22()
                    let v62874 : (exn -> US7) = method23()
                    let v62875 : US7 = match v62853 with Choice1Of2 x -> v62873 x | Choice2Of2 x -> v62874 x
                    let _v62854 = v62875 
                    #endif
                    let v62876 : US7 = _v62854 
                    return v62876 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v62909 : Async<US7> = _v62850 
            let _v62660 = v62909 
            #endif
            let v62910 : Async<US7> = _v62660 
            let v62972 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v62973 : Async<US8> = null |> unbox<Async<US8>>
            let _v62972 = v62973 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v62976 : Async<US8> = null |> unbox<Async<US8>>
            let _v62972 = v62976 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v62979 : Async<US8> = null |> unbox<Async<US8>>
            let _v62972 = v62979 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v62982 : unit = ()
            let _v62982 =
                async {
                    let! v62910 = v62910 
                    let v62985 : US7 = v62910 
                    let v62991 : US8 =
                        match v62985 with
                        | US7_0(v62986) -> (* C1of2 *)
                            US8_0(v62986)
                        | US7_1(v62988) -> (* C2of2 *)
                            US8_1(v62988)
                    return v62991 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v62999 : Async<US8> = _v62982 
            let _v62972 = v62999 
            #endif
#if FABLE_COMPILER_PYTHON
            let v63000 : unit = ()
            let _v63000 =
                async {
                    let! v62910 = v62910 
                    let v63003 : US7 = v62910 
                    let v63009 : US8 =
                        match v63003 with
                        | US7_0(v63004) -> (* C1of2 *)
                            US8_0(v63004)
                        | US7_1(v63006) -> (* C2of2 *)
                            US8_1(v63006)
                    return v63009 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v63017 : Async<US8> = _v63000 
            let _v62972 = v63017 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63018 : unit = ()
            let _v63018 =
                async {
                    let! v62910 = v62910 
                    let v63021 : US7 = v62910 
                    let v63027 : US8 =
                        match v63021 with
                        | US7_0(v63022) -> (* C1of2 *)
                            US8_0(v63022)
                        | US7_1(v63024) -> (* C2of2 *)
                            US8_1(v63024)
                    return v63027 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v63035 : Async<US8> = _v63018 
            let _v62972 = v63035 
            #endif
#else
            let v63036 : unit = ()
            let _v63036 =
                async {
                    let! v62910 = v62910 
                    let v63039 : US7 = v62910 
                    let v63045 : US8 =
                        match v63039 with
                        | US7_0(v63040) -> (* C1of2 *)
                            US8_0(v63040)
                        | US7_1(v63042) -> (* C2of2 *)
                            US8_1(v63042)
                    return v63045 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v63053 : Async<US8> = _v63036 
            let _v62972 = v63053 
            #endif
            let v63054 : Async<US8> = _v62972 
            let v63074 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v63075 : Async<US6> = null |> unbox<Async<US6>>
            let _v63074 = v63075 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v63078 : Async<US6> = null |> unbox<Async<US6>>
            let _v63074 = v63078 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v63081 : Async<US6> = null |> unbox<Async<US6>>
            let _v63074 = v63081 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v63084 : unit = ()
            let _v63084 =
                async {
                    let! v63054 = v63054 
                    let v63087 : US8 = v63054 
                    let v63211 : US6 =
                        match v63087 with
                        | US8_1(v63090) -> (* Error *)
                            let v63091 : string = $"%A{v63090}"
                            let v63094 : string = "System.TimeoutException"
                            let v63095 : bool = v63091.Contains v63094 
                            if v63095 then
                                let v63098 : unit = ()
                                let v63099 : (unit -> unit) = closure16(v0)
                                let v63100 : unit = (fun () -> v63099 (); v63098) ()
                                US6_1
                            else
                                let v63141 : unit = ()
                                let v63142 : (unit -> unit) = closure17(v0, v63090)
                                let v63143 : unit = (fun () -> v63142 (); v63141) ()
                                US6_1
                        | US8_0(v63088) -> (* Ok *)
                            US6_0(v63088)
                    return v63211 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v63337 : Async<US6> = _v63084 
            let _v63074 = v63337 
            #endif
#if FABLE_COMPILER_PYTHON
            let v63338 : unit = ()
            let _v63338 =
                async {
                    let! v63054 = v63054 
                    let v63341 : US8 = v63054 
                    let v63465 : US6 =
                        match v63341 with
                        | US8_1(v63344) -> (* Error *)
                            let v63345 : string = $"%A{v63344}"
                            let v63348 : string = "System.TimeoutException"
                            let v63349 : bool = v63345.Contains v63348 
                            if v63349 then
                                let v63352 : unit = ()
                                let v63353 : (unit -> unit) = closure16(v0)
                                let v63354 : unit = (fun () -> v63353 (); v63352) ()
                                US6_1
                            else
                                let v63395 : unit = ()
                                let v63396 : (unit -> unit) = closure17(v0, v63344)
                                let v63397 : unit = (fun () -> v63396 (); v63395) ()
                                US6_1
                        | US8_0(v63342) -> (* Ok *)
                            US6_0(v63342)
                    return v63465 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v63591 : Async<US6> = _v63338 
            let _v63074 = v63591 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v63592 : unit = ()
            let _v63592 =
                async {
                    let! v63054 = v63054 
                    let v63595 : US8 = v63054 
                    let v63719 : US6 =
                        match v63595 with
                        | US8_1(v63598) -> (* Error *)
                            let v63599 : string = $"%A{v63598}"
                            let v63602 : string = "System.TimeoutException"
                            let v63603 : bool = v63599.Contains v63602 
                            if v63603 then
                                let v63606 : unit = ()
                                let v63607 : (unit -> unit) = closure16(v0)
                                let v63608 : unit = (fun () -> v63607 (); v63606) ()
                                US6_1
                            else
                                let v63649 : unit = ()
                                let v63650 : (unit -> unit) = closure17(v0, v63598)
                                let v63651 : unit = (fun () -> v63650 (); v63649) ()
                                US6_1
                        | US8_0(v63596) -> (* Ok *)
                            US6_0(v63596)
                    return v63719 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v63845 : Async<US6> = _v63592 
            let _v63074 = v63845 
            #endif
#else
            let v63846 : unit = ()
            let _v63846 =
                async {
                    let! v63054 = v63054 
                    let v63849 : US8 = v63054 
                    let v63973 : US6 =
                        match v63849 with
                        | US8_1(v63852) -> (* Error *)
                            let v63853 : string = $"%A{v63852}"
                            let v63856 : string = "System.TimeoutException"
                            let v63857 : bool = v63853.Contains v63856 
                            if v63857 then
                                let v63860 : unit = ()
                                let v63861 : (unit -> unit) = closure16(v0)
                                let v63862 : unit = (fun () -> v63861 (); v63860) ()
                                US6_1
                            else
                                let v63903 : unit = ()
                                let v63904 : (unit -> unit) = closure17(v0, v63852)
                                let v63905 : unit = (fun () -> v63904 (); v63903) ()
                                US6_1
                        | US8_0(v63850) -> (* Ok *)
                            US6_0(v63850)
                    return v63973 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v64099 : Async<US6> = _v63846 
            let _v63074 = v64099 
            #endif
            let v64100 : Async<US6> = _v63074 
            return! v64100 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v66092 : Async<US6> = _v62617 
    let _v52179 = v66092 
    #endif
    let v66093 : Async<US6> = _v52179 
    let _v2 = v66093 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69571 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69572 : Async<US6> = null |> unbox<Async<US6>>
    let _v69571 = v69572 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69575 : Async<US6> = null |> unbox<Async<US6>>
    let _v69571 = v69575 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69578 : Async<US6> = null |> unbox<Async<US6>>
    let _v69571 = v69578 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v69581 : unit = ()
    let _v69581 =
        async {
            let v69584 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69585 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v69584 = v69585 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v69588 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v69584 = v69588 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v69591 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v69584 = v69591 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v69594 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v69584 = v69594 
            #endif
#if FABLE_COMPILER_PYTHON
            let v69595 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v69584 = v69595 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v69596 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v69584 = v69596 
            #endif
#else
            let v69597 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v69584 = v69597 
            #endif
            let v69598 : Async<Async<bool>> = _v69584 
            let! v69598 = v69598 
            let v69603 : Async<bool> = v69598 
            let v69604 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69605 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69606 : Async<Choice<bool, exn>> = v69605 v69603
            let _v69604 = v69606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v69607 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69608 : Async<Choice<bool, exn>> = v69607 v69603
            let _v69604 = v69608 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v69609 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69610 : Async<Choice<bool, exn>> = v69609 v69603
            let _v69604 = v69610 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v69611 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69612 : Async<Choice<bool, exn>> = v69611 v69603
            let _v69604 = v69612 
            #endif
#if FABLE_COMPILER_PYTHON
            let v69613 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69614 : Async<Choice<bool, exn>> = v69613 v69603
            let _v69604 = v69614 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v69615 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69616 : Async<Choice<bool, exn>> = v69615 v69603
            let _v69604 = v69616 
            #endif
#else
            let v69617 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v69618 : Async<Choice<bool, exn>> = v69617 v69603
            let _v69604 = v69618 
            #endif
            let v69619 : Async<Choice<bool, exn>> = _v69604 
            let v69624 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69625 : Async<US7> = null |> unbox<Async<US7>>
            let _v69624 = v69625 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v69628 : Async<US7> = null |> unbox<Async<US7>>
            let _v69624 = v69628 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v69631 : Async<US7> = null |> unbox<Async<US7>>
            let _v69624 = v69631 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v69634 : unit = ()
            let _v69634 =
                async {
                    let! v69619 = v69619 
                    let v69637 : Choice<bool, exn> = v69619 
                    let v69638 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v69639 : US7 = null |> unbox<US7>
                    let _v69638 = v69639 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v69642 : US7 = null |> unbox<US7>
                    let _v69638 = v69642 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v69645 : US7 = null |> unbox<US7>
                    let _v69638 = v69645 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v69648 : US7 = null |> unbox<US7>
                    let _v69638 = v69648 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v69651 : US7 = null |> unbox<US7>
                    let _v69638 = v69651 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v69654 : (bool -> US7) = method22()
                    let v69655 : (exn -> US7) = method23()
                    let v69656 : US7 = match v69637 with Choice1Of2 x -> v69654 x | Choice2Of2 x -> v69655 x
                    let _v69638 = v69656 
                    #endif
#else
                    let v69657 : (bool -> US7) = method22()
                    let v69658 : (exn -> US7) = method23()
                    let v69659 : US7 = match v69637 with Choice1Of2 x -> v69657 x | Choice2Of2 x -> v69658 x
                    let _v69638 = v69659 
                    #endif
                    let v69660 : US7 = _v69638 
                    return v69660 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69693 : Async<US7> = _v69634 
            let _v69624 = v69693 
            #endif
#if FABLE_COMPILER_PYTHON
            let v69694 : unit = ()
            let _v69694 =
                async {
                    let! v69619 = v69619 
                    let v69697 : Choice<bool, exn> = v69619 
                    let v69698 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v69699 : US7 = null |> unbox<US7>
                    let _v69698 = v69699 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v69702 : US7 = null |> unbox<US7>
                    let _v69698 = v69702 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v69705 : US7 = null |> unbox<US7>
                    let _v69698 = v69705 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v69708 : US7 = null |> unbox<US7>
                    let _v69698 = v69708 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v69711 : US7 = null |> unbox<US7>
                    let _v69698 = v69711 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v69714 : (bool -> US7) = method22()
                    let v69715 : (exn -> US7) = method23()
                    let v69716 : US7 = match v69697 with Choice1Of2 x -> v69714 x | Choice2Of2 x -> v69715 x
                    let _v69698 = v69716 
                    #endif
#else
                    let v69717 : (bool -> US7) = method22()
                    let v69718 : (exn -> US7) = method23()
                    let v69719 : US7 = match v69697 with Choice1Of2 x -> v69717 x | Choice2Of2 x -> v69718 x
                    let _v69698 = v69719 
                    #endif
                    let v69720 : US7 = _v69698 
                    return v69720 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69753 : Async<US7> = _v69694 
            let _v69624 = v69753 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v69754 : unit = ()
            let _v69754 =
                async {
                    let! v69619 = v69619 
                    let v69757 : Choice<bool, exn> = v69619 
                    let v69758 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v69759 : US7 = null |> unbox<US7>
                    let _v69758 = v69759 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v69762 : US7 = null |> unbox<US7>
                    let _v69758 = v69762 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v69765 : US7 = null |> unbox<US7>
                    let _v69758 = v69765 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v69768 : US7 = null |> unbox<US7>
                    let _v69758 = v69768 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v69771 : US7 = null |> unbox<US7>
                    let _v69758 = v69771 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v69774 : (bool -> US7) = method22()
                    let v69775 : (exn -> US7) = method23()
                    let v69776 : US7 = match v69757 with Choice1Of2 x -> v69774 x | Choice2Of2 x -> v69775 x
                    let _v69758 = v69776 
                    #endif
#else
                    let v69777 : (bool -> US7) = method22()
                    let v69778 : (exn -> US7) = method23()
                    let v69779 : US7 = match v69757 with Choice1Of2 x -> v69777 x | Choice2Of2 x -> v69778 x
                    let _v69758 = v69779 
                    #endif
                    let v69780 : US7 = _v69758 
                    return v69780 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69813 : Async<US7> = _v69754 
            let _v69624 = v69813 
            #endif
#else
            let v69814 : unit = ()
            let _v69814 =
                async {
                    let! v69619 = v69619 
                    let v69817 : Choice<bool, exn> = v69619 
                    let v69818 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v69819 : US7 = null |> unbox<US7>
                    let _v69818 = v69819 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v69822 : US7 = null |> unbox<US7>
                    let _v69818 = v69822 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v69825 : US7 = null |> unbox<US7>
                    let _v69818 = v69825 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v69828 : US7 = null |> unbox<US7>
                    let _v69818 = v69828 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v69831 : US7 = null |> unbox<US7>
                    let _v69818 = v69831 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v69834 : (bool -> US7) = method22()
                    let v69835 : (exn -> US7) = method23()
                    let v69836 : US7 = match v69817 with Choice1Of2 x -> v69834 x | Choice2Of2 x -> v69835 x
                    let _v69818 = v69836 
                    #endif
#else
                    let v69837 : (bool -> US7) = method22()
                    let v69838 : (exn -> US7) = method23()
                    let v69839 : US7 = match v69817 with Choice1Of2 x -> v69837 x | Choice2Of2 x -> v69838 x
                    let _v69818 = v69839 
                    #endif
                    let v69840 : US7 = _v69818 
                    return v69840 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69873 : Async<US7> = _v69814 
            let _v69624 = v69873 
            #endif
            let v69874 : Async<US7> = _v69624 
            let v69936 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v69937 : Async<US8> = null |> unbox<Async<US8>>
            let _v69936 = v69937 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v69940 : Async<US8> = null |> unbox<Async<US8>>
            let _v69936 = v69940 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v69943 : Async<US8> = null |> unbox<Async<US8>>
            let _v69936 = v69943 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v69946 : unit = ()
            let _v69946 =
                async {
                    let! v69874 = v69874 
                    let v69949 : US7 = v69874 
                    let v69955 : US8 =
                        match v69949 with
                        | US7_0(v69950) -> (* C1of2 *)
                            US8_0(v69950)
                        | US7_1(v69952) -> (* C2of2 *)
                            US8_1(v69952)
                    return v69955 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69963 : Async<US8> = _v69946 
            let _v69936 = v69963 
            #endif
#if FABLE_COMPILER_PYTHON
            let v69964 : unit = ()
            let _v69964 =
                async {
                    let! v69874 = v69874 
                    let v69967 : US7 = v69874 
                    let v69973 : US8 =
                        match v69967 with
                        | US7_0(v69968) -> (* C1of2 *)
                            US8_0(v69968)
                        | US7_1(v69970) -> (* C2of2 *)
                            US8_1(v69970)
                    return v69973 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69981 : Async<US8> = _v69964 
            let _v69936 = v69981 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v69982 : unit = ()
            let _v69982 =
                async {
                    let! v69874 = v69874 
                    let v69985 : US7 = v69874 
                    let v69991 : US8 =
                        match v69985 with
                        | US7_0(v69986) -> (* C1of2 *)
                            US8_0(v69986)
                        | US7_1(v69988) -> (* C2of2 *)
                            US8_1(v69988)
                    return v69991 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v69999 : Async<US8> = _v69982 
            let _v69936 = v69999 
            #endif
#else
            let v70000 : unit = ()
            let _v70000 =
                async {
                    let! v69874 = v69874 
                    let v70003 : US7 = v69874 
                    let v70009 : US8 =
                        match v70003 with
                        | US7_0(v70004) -> (* C1of2 *)
                            US8_0(v70004)
                        | US7_1(v70006) -> (* C2of2 *)
                            US8_1(v70006)
                    return v70009 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v70017 : Async<US8> = _v70000 
            let _v69936 = v70017 
            #endif
            let v70018 : Async<US8> = _v69936 
            let v70038 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v70039 : Async<US6> = null |> unbox<Async<US6>>
            let _v70038 = v70039 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v70042 : Async<US6> = null |> unbox<Async<US6>>
            let _v70038 = v70042 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v70045 : Async<US6> = null |> unbox<Async<US6>>
            let _v70038 = v70045 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v70048 : unit = ()
            let _v70048 =
                async {
                    let! v70018 = v70018 
                    let v70051 : US8 = v70018 
                    let v70175 : US6 =
                        match v70051 with
                        | US8_1(v70054) -> (* Error *)
                            let v70055 : string = $"%A{v70054}"
                            let v70058 : string = "System.TimeoutException"
                            let v70059 : bool = v70055.Contains v70058 
                            if v70059 then
                                let v70062 : unit = ()
                                let v70063 : (unit -> unit) = closure16(v0)
                                let v70064 : unit = (fun () -> v70063 (); v70062) ()
                                US6_1
                            else
                                let v70105 : unit = ()
                                let v70106 : (unit -> unit) = closure17(v0, v70054)
                                let v70107 : unit = (fun () -> v70106 (); v70105) ()
                                US6_1
                        | US8_0(v70052) -> (* Ok *)
                            US6_0(v70052)
                    return v70175 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v70301 : Async<US6> = _v70048 
            let _v70038 = v70301 
            #endif
#if FABLE_COMPILER_PYTHON
            let v70302 : unit = ()
            let _v70302 =
                async {
                    let! v70018 = v70018 
                    let v70305 : US8 = v70018 
                    let v70429 : US6 =
                        match v70305 with
                        | US8_1(v70308) -> (* Error *)
                            let v70309 : string = $"%A{v70308}"
                            let v70312 : string = "System.TimeoutException"
                            let v70313 : bool = v70309.Contains v70312 
                            if v70313 then
                                let v70316 : unit = ()
                                let v70317 : (unit -> unit) = closure16(v0)
                                let v70318 : unit = (fun () -> v70317 (); v70316) ()
                                US6_1
                            else
                                let v70359 : unit = ()
                                let v70360 : (unit -> unit) = closure17(v0, v70308)
                                let v70361 : unit = (fun () -> v70360 (); v70359) ()
                                US6_1
                        | US8_0(v70306) -> (* Ok *)
                            US6_0(v70306)
                    return v70429 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v70555 : Async<US6> = _v70302 
            let _v70038 = v70555 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v70556 : unit = ()
            let _v70556 =
                async {
                    let! v70018 = v70018 
                    let v70559 : US8 = v70018 
                    let v70683 : US6 =
                        match v70559 with
                        | US8_1(v70562) -> (* Error *)
                            let v70563 : string = $"%A{v70562}"
                            let v70566 : string = "System.TimeoutException"
                            let v70567 : bool = v70563.Contains v70566 
                            if v70567 then
                                let v70570 : unit = ()
                                let v70571 : (unit -> unit) = closure16(v0)
                                let v70572 : unit = (fun () -> v70571 (); v70570) ()
                                US6_1
                            else
                                let v70613 : unit = ()
                                let v70614 : (unit -> unit) = closure17(v0, v70562)
                                let v70615 : unit = (fun () -> v70614 (); v70613) ()
                                US6_1
                        | US8_0(v70560) -> (* Ok *)
                            US6_0(v70560)
                    return v70683 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v70809 : Async<US6> = _v70556 
            let _v70038 = v70809 
            #endif
#else
            let v70810 : unit = ()
            let _v70810 =
                async {
                    let! v70018 = v70018 
                    let v70813 : US8 = v70018 
                    let v70937 : US6 =
                        match v70813 with
                        | US8_1(v70816) -> (* Error *)
                            let v70817 : string = $"%A{v70816}"
                            let v70820 : string = "System.TimeoutException"
                            let v70821 : bool = v70817.Contains v70820 
                            if v70821 then
                                let v70824 : unit = ()
                                let v70825 : (unit -> unit) = closure16(v0)
                                let v70826 : unit = (fun () -> v70825 (); v70824) ()
                                US6_1
                            else
                                let v70867 : unit = ()
                                let v70868 : (unit -> unit) = closure17(v0, v70816)
                                let v70869 : unit = (fun () -> v70868 (); v70867) ()
                                US6_1
                        | US8_0(v70814) -> (* Ok *)
                            US6_0(v70814)
                    return v70937 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v71063 : Async<US6> = _v70810 
            let _v70038 = v71063 
            #endif
            let v71064 : Async<US6> = _v70038 
            return! v71064 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v73056 : Async<US6> = _v69581 
    let _v69571 = v73056 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73057 : unit = ()
    let _v73057 =
        async {
            let v73060 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73061 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v73060 = v73061 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73064 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v73060 = v73064 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73067 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v73060 = v73067 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73070 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v73060 = v73070 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73071 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v73060 = v73071 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v73072 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v73060 = v73072 
            #endif
#else
            let v73073 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v73060 = v73073 
            #endif
            let v73074 : Async<Async<bool>> = _v73060 
            let! v73074 = v73074 
            let v73079 : Async<bool> = v73074 
            let v73080 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73081 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73082 : Async<Choice<bool, exn>> = v73081 v73079
            let _v73080 = v73082 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73083 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73084 : Async<Choice<bool, exn>> = v73083 v73079
            let _v73080 = v73084 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73085 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73086 : Async<Choice<bool, exn>> = v73085 v73079
            let _v73080 = v73086 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73087 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73088 : Async<Choice<bool, exn>> = v73087 v73079
            let _v73080 = v73088 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73089 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73090 : Async<Choice<bool, exn>> = v73089 v73079
            let _v73080 = v73090 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v73091 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73092 : Async<Choice<bool, exn>> = v73091 v73079
            let _v73080 = v73092 
            #endif
#else
            let v73093 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v73094 : Async<Choice<bool, exn>> = v73093 v73079
            let _v73080 = v73094 
            #endif
            let v73095 : Async<Choice<bool, exn>> = _v73080 
            let v73100 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73101 : Async<US7> = null |> unbox<Async<US7>>
            let _v73100 = v73101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73104 : Async<US7> = null |> unbox<Async<US7>>
            let _v73100 = v73104 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73107 : Async<US7> = null |> unbox<Async<US7>>
            let _v73100 = v73107 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73110 : unit = ()
            let _v73110 =
                async {
                    let! v73095 = v73095 
                    let v73113 : Choice<bool, exn> = v73095 
                    let v73114 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v73115 : US7 = null |> unbox<US7>
                    let _v73114 = v73115 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73118 : US7 = null |> unbox<US7>
                    let _v73114 = v73118 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v73121 : US7 = null |> unbox<US7>
                    let _v73114 = v73121 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v73124 : US7 = null |> unbox<US7>
                    let _v73114 = v73124 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v73127 : US7 = null |> unbox<US7>
                    let _v73114 = v73127 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v73130 : (bool -> US7) = method22()
                    let v73131 : (exn -> US7) = method23()
                    let v73132 : US7 = match v73113 with Choice1Of2 x -> v73130 x | Choice2Of2 x -> v73131 x
                    let _v73114 = v73132 
                    #endif
#else
                    let v73133 : (bool -> US7) = method22()
                    let v73134 : (exn -> US7) = method23()
                    let v73135 : US7 = match v73113 with Choice1Of2 x -> v73133 x | Choice2Of2 x -> v73134 x
                    let _v73114 = v73135 
                    #endif
                    let v73136 : US7 = _v73114 
                    return v73136 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73169 : Async<US7> = _v73110 
            let _v73100 = v73169 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73170 : unit = ()
            let _v73170 =
                async {
                    let! v73095 = v73095 
                    let v73173 : Choice<bool, exn> = v73095 
                    let v73174 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v73175 : US7 = null |> unbox<US7>
                    let _v73174 = v73175 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73178 : US7 = null |> unbox<US7>
                    let _v73174 = v73178 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v73181 : US7 = null |> unbox<US7>
                    let _v73174 = v73181 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v73184 : US7 = null |> unbox<US7>
                    let _v73174 = v73184 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v73187 : US7 = null |> unbox<US7>
                    let _v73174 = v73187 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v73190 : (bool -> US7) = method22()
                    let v73191 : (exn -> US7) = method23()
                    let v73192 : US7 = match v73173 with Choice1Of2 x -> v73190 x | Choice2Of2 x -> v73191 x
                    let _v73174 = v73192 
                    #endif
#else
                    let v73193 : (bool -> US7) = method22()
                    let v73194 : (exn -> US7) = method23()
                    let v73195 : US7 = match v73173 with Choice1Of2 x -> v73193 x | Choice2Of2 x -> v73194 x
                    let _v73174 = v73195 
                    #endif
                    let v73196 : US7 = _v73174 
                    return v73196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73229 : Async<US7> = _v73170 
            let _v73100 = v73229 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v73230 : unit = ()
            let _v73230 =
                async {
                    let! v73095 = v73095 
                    let v73233 : Choice<bool, exn> = v73095 
                    let v73234 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v73235 : US7 = null |> unbox<US7>
                    let _v73234 = v73235 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73238 : US7 = null |> unbox<US7>
                    let _v73234 = v73238 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v73241 : US7 = null |> unbox<US7>
                    let _v73234 = v73241 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v73244 : US7 = null |> unbox<US7>
                    let _v73234 = v73244 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v73247 : US7 = null |> unbox<US7>
                    let _v73234 = v73247 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v73250 : (bool -> US7) = method22()
                    let v73251 : (exn -> US7) = method23()
                    let v73252 : US7 = match v73233 with Choice1Of2 x -> v73250 x | Choice2Of2 x -> v73251 x
                    let _v73234 = v73252 
                    #endif
#else
                    let v73253 : (bool -> US7) = method22()
                    let v73254 : (exn -> US7) = method23()
                    let v73255 : US7 = match v73233 with Choice1Of2 x -> v73253 x | Choice2Of2 x -> v73254 x
                    let _v73234 = v73255 
                    #endif
                    let v73256 : US7 = _v73234 
                    return v73256 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73289 : Async<US7> = _v73230 
            let _v73100 = v73289 
            #endif
#else
            let v73290 : unit = ()
            let _v73290 =
                async {
                    let! v73095 = v73095 
                    let v73293 : Choice<bool, exn> = v73095 
                    let v73294 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v73295 : US7 = null |> unbox<US7>
                    let _v73294 = v73295 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73298 : US7 = null |> unbox<US7>
                    let _v73294 = v73298 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v73301 : US7 = null |> unbox<US7>
                    let _v73294 = v73301 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v73304 : US7 = null |> unbox<US7>
                    let _v73294 = v73304 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v73307 : US7 = null |> unbox<US7>
                    let _v73294 = v73307 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v73310 : (bool -> US7) = method22()
                    let v73311 : (exn -> US7) = method23()
                    let v73312 : US7 = match v73293 with Choice1Of2 x -> v73310 x | Choice2Of2 x -> v73311 x
                    let _v73294 = v73312 
                    #endif
#else
                    let v73313 : (bool -> US7) = method22()
                    let v73314 : (exn -> US7) = method23()
                    let v73315 : US7 = match v73293 with Choice1Of2 x -> v73313 x | Choice2Of2 x -> v73314 x
                    let _v73294 = v73315 
                    #endif
                    let v73316 : US7 = _v73294 
                    return v73316 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73349 : Async<US7> = _v73290 
            let _v73100 = v73349 
            #endif
            let v73350 : Async<US7> = _v73100 
            let v73412 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73413 : Async<US8> = null |> unbox<Async<US8>>
            let _v73412 = v73413 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73416 : Async<US8> = null |> unbox<Async<US8>>
            let _v73412 = v73416 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73419 : Async<US8> = null |> unbox<Async<US8>>
            let _v73412 = v73419 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73422 : unit = ()
            let _v73422 =
                async {
                    let! v73350 = v73350 
                    let v73425 : US7 = v73350 
                    let v73431 : US8 =
                        match v73425 with
                        | US7_0(v73426) -> (* C1of2 *)
                            US8_0(v73426)
                        | US7_1(v73428) -> (* C2of2 *)
                            US8_1(v73428)
                    return v73431 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73439 : Async<US8> = _v73422 
            let _v73412 = v73439 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73440 : unit = ()
            let _v73440 =
                async {
                    let! v73350 = v73350 
                    let v73443 : US7 = v73350 
                    let v73449 : US8 =
                        match v73443 with
                        | US7_0(v73444) -> (* C1of2 *)
                            US8_0(v73444)
                        | US7_1(v73446) -> (* C2of2 *)
                            US8_1(v73446)
                    return v73449 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73457 : Async<US8> = _v73440 
            let _v73412 = v73457 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v73458 : unit = ()
            let _v73458 =
                async {
                    let! v73350 = v73350 
                    let v73461 : US7 = v73350 
                    let v73467 : US8 =
                        match v73461 with
                        | US7_0(v73462) -> (* C1of2 *)
                            US8_0(v73462)
                        | US7_1(v73464) -> (* C2of2 *)
                            US8_1(v73464)
                    return v73467 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73475 : Async<US8> = _v73458 
            let _v73412 = v73475 
            #endif
#else
            let v73476 : unit = ()
            let _v73476 =
                async {
                    let! v73350 = v73350 
                    let v73479 : US7 = v73350 
                    let v73485 : US8 =
                        match v73479 with
                        | US7_0(v73480) -> (* C1of2 *)
                            US8_0(v73480)
                        | US7_1(v73482) -> (* C2of2 *)
                            US8_1(v73482)
                    return v73485 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73493 : Async<US8> = _v73476 
            let _v73412 = v73493 
            #endif
            let v73494 : Async<US8> = _v73412 
            let v73514 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v73515 : Async<US6> = null |> unbox<Async<US6>>
            let _v73514 = v73515 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v73518 : Async<US6> = null |> unbox<Async<US6>>
            let _v73514 = v73518 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v73521 : Async<US6> = null |> unbox<Async<US6>>
            let _v73514 = v73521 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v73524 : unit = ()
            let _v73524 =
                async {
                    let! v73494 = v73494 
                    let v73527 : US8 = v73494 
                    let v73651 : US6 =
                        match v73527 with
                        | US8_1(v73530) -> (* Error *)
                            let v73531 : string = $"%A{v73530}"
                            let v73534 : string = "System.TimeoutException"
                            let v73535 : bool = v73531.Contains v73534 
                            if v73535 then
                                let v73538 : unit = ()
                                let v73539 : (unit -> unit) = closure16(v0)
                                let v73540 : unit = (fun () -> v73539 (); v73538) ()
                                US6_1
                            else
                                let v73581 : unit = ()
                                let v73582 : (unit -> unit) = closure17(v0, v73530)
                                let v73583 : unit = (fun () -> v73582 (); v73581) ()
                                US6_1
                        | US8_0(v73528) -> (* Ok *)
                            US6_0(v73528)
                    return v73651 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v73777 : Async<US6> = _v73524 
            let _v73514 = v73777 
            #endif
#if FABLE_COMPILER_PYTHON
            let v73778 : unit = ()
            let _v73778 =
                async {
                    let! v73494 = v73494 
                    let v73781 : US8 = v73494 
                    let v73905 : US6 =
                        match v73781 with
                        | US8_1(v73784) -> (* Error *)
                            let v73785 : string = $"%A{v73784}"
                            let v73788 : string = "System.TimeoutException"
                            let v73789 : bool = v73785.Contains v73788 
                            if v73789 then
                                let v73792 : unit = ()
                                let v73793 : (unit -> unit) = closure16(v0)
                                let v73794 : unit = (fun () -> v73793 (); v73792) ()
                                US6_1
                            else
                                let v73835 : unit = ()
                                let v73836 : (unit -> unit) = closure17(v0, v73784)
                                let v73837 : unit = (fun () -> v73836 (); v73835) ()
                                US6_1
                        | US8_0(v73782) -> (* Ok *)
                            US6_0(v73782)
                    return v73905 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v74031 : Async<US6> = _v73778 
            let _v73514 = v74031 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v74032 : unit = ()
            let _v74032 =
                async {
                    let! v73494 = v73494 
                    let v74035 : US8 = v73494 
                    let v74159 : US6 =
                        match v74035 with
                        | US8_1(v74038) -> (* Error *)
                            let v74039 : string = $"%A{v74038}"
                            let v74042 : string = "System.TimeoutException"
                            let v74043 : bool = v74039.Contains v74042 
                            if v74043 then
                                let v74046 : unit = ()
                                let v74047 : (unit -> unit) = closure16(v0)
                                let v74048 : unit = (fun () -> v74047 (); v74046) ()
                                US6_1
                            else
                                let v74089 : unit = ()
                                let v74090 : (unit -> unit) = closure17(v0, v74038)
                                let v74091 : unit = (fun () -> v74090 (); v74089) ()
                                US6_1
                        | US8_0(v74036) -> (* Ok *)
                            US6_0(v74036)
                    return v74159 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v74285 : Async<US6> = _v74032 
            let _v73514 = v74285 
            #endif
#else
            let v74286 : unit = ()
            let _v74286 =
                async {
                    let! v73494 = v73494 
                    let v74289 : US8 = v73494 
                    let v74413 : US6 =
                        match v74289 with
                        | US8_1(v74292) -> (* Error *)
                            let v74293 : string = $"%A{v74292}"
                            let v74296 : string = "System.TimeoutException"
                            let v74297 : bool = v74293.Contains v74296 
                            if v74297 then
                                let v74300 : unit = ()
                                let v74301 : (unit -> unit) = closure16(v0)
                                let v74302 : unit = (fun () -> v74301 (); v74300) ()
                                US6_1
                            else
                                let v74343 : unit = ()
                                let v74344 : (unit -> unit) = closure17(v0, v74292)
                                let v74345 : unit = (fun () -> v74344 (); v74343) ()
                                US6_1
                        | US8_0(v74290) -> (* Ok *)
                            US6_0(v74290)
                    return v74413 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v74539 : Async<US6> = _v74286 
            let _v73514 = v74539 
            #endif
            let v74540 : Async<US6> = _v73514 
            return! v74540 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v76532 : Async<US6> = _v73057 
    let _v69571 = v76532 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v76533 : unit = ()
    let _v76533 =
        async {
            let v76536 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v76537 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v76536 = v76537 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76540 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v76536 = v76540 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v76543 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v76536 = v76543 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v76546 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v76536 = v76546 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76547 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v76536 = v76547 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v76548 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v76536 = v76548 
            #endif
#else
            let v76549 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v76536 = v76549 
            #endif
            let v76550 : Async<Async<bool>> = _v76536 
            let! v76550 = v76550 
            let v76555 : Async<bool> = v76550 
            let v76556 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v76557 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76558 : Async<Choice<bool, exn>> = v76557 v76555
            let _v76556 = v76558 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76559 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76560 : Async<Choice<bool, exn>> = v76559 v76555
            let _v76556 = v76560 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v76561 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76562 : Async<Choice<bool, exn>> = v76561 v76555
            let _v76556 = v76562 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v76563 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76564 : Async<Choice<bool, exn>> = v76563 v76555
            let _v76556 = v76564 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76565 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76566 : Async<Choice<bool, exn>> = v76565 v76555
            let _v76556 = v76566 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v76567 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76568 : Async<Choice<bool, exn>> = v76567 v76555
            let _v76556 = v76568 
            #endif
#else
            let v76569 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v76570 : Async<Choice<bool, exn>> = v76569 v76555
            let _v76556 = v76570 
            #endif
            let v76571 : Async<Choice<bool, exn>> = _v76556 
            let v76576 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v76577 : Async<US7> = null |> unbox<Async<US7>>
            let _v76576 = v76577 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76580 : Async<US7> = null |> unbox<Async<US7>>
            let _v76576 = v76580 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v76583 : Async<US7> = null |> unbox<Async<US7>>
            let _v76576 = v76583 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v76586 : unit = ()
            let _v76586 =
                async {
                    let! v76571 = v76571 
                    let v76589 : Choice<bool, exn> = v76571 
                    let v76590 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v76591 : US7 = null |> unbox<US7>
                    let _v76590 = v76591 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v76594 : US7 = null |> unbox<US7>
                    let _v76590 = v76594 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76597 : US7 = null |> unbox<US7>
                    let _v76590 = v76597 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v76600 : US7 = null |> unbox<US7>
                    let _v76590 = v76600 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v76603 : US7 = null |> unbox<US7>
                    let _v76590 = v76603 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v76606 : (bool -> US7) = method22()
                    let v76607 : (exn -> US7) = method23()
                    let v76608 : US7 = match v76589 with Choice1Of2 x -> v76606 x | Choice2Of2 x -> v76607 x
                    let _v76590 = v76608 
                    #endif
#else
                    let v76609 : (bool -> US7) = method22()
                    let v76610 : (exn -> US7) = method23()
                    let v76611 : US7 = match v76589 with Choice1Of2 x -> v76609 x | Choice2Of2 x -> v76610 x
                    let _v76590 = v76611 
                    #endif
                    let v76612 : US7 = _v76590 
                    return v76612 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76645 : Async<US7> = _v76586 
            let _v76576 = v76645 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76646 : unit = ()
            let _v76646 =
                async {
                    let! v76571 = v76571 
                    let v76649 : Choice<bool, exn> = v76571 
                    let v76650 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v76651 : US7 = null |> unbox<US7>
                    let _v76650 = v76651 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v76654 : US7 = null |> unbox<US7>
                    let _v76650 = v76654 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76657 : US7 = null |> unbox<US7>
                    let _v76650 = v76657 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v76660 : US7 = null |> unbox<US7>
                    let _v76650 = v76660 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v76663 : US7 = null |> unbox<US7>
                    let _v76650 = v76663 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v76666 : (bool -> US7) = method22()
                    let v76667 : (exn -> US7) = method23()
                    let v76668 : US7 = match v76649 with Choice1Of2 x -> v76666 x | Choice2Of2 x -> v76667 x
                    let _v76650 = v76668 
                    #endif
#else
                    let v76669 : (bool -> US7) = method22()
                    let v76670 : (exn -> US7) = method23()
                    let v76671 : US7 = match v76649 with Choice1Of2 x -> v76669 x | Choice2Of2 x -> v76670 x
                    let _v76650 = v76671 
                    #endif
                    let v76672 : US7 = _v76650 
                    return v76672 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76705 : Async<US7> = _v76646 
            let _v76576 = v76705 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v76706 : unit = ()
            let _v76706 =
                async {
                    let! v76571 = v76571 
                    let v76709 : Choice<bool, exn> = v76571 
                    let v76710 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v76711 : US7 = null |> unbox<US7>
                    let _v76710 = v76711 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v76714 : US7 = null |> unbox<US7>
                    let _v76710 = v76714 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76717 : US7 = null |> unbox<US7>
                    let _v76710 = v76717 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v76720 : US7 = null |> unbox<US7>
                    let _v76710 = v76720 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v76723 : US7 = null |> unbox<US7>
                    let _v76710 = v76723 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v76726 : (bool -> US7) = method22()
                    let v76727 : (exn -> US7) = method23()
                    let v76728 : US7 = match v76709 with Choice1Of2 x -> v76726 x | Choice2Of2 x -> v76727 x
                    let _v76710 = v76728 
                    #endif
#else
                    let v76729 : (bool -> US7) = method22()
                    let v76730 : (exn -> US7) = method23()
                    let v76731 : US7 = match v76709 with Choice1Of2 x -> v76729 x | Choice2Of2 x -> v76730 x
                    let _v76710 = v76731 
                    #endif
                    let v76732 : US7 = _v76710 
                    return v76732 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76765 : Async<US7> = _v76706 
            let _v76576 = v76765 
            #endif
#else
            let v76766 : unit = ()
            let _v76766 =
                async {
                    let! v76571 = v76571 
                    let v76769 : Choice<bool, exn> = v76571 
                    let v76770 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v76771 : US7 = null |> unbox<US7>
                    let _v76770 = v76771 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v76774 : US7 = null |> unbox<US7>
                    let _v76770 = v76774 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76777 : US7 = null |> unbox<US7>
                    let _v76770 = v76777 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v76780 : US7 = null |> unbox<US7>
                    let _v76770 = v76780 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v76783 : US7 = null |> unbox<US7>
                    let _v76770 = v76783 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v76786 : (bool -> US7) = method22()
                    let v76787 : (exn -> US7) = method23()
                    let v76788 : US7 = match v76769 with Choice1Of2 x -> v76786 x | Choice2Of2 x -> v76787 x
                    let _v76770 = v76788 
                    #endif
#else
                    let v76789 : (bool -> US7) = method22()
                    let v76790 : (exn -> US7) = method23()
                    let v76791 : US7 = match v76769 with Choice1Of2 x -> v76789 x | Choice2Of2 x -> v76790 x
                    let _v76770 = v76791 
                    #endif
                    let v76792 : US7 = _v76770 
                    return v76792 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76825 : Async<US7> = _v76766 
            let _v76576 = v76825 
            #endif
            let v76826 : Async<US7> = _v76576 
            let v76888 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v76889 : Async<US8> = null |> unbox<Async<US8>>
            let _v76888 = v76889 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76892 : Async<US8> = null |> unbox<Async<US8>>
            let _v76888 = v76892 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v76895 : Async<US8> = null |> unbox<Async<US8>>
            let _v76888 = v76895 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v76898 : unit = ()
            let _v76898 =
                async {
                    let! v76826 = v76826 
                    let v76901 : US7 = v76826 
                    let v76907 : US8 =
                        match v76901 with
                        | US7_0(v76902) -> (* C1of2 *)
                            US8_0(v76902)
                        | US7_1(v76904) -> (* C2of2 *)
                            US8_1(v76904)
                    return v76907 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76915 : Async<US8> = _v76898 
            let _v76888 = v76915 
            #endif
#if FABLE_COMPILER_PYTHON
            let v76916 : unit = ()
            let _v76916 =
                async {
                    let! v76826 = v76826 
                    let v76919 : US7 = v76826 
                    let v76925 : US8 =
                        match v76919 with
                        | US7_0(v76920) -> (* C1of2 *)
                            US8_0(v76920)
                        | US7_1(v76922) -> (* C2of2 *)
                            US8_1(v76922)
                    return v76925 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76933 : Async<US8> = _v76916 
            let _v76888 = v76933 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v76934 : unit = ()
            let _v76934 =
                async {
                    let! v76826 = v76826 
                    let v76937 : US7 = v76826 
                    let v76943 : US8 =
                        match v76937 with
                        | US7_0(v76938) -> (* C1of2 *)
                            US8_0(v76938)
                        | US7_1(v76940) -> (* C2of2 *)
                            US8_1(v76940)
                    return v76943 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76951 : Async<US8> = _v76934 
            let _v76888 = v76951 
            #endif
#else
            let v76952 : unit = ()
            let _v76952 =
                async {
                    let! v76826 = v76826 
                    let v76955 : US7 = v76826 
                    let v76961 : US8 =
                        match v76955 with
                        | US7_0(v76956) -> (* C1of2 *)
                            US8_0(v76956)
                        | US7_1(v76958) -> (* C2of2 *)
                            US8_1(v76958)
                    return v76961 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v76969 : Async<US8> = _v76952 
            let _v76888 = v76969 
            #endif
            let v76970 : Async<US8> = _v76888 
            let v76990 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v76991 : Async<US6> = null |> unbox<Async<US6>>
            let _v76990 = v76991 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v76994 : Async<US6> = null |> unbox<Async<US6>>
            let _v76990 = v76994 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v76997 : Async<US6> = null |> unbox<Async<US6>>
            let _v76990 = v76997 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v77000 : unit = ()
            let _v77000 =
                async {
                    let! v76970 = v76970 
                    let v77003 : US8 = v76970 
                    let v77127 : US6 =
                        match v77003 with
                        | US8_1(v77006) -> (* Error *)
                            let v77007 : string = $"%A{v77006}"
                            let v77010 : string = "System.TimeoutException"
                            let v77011 : bool = v77007.Contains v77010 
                            if v77011 then
                                let v77014 : unit = ()
                                let v77015 : (unit -> unit) = closure16(v0)
                                let v77016 : unit = (fun () -> v77015 (); v77014) ()
                                US6_1
                            else
                                let v77057 : unit = ()
                                let v77058 : (unit -> unit) = closure17(v0, v77006)
                                let v77059 : unit = (fun () -> v77058 (); v77057) ()
                                US6_1
                        | US8_0(v77004) -> (* Ok *)
                            US6_0(v77004)
                    return v77127 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v77253 : Async<US6> = _v77000 
            let _v76990 = v77253 
            #endif
#if FABLE_COMPILER_PYTHON
            let v77254 : unit = ()
            let _v77254 =
                async {
                    let! v76970 = v76970 
                    let v77257 : US8 = v76970 
                    let v77381 : US6 =
                        match v77257 with
                        | US8_1(v77260) -> (* Error *)
                            let v77261 : string = $"%A{v77260}"
                            let v77264 : string = "System.TimeoutException"
                            let v77265 : bool = v77261.Contains v77264 
                            if v77265 then
                                let v77268 : unit = ()
                                let v77269 : (unit -> unit) = closure16(v0)
                                let v77270 : unit = (fun () -> v77269 (); v77268) ()
                                US6_1
                            else
                                let v77311 : unit = ()
                                let v77312 : (unit -> unit) = closure17(v0, v77260)
                                let v77313 : unit = (fun () -> v77312 (); v77311) ()
                                US6_1
                        | US8_0(v77258) -> (* Ok *)
                            US6_0(v77258)
                    return v77381 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v77507 : Async<US6> = _v77254 
            let _v76990 = v77507 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v77508 : unit = ()
            let _v77508 =
                async {
                    let! v76970 = v76970 
                    let v77511 : US8 = v76970 
                    let v77635 : US6 =
                        match v77511 with
                        | US8_1(v77514) -> (* Error *)
                            let v77515 : string = $"%A{v77514}"
                            let v77518 : string = "System.TimeoutException"
                            let v77519 : bool = v77515.Contains v77518 
                            if v77519 then
                                let v77522 : unit = ()
                                let v77523 : (unit -> unit) = closure16(v0)
                                let v77524 : unit = (fun () -> v77523 (); v77522) ()
                                US6_1
                            else
                                let v77565 : unit = ()
                                let v77566 : (unit -> unit) = closure17(v0, v77514)
                                let v77567 : unit = (fun () -> v77566 (); v77565) ()
                                US6_1
                        | US8_0(v77512) -> (* Ok *)
                            US6_0(v77512)
                    return v77635 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v77761 : Async<US6> = _v77508 
            let _v76990 = v77761 
            #endif
#else
            let v77762 : unit = ()
            let _v77762 =
                async {
                    let! v76970 = v76970 
                    let v77765 : US8 = v76970 
                    let v77889 : US6 =
                        match v77765 with
                        | US8_1(v77768) -> (* Error *)
                            let v77769 : string = $"%A{v77768}"
                            let v77772 : string = "System.TimeoutException"
                            let v77773 : bool = v77769.Contains v77772 
                            if v77773 then
                                let v77776 : unit = ()
                                let v77777 : (unit -> unit) = closure16(v0)
                                let v77778 : unit = (fun () -> v77777 (); v77776) ()
                                US6_1
                            else
                                let v77819 : unit = ()
                                let v77820 : (unit -> unit) = closure17(v0, v77768)
                                let v77821 : unit = (fun () -> v77820 (); v77819) ()
                                US6_1
                        | US8_0(v77766) -> (* Ok *)
                            US6_0(v77766)
                    return v77889 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v78015 : Async<US6> = _v77762 
            let _v76990 = v78015 
            #endif
            let v78016 : Async<US6> = _v76990 
            return! v78016 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v80008 : Async<US6> = _v76533 
    let _v69571 = v80008 
    #endif
#else
    let v80009 : unit = ()
    let _v80009 =
        async {
            let v80012 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80013 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v80012 = v80013 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v80016 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v80012 = v80016 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v80019 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v80012 = v80019 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80022 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v80012 = v80022 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80023 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v80012 = v80023 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v80024 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v80012 = v80024 
            #endif
#else
            let v80025 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v80012 = v80025 
            #endif
            let v80026 : Async<Async<bool>> = _v80012 
            let! v80026 = v80026 
            let v80031 : Async<bool> = v80026 
            let v80032 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80033 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80034 : Async<Choice<bool, exn>> = v80033 v80031
            let _v80032 = v80034 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v80035 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80036 : Async<Choice<bool, exn>> = v80035 v80031
            let _v80032 = v80036 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v80037 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80038 : Async<Choice<bool, exn>> = v80037 v80031
            let _v80032 = v80038 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80039 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80040 : Async<Choice<bool, exn>> = v80039 v80031
            let _v80032 = v80040 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80041 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80042 : Async<Choice<bool, exn>> = v80041 v80031
            let _v80032 = v80042 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v80043 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80044 : Async<Choice<bool, exn>> = v80043 v80031
            let _v80032 = v80044 
            #endif
#else
            let v80045 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v80046 : Async<Choice<bool, exn>> = v80045 v80031
            let _v80032 = v80046 
            #endif
            let v80047 : Async<Choice<bool, exn>> = _v80032 
            let v80052 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80053 : Async<US7> = null |> unbox<Async<US7>>
            let _v80052 = v80053 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v80056 : Async<US7> = null |> unbox<Async<US7>>
            let _v80052 = v80056 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v80059 : Async<US7> = null |> unbox<Async<US7>>
            let _v80052 = v80059 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80062 : unit = ()
            let _v80062 =
                async {
                    let! v80047 = v80047 
                    let v80065 : Choice<bool, exn> = v80047 
                    let v80066 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v80067 : US7 = null |> unbox<US7>
                    let _v80066 = v80067 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v80070 : US7 = null |> unbox<US7>
                    let _v80066 = v80070 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v80073 : US7 = null |> unbox<US7>
                    let _v80066 = v80073 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v80076 : US7 = null |> unbox<US7>
                    let _v80066 = v80076 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v80079 : US7 = null |> unbox<US7>
                    let _v80066 = v80079 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v80082 : (bool -> US7) = method22()
                    let v80083 : (exn -> US7) = method23()
                    let v80084 : US7 = match v80065 with Choice1Of2 x -> v80082 x | Choice2Of2 x -> v80083 x
                    let _v80066 = v80084 
                    #endif
#else
                    let v80085 : (bool -> US7) = method22()
                    let v80086 : (exn -> US7) = method23()
                    let v80087 : US7 = match v80065 with Choice1Of2 x -> v80085 x | Choice2Of2 x -> v80086 x
                    let _v80066 = v80087 
                    #endif
                    let v80088 : US7 = _v80066 
                    return v80088 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80121 : Async<US7> = _v80062 
            let _v80052 = v80121 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80122 : unit = ()
            let _v80122 =
                async {
                    let! v80047 = v80047 
                    let v80125 : Choice<bool, exn> = v80047 
                    let v80126 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v80127 : US7 = null |> unbox<US7>
                    let _v80126 = v80127 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v80130 : US7 = null |> unbox<US7>
                    let _v80126 = v80130 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v80133 : US7 = null |> unbox<US7>
                    let _v80126 = v80133 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v80136 : US7 = null |> unbox<US7>
                    let _v80126 = v80136 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v80139 : US7 = null |> unbox<US7>
                    let _v80126 = v80139 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v80142 : (bool -> US7) = method22()
                    let v80143 : (exn -> US7) = method23()
                    let v80144 : US7 = match v80125 with Choice1Of2 x -> v80142 x | Choice2Of2 x -> v80143 x
                    let _v80126 = v80144 
                    #endif
#else
                    let v80145 : (bool -> US7) = method22()
                    let v80146 : (exn -> US7) = method23()
                    let v80147 : US7 = match v80125 with Choice1Of2 x -> v80145 x | Choice2Of2 x -> v80146 x
                    let _v80126 = v80147 
                    #endif
                    let v80148 : US7 = _v80126 
                    return v80148 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80181 : Async<US7> = _v80122 
            let _v80052 = v80181 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v80182 : unit = ()
            let _v80182 =
                async {
                    let! v80047 = v80047 
                    let v80185 : Choice<bool, exn> = v80047 
                    let v80186 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v80187 : US7 = null |> unbox<US7>
                    let _v80186 = v80187 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v80190 : US7 = null |> unbox<US7>
                    let _v80186 = v80190 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v80193 : US7 = null |> unbox<US7>
                    let _v80186 = v80193 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v80196 : US7 = null |> unbox<US7>
                    let _v80186 = v80196 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v80199 : US7 = null |> unbox<US7>
                    let _v80186 = v80199 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v80202 : (bool -> US7) = method22()
                    let v80203 : (exn -> US7) = method23()
                    let v80204 : US7 = match v80185 with Choice1Of2 x -> v80202 x | Choice2Of2 x -> v80203 x
                    let _v80186 = v80204 
                    #endif
#else
                    let v80205 : (bool -> US7) = method22()
                    let v80206 : (exn -> US7) = method23()
                    let v80207 : US7 = match v80185 with Choice1Of2 x -> v80205 x | Choice2Of2 x -> v80206 x
                    let _v80186 = v80207 
                    #endif
                    let v80208 : US7 = _v80186 
                    return v80208 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80241 : Async<US7> = _v80182 
            let _v80052 = v80241 
            #endif
#else
            let v80242 : unit = ()
            let _v80242 =
                async {
                    let! v80047 = v80047 
                    let v80245 : Choice<bool, exn> = v80047 
                    let v80246 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v80247 : US7 = null |> unbox<US7>
                    let _v80246 = v80247 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v80250 : US7 = null |> unbox<US7>
                    let _v80246 = v80250 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v80253 : US7 = null |> unbox<US7>
                    let _v80246 = v80253 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v80256 : US7 = null |> unbox<US7>
                    let _v80246 = v80256 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v80259 : US7 = null |> unbox<US7>
                    let _v80246 = v80259 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v80262 : (bool -> US7) = method22()
                    let v80263 : (exn -> US7) = method23()
                    let v80264 : US7 = match v80245 with Choice1Of2 x -> v80262 x | Choice2Of2 x -> v80263 x
                    let _v80246 = v80264 
                    #endif
#else
                    let v80265 : (bool -> US7) = method22()
                    let v80266 : (exn -> US7) = method23()
                    let v80267 : US7 = match v80245 with Choice1Of2 x -> v80265 x | Choice2Of2 x -> v80266 x
                    let _v80246 = v80267 
                    #endif
                    let v80268 : US7 = _v80246 
                    return v80268 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80301 : Async<US7> = _v80242 
            let _v80052 = v80301 
            #endif
            let v80302 : Async<US7> = _v80052 
            let v80364 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80365 : Async<US8> = null |> unbox<Async<US8>>
            let _v80364 = v80365 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v80368 : Async<US8> = null |> unbox<Async<US8>>
            let _v80364 = v80368 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v80371 : Async<US8> = null |> unbox<Async<US8>>
            let _v80364 = v80371 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80374 : unit = ()
            let _v80374 =
                async {
                    let! v80302 = v80302 
                    let v80377 : US7 = v80302 
                    let v80383 : US8 =
                        match v80377 with
                        | US7_0(v80378) -> (* C1of2 *)
                            US8_0(v80378)
                        | US7_1(v80380) -> (* C2of2 *)
                            US8_1(v80380)
                    return v80383 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80391 : Async<US8> = _v80374 
            let _v80364 = v80391 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80392 : unit = ()
            let _v80392 =
                async {
                    let! v80302 = v80302 
                    let v80395 : US7 = v80302 
                    let v80401 : US8 =
                        match v80395 with
                        | US7_0(v80396) -> (* C1of2 *)
                            US8_0(v80396)
                        | US7_1(v80398) -> (* C2of2 *)
                            US8_1(v80398)
                    return v80401 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80409 : Async<US8> = _v80392 
            let _v80364 = v80409 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v80410 : unit = ()
            let _v80410 =
                async {
                    let! v80302 = v80302 
                    let v80413 : US7 = v80302 
                    let v80419 : US8 =
                        match v80413 with
                        | US7_0(v80414) -> (* C1of2 *)
                            US8_0(v80414)
                        | US7_1(v80416) -> (* C2of2 *)
                            US8_1(v80416)
                    return v80419 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80427 : Async<US8> = _v80410 
            let _v80364 = v80427 
            #endif
#else
            let v80428 : unit = ()
            let _v80428 =
                async {
                    let! v80302 = v80302 
                    let v80431 : US7 = v80302 
                    let v80437 : US8 =
                        match v80431 with
                        | US7_0(v80432) -> (* C1of2 *)
                            US8_0(v80432)
                        | US7_1(v80434) -> (* C2of2 *)
                            US8_1(v80434)
                    return v80437 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80445 : Async<US8> = _v80428 
            let _v80364 = v80445 
            #endif
            let v80446 : Async<US8> = _v80364 
            let v80466 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v80467 : Async<US6> = null |> unbox<Async<US6>>
            let _v80466 = v80467 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v80470 : Async<US6> = null |> unbox<Async<US6>>
            let _v80466 = v80470 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v80473 : Async<US6> = null |> unbox<Async<US6>>
            let _v80466 = v80473 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v80476 : unit = ()
            let _v80476 =
                async {
                    let! v80446 = v80446 
                    let v80479 : US8 = v80446 
                    let v80603 : US6 =
                        match v80479 with
                        | US8_1(v80482) -> (* Error *)
                            let v80483 : string = $"%A{v80482}"
                            let v80486 : string = "System.TimeoutException"
                            let v80487 : bool = v80483.Contains v80486 
                            if v80487 then
                                let v80490 : unit = ()
                                let v80491 : (unit -> unit) = closure16(v0)
                                let v80492 : unit = (fun () -> v80491 (); v80490) ()
                                US6_1
                            else
                                let v80533 : unit = ()
                                let v80534 : (unit -> unit) = closure17(v0, v80482)
                                let v80535 : unit = (fun () -> v80534 (); v80533) ()
                                US6_1
                        | US8_0(v80480) -> (* Ok *)
                            US6_0(v80480)
                    return v80603 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80729 : Async<US6> = _v80476 
            let _v80466 = v80729 
            #endif
#if FABLE_COMPILER_PYTHON
            let v80730 : unit = ()
            let _v80730 =
                async {
                    let! v80446 = v80446 
                    let v80733 : US8 = v80446 
                    let v80857 : US6 =
                        match v80733 with
                        | US8_1(v80736) -> (* Error *)
                            let v80737 : string = $"%A{v80736}"
                            let v80740 : string = "System.TimeoutException"
                            let v80741 : bool = v80737.Contains v80740 
                            if v80741 then
                                let v80744 : unit = ()
                                let v80745 : (unit -> unit) = closure16(v0)
                                let v80746 : unit = (fun () -> v80745 (); v80744) ()
                                US6_1
                            else
                                let v80787 : unit = ()
                                let v80788 : (unit -> unit) = closure17(v0, v80736)
                                let v80789 : unit = (fun () -> v80788 (); v80787) ()
                                US6_1
                        | US8_0(v80734) -> (* Ok *)
                            US6_0(v80734)
                    return v80857 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v80983 : Async<US6> = _v80730 
            let _v80466 = v80983 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v80984 : unit = ()
            let _v80984 =
                async {
                    let! v80446 = v80446 
                    let v80987 : US8 = v80446 
                    let v81111 : US6 =
                        match v80987 with
                        | US8_1(v80990) -> (* Error *)
                            let v80991 : string = $"%A{v80990}"
                            let v80994 : string = "System.TimeoutException"
                            let v80995 : bool = v80991.Contains v80994 
                            if v80995 then
                                let v80998 : unit = ()
                                let v80999 : (unit -> unit) = closure16(v0)
                                let v81000 : unit = (fun () -> v80999 (); v80998) ()
                                US6_1
                            else
                                let v81041 : unit = ()
                                let v81042 : (unit -> unit) = closure17(v0, v80990)
                                let v81043 : unit = (fun () -> v81042 (); v81041) ()
                                US6_1
                        | US8_0(v80988) -> (* Ok *)
                            US6_0(v80988)
                    return v81111 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v81237 : Async<US6> = _v80984 
            let _v80466 = v81237 
            #endif
#else
            let v81238 : unit = ()
            let _v81238 =
                async {
                    let! v80446 = v80446 
                    let v81241 : US8 = v80446 
                    let v81365 : US6 =
                        match v81241 with
                        | US8_1(v81244) -> (* Error *)
                            let v81245 : string = $"%A{v81244}"
                            let v81248 : string = "System.TimeoutException"
                            let v81249 : bool = v81245.Contains v81248 
                            if v81249 then
                                let v81252 : unit = ()
                                let v81253 : (unit -> unit) = closure16(v0)
                                let v81254 : unit = (fun () -> v81253 (); v81252) ()
                                US6_1
                            else
                                let v81295 : unit = ()
                                let v81296 : (unit -> unit) = closure17(v0, v81244)
                                let v81297 : unit = (fun () -> v81296 (); v81295) ()
                                US6_1
                        | US8_0(v81242) -> (* Ok *)
                            US6_0(v81242)
                    return v81365 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v81491 : Async<US6> = _v81238 
            let _v80466 = v81491 
            #endif
            let v81492 : Async<US6> = _v80466 
            return! v81492 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v83484 : Async<US6> = _v80009 
    let _v69571 = v83484 
    #endif
    let v83485 : Async<US6> = _v69571 
    let _v2 = v83485 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v86963 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v86964 : Async<US6> = null |> unbox<Async<US6>>
    let _v86963 = v86964 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v86967 : Async<US6> = null |> unbox<Async<US6>>
    let _v86963 = v86967 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v86970 : Async<US6> = null |> unbox<Async<US6>>
    let _v86963 = v86970 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v86973 : unit = ()
    let _v86973 =
        async {
            let v86976 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v86977 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v86976 = v86977 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v86980 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v86976 = v86980 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v86983 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v86976 = v86983 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v86986 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v86976 = v86986 
            #endif
#if FABLE_COMPILER_PYTHON
            let v86987 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v86976 = v86987 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v86988 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v86976 = v86988 
            #endif
#else
            let v86989 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v86976 = v86989 
            #endif
            let v86990 : Async<Async<bool>> = _v86976 
            let! v86990 = v86990 
            let v86995 : Async<bool> = v86990 
            let v86996 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v86997 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v86998 : Async<Choice<bool, exn>> = v86997 v86995
            let _v86996 = v86998 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v86999 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v87000 : Async<Choice<bool, exn>> = v86999 v86995
            let _v86996 = v87000 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v87001 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v87002 : Async<Choice<bool, exn>> = v87001 v86995
            let _v86996 = v87002 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87003 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v87004 : Async<Choice<bool, exn>> = v87003 v86995
            let _v86996 = v87004 
            #endif
#if FABLE_COMPILER_PYTHON
            let v87005 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v87006 : Async<Choice<bool, exn>> = v87005 v86995
            let _v86996 = v87006 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v87007 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v87008 : Async<Choice<bool, exn>> = v87007 v86995
            let _v86996 = v87008 
            #endif
#else
            let v87009 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v87010 : Async<Choice<bool, exn>> = v87009 v86995
            let _v86996 = v87010 
            #endif
            let v87011 : Async<Choice<bool, exn>> = _v86996 
            let v87016 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v87017 : Async<US7> = null |> unbox<Async<US7>>
            let _v87016 = v87017 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v87020 : Async<US7> = null |> unbox<Async<US7>>
            let _v87016 = v87020 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v87023 : Async<US7> = null |> unbox<Async<US7>>
            let _v87016 = v87023 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87026 : unit = ()
            let _v87026 =
                async {
                    let! v87011 = v87011 
                    let v87029 : Choice<bool, exn> = v87011 
                    let v87030 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v87031 : US7 = null |> unbox<US7>
                    let _v87030 = v87031 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v87034 : US7 = null |> unbox<US7>
                    let _v87030 = v87034 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v87037 : US7 = null |> unbox<US7>
                    let _v87030 = v87037 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v87040 : US7 = null |> unbox<US7>
                    let _v87030 = v87040 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v87043 : US7 = null |> unbox<US7>
                    let _v87030 = v87043 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v87046 : (bool -> US7) = method22()
                    let v87047 : (exn -> US7) = method23()
                    let v87048 : US7 = match v87029 with Choice1Of2 x -> v87046 x | Choice2Of2 x -> v87047 x
                    let _v87030 = v87048 
                    #endif
#else
                    let v87049 : (bool -> US7) = method22()
                    let v87050 : (exn -> US7) = method23()
                    let v87051 : US7 = match v87029 with Choice1Of2 x -> v87049 x | Choice2Of2 x -> v87050 x
                    let _v87030 = v87051 
                    #endif
                    let v87052 : US7 = _v87030 
                    return v87052 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87085 : Async<US7> = _v87026 
            let _v87016 = v87085 
            #endif
#if FABLE_COMPILER_PYTHON
            let v87086 : unit = ()
            let _v87086 =
                async {
                    let! v87011 = v87011 
                    let v87089 : Choice<bool, exn> = v87011 
                    let v87090 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v87091 : US7 = null |> unbox<US7>
                    let _v87090 = v87091 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v87094 : US7 = null |> unbox<US7>
                    let _v87090 = v87094 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v87097 : US7 = null |> unbox<US7>
                    let _v87090 = v87097 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v87100 : US7 = null |> unbox<US7>
                    let _v87090 = v87100 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v87103 : US7 = null |> unbox<US7>
                    let _v87090 = v87103 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v87106 : (bool -> US7) = method22()
                    let v87107 : (exn -> US7) = method23()
                    let v87108 : US7 = match v87089 with Choice1Of2 x -> v87106 x | Choice2Of2 x -> v87107 x
                    let _v87090 = v87108 
                    #endif
#else
                    let v87109 : (bool -> US7) = method22()
                    let v87110 : (exn -> US7) = method23()
                    let v87111 : US7 = match v87089 with Choice1Of2 x -> v87109 x | Choice2Of2 x -> v87110 x
                    let _v87090 = v87111 
                    #endif
                    let v87112 : US7 = _v87090 
                    return v87112 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87145 : Async<US7> = _v87086 
            let _v87016 = v87145 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v87146 : unit = ()
            let _v87146 =
                async {
                    let! v87011 = v87011 
                    let v87149 : Choice<bool, exn> = v87011 
                    let v87150 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v87151 : US7 = null |> unbox<US7>
                    let _v87150 = v87151 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v87154 : US7 = null |> unbox<US7>
                    let _v87150 = v87154 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v87157 : US7 = null |> unbox<US7>
                    let _v87150 = v87157 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v87160 : US7 = null |> unbox<US7>
                    let _v87150 = v87160 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v87163 : US7 = null |> unbox<US7>
                    let _v87150 = v87163 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v87166 : (bool -> US7) = method22()
                    let v87167 : (exn -> US7) = method23()
                    let v87168 : US7 = match v87149 with Choice1Of2 x -> v87166 x | Choice2Of2 x -> v87167 x
                    let _v87150 = v87168 
                    #endif
#else
                    let v87169 : (bool -> US7) = method22()
                    let v87170 : (exn -> US7) = method23()
                    let v87171 : US7 = match v87149 with Choice1Of2 x -> v87169 x | Choice2Of2 x -> v87170 x
                    let _v87150 = v87171 
                    #endif
                    let v87172 : US7 = _v87150 
                    return v87172 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87205 : Async<US7> = _v87146 
            let _v87016 = v87205 
            #endif
#else
            let v87206 : unit = ()
            let _v87206 =
                async {
                    let! v87011 = v87011 
                    let v87209 : Choice<bool, exn> = v87011 
                    let v87210 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v87211 : US7 = null |> unbox<US7>
                    let _v87210 = v87211 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v87214 : US7 = null |> unbox<US7>
                    let _v87210 = v87214 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v87217 : US7 = null |> unbox<US7>
                    let _v87210 = v87217 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v87220 : US7 = null |> unbox<US7>
                    let _v87210 = v87220 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v87223 : US7 = null |> unbox<US7>
                    let _v87210 = v87223 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v87226 : (bool -> US7) = method22()
                    let v87227 : (exn -> US7) = method23()
                    let v87228 : US7 = match v87209 with Choice1Of2 x -> v87226 x | Choice2Of2 x -> v87227 x
                    let _v87210 = v87228 
                    #endif
#else
                    let v87229 : (bool -> US7) = method22()
                    let v87230 : (exn -> US7) = method23()
                    let v87231 : US7 = match v87209 with Choice1Of2 x -> v87229 x | Choice2Of2 x -> v87230 x
                    let _v87210 = v87231 
                    #endif
                    let v87232 : US7 = _v87210 
                    return v87232 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87265 : Async<US7> = _v87206 
            let _v87016 = v87265 
            #endif
            let v87266 : Async<US7> = _v87016 
            let v87328 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v87329 : Async<US8> = null |> unbox<Async<US8>>
            let _v87328 = v87329 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v87332 : Async<US8> = null |> unbox<Async<US8>>
            let _v87328 = v87332 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v87335 : Async<US8> = null |> unbox<Async<US8>>
            let _v87328 = v87335 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87338 : unit = ()
            let _v87338 =
                async {
                    let! v87266 = v87266 
                    let v87341 : US7 = v87266 
                    let v87347 : US8 =
                        match v87341 with
                        | US7_0(v87342) -> (* C1of2 *)
                            US8_0(v87342)
                        | US7_1(v87344) -> (* C2of2 *)
                            US8_1(v87344)
                    return v87347 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87355 : Async<US8> = _v87338 
            let _v87328 = v87355 
            #endif
#if FABLE_COMPILER_PYTHON
            let v87356 : unit = ()
            let _v87356 =
                async {
                    let! v87266 = v87266 
                    let v87359 : US7 = v87266 
                    let v87365 : US8 =
                        match v87359 with
                        | US7_0(v87360) -> (* C1of2 *)
                            US8_0(v87360)
                        | US7_1(v87362) -> (* C2of2 *)
                            US8_1(v87362)
                    return v87365 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87373 : Async<US8> = _v87356 
            let _v87328 = v87373 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v87374 : unit = ()
            let _v87374 =
                async {
                    let! v87266 = v87266 
                    let v87377 : US7 = v87266 
                    let v87383 : US8 =
                        match v87377 with
                        | US7_0(v87378) -> (* C1of2 *)
                            US8_0(v87378)
                        | US7_1(v87380) -> (* C2of2 *)
                            US8_1(v87380)
                    return v87383 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87391 : Async<US8> = _v87374 
            let _v87328 = v87391 
            #endif
#else
            let v87392 : unit = ()
            let _v87392 =
                async {
                    let! v87266 = v87266 
                    let v87395 : US7 = v87266 
                    let v87401 : US8 =
                        match v87395 with
                        | US7_0(v87396) -> (* C1of2 *)
                            US8_0(v87396)
                        | US7_1(v87398) -> (* C2of2 *)
                            US8_1(v87398)
                    return v87401 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87409 : Async<US8> = _v87392 
            let _v87328 = v87409 
            #endif
            let v87410 : Async<US8> = _v87328 
            let v87430 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v87431 : Async<US6> = null |> unbox<Async<US6>>
            let _v87430 = v87431 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v87434 : Async<US6> = null |> unbox<Async<US6>>
            let _v87430 = v87434 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v87437 : Async<US6> = null |> unbox<Async<US6>>
            let _v87430 = v87437 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v87440 : unit = ()
            let _v87440 =
                async {
                    let! v87410 = v87410 
                    let v87443 : US8 = v87410 
                    let v87567 : US6 =
                        match v87443 with
                        | US8_1(v87446) -> (* Error *)
                            let v87447 : string = $"%A{v87446}"
                            let v87450 : string = "System.TimeoutException"
                            let v87451 : bool = v87447.Contains v87450 
                            if v87451 then
                                let v87454 : unit = ()
                                let v87455 : (unit -> unit) = closure16(v0)
                                let v87456 : unit = (fun () -> v87455 (); v87454) ()
                                US6_1
                            else
                                let v87497 : unit = ()
                                let v87498 : (unit -> unit) = closure17(v0, v87446)
                                let v87499 : unit = (fun () -> v87498 (); v87497) ()
                                US6_1
                        | US8_0(v87444) -> (* Ok *)
                            US6_0(v87444)
                    return v87567 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87693 : Async<US6> = _v87440 
            let _v87430 = v87693 
            #endif
#if FABLE_COMPILER_PYTHON
            let v87694 : unit = ()
            let _v87694 =
                async {
                    let! v87410 = v87410 
                    let v87697 : US8 = v87410 
                    let v87821 : US6 =
                        match v87697 with
                        | US8_1(v87700) -> (* Error *)
                            let v87701 : string = $"%A{v87700}"
                            let v87704 : string = "System.TimeoutException"
                            let v87705 : bool = v87701.Contains v87704 
                            if v87705 then
                                let v87708 : unit = ()
                                let v87709 : (unit -> unit) = closure16(v0)
                                let v87710 : unit = (fun () -> v87709 (); v87708) ()
                                US6_1
                            else
                                let v87751 : unit = ()
                                let v87752 : (unit -> unit) = closure17(v0, v87700)
                                let v87753 : unit = (fun () -> v87752 (); v87751) ()
                                US6_1
                        | US8_0(v87698) -> (* Ok *)
                            US6_0(v87698)
                    return v87821 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87947 : Async<US6> = _v87694 
            let _v87430 = v87947 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v87948 : unit = ()
            let _v87948 =
                async {
                    let! v87410 = v87410 
                    let v87951 : US8 = v87410 
                    let v88075 : US6 =
                        match v87951 with
                        | US8_1(v87954) -> (* Error *)
                            let v87955 : string = $"%A{v87954}"
                            let v87958 : string = "System.TimeoutException"
                            let v87959 : bool = v87955.Contains v87958 
                            if v87959 then
                                let v87962 : unit = ()
                                let v87963 : (unit -> unit) = closure16(v0)
                                let v87964 : unit = (fun () -> v87963 (); v87962) ()
                                US6_1
                            else
                                let v88005 : unit = ()
                                let v88006 : (unit -> unit) = closure17(v0, v87954)
                                let v88007 : unit = (fun () -> v88006 (); v88005) ()
                                US6_1
                        | US8_0(v87952) -> (* Ok *)
                            US6_0(v87952)
                    return v88075 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v88201 : Async<US6> = _v87948 
            let _v87430 = v88201 
            #endif
#else
            let v88202 : unit = ()
            let _v88202 =
                async {
                    let! v87410 = v87410 
                    let v88205 : US8 = v87410 
                    let v88329 : US6 =
                        match v88205 with
                        | US8_1(v88208) -> (* Error *)
                            let v88209 : string = $"%A{v88208}"
                            let v88212 : string = "System.TimeoutException"
                            let v88213 : bool = v88209.Contains v88212 
                            if v88213 then
                                let v88216 : unit = ()
                                let v88217 : (unit -> unit) = closure16(v0)
                                let v88218 : unit = (fun () -> v88217 (); v88216) ()
                                US6_1
                            else
                                let v88259 : unit = ()
                                let v88260 : (unit -> unit) = closure17(v0, v88208)
                                let v88261 : unit = (fun () -> v88260 (); v88259) ()
                                US6_1
                        | US8_0(v88206) -> (* Ok *)
                            US6_0(v88206)
                    return v88329 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v88455 : Async<US6> = _v88202 
            let _v87430 = v88455 
            #endif
            let v88456 : Async<US6> = _v87430 
            return! v88456 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v90448 : Async<US6> = _v86973 
    let _v86963 = v90448 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90449 : unit = ()
    let _v90449 =
        async {
            let v90452 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v90453 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v90452 = v90453 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v90456 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v90452 = v90456 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v90459 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v90452 = v90459 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v90462 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v90452 = v90462 
            #endif
#if FABLE_COMPILER_PYTHON
            let v90463 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v90452 = v90463 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v90464 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v90452 = v90464 
            #endif
#else
            let v90465 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v90452 = v90465 
            #endif
            let v90466 : Async<Async<bool>> = _v90452 
            let! v90466 = v90466 
            let v90471 : Async<bool> = v90466 
            let v90472 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v90473 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90474 : Async<Choice<bool, exn>> = v90473 v90471
            let _v90472 = v90474 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v90475 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90476 : Async<Choice<bool, exn>> = v90475 v90471
            let _v90472 = v90476 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v90477 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90478 : Async<Choice<bool, exn>> = v90477 v90471
            let _v90472 = v90478 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v90479 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90480 : Async<Choice<bool, exn>> = v90479 v90471
            let _v90472 = v90480 
            #endif
#if FABLE_COMPILER_PYTHON
            let v90481 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90482 : Async<Choice<bool, exn>> = v90481 v90471
            let _v90472 = v90482 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v90483 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90484 : Async<Choice<bool, exn>> = v90483 v90471
            let _v90472 = v90484 
            #endif
#else
            let v90485 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v90486 : Async<Choice<bool, exn>> = v90485 v90471
            let _v90472 = v90486 
            #endif
            let v90487 : Async<Choice<bool, exn>> = _v90472 
            let v90492 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v90493 : Async<US7> = null |> unbox<Async<US7>>
            let _v90492 = v90493 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v90496 : Async<US7> = null |> unbox<Async<US7>>
            let _v90492 = v90496 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v90499 : Async<US7> = null |> unbox<Async<US7>>
            let _v90492 = v90499 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v90502 : unit = ()
            let _v90502 =
                async {
                    let! v90487 = v90487 
                    let v90505 : Choice<bool, exn> = v90487 
                    let v90506 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v90507 : US7 = null |> unbox<US7>
                    let _v90506 = v90507 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v90510 : US7 = null |> unbox<US7>
                    let _v90506 = v90510 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v90513 : US7 = null |> unbox<US7>
                    let _v90506 = v90513 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v90516 : US7 = null |> unbox<US7>
                    let _v90506 = v90516 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v90519 : US7 = null |> unbox<US7>
                    let _v90506 = v90519 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v90522 : (bool -> US7) = method22()
                    let v90523 : (exn -> US7) = method23()
                    let v90524 : US7 = match v90505 with Choice1Of2 x -> v90522 x | Choice2Of2 x -> v90523 x
                    let _v90506 = v90524 
                    #endif
#else
                    let v90525 : (bool -> US7) = method22()
                    let v90526 : (exn -> US7) = method23()
                    let v90527 : US7 = match v90505 with Choice1Of2 x -> v90525 x | Choice2Of2 x -> v90526 x
                    let _v90506 = v90527 
                    #endif
                    let v90528 : US7 = _v90506 
                    return v90528 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90561 : Async<US7> = _v90502 
            let _v90492 = v90561 
            #endif
#if FABLE_COMPILER_PYTHON
            let v90562 : unit = ()
            let _v90562 =
                async {
                    let! v90487 = v90487 
                    let v90565 : Choice<bool, exn> = v90487 
                    let v90566 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v90567 : US7 = null |> unbox<US7>
                    let _v90566 = v90567 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v90570 : US7 = null |> unbox<US7>
                    let _v90566 = v90570 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v90573 : US7 = null |> unbox<US7>
                    let _v90566 = v90573 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v90576 : US7 = null |> unbox<US7>
                    let _v90566 = v90576 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v90579 : US7 = null |> unbox<US7>
                    let _v90566 = v90579 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v90582 : (bool -> US7) = method22()
                    let v90583 : (exn -> US7) = method23()
                    let v90584 : US7 = match v90565 with Choice1Of2 x -> v90582 x | Choice2Of2 x -> v90583 x
                    let _v90566 = v90584 
                    #endif
#else
                    let v90585 : (bool -> US7) = method22()
                    let v90586 : (exn -> US7) = method23()
                    let v90587 : US7 = match v90565 with Choice1Of2 x -> v90585 x | Choice2Of2 x -> v90586 x
                    let _v90566 = v90587 
                    #endif
                    let v90588 : US7 = _v90566 
                    return v90588 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90621 : Async<US7> = _v90562 
            let _v90492 = v90621 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v90622 : unit = ()
            let _v90622 =
                async {
                    let! v90487 = v90487 
                    let v90625 : Choice<bool, exn> = v90487 
                    let v90626 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v90627 : US7 = null |> unbox<US7>
                    let _v90626 = v90627 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v90630 : US7 = null |> unbox<US7>
                    let _v90626 = v90630 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v90633 : US7 = null |> unbox<US7>
                    let _v90626 = v90633 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v90636 : US7 = null |> unbox<US7>
                    let _v90626 = v90636 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v90639 : US7 = null |> unbox<US7>
                    let _v90626 = v90639 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v90642 : (bool -> US7) = method22()
                    let v90643 : (exn -> US7) = method23()
                    let v90644 : US7 = match v90625 with Choice1Of2 x -> v90642 x | Choice2Of2 x -> v90643 x
                    let _v90626 = v90644 
                    #endif
#else
                    let v90645 : (bool -> US7) = method22()
                    let v90646 : (exn -> US7) = method23()
                    let v90647 : US7 = match v90625 with Choice1Of2 x -> v90645 x | Choice2Of2 x -> v90646 x
                    let _v90626 = v90647 
                    #endif
                    let v90648 : US7 = _v90626 
                    return v90648 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90681 : Async<US7> = _v90622 
            let _v90492 = v90681 
            #endif
#else
            let v90682 : unit = ()
            let _v90682 =
                async {
                    let! v90487 = v90487 
                    let v90685 : Choice<bool, exn> = v90487 
                    let v90686 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v90687 : US7 = null |> unbox<US7>
                    let _v90686 = v90687 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v90690 : US7 = null |> unbox<US7>
                    let _v90686 = v90690 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v90693 : US7 = null |> unbox<US7>
                    let _v90686 = v90693 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v90696 : US7 = null |> unbox<US7>
                    let _v90686 = v90696 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v90699 : US7 = null |> unbox<US7>
                    let _v90686 = v90699 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v90702 : (bool -> US7) = method22()
                    let v90703 : (exn -> US7) = method23()
                    let v90704 : US7 = match v90685 with Choice1Of2 x -> v90702 x | Choice2Of2 x -> v90703 x
                    let _v90686 = v90704 
                    #endif
#else
                    let v90705 : (bool -> US7) = method22()
                    let v90706 : (exn -> US7) = method23()
                    let v90707 : US7 = match v90685 with Choice1Of2 x -> v90705 x | Choice2Of2 x -> v90706 x
                    let _v90686 = v90707 
                    #endif
                    let v90708 : US7 = _v90686 
                    return v90708 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90741 : Async<US7> = _v90682 
            let _v90492 = v90741 
            #endif
            let v90742 : Async<US7> = _v90492 
            let v90804 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v90805 : Async<US8> = null |> unbox<Async<US8>>
            let _v90804 = v90805 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v90808 : Async<US8> = null |> unbox<Async<US8>>
            let _v90804 = v90808 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v90811 : Async<US8> = null |> unbox<Async<US8>>
            let _v90804 = v90811 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v90814 : unit = ()
            let _v90814 =
                async {
                    let! v90742 = v90742 
                    let v90817 : US7 = v90742 
                    let v90823 : US8 =
                        match v90817 with
                        | US7_0(v90818) -> (* C1of2 *)
                            US8_0(v90818)
                        | US7_1(v90820) -> (* C2of2 *)
                            US8_1(v90820)
                    return v90823 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90831 : Async<US8> = _v90814 
            let _v90804 = v90831 
            #endif
#if FABLE_COMPILER_PYTHON
            let v90832 : unit = ()
            let _v90832 =
                async {
                    let! v90742 = v90742 
                    let v90835 : US7 = v90742 
                    let v90841 : US8 =
                        match v90835 with
                        | US7_0(v90836) -> (* C1of2 *)
                            US8_0(v90836)
                        | US7_1(v90838) -> (* C2of2 *)
                            US8_1(v90838)
                    return v90841 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90849 : Async<US8> = _v90832 
            let _v90804 = v90849 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v90850 : unit = ()
            let _v90850 =
                async {
                    let! v90742 = v90742 
                    let v90853 : US7 = v90742 
                    let v90859 : US8 =
                        match v90853 with
                        | US7_0(v90854) -> (* C1of2 *)
                            US8_0(v90854)
                        | US7_1(v90856) -> (* C2of2 *)
                            US8_1(v90856)
                    return v90859 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90867 : Async<US8> = _v90850 
            let _v90804 = v90867 
            #endif
#else
            let v90868 : unit = ()
            let _v90868 =
                async {
                    let! v90742 = v90742 
                    let v90871 : US7 = v90742 
                    let v90877 : US8 =
                        match v90871 with
                        | US7_0(v90872) -> (* C1of2 *)
                            US8_0(v90872)
                        | US7_1(v90874) -> (* C2of2 *)
                            US8_1(v90874)
                    return v90877 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v90885 : Async<US8> = _v90868 
            let _v90804 = v90885 
            #endif
            let v90886 : Async<US8> = _v90804 
            let v90906 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v90907 : Async<US6> = null |> unbox<Async<US6>>
            let _v90906 = v90907 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v90910 : Async<US6> = null |> unbox<Async<US6>>
            let _v90906 = v90910 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v90913 : Async<US6> = null |> unbox<Async<US6>>
            let _v90906 = v90913 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v90916 : unit = ()
            let _v90916 =
                async {
                    let! v90886 = v90886 
                    let v90919 : US8 = v90886 
                    let v91043 : US6 =
                        match v90919 with
                        | US8_1(v90922) -> (* Error *)
                            let v90923 : string = $"%A{v90922}"
                            let v90926 : string = "System.TimeoutException"
                            let v90927 : bool = v90923.Contains v90926 
                            if v90927 then
                                let v90930 : unit = ()
                                let v90931 : (unit -> unit) = closure16(v0)
                                let v90932 : unit = (fun () -> v90931 (); v90930) ()
                                US6_1
                            else
                                let v90973 : unit = ()
                                let v90974 : (unit -> unit) = closure17(v0, v90922)
                                let v90975 : unit = (fun () -> v90974 (); v90973) ()
                                US6_1
                        | US8_0(v90920) -> (* Ok *)
                            US6_0(v90920)
                    return v91043 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v91169 : Async<US6> = _v90916 
            let _v90906 = v91169 
            #endif
#if FABLE_COMPILER_PYTHON
            let v91170 : unit = ()
            let _v91170 =
                async {
                    let! v90886 = v90886 
                    let v91173 : US8 = v90886 
                    let v91297 : US6 =
                        match v91173 with
                        | US8_1(v91176) -> (* Error *)
                            let v91177 : string = $"%A{v91176}"
                            let v91180 : string = "System.TimeoutException"
                            let v91181 : bool = v91177.Contains v91180 
                            if v91181 then
                                let v91184 : unit = ()
                                let v91185 : (unit -> unit) = closure16(v0)
                                let v91186 : unit = (fun () -> v91185 (); v91184) ()
                                US6_1
                            else
                                let v91227 : unit = ()
                                let v91228 : (unit -> unit) = closure17(v0, v91176)
                                let v91229 : unit = (fun () -> v91228 (); v91227) ()
                                US6_1
                        | US8_0(v91174) -> (* Ok *)
                            US6_0(v91174)
                    return v91297 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v91423 : Async<US6> = _v91170 
            let _v90906 = v91423 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v91424 : unit = ()
            let _v91424 =
                async {
                    let! v90886 = v90886 
                    let v91427 : US8 = v90886 
                    let v91551 : US6 =
                        match v91427 with
                        | US8_1(v91430) -> (* Error *)
                            let v91431 : string = $"%A{v91430}"
                            let v91434 : string = "System.TimeoutException"
                            let v91435 : bool = v91431.Contains v91434 
                            if v91435 then
                                let v91438 : unit = ()
                                let v91439 : (unit -> unit) = closure16(v0)
                                let v91440 : unit = (fun () -> v91439 (); v91438) ()
                                US6_1
                            else
                                let v91481 : unit = ()
                                let v91482 : (unit -> unit) = closure17(v0, v91430)
                                let v91483 : unit = (fun () -> v91482 (); v91481) ()
                                US6_1
                        | US8_0(v91428) -> (* Ok *)
                            US6_0(v91428)
                    return v91551 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v91677 : Async<US6> = _v91424 
            let _v90906 = v91677 
            #endif
#else
            let v91678 : unit = ()
            let _v91678 =
                async {
                    let! v90886 = v90886 
                    let v91681 : US8 = v90886 
                    let v91805 : US6 =
                        match v91681 with
                        | US8_1(v91684) -> (* Error *)
                            let v91685 : string = $"%A{v91684}"
                            let v91688 : string = "System.TimeoutException"
                            let v91689 : bool = v91685.Contains v91688 
                            if v91689 then
                                let v91692 : unit = ()
                                let v91693 : (unit -> unit) = closure16(v0)
                                let v91694 : unit = (fun () -> v91693 (); v91692) ()
                                US6_1
                            else
                                let v91735 : unit = ()
                                let v91736 : (unit -> unit) = closure17(v0, v91684)
                                let v91737 : unit = (fun () -> v91736 (); v91735) ()
                                US6_1
                        | US8_0(v91682) -> (* Ok *)
                            US6_0(v91682)
                    return v91805 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v91931 : Async<US6> = _v91678 
            let _v90906 = v91931 
            #endif
            let v91932 : Async<US6> = _v90906 
            return! v91932 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v93924 : Async<US6> = _v90449 
    let _v86963 = v93924 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v93925 : unit = ()
    let _v93925 =
        async {
            let v93928 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93929 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v93928 = v93929 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v93932 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v93928 = v93932 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v93935 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v93928 = v93935 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v93938 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v93928 = v93938 
            #endif
#if FABLE_COMPILER_PYTHON
            let v93939 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v93928 = v93939 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v93940 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v93928 = v93940 
            #endif
#else
            let v93941 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v93928 = v93941 
            #endif
            let v93942 : Async<Async<bool>> = _v93928 
            let! v93942 = v93942 
            let v93947 : Async<bool> = v93942 
            let v93948 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93949 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93950 : Async<Choice<bool, exn>> = v93949 v93947
            let _v93948 = v93950 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v93951 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93952 : Async<Choice<bool, exn>> = v93951 v93947
            let _v93948 = v93952 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v93953 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93954 : Async<Choice<bool, exn>> = v93953 v93947
            let _v93948 = v93954 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v93955 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93956 : Async<Choice<bool, exn>> = v93955 v93947
            let _v93948 = v93956 
            #endif
#if FABLE_COMPILER_PYTHON
            let v93957 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93958 : Async<Choice<bool, exn>> = v93957 v93947
            let _v93948 = v93958 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v93959 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93960 : Async<Choice<bool, exn>> = v93959 v93947
            let _v93948 = v93960 
            #endif
#else
            let v93961 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v93962 : Async<Choice<bool, exn>> = v93961 v93947
            let _v93948 = v93962 
            #endif
            let v93963 : Async<Choice<bool, exn>> = _v93948 
            let v93968 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v93969 : Async<US7> = null |> unbox<Async<US7>>
            let _v93968 = v93969 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v93972 : Async<US7> = null |> unbox<Async<US7>>
            let _v93968 = v93972 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v93975 : Async<US7> = null |> unbox<Async<US7>>
            let _v93968 = v93975 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v93978 : unit = ()
            let _v93978 =
                async {
                    let! v93963 = v93963 
                    let v93981 : Choice<bool, exn> = v93963 
                    let v93982 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v93983 : US7 = null |> unbox<US7>
                    let _v93982 = v93983 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v93986 : US7 = null |> unbox<US7>
                    let _v93982 = v93986 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v93989 : US7 = null |> unbox<US7>
                    let _v93982 = v93989 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v93992 : US7 = null |> unbox<US7>
                    let _v93982 = v93992 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v93995 : US7 = null |> unbox<US7>
                    let _v93982 = v93995 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v93998 : (bool -> US7) = method22()
                    let v93999 : (exn -> US7) = method23()
                    let v94000 : US7 = match v93981 with Choice1Of2 x -> v93998 x | Choice2Of2 x -> v93999 x
                    let _v93982 = v94000 
                    #endif
#else
                    let v94001 : (bool -> US7) = method22()
                    let v94002 : (exn -> US7) = method23()
                    let v94003 : US7 = match v93981 with Choice1Of2 x -> v94001 x | Choice2Of2 x -> v94002 x
                    let _v93982 = v94003 
                    #endif
                    let v94004 : US7 = _v93982 
                    return v94004 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94037 : Async<US7> = _v93978 
            let _v93968 = v94037 
            #endif
#if FABLE_COMPILER_PYTHON
            let v94038 : unit = ()
            let _v94038 =
                async {
                    let! v93963 = v93963 
                    let v94041 : Choice<bool, exn> = v93963 
                    let v94042 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v94043 : US7 = null |> unbox<US7>
                    let _v94042 = v94043 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94046 : US7 = null |> unbox<US7>
                    let _v94042 = v94046 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v94049 : US7 = null |> unbox<US7>
                    let _v94042 = v94049 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v94052 : US7 = null |> unbox<US7>
                    let _v94042 = v94052 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v94055 : US7 = null |> unbox<US7>
                    let _v94042 = v94055 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v94058 : (bool -> US7) = method22()
                    let v94059 : (exn -> US7) = method23()
                    let v94060 : US7 = match v94041 with Choice1Of2 x -> v94058 x | Choice2Of2 x -> v94059 x
                    let _v94042 = v94060 
                    #endif
#else
                    let v94061 : (bool -> US7) = method22()
                    let v94062 : (exn -> US7) = method23()
                    let v94063 : US7 = match v94041 with Choice1Of2 x -> v94061 x | Choice2Of2 x -> v94062 x
                    let _v94042 = v94063 
                    #endif
                    let v94064 : US7 = _v94042 
                    return v94064 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94097 : Async<US7> = _v94038 
            let _v93968 = v94097 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v94098 : unit = ()
            let _v94098 =
                async {
                    let! v93963 = v93963 
                    let v94101 : Choice<bool, exn> = v93963 
                    let v94102 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v94103 : US7 = null |> unbox<US7>
                    let _v94102 = v94103 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94106 : US7 = null |> unbox<US7>
                    let _v94102 = v94106 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v94109 : US7 = null |> unbox<US7>
                    let _v94102 = v94109 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v94112 : US7 = null |> unbox<US7>
                    let _v94102 = v94112 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v94115 : US7 = null |> unbox<US7>
                    let _v94102 = v94115 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v94118 : (bool -> US7) = method22()
                    let v94119 : (exn -> US7) = method23()
                    let v94120 : US7 = match v94101 with Choice1Of2 x -> v94118 x | Choice2Of2 x -> v94119 x
                    let _v94102 = v94120 
                    #endif
#else
                    let v94121 : (bool -> US7) = method22()
                    let v94122 : (exn -> US7) = method23()
                    let v94123 : US7 = match v94101 with Choice1Of2 x -> v94121 x | Choice2Of2 x -> v94122 x
                    let _v94102 = v94123 
                    #endif
                    let v94124 : US7 = _v94102 
                    return v94124 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94157 : Async<US7> = _v94098 
            let _v93968 = v94157 
            #endif
#else
            let v94158 : unit = ()
            let _v94158 =
                async {
                    let! v93963 = v93963 
                    let v94161 : Choice<bool, exn> = v93963 
                    let v94162 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v94163 : US7 = null |> unbox<US7>
                    let _v94162 = v94163 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94166 : US7 = null |> unbox<US7>
                    let _v94162 = v94166 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v94169 : US7 = null |> unbox<US7>
                    let _v94162 = v94169 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v94172 : US7 = null |> unbox<US7>
                    let _v94162 = v94172 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v94175 : US7 = null |> unbox<US7>
                    let _v94162 = v94175 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v94178 : (bool -> US7) = method22()
                    let v94179 : (exn -> US7) = method23()
                    let v94180 : US7 = match v94161 with Choice1Of2 x -> v94178 x | Choice2Of2 x -> v94179 x
                    let _v94162 = v94180 
                    #endif
#else
                    let v94181 : (bool -> US7) = method22()
                    let v94182 : (exn -> US7) = method23()
                    let v94183 : US7 = match v94161 with Choice1Of2 x -> v94181 x | Choice2Of2 x -> v94182 x
                    let _v94162 = v94183 
                    #endif
                    let v94184 : US7 = _v94162 
                    return v94184 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94217 : Async<US7> = _v94158 
            let _v93968 = v94217 
            #endif
            let v94218 : Async<US7> = _v93968 
            let v94280 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v94281 : Async<US8> = null |> unbox<Async<US8>>
            let _v94280 = v94281 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v94284 : Async<US8> = null |> unbox<Async<US8>>
            let _v94280 = v94284 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v94287 : Async<US8> = null |> unbox<Async<US8>>
            let _v94280 = v94287 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v94290 : unit = ()
            let _v94290 =
                async {
                    let! v94218 = v94218 
                    let v94293 : US7 = v94218 
                    let v94299 : US8 =
                        match v94293 with
                        | US7_0(v94294) -> (* C1of2 *)
                            US8_0(v94294)
                        | US7_1(v94296) -> (* C2of2 *)
                            US8_1(v94296)
                    return v94299 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94307 : Async<US8> = _v94290 
            let _v94280 = v94307 
            #endif
#if FABLE_COMPILER_PYTHON
            let v94308 : unit = ()
            let _v94308 =
                async {
                    let! v94218 = v94218 
                    let v94311 : US7 = v94218 
                    let v94317 : US8 =
                        match v94311 with
                        | US7_0(v94312) -> (* C1of2 *)
                            US8_0(v94312)
                        | US7_1(v94314) -> (* C2of2 *)
                            US8_1(v94314)
                    return v94317 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94325 : Async<US8> = _v94308 
            let _v94280 = v94325 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v94326 : unit = ()
            let _v94326 =
                async {
                    let! v94218 = v94218 
                    let v94329 : US7 = v94218 
                    let v94335 : US8 =
                        match v94329 with
                        | US7_0(v94330) -> (* C1of2 *)
                            US8_0(v94330)
                        | US7_1(v94332) -> (* C2of2 *)
                            US8_1(v94332)
                    return v94335 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94343 : Async<US8> = _v94326 
            let _v94280 = v94343 
            #endif
#else
            let v94344 : unit = ()
            let _v94344 =
                async {
                    let! v94218 = v94218 
                    let v94347 : US7 = v94218 
                    let v94353 : US8 =
                        match v94347 with
                        | US7_0(v94348) -> (* C1of2 *)
                            US8_0(v94348)
                        | US7_1(v94350) -> (* C2of2 *)
                            US8_1(v94350)
                    return v94353 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94361 : Async<US8> = _v94344 
            let _v94280 = v94361 
            #endif
            let v94362 : Async<US8> = _v94280 
            let v94382 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v94383 : Async<US6> = null |> unbox<Async<US6>>
            let _v94382 = v94383 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v94386 : Async<US6> = null |> unbox<Async<US6>>
            let _v94382 = v94386 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v94389 : Async<US6> = null |> unbox<Async<US6>>
            let _v94382 = v94389 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v94392 : unit = ()
            let _v94392 =
                async {
                    let! v94362 = v94362 
                    let v94395 : US8 = v94362 
                    let v94519 : US6 =
                        match v94395 with
                        | US8_1(v94398) -> (* Error *)
                            let v94399 : string = $"%A{v94398}"
                            let v94402 : string = "System.TimeoutException"
                            let v94403 : bool = v94399.Contains v94402 
                            if v94403 then
                                let v94406 : unit = ()
                                let v94407 : (unit -> unit) = closure16(v0)
                                let v94408 : unit = (fun () -> v94407 (); v94406) ()
                                US6_1
                            else
                                let v94449 : unit = ()
                                let v94450 : (unit -> unit) = closure17(v0, v94398)
                                let v94451 : unit = (fun () -> v94450 (); v94449) ()
                                US6_1
                        | US8_0(v94396) -> (* Ok *)
                            US6_0(v94396)
                    return v94519 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94645 : Async<US6> = _v94392 
            let _v94382 = v94645 
            #endif
#if FABLE_COMPILER_PYTHON
            let v94646 : unit = ()
            let _v94646 =
                async {
                    let! v94362 = v94362 
                    let v94649 : US8 = v94362 
                    let v94773 : US6 =
                        match v94649 with
                        | US8_1(v94652) -> (* Error *)
                            let v94653 : string = $"%A{v94652}"
                            let v94656 : string = "System.TimeoutException"
                            let v94657 : bool = v94653.Contains v94656 
                            if v94657 then
                                let v94660 : unit = ()
                                let v94661 : (unit -> unit) = closure16(v0)
                                let v94662 : unit = (fun () -> v94661 (); v94660) ()
                                US6_1
                            else
                                let v94703 : unit = ()
                                let v94704 : (unit -> unit) = closure17(v0, v94652)
                                let v94705 : unit = (fun () -> v94704 (); v94703) ()
                                US6_1
                        | US8_0(v94650) -> (* Ok *)
                            US6_0(v94650)
                    return v94773 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v94899 : Async<US6> = _v94646 
            let _v94382 = v94899 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v94900 : unit = ()
            let _v94900 =
                async {
                    let! v94362 = v94362 
                    let v94903 : US8 = v94362 
                    let v95027 : US6 =
                        match v94903 with
                        | US8_1(v94906) -> (* Error *)
                            let v94907 : string = $"%A{v94906}"
                            let v94910 : string = "System.TimeoutException"
                            let v94911 : bool = v94907.Contains v94910 
                            if v94911 then
                                let v94914 : unit = ()
                                let v94915 : (unit -> unit) = closure16(v0)
                                let v94916 : unit = (fun () -> v94915 (); v94914) ()
                                US6_1
                            else
                                let v94957 : unit = ()
                                let v94958 : (unit -> unit) = closure17(v0, v94906)
                                let v94959 : unit = (fun () -> v94958 (); v94957) ()
                                US6_1
                        | US8_0(v94904) -> (* Ok *)
                            US6_0(v94904)
                    return v95027 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v95153 : Async<US6> = _v94900 
            let _v94382 = v95153 
            #endif
#else
            let v95154 : unit = ()
            let _v95154 =
                async {
                    let! v94362 = v94362 
                    let v95157 : US8 = v94362 
                    let v95281 : US6 =
                        match v95157 with
                        | US8_1(v95160) -> (* Error *)
                            let v95161 : string = $"%A{v95160}"
                            let v95164 : string = "System.TimeoutException"
                            let v95165 : bool = v95161.Contains v95164 
                            if v95165 then
                                let v95168 : unit = ()
                                let v95169 : (unit -> unit) = closure16(v0)
                                let v95170 : unit = (fun () -> v95169 (); v95168) ()
                                US6_1
                            else
                                let v95211 : unit = ()
                                let v95212 : (unit -> unit) = closure17(v0, v95160)
                                let v95213 : unit = (fun () -> v95212 (); v95211) ()
                                US6_1
                        | US8_0(v95158) -> (* Ok *)
                            US6_0(v95158)
                    return v95281 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v95407 : Async<US6> = _v95154 
            let _v94382 = v95407 
            #endif
            let v95408 : Async<US6> = _v94382 
            return! v95408 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v97400 : Async<US6> = _v93925 
    let _v86963 = v97400 
    #endif
#else
    let v97401 : unit = ()
    let _v97401 =
        async {
            let v97404 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97405 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v97404 = v97405 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v97408 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v97404 = v97408 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97411 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v97404 = v97411 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97414 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v97404 = v97414 
            #endif
#if FABLE_COMPILER_PYTHON
            let v97415 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v97404 = v97415 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v97416 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v97404 = v97416 
            #endif
#else
            let v97417 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v97404 = v97417 
            #endif
            let v97418 : Async<Async<bool>> = _v97404 
            let! v97418 = v97418 
            let v97423 : Async<bool> = v97418 
            let v97424 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97425 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97426 : Async<Choice<bool, exn>> = v97425 v97423
            let _v97424 = v97426 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v97427 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97428 : Async<Choice<bool, exn>> = v97427 v97423
            let _v97424 = v97428 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97429 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97430 : Async<Choice<bool, exn>> = v97429 v97423
            let _v97424 = v97430 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97431 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97432 : Async<Choice<bool, exn>> = v97431 v97423
            let _v97424 = v97432 
            #endif
#if FABLE_COMPILER_PYTHON
            let v97433 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97434 : Async<Choice<bool, exn>> = v97433 v97423
            let _v97424 = v97434 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v97435 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97436 : Async<Choice<bool, exn>> = v97435 v97423
            let _v97424 = v97436 
            #endif
#else
            let v97437 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v97438 : Async<Choice<bool, exn>> = v97437 v97423
            let _v97424 = v97438 
            #endif
            let v97439 : Async<Choice<bool, exn>> = _v97424 
            let v97444 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97445 : Async<US7> = null |> unbox<Async<US7>>
            let _v97444 = v97445 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v97448 : Async<US7> = null |> unbox<Async<US7>>
            let _v97444 = v97448 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97451 : Async<US7> = null |> unbox<Async<US7>>
            let _v97444 = v97451 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97454 : unit = ()
            let _v97454 =
                async {
                    let! v97439 = v97439 
                    let v97457 : Choice<bool, exn> = v97439 
                    let v97458 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v97459 : US7 = null |> unbox<US7>
                    let _v97458 = v97459 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v97462 : US7 = null |> unbox<US7>
                    let _v97458 = v97462 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97465 : US7 = null |> unbox<US7>
                    let _v97458 = v97465 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v97468 : US7 = null |> unbox<US7>
                    let _v97458 = v97468 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v97471 : US7 = null |> unbox<US7>
                    let _v97458 = v97471 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v97474 : (bool -> US7) = method22()
                    let v97475 : (exn -> US7) = method23()
                    let v97476 : US7 = match v97457 with Choice1Of2 x -> v97474 x | Choice2Of2 x -> v97475 x
                    let _v97458 = v97476 
                    #endif
#else
                    let v97477 : (bool -> US7) = method22()
                    let v97478 : (exn -> US7) = method23()
                    let v97479 : US7 = match v97457 with Choice1Of2 x -> v97477 x | Choice2Of2 x -> v97478 x
                    let _v97458 = v97479 
                    #endif
                    let v97480 : US7 = _v97458 
                    return v97480 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97513 : Async<US7> = _v97454 
            let _v97444 = v97513 
            #endif
#if FABLE_COMPILER_PYTHON
            let v97514 : unit = ()
            let _v97514 =
                async {
                    let! v97439 = v97439 
                    let v97517 : Choice<bool, exn> = v97439 
                    let v97518 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v97519 : US7 = null |> unbox<US7>
                    let _v97518 = v97519 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v97522 : US7 = null |> unbox<US7>
                    let _v97518 = v97522 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97525 : US7 = null |> unbox<US7>
                    let _v97518 = v97525 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v97528 : US7 = null |> unbox<US7>
                    let _v97518 = v97528 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v97531 : US7 = null |> unbox<US7>
                    let _v97518 = v97531 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v97534 : (bool -> US7) = method22()
                    let v97535 : (exn -> US7) = method23()
                    let v97536 : US7 = match v97517 with Choice1Of2 x -> v97534 x | Choice2Of2 x -> v97535 x
                    let _v97518 = v97536 
                    #endif
#else
                    let v97537 : (bool -> US7) = method22()
                    let v97538 : (exn -> US7) = method23()
                    let v97539 : US7 = match v97517 with Choice1Of2 x -> v97537 x | Choice2Of2 x -> v97538 x
                    let _v97518 = v97539 
                    #endif
                    let v97540 : US7 = _v97518 
                    return v97540 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97573 : Async<US7> = _v97514 
            let _v97444 = v97573 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v97574 : unit = ()
            let _v97574 =
                async {
                    let! v97439 = v97439 
                    let v97577 : Choice<bool, exn> = v97439 
                    let v97578 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v97579 : US7 = null |> unbox<US7>
                    let _v97578 = v97579 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v97582 : US7 = null |> unbox<US7>
                    let _v97578 = v97582 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97585 : US7 = null |> unbox<US7>
                    let _v97578 = v97585 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v97588 : US7 = null |> unbox<US7>
                    let _v97578 = v97588 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v97591 : US7 = null |> unbox<US7>
                    let _v97578 = v97591 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v97594 : (bool -> US7) = method22()
                    let v97595 : (exn -> US7) = method23()
                    let v97596 : US7 = match v97577 with Choice1Of2 x -> v97594 x | Choice2Of2 x -> v97595 x
                    let _v97578 = v97596 
                    #endif
#else
                    let v97597 : (bool -> US7) = method22()
                    let v97598 : (exn -> US7) = method23()
                    let v97599 : US7 = match v97577 with Choice1Of2 x -> v97597 x | Choice2Of2 x -> v97598 x
                    let _v97578 = v97599 
                    #endif
                    let v97600 : US7 = _v97578 
                    return v97600 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97633 : Async<US7> = _v97574 
            let _v97444 = v97633 
            #endif
#else
            let v97634 : unit = ()
            let _v97634 =
                async {
                    let! v97439 = v97439 
                    let v97637 : Choice<bool, exn> = v97439 
                    let v97638 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v97639 : US7 = null |> unbox<US7>
                    let _v97638 = v97639 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v97642 : US7 = null |> unbox<US7>
                    let _v97638 = v97642 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97645 : US7 = null |> unbox<US7>
                    let _v97638 = v97645 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v97648 : US7 = null |> unbox<US7>
                    let _v97638 = v97648 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v97651 : US7 = null |> unbox<US7>
                    let _v97638 = v97651 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v97654 : (bool -> US7) = method22()
                    let v97655 : (exn -> US7) = method23()
                    let v97656 : US7 = match v97637 with Choice1Of2 x -> v97654 x | Choice2Of2 x -> v97655 x
                    let _v97638 = v97656 
                    #endif
#else
                    let v97657 : (bool -> US7) = method22()
                    let v97658 : (exn -> US7) = method23()
                    let v97659 : US7 = match v97637 with Choice1Of2 x -> v97657 x | Choice2Of2 x -> v97658 x
                    let _v97638 = v97659 
                    #endif
                    let v97660 : US7 = _v97638 
                    return v97660 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97693 : Async<US7> = _v97634 
            let _v97444 = v97693 
            #endif
            let v97694 : Async<US7> = _v97444 
            let v97756 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97757 : Async<US8> = null |> unbox<Async<US8>>
            let _v97756 = v97757 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v97760 : Async<US8> = null |> unbox<Async<US8>>
            let _v97756 = v97760 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97763 : Async<US8> = null |> unbox<Async<US8>>
            let _v97756 = v97763 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97766 : unit = ()
            let _v97766 =
                async {
                    let! v97694 = v97694 
                    let v97769 : US7 = v97694 
                    let v97775 : US8 =
                        match v97769 with
                        | US7_0(v97770) -> (* C1of2 *)
                            US8_0(v97770)
                        | US7_1(v97772) -> (* C2of2 *)
                            US8_1(v97772)
                    return v97775 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97783 : Async<US8> = _v97766 
            let _v97756 = v97783 
            #endif
#if FABLE_COMPILER_PYTHON
            let v97784 : unit = ()
            let _v97784 =
                async {
                    let! v97694 = v97694 
                    let v97787 : US7 = v97694 
                    let v97793 : US8 =
                        match v97787 with
                        | US7_0(v97788) -> (* C1of2 *)
                            US8_0(v97788)
                        | US7_1(v97790) -> (* C2of2 *)
                            US8_1(v97790)
                    return v97793 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97801 : Async<US8> = _v97784 
            let _v97756 = v97801 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v97802 : unit = ()
            let _v97802 =
                async {
                    let! v97694 = v97694 
                    let v97805 : US7 = v97694 
                    let v97811 : US8 =
                        match v97805 with
                        | US7_0(v97806) -> (* C1of2 *)
                            US8_0(v97806)
                        | US7_1(v97808) -> (* C2of2 *)
                            US8_1(v97808)
                    return v97811 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97819 : Async<US8> = _v97802 
            let _v97756 = v97819 
            #endif
#else
            let v97820 : unit = ()
            let _v97820 =
                async {
                    let! v97694 = v97694 
                    let v97823 : US7 = v97694 
                    let v97829 : US8 =
                        match v97823 with
                        | US7_0(v97824) -> (* C1of2 *)
                            US8_0(v97824)
                        | US7_1(v97826) -> (* C2of2 *)
                            US8_1(v97826)
                    return v97829 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v97837 : Async<US8> = _v97820 
            let _v97756 = v97837 
            #endif
            let v97838 : Async<US8> = _v97756 
            let v97858 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v97859 : Async<US6> = null |> unbox<Async<US6>>
            let _v97858 = v97859 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v97862 : Async<US6> = null |> unbox<Async<US6>>
            let _v97858 = v97862 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v97865 : Async<US6> = null |> unbox<Async<US6>>
            let _v97858 = v97865 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v97868 : unit = ()
            let _v97868 =
                async {
                    let! v97838 = v97838 
                    let v97871 : US8 = v97838 
                    let v97995 : US6 =
                        match v97871 with
                        | US8_1(v97874) -> (* Error *)
                            let v97875 : string = $"%A{v97874}"
                            let v97878 : string = "System.TimeoutException"
                            let v97879 : bool = v97875.Contains v97878 
                            if v97879 then
                                let v97882 : unit = ()
                                let v97883 : (unit -> unit) = closure16(v0)
                                let v97884 : unit = (fun () -> v97883 (); v97882) ()
                                US6_1
                            else
                                let v97925 : unit = ()
                                let v97926 : (unit -> unit) = closure17(v0, v97874)
                                let v97927 : unit = (fun () -> v97926 (); v97925) ()
                                US6_1
                        | US8_0(v97872) -> (* Ok *)
                            US6_0(v97872)
                    return v97995 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v98121 : Async<US6> = _v97868 
            let _v97858 = v98121 
            #endif
#if FABLE_COMPILER_PYTHON
            let v98122 : unit = ()
            let _v98122 =
                async {
                    let! v97838 = v97838 
                    let v98125 : US8 = v97838 
                    let v98249 : US6 =
                        match v98125 with
                        | US8_1(v98128) -> (* Error *)
                            let v98129 : string = $"%A{v98128}"
                            let v98132 : string = "System.TimeoutException"
                            let v98133 : bool = v98129.Contains v98132 
                            if v98133 then
                                let v98136 : unit = ()
                                let v98137 : (unit -> unit) = closure16(v0)
                                let v98138 : unit = (fun () -> v98137 (); v98136) ()
                                US6_1
                            else
                                let v98179 : unit = ()
                                let v98180 : (unit -> unit) = closure17(v0, v98128)
                                let v98181 : unit = (fun () -> v98180 (); v98179) ()
                                US6_1
                        | US8_0(v98126) -> (* Ok *)
                            US6_0(v98126)
                    return v98249 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v98375 : Async<US6> = _v98122 
            let _v97858 = v98375 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v98376 : unit = ()
            let _v98376 =
                async {
                    let! v97838 = v97838 
                    let v98379 : US8 = v97838 
                    let v98503 : US6 =
                        match v98379 with
                        | US8_1(v98382) -> (* Error *)
                            let v98383 : string = $"%A{v98382}"
                            let v98386 : string = "System.TimeoutException"
                            let v98387 : bool = v98383.Contains v98386 
                            if v98387 then
                                let v98390 : unit = ()
                                let v98391 : (unit -> unit) = closure16(v0)
                                let v98392 : unit = (fun () -> v98391 (); v98390) ()
                                US6_1
                            else
                                let v98433 : unit = ()
                                let v98434 : (unit -> unit) = closure17(v0, v98382)
                                let v98435 : unit = (fun () -> v98434 (); v98433) ()
                                US6_1
                        | US8_0(v98380) -> (* Ok *)
                            US6_0(v98380)
                    return v98503 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v98629 : Async<US6> = _v98376 
            let _v97858 = v98629 
            #endif
#else
            let v98630 : unit = ()
            let _v98630 =
                async {
                    let! v97838 = v97838 
                    let v98633 : US8 = v97838 
                    let v98757 : US6 =
                        match v98633 with
                        | US8_1(v98636) -> (* Error *)
                            let v98637 : string = $"%A{v98636}"
                            let v98640 : string = "System.TimeoutException"
                            let v98641 : bool = v98637.Contains v98640 
                            if v98641 then
                                let v98644 : unit = ()
                                let v98645 : (unit -> unit) = closure16(v0)
                                let v98646 : unit = (fun () -> v98645 (); v98644) ()
                                US6_1
                            else
                                let v98687 : unit = ()
                                let v98688 : (unit -> unit) = closure17(v0, v98636)
                                let v98689 : unit = (fun () -> v98688 (); v98687) ()
                                US6_1
                        | US8_0(v98634) -> (* Ok *)
                            US6_0(v98634)
                    return v98757 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v98883 : Async<US6> = _v98630 
            let _v97858 = v98883 
            #endif
            let v98884 : Async<US6> = _v97858 
            return! v98884 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v100876 : Async<US6> = _v97401 
    let _v86963 = v100876 
    #endif
    let v100877 : Async<US6> = _v86963 
    let _v2 = v100877 
    #endif
#else
    let v104355 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v104356 : Async<US6> = null |> unbox<Async<US6>>
    let _v104355 = v104356 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104359 : Async<US6> = null |> unbox<Async<US6>>
    let _v104355 = v104359 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v104362 : Async<US6> = null |> unbox<Async<US6>>
    let _v104355 = v104362 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104365 : unit = ()
    let _v104365 =
        async {
            let v104368 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104369 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v104368 = v104369 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104372 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v104368 = v104372 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104375 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v104368 = v104375 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104378 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v104368 = v104378 
            #endif
#if FABLE_COMPILER_PYTHON
            let v104379 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v104368 = v104379 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v104380 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v104368 = v104380 
            #endif
#else
            let v104381 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v104368 = v104381 
            #endif
            let v104382 : Async<Async<bool>> = _v104368 
            let! v104382 = v104382 
            let v104387 : Async<bool> = v104382 
            let v104388 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104389 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104390 : Async<Choice<bool, exn>> = v104389 v104387
            let _v104388 = v104390 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104391 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104392 : Async<Choice<bool, exn>> = v104391 v104387
            let _v104388 = v104392 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104393 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104394 : Async<Choice<bool, exn>> = v104393 v104387
            let _v104388 = v104394 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104395 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104396 : Async<Choice<bool, exn>> = v104395 v104387
            let _v104388 = v104396 
            #endif
#if FABLE_COMPILER_PYTHON
            let v104397 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104398 : Async<Choice<bool, exn>> = v104397 v104387
            let _v104388 = v104398 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v104399 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104400 : Async<Choice<bool, exn>> = v104399 v104387
            let _v104388 = v104400 
            #endif
#else
            let v104401 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v104402 : Async<Choice<bool, exn>> = v104401 v104387
            let _v104388 = v104402 
            #endif
            let v104403 : Async<Choice<bool, exn>> = _v104388 
            let v104408 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104409 : Async<US7> = null |> unbox<Async<US7>>
            let _v104408 = v104409 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104412 : Async<US7> = null |> unbox<Async<US7>>
            let _v104408 = v104412 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104415 : Async<US7> = null |> unbox<Async<US7>>
            let _v104408 = v104415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104418 : unit = ()
            let _v104418 =
                async {
                    let! v104403 = v104403 
                    let v104421 : Choice<bool, exn> = v104403 
                    let v104422 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104423 : US7 = null |> unbox<US7>
                    let _v104422 = v104423 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v104426 : US7 = null |> unbox<US7>
                    let _v104422 = v104426 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v104429 : US7 = null |> unbox<US7>
                    let _v104422 = v104429 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v104432 : US7 = null |> unbox<US7>
                    let _v104422 = v104432 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v104435 : US7 = null |> unbox<US7>
                    let _v104422 = v104435 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104438 : (bool -> US7) = method22()
                    let v104439 : (exn -> US7) = method23()
                    let v104440 : US7 = match v104421 with Choice1Of2 x -> v104438 x | Choice2Of2 x -> v104439 x
                    let _v104422 = v104440 
                    #endif
#else
                    let v104441 : (bool -> US7) = method22()
                    let v104442 : (exn -> US7) = method23()
                    let v104443 : US7 = match v104421 with Choice1Of2 x -> v104441 x | Choice2Of2 x -> v104442 x
                    let _v104422 = v104443 
                    #endif
                    let v104444 : US7 = _v104422 
                    return v104444 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104477 : Async<US7> = _v104418 
            let _v104408 = v104477 
            #endif
#if FABLE_COMPILER_PYTHON
            let v104478 : unit = ()
            let _v104478 =
                async {
                    let! v104403 = v104403 
                    let v104481 : Choice<bool, exn> = v104403 
                    let v104482 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104483 : US7 = null |> unbox<US7>
                    let _v104482 = v104483 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v104486 : US7 = null |> unbox<US7>
                    let _v104482 = v104486 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v104489 : US7 = null |> unbox<US7>
                    let _v104482 = v104489 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v104492 : US7 = null |> unbox<US7>
                    let _v104482 = v104492 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v104495 : US7 = null |> unbox<US7>
                    let _v104482 = v104495 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104498 : (bool -> US7) = method22()
                    let v104499 : (exn -> US7) = method23()
                    let v104500 : US7 = match v104481 with Choice1Of2 x -> v104498 x | Choice2Of2 x -> v104499 x
                    let _v104482 = v104500 
                    #endif
#else
                    let v104501 : (bool -> US7) = method22()
                    let v104502 : (exn -> US7) = method23()
                    let v104503 : US7 = match v104481 with Choice1Of2 x -> v104501 x | Choice2Of2 x -> v104502 x
                    let _v104482 = v104503 
                    #endif
                    let v104504 : US7 = _v104482 
                    return v104504 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104537 : Async<US7> = _v104478 
            let _v104408 = v104537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v104538 : unit = ()
            let _v104538 =
                async {
                    let! v104403 = v104403 
                    let v104541 : Choice<bool, exn> = v104403 
                    let v104542 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104543 : US7 = null |> unbox<US7>
                    let _v104542 = v104543 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v104546 : US7 = null |> unbox<US7>
                    let _v104542 = v104546 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v104549 : US7 = null |> unbox<US7>
                    let _v104542 = v104549 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v104552 : US7 = null |> unbox<US7>
                    let _v104542 = v104552 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v104555 : US7 = null |> unbox<US7>
                    let _v104542 = v104555 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104558 : (bool -> US7) = method22()
                    let v104559 : (exn -> US7) = method23()
                    let v104560 : US7 = match v104541 with Choice1Of2 x -> v104558 x | Choice2Of2 x -> v104559 x
                    let _v104542 = v104560 
                    #endif
#else
                    let v104561 : (bool -> US7) = method22()
                    let v104562 : (exn -> US7) = method23()
                    let v104563 : US7 = match v104541 with Choice1Of2 x -> v104561 x | Choice2Of2 x -> v104562 x
                    let _v104542 = v104563 
                    #endif
                    let v104564 : US7 = _v104542 
                    return v104564 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104597 : Async<US7> = _v104538 
            let _v104408 = v104597 
            #endif
#else
            let v104598 : unit = ()
            let _v104598 =
                async {
                    let! v104403 = v104403 
                    let v104601 : Choice<bool, exn> = v104403 
                    let v104602 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v104603 : US7 = null |> unbox<US7>
                    let _v104602 = v104603 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v104606 : US7 = null |> unbox<US7>
                    let _v104602 = v104606 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v104609 : US7 = null |> unbox<US7>
                    let _v104602 = v104609 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v104612 : US7 = null |> unbox<US7>
                    let _v104602 = v104612 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v104615 : US7 = null |> unbox<US7>
                    let _v104602 = v104615 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v104618 : (bool -> US7) = method22()
                    let v104619 : (exn -> US7) = method23()
                    let v104620 : US7 = match v104601 with Choice1Of2 x -> v104618 x | Choice2Of2 x -> v104619 x
                    let _v104602 = v104620 
                    #endif
#else
                    let v104621 : (bool -> US7) = method22()
                    let v104622 : (exn -> US7) = method23()
                    let v104623 : US7 = match v104601 with Choice1Of2 x -> v104621 x | Choice2Of2 x -> v104622 x
                    let _v104602 = v104623 
                    #endif
                    let v104624 : US7 = _v104602 
                    return v104624 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104657 : Async<US7> = _v104598 
            let _v104408 = v104657 
            #endif
            let v104658 : Async<US7> = _v104408 
            let v104720 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104721 : Async<US8> = null |> unbox<Async<US8>>
            let _v104720 = v104721 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104724 : Async<US8> = null |> unbox<Async<US8>>
            let _v104720 = v104724 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104727 : Async<US8> = null |> unbox<Async<US8>>
            let _v104720 = v104727 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104730 : unit = ()
            let _v104730 =
                async {
                    let! v104658 = v104658 
                    let v104733 : US7 = v104658 
                    let v104739 : US8 =
                        match v104733 with
                        | US7_0(v104734) -> (* C1of2 *)
                            US8_0(v104734)
                        | US7_1(v104736) -> (* C2of2 *)
                            US8_1(v104736)
                    return v104739 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104747 : Async<US8> = _v104730 
            let _v104720 = v104747 
            #endif
#if FABLE_COMPILER_PYTHON
            let v104748 : unit = ()
            let _v104748 =
                async {
                    let! v104658 = v104658 
                    let v104751 : US7 = v104658 
                    let v104757 : US8 =
                        match v104751 with
                        | US7_0(v104752) -> (* C1of2 *)
                            US8_0(v104752)
                        | US7_1(v104754) -> (* C2of2 *)
                            US8_1(v104754)
                    return v104757 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104765 : Async<US8> = _v104748 
            let _v104720 = v104765 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v104766 : unit = ()
            let _v104766 =
                async {
                    let! v104658 = v104658 
                    let v104769 : US7 = v104658 
                    let v104775 : US8 =
                        match v104769 with
                        | US7_0(v104770) -> (* C1of2 *)
                            US8_0(v104770)
                        | US7_1(v104772) -> (* C2of2 *)
                            US8_1(v104772)
                    return v104775 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104783 : Async<US8> = _v104766 
            let _v104720 = v104783 
            #endif
#else
            let v104784 : unit = ()
            let _v104784 =
                async {
                    let! v104658 = v104658 
                    let v104787 : US7 = v104658 
                    let v104793 : US8 =
                        match v104787 with
                        | US7_0(v104788) -> (* C1of2 *)
                            US8_0(v104788)
                        | US7_1(v104790) -> (* C2of2 *)
                            US8_1(v104790)
                    return v104793 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v104801 : Async<US8> = _v104784 
            let _v104720 = v104801 
            #endif
            let v104802 : Async<US8> = _v104720 
            let v104822 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v104823 : Async<US6> = null |> unbox<Async<US6>>
            let _v104822 = v104823 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v104826 : Async<US6> = null |> unbox<Async<US6>>
            let _v104822 = v104826 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v104829 : Async<US6> = null |> unbox<Async<US6>>
            let _v104822 = v104829 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v104832 : unit = ()
            let _v104832 =
                async {
                    let! v104802 = v104802 
                    let v104835 : US8 = v104802 
                    let v104959 : US6 =
                        match v104835 with
                        | US8_1(v104838) -> (* Error *)
                            let v104839 : string = $"%A{v104838}"
                            let v104842 : string = "System.TimeoutException"
                            let v104843 : bool = v104839.Contains v104842 
                            if v104843 then
                                let v104846 : unit = ()
                                let v104847 : (unit -> unit) = closure16(v0)
                                let v104848 : unit = (fun () -> v104847 (); v104846) ()
                                US6_1
                            else
                                let v104889 : unit = ()
                                let v104890 : (unit -> unit) = closure17(v0, v104838)
                                let v104891 : unit = (fun () -> v104890 (); v104889) ()
                                US6_1
                        | US8_0(v104836) -> (* Ok *)
                            US6_0(v104836)
                    return v104959 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105085 : Async<US6> = _v104832 
            let _v104822 = v105085 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105086 : unit = ()
            let _v105086 =
                async {
                    let! v104802 = v104802 
                    let v105089 : US8 = v104802 
                    let v105213 : US6 =
                        match v105089 with
                        | US8_1(v105092) -> (* Error *)
                            let v105093 : string = $"%A{v105092}"
                            let v105096 : string = "System.TimeoutException"
                            let v105097 : bool = v105093.Contains v105096 
                            if v105097 then
                                let v105100 : unit = ()
                                let v105101 : (unit -> unit) = closure16(v0)
                                let v105102 : unit = (fun () -> v105101 (); v105100) ()
                                US6_1
                            else
                                let v105143 : unit = ()
                                let v105144 : (unit -> unit) = closure17(v0, v105092)
                                let v105145 : unit = (fun () -> v105144 (); v105143) ()
                                US6_1
                        | US8_0(v105090) -> (* Ok *)
                            US6_0(v105090)
                    return v105213 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105339 : Async<US6> = _v105086 
            let _v104822 = v105339 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v105340 : unit = ()
            let _v105340 =
                async {
                    let! v104802 = v104802 
                    let v105343 : US8 = v104802 
                    let v105467 : US6 =
                        match v105343 with
                        | US8_1(v105346) -> (* Error *)
                            let v105347 : string = $"%A{v105346}"
                            let v105350 : string = "System.TimeoutException"
                            let v105351 : bool = v105347.Contains v105350 
                            if v105351 then
                                let v105354 : unit = ()
                                let v105355 : (unit -> unit) = closure16(v0)
                                let v105356 : unit = (fun () -> v105355 (); v105354) ()
                                US6_1
                            else
                                let v105397 : unit = ()
                                let v105398 : (unit -> unit) = closure17(v0, v105346)
                                let v105399 : unit = (fun () -> v105398 (); v105397) ()
                                US6_1
                        | US8_0(v105344) -> (* Ok *)
                            US6_0(v105344)
                    return v105467 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105593 : Async<US6> = _v105340 
            let _v104822 = v105593 
            #endif
#else
            let v105594 : unit = ()
            let _v105594 =
                async {
                    let! v104802 = v104802 
                    let v105597 : US8 = v104802 
                    let v105721 : US6 =
                        match v105597 with
                        | US8_1(v105600) -> (* Error *)
                            let v105601 : string = $"%A{v105600}"
                            let v105604 : string = "System.TimeoutException"
                            let v105605 : bool = v105601.Contains v105604 
                            if v105605 then
                                let v105608 : unit = ()
                                let v105609 : (unit -> unit) = closure16(v0)
                                let v105610 : unit = (fun () -> v105609 (); v105608) ()
                                US6_1
                            else
                                let v105651 : unit = ()
                                let v105652 : (unit -> unit) = closure17(v0, v105600)
                                let v105653 : unit = (fun () -> v105652 (); v105651) ()
                                US6_1
                        | US8_0(v105598) -> (* Ok *)
                            US6_0(v105598)
                    return v105721 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105847 : Async<US6> = _v105594 
            let _v104822 = v105847 
            #endif
            let v105848 : Async<US6> = _v104822 
            return! v105848 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v107840 : Async<US6> = _v104365 
    let _v104355 = v107840 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107841 : unit = ()
    let _v107841 =
        async {
            let v107844 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v107845 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v107844 = v107845 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v107848 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v107844 = v107848 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v107851 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v107844 = v107851 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107854 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v107844 = v107854 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107855 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v107844 = v107855 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v107856 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v107844 = v107856 
            #endif
#else
            let v107857 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v107844 = v107857 
            #endif
            let v107858 : Async<Async<bool>> = _v107844 
            let! v107858 = v107858 
            let v107863 : Async<bool> = v107858 
            let v107864 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v107865 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107866 : Async<Choice<bool, exn>> = v107865 v107863
            let _v107864 = v107866 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v107867 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107868 : Async<Choice<bool, exn>> = v107867 v107863
            let _v107864 = v107868 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v107869 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107870 : Async<Choice<bool, exn>> = v107869 v107863
            let _v107864 = v107870 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107871 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107872 : Async<Choice<bool, exn>> = v107871 v107863
            let _v107864 = v107872 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107873 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107874 : Async<Choice<bool, exn>> = v107873 v107863
            let _v107864 = v107874 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v107875 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107876 : Async<Choice<bool, exn>> = v107875 v107863
            let _v107864 = v107876 
            #endif
#else
            let v107877 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v107878 : Async<Choice<bool, exn>> = v107877 v107863
            let _v107864 = v107878 
            #endif
            let v107879 : Async<Choice<bool, exn>> = _v107864 
            let v107884 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v107885 : Async<US7> = null |> unbox<Async<US7>>
            let _v107884 = v107885 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v107888 : Async<US7> = null |> unbox<Async<US7>>
            let _v107884 = v107888 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v107891 : Async<US7> = null |> unbox<Async<US7>>
            let _v107884 = v107891 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v107894 : unit = ()
            let _v107894 =
                async {
                    let! v107879 = v107879 
                    let v107897 : Choice<bool, exn> = v107879 
                    let v107898 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v107899 : US7 = null |> unbox<US7>
                    let _v107898 = v107899 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v107902 : US7 = null |> unbox<US7>
                    let _v107898 = v107902 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v107905 : US7 = null |> unbox<US7>
                    let _v107898 = v107905 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v107908 : US7 = null |> unbox<US7>
                    let _v107898 = v107908 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v107911 : US7 = null |> unbox<US7>
                    let _v107898 = v107911 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v107914 : (bool -> US7) = method22()
                    let v107915 : (exn -> US7) = method23()
                    let v107916 : US7 = match v107897 with Choice1Of2 x -> v107914 x | Choice2Of2 x -> v107915 x
                    let _v107898 = v107916 
                    #endif
#else
                    let v107917 : (bool -> US7) = method22()
                    let v107918 : (exn -> US7) = method23()
                    let v107919 : US7 = match v107897 with Choice1Of2 x -> v107917 x | Choice2Of2 x -> v107918 x
                    let _v107898 = v107919 
                    #endif
                    let v107920 : US7 = _v107898 
                    return v107920 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v107953 : Async<US7> = _v107894 
            let _v107884 = v107953 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107954 : unit = ()
            let _v107954 =
                async {
                    let! v107879 = v107879 
                    let v107957 : Choice<bool, exn> = v107879 
                    let v107958 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v107959 : US7 = null |> unbox<US7>
                    let _v107958 = v107959 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v107962 : US7 = null |> unbox<US7>
                    let _v107958 = v107962 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v107965 : US7 = null |> unbox<US7>
                    let _v107958 = v107965 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v107968 : US7 = null |> unbox<US7>
                    let _v107958 = v107968 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v107971 : US7 = null |> unbox<US7>
                    let _v107958 = v107971 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v107974 : (bool -> US7) = method22()
                    let v107975 : (exn -> US7) = method23()
                    let v107976 : US7 = match v107957 with Choice1Of2 x -> v107974 x | Choice2Of2 x -> v107975 x
                    let _v107958 = v107976 
                    #endif
#else
                    let v107977 : (bool -> US7) = method22()
                    let v107978 : (exn -> US7) = method23()
                    let v107979 : US7 = match v107957 with Choice1Of2 x -> v107977 x | Choice2Of2 x -> v107978 x
                    let _v107958 = v107979 
                    #endif
                    let v107980 : US7 = _v107958 
                    return v107980 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108013 : Async<US7> = _v107954 
            let _v107884 = v108013 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108014 : unit = ()
            let _v108014 =
                async {
                    let! v107879 = v107879 
                    let v108017 : Choice<bool, exn> = v107879 
                    let v108018 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v108019 : US7 = null |> unbox<US7>
                    let _v108018 = v108019 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v108022 : US7 = null |> unbox<US7>
                    let _v108018 = v108022 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v108025 : US7 = null |> unbox<US7>
                    let _v108018 = v108025 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v108028 : US7 = null |> unbox<US7>
                    let _v108018 = v108028 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v108031 : US7 = null |> unbox<US7>
                    let _v108018 = v108031 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v108034 : (bool -> US7) = method22()
                    let v108035 : (exn -> US7) = method23()
                    let v108036 : US7 = match v108017 with Choice1Of2 x -> v108034 x | Choice2Of2 x -> v108035 x
                    let _v108018 = v108036 
                    #endif
#else
                    let v108037 : (bool -> US7) = method22()
                    let v108038 : (exn -> US7) = method23()
                    let v108039 : US7 = match v108017 with Choice1Of2 x -> v108037 x | Choice2Of2 x -> v108038 x
                    let _v108018 = v108039 
                    #endif
                    let v108040 : US7 = _v108018 
                    return v108040 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108073 : Async<US7> = _v108014 
            let _v107884 = v108073 
            #endif
#else
            let v108074 : unit = ()
            let _v108074 =
                async {
                    let! v107879 = v107879 
                    let v108077 : Choice<bool, exn> = v107879 
                    let v108078 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v108079 : US7 = null |> unbox<US7>
                    let _v108078 = v108079 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v108082 : US7 = null |> unbox<US7>
                    let _v108078 = v108082 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v108085 : US7 = null |> unbox<US7>
                    let _v108078 = v108085 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v108088 : US7 = null |> unbox<US7>
                    let _v108078 = v108088 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v108091 : US7 = null |> unbox<US7>
                    let _v108078 = v108091 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v108094 : (bool -> US7) = method22()
                    let v108095 : (exn -> US7) = method23()
                    let v108096 : US7 = match v108077 with Choice1Of2 x -> v108094 x | Choice2Of2 x -> v108095 x
                    let _v108078 = v108096 
                    #endif
#else
                    let v108097 : (bool -> US7) = method22()
                    let v108098 : (exn -> US7) = method23()
                    let v108099 : US7 = match v108077 with Choice1Of2 x -> v108097 x | Choice2Of2 x -> v108098 x
                    let _v108078 = v108099 
                    #endif
                    let v108100 : US7 = _v108078 
                    return v108100 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108133 : Async<US7> = _v108074 
            let _v107884 = v108133 
            #endif
            let v108134 : Async<US7> = _v107884 
            let v108196 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108197 : Async<US8> = null |> unbox<Async<US8>>
            let _v108196 = v108197 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108200 : Async<US8> = null |> unbox<Async<US8>>
            let _v108196 = v108200 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v108203 : Async<US8> = null |> unbox<Async<US8>>
            let _v108196 = v108203 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v108206 : unit = ()
            let _v108206 =
                async {
                    let! v108134 = v108134 
                    let v108209 : US7 = v108134 
                    let v108215 : US8 =
                        match v108209 with
                        | US7_0(v108210) -> (* C1of2 *)
                            US8_0(v108210)
                        | US7_1(v108212) -> (* C2of2 *)
                            US8_1(v108212)
                    return v108215 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108223 : Async<US8> = _v108206 
            let _v108196 = v108223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108224 : unit = ()
            let _v108224 =
                async {
                    let! v108134 = v108134 
                    let v108227 : US7 = v108134 
                    let v108233 : US8 =
                        match v108227 with
                        | US7_0(v108228) -> (* C1of2 *)
                            US8_0(v108228)
                        | US7_1(v108230) -> (* C2of2 *)
                            US8_1(v108230)
                    return v108233 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108241 : Async<US8> = _v108224 
            let _v108196 = v108241 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108242 : unit = ()
            let _v108242 =
                async {
                    let! v108134 = v108134 
                    let v108245 : US7 = v108134 
                    let v108251 : US8 =
                        match v108245 with
                        | US7_0(v108246) -> (* C1of2 *)
                            US8_0(v108246)
                        | US7_1(v108248) -> (* C2of2 *)
                            US8_1(v108248)
                    return v108251 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108259 : Async<US8> = _v108242 
            let _v108196 = v108259 
            #endif
#else
            let v108260 : unit = ()
            let _v108260 =
                async {
                    let! v108134 = v108134 
                    let v108263 : US7 = v108134 
                    let v108269 : US8 =
                        match v108263 with
                        | US7_0(v108264) -> (* C1of2 *)
                            US8_0(v108264)
                        | US7_1(v108266) -> (* C2of2 *)
                            US8_1(v108266)
                    return v108269 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108277 : Async<US8> = _v108260 
            let _v108196 = v108277 
            #endif
            let v108278 : Async<US8> = _v108196 
            let v108298 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v108299 : Async<US6> = null |> unbox<Async<US6>>
            let _v108298 = v108299 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v108302 : Async<US6> = null |> unbox<Async<US6>>
            let _v108298 = v108302 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v108305 : Async<US6> = null |> unbox<Async<US6>>
            let _v108298 = v108305 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v108308 : unit = ()
            let _v108308 =
                async {
                    let! v108278 = v108278 
                    let v108311 : US8 = v108278 
                    let v108435 : US6 =
                        match v108311 with
                        | US8_1(v108314) -> (* Error *)
                            let v108315 : string = $"%A{v108314}"
                            let v108318 : string = "System.TimeoutException"
                            let v108319 : bool = v108315.Contains v108318 
                            if v108319 then
                                let v108322 : unit = ()
                                let v108323 : (unit -> unit) = closure16(v0)
                                let v108324 : unit = (fun () -> v108323 (); v108322) ()
                                US6_1
                            else
                                let v108365 : unit = ()
                                let v108366 : (unit -> unit) = closure17(v0, v108314)
                                let v108367 : unit = (fun () -> v108366 (); v108365) ()
                                US6_1
                        | US8_0(v108312) -> (* Ok *)
                            US6_0(v108312)
                    return v108435 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108561 : Async<US6> = _v108308 
            let _v108298 = v108561 
            #endif
#if FABLE_COMPILER_PYTHON
            let v108562 : unit = ()
            let _v108562 =
                async {
                    let! v108278 = v108278 
                    let v108565 : US8 = v108278 
                    let v108689 : US6 =
                        match v108565 with
                        | US8_1(v108568) -> (* Error *)
                            let v108569 : string = $"%A{v108568}"
                            let v108572 : string = "System.TimeoutException"
                            let v108573 : bool = v108569.Contains v108572 
                            if v108573 then
                                let v108576 : unit = ()
                                let v108577 : (unit -> unit) = closure16(v0)
                                let v108578 : unit = (fun () -> v108577 (); v108576) ()
                                US6_1
                            else
                                let v108619 : unit = ()
                                let v108620 : (unit -> unit) = closure17(v0, v108568)
                                let v108621 : unit = (fun () -> v108620 (); v108619) ()
                                US6_1
                        | US8_0(v108566) -> (* Ok *)
                            US6_0(v108566)
                    return v108689 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108815 : Async<US6> = _v108562 
            let _v108298 = v108815 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108816 : unit = ()
            let _v108816 =
                async {
                    let! v108278 = v108278 
                    let v108819 : US8 = v108278 
                    let v108943 : US6 =
                        match v108819 with
                        | US8_1(v108822) -> (* Error *)
                            let v108823 : string = $"%A{v108822}"
                            let v108826 : string = "System.TimeoutException"
                            let v108827 : bool = v108823.Contains v108826 
                            if v108827 then
                                let v108830 : unit = ()
                                let v108831 : (unit -> unit) = closure16(v0)
                                let v108832 : unit = (fun () -> v108831 (); v108830) ()
                                US6_1
                            else
                                let v108873 : unit = ()
                                let v108874 : (unit -> unit) = closure17(v0, v108822)
                                let v108875 : unit = (fun () -> v108874 (); v108873) ()
                                US6_1
                        | US8_0(v108820) -> (* Ok *)
                            US6_0(v108820)
                    return v108943 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v109069 : Async<US6> = _v108816 
            let _v108298 = v109069 
            #endif
#else
            let v109070 : unit = ()
            let _v109070 =
                async {
                    let! v108278 = v108278 
                    let v109073 : US8 = v108278 
                    let v109197 : US6 =
                        match v109073 with
                        | US8_1(v109076) -> (* Error *)
                            let v109077 : string = $"%A{v109076}"
                            let v109080 : string = "System.TimeoutException"
                            let v109081 : bool = v109077.Contains v109080 
                            if v109081 then
                                let v109084 : unit = ()
                                let v109085 : (unit -> unit) = closure16(v0)
                                let v109086 : unit = (fun () -> v109085 (); v109084) ()
                                US6_1
                            else
                                let v109127 : unit = ()
                                let v109128 : (unit -> unit) = closure17(v0, v109076)
                                let v109129 : unit = (fun () -> v109128 (); v109127) ()
                                US6_1
                        | US8_0(v109074) -> (* Ok *)
                            US6_0(v109074)
                    return v109197 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v109323 : Async<US6> = _v109070 
            let _v108298 = v109323 
            #endif
            let v109324 : Async<US6> = _v108298 
            return! v109324 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v111316 : Async<US6> = _v107841 
    let _v104355 = v111316 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v111317 : unit = ()
    let _v111317 =
        async {
            let v111320 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v111321 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v111320 = v111321 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v111324 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v111320 = v111324 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v111327 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v111320 = v111327 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111330 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v111320 = v111330 
            #endif
#if FABLE_COMPILER_PYTHON
            let v111331 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v111320 = v111331 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v111332 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v111320 = v111332 
            #endif
#else
            let v111333 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v111320 = v111333 
            #endif
            let v111334 : Async<Async<bool>> = _v111320 
            let! v111334 = v111334 
            let v111339 : Async<bool> = v111334 
            let v111340 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v111341 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111342 : Async<Choice<bool, exn>> = v111341 v111339
            let _v111340 = v111342 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v111343 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111344 : Async<Choice<bool, exn>> = v111343 v111339
            let _v111340 = v111344 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v111345 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111346 : Async<Choice<bool, exn>> = v111345 v111339
            let _v111340 = v111346 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111347 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111348 : Async<Choice<bool, exn>> = v111347 v111339
            let _v111340 = v111348 
            #endif
#if FABLE_COMPILER_PYTHON
            let v111349 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111350 : Async<Choice<bool, exn>> = v111349 v111339
            let _v111340 = v111350 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v111351 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111352 : Async<Choice<bool, exn>> = v111351 v111339
            let _v111340 = v111352 
            #endif
#else
            let v111353 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v111354 : Async<Choice<bool, exn>> = v111353 v111339
            let _v111340 = v111354 
            #endif
            let v111355 : Async<Choice<bool, exn>> = _v111340 
            let v111360 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v111361 : Async<US7> = null |> unbox<Async<US7>>
            let _v111360 = v111361 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v111364 : Async<US7> = null |> unbox<Async<US7>>
            let _v111360 = v111364 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v111367 : Async<US7> = null |> unbox<Async<US7>>
            let _v111360 = v111367 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111370 : unit = ()
            let _v111370 =
                async {
                    let! v111355 = v111355 
                    let v111373 : Choice<bool, exn> = v111355 
                    let v111374 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v111375 : US7 = null |> unbox<US7>
                    let _v111374 = v111375 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v111378 : US7 = null |> unbox<US7>
                    let _v111374 = v111378 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v111381 : US7 = null |> unbox<US7>
                    let _v111374 = v111381 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v111384 : US7 = null |> unbox<US7>
                    let _v111374 = v111384 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v111387 : US7 = null |> unbox<US7>
                    let _v111374 = v111387 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v111390 : (bool -> US7) = method22()
                    let v111391 : (exn -> US7) = method23()
                    let v111392 : US7 = match v111373 with Choice1Of2 x -> v111390 x | Choice2Of2 x -> v111391 x
                    let _v111374 = v111392 
                    #endif
#else
                    let v111393 : (bool -> US7) = method22()
                    let v111394 : (exn -> US7) = method23()
                    let v111395 : US7 = match v111373 with Choice1Of2 x -> v111393 x | Choice2Of2 x -> v111394 x
                    let _v111374 = v111395 
                    #endif
                    let v111396 : US7 = _v111374 
                    return v111396 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111429 : Async<US7> = _v111370 
            let _v111360 = v111429 
            #endif
#if FABLE_COMPILER_PYTHON
            let v111430 : unit = ()
            let _v111430 =
                async {
                    let! v111355 = v111355 
                    let v111433 : Choice<bool, exn> = v111355 
                    let v111434 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v111435 : US7 = null |> unbox<US7>
                    let _v111434 = v111435 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v111438 : US7 = null |> unbox<US7>
                    let _v111434 = v111438 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v111441 : US7 = null |> unbox<US7>
                    let _v111434 = v111441 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v111444 : US7 = null |> unbox<US7>
                    let _v111434 = v111444 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v111447 : US7 = null |> unbox<US7>
                    let _v111434 = v111447 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v111450 : (bool -> US7) = method22()
                    let v111451 : (exn -> US7) = method23()
                    let v111452 : US7 = match v111433 with Choice1Of2 x -> v111450 x | Choice2Of2 x -> v111451 x
                    let _v111434 = v111452 
                    #endif
#else
                    let v111453 : (bool -> US7) = method22()
                    let v111454 : (exn -> US7) = method23()
                    let v111455 : US7 = match v111433 with Choice1Of2 x -> v111453 x | Choice2Of2 x -> v111454 x
                    let _v111434 = v111455 
                    #endif
                    let v111456 : US7 = _v111434 
                    return v111456 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111489 : Async<US7> = _v111430 
            let _v111360 = v111489 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v111490 : unit = ()
            let _v111490 =
                async {
                    let! v111355 = v111355 
                    let v111493 : Choice<bool, exn> = v111355 
                    let v111494 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v111495 : US7 = null |> unbox<US7>
                    let _v111494 = v111495 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v111498 : US7 = null |> unbox<US7>
                    let _v111494 = v111498 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v111501 : US7 = null |> unbox<US7>
                    let _v111494 = v111501 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v111504 : US7 = null |> unbox<US7>
                    let _v111494 = v111504 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v111507 : US7 = null |> unbox<US7>
                    let _v111494 = v111507 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v111510 : (bool -> US7) = method22()
                    let v111511 : (exn -> US7) = method23()
                    let v111512 : US7 = match v111493 with Choice1Of2 x -> v111510 x | Choice2Of2 x -> v111511 x
                    let _v111494 = v111512 
                    #endif
#else
                    let v111513 : (bool -> US7) = method22()
                    let v111514 : (exn -> US7) = method23()
                    let v111515 : US7 = match v111493 with Choice1Of2 x -> v111513 x | Choice2Of2 x -> v111514 x
                    let _v111494 = v111515 
                    #endif
                    let v111516 : US7 = _v111494 
                    return v111516 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111549 : Async<US7> = _v111490 
            let _v111360 = v111549 
            #endif
#else
            let v111550 : unit = ()
            let _v111550 =
                async {
                    let! v111355 = v111355 
                    let v111553 : Choice<bool, exn> = v111355 
                    let v111554 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v111555 : US7 = null |> unbox<US7>
                    let _v111554 = v111555 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v111558 : US7 = null |> unbox<US7>
                    let _v111554 = v111558 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v111561 : US7 = null |> unbox<US7>
                    let _v111554 = v111561 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v111564 : US7 = null |> unbox<US7>
                    let _v111554 = v111564 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v111567 : US7 = null |> unbox<US7>
                    let _v111554 = v111567 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v111570 : (bool -> US7) = method22()
                    let v111571 : (exn -> US7) = method23()
                    let v111572 : US7 = match v111553 with Choice1Of2 x -> v111570 x | Choice2Of2 x -> v111571 x
                    let _v111554 = v111572 
                    #endif
#else
                    let v111573 : (bool -> US7) = method22()
                    let v111574 : (exn -> US7) = method23()
                    let v111575 : US7 = match v111553 with Choice1Of2 x -> v111573 x | Choice2Of2 x -> v111574 x
                    let _v111554 = v111575 
                    #endif
                    let v111576 : US7 = _v111554 
                    return v111576 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111609 : Async<US7> = _v111550 
            let _v111360 = v111609 
            #endif
            let v111610 : Async<US7> = _v111360 
            let v111672 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v111673 : Async<US8> = null |> unbox<Async<US8>>
            let _v111672 = v111673 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v111676 : Async<US8> = null |> unbox<Async<US8>>
            let _v111672 = v111676 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v111679 : Async<US8> = null |> unbox<Async<US8>>
            let _v111672 = v111679 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111682 : unit = ()
            let _v111682 =
                async {
                    let! v111610 = v111610 
                    let v111685 : US7 = v111610 
                    let v111691 : US8 =
                        match v111685 with
                        | US7_0(v111686) -> (* C1of2 *)
                            US8_0(v111686)
                        | US7_1(v111688) -> (* C2of2 *)
                            US8_1(v111688)
                    return v111691 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111699 : Async<US8> = _v111682 
            let _v111672 = v111699 
            #endif
#if FABLE_COMPILER_PYTHON
            let v111700 : unit = ()
            let _v111700 =
                async {
                    let! v111610 = v111610 
                    let v111703 : US7 = v111610 
                    let v111709 : US8 =
                        match v111703 with
                        | US7_0(v111704) -> (* C1of2 *)
                            US8_0(v111704)
                        | US7_1(v111706) -> (* C2of2 *)
                            US8_1(v111706)
                    return v111709 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111717 : Async<US8> = _v111700 
            let _v111672 = v111717 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v111718 : unit = ()
            let _v111718 =
                async {
                    let! v111610 = v111610 
                    let v111721 : US7 = v111610 
                    let v111727 : US8 =
                        match v111721 with
                        | US7_0(v111722) -> (* C1of2 *)
                            US8_0(v111722)
                        | US7_1(v111724) -> (* C2of2 *)
                            US8_1(v111724)
                    return v111727 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111735 : Async<US8> = _v111718 
            let _v111672 = v111735 
            #endif
#else
            let v111736 : unit = ()
            let _v111736 =
                async {
                    let! v111610 = v111610 
                    let v111739 : US7 = v111610 
                    let v111745 : US8 =
                        match v111739 with
                        | US7_0(v111740) -> (* C1of2 *)
                            US8_0(v111740)
                        | US7_1(v111742) -> (* C2of2 *)
                            US8_1(v111742)
                    return v111745 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111753 : Async<US8> = _v111736 
            let _v111672 = v111753 
            #endif
            let v111754 : Async<US8> = _v111672 
            let v111774 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v111775 : Async<US6> = null |> unbox<Async<US6>>
            let _v111774 = v111775 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v111778 : Async<US6> = null |> unbox<Async<US6>>
            let _v111774 = v111778 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v111781 : Async<US6> = null |> unbox<Async<US6>>
            let _v111774 = v111781 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v111784 : unit = ()
            let _v111784 =
                async {
                    let! v111754 = v111754 
                    let v111787 : US8 = v111754 
                    let v111911 : US6 =
                        match v111787 with
                        | US8_1(v111790) -> (* Error *)
                            let v111791 : string = $"%A{v111790}"
                            let v111794 : string = "System.TimeoutException"
                            let v111795 : bool = v111791.Contains v111794 
                            if v111795 then
                                let v111798 : unit = ()
                                let v111799 : (unit -> unit) = closure16(v0)
                                let v111800 : unit = (fun () -> v111799 (); v111798) ()
                                US6_1
                            else
                                let v111841 : unit = ()
                                let v111842 : (unit -> unit) = closure17(v0, v111790)
                                let v111843 : unit = (fun () -> v111842 (); v111841) ()
                                US6_1
                        | US8_0(v111788) -> (* Ok *)
                            US6_0(v111788)
                    return v111911 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v112037 : Async<US6> = _v111784 
            let _v111774 = v112037 
            #endif
#if FABLE_COMPILER_PYTHON
            let v112038 : unit = ()
            let _v112038 =
                async {
                    let! v111754 = v111754 
                    let v112041 : US8 = v111754 
                    let v112165 : US6 =
                        match v112041 with
                        | US8_1(v112044) -> (* Error *)
                            let v112045 : string = $"%A{v112044}"
                            let v112048 : string = "System.TimeoutException"
                            let v112049 : bool = v112045.Contains v112048 
                            if v112049 then
                                let v112052 : unit = ()
                                let v112053 : (unit -> unit) = closure16(v0)
                                let v112054 : unit = (fun () -> v112053 (); v112052) ()
                                US6_1
                            else
                                let v112095 : unit = ()
                                let v112096 : (unit -> unit) = closure17(v0, v112044)
                                let v112097 : unit = (fun () -> v112096 (); v112095) ()
                                US6_1
                        | US8_0(v112042) -> (* Ok *)
                            US6_0(v112042)
                    return v112165 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v112291 : Async<US6> = _v112038 
            let _v111774 = v112291 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v112292 : unit = ()
            let _v112292 =
                async {
                    let! v111754 = v111754 
                    let v112295 : US8 = v111754 
                    let v112419 : US6 =
                        match v112295 with
                        | US8_1(v112298) -> (* Error *)
                            let v112299 : string = $"%A{v112298}"
                            let v112302 : string = "System.TimeoutException"
                            let v112303 : bool = v112299.Contains v112302 
                            if v112303 then
                                let v112306 : unit = ()
                                let v112307 : (unit -> unit) = closure16(v0)
                                let v112308 : unit = (fun () -> v112307 (); v112306) ()
                                US6_1
                            else
                                let v112349 : unit = ()
                                let v112350 : (unit -> unit) = closure17(v0, v112298)
                                let v112351 : unit = (fun () -> v112350 (); v112349) ()
                                US6_1
                        | US8_0(v112296) -> (* Ok *)
                            US6_0(v112296)
                    return v112419 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v112545 : Async<US6> = _v112292 
            let _v111774 = v112545 
            #endif
#else
            let v112546 : unit = ()
            let _v112546 =
                async {
                    let! v111754 = v111754 
                    let v112549 : US8 = v111754 
                    let v112673 : US6 =
                        match v112549 with
                        | US8_1(v112552) -> (* Error *)
                            let v112553 : string = $"%A{v112552}"
                            let v112556 : string = "System.TimeoutException"
                            let v112557 : bool = v112553.Contains v112556 
                            if v112557 then
                                let v112560 : unit = ()
                                let v112561 : (unit -> unit) = closure16(v0)
                                let v112562 : unit = (fun () -> v112561 (); v112560) ()
                                US6_1
                            else
                                let v112603 : unit = ()
                                let v112604 : (unit -> unit) = closure17(v0, v112552)
                                let v112605 : unit = (fun () -> v112604 (); v112603) ()
                                US6_1
                        | US8_0(v112550) -> (* Ok *)
                            US6_0(v112550)
                    return v112673 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v112799 : Async<US6> = _v112546 
            let _v111774 = v112799 
            #endif
            let v112800 : Async<US6> = _v111774 
            return! v112800 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v114792 : Async<US6> = _v111317 
    let _v104355 = v114792 
    #endif
#else
    let v114793 : unit = ()
    let _v114793 =
        async {
            let v114796 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v114797 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v114796 = v114797 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v114800 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v114796 = v114800 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v114803 : Async<Async<bool>> = null |> unbox<Async<Async<bool>>>
            let _v114796 = v114803 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v114806 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v114796 = v114806 
            #endif
#if FABLE_COMPILER_PYTHON
            let v114807 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v114796 = v114807 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v114808 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v114796 = v114808 
            #endif
#else
            let v114809 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v114796 = v114809 
            #endif
            let v114810 : Async<Async<bool>> = _v114796 
            let! v114810 = v114810 
            let v114815 : Async<bool> = v114810 
            let v114816 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v114817 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114818 : Async<Choice<bool, exn>> = v114817 v114815
            let _v114816 = v114818 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v114819 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114820 : Async<Choice<bool, exn>> = v114819 v114815
            let _v114816 = v114820 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v114821 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114822 : Async<Choice<bool, exn>> = v114821 v114815
            let _v114816 = v114822 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v114823 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114824 : Async<Choice<bool, exn>> = v114823 v114815
            let _v114816 = v114824 
            #endif
#if FABLE_COMPILER_PYTHON
            let v114825 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114826 : Async<Choice<bool, exn>> = v114825 v114815
            let _v114816 = v114826 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v114827 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114828 : Async<Choice<bool, exn>> = v114827 v114815
            let _v114816 = v114828 
            #endif
#else
            let v114829 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v114830 : Async<Choice<bool, exn>> = v114829 v114815
            let _v114816 = v114830 
            #endif
            let v114831 : Async<Choice<bool, exn>> = _v114816 
            let v114836 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v114837 : Async<US7> = null |> unbox<Async<US7>>
            let _v114836 = v114837 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v114840 : Async<US7> = null |> unbox<Async<US7>>
            let _v114836 = v114840 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v114843 : Async<US7> = null |> unbox<Async<US7>>
            let _v114836 = v114843 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v114846 : unit = ()
            let _v114846 =
                async {
                    let! v114831 = v114831 
                    let v114849 : Choice<bool, exn> = v114831 
                    let v114850 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v114851 : US7 = null |> unbox<US7>
                    let _v114850 = v114851 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v114854 : US7 = null |> unbox<US7>
                    let _v114850 = v114854 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v114857 : US7 = null |> unbox<US7>
                    let _v114850 = v114857 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v114860 : US7 = null |> unbox<US7>
                    let _v114850 = v114860 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v114863 : US7 = null |> unbox<US7>
                    let _v114850 = v114863 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v114866 : (bool -> US7) = method22()
                    let v114867 : (exn -> US7) = method23()
                    let v114868 : US7 = match v114849 with Choice1Of2 x -> v114866 x | Choice2Of2 x -> v114867 x
                    let _v114850 = v114868 
                    #endif
#else
                    let v114869 : (bool -> US7) = method22()
                    let v114870 : (exn -> US7) = method23()
                    let v114871 : US7 = match v114849 with Choice1Of2 x -> v114869 x | Choice2Of2 x -> v114870 x
                    let _v114850 = v114871 
                    #endif
                    let v114872 : US7 = _v114850 
                    return v114872 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v114905 : Async<US7> = _v114846 
            let _v114836 = v114905 
            #endif
#if FABLE_COMPILER_PYTHON
            let v114906 : unit = ()
            let _v114906 =
                async {
                    let! v114831 = v114831 
                    let v114909 : Choice<bool, exn> = v114831 
                    let v114910 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v114911 : US7 = null |> unbox<US7>
                    let _v114910 = v114911 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v114914 : US7 = null |> unbox<US7>
                    let _v114910 = v114914 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v114917 : US7 = null |> unbox<US7>
                    let _v114910 = v114917 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v114920 : US7 = null |> unbox<US7>
                    let _v114910 = v114920 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v114923 : US7 = null |> unbox<US7>
                    let _v114910 = v114923 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v114926 : (bool -> US7) = method22()
                    let v114927 : (exn -> US7) = method23()
                    let v114928 : US7 = match v114909 with Choice1Of2 x -> v114926 x | Choice2Of2 x -> v114927 x
                    let _v114910 = v114928 
                    #endif
#else
                    let v114929 : (bool -> US7) = method22()
                    let v114930 : (exn -> US7) = method23()
                    let v114931 : US7 = match v114909 with Choice1Of2 x -> v114929 x | Choice2Of2 x -> v114930 x
                    let _v114910 = v114931 
                    #endif
                    let v114932 : US7 = _v114910 
                    return v114932 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v114965 : Async<US7> = _v114906 
            let _v114836 = v114965 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v114966 : unit = ()
            let _v114966 =
                async {
                    let! v114831 = v114831 
                    let v114969 : Choice<bool, exn> = v114831 
                    let v114970 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v114971 : US7 = null |> unbox<US7>
                    let _v114970 = v114971 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v114974 : US7 = null |> unbox<US7>
                    let _v114970 = v114974 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v114977 : US7 = null |> unbox<US7>
                    let _v114970 = v114977 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v114980 : US7 = null |> unbox<US7>
                    let _v114970 = v114980 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v114983 : US7 = null |> unbox<US7>
                    let _v114970 = v114983 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v114986 : (bool -> US7) = method22()
                    let v114987 : (exn -> US7) = method23()
                    let v114988 : US7 = match v114969 with Choice1Of2 x -> v114986 x | Choice2Of2 x -> v114987 x
                    let _v114970 = v114988 
                    #endif
#else
                    let v114989 : (bool -> US7) = method22()
                    let v114990 : (exn -> US7) = method23()
                    let v114991 : US7 = match v114969 with Choice1Of2 x -> v114989 x | Choice2Of2 x -> v114990 x
                    let _v114970 = v114991 
                    #endif
                    let v114992 : US7 = _v114970 
                    return v114992 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115025 : Async<US7> = _v114966 
            let _v114836 = v115025 
            #endif
#else
            let v115026 : unit = ()
            let _v115026 =
                async {
                    let! v114831 = v114831 
                    let v115029 : Choice<bool, exn> = v114831 
                    let v115030 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v115031 : US7 = null |> unbox<US7>
                    let _v115030 = v115031 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v115034 : US7 = null |> unbox<US7>
                    let _v115030 = v115034 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v115037 : US7 = null |> unbox<US7>
                    let _v115030 = v115037 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v115040 : US7 = null |> unbox<US7>
                    let _v115030 = v115040 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v115043 : US7 = null |> unbox<US7>
                    let _v115030 = v115043 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v115046 : (bool -> US7) = method22()
                    let v115047 : (exn -> US7) = method23()
                    let v115048 : US7 = match v115029 with Choice1Of2 x -> v115046 x | Choice2Of2 x -> v115047 x
                    let _v115030 = v115048 
                    #endif
#else
                    let v115049 : (bool -> US7) = method22()
                    let v115050 : (exn -> US7) = method23()
                    let v115051 : US7 = match v115029 with Choice1Of2 x -> v115049 x | Choice2Of2 x -> v115050 x
                    let _v115030 = v115051 
                    #endif
                    let v115052 : US7 = _v115030 
                    return v115052 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115085 : Async<US7> = _v115026 
            let _v114836 = v115085 
            #endif
            let v115086 : Async<US7> = _v114836 
            let v115148 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115149 : Async<US8> = null |> unbox<Async<US8>>
            let _v115148 = v115149 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v115152 : Async<US8> = null |> unbox<Async<US8>>
            let _v115148 = v115152 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v115155 : Async<US8> = null |> unbox<Async<US8>>
            let _v115148 = v115155 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v115158 : unit = ()
            let _v115158 =
                async {
                    let! v115086 = v115086 
                    let v115161 : US7 = v115086 
                    let v115167 : US8 =
                        match v115161 with
                        | US7_0(v115162) -> (* C1of2 *)
                            US8_0(v115162)
                        | US7_1(v115164) -> (* C2of2 *)
                            US8_1(v115164)
                    return v115167 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115175 : Async<US8> = _v115158 
            let _v115148 = v115175 
            #endif
#if FABLE_COMPILER_PYTHON
            let v115176 : unit = ()
            let _v115176 =
                async {
                    let! v115086 = v115086 
                    let v115179 : US7 = v115086 
                    let v115185 : US8 =
                        match v115179 with
                        | US7_0(v115180) -> (* C1of2 *)
                            US8_0(v115180)
                        | US7_1(v115182) -> (* C2of2 *)
                            US8_1(v115182)
                    return v115185 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115193 : Async<US8> = _v115176 
            let _v115148 = v115193 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v115194 : unit = ()
            let _v115194 =
                async {
                    let! v115086 = v115086 
                    let v115197 : US7 = v115086 
                    let v115203 : US8 =
                        match v115197 with
                        | US7_0(v115198) -> (* C1of2 *)
                            US8_0(v115198)
                        | US7_1(v115200) -> (* C2of2 *)
                            US8_1(v115200)
                    return v115203 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115211 : Async<US8> = _v115194 
            let _v115148 = v115211 
            #endif
#else
            let v115212 : unit = ()
            let _v115212 =
                async {
                    let! v115086 = v115086 
                    let v115215 : US7 = v115086 
                    let v115221 : US8 =
                        match v115215 with
                        | US7_0(v115216) -> (* C1of2 *)
                            US8_0(v115216)
                        | US7_1(v115218) -> (* C2of2 *)
                            US8_1(v115218)
                    return v115221 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115229 : Async<US8> = _v115212 
            let _v115148 = v115229 
            #endif
            let v115230 : Async<US8> = _v115148 
            let v115250 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v115251 : Async<US6> = null |> unbox<Async<US6>>
            let _v115250 = v115251 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v115254 : Async<US6> = null |> unbox<Async<US6>>
            let _v115250 = v115254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v115257 : Async<US6> = null |> unbox<Async<US6>>
            let _v115250 = v115257 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v115260 : unit = ()
            let _v115260 =
                async {
                    let! v115230 = v115230 
                    let v115263 : US8 = v115230 
                    let v115387 : US6 =
                        match v115263 with
                        | US8_1(v115266) -> (* Error *)
                            let v115267 : string = $"%A{v115266}"
                            let v115270 : string = "System.TimeoutException"
                            let v115271 : bool = v115267.Contains v115270 
                            if v115271 then
                                let v115274 : unit = ()
                                let v115275 : (unit -> unit) = closure16(v0)
                                let v115276 : unit = (fun () -> v115275 (); v115274) ()
                                US6_1
                            else
                                let v115317 : unit = ()
                                let v115318 : (unit -> unit) = closure17(v0, v115266)
                                let v115319 : unit = (fun () -> v115318 (); v115317) ()
                                US6_1
                        | US8_0(v115264) -> (* Ok *)
                            US6_0(v115264)
                    return v115387 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115513 : Async<US6> = _v115260 
            let _v115250 = v115513 
            #endif
#if FABLE_COMPILER_PYTHON
            let v115514 : unit = ()
            let _v115514 =
                async {
                    let! v115230 = v115230 
                    let v115517 : US8 = v115230 
                    let v115641 : US6 =
                        match v115517 with
                        | US8_1(v115520) -> (* Error *)
                            let v115521 : string = $"%A{v115520}"
                            let v115524 : string = "System.TimeoutException"
                            let v115525 : bool = v115521.Contains v115524 
                            if v115525 then
                                let v115528 : unit = ()
                                let v115529 : (unit -> unit) = closure16(v0)
                                let v115530 : unit = (fun () -> v115529 (); v115528) ()
                                US6_1
                            else
                                let v115571 : unit = ()
                                let v115572 : (unit -> unit) = closure17(v0, v115520)
                                let v115573 : unit = (fun () -> v115572 (); v115571) ()
                                US6_1
                        | US8_0(v115518) -> (* Ok *)
                            US6_0(v115518)
                    return v115641 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v115767 : Async<US6> = _v115514 
            let _v115250 = v115767 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v115768 : unit = ()
            let _v115768 =
                async {
                    let! v115230 = v115230 
                    let v115771 : US8 = v115230 
                    let v115895 : US6 =
                        match v115771 with
                        | US8_1(v115774) -> (* Error *)
                            let v115775 : string = $"%A{v115774}"
                            let v115778 : string = "System.TimeoutException"
                            let v115779 : bool = v115775.Contains v115778 
                            if v115779 then
                                let v115782 : unit = ()
                                let v115783 : (unit -> unit) = closure16(v0)
                                let v115784 : unit = (fun () -> v115783 (); v115782) ()
                                US6_1
                            else
                                let v115825 : unit = ()
                                let v115826 : (unit -> unit) = closure17(v0, v115774)
                                let v115827 : unit = (fun () -> v115826 (); v115825) ()
                                US6_1
                        | US8_0(v115772) -> (* Ok *)
                            US6_0(v115772)
                    return v115895 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v116021 : Async<US6> = _v115768 
            let _v115250 = v116021 
            #endif
#else
            let v116022 : unit = ()
            let _v116022 =
                async {
                    let! v115230 = v115230 
                    let v116025 : US8 = v115230 
                    let v116149 : US6 =
                        match v116025 with
                        | US8_1(v116028) -> (* Error *)
                            let v116029 : string = $"%A{v116028}"
                            let v116032 : string = "System.TimeoutException"
                            let v116033 : bool = v116029.Contains v116032 
                            if v116033 then
                                let v116036 : unit = ()
                                let v116037 : (unit -> unit) = closure16(v0)
                                let v116038 : unit = (fun () -> v116037 (); v116036) ()
                                US6_1
                            else
                                let v116079 : unit = ()
                                let v116080 : (unit -> unit) = closure17(v0, v116028)
                                let v116081 : unit = (fun () -> v116080 (); v116079) ()
                                US6_1
                        | US8_0(v116026) -> (* Ok *)
                            US6_0(v116026)
                    return v116149 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v116275 : Async<US6> = _v116022 
            let _v115250 = v116275 
            #endif
            let v116276 : Async<US6> = _v115250 
            return! v116276 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v118268 : Async<US6> = _v114793 
    let _v104355 = v118268 
    #endif
    let v118269 : Async<US6> = _v104355 
    let _v2 = v118269 
    #endif
    let v121747 : Async<US6> = _v2 
    v121747
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
            let v16 : Async<bool> = method6(v1, v2)
            let v17 : Async<US6> = method21(v0, v16)
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
    let v28 : Async<bool> = _v13 
    let _v3 = v28 
    #endif
#if FABLE_COMPILER_PYTHON
    let v29 : unit = ()
    let _v29 =
        async {
            let v32 : Async<bool> = method6(v1, v2)
            let v33 : Async<US6> = method21(v0, v32)
            let! v33 = v33 
            let v34 : US6 = v33 
            let v37 : bool =
                match v34 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v35) -> (* Some *)
                    v35
            return v37 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v44 : Async<bool> = _v29 
    let _v3 = v44 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v45 : unit = ()
    let _v45 =
        async {
            let v48 : Async<bool> = method6(v1, v2)
            let v49 : Async<US6> = method21(v0, v48)
            let! v49 = v49 
            let v50 : US6 = v49 
            let v53 : bool =
                match v50 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v51) -> (* Some *)
                    v51
            return v53 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v60 : Async<bool> = _v45 
    let _v3 = v60 
    #endif
#else
    let v61 : unit = ()
    let _v61 =
        async {
            let v64 : Async<bool> = method6(v1, v2)
            let v65 : Async<US6> = method21(v0, v64)
            let! v65 = v65 
            let v66 : US6 = v65 
            let v69 : bool =
                match v66 with
                | US6_1 -> (* None *)
                    false
                | US6_0(v67) -> (* Some *)
                    v67
            return v69 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v76 : Async<bool> = _v61 
    let _v3 = v76 
    #endif
    let v77 : Async<bool> = _v3 
    v77
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
            let v18 : (int32 -> US9) = method31()
            let v19 : US9 option = v0 |> Option.map v18 
            let v30 : US9 = US9_1
            let v31 : US9 = v19 |> Option.defaultValue v30 
            let v39 : Async<bool> =
                match v31 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v36) -> (* Some *)
                    method20(v36, v2, v3)
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
                let v86 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v87 : (int32 -> Async<unit>) = Async.Sleep
                let v88 : Async<unit> = v87 10
                let _v86 = v88 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v89 : (int32 -> Async<unit>) = Async.Sleep
                let v90 : Async<unit> = v89 10
                let _v86 = v90 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v91 : (int32 -> Async<unit>) = Async.Sleep
                let v92 : Async<unit> = v91 10
                let _v86 = v92 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v93 : (int32 -> Async<unit>) = Async.Sleep
                let v94 : Async<unit> = v93 10
                let _v86 = v94 
                #endif
#if FABLE_COMPILER_PYTHON
                let v95 : (int32 -> Async<unit>) = Async.Sleep
                let v96 : Async<unit> = v95 10
                let _v86 = v96 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v97 : (int32 -> Async<unit>) = Async.Sleep
                let v98 : Async<unit> = v97 10
                let _v86 = v98 
                #endif
#else
                let v99 : (int32 -> Async<unit>) = Async.Sleep
                let v100 : Async<unit> = v99 10
                let _v86 = v100 
                #endif
                let v101 : Async<unit> = _v86 
                do! v101 
                let v106 : int64 = v4 + 1L
                let v107 : Async<int64> = method30(v0, v1, v2, v3, v106)
                return! v107 
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
    let v198 : Async<int64> = _v15 
    let _v5 = v198 
    #endif
#if FABLE_COMPILER_PYTHON
    let v199 : unit = ()
    let _v199 =
        async {
            let v202 : (int32 -> US9) = method31()
            let v203 : US9 option = v0 |> Option.map v202 
            let v214 : US9 = US9_1
            let v215 : US9 = v203 |> Option.defaultValue v214 
            let v223 : Async<bool> =
                match v215 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v220) -> (* Some *)
                    method20(v220, v2, v3)
            let! v223 = v223 
            let v224 : bool = v223 
            let v225 : bool = v224 = v1
            if v225 then
                return v4 
                (*
                ()
            else
                *) else
                let v226 : int64 = v4 % 100L
                let v227 : bool = v226 = 0L
                if v227 then
                    let v228 : unit = ()
                    let v229 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v230 : unit = (fun () -> v229 (); v228) ()
                    ()
                let v270 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v271 : (int32 -> Async<unit>) = Async.Sleep
                let v272 : Async<unit> = v271 10
                let _v270 = v272 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v273 : (int32 -> Async<unit>) = Async.Sleep
                let v274 : Async<unit> = v273 10
                let _v270 = v274 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v275 : (int32 -> Async<unit>) = Async.Sleep
                let v276 : Async<unit> = v275 10
                let _v270 = v276 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v277 : (int32 -> Async<unit>) = Async.Sleep
                let v278 : Async<unit> = v277 10
                let _v270 = v278 
                #endif
#if FABLE_COMPILER_PYTHON
                let v279 : (int32 -> Async<unit>) = Async.Sleep
                let v280 : Async<unit> = v279 10
                let _v270 = v280 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v281 : (int32 -> Async<unit>) = Async.Sleep
                let v282 : Async<unit> = v281 10
                let _v270 = v282 
                #endif
#else
                let v283 : (int32 -> Async<unit>) = Async.Sleep
                let v284 : Async<unit> = v283 10
                let _v270 = v284 
                #endif
                let v285 : Async<unit> = _v270 
                do! v285 
                let v290 : int64 = v4 + 1L
                let v291 : Async<int64> = method30(v0, v1, v2, v3, v290)
                return! v291 
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
    let v382 : Async<int64> = _v199 
    let _v5 = v382 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v383 : unit = ()
    let _v383 =
        async {
            let v386 : (int32 -> US9) = method31()
            let v387 : US9 option = v0 |> Option.map v386 
            let v398 : US9 = US9_1
            let v399 : US9 = v387 |> Option.defaultValue v398 
            let v407 : Async<bool> =
                match v399 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v404) -> (* Some *)
                    method20(v404, v2, v3)
            let! v407 = v407 
            let v408 : bool = v407 
            let v409 : bool = v408 = v1
            if v409 then
                return v4 
                (*
                ()
            else
                *) else
                let v410 : int64 = v4 % 100L
                let v411 : bool = v410 = 0L
                if v411 then
                    let v412 : unit = ()
                    let v413 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v414 : unit = (fun () -> v413 (); v412) ()
                    ()
                let v454 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v455 : (int32 -> Async<unit>) = Async.Sleep
                let v456 : Async<unit> = v455 10
                let _v454 = v456 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v457 : (int32 -> Async<unit>) = Async.Sleep
                let v458 : Async<unit> = v457 10
                let _v454 = v458 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v459 : (int32 -> Async<unit>) = Async.Sleep
                let v460 : Async<unit> = v459 10
                let _v454 = v460 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v461 : (int32 -> Async<unit>) = Async.Sleep
                let v462 : Async<unit> = v461 10
                let _v454 = v462 
                #endif
#if FABLE_COMPILER_PYTHON
                let v463 : (int32 -> Async<unit>) = Async.Sleep
                let v464 : Async<unit> = v463 10
                let _v454 = v464 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v465 : (int32 -> Async<unit>) = Async.Sleep
                let v466 : Async<unit> = v465 10
                let _v454 = v466 
                #endif
#else
                let v467 : (int32 -> Async<unit>) = Async.Sleep
                let v468 : Async<unit> = v467 10
                let _v454 = v468 
                #endif
                let v469 : Async<unit> = _v454 
                do! v469 
                let v474 : int64 = v4 + 1L
                let v475 : Async<int64> = method30(v0, v1, v2, v3, v474)
                return! v475 
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
    let v566 : Async<int64> = _v383 
    let _v5 = v566 
    #endif
#else
    let v567 : unit = ()
    let _v567 =
        async {
            let v570 : (int32 -> US9) = method31()
            let v571 : US9 option = v0 |> Option.map v570 
            let v582 : US9 = US9_1
            let v583 : US9 = v571 |> Option.defaultValue v582 
            let v591 : Async<bool> =
                match v583 with
                | US9_1 -> (* None *)
                    method6(v2, v3)
                | US9_0(v588) -> (* Some *)
                    method20(v588, v2, v3)
            let! v591 = v591 
            let v592 : bool = v591 
            let v593 : bool = v592 = v1
            if v593 then
                return v4 
                (*
                ()
            else
                *) else
                let v594 : int64 = v4 % 100L
                let v595 : bool = v594 = 0L
                if v595 then
                    let v596 : unit = ()
                    let v597 : (unit -> unit) = closure23(v0, v1, v3, v4)
                    let v598 : unit = (fun () -> v597 (); v596) ()
                    ()
                let v638 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v639 : (int32 -> Async<unit>) = Async.Sleep
                let v640 : Async<unit> = v639 10
                let _v638 = v640 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v641 : (int32 -> Async<unit>) = Async.Sleep
                let v642 : Async<unit> = v641 10
                let _v638 = v642 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v643 : (int32 -> Async<unit>) = Async.Sleep
                let v644 : Async<unit> = v643 10
                let _v638 = v644 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v645 : (int32 -> Async<unit>) = Async.Sleep
                let v646 : Async<unit> = v645 10
                let _v638 = v646 
                #endif
#if FABLE_COMPILER_PYTHON
                let v647 : (int32 -> Async<unit>) = Async.Sleep
                let v648 : Async<unit> = v647 10
                let _v638 = v648 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v649 : (int32 -> Async<unit>) = Async.Sleep
                let v650 : Async<unit> = v649 10
                let _v638 = v650 
                #endif
#else
                let v651 : (int32 -> Async<unit>) = Async.Sleep
                let v652 : Async<unit> = v651 10
                let _v638 = v652 
                #endif
                let v653 : Async<unit> = _v638 
                do! v653 
                let v658 : int64 = v4 + 1L
                let v659 : Async<int64> = method30(v0, v1, v2, v3, v658)
                return! v659 
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
    let v750 : Async<int64> = _v567 
    let _v5 = v750 
    #endif
    let v751 : Async<int64> = _v5 
    v751
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
            let v16 : (int32 -> US9) = method31()
            let v17 : US9 option = v0 |> Option.map v16 
            let v28 : US9 = US9_1
            let v29 : US9 = v17 |> Option.defaultValue v28 
            let v37 : Async<bool> =
                match v29 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v34) -> (* Some *)
                    method20(v34, v1, v2)
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
                let v41 : Async<int32> = method35(v0, v1, v40)
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
    let v68 : Async<int32> = _v13 
    let _v3 = v68 
    #endif
#if FABLE_COMPILER_PYTHON
    let v69 : unit = ()
    let _v69 =
        async {
            let v72 : (int32 -> US9) = method31()
            let v73 : US9 option = v0 |> Option.map v72 
            let v84 : US9 = US9_1
            let v85 : US9 = v73 |> Option.defaultValue v84 
            let v93 : Async<bool> =
                match v85 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v90) -> (* Some *)
                    method20(v90, v1, v2)
            let! v93 = v93 
            let v94 : bool = v93 
            let v95 : bool = v94 = false
            if v95 then
                return v2 
                (*
                ()
            else
                *) else
                let v96 : int32 = v2 + 1
                let v97 : Async<int32> = method35(v0, v1, v96)
                return! v97 
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
    let v124 : Async<int32> = _v69 
    let _v3 = v124 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v125 : unit = ()
    let _v125 =
        async {
            let v128 : (int32 -> US9) = method31()
            let v129 : US9 option = v0 |> Option.map v128 
            let v140 : US9 = US9_1
            let v141 : US9 = v129 |> Option.defaultValue v140 
            let v149 : Async<bool> =
                match v141 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v146) -> (* Some *)
                    method20(v146, v1, v2)
            let! v149 = v149 
            let v150 : bool = v149 
            let v151 : bool = v150 = false
            if v151 then
                return v2 
                (*
                ()
            else
                *) else
                let v152 : int32 = v2 + 1
                let v153 : Async<int32> = method35(v0, v1, v152)
                return! v153 
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
    let v180 : Async<int32> = _v125 
    let _v3 = v180 
    #endif
#else
    let v181 : unit = ()
    let _v181 =
        async {
            let v184 : (int32 -> US9) = method31()
            let v185 : US9 option = v0 |> Option.map v184 
            let v196 : US9 = US9_1
            let v197 : US9 = v185 |> Option.defaultValue v196 
            let v205 : Async<bool> =
                match v197 with
                | US9_1 -> (* None *)
                    method6(v1, v2)
                | US9_0(v202) -> (* Some *)
                    method20(v202, v1, v2)
            let! v205 = v205 
            let v206 : bool = v205 
            let v207 : bool = v206 = false
            if v207 then
                return v2 
                (*
                ()
            else
                *) else
                let v208 : int32 = v2 + 1
                let v209 : Async<int32> = method35(v0, v1, v208)
                return! v209 
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
    let v236 : Async<int32> = _v181 
    let _v3 = v236 
    #endif
    let v237 : Async<int32> = _v3 
    v237
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
