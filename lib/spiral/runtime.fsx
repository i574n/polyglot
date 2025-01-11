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

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdin")>]
#endif
type std_process_ChildStdin = class end
#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = bool
  type DataReceivedEventArgs = bool
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
    | US6_0 of f0_0 : string * f0_1 : US5
    | US6_1 of f1_0 : string
and [<Struct>] US7 =
    | US7_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US7_1 of f1_0 : string
and Mut5 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and UH1 =
    | UH1_0
    | UH1_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) * UH1
and [<Struct>] US8 =
    | US8_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US8_1 of f1_0 : string
and [<Struct>] US9 =
    | US9_0 of f0_0 : char
    | US9_1
and [<Struct>] US10 =
    | US10_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US10_1 of f1_0 : string
and [<Struct>] US11 =
    | US11_0 of f0_0 : string * f0_1 : US5 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US11_1 of f1_0 : string
and [<Struct>] US12 =
    | US12_0 of f0_0 : US9 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US12_1 of f1_0 : string
and [<Struct>] US13 =
    | US13_0 of f0_0 : US5 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US13_1 of f1_0 : string
and [<Struct>] US14 =
    | US14_0 of f0_0 : (struct (int32 * string * bool) -> Async<unit>)
    | US14_1
and [<Struct>] US15 =
    | US15_0 of f0_0 : System.Threading.CancellationToken
    | US15_1
and Heap0 = {l0 : string; l1 : System.Threading.CancellationToken option; l2 : (struct (string * string) []); l3 : (struct (int32 * string * bool) -> Async<unit>) option; l4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option; l5 : bool; l6 : string option}
and [<Struct>] US16 =
    | US16_0 of f0_0 : (string [])
    | US16_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of string * UH2
and [<Struct>] US17 =
    | US17_0 of f0_0 : UH2 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US17_1 of f1_0 : string
and UH3 =
    | UH3_0
    | UH3_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) * UH3
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
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US2) = method9()
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
    let _run_target_args'_v6 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v139 : (int64 -> US2) = method9()
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
    let _run_target_args'_v6 = v257 
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
    let _run_target_args'_v6 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : (int64 -> US2) = method9()
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
    let _run_target_args'_v6 = v426 
    #endif
#if FABLE_COMPILER_PYTHON
    let v440 : (int64 -> US2) = method9()
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
    let _run_target_args'_v6 = v558 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v572 : (int64 -> US2) = method9()
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
    let _run_target_args'_v6 = v690 
    #endif
#else
    let v704 : (int64 -> US2) = method9()
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
    let _run_target_args'_v6 = v822 
    #endif
    let v836 : string = _run_target_args'_v6 
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
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_yellow"
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
    let v40 : string = "inline_colorization::color_yellow"
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
    let v72 : string = "inline_colorization::color_yellow"
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
    let v104 : string = "\u001b[93m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
and method17 () : string =
    let v0 : string = method14()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
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
and method16 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method17()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 3"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method18(v11)
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
and closure5 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method7(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method8(v18, v19, v20, v21, v22, v23)
        let v37 : string = method12()
        let v38 : string = method16(v18, v19, v20, v21, v22, v23, v36, v37)
        method19(v38)
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method17()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 2"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method18(v11)
and closure11 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method7(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method8(v18, v19, v20, v21, v22, v23)
        let v37 : string = method12()
        let v38 : string = method20(v18, v19, v20, v21, v22, v23, v36, v37)
        method19(v38)
and method21 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method17()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 1"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method18(v11)
and closure12 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method7(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method8(v18, v19, v20, v21, v22, v23)
        let v37 : string = method12()
        let v38 : string = method21(v18, v19, v20, v21, v22, v23, v36, v37)
        method19(v38)
and closure4 () () : unit =
    (* run_target_args'
    let v0 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure5()
    let v3 : unit = (fun () -> v2 (); v1) ()
    System.Threading.Thread.Sleep 300
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure11()
    let v45 : unit = (fun () -> v44 (); v43) ()
    System.Console.Out.Flush ()
    System.Threading.Thread.Sleep 60
    let v85 : unit = ()
    let v86 : (unit -> unit) = closure12()
    let v87 : unit = (fun () -> v86 (); v85) ()
    System.Diagnostics.Process.GetCurrentProcess().Kill ()
    #endif
    // run_target_args' is_unit
    ()
and method6 () : unit =
    (* run_target_args'
    let v0 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v1 : (unit -> unit) = closure4()
    let v2 : System.Threading.Thread = new System.Threading.Thread (v1)
    let v3 : (System.Threading.Thread -> unit) = _.Start()
    v3 v2
    #endif
    // run_target_args' is_unit
    ()
and closure3 () () : unit =
    method6()
and method26 () : string =
    let v0 : string = ""
    v0
and method27 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure16 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure15 () (v0 : char) : (UH0 -> UH0) =
    closure16(v0)
and method28 () : (char -> (UH0 -> UH0)) =
    closure15()
and method29 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
    match v0 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '\n' = v4
        let struct (v9 : int32, v10 : int32) =
            if v6 then
                let v7 : int32 = v2 + 1
                struct (v7, 1)
            else
                let v8 : int32 = v3 + 1
                struct (v2, v8)
        let v24 : System.Text.StringBuilder =
            if v6 then
                let v11 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v12 : System.Text.StringBuilder = v11 ()
                v1
            else
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v4
                let v20 : (string -> System.Text.StringBuilder) = v1.Append
                let v21 : System.Text.StringBuilder = v20 v17
                v1
        method29(v5, v24, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure17 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : bool = v1 >= v0
    if v3 then
        v2
    else
        let v4 : int32 = v1 + 1
        let v5 : (string -> string) = method30(v0, v4)
        let v6 : string = " "
        let v7 : string = v2 + v6 
        v5 v7
and method30 (v0 : int32, v1 : int32) : (string -> string) =
    closure17(v0, v1)
and closure14 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US7 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v1, v2, v3)}"
        US7_1(v5)
    else
        let v9 : char = v0.[int 0]
        let v10 : bool = v9 = '"'
        if v10 then
            let v11 : (string -> int32) = String.length
            let v12 : int32 = v11 v0
            let v15 : int32 = 1 |> int32 
            let v22 : int32 = v12 |> int32 
            let v29 : int32 = v22 - 1
            let v30 : string = v0.[int v15..int v29]
            let v34 : (char -> string) = _.ToString()
            let v35 : string = v34 v9
            let v38 : int32 = v35.Length
            let v39 : (char []) = Array.zeroCreate<char> (v38)
            let v40 : Mut5 = {l0 = 0} : Mut5
            while method27(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method28()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method29(v53, v1, v2, v3)
            US7_0(v9, v30, v75, v76, v77)
        else
            let v79 : string = "\n"
            let v80 : int32 = v0.IndexOf v79 
            let v83 : int32 = v80 - 1
            let v84 : bool = -2 = v83
            let v91 : int32 =
                if v84 then
                    let v85 : (string -> int32) = String.length
                    let v86 : int32 = v85 v0
                    let v89 : int32 = v86 + 1
                    v89
                else
                    let v90 : int32 = v83 + 1
                    v90
            let v92 : int32 = 0 |> int32 
            let v99 : int32 = v91 |> int32 
            let v106 : int32 = v99 - 1
            let v107 : string = v0.[int v92..int v106]
            let v111 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v107}"
            let v114 : int32 = v3 - 1
            let v115 : int32 = 0
            let v116 : (string -> string) = method30(v114, v115)
            let v117 : string = ""
            let v118 : string = v116 v117
            let v119 : string = "^"
            let v120 : string = v118 + v119 
            let v121 : string = $"{v111}
{v120}
"
            US7_1(v121)
and closure18 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US7 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'''}' / s: %A{struct (v1, v2, v3)}"
        US7_1(v5)
    else
        let v9 : char = v0.[int 0]
        let v10 : bool = v9 = '''
        if v10 then
            let v11 : (string -> int32) = String.length
            let v12 : int32 = v11 v0
            let v15 : int32 = 1 |> int32 
            let v22 : int32 = v12 |> int32 
            let v29 : int32 = v22 - 1
            let v30 : string = v0.[int v15..int v29]
            let v34 : (char -> string) = _.ToString()
            let v35 : string = v34 v9
            let v38 : int32 = v35.Length
            let v39 : (char []) = Array.zeroCreate<char> (v38)
            let v40 : Mut5 = {l0 = 0} : Mut5
            while method27(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method28()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method29(v53, v1, v2, v3)
            US7_0(v9, v30, v75, v76, v77)
        else
            let v79 : string = "\n"
            let v80 : int32 = v0.IndexOf v79 
            let v83 : int32 = v80 - 1
            let v84 : bool = -2 = v83
            let v91 : int32 =
                if v84 then
                    let v85 : (string -> int32) = String.length
                    let v86 : int32 = v85 v0
                    let v89 : int32 = v86 + 1
                    v89
                else
                    let v90 : int32 = v83 + 1
                    v90
            let v92 : int32 = 0 |> int32 
            let v99 : int32 = v91 |> int32 
            let v106 : int32 = v99 - 1
            let v107 : string = v0.[int v92..int v106]
            let v111 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v107}"
            let v114 : int32 = v3 - 1
            let v115 : int32 = 0
            let v116 : (string -> string) = method30(v114, v115)
            let v117 : string = ""
            let v118 : string = v116 v117
            let v119 : string = "^"
            let v120 : string = v118 + v119 
            let v121 : string = $"{v111}
{v120}
"
            US7_1(v121)
and method31 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US7 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US7 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US7_1(v13) -> (* Error *)
            method31(v0, v1, v6)
        | US7_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US7_1(v3)
and method32 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US9 =
            if v3 then
                US9_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US9_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    US9_1
        let v15 : char =
            match v11 with
            | US9_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US9_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method32(v0, v17)
and method33 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v109 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ''' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : (char list -> (char [])) = List.toArray
            let v14 : (char []) = v13 v10
            let v17 : string = $"parsing.none_of / unexpected end of input / chars: %A{v14} / s: %A{struct (v2, v3, v4)}"
            US7_1(v17)
        else
            let v21 : char = v1.[int 0]
            let v22 : int64 = 0L
            let v23 : bool = method32(v21, v22)
            let v24 : bool = v23 = false
            if v24 then
                let v25 : (string -> int32) = String.length
                let v26 : int32 = v25 v1
                let v29 : int32 = 1 |> int32 
                let v36 : int32 = v26 |> int32 
                let v43 : int32 = v36 - 1
                let v44 : string = v1.[int v29..int v43]
                let v48 : (char -> string) = _.ToString()
                let v49 : string = v48 v21
                let v52 : int32 = v49.Length
                let v53 : (char []) = Array.zeroCreate<char> (v52)
                let v54 : Mut5 = {l0 = 0} : Mut5
                while method27(v52, v54) do
                    let v56 : int32 = v54.l0
                    let v57 : char = v49.[int v56]
                    v53.[int v56] <- v57
                    let v58 : int32 = v56 + 1
                    v54.l0 <- v58
                    ()
                let v59 : char list = v53 |> Array.toList
                let v62 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v63 : (char -> (UH0 -> UH0)) = method28()
                let v64 : (char list -> (UH0 -> UH0)) = v62 v63
                let v65 : (UH0 -> UH0) = v64 v59
                let v66 : UH0 = UH0_0
                let v67 : UH0 = v65 v66
                let struct (v89 : System.Text.StringBuilder, v90 : int32, v91 : int32) = method29(v67, v2, v3, v4)
                US7_0(v21, v44, v89, v90, v91)
            else
                let v93 : char list = []
                let v94 : char list = ''' :: v93 
                let v97 : char list = '"' :: v94 
                let v100 : (char list -> (char [])) = List.toArray
                let v101 : (char []) = v100 v97
                let v104 : string = $"parsing.none_of / unexpected char: '{v21}' / chars: %A{v101} / s: %A{struct (v2, v3, v4)}"
                US7_1(v104)
    let v121 : US7 =
        match v109 with
        | US7_1(v118) -> (* Error *)
            US7_1(v118)
        | US7_0(v110, v111, v112, v113, v114) -> (* Ok *)
            let v115 : bool = '\\' = v110
            let v116 : char =
                if v115 then
                    '/'
                else
                    v110
            US7_0(v116, v111, v112, v113, v114)
    match v121 with
    | US7_1(v137) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US7_0(v122, v123, v124, v125, v126) -> (* Ok *)
        let v127 : (char -> string) = _.ToString()
        let v128 : string = v127 v122
        let v131 : string = v0 + v128 
        method33(v131, v123, v124, v125, v126)
and method34 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US7 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US7 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US7_1(v15) -> (* Error *)
            method34(v0, v1, v2, v3, v8)
        | US7_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US7_1(v5)
and method35 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US9 =
            if v3 then
                US9_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US9_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US9_0(' ')
                    else
                        let v11 : int64 = v8 - 1L
                        US9_1
        let v19 : char =
            match v15 with
            | US9_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US9_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method35(v0, v21)
and method36 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v115 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = ''' :: v7 
            let v13 : char list = '"' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US7_1(v20)
        else
            let v24 : char = v1.[int 0]
            let v25 : int64 = 0L
            let v26 : bool = method35(v24, v25)
            let v27 : bool = v26 = false
            if v27 then
                let v28 : (string -> int32) = String.length
                let v29 : int32 = v28 v1
                let v32 : int32 = 1 |> int32 
                let v39 : int32 = v29 |> int32 
                let v46 : int32 = v39 - 1
                let v47 : string = v1.[int v32..int v46]
                let v51 : (char -> string) = _.ToString()
                let v52 : string = v51 v24
                let v55 : int32 = v52.Length
                let v56 : (char []) = Array.zeroCreate<char> (v55)
                let v57 : Mut5 = {l0 = 0} : Mut5
                while method27(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method28()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method29(v70, v2, v3, v4)
                US7_0(v24, v47, v92, v93, v94)
            else
                let v96 : char list = []
                let v97 : char list = ' ' :: v96 
                let v100 : char list = ''' :: v97 
                let v103 : char list = '"' :: v100 
                let v106 : (char list -> (char [])) = List.toArray
                let v107 : (char []) = v106 v103
                let v110 : string = $"parsing.none_of / unexpected char: '{v24}' / chars: %A{v107} / s: %A{struct (v2, v3, v4)}"
                US7_1(v110)
    let v127 : US7 =
        match v115 with
        | US7_1(v124) -> (* Error *)
            US7_1(v124)
        | US7_0(v116, v117, v118, v119, v120) -> (* Ok *)
            let v121 : bool = '\\' = v116
            let v122 : char =
                if v121 then
                    '/'
                else
                    v116
            US7_0(v122, v117, v118, v119, v120)
    match v127 with
    | US7_1(v143) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US7_0(v128, v129, v130, v131, v132) -> (* Ok *)
        let v133 : (char -> string) = _.ToString()
        let v134 : string = v133 v128
        let v137 : string = v0 + v134 
        method36(v137, v129, v130, v131, v132)
and method37 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method37(v0, v6)
        else
            v1
and method38 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v79 : US7 =
        if v5 then
            let v6 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US7_1(v6)
        else
            let v10 : char = v1.[int 0]
            let v11 : (string -> int32) = String.length
            let v12 : int32 = v11 v1
            let v15 : int32 = 1 |> int32 
            let v22 : int32 = v12 |> int32 
            let v29 : int32 = v22 - 1
            let v30 : string = v1.[int v15..int v29]
            let v34 : (char -> string) = _.ToString()
            let v35 : string = v34 v10
            let v38 : int32 = v35.Length
            let v39 : (char []) = Array.zeroCreate<char> (v38)
            let v40 : Mut5 = {l0 = 0} : Mut5
            while method27(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method28()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method29(v53, v2, v3, v4)
            US7_0(v10, v30, v75, v76, v77)
    match v79 with
    | US7_1(v95) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US7_0(v80, v81, v82, v83, v84) -> (* Ok *)
        let v85 : (char -> string) = _.ToString()
        let v86 : string = v85 v80
        let v89 : string = v0 + v86 
        method38(v89, v81, v82, v83, v84)
and method25 (v0 : string) : US6 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v1 : (string -> string option) = Option.ofObj
    let v2 : string option = v1 v0
    v2 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v3 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v6 : string = ""
    let v7 : string = v3 |> Option.defaultValue v6 
    let v10 : string = method26()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure14()
    let v16 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure18()
    let v17 : UH1 = UH1_0
    let v18 : UH1 = UH1_1(v16, v17)
    let v19 : UH1 = UH1_1(v15, v18)
    let v20 : US7 = method31(v7, v12, v19)
    let v202 : US8 =
        match v20 with
        | US7_1(v199) -> (* Error *)
            US8_1(v199)
        | US7_0(v21, v22, v23, v24, v25) -> (* Ok *)
            let v26 : bool = "" = v22
            let v130 : US7 =
                if v26 then
                    let v27 : char list = []
                    let v28 : char list = ''' :: v27 
                    let v31 : char list = '"' :: v28 
                    let v34 : (char list -> (char [])) = List.toArray
                    let v35 : (char []) = v34 v31
                    let v38 : string = $"parsing.none_of / unexpected end of input / chars: %A{v35} / s: %A{struct (v23, v24, v25)}"
                    US7_1(v38)
                else
                    let v42 : char = v22.[int 0]
                    let v43 : int64 = 0L
                    let v44 : bool = method32(v42, v43)
                    let v45 : bool = v44 = false
                    if v45 then
                        let v46 : (string -> int32) = String.length
                        let v47 : int32 = v46 v22
                        let v50 : int32 = 1 |> int32 
                        let v57 : int32 = v47 |> int32 
                        let v64 : int32 = v57 - 1
                        let v65 : string = v22.[int v50..int v64]
                        let v69 : (char -> string) = _.ToString()
                        let v70 : string = v69 v42
                        let v73 : int32 = v70.Length
                        let v74 : (char []) = Array.zeroCreate<char> (v73)
                        let v75 : Mut5 = {l0 = 0} : Mut5
                        while method27(v73, v75) do
                            let v77 : int32 = v75.l0
                            let v78 : char = v70.[int v77]
                            v74.[int v77] <- v78
                            let v79 : int32 = v77 + 1
                            v75.l0 <- v79
                            ()
                        let v80 : char list = v74 |> Array.toList
                        let v83 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v84 : (char -> (UH0 -> UH0)) = method28()
                        let v85 : (char list -> (UH0 -> UH0)) = v83 v84
                        let v86 : (UH0 -> UH0) = v85 v80
                        let v87 : UH0 = UH0_0
                        let v88 : UH0 = v86 v87
                        let struct (v110 : System.Text.StringBuilder, v111 : int32, v112 : int32) = method29(v88, v23, v24, v25)
                        US7_0(v42, v65, v110, v111, v112)
                    else
                        let v114 : char list = []
                        let v115 : char list = ''' :: v114 
                        let v118 : char list = '"' :: v115 
                        let v121 : (char list -> (char [])) = List.toArray
                        let v122 : (char []) = v121 v118
                        let v125 : string = $"parsing.none_of / unexpected char: '{v42}' / chars: %A{v122} / s: %A{struct (v23, v24, v25)}"
                        US7_1(v125)
            let v142 : US7 =
                match v130 with
                | US7_1(v139) -> (* Error *)
                    US7_1(v139)
                | US7_0(v131, v132, v133, v134, v135) -> (* Ok *)
                    let v136 : bool = '\\' = v131
                    let v137 : char =
                        if v136 then
                            '/'
                        else
                            v131
                    US7_0(v137, v132, v133, v134, v135)
            let v161 : US8 =
                match v142 with
                | US7_1(v158) -> (* Error *)
                    US8_1(v158)
                | US7_0(v143, v144, v145, v146, v147) -> (* Ok *)
                    let v148 : (char -> string) = _.ToString()
                    let v149 : string = v148 v143
                    let struct (v152 : string, v153 : string, v154 : System.Text.StringBuilder, v155 : int32, v156 : int32) = method33(v149, v144, v145, v146, v147)
                    US8_0(v152, v153, v154, v155, v156)
            let v171 : US8 =
                match v161 with
                | US8_1(v168) -> (* Error *)
                    US8_0(v6, v22, v23, v24, v25)
                | US8_0(v162, v163, v164, v165, v166) -> (* Ok *)
                    US8_0(v162, v163, v164, v165, v166)
            match v171 with
            | US8_1(v194) -> (* Error *)
                let v195 : string = "parsing.between / expected content"
                US8_1(v195)
            | US8_0(v172, v173, v174, v175, v176) -> (* Ok *)
                let v177 : UH1 = UH1_0
                let v178 : UH1 = UH1_1(v16, v177)
                let v179 : UH1 = UH1_1(v15, v178)
                let v180 : US7 = method34(v173, v174, v175, v176, v179)
                match v180 with
                | US7_1(v187) -> (* Error *)
                    let v188 : string = $"parsing.between / expected closing delimiter / e: %A{v187} / input: %A{struct (v7, v12, 1, 1)} / rest1: %A{struct (v22, v23, v24, v25)} / rest2: %A{struct (v173, v174, v175, v176)}"
                    US8_1(v188)
                | US7_0(v181, v182, v183, v184, v185) -> (* Ok *)
                    US8_0(v172, v182, v183, v184, v185)
    let v414 : US8 =
        match v202 with
        | US8_1(v208) -> (* Error *)
            let v209 : bool = "" = v7
            let v321 : US7 =
                if v209 then
                    let v210 : char list = []
                    let v211 : char list = ' ' :: v210 
                    let v214 : char list = ''' :: v211 
                    let v217 : char list = '"' :: v214 
                    let v220 : (char list -> (char [])) = List.toArray
                    let v221 : (char []) = v220 v217
                    let v224 : string = $"parsing.none_of / unexpected end of input / chars: %A{v221} / s: %A{struct (v12, 1, 1)}"
                    US7_1(v224)
                else
                    let v228 : char = v7.[int 0]
                    let v229 : int64 = 0L
                    let v230 : bool = method35(v228, v229)
                    let v231 : bool = v230 = false
                    if v231 then
                        let v232 : (string -> int32) = String.length
                        let v233 : int32 = v232 v7
                        let v236 : int32 = 1 |> int32 
                        let v243 : int32 = v233 |> int32 
                        let v250 : int32 = v243 - 1
                        let v251 : string = v7.[int v236..int v250]
                        let v255 : (char -> string) = _.ToString()
                        let v256 : string = v255 v228
                        let v259 : int32 = v256.Length
                        let v260 : (char []) = Array.zeroCreate<char> (v259)
                        let v261 : Mut5 = {l0 = 0} : Mut5
                        while method27(v259, v261) do
                            let v263 : int32 = v261.l0
                            let v264 : char = v256.[int v263]
                            v260.[int v263] <- v264
                            let v265 : int32 = v263 + 1
                            v261.l0 <- v265
                            ()
                        let v266 : char list = v260 |> Array.toList
                        let v269 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v270 : (char -> (UH0 -> UH0)) = method28()
                        let v271 : (char list -> (UH0 -> UH0)) = v269 v270
                        let v272 : (UH0 -> UH0) = v271 v266
                        let v273 : UH0 = UH0_0
                        let v274 : UH0 = v272 v273
                        let v296 : int32 = 1
                        let v297 : int32 = 1
                        let struct (v298 : System.Text.StringBuilder, v299 : int32, v300 : int32) = method29(v274, v12, v296, v297)
                        US7_0(v228, v251, v298, v299, v300)
                    else
                        let v302 : char list = []
                        let v303 : char list = ' ' :: v302 
                        let v306 : char list = ''' :: v303 
                        let v309 : char list = '"' :: v306 
                        let v312 : (char list -> (char [])) = List.toArray
                        let v313 : (char []) = v312 v309
                        let v316 : string = $"parsing.none_of / unexpected char: '{v228}' / chars: %A{v313} / s: %A{struct (v12, 1, 1)}"
                        US7_1(v316)
            let v333 : US7 =
                match v321 with
                | US7_1(v330) -> (* Error *)
                    US7_1(v330)
                | US7_0(v322, v323, v324, v325, v326) -> (* Ok *)
                    let v327 : bool = '\\' = v322
                    let v328 : char =
                        if v327 then
                            '/'
                        else
                            v322
                    US7_0(v328, v323, v324, v325, v326)
            let v352 : US8 =
                match v333 with
                | US7_1(v349) -> (* Error *)
                    US8_1(v349)
                | US7_0(v334, v335, v336, v337, v338) -> (* Ok *)
                    let v339 : (char -> string) = _.ToString()
                    let v340 : string = v339 v334
                    let struct (v343 : string, v344 : string, v345 : System.Text.StringBuilder, v346 : int32, v347 : int32) = method36(v340, v335, v336, v337, v338)
                    US8_0(v343, v344, v345, v346, v347)
            match v352 with
            | US8_1(v358) -> (* Error *)
                let v359 : int32 = v7.Length
                let v360 : bool = v359 = 0
                let v366 : US10 =
                    if v360 then
                        US10_0(v7, v12, 1, 1)
                    else
                        let v362 : string = $"parsing.eof / expected end of input / input: %A{v7}"
                        US10_1(v362)
                let v375 : US8 =
                    match v366 with
                    | US10_1(v372) -> (* Error *)
                        US8_1(v372)
                    | US10_0(v367, v368, v369, v370) -> (* Ok *)
                        US8_0(v6, v367, v368, v369, v370)
                match v375 with
                | US8_1(v407) -> (* Error *)
                    US8_1(v407)
                | US8_0(v376, v377, v378, v379, v380) -> (* Ok *)
                    let v381 : int32 = 0
                    let v382 : int32 = method37(v377, v381)
                    let v383 : (string -> int32) = String.length
                    let v384 : int32 = v383 v377
                    let v387 : int32 = v382 |> int32 
                    let v394 : int32 = v384 |> int32 
                    let v401 : int32 = v394 - 1
                    let v402 : string = v377.[int v387..int v401]
                    US8_0(v376, v402, v378, v379, v380)
            | US8_0(v353, v354, v355, v356, v357) -> (* Ok *)
                v352
        | US8_0(v203, v204, v205, v206, v207) -> (* Ok *)
            v202
    let v682 : US11 =
        match v414 with
        | US8_1(v679) -> (* Error *)
            US11_1(v679)
        | US8_0(v415, v416, v417, v418, v419) -> (* Ok *)
            let v420 : bool = "" = v416
            let v541 : US7 =
                if v420 then
                    let v421 : string = $"parsing.p_char / unexpected end of input / c: '{' '}' / s: %A{struct (v417, v418, v419)}"
                    US7_1(v421)
                else
                    let v425 : char = v416.[int 0]
                    let v426 : bool = v425 = ' '
                    if v426 then
                        let v427 : (string -> int32) = String.length
                        let v428 : int32 = v427 v416
                        let v431 : int32 = 1 |> int32 
                        let v438 : int32 = v428 |> int32 
                        let v445 : int32 = v438 - 1
                        let v446 : string = v416.[int v431..int v445]
                        let v450 : (char -> string) = _.ToString()
                        let v451 : string = v450 v425
                        let v454 : int32 = v451.Length
                        let v455 : (char []) = Array.zeroCreate<char> (v454)
                        let v456 : Mut5 = {l0 = 0} : Mut5
                        while method27(v454, v456) do
                            let v458 : int32 = v456.l0
                            let v459 : char = v451.[int v458]
                            v455.[int v458] <- v459
                            let v460 : int32 = v458 + 1
                            v456.l0 <- v460
                            ()
                        let v461 : char list = v455 |> Array.toList
                        let v464 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v465 : (char -> (UH0 -> UH0)) = method28()
                        let v466 : (char list -> (UH0 -> UH0)) = v464 v465
                        let v467 : (UH0 -> UH0) = v466 v461
                        let v468 : UH0 = UH0_0
                        let v469 : UH0 = v467 v468
                        let struct (v491 : System.Text.StringBuilder, v492 : int32, v493 : int32) = method29(v469, v417, v418, v419)
                        US7_0(v425, v446, v491, v492, v493)
                    else
                        let v495 : string = "\n"
                        let v496 : int32 = v416.IndexOf v495 
                        let v499 : int32 = v496 - 1
                        let v500 : bool = -2 = v499
                        let v507 : int32 =
                            if v500 then
                                let v501 : (string -> int32) = String.length
                                let v502 : int32 = v501 v416
                                let v505 : int32 = v502 + 1
                                v505
                            else
                                let v506 : int32 = v499 + 1
                                v506
                        let v508 : int32 = 0 |> int32 
                        let v515 : int32 = v507 |> int32 
                        let v522 : int32 = v515 - 1
                        let v523 : string = v416.[int v508..int v522]
                        let v527 : string = $"parsing.p_char / expected: '{' '}' / line: {v418} / col: {v419}
{v417}{v523}"
                        let v530 : int32 = v419 - 1
                        let v531 : int32 = 0
                        let v532 : (string -> string) = method30(v530, v531)
                        let v533 : string = v532 v6
                        let v534 : string = "^"
                        let v535 : string = v533 + v534 
                        let v536 : string = $"{v527}
{v535}
"
                        US7_1(v536)
            let v553 : US12 =
                match v541 with
                | US7_1(v549) -> (* Error *)
                    let v550 : US9 = US9_1
                    US12_0(v550, v416, v417, v418, v419)
                | US7_0(v542, v543, v544, v545, v546) -> (* Ok *)
                    let v547 : US9 = US9_0(v542)
                    US12_0(v547, v543, v544, v545, v546)
            let v656 : US8 =
                match v553 with
                | US12_1(v653) -> (* Error *)
                    US8_1(v653)
                | US12_0(v554, v555, v556, v557, v558) -> (* Ok *)
                    let v559 : bool = "" = v555
                    let v633 : US7 =
                        if v559 then
                            let v560 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v556, v557, v558)}"
                            US7_1(v560)
                        else
                            let v564 : char = v555.[int 0]
                            let v565 : (string -> int32) = String.length
                            let v566 : int32 = v565 v555
                            let v569 : int32 = 1 |> int32 
                            let v576 : int32 = v566 |> int32 
                            let v583 : int32 = v576 - 1
                            let v584 : string = v555.[int v569..int v583]
                            let v588 : (char -> string) = _.ToString()
                            let v589 : string = v588 v564
                            let v592 : int32 = v589.Length
                            let v593 : (char []) = Array.zeroCreate<char> (v592)
                            let v594 : Mut5 = {l0 = 0} : Mut5
                            while method27(v592, v594) do
                                let v596 : int32 = v594.l0
                                let v597 : char = v589.[int v596]
                                v593.[int v596] <- v597
                                let v598 : int32 = v596 + 1
                                v594.l0 <- v598
                                ()
                            let v599 : char list = v593 |> Array.toList
                            let v602 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v603 : (char -> (UH0 -> UH0)) = method28()
                            let v604 : (char list -> (UH0 -> UH0)) = v602 v603
                            let v605 : (UH0 -> UH0) = v604 v599
                            let v606 : UH0 = UH0_0
                            let v607 : UH0 = v605 v606
                            let struct (v629 : System.Text.StringBuilder, v630 : int32, v631 : int32) = method29(v607, v556, v557, v558)
                            US7_0(v564, v584, v629, v630, v631)
                    match v633 with
                    | US7_1(v649) -> (* Error *)
                        US8_1(v649)
                    | US7_0(v634, v635, v636, v637, v638) -> (* Ok *)
                        let v639 : (char -> string) = _.ToString()
                        let v640 : string = v639 v634
                        let struct (v643 : string, v644 : string, v645 : System.Text.StringBuilder, v646 : int32, v647 : int32) = method38(v640, v635, v636, v637, v638)
                        US8_0(v643, v644, v645, v646, v647)
            let v668 : US13 =
                match v656 with
                | US8_1(v664) -> (* Error *)
                    let v665 : US5 = US5_1
                    US13_0(v665, v416, v417, v418, v419)
                | US8_0(v657, v658, v659, v660, v661) -> (* Ok *)
                    let v662 : US5 = US5_0(v657)
                    US13_0(v662, v658, v659, v660, v661)
            match v668 with
            | US13_1(v675) -> (* Error *)
                US11_1(v675)
            | US13_0(v669, v670, v671, v672, v673) -> (* Ok *)
                US11_0(v415, v669, v670, v671, v672, v673)
    match v682 with
    | US11_1(v690) -> (* Error *)
        US6_1(v690)
    | US11_0(v683, v684, v685, v686, v687, v688) -> (* Ok *)
        US6_0(v683, v684)
and method39 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_blue"
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
    let v40 : string = "inline_colorization::color_bright_blue"
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
    let v72 : string = "inline_colorization::color_bright_blue"
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
    let v104 : string = "\u001b[94m"
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
and method41 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method14()
    let v10 : Mut3 = {l0 = v9} : Mut3
    let v11 : string = "{ "
    let v12 : string = $"{v11}"
    let v15 : unit = ()
    let v16 : (unit -> unit) = closure7(v10, v12)
    let v17 : unit = (fun () -> v16 (); v15) ()
    let v20 : string = "file_name"
    let v21 : string = $"{v20}"
    let v24 : unit = ()
    let v25 : (unit -> unit) = closure7(v10, v21)
    let v26 : unit = (fun () -> v25 (); v24) ()
    let v29 : string = " = "
    let v30 : string = $"{v29}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure7(v10, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = $"{v0}"
    let v41 : unit = ()
    let v42 : (unit -> unit) = closure7(v10, v38)
    let v43 : unit = (fun () -> v42 (); v41) ()
    let v46 : string = "; "
    let v47 : string = $"{v46}"
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure7(v10, v47)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v55 : string = "arguments"
    let v56 : string = $"{v55}"
    let v59 : unit = ()
    let v60 : (unit -> unit) = closure7(v10, v56)
    let v61 : unit = (fun () -> v60 (); v59) ()
    let v64 : string = $"{v29}"
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure7(v10, v64)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : string = $"%A{v1}"
    let v75 : string = $"{v72}"
    let v78 : unit = ()
    let v79 : (unit -> unit) = closure7(v10, v75)
    let v80 : unit = (fun () -> v79 (); v78) ()
    let v83 : string = $"{v46}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure7(v10, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = "options"
    let v92 : string = $"{v91}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure7(v10, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = $"{v29}"
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure7(v10, v100)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v108 : string = $"{v11}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure7(v10, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = "command"
    let v117 : string = $"{v116}"
    let v120 : unit = ()
    let v121 : (unit -> unit) = closure7(v10, v117)
    let v122 : unit = (fun () -> v121 (); v120) ()
    let v125 : string = $"{v29}"
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure7(v10, v125)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v133 : string = $"{v2}"
    let v136 : unit = ()
    let v137 : (unit -> unit) = closure7(v10, v133)
    let v138 : unit = (fun () -> v137 (); v136) ()
    let v141 : string = $"{v46}"
    let v144 : unit = ()
    let v145 : (unit -> unit) = closure7(v10, v141)
    let v146 : unit = (fun () -> v145 (); v144) ()
    let v149 : string = "cancellation_token"
    let v150 : string = $"{v149}"
    let v153 : unit = ()
    let v154 : (unit -> unit) = closure7(v10, v150)
    let v155 : unit = (fun () -> v154 (); v153) ()
    let v158 : string = $"{v29}"
    let v161 : unit = ()
    let v162 : (unit -> unit) = closure7(v10, v158)
    let v163 : unit = (fun () -> v162 (); v161) ()
    (* run_target_args'
    let v166 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : string = "format!(\"{:#?}\", $0)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _run_target_args'_v166 = v170 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v171 : string = "format!(\"{:#?}\", $0)"
    let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v171 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v172 v173 
    let _run_target_args'_v166 = v174 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v175 : string = "format!(\"{:#?}\", $0)"
    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v175 
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177 
    let _run_target_args'_v166 = v178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v179 : string = $"%A{v3}"
    let _run_target_args'_v166 = v179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : string = $"%A{v3}"
    let _run_target_args'_v166 = v182 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v185 : string = $"%A{v3}"
    let _run_target_args'_v166 = v185 
    #endif
#else
    let v188 : string = $"%A{v3}"
    let _run_target_args'_v166 = v188 
    #endif
    let v191 : string = _run_target_args'_v166 
    let v196 : string = $"{v191}"
    let v199 : unit = ()
    let v200 : (unit -> unit) = closure7(v10, v196)
    let v201 : unit = (fun () -> v200 (); v199) ()
    let v204 : string = $"{v46}"
    let v207 : unit = ()
    let v208 : (unit -> unit) = closure7(v10, v204)
    let v209 : unit = (fun () -> v208 (); v207) ()
    let v212 : string = "environment_variables"
    let v213 : string = $"{v212}"
    let v216 : unit = ()
    let v217 : (unit -> unit) = closure7(v10, v213)
    let v218 : unit = (fun () -> v217 (); v216) ()
    let v221 : string = $"{v29}"
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure7(v10, v221)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v229 : string = $"%A{v4}"
    let v232 : string = $"{v229}"
    let v235 : unit = ()
    let v236 : (unit -> unit) = closure7(v10, v232)
    let v237 : unit = (fun () -> v236 (); v235) ()
    let v240 : string = $"{v46}"
    let v243 : unit = ()
    let v244 : (unit -> unit) = closure7(v10, v240)
    let v245 : unit = (fun () -> v244 (); v243) ()
    let v248 : string = "on_line"
    let v249 : string = $"{v248}"
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure7(v10, v249)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v257 : string = $"{v29}"
    let v260 : unit = ()
    let v261 : (unit -> unit) = closure7(v10, v257)
    let v262 : unit = (fun () -> v261 (); v260) ()
    (* run_target_args'
    let v265 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v266 : string = "format!(\"{:#?}\", $0)"
    let v267 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v266 
    let v268 : string = "fable_library_rust::String_::fromString($0)"
    let v269 : string = Fable.Core.RustInterop.emitRustExpr v267 v268 
    let _run_target_args'_v265 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "format!(\"{:#?}\", $0)"
    let v271 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v270 
    let v272 : string = "fable_library_rust::String_::fromString($0)"
    let v273 : string = Fable.Core.RustInterop.emitRustExpr v271 v272 
    let _run_target_args'_v265 = v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = "format!(\"{:#?}\", $0)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _run_target_args'_v265 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v278 : string = $"%A{v5}"
    let _run_target_args'_v265 = v278 
    #endif
#if FABLE_COMPILER_PYTHON
    let v281 : string = $"%A{v5}"
    let _run_target_args'_v265 = v281 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v284 : string = $"%A{v5}"
    let _run_target_args'_v265 = v284 
    #endif
#else
    let v287 : string = $"%A{v5}"
    let _run_target_args'_v265 = v287 
    #endif
    let v290 : string = _run_target_args'_v265 
    let v295 : string = $"{v290}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure7(v10, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v303 : string = $"{v46}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure7(v10, v303)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v311 : string = "stdin"
    let v312 : string = $"{v311}"
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure7(v10, v312)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v320 : string = $"{v29}"
    let v323 : unit = ()
    let v324 : (unit -> unit) = closure7(v10, v320)
    let v325 : unit = (fun () -> v324 (); v323) ()
    (* run_target_args'
    let v328 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : string = "format!(\"{:#?}\", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v329 
    let v331 : string = "fable_library_rust::String_::fromString($0)"
    let v332 : string = Fable.Core.RustInterop.emitRustExpr v330 v331 
    let _run_target_args'_v328 = v332 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v333 : string = "format!(\"{:#?}\", $0)"
    let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v333 
    let v335 : string = "fable_library_rust::String_::fromString($0)"
    let v336 : string = Fable.Core.RustInterop.emitRustExpr v334 v335 
    let _run_target_args'_v328 = v336 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : string = "format!(\"{:#?}\", $0)"
    let v338 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v337 
    let v339 : string = "fable_library_rust::String_::fromString($0)"
    let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339 
    let _run_target_args'_v328 = v340 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v341 : string = $"%A{v6}"
    let _run_target_args'_v328 = v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v344 : string = $"%A{v6}"
    let _run_target_args'_v328 = v344 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v347 : string = $"%A{v6}"
    let _run_target_args'_v328 = v347 
    #endif
#else
    let v350 : string = $"%A{v6}"
    let _run_target_args'_v328 = v350 
    #endif
    let v353 : string = _run_target_args'_v328 
    let v358 : string = $"{v353}"
    let v361 : unit = ()
    let v362 : (unit -> unit) = closure7(v10, v358)
    let v363 : unit = (fun () -> v362 (); v361) ()
    let v366 : string = $"{v46}"
    let v369 : unit = ()
    let v370 : (unit -> unit) = closure7(v10, v366)
    let v371 : unit = (fun () -> v370 (); v369) ()
    let v374 : string = "trace"
    let v375 : string = $"{v374}"
    let v378 : unit = ()
    let v379 : (unit -> unit) = closure7(v10, v375)
    let v380 : unit = (fun () -> v379 (); v378) ()
    let v383 : string = $"{v29}"
    let v386 : unit = ()
    let v387 : (unit -> unit) = closure7(v10, v383)
    let v388 : unit = (fun () -> v387 (); v386) ()
    let v393 : string =
        if v7 then
            let v391 : string = "true"
            v391
        else
            let v392 : string = "false"
            v392
    let v394 : string = $"{v393}"
    let v397 : unit = ()
    let v398 : (unit -> unit) = closure7(v10, v394)
    let v399 : unit = (fun () -> v398 (); v397) ()
    let v402 : string = $"{v46}"
    let v405 : unit = ()
    let v406 : (unit -> unit) = closure7(v10, v402)
    let v407 : unit = (fun () -> v406 (); v405) ()
    let v410 : string = "working_directory"
    let v411 : string = $"{v410}"
    let v414 : unit = ()
    let v415 : (unit -> unit) = closure7(v10, v411)
    let v416 : unit = (fun () -> v415 (); v414) ()
    let v419 : string = $"{v29}"
    let v422 : unit = ()
    let v423 : (unit -> unit) = closure7(v10, v419)
    let v424 : unit = (fun () -> v423 (); v422) ()
    (* run_target_args'
    let v427 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v428 : string = "format!(\"{:#?}\", $0)"
    let v429 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v428 
    let v430 : string = "fable_library_rust::String_::fromString($0)"
    let v431 : string = Fable.Core.RustInterop.emitRustExpr v429 v430 
    let _run_target_args'_v427 = v431 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v432 : string = "format!(\"{:#?}\", $0)"
    let v433 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v432 
    let v434 : string = "fable_library_rust::String_::fromString($0)"
    let v435 : string = Fable.Core.RustInterop.emitRustExpr v433 v434 
    let _run_target_args'_v427 = v435 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v436 : string = "format!(\"{:#?}\", $0)"
    let v437 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v436 
    let v438 : string = "fable_library_rust::String_::fromString($0)"
    let v439 : string = Fable.Core.RustInterop.emitRustExpr v437 v438 
    let _run_target_args'_v427 = v439 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v440 : string = $"%A{v8}"
    let _run_target_args'_v427 = v440 
    #endif
#if FABLE_COMPILER_PYTHON
    let v443 : string = $"%A{v8}"
    let _run_target_args'_v427 = v443 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v446 : string = $"%A{v8}"
    let _run_target_args'_v427 = v446 
    #endif
#else
    let v449 : string = $"%A{v8}"
    let _run_target_args'_v427 = v449 
    #endif
    let v452 : string = _run_target_args'_v427 
    let v457 : string = $"{v452}"
    let v460 : unit = ()
    let v461 : (unit -> unit) = closure7(v10, v457)
    let v462 : unit = (fun () -> v461 (); v460) ()
    let v465 : string = " }"
    let v466 : string = $"{v465}"
    let v469 : unit = ()
    let v470 : (unit -> unit) = closure7(v10, v466)
    let v471 : unit = (fun () -> v470 (); v469) ()
    let v474 : string = $"{v465}"
    let v477 : unit = ()
    let v478 : (unit -> unit) = closure7(v10, v474)
    let v479 : unit = (fun () -> v478 (); v477) ()
    let v482 : string = v10.l0
    v482
and method40 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method41(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options_async"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method18(v20)
and closure19 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method7(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure0()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method8(v27, v28, v29, v30, v31, v32)
        let v46 : string = method39()
        let v47 : string = method40(v27, v28, v29, v30, v31, v32, v45, v46, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method19(v47)
and method42 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and method45 (v0 : System.Diagnostics.DataReceivedEventArgs) : string =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = null |> unbox<string>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = null |> unbox<string>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = null |> unbox<string>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = null |> unbox<string>
    let _run_target_args'_v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : string = null |> unbox<string>
    let _run_target_args'_v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : string = null |> unbox<string>
    let _run_target_args'_v1 = v17 
    #endif
#else
    let v20 : (System.Diagnostics.DataReceivedEventArgs -> string) = _.Data
    let v21 : string = v20 v0
    let _run_target_args'_v1 = v21 
    #endif
    let v22 : string = _run_target_args'_v1 
    v22
and closure21 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US14 =
    US14_0(v0)
and method46 () : ((struct (int32 * string * bool) -> Async<unit>) -> US14) =
    closure21()
and method47 (v0 : System.Diagnostics.Process) : int32 =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : int32 = null |> unbox<int32>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : int32 = null |> unbox<int32>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : int32 = null |> unbox<int32>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : int32 = null |> unbox<int32>
    let _run_target_args'_v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : int32 = null |> unbox<int32>
    let _run_target_args'_v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : int32 = null |> unbox<int32>
    let _run_target_args'_v1 = v17 
    #endif
#else
    let v20 : (System.Diagnostics.Process -> int32) = _.Id
    let v21 : int32 = v20 v0
    let _run_target_args'_v1 = v21 
    #endif
    let v22 : int32 = _run_target_args'_v1 
    v22
and method48 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method13(v5)
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
    let v105 : string = method15()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method15()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method15()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method15()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
and method49 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method17()
    let v10 : int64 = v0.l0
    let v11 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method18(v11)
and closure22 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method48()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method49(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v42)
and method44 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    (* run_target_args'
    let v11 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v11 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v11 = v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v18 : Async<unit> = null |> unbox<Async<unit>>
    let _run_target_args'_v11 = v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v21 : unit = ()
    let _let'_v21 =
        async {
            let v24 : string = method45(v10)
            let v25 : string = null |> unbox<string>
            let v28 : bool = v24 = v25
            let v29 : bool = v28 <> true
            if v29 then
                let v30 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method46()
                let v31 : US14 option = v3 |> Option.map v30 
                let v42 : US14 = US14_1
                let v43 : US14 = v31 |> Option.defaultValue v42 
                match v43 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v47) -> (* Some *)
                    let v48 : int32 = method47(v7)
                    let v49 : Async<unit> = v47 struct (v48, v24, v9)
                    do! v49 
                    ()
                let v52 : string =
                    if v9 then
                        let v50 : string = $"! {v24}"
                        v50
                    else
                        let v51 : string = $"> {v24}"
                        v51
                if v5 then
                    let v53 : unit = ()
                    let v54 : (unit -> unit) = closure22(v52)
                    let v55 : unit = (fun () -> v54 (); v53) ()
                    ()
                else
                    let v98 : unit = ()
                    let v99 : (unit -> unit) = closure10(v52)
                    let v100 : unit = (fun () -> v99 (); v98) ()
                    ()
                let v104 : string =
                    if v9 then
                        let v102 : string = "\u001b[7;4m"
                        v102
                    else
                        let v103 : string = ""
                        v103
                let v107 : string =
                    if v9 then
                        let v105 : string = "\u001b[0m"
                        v105
                    else
                        let v106 : string = ""
                        v106
                let v108 : string = $"{v104}{v24}{v107}"
                (* run_target_args'
                let v109 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v110 : (string -> unit) = v8.Push
                v110 v108
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v720 : Async<unit> = _let'_v21 
    let _run_target_args'_v11 = v720 
    #endif
#if FABLE_COMPILER_PYTHON
    let v721 : unit = ()
    let _let'_v721 =
        async {
            let v724 : string = method45(v10)
            let v725 : string = null |> unbox<string>
            let v728 : bool = v724 = v725
            let v729 : bool = v728 <> true
            if v729 then
                let v730 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method46()
                let v731 : US14 option = v3 |> Option.map v730 
                let v742 : US14 = US14_1
                let v743 : US14 = v731 |> Option.defaultValue v742 
                match v743 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v747) -> (* Some *)
                    let v748 : int32 = method47(v7)
                    let v749 : Async<unit> = v747 struct (v748, v724, v9)
                    do! v749 
                    ()
                let v752 : string =
                    if v9 then
                        let v750 : string = $"! {v724}"
                        v750
                    else
                        let v751 : string = $"> {v724}"
                        v751
                if v5 then
                    let v753 : unit = ()
                    let v754 : (unit -> unit) = closure22(v752)
                    let v755 : unit = (fun () -> v754 (); v753) ()
                    ()
                else
                    let v798 : unit = ()
                    let v799 : (unit -> unit) = closure10(v752)
                    let v800 : unit = (fun () -> v799 (); v798) ()
                    ()
                let v804 : string =
                    if v9 then
                        let v802 : string = "\u001b[7;4m"
                        v802
                    else
                        let v803 : string = ""
                        v803
                let v807 : string =
                    if v9 then
                        let v805 : string = "\u001b[0m"
                        v805
                    else
                        let v806 : string = ""
                        v806
                let v808 : string = $"{v804}{v724}{v807}"
                (* run_target_args'
                let v809 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v810 : (string -> unit) = v8.Push
                v810 v808
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1420 : Async<unit> = _let'_v721 
    let _run_target_args'_v11 = v1420 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1421 : unit = ()
    let _let'_v1421 =
        async {
            let v1424 : string = method45(v10)
            let v1425 : string = null |> unbox<string>
            let v1428 : bool = v1424 = v1425
            let v1429 : bool = v1428 <> true
            if v1429 then
                let v1430 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method46()
                let v1431 : US14 option = v3 |> Option.map v1430 
                let v1442 : US14 = US14_1
                let v1443 : US14 = v1431 |> Option.defaultValue v1442 
                match v1443 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v1447) -> (* Some *)
                    let v1448 : int32 = method47(v7)
                    let v1449 : Async<unit> = v1447 struct (v1448, v1424, v9)
                    do! v1449 
                    ()
                let v1452 : string =
                    if v9 then
                        let v1450 : string = $"! {v1424}"
                        v1450
                    else
                        let v1451 : string = $"> {v1424}"
                        v1451
                if v5 then
                    let v1453 : unit = ()
                    let v1454 : (unit -> unit) = closure22(v1452)
                    let v1455 : unit = (fun () -> v1454 (); v1453) ()
                    ()
                else
                    let v1498 : unit = ()
                    let v1499 : (unit -> unit) = closure10(v1452)
                    let v1500 : unit = (fun () -> v1499 (); v1498) ()
                    ()
                let v1504 : string =
                    if v9 then
                        let v1502 : string = "\u001b[7;4m"
                        v1502
                    else
                        let v1503 : string = ""
                        v1503
                let v1507 : string =
                    if v9 then
                        let v1505 : string = "\u001b[0m"
                        v1505
                    else
                        let v1506 : string = ""
                        v1506
                let v1508 : string = $"{v1504}{v1424}{v1507}"
                (* run_target_args'
                let v1509 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v1510 : (string -> unit) = v8.Push
                v1510 v1508
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2120 : Async<unit> = _let'_v1421 
    let _run_target_args'_v11 = v2120 
    #endif
#else
    let v2121 : unit = ()
    let _let'_v2121 =
        async {
            let v2124 : string = method45(v10)
            let v2125 : string = null |> unbox<string>
            let v2128 : bool = v2124 = v2125
            let v2129 : bool = v2128 <> true
            if v2129 then
                let v2130 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method46()
                let v2131 : US14 option = v3 |> Option.map v2130 
                let v2142 : US14 = US14_1
                let v2143 : US14 = v2131 |> Option.defaultValue v2142 
                match v2143 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v2147) -> (* Some *)
                    let v2148 : int32 = method47(v7)
                    let v2149 : Async<unit> = v2147 struct (v2148, v2124, v9)
                    do! v2149 
                    ()
                let v2152 : string =
                    if v9 then
                        let v2150 : string = $"! {v2124}"
                        v2150
                    else
                        let v2151 : string = $"> {v2124}"
                        v2151
                if v5 then
                    let v2153 : unit = ()
                    let v2154 : (unit -> unit) = closure22(v2152)
                    let v2155 : unit = (fun () -> v2154 (); v2153) ()
                    ()
                else
                    let v2198 : unit = ()
                    let v2199 : (unit -> unit) = closure10(v2152)
                    let v2200 : unit = (fun () -> v2199 (); v2198) ()
                    ()
                let v2204 : string =
                    if v9 then
                        let v2202 : string = "\u001b[7;4m"
                        v2202
                    else
                        let v2203 : string = ""
                        v2203
                let v2207 : string =
                    if v9 then
                        let v2205 : string = "\u001b[0m"
                        v2205
                    else
                        let v2206 : string = ""
                        v2206
                let v2208 : string = $"{v2204}{v2124}{v2207}"
                (* run_target_args'
                let v2209 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v2210 : (string -> unit) = v8.Push
                v2210 v2208
                #endif
                // run_target_args' is_unit
                ()
            ()
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2820 : Async<unit> = _let'_v2121 
    let _run_target_args'_v11 = v2820 
    #endif
    let v2821 : Async<unit> = _run_target_args'_v11 
    v2821
and method43 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool, v10 : System.Diagnostics.DataReceivedEventArgs) : Async<unit> =
    method44(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
and closure20 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>, v9 : bool) (v10 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v11 : Async<unit> = method43(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
    (* run_target_args'
    let v12 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : (Async<unit> -> unit) = Async.StartImmediate
    v13 v11
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : (Async<unit> -> unit) = Async.StartImmediate
    v14 v11
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : (Async<unit> -> unit) = Async.StartImmediate
    v15 v11
    #endif
#else
    let v16 : (Async<unit> -> unit) = Async.StartImmediate
    v16 v11
    #endif
    // run_target_args' is_unit
    ()
and closure23 () (v0 : System.Threading.CancellationToken) : US15 =
    US15_0(v0)
and method50 () : (System.Threading.CancellationToken -> US15) =
    closure23()
and method51 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _let'_v11 =
        async {
            (* run_target_args'
            let v14 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v15 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v18 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v24 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v27 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v30 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v30 
            #endif
#else
            let v33 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v33 = v33 
            let v34 : System.Threading.CancellationToken = v33 
            let v35 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v36 : (System.Threading.CancellationToken []) = [|v34; v35; v0|]
            let v37 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v38 : System.Threading.CancellationTokenSource = v37 v36
            let v39 : System.Threading.CancellationToken = v38.Token
            return v39 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v246 : Async<System.Threading.CancellationToken> = _let'_v11 
    let _run_target_args'_v1 = v246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v247 : unit = ()
    let _let'_v247 =
        async {
            (* run_target_args'
            let v250 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v251 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v251 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v257 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v257 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v260 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v260 
            #endif
#if FABLE_COMPILER_PYTHON
            let v263 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v263 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v266 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v266 
            #endif
#else
            let v269 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v269 = v269 
            let v270 : System.Threading.CancellationToken = v269 
            let v271 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v272 : (System.Threading.CancellationToken []) = [|v270; v271; v0|]
            let v273 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v274 : System.Threading.CancellationTokenSource = v273 v272
            let v275 : System.Threading.CancellationToken = v274.Token
            return v275 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v482 : Async<System.Threading.CancellationToken> = _let'_v247 
    let _run_target_args'_v1 = v482 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v483 : unit = ()
    let _let'_v483 =
        async {
            (* run_target_args'
            let v486 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v487 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v487 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v490 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v490 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v493 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v493 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v496 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v496 
            #endif
#if FABLE_COMPILER_PYTHON
            let v499 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v499 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v502 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v502 
            #endif
#else
            let v505 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v505 = v505 
            let v506 : System.Threading.CancellationToken = v505 
            let v507 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v508 : (System.Threading.CancellationToken []) = [|v506; v507; v0|]
            let v509 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v510 : System.Threading.CancellationTokenSource = v509 v508
            let v511 : System.Threading.CancellationToken = v510.Token
            return v511 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v718 : Async<System.Threading.CancellationToken> = _let'_v483 
    let _run_target_args'_v1 = v718 
    #endif
#else
    let v719 : unit = ()
    let _let'_v719 =
        async {
            (* run_target_args'
            let v722 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v726 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v726 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v729 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v729 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v732 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v732 
            #endif
#if FABLE_COMPILER_PYTHON
            let v735 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v735 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v738 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v738 
            #endif
#else
            let v741 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v741 = v741 
            let v742 : System.Threading.CancellationToken = v741 
            let v743 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v744 : (System.Threading.CancellationToken []) = [|v742; v743; v0|]
            let v745 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v746 : System.Threading.CancellationTokenSource = v745 v744
            let v747 : System.Threading.CancellationToken = v746.Token
            return v747 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v954 : Async<System.Threading.CancellationToken> = _let'_v719 
    let _run_target_args'_v1 = v954 
    #endif
    let v955 : Async<System.Threading.CancellationToken> = _run_target_args'_v1 
    v955
and method52 (v0 : System.Diagnostics.Process) : bool =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : bool = null |> unbox<bool>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : bool = null |> unbox<bool>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : bool = null |> unbox<bool>
    let _run_target_args'_v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : bool = null |> unbox<bool>
    let _run_target_args'_v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : bool = null |> unbox<bool>
    let _run_target_args'_v1 = v17 
    #endif
#else
    let v20 : (System.Diagnostics.Process -> bool) = _.HasExited
    let v21 : bool = v20 v0
    let _run_target_args'_v1 = v21 
    #endif
    let v22 : bool = _run_target_args'_v1 
    v22
and method53 (v0 : System.Diagnostics.Process) : unit =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    #endif
#if FABLE_COMPILER_RUST && WASM
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    #endif
#if FABLE_COMPILER_PYTHON
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    #endif
#else
    let v2 : (System.Diagnostics.Process -> unit) = _.Kill()
    v2 v0
    #endif
    // run_target_args' is_unit
    ()
and closure24 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool = method52(v0)
    let v2 : bool = v1 = false
    if v2 then
        method53(v0)
and method56 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method14()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "ex"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure7(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure7(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "format!(\"{:#?}\", $0)"
    let v32 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v31 
    let v33 : string = "fable_library_rust::String_::fromString($0)"
    let v34 : string = Fable.Core.RustInterop.emitRustExpr v32 v33 
    let _run_target_args'_v30 = v34 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v35 : string = "format!(\"{:#?}\", $0)"
    let v36 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v35 
    let v37 : string = "fable_library_rust::String_::fromString($0)"
    let v38 : string = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let _run_target_args'_v30 = v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "format!(\"{:#?}\", $0)"
    let v40 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v39 
    let v41 : string = "fable_library_rust::String_::fromString($0)"
    let v42 : string = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let _run_target_args'_v30 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v43 : string = $"%A{v0}"
    let _run_target_args'_v30 = v43 
    #endif
#if FABLE_COMPILER_PYTHON
    let v46 : string = $"%A{v0}"
    let _run_target_args'_v30 = v46 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v49 : string = $"%A{v0}"
    let _run_target_args'_v30 = v49 
    #endif
#else
    let v52 : string = $"%A{v0}"
    let _run_target_args'_v30 = v52 
    #endif
    let v55 : string = _run_target_args'_v30 
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
and method55 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method56(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method18(v12)
and closure25 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method7(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method8(v19, v20, v21, v22, v23, v24)
        let v38 : string = method12()
        let v39 : string = method55(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method19(v39)
and method54 (v0 : System.Diagnostics.Process, v1 : System.Collections.Concurrent.ConcurrentStack<string>, v2 : System.Threading.CancellationToken) : Async<int32> =
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
            try
                (* run_target_args'
                let v16 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v17 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v16 = v17 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v20 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v16 = v20 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v23 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v16 = v23 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v26 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v16 = v26 
                #endif
#if FABLE_COMPILER_PYTHON
                let v29 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v16 = v29 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v32 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v16 = v32 
                #endif
#else
                let v35 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v16 = v35 
                #endif
                let v36 : System.Threading.Tasks.Task = _run_target_args'_v16 
                (* run_target_args'
                let v41 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v42 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v41 = v42 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v45 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v41 = v45 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v48 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v41 = v48 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v51 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v52 : Async<unit> = v51 v36
                let _run_target_args'_v41 = v52 
                #endif
#if FABLE_COMPILER_PYTHON
                let v53 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v54 : Async<unit> = v53 v36
                let _run_target_args'_v41 = v54 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v55 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v56 : Async<unit> = v55 v36
                let _run_target_args'_v41 = v56 
                #endif
#else
                let v57 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v58 : Async<unit> = v57 v36
                let _run_target_args'_v41 = v58 
                #endif
                let v59 : Async<unit> = _run_target_args'_v41 
                do! v59 
                (* run_target_args'
                let v64 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v65 : int32 = null |> unbox<int32>
                let _run_target_args'_v64 = v65 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v68 : int32 = null |> unbox<int32>
                let _run_target_args'_v64 = v68 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v71 : int32 = null |> unbox<int32>
                let _run_target_args'_v64 = v71 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v74 : int32 = null |> unbox<int32>
                let _run_target_args'_v64 = v74 
                #endif
#if FABLE_COMPILER_PYTHON
                let v77 : int32 = null |> unbox<int32>
                let _run_target_args'_v64 = v77 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v80 : int32 = null |> unbox<int32>
                let _run_target_args'_v64 = v80 
                #endif
#else
                let v83 : int32 = v0.ExitCode
                let _run_target_args'_v64 = v83 
                #endif
                let v84 : int32 = _run_target_args'_v64 
                return v84 
                (* indent
                ()
            indent *)
            with ex ->
                let v162 : exn = ex
                (* run_target_args'
                let v163 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v164 : string = $"%A{v162}"
                let _run_target_args'_v163 = v164 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v167 : string = $"%A{v162}"
                let _run_target_args'_v163 = v167 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v170 : string = $"%A{v162}"
                let _run_target_args'_v163 = v170 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v173 : string = $"%A{v162}"
                let _run_target_args'_v163 = v173 
                #endif
#if FABLE_COMPILER_PYTHON
                let v176 : string = $"%A{v162}"
                let _run_target_args'_v163 = v176 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v179 : string = $"%A{v162}"
                let _run_target_args'_v163 = v179 
                #endif
#else
                let v182 : string = $"{v162.GetType ()}: {v162.Message}"
                let _run_target_args'_v163 = v182 
                #endif
                let v183 : string = _run_target_args'_v163 
                (* run_target_args'
                let v188 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v189 : (string -> unit) = v1.Push
                v189 v183
                #endif
                // run_target_args' is_unit
                let v190 : System.Threading.Tasks.TaskCanceledException = v162 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v193 : unit = ()
                let v194 : (unit -> unit) = closure25(v190)
                let v195 : unit = (fun () -> v194 (); v193) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v2352 : Async<int32> = _let'_v13 
    let _run_target_args'_v3 = v2352 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2353 : unit = ()
    let _let'_v2353 =
        async {
            try
                (* run_target_args'
                let v2356 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2357 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2356 = v2357 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2360 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2356 = v2360 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2363 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2356 = v2363 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2366 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2356 = v2366 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2369 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2356 = v2369 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2372 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v2356 = v2372 
                #endif
#else
                let v2375 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v2356 = v2375 
                #endif
                let v2376 : System.Threading.Tasks.Task = _run_target_args'_v2356 
                (* run_target_args'
                let v2381 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2382 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v2381 = v2382 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2385 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v2381 = v2385 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2388 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v2381 = v2388 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2391 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2392 : Async<unit> = v2391 v2376
                let _run_target_args'_v2381 = v2392 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2393 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2394 : Async<unit> = v2393 v2376
                let _run_target_args'_v2381 = v2394 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2395 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2396 : Async<unit> = v2395 v2376
                let _run_target_args'_v2381 = v2396 
                #endif
#else
                let v2397 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v2398 : Async<unit> = v2397 v2376
                let _run_target_args'_v2381 = v2398 
                #endif
                let v2399 : Async<unit> = _run_target_args'_v2381 
                do! v2399 
                (* run_target_args'
                let v2404 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2405 : int32 = null |> unbox<int32>
                let _run_target_args'_v2404 = v2405 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2408 : int32 = null |> unbox<int32>
                let _run_target_args'_v2404 = v2408 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2411 : int32 = null |> unbox<int32>
                let _run_target_args'_v2404 = v2411 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2414 : int32 = null |> unbox<int32>
                let _run_target_args'_v2404 = v2414 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2417 : int32 = null |> unbox<int32>
                let _run_target_args'_v2404 = v2417 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2420 : int32 = null |> unbox<int32>
                let _run_target_args'_v2404 = v2420 
                #endif
#else
                let v2423 : int32 = v0.ExitCode
                let _run_target_args'_v2404 = v2423 
                #endif
                let v2424 : int32 = _run_target_args'_v2404 
                return v2424 
                (* indent
                ()
            indent *)
            with ex ->
                let v2502 : exn = ex
                (* run_target_args'
                let v2503 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v2504 : string = $"%A{v2502}"
                let _run_target_args'_v2503 = v2504 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v2507 : string = $"%A{v2502}"
                let _run_target_args'_v2503 = v2507 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v2510 : string = $"%A{v2502}"
                let _run_target_args'_v2503 = v2510 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v2513 : string = $"%A{v2502}"
                let _run_target_args'_v2503 = v2513 
                #endif
#if FABLE_COMPILER_PYTHON
                let v2516 : string = $"%A{v2502}"
                let _run_target_args'_v2503 = v2516 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v2519 : string = $"%A{v2502}"
                let _run_target_args'_v2503 = v2519 
                #endif
#else
                let v2522 : string = $"{v2502.GetType ()}: {v2502.Message}"
                let _run_target_args'_v2503 = v2522 
                #endif
                let v2523 : string = _run_target_args'_v2503 
                (* run_target_args'
                let v2528 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v2529 : (string -> unit) = v1.Push
                v2529 v2523
                #endif
                // run_target_args' is_unit
                let v2530 : System.Threading.Tasks.TaskCanceledException = v2502 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v2533 : unit = ()
                let v2534 : (unit -> unit) = closure25(v2530)
                let v2535 : unit = (fun () -> v2534 (); v2533) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v4692 : Async<int32> = _let'_v2353 
    let _run_target_args'_v3 = v4692 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4693 : unit = ()
    let _let'_v4693 =
        async {
            try
                (* run_target_args'
                let v4696 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4697 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v4696 = v4697 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4700 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v4696 = v4700 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4703 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v4696 = v4703 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4706 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v4696 = v4706 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4709 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v4696 = v4709 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4712 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v4696 = v4712 
                #endif
#else
                let v4715 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v4696 = v4715 
                #endif
                let v4716 : System.Threading.Tasks.Task = _run_target_args'_v4696 
                (* run_target_args'
                let v4721 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4722 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v4721 = v4722 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4725 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v4721 = v4725 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4728 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v4721 = v4728 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4731 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4732 : Async<unit> = v4731 v4716
                let _run_target_args'_v4721 = v4732 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4733 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4734 : Async<unit> = v4733 v4716
                let _run_target_args'_v4721 = v4734 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4735 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4736 : Async<unit> = v4735 v4716
                let _run_target_args'_v4721 = v4736 
                #endif
#else
                let v4737 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v4738 : Async<unit> = v4737 v4716
                let _run_target_args'_v4721 = v4738 
                #endif
                let v4739 : Async<unit> = _run_target_args'_v4721 
                do! v4739 
                (* run_target_args'
                let v4744 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4745 : int32 = null |> unbox<int32>
                let _run_target_args'_v4744 = v4745 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4748 : int32 = null |> unbox<int32>
                let _run_target_args'_v4744 = v4748 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4751 : int32 = null |> unbox<int32>
                let _run_target_args'_v4744 = v4751 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4754 : int32 = null |> unbox<int32>
                let _run_target_args'_v4744 = v4754 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4757 : int32 = null |> unbox<int32>
                let _run_target_args'_v4744 = v4757 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4760 : int32 = null |> unbox<int32>
                let _run_target_args'_v4744 = v4760 
                #endif
#else
                let v4763 : int32 = v0.ExitCode
                let _run_target_args'_v4744 = v4763 
                #endif
                let v4764 : int32 = _run_target_args'_v4744 
                return v4764 
                (* indent
                ()
            indent *)
            with ex ->
                let v4842 : exn = ex
                (* run_target_args'
                let v4843 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v4844 : string = $"%A{v4842}"
                let _run_target_args'_v4843 = v4844 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v4847 : string = $"%A{v4842}"
                let _run_target_args'_v4843 = v4847 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v4850 : string = $"%A{v4842}"
                let _run_target_args'_v4843 = v4850 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v4853 : string = $"%A{v4842}"
                let _run_target_args'_v4843 = v4853 
                #endif
#if FABLE_COMPILER_PYTHON
                let v4856 : string = $"%A{v4842}"
                let _run_target_args'_v4843 = v4856 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v4859 : string = $"%A{v4842}"
                let _run_target_args'_v4843 = v4859 
                #endif
#else
                let v4862 : string = $"{v4842.GetType ()}: {v4842.Message}"
                let _run_target_args'_v4843 = v4862 
                #endif
                let v4863 : string = _run_target_args'_v4843 
                (* run_target_args'
                let v4868 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v4869 : (string -> unit) = v1.Push
                v4869 v4863
                #endif
                // run_target_args' is_unit
                let v4870 : System.Threading.Tasks.TaskCanceledException = v4842 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v4873 : unit = ()
                let v4874 : (unit -> unit) = closure25(v4870)
                let v4875 : unit = (fun () -> v4874 (); v4873) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v7032 : Async<int32> = _let'_v4693 
    let _run_target_args'_v3 = v7032 
    #endif
#else
    let v7033 : unit = ()
    let _let'_v7033 =
        async {
            try
                (* run_target_args'
                let v7036 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7037 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7036 = v7037 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7040 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7036 = v7040 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7043 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7036 = v7043 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7046 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7036 = v7046 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7049 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7036 = v7049 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7052 : System.Threading.Tasks.Task = null |> unbox<System.Threading.Tasks.Task>
                let _run_target_args'_v7036 = v7052 
                #endif
#else
                let v7055 : System.Threading.Tasks.Task = v0.WaitForExitAsync v2 
                let _run_target_args'_v7036 = v7055 
                #endif
                let v7056 : System.Threading.Tasks.Task = _run_target_args'_v7036 
                (* run_target_args'
                let v7061 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7062 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v7061 = v7062 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7065 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v7061 = v7065 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7068 : Async<unit> = null |> unbox<Async<unit>>
                let _run_target_args'_v7061 = v7068 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7071 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7072 : Async<unit> = v7071 v7056
                let _run_target_args'_v7061 = v7072 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7073 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7074 : Async<unit> = v7073 v7056
                let _run_target_args'_v7061 = v7074 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7075 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7076 : Async<unit> = v7075 v7056
                let _run_target_args'_v7061 = v7076 
                #endif
#else
                let v7077 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                let v7078 : Async<unit> = v7077 v7056
                let _run_target_args'_v7061 = v7078 
                #endif
                let v7079 : Async<unit> = _run_target_args'_v7061 
                do! v7079 
                (* run_target_args'
                let v7084 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7085 : int32 = null |> unbox<int32>
                let _run_target_args'_v7084 = v7085 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7088 : int32 = null |> unbox<int32>
                let _run_target_args'_v7084 = v7088 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7091 : int32 = null |> unbox<int32>
                let _run_target_args'_v7084 = v7091 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7094 : int32 = null |> unbox<int32>
                let _run_target_args'_v7084 = v7094 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7097 : int32 = null |> unbox<int32>
                let _run_target_args'_v7084 = v7097 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7100 : int32 = null |> unbox<int32>
                let _run_target_args'_v7084 = v7100 
                #endif
#else
                let v7103 : int32 = v0.ExitCode
                let _run_target_args'_v7084 = v7103 
                #endif
                let v7104 : int32 = _run_target_args'_v7084 
                return v7104 
                (* indent
                ()
            indent *)
            with ex ->
                let v7182 : exn = ex
                (* run_target_args'
                let v7183 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v7184 : string = $"%A{v7182}"
                let _run_target_args'_v7183 = v7184 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v7187 : string = $"%A{v7182}"
                let _run_target_args'_v7183 = v7187 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v7190 : string = $"%A{v7182}"
                let _run_target_args'_v7183 = v7190 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v7193 : string = $"%A{v7182}"
                let _run_target_args'_v7183 = v7193 
                #endif
#if FABLE_COMPILER_PYTHON
                let v7196 : string = $"%A{v7182}"
                let _run_target_args'_v7183 = v7196 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v7199 : string = $"%A{v7182}"
                let _run_target_args'_v7183 = v7199 
                #endif
#else
                let v7202 : string = $"{v7182.GetType ()}: {v7182.Message}"
                let _run_target_args'_v7183 = v7202 
                #endif
                let v7203 : string = _run_target_args'_v7183 
                (* run_target_args'
                let v7208 : unit = ()
                run_target_args' *)
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                #endif
#if FABLE_COMPILER_RUST && WASM
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                #endif
#if FABLE_COMPILER_PYTHON
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                #endif
#else
                let v7209 : (string -> unit) = v1.Push
                v7209 v7203
                #endif
                // run_target_args' is_unit
                let v7210 : System.Threading.Tasks.TaskCanceledException = v7182 |> unbox<System.Threading.Tasks.TaskCanceledException>
                let v7213 : unit = ()
                let v7214 : (unit -> unit) = closure25(v7210)
                let v7215 : unit = (fun () -> v7214 (); v7213) ()
                return -2147483648 
                (* indent
                ()
            indent *)
            (* try_unit
            try_unit *)
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v9372 : Async<int32> = _let'_v7033 
    let _run_target_args'_v3 = v9372 
    #endif
    let v9373 : Async<int32> = _run_target_args'_v3 
    v9373
and method57 () : string =
    let v0 : string = "\n"
    v0
and method59 (v0 : int32, v1 : int32) : string =
    let v2 : string = method14()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure7(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "exit_code"
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
    let v48 : string = "output_length"
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
and method58 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method59(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method18(v13)
and closure26 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method7(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method8(v20, v21, v22, v23, v24, v25)
        let v39 : string = method39()
        let v40 : int32 = v1.Length
        let v41 : string = method58(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method19(v41)
and method24 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    (* run_target_args'
    let v7 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v7 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _run_target_args'_v7 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : unit = ()
    let _let'_v17 =
        async {
            (* run_target_args'
            let v20 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v21 : int32, v22 : string) = null |> unbox<struct (int32 * string)>
            return struct (v21, v22) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v27 : int32, v28 : string) = null |> unbox<struct (int32 * string)>
            return struct (v27, v28) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v33 : int32, v34 : string) = null |> unbox<struct (int32 * string)>
            return struct (v33, v34) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v39 : int32, v40 : string) = null |> unbox<struct (int32 * string)>
            return struct (v39, v40) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v45 : int32, v46 : string) = null |> unbox<struct (int32 * string)>
            return struct (v45, v46) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v51 : int32, v52 : string) = null |> unbox<struct (int32 * string)>
            return struct (v51, v52) 
            #endif
#else
            let v57 : US6 = method25(v0)
            let struct (v68 : string, v69 : US5) =
                match v57 with
                | US6_1(v60) -> (* Error *)
                    let v61 : string = $"resultm.get / Result value was Error: {v60}"
                    failwith<struct (string * US5)> v61
                | US6_0(v58, v59) -> (* Ok *)
                    struct (v58, v59)
            let v70 : (string -> US5) = method5()
            let v71 : US5 option = v6 |> Option.map v70 
            let v82 : US5 = US5_1
            let v83 : US5 = v71 |> Option.defaultValue v82 
            let v90 : string =
                match v83 with
                | US5_1 -> (* None *)
                    let v88 : string = ""
                    v88
                | US5_0(v87) -> (* Some *)
                    v87
            let v91 : unit = ()
            let v92 : (unit -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v69, v68)
            let v93 : unit = (fun () -> v92 (); v91) ()
            let v133 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v137 : string =
                match v69 with
                | US5_1 -> (* None *)
                    let v135 : string = ""
                    v135
                | US5_0(v134) -> (* Some *)
                    v134
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v137,
              StandardOutputEncoding = v133,
              WorkingDirectory = v90,
              FileName = v68,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v138 : System.Diagnostics.ProcessStartInfo = start_info
            let v139 : (struct (string * string) []) = method42(v0, v1, v2, v3, v4, v5, v6)
            let v140 : int32 = v139.Length
            let v141 : Mut5 = {l0 = 0} : Mut5
            while method27(v140, v141) do
                let v143 : int32 = v141.l0
                let struct (v144 : string, v145 : string) = v139.[int v143]
                v138.EnvironmentVariables.[v144] <- v145 
                let v146 : int32 = v143 + 1
                v141.l0 <- v146
                ()
            let v147 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v138)
            use v147 = v147 
            let v148 : System.Diagnostics.Process = v147 
            let v149 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v150 : System.Collections.Concurrent.ConcurrentStack<string> = v149 ()
            let v151 : bool = false
            let v152 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v148, v150, v151)
            v148.OutputDataReceived.Add v152 
            let v153 : bool = true
            let v154 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v148, v150, v153)
            v148.ErrorDataReceived.Add v154 
            let v155 : (unit -> bool) = v148.Start
            let v156 : bool = v155 ()
            let v157 : bool = v156 = false
            if v157 then
                let v158 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v158
            let v159 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v159 v148
            let v160 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v160 v148
            let v161 : (System.Threading.CancellationToken -> US15) = method50()
            let v162 : US15 option = v1 |> Option.map v161 
            let v173 : US15 = US15_1
            let v174 : US15 = v162 |> Option.defaultValue v173 
            let v181 : System.Threading.CancellationToken =
                match v174 with
                | US15_1 -> (* None *)
                    let v179 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v179
                | US15_0(v178) -> (* Some *)
                    v178
            let v182 : Async<System.Threading.CancellationToken> = method51(v181)
            let! v182 = v182 
            let v183 : System.Threading.CancellationToken = v182 
            let v184 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v183.Register
            let v185 : (unit -> unit) = closure24(v148)
            let v186 : System.Threading.CancellationTokenRegistration = v184 v185
            use v186 = v186 
            let v187 : System.Threading.CancellationTokenRegistration = v186 
            let v188 : Async<int32> = method54(v148, v150, v183)
            let! v188 = v188 
            let v189 : int32 = v188 
            let v190 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v191 : string seq = v190 v150
            let v194 : (string seq -> string seq) = Seq.rev
            let v195 : string seq = v194 v191
            let v198 : string = method57()
            let v199 : (string -> (string seq -> string)) = String.concat
            let v200 : (string seq -> string) = v199 v198
            let v201 : string = v200 v195
            let v205 : unit = ()
            let v206 : (unit -> unit) = closure26(v189, v201)
            let v207 : unit = (fun () -> v206 (); v205) ()
            return struct (v189, v201) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v1892 : Async<struct (int32 * string)> = _let'_v17 
    let _run_target_args'_v7 = v1892 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1893 : unit = ()
    let _let'_v1893 =
        async {
            (* run_target_args'
            let v1896 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v1897 : int32, v1898 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1897, v1898) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v1903 : int32, v1904 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1903, v1904) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v1909 : int32, v1910 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1909, v1910) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v1915 : int32, v1916 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1915, v1916) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v1921 : int32, v1922 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1921, v1922) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v1927 : int32, v1928 : string) = null |> unbox<struct (int32 * string)>
            return struct (v1927, v1928) 
            #endif
#else
            let v1933 : US6 = method25(v0)
            let struct (v1944 : string, v1945 : US5) =
                match v1933 with
                | US6_1(v1936) -> (* Error *)
                    let v1937 : string = $"resultm.get / Result value was Error: {v1936}"
                    failwith<struct (string * US5)> v1937
                | US6_0(v1934, v1935) -> (* Ok *)
                    struct (v1934, v1935)
            let v1946 : (string -> US5) = method5()
            let v1947 : US5 option = v6 |> Option.map v1946 
            let v1958 : US5 = US5_1
            let v1959 : US5 = v1947 |> Option.defaultValue v1958 
            let v1966 : string =
                match v1959 with
                | US5_1 -> (* None *)
                    let v1964 : string = ""
                    v1964
                | US5_0(v1963) -> (* Some *)
                    v1963
            let v1967 : unit = ()
            let v1968 : (unit -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v1945, v1944)
            let v1969 : unit = (fun () -> v1968 (); v1967) ()
            let v2009 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2013 : string =
                match v1945 with
                | US5_1 -> (* None *)
                    let v2011 : string = ""
                    v2011
                | US5_0(v2010) -> (* Some *)
                    v2010
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2013,
              StandardOutputEncoding = v2009,
              WorkingDirectory = v1966,
              FileName = v1944,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2014 : System.Diagnostics.ProcessStartInfo = start_info
            let v2015 : (struct (string * string) []) = method42(v0, v1, v2, v3, v4, v5, v6)
            let v2016 : int32 = v2015.Length
            let v2017 : Mut5 = {l0 = 0} : Mut5
            while method27(v2016, v2017) do
                let v2019 : int32 = v2017.l0
                let struct (v2020 : string, v2021 : string) = v2015.[int v2019]
                v2014.EnvironmentVariables.[v2020] <- v2021 
                let v2022 : int32 = v2019 + 1
                v2017.l0 <- v2022
                ()
            let v2023 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2014)
            use v2023 = v2023 
            let v2024 : System.Diagnostics.Process = v2023 
            let v2025 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2026 : System.Collections.Concurrent.ConcurrentStack<string> = v2025 ()
            let v2027 : bool = false
            let v2028 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v2024, v2026, v2027)
            v2024.OutputDataReceived.Add v2028 
            let v2029 : bool = true
            let v2030 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v2024, v2026, v2029)
            v2024.ErrorDataReceived.Add v2030 
            let v2031 : (unit -> bool) = v2024.Start
            let v2032 : bool = v2031 ()
            let v2033 : bool = v2032 = false
            if v2033 then
                let v2034 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2034
            let v2035 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v2035 v2024
            let v2036 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v2036 v2024
            let v2037 : (System.Threading.CancellationToken -> US15) = method50()
            let v2038 : US15 option = v1 |> Option.map v2037 
            let v2049 : US15 = US15_1
            let v2050 : US15 = v2038 |> Option.defaultValue v2049 
            let v2057 : System.Threading.CancellationToken =
                match v2050 with
                | US15_1 -> (* None *)
                    let v2055 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2055
                | US15_0(v2054) -> (* Some *)
                    v2054
            let v2058 : Async<System.Threading.CancellationToken> = method51(v2057)
            let! v2058 = v2058 
            let v2059 : System.Threading.CancellationToken = v2058 
            let v2060 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2059.Register
            let v2061 : (unit -> unit) = closure24(v2024)
            let v2062 : System.Threading.CancellationTokenRegistration = v2060 v2061
            use v2062 = v2062 
            let v2063 : System.Threading.CancellationTokenRegistration = v2062 
            let v2064 : Async<int32> = method54(v2024, v2026, v2059)
            let! v2064 = v2064 
            let v2065 : int32 = v2064 
            let v2066 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2067 : string seq = v2066 v2026
            let v2070 : (string seq -> string seq) = Seq.rev
            let v2071 : string seq = v2070 v2067
            let v2074 : string = method57()
            let v2075 : (string -> (string seq -> string)) = String.concat
            let v2076 : (string seq -> string) = v2075 v2074
            let v2077 : string = v2076 v2071
            let v2081 : unit = ()
            let v2082 : (unit -> unit) = closure26(v2065, v2077)
            let v2083 : unit = (fun () -> v2082 (); v2081) ()
            return struct (v2065, v2077) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v3768 : Async<struct (int32 * string)> = _let'_v1893 
    let _run_target_args'_v7 = v3768 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v3769 : unit = ()
    let _let'_v3769 =
        async {
            (* run_target_args'
            let v3772 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v3773 : int32, v3774 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3773, v3774) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v3779 : int32, v3780 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3779, v3780) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v3785 : int32, v3786 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3785, v3786) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v3791 : int32, v3792 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3791, v3792) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v3797 : int32, v3798 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3797, v3798) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v3803 : int32, v3804 : string) = null |> unbox<struct (int32 * string)>
            return struct (v3803, v3804) 
            #endif
#else
            let v3809 : US6 = method25(v0)
            let struct (v3820 : string, v3821 : US5) =
                match v3809 with
                | US6_1(v3812) -> (* Error *)
                    let v3813 : string = $"resultm.get / Result value was Error: {v3812}"
                    failwith<struct (string * US5)> v3813
                | US6_0(v3810, v3811) -> (* Ok *)
                    struct (v3810, v3811)
            let v3822 : (string -> US5) = method5()
            let v3823 : US5 option = v6 |> Option.map v3822 
            let v3834 : US5 = US5_1
            let v3835 : US5 = v3823 |> Option.defaultValue v3834 
            let v3842 : string =
                match v3835 with
                | US5_1 -> (* None *)
                    let v3840 : string = ""
                    v3840
                | US5_0(v3839) -> (* Some *)
                    v3839
            let v3843 : unit = ()
            let v3844 : (unit -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v3821, v3820)
            let v3845 : unit = (fun () -> v3844 (); v3843) ()
            let v3885 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v3889 : string =
                match v3821 with
                | US5_1 -> (* None *)
                    let v3887 : string = ""
                    v3887
                | US5_0(v3886) -> (* Some *)
                    v3886
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v3889,
              StandardOutputEncoding = v3885,
              WorkingDirectory = v3842,
              FileName = v3820,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v3890 : System.Diagnostics.ProcessStartInfo = start_info
            let v3891 : (struct (string * string) []) = method42(v0, v1, v2, v3, v4, v5, v6)
            let v3892 : int32 = v3891.Length
            let v3893 : Mut5 = {l0 = 0} : Mut5
            while method27(v3892, v3893) do
                let v3895 : int32 = v3893.l0
                let struct (v3896 : string, v3897 : string) = v3891.[int v3895]
                v3890.EnvironmentVariables.[v3896] <- v3897 
                let v3898 : int32 = v3895 + 1
                v3893.l0 <- v3898
                ()
            let v3899 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v3890)
            use v3899 = v3899 
            let v3900 : System.Diagnostics.Process = v3899 
            let v3901 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v3902 : System.Collections.Concurrent.ConcurrentStack<string> = v3901 ()
            let v3903 : bool = false
            let v3904 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v3900, v3902, v3903)
            v3900.OutputDataReceived.Add v3904 
            let v3905 : bool = true
            let v3906 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v3900, v3902, v3905)
            v3900.ErrorDataReceived.Add v3906 
            let v3907 : (unit -> bool) = v3900.Start
            let v3908 : bool = v3907 ()
            let v3909 : bool = v3908 = false
            if v3909 then
                let v3910 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v3910
            let v3911 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v3911 v3900
            let v3912 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v3912 v3900
            let v3913 : (System.Threading.CancellationToken -> US15) = method50()
            let v3914 : US15 option = v1 |> Option.map v3913 
            let v3925 : US15 = US15_1
            let v3926 : US15 = v3914 |> Option.defaultValue v3925 
            let v3933 : System.Threading.CancellationToken =
                match v3926 with
                | US15_1 -> (* None *)
                    let v3931 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v3931
                | US15_0(v3930) -> (* Some *)
                    v3930
            let v3934 : Async<System.Threading.CancellationToken> = method51(v3933)
            let! v3934 = v3934 
            let v3935 : System.Threading.CancellationToken = v3934 
            let v3936 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v3935.Register
            let v3937 : (unit -> unit) = closure24(v3900)
            let v3938 : System.Threading.CancellationTokenRegistration = v3936 v3937
            use v3938 = v3938 
            let v3939 : System.Threading.CancellationTokenRegistration = v3938 
            let v3940 : Async<int32> = method54(v3900, v3902, v3935)
            let! v3940 = v3940 
            let v3941 : int32 = v3940 
            let v3942 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v3943 : string seq = v3942 v3902
            let v3946 : (string seq -> string seq) = Seq.rev
            let v3947 : string seq = v3946 v3943
            let v3950 : string = method57()
            let v3951 : (string -> (string seq -> string)) = String.concat
            let v3952 : (string seq -> string) = v3951 v3950
            let v3953 : string = v3952 v3947
            let v3957 : unit = ()
            let v3958 : (unit -> unit) = closure26(v3941, v3953)
            let v3959 : unit = (fun () -> v3958 (); v3957) ()
            return struct (v3941, v3953) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v5644 : Async<struct (int32 * string)> = _let'_v3769 
    let _run_target_args'_v7 = v5644 
    #endif
#else
    let v5645 : unit = ()
    let _let'_v5645 =
        async {
            (* run_target_args'
            let v5648 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let struct (v5649 : int32, v5650 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5649, v5650) 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let struct (v5655 : int32, v5656 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5655, v5656) 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let struct (v5661 : int32, v5662 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5661, v5662) 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let struct (v5667 : int32, v5668 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5667, v5668) 
            #endif
#if FABLE_COMPILER_PYTHON
            let struct (v5673 : int32, v5674 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5673, v5674) 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let struct (v5679 : int32, v5680 : string) = null |> unbox<struct (int32 * string)>
            return struct (v5679, v5680) 
            #endif
#else
            let v5685 : US6 = method25(v0)
            let struct (v5696 : string, v5697 : US5) =
                match v5685 with
                | US6_1(v5688) -> (* Error *)
                    let v5689 : string = $"resultm.get / Result value was Error: {v5688}"
                    failwith<struct (string * US5)> v5689
                | US6_0(v5686, v5687) -> (* Ok *)
                    struct (v5686, v5687)
            let v5698 : (string -> US5) = method5()
            let v5699 : US5 option = v6 |> Option.map v5698 
            let v5710 : US5 = US5_1
            let v5711 : US5 = v5699 |> Option.defaultValue v5710 
            let v5718 : string =
                match v5711 with
                | US5_1 -> (* None *)
                    let v5716 : string = ""
                    v5716
                | US5_0(v5715) -> (* Some *)
                    v5715
            let v5719 : unit = ()
            let v5720 : (unit -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v5697, v5696)
            let v5721 : unit = (fun () -> v5720 (); v5719) ()
            let v5761 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v5765 : string =
                match v5697 with
                | US5_1 -> (* None *)
                    let v5763 : string = ""
                    v5763
                | US5_0(v5762) -> (* Some *)
                    v5762
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v5765,
              StandardOutputEncoding = v5761,
              WorkingDirectory = v5718,
              FileName = v5696,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v5766 : System.Diagnostics.ProcessStartInfo = start_info
            let v5767 : (struct (string * string) []) = method42(v0, v1, v2, v3, v4, v5, v6)
            let v5768 : int32 = v5767.Length
            let v5769 : Mut5 = {l0 = 0} : Mut5
            while method27(v5768, v5769) do
                let v5771 : int32 = v5769.l0
                let struct (v5772 : string, v5773 : string) = v5767.[int v5771]
                v5766.EnvironmentVariables.[v5772] <- v5773 
                let v5774 : int32 = v5771 + 1
                v5769.l0 <- v5774
                ()
            let v5775 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v5766)
            use v5775 = v5775 
            let v5776 : System.Diagnostics.Process = v5775 
            let v5777 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v5778 : System.Collections.Concurrent.ConcurrentStack<string> = v5777 ()
            let v5779 : bool = false
            let v5780 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v5776, v5778, v5779)
            v5776.OutputDataReceived.Add v5780 
            let v5781 : bool = true
            let v5782 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6, v5776, v5778, v5781)
            v5776.ErrorDataReceived.Add v5782 
            let v5783 : (unit -> bool) = v5776.Start
            let v5784 : bool = v5783 ()
            let v5785 : bool = v5784 = false
            if v5785 then
                let v5786 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v5786
            let v5787 : (System.Diagnostics.Process -> unit) = _.BeginErrorReadLine()
            v5787 v5776
            let v5788 : (System.Diagnostics.Process -> unit) = _.BeginOutputReadLine()
            v5788 v5776
            let v5789 : (System.Threading.CancellationToken -> US15) = method50()
            let v5790 : US15 option = v1 |> Option.map v5789 
            let v5801 : US15 = US15_1
            let v5802 : US15 = v5790 |> Option.defaultValue v5801 
            let v5809 : System.Threading.CancellationToken =
                match v5802 with
                | US15_1 -> (* None *)
                    let v5807 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v5807
                | US15_0(v5806) -> (* Some *)
                    v5806
            let v5810 : Async<System.Threading.CancellationToken> = method51(v5809)
            let! v5810 = v5810 
            let v5811 : System.Threading.CancellationToken = v5810 
            let v5812 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v5811.Register
            let v5813 : (unit -> unit) = closure24(v5776)
            let v5814 : System.Threading.CancellationTokenRegistration = v5812 v5813
            use v5814 = v5814 
            let v5815 : System.Threading.CancellationTokenRegistration = v5814 
            let v5816 : Async<int32> = method54(v5776, v5778, v5811)
            let! v5816 = v5816 
            let v5817 : int32 = v5816 
            let v5818 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v5819 : string seq = v5818 v5778
            let v5822 : (string seq -> string seq) = Seq.rev
            let v5823 : string seq = v5822 v5819
            let v5826 : string = method57()
            let v5827 : (string -> (string seq -> string)) = String.concat
            let v5828 : (string seq -> string) = v5827 v5826
            let v5829 : string = v5828 v5823
            let v5833 : unit = ()
            let v5834 : (unit -> unit) = closure26(v5817, v5829)
            let v5835 : unit = (fun () -> v5834 (); v5833) ()
            return struct (v5817, v5829) 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v7520 : Async<struct (int32 * string)> = _let'_v5645 
    let _run_target_args'_v7 = v7520 
    #endif
    let v7521 : Async<struct (int32 * string)> = _run_target_args'_v7 
    v7521
and method23 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method24(v0, v1, v2, v3, v4, v5, v6)
and method22 (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method23(v0, v1, v2, v3, v4, v6, v5)
and closure13 () (v0 : string) : Async<struct (int32 * string)> =
    method22(v0)
and closure27 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method23(v0, v1, v2, v3, v4, v5, v6)
and closure28 () (v0 : (Heap0 -> Heap0)) : struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : string = ""
    let v7 : Heap0 = {l0 = v6; l1 = v1; l2 = v2; l3 = v3; l4 = v4; l5 = true; l6 = v5} : Heap0
    let v8 : Heap0 = v0 v7
    let v9 : string = v8.l0
    let v10 : System.Threading.CancellationToken option = v8.l1
    let v11 : (struct (string * string) []) = v8.l2
    let v12 : (struct (int32 * string * bool) -> Async<unit>) option = v8.l3
    let v13 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = v8.l4
    let v14 : bool = v8.l5
    let v15 : string option = v8.l6
    struct (v9, v10, v11, v12, v13, v14, v15)
and method62 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US9 =
            if v3 then
                US9_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US9_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US9_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US9_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US9_1
        let v23 : char =
            match v19 with
            | US9_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US9_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method62(v0, v25)
and method63 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
    let v5 : bool = "" = v1
    let v121 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : char list = '`' :: v10 
            let v16 : char list = '\\' :: v13 
            let v19 : (char list -> (char [])) = List.toArray
            let v20 : (char []) = v19 v16
            let v23 : string = $"parsing.none_of / unexpected end of input / chars: %A{v20} / s: %A{struct (v2, v3, v4)}"
            US7_1(v23)
        else
            let v27 : char = v1.[int 0]
            let v28 : int64 = 0L
            let v29 : bool = method62(v27, v28)
            let v30 : bool = v29 = false
            if v30 then
                let v31 : (string -> int32) = String.length
                let v32 : int32 = v31 v1
                let v35 : int32 = 1 |> int32 
                let v42 : int32 = v32 |> int32 
                let v49 : int32 = v42 - 1
                let v50 : string = v1.[int v35..int v49]
                let v54 : (char -> string) = _.ToString()
                let v55 : string = v54 v27
                let v58 : int32 = v55.Length
                let v59 : (char []) = Array.zeroCreate<char> (v58)
                let v60 : Mut5 = {l0 = 0} : Mut5
                while method27(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method28()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method29(v73, v2, v3, v4)
                US7_0(v27, v50, v95, v96, v97)
            else
                let v99 : char list = []
                let v100 : char list = ' ' :: v99 
                let v103 : char list = '"' :: v100 
                let v106 : char list = '`' :: v103 
                let v109 : char list = '\\' :: v106 
                let v112 : (char list -> (char [])) = List.toArray
                let v113 : (char []) = v112 v109
                let v116 : string = $"parsing.none_of / unexpected char: '{v27}' / chars: %A{v113} / s: %A{struct (v2, v3, v4)}"
                US7_1(v116)
    match v121 with
    | US7_1(v137) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US7_0(v122, v123, v124, v125, v126) -> (* Ok *)
        let v127 : (char -> string) = _.ToString()
        let v128 : string = v127 v122
        let v131 : string = v0 + v128 
        method63(v131, v123, v124, v125, v126)
and method65 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US9 =
            if v3 then
                US9_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US9_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US9_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US9_1
        let v19 : char =
            match v15 with
            | US9_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US9_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method65(v0, v21)
and closure30 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US8 =
    let v4 : bool = "" = v0
    let v126 : US7 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'\\'}' / s: %A{struct (v1, v2, v3)}"
            US7_1(v5)
        else
            let v9 : char = v0.[int 0]
            let v10 : bool = v9 = '\\'
            if v10 then
                let v11 : (string -> int32) = String.length
                let v12 : int32 = v11 v0
                let v15 : int32 = 1 |> int32 
                let v22 : int32 = v12 |> int32 
                let v29 : int32 = v22 - 1
                let v30 : string = v0.[int v15..int v29]
                let v34 : (char -> string) = _.ToString()
                let v35 : string = v34 v9
                let v38 : int32 = v35.Length
                let v39 : (char []) = Array.zeroCreate<char> (v38)
                let v40 : Mut5 = {l0 = 0} : Mut5
                while method27(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method28()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method29(v53, v1, v2, v3)
                US7_0(v9, v30, v75, v76, v77)
            else
                let v79 : string = "\n"
                let v80 : int32 = v0.IndexOf v79 
                let v83 : int32 = v80 - 1
                let v84 : bool = -2 = v83
                let v91 : int32 =
                    if v84 then
                        let v85 : (string -> int32) = String.length
                        let v86 : int32 = v85 v0
                        let v89 : int32 = v86 + 1
                        v89
                    else
                        let v90 : int32 = v83 + 1
                        v90
                let v92 : int32 = 0 |> int32 
                let v99 : int32 = v91 |> int32 
                let v106 : int32 = v99 - 1
                let v107 : string = v0.[int v92..int v106]
                let v111 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v107}"
                let v114 : int32 = v3 - 1
                let v115 : int32 = 0
                let v116 : (string -> string) = method30(v114, v115)
                let v117 : string = ""
                let v118 : string = v116 v117
                let v119 : string = "^"
                let v120 : string = v118 + v119 
                let v121 : string = $"{v111}
{v120}
"
                US7_1(v121)
    let v210 : US7 =
        match v126 with
        | US7_1(v207) -> (* Error *)
            US7_1(v207)
        | US7_0(v127, v128, v129, v130, v131) -> (* Ok *)
            let v132 : bool = "" = v128
            if v132 then
                let v133 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v129, v130, v131)}"
                US7_1(v133)
            else
                let v137 : char = v128.[int 0]
                let v138 : (string -> int32) = String.length
                let v139 : int32 = v138 v128
                let v142 : int32 = 1 |> int32 
                let v149 : int32 = v139 |> int32 
                let v156 : int32 = v149 - 1
                let v157 : string = v128.[int v142..int v156]
                let v161 : (char -> string) = _.ToString()
                let v162 : string = v161 v137
                let v165 : int32 = v162.Length
                let v166 : (char []) = Array.zeroCreate<char> (v165)
                let v167 : Mut5 = {l0 = 0} : Mut5
                while method27(v165, v167) do
                    let v169 : int32 = v167.l0
                    let v170 : char = v162.[int v169]
                    v166.[int v169] <- v170
                    let v171 : int32 = v169 + 1
                    v167.l0 <- v171
                    ()
                let v172 : char list = v166 |> Array.toList
                let v175 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v176 : (char -> (UH0 -> UH0)) = method28()
                let v177 : (char list -> (UH0 -> UH0)) = v175 v176
                let v178 : (UH0 -> UH0) = v177 v172
                let v179 : UH0 = UH0_0
                let v180 : UH0 = v178 v179
                let struct (v202 : System.Text.StringBuilder, v203 : int32, v204 : int32) = method29(v180, v129, v130, v131)
                US7_0(v137, v157, v202, v203, v204)
    match v210 with
    | US7_1(v226) -> (* Error *)
        US8_1(v226)
    | US7_0(v211, v212, v213, v214, v215) -> (* Ok *)
        let v216 : (char -> string) = _.ToString()
        let v217 : string = v216 '\\'
        let v220 : (char -> string) = _.ToString()
        let v221 : string = v220 v211
        let v224 : string = v217 + v221 
        US8_0(v224, v212, v213, v214, v215)
and closure31 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US8 =
    let v4 : bool = "" = v0
    let v126 : US7 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / c: '{'`'}' / s: %A{struct (v1, v2, v3)}"
            US7_1(v5)
        else
            let v9 : char = v0.[int 0]
            let v10 : bool = v9 = '`'
            if v10 then
                let v11 : (string -> int32) = String.length
                let v12 : int32 = v11 v0
                let v15 : int32 = 1 |> int32 
                let v22 : int32 = v12 |> int32 
                let v29 : int32 = v22 - 1
                let v30 : string = v0.[int v15..int v29]
                let v34 : (char -> string) = _.ToString()
                let v35 : string = v34 v9
                let v38 : int32 = v35.Length
                let v39 : (char []) = Array.zeroCreate<char> (v38)
                let v40 : Mut5 = {l0 = 0} : Mut5
                while method27(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method28()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method29(v53, v1, v2, v3)
                US7_0(v9, v30, v75, v76, v77)
            else
                let v79 : string = "\n"
                let v80 : int32 = v0.IndexOf v79 
                let v83 : int32 = v80 - 1
                let v84 : bool = -2 = v83
                let v91 : int32 =
                    if v84 then
                        let v85 : (string -> int32) = String.length
                        let v86 : int32 = v85 v0
                        let v89 : int32 = v86 + 1
                        v89
                    else
                        let v90 : int32 = v83 + 1
                        v90
                let v92 : int32 = 0 |> int32 
                let v99 : int32 = v91 |> int32 
                let v106 : int32 = v99 - 1
                let v107 : string = v0.[int v92..int v106]
                let v111 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v107}"
                let v114 : int32 = v3 - 1
                let v115 : int32 = 0
                let v116 : (string -> string) = method30(v114, v115)
                let v117 : string = ""
                let v118 : string = v116 v117
                let v119 : string = "^"
                let v120 : string = v118 + v119 
                let v121 : string = $"{v111}
{v120}
"
                US7_1(v121)
    let v210 : US7 =
        match v126 with
        | US7_1(v207) -> (* Error *)
            US7_1(v207)
        | US7_0(v127, v128, v129, v130, v131) -> (* Ok *)
            let v132 : bool = "" = v128
            if v132 then
                let v133 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v129, v130, v131)}"
                US7_1(v133)
            else
                let v137 : char = v128.[int 0]
                let v138 : (string -> int32) = String.length
                let v139 : int32 = v138 v128
                let v142 : int32 = 1 |> int32 
                let v149 : int32 = v139 |> int32 
                let v156 : int32 = v149 - 1
                let v157 : string = v128.[int v142..int v156]
                let v161 : (char -> string) = _.ToString()
                let v162 : string = v161 v137
                let v165 : int32 = v162.Length
                let v166 : (char []) = Array.zeroCreate<char> (v165)
                let v167 : Mut5 = {l0 = 0} : Mut5
                while method27(v165, v167) do
                    let v169 : int32 = v167.l0
                    let v170 : char = v162.[int v169]
                    v166.[int v169] <- v170
                    let v171 : int32 = v169 + 1
                    v167.l0 <- v171
                    ()
                let v172 : char list = v166 |> Array.toList
                let v175 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v176 : (char -> (UH0 -> UH0)) = method28()
                let v177 : (char list -> (UH0 -> UH0)) = v175 v176
                let v178 : (UH0 -> UH0) = v177 v172
                let v179 : UH0 = UH0_0
                let v180 : UH0 = v178 v179
                let struct (v202 : System.Text.StringBuilder, v203 : int32, v204 : int32) = method29(v180, v129, v130, v131)
                US7_0(v137, v157, v202, v203, v204)
    match v210 with
    | US7_1(v226) -> (* Error *)
        US8_1(v226)
    | US7_0(v211, v212, v213, v214, v215) -> (* Ok *)
        let v216 : (char -> string) = _.ToString()
        let v217 : string = v216 '`'
        let v220 : (char -> string) = _.ToString()
        let v221 : string = v220 v211
        let v224 : string = v217 + v221 
        US8_0(v224, v212, v213, v214, v215)
and method66 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US8 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US8 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US8_1(v15) -> (* Error *)
            method66(v0, v1, v2, v3, v8)
        | US8_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US8_1(v5)
and method67 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method67(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method64 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v115 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v10 : char list = '`' :: v7 
            let v13 : char list = '\\' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US7_1(v20)
        else
            let v24 : char = v1.[int 0]
            let v25 : int64 = 0L
            let v26 : bool = method65(v24, v25)
            let v27 : bool = v26 = false
            if v27 then
                let v28 : (string -> int32) = String.length
                let v29 : int32 = v28 v1
                let v32 : int32 = 1 |> int32 
                let v39 : int32 = v29 |> int32 
                let v46 : int32 = v39 - 1
                let v47 : string = v1.[int v32..int v46]
                let v51 : (char -> string) = _.ToString()
                let v52 : string = v51 v24
                let v55 : int32 = v52.Length
                let v56 : (char []) = Array.zeroCreate<char> (v55)
                let v57 : Mut5 = {l0 = 0} : Mut5
                while method27(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method28()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method29(v70, v2, v3, v4)
                US7_0(v24, v47, v92, v93, v94)
            else
                let v96 : char list = []
                let v97 : char list = '"' :: v96 
                let v100 : char list = '`' :: v97 
                let v103 : char list = '\\' :: v100 
                let v106 : (char list -> (char [])) = List.toArray
                let v107 : (char []) = v106 v103
                let v110 : string = $"parsing.none_of / unexpected char: '{v24}' / chars: %A{v107} / s: %A{struct (v2, v3, v4)}"
                US7_1(v110)
    let v129 : US8 =
        match v115 with
        | US7_1(v126) -> (* Error *)
            US8_1(v126)
        | US7_0(v116, v117, v118, v119, v120) -> (* Ok *)
            let v121 : (char -> string) = _.ToString()
            let v122 : string = v121 v116
            US8_0(v122, v117, v118, v119, v120)
    let v143 : US8 =
        match v129 with
        | US8_1(v135) -> (* Error *)
            let v136 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure30()
            let v137 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure31()
            let v138 : UH3 = UH3_0
            let v139 : UH3 = UH3_1(v137, v138)
            let v140 : UH3 = UH3_1(v136, v139)
            method66(v1, v2, v3, v4, v140)
        | US8_0(v130, v131, v132, v133, v134) -> (* Ok *)
            v129
    match v143 with
    | US8_1(v151) -> (* Error *)
        let v152 : UH2 = UH2_0
        let v153 : UH2 = method67(v0, v152)
        US17_0(v153, v1, v2, v3, v4)
    | US8_0(v144, v145, v146, v147, v148) -> (* Ok *)
        let v149 : UH2 = UH2_1(v144, v0)
        method64(v149, v145, v146, v147, v148)
and method68 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method68(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method69 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v115 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v10 : char list = '`' :: v7 
            let v13 : char list = '\\' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US7_1(v20)
        else
            let v24 : char = v1.[int 0]
            let v25 : int64 = 0L
            let v26 : bool = method65(v24, v25)
            let v27 : bool = v26 = false
            if v27 then
                let v28 : (string -> int32) = String.length
                let v29 : int32 = v28 v1
                let v32 : int32 = 1 |> int32 
                let v39 : int32 = v29 |> int32 
                let v46 : int32 = v39 - 1
                let v47 : string = v1.[int v32..int v46]
                let v51 : (char -> string) = _.ToString()
                let v52 : string = v51 v24
                let v55 : int32 = v52.Length
                let v56 : (char []) = Array.zeroCreate<char> (v55)
                let v57 : Mut5 = {l0 = 0} : Mut5
                while method27(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method28()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method29(v70, v2, v3, v4)
                US7_0(v24, v47, v92, v93, v94)
            else
                let v96 : char list = []
                let v97 : char list = '"' :: v96 
                let v100 : char list = '`' :: v97 
                let v103 : char list = '\\' :: v100 
                let v106 : (char list -> (char [])) = List.toArray
                let v107 : (char []) = v106 v103
                let v110 : string = $"parsing.none_of / unexpected char: '{v24}' / chars: %A{v107} / s: %A{struct (v2, v3, v4)}"
                US7_1(v110)
    let v129 : US8 =
        match v115 with
        | US7_1(v126) -> (* Error *)
            US8_1(v126)
        | US7_0(v116, v117, v118, v119, v120) -> (* Ok *)
            let v121 : (char -> string) = _.ToString()
            let v122 : string = v121 v116
            US8_0(v122, v117, v118, v119, v120)
    match v129 with
    | US8_1(v137) -> (* Error *)
        let v138 : UH2 = UH2_0
        let v139 : UH2 = method67(v0, v138)
        US17_0(v139, v1, v2, v3, v4)
    | US8_0(v130, v131, v132, v133, v134) -> (* Ok *)
        let v135 : UH2 = UH2_1(v130, v0)
        method69(v135, v131, v132, v133, v134)
and method61 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v121 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : char list = '`' :: v10 
            let v16 : char list = '\\' :: v13 
            let v19 : (char list -> (char [])) = List.toArray
            let v20 : (char []) = v19 v16
            let v23 : string = $"parsing.none_of / unexpected end of input / chars: %A{v20} / s: %A{struct (v2, v3, v4)}"
            US7_1(v23)
        else
            let v27 : char = v1.[int 0]
            let v28 : int64 = 0L
            let v29 : bool = method62(v27, v28)
            let v30 : bool = v29 = false
            if v30 then
                let v31 : (string -> int32) = String.length
                let v32 : int32 = v31 v1
                let v35 : int32 = 1 |> int32 
                let v42 : int32 = v32 |> int32 
                let v49 : int32 = v42 - 1
                let v50 : string = v1.[int v35..int v49]
                let v54 : (char -> string) = _.ToString()
                let v55 : string = v54 v27
                let v58 : int32 = v55.Length
                let v59 : (char []) = Array.zeroCreate<char> (v58)
                let v60 : Mut5 = {l0 = 0} : Mut5
                while method27(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method28()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method29(v73, v2, v3, v4)
                US7_0(v27, v50, v95, v96, v97)
            else
                let v99 : char list = []
                let v100 : char list = ' ' :: v99 
                let v103 : char list = '"' :: v100 
                let v106 : char list = '`' :: v103 
                let v109 : char list = '\\' :: v106 
                let v112 : (char list -> (char [])) = List.toArray
                let v113 : (char []) = v112 v109
                let v116 : string = $"parsing.none_of / unexpected char: '{v27}' / chars: %A{v113} / s: %A{struct (v2, v3, v4)}"
                US7_1(v116)
    let v140 : US8 =
        match v121 with
        | US7_1(v137) -> (* Error *)
            US8_1(v137)
        | US7_0(v122, v123, v124, v125, v126) -> (* Ok *)
            let v127 : (char -> string) = _.ToString()
            let v128 : string = v127 v122
            let struct (v131 : string, v132 : string, v133 : System.Text.StringBuilder, v134 : int32, v135 : int32) = method63(v128, v123, v124, v125, v126)
            US8_0(v131, v132, v133, v134, v135)
    let v517 : US8 =
        match v140 with
        | US8_1(v146) -> (* Error *)
            let v268 : US7 =
                if v5 then
                    let v147 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v2, v3, v4)}"
                    US7_1(v147)
                else
                    let v151 : char = v1.[int 0]
                    let v152 : bool = v151 = '"'
                    if v152 then
                        let v153 : (string -> int32) = String.length
                        let v154 : int32 = v153 v1
                        let v157 : int32 = 1 |> int32 
                        let v164 : int32 = v154 |> int32 
                        let v171 : int32 = v164 - 1
                        let v172 : string = v1.[int v157..int v171]
                        let v176 : (char -> string) = _.ToString()
                        let v177 : string = v176 v151
                        let v180 : int32 = v177.Length
                        let v181 : (char []) = Array.zeroCreate<char> (v180)
                        let v182 : Mut5 = {l0 = 0} : Mut5
                        while method27(v180, v182) do
                            let v184 : int32 = v182.l0
                            let v185 : char = v177.[int v184]
                            v181.[int v184] <- v185
                            let v186 : int32 = v184 + 1
                            v182.l0 <- v186
                            ()
                        let v187 : char list = v181 |> Array.toList
                        let v190 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v191 : (char -> (UH0 -> UH0)) = method28()
                        let v192 : (char list -> (UH0 -> UH0)) = v190 v191
                        let v193 : (UH0 -> UH0) = v192 v187
                        let v194 : UH0 = UH0_0
                        let v195 : UH0 = v193 v194
                        let struct (v217 : System.Text.StringBuilder, v218 : int32, v219 : int32) = method29(v195, v2, v3, v4)
                        US7_0(v151, v172, v217, v218, v219)
                    else
                        let v221 : string = "\n"
                        let v222 : int32 = v1.IndexOf v221 
                        let v225 : int32 = v222 - 1
                        let v226 : bool = -2 = v225
                        let v233 : int32 =
                            if v226 then
                                let v227 : (string -> int32) = String.length
                                let v228 : int32 = v227 v1
                                let v231 : int32 = v228 + 1
                                v231
                            else
                                let v232 : int32 = v225 + 1
                                v232
                        let v234 : int32 = 0 |> int32 
                        let v241 : int32 = v233 |> int32 
                        let v248 : int32 = v241 - 1
                        let v249 : string = v1.[int v234..int v248]
                        let v253 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v249}"
                        let v256 : int32 = v4 - 1
                        let v257 : int32 = 0
                        let v258 : (string -> string) = method30(v256, v257)
                        let v259 : string = ""
                        let v260 : string = v258 v259
                        let v261 : string = "^"
                        let v262 : string = v260 + v261 
                        let v263 : string = $"{v253}
{v262}
"
                        US7_1(v263)
            let v452 : US8 =
                match v268 with
                | US7_1(v449) -> (* Error *)
                    US8_1(v449)
                | US7_0(v269, v270, v271, v272, v273) -> (* Ok *)
                    let v274 : UH2 = UH2_0
                    let v275 : US17 = method64(v274, v270, v271, v272, v273)
                    let v302 : US8 =
                        match v275 with
                        | US17_1(v299) -> (* Error *)
                            US8_1(v299)
                        | US17_0(v276, v277, v278, v279, v280) -> (* Ok *)
                            let v281 : string list = []
                            let v282 : string list = method68(v276, v281)
                            let v283 : unit = ()
                            let _let'_v283 =
                                seq {
                                    yield! v282 
                                    (* indent
                                    ()
                                indent *)
                                }
                                (* indent
                                ()
                            indent *)
                            let v286 : string seq = _let'_v283 
                            let v292 : (string -> (string seq -> string)) = String.concat
                            let v293 : string = ""
                            let v294 : (string seq -> string) = v292 v293
                            let v295 : string = v294 v286
                            US8_0(v295, v277, v278, v279, v280)
                    match v302 with
                    | US8_1(v444) -> (* Error *)
                        let v445 : string = "parsing.between / expected content"
                        US8_1(v445)
                    | US8_0(v303, v304, v305, v306, v307) -> (* Ok *)
                        let v308 : bool = "" = v304
                        let v430 : US7 =
                            if v308 then
                                let v309 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v305, v306, v307)}"
                                US7_1(v309)
                            else
                                let v313 : char = v304.[int 0]
                                let v314 : bool = v313 = '"'
                                if v314 then
                                    let v315 : (string -> int32) = String.length
                                    let v316 : int32 = v315 v304
                                    let v319 : int32 = 1 |> int32 
                                    let v326 : int32 = v316 |> int32 
                                    let v333 : int32 = v326 - 1
                                    let v334 : string = v304.[int v319..int v333]
                                    let v338 : (char -> string) = _.ToString()
                                    let v339 : string = v338 v313
                                    let v342 : int32 = v339.Length
                                    let v343 : (char []) = Array.zeroCreate<char> (v342)
                                    let v344 : Mut5 = {l0 = 0} : Mut5
                                    while method27(v342, v344) do
                                        let v346 : int32 = v344.l0
                                        let v347 : char = v339.[int v346]
                                        v343.[int v346] <- v347
                                        let v348 : int32 = v346 + 1
                                        v344.l0 <- v348
                                        ()
                                    let v349 : char list = v343 |> Array.toList
                                    let v352 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v353 : (char -> (UH0 -> UH0)) = method28()
                                    let v354 : (char list -> (UH0 -> UH0)) = v352 v353
                                    let v355 : (UH0 -> UH0) = v354 v349
                                    let v356 : UH0 = UH0_0
                                    let v357 : UH0 = v355 v356
                                    let struct (v379 : System.Text.StringBuilder, v380 : int32, v381 : int32) = method29(v357, v305, v306, v307)
                                    US7_0(v313, v334, v379, v380, v381)
                                else
                                    let v383 : string = "\n"
                                    let v384 : int32 = v304.IndexOf v383 
                                    let v387 : int32 = v384 - 1
                                    let v388 : bool = -2 = v387
                                    let v395 : int32 =
                                        if v388 then
                                            let v389 : (string -> int32) = String.length
                                            let v390 : int32 = v389 v304
                                            let v393 : int32 = v390 + 1
                                            v393
                                        else
                                            let v394 : int32 = v387 + 1
                                            v394
                                    let v396 : int32 = 0 |> int32 
                                    let v403 : int32 = v395 |> int32 
                                    let v410 : int32 = v403 - 1
                                    let v411 : string = v304.[int v396..int v410]
                                    let v415 : string = $"parsing.p_char / expected: '{'"'}' / line: {v306} / col: {v307}
{v305}{v411}"
                                    let v418 : int32 = v307 - 1
                                    let v419 : int32 = 0
                                    let v420 : (string -> string) = method30(v418, v419)
                                    let v421 : string = ""
                                    let v422 : string = v420 v421
                                    let v423 : string = "^"
                                    let v424 : string = v422 + v423 
                                    let v425 : string = $"{v415}
{v424}
"
                                    US7_1(v425)
                        match v430 with
                        | US7_1(v437) -> (* Error *)
                            let v438 : string = $"parsing.between / expected closing delimiter / e: %A{v437} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v270, v271, v272, v273)} / rest2: %A{struct (v304, v305, v306, v307)}"
                            US8_1(v438)
                        | US7_0(v431, v432, v433, v434, v435) -> (* Ok *)
                            US8_0(v303, v432, v433, v434, v435)
            match v452 with
            | US8_1(v458) -> (* Error *)
                let v459 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure30()
                let v460 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure31()
                let v461 : UH3 = UH3_0
                let v462 : UH3 = UH3_1(v460, v461)
                let v463 : UH3 = UH3_1(v459, v462)
                let v464 : US8 = method66(v1, v2, v3, v4, v463)
                let v475 : US8 =
                    match v464 with
                    | US8_1(v472) -> (* Error *)
                        US8_1(v472)
                    | US8_0(v465, v466, v467, v468, v469) -> (* Ok *)
                        let v470 : string = ""
                        US8_0(v470, v466, v467, v468, v469)
                let v486 : US17 =
                    match v475 with
                    | US8_1(v483) -> (* Error *)
                        US17_1(v483)
                    | US8_0(v476, v477, v478, v479, v480) -> (* Ok *)
                        let v481 : UH2 = UH2_0
                        method69(v481, v477, v478, v479, v480)
                match v486 with
                | US17_1(v510) -> (* Error *)
                    US8_1(v510)
                | US17_0(v487, v488, v489, v490, v491) -> (* Ok *)
                    let v492 : string list = []
                    let v493 : string list = method68(v487, v492)
                    let v494 : unit = ()
                    let _let'_v494 =
                        seq {
                            yield! v493 
                            (* indent
                            ()
                        indent *)
                        }
                        (* indent
                        ()
                    indent *)
                    let v497 : string seq = _let'_v494 
                    let v503 : (string -> (string seq -> string)) = String.concat
                    let v504 : string = ""
                    let v505 : (string seq -> string) = v503 v504
                    let v506 : string = v505 v497
                    US8_0(v506, v488, v489, v490, v491)
            | US8_0(v453, v454, v455, v456, v457) -> (* Ok *)
                v452
        | US8_0(v141, v142, v143, v144, v145) -> (* Ok *)
            v140
    match v517 with
    | US8_1(v566) -> (* Error *)
        let v567 : UH2 = UH2_0
        let v568 : UH2 = method67(v0, v567)
        US17_0(v568, v1, v2, v3, v4)
    | US8_0(v518, v519, v520, v521, v522) -> (* Ok *)
        let v523 : int32 = 0
        let v524 : int32 = method37(v519, v523)
        let v525 : bool = 0 = v524
        let v552 : US10 =
            if v525 then
                let v526 : string = "parsing.spaces1 / expected at least one space"
                US10_1(v526)
            else
                let v528 : (string -> int32) = String.length
                let v529 : int32 = v528 v519
                let v532 : int32 = v524 |> int32 
                let v539 : int32 = v529 |> int32 
                let v546 : int32 = v539 - 1
                let v547 : string = v519.[int v532..int v546]
                US10_0(v547, v520, v521, v522)
        match v552 with
        | US10_1(v559) -> (* Error *)
            let v560 : UH2 = UH2_0
            let v561 : UH2 = UH2_1(v518, v560)
            let v562 : UH2 = method67(v0, v561)
            US17_0(v562, v519, v520, v521, v522)
        | US10_0(v553, v554, v555, v556) -> (* Ok *)
            let v557 : UH2 = UH2_1(v518, v0)
            method61(v557, v553, v554, v555, v556)
and method60 (v0 : string) : US16 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v1 : (string -> string option) = Option.ofObj
    let v2 : string option = v1 v0
    v2 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v3 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v6 : string = ""
    let v7 : string = v3 |> Option.defaultValue v6 
    let v10 : string = method26()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : UH2 = UH2_0
    let v16 : int32 = 1
    let v17 : int32 = 1
    let v18 : US17 = method61(v15, v7, v12, v16, v17)
    match v18 with
    | US17_1(v31) -> (* Error *)
        US16_1(v31)
    | US17_0(v19, v20, v21, v22, v23) -> (* Ok *)
        let v24 : string list = []
        let v25 : string list = method68(v19, v24)
        let v26 : (string list -> (string [])) = List.toArray
        let v27 : (string []) = v26 v25
        US16_0(v27)
and closure29 () (v0 : string) : Result<(string []), string> =
    let v1 : US16 = method60(v0)
    match v1 with
    | US16_1(v4) -> (* Error *)
        let v5 : Result<(string []), string> = Error v4 
        v5
    | US16_0(v2) -> (* Ok *)
        let v3 : Result<(string []), string> = Ok v2 
        v3
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (unit -> unit) = closure3()
let current_process_kill () = v16 ()
let v17 : (string -> Async<struct (int32 * string)>) = closure13()
let execute_async x = v17 x
let v18 : (struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) -> Async<struct (int32 * string)>) = closure27()
let execute_with_options_async x = v18 x
let v19 : ((Heap0 -> Heap0) -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure28()
let execution_options x = v19 x
let v20 : (string -> Result<(string []), string>) = closure29()
let split_args x = v20 x
()
