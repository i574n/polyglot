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
and method4 () : string =
    let v0 : string = ""
    v0
and closure4 () (v0 : string) : US5 =
    US5_0(v0)
and method5 () : (string -> US5) =
    closure4()
and method3 (v0 : string) : string =
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
    let v14 : string = method4()
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
    let v42 : (string -> US5) = method5()
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
    let v74 : (string -> US5) = method5()
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
and method2 () : struct (US1 * US2) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method3(v0)
    
    
    
    
    
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
    let v49 : string = method3(v48)
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
and closure5 () (v0 : string) : unit =
    ()
and method1 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US1, v3 : US2) = method2()
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
    let struct (v123 : US1, v124 : US2) = method2()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US1, v126 : US2) = method2()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US1, v128 : US2) = method2()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US1, v130 : US2) = method2()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US1, v132 : US2) = _v1 
    let v137 : Mut0 = {l0 = 1L} : Mut0
    let v138 : (string -> unit) = closure5()
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
and closure3 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method1(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method0 (v0 : US0) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
and method7 () : (int64 -> US2) =
    closure6()
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
    let v124 : (int64 -> US2) = method7()
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
    let v234 : string = method8()
    let v237 : (string -> string) = v233.ToString
    let v238 : string = v237 v234
    let _v6 = v238 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v241 : string = $"near_sdk::env::block_timestamp()"
    let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
    let v243 : (int64 -> US2) = method7()
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
    let v278 : (int64 -> US2) = method7()
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
    let v388 : string = method9()
    let v391 : (string -> string) = v387.ToString
    let v392 : string = v391 v388
    let _v6 = v392 
    #endif
#if FABLE_COMPILER_PYTHON
    let v395 : (int64 -> US2) = method7()
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
    let v505 : string = method9()
    let v508 : (string -> string) = v504.ToString
    let v509 : string = v508 v505
    let _v6 = v509 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v512 : (int64 -> US2) = method7()
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
    let v622 : string = method9()
    let v625 : (string -> string) = v621.ToString
    let v626 : string = v625 v622
    let _v6 = v626 
    #endif
#else
    let v629 : (int64 -> US2) = method7()
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
    let v739 : string = method9()
    let v742 : (string -> string) = v738.ToString
    let v743 : string = v742 v739
    let _v6 = v743 
    #endif
    let v746 : string = _v6 
    v746
and method12 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method11 (v0 : char) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure7(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method13 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method11(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_blue"
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
    let v40 : string = "inline_colorization::color_bright_blue"
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
    let v72 : string = "inline_colorization::color_bright_blue"
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
    let v104 : string = "\u001b[94m"
    let v105 : string = method13()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method13()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method13()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method13()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method15 (v0 : std_string_String, v1 : uint64, v2 : std_string_String, v3 : std_string_String) : string =
    let v4 : string = method12()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : string = "{ "
    let v7 : string = $"{v6}"
    let v10 : unit = ()
    let v11 : (unit -> unit) = closure7(v5, v7)
    let v12 : unit = (fun () -> v11 (); v10) ()
    let v15 : string = "alias"
    let v16 : string = $"{v15}"
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure7(v5, v16)
    let v21 : unit = (fun () -> v20 (); v19) ()
    let v24 : string = " = "
    let v25 : string = $"{v24}"
    let v28 : unit = ()
    let v29 : (unit -> unit) = closure7(v5, v25)
    let v30 : unit = (fun () -> v29 (); v28) ()
    let v33 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = "format!(\"{:#?}\", $0)"
    let v35 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v34 
    let v36 : string = "fable_library_rust::String_::fromString($0)"
    let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let _v33 = v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "format!(\"{:#?}\", $0)"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let _v33 = v41 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v42 : string = "format!(\"{:#?}\", $0)"
    let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v42 
    let v44 : string = "fable_library_rust::String_::fromString($0)"
    let v45 : string = Fable.Core.RustInterop.emitRustExpr v43 v44 
    let _v33 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : string = $"%A{v0}"
    let _v33 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v33 = v49 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v52 : string = $"%A{v0}"
    let _v33 = v52 
    #endif
#else
    let v55 : string = $"%A{v0}"
    let _v33 = v55 
    #endif
    let v58 : string = _v33 
    let v63 : string = $"{v58}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure7(v5, v63)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v71 : string = "; "
    let v72 : string = $"{v71}"
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure7(v5, v72)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v80 : string = "block_timestamp"
    let v81 : string = $"{v80}"
    let v84 : unit = ()
    let v85 : (unit -> unit) = closure7(v5, v81)
    let v86 : unit = (fun () -> v85 (); v84) ()
    let v89 : string = $"{v24}"
    let v92 : unit = ()
    let v93 : (unit -> unit) = closure7(v5, v89)
    let v94 : unit = (fun () -> v93 (); v92) ()
    let v97 : string = $"{v1}"
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure7(v5, v97)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v105 : string = $"{v71}"
    let v108 : unit = ()
    let v109 : (unit -> unit) = closure7(v5, v105)
    let v110 : unit = (fun () -> v109 (); v108) ()
    let v113 : string = "signer_account_id"
    let v114 : string = $"{v113}"
    let v117 : unit = ()
    let v118 : (unit -> unit) = closure7(v5, v114)
    let v119 : unit = (fun () -> v118 (); v117) ()
    let v122 : string = $"{v24}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure7(v5, v122)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v130 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v131 : string = "format!(\"{:#?}\", $0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v131 
    let v133 : string = "fable_library_rust::String_::fromString($0)"
    let v134 : string = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let _v130 = v134 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v135 : string = "format!(\"{:#?}\", $0)"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v135 
    let v137 : string = "fable_library_rust::String_::fromString($0)"
    let v138 : string = Fable.Core.RustInterop.emitRustExpr v136 v137 
    let _v130 = v138 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v139 : string = "format!(\"{:#?}\", $0)"
    let v140 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v139 
    let v141 : string = "fable_library_rust::String_::fromString($0)"
    let v142 : string = Fable.Core.RustInterop.emitRustExpr v140 v141 
    let _v130 = v142 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v143 : string = $"%A{v2}"
    let _v130 = v143 
    #endif
#if FABLE_COMPILER_PYTHON
    let v146 : string = $"%A{v2}"
    let _v130 = v146 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v149 : string = $"%A{v2}"
    let _v130 = v149 
    #endif
#else
    let v152 : string = $"%A{v2}"
    let _v130 = v152 
    #endif
    let v155 : string = _v130 
    let v160 : string = $"{v155}"
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure7(v5, v160)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v168 : string = $"{v71}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure7(v5, v168)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v176 : string = "predecessor_account_id"
    let v177 : string = $"{v176}"
    let v180 : unit = ()
    let v181 : (unit -> unit) = closure7(v5, v177)
    let v182 : unit = (fun () -> v181 (); v180) ()
    let v185 : string = $"{v24}"
    let v188 : unit = ()
    let v189 : (unit -> unit) = closure7(v5, v185)
    let v190 : unit = (fun () -> v189 (); v188) ()
    let v193 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v194 : string = "format!(\"{:#?}\", $0)"
    let v195 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v194 
    let v196 : string = "fable_library_rust::String_::fromString($0)"
    let v197 : string = Fable.Core.RustInterop.emitRustExpr v195 v196 
    let _v193 = v197 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v198 : string = "format!(\"{:#?}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v198 
    let v200 : string = "fable_library_rust::String_::fromString($0)"
    let v201 : string = Fable.Core.RustInterop.emitRustExpr v199 v200 
    let _v193 = v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = "format!(\"{:#?}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v202 
    let v204 : string = "fable_library_rust::String_::fromString($0)"
    let v205 : string = Fable.Core.RustInterop.emitRustExpr v203 v204 
    let _v193 = v205 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v206 : string = $"%A{v3}"
    let _v193 = v206 
    #endif
#if FABLE_COMPILER_PYTHON
    let v209 : string = $"%A{v3}"
    let _v193 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v212 : string = $"%A{v3}"
    let _v193 = v212 
    #endif
#else
    let v215 : string = $"%A{v3}"
    let _v193 = v215 
    #endif
    let v218 : string = _v193 
    let v223 : string = $"{v218}"
    let v226 : unit = ()
    let v227 : (unit -> unit) = closure7(v5, v223)
    let v228 : unit = (fun () -> v227 (); v226) ()
    let v231 : string = " }"
    let v232 : string = $"{v231}"
    let v235 : unit = ()
    let v236 : (unit -> unit) = closure7(v5, v232)
    let v237 : unit = (fun () -> v236 (); v235) ()
    let v240 : string = v5.l0
    v240
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
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String, v9 : uint64, v10 : std_string_String, v11 : std_string_String) : string =
    let v12 : string = method15(v8, v9, v10, v11)
    let v13 : int64 = v0.l0
    let v14 : string = "chat_contract.claim_alias"
    let v15 : string = $"{v6} {v7} #{v13} %s{v14} / {v12}"
    method16(v15)
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
and method17 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure3()
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
and closure2 (v0 : std_string_String, v1 : near_sdk_AccountId, v2 : near_sdk_AccountId, v3 : uint64) () : unit =
    let v4 : US0 = US0_1
    let v5 : bool = method0(v4)
    if v5 then
        let v6 : unit = ()
        let v7 : (unit -> unit) = closure3()
        let v8 : unit = (fun () -> v7 (); v6) ()
        let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : Mut4, v27 : int64 option) = TraceState.trace_state.Value
        let v40 : string = method6(v22, v23, v24, v25, v26, v27)
        let v41 : string = method10()
        let v42 : string = $"v1.to_string()"
        let v43 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v42 
        let v44 : string = $"v2.to_string()"
        let v45 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v44 
        let v46 : string = method14(v22, v23, v24, v25, v26, v27, v40, v41, v0, v3, v43, v45)
        method17(v46)
and closure11 () (v0 : std_string_String) : US6 =
    US6_0(v0)
and method18 () : (std_string_String -> US6) =
    closure11()
and method19 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method11(v5)
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
    let v105 : string = method13()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method13()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method13()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method13()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method21 (v0 : string) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "account_alias"
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
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method21(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "chat_contract.claim_alias / alias already claimed"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method16(v12)
and closure12 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method19()
        let v39 : string = $"%A{v0}"
        let v42 : string = method20(v19, v20, v21, v22, v23, v24, v37, v38, v39)
        method17(v42)
and method22 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method21(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "chat_contract.claim_alias"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method16(v12)
and closure13 (v0 : std_string_String option) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method10()
        let v39 : string = $"%A{v0}"
        let v42 : string = method22(v19, v20, v21, v22, v23, v24, v37, v38, v39)
        method17(v42)
and closure14 () () : unit =
    ()
and method23 () : (unit -> unit) =
    closure14()
and method24 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure3()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v16)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = ""
    let v40 : (string -> unit) = closure9()
    let v41 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v42 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v42 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v43 
    let _v41 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = v19.l0
    let v45 : bool = v44 = ""
    let v53 : string =
        if v45 then
            v39
        else
            let v46 : bool = v39 = ""
            if v46 then
                let v47 : string = v19.l0
                v47
            else
                let v48 : string = v19.l0
                let v49 : string = "\n"
                let v50 : string = v48 + v49 
                let v51 : string = v50 + v39 
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
    let v105 : bool = v39 <> v39 
    let v109 : bool =
        if v105 then
            let v108 : bool = v98 <= 1
            v108
        else
            false
    if v109 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v39
        let v110 : string = "true; $0.into_iter().for_each(|x| { //"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr v95 v110 
        let v112 : string = "x"
        let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v115 : bool = Fable.Core.RustInterop.emitRustExpr v113 v114 
        let v116 : string = $"true"
        let v117 : bool = Fable.Core.RustInterop.emitRustExpr () v116 
        let v118 : string = "true; }); //"
        let v119 : bool = Fable.Core.RustInterop.emitRustExpr () v118 
        ()
    let _v41 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v39
    let _v41 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v39
    let _v41 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v39
    let _v41 = () 
    #endif
#else
    v40 v39
    let _v41 = () 
    #endif
    _v41 
    let v120 : (string -> unit) = v17.l0
    v120 v39
and closure15 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method10()
        method24()
and method26 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) : string =
    let v2 : string = method12()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure7(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "account_id"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure7(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure7(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v32 : string = "format!(\"{:#?}\", $0)"
    let v33 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "fable_library_rust::String_::fromString($0)"
    let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let _v31 = v35 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = "format!(\"{:#?}\", $0)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v31 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "format!(\"{:#?}\", $0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v40 
    let v42 : string = "fable_library_rust::String_::fromString($0)"
    let v43 : string = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let _v31 = v43 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v44 : string = $"%A{v0}"
    let _v31 = v44 
    #endif
#if FABLE_COMPILER_PYTHON
    let v47 : string = $"%A{v0}"
    let _v31 = v47 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v50 : string = $"%A{v0}"
    let _v31 = v50 
    #endif
#else
    let v53 : string = $"%A{v0}"
    let _v31 = v53 
    #endif
    let v56 : string = _v31 
    let v61 : string = $"{v56}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure7(v3, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v69 : string = "; "
    let v70 : string = $"{v69}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure7(v3, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v78 : string = "result"
    let v79 : string = $"{v78}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure7(v3, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v87 : string = $"{v22}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure7(v3, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "format!(\"{:#?}\", $0)"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v96 
    let v98 : string = "fable_library_rust::String_::fromString($0)"
    let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let _v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v95 = v103 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v95 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : string = $"%A{v1}"
    let _v95 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = $"%A{v1}"
    let _v95 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v114 : string = $"%A{v1}"
    let _v95 = v114 
    #endif
#else
    let v117 : string = $"%A{v1}"
    let _v95 = v117 
    #endif
    let v120 : string = _v95 
    let v125 : string = $"{v120}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure7(v3, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = " }"
    let v134 : string = $"{v133}"
    let v137 : unit = ()
    let v138 : (unit -> unit) = closure7(v3, v134)
    let v139 : unit = (fun () -> v138 (); v137) ()
    let v142 : string = v3.l0
    v142
and method25 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : near_sdk_AccountId, v9 : struct (std_string_String * uint64 * uint32) option) : string =
    let v10 : string = method26(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "chat_contract.get_account_info"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method16(v13)
and closure16 (v0 : near_sdk_AccountId, v1 : struct (std_string_String * uint64 * uint32) option) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method0(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure3()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method6(v20, v21, v22, v23, v24, v25)
        let v39 : string = method10()
        let v40 : string = method25(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method17(v40)
and closure17 () () : unit =
    let v0 : US0 = US0_1
    let v1 : bool = method0(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure3()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method6(v18, v19, v20, v21, v22, v23)
        let v37 : string = method10()
        method24()
and method28 (v0 : std_string_String) : string =
    let v1 : string = method12()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "alias"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure7(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure7(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _v30 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _v30 = v52 
    #endif
    let v55 : string = _v30 
    let v60 : string = $"{v55}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure7(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure7(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method27 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : std_string_String) : string =
    let v9 : string = method28(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "chat_contract.get_alias_map"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method16(v12)
and closure18 (v0 : std_string_String) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method10()
        let v39 : string = method27(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method17(v39)
and method29 () : (unit -> unit) =
    closure14()
and closure19 (v0 : (unit -> unit)) () : unit =
    let v1 : US0 = US0_1
    let v2 : bool = method0(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure3()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method10()
        method24()
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
    let v9 : TypeEmit<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>>
    let v12 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "true; /*"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v22 : string = "true; */"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "account_set"
    let v25 : string = "b\"" + v24 + "\""
    let v26 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "near_sdk::store::IterableSet::new(v26)"
    let v28 : near_sdk_store_IterableSet<near_sdk_AccountId> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "alias_set"
    let v30 : string = "b\"" + v29 + "\""
    let v31 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "near_sdk::store::IterableSet::new(v31)"
    let v33 : near_sdk_store_IterableSet<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "account_map"
    let v35 : string = "b\"" + v34 + "\""
    let v36 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "near_sdk::store::LookupMap::new(v36)"
    let v38 : near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "alias_map"
    let v40 : string = "b\"" + v39 + "\""
    let v41 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "near_sdk::store::LookupMap::new(v41)"
    let v43 : near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>> = Fable.Core.RustInterop.emitRustExpr () v42 
    let _result = struct (2u, v28, v33, v38, v43) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v44 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v48 : bool = Fable.Core.RustInterop.emitRustExpr () v47 
    let v49 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v50 : bool = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "fn is_valid_alias(alias: String) -> bool { //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = $"alias"
    let v55 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v54 
    let v56 : string = "fable_library_rust::String_::fromString($0)"
    let v57 : string = Fable.Core.RustInterop.emitRustExpr v55 v56 
    let v58 : int32 = v57.Length
    let v59 : bool = v58 > 0
    let v103 : bool =
        if v59 then
            let v60 : bool = v58 < 64
            if v60 then
                let v61 : string = "-"
                let v62 : bool = v57.StartsWith v61 
                let v65 : bool = v62 = false
                if v65 then
                    let v66 : bool = v57.EndsWith v61 
                    let v67 : bool = v66 = false
                    if v67 then
                        let v68 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v69 : string = "&*$0"
                        let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v69 
                        let _v68 = v70 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v71 : string = "&*$0"
                        let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v71 
                        let _v68 = v72 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v73 : string = "&*$0"
                        let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v57 v73 
                        let _v68 = v74 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v75 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v75 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v78 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v78 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v81 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v81 
                        #endif
#else
                        let v84 : Ref<Str> = v57 |> unbox<Ref<Str>>
                        let _v68 = v84 
                        #endif
                        let v87 : Ref<Str> = _v68 
                        let v92 : string = $"$0.chars()"
                        let v93 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v87 v92 
                        let v94 : string = "true; // 1"
                        let v95 : bool = Fable.Core.RustInterop.emitRustExpr () v94 
                        let v96 : string = "let mut v93 = v93"
                        Fable.Core.RustInterop.emitRustExpr () v96 
                        let v97 : string = $"v93.all(|x| $0(x))"
                        let v98 : (char -> bool) = closure1()
                        let v99 : bool = Fable.Core.RustInterop.emitRustExpr v98 v97 
                        v99
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let _result = v103 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v104 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v105 
    let v106 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy"
    let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
    let v108 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy"
    let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108 
    let v110 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = "pub fn generate_cid( //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "  content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v115 
    let v116 : string = $"content"
    let v117 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr () v116 
    let v118 : string = "  fn encode_u64(value: u64) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v118 
    let v119 : string = "    let mut buffer = unsigned_varint::encode::u64_buffer(); //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "    unsigned_varint::encode::u64(value, &mut buffer).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "  fn sha256_hash(content: &[u8]) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "    let mut hasher: sha2::Sha256 = sha2::Digest::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "    sha2::Digest::update(&mut hasher, content); //"
    Fable.Core.RustInterop.emitRustExpr () v124 
    let v125 : string = "    sha2::Digest::finalize(hasher).to_vec() //"
    Fable.Core.RustInterop.emitRustExpr () v125 
    let v126 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v126 
    let v127 : string = "  let version: u8 = 1; //"
    Fable.Core.RustInterop.emitRustExpr () v127 
    let v128 : string = "  let codec_raw: u64 = 0x55; //"
    Fable.Core.RustInterop.emitRustExpr () v128 
    let v129 : string = "  let codec_bytes = encode_u64(codec_raw); //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "  let hash_result = sha256_hash(&v117); //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = "  let multihash = std::iter::once(0x12) //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = "    .chain(std::iter::once(32)) //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = "    .chain(hash_result.into_iter()) //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = "    .collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "  let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "  let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "result"
    let v138 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v137 
    let _result = v138 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 }") // 2
    let v139 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy"
    let v142 : bool = Fable.Core.RustInterop.emitRustExpr () v141 
    let v143 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr () v143 
    let v145 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "pub fn generate_cid_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "  #[serializer(borsh)] content: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = ") -> String { //"
    Fable.Core.RustInterop.emitRustExpr () v151 
    let v152 : string = "  self.generate_cid(content) //"
    Fable.Core.RustInterop.emitRustExpr () v152 
    let v153 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v153 
    let v154 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v154 
    let v155 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy"
    let v156 : bool = Fable.Core.RustInterop.emitRustExpr () v155 
    let v157 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy"
    let v158 : bool = Fable.Core.RustInterop.emitRustExpr () v157 
    let v159 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v159 
    let v160 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v160 
    let v161 : string = "pub fn claim_alias( //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "  &mut self, //"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v163 
    let v164 : string = ") { //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = $"&mut self.0"
    let v166 : Ref<Mut<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)>> = Fable.Core.RustInterop.emitRustExpr () v165 
    let v167 : string = $"alias"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v167 
    let v169 : string = $"&mut v166.1"
    let v170 : Ref<Mut<near_sdk_store_IterableSet<near_sdk_AccountId>>> = Fable.Core.RustInterop.emitRustExpr () v169 
    let v171 : string = $"&mut v166.2"
    let v172 : Ref<Mut<near_sdk_store_IterableSet<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v171 
    let v173 : string = $"&mut v166.3"
    let v174 : Ref<Mut<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>>> = Fable.Core.RustInterop.emitRustExpr () v173 
    let v175 : string = $"&mut v166.4"
    let v176 : Ref<Mut<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>>> = Fable.Core.RustInterop.emitRustExpr () v175 
    let v177 : string = $"near_sdk::env::signer_account_id()"
    let v178 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v177 
    let v179 : string = $"near_sdk::env::predecessor_account_id()"
    let v180 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v179 
    let v181 : string = $"near_sdk::env::block_timestamp()"
    let v182 : uint64 = Fable.Core.RustInterop.emitRustExpr () v181 
    let v183 : unit = ()
    let v184 : (unit -> unit) = closure2(v168, v178, v180, v182)
    let v185 : unit = (fun () -> v184 (); v183) ()
    let v229 : string = "fable_library_rust::String_::fromString($0)"
    let v230 : string = Fable.Core.RustInterop.emitRustExpr v168 v229 
    let v231 : int32 = v230.Length
    let v232 : bool = v231 > 0
    let v276 : bool =
        if v232 then
            let v233 : bool = v231 < 64
            if v233 then
                let v234 : string = "-"
                let v235 : bool = v230.StartsWith v234 
                let v238 : bool = v235 = false
                if v238 then
                    let v239 : bool = v230.EndsWith v234 
                    let v240 : bool = v239 = false
                    if v240 then
                        let v241 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v242 : string = "&*$0"
                        let v243 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v230 v242 
                        let _v241 = v243 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v244 : string = "&*$0"
                        let v245 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v230 v244 
                        let _v241 = v245 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v246 : string = "&*$0"
                        let v247 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v230 v246 
                        let _v241 = v247 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v248 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v248 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v251 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v251 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v254 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v254 
                        #endif
#else
                        let v257 : Ref<Str> = v230 |> unbox<Ref<Str>>
                        let _v241 = v257 
                        #endif
                        let v260 : Ref<Str> = _v241 
                        let v265 : string = $"$0.chars()"
                        let v266 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v260 v265 
                        let v267 : string = "true; // 1"
                        let v268 : bool = Fable.Core.RustInterop.emitRustExpr () v267 
                        let v269 : string = "let mut v266 = v266"
                        Fable.Core.RustInterop.emitRustExpr () v269 
                        let v270 : string = $"v266.all(|x| $0(x))"
                        let v271 : (char -> bool) = closure1()
                        let v272 : bool = Fable.Core.RustInterop.emitRustExpr v271 v270 
                        v272
                    else
                        false
                else
                    false
            else
                false
        else
            false
    let v277 : bool = v276 = false
    let v281 : bool =
        if v277 then
            let v278 : string = $"true; near_sdk::env::panic_str(&*$0); //"
            let v279 : string = "chat_contract.claim_alias / invalid alias"
            let v280 : bool = Fable.Core.RustInterop.emitRustExpr v279 v278 
            true
        else
            false
    let v282 : string = $"v174.get(&$0)"
    let v283 : Ref<std_string_String> option = Fable.Core.RustInterop.emitRustExpr v178 v282 
    let v284 : string = "$0.cloned()"
    let v285 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v283 v284 
    let v286 : (std_string_String -> US6) = method18()
    let v287 : US6 option = v285 |> Option.map v286 
    let v298 : US6 = US6_1
    let v299 : US6 = v287 |> Option.defaultValue v298 
    match v299 with
    | US6_0(v303) -> (* Some *)
        let v304 : bool = v303 = v168 
        if v304 then
            let v307 : unit = ()
            let v308 : (unit -> unit) = closure12(v303)
            let v309 : unit = (fun () -> v308 (); v307) ()
            ()
        else
            let v352 : unit = ()
            let v353 : (unit -> unit) = closure13(v285)
            let v354 : unit = (fun () -> v353 (); v352) ()
            let v397 : string = "    v176 //"
            Fable.Core.RustInterop.emitRustExpr () v397 
            let v398 : string = "      .get_mut(&v303) //"
            Fable.Core.RustInterop.emitRustExpr () v398 
            let v399 : string = "      .unwrap() //"
            Fable.Core.RustInterop.emitRustExpr () v399 
            let v400 : string = "      .remove(&$0); //"
            Fable.Core.RustInterop.emitRustExpr v178 v400 
            let v401 : string = "  v174.insert($0.clone(), $1.clone()); //"
            Fable.Core.RustInterop.emitRustExpr struct (v178, v168) v401 
            let v402 : string = $"v170.insert($0)"
            let v403 : bool = Fable.Core.RustInterop.emitRustExpr v178 v402 
            let v404 : string = $"v172.insert($0)"
            let v405 : bool = Fable.Core.RustInterop.emitRustExpr v168 v404 
            let v406 : string = "  let new_alias_account_map = match v176.get(&$0) { //"
            Fable.Core.RustInterop.emitRustExpr v168 v406 
            let v407 : string = "    None => { //"
            Fable.Core.RustInterop.emitRustExpr () v407 
            let v408 : string = "      let mut new_map = std::collections::HashMap::new(); //"
            Fable.Core.RustInterop.emitRustExpr () v408 
            let v409 : string = "      new_map.insert($0, ($1, 0u32)); //"
            Fable.Core.RustInterop.emitRustExpr struct (v178, v182) v409 
            let v410 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v410 
            let v411 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v411 
            let v412 : string = "    Some(accounts) => { //"
            Fable.Core.RustInterop.emitRustExpr () v412 
            let v413 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v413 
            let v414 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
            Fable.Core.RustInterop.emitRustExpr () v414 
            let v415 : string = "      let mut new_map = accounts_vec //"
            Fable.Core.RustInterop.emitRustExpr () v415 
            let v416 : string = "        .iter() //"
            Fable.Core.RustInterop.emitRustExpr () v416 
            let v417 : string = "        .enumerate() //"
            Fable.Core.RustInterop.emitRustExpr () v417 
            let v418 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
            Fable.Core.RustInterop.emitRustExpr () v418 
            let v419 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
            Fable.Core.RustInterop.emitRustExpr () v419 
            let v420 : string = "        }) //"
            Fable.Core.RustInterop.emitRustExpr () v420 
            let v421 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
            Fable.Core.RustInterop.emitRustExpr () v421 
            let v422 : string = "      new_map.insert($0, (v182, accounts_vec.len() as u32)); //"
            Fable.Core.RustInterop.emitRustExpr v178 v422 
            let v423 : string = "      new_map //"
            Fable.Core.RustInterop.emitRustExpr () v423 
            let v424 : string = "    } //"
            Fable.Core.RustInterop.emitRustExpr () v424 
            let v425 : string = "  }; //"
            Fable.Core.RustInterop.emitRustExpr () v425 
            let v426 : string = "  v176.insert($0, new_alias_account_map); //"
            Fable.Core.RustInterop.emitRustExpr v168 v426 
            ()
    | _ ->
        let v427 : unit = ()
        let v428 : (unit -> unit) = closure13(v285)
        let v429 : unit = (fun () -> v428 (); v427) ()
        match v299 with
        | US6_1 -> (* None *)
            ()
        let v472 : string = "  v174.insert($0.clone(), $1.clone()); //"
        Fable.Core.RustInterop.emitRustExpr struct (v178, v168) v472 
        let v473 : string = $"v170.insert($0)"
        let v474 : bool = Fable.Core.RustInterop.emitRustExpr v178 v473 
        let v475 : string = $"v172.insert($0)"
        let v476 : bool = Fable.Core.RustInterop.emitRustExpr v168 v475 
        let v477 : string = "  let new_alias_account_map = match v176.get(&$0) { //"
        Fable.Core.RustInterop.emitRustExpr v168 v477 
        let v478 : string = "    None => { //"
        Fable.Core.RustInterop.emitRustExpr () v478 
        let v479 : string = "      let mut new_map = std::collections::HashMap::new(); //"
        Fable.Core.RustInterop.emitRustExpr () v479 
        let v480 : string = "      new_map.insert($0, ($1, 0u32)); //"
        Fable.Core.RustInterop.emitRustExpr struct (v178, v182) v480 
        let v481 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v481 
        let v482 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v482 
        let v483 : string = "    Some(accounts) => { //"
        Fable.Core.RustInterop.emitRustExpr () v483 
        let v484 : string = "      let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v484 
        let v485 : string = "      accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //"
        Fable.Core.RustInterop.emitRustExpr () v485 
        let v486 : string = "      let mut new_map = accounts_vec //"
        Fable.Core.RustInterop.emitRustExpr () v486 
        let v487 : string = "        .iter() //"
        Fable.Core.RustInterop.emitRustExpr () v487 
        let v488 : string = "        .enumerate() //"
        Fable.Core.RustInterop.emitRustExpr () v488 
        let v489 : string = "        .map(|(i, (signer_account_id, (timestamp, _)))| { //"
        Fable.Core.RustInterop.emitRustExpr () v489 
        let v490 : string = "          ((*signer_account_id).clone(), (*timestamp, i as u32)) //"
        Fable.Core.RustInterop.emitRustExpr () v490 
        let v491 : string = "        }) //"
        Fable.Core.RustInterop.emitRustExpr () v491 
        let v492 : string = "        .collect::<std::collections::HashMap<_, _>>(); //"
        Fable.Core.RustInterop.emitRustExpr () v492 
        let v493 : string = "      new_map.insert($0, (v182, accounts_vec.len() as u32)); //"
        Fable.Core.RustInterop.emitRustExpr v178 v493 
        let v494 : string = "      new_map //"
        Fable.Core.RustInterop.emitRustExpr () v494 
        let v495 : string = "    } //"
        Fable.Core.RustInterop.emitRustExpr () v495 
        let v496 : string = "  }; //"
        Fable.Core.RustInterop.emitRustExpr () v496 
        let v497 : string = "  v176.insert($0, new_alias_account_map); //"
        Fable.Core.RustInterop.emitRustExpr v168 v497 
        ()
    let v498 : (unit -> unit) = method23()
    let v499 : unit = ()
    let v500 : (unit -> unit) = closure15(v498)
    let v501 : unit = (fun () -> v500 (); v499) ()
    let v540 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v540 
    let v541 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v541 
    let v542 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v542 
    let v543 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v543 
    let v544 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy"
    let v545 : bool = Fable.Core.RustInterop.emitRustExpr () v544 
    let v546 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy"
    let v547 : bool = Fable.Core.RustInterop.emitRustExpr () v546 
    let v548 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v548 
    let v549 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v549 
    let v550 : string = "pub fn get_account_info( //"
    Fable.Core.RustInterop.emitRustExpr () v550 
    let v551 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v551 
    let v552 : string = "  account_id: near_sdk::AccountId, //"
    Fable.Core.RustInterop.emitRustExpr () v552 
    let v553 : string = ") -> Option<(String, u64, u32)> { //"
    Fable.Core.RustInterop.emitRustExpr () v553 
    let v554 : string = $"&self.0"
    let v555 : Ref<struct (uint32 * near_sdk_store_IterableSet<near_sdk_AccountId> * near_sdk_store_IterableSet<std_string_String> * near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String> * near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>)> = Fable.Core.RustInterop.emitRustExpr () v554 
    let v556 : string = $"account_id"
    let v557 : near_sdk_AccountId = Fable.Core.RustInterop.emitRustExpr () v556 
    let v558 : string = $"&v555.3"
    let v559 : Ref<near_sdk_store_LookupMap<near_sdk_AccountId, std_string_String>> = Fable.Core.RustInterop.emitRustExpr () v558 
    let v560 : string = $"&v555.4"
    let v561 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v560 
    let v562 : string = "let result = v559.get(&$0).and_then(|alias| { //"
    Fable.Core.RustInterop.emitRustExpr v557 v562 
    let v563 : string = "    v561 //"
    Fable.Core.RustInterop.emitRustExpr () v563 
    let v564 : string = "      .get(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v564 
    let v565 : string = "      .map(|accounts| { //"
    Fable.Core.RustInterop.emitRustExpr () v565 
    let v566 : string = "          let result = (alias.clone(), *accounts.get(&v557).unwrap()); //"
    Fable.Core.RustInterop.emitRustExpr () v566 
    let v567 : string = "          (result.0, result.1.0, result.1.1) //"
    Fable.Core.RustInterop.emitRustExpr () v567 
    let v568 : string = "      }) //"
    Fable.Core.RustInterop.emitRustExpr () v568 
    let v569 : string = "}); //"
    Fable.Core.RustInterop.emitRustExpr () v569 
    let v570 : string = "result"
    let v571 : struct (std_string_String * uint64 * uint32) option = Fable.Core.RustInterop.emitRustExpr () v570 
    let v572 : unit = ()
    let v573 : (unit -> unit) = closure16(v557, v571)
    let v574 : unit = (fun () -> v573 (); v572) ()
    let v614 : unit = ()
    let v615 : (unit -> unit) = closure17()
    let v616 : unit = (fun () -> v615 (); v614) ()
    let _result = v571 in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x "$0 } // 4") // 3
    let v655 : string = "} // 2"
    Fable.Core.RustInterop.emitRustExpr () v655 
    let v656 : string = "} // 1"
    Fable.Core.RustInterop.emitRustExpr () v656 
    let v657 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v657 
    let v658 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy"
    let v659 : bool = Fable.Core.RustInterop.emitRustExpr () v658 
    let v660 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy"
    let v661 : bool = Fable.Core.RustInterop.emitRustExpr () v660 
    let v662 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v662 
    let v663 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v663 
    let v664 : string = "pub fn get_alias_map( //"
    Fable.Core.RustInterop.emitRustExpr () v664 
    let v665 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v665 
    let v666 : string = "  alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v666 
    let v667 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v667 
    let v668 : string = $"&self.0.4"
    let v669 : Ref<near_sdk_store_LookupMap<std_string_String, std_collections_HashMap<near_sdk_AccountId, struct (uint64 * uint32)>>> = Fable.Core.RustInterop.emitRustExpr () v668 
    let v670 : string = $"alias"
    let v671 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v670 
    let v672 : unit = ()
    let v673 : (unit -> unit) = closure18(v671)
    let v674 : unit = (fun () -> v673 (); v672) ()
    let v714 : (unit -> unit) = method29()
    let v715 : unit = ()
    let v716 : (unit -> unit) = closure19(v714)
    let v717 : unit = (fun () -> v716 (); v715) ()
    let v756 : string = "  v669.get(&$0).cloned() //"
    Fable.Core.RustInterop.emitRustExpr v671 v756 
    let v757 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v757 
    let v758 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v758 
    let v759 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v759 
    let v760 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy"
    let v761 : bool = Fable.Core.RustInterop.emitRustExpr () v760 
    let v762 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy"
    let v763 : bool = Fable.Core.RustInterop.emitRustExpr () v762 
    let v764 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v764 
    let v765 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v765 
    let v766 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v766 
    let v767 : string = "pub fn get_alias_map_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v767 
    let v768 : string = "  &self, //"
    Fable.Core.RustInterop.emitRustExpr () v768 
    let v769 : string = "  #[serializer(borsh)] alias: String, //"
    Fable.Core.RustInterop.emitRustExpr () v769 
    let v770 : string = ") -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> { //"
    Fable.Core.RustInterop.emitRustExpr () v770 
    let v771 : string = "  self.get_alias_map(alias) //"
    Fable.Core.RustInterop.emitRustExpr () v771 
    let v772 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v772 
    let v773 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v773 
    let v774 : string = "true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy"
    let v775 : bool = Fable.Core.RustInterop.emitRustExpr () v774 
    let v776 : string = "true; */ // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy"
    let v777 : bool = Fable.Core.RustInterop.emitRustExpr () v776 
    let v778 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v778 
    let v779 : string = "{ { //"
    Fable.Core.RustInterop.emitRustExpr () v779 
    let v780 : string = "true; { (); // ?? / i': 1uy / n: 14uy"
    let v781 : bool = Fable.Core.RustInterop.emitRustExpr () v780 
    let v782 : string = "true; { (); // ?? / i': 2uy / n: 14uy"
    let v783 : bool = Fable.Core.RustInterop.emitRustExpr () v782 
    let v784 : string = "true; { (); // ?? / i': 3uy / n: 14uy"
    let v785 : bool = Fable.Core.RustInterop.emitRustExpr () v784 
    let v786 : string = "true; { (); // ?? / i': 4uy / n: 14uy"
    let v787 : bool = Fable.Core.RustInterop.emitRustExpr () v786 
    let v788 : string = "true; { (); // ?? / i': 5uy / n: 14uy"
    let v789 : bool = Fable.Core.RustInterop.emitRustExpr () v788 
    let v790 : string = "true; { (); // ?? / i': 6uy / n: 14uy"
    let v791 : bool = Fable.Core.RustInterop.emitRustExpr () v790 
    let v792 : string = "true; { (); // ?? / i': 7uy / n: 14uy"
    let v793 : bool = Fable.Core.RustInterop.emitRustExpr () v792 
    let v794 : string = "true; { (); // ?? / i': 8uy / n: 14uy"
    let v795 : bool = Fable.Core.RustInterop.emitRustExpr () v794 
    let v796 : string = "true; { (); // ?? / i': 9uy / n: 14uy"
    let v797 : bool = Fable.Core.RustInterop.emitRustExpr () v796 
    let v798 : string = "true; { (); // ?? / i': 10uy / n: 14uy"
    let v799 : bool = Fable.Core.RustInterop.emitRustExpr () v798 
    let v800 : string = "true; { (); // ?? / i': 11uy / n: 14uy"
    let v801 : bool = Fable.Core.RustInterop.emitRustExpr () v800 
    let v802 : string = "true; { (); // ?? / i': 12uy / n: 14uy"
    let v803 : bool = Fable.Core.RustInterop.emitRustExpr () v802 
    let v804 : string = "true; { (); // ?? / i': 13uy / n: 14uy"
    let v805 : bool = Fable.Core.RustInterop.emitRustExpr () v804 
    let v806 : string = "true; { (); // ?? / i': 14uy / n: 14uy"
    let v807 : bool = Fable.Core.RustInterop.emitRustExpr () v806 
    let v808 : string = "true; { { (); // ? / i': 15uy / n: 14uy"
    let v809 : bool = Fable.Core.RustInterop.emitRustExpr () v808 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
