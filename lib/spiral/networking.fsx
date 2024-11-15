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
let rec method3 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US5 =
    US5_0(v0)
and method4 () : (string -> US5) =
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
    let v17 : US3 = US3_1
    let v18 : US4 = US4_2(v17)
    let v19 : string = $"env.get_environment_variable / target: {v18} / var: {v0}"
    let v20 : string = failwith<string> v19
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : US3 = US3_2
    let v22 : US4 = US4_2(v21)
    let v23 : string = $"env.get_environment_variable / target: {v22} / var: {v0}"
    let v24 : string = failwith<string> v23
    let _v1 = v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v25 : string = "process.env[$0] ?? \"\""
    let v26 : string = Fable.Core.JsInterop.emitJsExpr v0 v25 
    let _v1 = v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = "os"
    let v28 : IOsEnviron = Fable.Core.PyInterop.importAll v27 
    let v29 : string = "v28.environ"
    let v30 : obj = Fable.Core.PyInterop.emitPyExpr () v29 
    let v33 : string = "v30.get($0)"
    let v34 : string = Fable.Core.PyInterop.emitPyExpr v0 v33 
    let mutable _v34 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v37 : (string -> string option) = Option.ofObj
    let v38 : string option = v37 v34
    v38 
    #else
    Some v34 
    #endif
    |> fun x -> _v34 <- Some x
    let v39 : string option = match _v34 with Some x -> x | None -> failwith "optionm'.of_obj / _v34=None"
    let v42 : (string -> US5) = method4()
    let v43 : US5 option = v39 |> Option.map v42 
    let v54 : US5 = US5_1
    let v55 : US5 = v43 |> Option.defaultValue v54 
    let v62 : string =
        match v55 with
        | US5_1 -> (* None *)
            let v60 : string = ""
            v60
        | US5_0(v59) -> (* Some *)
            v59
    let _v1 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : US3 = US3_1
    let v64 : US4 = US4_0(v63)
    let v65 : string = $"env.get_environment_variable / target: {v64} / var: {v0}"
    let v66 : string = failwith<string> v65
    let _v1 = v66 
    #endif
#else
    let v67 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v68 : string = v67 v0
    let mutable _v68 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v69 : (string -> string option) = Option.ofObj
    let v70 : string option = v69 v68
    v70 
    #else
    Some v68 
    #endif
    |> fun x -> _v68 <- Some x
    let v71 : string option = match _v68 with Some x -> x | None -> failwith "optionm'.of_obj / _v68=None"
    let v74 : (string -> US5) = method4()
    let v75 : US5 option = v71 |> Option.map v74 
    let v86 : US5 = US5_1
    let v87 : US5 = v75 |> Option.defaultValue v86 
    let v94 : string =
        match v87 with
        | US5_1 -> (* None *)
            let v92 : string = ""
            v92
        | US5_0(v91) -> (* Some *)
            v91
    let _v1 = v94 
    #endif
    let v95 : string = _v1 
    v95
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
    let v8 : string = "env!(\"" + v6 + "\")"
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
    let v36 : string = "env!(\"" + v6 + "\")"
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
    let v64 : string = "env!(\"" + v6 + "\")"
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
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method8()
    let v8 : US2 option = v5 |> Option.map v7 
    let v19 : US2 = US2_1
    let v20 : US2 = v8 |> Option.defaultValue v19 
    let v116 : System.DateTime =
        match v20 with
        | US2_1 -> (* None *)
            let v100 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v101 : System.DateTime = System.DateTime.Now
            let _v100 = v101 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v102 : System.DateTime = System.DateTime.Now
            let _v100 = v102 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v103 : System.DateTime = null |> unbox<System.DateTime>
            let _v100 = v103 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v106 : System.DateTime = System.DateTime.Now
            let _v100 = v106 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107 : System.DateTime = System.DateTime.Now
            let _v100 = v107 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108 : System.DateTime = System.DateTime.Now
            let _v100 = v108 
            #endif
#else
            let v109 : System.DateTime = System.DateTime.Now
            let _v100 = v109 
            #endif
            let v110 : System.DateTime = _v100 
            v110
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
            let v77 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v78 : System.TimeSpan = v77 v76
            let v81 : (System.TimeSpan -> int32) = _.Hours
            let v82 : int32 = v81 v78
            let v85 : (System.TimeSpan -> int32) = _.Minutes
            let v86 : int32 = v85 v78
            let v89 : (System.TimeSpan -> int32) = _.Seconds
            let v90 : int32 = v89 v78
            let v93 : (System.TimeSpan -> int32) = _.Milliseconds
            let v94 : int32 = v93 v78
            let v97 : System.DateTime = System.DateTime (1, 1, 1, v82, v86, v90, v94)
            v97
    let v117 : string = method9()
    let v120 : (string -> string) = v116.ToString
    let v121 : string = v120 v117
    let _v6 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v124 : (int64 -> US2) = method8()
    let v125 : US2 option = v5 |> Option.map v124 
    let v136 : US2 = US2_1
    let v137 : US2 = v125 |> Option.defaultValue v136 
    let v233 : System.DateTime =
        match v137 with
        | US2_1 -> (* None *)
            let v217 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v218 : System.DateTime = System.DateTime.Now
            let _v217 = v218 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v219 : System.DateTime = System.DateTime.Now
            let _v217 = v219 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v220 : System.DateTime = null |> unbox<System.DateTime>
            let _v217 = v220 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v223 : System.DateTime = System.DateTime.Now
            let _v217 = v223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v224 : System.DateTime = System.DateTime.Now
            let _v217 = v224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v225 : System.DateTime = System.DateTime.Now
            let _v217 = v225 
            #endif
#else
            let v226 : System.DateTime = System.DateTime.Now
            let _v217 = v226 
            #endif
            let v227 : System.DateTime = _v217 
            v227
        | US2_0(v141) -> (* Some *)
            let v142 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v143 : System.DateTime = System.DateTime.Now
            let _v142 = v143 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v144 : System.DateTime = System.DateTime.Now
            let _v142 = v144 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v145 : System.DateTime = null |> unbox<System.DateTime>
            let _v142 = v145 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v148 : System.DateTime = System.DateTime.Now
            let _v142 = v148 
            #endif
#if FABLE_COMPILER_PYTHON
            let v149 : System.DateTime = System.DateTime.Now
            let _v142 = v149 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v150 : System.DateTime = System.DateTime.Now
            let _v142 = v150 
            #endif
#else
            let v151 : System.DateTime = System.DateTime.Now
            let _v142 = v151 
            #endif
            let v152 : System.DateTime = _v142 
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : (System.DateTime -> int64) = _.Ticks
            let v159 : int64 = v158 v152
            let _v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v160 : (System.DateTime -> int64) = _.Ticks
            let v161 : int64 = v160 v152
            let _v157 = v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v162 : int64 = null |> unbox<int64>
            let _v157 = v162 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v152
            let _v157 = v166 
            #endif
#if FABLE_COMPILER_PYTHON
            let v167 : (System.DateTime -> int64) = _.Ticks
            let v168 : int64 = v167 v152
            let _v157 = v168 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v169 : (System.DateTime -> int64) = _.Ticks
            let v170 : int64 = v169 v152
            let _v157 = v170 
            #endif
#else
            let v171 : (System.DateTime -> int64) = _.Ticks
            let v172 : int64 = v171 v152
            let _v157 = v172 
            #endif
            let v173 : int64 = _v157 
            let v190 : int64 = v173 |> int64 
            let v193 : int64 = v190 - v141
            let v194 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v195 : System.TimeSpan = v194 v193
            let v198 : (System.TimeSpan -> int32) = _.Hours
            let v199 : int32 = v198 v195
            let v202 : (System.TimeSpan -> int32) = _.Minutes
            let v203 : int32 = v202 v195
            let v206 : (System.TimeSpan -> int32) = _.Seconds
            let v207 : int32 = v206 v195
            let v210 : (System.TimeSpan -> int32) = _.Milliseconds
            let v211 : int32 = v210 v195
            let v214 : System.DateTime = System.DateTime (1, 1, 1, v199, v203, v207, v211)
            v214
    let v234 : string = method9()
    let v237 : (string -> string) = v233.ToString
    let v238 : string = v237 v234
    let _v6 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v241 : string = $"near_sdk::env::block_timestamp()"
    let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : (int64 -> US2) = method8()
    let v244 : US2 option = v5 |> Option.map v243 
    let v255 : US2 = US2_1
    let v256 : US2 = v244 |> Option.defaultValue v255 
    let v267 : uint64 =
        match v256 with
        | US2_1 -> (* None *)
            v242
        | US2_0(v260) -> (* Some *)
            let v261 : (int64 -> uint64) = uint64
            let v262 : uint64 = v261 v260
            let v265 : uint64 = v242 - v262
            v265
    let v268 : uint64 = v267 / 1000000000UL
    let v269 : uint64 = v268 % 60UL
    let v270 : uint64 = v268 / 60UL
    let v271 : uint64 = v270 % 60UL
    let v272 : uint64 = v268 / 3600UL
    let v273 : uint64 = v272 % 24UL
    let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _v6 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v278 : (int64 -> US2) = method8()
    let v279 : US2 option = v5 |> Option.map v278 
    let v290 : US2 = US2_1
    let v291 : US2 = v279 |> Option.defaultValue v290 
    let v387 : System.DateTime =
        match v291 with
        | US2_1 -> (* None *)
            let v371 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v372 : System.DateTime = System.DateTime.Now
            let _v371 = v372 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v373 : System.DateTime = System.DateTime.Now
            let _v371 = v373 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v374 : System.DateTime = null |> unbox<System.DateTime>
            let _v371 = v374 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v377 : System.DateTime = System.DateTime.Now
            let _v371 = v377 
            #endif
#if FABLE_COMPILER_PYTHON
            let v378 : System.DateTime = System.DateTime.Now
            let _v371 = v378 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v379 : System.DateTime = System.DateTime.Now
            let _v371 = v379 
            #endif
#else
            let v380 : System.DateTime = System.DateTime.Now
            let _v371 = v380 
            #endif
            let v381 : System.DateTime = _v371 
            v381
        | US2_0(v295) -> (* Some *)
            let v296 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v297 : System.DateTime = System.DateTime.Now
            let _v296 = v297 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v298 : System.DateTime = System.DateTime.Now
            let _v296 = v298 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v299 : System.DateTime = null |> unbox<System.DateTime>
            let _v296 = v299 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v302 : System.DateTime = System.DateTime.Now
            let _v296 = v302 
            #endif
#if FABLE_COMPILER_PYTHON
            let v303 : System.DateTime = System.DateTime.Now
            let _v296 = v303 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v304 : System.DateTime = System.DateTime.Now
            let _v296 = v304 
            #endif
#else
            let v305 : System.DateTime = System.DateTime.Now
            let _v296 = v305 
            #endif
            let v306 : System.DateTime = _v296 
            let v311 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v306
            let _v311 = v313 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v314 : (System.DateTime -> int64) = _.Ticks
            let v315 : int64 = v314 v306
            let _v311 = v315 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v316 : int64 = null |> unbox<int64>
            let _v311 = v316 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v319 : (System.DateTime -> int64) = _.Ticks
            let v320 : int64 = v319 v306
            let _v311 = v320 
            #endif
#if FABLE_COMPILER_PYTHON
            let v321 : (System.DateTime -> int64) = _.Ticks
            let v322 : int64 = v321 v306
            let _v311 = v322 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v323 : (System.DateTime -> int64) = _.Ticks
            let v324 : int64 = v323 v306
            let _v311 = v324 
            #endif
#else
            let v325 : (System.DateTime -> int64) = _.Ticks
            let v326 : int64 = v325 v306
            let _v311 = v326 
            #endif
            let v327 : int64 = _v311 
            let v344 : int64 = v327 |> int64 
            let v347 : int64 = v344 - v295
            let v348 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v349 : System.TimeSpan = v348 v347
            let v352 : (System.TimeSpan -> int32) = _.Hours
            let v353 : int32 = v352 v349
            let v356 : (System.TimeSpan -> int32) = _.Minutes
            let v357 : int32 = v356 v349
            let v360 : (System.TimeSpan -> int32) = _.Seconds
            let v361 : int32 = v360 v349
            let v364 : (System.TimeSpan -> int32) = _.Milliseconds
            let v365 : int32 = v364 v349
            let v368 : System.DateTime = System.DateTime (1, 1, 1, v353, v357, v361, v365)
            v368
    let v388 : string = method10()
    let v391 : (string -> string) = v387.ToString
    let v392 : string = v391 v388
    let _v6 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v395 : (int64 -> US2) = method8()
    let v396 : US2 option = v5 |> Option.map v395 
    let v407 : US2 = US2_1
    let v408 : US2 = v396 |> Option.defaultValue v407 
    let v504 : System.DateTime =
        match v408 with
        | US2_1 -> (* None *)
            let v488 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v489 : System.DateTime = System.DateTime.Now
            let _v488 = v489 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v490 : System.DateTime = System.DateTime.Now
            let _v488 = v490 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v491 : System.DateTime = null |> unbox<System.DateTime>
            let _v488 = v491 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v494 : System.DateTime = System.DateTime.Now
            let _v488 = v494 
            #endif
#if FABLE_COMPILER_PYTHON
            let v495 : System.DateTime = System.DateTime.Now
            let _v488 = v495 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v496 : System.DateTime = System.DateTime.Now
            let _v488 = v496 
            #endif
#else
            let v497 : System.DateTime = System.DateTime.Now
            let _v488 = v497 
            #endif
            let v498 : System.DateTime = _v488 
            v498
        | US2_0(v412) -> (* Some *)
            let v413 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v414 : System.DateTime = System.DateTime.Now
            let _v413 = v414 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : System.DateTime = System.DateTime.Now
            let _v413 = v415 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v416 : System.DateTime = null |> unbox<System.DateTime>
            let _v413 = v416 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v419 : System.DateTime = System.DateTime.Now
            let _v413 = v419 
            #endif
#if FABLE_COMPILER_PYTHON
            let v420 : System.DateTime = System.DateTime.Now
            let _v413 = v420 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v421 : System.DateTime = System.DateTime.Now
            let _v413 = v421 
            #endif
#else
            let v422 : System.DateTime = System.DateTime.Now
            let _v413 = v422 
            #endif
            let v423 : System.DateTime = _v413 
            let v428 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v429 : (System.DateTime -> int64) = _.Ticks
            let v430 : int64 = v429 v423
            let _v428 = v430 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v431 : (System.DateTime -> int64) = _.Ticks
            let v432 : int64 = v431 v423
            let _v428 = v432 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v433 : int64 = null |> unbox<int64>
            let _v428 = v433 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v436 : (System.DateTime -> int64) = _.Ticks
            let v437 : int64 = v436 v423
            let _v428 = v437 
            #endif
#if FABLE_COMPILER_PYTHON
            let v438 : (System.DateTime -> int64) = _.Ticks
            let v439 : int64 = v438 v423
            let _v428 = v439 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v423
            let _v428 = v441 
            #endif
#else
            let v442 : (System.DateTime -> int64) = _.Ticks
            let v443 : int64 = v442 v423
            let _v428 = v443 
            #endif
            let v444 : int64 = _v428 
            let v461 : int64 = v444 |> int64 
            let v464 : int64 = v461 - v412
            let v465 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v466 : System.TimeSpan = v465 v464
            let v469 : (System.TimeSpan -> int32) = _.Hours
            let v470 : int32 = v469 v466
            let v473 : (System.TimeSpan -> int32) = _.Minutes
            let v474 : int32 = v473 v466
            let v477 : (System.TimeSpan -> int32) = _.Seconds
            let v478 : int32 = v477 v466
            let v481 : (System.TimeSpan -> int32) = _.Milliseconds
            let v482 : int32 = v481 v466
            let v485 : System.DateTime = System.DateTime (1, 1, 1, v470, v474, v478, v482)
            v485
    let v505 : string = method10()
    let v508 : (string -> string) = v504.ToString
    let v509 : string = v508 v505
    let _v6 = v509 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v512 : (int64 -> US2) = method8()
    let v513 : US2 option = v5 |> Option.map v512 
    let v524 : US2 = US2_1
    let v525 : US2 = v513 |> Option.defaultValue v524 
    let v621 : System.DateTime =
        match v525 with
        | US2_1 -> (* None *)
            let v605 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v606 : System.DateTime = System.DateTime.Now
            let _v605 = v606 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v607 : System.DateTime = System.DateTime.Now
            let _v605 = v607 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v608 : System.DateTime = null |> unbox<System.DateTime>
            let _v605 = v608 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v611 : System.DateTime = System.DateTime.Now
            let _v605 = v611 
            #endif
#if FABLE_COMPILER_PYTHON
            let v612 : System.DateTime = System.DateTime.Now
            let _v605 = v612 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v613 : System.DateTime = System.DateTime.Now
            let _v605 = v613 
            #endif
#else
            let v614 : System.DateTime = System.DateTime.Now
            let _v605 = v614 
            #endif
            let v615 : System.DateTime = _v605 
            v615
        | US2_0(v529) -> (* Some *)
            let v530 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v531 : System.DateTime = System.DateTime.Now
            let _v530 = v531 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v532 : System.DateTime = System.DateTime.Now
            let _v530 = v532 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v533 : System.DateTime = null |> unbox<System.DateTime>
            let _v530 = v533 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v536 : System.DateTime = System.DateTime.Now
            let _v530 = v536 
            #endif
#if FABLE_COMPILER_PYTHON
            let v537 : System.DateTime = System.DateTime.Now
            let _v530 = v537 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v538 : System.DateTime = System.DateTime.Now
            let _v530 = v538 
            #endif
#else
            let v539 : System.DateTime = System.DateTime.Now
            let _v530 = v539 
            #endif
            let v540 : System.DateTime = _v530 
            let v545 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v546 : (System.DateTime -> int64) = _.Ticks
            let v547 : int64 = v546 v540
            let _v545 = v547 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v548 : (System.DateTime -> int64) = _.Ticks
            let v549 : int64 = v548 v540
            let _v545 = v549 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v550 : int64 = null |> unbox<int64>
            let _v545 = v550 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v553 : (System.DateTime -> int64) = _.Ticks
            let v554 : int64 = v553 v540
            let _v545 = v554 
            #endif
#if FABLE_COMPILER_PYTHON
            let v555 : (System.DateTime -> int64) = _.Ticks
            let v556 : int64 = v555 v540
            let _v545 = v556 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v557 : (System.DateTime -> int64) = _.Ticks
            let v558 : int64 = v557 v540
            let _v545 = v558 
            #endif
#else
            let v559 : (System.DateTime -> int64) = _.Ticks
            let v560 : int64 = v559 v540
            let _v545 = v560 
            #endif
            let v561 : int64 = _v545 
            let v578 : int64 = v561 |> int64 
            let v581 : int64 = v578 - v529
            let v582 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v583 : System.TimeSpan = v582 v581
            let v586 : (System.TimeSpan -> int32) = _.Hours
            let v587 : int32 = v586 v583
            let v590 : (System.TimeSpan -> int32) = _.Minutes
            let v591 : int32 = v590 v583
            let v594 : (System.TimeSpan -> int32) = _.Seconds
            let v595 : int32 = v594 v583
            let v598 : (System.TimeSpan -> int32) = _.Milliseconds
            let v599 : int32 = v598 v583
            let v602 : System.DateTime = System.DateTime (1, 1, 1, v587, v591, v595, v599)
            v602
    let v622 : string = method10()
    let v625 : (string -> string) = v621.ToString
    let v626 : string = v625 v622
    let _v6 = v626 
    #endif
#else
    let v629 : (int64 -> US2) = method8()
    let v630 : US2 option = v5 |> Option.map v629 
    let v641 : US2 = US2_1
    let v642 : US2 = v630 |> Option.defaultValue v641 
    let v738 : System.DateTime =
        match v642 with
        | US2_1 -> (* None *)
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
            v732
        | US2_0(v646) -> (* Some *)
            let v647 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v648 : System.DateTime = System.DateTime.Now
            let _v647 = v648 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v649 : System.DateTime = System.DateTime.Now
            let _v647 = v649 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v650 : System.DateTime = null |> unbox<System.DateTime>
            let _v647 = v650 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v653 : System.DateTime = System.DateTime.Now
            let _v647 = v653 
            #endif
#if FABLE_COMPILER_PYTHON
            let v654 : System.DateTime = System.DateTime.Now
            let _v647 = v654 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v655 : System.DateTime = System.DateTime.Now
            let _v647 = v655 
            #endif
#else
            let v656 : System.DateTime = System.DateTime.Now
            let _v647 = v656 
            #endif
            let v657 : System.DateTime = _v647 
            let v662 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v663 : (System.DateTime -> int64) = _.Ticks
            let v664 : int64 = v663 v657
            let _v662 = v664 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v665 : (System.DateTime -> int64) = _.Ticks
            let v666 : int64 = v665 v657
            let _v662 = v666 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v667 : int64 = null |> unbox<int64>
            let _v662 = v667 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v670 : (System.DateTime -> int64) = _.Ticks
            let v671 : int64 = v670 v657
            let _v662 = v671 
            #endif
#if FABLE_COMPILER_PYTHON
            let v672 : (System.DateTime -> int64) = _.Ticks
            let v673 : int64 = v672 v657
            let _v662 = v673 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v674 : (System.DateTime -> int64) = _.Ticks
            let v675 : int64 = v674 v657
            let _v662 = v675 
            #endif
#else
            let v676 : (System.DateTime -> int64) = _.Ticks
            let v677 : int64 = v676 v657
            let _v662 = v677 
            #endif
            let v678 : int64 = _v662 
            let v695 : int64 = v678 |> int64 
            let v698 : int64 = v695 - v646
            let v699 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v700 : System.TimeSpan = v699 v698
            let v703 : (System.TimeSpan -> int32) = _.Hours
            let v704 : int32 = v703 v700
            let v707 : (System.TimeSpan -> int32) = _.Minutes
            let v708 : int32 = v707 v700
            let v711 : (System.TimeSpan -> int32) = _.Seconds
            let v712 : int32 = v711 v700
            let v715 : (System.TimeSpan -> int32) = _.Milliseconds
            let v716 : int32 = v715 v700
            let v719 : System.DateTime = System.DateTime (1, 1, 1, v704, v708, v712, v716)
            v719
    let v739 : string = method10()
    let v742 : (string -> string) = v738.ToString
    let v743 : string = v742 v739
    let _v6 = v743 
    #endif
    let v746 : string = _v6 
    v746
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
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method16 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
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
and method17 (v0 : string) : string =
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
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method16(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "networking.test_port_open"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
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
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method11()
        let v40 : string = method15(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method18(v40)
and method5 (v0 : string, v1 : int32) : Async<bool> =
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
    method5(v0, v1)
and closure3 () (v0 : string) : (int32 -> Async<bool>) =
    closure4(v0)
and closure14 () (v0 : bool) : US7 =
    US7_0(v0)
and method21 () : (bool -> US7) =
    closure14()
and closure15 () (v0 : exn) : US7 =
    US7_1(v0)
and method22 () : (exn -> US7) =
    closure15()
and method24 (v0 : int32) : string =
    let v1 : string = method13()
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
and method23 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32) : string =
    let v9 : string = method24(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "async.run_with_timeout_async"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure16 (v0 : int32) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = method23(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method25 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method27 (v0 : int32, v1 : string) : string =
    let v2 : string = method13()
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
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : string) : string =
    let v10 : string = method27(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "async.run_with_timeout_async**"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure17 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_4
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method25()
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
        let v65 : string = method26(v20, v21, v22, v23, v24, v25, v38, v39, v0, v60)
        method18(v65)
and method20 (v0 : int32, v1 : Async<bool>) : Async<US6> =
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
            let v15 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v15 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v16 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v17 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v18 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v19 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v20 
            #endif
#else
            let v21 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14 = v21 
            #endif
            let v22 : Async<Async<bool>> = _v14 
            let! v22 = v22 
            let v27 : Async<bool> = v22 
            let v28 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v29 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v30 : Async<Choice<bool, exn>> = v29 v27
            let _v28 = v30 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v31 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v32 : Async<Choice<bool, exn>> = v31 v27
            let _v28 = v32 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v33 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v34 : Async<Choice<bool, exn>> = v33 v27
            let _v28 = v34 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v35 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v36 : Async<Choice<bool, exn>> = v35 v27
            let _v28 = v36 
            #endif
#if FABLE_COMPILER_PYTHON
            let v37 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v38 : Async<Choice<bool, exn>> = v37 v27
            let _v28 = v38 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v39 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v40 : Async<Choice<bool, exn>> = v39 v27
            let _v28 = v40 
            #endif
#else
            let v41 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v42 : Async<Choice<bool, exn>> = v41 v27
            let _v28 = v42 
            #endif
            let v43 : Async<Choice<bool, exn>> = _v28 
            let v48 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v49 : Async<US7> = null |> unbox<Async<US7>>
            let _v48 = v49 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52 : Async<US7> = null |> unbox<Async<US7>>
            let _v48 = v52 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v55 : Async<US7> = null |> unbox<Async<US7>>
            let _v48 = v55 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v58 : unit = ()
            let _v58 =
                async {
                    let! v43 = v43 
                    let v59 : Choice<bool, exn> = v43 
                    let v60 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v61 : US7 = null |> unbox<US7>
                    let _v60 = v61 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v64 : US7 = null |> unbox<US7>
                    let _v60 = v64 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v67 : US7 = null |> unbox<US7>
                    let _v60 = v67 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v70 : US7 = null |> unbox<US7>
                    let _v60 = v70 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v73 : US7 = null |> unbox<US7>
                    let _v60 = v73 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v76 : (bool -> US7) = method21()
                    let v77 : (exn -> US7) = method22()
                    let v78 : US7 = match v59 with Choice1Of2 x -> v76 x | Choice2Of2 x -> v77 x
                    let _v60 = v78 
                    #endif
#else
                    let v79 : (bool -> US7) = method21()
                    let v80 : (exn -> US7) = method22()
                    let v81 : US7 = match v59 with Choice1Of2 x -> v79 x | Choice2Of2 x -> v80 x
                    let _v60 = v81 
                    #endif
                    let v82 : US7 = _v60 
                    return v82 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v87 : Async<US7> = _v58 
            let _v48 = v87 
            #endif
#if FABLE_COMPILER_PYTHON
            let v88 : unit = ()
            let _v88 =
                async {
                    let! v43 = v43 
                    let v89 : Choice<bool, exn> = v43 
                    let v90 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v91 : US7 = null |> unbox<US7>
                    let _v90 = v91 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v94 : US7 = null |> unbox<US7>
                    let _v90 = v94 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v97 : US7 = null |> unbox<US7>
                    let _v90 = v97 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v100 : US7 = null |> unbox<US7>
                    let _v90 = v100 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v103 : US7 = null |> unbox<US7>
                    let _v90 = v103 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v106 : (bool -> US7) = method21()
                    let v107 : (exn -> US7) = method22()
                    let v108 : US7 = match v89 with Choice1Of2 x -> v106 x | Choice2Of2 x -> v107 x
                    let _v90 = v108 
                    #endif
#else
                    let v109 : (bool -> US7) = method21()
                    let v110 : (exn -> US7) = method22()
                    let v111 : US7 = match v89 with Choice1Of2 x -> v109 x | Choice2Of2 x -> v110 x
                    let _v90 = v111 
                    #endif
                    let v112 : US7 = _v90 
                    return v112 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v117 : Async<US7> = _v88 
            let _v48 = v117 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v118 : unit = ()
            let _v118 =
                async {
                    let! v43 = v43 
                    let v119 : Choice<bool, exn> = v43 
                    let v120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v121 : US7 = null |> unbox<US7>
                    let _v120 = v121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v124 : US7 = null |> unbox<US7>
                    let _v120 = v124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v127 : US7 = null |> unbox<US7>
                    let _v120 = v127 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v130 : US7 = null |> unbox<US7>
                    let _v120 = v130 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v133 : US7 = null |> unbox<US7>
                    let _v120 = v133 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v136 : (bool -> US7) = method21()
                    let v137 : (exn -> US7) = method22()
                    let v138 : US7 = match v119 with Choice1Of2 x -> v136 x | Choice2Of2 x -> v137 x
                    let _v120 = v138 
                    #endif
#else
                    let v139 : (bool -> US7) = method21()
                    let v140 : (exn -> US7) = method22()
                    let v141 : US7 = match v119 with Choice1Of2 x -> v139 x | Choice2Of2 x -> v140 x
                    let _v120 = v141 
                    #endif
                    let v142 : US7 = _v120 
                    return v142 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v147 : Async<US7> = _v118 
            let _v48 = v147 
            #endif
#else
            let v148 : unit = ()
            let _v148 =
                async {
                    let! v43 = v43 
                    let v149 : Choice<bool, exn> = v43 
                    let v150 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v151 : US7 = null |> unbox<US7>
                    let _v150 = v151 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v154 : US7 = null |> unbox<US7>
                    let _v150 = v154 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v157 : US7 = null |> unbox<US7>
                    let _v150 = v157 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v160 : US7 = null |> unbox<US7>
                    let _v150 = v160 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v163 : US7 = null |> unbox<US7>
                    let _v150 = v163 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v166 : (bool -> US7) = method21()
                    let v167 : (exn -> US7) = method22()
                    let v168 : US7 = match v149 with Choice1Of2 x -> v166 x | Choice2Of2 x -> v167 x
                    let _v150 = v168 
                    #endif
#else
                    let v169 : (bool -> US7) = method21()
                    let v170 : (exn -> US7) = method22()
                    let v171 : US7 = match v149 with Choice1Of2 x -> v169 x | Choice2Of2 x -> v170 x
                    let _v150 = v171 
                    #endif
                    let v172 : US7 = _v150 
                    return v172 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v177 : Async<US7> = _v148 
            let _v48 = v177 
            #endif
            let v178 : Async<US7> = _v48 
            let v183 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v184 : Async<US8> = null |> unbox<Async<US8>>
            let _v183 = v184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v187 : Async<US8> = null |> unbox<Async<US8>>
            let _v183 = v187 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v190 : Async<US8> = null |> unbox<Async<US8>>
            let _v183 = v190 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v193 : unit = ()
            let _v193 =
                async {
                    let! v178 = v178 
                    let v194 : US7 = v178 
                    let v200 : US8 =
                        match v194 with
                        | US7_0(v195) -> (* C1of2 *)
                            US8_0(v195)
                        | US7_1(v197) -> (* C2of2 *)
                            US8_1(v197)
                    return v200 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v201 : Async<US8> = _v193 
            let _v183 = v201 
            #endif
#if FABLE_COMPILER_PYTHON
            let v202 : unit = ()
            let _v202 =
                async {
                    let! v178 = v178 
                    let v203 : US7 = v178 
                    let v209 : US8 =
                        match v203 with
                        | US7_0(v204) -> (* C1of2 *)
                            US8_0(v204)
                        | US7_1(v206) -> (* C2of2 *)
                            US8_1(v206)
                    return v209 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v210 : Async<US8> = _v202 
            let _v183 = v210 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v211 : unit = ()
            let _v211 =
                async {
                    let! v178 = v178 
                    let v212 : US7 = v178 
                    let v218 : US8 =
                        match v212 with
                        | US7_0(v213) -> (* C1of2 *)
                            US8_0(v213)
                        | US7_1(v215) -> (* C2of2 *)
                            US8_1(v215)
                    return v218 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v219 : Async<US8> = _v211 
            let _v183 = v219 
            #endif
#else
            let v220 : unit = ()
            let _v220 =
                async {
                    let! v178 = v178 
                    let v221 : US7 = v178 
                    let v227 : US8 =
                        match v221 with
                        | US7_0(v222) -> (* C1of2 *)
                            US8_0(v222)
                        | US7_1(v224) -> (* C2of2 *)
                            US8_1(v224)
                    return v227 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v228 : Async<US8> = _v220 
            let _v183 = v228 
            #endif
            let v229 : Async<US8> = _v183 
            let v234 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v235 : Async<US6> = null |> unbox<Async<US6>>
            let _v234 = v235 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v238 : Async<US6> = null |> unbox<Async<US6>>
            let _v234 = v238 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v241 : Async<US6> = null |> unbox<Async<US6>>
            let _v234 = v241 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v244 : unit = ()
            let _v244 =
                async {
                    let! v229 = v229 
                    let v245 : US8 = v229 
                    let v369 : US6 =
                        match v245 with
                        | US8_1(v248) -> (* Error *)
                            let v249 : string = $"%A{v248}"
                            let v252 : string = "System.TimeoutException"
                            let v253 : bool = v249.Contains v252 
                            if v253 then
                                let v256 : unit = ()
                                let v257 : (unit -> unit) = closure16(v0)
                                let v258 : unit = (fun () -> v257 (); v256) ()
                                US6_1
                            else
                                let v299 : unit = ()
                                let v300 : (unit -> unit) = closure17(v0, v248)
                                let v301 : unit = (fun () -> v300 (); v299) ()
                                US6_1
                        | US8_0(v246) -> (* Ok *)
                            US6_0(v246)
                    return v369 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v370 : Async<US6> = _v244 
            let _v234 = v370 
            #endif
#if FABLE_COMPILER_PYTHON
            let v371 : unit = ()
            let _v371 =
                async {
                    let! v229 = v229 
                    let v372 : US8 = v229 
                    let v496 : US6 =
                        match v372 with
                        | US8_1(v375) -> (* Error *)
                            let v376 : string = $"%A{v375}"
                            let v379 : string = "System.TimeoutException"
                            let v380 : bool = v376.Contains v379 
                            if v380 then
                                let v383 : unit = ()
                                let v384 : (unit -> unit) = closure16(v0)
                                let v385 : unit = (fun () -> v384 (); v383) ()
                                US6_1
                            else
                                let v426 : unit = ()
                                let v427 : (unit -> unit) = closure17(v0, v375)
                                let v428 : unit = (fun () -> v427 (); v426) ()
                                US6_1
                        | US8_0(v373) -> (* Ok *)
                            US6_0(v373)
                    return v496 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v497 : Async<US6> = _v371 
            let _v234 = v497 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v498 : unit = ()
            let _v498 =
                async {
                    let! v229 = v229 
                    let v499 : US8 = v229 
                    let v623 : US6 =
                        match v499 with
                        | US8_1(v502) -> (* Error *)
                            let v503 : string = $"%A{v502}"
                            let v506 : string = "System.TimeoutException"
                            let v507 : bool = v503.Contains v506 
                            if v507 then
                                let v510 : unit = ()
                                let v511 : (unit -> unit) = closure16(v0)
                                let v512 : unit = (fun () -> v511 (); v510) ()
                                US6_1
                            else
                                let v553 : unit = ()
                                let v554 : (unit -> unit) = closure17(v0, v502)
                                let v555 : unit = (fun () -> v554 (); v553) ()
                                US6_1
                        | US8_0(v500) -> (* Ok *)
                            US6_0(v500)
                    return v623 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v624 : Async<US6> = _v498 
            let _v234 = v624 
            #endif
#else
            let v625 : unit = ()
            let _v625 =
                async {
                    let! v229 = v229 
                    let v626 : US8 = v229 
                    let v750 : US6 =
                        match v626 with
                        | US8_1(v629) -> (* Error *)
                            let v630 : string = $"%A{v629}"
                            let v633 : string = "System.TimeoutException"
                            let v634 : bool = v630.Contains v633 
                            if v634 then
                                let v637 : unit = ()
                                let v638 : (unit -> unit) = closure16(v0)
                                let v639 : unit = (fun () -> v638 (); v637) ()
                                US6_1
                            else
                                let v680 : unit = ()
                                let v681 : (unit -> unit) = closure17(v0, v629)
                                let v682 : unit = (fun () -> v681 (); v680) ()
                                US6_1
                        | US8_0(v627) -> (* Ok *)
                            US6_0(v627)
                    return v750 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v751 : Async<US6> = _v625 
            let _v234 = v751 
            #endif
            let v752 : Async<US6> = _v234 
            return! v752 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v757 : Async<US6> = _v13 
    let _v3 = v757 
    #endif
#if FABLE_COMPILER_PYTHON
    let v758 : unit = ()
    let _v758 =
        async {
            let v759 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v760 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v760 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v761 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v761 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v762 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v762 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v763 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v763 
            #endif
#if FABLE_COMPILER_PYTHON
            let v764 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v764 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v765 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v765 
            #endif
#else
            let v766 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v759 = v766 
            #endif
            let v767 : Async<Async<bool>> = _v759 
            let! v767 = v767 
            let v772 : Async<bool> = v767 
            let v773 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v774 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v775 : Async<Choice<bool, exn>> = v774 v772
            let _v773 = v775 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v776 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v777 : Async<Choice<bool, exn>> = v776 v772
            let _v773 = v777 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v778 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v779 : Async<Choice<bool, exn>> = v778 v772
            let _v773 = v779 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v780 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v781 : Async<Choice<bool, exn>> = v780 v772
            let _v773 = v781 
            #endif
#if FABLE_COMPILER_PYTHON
            let v782 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v783 : Async<Choice<bool, exn>> = v782 v772
            let _v773 = v783 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v784 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v785 : Async<Choice<bool, exn>> = v784 v772
            let _v773 = v785 
            #endif
#else
            let v786 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v787 : Async<Choice<bool, exn>> = v786 v772
            let _v773 = v787 
            #endif
            let v788 : Async<Choice<bool, exn>> = _v773 
            let v793 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v794 : Async<US7> = null |> unbox<Async<US7>>
            let _v793 = v794 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v797 : Async<US7> = null |> unbox<Async<US7>>
            let _v793 = v797 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v800 : Async<US7> = null |> unbox<Async<US7>>
            let _v793 = v800 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v803 : unit = ()
            let _v803 =
                async {
                    let! v788 = v788 
                    let v804 : Choice<bool, exn> = v788 
                    let v805 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v806 : US7 = null |> unbox<US7>
                    let _v805 = v806 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v809 : US7 = null |> unbox<US7>
                    let _v805 = v809 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v812 : US7 = null |> unbox<US7>
                    let _v805 = v812 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v815 : US7 = null |> unbox<US7>
                    let _v805 = v815 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v818 : US7 = null |> unbox<US7>
                    let _v805 = v818 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v821 : (bool -> US7) = method21()
                    let v822 : (exn -> US7) = method22()
                    let v823 : US7 = match v804 with Choice1Of2 x -> v821 x | Choice2Of2 x -> v822 x
                    let _v805 = v823 
                    #endif
#else
                    let v824 : (bool -> US7) = method21()
                    let v825 : (exn -> US7) = method22()
                    let v826 : US7 = match v804 with Choice1Of2 x -> v824 x | Choice2Of2 x -> v825 x
                    let _v805 = v826 
                    #endif
                    let v827 : US7 = _v805 
                    return v827 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v832 : Async<US7> = _v803 
            let _v793 = v832 
            #endif
#if FABLE_COMPILER_PYTHON
            let v833 : unit = ()
            let _v833 =
                async {
                    let! v788 = v788 
                    let v834 : Choice<bool, exn> = v788 
                    let v835 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v836 : US7 = null |> unbox<US7>
                    let _v835 = v836 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v839 : US7 = null |> unbox<US7>
                    let _v835 = v839 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v842 : US7 = null |> unbox<US7>
                    let _v835 = v842 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v845 : US7 = null |> unbox<US7>
                    let _v835 = v845 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v848 : US7 = null |> unbox<US7>
                    let _v835 = v848 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v851 : (bool -> US7) = method21()
                    let v852 : (exn -> US7) = method22()
                    let v853 : US7 = match v834 with Choice1Of2 x -> v851 x | Choice2Of2 x -> v852 x
                    let _v835 = v853 
                    #endif
#else
                    let v854 : (bool -> US7) = method21()
                    let v855 : (exn -> US7) = method22()
                    let v856 : US7 = match v834 with Choice1Of2 x -> v854 x | Choice2Of2 x -> v855 x
                    let _v835 = v856 
                    #endif
                    let v857 : US7 = _v835 
                    return v857 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v862 : Async<US7> = _v833 
            let _v793 = v862 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v863 : unit = ()
            let _v863 =
                async {
                    let! v788 = v788 
                    let v864 : Choice<bool, exn> = v788 
                    let v865 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v866 : US7 = null |> unbox<US7>
                    let _v865 = v866 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v869 : US7 = null |> unbox<US7>
                    let _v865 = v869 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v872 : US7 = null |> unbox<US7>
                    let _v865 = v872 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v875 : US7 = null |> unbox<US7>
                    let _v865 = v875 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v878 : US7 = null |> unbox<US7>
                    let _v865 = v878 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v881 : (bool -> US7) = method21()
                    let v882 : (exn -> US7) = method22()
                    let v883 : US7 = match v864 with Choice1Of2 x -> v881 x | Choice2Of2 x -> v882 x
                    let _v865 = v883 
                    #endif
#else
                    let v884 : (bool -> US7) = method21()
                    let v885 : (exn -> US7) = method22()
                    let v886 : US7 = match v864 with Choice1Of2 x -> v884 x | Choice2Of2 x -> v885 x
                    let _v865 = v886 
                    #endif
                    let v887 : US7 = _v865 
                    return v887 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v892 : Async<US7> = _v863 
            let _v793 = v892 
            #endif
#else
            let v893 : unit = ()
            let _v893 =
                async {
                    let! v788 = v788 
                    let v894 : Choice<bool, exn> = v788 
                    let v895 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v896 : US7 = null |> unbox<US7>
                    let _v895 = v896 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v899 : US7 = null |> unbox<US7>
                    let _v895 = v899 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v902 : US7 = null |> unbox<US7>
                    let _v895 = v902 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v905 : US7 = null |> unbox<US7>
                    let _v895 = v905 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v908 : US7 = null |> unbox<US7>
                    let _v895 = v908 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v911 : (bool -> US7) = method21()
                    let v912 : (exn -> US7) = method22()
                    let v913 : US7 = match v894 with Choice1Of2 x -> v911 x | Choice2Of2 x -> v912 x
                    let _v895 = v913 
                    #endif
#else
                    let v914 : (bool -> US7) = method21()
                    let v915 : (exn -> US7) = method22()
                    let v916 : US7 = match v894 with Choice1Of2 x -> v914 x | Choice2Of2 x -> v915 x
                    let _v895 = v916 
                    #endif
                    let v917 : US7 = _v895 
                    return v917 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v922 : Async<US7> = _v893 
            let _v793 = v922 
            #endif
            let v923 : Async<US7> = _v793 
            let v928 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v929 : Async<US8> = null |> unbox<Async<US8>>
            let _v928 = v929 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v932 : Async<US8> = null |> unbox<Async<US8>>
            let _v928 = v932 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v935 : Async<US8> = null |> unbox<Async<US8>>
            let _v928 = v935 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v938 : unit = ()
            let _v938 =
                async {
                    let! v923 = v923 
                    let v939 : US7 = v923 
                    let v945 : US8 =
                        match v939 with
                        | US7_0(v940) -> (* C1of2 *)
                            US8_0(v940)
                        | US7_1(v942) -> (* C2of2 *)
                            US8_1(v942)
                    return v945 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v946 : Async<US8> = _v938 
            let _v928 = v946 
            #endif
#if FABLE_COMPILER_PYTHON
            let v947 : unit = ()
            let _v947 =
                async {
                    let! v923 = v923 
                    let v948 : US7 = v923 
                    let v954 : US8 =
                        match v948 with
                        | US7_0(v949) -> (* C1of2 *)
                            US8_0(v949)
                        | US7_1(v951) -> (* C2of2 *)
                            US8_1(v951)
                    return v954 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v955 : Async<US8> = _v947 
            let _v928 = v955 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v956 : unit = ()
            let _v956 =
                async {
                    let! v923 = v923 
                    let v957 : US7 = v923 
                    let v963 : US8 =
                        match v957 with
                        | US7_0(v958) -> (* C1of2 *)
                            US8_0(v958)
                        | US7_1(v960) -> (* C2of2 *)
                            US8_1(v960)
                    return v963 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v964 : Async<US8> = _v956 
            let _v928 = v964 
            #endif
#else
            let v965 : unit = ()
            let _v965 =
                async {
                    let! v923 = v923 
                    let v966 : US7 = v923 
                    let v972 : US8 =
                        match v966 with
                        | US7_0(v967) -> (* C1of2 *)
                            US8_0(v967)
                        | US7_1(v969) -> (* C2of2 *)
                            US8_1(v969)
                    return v972 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v973 : Async<US8> = _v965 
            let _v928 = v973 
            #endif
            let v974 : Async<US8> = _v928 
            let v979 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v980 : Async<US6> = null |> unbox<Async<US6>>
            let _v979 = v980 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v983 : Async<US6> = null |> unbox<Async<US6>>
            let _v979 = v983 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v986 : Async<US6> = null |> unbox<Async<US6>>
            let _v979 = v986 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v989 : unit = ()
            let _v989 =
                async {
                    let! v974 = v974 
                    let v990 : US8 = v974 
                    let v1114 : US6 =
                        match v990 with
                        | US8_1(v993) -> (* Error *)
                            let v994 : string = $"%A{v993}"
                            let v997 : string = "System.TimeoutException"
                            let v998 : bool = v994.Contains v997 
                            if v998 then
                                let v1001 : unit = ()
                                let v1002 : (unit -> unit) = closure16(v0)
                                let v1003 : unit = (fun () -> v1002 (); v1001) ()
                                US6_1
                            else
                                let v1044 : unit = ()
                                let v1045 : (unit -> unit) = closure17(v0, v993)
                                let v1046 : unit = (fun () -> v1045 (); v1044) ()
                                US6_1
                        | US8_0(v991) -> (* Ok *)
                            US6_0(v991)
                    return v1114 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1115 : Async<US6> = _v989 
            let _v979 = v1115 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1116 : unit = ()
            let _v1116 =
                async {
                    let! v974 = v974 
                    let v1117 : US8 = v974 
                    let v1241 : US6 =
                        match v1117 with
                        | US8_1(v1120) -> (* Error *)
                            let v1121 : string = $"%A{v1120}"
                            let v1124 : string = "System.TimeoutException"
                            let v1125 : bool = v1121.Contains v1124 
                            if v1125 then
                                let v1128 : unit = ()
                                let v1129 : (unit -> unit) = closure16(v0)
                                let v1130 : unit = (fun () -> v1129 (); v1128) ()
                                US6_1
                            else
                                let v1171 : unit = ()
                                let v1172 : (unit -> unit) = closure17(v0, v1120)
                                let v1173 : unit = (fun () -> v1172 (); v1171) ()
                                US6_1
                        | US8_0(v1118) -> (* Ok *)
                            US6_0(v1118)
                    return v1241 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1242 : Async<US6> = _v1116 
            let _v979 = v1242 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1243 : unit = ()
            let _v1243 =
                async {
                    let! v974 = v974 
                    let v1244 : US8 = v974 
                    let v1368 : US6 =
                        match v1244 with
                        | US8_1(v1247) -> (* Error *)
                            let v1248 : string = $"%A{v1247}"
                            let v1251 : string = "System.TimeoutException"
                            let v1252 : bool = v1248.Contains v1251 
                            if v1252 then
                                let v1255 : unit = ()
                                let v1256 : (unit -> unit) = closure16(v0)
                                let v1257 : unit = (fun () -> v1256 (); v1255) ()
                                US6_1
                            else
                                let v1298 : unit = ()
                                let v1299 : (unit -> unit) = closure17(v0, v1247)
                                let v1300 : unit = (fun () -> v1299 (); v1298) ()
                                US6_1
                        | US8_0(v1245) -> (* Ok *)
                            US6_0(v1245)
                    return v1368 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1369 : Async<US6> = _v1243 
            let _v979 = v1369 
            #endif
#else
            let v1370 : unit = ()
            let _v1370 =
                async {
                    let! v974 = v974 
                    let v1371 : US8 = v974 
                    let v1495 : US6 =
                        match v1371 with
                        | US8_1(v1374) -> (* Error *)
                            let v1375 : string = $"%A{v1374}"
                            let v1378 : string = "System.TimeoutException"
                            let v1379 : bool = v1375.Contains v1378 
                            if v1379 then
                                let v1382 : unit = ()
                                let v1383 : (unit -> unit) = closure16(v0)
                                let v1384 : unit = (fun () -> v1383 (); v1382) ()
                                US6_1
                            else
                                let v1425 : unit = ()
                                let v1426 : (unit -> unit) = closure17(v0, v1374)
                                let v1427 : unit = (fun () -> v1426 (); v1425) ()
                                US6_1
                        | US8_0(v1372) -> (* Ok *)
                            US6_0(v1372)
                    return v1495 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1496 : Async<US6> = _v1370 
            let _v979 = v1496 
            #endif
            let v1497 : Async<US6> = _v979 
            return! v1497 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1502 : Async<US6> = _v758 
    let _v3 = v1502 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1503 : unit = ()
    let _v1503 =
        async {
            let v1504 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1505 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1505 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1506 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1506 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1507 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1507 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1508 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1508 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1509 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1509 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1510 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1510 
            #endif
#else
            let v1511 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v1504 = v1511 
            #endif
            let v1512 : Async<Async<bool>> = _v1504 
            let! v1512 = v1512 
            let v1517 : Async<bool> = v1512 
            let v1518 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1519 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1520 : Async<Choice<bool, exn>> = v1519 v1517
            let _v1518 = v1520 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1521 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1522 : Async<Choice<bool, exn>> = v1521 v1517
            let _v1518 = v1522 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1523 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1524 : Async<Choice<bool, exn>> = v1523 v1517
            let _v1518 = v1524 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1525 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1526 : Async<Choice<bool, exn>> = v1525 v1517
            let _v1518 = v1526 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1527 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1528 : Async<Choice<bool, exn>> = v1527 v1517
            let _v1518 = v1528 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1529 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1530 : Async<Choice<bool, exn>> = v1529 v1517
            let _v1518 = v1530 
            #endif
#else
            let v1531 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v1532 : Async<Choice<bool, exn>> = v1531 v1517
            let _v1518 = v1532 
            #endif
            let v1533 : Async<Choice<bool, exn>> = _v1518 
            let v1538 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1539 : Async<US7> = null |> unbox<Async<US7>>
            let _v1538 = v1539 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1542 : Async<US7> = null |> unbox<Async<US7>>
            let _v1538 = v1542 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1545 : Async<US7> = null |> unbox<Async<US7>>
            let _v1538 = v1545 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1548 : unit = ()
            let _v1548 =
                async {
                    let! v1533 = v1533 
                    let v1549 : Choice<bool, exn> = v1533 
                    let v1550 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1551 : US7 = null |> unbox<US7>
                    let _v1550 = v1551 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1554 : US7 = null |> unbox<US7>
                    let _v1550 = v1554 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1557 : US7 = null |> unbox<US7>
                    let _v1550 = v1557 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1560 : US7 = null |> unbox<US7>
                    let _v1550 = v1560 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1563 : US7 = null |> unbox<US7>
                    let _v1550 = v1563 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1566 : (bool -> US7) = method21()
                    let v1567 : (exn -> US7) = method22()
                    let v1568 : US7 = match v1549 with Choice1Of2 x -> v1566 x | Choice2Of2 x -> v1567 x
                    let _v1550 = v1568 
                    #endif
#else
                    let v1569 : (bool -> US7) = method21()
                    let v1570 : (exn -> US7) = method22()
                    let v1571 : US7 = match v1549 with Choice1Of2 x -> v1569 x | Choice2Of2 x -> v1570 x
                    let _v1550 = v1571 
                    #endif
                    let v1572 : US7 = _v1550 
                    return v1572 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1577 : Async<US7> = _v1548 
            let _v1538 = v1577 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1578 : unit = ()
            let _v1578 =
                async {
                    let! v1533 = v1533 
                    let v1579 : Choice<bool, exn> = v1533 
                    let v1580 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1581 : US7 = null |> unbox<US7>
                    let _v1580 = v1581 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1584 : US7 = null |> unbox<US7>
                    let _v1580 = v1584 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1587 : US7 = null |> unbox<US7>
                    let _v1580 = v1587 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1590 : US7 = null |> unbox<US7>
                    let _v1580 = v1590 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1593 : US7 = null |> unbox<US7>
                    let _v1580 = v1593 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1596 : (bool -> US7) = method21()
                    let v1597 : (exn -> US7) = method22()
                    let v1598 : US7 = match v1579 with Choice1Of2 x -> v1596 x | Choice2Of2 x -> v1597 x
                    let _v1580 = v1598 
                    #endif
#else
                    let v1599 : (bool -> US7) = method21()
                    let v1600 : (exn -> US7) = method22()
                    let v1601 : US7 = match v1579 with Choice1Of2 x -> v1599 x | Choice2Of2 x -> v1600 x
                    let _v1580 = v1601 
                    #endif
                    let v1602 : US7 = _v1580 
                    return v1602 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1607 : Async<US7> = _v1578 
            let _v1538 = v1607 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1608 : unit = ()
            let _v1608 =
                async {
                    let! v1533 = v1533 
                    let v1609 : Choice<bool, exn> = v1533 
                    let v1610 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1611 : US7 = null |> unbox<US7>
                    let _v1610 = v1611 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1614 : US7 = null |> unbox<US7>
                    let _v1610 = v1614 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1617 : US7 = null |> unbox<US7>
                    let _v1610 = v1617 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1620 : US7 = null |> unbox<US7>
                    let _v1610 = v1620 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1623 : US7 = null |> unbox<US7>
                    let _v1610 = v1623 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1626 : (bool -> US7) = method21()
                    let v1627 : (exn -> US7) = method22()
                    let v1628 : US7 = match v1609 with Choice1Of2 x -> v1626 x | Choice2Of2 x -> v1627 x
                    let _v1610 = v1628 
                    #endif
#else
                    let v1629 : (bool -> US7) = method21()
                    let v1630 : (exn -> US7) = method22()
                    let v1631 : US7 = match v1609 with Choice1Of2 x -> v1629 x | Choice2Of2 x -> v1630 x
                    let _v1610 = v1631 
                    #endif
                    let v1632 : US7 = _v1610 
                    return v1632 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1637 : Async<US7> = _v1608 
            let _v1538 = v1637 
            #endif
#else
            let v1638 : unit = ()
            let _v1638 =
                async {
                    let! v1533 = v1533 
                    let v1639 : Choice<bool, exn> = v1533 
                    let v1640 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1641 : US7 = null |> unbox<US7>
                    let _v1640 = v1641 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1644 : US7 = null |> unbox<US7>
                    let _v1640 = v1644 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1647 : US7 = null |> unbox<US7>
                    let _v1640 = v1647 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1650 : US7 = null |> unbox<US7>
                    let _v1640 = v1650 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1653 : US7 = null |> unbox<US7>
                    let _v1640 = v1653 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1656 : (bool -> US7) = method21()
                    let v1657 : (exn -> US7) = method22()
                    let v1658 : US7 = match v1639 with Choice1Of2 x -> v1656 x | Choice2Of2 x -> v1657 x
                    let _v1640 = v1658 
                    #endif
#else
                    let v1659 : (bool -> US7) = method21()
                    let v1660 : (exn -> US7) = method22()
                    let v1661 : US7 = match v1639 with Choice1Of2 x -> v1659 x | Choice2Of2 x -> v1660 x
                    let _v1640 = v1661 
                    #endif
                    let v1662 : US7 = _v1640 
                    return v1662 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1667 : Async<US7> = _v1638 
            let _v1538 = v1667 
            #endif
            let v1668 : Async<US7> = _v1538 
            let v1673 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1674 : Async<US8> = null |> unbox<Async<US8>>
            let _v1673 = v1674 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1677 : Async<US8> = null |> unbox<Async<US8>>
            let _v1673 = v1677 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1680 : Async<US8> = null |> unbox<Async<US8>>
            let _v1673 = v1680 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1683 : unit = ()
            let _v1683 =
                async {
                    let! v1668 = v1668 
                    let v1684 : US7 = v1668 
                    let v1690 : US8 =
                        match v1684 with
                        | US7_0(v1685) -> (* C1of2 *)
                            US8_0(v1685)
                        | US7_1(v1687) -> (* C2of2 *)
                            US8_1(v1687)
                    return v1690 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1691 : Async<US8> = _v1683 
            let _v1673 = v1691 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1692 : unit = ()
            let _v1692 =
                async {
                    let! v1668 = v1668 
                    let v1693 : US7 = v1668 
                    let v1699 : US8 =
                        match v1693 with
                        | US7_0(v1694) -> (* C1of2 *)
                            US8_0(v1694)
                        | US7_1(v1696) -> (* C2of2 *)
                            US8_1(v1696)
                    return v1699 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1700 : Async<US8> = _v1692 
            let _v1673 = v1700 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1701 : unit = ()
            let _v1701 =
                async {
                    let! v1668 = v1668 
                    let v1702 : US7 = v1668 
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
            let _v1673 = v1709 
            #endif
#else
            let v1710 : unit = ()
            let _v1710 =
                async {
                    let! v1668 = v1668 
                    let v1711 : US7 = v1668 
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
            let _v1673 = v1718 
            #endif
            let v1719 : Async<US8> = _v1673 
            let v1724 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1725 : Async<US6> = null |> unbox<Async<US6>>
            let _v1724 = v1725 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1728 : Async<US6> = null |> unbox<Async<US6>>
            let _v1724 = v1728 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1731 : Async<US6> = null |> unbox<Async<US6>>
            let _v1724 = v1731 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1734 : unit = ()
            let _v1734 =
                async {
                    let! v1719 = v1719 
                    let v1735 : US8 = v1719 
                    let v1859 : US6 =
                        match v1735 with
                        | US8_1(v1738) -> (* Error *)
                            let v1739 : string = $"%A{v1738}"
                            let v1742 : string = "System.TimeoutException"
                            let v1743 : bool = v1739.Contains v1742 
                            if v1743 then
                                let v1746 : unit = ()
                                let v1747 : (unit -> unit) = closure16(v0)
                                let v1748 : unit = (fun () -> v1747 (); v1746) ()
                                US6_1
                            else
                                let v1789 : unit = ()
                                let v1790 : (unit -> unit) = closure17(v0, v1738)
                                let v1791 : unit = (fun () -> v1790 (); v1789) ()
                                US6_1
                        | US8_0(v1736) -> (* Ok *)
                            US6_0(v1736)
                    return v1859 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1860 : Async<US6> = _v1734 
            let _v1724 = v1860 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1861 : unit = ()
            let _v1861 =
                async {
                    let! v1719 = v1719 
                    let v1862 : US8 = v1719 
                    let v1986 : US6 =
                        match v1862 with
                        | US8_1(v1865) -> (* Error *)
                            let v1866 : string = $"%A{v1865}"
                            let v1869 : string = "System.TimeoutException"
                            let v1870 : bool = v1866.Contains v1869 
                            if v1870 then
                                let v1873 : unit = ()
                                let v1874 : (unit -> unit) = closure16(v0)
                                let v1875 : unit = (fun () -> v1874 (); v1873) ()
                                US6_1
                            else
                                let v1916 : unit = ()
                                let v1917 : (unit -> unit) = closure17(v0, v1865)
                                let v1918 : unit = (fun () -> v1917 (); v1916) ()
                                US6_1
                        | US8_0(v1863) -> (* Ok *)
                            US6_0(v1863)
                    return v1986 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1987 : Async<US6> = _v1861 
            let _v1724 = v1987 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1988 : unit = ()
            let _v1988 =
                async {
                    let! v1719 = v1719 
                    let v1989 : US8 = v1719 
                    let v2113 : US6 =
                        match v1989 with
                        | US8_1(v1992) -> (* Error *)
                            let v1993 : string = $"%A{v1992}"
                            let v1996 : string = "System.TimeoutException"
                            let v1997 : bool = v1993.Contains v1996 
                            if v1997 then
                                let v2000 : unit = ()
                                let v2001 : (unit -> unit) = closure16(v0)
                                let v2002 : unit = (fun () -> v2001 (); v2000) ()
                                US6_1
                            else
                                let v2043 : unit = ()
                                let v2044 : (unit -> unit) = closure17(v0, v1992)
                                let v2045 : unit = (fun () -> v2044 (); v2043) ()
                                US6_1
                        | US8_0(v1990) -> (* Ok *)
                            US6_0(v1990)
                    return v2113 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2114 : Async<US6> = _v1988 
            let _v1724 = v2114 
            #endif
#else
            let v2115 : unit = ()
            let _v2115 =
                async {
                    let! v1719 = v1719 
                    let v2116 : US8 = v1719 
                    let v2240 : US6 =
                        match v2116 with
                        | US8_1(v2119) -> (* Error *)
                            let v2120 : string = $"%A{v2119}"
                            let v2123 : string = "System.TimeoutException"
                            let v2124 : bool = v2120.Contains v2123 
                            if v2124 then
                                let v2127 : unit = ()
                                let v2128 : (unit -> unit) = closure16(v0)
                                let v2129 : unit = (fun () -> v2128 (); v2127) ()
                                US6_1
                            else
                                let v2170 : unit = ()
                                let v2171 : (unit -> unit) = closure17(v0, v2119)
                                let v2172 : unit = (fun () -> v2171 (); v2170) ()
                                US6_1
                        | US8_0(v2117) -> (* Ok *)
                            US6_0(v2117)
                    return v2240 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2241 : Async<US6> = _v2115 
            let _v1724 = v2241 
            #endif
            let v2242 : Async<US6> = _v1724 
            return! v2242 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2247 : Async<US6> = _v1503 
    let _v3 = v2247 
    #endif
#else
    let v2248 : unit = ()
    let _v2248 =
        async {
            let v2249 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2250 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2250 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2251 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2251 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2252 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2252 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2253 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2253 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2254 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2254 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2255 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2255 
            #endif
#else
            let v2256 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v2249 = v2256 
            #endif
            let v2257 : Async<Async<bool>> = _v2249 
            let! v2257 = v2257 
            let v2262 : Async<bool> = v2257 
            let v2263 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2264 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2265 : Async<Choice<bool, exn>> = v2264 v2262
            let _v2263 = v2265 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2266 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2267 : Async<Choice<bool, exn>> = v2266 v2262
            let _v2263 = v2267 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2268 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2269 : Async<Choice<bool, exn>> = v2268 v2262
            let _v2263 = v2269 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2270 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2271 : Async<Choice<bool, exn>> = v2270 v2262
            let _v2263 = v2271 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2272 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2273 : Async<Choice<bool, exn>> = v2272 v2262
            let _v2263 = v2273 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2274 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2275 : Async<Choice<bool, exn>> = v2274 v2262
            let _v2263 = v2275 
            #endif
#else
            let v2276 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v2277 : Async<Choice<bool, exn>> = v2276 v2262
            let _v2263 = v2277 
            #endif
            let v2278 : Async<Choice<bool, exn>> = _v2263 
            let v2283 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2284 : Async<US7> = null |> unbox<Async<US7>>
            let _v2283 = v2284 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2287 : Async<US7> = null |> unbox<Async<US7>>
            let _v2283 = v2287 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2290 : Async<US7> = null |> unbox<Async<US7>>
            let _v2283 = v2290 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2293 : unit = ()
            let _v2293 =
                async {
                    let! v2278 = v2278 
                    let v2294 : Choice<bool, exn> = v2278 
                    let v2295 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2296 : US7 = null |> unbox<US7>
                    let _v2295 = v2296 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2299 : US7 = null |> unbox<US7>
                    let _v2295 = v2299 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2302 : US7 = null |> unbox<US7>
                    let _v2295 = v2302 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2305 : US7 = null |> unbox<US7>
                    let _v2295 = v2305 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2308 : US7 = null |> unbox<US7>
                    let _v2295 = v2308 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2311 : (bool -> US7) = method21()
                    let v2312 : (exn -> US7) = method22()
                    let v2313 : US7 = match v2294 with Choice1Of2 x -> v2311 x | Choice2Of2 x -> v2312 x
                    let _v2295 = v2313 
                    #endif
#else
                    let v2314 : (bool -> US7) = method21()
                    let v2315 : (exn -> US7) = method22()
                    let v2316 : US7 = match v2294 with Choice1Of2 x -> v2314 x | Choice2Of2 x -> v2315 x
                    let _v2295 = v2316 
                    #endif
                    let v2317 : US7 = _v2295 
                    return v2317 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2322 : Async<US7> = _v2293 
            let _v2283 = v2322 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2323 : unit = ()
            let _v2323 =
                async {
                    let! v2278 = v2278 
                    let v2324 : Choice<bool, exn> = v2278 
                    let v2325 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2326 : US7 = null |> unbox<US7>
                    let _v2325 = v2326 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2329 : US7 = null |> unbox<US7>
                    let _v2325 = v2329 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2332 : US7 = null |> unbox<US7>
                    let _v2325 = v2332 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2335 : US7 = null |> unbox<US7>
                    let _v2325 = v2335 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2338 : US7 = null |> unbox<US7>
                    let _v2325 = v2338 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2341 : (bool -> US7) = method21()
                    let v2342 : (exn -> US7) = method22()
                    let v2343 : US7 = match v2324 with Choice1Of2 x -> v2341 x | Choice2Of2 x -> v2342 x
                    let _v2325 = v2343 
                    #endif
#else
                    let v2344 : (bool -> US7) = method21()
                    let v2345 : (exn -> US7) = method22()
                    let v2346 : US7 = match v2324 with Choice1Of2 x -> v2344 x | Choice2Of2 x -> v2345 x
                    let _v2325 = v2346 
                    #endif
                    let v2347 : US7 = _v2325 
                    return v2347 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2352 : Async<US7> = _v2323 
            let _v2283 = v2352 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2353 : unit = ()
            let _v2353 =
                async {
                    let! v2278 = v2278 
                    let v2354 : Choice<bool, exn> = v2278 
                    let v2355 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2356 : US7 = null |> unbox<US7>
                    let _v2355 = v2356 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2359 : US7 = null |> unbox<US7>
                    let _v2355 = v2359 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2362 : US7 = null |> unbox<US7>
                    let _v2355 = v2362 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2365 : US7 = null |> unbox<US7>
                    let _v2355 = v2365 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2368 : US7 = null |> unbox<US7>
                    let _v2355 = v2368 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2371 : (bool -> US7) = method21()
                    let v2372 : (exn -> US7) = method22()
                    let v2373 : US7 = match v2354 with Choice1Of2 x -> v2371 x | Choice2Of2 x -> v2372 x
                    let _v2355 = v2373 
                    #endif
#else
                    let v2374 : (bool -> US7) = method21()
                    let v2375 : (exn -> US7) = method22()
                    let v2376 : US7 = match v2354 with Choice1Of2 x -> v2374 x | Choice2Of2 x -> v2375 x
                    let _v2355 = v2376 
                    #endif
                    let v2377 : US7 = _v2355 
                    return v2377 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2382 : Async<US7> = _v2353 
            let _v2283 = v2382 
            #endif
#else
            let v2383 : unit = ()
            let _v2383 =
                async {
                    let! v2278 = v2278 
                    let v2384 : Choice<bool, exn> = v2278 
                    let v2385 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2386 : US7 = null |> unbox<US7>
                    let _v2385 = v2386 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2389 : US7 = null |> unbox<US7>
                    let _v2385 = v2389 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2392 : US7 = null |> unbox<US7>
                    let _v2385 = v2392 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2395 : US7 = null |> unbox<US7>
                    let _v2385 = v2395 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2398 : US7 = null |> unbox<US7>
                    let _v2385 = v2398 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2401 : (bool -> US7) = method21()
                    let v2402 : (exn -> US7) = method22()
                    let v2403 : US7 = match v2384 with Choice1Of2 x -> v2401 x | Choice2Of2 x -> v2402 x
                    let _v2385 = v2403 
                    #endif
#else
                    let v2404 : (bool -> US7) = method21()
                    let v2405 : (exn -> US7) = method22()
                    let v2406 : US7 = match v2384 with Choice1Of2 x -> v2404 x | Choice2Of2 x -> v2405 x
                    let _v2385 = v2406 
                    #endif
                    let v2407 : US7 = _v2385 
                    return v2407 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2412 : Async<US7> = _v2383 
            let _v2283 = v2412 
            #endif
            let v2413 : Async<US7> = _v2283 
            let v2418 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2419 : Async<US8> = null |> unbox<Async<US8>>
            let _v2418 = v2419 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2422 : Async<US8> = null |> unbox<Async<US8>>
            let _v2418 = v2422 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2425 : Async<US8> = null |> unbox<Async<US8>>
            let _v2418 = v2425 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2428 : unit = ()
            let _v2428 =
                async {
                    let! v2413 = v2413 
                    let v2429 : US7 = v2413 
                    let v2435 : US8 =
                        match v2429 with
                        | US7_0(v2430) -> (* C1of2 *)
                            US8_0(v2430)
                        | US7_1(v2432) -> (* C2of2 *)
                            US8_1(v2432)
                    return v2435 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2436 : Async<US8> = _v2428 
            let _v2418 = v2436 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2437 : unit = ()
            let _v2437 =
                async {
                    let! v2413 = v2413 
                    let v2438 : US7 = v2413 
                    let v2444 : US8 =
                        match v2438 with
                        | US7_0(v2439) -> (* C1of2 *)
                            US8_0(v2439)
                        | US7_1(v2441) -> (* C2of2 *)
                            US8_1(v2441)
                    return v2444 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2445 : Async<US8> = _v2437 
            let _v2418 = v2445 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2446 : unit = ()
            let _v2446 =
                async {
                    let! v2413 = v2413 
                    let v2447 : US7 = v2413 
                    let v2453 : US8 =
                        match v2447 with
                        | US7_0(v2448) -> (* C1of2 *)
                            US8_0(v2448)
                        | US7_1(v2450) -> (* C2of2 *)
                            US8_1(v2450)
                    return v2453 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2454 : Async<US8> = _v2446 
            let _v2418 = v2454 
            #endif
#else
            let v2455 : unit = ()
            let _v2455 =
                async {
                    let! v2413 = v2413 
                    let v2456 : US7 = v2413 
                    let v2462 : US8 =
                        match v2456 with
                        | US7_0(v2457) -> (* C1of2 *)
                            US8_0(v2457)
                        | US7_1(v2459) -> (* C2of2 *)
                            US8_1(v2459)
                    return v2462 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2463 : Async<US8> = _v2455 
            let _v2418 = v2463 
            #endif
            let v2464 : Async<US8> = _v2418 
            let v2469 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2470 : Async<US6> = null |> unbox<Async<US6>>
            let _v2469 = v2470 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2473 : Async<US6> = null |> unbox<Async<US6>>
            let _v2469 = v2473 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2476 : Async<US6> = null |> unbox<Async<US6>>
            let _v2469 = v2476 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2479 : unit = ()
            let _v2479 =
                async {
                    let! v2464 = v2464 
                    let v2480 : US8 = v2464 
                    let v2604 : US6 =
                        match v2480 with
                        | US8_1(v2483) -> (* Error *)
                            let v2484 : string = $"%A{v2483}"
                            let v2487 : string = "System.TimeoutException"
                            let v2488 : bool = v2484.Contains v2487 
                            if v2488 then
                                let v2491 : unit = ()
                                let v2492 : (unit -> unit) = closure16(v0)
                                let v2493 : unit = (fun () -> v2492 (); v2491) ()
                                US6_1
                            else
                                let v2534 : unit = ()
                                let v2535 : (unit -> unit) = closure17(v0, v2483)
                                let v2536 : unit = (fun () -> v2535 (); v2534) ()
                                US6_1
                        | US8_0(v2481) -> (* Ok *)
                            US6_0(v2481)
                    return v2604 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2605 : Async<US6> = _v2479 
            let _v2469 = v2605 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2606 : unit = ()
            let _v2606 =
                async {
                    let! v2464 = v2464 
                    let v2607 : US8 = v2464 
                    let v2731 : US6 =
                        match v2607 with
                        | US8_1(v2610) -> (* Error *)
                            let v2611 : string = $"%A{v2610}"
                            let v2614 : string = "System.TimeoutException"
                            let v2615 : bool = v2611.Contains v2614 
                            if v2615 then
                                let v2618 : unit = ()
                                let v2619 : (unit -> unit) = closure16(v0)
                                let v2620 : unit = (fun () -> v2619 (); v2618) ()
                                US6_1
                            else
                                let v2661 : unit = ()
                                let v2662 : (unit -> unit) = closure17(v0, v2610)
                                let v2663 : unit = (fun () -> v2662 (); v2661) ()
                                US6_1
                        | US8_0(v2608) -> (* Ok *)
                            US6_0(v2608)
                    return v2731 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2732 : Async<US6> = _v2606 
            let _v2469 = v2732 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2733 : unit = ()
            let _v2733 =
                async {
                    let! v2464 = v2464 
                    let v2734 : US8 = v2464 
                    let v2858 : US6 =
                        match v2734 with
                        | US8_1(v2737) -> (* Error *)
                            let v2738 : string = $"%A{v2737}"
                            let v2741 : string = "System.TimeoutException"
                            let v2742 : bool = v2738.Contains v2741 
                            if v2742 then
                                let v2745 : unit = ()
                                let v2746 : (unit -> unit) = closure16(v0)
                                let v2747 : unit = (fun () -> v2746 (); v2745) ()
                                US6_1
                            else
                                let v2788 : unit = ()
                                let v2789 : (unit -> unit) = closure17(v0, v2737)
                                let v2790 : unit = (fun () -> v2789 (); v2788) ()
                                US6_1
                        | US8_0(v2735) -> (* Ok *)
                            US6_0(v2735)
                    return v2858 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2859 : Async<US6> = _v2733 
            let _v2469 = v2859 
            #endif
#else
            let v2860 : unit = ()
            let _v2860 =
                async {
                    let! v2464 = v2464 
                    let v2861 : US8 = v2464 
                    let v2985 : US6 =
                        match v2861 with
                        | US8_1(v2864) -> (* Error *)
                            let v2865 : string = $"%A{v2864}"
                            let v2868 : string = "System.TimeoutException"
                            let v2869 : bool = v2865.Contains v2868 
                            if v2869 then
                                let v2872 : unit = ()
                                let v2873 : (unit -> unit) = closure16(v0)
                                let v2874 : unit = (fun () -> v2873 (); v2872) ()
                                US6_1
                            else
                                let v2915 : unit = ()
                                let v2916 : (unit -> unit) = closure17(v0, v2864)
                                let v2917 : unit = (fun () -> v2916 (); v2915) ()
                                US6_1
                        | US8_0(v2862) -> (* Ok *)
                            US6_0(v2862)
                    return v2985 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2986 : Async<US6> = _v2860 
            let _v2469 = v2986 
            #endif
            let v2987 : Async<US6> = _v2469 
            return! v2987 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2992 : Async<US6> = _v2248 
    let _v3 = v2992 
    #endif
    let v2993 : Async<US6> = _v3 
    let _v2 = v2993 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2998 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2999 : Async<US6> = null |> unbox<Async<US6>>
    let _v2998 = v2999 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3002 : Async<US6> = null |> unbox<Async<US6>>
    let _v2998 = v3002 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3005 : Async<US6> = null |> unbox<Async<US6>>
    let _v2998 = v3005 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3008 : unit = ()
    let _v3008 =
        async {
            let v3009 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3010 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3010 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3011 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3011 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3012 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3012 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3013 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3013 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3014 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3014 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3015 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3015 
            #endif
#else
            let v3016 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3009 = v3016 
            #endif
            let v3017 : Async<Async<bool>> = _v3009 
            let! v3017 = v3017 
            let v3022 : Async<bool> = v3017 
            let v3023 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3024 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3025 : Async<Choice<bool, exn>> = v3024 v3022
            let _v3023 = v3025 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3026 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3027 : Async<Choice<bool, exn>> = v3026 v3022
            let _v3023 = v3027 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3028 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3029 : Async<Choice<bool, exn>> = v3028 v3022
            let _v3023 = v3029 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3030 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3031 : Async<Choice<bool, exn>> = v3030 v3022
            let _v3023 = v3031 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3032 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3033 : Async<Choice<bool, exn>> = v3032 v3022
            let _v3023 = v3033 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3034 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3035 : Async<Choice<bool, exn>> = v3034 v3022
            let _v3023 = v3035 
            #endif
#else
            let v3036 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3037 : Async<Choice<bool, exn>> = v3036 v3022
            let _v3023 = v3037 
            #endif
            let v3038 : Async<Choice<bool, exn>> = _v3023 
            let v3043 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3044 : Async<US7> = null |> unbox<Async<US7>>
            let _v3043 = v3044 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3047 : Async<US7> = null |> unbox<Async<US7>>
            let _v3043 = v3047 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3050 : Async<US7> = null |> unbox<Async<US7>>
            let _v3043 = v3050 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3053 : unit = ()
            let _v3053 =
                async {
                    let! v3038 = v3038 
                    let v3054 : Choice<bool, exn> = v3038 
                    let v3055 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3056 : US7 = null |> unbox<US7>
                    let _v3055 = v3056 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3059 : US7 = null |> unbox<US7>
                    let _v3055 = v3059 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3062 : US7 = null |> unbox<US7>
                    let _v3055 = v3062 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3065 : US7 = null |> unbox<US7>
                    let _v3055 = v3065 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3068 : US7 = null |> unbox<US7>
                    let _v3055 = v3068 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3071 : (bool -> US7) = method21()
                    let v3072 : (exn -> US7) = method22()
                    let v3073 : US7 = match v3054 with Choice1Of2 x -> v3071 x | Choice2Of2 x -> v3072 x
                    let _v3055 = v3073 
                    #endif
#else
                    let v3074 : (bool -> US7) = method21()
                    let v3075 : (exn -> US7) = method22()
                    let v3076 : US7 = match v3054 with Choice1Of2 x -> v3074 x | Choice2Of2 x -> v3075 x
                    let _v3055 = v3076 
                    #endif
                    let v3077 : US7 = _v3055 
                    return v3077 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3082 : Async<US7> = _v3053 
            let _v3043 = v3082 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3083 : unit = ()
            let _v3083 =
                async {
                    let! v3038 = v3038 
                    let v3084 : Choice<bool, exn> = v3038 
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
                    let v3101 : (bool -> US7) = method21()
                    let v3102 : (exn -> US7) = method22()
                    let v3103 : US7 = match v3084 with Choice1Of2 x -> v3101 x | Choice2Of2 x -> v3102 x
                    let _v3085 = v3103 
                    #endif
#else
                    let v3104 : (bool -> US7) = method21()
                    let v3105 : (exn -> US7) = method22()
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
            let _v3043 = v3112 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3113 : unit = ()
            let _v3113 =
                async {
                    let! v3038 = v3038 
                    let v3114 : Choice<bool, exn> = v3038 
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
                    let v3131 : (bool -> US7) = method21()
                    let v3132 : (exn -> US7) = method22()
                    let v3133 : US7 = match v3114 with Choice1Of2 x -> v3131 x | Choice2Of2 x -> v3132 x
                    let _v3115 = v3133 
                    #endif
#else
                    let v3134 : (bool -> US7) = method21()
                    let v3135 : (exn -> US7) = method22()
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
            let _v3043 = v3142 
            #endif
#else
            let v3143 : unit = ()
            let _v3143 =
                async {
                    let! v3038 = v3038 
                    let v3144 : Choice<bool, exn> = v3038 
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
                    let v3161 : (bool -> US7) = method21()
                    let v3162 : (exn -> US7) = method22()
                    let v3163 : US7 = match v3144 with Choice1Of2 x -> v3161 x | Choice2Of2 x -> v3162 x
                    let _v3145 = v3163 
                    #endif
#else
                    let v3164 : (bool -> US7) = method21()
                    let v3165 : (exn -> US7) = method22()
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
            let _v3043 = v3172 
            #endif
            let v3173 : Async<US7> = _v3043 
            let v3178 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3179 : Async<US8> = null |> unbox<Async<US8>>
            let _v3178 = v3179 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3182 : Async<US8> = null |> unbox<Async<US8>>
            let _v3178 = v3182 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3185 : Async<US8> = null |> unbox<Async<US8>>
            let _v3178 = v3185 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3188 : unit = ()
            let _v3188 =
                async {
                    let! v3173 = v3173 
                    let v3189 : US7 = v3173 
                    let v3195 : US8 =
                        match v3189 with
                        | US7_0(v3190) -> (* C1of2 *)
                            US8_0(v3190)
                        | US7_1(v3192) -> (* C2of2 *)
                            US8_1(v3192)
                    return v3195 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3196 : Async<US8> = _v3188 
            let _v3178 = v3196 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3197 : unit = ()
            let _v3197 =
                async {
                    let! v3173 = v3173 
                    let v3198 : US7 = v3173 
                    let v3204 : US8 =
                        match v3198 with
                        | US7_0(v3199) -> (* C1of2 *)
                            US8_0(v3199)
                        | US7_1(v3201) -> (* C2of2 *)
                            US8_1(v3201)
                    return v3204 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3205 : Async<US8> = _v3197 
            let _v3178 = v3205 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3206 : unit = ()
            let _v3206 =
                async {
                    let! v3173 = v3173 
                    let v3207 : US7 = v3173 
                    let v3213 : US8 =
                        match v3207 with
                        | US7_0(v3208) -> (* C1of2 *)
                            US8_0(v3208)
                        | US7_1(v3210) -> (* C2of2 *)
                            US8_1(v3210)
                    return v3213 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3214 : Async<US8> = _v3206 
            let _v3178 = v3214 
            #endif
#else
            let v3215 : unit = ()
            let _v3215 =
                async {
                    let! v3173 = v3173 
                    let v3216 : US7 = v3173 
                    let v3222 : US8 =
                        match v3216 with
                        | US7_0(v3217) -> (* C1of2 *)
                            US8_0(v3217)
                        | US7_1(v3219) -> (* C2of2 *)
                            US8_1(v3219)
                    return v3222 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3223 : Async<US8> = _v3215 
            let _v3178 = v3223 
            #endif
            let v3224 : Async<US8> = _v3178 
            let v3229 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3230 : Async<US6> = null |> unbox<Async<US6>>
            let _v3229 = v3230 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3233 : Async<US6> = null |> unbox<Async<US6>>
            let _v3229 = v3233 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3236 : Async<US6> = null |> unbox<Async<US6>>
            let _v3229 = v3236 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3239 : unit = ()
            let _v3239 =
                async {
                    let! v3224 = v3224 
                    let v3240 : US8 = v3224 
                    let v3364 : US6 =
                        match v3240 with
                        | US8_1(v3243) -> (* Error *)
                            let v3244 : string = $"%A{v3243}"
                            let v3247 : string = "System.TimeoutException"
                            let v3248 : bool = v3244.Contains v3247 
                            if v3248 then
                                let v3251 : unit = ()
                                let v3252 : (unit -> unit) = closure16(v0)
                                let v3253 : unit = (fun () -> v3252 (); v3251) ()
                                US6_1
                            else
                                let v3294 : unit = ()
                                let v3295 : (unit -> unit) = closure17(v0, v3243)
                                let v3296 : unit = (fun () -> v3295 (); v3294) ()
                                US6_1
                        | US8_0(v3241) -> (* Ok *)
                            US6_0(v3241)
                    return v3364 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3365 : Async<US6> = _v3239 
            let _v3229 = v3365 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3366 : unit = ()
            let _v3366 =
                async {
                    let! v3224 = v3224 
                    let v3367 : US8 = v3224 
                    let v3491 : US6 =
                        match v3367 with
                        | US8_1(v3370) -> (* Error *)
                            let v3371 : string = $"%A{v3370}"
                            let v3374 : string = "System.TimeoutException"
                            let v3375 : bool = v3371.Contains v3374 
                            if v3375 then
                                let v3378 : unit = ()
                                let v3379 : (unit -> unit) = closure16(v0)
                                let v3380 : unit = (fun () -> v3379 (); v3378) ()
                                US6_1
                            else
                                let v3421 : unit = ()
                                let v3422 : (unit -> unit) = closure17(v0, v3370)
                                let v3423 : unit = (fun () -> v3422 (); v3421) ()
                                US6_1
                        | US8_0(v3368) -> (* Ok *)
                            US6_0(v3368)
                    return v3491 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3492 : Async<US6> = _v3366 
            let _v3229 = v3492 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3493 : unit = ()
            let _v3493 =
                async {
                    let! v3224 = v3224 
                    let v3494 : US8 = v3224 
                    let v3618 : US6 =
                        match v3494 with
                        | US8_1(v3497) -> (* Error *)
                            let v3498 : string = $"%A{v3497}"
                            let v3501 : string = "System.TimeoutException"
                            let v3502 : bool = v3498.Contains v3501 
                            if v3502 then
                                let v3505 : unit = ()
                                let v3506 : (unit -> unit) = closure16(v0)
                                let v3507 : unit = (fun () -> v3506 (); v3505) ()
                                US6_1
                            else
                                let v3548 : unit = ()
                                let v3549 : (unit -> unit) = closure17(v0, v3497)
                                let v3550 : unit = (fun () -> v3549 (); v3548) ()
                                US6_1
                        | US8_0(v3495) -> (* Ok *)
                            US6_0(v3495)
                    return v3618 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3619 : Async<US6> = _v3493 
            let _v3229 = v3619 
            #endif
#else
            let v3620 : unit = ()
            let _v3620 =
                async {
                    let! v3224 = v3224 
                    let v3621 : US8 = v3224 
                    let v3745 : US6 =
                        match v3621 with
                        | US8_1(v3624) -> (* Error *)
                            let v3625 : string = $"%A{v3624}"
                            let v3628 : string = "System.TimeoutException"
                            let v3629 : bool = v3625.Contains v3628 
                            if v3629 then
                                let v3632 : unit = ()
                                let v3633 : (unit -> unit) = closure16(v0)
                                let v3634 : unit = (fun () -> v3633 (); v3632) ()
                                US6_1
                            else
                                let v3675 : unit = ()
                                let v3676 : (unit -> unit) = closure17(v0, v3624)
                                let v3677 : unit = (fun () -> v3676 (); v3675) ()
                                US6_1
                        | US8_0(v3622) -> (* Ok *)
                            US6_0(v3622)
                    return v3745 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3746 : Async<US6> = _v3620 
            let _v3229 = v3746 
            #endif
            let v3747 : Async<US6> = _v3229 
            return! v3747 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3752 : Async<US6> = _v3008 
    let _v2998 = v3752 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3753 : unit = ()
    let _v3753 =
        async {
            let v3754 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3755 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3755 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3756 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3756 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3757 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3757 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3758 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3758 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3759 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3759 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3760 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3760 
            #endif
#else
            let v3761 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v3754 = v3761 
            #endif
            let v3762 : Async<Async<bool>> = _v3754 
            let! v3762 = v3762 
            let v3767 : Async<bool> = v3762 
            let v3768 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3769 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3770 : Async<Choice<bool, exn>> = v3769 v3767
            let _v3768 = v3770 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3771 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3772 : Async<Choice<bool, exn>> = v3771 v3767
            let _v3768 = v3772 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3773 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3774 : Async<Choice<bool, exn>> = v3773 v3767
            let _v3768 = v3774 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3775 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3776 : Async<Choice<bool, exn>> = v3775 v3767
            let _v3768 = v3776 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3777 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3778 : Async<Choice<bool, exn>> = v3777 v3767
            let _v3768 = v3778 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3779 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3780 : Async<Choice<bool, exn>> = v3779 v3767
            let _v3768 = v3780 
            #endif
#else
            let v3781 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v3782 : Async<Choice<bool, exn>> = v3781 v3767
            let _v3768 = v3782 
            #endif
            let v3783 : Async<Choice<bool, exn>> = _v3768 
            let v3788 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3789 : Async<US7> = null |> unbox<Async<US7>>
            let _v3788 = v3789 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3792 : Async<US7> = null |> unbox<Async<US7>>
            let _v3788 = v3792 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3795 : Async<US7> = null |> unbox<Async<US7>>
            let _v3788 = v3795 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3798 : unit = ()
            let _v3798 =
                async {
                    let! v3783 = v3783 
                    let v3799 : Choice<bool, exn> = v3783 
                    let v3800 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3801 : US7 = null |> unbox<US7>
                    let _v3800 = v3801 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3804 : US7 = null |> unbox<US7>
                    let _v3800 = v3804 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3807 : US7 = null |> unbox<US7>
                    let _v3800 = v3807 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3810 : US7 = null |> unbox<US7>
                    let _v3800 = v3810 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3813 : US7 = null |> unbox<US7>
                    let _v3800 = v3813 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3816 : (bool -> US7) = method21()
                    let v3817 : (exn -> US7) = method22()
                    let v3818 : US7 = match v3799 with Choice1Of2 x -> v3816 x | Choice2Of2 x -> v3817 x
                    let _v3800 = v3818 
                    #endif
#else
                    let v3819 : (bool -> US7) = method21()
                    let v3820 : (exn -> US7) = method22()
                    let v3821 : US7 = match v3799 with Choice1Of2 x -> v3819 x | Choice2Of2 x -> v3820 x
                    let _v3800 = v3821 
                    #endif
                    let v3822 : US7 = _v3800 
                    return v3822 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3827 : Async<US7> = _v3798 
            let _v3788 = v3827 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3828 : unit = ()
            let _v3828 =
                async {
                    let! v3783 = v3783 
                    let v3829 : Choice<bool, exn> = v3783 
                    let v3830 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3831 : US7 = null |> unbox<US7>
                    let _v3830 = v3831 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3834 : US7 = null |> unbox<US7>
                    let _v3830 = v3834 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3837 : US7 = null |> unbox<US7>
                    let _v3830 = v3837 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3840 : US7 = null |> unbox<US7>
                    let _v3830 = v3840 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3843 : US7 = null |> unbox<US7>
                    let _v3830 = v3843 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3846 : (bool -> US7) = method21()
                    let v3847 : (exn -> US7) = method22()
                    let v3848 : US7 = match v3829 with Choice1Of2 x -> v3846 x | Choice2Of2 x -> v3847 x
                    let _v3830 = v3848 
                    #endif
#else
                    let v3849 : (bool -> US7) = method21()
                    let v3850 : (exn -> US7) = method22()
                    let v3851 : US7 = match v3829 with Choice1Of2 x -> v3849 x | Choice2Of2 x -> v3850 x
                    let _v3830 = v3851 
                    #endif
                    let v3852 : US7 = _v3830 
                    return v3852 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3857 : Async<US7> = _v3828 
            let _v3788 = v3857 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3858 : unit = ()
            let _v3858 =
                async {
                    let! v3783 = v3783 
                    let v3859 : Choice<bool, exn> = v3783 
                    let v3860 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3861 : US7 = null |> unbox<US7>
                    let _v3860 = v3861 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3864 : US7 = null |> unbox<US7>
                    let _v3860 = v3864 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3867 : US7 = null |> unbox<US7>
                    let _v3860 = v3867 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3870 : US7 = null |> unbox<US7>
                    let _v3860 = v3870 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3873 : US7 = null |> unbox<US7>
                    let _v3860 = v3873 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3876 : (bool -> US7) = method21()
                    let v3877 : (exn -> US7) = method22()
                    let v3878 : US7 = match v3859 with Choice1Of2 x -> v3876 x | Choice2Of2 x -> v3877 x
                    let _v3860 = v3878 
                    #endif
#else
                    let v3879 : (bool -> US7) = method21()
                    let v3880 : (exn -> US7) = method22()
                    let v3881 : US7 = match v3859 with Choice1Of2 x -> v3879 x | Choice2Of2 x -> v3880 x
                    let _v3860 = v3881 
                    #endif
                    let v3882 : US7 = _v3860 
                    return v3882 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3887 : Async<US7> = _v3858 
            let _v3788 = v3887 
            #endif
#else
            let v3888 : unit = ()
            let _v3888 =
                async {
                    let! v3783 = v3783 
                    let v3889 : Choice<bool, exn> = v3783 
                    let v3890 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3891 : US7 = null |> unbox<US7>
                    let _v3890 = v3891 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3894 : US7 = null |> unbox<US7>
                    let _v3890 = v3894 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3897 : US7 = null |> unbox<US7>
                    let _v3890 = v3897 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3900 : US7 = null |> unbox<US7>
                    let _v3890 = v3900 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3903 : US7 = null |> unbox<US7>
                    let _v3890 = v3903 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3906 : (bool -> US7) = method21()
                    let v3907 : (exn -> US7) = method22()
                    let v3908 : US7 = match v3889 with Choice1Of2 x -> v3906 x | Choice2Of2 x -> v3907 x
                    let _v3890 = v3908 
                    #endif
#else
                    let v3909 : (bool -> US7) = method21()
                    let v3910 : (exn -> US7) = method22()
                    let v3911 : US7 = match v3889 with Choice1Of2 x -> v3909 x | Choice2Of2 x -> v3910 x
                    let _v3890 = v3911 
                    #endif
                    let v3912 : US7 = _v3890 
                    return v3912 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3917 : Async<US7> = _v3888 
            let _v3788 = v3917 
            #endif
            let v3918 : Async<US7> = _v3788 
            let v3923 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3924 : Async<US8> = null |> unbox<Async<US8>>
            let _v3923 = v3924 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3927 : Async<US8> = null |> unbox<Async<US8>>
            let _v3923 = v3927 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3930 : Async<US8> = null |> unbox<Async<US8>>
            let _v3923 = v3930 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3933 : unit = ()
            let _v3933 =
                async {
                    let! v3918 = v3918 
                    let v3934 : US7 = v3918 
                    let v3940 : US8 =
                        match v3934 with
                        | US7_0(v3935) -> (* C1of2 *)
                            US8_0(v3935)
                        | US7_1(v3937) -> (* C2of2 *)
                            US8_1(v3937)
                    return v3940 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3941 : Async<US8> = _v3933 
            let _v3923 = v3941 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3942 : unit = ()
            let _v3942 =
                async {
                    let! v3918 = v3918 
                    let v3943 : US7 = v3918 
                    let v3949 : US8 =
                        match v3943 with
                        | US7_0(v3944) -> (* C1of2 *)
                            US8_0(v3944)
                        | US7_1(v3946) -> (* C2of2 *)
                            US8_1(v3946)
                    return v3949 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3950 : Async<US8> = _v3942 
            let _v3923 = v3950 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3951 : unit = ()
            let _v3951 =
                async {
                    let! v3918 = v3918 
                    let v3952 : US7 = v3918 
                    let v3958 : US8 =
                        match v3952 with
                        | US7_0(v3953) -> (* C1of2 *)
                            US8_0(v3953)
                        | US7_1(v3955) -> (* C2of2 *)
                            US8_1(v3955)
                    return v3958 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3959 : Async<US8> = _v3951 
            let _v3923 = v3959 
            #endif
#else
            let v3960 : unit = ()
            let _v3960 =
                async {
                    let! v3918 = v3918 
                    let v3961 : US7 = v3918 
                    let v3967 : US8 =
                        match v3961 with
                        | US7_0(v3962) -> (* C1of2 *)
                            US8_0(v3962)
                        | US7_1(v3964) -> (* C2of2 *)
                            US8_1(v3964)
                    return v3967 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3968 : Async<US8> = _v3960 
            let _v3923 = v3968 
            #endif
            let v3969 : Async<US8> = _v3923 
            let v3974 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3975 : Async<US6> = null |> unbox<Async<US6>>
            let _v3974 = v3975 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3978 : Async<US6> = null |> unbox<Async<US6>>
            let _v3974 = v3978 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3981 : Async<US6> = null |> unbox<Async<US6>>
            let _v3974 = v3981 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3984 : unit = ()
            let _v3984 =
                async {
                    let! v3969 = v3969 
                    let v3985 : US8 = v3969 
                    let v4109 : US6 =
                        match v3985 with
                        | US8_1(v3988) -> (* Error *)
                            let v3989 : string = $"%A{v3988}"
                            let v3992 : string = "System.TimeoutException"
                            let v3993 : bool = v3989.Contains v3992 
                            if v3993 then
                                let v3996 : unit = ()
                                let v3997 : (unit -> unit) = closure16(v0)
                                let v3998 : unit = (fun () -> v3997 (); v3996) ()
                                US6_1
                            else
                                let v4039 : unit = ()
                                let v4040 : (unit -> unit) = closure17(v0, v3988)
                                let v4041 : unit = (fun () -> v4040 (); v4039) ()
                                US6_1
                        | US8_0(v3986) -> (* Ok *)
                            US6_0(v3986)
                    return v4109 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4110 : Async<US6> = _v3984 
            let _v3974 = v4110 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4111 : unit = ()
            let _v4111 =
                async {
                    let! v3969 = v3969 
                    let v4112 : US8 = v3969 
                    let v4236 : US6 =
                        match v4112 with
                        | US8_1(v4115) -> (* Error *)
                            let v4116 : string = $"%A{v4115}"
                            let v4119 : string = "System.TimeoutException"
                            let v4120 : bool = v4116.Contains v4119 
                            if v4120 then
                                let v4123 : unit = ()
                                let v4124 : (unit -> unit) = closure16(v0)
                                let v4125 : unit = (fun () -> v4124 (); v4123) ()
                                US6_1
                            else
                                let v4166 : unit = ()
                                let v4167 : (unit -> unit) = closure17(v0, v4115)
                                let v4168 : unit = (fun () -> v4167 (); v4166) ()
                                US6_1
                        | US8_0(v4113) -> (* Ok *)
                            US6_0(v4113)
                    return v4236 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4237 : Async<US6> = _v4111 
            let _v3974 = v4237 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4238 : unit = ()
            let _v4238 =
                async {
                    let! v3969 = v3969 
                    let v4239 : US8 = v3969 
                    let v4363 : US6 =
                        match v4239 with
                        | US8_1(v4242) -> (* Error *)
                            let v4243 : string = $"%A{v4242}"
                            let v4246 : string = "System.TimeoutException"
                            let v4247 : bool = v4243.Contains v4246 
                            if v4247 then
                                let v4250 : unit = ()
                                let v4251 : (unit -> unit) = closure16(v0)
                                let v4252 : unit = (fun () -> v4251 (); v4250) ()
                                US6_1
                            else
                                let v4293 : unit = ()
                                let v4294 : (unit -> unit) = closure17(v0, v4242)
                                let v4295 : unit = (fun () -> v4294 (); v4293) ()
                                US6_1
                        | US8_0(v4240) -> (* Ok *)
                            US6_0(v4240)
                    return v4363 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4364 : Async<US6> = _v4238 
            let _v3974 = v4364 
            #endif
#else
            let v4365 : unit = ()
            let _v4365 =
                async {
                    let! v3969 = v3969 
                    let v4366 : US8 = v3969 
                    let v4490 : US6 =
                        match v4366 with
                        | US8_1(v4369) -> (* Error *)
                            let v4370 : string = $"%A{v4369}"
                            let v4373 : string = "System.TimeoutException"
                            let v4374 : bool = v4370.Contains v4373 
                            if v4374 then
                                let v4377 : unit = ()
                                let v4378 : (unit -> unit) = closure16(v0)
                                let v4379 : unit = (fun () -> v4378 (); v4377) ()
                                US6_1
                            else
                                let v4420 : unit = ()
                                let v4421 : (unit -> unit) = closure17(v0, v4369)
                                let v4422 : unit = (fun () -> v4421 (); v4420) ()
                                US6_1
                        | US8_0(v4367) -> (* Ok *)
                            US6_0(v4367)
                    return v4490 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4491 : Async<US6> = _v4365 
            let _v3974 = v4491 
            #endif
            let v4492 : Async<US6> = _v3974 
            return! v4492 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4497 : Async<US6> = _v3753 
    let _v2998 = v4497 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4498 : unit = ()
    let _v4498 =
        async {
            let v4499 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4500 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4501 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4501 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4502 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4502 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4503 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4503 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4504 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4504 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4505 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4505 
            #endif
#else
            let v4506 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v4499 = v4506 
            #endif
            let v4507 : Async<Async<bool>> = _v4499 
            let! v4507 = v4507 
            let v4512 : Async<bool> = v4507 
            let v4513 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4514 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4515 : Async<Choice<bool, exn>> = v4514 v4512
            let _v4513 = v4515 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4516 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4517 : Async<Choice<bool, exn>> = v4516 v4512
            let _v4513 = v4517 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4518 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4519 : Async<Choice<bool, exn>> = v4518 v4512
            let _v4513 = v4519 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4520 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4521 : Async<Choice<bool, exn>> = v4520 v4512
            let _v4513 = v4521 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4522 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4523 : Async<Choice<bool, exn>> = v4522 v4512
            let _v4513 = v4523 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4524 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4525 : Async<Choice<bool, exn>> = v4524 v4512
            let _v4513 = v4525 
            #endif
#else
            let v4526 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v4527 : Async<Choice<bool, exn>> = v4526 v4512
            let _v4513 = v4527 
            #endif
            let v4528 : Async<Choice<bool, exn>> = _v4513 
            let v4533 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4534 : Async<US7> = null |> unbox<Async<US7>>
            let _v4533 = v4534 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4537 : Async<US7> = null |> unbox<Async<US7>>
            let _v4533 = v4537 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4540 : Async<US7> = null |> unbox<Async<US7>>
            let _v4533 = v4540 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4543 : unit = ()
            let _v4543 =
                async {
                    let! v4528 = v4528 
                    let v4544 : Choice<bool, exn> = v4528 
                    let v4545 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4546 : US7 = null |> unbox<US7>
                    let _v4545 = v4546 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4549 : US7 = null |> unbox<US7>
                    let _v4545 = v4549 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4552 : US7 = null |> unbox<US7>
                    let _v4545 = v4552 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4555 : US7 = null |> unbox<US7>
                    let _v4545 = v4555 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4558 : US7 = null |> unbox<US7>
                    let _v4545 = v4558 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4561 : (bool -> US7) = method21()
                    let v4562 : (exn -> US7) = method22()
                    let v4563 : US7 = match v4544 with Choice1Of2 x -> v4561 x | Choice2Of2 x -> v4562 x
                    let _v4545 = v4563 
                    #endif
#else
                    let v4564 : (bool -> US7) = method21()
                    let v4565 : (exn -> US7) = method22()
                    let v4566 : US7 = match v4544 with Choice1Of2 x -> v4564 x | Choice2Of2 x -> v4565 x
                    let _v4545 = v4566 
                    #endif
                    let v4567 : US7 = _v4545 
                    return v4567 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4572 : Async<US7> = _v4543 
            let _v4533 = v4572 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4573 : unit = ()
            let _v4573 =
                async {
                    let! v4528 = v4528 
                    let v4574 : Choice<bool, exn> = v4528 
                    let v4575 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4576 : US7 = null |> unbox<US7>
                    let _v4575 = v4576 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4579 : US7 = null |> unbox<US7>
                    let _v4575 = v4579 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4582 : US7 = null |> unbox<US7>
                    let _v4575 = v4582 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4585 : US7 = null |> unbox<US7>
                    let _v4575 = v4585 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4588 : US7 = null |> unbox<US7>
                    let _v4575 = v4588 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4591 : (bool -> US7) = method21()
                    let v4592 : (exn -> US7) = method22()
                    let v4593 : US7 = match v4574 with Choice1Of2 x -> v4591 x | Choice2Of2 x -> v4592 x
                    let _v4575 = v4593 
                    #endif
#else
                    let v4594 : (bool -> US7) = method21()
                    let v4595 : (exn -> US7) = method22()
                    let v4596 : US7 = match v4574 with Choice1Of2 x -> v4594 x | Choice2Of2 x -> v4595 x
                    let _v4575 = v4596 
                    #endif
                    let v4597 : US7 = _v4575 
                    return v4597 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4602 : Async<US7> = _v4573 
            let _v4533 = v4602 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4603 : unit = ()
            let _v4603 =
                async {
                    let! v4528 = v4528 
                    let v4604 : Choice<bool, exn> = v4528 
                    let v4605 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4606 : US7 = null |> unbox<US7>
                    let _v4605 = v4606 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4609 : US7 = null |> unbox<US7>
                    let _v4605 = v4609 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4612 : US7 = null |> unbox<US7>
                    let _v4605 = v4612 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4615 : US7 = null |> unbox<US7>
                    let _v4605 = v4615 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4618 : US7 = null |> unbox<US7>
                    let _v4605 = v4618 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4621 : (bool -> US7) = method21()
                    let v4622 : (exn -> US7) = method22()
                    let v4623 : US7 = match v4604 with Choice1Of2 x -> v4621 x | Choice2Of2 x -> v4622 x
                    let _v4605 = v4623 
                    #endif
#else
                    let v4624 : (bool -> US7) = method21()
                    let v4625 : (exn -> US7) = method22()
                    let v4626 : US7 = match v4604 with Choice1Of2 x -> v4624 x | Choice2Of2 x -> v4625 x
                    let _v4605 = v4626 
                    #endif
                    let v4627 : US7 = _v4605 
                    return v4627 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4632 : Async<US7> = _v4603 
            let _v4533 = v4632 
            #endif
#else
            let v4633 : unit = ()
            let _v4633 =
                async {
                    let! v4528 = v4528 
                    let v4634 : Choice<bool, exn> = v4528 
                    let v4635 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4636 : US7 = null |> unbox<US7>
                    let _v4635 = v4636 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4639 : US7 = null |> unbox<US7>
                    let _v4635 = v4639 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4642 : US7 = null |> unbox<US7>
                    let _v4635 = v4642 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4645 : US7 = null |> unbox<US7>
                    let _v4635 = v4645 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4648 : US7 = null |> unbox<US7>
                    let _v4635 = v4648 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4651 : (bool -> US7) = method21()
                    let v4652 : (exn -> US7) = method22()
                    let v4653 : US7 = match v4634 with Choice1Of2 x -> v4651 x | Choice2Of2 x -> v4652 x
                    let _v4635 = v4653 
                    #endif
#else
                    let v4654 : (bool -> US7) = method21()
                    let v4655 : (exn -> US7) = method22()
                    let v4656 : US7 = match v4634 with Choice1Of2 x -> v4654 x | Choice2Of2 x -> v4655 x
                    let _v4635 = v4656 
                    #endif
                    let v4657 : US7 = _v4635 
                    return v4657 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4662 : Async<US7> = _v4633 
            let _v4533 = v4662 
            #endif
            let v4663 : Async<US7> = _v4533 
            let v4668 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4669 : Async<US8> = null |> unbox<Async<US8>>
            let _v4668 = v4669 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4672 : Async<US8> = null |> unbox<Async<US8>>
            let _v4668 = v4672 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4675 : Async<US8> = null |> unbox<Async<US8>>
            let _v4668 = v4675 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4678 : unit = ()
            let _v4678 =
                async {
                    let! v4663 = v4663 
                    let v4679 : US7 = v4663 
                    let v4685 : US8 =
                        match v4679 with
                        | US7_0(v4680) -> (* C1of2 *)
                            US8_0(v4680)
                        | US7_1(v4682) -> (* C2of2 *)
                            US8_1(v4682)
                    return v4685 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4686 : Async<US8> = _v4678 
            let _v4668 = v4686 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4687 : unit = ()
            let _v4687 =
                async {
                    let! v4663 = v4663 
                    let v4688 : US7 = v4663 
                    let v4694 : US8 =
                        match v4688 with
                        | US7_0(v4689) -> (* C1of2 *)
                            US8_0(v4689)
                        | US7_1(v4691) -> (* C2of2 *)
                            US8_1(v4691)
                    return v4694 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4695 : Async<US8> = _v4687 
            let _v4668 = v4695 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4696 : unit = ()
            let _v4696 =
                async {
                    let! v4663 = v4663 
                    let v4697 : US7 = v4663 
                    let v4703 : US8 =
                        match v4697 with
                        | US7_0(v4698) -> (* C1of2 *)
                            US8_0(v4698)
                        | US7_1(v4700) -> (* C2of2 *)
                            US8_1(v4700)
                    return v4703 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4704 : Async<US8> = _v4696 
            let _v4668 = v4704 
            #endif
#else
            let v4705 : unit = ()
            let _v4705 =
                async {
                    let! v4663 = v4663 
                    let v4706 : US7 = v4663 
                    let v4712 : US8 =
                        match v4706 with
                        | US7_0(v4707) -> (* C1of2 *)
                            US8_0(v4707)
                        | US7_1(v4709) -> (* C2of2 *)
                            US8_1(v4709)
                    return v4712 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4713 : Async<US8> = _v4705 
            let _v4668 = v4713 
            #endif
            let v4714 : Async<US8> = _v4668 
            let v4719 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v4720 : Async<US6> = null |> unbox<Async<US6>>
            let _v4719 = v4720 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v4723 : Async<US6> = null |> unbox<Async<US6>>
            let _v4719 = v4723 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v4726 : Async<US6> = null |> unbox<Async<US6>>
            let _v4719 = v4726 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v4729 : unit = ()
            let _v4729 =
                async {
                    let! v4714 = v4714 
                    let v4730 : US8 = v4714 
                    let v4854 : US6 =
                        match v4730 with
                        | US8_1(v4733) -> (* Error *)
                            let v4734 : string = $"%A{v4733}"
                            let v4737 : string = "System.TimeoutException"
                            let v4738 : bool = v4734.Contains v4737 
                            if v4738 then
                                let v4741 : unit = ()
                                let v4742 : (unit -> unit) = closure16(v0)
                                let v4743 : unit = (fun () -> v4742 (); v4741) ()
                                US6_1
                            else
                                let v4784 : unit = ()
                                let v4785 : (unit -> unit) = closure17(v0, v4733)
                                let v4786 : unit = (fun () -> v4785 (); v4784) ()
                                US6_1
                        | US8_0(v4731) -> (* Ok *)
                            US6_0(v4731)
                    return v4854 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4855 : Async<US6> = _v4729 
            let _v4719 = v4855 
            #endif
#if FABLE_COMPILER_PYTHON
            let v4856 : unit = ()
            let _v4856 =
                async {
                    let! v4714 = v4714 
                    let v4857 : US8 = v4714 
                    let v4981 : US6 =
                        match v4857 with
                        | US8_1(v4860) -> (* Error *)
                            let v4861 : string = $"%A{v4860}"
                            let v4864 : string = "System.TimeoutException"
                            let v4865 : bool = v4861.Contains v4864 
                            if v4865 then
                                let v4868 : unit = ()
                                let v4869 : (unit -> unit) = closure16(v0)
                                let v4870 : unit = (fun () -> v4869 (); v4868) ()
                                US6_1
                            else
                                let v4911 : unit = ()
                                let v4912 : (unit -> unit) = closure17(v0, v4860)
                                let v4913 : unit = (fun () -> v4912 (); v4911) ()
                                US6_1
                        | US8_0(v4858) -> (* Ok *)
                            US6_0(v4858)
                    return v4981 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4982 : Async<US6> = _v4856 
            let _v4719 = v4982 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v4983 : unit = ()
            let _v4983 =
                async {
                    let! v4714 = v4714 
                    let v4984 : US8 = v4714 
                    let v5108 : US6 =
                        match v4984 with
                        | US8_1(v4987) -> (* Error *)
                            let v4988 : string = $"%A{v4987}"
                            let v4991 : string = "System.TimeoutException"
                            let v4992 : bool = v4988.Contains v4991 
                            if v4992 then
                                let v4995 : unit = ()
                                let v4996 : (unit -> unit) = closure16(v0)
                                let v4997 : unit = (fun () -> v4996 (); v4995) ()
                                US6_1
                            else
                                let v5038 : unit = ()
                                let v5039 : (unit -> unit) = closure17(v0, v4987)
                                let v5040 : unit = (fun () -> v5039 (); v5038) ()
                                US6_1
                        | US8_0(v4985) -> (* Ok *)
                            US6_0(v4985)
                    return v5108 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5109 : Async<US6> = _v4983 
            let _v4719 = v5109 
            #endif
#else
            let v5110 : unit = ()
            let _v5110 =
                async {
                    let! v4714 = v4714 
                    let v5111 : US8 = v4714 
                    let v5235 : US6 =
                        match v5111 with
                        | US8_1(v5114) -> (* Error *)
                            let v5115 : string = $"%A{v5114}"
                            let v5118 : string = "System.TimeoutException"
                            let v5119 : bool = v5115.Contains v5118 
                            if v5119 then
                                let v5122 : unit = ()
                                let v5123 : (unit -> unit) = closure16(v0)
                                let v5124 : unit = (fun () -> v5123 (); v5122) ()
                                US6_1
                            else
                                let v5165 : unit = ()
                                let v5166 : (unit -> unit) = closure17(v0, v5114)
                                let v5167 : unit = (fun () -> v5166 (); v5165) ()
                                US6_1
                        | US8_0(v5112) -> (* Ok *)
                            US6_0(v5112)
                    return v5235 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5236 : Async<US6> = _v5110 
            let _v4719 = v5236 
            #endif
            let v5237 : Async<US6> = _v4719 
            return! v5237 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v5242 : Async<US6> = _v4498 
    let _v2998 = v5242 
    #endif
#else
    let v5243 : unit = ()
    let _v5243 =
        async {
            let v5244 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5245 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5245 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5246 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5246 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5247 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5247 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5248 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5248 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5249 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5249 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5250 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5250 
            #endif
#else
            let v5251 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v5244 = v5251 
            #endif
            let v5252 : Async<Async<bool>> = _v5244 
            let! v5252 = v5252 
            let v5257 : Async<bool> = v5252 
            let v5258 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5259 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5260 : Async<Choice<bool, exn>> = v5259 v5257
            let _v5258 = v5260 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5261 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5262 : Async<Choice<bool, exn>> = v5261 v5257
            let _v5258 = v5262 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5263 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5264 : Async<Choice<bool, exn>> = v5263 v5257
            let _v5258 = v5264 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5265 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5266 : Async<Choice<bool, exn>> = v5265 v5257
            let _v5258 = v5266 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5267 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5268 : Async<Choice<bool, exn>> = v5267 v5257
            let _v5258 = v5268 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5269 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5270 : Async<Choice<bool, exn>> = v5269 v5257
            let _v5258 = v5270 
            #endif
#else
            let v5271 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v5272 : Async<Choice<bool, exn>> = v5271 v5257
            let _v5258 = v5272 
            #endif
            let v5273 : Async<Choice<bool, exn>> = _v5258 
            let v5278 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5279 : Async<US7> = null |> unbox<Async<US7>>
            let _v5278 = v5279 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5282 : Async<US7> = null |> unbox<Async<US7>>
            let _v5278 = v5282 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5285 : Async<US7> = null |> unbox<Async<US7>>
            let _v5278 = v5285 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5288 : unit = ()
            let _v5288 =
                async {
                    let! v5273 = v5273 
                    let v5289 : Choice<bool, exn> = v5273 
                    let v5290 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5291 : US7 = null |> unbox<US7>
                    let _v5290 = v5291 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5294 : US7 = null |> unbox<US7>
                    let _v5290 = v5294 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5297 : US7 = null |> unbox<US7>
                    let _v5290 = v5297 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5300 : US7 = null |> unbox<US7>
                    let _v5290 = v5300 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5303 : US7 = null |> unbox<US7>
                    let _v5290 = v5303 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5306 : (bool -> US7) = method21()
                    let v5307 : (exn -> US7) = method22()
                    let v5308 : US7 = match v5289 with Choice1Of2 x -> v5306 x | Choice2Of2 x -> v5307 x
                    let _v5290 = v5308 
                    #endif
#else
                    let v5309 : (bool -> US7) = method21()
                    let v5310 : (exn -> US7) = method22()
                    let v5311 : US7 = match v5289 with Choice1Of2 x -> v5309 x | Choice2Of2 x -> v5310 x
                    let _v5290 = v5311 
                    #endif
                    let v5312 : US7 = _v5290 
                    return v5312 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5317 : Async<US7> = _v5288 
            let _v5278 = v5317 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5318 : unit = ()
            let _v5318 =
                async {
                    let! v5273 = v5273 
                    let v5319 : Choice<bool, exn> = v5273 
                    let v5320 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5321 : US7 = null |> unbox<US7>
                    let _v5320 = v5321 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5324 : US7 = null |> unbox<US7>
                    let _v5320 = v5324 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5327 : US7 = null |> unbox<US7>
                    let _v5320 = v5327 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5330 : US7 = null |> unbox<US7>
                    let _v5320 = v5330 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5333 : US7 = null |> unbox<US7>
                    let _v5320 = v5333 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5336 : (bool -> US7) = method21()
                    let v5337 : (exn -> US7) = method22()
                    let v5338 : US7 = match v5319 with Choice1Of2 x -> v5336 x | Choice2Of2 x -> v5337 x
                    let _v5320 = v5338 
                    #endif
#else
                    let v5339 : (bool -> US7) = method21()
                    let v5340 : (exn -> US7) = method22()
                    let v5341 : US7 = match v5319 with Choice1Of2 x -> v5339 x | Choice2Of2 x -> v5340 x
                    let _v5320 = v5341 
                    #endif
                    let v5342 : US7 = _v5320 
                    return v5342 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5347 : Async<US7> = _v5318 
            let _v5278 = v5347 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5348 : unit = ()
            let _v5348 =
                async {
                    let! v5273 = v5273 
                    let v5349 : Choice<bool, exn> = v5273 
                    let v5350 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5351 : US7 = null |> unbox<US7>
                    let _v5350 = v5351 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5354 : US7 = null |> unbox<US7>
                    let _v5350 = v5354 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5357 : US7 = null |> unbox<US7>
                    let _v5350 = v5357 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5360 : US7 = null |> unbox<US7>
                    let _v5350 = v5360 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5363 : US7 = null |> unbox<US7>
                    let _v5350 = v5363 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5366 : (bool -> US7) = method21()
                    let v5367 : (exn -> US7) = method22()
                    let v5368 : US7 = match v5349 with Choice1Of2 x -> v5366 x | Choice2Of2 x -> v5367 x
                    let _v5350 = v5368 
                    #endif
#else
                    let v5369 : (bool -> US7) = method21()
                    let v5370 : (exn -> US7) = method22()
                    let v5371 : US7 = match v5349 with Choice1Of2 x -> v5369 x | Choice2Of2 x -> v5370 x
                    let _v5350 = v5371 
                    #endif
                    let v5372 : US7 = _v5350 
                    return v5372 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5377 : Async<US7> = _v5348 
            let _v5278 = v5377 
            #endif
#else
            let v5378 : unit = ()
            let _v5378 =
                async {
                    let! v5273 = v5273 
                    let v5379 : Choice<bool, exn> = v5273 
                    let v5380 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v5381 : US7 = null |> unbox<US7>
                    let _v5380 = v5381 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v5384 : US7 = null |> unbox<US7>
                    let _v5380 = v5384 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v5387 : US7 = null |> unbox<US7>
                    let _v5380 = v5387 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v5390 : US7 = null |> unbox<US7>
                    let _v5380 = v5390 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v5393 : US7 = null |> unbox<US7>
                    let _v5380 = v5393 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v5396 : (bool -> US7) = method21()
                    let v5397 : (exn -> US7) = method22()
                    let v5398 : US7 = match v5379 with Choice1Of2 x -> v5396 x | Choice2Of2 x -> v5397 x
                    let _v5380 = v5398 
                    #endif
#else
                    let v5399 : (bool -> US7) = method21()
                    let v5400 : (exn -> US7) = method22()
                    let v5401 : US7 = match v5379 with Choice1Of2 x -> v5399 x | Choice2Of2 x -> v5400 x
                    let _v5380 = v5401 
                    #endif
                    let v5402 : US7 = _v5380 
                    return v5402 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5407 : Async<US7> = _v5378 
            let _v5278 = v5407 
            #endif
            let v5408 : Async<US7> = _v5278 
            let v5413 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5414 : Async<US8> = null |> unbox<Async<US8>>
            let _v5413 = v5414 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5417 : Async<US8> = null |> unbox<Async<US8>>
            let _v5413 = v5417 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5420 : Async<US8> = null |> unbox<Async<US8>>
            let _v5413 = v5420 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5423 : unit = ()
            let _v5423 =
                async {
                    let! v5408 = v5408 
                    let v5424 : US7 = v5408 
                    let v5430 : US8 =
                        match v5424 with
                        | US7_0(v5425) -> (* C1of2 *)
                            US8_0(v5425)
                        | US7_1(v5427) -> (* C2of2 *)
                            US8_1(v5427)
                    return v5430 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5431 : Async<US8> = _v5423 
            let _v5413 = v5431 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5432 : unit = ()
            let _v5432 =
                async {
                    let! v5408 = v5408 
                    let v5433 : US7 = v5408 
                    let v5439 : US8 =
                        match v5433 with
                        | US7_0(v5434) -> (* C1of2 *)
                            US8_0(v5434)
                        | US7_1(v5436) -> (* C2of2 *)
                            US8_1(v5436)
                    return v5439 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5440 : Async<US8> = _v5432 
            let _v5413 = v5440 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5441 : unit = ()
            let _v5441 =
                async {
                    let! v5408 = v5408 
                    let v5442 : US7 = v5408 
                    let v5448 : US8 =
                        match v5442 with
                        | US7_0(v5443) -> (* C1of2 *)
                            US8_0(v5443)
                        | US7_1(v5445) -> (* C2of2 *)
                            US8_1(v5445)
                    return v5448 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5449 : Async<US8> = _v5441 
            let _v5413 = v5449 
            #endif
#else
            let v5450 : unit = ()
            let _v5450 =
                async {
                    let! v5408 = v5408 
                    let v5451 : US7 = v5408 
                    let v5457 : US8 =
                        match v5451 with
                        | US7_0(v5452) -> (* C1of2 *)
                            US8_0(v5452)
                        | US7_1(v5454) -> (* C2of2 *)
                            US8_1(v5454)
                    return v5457 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5458 : Async<US8> = _v5450 
            let _v5413 = v5458 
            #endif
            let v5459 : Async<US8> = _v5413 
            let v5464 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v5465 : Async<US6> = null |> unbox<Async<US6>>
            let _v5464 = v5465 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v5468 : Async<US6> = null |> unbox<Async<US6>>
            let _v5464 = v5468 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v5471 : Async<US6> = null |> unbox<Async<US6>>
            let _v5464 = v5471 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v5474 : unit = ()
            let _v5474 =
                async {
                    let! v5459 = v5459 
                    let v5475 : US8 = v5459 
                    let v5599 : US6 =
                        match v5475 with
                        | US8_1(v5478) -> (* Error *)
                            let v5479 : string = $"%A{v5478}"
                            let v5482 : string = "System.TimeoutException"
                            let v5483 : bool = v5479.Contains v5482 
                            if v5483 then
                                let v5486 : unit = ()
                                let v5487 : (unit -> unit) = closure16(v0)
                                let v5488 : unit = (fun () -> v5487 (); v5486) ()
                                US6_1
                            else
                                let v5529 : unit = ()
                                let v5530 : (unit -> unit) = closure17(v0, v5478)
                                let v5531 : unit = (fun () -> v5530 (); v5529) ()
                                US6_1
                        | US8_0(v5476) -> (* Ok *)
                            US6_0(v5476)
                    return v5599 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5600 : Async<US6> = _v5474 
            let _v5464 = v5600 
            #endif
#if FABLE_COMPILER_PYTHON
            let v5601 : unit = ()
            let _v5601 =
                async {
                    let! v5459 = v5459 
                    let v5602 : US8 = v5459 
                    let v5726 : US6 =
                        match v5602 with
                        | US8_1(v5605) -> (* Error *)
                            let v5606 : string = $"%A{v5605}"
                            let v5609 : string = "System.TimeoutException"
                            let v5610 : bool = v5606.Contains v5609 
                            if v5610 then
                                let v5613 : unit = ()
                                let v5614 : (unit -> unit) = closure16(v0)
                                let v5615 : unit = (fun () -> v5614 (); v5613) ()
                                US6_1
                            else
                                let v5656 : unit = ()
                                let v5657 : (unit -> unit) = closure17(v0, v5605)
                                let v5658 : unit = (fun () -> v5657 (); v5656) ()
                                US6_1
                        | US8_0(v5603) -> (* Ok *)
                            US6_0(v5603)
                    return v5726 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5727 : Async<US6> = _v5601 
            let _v5464 = v5727 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v5728 : unit = ()
            let _v5728 =
                async {
                    let! v5459 = v5459 
                    let v5729 : US8 = v5459 
                    let v5853 : US6 =
                        match v5729 with
                        | US8_1(v5732) -> (* Error *)
                            let v5733 : string = $"%A{v5732}"
                            let v5736 : string = "System.TimeoutException"
                            let v5737 : bool = v5733.Contains v5736 
                            if v5737 then
                                let v5740 : unit = ()
                                let v5741 : (unit -> unit) = closure16(v0)
                                let v5742 : unit = (fun () -> v5741 (); v5740) ()
                                US6_1
                            else
                                let v5783 : unit = ()
                                let v5784 : (unit -> unit) = closure17(v0, v5732)
                                let v5785 : unit = (fun () -> v5784 (); v5783) ()
                                US6_1
                        | US8_0(v5730) -> (* Ok *)
                            US6_0(v5730)
                    return v5853 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5854 : Async<US6> = _v5728 
            let _v5464 = v5854 
            #endif
#else
            let v5855 : unit = ()
            let _v5855 =
                async {
                    let! v5459 = v5459 
                    let v5856 : US8 = v5459 
                    let v5980 : US6 =
                        match v5856 with
                        | US8_1(v5859) -> (* Error *)
                            let v5860 : string = $"%A{v5859}"
                            let v5863 : string = "System.TimeoutException"
                            let v5864 : bool = v5860.Contains v5863 
                            if v5864 then
                                let v5867 : unit = ()
                                let v5868 : (unit -> unit) = closure16(v0)
                                let v5869 : unit = (fun () -> v5868 (); v5867) ()
                                US6_1
                            else
                                let v5910 : unit = ()
                                let v5911 : (unit -> unit) = closure17(v0, v5859)
                                let v5912 : unit = (fun () -> v5911 (); v5910) ()
                                US6_1
                        | US8_0(v5857) -> (* Ok *)
                            US6_0(v5857)
                    return v5980 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5981 : Async<US6> = _v5855 
            let _v5464 = v5981 
            #endif
            let v5982 : Async<US6> = _v5464 
            return! v5982 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v5987 : Async<US6> = _v5243 
    let _v2998 = v5987 
    #endif
    let v5988 : Async<US6> = _v2998 
    let _v2 = v5988 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5993 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5994 : Async<US6> = null |> unbox<Async<US6>>
    let _v5993 = v5994 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5997 : Async<US6> = null |> unbox<Async<US6>>
    let _v5993 = v5997 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6000 : Async<US6> = null |> unbox<Async<US6>>
    let _v5993 = v6000 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v6003 : unit = ()
    let _v6003 =
        async {
            let v6004 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6005 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6005 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6006 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6006 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6007 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6007 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6008 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6008 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6009 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6009 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6010 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6010 
            #endif
#else
            let v6011 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6004 = v6011 
            #endif
            let v6012 : Async<Async<bool>> = _v6004 
            let! v6012 = v6012 
            let v6017 : Async<bool> = v6012 
            let v6018 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6019 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6020 : Async<Choice<bool, exn>> = v6019 v6017
            let _v6018 = v6020 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6021 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6022 : Async<Choice<bool, exn>> = v6021 v6017
            let _v6018 = v6022 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6023 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6024 : Async<Choice<bool, exn>> = v6023 v6017
            let _v6018 = v6024 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6025 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6026 : Async<Choice<bool, exn>> = v6025 v6017
            let _v6018 = v6026 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6027 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6028 : Async<Choice<bool, exn>> = v6027 v6017
            let _v6018 = v6028 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6029 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6030 : Async<Choice<bool, exn>> = v6029 v6017
            let _v6018 = v6030 
            #endif
#else
            let v6031 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6032 : Async<Choice<bool, exn>> = v6031 v6017
            let _v6018 = v6032 
            #endif
            let v6033 : Async<Choice<bool, exn>> = _v6018 
            let v6038 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6039 : Async<US7> = null |> unbox<Async<US7>>
            let _v6038 = v6039 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6042 : Async<US7> = null |> unbox<Async<US7>>
            let _v6038 = v6042 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6045 : Async<US7> = null |> unbox<Async<US7>>
            let _v6038 = v6045 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6048 : unit = ()
            let _v6048 =
                async {
                    let! v6033 = v6033 
                    let v6049 : Choice<bool, exn> = v6033 
                    let v6050 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6051 : US7 = null |> unbox<US7>
                    let _v6050 = v6051 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6054 : US7 = null |> unbox<US7>
                    let _v6050 = v6054 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6057 : US7 = null |> unbox<US7>
                    let _v6050 = v6057 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6060 : US7 = null |> unbox<US7>
                    let _v6050 = v6060 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6063 : US7 = null |> unbox<US7>
                    let _v6050 = v6063 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6066 : (bool -> US7) = method21()
                    let v6067 : (exn -> US7) = method22()
                    let v6068 : US7 = match v6049 with Choice1Of2 x -> v6066 x | Choice2Of2 x -> v6067 x
                    let _v6050 = v6068 
                    #endif
#else
                    let v6069 : (bool -> US7) = method21()
                    let v6070 : (exn -> US7) = method22()
                    let v6071 : US7 = match v6049 with Choice1Of2 x -> v6069 x | Choice2Of2 x -> v6070 x
                    let _v6050 = v6071 
                    #endif
                    let v6072 : US7 = _v6050 
                    return v6072 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6077 : Async<US7> = _v6048 
            let _v6038 = v6077 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6078 : unit = ()
            let _v6078 =
                async {
                    let! v6033 = v6033 
                    let v6079 : Choice<bool, exn> = v6033 
                    let v6080 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6081 : US7 = null |> unbox<US7>
                    let _v6080 = v6081 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6084 : US7 = null |> unbox<US7>
                    let _v6080 = v6084 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6087 : US7 = null |> unbox<US7>
                    let _v6080 = v6087 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6090 : US7 = null |> unbox<US7>
                    let _v6080 = v6090 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6093 : US7 = null |> unbox<US7>
                    let _v6080 = v6093 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6096 : (bool -> US7) = method21()
                    let v6097 : (exn -> US7) = method22()
                    let v6098 : US7 = match v6079 with Choice1Of2 x -> v6096 x | Choice2Of2 x -> v6097 x
                    let _v6080 = v6098 
                    #endif
#else
                    let v6099 : (bool -> US7) = method21()
                    let v6100 : (exn -> US7) = method22()
                    let v6101 : US7 = match v6079 with Choice1Of2 x -> v6099 x | Choice2Of2 x -> v6100 x
                    let _v6080 = v6101 
                    #endif
                    let v6102 : US7 = _v6080 
                    return v6102 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6107 : Async<US7> = _v6078 
            let _v6038 = v6107 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6108 : unit = ()
            let _v6108 =
                async {
                    let! v6033 = v6033 
                    let v6109 : Choice<bool, exn> = v6033 
                    let v6110 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6111 : US7 = null |> unbox<US7>
                    let _v6110 = v6111 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6114 : US7 = null |> unbox<US7>
                    let _v6110 = v6114 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6117 : US7 = null |> unbox<US7>
                    let _v6110 = v6117 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6120 : US7 = null |> unbox<US7>
                    let _v6110 = v6120 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6123 : US7 = null |> unbox<US7>
                    let _v6110 = v6123 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6126 : (bool -> US7) = method21()
                    let v6127 : (exn -> US7) = method22()
                    let v6128 : US7 = match v6109 with Choice1Of2 x -> v6126 x | Choice2Of2 x -> v6127 x
                    let _v6110 = v6128 
                    #endif
#else
                    let v6129 : (bool -> US7) = method21()
                    let v6130 : (exn -> US7) = method22()
                    let v6131 : US7 = match v6109 with Choice1Of2 x -> v6129 x | Choice2Of2 x -> v6130 x
                    let _v6110 = v6131 
                    #endif
                    let v6132 : US7 = _v6110 
                    return v6132 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6137 : Async<US7> = _v6108 
            let _v6038 = v6137 
            #endif
#else
            let v6138 : unit = ()
            let _v6138 =
                async {
                    let! v6033 = v6033 
                    let v6139 : Choice<bool, exn> = v6033 
                    let v6140 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6141 : US7 = null |> unbox<US7>
                    let _v6140 = v6141 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6144 : US7 = null |> unbox<US7>
                    let _v6140 = v6144 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6147 : US7 = null |> unbox<US7>
                    let _v6140 = v6147 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6150 : US7 = null |> unbox<US7>
                    let _v6140 = v6150 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6153 : US7 = null |> unbox<US7>
                    let _v6140 = v6153 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6156 : (bool -> US7) = method21()
                    let v6157 : (exn -> US7) = method22()
                    let v6158 : US7 = match v6139 with Choice1Of2 x -> v6156 x | Choice2Of2 x -> v6157 x
                    let _v6140 = v6158 
                    #endif
#else
                    let v6159 : (bool -> US7) = method21()
                    let v6160 : (exn -> US7) = method22()
                    let v6161 : US7 = match v6139 with Choice1Of2 x -> v6159 x | Choice2Of2 x -> v6160 x
                    let _v6140 = v6161 
                    #endif
                    let v6162 : US7 = _v6140 
                    return v6162 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6167 : Async<US7> = _v6138 
            let _v6038 = v6167 
            #endif
            let v6168 : Async<US7> = _v6038 
            let v6173 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6174 : Async<US8> = null |> unbox<Async<US8>>
            let _v6173 = v6174 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6177 : Async<US8> = null |> unbox<Async<US8>>
            let _v6173 = v6177 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6180 : Async<US8> = null |> unbox<Async<US8>>
            let _v6173 = v6180 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6183 : unit = ()
            let _v6183 =
                async {
                    let! v6168 = v6168 
                    let v6184 : US7 = v6168 
                    let v6190 : US8 =
                        match v6184 with
                        | US7_0(v6185) -> (* C1of2 *)
                            US8_0(v6185)
                        | US7_1(v6187) -> (* C2of2 *)
                            US8_1(v6187)
                    return v6190 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6191 : Async<US8> = _v6183 
            let _v6173 = v6191 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6192 : unit = ()
            let _v6192 =
                async {
                    let! v6168 = v6168 
                    let v6193 : US7 = v6168 
                    let v6199 : US8 =
                        match v6193 with
                        | US7_0(v6194) -> (* C1of2 *)
                            US8_0(v6194)
                        | US7_1(v6196) -> (* C2of2 *)
                            US8_1(v6196)
                    return v6199 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6200 : Async<US8> = _v6192 
            let _v6173 = v6200 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6201 : unit = ()
            let _v6201 =
                async {
                    let! v6168 = v6168 
                    let v6202 : US7 = v6168 
                    let v6208 : US8 =
                        match v6202 with
                        | US7_0(v6203) -> (* C1of2 *)
                            US8_0(v6203)
                        | US7_1(v6205) -> (* C2of2 *)
                            US8_1(v6205)
                    return v6208 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6209 : Async<US8> = _v6201 
            let _v6173 = v6209 
            #endif
#else
            let v6210 : unit = ()
            let _v6210 =
                async {
                    let! v6168 = v6168 
                    let v6211 : US7 = v6168 
                    let v6217 : US8 =
                        match v6211 with
                        | US7_0(v6212) -> (* C1of2 *)
                            US8_0(v6212)
                        | US7_1(v6214) -> (* C2of2 *)
                            US8_1(v6214)
                    return v6217 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6218 : Async<US8> = _v6210 
            let _v6173 = v6218 
            #endif
            let v6219 : Async<US8> = _v6173 
            let v6224 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6225 : Async<US6> = null |> unbox<Async<US6>>
            let _v6224 = v6225 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6228 : Async<US6> = null |> unbox<Async<US6>>
            let _v6224 = v6228 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6231 : Async<US6> = null |> unbox<Async<US6>>
            let _v6224 = v6231 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6234 : unit = ()
            let _v6234 =
                async {
                    let! v6219 = v6219 
                    let v6235 : US8 = v6219 
                    let v6359 : US6 =
                        match v6235 with
                        | US8_1(v6238) -> (* Error *)
                            let v6239 : string = $"%A{v6238}"
                            let v6242 : string = "System.TimeoutException"
                            let v6243 : bool = v6239.Contains v6242 
                            if v6243 then
                                let v6246 : unit = ()
                                let v6247 : (unit -> unit) = closure16(v0)
                                let v6248 : unit = (fun () -> v6247 (); v6246) ()
                                US6_1
                            else
                                let v6289 : unit = ()
                                let v6290 : (unit -> unit) = closure17(v0, v6238)
                                let v6291 : unit = (fun () -> v6290 (); v6289) ()
                                US6_1
                        | US8_0(v6236) -> (* Ok *)
                            US6_0(v6236)
                    return v6359 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6360 : Async<US6> = _v6234 
            let _v6224 = v6360 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6361 : unit = ()
            let _v6361 =
                async {
                    let! v6219 = v6219 
                    let v6362 : US8 = v6219 
                    let v6486 : US6 =
                        match v6362 with
                        | US8_1(v6365) -> (* Error *)
                            let v6366 : string = $"%A{v6365}"
                            let v6369 : string = "System.TimeoutException"
                            let v6370 : bool = v6366.Contains v6369 
                            if v6370 then
                                let v6373 : unit = ()
                                let v6374 : (unit -> unit) = closure16(v0)
                                let v6375 : unit = (fun () -> v6374 (); v6373) ()
                                US6_1
                            else
                                let v6416 : unit = ()
                                let v6417 : (unit -> unit) = closure17(v0, v6365)
                                let v6418 : unit = (fun () -> v6417 (); v6416) ()
                                US6_1
                        | US8_0(v6363) -> (* Ok *)
                            US6_0(v6363)
                    return v6486 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6487 : Async<US6> = _v6361 
            let _v6224 = v6487 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6488 : unit = ()
            let _v6488 =
                async {
                    let! v6219 = v6219 
                    let v6489 : US8 = v6219 
                    let v6613 : US6 =
                        match v6489 with
                        | US8_1(v6492) -> (* Error *)
                            let v6493 : string = $"%A{v6492}"
                            let v6496 : string = "System.TimeoutException"
                            let v6497 : bool = v6493.Contains v6496 
                            if v6497 then
                                let v6500 : unit = ()
                                let v6501 : (unit -> unit) = closure16(v0)
                                let v6502 : unit = (fun () -> v6501 (); v6500) ()
                                US6_1
                            else
                                let v6543 : unit = ()
                                let v6544 : (unit -> unit) = closure17(v0, v6492)
                                let v6545 : unit = (fun () -> v6544 (); v6543) ()
                                US6_1
                        | US8_0(v6490) -> (* Ok *)
                            US6_0(v6490)
                    return v6613 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6614 : Async<US6> = _v6488 
            let _v6224 = v6614 
            #endif
#else
            let v6615 : unit = ()
            let _v6615 =
                async {
                    let! v6219 = v6219 
                    let v6616 : US8 = v6219 
                    let v6740 : US6 =
                        match v6616 with
                        | US8_1(v6619) -> (* Error *)
                            let v6620 : string = $"%A{v6619}"
                            let v6623 : string = "System.TimeoutException"
                            let v6624 : bool = v6620.Contains v6623 
                            if v6624 then
                                let v6627 : unit = ()
                                let v6628 : (unit -> unit) = closure16(v0)
                                let v6629 : unit = (fun () -> v6628 (); v6627) ()
                                US6_1
                            else
                                let v6670 : unit = ()
                                let v6671 : (unit -> unit) = closure17(v0, v6619)
                                let v6672 : unit = (fun () -> v6671 (); v6670) ()
                                US6_1
                        | US8_0(v6617) -> (* Ok *)
                            US6_0(v6617)
                    return v6740 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6741 : Async<US6> = _v6615 
            let _v6224 = v6741 
            #endif
            let v6742 : Async<US6> = _v6224 
            return! v6742 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v6747 : Async<US6> = _v6003 
    let _v5993 = v6747 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6748 : unit = ()
    let _v6748 =
        async {
            let v6749 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6750 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6750 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6751 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6751 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6752 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6752 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6753 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6753 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6754 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6754 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6755 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6755 
            #endif
#else
            let v6756 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v6749 = v6756 
            #endif
            let v6757 : Async<Async<bool>> = _v6749 
            let! v6757 = v6757 
            let v6762 : Async<bool> = v6757 
            let v6763 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6764 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6765 : Async<Choice<bool, exn>> = v6764 v6762
            let _v6763 = v6765 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6766 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6767 : Async<Choice<bool, exn>> = v6766 v6762
            let _v6763 = v6767 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6768 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6769 : Async<Choice<bool, exn>> = v6768 v6762
            let _v6763 = v6769 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6770 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6771 : Async<Choice<bool, exn>> = v6770 v6762
            let _v6763 = v6771 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6772 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6773 : Async<Choice<bool, exn>> = v6772 v6762
            let _v6763 = v6773 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6774 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6775 : Async<Choice<bool, exn>> = v6774 v6762
            let _v6763 = v6775 
            #endif
#else
            let v6776 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v6777 : Async<Choice<bool, exn>> = v6776 v6762
            let _v6763 = v6777 
            #endif
            let v6778 : Async<Choice<bool, exn>> = _v6763 
            let v6783 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6784 : Async<US7> = null |> unbox<Async<US7>>
            let _v6783 = v6784 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6787 : Async<US7> = null |> unbox<Async<US7>>
            let _v6783 = v6787 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6790 : Async<US7> = null |> unbox<Async<US7>>
            let _v6783 = v6790 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6793 : unit = ()
            let _v6793 =
                async {
                    let! v6778 = v6778 
                    let v6794 : Choice<bool, exn> = v6778 
                    let v6795 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6796 : US7 = null |> unbox<US7>
                    let _v6795 = v6796 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6799 : US7 = null |> unbox<US7>
                    let _v6795 = v6799 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6802 : US7 = null |> unbox<US7>
                    let _v6795 = v6802 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6805 : US7 = null |> unbox<US7>
                    let _v6795 = v6805 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6808 : US7 = null |> unbox<US7>
                    let _v6795 = v6808 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6811 : (bool -> US7) = method21()
                    let v6812 : (exn -> US7) = method22()
                    let v6813 : US7 = match v6794 with Choice1Of2 x -> v6811 x | Choice2Of2 x -> v6812 x
                    let _v6795 = v6813 
                    #endif
#else
                    let v6814 : (bool -> US7) = method21()
                    let v6815 : (exn -> US7) = method22()
                    let v6816 : US7 = match v6794 with Choice1Of2 x -> v6814 x | Choice2Of2 x -> v6815 x
                    let _v6795 = v6816 
                    #endif
                    let v6817 : US7 = _v6795 
                    return v6817 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6822 : Async<US7> = _v6793 
            let _v6783 = v6822 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6823 : unit = ()
            let _v6823 =
                async {
                    let! v6778 = v6778 
                    let v6824 : Choice<bool, exn> = v6778 
                    let v6825 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v6826 : US7 = null |> unbox<US7>
                    let _v6825 = v6826 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v6829 : US7 = null |> unbox<US7>
                    let _v6825 = v6829 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v6832 : US7 = null |> unbox<US7>
                    let _v6825 = v6832 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v6835 : US7 = null |> unbox<US7>
                    let _v6825 = v6835 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v6838 : US7 = null |> unbox<US7>
                    let _v6825 = v6838 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v6841 : (bool -> US7) = method21()
                    let v6842 : (exn -> US7) = method22()
                    let v6843 : US7 = match v6824 with Choice1Of2 x -> v6841 x | Choice2Of2 x -> v6842 x
                    let _v6825 = v6843 
                    #endif
#else
                    let v6844 : (bool -> US7) = method21()
                    let v6845 : (exn -> US7) = method22()
                    let v6846 : US7 = match v6824 with Choice1Of2 x -> v6844 x | Choice2Of2 x -> v6845 x
                    let _v6825 = v6846 
                    #endif
                    let v6847 : US7 = _v6825 
                    return v6847 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6852 : Async<US7> = _v6823 
            let _v6783 = v6852 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6853 : unit = ()
            let _v6853 =
                async {
                    let! v6778 = v6778 
                    let v6854 : Choice<bool, exn> = v6778 
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
                    let v6871 : (bool -> US7) = method21()
                    let v6872 : (exn -> US7) = method22()
                    let v6873 : US7 = match v6854 with Choice1Of2 x -> v6871 x | Choice2Of2 x -> v6872 x
                    let _v6855 = v6873 
                    #endif
#else
                    let v6874 : (bool -> US7) = method21()
                    let v6875 : (exn -> US7) = method22()
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
            let _v6783 = v6882 
            #endif
#else
            let v6883 : unit = ()
            let _v6883 =
                async {
                    let! v6778 = v6778 
                    let v6884 : Choice<bool, exn> = v6778 
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
                    let v6901 : (bool -> US7) = method21()
                    let v6902 : (exn -> US7) = method22()
                    let v6903 : US7 = match v6884 with Choice1Of2 x -> v6901 x | Choice2Of2 x -> v6902 x
                    let _v6885 = v6903 
                    #endif
#else
                    let v6904 : (bool -> US7) = method21()
                    let v6905 : (exn -> US7) = method22()
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
            let _v6783 = v6912 
            #endif
            let v6913 : Async<US7> = _v6783 
            let v6918 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6919 : Async<US8> = null |> unbox<Async<US8>>
            let _v6918 = v6919 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6922 : Async<US8> = null |> unbox<Async<US8>>
            let _v6918 = v6922 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6925 : Async<US8> = null |> unbox<Async<US8>>
            let _v6918 = v6925 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6928 : unit = ()
            let _v6928 =
                async {
                    let! v6913 = v6913 
                    let v6929 : US7 = v6913 
                    let v6935 : US8 =
                        match v6929 with
                        | US7_0(v6930) -> (* C1of2 *)
                            US8_0(v6930)
                        | US7_1(v6932) -> (* C2of2 *)
                            US8_1(v6932)
                    return v6935 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6936 : Async<US8> = _v6928 
            let _v6918 = v6936 
            #endif
#if FABLE_COMPILER_PYTHON
            let v6937 : unit = ()
            let _v6937 =
                async {
                    let! v6913 = v6913 
                    let v6938 : US7 = v6913 
                    let v6944 : US8 =
                        match v6938 with
                        | US7_0(v6939) -> (* C1of2 *)
                            US8_0(v6939)
                        | US7_1(v6941) -> (* C2of2 *)
                            US8_1(v6941)
                    return v6944 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6945 : Async<US8> = _v6937 
            let _v6918 = v6945 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v6946 : unit = ()
            let _v6946 =
                async {
                    let! v6913 = v6913 
                    let v6947 : US7 = v6913 
                    let v6953 : US8 =
                        match v6947 with
                        | US7_0(v6948) -> (* C1of2 *)
                            US8_0(v6948)
                        | US7_1(v6950) -> (* C2of2 *)
                            US8_1(v6950)
                    return v6953 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6954 : Async<US8> = _v6946 
            let _v6918 = v6954 
            #endif
#else
            let v6955 : unit = ()
            let _v6955 =
                async {
                    let! v6913 = v6913 
                    let v6956 : US7 = v6913 
                    let v6962 : US8 =
                        match v6956 with
                        | US7_0(v6957) -> (* C1of2 *)
                            US8_0(v6957)
                        | US7_1(v6959) -> (* C2of2 *)
                            US8_1(v6959)
                    return v6962 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v6963 : Async<US8> = _v6955 
            let _v6918 = v6963 
            #endif
            let v6964 : Async<US8> = _v6918 
            let v6969 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v6970 : Async<US6> = null |> unbox<Async<US6>>
            let _v6969 = v6970 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v6973 : Async<US6> = null |> unbox<Async<US6>>
            let _v6969 = v6973 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v6976 : Async<US6> = null |> unbox<Async<US6>>
            let _v6969 = v6976 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v6979 : unit = ()
            let _v6979 =
                async {
                    let! v6964 = v6964 
                    let v6980 : US8 = v6964 
                    let v7104 : US6 =
                        match v6980 with
                        | US8_1(v6983) -> (* Error *)
                            let v6984 : string = $"%A{v6983}"
                            let v6987 : string = "System.TimeoutException"
                            let v6988 : bool = v6984.Contains v6987 
                            if v6988 then
                                let v6991 : unit = ()
                                let v6992 : (unit -> unit) = closure16(v0)
                                let v6993 : unit = (fun () -> v6992 (); v6991) ()
                                US6_1
                            else
                                let v7034 : unit = ()
                                let v7035 : (unit -> unit) = closure17(v0, v6983)
                                let v7036 : unit = (fun () -> v7035 (); v7034) ()
                                US6_1
                        | US8_0(v6981) -> (* Ok *)
                            US6_0(v6981)
                    return v7104 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7105 : Async<US6> = _v6979 
            let _v6969 = v7105 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7106 : unit = ()
            let _v7106 =
                async {
                    let! v6964 = v6964 
                    let v7107 : US8 = v6964 
                    let v7231 : US6 =
                        match v7107 with
                        | US8_1(v7110) -> (* Error *)
                            let v7111 : string = $"%A{v7110}"
                            let v7114 : string = "System.TimeoutException"
                            let v7115 : bool = v7111.Contains v7114 
                            if v7115 then
                                let v7118 : unit = ()
                                let v7119 : (unit -> unit) = closure16(v0)
                                let v7120 : unit = (fun () -> v7119 (); v7118) ()
                                US6_1
                            else
                                let v7161 : unit = ()
                                let v7162 : (unit -> unit) = closure17(v0, v7110)
                                let v7163 : unit = (fun () -> v7162 (); v7161) ()
                                US6_1
                        | US8_0(v7108) -> (* Ok *)
                            US6_0(v7108)
                    return v7231 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7232 : Async<US6> = _v7106 
            let _v6969 = v7232 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7233 : unit = ()
            let _v7233 =
                async {
                    let! v6964 = v6964 
                    let v7234 : US8 = v6964 
                    let v7358 : US6 =
                        match v7234 with
                        | US8_1(v7237) -> (* Error *)
                            let v7238 : string = $"%A{v7237}"
                            let v7241 : string = "System.TimeoutException"
                            let v7242 : bool = v7238.Contains v7241 
                            if v7242 then
                                let v7245 : unit = ()
                                let v7246 : (unit -> unit) = closure16(v0)
                                let v7247 : unit = (fun () -> v7246 (); v7245) ()
                                US6_1
                            else
                                let v7288 : unit = ()
                                let v7289 : (unit -> unit) = closure17(v0, v7237)
                                let v7290 : unit = (fun () -> v7289 (); v7288) ()
                                US6_1
                        | US8_0(v7235) -> (* Ok *)
                            US6_0(v7235)
                    return v7358 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7359 : Async<US6> = _v7233 
            let _v6969 = v7359 
            #endif
#else
            let v7360 : unit = ()
            let _v7360 =
                async {
                    let! v6964 = v6964 
                    let v7361 : US8 = v6964 
                    let v7485 : US6 =
                        match v7361 with
                        | US8_1(v7364) -> (* Error *)
                            let v7365 : string = $"%A{v7364}"
                            let v7368 : string = "System.TimeoutException"
                            let v7369 : bool = v7365.Contains v7368 
                            if v7369 then
                                let v7372 : unit = ()
                                let v7373 : (unit -> unit) = closure16(v0)
                                let v7374 : unit = (fun () -> v7373 (); v7372) ()
                                US6_1
                            else
                                let v7415 : unit = ()
                                let v7416 : (unit -> unit) = closure17(v0, v7364)
                                let v7417 : unit = (fun () -> v7416 (); v7415) ()
                                US6_1
                        | US8_0(v7362) -> (* Ok *)
                            US6_0(v7362)
                    return v7485 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7486 : Async<US6> = _v7360 
            let _v6969 = v7486 
            #endif
            let v7487 : Async<US6> = _v6969 
            return! v7487 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v7492 : Async<US6> = _v6748 
    let _v5993 = v7492 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v7493 : unit = ()
    let _v7493 =
        async {
            let v7494 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7495 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7495 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7496 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7496 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7497 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7497 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7498 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7498 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7499 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7499 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7500 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7500 
            #endif
#else
            let v7501 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v7494 = v7501 
            #endif
            let v7502 : Async<Async<bool>> = _v7494 
            let! v7502 = v7502 
            let v7507 : Async<bool> = v7502 
            let v7508 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7509 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7510 : Async<Choice<bool, exn>> = v7509 v7507
            let _v7508 = v7510 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7511 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7512 : Async<Choice<bool, exn>> = v7511 v7507
            let _v7508 = v7512 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7513 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7514 : Async<Choice<bool, exn>> = v7513 v7507
            let _v7508 = v7514 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7515 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7516 : Async<Choice<bool, exn>> = v7515 v7507
            let _v7508 = v7516 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7517 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7518 : Async<Choice<bool, exn>> = v7517 v7507
            let _v7508 = v7518 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7519 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7520 : Async<Choice<bool, exn>> = v7519 v7507
            let _v7508 = v7520 
            #endif
#else
            let v7521 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v7522 : Async<Choice<bool, exn>> = v7521 v7507
            let _v7508 = v7522 
            #endif
            let v7523 : Async<Choice<bool, exn>> = _v7508 
            let v7528 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7529 : Async<US7> = null |> unbox<Async<US7>>
            let _v7528 = v7529 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7532 : Async<US7> = null |> unbox<Async<US7>>
            let _v7528 = v7532 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7535 : Async<US7> = null |> unbox<Async<US7>>
            let _v7528 = v7535 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7538 : unit = ()
            let _v7538 =
                async {
                    let! v7523 = v7523 
                    let v7539 : Choice<bool, exn> = v7523 
                    let v7540 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7541 : US7 = null |> unbox<US7>
                    let _v7540 = v7541 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7544 : US7 = null |> unbox<US7>
                    let _v7540 = v7544 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7547 : US7 = null |> unbox<US7>
                    let _v7540 = v7547 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7550 : US7 = null |> unbox<US7>
                    let _v7540 = v7550 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7553 : US7 = null |> unbox<US7>
                    let _v7540 = v7553 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7556 : (bool -> US7) = method21()
                    let v7557 : (exn -> US7) = method22()
                    let v7558 : US7 = match v7539 with Choice1Of2 x -> v7556 x | Choice2Of2 x -> v7557 x
                    let _v7540 = v7558 
                    #endif
#else
                    let v7559 : (bool -> US7) = method21()
                    let v7560 : (exn -> US7) = method22()
                    let v7561 : US7 = match v7539 with Choice1Of2 x -> v7559 x | Choice2Of2 x -> v7560 x
                    let _v7540 = v7561 
                    #endif
                    let v7562 : US7 = _v7540 
                    return v7562 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7567 : Async<US7> = _v7538 
            let _v7528 = v7567 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7568 : unit = ()
            let _v7568 =
                async {
                    let! v7523 = v7523 
                    let v7569 : Choice<bool, exn> = v7523 
                    let v7570 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7571 : US7 = null |> unbox<US7>
                    let _v7570 = v7571 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7574 : US7 = null |> unbox<US7>
                    let _v7570 = v7574 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7577 : US7 = null |> unbox<US7>
                    let _v7570 = v7577 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7580 : US7 = null |> unbox<US7>
                    let _v7570 = v7580 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7583 : US7 = null |> unbox<US7>
                    let _v7570 = v7583 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7586 : (bool -> US7) = method21()
                    let v7587 : (exn -> US7) = method22()
                    let v7588 : US7 = match v7569 with Choice1Of2 x -> v7586 x | Choice2Of2 x -> v7587 x
                    let _v7570 = v7588 
                    #endif
#else
                    let v7589 : (bool -> US7) = method21()
                    let v7590 : (exn -> US7) = method22()
                    let v7591 : US7 = match v7569 with Choice1Of2 x -> v7589 x | Choice2Of2 x -> v7590 x
                    let _v7570 = v7591 
                    #endif
                    let v7592 : US7 = _v7570 
                    return v7592 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7597 : Async<US7> = _v7568 
            let _v7528 = v7597 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7598 : unit = ()
            let _v7598 =
                async {
                    let! v7523 = v7523 
                    let v7599 : Choice<bool, exn> = v7523 
                    let v7600 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7601 : US7 = null |> unbox<US7>
                    let _v7600 = v7601 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7604 : US7 = null |> unbox<US7>
                    let _v7600 = v7604 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7607 : US7 = null |> unbox<US7>
                    let _v7600 = v7607 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7610 : US7 = null |> unbox<US7>
                    let _v7600 = v7610 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7613 : US7 = null |> unbox<US7>
                    let _v7600 = v7613 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7616 : (bool -> US7) = method21()
                    let v7617 : (exn -> US7) = method22()
                    let v7618 : US7 = match v7599 with Choice1Of2 x -> v7616 x | Choice2Of2 x -> v7617 x
                    let _v7600 = v7618 
                    #endif
#else
                    let v7619 : (bool -> US7) = method21()
                    let v7620 : (exn -> US7) = method22()
                    let v7621 : US7 = match v7599 with Choice1Of2 x -> v7619 x | Choice2Of2 x -> v7620 x
                    let _v7600 = v7621 
                    #endif
                    let v7622 : US7 = _v7600 
                    return v7622 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7627 : Async<US7> = _v7598 
            let _v7528 = v7627 
            #endif
#else
            let v7628 : unit = ()
            let _v7628 =
                async {
                    let! v7523 = v7523 
                    let v7629 : Choice<bool, exn> = v7523 
                    let v7630 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v7631 : US7 = null |> unbox<US7>
                    let _v7630 = v7631 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v7634 : US7 = null |> unbox<US7>
                    let _v7630 = v7634 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v7637 : US7 = null |> unbox<US7>
                    let _v7630 = v7637 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v7640 : US7 = null |> unbox<US7>
                    let _v7630 = v7640 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v7643 : US7 = null |> unbox<US7>
                    let _v7630 = v7643 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v7646 : (bool -> US7) = method21()
                    let v7647 : (exn -> US7) = method22()
                    let v7648 : US7 = match v7629 with Choice1Of2 x -> v7646 x | Choice2Of2 x -> v7647 x
                    let _v7630 = v7648 
                    #endif
#else
                    let v7649 : (bool -> US7) = method21()
                    let v7650 : (exn -> US7) = method22()
                    let v7651 : US7 = match v7629 with Choice1Of2 x -> v7649 x | Choice2Of2 x -> v7650 x
                    let _v7630 = v7651 
                    #endif
                    let v7652 : US7 = _v7630 
                    return v7652 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7657 : Async<US7> = _v7628 
            let _v7528 = v7657 
            #endif
            let v7658 : Async<US7> = _v7528 
            let v7663 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7664 : Async<US8> = null |> unbox<Async<US8>>
            let _v7663 = v7664 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7667 : Async<US8> = null |> unbox<Async<US8>>
            let _v7663 = v7667 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7670 : Async<US8> = null |> unbox<Async<US8>>
            let _v7663 = v7670 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7673 : unit = ()
            let _v7673 =
                async {
                    let! v7658 = v7658 
                    let v7674 : US7 = v7658 
                    let v7680 : US8 =
                        match v7674 with
                        | US7_0(v7675) -> (* C1of2 *)
                            US8_0(v7675)
                        | US7_1(v7677) -> (* C2of2 *)
                            US8_1(v7677)
                    return v7680 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7681 : Async<US8> = _v7673 
            let _v7663 = v7681 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7682 : unit = ()
            let _v7682 =
                async {
                    let! v7658 = v7658 
                    let v7683 : US7 = v7658 
                    let v7689 : US8 =
                        match v7683 with
                        | US7_0(v7684) -> (* C1of2 *)
                            US8_0(v7684)
                        | US7_1(v7686) -> (* C2of2 *)
                            US8_1(v7686)
                    return v7689 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7690 : Async<US8> = _v7682 
            let _v7663 = v7690 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7691 : unit = ()
            let _v7691 =
                async {
                    let! v7658 = v7658 
                    let v7692 : US7 = v7658 
                    let v7698 : US8 =
                        match v7692 with
                        | US7_0(v7693) -> (* C1of2 *)
                            US8_0(v7693)
                        | US7_1(v7695) -> (* C2of2 *)
                            US8_1(v7695)
                    return v7698 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7699 : Async<US8> = _v7691 
            let _v7663 = v7699 
            #endif
#else
            let v7700 : unit = ()
            let _v7700 =
                async {
                    let! v7658 = v7658 
                    let v7701 : US7 = v7658 
                    let v7707 : US8 =
                        match v7701 with
                        | US7_0(v7702) -> (* C1of2 *)
                            US8_0(v7702)
                        | US7_1(v7704) -> (* C2of2 *)
                            US8_1(v7704)
                    return v7707 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7708 : Async<US8> = _v7700 
            let _v7663 = v7708 
            #endif
            let v7709 : Async<US8> = _v7663 
            let v7714 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v7715 : Async<US6> = null |> unbox<Async<US6>>
            let _v7714 = v7715 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v7718 : Async<US6> = null |> unbox<Async<US6>>
            let _v7714 = v7718 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v7721 : Async<US6> = null |> unbox<Async<US6>>
            let _v7714 = v7721 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v7724 : unit = ()
            let _v7724 =
                async {
                    let! v7709 = v7709 
                    let v7725 : US8 = v7709 
                    let v7849 : US6 =
                        match v7725 with
                        | US8_1(v7728) -> (* Error *)
                            let v7729 : string = $"%A{v7728}"
                            let v7732 : string = "System.TimeoutException"
                            let v7733 : bool = v7729.Contains v7732 
                            if v7733 then
                                let v7736 : unit = ()
                                let v7737 : (unit -> unit) = closure16(v0)
                                let v7738 : unit = (fun () -> v7737 (); v7736) ()
                                US6_1
                            else
                                let v7779 : unit = ()
                                let v7780 : (unit -> unit) = closure17(v0, v7728)
                                let v7781 : unit = (fun () -> v7780 (); v7779) ()
                                US6_1
                        | US8_0(v7726) -> (* Ok *)
                            US6_0(v7726)
                    return v7849 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7850 : Async<US6> = _v7724 
            let _v7714 = v7850 
            #endif
#if FABLE_COMPILER_PYTHON
            let v7851 : unit = ()
            let _v7851 =
                async {
                    let! v7709 = v7709 
                    let v7852 : US8 = v7709 
                    let v7976 : US6 =
                        match v7852 with
                        | US8_1(v7855) -> (* Error *)
                            let v7856 : string = $"%A{v7855}"
                            let v7859 : string = "System.TimeoutException"
                            let v7860 : bool = v7856.Contains v7859 
                            if v7860 then
                                let v7863 : unit = ()
                                let v7864 : (unit -> unit) = closure16(v0)
                                let v7865 : unit = (fun () -> v7864 (); v7863) ()
                                US6_1
                            else
                                let v7906 : unit = ()
                                let v7907 : (unit -> unit) = closure17(v0, v7855)
                                let v7908 : unit = (fun () -> v7907 (); v7906) ()
                                US6_1
                        | US8_0(v7853) -> (* Ok *)
                            US6_0(v7853)
                    return v7976 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v7977 : Async<US6> = _v7851 
            let _v7714 = v7977 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v7978 : unit = ()
            let _v7978 =
                async {
                    let! v7709 = v7709 
                    let v7979 : US8 = v7709 
                    let v8103 : US6 =
                        match v7979 with
                        | US8_1(v7982) -> (* Error *)
                            let v7983 : string = $"%A{v7982}"
                            let v7986 : string = "System.TimeoutException"
                            let v7987 : bool = v7983.Contains v7986 
                            if v7987 then
                                let v7990 : unit = ()
                                let v7991 : (unit -> unit) = closure16(v0)
                                let v7992 : unit = (fun () -> v7991 (); v7990) ()
                                US6_1
                            else
                                let v8033 : unit = ()
                                let v8034 : (unit -> unit) = closure17(v0, v7982)
                                let v8035 : unit = (fun () -> v8034 (); v8033) ()
                                US6_1
                        | US8_0(v7980) -> (* Ok *)
                            US6_0(v7980)
                    return v8103 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8104 : Async<US6> = _v7978 
            let _v7714 = v8104 
            #endif
#else
            let v8105 : unit = ()
            let _v8105 =
                async {
                    let! v7709 = v7709 
                    let v8106 : US8 = v7709 
                    let v8230 : US6 =
                        match v8106 with
                        | US8_1(v8109) -> (* Error *)
                            let v8110 : string = $"%A{v8109}"
                            let v8113 : string = "System.TimeoutException"
                            let v8114 : bool = v8110.Contains v8113 
                            if v8114 then
                                let v8117 : unit = ()
                                let v8118 : (unit -> unit) = closure16(v0)
                                let v8119 : unit = (fun () -> v8118 (); v8117) ()
                                US6_1
                            else
                                let v8160 : unit = ()
                                let v8161 : (unit -> unit) = closure17(v0, v8109)
                                let v8162 : unit = (fun () -> v8161 (); v8160) ()
                                US6_1
                        | US8_0(v8107) -> (* Ok *)
                            US6_0(v8107)
                    return v8230 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8231 : Async<US6> = _v8105 
            let _v7714 = v8231 
            #endif
            let v8232 : Async<US6> = _v7714 
            return! v8232 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v8237 : Async<US6> = _v7493 
    let _v5993 = v8237 
    #endif
#else
    let v8238 : unit = ()
    let _v8238 =
        async {
            let v8239 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8240 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8240 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8241 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8241 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8242 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8242 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8243 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8243 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8244 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8244 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8245 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8245 
            #endif
#else
            let v8246 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8239 = v8246 
            #endif
            let v8247 : Async<Async<bool>> = _v8239 
            let! v8247 = v8247 
            let v8252 : Async<bool> = v8247 
            let v8253 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8254 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8255 : Async<Choice<bool, exn>> = v8254 v8252
            let _v8253 = v8255 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8256 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8257 : Async<Choice<bool, exn>> = v8256 v8252
            let _v8253 = v8257 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8258 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8259 : Async<Choice<bool, exn>> = v8258 v8252
            let _v8253 = v8259 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8260 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8261 : Async<Choice<bool, exn>> = v8260 v8252
            let _v8253 = v8261 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8262 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8263 : Async<Choice<bool, exn>> = v8262 v8252
            let _v8253 = v8263 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8264 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8265 : Async<Choice<bool, exn>> = v8264 v8252
            let _v8253 = v8265 
            #endif
#else
            let v8266 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v8267 : Async<Choice<bool, exn>> = v8266 v8252
            let _v8253 = v8267 
            #endif
            let v8268 : Async<Choice<bool, exn>> = _v8253 
            let v8273 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8274 : Async<US7> = null |> unbox<Async<US7>>
            let _v8273 = v8274 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8277 : Async<US7> = null |> unbox<Async<US7>>
            let _v8273 = v8277 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8280 : Async<US7> = null |> unbox<Async<US7>>
            let _v8273 = v8280 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8283 : unit = ()
            let _v8283 =
                async {
                    let! v8268 = v8268 
                    let v8284 : Choice<bool, exn> = v8268 
                    let v8285 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8286 : US7 = null |> unbox<US7>
                    let _v8285 = v8286 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8289 : US7 = null |> unbox<US7>
                    let _v8285 = v8289 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8292 : US7 = null |> unbox<US7>
                    let _v8285 = v8292 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8295 : US7 = null |> unbox<US7>
                    let _v8285 = v8295 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8298 : US7 = null |> unbox<US7>
                    let _v8285 = v8298 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8301 : (bool -> US7) = method21()
                    let v8302 : (exn -> US7) = method22()
                    let v8303 : US7 = match v8284 with Choice1Of2 x -> v8301 x | Choice2Of2 x -> v8302 x
                    let _v8285 = v8303 
                    #endif
#else
                    let v8304 : (bool -> US7) = method21()
                    let v8305 : (exn -> US7) = method22()
                    let v8306 : US7 = match v8284 with Choice1Of2 x -> v8304 x | Choice2Of2 x -> v8305 x
                    let _v8285 = v8306 
                    #endif
                    let v8307 : US7 = _v8285 
                    return v8307 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8312 : Async<US7> = _v8283 
            let _v8273 = v8312 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8313 : unit = ()
            let _v8313 =
                async {
                    let! v8268 = v8268 
                    let v8314 : Choice<bool, exn> = v8268 
                    let v8315 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8316 : US7 = null |> unbox<US7>
                    let _v8315 = v8316 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8319 : US7 = null |> unbox<US7>
                    let _v8315 = v8319 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8322 : US7 = null |> unbox<US7>
                    let _v8315 = v8322 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8325 : US7 = null |> unbox<US7>
                    let _v8315 = v8325 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8328 : US7 = null |> unbox<US7>
                    let _v8315 = v8328 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8331 : (bool -> US7) = method21()
                    let v8332 : (exn -> US7) = method22()
                    let v8333 : US7 = match v8314 with Choice1Of2 x -> v8331 x | Choice2Of2 x -> v8332 x
                    let _v8315 = v8333 
                    #endif
#else
                    let v8334 : (bool -> US7) = method21()
                    let v8335 : (exn -> US7) = method22()
                    let v8336 : US7 = match v8314 with Choice1Of2 x -> v8334 x | Choice2Of2 x -> v8335 x
                    let _v8315 = v8336 
                    #endif
                    let v8337 : US7 = _v8315 
                    return v8337 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8342 : Async<US7> = _v8313 
            let _v8273 = v8342 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8343 : unit = ()
            let _v8343 =
                async {
                    let! v8268 = v8268 
                    let v8344 : Choice<bool, exn> = v8268 
                    let v8345 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8346 : US7 = null |> unbox<US7>
                    let _v8345 = v8346 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8349 : US7 = null |> unbox<US7>
                    let _v8345 = v8349 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8352 : US7 = null |> unbox<US7>
                    let _v8345 = v8352 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8355 : US7 = null |> unbox<US7>
                    let _v8345 = v8355 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8358 : US7 = null |> unbox<US7>
                    let _v8345 = v8358 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8361 : (bool -> US7) = method21()
                    let v8362 : (exn -> US7) = method22()
                    let v8363 : US7 = match v8344 with Choice1Of2 x -> v8361 x | Choice2Of2 x -> v8362 x
                    let _v8345 = v8363 
                    #endif
#else
                    let v8364 : (bool -> US7) = method21()
                    let v8365 : (exn -> US7) = method22()
                    let v8366 : US7 = match v8344 with Choice1Of2 x -> v8364 x | Choice2Of2 x -> v8365 x
                    let _v8345 = v8366 
                    #endif
                    let v8367 : US7 = _v8345 
                    return v8367 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8372 : Async<US7> = _v8343 
            let _v8273 = v8372 
            #endif
#else
            let v8373 : unit = ()
            let _v8373 =
                async {
                    let! v8268 = v8268 
                    let v8374 : Choice<bool, exn> = v8268 
                    let v8375 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v8376 : US7 = null |> unbox<US7>
                    let _v8375 = v8376 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v8379 : US7 = null |> unbox<US7>
                    let _v8375 = v8379 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v8382 : US7 = null |> unbox<US7>
                    let _v8375 = v8382 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v8385 : US7 = null |> unbox<US7>
                    let _v8375 = v8385 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v8388 : US7 = null |> unbox<US7>
                    let _v8375 = v8388 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v8391 : (bool -> US7) = method21()
                    let v8392 : (exn -> US7) = method22()
                    let v8393 : US7 = match v8374 with Choice1Of2 x -> v8391 x | Choice2Of2 x -> v8392 x
                    let _v8375 = v8393 
                    #endif
#else
                    let v8394 : (bool -> US7) = method21()
                    let v8395 : (exn -> US7) = method22()
                    let v8396 : US7 = match v8374 with Choice1Of2 x -> v8394 x | Choice2Of2 x -> v8395 x
                    let _v8375 = v8396 
                    #endif
                    let v8397 : US7 = _v8375 
                    return v8397 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8402 : Async<US7> = _v8373 
            let _v8273 = v8402 
            #endif
            let v8403 : Async<US7> = _v8273 
            let v8408 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8409 : Async<US8> = null |> unbox<Async<US8>>
            let _v8408 = v8409 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8412 : Async<US8> = null |> unbox<Async<US8>>
            let _v8408 = v8412 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8415 : Async<US8> = null |> unbox<Async<US8>>
            let _v8408 = v8415 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8418 : unit = ()
            let _v8418 =
                async {
                    let! v8403 = v8403 
                    let v8419 : US7 = v8403 
                    let v8425 : US8 =
                        match v8419 with
                        | US7_0(v8420) -> (* C1of2 *)
                            US8_0(v8420)
                        | US7_1(v8422) -> (* C2of2 *)
                            US8_1(v8422)
                    return v8425 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8426 : Async<US8> = _v8418 
            let _v8408 = v8426 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8427 : unit = ()
            let _v8427 =
                async {
                    let! v8403 = v8403 
                    let v8428 : US7 = v8403 
                    let v8434 : US8 =
                        match v8428 with
                        | US7_0(v8429) -> (* C1of2 *)
                            US8_0(v8429)
                        | US7_1(v8431) -> (* C2of2 *)
                            US8_1(v8431)
                    return v8434 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8435 : Async<US8> = _v8427 
            let _v8408 = v8435 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8436 : unit = ()
            let _v8436 =
                async {
                    let! v8403 = v8403 
                    let v8437 : US7 = v8403 
                    let v8443 : US8 =
                        match v8437 with
                        | US7_0(v8438) -> (* C1of2 *)
                            US8_0(v8438)
                        | US7_1(v8440) -> (* C2of2 *)
                            US8_1(v8440)
                    return v8443 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8444 : Async<US8> = _v8436 
            let _v8408 = v8444 
            #endif
#else
            let v8445 : unit = ()
            let _v8445 =
                async {
                    let! v8403 = v8403 
                    let v8446 : US7 = v8403 
                    let v8452 : US8 =
                        match v8446 with
                        | US7_0(v8447) -> (* C1of2 *)
                            US8_0(v8447)
                        | US7_1(v8449) -> (* C2of2 *)
                            US8_1(v8449)
                    return v8452 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8453 : Async<US8> = _v8445 
            let _v8408 = v8453 
            #endif
            let v8454 : Async<US8> = _v8408 
            let v8459 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v8460 : Async<US6> = null |> unbox<Async<US6>>
            let _v8459 = v8460 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v8463 : Async<US6> = null |> unbox<Async<US6>>
            let _v8459 = v8463 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v8466 : Async<US6> = null |> unbox<Async<US6>>
            let _v8459 = v8466 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v8469 : unit = ()
            let _v8469 =
                async {
                    let! v8454 = v8454 
                    let v8470 : US8 = v8454 
                    let v8594 : US6 =
                        match v8470 with
                        | US8_1(v8473) -> (* Error *)
                            let v8474 : string = $"%A{v8473}"
                            let v8477 : string = "System.TimeoutException"
                            let v8478 : bool = v8474.Contains v8477 
                            if v8478 then
                                let v8481 : unit = ()
                                let v8482 : (unit -> unit) = closure16(v0)
                                let v8483 : unit = (fun () -> v8482 (); v8481) ()
                                US6_1
                            else
                                let v8524 : unit = ()
                                let v8525 : (unit -> unit) = closure17(v0, v8473)
                                let v8526 : unit = (fun () -> v8525 (); v8524) ()
                                US6_1
                        | US8_0(v8471) -> (* Ok *)
                            US6_0(v8471)
                    return v8594 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8595 : Async<US6> = _v8469 
            let _v8459 = v8595 
            #endif
#if FABLE_COMPILER_PYTHON
            let v8596 : unit = ()
            let _v8596 =
                async {
                    let! v8454 = v8454 
                    let v8597 : US8 = v8454 
                    let v8721 : US6 =
                        match v8597 with
                        | US8_1(v8600) -> (* Error *)
                            let v8601 : string = $"%A{v8600}"
                            let v8604 : string = "System.TimeoutException"
                            let v8605 : bool = v8601.Contains v8604 
                            if v8605 then
                                let v8608 : unit = ()
                                let v8609 : (unit -> unit) = closure16(v0)
                                let v8610 : unit = (fun () -> v8609 (); v8608) ()
                                US6_1
                            else
                                let v8651 : unit = ()
                                let v8652 : (unit -> unit) = closure17(v0, v8600)
                                let v8653 : unit = (fun () -> v8652 (); v8651) ()
                                US6_1
                        | US8_0(v8598) -> (* Ok *)
                            US6_0(v8598)
                    return v8721 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8722 : Async<US6> = _v8596 
            let _v8459 = v8722 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v8723 : unit = ()
            let _v8723 =
                async {
                    let! v8454 = v8454 
                    let v8724 : US8 = v8454 
                    let v8848 : US6 =
                        match v8724 with
                        | US8_1(v8727) -> (* Error *)
                            let v8728 : string = $"%A{v8727}"
                            let v8731 : string = "System.TimeoutException"
                            let v8732 : bool = v8728.Contains v8731 
                            if v8732 then
                                let v8735 : unit = ()
                                let v8736 : (unit -> unit) = closure16(v0)
                                let v8737 : unit = (fun () -> v8736 (); v8735) ()
                                US6_1
                            else
                                let v8778 : unit = ()
                                let v8779 : (unit -> unit) = closure17(v0, v8727)
                                let v8780 : unit = (fun () -> v8779 (); v8778) ()
                                US6_1
                        | US8_0(v8725) -> (* Ok *)
                            US6_0(v8725)
                    return v8848 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8849 : Async<US6> = _v8723 
            let _v8459 = v8849 
            #endif
#else
            let v8850 : unit = ()
            let _v8850 =
                async {
                    let! v8454 = v8454 
                    let v8851 : US8 = v8454 
                    let v8975 : US6 =
                        match v8851 with
                        | US8_1(v8854) -> (* Error *)
                            let v8855 : string = $"%A{v8854}"
                            let v8858 : string = "System.TimeoutException"
                            let v8859 : bool = v8855.Contains v8858 
                            if v8859 then
                                let v8862 : unit = ()
                                let v8863 : (unit -> unit) = closure16(v0)
                                let v8864 : unit = (fun () -> v8863 (); v8862) ()
                                US6_1
                            else
                                let v8905 : unit = ()
                                let v8906 : (unit -> unit) = closure17(v0, v8854)
                                let v8907 : unit = (fun () -> v8906 (); v8905) ()
                                US6_1
                        | US8_0(v8852) -> (* Ok *)
                            US6_0(v8852)
                    return v8975 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v8976 : Async<US6> = _v8850 
            let _v8459 = v8976 
            #endif
            let v8977 : Async<US6> = _v8459 
            return! v8977 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v8982 : Async<US6> = _v8238 
    let _v5993 = v8982 
    #endif
    let v8983 : Async<US6> = _v5993 
    let _v2 = v8983 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8988 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8989 : Async<US6> = null |> unbox<Async<US6>>
    let _v8988 = v8989 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8992 : Async<US6> = null |> unbox<Async<US6>>
    let _v8988 = v8992 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8995 : Async<US6> = null |> unbox<Async<US6>>
    let _v8988 = v8995 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8998 : unit = ()
    let _v8998 =
        async {
            let v8999 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9000 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9000 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9001 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9001 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9002 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9002 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9003 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9003 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9004 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9004 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9005 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9005 
            #endif
#else
            let v9006 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v8999 = v9006 
            #endif
            let v9007 : Async<Async<bool>> = _v8999 
            let! v9007 = v9007 
            let v9012 : Async<bool> = v9007 
            let v9013 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9014 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9015 : Async<Choice<bool, exn>> = v9014 v9012
            let _v9013 = v9015 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9016 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9017 : Async<Choice<bool, exn>> = v9016 v9012
            let _v9013 = v9017 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9018 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9019 : Async<Choice<bool, exn>> = v9018 v9012
            let _v9013 = v9019 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9020 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9021 : Async<Choice<bool, exn>> = v9020 v9012
            let _v9013 = v9021 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9022 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9023 : Async<Choice<bool, exn>> = v9022 v9012
            let _v9013 = v9023 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9024 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9025 : Async<Choice<bool, exn>> = v9024 v9012
            let _v9013 = v9025 
            #endif
#else
            let v9026 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9027 : Async<Choice<bool, exn>> = v9026 v9012
            let _v9013 = v9027 
            #endif
            let v9028 : Async<Choice<bool, exn>> = _v9013 
            let v9033 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9034 : Async<US7> = null |> unbox<Async<US7>>
            let _v9033 = v9034 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9037 : Async<US7> = null |> unbox<Async<US7>>
            let _v9033 = v9037 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9040 : Async<US7> = null |> unbox<Async<US7>>
            let _v9033 = v9040 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9043 : unit = ()
            let _v9043 =
                async {
                    let! v9028 = v9028 
                    let v9044 : Choice<bool, exn> = v9028 
                    let v9045 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9046 : US7 = null |> unbox<US7>
                    let _v9045 = v9046 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9049 : US7 = null |> unbox<US7>
                    let _v9045 = v9049 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9052 : US7 = null |> unbox<US7>
                    let _v9045 = v9052 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9055 : US7 = null |> unbox<US7>
                    let _v9045 = v9055 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9058 : US7 = null |> unbox<US7>
                    let _v9045 = v9058 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9061 : (bool -> US7) = method21()
                    let v9062 : (exn -> US7) = method22()
                    let v9063 : US7 = match v9044 with Choice1Of2 x -> v9061 x | Choice2Of2 x -> v9062 x
                    let _v9045 = v9063 
                    #endif
#else
                    let v9064 : (bool -> US7) = method21()
                    let v9065 : (exn -> US7) = method22()
                    let v9066 : US7 = match v9044 with Choice1Of2 x -> v9064 x | Choice2Of2 x -> v9065 x
                    let _v9045 = v9066 
                    #endif
                    let v9067 : US7 = _v9045 
                    return v9067 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9072 : Async<US7> = _v9043 
            let _v9033 = v9072 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9073 : unit = ()
            let _v9073 =
                async {
                    let! v9028 = v9028 
                    let v9074 : Choice<bool, exn> = v9028 
                    let v9075 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9076 : US7 = null |> unbox<US7>
                    let _v9075 = v9076 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9079 : US7 = null |> unbox<US7>
                    let _v9075 = v9079 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9082 : US7 = null |> unbox<US7>
                    let _v9075 = v9082 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9085 : US7 = null |> unbox<US7>
                    let _v9075 = v9085 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9088 : US7 = null |> unbox<US7>
                    let _v9075 = v9088 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9091 : (bool -> US7) = method21()
                    let v9092 : (exn -> US7) = method22()
                    let v9093 : US7 = match v9074 with Choice1Of2 x -> v9091 x | Choice2Of2 x -> v9092 x
                    let _v9075 = v9093 
                    #endif
#else
                    let v9094 : (bool -> US7) = method21()
                    let v9095 : (exn -> US7) = method22()
                    let v9096 : US7 = match v9074 with Choice1Of2 x -> v9094 x | Choice2Of2 x -> v9095 x
                    let _v9075 = v9096 
                    #endif
                    let v9097 : US7 = _v9075 
                    return v9097 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9102 : Async<US7> = _v9073 
            let _v9033 = v9102 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9103 : unit = ()
            let _v9103 =
                async {
                    let! v9028 = v9028 
                    let v9104 : Choice<bool, exn> = v9028 
                    let v9105 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9106 : US7 = null |> unbox<US7>
                    let _v9105 = v9106 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9109 : US7 = null |> unbox<US7>
                    let _v9105 = v9109 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9112 : US7 = null |> unbox<US7>
                    let _v9105 = v9112 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9115 : US7 = null |> unbox<US7>
                    let _v9105 = v9115 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9118 : US7 = null |> unbox<US7>
                    let _v9105 = v9118 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9121 : (bool -> US7) = method21()
                    let v9122 : (exn -> US7) = method22()
                    let v9123 : US7 = match v9104 with Choice1Of2 x -> v9121 x | Choice2Of2 x -> v9122 x
                    let _v9105 = v9123 
                    #endif
#else
                    let v9124 : (bool -> US7) = method21()
                    let v9125 : (exn -> US7) = method22()
                    let v9126 : US7 = match v9104 with Choice1Of2 x -> v9124 x | Choice2Of2 x -> v9125 x
                    let _v9105 = v9126 
                    #endif
                    let v9127 : US7 = _v9105 
                    return v9127 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9132 : Async<US7> = _v9103 
            let _v9033 = v9132 
            #endif
#else
            let v9133 : unit = ()
            let _v9133 =
                async {
                    let! v9028 = v9028 
                    let v9134 : Choice<bool, exn> = v9028 
                    let v9135 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9136 : US7 = null |> unbox<US7>
                    let _v9135 = v9136 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9139 : US7 = null |> unbox<US7>
                    let _v9135 = v9139 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9142 : US7 = null |> unbox<US7>
                    let _v9135 = v9142 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9145 : US7 = null |> unbox<US7>
                    let _v9135 = v9145 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9148 : US7 = null |> unbox<US7>
                    let _v9135 = v9148 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9151 : (bool -> US7) = method21()
                    let v9152 : (exn -> US7) = method22()
                    let v9153 : US7 = match v9134 with Choice1Of2 x -> v9151 x | Choice2Of2 x -> v9152 x
                    let _v9135 = v9153 
                    #endif
#else
                    let v9154 : (bool -> US7) = method21()
                    let v9155 : (exn -> US7) = method22()
                    let v9156 : US7 = match v9134 with Choice1Of2 x -> v9154 x | Choice2Of2 x -> v9155 x
                    let _v9135 = v9156 
                    #endif
                    let v9157 : US7 = _v9135 
                    return v9157 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9162 : Async<US7> = _v9133 
            let _v9033 = v9162 
            #endif
            let v9163 : Async<US7> = _v9033 
            let v9168 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9169 : Async<US8> = null |> unbox<Async<US8>>
            let _v9168 = v9169 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9172 : Async<US8> = null |> unbox<Async<US8>>
            let _v9168 = v9172 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9175 : Async<US8> = null |> unbox<Async<US8>>
            let _v9168 = v9175 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9178 : unit = ()
            let _v9178 =
                async {
                    let! v9163 = v9163 
                    let v9179 : US7 = v9163 
                    let v9185 : US8 =
                        match v9179 with
                        | US7_0(v9180) -> (* C1of2 *)
                            US8_0(v9180)
                        | US7_1(v9182) -> (* C2of2 *)
                            US8_1(v9182)
                    return v9185 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9186 : Async<US8> = _v9178 
            let _v9168 = v9186 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9187 : unit = ()
            let _v9187 =
                async {
                    let! v9163 = v9163 
                    let v9188 : US7 = v9163 
                    let v9194 : US8 =
                        match v9188 with
                        | US7_0(v9189) -> (* C1of2 *)
                            US8_0(v9189)
                        | US7_1(v9191) -> (* C2of2 *)
                            US8_1(v9191)
                    return v9194 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9195 : Async<US8> = _v9187 
            let _v9168 = v9195 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9196 : unit = ()
            let _v9196 =
                async {
                    let! v9163 = v9163 
                    let v9197 : US7 = v9163 
                    let v9203 : US8 =
                        match v9197 with
                        | US7_0(v9198) -> (* C1of2 *)
                            US8_0(v9198)
                        | US7_1(v9200) -> (* C2of2 *)
                            US8_1(v9200)
                    return v9203 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9204 : Async<US8> = _v9196 
            let _v9168 = v9204 
            #endif
#else
            let v9205 : unit = ()
            let _v9205 =
                async {
                    let! v9163 = v9163 
                    let v9206 : US7 = v9163 
                    let v9212 : US8 =
                        match v9206 with
                        | US7_0(v9207) -> (* C1of2 *)
                            US8_0(v9207)
                        | US7_1(v9209) -> (* C2of2 *)
                            US8_1(v9209)
                    return v9212 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9213 : Async<US8> = _v9205 
            let _v9168 = v9213 
            #endif
            let v9214 : Async<US8> = _v9168 
            let v9219 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9220 : Async<US6> = null |> unbox<Async<US6>>
            let _v9219 = v9220 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9223 : Async<US6> = null |> unbox<Async<US6>>
            let _v9219 = v9223 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9226 : Async<US6> = null |> unbox<Async<US6>>
            let _v9219 = v9226 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9229 : unit = ()
            let _v9229 =
                async {
                    let! v9214 = v9214 
                    let v9230 : US8 = v9214 
                    let v9354 : US6 =
                        match v9230 with
                        | US8_1(v9233) -> (* Error *)
                            let v9234 : string = $"%A{v9233}"
                            let v9237 : string = "System.TimeoutException"
                            let v9238 : bool = v9234.Contains v9237 
                            if v9238 then
                                let v9241 : unit = ()
                                let v9242 : (unit -> unit) = closure16(v0)
                                let v9243 : unit = (fun () -> v9242 (); v9241) ()
                                US6_1
                            else
                                let v9284 : unit = ()
                                let v9285 : (unit -> unit) = closure17(v0, v9233)
                                let v9286 : unit = (fun () -> v9285 (); v9284) ()
                                US6_1
                        | US8_0(v9231) -> (* Ok *)
                            US6_0(v9231)
                    return v9354 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9355 : Async<US6> = _v9229 
            let _v9219 = v9355 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9356 : unit = ()
            let _v9356 =
                async {
                    let! v9214 = v9214 
                    let v9357 : US8 = v9214 
                    let v9481 : US6 =
                        match v9357 with
                        | US8_1(v9360) -> (* Error *)
                            let v9361 : string = $"%A{v9360}"
                            let v9364 : string = "System.TimeoutException"
                            let v9365 : bool = v9361.Contains v9364 
                            if v9365 then
                                let v9368 : unit = ()
                                let v9369 : (unit -> unit) = closure16(v0)
                                let v9370 : unit = (fun () -> v9369 (); v9368) ()
                                US6_1
                            else
                                let v9411 : unit = ()
                                let v9412 : (unit -> unit) = closure17(v0, v9360)
                                let v9413 : unit = (fun () -> v9412 (); v9411) ()
                                US6_1
                        | US8_0(v9358) -> (* Ok *)
                            US6_0(v9358)
                    return v9481 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9482 : Async<US6> = _v9356 
            let _v9219 = v9482 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9483 : unit = ()
            let _v9483 =
                async {
                    let! v9214 = v9214 
                    let v9484 : US8 = v9214 
                    let v9608 : US6 =
                        match v9484 with
                        | US8_1(v9487) -> (* Error *)
                            let v9488 : string = $"%A{v9487}"
                            let v9491 : string = "System.TimeoutException"
                            let v9492 : bool = v9488.Contains v9491 
                            if v9492 then
                                let v9495 : unit = ()
                                let v9496 : (unit -> unit) = closure16(v0)
                                let v9497 : unit = (fun () -> v9496 (); v9495) ()
                                US6_1
                            else
                                let v9538 : unit = ()
                                let v9539 : (unit -> unit) = closure17(v0, v9487)
                                let v9540 : unit = (fun () -> v9539 (); v9538) ()
                                US6_1
                        | US8_0(v9485) -> (* Ok *)
                            US6_0(v9485)
                    return v9608 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9609 : Async<US6> = _v9483 
            let _v9219 = v9609 
            #endif
#else
            let v9610 : unit = ()
            let _v9610 =
                async {
                    let! v9214 = v9214 
                    let v9611 : US8 = v9214 
                    let v9735 : US6 =
                        match v9611 with
                        | US8_1(v9614) -> (* Error *)
                            let v9615 : string = $"%A{v9614}"
                            let v9618 : string = "System.TimeoutException"
                            let v9619 : bool = v9615.Contains v9618 
                            if v9619 then
                                let v9622 : unit = ()
                                let v9623 : (unit -> unit) = closure16(v0)
                                let v9624 : unit = (fun () -> v9623 (); v9622) ()
                                US6_1
                            else
                                let v9665 : unit = ()
                                let v9666 : (unit -> unit) = closure17(v0, v9614)
                                let v9667 : unit = (fun () -> v9666 (); v9665) ()
                                US6_1
                        | US8_0(v9612) -> (* Ok *)
                            US6_0(v9612)
                    return v9735 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9736 : Async<US6> = _v9610 
            let _v9219 = v9736 
            #endif
            let v9737 : Async<US6> = _v9219 
            return! v9737 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v9742 : Async<US6> = _v8998 
    let _v8988 = v9742 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9743 : unit = ()
    let _v9743 =
        async {
            let v9744 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9745 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9745 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9746 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9746 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9747 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9747 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9748 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9748 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9749 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9749 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9750 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9750 
            #endif
#else
            let v9751 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v9744 = v9751 
            #endif
            let v9752 : Async<Async<bool>> = _v9744 
            let! v9752 = v9752 
            let v9757 : Async<bool> = v9752 
            let v9758 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9759 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9760 : Async<Choice<bool, exn>> = v9759 v9757
            let _v9758 = v9760 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9761 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9762 : Async<Choice<bool, exn>> = v9761 v9757
            let _v9758 = v9762 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9763 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9764 : Async<Choice<bool, exn>> = v9763 v9757
            let _v9758 = v9764 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9765 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9766 : Async<Choice<bool, exn>> = v9765 v9757
            let _v9758 = v9766 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9767 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9768 : Async<Choice<bool, exn>> = v9767 v9757
            let _v9758 = v9768 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9769 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9770 : Async<Choice<bool, exn>> = v9769 v9757
            let _v9758 = v9770 
            #endif
#else
            let v9771 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v9772 : Async<Choice<bool, exn>> = v9771 v9757
            let _v9758 = v9772 
            #endif
            let v9773 : Async<Choice<bool, exn>> = _v9758 
            let v9778 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9779 : Async<US7> = null |> unbox<Async<US7>>
            let _v9778 = v9779 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9782 : Async<US7> = null |> unbox<Async<US7>>
            let _v9778 = v9782 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9785 : Async<US7> = null |> unbox<Async<US7>>
            let _v9778 = v9785 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9788 : unit = ()
            let _v9788 =
                async {
                    let! v9773 = v9773 
                    let v9789 : Choice<bool, exn> = v9773 
                    let v9790 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9791 : US7 = null |> unbox<US7>
                    let _v9790 = v9791 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9794 : US7 = null |> unbox<US7>
                    let _v9790 = v9794 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9797 : US7 = null |> unbox<US7>
                    let _v9790 = v9797 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9800 : US7 = null |> unbox<US7>
                    let _v9790 = v9800 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9803 : US7 = null |> unbox<US7>
                    let _v9790 = v9803 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9806 : (bool -> US7) = method21()
                    let v9807 : (exn -> US7) = method22()
                    let v9808 : US7 = match v9789 with Choice1Of2 x -> v9806 x | Choice2Of2 x -> v9807 x
                    let _v9790 = v9808 
                    #endif
#else
                    let v9809 : (bool -> US7) = method21()
                    let v9810 : (exn -> US7) = method22()
                    let v9811 : US7 = match v9789 with Choice1Of2 x -> v9809 x | Choice2Of2 x -> v9810 x
                    let _v9790 = v9811 
                    #endif
                    let v9812 : US7 = _v9790 
                    return v9812 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9817 : Async<US7> = _v9788 
            let _v9778 = v9817 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9818 : unit = ()
            let _v9818 =
                async {
                    let! v9773 = v9773 
                    let v9819 : Choice<bool, exn> = v9773 
                    let v9820 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9821 : US7 = null |> unbox<US7>
                    let _v9820 = v9821 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9824 : US7 = null |> unbox<US7>
                    let _v9820 = v9824 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9827 : US7 = null |> unbox<US7>
                    let _v9820 = v9827 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9830 : US7 = null |> unbox<US7>
                    let _v9820 = v9830 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9833 : US7 = null |> unbox<US7>
                    let _v9820 = v9833 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9836 : (bool -> US7) = method21()
                    let v9837 : (exn -> US7) = method22()
                    let v9838 : US7 = match v9819 with Choice1Of2 x -> v9836 x | Choice2Of2 x -> v9837 x
                    let _v9820 = v9838 
                    #endif
#else
                    let v9839 : (bool -> US7) = method21()
                    let v9840 : (exn -> US7) = method22()
                    let v9841 : US7 = match v9819 with Choice1Of2 x -> v9839 x | Choice2Of2 x -> v9840 x
                    let _v9820 = v9841 
                    #endif
                    let v9842 : US7 = _v9820 
                    return v9842 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9847 : Async<US7> = _v9818 
            let _v9778 = v9847 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9848 : unit = ()
            let _v9848 =
                async {
                    let! v9773 = v9773 
                    let v9849 : Choice<bool, exn> = v9773 
                    let v9850 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9851 : US7 = null |> unbox<US7>
                    let _v9850 = v9851 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9854 : US7 = null |> unbox<US7>
                    let _v9850 = v9854 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9857 : US7 = null |> unbox<US7>
                    let _v9850 = v9857 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9860 : US7 = null |> unbox<US7>
                    let _v9850 = v9860 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9863 : US7 = null |> unbox<US7>
                    let _v9850 = v9863 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9866 : (bool -> US7) = method21()
                    let v9867 : (exn -> US7) = method22()
                    let v9868 : US7 = match v9849 with Choice1Of2 x -> v9866 x | Choice2Of2 x -> v9867 x
                    let _v9850 = v9868 
                    #endif
#else
                    let v9869 : (bool -> US7) = method21()
                    let v9870 : (exn -> US7) = method22()
                    let v9871 : US7 = match v9849 with Choice1Of2 x -> v9869 x | Choice2Of2 x -> v9870 x
                    let _v9850 = v9871 
                    #endif
                    let v9872 : US7 = _v9850 
                    return v9872 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9877 : Async<US7> = _v9848 
            let _v9778 = v9877 
            #endif
#else
            let v9878 : unit = ()
            let _v9878 =
                async {
                    let! v9773 = v9773 
                    let v9879 : Choice<bool, exn> = v9773 
                    let v9880 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v9881 : US7 = null |> unbox<US7>
                    let _v9880 = v9881 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v9884 : US7 = null |> unbox<US7>
                    let _v9880 = v9884 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v9887 : US7 = null |> unbox<US7>
                    let _v9880 = v9887 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v9890 : US7 = null |> unbox<US7>
                    let _v9880 = v9890 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v9893 : US7 = null |> unbox<US7>
                    let _v9880 = v9893 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v9896 : (bool -> US7) = method21()
                    let v9897 : (exn -> US7) = method22()
                    let v9898 : US7 = match v9879 with Choice1Of2 x -> v9896 x | Choice2Of2 x -> v9897 x
                    let _v9880 = v9898 
                    #endif
#else
                    let v9899 : (bool -> US7) = method21()
                    let v9900 : (exn -> US7) = method22()
                    let v9901 : US7 = match v9879 with Choice1Of2 x -> v9899 x | Choice2Of2 x -> v9900 x
                    let _v9880 = v9901 
                    #endif
                    let v9902 : US7 = _v9880 
                    return v9902 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9907 : Async<US7> = _v9878 
            let _v9778 = v9907 
            #endif
            let v9908 : Async<US7> = _v9778 
            let v9913 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9914 : Async<US8> = null |> unbox<Async<US8>>
            let _v9913 = v9914 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9917 : Async<US8> = null |> unbox<Async<US8>>
            let _v9913 = v9917 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9920 : Async<US8> = null |> unbox<Async<US8>>
            let _v9913 = v9920 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9923 : unit = ()
            let _v9923 =
                async {
                    let! v9908 = v9908 
                    let v9924 : US7 = v9908 
                    let v9930 : US8 =
                        match v9924 with
                        | US7_0(v9925) -> (* C1of2 *)
                            US8_0(v9925)
                        | US7_1(v9927) -> (* C2of2 *)
                            US8_1(v9927)
                    return v9930 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9931 : Async<US8> = _v9923 
            let _v9913 = v9931 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9932 : unit = ()
            let _v9932 =
                async {
                    let! v9908 = v9908 
                    let v9933 : US7 = v9908 
                    let v9939 : US8 =
                        match v9933 with
                        | US7_0(v9934) -> (* C1of2 *)
                            US8_0(v9934)
                        | US7_1(v9936) -> (* C2of2 *)
                            US8_1(v9936)
                    return v9939 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9940 : Async<US8> = _v9932 
            let _v9913 = v9940 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v9941 : unit = ()
            let _v9941 =
                async {
                    let! v9908 = v9908 
                    let v9942 : US7 = v9908 
                    let v9948 : US8 =
                        match v9942 with
                        | US7_0(v9943) -> (* C1of2 *)
                            US8_0(v9943)
                        | US7_1(v9945) -> (* C2of2 *)
                            US8_1(v9945)
                    return v9948 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9949 : Async<US8> = _v9941 
            let _v9913 = v9949 
            #endif
#else
            let v9950 : unit = ()
            let _v9950 =
                async {
                    let! v9908 = v9908 
                    let v9951 : US7 = v9908 
                    let v9957 : US8 =
                        match v9951 with
                        | US7_0(v9952) -> (* C1of2 *)
                            US8_0(v9952)
                        | US7_1(v9954) -> (* C2of2 *)
                            US8_1(v9954)
                    return v9957 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v9958 : Async<US8> = _v9950 
            let _v9913 = v9958 
            #endif
            let v9959 : Async<US8> = _v9913 
            let v9964 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9965 : Async<US6> = null |> unbox<Async<US6>>
            let _v9964 = v9965 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9968 : Async<US6> = null |> unbox<Async<US6>>
            let _v9964 = v9968 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9971 : Async<US6> = null |> unbox<Async<US6>>
            let _v9964 = v9971 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9974 : unit = ()
            let _v9974 =
                async {
                    let! v9959 = v9959 
                    let v9975 : US8 = v9959 
                    let v10099 : US6 =
                        match v9975 with
                        | US8_1(v9978) -> (* Error *)
                            let v9979 : string = $"%A{v9978}"
                            let v9982 : string = "System.TimeoutException"
                            let v9983 : bool = v9979.Contains v9982 
                            if v9983 then
                                let v9986 : unit = ()
                                let v9987 : (unit -> unit) = closure16(v0)
                                let v9988 : unit = (fun () -> v9987 (); v9986) ()
                                US6_1
                            else
                                let v10029 : unit = ()
                                let v10030 : (unit -> unit) = closure17(v0, v9978)
                                let v10031 : unit = (fun () -> v10030 (); v10029) ()
                                US6_1
                        | US8_0(v9976) -> (* Ok *)
                            US6_0(v9976)
                    return v10099 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10100 : Async<US6> = _v9974 
            let _v9964 = v10100 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10101 : unit = ()
            let _v10101 =
                async {
                    let! v9959 = v9959 
                    let v10102 : US8 = v9959 
                    let v10226 : US6 =
                        match v10102 with
                        | US8_1(v10105) -> (* Error *)
                            let v10106 : string = $"%A{v10105}"
                            let v10109 : string = "System.TimeoutException"
                            let v10110 : bool = v10106.Contains v10109 
                            if v10110 then
                                let v10113 : unit = ()
                                let v10114 : (unit -> unit) = closure16(v0)
                                let v10115 : unit = (fun () -> v10114 (); v10113) ()
                                US6_1
                            else
                                let v10156 : unit = ()
                                let v10157 : (unit -> unit) = closure17(v0, v10105)
                                let v10158 : unit = (fun () -> v10157 (); v10156) ()
                                US6_1
                        | US8_0(v10103) -> (* Ok *)
                            US6_0(v10103)
                    return v10226 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10227 : Async<US6> = _v10101 
            let _v9964 = v10227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10228 : unit = ()
            let _v10228 =
                async {
                    let! v9959 = v9959 
                    let v10229 : US8 = v9959 
                    let v10353 : US6 =
                        match v10229 with
                        | US8_1(v10232) -> (* Error *)
                            let v10233 : string = $"%A{v10232}"
                            let v10236 : string = "System.TimeoutException"
                            let v10237 : bool = v10233.Contains v10236 
                            if v10237 then
                                let v10240 : unit = ()
                                let v10241 : (unit -> unit) = closure16(v0)
                                let v10242 : unit = (fun () -> v10241 (); v10240) ()
                                US6_1
                            else
                                let v10283 : unit = ()
                                let v10284 : (unit -> unit) = closure17(v0, v10232)
                                let v10285 : unit = (fun () -> v10284 (); v10283) ()
                                US6_1
                        | US8_0(v10230) -> (* Ok *)
                            US6_0(v10230)
                    return v10353 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10354 : Async<US6> = _v10228 
            let _v9964 = v10354 
            #endif
#else
            let v10355 : unit = ()
            let _v10355 =
                async {
                    let! v9959 = v9959 
                    let v10356 : US8 = v9959 
                    let v10480 : US6 =
                        match v10356 with
                        | US8_1(v10359) -> (* Error *)
                            let v10360 : string = $"%A{v10359}"
                            let v10363 : string = "System.TimeoutException"
                            let v10364 : bool = v10360.Contains v10363 
                            if v10364 then
                                let v10367 : unit = ()
                                let v10368 : (unit -> unit) = closure16(v0)
                                let v10369 : unit = (fun () -> v10368 (); v10367) ()
                                US6_1
                            else
                                let v10410 : unit = ()
                                let v10411 : (unit -> unit) = closure17(v0, v10359)
                                let v10412 : unit = (fun () -> v10411 (); v10410) ()
                                US6_1
                        | US8_0(v10357) -> (* Ok *)
                            US6_0(v10357)
                    return v10480 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10481 : Async<US6> = _v10355 
            let _v9964 = v10481 
            #endif
            let v10482 : Async<US6> = _v9964 
            return! v10482 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v10487 : Async<US6> = _v9743 
    let _v8988 = v10487 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v10488 : unit = ()
    let _v10488 =
        async {
            let v10489 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10490 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10490 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10491 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10491 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10492 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10492 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10493 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10493 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10494 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10494 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10495 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10495 
            #endif
#else
            let v10496 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v10489 = v10496 
            #endif
            let v10497 : Async<Async<bool>> = _v10489 
            let! v10497 = v10497 
            let v10502 : Async<bool> = v10497 
            let v10503 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10504 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10505 : Async<Choice<bool, exn>> = v10504 v10502
            let _v10503 = v10505 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10506 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10507 : Async<Choice<bool, exn>> = v10506 v10502
            let _v10503 = v10507 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10508 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10509 : Async<Choice<bool, exn>> = v10508 v10502
            let _v10503 = v10509 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10510 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10511 : Async<Choice<bool, exn>> = v10510 v10502
            let _v10503 = v10511 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10512 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10513 : Async<Choice<bool, exn>> = v10512 v10502
            let _v10503 = v10513 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10514 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10515 : Async<Choice<bool, exn>> = v10514 v10502
            let _v10503 = v10515 
            #endif
#else
            let v10516 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v10517 : Async<Choice<bool, exn>> = v10516 v10502
            let _v10503 = v10517 
            #endif
            let v10518 : Async<Choice<bool, exn>> = _v10503 
            let v10523 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10524 : Async<US7> = null |> unbox<Async<US7>>
            let _v10523 = v10524 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10527 : Async<US7> = null |> unbox<Async<US7>>
            let _v10523 = v10527 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10530 : Async<US7> = null |> unbox<Async<US7>>
            let _v10523 = v10530 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10533 : unit = ()
            let _v10533 =
                async {
                    let! v10518 = v10518 
                    let v10534 : Choice<bool, exn> = v10518 
                    let v10535 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10536 : US7 = null |> unbox<US7>
                    let _v10535 = v10536 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10539 : US7 = null |> unbox<US7>
                    let _v10535 = v10539 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10542 : US7 = null |> unbox<US7>
                    let _v10535 = v10542 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10545 : US7 = null |> unbox<US7>
                    let _v10535 = v10545 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10548 : US7 = null |> unbox<US7>
                    let _v10535 = v10548 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10551 : (bool -> US7) = method21()
                    let v10552 : (exn -> US7) = method22()
                    let v10553 : US7 = match v10534 with Choice1Of2 x -> v10551 x | Choice2Of2 x -> v10552 x
                    let _v10535 = v10553 
                    #endif
#else
                    let v10554 : (bool -> US7) = method21()
                    let v10555 : (exn -> US7) = method22()
                    let v10556 : US7 = match v10534 with Choice1Of2 x -> v10554 x | Choice2Of2 x -> v10555 x
                    let _v10535 = v10556 
                    #endif
                    let v10557 : US7 = _v10535 
                    return v10557 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10562 : Async<US7> = _v10533 
            let _v10523 = v10562 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10563 : unit = ()
            let _v10563 =
                async {
                    let! v10518 = v10518 
                    let v10564 : Choice<bool, exn> = v10518 
                    let v10565 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10566 : US7 = null |> unbox<US7>
                    let _v10565 = v10566 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10569 : US7 = null |> unbox<US7>
                    let _v10565 = v10569 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10572 : US7 = null |> unbox<US7>
                    let _v10565 = v10572 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10575 : US7 = null |> unbox<US7>
                    let _v10565 = v10575 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10578 : US7 = null |> unbox<US7>
                    let _v10565 = v10578 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10581 : (bool -> US7) = method21()
                    let v10582 : (exn -> US7) = method22()
                    let v10583 : US7 = match v10564 with Choice1Of2 x -> v10581 x | Choice2Of2 x -> v10582 x
                    let _v10565 = v10583 
                    #endif
#else
                    let v10584 : (bool -> US7) = method21()
                    let v10585 : (exn -> US7) = method22()
                    let v10586 : US7 = match v10564 with Choice1Of2 x -> v10584 x | Choice2Of2 x -> v10585 x
                    let _v10565 = v10586 
                    #endif
                    let v10587 : US7 = _v10565 
                    return v10587 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10592 : Async<US7> = _v10563 
            let _v10523 = v10592 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10593 : unit = ()
            let _v10593 =
                async {
                    let! v10518 = v10518 
                    let v10594 : Choice<bool, exn> = v10518 
                    let v10595 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v10596 : US7 = null |> unbox<US7>
                    let _v10595 = v10596 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v10599 : US7 = null |> unbox<US7>
                    let _v10595 = v10599 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v10602 : US7 = null |> unbox<US7>
                    let _v10595 = v10602 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v10605 : US7 = null |> unbox<US7>
                    let _v10595 = v10605 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v10608 : US7 = null |> unbox<US7>
                    let _v10595 = v10608 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v10611 : (bool -> US7) = method21()
                    let v10612 : (exn -> US7) = method22()
                    let v10613 : US7 = match v10594 with Choice1Of2 x -> v10611 x | Choice2Of2 x -> v10612 x
                    let _v10595 = v10613 
                    #endif
#else
                    let v10614 : (bool -> US7) = method21()
                    let v10615 : (exn -> US7) = method22()
                    let v10616 : US7 = match v10594 with Choice1Of2 x -> v10614 x | Choice2Of2 x -> v10615 x
                    let _v10595 = v10616 
                    #endif
                    let v10617 : US7 = _v10595 
                    return v10617 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10622 : Async<US7> = _v10593 
            let _v10523 = v10622 
            #endif
#else
            let v10623 : unit = ()
            let _v10623 =
                async {
                    let! v10518 = v10518 
                    let v10624 : Choice<bool, exn> = v10518 
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
                    let v10641 : (bool -> US7) = method21()
                    let v10642 : (exn -> US7) = method22()
                    let v10643 : US7 = match v10624 with Choice1Of2 x -> v10641 x | Choice2Of2 x -> v10642 x
                    let _v10625 = v10643 
                    #endif
#else
                    let v10644 : (bool -> US7) = method21()
                    let v10645 : (exn -> US7) = method22()
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
            let _v10523 = v10652 
            #endif
            let v10653 : Async<US7> = _v10523 
            let v10658 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10659 : Async<US8> = null |> unbox<Async<US8>>
            let _v10658 = v10659 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10662 : Async<US8> = null |> unbox<Async<US8>>
            let _v10658 = v10662 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10665 : Async<US8> = null |> unbox<Async<US8>>
            let _v10658 = v10665 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10668 : unit = ()
            let _v10668 =
                async {
                    let! v10653 = v10653 
                    let v10669 : US7 = v10653 
                    let v10675 : US8 =
                        match v10669 with
                        | US7_0(v10670) -> (* C1of2 *)
                            US8_0(v10670)
                        | US7_1(v10672) -> (* C2of2 *)
                            US8_1(v10672)
                    return v10675 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10676 : Async<US8> = _v10668 
            let _v10658 = v10676 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10677 : unit = ()
            let _v10677 =
                async {
                    let! v10653 = v10653 
                    let v10678 : US7 = v10653 
                    let v10684 : US8 =
                        match v10678 with
                        | US7_0(v10679) -> (* C1of2 *)
                            US8_0(v10679)
                        | US7_1(v10681) -> (* C2of2 *)
                            US8_1(v10681)
                    return v10684 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10685 : Async<US8> = _v10677 
            let _v10658 = v10685 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10686 : unit = ()
            let _v10686 =
                async {
                    let! v10653 = v10653 
                    let v10687 : US7 = v10653 
                    let v10693 : US8 =
                        match v10687 with
                        | US7_0(v10688) -> (* C1of2 *)
                            US8_0(v10688)
                        | US7_1(v10690) -> (* C2of2 *)
                            US8_1(v10690)
                    return v10693 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10694 : Async<US8> = _v10686 
            let _v10658 = v10694 
            #endif
#else
            let v10695 : unit = ()
            let _v10695 =
                async {
                    let! v10653 = v10653 
                    let v10696 : US7 = v10653 
                    let v10702 : US8 =
                        match v10696 with
                        | US7_0(v10697) -> (* C1of2 *)
                            US8_0(v10697)
                        | US7_1(v10699) -> (* C2of2 *)
                            US8_1(v10699)
                    return v10702 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10703 : Async<US8> = _v10695 
            let _v10658 = v10703 
            #endif
            let v10704 : Async<US8> = _v10658 
            let v10709 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v10710 : Async<US6> = null |> unbox<Async<US6>>
            let _v10709 = v10710 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v10713 : Async<US6> = null |> unbox<Async<US6>>
            let _v10709 = v10713 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v10716 : Async<US6> = null |> unbox<Async<US6>>
            let _v10709 = v10716 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v10719 : unit = ()
            let _v10719 =
                async {
                    let! v10704 = v10704 
                    let v10720 : US8 = v10704 
                    let v10844 : US6 =
                        match v10720 with
                        | US8_1(v10723) -> (* Error *)
                            let v10724 : string = $"%A{v10723}"
                            let v10727 : string = "System.TimeoutException"
                            let v10728 : bool = v10724.Contains v10727 
                            if v10728 then
                                let v10731 : unit = ()
                                let v10732 : (unit -> unit) = closure16(v0)
                                let v10733 : unit = (fun () -> v10732 (); v10731) ()
                                US6_1
                            else
                                let v10774 : unit = ()
                                let v10775 : (unit -> unit) = closure17(v0, v10723)
                                let v10776 : unit = (fun () -> v10775 (); v10774) ()
                                US6_1
                        | US8_0(v10721) -> (* Ok *)
                            US6_0(v10721)
                    return v10844 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10845 : Async<US6> = _v10719 
            let _v10709 = v10845 
            #endif
#if FABLE_COMPILER_PYTHON
            let v10846 : unit = ()
            let _v10846 =
                async {
                    let! v10704 = v10704 
                    let v10847 : US8 = v10704 
                    let v10971 : US6 =
                        match v10847 with
                        | US8_1(v10850) -> (* Error *)
                            let v10851 : string = $"%A{v10850}"
                            let v10854 : string = "System.TimeoutException"
                            let v10855 : bool = v10851.Contains v10854 
                            if v10855 then
                                let v10858 : unit = ()
                                let v10859 : (unit -> unit) = closure16(v0)
                                let v10860 : unit = (fun () -> v10859 (); v10858) ()
                                US6_1
                            else
                                let v10901 : unit = ()
                                let v10902 : (unit -> unit) = closure17(v0, v10850)
                                let v10903 : unit = (fun () -> v10902 (); v10901) ()
                                US6_1
                        | US8_0(v10848) -> (* Ok *)
                            US6_0(v10848)
                    return v10971 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v10972 : Async<US6> = _v10846 
            let _v10709 = v10972 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v10973 : unit = ()
            let _v10973 =
                async {
                    let! v10704 = v10704 
                    let v10974 : US8 = v10704 
                    let v11098 : US6 =
                        match v10974 with
                        | US8_1(v10977) -> (* Error *)
                            let v10978 : string = $"%A{v10977}"
                            let v10981 : string = "System.TimeoutException"
                            let v10982 : bool = v10978.Contains v10981 
                            if v10982 then
                                let v10985 : unit = ()
                                let v10986 : (unit -> unit) = closure16(v0)
                                let v10987 : unit = (fun () -> v10986 (); v10985) ()
                                US6_1
                            else
                                let v11028 : unit = ()
                                let v11029 : (unit -> unit) = closure17(v0, v10977)
                                let v11030 : unit = (fun () -> v11029 (); v11028) ()
                                US6_1
                        | US8_0(v10975) -> (* Ok *)
                            US6_0(v10975)
                    return v11098 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11099 : Async<US6> = _v10973 
            let _v10709 = v11099 
            #endif
#else
            let v11100 : unit = ()
            let _v11100 =
                async {
                    let! v10704 = v10704 
                    let v11101 : US8 = v10704 
                    let v11225 : US6 =
                        match v11101 with
                        | US8_1(v11104) -> (* Error *)
                            let v11105 : string = $"%A{v11104}"
                            let v11108 : string = "System.TimeoutException"
                            let v11109 : bool = v11105.Contains v11108 
                            if v11109 then
                                let v11112 : unit = ()
                                let v11113 : (unit -> unit) = closure16(v0)
                                let v11114 : unit = (fun () -> v11113 (); v11112) ()
                                US6_1
                            else
                                let v11155 : unit = ()
                                let v11156 : (unit -> unit) = closure17(v0, v11104)
                                let v11157 : unit = (fun () -> v11156 (); v11155) ()
                                US6_1
                        | US8_0(v11102) -> (* Ok *)
                            US6_0(v11102)
                    return v11225 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11226 : Async<US6> = _v11100 
            let _v10709 = v11226 
            #endif
            let v11227 : Async<US6> = _v10709 
            return! v11227 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v11232 : Async<US6> = _v10488 
    let _v8988 = v11232 
    #endif
#else
    let v11233 : unit = ()
    let _v11233 =
        async {
            let v11234 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11235 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11235 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11236 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11236 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11237 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11237 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11238 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11238 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11239 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11239 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11240 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11240 
            #endif
#else
            let v11241 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11234 = v11241 
            #endif
            let v11242 : Async<Async<bool>> = _v11234 
            let! v11242 = v11242 
            let v11247 : Async<bool> = v11242 
            let v11248 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11249 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11250 : Async<Choice<bool, exn>> = v11249 v11247
            let _v11248 = v11250 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11251 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11252 : Async<Choice<bool, exn>> = v11251 v11247
            let _v11248 = v11252 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11253 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11254 : Async<Choice<bool, exn>> = v11253 v11247
            let _v11248 = v11254 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11255 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11256 : Async<Choice<bool, exn>> = v11255 v11247
            let _v11248 = v11256 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11257 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11258 : Async<Choice<bool, exn>> = v11257 v11247
            let _v11248 = v11258 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11259 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11260 : Async<Choice<bool, exn>> = v11259 v11247
            let _v11248 = v11260 
            #endif
#else
            let v11261 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v11262 : Async<Choice<bool, exn>> = v11261 v11247
            let _v11248 = v11262 
            #endif
            let v11263 : Async<Choice<bool, exn>> = _v11248 
            let v11268 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11269 : Async<US7> = null |> unbox<Async<US7>>
            let _v11268 = v11269 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11272 : Async<US7> = null |> unbox<Async<US7>>
            let _v11268 = v11272 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11275 : Async<US7> = null |> unbox<Async<US7>>
            let _v11268 = v11275 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11278 : unit = ()
            let _v11278 =
                async {
                    let! v11263 = v11263 
                    let v11279 : Choice<bool, exn> = v11263 
                    let v11280 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11281 : US7 = null |> unbox<US7>
                    let _v11280 = v11281 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11284 : US7 = null |> unbox<US7>
                    let _v11280 = v11284 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11287 : US7 = null |> unbox<US7>
                    let _v11280 = v11287 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11290 : US7 = null |> unbox<US7>
                    let _v11280 = v11290 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11293 : US7 = null |> unbox<US7>
                    let _v11280 = v11293 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11296 : (bool -> US7) = method21()
                    let v11297 : (exn -> US7) = method22()
                    let v11298 : US7 = match v11279 with Choice1Of2 x -> v11296 x | Choice2Of2 x -> v11297 x
                    let _v11280 = v11298 
                    #endif
#else
                    let v11299 : (bool -> US7) = method21()
                    let v11300 : (exn -> US7) = method22()
                    let v11301 : US7 = match v11279 with Choice1Of2 x -> v11299 x | Choice2Of2 x -> v11300 x
                    let _v11280 = v11301 
                    #endif
                    let v11302 : US7 = _v11280 
                    return v11302 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11307 : Async<US7> = _v11278 
            let _v11268 = v11307 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11308 : unit = ()
            let _v11308 =
                async {
                    let! v11263 = v11263 
                    let v11309 : Choice<bool, exn> = v11263 
                    let v11310 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11311 : US7 = null |> unbox<US7>
                    let _v11310 = v11311 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11314 : US7 = null |> unbox<US7>
                    let _v11310 = v11314 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11317 : US7 = null |> unbox<US7>
                    let _v11310 = v11317 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11320 : US7 = null |> unbox<US7>
                    let _v11310 = v11320 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11323 : US7 = null |> unbox<US7>
                    let _v11310 = v11323 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11326 : (bool -> US7) = method21()
                    let v11327 : (exn -> US7) = method22()
                    let v11328 : US7 = match v11309 with Choice1Of2 x -> v11326 x | Choice2Of2 x -> v11327 x
                    let _v11310 = v11328 
                    #endif
#else
                    let v11329 : (bool -> US7) = method21()
                    let v11330 : (exn -> US7) = method22()
                    let v11331 : US7 = match v11309 with Choice1Of2 x -> v11329 x | Choice2Of2 x -> v11330 x
                    let _v11310 = v11331 
                    #endif
                    let v11332 : US7 = _v11310 
                    return v11332 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11337 : Async<US7> = _v11308 
            let _v11268 = v11337 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11338 : unit = ()
            let _v11338 =
                async {
                    let! v11263 = v11263 
                    let v11339 : Choice<bool, exn> = v11263 
                    let v11340 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11341 : US7 = null |> unbox<US7>
                    let _v11340 = v11341 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11344 : US7 = null |> unbox<US7>
                    let _v11340 = v11344 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11347 : US7 = null |> unbox<US7>
                    let _v11340 = v11347 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11350 : US7 = null |> unbox<US7>
                    let _v11340 = v11350 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11353 : US7 = null |> unbox<US7>
                    let _v11340 = v11353 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11356 : (bool -> US7) = method21()
                    let v11357 : (exn -> US7) = method22()
                    let v11358 : US7 = match v11339 with Choice1Of2 x -> v11356 x | Choice2Of2 x -> v11357 x
                    let _v11340 = v11358 
                    #endif
#else
                    let v11359 : (bool -> US7) = method21()
                    let v11360 : (exn -> US7) = method22()
                    let v11361 : US7 = match v11339 with Choice1Of2 x -> v11359 x | Choice2Of2 x -> v11360 x
                    let _v11340 = v11361 
                    #endif
                    let v11362 : US7 = _v11340 
                    return v11362 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11367 : Async<US7> = _v11338 
            let _v11268 = v11367 
            #endif
#else
            let v11368 : unit = ()
            let _v11368 =
                async {
                    let! v11263 = v11263 
                    let v11369 : Choice<bool, exn> = v11263 
                    let v11370 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v11371 : US7 = null |> unbox<US7>
                    let _v11370 = v11371 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v11374 : US7 = null |> unbox<US7>
                    let _v11370 = v11374 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v11377 : US7 = null |> unbox<US7>
                    let _v11370 = v11377 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v11380 : US7 = null |> unbox<US7>
                    let _v11370 = v11380 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v11383 : US7 = null |> unbox<US7>
                    let _v11370 = v11383 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v11386 : (bool -> US7) = method21()
                    let v11387 : (exn -> US7) = method22()
                    let v11388 : US7 = match v11369 with Choice1Of2 x -> v11386 x | Choice2Of2 x -> v11387 x
                    let _v11370 = v11388 
                    #endif
#else
                    let v11389 : (bool -> US7) = method21()
                    let v11390 : (exn -> US7) = method22()
                    let v11391 : US7 = match v11369 with Choice1Of2 x -> v11389 x | Choice2Of2 x -> v11390 x
                    let _v11370 = v11391 
                    #endif
                    let v11392 : US7 = _v11370 
                    return v11392 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11397 : Async<US7> = _v11368 
            let _v11268 = v11397 
            #endif
            let v11398 : Async<US7> = _v11268 
            let v11403 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11404 : Async<US8> = null |> unbox<Async<US8>>
            let _v11403 = v11404 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11407 : Async<US8> = null |> unbox<Async<US8>>
            let _v11403 = v11407 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11410 : Async<US8> = null |> unbox<Async<US8>>
            let _v11403 = v11410 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11413 : unit = ()
            let _v11413 =
                async {
                    let! v11398 = v11398 
                    let v11414 : US7 = v11398 
                    let v11420 : US8 =
                        match v11414 with
                        | US7_0(v11415) -> (* C1of2 *)
                            US8_0(v11415)
                        | US7_1(v11417) -> (* C2of2 *)
                            US8_1(v11417)
                    return v11420 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11421 : Async<US8> = _v11413 
            let _v11403 = v11421 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11422 : unit = ()
            let _v11422 =
                async {
                    let! v11398 = v11398 
                    let v11423 : US7 = v11398 
                    let v11429 : US8 =
                        match v11423 with
                        | US7_0(v11424) -> (* C1of2 *)
                            US8_0(v11424)
                        | US7_1(v11426) -> (* C2of2 *)
                            US8_1(v11426)
                    return v11429 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11430 : Async<US8> = _v11422 
            let _v11403 = v11430 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11431 : unit = ()
            let _v11431 =
                async {
                    let! v11398 = v11398 
                    let v11432 : US7 = v11398 
                    let v11438 : US8 =
                        match v11432 with
                        | US7_0(v11433) -> (* C1of2 *)
                            US8_0(v11433)
                        | US7_1(v11435) -> (* C2of2 *)
                            US8_1(v11435)
                    return v11438 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11439 : Async<US8> = _v11431 
            let _v11403 = v11439 
            #endif
#else
            let v11440 : unit = ()
            let _v11440 =
                async {
                    let! v11398 = v11398 
                    let v11441 : US7 = v11398 
                    let v11447 : US8 =
                        match v11441 with
                        | US7_0(v11442) -> (* C1of2 *)
                            US8_0(v11442)
                        | US7_1(v11444) -> (* C2of2 *)
                            US8_1(v11444)
                    return v11447 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11448 : Async<US8> = _v11440 
            let _v11403 = v11448 
            #endif
            let v11449 : Async<US8> = _v11403 
            let v11454 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11455 : Async<US6> = null |> unbox<Async<US6>>
            let _v11454 = v11455 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11458 : Async<US6> = null |> unbox<Async<US6>>
            let _v11454 = v11458 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11461 : Async<US6> = null |> unbox<Async<US6>>
            let _v11454 = v11461 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11464 : unit = ()
            let _v11464 =
                async {
                    let! v11449 = v11449 
                    let v11465 : US8 = v11449 
                    let v11589 : US6 =
                        match v11465 with
                        | US8_1(v11468) -> (* Error *)
                            let v11469 : string = $"%A{v11468}"
                            let v11472 : string = "System.TimeoutException"
                            let v11473 : bool = v11469.Contains v11472 
                            if v11473 then
                                let v11476 : unit = ()
                                let v11477 : (unit -> unit) = closure16(v0)
                                let v11478 : unit = (fun () -> v11477 (); v11476) ()
                                US6_1
                            else
                                let v11519 : unit = ()
                                let v11520 : (unit -> unit) = closure17(v0, v11468)
                                let v11521 : unit = (fun () -> v11520 (); v11519) ()
                                US6_1
                        | US8_0(v11466) -> (* Ok *)
                            US6_0(v11466)
                    return v11589 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11590 : Async<US6> = _v11464 
            let _v11454 = v11590 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11591 : unit = ()
            let _v11591 =
                async {
                    let! v11449 = v11449 
                    let v11592 : US8 = v11449 
                    let v11716 : US6 =
                        match v11592 with
                        | US8_1(v11595) -> (* Error *)
                            let v11596 : string = $"%A{v11595}"
                            let v11599 : string = "System.TimeoutException"
                            let v11600 : bool = v11596.Contains v11599 
                            if v11600 then
                                let v11603 : unit = ()
                                let v11604 : (unit -> unit) = closure16(v0)
                                let v11605 : unit = (fun () -> v11604 (); v11603) ()
                                US6_1
                            else
                                let v11646 : unit = ()
                                let v11647 : (unit -> unit) = closure17(v0, v11595)
                                let v11648 : unit = (fun () -> v11647 (); v11646) ()
                                US6_1
                        | US8_0(v11593) -> (* Ok *)
                            US6_0(v11593)
                    return v11716 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11717 : Async<US6> = _v11591 
            let _v11454 = v11717 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v11718 : unit = ()
            let _v11718 =
                async {
                    let! v11449 = v11449 
                    let v11719 : US8 = v11449 
                    let v11843 : US6 =
                        match v11719 with
                        | US8_1(v11722) -> (* Error *)
                            let v11723 : string = $"%A{v11722}"
                            let v11726 : string = "System.TimeoutException"
                            let v11727 : bool = v11723.Contains v11726 
                            if v11727 then
                                let v11730 : unit = ()
                                let v11731 : (unit -> unit) = closure16(v0)
                                let v11732 : unit = (fun () -> v11731 (); v11730) ()
                                US6_1
                            else
                                let v11773 : unit = ()
                                let v11774 : (unit -> unit) = closure17(v0, v11722)
                                let v11775 : unit = (fun () -> v11774 (); v11773) ()
                                US6_1
                        | US8_0(v11720) -> (* Ok *)
                            US6_0(v11720)
                    return v11843 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11844 : Async<US6> = _v11718 
            let _v11454 = v11844 
            #endif
#else
            let v11845 : unit = ()
            let _v11845 =
                async {
                    let! v11449 = v11449 
                    let v11846 : US8 = v11449 
                    let v11970 : US6 =
                        match v11846 with
                        | US8_1(v11849) -> (* Error *)
                            let v11850 : string = $"%A{v11849}"
                            let v11853 : string = "System.TimeoutException"
                            let v11854 : bool = v11850.Contains v11853 
                            if v11854 then
                                let v11857 : unit = ()
                                let v11858 : (unit -> unit) = closure16(v0)
                                let v11859 : unit = (fun () -> v11858 (); v11857) ()
                                US6_1
                            else
                                let v11900 : unit = ()
                                let v11901 : (unit -> unit) = closure17(v0, v11849)
                                let v11902 : unit = (fun () -> v11901 (); v11900) ()
                                US6_1
                        | US8_0(v11847) -> (* Ok *)
                            US6_0(v11847)
                    return v11970 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v11971 : Async<US6> = _v11845 
            let _v11454 = v11971 
            #endif
            let v11972 : Async<US6> = _v11454 
            return! v11972 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v11977 : Async<US6> = _v11233 
    let _v8988 = v11977 
    #endif
    let v11978 : Async<US6> = _v8988 
    let _v2 = v11978 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11983 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11984 : Async<US6> = null |> unbox<Async<US6>>
    let _v11983 = v11984 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11987 : Async<US6> = null |> unbox<Async<US6>>
    let _v11983 = v11987 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11990 : Async<US6> = null |> unbox<Async<US6>>
    let _v11983 = v11990 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11993 : unit = ()
    let _v11993 =
        async {
            let v11994 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v11995 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v11995 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v11996 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v11996 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v11997 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v11997 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v11998 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v11998 
            #endif
#if FABLE_COMPILER_PYTHON
            let v11999 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v11999 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12000 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v12000 
            #endif
#else
            let v12001 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v11994 = v12001 
            #endif
            let v12002 : Async<Async<bool>> = _v11994 
            let! v12002 = v12002 
            let v12007 : Async<bool> = v12002 
            let v12008 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12009 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12010 : Async<Choice<bool, exn>> = v12009 v12007
            let _v12008 = v12010 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12011 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12012 : Async<Choice<bool, exn>> = v12011 v12007
            let _v12008 = v12012 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12013 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12014 : Async<Choice<bool, exn>> = v12013 v12007
            let _v12008 = v12014 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12015 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12016 : Async<Choice<bool, exn>> = v12015 v12007
            let _v12008 = v12016 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12017 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12018 : Async<Choice<bool, exn>> = v12017 v12007
            let _v12008 = v12018 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12019 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12020 : Async<Choice<bool, exn>> = v12019 v12007
            let _v12008 = v12020 
            #endif
#else
            let v12021 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12022 : Async<Choice<bool, exn>> = v12021 v12007
            let _v12008 = v12022 
            #endif
            let v12023 : Async<Choice<bool, exn>> = _v12008 
            let v12028 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12029 : Async<US7> = null |> unbox<Async<US7>>
            let _v12028 = v12029 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12032 : Async<US7> = null |> unbox<Async<US7>>
            let _v12028 = v12032 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12035 : Async<US7> = null |> unbox<Async<US7>>
            let _v12028 = v12035 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12038 : unit = ()
            let _v12038 =
                async {
                    let! v12023 = v12023 
                    let v12039 : Choice<bool, exn> = v12023 
                    let v12040 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12041 : US7 = null |> unbox<US7>
                    let _v12040 = v12041 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12044 : US7 = null |> unbox<US7>
                    let _v12040 = v12044 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12047 : US7 = null |> unbox<US7>
                    let _v12040 = v12047 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12050 : US7 = null |> unbox<US7>
                    let _v12040 = v12050 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12053 : US7 = null |> unbox<US7>
                    let _v12040 = v12053 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12056 : (bool -> US7) = method21()
                    let v12057 : (exn -> US7) = method22()
                    let v12058 : US7 = match v12039 with Choice1Of2 x -> v12056 x | Choice2Of2 x -> v12057 x
                    let _v12040 = v12058 
                    #endif
#else
                    let v12059 : (bool -> US7) = method21()
                    let v12060 : (exn -> US7) = method22()
                    let v12061 : US7 = match v12039 with Choice1Of2 x -> v12059 x | Choice2Of2 x -> v12060 x
                    let _v12040 = v12061 
                    #endif
                    let v12062 : US7 = _v12040 
                    return v12062 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12067 : Async<US7> = _v12038 
            let _v12028 = v12067 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12068 : unit = ()
            let _v12068 =
                async {
                    let! v12023 = v12023 
                    let v12069 : Choice<bool, exn> = v12023 
                    let v12070 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12071 : US7 = null |> unbox<US7>
                    let _v12070 = v12071 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12074 : US7 = null |> unbox<US7>
                    let _v12070 = v12074 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12077 : US7 = null |> unbox<US7>
                    let _v12070 = v12077 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12080 : US7 = null |> unbox<US7>
                    let _v12070 = v12080 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12083 : US7 = null |> unbox<US7>
                    let _v12070 = v12083 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12086 : (bool -> US7) = method21()
                    let v12087 : (exn -> US7) = method22()
                    let v12088 : US7 = match v12069 with Choice1Of2 x -> v12086 x | Choice2Of2 x -> v12087 x
                    let _v12070 = v12088 
                    #endif
#else
                    let v12089 : (bool -> US7) = method21()
                    let v12090 : (exn -> US7) = method22()
                    let v12091 : US7 = match v12069 with Choice1Of2 x -> v12089 x | Choice2Of2 x -> v12090 x
                    let _v12070 = v12091 
                    #endif
                    let v12092 : US7 = _v12070 
                    return v12092 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12097 : Async<US7> = _v12068 
            let _v12028 = v12097 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12098 : unit = ()
            let _v12098 =
                async {
                    let! v12023 = v12023 
                    let v12099 : Choice<bool, exn> = v12023 
                    let v12100 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12101 : US7 = null |> unbox<US7>
                    let _v12100 = v12101 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12104 : US7 = null |> unbox<US7>
                    let _v12100 = v12104 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12107 : US7 = null |> unbox<US7>
                    let _v12100 = v12107 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12110 : US7 = null |> unbox<US7>
                    let _v12100 = v12110 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12113 : US7 = null |> unbox<US7>
                    let _v12100 = v12113 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12116 : (bool -> US7) = method21()
                    let v12117 : (exn -> US7) = method22()
                    let v12118 : US7 = match v12099 with Choice1Of2 x -> v12116 x | Choice2Of2 x -> v12117 x
                    let _v12100 = v12118 
                    #endif
#else
                    let v12119 : (bool -> US7) = method21()
                    let v12120 : (exn -> US7) = method22()
                    let v12121 : US7 = match v12099 with Choice1Of2 x -> v12119 x | Choice2Of2 x -> v12120 x
                    let _v12100 = v12121 
                    #endif
                    let v12122 : US7 = _v12100 
                    return v12122 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12127 : Async<US7> = _v12098 
            let _v12028 = v12127 
            #endif
#else
            let v12128 : unit = ()
            let _v12128 =
                async {
                    let! v12023 = v12023 
                    let v12129 : Choice<bool, exn> = v12023 
                    let v12130 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12131 : US7 = null |> unbox<US7>
                    let _v12130 = v12131 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12134 : US7 = null |> unbox<US7>
                    let _v12130 = v12134 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12137 : US7 = null |> unbox<US7>
                    let _v12130 = v12137 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12140 : US7 = null |> unbox<US7>
                    let _v12130 = v12140 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12143 : US7 = null |> unbox<US7>
                    let _v12130 = v12143 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12146 : (bool -> US7) = method21()
                    let v12147 : (exn -> US7) = method22()
                    let v12148 : US7 = match v12129 with Choice1Of2 x -> v12146 x | Choice2Of2 x -> v12147 x
                    let _v12130 = v12148 
                    #endif
#else
                    let v12149 : (bool -> US7) = method21()
                    let v12150 : (exn -> US7) = method22()
                    let v12151 : US7 = match v12129 with Choice1Of2 x -> v12149 x | Choice2Of2 x -> v12150 x
                    let _v12130 = v12151 
                    #endif
                    let v12152 : US7 = _v12130 
                    return v12152 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12157 : Async<US7> = _v12128 
            let _v12028 = v12157 
            #endif
            let v12158 : Async<US7> = _v12028 
            let v12163 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12164 : Async<US8> = null |> unbox<Async<US8>>
            let _v12163 = v12164 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12167 : Async<US8> = null |> unbox<Async<US8>>
            let _v12163 = v12167 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12170 : Async<US8> = null |> unbox<Async<US8>>
            let _v12163 = v12170 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12173 : unit = ()
            let _v12173 =
                async {
                    let! v12158 = v12158 
                    let v12174 : US7 = v12158 
                    let v12180 : US8 =
                        match v12174 with
                        | US7_0(v12175) -> (* C1of2 *)
                            US8_0(v12175)
                        | US7_1(v12177) -> (* C2of2 *)
                            US8_1(v12177)
                    return v12180 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12181 : Async<US8> = _v12173 
            let _v12163 = v12181 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12182 : unit = ()
            let _v12182 =
                async {
                    let! v12158 = v12158 
                    let v12183 : US7 = v12158 
                    let v12189 : US8 =
                        match v12183 with
                        | US7_0(v12184) -> (* C1of2 *)
                            US8_0(v12184)
                        | US7_1(v12186) -> (* C2of2 *)
                            US8_1(v12186)
                    return v12189 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12190 : Async<US8> = _v12182 
            let _v12163 = v12190 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12191 : unit = ()
            let _v12191 =
                async {
                    let! v12158 = v12158 
                    let v12192 : US7 = v12158 
                    let v12198 : US8 =
                        match v12192 with
                        | US7_0(v12193) -> (* C1of2 *)
                            US8_0(v12193)
                        | US7_1(v12195) -> (* C2of2 *)
                            US8_1(v12195)
                    return v12198 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12199 : Async<US8> = _v12191 
            let _v12163 = v12199 
            #endif
#else
            let v12200 : unit = ()
            let _v12200 =
                async {
                    let! v12158 = v12158 
                    let v12201 : US7 = v12158 
                    let v12207 : US8 =
                        match v12201 with
                        | US7_0(v12202) -> (* C1of2 *)
                            US8_0(v12202)
                        | US7_1(v12204) -> (* C2of2 *)
                            US8_1(v12204)
                    return v12207 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12208 : Async<US8> = _v12200 
            let _v12163 = v12208 
            #endif
            let v12209 : Async<US8> = _v12163 
            let v12214 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12215 : Async<US6> = null |> unbox<Async<US6>>
            let _v12214 = v12215 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12218 : Async<US6> = null |> unbox<Async<US6>>
            let _v12214 = v12218 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12221 : Async<US6> = null |> unbox<Async<US6>>
            let _v12214 = v12221 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12224 : unit = ()
            let _v12224 =
                async {
                    let! v12209 = v12209 
                    let v12225 : US8 = v12209 
                    let v12349 : US6 =
                        match v12225 with
                        | US8_1(v12228) -> (* Error *)
                            let v12229 : string = $"%A{v12228}"
                            let v12232 : string = "System.TimeoutException"
                            let v12233 : bool = v12229.Contains v12232 
                            if v12233 then
                                let v12236 : unit = ()
                                let v12237 : (unit -> unit) = closure16(v0)
                                let v12238 : unit = (fun () -> v12237 (); v12236) ()
                                US6_1
                            else
                                let v12279 : unit = ()
                                let v12280 : (unit -> unit) = closure17(v0, v12228)
                                let v12281 : unit = (fun () -> v12280 (); v12279) ()
                                US6_1
                        | US8_0(v12226) -> (* Ok *)
                            US6_0(v12226)
                    return v12349 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12350 : Async<US6> = _v12224 
            let _v12214 = v12350 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12351 : unit = ()
            let _v12351 =
                async {
                    let! v12209 = v12209 
                    let v12352 : US8 = v12209 
                    let v12476 : US6 =
                        match v12352 with
                        | US8_1(v12355) -> (* Error *)
                            let v12356 : string = $"%A{v12355}"
                            let v12359 : string = "System.TimeoutException"
                            let v12360 : bool = v12356.Contains v12359 
                            if v12360 then
                                let v12363 : unit = ()
                                let v12364 : (unit -> unit) = closure16(v0)
                                let v12365 : unit = (fun () -> v12364 (); v12363) ()
                                US6_1
                            else
                                let v12406 : unit = ()
                                let v12407 : (unit -> unit) = closure17(v0, v12355)
                                let v12408 : unit = (fun () -> v12407 (); v12406) ()
                                US6_1
                        | US8_0(v12353) -> (* Ok *)
                            US6_0(v12353)
                    return v12476 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12477 : Async<US6> = _v12351 
            let _v12214 = v12477 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12478 : unit = ()
            let _v12478 =
                async {
                    let! v12209 = v12209 
                    let v12479 : US8 = v12209 
                    let v12603 : US6 =
                        match v12479 with
                        | US8_1(v12482) -> (* Error *)
                            let v12483 : string = $"%A{v12482}"
                            let v12486 : string = "System.TimeoutException"
                            let v12487 : bool = v12483.Contains v12486 
                            if v12487 then
                                let v12490 : unit = ()
                                let v12491 : (unit -> unit) = closure16(v0)
                                let v12492 : unit = (fun () -> v12491 (); v12490) ()
                                US6_1
                            else
                                let v12533 : unit = ()
                                let v12534 : (unit -> unit) = closure17(v0, v12482)
                                let v12535 : unit = (fun () -> v12534 (); v12533) ()
                                US6_1
                        | US8_0(v12480) -> (* Ok *)
                            US6_0(v12480)
                    return v12603 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12604 : Async<US6> = _v12478 
            let _v12214 = v12604 
            #endif
#else
            let v12605 : unit = ()
            let _v12605 =
                async {
                    let! v12209 = v12209 
                    let v12606 : US8 = v12209 
                    let v12730 : US6 =
                        match v12606 with
                        | US8_1(v12609) -> (* Error *)
                            let v12610 : string = $"%A{v12609}"
                            let v12613 : string = "System.TimeoutException"
                            let v12614 : bool = v12610.Contains v12613 
                            if v12614 then
                                let v12617 : unit = ()
                                let v12618 : (unit -> unit) = closure16(v0)
                                let v12619 : unit = (fun () -> v12618 (); v12617) ()
                                US6_1
                            else
                                let v12660 : unit = ()
                                let v12661 : (unit -> unit) = closure17(v0, v12609)
                                let v12662 : unit = (fun () -> v12661 (); v12660) ()
                                US6_1
                        | US8_0(v12607) -> (* Ok *)
                            US6_0(v12607)
                    return v12730 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12731 : Async<US6> = _v12605 
            let _v12214 = v12731 
            #endif
            let v12732 : Async<US6> = _v12214 
            return! v12732 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v12737 : Async<US6> = _v11993 
    let _v11983 = v12737 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12738 : unit = ()
    let _v12738 =
        async {
            let v12739 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12740 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12740 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12741 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12741 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12742 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12742 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12743 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12743 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12744 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12744 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12745 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12745 
            #endif
#else
            let v12746 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v12739 = v12746 
            #endif
            let v12747 : Async<Async<bool>> = _v12739 
            let! v12747 = v12747 
            let v12752 : Async<bool> = v12747 
            let v12753 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12754 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12755 : Async<Choice<bool, exn>> = v12754 v12752
            let _v12753 = v12755 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12756 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12757 : Async<Choice<bool, exn>> = v12756 v12752
            let _v12753 = v12757 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12758 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12759 : Async<Choice<bool, exn>> = v12758 v12752
            let _v12753 = v12759 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12760 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12761 : Async<Choice<bool, exn>> = v12760 v12752
            let _v12753 = v12761 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12762 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12763 : Async<Choice<bool, exn>> = v12762 v12752
            let _v12753 = v12763 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12764 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12765 : Async<Choice<bool, exn>> = v12764 v12752
            let _v12753 = v12765 
            #endif
#else
            let v12766 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v12767 : Async<Choice<bool, exn>> = v12766 v12752
            let _v12753 = v12767 
            #endif
            let v12768 : Async<Choice<bool, exn>> = _v12753 
            let v12773 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12774 : Async<US7> = null |> unbox<Async<US7>>
            let _v12773 = v12774 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12777 : Async<US7> = null |> unbox<Async<US7>>
            let _v12773 = v12777 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12780 : Async<US7> = null |> unbox<Async<US7>>
            let _v12773 = v12780 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12783 : unit = ()
            let _v12783 =
                async {
                    let! v12768 = v12768 
                    let v12784 : Choice<bool, exn> = v12768 
                    let v12785 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12786 : US7 = null |> unbox<US7>
                    let _v12785 = v12786 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12789 : US7 = null |> unbox<US7>
                    let _v12785 = v12789 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12792 : US7 = null |> unbox<US7>
                    let _v12785 = v12792 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12795 : US7 = null |> unbox<US7>
                    let _v12785 = v12795 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12798 : US7 = null |> unbox<US7>
                    let _v12785 = v12798 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12801 : (bool -> US7) = method21()
                    let v12802 : (exn -> US7) = method22()
                    let v12803 : US7 = match v12784 with Choice1Of2 x -> v12801 x | Choice2Of2 x -> v12802 x
                    let _v12785 = v12803 
                    #endif
#else
                    let v12804 : (bool -> US7) = method21()
                    let v12805 : (exn -> US7) = method22()
                    let v12806 : US7 = match v12784 with Choice1Of2 x -> v12804 x | Choice2Of2 x -> v12805 x
                    let _v12785 = v12806 
                    #endif
                    let v12807 : US7 = _v12785 
                    return v12807 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12812 : Async<US7> = _v12783 
            let _v12773 = v12812 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12813 : unit = ()
            let _v12813 =
                async {
                    let! v12768 = v12768 
                    let v12814 : Choice<bool, exn> = v12768 
                    let v12815 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12816 : US7 = null |> unbox<US7>
                    let _v12815 = v12816 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12819 : US7 = null |> unbox<US7>
                    let _v12815 = v12819 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12822 : US7 = null |> unbox<US7>
                    let _v12815 = v12822 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12825 : US7 = null |> unbox<US7>
                    let _v12815 = v12825 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12828 : US7 = null |> unbox<US7>
                    let _v12815 = v12828 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12831 : (bool -> US7) = method21()
                    let v12832 : (exn -> US7) = method22()
                    let v12833 : US7 = match v12814 with Choice1Of2 x -> v12831 x | Choice2Of2 x -> v12832 x
                    let _v12815 = v12833 
                    #endif
#else
                    let v12834 : (bool -> US7) = method21()
                    let v12835 : (exn -> US7) = method22()
                    let v12836 : US7 = match v12814 with Choice1Of2 x -> v12834 x | Choice2Of2 x -> v12835 x
                    let _v12815 = v12836 
                    #endif
                    let v12837 : US7 = _v12815 
                    return v12837 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12842 : Async<US7> = _v12813 
            let _v12773 = v12842 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12843 : unit = ()
            let _v12843 =
                async {
                    let! v12768 = v12768 
                    let v12844 : Choice<bool, exn> = v12768 
                    let v12845 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12846 : US7 = null |> unbox<US7>
                    let _v12845 = v12846 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12849 : US7 = null |> unbox<US7>
                    let _v12845 = v12849 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12852 : US7 = null |> unbox<US7>
                    let _v12845 = v12852 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12855 : US7 = null |> unbox<US7>
                    let _v12845 = v12855 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12858 : US7 = null |> unbox<US7>
                    let _v12845 = v12858 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12861 : (bool -> US7) = method21()
                    let v12862 : (exn -> US7) = method22()
                    let v12863 : US7 = match v12844 with Choice1Of2 x -> v12861 x | Choice2Of2 x -> v12862 x
                    let _v12845 = v12863 
                    #endif
#else
                    let v12864 : (bool -> US7) = method21()
                    let v12865 : (exn -> US7) = method22()
                    let v12866 : US7 = match v12844 with Choice1Of2 x -> v12864 x | Choice2Of2 x -> v12865 x
                    let _v12845 = v12866 
                    #endif
                    let v12867 : US7 = _v12845 
                    return v12867 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12872 : Async<US7> = _v12843 
            let _v12773 = v12872 
            #endif
#else
            let v12873 : unit = ()
            let _v12873 =
                async {
                    let! v12768 = v12768 
                    let v12874 : Choice<bool, exn> = v12768 
                    let v12875 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v12876 : US7 = null |> unbox<US7>
                    let _v12875 = v12876 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v12879 : US7 = null |> unbox<US7>
                    let _v12875 = v12879 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v12882 : US7 = null |> unbox<US7>
                    let _v12875 = v12882 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v12885 : US7 = null |> unbox<US7>
                    let _v12875 = v12885 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v12888 : US7 = null |> unbox<US7>
                    let _v12875 = v12888 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v12891 : (bool -> US7) = method21()
                    let v12892 : (exn -> US7) = method22()
                    let v12893 : US7 = match v12874 with Choice1Of2 x -> v12891 x | Choice2Of2 x -> v12892 x
                    let _v12875 = v12893 
                    #endif
#else
                    let v12894 : (bool -> US7) = method21()
                    let v12895 : (exn -> US7) = method22()
                    let v12896 : US7 = match v12874 with Choice1Of2 x -> v12894 x | Choice2Of2 x -> v12895 x
                    let _v12875 = v12896 
                    #endif
                    let v12897 : US7 = _v12875 
                    return v12897 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12902 : Async<US7> = _v12873 
            let _v12773 = v12902 
            #endif
            let v12903 : Async<US7> = _v12773 
            let v12908 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12909 : Async<US8> = null |> unbox<Async<US8>>
            let _v12908 = v12909 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12912 : Async<US8> = null |> unbox<Async<US8>>
            let _v12908 = v12912 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12915 : Async<US8> = null |> unbox<Async<US8>>
            let _v12908 = v12915 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12918 : unit = ()
            let _v12918 =
                async {
                    let! v12903 = v12903 
                    let v12919 : US7 = v12903 
                    let v12925 : US8 =
                        match v12919 with
                        | US7_0(v12920) -> (* C1of2 *)
                            US8_0(v12920)
                        | US7_1(v12922) -> (* C2of2 *)
                            US8_1(v12922)
                    return v12925 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12926 : Async<US8> = _v12918 
            let _v12908 = v12926 
            #endif
#if FABLE_COMPILER_PYTHON
            let v12927 : unit = ()
            let _v12927 =
                async {
                    let! v12903 = v12903 
                    let v12928 : US7 = v12903 
                    let v12934 : US8 =
                        match v12928 with
                        | US7_0(v12929) -> (* C1of2 *)
                            US8_0(v12929)
                        | US7_1(v12931) -> (* C2of2 *)
                            US8_1(v12931)
                    return v12934 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12935 : Async<US8> = _v12927 
            let _v12908 = v12935 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v12936 : unit = ()
            let _v12936 =
                async {
                    let! v12903 = v12903 
                    let v12937 : US7 = v12903 
                    let v12943 : US8 =
                        match v12937 with
                        | US7_0(v12938) -> (* C1of2 *)
                            US8_0(v12938)
                        | US7_1(v12940) -> (* C2of2 *)
                            US8_1(v12940)
                    return v12943 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12944 : Async<US8> = _v12936 
            let _v12908 = v12944 
            #endif
#else
            let v12945 : unit = ()
            let _v12945 =
                async {
                    let! v12903 = v12903 
                    let v12946 : US7 = v12903 
                    let v12952 : US8 =
                        match v12946 with
                        | US7_0(v12947) -> (* C1of2 *)
                            US8_0(v12947)
                        | US7_1(v12949) -> (* C2of2 *)
                            US8_1(v12949)
                    return v12952 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v12953 : Async<US8> = _v12945 
            let _v12908 = v12953 
            #endif
            let v12954 : Async<US8> = _v12908 
            let v12959 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v12960 : Async<US6> = null |> unbox<Async<US6>>
            let _v12959 = v12960 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v12963 : Async<US6> = null |> unbox<Async<US6>>
            let _v12959 = v12963 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v12966 : Async<US6> = null |> unbox<Async<US6>>
            let _v12959 = v12966 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v12969 : unit = ()
            let _v12969 =
                async {
                    let! v12954 = v12954 
                    let v12970 : US8 = v12954 
                    let v13094 : US6 =
                        match v12970 with
                        | US8_1(v12973) -> (* Error *)
                            let v12974 : string = $"%A{v12973}"
                            let v12977 : string = "System.TimeoutException"
                            let v12978 : bool = v12974.Contains v12977 
                            if v12978 then
                                let v12981 : unit = ()
                                let v12982 : (unit -> unit) = closure16(v0)
                                let v12983 : unit = (fun () -> v12982 (); v12981) ()
                                US6_1
                            else
                                let v13024 : unit = ()
                                let v13025 : (unit -> unit) = closure17(v0, v12973)
                                let v13026 : unit = (fun () -> v13025 (); v13024) ()
                                US6_1
                        | US8_0(v12971) -> (* Ok *)
                            US6_0(v12971)
                    return v13094 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13095 : Async<US6> = _v12969 
            let _v12959 = v13095 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13096 : unit = ()
            let _v13096 =
                async {
                    let! v12954 = v12954 
                    let v13097 : US8 = v12954 
                    let v13221 : US6 =
                        match v13097 with
                        | US8_1(v13100) -> (* Error *)
                            let v13101 : string = $"%A{v13100}"
                            let v13104 : string = "System.TimeoutException"
                            let v13105 : bool = v13101.Contains v13104 
                            if v13105 then
                                let v13108 : unit = ()
                                let v13109 : (unit -> unit) = closure16(v0)
                                let v13110 : unit = (fun () -> v13109 (); v13108) ()
                                US6_1
                            else
                                let v13151 : unit = ()
                                let v13152 : (unit -> unit) = closure17(v0, v13100)
                                let v13153 : unit = (fun () -> v13152 (); v13151) ()
                                US6_1
                        | US8_0(v13098) -> (* Ok *)
                            US6_0(v13098)
                    return v13221 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13222 : Async<US6> = _v13096 
            let _v12959 = v13222 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13223 : unit = ()
            let _v13223 =
                async {
                    let! v12954 = v12954 
                    let v13224 : US8 = v12954 
                    let v13348 : US6 =
                        match v13224 with
                        | US8_1(v13227) -> (* Error *)
                            let v13228 : string = $"%A{v13227}"
                            let v13231 : string = "System.TimeoutException"
                            let v13232 : bool = v13228.Contains v13231 
                            if v13232 then
                                let v13235 : unit = ()
                                let v13236 : (unit -> unit) = closure16(v0)
                                let v13237 : unit = (fun () -> v13236 (); v13235) ()
                                US6_1
                            else
                                let v13278 : unit = ()
                                let v13279 : (unit -> unit) = closure17(v0, v13227)
                                let v13280 : unit = (fun () -> v13279 (); v13278) ()
                                US6_1
                        | US8_0(v13225) -> (* Ok *)
                            US6_0(v13225)
                    return v13348 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13349 : Async<US6> = _v13223 
            let _v12959 = v13349 
            #endif
#else
            let v13350 : unit = ()
            let _v13350 =
                async {
                    let! v12954 = v12954 
                    let v13351 : US8 = v12954 
                    let v13475 : US6 =
                        match v13351 with
                        | US8_1(v13354) -> (* Error *)
                            let v13355 : string = $"%A{v13354}"
                            let v13358 : string = "System.TimeoutException"
                            let v13359 : bool = v13355.Contains v13358 
                            if v13359 then
                                let v13362 : unit = ()
                                let v13363 : (unit -> unit) = closure16(v0)
                                let v13364 : unit = (fun () -> v13363 (); v13362) ()
                                US6_1
                            else
                                let v13405 : unit = ()
                                let v13406 : (unit -> unit) = closure17(v0, v13354)
                                let v13407 : unit = (fun () -> v13406 (); v13405) ()
                                US6_1
                        | US8_0(v13352) -> (* Ok *)
                            US6_0(v13352)
                    return v13475 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13476 : Async<US6> = _v13350 
            let _v12959 = v13476 
            #endif
            let v13477 : Async<US6> = _v12959 
            return! v13477 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v13482 : Async<US6> = _v12738 
    let _v11983 = v13482 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v13483 : unit = ()
    let _v13483 =
        async {
            let v13484 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13485 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13485 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13486 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13486 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13487 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13487 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13488 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13488 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13489 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13489 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13490 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13490 
            #endif
#else
            let v13491 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v13484 = v13491 
            #endif
            let v13492 : Async<Async<bool>> = _v13484 
            let! v13492 = v13492 
            let v13497 : Async<bool> = v13492 
            let v13498 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13499 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13500 : Async<Choice<bool, exn>> = v13499 v13497
            let _v13498 = v13500 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13501 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13502 : Async<Choice<bool, exn>> = v13501 v13497
            let _v13498 = v13502 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13503 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13504 : Async<Choice<bool, exn>> = v13503 v13497
            let _v13498 = v13504 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13505 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13506 : Async<Choice<bool, exn>> = v13505 v13497
            let _v13498 = v13506 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13507 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13508 : Async<Choice<bool, exn>> = v13507 v13497
            let _v13498 = v13508 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13509 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13510 : Async<Choice<bool, exn>> = v13509 v13497
            let _v13498 = v13510 
            #endif
#else
            let v13511 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v13512 : Async<Choice<bool, exn>> = v13511 v13497
            let _v13498 = v13512 
            #endif
            let v13513 : Async<Choice<bool, exn>> = _v13498 
            let v13518 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13519 : Async<US7> = null |> unbox<Async<US7>>
            let _v13518 = v13519 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13522 : Async<US7> = null |> unbox<Async<US7>>
            let _v13518 = v13522 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13525 : Async<US7> = null |> unbox<Async<US7>>
            let _v13518 = v13525 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13528 : unit = ()
            let _v13528 =
                async {
                    let! v13513 = v13513 
                    let v13529 : Choice<bool, exn> = v13513 
                    let v13530 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13531 : US7 = null |> unbox<US7>
                    let _v13530 = v13531 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13534 : US7 = null |> unbox<US7>
                    let _v13530 = v13534 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13537 : US7 = null |> unbox<US7>
                    let _v13530 = v13537 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13540 : US7 = null |> unbox<US7>
                    let _v13530 = v13540 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13543 : US7 = null |> unbox<US7>
                    let _v13530 = v13543 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13546 : (bool -> US7) = method21()
                    let v13547 : (exn -> US7) = method22()
                    let v13548 : US7 = match v13529 with Choice1Of2 x -> v13546 x | Choice2Of2 x -> v13547 x
                    let _v13530 = v13548 
                    #endif
#else
                    let v13549 : (bool -> US7) = method21()
                    let v13550 : (exn -> US7) = method22()
                    let v13551 : US7 = match v13529 with Choice1Of2 x -> v13549 x | Choice2Of2 x -> v13550 x
                    let _v13530 = v13551 
                    #endif
                    let v13552 : US7 = _v13530 
                    return v13552 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13557 : Async<US7> = _v13528 
            let _v13518 = v13557 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13558 : unit = ()
            let _v13558 =
                async {
                    let! v13513 = v13513 
                    let v13559 : Choice<bool, exn> = v13513 
                    let v13560 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13561 : US7 = null |> unbox<US7>
                    let _v13560 = v13561 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13564 : US7 = null |> unbox<US7>
                    let _v13560 = v13564 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13567 : US7 = null |> unbox<US7>
                    let _v13560 = v13567 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13570 : US7 = null |> unbox<US7>
                    let _v13560 = v13570 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13573 : US7 = null |> unbox<US7>
                    let _v13560 = v13573 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13576 : (bool -> US7) = method21()
                    let v13577 : (exn -> US7) = method22()
                    let v13578 : US7 = match v13559 with Choice1Of2 x -> v13576 x | Choice2Of2 x -> v13577 x
                    let _v13560 = v13578 
                    #endif
#else
                    let v13579 : (bool -> US7) = method21()
                    let v13580 : (exn -> US7) = method22()
                    let v13581 : US7 = match v13559 with Choice1Of2 x -> v13579 x | Choice2Of2 x -> v13580 x
                    let _v13560 = v13581 
                    #endif
                    let v13582 : US7 = _v13560 
                    return v13582 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13587 : Async<US7> = _v13558 
            let _v13518 = v13587 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13588 : unit = ()
            let _v13588 =
                async {
                    let! v13513 = v13513 
                    let v13589 : Choice<bool, exn> = v13513 
                    let v13590 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13591 : US7 = null |> unbox<US7>
                    let _v13590 = v13591 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13594 : US7 = null |> unbox<US7>
                    let _v13590 = v13594 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13597 : US7 = null |> unbox<US7>
                    let _v13590 = v13597 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13600 : US7 = null |> unbox<US7>
                    let _v13590 = v13600 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13603 : US7 = null |> unbox<US7>
                    let _v13590 = v13603 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13606 : (bool -> US7) = method21()
                    let v13607 : (exn -> US7) = method22()
                    let v13608 : US7 = match v13589 with Choice1Of2 x -> v13606 x | Choice2Of2 x -> v13607 x
                    let _v13590 = v13608 
                    #endif
#else
                    let v13609 : (bool -> US7) = method21()
                    let v13610 : (exn -> US7) = method22()
                    let v13611 : US7 = match v13589 with Choice1Of2 x -> v13609 x | Choice2Of2 x -> v13610 x
                    let _v13590 = v13611 
                    #endif
                    let v13612 : US7 = _v13590 
                    return v13612 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13617 : Async<US7> = _v13588 
            let _v13518 = v13617 
            #endif
#else
            let v13618 : unit = ()
            let _v13618 =
                async {
                    let! v13513 = v13513 
                    let v13619 : Choice<bool, exn> = v13513 
                    let v13620 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v13621 : US7 = null |> unbox<US7>
                    let _v13620 = v13621 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v13624 : US7 = null |> unbox<US7>
                    let _v13620 = v13624 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v13627 : US7 = null |> unbox<US7>
                    let _v13620 = v13627 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v13630 : US7 = null |> unbox<US7>
                    let _v13620 = v13630 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v13633 : US7 = null |> unbox<US7>
                    let _v13620 = v13633 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v13636 : (bool -> US7) = method21()
                    let v13637 : (exn -> US7) = method22()
                    let v13638 : US7 = match v13619 with Choice1Of2 x -> v13636 x | Choice2Of2 x -> v13637 x
                    let _v13620 = v13638 
                    #endif
#else
                    let v13639 : (bool -> US7) = method21()
                    let v13640 : (exn -> US7) = method22()
                    let v13641 : US7 = match v13619 with Choice1Of2 x -> v13639 x | Choice2Of2 x -> v13640 x
                    let _v13620 = v13641 
                    #endif
                    let v13642 : US7 = _v13620 
                    return v13642 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13647 : Async<US7> = _v13618 
            let _v13518 = v13647 
            #endif
            let v13648 : Async<US7> = _v13518 
            let v13653 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13654 : Async<US8> = null |> unbox<Async<US8>>
            let _v13653 = v13654 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13657 : Async<US8> = null |> unbox<Async<US8>>
            let _v13653 = v13657 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13660 : Async<US8> = null |> unbox<Async<US8>>
            let _v13653 = v13660 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13663 : unit = ()
            let _v13663 =
                async {
                    let! v13648 = v13648 
                    let v13664 : US7 = v13648 
                    let v13670 : US8 =
                        match v13664 with
                        | US7_0(v13665) -> (* C1of2 *)
                            US8_0(v13665)
                        | US7_1(v13667) -> (* C2of2 *)
                            US8_1(v13667)
                    return v13670 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13671 : Async<US8> = _v13663 
            let _v13653 = v13671 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13672 : unit = ()
            let _v13672 =
                async {
                    let! v13648 = v13648 
                    let v13673 : US7 = v13648 
                    let v13679 : US8 =
                        match v13673 with
                        | US7_0(v13674) -> (* C1of2 *)
                            US8_0(v13674)
                        | US7_1(v13676) -> (* C2of2 *)
                            US8_1(v13676)
                    return v13679 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13680 : Async<US8> = _v13672 
            let _v13653 = v13680 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13681 : unit = ()
            let _v13681 =
                async {
                    let! v13648 = v13648 
                    let v13682 : US7 = v13648 
                    let v13688 : US8 =
                        match v13682 with
                        | US7_0(v13683) -> (* C1of2 *)
                            US8_0(v13683)
                        | US7_1(v13685) -> (* C2of2 *)
                            US8_1(v13685)
                    return v13688 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13689 : Async<US8> = _v13681 
            let _v13653 = v13689 
            #endif
#else
            let v13690 : unit = ()
            let _v13690 =
                async {
                    let! v13648 = v13648 
                    let v13691 : US7 = v13648 
                    let v13697 : US8 =
                        match v13691 with
                        | US7_0(v13692) -> (* C1of2 *)
                            US8_0(v13692)
                        | US7_1(v13694) -> (* C2of2 *)
                            US8_1(v13694)
                    return v13697 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13698 : Async<US8> = _v13690 
            let _v13653 = v13698 
            #endif
            let v13699 : Async<US8> = _v13653 
            let v13704 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v13705 : Async<US6> = null |> unbox<Async<US6>>
            let _v13704 = v13705 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v13708 : Async<US6> = null |> unbox<Async<US6>>
            let _v13704 = v13708 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v13711 : Async<US6> = null |> unbox<Async<US6>>
            let _v13704 = v13711 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v13714 : unit = ()
            let _v13714 =
                async {
                    let! v13699 = v13699 
                    let v13715 : US8 = v13699 
                    let v13839 : US6 =
                        match v13715 with
                        | US8_1(v13718) -> (* Error *)
                            let v13719 : string = $"%A{v13718}"
                            let v13722 : string = "System.TimeoutException"
                            let v13723 : bool = v13719.Contains v13722 
                            if v13723 then
                                let v13726 : unit = ()
                                let v13727 : (unit -> unit) = closure16(v0)
                                let v13728 : unit = (fun () -> v13727 (); v13726) ()
                                US6_1
                            else
                                let v13769 : unit = ()
                                let v13770 : (unit -> unit) = closure17(v0, v13718)
                                let v13771 : unit = (fun () -> v13770 (); v13769) ()
                                US6_1
                        | US8_0(v13716) -> (* Ok *)
                            US6_0(v13716)
                    return v13839 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13840 : Async<US6> = _v13714 
            let _v13704 = v13840 
            #endif
#if FABLE_COMPILER_PYTHON
            let v13841 : unit = ()
            let _v13841 =
                async {
                    let! v13699 = v13699 
                    let v13842 : US8 = v13699 
                    let v13966 : US6 =
                        match v13842 with
                        | US8_1(v13845) -> (* Error *)
                            let v13846 : string = $"%A{v13845}"
                            let v13849 : string = "System.TimeoutException"
                            let v13850 : bool = v13846.Contains v13849 
                            if v13850 then
                                let v13853 : unit = ()
                                let v13854 : (unit -> unit) = closure16(v0)
                                let v13855 : unit = (fun () -> v13854 (); v13853) ()
                                US6_1
                            else
                                let v13896 : unit = ()
                                let v13897 : (unit -> unit) = closure17(v0, v13845)
                                let v13898 : unit = (fun () -> v13897 (); v13896) ()
                                US6_1
                        | US8_0(v13843) -> (* Ok *)
                            US6_0(v13843)
                    return v13966 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v13967 : Async<US6> = _v13841 
            let _v13704 = v13967 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v13968 : unit = ()
            let _v13968 =
                async {
                    let! v13699 = v13699 
                    let v13969 : US8 = v13699 
                    let v14093 : US6 =
                        match v13969 with
                        | US8_1(v13972) -> (* Error *)
                            let v13973 : string = $"%A{v13972}"
                            let v13976 : string = "System.TimeoutException"
                            let v13977 : bool = v13973.Contains v13976 
                            if v13977 then
                                let v13980 : unit = ()
                                let v13981 : (unit -> unit) = closure16(v0)
                                let v13982 : unit = (fun () -> v13981 (); v13980) ()
                                US6_1
                            else
                                let v14023 : unit = ()
                                let v14024 : (unit -> unit) = closure17(v0, v13972)
                                let v14025 : unit = (fun () -> v14024 (); v14023) ()
                                US6_1
                        | US8_0(v13970) -> (* Ok *)
                            US6_0(v13970)
                    return v14093 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14094 : Async<US6> = _v13968 
            let _v13704 = v14094 
            #endif
#else
            let v14095 : unit = ()
            let _v14095 =
                async {
                    let! v13699 = v13699 
                    let v14096 : US8 = v13699 
                    let v14220 : US6 =
                        match v14096 with
                        | US8_1(v14099) -> (* Error *)
                            let v14100 : string = $"%A{v14099}"
                            let v14103 : string = "System.TimeoutException"
                            let v14104 : bool = v14100.Contains v14103 
                            if v14104 then
                                let v14107 : unit = ()
                                let v14108 : (unit -> unit) = closure16(v0)
                                let v14109 : unit = (fun () -> v14108 (); v14107) ()
                                US6_1
                            else
                                let v14150 : unit = ()
                                let v14151 : (unit -> unit) = closure17(v0, v14099)
                                let v14152 : unit = (fun () -> v14151 (); v14150) ()
                                US6_1
                        | US8_0(v14097) -> (* Ok *)
                            US6_0(v14097)
                    return v14220 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14221 : Async<US6> = _v14095 
            let _v13704 = v14221 
            #endif
            let v14222 : Async<US6> = _v13704 
            return! v14222 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v14227 : Async<US6> = _v13483 
    let _v11983 = v14227 
    #endif
#else
    let v14228 : unit = ()
    let _v14228 =
        async {
            let v14229 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14230 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14230 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14231 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14231 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14232 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14232 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14233 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14233 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14234 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14234 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14235 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14235 
            #endif
#else
            let v14236 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14229 = v14236 
            #endif
            let v14237 : Async<Async<bool>> = _v14229 
            let! v14237 = v14237 
            let v14242 : Async<bool> = v14237 
            let v14243 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14244 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14245 : Async<Choice<bool, exn>> = v14244 v14242
            let _v14243 = v14245 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14246 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14247 : Async<Choice<bool, exn>> = v14246 v14242
            let _v14243 = v14247 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14248 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14249 : Async<Choice<bool, exn>> = v14248 v14242
            let _v14243 = v14249 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14250 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14251 : Async<Choice<bool, exn>> = v14250 v14242
            let _v14243 = v14251 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14252 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14253 : Async<Choice<bool, exn>> = v14252 v14242
            let _v14243 = v14253 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14254 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14255 : Async<Choice<bool, exn>> = v14254 v14242
            let _v14243 = v14255 
            #endif
#else
            let v14256 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v14257 : Async<Choice<bool, exn>> = v14256 v14242
            let _v14243 = v14257 
            #endif
            let v14258 : Async<Choice<bool, exn>> = _v14243 
            let v14263 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14264 : Async<US7> = null |> unbox<Async<US7>>
            let _v14263 = v14264 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14267 : Async<US7> = null |> unbox<Async<US7>>
            let _v14263 = v14267 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14270 : Async<US7> = null |> unbox<Async<US7>>
            let _v14263 = v14270 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14273 : unit = ()
            let _v14273 =
                async {
                    let! v14258 = v14258 
                    let v14274 : Choice<bool, exn> = v14258 
                    let v14275 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14276 : US7 = null |> unbox<US7>
                    let _v14275 = v14276 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14279 : US7 = null |> unbox<US7>
                    let _v14275 = v14279 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14282 : US7 = null |> unbox<US7>
                    let _v14275 = v14282 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14285 : US7 = null |> unbox<US7>
                    let _v14275 = v14285 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14288 : US7 = null |> unbox<US7>
                    let _v14275 = v14288 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14291 : (bool -> US7) = method21()
                    let v14292 : (exn -> US7) = method22()
                    let v14293 : US7 = match v14274 with Choice1Of2 x -> v14291 x | Choice2Of2 x -> v14292 x
                    let _v14275 = v14293 
                    #endif
#else
                    let v14294 : (bool -> US7) = method21()
                    let v14295 : (exn -> US7) = method22()
                    let v14296 : US7 = match v14274 with Choice1Of2 x -> v14294 x | Choice2Of2 x -> v14295 x
                    let _v14275 = v14296 
                    #endif
                    let v14297 : US7 = _v14275 
                    return v14297 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14302 : Async<US7> = _v14273 
            let _v14263 = v14302 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14303 : unit = ()
            let _v14303 =
                async {
                    let! v14258 = v14258 
                    let v14304 : Choice<bool, exn> = v14258 
                    let v14305 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14306 : US7 = null |> unbox<US7>
                    let _v14305 = v14306 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14309 : US7 = null |> unbox<US7>
                    let _v14305 = v14309 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14312 : US7 = null |> unbox<US7>
                    let _v14305 = v14312 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14315 : US7 = null |> unbox<US7>
                    let _v14305 = v14315 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14318 : US7 = null |> unbox<US7>
                    let _v14305 = v14318 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14321 : (bool -> US7) = method21()
                    let v14322 : (exn -> US7) = method22()
                    let v14323 : US7 = match v14304 with Choice1Of2 x -> v14321 x | Choice2Of2 x -> v14322 x
                    let _v14305 = v14323 
                    #endif
#else
                    let v14324 : (bool -> US7) = method21()
                    let v14325 : (exn -> US7) = method22()
                    let v14326 : US7 = match v14304 with Choice1Of2 x -> v14324 x | Choice2Of2 x -> v14325 x
                    let _v14305 = v14326 
                    #endif
                    let v14327 : US7 = _v14305 
                    return v14327 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14332 : Async<US7> = _v14303 
            let _v14263 = v14332 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14333 : unit = ()
            let _v14333 =
                async {
                    let! v14258 = v14258 
                    let v14334 : Choice<bool, exn> = v14258 
                    let v14335 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14336 : US7 = null |> unbox<US7>
                    let _v14335 = v14336 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14339 : US7 = null |> unbox<US7>
                    let _v14335 = v14339 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14342 : US7 = null |> unbox<US7>
                    let _v14335 = v14342 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14345 : US7 = null |> unbox<US7>
                    let _v14335 = v14345 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14348 : US7 = null |> unbox<US7>
                    let _v14335 = v14348 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14351 : (bool -> US7) = method21()
                    let v14352 : (exn -> US7) = method22()
                    let v14353 : US7 = match v14334 with Choice1Of2 x -> v14351 x | Choice2Of2 x -> v14352 x
                    let _v14335 = v14353 
                    #endif
#else
                    let v14354 : (bool -> US7) = method21()
                    let v14355 : (exn -> US7) = method22()
                    let v14356 : US7 = match v14334 with Choice1Of2 x -> v14354 x | Choice2Of2 x -> v14355 x
                    let _v14335 = v14356 
                    #endif
                    let v14357 : US7 = _v14335 
                    return v14357 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14362 : Async<US7> = _v14333 
            let _v14263 = v14362 
            #endif
#else
            let v14363 : unit = ()
            let _v14363 =
                async {
                    let! v14258 = v14258 
                    let v14364 : Choice<bool, exn> = v14258 
                    let v14365 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v14366 : US7 = null |> unbox<US7>
                    let _v14365 = v14366 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v14369 : US7 = null |> unbox<US7>
                    let _v14365 = v14369 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v14372 : US7 = null |> unbox<US7>
                    let _v14365 = v14372 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v14375 : US7 = null |> unbox<US7>
                    let _v14365 = v14375 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v14378 : US7 = null |> unbox<US7>
                    let _v14365 = v14378 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v14381 : (bool -> US7) = method21()
                    let v14382 : (exn -> US7) = method22()
                    let v14383 : US7 = match v14364 with Choice1Of2 x -> v14381 x | Choice2Of2 x -> v14382 x
                    let _v14365 = v14383 
                    #endif
#else
                    let v14384 : (bool -> US7) = method21()
                    let v14385 : (exn -> US7) = method22()
                    let v14386 : US7 = match v14364 with Choice1Of2 x -> v14384 x | Choice2Of2 x -> v14385 x
                    let _v14365 = v14386 
                    #endif
                    let v14387 : US7 = _v14365 
                    return v14387 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14392 : Async<US7> = _v14363 
            let _v14263 = v14392 
            #endif
            let v14393 : Async<US7> = _v14263 
            let v14398 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14399 : Async<US8> = null |> unbox<Async<US8>>
            let _v14398 = v14399 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14402 : Async<US8> = null |> unbox<Async<US8>>
            let _v14398 = v14402 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14405 : Async<US8> = null |> unbox<Async<US8>>
            let _v14398 = v14405 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14408 : unit = ()
            let _v14408 =
                async {
                    let! v14393 = v14393 
                    let v14409 : US7 = v14393 
                    let v14415 : US8 =
                        match v14409 with
                        | US7_0(v14410) -> (* C1of2 *)
                            US8_0(v14410)
                        | US7_1(v14412) -> (* C2of2 *)
                            US8_1(v14412)
                    return v14415 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14416 : Async<US8> = _v14408 
            let _v14398 = v14416 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14417 : unit = ()
            let _v14417 =
                async {
                    let! v14393 = v14393 
                    let v14418 : US7 = v14393 
                    let v14424 : US8 =
                        match v14418 with
                        | US7_0(v14419) -> (* C1of2 *)
                            US8_0(v14419)
                        | US7_1(v14421) -> (* C2of2 *)
                            US8_1(v14421)
                    return v14424 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14425 : Async<US8> = _v14417 
            let _v14398 = v14425 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14426 : unit = ()
            let _v14426 =
                async {
                    let! v14393 = v14393 
                    let v14427 : US7 = v14393 
                    let v14433 : US8 =
                        match v14427 with
                        | US7_0(v14428) -> (* C1of2 *)
                            US8_0(v14428)
                        | US7_1(v14430) -> (* C2of2 *)
                            US8_1(v14430)
                    return v14433 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14434 : Async<US8> = _v14426 
            let _v14398 = v14434 
            #endif
#else
            let v14435 : unit = ()
            let _v14435 =
                async {
                    let! v14393 = v14393 
                    let v14436 : US7 = v14393 
                    let v14442 : US8 =
                        match v14436 with
                        | US7_0(v14437) -> (* C1of2 *)
                            US8_0(v14437)
                        | US7_1(v14439) -> (* C2of2 *)
                            US8_1(v14439)
                    return v14442 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14443 : Async<US8> = _v14435 
            let _v14398 = v14443 
            #endif
            let v14444 : Async<US8> = _v14398 
            let v14449 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14450 : Async<US6> = null |> unbox<Async<US6>>
            let _v14449 = v14450 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14453 : Async<US6> = null |> unbox<Async<US6>>
            let _v14449 = v14453 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14456 : Async<US6> = null |> unbox<Async<US6>>
            let _v14449 = v14456 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14459 : unit = ()
            let _v14459 =
                async {
                    let! v14444 = v14444 
                    let v14460 : US8 = v14444 
                    let v14584 : US6 =
                        match v14460 with
                        | US8_1(v14463) -> (* Error *)
                            let v14464 : string = $"%A{v14463}"
                            let v14467 : string = "System.TimeoutException"
                            let v14468 : bool = v14464.Contains v14467 
                            if v14468 then
                                let v14471 : unit = ()
                                let v14472 : (unit -> unit) = closure16(v0)
                                let v14473 : unit = (fun () -> v14472 (); v14471) ()
                                US6_1
                            else
                                let v14514 : unit = ()
                                let v14515 : (unit -> unit) = closure17(v0, v14463)
                                let v14516 : unit = (fun () -> v14515 (); v14514) ()
                                US6_1
                        | US8_0(v14461) -> (* Ok *)
                            US6_0(v14461)
                    return v14584 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14585 : Async<US6> = _v14459 
            let _v14449 = v14585 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14586 : unit = ()
            let _v14586 =
                async {
                    let! v14444 = v14444 
                    let v14587 : US8 = v14444 
                    let v14711 : US6 =
                        match v14587 with
                        | US8_1(v14590) -> (* Error *)
                            let v14591 : string = $"%A{v14590}"
                            let v14594 : string = "System.TimeoutException"
                            let v14595 : bool = v14591.Contains v14594 
                            if v14595 then
                                let v14598 : unit = ()
                                let v14599 : (unit -> unit) = closure16(v0)
                                let v14600 : unit = (fun () -> v14599 (); v14598) ()
                                US6_1
                            else
                                let v14641 : unit = ()
                                let v14642 : (unit -> unit) = closure17(v0, v14590)
                                let v14643 : unit = (fun () -> v14642 (); v14641) ()
                                US6_1
                        | US8_0(v14588) -> (* Ok *)
                            US6_0(v14588)
                    return v14711 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14712 : Async<US6> = _v14586 
            let _v14449 = v14712 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14713 : unit = ()
            let _v14713 =
                async {
                    let! v14444 = v14444 
                    let v14714 : US8 = v14444 
                    let v14838 : US6 =
                        match v14714 with
                        | US8_1(v14717) -> (* Error *)
                            let v14718 : string = $"%A{v14717}"
                            let v14721 : string = "System.TimeoutException"
                            let v14722 : bool = v14718.Contains v14721 
                            if v14722 then
                                let v14725 : unit = ()
                                let v14726 : (unit -> unit) = closure16(v0)
                                let v14727 : unit = (fun () -> v14726 (); v14725) ()
                                US6_1
                            else
                                let v14768 : unit = ()
                                let v14769 : (unit -> unit) = closure17(v0, v14717)
                                let v14770 : unit = (fun () -> v14769 (); v14768) ()
                                US6_1
                        | US8_0(v14715) -> (* Ok *)
                            US6_0(v14715)
                    return v14838 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14839 : Async<US6> = _v14713 
            let _v14449 = v14839 
            #endif
#else
            let v14840 : unit = ()
            let _v14840 =
                async {
                    let! v14444 = v14444 
                    let v14841 : US8 = v14444 
                    let v14965 : US6 =
                        match v14841 with
                        | US8_1(v14844) -> (* Error *)
                            let v14845 : string = $"%A{v14844}"
                            let v14848 : string = "System.TimeoutException"
                            let v14849 : bool = v14845.Contains v14848 
                            if v14849 then
                                let v14852 : unit = ()
                                let v14853 : (unit -> unit) = closure16(v0)
                                let v14854 : unit = (fun () -> v14853 (); v14852) ()
                                US6_1
                            else
                                let v14895 : unit = ()
                                let v14896 : (unit -> unit) = closure17(v0, v14844)
                                let v14897 : unit = (fun () -> v14896 (); v14895) ()
                                US6_1
                        | US8_0(v14842) -> (* Ok *)
                            US6_0(v14842)
                    return v14965 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v14966 : Async<US6> = _v14840 
            let _v14449 = v14966 
            #endif
            let v14967 : Async<US6> = _v14449 
            return! v14967 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v14972 : Async<US6> = _v14228 
    let _v11983 = v14972 
    #endif
    let v14973 : Async<US6> = _v11983 
    let _v2 = v14973 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14978 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14979 : Async<US6> = null |> unbox<Async<US6>>
    let _v14978 = v14979 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14982 : Async<US6> = null |> unbox<Async<US6>>
    let _v14978 = v14982 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14985 : Async<US6> = null |> unbox<Async<US6>>
    let _v14978 = v14985 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v14988 : unit = ()
    let _v14988 =
        async {
            let v14989 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14990 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14990 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v14991 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14991 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v14992 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14992 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v14993 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14993 
            #endif
#if FABLE_COMPILER_PYTHON
            let v14994 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14994 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v14995 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14995 
            #endif
#else
            let v14996 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v14989 = v14996 
            #endif
            let v14997 : Async<Async<bool>> = _v14989 
            let! v14997 = v14997 
            let v15002 : Async<bool> = v14997 
            let v15003 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15004 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15005 : Async<Choice<bool, exn>> = v15004 v15002
            let _v15003 = v15005 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15006 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15007 : Async<Choice<bool, exn>> = v15006 v15002
            let _v15003 = v15007 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15008 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15009 : Async<Choice<bool, exn>> = v15008 v15002
            let _v15003 = v15009 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15010 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15011 : Async<Choice<bool, exn>> = v15010 v15002
            let _v15003 = v15011 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15012 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15013 : Async<Choice<bool, exn>> = v15012 v15002
            let _v15003 = v15013 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15014 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15015 : Async<Choice<bool, exn>> = v15014 v15002
            let _v15003 = v15015 
            #endif
#else
            let v15016 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15017 : Async<Choice<bool, exn>> = v15016 v15002
            let _v15003 = v15017 
            #endif
            let v15018 : Async<Choice<bool, exn>> = _v15003 
            let v15023 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15024 : Async<US7> = null |> unbox<Async<US7>>
            let _v15023 = v15024 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15027 : Async<US7> = null |> unbox<Async<US7>>
            let _v15023 = v15027 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15030 : Async<US7> = null |> unbox<Async<US7>>
            let _v15023 = v15030 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15033 : unit = ()
            let _v15033 =
                async {
                    let! v15018 = v15018 
                    let v15034 : Choice<bool, exn> = v15018 
                    let v15035 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15036 : US7 = null |> unbox<US7>
                    let _v15035 = v15036 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15039 : US7 = null |> unbox<US7>
                    let _v15035 = v15039 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15042 : US7 = null |> unbox<US7>
                    let _v15035 = v15042 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15045 : US7 = null |> unbox<US7>
                    let _v15035 = v15045 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15048 : US7 = null |> unbox<US7>
                    let _v15035 = v15048 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15051 : (bool -> US7) = method21()
                    let v15052 : (exn -> US7) = method22()
                    let v15053 : US7 = match v15034 with Choice1Of2 x -> v15051 x | Choice2Of2 x -> v15052 x
                    let _v15035 = v15053 
                    #endif
#else
                    let v15054 : (bool -> US7) = method21()
                    let v15055 : (exn -> US7) = method22()
                    let v15056 : US7 = match v15034 with Choice1Of2 x -> v15054 x | Choice2Of2 x -> v15055 x
                    let _v15035 = v15056 
                    #endif
                    let v15057 : US7 = _v15035 
                    return v15057 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15062 : Async<US7> = _v15033 
            let _v15023 = v15062 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15063 : unit = ()
            let _v15063 =
                async {
                    let! v15018 = v15018 
                    let v15064 : Choice<bool, exn> = v15018 
                    let v15065 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15066 : US7 = null |> unbox<US7>
                    let _v15065 = v15066 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15069 : US7 = null |> unbox<US7>
                    let _v15065 = v15069 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15072 : US7 = null |> unbox<US7>
                    let _v15065 = v15072 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15075 : US7 = null |> unbox<US7>
                    let _v15065 = v15075 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15078 : US7 = null |> unbox<US7>
                    let _v15065 = v15078 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15081 : (bool -> US7) = method21()
                    let v15082 : (exn -> US7) = method22()
                    let v15083 : US7 = match v15064 with Choice1Of2 x -> v15081 x | Choice2Of2 x -> v15082 x
                    let _v15065 = v15083 
                    #endif
#else
                    let v15084 : (bool -> US7) = method21()
                    let v15085 : (exn -> US7) = method22()
                    let v15086 : US7 = match v15064 with Choice1Of2 x -> v15084 x | Choice2Of2 x -> v15085 x
                    let _v15065 = v15086 
                    #endif
                    let v15087 : US7 = _v15065 
                    return v15087 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15092 : Async<US7> = _v15063 
            let _v15023 = v15092 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15093 : unit = ()
            let _v15093 =
                async {
                    let! v15018 = v15018 
                    let v15094 : Choice<bool, exn> = v15018 
                    let v15095 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15096 : US7 = null |> unbox<US7>
                    let _v15095 = v15096 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15099 : US7 = null |> unbox<US7>
                    let _v15095 = v15099 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15102 : US7 = null |> unbox<US7>
                    let _v15095 = v15102 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15105 : US7 = null |> unbox<US7>
                    let _v15095 = v15105 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15108 : US7 = null |> unbox<US7>
                    let _v15095 = v15108 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15111 : (bool -> US7) = method21()
                    let v15112 : (exn -> US7) = method22()
                    let v15113 : US7 = match v15094 with Choice1Of2 x -> v15111 x | Choice2Of2 x -> v15112 x
                    let _v15095 = v15113 
                    #endif
#else
                    let v15114 : (bool -> US7) = method21()
                    let v15115 : (exn -> US7) = method22()
                    let v15116 : US7 = match v15094 with Choice1Of2 x -> v15114 x | Choice2Of2 x -> v15115 x
                    let _v15095 = v15116 
                    #endif
                    let v15117 : US7 = _v15095 
                    return v15117 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15122 : Async<US7> = _v15093 
            let _v15023 = v15122 
            #endif
#else
            let v15123 : unit = ()
            let _v15123 =
                async {
                    let! v15018 = v15018 
                    let v15124 : Choice<bool, exn> = v15018 
                    let v15125 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15126 : US7 = null |> unbox<US7>
                    let _v15125 = v15126 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15129 : US7 = null |> unbox<US7>
                    let _v15125 = v15129 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15132 : US7 = null |> unbox<US7>
                    let _v15125 = v15132 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15135 : US7 = null |> unbox<US7>
                    let _v15125 = v15135 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15138 : US7 = null |> unbox<US7>
                    let _v15125 = v15138 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15141 : (bool -> US7) = method21()
                    let v15142 : (exn -> US7) = method22()
                    let v15143 : US7 = match v15124 with Choice1Of2 x -> v15141 x | Choice2Of2 x -> v15142 x
                    let _v15125 = v15143 
                    #endif
#else
                    let v15144 : (bool -> US7) = method21()
                    let v15145 : (exn -> US7) = method22()
                    let v15146 : US7 = match v15124 with Choice1Of2 x -> v15144 x | Choice2Of2 x -> v15145 x
                    let _v15125 = v15146 
                    #endif
                    let v15147 : US7 = _v15125 
                    return v15147 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15152 : Async<US7> = _v15123 
            let _v15023 = v15152 
            #endif
            let v15153 : Async<US7> = _v15023 
            let v15158 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15159 : Async<US8> = null |> unbox<Async<US8>>
            let _v15158 = v15159 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15162 : Async<US8> = null |> unbox<Async<US8>>
            let _v15158 = v15162 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15165 : Async<US8> = null |> unbox<Async<US8>>
            let _v15158 = v15165 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15168 : unit = ()
            let _v15168 =
                async {
                    let! v15153 = v15153 
                    let v15169 : US7 = v15153 
                    let v15175 : US8 =
                        match v15169 with
                        | US7_0(v15170) -> (* C1of2 *)
                            US8_0(v15170)
                        | US7_1(v15172) -> (* C2of2 *)
                            US8_1(v15172)
                    return v15175 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15176 : Async<US8> = _v15168 
            let _v15158 = v15176 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15177 : unit = ()
            let _v15177 =
                async {
                    let! v15153 = v15153 
                    let v15178 : US7 = v15153 
                    let v15184 : US8 =
                        match v15178 with
                        | US7_0(v15179) -> (* C1of2 *)
                            US8_0(v15179)
                        | US7_1(v15181) -> (* C2of2 *)
                            US8_1(v15181)
                    return v15184 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15185 : Async<US8> = _v15177 
            let _v15158 = v15185 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15186 : unit = ()
            let _v15186 =
                async {
                    let! v15153 = v15153 
                    let v15187 : US7 = v15153 
                    let v15193 : US8 =
                        match v15187 with
                        | US7_0(v15188) -> (* C1of2 *)
                            US8_0(v15188)
                        | US7_1(v15190) -> (* C2of2 *)
                            US8_1(v15190)
                    return v15193 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15194 : Async<US8> = _v15186 
            let _v15158 = v15194 
            #endif
#else
            let v15195 : unit = ()
            let _v15195 =
                async {
                    let! v15153 = v15153 
                    let v15196 : US7 = v15153 
                    let v15202 : US8 =
                        match v15196 with
                        | US7_0(v15197) -> (* C1of2 *)
                            US8_0(v15197)
                        | US7_1(v15199) -> (* C2of2 *)
                            US8_1(v15199)
                    return v15202 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15203 : Async<US8> = _v15195 
            let _v15158 = v15203 
            #endif
            let v15204 : Async<US8> = _v15158 
            let v15209 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15210 : Async<US6> = null |> unbox<Async<US6>>
            let _v15209 = v15210 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15213 : Async<US6> = null |> unbox<Async<US6>>
            let _v15209 = v15213 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15216 : Async<US6> = null |> unbox<Async<US6>>
            let _v15209 = v15216 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15219 : unit = ()
            let _v15219 =
                async {
                    let! v15204 = v15204 
                    let v15220 : US8 = v15204 
                    let v15344 : US6 =
                        match v15220 with
                        | US8_1(v15223) -> (* Error *)
                            let v15224 : string = $"%A{v15223}"
                            let v15227 : string = "System.TimeoutException"
                            let v15228 : bool = v15224.Contains v15227 
                            if v15228 then
                                let v15231 : unit = ()
                                let v15232 : (unit -> unit) = closure16(v0)
                                let v15233 : unit = (fun () -> v15232 (); v15231) ()
                                US6_1
                            else
                                let v15274 : unit = ()
                                let v15275 : (unit -> unit) = closure17(v0, v15223)
                                let v15276 : unit = (fun () -> v15275 (); v15274) ()
                                US6_1
                        | US8_0(v15221) -> (* Ok *)
                            US6_0(v15221)
                    return v15344 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15345 : Async<US6> = _v15219 
            let _v15209 = v15345 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15346 : unit = ()
            let _v15346 =
                async {
                    let! v15204 = v15204 
                    let v15347 : US8 = v15204 
                    let v15471 : US6 =
                        match v15347 with
                        | US8_1(v15350) -> (* Error *)
                            let v15351 : string = $"%A{v15350}"
                            let v15354 : string = "System.TimeoutException"
                            let v15355 : bool = v15351.Contains v15354 
                            if v15355 then
                                let v15358 : unit = ()
                                let v15359 : (unit -> unit) = closure16(v0)
                                let v15360 : unit = (fun () -> v15359 (); v15358) ()
                                US6_1
                            else
                                let v15401 : unit = ()
                                let v15402 : (unit -> unit) = closure17(v0, v15350)
                                let v15403 : unit = (fun () -> v15402 (); v15401) ()
                                US6_1
                        | US8_0(v15348) -> (* Ok *)
                            US6_0(v15348)
                    return v15471 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15472 : Async<US6> = _v15346 
            let _v15209 = v15472 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15473 : unit = ()
            let _v15473 =
                async {
                    let! v15204 = v15204 
                    let v15474 : US8 = v15204 
                    let v15598 : US6 =
                        match v15474 with
                        | US8_1(v15477) -> (* Error *)
                            let v15478 : string = $"%A{v15477}"
                            let v15481 : string = "System.TimeoutException"
                            let v15482 : bool = v15478.Contains v15481 
                            if v15482 then
                                let v15485 : unit = ()
                                let v15486 : (unit -> unit) = closure16(v0)
                                let v15487 : unit = (fun () -> v15486 (); v15485) ()
                                US6_1
                            else
                                let v15528 : unit = ()
                                let v15529 : (unit -> unit) = closure17(v0, v15477)
                                let v15530 : unit = (fun () -> v15529 (); v15528) ()
                                US6_1
                        | US8_0(v15475) -> (* Ok *)
                            US6_0(v15475)
                    return v15598 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15599 : Async<US6> = _v15473 
            let _v15209 = v15599 
            #endif
#else
            let v15600 : unit = ()
            let _v15600 =
                async {
                    let! v15204 = v15204 
                    let v15601 : US8 = v15204 
                    let v15725 : US6 =
                        match v15601 with
                        | US8_1(v15604) -> (* Error *)
                            let v15605 : string = $"%A{v15604}"
                            let v15608 : string = "System.TimeoutException"
                            let v15609 : bool = v15605.Contains v15608 
                            if v15609 then
                                let v15612 : unit = ()
                                let v15613 : (unit -> unit) = closure16(v0)
                                let v15614 : unit = (fun () -> v15613 (); v15612) ()
                                US6_1
                            else
                                let v15655 : unit = ()
                                let v15656 : (unit -> unit) = closure17(v0, v15604)
                                let v15657 : unit = (fun () -> v15656 (); v15655) ()
                                US6_1
                        | US8_0(v15602) -> (* Ok *)
                            US6_0(v15602)
                    return v15725 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15726 : Async<US6> = _v15600 
            let _v15209 = v15726 
            #endif
            let v15727 : Async<US6> = _v15209 
            return! v15727 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v15732 : Async<US6> = _v14988 
    let _v14978 = v15732 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15733 : unit = ()
    let _v15733 =
        async {
            let v15734 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15735 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15735 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15736 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15736 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15737 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15737 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15738 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15738 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15739 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15739 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15740 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15740 
            #endif
#else
            let v15741 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v15734 = v15741 
            #endif
            let v15742 : Async<Async<bool>> = _v15734 
            let! v15742 = v15742 
            let v15747 : Async<bool> = v15742 
            let v15748 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15749 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15750 : Async<Choice<bool, exn>> = v15749 v15747
            let _v15748 = v15750 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15751 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15752 : Async<Choice<bool, exn>> = v15751 v15747
            let _v15748 = v15752 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15753 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15754 : Async<Choice<bool, exn>> = v15753 v15747
            let _v15748 = v15754 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15755 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15756 : Async<Choice<bool, exn>> = v15755 v15747
            let _v15748 = v15756 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15757 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15758 : Async<Choice<bool, exn>> = v15757 v15747
            let _v15748 = v15758 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15759 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15760 : Async<Choice<bool, exn>> = v15759 v15747
            let _v15748 = v15760 
            #endif
#else
            let v15761 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v15762 : Async<Choice<bool, exn>> = v15761 v15747
            let _v15748 = v15762 
            #endif
            let v15763 : Async<Choice<bool, exn>> = _v15748 
            let v15768 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15769 : Async<US7> = null |> unbox<Async<US7>>
            let _v15768 = v15769 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15772 : Async<US7> = null |> unbox<Async<US7>>
            let _v15768 = v15772 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15775 : Async<US7> = null |> unbox<Async<US7>>
            let _v15768 = v15775 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15778 : unit = ()
            let _v15778 =
                async {
                    let! v15763 = v15763 
                    let v15779 : Choice<bool, exn> = v15763 
                    let v15780 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15781 : US7 = null |> unbox<US7>
                    let _v15780 = v15781 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15784 : US7 = null |> unbox<US7>
                    let _v15780 = v15784 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15787 : US7 = null |> unbox<US7>
                    let _v15780 = v15787 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15790 : US7 = null |> unbox<US7>
                    let _v15780 = v15790 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15793 : US7 = null |> unbox<US7>
                    let _v15780 = v15793 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15796 : (bool -> US7) = method21()
                    let v15797 : (exn -> US7) = method22()
                    let v15798 : US7 = match v15779 with Choice1Of2 x -> v15796 x | Choice2Of2 x -> v15797 x
                    let _v15780 = v15798 
                    #endif
#else
                    let v15799 : (bool -> US7) = method21()
                    let v15800 : (exn -> US7) = method22()
                    let v15801 : US7 = match v15779 with Choice1Of2 x -> v15799 x | Choice2Of2 x -> v15800 x
                    let _v15780 = v15801 
                    #endif
                    let v15802 : US7 = _v15780 
                    return v15802 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15807 : Async<US7> = _v15778 
            let _v15768 = v15807 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15808 : unit = ()
            let _v15808 =
                async {
                    let! v15763 = v15763 
                    let v15809 : Choice<bool, exn> = v15763 
                    let v15810 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15811 : US7 = null |> unbox<US7>
                    let _v15810 = v15811 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15814 : US7 = null |> unbox<US7>
                    let _v15810 = v15814 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15817 : US7 = null |> unbox<US7>
                    let _v15810 = v15817 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15820 : US7 = null |> unbox<US7>
                    let _v15810 = v15820 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15823 : US7 = null |> unbox<US7>
                    let _v15810 = v15823 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15826 : (bool -> US7) = method21()
                    let v15827 : (exn -> US7) = method22()
                    let v15828 : US7 = match v15809 with Choice1Of2 x -> v15826 x | Choice2Of2 x -> v15827 x
                    let _v15810 = v15828 
                    #endif
#else
                    let v15829 : (bool -> US7) = method21()
                    let v15830 : (exn -> US7) = method22()
                    let v15831 : US7 = match v15809 with Choice1Of2 x -> v15829 x | Choice2Of2 x -> v15830 x
                    let _v15810 = v15831 
                    #endif
                    let v15832 : US7 = _v15810 
                    return v15832 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15837 : Async<US7> = _v15808 
            let _v15768 = v15837 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15838 : unit = ()
            let _v15838 =
                async {
                    let! v15763 = v15763 
                    let v15839 : Choice<bool, exn> = v15763 
                    let v15840 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15841 : US7 = null |> unbox<US7>
                    let _v15840 = v15841 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15844 : US7 = null |> unbox<US7>
                    let _v15840 = v15844 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15847 : US7 = null |> unbox<US7>
                    let _v15840 = v15847 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15850 : US7 = null |> unbox<US7>
                    let _v15840 = v15850 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15853 : US7 = null |> unbox<US7>
                    let _v15840 = v15853 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15856 : (bool -> US7) = method21()
                    let v15857 : (exn -> US7) = method22()
                    let v15858 : US7 = match v15839 with Choice1Of2 x -> v15856 x | Choice2Of2 x -> v15857 x
                    let _v15840 = v15858 
                    #endif
#else
                    let v15859 : (bool -> US7) = method21()
                    let v15860 : (exn -> US7) = method22()
                    let v15861 : US7 = match v15839 with Choice1Of2 x -> v15859 x | Choice2Of2 x -> v15860 x
                    let _v15840 = v15861 
                    #endif
                    let v15862 : US7 = _v15840 
                    return v15862 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15867 : Async<US7> = _v15838 
            let _v15768 = v15867 
            #endif
#else
            let v15868 : unit = ()
            let _v15868 =
                async {
                    let! v15763 = v15763 
                    let v15869 : Choice<bool, exn> = v15763 
                    let v15870 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v15871 : US7 = null |> unbox<US7>
                    let _v15870 = v15871 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v15874 : US7 = null |> unbox<US7>
                    let _v15870 = v15874 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v15877 : US7 = null |> unbox<US7>
                    let _v15870 = v15877 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v15880 : US7 = null |> unbox<US7>
                    let _v15870 = v15880 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v15883 : US7 = null |> unbox<US7>
                    let _v15870 = v15883 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v15886 : (bool -> US7) = method21()
                    let v15887 : (exn -> US7) = method22()
                    let v15888 : US7 = match v15869 with Choice1Of2 x -> v15886 x | Choice2Of2 x -> v15887 x
                    let _v15870 = v15888 
                    #endif
#else
                    let v15889 : (bool -> US7) = method21()
                    let v15890 : (exn -> US7) = method22()
                    let v15891 : US7 = match v15869 with Choice1Of2 x -> v15889 x | Choice2Of2 x -> v15890 x
                    let _v15870 = v15891 
                    #endif
                    let v15892 : US7 = _v15870 
                    return v15892 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15897 : Async<US7> = _v15868 
            let _v15768 = v15897 
            #endif
            let v15898 : Async<US7> = _v15768 
            let v15903 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15904 : Async<US8> = null |> unbox<Async<US8>>
            let _v15903 = v15904 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15907 : Async<US8> = null |> unbox<Async<US8>>
            let _v15903 = v15907 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15910 : Async<US8> = null |> unbox<Async<US8>>
            let _v15903 = v15910 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15913 : unit = ()
            let _v15913 =
                async {
                    let! v15898 = v15898 
                    let v15914 : US7 = v15898 
                    let v15920 : US8 =
                        match v15914 with
                        | US7_0(v15915) -> (* C1of2 *)
                            US8_0(v15915)
                        | US7_1(v15917) -> (* C2of2 *)
                            US8_1(v15917)
                    return v15920 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15921 : Async<US8> = _v15913 
            let _v15903 = v15921 
            #endif
#if FABLE_COMPILER_PYTHON
            let v15922 : unit = ()
            let _v15922 =
                async {
                    let! v15898 = v15898 
                    let v15923 : US7 = v15898 
                    let v15929 : US8 =
                        match v15923 with
                        | US7_0(v15924) -> (* C1of2 *)
                            US8_0(v15924)
                        | US7_1(v15926) -> (* C2of2 *)
                            US8_1(v15926)
                    return v15929 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15930 : Async<US8> = _v15922 
            let _v15903 = v15930 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v15931 : unit = ()
            let _v15931 =
                async {
                    let! v15898 = v15898 
                    let v15932 : US7 = v15898 
                    let v15938 : US8 =
                        match v15932 with
                        | US7_0(v15933) -> (* C1of2 *)
                            US8_0(v15933)
                        | US7_1(v15935) -> (* C2of2 *)
                            US8_1(v15935)
                    return v15938 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15939 : Async<US8> = _v15931 
            let _v15903 = v15939 
            #endif
#else
            let v15940 : unit = ()
            let _v15940 =
                async {
                    let! v15898 = v15898 
                    let v15941 : US7 = v15898 
                    let v15947 : US8 =
                        match v15941 with
                        | US7_0(v15942) -> (* C1of2 *)
                            US8_0(v15942)
                        | US7_1(v15944) -> (* C2of2 *)
                            US8_1(v15944)
                    return v15947 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v15948 : Async<US8> = _v15940 
            let _v15903 = v15948 
            #endif
            let v15949 : Async<US8> = _v15903 
            let v15954 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15955 : Async<US6> = null |> unbox<Async<US6>>
            let _v15954 = v15955 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v15958 : Async<US6> = null |> unbox<Async<US6>>
            let _v15954 = v15958 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v15961 : Async<US6> = null |> unbox<Async<US6>>
            let _v15954 = v15961 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v15964 : unit = ()
            let _v15964 =
                async {
                    let! v15949 = v15949 
                    let v15965 : US8 = v15949 
                    let v16089 : US6 =
                        match v15965 with
                        | US8_1(v15968) -> (* Error *)
                            let v15969 : string = $"%A{v15968}"
                            let v15972 : string = "System.TimeoutException"
                            let v15973 : bool = v15969.Contains v15972 
                            if v15973 then
                                let v15976 : unit = ()
                                let v15977 : (unit -> unit) = closure16(v0)
                                let v15978 : unit = (fun () -> v15977 (); v15976) ()
                                US6_1
                            else
                                let v16019 : unit = ()
                                let v16020 : (unit -> unit) = closure17(v0, v15968)
                                let v16021 : unit = (fun () -> v16020 (); v16019) ()
                                US6_1
                        | US8_0(v15966) -> (* Ok *)
                            US6_0(v15966)
                    return v16089 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16090 : Async<US6> = _v15964 
            let _v15954 = v16090 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16091 : unit = ()
            let _v16091 =
                async {
                    let! v15949 = v15949 
                    let v16092 : US8 = v15949 
                    let v16216 : US6 =
                        match v16092 with
                        | US8_1(v16095) -> (* Error *)
                            let v16096 : string = $"%A{v16095}"
                            let v16099 : string = "System.TimeoutException"
                            let v16100 : bool = v16096.Contains v16099 
                            if v16100 then
                                let v16103 : unit = ()
                                let v16104 : (unit -> unit) = closure16(v0)
                                let v16105 : unit = (fun () -> v16104 (); v16103) ()
                                US6_1
                            else
                                let v16146 : unit = ()
                                let v16147 : (unit -> unit) = closure17(v0, v16095)
                                let v16148 : unit = (fun () -> v16147 (); v16146) ()
                                US6_1
                        | US8_0(v16093) -> (* Ok *)
                            US6_0(v16093)
                    return v16216 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16217 : Async<US6> = _v16091 
            let _v15954 = v16217 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16218 : unit = ()
            let _v16218 =
                async {
                    let! v15949 = v15949 
                    let v16219 : US8 = v15949 
                    let v16343 : US6 =
                        match v16219 with
                        | US8_1(v16222) -> (* Error *)
                            let v16223 : string = $"%A{v16222}"
                            let v16226 : string = "System.TimeoutException"
                            let v16227 : bool = v16223.Contains v16226 
                            if v16227 then
                                let v16230 : unit = ()
                                let v16231 : (unit -> unit) = closure16(v0)
                                let v16232 : unit = (fun () -> v16231 (); v16230) ()
                                US6_1
                            else
                                let v16273 : unit = ()
                                let v16274 : (unit -> unit) = closure17(v0, v16222)
                                let v16275 : unit = (fun () -> v16274 (); v16273) ()
                                US6_1
                        | US8_0(v16220) -> (* Ok *)
                            US6_0(v16220)
                    return v16343 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16344 : Async<US6> = _v16218 
            let _v15954 = v16344 
            #endif
#else
            let v16345 : unit = ()
            let _v16345 =
                async {
                    let! v15949 = v15949 
                    let v16346 : US8 = v15949 
                    let v16470 : US6 =
                        match v16346 with
                        | US8_1(v16349) -> (* Error *)
                            let v16350 : string = $"%A{v16349}"
                            let v16353 : string = "System.TimeoutException"
                            let v16354 : bool = v16350.Contains v16353 
                            if v16354 then
                                let v16357 : unit = ()
                                let v16358 : (unit -> unit) = closure16(v0)
                                let v16359 : unit = (fun () -> v16358 (); v16357) ()
                                US6_1
                            else
                                let v16400 : unit = ()
                                let v16401 : (unit -> unit) = closure17(v0, v16349)
                                let v16402 : unit = (fun () -> v16401 (); v16400) ()
                                US6_1
                        | US8_0(v16347) -> (* Ok *)
                            US6_0(v16347)
                    return v16470 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16471 : Async<US6> = _v16345 
            let _v15954 = v16471 
            #endif
            let v16472 : Async<US6> = _v15954 
            return! v16472 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v16477 : Async<US6> = _v15733 
    let _v14978 = v16477 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v16478 : unit = ()
    let _v16478 =
        async {
            let v16479 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16480 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16480 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16481 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16481 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16482 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16482 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16483 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16483 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16484 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16484 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16485 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16485 
            #endif
#else
            let v16486 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v16479 = v16486 
            #endif
            let v16487 : Async<Async<bool>> = _v16479 
            let! v16487 = v16487 
            let v16492 : Async<bool> = v16487 
            let v16493 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16494 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16495 : Async<Choice<bool, exn>> = v16494 v16492
            let _v16493 = v16495 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16496 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16497 : Async<Choice<bool, exn>> = v16496 v16492
            let _v16493 = v16497 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16498 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16499 : Async<Choice<bool, exn>> = v16498 v16492
            let _v16493 = v16499 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16500 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16501 : Async<Choice<bool, exn>> = v16500 v16492
            let _v16493 = v16501 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16502 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16503 : Async<Choice<bool, exn>> = v16502 v16492
            let _v16493 = v16503 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16504 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16505 : Async<Choice<bool, exn>> = v16504 v16492
            let _v16493 = v16505 
            #endif
#else
            let v16506 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v16507 : Async<Choice<bool, exn>> = v16506 v16492
            let _v16493 = v16507 
            #endif
            let v16508 : Async<Choice<bool, exn>> = _v16493 
            let v16513 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16514 : Async<US7> = null |> unbox<Async<US7>>
            let _v16513 = v16514 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16517 : Async<US7> = null |> unbox<Async<US7>>
            let _v16513 = v16517 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16520 : Async<US7> = null |> unbox<Async<US7>>
            let _v16513 = v16520 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16523 : unit = ()
            let _v16523 =
                async {
                    let! v16508 = v16508 
                    let v16524 : Choice<bool, exn> = v16508 
                    let v16525 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16526 : US7 = null |> unbox<US7>
                    let _v16525 = v16526 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16529 : US7 = null |> unbox<US7>
                    let _v16525 = v16529 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16532 : US7 = null |> unbox<US7>
                    let _v16525 = v16532 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16535 : US7 = null |> unbox<US7>
                    let _v16525 = v16535 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16538 : US7 = null |> unbox<US7>
                    let _v16525 = v16538 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16541 : (bool -> US7) = method21()
                    let v16542 : (exn -> US7) = method22()
                    let v16543 : US7 = match v16524 with Choice1Of2 x -> v16541 x | Choice2Of2 x -> v16542 x
                    let _v16525 = v16543 
                    #endif
#else
                    let v16544 : (bool -> US7) = method21()
                    let v16545 : (exn -> US7) = method22()
                    let v16546 : US7 = match v16524 with Choice1Of2 x -> v16544 x | Choice2Of2 x -> v16545 x
                    let _v16525 = v16546 
                    #endif
                    let v16547 : US7 = _v16525 
                    return v16547 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16552 : Async<US7> = _v16523 
            let _v16513 = v16552 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16553 : unit = ()
            let _v16553 =
                async {
                    let! v16508 = v16508 
                    let v16554 : Choice<bool, exn> = v16508 
                    let v16555 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16556 : US7 = null |> unbox<US7>
                    let _v16555 = v16556 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16559 : US7 = null |> unbox<US7>
                    let _v16555 = v16559 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16562 : US7 = null |> unbox<US7>
                    let _v16555 = v16562 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16565 : US7 = null |> unbox<US7>
                    let _v16555 = v16565 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16568 : US7 = null |> unbox<US7>
                    let _v16555 = v16568 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16571 : (bool -> US7) = method21()
                    let v16572 : (exn -> US7) = method22()
                    let v16573 : US7 = match v16554 with Choice1Of2 x -> v16571 x | Choice2Of2 x -> v16572 x
                    let _v16555 = v16573 
                    #endif
#else
                    let v16574 : (bool -> US7) = method21()
                    let v16575 : (exn -> US7) = method22()
                    let v16576 : US7 = match v16554 with Choice1Of2 x -> v16574 x | Choice2Of2 x -> v16575 x
                    let _v16555 = v16576 
                    #endif
                    let v16577 : US7 = _v16555 
                    return v16577 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16582 : Async<US7> = _v16553 
            let _v16513 = v16582 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16583 : unit = ()
            let _v16583 =
                async {
                    let! v16508 = v16508 
                    let v16584 : Choice<bool, exn> = v16508 
                    let v16585 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16586 : US7 = null |> unbox<US7>
                    let _v16585 = v16586 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16589 : US7 = null |> unbox<US7>
                    let _v16585 = v16589 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16592 : US7 = null |> unbox<US7>
                    let _v16585 = v16592 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16595 : US7 = null |> unbox<US7>
                    let _v16585 = v16595 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16598 : US7 = null |> unbox<US7>
                    let _v16585 = v16598 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16601 : (bool -> US7) = method21()
                    let v16602 : (exn -> US7) = method22()
                    let v16603 : US7 = match v16584 with Choice1Of2 x -> v16601 x | Choice2Of2 x -> v16602 x
                    let _v16585 = v16603 
                    #endif
#else
                    let v16604 : (bool -> US7) = method21()
                    let v16605 : (exn -> US7) = method22()
                    let v16606 : US7 = match v16584 with Choice1Of2 x -> v16604 x | Choice2Of2 x -> v16605 x
                    let _v16585 = v16606 
                    #endif
                    let v16607 : US7 = _v16585 
                    return v16607 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16612 : Async<US7> = _v16583 
            let _v16513 = v16612 
            #endif
#else
            let v16613 : unit = ()
            let _v16613 =
                async {
                    let! v16508 = v16508 
                    let v16614 : Choice<bool, exn> = v16508 
                    let v16615 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v16616 : US7 = null |> unbox<US7>
                    let _v16615 = v16616 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v16619 : US7 = null |> unbox<US7>
                    let _v16615 = v16619 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v16622 : US7 = null |> unbox<US7>
                    let _v16615 = v16622 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v16625 : US7 = null |> unbox<US7>
                    let _v16615 = v16625 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v16628 : US7 = null |> unbox<US7>
                    let _v16615 = v16628 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v16631 : (bool -> US7) = method21()
                    let v16632 : (exn -> US7) = method22()
                    let v16633 : US7 = match v16614 with Choice1Of2 x -> v16631 x | Choice2Of2 x -> v16632 x
                    let _v16615 = v16633 
                    #endif
#else
                    let v16634 : (bool -> US7) = method21()
                    let v16635 : (exn -> US7) = method22()
                    let v16636 : US7 = match v16614 with Choice1Of2 x -> v16634 x | Choice2Of2 x -> v16635 x
                    let _v16615 = v16636 
                    #endif
                    let v16637 : US7 = _v16615 
                    return v16637 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16642 : Async<US7> = _v16613 
            let _v16513 = v16642 
            #endif
            let v16643 : Async<US7> = _v16513 
            let v16648 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16649 : Async<US8> = null |> unbox<Async<US8>>
            let _v16648 = v16649 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16652 : Async<US8> = null |> unbox<Async<US8>>
            let _v16648 = v16652 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16655 : Async<US8> = null |> unbox<Async<US8>>
            let _v16648 = v16655 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16658 : unit = ()
            let _v16658 =
                async {
                    let! v16643 = v16643 
                    let v16659 : US7 = v16643 
                    let v16665 : US8 =
                        match v16659 with
                        | US7_0(v16660) -> (* C1of2 *)
                            US8_0(v16660)
                        | US7_1(v16662) -> (* C2of2 *)
                            US8_1(v16662)
                    return v16665 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16666 : Async<US8> = _v16658 
            let _v16648 = v16666 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16667 : unit = ()
            let _v16667 =
                async {
                    let! v16643 = v16643 
                    let v16668 : US7 = v16643 
                    let v16674 : US8 =
                        match v16668 with
                        | US7_0(v16669) -> (* C1of2 *)
                            US8_0(v16669)
                        | US7_1(v16671) -> (* C2of2 *)
                            US8_1(v16671)
                    return v16674 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16675 : Async<US8> = _v16667 
            let _v16648 = v16675 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16676 : unit = ()
            let _v16676 =
                async {
                    let! v16643 = v16643 
                    let v16677 : US7 = v16643 
                    let v16683 : US8 =
                        match v16677 with
                        | US7_0(v16678) -> (* C1of2 *)
                            US8_0(v16678)
                        | US7_1(v16680) -> (* C2of2 *)
                            US8_1(v16680)
                    return v16683 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16684 : Async<US8> = _v16676 
            let _v16648 = v16684 
            #endif
#else
            let v16685 : unit = ()
            let _v16685 =
                async {
                    let! v16643 = v16643 
                    let v16686 : US7 = v16643 
                    let v16692 : US8 =
                        match v16686 with
                        | US7_0(v16687) -> (* C1of2 *)
                            US8_0(v16687)
                        | US7_1(v16689) -> (* C2of2 *)
                            US8_1(v16689)
                    return v16692 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16693 : Async<US8> = _v16685 
            let _v16648 = v16693 
            #endif
            let v16694 : Async<US8> = _v16648 
            let v16699 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v16700 : Async<US6> = null |> unbox<Async<US6>>
            let _v16699 = v16700 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16703 : Async<US6> = null |> unbox<Async<US6>>
            let _v16699 = v16703 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v16706 : Async<US6> = null |> unbox<Async<US6>>
            let _v16699 = v16706 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v16709 : unit = ()
            let _v16709 =
                async {
                    let! v16694 = v16694 
                    let v16710 : US8 = v16694 
                    let v16834 : US6 =
                        match v16710 with
                        | US8_1(v16713) -> (* Error *)
                            let v16714 : string = $"%A{v16713}"
                            let v16717 : string = "System.TimeoutException"
                            let v16718 : bool = v16714.Contains v16717 
                            if v16718 then
                                let v16721 : unit = ()
                                let v16722 : (unit -> unit) = closure16(v0)
                                let v16723 : unit = (fun () -> v16722 (); v16721) ()
                                US6_1
                            else
                                let v16764 : unit = ()
                                let v16765 : (unit -> unit) = closure17(v0, v16713)
                                let v16766 : unit = (fun () -> v16765 (); v16764) ()
                                US6_1
                        | US8_0(v16711) -> (* Ok *)
                            US6_0(v16711)
                    return v16834 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16835 : Async<US6> = _v16709 
            let _v16699 = v16835 
            #endif
#if FABLE_COMPILER_PYTHON
            let v16836 : unit = ()
            let _v16836 =
                async {
                    let! v16694 = v16694 
                    let v16837 : US8 = v16694 
                    let v16961 : US6 =
                        match v16837 with
                        | US8_1(v16840) -> (* Error *)
                            let v16841 : string = $"%A{v16840}"
                            let v16844 : string = "System.TimeoutException"
                            let v16845 : bool = v16841.Contains v16844 
                            if v16845 then
                                let v16848 : unit = ()
                                let v16849 : (unit -> unit) = closure16(v0)
                                let v16850 : unit = (fun () -> v16849 (); v16848) ()
                                US6_1
                            else
                                let v16891 : unit = ()
                                let v16892 : (unit -> unit) = closure17(v0, v16840)
                                let v16893 : unit = (fun () -> v16892 (); v16891) ()
                                US6_1
                        | US8_0(v16838) -> (* Ok *)
                            US6_0(v16838)
                    return v16961 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v16962 : Async<US6> = _v16836 
            let _v16699 = v16962 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v16963 : unit = ()
            let _v16963 =
                async {
                    let! v16694 = v16694 
                    let v16964 : US8 = v16694 
                    let v17088 : US6 =
                        match v16964 with
                        | US8_1(v16967) -> (* Error *)
                            let v16968 : string = $"%A{v16967}"
                            let v16971 : string = "System.TimeoutException"
                            let v16972 : bool = v16968.Contains v16971 
                            if v16972 then
                                let v16975 : unit = ()
                                let v16976 : (unit -> unit) = closure16(v0)
                                let v16977 : unit = (fun () -> v16976 (); v16975) ()
                                US6_1
                            else
                                let v17018 : unit = ()
                                let v17019 : (unit -> unit) = closure17(v0, v16967)
                                let v17020 : unit = (fun () -> v17019 (); v17018) ()
                                US6_1
                        | US8_0(v16965) -> (* Ok *)
                            US6_0(v16965)
                    return v17088 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17089 : Async<US6> = _v16963 
            let _v16699 = v17089 
            #endif
#else
            let v17090 : unit = ()
            let _v17090 =
                async {
                    let! v16694 = v16694 
                    let v17091 : US8 = v16694 
                    let v17215 : US6 =
                        match v17091 with
                        | US8_1(v17094) -> (* Error *)
                            let v17095 : string = $"%A{v17094}"
                            let v17098 : string = "System.TimeoutException"
                            let v17099 : bool = v17095.Contains v17098 
                            if v17099 then
                                let v17102 : unit = ()
                                let v17103 : (unit -> unit) = closure16(v0)
                                let v17104 : unit = (fun () -> v17103 (); v17102) ()
                                US6_1
                            else
                                let v17145 : unit = ()
                                let v17146 : (unit -> unit) = closure17(v0, v17094)
                                let v17147 : unit = (fun () -> v17146 (); v17145) ()
                                US6_1
                        | US8_0(v17092) -> (* Ok *)
                            US6_0(v17092)
                    return v17215 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17216 : Async<US6> = _v17090 
            let _v16699 = v17216 
            #endif
            let v17217 : Async<US6> = _v16699 
            return! v17217 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v17222 : Async<US6> = _v16478 
    let _v14978 = v17222 
    #endif
#else
    let v17223 : unit = ()
    let _v17223 =
        async {
            let v17224 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17225 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17225 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17226 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17226 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17227 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17227 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17228 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17228 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17229 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17229 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17230 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17230 
            #endif
#else
            let v17231 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17224 = v17231 
            #endif
            let v17232 : Async<Async<bool>> = _v17224 
            let! v17232 = v17232 
            let v17237 : Async<bool> = v17232 
            let v17238 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17239 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17240 : Async<Choice<bool, exn>> = v17239 v17237
            let _v17238 = v17240 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17241 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17242 : Async<Choice<bool, exn>> = v17241 v17237
            let _v17238 = v17242 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17243 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17244 : Async<Choice<bool, exn>> = v17243 v17237
            let _v17238 = v17244 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17245 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17246 : Async<Choice<bool, exn>> = v17245 v17237
            let _v17238 = v17246 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17247 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17248 : Async<Choice<bool, exn>> = v17247 v17237
            let _v17238 = v17248 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17249 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17250 : Async<Choice<bool, exn>> = v17249 v17237
            let _v17238 = v17250 
            #endif
#else
            let v17251 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v17252 : Async<Choice<bool, exn>> = v17251 v17237
            let _v17238 = v17252 
            #endif
            let v17253 : Async<Choice<bool, exn>> = _v17238 
            let v17258 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17259 : Async<US7> = null |> unbox<Async<US7>>
            let _v17258 = v17259 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17262 : Async<US7> = null |> unbox<Async<US7>>
            let _v17258 = v17262 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17265 : Async<US7> = null |> unbox<Async<US7>>
            let _v17258 = v17265 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17268 : unit = ()
            let _v17268 =
                async {
                    let! v17253 = v17253 
                    let v17269 : Choice<bool, exn> = v17253 
                    let v17270 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17271 : US7 = null |> unbox<US7>
                    let _v17270 = v17271 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17274 : US7 = null |> unbox<US7>
                    let _v17270 = v17274 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17277 : US7 = null |> unbox<US7>
                    let _v17270 = v17277 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17280 : US7 = null |> unbox<US7>
                    let _v17270 = v17280 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17283 : US7 = null |> unbox<US7>
                    let _v17270 = v17283 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17286 : (bool -> US7) = method21()
                    let v17287 : (exn -> US7) = method22()
                    let v17288 : US7 = match v17269 with Choice1Of2 x -> v17286 x | Choice2Of2 x -> v17287 x
                    let _v17270 = v17288 
                    #endif
#else
                    let v17289 : (bool -> US7) = method21()
                    let v17290 : (exn -> US7) = method22()
                    let v17291 : US7 = match v17269 with Choice1Of2 x -> v17289 x | Choice2Of2 x -> v17290 x
                    let _v17270 = v17291 
                    #endif
                    let v17292 : US7 = _v17270 
                    return v17292 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17297 : Async<US7> = _v17268 
            let _v17258 = v17297 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17298 : unit = ()
            let _v17298 =
                async {
                    let! v17253 = v17253 
                    let v17299 : Choice<bool, exn> = v17253 
                    let v17300 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17301 : US7 = null |> unbox<US7>
                    let _v17300 = v17301 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17304 : US7 = null |> unbox<US7>
                    let _v17300 = v17304 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17307 : US7 = null |> unbox<US7>
                    let _v17300 = v17307 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17310 : US7 = null |> unbox<US7>
                    let _v17300 = v17310 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17313 : US7 = null |> unbox<US7>
                    let _v17300 = v17313 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17316 : (bool -> US7) = method21()
                    let v17317 : (exn -> US7) = method22()
                    let v17318 : US7 = match v17299 with Choice1Of2 x -> v17316 x | Choice2Of2 x -> v17317 x
                    let _v17300 = v17318 
                    #endif
#else
                    let v17319 : (bool -> US7) = method21()
                    let v17320 : (exn -> US7) = method22()
                    let v17321 : US7 = match v17299 with Choice1Of2 x -> v17319 x | Choice2Of2 x -> v17320 x
                    let _v17300 = v17321 
                    #endif
                    let v17322 : US7 = _v17300 
                    return v17322 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17327 : Async<US7> = _v17298 
            let _v17258 = v17327 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17328 : unit = ()
            let _v17328 =
                async {
                    let! v17253 = v17253 
                    let v17329 : Choice<bool, exn> = v17253 
                    let v17330 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17331 : US7 = null |> unbox<US7>
                    let _v17330 = v17331 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17334 : US7 = null |> unbox<US7>
                    let _v17330 = v17334 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17337 : US7 = null |> unbox<US7>
                    let _v17330 = v17337 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17340 : US7 = null |> unbox<US7>
                    let _v17330 = v17340 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17343 : US7 = null |> unbox<US7>
                    let _v17330 = v17343 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17346 : (bool -> US7) = method21()
                    let v17347 : (exn -> US7) = method22()
                    let v17348 : US7 = match v17329 with Choice1Of2 x -> v17346 x | Choice2Of2 x -> v17347 x
                    let _v17330 = v17348 
                    #endif
#else
                    let v17349 : (bool -> US7) = method21()
                    let v17350 : (exn -> US7) = method22()
                    let v17351 : US7 = match v17329 with Choice1Of2 x -> v17349 x | Choice2Of2 x -> v17350 x
                    let _v17330 = v17351 
                    #endif
                    let v17352 : US7 = _v17330 
                    return v17352 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17357 : Async<US7> = _v17328 
            let _v17258 = v17357 
            #endif
#else
            let v17358 : unit = ()
            let _v17358 =
                async {
                    let! v17253 = v17253 
                    let v17359 : Choice<bool, exn> = v17253 
                    let v17360 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v17361 : US7 = null |> unbox<US7>
                    let _v17360 = v17361 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v17364 : US7 = null |> unbox<US7>
                    let _v17360 = v17364 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v17367 : US7 = null |> unbox<US7>
                    let _v17360 = v17367 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v17370 : US7 = null |> unbox<US7>
                    let _v17360 = v17370 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v17373 : US7 = null |> unbox<US7>
                    let _v17360 = v17373 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v17376 : (bool -> US7) = method21()
                    let v17377 : (exn -> US7) = method22()
                    let v17378 : US7 = match v17359 with Choice1Of2 x -> v17376 x | Choice2Of2 x -> v17377 x
                    let _v17360 = v17378 
                    #endif
#else
                    let v17379 : (bool -> US7) = method21()
                    let v17380 : (exn -> US7) = method22()
                    let v17381 : US7 = match v17359 with Choice1Of2 x -> v17379 x | Choice2Of2 x -> v17380 x
                    let _v17360 = v17381 
                    #endif
                    let v17382 : US7 = _v17360 
                    return v17382 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17387 : Async<US7> = _v17358 
            let _v17258 = v17387 
            #endif
            let v17388 : Async<US7> = _v17258 
            let v17393 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17394 : Async<US8> = null |> unbox<Async<US8>>
            let _v17393 = v17394 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17397 : Async<US8> = null |> unbox<Async<US8>>
            let _v17393 = v17397 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17400 : Async<US8> = null |> unbox<Async<US8>>
            let _v17393 = v17400 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17403 : unit = ()
            let _v17403 =
                async {
                    let! v17388 = v17388 
                    let v17404 : US7 = v17388 
                    let v17410 : US8 =
                        match v17404 with
                        | US7_0(v17405) -> (* C1of2 *)
                            US8_0(v17405)
                        | US7_1(v17407) -> (* C2of2 *)
                            US8_1(v17407)
                    return v17410 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17411 : Async<US8> = _v17403 
            let _v17393 = v17411 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17412 : unit = ()
            let _v17412 =
                async {
                    let! v17388 = v17388 
                    let v17413 : US7 = v17388 
                    let v17419 : US8 =
                        match v17413 with
                        | US7_0(v17414) -> (* C1of2 *)
                            US8_0(v17414)
                        | US7_1(v17416) -> (* C2of2 *)
                            US8_1(v17416)
                    return v17419 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17420 : Async<US8> = _v17412 
            let _v17393 = v17420 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17421 : unit = ()
            let _v17421 =
                async {
                    let! v17388 = v17388 
                    let v17422 : US7 = v17388 
                    let v17428 : US8 =
                        match v17422 with
                        | US7_0(v17423) -> (* C1of2 *)
                            US8_0(v17423)
                        | US7_1(v17425) -> (* C2of2 *)
                            US8_1(v17425)
                    return v17428 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17429 : Async<US8> = _v17421 
            let _v17393 = v17429 
            #endif
#else
            let v17430 : unit = ()
            let _v17430 =
                async {
                    let! v17388 = v17388 
                    let v17431 : US7 = v17388 
                    let v17437 : US8 =
                        match v17431 with
                        | US7_0(v17432) -> (* C1of2 *)
                            US8_0(v17432)
                        | US7_1(v17434) -> (* C2of2 *)
                            US8_1(v17434)
                    return v17437 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17438 : Async<US8> = _v17430 
            let _v17393 = v17438 
            #endif
            let v17439 : Async<US8> = _v17393 
            let v17444 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17445 : Async<US6> = null |> unbox<Async<US6>>
            let _v17444 = v17445 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17448 : Async<US6> = null |> unbox<Async<US6>>
            let _v17444 = v17448 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17451 : Async<US6> = null |> unbox<Async<US6>>
            let _v17444 = v17451 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17454 : unit = ()
            let _v17454 =
                async {
                    let! v17439 = v17439 
                    let v17455 : US8 = v17439 
                    let v17579 : US6 =
                        match v17455 with
                        | US8_1(v17458) -> (* Error *)
                            let v17459 : string = $"%A{v17458}"
                            let v17462 : string = "System.TimeoutException"
                            let v17463 : bool = v17459.Contains v17462 
                            if v17463 then
                                let v17466 : unit = ()
                                let v17467 : (unit -> unit) = closure16(v0)
                                let v17468 : unit = (fun () -> v17467 (); v17466) ()
                                US6_1
                            else
                                let v17509 : unit = ()
                                let v17510 : (unit -> unit) = closure17(v0, v17458)
                                let v17511 : unit = (fun () -> v17510 (); v17509) ()
                                US6_1
                        | US8_0(v17456) -> (* Ok *)
                            US6_0(v17456)
                    return v17579 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17580 : Async<US6> = _v17454 
            let _v17444 = v17580 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17581 : unit = ()
            let _v17581 =
                async {
                    let! v17439 = v17439 
                    let v17582 : US8 = v17439 
                    let v17706 : US6 =
                        match v17582 with
                        | US8_1(v17585) -> (* Error *)
                            let v17586 : string = $"%A{v17585}"
                            let v17589 : string = "System.TimeoutException"
                            let v17590 : bool = v17586.Contains v17589 
                            if v17590 then
                                let v17593 : unit = ()
                                let v17594 : (unit -> unit) = closure16(v0)
                                let v17595 : unit = (fun () -> v17594 (); v17593) ()
                                US6_1
                            else
                                let v17636 : unit = ()
                                let v17637 : (unit -> unit) = closure17(v0, v17585)
                                let v17638 : unit = (fun () -> v17637 (); v17636) ()
                                US6_1
                        | US8_0(v17583) -> (* Ok *)
                            US6_0(v17583)
                    return v17706 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17707 : Async<US6> = _v17581 
            let _v17444 = v17707 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17708 : unit = ()
            let _v17708 =
                async {
                    let! v17439 = v17439 
                    let v17709 : US8 = v17439 
                    let v17833 : US6 =
                        match v17709 with
                        | US8_1(v17712) -> (* Error *)
                            let v17713 : string = $"%A{v17712}"
                            let v17716 : string = "System.TimeoutException"
                            let v17717 : bool = v17713.Contains v17716 
                            if v17717 then
                                let v17720 : unit = ()
                                let v17721 : (unit -> unit) = closure16(v0)
                                let v17722 : unit = (fun () -> v17721 (); v17720) ()
                                US6_1
                            else
                                let v17763 : unit = ()
                                let v17764 : (unit -> unit) = closure17(v0, v17712)
                                let v17765 : unit = (fun () -> v17764 (); v17763) ()
                                US6_1
                        | US8_0(v17710) -> (* Ok *)
                            US6_0(v17710)
                    return v17833 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17834 : Async<US6> = _v17708 
            let _v17444 = v17834 
            #endif
#else
            let v17835 : unit = ()
            let _v17835 =
                async {
                    let! v17439 = v17439 
                    let v17836 : US8 = v17439 
                    let v17960 : US6 =
                        match v17836 with
                        | US8_1(v17839) -> (* Error *)
                            let v17840 : string = $"%A{v17839}"
                            let v17843 : string = "System.TimeoutException"
                            let v17844 : bool = v17840.Contains v17843 
                            if v17844 then
                                let v17847 : unit = ()
                                let v17848 : (unit -> unit) = closure16(v0)
                                let v17849 : unit = (fun () -> v17848 (); v17847) ()
                                US6_1
                            else
                                let v17890 : unit = ()
                                let v17891 : (unit -> unit) = closure17(v0, v17839)
                                let v17892 : unit = (fun () -> v17891 (); v17890) ()
                                US6_1
                        | US8_0(v17837) -> (* Ok *)
                            US6_0(v17837)
                    return v17960 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v17961 : Async<US6> = _v17835 
            let _v17444 = v17961 
            #endif
            let v17962 : Async<US6> = _v17444 
            return! v17962 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v17967 : Async<US6> = _v17223 
    let _v14978 = v17967 
    #endif
    let v17968 : Async<US6> = _v14978 
    let _v2 = v17968 
    #endif
#else
    let v17973 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v17974 : Async<US6> = null |> unbox<Async<US6>>
    let _v17973 = v17974 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17977 : Async<US6> = null |> unbox<Async<US6>>
    let _v17973 = v17977 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17980 : Async<US6> = null |> unbox<Async<US6>>
    let _v17973 = v17980 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17983 : unit = ()
    let _v17983 =
        async {
            let v17984 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17985 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17985 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v17986 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17986 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v17987 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17987 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v17988 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17988 
            #endif
#if FABLE_COMPILER_PYTHON
            let v17989 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17989 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v17990 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17990 
            #endif
#else
            let v17991 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v17984 = v17991 
            #endif
            let v17992 : Async<Async<bool>> = _v17984 
            let! v17992 = v17992 
            let v17997 : Async<bool> = v17992 
            let v17998 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v17999 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18000 : Async<Choice<bool, exn>> = v17999 v17997
            let _v17998 = v18000 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18001 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18002 : Async<Choice<bool, exn>> = v18001 v17997
            let _v17998 = v18002 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18003 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18004 : Async<Choice<bool, exn>> = v18003 v17997
            let _v17998 = v18004 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18005 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18006 : Async<Choice<bool, exn>> = v18005 v17997
            let _v17998 = v18006 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18007 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18008 : Async<Choice<bool, exn>> = v18007 v17997
            let _v17998 = v18008 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18009 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18010 : Async<Choice<bool, exn>> = v18009 v17997
            let _v17998 = v18010 
            #endif
#else
            let v18011 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18012 : Async<Choice<bool, exn>> = v18011 v17997
            let _v17998 = v18012 
            #endif
            let v18013 : Async<Choice<bool, exn>> = _v17998 
            let v18018 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18019 : Async<US7> = null |> unbox<Async<US7>>
            let _v18018 = v18019 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18022 : Async<US7> = null |> unbox<Async<US7>>
            let _v18018 = v18022 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18025 : Async<US7> = null |> unbox<Async<US7>>
            let _v18018 = v18025 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18028 : unit = ()
            let _v18028 =
                async {
                    let! v18013 = v18013 
                    let v18029 : Choice<bool, exn> = v18013 
                    let v18030 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18031 : US7 = null |> unbox<US7>
                    let _v18030 = v18031 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18034 : US7 = null |> unbox<US7>
                    let _v18030 = v18034 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18037 : US7 = null |> unbox<US7>
                    let _v18030 = v18037 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18040 : US7 = null |> unbox<US7>
                    let _v18030 = v18040 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18043 : US7 = null |> unbox<US7>
                    let _v18030 = v18043 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18046 : (bool -> US7) = method21()
                    let v18047 : (exn -> US7) = method22()
                    let v18048 : US7 = match v18029 with Choice1Of2 x -> v18046 x | Choice2Of2 x -> v18047 x
                    let _v18030 = v18048 
                    #endif
#else
                    let v18049 : (bool -> US7) = method21()
                    let v18050 : (exn -> US7) = method22()
                    let v18051 : US7 = match v18029 with Choice1Of2 x -> v18049 x | Choice2Of2 x -> v18050 x
                    let _v18030 = v18051 
                    #endif
                    let v18052 : US7 = _v18030 
                    return v18052 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18057 : Async<US7> = _v18028 
            let _v18018 = v18057 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18058 : unit = ()
            let _v18058 =
                async {
                    let! v18013 = v18013 
                    let v18059 : Choice<bool, exn> = v18013 
                    let v18060 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18061 : US7 = null |> unbox<US7>
                    let _v18060 = v18061 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18064 : US7 = null |> unbox<US7>
                    let _v18060 = v18064 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18067 : US7 = null |> unbox<US7>
                    let _v18060 = v18067 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18070 : US7 = null |> unbox<US7>
                    let _v18060 = v18070 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18073 : US7 = null |> unbox<US7>
                    let _v18060 = v18073 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18076 : (bool -> US7) = method21()
                    let v18077 : (exn -> US7) = method22()
                    let v18078 : US7 = match v18059 with Choice1Of2 x -> v18076 x | Choice2Of2 x -> v18077 x
                    let _v18060 = v18078 
                    #endif
#else
                    let v18079 : (bool -> US7) = method21()
                    let v18080 : (exn -> US7) = method22()
                    let v18081 : US7 = match v18059 with Choice1Of2 x -> v18079 x | Choice2Of2 x -> v18080 x
                    let _v18060 = v18081 
                    #endif
                    let v18082 : US7 = _v18060 
                    return v18082 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18087 : Async<US7> = _v18058 
            let _v18018 = v18087 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18088 : unit = ()
            let _v18088 =
                async {
                    let! v18013 = v18013 
                    let v18089 : Choice<bool, exn> = v18013 
                    let v18090 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18091 : US7 = null |> unbox<US7>
                    let _v18090 = v18091 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18094 : US7 = null |> unbox<US7>
                    let _v18090 = v18094 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18097 : US7 = null |> unbox<US7>
                    let _v18090 = v18097 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18100 : US7 = null |> unbox<US7>
                    let _v18090 = v18100 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18103 : US7 = null |> unbox<US7>
                    let _v18090 = v18103 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18106 : (bool -> US7) = method21()
                    let v18107 : (exn -> US7) = method22()
                    let v18108 : US7 = match v18089 with Choice1Of2 x -> v18106 x | Choice2Of2 x -> v18107 x
                    let _v18090 = v18108 
                    #endif
#else
                    let v18109 : (bool -> US7) = method21()
                    let v18110 : (exn -> US7) = method22()
                    let v18111 : US7 = match v18089 with Choice1Of2 x -> v18109 x | Choice2Of2 x -> v18110 x
                    let _v18090 = v18111 
                    #endif
                    let v18112 : US7 = _v18090 
                    return v18112 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18117 : Async<US7> = _v18088 
            let _v18018 = v18117 
            #endif
#else
            let v18118 : unit = ()
            let _v18118 =
                async {
                    let! v18013 = v18013 
                    let v18119 : Choice<bool, exn> = v18013 
                    let v18120 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18121 : US7 = null |> unbox<US7>
                    let _v18120 = v18121 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18124 : US7 = null |> unbox<US7>
                    let _v18120 = v18124 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18127 : US7 = null |> unbox<US7>
                    let _v18120 = v18127 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18130 : US7 = null |> unbox<US7>
                    let _v18120 = v18130 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18133 : US7 = null |> unbox<US7>
                    let _v18120 = v18133 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18136 : (bool -> US7) = method21()
                    let v18137 : (exn -> US7) = method22()
                    let v18138 : US7 = match v18119 with Choice1Of2 x -> v18136 x | Choice2Of2 x -> v18137 x
                    let _v18120 = v18138 
                    #endif
#else
                    let v18139 : (bool -> US7) = method21()
                    let v18140 : (exn -> US7) = method22()
                    let v18141 : US7 = match v18119 with Choice1Of2 x -> v18139 x | Choice2Of2 x -> v18140 x
                    let _v18120 = v18141 
                    #endif
                    let v18142 : US7 = _v18120 
                    return v18142 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18147 : Async<US7> = _v18118 
            let _v18018 = v18147 
            #endif
            let v18148 : Async<US7> = _v18018 
            let v18153 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18154 : Async<US8> = null |> unbox<Async<US8>>
            let _v18153 = v18154 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18157 : Async<US8> = null |> unbox<Async<US8>>
            let _v18153 = v18157 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18160 : Async<US8> = null |> unbox<Async<US8>>
            let _v18153 = v18160 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18163 : unit = ()
            let _v18163 =
                async {
                    let! v18148 = v18148 
                    let v18164 : US7 = v18148 
                    let v18170 : US8 =
                        match v18164 with
                        | US7_0(v18165) -> (* C1of2 *)
                            US8_0(v18165)
                        | US7_1(v18167) -> (* C2of2 *)
                            US8_1(v18167)
                    return v18170 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18171 : Async<US8> = _v18163 
            let _v18153 = v18171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18172 : unit = ()
            let _v18172 =
                async {
                    let! v18148 = v18148 
                    let v18173 : US7 = v18148 
                    let v18179 : US8 =
                        match v18173 with
                        | US7_0(v18174) -> (* C1of2 *)
                            US8_0(v18174)
                        | US7_1(v18176) -> (* C2of2 *)
                            US8_1(v18176)
                    return v18179 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18180 : Async<US8> = _v18172 
            let _v18153 = v18180 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18181 : unit = ()
            let _v18181 =
                async {
                    let! v18148 = v18148 
                    let v18182 : US7 = v18148 
                    let v18188 : US8 =
                        match v18182 with
                        | US7_0(v18183) -> (* C1of2 *)
                            US8_0(v18183)
                        | US7_1(v18185) -> (* C2of2 *)
                            US8_1(v18185)
                    return v18188 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18189 : Async<US8> = _v18181 
            let _v18153 = v18189 
            #endif
#else
            let v18190 : unit = ()
            let _v18190 =
                async {
                    let! v18148 = v18148 
                    let v18191 : US7 = v18148 
                    let v18197 : US8 =
                        match v18191 with
                        | US7_0(v18192) -> (* C1of2 *)
                            US8_0(v18192)
                        | US7_1(v18194) -> (* C2of2 *)
                            US8_1(v18194)
                    return v18197 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18198 : Async<US8> = _v18190 
            let _v18153 = v18198 
            #endif
            let v18199 : Async<US8> = _v18153 
            let v18204 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18205 : Async<US6> = null |> unbox<Async<US6>>
            let _v18204 = v18205 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18208 : Async<US6> = null |> unbox<Async<US6>>
            let _v18204 = v18208 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18211 : Async<US6> = null |> unbox<Async<US6>>
            let _v18204 = v18211 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18214 : unit = ()
            let _v18214 =
                async {
                    let! v18199 = v18199 
                    let v18215 : US8 = v18199 
                    let v18339 : US6 =
                        match v18215 with
                        | US8_1(v18218) -> (* Error *)
                            let v18219 : string = $"%A{v18218}"
                            let v18222 : string = "System.TimeoutException"
                            let v18223 : bool = v18219.Contains v18222 
                            if v18223 then
                                let v18226 : unit = ()
                                let v18227 : (unit -> unit) = closure16(v0)
                                let v18228 : unit = (fun () -> v18227 (); v18226) ()
                                US6_1
                            else
                                let v18269 : unit = ()
                                let v18270 : (unit -> unit) = closure17(v0, v18218)
                                let v18271 : unit = (fun () -> v18270 (); v18269) ()
                                US6_1
                        | US8_0(v18216) -> (* Ok *)
                            US6_0(v18216)
                    return v18339 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18340 : Async<US6> = _v18214 
            let _v18204 = v18340 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18341 : unit = ()
            let _v18341 =
                async {
                    let! v18199 = v18199 
                    let v18342 : US8 = v18199 
                    let v18466 : US6 =
                        match v18342 with
                        | US8_1(v18345) -> (* Error *)
                            let v18346 : string = $"%A{v18345}"
                            let v18349 : string = "System.TimeoutException"
                            let v18350 : bool = v18346.Contains v18349 
                            if v18350 then
                                let v18353 : unit = ()
                                let v18354 : (unit -> unit) = closure16(v0)
                                let v18355 : unit = (fun () -> v18354 (); v18353) ()
                                US6_1
                            else
                                let v18396 : unit = ()
                                let v18397 : (unit -> unit) = closure17(v0, v18345)
                                let v18398 : unit = (fun () -> v18397 (); v18396) ()
                                US6_1
                        | US8_0(v18343) -> (* Ok *)
                            US6_0(v18343)
                    return v18466 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18467 : Async<US6> = _v18341 
            let _v18204 = v18467 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18468 : unit = ()
            let _v18468 =
                async {
                    let! v18199 = v18199 
                    let v18469 : US8 = v18199 
                    let v18593 : US6 =
                        match v18469 with
                        | US8_1(v18472) -> (* Error *)
                            let v18473 : string = $"%A{v18472}"
                            let v18476 : string = "System.TimeoutException"
                            let v18477 : bool = v18473.Contains v18476 
                            if v18477 then
                                let v18480 : unit = ()
                                let v18481 : (unit -> unit) = closure16(v0)
                                let v18482 : unit = (fun () -> v18481 (); v18480) ()
                                US6_1
                            else
                                let v18523 : unit = ()
                                let v18524 : (unit -> unit) = closure17(v0, v18472)
                                let v18525 : unit = (fun () -> v18524 (); v18523) ()
                                US6_1
                        | US8_0(v18470) -> (* Ok *)
                            US6_0(v18470)
                    return v18593 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18594 : Async<US6> = _v18468 
            let _v18204 = v18594 
            #endif
#else
            let v18595 : unit = ()
            let _v18595 =
                async {
                    let! v18199 = v18199 
                    let v18596 : US8 = v18199 
                    let v18720 : US6 =
                        match v18596 with
                        | US8_1(v18599) -> (* Error *)
                            let v18600 : string = $"%A{v18599}"
                            let v18603 : string = "System.TimeoutException"
                            let v18604 : bool = v18600.Contains v18603 
                            if v18604 then
                                let v18607 : unit = ()
                                let v18608 : (unit -> unit) = closure16(v0)
                                let v18609 : unit = (fun () -> v18608 (); v18607) ()
                                US6_1
                            else
                                let v18650 : unit = ()
                                let v18651 : (unit -> unit) = closure17(v0, v18599)
                                let v18652 : unit = (fun () -> v18651 (); v18650) ()
                                US6_1
                        | US8_0(v18597) -> (* Ok *)
                            US6_0(v18597)
                    return v18720 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18721 : Async<US6> = _v18595 
            let _v18204 = v18721 
            #endif
            let v18722 : Async<US6> = _v18204 
            return! v18722 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v18727 : Async<US6> = _v17983 
    let _v17973 = v18727 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18728 : unit = ()
    let _v18728 =
        async {
            let v18729 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18730 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18730 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18731 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18731 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18732 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18732 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18733 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18733 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18734 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18734 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18735 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18735 
            #endif
#else
            let v18736 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v18729 = v18736 
            #endif
            let v18737 : Async<Async<bool>> = _v18729 
            let! v18737 = v18737 
            let v18742 : Async<bool> = v18737 
            let v18743 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18744 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18745 : Async<Choice<bool, exn>> = v18744 v18742
            let _v18743 = v18745 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18746 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18747 : Async<Choice<bool, exn>> = v18746 v18742
            let _v18743 = v18747 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18748 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18749 : Async<Choice<bool, exn>> = v18748 v18742
            let _v18743 = v18749 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18750 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18751 : Async<Choice<bool, exn>> = v18750 v18742
            let _v18743 = v18751 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18752 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18753 : Async<Choice<bool, exn>> = v18752 v18742
            let _v18743 = v18753 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18754 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18755 : Async<Choice<bool, exn>> = v18754 v18742
            let _v18743 = v18755 
            #endif
#else
            let v18756 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v18757 : Async<Choice<bool, exn>> = v18756 v18742
            let _v18743 = v18757 
            #endif
            let v18758 : Async<Choice<bool, exn>> = _v18743 
            let v18763 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18764 : Async<US7> = null |> unbox<Async<US7>>
            let _v18763 = v18764 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18767 : Async<US7> = null |> unbox<Async<US7>>
            let _v18763 = v18767 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18770 : Async<US7> = null |> unbox<Async<US7>>
            let _v18763 = v18770 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18773 : unit = ()
            let _v18773 =
                async {
                    let! v18758 = v18758 
                    let v18774 : Choice<bool, exn> = v18758 
                    let v18775 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18776 : US7 = null |> unbox<US7>
                    let _v18775 = v18776 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18779 : US7 = null |> unbox<US7>
                    let _v18775 = v18779 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18782 : US7 = null |> unbox<US7>
                    let _v18775 = v18782 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18785 : US7 = null |> unbox<US7>
                    let _v18775 = v18785 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18788 : US7 = null |> unbox<US7>
                    let _v18775 = v18788 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18791 : (bool -> US7) = method21()
                    let v18792 : (exn -> US7) = method22()
                    let v18793 : US7 = match v18774 with Choice1Of2 x -> v18791 x | Choice2Of2 x -> v18792 x
                    let _v18775 = v18793 
                    #endif
#else
                    let v18794 : (bool -> US7) = method21()
                    let v18795 : (exn -> US7) = method22()
                    let v18796 : US7 = match v18774 with Choice1Of2 x -> v18794 x | Choice2Of2 x -> v18795 x
                    let _v18775 = v18796 
                    #endif
                    let v18797 : US7 = _v18775 
                    return v18797 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18802 : Async<US7> = _v18773 
            let _v18763 = v18802 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18803 : unit = ()
            let _v18803 =
                async {
                    let! v18758 = v18758 
                    let v18804 : Choice<bool, exn> = v18758 
                    let v18805 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18806 : US7 = null |> unbox<US7>
                    let _v18805 = v18806 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18809 : US7 = null |> unbox<US7>
                    let _v18805 = v18809 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18812 : US7 = null |> unbox<US7>
                    let _v18805 = v18812 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18815 : US7 = null |> unbox<US7>
                    let _v18805 = v18815 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18818 : US7 = null |> unbox<US7>
                    let _v18805 = v18818 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18821 : (bool -> US7) = method21()
                    let v18822 : (exn -> US7) = method22()
                    let v18823 : US7 = match v18804 with Choice1Of2 x -> v18821 x | Choice2Of2 x -> v18822 x
                    let _v18805 = v18823 
                    #endif
#else
                    let v18824 : (bool -> US7) = method21()
                    let v18825 : (exn -> US7) = method22()
                    let v18826 : US7 = match v18804 with Choice1Of2 x -> v18824 x | Choice2Of2 x -> v18825 x
                    let _v18805 = v18826 
                    #endif
                    let v18827 : US7 = _v18805 
                    return v18827 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18832 : Async<US7> = _v18803 
            let _v18763 = v18832 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18833 : unit = ()
            let _v18833 =
                async {
                    let! v18758 = v18758 
                    let v18834 : Choice<bool, exn> = v18758 
                    let v18835 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18836 : US7 = null |> unbox<US7>
                    let _v18835 = v18836 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18839 : US7 = null |> unbox<US7>
                    let _v18835 = v18839 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18842 : US7 = null |> unbox<US7>
                    let _v18835 = v18842 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18845 : US7 = null |> unbox<US7>
                    let _v18835 = v18845 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18848 : US7 = null |> unbox<US7>
                    let _v18835 = v18848 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18851 : (bool -> US7) = method21()
                    let v18852 : (exn -> US7) = method22()
                    let v18853 : US7 = match v18834 with Choice1Of2 x -> v18851 x | Choice2Of2 x -> v18852 x
                    let _v18835 = v18853 
                    #endif
#else
                    let v18854 : (bool -> US7) = method21()
                    let v18855 : (exn -> US7) = method22()
                    let v18856 : US7 = match v18834 with Choice1Of2 x -> v18854 x | Choice2Of2 x -> v18855 x
                    let _v18835 = v18856 
                    #endif
                    let v18857 : US7 = _v18835 
                    return v18857 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18862 : Async<US7> = _v18833 
            let _v18763 = v18862 
            #endif
#else
            let v18863 : unit = ()
            let _v18863 =
                async {
                    let! v18758 = v18758 
                    let v18864 : Choice<bool, exn> = v18758 
                    let v18865 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v18866 : US7 = null |> unbox<US7>
                    let _v18865 = v18866 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v18869 : US7 = null |> unbox<US7>
                    let _v18865 = v18869 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v18872 : US7 = null |> unbox<US7>
                    let _v18865 = v18872 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v18875 : US7 = null |> unbox<US7>
                    let _v18865 = v18875 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v18878 : US7 = null |> unbox<US7>
                    let _v18865 = v18878 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v18881 : (bool -> US7) = method21()
                    let v18882 : (exn -> US7) = method22()
                    let v18883 : US7 = match v18864 with Choice1Of2 x -> v18881 x | Choice2Of2 x -> v18882 x
                    let _v18865 = v18883 
                    #endif
#else
                    let v18884 : (bool -> US7) = method21()
                    let v18885 : (exn -> US7) = method22()
                    let v18886 : US7 = match v18864 with Choice1Of2 x -> v18884 x | Choice2Of2 x -> v18885 x
                    let _v18865 = v18886 
                    #endif
                    let v18887 : US7 = _v18865 
                    return v18887 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18892 : Async<US7> = _v18863 
            let _v18763 = v18892 
            #endif
            let v18893 : Async<US7> = _v18763 
            let v18898 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18899 : Async<US8> = null |> unbox<Async<US8>>
            let _v18898 = v18899 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18902 : Async<US8> = null |> unbox<Async<US8>>
            let _v18898 = v18902 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18905 : Async<US8> = null |> unbox<Async<US8>>
            let _v18898 = v18905 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18908 : unit = ()
            let _v18908 =
                async {
                    let! v18893 = v18893 
                    let v18909 : US7 = v18893 
                    let v18915 : US8 =
                        match v18909 with
                        | US7_0(v18910) -> (* C1of2 *)
                            US8_0(v18910)
                        | US7_1(v18912) -> (* C2of2 *)
                            US8_1(v18912)
                    return v18915 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18916 : Async<US8> = _v18908 
            let _v18898 = v18916 
            #endif
#if FABLE_COMPILER_PYTHON
            let v18917 : unit = ()
            let _v18917 =
                async {
                    let! v18893 = v18893 
                    let v18918 : US7 = v18893 
                    let v18924 : US8 =
                        match v18918 with
                        | US7_0(v18919) -> (* C1of2 *)
                            US8_0(v18919)
                        | US7_1(v18921) -> (* C2of2 *)
                            US8_1(v18921)
                    return v18924 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18925 : Async<US8> = _v18917 
            let _v18898 = v18925 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v18926 : unit = ()
            let _v18926 =
                async {
                    let! v18893 = v18893 
                    let v18927 : US7 = v18893 
                    let v18933 : US8 =
                        match v18927 with
                        | US7_0(v18928) -> (* C1of2 *)
                            US8_0(v18928)
                        | US7_1(v18930) -> (* C2of2 *)
                            US8_1(v18930)
                    return v18933 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18934 : Async<US8> = _v18926 
            let _v18898 = v18934 
            #endif
#else
            let v18935 : unit = ()
            let _v18935 =
                async {
                    let! v18893 = v18893 
                    let v18936 : US7 = v18893 
                    let v18942 : US8 =
                        match v18936 with
                        | US7_0(v18937) -> (* C1of2 *)
                            US8_0(v18937)
                        | US7_1(v18939) -> (* C2of2 *)
                            US8_1(v18939)
                    return v18942 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v18943 : Async<US8> = _v18935 
            let _v18898 = v18943 
            #endif
            let v18944 : Async<US8> = _v18898 
            let v18949 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v18950 : Async<US6> = null |> unbox<Async<US6>>
            let _v18949 = v18950 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18953 : Async<US6> = null |> unbox<Async<US6>>
            let _v18949 = v18953 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18956 : Async<US6> = null |> unbox<Async<US6>>
            let _v18949 = v18956 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v18959 : unit = ()
            let _v18959 =
                async {
                    let! v18944 = v18944 
                    let v18960 : US8 = v18944 
                    let v19084 : US6 =
                        match v18960 with
                        | US8_1(v18963) -> (* Error *)
                            let v18964 : string = $"%A{v18963}"
                            let v18967 : string = "System.TimeoutException"
                            let v18968 : bool = v18964.Contains v18967 
                            if v18968 then
                                let v18971 : unit = ()
                                let v18972 : (unit -> unit) = closure16(v0)
                                let v18973 : unit = (fun () -> v18972 (); v18971) ()
                                US6_1
                            else
                                let v19014 : unit = ()
                                let v19015 : (unit -> unit) = closure17(v0, v18963)
                                let v19016 : unit = (fun () -> v19015 (); v19014) ()
                                US6_1
                        | US8_0(v18961) -> (* Ok *)
                            US6_0(v18961)
                    return v19084 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19085 : Async<US6> = _v18959 
            let _v18949 = v19085 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19086 : unit = ()
            let _v19086 =
                async {
                    let! v18944 = v18944 
                    let v19087 : US8 = v18944 
                    let v19211 : US6 =
                        match v19087 with
                        | US8_1(v19090) -> (* Error *)
                            let v19091 : string = $"%A{v19090}"
                            let v19094 : string = "System.TimeoutException"
                            let v19095 : bool = v19091.Contains v19094 
                            if v19095 then
                                let v19098 : unit = ()
                                let v19099 : (unit -> unit) = closure16(v0)
                                let v19100 : unit = (fun () -> v19099 (); v19098) ()
                                US6_1
                            else
                                let v19141 : unit = ()
                                let v19142 : (unit -> unit) = closure17(v0, v19090)
                                let v19143 : unit = (fun () -> v19142 (); v19141) ()
                                US6_1
                        | US8_0(v19088) -> (* Ok *)
                            US6_0(v19088)
                    return v19211 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19212 : Async<US6> = _v19086 
            let _v18949 = v19212 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19213 : unit = ()
            let _v19213 =
                async {
                    let! v18944 = v18944 
                    let v19214 : US8 = v18944 
                    let v19338 : US6 =
                        match v19214 with
                        | US8_1(v19217) -> (* Error *)
                            let v19218 : string = $"%A{v19217}"
                            let v19221 : string = "System.TimeoutException"
                            let v19222 : bool = v19218.Contains v19221 
                            if v19222 then
                                let v19225 : unit = ()
                                let v19226 : (unit -> unit) = closure16(v0)
                                let v19227 : unit = (fun () -> v19226 (); v19225) ()
                                US6_1
                            else
                                let v19268 : unit = ()
                                let v19269 : (unit -> unit) = closure17(v0, v19217)
                                let v19270 : unit = (fun () -> v19269 (); v19268) ()
                                US6_1
                        | US8_0(v19215) -> (* Ok *)
                            US6_0(v19215)
                    return v19338 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19339 : Async<US6> = _v19213 
            let _v18949 = v19339 
            #endif
#else
            let v19340 : unit = ()
            let _v19340 =
                async {
                    let! v18944 = v18944 
                    let v19341 : US8 = v18944 
                    let v19465 : US6 =
                        match v19341 with
                        | US8_1(v19344) -> (* Error *)
                            let v19345 : string = $"%A{v19344}"
                            let v19348 : string = "System.TimeoutException"
                            let v19349 : bool = v19345.Contains v19348 
                            if v19349 then
                                let v19352 : unit = ()
                                let v19353 : (unit -> unit) = closure16(v0)
                                let v19354 : unit = (fun () -> v19353 (); v19352) ()
                                US6_1
                            else
                                let v19395 : unit = ()
                                let v19396 : (unit -> unit) = closure17(v0, v19344)
                                let v19397 : unit = (fun () -> v19396 (); v19395) ()
                                US6_1
                        | US8_0(v19342) -> (* Ok *)
                            US6_0(v19342)
                    return v19465 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19466 : Async<US6> = _v19340 
            let _v18949 = v19466 
            #endif
            let v19467 : Async<US6> = _v18949 
            return! v19467 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v19472 : Async<US6> = _v18728 
    let _v17973 = v19472 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v19473 : unit = ()
    let _v19473 =
        async {
            let v19474 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19475 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19475 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19476 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19476 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19477 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19477 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19478 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19478 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19479 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19479 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19480 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19480 
            #endif
#else
            let v19481 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v19474 = v19481 
            #endif
            let v19482 : Async<Async<bool>> = _v19474 
            let! v19482 = v19482 
            let v19487 : Async<bool> = v19482 
            let v19488 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19489 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19490 : Async<Choice<bool, exn>> = v19489 v19487
            let _v19488 = v19490 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19491 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19492 : Async<Choice<bool, exn>> = v19491 v19487
            let _v19488 = v19492 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19493 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19494 : Async<Choice<bool, exn>> = v19493 v19487
            let _v19488 = v19494 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19495 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19496 : Async<Choice<bool, exn>> = v19495 v19487
            let _v19488 = v19496 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19497 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19498 : Async<Choice<bool, exn>> = v19497 v19487
            let _v19488 = v19498 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19499 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19500 : Async<Choice<bool, exn>> = v19499 v19487
            let _v19488 = v19500 
            #endif
#else
            let v19501 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v19502 : Async<Choice<bool, exn>> = v19501 v19487
            let _v19488 = v19502 
            #endif
            let v19503 : Async<Choice<bool, exn>> = _v19488 
            let v19508 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19509 : Async<US7> = null |> unbox<Async<US7>>
            let _v19508 = v19509 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19512 : Async<US7> = null |> unbox<Async<US7>>
            let _v19508 = v19512 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19515 : Async<US7> = null |> unbox<Async<US7>>
            let _v19508 = v19515 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19518 : unit = ()
            let _v19518 =
                async {
                    let! v19503 = v19503 
                    let v19519 : Choice<bool, exn> = v19503 
                    let v19520 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19521 : US7 = null |> unbox<US7>
                    let _v19520 = v19521 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19524 : US7 = null |> unbox<US7>
                    let _v19520 = v19524 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19527 : US7 = null |> unbox<US7>
                    let _v19520 = v19527 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19530 : US7 = null |> unbox<US7>
                    let _v19520 = v19530 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19533 : US7 = null |> unbox<US7>
                    let _v19520 = v19533 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19536 : (bool -> US7) = method21()
                    let v19537 : (exn -> US7) = method22()
                    let v19538 : US7 = match v19519 with Choice1Of2 x -> v19536 x | Choice2Of2 x -> v19537 x
                    let _v19520 = v19538 
                    #endif
#else
                    let v19539 : (bool -> US7) = method21()
                    let v19540 : (exn -> US7) = method22()
                    let v19541 : US7 = match v19519 with Choice1Of2 x -> v19539 x | Choice2Of2 x -> v19540 x
                    let _v19520 = v19541 
                    #endif
                    let v19542 : US7 = _v19520 
                    return v19542 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19547 : Async<US7> = _v19518 
            let _v19508 = v19547 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19548 : unit = ()
            let _v19548 =
                async {
                    let! v19503 = v19503 
                    let v19549 : Choice<bool, exn> = v19503 
                    let v19550 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19551 : US7 = null |> unbox<US7>
                    let _v19550 = v19551 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19554 : US7 = null |> unbox<US7>
                    let _v19550 = v19554 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19557 : US7 = null |> unbox<US7>
                    let _v19550 = v19557 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19560 : US7 = null |> unbox<US7>
                    let _v19550 = v19560 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19563 : US7 = null |> unbox<US7>
                    let _v19550 = v19563 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19566 : (bool -> US7) = method21()
                    let v19567 : (exn -> US7) = method22()
                    let v19568 : US7 = match v19549 with Choice1Of2 x -> v19566 x | Choice2Of2 x -> v19567 x
                    let _v19550 = v19568 
                    #endif
#else
                    let v19569 : (bool -> US7) = method21()
                    let v19570 : (exn -> US7) = method22()
                    let v19571 : US7 = match v19549 with Choice1Of2 x -> v19569 x | Choice2Of2 x -> v19570 x
                    let _v19550 = v19571 
                    #endif
                    let v19572 : US7 = _v19550 
                    return v19572 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19577 : Async<US7> = _v19548 
            let _v19508 = v19577 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19578 : unit = ()
            let _v19578 =
                async {
                    let! v19503 = v19503 
                    let v19579 : Choice<bool, exn> = v19503 
                    let v19580 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19581 : US7 = null |> unbox<US7>
                    let _v19580 = v19581 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19584 : US7 = null |> unbox<US7>
                    let _v19580 = v19584 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19587 : US7 = null |> unbox<US7>
                    let _v19580 = v19587 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19590 : US7 = null |> unbox<US7>
                    let _v19580 = v19590 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19593 : US7 = null |> unbox<US7>
                    let _v19580 = v19593 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19596 : (bool -> US7) = method21()
                    let v19597 : (exn -> US7) = method22()
                    let v19598 : US7 = match v19579 with Choice1Of2 x -> v19596 x | Choice2Of2 x -> v19597 x
                    let _v19580 = v19598 
                    #endif
#else
                    let v19599 : (bool -> US7) = method21()
                    let v19600 : (exn -> US7) = method22()
                    let v19601 : US7 = match v19579 with Choice1Of2 x -> v19599 x | Choice2Of2 x -> v19600 x
                    let _v19580 = v19601 
                    #endif
                    let v19602 : US7 = _v19580 
                    return v19602 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19607 : Async<US7> = _v19578 
            let _v19508 = v19607 
            #endif
#else
            let v19608 : unit = ()
            let _v19608 =
                async {
                    let! v19503 = v19503 
                    let v19609 : Choice<bool, exn> = v19503 
                    let v19610 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v19611 : US7 = null |> unbox<US7>
                    let _v19610 = v19611 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v19614 : US7 = null |> unbox<US7>
                    let _v19610 = v19614 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v19617 : US7 = null |> unbox<US7>
                    let _v19610 = v19617 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v19620 : US7 = null |> unbox<US7>
                    let _v19610 = v19620 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v19623 : US7 = null |> unbox<US7>
                    let _v19610 = v19623 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v19626 : (bool -> US7) = method21()
                    let v19627 : (exn -> US7) = method22()
                    let v19628 : US7 = match v19609 with Choice1Of2 x -> v19626 x | Choice2Of2 x -> v19627 x
                    let _v19610 = v19628 
                    #endif
#else
                    let v19629 : (bool -> US7) = method21()
                    let v19630 : (exn -> US7) = method22()
                    let v19631 : US7 = match v19609 with Choice1Of2 x -> v19629 x | Choice2Of2 x -> v19630 x
                    let _v19610 = v19631 
                    #endif
                    let v19632 : US7 = _v19610 
                    return v19632 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19637 : Async<US7> = _v19608 
            let _v19508 = v19637 
            #endif
            let v19638 : Async<US7> = _v19508 
            let v19643 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19644 : Async<US8> = null |> unbox<Async<US8>>
            let _v19643 = v19644 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19647 : Async<US8> = null |> unbox<Async<US8>>
            let _v19643 = v19647 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19650 : Async<US8> = null |> unbox<Async<US8>>
            let _v19643 = v19650 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19653 : unit = ()
            let _v19653 =
                async {
                    let! v19638 = v19638 
                    let v19654 : US7 = v19638 
                    let v19660 : US8 =
                        match v19654 with
                        | US7_0(v19655) -> (* C1of2 *)
                            US8_0(v19655)
                        | US7_1(v19657) -> (* C2of2 *)
                            US8_1(v19657)
                    return v19660 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19661 : Async<US8> = _v19653 
            let _v19643 = v19661 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19662 : unit = ()
            let _v19662 =
                async {
                    let! v19638 = v19638 
                    let v19663 : US7 = v19638 
                    let v19669 : US8 =
                        match v19663 with
                        | US7_0(v19664) -> (* C1of2 *)
                            US8_0(v19664)
                        | US7_1(v19666) -> (* C2of2 *)
                            US8_1(v19666)
                    return v19669 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19670 : Async<US8> = _v19662 
            let _v19643 = v19670 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19671 : unit = ()
            let _v19671 =
                async {
                    let! v19638 = v19638 
                    let v19672 : US7 = v19638 
                    let v19678 : US8 =
                        match v19672 with
                        | US7_0(v19673) -> (* C1of2 *)
                            US8_0(v19673)
                        | US7_1(v19675) -> (* C2of2 *)
                            US8_1(v19675)
                    return v19678 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19679 : Async<US8> = _v19671 
            let _v19643 = v19679 
            #endif
#else
            let v19680 : unit = ()
            let _v19680 =
                async {
                    let! v19638 = v19638 
                    let v19681 : US7 = v19638 
                    let v19687 : US8 =
                        match v19681 with
                        | US7_0(v19682) -> (* C1of2 *)
                            US8_0(v19682)
                        | US7_1(v19684) -> (* C2of2 *)
                            US8_1(v19684)
                    return v19687 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19688 : Async<US8> = _v19680 
            let _v19643 = v19688 
            #endif
            let v19689 : Async<US8> = _v19643 
            let v19694 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v19695 : Async<US6> = null |> unbox<Async<US6>>
            let _v19694 = v19695 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v19698 : Async<US6> = null |> unbox<Async<US6>>
            let _v19694 = v19698 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v19701 : Async<US6> = null |> unbox<Async<US6>>
            let _v19694 = v19701 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v19704 : unit = ()
            let _v19704 =
                async {
                    let! v19689 = v19689 
                    let v19705 : US8 = v19689 
                    let v19829 : US6 =
                        match v19705 with
                        | US8_1(v19708) -> (* Error *)
                            let v19709 : string = $"%A{v19708}"
                            let v19712 : string = "System.TimeoutException"
                            let v19713 : bool = v19709.Contains v19712 
                            if v19713 then
                                let v19716 : unit = ()
                                let v19717 : (unit -> unit) = closure16(v0)
                                let v19718 : unit = (fun () -> v19717 (); v19716) ()
                                US6_1
                            else
                                let v19759 : unit = ()
                                let v19760 : (unit -> unit) = closure17(v0, v19708)
                                let v19761 : unit = (fun () -> v19760 (); v19759) ()
                                US6_1
                        | US8_0(v19706) -> (* Ok *)
                            US6_0(v19706)
                    return v19829 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19830 : Async<US6> = _v19704 
            let _v19694 = v19830 
            #endif
#if FABLE_COMPILER_PYTHON
            let v19831 : unit = ()
            let _v19831 =
                async {
                    let! v19689 = v19689 
                    let v19832 : US8 = v19689 
                    let v19956 : US6 =
                        match v19832 with
                        | US8_1(v19835) -> (* Error *)
                            let v19836 : string = $"%A{v19835}"
                            let v19839 : string = "System.TimeoutException"
                            let v19840 : bool = v19836.Contains v19839 
                            if v19840 then
                                let v19843 : unit = ()
                                let v19844 : (unit -> unit) = closure16(v0)
                                let v19845 : unit = (fun () -> v19844 (); v19843) ()
                                US6_1
                            else
                                let v19886 : unit = ()
                                let v19887 : (unit -> unit) = closure17(v0, v19835)
                                let v19888 : unit = (fun () -> v19887 (); v19886) ()
                                US6_1
                        | US8_0(v19833) -> (* Ok *)
                            US6_0(v19833)
                    return v19956 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v19957 : Async<US6> = _v19831 
            let _v19694 = v19957 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v19958 : unit = ()
            let _v19958 =
                async {
                    let! v19689 = v19689 
                    let v19959 : US8 = v19689 
                    let v20083 : US6 =
                        match v19959 with
                        | US8_1(v19962) -> (* Error *)
                            let v19963 : string = $"%A{v19962}"
                            let v19966 : string = "System.TimeoutException"
                            let v19967 : bool = v19963.Contains v19966 
                            if v19967 then
                                let v19970 : unit = ()
                                let v19971 : (unit -> unit) = closure16(v0)
                                let v19972 : unit = (fun () -> v19971 (); v19970) ()
                                US6_1
                            else
                                let v20013 : unit = ()
                                let v20014 : (unit -> unit) = closure17(v0, v19962)
                                let v20015 : unit = (fun () -> v20014 (); v20013) ()
                                US6_1
                        | US8_0(v19960) -> (* Ok *)
                            US6_0(v19960)
                    return v20083 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20084 : Async<US6> = _v19958 
            let _v19694 = v20084 
            #endif
#else
            let v20085 : unit = ()
            let _v20085 =
                async {
                    let! v19689 = v19689 
                    let v20086 : US8 = v19689 
                    let v20210 : US6 =
                        match v20086 with
                        | US8_1(v20089) -> (* Error *)
                            let v20090 : string = $"%A{v20089}"
                            let v20093 : string = "System.TimeoutException"
                            let v20094 : bool = v20090.Contains v20093 
                            if v20094 then
                                let v20097 : unit = ()
                                let v20098 : (unit -> unit) = closure16(v0)
                                let v20099 : unit = (fun () -> v20098 (); v20097) ()
                                US6_1
                            else
                                let v20140 : unit = ()
                                let v20141 : (unit -> unit) = closure17(v0, v20089)
                                let v20142 : unit = (fun () -> v20141 (); v20140) ()
                                US6_1
                        | US8_0(v20087) -> (* Ok *)
                            US6_0(v20087)
                    return v20210 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20211 : Async<US6> = _v20085 
            let _v19694 = v20211 
            #endif
            let v20212 : Async<US6> = _v19694 
            return! v20212 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v20217 : Async<US6> = _v19473 
    let _v17973 = v20217 
    #endif
#else
    let v20218 : unit = ()
    let _v20218 =
        async {
            let v20219 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20220 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20220 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20221 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20221 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20222 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20222 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20223 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20223 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20224 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20224 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20225 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20225 
            #endif
#else
            let v20226 : Async<Async<bool>> = Async.StartChild (v1, v0)
            let _v20219 = v20226 
            #endif
            let v20227 : Async<Async<bool>> = _v20219 
            let! v20227 = v20227 
            let v20232 : Async<bool> = v20227 
            let v20233 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20234 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20235 : Async<Choice<bool, exn>> = v20234 v20232
            let _v20233 = v20235 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20236 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20237 : Async<Choice<bool, exn>> = v20236 v20232
            let _v20233 = v20237 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20238 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20239 : Async<Choice<bool, exn>> = v20238 v20232
            let _v20233 = v20239 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20240 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20241 : Async<Choice<bool, exn>> = v20240 v20232
            let _v20233 = v20241 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20242 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20243 : Async<Choice<bool, exn>> = v20242 v20232
            let _v20233 = v20243 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20244 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20245 : Async<Choice<bool, exn>> = v20244 v20232
            let _v20233 = v20245 
            #endif
#else
            let v20246 : (Async<bool> -> Async<Choice<bool, exn>>) = Async.Catch
            let v20247 : Async<Choice<bool, exn>> = v20246 v20232
            let _v20233 = v20247 
            #endif
            let v20248 : Async<Choice<bool, exn>> = _v20233 
            let v20253 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20254 : Async<US7> = null |> unbox<Async<US7>>
            let _v20253 = v20254 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20257 : Async<US7> = null |> unbox<Async<US7>>
            let _v20253 = v20257 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20260 : Async<US7> = null |> unbox<Async<US7>>
            let _v20253 = v20260 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20263 : unit = ()
            let _v20263 =
                async {
                    let! v20248 = v20248 
                    let v20264 : Choice<bool, exn> = v20248 
                    let v20265 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20266 : US7 = null |> unbox<US7>
                    let _v20265 = v20266 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20269 : US7 = null |> unbox<US7>
                    let _v20265 = v20269 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20272 : US7 = null |> unbox<US7>
                    let _v20265 = v20272 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20275 : US7 = null |> unbox<US7>
                    let _v20265 = v20275 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20278 : US7 = null |> unbox<US7>
                    let _v20265 = v20278 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20281 : (bool -> US7) = method21()
                    let v20282 : (exn -> US7) = method22()
                    let v20283 : US7 = match v20264 with Choice1Of2 x -> v20281 x | Choice2Of2 x -> v20282 x
                    let _v20265 = v20283 
                    #endif
#else
                    let v20284 : (bool -> US7) = method21()
                    let v20285 : (exn -> US7) = method22()
                    let v20286 : US7 = match v20264 with Choice1Of2 x -> v20284 x | Choice2Of2 x -> v20285 x
                    let _v20265 = v20286 
                    #endif
                    let v20287 : US7 = _v20265 
                    return v20287 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20292 : Async<US7> = _v20263 
            let _v20253 = v20292 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20293 : unit = ()
            let _v20293 =
                async {
                    let! v20248 = v20248 
                    let v20294 : Choice<bool, exn> = v20248 
                    let v20295 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20296 : US7 = null |> unbox<US7>
                    let _v20295 = v20296 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20299 : US7 = null |> unbox<US7>
                    let _v20295 = v20299 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20302 : US7 = null |> unbox<US7>
                    let _v20295 = v20302 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20305 : US7 = null |> unbox<US7>
                    let _v20295 = v20305 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20308 : US7 = null |> unbox<US7>
                    let _v20295 = v20308 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20311 : (bool -> US7) = method21()
                    let v20312 : (exn -> US7) = method22()
                    let v20313 : US7 = match v20294 with Choice1Of2 x -> v20311 x | Choice2Of2 x -> v20312 x
                    let _v20295 = v20313 
                    #endif
#else
                    let v20314 : (bool -> US7) = method21()
                    let v20315 : (exn -> US7) = method22()
                    let v20316 : US7 = match v20294 with Choice1Of2 x -> v20314 x | Choice2Of2 x -> v20315 x
                    let _v20295 = v20316 
                    #endif
                    let v20317 : US7 = _v20295 
                    return v20317 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20322 : Async<US7> = _v20293 
            let _v20253 = v20322 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20323 : unit = ()
            let _v20323 =
                async {
                    let! v20248 = v20248 
                    let v20324 : Choice<bool, exn> = v20248 
                    let v20325 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20326 : US7 = null |> unbox<US7>
                    let _v20325 = v20326 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20329 : US7 = null |> unbox<US7>
                    let _v20325 = v20329 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20332 : US7 = null |> unbox<US7>
                    let _v20325 = v20332 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20335 : US7 = null |> unbox<US7>
                    let _v20325 = v20335 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20338 : US7 = null |> unbox<US7>
                    let _v20325 = v20338 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20341 : (bool -> US7) = method21()
                    let v20342 : (exn -> US7) = method22()
                    let v20343 : US7 = match v20324 with Choice1Of2 x -> v20341 x | Choice2Of2 x -> v20342 x
                    let _v20325 = v20343 
                    #endif
#else
                    let v20344 : (bool -> US7) = method21()
                    let v20345 : (exn -> US7) = method22()
                    let v20346 : US7 = match v20324 with Choice1Of2 x -> v20344 x | Choice2Of2 x -> v20345 x
                    let _v20325 = v20346 
                    #endif
                    let v20347 : US7 = _v20325 
                    return v20347 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20352 : Async<US7> = _v20323 
            let _v20253 = v20352 
            #endif
#else
            let v20353 : unit = ()
            let _v20353 =
                async {
                    let! v20248 = v20248 
                    let v20354 : Choice<bool, exn> = v20248 
                    let v20355 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v20356 : US7 = null |> unbox<US7>
                    let _v20355 = v20356 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v20359 : US7 = null |> unbox<US7>
                    let _v20355 = v20359 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v20362 : US7 = null |> unbox<US7>
                    let _v20355 = v20362 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v20365 : US7 = null |> unbox<US7>
                    let _v20355 = v20365 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v20368 : US7 = null |> unbox<US7>
                    let _v20355 = v20368 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v20371 : (bool -> US7) = method21()
                    let v20372 : (exn -> US7) = method22()
                    let v20373 : US7 = match v20354 with Choice1Of2 x -> v20371 x | Choice2Of2 x -> v20372 x
                    let _v20355 = v20373 
                    #endif
#else
                    let v20374 : (bool -> US7) = method21()
                    let v20375 : (exn -> US7) = method22()
                    let v20376 : US7 = match v20354 with Choice1Of2 x -> v20374 x | Choice2Of2 x -> v20375 x
                    let _v20355 = v20376 
                    #endif
                    let v20377 : US7 = _v20355 
                    return v20377 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20382 : Async<US7> = _v20353 
            let _v20253 = v20382 
            #endif
            let v20383 : Async<US7> = _v20253 
            let v20388 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20389 : Async<US8> = null |> unbox<Async<US8>>
            let _v20388 = v20389 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20392 : Async<US8> = null |> unbox<Async<US8>>
            let _v20388 = v20392 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20395 : Async<US8> = null |> unbox<Async<US8>>
            let _v20388 = v20395 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20398 : unit = ()
            let _v20398 =
                async {
                    let! v20383 = v20383 
                    let v20399 : US7 = v20383 
                    let v20405 : US8 =
                        match v20399 with
                        | US7_0(v20400) -> (* C1of2 *)
                            US8_0(v20400)
                        | US7_1(v20402) -> (* C2of2 *)
                            US8_1(v20402)
                    return v20405 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20406 : Async<US8> = _v20398 
            let _v20388 = v20406 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20407 : unit = ()
            let _v20407 =
                async {
                    let! v20383 = v20383 
                    let v20408 : US7 = v20383 
                    let v20414 : US8 =
                        match v20408 with
                        | US7_0(v20409) -> (* C1of2 *)
                            US8_0(v20409)
                        | US7_1(v20411) -> (* C2of2 *)
                            US8_1(v20411)
                    return v20414 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20415 : Async<US8> = _v20407 
            let _v20388 = v20415 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20416 : unit = ()
            let _v20416 =
                async {
                    let! v20383 = v20383 
                    let v20417 : US7 = v20383 
                    let v20423 : US8 =
                        match v20417 with
                        | US7_0(v20418) -> (* C1of2 *)
                            US8_0(v20418)
                        | US7_1(v20420) -> (* C2of2 *)
                            US8_1(v20420)
                    return v20423 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20424 : Async<US8> = _v20416 
            let _v20388 = v20424 
            #endif
#else
            let v20425 : unit = ()
            let _v20425 =
                async {
                    let! v20383 = v20383 
                    let v20426 : US7 = v20383 
                    let v20432 : US8 =
                        match v20426 with
                        | US7_0(v20427) -> (* C1of2 *)
                            US8_0(v20427)
                        | US7_1(v20429) -> (* C2of2 *)
                            US8_1(v20429)
                    return v20432 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20433 : Async<US8> = _v20425 
            let _v20388 = v20433 
            #endif
            let v20434 : Async<US8> = _v20388 
            let v20439 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v20440 : Async<US6> = null |> unbox<Async<US6>>
            let _v20439 = v20440 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v20443 : Async<US6> = null |> unbox<Async<US6>>
            let _v20439 = v20443 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v20446 : Async<US6> = null |> unbox<Async<US6>>
            let _v20439 = v20446 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20449 : unit = ()
            let _v20449 =
                async {
                    let! v20434 = v20434 
                    let v20450 : US8 = v20434 
                    let v20574 : US6 =
                        match v20450 with
                        | US8_1(v20453) -> (* Error *)
                            let v20454 : string = $"%A{v20453}"
                            let v20457 : string = "System.TimeoutException"
                            let v20458 : bool = v20454.Contains v20457 
                            if v20458 then
                                let v20461 : unit = ()
                                let v20462 : (unit -> unit) = closure16(v0)
                                let v20463 : unit = (fun () -> v20462 (); v20461) ()
                                US6_1
                            else
                                let v20504 : unit = ()
                                let v20505 : (unit -> unit) = closure17(v0, v20453)
                                let v20506 : unit = (fun () -> v20505 (); v20504) ()
                                US6_1
                        | US8_0(v20451) -> (* Ok *)
                            US6_0(v20451)
                    return v20574 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20575 : Async<US6> = _v20449 
            let _v20439 = v20575 
            #endif
#if FABLE_COMPILER_PYTHON
            let v20576 : unit = ()
            let _v20576 =
                async {
                    let! v20434 = v20434 
                    let v20577 : US8 = v20434 
                    let v20701 : US6 =
                        match v20577 with
                        | US8_1(v20580) -> (* Error *)
                            let v20581 : string = $"%A{v20580}"
                            let v20584 : string = "System.TimeoutException"
                            let v20585 : bool = v20581.Contains v20584 
                            if v20585 then
                                let v20588 : unit = ()
                                let v20589 : (unit -> unit) = closure16(v0)
                                let v20590 : unit = (fun () -> v20589 (); v20588) ()
                                US6_1
                            else
                                let v20631 : unit = ()
                                let v20632 : (unit -> unit) = closure17(v0, v20580)
                                let v20633 : unit = (fun () -> v20632 (); v20631) ()
                                US6_1
                        | US8_0(v20578) -> (* Ok *)
                            US6_0(v20578)
                    return v20701 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20702 : Async<US6> = _v20576 
            let _v20439 = v20702 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v20703 : unit = ()
            let _v20703 =
                async {
                    let! v20434 = v20434 
                    let v20704 : US8 = v20434 
                    let v20828 : US6 =
                        match v20704 with
                        | US8_1(v20707) -> (* Error *)
                            let v20708 : string = $"%A{v20707}"
                            let v20711 : string = "System.TimeoutException"
                            let v20712 : bool = v20708.Contains v20711 
                            if v20712 then
                                let v20715 : unit = ()
                                let v20716 : (unit -> unit) = closure16(v0)
                                let v20717 : unit = (fun () -> v20716 (); v20715) ()
                                US6_1
                            else
                                let v20758 : unit = ()
                                let v20759 : (unit -> unit) = closure17(v0, v20707)
                                let v20760 : unit = (fun () -> v20759 (); v20758) ()
                                US6_1
                        | US8_0(v20705) -> (* Ok *)
                            US6_0(v20705)
                    return v20828 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20829 : Async<US6> = _v20703 
            let _v20439 = v20829 
            #endif
#else
            let v20830 : unit = ()
            let _v20830 =
                async {
                    let! v20434 = v20434 
                    let v20831 : US8 = v20434 
                    let v20955 : US6 =
                        match v20831 with
                        | US8_1(v20834) -> (* Error *)
                            let v20835 : string = $"%A{v20834}"
                            let v20838 : string = "System.TimeoutException"
                            let v20839 : bool = v20835.Contains v20838 
                            if v20839 then
                                let v20842 : unit = ()
                                let v20843 : (unit -> unit) = closure16(v0)
                                let v20844 : unit = (fun () -> v20843 (); v20842) ()
                                US6_1
                            else
                                let v20885 : unit = ()
                                let v20886 : (unit -> unit) = closure17(v0, v20834)
                                let v20887 : unit = (fun () -> v20886 (); v20885) ()
                                US6_1
                        | US8_0(v20832) -> (* Ok *)
                            US6_0(v20832)
                    return v20955 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v20956 : Async<US6> = _v20830 
            let _v20439 = v20956 
            #endif
            let v20957 : Async<US6> = _v20439 
            return! v20957 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v20962 : Async<US6> = _v20218 
    let _v17973 = v20962 
    #endif
    let v20963 : Async<US6> = _v17973 
    let _v2 = v20963 
    #endif
    let v20968 : Async<US6> = _v2 
    v20968
and method19 (v0 : int32, v1 : string, v2 : int32) : Async<bool> =
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
            let v14 : Async<bool> = method5(v1, v2)
            let v15 : Async<US6> = method20(v0, v14)
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
            let v22 : Async<bool> = method5(v1, v2)
            let v23 : Async<US6> = method20(v0, v22)
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
            let v30 : Async<bool> = method5(v1, v2)
            let v31 : Async<US6> = method20(v0, v30)
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
            let v38 : Async<bool> = method5(v1, v2)
            let v39 : Async<US6> = method20(v0, v38)
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
    method19(v0, v1, v2)
and closure12 (v0 : int32) (v1 : string) : (int32 -> Async<bool>) =
    closure13(v0, v1)
and closure11 () (v0 : int32) : (string -> (int32 -> Async<bool>)) =
    closure12(v0)
and closure22 () (v0 : int32) : US9 =
    US9_0(v0)
and method30 () : (int32 -> US9) =
    closure22()
and method32 (v0 : int32, v1 : int64, v2 : int32 option, v3 : bool) : string =
    let v4 : string = method13()
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
and method31 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int64, v10 : int32 option, v11 : bool) : string =
    let v12 : string = method32(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "networking.wait_for_port_access"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method17(v15)
and closure23 (v0 : int32 option, v1 : bool, v2 : int32, v3 : int64) () : unit =
    let v4 : US0 = US0_0
    let v5 : bool = method6(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure0()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method7(v22, v23, v24, v25, v26, v27)
        let v41 : string = method11()
        let v42 : string = method31(v22, v23, v24, v25, v26, v27, v40, v41, v2, v3, v0, v1)
        method18(v42)
and method29 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32, v4 : int64) : Async<int64> =
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
            let v16 : (int32 -> US9) = method30()
            let v17 : US9 option = v0 |> Option.map v16 
            let v28 : US9 = US9_1
            let v29 : US9 = v17 |> Option.defaultValue v28 
            let v37 : Async<bool> =
                match v29 with
                | US9_1 -> (* None *)
                    method5(v2, v3)
                | US9_0(v34) -> (* Some *)
                    method19(v34, v2, v3)
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
                let v105 : Async<int64> = method29(v0, v1, v2, v3, v104)
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
            let v108 : (int32 -> US9) = method30()
            let v109 : US9 option = v0 |> Option.map v108 
            let v120 : US9 = US9_1
            let v121 : US9 = v109 |> Option.defaultValue v120 
            let v129 : Async<bool> =
                match v121 with
                | US9_1 -> (* None *)
                    method5(v2, v3)
                | US9_0(v126) -> (* Some *)
                    method19(v126, v2, v3)
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
                let v197 : Async<int64> = method29(v0, v1, v2, v3, v196)
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
            let v200 : (int32 -> US9) = method30()
            let v201 : US9 option = v0 |> Option.map v200 
            let v212 : US9 = US9_1
            let v213 : US9 = v201 |> Option.defaultValue v212 
            let v221 : Async<bool> =
                match v213 with
                | US9_1 -> (* None *)
                    method5(v2, v3)
                | US9_0(v218) -> (* Some *)
                    method19(v218, v2, v3)
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
                let v289 : Async<int64> = method29(v0, v1, v2, v3, v288)
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
            let v292 : (int32 -> US9) = method30()
            let v293 : US9 option = v0 |> Option.map v292 
            let v304 : US9 = US9_1
            let v305 : US9 = v293 |> Option.defaultValue v304 
            let v313 : Async<bool> =
                match v305 with
                | US9_1 -> (* None *)
                    method5(v2, v3)
                | US9_0(v310) -> (* Some *)
                    method19(v310, v2, v3)
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
                let v381 : Async<int64> = method29(v0, v1, v2, v3, v380)
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
and method28 (v0 : int32 option, v1 : bool, v2 : string, v3 : int32) : Async<int64> =
    let v4 : int64 = 1L
    method29(v0, v1, v2, v3, v4)
and closure21 (v0 : int32 option, v1 : bool, v2 : string) (v3 : int32) : Async<int64> =
    method28(v0, v1, v2, v3)
and closure20 (v0 : int32 option, v1 : bool) (v2 : string) : (int32 -> Async<int64>) =
    closure21(v0, v1, v2)
and closure19 (v0 : int32 option) (v1 : bool) : (string -> (int32 -> Async<int64>)) =
    closure20(v0, v1)
and closure18 () (v0 : int32 option) : (bool -> (string -> (int32 -> Async<int64>))) =
    closure19(v0)
and method34 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
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
            let v14 : (int32 -> US9) = method30()
            let v15 : US9 option = v0 |> Option.map v14 
            let v26 : US9 = US9_1
            let v27 : US9 = v15 |> Option.defaultValue v26 
            let v35 : Async<bool> =
                match v27 with
                | US9_1 -> (* None *)
                    method5(v1, v2)
                | US9_0(v32) -> (* Some *)
                    method19(v32, v1, v2)
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
                let v39 : Async<int32> = method34(v0, v1, v38)
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
            let v42 : (int32 -> US9) = method30()
            let v43 : US9 option = v0 |> Option.map v42 
            let v54 : US9 = US9_1
            let v55 : US9 = v43 |> Option.defaultValue v54 
            let v63 : Async<bool> =
                match v55 with
                | US9_1 -> (* None *)
                    method5(v1, v2)
                | US9_0(v60) -> (* Some *)
                    method19(v60, v1, v2)
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
                let v67 : Async<int32> = method34(v0, v1, v66)
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
            let v70 : (int32 -> US9) = method30()
            let v71 : US9 option = v0 |> Option.map v70 
            let v82 : US9 = US9_1
            let v83 : US9 = v71 |> Option.defaultValue v82 
            let v91 : Async<bool> =
                match v83 with
                | US9_1 -> (* None *)
                    method5(v1, v2)
                | US9_0(v88) -> (* Some *)
                    method19(v88, v1, v2)
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
                let v95 : Async<int32> = method34(v0, v1, v94)
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
            let v98 : (int32 -> US9) = method30()
            let v99 : US9 option = v0 |> Option.map v98 
            let v110 : US9 = US9_1
            let v111 : US9 = v99 |> Option.defaultValue v110 
            let v119 : Async<bool> =
                match v111 with
                | US9_1 -> (* None *)
                    method5(v1, v2)
                | US9_0(v116) -> (* Some *)
                    method19(v116, v1, v2)
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
                let v123 : Async<int32> = method34(v0, v1, v122)
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
and method33 (v0 : int32 option, v1 : string, v2 : int32) : Async<int32> =
    method34(v0, v1, v2)
and closure26 (v0 : int32 option, v1 : string) (v2 : int32) : Async<int32> =
    method33(v0, v1, v2)
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
