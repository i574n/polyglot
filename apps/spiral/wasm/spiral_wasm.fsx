#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::Worker<$0>")>]
#endif
type near_workspaces_Worker<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::Contract")>]
#endif
type near_workspaces_Contract = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::operations::CallTransaction")>]
#endif
type near_workspaces_operations_CallTransaction = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionFinalResult")>]
#endif
type near_workspaces_result_ExecutionFinalResult = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("anyhow::Error")>]
#endif
type anyhow_Error = class end
module State = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::network::Sandbox")>]
#endif
type near_workspaces_network_Sandbox = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::error::Error")>]
#endif
type near_workspaces_error_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionResult<$0>")>]
#endif
type near_workspaces_result_ExecutionResult<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::Value")>]
#endif
type near_workspaces_result_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_primitives::errors::TxExecutionError")>]
#endif
type near_primitives_errors_TxExecutionError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionOutcome")>]
#endif
type near_workspaces_result_ExecutionOutcome = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and Mut4 = {mutable l0 : string}
and [<Struct>] US4 =
    | US4_0 of f0_0 : std_string_String
    | US4_1
let rec closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "fn print_usd(result: near_workspaces::result::ExecutionFinalResult) { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "  const NEAR_PRICE_IN_USD: f64 = 6.68; //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "  fn gas_to_usd(gas: u64) -> f64 { //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "    (gas as f64) / 1e16 * NEAR_PRICE_IN_USD //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = "  fn tokens_to_usd(tokens: u128) -> f64 { //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "    (tokens as f64) / 1e24 * NEAR_PRICE_IN_USD //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "  } //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "  println!(\"gas_to_usd(result.total_gas_burnt.as_gas()): {:.6} ({:#?})\", //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "    gas_to_usd(result.total_gas_burnt.as_gas()), //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "    result.total_gas_burnt.as_gas() //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "  ); //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "  result.outcomes().iter().for_each(|outcome| { //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "    println!(\"outcome (success: {:#?}):\", outcome.is_success()); //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "    println!( //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "      \"  gas_to_usd(outcome.gas_burnt.as_gas()): {:.6} ({:#?})\", //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "      gas_to_usd(outcome.gas_burnt.as_gas()), //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "      outcome.gas_burnt.as_gas() //"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "    ); //"
    Fable.Core.RustInterop.emitRustExpr () v19 
    let v20 : string = "    println!( //"
    Fable.Core.RustInterop.emitRustExpr () v20 
    let v21 : string = "      \"  tokens_to_usd(outcome.tokens_burnt.as_yoctonear()): {:.6} ({:#?})\", //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "      tokens_to_usd(outcome.tokens_burnt.as_yoctonear()), //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "      outcome.tokens_burnt.as_yoctonear() //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "    ); //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "  }); //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "fn _main() { //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    ()
and method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and method2 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method3()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method3()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method3()
    let v45 : string = "$0.unwrap_or($1)"
    let v46 : string = Fable.Core.RustInterop.emitRustExpr struct (v43, v44) v45 
    let _v1 = v46 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v47 : string = "process.env[$0] ?? \"\""
    let v48 : string = Fable.Core.JsInterop.emitJsExpr v0 v47 
    let _v1 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : string = "os"
    let v50 : IOsEnviron = Fable.Core.PyInterop.importAll v49 
    let v51 : string = "v50.environ"
    let v52 : obj = Fable.Core.PyInterop.emitPyExpr () v51 
    let v55 : string = "v52.get($0)"
    let v56 : string = Fable.Core.PyInterop.emitPyExpr v0 v55 
    let mutable _v56 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v59 : (string -> string option) = Option.ofObj
    let v60 : string option = v59 v56
    v60 
    #else
    Some v56 
    #endif
    |> fun x -> _v56 <- Some x
    let v61 : string option = match _v56 with Some x -> x | None -> failwith "optionm'.of_obj / _v56=None"
    let v64 : US1 option = None
    let _v64 = ref v64 
    match v61 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v65 : string = x
    let v66 : US1 = US1_0(v65)
    v66 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v64.Value <- x
    let v67 : US1 option = _v64.Value 
    let v78 : US1 = US1_1
    let v79 : US1 = v67 |> Option.defaultValue v78 
    let v86 : string =
        match v79 with
        | US1_1 -> (* None *)
            let v84 : string = ""
            v84
        | US1_0(v83) -> (* Some *)
            v83
    let _v1 = v86 
    #endif
#else
    let v87 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v88 : string = v87 v0
    let mutable _v88 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v88
    v90 
    #else
    Some v88 
    #endif
    |> fun x -> _v88 <- Some x
    let v91 : string option = match _v88 with Some x -> x | None -> failwith "optionm'.of_obj / _v88=None"
    let v94 : US1 option = None
    let _v94 = ref v94 
    match v91 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v95 : string = x
    let v96 : US1 = US1_0(v95)
    v96 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v94.Value <- x
    let v97 : US1 option = _v94.Value 
    let v108 : US1 = US1_1
    let v109 : US1 = v97 |> Option.defaultValue v108 
    let v116 : string =
        match v109 with
        | US1_1 -> (* None *)
            let v114 : string = ""
            v114
        | US1_0(v113) -> (* Some *)
            v113
    let _v1 = v116 
    #endif
    let v117 : string = _v1 
    v117
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure2 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method1()
    let v3 : string = method2(v2)
    let v4 : bool = "Verbose" = v3
    let v8 : US2 =
        if v4 then
            let v5 : US0 = US0_0
            US2_0(v5)
        else
            US2_1
    let v49 : US2 =
        match v8 with
        | US2_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US2 =
                if v11 then
                    let v12 : US0 = US0_1
                    US2_0(v12)
                else
                    US2_1
            match v15 with
            | US2_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US2 =
                    if v18 then
                        let v19 : US0 = US0_2
                        US2_0(v19)
                    else
                        US2_1
                match v22 with
                | US2_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US2 =
                        if v25 then
                            let v26 : US0 = US0_3
                            US2_0(v26)
                        else
                            US2_1
                    match v29 with
                    | US2_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US2 =
                            if v32 then
                                let v33 : US0 = US0_4
                                US2_0(v33)
                            else
                                US2_1
                        match v36 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v37) -> (* Some *)
                            US2_0(v37)
                    | US2_0(v30) -> (* Some *)
                        US2_0(v30)
                | US2_0(v23) -> (* Some *)
                    US2_0(v23)
            | US2_0(v16) -> (* Some *)
                US2_0(v16)
        | US2_0(v9) -> (* Some *)
            US2_0(v9)
    let v50 : string = method4()
    let v51 : string = method2(v50)
    let v52 : bool = v51 = "True"
    let v62 : US3 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US3_0(v57)
        else
            US3_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US2 = US2_1
    let v64 : US3 = US3_1
    let _v1 = struct (v63, v64) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v65 : string = "AUTOMATION"
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "env!(\"" + v65 + "\")"
    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "String::from($0)"
    let v70 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let v71 : string = "fable_library_rust::String_::fromString($0)"
    let v72 : string = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v73 : string = "env!(\"" + v65 + "\")"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : string = "String::from($0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v74 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let _v66 = v78 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v79 : string = "env!(\"" + v65 + "\")"
    let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79 
    let v81 : string = "String::from($0)"
    let v82 : std_string_String = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "fable_library_rust::String_::fromString($0)"
    let v84 : string = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let _v66 = v84 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : string = null |> unbox<string>
    let _v66 = v85 
    #endif
#if FABLE_COMPILER_PYTHON
    let v88 : string = null |> unbox<string>
    let _v66 = v88 
    #endif
#else
    let v91 : string = null |> unbox<string>
    let _v66 = v91 
    #endif
    let v94 : string = _v66 
    let v99 : string = "True"
    let v100 : bool = v94 <> v99 
    let v109 : US3 =
        if v100 then
            US3_1
        else
            let v104 : string = $"near_sdk::env::block_timestamp()"
            let v105 : uint64 = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : (uint64 -> int64) = int64
            let v107 : int64 = v106 v105
            US3_0(v107)
    let v110 : US2 = US2_1
    let _v1 = struct (v110, v109) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : string = method1()
    let v112 : string = method2(v111)
    let v113 : bool = "Verbose" = v112
    let v117 : US2 =
        if v113 then
            let v114 : US0 = US0_0
            US2_0(v114)
        else
            US2_1
    let v158 : US2 =
        match v117 with
        | US2_1 -> (* None *)
            let v120 : bool = "Debug" = v112
            let v124 : US2 =
                if v120 then
                    let v121 : US0 = US0_1
                    US2_0(v121)
                else
                    US2_1
            match v124 with
            | US2_1 -> (* None *)
                let v127 : bool = "Info" = v112
                let v131 : US2 =
                    if v127 then
                        let v128 : US0 = US0_2
                        US2_0(v128)
                    else
                        US2_1
                match v131 with
                | US2_1 -> (* None *)
                    let v134 : bool = "Warning" = v112
                    let v138 : US2 =
                        if v134 then
                            let v135 : US0 = US0_3
                            US2_0(v135)
                        else
                            US2_1
                    match v138 with
                    | US2_1 -> (* None *)
                        let v141 : bool = "Critical" = v112
                        let v145 : US2 =
                            if v141 then
                                let v142 : US0 = US0_4
                                US2_0(v142)
                            else
                                US2_1
                        match v145 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v146) -> (* Some *)
                            US2_0(v146)
                    | US2_0(v139) -> (* Some *)
                        US2_0(v139)
                | US2_0(v132) -> (* Some *)
                    US2_0(v132)
            | US2_0(v125) -> (* Some *)
                US2_0(v125)
        | US2_0(v118) -> (* Some *)
            US2_0(v118)
    let v159 : string = method4()
    let v160 : string = method2(v159)
    let v161 : bool = v160 = "True"
    let v171 : US3 =
        if v161 then
            let v162 : System.DateTime = System.DateTime.Now
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v162
            US3_0(v166)
        else
            US3_1
    let _v1 = struct (v158, v171) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : string = method1()
    let v173 : string = method2(v172)
    let v174 : bool = "Verbose" = v173
    let v178 : US2 =
        if v174 then
            let v175 : US0 = US0_0
            US2_0(v175)
        else
            US2_1
    let v219 : US2 =
        match v178 with
        | US2_1 -> (* None *)
            let v181 : bool = "Debug" = v173
            let v185 : US2 =
                if v181 then
                    let v182 : US0 = US0_1
                    US2_0(v182)
                else
                    US2_1
            match v185 with
            | US2_1 -> (* None *)
                let v188 : bool = "Info" = v173
                let v192 : US2 =
                    if v188 then
                        let v189 : US0 = US0_2
                        US2_0(v189)
                    else
                        US2_1
                match v192 with
                | US2_1 -> (* None *)
                    let v195 : bool = "Warning" = v173
                    let v199 : US2 =
                        if v195 then
                            let v196 : US0 = US0_3
                            US2_0(v196)
                        else
                            US2_1
                    match v199 with
                    | US2_1 -> (* None *)
                        let v202 : bool = "Critical" = v173
                        let v206 : US2 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US2_0(v203)
                            else
                                US2_1
                        match v206 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v207) -> (* Some *)
                            US2_0(v207)
                    | US2_0(v200) -> (* Some *)
                        US2_0(v200)
                | US2_0(v193) -> (* Some *)
                    US2_0(v193)
            | US2_0(v186) -> (* Some *)
                US2_0(v186)
        | US2_0(v179) -> (* Some *)
            US2_0(v179)
    let v220 : string = method4()
    let v221 : string = method2(v220)
    let v222 : bool = v221 = "True"
    let v232 : US3 =
        if v222 then
            let v223 : System.DateTime = System.DateTime.Now
            let v226 : (System.DateTime -> int64) = _.Ticks
            let v227 : int64 = v226 v223
            US3_0(v227)
        else
            US3_1
    let _v1 = struct (v219, v232) 
    #endif
#else
    let v233 : string = method1()
    let v234 : string = method2(v233)
    let v235 : bool = "Verbose" = v234
    let v239 : US2 =
        if v235 then
            let v236 : US0 = US0_0
            US2_0(v236)
        else
            US2_1
    let v280 : US2 =
        match v239 with
        | US2_1 -> (* None *)
            let v242 : bool = "Debug" = v234
            let v246 : US2 =
                if v242 then
                    let v243 : US0 = US0_1
                    US2_0(v243)
                else
                    US2_1
            match v246 with
            | US2_1 -> (* None *)
                let v249 : bool = "Info" = v234
                let v253 : US2 =
                    if v249 then
                        let v250 : US0 = US0_2
                        US2_0(v250)
                    else
                        US2_1
                match v253 with
                | US2_1 -> (* None *)
                    let v256 : bool = "Warning" = v234
                    let v260 : US2 =
                        if v256 then
                            let v257 : US0 = US0_3
                            US2_0(v257)
                        else
                            US2_1
                    match v260 with
                    | US2_1 -> (* None *)
                        let v263 : bool = "Critical" = v234
                        let v267 : US2 =
                            if v263 then
                                let v264 : US0 = US0_4
                                US2_0(v264)
                            else
                                US2_1
                        match v267 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v268) -> (* Some *)
                            US2_0(v268)
                    | US2_0(v261) -> (* Some *)
                        US2_0(v261)
                | US2_0(v254) -> (* Some *)
                    US2_0(v254)
            | US2_0(v247) -> (* Some *)
                US2_0(v247)
        | US2_0(v240) -> (* Some *)
            US2_0(v240)
    let v281 : string = method4()
    let v282 : string = method2(v281)
    let v283 : bool = v282 = "True"
    let v293 : US3 =
        if v283 then
            let v284 : System.DateTime = System.DateTime.Now
            let v287 : (System.DateTime -> int64) = _.Ticks
            let v288 : int64 = v287 v284
            US3_0(v288)
        else
            US3_1
    let _v1 = struct (v280, v293) 
    #endif
    let struct (v294 : US2, v295 : US3) = _v1 
    let v359 : Mut2 = {l0 = true} : Mut2
    let v360 : Mut0 = {l0 = 0L} : Mut0
    let v363 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v361) -> (* Some *)
            v361
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v365 : (string -> unit) = closure2()
    let v366 : Mut1 = {l0 = v365} : Mut1
    let v373 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v371 : int64 option = None
            v371
        | US3_0(v367) -> (* Some *)
            let v368 : int64 option = Some v367 
            v368
    struct (v360, v366, v359, v364, v373)
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method8 () : string =
    let v0 : string = ""
    v0
and closure3 () () : string =
    let v0 : string = $"spiral_wasm.main"
    v0
and method9 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "wasm"
    let v6 : string = "r#\"" + v5 + "\"#"
    let v7 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "clap::Arg::new($0)"
    let v9 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "$0.short($1)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v9, 'w') v10 
    let v12 : string = "r#\"" + v5 + "\"#"
    let v13 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "$0.long($1)"
    let v15 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, v13) v14 
    let v16 : string = "$0.required($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v15, true) v16 
    let v18 : string = "clap::Command::arg($0, $1)"
    let v19 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v4, v17) v18 
    v19
and method11 () : string =
    let v0 : string = "wasm"
    v0
and closure4 () () : string =
    let v0 : string = "run"
    v0
and closure5 () () : string =
    let v0 : string = ""
    v0
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure7 () () : string =
    let v0 : string = ""
    v0
and closure8 () (v0 : std_string_String) : unit =
    v0 |> System.Console.WriteLine
    ()
and closure9 () () : string =
    let v0 : string = ""
    v0
and method12 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and closure10 () () : string =
    let v0 : string = ""
    v0
and method13 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and closure11 () () : string =
    let v0 : string = ""
    v0
and closure12 () () : string =
    let v0 : string = ""
    v0
and closure13 () () : string =
    let v0 : string = ""
    v0
and method14 (v0 : Result<unit, anyhow_Error>) : Result<unit, anyhow_Error> =
    v0
and method10 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = method11()
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "clap::ArgMatches::get_one(&$0, v4).cloned()"
    let v6 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let v7 : US4 option = None
    let _v7 = ref v7 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v8 : std_string_String = x
    let v9 : US4 = US4_0(v8)
    v9 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v7.Value <- x
    let v10 : US4 option = _v7.Value 
    let v21 : US4 = US4_1
    let v22 : US4 = v10 |> Option.defaultValue v21 
    let v29 : std_string_String =
        match v22 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v26) -> (* Some *)
            v26
    let v30 : string = "fable_library_rust::String_::fromString($0)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : bool = State.trace_state.IsNone
    if v32 then
        let v33 : US0 = US0_0
        let struct (v34 : Mut0, v35 : Mut1, v36 : Mut2, v37 : Mut3, v38 : int64 option) = method0(v33)
        let v39 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v34, v35, v36, v37, v38) 
        State.trace_state <- v39 
        ()
    let struct (v44 : Mut0, v45 : Mut1, v46 : Mut2, v47 : Mut3, v48 : int64 option) = State.trace_state.Value
    let v59 : bool = State.trace_state.IsNone
    if v59 then
        let v60 : US0 = US0_0
        let struct (v61 : Mut0, v62 : Mut1, v63 : Mut2, v64 : Mut3, v65 : int64 option) = method0(v60)
        let v66 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v61, v62, v63, v64, v65) 
        State.trace_state <- v66 
        ()
    let struct (v71 : Mut0, v72 : Mut1, v73 : Mut2, v74 : Mut3, v75 : int64 option) = State.trace_state.Value
    let v86 : US0 = v74.l0
    let v87 : bool = v73.l0
    let v88 : bool = v87 = false
    let v91 : bool =
        if v88 then
            false
        else
            let v89 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v86
            let v90 : bool = 1 >= v89
            v90
    if v91 then
        let v92 : int64 = v44.l0
        let v93 : int64 = v92 + 1L
        v44.l0 <- v93
        let v94 : bool = State.trace_state.IsNone
        if v94 then
            let v95 : US0 = US0_0
            let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : int64 option) = method0(v95)
            let v101 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v96, v97, v98, v99, v100) 
            State.trace_state <- v101 
            ()
        let struct (v106 : Mut0, v107 : Mut1, v108 : Mut2, v109 : Mut3, v110 : int64 option) = State.trace_state.Value
        let v121 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v122 : US3 option = None
        let _v122 = ref v122 
        match v110 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v123 : int64 = x
        let v124 : US3 = US3_0(v123)
        v124 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v122.Value <- x
        let v125 : US3 option = _v122.Value 
        let v136 : US3 = US3_1
        let v137 : US3 = v125 |> Option.defaultValue v136 
        let v177 : System.DateTime =
            match v137 with
            | US3_1 -> (* None *)
                let v173 : System.DateTime = System.DateTime.Now
                v173
            | US3_0(v141) -> (* Some *)
                let v142 : System.DateTime = System.DateTime.Now
                let v145 : (System.DateTime -> int64) = _.Ticks
                let v146 : int64 = v145 v142
                let v149 : int64 = v146 - v141
                let v150 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v151 : System.TimeSpan = v150 v149
                let v154 : (System.TimeSpan -> int32) = _.Hours
                let v155 : int32 = v154 v151
                let v158 : (System.TimeSpan -> int32) = _.Minutes
                let v159 : int32 = v158 v151
                let v162 : (System.TimeSpan -> int32) = _.Seconds
                let v163 : int32 = v162 v151
                let v166 : (System.TimeSpan -> int32) = _.Milliseconds
                let v167 : int32 = v166 v151
                let v170 : System.DateTime = System.DateTime (1, 1, 1, v155, v159, v163, v167)
                v170
        let v178 : string = method5()
        let v181 : (string -> string) = v177.ToString
        let v182 : string = v181 v178
        let _v121 = v182 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v185 : US3 option = None
        let _v185 = ref v185 
        match v110 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v186 : int64 = x
        let v187 : US3 = US3_0(v186)
        v187 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v185.Value <- x
        let v188 : US3 option = _v185.Value 
        let v199 : US3 = US3_1
        let v200 : US3 = v188 |> Option.defaultValue v199 
        let v240 : System.DateTime =
            match v200 with
            | US3_1 -> (* None *)
                let v236 : System.DateTime = System.DateTime.Now
                v236
            | US3_0(v204) -> (* Some *)
                let v205 : System.DateTime = System.DateTime.Now
                let v208 : (System.DateTime -> int64) = _.Ticks
                let v209 : int64 = v208 v205
                let v212 : int64 = v209 - v204
                let v213 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v214 : System.TimeSpan = v213 v212
                let v217 : (System.TimeSpan -> int32) = _.Hours
                let v218 : int32 = v217 v214
                let v221 : (System.TimeSpan -> int32) = _.Minutes
                let v222 : int32 = v221 v214
                let v225 : (System.TimeSpan -> int32) = _.Seconds
                let v226 : int32 = v225 v214
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v214
                let v233 : System.DateTime = System.DateTime (1, 1, 1, v218, v222, v226, v230)
                v233
        let v241 : string = method5()
        let v244 : (string -> string) = v240.ToString
        let v245 : string = v244 v241
        let _v121 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        match v110 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v251 : int64 = x
        let v252 : US3 = US3_0(v251)
        v252 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v250.Value <- x
        let v253 : US3 option = _v250.Value 
        let v264 : US3 = US3_1
        let v265 : US3 = v253 |> Option.defaultValue v264 
        let v274 : uint64 =
            match v265 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v269) -> (* Some *)
                let v270 : (int64 -> uint64) = uint64
                let v271 : uint64 = v270 v269
                let v272 : uint64 = v249 - v271
                v272
        let v275 : uint64 = v274 / 1000000000UL
        let v276 : uint64 = v275 % 60UL
        let v277 : uint64 = v275 / 60UL
        let v278 : uint64 = v277 % 60UL
        let v279 : uint64 = v275 / 3600UL
        let v280 : uint64 = v279 % 24UL
        let v281 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v282 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v280, v278, v276) v281 
        let v283 : string = "fable_library_rust::String_::fromString($0)"
        let v284 : string = Fable.Core.RustInterop.emitRustExpr v282 v283 
        let _v121 = v284 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v285 : US3 option = None
        let _v285 = ref v285 
        match v110 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v286 : int64 = x
        let v287 : US3 = US3_0(v286)
        v287 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v285.Value <- x
        let v288 : US3 option = _v285.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
                let v305 : System.DateTime = System.DateTime.Now
                let v308 : (System.DateTime -> int64) = _.Ticks
                let v309 : int64 = v308 v305
                let v312 : int64 = v309 - v304
                let v313 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v314 : System.TimeSpan = v313 v312
                let v317 : (System.TimeSpan -> int32) = _.Hours
                let v318 : int32 = v317 v314
                let v321 : (System.TimeSpan -> int32) = _.Minutes
                let v322 : int32 = v321 v314
                let v325 : (System.TimeSpan -> int32) = _.Seconds
                let v326 : int32 = v325 v314
                let v329 : (System.TimeSpan -> int32) = _.Milliseconds
                let v330 : int32 = v329 v314
                let v333 : System.DateTime = System.DateTime (1, 1, 1, v318, v322, v326, v330)
                v333
        let v341 : string = method6()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v121 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        match v110 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v349 : int64 = x
        let v350 : US3 = US3_0(v349)
        v350 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v348.Value <- x
        let v351 : US3 option = _v348.Value 
        let v362 : US3 = US3_1
        let v363 : US3 = v351 |> Option.defaultValue v362 
        let v403 : System.DateTime =
            match v363 with
            | US3_1 -> (* None *)
                let v399 : System.DateTime = System.DateTime.Now
                v399
            | US3_0(v367) -> (* Some *)
                let v368 : System.DateTime = System.DateTime.Now
                let v371 : (System.DateTime -> int64) = _.Ticks
                let v372 : int64 = v371 v368
                let v375 : int64 = v372 - v367
                let v376 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v377 : System.TimeSpan = v376 v375
                let v380 : (System.TimeSpan -> int32) = _.Hours
                let v381 : int32 = v380 v377
                let v384 : (System.TimeSpan -> int32) = _.Minutes
                let v385 : int32 = v384 v377
                let v388 : (System.TimeSpan -> int32) = _.Seconds
                let v389 : int32 = v388 v377
                let v392 : (System.TimeSpan -> int32) = _.Milliseconds
                let v393 : int32 = v392 v377
                let v396 : System.DateTime = System.DateTime (1, 1, 1, v381, v385, v389, v393)
                v396
        let v404 : string = method6()
        let v407 : (string -> string) = v403.ToString
        let v408 : string = v407 v404
        let _v121 = v408 
        #endif
#else
        let v411 : US3 option = None
        let _v411 = ref v411 
        match v110 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v412 : int64 = x
        let v413 : US3 = US3_0(v412)
        v413 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v411.Value <- x
        let v414 : US3 option = _v411.Value 
        let v425 : US3 = US3_1
        let v426 : US3 = v414 |> Option.defaultValue v425 
        let v466 : System.DateTime =
            match v426 with
            | US3_1 -> (* None *)
                let v462 : System.DateTime = System.DateTime.Now
                v462
            | US3_0(v430) -> (* Some *)
                let v431 : System.DateTime = System.DateTime.Now
                let v434 : (System.DateTime -> int64) = _.Ticks
                let v435 : int64 = v434 v431
                let v438 : int64 = v435 - v430
                let v439 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v440 : System.TimeSpan = v439 v438
                let v443 : (System.TimeSpan -> int32) = _.Hours
                let v444 : int32 = v443 v440
                let v447 : (System.TimeSpan -> int32) = _.Minutes
                let v448 : int32 = v447 v440
                let v451 : (System.TimeSpan -> int32) = _.Seconds
                let v452 : int32 = v451 v440
                let v455 : (System.TimeSpan -> int32) = _.Milliseconds
                let v456 : int32 = v455 v440
                let v459 : System.DateTime = System.DateTime (1, 1, 1, v444, v448, v452, v456)
                v459
        let v467 : string = method6()
        let v470 : (string -> string) = v466.ToString
        let v471 : string = v470 v467
        let _v121 = v471 
        #endif
        let v474 : string = _v121 
        let v539 : string = "Debug"
        let v540 : (unit -> string) = v539.ToLower
        let v541 : string = v540 ()
        let v544 : string = v541.PadLeft (7, ' ')
        let v558 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v559 : string = "inline_colorization::color_bright_blue"
        let v560 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v559 
        let v561 : string = "&*$0"
        let v562 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v544 v561 
        let v563 : string = "inline_colorization::color_reset"
        let v564 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v563 
        let v565 : string = "\"{v560}{v562}{v564}\""
        let v566 : string = @$"format!(" + v565 + ")"
        let v567 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v566 
        let v568 : string = "fable_library_rust::String_::fromString($0)"
        let v569 : string = Fable.Core.RustInterop.emitRustExpr v567 v568 
        let _v558 = v569 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v570 : string = "inline_colorization::color_bright_blue"
        let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v570 
        let v572 : string = "&*$0"
        let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v544 v572 
        let v574 : string = "inline_colorization::color_reset"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "\"{v571}{v573}{v575}\""
        let v577 : string = @$"format!(" + v576 + ")"
        let v578 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "fable_library_rust::String_::fromString($0)"
        let v580 : string = Fable.Core.RustInterop.emitRustExpr v578 v579 
        let _v558 = v580 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v581 : string = "inline_colorization::color_bright_blue"
        let v582 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "&*$0"
        let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v544 v583 
        let v585 : string = "inline_colorization::color_reset"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "\"{v582}{v584}{v586}\""
        let v588 : string = @$"format!(" + v587 + ")"
        let v589 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "fable_library_rust::String_::fromString($0)"
        let v591 : string = Fable.Core.RustInterop.emitRustExpr v589 v590 
        let _v558 = v591 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v592 : string = "\u001b[94m"
        let v593 : string = method7()
        let v594 : string = v592 + v544 
        let v595 : string = v594 + v593 
        let _v558 = v595 
        #endif
#if FABLE_COMPILER_PYTHON
        let v596 : string = "\u001b[94m"
        let v597 : string = method7()
        let v598 : string = v596 + v544 
        let v599 : string = v598 + v597 
        let _v558 = v599 
        #endif
#else
        let v600 : string = "\u001b[94m"
        let v601 : string = method7()
        let v602 : string = v600 + v544 
        let v603 : string = v602 + v601 
        let _v558 = v603 
        #endif
        let v604 : string = _v558 
        let v610 : int64 = v106.l0
        let v611 : string = method8()
        let v612 : Mut4 = {l0 = v611} : Mut4
        let v613 : string = "{ "
        let v614 : string = $"{v613}"
        let v617 : string = v612.l0
        let v618 : string = v617 + v614 
        v612.l0 <- v618
        let v619 : string = "wasm_path"
        let v620 : string = $"{v619}"
        let v623 : string = v612.l0
        let v624 : string = v623 + v620 
        v612.l0 <- v624
        let v625 : string = " = "
        let v626 : string = $"{v625}"
        let v629 : string = v612.l0
        let v630 : string = v629 + v626 
        v612.l0 <- v630
        let v631 : string = $"{v31}"
        let v634 : string = v612.l0
        let v635 : string = v634 + v631 
        v612.l0 <- v635
        let v636 : string = " }"
        let v637 : string = $"{v636}"
        let v640 : string = v612.l0
        let v641 : string = v640 + v637 
        v612.l0 <- v641
        let v642 : string = v612.l0
        let v643 : (unit -> string) = closure4()
        let v644 : string = $"{v474} {v604} #{v610} %s{v643 ()} / {v642}"
        let v647 : char list = []
        let v648 : (char list -> (char [])) = List.toArray
        let v649 : (char []) = v648 v647
        let v652 : string = v644.TrimStart v649 
        let v670 : char list = []
        let v671 : char list = '/' :: v670 
        let v674 : char list = ' ' :: v671 
        let v677 : (char list -> (char [])) = List.toArray
        let v678 : (char []) = v677 v674
        let v681 : string = v652.TrimEnd v678 
        let v699 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v700 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v681 v700 
        let _v699 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v701 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v681 v701 
        let _v699 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v702 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v681 v702 
        let _v699 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v681 
        let _v699 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v681 
        let _v699 = () 
        #endif
#else
        System.Console.WriteLine v681 
        let _v699 = () 
        #endif
        _v699 
        let v703 : (string -> unit) = v45.l0
        v703 v681
    let v704 : string = "std::fs::read(&*$0)"
    let v705 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v31 v704 
    let v706 : string = "$0?"
    let v707 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v705 v706 
    let v708 : string = "near_workspaces::sandbox().await"
    let v709 : Result<near_workspaces_Worker<near_workspaces_network_Sandbox>, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v708 
    let v710 : string = "$0?"
    let v711 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v709 v710 
    let v712 : bool = State.trace_state.IsNone
    if v712 then
        let v713 : US0 = US0_0
        let struct (v714 : Mut0, v715 : Mut1, v716 : Mut2, v717 : Mut3, v718 : int64 option) = method0(v713)
        let v719 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v714, v715, v716, v717, v718) 
        State.trace_state <- v719 
        ()
    let struct (v724 : Mut0, v725 : Mut1, v726 : Mut2, v727 : Mut3, v728 : int64 option) = State.trace_state.Value
    let v739 : bool = State.trace_state.IsNone
    if v739 then
        let v740 : US0 = US0_0
        let struct (v741 : Mut0, v742 : Mut1, v743 : Mut2, v744 : Mut3, v745 : int64 option) = method0(v740)
        let v746 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v741, v742, v743, v744, v745) 
        State.trace_state <- v746 
        ()
    let struct (v751 : Mut0, v752 : Mut1, v753 : Mut2, v754 : Mut3, v755 : int64 option) = State.trace_state.Value
    let v766 : US0 = v754.l0
    let v767 : bool = v753.l0
    let v768 : bool = v767 = false
    let v771 : bool =
        if v768 then
            false
        else
            let v769 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v766
            let v770 : bool = 1 >= v769
            v770
    if v771 then
        let v772 : int64 = v724.l0
        let v773 : int64 = v772 + 1L
        v724.l0 <- v773
        let v774 : bool = State.trace_state.IsNone
        if v774 then
            let v775 : US0 = US0_0
            let struct (v776 : Mut0, v777 : Mut1, v778 : Mut2, v779 : Mut3, v780 : int64 option) = method0(v775)
            let v781 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v776, v777, v778, v779, v780) 
            State.trace_state <- v781 
            ()
        let struct (v786 : Mut0, v787 : Mut1, v788 : Mut2, v789 : Mut3, v790 : int64 option) = State.trace_state.Value
        let v801 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v802 : US3 option = None
        let _v802 = ref v802 
        match v790 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v803 : int64 = x
        let v804 : US3 = US3_0(v803)
        v804 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v802.Value <- x
        let v805 : US3 option = _v802.Value 
        let v816 : US3 = US3_1
        let v817 : US3 = v805 |> Option.defaultValue v816 
        let v857 : System.DateTime =
            match v817 with
            | US3_1 -> (* None *)
                let v853 : System.DateTime = System.DateTime.Now
                v853
            | US3_0(v821) -> (* Some *)
                let v822 : System.DateTime = System.DateTime.Now
                let v825 : (System.DateTime -> int64) = _.Ticks
                let v826 : int64 = v825 v822
                let v829 : int64 = v826 - v821
                let v830 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v831 : System.TimeSpan = v830 v829
                let v834 : (System.TimeSpan -> int32) = _.Hours
                let v835 : int32 = v834 v831
                let v838 : (System.TimeSpan -> int32) = _.Minutes
                let v839 : int32 = v838 v831
                let v842 : (System.TimeSpan -> int32) = _.Seconds
                let v843 : int32 = v842 v831
                let v846 : (System.TimeSpan -> int32) = _.Milliseconds
                let v847 : int32 = v846 v831
                let v850 : System.DateTime = System.DateTime (1, 1, 1, v835, v839, v843, v847)
                v850
        let v858 : string = method5()
        let v861 : (string -> string) = v857.ToString
        let v862 : string = v861 v858
        let _v801 = v862 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v865 : US3 option = None
        let _v865 = ref v865 
        match v790 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v866 : int64 = x
        let v867 : US3 = US3_0(v866)
        v867 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v865.Value <- x
        let v868 : US3 option = _v865.Value 
        let v879 : US3 = US3_1
        let v880 : US3 = v868 |> Option.defaultValue v879 
        let v920 : System.DateTime =
            match v880 with
            | US3_1 -> (* None *)
                let v916 : System.DateTime = System.DateTime.Now
                v916
            | US3_0(v884) -> (* Some *)
                let v885 : System.DateTime = System.DateTime.Now
                let v888 : (System.DateTime -> int64) = _.Ticks
                let v889 : int64 = v888 v885
                let v892 : int64 = v889 - v884
                let v893 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v894 : System.TimeSpan = v893 v892
                let v897 : (System.TimeSpan -> int32) = _.Hours
                let v898 : int32 = v897 v894
                let v901 : (System.TimeSpan -> int32) = _.Minutes
                let v902 : int32 = v901 v894
                let v905 : (System.TimeSpan -> int32) = _.Seconds
                let v906 : int32 = v905 v894
                let v909 : (System.TimeSpan -> int32) = _.Milliseconds
                let v910 : int32 = v909 v894
                let v913 : System.DateTime = System.DateTime (1, 1, 1, v898, v902, v906, v910)
                v913
        let v921 : string = method5()
        let v924 : (string -> string) = v920.ToString
        let v925 : string = v924 v921
        let _v801 = v925 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v928 : string = $"near_sdk::env::block_timestamp()"
        let v929 : uint64 = Fable.Core.RustInterop.emitRustExpr () v928 
        let v930 : US3 option = None
        let _v930 = ref v930 
        match v790 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v931 : int64 = x
        let v932 : US3 = US3_0(v931)
        v932 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v930.Value <- x
        let v933 : US3 option = _v930.Value 
        let v944 : US3 = US3_1
        let v945 : US3 = v933 |> Option.defaultValue v944 
        let v954 : uint64 =
            match v945 with
            | US3_1 -> (* None *)
                v929
            | US3_0(v949) -> (* Some *)
                let v950 : (int64 -> uint64) = uint64
                let v951 : uint64 = v950 v949
                let v952 : uint64 = v929 - v951
                v952
        let v955 : uint64 = v954 / 1000000000UL
        let v956 : uint64 = v955 % 60UL
        let v957 : uint64 = v955 / 60UL
        let v958 : uint64 = v957 % 60UL
        let v959 : uint64 = v955 / 3600UL
        let v960 : uint64 = v959 % 24UL
        let v961 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v962 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v960, v958, v956) v961 
        let v963 : string = "fable_library_rust::String_::fromString($0)"
        let v964 : string = Fable.Core.RustInterop.emitRustExpr v962 v963 
        let _v801 = v964 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v965 : US3 option = None
        let _v965 = ref v965 
        match v790 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v966 : int64 = x
        let v967 : US3 = US3_0(v966)
        v967 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v965.Value <- x
        let v968 : US3 option = _v965.Value 
        let v979 : US3 = US3_1
        let v980 : US3 = v968 |> Option.defaultValue v979 
        let v1020 : System.DateTime =
            match v980 with
            | US3_1 -> (* None *)
                let v1016 : System.DateTime = System.DateTime.Now
                v1016
            | US3_0(v984) -> (* Some *)
                let v985 : System.DateTime = System.DateTime.Now
                let v988 : (System.DateTime -> int64) = _.Ticks
                let v989 : int64 = v988 v985
                let v992 : int64 = v989 - v984
                let v993 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v994 : System.TimeSpan = v993 v992
                let v997 : (System.TimeSpan -> int32) = _.Hours
                let v998 : int32 = v997 v994
                let v1001 : (System.TimeSpan -> int32) = _.Minutes
                let v1002 : int32 = v1001 v994
                let v1005 : (System.TimeSpan -> int32) = _.Seconds
                let v1006 : int32 = v1005 v994
                let v1009 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1010 : int32 = v1009 v994
                let v1013 : System.DateTime = System.DateTime (1, 1, 1, v998, v1002, v1006, v1010)
                v1013
        let v1021 : string = method6()
        let v1024 : (string -> string) = v1020.ToString
        let v1025 : string = v1024 v1021
        let _v801 = v1025 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1028 : US3 option = None
        let _v1028 = ref v1028 
        match v790 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1029 : int64 = x
        let v1030 : US3 = US3_0(v1029)
        v1030 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1028.Value <- x
        let v1031 : US3 option = _v1028.Value 
        let v1042 : US3 = US3_1
        let v1043 : US3 = v1031 |> Option.defaultValue v1042 
        let v1083 : System.DateTime =
            match v1043 with
            | US3_1 -> (* None *)
                let v1079 : System.DateTime = System.DateTime.Now
                v1079
            | US3_0(v1047) -> (* Some *)
                let v1048 : System.DateTime = System.DateTime.Now
                let v1051 : (System.DateTime -> int64) = _.Ticks
                let v1052 : int64 = v1051 v1048
                let v1055 : int64 = v1052 - v1047
                let v1056 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1057 : System.TimeSpan = v1056 v1055
                let v1060 : (System.TimeSpan -> int32) = _.Hours
                let v1061 : int32 = v1060 v1057
                let v1064 : (System.TimeSpan -> int32) = _.Minutes
                let v1065 : int32 = v1064 v1057
                let v1068 : (System.TimeSpan -> int32) = _.Seconds
                let v1069 : int32 = v1068 v1057
                let v1072 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1073 : int32 = v1072 v1057
                let v1076 : System.DateTime = System.DateTime (1, 1, 1, v1061, v1065, v1069, v1073)
                v1076
        let v1084 : string = method6()
        let v1087 : (string -> string) = v1083.ToString
        let v1088 : string = v1087 v1084
        let _v801 = v1088 
        #endif
#else
        let v1091 : US3 option = None
        let _v1091 = ref v1091 
        match v790 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1092 : int64 = x
        let v1093 : US3 = US3_0(v1092)
        v1093 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1091.Value <- x
        let v1094 : US3 option = _v1091.Value 
        let v1105 : US3 = US3_1
        let v1106 : US3 = v1094 |> Option.defaultValue v1105 
        let v1146 : System.DateTime =
            match v1106 with
            | US3_1 -> (* None *)
                let v1142 : System.DateTime = System.DateTime.Now
                v1142
            | US3_0(v1110) -> (* Some *)
                let v1111 : System.DateTime = System.DateTime.Now
                let v1114 : (System.DateTime -> int64) = _.Ticks
                let v1115 : int64 = v1114 v1111
                let v1118 : int64 = v1115 - v1110
                let v1119 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1120 : System.TimeSpan = v1119 v1118
                let v1123 : (System.TimeSpan -> int32) = _.Hours
                let v1124 : int32 = v1123 v1120
                let v1127 : (System.TimeSpan -> int32) = _.Minutes
                let v1128 : int32 = v1127 v1120
                let v1131 : (System.TimeSpan -> int32) = _.Seconds
                let v1132 : int32 = v1131 v1120
                let v1135 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1136 : int32 = v1135 v1120
                let v1139 : System.DateTime = System.DateTime (1, 1, 1, v1124, v1128, v1132, v1136)
                v1139
        let v1147 : string = method6()
        let v1150 : (string -> string) = v1146.ToString
        let v1151 : string = v1150 v1147
        let _v801 = v1151 
        #endif
        let v1154 : string = _v801 
        let v1219 : string = "Debug"
        let v1220 : (unit -> string) = v1219.ToLower
        let v1221 : string = v1220 ()
        let v1224 : string = v1221.PadLeft (7, ' ')
        let v1238 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1239 : string = "inline_colorization::color_bright_blue"
        let v1240 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1239 
        let v1241 : string = "&*$0"
        let v1242 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1241 
        let v1243 : string = "inline_colorization::color_reset"
        let v1244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1243 
        let v1245 : string = "\"{v1240}{v1242}{v1244}\""
        let v1246 : string = @$"format!(" + v1245 + ")"
        let v1247 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1246 
        let v1248 : string = "fable_library_rust::String_::fromString($0)"
        let v1249 : string = Fable.Core.RustInterop.emitRustExpr v1247 v1248 
        let _v1238 = v1249 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1250 : string = "inline_colorization::color_bright_blue"
        let v1251 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1250 
        let v1252 : string = "&*$0"
        let v1253 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1252 
        let v1254 : string = "inline_colorization::color_reset"
        let v1255 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1254 
        let v1256 : string = "\"{v1251}{v1253}{v1255}\""
        let v1257 : string = @$"format!(" + v1256 + ")"
        let v1258 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1257 
        let v1259 : string = "fable_library_rust::String_::fromString($0)"
        let v1260 : string = Fable.Core.RustInterop.emitRustExpr v1258 v1259 
        let _v1238 = v1260 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1261 : string = "inline_colorization::color_bright_blue"
        let v1262 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1261 
        let v1263 : string = "&*$0"
        let v1264 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1224 v1263 
        let v1265 : string = "inline_colorization::color_reset"
        let v1266 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1265 
        let v1267 : string = "\"{v1262}{v1264}{v1266}\""
        let v1268 : string = @$"format!(" + v1267 + ")"
        let v1269 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1268 
        let v1270 : string = "fable_library_rust::String_::fromString($0)"
        let v1271 : string = Fable.Core.RustInterop.emitRustExpr v1269 v1270 
        let _v1238 = v1271 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1272 : string = "\u001b[94m"
        let v1273 : string = method7()
        let v1274 : string = v1272 + v1224 
        let v1275 : string = v1274 + v1273 
        let _v1238 = v1275 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1276 : string = "\u001b[94m"
        let v1277 : string = method7()
        let v1278 : string = v1276 + v1224 
        let v1279 : string = v1278 + v1277 
        let _v1238 = v1279 
        #endif
#else
        let v1280 : string = "\u001b[94m"
        let v1281 : string = method7()
        let v1282 : string = v1280 + v1224 
        let v1283 : string = v1282 + v1281 
        let _v1238 = v1283 
        #endif
        let v1284 : string = _v1238 
        let v1290 : int64 = v786.l0
        let v1291 : string = method8()
        let v1292 : Mut4 = {l0 = v1291} : Mut4
        let v1293 : string = "{ "
        let v1294 : string = $"{v1293}"
        let v1297 : string = v1292.l0
        let v1298 : string = v1297 + v1294 
        v1292.l0 <- v1298
        let v1299 : string = "worker"
        let v1300 : string = $"{v1299}"
        let v1303 : string = v1292.l0
        let v1304 : string = v1303 + v1300 
        v1292.l0 <- v1304
        let v1305 : string = " = "
        let v1306 : string = $"{v1305}"
        let v1309 : string = v1292.l0
        let v1310 : string = v1309 + v1306 
        v1292.l0 <- v1310
        let v1311 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1312 : string = "format!(\"{:#?}\", $0)"
        let v1313 : std_string_String = Fable.Core.RustInterop.emitRustExpr v711 v1312 
        let v1314 : string = "fable_library_rust::String_::fromString($0)"
        let v1315 : string = Fable.Core.RustInterop.emitRustExpr v1313 v1314 
        let _v1311 = v1315 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1316 : string = "format!(\"{:#?}\", $0)"
        let v1317 : std_string_String = Fable.Core.RustInterop.emitRustExpr v711 v1316 
        let v1318 : string = "fable_library_rust::String_::fromString($0)"
        let v1319 : string = Fable.Core.RustInterop.emitRustExpr v1317 v1318 
        let _v1311 = v1319 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1320 : string = "format!(\"{:#?}\", $0)"
        let v1321 : std_string_String = Fable.Core.RustInterop.emitRustExpr v711 v1320 
        let v1322 : string = "fable_library_rust::String_::fromString($0)"
        let v1323 : string = Fable.Core.RustInterop.emitRustExpr v1321 v1322 
        let _v1311 = v1323 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1324 : string = $"%A{v711}"
        let _v1311 = v1324 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1327 : string = $"%A{v711}"
        let _v1311 = v1327 
        #endif
#else
        let v1330 : string = $"%A{v711}"
        let _v1311 = v1330 
        #endif
        let v1333 : string = _v1311 
        let v1338 : string = $"{v1333}"
        let v1341 : string = v1292.l0
        let v1342 : string = v1341 + v1338 
        v1292.l0 <- v1342
        let v1343 : string = " }"
        let v1344 : string = $"{v1343}"
        let v1347 : string = v1292.l0
        let v1348 : string = v1347 + v1344 
        v1292.l0 <- v1348
        let v1349 : string = v1292.l0
        let v1350 : (unit -> string) = closure5()
        let v1351 : string = $"{v1154} {v1284} #{v1290} %s{v1350 ()} / {v1349}"
        let v1354 : char list = []
        let v1355 : (char list -> (char [])) = List.toArray
        let v1356 : (char []) = v1355 v1354
        let v1359 : string = v1351.TrimStart v1356 
        let v1377 : char list = []
        let v1378 : char list = '/' :: v1377 
        let v1381 : char list = ' ' :: v1378 
        let v1384 : (char list -> (char [])) = List.toArray
        let v1385 : (char []) = v1384 v1381
        let v1388 : string = v1359.TrimEnd v1385 
        let v1406 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1407 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1388 v1407 
        let _v1406 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1408 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1388 v1408 
        let _v1406 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1409 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1388 v1409 
        let _v1406 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1388 
        let _v1406 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1388 
        let _v1406 = () 
        #endif
#else
        System.Console.WriteLine v1388 
        let _v1406 = () 
        #endif
        _v1406 
        let v1410 : (string -> unit) = v725.l0
        v1410 v1388
    let v1411 : string = "Box::pin(v711.dev_deploy(&v707))"
    let v1412 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_Contract, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v1411 
    let v1413 : string = "v1412.await"
    let v1414 : Result<near_workspaces_Contract, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v1413 
    let v1415 : string = "$0?"
    let v1416 : near_workspaces_Contract = Fable.Core.RustInterop.emitRustExpr v1414 v1415 
    let v1417 : bool = State.trace_state.IsNone
    if v1417 then
        let v1418 : US0 = US0_0
        let struct (v1419 : Mut0, v1420 : Mut1, v1421 : Mut2, v1422 : Mut3, v1423 : int64 option) = method0(v1418)
        let v1424 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1419, v1420, v1421, v1422, v1423) 
        State.trace_state <- v1424 
        ()
    let struct (v1429 : Mut0, v1430 : Mut1, v1431 : Mut2, v1432 : Mut3, v1433 : int64 option) = State.trace_state.Value
    let v1444 : bool = State.trace_state.IsNone
    if v1444 then
        let v1445 : US0 = US0_0
        let struct (v1446 : Mut0, v1447 : Mut1, v1448 : Mut2, v1449 : Mut3, v1450 : int64 option) = method0(v1445)
        let v1451 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1446, v1447, v1448, v1449, v1450) 
        State.trace_state <- v1451 
        ()
    let struct (v1456 : Mut0, v1457 : Mut1, v1458 : Mut2, v1459 : Mut3, v1460 : int64 option) = State.trace_state.Value
    let v1471 : US0 = v1459.l0
    let v1472 : bool = v1458.l0
    let v1473 : bool = v1472 = false
    let v1476 : bool =
        if v1473 then
            false
        else
            let v1474 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1471
            let v1475 : bool = 1 >= v1474
            v1475
    if v1476 then
        let v1477 : int64 = v1429.l0
        let v1478 : int64 = v1477 + 1L
        v1429.l0 <- v1478
        let v1479 : bool = State.trace_state.IsNone
        if v1479 then
            let v1480 : US0 = US0_0
            let struct (v1481 : Mut0, v1482 : Mut1, v1483 : Mut2, v1484 : Mut3, v1485 : int64 option) = method0(v1480)
            let v1486 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1481, v1482, v1483, v1484, v1485) 
            State.trace_state <- v1486 
            ()
        let struct (v1491 : Mut0, v1492 : Mut1, v1493 : Mut2, v1494 : Mut3, v1495 : int64 option) = State.trace_state.Value
        let v1506 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1507 : US3 option = None
        let _v1507 = ref v1507 
        match v1495 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1508 : int64 = x
        let v1509 : US3 = US3_0(v1508)
        v1509 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1507.Value <- x
        let v1510 : US3 option = _v1507.Value 
        let v1521 : US3 = US3_1
        let v1522 : US3 = v1510 |> Option.defaultValue v1521 
        let v1562 : System.DateTime =
            match v1522 with
            | US3_1 -> (* None *)
                let v1558 : System.DateTime = System.DateTime.Now
                v1558
            | US3_0(v1526) -> (* Some *)
                let v1527 : System.DateTime = System.DateTime.Now
                let v1530 : (System.DateTime -> int64) = _.Ticks
                let v1531 : int64 = v1530 v1527
                let v1534 : int64 = v1531 - v1526
                let v1535 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1536 : System.TimeSpan = v1535 v1534
                let v1539 : (System.TimeSpan -> int32) = _.Hours
                let v1540 : int32 = v1539 v1536
                let v1543 : (System.TimeSpan -> int32) = _.Minutes
                let v1544 : int32 = v1543 v1536
                let v1547 : (System.TimeSpan -> int32) = _.Seconds
                let v1548 : int32 = v1547 v1536
                let v1551 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1552 : int32 = v1551 v1536
                let v1555 : System.DateTime = System.DateTime (1, 1, 1, v1540, v1544, v1548, v1552)
                v1555
        let v1563 : string = method5()
        let v1566 : (string -> string) = v1562.ToString
        let v1567 : string = v1566 v1563
        let _v1506 = v1567 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1570 : US3 option = None
        let _v1570 = ref v1570 
        match v1495 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1571 : int64 = x
        let v1572 : US3 = US3_0(v1571)
        v1572 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1570.Value <- x
        let v1573 : US3 option = _v1570.Value 
        let v1584 : US3 = US3_1
        let v1585 : US3 = v1573 |> Option.defaultValue v1584 
        let v1625 : System.DateTime =
            match v1585 with
            | US3_1 -> (* None *)
                let v1621 : System.DateTime = System.DateTime.Now
                v1621
            | US3_0(v1589) -> (* Some *)
                let v1590 : System.DateTime = System.DateTime.Now
                let v1593 : (System.DateTime -> int64) = _.Ticks
                let v1594 : int64 = v1593 v1590
                let v1597 : int64 = v1594 - v1589
                let v1598 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1599 : System.TimeSpan = v1598 v1597
                let v1602 : (System.TimeSpan -> int32) = _.Hours
                let v1603 : int32 = v1602 v1599
                let v1606 : (System.TimeSpan -> int32) = _.Minutes
                let v1607 : int32 = v1606 v1599
                let v1610 : (System.TimeSpan -> int32) = _.Seconds
                let v1611 : int32 = v1610 v1599
                let v1614 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1615 : int32 = v1614 v1599
                let v1618 : System.DateTime = System.DateTime (1, 1, 1, v1603, v1607, v1611, v1615)
                v1618
        let v1626 : string = method5()
        let v1629 : (string -> string) = v1625.ToString
        let v1630 : string = v1629 v1626
        let _v1506 = v1630 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1633 : string = $"near_sdk::env::block_timestamp()"
        let v1634 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1633 
        let v1635 : US3 option = None
        let _v1635 = ref v1635 
        match v1495 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1636 : int64 = x
        let v1637 : US3 = US3_0(v1636)
        v1637 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1635.Value <- x
        let v1638 : US3 option = _v1635.Value 
        let v1649 : US3 = US3_1
        let v1650 : US3 = v1638 |> Option.defaultValue v1649 
        let v1659 : uint64 =
            match v1650 with
            | US3_1 -> (* None *)
                v1634
            | US3_0(v1654) -> (* Some *)
                let v1655 : (int64 -> uint64) = uint64
                let v1656 : uint64 = v1655 v1654
                let v1657 : uint64 = v1634 - v1656
                v1657
        let v1660 : uint64 = v1659 / 1000000000UL
        let v1661 : uint64 = v1660 % 60UL
        let v1662 : uint64 = v1660 / 60UL
        let v1663 : uint64 = v1662 % 60UL
        let v1664 : uint64 = v1660 / 3600UL
        let v1665 : uint64 = v1664 % 24UL
        let v1666 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v1667 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1665, v1663, v1661) v1666 
        let v1668 : string = "fable_library_rust::String_::fromString($0)"
        let v1669 : string = Fable.Core.RustInterop.emitRustExpr v1667 v1668 
        let _v1506 = v1669 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1670 : US3 option = None
        let _v1670 = ref v1670 
        match v1495 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1671 : int64 = x
        let v1672 : US3 = US3_0(v1671)
        v1672 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1670.Value <- x
        let v1673 : US3 option = _v1670.Value 
        let v1684 : US3 = US3_1
        let v1685 : US3 = v1673 |> Option.defaultValue v1684 
        let v1725 : System.DateTime =
            match v1685 with
            | US3_1 -> (* None *)
                let v1721 : System.DateTime = System.DateTime.Now
                v1721
            | US3_0(v1689) -> (* Some *)
                let v1690 : System.DateTime = System.DateTime.Now
                let v1693 : (System.DateTime -> int64) = _.Ticks
                let v1694 : int64 = v1693 v1690
                let v1697 : int64 = v1694 - v1689
                let v1698 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1699 : System.TimeSpan = v1698 v1697
                let v1702 : (System.TimeSpan -> int32) = _.Hours
                let v1703 : int32 = v1702 v1699
                let v1706 : (System.TimeSpan -> int32) = _.Minutes
                let v1707 : int32 = v1706 v1699
                let v1710 : (System.TimeSpan -> int32) = _.Seconds
                let v1711 : int32 = v1710 v1699
                let v1714 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1715 : int32 = v1714 v1699
                let v1718 : System.DateTime = System.DateTime (1, 1, 1, v1703, v1707, v1711, v1715)
                v1718
        let v1726 : string = method6()
        let v1729 : (string -> string) = v1725.ToString
        let v1730 : string = v1729 v1726
        let _v1506 = v1730 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1733 : US3 option = None
        let _v1733 = ref v1733 
        match v1495 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1734 : int64 = x
        let v1735 : US3 = US3_0(v1734)
        v1735 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1733.Value <- x
        let v1736 : US3 option = _v1733.Value 
        let v1747 : US3 = US3_1
        let v1748 : US3 = v1736 |> Option.defaultValue v1747 
        let v1788 : System.DateTime =
            match v1748 with
            | US3_1 -> (* None *)
                let v1784 : System.DateTime = System.DateTime.Now
                v1784
            | US3_0(v1752) -> (* Some *)
                let v1753 : System.DateTime = System.DateTime.Now
                let v1756 : (System.DateTime -> int64) = _.Ticks
                let v1757 : int64 = v1756 v1753
                let v1760 : int64 = v1757 - v1752
                let v1761 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1762 : System.TimeSpan = v1761 v1760
                let v1765 : (System.TimeSpan -> int32) = _.Hours
                let v1766 : int32 = v1765 v1762
                let v1769 : (System.TimeSpan -> int32) = _.Minutes
                let v1770 : int32 = v1769 v1762
                let v1773 : (System.TimeSpan -> int32) = _.Seconds
                let v1774 : int32 = v1773 v1762
                let v1777 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1778 : int32 = v1777 v1762
                let v1781 : System.DateTime = System.DateTime (1, 1, 1, v1766, v1770, v1774, v1778)
                v1781
        let v1789 : string = method6()
        let v1792 : (string -> string) = v1788.ToString
        let v1793 : string = v1792 v1789
        let _v1506 = v1793 
        #endif
#else
        let v1796 : US3 option = None
        let _v1796 = ref v1796 
        match v1495 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1797 : int64 = x
        let v1798 : US3 = US3_0(v1797)
        v1798 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1796.Value <- x
        let v1799 : US3 option = _v1796.Value 
        let v1810 : US3 = US3_1
        let v1811 : US3 = v1799 |> Option.defaultValue v1810 
        let v1851 : System.DateTime =
            match v1811 with
            | US3_1 -> (* None *)
                let v1847 : System.DateTime = System.DateTime.Now
                v1847
            | US3_0(v1815) -> (* Some *)
                let v1816 : System.DateTime = System.DateTime.Now
                let v1819 : (System.DateTime -> int64) = _.Ticks
                let v1820 : int64 = v1819 v1816
                let v1823 : int64 = v1820 - v1815
                let v1824 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1825 : System.TimeSpan = v1824 v1823
                let v1828 : (System.TimeSpan -> int32) = _.Hours
                let v1829 : int32 = v1828 v1825
                let v1832 : (System.TimeSpan -> int32) = _.Minutes
                let v1833 : int32 = v1832 v1825
                let v1836 : (System.TimeSpan -> int32) = _.Seconds
                let v1837 : int32 = v1836 v1825
                let v1840 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1841 : int32 = v1840 v1825
                let v1844 : System.DateTime = System.DateTime (1, 1, 1, v1829, v1833, v1837, v1841)
                v1844
        let v1852 : string = method6()
        let v1855 : (string -> string) = v1851.ToString
        let v1856 : string = v1855 v1852
        let _v1506 = v1856 
        #endif
        let v1859 : string = _v1506 
        let v1924 : string = "Debug"
        let v1925 : (unit -> string) = v1924.ToLower
        let v1926 : string = v1925 ()
        let v1929 : string = v1926.PadLeft (7, ' ')
        let v1943 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1944 : string = "inline_colorization::color_bright_blue"
        let v1945 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1944 
        let v1946 : string = "&*$0"
        let v1947 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1929 v1946 
        let v1948 : string = "inline_colorization::color_reset"
        let v1949 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1948 
        let v1950 : string = "\"{v1945}{v1947}{v1949}\""
        let v1951 : string = @$"format!(" + v1950 + ")"
        let v1952 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1951 
        let v1953 : string = "fable_library_rust::String_::fromString($0)"
        let v1954 : string = Fable.Core.RustInterop.emitRustExpr v1952 v1953 
        let _v1943 = v1954 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1955 : string = "inline_colorization::color_bright_blue"
        let v1956 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1955 
        let v1957 : string = "&*$0"
        let v1958 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1929 v1957 
        let v1959 : string = "inline_colorization::color_reset"
        let v1960 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1959 
        let v1961 : string = "\"{v1956}{v1958}{v1960}\""
        let v1962 : string = @$"format!(" + v1961 + ")"
        let v1963 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1962 
        let v1964 : string = "fable_library_rust::String_::fromString($0)"
        let v1965 : string = Fable.Core.RustInterop.emitRustExpr v1963 v1964 
        let _v1943 = v1965 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1966 : string = "inline_colorization::color_bright_blue"
        let v1967 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1966 
        let v1968 : string = "&*$0"
        let v1969 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1929 v1968 
        let v1970 : string = "inline_colorization::color_reset"
        let v1971 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1970 
        let v1972 : string = "\"{v1967}{v1969}{v1971}\""
        let v1973 : string = @$"format!(" + v1972 + ")"
        let v1974 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1973 
        let v1975 : string = "fable_library_rust::String_::fromString($0)"
        let v1976 : string = Fable.Core.RustInterop.emitRustExpr v1974 v1975 
        let _v1943 = v1976 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1977 : string = "\u001b[94m"
        let v1978 : string = method7()
        let v1979 : string = v1977 + v1929 
        let v1980 : string = v1979 + v1978 
        let _v1943 = v1980 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1981 : string = "\u001b[94m"
        let v1982 : string = method7()
        let v1983 : string = v1981 + v1929 
        let v1984 : string = v1983 + v1982 
        let _v1943 = v1984 
        #endif
#else
        let v1985 : string = "\u001b[94m"
        let v1986 : string = method7()
        let v1987 : string = v1985 + v1929 
        let v1988 : string = v1987 + v1986 
        let _v1943 = v1988 
        #endif
        let v1989 : string = _v1943 
        let v1995 : int64 = v1491.l0
        let v1996 : string = method8()
        let v1997 : Mut4 = {l0 = v1996} : Mut4
        let v1998 : string = "{ "
        let v1999 : string = $"{v1998}"
        let v2002 : string = v1997.l0
        let v2003 : string = v2002 + v1999 
        v1997.l0 <- v2003
        let v2004 : string = "contract"
        let v2005 : string = $"{v2004}"
        let v2008 : string = v1997.l0
        let v2009 : string = v2008 + v2005 
        v1997.l0 <- v2009
        let v2010 : string = " = "
        let v2011 : string = $"{v2010}"
        let v2014 : string = v1997.l0
        let v2015 : string = v2014 + v2011 
        v1997.l0 <- v2015
        let v2016 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2017 : string = "format!(\"{:#?}\", $0)"
        let v2018 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1416 v2017 
        let v2019 : string = "fable_library_rust::String_::fromString($0)"
        let v2020 : string = Fable.Core.RustInterop.emitRustExpr v2018 v2019 
        let _v2016 = v2020 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2021 : string = "format!(\"{:#?}\", $0)"
        let v2022 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1416 v2021 
        let v2023 : string = "fable_library_rust::String_::fromString($0)"
        let v2024 : string = Fable.Core.RustInterop.emitRustExpr v2022 v2023 
        let _v2016 = v2024 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2025 : string = "format!(\"{:#?}\", $0)"
        let v2026 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1416 v2025 
        let v2027 : string = "fable_library_rust::String_::fromString($0)"
        let v2028 : string = Fable.Core.RustInterop.emitRustExpr v2026 v2027 
        let _v2016 = v2028 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2029 : string = $"%A{v1416}"
        let _v2016 = v2029 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2032 : string = $"%A{v1416}"
        let _v2016 = v2032 
        #endif
#else
        let v2035 : string = $"%A{v1416}"
        let _v2016 = v2035 
        #endif
        let v2038 : string = _v2016 
        let v2043 : string = $"{v2038}"
        let v2046 : string = v1997.l0
        let v2047 : string = v2046 + v2043 
        v1997.l0 <- v2047
        let v2048 : string = " }"
        let v2049 : string = $"{v2048}"
        let v2052 : string = v1997.l0
        let v2053 : string = v2052 + v2049 
        v1997.l0 <- v2053
        let v2054 : string = v1997.l0
        let v2055 : (unit -> string) = closure6()
        let v2056 : string = $"{v1859} {v1989} #{v1995} %s{v2055 ()} / {v2054}"
        let v2059 : char list = []
        let v2060 : (char list -> (char [])) = List.toArray
        let v2061 : (char []) = v2060 v2059
        let v2064 : string = v2056.TrimStart v2061 
        let v2082 : char list = []
        let v2083 : char list = '/' :: v2082 
        let v2086 : char list = ' ' :: v2083 
        let v2089 : (char list -> (char [])) = List.toArray
        let v2090 : (char []) = v2089 v2086
        let v2093 : string = v2064.TrimEnd v2090 
        let v2111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2112 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2093 v2112 
        let _v2111 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2113 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2093 v2113 
        let _v2111 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2114 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v2093 v2114 
        let _v2111 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v2093 
        let _v2111 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v2093 
        let _v2111 = () 
        #endif
#else
        System.Console.WriteLine v2093 
        let _v2111 = () 
        #endif
        _v2111 
        let v2115 : (string -> unit) = v1430.l0
        v2115 v2093
    let v2116 : string = "v1416.call(&*$0)"
    let v2117 : string = "state_main"
    let v2118 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr v2117 v2116 
    let v2119 : string = "Box::pin(v2118.transact())"
    let v2120 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v2119 
    let v2121 : string = "v2120.await"
    let v2122 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v2121 
    let v2123 : string = "$0?"
    let v2124 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v2122 v2123 
    let v2125 : bool = State.trace_state.IsNone
    if v2125 then
        let v2126 : US0 = US0_0
        let struct (v2127 : Mut0, v2128 : Mut1, v2129 : Mut2, v2130 : Mut3, v2131 : int64 option) = method0(v2126)
        let v2132 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2127, v2128, v2129, v2130, v2131) 
        State.trace_state <- v2132 
        ()
    let struct (v2137 : Mut0, v2138 : Mut1, v2139 : Mut2, v2140 : Mut3, v2141 : int64 option) = State.trace_state.Value
    let v2152 : bool = State.trace_state.IsNone
    if v2152 then
        let v2153 : US0 = US0_0
        let struct (v2154 : Mut0, v2155 : Mut1, v2156 : Mut2, v2157 : Mut3, v2158 : int64 option) = method0(v2153)
        let v2159 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2154, v2155, v2156, v2157, v2158) 
        State.trace_state <- v2159 
        ()
    let struct (v2164 : Mut0, v2165 : Mut1, v2166 : Mut2, v2167 : Mut3, v2168 : int64 option) = State.trace_state.Value
    let v2179 : US0 = v2167.l0
    let v2180 : bool = v2166.l0
    let v2181 : bool = v2180 = false
    let v2184 : bool =
        if v2181 then
            false
        else
            let v2182 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v2179
            let v2183 : bool = 1 >= v2182
            v2183
    if v2184 then
        let v2185 : int64 = v2137.l0
        let v2186 : int64 = v2185 + 1L
        v2137.l0 <- v2186
        let v2187 : bool = State.trace_state.IsNone
        if v2187 then
            let v2188 : US0 = US0_0
            let struct (v2189 : Mut0, v2190 : Mut1, v2191 : Mut2, v2192 : Mut3, v2193 : int64 option) = method0(v2188)
            let v2194 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2189, v2190, v2191, v2192, v2193) 
            State.trace_state <- v2194 
            ()
        let struct (v2199 : Mut0, v2200 : Mut1, v2201 : Mut2, v2202 : Mut3, v2203 : int64 option) = State.trace_state.Value
        let v2214 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2215 : US3 option = None
        let _v2215 = ref v2215 
        match v2203 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2216 : int64 = x
        let v2217 : US3 = US3_0(v2216)
        v2217 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2215.Value <- x
        let v2218 : US3 option = _v2215.Value 
        let v2229 : US3 = US3_1
        let v2230 : US3 = v2218 |> Option.defaultValue v2229 
        let v2270 : System.DateTime =
            match v2230 with
            | US3_1 -> (* None *)
                let v2266 : System.DateTime = System.DateTime.Now
                v2266
            | US3_0(v2234) -> (* Some *)
                let v2235 : System.DateTime = System.DateTime.Now
                let v2238 : (System.DateTime -> int64) = _.Ticks
                let v2239 : int64 = v2238 v2235
                let v2242 : int64 = v2239 - v2234
                let v2243 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2244 : System.TimeSpan = v2243 v2242
                let v2247 : (System.TimeSpan -> int32) = _.Hours
                let v2248 : int32 = v2247 v2244
                let v2251 : (System.TimeSpan -> int32) = _.Minutes
                let v2252 : int32 = v2251 v2244
                let v2255 : (System.TimeSpan -> int32) = _.Seconds
                let v2256 : int32 = v2255 v2244
                let v2259 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2260 : int32 = v2259 v2244
                let v2263 : System.DateTime = System.DateTime (1, 1, 1, v2248, v2252, v2256, v2260)
                v2263
        let v2271 : string = method5()
        let v2274 : (string -> string) = v2270.ToString
        let v2275 : string = v2274 v2271
        let _v2214 = v2275 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2278 : US3 option = None
        let _v2278 = ref v2278 
        match v2203 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2279 : int64 = x
        let v2280 : US3 = US3_0(v2279)
        v2280 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2278.Value <- x
        let v2281 : US3 option = _v2278.Value 
        let v2292 : US3 = US3_1
        let v2293 : US3 = v2281 |> Option.defaultValue v2292 
        let v2333 : System.DateTime =
            match v2293 with
            | US3_1 -> (* None *)
                let v2329 : System.DateTime = System.DateTime.Now
                v2329
            | US3_0(v2297) -> (* Some *)
                let v2298 : System.DateTime = System.DateTime.Now
                let v2301 : (System.DateTime -> int64) = _.Ticks
                let v2302 : int64 = v2301 v2298
                let v2305 : int64 = v2302 - v2297
                let v2306 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2307 : System.TimeSpan = v2306 v2305
                let v2310 : (System.TimeSpan -> int32) = _.Hours
                let v2311 : int32 = v2310 v2307
                let v2314 : (System.TimeSpan -> int32) = _.Minutes
                let v2315 : int32 = v2314 v2307
                let v2318 : (System.TimeSpan -> int32) = _.Seconds
                let v2319 : int32 = v2318 v2307
                let v2322 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2323 : int32 = v2322 v2307
                let v2326 : System.DateTime = System.DateTime (1, 1, 1, v2311, v2315, v2319, v2323)
                v2326
        let v2334 : string = method5()
        let v2337 : (string -> string) = v2333.ToString
        let v2338 : string = v2337 v2334
        let _v2214 = v2338 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2341 : string = $"near_sdk::env::block_timestamp()"
        let v2342 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2341 
        let v2343 : US3 option = None
        let _v2343 = ref v2343 
        match v2203 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2344 : int64 = x
        let v2345 : US3 = US3_0(v2344)
        v2345 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2343.Value <- x
        let v2346 : US3 option = _v2343.Value 
        let v2357 : US3 = US3_1
        let v2358 : US3 = v2346 |> Option.defaultValue v2357 
        let v2367 : uint64 =
            match v2358 with
            | US3_1 -> (* None *)
                v2342
            | US3_0(v2362) -> (* Some *)
                let v2363 : (int64 -> uint64) = uint64
                let v2364 : uint64 = v2363 v2362
                let v2365 : uint64 = v2342 - v2364
                v2365
        let v2368 : uint64 = v2367 / 1000000000UL
        let v2369 : uint64 = v2368 % 60UL
        let v2370 : uint64 = v2368 / 60UL
        let v2371 : uint64 = v2370 % 60UL
        let v2372 : uint64 = v2368 / 3600UL
        let v2373 : uint64 = v2372 % 24UL
        let v2374 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v2375 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2373, v2371, v2369) v2374 
        let v2376 : string = "fable_library_rust::String_::fromString($0)"
        let v2377 : string = Fable.Core.RustInterop.emitRustExpr v2375 v2376 
        let _v2214 = v2377 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2378 : US3 option = None
        let _v2378 = ref v2378 
        match v2203 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2379 : int64 = x
        let v2380 : US3 = US3_0(v2379)
        v2380 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2378.Value <- x
        let v2381 : US3 option = _v2378.Value 
        let v2392 : US3 = US3_1
        let v2393 : US3 = v2381 |> Option.defaultValue v2392 
        let v2433 : System.DateTime =
            match v2393 with
            | US3_1 -> (* None *)
                let v2429 : System.DateTime = System.DateTime.Now
                v2429
            | US3_0(v2397) -> (* Some *)
                let v2398 : System.DateTime = System.DateTime.Now
                let v2401 : (System.DateTime -> int64) = _.Ticks
                let v2402 : int64 = v2401 v2398
                let v2405 : int64 = v2402 - v2397
                let v2406 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2407 : System.TimeSpan = v2406 v2405
                let v2410 : (System.TimeSpan -> int32) = _.Hours
                let v2411 : int32 = v2410 v2407
                let v2414 : (System.TimeSpan -> int32) = _.Minutes
                let v2415 : int32 = v2414 v2407
                let v2418 : (System.TimeSpan -> int32) = _.Seconds
                let v2419 : int32 = v2418 v2407
                let v2422 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2423 : int32 = v2422 v2407
                let v2426 : System.DateTime = System.DateTime (1, 1, 1, v2411, v2415, v2419, v2423)
                v2426
        let v2434 : string = method6()
        let v2437 : (string -> string) = v2433.ToString
        let v2438 : string = v2437 v2434
        let _v2214 = v2438 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2441 : US3 option = None
        let _v2441 = ref v2441 
        match v2203 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2442 : int64 = x
        let v2443 : US3 = US3_0(v2442)
        v2443 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2441.Value <- x
        let v2444 : US3 option = _v2441.Value 
        let v2455 : US3 = US3_1
        let v2456 : US3 = v2444 |> Option.defaultValue v2455 
        let v2496 : System.DateTime =
            match v2456 with
            | US3_1 -> (* None *)
                let v2492 : System.DateTime = System.DateTime.Now
                v2492
            | US3_0(v2460) -> (* Some *)
                let v2461 : System.DateTime = System.DateTime.Now
                let v2464 : (System.DateTime -> int64) = _.Ticks
                let v2465 : int64 = v2464 v2461
                let v2468 : int64 = v2465 - v2460
                let v2469 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2470 : System.TimeSpan = v2469 v2468
                let v2473 : (System.TimeSpan -> int32) = _.Hours
                let v2474 : int32 = v2473 v2470
                let v2477 : (System.TimeSpan -> int32) = _.Minutes
                let v2478 : int32 = v2477 v2470
                let v2481 : (System.TimeSpan -> int32) = _.Seconds
                let v2482 : int32 = v2481 v2470
                let v2485 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2486 : int32 = v2485 v2470
                let v2489 : System.DateTime = System.DateTime (1, 1, 1, v2474, v2478, v2482, v2486)
                v2489
        let v2497 : string = method6()
        let v2500 : (string -> string) = v2496.ToString
        let v2501 : string = v2500 v2497
        let _v2214 = v2501 
        #endif
#else
        let v2504 : US3 option = None
        let _v2504 = ref v2504 
        match v2203 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2505 : int64 = x
        let v2506 : US3 = US3_0(v2505)
        v2506 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2504.Value <- x
        let v2507 : US3 option = _v2504.Value 
        let v2518 : US3 = US3_1
        let v2519 : US3 = v2507 |> Option.defaultValue v2518 
        let v2559 : System.DateTime =
            match v2519 with
            | US3_1 -> (* None *)
                let v2555 : System.DateTime = System.DateTime.Now
                v2555
            | US3_0(v2523) -> (* Some *)
                let v2524 : System.DateTime = System.DateTime.Now
                let v2527 : (System.DateTime -> int64) = _.Ticks
                let v2528 : int64 = v2527 v2524
                let v2531 : int64 = v2528 - v2523
                let v2532 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2533 : System.TimeSpan = v2532 v2531
                let v2536 : (System.TimeSpan -> int32) = _.Hours
                let v2537 : int32 = v2536 v2533
                let v2540 : (System.TimeSpan -> int32) = _.Minutes
                let v2541 : int32 = v2540 v2533
                let v2544 : (System.TimeSpan -> int32) = _.Seconds
                let v2545 : int32 = v2544 v2533
                let v2548 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2549 : int32 = v2548 v2533
                let v2552 : System.DateTime = System.DateTime (1, 1, 1, v2537, v2541, v2545, v2549)
                v2552
        let v2560 : string = method6()
        let v2563 : (string -> string) = v2559.ToString
        let v2564 : string = v2563 v2560
        let _v2214 = v2564 
        #endif
        let v2567 : string = _v2214 
        let v2632 : string = "Debug"
        let v2633 : (unit -> string) = v2632.ToLower
        let v2634 : string = v2633 ()
        let v2637 : string = v2634.PadLeft (7, ' ')
        let v2651 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2652 : string = "inline_colorization::color_bright_blue"
        let v2653 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2652 
        let v2654 : string = "&*$0"
        let v2655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2637 v2654 
        let v2656 : string = "inline_colorization::color_reset"
        let v2657 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2656 
        let v2658 : string = "\"{v2653}{v2655}{v2657}\""
        let v2659 : string = @$"format!(" + v2658 + ")"
        let v2660 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2659 
        let v2661 : string = "fable_library_rust::String_::fromString($0)"
        let v2662 : string = Fable.Core.RustInterop.emitRustExpr v2660 v2661 
        let _v2651 = v2662 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2663 : string = "inline_colorization::color_bright_blue"
        let v2664 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2663 
        let v2665 : string = "&*$0"
        let v2666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2637 v2665 
        let v2667 : string = "inline_colorization::color_reset"
        let v2668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2667 
        let v2669 : string = "\"{v2664}{v2666}{v2668}\""
        let v2670 : string = @$"format!(" + v2669 + ")"
        let v2671 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2670 
        let v2672 : string = "fable_library_rust::String_::fromString($0)"
        let v2673 : string = Fable.Core.RustInterop.emitRustExpr v2671 v2672 
        let _v2651 = v2673 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2674 : string = "inline_colorization::color_bright_blue"
        let v2675 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2674 
        let v2676 : string = "&*$0"
        let v2677 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2637 v2676 
        let v2678 : string = "inline_colorization::color_reset"
        let v2679 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2678 
        let v2680 : string = "\"{v2675}{v2677}{v2679}\""
        let v2681 : string = @$"format!(" + v2680 + ")"
        let v2682 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2681 
        let v2683 : string = "fable_library_rust::String_::fromString($0)"
        let v2684 : string = Fable.Core.RustInterop.emitRustExpr v2682 v2683 
        let _v2651 = v2684 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2685 : string = "\u001b[94m"
        let v2686 : string = method7()
        let v2687 : string = v2685 + v2637 
        let v2688 : string = v2687 + v2686 
        let _v2651 = v2688 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2689 : string = "\u001b[94m"
        let v2690 : string = method7()
        let v2691 : string = v2689 + v2637 
        let v2692 : string = v2691 + v2690 
        let _v2651 = v2692 
        #endif
#else
        let v2693 : string = "\u001b[94m"
        let v2694 : string = method7()
        let v2695 : string = v2693 + v2637 
        let v2696 : string = v2695 + v2694 
        let _v2651 = v2696 
        #endif
        let v2697 : string = _v2651 
        let v2703 : int64 = v2199.l0
        let v2704 : string = method8()
        let v2705 : Mut4 = {l0 = v2704} : Mut4
        let v2706 : string = "{ "
        let v2707 : string = $"{v2706}"
        let v2710 : string = v2705.l0
        let v2711 : string = v2710 + v2707 
        v2705.l0 <- v2711
        let v2712 : string = "result"
        let v2713 : string = $"{v2712}"
        let v2716 : string = v2705.l0
        let v2717 : string = v2716 + v2713 
        v2705.l0 <- v2717
        let v2718 : string = " = "
        let v2719 : string = $"{v2718}"
        let v2722 : string = v2705.l0
        let v2723 : string = v2722 + v2719 
        v2705.l0 <- v2723
        let v2724 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2725 : string = "format!(\"{:#?}\", $0)"
        let v2726 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2124 v2725 
        let v2727 : string = "fable_library_rust::String_::fromString($0)"
        let v2728 : string = Fable.Core.RustInterop.emitRustExpr v2726 v2727 
        let _v2724 = v2728 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2729 : string = "format!(\"{:#?}\", $0)"
        let v2730 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2124 v2729 
        let v2731 : string = "fable_library_rust::String_::fromString($0)"
        let v2732 : string = Fable.Core.RustInterop.emitRustExpr v2730 v2731 
        let _v2724 = v2732 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2733 : string = "format!(\"{:#?}\", $0)"
        let v2734 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2124 v2733 
        let v2735 : string = "fable_library_rust::String_::fromString($0)"
        let v2736 : string = Fable.Core.RustInterop.emitRustExpr v2734 v2735 
        let _v2724 = v2736 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2737 : string = $"%A{v2124}"
        let _v2724 = v2737 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2740 : string = $"%A{v2124}"
        let _v2724 = v2740 
        #endif
#else
        let v2743 : string = $"%A{v2124}"
        let _v2724 = v2743 
        #endif
        let v2746 : string = _v2724 
        let v2751 : string = $"{v2746}"
        let v2754 : string = v2705.l0
        let v2755 : string = v2754 + v2751 
        v2705.l0 <- v2755
        let v2756 : string = " }"
        let v2757 : string = $"{v2756}"
        let v2760 : string = v2705.l0
        let v2761 : string = v2760 + v2757 
        v2705.l0 <- v2761
        let v2762 : string = v2705.l0
        let v2763 : (unit -> string) = closure7()
        let v2764 : string = $"{v2567} {v2697} #{v2703} %s{v2763 ()} / {v2762}"
        let v2767 : char list = []
        let v2768 : (char list -> (char [])) = List.toArray
        let v2769 : (char []) = v2768 v2767
        let v2772 : string = v2764.TrimStart v2769 
        let v2790 : char list = []
        let v2791 : char list = '/' :: v2790 
        let v2794 : char list = ' ' :: v2791 
        let v2797 : (char list -> (char [])) = List.toArray
        let v2798 : (char []) = v2797 v2794
        let v2801 : string = v2772.TrimEnd v2798 
        let v2819 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2820 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2801 v2820 
        let _v2819 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2821 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2801 v2821 
        let _v2819 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2822 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v2801 v2822 
        let _v2819 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v2801 
        let _v2819 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v2801 
        let _v2819 = () 
        #endif
#else
        System.Console.WriteLine v2801 
        let _v2819 = () 
        #endif
        _v2819 
        let v2823 : (string -> unit) = v2138.l0
        v2823 v2801
    let v2824 : string = "v2124.logs()"
    let v2825 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v2824 
    let v2826 : string = "true; let _result : Vec<_> = v2825.into_iter().map(|x| { //"
    let v2827 : bool = Fable.Core.RustInterop.emitRustExpr () v2826 
    let v2828 : string = "x"
    let v2829 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2828 
    let v2830 : string = "String::from($0)"
    let v2831 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2829 v2830 
    let v2832 : string = "true; $0 }).collect::<Vec<_>>()"
    let v2833 : bool = Fable.Core.RustInterop.emitRustExpr v2831 v2832 
    let v2834 : string = "_result"
    let v2835 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2834 
    let v2836 : string = "$0.iter().for_each(|x| { $1(x.clone()); })"
    let v2837 : (std_string_String -> unit) = closure8()
    Fable.Core.RustInterop.emitRustExpr struct (v2835, v2837) v2836 
    let v2838 : string = "  println!(\"\\n\\n state_main transact result: {:#?}\", v2124.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v2838 
    let v2839 : string = "  println!(\"\\n\\n print_usd:\"); //"
    Fable.Core.RustInterop.emitRustExpr () v2839 
    let v2840 : string = "  print_usd(v2124.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v2840 
    let v2841 : string = "$0.into_result()"
    let v2842 : Result<near_workspaces_result_ExecutionResult<near_workspaces_result_Value>, near_workspaces_result_ExecutionResult<near_primitives_errors_TxExecutionError>> = Fable.Core.RustInterop.emitRustExpr v2124 v2841 
    let v2843 : bool = State.trace_state.IsNone
    if v2843 then
        let v2844 : US0 = US0_0
        let struct (v2845 : Mut0, v2846 : Mut1, v2847 : Mut2, v2848 : Mut3, v2849 : int64 option) = method0(v2844)
        let v2850 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2845, v2846, v2847, v2848, v2849) 
        State.trace_state <- v2850 
        ()
    let struct (v2855 : Mut0, v2856 : Mut1, v2857 : Mut2, v2858 : Mut3, v2859 : int64 option) = State.trace_state.Value
    let v2870 : bool = State.trace_state.IsNone
    if v2870 then
        let v2871 : US0 = US0_0
        let struct (v2872 : Mut0, v2873 : Mut1, v2874 : Mut2, v2875 : Mut3, v2876 : int64 option) = method0(v2871)
        let v2877 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2872, v2873, v2874, v2875, v2876) 
        State.trace_state <- v2877 
        ()
    let struct (v2882 : Mut0, v2883 : Mut1, v2884 : Mut2, v2885 : Mut3, v2886 : int64 option) = State.trace_state.Value
    let v2897 : US0 = v2885.l0
    let v2898 : bool = v2884.l0
    let v2899 : bool = v2898 = false
    let v2902 : bool =
        if v2899 then
            false
        else
            let v2900 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v2897
            let v2901 : bool = 1 >= v2900
            v2901
    if v2902 then
        let v2903 : int64 = v2855.l0
        let v2904 : int64 = v2903 + 1L
        v2855.l0 <- v2904
        let v2905 : bool = State.trace_state.IsNone
        if v2905 then
            let v2906 : US0 = US0_0
            let struct (v2907 : Mut0, v2908 : Mut1, v2909 : Mut2, v2910 : Mut3, v2911 : int64 option) = method0(v2906)
            let v2912 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2907, v2908, v2909, v2910, v2911) 
            State.trace_state <- v2912 
            ()
        let struct (v2917 : Mut0, v2918 : Mut1, v2919 : Mut2, v2920 : Mut3, v2921 : int64 option) = State.trace_state.Value
        let v2932 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2933 : US3 option = None
        let _v2933 = ref v2933 
        match v2921 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2934 : int64 = x
        let v2935 : US3 = US3_0(v2934)
        v2935 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2933.Value <- x
        let v2936 : US3 option = _v2933.Value 
        let v2947 : US3 = US3_1
        let v2948 : US3 = v2936 |> Option.defaultValue v2947 
        let v2988 : System.DateTime =
            match v2948 with
            | US3_1 -> (* None *)
                let v2984 : System.DateTime = System.DateTime.Now
                v2984
            | US3_0(v2952) -> (* Some *)
                let v2953 : System.DateTime = System.DateTime.Now
                let v2956 : (System.DateTime -> int64) = _.Ticks
                let v2957 : int64 = v2956 v2953
                let v2960 : int64 = v2957 - v2952
                let v2961 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2962 : System.TimeSpan = v2961 v2960
                let v2965 : (System.TimeSpan -> int32) = _.Hours
                let v2966 : int32 = v2965 v2962
                let v2969 : (System.TimeSpan -> int32) = _.Minutes
                let v2970 : int32 = v2969 v2962
                let v2973 : (System.TimeSpan -> int32) = _.Seconds
                let v2974 : int32 = v2973 v2962
                let v2977 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2978 : int32 = v2977 v2962
                let v2981 : System.DateTime = System.DateTime (1, 1, 1, v2966, v2970, v2974, v2978)
                v2981
        let v2989 : string = method5()
        let v2992 : (string -> string) = v2988.ToString
        let v2993 : string = v2992 v2989
        let _v2932 = v2993 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2996 : US3 option = None
        let _v2996 = ref v2996 
        match v2921 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2997 : int64 = x
        let v2998 : US3 = US3_0(v2997)
        v2998 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2996.Value <- x
        let v2999 : US3 option = _v2996.Value 
        let v3010 : US3 = US3_1
        let v3011 : US3 = v2999 |> Option.defaultValue v3010 
        let v3051 : System.DateTime =
            match v3011 with
            | US3_1 -> (* None *)
                let v3047 : System.DateTime = System.DateTime.Now
                v3047
            | US3_0(v3015) -> (* Some *)
                let v3016 : System.DateTime = System.DateTime.Now
                let v3019 : (System.DateTime -> int64) = _.Ticks
                let v3020 : int64 = v3019 v3016
                let v3023 : int64 = v3020 - v3015
                let v3024 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3025 : System.TimeSpan = v3024 v3023
                let v3028 : (System.TimeSpan -> int32) = _.Hours
                let v3029 : int32 = v3028 v3025
                let v3032 : (System.TimeSpan -> int32) = _.Minutes
                let v3033 : int32 = v3032 v3025
                let v3036 : (System.TimeSpan -> int32) = _.Seconds
                let v3037 : int32 = v3036 v3025
                let v3040 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3041 : int32 = v3040 v3025
                let v3044 : System.DateTime = System.DateTime (1, 1, 1, v3029, v3033, v3037, v3041)
                v3044
        let v3052 : string = method5()
        let v3055 : (string -> string) = v3051.ToString
        let v3056 : string = v3055 v3052
        let _v2932 = v3056 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3059 : string = $"near_sdk::env::block_timestamp()"
        let v3060 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3059 
        let v3061 : US3 option = None
        let _v3061 = ref v3061 
        match v2921 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3062 : int64 = x
        let v3063 : US3 = US3_0(v3062)
        v3063 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3061.Value <- x
        let v3064 : US3 option = _v3061.Value 
        let v3075 : US3 = US3_1
        let v3076 : US3 = v3064 |> Option.defaultValue v3075 
        let v3085 : uint64 =
            match v3076 with
            | US3_1 -> (* None *)
                v3060
            | US3_0(v3080) -> (* Some *)
                let v3081 : (int64 -> uint64) = uint64
                let v3082 : uint64 = v3081 v3080
                let v3083 : uint64 = v3060 - v3082
                v3083
        let v3086 : uint64 = v3085 / 1000000000UL
        let v3087 : uint64 = v3086 % 60UL
        let v3088 : uint64 = v3086 / 60UL
        let v3089 : uint64 = v3088 % 60UL
        let v3090 : uint64 = v3086 / 3600UL
        let v3091 : uint64 = v3090 % 24UL
        let v3092 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v3093 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3091, v3089, v3087) v3092 
        let v3094 : string = "fable_library_rust::String_::fromString($0)"
        let v3095 : string = Fable.Core.RustInterop.emitRustExpr v3093 v3094 
        let _v2932 = v3095 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3096 : US3 option = None
        let _v3096 = ref v3096 
        match v2921 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3097 : int64 = x
        let v3098 : US3 = US3_0(v3097)
        v3098 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3096.Value <- x
        let v3099 : US3 option = _v3096.Value 
        let v3110 : US3 = US3_1
        let v3111 : US3 = v3099 |> Option.defaultValue v3110 
        let v3151 : System.DateTime =
            match v3111 with
            | US3_1 -> (* None *)
                let v3147 : System.DateTime = System.DateTime.Now
                v3147
            | US3_0(v3115) -> (* Some *)
                let v3116 : System.DateTime = System.DateTime.Now
                let v3119 : (System.DateTime -> int64) = _.Ticks
                let v3120 : int64 = v3119 v3116
                let v3123 : int64 = v3120 - v3115
                let v3124 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3125 : System.TimeSpan = v3124 v3123
                let v3128 : (System.TimeSpan -> int32) = _.Hours
                let v3129 : int32 = v3128 v3125
                let v3132 : (System.TimeSpan -> int32) = _.Minutes
                let v3133 : int32 = v3132 v3125
                let v3136 : (System.TimeSpan -> int32) = _.Seconds
                let v3137 : int32 = v3136 v3125
                let v3140 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3141 : int32 = v3140 v3125
                let v3144 : System.DateTime = System.DateTime (1, 1, 1, v3129, v3133, v3137, v3141)
                v3144
        let v3152 : string = method6()
        let v3155 : (string -> string) = v3151.ToString
        let v3156 : string = v3155 v3152
        let _v2932 = v3156 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3159 : US3 option = None
        let _v3159 = ref v3159 
        match v2921 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3160 : int64 = x
        let v3161 : US3 = US3_0(v3160)
        v3161 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3159.Value <- x
        let v3162 : US3 option = _v3159.Value 
        let v3173 : US3 = US3_1
        let v3174 : US3 = v3162 |> Option.defaultValue v3173 
        let v3214 : System.DateTime =
            match v3174 with
            | US3_1 -> (* None *)
                let v3210 : System.DateTime = System.DateTime.Now
                v3210
            | US3_0(v3178) -> (* Some *)
                let v3179 : System.DateTime = System.DateTime.Now
                let v3182 : (System.DateTime -> int64) = _.Ticks
                let v3183 : int64 = v3182 v3179
                let v3186 : int64 = v3183 - v3178
                let v3187 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3188 : System.TimeSpan = v3187 v3186
                let v3191 : (System.TimeSpan -> int32) = _.Hours
                let v3192 : int32 = v3191 v3188
                let v3195 : (System.TimeSpan -> int32) = _.Minutes
                let v3196 : int32 = v3195 v3188
                let v3199 : (System.TimeSpan -> int32) = _.Seconds
                let v3200 : int32 = v3199 v3188
                let v3203 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3204 : int32 = v3203 v3188
                let v3207 : System.DateTime = System.DateTime (1, 1, 1, v3192, v3196, v3200, v3204)
                v3207
        let v3215 : string = method6()
        let v3218 : (string -> string) = v3214.ToString
        let v3219 : string = v3218 v3215
        let _v2932 = v3219 
        #endif
#else
        let v3222 : US3 option = None
        let _v3222 = ref v3222 
        match v2921 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3223 : int64 = x
        let v3224 : US3 = US3_0(v3223)
        v3224 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3222.Value <- x
        let v3225 : US3 option = _v3222.Value 
        let v3236 : US3 = US3_1
        let v3237 : US3 = v3225 |> Option.defaultValue v3236 
        let v3277 : System.DateTime =
            match v3237 with
            | US3_1 -> (* None *)
                let v3273 : System.DateTime = System.DateTime.Now
                v3273
            | US3_0(v3241) -> (* Some *)
                let v3242 : System.DateTime = System.DateTime.Now
                let v3245 : (System.DateTime -> int64) = _.Ticks
                let v3246 : int64 = v3245 v3242
                let v3249 : int64 = v3246 - v3241
                let v3250 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3251 : System.TimeSpan = v3250 v3249
                let v3254 : (System.TimeSpan -> int32) = _.Hours
                let v3255 : int32 = v3254 v3251
                let v3258 : (System.TimeSpan -> int32) = _.Minutes
                let v3259 : int32 = v3258 v3251
                let v3262 : (System.TimeSpan -> int32) = _.Seconds
                let v3263 : int32 = v3262 v3251
                let v3266 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3267 : int32 = v3266 v3251
                let v3270 : System.DateTime = System.DateTime (1, 1, 1, v3255, v3259, v3263, v3267)
                v3270
        let v3278 : string = method6()
        let v3281 : (string -> string) = v3277.ToString
        let v3282 : string = v3281 v3278
        let _v2932 = v3282 
        #endif
        let v3285 : string = _v2932 
        let v3350 : string = "Debug"
        let v3351 : (unit -> string) = v3350.ToLower
        let v3352 : string = v3351 ()
        let v3355 : string = v3352.PadLeft (7, ' ')
        let v3369 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3370 : string = "inline_colorization::color_bright_blue"
        let v3371 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3370 
        let v3372 : string = "&*$0"
        let v3373 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3355 v3372 
        let v3374 : string = "inline_colorization::color_reset"
        let v3375 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3374 
        let v3376 : string = "\"{v3371}{v3373}{v3375}\""
        let v3377 : string = @$"format!(" + v3376 + ")"
        let v3378 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3377 
        let v3379 : string = "fable_library_rust::String_::fromString($0)"
        let v3380 : string = Fable.Core.RustInterop.emitRustExpr v3378 v3379 
        let _v3369 = v3380 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3381 : string = "inline_colorization::color_bright_blue"
        let v3382 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3381 
        let v3383 : string = "&*$0"
        let v3384 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3355 v3383 
        let v3385 : string = "inline_colorization::color_reset"
        let v3386 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3385 
        let v3387 : string = "\"{v3382}{v3384}{v3386}\""
        let v3388 : string = @$"format!(" + v3387 + ")"
        let v3389 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3388 
        let v3390 : string = "fable_library_rust::String_::fromString($0)"
        let v3391 : string = Fable.Core.RustInterop.emitRustExpr v3389 v3390 
        let _v3369 = v3391 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3392 : string = "inline_colorization::color_bright_blue"
        let v3393 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3392 
        let v3394 : string = "&*$0"
        let v3395 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3355 v3394 
        let v3396 : string = "inline_colorization::color_reset"
        let v3397 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3396 
        let v3398 : string = "\"{v3393}{v3395}{v3397}\""
        let v3399 : string = @$"format!(" + v3398 + ")"
        let v3400 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3399 
        let v3401 : string = "fable_library_rust::String_::fromString($0)"
        let v3402 : string = Fable.Core.RustInterop.emitRustExpr v3400 v3401 
        let _v3369 = v3402 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3403 : string = "\u001b[94m"
        let v3404 : string = method7()
        let v3405 : string = v3403 + v3355 
        let v3406 : string = v3405 + v3404 
        let _v3369 = v3406 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3407 : string = "\u001b[94m"
        let v3408 : string = method7()
        let v3409 : string = v3407 + v3355 
        let v3410 : string = v3409 + v3408 
        let _v3369 = v3410 
        #endif
#else
        let v3411 : string = "\u001b[94m"
        let v3412 : string = method7()
        let v3413 : string = v3411 + v3355 
        let v3414 : string = v3413 + v3412 
        let _v3369 = v3414 
        #endif
        let v3415 : string = _v3369 
        let v3421 : int64 = v2917.l0
        let v3422 : string = method8()
        let v3423 : Mut4 = {l0 = v3422} : Mut4
        let v3424 : string = "{ "
        let v3425 : string = $"{v3424}"
        let v3428 : string = v3423.l0
        let v3429 : string = v3428 + v3425 
        v3423.l0 <- v3429
        let v3430 : string = "result2"
        let v3431 : string = $"{v3430}"
        let v3434 : string = v3423.l0
        let v3435 : string = v3434 + v3431 
        v3423.l0 <- v3435
        let v3436 : string = " = "
        let v3437 : string = $"{v3436}"
        let v3440 : string = v3423.l0
        let v3441 : string = v3440 + v3437 
        v3423.l0 <- v3441
        let v3442 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3443 : string = "format!(\"{:#?}\", $0)"
        let v3444 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2842 v3443 
        let v3445 : string = "fable_library_rust::String_::fromString($0)"
        let v3446 : string = Fable.Core.RustInterop.emitRustExpr v3444 v3445 
        let _v3442 = v3446 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3447 : string = "format!(\"{:#?}\", $0)"
        let v3448 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2842 v3447 
        let v3449 : string = "fable_library_rust::String_::fromString($0)"
        let v3450 : string = Fable.Core.RustInterop.emitRustExpr v3448 v3449 
        let _v3442 = v3450 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3451 : string = "format!(\"{:#?}\", $0)"
        let v3452 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2842 v3451 
        let v3453 : string = "fable_library_rust::String_::fromString($0)"
        let v3454 : string = Fable.Core.RustInterop.emitRustExpr v3452 v3453 
        let _v3442 = v3454 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3455 : string = $"%A{v2842}"
        let _v3442 = v3455 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3458 : string = $"%A{v2842}"
        let _v3442 = v3458 
        #endif
#else
        let v3461 : string = $"%A{v2842}"
        let _v3442 = v3461 
        #endif
        let v3464 : string = _v3442 
        let v3469 : string = $"{v3464}"
        let v3472 : string = v3423.l0
        let v3473 : string = v3472 + v3469 
        v3423.l0 <- v3473
        let v3474 : string = " }"
        let v3475 : string = $"{v3474}"
        let v3478 : string = v3423.l0
        let v3479 : string = v3478 + v3475 
        v3423.l0 <- v3479
        let v3480 : string = v3423.l0
        let v3481 : (unit -> string) = closure9()
        let v3482 : string = $"{v3285} {v3415} #{v3421} %s{v3481 ()} / {v3480}"
        let v3485 : char list = []
        let v3486 : (char list -> (char [])) = List.toArray
        let v3487 : (char []) = v3486 v3485
        let v3490 : string = v3482.TrimStart v3487 
        let v3508 : char list = []
        let v3509 : char list = '/' :: v3508 
        let v3512 : char list = ' ' :: v3509 
        let v3515 : (char list -> (char [])) = List.toArray
        let v3516 : (char []) = v3515 v3512
        let v3519 : string = v3490.TrimEnd v3516 
        let v3537 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3538 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v3519 v3538 
        let _v3537 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3539 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v3519 v3539 
        let _v3537 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3540 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v3519 v3540 
        let _v3537 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v3519 
        let _v3537 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v3519 
        let _v3537 = () 
        #endif
#else
        System.Console.WriteLine v3519 
        let _v3537 = () 
        #endif
        _v3537 
        let v3541 : (string -> unit) = v2856.l0
        v3541 v3519
    let v3542 : near_workspaces_result_ExecutionFinalResult = method12(v2124)
    let v3543 : string = "v3542.receipt_failures()"
    let v3544 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v3543 
    let v3545 : bool = State.trace_state.IsNone
    if v3545 then
        let v3546 : US0 = US0_0
        let struct (v3547 : Mut0, v3548 : Mut1, v3549 : Mut2, v3550 : Mut3, v3551 : int64 option) = method0(v3546)
        let v3552 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3547, v3548, v3549, v3550, v3551) 
        State.trace_state <- v3552 
        ()
    let struct (v3557 : Mut0, v3558 : Mut1, v3559 : Mut2, v3560 : Mut3, v3561 : int64 option) = State.trace_state.Value
    let v3572 : bool = State.trace_state.IsNone
    if v3572 then
        let v3573 : US0 = US0_0
        let struct (v3574 : Mut0, v3575 : Mut1, v3576 : Mut2, v3577 : Mut3, v3578 : int64 option) = method0(v3573)
        let v3579 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3574, v3575, v3576, v3577, v3578) 
        State.trace_state <- v3579 
        ()
    let struct (v3584 : Mut0, v3585 : Mut1, v3586 : Mut2, v3587 : Mut3, v3588 : int64 option) = State.trace_state.Value
    let v3599 : US0 = v3587.l0
    let v3600 : bool = v3586.l0
    let v3601 : bool = v3600 = false
    let v3604 : bool =
        if v3601 then
            false
        else
            let v3602 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v3599
            let v3603 : bool = 1 >= v3602
            v3603
    if v3604 then
        let v3605 : int64 = v3557.l0
        let v3606 : int64 = v3605 + 1L
        v3557.l0 <- v3606
        let v3607 : bool = State.trace_state.IsNone
        if v3607 then
            let v3608 : US0 = US0_0
            let struct (v3609 : Mut0, v3610 : Mut1, v3611 : Mut2, v3612 : Mut3, v3613 : int64 option) = method0(v3608)
            let v3614 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3609, v3610, v3611, v3612, v3613) 
            State.trace_state <- v3614 
            ()
        let struct (v3619 : Mut0, v3620 : Mut1, v3621 : Mut2, v3622 : Mut3, v3623 : int64 option) = State.trace_state.Value
        let v3634 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3635 : US3 option = None
        let _v3635 = ref v3635 
        match v3623 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3636 : int64 = x
        let v3637 : US3 = US3_0(v3636)
        v3637 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3635.Value <- x
        let v3638 : US3 option = _v3635.Value 
        let v3649 : US3 = US3_1
        let v3650 : US3 = v3638 |> Option.defaultValue v3649 
        let v3690 : System.DateTime =
            match v3650 with
            | US3_1 -> (* None *)
                let v3686 : System.DateTime = System.DateTime.Now
                v3686
            | US3_0(v3654) -> (* Some *)
                let v3655 : System.DateTime = System.DateTime.Now
                let v3658 : (System.DateTime -> int64) = _.Ticks
                let v3659 : int64 = v3658 v3655
                let v3662 : int64 = v3659 - v3654
                let v3663 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3664 : System.TimeSpan = v3663 v3662
                let v3667 : (System.TimeSpan -> int32) = _.Hours
                let v3668 : int32 = v3667 v3664
                let v3671 : (System.TimeSpan -> int32) = _.Minutes
                let v3672 : int32 = v3671 v3664
                let v3675 : (System.TimeSpan -> int32) = _.Seconds
                let v3676 : int32 = v3675 v3664
                let v3679 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3680 : int32 = v3679 v3664
                let v3683 : System.DateTime = System.DateTime (1, 1, 1, v3668, v3672, v3676, v3680)
                v3683
        let v3691 : string = method5()
        let v3694 : (string -> string) = v3690.ToString
        let v3695 : string = v3694 v3691
        let _v3634 = v3695 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3698 : US3 option = None
        let _v3698 = ref v3698 
        match v3623 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3699 : int64 = x
        let v3700 : US3 = US3_0(v3699)
        v3700 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3698.Value <- x
        let v3701 : US3 option = _v3698.Value 
        let v3712 : US3 = US3_1
        let v3713 : US3 = v3701 |> Option.defaultValue v3712 
        let v3753 : System.DateTime =
            match v3713 with
            | US3_1 -> (* None *)
                let v3749 : System.DateTime = System.DateTime.Now
                v3749
            | US3_0(v3717) -> (* Some *)
                let v3718 : System.DateTime = System.DateTime.Now
                let v3721 : (System.DateTime -> int64) = _.Ticks
                let v3722 : int64 = v3721 v3718
                let v3725 : int64 = v3722 - v3717
                let v3726 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3727 : System.TimeSpan = v3726 v3725
                let v3730 : (System.TimeSpan -> int32) = _.Hours
                let v3731 : int32 = v3730 v3727
                let v3734 : (System.TimeSpan -> int32) = _.Minutes
                let v3735 : int32 = v3734 v3727
                let v3738 : (System.TimeSpan -> int32) = _.Seconds
                let v3739 : int32 = v3738 v3727
                let v3742 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3743 : int32 = v3742 v3727
                let v3746 : System.DateTime = System.DateTime (1, 1, 1, v3731, v3735, v3739, v3743)
                v3746
        let v3754 : string = method5()
        let v3757 : (string -> string) = v3753.ToString
        let v3758 : string = v3757 v3754
        let _v3634 = v3758 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3761 : string = $"near_sdk::env::block_timestamp()"
        let v3762 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3761 
        let v3763 : US3 option = None
        let _v3763 = ref v3763 
        match v3623 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3764 : int64 = x
        let v3765 : US3 = US3_0(v3764)
        v3765 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3763.Value <- x
        let v3766 : US3 option = _v3763.Value 
        let v3777 : US3 = US3_1
        let v3778 : US3 = v3766 |> Option.defaultValue v3777 
        let v3787 : uint64 =
            match v3778 with
            | US3_1 -> (* None *)
                v3762
            | US3_0(v3782) -> (* Some *)
                let v3783 : (int64 -> uint64) = uint64
                let v3784 : uint64 = v3783 v3782
                let v3785 : uint64 = v3762 - v3784
                v3785
        let v3788 : uint64 = v3787 / 1000000000UL
        let v3789 : uint64 = v3788 % 60UL
        let v3790 : uint64 = v3788 / 60UL
        let v3791 : uint64 = v3790 % 60UL
        let v3792 : uint64 = v3788 / 3600UL
        let v3793 : uint64 = v3792 % 24UL
        let v3794 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v3795 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3793, v3791, v3789) v3794 
        let v3796 : string = "fable_library_rust::String_::fromString($0)"
        let v3797 : string = Fable.Core.RustInterop.emitRustExpr v3795 v3796 
        let _v3634 = v3797 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3798 : US3 option = None
        let _v3798 = ref v3798 
        match v3623 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3799 : int64 = x
        let v3800 : US3 = US3_0(v3799)
        v3800 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3798.Value <- x
        let v3801 : US3 option = _v3798.Value 
        let v3812 : US3 = US3_1
        let v3813 : US3 = v3801 |> Option.defaultValue v3812 
        let v3853 : System.DateTime =
            match v3813 with
            | US3_1 -> (* None *)
                let v3849 : System.DateTime = System.DateTime.Now
                v3849
            | US3_0(v3817) -> (* Some *)
                let v3818 : System.DateTime = System.DateTime.Now
                let v3821 : (System.DateTime -> int64) = _.Ticks
                let v3822 : int64 = v3821 v3818
                let v3825 : int64 = v3822 - v3817
                let v3826 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3827 : System.TimeSpan = v3826 v3825
                let v3830 : (System.TimeSpan -> int32) = _.Hours
                let v3831 : int32 = v3830 v3827
                let v3834 : (System.TimeSpan -> int32) = _.Minutes
                let v3835 : int32 = v3834 v3827
                let v3838 : (System.TimeSpan -> int32) = _.Seconds
                let v3839 : int32 = v3838 v3827
                let v3842 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3843 : int32 = v3842 v3827
                let v3846 : System.DateTime = System.DateTime (1, 1, 1, v3831, v3835, v3839, v3843)
                v3846
        let v3854 : string = method6()
        let v3857 : (string -> string) = v3853.ToString
        let v3858 : string = v3857 v3854
        let _v3634 = v3858 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3861 : US3 option = None
        let _v3861 = ref v3861 
        match v3623 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3862 : int64 = x
        let v3863 : US3 = US3_0(v3862)
        v3863 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3861.Value <- x
        let v3864 : US3 option = _v3861.Value 
        let v3875 : US3 = US3_1
        let v3876 : US3 = v3864 |> Option.defaultValue v3875 
        let v3916 : System.DateTime =
            match v3876 with
            | US3_1 -> (* None *)
                let v3912 : System.DateTime = System.DateTime.Now
                v3912
            | US3_0(v3880) -> (* Some *)
                let v3881 : System.DateTime = System.DateTime.Now
                let v3884 : (System.DateTime -> int64) = _.Ticks
                let v3885 : int64 = v3884 v3881
                let v3888 : int64 = v3885 - v3880
                let v3889 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3890 : System.TimeSpan = v3889 v3888
                let v3893 : (System.TimeSpan -> int32) = _.Hours
                let v3894 : int32 = v3893 v3890
                let v3897 : (System.TimeSpan -> int32) = _.Minutes
                let v3898 : int32 = v3897 v3890
                let v3901 : (System.TimeSpan -> int32) = _.Seconds
                let v3902 : int32 = v3901 v3890
                let v3905 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3906 : int32 = v3905 v3890
                let v3909 : System.DateTime = System.DateTime (1, 1, 1, v3894, v3898, v3902, v3906)
                v3909
        let v3917 : string = method6()
        let v3920 : (string -> string) = v3916.ToString
        let v3921 : string = v3920 v3917
        let _v3634 = v3921 
        #endif
#else
        let v3924 : US3 option = None
        let _v3924 = ref v3924 
        match v3623 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3925 : int64 = x
        let v3926 : US3 = US3_0(v3925)
        v3926 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3924.Value <- x
        let v3927 : US3 option = _v3924.Value 
        let v3938 : US3 = US3_1
        let v3939 : US3 = v3927 |> Option.defaultValue v3938 
        let v3979 : System.DateTime =
            match v3939 with
            | US3_1 -> (* None *)
                let v3975 : System.DateTime = System.DateTime.Now
                v3975
            | US3_0(v3943) -> (* Some *)
                let v3944 : System.DateTime = System.DateTime.Now
                let v3947 : (System.DateTime -> int64) = _.Ticks
                let v3948 : int64 = v3947 v3944
                let v3951 : int64 = v3948 - v3943
                let v3952 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3953 : System.TimeSpan = v3952 v3951
                let v3956 : (System.TimeSpan -> int32) = _.Hours
                let v3957 : int32 = v3956 v3953
                let v3960 : (System.TimeSpan -> int32) = _.Minutes
                let v3961 : int32 = v3960 v3953
                let v3964 : (System.TimeSpan -> int32) = _.Seconds
                let v3965 : int32 = v3964 v3953
                let v3968 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3969 : int32 = v3968 v3953
                let v3972 : System.DateTime = System.DateTime (1, 1, 1, v3957, v3961, v3965, v3969)
                v3972
        let v3980 : string = method6()
        let v3983 : (string -> string) = v3979.ToString
        let v3984 : string = v3983 v3980
        let _v3634 = v3984 
        #endif
        let v3987 : string = _v3634 
        let v4052 : string = "Debug"
        let v4053 : (unit -> string) = v4052.ToLower
        let v4054 : string = v4053 ()
        let v4057 : string = v4054.PadLeft (7, ' ')
        let v4071 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4072 : string = "inline_colorization::color_bright_blue"
        let v4073 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4072 
        let v4074 : string = "&*$0"
        let v4075 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4057 v4074 
        let v4076 : string = "inline_colorization::color_reset"
        let v4077 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4076 
        let v4078 : string = "\"{v4073}{v4075}{v4077}\""
        let v4079 : string = @$"format!(" + v4078 + ")"
        let v4080 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4079 
        let v4081 : string = "fable_library_rust::String_::fromString($0)"
        let v4082 : string = Fable.Core.RustInterop.emitRustExpr v4080 v4081 
        let _v4071 = v4082 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4083 : string = "inline_colorization::color_bright_blue"
        let v4084 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4083 
        let v4085 : string = "&*$0"
        let v4086 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4057 v4085 
        let v4087 : string = "inline_colorization::color_reset"
        let v4088 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4087 
        let v4089 : string = "\"{v4084}{v4086}{v4088}\""
        let v4090 : string = @$"format!(" + v4089 + ")"
        let v4091 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4090 
        let v4092 : string = "fable_library_rust::String_::fromString($0)"
        let v4093 : string = Fable.Core.RustInterop.emitRustExpr v4091 v4092 
        let _v4071 = v4093 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4094 : string = "inline_colorization::color_bright_blue"
        let v4095 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4094 
        let v4096 : string = "&*$0"
        let v4097 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4057 v4096 
        let v4098 : string = "inline_colorization::color_reset"
        let v4099 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4098 
        let v4100 : string = "\"{v4095}{v4097}{v4099}\""
        let v4101 : string = @$"format!(" + v4100 + ")"
        let v4102 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4101 
        let v4103 : string = "fable_library_rust::String_::fromString($0)"
        let v4104 : string = Fable.Core.RustInterop.emitRustExpr v4102 v4103 
        let _v4071 = v4104 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4105 : string = "\u001b[94m"
        let v4106 : string = method7()
        let v4107 : string = v4105 + v4057 
        let v4108 : string = v4107 + v4106 
        let _v4071 = v4108 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4109 : string = "\u001b[94m"
        let v4110 : string = method7()
        let v4111 : string = v4109 + v4057 
        let v4112 : string = v4111 + v4110 
        let _v4071 = v4112 
        #endif
#else
        let v4113 : string = "\u001b[94m"
        let v4114 : string = method7()
        let v4115 : string = v4113 + v4057 
        let v4116 : string = v4115 + v4114 
        let _v4071 = v4116 
        #endif
        let v4117 : string = _v4071 
        let v4123 : int64 = v3619.l0
        let v4124 : string = method8()
        let v4125 : Mut4 = {l0 = v4124} : Mut4
        let v4126 : string = "{ "
        let v4127 : string = $"{v4126}"
        let v4130 : string = v4125.l0
        let v4131 : string = v4130 + v4127 
        v4125.l0 <- v4131
        let v4132 : string = "receipt_failures"
        let v4133 : string = $"{v4132}"
        let v4136 : string = v4125.l0
        let v4137 : string = v4136 + v4133 
        v4125.l0 <- v4137
        let v4138 : string = " = "
        let v4139 : string = $"{v4138}"
        let v4142 : string = v4125.l0
        let v4143 : string = v4142 + v4139 
        v4125.l0 <- v4143
        let v4144 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4145 : string = "format!(\"{:#?}\", $0)"
        let v4146 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3544 v4145 
        let v4147 : string = "fable_library_rust::String_::fromString($0)"
        let v4148 : string = Fable.Core.RustInterop.emitRustExpr v4146 v4147 
        let _v4144 = v4148 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4149 : string = "format!(\"{:#?}\", $0)"
        let v4150 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3544 v4149 
        let v4151 : string = "fable_library_rust::String_::fromString($0)"
        let v4152 : string = Fable.Core.RustInterop.emitRustExpr v4150 v4151 
        let _v4144 = v4152 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4153 : string = "format!(\"{:#?}\", $0)"
        let v4154 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3544 v4153 
        let v4155 : string = "fable_library_rust::String_::fromString($0)"
        let v4156 : string = Fable.Core.RustInterop.emitRustExpr v4154 v4155 
        let _v4144 = v4156 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4157 : string = $"%A{v3544}"
        let _v4144 = v4157 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4160 : string = $"%A{v3544}"
        let _v4144 = v4160 
        #endif
#else
        let v4163 : string = $"%A{v3544}"
        let _v4144 = v4163 
        #endif
        let v4166 : string = _v4144 
        let v4171 : string = $"{v4166}"
        let v4174 : string = v4125.l0
        let v4175 : string = v4174 + v4171 
        v4125.l0 <- v4175
        let v4176 : string = " }"
        let v4177 : string = $"{v4176}"
        let v4180 : string = v4125.l0
        let v4181 : string = v4180 + v4177 
        v4125.l0 <- v4181
        let v4182 : string = v4125.l0
        let v4183 : (unit -> string) = closure10()
        let v4184 : string = $"{v3987} {v4117} #{v4123} %s{v4183 ()} / {v4182}"
        let v4187 : char list = []
        let v4188 : (char list -> (char [])) = List.toArray
        let v4189 : (char []) = v4188 v4187
        let v4192 : string = v4184.TrimStart v4189 
        let v4210 : char list = []
        let v4211 : char list = '/' :: v4210 
        let v4214 : char list = ' ' :: v4211 
        let v4217 : (char list -> (char [])) = List.toArray
        let v4218 : (char []) = v4217 v4214
        let v4221 : string = v4192.TrimEnd v4218 
        let v4239 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4240 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v4221 v4240 
        let _v4239 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4241 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v4221 v4241 
        let _v4239 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4242 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v4221 v4242 
        let _v4239 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v4221 
        let _v4239 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v4221 
        let _v4239 = () 
        #endif
#else
        System.Console.WriteLine v4221 
        let _v4239 = () 
        #endif
        _v4239 
        let v4243 : (string -> unit) = v3558.l0
        v4243 v4221
    let v4244 : near_workspaces_result_ExecutionFinalResult = method13(v2124)
    let v4245 : string = "v4244.receipt_outcomes()"
    let v4246 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v4245 
    let v4247 : bool = State.trace_state.IsNone
    if v4247 then
        let v4248 : US0 = US0_0
        let struct (v4249 : Mut0, v4250 : Mut1, v4251 : Mut2, v4252 : Mut3, v4253 : int64 option) = method0(v4248)
        let v4254 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v4249, v4250, v4251, v4252, v4253) 
        State.trace_state <- v4254 
        ()
    let struct (v4259 : Mut0, v4260 : Mut1, v4261 : Mut2, v4262 : Mut3, v4263 : int64 option) = State.trace_state.Value
    let v4274 : bool = State.trace_state.IsNone
    if v4274 then
        let v4275 : US0 = US0_0
        let struct (v4276 : Mut0, v4277 : Mut1, v4278 : Mut2, v4279 : Mut3, v4280 : int64 option) = method0(v4275)
        let v4281 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v4276, v4277, v4278, v4279, v4280) 
        State.trace_state <- v4281 
        ()
    let struct (v4286 : Mut0, v4287 : Mut1, v4288 : Mut2, v4289 : Mut3, v4290 : int64 option) = State.trace_state.Value
    let v4301 : US0 = v4289.l0
    let v4302 : bool = v4288.l0
    let v4303 : bool = v4302 = false
    let v4306 : bool =
        if v4303 then
            false
        else
            let v4304 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v4301
            let v4305 : bool = 1 >= v4304
            v4305
    if v4306 then
        let v4307 : int64 = v4259.l0
        let v4308 : int64 = v4307 + 1L
        v4259.l0 <- v4308
        let v4309 : bool = State.trace_state.IsNone
        if v4309 then
            let v4310 : US0 = US0_0
            let struct (v4311 : Mut0, v4312 : Mut1, v4313 : Mut2, v4314 : Mut3, v4315 : int64 option) = method0(v4310)
            let v4316 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v4311, v4312, v4313, v4314, v4315) 
            State.trace_state <- v4316 
            ()
        let struct (v4321 : Mut0, v4322 : Mut1, v4323 : Mut2, v4324 : Mut3, v4325 : int64 option) = State.trace_state.Value
        let v4336 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4337 : US3 option = None
        let _v4337 = ref v4337 
        match v4325 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4338 : int64 = x
        let v4339 : US3 = US3_0(v4338)
        v4339 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4337.Value <- x
        let v4340 : US3 option = _v4337.Value 
        let v4351 : US3 = US3_1
        let v4352 : US3 = v4340 |> Option.defaultValue v4351 
        let v4392 : System.DateTime =
            match v4352 with
            | US3_1 -> (* None *)
                let v4388 : System.DateTime = System.DateTime.Now
                v4388
            | US3_0(v4356) -> (* Some *)
                let v4357 : System.DateTime = System.DateTime.Now
                let v4360 : (System.DateTime -> int64) = _.Ticks
                let v4361 : int64 = v4360 v4357
                let v4364 : int64 = v4361 - v4356
                let v4365 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4366 : System.TimeSpan = v4365 v4364
                let v4369 : (System.TimeSpan -> int32) = _.Hours
                let v4370 : int32 = v4369 v4366
                let v4373 : (System.TimeSpan -> int32) = _.Minutes
                let v4374 : int32 = v4373 v4366
                let v4377 : (System.TimeSpan -> int32) = _.Seconds
                let v4378 : int32 = v4377 v4366
                let v4381 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4382 : int32 = v4381 v4366
                let v4385 : System.DateTime = System.DateTime (1, 1, 1, v4370, v4374, v4378, v4382)
                v4385
        let v4393 : string = method5()
        let v4396 : (string -> string) = v4392.ToString
        let v4397 : string = v4396 v4393
        let _v4336 = v4397 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4400 : US3 option = None
        let _v4400 = ref v4400 
        match v4325 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4401 : int64 = x
        let v4402 : US3 = US3_0(v4401)
        v4402 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4400.Value <- x
        let v4403 : US3 option = _v4400.Value 
        let v4414 : US3 = US3_1
        let v4415 : US3 = v4403 |> Option.defaultValue v4414 
        let v4455 : System.DateTime =
            match v4415 with
            | US3_1 -> (* None *)
                let v4451 : System.DateTime = System.DateTime.Now
                v4451
            | US3_0(v4419) -> (* Some *)
                let v4420 : System.DateTime = System.DateTime.Now
                let v4423 : (System.DateTime -> int64) = _.Ticks
                let v4424 : int64 = v4423 v4420
                let v4427 : int64 = v4424 - v4419
                let v4428 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4429 : System.TimeSpan = v4428 v4427
                let v4432 : (System.TimeSpan -> int32) = _.Hours
                let v4433 : int32 = v4432 v4429
                let v4436 : (System.TimeSpan -> int32) = _.Minutes
                let v4437 : int32 = v4436 v4429
                let v4440 : (System.TimeSpan -> int32) = _.Seconds
                let v4441 : int32 = v4440 v4429
                let v4444 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4445 : int32 = v4444 v4429
                let v4448 : System.DateTime = System.DateTime (1, 1, 1, v4433, v4437, v4441, v4445)
                v4448
        let v4456 : string = method5()
        let v4459 : (string -> string) = v4455.ToString
        let v4460 : string = v4459 v4456
        let _v4336 = v4460 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4463 : string = $"near_sdk::env::block_timestamp()"
        let v4464 : uint64 = Fable.Core.RustInterop.emitRustExpr () v4463 
        let v4465 : US3 option = None
        let _v4465 = ref v4465 
        match v4325 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4466 : int64 = x
        let v4467 : US3 = US3_0(v4466)
        v4467 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4465.Value <- x
        let v4468 : US3 option = _v4465.Value 
        let v4479 : US3 = US3_1
        let v4480 : US3 = v4468 |> Option.defaultValue v4479 
        let v4489 : uint64 =
            match v4480 with
            | US3_1 -> (* None *)
                v4464
            | US3_0(v4484) -> (* Some *)
                let v4485 : (int64 -> uint64) = uint64
                let v4486 : uint64 = v4485 v4484
                let v4487 : uint64 = v4464 - v4486
                v4487
        let v4490 : uint64 = v4489 / 1000000000UL
        let v4491 : uint64 = v4490 % 60UL
        let v4492 : uint64 = v4490 / 60UL
        let v4493 : uint64 = v4492 % 60UL
        let v4494 : uint64 = v4490 / 3600UL
        let v4495 : uint64 = v4494 % 24UL
        let v4496 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v4497 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v4495, v4493, v4491) v4496 
        let v4498 : string = "fable_library_rust::String_::fromString($0)"
        let v4499 : string = Fable.Core.RustInterop.emitRustExpr v4497 v4498 
        let _v4336 = v4499 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4500 : US3 option = None
        let _v4500 = ref v4500 
        match v4325 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4501 : int64 = x
        let v4502 : US3 = US3_0(v4501)
        v4502 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4500.Value <- x
        let v4503 : US3 option = _v4500.Value 
        let v4514 : US3 = US3_1
        let v4515 : US3 = v4503 |> Option.defaultValue v4514 
        let v4555 : System.DateTime =
            match v4515 with
            | US3_1 -> (* None *)
                let v4551 : System.DateTime = System.DateTime.Now
                v4551
            | US3_0(v4519) -> (* Some *)
                let v4520 : System.DateTime = System.DateTime.Now
                let v4523 : (System.DateTime -> int64) = _.Ticks
                let v4524 : int64 = v4523 v4520
                let v4527 : int64 = v4524 - v4519
                let v4528 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4529 : System.TimeSpan = v4528 v4527
                let v4532 : (System.TimeSpan -> int32) = _.Hours
                let v4533 : int32 = v4532 v4529
                let v4536 : (System.TimeSpan -> int32) = _.Minutes
                let v4537 : int32 = v4536 v4529
                let v4540 : (System.TimeSpan -> int32) = _.Seconds
                let v4541 : int32 = v4540 v4529
                let v4544 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4545 : int32 = v4544 v4529
                let v4548 : System.DateTime = System.DateTime (1, 1, 1, v4533, v4537, v4541, v4545)
                v4548
        let v4556 : string = method6()
        let v4559 : (string -> string) = v4555.ToString
        let v4560 : string = v4559 v4556
        let _v4336 = v4560 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4563 : US3 option = None
        let _v4563 = ref v4563 
        match v4325 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4564 : int64 = x
        let v4565 : US3 = US3_0(v4564)
        v4565 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4563.Value <- x
        let v4566 : US3 option = _v4563.Value 
        let v4577 : US3 = US3_1
        let v4578 : US3 = v4566 |> Option.defaultValue v4577 
        let v4618 : System.DateTime =
            match v4578 with
            | US3_1 -> (* None *)
                let v4614 : System.DateTime = System.DateTime.Now
                v4614
            | US3_0(v4582) -> (* Some *)
                let v4583 : System.DateTime = System.DateTime.Now
                let v4586 : (System.DateTime -> int64) = _.Ticks
                let v4587 : int64 = v4586 v4583
                let v4590 : int64 = v4587 - v4582
                let v4591 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4592 : System.TimeSpan = v4591 v4590
                let v4595 : (System.TimeSpan -> int32) = _.Hours
                let v4596 : int32 = v4595 v4592
                let v4599 : (System.TimeSpan -> int32) = _.Minutes
                let v4600 : int32 = v4599 v4592
                let v4603 : (System.TimeSpan -> int32) = _.Seconds
                let v4604 : int32 = v4603 v4592
                let v4607 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4608 : int32 = v4607 v4592
                let v4611 : System.DateTime = System.DateTime (1, 1, 1, v4596, v4600, v4604, v4608)
                v4611
        let v4619 : string = method6()
        let v4622 : (string -> string) = v4618.ToString
        let v4623 : string = v4622 v4619
        let _v4336 = v4623 
        #endif
#else
        let v4626 : US3 option = None
        let _v4626 = ref v4626 
        match v4325 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4627 : int64 = x
        let v4628 : US3 = US3_0(v4627)
        v4628 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4626.Value <- x
        let v4629 : US3 option = _v4626.Value 
        let v4640 : US3 = US3_1
        let v4641 : US3 = v4629 |> Option.defaultValue v4640 
        let v4681 : System.DateTime =
            match v4641 with
            | US3_1 -> (* None *)
                let v4677 : System.DateTime = System.DateTime.Now
                v4677
            | US3_0(v4645) -> (* Some *)
                let v4646 : System.DateTime = System.DateTime.Now
                let v4649 : (System.DateTime -> int64) = _.Ticks
                let v4650 : int64 = v4649 v4646
                let v4653 : int64 = v4650 - v4645
                let v4654 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4655 : System.TimeSpan = v4654 v4653
                let v4658 : (System.TimeSpan -> int32) = _.Hours
                let v4659 : int32 = v4658 v4655
                let v4662 : (System.TimeSpan -> int32) = _.Minutes
                let v4663 : int32 = v4662 v4655
                let v4666 : (System.TimeSpan -> int32) = _.Seconds
                let v4667 : int32 = v4666 v4655
                let v4670 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4671 : int32 = v4670 v4655
                let v4674 : System.DateTime = System.DateTime (1, 1, 1, v4659, v4663, v4667, v4671)
                v4674
        let v4682 : string = method6()
        let v4685 : (string -> string) = v4681.ToString
        let v4686 : string = v4685 v4682
        let _v4336 = v4686 
        #endif
        let v4689 : string = _v4336 
        let v4754 : string = "Debug"
        let v4755 : (unit -> string) = v4754.ToLower
        let v4756 : string = v4755 ()
        let v4759 : string = v4756.PadLeft (7, ' ')
        let v4773 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4774 : string = "inline_colorization::color_bright_blue"
        let v4775 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4774 
        let v4776 : string = "&*$0"
        let v4777 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4759 v4776 
        let v4778 : string = "inline_colorization::color_reset"
        let v4779 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4778 
        let v4780 : string = "\"{v4775}{v4777}{v4779}\""
        let v4781 : string = @$"format!(" + v4780 + ")"
        let v4782 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4781 
        let v4783 : string = "fable_library_rust::String_::fromString($0)"
        let v4784 : string = Fable.Core.RustInterop.emitRustExpr v4782 v4783 
        let _v4773 = v4784 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4785 : string = "inline_colorization::color_bright_blue"
        let v4786 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4785 
        let v4787 : string = "&*$0"
        let v4788 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4759 v4787 
        let v4789 : string = "inline_colorization::color_reset"
        let v4790 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4789 
        let v4791 : string = "\"{v4786}{v4788}{v4790}\""
        let v4792 : string = @$"format!(" + v4791 + ")"
        let v4793 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4792 
        let v4794 : string = "fable_library_rust::String_::fromString($0)"
        let v4795 : string = Fable.Core.RustInterop.emitRustExpr v4793 v4794 
        let _v4773 = v4795 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4796 : string = "inline_colorization::color_bright_blue"
        let v4797 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4796 
        let v4798 : string = "&*$0"
        let v4799 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4759 v4798 
        let v4800 : string = "inline_colorization::color_reset"
        let v4801 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4800 
        let v4802 : string = "\"{v4797}{v4799}{v4801}\""
        let v4803 : string = @$"format!(" + v4802 + ")"
        let v4804 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4803 
        let v4805 : string = "fable_library_rust::String_::fromString($0)"
        let v4806 : string = Fable.Core.RustInterop.emitRustExpr v4804 v4805 
        let _v4773 = v4806 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4807 : string = "\u001b[94m"
        let v4808 : string = method7()
        let v4809 : string = v4807 + v4759 
        let v4810 : string = v4809 + v4808 
        let _v4773 = v4810 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4811 : string = "\u001b[94m"
        let v4812 : string = method7()
        let v4813 : string = v4811 + v4759 
        let v4814 : string = v4813 + v4812 
        let _v4773 = v4814 
        #endif
#else
        let v4815 : string = "\u001b[94m"
        let v4816 : string = method7()
        let v4817 : string = v4815 + v4759 
        let v4818 : string = v4817 + v4816 
        let _v4773 = v4818 
        #endif
        let v4819 : string = _v4773 
        let v4825 : int64 = v4321.l0
        let v4826 : string = method8()
        let v4827 : Mut4 = {l0 = v4826} : Mut4
        let v4828 : string = "{ "
        let v4829 : string = $"{v4828}"
        let v4832 : string = v4827.l0
        let v4833 : string = v4832 + v4829 
        v4827.l0 <- v4833
        let v4834 : string = "receipt_outcomes"
        let v4835 : string = $"{v4834}"
        let v4838 : string = v4827.l0
        let v4839 : string = v4838 + v4835 
        v4827.l0 <- v4839
        let v4840 : string = " = "
        let v4841 : string = $"{v4840}"
        let v4844 : string = v4827.l0
        let v4845 : string = v4844 + v4841 
        v4827.l0 <- v4845
        let v4846 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4847 : string = "format!(\"{:#?}\", $0)"
        let v4848 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4246 v4847 
        let v4849 : string = "fable_library_rust::String_::fromString($0)"
        let v4850 : string = Fable.Core.RustInterop.emitRustExpr v4848 v4849 
        let _v4846 = v4850 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4851 : string = "format!(\"{:#?}\", $0)"
        let v4852 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4246 v4851 
        let v4853 : string = "fable_library_rust::String_::fromString($0)"
        let v4854 : string = Fable.Core.RustInterop.emitRustExpr v4852 v4853 
        let _v4846 = v4854 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4855 : string = "format!(\"{:#?}\", $0)"
        let v4856 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4246 v4855 
        let v4857 : string = "fable_library_rust::String_::fromString($0)"
        let v4858 : string = Fable.Core.RustInterop.emitRustExpr v4856 v4857 
        let _v4846 = v4858 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4859 : string = $"%A{v4246}"
        let _v4846 = v4859 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4862 : string = $"%A{v4246}"
        let _v4846 = v4862 
        #endif
#else
        let v4865 : string = $"%A{v4246}"
        let _v4846 = v4865 
        #endif
        let v4868 : string = _v4846 
        let v4873 : string = $"{v4868}"
        let v4876 : string = v4827.l0
        let v4877 : string = v4876 + v4873 
        v4827.l0 <- v4877
        let v4878 : string = " }"
        let v4879 : string = $"{v4878}"
        let v4882 : string = v4827.l0
        let v4883 : string = v4882 + v4879 
        v4827.l0 <- v4883
        let v4884 : string = v4827.l0
        let v4885 : (unit -> string) = closure11()
        let v4886 : string = $"{v4689} {v4819} #{v4825} %s{v4885 ()} / {v4884}"
        let v4889 : char list = []
        let v4890 : (char list -> (char [])) = List.toArray
        let v4891 : (char []) = v4890 v4889
        let v4894 : string = v4886.TrimStart v4891 
        let v4912 : char list = []
        let v4913 : char list = '/' :: v4912 
        let v4916 : char list = ' ' :: v4913 
        let v4919 : (char list -> (char [])) = List.toArray
        let v4920 : (char []) = v4919 v4916
        let v4923 : string = v4894.TrimEnd v4920 
        let v4941 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4942 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v4923 v4942 
        let _v4941 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4943 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v4923 v4943 
        let _v4941 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4944 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v4923 v4944 
        let _v4941 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v4923 
        let _v4941 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v4923 
        let _v4941 = () 
        #endif
#else
        System.Console.WriteLine v4923 
        let _v4941 = () 
        #endif
        _v4941 
        let v4945 : (string -> unit) = v4260.l0
        v4945 v4923
    let v4946 : string = "$0.json()"
    let v4947 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v2124 v4946 
    let v4948 : bool = State.trace_state.IsNone
    if v4948 then
        let v4949 : US0 = US0_0
        let struct (v4950 : Mut0, v4951 : Mut1, v4952 : Mut2, v4953 : Mut3, v4954 : int64 option) = method0(v4949)
        let v4955 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v4950, v4951, v4952, v4953, v4954) 
        State.trace_state <- v4955 
        ()
    let struct (v4960 : Mut0, v4961 : Mut1, v4962 : Mut2, v4963 : Mut3, v4964 : int64 option) = State.trace_state.Value
    let v4975 : bool = State.trace_state.IsNone
    if v4975 then
        let v4976 : US0 = US0_0
        let struct (v4977 : Mut0, v4978 : Mut1, v4979 : Mut2, v4980 : Mut3, v4981 : int64 option) = method0(v4976)
        let v4982 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v4977, v4978, v4979, v4980, v4981) 
        State.trace_state <- v4982 
        ()
    let struct (v4987 : Mut0, v4988 : Mut1, v4989 : Mut2, v4990 : Mut3, v4991 : int64 option) = State.trace_state.Value
    let v5002 : US0 = v4990.l0
    let v5003 : bool = v4989.l0
    let v5004 : bool = v5003 = false
    let v5007 : bool =
        if v5004 then
            false
        else
            let v5005 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v5002
            let v5006 : bool = 1 >= v5005
            v5006
    if v5007 then
        let v5008 : int64 = v4960.l0
        let v5009 : int64 = v5008 + 1L
        v4960.l0 <- v5009
        let v5010 : bool = State.trace_state.IsNone
        if v5010 then
            let v5011 : US0 = US0_0
            let struct (v5012 : Mut0, v5013 : Mut1, v5014 : Mut2, v5015 : Mut3, v5016 : int64 option) = method0(v5011)
            let v5017 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v5012, v5013, v5014, v5015, v5016) 
            State.trace_state <- v5017 
            ()
        let struct (v5022 : Mut0, v5023 : Mut1, v5024 : Mut2, v5025 : Mut3, v5026 : int64 option) = State.trace_state.Value
        let v5037 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5038 : US3 option = None
        let _v5038 = ref v5038 
        match v5026 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5039 : int64 = x
        let v5040 : US3 = US3_0(v5039)
        v5040 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5038.Value <- x
        let v5041 : US3 option = _v5038.Value 
        let v5052 : US3 = US3_1
        let v5053 : US3 = v5041 |> Option.defaultValue v5052 
        let v5093 : System.DateTime =
            match v5053 with
            | US3_1 -> (* None *)
                let v5089 : System.DateTime = System.DateTime.Now
                v5089
            | US3_0(v5057) -> (* Some *)
                let v5058 : System.DateTime = System.DateTime.Now
                let v5061 : (System.DateTime -> int64) = _.Ticks
                let v5062 : int64 = v5061 v5058
                let v5065 : int64 = v5062 - v5057
                let v5066 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5067 : System.TimeSpan = v5066 v5065
                let v5070 : (System.TimeSpan -> int32) = _.Hours
                let v5071 : int32 = v5070 v5067
                let v5074 : (System.TimeSpan -> int32) = _.Minutes
                let v5075 : int32 = v5074 v5067
                let v5078 : (System.TimeSpan -> int32) = _.Seconds
                let v5079 : int32 = v5078 v5067
                let v5082 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5083 : int32 = v5082 v5067
                let v5086 : System.DateTime = System.DateTime (1, 1, 1, v5071, v5075, v5079, v5083)
                v5086
        let v5094 : string = method5()
        let v5097 : (string -> string) = v5093.ToString
        let v5098 : string = v5097 v5094
        let _v5037 = v5098 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5101 : US3 option = None
        let _v5101 = ref v5101 
        match v5026 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5102 : int64 = x
        let v5103 : US3 = US3_0(v5102)
        v5103 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5101.Value <- x
        let v5104 : US3 option = _v5101.Value 
        let v5115 : US3 = US3_1
        let v5116 : US3 = v5104 |> Option.defaultValue v5115 
        let v5156 : System.DateTime =
            match v5116 with
            | US3_1 -> (* None *)
                let v5152 : System.DateTime = System.DateTime.Now
                v5152
            | US3_0(v5120) -> (* Some *)
                let v5121 : System.DateTime = System.DateTime.Now
                let v5124 : (System.DateTime -> int64) = _.Ticks
                let v5125 : int64 = v5124 v5121
                let v5128 : int64 = v5125 - v5120
                let v5129 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5130 : System.TimeSpan = v5129 v5128
                let v5133 : (System.TimeSpan -> int32) = _.Hours
                let v5134 : int32 = v5133 v5130
                let v5137 : (System.TimeSpan -> int32) = _.Minutes
                let v5138 : int32 = v5137 v5130
                let v5141 : (System.TimeSpan -> int32) = _.Seconds
                let v5142 : int32 = v5141 v5130
                let v5145 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5146 : int32 = v5145 v5130
                let v5149 : System.DateTime = System.DateTime (1, 1, 1, v5134, v5138, v5142, v5146)
                v5149
        let v5157 : string = method5()
        let v5160 : (string -> string) = v5156.ToString
        let v5161 : string = v5160 v5157
        let _v5037 = v5161 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5164 : string = $"near_sdk::env::block_timestamp()"
        let v5165 : uint64 = Fable.Core.RustInterop.emitRustExpr () v5164 
        let v5166 : US3 option = None
        let _v5166 = ref v5166 
        match v5026 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5167 : int64 = x
        let v5168 : US3 = US3_0(v5167)
        v5168 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5166.Value <- x
        let v5169 : US3 option = _v5166.Value 
        let v5180 : US3 = US3_1
        let v5181 : US3 = v5169 |> Option.defaultValue v5180 
        let v5190 : uint64 =
            match v5181 with
            | US3_1 -> (* None *)
                v5165
            | US3_0(v5185) -> (* Some *)
                let v5186 : (int64 -> uint64) = uint64
                let v5187 : uint64 = v5186 v5185
                let v5188 : uint64 = v5165 - v5187
                v5188
        let v5191 : uint64 = v5190 / 1000000000UL
        let v5192 : uint64 = v5191 % 60UL
        let v5193 : uint64 = v5191 / 60UL
        let v5194 : uint64 = v5193 % 60UL
        let v5195 : uint64 = v5191 / 3600UL
        let v5196 : uint64 = v5195 % 24UL
        let v5197 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v5198 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v5196, v5194, v5192) v5197 
        let v5199 : string = "fable_library_rust::String_::fromString($0)"
        let v5200 : string = Fable.Core.RustInterop.emitRustExpr v5198 v5199 
        let _v5037 = v5200 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v5201 : US3 option = None
        let _v5201 = ref v5201 
        match v5026 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5202 : int64 = x
        let v5203 : US3 = US3_0(v5202)
        v5203 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5201.Value <- x
        let v5204 : US3 option = _v5201.Value 
        let v5215 : US3 = US3_1
        let v5216 : US3 = v5204 |> Option.defaultValue v5215 
        let v5256 : System.DateTime =
            match v5216 with
            | US3_1 -> (* None *)
                let v5252 : System.DateTime = System.DateTime.Now
                v5252
            | US3_0(v5220) -> (* Some *)
                let v5221 : System.DateTime = System.DateTime.Now
                let v5224 : (System.DateTime -> int64) = _.Ticks
                let v5225 : int64 = v5224 v5221
                let v5228 : int64 = v5225 - v5220
                let v5229 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5230 : System.TimeSpan = v5229 v5228
                let v5233 : (System.TimeSpan -> int32) = _.Hours
                let v5234 : int32 = v5233 v5230
                let v5237 : (System.TimeSpan -> int32) = _.Minutes
                let v5238 : int32 = v5237 v5230
                let v5241 : (System.TimeSpan -> int32) = _.Seconds
                let v5242 : int32 = v5241 v5230
                let v5245 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5246 : int32 = v5245 v5230
                let v5249 : System.DateTime = System.DateTime (1, 1, 1, v5234, v5238, v5242, v5246)
                v5249
        let v5257 : string = method6()
        let v5260 : (string -> string) = v5256.ToString
        let v5261 : string = v5260 v5257
        let _v5037 = v5261 
        #endif
#if FABLE_COMPILER_PYTHON
        let v5264 : US3 option = None
        let _v5264 = ref v5264 
        match v5026 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5265 : int64 = x
        let v5266 : US3 = US3_0(v5265)
        v5266 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5264.Value <- x
        let v5267 : US3 option = _v5264.Value 
        let v5278 : US3 = US3_1
        let v5279 : US3 = v5267 |> Option.defaultValue v5278 
        let v5319 : System.DateTime =
            match v5279 with
            | US3_1 -> (* None *)
                let v5315 : System.DateTime = System.DateTime.Now
                v5315
            | US3_0(v5283) -> (* Some *)
                let v5284 : System.DateTime = System.DateTime.Now
                let v5287 : (System.DateTime -> int64) = _.Ticks
                let v5288 : int64 = v5287 v5284
                let v5291 : int64 = v5288 - v5283
                let v5292 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5293 : System.TimeSpan = v5292 v5291
                let v5296 : (System.TimeSpan -> int32) = _.Hours
                let v5297 : int32 = v5296 v5293
                let v5300 : (System.TimeSpan -> int32) = _.Minutes
                let v5301 : int32 = v5300 v5293
                let v5304 : (System.TimeSpan -> int32) = _.Seconds
                let v5305 : int32 = v5304 v5293
                let v5308 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5309 : int32 = v5308 v5293
                let v5312 : System.DateTime = System.DateTime (1, 1, 1, v5297, v5301, v5305, v5309)
                v5312
        let v5320 : string = method6()
        let v5323 : (string -> string) = v5319.ToString
        let v5324 : string = v5323 v5320
        let _v5037 = v5324 
        #endif
#else
        let v5327 : US3 option = None
        let _v5327 = ref v5327 
        match v5026 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5328 : int64 = x
        let v5329 : US3 = US3_0(v5328)
        v5329 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5327.Value <- x
        let v5330 : US3 option = _v5327.Value 
        let v5341 : US3 = US3_1
        let v5342 : US3 = v5330 |> Option.defaultValue v5341 
        let v5382 : System.DateTime =
            match v5342 with
            | US3_1 -> (* None *)
                let v5378 : System.DateTime = System.DateTime.Now
                v5378
            | US3_0(v5346) -> (* Some *)
                let v5347 : System.DateTime = System.DateTime.Now
                let v5350 : (System.DateTime -> int64) = _.Ticks
                let v5351 : int64 = v5350 v5347
                let v5354 : int64 = v5351 - v5346
                let v5355 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5356 : System.TimeSpan = v5355 v5354
                let v5359 : (System.TimeSpan -> int32) = _.Hours
                let v5360 : int32 = v5359 v5356
                let v5363 : (System.TimeSpan -> int32) = _.Minutes
                let v5364 : int32 = v5363 v5356
                let v5367 : (System.TimeSpan -> int32) = _.Seconds
                let v5368 : int32 = v5367 v5356
                let v5371 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5372 : int32 = v5371 v5356
                let v5375 : System.DateTime = System.DateTime (1, 1, 1, v5360, v5364, v5368, v5372)
                v5375
        let v5383 : string = method6()
        let v5386 : (string -> string) = v5382.ToString
        let v5387 : string = v5386 v5383
        let _v5037 = v5387 
        #endif
        let v5390 : string = _v5037 
        let v5455 : string = "Debug"
        let v5456 : (unit -> string) = v5455.ToLower
        let v5457 : string = v5456 ()
        let v5460 : string = v5457.PadLeft (7, ' ')
        let v5474 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5475 : string = "inline_colorization::color_bright_blue"
        let v5476 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5475 
        let v5477 : string = "&*$0"
        let v5478 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5460 v5477 
        let v5479 : string = "inline_colorization::color_reset"
        let v5480 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5479 
        let v5481 : string = "\"{v5476}{v5478}{v5480}\""
        let v5482 : string = @$"format!(" + v5481 + ")"
        let v5483 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5482 
        let v5484 : string = "fable_library_rust::String_::fromString($0)"
        let v5485 : string = Fable.Core.RustInterop.emitRustExpr v5483 v5484 
        let _v5474 = v5485 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5486 : string = "inline_colorization::color_bright_blue"
        let v5487 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5486 
        let v5488 : string = "&*$0"
        let v5489 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5460 v5488 
        let v5490 : string = "inline_colorization::color_reset"
        let v5491 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5490 
        let v5492 : string = "\"{v5487}{v5489}{v5491}\""
        let v5493 : string = @$"format!(" + v5492 + ")"
        let v5494 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5493 
        let v5495 : string = "fable_library_rust::String_::fromString($0)"
        let v5496 : string = Fable.Core.RustInterop.emitRustExpr v5494 v5495 
        let _v5474 = v5496 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5497 : string = "inline_colorization::color_bright_blue"
        let v5498 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5497 
        let v5499 : string = "&*$0"
        let v5500 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5460 v5499 
        let v5501 : string = "inline_colorization::color_reset"
        let v5502 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5501 
        let v5503 : string = "\"{v5498}{v5500}{v5502}\""
        let v5504 : string = @$"format!(" + v5503 + ")"
        let v5505 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5504 
        let v5506 : string = "fable_library_rust::String_::fromString($0)"
        let v5507 : string = Fable.Core.RustInterop.emitRustExpr v5505 v5506 
        let _v5474 = v5507 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v5508 : string = "\u001b[94m"
        let v5509 : string = method7()
        let v5510 : string = v5508 + v5460 
        let v5511 : string = v5510 + v5509 
        let _v5474 = v5511 
        #endif
#if FABLE_COMPILER_PYTHON
        let v5512 : string = "\u001b[94m"
        let v5513 : string = method7()
        let v5514 : string = v5512 + v5460 
        let v5515 : string = v5514 + v5513 
        let _v5474 = v5515 
        #endif
#else
        let v5516 : string = "\u001b[94m"
        let v5517 : string = method7()
        let v5518 : string = v5516 + v5460 
        let v5519 : string = v5518 + v5517 
        let _v5474 = v5519 
        #endif
        let v5520 : string = _v5474 
        let v5526 : int64 = v5022.l0
        let v5527 : string = method8()
        let v5528 : Mut4 = {l0 = v5527} : Mut4
        let v5529 : string = "{ "
        let v5530 : string = $"{v5529}"
        let v5533 : string = v5528.l0
        let v5534 : string = v5533 + v5530 
        v5528.l0 <- v5534
        let v5535 : string = "json"
        let v5536 : string = $"{v5535}"
        let v5539 : string = v5528.l0
        let v5540 : string = v5539 + v5536 
        v5528.l0 <- v5540
        let v5541 : string = " = "
        let v5542 : string = $"{v5541}"
        let v5545 : string = v5528.l0
        let v5546 : string = v5545 + v5542 
        v5528.l0 <- v5546
        let v5547 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5548 : string = "format!(\"{:#?}\", $0)"
        let v5549 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4947 v5548 
        let v5550 : string = "fable_library_rust::String_::fromString($0)"
        let v5551 : string = Fable.Core.RustInterop.emitRustExpr v5549 v5550 
        let _v5547 = v5551 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5552 : string = "format!(\"{:#?}\", $0)"
        let v5553 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4947 v5552 
        let v5554 : string = "fable_library_rust::String_::fromString($0)"
        let v5555 : string = Fable.Core.RustInterop.emitRustExpr v5553 v5554 
        let _v5547 = v5555 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5556 : string = "format!(\"{:#?}\", $0)"
        let v5557 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4947 v5556 
        let v5558 : string = "fable_library_rust::String_::fromString($0)"
        let v5559 : string = Fable.Core.RustInterop.emitRustExpr v5557 v5558 
        let _v5547 = v5559 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v5560 : string = $"%A{v4947}"
        let _v5547 = v5560 
        #endif
#if FABLE_COMPILER_PYTHON
        let v5563 : string = $"%A{v4947}"
        let _v5547 = v5563 
        #endif
#else
        let v5566 : string = $"%A{v4947}"
        let _v5547 = v5566 
        #endif
        let v5569 : string = _v5547 
        let v5574 : string = $"{v5569}"
        let v5577 : string = v5528.l0
        let v5578 : string = v5577 + v5574 
        v5528.l0 <- v5578
        let v5579 : string = " }"
        let v5580 : string = $"{v5579}"
        let v5583 : string = v5528.l0
        let v5584 : string = v5583 + v5580 
        v5528.l0 <- v5584
        let v5585 : string = v5528.l0
        let v5586 : (unit -> string) = closure12()
        let v5587 : string = $"{v5390} {v5520} #{v5526} %s{v5586 ()} / {v5585}"
        let v5590 : char list = []
        let v5591 : (char list -> (char [])) = List.toArray
        let v5592 : (char []) = v5591 v5590
        let v5595 : string = v5587.TrimStart v5592 
        let v5613 : char list = []
        let v5614 : char list = '/' :: v5613 
        let v5617 : char list = ' ' :: v5614 
        let v5620 : (char list -> (char [])) = List.toArray
        let v5621 : (char []) = v5620 v5617
        let v5624 : string = v5595.TrimEnd v5621 
        let v5642 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5643 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v5624 v5643 
        let _v5642 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5644 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v5624 v5644 
        let _v5642 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5645 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v5624 v5645 
        let _v5642 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v5624 
        let _v5642 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v5624 
        let _v5642 = () 
        #endif
#else
        System.Console.WriteLine v5624 
        let _v5642 = () 
        #endif
        _v5642 
        let v5646 : (string -> unit) = v4961.l0
        v5646 v5624
    let v5647 : string = "$0.borsh()"
    let v5648 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v2124 v5647 
    let v5649 : bool = State.trace_state.IsNone
    if v5649 then
        let v5650 : US0 = US0_0
        let struct (v5651 : Mut0, v5652 : Mut1, v5653 : Mut2, v5654 : Mut3, v5655 : int64 option) = method0(v5650)
        let v5656 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v5651, v5652, v5653, v5654, v5655) 
        State.trace_state <- v5656 
        ()
    let struct (v5661 : Mut0, v5662 : Mut1, v5663 : Mut2, v5664 : Mut3, v5665 : int64 option) = State.trace_state.Value
    let v5676 : bool = State.trace_state.IsNone
    if v5676 then
        let v5677 : US0 = US0_0
        let struct (v5678 : Mut0, v5679 : Mut1, v5680 : Mut2, v5681 : Mut3, v5682 : int64 option) = method0(v5677)
        let v5683 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v5678, v5679, v5680, v5681, v5682) 
        State.trace_state <- v5683 
        ()
    let struct (v5688 : Mut0, v5689 : Mut1, v5690 : Mut2, v5691 : Mut3, v5692 : int64 option) = State.trace_state.Value
    let v5703 : US0 = v5691.l0
    let v5704 : bool = v5690.l0
    let v5705 : bool = v5704 = false
    let v5708 : bool =
        if v5705 then
            false
        else
            let v5706 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v5703
            let v5707 : bool = 1 >= v5706
            v5707
    if v5708 then
        let v5709 : int64 = v5661.l0
        let v5710 : int64 = v5709 + 1L
        v5661.l0 <- v5710
        let v5711 : bool = State.trace_state.IsNone
        if v5711 then
            let v5712 : US0 = US0_0
            let struct (v5713 : Mut0, v5714 : Mut1, v5715 : Mut2, v5716 : Mut3, v5717 : int64 option) = method0(v5712)
            let v5718 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v5713, v5714, v5715, v5716, v5717) 
            State.trace_state <- v5718 
            ()
        let struct (v5723 : Mut0, v5724 : Mut1, v5725 : Mut2, v5726 : Mut3, v5727 : int64 option) = State.trace_state.Value
        let v5738 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5739 : US3 option = None
        let _v5739 = ref v5739 
        match v5727 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5740 : int64 = x
        let v5741 : US3 = US3_0(v5740)
        v5741 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5739.Value <- x
        let v5742 : US3 option = _v5739.Value 
        let v5753 : US3 = US3_1
        let v5754 : US3 = v5742 |> Option.defaultValue v5753 
        let v5794 : System.DateTime =
            match v5754 with
            | US3_1 -> (* None *)
                let v5790 : System.DateTime = System.DateTime.Now
                v5790
            | US3_0(v5758) -> (* Some *)
                let v5759 : System.DateTime = System.DateTime.Now
                let v5762 : (System.DateTime -> int64) = _.Ticks
                let v5763 : int64 = v5762 v5759
                let v5766 : int64 = v5763 - v5758
                let v5767 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5768 : System.TimeSpan = v5767 v5766
                let v5771 : (System.TimeSpan -> int32) = _.Hours
                let v5772 : int32 = v5771 v5768
                let v5775 : (System.TimeSpan -> int32) = _.Minutes
                let v5776 : int32 = v5775 v5768
                let v5779 : (System.TimeSpan -> int32) = _.Seconds
                let v5780 : int32 = v5779 v5768
                let v5783 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5784 : int32 = v5783 v5768
                let v5787 : System.DateTime = System.DateTime (1, 1, 1, v5772, v5776, v5780, v5784)
                v5787
        let v5795 : string = method5()
        let v5798 : (string -> string) = v5794.ToString
        let v5799 : string = v5798 v5795
        let _v5738 = v5799 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5802 : US3 option = None
        let _v5802 = ref v5802 
        match v5727 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5803 : int64 = x
        let v5804 : US3 = US3_0(v5803)
        v5804 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5802.Value <- x
        let v5805 : US3 option = _v5802.Value 
        let v5816 : US3 = US3_1
        let v5817 : US3 = v5805 |> Option.defaultValue v5816 
        let v5857 : System.DateTime =
            match v5817 with
            | US3_1 -> (* None *)
                let v5853 : System.DateTime = System.DateTime.Now
                v5853
            | US3_0(v5821) -> (* Some *)
                let v5822 : System.DateTime = System.DateTime.Now
                let v5825 : (System.DateTime -> int64) = _.Ticks
                let v5826 : int64 = v5825 v5822
                let v5829 : int64 = v5826 - v5821
                let v5830 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5831 : System.TimeSpan = v5830 v5829
                let v5834 : (System.TimeSpan -> int32) = _.Hours
                let v5835 : int32 = v5834 v5831
                let v5838 : (System.TimeSpan -> int32) = _.Minutes
                let v5839 : int32 = v5838 v5831
                let v5842 : (System.TimeSpan -> int32) = _.Seconds
                let v5843 : int32 = v5842 v5831
                let v5846 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5847 : int32 = v5846 v5831
                let v5850 : System.DateTime = System.DateTime (1, 1, 1, v5835, v5839, v5843, v5847)
                v5850
        let v5858 : string = method5()
        let v5861 : (string -> string) = v5857.ToString
        let v5862 : string = v5861 v5858
        let _v5738 = v5862 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5865 : string = $"near_sdk::env::block_timestamp()"
        let v5866 : uint64 = Fable.Core.RustInterop.emitRustExpr () v5865 
        let v5867 : US3 option = None
        let _v5867 = ref v5867 
        match v5727 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5868 : int64 = x
        let v5869 : US3 = US3_0(v5868)
        v5869 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5867.Value <- x
        let v5870 : US3 option = _v5867.Value 
        let v5881 : US3 = US3_1
        let v5882 : US3 = v5870 |> Option.defaultValue v5881 
        let v5891 : uint64 =
            match v5882 with
            | US3_1 -> (* None *)
                v5866
            | US3_0(v5886) -> (* Some *)
                let v5887 : (int64 -> uint64) = uint64
                let v5888 : uint64 = v5887 v5886
                let v5889 : uint64 = v5866 - v5888
                v5889
        let v5892 : uint64 = v5891 / 1000000000UL
        let v5893 : uint64 = v5892 % 60UL
        let v5894 : uint64 = v5892 / 60UL
        let v5895 : uint64 = v5894 % 60UL
        let v5896 : uint64 = v5892 / 3600UL
        let v5897 : uint64 = v5896 % 24UL
        let v5898 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v5899 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v5897, v5895, v5893) v5898 
        let v5900 : string = "fable_library_rust::String_::fromString($0)"
        let v5901 : string = Fable.Core.RustInterop.emitRustExpr v5899 v5900 
        let _v5738 = v5901 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v5902 : US3 option = None
        let _v5902 = ref v5902 
        match v5727 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5903 : int64 = x
        let v5904 : US3 = US3_0(v5903)
        v5904 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5902.Value <- x
        let v5905 : US3 option = _v5902.Value 
        let v5916 : US3 = US3_1
        let v5917 : US3 = v5905 |> Option.defaultValue v5916 
        let v5957 : System.DateTime =
            match v5917 with
            | US3_1 -> (* None *)
                let v5953 : System.DateTime = System.DateTime.Now
                v5953
            | US3_0(v5921) -> (* Some *)
                let v5922 : System.DateTime = System.DateTime.Now
                let v5925 : (System.DateTime -> int64) = _.Ticks
                let v5926 : int64 = v5925 v5922
                let v5929 : int64 = v5926 - v5921
                let v5930 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5931 : System.TimeSpan = v5930 v5929
                let v5934 : (System.TimeSpan -> int32) = _.Hours
                let v5935 : int32 = v5934 v5931
                let v5938 : (System.TimeSpan -> int32) = _.Minutes
                let v5939 : int32 = v5938 v5931
                let v5942 : (System.TimeSpan -> int32) = _.Seconds
                let v5943 : int32 = v5942 v5931
                let v5946 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5947 : int32 = v5946 v5931
                let v5950 : System.DateTime = System.DateTime (1, 1, 1, v5935, v5939, v5943, v5947)
                v5950
        let v5958 : string = method6()
        let v5961 : (string -> string) = v5957.ToString
        let v5962 : string = v5961 v5958
        let _v5738 = v5962 
        #endif
#if FABLE_COMPILER_PYTHON
        let v5965 : US3 option = None
        let _v5965 = ref v5965 
        match v5727 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5966 : int64 = x
        let v5967 : US3 = US3_0(v5966)
        v5967 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5965.Value <- x
        let v5968 : US3 option = _v5965.Value 
        let v5979 : US3 = US3_1
        let v5980 : US3 = v5968 |> Option.defaultValue v5979 
        let v6020 : System.DateTime =
            match v5980 with
            | US3_1 -> (* None *)
                let v6016 : System.DateTime = System.DateTime.Now
                v6016
            | US3_0(v5984) -> (* Some *)
                let v5985 : System.DateTime = System.DateTime.Now
                let v5988 : (System.DateTime -> int64) = _.Ticks
                let v5989 : int64 = v5988 v5985
                let v5992 : int64 = v5989 - v5984
                let v5993 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5994 : System.TimeSpan = v5993 v5992
                let v5997 : (System.TimeSpan -> int32) = _.Hours
                let v5998 : int32 = v5997 v5994
                let v6001 : (System.TimeSpan -> int32) = _.Minutes
                let v6002 : int32 = v6001 v5994
                let v6005 : (System.TimeSpan -> int32) = _.Seconds
                let v6006 : int32 = v6005 v5994
                let v6009 : (System.TimeSpan -> int32) = _.Milliseconds
                let v6010 : int32 = v6009 v5994
                let v6013 : System.DateTime = System.DateTime (1, 1, 1, v5998, v6002, v6006, v6010)
                v6013
        let v6021 : string = method6()
        let v6024 : (string -> string) = v6020.ToString
        let v6025 : string = v6024 v6021
        let _v5738 = v6025 
        #endif
#else
        let v6028 : US3 option = None
        let _v6028 = ref v6028 
        match v5727 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v6029 : int64 = x
        let v6030 : US3 = US3_0(v6029)
        v6030 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6028.Value <- x
        let v6031 : US3 option = _v6028.Value 
        let v6042 : US3 = US3_1
        let v6043 : US3 = v6031 |> Option.defaultValue v6042 
        let v6083 : System.DateTime =
            match v6043 with
            | US3_1 -> (* None *)
                let v6079 : System.DateTime = System.DateTime.Now
                v6079
            | US3_0(v6047) -> (* Some *)
                let v6048 : System.DateTime = System.DateTime.Now
                let v6051 : (System.DateTime -> int64) = _.Ticks
                let v6052 : int64 = v6051 v6048
                let v6055 : int64 = v6052 - v6047
                let v6056 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v6057 : System.TimeSpan = v6056 v6055
                let v6060 : (System.TimeSpan -> int32) = _.Hours
                let v6061 : int32 = v6060 v6057
                let v6064 : (System.TimeSpan -> int32) = _.Minutes
                let v6065 : int32 = v6064 v6057
                let v6068 : (System.TimeSpan -> int32) = _.Seconds
                let v6069 : int32 = v6068 v6057
                let v6072 : (System.TimeSpan -> int32) = _.Milliseconds
                let v6073 : int32 = v6072 v6057
                let v6076 : System.DateTime = System.DateTime (1, 1, 1, v6061, v6065, v6069, v6073)
                v6076
        let v6084 : string = method6()
        let v6087 : (string -> string) = v6083.ToString
        let v6088 : string = v6087 v6084
        let _v5738 = v6088 
        #endif
        let v6091 : string = _v5738 
        let v6156 : string = "Debug"
        let v6157 : (unit -> string) = v6156.ToLower
        let v6158 : string = v6157 ()
        let v6161 : string = v6158.PadLeft (7, ' ')
        let v6175 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6176 : string = "inline_colorization::color_bright_blue"
        let v6177 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6176 
        let v6178 : string = "&*$0"
        let v6179 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6161 v6178 
        let v6180 : string = "inline_colorization::color_reset"
        let v6181 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6180 
        let v6182 : string = "\"{v6177}{v6179}{v6181}\""
        let v6183 : string = @$"format!(" + v6182 + ")"
        let v6184 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6183 
        let v6185 : string = "fable_library_rust::String_::fromString($0)"
        let v6186 : string = Fable.Core.RustInterop.emitRustExpr v6184 v6185 
        let _v6175 = v6186 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6187 : string = "inline_colorization::color_bright_blue"
        let v6188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6187 
        let v6189 : string = "&*$0"
        let v6190 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6161 v6189 
        let v6191 : string = "inline_colorization::color_reset"
        let v6192 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6191 
        let v6193 : string = "\"{v6188}{v6190}{v6192}\""
        let v6194 : string = @$"format!(" + v6193 + ")"
        let v6195 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6194 
        let v6196 : string = "fable_library_rust::String_::fromString($0)"
        let v6197 : string = Fable.Core.RustInterop.emitRustExpr v6195 v6196 
        let _v6175 = v6197 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v6198 : string = "inline_colorization::color_bright_blue"
        let v6199 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6198 
        let v6200 : string = "&*$0"
        let v6201 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6161 v6200 
        let v6202 : string = "inline_colorization::color_reset"
        let v6203 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6202 
        let v6204 : string = "\"{v6199}{v6201}{v6203}\""
        let v6205 : string = @$"format!(" + v6204 + ")"
        let v6206 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6205 
        let v6207 : string = "fable_library_rust::String_::fromString($0)"
        let v6208 : string = Fable.Core.RustInterop.emitRustExpr v6206 v6207 
        let _v6175 = v6208 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v6209 : string = "\u001b[94m"
        let v6210 : string = method7()
        let v6211 : string = v6209 + v6161 
        let v6212 : string = v6211 + v6210 
        let _v6175 = v6212 
        #endif
#if FABLE_COMPILER_PYTHON
        let v6213 : string = "\u001b[94m"
        let v6214 : string = method7()
        let v6215 : string = v6213 + v6161 
        let v6216 : string = v6215 + v6214 
        let _v6175 = v6216 
        #endif
#else
        let v6217 : string = "\u001b[94m"
        let v6218 : string = method7()
        let v6219 : string = v6217 + v6161 
        let v6220 : string = v6219 + v6218 
        let _v6175 = v6220 
        #endif
        let v6221 : string = _v6175 
        let v6227 : int64 = v5723.l0
        let v6228 : string = method8()
        let v6229 : Mut4 = {l0 = v6228} : Mut4
        let v6230 : string = "{ "
        let v6231 : string = $"{v6230}"
        let v6234 : string = v6229.l0
        let v6235 : string = v6234 + v6231 
        v6229.l0 <- v6235
        let v6236 : string = "borsh"
        let v6237 : string = $"{v6236}"
        let v6240 : string = v6229.l0
        let v6241 : string = v6240 + v6237 
        v6229.l0 <- v6241
        let v6242 : string = " = "
        let v6243 : string = $"{v6242}"
        let v6246 : string = v6229.l0
        let v6247 : string = v6246 + v6243 
        v6229.l0 <- v6247
        let v6248 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6249 : string = "format!(\"{:#?}\", $0)"
        let v6250 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5648 v6249 
        let v6251 : string = "fable_library_rust::String_::fromString($0)"
        let v6252 : string = Fable.Core.RustInterop.emitRustExpr v6250 v6251 
        let _v6248 = v6252 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6253 : string = "format!(\"{:#?}\", $0)"
        let v6254 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5648 v6253 
        let v6255 : string = "fable_library_rust::String_::fromString($0)"
        let v6256 : string = Fable.Core.RustInterop.emitRustExpr v6254 v6255 
        let _v6248 = v6256 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v6257 : string = "format!(\"{:#?}\", $0)"
        let v6258 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5648 v6257 
        let v6259 : string = "fable_library_rust::String_::fromString($0)"
        let v6260 : string = Fable.Core.RustInterop.emitRustExpr v6258 v6259 
        let _v6248 = v6260 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v6261 : string = $"%A{v5648}"
        let _v6248 = v6261 
        #endif
#if FABLE_COMPILER_PYTHON
        let v6264 : string = $"%A{v5648}"
        let _v6248 = v6264 
        #endif
#else
        let v6267 : string = $"%A{v5648}"
        let _v6248 = v6267 
        #endif
        let v6270 : string = _v6248 
        let v6275 : string = $"{v6270}"
        let v6278 : string = v6229.l0
        let v6279 : string = v6278 + v6275 
        v6229.l0 <- v6279
        let v6280 : string = " }"
        let v6281 : string = $"{v6280}"
        let v6284 : string = v6229.l0
        let v6285 : string = v6284 + v6281 
        v6229.l0 <- v6285
        let v6286 : string = v6229.l0
        let v6287 : (unit -> string) = closure13()
        let v6288 : string = $"{v6091} {v6221} #{v6227} %s{v6287 ()} / {v6286}"
        let v6291 : char list = []
        let v6292 : (char list -> (char [])) = List.toArray
        let v6293 : (char []) = v6292 v6291
        let v6296 : string = v6288.TrimStart v6293 
        let v6314 : char list = []
        let v6315 : char list = '/' :: v6314 
        let v6318 : char list = ' ' :: v6315 
        let v6321 : (char list -> (char [])) = List.toArray
        let v6322 : (char []) = v6321 v6318
        let v6325 : string = v6296.TrimEnd v6322 
        let v6343 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6344 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v6325 v6344 
        let _v6343 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6345 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v6325 v6345 
        let _v6343 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v6346 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v6325 v6346 
        let _v6343 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v6325 
        let _v6343 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v6325 
        let _v6343 = () 
        #endif
#else
        System.Console.WriteLine v6325 
        let _v6343 = () 
        #endif
        _v6343 
        let v6347 : (string -> unit) = v5662.l0
        v6347 v6325
    let v6348 : string = "  println!(\"\\n\\n worker: {:#?}\", v711); //"
    Fable.Core.RustInterop.emitRustExpr () v6348 
    let v6349 : string = "  println!(\"\\n\\n contract: {:#?}\", v1416); //"
    Fable.Core.RustInterop.emitRustExpr () v6349 
    let v6350 : string = "$0.len()"
    let v6351 : unativeint = Fable.Core.RustInterop.emitRustExpr v3544 v6350 
    let v6352 : (unativeint -> int32) = int32
    let v6353 : int32 = v6352 v6351
    let v6354 : bool = v6353 = 0
    let v6361 : Result<unit, anyhow_Error> =
        if v6354 then
            let v6355 : Result<unit, anyhow_Error> = Ok () 
            v6355
        else
            let v6356 : string = "anyhow::anyhow!($0)"
            let v6357 : string = "<error>"
            let v6358 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v6357 v6356 
            let v6359 : string = "Err(v6358)"
            let v6360 : Result<unit, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6359 
            v6360
    let v6362 : Result<unit, anyhow_Error> = method14(v6361)
    let v6363 : string = ""
    let v6364 : string = "}"
    let v6365 : string = v6363 + v6364 
    let v6366 : string = v6365 + v6364 
    let v6367 : string = v6366 + v6364 
    let v6368 : string = v6367 + v6364 
    let v6369 : string = v6368 + v6364 
    let v6370 : string = v6369 + v6364 
    let v6371 : string = v6370 + v6364 
    let v6372 : string = v6371 + v6364 
    let v6373 : string = v6372 + v6364 
    let v6374 : string = v6373 + v6364 
    let v6375 : string = v6374 + v6364 
    let v6376 : string = v6375 + v6364 
    let v6377 : string = v6376 + v6364 
    let v6378 : string = v6377 + v6364 
    let v6379 : string = v6378 + v6364 
    let v6380 : string = v6379 + v6364 
    let v6381 : string = v6380 + v6364 
    let v6382 : string = v6381 + v6364 
    let v6383 : string = v6382 + v6364 
    let v6384 : string = v6383 + v6364 
    let v6385 : string = v6384 + v6364 
    let v6386 : string = v6385 + v6364 
    let v6387 : string = v6386 + v6364 
    let v6388 : string = v6387 + v6364 
    let v6389 : string = v6388 + v6364 
    let v6390 : string = v6389 + v6364 
    let v6391 : string = v6390 + v6364 
    let v6392 : string = v6391 + v6364 
    let v6393 : string = v6392 + v6364 
    let v6394 : string = v6393 + v6364 
    let v6395 : string = v6394 + v6364 
    let v6396 : string = "{"
    let v6397 : string = v6363 + v6396 
    let v6398 : string = v6397 + v6396 
    let v6399 : string = v6398 + v6396 
    let v6400 : string = v6399 + v6396 
    let v6401 : string = v6400 + v6396 
    let v6402 : string = v6401 + v6396 
    let v6403 : string = v6402 + v6396 
    let v6404 : string = v6403 + v6396 
    let v6405 : string = v6404 + v6396 
    let v6406 : string = v6405 + v6396 
    let v6407 : string = v6406 + v6396 
    let v6408 : string = v6407 + v6396 
    let v6409 : string = v6408 + v6396 
    let v6410 : string = v6409 + v6396 
    let v6411 : string = v6410 + v6396 
    let v6412 : string = v6411 + v6396 
    let v6413 : string = v6412 + v6396 
    let v6414 : string = v6413 + v6396 
    let v6415 : string = v6414 + v6396 
    let v6416 : string = v6415 + v6396 
    let v6417 : string = v6416 + v6396 
    let v6418 : string = v6417 + v6396 
    let v6419 : string = v6418 + v6396 
    let v6420 : string = v6419 + v6396 
    let v6421 : string = v6420 + v6396 
    let v6422 : string = v6421 + v6396 
    let v6423 : string = v6422 + v6396 
    let v6424 : string = v6423 + v6396 
    let v6425 : string = v6424 + v6396 
    let v6426 : string = v6425 + v6396 
    let v6427 : string = "v6362 " + v6395 + "); " + v6426 + " // rust.fix_closure'"
    Fable.Core.RustInterop.emitRustExpr () v6427 
    let v6428 : string = "__result"
    let v6429 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v6428 
    v6429
and closure1 () (v0 : (string [])) : int32 =
    let v1 : bool = State.trace_state.IsNone
    if v1 then
        let v2 : US0 = US0_0
        let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : Mut3, v7 : int64 option) = method0(v2)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3, v4, v5, v6, v7) 
        State.trace_state <- v8 
        ()
    let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = State.trace_state.Value
    let v28 : bool = State.trace_state.IsNone
    if v28 then
        let v29 : US0 = US0_0
        let struct (v30 : Mut0, v31 : Mut1, v32 : Mut2, v33 : Mut3, v34 : int64 option) = method0(v29)
        let v35 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v30, v31, v32, v33, v34) 
        State.trace_state <- v35 
        ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : int64 option) = State.trace_state.Value
    let v55 : bool = State.trace_state.IsNone
    if v55 then
        let v56 : US0 = US0_0
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : int64 option) = method0(v56)
        let v62 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v57, v58, v59, v60, v61) 
        State.trace_state <- v62 
        ()
    let struct (v67 : Mut0, v68 : Mut1, v69 : Mut2, v70 : Mut3, v71 : int64 option) = State.trace_state.Value
    let v82 : US0 = v70.l0
    let v83 : bool = v69.l0
    let v84 : bool = v83 = false
    let v87 : bool =
        if v84 then
            false
        else
            let v85 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v82
            let v86 : bool = 1 >= v85
            v86
    if v87 then
        let v88 : int64 = v40.l0
        let v89 : int64 = v88 + 1L
        v40.l0 <- v89
        let v90 : bool = State.trace_state.IsNone
        if v90 then
            let v91 : US0 = US0_0
            let struct (v92 : Mut0, v93 : Mut1, v94 : Mut2, v95 : Mut3, v96 : int64 option) = method0(v91)
            let v97 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v92, v93, v94, v95, v96) 
            State.trace_state <- v97 
            ()
        let struct (v102 : Mut0, v103 : Mut1, v104 : Mut2, v105 : Mut3, v106 : int64 option) = State.trace_state.Value
        let v117 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v118 : US3 option = None
        let _v118 = ref v118 
        match v106 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v119 : int64 = x
        let v120 : US3 = US3_0(v119)
        v120 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v118.Value <- x
        let v121 : US3 option = _v118.Value 
        let v132 : US3 = US3_1
        let v133 : US3 = v121 |> Option.defaultValue v132 
        let v173 : System.DateTime =
            match v133 with
            | US3_1 -> (* None *)
                let v169 : System.DateTime = System.DateTime.Now
                v169
            | US3_0(v137) -> (* Some *)
                let v138 : System.DateTime = System.DateTime.Now
                let v141 : (System.DateTime -> int64) = _.Ticks
                let v142 : int64 = v141 v138
                let v145 : int64 = v142 - v137
                let v146 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v147 : System.TimeSpan = v146 v145
                let v150 : (System.TimeSpan -> int32) = _.Hours
                let v151 : int32 = v150 v147
                let v154 : (System.TimeSpan -> int32) = _.Minutes
                let v155 : int32 = v154 v147
                let v158 : (System.TimeSpan -> int32) = _.Seconds
                let v159 : int32 = v158 v147
                let v162 : (System.TimeSpan -> int32) = _.Milliseconds
                let v163 : int32 = v162 v147
                let v166 : System.DateTime = System.DateTime (1, 1, 1, v151, v155, v159, v163)
                v166
        let v174 : string = method5()
        let v177 : (string -> string) = v173.ToString
        let v178 : string = v177 v174
        let _v117 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        match v106 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v182 : int64 = x
        let v183 : US3 = US3_0(v182)
        v183 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v181.Value <- x
        let v184 : US3 option = _v181.Value 
        let v195 : US3 = US3_1
        let v196 : US3 = v184 |> Option.defaultValue v195 
        let v236 : System.DateTime =
            match v196 with
            | US3_1 -> (* None *)
                let v232 : System.DateTime = System.DateTime.Now
                v232
            | US3_0(v200) -> (* Some *)
                let v201 : System.DateTime = System.DateTime.Now
                let v204 : (System.DateTime -> int64) = _.Ticks
                let v205 : int64 = v204 v201
                let v208 : int64 = v205 - v200
                let v209 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v210 : System.TimeSpan = v209 v208
                let v213 : (System.TimeSpan -> int32) = _.Hours
                let v214 : int32 = v213 v210
                let v217 : (System.TimeSpan -> int32) = _.Minutes
                let v218 : int32 = v217 v210
                let v221 : (System.TimeSpan -> int32) = _.Seconds
                let v222 : int32 = v221 v210
                let v225 : (System.TimeSpan -> int32) = _.Milliseconds
                let v226 : int32 = v225 v210
                let v229 : System.DateTime = System.DateTime (1, 1, 1, v214, v218, v222, v226)
                v229
        let v237 : string = method5()
        let v240 : (string -> string) = v236.ToString
        let v241 : string = v240 v237
        let _v117 = v241 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v244 : string = $"near_sdk::env::block_timestamp()"
        let v245 : uint64 = Fable.Core.RustInterop.emitRustExpr () v244 
        let v246 : US3 option = None
        let _v246 = ref v246 
        match v106 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v247 : int64 = x
        let v248 : US3 = US3_0(v247)
        v248 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v246.Value <- x
        let v249 : US3 option = _v246.Value 
        let v260 : US3 = US3_1
        let v261 : US3 = v249 |> Option.defaultValue v260 
        let v270 : uint64 =
            match v261 with
            | US3_1 -> (* None *)
                v245
            | US3_0(v265) -> (* Some *)
                let v266 : (int64 -> uint64) = uint64
                let v267 : uint64 = v266 v265
                let v268 : uint64 = v245 - v267
                v268
        let v271 : uint64 = v270 / 1000000000UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v271 / 60UL
        let v274 : uint64 = v273 % 60UL
        let v275 : uint64 = v271 / 3600UL
        let v276 : uint64 = v275 % 24UL
        let v277 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v278 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v276, v274, v272) v277 
        let v279 : string = "fable_library_rust::String_::fromString($0)"
        let v280 : string = Fable.Core.RustInterop.emitRustExpr v278 v279 
        let _v117 = v280 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v281 : US3 option = None
        let _v281 = ref v281 
        match v106 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v282 : int64 = x
        let v283 : US3 = US3_0(v282)
        v283 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v281.Value <- x
        let v284 : US3 option = _v281.Value 
        let v295 : US3 = US3_1
        let v296 : US3 = v284 |> Option.defaultValue v295 
        let v336 : System.DateTime =
            match v296 with
            | US3_1 -> (* None *)
                let v332 : System.DateTime = System.DateTime.Now
                v332
            | US3_0(v300) -> (* Some *)
                let v301 : System.DateTime = System.DateTime.Now
                let v304 : (System.DateTime -> int64) = _.Ticks
                let v305 : int64 = v304 v301
                let v308 : int64 = v305 - v300
                let v309 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v310 : System.TimeSpan = v309 v308
                let v313 : (System.TimeSpan -> int32) = _.Hours
                let v314 : int32 = v313 v310
                let v317 : (System.TimeSpan -> int32) = _.Minutes
                let v318 : int32 = v317 v310
                let v321 : (System.TimeSpan -> int32) = _.Seconds
                let v322 : int32 = v321 v310
                let v325 : (System.TimeSpan -> int32) = _.Milliseconds
                let v326 : int32 = v325 v310
                let v329 : System.DateTime = System.DateTime (1, 1, 1, v314, v318, v322, v326)
                v329
        let v337 : string = method6()
        let v340 : (string -> string) = v336.ToString
        let v341 : string = v340 v337
        let _v117 = v341 
        #endif
#if FABLE_COMPILER_PYTHON
        let v344 : US3 option = None
        let _v344 = ref v344 
        match v106 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v345 : int64 = x
        let v346 : US3 = US3_0(v345)
        v346 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v344.Value <- x
        let v347 : US3 option = _v344.Value 
        let v358 : US3 = US3_1
        let v359 : US3 = v347 |> Option.defaultValue v358 
        let v399 : System.DateTime =
            match v359 with
            | US3_1 -> (* None *)
                let v395 : System.DateTime = System.DateTime.Now
                v395
            | US3_0(v363) -> (* Some *)
                let v364 : System.DateTime = System.DateTime.Now
                let v367 : (System.DateTime -> int64) = _.Ticks
                let v368 : int64 = v367 v364
                let v371 : int64 = v368 - v363
                let v372 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v373 : System.TimeSpan = v372 v371
                let v376 : (System.TimeSpan -> int32) = _.Hours
                let v377 : int32 = v376 v373
                let v380 : (System.TimeSpan -> int32) = _.Minutes
                let v381 : int32 = v380 v373
                let v384 : (System.TimeSpan -> int32) = _.Seconds
                let v385 : int32 = v384 v373
                let v388 : (System.TimeSpan -> int32) = _.Milliseconds
                let v389 : int32 = v388 v373
                let v392 : System.DateTime = System.DateTime (1, 1, 1, v377, v381, v385, v389)
                v392
        let v400 : string = method6()
        let v403 : (string -> string) = v399.ToString
        let v404 : string = v403 v400
        let _v117 = v404 
        #endif
#else
        let v407 : US3 option = None
        let _v407 = ref v407 
        match v106 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v408 : int64 = x
        let v409 : US3 = US3_0(v408)
        v409 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v407.Value <- x
        let v410 : US3 option = _v407.Value 
        let v421 : US3 = US3_1
        let v422 : US3 = v410 |> Option.defaultValue v421 
        let v462 : System.DateTime =
            match v422 with
            | US3_1 -> (* None *)
                let v458 : System.DateTime = System.DateTime.Now
                v458
            | US3_0(v426) -> (* Some *)
                let v427 : System.DateTime = System.DateTime.Now
                let v430 : (System.DateTime -> int64) = _.Ticks
                let v431 : int64 = v430 v427
                let v434 : int64 = v431 - v426
                let v435 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v436 : System.TimeSpan = v435 v434
                let v439 : (System.TimeSpan -> int32) = _.Hours
                let v440 : int32 = v439 v436
                let v443 : (System.TimeSpan -> int32) = _.Minutes
                let v444 : int32 = v443 v436
                let v447 : (System.TimeSpan -> int32) = _.Seconds
                let v448 : int32 = v447 v436
                let v451 : (System.TimeSpan -> int32) = _.Milliseconds
                let v452 : int32 = v451 v436
                let v455 : System.DateTime = System.DateTime (1, 1, 1, v440, v444, v448, v452)
                v455
        let v463 : string = method6()
        let v466 : (string -> string) = v462.ToString
        let v467 : string = v466 v463
        let _v117 = v467 
        #endif
        let v470 : string = _v117 
        let v535 : string = "Debug"
        let v536 : (unit -> string) = v535.ToLower
        let v537 : string = v536 ()
        let v540 : string = v537.PadLeft (7, ' ')
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = "inline_colorization::color_bright_blue"
        let v556 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v555 
        let v557 : string = "&*$0"
        let v558 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v557 
        let v559 : string = "inline_colorization::color_reset"
        let v560 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v559 
        let v561 : string = "\"{v556}{v558}{v560}\""
        let v562 : string = @$"format!(" + v561 + ")"
        let v563 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v562 
        let v564 : string = "fable_library_rust::String_::fromString($0)"
        let v565 : string = Fable.Core.RustInterop.emitRustExpr v563 v564 
        let _v554 = v565 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v566 : string = "inline_colorization::color_bright_blue"
        let v567 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v566 
        let v568 : string = "&*$0"
        let v569 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v568 
        let v570 : string = "inline_colorization::color_reset"
        let v571 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v570 
        let v572 : string = "\"{v567}{v569}{v571}\""
        let v573 : string = @$"format!(" + v572 + ")"
        let v574 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "fable_library_rust::String_::fromString($0)"
        let v576 : string = Fable.Core.RustInterop.emitRustExpr v574 v575 
        let _v554 = v576 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v577 : string = "inline_colorization::color_bright_blue"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "&*$0"
        let v580 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v540 v579 
        let v581 : string = "inline_colorization::color_reset"
        let v582 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "\"{v578}{v580}{v582}\""
        let v584 : string = @$"format!(" + v583 + ")"
        let v585 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "fable_library_rust::String_::fromString($0)"
        let v587 : string = Fable.Core.RustInterop.emitRustExpr v585 v586 
        let _v554 = v587 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v588 : string = "\u001b[94m"
        let v589 : string = method7()
        let v590 : string = v588 + v540 
        let v591 : string = v590 + v589 
        let _v554 = v591 
        #endif
#if FABLE_COMPILER_PYTHON
        let v592 : string = "\u001b[94m"
        let v593 : string = method7()
        let v594 : string = v592 + v540 
        let v595 : string = v594 + v593 
        let _v554 = v595 
        #endif
#else
        let v596 : string = "\u001b[94m"
        let v597 : string = method7()
        let v598 : string = v596 + v540 
        let v599 : string = v598 + v597 
        let _v554 = v599 
        #endif
        let v600 : string = _v554 
        let v606 : int64 = v102.l0
        let v607 : string = method8()
        let v608 : Mut4 = {l0 = v607} : Mut4
        let v609 : string = "{ "
        let v610 : string = $"{v609}"
        let v613 : string = v608.l0
        let v614 : string = v613 + v610 
        v608.l0 <- v614
        let v615 : string = "args"
        let v616 : string = $"{v615}"
        let v619 : string = v608.l0
        let v620 : string = v619 + v616 
        v608.l0 <- v620
        let v621 : string = " = "
        let v622 : string = $"{v621}"
        let v625 : string = v608.l0
        let v626 : string = v625 + v622 
        v608.l0 <- v626
        let v627 : string = $"%A{v0}"
        let v630 : string = $"{v627}"
        let v633 : string = v608.l0
        let v634 : string = v633 + v630 
        v608.l0 <- v634
        let v635 : string = " }"
        let v636 : string = $"{v635}"
        let v639 : string = v608.l0
        let v640 : string = v639 + v636 
        v608.l0 <- v640
        let v641 : string = v608.l0
        let v642 : (unit -> string) = closure3()
        let v643 : string = $"{v470} {v600} #{v606} %s{v642 ()} / {v641}"
        let v646 : char list = []
        let v647 : (char list -> (char [])) = List.toArray
        let v648 : (char []) = v647 v646
        let v651 : string = v643.TrimStart v648 
        let v669 : char list = []
        let v670 : char list = '/' :: v669 
        let v673 : char list = ' ' :: v670 
        let v676 : (char list -> (char [])) = List.toArray
        let v677 : (char []) = v676 v673
        let v680 : string = v651.TrimEnd v677 
        let v698 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v699 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v680 v699 
        let _v698 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v700 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v680 v700 
        let _v698 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v701 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v680 v701 
        let _v698 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v680 
        let _v698 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v680 
        let _v698 = () 
        #endif
#else
        System.Console.WriteLine v680 
        let _v698 = () 
        #endif
        _v698 
        let v702 : (string -> unit) = v41.l0
        v702 v680
    let v703 : clap_Command = method9()
    let v704 : string = "clap::Command::get_matches($0)"
    let v705 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v703 v704 
    let v706 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> = method10(v705)
    let v707 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v708 : _ = Fable.Core.RustInterop.emitRustExpr () v707 
    let v709 : string = "v708.handle().block_on($0)"
    let v710 : Result<unit, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v706 v709 
    let v711 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v710 v711 
    0
let v0 : (unit -> unit) = closure0()
v0 |> ignore
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
