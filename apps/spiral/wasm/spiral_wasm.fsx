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
and method0 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string) : string =
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "std::env::var(&*$0)"
    let v4 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "true; let _result = $0.map(|x| { //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "x"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v7 
    let v9 : string = "fable_library_rust::String_::fromString($0)"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr v8 v9 
    let v11 : string = "true; $0 })"
    let v12 : bool = Fable.Core.RustInterop.emitRustExpr v10 v11 
    let v13 : string = "_result"
    let v14 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v13 
    let v15 : string = method2()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let result = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : string = "std::env::var(&*$0)"
    let v19 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v18 
    let v20 : string = "true; let _result = $0.map(|x| { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v19 v20 
    let v22 : string = "x"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v22 
    let v24 : string = "fable_library_rust::String_::fromString($0)"
    let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let v26 : string = "true; $0 })"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = "_result"
    let v29 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = method2()
    let v31 : string = "$0.unwrap_or($1)"
    let v32 : string = Fable.Core.RustInterop.emitRustExpr struct (v29, v30) v31 
    let result = v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "std::env::var(&*$0)"
    let v34 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v33 
    let v35 : string = "true; let _result = $0.map(|x| { //"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let v37 : string = "x"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "fable_library_rust::String_::fromString($0)"
    let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39 
    let v41 : string = "true; $0 })"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr v40 v41 
    let v43 : string = "_result"
    let v44 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = method2()
    let v46 : string = "$0.unwrap_or($1)"
    let v47 : string = Fable.Core.RustInterop.emitRustExpr struct (v44, v45) v46 
    let result = v47 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : string = "process.env[$0] ?? \"\""
    let v49 : string = Fable.Core.JsInterop.emitJsExpr v0 v48 
    let result = v49 
    #endif
#if FABLE_COMPILER_PYTHON
    let v52 : string = "os"
    let v53 : IOsEnviron = Fable.Core.PyInterop.importAll v52 
    let v54 : string = "v53.environ"
    let v55 : obj = Fable.Core.PyInterop.emitPyExpr () v54 
    let v64 : string = "v55.get($0)"
    let v65 : string = Fable.Core.PyInterop.emitPyExpr v0 v64 
    let mutable _v65 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v74 : (string -> string option) = Option.ofObj
    let v75 : string option = v74 v65
    v75 
    #else
    Some v65 
    #endif
    |> fun x -> _v65 <- Some x
    let v76 : string option = match _v65 with Some x -> x | None -> failwith "optionm'.of_obj / _v65=None"
    let v85 : US1 option = None
    let _v85 = ref v85 
    match v76 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v86 : string = x
    let v87 : US1 = US1_0(v86)
    v87 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v85.Value <- x
    let v88 : US1 option = _v85.Value 
    let v111 : US1 = US1_1
    let v112 : (US1 option -> US1) = Option.defaultValue v111 
    let v113 : US1 = v112 v88
    let v124 : string =
        match v113 with
        | US1_1 -> (* None *)
            let v122 : string = ""
            v122
        | US1_0(v121) -> (* Some *)
            v121
    let result = v124 
    #endif
#else
    let v125 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v126 : string = v125 v0
    let mutable _v126 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v129 : (string -> string option) = Option.ofObj
    let v130 : string option = v129 v126
    v130 
    #else
    Some v126 
    #endif
    |> fun x -> _v126 <- Some x
    let v131 : string option = match _v126 with Some x -> x | None -> failwith "optionm'.of_obj / _v126=None"
    let v140 : US1 option = None
    let _v140 = ref v140 
    match v131 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v141 : string = x
    let v142 : US1 = US1_0(v141)
    v142 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v140.Value <- x
    let v143 : US1 option = _v140.Value 
    let v166 : US1 = US1_1
    let v167 : (US1 option -> US1) = Option.defaultValue v166 
    let v168 : US1 = v167 v143
    let v179 : string =
        match v168 with
        | US1_1 -> (* None *)
            let v177 : string = ""
            v177
        | US1_0(v176) -> (* Some *)
            v176
    let result = v179 
    #endif
    let v180 : string = result
    v180
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure3 () (v0 : string) : unit =
    ()
and closure2 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = method0()
    let v4 : string = method1(v3)
    let v6 : bool = "Verbose" = v4
    let v10 : US2 =
        if v6 then
            let v7 : US0 = US0_0
            US2_0(v7)
        else
            US2_1
    let v55 : US2 =
        match v10 with
        | US2_1 -> (* None *)
            let v14 : bool = "Debug" = v4
            let v18 : US2 =
                if v14 then
                    let v15 : US0 = US0_1
                    US2_0(v15)
                else
                    US2_1
            match v18 with
            | US2_1 -> (* None *)
                let v22 : bool = "Info" = v4
                let v26 : US2 =
                    if v22 then
                        let v23 : US0 = US0_2
                        US2_0(v23)
                    else
                        US2_1
                match v26 with
                | US2_1 -> (* None *)
                    let v30 : bool = "Warning" = v4
                    let v34 : US2 =
                        if v30 then
                            let v31 : US0 = US0_3
                            US2_0(v31)
                        else
                            US2_1
                    match v34 with
                    | US2_1 -> (* None *)
                        let v38 : bool = "Critical" = v4
                        let v42 : US2 =
                            if v38 then
                                let v39 : US0 = US0_4
                                US2_0(v39)
                            else
                                US2_1
                        match v42 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v43) -> (* Some *)
                            US2_0(v43)
                    | US2_0(v35) -> (* Some *)
                        US2_0(v35)
                | US2_0(v27) -> (* Some *)
                    US2_0(v27)
            | US2_0(v19) -> (* Some *)
                US2_0(v19)
        | US2_0(v11) -> (* Some *)
            US2_0(v11)
    let v56 : string = method3()
    let v57 : string = method1(v56)
    let v59 : bool = v57 = "True"
    let v81 : US3 =
        if v59 then
            let v62 : System.DateTime = System.DateTime.Now
            let v71 : (System.DateTime -> int64) = _.Ticks
            let v72 : int64 = v71 v62
            US3_0(v72)
        else
            US3_1
    let result = struct (v55, v81) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v82 : US2 = US2_1
    let v83 : US3 = US3_1
    let result = struct (v82, v83) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v84 : string = "AUTOMATION"
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : string = "env!(\"" + v84 + "\")"
    let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : string = "String::from($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "fable_library_rust::String_::fromString($0)"
    let v92 : string = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let result = v92 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v93 : string = "env!(\"" + v84 + "\")"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let v97 : string = "fable_library_rust::String_::fromString($0)"
    let v98 : string = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let result = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "env!(\"" + v84 + "\")"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v99 
    let v101 : string = "String::from($0)"
    let v102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let v103 : string = "fable_library_rust::String_::fromString($0)"
    let v104 : string = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let result = v104 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = null |> unbox<string>
    let result = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v116 : string = null |> unbox<string>
    let result = v116 
    #endif
#else
    let v125 : string = null |> unbox<string>
    let result = v125 
    #endif
    let v132 : string = result
    let v149 : string = "True"
    let v150 : bool = v132 <> v149 
    let v163 : US3 =
        if v150 then
            US3_1
        else
            let v158 : string = $"near_sdk::env::block_timestamp()"
            let v159 : uint64 = Fable.Core.RustInterop.emitRustExpr () v158 
            let v160 : (uint64 -> int64) = int64
            let v161 : int64 = v160 v159
            US3_0(v161)
    let v164 : US2 = US2_1
    let result = struct (v164, v163) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v165 : string = method0()
    let v166 : string = method1(v165)
    let v168 : bool = "Verbose" = v166
    let v172 : US2 =
        if v168 then
            let v169 : US0 = US0_0
            US2_0(v169)
        else
            US2_1
    let v217 : US2 =
        match v172 with
        | US2_1 -> (* None *)
            let v176 : bool = "Debug" = v166
            let v180 : US2 =
                if v176 then
                    let v177 : US0 = US0_1
                    US2_0(v177)
                else
                    US2_1
            match v180 with
            | US2_1 -> (* None *)
                let v184 : bool = "Info" = v166
                let v188 : US2 =
                    if v184 then
                        let v185 : US0 = US0_2
                        US2_0(v185)
                    else
                        US2_1
                match v188 with
                | US2_1 -> (* None *)
                    let v192 : bool = "Warning" = v166
                    let v196 : US2 =
                        if v192 then
                            let v193 : US0 = US0_3
                            US2_0(v193)
                        else
                            US2_1
                    match v196 with
                    | US2_1 -> (* None *)
                        let v200 : bool = "Critical" = v166
                        let v204 : US2 =
                            if v200 then
                                let v201 : US0 = US0_4
                                US2_0(v201)
                            else
                                US2_1
                        match v204 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v205) -> (* Some *)
                            US2_0(v205)
                    | US2_0(v197) -> (* Some *)
                        US2_0(v197)
                | US2_0(v189) -> (* Some *)
                    US2_0(v189)
            | US2_0(v181) -> (* Some *)
                US2_0(v181)
        | US2_0(v173) -> (* Some *)
            US2_0(v173)
    let v218 : string = method3()
    let v219 : string = method1(v218)
    let v220 : bool = v219 = "True"
    let v242 : US3 =
        if v220 then
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            US3_0(v233)
        else
            US3_1
    let result = struct (v217, v242) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v243 : string = method0()
    let v244 : string = method1(v243)
    let v246 : bool = "Verbose" = v244
    let v250 : US2 =
        if v246 then
            let v247 : US0 = US0_0
            US2_0(v247)
        else
            US2_1
    let v295 : US2 =
        match v250 with
        | US2_1 -> (* None *)
            let v254 : bool = "Debug" = v244
            let v258 : US2 =
                if v254 then
                    let v255 : US0 = US0_1
                    US2_0(v255)
                else
                    US2_1
            match v258 with
            | US2_1 -> (* None *)
                let v262 : bool = "Info" = v244
                let v266 : US2 =
                    if v262 then
                        let v263 : US0 = US0_2
                        US2_0(v263)
                    else
                        US2_1
                match v266 with
                | US2_1 -> (* None *)
                    let v270 : bool = "Warning" = v244
                    let v274 : US2 =
                        if v270 then
                            let v271 : US0 = US0_3
                            US2_0(v271)
                        else
                            US2_1
                    match v274 with
                    | US2_1 -> (* None *)
                        let v278 : bool = "Critical" = v244
                        let v282 : US2 =
                            if v278 then
                                let v279 : US0 = US0_4
                                US2_0(v279)
                            else
                                US2_1
                        match v282 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v283) -> (* Some *)
                            US2_0(v283)
                    | US2_0(v275) -> (* Some *)
                        US2_0(v275)
                | US2_0(v267) -> (* Some *)
                    US2_0(v267)
            | US2_0(v259) -> (* Some *)
                US2_0(v259)
        | US2_0(v251) -> (* Some *)
            US2_0(v251)
    let v296 : string = method3()
    let v297 : string = method1(v296)
    let v298 : bool = v297 = "True"
    let v320 : US3 =
        if v298 then
            let v301 : System.DateTime = System.DateTime.Now
            let v310 : (System.DateTime -> int64) = _.Ticks
            let v311 : int64 = v310 v301
            US3_0(v311)
        else
            US3_1
    let result = struct (v295, v320) 
    #endif
#else
    let v321 : string = method0()
    let v322 : string = method1(v321)
    let v324 : bool = "Verbose" = v322
    let v328 : US2 =
        if v324 then
            let v325 : US0 = US0_0
            US2_0(v325)
        else
            US2_1
    let v373 : US2 =
        match v328 with
        | US2_1 -> (* None *)
            let v332 : bool = "Debug" = v322
            let v336 : US2 =
                if v332 then
                    let v333 : US0 = US0_1
                    US2_0(v333)
                else
                    US2_1
            match v336 with
            | US2_1 -> (* None *)
                let v340 : bool = "Info" = v322
                let v344 : US2 =
                    if v340 then
                        let v341 : US0 = US0_2
                        US2_0(v341)
                    else
                        US2_1
                match v344 with
                | US2_1 -> (* None *)
                    let v348 : bool = "Warning" = v322
                    let v352 : US2 =
                        if v348 then
                            let v349 : US0 = US0_3
                            US2_0(v349)
                        else
                            US2_1
                    match v352 with
                    | US2_1 -> (* None *)
                        let v356 : bool = "Critical" = v322
                        let v360 : US2 =
                            if v356 then
                                let v357 : US0 = US0_4
                                US2_0(v357)
                            else
                                US2_1
                        match v360 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v361) -> (* Some *)
                            US2_0(v361)
                    | US2_0(v353) -> (* Some *)
                        US2_0(v353)
                | US2_0(v345) -> (* Some *)
                    US2_0(v345)
            | US2_0(v337) -> (* Some *)
                US2_0(v337)
        | US2_0(v329) -> (* Some *)
            US2_0(v329)
    let v374 : string = method3()
    let v375 : string = method1(v374)
    let v376 : bool = v375 = "True"
    let v398 : US3 =
        if v376 then
            let v379 : System.DateTime = System.DateTime.Now
            let v388 : (System.DateTime -> int64) = _.Ticks
            let v389 : int64 = v388 v379
            US3_0(v389)
        else
            US3_1
    let result = struct (v373, v398) 
    #endif
    let struct (v399 : US2, v400 : US3) = result
    let v485 : Mut2 = {l0 = true} : Mut2
    let v486 : Mut0 = {l0 = 0L} : Mut0
    let v489 : US0 =
        match v399 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v487) -> (* Some *)
            v487
    let v490 : Mut3 = {l0 = v489} : Mut3
    let v491 : (string -> unit) = closure3()
    let v492 : Mut1 = {l0 = v491} : Mut1
    let v505 : int64 option =
        match v400 with
        | US3_1 -> (* None *)
            let v503 : int64 option = None
            v503
        | US3_0(v493) -> (* Some *)
            let v496 : int64 option = Some v493 
            v496
    struct (v486, v492, v485, v490, v505)
and method4 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method5 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 () : string =
    let v0 : string = "\u001b[0m"
    v0
and closure4 () () : string =
    let v0 : string = $"spiral_wasm.main"
    v0
and method7 () : clap_Command =
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
and method9 () : string =
    let v0 : string = "wasm"
    v0
and closure5 () () : string =
    let v0 : string = "run"
    v0
and closure6 () () : string =
    let v0 : string = ""
    v0
and closure7 () () : string =
    let v0 : string = ""
    v0
and closure8 () () : string =
    let v0 : string = ""
    v0
and closure9 () (v0 : std_string_String) : unit =
    v0 |> System.Console.WriteLine
    ()
and closure10 () () : string =
    let v0 : string = ""
    v0
and method10 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and closure11 () () : string =
    let v0 : string = ""
    v0
and method11 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and closure12 () () : string =
    let v0 : string = ""
    v0
and closure13 () () : string =
    let v0 : string = ""
    v0
and closure14 () () : string =
    let v0 : string = ""
    v0
and method12 (v0 : Result<unit, anyhow_Error>) : Result<unit, anyhow_Error> =
    v0
and method8 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> =
    let v1 : string = "let __result = Box::pin(async move { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = method9()
    let v3 : string = "&*$0"
    let v4 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "clap::ArgMatches::get_one(&$0, v4).cloned()"
    let v6 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v5 
    let v9 : US4 option = None
    let _v9 = ref v9 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : std_string_String = x
    let v11 : US4 = US4_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US4 option = _v9.Value 
    let v35 : US4 = US4_1
    let v36 : (US4 option -> US4) = Option.defaultValue v35 
    let v37 : US4 = v36 v12
    let v48 : std_string_String =
        match v37 with
        | US4_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US4_0(v45) -> (* Some *)
            v45
    let v49 : string = "fable_library_rust::String_::fromString($0)"
    let v50 : string = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v53 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure2()
    let v54 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v54 |> Some
    let struct (v62 : Mut0, v63 : Mut1, v64 : Mut2, v65 : Mut3, v66 : int64 option) = State.trace_state.Value
    let v83 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v83 |> Some
    let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : int64 option) = State.trace_state.Value
    let v110 : US0 = v94.l0
    let v111 : bool = v93.l0
    let v112 : bool = v111 = false
    let v115 : bool =
        if v112 then
            false
        else
            let v113 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v110
            let v114 : bool = 1 >= v113
            v114
    if v115 then
        let v116 : int64 = v62.l0
        let v117 : int64 = v116 + 1L
        v62.l0 <- v117
        let v120 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v120 |> Some
        let struct (v128 : Mut0, v129 : Mut1, v130 : Mut2, v131 : Mut3, v132 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v151 : US3 option = None
        let _v151 = ref v151 
        match v132 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v152 : int64 = x
        let v153 : US3 = US3_0(v152)
        v153 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v151.Value <- x
        let v154 : US3 option = _v151.Value 
        let v177 : US3 = US3_1
        let v178 : (US3 option -> US3) = Option.defaultValue v177 
        let v179 : US3 = v178 v154
        let v277 : System.DateTime =
            match v179 with
            | US3_1 -> (* None *)
                let v269 : System.DateTime = System.DateTime.Now
                v269
            | US3_0(v187) -> (* Some *)
                let v190 : System.DateTime = System.DateTime.Now
                let v199 : (System.DateTime -> int64) = _.Ticks
                let v200 : int64 = v199 v190
                let v207 : int64 = v200 - v187
                let v210 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v211 : System.TimeSpan = v210 v207
                let v220 : (System.TimeSpan -> int32) = _.Hours
                let v221 : int32 = v220 v211
                let v230 : (System.TimeSpan -> int32) = _.Minutes
                let v231 : int32 = v230 v211
                let v240 : (System.TimeSpan -> int32) = _.Seconds
                let v241 : int32 = v240 v211
                let v250 : (System.TimeSpan -> int32) = _.Milliseconds
                let v251 : int32 = v250 v211
                let v260 : System.DateTime = System.DateTime (1, 1, 1, v221, v231, v241, v251)
                v260
        let v280 : string = method4()
        let v289 : (string -> string) = v277.ToString
        let v290 : string = v289 v280
        let result = v290 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v299 : US3 option = None
        let _v299 = ref v299 
        match v132 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v300 : int64 = x
        let v301 : US3 = US3_0(v300)
        v301 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v299.Value <- x
        let v302 : US3 option = _v299.Value 
        let v325 : US3 = US3_1
        let v326 : (US3 option -> US3) = Option.defaultValue v325 
        let v327 : US3 = v326 v302
        let v425 : System.DateTime =
            match v327 with
            | US3_1 -> (* None *)
                let v417 : System.DateTime = System.DateTime.Now
                v417
            | US3_0(v335) -> (* Some *)
                let v338 : System.DateTime = System.DateTime.Now
                let v347 : (System.DateTime -> int64) = _.Ticks
                let v348 : int64 = v347 v338
                let v355 : int64 = v348 - v335
                let v358 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v359 : System.TimeSpan = v358 v355
                let v368 : (System.TimeSpan -> int32) = _.Hours
                let v369 : int32 = v368 v359
                let v378 : (System.TimeSpan -> int32) = _.Minutes
                let v379 : int32 = v378 v359
                let v388 : (System.TimeSpan -> int32) = _.Seconds
                let v389 : int32 = v388 v359
                let v398 : (System.TimeSpan -> int32) = _.Milliseconds
                let v399 : int32 = v398 v359
                let v408 : System.DateTime = System.DateTime (1, 1, 1, v369, v379, v389, v399)
                v408
        let v428 : string = method4()
        let v437 : (string -> string) = v425.ToString
        let v438 : string = v437 v428
        let result = v438 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v445 : string = $"near_sdk::env::block_timestamp()"
        let v446 : uint64 = Fable.Core.RustInterop.emitRustExpr () v445 
        let v449 : US3 option = None
        let _v449 = ref v449 
        match v132 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v450 : int64 = x
        let v451 : US3 = US3_0(v450)
        v451 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v449.Value <- x
        let v452 : US3 option = _v449.Value 
        let v475 : US3 = US3_1
        let v476 : (US3 option -> US3) = Option.defaultValue v475 
        let v477 : US3 = v476 v452
        let v490 : uint64 =
            match v477 with
            | US3_1 -> (* None *)
                v446
            | US3_0(v485) -> (* Some *)
                let v486 : (int64 -> uint64) = uint64
                let v487 : uint64 = v486 v485
                let v488 : uint64 = v446 - v487
                v488
        let v491 : uint64 = v490 / 1000000000UL
        let v492 : uint64 = v491 % 60UL
        let v493 : uint64 = v491 / 60UL
        let v494 : uint64 = v493 % 60UL
        let v495 : uint64 = v491 / 3600UL
        let v496 : uint64 = v495 % 24UL
        let v497 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v498 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v496, v494, v492) v497 
        let v499 : string = "fable_library_rust::String_::fromString($0)"
        let v500 : string = Fable.Core.RustInterop.emitRustExpr v498 v499 
        let result = v500 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v503 : US3 option = None
        let _v503 = ref v503 
        match v132 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v504 : int64 = x
        let v505 : US3 = US3_0(v504)
        v505 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v503.Value <- x
        let v506 : US3 option = _v503.Value 
        let v529 : US3 = US3_1
        let v530 : (US3 option -> US3) = Option.defaultValue v529 
        let v531 : US3 = v530 v506
        let v629 : System.DateTime =
            match v531 with
            | US3_1 -> (* None *)
                let v621 : System.DateTime = System.DateTime.Now
                v621
            | US3_0(v539) -> (* Some *)
                let v542 : System.DateTime = System.DateTime.Now
                let v551 : (System.DateTime -> int64) = _.Ticks
                let v552 : int64 = v551 v542
                let v559 : int64 = v552 - v539
                let v562 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v563 : System.TimeSpan = v562 v559
                let v572 : (System.TimeSpan -> int32) = _.Hours
                let v573 : int32 = v572 v563
                let v582 : (System.TimeSpan -> int32) = _.Minutes
                let v583 : int32 = v582 v563
                let v592 : (System.TimeSpan -> int32) = _.Seconds
                let v593 : int32 = v592 v563
                let v602 : (System.TimeSpan -> int32) = _.Milliseconds
                let v603 : int32 = v602 v563
                let v612 : System.DateTime = System.DateTime (1, 1, 1, v573, v583, v593, v603)
                v612
        let v632 : string = method5()
        let v641 : (string -> string) = v629.ToString
        let v642 : string = v641 v632
        let result = v642 
        #endif
#if FABLE_COMPILER_PYTHON
        let v651 : US3 option = None
        let _v651 = ref v651 
        match v132 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v652 : int64 = x
        let v653 : US3 = US3_0(v652)
        v653 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v651.Value <- x
        let v654 : US3 option = _v651.Value 
        let v677 : US3 = US3_1
        let v678 : (US3 option -> US3) = Option.defaultValue v677 
        let v679 : US3 = v678 v654
        let v777 : System.DateTime =
            match v679 with
            | US3_1 -> (* None *)
                let v769 : System.DateTime = System.DateTime.Now
                v769
            | US3_0(v687) -> (* Some *)
                let v690 : System.DateTime = System.DateTime.Now
                let v699 : (System.DateTime -> int64) = _.Ticks
                let v700 : int64 = v699 v690
                let v707 : int64 = v700 - v687
                let v710 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v711 : System.TimeSpan = v710 v707
                let v720 : (System.TimeSpan -> int32) = _.Hours
                let v721 : int32 = v720 v711
                let v730 : (System.TimeSpan -> int32) = _.Minutes
                let v731 : int32 = v730 v711
                let v740 : (System.TimeSpan -> int32) = _.Seconds
                let v741 : int32 = v740 v711
                let v750 : (System.TimeSpan -> int32) = _.Milliseconds
                let v751 : int32 = v750 v711
                let v760 : System.DateTime = System.DateTime (1, 1, 1, v721, v731, v741, v751)
                v760
        let v780 : string = method5()
        let v789 : (string -> string) = v777.ToString
        let v790 : string = v789 v780
        let result = v790 
        #endif
#else
        let v799 : US3 option = None
        let _v799 = ref v799 
        match v132 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v800 : int64 = x
        let v801 : US3 = US3_0(v800)
        v801 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v799.Value <- x
        let v802 : US3 option = _v799.Value 
        let v825 : US3 = US3_1
        let v826 : (US3 option -> US3) = Option.defaultValue v825 
        let v827 : US3 = v826 v802
        let v925 : System.DateTime =
            match v827 with
            | US3_1 -> (* None *)
                let v917 : System.DateTime = System.DateTime.Now
                v917
            | US3_0(v835) -> (* Some *)
                let v838 : System.DateTime = System.DateTime.Now
                let v847 : (System.DateTime -> int64) = _.Ticks
                let v848 : int64 = v847 v838
                let v855 : int64 = v848 - v835
                let v858 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v859 : System.TimeSpan = v858 v855
                let v868 : (System.TimeSpan -> int32) = _.Hours
                let v869 : int32 = v868 v859
                let v878 : (System.TimeSpan -> int32) = _.Minutes
                let v879 : int32 = v878 v859
                let v888 : (System.TimeSpan -> int32) = _.Seconds
                let v889 : int32 = v888 v859
                let v898 : (System.TimeSpan -> int32) = _.Milliseconds
                let v899 : int32 = v898 v859
                let v908 : System.DateTime = System.DateTime (1, 1, 1, v869, v879, v889, v899)
                v908
        let v928 : string = method5()
        let v937 : (string -> string) = v925.ToString
        let v938 : string = v937 v928
        let result = v938 
        #endif
        let v945 : string = result
        let v1107 : string = "Debug"
        let v1108 : (unit -> string) = v1107.ToLower
        let v1109 : string = v1108 ()
        let v1118 : string = v1109.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1150 : string = "inline_colorization::color_bright_blue"
        let v1151 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1150 
        let v1152 : string = "&*$0"
        let v1153 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1118 v1152 
        let v1154 : string = "inline_colorization::color_reset"
        let v1155 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1154 
        let v1156 : string = "\"{v1151}{v1153}{v1155}\""
        let v1157 : string = @$"format!(" + v1156 + ")"
        let v1158 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1157 
        let v1159 : string = "fable_library_rust::String_::fromString($0)"
        let v1160 : string = Fable.Core.RustInterop.emitRustExpr v1158 v1159 
        let result = v1160 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1161 : string = "inline_colorization::color_bright_blue"
        let v1162 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1161 
        let v1163 : string = "&*$0"
        let v1164 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1118 v1163 
        let v1165 : string = "inline_colorization::color_reset"
        let v1166 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1165 
        let v1167 : string = "\"{v1162}{v1164}{v1166}\""
        let v1168 : string = @$"format!(" + v1167 + ")"
        let v1169 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1168 
        let v1170 : string = "fable_library_rust::String_::fromString($0)"
        let v1171 : string = Fable.Core.RustInterop.emitRustExpr v1169 v1170 
        let result = v1171 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1172 : string = "inline_colorization::color_bright_blue"
        let v1173 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1172 
        let v1174 : string = "&*$0"
        let v1175 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1118 v1174 
        let v1176 : string = "inline_colorization::color_reset"
        let v1177 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1176 
        let v1178 : string = "\"{v1173}{v1175}{v1177}\""
        let v1179 : string = @$"format!(" + v1178 + ")"
        let v1180 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1179 
        let v1181 : string = "fable_library_rust::String_::fromString($0)"
        let v1182 : string = Fable.Core.RustInterop.emitRustExpr v1180 v1181 
        let result = v1182 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1183 : string = "\u001b[94m"
        let v1184 : string = method6()
        let v1185 : string = v1183 + v1118 
        let v1186 : string = v1185 + v1184 
        let result = v1186 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1187 : string = "\u001b[94m"
        let v1188 : string = method6()
        let v1189 : string = v1187 + v1118 
        let v1190 : string = v1189 + v1188 
        let result = v1190 
        #endif
#else
        let v1191 : string = "\u001b[94m"
        let v1192 : string = method6()
        let v1193 : string = v1191 + v1118 
        let v1194 : string = v1193 + v1192 
        let result = v1194 
        #endif
        let v1195 : string = result
        let v1205 : int64 = v128.l0
        let v1206 : string = ""
        let v1207 : Mut4 = {l0 = v1206} : Mut4
        let v1210 : string = "{ "
        let v1211 : string = $"{v1210}"
        let v1218 : string = v1207.l0
        let v1219 : string = v1218 + v1211 
        v1207.l0 <- v1219
        let v1222 : string = "wasm_path"
        let v1223 : string = $"{v1222}"
        let v1230 : string = v1207.l0
        let v1231 : string = v1230 + v1223 
        v1207.l0 <- v1231
        let v1234 : string = " = "
        let v1235 : string = $"{v1234}"
        let v1242 : string = v1207.l0
        let v1243 : string = v1242 + v1235 
        v1207.l0 <- v1243
        let v1246 : string = $"{v50}"
        let v1253 : string = v1207.l0
        let v1254 : string = v1253 + v1246 
        v1207.l0 <- v1254
        let v1257 : string = " }"
        let v1258 : string = $"{v1257}"
        let v1265 : string = v1207.l0
        let v1266 : string = v1265 + v1258 
        v1207.l0 <- v1266
        let v1267 : string = v1207.l0
        let v1270 : (unit -> string) = closure5()
        let v1271 : string = $"{v945} {v1195} #{v1205} %s{v1270 ()} / {v1267}"
        let v1278 : char list = []
        let v1283 : (char list -> (char [])) = List.toArray
        let v1284 : (char []) = v1283 v1278
        let v1291 : string = v1271.TrimStart v1284 
        let v1330 : char list = []
        let v1333 : char list = '/' :: v1330 
        let v1342 : char list = ' ' :: v1333 
        let v1353 : (char list -> (char [])) = List.toArray
        let v1354 : (char []) = v1353 v1342
        let v1361 : string = v1291.TrimEnd v1354 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1402 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1361 v1402 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1403 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1361 v1403 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1404 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1361 v1404 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1361 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1361 
        let result = () 
        #endif
#else
        System.Console.WriteLine v1361 
        let result = () 
        #endif
        result
        let v1433 : (string -> unit) = v63.l0
        v1433 v1361
    let v1434 : string = "std::fs::read(&*$0)"
    let v1435 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v50 v1434 
    let v1436 : string = "$0?"
    let v1437 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v1435 v1436 
    let v1438 : string = "near_workspaces::sandbox().await"
    let v1439 : Result<near_workspaces_Worker<near_workspaces_network_Sandbox>, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v1438 
    let v1440 : string = "$0?"
    let v1441 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v1439 v1440 
    let v1444 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v1444 |> Some
    let struct (v1452 : Mut0, v1453 : Mut1, v1454 : Mut2, v1455 : Mut3, v1456 : int64 option) = State.trace_state.Value
    let v1473 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v1473 |> Some
    let struct (v1481 : Mut0, v1482 : Mut1, v1483 : Mut2, v1484 : Mut3, v1485 : int64 option) = State.trace_state.Value
    let v1500 : US0 = v1484.l0
    let v1501 : bool = v1483.l0
    let v1502 : bool = v1501 = false
    let v1505 : bool =
        if v1502 then
            false
        else
            let v1503 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1500
            let v1504 : bool = 1 >= v1503
            v1504
    if v1505 then
        let v1506 : int64 = v1452.l0
        let v1507 : int64 = v1506 + 1L
        v1452.l0 <- v1507
        let v1510 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v1510 |> Some
        let struct (v1518 : Mut0, v1519 : Mut1, v1520 : Mut2, v1521 : Mut3, v1522 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1541 : US3 option = None
        let _v1541 = ref v1541 
        match v1522 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1542 : int64 = x
        let v1543 : US3 = US3_0(v1542)
        v1543 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1541.Value <- x
        let v1544 : US3 option = _v1541.Value 
        let v1567 : US3 = US3_1
        let v1568 : (US3 option -> US3) = Option.defaultValue v1567 
        let v1569 : US3 = v1568 v1544
        let v1667 : System.DateTime =
            match v1569 with
            | US3_1 -> (* None *)
                let v1659 : System.DateTime = System.DateTime.Now
                v1659
            | US3_0(v1577) -> (* Some *)
                let v1580 : System.DateTime = System.DateTime.Now
                let v1589 : (System.DateTime -> int64) = _.Ticks
                let v1590 : int64 = v1589 v1580
                let v1597 : int64 = v1590 - v1577
                let v1600 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1601 : System.TimeSpan = v1600 v1597
                let v1610 : (System.TimeSpan -> int32) = _.Hours
                let v1611 : int32 = v1610 v1601
                let v1620 : (System.TimeSpan -> int32) = _.Minutes
                let v1621 : int32 = v1620 v1601
                let v1630 : (System.TimeSpan -> int32) = _.Seconds
                let v1631 : int32 = v1630 v1601
                let v1640 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1641 : int32 = v1640 v1601
                let v1650 : System.DateTime = System.DateTime (1, 1, 1, v1611, v1621, v1631, v1641)
                v1650
        let v1670 : string = method4()
        let v1679 : (string -> string) = v1667.ToString
        let v1680 : string = v1679 v1670
        let result = v1680 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1689 : US3 option = None
        let _v1689 = ref v1689 
        match v1522 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1690 : int64 = x
        let v1691 : US3 = US3_0(v1690)
        v1691 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1689.Value <- x
        let v1692 : US3 option = _v1689.Value 
        let v1715 : US3 = US3_1
        let v1716 : (US3 option -> US3) = Option.defaultValue v1715 
        let v1717 : US3 = v1716 v1692
        let v1815 : System.DateTime =
            match v1717 with
            | US3_1 -> (* None *)
                let v1807 : System.DateTime = System.DateTime.Now
                v1807
            | US3_0(v1725) -> (* Some *)
                let v1728 : System.DateTime = System.DateTime.Now
                let v1737 : (System.DateTime -> int64) = _.Ticks
                let v1738 : int64 = v1737 v1728
                let v1745 : int64 = v1738 - v1725
                let v1748 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1749 : System.TimeSpan = v1748 v1745
                let v1758 : (System.TimeSpan -> int32) = _.Hours
                let v1759 : int32 = v1758 v1749
                let v1768 : (System.TimeSpan -> int32) = _.Minutes
                let v1769 : int32 = v1768 v1749
                let v1778 : (System.TimeSpan -> int32) = _.Seconds
                let v1779 : int32 = v1778 v1749
                let v1788 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1789 : int32 = v1788 v1749
                let v1798 : System.DateTime = System.DateTime (1, 1, 1, v1759, v1769, v1779, v1789)
                v1798
        let v1818 : string = method4()
        let v1827 : (string -> string) = v1815.ToString
        let v1828 : string = v1827 v1818
        let result = v1828 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1835 : string = $"near_sdk::env::block_timestamp()"
        let v1836 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1835 
        let v1839 : US3 option = None
        let _v1839 = ref v1839 
        match v1522 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1840 : int64 = x
        let v1841 : US3 = US3_0(v1840)
        v1841 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1839.Value <- x
        let v1842 : US3 option = _v1839.Value 
        let v1865 : US3 = US3_1
        let v1866 : (US3 option -> US3) = Option.defaultValue v1865 
        let v1867 : US3 = v1866 v1842
        let v1880 : uint64 =
            match v1867 with
            | US3_1 -> (* None *)
                v1836
            | US3_0(v1875) -> (* Some *)
                let v1876 : (int64 -> uint64) = uint64
                let v1877 : uint64 = v1876 v1875
                let v1878 : uint64 = v1836 - v1877
                v1878
        let v1881 : uint64 = v1880 / 1000000000UL
        let v1882 : uint64 = v1881 % 60UL
        let v1883 : uint64 = v1881 / 60UL
        let v1884 : uint64 = v1883 % 60UL
        let v1885 : uint64 = v1881 / 3600UL
        let v1886 : uint64 = v1885 % 24UL
        let v1887 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v1888 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1886, v1884, v1882) v1887 
        let v1889 : string = "fable_library_rust::String_::fromString($0)"
        let v1890 : string = Fable.Core.RustInterop.emitRustExpr v1888 v1889 
        let result = v1890 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1893 : US3 option = None
        let _v1893 = ref v1893 
        match v1522 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1894 : int64 = x
        let v1895 : US3 = US3_0(v1894)
        v1895 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1893.Value <- x
        let v1896 : US3 option = _v1893.Value 
        let v1919 : US3 = US3_1
        let v1920 : (US3 option -> US3) = Option.defaultValue v1919 
        let v1921 : US3 = v1920 v1896
        let v2019 : System.DateTime =
            match v1921 with
            | US3_1 -> (* None *)
                let v2011 : System.DateTime = System.DateTime.Now
                v2011
            | US3_0(v1929) -> (* Some *)
                let v1932 : System.DateTime = System.DateTime.Now
                let v1941 : (System.DateTime -> int64) = _.Ticks
                let v1942 : int64 = v1941 v1932
                let v1949 : int64 = v1942 - v1929
                let v1952 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1953 : System.TimeSpan = v1952 v1949
                let v1962 : (System.TimeSpan -> int32) = _.Hours
                let v1963 : int32 = v1962 v1953
                let v1972 : (System.TimeSpan -> int32) = _.Minutes
                let v1973 : int32 = v1972 v1953
                let v1982 : (System.TimeSpan -> int32) = _.Seconds
                let v1983 : int32 = v1982 v1953
                let v1992 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1993 : int32 = v1992 v1953
                let v2002 : System.DateTime = System.DateTime (1, 1, 1, v1963, v1973, v1983, v1993)
                v2002
        let v2022 : string = method5()
        let v2031 : (string -> string) = v2019.ToString
        let v2032 : string = v2031 v2022
        let result = v2032 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2041 : US3 option = None
        let _v2041 = ref v2041 
        match v1522 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2042 : int64 = x
        let v2043 : US3 = US3_0(v2042)
        v2043 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2041.Value <- x
        let v2044 : US3 option = _v2041.Value 
        let v2067 : US3 = US3_1
        let v2068 : (US3 option -> US3) = Option.defaultValue v2067 
        let v2069 : US3 = v2068 v2044
        let v2167 : System.DateTime =
            match v2069 with
            | US3_1 -> (* None *)
                let v2159 : System.DateTime = System.DateTime.Now
                v2159
            | US3_0(v2077) -> (* Some *)
                let v2080 : System.DateTime = System.DateTime.Now
                let v2089 : (System.DateTime -> int64) = _.Ticks
                let v2090 : int64 = v2089 v2080
                let v2097 : int64 = v2090 - v2077
                let v2100 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2101 : System.TimeSpan = v2100 v2097
                let v2110 : (System.TimeSpan -> int32) = _.Hours
                let v2111 : int32 = v2110 v2101
                let v2120 : (System.TimeSpan -> int32) = _.Minutes
                let v2121 : int32 = v2120 v2101
                let v2130 : (System.TimeSpan -> int32) = _.Seconds
                let v2131 : int32 = v2130 v2101
                let v2140 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2141 : int32 = v2140 v2101
                let v2150 : System.DateTime = System.DateTime (1, 1, 1, v2111, v2121, v2131, v2141)
                v2150
        let v2170 : string = method5()
        let v2179 : (string -> string) = v2167.ToString
        let v2180 : string = v2179 v2170
        let result = v2180 
        #endif
#else
        let v2189 : US3 option = None
        let _v2189 = ref v2189 
        match v1522 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2190 : int64 = x
        let v2191 : US3 = US3_0(v2190)
        v2191 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2189.Value <- x
        let v2192 : US3 option = _v2189.Value 
        let v2215 : US3 = US3_1
        let v2216 : (US3 option -> US3) = Option.defaultValue v2215 
        let v2217 : US3 = v2216 v2192
        let v2315 : System.DateTime =
            match v2217 with
            | US3_1 -> (* None *)
                let v2307 : System.DateTime = System.DateTime.Now
                v2307
            | US3_0(v2225) -> (* Some *)
                let v2228 : System.DateTime = System.DateTime.Now
                let v2237 : (System.DateTime -> int64) = _.Ticks
                let v2238 : int64 = v2237 v2228
                let v2245 : int64 = v2238 - v2225
                let v2248 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2249 : System.TimeSpan = v2248 v2245
                let v2258 : (System.TimeSpan -> int32) = _.Hours
                let v2259 : int32 = v2258 v2249
                let v2268 : (System.TimeSpan -> int32) = _.Minutes
                let v2269 : int32 = v2268 v2249
                let v2278 : (System.TimeSpan -> int32) = _.Seconds
                let v2279 : int32 = v2278 v2249
                let v2288 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2289 : int32 = v2288 v2249
                let v2298 : System.DateTime = System.DateTime (1, 1, 1, v2259, v2269, v2279, v2289)
                v2298
        let v2318 : string = method5()
        let v2327 : (string -> string) = v2315.ToString
        let v2328 : string = v2327 v2318
        let result = v2328 
        #endif
        let v2335 : string = result
        let v2497 : string = "Debug"
        let v2498 : (unit -> string) = v2497.ToLower
        let v2499 : string = v2498 ()
        let v2508 : string = v2499.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2540 : string = "inline_colorization::color_bright_blue"
        let v2541 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2540 
        let v2542 : string = "&*$0"
        let v2543 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2508 v2542 
        let v2544 : string = "inline_colorization::color_reset"
        let v2545 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2544 
        let v2546 : string = "\"{v2541}{v2543}{v2545}\""
        let v2547 : string = @$"format!(" + v2546 + ")"
        let v2548 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2547 
        let v2549 : string = "fable_library_rust::String_::fromString($0)"
        let v2550 : string = Fable.Core.RustInterop.emitRustExpr v2548 v2549 
        let result = v2550 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2551 : string = "inline_colorization::color_bright_blue"
        let v2552 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2551 
        let v2553 : string = "&*$0"
        let v2554 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2508 v2553 
        let v2555 : string = "inline_colorization::color_reset"
        let v2556 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2555 
        let v2557 : string = "\"{v2552}{v2554}{v2556}\""
        let v2558 : string = @$"format!(" + v2557 + ")"
        let v2559 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2558 
        let v2560 : string = "fable_library_rust::String_::fromString($0)"
        let v2561 : string = Fable.Core.RustInterop.emitRustExpr v2559 v2560 
        let result = v2561 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2562 : string = "inline_colorization::color_bright_blue"
        let v2563 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2562 
        let v2564 : string = "&*$0"
        let v2565 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2508 v2564 
        let v2566 : string = "inline_colorization::color_reset"
        let v2567 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2566 
        let v2568 : string = "\"{v2563}{v2565}{v2567}\""
        let v2569 : string = @$"format!(" + v2568 + ")"
        let v2570 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2569 
        let v2571 : string = "fable_library_rust::String_::fromString($0)"
        let v2572 : string = Fable.Core.RustInterop.emitRustExpr v2570 v2571 
        let result = v2572 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2573 : string = "\u001b[94m"
        let v2574 : string = method6()
        let v2575 : string = v2573 + v2508 
        let v2576 : string = v2575 + v2574 
        let result = v2576 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2577 : string = "\u001b[94m"
        let v2578 : string = method6()
        let v2579 : string = v2577 + v2508 
        let v2580 : string = v2579 + v2578 
        let result = v2580 
        #endif
#else
        let v2581 : string = "\u001b[94m"
        let v2582 : string = method6()
        let v2583 : string = v2581 + v2508 
        let v2584 : string = v2583 + v2582 
        let result = v2584 
        #endif
        let v2585 : string = result
        let v2595 : int64 = v1518.l0
        let v2596 : string = ""
        let v2597 : Mut4 = {l0 = v2596} : Mut4
        let v2600 : string = "{ "
        let v2601 : string = $"{v2600}"
        let v2608 : string = v2597.l0
        let v2609 : string = v2608 + v2601 
        v2597.l0 <- v2609
        let v2612 : string = "worker"
        let v2613 : string = $"{v2612}"
        let v2620 : string = v2597.l0
        let v2621 : string = v2620 + v2613 
        v2597.l0 <- v2621
        let v2624 : string = " = "
        let v2625 : string = $"{v2624}"
        let v2632 : string = v2597.l0
        let v2633 : string = v2632 + v2625 
        v2597.l0 <- v2633
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2636 : string = "format!(\"{:#?}\", $0)"
        let v2637 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1441 v2636 
        let v2638 : string = "fable_library_rust::String_::fromString($0)"
        let v2639 : string = Fable.Core.RustInterop.emitRustExpr v2637 v2638 
        let result = v2639 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2640 : string = "format!(\"{:#?}\", $0)"
        let v2641 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1441 v2640 
        let v2642 : string = "fable_library_rust::String_::fromString($0)"
        let v2643 : string = Fable.Core.RustInterop.emitRustExpr v2641 v2642 
        let result = v2643 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2644 : string = "format!(\"{:#?}\", $0)"
        let v2645 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1441 v2644 
        let v2646 : string = "fable_library_rust::String_::fromString($0)"
        let v2647 : string = Fable.Core.RustInterop.emitRustExpr v2645 v2646 
        let result = v2647 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2650 : string = $"%A{v1441}"
        let result = v2650 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2659 : string = $"%A{v1441}"
        let result = v2659 
        #endif
#else
        let v2668 : string = $"%A{v1441}"
        let result = v2668 
        #endif
        let v2675 : string = result
        let v2692 : string = $"{v2675}"
        let v2699 : string = v2597.l0
        let v2700 : string = v2699 + v2692 
        v2597.l0 <- v2700
        let v2703 : string = " }"
        let v2704 : string = $"{v2703}"
        let v2711 : string = v2597.l0
        let v2712 : string = v2711 + v2704 
        v2597.l0 <- v2712
        let v2713 : string = v2597.l0
        let v2716 : (unit -> string) = closure6()
        let v2717 : string = $"{v2335} {v2585} #{v2595} %s{v2716 ()} / {v2713}"
        let v2724 : char list = []
        let v2729 : (char list -> (char [])) = List.toArray
        let v2730 : (char []) = v2729 v2724
        let v2737 : string = v2717.TrimStart v2730 
        let v2776 : char list = []
        let v2779 : char list = '/' :: v2776 
        let v2788 : char list = ' ' :: v2779 
        let v2799 : (char list -> (char [])) = List.toArray
        let v2800 : (char []) = v2799 v2788
        let v2807 : string = v2737.TrimEnd v2800 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2848 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2807 v2848 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2849 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2807 v2849 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2850 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v2807 v2850 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v2807 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v2807 
        let result = () 
        #endif
#else
        System.Console.WriteLine v2807 
        let result = () 
        #endif
        result
        let v2879 : (string -> unit) = v1453.l0
        v2879 v2807
    let v2880 : string = "Box::pin(v1441.dev_deploy(&v1437))"
    let v2881 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_Contract, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v2880 
    let v2882 : string = "v2881.await"
    let v2883 : Result<near_workspaces_Contract, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v2882 
    let v2884 : string = "$0?"
    let v2885 : near_workspaces_Contract = Fable.Core.RustInterop.emitRustExpr v2883 v2884 
    let v2888 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v2888 |> Some
    let struct (v2896 : Mut0, v2897 : Mut1, v2898 : Mut2, v2899 : Mut3, v2900 : int64 option) = State.trace_state.Value
    let v2917 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v2917 |> Some
    let struct (v2925 : Mut0, v2926 : Mut1, v2927 : Mut2, v2928 : Mut3, v2929 : int64 option) = State.trace_state.Value
    let v2944 : US0 = v2928.l0
    let v2945 : bool = v2927.l0
    let v2946 : bool = v2945 = false
    let v2949 : bool =
        if v2946 then
            false
        else
            let v2947 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v2944
            let v2948 : bool = 1 >= v2947
            v2948
    if v2949 then
        let v2950 : int64 = v2896.l0
        let v2951 : int64 = v2950 + 1L
        v2896.l0 <- v2951
        let v2954 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v2954 |> Some
        let struct (v2962 : Mut0, v2963 : Mut1, v2964 : Mut2, v2965 : Mut3, v2966 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2985 : US3 option = None
        let _v2985 = ref v2985 
        match v2966 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2986 : int64 = x
        let v2987 : US3 = US3_0(v2986)
        v2987 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2985.Value <- x
        let v2988 : US3 option = _v2985.Value 
        let v3011 : US3 = US3_1
        let v3012 : (US3 option -> US3) = Option.defaultValue v3011 
        let v3013 : US3 = v3012 v2988
        let v3111 : System.DateTime =
            match v3013 with
            | US3_1 -> (* None *)
                let v3103 : System.DateTime = System.DateTime.Now
                v3103
            | US3_0(v3021) -> (* Some *)
                let v3024 : System.DateTime = System.DateTime.Now
                let v3033 : (System.DateTime -> int64) = _.Ticks
                let v3034 : int64 = v3033 v3024
                let v3041 : int64 = v3034 - v3021
                let v3044 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3045 : System.TimeSpan = v3044 v3041
                let v3054 : (System.TimeSpan -> int32) = _.Hours
                let v3055 : int32 = v3054 v3045
                let v3064 : (System.TimeSpan -> int32) = _.Minutes
                let v3065 : int32 = v3064 v3045
                let v3074 : (System.TimeSpan -> int32) = _.Seconds
                let v3075 : int32 = v3074 v3045
                let v3084 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3085 : int32 = v3084 v3045
                let v3094 : System.DateTime = System.DateTime (1, 1, 1, v3055, v3065, v3075, v3085)
                v3094
        let v3114 : string = method4()
        let v3123 : (string -> string) = v3111.ToString
        let v3124 : string = v3123 v3114
        let result = v3124 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3133 : US3 option = None
        let _v3133 = ref v3133 
        match v2966 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3134 : int64 = x
        let v3135 : US3 = US3_0(v3134)
        v3135 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3133.Value <- x
        let v3136 : US3 option = _v3133.Value 
        let v3159 : US3 = US3_1
        let v3160 : (US3 option -> US3) = Option.defaultValue v3159 
        let v3161 : US3 = v3160 v3136
        let v3259 : System.DateTime =
            match v3161 with
            | US3_1 -> (* None *)
                let v3251 : System.DateTime = System.DateTime.Now
                v3251
            | US3_0(v3169) -> (* Some *)
                let v3172 : System.DateTime = System.DateTime.Now
                let v3181 : (System.DateTime -> int64) = _.Ticks
                let v3182 : int64 = v3181 v3172
                let v3189 : int64 = v3182 - v3169
                let v3192 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3193 : System.TimeSpan = v3192 v3189
                let v3202 : (System.TimeSpan -> int32) = _.Hours
                let v3203 : int32 = v3202 v3193
                let v3212 : (System.TimeSpan -> int32) = _.Minutes
                let v3213 : int32 = v3212 v3193
                let v3222 : (System.TimeSpan -> int32) = _.Seconds
                let v3223 : int32 = v3222 v3193
                let v3232 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3233 : int32 = v3232 v3193
                let v3242 : System.DateTime = System.DateTime (1, 1, 1, v3203, v3213, v3223, v3233)
                v3242
        let v3262 : string = method4()
        let v3271 : (string -> string) = v3259.ToString
        let v3272 : string = v3271 v3262
        let result = v3272 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v3279 : string = $"near_sdk::env::block_timestamp()"
        let v3280 : uint64 = Fable.Core.RustInterop.emitRustExpr () v3279 
        let v3283 : US3 option = None
        let _v3283 = ref v3283 
        match v2966 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3284 : int64 = x
        let v3285 : US3 = US3_0(v3284)
        v3285 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3283.Value <- x
        let v3286 : US3 option = _v3283.Value 
        let v3309 : US3 = US3_1
        let v3310 : (US3 option -> US3) = Option.defaultValue v3309 
        let v3311 : US3 = v3310 v3286
        let v3324 : uint64 =
            match v3311 with
            | US3_1 -> (* None *)
                v3280
            | US3_0(v3319) -> (* Some *)
                let v3320 : (int64 -> uint64) = uint64
                let v3321 : uint64 = v3320 v3319
                let v3322 : uint64 = v3280 - v3321
                v3322
        let v3325 : uint64 = v3324 / 1000000000UL
        let v3326 : uint64 = v3325 % 60UL
        let v3327 : uint64 = v3325 / 60UL
        let v3328 : uint64 = v3327 % 60UL
        let v3329 : uint64 = v3325 / 3600UL
        let v3330 : uint64 = v3329 % 24UL
        let v3331 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v3332 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v3330, v3328, v3326) v3331 
        let v3333 : string = "fable_library_rust::String_::fromString($0)"
        let v3334 : string = Fable.Core.RustInterop.emitRustExpr v3332 v3333 
        let result = v3334 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v3337 : US3 option = None
        let _v3337 = ref v3337 
        match v2966 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3338 : int64 = x
        let v3339 : US3 = US3_0(v3338)
        v3339 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3337.Value <- x
        let v3340 : US3 option = _v3337.Value 
        let v3363 : US3 = US3_1
        let v3364 : (US3 option -> US3) = Option.defaultValue v3363 
        let v3365 : US3 = v3364 v3340
        let v3463 : System.DateTime =
            match v3365 with
            | US3_1 -> (* None *)
                let v3455 : System.DateTime = System.DateTime.Now
                v3455
            | US3_0(v3373) -> (* Some *)
                let v3376 : System.DateTime = System.DateTime.Now
                let v3385 : (System.DateTime -> int64) = _.Ticks
                let v3386 : int64 = v3385 v3376
                let v3393 : int64 = v3386 - v3373
                let v3396 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3397 : System.TimeSpan = v3396 v3393
                let v3406 : (System.TimeSpan -> int32) = _.Hours
                let v3407 : int32 = v3406 v3397
                let v3416 : (System.TimeSpan -> int32) = _.Minutes
                let v3417 : int32 = v3416 v3397
                let v3426 : (System.TimeSpan -> int32) = _.Seconds
                let v3427 : int32 = v3426 v3397
                let v3436 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3437 : int32 = v3436 v3397
                let v3446 : System.DateTime = System.DateTime (1, 1, 1, v3407, v3417, v3427, v3437)
                v3446
        let v3466 : string = method5()
        let v3475 : (string -> string) = v3463.ToString
        let v3476 : string = v3475 v3466
        let result = v3476 
        #endif
#if FABLE_COMPILER_PYTHON
        let v3485 : US3 option = None
        let _v3485 = ref v3485 
        match v2966 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3486 : int64 = x
        let v3487 : US3 = US3_0(v3486)
        v3487 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3485.Value <- x
        let v3488 : US3 option = _v3485.Value 
        let v3511 : US3 = US3_1
        let v3512 : (US3 option -> US3) = Option.defaultValue v3511 
        let v3513 : US3 = v3512 v3488
        let v3611 : System.DateTime =
            match v3513 with
            | US3_1 -> (* None *)
                let v3603 : System.DateTime = System.DateTime.Now
                v3603
            | US3_0(v3521) -> (* Some *)
                let v3524 : System.DateTime = System.DateTime.Now
                let v3533 : (System.DateTime -> int64) = _.Ticks
                let v3534 : int64 = v3533 v3524
                let v3541 : int64 = v3534 - v3521
                let v3544 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3545 : System.TimeSpan = v3544 v3541
                let v3554 : (System.TimeSpan -> int32) = _.Hours
                let v3555 : int32 = v3554 v3545
                let v3564 : (System.TimeSpan -> int32) = _.Minutes
                let v3565 : int32 = v3564 v3545
                let v3574 : (System.TimeSpan -> int32) = _.Seconds
                let v3575 : int32 = v3574 v3545
                let v3584 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3585 : int32 = v3584 v3545
                let v3594 : System.DateTime = System.DateTime (1, 1, 1, v3555, v3565, v3575, v3585)
                v3594
        let v3614 : string = method5()
        let v3623 : (string -> string) = v3611.ToString
        let v3624 : string = v3623 v3614
        let result = v3624 
        #endif
#else
        let v3633 : US3 option = None
        let _v3633 = ref v3633 
        match v2966 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v3634 : int64 = x
        let v3635 : US3 = US3_0(v3634)
        v3635 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v3633.Value <- x
        let v3636 : US3 option = _v3633.Value 
        let v3659 : US3 = US3_1
        let v3660 : (US3 option -> US3) = Option.defaultValue v3659 
        let v3661 : US3 = v3660 v3636
        let v3759 : System.DateTime =
            match v3661 with
            | US3_1 -> (* None *)
                let v3751 : System.DateTime = System.DateTime.Now
                v3751
            | US3_0(v3669) -> (* Some *)
                let v3672 : System.DateTime = System.DateTime.Now
                let v3681 : (System.DateTime -> int64) = _.Ticks
                let v3682 : int64 = v3681 v3672
                let v3689 : int64 = v3682 - v3669
                let v3692 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v3693 : System.TimeSpan = v3692 v3689
                let v3702 : (System.TimeSpan -> int32) = _.Hours
                let v3703 : int32 = v3702 v3693
                let v3712 : (System.TimeSpan -> int32) = _.Minutes
                let v3713 : int32 = v3712 v3693
                let v3722 : (System.TimeSpan -> int32) = _.Seconds
                let v3723 : int32 = v3722 v3693
                let v3732 : (System.TimeSpan -> int32) = _.Milliseconds
                let v3733 : int32 = v3732 v3693
                let v3742 : System.DateTime = System.DateTime (1, 1, 1, v3703, v3713, v3723, v3733)
                v3742
        let v3762 : string = method5()
        let v3771 : (string -> string) = v3759.ToString
        let v3772 : string = v3771 v3762
        let result = v3772 
        #endif
        let v3779 : string = result
        let v3941 : string = "Debug"
        let v3942 : (unit -> string) = v3941.ToLower
        let v3943 : string = v3942 ()
        let v3952 : string = v3943.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v3984 : string = "inline_colorization::color_bright_blue"
        let v3985 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3984 
        let v3986 : string = "&*$0"
        let v3987 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3952 v3986 
        let v3988 : string = "inline_colorization::color_reset"
        let v3989 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3988 
        let v3990 : string = "\"{v3985}{v3987}{v3989}\""
        let v3991 : string = @$"format!(" + v3990 + ")"
        let v3992 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v3991 
        let v3993 : string = "fable_library_rust::String_::fromString($0)"
        let v3994 : string = Fable.Core.RustInterop.emitRustExpr v3992 v3993 
        let result = v3994 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v3995 : string = "inline_colorization::color_bright_blue"
        let v3996 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3995 
        let v3997 : string = "&*$0"
        let v3998 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3952 v3997 
        let v3999 : string = "inline_colorization::color_reset"
        let v4000 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3999 
        let v4001 : string = "\"{v3996}{v3998}{v4000}\""
        let v4002 : string = @$"format!(" + v4001 + ")"
        let v4003 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4002 
        let v4004 : string = "fable_library_rust::String_::fromString($0)"
        let v4005 : string = Fable.Core.RustInterop.emitRustExpr v4003 v4004 
        let result = v4005 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4006 : string = "inline_colorization::color_bright_blue"
        let v4007 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4006 
        let v4008 : string = "&*$0"
        let v4009 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3952 v4008 
        let v4010 : string = "inline_colorization::color_reset"
        let v4011 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v4010 
        let v4012 : string = "\"{v4007}{v4009}{v4011}\""
        let v4013 : string = @$"format!(" + v4012 + ")"
        let v4014 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v4013 
        let v4015 : string = "fable_library_rust::String_::fromString($0)"
        let v4016 : string = Fable.Core.RustInterop.emitRustExpr v4014 v4015 
        let result = v4016 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4017 : string = "\u001b[94m"
        let v4018 : string = method6()
        let v4019 : string = v4017 + v3952 
        let v4020 : string = v4019 + v4018 
        let result = v4020 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4021 : string = "\u001b[94m"
        let v4022 : string = method6()
        let v4023 : string = v4021 + v3952 
        let v4024 : string = v4023 + v4022 
        let result = v4024 
        #endif
#else
        let v4025 : string = "\u001b[94m"
        let v4026 : string = method6()
        let v4027 : string = v4025 + v3952 
        let v4028 : string = v4027 + v4026 
        let result = v4028 
        #endif
        let v4029 : string = result
        let v4039 : int64 = v2962.l0
        let v4040 : string = ""
        let v4041 : Mut4 = {l0 = v4040} : Mut4
        let v4044 : string = "{ "
        let v4045 : string = $"{v4044}"
        let v4052 : string = v4041.l0
        let v4053 : string = v4052 + v4045 
        v4041.l0 <- v4053
        let v4056 : string = "contract"
        let v4057 : string = $"{v4056}"
        let v4064 : string = v4041.l0
        let v4065 : string = v4064 + v4057 
        v4041.l0 <- v4065
        let v4068 : string = " = "
        let v4069 : string = $"{v4068}"
        let v4076 : string = v4041.l0
        let v4077 : string = v4076 + v4069 
        v4041.l0 <- v4077
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4080 : string = "format!(\"{:#?}\", $0)"
        let v4081 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2885 v4080 
        let v4082 : string = "fable_library_rust::String_::fromString($0)"
        let v4083 : string = Fable.Core.RustInterop.emitRustExpr v4081 v4082 
        let result = v4083 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4084 : string = "format!(\"{:#?}\", $0)"
        let v4085 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2885 v4084 
        let v4086 : string = "fable_library_rust::String_::fromString($0)"
        let v4087 : string = Fable.Core.RustInterop.emitRustExpr v4085 v4086 
        let result = v4087 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4088 : string = "format!(\"{:#?}\", $0)"
        let v4089 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2885 v4088 
        let v4090 : string = "fable_library_rust::String_::fromString($0)"
        let v4091 : string = Fable.Core.RustInterop.emitRustExpr v4089 v4090 
        let result = v4091 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4094 : string = $"%A{v2885}"
        let result = v4094 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4103 : string = $"%A{v2885}"
        let result = v4103 
        #endif
#else
        let v4112 : string = $"%A{v2885}"
        let result = v4112 
        #endif
        let v4119 : string = result
        let v4136 : string = $"{v4119}"
        let v4143 : string = v4041.l0
        let v4144 : string = v4143 + v4136 
        v4041.l0 <- v4144
        let v4147 : string = " }"
        let v4148 : string = $"{v4147}"
        let v4155 : string = v4041.l0
        let v4156 : string = v4155 + v4148 
        v4041.l0 <- v4156
        let v4157 : string = v4041.l0
        let v4160 : (unit -> string) = closure7()
        let v4161 : string = $"{v3779} {v4029} #{v4039} %s{v4160 ()} / {v4157}"
        let v4168 : char list = []
        let v4173 : (char list -> (char [])) = List.toArray
        let v4174 : (char []) = v4173 v4168
        let v4181 : string = v4161.TrimStart v4174 
        let v4220 : char list = []
        let v4223 : char list = '/' :: v4220 
        let v4232 : char list = ' ' :: v4223 
        let v4243 : (char list -> (char [])) = List.toArray
        let v4244 : (char []) = v4243 v4232
        let v4251 : string = v4181.TrimEnd v4244 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4292 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v4251 v4292 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4293 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v4251 v4293 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4294 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v4251 v4294 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v4251 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v4251 
        let result = () 
        #endif
#else
        System.Console.WriteLine v4251 
        let result = () 
        #endif
        result
        let v4323 : (string -> unit) = v2897.l0
        v4323 v4251
    let v4324 : string = "v2885.call(&*$0)"
    let v4325 : string = "state_main"
    let v4326 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr v4325 v4324 
    let v4327 : string = "Box::pin(v4326.transact())"
    let v4328 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v4327 
    let v4329 : string = "v4328.await"
    let v4330 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v4329 
    let v4331 : string = "$0?"
    let v4332 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v4330 v4331 
    let v4335 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v4335 |> Some
    let struct (v4343 : Mut0, v4344 : Mut1, v4345 : Mut2, v4346 : Mut3, v4347 : int64 option) = State.trace_state.Value
    let v4364 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v4364 |> Some
    let struct (v4372 : Mut0, v4373 : Mut1, v4374 : Mut2, v4375 : Mut3, v4376 : int64 option) = State.trace_state.Value
    let v4391 : US0 = v4375.l0
    let v4392 : bool = v4374.l0
    let v4393 : bool = v4392 = false
    let v4396 : bool =
        if v4393 then
            false
        else
            let v4394 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v4391
            let v4395 : bool = 1 >= v4394
            v4395
    if v4396 then
        let v4397 : int64 = v4343.l0
        let v4398 : int64 = v4397 + 1L
        v4343.l0 <- v4398
        let v4401 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v4401 |> Some
        let struct (v4409 : Mut0, v4410 : Mut1, v4411 : Mut2, v4412 : Mut3, v4413 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v4432 : US3 option = None
        let _v4432 = ref v4432 
        match v4413 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4433 : int64 = x
        let v4434 : US3 = US3_0(v4433)
        v4434 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4432.Value <- x
        let v4435 : US3 option = _v4432.Value 
        let v4458 : US3 = US3_1
        let v4459 : (US3 option -> US3) = Option.defaultValue v4458 
        let v4460 : US3 = v4459 v4435
        let v4558 : System.DateTime =
            match v4460 with
            | US3_1 -> (* None *)
                let v4550 : System.DateTime = System.DateTime.Now
                v4550
            | US3_0(v4468) -> (* Some *)
                let v4471 : System.DateTime = System.DateTime.Now
                let v4480 : (System.DateTime -> int64) = _.Ticks
                let v4481 : int64 = v4480 v4471
                let v4488 : int64 = v4481 - v4468
                let v4491 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4492 : System.TimeSpan = v4491 v4488
                let v4501 : (System.TimeSpan -> int32) = _.Hours
                let v4502 : int32 = v4501 v4492
                let v4511 : (System.TimeSpan -> int32) = _.Minutes
                let v4512 : int32 = v4511 v4492
                let v4521 : (System.TimeSpan -> int32) = _.Seconds
                let v4522 : int32 = v4521 v4492
                let v4531 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4532 : int32 = v4531 v4492
                let v4541 : System.DateTime = System.DateTime (1, 1, 1, v4502, v4512, v4522, v4532)
                v4541
        let v4561 : string = method4()
        let v4570 : (string -> string) = v4558.ToString
        let v4571 : string = v4570 v4561
        let result = v4571 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v4580 : US3 option = None
        let _v4580 = ref v4580 
        match v4413 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4581 : int64 = x
        let v4582 : US3 = US3_0(v4581)
        v4582 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4580.Value <- x
        let v4583 : US3 option = _v4580.Value 
        let v4606 : US3 = US3_1
        let v4607 : (US3 option -> US3) = Option.defaultValue v4606 
        let v4608 : US3 = v4607 v4583
        let v4706 : System.DateTime =
            match v4608 with
            | US3_1 -> (* None *)
                let v4698 : System.DateTime = System.DateTime.Now
                v4698
            | US3_0(v4616) -> (* Some *)
                let v4619 : System.DateTime = System.DateTime.Now
                let v4628 : (System.DateTime -> int64) = _.Ticks
                let v4629 : int64 = v4628 v4619
                let v4636 : int64 = v4629 - v4616
                let v4639 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4640 : System.TimeSpan = v4639 v4636
                let v4649 : (System.TimeSpan -> int32) = _.Hours
                let v4650 : int32 = v4649 v4640
                let v4659 : (System.TimeSpan -> int32) = _.Minutes
                let v4660 : int32 = v4659 v4640
                let v4669 : (System.TimeSpan -> int32) = _.Seconds
                let v4670 : int32 = v4669 v4640
                let v4679 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4680 : int32 = v4679 v4640
                let v4689 : System.DateTime = System.DateTime (1, 1, 1, v4650, v4660, v4670, v4680)
                v4689
        let v4709 : string = method4()
        let v4718 : (string -> string) = v4706.ToString
        let v4719 : string = v4718 v4709
        let result = v4719 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v4726 : string = $"near_sdk::env::block_timestamp()"
        let v4727 : uint64 = Fable.Core.RustInterop.emitRustExpr () v4726 
        let v4730 : US3 option = None
        let _v4730 = ref v4730 
        match v4413 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4731 : int64 = x
        let v4732 : US3 = US3_0(v4731)
        v4732 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4730.Value <- x
        let v4733 : US3 option = _v4730.Value 
        let v4756 : US3 = US3_1
        let v4757 : (US3 option -> US3) = Option.defaultValue v4756 
        let v4758 : US3 = v4757 v4733
        let v4771 : uint64 =
            match v4758 with
            | US3_1 -> (* None *)
                v4727
            | US3_0(v4766) -> (* Some *)
                let v4767 : (int64 -> uint64) = uint64
                let v4768 : uint64 = v4767 v4766
                let v4769 : uint64 = v4727 - v4768
                v4769
        let v4772 : uint64 = v4771 / 1000000000UL
        let v4773 : uint64 = v4772 % 60UL
        let v4774 : uint64 = v4772 / 60UL
        let v4775 : uint64 = v4774 % 60UL
        let v4776 : uint64 = v4772 / 3600UL
        let v4777 : uint64 = v4776 % 24UL
        let v4778 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v4779 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v4777, v4775, v4773) v4778 
        let v4780 : string = "fable_library_rust::String_::fromString($0)"
        let v4781 : string = Fable.Core.RustInterop.emitRustExpr v4779 v4780 
        let result = v4781 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v4784 : US3 option = None
        let _v4784 = ref v4784 
        match v4413 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4785 : int64 = x
        let v4786 : US3 = US3_0(v4785)
        v4786 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4784.Value <- x
        let v4787 : US3 option = _v4784.Value 
        let v4810 : US3 = US3_1
        let v4811 : (US3 option -> US3) = Option.defaultValue v4810 
        let v4812 : US3 = v4811 v4787
        let v4910 : System.DateTime =
            match v4812 with
            | US3_1 -> (* None *)
                let v4902 : System.DateTime = System.DateTime.Now
                v4902
            | US3_0(v4820) -> (* Some *)
                let v4823 : System.DateTime = System.DateTime.Now
                let v4832 : (System.DateTime -> int64) = _.Ticks
                let v4833 : int64 = v4832 v4823
                let v4840 : int64 = v4833 - v4820
                let v4843 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4844 : System.TimeSpan = v4843 v4840
                let v4853 : (System.TimeSpan -> int32) = _.Hours
                let v4854 : int32 = v4853 v4844
                let v4863 : (System.TimeSpan -> int32) = _.Minutes
                let v4864 : int32 = v4863 v4844
                let v4873 : (System.TimeSpan -> int32) = _.Seconds
                let v4874 : int32 = v4873 v4844
                let v4883 : (System.TimeSpan -> int32) = _.Milliseconds
                let v4884 : int32 = v4883 v4844
                let v4893 : System.DateTime = System.DateTime (1, 1, 1, v4854, v4864, v4874, v4884)
                v4893
        let v4913 : string = method5()
        let v4922 : (string -> string) = v4910.ToString
        let v4923 : string = v4922 v4913
        let result = v4923 
        #endif
#if FABLE_COMPILER_PYTHON
        let v4932 : US3 option = None
        let _v4932 = ref v4932 
        match v4413 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v4933 : int64 = x
        let v4934 : US3 = US3_0(v4933)
        v4934 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v4932.Value <- x
        let v4935 : US3 option = _v4932.Value 
        let v4958 : US3 = US3_1
        let v4959 : (US3 option -> US3) = Option.defaultValue v4958 
        let v4960 : US3 = v4959 v4935
        let v5058 : System.DateTime =
            match v4960 with
            | US3_1 -> (* None *)
                let v5050 : System.DateTime = System.DateTime.Now
                v5050
            | US3_0(v4968) -> (* Some *)
                let v4971 : System.DateTime = System.DateTime.Now
                let v4980 : (System.DateTime -> int64) = _.Ticks
                let v4981 : int64 = v4980 v4971
                let v4988 : int64 = v4981 - v4968
                let v4991 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v4992 : System.TimeSpan = v4991 v4988
                let v5001 : (System.TimeSpan -> int32) = _.Hours
                let v5002 : int32 = v5001 v4992
                let v5011 : (System.TimeSpan -> int32) = _.Minutes
                let v5012 : int32 = v5011 v4992
                let v5021 : (System.TimeSpan -> int32) = _.Seconds
                let v5022 : int32 = v5021 v4992
                let v5031 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5032 : int32 = v5031 v4992
                let v5041 : System.DateTime = System.DateTime (1, 1, 1, v5002, v5012, v5022, v5032)
                v5041
        let v5061 : string = method5()
        let v5070 : (string -> string) = v5058.ToString
        let v5071 : string = v5070 v5061
        let result = v5071 
        #endif
#else
        let v5080 : US3 option = None
        let _v5080 = ref v5080 
        match v4413 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5081 : int64 = x
        let v5082 : US3 = US3_0(v5081)
        v5082 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5080.Value <- x
        let v5083 : US3 option = _v5080.Value 
        let v5106 : US3 = US3_1
        let v5107 : (US3 option -> US3) = Option.defaultValue v5106 
        let v5108 : US3 = v5107 v5083
        let v5206 : System.DateTime =
            match v5108 with
            | US3_1 -> (* None *)
                let v5198 : System.DateTime = System.DateTime.Now
                v5198
            | US3_0(v5116) -> (* Some *)
                let v5119 : System.DateTime = System.DateTime.Now
                let v5128 : (System.DateTime -> int64) = _.Ticks
                let v5129 : int64 = v5128 v5119
                let v5136 : int64 = v5129 - v5116
                let v5139 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5140 : System.TimeSpan = v5139 v5136
                let v5149 : (System.TimeSpan -> int32) = _.Hours
                let v5150 : int32 = v5149 v5140
                let v5159 : (System.TimeSpan -> int32) = _.Minutes
                let v5160 : int32 = v5159 v5140
                let v5169 : (System.TimeSpan -> int32) = _.Seconds
                let v5170 : int32 = v5169 v5140
                let v5179 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5180 : int32 = v5179 v5140
                let v5189 : System.DateTime = System.DateTime (1, 1, 1, v5150, v5160, v5170, v5180)
                v5189
        let v5209 : string = method5()
        let v5218 : (string -> string) = v5206.ToString
        let v5219 : string = v5218 v5209
        let result = v5219 
        #endif
        let v5226 : string = result
        let v5388 : string = "Debug"
        let v5389 : (unit -> string) = v5388.ToLower
        let v5390 : string = v5389 ()
        let v5399 : string = v5390.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5431 : string = "inline_colorization::color_bright_blue"
        let v5432 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5431 
        let v5433 : string = "&*$0"
        let v5434 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5399 v5433 
        let v5435 : string = "inline_colorization::color_reset"
        let v5436 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5435 
        let v5437 : string = "\"{v5432}{v5434}{v5436}\""
        let v5438 : string = @$"format!(" + v5437 + ")"
        let v5439 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5438 
        let v5440 : string = "fable_library_rust::String_::fromString($0)"
        let v5441 : string = Fable.Core.RustInterop.emitRustExpr v5439 v5440 
        let result = v5441 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5442 : string = "inline_colorization::color_bright_blue"
        let v5443 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5442 
        let v5444 : string = "&*$0"
        let v5445 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5399 v5444 
        let v5446 : string = "inline_colorization::color_reset"
        let v5447 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5446 
        let v5448 : string = "\"{v5443}{v5445}{v5447}\""
        let v5449 : string = @$"format!(" + v5448 + ")"
        let v5450 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5449 
        let v5451 : string = "fable_library_rust::String_::fromString($0)"
        let v5452 : string = Fable.Core.RustInterop.emitRustExpr v5450 v5451 
        let result = v5452 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5453 : string = "inline_colorization::color_bright_blue"
        let v5454 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5453 
        let v5455 : string = "&*$0"
        let v5456 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5399 v5455 
        let v5457 : string = "inline_colorization::color_reset"
        let v5458 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5457 
        let v5459 : string = "\"{v5454}{v5456}{v5458}\""
        let v5460 : string = @$"format!(" + v5459 + ")"
        let v5461 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v5460 
        let v5462 : string = "fable_library_rust::String_::fromString($0)"
        let v5463 : string = Fable.Core.RustInterop.emitRustExpr v5461 v5462 
        let result = v5463 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v5464 : string = "\u001b[94m"
        let v5465 : string = method6()
        let v5466 : string = v5464 + v5399 
        let v5467 : string = v5466 + v5465 
        let result = v5467 
        #endif
#if FABLE_COMPILER_PYTHON
        let v5468 : string = "\u001b[94m"
        let v5469 : string = method6()
        let v5470 : string = v5468 + v5399 
        let v5471 : string = v5470 + v5469 
        let result = v5471 
        #endif
#else
        let v5472 : string = "\u001b[94m"
        let v5473 : string = method6()
        let v5474 : string = v5472 + v5399 
        let v5475 : string = v5474 + v5473 
        let result = v5475 
        #endif
        let v5476 : string = result
        let v5486 : int64 = v4409.l0
        let v5487 : string = ""
        let v5488 : Mut4 = {l0 = v5487} : Mut4
        let v5491 : string = "{ "
        let v5492 : string = $"{v5491}"
        let v5499 : string = v5488.l0
        let v5500 : string = v5499 + v5492 
        v5488.l0 <- v5500
        let v5503 : string = "result"
        let v5504 : string = $"{v5503}"
        let v5511 : string = v5488.l0
        let v5512 : string = v5511 + v5504 
        v5488.l0 <- v5512
        let v5515 : string = " = "
        let v5516 : string = $"{v5515}"
        let v5523 : string = v5488.l0
        let v5524 : string = v5523 + v5516 
        v5488.l0 <- v5524
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5527 : string = "format!(\"{:#?}\", $0)"
        let v5528 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4332 v5527 
        let v5529 : string = "fable_library_rust::String_::fromString($0)"
        let v5530 : string = Fable.Core.RustInterop.emitRustExpr v5528 v5529 
        let result = v5530 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5531 : string = "format!(\"{:#?}\", $0)"
        let v5532 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4332 v5531 
        let v5533 : string = "fable_library_rust::String_::fromString($0)"
        let v5534 : string = Fable.Core.RustInterop.emitRustExpr v5532 v5533 
        let result = v5534 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5535 : string = "format!(\"{:#?}\", $0)"
        let v5536 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4332 v5535 
        let v5537 : string = "fable_library_rust::String_::fromString($0)"
        let v5538 : string = Fable.Core.RustInterop.emitRustExpr v5536 v5537 
        let result = v5538 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v5541 : string = $"%A{v4332}"
        let result = v5541 
        #endif
#if FABLE_COMPILER_PYTHON
        let v5550 : string = $"%A{v4332}"
        let result = v5550 
        #endif
#else
        let v5559 : string = $"%A{v4332}"
        let result = v5559 
        #endif
        let v5566 : string = result
        let v5583 : string = $"{v5566}"
        let v5590 : string = v5488.l0
        let v5591 : string = v5590 + v5583 
        v5488.l0 <- v5591
        let v5594 : string = " }"
        let v5595 : string = $"{v5594}"
        let v5602 : string = v5488.l0
        let v5603 : string = v5602 + v5595 
        v5488.l0 <- v5603
        let v5604 : string = v5488.l0
        let v5607 : (unit -> string) = closure8()
        let v5608 : string = $"{v5226} {v5476} #{v5486} %s{v5607 ()} / {v5604}"
        let v5615 : char list = []
        let v5620 : (char list -> (char [])) = List.toArray
        let v5621 : (char []) = v5620 v5615
        let v5628 : string = v5608.TrimStart v5621 
        let v5667 : char list = []
        let v5670 : char list = '/' :: v5667 
        let v5679 : char list = ' ' :: v5670 
        let v5690 : (char list -> (char [])) = List.toArray
        let v5691 : (char []) = v5690 v5679
        let v5698 : string = v5628.TrimEnd v5691 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5739 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v5698 v5739 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v5740 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v5698 v5740 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v5741 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v5698 v5741 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v5698 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v5698 
        let result = () 
        #endif
#else
        System.Console.WriteLine v5698 
        let result = () 
        #endif
        result
        let v5770 : (string -> unit) = v4344.l0
        v5770 v5698
    let v5771 : string = "v4332.logs()"
    let v5772 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v5771 
    let v5773 : string = "true; let _result : Vec<_> = v5772.into_iter().map(|x| { //"
    let v5774 : bool = Fable.Core.RustInterop.emitRustExpr () v5773 
    let v5775 : string = "x"
    let v5776 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v5775 
    let v5777 : string = "String::from($0)"
    let v5778 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5776 v5777 
    let v5779 : string = "true; $0 }).collect::<Vec<_>>()"
    let v5780 : bool = Fable.Core.RustInterop.emitRustExpr v5778 v5779 
    let v5781 : string = "_result"
    let v5782 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v5781 
    let v5783 : string = "$0.iter().for_each(|x| { $1(x.clone()); })"
    let v5784 : (std_string_String -> unit) = closure9()
    Fable.Core.RustInterop.emitRustExpr struct (v5782, v5784) v5783 
    let v5785 : string = "  println!(\"\\n\\n state_main transact result: {:#?}\", v4332.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v5785 
    let v5786 : string = "  println!(\"\\n\\n print_usd:\"); //"
    Fable.Core.RustInterop.emitRustExpr () v5786 
    let v5787 : string = "  print_usd(v4332.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v5787 
    let v5788 : string = "$0.into_result()"
    let v5789 : Result<near_workspaces_result_ExecutionResult<near_workspaces_result_Value>, near_workspaces_result_ExecutionResult<near_primitives_errors_TxExecutionError>> = Fable.Core.RustInterop.emitRustExpr v4332 v5788 
    let v5792 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v5792 |> Some
    let struct (v5800 : Mut0, v5801 : Mut1, v5802 : Mut2, v5803 : Mut3, v5804 : int64 option) = State.trace_state.Value
    let v5821 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v5821 |> Some
    let struct (v5829 : Mut0, v5830 : Mut1, v5831 : Mut2, v5832 : Mut3, v5833 : int64 option) = State.trace_state.Value
    let v5848 : US0 = v5832.l0
    let v5849 : bool = v5831.l0
    let v5850 : bool = v5849 = false
    let v5853 : bool =
        if v5850 then
            false
        else
            let v5851 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v5848
            let v5852 : bool = 1 >= v5851
            v5852
    if v5853 then
        let v5854 : int64 = v5800.l0
        let v5855 : int64 = v5854 + 1L
        v5800.l0 <- v5855
        let v5858 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v5858 |> Some
        let struct (v5866 : Mut0, v5867 : Mut1, v5868 : Mut2, v5869 : Mut3, v5870 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v5889 : US3 option = None
        let _v5889 = ref v5889 
        match v5870 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v5890 : int64 = x
        let v5891 : US3 = US3_0(v5890)
        v5891 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v5889.Value <- x
        let v5892 : US3 option = _v5889.Value 
        let v5915 : US3 = US3_1
        let v5916 : (US3 option -> US3) = Option.defaultValue v5915 
        let v5917 : US3 = v5916 v5892
        let v6015 : System.DateTime =
            match v5917 with
            | US3_1 -> (* None *)
                let v6007 : System.DateTime = System.DateTime.Now
                v6007
            | US3_0(v5925) -> (* Some *)
                let v5928 : System.DateTime = System.DateTime.Now
                let v5937 : (System.DateTime -> int64) = _.Ticks
                let v5938 : int64 = v5937 v5928
                let v5945 : int64 = v5938 - v5925
                let v5948 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v5949 : System.TimeSpan = v5948 v5945
                let v5958 : (System.TimeSpan -> int32) = _.Hours
                let v5959 : int32 = v5958 v5949
                let v5968 : (System.TimeSpan -> int32) = _.Minutes
                let v5969 : int32 = v5968 v5949
                let v5978 : (System.TimeSpan -> int32) = _.Seconds
                let v5979 : int32 = v5978 v5949
                let v5988 : (System.TimeSpan -> int32) = _.Milliseconds
                let v5989 : int32 = v5988 v5949
                let v5998 : System.DateTime = System.DateTime (1, 1, 1, v5959, v5969, v5979, v5989)
                v5998
        let v6018 : string = method4()
        let v6027 : (string -> string) = v6015.ToString
        let v6028 : string = v6027 v6018
        let result = v6028 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6037 : US3 option = None
        let _v6037 = ref v6037 
        match v5870 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v6038 : int64 = x
        let v6039 : US3 = US3_0(v6038)
        v6039 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6037.Value <- x
        let v6040 : US3 option = _v6037.Value 
        let v6063 : US3 = US3_1
        let v6064 : (US3 option -> US3) = Option.defaultValue v6063 
        let v6065 : US3 = v6064 v6040
        let v6163 : System.DateTime =
            match v6065 with
            | US3_1 -> (* None *)
                let v6155 : System.DateTime = System.DateTime.Now
                v6155
            | US3_0(v6073) -> (* Some *)
                let v6076 : System.DateTime = System.DateTime.Now
                let v6085 : (System.DateTime -> int64) = _.Ticks
                let v6086 : int64 = v6085 v6076
                let v6093 : int64 = v6086 - v6073
                let v6096 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v6097 : System.TimeSpan = v6096 v6093
                let v6106 : (System.TimeSpan -> int32) = _.Hours
                let v6107 : int32 = v6106 v6097
                let v6116 : (System.TimeSpan -> int32) = _.Minutes
                let v6117 : int32 = v6116 v6097
                let v6126 : (System.TimeSpan -> int32) = _.Seconds
                let v6127 : int32 = v6126 v6097
                let v6136 : (System.TimeSpan -> int32) = _.Milliseconds
                let v6137 : int32 = v6136 v6097
                let v6146 : System.DateTime = System.DateTime (1, 1, 1, v6107, v6117, v6127, v6137)
                v6146
        let v6166 : string = method4()
        let v6175 : (string -> string) = v6163.ToString
        let v6176 : string = v6175 v6166
        let result = v6176 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v6183 : string = $"near_sdk::env::block_timestamp()"
        let v6184 : uint64 = Fable.Core.RustInterop.emitRustExpr () v6183 
        let v6187 : US3 option = None
        let _v6187 = ref v6187 
        match v5870 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v6188 : int64 = x
        let v6189 : US3 = US3_0(v6188)
        v6189 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6187.Value <- x
        let v6190 : US3 option = _v6187.Value 
        let v6213 : US3 = US3_1
        let v6214 : (US3 option -> US3) = Option.defaultValue v6213 
        let v6215 : US3 = v6214 v6190
        let v6228 : uint64 =
            match v6215 with
            | US3_1 -> (* None *)
                v6184
            | US3_0(v6223) -> (* Some *)
                let v6224 : (int64 -> uint64) = uint64
                let v6225 : uint64 = v6224 v6223
                let v6226 : uint64 = v6184 - v6225
                v6226
        let v6229 : uint64 = v6228 / 1000000000UL
        let v6230 : uint64 = v6229 % 60UL
        let v6231 : uint64 = v6229 / 60UL
        let v6232 : uint64 = v6231 % 60UL
        let v6233 : uint64 = v6229 / 3600UL
        let v6234 : uint64 = v6233 % 24UL
        let v6235 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v6236 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v6234, v6232, v6230) v6235 
        let v6237 : string = "fable_library_rust::String_::fromString($0)"
        let v6238 : string = Fable.Core.RustInterop.emitRustExpr v6236 v6237 
        let result = v6238 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v6241 : US3 option = None
        let _v6241 = ref v6241 
        match v5870 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v6242 : int64 = x
        let v6243 : US3 = US3_0(v6242)
        v6243 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6241.Value <- x
        let v6244 : US3 option = _v6241.Value 
        let v6267 : US3 = US3_1
        let v6268 : (US3 option -> US3) = Option.defaultValue v6267 
        let v6269 : US3 = v6268 v6244
        let v6367 : System.DateTime =
            match v6269 with
            | US3_1 -> (* None *)
                let v6359 : System.DateTime = System.DateTime.Now
                v6359
            | US3_0(v6277) -> (* Some *)
                let v6280 : System.DateTime = System.DateTime.Now
                let v6289 : (System.DateTime -> int64) = _.Ticks
                let v6290 : int64 = v6289 v6280
                let v6297 : int64 = v6290 - v6277
                let v6300 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v6301 : System.TimeSpan = v6300 v6297
                let v6310 : (System.TimeSpan -> int32) = _.Hours
                let v6311 : int32 = v6310 v6301
                let v6320 : (System.TimeSpan -> int32) = _.Minutes
                let v6321 : int32 = v6320 v6301
                let v6330 : (System.TimeSpan -> int32) = _.Seconds
                let v6331 : int32 = v6330 v6301
                let v6340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v6341 : int32 = v6340 v6301
                let v6350 : System.DateTime = System.DateTime (1, 1, 1, v6311, v6321, v6331, v6341)
                v6350
        let v6370 : string = method5()
        let v6379 : (string -> string) = v6367.ToString
        let v6380 : string = v6379 v6370
        let result = v6380 
        #endif
#if FABLE_COMPILER_PYTHON
        let v6389 : US3 option = None
        let _v6389 = ref v6389 
        match v5870 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v6390 : int64 = x
        let v6391 : US3 = US3_0(v6390)
        v6391 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6389.Value <- x
        let v6392 : US3 option = _v6389.Value 
        let v6415 : US3 = US3_1
        let v6416 : (US3 option -> US3) = Option.defaultValue v6415 
        let v6417 : US3 = v6416 v6392
        let v6515 : System.DateTime =
            match v6417 with
            | US3_1 -> (* None *)
                let v6507 : System.DateTime = System.DateTime.Now
                v6507
            | US3_0(v6425) -> (* Some *)
                let v6428 : System.DateTime = System.DateTime.Now
                let v6437 : (System.DateTime -> int64) = _.Ticks
                let v6438 : int64 = v6437 v6428
                let v6445 : int64 = v6438 - v6425
                let v6448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v6449 : System.TimeSpan = v6448 v6445
                let v6458 : (System.TimeSpan -> int32) = _.Hours
                let v6459 : int32 = v6458 v6449
                let v6468 : (System.TimeSpan -> int32) = _.Minutes
                let v6469 : int32 = v6468 v6449
                let v6478 : (System.TimeSpan -> int32) = _.Seconds
                let v6479 : int32 = v6478 v6449
                let v6488 : (System.TimeSpan -> int32) = _.Milliseconds
                let v6489 : int32 = v6488 v6449
                let v6498 : System.DateTime = System.DateTime (1, 1, 1, v6459, v6469, v6479, v6489)
                v6498
        let v6518 : string = method5()
        let v6527 : (string -> string) = v6515.ToString
        let v6528 : string = v6527 v6518
        let result = v6528 
        #endif
#else
        let v6537 : US3 option = None
        let _v6537 = ref v6537 
        match v5870 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v6538 : int64 = x
        let v6539 : US3 = US3_0(v6538)
        v6539 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v6537.Value <- x
        let v6540 : US3 option = _v6537.Value 
        let v6563 : US3 = US3_1
        let v6564 : (US3 option -> US3) = Option.defaultValue v6563 
        let v6565 : US3 = v6564 v6540
        let v6663 : System.DateTime =
            match v6565 with
            | US3_1 -> (* None *)
                let v6655 : System.DateTime = System.DateTime.Now
                v6655
            | US3_0(v6573) -> (* Some *)
                let v6576 : System.DateTime = System.DateTime.Now
                let v6585 : (System.DateTime -> int64) = _.Ticks
                let v6586 : int64 = v6585 v6576
                let v6593 : int64 = v6586 - v6573
                let v6596 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v6597 : System.TimeSpan = v6596 v6593
                let v6606 : (System.TimeSpan -> int32) = _.Hours
                let v6607 : int32 = v6606 v6597
                let v6616 : (System.TimeSpan -> int32) = _.Minutes
                let v6617 : int32 = v6616 v6597
                let v6626 : (System.TimeSpan -> int32) = _.Seconds
                let v6627 : int32 = v6626 v6597
                let v6636 : (System.TimeSpan -> int32) = _.Milliseconds
                let v6637 : int32 = v6636 v6597
                let v6646 : System.DateTime = System.DateTime (1, 1, 1, v6607, v6617, v6627, v6637)
                v6646
        let v6666 : string = method5()
        let v6675 : (string -> string) = v6663.ToString
        let v6676 : string = v6675 v6666
        let result = v6676 
        #endif
        let v6683 : string = result
        let v6845 : string = "Debug"
        let v6846 : (unit -> string) = v6845.ToLower
        let v6847 : string = v6846 ()
        let v6856 : string = v6847.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6888 : string = "inline_colorization::color_bright_blue"
        let v6889 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6888 
        let v6890 : string = "&*$0"
        let v6891 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6856 v6890 
        let v6892 : string = "inline_colorization::color_reset"
        let v6893 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6892 
        let v6894 : string = "\"{v6889}{v6891}{v6893}\""
        let v6895 : string = @$"format!(" + v6894 + ")"
        let v6896 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6895 
        let v6897 : string = "fable_library_rust::String_::fromString($0)"
        let v6898 : string = Fable.Core.RustInterop.emitRustExpr v6896 v6897 
        let result = v6898 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6899 : string = "inline_colorization::color_bright_blue"
        let v6900 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6899 
        let v6901 : string = "&*$0"
        let v6902 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6856 v6901 
        let v6903 : string = "inline_colorization::color_reset"
        let v6904 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6903 
        let v6905 : string = "\"{v6900}{v6902}{v6904}\""
        let v6906 : string = @$"format!(" + v6905 + ")"
        let v6907 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6906 
        let v6908 : string = "fable_library_rust::String_::fromString($0)"
        let v6909 : string = Fable.Core.RustInterop.emitRustExpr v6907 v6908 
        let result = v6909 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v6910 : string = "inline_colorization::color_bright_blue"
        let v6911 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6910 
        let v6912 : string = "&*$0"
        let v6913 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6856 v6912 
        let v6914 : string = "inline_colorization::color_reset"
        let v6915 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v6914 
        let v6916 : string = "\"{v6911}{v6913}{v6915}\""
        let v6917 : string = @$"format!(" + v6916 + ")"
        let v6918 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6917 
        let v6919 : string = "fable_library_rust::String_::fromString($0)"
        let v6920 : string = Fable.Core.RustInterop.emitRustExpr v6918 v6919 
        let result = v6920 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v6921 : string = "\u001b[94m"
        let v6922 : string = method6()
        let v6923 : string = v6921 + v6856 
        let v6924 : string = v6923 + v6922 
        let result = v6924 
        #endif
#if FABLE_COMPILER_PYTHON
        let v6925 : string = "\u001b[94m"
        let v6926 : string = method6()
        let v6927 : string = v6925 + v6856 
        let v6928 : string = v6927 + v6926 
        let result = v6928 
        #endif
#else
        let v6929 : string = "\u001b[94m"
        let v6930 : string = method6()
        let v6931 : string = v6929 + v6856 
        let v6932 : string = v6931 + v6930 
        let result = v6932 
        #endif
        let v6933 : string = result
        let v6943 : int64 = v5866.l0
        let v6944 : string = ""
        let v6945 : Mut4 = {l0 = v6944} : Mut4
        let v6948 : string = "{ "
        let v6949 : string = $"{v6948}"
        let v6956 : string = v6945.l0
        let v6957 : string = v6956 + v6949 
        v6945.l0 <- v6957
        let v6960 : string = "result2"
        let v6961 : string = $"{v6960}"
        let v6968 : string = v6945.l0
        let v6969 : string = v6968 + v6961 
        v6945.l0 <- v6969
        let v6972 : string = " = "
        let v6973 : string = $"{v6972}"
        let v6980 : string = v6945.l0
        let v6981 : string = v6980 + v6973 
        v6945.l0 <- v6981
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v6984 : string = "format!(\"{:#?}\", $0)"
        let v6985 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5789 v6984 
        let v6986 : string = "fable_library_rust::String_::fromString($0)"
        let v6987 : string = Fable.Core.RustInterop.emitRustExpr v6985 v6986 
        let result = v6987 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v6988 : string = "format!(\"{:#?}\", $0)"
        let v6989 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5789 v6988 
        let v6990 : string = "fable_library_rust::String_::fromString($0)"
        let v6991 : string = Fable.Core.RustInterop.emitRustExpr v6989 v6990 
        let result = v6991 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v6992 : string = "format!(\"{:#?}\", $0)"
        let v6993 : std_string_String = Fable.Core.RustInterop.emitRustExpr v5789 v6992 
        let v6994 : string = "fable_library_rust::String_::fromString($0)"
        let v6995 : string = Fable.Core.RustInterop.emitRustExpr v6993 v6994 
        let result = v6995 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v6998 : string = $"%A{v5789}"
        let result = v6998 
        #endif
#if FABLE_COMPILER_PYTHON
        let v7007 : string = $"%A{v5789}"
        let result = v7007 
        #endif
#else
        let v7016 : string = $"%A{v5789}"
        let result = v7016 
        #endif
        let v7023 : string = result
        let v7040 : string = $"{v7023}"
        let v7047 : string = v6945.l0
        let v7048 : string = v7047 + v7040 
        v6945.l0 <- v7048
        let v7051 : string = " }"
        let v7052 : string = $"{v7051}"
        let v7059 : string = v6945.l0
        let v7060 : string = v7059 + v7052 
        v6945.l0 <- v7060
        let v7061 : string = v6945.l0
        let v7064 : (unit -> string) = closure10()
        let v7065 : string = $"{v6683} {v6933} #{v6943} %s{v7064 ()} / {v7061}"
        let v7072 : char list = []
        let v7077 : (char list -> (char [])) = List.toArray
        let v7078 : (char []) = v7077 v7072
        let v7085 : string = v7065.TrimStart v7078 
        let v7124 : char list = []
        let v7127 : char list = '/' :: v7124 
        let v7136 : char list = ' ' :: v7127 
        let v7147 : (char list -> (char [])) = List.toArray
        let v7148 : (char []) = v7147 v7136
        let v7155 : string = v7085.TrimEnd v7148 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v7196 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v7155 v7196 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v7197 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v7155 v7197 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v7198 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v7155 v7198 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v7155 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v7155 
        let result = () 
        #endif
#else
        System.Console.WriteLine v7155 
        let result = () 
        #endif
        result
        let v7227 : (string -> unit) = v5801.l0
        v7227 v7155
    let v7228 : near_workspaces_result_ExecutionFinalResult = method10(v4332)
    let v7229 : string = "v7228.receipt_failures()"
    let v7230 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v7229 
    let v7233 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v7233 |> Some
    let struct (v7241 : Mut0, v7242 : Mut1, v7243 : Mut2, v7244 : Mut3, v7245 : int64 option) = State.trace_state.Value
    let v7262 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v7262 |> Some
    let struct (v7270 : Mut0, v7271 : Mut1, v7272 : Mut2, v7273 : Mut3, v7274 : int64 option) = State.trace_state.Value
    let v7289 : US0 = v7273.l0
    let v7290 : bool = v7272.l0
    let v7291 : bool = v7290 = false
    let v7294 : bool =
        if v7291 then
            false
        else
            let v7292 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v7289
            let v7293 : bool = 1 >= v7292
            v7293
    if v7294 then
        let v7295 : int64 = v7241.l0
        let v7296 : int64 = v7295 + 1L
        v7241.l0 <- v7296
        let v7299 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v7299 |> Some
        let struct (v7307 : Mut0, v7308 : Mut1, v7309 : Mut2, v7310 : Mut3, v7311 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v7330 : US3 option = None
        let _v7330 = ref v7330 
        match v7311 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7331 : int64 = x
        let v7332 : US3 = US3_0(v7331)
        v7332 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7330.Value <- x
        let v7333 : US3 option = _v7330.Value 
        let v7356 : US3 = US3_1
        let v7357 : (US3 option -> US3) = Option.defaultValue v7356 
        let v7358 : US3 = v7357 v7333
        let v7456 : System.DateTime =
            match v7358 with
            | US3_1 -> (* None *)
                let v7448 : System.DateTime = System.DateTime.Now
                v7448
            | US3_0(v7366) -> (* Some *)
                let v7369 : System.DateTime = System.DateTime.Now
                let v7378 : (System.DateTime -> int64) = _.Ticks
                let v7379 : int64 = v7378 v7369
                let v7386 : int64 = v7379 - v7366
                let v7389 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v7390 : System.TimeSpan = v7389 v7386
                let v7399 : (System.TimeSpan -> int32) = _.Hours
                let v7400 : int32 = v7399 v7390
                let v7409 : (System.TimeSpan -> int32) = _.Minutes
                let v7410 : int32 = v7409 v7390
                let v7419 : (System.TimeSpan -> int32) = _.Seconds
                let v7420 : int32 = v7419 v7390
                let v7429 : (System.TimeSpan -> int32) = _.Milliseconds
                let v7430 : int32 = v7429 v7390
                let v7439 : System.DateTime = System.DateTime (1, 1, 1, v7400, v7410, v7420, v7430)
                v7439
        let v7459 : string = method4()
        let v7468 : (string -> string) = v7456.ToString
        let v7469 : string = v7468 v7459
        let result = v7469 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v7478 : US3 option = None
        let _v7478 = ref v7478 
        match v7311 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7479 : int64 = x
        let v7480 : US3 = US3_0(v7479)
        v7480 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7478.Value <- x
        let v7481 : US3 option = _v7478.Value 
        let v7504 : US3 = US3_1
        let v7505 : (US3 option -> US3) = Option.defaultValue v7504 
        let v7506 : US3 = v7505 v7481
        let v7604 : System.DateTime =
            match v7506 with
            | US3_1 -> (* None *)
                let v7596 : System.DateTime = System.DateTime.Now
                v7596
            | US3_0(v7514) -> (* Some *)
                let v7517 : System.DateTime = System.DateTime.Now
                let v7526 : (System.DateTime -> int64) = _.Ticks
                let v7527 : int64 = v7526 v7517
                let v7534 : int64 = v7527 - v7514
                let v7537 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v7538 : System.TimeSpan = v7537 v7534
                let v7547 : (System.TimeSpan -> int32) = _.Hours
                let v7548 : int32 = v7547 v7538
                let v7557 : (System.TimeSpan -> int32) = _.Minutes
                let v7558 : int32 = v7557 v7538
                let v7567 : (System.TimeSpan -> int32) = _.Seconds
                let v7568 : int32 = v7567 v7538
                let v7577 : (System.TimeSpan -> int32) = _.Milliseconds
                let v7578 : int32 = v7577 v7538
                let v7587 : System.DateTime = System.DateTime (1, 1, 1, v7548, v7558, v7568, v7578)
                v7587
        let v7607 : string = method4()
        let v7616 : (string -> string) = v7604.ToString
        let v7617 : string = v7616 v7607
        let result = v7617 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v7624 : string = $"near_sdk::env::block_timestamp()"
        let v7625 : uint64 = Fable.Core.RustInterop.emitRustExpr () v7624 
        let v7628 : US3 option = None
        let _v7628 = ref v7628 
        match v7311 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7629 : int64 = x
        let v7630 : US3 = US3_0(v7629)
        v7630 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7628.Value <- x
        let v7631 : US3 option = _v7628.Value 
        let v7654 : US3 = US3_1
        let v7655 : (US3 option -> US3) = Option.defaultValue v7654 
        let v7656 : US3 = v7655 v7631
        let v7669 : uint64 =
            match v7656 with
            | US3_1 -> (* None *)
                v7625
            | US3_0(v7664) -> (* Some *)
                let v7665 : (int64 -> uint64) = uint64
                let v7666 : uint64 = v7665 v7664
                let v7667 : uint64 = v7625 - v7666
                v7667
        let v7670 : uint64 = v7669 / 1000000000UL
        let v7671 : uint64 = v7670 % 60UL
        let v7672 : uint64 = v7670 / 60UL
        let v7673 : uint64 = v7672 % 60UL
        let v7674 : uint64 = v7670 / 3600UL
        let v7675 : uint64 = v7674 % 24UL
        let v7676 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v7677 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v7675, v7673, v7671) v7676 
        let v7678 : string = "fable_library_rust::String_::fromString($0)"
        let v7679 : string = Fable.Core.RustInterop.emitRustExpr v7677 v7678 
        let result = v7679 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v7682 : US3 option = None
        let _v7682 = ref v7682 
        match v7311 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7683 : int64 = x
        let v7684 : US3 = US3_0(v7683)
        v7684 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7682.Value <- x
        let v7685 : US3 option = _v7682.Value 
        let v7708 : US3 = US3_1
        let v7709 : (US3 option -> US3) = Option.defaultValue v7708 
        let v7710 : US3 = v7709 v7685
        let v7808 : System.DateTime =
            match v7710 with
            | US3_1 -> (* None *)
                let v7800 : System.DateTime = System.DateTime.Now
                v7800
            | US3_0(v7718) -> (* Some *)
                let v7721 : System.DateTime = System.DateTime.Now
                let v7730 : (System.DateTime -> int64) = _.Ticks
                let v7731 : int64 = v7730 v7721
                let v7738 : int64 = v7731 - v7718
                let v7741 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v7742 : System.TimeSpan = v7741 v7738
                let v7751 : (System.TimeSpan -> int32) = _.Hours
                let v7752 : int32 = v7751 v7742
                let v7761 : (System.TimeSpan -> int32) = _.Minutes
                let v7762 : int32 = v7761 v7742
                let v7771 : (System.TimeSpan -> int32) = _.Seconds
                let v7772 : int32 = v7771 v7742
                let v7781 : (System.TimeSpan -> int32) = _.Milliseconds
                let v7782 : int32 = v7781 v7742
                let v7791 : System.DateTime = System.DateTime (1, 1, 1, v7752, v7762, v7772, v7782)
                v7791
        let v7811 : string = method5()
        let v7820 : (string -> string) = v7808.ToString
        let v7821 : string = v7820 v7811
        let result = v7821 
        #endif
#if FABLE_COMPILER_PYTHON
        let v7830 : US3 option = None
        let _v7830 = ref v7830 
        match v7311 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7831 : int64 = x
        let v7832 : US3 = US3_0(v7831)
        v7832 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7830.Value <- x
        let v7833 : US3 option = _v7830.Value 
        let v7856 : US3 = US3_1
        let v7857 : (US3 option -> US3) = Option.defaultValue v7856 
        let v7858 : US3 = v7857 v7833
        let v7956 : System.DateTime =
            match v7858 with
            | US3_1 -> (* None *)
                let v7948 : System.DateTime = System.DateTime.Now
                v7948
            | US3_0(v7866) -> (* Some *)
                let v7869 : System.DateTime = System.DateTime.Now
                let v7878 : (System.DateTime -> int64) = _.Ticks
                let v7879 : int64 = v7878 v7869
                let v7886 : int64 = v7879 - v7866
                let v7889 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v7890 : System.TimeSpan = v7889 v7886
                let v7899 : (System.TimeSpan -> int32) = _.Hours
                let v7900 : int32 = v7899 v7890
                let v7909 : (System.TimeSpan -> int32) = _.Minutes
                let v7910 : int32 = v7909 v7890
                let v7919 : (System.TimeSpan -> int32) = _.Seconds
                let v7920 : int32 = v7919 v7890
                let v7929 : (System.TimeSpan -> int32) = _.Milliseconds
                let v7930 : int32 = v7929 v7890
                let v7939 : System.DateTime = System.DateTime (1, 1, 1, v7900, v7910, v7920, v7930)
                v7939
        let v7959 : string = method5()
        let v7968 : (string -> string) = v7956.ToString
        let v7969 : string = v7968 v7959
        let result = v7969 
        #endif
#else
        let v7978 : US3 option = None
        let _v7978 = ref v7978 
        match v7311 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v7979 : int64 = x
        let v7980 : US3 = US3_0(v7979)
        v7980 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v7978.Value <- x
        let v7981 : US3 option = _v7978.Value 
        let v8004 : US3 = US3_1
        let v8005 : (US3 option -> US3) = Option.defaultValue v8004 
        let v8006 : US3 = v8005 v7981
        let v8104 : System.DateTime =
            match v8006 with
            | US3_1 -> (* None *)
                let v8096 : System.DateTime = System.DateTime.Now
                v8096
            | US3_0(v8014) -> (* Some *)
                let v8017 : System.DateTime = System.DateTime.Now
                let v8026 : (System.DateTime -> int64) = _.Ticks
                let v8027 : int64 = v8026 v8017
                let v8034 : int64 = v8027 - v8014
                let v8037 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v8038 : System.TimeSpan = v8037 v8034
                let v8047 : (System.TimeSpan -> int32) = _.Hours
                let v8048 : int32 = v8047 v8038
                let v8057 : (System.TimeSpan -> int32) = _.Minutes
                let v8058 : int32 = v8057 v8038
                let v8067 : (System.TimeSpan -> int32) = _.Seconds
                let v8068 : int32 = v8067 v8038
                let v8077 : (System.TimeSpan -> int32) = _.Milliseconds
                let v8078 : int32 = v8077 v8038
                let v8087 : System.DateTime = System.DateTime (1, 1, 1, v8048, v8058, v8068, v8078)
                v8087
        let v8107 : string = method5()
        let v8116 : (string -> string) = v8104.ToString
        let v8117 : string = v8116 v8107
        let result = v8117 
        #endif
        let v8124 : string = result
        let v8286 : string = "Debug"
        let v8287 : (unit -> string) = v8286.ToLower
        let v8288 : string = v8287 ()
        let v8297 : string = v8288.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8329 : string = "inline_colorization::color_bright_blue"
        let v8330 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8329 
        let v8331 : string = "&*$0"
        let v8332 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8297 v8331 
        let v8333 : string = "inline_colorization::color_reset"
        let v8334 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8333 
        let v8335 : string = "\"{v8330}{v8332}{v8334}\""
        let v8336 : string = @$"format!(" + v8335 + ")"
        let v8337 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8336 
        let v8338 : string = "fable_library_rust::String_::fromString($0)"
        let v8339 : string = Fable.Core.RustInterop.emitRustExpr v8337 v8338 
        let result = v8339 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v8340 : string = "inline_colorization::color_bright_blue"
        let v8341 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8340 
        let v8342 : string = "&*$0"
        let v8343 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8297 v8342 
        let v8344 : string = "inline_colorization::color_reset"
        let v8345 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8344 
        let v8346 : string = "\"{v8341}{v8343}{v8345}\""
        let v8347 : string = @$"format!(" + v8346 + ")"
        let v8348 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8347 
        let v8349 : string = "fable_library_rust::String_::fromString($0)"
        let v8350 : string = Fable.Core.RustInterop.emitRustExpr v8348 v8349 
        let result = v8350 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v8351 : string = "inline_colorization::color_bright_blue"
        let v8352 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8351 
        let v8353 : string = "&*$0"
        let v8354 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v8297 v8353 
        let v8355 : string = "inline_colorization::color_reset"
        let v8356 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v8355 
        let v8357 : string = "\"{v8352}{v8354}{v8356}\""
        let v8358 : string = @$"format!(" + v8357 + ")"
        let v8359 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8358 
        let v8360 : string = "fable_library_rust::String_::fromString($0)"
        let v8361 : string = Fable.Core.RustInterop.emitRustExpr v8359 v8360 
        let result = v8361 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v8362 : string = "\u001b[94m"
        let v8363 : string = method6()
        let v8364 : string = v8362 + v8297 
        let v8365 : string = v8364 + v8363 
        let result = v8365 
        #endif
#if FABLE_COMPILER_PYTHON
        let v8366 : string = "\u001b[94m"
        let v8367 : string = method6()
        let v8368 : string = v8366 + v8297 
        let v8369 : string = v8368 + v8367 
        let result = v8369 
        #endif
#else
        let v8370 : string = "\u001b[94m"
        let v8371 : string = method6()
        let v8372 : string = v8370 + v8297 
        let v8373 : string = v8372 + v8371 
        let result = v8373 
        #endif
        let v8374 : string = result
        let v8384 : int64 = v7307.l0
        let v8385 : string = ""
        let v8386 : Mut4 = {l0 = v8385} : Mut4
        let v8389 : string = "{ "
        let v8390 : string = $"{v8389}"
        let v8397 : string = v8386.l0
        let v8398 : string = v8397 + v8390 
        v8386.l0 <- v8398
        let v8401 : string = "receipt_failures"
        let v8402 : string = $"{v8401}"
        let v8409 : string = v8386.l0
        let v8410 : string = v8409 + v8402 
        v8386.l0 <- v8410
        let v8413 : string = " = "
        let v8414 : string = $"{v8413}"
        let v8421 : string = v8386.l0
        let v8422 : string = v8421 + v8414 
        v8386.l0 <- v8422
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8425 : string = "format!(\"{:#?}\", $0)"
        let v8426 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7230 v8425 
        let v8427 : string = "fable_library_rust::String_::fromString($0)"
        let v8428 : string = Fable.Core.RustInterop.emitRustExpr v8426 v8427 
        let result = v8428 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v8429 : string = "format!(\"{:#?}\", $0)"
        let v8430 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7230 v8429 
        let v8431 : string = "fable_library_rust::String_::fromString($0)"
        let v8432 : string = Fable.Core.RustInterop.emitRustExpr v8430 v8431 
        let result = v8432 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v8433 : string = "format!(\"{:#?}\", $0)"
        let v8434 : std_string_String = Fable.Core.RustInterop.emitRustExpr v7230 v8433 
        let v8435 : string = "fable_library_rust::String_::fromString($0)"
        let v8436 : string = Fable.Core.RustInterop.emitRustExpr v8434 v8435 
        let result = v8436 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v8439 : string = $"%A{v7230}"
        let result = v8439 
        #endif
#if FABLE_COMPILER_PYTHON
        let v8448 : string = $"%A{v7230}"
        let result = v8448 
        #endif
#else
        let v8457 : string = $"%A{v7230}"
        let result = v8457 
        #endif
        let v8464 : string = result
        let v8481 : string = $"{v8464}"
        let v8488 : string = v8386.l0
        let v8489 : string = v8488 + v8481 
        v8386.l0 <- v8489
        let v8492 : string = " }"
        let v8493 : string = $"{v8492}"
        let v8500 : string = v8386.l0
        let v8501 : string = v8500 + v8493 
        v8386.l0 <- v8501
        let v8502 : string = v8386.l0
        let v8505 : (unit -> string) = closure11()
        let v8506 : string = $"{v8124} {v8374} #{v8384} %s{v8505 ()} / {v8502}"
        let v8513 : char list = []
        let v8518 : (char list -> (char [])) = List.toArray
        let v8519 : (char []) = v8518 v8513
        let v8526 : string = v8506.TrimStart v8519 
        let v8565 : char list = []
        let v8568 : char list = '/' :: v8565 
        let v8577 : char list = ' ' :: v8568 
        let v8588 : (char list -> (char [])) = List.toArray
        let v8589 : (char []) = v8588 v8577
        let v8596 : string = v8526.TrimEnd v8589 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8637 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v8596 v8637 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v8638 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v8596 v8638 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v8639 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v8596 v8639 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v8596 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v8596 
        let result = () 
        #endif
#else
        System.Console.WriteLine v8596 
        let result = () 
        #endif
        result
        let v8668 : (string -> unit) = v7242.l0
        v8668 v8596
    let v8669 : near_workspaces_result_ExecutionFinalResult = method11(v4332)
    let v8670 : string = "v8669.receipt_outcomes()"
    let v8671 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v8670 
    let v8674 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v8674 |> Some
    let struct (v8682 : Mut0, v8683 : Mut1, v8684 : Mut2, v8685 : Mut3, v8686 : int64 option) = State.trace_state.Value
    let v8703 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v8703 |> Some
    let struct (v8711 : Mut0, v8712 : Mut1, v8713 : Mut2, v8714 : Mut3, v8715 : int64 option) = State.trace_state.Value
    let v8730 : US0 = v8714.l0
    let v8731 : bool = v8713.l0
    let v8732 : bool = v8731 = false
    let v8735 : bool =
        if v8732 then
            false
        else
            let v8733 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v8730
            let v8734 : bool = 1 >= v8733
            v8734
    if v8735 then
        let v8736 : int64 = v8682.l0
        let v8737 : int64 = v8736 + 1L
        v8682.l0 <- v8737
        let v8740 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v8740 |> Some
        let struct (v8748 : Mut0, v8749 : Mut1, v8750 : Mut2, v8751 : Mut3, v8752 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v8771 : US3 option = None
        let _v8771 = ref v8771 
        match v8752 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v8772 : int64 = x
        let v8773 : US3 = US3_0(v8772)
        v8773 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v8771.Value <- x
        let v8774 : US3 option = _v8771.Value 
        let v8797 : US3 = US3_1
        let v8798 : (US3 option -> US3) = Option.defaultValue v8797 
        let v8799 : US3 = v8798 v8774
        let v8897 : System.DateTime =
            match v8799 with
            | US3_1 -> (* None *)
                let v8889 : System.DateTime = System.DateTime.Now
                v8889
            | US3_0(v8807) -> (* Some *)
                let v8810 : System.DateTime = System.DateTime.Now
                let v8819 : (System.DateTime -> int64) = _.Ticks
                let v8820 : int64 = v8819 v8810
                let v8827 : int64 = v8820 - v8807
                let v8830 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v8831 : System.TimeSpan = v8830 v8827
                let v8840 : (System.TimeSpan -> int32) = _.Hours
                let v8841 : int32 = v8840 v8831
                let v8850 : (System.TimeSpan -> int32) = _.Minutes
                let v8851 : int32 = v8850 v8831
                let v8860 : (System.TimeSpan -> int32) = _.Seconds
                let v8861 : int32 = v8860 v8831
                let v8870 : (System.TimeSpan -> int32) = _.Milliseconds
                let v8871 : int32 = v8870 v8831
                let v8880 : System.DateTime = System.DateTime (1, 1, 1, v8841, v8851, v8861, v8871)
                v8880
        let v8900 : string = method4()
        let v8909 : (string -> string) = v8897.ToString
        let v8910 : string = v8909 v8900
        let result = v8910 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v8919 : US3 option = None
        let _v8919 = ref v8919 
        match v8752 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v8920 : int64 = x
        let v8921 : US3 = US3_0(v8920)
        v8921 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v8919.Value <- x
        let v8922 : US3 option = _v8919.Value 
        let v8945 : US3 = US3_1
        let v8946 : (US3 option -> US3) = Option.defaultValue v8945 
        let v8947 : US3 = v8946 v8922
        let v9045 : System.DateTime =
            match v8947 with
            | US3_1 -> (* None *)
                let v9037 : System.DateTime = System.DateTime.Now
                v9037
            | US3_0(v8955) -> (* Some *)
                let v8958 : System.DateTime = System.DateTime.Now
                let v8967 : (System.DateTime -> int64) = _.Ticks
                let v8968 : int64 = v8967 v8958
                let v8975 : int64 = v8968 - v8955
                let v8978 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v8979 : System.TimeSpan = v8978 v8975
                let v8988 : (System.TimeSpan -> int32) = _.Hours
                let v8989 : int32 = v8988 v8979
                let v8998 : (System.TimeSpan -> int32) = _.Minutes
                let v8999 : int32 = v8998 v8979
                let v9008 : (System.TimeSpan -> int32) = _.Seconds
                let v9009 : int32 = v9008 v8979
                let v9018 : (System.TimeSpan -> int32) = _.Milliseconds
                let v9019 : int32 = v9018 v8979
                let v9028 : System.DateTime = System.DateTime (1, 1, 1, v8989, v8999, v9009, v9019)
                v9028
        let v9048 : string = method4()
        let v9057 : (string -> string) = v9045.ToString
        let v9058 : string = v9057 v9048
        let result = v9058 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v9065 : string = $"near_sdk::env::block_timestamp()"
        let v9066 : uint64 = Fable.Core.RustInterop.emitRustExpr () v9065 
        let v9069 : US3 option = None
        let _v9069 = ref v9069 
        match v8752 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9070 : int64 = x
        let v9071 : US3 = US3_0(v9070)
        v9071 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v9069.Value <- x
        let v9072 : US3 option = _v9069.Value 
        let v9095 : US3 = US3_1
        let v9096 : (US3 option -> US3) = Option.defaultValue v9095 
        let v9097 : US3 = v9096 v9072
        let v9110 : uint64 =
            match v9097 with
            | US3_1 -> (* None *)
                v9066
            | US3_0(v9105) -> (* Some *)
                let v9106 : (int64 -> uint64) = uint64
                let v9107 : uint64 = v9106 v9105
                let v9108 : uint64 = v9066 - v9107
                v9108
        let v9111 : uint64 = v9110 / 1000000000UL
        let v9112 : uint64 = v9111 % 60UL
        let v9113 : uint64 = v9111 / 60UL
        let v9114 : uint64 = v9113 % 60UL
        let v9115 : uint64 = v9111 / 3600UL
        let v9116 : uint64 = v9115 % 24UL
        let v9117 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v9118 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9116, v9114, v9112) v9117 
        let v9119 : string = "fable_library_rust::String_::fromString($0)"
        let v9120 : string = Fable.Core.RustInterop.emitRustExpr v9118 v9119 
        let result = v9120 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v9123 : US3 option = None
        let _v9123 = ref v9123 
        match v8752 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9124 : int64 = x
        let v9125 : US3 = US3_0(v9124)
        v9125 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v9123.Value <- x
        let v9126 : US3 option = _v9123.Value 
        let v9149 : US3 = US3_1
        let v9150 : (US3 option -> US3) = Option.defaultValue v9149 
        let v9151 : US3 = v9150 v9126
        let v9249 : System.DateTime =
            match v9151 with
            | US3_1 -> (* None *)
                let v9241 : System.DateTime = System.DateTime.Now
                v9241
            | US3_0(v9159) -> (* Some *)
                let v9162 : System.DateTime = System.DateTime.Now
                let v9171 : (System.DateTime -> int64) = _.Ticks
                let v9172 : int64 = v9171 v9162
                let v9179 : int64 = v9172 - v9159
                let v9182 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v9183 : System.TimeSpan = v9182 v9179
                let v9192 : (System.TimeSpan -> int32) = _.Hours
                let v9193 : int32 = v9192 v9183
                let v9202 : (System.TimeSpan -> int32) = _.Minutes
                let v9203 : int32 = v9202 v9183
                let v9212 : (System.TimeSpan -> int32) = _.Seconds
                let v9213 : int32 = v9212 v9183
                let v9222 : (System.TimeSpan -> int32) = _.Milliseconds
                let v9223 : int32 = v9222 v9183
                let v9232 : System.DateTime = System.DateTime (1, 1, 1, v9193, v9203, v9213, v9223)
                v9232
        let v9252 : string = method5()
        let v9261 : (string -> string) = v9249.ToString
        let v9262 : string = v9261 v9252
        let result = v9262 
        #endif
#if FABLE_COMPILER_PYTHON
        let v9271 : US3 option = None
        let _v9271 = ref v9271 
        match v8752 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9272 : int64 = x
        let v9273 : US3 = US3_0(v9272)
        v9273 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v9271.Value <- x
        let v9274 : US3 option = _v9271.Value 
        let v9297 : US3 = US3_1
        let v9298 : (US3 option -> US3) = Option.defaultValue v9297 
        let v9299 : US3 = v9298 v9274
        let v9397 : System.DateTime =
            match v9299 with
            | US3_1 -> (* None *)
                let v9389 : System.DateTime = System.DateTime.Now
                v9389
            | US3_0(v9307) -> (* Some *)
                let v9310 : System.DateTime = System.DateTime.Now
                let v9319 : (System.DateTime -> int64) = _.Ticks
                let v9320 : int64 = v9319 v9310
                let v9327 : int64 = v9320 - v9307
                let v9330 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v9331 : System.TimeSpan = v9330 v9327
                let v9340 : (System.TimeSpan -> int32) = _.Hours
                let v9341 : int32 = v9340 v9331
                let v9350 : (System.TimeSpan -> int32) = _.Minutes
                let v9351 : int32 = v9350 v9331
                let v9360 : (System.TimeSpan -> int32) = _.Seconds
                let v9361 : int32 = v9360 v9331
                let v9370 : (System.TimeSpan -> int32) = _.Milliseconds
                let v9371 : int32 = v9370 v9331
                let v9380 : System.DateTime = System.DateTime (1, 1, 1, v9341, v9351, v9361, v9371)
                v9380
        let v9400 : string = method5()
        let v9409 : (string -> string) = v9397.ToString
        let v9410 : string = v9409 v9400
        let result = v9410 
        #endif
#else
        let v9419 : US3 option = None
        let _v9419 = ref v9419 
        match v8752 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v9420 : int64 = x
        let v9421 : US3 = US3_0(v9420)
        v9421 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v9419.Value <- x
        let v9422 : US3 option = _v9419.Value 
        let v9445 : US3 = US3_1
        let v9446 : (US3 option -> US3) = Option.defaultValue v9445 
        let v9447 : US3 = v9446 v9422
        let v9545 : System.DateTime =
            match v9447 with
            | US3_1 -> (* None *)
                let v9537 : System.DateTime = System.DateTime.Now
                v9537
            | US3_0(v9455) -> (* Some *)
                let v9458 : System.DateTime = System.DateTime.Now
                let v9467 : (System.DateTime -> int64) = _.Ticks
                let v9468 : int64 = v9467 v9458
                let v9475 : int64 = v9468 - v9455
                let v9478 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v9479 : System.TimeSpan = v9478 v9475
                let v9488 : (System.TimeSpan -> int32) = _.Hours
                let v9489 : int32 = v9488 v9479
                let v9498 : (System.TimeSpan -> int32) = _.Minutes
                let v9499 : int32 = v9498 v9479
                let v9508 : (System.TimeSpan -> int32) = _.Seconds
                let v9509 : int32 = v9508 v9479
                let v9518 : (System.TimeSpan -> int32) = _.Milliseconds
                let v9519 : int32 = v9518 v9479
                let v9528 : System.DateTime = System.DateTime (1, 1, 1, v9489, v9499, v9509, v9519)
                v9528
        let v9548 : string = method5()
        let v9557 : (string -> string) = v9545.ToString
        let v9558 : string = v9557 v9548
        let result = v9558 
        #endif
        let v9565 : string = result
        let v9727 : string = "Debug"
        let v9728 : (unit -> string) = v9727.ToLower
        let v9729 : string = v9728 ()
        let v9738 : string = v9729.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v9770 : string = "inline_colorization::color_bright_blue"
        let v9771 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9770 
        let v9772 : string = "&*$0"
        let v9773 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9738 v9772 
        let v9774 : string = "inline_colorization::color_reset"
        let v9775 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9774 
        let v9776 : string = "\"{v9771}{v9773}{v9775}\""
        let v9777 : string = @$"format!(" + v9776 + ")"
        let v9778 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v9777 
        let v9779 : string = "fable_library_rust::String_::fromString($0)"
        let v9780 : string = Fable.Core.RustInterop.emitRustExpr v9778 v9779 
        let result = v9780 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v9781 : string = "inline_colorization::color_bright_blue"
        let v9782 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9781 
        let v9783 : string = "&*$0"
        let v9784 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9738 v9783 
        let v9785 : string = "inline_colorization::color_reset"
        let v9786 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9785 
        let v9787 : string = "\"{v9782}{v9784}{v9786}\""
        let v9788 : string = @$"format!(" + v9787 + ")"
        let v9789 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v9788 
        let v9790 : string = "fable_library_rust::String_::fromString($0)"
        let v9791 : string = Fable.Core.RustInterop.emitRustExpr v9789 v9790 
        let result = v9791 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v9792 : string = "inline_colorization::color_bright_blue"
        let v9793 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9792 
        let v9794 : string = "&*$0"
        let v9795 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v9738 v9794 
        let v9796 : string = "inline_colorization::color_reset"
        let v9797 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v9796 
        let v9798 : string = "\"{v9793}{v9795}{v9797}\""
        let v9799 : string = @$"format!(" + v9798 + ")"
        let v9800 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v9799 
        let v9801 : string = "fable_library_rust::String_::fromString($0)"
        let v9802 : string = Fable.Core.RustInterop.emitRustExpr v9800 v9801 
        let result = v9802 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v9803 : string = "\u001b[94m"
        let v9804 : string = method6()
        let v9805 : string = v9803 + v9738 
        let v9806 : string = v9805 + v9804 
        let result = v9806 
        #endif
#if FABLE_COMPILER_PYTHON
        let v9807 : string = "\u001b[94m"
        let v9808 : string = method6()
        let v9809 : string = v9807 + v9738 
        let v9810 : string = v9809 + v9808 
        let result = v9810 
        #endif
#else
        let v9811 : string = "\u001b[94m"
        let v9812 : string = method6()
        let v9813 : string = v9811 + v9738 
        let v9814 : string = v9813 + v9812 
        let result = v9814 
        #endif
        let v9815 : string = result
        let v9825 : int64 = v8748.l0
        let v9826 : string = ""
        let v9827 : Mut4 = {l0 = v9826} : Mut4
        let v9830 : string = "{ "
        let v9831 : string = $"{v9830}"
        let v9838 : string = v9827.l0
        let v9839 : string = v9838 + v9831 
        v9827.l0 <- v9839
        let v9842 : string = "receipt_outcomes"
        let v9843 : string = $"{v9842}"
        let v9850 : string = v9827.l0
        let v9851 : string = v9850 + v9843 
        v9827.l0 <- v9851
        let v9854 : string = " = "
        let v9855 : string = $"{v9854}"
        let v9862 : string = v9827.l0
        let v9863 : string = v9862 + v9855 
        v9827.l0 <- v9863
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v9866 : string = "format!(\"{:#?}\", $0)"
        let v9867 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8671 v9866 
        let v9868 : string = "fable_library_rust::String_::fromString($0)"
        let v9869 : string = Fable.Core.RustInterop.emitRustExpr v9867 v9868 
        let result = v9869 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v9870 : string = "format!(\"{:#?}\", $0)"
        let v9871 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8671 v9870 
        let v9872 : string = "fable_library_rust::String_::fromString($0)"
        let v9873 : string = Fable.Core.RustInterop.emitRustExpr v9871 v9872 
        let result = v9873 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v9874 : string = "format!(\"{:#?}\", $0)"
        let v9875 : std_string_String = Fable.Core.RustInterop.emitRustExpr v8671 v9874 
        let v9876 : string = "fable_library_rust::String_::fromString($0)"
        let v9877 : string = Fable.Core.RustInterop.emitRustExpr v9875 v9876 
        let result = v9877 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v9880 : string = $"%A{v8671}"
        let result = v9880 
        #endif
#if FABLE_COMPILER_PYTHON
        let v9889 : string = $"%A{v8671}"
        let result = v9889 
        #endif
#else
        let v9898 : string = $"%A{v8671}"
        let result = v9898 
        #endif
        let v9905 : string = result
        let v9922 : string = $"{v9905}"
        let v9929 : string = v9827.l0
        let v9930 : string = v9929 + v9922 
        v9827.l0 <- v9930
        let v9933 : string = " }"
        let v9934 : string = $"{v9933}"
        let v9941 : string = v9827.l0
        let v9942 : string = v9941 + v9934 
        v9827.l0 <- v9942
        let v9943 : string = v9827.l0
        let v9946 : (unit -> string) = closure12()
        let v9947 : string = $"{v9565} {v9815} #{v9825} %s{v9946 ()} / {v9943}"
        let v9954 : char list = []
        let v9959 : (char list -> (char [])) = List.toArray
        let v9960 : (char []) = v9959 v9954
        let v9967 : string = v9947.TrimStart v9960 
        let v10006 : char list = []
        let v10009 : char list = '/' :: v10006 
        let v10018 : char list = ' ' :: v10009 
        let v10029 : (char list -> (char [])) = List.toArray
        let v10030 : (char []) = v10029 v10018
        let v10037 : string = v9967.TrimEnd v10030 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v10078 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v10037 v10078 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v10079 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v10037 v10079 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v10080 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v10037 v10080 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v10037 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v10037 
        let result = () 
        #endif
#else
        System.Console.WriteLine v10037 
        let result = () 
        #endif
        result
        let v10109 : (string -> unit) = v8683.l0
        v10109 v10037
    let v10110 : string = "$0.json()"
    let v10111 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v4332 v10110 
    let v10114 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v10114 |> Some
    let struct (v10122 : Mut0, v10123 : Mut1, v10124 : Mut2, v10125 : Mut3, v10126 : int64 option) = State.trace_state.Value
    let v10143 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v10143 |> Some
    let struct (v10151 : Mut0, v10152 : Mut1, v10153 : Mut2, v10154 : Mut3, v10155 : int64 option) = State.trace_state.Value
    let v10170 : US0 = v10154.l0
    let v10171 : bool = v10153.l0
    let v10172 : bool = v10171 = false
    let v10175 : bool =
        if v10172 then
            false
        else
            let v10173 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v10170
            let v10174 : bool = 1 >= v10173
            v10174
    if v10175 then
        let v10176 : int64 = v10122.l0
        let v10177 : int64 = v10176 + 1L
        v10122.l0 <- v10177
        let v10180 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v10180 |> Some
        let struct (v10188 : Mut0, v10189 : Mut1, v10190 : Mut2, v10191 : Mut3, v10192 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v10211 : US3 option = None
        let _v10211 = ref v10211 
        match v10192 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10212 : int64 = x
        let v10213 : US3 = US3_0(v10212)
        v10213 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10211.Value <- x
        let v10214 : US3 option = _v10211.Value 
        let v10237 : US3 = US3_1
        let v10238 : (US3 option -> US3) = Option.defaultValue v10237 
        let v10239 : US3 = v10238 v10214
        let v10337 : System.DateTime =
            match v10239 with
            | US3_1 -> (* None *)
                let v10329 : System.DateTime = System.DateTime.Now
                v10329
            | US3_0(v10247) -> (* Some *)
                let v10250 : System.DateTime = System.DateTime.Now
                let v10259 : (System.DateTime -> int64) = _.Ticks
                let v10260 : int64 = v10259 v10250
                let v10267 : int64 = v10260 - v10247
                let v10270 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v10271 : System.TimeSpan = v10270 v10267
                let v10280 : (System.TimeSpan -> int32) = _.Hours
                let v10281 : int32 = v10280 v10271
                let v10290 : (System.TimeSpan -> int32) = _.Minutes
                let v10291 : int32 = v10290 v10271
                let v10300 : (System.TimeSpan -> int32) = _.Seconds
                let v10301 : int32 = v10300 v10271
                let v10310 : (System.TimeSpan -> int32) = _.Milliseconds
                let v10311 : int32 = v10310 v10271
                let v10320 : System.DateTime = System.DateTime (1, 1, 1, v10281, v10291, v10301, v10311)
                v10320
        let v10340 : string = method4()
        let v10349 : (string -> string) = v10337.ToString
        let v10350 : string = v10349 v10340
        let result = v10350 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v10359 : US3 option = None
        let _v10359 = ref v10359 
        match v10192 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10360 : int64 = x
        let v10361 : US3 = US3_0(v10360)
        v10361 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10359.Value <- x
        let v10362 : US3 option = _v10359.Value 
        let v10385 : US3 = US3_1
        let v10386 : (US3 option -> US3) = Option.defaultValue v10385 
        let v10387 : US3 = v10386 v10362
        let v10485 : System.DateTime =
            match v10387 with
            | US3_1 -> (* None *)
                let v10477 : System.DateTime = System.DateTime.Now
                v10477
            | US3_0(v10395) -> (* Some *)
                let v10398 : System.DateTime = System.DateTime.Now
                let v10407 : (System.DateTime -> int64) = _.Ticks
                let v10408 : int64 = v10407 v10398
                let v10415 : int64 = v10408 - v10395
                let v10418 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v10419 : System.TimeSpan = v10418 v10415
                let v10428 : (System.TimeSpan -> int32) = _.Hours
                let v10429 : int32 = v10428 v10419
                let v10438 : (System.TimeSpan -> int32) = _.Minutes
                let v10439 : int32 = v10438 v10419
                let v10448 : (System.TimeSpan -> int32) = _.Seconds
                let v10449 : int32 = v10448 v10419
                let v10458 : (System.TimeSpan -> int32) = _.Milliseconds
                let v10459 : int32 = v10458 v10419
                let v10468 : System.DateTime = System.DateTime (1, 1, 1, v10429, v10439, v10449, v10459)
                v10468
        let v10488 : string = method4()
        let v10497 : (string -> string) = v10485.ToString
        let v10498 : string = v10497 v10488
        let result = v10498 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v10505 : string = $"near_sdk::env::block_timestamp()"
        let v10506 : uint64 = Fable.Core.RustInterop.emitRustExpr () v10505 
        let v10509 : US3 option = None
        let _v10509 = ref v10509 
        match v10192 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10510 : int64 = x
        let v10511 : US3 = US3_0(v10510)
        v10511 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10509.Value <- x
        let v10512 : US3 option = _v10509.Value 
        let v10535 : US3 = US3_1
        let v10536 : (US3 option -> US3) = Option.defaultValue v10535 
        let v10537 : US3 = v10536 v10512
        let v10550 : uint64 =
            match v10537 with
            | US3_1 -> (* None *)
                v10506
            | US3_0(v10545) -> (* Some *)
                let v10546 : (int64 -> uint64) = uint64
                let v10547 : uint64 = v10546 v10545
                let v10548 : uint64 = v10506 - v10547
                v10548
        let v10551 : uint64 = v10550 / 1000000000UL
        let v10552 : uint64 = v10551 % 60UL
        let v10553 : uint64 = v10551 / 60UL
        let v10554 : uint64 = v10553 % 60UL
        let v10555 : uint64 = v10551 / 3600UL
        let v10556 : uint64 = v10555 % 24UL
        let v10557 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v10558 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v10556, v10554, v10552) v10557 
        let v10559 : string = "fable_library_rust::String_::fromString($0)"
        let v10560 : string = Fable.Core.RustInterop.emitRustExpr v10558 v10559 
        let result = v10560 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v10563 : US3 option = None
        let _v10563 = ref v10563 
        match v10192 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10564 : int64 = x
        let v10565 : US3 = US3_0(v10564)
        v10565 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10563.Value <- x
        let v10566 : US3 option = _v10563.Value 
        let v10589 : US3 = US3_1
        let v10590 : (US3 option -> US3) = Option.defaultValue v10589 
        let v10591 : US3 = v10590 v10566
        let v10689 : System.DateTime =
            match v10591 with
            | US3_1 -> (* None *)
                let v10681 : System.DateTime = System.DateTime.Now
                v10681
            | US3_0(v10599) -> (* Some *)
                let v10602 : System.DateTime = System.DateTime.Now
                let v10611 : (System.DateTime -> int64) = _.Ticks
                let v10612 : int64 = v10611 v10602
                let v10619 : int64 = v10612 - v10599
                let v10622 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v10623 : System.TimeSpan = v10622 v10619
                let v10632 : (System.TimeSpan -> int32) = _.Hours
                let v10633 : int32 = v10632 v10623
                let v10642 : (System.TimeSpan -> int32) = _.Minutes
                let v10643 : int32 = v10642 v10623
                let v10652 : (System.TimeSpan -> int32) = _.Seconds
                let v10653 : int32 = v10652 v10623
                let v10662 : (System.TimeSpan -> int32) = _.Milliseconds
                let v10663 : int32 = v10662 v10623
                let v10672 : System.DateTime = System.DateTime (1, 1, 1, v10633, v10643, v10653, v10663)
                v10672
        let v10692 : string = method5()
        let v10701 : (string -> string) = v10689.ToString
        let v10702 : string = v10701 v10692
        let result = v10702 
        #endif
#if FABLE_COMPILER_PYTHON
        let v10711 : US3 option = None
        let _v10711 = ref v10711 
        match v10192 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10712 : int64 = x
        let v10713 : US3 = US3_0(v10712)
        v10713 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10711.Value <- x
        let v10714 : US3 option = _v10711.Value 
        let v10737 : US3 = US3_1
        let v10738 : (US3 option -> US3) = Option.defaultValue v10737 
        let v10739 : US3 = v10738 v10714
        let v10837 : System.DateTime =
            match v10739 with
            | US3_1 -> (* None *)
                let v10829 : System.DateTime = System.DateTime.Now
                v10829
            | US3_0(v10747) -> (* Some *)
                let v10750 : System.DateTime = System.DateTime.Now
                let v10759 : (System.DateTime -> int64) = _.Ticks
                let v10760 : int64 = v10759 v10750
                let v10767 : int64 = v10760 - v10747
                let v10770 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v10771 : System.TimeSpan = v10770 v10767
                let v10780 : (System.TimeSpan -> int32) = _.Hours
                let v10781 : int32 = v10780 v10771
                let v10790 : (System.TimeSpan -> int32) = _.Minutes
                let v10791 : int32 = v10790 v10771
                let v10800 : (System.TimeSpan -> int32) = _.Seconds
                let v10801 : int32 = v10800 v10771
                let v10810 : (System.TimeSpan -> int32) = _.Milliseconds
                let v10811 : int32 = v10810 v10771
                let v10820 : System.DateTime = System.DateTime (1, 1, 1, v10781, v10791, v10801, v10811)
                v10820
        let v10840 : string = method5()
        let v10849 : (string -> string) = v10837.ToString
        let v10850 : string = v10849 v10840
        let result = v10850 
        #endif
#else
        let v10859 : US3 option = None
        let _v10859 = ref v10859 
        match v10192 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v10860 : int64 = x
        let v10861 : US3 = US3_0(v10860)
        v10861 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10859.Value <- x
        let v10862 : US3 option = _v10859.Value 
        let v10885 : US3 = US3_1
        let v10886 : (US3 option -> US3) = Option.defaultValue v10885 
        let v10887 : US3 = v10886 v10862
        let v10985 : System.DateTime =
            match v10887 with
            | US3_1 -> (* None *)
                let v10977 : System.DateTime = System.DateTime.Now
                v10977
            | US3_0(v10895) -> (* Some *)
                let v10898 : System.DateTime = System.DateTime.Now
                let v10907 : (System.DateTime -> int64) = _.Ticks
                let v10908 : int64 = v10907 v10898
                let v10915 : int64 = v10908 - v10895
                let v10918 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v10919 : System.TimeSpan = v10918 v10915
                let v10928 : (System.TimeSpan -> int32) = _.Hours
                let v10929 : int32 = v10928 v10919
                let v10938 : (System.TimeSpan -> int32) = _.Minutes
                let v10939 : int32 = v10938 v10919
                let v10948 : (System.TimeSpan -> int32) = _.Seconds
                let v10949 : int32 = v10948 v10919
                let v10958 : (System.TimeSpan -> int32) = _.Milliseconds
                let v10959 : int32 = v10958 v10919
                let v10968 : System.DateTime = System.DateTime (1, 1, 1, v10929, v10939, v10949, v10959)
                v10968
        let v10988 : string = method5()
        let v10997 : (string -> string) = v10985.ToString
        let v10998 : string = v10997 v10988
        let result = v10998 
        #endif
        let v11005 : string = result
        let v11167 : string = "Debug"
        let v11168 : (unit -> string) = v11167.ToLower
        let v11169 : string = v11168 ()
        let v11178 : string = v11169.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11210 : string = "inline_colorization::color_bright_blue"
        let v11211 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11210 
        let v11212 : string = "&*$0"
        let v11213 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11178 v11212 
        let v11214 : string = "inline_colorization::color_reset"
        let v11215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11214 
        let v11216 : string = "\"{v11211}{v11213}{v11215}\""
        let v11217 : string = @$"format!(" + v11216 + ")"
        let v11218 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11217 
        let v11219 : string = "fable_library_rust::String_::fromString($0)"
        let v11220 : string = Fable.Core.RustInterop.emitRustExpr v11218 v11219 
        let result = v11220 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v11221 : string = "inline_colorization::color_bright_blue"
        let v11222 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11221 
        let v11223 : string = "&*$0"
        let v11224 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11178 v11223 
        let v11225 : string = "inline_colorization::color_reset"
        let v11226 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11225 
        let v11227 : string = "\"{v11222}{v11224}{v11226}\""
        let v11228 : string = @$"format!(" + v11227 + ")"
        let v11229 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11228 
        let v11230 : string = "fable_library_rust::String_::fromString($0)"
        let v11231 : string = Fable.Core.RustInterop.emitRustExpr v11229 v11230 
        let result = v11231 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v11232 : string = "inline_colorization::color_bright_blue"
        let v11233 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11232 
        let v11234 : string = "&*$0"
        let v11235 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v11178 v11234 
        let v11236 : string = "inline_colorization::color_reset"
        let v11237 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v11236 
        let v11238 : string = "\"{v11233}{v11235}{v11237}\""
        let v11239 : string = @$"format!(" + v11238 + ")"
        let v11240 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v11239 
        let v11241 : string = "fable_library_rust::String_::fromString($0)"
        let v11242 : string = Fable.Core.RustInterop.emitRustExpr v11240 v11241 
        let result = v11242 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v11243 : string = "\u001b[94m"
        let v11244 : string = method6()
        let v11245 : string = v11243 + v11178 
        let v11246 : string = v11245 + v11244 
        let result = v11246 
        #endif
#if FABLE_COMPILER_PYTHON
        let v11247 : string = "\u001b[94m"
        let v11248 : string = method6()
        let v11249 : string = v11247 + v11178 
        let v11250 : string = v11249 + v11248 
        let result = v11250 
        #endif
#else
        let v11251 : string = "\u001b[94m"
        let v11252 : string = method6()
        let v11253 : string = v11251 + v11178 
        let v11254 : string = v11253 + v11252 
        let result = v11254 
        #endif
        let v11255 : string = result
        let v11265 : int64 = v10188.l0
        let v11266 : string = ""
        let v11267 : Mut4 = {l0 = v11266} : Mut4
        let v11270 : string = "{ "
        let v11271 : string = $"{v11270}"
        let v11278 : string = v11267.l0
        let v11279 : string = v11278 + v11271 
        v11267.l0 <- v11279
        let v11282 : string = "json"
        let v11283 : string = $"{v11282}"
        let v11290 : string = v11267.l0
        let v11291 : string = v11290 + v11283 
        v11267.l0 <- v11291
        let v11294 : string = " = "
        let v11295 : string = $"{v11294}"
        let v11302 : string = v11267.l0
        let v11303 : string = v11302 + v11295 
        v11267.l0 <- v11303
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11306 : string = "format!(\"{:#?}\", $0)"
        let v11307 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10111 v11306 
        let v11308 : string = "fable_library_rust::String_::fromString($0)"
        let v11309 : string = Fable.Core.RustInterop.emitRustExpr v11307 v11308 
        let result = v11309 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v11310 : string = "format!(\"{:#?}\", $0)"
        let v11311 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10111 v11310 
        let v11312 : string = "fable_library_rust::String_::fromString($0)"
        let v11313 : string = Fable.Core.RustInterop.emitRustExpr v11311 v11312 
        let result = v11313 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v11314 : string = "format!(\"{:#?}\", $0)"
        let v11315 : std_string_String = Fable.Core.RustInterop.emitRustExpr v10111 v11314 
        let v11316 : string = "fable_library_rust::String_::fromString($0)"
        let v11317 : string = Fable.Core.RustInterop.emitRustExpr v11315 v11316 
        let result = v11317 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v11320 : string = $"%A{v10111}"
        let result = v11320 
        #endif
#if FABLE_COMPILER_PYTHON
        let v11329 : string = $"%A{v10111}"
        let result = v11329 
        #endif
#else
        let v11338 : string = $"%A{v10111}"
        let result = v11338 
        #endif
        let v11345 : string = result
        let v11362 : string = $"{v11345}"
        let v11369 : string = v11267.l0
        let v11370 : string = v11369 + v11362 
        v11267.l0 <- v11370
        let v11373 : string = " }"
        let v11374 : string = $"{v11373}"
        let v11381 : string = v11267.l0
        let v11382 : string = v11381 + v11374 
        v11267.l0 <- v11382
        let v11383 : string = v11267.l0
        let v11386 : (unit -> string) = closure13()
        let v11387 : string = $"{v11005} {v11255} #{v11265} %s{v11386 ()} / {v11383}"
        let v11394 : char list = []
        let v11399 : (char list -> (char [])) = List.toArray
        let v11400 : (char []) = v11399 v11394
        let v11407 : string = v11387.TrimStart v11400 
        let v11446 : char list = []
        let v11449 : char list = '/' :: v11446 
        let v11458 : char list = ' ' :: v11449 
        let v11469 : (char list -> (char [])) = List.toArray
        let v11470 : (char []) = v11469 v11458
        let v11477 : string = v11407.TrimEnd v11470 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11518 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v11477 v11518 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v11519 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v11477 v11519 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v11520 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v11477 v11520 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v11477 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v11477 
        let result = () 
        #endif
#else
        System.Console.WriteLine v11477 
        let result = () 
        #endif
        result
        let v11549 : (string -> unit) = v10123.l0
        v11549 v11477
    let v11550 : string = "$0.borsh()"
    let v11551 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v4332 v11550 
    let v11554 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v11554 |> Some
    let struct (v11562 : Mut0, v11563 : Mut1, v11564 : Mut2, v11565 : Mut3, v11566 : int64 option) = State.trace_state.Value
    let v11583 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v53 v11583 |> Some
    let struct (v11591 : Mut0, v11592 : Mut1, v11593 : Mut2, v11594 : Mut3, v11595 : int64 option) = State.trace_state.Value
    let v11610 : US0 = v11594.l0
    let v11611 : bool = v11593.l0
    let v11612 : bool = v11611 = false
    let v11615 : bool =
        if v11612 then
            false
        else
            let v11613 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v11610
            let v11614 : bool = 1 >= v11613
            v11614
    if v11615 then
        let v11616 : int64 = v11562.l0
        let v11617 : int64 = v11616 + 1L
        v11562.l0 <- v11617
        let v11620 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v53 v11620 |> Some
        let struct (v11628 : Mut0, v11629 : Mut1, v11630 : Mut2, v11631 : Mut3, v11632 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11651 : US3 option = None
        let _v11651 = ref v11651 
        match v11632 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11652 : int64 = x
        let v11653 : US3 = US3_0(v11652)
        v11653 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v11651.Value <- x
        let v11654 : US3 option = _v11651.Value 
        let v11677 : US3 = US3_1
        let v11678 : (US3 option -> US3) = Option.defaultValue v11677 
        let v11679 : US3 = v11678 v11654
        let v11777 : System.DateTime =
            match v11679 with
            | US3_1 -> (* None *)
                let v11769 : System.DateTime = System.DateTime.Now
                v11769
            | US3_0(v11687) -> (* Some *)
                let v11690 : System.DateTime = System.DateTime.Now
                let v11699 : (System.DateTime -> int64) = _.Ticks
                let v11700 : int64 = v11699 v11690
                let v11707 : int64 = v11700 - v11687
                let v11710 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v11711 : System.TimeSpan = v11710 v11707
                let v11720 : (System.TimeSpan -> int32) = _.Hours
                let v11721 : int32 = v11720 v11711
                let v11730 : (System.TimeSpan -> int32) = _.Minutes
                let v11731 : int32 = v11730 v11711
                let v11740 : (System.TimeSpan -> int32) = _.Seconds
                let v11741 : int32 = v11740 v11711
                let v11750 : (System.TimeSpan -> int32) = _.Milliseconds
                let v11751 : int32 = v11750 v11711
                let v11760 : System.DateTime = System.DateTime (1, 1, 1, v11721, v11731, v11741, v11751)
                v11760
        let v11780 : string = method4()
        let v11789 : (string -> string) = v11777.ToString
        let v11790 : string = v11789 v11780
        let result = v11790 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v11799 : US3 option = None
        let _v11799 = ref v11799 
        match v11632 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11800 : int64 = x
        let v11801 : US3 = US3_0(v11800)
        v11801 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v11799.Value <- x
        let v11802 : US3 option = _v11799.Value 
        let v11825 : US3 = US3_1
        let v11826 : (US3 option -> US3) = Option.defaultValue v11825 
        let v11827 : US3 = v11826 v11802
        let v11925 : System.DateTime =
            match v11827 with
            | US3_1 -> (* None *)
                let v11917 : System.DateTime = System.DateTime.Now
                v11917
            | US3_0(v11835) -> (* Some *)
                let v11838 : System.DateTime = System.DateTime.Now
                let v11847 : (System.DateTime -> int64) = _.Ticks
                let v11848 : int64 = v11847 v11838
                let v11855 : int64 = v11848 - v11835
                let v11858 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v11859 : System.TimeSpan = v11858 v11855
                let v11868 : (System.TimeSpan -> int32) = _.Hours
                let v11869 : int32 = v11868 v11859
                let v11878 : (System.TimeSpan -> int32) = _.Minutes
                let v11879 : int32 = v11878 v11859
                let v11888 : (System.TimeSpan -> int32) = _.Seconds
                let v11889 : int32 = v11888 v11859
                let v11898 : (System.TimeSpan -> int32) = _.Milliseconds
                let v11899 : int32 = v11898 v11859
                let v11908 : System.DateTime = System.DateTime (1, 1, 1, v11869, v11879, v11889, v11899)
                v11908
        let v11928 : string = method4()
        let v11937 : (string -> string) = v11925.ToString
        let v11938 : string = v11937 v11928
        let result = v11938 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v11945 : string = $"near_sdk::env::block_timestamp()"
        let v11946 : uint64 = Fable.Core.RustInterop.emitRustExpr () v11945 
        let v11949 : US3 option = None
        let _v11949 = ref v11949 
        match v11632 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11950 : int64 = x
        let v11951 : US3 = US3_0(v11950)
        v11951 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v11949.Value <- x
        let v11952 : US3 option = _v11949.Value 
        let v11975 : US3 = US3_1
        let v11976 : (US3 option -> US3) = Option.defaultValue v11975 
        let v11977 : US3 = v11976 v11952
        let v11990 : uint64 =
            match v11977 with
            | US3_1 -> (* None *)
                v11946
            | US3_0(v11985) -> (* Some *)
                let v11986 : (int64 -> uint64) = uint64
                let v11987 : uint64 = v11986 v11985
                let v11988 : uint64 = v11946 - v11987
                v11988
        let v11991 : uint64 = v11990 / 1000000000UL
        let v11992 : uint64 = v11991 % 60UL
        let v11993 : uint64 = v11991 / 60UL
        let v11994 : uint64 = v11993 % 60UL
        let v11995 : uint64 = v11991 / 3600UL
        let v11996 : uint64 = v11995 % 24UL
        let v11997 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v11998 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v11996, v11994, v11992) v11997 
        let v11999 : string = "fable_library_rust::String_::fromString($0)"
        let v12000 : string = Fable.Core.RustInterop.emitRustExpr v11998 v11999 
        let result = v12000 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v12003 : US3 option = None
        let _v12003 = ref v12003 
        match v11632 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v12004 : int64 = x
        let v12005 : US3 = US3_0(v12004)
        v12005 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v12003.Value <- x
        let v12006 : US3 option = _v12003.Value 
        let v12029 : US3 = US3_1
        let v12030 : (US3 option -> US3) = Option.defaultValue v12029 
        let v12031 : US3 = v12030 v12006
        let v12129 : System.DateTime =
            match v12031 with
            | US3_1 -> (* None *)
                let v12121 : System.DateTime = System.DateTime.Now
                v12121
            | US3_0(v12039) -> (* Some *)
                let v12042 : System.DateTime = System.DateTime.Now
                let v12051 : (System.DateTime -> int64) = _.Ticks
                let v12052 : int64 = v12051 v12042
                let v12059 : int64 = v12052 - v12039
                let v12062 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v12063 : System.TimeSpan = v12062 v12059
                let v12072 : (System.TimeSpan -> int32) = _.Hours
                let v12073 : int32 = v12072 v12063
                let v12082 : (System.TimeSpan -> int32) = _.Minutes
                let v12083 : int32 = v12082 v12063
                let v12092 : (System.TimeSpan -> int32) = _.Seconds
                let v12093 : int32 = v12092 v12063
                let v12102 : (System.TimeSpan -> int32) = _.Milliseconds
                let v12103 : int32 = v12102 v12063
                let v12112 : System.DateTime = System.DateTime (1, 1, 1, v12073, v12083, v12093, v12103)
                v12112
        let v12132 : string = method5()
        let v12141 : (string -> string) = v12129.ToString
        let v12142 : string = v12141 v12132
        let result = v12142 
        #endif
#if FABLE_COMPILER_PYTHON
        let v12151 : US3 option = None
        let _v12151 = ref v12151 
        match v11632 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v12152 : int64 = x
        let v12153 : US3 = US3_0(v12152)
        v12153 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v12151.Value <- x
        let v12154 : US3 option = _v12151.Value 
        let v12177 : US3 = US3_1
        let v12178 : (US3 option -> US3) = Option.defaultValue v12177 
        let v12179 : US3 = v12178 v12154
        let v12277 : System.DateTime =
            match v12179 with
            | US3_1 -> (* None *)
                let v12269 : System.DateTime = System.DateTime.Now
                v12269
            | US3_0(v12187) -> (* Some *)
                let v12190 : System.DateTime = System.DateTime.Now
                let v12199 : (System.DateTime -> int64) = _.Ticks
                let v12200 : int64 = v12199 v12190
                let v12207 : int64 = v12200 - v12187
                let v12210 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v12211 : System.TimeSpan = v12210 v12207
                let v12220 : (System.TimeSpan -> int32) = _.Hours
                let v12221 : int32 = v12220 v12211
                let v12230 : (System.TimeSpan -> int32) = _.Minutes
                let v12231 : int32 = v12230 v12211
                let v12240 : (System.TimeSpan -> int32) = _.Seconds
                let v12241 : int32 = v12240 v12211
                let v12250 : (System.TimeSpan -> int32) = _.Milliseconds
                let v12251 : int32 = v12250 v12211
                let v12260 : System.DateTime = System.DateTime (1, 1, 1, v12221, v12231, v12241, v12251)
                v12260
        let v12280 : string = method5()
        let v12289 : (string -> string) = v12277.ToString
        let v12290 : string = v12289 v12280
        let result = v12290 
        #endif
#else
        let v12299 : US3 option = None
        let _v12299 = ref v12299 
        match v11632 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v12300 : int64 = x
        let v12301 : US3 = US3_0(v12300)
        v12301 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v12299.Value <- x
        let v12302 : US3 option = _v12299.Value 
        let v12325 : US3 = US3_1
        let v12326 : (US3 option -> US3) = Option.defaultValue v12325 
        let v12327 : US3 = v12326 v12302
        let v12425 : System.DateTime =
            match v12327 with
            | US3_1 -> (* None *)
                let v12417 : System.DateTime = System.DateTime.Now
                v12417
            | US3_0(v12335) -> (* Some *)
                let v12338 : System.DateTime = System.DateTime.Now
                let v12347 : (System.DateTime -> int64) = _.Ticks
                let v12348 : int64 = v12347 v12338
                let v12355 : int64 = v12348 - v12335
                let v12358 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v12359 : System.TimeSpan = v12358 v12355
                let v12368 : (System.TimeSpan -> int32) = _.Hours
                let v12369 : int32 = v12368 v12359
                let v12378 : (System.TimeSpan -> int32) = _.Minutes
                let v12379 : int32 = v12378 v12359
                let v12388 : (System.TimeSpan -> int32) = _.Seconds
                let v12389 : int32 = v12388 v12359
                let v12398 : (System.TimeSpan -> int32) = _.Milliseconds
                let v12399 : int32 = v12398 v12359
                let v12408 : System.DateTime = System.DateTime (1, 1, 1, v12369, v12379, v12389, v12399)
                v12408
        let v12428 : string = method5()
        let v12437 : (string -> string) = v12425.ToString
        let v12438 : string = v12437 v12428
        let result = v12438 
        #endif
        let v12445 : string = result
        let v12607 : string = "Debug"
        let v12608 : (unit -> string) = v12607.ToLower
        let v12609 : string = v12608 ()
        let v12618 : string = v12609.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v12650 : string = "inline_colorization::color_bright_blue"
        let v12651 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12650 
        let v12652 : string = "&*$0"
        let v12653 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12618 v12652 
        let v12654 : string = "inline_colorization::color_reset"
        let v12655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12654 
        let v12656 : string = "\"{v12651}{v12653}{v12655}\""
        let v12657 : string = @$"format!(" + v12656 + ")"
        let v12658 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v12657 
        let v12659 : string = "fable_library_rust::String_::fromString($0)"
        let v12660 : string = Fable.Core.RustInterop.emitRustExpr v12658 v12659 
        let result = v12660 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12661 : string = "inline_colorization::color_bright_blue"
        let v12662 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12661 
        let v12663 : string = "&*$0"
        let v12664 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12618 v12663 
        let v12665 : string = "inline_colorization::color_reset"
        let v12666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12665 
        let v12667 : string = "\"{v12662}{v12664}{v12666}\""
        let v12668 : string = @$"format!(" + v12667 + ")"
        let v12669 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v12668 
        let v12670 : string = "fable_library_rust::String_::fromString($0)"
        let v12671 : string = Fable.Core.RustInterop.emitRustExpr v12669 v12670 
        let result = v12671 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v12672 : string = "inline_colorization::color_bright_blue"
        let v12673 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12672 
        let v12674 : string = "&*$0"
        let v12675 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v12618 v12674 
        let v12676 : string = "inline_colorization::color_reset"
        let v12677 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v12676 
        let v12678 : string = "\"{v12673}{v12675}{v12677}\""
        let v12679 : string = @$"format!(" + v12678 + ")"
        let v12680 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v12679 
        let v12681 : string = "fable_library_rust::String_::fromString($0)"
        let v12682 : string = Fable.Core.RustInterop.emitRustExpr v12680 v12681 
        let result = v12682 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v12683 : string = "\u001b[94m"
        let v12684 : string = method6()
        let v12685 : string = v12683 + v12618 
        let v12686 : string = v12685 + v12684 
        let result = v12686 
        #endif
#if FABLE_COMPILER_PYTHON
        let v12687 : string = "\u001b[94m"
        let v12688 : string = method6()
        let v12689 : string = v12687 + v12618 
        let v12690 : string = v12689 + v12688 
        let result = v12690 
        #endif
#else
        let v12691 : string = "\u001b[94m"
        let v12692 : string = method6()
        let v12693 : string = v12691 + v12618 
        let v12694 : string = v12693 + v12692 
        let result = v12694 
        #endif
        let v12695 : string = result
        let v12705 : int64 = v11628.l0
        let v12706 : string = ""
        let v12707 : Mut4 = {l0 = v12706} : Mut4
        let v12710 : string = "{ "
        let v12711 : string = $"{v12710}"
        let v12718 : string = v12707.l0
        let v12719 : string = v12718 + v12711 
        v12707.l0 <- v12719
        let v12722 : string = "borsh"
        let v12723 : string = $"{v12722}"
        let v12730 : string = v12707.l0
        let v12731 : string = v12730 + v12723 
        v12707.l0 <- v12731
        let v12734 : string = " = "
        let v12735 : string = $"{v12734}"
        let v12742 : string = v12707.l0
        let v12743 : string = v12742 + v12735 
        v12707.l0 <- v12743
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v12746 : string = "format!(\"{:#?}\", $0)"
        let v12747 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11551 v12746 
        let v12748 : string = "fable_library_rust::String_::fromString($0)"
        let v12749 : string = Fable.Core.RustInterop.emitRustExpr v12747 v12748 
        let result = v12749 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12750 : string = "format!(\"{:#?}\", $0)"
        let v12751 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11551 v12750 
        let v12752 : string = "fable_library_rust::String_::fromString($0)"
        let v12753 : string = Fable.Core.RustInterop.emitRustExpr v12751 v12752 
        let result = v12753 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v12754 : string = "format!(\"{:#?}\", $0)"
        let v12755 : std_string_String = Fable.Core.RustInterop.emitRustExpr v11551 v12754 
        let v12756 : string = "fable_library_rust::String_::fromString($0)"
        let v12757 : string = Fable.Core.RustInterop.emitRustExpr v12755 v12756 
        let result = v12757 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v12760 : string = $"%A{v11551}"
        let result = v12760 
        #endif
#if FABLE_COMPILER_PYTHON
        let v12769 : string = $"%A{v11551}"
        let result = v12769 
        #endif
#else
        let v12778 : string = $"%A{v11551}"
        let result = v12778 
        #endif
        let v12785 : string = result
        let v12802 : string = $"{v12785}"
        let v12809 : string = v12707.l0
        let v12810 : string = v12809 + v12802 
        v12707.l0 <- v12810
        let v12813 : string = " }"
        let v12814 : string = $"{v12813}"
        let v12821 : string = v12707.l0
        let v12822 : string = v12821 + v12814 
        v12707.l0 <- v12822
        let v12823 : string = v12707.l0
        let v12826 : (unit -> string) = closure14()
        let v12827 : string = $"{v12445} {v12695} #{v12705} %s{v12826 ()} / {v12823}"
        let v12834 : char list = []
        let v12839 : (char list -> (char [])) = List.toArray
        let v12840 : (char []) = v12839 v12834
        let v12847 : string = v12827.TrimStart v12840 
        let v12886 : char list = []
        let v12889 : char list = '/' :: v12886 
        let v12898 : char list = ' ' :: v12889 
        let v12909 : (char list -> (char [])) = List.toArray
        let v12910 : (char []) = v12909 v12898
        let v12917 : string = v12847.TrimEnd v12910 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v12958 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v12917 v12958 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12959 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v12917 v12959 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v12960 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v12917 v12960 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v12917 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v12917 
        let result = () 
        #endif
#else
        System.Console.WriteLine v12917 
        let result = () 
        #endif
        result
        let v12989 : (string -> unit) = v11563.l0
        v12989 v12917
    let v12990 : string = "  println!(\"\\n\\n worker: {:#?}\", v1441); //"
    Fable.Core.RustInterop.emitRustExpr () v12990 
    let v12991 : string = "  println!(\"\\n\\n contract: {:#?}\", v2885); //"
    Fable.Core.RustInterop.emitRustExpr () v12991 
    let v12992 : string = "$0.len()"
    let v12993 : unativeint = Fable.Core.RustInterop.emitRustExpr v7230 v12992 
    let v12994 : (unativeint -> int32) = int32
    let v12995 : int32 = v12994 v12993
    let v12996 : bool = v12995 = 0
    let v13003 : Result<unit, anyhow_Error> =
        if v12996 then
            let v12997 : Result<unit, anyhow_Error> = Ok () 
            v12997
        else
            let v12998 : string = "anyhow::anyhow!($0)"
            let v12999 : string = "<error>"
            let v13000 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v12999 v12998 
            let v13001 : string = "Err(v13000)"
            let v13002 : Result<unit, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v13001 
            v13002
    let v13004 : Result<unit, anyhow_Error> = method12(v13003)
    let v13005 : string = ""
    let v13006 : string = "}"
    let v13007 : string = v13005 + v13006 
    let v13008 : string = v13007 + v13006 
    let v13009 : string = v13008 + v13006 
    let v13010 : string = v13009 + v13006 
    let v13011 : string = v13010 + v13006 
    let v13012 : string = v13011 + v13006 
    let v13013 : string = v13012 + v13006 
    let v13014 : string = v13013 + v13006 
    let v13015 : string = v13014 + v13006 
    let v13016 : string = v13015 + v13006 
    let v13017 : string = v13016 + v13006 
    let v13018 : string = v13017 + v13006 
    let v13019 : string = v13018 + v13006 
    let v13020 : string = v13019 + v13006 
    let v13021 : string = v13020 + v13006 
    let v13022 : string = v13021 + v13006 
    let v13023 : string = v13022 + v13006 
    let v13024 : string = v13023 + v13006 
    let v13025 : string = v13024 + v13006 
    let v13026 : string = v13025 + v13006 
    let v13027 : string = v13026 + v13006 
    let v13028 : string = v13027 + v13006 
    let v13029 : string = v13028 + v13006 
    let v13030 : string = v13029 + v13006 
    let v13031 : string = v13030 + v13006 
    let v13032 : string = v13031 + v13006 
    let v13033 : string = v13032 + v13006 
    let v13034 : string = v13033 + v13006 
    let v13035 : string = v13034 + v13006 
    let v13036 : string = v13035 + v13006 
    let v13037 : string = v13036 + v13006 
    let v13038 : string = "{"
    let v13039 : string = v13005 + v13038 
    let v13040 : string = v13039 + v13038 
    let v13041 : string = v13040 + v13038 
    let v13042 : string = v13041 + v13038 
    let v13043 : string = v13042 + v13038 
    let v13044 : string = v13043 + v13038 
    let v13045 : string = v13044 + v13038 
    let v13046 : string = v13045 + v13038 
    let v13047 : string = v13046 + v13038 
    let v13048 : string = v13047 + v13038 
    let v13049 : string = v13048 + v13038 
    let v13050 : string = v13049 + v13038 
    let v13051 : string = v13050 + v13038 
    let v13052 : string = v13051 + v13038 
    let v13053 : string = v13052 + v13038 
    let v13054 : string = v13053 + v13038 
    let v13055 : string = v13054 + v13038 
    let v13056 : string = v13055 + v13038 
    let v13057 : string = v13056 + v13038 
    let v13058 : string = v13057 + v13038 
    let v13059 : string = v13058 + v13038 
    let v13060 : string = v13059 + v13038 
    let v13061 : string = v13060 + v13038 
    let v13062 : string = v13061 + v13038 
    let v13063 : string = v13062 + v13038 
    let v13064 : string = v13063 + v13038 
    let v13065 : string = v13064 + v13038 
    let v13066 : string = v13065 + v13038 
    let v13067 : string = v13066 + v13038 
    let v13068 : string = v13067 + v13038 
    let v13069 : string = "v13004 " + v13037 + "); " + v13068 + " // rust.fix_closure'"
    Fable.Core.RustInterop.emitRustExpr () v13069 
    let v13070 : string = "__result"
    let v13071 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v13070 
    v13071
and closure1 () (v0 : (string [])) : int32 =
    let v3 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure2()
    let v4 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v4 |> Some
    let struct (v12 : Mut0, v13 : Mut1, v14 : Mut2, v15 : Mut3, v16 : int64 option) = State.trace_state.Value
    let v33 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v33 |> Some
    let struct (v41 : Mut0, v42 : Mut1, v43 : Mut2, v44 : Mut3, v45 : int64 option) = State.trace_state.Value
    let v62 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v3 v62 |> Some
    let struct (v70 : Mut0, v71 : Mut1, v72 : Mut2, v73 : Mut3, v74 : int64 option) = State.trace_state.Value
    let v89 : US0 = v73.l0
    let v90 : bool = v72.l0
    let v91 : bool = v90 = false
    let v94 : bool =
        if v91 then
            false
        else
            let v92 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v89
            let v93 : bool = 1 >= v92
            v93
    if v94 then
        let v95 : int64 = v41.l0
        let v96 : int64 = v95 + 1L
        v41.l0 <- v96
        let v99 : US0 = US0_0
        if State.trace_state.IsNone then State.trace_state <- v3 v99 |> Some
        let struct (v107 : Mut0, v108 : Mut1, v109 : Mut2, v110 : Mut3, v111 : int64 option) = State.trace_state.Value
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v130 : US3 option = None
        let _v130 = ref v130 
        match v111 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v131 : int64 = x
        let v132 : US3 = US3_0(v131)
        v132 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v130.Value <- x
        let v133 : US3 option = _v130.Value 
        let v156 : US3 = US3_1
        let v157 : (US3 option -> US3) = Option.defaultValue v156 
        let v158 : US3 = v157 v133
        let v256 : System.DateTime =
            match v158 with
            | US3_1 -> (* None *)
                let v248 : System.DateTime = System.DateTime.Now
                v248
            | US3_0(v166) -> (* Some *)
                let v169 : System.DateTime = System.DateTime.Now
                let v178 : (System.DateTime -> int64) = _.Ticks
                let v179 : int64 = v178 v169
                let v186 : int64 = v179 - v166
                let v189 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v190 : System.TimeSpan = v189 v186
                let v199 : (System.TimeSpan -> int32) = _.Hours
                let v200 : int32 = v199 v190
                let v209 : (System.TimeSpan -> int32) = _.Minutes
                let v210 : int32 = v209 v190
                let v219 : (System.TimeSpan -> int32) = _.Seconds
                let v220 : int32 = v219 v190
                let v229 : (System.TimeSpan -> int32) = _.Milliseconds
                let v230 : int32 = v229 v190
                let v239 : System.DateTime = System.DateTime (1, 1, 1, v200, v210, v220, v230)
                v239
        let v259 : string = method4()
        let v268 : (string -> string) = v256.ToString
        let v269 : string = v268 v259
        let result = v269 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v278 : US3 option = None
        let _v278 = ref v278 
        match v111 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v279 : int64 = x
        let v280 : US3 = US3_0(v279)
        v280 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v278.Value <- x
        let v281 : US3 option = _v278.Value 
        let v304 : US3 = US3_1
        let v305 : (US3 option -> US3) = Option.defaultValue v304 
        let v306 : US3 = v305 v281
        let v404 : System.DateTime =
            match v306 with
            | US3_1 -> (* None *)
                let v396 : System.DateTime = System.DateTime.Now
                v396
            | US3_0(v314) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v326 : (System.DateTime -> int64) = _.Ticks
                let v327 : int64 = v326 v317
                let v334 : int64 = v327 - v314
                let v337 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v338 : System.TimeSpan = v337 v334
                let v347 : (System.TimeSpan -> int32) = _.Hours
                let v348 : int32 = v347 v338
                let v357 : (System.TimeSpan -> int32) = _.Minutes
                let v358 : int32 = v357 v338
                let v367 : (System.TimeSpan -> int32) = _.Seconds
                let v368 : int32 = v367 v338
                let v377 : (System.TimeSpan -> int32) = _.Milliseconds
                let v378 : int32 = v377 v338
                let v387 : System.DateTime = System.DateTime (1, 1, 1, v348, v358, v368, v378)
                v387
        let v407 : string = method4()
        let v416 : (string -> string) = v404.ToString
        let v417 : string = v416 v407
        let result = v417 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v424 : string = $"near_sdk::env::block_timestamp()"
        let v425 : uint64 = Fable.Core.RustInterop.emitRustExpr () v424 
        let v428 : US3 option = None
        let _v428 = ref v428 
        match v111 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v429 : int64 = x
        let v430 : US3 = US3_0(v429)
        v430 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v428.Value <- x
        let v431 : US3 option = _v428.Value 
        let v454 : US3 = US3_1
        let v455 : (US3 option -> US3) = Option.defaultValue v454 
        let v456 : US3 = v455 v431
        let v469 : uint64 =
            match v456 with
            | US3_1 -> (* None *)
                v425
            | US3_0(v464) -> (* Some *)
                let v465 : (int64 -> uint64) = uint64
                let v466 : uint64 = v465 v464
                let v467 : uint64 = v425 - v466
                v467
        let v470 : uint64 = v469 / 1000000000UL
        let v471 : uint64 = v470 % 60UL
        let v472 : uint64 = v470 / 60UL
        let v473 : uint64 = v472 % 60UL
        let v474 : uint64 = v470 / 3600UL
        let v475 : uint64 = v474 % 24UL
        let v476 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v477 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v475, v473, v471) v476 
        let v478 : string = "fable_library_rust::String_::fromString($0)"
        let v479 : string = Fable.Core.RustInterop.emitRustExpr v477 v478 
        let result = v479 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v482 : US3 option = None
        let _v482 = ref v482 
        match v111 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v483 : int64 = x
        let v484 : US3 = US3_0(v483)
        v484 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v482.Value <- x
        let v485 : US3 option = _v482.Value 
        let v508 : US3 = US3_1
        let v509 : (US3 option -> US3) = Option.defaultValue v508 
        let v510 : US3 = v509 v485
        let v608 : System.DateTime =
            match v510 with
            | US3_1 -> (* None *)
                let v600 : System.DateTime = System.DateTime.Now
                v600
            | US3_0(v518) -> (* Some *)
                let v521 : System.DateTime = System.DateTime.Now
                let v530 : (System.DateTime -> int64) = _.Ticks
                let v531 : int64 = v530 v521
                let v538 : int64 = v531 - v518
                let v541 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v542 : System.TimeSpan = v541 v538
                let v551 : (System.TimeSpan -> int32) = _.Hours
                let v552 : int32 = v551 v542
                let v561 : (System.TimeSpan -> int32) = _.Minutes
                let v562 : int32 = v561 v542
                let v571 : (System.TimeSpan -> int32) = _.Seconds
                let v572 : int32 = v571 v542
                let v581 : (System.TimeSpan -> int32) = _.Milliseconds
                let v582 : int32 = v581 v542
                let v591 : System.DateTime = System.DateTime (1, 1, 1, v552, v562, v572, v582)
                v591
        let v611 : string = method5()
        let v620 : (string -> string) = v608.ToString
        let v621 : string = v620 v611
        let result = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v630 : US3 option = None
        let _v630 = ref v630 
        match v111 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v631 : int64 = x
        let v632 : US3 = US3_0(v631)
        v632 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v630.Value <- x
        let v633 : US3 option = _v630.Value 
        let v656 : US3 = US3_1
        let v657 : (US3 option -> US3) = Option.defaultValue v656 
        let v658 : US3 = v657 v633
        let v756 : System.DateTime =
            match v658 with
            | US3_1 -> (* None *)
                let v748 : System.DateTime = System.DateTime.Now
                v748
            | US3_0(v666) -> (* Some *)
                let v669 : System.DateTime = System.DateTime.Now
                let v678 : (System.DateTime -> int64) = _.Ticks
                let v679 : int64 = v678 v669
                let v686 : int64 = v679 - v666
                let v689 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v690 : System.TimeSpan = v689 v686
                let v699 : (System.TimeSpan -> int32) = _.Hours
                let v700 : int32 = v699 v690
                let v709 : (System.TimeSpan -> int32) = _.Minutes
                let v710 : int32 = v709 v690
                let v719 : (System.TimeSpan -> int32) = _.Seconds
                let v720 : int32 = v719 v690
                let v729 : (System.TimeSpan -> int32) = _.Milliseconds
                let v730 : int32 = v729 v690
                let v739 : System.DateTime = System.DateTime (1, 1, 1, v700, v710, v720, v730)
                v739
        let v759 : string = method5()
        let v768 : (string -> string) = v756.ToString
        let v769 : string = v768 v759
        let result = v769 
        #endif
#else
        let v778 : US3 option = None
        let _v778 = ref v778 
        match v111 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v779 : int64 = x
        let v780 : US3 = US3_0(v779)
        v780 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v778.Value <- x
        let v781 : US3 option = _v778.Value 
        let v804 : US3 = US3_1
        let v805 : (US3 option -> US3) = Option.defaultValue v804 
        let v806 : US3 = v805 v781
        let v904 : System.DateTime =
            match v806 with
            | US3_1 -> (* None *)
                let v896 : System.DateTime = System.DateTime.Now
                v896
            | US3_0(v814) -> (* Some *)
                let v817 : System.DateTime = System.DateTime.Now
                let v826 : (System.DateTime -> int64) = _.Ticks
                let v827 : int64 = v826 v817
                let v834 : int64 = v827 - v814
                let v837 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v838 : System.TimeSpan = v837 v834
                let v847 : (System.TimeSpan -> int32) = _.Hours
                let v848 : int32 = v847 v838
                let v857 : (System.TimeSpan -> int32) = _.Minutes
                let v858 : int32 = v857 v838
                let v867 : (System.TimeSpan -> int32) = _.Seconds
                let v868 : int32 = v867 v838
                let v877 : (System.TimeSpan -> int32) = _.Milliseconds
                let v878 : int32 = v877 v838
                let v887 : System.DateTime = System.DateTime (1, 1, 1, v848, v858, v868, v878)
                v887
        let v907 : string = method5()
        let v916 : (string -> string) = v904.ToString
        let v917 : string = v916 v907
        let result = v917 
        #endif
        let v924 : string = result
        let v1086 : string = "Debug"
        let v1087 : (unit -> string) = v1086.ToLower
        let v1088 : string = v1087 ()
        let v1097 : string = v1088.PadLeft (7, ' ')
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1129 : string = "inline_colorization::color_bright_blue"
        let v1130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1129 
        let v1131 : string = "&*$0"
        let v1132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1097 v1131 
        let v1133 : string = "inline_colorization::color_reset"
        let v1134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1133 
        let v1135 : string = "\"{v1130}{v1132}{v1134}\""
        let v1136 : string = @$"format!(" + v1135 + ")"
        let v1137 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1136 
        let v1138 : string = "fable_library_rust::String_::fromString($0)"
        let v1139 : string = Fable.Core.RustInterop.emitRustExpr v1137 v1138 
        let result = v1139 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1140 : string = "inline_colorization::color_bright_blue"
        let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
        let v1142 : string = "&*$0"
        let v1143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1097 v1142 
        let v1144 : string = "inline_colorization::color_reset"
        let v1145 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1144 
        let v1146 : string = "\"{v1141}{v1143}{v1145}\""
        let v1147 : string = @$"format!(" + v1146 + ")"
        let v1148 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1147 
        let v1149 : string = "fable_library_rust::String_::fromString($0)"
        let v1150 : string = Fable.Core.RustInterop.emitRustExpr v1148 v1149 
        let result = v1150 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1151 : string = "inline_colorization::color_bright_blue"
        let v1152 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1151 
        let v1153 : string = "&*$0"
        let v1154 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1097 v1153 
        let v1155 : string = "inline_colorization::color_reset"
        let v1156 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1155 
        let v1157 : string = "\"{v1152}{v1154}{v1156}\""
        let v1158 : string = @$"format!(" + v1157 + ")"
        let v1159 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1158 
        let v1160 : string = "fable_library_rust::String_::fromString($0)"
        let v1161 : string = Fable.Core.RustInterop.emitRustExpr v1159 v1160 
        let result = v1161 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1162 : string = "\u001b[94m"
        let v1163 : string = method6()
        let v1164 : string = v1162 + v1097 
        let v1165 : string = v1164 + v1163 
        let result = v1165 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1166 : string = "\u001b[94m"
        let v1167 : string = method6()
        let v1168 : string = v1166 + v1097 
        let v1169 : string = v1168 + v1167 
        let result = v1169 
        #endif
#else
        let v1170 : string = "\u001b[94m"
        let v1171 : string = method6()
        let v1172 : string = v1170 + v1097 
        let v1173 : string = v1172 + v1171 
        let result = v1173 
        #endif
        let v1174 : string = result
        let v1184 : int64 = v107.l0
        let v1185 : string = ""
        let v1186 : Mut4 = {l0 = v1185} : Mut4
        let v1189 : string = "{ "
        let v1190 : string = $"{v1189}"
        let v1197 : string = v1186.l0
        let v1198 : string = v1197 + v1190 
        v1186.l0 <- v1198
        let v1201 : string = "args"
        let v1202 : string = $"{v1201}"
        let v1209 : string = v1186.l0
        let v1210 : string = v1209 + v1202 
        v1186.l0 <- v1210
        let v1213 : string = " = "
        let v1214 : string = $"{v1213}"
        let v1221 : string = v1186.l0
        let v1222 : string = v1221 + v1214 
        v1186.l0 <- v1222
        let v1225 : string = $"%A{v0}"
        let v1234 : string = $"{v1225}"
        let v1241 : string = v1186.l0
        let v1242 : string = v1241 + v1234 
        v1186.l0 <- v1242
        let v1245 : string = " }"
        let v1246 : string = $"{v1245}"
        let v1253 : string = v1186.l0
        let v1254 : string = v1253 + v1246 
        v1186.l0 <- v1254
        let v1255 : string = v1186.l0
        let v1258 : (unit -> string) = closure4()
        let v1259 : string = $"{v924} {v1174} #{v1184} %s{v1258 ()} / {v1255}"
        let v1266 : char list = []
        let v1271 : (char list -> (char [])) = List.toArray
        let v1272 : (char []) = v1271 v1266
        let v1279 : string = v1259.TrimStart v1272 
        let v1318 : char list = []
        let v1321 : char list = '/' :: v1318 
        let v1330 : char list = ' ' :: v1321 
        let v1341 : (char list -> (char [])) = List.toArray
        let v1342 : (char []) = v1341 v1330
        let v1349 : string = v1279.TrimEnd v1342 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1390 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1349 v1390 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1391 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1349 v1391 
        let result = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1392 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1349 v1392 
        let result = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1349 
        let result = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1349 
        let result = () 
        #endif
#else
        System.Console.WriteLine v1349 
        let result = () 
        #endif
        result
        let v1421 : (string -> unit) = v42.l0
        v1421 v1349
    let v1422 : clap_Command = method7()
    let v1423 : string = "clap::Command::get_matches($0)"
    let v1424 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v1422 v1423 
    let v1425 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> = method8(v1424)
    let v1426 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v1427 : _ = Fable.Core.RustInterop.emitRustExpr () v1426 
    let v1428 : string = "v1427.handle().block_on($0)"
    let v1429 : Result<unit, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v1425 v1428 
    let v1430 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v1429 v1430 
    0
let v0 : (unit -> unit) = closure0()
v0 |> ignore
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
