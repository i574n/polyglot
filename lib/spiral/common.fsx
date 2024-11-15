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

type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
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
    | US6_0
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : US6
    | US7_1
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
and method5 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and method6 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure3 () (v0 : (unit -> unit)) : System.IDisposable =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : (unit -> unit) = method5(v0)
    let v3 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v2 "$0()" )
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : (unit -> unit) = method5(v0)
    let v5 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v4 "$0()" )
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : (unit -> unit) = method5(v0)
    let v7 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v6 "$0()" )
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : (unit -> unit) = method6(v0)
    let v9 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v8 () }
    let _v1 = v9 
    #endif
#if FABLE_COMPILER_PYTHON
    let v10 : (unit -> unit) = method6(v0)
    let v11 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v10 () }
    let _v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v12 : (unit -> unit) = method6(v0)
    let v13 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v12 () }
    let _v1 = v13 
    #endif
#else
    let v14 : (unit -> unit) = method6(v0)
    let v15 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v14 () }
    let _v1 = v15 
    #endif
    let v16 : System.IDisposable = _v1 
    v16
and closure6 () (v0 : US6) : US7 =
    US7_0(v0)
and closure7 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US6 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US6_0
    else
        US6_1
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
and closure10 () (v0 : int64) : US2 =
    US2_0(v0)
and method10 () : (int64 -> US2) =
    closure10()
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
    let v117 : string = method11()
    let v120 : (string -> string) = v116.ToString
    let v121 : string = v120 v117
    let _v6 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v124 : (int64 -> US2) = method10()
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
    let v234 : string = method11()
    let v237 : (string -> string) = v233.ToString
    let v238 : string = v237 v234
    let _v6 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v241 : string = $"near_sdk::env::block_timestamp()"
    let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : (int64 -> US2) = method10()
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
    let v278 : (int64 -> US2) = method10()
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
    let v388 : string = method12()
    let v391 : (string -> string) = v387.ToString
    let v392 : string = v391 v388
    let _v6 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v395 : (int64 -> US2) = method10()
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
    let v505 : string = method12()
    let v508 : (string -> string) = v504.ToString
    let v509 : string = v508 v505
    let _v6 = v509 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v512 : (int64 -> US2) = method10()
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
    let v622 : string = method12()
    let v625 : (string -> string) = v621.ToString
    let v626 : string = v625 v622
    let _v6 = v626 
    #endif
#else
    let v629 : (int64 -> US2) = method10()
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
    let v739 : string = method12()
    let v742 : (string -> string) = v738.ToString
    let v743 : string = v742 v739
    let _v6 = v743 
    #endif
    let v746 : string = _v6 
    v746
and method15 () : string =
    let v0 : string = ""
    v0
and closure11 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method14 (v0 : char) : string =
    let v1 : string = method15()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure11(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method16 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method13 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
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
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method18 (v0 : int32, v1 : exn) : string =
    let v2 : string = method15()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure11(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure11(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure11(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure11(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure11(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "ex"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure11(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure11(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "format!(\"{:#?}\", $0)"
    let v67 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v66 
    let v68 : string = "fable_library_rust::String_::fromString($0)"
    let v69 : string = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let _v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _v65 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _v65 = v87 
    #endif
    let v90 : string = _v65 
    let v95 : string = $"{v90}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure11(v3, v95)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v103 : string = " }"
    let v104 : string = $"{v103}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure11(v3, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = v3.l0
    v112
and method19 (v0 : string) : string =
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
and method17 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : exn) : string =
    let v10 : string = method18(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "common.retry_fn"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
and closure12 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure14 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure13 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure14(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method20 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure12(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure13()
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
and closure9 (v0 : int32, v1 : exn) () : unit =
    let v2 : US0 = US0_3
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
and closure8 (v0 : int32) (v1 : exn) : US7 =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure9(v0, v1)
    let v4 : unit = (fun () -> v3 (); v2) ()
    US7_1
and method7 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US6 =
    let v3 : (US6 -> US7) = closure6()
    let v4 : (unit -> US6) = closure7(v0, v1, v2)
    let v5 : (exn -> US7) = closure8(v2)
    let v6 : US7 = US7_1
    let result = ref v6
    try
        result.Value <- v4 () |> v3 
    with ex ->
        result.Value <- v5 ex 
    let v7 : US7 = result.Value
    match v7 with
    | US7_1 -> (* None *)
        let v12 : int32 = v2 + 1
        method7(v0, v1, v12)
    | US7_0(v11) -> (* Some *)
        v11
and closure5 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US6 = method7(v0, v1, v2)
    match v3 with
    | US6_1 -> (* None *)
        let v7 : unit option = None
        v7
    | US6_0 -> (* Some *)
        let v4 : unit option = Some () 
        v4
and closure4 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure5(v0)
and method21 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure16 (v0 : Lazy<unit>) () : unit =
    v0.Value
    ()
and closure15 () (v0 : (unit -> unit)) : (unit -> unit) =
    let v1 : (unit -> unit) = method21(v0)
    let v2 : Lazy<unit> = lazy v1 ()
    closure16(v2)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : ((unit -> unit) -> System.IDisposable) = closure3()
let new_disposable x = v16 x
let v17 : (int32 -> ((unit -> unit) -> unit option)) = closure4()
let retry_fn x = v17 x
let v18 : ((unit -> unit) -> (unit -> unit)) = closure15()
let memoize x = v18 x
()
