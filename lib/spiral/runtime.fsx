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
  type Process = unit
  type DataReceivedEventArgs = unit
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
    let v118 : string = method9()
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
    let v139 : (int64 -> US2) = method8()
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
    let v250 : string = method9()
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
    let v273 : (int64 -> US2) = method8()
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
    let v308 : (int64 -> US2) = method8()
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
    let v419 : string = method10()
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
    let v440 : (int64 -> US2) = method8()
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
    let v551 : string = method10()
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
    let v572 : (int64 -> US2) = method8()
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
    let v683 : string = method10()
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
    let v704 : (int64 -> US2) = method8()
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
    let v815 : string = method10()
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
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method16 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method17 (v0 : string) : string =
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
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method16()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 3"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
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
and closure5 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method15(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method16()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 2"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
and closure11 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method19(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method16()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 1"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
and closure12 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method20(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and closure4 () () : unit =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let _v0 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v0 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v0 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v0 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v0 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v0 = () 
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
    let _v0 = () 
    #endif
    _v0 
    ()
and closure3 () () : unit =
    let v0 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let _v0 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let _v0 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let _v0 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _v0 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let _v0 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _v0 = () 
    #endif
#else
    let v1 : (unit -> unit) = closure4()
    let v2 : System.Threading.Thread = new System.Threading.Thread (v1)
    let v3 : (System.Threading.Thread -> unit) = _.Start()
    v3 v2
    let _v0 = () 
    #endif
    _v0 
    ()
and method23 () : string =
    let v0 : string = ""
    v0
and method24 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure16 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure15 () (v0 : char) : (UH0 -> UH0) =
    closure16(v0)
and method25 () : (char -> (UH0 -> UH0)) =
    closure15()
and method26 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method26(v5, v24, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
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
            while method24(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method25()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method26(v53, v1, v2, v3)
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
            let v115 : (int32 -> (string -> string)) = String.replicate
            let v116 : (string -> string) = v115 v114
            let v117 : string = " "
            let v118 : string = v116 v117
            let v121 : string = "^"
            let v122 : string = v118 + v121 
            let v123 : string = $"{v111}
{v122}
"
            US7_1(v123)
and closure17 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US7 =
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
            while method24(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method25()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method26(v53, v1, v2, v3)
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
            let v115 : (int32 -> (string -> string)) = String.replicate
            let v116 : (string -> string) = v115 v114
            let v117 : string = " "
            let v118 : string = v116 v117
            let v121 : string = "^"
            let v122 : string = v118 + v121 
            let v123 : string = $"{v111}
{v122}
"
            US7_1(v123)
and method27 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US7 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US7 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US7_1(v13) -> (* Error *)
            method27(v0, v1, v6)
        | US7_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US7_1(v3)
and method28 (v0 : char, v1 : int64) : bool =
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
            method28(v0, v17)
and method29 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v23 : bool = method28(v21, v22)
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
                while method24(v52, v54) do
                    let v56 : int32 = v54.l0
                    let v57 : char = v49.[int v56]
                    v53.[int v56] <- v57
                    let v58 : int32 = v56 + 1
                    v54.l0 <- v58
                    ()
                let v59 : char list = v53 |> Array.toList
                let v62 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v63 : (char -> (UH0 -> UH0)) = method25()
                let v64 : (char list -> (UH0 -> UH0)) = v62 v63
                let v65 : (UH0 -> UH0) = v64 v59
                let v66 : UH0 = UH0_0
                let v67 : UH0 = v65 v66
                let struct (v89 : System.Text.StringBuilder, v90 : int32, v91 : int32) = method26(v67, v2, v3, v4)
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
        method29(v131, v123, v124, v125, v126)
and method30 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US7 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US7 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US7_1(v15) -> (* Error *)
            method30(v0, v1, v2, v3, v8)
        | US7_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US7_1(v5)
and method31 (v0 : char, v1 : int64) : bool =
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
            method31(v0, v21)
and method32 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v26 : bool = method31(v24, v25)
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
                while method24(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method25()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method26(v70, v2, v3, v4)
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
        method32(v137, v129, v130, v131, v132)
and method33 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method33(v0, v6)
        else
            v1
and method34 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            while method24(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method25()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method26(v53, v2, v3, v4)
            US7_0(v10, v30, v75, v76, v77)
    match v79 with
    | US7_1(v95) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US7_0(v80, v81, v82, v83, v84) -> (* Ok *)
        let v85 : (char -> string) = _.ToString()
        let v86 : string = v85 v80
        let v89 : string = v0 + v86 
        method34(v89, v81, v82, v83, v84)
and method22 (v0 : string) : US6 =
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
    let v10 : string = method23()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure14()
    let v16 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure17()
    let v17 : UH1 = UH1_0
    let v18 : UH1 = UH1_1(v16, v17)
    let v19 : UH1 = UH1_1(v15, v18)
    let v20 : US7 = method27(v7, v12, v19)
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
                    let v44 : bool = method28(v42, v43)
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
                        while method24(v73, v75) do
                            let v77 : int32 = v75.l0
                            let v78 : char = v70.[int v77]
                            v74.[int v77] <- v78
                            let v79 : int32 = v77 + 1
                            v75.l0 <- v79
                            ()
                        let v80 : char list = v74 |> Array.toList
                        let v83 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v84 : (char -> (UH0 -> UH0)) = method25()
                        let v85 : (char list -> (UH0 -> UH0)) = v83 v84
                        let v86 : (UH0 -> UH0) = v85 v80
                        let v87 : UH0 = UH0_0
                        let v88 : UH0 = v86 v87
                        let struct (v110 : System.Text.StringBuilder, v111 : int32, v112 : int32) = method26(v88, v23, v24, v25)
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
                    let struct (v152 : string, v153 : string, v154 : System.Text.StringBuilder, v155 : int32, v156 : int32) = method29(v149, v144, v145, v146, v147)
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
                let v180 : US7 = method30(v173, v174, v175, v176, v179)
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
                    let v230 : bool = method31(v228, v229)
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
                        while method24(v259, v261) do
                            let v263 : int32 = v261.l0
                            let v264 : char = v256.[int v263]
                            v260.[int v263] <- v264
                            let v265 : int32 = v263 + 1
                            v261.l0 <- v265
                            ()
                        let v266 : char list = v260 |> Array.toList
                        let v269 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v270 : (char -> (UH0 -> UH0)) = method25()
                        let v271 : (char list -> (UH0 -> UH0)) = v269 v270
                        let v272 : (UH0 -> UH0) = v271 v266
                        let v273 : UH0 = UH0_0
                        let v274 : UH0 = v272 v273
                        let v296 : int32 = 1
                        let v297 : int32 = 1
                        let struct (v298 : System.Text.StringBuilder, v299 : int32, v300 : int32) = method26(v274, v12, v296, v297)
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
                    let struct (v343 : string, v344 : string, v345 : System.Text.StringBuilder, v346 : int32, v347 : int32) = method32(v340, v335, v336, v337, v338)
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
                    let v382 : int32 = method33(v377, v381)
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
    let v685 : US11 =
        match v414 with
        | US8_1(v682) -> (* Error *)
            US11_1(v682)
        | US8_0(v415, v416, v417, v418, v419) -> (* Ok *)
            let v420 : bool = "" = v416
            let v544 : US7 =
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
                        while method24(v454, v456) do
                            let v458 : int32 = v456.l0
                            let v459 : char = v451.[int v458]
                            v455.[int v458] <- v459
                            let v460 : int32 = v458 + 1
                            v456.l0 <- v460
                            ()
                        let v461 : char list = v455 |> Array.toList
                        let v464 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v465 : (char -> (UH0 -> UH0)) = method25()
                        let v466 : (char list -> (UH0 -> UH0)) = v464 v465
                        let v467 : (UH0 -> UH0) = v466 v461
                        let v468 : UH0 = UH0_0
                        let v469 : UH0 = v467 v468
                        let struct (v491 : System.Text.StringBuilder, v492 : int32, v493 : int32) = method26(v469, v417, v418, v419)
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
                        let v531 : (int32 -> (string -> string)) = String.replicate
                        let v532 : (string -> string) = v531 v530
                        let v533 : string = " "
                        let v534 : string = v532 v533
                        let v537 : string = "^"
                        let v538 : string = v534 + v537 
                        let v539 : string = $"{v527}
{v538}
"
                        US7_1(v539)
            let v556 : US12 =
                match v544 with
                | US7_1(v552) -> (* Error *)
                    let v553 : US9 = US9_1
                    US12_0(v553, v416, v417, v418, v419)
                | US7_0(v545, v546, v547, v548, v549) -> (* Ok *)
                    let v550 : US9 = US9_0(v545)
                    US12_0(v550, v546, v547, v548, v549)
            let v659 : US8 =
                match v556 with
                | US12_1(v656) -> (* Error *)
                    US8_1(v656)
                | US12_0(v557, v558, v559, v560, v561) -> (* Ok *)
                    let v562 : bool = "" = v558
                    let v636 : US7 =
                        if v562 then
                            let v563 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v559, v560, v561)}"
                            US7_1(v563)
                        else
                            let v567 : char = v558.[int 0]
                            let v568 : (string -> int32) = String.length
                            let v569 : int32 = v568 v558
                            let v572 : int32 = 1 |> int32 
                            let v579 : int32 = v569 |> int32 
                            let v586 : int32 = v579 - 1
                            let v587 : string = v558.[int v572..int v586]
                            let v591 : (char -> string) = _.ToString()
                            let v592 : string = v591 v567
                            let v595 : int32 = v592.Length
                            let v596 : (char []) = Array.zeroCreate<char> (v595)
                            let v597 : Mut5 = {l0 = 0} : Mut5
                            while method24(v595, v597) do
                                let v599 : int32 = v597.l0
                                let v600 : char = v592.[int v599]
                                v596.[int v599] <- v600
                                let v601 : int32 = v599 + 1
                                v597.l0 <- v601
                                ()
                            let v602 : char list = v596 |> Array.toList
                            let v605 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v606 : (char -> (UH0 -> UH0)) = method25()
                            let v607 : (char list -> (UH0 -> UH0)) = v605 v606
                            let v608 : (UH0 -> UH0) = v607 v602
                            let v609 : UH0 = UH0_0
                            let v610 : UH0 = v608 v609
                            let struct (v632 : System.Text.StringBuilder, v633 : int32, v634 : int32) = method26(v610, v559, v560, v561)
                            US7_0(v567, v587, v632, v633, v634)
                    match v636 with
                    | US7_1(v652) -> (* Error *)
                        US8_1(v652)
                    | US7_0(v637, v638, v639, v640, v641) -> (* Ok *)
                        let v642 : (char -> string) = _.ToString()
                        let v643 : string = v642 v637
                        let struct (v646 : string, v647 : string, v648 : System.Text.StringBuilder, v649 : int32, v650 : int32) = method34(v643, v638, v639, v640, v641)
                        US8_0(v646, v647, v648, v649, v650)
            let v671 : US13 =
                match v659 with
                | US8_1(v667) -> (* Error *)
                    let v668 : US5 = US5_1
                    US13_0(v668, v416, v417, v418, v419)
                | US8_0(v660, v661, v662, v663, v664) -> (* Ok *)
                    let v665 : US5 = US5_0(v660)
                    US13_0(v665, v661, v662, v663, v664)
            match v671 with
            | US13_1(v678) -> (* Error *)
                US11_1(v678)
            | US13_0(v672, v673, v674, v675, v676) -> (* Ok *)
                US11_0(v415, v672, v673, v674, v675, v676)
    match v685 with
    | US11_1(v693) -> (* Error *)
        US6_1(v693)
    | US11_0(v686, v687, v688, v689, v690, v691) -> (* Ok *)
        US6_0(v686, v687)
and method35 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method37 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method13()
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
    let v166 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v167 : string = "format!(\"{:#?}\", $0)"
    let v168 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v167 
    let v169 : string = "fable_library_rust::String_::fromString($0)"
    let v170 : string = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let _v166 = v170 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v171 : string = "format!(\"{:#?}\", $0)"
    let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v171 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v172 v173 
    let _v166 = v174 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v175 : string = "format!(\"{:#?}\", $0)"
    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v175 
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177 
    let _v166 = v178 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v179 : string = $"%A{v3}"
    let _v166 = v179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : string = $"%A{v3}"
    let _v166 = v182 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v185 : string = $"%A{v3}"
    let _v166 = v185 
    #endif
#else
    let v188 : string = $"%A{v3}"
    let _v166 = v188 
    #endif
    let v191 : string = _v166 
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
    let v265 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v266 : string = "format!(\"{:#?}\", $0)"
    let v267 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v266 
    let v268 : string = "fable_library_rust::String_::fromString($0)"
    let v269 : string = Fable.Core.RustInterop.emitRustExpr v267 v268 
    let _v265 = v269 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v270 : string = "format!(\"{:#?}\", $0)"
    let v271 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v270 
    let v272 : string = "fable_library_rust::String_::fromString($0)"
    let v273 : string = Fable.Core.RustInterop.emitRustExpr v271 v272 
    let _v265 = v273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v274 : string = "format!(\"{:#?}\", $0)"
    let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5 v274 
    let v276 : string = "fable_library_rust::String_::fromString($0)"
    let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
    let _v265 = v277 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v278 : string = $"%A{v5}"
    let _v265 = v278 
    #endif
#if FABLE_COMPILER_PYTHON
    let v281 : string = $"%A{v5}"
    let _v265 = v281 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v284 : string = $"%A{v5}"
    let _v265 = v284 
    #endif
#else
    let v287 : string = $"%A{v5}"
    let _v265 = v287 
    #endif
    let v290 : string = _v265 
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
    let v328 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v329 : string = "format!(\"{:#?}\", $0)"
    let v330 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v329 
    let v331 : string = "fable_library_rust::String_::fromString($0)"
    let v332 : string = Fable.Core.RustInterop.emitRustExpr v330 v331 
    let _v328 = v332 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v333 : string = "format!(\"{:#?}\", $0)"
    let v334 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v333 
    let v335 : string = "fable_library_rust::String_::fromString($0)"
    let v336 : string = Fable.Core.RustInterop.emitRustExpr v334 v335 
    let _v328 = v336 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v337 : string = "format!(\"{:#?}\", $0)"
    let v338 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v337 
    let v339 : string = "fable_library_rust::String_::fromString($0)"
    let v340 : string = Fable.Core.RustInterop.emitRustExpr v338 v339 
    let _v328 = v340 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v341 : string = $"%A{v6}"
    let _v328 = v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v344 : string = $"%A{v6}"
    let _v328 = v344 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v347 : string = $"%A{v6}"
    let _v328 = v347 
    #endif
#else
    let v350 : string = $"%A{v6}"
    let _v328 = v350 
    #endif
    let v353 : string = _v328 
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
    let v427 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v428 : string = "format!(\"{:#?}\", $0)"
    let v429 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v428 
    let v430 : string = "fable_library_rust::String_::fromString($0)"
    let v431 : string = Fable.Core.RustInterop.emitRustExpr v429 v430 
    let _v427 = v431 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v432 : string = "format!(\"{:#?}\", $0)"
    let v433 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v432 
    let v434 : string = "fable_library_rust::String_::fromString($0)"
    let v435 : string = Fable.Core.RustInterop.emitRustExpr v433 v434 
    let _v427 = v435 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v436 : string = "format!(\"{:#?}\", $0)"
    let v437 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8 v436 
    let v438 : string = "fable_library_rust::String_::fromString($0)"
    let v439 : string = Fable.Core.RustInterop.emitRustExpr v437 v438 
    let _v427 = v439 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v440 : string = $"%A{v8}"
    let _v427 = v440 
    #endif
#if FABLE_COMPILER_PYTHON
    let v443 : string = $"%A{v8}"
    let _v427 = v443 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v446 : string = $"%A{v8}"
    let _v427 = v446 
    #endif
#else
    let v449 : string = $"%A{v8}"
    let _v427 = v449 
    #endif
    let v452 : string = _v427 
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
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method37(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options_async"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method17(v20)
and closure18 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method6(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure0()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method7(v27, v28, v29, v30, v31, v32)
        let v46 : string = method35()
        let v47 : string = method36(v27, v28, v29, v30, v31, v32, v45, v46, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method18(v47)
and method38 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and closure20 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US14 =
    US14_0(v0)
and method39 () : ((struct (int32 * string * bool) -> Async<unit>) -> US14) =
    closure20()
and method40 () : string =
    
    
    
    
    
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
and method41 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method16()
    let v10 : int64 = v0.l0
    let v11 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method17(v11)
and closure21 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method40()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method41(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v42)
and closure19 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : unit = ()
    let _v20 =
        async {
            let v23 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24 : string = null |> unbox<string>
            let _v23 = v24 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : string = null |> unbox<string>
            let _v23 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = null |> unbox<string>
            let _v23 = v30 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v33 : string = null |> unbox<string>
            let _v23 = v33 
            #endif
#if FABLE_COMPILER_PYTHON
            let v36 : string = null |> unbox<string>
            let _v23 = v36 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v39 : string = null |> unbox<string>
            let _v23 = v39 
            #endif
#else
            let v42 : string = v9.Data
            let _v23 = v42 
            #endif
            let v43 : string = _v23 
            let v48 : string = null |> unbox<string>
            let v51 : bool = v43 = v48
            let v52 : bool = v51 <> true
            if v52 then
                let v53 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v54 : US14 option = v3 |> Option.map v53 
                let v65 : US14 = US14_1
                let v66 : US14 = v54 |> Option.defaultValue v65 
                match v66 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v70) -> (* Some *)
                    let v71 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v72 : int32 = null |> unbox<int32>
                    let _v71 = v72 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v75 : int32 = null |> unbox<int32>
                    let _v71 = v75 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v78 : int32 = null |> unbox<int32>
                    let _v71 = v78 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v81 : int32 = null |> unbox<int32>
                    let _v71 = v81 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v84 : int32 = null |> unbox<int32>
                    let _v71 = v84 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v87 : int32 = null |> unbox<int32>
                    let _v71 = v87 
                    #endif
#else
                    let v90 : int32 = v7.Id
                    let _v71 = v90 
                    #endif
                    let v91 : int32 = _v71 
                    let v96 : Async<unit> = v70 struct (v91, v43, false)
                    do! v96 
                    ()
                let v97 : string = $"> {v43}"
                if v5 then
                    let v98 : unit = ()
                    let v99 : (unit -> unit) = closure21(v97)
                    let v100 : unit = (fun () -> v99 (); v98) ()
                    ()
                else
                    let v143 : unit = ()
                    let v144 : (unit -> unit) = closure10(v97)
                    let v145 : unit = (fun () -> v144 (); v143) ()
                    ()
                let v147 : string = ""
                let v148 : string = $"{v147}{v43}{v147}"
                let v149 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v149 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v149 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v149 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v149 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v149 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v149 = () 
                #endif
#else
                let v150 : (string -> unit) = v8.Push
                v150 v148
                let _v149 = () 
                #endif
                _v149 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1047 : Async<unit> = _v20 
    let _v10 = v1047 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1048 : unit = ()
    let _v1048 =
        async {
            let v1051 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1052 : string = null |> unbox<string>
            let _v1051 = v1052 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1055 : string = null |> unbox<string>
            let _v1051 = v1055 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1058 : string = null |> unbox<string>
            let _v1051 = v1058 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1061 : string = null |> unbox<string>
            let _v1051 = v1061 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1064 : string = null |> unbox<string>
            let _v1051 = v1064 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1067 : string = null |> unbox<string>
            let _v1051 = v1067 
            #endif
#else
            let v1070 : string = v9.Data
            let _v1051 = v1070 
            #endif
            let v1071 : string = _v1051 
            let v1076 : string = null |> unbox<string>
            let v1079 : bool = v1071 = v1076
            let v1080 : bool = v1079 <> true
            if v1080 then
                let v1081 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v1082 : US14 option = v3 |> Option.map v1081 
                let v1093 : US14 = US14_1
                let v1094 : US14 = v1082 |> Option.defaultValue v1093 
                match v1094 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v1098) -> (* Some *)
                    let v1099 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1100 : int32 = null |> unbox<int32>
                    let _v1099 = v1100 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1103 : int32 = null |> unbox<int32>
                    let _v1099 = v1103 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1106 : int32 = null |> unbox<int32>
                    let _v1099 = v1106 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1109 : int32 = null |> unbox<int32>
                    let _v1099 = v1109 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1112 : int32 = null |> unbox<int32>
                    let _v1099 = v1112 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1115 : int32 = null |> unbox<int32>
                    let _v1099 = v1115 
                    #endif
#else
                    let v1118 : int32 = v7.Id
                    let _v1099 = v1118 
                    #endif
                    let v1119 : int32 = _v1099 
                    let v1124 : Async<unit> = v1098 struct (v1119, v1071, false)
                    do! v1124 
                    ()
                let v1125 : string = $"> {v1071}"
                if v5 then
                    let v1126 : unit = ()
                    let v1127 : (unit -> unit) = closure21(v1125)
                    let v1128 : unit = (fun () -> v1127 (); v1126) ()
                    ()
                else
                    let v1171 : unit = ()
                    let v1172 : (unit -> unit) = closure10(v1125)
                    let v1173 : unit = (fun () -> v1172 (); v1171) ()
                    ()
                let v1175 : string = ""
                let v1176 : string = $"{v1175}{v1071}{v1175}"
                let v1177 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v1177 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v1177 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v1177 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v1177 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v1177 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v1177 = () 
                #endif
#else
                let v1178 : (string -> unit) = v8.Push
                v1178 v1176
                let _v1177 = () 
                #endif
                _v1177 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2075 : Async<unit> = _v1048 
    let _v10 = v2075 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2076 : unit = ()
    let _v2076 =
        async {
            let v2079 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2080 : string = null |> unbox<string>
            let _v2079 = v2080 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2083 : string = null |> unbox<string>
            let _v2079 = v2083 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2086 : string = null |> unbox<string>
            let _v2079 = v2086 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2089 : string = null |> unbox<string>
            let _v2079 = v2089 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2092 : string = null |> unbox<string>
            let _v2079 = v2092 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2095 : string = null |> unbox<string>
            let _v2079 = v2095 
            #endif
#else
            let v2098 : string = v9.Data
            let _v2079 = v2098 
            #endif
            let v2099 : string = _v2079 
            let v2104 : string = null |> unbox<string>
            let v2107 : bool = v2099 = v2104
            let v2108 : bool = v2107 <> true
            if v2108 then
                let v2109 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v2110 : US14 option = v3 |> Option.map v2109 
                let v2121 : US14 = US14_1
                let v2122 : US14 = v2110 |> Option.defaultValue v2121 
                match v2122 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v2126) -> (* Some *)
                    let v2127 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2128 : int32 = null |> unbox<int32>
                    let _v2127 = v2128 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2131 : int32 = null |> unbox<int32>
                    let _v2127 = v2131 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2134 : int32 = null |> unbox<int32>
                    let _v2127 = v2134 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2137 : int32 = null |> unbox<int32>
                    let _v2127 = v2137 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2140 : int32 = null |> unbox<int32>
                    let _v2127 = v2140 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2143 : int32 = null |> unbox<int32>
                    let _v2127 = v2143 
                    #endif
#else
                    let v2146 : int32 = v7.Id
                    let _v2127 = v2146 
                    #endif
                    let v2147 : int32 = _v2127 
                    let v2152 : Async<unit> = v2126 struct (v2147, v2099, false)
                    do! v2152 
                    ()
                let v2153 : string = $"> {v2099}"
                if v5 then
                    let v2154 : unit = ()
                    let v2155 : (unit -> unit) = closure21(v2153)
                    let v2156 : unit = (fun () -> v2155 (); v2154) ()
                    ()
                else
                    let v2199 : unit = ()
                    let v2200 : (unit -> unit) = closure10(v2153)
                    let v2201 : unit = (fun () -> v2200 (); v2199) ()
                    ()
                let v2203 : string = ""
                let v2204 : string = $"{v2203}{v2099}{v2203}"
                let v2205 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v2205 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v2205 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v2205 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v2205 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v2205 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v2205 = () 
                #endif
#else
                let v2206 : (string -> unit) = v8.Push
                v2206 v2204
                let _v2205 = () 
                #endif
                _v2205 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3103 : Async<unit> = _v2076 
    let _v10 = v3103 
    #endif
#else
    let v3104 : unit = ()
    let _v3104 =
        async {
            let v3107 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3108 : string = null |> unbox<string>
            let _v3107 = v3108 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3111 : string = null |> unbox<string>
            let _v3107 = v3111 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3114 : string = null |> unbox<string>
            let _v3107 = v3114 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3117 : string = null |> unbox<string>
            let _v3107 = v3117 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3120 : string = null |> unbox<string>
            let _v3107 = v3120 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3123 : string = null |> unbox<string>
            let _v3107 = v3123 
            #endif
#else
            let v3126 : string = v9.Data
            let _v3107 = v3126 
            #endif
            let v3127 : string = _v3107 
            let v3132 : string = null |> unbox<string>
            let v3135 : bool = v3127 = v3132
            let v3136 : bool = v3135 <> true
            if v3136 then
                let v3137 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v3138 : US14 option = v3 |> Option.map v3137 
                let v3149 : US14 = US14_1
                let v3150 : US14 = v3138 |> Option.defaultValue v3149 
                match v3150 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v3154) -> (* Some *)
                    let v3155 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3156 : int32 = null |> unbox<int32>
                    let _v3155 = v3156 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3159 : int32 = null |> unbox<int32>
                    let _v3155 = v3159 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3162 : int32 = null |> unbox<int32>
                    let _v3155 = v3162 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3165 : int32 = null |> unbox<int32>
                    let _v3155 = v3165 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3168 : int32 = null |> unbox<int32>
                    let _v3155 = v3168 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3171 : int32 = null |> unbox<int32>
                    let _v3155 = v3171 
                    #endif
#else
                    let v3174 : int32 = v7.Id
                    let _v3155 = v3174 
                    #endif
                    let v3175 : int32 = _v3155 
                    let v3180 : Async<unit> = v3154 struct (v3175, v3127, false)
                    do! v3180 
                    ()
                let v3181 : string = $"> {v3127}"
                if v5 then
                    let v3182 : unit = ()
                    let v3183 : (unit -> unit) = closure21(v3181)
                    let v3184 : unit = (fun () -> v3183 (); v3182) ()
                    ()
                else
                    let v3227 : unit = ()
                    let v3228 : (unit -> unit) = closure10(v3181)
                    let v3229 : unit = (fun () -> v3228 (); v3227) ()
                    ()
                let v3231 : string = ""
                let v3232 : string = $"{v3231}{v3127}{v3231}"
                let v3233 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v3233 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v3233 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v3233 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v3233 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v3233 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v3233 = () 
                #endif
#else
                let v3234 : (string -> unit) = v8.Push
                v3234 v3232
                let _v3233 = () 
                #endif
                _v3233 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4131 : Async<unit> = _v3104 
    let _v10 = v4131 
    #endif
    let v4132 : Async<unit> = _v10 
    let v4650 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v4650 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v4650 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v4650 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4651 : (Async<unit> -> unit) = Async.StartImmediate
    v4651 v4132
    let _v4650 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4652 : (Async<unit> -> unit) = Async.StartImmediate
    v4652 v4132
    let _v4650 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4653 : (Async<unit> -> unit) = Async.StartImmediate
    v4653 v4132
    let _v4650 = () 
    #endif
#else
    let v4654 : (Async<unit> -> unit) = Async.StartImmediate
    v4654 v4132
    let _v4650 = () 
    #endif
    _v4650 
    ()
and closure22 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v10 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v14 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v14 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v17 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v20 : unit = ()
    let _v20 =
        async {
            let v23 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v24 : string = null |> unbox<string>
            let _v23 = v24 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v27 : string = null |> unbox<string>
            let _v23 = v27 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v30 : string = null |> unbox<string>
            let _v23 = v30 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v33 : string = null |> unbox<string>
            let _v23 = v33 
            #endif
#if FABLE_COMPILER_PYTHON
            let v36 : string = null |> unbox<string>
            let _v23 = v36 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v39 : string = null |> unbox<string>
            let _v23 = v39 
            #endif
#else
            let v42 : string = v9.Data
            let _v23 = v42 
            #endif
            let v43 : string = _v23 
            let v48 : string = null |> unbox<string>
            let v51 : bool = v43 = v48
            let v52 : bool = v51 <> true
            if v52 then
                let v53 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v54 : US14 option = v3 |> Option.map v53 
                let v65 : US14 = US14_1
                let v66 : US14 = v54 |> Option.defaultValue v65 
                match v66 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v70) -> (* Some *)
                    let v71 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v72 : int32 = null |> unbox<int32>
                    let _v71 = v72 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v75 : int32 = null |> unbox<int32>
                    let _v71 = v75 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v78 : int32 = null |> unbox<int32>
                    let _v71 = v78 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v81 : int32 = null |> unbox<int32>
                    let _v71 = v81 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v84 : int32 = null |> unbox<int32>
                    let _v71 = v84 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v87 : int32 = null |> unbox<int32>
                    let _v71 = v87 
                    #endif
#else
                    let v90 : int32 = v7.Id
                    let _v71 = v90 
                    #endif
                    let v91 : int32 = _v71 
                    let v96 : Async<unit> = v70 struct (v91, v43, true)
                    do! v96 
                    ()
                let v97 : string = $"! {v43}"
                if v5 then
                    let v98 : unit = ()
                    let v99 : (unit -> unit) = closure21(v97)
                    let v100 : unit = (fun () -> v99 (); v98) ()
                    ()
                else
                    let v143 : unit = ()
                    let v144 : (unit -> unit) = closure10(v97)
                    let v145 : unit = (fun () -> v144 (); v143) ()
                    ()
                let v147 : string = "\u001b[7;4m"
                let v148 : string = "\u001b[0m"
                let v149 : string = $"{v147}{v43}{v148}"
                let v150 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v150 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v150 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v150 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v150 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v150 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v150 = () 
                #endif
#else
                let v151 : (string -> unit) = v8.Push
                v151 v149
                let _v150 = () 
                #endif
                _v150 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1055 : Async<unit> = _v20 
    let _v10 = v1055 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1056 : unit = ()
    let _v1056 =
        async {
            let v1059 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1060 : string = null |> unbox<string>
            let _v1059 = v1060 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1063 : string = null |> unbox<string>
            let _v1059 = v1063 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1066 : string = null |> unbox<string>
            let _v1059 = v1066 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1069 : string = null |> unbox<string>
            let _v1059 = v1069 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1072 : string = null |> unbox<string>
            let _v1059 = v1072 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1075 : string = null |> unbox<string>
            let _v1059 = v1075 
            #endif
#else
            let v1078 : string = v9.Data
            let _v1059 = v1078 
            #endif
            let v1079 : string = _v1059 
            let v1084 : string = null |> unbox<string>
            let v1087 : bool = v1079 = v1084
            let v1088 : bool = v1087 <> true
            if v1088 then
                let v1089 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v1090 : US14 option = v3 |> Option.map v1089 
                let v1101 : US14 = US14_1
                let v1102 : US14 = v1090 |> Option.defaultValue v1101 
                match v1102 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v1106) -> (* Some *)
                    let v1107 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1108 : int32 = null |> unbox<int32>
                    let _v1107 = v1108 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1111 : int32 = null |> unbox<int32>
                    let _v1107 = v1111 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1114 : int32 = null |> unbox<int32>
                    let _v1107 = v1114 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1117 : int32 = null |> unbox<int32>
                    let _v1107 = v1117 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1120 : int32 = null |> unbox<int32>
                    let _v1107 = v1120 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1123 : int32 = null |> unbox<int32>
                    let _v1107 = v1123 
                    #endif
#else
                    let v1126 : int32 = v7.Id
                    let _v1107 = v1126 
                    #endif
                    let v1127 : int32 = _v1107 
                    let v1132 : Async<unit> = v1106 struct (v1127, v1079, true)
                    do! v1132 
                    ()
                let v1133 : string = $"! {v1079}"
                if v5 then
                    let v1134 : unit = ()
                    let v1135 : (unit -> unit) = closure21(v1133)
                    let v1136 : unit = (fun () -> v1135 (); v1134) ()
                    ()
                else
                    let v1179 : unit = ()
                    let v1180 : (unit -> unit) = closure10(v1133)
                    let v1181 : unit = (fun () -> v1180 (); v1179) ()
                    ()
                let v1183 : string = "\u001b[7;4m"
                let v1184 : string = "\u001b[0m"
                let v1185 : string = $"{v1183}{v1079}{v1184}"
                let v1186 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v1186 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v1186 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v1186 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v1186 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v1186 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v1186 = () 
                #endif
#else
                let v1187 : (string -> unit) = v8.Push
                v1187 v1185
                let _v1186 = () 
                #endif
                _v1186 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2091 : Async<unit> = _v1056 
    let _v10 = v2091 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v2092 : unit = ()
    let _v2092 =
        async {
            let v2095 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2096 : string = null |> unbox<string>
            let _v2095 = v2096 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2099 : string = null |> unbox<string>
            let _v2095 = v2099 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2102 : string = null |> unbox<string>
            let _v2095 = v2102 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2105 : string = null |> unbox<string>
            let _v2095 = v2105 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2108 : string = null |> unbox<string>
            let _v2095 = v2108 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2111 : string = null |> unbox<string>
            let _v2095 = v2111 
            #endif
#else
            let v2114 : string = v9.Data
            let _v2095 = v2114 
            #endif
            let v2115 : string = _v2095 
            let v2120 : string = null |> unbox<string>
            let v2123 : bool = v2115 = v2120
            let v2124 : bool = v2123 <> true
            if v2124 then
                let v2125 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v2126 : US14 option = v3 |> Option.map v2125 
                let v2137 : US14 = US14_1
                let v2138 : US14 = v2126 |> Option.defaultValue v2137 
                match v2138 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v2142) -> (* Some *)
                    let v2143 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2144 : int32 = null |> unbox<int32>
                    let _v2143 = v2144 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2147 : int32 = null |> unbox<int32>
                    let _v2143 = v2147 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2150 : int32 = null |> unbox<int32>
                    let _v2143 = v2150 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2153 : int32 = null |> unbox<int32>
                    let _v2143 = v2153 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2156 : int32 = null |> unbox<int32>
                    let _v2143 = v2156 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2159 : int32 = null |> unbox<int32>
                    let _v2143 = v2159 
                    #endif
#else
                    let v2162 : int32 = v7.Id
                    let _v2143 = v2162 
                    #endif
                    let v2163 : int32 = _v2143 
                    let v2168 : Async<unit> = v2142 struct (v2163, v2115, true)
                    do! v2168 
                    ()
                let v2169 : string = $"! {v2115}"
                if v5 then
                    let v2170 : unit = ()
                    let v2171 : (unit -> unit) = closure21(v2169)
                    let v2172 : unit = (fun () -> v2171 (); v2170) ()
                    ()
                else
                    let v2215 : unit = ()
                    let v2216 : (unit -> unit) = closure10(v2169)
                    let v2217 : unit = (fun () -> v2216 (); v2215) ()
                    ()
                let v2219 : string = "\u001b[7;4m"
                let v2220 : string = "\u001b[0m"
                let v2221 : string = $"{v2219}{v2115}{v2220}"
                let v2222 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v2222 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v2222 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v2222 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v2222 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v2222 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v2222 = () 
                #endif
#else
                let v2223 : (string -> unit) = v8.Push
                v2223 v2221
                let _v2222 = () 
                #endif
                _v2222 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v3127 : Async<unit> = _v2092 
    let _v10 = v3127 
    #endif
#else
    let v3128 : unit = ()
    let _v3128 =
        async {
            let v3131 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v3132 : string = null |> unbox<string>
            let _v3131 = v3132 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v3135 : string = null |> unbox<string>
            let _v3131 = v3135 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v3138 : string = null |> unbox<string>
            let _v3131 = v3138 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v3141 : string = null |> unbox<string>
            let _v3131 = v3141 
            #endif
#if FABLE_COMPILER_PYTHON
            let v3144 : string = null |> unbox<string>
            let _v3131 = v3144 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3147 : string = null |> unbox<string>
            let _v3131 = v3147 
            #endif
#else
            let v3150 : string = v9.Data
            let _v3131 = v3150 
            #endif
            let v3151 : string = _v3131 
            let v3156 : string = null |> unbox<string>
            let v3159 : bool = v3151 = v3156
            let v3160 : bool = v3159 <> true
            if v3160 then
                let v3161 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v3162 : US14 option = v3 |> Option.map v3161 
                let v3173 : US14 = US14_1
                let v3174 : US14 = v3162 |> Option.defaultValue v3173 
                match v3174 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v3178) -> (* Some *)
                    let v3179 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3180 : int32 = null |> unbox<int32>
                    let _v3179 = v3180 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3183 : int32 = null |> unbox<int32>
                    let _v3179 = v3183 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3186 : int32 = null |> unbox<int32>
                    let _v3179 = v3186 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3189 : int32 = null |> unbox<int32>
                    let _v3179 = v3189 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3192 : int32 = null |> unbox<int32>
                    let _v3179 = v3192 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3195 : int32 = null |> unbox<int32>
                    let _v3179 = v3195 
                    #endif
#else
                    let v3198 : int32 = v7.Id
                    let _v3179 = v3198 
                    #endif
                    let v3199 : int32 = _v3179 
                    let v3204 : Async<unit> = v3178 struct (v3199, v3151, true)
                    do! v3204 
                    ()
                let v3205 : string = $"! {v3151}"
                if v5 then
                    let v3206 : unit = ()
                    let v3207 : (unit -> unit) = closure21(v3205)
                    let v3208 : unit = (fun () -> v3207 (); v3206) ()
                    ()
                else
                    let v3251 : unit = ()
                    let v3252 : (unit -> unit) = closure10(v3205)
                    let v3253 : unit = (fun () -> v3252 (); v3251) ()
                    ()
                let v3255 : string = "\u001b[7;4m"
                let v3256 : string = "\u001b[0m"
                let v3257 : string = $"{v3255}{v3151}{v3256}"
                let v3258 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v3258 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v3258 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v3258 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v3258 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v3258 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v3258 = () 
                #endif
#else
                let v3259 : (string -> unit) = v8.Push
                v3259 v3257
                let _v3258 = () 
                #endif
                _v3258 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v4163 : Async<unit> = _v3128 
    let _v10 = v4163 
    #endif
    let v4164 : Async<unit> = _v10 
    let v4686 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v4686 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v4686 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v4686 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v4687 : (Async<unit> -> unit) = Async.StartImmediate
    v4687 v4164
    let _v4686 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v4688 : (Async<unit> -> unit) = Async.StartImmediate
    v4688 v4164
    let _v4686 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v4689 : (Async<unit> -> unit) = Async.StartImmediate
    v4689 v4164
    let _v4686 = () 
    #endif
#else
    let v4690 : (Async<unit> -> unit) = Async.StartImmediate
    v4690 v4164
    let _v4686 = () 
    #endif
    _v4686 
    ()
and closure23 () (v0 : System.Threading.CancellationToken) : US15 =
    US15_0(v0)
and method42 () : (System.Threading.CancellationToken -> US15) =
    closure23()
and closure24 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : bool = null |> unbox<bool>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : bool = null |> unbox<bool>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : bool = null |> unbox<bool>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : bool = null |> unbox<bool>
    let _v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : bool = null |> unbox<bool>
    let _v1 = v17 
    #endif
#else
    let v20 : bool = v0.HasExited
    let _v1 = v20 
    #endif
    let v21 : bool = _v1 
    let v26 : bool = v21 = false
    if v26 then
        let v27 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let _v27 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let _v27 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let _v27 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let _v27 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let _v27 = () 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let _v27 = () 
        #endif
#else
        let v28 : (unit -> unit) = v0.Kill
        v28 ()
        let _v27 = () 
        #endif
        _v27 
        ()
and method44 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method13()
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
and method43 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method44(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure25 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = method43(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method45 () : string =
    let v0 : string = "\n"
    v0
and method47 (v0 : int32, v1 : int32) : string =
    let v2 : string = method13()
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
and method46 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method47(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure26 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method35()
        let v40 : int32 = v1.Length
        let v41 : string = method46(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method18(v41)
and method21 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v11 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v17 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v17 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v23 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v7 = v23 
    #endif
#else
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v27 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v36 : unit = ()
    let _v36 =
        async {
            let v39 : US6 = method22(v0)
            let struct (v50 : string, v51 : US5) =
                match v39 with
                | US6_1(v42) -> (* Error *)
                    let v43 : string = $"resultm.get / Result value was Error: {v42}"
                    failwith<struct (string * US5)> v43
                | US6_0(v40, v41) -> (* Ok *)
                    struct (v40, v41)
            let v52 : (string -> US5) = method5()
            let v53 : US5 option = v6 |> Option.map v52 
            let v64 : US5 = US5_1
            let v65 : US5 = v53 |> Option.defaultValue v64 
            let v72 : string =
                match v65 with
                | US5_1 -> (* None *)
                    let v70 : string = ""
                    v70
                | US5_0(v69) -> (* Some *)
                    v69
            let v73 : unit = ()
            let v74 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v51, v50)
            let v75 : unit = (fun () -> v74 (); v73) ()
            let v115 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v119 : string =
                match v51 with
                | US5_1 -> (* None *)
                    let v117 : string = ""
                    v117
                | US5_0(v116) -> (* Some *)
                    v116
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v119,
              StandardOutputEncoding = v115,
              WorkingDirectory = v72,
              FileName = v50,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v120 : System.Diagnostics.ProcessStartInfo = start_info
            let v121 : (struct (string * string) []) = method38(v0, v1, v2, v3, v4, v5, v6)
            let v122 : int32 = v121.Length
            let v123 : Mut5 = {l0 = 0} : Mut5
            while method24(v122, v123) do
                let v125 : int32 = v123.l0
                let struct (v126 : string, v127 : string) = v121.[int v125]
                v120.EnvironmentVariables.[v126] <- v127 
                let v128 : int32 = v125 + 1
                v123.l0 <- v128
                ()
            let v129 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v120)
            use v129 = v129 
            let v130 : System.Diagnostics.Process = v129 
            let v131 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v132 : System.Collections.Concurrent.ConcurrentStack<string> = v131 ()
            let v133 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v130, v132)
            v130.OutputDataReceived.Add v133 
            let v134 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v130, v132)
            v130.ErrorDataReceived.Add v134 
            let v135 : (unit -> bool) = v130.Start
            let v136 : bool = v135 ()
            let v137 : bool = v136 = false
            if v137 then
                let v138 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v138
            let v139 : (unit -> unit) = v130.BeginErrorReadLine
            v139 ()
            let v140 : (unit -> unit) = v130.BeginOutputReadLine
            v140 ()
            let v141 : (System.Threading.CancellationToken -> US15) = method42()
            let v142 : US15 option = v1 |> Option.map v141 
            let v153 : US15 = US15_1
            let v154 : US15 = v142 |> Option.defaultValue v153 
            let v161 : System.Threading.CancellationToken =
                match v154 with
                | US15_1 -> (* None *)
                    let v159 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v159
                | US15_0(v158) -> (* Some *)
                    v158
            let v162 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v163 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v162 = v163 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v166 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v162 = v166 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v169 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v162 = v169 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v172 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v162 = v172 
            #endif
#if FABLE_COMPILER_PYTHON
            let v175 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v162 = v175 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v178 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v162 = v178 
            #endif
#else
            let v181 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v182 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v181 = v182 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v185 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v181 = v185 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v188 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v181 = v188 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v191 : unit = ()
            let _v191 =
                async {
                    let v194 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v194 = v194 
                    let v195 : System.Threading.CancellationToken = v194 
                    let v196 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v197 : (System.Threading.CancellationToken []) = [|v195; v196; v161|]
                    let v198 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v199 : System.Threading.CancellationTokenSource = v198 v197
                    let v200 : System.Threading.CancellationToken = v199.Token
                    return v200 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v250 : Async<System.Threading.CancellationToken> = _v191 
            let _v181 = v250 
            #endif
#if FABLE_COMPILER_PYTHON
            let v251 : unit = ()
            let _v251 =
                async {
                    let v254 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v254 = v254 
                    let v255 : System.Threading.CancellationToken = v254 
                    let v256 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v257 : (System.Threading.CancellationToken []) = [|v255; v256; v161|]
                    let v258 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v259 : System.Threading.CancellationTokenSource = v258 v257
                    let v260 : System.Threading.CancellationToken = v259.Token
                    return v260 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v310 : Async<System.Threading.CancellationToken> = _v251 
            let _v181 = v310 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v311 : unit = ()
            let _v311 =
                async {
                    let v314 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v314 = v314 
                    let v315 : System.Threading.CancellationToken = v314 
                    let v316 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v317 : (System.Threading.CancellationToken []) = [|v315; v316; v161|]
                    let v318 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v319 : System.Threading.CancellationTokenSource = v318 v317
                    let v320 : System.Threading.CancellationToken = v319.Token
                    return v320 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v370 : Async<System.Threading.CancellationToken> = _v311 
            let _v181 = v370 
            #endif
#else
            let v371 : unit = ()
            let _v371 =
                async {
                    let v374 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v374 = v374 
                    let v375 : System.Threading.CancellationToken = v374 
                    let v376 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v377 : (System.Threading.CancellationToken []) = [|v375; v376; v161|]
                    let v378 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v379 : System.Threading.CancellationTokenSource = v378 v377
                    let v380 : System.Threading.CancellationToken = v379.Token
                    return v380 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v430 : Async<System.Threading.CancellationToken> = _v371 
            let _v181 = v430 
            #endif
            let v431 : Async<System.Threading.CancellationToken> = _v181 
            let _v162 = v431 
            #endif
            let v465 : Async<System.Threading.CancellationToken> = _v162 
            let! v465 = v465 
            let v470 : System.Threading.CancellationToken = v465 
            let v471 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v470.Register
            let v472 : (unit -> unit) = closure24(v130)
            let v473 : System.Threading.CancellationTokenRegistration = v471 v472
            use v473 = v473 
            let v474 : System.Threading.CancellationTokenRegistration = v473 
            let v475 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v476 : Async<int32> = null |> unbox<Async<int32>>
            let _v475 = v476 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v479 : Async<int32> = null |> unbox<Async<int32>>
            let _v475 = v479 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v482 : Async<int32> = null |> unbox<Async<int32>>
            let _v475 = v482 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v485 : unit = ()
            let _v485 =
                async {
                    try
                    let v488 : System.Threading.Tasks.Task = v130.WaitForExitAsync v470 
                    let v489 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v490 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v491 : Async<unit> = v490 v488
                    let _v489 = v491 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v492 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v493 : Async<unit> = v492 v488
                    let _v489 = v493 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v494 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v495 : Async<unit> = v494 v488
                    let _v489 = v495 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v496 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v497 : Async<unit> = v496 v488
                    let _v489 = v497 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v498 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v499 : Async<unit> = v498 v488
                    let _v489 = v499 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v500 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v501 : Async<unit> = v500 v488
                    let _v489 = v501 
                    #endif
#else
                    let v502 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v503 : Async<unit> = v502 v488
                    let _v489 = v503 
                    #endif
                    let v504 : Async<unit> = _v489 
                    do! v504 
                    let v509 : int32 = v130.ExitCode
                    return v509 
                    with ex ->
                        let v510 : exn = ex
                        let v511 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v512 : string = $"%A{v510}"
                        let _v511 = v512 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v515 : string = $"%A{v510}"
                        let _v511 = v515 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v518 : string = $"%A{v510}"
                        let _v511 = v518 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v521 : string = $"%A{v510}"
                        let _v511 = v521 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v524 : string = $"%A{v510}"
                        let _v511 = v524 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v527 : string = $"%A{v510}"
                        let _v511 = v527 
                        #endif
#else
                        let v530 : string = $"{v510.GetType ()}: {v510.Message}"
                        let _v511 = v530 
                        #endif
                        let v531 : string = _v511 
                        let v536 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v536 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v536 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v536 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v536 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v536 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v536 = () 
                        #endif
#else
                        let v537 : (string -> unit) = v132.Push
                        v537 v531
                        let _v536 = () 
                        #endif
                        _v536 
                        let v538 : System.Threading.Tasks.TaskCanceledException = v510 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v541 : unit = ()
                        let v542 : (unit -> unit) = closure25(v538)
                        let v543 : unit = (fun () -> v542 (); v541) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1832 : Async<int32> = _v485 
            let _v475 = v1832 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1833 : unit = ()
            let _v1833 =
                async {
                    try
                    let v1836 : System.Threading.Tasks.Task = v130.WaitForExitAsync v470 
                    let v1837 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1838 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1839 : Async<unit> = v1838 v1836
                    let _v1837 = v1839 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1840 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1841 : Async<unit> = v1840 v1836
                    let _v1837 = v1841 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1842 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1843 : Async<unit> = v1842 v1836
                    let _v1837 = v1843 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1844 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1845 : Async<unit> = v1844 v1836
                    let _v1837 = v1845 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1846 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1847 : Async<unit> = v1846 v1836
                    let _v1837 = v1847 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1848 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1849 : Async<unit> = v1848 v1836
                    let _v1837 = v1849 
                    #endif
#else
                    let v1850 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1851 : Async<unit> = v1850 v1836
                    let _v1837 = v1851 
                    #endif
                    let v1852 : Async<unit> = _v1837 
                    do! v1852 
                    let v1857 : int32 = v130.ExitCode
                    return v1857 
                    with ex ->
                        let v1858 : exn = ex
                        let v1859 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1860 : string = $"%A{v1858}"
                        let _v1859 = v1860 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1863 : string = $"%A{v1858}"
                        let _v1859 = v1863 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1866 : string = $"%A{v1858}"
                        let _v1859 = v1866 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1869 : string = $"%A{v1858}"
                        let _v1859 = v1869 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1872 : string = $"%A{v1858}"
                        let _v1859 = v1872 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1875 : string = $"%A{v1858}"
                        let _v1859 = v1875 
                        #endif
#else
                        let v1878 : string = $"{v1858.GetType ()}: {v1858.Message}"
                        let _v1859 = v1878 
                        #endif
                        let v1879 : string = _v1859 
                        let v1884 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1884 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1884 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1884 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1884 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1884 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1884 = () 
                        #endif
#else
                        let v1885 : (string -> unit) = v132.Push
                        v1885 v1879
                        let _v1884 = () 
                        #endif
                        _v1884 
                        let v1886 : System.Threading.Tasks.TaskCanceledException = v1858 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1889 : unit = ()
                        let v1890 : (unit -> unit) = closure25(v1886)
                        let v1891 : unit = (fun () -> v1890 (); v1889) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v3180 : Async<int32> = _v1833 
            let _v475 = v3180 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v3181 : unit = ()
            let _v3181 =
                async {
                    try
                    let v3184 : System.Threading.Tasks.Task = v130.WaitForExitAsync v470 
                    let v3185 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v3186 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3187 : Async<unit> = v3186 v3184
                    let _v3185 = v3187 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v3188 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3189 : Async<unit> = v3188 v3184
                    let _v3185 = v3189 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v3190 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3191 : Async<unit> = v3190 v3184
                    let _v3185 = v3191 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v3192 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3193 : Async<unit> = v3192 v3184
                    let _v3185 = v3193 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v3194 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3195 : Async<unit> = v3194 v3184
                    let _v3185 = v3195 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v3196 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3197 : Async<unit> = v3196 v3184
                    let _v3185 = v3197 
                    #endif
#else
                    let v3198 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v3199 : Async<unit> = v3198 v3184
                    let _v3185 = v3199 
                    #endif
                    let v3200 : Async<unit> = _v3185 
                    do! v3200 
                    let v3205 : int32 = v130.ExitCode
                    return v3205 
                    with ex ->
                        let v3206 : exn = ex
                        let v3207 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v3208 : string = $"%A{v3206}"
                        let _v3207 = v3208 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v3211 : string = $"%A{v3206}"
                        let _v3207 = v3211 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v3214 : string = $"%A{v3206}"
                        let _v3207 = v3214 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v3217 : string = $"%A{v3206}"
                        let _v3207 = v3217 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v3220 : string = $"%A{v3206}"
                        let _v3207 = v3220 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v3223 : string = $"%A{v3206}"
                        let _v3207 = v3223 
                        #endif
#else
                        let v3226 : string = $"{v3206.GetType ()}: {v3206.Message}"
                        let _v3207 = v3226 
                        #endif
                        let v3227 : string = _v3207 
                        let v3232 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v3232 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v3232 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v3232 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v3232 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v3232 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v3232 = () 
                        #endif
#else
                        let v3233 : (string -> unit) = v132.Push
                        v3233 v3227
                        let _v3232 = () 
                        #endif
                        _v3232 
                        let v3234 : System.Threading.Tasks.TaskCanceledException = v3206 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v3237 : unit = ()
                        let v3238 : (unit -> unit) = closure25(v3234)
                        let v3239 : unit = (fun () -> v3238 (); v3237) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v4528 : Async<int32> = _v3181 
            let _v475 = v4528 
            #endif
#else
            let v4529 : unit = ()
            let _v4529 =
                async {
                    try
                    let v4532 : System.Threading.Tasks.Task = v130.WaitForExitAsync v470 
                    let v4533 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v4534 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4535 : Async<unit> = v4534 v4532
                    let _v4533 = v4535 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v4536 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4537 : Async<unit> = v4536 v4532
                    let _v4533 = v4537 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v4538 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4539 : Async<unit> = v4538 v4532
                    let _v4533 = v4539 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v4540 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4541 : Async<unit> = v4540 v4532
                    let _v4533 = v4541 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v4542 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4543 : Async<unit> = v4542 v4532
                    let _v4533 = v4543 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v4544 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4545 : Async<unit> = v4544 v4532
                    let _v4533 = v4545 
                    #endif
#else
                    let v4546 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v4547 : Async<unit> = v4546 v4532
                    let _v4533 = v4547 
                    #endif
                    let v4548 : Async<unit> = _v4533 
                    do! v4548 
                    let v4553 : int32 = v130.ExitCode
                    return v4553 
                    with ex ->
                        let v4554 : exn = ex
                        let v4555 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v4556 : string = $"%A{v4554}"
                        let _v4555 = v4556 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v4559 : string = $"%A{v4554}"
                        let _v4555 = v4559 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v4562 : string = $"%A{v4554}"
                        let _v4555 = v4562 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v4565 : string = $"%A{v4554}"
                        let _v4555 = v4565 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v4568 : string = $"%A{v4554}"
                        let _v4555 = v4568 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v4571 : string = $"%A{v4554}"
                        let _v4555 = v4571 
                        #endif
#else
                        let v4574 : string = $"{v4554.GetType ()}: {v4554.Message}"
                        let _v4555 = v4574 
                        #endif
                        let v4575 : string = _v4555 
                        let v4580 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v4580 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v4580 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v4580 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v4580 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v4580 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v4580 = () 
                        #endif
#else
                        let v4581 : (string -> unit) = v132.Push
                        v4581 v4575
                        let _v4580 = () 
                        #endif
                        _v4580 
                        let v4582 : System.Threading.Tasks.TaskCanceledException = v4554 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v4585 : unit = ()
                        let v4586 : (unit -> unit) = closure25(v4582)
                        let v4587 : unit = (fun () -> v4586 (); v4585) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v5876 : Async<int32> = _v4529 
            let _v475 = v5876 
            #endif
            let v5877 : Async<int32> = _v475 
            let! v5877 = v5877 
            let v6555 : int32 = v5877 
            let v6556 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v6557 : string seq = v6556 v132
            let v6560 : (string seq -> string seq) = Seq.rev
            let v6561 : string seq = v6560 v6557
            let v6564 : string = method45()
            let v6565 : (string -> (string seq -> string)) = String.concat
            let v6566 : (string seq -> string) = v6565 v6564
            let v6567 : string = v6566 v6561
            let v6571 : unit = ()
            let v6572 : (unit -> unit) = closure26(v6555, v6567)
            let v6573 : unit = (fun () -> v6572 (); v6571) ()
            return struct (v6555, v6567) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v52639 : Async<struct (int32 * string)> = _v36 
    let _v26 = v52639 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52640 : unit = ()
    let _v52640 =
        async {
            let v52643 : US6 = method22(v0)
            let struct (v52654 : string, v52655 : US5) =
                match v52643 with
                | US6_1(v52646) -> (* Error *)
                    let v52647 : string = $"resultm.get / Result value was Error: {v52646}"
                    failwith<struct (string * US5)> v52647
                | US6_0(v52644, v52645) -> (* Ok *)
                    struct (v52644, v52645)
            let v52656 : (string -> US5) = method5()
            let v52657 : US5 option = v6 |> Option.map v52656 
            let v52668 : US5 = US5_1
            let v52669 : US5 = v52657 |> Option.defaultValue v52668 
            let v52676 : string =
                match v52669 with
                | US5_1 -> (* None *)
                    let v52674 : string = ""
                    v52674
                | US5_0(v52673) -> (* Some *)
                    v52673
            let v52677 : unit = ()
            let v52678 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v52655, v52654)
            let v52679 : unit = (fun () -> v52678 (); v52677) ()
            let v52719 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v52723 : string =
                match v52655 with
                | US5_1 -> (* None *)
                    let v52721 : string = ""
                    v52721
                | US5_0(v52720) -> (* Some *)
                    v52720
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v52723,
              StandardOutputEncoding = v52719,
              WorkingDirectory = v52676,
              FileName = v52654,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v52724 : System.Diagnostics.ProcessStartInfo = start_info
            let v52725 : (struct (string * string) []) = method38(v0, v1, v2, v3, v4, v5, v6)
            let v52726 : int32 = v52725.Length
            let v52727 : Mut5 = {l0 = 0} : Mut5
            while method24(v52726, v52727) do
                let v52729 : int32 = v52727.l0
                let struct (v52730 : string, v52731 : string) = v52725.[int v52729]
                v52724.EnvironmentVariables.[v52730] <- v52731 
                let v52732 : int32 = v52729 + 1
                v52727.l0 <- v52732
                ()
            let v52733 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v52724)
            use v52733 = v52733 
            let v52734 : System.Diagnostics.Process = v52733 
            let v52735 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v52736 : System.Collections.Concurrent.ConcurrentStack<string> = v52735 ()
            let v52737 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v52734, v52736)
            v52734.OutputDataReceived.Add v52737 
            let v52738 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v52734, v52736)
            v52734.ErrorDataReceived.Add v52738 
            let v52739 : (unit -> bool) = v52734.Start
            let v52740 : bool = v52739 ()
            let v52741 : bool = v52740 = false
            if v52741 then
                let v52742 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v52742
            let v52743 : (unit -> unit) = v52734.BeginErrorReadLine
            v52743 ()
            let v52744 : (unit -> unit) = v52734.BeginOutputReadLine
            v52744 ()
            let v52745 : (System.Threading.CancellationToken -> US15) = method42()
            let v52746 : US15 option = v1 |> Option.map v52745 
            let v52757 : US15 = US15_1
            let v52758 : US15 = v52746 |> Option.defaultValue v52757 
            let v52765 : System.Threading.CancellationToken =
                match v52758 with
                | US15_1 -> (* None *)
                    let v52763 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v52763
                | US15_0(v52762) -> (* Some *)
                    v52762
            let v52766 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52767 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52766 = v52767 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52770 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52766 = v52770 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52773 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52766 = v52773 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52776 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52766 = v52776 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52779 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52766 = v52779 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52782 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52766 = v52782 
            #endif
#else
            let v52785 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v52786 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52785 = v52786 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v52789 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52785 = v52789 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v52792 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v52785 = v52792 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v52795 : unit = ()
            let _v52795 =
                async {
                    let v52798 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v52798 = v52798 
                    let v52799 : System.Threading.CancellationToken = v52798 
                    let v52800 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v52801 : (System.Threading.CancellationToken []) = [|v52799; v52800; v52765|]
                    let v52802 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v52803 : System.Threading.CancellationTokenSource = v52802 v52801
                    let v52804 : System.Threading.CancellationToken = v52803.Token
                    return v52804 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52854 : Async<System.Threading.CancellationToken> = _v52795 
            let _v52785 = v52854 
            #endif
#if FABLE_COMPILER_PYTHON
            let v52855 : unit = ()
            let _v52855 =
                async {
                    let v52858 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v52858 = v52858 
                    let v52859 : System.Threading.CancellationToken = v52858 
                    let v52860 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v52861 : (System.Threading.CancellationToken []) = [|v52859; v52860; v52765|]
                    let v52862 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v52863 : System.Threading.CancellationTokenSource = v52862 v52861
                    let v52864 : System.Threading.CancellationToken = v52863.Token
                    return v52864 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52914 : Async<System.Threading.CancellationToken> = _v52855 
            let _v52785 = v52914 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v52915 : unit = ()
            let _v52915 =
                async {
                    let v52918 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v52918 = v52918 
                    let v52919 : System.Threading.CancellationToken = v52918 
                    let v52920 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v52921 : (System.Threading.CancellationToken []) = [|v52919; v52920; v52765|]
                    let v52922 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v52923 : System.Threading.CancellationTokenSource = v52922 v52921
                    let v52924 : System.Threading.CancellationToken = v52923.Token
                    return v52924 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v52974 : Async<System.Threading.CancellationToken> = _v52915 
            let _v52785 = v52974 
            #endif
#else
            let v52975 : unit = ()
            let _v52975 =
                async {
                    let v52978 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v52978 = v52978 
                    let v52979 : System.Threading.CancellationToken = v52978 
                    let v52980 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v52981 : (System.Threading.CancellationToken []) = [|v52979; v52980; v52765|]
                    let v52982 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v52983 : System.Threading.CancellationTokenSource = v52982 v52981
                    let v52984 : System.Threading.CancellationToken = v52983.Token
                    return v52984 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v53034 : Async<System.Threading.CancellationToken> = _v52975 
            let _v52785 = v53034 
            #endif
            let v53035 : Async<System.Threading.CancellationToken> = _v52785 
            let _v52766 = v53035 
            #endif
            let v53069 : Async<System.Threading.CancellationToken> = _v52766 
            let! v53069 = v53069 
            let v53074 : System.Threading.CancellationToken = v53069 
            let v53075 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v53074.Register
            let v53076 : (unit -> unit) = closure24(v52734)
            let v53077 : System.Threading.CancellationTokenRegistration = v53075 v53076
            use v53077 = v53077 
            let v53078 : System.Threading.CancellationTokenRegistration = v53077 
            let v53079 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v53080 : Async<int32> = null |> unbox<Async<int32>>
            let _v53079 = v53080 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v53083 : Async<int32> = null |> unbox<Async<int32>>
            let _v53079 = v53083 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v53086 : Async<int32> = null |> unbox<Async<int32>>
            let _v53079 = v53086 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v53089 : unit = ()
            let _v53089 =
                async {
                    try
                    let v53092 : System.Threading.Tasks.Task = v52734.WaitForExitAsync v53074 
                    let v53093 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v53094 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53095 : Async<unit> = v53094 v53092
                    let _v53093 = v53095 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v53096 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53097 : Async<unit> = v53096 v53092
                    let _v53093 = v53097 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v53098 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53099 : Async<unit> = v53098 v53092
                    let _v53093 = v53099 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v53100 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53101 : Async<unit> = v53100 v53092
                    let _v53093 = v53101 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v53102 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53103 : Async<unit> = v53102 v53092
                    let _v53093 = v53103 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v53104 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53105 : Async<unit> = v53104 v53092
                    let _v53093 = v53105 
                    #endif
#else
                    let v53106 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v53107 : Async<unit> = v53106 v53092
                    let _v53093 = v53107 
                    #endif
                    let v53108 : Async<unit> = _v53093 
                    do! v53108 
                    let v53113 : int32 = v52734.ExitCode
                    return v53113 
                    with ex ->
                        let v53114 : exn = ex
                        let v53115 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v53116 : string = $"%A{v53114}"
                        let _v53115 = v53116 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v53119 : string = $"%A{v53114}"
                        let _v53115 = v53119 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v53122 : string = $"%A{v53114}"
                        let _v53115 = v53122 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v53125 : string = $"%A{v53114}"
                        let _v53115 = v53125 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v53128 : string = $"%A{v53114}"
                        let _v53115 = v53128 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v53131 : string = $"%A{v53114}"
                        let _v53115 = v53131 
                        #endif
#else
                        let v53134 : string = $"{v53114.GetType ()}: {v53114.Message}"
                        let _v53115 = v53134 
                        #endif
                        let v53135 : string = _v53115 
                        let v53140 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v53140 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v53140 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v53140 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v53140 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v53140 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v53140 = () 
                        #endif
#else
                        let v53141 : (string -> unit) = v52736.Push
                        v53141 v53135
                        let _v53140 = () 
                        #endif
                        _v53140 
                        let v53142 : System.Threading.Tasks.TaskCanceledException = v53114 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v53145 : unit = ()
                        let v53146 : (unit -> unit) = closure25(v53142)
                        let v53147 : unit = (fun () -> v53146 (); v53145) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v54436 : Async<int32> = _v53089 
            let _v53079 = v54436 
            #endif
#if FABLE_COMPILER_PYTHON
            let v54437 : unit = ()
            let _v54437 =
                async {
                    try
                    let v54440 : System.Threading.Tasks.Task = v52734.WaitForExitAsync v53074 
                    let v54441 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v54442 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54443 : Async<unit> = v54442 v54440
                    let _v54441 = v54443 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v54444 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54445 : Async<unit> = v54444 v54440
                    let _v54441 = v54445 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v54446 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54447 : Async<unit> = v54446 v54440
                    let _v54441 = v54447 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v54448 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54449 : Async<unit> = v54448 v54440
                    let _v54441 = v54449 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v54450 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54451 : Async<unit> = v54450 v54440
                    let _v54441 = v54451 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v54452 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54453 : Async<unit> = v54452 v54440
                    let _v54441 = v54453 
                    #endif
#else
                    let v54454 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v54455 : Async<unit> = v54454 v54440
                    let _v54441 = v54455 
                    #endif
                    let v54456 : Async<unit> = _v54441 
                    do! v54456 
                    let v54461 : int32 = v52734.ExitCode
                    return v54461 
                    with ex ->
                        let v54462 : exn = ex
                        let v54463 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v54464 : string = $"%A{v54462}"
                        let _v54463 = v54464 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v54467 : string = $"%A{v54462}"
                        let _v54463 = v54467 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v54470 : string = $"%A{v54462}"
                        let _v54463 = v54470 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v54473 : string = $"%A{v54462}"
                        let _v54463 = v54473 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v54476 : string = $"%A{v54462}"
                        let _v54463 = v54476 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v54479 : string = $"%A{v54462}"
                        let _v54463 = v54479 
                        #endif
#else
                        let v54482 : string = $"{v54462.GetType ()}: {v54462.Message}"
                        let _v54463 = v54482 
                        #endif
                        let v54483 : string = _v54463 
                        let v54488 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v54488 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v54488 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v54488 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v54488 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v54488 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v54488 = () 
                        #endif
#else
                        let v54489 : (string -> unit) = v52736.Push
                        v54489 v54483
                        let _v54488 = () 
                        #endif
                        _v54488 
                        let v54490 : System.Threading.Tasks.TaskCanceledException = v54462 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v54493 : unit = ()
                        let v54494 : (unit -> unit) = closure25(v54490)
                        let v54495 : unit = (fun () -> v54494 (); v54493) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v55784 : Async<int32> = _v54437 
            let _v53079 = v55784 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v55785 : unit = ()
            let _v55785 =
                async {
                    try
                    let v55788 : System.Threading.Tasks.Task = v52734.WaitForExitAsync v53074 
                    let v55789 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v55790 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55791 : Async<unit> = v55790 v55788
                    let _v55789 = v55791 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v55792 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55793 : Async<unit> = v55792 v55788
                    let _v55789 = v55793 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v55794 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55795 : Async<unit> = v55794 v55788
                    let _v55789 = v55795 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v55796 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55797 : Async<unit> = v55796 v55788
                    let _v55789 = v55797 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v55798 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55799 : Async<unit> = v55798 v55788
                    let _v55789 = v55799 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v55800 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55801 : Async<unit> = v55800 v55788
                    let _v55789 = v55801 
                    #endif
#else
                    let v55802 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v55803 : Async<unit> = v55802 v55788
                    let _v55789 = v55803 
                    #endif
                    let v55804 : Async<unit> = _v55789 
                    do! v55804 
                    let v55809 : int32 = v52734.ExitCode
                    return v55809 
                    with ex ->
                        let v55810 : exn = ex
                        let v55811 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v55812 : string = $"%A{v55810}"
                        let _v55811 = v55812 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v55815 : string = $"%A{v55810}"
                        let _v55811 = v55815 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v55818 : string = $"%A{v55810}"
                        let _v55811 = v55818 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v55821 : string = $"%A{v55810}"
                        let _v55811 = v55821 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v55824 : string = $"%A{v55810}"
                        let _v55811 = v55824 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v55827 : string = $"%A{v55810}"
                        let _v55811 = v55827 
                        #endif
#else
                        let v55830 : string = $"{v55810.GetType ()}: {v55810.Message}"
                        let _v55811 = v55830 
                        #endif
                        let v55831 : string = _v55811 
                        let v55836 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v55836 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v55836 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v55836 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v55836 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v55836 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v55836 = () 
                        #endif
#else
                        let v55837 : (string -> unit) = v52736.Push
                        v55837 v55831
                        let _v55836 = () 
                        #endif
                        _v55836 
                        let v55838 : System.Threading.Tasks.TaskCanceledException = v55810 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v55841 : unit = ()
                        let v55842 : (unit -> unit) = closure25(v55838)
                        let v55843 : unit = (fun () -> v55842 (); v55841) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v57132 : Async<int32> = _v55785 
            let _v53079 = v57132 
            #endif
#else
            let v57133 : unit = ()
            let _v57133 =
                async {
                    try
                    let v57136 : System.Threading.Tasks.Task = v52734.WaitForExitAsync v53074 
                    let v57137 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v57138 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57139 : Async<unit> = v57138 v57136
                    let _v57137 = v57139 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v57140 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57141 : Async<unit> = v57140 v57136
                    let _v57137 = v57141 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v57142 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57143 : Async<unit> = v57142 v57136
                    let _v57137 = v57143 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v57144 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57145 : Async<unit> = v57144 v57136
                    let _v57137 = v57145 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v57146 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57147 : Async<unit> = v57146 v57136
                    let _v57137 = v57147 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v57148 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57149 : Async<unit> = v57148 v57136
                    let _v57137 = v57149 
                    #endif
#else
                    let v57150 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v57151 : Async<unit> = v57150 v57136
                    let _v57137 = v57151 
                    #endif
                    let v57152 : Async<unit> = _v57137 
                    do! v57152 
                    let v57157 : int32 = v52734.ExitCode
                    return v57157 
                    with ex ->
                        let v57158 : exn = ex
                        let v57159 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v57160 : string = $"%A{v57158}"
                        let _v57159 = v57160 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v57163 : string = $"%A{v57158}"
                        let _v57159 = v57163 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v57166 : string = $"%A{v57158}"
                        let _v57159 = v57166 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v57169 : string = $"%A{v57158}"
                        let _v57159 = v57169 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v57172 : string = $"%A{v57158}"
                        let _v57159 = v57172 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v57175 : string = $"%A{v57158}"
                        let _v57159 = v57175 
                        #endif
#else
                        let v57178 : string = $"{v57158.GetType ()}: {v57158.Message}"
                        let _v57159 = v57178 
                        #endif
                        let v57179 : string = _v57159 
                        let v57184 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v57184 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v57184 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v57184 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v57184 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v57184 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v57184 = () 
                        #endif
#else
                        let v57185 : (string -> unit) = v52736.Push
                        v57185 v57179
                        let _v57184 = () 
                        #endif
                        _v57184 
                        let v57186 : System.Threading.Tasks.TaskCanceledException = v57158 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v57189 : unit = ()
                        let v57190 : (unit -> unit) = closure25(v57186)
                        let v57191 : unit = (fun () -> v57190 (); v57189) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v58480 : Async<int32> = _v57133 
            let _v53079 = v58480 
            #endif
            let v58481 : Async<int32> = _v53079 
            let! v58481 = v58481 
            let v59159 : int32 = v58481 
            let v59160 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v59161 : string seq = v59160 v52736
            let v59164 : (string seq -> string seq) = Seq.rev
            let v59165 : string seq = v59164 v59161
            let v59168 : string = method45()
            let v59169 : (string -> (string seq -> string)) = String.concat
            let v59170 : (string seq -> string) = v59169 v59168
            let v59171 : string = v59170 v59165
            let v59175 : unit = ()
            let v59176 : (unit -> unit) = closure26(v59159, v59171)
            let v59177 : unit = (fun () -> v59176 (); v59175) ()
            return struct (v59159, v59171) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v105243 : Async<struct (int32 * string)> = _v52640 
    let _v26 = v105243 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v105244 : unit = ()
    let _v105244 =
        async {
            let v105247 : US6 = method22(v0)
            let struct (v105258 : string, v105259 : US5) =
                match v105247 with
                | US6_1(v105250) -> (* Error *)
                    let v105251 : string = $"resultm.get / Result value was Error: {v105250}"
                    failwith<struct (string * US5)> v105251
                | US6_0(v105248, v105249) -> (* Ok *)
                    struct (v105248, v105249)
            let v105260 : (string -> US5) = method5()
            let v105261 : US5 option = v6 |> Option.map v105260 
            let v105272 : US5 = US5_1
            let v105273 : US5 = v105261 |> Option.defaultValue v105272 
            let v105280 : string =
                match v105273 with
                | US5_1 -> (* None *)
                    let v105278 : string = ""
                    v105278
                | US5_0(v105277) -> (* Some *)
                    v105277
            let v105281 : unit = ()
            let v105282 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v105259, v105258)
            let v105283 : unit = (fun () -> v105282 (); v105281) ()
            let v105323 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v105327 : string =
                match v105259 with
                | US5_1 -> (* None *)
                    let v105325 : string = ""
                    v105325
                | US5_0(v105324) -> (* Some *)
                    v105324
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v105327,
              StandardOutputEncoding = v105323,
              WorkingDirectory = v105280,
              FileName = v105258,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v105328 : System.Diagnostics.ProcessStartInfo = start_info
            let v105329 : (struct (string * string) []) = method38(v0, v1, v2, v3, v4, v5, v6)
            let v105330 : int32 = v105329.Length
            let v105331 : Mut5 = {l0 = 0} : Mut5
            while method24(v105330, v105331) do
                let v105333 : int32 = v105331.l0
                let struct (v105334 : string, v105335 : string) = v105329.[int v105333]
                v105328.EnvironmentVariables.[v105334] <- v105335 
                let v105336 : int32 = v105333 + 1
                v105331.l0 <- v105336
                ()
            let v105337 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v105328)
            use v105337 = v105337 
            let v105338 : System.Diagnostics.Process = v105337 
            let v105339 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v105340 : System.Collections.Concurrent.ConcurrentStack<string> = v105339 ()
            let v105341 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v105338, v105340)
            v105338.OutputDataReceived.Add v105341 
            let v105342 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v105338, v105340)
            v105338.ErrorDataReceived.Add v105342 
            let v105343 : (unit -> bool) = v105338.Start
            let v105344 : bool = v105343 ()
            let v105345 : bool = v105344 = false
            if v105345 then
                let v105346 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v105346
            let v105347 : (unit -> unit) = v105338.BeginErrorReadLine
            v105347 ()
            let v105348 : (unit -> unit) = v105338.BeginOutputReadLine
            v105348 ()
            let v105349 : (System.Threading.CancellationToken -> US15) = method42()
            let v105350 : US15 option = v1 |> Option.map v105349 
            let v105361 : US15 = US15_1
            let v105362 : US15 = v105350 |> Option.defaultValue v105361 
            let v105369 : System.Threading.CancellationToken =
                match v105362 with
                | US15_1 -> (* None *)
                    let v105367 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v105367
                | US15_0(v105366) -> (* Some *)
                    v105366
            let v105370 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v105371 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105370 = v105371 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v105374 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105370 = v105374 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v105377 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105370 = v105377 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v105380 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105370 = v105380 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105383 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105370 = v105383 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v105386 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105370 = v105386 
            #endif
#else
            let v105389 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v105390 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105389 = v105390 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v105393 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105389 = v105393 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v105396 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v105389 = v105396 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v105399 : unit = ()
            let _v105399 =
                async {
                    let v105402 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v105402 = v105402 
                    let v105403 : System.Threading.CancellationToken = v105402 
                    let v105404 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v105405 : (System.Threading.CancellationToken []) = [|v105403; v105404; v105369|]
                    let v105406 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v105407 : System.Threading.CancellationTokenSource = v105406 v105405
                    let v105408 : System.Threading.CancellationToken = v105407.Token
                    return v105408 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105458 : Async<System.Threading.CancellationToken> = _v105399 
            let _v105389 = v105458 
            #endif
#if FABLE_COMPILER_PYTHON
            let v105459 : unit = ()
            let _v105459 =
                async {
                    let v105462 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v105462 = v105462 
                    let v105463 : System.Threading.CancellationToken = v105462 
                    let v105464 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v105465 : (System.Threading.CancellationToken []) = [|v105463; v105464; v105369|]
                    let v105466 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v105467 : System.Threading.CancellationTokenSource = v105466 v105465
                    let v105468 : System.Threading.CancellationToken = v105467.Token
                    return v105468 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105518 : Async<System.Threading.CancellationToken> = _v105459 
            let _v105389 = v105518 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v105519 : unit = ()
            let _v105519 =
                async {
                    let v105522 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v105522 = v105522 
                    let v105523 : System.Threading.CancellationToken = v105522 
                    let v105524 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v105525 : (System.Threading.CancellationToken []) = [|v105523; v105524; v105369|]
                    let v105526 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v105527 : System.Threading.CancellationTokenSource = v105526 v105525
                    let v105528 : System.Threading.CancellationToken = v105527.Token
                    return v105528 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105578 : Async<System.Threading.CancellationToken> = _v105519 
            let _v105389 = v105578 
            #endif
#else
            let v105579 : unit = ()
            let _v105579 =
                async {
                    let v105582 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v105582 = v105582 
                    let v105583 : System.Threading.CancellationToken = v105582 
                    let v105584 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v105585 : (System.Threading.CancellationToken []) = [|v105583; v105584; v105369|]
                    let v105586 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v105587 : System.Threading.CancellationTokenSource = v105586 v105585
                    let v105588 : System.Threading.CancellationToken = v105587.Token
                    return v105588 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v105638 : Async<System.Threading.CancellationToken> = _v105579 
            let _v105389 = v105638 
            #endif
            let v105639 : Async<System.Threading.CancellationToken> = _v105389 
            let _v105370 = v105639 
            #endif
            let v105673 : Async<System.Threading.CancellationToken> = _v105370 
            let! v105673 = v105673 
            let v105678 : System.Threading.CancellationToken = v105673 
            let v105679 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v105678.Register
            let v105680 : (unit -> unit) = closure24(v105338)
            let v105681 : System.Threading.CancellationTokenRegistration = v105679 v105680
            use v105681 = v105681 
            let v105682 : System.Threading.CancellationTokenRegistration = v105681 
            let v105683 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v105684 : Async<int32> = null |> unbox<Async<int32>>
            let _v105683 = v105684 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v105687 : Async<int32> = null |> unbox<Async<int32>>
            let _v105683 = v105687 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v105690 : Async<int32> = null |> unbox<Async<int32>>
            let _v105683 = v105690 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v105693 : unit = ()
            let _v105693 =
                async {
                    try
                    let v105696 : System.Threading.Tasks.Task = v105338.WaitForExitAsync v105678 
                    let v105697 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v105698 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105699 : Async<unit> = v105698 v105696
                    let _v105697 = v105699 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v105700 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105701 : Async<unit> = v105700 v105696
                    let _v105697 = v105701 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v105702 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105703 : Async<unit> = v105702 v105696
                    let _v105697 = v105703 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v105704 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105705 : Async<unit> = v105704 v105696
                    let _v105697 = v105705 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v105706 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105707 : Async<unit> = v105706 v105696
                    let _v105697 = v105707 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v105708 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105709 : Async<unit> = v105708 v105696
                    let _v105697 = v105709 
                    #endif
#else
                    let v105710 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v105711 : Async<unit> = v105710 v105696
                    let _v105697 = v105711 
                    #endif
                    let v105712 : Async<unit> = _v105697 
                    do! v105712 
                    let v105717 : int32 = v105338.ExitCode
                    return v105717 
                    with ex ->
                        let v105718 : exn = ex
                        let v105719 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v105720 : string = $"%A{v105718}"
                        let _v105719 = v105720 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v105723 : string = $"%A{v105718}"
                        let _v105719 = v105723 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v105726 : string = $"%A{v105718}"
                        let _v105719 = v105726 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v105729 : string = $"%A{v105718}"
                        let _v105719 = v105729 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v105732 : string = $"%A{v105718}"
                        let _v105719 = v105732 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v105735 : string = $"%A{v105718}"
                        let _v105719 = v105735 
                        #endif
#else
                        let v105738 : string = $"{v105718.GetType ()}: {v105718.Message}"
                        let _v105719 = v105738 
                        #endif
                        let v105739 : string = _v105719 
                        let v105744 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v105744 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v105744 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v105744 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v105744 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v105744 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v105744 = () 
                        #endif
#else
                        let v105745 : (string -> unit) = v105340.Push
                        v105745 v105739
                        let _v105744 = () 
                        #endif
                        _v105744 
                        let v105746 : System.Threading.Tasks.TaskCanceledException = v105718 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v105749 : unit = ()
                        let v105750 : (unit -> unit) = closure25(v105746)
                        let v105751 : unit = (fun () -> v105750 (); v105749) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v107040 : Async<int32> = _v105693 
            let _v105683 = v107040 
            #endif
#if FABLE_COMPILER_PYTHON
            let v107041 : unit = ()
            let _v107041 =
                async {
                    try
                    let v107044 : System.Threading.Tasks.Task = v105338.WaitForExitAsync v105678 
                    let v107045 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v107046 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107047 : Async<unit> = v107046 v107044
                    let _v107045 = v107047 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v107048 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107049 : Async<unit> = v107048 v107044
                    let _v107045 = v107049 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v107050 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107051 : Async<unit> = v107050 v107044
                    let _v107045 = v107051 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v107052 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107053 : Async<unit> = v107052 v107044
                    let _v107045 = v107053 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v107054 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107055 : Async<unit> = v107054 v107044
                    let _v107045 = v107055 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v107056 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107057 : Async<unit> = v107056 v107044
                    let _v107045 = v107057 
                    #endif
#else
                    let v107058 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v107059 : Async<unit> = v107058 v107044
                    let _v107045 = v107059 
                    #endif
                    let v107060 : Async<unit> = _v107045 
                    do! v107060 
                    let v107065 : int32 = v105338.ExitCode
                    return v107065 
                    with ex ->
                        let v107066 : exn = ex
                        let v107067 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v107068 : string = $"%A{v107066}"
                        let _v107067 = v107068 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v107071 : string = $"%A{v107066}"
                        let _v107067 = v107071 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v107074 : string = $"%A{v107066}"
                        let _v107067 = v107074 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v107077 : string = $"%A{v107066}"
                        let _v107067 = v107077 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v107080 : string = $"%A{v107066}"
                        let _v107067 = v107080 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v107083 : string = $"%A{v107066}"
                        let _v107067 = v107083 
                        #endif
#else
                        let v107086 : string = $"{v107066.GetType ()}: {v107066.Message}"
                        let _v107067 = v107086 
                        #endif
                        let v107087 : string = _v107067 
                        let v107092 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v107092 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v107092 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v107092 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v107092 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v107092 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v107092 = () 
                        #endif
#else
                        let v107093 : (string -> unit) = v105340.Push
                        v107093 v107087
                        let _v107092 = () 
                        #endif
                        _v107092 
                        let v107094 : System.Threading.Tasks.TaskCanceledException = v107066 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v107097 : unit = ()
                        let v107098 : (unit -> unit) = closure25(v107094)
                        let v107099 : unit = (fun () -> v107098 (); v107097) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v108388 : Async<int32> = _v107041 
            let _v105683 = v108388 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v108389 : unit = ()
            let _v108389 =
                async {
                    try
                    let v108392 : System.Threading.Tasks.Task = v105338.WaitForExitAsync v105678 
                    let v108393 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v108394 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108395 : Async<unit> = v108394 v108392
                    let _v108393 = v108395 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v108396 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108397 : Async<unit> = v108396 v108392
                    let _v108393 = v108397 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v108398 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108399 : Async<unit> = v108398 v108392
                    let _v108393 = v108399 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v108400 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108401 : Async<unit> = v108400 v108392
                    let _v108393 = v108401 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v108402 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108403 : Async<unit> = v108402 v108392
                    let _v108393 = v108403 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v108404 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108405 : Async<unit> = v108404 v108392
                    let _v108393 = v108405 
                    #endif
#else
                    let v108406 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v108407 : Async<unit> = v108406 v108392
                    let _v108393 = v108407 
                    #endif
                    let v108408 : Async<unit> = _v108393 
                    do! v108408 
                    let v108413 : int32 = v105338.ExitCode
                    return v108413 
                    with ex ->
                        let v108414 : exn = ex
                        let v108415 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v108416 : string = $"%A{v108414}"
                        let _v108415 = v108416 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v108419 : string = $"%A{v108414}"
                        let _v108415 = v108419 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v108422 : string = $"%A{v108414}"
                        let _v108415 = v108422 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v108425 : string = $"%A{v108414}"
                        let _v108415 = v108425 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v108428 : string = $"%A{v108414}"
                        let _v108415 = v108428 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v108431 : string = $"%A{v108414}"
                        let _v108415 = v108431 
                        #endif
#else
                        let v108434 : string = $"{v108414.GetType ()}: {v108414.Message}"
                        let _v108415 = v108434 
                        #endif
                        let v108435 : string = _v108415 
                        let v108440 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v108440 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v108440 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v108440 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v108440 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v108440 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v108440 = () 
                        #endif
#else
                        let v108441 : (string -> unit) = v105340.Push
                        v108441 v108435
                        let _v108440 = () 
                        #endif
                        _v108440 
                        let v108442 : System.Threading.Tasks.TaskCanceledException = v108414 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v108445 : unit = ()
                        let v108446 : (unit -> unit) = closure25(v108442)
                        let v108447 : unit = (fun () -> v108446 (); v108445) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v109736 : Async<int32> = _v108389 
            let _v105683 = v109736 
            #endif
#else
            let v109737 : unit = ()
            let _v109737 =
                async {
                    try
                    let v109740 : System.Threading.Tasks.Task = v105338.WaitForExitAsync v105678 
                    let v109741 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v109742 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109743 : Async<unit> = v109742 v109740
                    let _v109741 = v109743 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v109744 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109745 : Async<unit> = v109744 v109740
                    let _v109741 = v109745 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v109746 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109747 : Async<unit> = v109746 v109740
                    let _v109741 = v109747 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v109748 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109749 : Async<unit> = v109748 v109740
                    let _v109741 = v109749 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v109750 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109751 : Async<unit> = v109750 v109740
                    let _v109741 = v109751 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v109752 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109753 : Async<unit> = v109752 v109740
                    let _v109741 = v109753 
                    #endif
#else
                    let v109754 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v109755 : Async<unit> = v109754 v109740
                    let _v109741 = v109755 
                    #endif
                    let v109756 : Async<unit> = _v109741 
                    do! v109756 
                    let v109761 : int32 = v105338.ExitCode
                    return v109761 
                    with ex ->
                        let v109762 : exn = ex
                        let v109763 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v109764 : string = $"%A{v109762}"
                        let _v109763 = v109764 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v109767 : string = $"%A{v109762}"
                        let _v109763 = v109767 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v109770 : string = $"%A{v109762}"
                        let _v109763 = v109770 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v109773 : string = $"%A{v109762}"
                        let _v109763 = v109773 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v109776 : string = $"%A{v109762}"
                        let _v109763 = v109776 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v109779 : string = $"%A{v109762}"
                        let _v109763 = v109779 
                        #endif
#else
                        let v109782 : string = $"{v109762.GetType ()}: {v109762.Message}"
                        let _v109763 = v109782 
                        #endif
                        let v109783 : string = _v109763 
                        let v109788 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v109788 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v109788 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v109788 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v109788 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v109788 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v109788 = () 
                        #endif
#else
                        let v109789 : (string -> unit) = v105340.Push
                        v109789 v109783
                        let _v109788 = () 
                        #endif
                        _v109788 
                        let v109790 : System.Threading.Tasks.TaskCanceledException = v109762 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v109793 : unit = ()
                        let v109794 : (unit -> unit) = closure25(v109790)
                        let v109795 : unit = (fun () -> v109794 (); v109793) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v111084 : Async<int32> = _v109737 
            let _v105683 = v111084 
            #endif
            let v111085 : Async<int32> = _v105683 
            let! v111085 = v111085 
            let v111763 : int32 = v111085 
            let v111764 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v111765 : string seq = v111764 v105340
            let v111768 : (string seq -> string seq) = Seq.rev
            let v111769 : string seq = v111768 v111765
            let v111772 : string = method45()
            let v111773 : (string -> (string seq -> string)) = String.concat
            let v111774 : (string seq -> string) = v111773 v111772
            let v111775 : string = v111774 v111769
            let v111779 : unit = ()
            let v111780 : (unit -> unit) = closure26(v111763, v111775)
            let v111781 : unit = (fun () -> v111780 (); v111779) ()
            return struct (v111763, v111775) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v157847 : Async<struct (int32 * string)> = _v105244 
    let _v26 = v157847 
    #endif
#else
    let v157848 : unit = ()
    let _v157848 =
        async {
            let v157851 : US6 = method22(v0)
            let struct (v157862 : string, v157863 : US5) =
                match v157851 with
                | US6_1(v157854) -> (* Error *)
                    let v157855 : string = $"resultm.get / Result value was Error: {v157854}"
                    failwith<struct (string * US5)> v157855
                | US6_0(v157852, v157853) -> (* Ok *)
                    struct (v157852, v157853)
            let v157864 : (string -> US5) = method5()
            let v157865 : US5 option = v6 |> Option.map v157864 
            let v157876 : US5 = US5_1
            let v157877 : US5 = v157865 |> Option.defaultValue v157876 
            let v157884 : string =
                match v157877 with
                | US5_1 -> (* None *)
                    let v157882 : string = ""
                    v157882
                | US5_0(v157881) -> (* Some *)
                    v157881
            let v157885 : unit = ()
            let v157886 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v157863, v157862)
            let v157887 : unit = (fun () -> v157886 (); v157885) ()
            let v157927 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v157931 : string =
                match v157863 with
                | US5_1 -> (* None *)
                    let v157929 : string = ""
                    v157929
                | US5_0(v157928) -> (* Some *)
                    v157928
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v157931,
              StandardOutputEncoding = v157927,
              WorkingDirectory = v157884,
              FileName = v157862,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v157932 : System.Diagnostics.ProcessStartInfo = start_info
            let v157933 : (struct (string * string) []) = method38(v0, v1, v2, v3, v4, v5, v6)
            let v157934 : int32 = v157933.Length
            let v157935 : Mut5 = {l0 = 0} : Mut5
            while method24(v157934, v157935) do
                let v157937 : int32 = v157935.l0
                let struct (v157938 : string, v157939 : string) = v157933.[int v157937]
                v157932.EnvironmentVariables.[v157938] <- v157939 
                let v157940 : int32 = v157937 + 1
                v157935.l0 <- v157940
                ()
            let v157941 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v157932)
            use v157941 = v157941 
            let v157942 : System.Diagnostics.Process = v157941 
            let v157943 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v157944 : System.Collections.Concurrent.ConcurrentStack<string> = v157943 ()
            let v157945 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v157942, v157944)
            v157942.OutputDataReceived.Add v157945 
            let v157946 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v157942, v157944)
            v157942.ErrorDataReceived.Add v157946 
            let v157947 : (unit -> bool) = v157942.Start
            let v157948 : bool = v157947 ()
            let v157949 : bool = v157948 = false
            if v157949 then
                let v157950 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v157950
            let v157951 : (unit -> unit) = v157942.BeginErrorReadLine
            v157951 ()
            let v157952 : (unit -> unit) = v157942.BeginOutputReadLine
            v157952 ()
            let v157953 : (System.Threading.CancellationToken -> US15) = method42()
            let v157954 : US15 option = v1 |> Option.map v157953 
            let v157965 : US15 = US15_1
            let v157966 : US15 = v157954 |> Option.defaultValue v157965 
            let v157973 : System.Threading.CancellationToken =
                match v157966 with
                | US15_1 -> (* None *)
                    let v157971 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v157971
                | US15_0(v157970) -> (* Some *)
                    v157970
            let v157974 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v157975 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157974 = v157975 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v157978 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157974 = v157978 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v157981 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157974 = v157981 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v157984 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157974 = v157984 
            #endif
#if FABLE_COMPILER_PYTHON
            let v157987 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157974 = v157987 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v157990 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157974 = v157990 
            #endif
#else
            let v157993 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v157994 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157993 = v157994 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v157997 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157993 = v157997 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v158000 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v157993 = v158000 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v158003 : unit = ()
            let _v158003 =
                async {
                    let v158006 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v158006 = v158006 
                    let v158007 : System.Threading.CancellationToken = v158006 
                    let v158008 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v158009 : (System.Threading.CancellationToken []) = [|v158007; v158008; v157973|]
                    let v158010 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v158011 : System.Threading.CancellationTokenSource = v158010 v158009
                    let v158012 : System.Threading.CancellationToken = v158011.Token
                    return v158012 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v158062 : Async<System.Threading.CancellationToken> = _v158003 
            let _v157993 = v158062 
            #endif
#if FABLE_COMPILER_PYTHON
            let v158063 : unit = ()
            let _v158063 =
                async {
                    let v158066 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v158066 = v158066 
                    let v158067 : System.Threading.CancellationToken = v158066 
                    let v158068 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v158069 : (System.Threading.CancellationToken []) = [|v158067; v158068; v157973|]
                    let v158070 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v158071 : System.Threading.CancellationTokenSource = v158070 v158069
                    let v158072 : System.Threading.CancellationToken = v158071.Token
                    return v158072 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v158122 : Async<System.Threading.CancellationToken> = _v158063 
            let _v157993 = v158122 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v158123 : unit = ()
            let _v158123 =
                async {
                    let v158126 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v158126 = v158126 
                    let v158127 : System.Threading.CancellationToken = v158126 
                    let v158128 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v158129 : (System.Threading.CancellationToken []) = [|v158127; v158128; v157973|]
                    let v158130 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v158131 : System.Threading.CancellationTokenSource = v158130 v158129
                    let v158132 : System.Threading.CancellationToken = v158131.Token
                    return v158132 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v158182 : Async<System.Threading.CancellationToken> = _v158123 
            let _v157993 = v158182 
            #endif
#else
            let v158183 : unit = ()
            let _v158183 =
                async {
                    let v158186 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v158186 = v158186 
                    let v158187 : System.Threading.CancellationToken = v158186 
                    let v158188 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v158189 : (System.Threading.CancellationToken []) = [|v158187; v158188; v157973|]
                    let v158190 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v158191 : System.Threading.CancellationTokenSource = v158190 v158189
                    let v158192 : System.Threading.CancellationToken = v158191.Token
                    return v158192 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v158242 : Async<System.Threading.CancellationToken> = _v158183 
            let _v157993 = v158242 
            #endif
            let v158243 : Async<System.Threading.CancellationToken> = _v157993 
            let _v157974 = v158243 
            #endif
            let v158277 : Async<System.Threading.CancellationToken> = _v157974 
            let! v158277 = v158277 
            let v158282 : System.Threading.CancellationToken = v158277 
            let v158283 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v158282.Register
            let v158284 : (unit -> unit) = closure24(v157942)
            let v158285 : System.Threading.CancellationTokenRegistration = v158283 v158284
            use v158285 = v158285 
            let v158286 : System.Threading.CancellationTokenRegistration = v158285 
            let v158287 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158288 : Async<int32> = null |> unbox<Async<int32>>
            let _v158287 = v158288 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v158291 : Async<int32> = null |> unbox<Async<int32>>
            let _v158287 = v158291 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v158294 : Async<int32> = null |> unbox<Async<int32>>
            let _v158287 = v158294 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v158297 : unit = ()
            let _v158297 =
                async {
                    try
                    let v158300 : System.Threading.Tasks.Task = v157942.WaitForExitAsync v158282 
                    let v158301 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v158302 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158303 : Async<unit> = v158302 v158300
                    let _v158301 = v158303 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v158304 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158305 : Async<unit> = v158304 v158300
                    let _v158301 = v158305 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v158306 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158307 : Async<unit> = v158306 v158300
                    let _v158301 = v158307 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v158308 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158309 : Async<unit> = v158308 v158300
                    let _v158301 = v158309 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v158310 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158311 : Async<unit> = v158310 v158300
                    let _v158301 = v158311 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v158312 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158313 : Async<unit> = v158312 v158300
                    let _v158301 = v158313 
                    #endif
#else
                    let v158314 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v158315 : Async<unit> = v158314 v158300
                    let _v158301 = v158315 
                    #endif
                    let v158316 : Async<unit> = _v158301 
                    do! v158316 
                    let v158321 : int32 = v157942.ExitCode
                    return v158321 
                    with ex ->
                        let v158322 : exn = ex
                        let v158323 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v158324 : string = $"%A{v158322}"
                        let _v158323 = v158324 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v158327 : string = $"%A{v158322}"
                        let _v158323 = v158327 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v158330 : string = $"%A{v158322}"
                        let _v158323 = v158330 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v158333 : string = $"%A{v158322}"
                        let _v158323 = v158333 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v158336 : string = $"%A{v158322}"
                        let _v158323 = v158336 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v158339 : string = $"%A{v158322}"
                        let _v158323 = v158339 
                        #endif
#else
                        let v158342 : string = $"{v158322.GetType ()}: {v158322.Message}"
                        let _v158323 = v158342 
                        #endif
                        let v158343 : string = _v158323 
                        let v158348 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v158348 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v158348 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v158348 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v158348 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v158348 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v158348 = () 
                        #endif
#else
                        let v158349 : (string -> unit) = v157944.Push
                        v158349 v158343
                        let _v158348 = () 
                        #endif
                        _v158348 
                        let v158350 : System.Threading.Tasks.TaskCanceledException = v158322 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v158353 : unit = ()
                        let v158354 : (unit -> unit) = closure25(v158350)
                        let v158355 : unit = (fun () -> v158354 (); v158353) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v159644 : Async<int32> = _v158297 
            let _v158287 = v159644 
            #endif
#if FABLE_COMPILER_PYTHON
            let v159645 : unit = ()
            let _v159645 =
                async {
                    try
                    let v159648 : System.Threading.Tasks.Task = v157942.WaitForExitAsync v158282 
                    let v159649 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v159650 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159651 : Async<unit> = v159650 v159648
                    let _v159649 = v159651 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v159652 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159653 : Async<unit> = v159652 v159648
                    let _v159649 = v159653 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v159654 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159655 : Async<unit> = v159654 v159648
                    let _v159649 = v159655 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v159656 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159657 : Async<unit> = v159656 v159648
                    let _v159649 = v159657 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v159658 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159659 : Async<unit> = v159658 v159648
                    let _v159649 = v159659 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v159660 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159661 : Async<unit> = v159660 v159648
                    let _v159649 = v159661 
                    #endif
#else
                    let v159662 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v159663 : Async<unit> = v159662 v159648
                    let _v159649 = v159663 
                    #endif
                    let v159664 : Async<unit> = _v159649 
                    do! v159664 
                    let v159669 : int32 = v157942.ExitCode
                    return v159669 
                    with ex ->
                        let v159670 : exn = ex
                        let v159671 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v159672 : string = $"%A{v159670}"
                        let _v159671 = v159672 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v159675 : string = $"%A{v159670}"
                        let _v159671 = v159675 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v159678 : string = $"%A{v159670}"
                        let _v159671 = v159678 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v159681 : string = $"%A{v159670}"
                        let _v159671 = v159681 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v159684 : string = $"%A{v159670}"
                        let _v159671 = v159684 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v159687 : string = $"%A{v159670}"
                        let _v159671 = v159687 
                        #endif
#else
                        let v159690 : string = $"{v159670.GetType ()}: {v159670.Message}"
                        let _v159671 = v159690 
                        #endif
                        let v159691 : string = _v159671 
                        let v159696 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v159696 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v159696 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v159696 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v159696 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v159696 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v159696 = () 
                        #endif
#else
                        let v159697 : (string -> unit) = v157944.Push
                        v159697 v159691
                        let _v159696 = () 
                        #endif
                        _v159696 
                        let v159698 : System.Threading.Tasks.TaskCanceledException = v159670 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v159701 : unit = ()
                        let v159702 : (unit -> unit) = closure25(v159698)
                        let v159703 : unit = (fun () -> v159702 (); v159701) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v160992 : Async<int32> = _v159645 
            let _v158287 = v160992 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v160993 : unit = ()
            let _v160993 =
                async {
                    try
                    let v160996 : System.Threading.Tasks.Task = v157942.WaitForExitAsync v158282 
                    let v160997 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v160998 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v160999 : Async<unit> = v160998 v160996
                    let _v160997 = v160999 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v161000 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v161001 : Async<unit> = v161000 v160996
                    let _v160997 = v161001 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v161002 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v161003 : Async<unit> = v161002 v160996
                    let _v160997 = v161003 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v161004 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v161005 : Async<unit> = v161004 v160996
                    let _v160997 = v161005 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v161006 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v161007 : Async<unit> = v161006 v160996
                    let _v160997 = v161007 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v161008 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v161009 : Async<unit> = v161008 v160996
                    let _v160997 = v161009 
                    #endif
#else
                    let v161010 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v161011 : Async<unit> = v161010 v160996
                    let _v160997 = v161011 
                    #endif
                    let v161012 : Async<unit> = _v160997 
                    do! v161012 
                    let v161017 : int32 = v157942.ExitCode
                    return v161017 
                    with ex ->
                        let v161018 : exn = ex
                        let v161019 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v161020 : string = $"%A{v161018}"
                        let _v161019 = v161020 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v161023 : string = $"%A{v161018}"
                        let _v161019 = v161023 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v161026 : string = $"%A{v161018}"
                        let _v161019 = v161026 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v161029 : string = $"%A{v161018}"
                        let _v161019 = v161029 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v161032 : string = $"%A{v161018}"
                        let _v161019 = v161032 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v161035 : string = $"%A{v161018}"
                        let _v161019 = v161035 
                        #endif
#else
                        let v161038 : string = $"{v161018.GetType ()}: {v161018.Message}"
                        let _v161019 = v161038 
                        #endif
                        let v161039 : string = _v161019 
                        let v161044 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v161044 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v161044 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v161044 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v161044 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v161044 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v161044 = () 
                        #endif
#else
                        let v161045 : (string -> unit) = v157944.Push
                        v161045 v161039
                        let _v161044 = () 
                        #endif
                        _v161044 
                        let v161046 : System.Threading.Tasks.TaskCanceledException = v161018 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v161049 : unit = ()
                        let v161050 : (unit -> unit) = closure25(v161046)
                        let v161051 : unit = (fun () -> v161050 (); v161049) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v162340 : Async<int32> = _v160993 
            let _v158287 = v162340 
            #endif
#else
            let v162341 : unit = ()
            let _v162341 =
                async {
                    try
                    let v162344 : System.Threading.Tasks.Task = v157942.WaitForExitAsync v158282 
                    let v162345 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v162346 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162347 : Async<unit> = v162346 v162344
                    let _v162345 = v162347 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v162348 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162349 : Async<unit> = v162348 v162344
                    let _v162345 = v162349 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v162350 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162351 : Async<unit> = v162350 v162344
                    let _v162345 = v162351 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v162352 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162353 : Async<unit> = v162352 v162344
                    let _v162345 = v162353 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v162354 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162355 : Async<unit> = v162354 v162344
                    let _v162345 = v162355 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v162356 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162357 : Async<unit> = v162356 v162344
                    let _v162345 = v162357 
                    #endif
#else
                    let v162358 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v162359 : Async<unit> = v162358 v162344
                    let _v162345 = v162359 
                    #endif
                    let v162360 : Async<unit> = _v162345 
                    do! v162360 
                    let v162365 : int32 = v157942.ExitCode
                    return v162365 
                    with ex ->
                        let v162366 : exn = ex
                        let v162367 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v162368 : string = $"%A{v162366}"
                        let _v162367 = v162368 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v162371 : string = $"%A{v162366}"
                        let _v162367 = v162371 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v162374 : string = $"%A{v162366}"
                        let _v162367 = v162374 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v162377 : string = $"%A{v162366}"
                        let _v162367 = v162377 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v162380 : string = $"%A{v162366}"
                        let _v162367 = v162380 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v162383 : string = $"%A{v162366}"
                        let _v162367 = v162383 
                        #endif
#else
                        let v162386 : string = $"{v162366.GetType ()}: {v162366.Message}"
                        let _v162367 = v162386 
                        #endif
                        let v162387 : string = _v162367 
                        let v162392 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v162392 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v162392 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v162392 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v162392 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v162392 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v162392 = () 
                        #endif
#else
                        let v162393 : (string -> unit) = v157944.Push
                        v162393 v162387
                        let _v162392 = () 
                        #endif
                        _v162392 
                        let v162394 : System.Threading.Tasks.TaskCanceledException = v162366 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v162397 : unit = ()
                        let v162398 : (unit -> unit) = closure25(v162394)
                        let v162399 : unit = (fun () -> v162398 (); v162397) ()
                        return -2147483648 
                        (*
                        ()
                    *)
                    (*
                    *)
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v163688 : Async<int32> = _v162341 
            let _v158287 = v163688 
            #endif
            let v163689 : Async<int32> = _v158287 
            let! v163689 = v163689 
            let v164367 : int32 = v163689 
            let v164368 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v164369 : string seq = v164368 v157944
            let v164372 : (string seq -> string seq) = Seq.rev
            let v164373 : string seq = v164372 v164369
            let v164376 : string = method45()
            let v164377 : (string -> (string seq -> string)) = String.concat
            let v164378 : (string seq -> string) = v164377 v164376
            let v164379 : string = v164378 v164373
            let v164383 : unit = ()
            let v164384 : (unit -> unit) = closure26(v164367, v164379)
            let v164385 : unit = (fun () -> v164384 (); v164383) ()
            return struct (v164367, v164379) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v210451 : Async<struct (int32 * string)> = _v157848 
    let _v26 = v210451 
    #endif
    let v210452 : Async<struct (int32 * string)> = _v26 
    let _v7 = v210452 
    #endif
    let v236758 : Async<struct (int32 * string)> = _v7 
    v236758
and closure13 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method21(v0, v1, v2, v3, v4, v6, v5)
and closure27 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method21(v0, v1, v2, v3, v4, v5, v6)
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
and method50 (v0 : char, v1 : int64) : bool =
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
            method50(v0, v25)
and method51 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v29 : bool = method50(v27, v28)
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
                while method24(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method25()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method26(v73, v2, v3, v4)
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
        method51(v131, v123, v124, v125, v126)
and method53 (v0 : char, v1 : int64) : bool =
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
            method53(v0, v21)
and closure30 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US8 =
    let v4 : bool = "" = v0
    let v128 : US7 =
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
                while method24(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method25()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method26(v53, v1, v2, v3)
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
                let v115 : (int32 -> (string -> string)) = String.replicate
                let v116 : (string -> string) = v115 v114
                let v117 : string = " "
                let v118 : string = v116 v117
                let v121 : string = "^"
                let v122 : string = v118 + v121 
                let v123 : string = $"{v111}
{v122}
"
                US7_1(v123)
    let v212 : US7 =
        match v128 with
        | US7_1(v209) -> (* Error *)
            US7_1(v209)
        | US7_0(v129, v130, v131, v132, v133) -> (* Ok *)
            let v134 : bool = "" = v130
            if v134 then
                let v135 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v131, v132, v133)}"
                US7_1(v135)
            else
                let v139 : char = v130.[int 0]
                let v140 : (string -> int32) = String.length
                let v141 : int32 = v140 v130
                let v144 : int32 = 1 |> int32 
                let v151 : int32 = v141 |> int32 
                let v158 : int32 = v151 - 1
                let v159 : string = v130.[int v144..int v158]
                let v163 : (char -> string) = _.ToString()
                let v164 : string = v163 v139
                let v167 : int32 = v164.Length
                let v168 : (char []) = Array.zeroCreate<char> (v167)
                let v169 : Mut5 = {l0 = 0} : Mut5
                while method24(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method25()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method26(v182, v131, v132, v133)
                US7_0(v139, v159, v204, v205, v206)
    match v212 with
    | US7_1(v228) -> (* Error *)
        US8_1(v228)
    | US7_0(v213, v214, v215, v216, v217) -> (* Ok *)
        let v218 : (char -> string) = _.ToString()
        let v219 : string = v218 '\\'
        let v222 : (char -> string) = _.ToString()
        let v223 : string = v222 v213
        let v226 : string = v219 + v223 
        US8_0(v226, v214, v215, v216, v217)
and closure31 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US8 =
    let v4 : bool = "" = v0
    let v128 : US7 =
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
                while method24(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method25()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method26(v53, v1, v2, v3)
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
                let v115 : (int32 -> (string -> string)) = String.replicate
                let v116 : (string -> string) = v115 v114
                let v117 : string = " "
                let v118 : string = v116 v117
                let v121 : string = "^"
                let v122 : string = v118 + v121 
                let v123 : string = $"{v111}
{v122}
"
                US7_1(v123)
    let v212 : US7 =
        match v128 with
        | US7_1(v209) -> (* Error *)
            US7_1(v209)
        | US7_0(v129, v130, v131, v132, v133) -> (* Ok *)
            let v134 : bool = "" = v130
            if v134 then
                let v135 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v131, v132, v133)}"
                US7_1(v135)
            else
                let v139 : char = v130.[int 0]
                let v140 : (string -> int32) = String.length
                let v141 : int32 = v140 v130
                let v144 : int32 = 1 |> int32 
                let v151 : int32 = v141 |> int32 
                let v158 : int32 = v151 - 1
                let v159 : string = v130.[int v144..int v158]
                let v163 : (char -> string) = _.ToString()
                let v164 : string = v163 v139
                let v167 : int32 = v164.Length
                let v168 : (char []) = Array.zeroCreate<char> (v167)
                let v169 : Mut5 = {l0 = 0} : Mut5
                while method24(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method25()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method26(v182, v131, v132, v133)
                US7_0(v139, v159, v204, v205, v206)
    match v212 with
    | US7_1(v228) -> (* Error *)
        US8_1(v228)
    | US7_0(v213, v214, v215, v216, v217) -> (* Ok *)
        let v218 : (char -> string) = _.ToString()
        let v219 : string = v218 '`'
        let v222 : (char -> string) = _.ToString()
        let v223 : string = v222 v213
        let v226 : string = v219 + v223 
        US8_0(v226, v214, v215, v216, v217)
and method54 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US8 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US8 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US8_1(v15) -> (* Error *)
            method54(v0, v1, v2, v3, v8)
        | US8_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US8_1(v5)
and method55 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method55(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method52 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
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
            let v26 : bool = method53(v24, v25)
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
                while method24(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method25()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method26(v70, v2, v3, v4)
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
            method54(v1, v2, v3, v4, v140)
        | US8_0(v130, v131, v132, v133, v134) -> (* Ok *)
            v129
    match v143 with
    | US8_1(v151) -> (* Error *)
        let v152 : UH2 = UH2_0
        let v153 : UH2 = method55(v0, v152)
        US17_0(v153, v1, v2, v3, v4)
    | US8_0(v144, v145, v146, v147, v148) -> (* Ok *)
        let v149 : UH2 = UH2_1(v144, v0)
        method52(v149, v145, v146, v147, v148)
and method56 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method56(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method57 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
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
            let v26 : bool = method53(v24, v25)
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
                while method24(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method25()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method26(v70, v2, v3, v4)
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
        let v139 : UH2 = method55(v0, v138)
        US17_0(v139, v1, v2, v3, v4)
    | US8_0(v130, v131, v132, v133, v134) -> (* Ok *)
        let v135 : UH2 = UH2_1(v130, v0)
        method57(v135, v131, v132, v133, v134)
and method49 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
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
            let v29 : bool = method50(v27, v28)
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
                while method24(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method25()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method26(v73, v2, v3, v4)
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
            let struct (v131 : string, v132 : string, v133 : System.Text.StringBuilder, v134 : int32, v135 : int32) = method51(v128, v123, v124, v125, v126)
            US8_0(v131, v132, v133, v134, v135)
    let v521 : US8 =
        match v140 with
        | US8_1(v146) -> (* Error *)
            let v270 : US7 =
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
                        while method24(v180, v182) do
                            let v184 : int32 = v182.l0
                            let v185 : char = v177.[int v184]
                            v181.[int v184] <- v185
                            let v186 : int32 = v184 + 1
                            v182.l0 <- v186
                            ()
                        let v187 : char list = v181 |> Array.toList
                        let v190 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v191 : (char -> (UH0 -> UH0)) = method25()
                        let v192 : (char list -> (UH0 -> UH0)) = v190 v191
                        let v193 : (UH0 -> UH0) = v192 v187
                        let v194 : UH0 = UH0_0
                        let v195 : UH0 = v193 v194
                        let struct (v217 : System.Text.StringBuilder, v218 : int32, v219 : int32) = method26(v195, v2, v3, v4)
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
                        let v257 : (int32 -> (string -> string)) = String.replicate
                        let v258 : (string -> string) = v257 v256
                        let v259 : string = " "
                        let v260 : string = v258 v259
                        let v263 : string = "^"
                        let v264 : string = v260 + v263 
                        let v265 : string = $"{v253}
{v264}
"
                        US7_1(v265)
            let v456 : US8 =
                match v270 with
                | US7_1(v453) -> (* Error *)
                    US8_1(v453)
                | US7_0(v271, v272, v273, v274, v275) -> (* Ok *)
                    let v276 : UH2 = UH2_0
                    let v277 : US17 = method52(v276, v272, v273, v274, v275)
                    let v304 : US8 =
                        match v277 with
                        | US17_1(v301) -> (* Error *)
                            US8_1(v301)
                        | US17_0(v278, v279, v280, v281, v282) -> (* Ok *)
                            let v283 : string list = []
                            let v284 : string list = method56(v278, v283)
                            let v285 : unit = ()
                            let _v285 =
                                seq {
                                    for i = 0 to v284.Length - 1 do yield v284.[i]
                                    (*
                                    ()
                                *)
                                }
                                (*
                                ()
                            *)
                            let v288 : string seq = _v285 
                            let v294 : (string -> (string seq -> string)) = String.concat
                            let v295 : string = ""
                            let v296 : (string seq -> string) = v294 v295
                            let v297 : string = v296 v288
                            US8_0(v297, v279, v280, v281, v282)
                    match v304 with
                    | US8_1(v448) -> (* Error *)
                        let v449 : string = "parsing.between / expected content"
                        US8_1(v449)
                    | US8_0(v305, v306, v307, v308, v309) -> (* Ok *)
                        let v310 : bool = "" = v306
                        let v434 : US7 =
                            if v310 then
                                let v311 : string = $"parsing.p_char / unexpected end of input / c: '{'"'}' / s: %A{struct (v307, v308, v309)}"
                                US7_1(v311)
                            else
                                let v315 : char = v306.[int 0]
                                let v316 : bool = v315 = '"'
                                if v316 then
                                    let v317 : (string -> int32) = String.length
                                    let v318 : int32 = v317 v306
                                    let v321 : int32 = 1 |> int32 
                                    let v328 : int32 = v318 |> int32 
                                    let v335 : int32 = v328 - 1
                                    let v336 : string = v306.[int v321..int v335]
                                    let v340 : (char -> string) = _.ToString()
                                    let v341 : string = v340 v315
                                    let v344 : int32 = v341.Length
                                    let v345 : (char []) = Array.zeroCreate<char> (v344)
                                    let v346 : Mut5 = {l0 = 0} : Mut5
                                    while method24(v344, v346) do
                                        let v348 : int32 = v346.l0
                                        let v349 : char = v341.[int v348]
                                        v345.[int v348] <- v349
                                        let v350 : int32 = v348 + 1
                                        v346.l0 <- v350
                                        ()
                                    let v351 : char list = v345 |> Array.toList
                                    let v354 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v355 : (char -> (UH0 -> UH0)) = method25()
                                    let v356 : (char list -> (UH0 -> UH0)) = v354 v355
                                    let v357 : (UH0 -> UH0) = v356 v351
                                    let v358 : UH0 = UH0_0
                                    let v359 : UH0 = v357 v358
                                    let struct (v381 : System.Text.StringBuilder, v382 : int32, v383 : int32) = method26(v359, v307, v308, v309)
                                    US7_0(v315, v336, v381, v382, v383)
                                else
                                    let v385 : string = "\n"
                                    let v386 : int32 = v306.IndexOf v385 
                                    let v389 : int32 = v386 - 1
                                    let v390 : bool = -2 = v389
                                    let v397 : int32 =
                                        if v390 then
                                            let v391 : (string -> int32) = String.length
                                            let v392 : int32 = v391 v306
                                            let v395 : int32 = v392 + 1
                                            v395
                                        else
                                            let v396 : int32 = v389 + 1
                                            v396
                                    let v398 : int32 = 0 |> int32 
                                    let v405 : int32 = v397 |> int32 
                                    let v412 : int32 = v405 - 1
                                    let v413 : string = v306.[int v398..int v412]
                                    let v417 : string = $"parsing.p_char / expected: '{'"'}' / line: {v308} / col: {v309}
{v307}{v413}"
                                    let v420 : int32 = v309 - 1
                                    let v421 : (int32 -> (string -> string)) = String.replicate
                                    let v422 : (string -> string) = v421 v420
                                    let v423 : string = " "
                                    let v424 : string = v422 v423
                                    let v427 : string = "^"
                                    let v428 : string = v424 + v427 
                                    let v429 : string = $"{v417}
{v428}
"
                                    US7_1(v429)
                        match v434 with
                        | US7_1(v441) -> (* Error *)
                            let v442 : string = $"parsing.between / expected closing delimiter / e: %A{v441} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v272, v273, v274, v275)} / rest2: %A{struct (v306, v307, v308, v309)}"
                            US8_1(v442)
                        | US7_0(v435, v436, v437, v438, v439) -> (* Ok *)
                            US8_0(v305, v436, v437, v438, v439)
            match v456 with
            | US8_1(v462) -> (* Error *)
                let v463 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure30()
                let v464 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure31()
                let v465 : UH3 = UH3_0
                let v466 : UH3 = UH3_1(v464, v465)
                let v467 : UH3 = UH3_1(v463, v466)
                let v468 : US8 = method54(v1, v2, v3, v4, v467)
                let v479 : US8 =
                    match v468 with
                    | US8_1(v476) -> (* Error *)
                        US8_1(v476)
                    | US8_0(v469, v470, v471, v472, v473) -> (* Ok *)
                        let v474 : string = ""
                        US8_0(v474, v470, v471, v472, v473)
                let v490 : US17 =
                    match v479 with
                    | US8_1(v487) -> (* Error *)
                        US17_1(v487)
                    | US8_0(v480, v481, v482, v483, v484) -> (* Ok *)
                        let v485 : UH2 = UH2_0
                        method57(v485, v481, v482, v483, v484)
                match v490 with
                | US17_1(v514) -> (* Error *)
                    US8_1(v514)
                | US17_0(v491, v492, v493, v494, v495) -> (* Ok *)
                    let v496 : string list = []
                    let v497 : string list = method56(v491, v496)
                    let v498 : unit = ()
                    let _v498 =
                        seq {
                            for i = 0 to v497.Length - 1 do yield v497.[i]
                            (*
                            ()
                        *)
                        }
                        (*
                        ()
                    *)
                    let v501 : string seq = _v498 
                    let v507 : (string -> (string seq -> string)) = String.concat
                    let v508 : string = ""
                    let v509 : (string seq -> string) = v507 v508
                    let v510 : string = v509 v501
                    US8_0(v510, v492, v493, v494, v495)
            | US8_0(v457, v458, v459, v460, v461) -> (* Ok *)
                v456
        | US8_0(v141, v142, v143, v144, v145) -> (* Ok *)
            v140
    match v521 with
    | US8_1(v570) -> (* Error *)
        let v571 : UH2 = UH2_0
        let v572 : UH2 = method55(v0, v571)
        US17_0(v572, v1, v2, v3, v4)
    | US8_0(v522, v523, v524, v525, v526) -> (* Ok *)
        let v527 : int32 = 0
        let v528 : int32 = method33(v523, v527)
        let v529 : bool = 0 = v528
        let v556 : US10 =
            if v529 then
                let v530 : string = "parsing.spaces1 / expected at least one space"
                US10_1(v530)
            else
                let v532 : (string -> int32) = String.length
                let v533 : int32 = v532 v523
                let v536 : int32 = v528 |> int32 
                let v543 : int32 = v533 |> int32 
                let v550 : int32 = v543 - 1
                let v551 : string = v523.[int v536..int v550]
                US10_0(v551, v524, v525, v526)
        match v556 with
        | US10_1(v563) -> (* Error *)
            let v564 : UH2 = UH2_0
            let v565 : UH2 = UH2_1(v522, v564)
            let v566 : UH2 = method55(v0, v565)
            US17_0(v566, v523, v524, v525, v526)
        | US10_0(v557, v558, v559, v560) -> (* Ok *)
            let v561 : UH2 = UH2_1(v522, v0)
            method49(v561, v557, v558, v559, v560)
and method48 (v0 : string) : US16 =
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
    let v10 : string = method23()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : UH2 = UH2_0
    let v16 : int32 = 1
    let v17 : int32 = 1
    let v18 : US17 = method49(v15, v7, v12, v16, v17)
    match v18 with
    | US17_1(v31) -> (* Error *)
        US16_1(v31)
    | US17_0(v19, v20, v21, v22, v23) -> (* Ok *)
        let v24 : string list = []
        let v25 : string list = method56(v19, v24)
        let v26 : (string list -> (string [])) = List.toArray
        let v27 : (string []) = v26 v25
        US16_0(v27)
and closure29 () (v0 : string) : Result<(string []), string> =
    let v1 : US16 = method48(v0)
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
