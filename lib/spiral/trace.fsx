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
and method5 (v0 : US0) : bool =
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
and closure7 () (v0 : int64) : US2 =
    US2_0(v0)
and method7 () : (int64 -> US2) =
    closure7()
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method7()
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
    let v117 : string = method8()
    let v120 : (string -> string) = v116.ToString
    let v121 : string = v120 v117
    let _v6 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v127 : (int64 -> US2) = method7()
    let v128 : US2 option = v5 |> Option.map v127 
    let v139 : US2 = US2_1
    let v140 : US2 = v128 |> Option.defaultValue v139 
    let v236 : System.DateTime =
        match v140 with
        | US2_1 -> (* None *)
            let v220 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v221 : System.DateTime = System.DateTime.Now
            let _v220 = v221 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v222 : System.DateTime = System.DateTime.Now
            let _v220 = v222 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v223 : System.DateTime = null |> unbox<System.DateTime>
            let _v220 = v223 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v226 : System.DateTime = System.DateTime.Now
            let _v220 = v226 
            #endif
#if FABLE_COMPILER_PYTHON
            let v227 : System.DateTime = System.DateTime.Now
            let _v220 = v227 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v228 : System.DateTime = System.DateTime.Now
            let _v220 = v228 
            #endif
#else
            let v229 : System.DateTime = System.DateTime.Now
            let _v220 = v229 
            #endif
            let v230 : System.DateTime = _v220 
            v230
        | US2_0(v144) -> (* Some *)
            let v145 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v146 : System.DateTime = System.DateTime.Now
            let _v145 = v146 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v147 : System.DateTime = System.DateTime.Now
            let _v145 = v147 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v148 : System.DateTime = null |> unbox<System.DateTime>
            let _v145 = v148 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v151 : System.DateTime = System.DateTime.Now
            let _v145 = v151 
            #endif
#if FABLE_COMPILER_PYTHON
            let v152 : System.DateTime = System.DateTime.Now
            let _v145 = v152 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v153 : System.DateTime = System.DateTime.Now
            let _v145 = v153 
            #endif
#else
            let v154 : System.DateTime = System.DateTime.Now
            let _v145 = v154 
            #endif
            let v155 : System.DateTime = _v145 
            let v160 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v161 : (System.DateTime -> int64) = _.Ticks
            let v162 : int64 = v161 v155
            let _v160 = v162 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v163 : (System.DateTime -> int64) = _.Ticks
            let v164 : int64 = v163 v155
            let _v160 = v164 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v165 : int64 = null |> unbox<int64>
            let _v160 = v165 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v168 : (System.DateTime -> int64) = _.Ticks
            let v169 : int64 = v168 v155
            let _v160 = v169 
            #endif
#if FABLE_COMPILER_PYTHON
            let v170 : (System.DateTime -> int64) = _.Ticks
            let v171 : int64 = v170 v155
            let _v160 = v171 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v172 : (System.DateTime -> int64) = _.Ticks
            let v173 : int64 = v172 v155
            let _v160 = v173 
            #endif
#else
            let v174 : (System.DateTime -> int64) = _.Ticks
            let v175 : int64 = v174 v155
            let _v160 = v175 
            #endif
            let v176 : int64 = _v160 
            let v193 : int64 = v176 |> int64 
            let v196 : int64 = v193 - v144
            let v197 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v198 : System.TimeSpan = v197 v196
            let v201 : (System.TimeSpan -> int32) = _.Hours
            let v202 : int32 = v201 v198
            let v205 : (System.TimeSpan -> int32) = _.Minutes
            let v206 : int32 = v205 v198
            let v209 : (System.TimeSpan -> int32) = _.Seconds
            let v210 : int32 = v209 v198
            let v213 : (System.TimeSpan -> int32) = _.Milliseconds
            let v214 : int32 = v213 v198
            let v217 : System.DateTime = System.DateTime (1, 1, 1, v202, v206, v210, v214)
            v217
    let v237 : string = method8()
    let v240 : (string -> string) = v236.ToString
    let v241 : string = v240 v237
    let _v6 = v241 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v247 : string = $"near_sdk::env::block_timestamp()"
    let v248 : uint64 = Fable.Core.RustInterop.emitRustExpr () v247 
    let v249 : (int64 -> US2) = method7()
    let v250 : US2 option = v5 |> Option.map v249 
    let v261 : US2 = US2_1
    let v262 : US2 = v250 |> Option.defaultValue v261 
    let v273 : uint64 =
        match v262 with
        | US2_1 -> (* None *)
            v248
        | US2_0(v266) -> (* Some *)
            let v267 : (int64 -> uint64) = uint64
            let v268 : uint64 = v267 v266
            let v271 : uint64 = v248 - v268
            v271
    let v274 : uint64 = v273 / 1000000000UL
    let v275 : uint64 = v274 % 60UL
    let v276 : uint64 = v274 / 60UL
    let v277 : uint64 = v276 % 60UL
    let v278 : uint64 = v274 / 3600UL
    let v279 : uint64 = v278 % 24UL
    let v280 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v281 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v279, v277, v275) v280 
    let v282 : string = "fable_library_rust::String_::fromString($0)"
    let v283 : string = Fable.Core.RustInterop.emitRustExpr v281 v282 
    let _v6 = v283 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v284 : (int64 -> US2) = method7()
    let v285 : US2 option = v5 |> Option.map v284 
    let v296 : US2 = US2_1
    let v297 : US2 = v285 |> Option.defaultValue v296 
    let v393 : System.DateTime =
        match v297 with
        | US2_1 -> (* None *)
            let v377 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v378 : System.DateTime = System.DateTime.Now
            let _v377 = v378 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v379 : System.DateTime = System.DateTime.Now
            let _v377 = v379 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v380 : System.DateTime = null |> unbox<System.DateTime>
            let _v377 = v380 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v383 : System.DateTime = System.DateTime.Now
            let _v377 = v383 
            #endif
#if FABLE_COMPILER_PYTHON
            let v384 : System.DateTime = System.DateTime.Now
            let _v377 = v384 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v385 : System.DateTime = System.DateTime.Now
            let _v377 = v385 
            #endif
#else
            let v386 : System.DateTime = System.DateTime.Now
            let _v377 = v386 
            #endif
            let v387 : System.DateTime = _v377 
            v387
        | US2_0(v301) -> (* Some *)
            let v302 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v303 : System.DateTime = System.DateTime.Now
            let _v302 = v303 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v304 : System.DateTime = System.DateTime.Now
            let _v302 = v304 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v305 : System.DateTime = null |> unbox<System.DateTime>
            let _v302 = v305 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v308 : System.DateTime = System.DateTime.Now
            let _v302 = v308 
            #endif
#if FABLE_COMPILER_PYTHON
            let v309 : System.DateTime = System.DateTime.Now
            let _v302 = v309 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v310 : System.DateTime = System.DateTime.Now
            let _v302 = v310 
            #endif
#else
            let v311 : System.DateTime = System.DateTime.Now
            let _v302 = v311 
            #endif
            let v312 : System.DateTime = _v302 
            let v317 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v318 : (System.DateTime -> int64) = _.Ticks
            let v319 : int64 = v318 v312
            let _v317 = v319 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v320 : (System.DateTime -> int64) = _.Ticks
            let v321 : int64 = v320 v312
            let _v317 = v321 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v322 : int64 = null |> unbox<int64>
            let _v317 = v322 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v325 : (System.DateTime -> int64) = _.Ticks
            let v326 : int64 = v325 v312
            let _v317 = v326 
            #endif
#if FABLE_COMPILER_PYTHON
            let v327 : (System.DateTime -> int64) = _.Ticks
            let v328 : int64 = v327 v312
            let _v317 = v328 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v329 : (System.DateTime -> int64) = _.Ticks
            let v330 : int64 = v329 v312
            let _v317 = v330 
            #endif
#else
            let v331 : (System.DateTime -> int64) = _.Ticks
            let v332 : int64 = v331 v312
            let _v317 = v332 
            #endif
            let v333 : int64 = _v317 
            let v350 : int64 = v333 |> int64 
            let v353 : int64 = v350 - v301
            let v354 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v355 : System.TimeSpan = v354 v353
            let v358 : (System.TimeSpan -> int32) = _.Hours
            let v359 : int32 = v358 v355
            let v362 : (System.TimeSpan -> int32) = _.Minutes
            let v363 : int32 = v362 v355
            let v366 : (System.TimeSpan -> int32) = _.Seconds
            let v367 : int32 = v366 v355
            let v370 : (System.TimeSpan -> int32) = _.Milliseconds
            let v371 : int32 = v370 v355
            let v374 : System.DateTime = System.DateTime (1, 1, 1, v359, v363, v367, v371)
            v374
    let v394 : string = method9()
    let v397 : (string -> string) = v393.ToString
    let v398 : string = v397 v394
    let _v6 = v398 
    #endif
#if FABLE_COMPILER_PYTHON
    let v404 : (int64 -> US2) = method7()
    let v405 : US2 option = v5 |> Option.map v404 
    let v416 : US2 = US2_1
    let v417 : US2 = v405 |> Option.defaultValue v416 
    let v513 : System.DateTime =
        match v417 with
        | US2_1 -> (* None *)
            let v497 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v498 : System.DateTime = System.DateTime.Now
            let _v497 = v498 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v499 : System.DateTime = System.DateTime.Now
            let _v497 = v499 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v500 : System.DateTime = null |> unbox<System.DateTime>
            let _v497 = v500 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v503 : System.DateTime = System.DateTime.Now
            let _v497 = v503 
            #endif
#if FABLE_COMPILER_PYTHON
            let v504 : System.DateTime = System.DateTime.Now
            let _v497 = v504 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v505 : System.DateTime = System.DateTime.Now
            let _v497 = v505 
            #endif
#else
            let v506 : System.DateTime = System.DateTime.Now
            let _v497 = v506 
            #endif
            let v507 : System.DateTime = _v497 
            v507
        | US2_0(v421) -> (* Some *)
            let v422 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v423 : System.DateTime = System.DateTime.Now
            let _v422 = v423 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v424 : System.DateTime = System.DateTime.Now
            let _v422 = v424 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v425 : System.DateTime = null |> unbox<System.DateTime>
            let _v422 = v425 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v428 : System.DateTime = System.DateTime.Now
            let _v422 = v428 
            #endif
#if FABLE_COMPILER_PYTHON
            let v429 : System.DateTime = System.DateTime.Now
            let _v422 = v429 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v430 : System.DateTime = System.DateTime.Now
            let _v422 = v430 
            #endif
#else
            let v431 : System.DateTime = System.DateTime.Now
            let _v422 = v431 
            #endif
            let v432 : System.DateTime = _v422 
            let v437 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v438 : (System.DateTime -> int64) = _.Ticks
            let v439 : int64 = v438 v432
            let _v437 = v439 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v440 : (System.DateTime -> int64) = _.Ticks
            let v441 : int64 = v440 v432
            let _v437 = v441 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v442 : int64 = null |> unbox<int64>
            let _v437 = v442 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v445 : (System.DateTime -> int64) = _.Ticks
            let v446 : int64 = v445 v432
            let _v437 = v446 
            #endif
#if FABLE_COMPILER_PYTHON
            let v447 : (System.DateTime -> int64) = _.Ticks
            let v448 : int64 = v447 v432
            let _v437 = v448 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v449 : (System.DateTime -> int64) = _.Ticks
            let v450 : int64 = v449 v432
            let _v437 = v450 
            #endif
#else
            let v451 : (System.DateTime -> int64) = _.Ticks
            let v452 : int64 = v451 v432
            let _v437 = v452 
            #endif
            let v453 : int64 = _v437 
            let v470 : int64 = v453 |> int64 
            let v473 : int64 = v470 - v421
            let v474 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v475 : System.TimeSpan = v474 v473
            let v478 : (System.TimeSpan -> int32) = _.Hours
            let v479 : int32 = v478 v475
            let v482 : (System.TimeSpan -> int32) = _.Minutes
            let v483 : int32 = v482 v475
            let v486 : (System.TimeSpan -> int32) = _.Seconds
            let v487 : int32 = v486 v475
            let v490 : (System.TimeSpan -> int32) = _.Milliseconds
            let v491 : int32 = v490 v475
            let v494 : System.DateTime = System.DateTime (1, 1, 1, v479, v483, v487, v491)
            v494
    let v514 : string = method9()
    let v517 : (string -> string) = v513.ToString
    let v518 : string = v517 v514
    let _v6 = v518 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v524 : (int64 -> US2) = method7()
    let v525 : US2 option = v5 |> Option.map v524 
    let v536 : US2 = US2_1
    let v537 : US2 = v525 |> Option.defaultValue v536 
    let v633 : System.DateTime =
        match v537 with
        | US2_1 -> (* None *)
            let v617 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v618 : System.DateTime = System.DateTime.Now
            let _v617 = v618 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v619 : System.DateTime = System.DateTime.Now
            let _v617 = v619 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v620 : System.DateTime = null |> unbox<System.DateTime>
            let _v617 = v620 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v623 : System.DateTime = System.DateTime.Now
            let _v617 = v623 
            #endif
#if FABLE_COMPILER_PYTHON
            let v624 : System.DateTime = System.DateTime.Now
            let _v617 = v624 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v625 : System.DateTime = System.DateTime.Now
            let _v617 = v625 
            #endif
#else
            let v626 : System.DateTime = System.DateTime.Now
            let _v617 = v626 
            #endif
            let v627 : System.DateTime = _v617 
            v627
        | US2_0(v541) -> (* Some *)
            let v542 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v543 : System.DateTime = System.DateTime.Now
            let _v542 = v543 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v544 : System.DateTime = System.DateTime.Now
            let _v542 = v544 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v545 : System.DateTime = null |> unbox<System.DateTime>
            let _v542 = v545 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v548 : System.DateTime = System.DateTime.Now
            let _v542 = v548 
            #endif
#if FABLE_COMPILER_PYTHON
            let v549 : System.DateTime = System.DateTime.Now
            let _v542 = v549 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v550 : System.DateTime = System.DateTime.Now
            let _v542 = v550 
            #endif
#else
            let v551 : System.DateTime = System.DateTime.Now
            let _v542 = v551 
            #endif
            let v552 : System.DateTime = _v542 
            let v557 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v558 : (System.DateTime -> int64) = _.Ticks
            let v559 : int64 = v558 v552
            let _v557 = v559 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v560 : (System.DateTime -> int64) = _.Ticks
            let v561 : int64 = v560 v552
            let _v557 = v561 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v562 : int64 = null |> unbox<int64>
            let _v557 = v562 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v565 : (System.DateTime -> int64) = _.Ticks
            let v566 : int64 = v565 v552
            let _v557 = v566 
            #endif
#if FABLE_COMPILER_PYTHON
            let v567 : (System.DateTime -> int64) = _.Ticks
            let v568 : int64 = v567 v552
            let _v557 = v568 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v569 : (System.DateTime -> int64) = _.Ticks
            let v570 : int64 = v569 v552
            let _v557 = v570 
            #endif
#else
            let v571 : (System.DateTime -> int64) = _.Ticks
            let v572 : int64 = v571 v552
            let _v557 = v572 
            #endif
            let v573 : int64 = _v557 
            let v590 : int64 = v573 |> int64 
            let v593 : int64 = v590 - v541
            let v594 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v595 : System.TimeSpan = v594 v593
            let v598 : (System.TimeSpan -> int32) = _.Hours
            let v599 : int32 = v598 v595
            let v602 : (System.TimeSpan -> int32) = _.Minutes
            let v603 : int32 = v602 v595
            let v606 : (System.TimeSpan -> int32) = _.Seconds
            let v607 : int32 = v606 v595
            let v610 : (System.TimeSpan -> int32) = _.Milliseconds
            let v611 : int32 = v610 v595
            let v614 : System.DateTime = System.DateTime (1, 1, 1, v599, v603, v607, v611)
            v614
    let v634 : string = method9()
    let v637 : (string -> string) = v633.ToString
    let v638 : string = v637 v634
    let _v6 = v638 
    #endif
#else
    let v644 : (int64 -> US2) = method7()
    let v645 : US2 option = v5 |> Option.map v644 
    let v656 : US2 = US2_1
    let v657 : US2 = v645 |> Option.defaultValue v656 
    let v753 : System.DateTime =
        match v657 with
        | US2_1 -> (* None *)
            let v737 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v738 : System.DateTime = System.DateTime.Now
            let _v737 = v738 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v739 : System.DateTime = System.DateTime.Now
            let _v737 = v739 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v740 : System.DateTime = null |> unbox<System.DateTime>
            let _v737 = v740 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v743 : System.DateTime = System.DateTime.Now
            let _v737 = v743 
            #endif
#if FABLE_COMPILER_PYTHON
            let v744 : System.DateTime = System.DateTime.Now
            let _v737 = v744 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v745 : System.DateTime = System.DateTime.Now
            let _v737 = v745 
            #endif
#else
            let v746 : System.DateTime = System.DateTime.Now
            let _v737 = v746 
            #endif
            let v747 : System.DateTime = _v737 
            v747
        | US2_0(v661) -> (* Some *)
            let v662 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v663 : System.DateTime = System.DateTime.Now
            let _v662 = v663 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v664 : System.DateTime = System.DateTime.Now
            let _v662 = v664 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v665 : System.DateTime = null |> unbox<System.DateTime>
            let _v662 = v665 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v668 : System.DateTime = System.DateTime.Now
            let _v662 = v668 
            #endif
#if FABLE_COMPILER_PYTHON
            let v669 : System.DateTime = System.DateTime.Now
            let _v662 = v669 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v670 : System.DateTime = System.DateTime.Now
            let _v662 = v670 
            #endif
#else
            let v671 : System.DateTime = System.DateTime.Now
            let _v662 = v671 
            #endif
            let v672 : System.DateTime = _v662 
            let v677 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v678 : (System.DateTime -> int64) = _.Ticks
            let v679 : int64 = v678 v672
            let _v677 = v679 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v680 : (System.DateTime -> int64) = _.Ticks
            let v681 : int64 = v680 v672
            let _v677 = v681 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v682 : int64 = null |> unbox<int64>
            let _v677 = v682 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v685 : (System.DateTime -> int64) = _.Ticks
            let v686 : int64 = v685 v672
            let _v677 = v686 
            #endif
#if FABLE_COMPILER_PYTHON
            let v687 : (System.DateTime -> int64) = _.Ticks
            let v688 : int64 = v687 v672
            let _v677 = v688 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v689 : (System.DateTime -> int64) = _.Ticks
            let v690 : int64 = v689 v672
            let _v677 = v690 
            #endif
#else
            let v691 : (System.DateTime -> int64) = _.Ticks
            let v692 : int64 = v691 v672
            let _v677 = v692 
            #endif
            let v693 : int64 = _v677 
            let v710 : int64 = v693 |> int64 
            let v713 : int64 = v710 - v661
            let v714 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v715 : System.TimeSpan = v714 v713
            let v718 : (System.TimeSpan -> int32) = _.Hours
            let v719 : int32 = v718 v715
            let v722 : (System.TimeSpan -> int32) = _.Minutes
            let v723 : int32 = v722 v715
            let v726 : (System.TimeSpan -> int32) = _.Seconds
            let v727 : int32 = v726 v715
            let v730 : (System.TimeSpan -> int32) = _.Milliseconds
            let v731 : int32 = v730 v715
            let v734 : System.DateTime = System.DateTime (1, 1, 1, v719, v723, v727, v731)
            v734
    let v754 : string = method9()
    let v757 : (string -> string) = v753.ToString
    let v758 : string = v757 v754
    let _v6 = v758 
    #endif
    let v764 : string = _v6 
    v764
and method12 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method11 (v0 : char) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 (v0 : US0) : string =
    
    
    
    
    
    let v1 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v5 : US5 =
        if v1 then
            let v2 : string = "Verbose"
            US5_0(v2)
        else
            US5_1
    let v46 : US5 =
        match v5 with
        | US5_1 -> (* None *)
            let v8 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v12 : US5 =
                if v8 then
                    let v9 : string = "Debug"
                    US5_0(v9)
                else
                    US5_1
            match v12 with
            | US5_1 -> (* None *)
                let v15 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v19 : US5 =
                    if v15 then
                        let v16 : string = "Info"
                        US5_0(v16)
                    else
                        US5_1
                match v19 with
                | US5_1 -> (* None *)
                    let v22 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v26 : US5 =
                        if v22 then
                            let v23 : string = "Warning"
                            US5_0(v23)
                        else
                            US5_1
                    match v26 with
                    | US5_1 -> (* None *)
                        let v29 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v33 : US5 =
                            if v29 then
                                let v30 : string = "Critical"
                                US5_0(v30)
                            else
                                US5_1
                        match v33 with
                        | US5_1 -> (* None *)
                            US5_1
                        | US5_0(v34) -> (* Some *)
                            US5_0(v34)
                    | US5_0(v27) -> (* Some *)
                        US5_0(v27)
                | US5_0(v20) -> (* Some *)
                    US5_0(v20)
            | US5_0(v13) -> (* Some *)
                US5_0(v13)
        | US5_0(v6) -> (* Some *)
            US5_0(v6)
    let v50 : string =
        match v46 with
        | US5_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US5_0(v47) -> (* Some *)
            v47
    let v51 : (unit -> string) = v50.ToLower
    let v52 : string = v51 ()
    let v55 : char = v52.[int 0]
    let v56 : string = method11(v55)
    let v57 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v72 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v66 : string = "inline_colorization::color_bright_red"
            let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
            v67
        | US0_1 -> (* Debug *)
            let v60 : string = "inline_colorization::color_bright_blue"
            let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
            v61
        | US0_2 -> (* Info *)
            let v62 : string = "inline_colorization::color_bright_green"
            let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v62 
            v63
        | US0_0 -> (* Verbose *)
            let v58 : string = "inline_colorization::color_bright_black"
            let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v58 
            v59
        | US0_3 -> (* Warning *)
            let v64 : string = "inline_colorization::color_yellow"
            let v65 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v64 
            v65
    let v73 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v74 : string = "&*$0"
    let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v74 
    let _v73 = v75 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v76 
    let _v73 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v78 
    let _v73 = v79 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v80 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v80 
    #endif
#if FABLE_COMPILER_PYTHON
    let v83 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v83 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v86 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v86 
    #endif
#else
    let v89 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v73 = v89 
    #endif
    let v92 : Ref<Str> = _v73 
    let v97 : string = "inline_colorization::color_reset"
    let v98 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v72, v92, v98) v99 
    let v101 : string = "fable_library_rust::String_::fromString($0)"
    let v102 : string = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let _v57 = v102 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v117 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v111 : string = "inline_colorization::color_bright_red"
            let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v111 
            v112
        | US0_1 -> (* Debug *)
            let v105 : string = "inline_colorization::color_bright_blue"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105 
            v106
        | US0_2 -> (* Info *)
            let v107 : string = "inline_colorization::color_bright_green"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107 
            v108
        | US0_0 -> (* Verbose *)
            let v103 : string = "inline_colorization::color_bright_black"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103 
            v104
        | US0_3 -> (* Warning *)
            let v109 : string = "inline_colorization::color_yellow"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109 
            v110
    let v118 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v119 : string = "&*$0"
    let v120 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v119 
    let _v118 = v120 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v121 : string = "&*$0"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v121 
    let _v118 = v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v123 
    let _v118 = v124 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v125 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v125 
    #endif
#if FABLE_COMPILER_PYTHON
    let v128 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v128 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v131 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v131 
    #endif
#else
    let v134 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v118 = v134 
    #endif
    let v137 : Ref<Str> = _v118 
    let v142 : string = "inline_colorization::color_reset"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v142 
    let v144 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v117, v137, v143) v144 
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146 
    let _v57 = v147 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v162 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v156 : string = "inline_colorization::color_bright_red"
            let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v156 
            v157
        | US0_1 -> (* Debug *)
            let v150 : string = "inline_colorization::color_bright_blue"
            let v151 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v150 
            v151
        | US0_2 -> (* Info *)
            let v152 : string = "inline_colorization::color_bright_green"
            let v153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v152 
            v153
        | US0_0 -> (* Verbose *)
            let v148 : string = "inline_colorization::color_bright_black"
            let v149 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v148 
            v149
        | US0_3 -> (* Warning *)
            let v154 : string = "inline_colorization::color_yellow"
            let v155 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v154 
            v155
    let v163 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v164 : string = "&*$0"
    let v165 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v164 
    let _v163 = v165 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v166 : string = "&*$0"
    let v167 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v166 
    let _v163 = v167 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v168 : string = "&*$0"
    let v169 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v56 v168 
    let _v163 = v169 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v170 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v170 
    #endif
#if FABLE_COMPILER_PYTHON
    let v173 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v173 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v176 
    #endif
#else
    let v179 : Ref<Str> = v56 |> unbox<Ref<Str>>
    let _v163 = v179 
    #endif
    let v182 : Ref<Str> = _v163 
    let v187 : string = "inline_colorization::color_reset"
    let v188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v187 
    let v189 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v190 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v162, v182, v188) v189 
    let v191 : string = "fable_library_rust::String_::fromString($0)"
    let v192 : string = Fable.Core.RustInterop.emitRustExpr v190 v191 
    let _v57 = v192 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v202 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v197 : string = "\u001b[91m"
            v197
        | US0_1 -> (* Debug *)
            let v194 : string = "\u001b[94m"
            v194
        | US0_2 -> (* Info *)
            let v195 : string = "\u001b[92m"
            v195
        | US0_0 -> (* Verbose *)
            let v193 : string = "\u001b[90m"
            v193
        | US0_3 -> (* Warning *)
            let v196 : string = "\u001b[93m"
            v196
    let v203 : string = method13()
    let v204 : string = v202 + v56 
    let v205 : string = v204 + v203 
    let _v57 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v215 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v210 : string = "\u001b[91m"
            v210
        | US0_1 -> (* Debug *)
            let v207 : string = "\u001b[94m"
            v207
        | US0_2 -> (* Info *)
            let v208 : string = "\u001b[92m"
            v208
        | US0_0 -> (* Verbose *)
            let v206 : string = "\u001b[90m"
            v206
        | US0_3 -> (* Warning *)
            let v209 : string = "\u001b[93m"
            v209
    let v216 : string = method13()
    let v217 : string = v215 + v56 
    let v218 : string = v217 + v216 
    let _v57 = v218 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v228 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v223 : string = "\u001b[91m"
            v223
        | US0_1 -> (* Debug *)
            let v220 : string = "\u001b[94m"
            v220
        | US0_2 -> (* Info *)
            let v221 : string = "\u001b[92m"
            v221
        | US0_0 -> (* Verbose *)
            let v219 : string = "\u001b[90m"
            v219
        | US0_3 -> (* Warning *)
            let v222 : string = "\u001b[93m"
            v222
    let v229 : string = method13()
    let v230 : string = v228 + v56 
    let v231 : string = v230 + v229 
    let _v57 = v231 
    #endif
#else
    let v241 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v236 : string = "\u001b[91m"
            v236
        | US0_1 -> (* Debug *)
            let v233 : string = "\u001b[94m"
            v233
        | US0_2 -> (* Info *)
            let v234 : string = "\u001b[92m"
            v234
        | US0_0 -> (* Verbose *)
            let v232 : string = "\u001b[90m"
            v232
        | US0_3 -> (* Warning *)
            let v235 : string = "\u001b[93m"
            v235
    let v242 : string = method13()
    let v243 : string = v241 + v56 
    let v244 : string = v243 + v242 
    let _v57 = v244 
    #endif
    let v245 : string = _v57 
    v245
and method15 (v0 : string) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method16 (v0 : string) : string =
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
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : string) : string =
    let v10 : string = method15(v9)
    let v11 : int64 = v0.l0
    let v12 : string = $"{v6} {v7} #{v11} %s{v8} / {v10}"
    method16(v12)
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method17 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure9(v17)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : (string -> unit) = closure10()
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
and closure6 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : unit =
    let v3 : bool = method5(v0)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method6(v20, v21, v22, v23, v24, v25)
        let v39 : string = method10(v0)
        let v40 : string = v1 ()
        let v41 : bool = v40 = ""
        let v45 : string =
            if v41 then
                let v42 : string = ""
                v42
            else
                let v43 : string = v2 ()
                method14(v20, v21, v22, v23, v24, v25, v38, v39, v40, v43)
        method17(v45)
and closure5 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure6(v0, v1, v2)
    let v5 : unit = (fun () -> v4 (); v3) ()
    ()
and closure4 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure5(v0, v1)
and closure3 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure4(v0)
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure3()
let trace x = v16 x
()
