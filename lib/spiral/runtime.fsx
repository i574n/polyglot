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
and method15 () : string =
    let v0 : string = method12()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
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
and method14 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method15()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 3"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method16(v11)
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
    let v1 : bool = method5(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method6(v18, v19, v20, v21, v22, v23)
        let v37 : string = method10()
        let v38 : string = method14(v18, v19, v20, v21, v22, v23, v36, v37)
        method17(v38)
and method18 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method15()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 2"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method16(v11)
and closure11 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method5(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method6(v18, v19, v20, v21, v22, v23)
        let v37 : string = method10()
        let v38 : string = method18(v18, v19, v20, v21, v22, v23, v36, v37)
        method17(v38)
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method15()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 1"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method16(v11)
and closure12 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method5(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method6(v18, v19, v20, v21, v22, v23)
        let v37 : string = method10()
        let v38 : string = method19(v18, v19, v20, v21, v22, v23, v36, v37)
        method17(v38)
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
and method22 () : string =
    let v0 : string = ""
    v0
and method23 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure16 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure15 () (v0 : char) : (UH0 -> UH0) =
    closure16(v0)
and method24 () : (char -> (UH0 -> UH0)) =
    closure15()
and method25 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method25(v5, v24, v9, v10)
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
            while method23(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method24()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method25(v53, v1, v2, v3)
            US7_0(v9, v30, v75, v76, v77)
        else
            let v79 : (string -> int32) = String.length
            let v80 : int32 = v79 v0
            let v83 : string = "\n"
            let v84 : int32 = v0.IndexOf v83 
            let v87 : int32 = v84 - 1
            let v88 : bool = -2 = v87
            let v91 : int32 =
                if v88 then
                    let v89 : int32 = v80 + 1
                    v89
                else
                    let v90 : int32 = v87 + 1
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
            while method23(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method24()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method25(v53, v1, v2, v3)
            US7_0(v9, v30, v75, v76, v77)
        else
            let v79 : (string -> int32) = String.length
            let v80 : int32 = v79 v0
            let v83 : string = "\n"
            let v84 : int32 = v0.IndexOf v83 
            let v87 : int32 = v84 - 1
            let v88 : bool = -2 = v87
            let v91 : int32 =
                if v88 then
                    let v89 : int32 = v80 + 1
                    v89
                else
                    let v90 : int32 = v87 + 1
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
and method26 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US7 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US7 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US7_1(v13) -> (* Error *)
            method26(v0, v1, v6)
        | US7_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "parsing.choice / no parsers succeeded"
        US7_1(v3)
and method27 (v0 : char, v1 : int64) : bool =
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
            method27(v0, v17)
and method28 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v23 : bool = method27(v21, v22)
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
                while method23(v52, v54) do
                    let v56 : int32 = v54.l0
                    let v57 : char = v49.[int v56]
                    v53.[int v56] <- v57
                    let v58 : int32 = v56 + 1
                    v54.l0 <- v58
                    ()
                let v59 : char list = v53 |> Array.toList
                let v62 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v63 : (char -> (UH0 -> UH0)) = method24()
                let v64 : (char list -> (UH0 -> UH0)) = v62 v63
                let v65 : (UH0 -> UH0) = v64 v59
                let v66 : UH0 = UH0_0
                let v67 : UH0 = v65 v66
                let struct (v89 : System.Text.StringBuilder, v90 : int32, v91 : int32) = method25(v67, v2, v3, v4)
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
        method28(v131, v123, v124, v125, v126)
and method29 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US7 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US7 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US7_1(v15) -> (* Error *)
            method29(v0, v1, v2, v3, v8)
        | US7_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US7_1(v5)
and method30 (v0 : char, v1 : int64) : bool =
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
            method30(v0, v21)
and method31 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v26 : bool = method30(v24, v25)
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
                while method23(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method24()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method25(v70, v2, v3, v4)
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
        method31(v137, v129, v130, v131, v132)
and method32 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = ' ' = v4
        if v5 then
            let v6 : int32 = v1 + 1
            method32(v0, v6)
        else
            v1
and method33 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            while method23(v38, v40) do
                let v42 : int32 = v40.l0
                let v43 : char = v35.[int v42]
                v39.[int v42] <- v43
                let v44 : int32 = v42 + 1
                v40.l0 <- v44
                ()
            let v45 : char list = v39 |> Array.toList
            let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v49 : (char -> (UH0 -> UH0)) = method24()
            let v50 : (char list -> (UH0 -> UH0)) = v48 v49
            let v51 : (UH0 -> UH0) = v50 v45
            let v52 : UH0 = UH0_0
            let v53 : UH0 = v51 v52
            let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method25(v53, v2, v3, v4)
            US7_0(v10, v30, v75, v76, v77)
    match v79 with
    | US7_1(v95) -> (* Error *)
        struct (v0, v1, v2, v3, v4)
    | US7_0(v80, v81, v82, v83, v84) -> (* Ok *)
        let v85 : (char -> string) = _.ToString()
        let v86 : string = v85 v80
        let v89 : string = v0 + v86 
        method33(v89, v81, v82, v83, v84)
and method21 (v0 : string) : US6 =
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
    let v10 : string = method22()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure14()
    let v16 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure17()
    let v17 : UH1 = UH1_0
    let v18 : UH1 = UH1_1(v16, v17)
    let v19 : UH1 = UH1_1(v15, v18)
    let v20 : US7 = method26(v7, v12, v19)
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
                    let v44 : bool = method27(v42, v43)
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
                        while method23(v73, v75) do
                            let v77 : int32 = v75.l0
                            let v78 : char = v70.[int v77]
                            v74.[int v77] <- v78
                            let v79 : int32 = v77 + 1
                            v75.l0 <- v79
                            ()
                        let v80 : char list = v74 |> Array.toList
                        let v83 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v84 : (char -> (UH0 -> UH0)) = method24()
                        let v85 : (char list -> (UH0 -> UH0)) = v83 v84
                        let v86 : (UH0 -> UH0) = v85 v80
                        let v87 : UH0 = UH0_0
                        let v88 : UH0 = v86 v87
                        let struct (v110 : System.Text.StringBuilder, v111 : int32, v112 : int32) = method25(v88, v23, v24, v25)
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
                    let struct (v152 : string, v153 : string, v154 : System.Text.StringBuilder, v155 : int32, v156 : int32) = method28(v149, v144, v145, v146, v147)
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
                let v180 : US7 = method29(v173, v174, v175, v176, v179)
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
                    let v230 : bool = method30(v228, v229)
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
                        while method23(v259, v261) do
                            let v263 : int32 = v261.l0
                            let v264 : char = v256.[int v263]
                            v260.[int v263] <- v264
                            let v265 : int32 = v263 + 1
                            v261.l0 <- v265
                            ()
                        let v266 : char list = v260 |> Array.toList
                        let v269 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v270 : (char -> (UH0 -> UH0)) = method24()
                        let v271 : (char list -> (UH0 -> UH0)) = v269 v270
                        let v272 : (UH0 -> UH0) = v271 v266
                        let v273 : UH0 = UH0_0
                        let v274 : UH0 = v272 v273
                        let v296 : int32 = 1
                        let v297 : int32 = 1
                        let struct (v298 : System.Text.StringBuilder, v299 : int32, v300 : int32) = method25(v274, v12, v296, v297)
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
                    let struct (v343 : string, v344 : string, v345 : System.Text.StringBuilder, v346 : int32, v347 : int32) = method31(v340, v335, v336, v337, v338)
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
                    let v382 : int32 = method32(v377, v381)
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
                        while method23(v454, v456) do
                            let v458 : int32 = v456.l0
                            let v459 : char = v451.[int v458]
                            v455.[int v458] <- v459
                            let v460 : int32 = v458 + 1
                            v456.l0 <- v460
                            ()
                        let v461 : char list = v455 |> Array.toList
                        let v464 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v465 : (char -> (UH0 -> UH0)) = method24()
                        let v466 : (char list -> (UH0 -> UH0)) = v464 v465
                        let v467 : (UH0 -> UH0) = v466 v461
                        let v468 : UH0 = UH0_0
                        let v469 : UH0 = v467 v468
                        let struct (v491 : System.Text.StringBuilder, v492 : int32, v493 : int32) = method25(v469, v417, v418, v419)
                        US7_0(v425, v446, v491, v492, v493)
                    else
                        let v495 : (string -> int32) = String.length
                        let v496 : int32 = v495 v416
                        let v499 : string = "\n"
                        let v500 : int32 = v416.IndexOf v499 
                        let v503 : int32 = v500 - 1
                        let v504 : bool = -2 = v503
                        let v507 : int32 =
                            if v504 then
                                let v505 : int32 = v496 + 1
                                v505
                            else
                                let v506 : int32 = v503 + 1
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
                            while method23(v595, v597) do
                                let v599 : int32 = v597.l0
                                let v600 : char = v592.[int v599]
                                v596.[int v599] <- v600
                                let v601 : int32 = v599 + 1
                                v597.l0 <- v601
                                ()
                            let v602 : char list = v596 |> Array.toList
                            let v605 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v606 : (char -> (UH0 -> UH0)) = method24()
                            let v607 : (char list -> (UH0 -> UH0)) = v605 v606
                            let v608 : (UH0 -> UH0) = v607 v602
                            let v609 : UH0 = UH0_0
                            let v610 : UH0 = v608 v609
                            let struct (v632 : System.Text.StringBuilder, v633 : int32, v634 : int32) = method25(v610, v559, v560, v561)
                            US7_0(v567, v587, v632, v633, v634)
                    match v636 with
                    | US7_1(v652) -> (* Error *)
                        US8_1(v652)
                    | US7_0(v637, v638, v639, v640, v641) -> (* Ok *)
                        let v642 : (char -> string) = _.ToString()
                        let v643 : string = v642 v637
                        let struct (v646 : string, v647 : string, v648 : System.Text.StringBuilder, v649 : int32, v650 : int32) = method33(v643, v638, v639, v640, v641)
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
and method34 () : string =
    
    
    
    
    
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
and method36 (v0 : string, v1 : US5, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method12()
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
and method35 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US5, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method36(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options_async"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method16(v20)
and closure18 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US5, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method5(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure0()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method6(v27, v28, v29, v30, v31, v32)
        let v46 : string = method34()
        let v47 : string = method35(v27, v28, v29, v30, v31, v32, v45, v46, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method17(v47)
and method37 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and closure20 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US14 =
    US14_0(v0)
and method38 () : ((struct (int32 * string * bool) -> Async<unit>) -> US14) =
    closure20()
and method39 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method11(v5)
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
    let v105 : string = method13()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method13()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method13()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method13()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method40 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method15()
    let v10 : int64 = v0.l0
    let v11 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method16(v11)
and closure21 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method5(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method39()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method40(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method17(v42)
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
            let v21 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v22 : string = null |> unbox<string>
            let _v21 = v22 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : string = null |> unbox<string>
            let _v21 = v25 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : string = null |> unbox<string>
            let _v21 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : string = null |> unbox<string>
            let _v21 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34 : string = null |> unbox<string>
            let _v21 = v34 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v37 : string = null |> unbox<string>
            let _v21 = v37 
            #endif
#else
            let v40 : string = v9.Data
            let _v21 = v40 
            #endif
            let v41 : string = _v21 
            let v46 : string = null |> unbox<string>
            let v49 : bool = v41 = v46
            let v50 : bool = v49 <> true
            if v50 then
                let v51 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v52 : US14 option = v3 |> Option.map v51 
                let v63 : US14 = US14_1
                let v64 : US14 = v52 |> Option.defaultValue v63 
                match v64 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v68) -> (* Some *)
                    let v69 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v70 : int32 = null |> unbox<int32>
                    let _v69 = v70 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73 : int32 = null |> unbox<int32>
                    let _v69 = v73 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76 : int32 = null |> unbox<int32>
                    let _v69 = v76 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v79 : int32 = null |> unbox<int32>
                    let _v69 = v79 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v82 : int32 = null |> unbox<int32>
                    let _v69 = v82 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v85 : int32 = null |> unbox<int32>
                    let _v69 = v85 
                    #endif
#else
                    let v88 : int32 = v7.Id
                    let _v69 = v88 
                    #endif
                    let v89 : int32 = _v69 
                    let v94 : Async<unit> = v68 struct (v89, v41, false)
                    do! v94 
                    ()
                let v95 : string = $"> {v41}"
                if v5 then
                    let v96 : unit = ()
                    let v97 : (unit -> unit) = closure21(v95)
                    let v98 : unit = (fun () -> v97 (); v96) ()
                    ()
                else
                    let v141 : unit = ()
                    let v142 : (unit -> unit) = closure10(v95)
                    let v143 : unit = (fun () -> v142 (); v141) ()
                    ()
                let v145 : string = ""
                let v146 : string = $"{v145}{v41}{v145}"
                let v147 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v147 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v147 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v147 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v147 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v147 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v147 = () 
                #endif
#else
                let v148 : (string -> unit) = v8.Push
                v148 v146
                let _v147 = () 
                #endif
                _v147 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v149 : Async<unit> = _v20 
    let _v10 = v149 
    #endif
#if FABLE_COMPILER_PYTHON
    let v150 : unit = ()
    let _v150 =
        async {
            let v151 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v152 : string = null |> unbox<string>
            let _v151 = v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v155 : string = null |> unbox<string>
            let _v151 = v155 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v158 : string = null |> unbox<string>
            let _v151 = v158 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v161 : string = null |> unbox<string>
            let _v151 = v161 
            #endif
#if FABLE_COMPILER_PYTHON
            let v164 : string = null |> unbox<string>
            let _v151 = v164 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v167 : string = null |> unbox<string>
            let _v151 = v167 
            #endif
#else
            let v170 : string = v9.Data
            let _v151 = v170 
            #endif
            let v171 : string = _v151 
            let v176 : string = null |> unbox<string>
            let v179 : bool = v171 = v176
            let v180 : bool = v179 <> true
            if v180 then
                let v181 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v182 : US14 option = v3 |> Option.map v181 
                let v193 : US14 = US14_1
                let v194 : US14 = v182 |> Option.defaultValue v193 
                match v194 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v198) -> (* Some *)
                    let v199 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v200 : int32 = null |> unbox<int32>
                    let _v199 = v200 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v203 : int32 = null |> unbox<int32>
                    let _v199 = v203 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v206 : int32 = null |> unbox<int32>
                    let _v199 = v206 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v209 : int32 = null |> unbox<int32>
                    let _v199 = v209 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v212 : int32 = null |> unbox<int32>
                    let _v199 = v212 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v215 : int32 = null |> unbox<int32>
                    let _v199 = v215 
                    #endif
#else
                    let v218 : int32 = v7.Id
                    let _v199 = v218 
                    #endif
                    let v219 : int32 = _v199 
                    let v224 : Async<unit> = v198 struct (v219, v171, false)
                    do! v224 
                    ()
                let v225 : string = $"> {v171}"
                if v5 then
                    let v226 : unit = ()
                    let v227 : (unit -> unit) = closure21(v225)
                    let v228 : unit = (fun () -> v227 (); v226) ()
                    ()
                else
                    let v271 : unit = ()
                    let v272 : (unit -> unit) = closure10(v225)
                    let v273 : unit = (fun () -> v272 (); v271) ()
                    ()
                let v275 : string = ""
                let v276 : string = $"{v275}{v171}{v275}"
                let v277 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v277 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v277 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v277 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v277 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v277 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v277 = () 
                #endif
#else
                let v278 : (string -> unit) = v8.Push
                v278 v276
                let _v277 = () 
                #endif
                _v277 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v279 : Async<unit> = _v150 
    let _v10 = v279 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v280 : unit = ()
    let _v280 =
        async {
            let v281 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v282 : string = null |> unbox<string>
            let _v281 = v282 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v285 : string = null |> unbox<string>
            let _v281 = v285 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v288 : string = null |> unbox<string>
            let _v281 = v288 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v291 : string = null |> unbox<string>
            let _v281 = v291 
            #endif
#if FABLE_COMPILER_PYTHON
            let v294 : string = null |> unbox<string>
            let _v281 = v294 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v297 : string = null |> unbox<string>
            let _v281 = v297 
            #endif
#else
            let v300 : string = v9.Data
            let _v281 = v300 
            #endif
            let v301 : string = _v281 
            let v306 : string = null |> unbox<string>
            let v309 : bool = v301 = v306
            let v310 : bool = v309 <> true
            if v310 then
                let v311 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v312 : US14 option = v3 |> Option.map v311 
                let v323 : US14 = US14_1
                let v324 : US14 = v312 |> Option.defaultValue v323 
                match v324 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v328) -> (* Some *)
                    let v329 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v330 : int32 = null |> unbox<int32>
                    let _v329 = v330 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v333 : int32 = null |> unbox<int32>
                    let _v329 = v333 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v336 : int32 = null |> unbox<int32>
                    let _v329 = v336 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v339 : int32 = null |> unbox<int32>
                    let _v329 = v339 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v342 : int32 = null |> unbox<int32>
                    let _v329 = v342 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v345 : int32 = null |> unbox<int32>
                    let _v329 = v345 
                    #endif
#else
                    let v348 : int32 = v7.Id
                    let _v329 = v348 
                    #endif
                    let v349 : int32 = _v329 
                    let v354 : Async<unit> = v328 struct (v349, v301, false)
                    do! v354 
                    ()
                let v355 : string = $"> {v301}"
                if v5 then
                    let v356 : unit = ()
                    let v357 : (unit -> unit) = closure21(v355)
                    let v358 : unit = (fun () -> v357 (); v356) ()
                    ()
                else
                    let v401 : unit = ()
                    let v402 : (unit -> unit) = closure10(v355)
                    let v403 : unit = (fun () -> v402 (); v401) ()
                    ()
                let v405 : string = ""
                let v406 : string = $"{v405}{v301}{v405}"
                let v407 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v407 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v407 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v407 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v407 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v407 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v407 = () 
                #endif
#else
                let v408 : (string -> unit) = v8.Push
                v408 v406
                let _v407 = () 
                #endif
                _v407 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v409 : Async<unit> = _v280 
    let _v10 = v409 
    #endif
#else
    let v410 : unit = ()
    let _v410 =
        async {
            let v411 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v412 : string = null |> unbox<string>
            let _v411 = v412 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v415 : string = null |> unbox<string>
            let _v411 = v415 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v418 : string = null |> unbox<string>
            let _v411 = v418 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v421 : string = null |> unbox<string>
            let _v411 = v421 
            #endif
#if FABLE_COMPILER_PYTHON
            let v424 : string = null |> unbox<string>
            let _v411 = v424 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v427 : string = null |> unbox<string>
            let _v411 = v427 
            #endif
#else
            let v430 : string = v9.Data
            let _v411 = v430 
            #endif
            let v431 : string = _v411 
            let v436 : string = null |> unbox<string>
            let v439 : bool = v431 = v436
            let v440 : bool = v439 <> true
            if v440 then
                let v441 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v442 : US14 option = v3 |> Option.map v441 
                let v453 : US14 = US14_1
                let v454 : US14 = v442 |> Option.defaultValue v453 
                match v454 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v458) -> (* Some *)
                    let v459 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v460 : int32 = null |> unbox<int32>
                    let _v459 = v460 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v463 : int32 = null |> unbox<int32>
                    let _v459 = v463 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v466 : int32 = null |> unbox<int32>
                    let _v459 = v466 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v469 : int32 = null |> unbox<int32>
                    let _v459 = v469 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v472 : int32 = null |> unbox<int32>
                    let _v459 = v472 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v475 : int32 = null |> unbox<int32>
                    let _v459 = v475 
                    #endif
#else
                    let v478 : int32 = v7.Id
                    let _v459 = v478 
                    #endif
                    let v479 : int32 = _v459 
                    let v484 : Async<unit> = v458 struct (v479, v431, false)
                    do! v484 
                    ()
                let v485 : string = $"> {v431}"
                if v5 then
                    let v486 : unit = ()
                    let v487 : (unit -> unit) = closure21(v485)
                    let v488 : unit = (fun () -> v487 (); v486) ()
                    ()
                else
                    let v531 : unit = ()
                    let v532 : (unit -> unit) = closure10(v485)
                    let v533 : unit = (fun () -> v532 (); v531) ()
                    ()
                let v535 : string = ""
                let v536 : string = $"{v535}{v431}{v535}"
                let v537 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v537 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v537 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v537 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v537 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v537 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v537 = () 
                #endif
#else
                let v538 : (string -> unit) = v8.Push
                v538 v536
                let _v537 = () 
                #endif
                _v537 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v539 : Async<unit> = _v410 
    let _v10 = v539 
    #endif
    let v540 : Async<unit> = _v10 
    let v545 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v545 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v545 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v545 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v546 : (Async<unit> -> unit) = Async.StartImmediate
    v546 v540
    let _v545 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v547 : (Async<unit> -> unit) = Async.StartImmediate
    v547 v540
    let _v545 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v548 : (Async<unit> -> unit) = Async.StartImmediate
    v548 v540
    let _v545 = () 
    #endif
#else
    let v549 : (Async<unit> -> unit) = Async.StartImmediate
    v549 v540
    let _v545 = () 
    #endif
    _v545 
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
            let v21 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v22 : string = null |> unbox<string>
            let _v21 = v22 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v25 : string = null |> unbox<string>
            let _v21 = v25 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v28 : string = null |> unbox<string>
            let _v21 = v28 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v31 : string = null |> unbox<string>
            let _v21 = v31 
            #endif
#if FABLE_COMPILER_PYTHON
            let v34 : string = null |> unbox<string>
            let _v21 = v34 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v37 : string = null |> unbox<string>
            let _v21 = v37 
            #endif
#else
            let v40 : string = v9.Data
            let _v21 = v40 
            #endif
            let v41 : string = _v21 
            let v46 : string = null |> unbox<string>
            let v49 : bool = v41 = v46
            let v50 : bool = v49 <> true
            if v50 then
                let v51 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v52 : US14 option = v3 |> Option.map v51 
                let v63 : US14 = US14_1
                let v64 : US14 = v52 |> Option.defaultValue v63 
                match v64 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v68) -> (* Some *)
                    let v69 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v70 : int32 = null |> unbox<int32>
                    let _v69 = v70 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v73 : int32 = null |> unbox<int32>
                    let _v69 = v73 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v76 : int32 = null |> unbox<int32>
                    let _v69 = v76 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v79 : int32 = null |> unbox<int32>
                    let _v69 = v79 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v82 : int32 = null |> unbox<int32>
                    let _v69 = v82 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v85 : int32 = null |> unbox<int32>
                    let _v69 = v85 
                    #endif
#else
                    let v88 : int32 = v7.Id
                    let _v69 = v88 
                    #endif
                    let v89 : int32 = _v69 
                    let v94 : Async<unit> = v68 struct (v89, v41, true)
                    do! v94 
                    ()
                let v95 : string = $"! {v41}"
                if v5 then
                    let v96 : unit = ()
                    let v97 : (unit -> unit) = closure21(v95)
                    let v98 : unit = (fun () -> v97 (); v96) ()
                    ()
                else
                    let v141 : unit = ()
                    let v142 : (unit -> unit) = closure10(v95)
                    let v143 : unit = (fun () -> v142 (); v141) ()
                    ()
                let v145 : string = "\u001b[7;4m"
                let v146 : string = "\u001b[0m"
                let v147 : string = $"{v145}{v41}{v146}"
                let v148 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v148 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v148 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v148 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v148 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v148 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v148 = () 
                #endif
#else
                let v149 : (string -> unit) = v8.Push
                v149 v147
                let _v148 = () 
                #endif
                _v148 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v150 : Async<unit> = _v20 
    let _v10 = v150 
    #endif
#if FABLE_COMPILER_PYTHON
    let v151 : unit = ()
    let _v151 =
        async {
            let v152 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v153 : string = null |> unbox<string>
            let _v152 = v153 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v156 : string = null |> unbox<string>
            let _v152 = v156 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v159 : string = null |> unbox<string>
            let _v152 = v159 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v162 : string = null |> unbox<string>
            let _v152 = v162 
            #endif
#if FABLE_COMPILER_PYTHON
            let v165 : string = null |> unbox<string>
            let _v152 = v165 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v168 : string = null |> unbox<string>
            let _v152 = v168 
            #endif
#else
            let v171 : string = v9.Data
            let _v152 = v171 
            #endif
            let v172 : string = _v152 
            let v177 : string = null |> unbox<string>
            let v180 : bool = v172 = v177
            let v181 : bool = v180 <> true
            if v181 then
                let v182 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v183 : US14 option = v3 |> Option.map v182 
                let v194 : US14 = US14_1
                let v195 : US14 = v183 |> Option.defaultValue v194 
                match v195 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v199) -> (* Some *)
                    let v200 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v201 : int32 = null |> unbox<int32>
                    let _v200 = v201 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v204 : int32 = null |> unbox<int32>
                    let _v200 = v204 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v207 : int32 = null |> unbox<int32>
                    let _v200 = v207 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v210 : int32 = null |> unbox<int32>
                    let _v200 = v210 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v213 : int32 = null |> unbox<int32>
                    let _v200 = v213 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v216 : int32 = null |> unbox<int32>
                    let _v200 = v216 
                    #endif
#else
                    let v219 : int32 = v7.Id
                    let _v200 = v219 
                    #endif
                    let v220 : int32 = _v200 
                    let v225 : Async<unit> = v199 struct (v220, v172, true)
                    do! v225 
                    ()
                let v226 : string = $"! {v172}"
                if v5 then
                    let v227 : unit = ()
                    let v228 : (unit -> unit) = closure21(v226)
                    let v229 : unit = (fun () -> v228 (); v227) ()
                    ()
                else
                    let v272 : unit = ()
                    let v273 : (unit -> unit) = closure10(v226)
                    let v274 : unit = (fun () -> v273 (); v272) ()
                    ()
                let v276 : string = "\u001b[7;4m"
                let v277 : string = "\u001b[0m"
                let v278 : string = $"{v276}{v172}{v277}"
                let v279 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v279 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v279 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v279 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v279 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v279 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v279 = () 
                #endif
#else
                let v280 : (string -> unit) = v8.Push
                v280 v278
                let _v279 = () 
                #endif
                _v279 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v281 : Async<unit> = _v151 
    let _v10 = v281 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v282 : unit = ()
    let _v282 =
        async {
            let v283 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v284 : string = null |> unbox<string>
            let _v283 = v284 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v287 : string = null |> unbox<string>
            let _v283 = v287 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v290 : string = null |> unbox<string>
            let _v283 = v290 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v293 : string = null |> unbox<string>
            let _v283 = v293 
            #endif
#if FABLE_COMPILER_PYTHON
            let v296 : string = null |> unbox<string>
            let _v283 = v296 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v299 : string = null |> unbox<string>
            let _v283 = v299 
            #endif
#else
            let v302 : string = v9.Data
            let _v283 = v302 
            #endif
            let v303 : string = _v283 
            let v308 : string = null |> unbox<string>
            let v311 : bool = v303 = v308
            let v312 : bool = v311 <> true
            if v312 then
                let v313 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v314 : US14 option = v3 |> Option.map v313 
                let v325 : US14 = US14_1
                let v326 : US14 = v314 |> Option.defaultValue v325 
                match v326 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v330) -> (* Some *)
                    let v331 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v332 : int32 = null |> unbox<int32>
                    let _v331 = v332 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v335 : int32 = null |> unbox<int32>
                    let _v331 = v335 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v338 : int32 = null |> unbox<int32>
                    let _v331 = v338 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v341 : int32 = null |> unbox<int32>
                    let _v331 = v341 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v344 : int32 = null |> unbox<int32>
                    let _v331 = v344 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v347 : int32 = null |> unbox<int32>
                    let _v331 = v347 
                    #endif
#else
                    let v350 : int32 = v7.Id
                    let _v331 = v350 
                    #endif
                    let v351 : int32 = _v331 
                    let v356 : Async<unit> = v330 struct (v351, v303, true)
                    do! v356 
                    ()
                let v357 : string = $"! {v303}"
                if v5 then
                    let v358 : unit = ()
                    let v359 : (unit -> unit) = closure21(v357)
                    let v360 : unit = (fun () -> v359 (); v358) ()
                    ()
                else
                    let v403 : unit = ()
                    let v404 : (unit -> unit) = closure10(v357)
                    let v405 : unit = (fun () -> v404 (); v403) ()
                    ()
                let v407 : string = "\u001b[7;4m"
                let v408 : string = "\u001b[0m"
                let v409 : string = $"{v407}{v303}{v408}"
                let v410 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v410 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v410 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v410 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v410 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v410 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v410 = () 
                #endif
#else
                let v411 : (string -> unit) = v8.Push
                v411 v409
                let _v410 = () 
                #endif
                _v410 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v412 : Async<unit> = _v282 
    let _v10 = v412 
    #endif
#else
    let v413 : unit = ()
    let _v413 =
        async {
            let v414 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v415 : string = null |> unbox<string>
            let _v414 = v415 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v418 : string = null |> unbox<string>
            let _v414 = v418 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v421 : string = null |> unbox<string>
            let _v414 = v421 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v424 : string = null |> unbox<string>
            let _v414 = v424 
            #endif
#if FABLE_COMPILER_PYTHON
            let v427 : string = null |> unbox<string>
            let _v414 = v427 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v430 : string = null |> unbox<string>
            let _v414 = v430 
            #endif
#else
            let v433 : string = v9.Data
            let _v414 = v433 
            #endif
            let v434 : string = _v414 
            let v439 : string = null |> unbox<string>
            let v442 : bool = v434 = v439
            let v443 : bool = v442 <> true
            if v443 then
                let v444 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method38()
                let v445 : US14 option = v3 |> Option.map v444 
                let v456 : US14 = US14_1
                let v457 : US14 = v445 |> Option.defaultValue v456 
                match v457 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v461) -> (* Some *)
                    let v462 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v463 : int32 = null |> unbox<int32>
                    let _v462 = v463 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v466 : int32 = null |> unbox<int32>
                    let _v462 = v466 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v469 : int32 = null |> unbox<int32>
                    let _v462 = v469 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v472 : int32 = null |> unbox<int32>
                    let _v462 = v472 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v475 : int32 = null |> unbox<int32>
                    let _v462 = v475 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v478 : int32 = null |> unbox<int32>
                    let _v462 = v478 
                    #endif
#else
                    let v481 : int32 = v7.Id
                    let _v462 = v481 
                    #endif
                    let v482 : int32 = _v462 
                    let v487 : Async<unit> = v461 struct (v482, v434, true)
                    do! v487 
                    ()
                let v488 : string = $"! {v434}"
                if v5 then
                    let v489 : unit = ()
                    let v490 : (unit -> unit) = closure21(v488)
                    let v491 : unit = (fun () -> v490 (); v489) ()
                    ()
                else
                    let v534 : unit = ()
                    let v535 : (unit -> unit) = closure10(v488)
                    let v536 : unit = (fun () -> v535 (); v534) ()
                    ()
                let v538 : string = "\u001b[7;4m"
                let v539 : string = "\u001b[0m"
                let v540 : string = $"{v538}{v434}{v539}"
                let v541 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let _v541 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let _v541 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let _v541 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _v541 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                let _v541 = () 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _v541 = () 
                #endif
#else
                let v542 : (string -> unit) = v8.Push
                v542 v540
                let _v541 = () 
                #endif
                _v541 
                ()
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v543 : Async<unit> = _v413 
    let _v10 = v543 
    #endif
    let v544 : Async<unit> = _v10 
    let v549 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v549 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v549 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v549 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v550 : (Async<unit> -> unit) = Async.StartImmediate
    v550 v544
    let _v549 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    let v551 : (Async<unit> -> unit) = Async.StartImmediate
    v551 v544
    let _v549 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v552 : (Async<unit> -> unit) = Async.StartImmediate
    v552 v544
    let _v549 = () 
    #endif
#else
    let v553 : (Async<unit> -> unit) = Async.StartImmediate
    v553 v544
    let _v549 = () 
    #endif
    _v549 
    ()
and closure23 () (v0 : System.Threading.CancellationToken) : US15 =
    US15_0(v0)
and method41 () : (System.Threading.CancellationToken -> US15) =
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
and method43 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method12()
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
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method43(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method16(v12)
and closure25 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method5(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method6(v19, v20, v21, v22, v23, v24)
        let v38 : string = method10()
        let v39 : string = method42(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method17(v39)
and method44 () : string =
    let v0 : string = "\n"
    v0
and method46 (v0 : int32, v1 : int32) : string =
    let v2 : string = method12()
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
and method45 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method46(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method16(v13)
and closure26 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method5(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method6(v20, v21, v22, v23, v24, v25)
        let v39 : string = method34()
        let v40 : int32 = v1.Length
        let v41 : string = method45(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method17(v41)
and method20 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
            let v37 : US6 = method21(v0)
            let struct (v48 : string, v49 : US5) =
                match v37 with
                | US6_1(v40) -> (* Error *)
                    let v41 : string = $"resultm.get / Result value was Error: {v40}"
                    failwith<struct (string * US5)> v41
                | US6_0(v38, v39) -> (* Ok *)
                    struct (v38, v39)
            let v50 : (string -> US5) = method4()
            let v51 : US5 option = v6 |> Option.map v50 
            let v62 : US5 = US5_1
            let v63 : US5 = v51 |> Option.defaultValue v62 
            let v70 : string =
                match v63 with
                | US5_1 -> (* None *)
                    let v68 : string = ""
                    v68
                | US5_0(v67) -> (* Some *)
                    v67
            let v71 : unit = ()
            let v72 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v49, v48)
            let v73 : unit = (fun () -> v72 (); v71) ()
            let v113 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v117 : string =
                match v49 with
                | US5_1 -> (* None *)
                    let v115 : string = ""
                    v115
                | US5_0(v114) -> (* Some *)
                    v114
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v117,
              StandardOutputEncoding = v113,
              WorkingDirectory = v70,
              FileName = v48,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v118 : System.Diagnostics.ProcessStartInfo = start_info
            let v119 : (struct (string * string) []) = method37(v0, v1, v2, v3, v4, v5, v6)
            let v120 : int32 = v119.Length
            let v121 : Mut5 = {l0 = 0} : Mut5
            while method23(v120, v121) do
                let v123 : int32 = v121.l0
                let struct (v124 : string, v125 : string) = v119.[int v123]
                v118.EnvironmentVariables.[v124] <- v125 
                let v126 : int32 = v123 + 1
                v121.l0 <- v126
                ()
            let v127 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v118)
            use v127 = v127 
            let v128 : System.Diagnostics.Process = v127 
            let v129 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v130 : System.Collections.Concurrent.ConcurrentStack<string> = v129 ()
            let v131 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v128, v130)
            v128.OutputDataReceived.Add v131 
            let v132 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v128, v130)
            v128.ErrorDataReceived.Add v132 
            let v133 : (unit -> bool) = v128.Start
            let v134 : bool = v133 ()
            let v135 : bool = v134 = false
            if v135 then
                let v136 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v136
            let v137 : (unit -> unit) = v128.BeginErrorReadLine
            v137 ()
            let v138 : (unit -> unit) = v128.BeginOutputReadLine
            v138 ()
            let v139 : (System.Threading.CancellationToken -> US15) = method41()
            let v140 : US15 option = v1 |> Option.map v139 
            let v151 : US15 = US15_1
            let v152 : US15 = v140 |> Option.defaultValue v151 
            let v159 : System.Threading.CancellationToken =
                match v152 with
                | US15_1 -> (* None *)
                    let v157 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v157
                | US15_0(v156) -> (* Some *)
                    v156
            let v160 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v161 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v161 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v164 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v164 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v167 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v167 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v170 
            #endif
#if FABLE_COMPILER_PYTHON
            let v173 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v173 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v176 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v160 = v176 
            #endif
#else
            let v179 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v180 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v179 = v180 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v183 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v179 = v183 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v186 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v179 = v186 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v189 : unit = ()
            let _v189 =
                async {
                    let v190 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v190 = v190 
                    let v191 : System.Threading.CancellationToken = v190 
                    let v192 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v193 : (System.Threading.CancellationToken []) = [|v191; v192; v159|]
                    let v194 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v195 : System.Threading.CancellationTokenSource = v194 v193
                    let v196 : System.Threading.CancellationToken = v195.Token
                    return v196 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v197 : Async<System.Threading.CancellationToken> = _v189 
            let _v179 = v197 
            #endif
#if FABLE_COMPILER_PYTHON
            let v198 : unit = ()
            let _v198 =
                async {
                    let v199 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v199 = v199 
                    let v200 : System.Threading.CancellationToken = v199 
                    let v201 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v202 : (System.Threading.CancellationToken []) = [|v200; v201; v159|]
                    let v203 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v204 : System.Threading.CancellationTokenSource = v203 v202
                    let v205 : System.Threading.CancellationToken = v204.Token
                    return v205 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v206 : Async<System.Threading.CancellationToken> = _v198 
            let _v179 = v206 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v207 : unit = ()
            let _v207 =
                async {
                    let v208 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v208 = v208 
                    let v209 : System.Threading.CancellationToken = v208 
                    let v210 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v211 : (System.Threading.CancellationToken []) = [|v209; v210; v159|]
                    let v212 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v213 : System.Threading.CancellationTokenSource = v212 v211
                    let v214 : System.Threading.CancellationToken = v213.Token
                    return v214 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v215 : Async<System.Threading.CancellationToken> = _v207 
            let _v179 = v215 
            #endif
#else
            let v216 : unit = ()
            let _v216 =
                async {
                    let v217 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v217 = v217 
                    let v218 : System.Threading.CancellationToken = v217 
                    let v219 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v220 : (System.Threading.CancellationToken []) = [|v218; v219; v159|]
                    let v221 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v222 : System.Threading.CancellationTokenSource = v221 v220
                    let v223 : System.Threading.CancellationToken = v222.Token
                    return v223 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v224 : Async<System.Threading.CancellationToken> = _v216 
            let _v179 = v224 
            #endif
            let v225 : Async<System.Threading.CancellationToken> = _v179 
            let _v160 = v225 
            #endif
            let v230 : Async<System.Threading.CancellationToken> = _v160 
            let! v230 = v230 
            let v235 : System.Threading.CancellationToken = v230 
            let v236 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v235.Register
            let v237 : (unit -> unit) = closure24(v128)
            let v238 : System.Threading.CancellationTokenRegistration = v236 v237
            use v238 = v238 
            let v239 : System.Threading.CancellationTokenRegistration = v238 
            let v240 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v241 : Async<int32> = null |> unbox<Async<int32>>
            let _v240 = v241 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v244 : Async<int32> = null |> unbox<Async<int32>>
            let _v240 = v244 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v247 : Async<int32> = null |> unbox<Async<int32>>
            let _v240 = v247 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v250 : unit = ()
            let _v250 =
                async {
                    try
                    let v251 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v252 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v253 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v254 : Async<unit> = v253 v251
                    let _v252 = v254 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v255 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v256 : Async<unit> = v255 v251
                    let _v252 = v256 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v258 : Async<unit> = v257 v251
                    let _v252 = v258 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v259 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v260 : Async<unit> = v259 v251
                    let _v252 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v261 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v262 : Async<unit> = v261 v251
                    let _v252 = v262 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v263 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v264 : Async<unit> = v263 v251
                    let _v252 = v264 
                    #endif
#else
                    let v265 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v266 : Async<unit> = v265 v251
                    let _v252 = v266 
                    #endif
                    let v267 : Async<unit> = _v252 
                    do! v267 
                    let v272 : int32 = v128.ExitCode
                    return v272 
                    with ex ->
                        let v273 : exn = ex
                        let v274 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v275 : string = $"%A{v273}"
                        let _v274 = v275 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v278 : string = $"%A{v273}"
                        let _v274 = v278 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v281 : string = $"%A{v273}"
                        let _v274 = v281 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v284 : string = $"%A{v273}"
                        let _v274 = v284 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v287 : string = $"%A{v273}"
                        let _v274 = v287 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v290 : string = $"%A{v273}"
                        let _v274 = v290 
                        #endif
#else
                        let v293 : string = $"{v273.GetType ()}: {v273.Message}"
                        let _v274 = v293 
                        #endif
                        let v294 : string = _v274 
                        let v299 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v299 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v299 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v299 = () 
                        #endif
#else
                        let v300 : (string -> unit) = v130.Push
                        v300 v294
                        let _v299 = () 
                        #endif
                        _v299 
                        let v301 : System.Threading.Tasks.TaskCanceledException = v273 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v304 : unit = ()
                        let v305 : (unit -> unit) = closure25(v301)
                        let v306 : unit = (fun () -> v305 (); v304) ()
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
            let v346 : Async<int32> = _v250 
            let _v240 = v346 
            #endif
#if FABLE_COMPILER_PYTHON
            let v347 : unit = ()
            let _v347 =
                async {
                    try
                    let v348 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v349 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v350 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v351 : Async<unit> = v350 v348
                    let _v349 = v351 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v352 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v353 : Async<unit> = v352 v348
                    let _v349 = v353 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v354 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v355 : Async<unit> = v354 v348
                    let _v349 = v355 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v356 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v357 : Async<unit> = v356 v348
                    let _v349 = v357 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v358 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v359 : Async<unit> = v358 v348
                    let _v349 = v359 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v360 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v361 : Async<unit> = v360 v348
                    let _v349 = v361 
                    #endif
#else
                    let v362 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v363 : Async<unit> = v362 v348
                    let _v349 = v363 
                    #endif
                    let v364 : Async<unit> = _v349 
                    do! v364 
                    let v369 : int32 = v128.ExitCode
                    return v369 
                    with ex ->
                        let v370 : exn = ex
                        let v371 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v372 : string = $"%A{v370}"
                        let _v371 = v372 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v375 : string = $"%A{v370}"
                        let _v371 = v375 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v378 : string = $"%A{v370}"
                        let _v371 = v378 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v381 : string = $"%A{v370}"
                        let _v371 = v381 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v384 : string = $"%A{v370}"
                        let _v371 = v384 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v387 : string = $"%A{v370}"
                        let _v371 = v387 
                        #endif
#else
                        let v390 : string = $"{v370.GetType ()}: {v370.Message}"
                        let _v371 = v390 
                        #endif
                        let v391 : string = _v371 
                        let v396 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v396 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v396 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v396 = () 
                        #endif
#else
                        let v397 : (string -> unit) = v130.Push
                        v397 v391
                        let _v396 = () 
                        #endif
                        _v396 
                        let v398 : System.Threading.Tasks.TaskCanceledException = v370 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v401 : unit = ()
                        let v402 : (unit -> unit) = closure25(v398)
                        let v403 : unit = (fun () -> v402 (); v401) ()
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
            let v443 : Async<int32> = _v347 
            let _v240 = v443 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v444 : unit = ()
            let _v444 =
                async {
                    try
                    let v445 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v446 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v447 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v448 : Async<unit> = v447 v445
                    let _v446 = v448 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v449 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v450 : Async<unit> = v449 v445
                    let _v446 = v450 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v451 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v452 : Async<unit> = v451 v445
                    let _v446 = v452 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v453 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v454 : Async<unit> = v453 v445
                    let _v446 = v454 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v455 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v456 : Async<unit> = v455 v445
                    let _v446 = v456 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v457 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v458 : Async<unit> = v457 v445
                    let _v446 = v458 
                    #endif
#else
                    let v459 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v460 : Async<unit> = v459 v445
                    let _v446 = v460 
                    #endif
                    let v461 : Async<unit> = _v446 
                    do! v461 
                    let v466 : int32 = v128.ExitCode
                    return v466 
                    with ex ->
                        let v467 : exn = ex
                        let v468 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v469 : string = $"%A{v467}"
                        let _v468 = v469 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v472 : string = $"%A{v467}"
                        let _v468 = v472 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v475 : string = $"%A{v467}"
                        let _v468 = v475 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v478 : string = $"%A{v467}"
                        let _v468 = v478 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v481 : string = $"%A{v467}"
                        let _v468 = v481 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v484 : string = $"%A{v467}"
                        let _v468 = v484 
                        #endif
#else
                        let v487 : string = $"{v467.GetType ()}: {v467.Message}"
                        let _v468 = v487 
                        #endif
                        let v488 : string = _v468 
                        let v493 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v493 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v493 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v493 = () 
                        #endif
#else
                        let v494 : (string -> unit) = v130.Push
                        v494 v488
                        let _v493 = () 
                        #endif
                        _v493 
                        let v495 : System.Threading.Tasks.TaskCanceledException = v467 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v498 : unit = ()
                        let v499 : (unit -> unit) = closure25(v495)
                        let v500 : unit = (fun () -> v499 (); v498) ()
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
            let v540 : Async<int32> = _v444 
            let _v240 = v540 
            #endif
#else
            let v541 : unit = ()
            let _v541 =
                async {
                    try
                    let v542 : System.Threading.Tasks.Task = v128.WaitForExitAsync v235 
                    let v543 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v544 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v545 : Async<unit> = v544 v542
                    let _v543 = v545 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v546 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v547 : Async<unit> = v546 v542
                    let _v543 = v547 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v548 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v549 : Async<unit> = v548 v542
                    let _v543 = v549 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v550 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v551 : Async<unit> = v550 v542
                    let _v543 = v551 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v552 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v553 : Async<unit> = v552 v542
                    let _v543 = v553 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v554 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v555 : Async<unit> = v554 v542
                    let _v543 = v555 
                    #endif
#else
                    let v556 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v557 : Async<unit> = v556 v542
                    let _v543 = v557 
                    #endif
                    let v558 : Async<unit> = _v543 
                    do! v558 
                    let v563 : int32 = v128.ExitCode
                    return v563 
                    with ex ->
                        let v564 : exn = ex
                        let v565 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v566 : string = $"%A{v564}"
                        let _v565 = v566 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v569 : string = $"%A{v564}"
                        let _v565 = v569 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v572 : string = $"%A{v564}"
                        let _v565 = v572 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v575 : string = $"%A{v564}"
                        let _v565 = v575 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v578 : string = $"%A{v564}"
                        let _v565 = v578 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v581 : string = $"%A{v564}"
                        let _v565 = v581 
                        #endif
#else
                        let v584 : string = $"{v564.GetType ()}: {v564.Message}"
                        let _v565 = v584 
                        #endif
                        let v585 : string = _v565 
                        let v590 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v590 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v590 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v590 = () 
                        #endif
#else
                        let v591 : (string -> unit) = v130.Push
                        v591 v585
                        let _v590 = () 
                        #endif
                        _v590 
                        let v592 : System.Threading.Tasks.TaskCanceledException = v564 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v595 : unit = ()
                        let v596 : (unit -> unit) = closure25(v592)
                        let v597 : unit = (fun () -> v596 (); v595) ()
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
            let v637 : Async<int32> = _v541 
            let _v240 = v637 
            #endif
            let v638 : Async<int32> = _v240 
            let! v638 = v638 
            let v643 : int32 = v638 
            let v644 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v645 : string seq = v644 v130
            let v648 : (string seq -> string seq) = Seq.rev
            let v649 : string seq = v648 v645
            let v652 : string = method44()
            let v653 : (string -> (string seq -> string)) = String.concat
            let v654 : (string seq -> string) = v653 v652
            let v655 : string = v654 v649
            let v659 : unit = ()
            let v660 : (unit -> unit) = closure26(v643, v655)
            let v661 : unit = (fun () -> v660 (); v659) ()
            return struct (v643, v655) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v702 : Async<struct (int32 * string)> = _v36 
    let _v26 = v702 
    #endif
#if FABLE_COMPILER_PYTHON
    let v703 : unit = ()
    let _v703 =
        async {
            let v704 : US6 = method21(v0)
            let struct (v715 : string, v716 : US5) =
                match v704 with
                | US6_1(v707) -> (* Error *)
                    let v708 : string = $"resultm.get / Result value was Error: {v707}"
                    failwith<struct (string * US5)> v708
                | US6_0(v705, v706) -> (* Ok *)
                    struct (v705, v706)
            let v717 : (string -> US5) = method4()
            let v718 : US5 option = v6 |> Option.map v717 
            let v729 : US5 = US5_1
            let v730 : US5 = v718 |> Option.defaultValue v729 
            let v737 : string =
                match v730 with
                | US5_1 -> (* None *)
                    let v735 : string = ""
                    v735
                | US5_0(v734) -> (* Some *)
                    v734
            let v738 : unit = ()
            let v739 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v716, v715)
            let v740 : unit = (fun () -> v739 (); v738) ()
            let v780 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v784 : string =
                match v716 with
                | US5_1 -> (* None *)
                    let v782 : string = ""
                    v782
                | US5_0(v781) -> (* Some *)
                    v781
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v784,
              StandardOutputEncoding = v780,
              WorkingDirectory = v737,
              FileName = v715,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v785 : System.Diagnostics.ProcessStartInfo = start_info
            let v786 : (struct (string * string) []) = method37(v0, v1, v2, v3, v4, v5, v6)
            let v787 : int32 = v786.Length
            let v788 : Mut5 = {l0 = 0} : Mut5
            while method23(v787, v788) do
                let v790 : int32 = v788.l0
                let struct (v791 : string, v792 : string) = v786.[int v790]
                v785.EnvironmentVariables.[v791] <- v792 
                let v793 : int32 = v790 + 1
                v788.l0 <- v793
                ()
            let v794 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v785)
            use v794 = v794 
            let v795 : System.Diagnostics.Process = v794 
            let v796 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v797 : System.Collections.Concurrent.ConcurrentStack<string> = v796 ()
            let v798 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v795, v797)
            v795.OutputDataReceived.Add v798 
            let v799 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v795, v797)
            v795.ErrorDataReceived.Add v799 
            let v800 : (unit -> bool) = v795.Start
            let v801 : bool = v800 ()
            let v802 : bool = v801 = false
            if v802 then
                let v803 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v803
            let v804 : (unit -> unit) = v795.BeginErrorReadLine
            v804 ()
            let v805 : (unit -> unit) = v795.BeginOutputReadLine
            v805 ()
            let v806 : (System.Threading.CancellationToken -> US15) = method41()
            let v807 : US15 option = v1 |> Option.map v806 
            let v818 : US15 = US15_1
            let v819 : US15 = v807 |> Option.defaultValue v818 
            let v826 : System.Threading.CancellationToken =
                match v819 with
                | US15_1 -> (* None *)
                    let v824 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v824
                | US15_0(v823) -> (* Some *)
                    v823
            let v827 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v828 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v828 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v831 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v831 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v834 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v834 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v837 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v837 
            #endif
#if FABLE_COMPILER_PYTHON
            let v840 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v840 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v843 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v827 = v843 
            #endif
#else
            let v846 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v847 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v846 = v847 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v850 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v846 = v850 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v853 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v846 = v853 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v856 : unit = ()
            let _v856 =
                async {
                    let v857 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v857 = v857 
                    let v858 : System.Threading.CancellationToken = v857 
                    let v859 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v860 : (System.Threading.CancellationToken []) = [|v858; v859; v826|]
                    let v861 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v862 : System.Threading.CancellationTokenSource = v861 v860
                    let v863 : System.Threading.CancellationToken = v862.Token
                    return v863 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v864 : Async<System.Threading.CancellationToken> = _v856 
            let _v846 = v864 
            #endif
#if FABLE_COMPILER_PYTHON
            let v865 : unit = ()
            let _v865 =
                async {
                    let v866 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v866 = v866 
                    let v867 : System.Threading.CancellationToken = v866 
                    let v868 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v869 : (System.Threading.CancellationToken []) = [|v867; v868; v826|]
                    let v870 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v871 : System.Threading.CancellationTokenSource = v870 v869
                    let v872 : System.Threading.CancellationToken = v871.Token
                    return v872 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v873 : Async<System.Threading.CancellationToken> = _v865 
            let _v846 = v873 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v874 : unit = ()
            let _v874 =
                async {
                    let v875 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v875 = v875 
                    let v876 : System.Threading.CancellationToken = v875 
                    let v877 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v878 : (System.Threading.CancellationToken []) = [|v876; v877; v826|]
                    let v879 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v880 : System.Threading.CancellationTokenSource = v879 v878
                    let v881 : System.Threading.CancellationToken = v880.Token
                    return v881 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v882 : Async<System.Threading.CancellationToken> = _v874 
            let _v846 = v882 
            #endif
#else
            let v883 : unit = ()
            let _v883 =
                async {
                    let v884 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v884 = v884 
                    let v885 : System.Threading.CancellationToken = v884 
                    let v886 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v887 : (System.Threading.CancellationToken []) = [|v885; v886; v826|]
                    let v888 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v889 : System.Threading.CancellationTokenSource = v888 v887
                    let v890 : System.Threading.CancellationToken = v889.Token
                    return v890 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v891 : Async<System.Threading.CancellationToken> = _v883 
            let _v846 = v891 
            #endif
            let v892 : Async<System.Threading.CancellationToken> = _v846 
            let _v827 = v892 
            #endif
            let v897 : Async<System.Threading.CancellationToken> = _v827 
            let! v897 = v897 
            let v902 : System.Threading.CancellationToken = v897 
            let v903 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v902.Register
            let v904 : (unit -> unit) = closure24(v795)
            let v905 : System.Threading.CancellationTokenRegistration = v903 v904
            use v905 = v905 
            let v906 : System.Threading.CancellationTokenRegistration = v905 
            let v907 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v908 : Async<int32> = null |> unbox<Async<int32>>
            let _v907 = v908 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v911 : Async<int32> = null |> unbox<Async<int32>>
            let _v907 = v911 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v914 : Async<int32> = null |> unbox<Async<int32>>
            let _v907 = v914 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v917 : unit = ()
            let _v917 =
                async {
                    try
                    let v918 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v919 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v920 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v921 : Async<unit> = v920 v918
                    let _v919 = v921 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v922 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v923 : Async<unit> = v922 v918
                    let _v919 = v923 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v924 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v925 : Async<unit> = v924 v918
                    let _v919 = v925 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v926 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v927 : Async<unit> = v926 v918
                    let _v919 = v927 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v928 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v929 : Async<unit> = v928 v918
                    let _v919 = v929 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v930 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v931 : Async<unit> = v930 v918
                    let _v919 = v931 
                    #endif
#else
                    let v932 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v933 : Async<unit> = v932 v918
                    let _v919 = v933 
                    #endif
                    let v934 : Async<unit> = _v919 
                    do! v934 
                    let v939 : int32 = v795.ExitCode
                    return v939 
                    with ex ->
                        let v940 : exn = ex
                        let v941 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v942 : string = $"%A{v940}"
                        let _v941 = v942 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v945 : string = $"%A{v940}"
                        let _v941 = v945 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v948 : string = $"%A{v940}"
                        let _v941 = v948 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v951 : string = $"%A{v940}"
                        let _v941 = v951 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v954 : string = $"%A{v940}"
                        let _v941 = v954 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v957 : string = $"%A{v940}"
                        let _v941 = v957 
                        #endif
#else
                        let v960 : string = $"{v940.GetType ()}: {v940.Message}"
                        let _v941 = v960 
                        #endif
                        let v961 : string = _v941 
                        let v966 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v966 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v966 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v966 = () 
                        #endif
#else
                        let v967 : (string -> unit) = v797.Push
                        v967 v961
                        let _v966 = () 
                        #endif
                        _v966 
                        let v968 : System.Threading.Tasks.TaskCanceledException = v940 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v971 : unit = ()
                        let v972 : (unit -> unit) = closure25(v968)
                        let v973 : unit = (fun () -> v972 (); v971) ()
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
            let v1013 : Async<int32> = _v917 
            let _v907 = v1013 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1014 : unit = ()
            let _v1014 =
                async {
                    try
                    let v1015 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v1016 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1017 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1018 : Async<unit> = v1017 v1015
                    let _v1016 = v1018 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1019 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1020 : Async<unit> = v1019 v1015
                    let _v1016 = v1020 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1021 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1022 : Async<unit> = v1021 v1015
                    let _v1016 = v1022 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1023 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1024 : Async<unit> = v1023 v1015
                    let _v1016 = v1024 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1025 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1026 : Async<unit> = v1025 v1015
                    let _v1016 = v1026 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1027 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1028 : Async<unit> = v1027 v1015
                    let _v1016 = v1028 
                    #endif
#else
                    let v1029 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1030 : Async<unit> = v1029 v1015
                    let _v1016 = v1030 
                    #endif
                    let v1031 : Async<unit> = _v1016 
                    do! v1031 
                    let v1036 : int32 = v795.ExitCode
                    return v1036 
                    with ex ->
                        let v1037 : exn = ex
                        let v1038 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1039 : string = $"%A{v1037}"
                        let _v1038 = v1039 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1042 : string = $"%A{v1037}"
                        let _v1038 = v1042 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1045 : string = $"%A{v1037}"
                        let _v1038 = v1045 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1048 : string = $"%A{v1037}"
                        let _v1038 = v1048 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1051 : string = $"%A{v1037}"
                        let _v1038 = v1051 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1054 : string = $"%A{v1037}"
                        let _v1038 = v1054 
                        #endif
#else
                        let v1057 : string = $"{v1037.GetType ()}: {v1037.Message}"
                        let _v1038 = v1057 
                        #endif
                        let v1058 : string = _v1038 
                        let v1063 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1063 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1063 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1063 = () 
                        #endif
#else
                        let v1064 : (string -> unit) = v797.Push
                        v1064 v1058
                        let _v1063 = () 
                        #endif
                        _v1063 
                        let v1065 : System.Threading.Tasks.TaskCanceledException = v1037 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1068 : unit = ()
                        let v1069 : (unit -> unit) = closure25(v1065)
                        let v1070 : unit = (fun () -> v1069 (); v1068) ()
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
            let v1110 : Async<int32> = _v1014 
            let _v907 = v1110 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1111 : unit = ()
            let _v1111 =
                async {
                    try
                    let v1112 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v1113 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1114 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1115 : Async<unit> = v1114 v1112
                    let _v1113 = v1115 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1116 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1117 : Async<unit> = v1116 v1112
                    let _v1113 = v1117 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1118 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1119 : Async<unit> = v1118 v1112
                    let _v1113 = v1119 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1120 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1121 : Async<unit> = v1120 v1112
                    let _v1113 = v1121 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1122 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1123 : Async<unit> = v1122 v1112
                    let _v1113 = v1123 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1124 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1125 : Async<unit> = v1124 v1112
                    let _v1113 = v1125 
                    #endif
#else
                    let v1126 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1127 : Async<unit> = v1126 v1112
                    let _v1113 = v1127 
                    #endif
                    let v1128 : Async<unit> = _v1113 
                    do! v1128 
                    let v1133 : int32 = v795.ExitCode
                    return v1133 
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
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1160 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1160 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1160 = () 
                        #endif
#else
                        let v1161 : (string -> unit) = v797.Push
                        v1161 v1155
                        let _v1160 = () 
                        #endif
                        _v1160 
                        let v1162 : System.Threading.Tasks.TaskCanceledException = v1134 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1165 : unit = ()
                        let v1166 : (unit -> unit) = closure25(v1162)
                        let v1167 : unit = (fun () -> v1166 (); v1165) ()
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
            let v1207 : Async<int32> = _v1111 
            let _v907 = v1207 
            #endif
#else
            let v1208 : unit = ()
            let _v1208 =
                async {
                    try
                    let v1209 : System.Threading.Tasks.Task = v795.WaitForExitAsync v902 
                    let v1210 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1211 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1212 : Async<unit> = v1211 v1209
                    let _v1210 = v1212 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1213 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1214 : Async<unit> = v1213 v1209
                    let _v1210 = v1214 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1215 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1216 : Async<unit> = v1215 v1209
                    let _v1210 = v1216 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1217 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1218 : Async<unit> = v1217 v1209
                    let _v1210 = v1218 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1219 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1220 : Async<unit> = v1219 v1209
                    let _v1210 = v1220 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1221 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1222 : Async<unit> = v1221 v1209
                    let _v1210 = v1222 
                    #endif
#else
                    let v1223 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1224 : Async<unit> = v1223 v1209
                    let _v1210 = v1224 
                    #endif
                    let v1225 : Async<unit> = _v1210 
                    do! v1225 
                    let v1230 : int32 = v795.ExitCode
                    return v1230 
                    with ex ->
                        let v1231 : exn = ex
                        let v1232 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1233 : string = $"%A{v1231}"
                        let _v1232 = v1233 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1236 : string = $"%A{v1231}"
                        let _v1232 = v1236 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1239 : string = $"%A{v1231}"
                        let _v1232 = v1239 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1242 : string = $"%A{v1231}"
                        let _v1232 = v1242 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1245 : string = $"%A{v1231}"
                        let _v1232 = v1245 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1248 : string = $"%A{v1231}"
                        let _v1232 = v1248 
                        #endif
#else
                        let v1251 : string = $"{v1231.GetType ()}: {v1231.Message}"
                        let _v1232 = v1251 
                        #endif
                        let v1252 : string = _v1232 
                        let v1257 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1257 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1257 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1257 = () 
                        #endif
#else
                        let v1258 : (string -> unit) = v797.Push
                        v1258 v1252
                        let _v1257 = () 
                        #endif
                        _v1257 
                        let v1259 : System.Threading.Tasks.TaskCanceledException = v1231 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1262 : unit = ()
                        let v1263 : (unit -> unit) = closure25(v1259)
                        let v1264 : unit = (fun () -> v1263 (); v1262) ()
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
            let v1304 : Async<int32> = _v1208 
            let _v907 = v1304 
            #endif
            let v1305 : Async<int32> = _v907 
            let! v1305 = v1305 
            let v1310 : int32 = v1305 
            let v1311 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v1312 : string seq = v1311 v797
            let v1315 : (string seq -> string seq) = Seq.rev
            let v1316 : string seq = v1315 v1312
            let v1319 : string = method44()
            let v1320 : (string -> (string seq -> string)) = String.concat
            let v1321 : (string seq -> string) = v1320 v1319
            let v1322 : string = v1321 v1316
            let v1326 : unit = ()
            let v1327 : (unit -> unit) = closure26(v1310, v1322)
            let v1328 : unit = (fun () -> v1327 (); v1326) ()
            return struct (v1310, v1322) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v1369 : Async<struct (int32 * string)> = _v703 
    let _v26 = v1369 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1370 : unit = ()
    let _v1370 =
        async {
            let v1371 : US6 = method21(v0)
            let struct (v1382 : string, v1383 : US5) =
                match v1371 with
                | US6_1(v1374) -> (* Error *)
                    let v1375 : string = $"resultm.get / Result value was Error: {v1374}"
                    failwith<struct (string * US5)> v1375
                | US6_0(v1372, v1373) -> (* Ok *)
                    struct (v1372, v1373)
            let v1384 : (string -> US5) = method4()
            let v1385 : US5 option = v6 |> Option.map v1384 
            let v1396 : US5 = US5_1
            let v1397 : US5 = v1385 |> Option.defaultValue v1396 
            let v1404 : string =
                match v1397 with
                | US5_1 -> (* None *)
                    let v1402 : string = ""
                    v1402
                | US5_0(v1401) -> (* Some *)
                    v1401
            let v1405 : unit = ()
            let v1406 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v1383, v1382)
            let v1407 : unit = (fun () -> v1406 (); v1405) ()
            let v1447 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v1451 : string =
                match v1383 with
                | US5_1 -> (* None *)
                    let v1449 : string = ""
                    v1449
                | US5_0(v1448) -> (* Some *)
                    v1448
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v1451,
              StandardOutputEncoding = v1447,
              WorkingDirectory = v1404,
              FileName = v1382,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v1452 : System.Diagnostics.ProcessStartInfo = start_info
            let v1453 : (struct (string * string) []) = method37(v0, v1, v2, v3, v4, v5, v6)
            let v1454 : int32 = v1453.Length
            let v1455 : Mut5 = {l0 = 0} : Mut5
            while method23(v1454, v1455) do
                let v1457 : int32 = v1455.l0
                let struct (v1458 : string, v1459 : string) = v1453.[int v1457]
                v1452.EnvironmentVariables.[v1458] <- v1459 
                let v1460 : int32 = v1457 + 1
                v1455.l0 <- v1460
                ()
            let v1461 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1452)
            use v1461 = v1461 
            let v1462 : System.Diagnostics.Process = v1461 
            let v1463 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v1464 : System.Collections.Concurrent.ConcurrentStack<string> = v1463 ()
            let v1465 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v1462, v1464)
            v1462.OutputDataReceived.Add v1465 
            let v1466 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v1462, v1464)
            v1462.ErrorDataReceived.Add v1466 
            let v1467 : (unit -> bool) = v1462.Start
            let v1468 : bool = v1467 ()
            let v1469 : bool = v1468 = false
            if v1469 then
                let v1470 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v1470
            let v1471 : (unit -> unit) = v1462.BeginErrorReadLine
            v1471 ()
            let v1472 : (unit -> unit) = v1462.BeginOutputReadLine
            v1472 ()
            let v1473 : (System.Threading.CancellationToken -> US15) = method41()
            let v1474 : US15 option = v1 |> Option.map v1473 
            let v1485 : US15 = US15_1
            let v1486 : US15 = v1474 |> Option.defaultValue v1485 
            let v1493 : System.Threading.CancellationToken =
                match v1486 with
                | US15_1 -> (* None *)
                    let v1491 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v1491
                | US15_0(v1490) -> (* Some *)
                    v1490
            let v1494 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1495 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1495 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1498 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1498 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1501 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1501 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1504 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1504 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1507 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1507 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1510 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1494 = v1510 
            #endif
#else
            let v1513 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1514 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1513 = v1514 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1517 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1513 = v1517 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1520 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v1513 = v1520 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1523 : unit = ()
            let _v1523 =
                async {
                    let v1524 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1524 = v1524 
                    let v1525 : System.Threading.CancellationToken = v1524 
                    let v1526 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1527 : (System.Threading.CancellationToken []) = [|v1525; v1526; v1493|]
                    let v1528 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1529 : System.Threading.CancellationTokenSource = v1528 v1527
                    let v1530 : System.Threading.CancellationToken = v1529.Token
                    return v1530 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1531 : Async<System.Threading.CancellationToken> = _v1523 
            let _v1513 = v1531 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1532 : unit = ()
            let _v1532 =
                async {
                    let v1533 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1533 = v1533 
                    let v1534 : System.Threading.CancellationToken = v1533 
                    let v1535 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1536 : (System.Threading.CancellationToken []) = [|v1534; v1535; v1493|]
                    let v1537 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1538 : System.Threading.CancellationTokenSource = v1537 v1536
                    let v1539 : System.Threading.CancellationToken = v1538.Token
                    return v1539 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1540 : Async<System.Threading.CancellationToken> = _v1532 
            let _v1513 = v1540 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1541 : unit = ()
            let _v1541 =
                async {
                    let v1542 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1542 = v1542 
                    let v1543 : System.Threading.CancellationToken = v1542 
                    let v1544 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1545 : (System.Threading.CancellationToken []) = [|v1543; v1544; v1493|]
                    let v1546 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1547 : System.Threading.CancellationTokenSource = v1546 v1545
                    let v1548 : System.Threading.CancellationToken = v1547.Token
                    return v1548 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1549 : Async<System.Threading.CancellationToken> = _v1541 
            let _v1513 = v1549 
            #endif
#else
            let v1550 : unit = ()
            let _v1550 =
                async {
                    let v1551 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v1551 = v1551 
                    let v1552 : System.Threading.CancellationToken = v1551 
                    let v1553 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v1554 : (System.Threading.CancellationToken []) = [|v1552; v1553; v1493|]
                    let v1555 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v1556 : System.Threading.CancellationTokenSource = v1555 v1554
                    let v1557 : System.Threading.CancellationToken = v1556.Token
                    return v1557 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v1558 : Async<System.Threading.CancellationToken> = _v1550 
            let _v1513 = v1558 
            #endif
            let v1559 : Async<System.Threading.CancellationToken> = _v1513 
            let _v1494 = v1559 
            #endif
            let v1564 : Async<System.Threading.CancellationToken> = _v1494 
            let! v1564 = v1564 
            let v1569 : System.Threading.CancellationToken = v1564 
            let v1570 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1569.Register
            let v1571 : (unit -> unit) = closure24(v1462)
            let v1572 : System.Threading.CancellationTokenRegistration = v1570 v1571
            use v1572 = v1572 
            let v1573 : System.Threading.CancellationTokenRegistration = v1572 
            let v1574 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v1575 : Async<int32> = null |> unbox<Async<int32>>
            let _v1574 = v1575 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v1578 : Async<int32> = null |> unbox<Async<int32>>
            let _v1574 = v1578 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v1581 : Async<int32> = null |> unbox<Async<int32>>
            let _v1574 = v1581 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v1584 : unit = ()
            let _v1584 =
                async {
                    try
                    let v1585 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1586 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1587 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1588 : Async<unit> = v1587 v1585
                    let _v1586 = v1588 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1589 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1590 : Async<unit> = v1589 v1585
                    let _v1586 = v1590 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1591 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1592 : Async<unit> = v1591 v1585
                    let _v1586 = v1592 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1593 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1594 : Async<unit> = v1593 v1585
                    let _v1586 = v1594 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1595 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1596 : Async<unit> = v1595 v1585
                    let _v1586 = v1596 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1597 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1598 : Async<unit> = v1597 v1585
                    let _v1586 = v1598 
                    #endif
#else
                    let v1599 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1600 : Async<unit> = v1599 v1585
                    let _v1586 = v1600 
                    #endif
                    let v1601 : Async<unit> = _v1586 
                    do! v1601 
                    let v1606 : int32 = v1462.ExitCode
                    return v1606 
                    with ex ->
                        let v1607 : exn = ex
                        let v1608 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1609 : string = $"%A{v1607}"
                        let _v1608 = v1609 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1612 : string = $"%A{v1607}"
                        let _v1608 = v1612 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1615 : string = $"%A{v1607}"
                        let _v1608 = v1615 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1618 : string = $"%A{v1607}"
                        let _v1608 = v1618 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1621 : string = $"%A{v1607}"
                        let _v1608 = v1621 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1624 : string = $"%A{v1607}"
                        let _v1608 = v1624 
                        #endif
#else
                        let v1627 : string = $"{v1607.GetType ()}: {v1607.Message}"
                        let _v1608 = v1627 
                        #endif
                        let v1628 : string = _v1608 
                        let v1633 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1633 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1633 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1633 = () 
                        #endif
#else
                        let v1634 : (string -> unit) = v1464.Push
                        v1634 v1628
                        let _v1633 = () 
                        #endif
                        _v1633 
                        let v1635 : System.Threading.Tasks.TaskCanceledException = v1607 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1638 : unit = ()
                        let v1639 : (unit -> unit) = closure25(v1635)
                        let v1640 : unit = (fun () -> v1639 (); v1638) ()
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
            let v1680 : Async<int32> = _v1584 
            let _v1574 = v1680 
            #endif
#if FABLE_COMPILER_PYTHON
            let v1681 : unit = ()
            let _v1681 =
                async {
                    try
                    let v1682 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1683 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1684 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1685 : Async<unit> = v1684 v1682
                    let _v1683 = v1685 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1686 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1687 : Async<unit> = v1686 v1682
                    let _v1683 = v1687 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1688 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1689 : Async<unit> = v1688 v1682
                    let _v1683 = v1689 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1690 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1691 : Async<unit> = v1690 v1682
                    let _v1683 = v1691 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1692 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1693 : Async<unit> = v1692 v1682
                    let _v1683 = v1693 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1694 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1695 : Async<unit> = v1694 v1682
                    let _v1683 = v1695 
                    #endif
#else
                    let v1696 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1697 : Async<unit> = v1696 v1682
                    let _v1683 = v1697 
                    #endif
                    let v1698 : Async<unit> = _v1683 
                    do! v1698 
                    let v1703 : int32 = v1462.ExitCode
                    return v1703 
                    with ex ->
                        let v1704 : exn = ex
                        let v1705 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1706 : string = $"%A{v1704}"
                        let _v1705 = v1706 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1709 : string = $"%A{v1704}"
                        let _v1705 = v1709 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1712 : string = $"%A{v1704}"
                        let _v1705 = v1712 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1715 : string = $"%A{v1704}"
                        let _v1705 = v1715 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1718 : string = $"%A{v1704}"
                        let _v1705 = v1718 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1721 : string = $"%A{v1704}"
                        let _v1705 = v1721 
                        #endif
#else
                        let v1724 : string = $"{v1704.GetType ()}: {v1704.Message}"
                        let _v1705 = v1724 
                        #endif
                        let v1725 : string = _v1705 
                        let v1730 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1730 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1730 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1730 = () 
                        #endif
#else
                        let v1731 : (string -> unit) = v1464.Push
                        v1731 v1725
                        let _v1730 = () 
                        #endif
                        _v1730 
                        let v1732 : System.Threading.Tasks.TaskCanceledException = v1704 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1735 : unit = ()
                        let v1736 : (unit -> unit) = closure25(v1732)
                        let v1737 : unit = (fun () -> v1736 (); v1735) ()
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
            let v1777 : Async<int32> = _v1681 
            let _v1574 = v1777 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v1778 : unit = ()
            let _v1778 =
                async {
                    try
                    let v1779 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1780 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1781 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1782 : Async<unit> = v1781 v1779
                    let _v1780 = v1782 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1783 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1784 : Async<unit> = v1783 v1779
                    let _v1780 = v1784 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1785 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1786 : Async<unit> = v1785 v1779
                    let _v1780 = v1786 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1787 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1788 : Async<unit> = v1787 v1779
                    let _v1780 = v1788 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1789 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1790 : Async<unit> = v1789 v1779
                    let _v1780 = v1790 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1791 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1792 : Async<unit> = v1791 v1779
                    let _v1780 = v1792 
                    #endif
#else
                    let v1793 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1794 : Async<unit> = v1793 v1779
                    let _v1780 = v1794 
                    #endif
                    let v1795 : Async<unit> = _v1780 
                    do! v1795 
                    let v1800 : int32 = v1462.ExitCode
                    return v1800 
                    with ex ->
                        let v1801 : exn = ex
                        let v1802 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1803 : string = $"%A{v1801}"
                        let _v1802 = v1803 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1806 : string = $"%A{v1801}"
                        let _v1802 = v1806 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1809 : string = $"%A{v1801}"
                        let _v1802 = v1809 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1812 : string = $"%A{v1801}"
                        let _v1802 = v1812 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1815 : string = $"%A{v1801}"
                        let _v1802 = v1815 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1818 : string = $"%A{v1801}"
                        let _v1802 = v1818 
                        #endif
#else
                        let v1821 : string = $"{v1801.GetType ()}: {v1801.Message}"
                        let _v1802 = v1821 
                        #endif
                        let v1822 : string = _v1802 
                        let v1827 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1827 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1827 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1827 = () 
                        #endif
#else
                        let v1828 : (string -> unit) = v1464.Push
                        v1828 v1822
                        let _v1827 = () 
                        #endif
                        _v1827 
                        let v1829 : System.Threading.Tasks.TaskCanceledException = v1801 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1832 : unit = ()
                        let v1833 : (unit -> unit) = closure25(v1829)
                        let v1834 : unit = (fun () -> v1833 (); v1832) ()
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
            let v1874 : Async<int32> = _v1778 
            let _v1574 = v1874 
            #endif
#else
            let v1875 : unit = ()
            let _v1875 =
                async {
                    try
                    let v1876 : System.Threading.Tasks.Task = v1462.WaitForExitAsync v1569 
                    let v1877 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1878 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1879 : Async<unit> = v1878 v1876
                    let _v1877 = v1879 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1880 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1881 : Async<unit> = v1880 v1876
                    let _v1877 = v1881 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1882 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1883 : Async<unit> = v1882 v1876
                    let _v1877 = v1883 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1884 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1885 : Async<unit> = v1884 v1876
                    let _v1877 = v1885 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1886 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1887 : Async<unit> = v1886 v1876
                    let _v1877 = v1887 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v1888 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1889 : Async<unit> = v1888 v1876
                    let _v1877 = v1889 
                    #endif
#else
                    let v1890 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v1891 : Async<unit> = v1890 v1876
                    let _v1877 = v1891 
                    #endif
                    let v1892 : Async<unit> = _v1877 
                    do! v1892 
                    let v1897 : int32 = v1462.ExitCode
                    return v1897 
                    with ex ->
                        let v1898 : exn = ex
                        let v1899 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1900 : string = $"%A{v1898}"
                        let _v1899 = v1900 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1903 : string = $"%A{v1898}"
                        let _v1899 = v1903 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1906 : string = $"%A{v1898}"
                        let _v1899 = v1906 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1909 : string = $"%A{v1898}"
                        let _v1899 = v1909 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1912 : string = $"%A{v1898}"
                        let _v1899 = v1912 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v1915 : string = $"%A{v1898}"
                        let _v1899 = v1915 
                        #endif
#else
                        let v1918 : string = $"{v1898.GetType ()}: {v1898.Message}"
                        let _v1899 = v1918 
                        #endif
                        let v1919 : string = _v1899 
                        let v1924 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v1924 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v1924 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v1924 = () 
                        #endif
#else
                        let v1925 : (string -> unit) = v1464.Push
                        v1925 v1919
                        let _v1924 = () 
                        #endif
                        _v1924 
                        let v1926 : System.Threading.Tasks.TaskCanceledException = v1898 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v1929 : unit = ()
                        let v1930 : (unit -> unit) = closure25(v1926)
                        let v1931 : unit = (fun () -> v1930 (); v1929) ()
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
            let v1971 : Async<int32> = _v1875 
            let _v1574 = v1971 
            #endif
            let v1972 : Async<int32> = _v1574 
            let! v1972 = v1972 
            let v1977 : int32 = v1972 
            let v1978 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v1979 : string seq = v1978 v1464
            let v1982 : (string seq -> string seq) = Seq.rev
            let v1983 : string seq = v1982 v1979
            let v1986 : string = method44()
            let v1987 : (string -> (string seq -> string)) = String.concat
            let v1988 : (string seq -> string) = v1987 v1986
            let v1989 : string = v1988 v1983
            let v1993 : unit = ()
            let v1994 : (unit -> unit) = closure26(v1977, v1989)
            let v1995 : unit = (fun () -> v1994 (); v1993) ()
            return struct (v1977, v1989) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2036 : Async<struct (int32 * string)> = _v1370 
    let _v26 = v2036 
    #endif
#else
    let v2037 : unit = ()
    let _v2037 =
        async {
            let v2038 : US6 = method21(v0)
            let struct (v2049 : string, v2050 : US5) =
                match v2038 with
                | US6_1(v2041) -> (* Error *)
                    let v2042 : string = $"resultm.get / Result value was Error: {v2041}"
                    failwith<struct (string * US5)> v2042
                | US6_0(v2039, v2040) -> (* Ok *)
                    struct (v2039, v2040)
            let v2051 : (string -> US5) = method4()
            let v2052 : US5 option = v6 |> Option.map v2051 
            let v2063 : US5 = US5_1
            let v2064 : US5 = v2052 |> Option.defaultValue v2063 
            let v2071 : string =
                match v2064 with
                | US5_1 -> (* None *)
                    let v2069 : string = ""
                    v2069
                | US5_0(v2068) -> (* Some *)
                    v2068
            let v2072 : unit = ()
            let v2073 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v2050, v2049)
            let v2074 : unit = (fun () -> v2073 (); v2072) ()
            let v2114 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v2118 : string =
                match v2050 with
                | US5_1 -> (* None *)
                    let v2116 : string = ""
                    v2116
                | US5_0(v2115) -> (* Some *)
                    v2115
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v2118,
              StandardOutputEncoding = v2114,
              WorkingDirectory = v2071,
              FileName = v2049,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v2119 : System.Diagnostics.ProcessStartInfo = start_info
            let v2120 : (struct (string * string) []) = method37(v0, v1, v2, v3, v4, v5, v6)
            let v2121 : int32 = v2120.Length
            let v2122 : Mut5 = {l0 = 0} : Mut5
            while method23(v2121, v2122) do
                let v2124 : int32 = v2122.l0
                let struct (v2125 : string, v2126 : string) = v2120.[int v2124]
                v2119.EnvironmentVariables.[v2125] <- v2126 
                let v2127 : int32 = v2124 + 1
                v2122.l0 <- v2127
                ()
            let v2128 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v2119)
            use v2128 = v2128 
            let v2129 : System.Diagnostics.Process = v2128 
            let v2130 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v2131 : System.Collections.Concurrent.ConcurrentStack<string> = v2130 ()
            let v2132 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v2129, v2131)
            v2129.OutputDataReceived.Add v2132 
            let v2133 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v2129, v2131)
            v2129.ErrorDataReceived.Add v2133 
            let v2134 : (unit -> bool) = v2129.Start
            let v2135 : bool = v2134 ()
            let v2136 : bool = v2135 = false
            if v2136 then
                let v2137 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v2137
            let v2138 : (unit -> unit) = v2129.BeginErrorReadLine
            v2138 ()
            let v2139 : (unit -> unit) = v2129.BeginOutputReadLine
            v2139 ()
            let v2140 : (System.Threading.CancellationToken -> US15) = method41()
            let v2141 : US15 option = v1 |> Option.map v2140 
            let v2152 : US15 = US15_1
            let v2153 : US15 = v2141 |> Option.defaultValue v2152 
            let v2160 : System.Threading.CancellationToken =
                match v2153 with
                | US15_1 -> (* None *)
                    let v2158 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v2158
                | US15_0(v2157) -> (* Some *)
                    v2157
            let v2161 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2162 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2162 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2165 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2165 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2168 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2168 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2171 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2174 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2174 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2177 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2161 = v2177 
            #endif
#else
            let v2180 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2181 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2180 = v2181 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2184 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2180 = v2184 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2187 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v2180 = v2187 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2190 : unit = ()
            let _v2190 =
                async {
                    let v2191 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2191 = v2191 
                    let v2192 : System.Threading.CancellationToken = v2191 
                    let v2193 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2194 : (System.Threading.CancellationToken []) = [|v2192; v2193; v2160|]
                    let v2195 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2196 : System.Threading.CancellationTokenSource = v2195 v2194
                    let v2197 : System.Threading.CancellationToken = v2196.Token
                    return v2197 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2198 : Async<System.Threading.CancellationToken> = _v2190 
            let _v2180 = v2198 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2199 : unit = ()
            let _v2199 =
                async {
                    let v2200 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2200 = v2200 
                    let v2201 : System.Threading.CancellationToken = v2200 
                    let v2202 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2203 : (System.Threading.CancellationToken []) = [|v2201; v2202; v2160|]
                    let v2204 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2205 : System.Threading.CancellationTokenSource = v2204 v2203
                    let v2206 : System.Threading.CancellationToken = v2205.Token
                    return v2206 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2207 : Async<System.Threading.CancellationToken> = _v2199 
            let _v2180 = v2207 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2208 : unit = ()
            let _v2208 =
                async {
                    let v2209 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2209 = v2209 
                    let v2210 : System.Threading.CancellationToken = v2209 
                    let v2211 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2212 : (System.Threading.CancellationToken []) = [|v2210; v2211; v2160|]
                    let v2213 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2214 : System.Threading.CancellationTokenSource = v2213 v2212
                    let v2215 : System.Threading.CancellationToken = v2214.Token
                    return v2215 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2216 : Async<System.Threading.CancellationToken> = _v2208 
            let _v2180 = v2216 
            #endif
#else
            let v2217 : unit = ()
            let _v2217 =
                async {
                    let v2218 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v2218 = v2218 
                    let v2219 : System.Threading.CancellationToken = v2218 
                    let v2220 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v2221 : (System.Threading.CancellationToken []) = [|v2219; v2220; v2160|]
                    let v2222 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v2223 : System.Threading.CancellationTokenSource = v2222 v2221
                    let v2224 : System.Threading.CancellationToken = v2223.Token
                    return v2224 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v2225 : Async<System.Threading.CancellationToken> = _v2217 
            let _v2180 = v2225 
            #endif
            let v2226 : Async<System.Threading.CancellationToken> = _v2180 
            let _v2161 = v2226 
            #endif
            let v2231 : Async<System.Threading.CancellationToken> = _v2161 
            let! v2231 = v2231 
            let v2236 : System.Threading.CancellationToken = v2231 
            let v2237 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v2236.Register
            let v2238 : (unit -> unit) = closure24(v2129)
            let v2239 : System.Threading.CancellationTokenRegistration = v2237 v2238
            use v2239 = v2239 
            let v2240 : System.Threading.CancellationTokenRegistration = v2239 
            let v2241 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v2242 : Async<int32> = null |> unbox<Async<int32>>
            let _v2241 = v2242 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v2245 : Async<int32> = null |> unbox<Async<int32>>
            let _v2241 = v2245 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v2248 : Async<int32> = null |> unbox<Async<int32>>
            let _v2241 = v2248 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v2251 : unit = ()
            let _v2251 =
                async {
                    try
                    let v2252 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2253 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2254 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2255 : Async<unit> = v2254 v2252
                    let _v2253 = v2255 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2256 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2257 : Async<unit> = v2256 v2252
                    let _v2253 = v2257 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2258 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2259 : Async<unit> = v2258 v2252
                    let _v2253 = v2259 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2260 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2261 : Async<unit> = v2260 v2252
                    let _v2253 = v2261 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2262 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2263 : Async<unit> = v2262 v2252
                    let _v2253 = v2263 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2264 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2265 : Async<unit> = v2264 v2252
                    let _v2253 = v2265 
                    #endif
#else
                    let v2266 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2267 : Async<unit> = v2266 v2252
                    let _v2253 = v2267 
                    #endif
                    let v2268 : Async<unit> = _v2253 
                    do! v2268 
                    let v2273 : int32 = v2129.ExitCode
                    return v2273 
                    with ex ->
                        let v2274 : exn = ex
                        let v2275 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2276 : string = $"%A{v2274}"
                        let _v2275 = v2276 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2279 : string = $"%A{v2274}"
                        let _v2275 = v2279 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2282 : string = $"%A{v2274}"
                        let _v2275 = v2282 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2285 : string = $"%A{v2274}"
                        let _v2275 = v2285 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2288 : string = $"%A{v2274}"
                        let _v2275 = v2288 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2291 : string = $"%A{v2274}"
                        let _v2275 = v2291 
                        #endif
#else
                        let v2294 : string = $"{v2274.GetType ()}: {v2274.Message}"
                        let _v2275 = v2294 
                        #endif
                        let v2295 : string = _v2275 
                        let v2300 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2300 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2300 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2300 = () 
                        #endif
#else
                        let v2301 : (string -> unit) = v2131.Push
                        v2301 v2295
                        let _v2300 = () 
                        #endif
                        _v2300 
                        let v2302 : System.Threading.Tasks.TaskCanceledException = v2274 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2305 : unit = ()
                        let v2306 : (unit -> unit) = closure25(v2302)
                        let v2307 : unit = (fun () -> v2306 (); v2305) ()
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
            let v2347 : Async<int32> = _v2251 
            let _v2241 = v2347 
            #endif
#if FABLE_COMPILER_PYTHON
            let v2348 : unit = ()
            let _v2348 =
                async {
                    try
                    let v2349 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2350 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2351 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2352 : Async<unit> = v2351 v2349
                    let _v2350 = v2352 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2353 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2354 : Async<unit> = v2353 v2349
                    let _v2350 = v2354 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2355 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2356 : Async<unit> = v2355 v2349
                    let _v2350 = v2356 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2357 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2358 : Async<unit> = v2357 v2349
                    let _v2350 = v2358 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2359 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2360 : Async<unit> = v2359 v2349
                    let _v2350 = v2360 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2361 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2362 : Async<unit> = v2361 v2349
                    let _v2350 = v2362 
                    #endif
#else
                    let v2363 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2364 : Async<unit> = v2363 v2349
                    let _v2350 = v2364 
                    #endif
                    let v2365 : Async<unit> = _v2350 
                    do! v2365 
                    let v2370 : int32 = v2129.ExitCode
                    return v2370 
                    with ex ->
                        let v2371 : exn = ex
                        let v2372 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2373 : string = $"%A{v2371}"
                        let _v2372 = v2373 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2376 : string = $"%A{v2371}"
                        let _v2372 = v2376 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2379 : string = $"%A{v2371}"
                        let _v2372 = v2379 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2382 : string = $"%A{v2371}"
                        let _v2372 = v2382 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2385 : string = $"%A{v2371}"
                        let _v2372 = v2385 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2388 : string = $"%A{v2371}"
                        let _v2372 = v2388 
                        #endif
#else
                        let v2391 : string = $"{v2371.GetType ()}: {v2371.Message}"
                        let _v2372 = v2391 
                        #endif
                        let v2392 : string = _v2372 
                        let v2397 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2397 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2397 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2397 = () 
                        #endif
#else
                        let v2398 : (string -> unit) = v2131.Push
                        v2398 v2392
                        let _v2397 = () 
                        #endif
                        _v2397 
                        let v2399 : System.Threading.Tasks.TaskCanceledException = v2371 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2402 : unit = ()
                        let v2403 : (unit -> unit) = closure25(v2399)
                        let v2404 : unit = (fun () -> v2403 (); v2402) ()
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
            let v2444 : Async<int32> = _v2348 
            let _v2241 = v2444 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v2445 : unit = ()
            let _v2445 =
                async {
                    try
                    let v2446 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2447 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2448 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2449 : Async<unit> = v2448 v2446
                    let _v2447 = v2449 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2450 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2451 : Async<unit> = v2450 v2446
                    let _v2447 = v2451 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2452 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2453 : Async<unit> = v2452 v2446
                    let _v2447 = v2453 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2454 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2455 : Async<unit> = v2454 v2446
                    let _v2447 = v2455 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2456 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2457 : Async<unit> = v2456 v2446
                    let _v2447 = v2457 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2458 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2459 : Async<unit> = v2458 v2446
                    let _v2447 = v2459 
                    #endif
#else
                    let v2460 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2461 : Async<unit> = v2460 v2446
                    let _v2447 = v2461 
                    #endif
                    let v2462 : Async<unit> = _v2447 
                    do! v2462 
                    let v2467 : int32 = v2129.ExitCode
                    return v2467 
                    with ex ->
                        let v2468 : exn = ex
                        let v2469 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2470 : string = $"%A{v2468}"
                        let _v2469 = v2470 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2473 : string = $"%A{v2468}"
                        let _v2469 = v2473 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2476 : string = $"%A{v2468}"
                        let _v2469 = v2476 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2479 : string = $"%A{v2468}"
                        let _v2469 = v2479 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2482 : string = $"%A{v2468}"
                        let _v2469 = v2482 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2485 : string = $"%A{v2468}"
                        let _v2469 = v2485 
                        #endif
#else
                        let v2488 : string = $"{v2468.GetType ()}: {v2468.Message}"
                        let _v2469 = v2488 
                        #endif
                        let v2489 : string = _v2469 
                        let v2494 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2494 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2494 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2494 = () 
                        #endif
#else
                        let v2495 : (string -> unit) = v2131.Push
                        v2495 v2489
                        let _v2494 = () 
                        #endif
                        _v2494 
                        let v2496 : System.Threading.Tasks.TaskCanceledException = v2468 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2499 : unit = ()
                        let v2500 : (unit -> unit) = closure25(v2496)
                        let v2501 : unit = (fun () -> v2500 (); v2499) ()
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
            let v2541 : Async<int32> = _v2445 
            let _v2241 = v2541 
            #endif
#else
            let v2542 : unit = ()
            let _v2542 =
                async {
                    try
                    let v2543 : System.Threading.Tasks.Task = v2129.WaitForExitAsync v2236 
                    let v2544 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v2545 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2546 : Async<unit> = v2545 v2543
                    let _v2544 = v2546 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v2547 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2548 : Async<unit> = v2547 v2543
                    let _v2544 = v2548 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v2549 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2550 : Async<unit> = v2549 v2543
                    let _v2544 = v2550 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v2551 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2552 : Async<unit> = v2551 v2543
                    let _v2544 = v2552 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v2553 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2554 : Async<unit> = v2553 v2543
                    let _v2544 = v2554 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v2555 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2556 : Async<unit> = v2555 v2543
                    let _v2544 = v2556 
                    #endif
#else
                    let v2557 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v2558 : Async<unit> = v2557 v2543
                    let _v2544 = v2558 
                    #endif
                    let v2559 : Async<unit> = _v2544 
                    do! v2559 
                    let v2564 : int32 = v2129.ExitCode
                    return v2564 
                    with ex ->
                        let v2565 : exn = ex
                        let v2566 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v2567 : string = $"%A{v2565}"
                        let _v2566 = v2567 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v2570 : string = $"%A{v2565}"
                        let _v2566 = v2570 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v2573 : string = $"%A{v2565}"
                        let _v2566 = v2573 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v2576 : string = $"%A{v2565}"
                        let _v2566 = v2576 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v2579 : string = $"%A{v2565}"
                        let _v2566 = v2579 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v2582 : string = $"%A{v2565}"
                        let _v2566 = v2582 
                        #endif
#else
                        let v2585 : string = $"{v2565.GetType ()}: {v2565.Message}"
                        let _v2566 = v2585 
                        #endif
                        let v2586 : string = _v2566 
                        let v2591 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let _v2591 = () 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let _v2591 = () 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let _v2591 = () 
                        #endif
#else
                        let v2592 : (string -> unit) = v2131.Push
                        v2592 v2586
                        let _v2591 = () 
                        #endif
                        _v2591 
                        let v2593 : System.Threading.Tasks.TaskCanceledException = v2565 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v2596 : unit = ()
                        let v2597 : (unit -> unit) = closure25(v2593)
                        let v2598 : unit = (fun () -> v2597 (); v2596) ()
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
            let v2638 : Async<int32> = _v2542 
            let _v2241 = v2638 
            #endif
            let v2639 : Async<int32> = _v2241 
            let! v2639 = v2639 
            let v2644 : int32 = v2639 
            let v2645 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.cast
            let v2646 : string seq = v2645 v2131
            let v2649 : (string seq -> string seq) = Seq.rev
            let v2650 : string seq = v2649 v2646
            let v2653 : string = method44()
            let v2654 : (string -> (string seq -> string)) = String.concat
            let v2655 : (string seq -> string) = v2654 v2653
            let v2656 : string = v2655 v2650
            let v2660 : unit = ()
            let v2661 : (unit -> unit) = closure26(v2644, v2656)
            let v2662 : unit = (fun () -> v2661 (); v2660) ()
            return struct (v2644, v2656) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v2703 : Async<struct (int32 * string)> = _v2037 
    let _v26 = v2703 
    #endif
    let v2704 : Async<struct (int32 * string)> = _v26 
    let _v7 = v2704 
    #endif
    let v2709 : Async<struct (int32 * string)> = _v7 
    v2709
and closure13 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method20(v0, v1, v2, v3, v4, v6, v5)
and closure27 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method20(v0, v1, v2, v3, v4, v5, v6)
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
and method49 (v0 : char, v1 : int64) : bool =
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
            method49(v0, v25)
and method50 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : struct (string * string * System.Text.StringBuilder * int32 * int32) =
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
            let v29 : bool = method49(v27, v28)
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
                while method23(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method24()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method25(v73, v2, v3, v4)
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
        method50(v131, v123, v124, v125, v126)
and method52 (v0 : char, v1 : int64) : bool =
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
            method52(v0, v21)
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
                while method23(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method24()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method25(v53, v1, v2, v3)
                US7_0(v9, v30, v75, v76, v77)
            else
                let v79 : (string -> int32) = String.length
                let v80 : int32 = v79 v0
                let v83 : string = "\n"
                let v84 : int32 = v0.IndexOf v83 
                let v87 : int32 = v84 - 1
                let v88 : bool = -2 = v87
                let v91 : int32 =
                    if v88 then
                        let v89 : int32 = v80 + 1
                        v89
                    else
                        let v90 : int32 = v87 + 1
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
                while method23(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method24()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method25(v182, v131, v132, v133)
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
                while method23(v38, v40) do
                    let v42 : int32 = v40.l0
                    let v43 : char = v35.[int v42]
                    v39.[int v42] <- v43
                    let v44 : int32 = v42 + 1
                    v40.l0 <- v44
                    ()
                let v45 : char list = v39 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method24()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v45
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v75 : System.Text.StringBuilder, v76 : int32, v77 : int32) = method25(v53, v1, v2, v3)
                US7_0(v9, v30, v75, v76, v77)
            else
                let v79 : (string -> int32) = String.length
                let v80 : int32 = v79 v0
                let v83 : string = "\n"
                let v84 : int32 = v0.IndexOf v83 
                let v87 : int32 = v84 - 1
                let v88 : bool = -2 = v87
                let v91 : int32 =
                    if v88 then
                        let v89 : int32 = v80 + 1
                        v89
                    else
                        let v90 : int32 = v87 + 1
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
                while method23(v167, v169) do
                    let v171 : int32 = v169.l0
                    let v172 : char = v164.[int v171]
                    v168.[int v171] <- v172
                    let v173 : int32 = v171 + 1
                    v169.l0 <- v173
                    ()
                let v174 : char list = v168 |> Array.toList
                let v177 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v178 : (char -> (UH0 -> UH0)) = method24()
                let v179 : (char list -> (UH0 -> UH0)) = v177 v178
                let v180 : (UH0 -> UH0) = v179 v174
                let v181 : UH0 = UH0_0
                let v182 : UH0 = v180 v181
                let struct (v204 : System.Text.StringBuilder, v205 : int32, v206 : int32) = method25(v182, v131, v132, v133)
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
and method53 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US8 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US8 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US8_1(v15) -> (* Error *)
            method53(v0, v1, v2, v3, v8)
        | US8_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "parsing.choice / no parsers succeeded"
        US8_1(v5)
and method54 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method54(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method51 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
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
            let v26 : bool = method52(v24, v25)
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
                while method23(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method24()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method25(v70, v2, v3, v4)
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
            method53(v1, v2, v3, v4, v140)
        | US8_0(v130, v131, v132, v133, v134) -> (* Ok *)
            v129
    match v143 with
    | US8_1(v151) -> (* Error *)
        let v152 : UH2 = UH2_0
        let v153 : UH2 = method54(v0, v152)
        US17_0(v153, v1, v2, v3, v4)
    | US8_0(v144, v145, v146, v147, v148) -> (* Ok *)
        let v149 : UH2 = UH2_1(v144, v0)
        method51(v149, v145, v146, v147, v148)
and method55 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method55(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method56 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
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
            let v26 : bool = method52(v24, v25)
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
                while method23(v55, v57) do
                    let v59 : int32 = v57.l0
                    let v60 : char = v52.[int v59]
                    v56.[int v59] <- v60
                    let v61 : int32 = v59 + 1
                    v57.l0 <- v61
                    ()
                let v62 : char list = v56 |> Array.toList
                let v65 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v66 : (char -> (UH0 -> UH0)) = method24()
                let v67 : (char list -> (UH0 -> UH0)) = v65 v66
                let v68 : (UH0 -> UH0) = v67 v62
                let v69 : UH0 = UH0_0
                let v70 : UH0 = v68 v69
                let struct (v92 : System.Text.StringBuilder, v93 : int32, v94 : int32) = method25(v70, v2, v3, v4)
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
        let v139 : UH2 = method54(v0, v138)
        US17_0(v139, v1, v2, v3, v4)
    | US8_0(v130, v131, v132, v133, v134) -> (* Ok *)
        let v135 : UH2 = UH2_1(v130, v0)
        method56(v135, v131, v132, v133, v134)
and method48 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
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
            let v29 : bool = method49(v27, v28)
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
                while method23(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v55.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method24()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v95 : System.Text.StringBuilder, v96 : int32, v97 : int32) = method25(v73, v2, v3, v4)
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
            let struct (v131 : string, v132 : string, v133 : System.Text.StringBuilder, v134 : int32, v135 : int32) = method50(v128, v123, v124, v125, v126)
            US8_0(v131, v132, v133, v134, v135)
    let v517 : US8 =
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
                        while method23(v180, v182) do
                            let v184 : int32 = v182.l0
                            let v185 : char = v177.[int v184]
                            v181.[int v184] <- v185
                            let v186 : int32 = v184 + 1
                            v182.l0 <- v186
                            ()
                        let v187 : char list = v181 |> Array.toList
                        let v190 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v191 : (char -> (UH0 -> UH0)) = method24()
                        let v192 : (char list -> (UH0 -> UH0)) = v190 v191
                        let v193 : (UH0 -> UH0) = v192 v187
                        let v194 : UH0 = UH0_0
                        let v195 : UH0 = v193 v194
                        let struct (v217 : System.Text.StringBuilder, v218 : int32, v219 : int32) = method25(v195, v2, v3, v4)
                        US7_0(v151, v172, v217, v218, v219)
                    else
                        let v221 : (string -> int32) = String.length
                        let v222 : int32 = v221 v1
                        let v225 : string = "\n"
                        let v226 : int32 = v1.IndexOf v225 
                        let v229 : int32 = v226 - 1
                        let v230 : bool = -2 = v229
                        let v233 : int32 =
                            if v230 then
                                let v231 : int32 = v222 + 1
                                v231
                            else
                                let v232 : int32 = v229 + 1
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
            let v454 : US8 =
                match v270 with
                | US7_1(v451) -> (* Error *)
                    US8_1(v451)
                | US7_0(v271, v272, v273, v274, v275) -> (* Ok *)
                    let v276 : UH2 = UH2_0
                    let v277 : US17 = method51(v276, v272, v273, v274, v275)
                    let v302 : US8 =
                        match v277 with
                        | US17_1(v299) -> (* Error *)
                            US8_1(v299)
                        | US17_0(v278, v279, v280, v281, v282) -> (* Ok *)
                            let v283 : string list = []
                            let v284 : string list = method55(v278, v283)
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
                            let v286 : string seq = _v285 
                            let v292 : (string -> (string seq -> string)) = String.concat
                            let v293 : string = ""
                            let v294 : (string seq -> string) = v292 v293
                            let v295 : string = v294 v286
                            US8_0(v295, v279, v280, v281, v282)
                    match v302 with
                    | US8_1(v446) -> (* Error *)
                        let v447 : string = "parsing.between / expected content"
                        US8_1(v447)
                    | US8_0(v303, v304, v305, v306, v307) -> (* Ok *)
                        let v308 : bool = "" = v304
                        let v432 : US7 =
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
                                    while method23(v342, v344) do
                                        let v346 : int32 = v344.l0
                                        let v347 : char = v339.[int v346]
                                        v343.[int v346] <- v347
                                        let v348 : int32 = v346 + 1
                                        v344.l0 <- v348
                                        ()
                                    let v349 : char list = v343 |> Array.toList
                                    let v352 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v353 : (char -> (UH0 -> UH0)) = method24()
                                    let v354 : (char list -> (UH0 -> UH0)) = v352 v353
                                    let v355 : (UH0 -> UH0) = v354 v349
                                    let v356 : UH0 = UH0_0
                                    let v357 : UH0 = v355 v356
                                    let struct (v379 : System.Text.StringBuilder, v380 : int32, v381 : int32) = method25(v357, v305, v306, v307)
                                    US7_0(v313, v334, v379, v380, v381)
                                else
                                    let v383 : (string -> int32) = String.length
                                    let v384 : int32 = v383 v304
                                    let v387 : string = "\n"
                                    let v388 : int32 = v304.IndexOf v387 
                                    let v391 : int32 = v388 - 1
                                    let v392 : bool = -2 = v391
                                    let v395 : int32 =
                                        if v392 then
                                            let v393 : int32 = v384 + 1
                                            v393
                                        else
                                            let v394 : int32 = v391 + 1
                                            v394
                                    let v396 : int32 = 0 |> int32 
                                    let v403 : int32 = v395 |> int32 
                                    let v410 : int32 = v403 - 1
                                    let v411 : string = v304.[int v396..int v410]
                                    let v415 : string = $"parsing.p_char / expected: '{'"'}' / line: {v306} / col: {v307}
{v305}{v411}"
                                    let v418 : int32 = v307 - 1
                                    let v419 : (int32 -> (string -> string)) = String.replicate
                                    let v420 : (string -> string) = v419 v418
                                    let v421 : string = " "
                                    let v422 : string = v420 v421
                                    let v425 : string = "^"
                                    let v426 : string = v422 + v425 
                                    let v427 : string = $"{v415}
{v426}
"
                                    US7_1(v427)
                        match v432 with
                        | US7_1(v439) -> (* Error *)
                            let v440 : string = $"parsing.between / expected closing delimiter / e: %A{v439} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v272, v273, v274, v275)} / rest2: %A{struct (v304, v305, v306, v307)}"
                            US8_1(v440)
                        | US7_0(v433, v434, v435, v436, v437) -> (* Ok *)
                            US8_0(v303, v434, v435, v436, v437)
            match v454 with
            | US8_1(v460) -> (* Error *)
                let v461 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure30()
                let v462 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure31()
                let v463 : UH3 = UH3_0
                let v464 : UH3 = UH3_1(v462, v463)
                let v465 : UH3 = UH3_1(v461, v464)
                let v466 : US8 = method53(v1, v2, v3, v4, v465)
                let v477 : US8 =
                    match v466 with
                    | US8_1(v474) -> (* Error *)
                        US8_1(v474)
                    | US8_0(v467, v468, v469, v470, v471) -> (* Ok *)
                        let v472 : string = ""
                        US8_0(v472, v468, v469, v470, v471)
                let v488 : US17 =
                    match v477 with
                    | US8_1(v485) -> (* Error *)
                        US17_1(v485)
                    | US8_0(v478, v479, v480, v481, v482) -> (* Ok *)
                        let v483 : UH2 = UH2_0
                        method56(v483, v479, v480, v481, v482)
                match v488 with
                | US17_1(v510) -> (* Error *)
                    US8_1(v510)
                | US17_0(v489, v490, v491, v492, v493) -> (* Ok *)
                    let v494 : string list = []
                    let v495 : string list = method55(v489, v494)
                    let v496 : unit = ()
                    let _v496 =
                        seq {
                            for i = 0 to v495.Length - 1 do yield v495.[i]
                            (*
                            ()
                        *)
                        }
                        (*
                        ()
                    *)
                    let v497 : string seq = _v496 
                    let v503 : (string -> (string seq -> string)) = String.concat
                    let v504 : string = ""
                    let v505 : (string seq -> string) = v503 v504
                    let v506 : string = v505 v497
                    US8_0(v506, v490, v491, v492, v493)
            | US8_0(v455, v456, v457, v458, v459) -> (* Ok *)
                v454
        | US8_0(v141, v142, v143, v144, v145) -> (* Ok *)
            v140
    match v517 with
    | US8_1(v566) -> (* Error *)
        let v567 : UH2 = UH2_0
        let v568 : UH2 = method54(v0, v567)
        US17_0(v568, v1, v2, v3, v4)
    | US8_0(v518, v519, v520, v521, v522) -> (* Ok *)
        let v523 : int32 = 0
        let v524 : int32 = method32(v519, v523)
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
            let v562 : UH2 = method54(v0, v561)
            US17_0(v562, v519, v520, v521, v522)
        | US10_0(v553, v554, v555, v556) -> (* Ok *)
            let v557 : UH2 = UH2_1(v518, v0)
            method48(v557, v553, v554, v555, v556)
and method47 (v0 : string) : US16 =
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
    let v10 : string = method22()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v15 : UH2 = UH2_0
    let v16 : int32 = 1
    let v17 : int32 = 1
    let v18 : US17 = method48(v15, v7, v12, v16, v17)
    match v18 with
    | US17_1(v31) -> (* Error *)
        US16_1(v31)
    | US17_0(v19, v20, v21, v22, v23) -> (* Ok *)
        let v24 : string list = []
        let v25 : string list = method55(v19, v24)
        let v26 : (string list -> (string [])) = List.toArray
        let v27 : (string []) = v26 v25
        US16_0(v27)
and closure29 () (v0 : string) : Result<(string []), string> =
    let v1 : US16 = method47(v0)
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
