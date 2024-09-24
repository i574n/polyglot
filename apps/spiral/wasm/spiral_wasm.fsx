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
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgAction")>]
#endif
type clap_ArgAction = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::PossibleValue")>]
#endif
type clap_builder_PossibleValue = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueParser")>]
#endif
type clap_builder_ValueParser = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::types::Gas")>]
#endif
type near_workspaces_types_Gas = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionOutcome")>]
#endif
type near_workspaces_result_ExecutionOutcome = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::types::NearToken")>]
#endif
type near_workspaces_types_NearToken = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("u128")>]
#endif
type u128 = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("anyhow::Error")>]
#endif
type anyhow_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
module TraceState = let mutable trace_state = None
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
type IOsEnviron = abstract environ: x: unit -> obj
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
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionSuccess")>]
#endif
type near_workspaces_result_ExecutionSuccess = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionFailure")>]
#endif
type near_workspaces_result_ExecutionFailure = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
type [<Struct>] US0 =
    | US0_0 of f0_0 : std_string_String
    | US0_1
and [<Struct>] US3 =
    | US3_0
    | US3_1
    | US3_2
    | US3_3
    | US3_4
and [<Struct>] US2 =
    | US2_0 of f0_0 : US3
    | US2_1
and [<Struct>] US1 =
    | US1_0 of f0_0 : US2
    | US1_1
and Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : (string -> unit)}
and Mut2 = {mutable l0 : bool}
and Mut3 = {mutable l0 : string}
and Mut4 = {mutable l0 : US3}
and [<Struct>] US4 =
    | US4_0 of f0_0 : string
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : US4
    | US6_1 of f1_0 : std_string_String
and [<Struct>] US7 =
    | US7_0 of f0_0 : uint8
    | US7_1 of f1_0 : uint8
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint8
    | US8_1
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "clap::Command::args_override_self($0, true)"
    let v6 : clap_Command = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "exception"
    let v8 : string = "r#\"" + v7 + "\"#"
    let v9 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "clap::Arg::new($0)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.short($1)"
    let v13 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, 'e') v12 
    let v14 : string = "r#\"" + v7 + "\"#"
    let v15 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.long($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v16 
    let v18 : string = "clap::ArgAction::SetTrue"
    let v19 : clap_ArgAction = Fable.Core.RustInterop.emitRustExpr () v18 
    let v20 : string = "$0.action($1)"
    let v21 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v17, v19) v20 
    let v22 : string = "clap::Command::arg($0, $1)"
    let v23 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v6, v21) v22 
    let v24 : string = "trace_level"
    let v25 : string = "r#\"" + v24 + "\"#"
    let v26 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v25 
    let v27 : string = "clap::Arg::new($0)"
    let v28 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "$0.short($1)"
    let v30 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v28, 't') v29 
    let v31 : string = "r#\"" + v24 + "\"#"
    let v32 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = "$0.long($1)"
    let v34 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33 
    
    
    
    
    
    let v35 : string list = []
    let v36 : string = "Critical"
    let v37 : string list = v36 :: v35 
    let v40 : string = "Warning"
    let v41 : string list = v40 :: v37 
    let v44 : string = "Info"
    let v45 : string list = v44 :: v41 
    let v48 : string = "Debug"
    let v49 : string list = v48 :: v45 
    let v52 : string = "Verbose"
    let v53 : string list = v52 :: v49 
    let v56 : (string list -> (string [])) = List.toArray
    let v57 : (string []) = v56 v53
    let v60 : string = "$0.to_vec()"
    let v61 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v57 v60 
    let v62 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v63 : bool = Fable.Core.RustInterop.emitRustExpr v61 v62 
    let v64 : string = "x"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr () v64 
    let v66 : string = "&*$0"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v66 
    let v68 : string = "String::from($0)"
    let v69 : std_string_String = Fable.Core.RustInterop.emitRustExpr v67 v68 
    let v70 : string = "Box::new($0)"
    let v71 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v69 v70 
    let v72 : string = "Box::leak($0)"
    let v73 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let v74 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v75 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v73 v74 
    let v76 : string = "true; $0 }).collect::<Vec<_>>()"
    let v77 : bool = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "_vec_map"
    let v79 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v81 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "$0.value_parser($1)"
    let v83 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v34, v81) v82 
    let v84 : string = "clap::Command::arg($0, $1)"
    let v85 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v23, v83) v84 
    let v86 : string = "wasm"
    let v87 : string = "r#\"" + v86 + "\"#"
    let v88 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : string = "clap::Arg::new($0)"
    let v90 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "$0.short($1)"
    let v92 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v90, 'w') v91 
    let v93 : string = "r#\"" + v86 + "\"#"
    let v94 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "$0.long($1)"
    let v96 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v92, v94) v95 
    let v97 : string = "$0.required($1)"
    let v98 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v96, true) v97 
    let v99 : string = "clap::Command::arg($0, $1)"
    let v100 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v85, v98) v99 
    v100
and method1 () : string =
    let v0 : string = "trace_level"
    v0
and closure1 () (v0 : std_string_String) : US0 =
    US0_0(v0)
and method2 () : (std_string_String -> US0) =
    closure1()
and method4 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method6 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US4 =
    US4_0(v0)
and method7 () : (string -> US4) =
    closure3()
and method5 (v0 : string) : string =
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
    let v14 : string = method6()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result_map_"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method6()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result_map_ = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result_map_"
    let v43 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = method6()
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
    let v64 : (string -> US4) = method7()
    let v65 : US4 option = v61 |> Option.map v64 
    let v76 : US4 = US4_1
    let v77 : US4 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US4_1 -> (* None *)
            let v82 : string = ""
            v82
        | US4_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#else
    let v85 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v86 : string = v85 v0
    let mutable _v86 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v87 : (string -> string option) = Option.ofObj
    let v88 : string option = v87 v86
    v88 
    #else
    Some v86 
    #endif
    |> fun x -> _v86 <- Some x
    let v89 : string option = match _v86 with Some x -> x | None -> failwith "optionm'.of_obj / _v86=None"
    let v92 : (string -> US4) = method7()
    let v93 : US4 option = v89 |> Option.map v92 
    let v104 : US4 = US4_1
    let v105 : US4 = v93 |> Option.defaultValue v104 
    let v112 : string =
        match v105 with
        | US4_1 -> (* None *)
            let v110 : string = ""
            v110
        | US4_0(v109) -> (* Some *)
            v109
    let _v1 = v112 
    #endif
    let v113 : string = _v1 
    v113
and method8 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure4 () (v0 : string) : unit =
    ()
and method3 (v0 : US3) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method4()
    let v3 : string = method5(v2)
    
    
    
    
    
    let v4 : bool = "Verbose" = v3
    let v8 : US2 =
        if v4 then
            let v5 : US3 = US3_0
            US2_0(v5)
        else
            US2_1
    let v49 : US2 =
        match v8 with
        | US2_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US2 =
                if v11 then
                    let v12 : US3 = US3_1
                    US2_0(v12)
                else
                    US2_1
            match v15 with
            | US2_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US2 =
                    if v18 then
                        let v19 : US3 = US3_2
                        US2_0(v19)
                    else
                        US2_1
                match v22 with
                | US2_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US2 =
                        if v25 then
                            let v26 : US3 = US3_3
                            US2_0(v26)
                        else
                            US2_1
                    match v29 with
                    | US2_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US2 =
                            if v32 then
                                let v33 : US3 = US3_4
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
    let v50 : string = method8()
    let v51 : string = method5(v50)
    let v52 : bool = v51 = "True"
    let v62 : US5 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US5_0(v57)
        else
            US5_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US2 = US2_1
    let v64 : US5 = US5_1
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
    let v109 : US5 =
        if v100 then
            US5_1
        else
            let v104 : string = $"near_sdk::env::block_timestamp()"
            let v105 : uint64 = Fable.Core.RustInterop.emitRustExpr () v104 
            let v106 : (uint64 -> int64) = int64
            let v107 : int64 = v106 v105
            US5_0(v107)
    let v110 : US2 = US2_1
    let _v1 = struct (v110, v109) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v111 : string = method4()
    let v112 : string = method5(v111)
    
    
    
    
    
    let v113 : bool = "Verbose" = v112
    let v117 : US2 =
        if v113 then
            let v114 : US3 = US3_0
            US2_0(v114)
        else
            US2_1
    let v158 : US2 =
        match v117 with
        | US2_1 -> (* None *)
            let v120 : bool = "Debug" = v112
            let v124 : US2 =
                if v120 then
                    let v121 : US3 = US3_1
                    US2_0(v121)
                else
                    US2_1
            match v124 with
            | US2_1 -> (* None *)
                let v127 : bool = "Info" = v112
                let v131 : US2 =
                    if v127 then
                        let v128 : US3 = US3_2
                        US2_0(v128)
                    else
                        US2_1
                match v131 with
                | US2_1 -> (* None *)
                    let v134 : bool = "Warning" = v112
                    let v138 : US2 =
                        if v134 then
                            let v135 : US3 = US3_3
                            US2_0(v135)
                        else
                            US2_1
                    match v138 with
                    | US2_1 -> (* None *)
                        let v141 : bool = "Critical" = v112
                        let v145 : US2 =
                            if v141 then
                                let v142 : US3 = US3_4
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
    let v159 : string = method8()
    let v160 : string = method5(v159)
    let v161 : bool = v160 = "True"
    let v171 : US5 =
        if v161 then
            let v162 : System.DateTime = System.DateTime.Now
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v162
            US5_0(v166)
        else
            US5_1
    let _v1 = struct (v158, v171) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v172 : string = method4()
    let v173 : string = method5(v172)
    
    
    
    
    
    let v174 : bool = "Verbose" = v173
    let v178 : US2 =
        if v174 then
            let v175 : US3 = US3_0
            US2_0(v175)
        else
            US2_1
    let v219 : US2 =
        match v178 with
        | US2_1 -> (* None *)
            let v181 : bool = "Debug" = v173
            let v185 : US2 =
                if v181 then
                    let v182 : US3 = US3_1
                    US2_0(v182)
                else
                    US2_1
            match v185 with
            | US2_1 -> (* None *)
                let v188 : bool = "Info" = v173
                let v192 : US2 =
                    if v188 then
                        let v189 : US3 = US3_2
                        US2_0(v189)
                    else
                        US2_1
                match v192 with
                | US2_1 -> (* None *)
                    let v195 : bool = "Warning" = v173
                    let v199 : US2 =
                        if v195 then
                            let v196 : US3 = US3_3
                            US2_0(v196)
                        else
                            US2_1
                    match v199 with
                    | US2_1 -> (* None *)
                        let v202 : bool = "Critical" = v173
                        let v206 : US2 =
                            if v202 then
                                let v203 : US3 = US3_4
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
    let v220 : string = method8()
    let v221 : string = method5(v220)
    let v222 : bool = v221 = "True"
    let v232 : US5 =
        if v222 then
            let v223 : System.DateTime = System.DateTime.Now
            let v226 : (System.DateTime -> int64) = _.Ticks
            let v227 : int64 = v226 v223
            US5_0(v227)
        else
            US5_1
    let _v1 = struct (v219, v232) 
    #endif
#else
    let v233 : string = method4()
    let v234 : string = method5(v233)
    
    
    
    
    
    let v235 : bool = "Verbose" = v234
    let v239 : US2 =
        if v235 then
            let v236 : US3 = US3_0
            US2_0(v236)
        else
            US2_1
    let v280 : US2 =
        match v239 with
        | US2_1 -> (* None *)
            let v242 : bool = "Debug" = v234
            let v246 : US2 =
                if v242 then
                    let v243 : US3 = US3_1
                    US2_0(v243)
                else
                    US2_1
            match v246 with
            | US2_1 -> (* None *)
                let v249 : bool = "Info" = v234
                let v253 : US2 =
                    if v249 then
                        let v250 : US3 = US3_2
                        US2_0(v250)
                    else
                        US2_1
                match v253 with
                | US2_1 -> (* None *)
                    let v256 : bool = "Warning" = v234
                    let v260 : US2 =
                        if v256 then
                            let v257 : US3 = US3_3
                            US2_0(v257)
                        else
                            US2_1
                    match v260 with
                    | US2_1 -> (* None *)
                        let v263 : bool = "Critical" = v234
                        let v267 : US2 =
                            if v263 then
                                let v264 : US3 = US3_4
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
    let v281 : string = method8()
    let v282 : string = method5(v281)
    let v283 : bool = v282 = "True"
    let v293 : US5 =
        if v283 then
            let v284 : System.DateTime = System.DateTime.Now
            let v287 : (System.DateTime -> int64) = _.Ticks
            let v288 : int64 = v287 v284
            US5_0(v288)
        else
            US5_1
    let _v1 = struct (v280, v293) 
    #endif
    let struct (v294 : US2, v295 : US5) = _v1 
    let v359 : Mut0 = {l0 = 1L} : Mut0
    let v360 : (string -> unit) = closure4()
    let v361 : Mut1 = {l0 = v360} : Mut1
    let v362 : Mut2 = {l0 = true} : Mut2
    let v363 : string = ""
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v367 : US3 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v365) -> (* Some *)
            v365
    let v368 : Mut4 = {l0 = v367} : Mut4
    let v375 : int64 option =
        match v295 with
        | US5_1 -> (* None *)
            let v373 : int64 option = None
            v373
        | US5_0(v369) -> (* Some *)
            let v370 : int64 option = Some v369 
            v370
    struct (v359, v361, v362, v364, v368, v375)
and closure2 (v0 : US3) () : unit =
    let v1 : bool = TraceState.trace_state.IsNone
    if v1 then
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method3(v0)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure6 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US3 = US3_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method3(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure7 () (v0 : int64) : US5 =
    US5_0(v0)
and method10 () : (int64 -> US5) =
    closure7()
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
    let v7 : (int64 -> US5) = method10()
    let v8 : US5 option = v5 |> Option.map v7 
    let v19 : US5 = US5_1
    let v20 : US5 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US5_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US5_0(v24) -> (* Some *)
            let v25 : System.DateTime = System.DateTime.Now
            let v28 : (System.DateTime -> int64) = _.Ticks
            let v29 : int64 = v28 v25
            let v32 : int64 = v29 - v24
            let v33 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v34 : System.TimeSpan = v33 v32
            let v37 : (System.TimeSpan -> int32) = _.Hours
            let v38 : int32 = v37 v34
            let v41 : (System.TimeSpan -> int32) = _.Minutes
            let v42 : int32 = v41 v34
            let v45 : (System.TimeSpan -> int32) = _.Seconds
            let v46 : int32 = v45 v34
            let v49 : (System.TimeSpan -> int32) = _.Milliseconds
            let v50 : int32 = v49 v34
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v38, v42, v46, v50)
            v53
    let v61 : string = method11()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US5) = method10()
    let v69 : US5 option = v5 |> Option.map v68 
    let v80 : US5 = US5_1
    let v81 : US5 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US5_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US5_0(v85) -> (* Some *)
            let v86 : System.DateTime = System.DateTime.Now
            let v89 : (System.DateTime -> int64) = _.Ticks
            let v90 : int64 = v89 v86
            let v93 : int64 = v90 - v85
            let v94 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v95 : System.TimeSpan = v94 v93
            let v98 : (System.TimeSpan -> int32) = _.Hours
            let v99 : int32 = v98 v95
            let v102 : (System.TimeSpan -> int32) = _.Minutes
            let v103 : int32 = v102 v95
            let v106 : (System.TimeSpan -> int32) = _.Seconds
            let v107 : int32 = v106 v95
            let v110 : (System.TimeSpan -> int32) = _.Milliseconds
            let v111 : int32 = v110 v95
            let v114 : System.DateTime = System.DateTime (1, 1, 1, v99, v103, v107, v111)
            v114
    let v122 : string = method11()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US5) = method10()
    let v132 : US5 option = v5 |> Option.map v131 
    let v143 : US5 = US5_1
    let v144 : US5 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US5_1 -> (* None *)
            v130
        | US5_0(v148) -> (* Some *)
            let v149 : (int64 -> uint64) = uint64
            let v150 : uint64 = v149 v148
            let v151 : uint64 = v130 - v150
            v151
    let v154 : uint64 = v153 / 1000000000UL
    let v155 : uint64 = v154 % 60UL
    let v156 : uint64 = v154 / 60UL
    let v157 : uint64 = v156 % 60UL
    let v158 : uint64 = v154 / 3600UL
    let v159 : uint64 = v158 % 24UL
    let v160 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v161 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v159, v157, v155) v160 
    let v162 : string = "fable_library_rust::String_::fromString($0)"
    let v163 : string = Fable.Core.RustInterop.emitRustExpr v161 v162 
    let _v6 = v163 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : (int64 -> US5) = method10()
    let v165 : US5 option = v5 |> Option.map v164 
    let v176 : US5 = US5_1
    let v177 : US5 = v165 |> Option.defaultValue v176 
    let v217 : System.DateTime =
        match v177 with
        | US5_1 -> (* None *)
            let v213 : System.DateTime = System.DateTime.Now
            v213
        | US5_0(v181) -> (* Some *)
            let v182 : System.DateTime = System.DateTime.Now
            let v185 : (System.DateTime -> int64) = _.Ticks
            let v186 : int64 = v185 v182
            let v189 : int64 = v186 - v181
            let v190 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v191 : System.TimeSpan = v190 v189
            let v194 : (System.TimeSpan -> int32) = _.Hours
            let v195 : int32 = v194 v191
            let v198 : (System.TimeSpan -> int32) = _.Minutes
            let v199 : int32 = v198 v191
            let v202 : (System.TimeSpan -> int32) = _.Seconds
            let v203 : int32 = v202 v191
            let v206 : (System.TimeSpan -> int32) = _.Milliseconds
            let v207 : int32 = v206 v191
            let v210 : System.DateTime = System.DateTime (1, 1, 1, v195, v199, v203, v207)
            v210
    let v218 : string = method12()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US5) = method10()
    let v226 : US5 option = v5 |> Option.map v225 
    let v237 : US5 = US5_1
    let v238 : US5 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US5_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US5_0(v242) -> (* Some *)
            let v243 : System.DateTime = System.DateTime.Now
            let v246 : (System.DateTime -> int64) = _.Ticks
            let v247 : int64 = v246 v243
            let v250 : int64 = v247 - v242
            let v251 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v252 : System.TimeSpan = v251 v250
            let v255 : (System.TimeSpan -> int32) = _.Hours
            let v256 : int32 = v255 v252
            let v259 : (System.TimeSpan -> int32) = _.Minutes
            let v260 : int32 = v259 v252
            let v263 : (System.TimeSpan -> int32) = _.Seconds
            let v264 : int32 = v263 v252
            let v267 : (System.TimeSpan -> int32) = _.Milliseconds
            let v268 : int32 = v267 v252
            let v271 : System.DateTime = System.DateTime (1, 1, 1, v256, v260, v264, v268)
            v271
    let v279 : string = method12()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US5) = method10()
    let v287 : US5 option = v5 |> Option.map v286 
    let v298 : US5 = US5_1
    let v299 : US5 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US5_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US5_0(v303) -> (* Some *)
            let v304 : System.DateTime = System.DateTime.Now
            let v307 : (System.DateTime -> int64) = _.Ticks
            let v308 : int64 = v307 v304
            let v311 : int64 = v308 - v303
            let v312 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v313 : System.TimeSpan = v312 v311
            let v316 : (System.TimeSpan -> int32) = _.Hours
            let v317 : int32 = v316 v313
            let v320 : (System.TimeSpan -> int32) = _.Minutes
            let v321 : int32 = v320 v313
            let v324 : (System.TimeSpan -> int32) = _.Seconds
            let v325 : int32 = v324 v313
            let v328 : (System.TimeSpan -> int32) = _.Milliseconds
            let v329 : int32 = v328 v313
            let v332 : System.DateTime = System.DateTime (1, 1, 1, v317, v321, v325, v329)
            v332
    let v340 : string = method12()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method13 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_black"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_black"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_black"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[90m"
    let v51 : string = method14()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[90m"
    let v55 : string = method14()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[90m"
    let v59 : string = method14()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method16 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method15 (v0 : (string [])) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "args"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"%A{v0}"
    let v33 : string = $"{v30}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v2, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = " }"
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v2, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = v2.l0
    v50
and method17 (v0 : string, v1 : string, v2 : string, v3 : int64, v4 : string) : string =
    let v5 : string = $"{v0} {v1} #{v3} %s{v2} / {v4}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
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
and method18 (v0 : string, v1 : Mut0, v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure9(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure10()
    let v13 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v14 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v14 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v0 v15 
    let _v13 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v16 : string = v4.l0
    let v17 : bool = v16 = ""
    let v25 : string =
        if v17 then
            v0
        else
            let v18 : bool = v0 = ""
            if v18 then
                let v19 : string = v4.l0
                v19
            else
                let v20 : string = v4.l0
                let v21 : string = "\n"
                let v22 : string = v20 + v21 
                let v23 : string = v22 + v0 
                v23
    let v26 : string = "&*$0"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v26 
    let v28 : string = $"$0.chars()"
    let v29 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0"
    let v31 : _ = Fable.Core.RustInterop.emitRustExpr v29 v30 
    let v32 : string = "$0.collect::<Vec<_>>()"
    let v33 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v31 v32 
    let v34 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v35 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "String::from_iter($0)"
    let v41 : std_string_String = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 }).collect::<Vec<_>>()"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_vec_map"
    let v45 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "$0.len()"
    let v47 : unativeint = Fable.Core.RustInterop.emitRustExpr v45 v46 
    let v48 : (unativeint -> int32) = int32
    let v49 : int32 = v48 v47
    let v50 : string = ""
    let v51 : bool = v0 <> v50 
    let v55 : bool =
        if v51 then
            let v54 : bool = v49 <= 1
            v54
        else
            false
    if v55 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v50
        let v56 : string = "true; $0.into_iter().for_each(|x| { //"
        let v57 : bool = Fable.Core.RustInterop.emitRustExpr v45 v56 
        let v58 : string = "x"
        let v59 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v61 : bool = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v62 : string = $"true"
        let v63 : bool = Fable.Core.RustInterop.emitRustExpr () v62 
        let v64 : string = "true; }); //"
        let v65 : bool = Fable.Core.RustInterop.emitRustExpr () v64 
        ()
    let _v13 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v12 v0
    let _v13 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    v12 v0
    let _v13 = () 
    #endif
#else
    v12 v0
    let _v13 = () 
    #endif
    _v13 
    let v66 : (string -> unit) = v2.l0
    v66 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method13()
        let v76 : string = $"spiral_wasm.main"
        let v77 : bool = v76 = ""
        let v82 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = method15(v0)
                method17(v74, v75, v76, v79, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v2 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method18(v82, v98, v99, v100, v101, v102, v103)
and method19 () : string =
    let v0 : string = "exception"
    v0
and method21 () : string =
    let v0 : string = "wasm"
    v0
and method22 (v0 : string) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "wasm_path"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method23 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "spiral_wasm.run"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure12 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method13()
        let v76 : int64 = v56.l0
        let v77 : string = method22(v0)
        let v78 : string = method23(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method18(v78, v94, v95, v96, v97, v98, v99)
and method25 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "worker"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and closure13 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure6()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US3 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 0 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method9(v57, v58, v59, v60, v61, v62)
        let v76 : string = method13()
        let v77 : int64 = v57.l0
        let v78 : string = method25(v0, v1)
        let v79 : string = method23(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method26 (v0 : uint8, v1 : near_workspaces_Contract) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "contract"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and closure14 (v0 : uint8, v1 : near_workspaces_Contract) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure6()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US3 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 0 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method9(v57, v58, v59, v60, v61, v62)
        let v76 : string = method13()
        let v77 : int64 = v57.l0
        let v78 : string = method26(v0, v1)
        let v79 : string = method23(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method27 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "result"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and closure15 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure6()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US3 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 0 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method9(v57, v58, v59, v60, v61, v62)
        let v76 : string = method13()
        let v77 : int64 = v57.l0
        let v78 : string = method27(v0, v1)
        let v79 : string = method23(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure17 (v0 : std_string_String) () : unit =
    let v1 : (std_string_String -> unit) = System.Console.WriteLine
    v1 v0
and closure16 () (v0 : std_string_String) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure17(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method28 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_blue"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_blue"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_blue"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[94m"
    let v51 : string = method14()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[94m"
    let v55 : string = method14()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[94m"
    let v59 : string = method14()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method29 (v0 : uint8, v1 : float, v2 : uint64) : string =
    let v3 : string = method16()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "retry"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure8(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : string = $"{v0}"
    let v35 : unit = ()
    let v36 : (unit -> unit) = closure8(v4, v32)
    let v37 : unit = (fun () -> v36 (); v35) ()
    let v40 : string = "; "
    let v41 : string = $"{v40}"
    let v44 : unit = ()
    let v45 : (unit -> unit) = closure8(v4, v41)
    let v46 : unit = (fun () -> v45 (); v44) ()
    let v49 : string = "total_gas_burnt_usd"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"%+.6f{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "total_gas_burnt"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : string = $"{v2}"
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure8(v4, v99)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : string = " }"
    let v108 : string = $"{v107}"
    let v111 : unit = ()
    let v112 : (unit -> unit) = closure8(v4, v108)
    let v113 : unit = (fun () -> v112 (); v111) ()
    let v116 : string = v4.l0
    v116
and method30 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "near_workspaces.print_usd"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure18 (v0 : uint8, v1 : uint64, v2 : float) () : unit =
    let v3 : unit = ()
    let v4 : (unit -> unit) = closure6()
    let v5 : unit = (fun () -> v4 (); v3) ()
    let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
    let v37 : US3 = v23.l0
    let v38 : bool = v21.l0
    let v39 : bool = v38 = false
    let v42 : bool =
        if v39 then
            false
        else
            let v40 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v37
            let v41 : bool = 1 >= v40
            v41
    if v42 then
        let v43 : unit = ()
        let v44 : unit = (fun () -> v4 (); v43) ()
        let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : Mut4, v63 : int64 option) = TraceState.trace_state.Value
        let v76 : string = method9(v58, v59, v60, v61, v62, v63)
        let v77 : string = method28()
        let v78 : int64 = v58.l0
        let v79 : string = method29(v0, v2, v1)
        let v80 : string = method30(v76, v77, v78, v79)
        let v81 : unit = ()
        let v82 : unit = (fun () -> v4 (); v81) ()
        let struct (v96 : Mut0, v97 : Mut1, v98 : Mut2, v99 : Mut3, v100 : Mut4, v101 : int64 option) = TraceState.trace_state.Value
        method18(v80, v96, v97, v98, v99, v100, v101)
and method31 (v0 : bool, v1 : float, v2 : float, v3 : uint64, v4 : u128) : string =
    let v5 : string = method16()
    let v6 : Mut3 = {l0 = v5} : Mut3
    let v7 : string = "{ "
    let v8 : string = $"{v7}"
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure8(v6, v8)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v16 : string = "is_success"
    let v17 : string = $"{v16}"
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure8(v6, v17)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v25 : string = " = "
    let v26 : string = $"{v25}"
    let v29 : unit = ()
    let v30 : (unit -> unit) = closure8(v6, v26)
    let v31 : unit = (fun () -> v30 (); v29) ()
    let v36 : string =
        if v0 then
            let v34 : string = "true"
            v34
        else
            let v35 : string = "false"
            v35
    let v37 : string = $"{v36}"
    let v40 : unit = ()
    let v41 : (unit -> unit) = closure8(v6, v37)
    let v42 : unit = (fun () -> v41 (); v40) ()
    let v45 : string = "; "
    let v46 : string = $"{v45}"
    let v49 : unit = ()
    let v50 : (unit -> unit) = closure8(v6, v46)
    let v51 : unit = (fun () -> v50 (); v49) ()
    let v54 : string = "gas_burnt_usd"
    let v55 : string = $"{v54}"
    let v58 : unit = ()
    let v59 : (unit -> unit) = closure8(v6, v55)
    let v60 : unit = (fun () -> v59 (); v58) ()
    let v63 : string = $"{v25}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure8(v6, v63)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v71 : string = $"%+.6f{v1}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v6, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v79 : string = $"{v45}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure8(v6, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v87 : string = "tokens_burnt_usd"
    let v88 : string = $"{v87}"
    let v91 : unit = ()
    let v92 : (unit -> unit) = closure8(v6, v88)
    let v93 : unit = (fun () -> v92 (); v91) ()
    let v96 : string = $"{v25}"
    let v99 : unit = ()
    let v100 : (unit -> unit) = closure8(v6, v96)
    let v101 : unit = (fun () -> v100 (); v99) ()
    let v104 : string = $"%+.6f{v2}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v6, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = $"{v45}"
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure8(v6, v112)
    let v117 : unit = (fun () -> v116 (); v115) ()
    let v120 : string = "gas_burnt"
    let v121 : string = $"{v120}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v6, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : string = $"{v25}"
    let v132 : unit = ()
    let v133 : (unit -> unit) = closure8(v6, v129)
    let v134 : unit = (fun () -> v133 (); v132) ()
    let v137 : string = $"{v3}"
    let v140 : unit = ()
    let v141 : (unit -> unit) = closure8(v6, v137)
    let v142 : unit = (fun () -> v141 (); v140) ()
    let v145 : string = $"{v45}"
    let v148 : unit = ()
    let v149 : (unit -> unit) = closure8(v6, v145)
    let v150 : unit = (fun () -> v149 (); v148) ()
    let v153 : string = "tokens_burnt"
    let v154 : string = $"{v153}"
    let v157 : unit = ()
    let v158 : (unit -> unit) = closure8(v6, v154)
    let v159 : unit = (fun () -> v158 (); v157) ()
    let v162 : string = $"{v25}"
    let v165 : unit = ()
    let v166 : (unit -> unit) = closure8(v6, v162)
    let v167 : unit = (fun () -> v166 (); v165) ()
    let v170 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v171 : string = "format!(\"{:#?}\", $0)"
    let v172 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v171 
    let v173 : string = "fable_library_rust::String_::fromString($0)"
    let v174 : string = Fable.Core.RustInterop.emitRustExpr v172 v173 
    let _v170 = v174 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v175 : string = "format!(\"{:#?}\", $0)"
    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v175 
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177 
    let _v170 = v178 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = "format!(\"{:#?}\", $0)"
    let v180 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v179 
    let v181 : string = "fable_library_rust::String_::fromString($0)"
    let v182 : string = Fable.Core.RustInterop.emitRustExpr v180 v181 
    let _v170 = v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : string = $"%A{v4}"
    let _v170 = v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v186 : string = $"%A{v4}"
    let _v170 = v186 
    #endif
#else
    let v189 : string = $"%A{v4}"
    let _v170 = v189 
    #endif
    let v192 : string = _v170 
    let v197 : string = $"{v192}"
    let v200 : unit = ()
    let v201 : (unit -> unit) = closure8(v6, v197)
    let v202 : unit = (fun () -> v201 (); v200) ()
    let v205 : string = " }"
    let v206 : string = $"{v205}"
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure8(v6, v206)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v214 : string = v6.l0
    v214
and method32 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "near_workspaces.print_usd / outcome"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure20 (v0 : bool, v1 : uint64, v2 : float, v3 : u128, v4 : float) () : unit =
    let v5 : unit = ()
    let v6 : (unit -> unit) = closure6()
    let v7 : unit = (fun () -> v6 (); v5) ()
    let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
    let v39 : US3 = v25.l0
    let v40 : bool = v23.l0
    let v41 : bool = v40 = false
    let v44 : bool =
        if v41 then
            false
        else
            let v42 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v39
            let v43 : bool = 1 >= v42
            v43
    if v44 then
        let v45 : unit = ()
        let v46 : unit = (fun () -> v6 (); v45) ()
        let struct (v60 : Mut0, v61 : Mut1, v62 : Mut2, v63 : Mut3, v64 : Mut4, v65 : int64 option) = TraceState.trace_state.Value
        let v78 : string = method9(v60, v61, v62, v63, v64, v65)
        let v79 : string = method28()
        let v80 : int64 = v60.l0
        let v81 : string = method31(v0, v2, v4, v1, v3)
        let v82 : string = method32(v78, v79, v80, v81)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v6 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method18(v82, v98, v99, v100, v101, v102, v103)
and closure19 () (v0 : near_workspaces_result_ExecutionOutcome) : unit =
    let v1 : string = "$0.is_success()"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : string = "$0.gas_burnt"
    let v4 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v0 v3 
    let v5 : string = "$0.as_gas()"
    let v6 : uint64 = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : (uint64 -> float) = float
    let v8 : float = v7 v6
    let v9 : float = v8 / 10000000000000000.0
    let v10 : float = v9 * 6.68
    let v11 : string = "$0.tokens_burnt"
    let v12 : near_workspaces_types_NearToken = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let v13 : string = "$0.as_yoctonear()"
    let v14 : u128 = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "$0 as f64"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : float = v16 / 1E+24
    let v18 : float = v17 * 6.68
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure20(v2, v6, v10, v14, v18)
    let v21 : unit = (fun () -> v20 (); v19) ()
    ()
and method33 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "result2"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
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
#else
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
    let v52 : string = _v30 
    let v57 : string = $"{v52}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v2, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = " }"
    let v66 : string = $"{v65}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v2, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = v2.l0
    v74
and closure21 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method13()
        let v76 : int64 = v56.l0
        let v77 : string = method33(v0)
        let v78 : string = method23(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method18(v78, v94, v95, v96, v97, v98, v99)
and method34 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method35 (v0 : int32, v1 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "receipt_failures_len"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "receipt_failures"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and closure22 (v0 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>, v1 : int32) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure6()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US3 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 0 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method9(v57, v58, v59, v60, v61, v62)
        let v76 : string = method13()
        let v77 : int64 = v57.l0
        let v78 : string = method35(v1, v0)
        let v79 : string = method23(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method36 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method37 (v0 : int32, v1 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "receipt_outcomes_len"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "receipt_outcomes"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and closure23 (v0 : Vec<near_workspaces_result_ExecutionOutcome>, v1 : int32) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure6()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US3 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 0 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method9(v57, v58, v59, v60, v61, v62)
        let v76 : string = method13()
        let v77 : int64 = v57.l0
        let v78 : string = method37(v1, v0)
        let v79 : string = method23(v75, v76, v77, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method38 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "json"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
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
#else
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
    let v52 : string = _v30 
    let v57 : string = $"{v52}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v2, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = " }"
    let v66 : string = $"{v65}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v2, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = v2.l0
    v74
and closure24 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method13()
        let v76 : int64 = v56.l0
        let v77 : string = method38(v0)
        let v78 : string = method23(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method18(v78, v94, v95, v96, v97, v98, v99)
and method39 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "borsh"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
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
#else
    let v49 : string = $"%A{v0}"
    let _v30 = v49 
    #endif
    let v52 : string = _v30 
    let v57 : string = $"{v52}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v2, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = " }"
    let v66 : string = $"{v65}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v2, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = v2.l0
    v74
and closure25 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method13()
        let v76 : int64 = v56.l0
        let v77 : string = method39(v0)
        let v78 : string = method23(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method18(v78, v94, v95, v96, v97, v98, v99)
and method40 (v0 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>, v1 : int32, v2 : uint8) : string =
    let v3 : string = method16()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "receipt_failures"
    let v15 : string = $"{v14}"
    let v18 : unit = ()
    let v19 : (unit -> unit) = closure8(v4, v15)
    let v20 : unit = (fun () -> v19 (); v18) ()
    let v23 : string = " = "
    let v24 : string = $"{v23}"
    let v27 : unit = ()
    let v28 : (unit -> unit) = closure8(v4, v24)
    let v29 : unit = (fun () -> v28 (); v27) ()
    let v32 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v33 : string = "format!(\"{:#?}\", $0)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v32 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "format!(\"{:#?}\", $0)"
    let v38 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v37 
    let v39 : string = "fable_library_rust::String_::fromString($0)"
    let v40 : string = Fable.Core.RustInterop.emitRustExpr v38 v39 
    let _v32 = v40 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v41 : string = "format!(\"{:#?}\", $0)"
    let v42 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v41 
    let v43 : string = "fable_library_rust::String_::fromString($0)"
    let v44 : string = Fable.Core.RustInterop.emitRustExpr v42 v43 
    let _v32 = v44 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = $"%A{v0}"
    let _v32 = v45 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : string = $"%A{v0}"
    let _v32 = v48 
    #endif
#else
    let v51 : string = $"%A{v0}"
    let _v32 = v51 
    #endif
    let v54 : string = _v32 
    let v59 : string = $"{v54}"
    let v62 : unit = ()
    let v63 : (unit -> unit) = closure8(v4, v59)
    let v64 : unit = (fun () -> v63 (); v62) ()
    let v67 : string = "; "
    let v68 : string = $"{v67}"
    let v71 : unit = ()
    let v72 : (unit -> unit) = closure8(v4, v68)
    let v73 : unit = (fun () -> v72 (); v71) ()
    let v76 : string = "receipt_outcomes_len"
    let v77 : string = $"{v76}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure8(v4, v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v85 : string = $"{v23}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure8(v4, v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v93 : string = $"{v1}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v101 : string = $"{v67}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v4, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = "retry"
    let v110 : string = $"{v109}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure8(v4, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v118 : string = $"{v23}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure8(v4, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v126 : string = $"{v2}"
    let v129 : unit = ()
    let v130 : (unit -> unit) = closure8(v4, v126)
    let v131 : unit = (fun () -> v130 (); v129) ()
    let v134 : string = " }"
    let v135 : string = $"{v134}"
    let v138 : unit = ()
    let v139 : (unit -> unit) = closure8(v4, v135)
    let v140 : unit = (fun () -> v139 (); v138) ()
    let v143 : string = v4.l0
    v143
and method41 (v0 : Result<US4, anyhow_Error>) : Result<US4, anyhow_Error> =
    v0
and method24 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> =
    let v2 : string = "true; let __future_init = Box::pin(async move { //"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : string = "near_workspaces::sandbox().await"
    let v5 : Result<near_workspaces_Worker<near_workspaces_network_Sandbox>, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : string = "$0?"
    let v7 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure13(v1, v7)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v122 : string = "Box::pin($0.dev_deploy(&$1))"
    let v123 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_Contract, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr struct (v7, v0) v122 
    let v124 : string = "v123.await"
    let v125 : Result<near_workspaces_Contract, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v124 
    let v126 : string = "$0?"
    let v127 : near_workspaces_Contract = Fable.Core.RustInterop.emitRustExpr v125 v126 
    let v128 : unit = ()
    let v129 : (unit -> unit) = closure14(v1, v127)
    let v130 : unit = (fun () -> v129 (); v128) ()
    let v242 : string = "$0.call(&*$1)"
    let v243 : string = "state_main"
    let v244 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr struct (v127, v243) v242 
    let v245 : string = "Box::pin(v244.transact())"
    let v246 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v245 
    let v247 : string = "v246.await"
    let v248 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v247 
    let v249 : string = "$0?"
    let v250 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v248 v249 
    let v251 : unit = ()
    let v252 : (unit -> unit) = closure15(v1, v250)
    let v253 : unit = (fun () -> v252 (); v251) ()
    let v365 : string = "v250.logs()"
    let v366 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v365 
    let v367 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v368 : bool = Fable.Core.RustInterop.emitRustExpr v366 v367 
    let v369 : string = "x"
    let v370 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v369 
    let v371 : string = "String::from($0)"
    let v372 : std_string_String = Fable.Core.RustInterop.emitRustExpr v370 v371 
    let v373 : string = "true; $0 }).collect::<Vec<_>>()"
    let v374 : bool = Fable.Core.RustInterop.emitRustExpr v372 v373 
    let v375 : string = "_vec_map"
    let v376 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v375 
    let v377 : string = "true; $0.iter().for_each(|x| { $1(x.clone()); }); //"
    let v378 : (std_string_String -> unit) = closure16()
    let v379 : bool = Fable.Core.RustInterop.emitRustExpr struct (v376, v378) v377 
    let v380 : string = "$0.total_gas_burnt"
    let v381 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v250 v380 
    let v382 : string = "$0.as_gas()"
    let v383 : uint64 = Fable.Core.RustInterop.emitRustExpr v381 v382 
    let v384 : (uint64 -> float) = float
    let v385 : float = v384 v383
    let v386 : float = v385 / 10000000000000000.0
    let v387 : float = v386 * 6.68
    let v388 : unit = ()
    let v389 : (unit -> unit) = closure18(v1, v383, v387)
    let v390 : unit = (fun () -> v389 (); v388) ()
    let v502 : string = "$0"
    let v503 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v250 v502 
    let v504 : string = "v503.outcomes()"
    let v505 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v504 
    let v506 : string = "v505.into_iter()"
    let v507 : _ = Fable.Core.RustInterop.emitRustExpr () v506 
    let v508 : string = "v507.cloned()"
    let v509 : _ = Fable.Core.RustInterop.emitRustExpr () v508 
    let v510 : string = "true; v509.for_each(|x| $0(x))"
    let v511 : (near_workspaces_result_ExecutionOutcome -> unit) = closure19()
    let v512 : bool = Fable.Core.RustInterop.emitRustExpr v511 v510 
    let v513 : string = "$0.into_result()"
    let v514 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v250 v513 
    let v515 : unit = ()
    let v516 : (unit -> unit) = closure21(v514)
    let v517 : unit = (fun () -> v516 (); v515) ()
    let v629 : near_workspaces_result_ExecutionFinalResult = method34(v250)
    let v630 : string = "v629.receipt_failures()"
    let v631 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v630 
    let v632 : string = "$0.len()"
    let v633 : unativeint = Fable.Core.RustInterop.emitRustExpr v631 v632 
    let v634 : (unativeint -> int32) = int32
    let v635 : int32 = v634 v633
    let v636 : unit = ()
    let v637 : (unit -> unit) = closure22(v631, v635)
    let v638 : unit = (fun () -> v637 (); v636) ()
    let v750 : near_workspaces_result_ExecutionFinalResult = method36(v250)
    let v751 : string = "v750.receipt_outcomes()"
    let v752 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v751 
    let v753 : string = "v752.into()"
    let v754 : Vec<near_workspaces_result_ExecutionOutcome> = Fable.Core.RustInterop.emitRustExpr () v753 
    let v755 : string = "$0.len()"
    let v756 : unativeint = Fable.Core.RustInterop.emitRustExpr v754 v755 
    let v757 : (unativeint -> int32) = int32
    let v758 : int32 = v757 v756
    let v759 : unit = ()
    let v760 : (unit -> unit) = closure23(v754, v758)
    let v761 : unit = (fun () -> v760 (); v759) ()
    let v873 : string = "$0.json()"
    let v874 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v250 v873 
    let v875 : unit = ()
    let v876 : (unit -> unit) = closure24(v874)
    let v877 : unit = (fun () -> v876 (); v875) ()
    let v989 : string = "$0.borsh()"
    let v990 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v250 v989 
    let v991 : unit = ()
    let v992 : (unit -> unit) = closure25(v990)
    let v993 : unit = (fun () -> v992 (); v991) ()
    let v1105 : string = method40(v631, v758, v1)
    let v1106 : bool = v635 > 0
    let v1117 : Result<US4, anyhow_Error> =
        if v1106 then
            let v1107 : US4 = US4_0(v1105)
            let v1108 : Result<US4, anyhow_Error> = Ok v1107 
            v1108
        else
            let v1109 : bool = v758 > 1
            if v1109 then
                let v1110 : US4 = US4_1
                let v1111 : Result<US4, anyhow_Error> = Ok v1110 
                v1111
            else
                let v1112 : string = "anyhow::anyhow!($0)"
                let v1113 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v1105 v1112 
                let v1114 : string = "Err($0)"
                let v1115 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v1113 v1114 
                v1115
    let v1118 : Result<US4, anyhow_Error> = method41(v1117)
    let v1119 : string = ""
    let v1120 : string = "}"
    let v1121 : string = v1119 + v1120 
    let v1122 : string = "true; v1118 " + v1121 + "); " + v1119 + " // rust.fix_closure'"
    let v1123 : bool = Fable.Core.RustInterop.emitRustExpr () v1122 
    let v1124 : string = "__future_init"
    let v1125 : _ = Fable.Core.RustInterop.emitRustExpr () v1124 
    let v1126 : string = "v1125"
    let v1127 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v1126 
    v1127
and closure26 () (v0 : anyhow_Error) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
    let v17 : std_string_String = _v1 
    v17
and method42 () : (anyhow_Error -> std_string_String) =
    closure26()
and closure27 () (v0 : US4) : US6 =
    US6_0(v0)
and closure28 () (v0 : std_string_String) : US6 =
    US6_1(v0)
and method43 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_yellow"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_yellow"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_yellow"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[93m"
    let v51 : string = method14()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[93m"
    let v55 : string = method14()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[93m"
    let v59 : string = method14()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method44 (v0 : uint8, v1 : std_string_String) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "error"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
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
#else
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
    let v87 : string = _v65 
    let v92 : string = $"{v87}"
    let v95 : unit = ()
    let v96 : (unit -> unit) = closure8(v3, v92)
    let v97 : unit = (fun () -> v96 (); v95) ()
    let v100 : string = " }"
    let v101 : string = $"{v100}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v3, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = v3.l0
    v109
and method45 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "spiral_wasm.run / Error error"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure29 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 1uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure30 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 2uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure31 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 3uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure32 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 4uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure33 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 5uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure34 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 6uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure35 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 7uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure36 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 8uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure37 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 9uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure38 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 10uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure39 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 11uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure40 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 12uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure41 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 13uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure42 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 14uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure43 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 15uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure44 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 16uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure45 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 17uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure46 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 18uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure47 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 19uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure48 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 20uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure49 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 21uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure50 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 22uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure51 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 23uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure52 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 24uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure53 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 25uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure54 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 26uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure55 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 27uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure56 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 28uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and closure57 (v0 : std_string_String) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method43()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 29uy
        let v78 : string = method44(v77, v0)
        let v79 : string = method45(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method46 () : uint8 =
    30uy
and method47 (v0 : uint8) : US7 =
    US7_1(v0)
and method48 () : uint8 =
    29uy
and method49 (v0 : uint8) : US7 =
    US7_0(v0)
and method50 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_red"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : string = "&*$0"
    let v23 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v22 
    let v24 : string = "inline_colorization::color_reset"
    let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24 
    let v26 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v27 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v23, v25) v26 
    let v28 : string = "fable_library_rust::String_::fromString($0)"
    let v29 : string = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let _v19 = v29 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = "inline_colorization::color_bright_red"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "&*$0"
    let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v32 
    let v34 : string = "inline_colorization::color_reset"
    let v35 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v31, v33, v35) v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let _v19 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v40 : string = "inline_colorization::color_bright_red"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v42 
    let v44 : string = "inline_colorization::color_reset"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v47 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v41, v43, v45) v46 
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let _v19 = v49 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v50 : string = "\u001b[91m"
    let v51 : string = method14()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[91m"
    let v55 : string = method14()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[91m"
    let v59 : string = method14()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method51 (v0 : uint8, v1 : string) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retry"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure8(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure8(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "error"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure8(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure8(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure8(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and method52 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "spiral_wasm.run / Ok (Some error)"
    let v5 : string = $"{v0} {v1} #{v2} %s{v4} / {v3}"
    let v8 : char list = []
    let v9 : (char list -> (char [])) = List.toArray
    let v10 : (char []) = v9 v8
    let v13 : string = v5.TrimStart v10 
    let v31 : char list = []
    let v32 : char list = '/' :: v31 
    let v35 : char list = ' ' :: v32 
    let v38 : (char list -> (char [])) = List.toArray
    let v39 : (char []) = v38 v35
    let v42 : string = v13.TrimEnd v39 
    v42
and closure58 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 29uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method53 () : uint8 =
    28uy
and closure59 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 28uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method54 () : uint8 =
    27uy
and closure60 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 27uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method55 () : uint8 =
    26uy
and closure61 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 26uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method56 () : uint8 =
    25uy
and closure62 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 25uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method57 () : uint8 =
    24uy
and closure63 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 24uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method58 () : uint8 =
    23uy
and closure64 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 23uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method59 () : uint8 =
    22uy
and closure65 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 22uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method60 () : uint8 =
    21uy
and closure66 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 21uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method61 () : uint8 =
    20uy
and closure67 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 20uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method62 () : uint8 =
    19uy
and closure68 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 19uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method63 () : uint8 =
    18uy
and closure69 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 18uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method64 () : uint8 =
    17uy
and closure70 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 17uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method65 () : uint8 =
    16uy
and closure71 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 16uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method66 () : uint8 =
    15uy
and closure72 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 15uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method67 () : uint8 =
    14uy
and closure73 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 14uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method68 () : uint8 =
    13uy
and closure74 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 13uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method69 () : uint8 =
    12uy
and closure75 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 12uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method70 () : uint8 =
    11uy
and closure76 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 11uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method71 () : uint8 =
    10uy
and closure77 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 10uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method72 () : uint8 =
    9uy
and closure78 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 9uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method73 () : uint8 =
    8uy
and closure79 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 8uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method74 () : uint8 =
    7uy
and closure80 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 7uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method75 () : uint8 =
    6uy
and closure81 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 6uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method76 () : uint8 =
    5uy
and closure82 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 5uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method77 () : uint8 =
    4uy
and closure83 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 4uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method78 () : uint8 =
    3uy
and closure84 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 3uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method79 () : uint8 =
    2uy
and closure85 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 2uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method80 () : uint8 =
    1uy
and closure86 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 4 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method50()
        let v76 : int64 = v56.l0
        let v77 : uint8 = 1uy
        let v78 : string = method51(v77, v0)
        let v79 : string = method52(v74, v75, v76, v78)
        let v80 : unit = ()
        let v81 : unit = (fun () -> v2 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        method18(v79, v95, v96, v97, v98, v99, v100)
and method81 (v0 : US7) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "retries"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"%A{v0}"
    let v33 : string = $"{v30}"
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure8(v2, v33)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : string = " }"
    let v42 : string = $"{v41}"
    let v45 : unit = ()
    let v46 : (unit -> unit) = closure8(v2, v42)
    let v47 : unit = (fun () -> v46 (); v45) ()
    let v50 : string = v2.l0
    v50
and closure87 (v0 : US7) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method9(v56, v57, v58, v59, v60, v61)
        let v75 : string = method13()
        let v76 : int64 = v56.l0
        let v77 : string = method81(v0)
        let v78 : string = method23(v74, v75, v76, v77)
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        method18(v78, v94, v95, v96, v97, v98, v99)
and method82 (v0 : uint8) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure8(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "retries"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure8(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure8(v2, v22)
    let v27 : unit = (fun () -> v26 (); v25) ()
    let v30 : string = $"{v0}"
    let v33 : unit = ()
    let v34 : (unit -> unit) = closure8(v2, v30)
    let v35 : unit = (fun () -> v34 (); v33) ()
    let v38 : string = " }"
    let v39 : string = $"{v38}"
    let v42 : unit = ()
    let v43 : (unit -> unit) = closure8(v2, v39)
    let v44 : unit = (fun () -> v43 (); v42) ()
    let v47 : string = v2.l0
    v47
and method83 (v0 : Result<uint8, anyhow_Error>) : Result<uint8, anyhow_Error> =
    v0
and method20 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(async move { //"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = method21()
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "clap::ArgMatches::get_one(&$0, v5).cloned()"
    let v7 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let v8 : (std_string_String -> US0) = method2()
    let v9 : US0 option = v7 |> Option.map v8 
    let v20 : US0 = US0_1
    let v21 : US0 = v9 |> Option.defaultValue v20 
    let v28 : std_string_String =
        match v21 with
        | US0_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US0_0(v25) -> (* Some *)
            v25
    let v29 : string = "fable_library_rust::String_::fromString($0)"
    let v30 : string = Fable.Core.RustInterop.emitRustExpr v28 v29 
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure12(v30)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v145 : string = "std::fs::read(&*$0)"
    let v146 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v30 v145 
    let v147 : string = "$0?"
    let v148 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v146 v147 
    let v149 : uint8 = 1uy
    let v150 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v149)
    let v151 : string = "v150.await"
    let v152 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : (anyhow_Error -> std_string_String) = method42()
    let v154 : string = "$0.map_err(|x| $1(x))"
    let v155 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v152, v153) v154 
    let v156 : (US4 -> US6) = closure27()
    let v157 : (std_string_String -> US6) = closure28()
    let v158 : US6 = match v155 with Ok x -> v156 x | Error x -> v157 x
    let v8671 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> =
        match v158 with
        | US6_1(v326) -> (* Error *)
            let v327 : unit = ()
            let v328 : (unit -> unit) = closure29(v326)
            let v329 : unit = (fun () -> v328 (); v327) ()
            let v442 : uint8 = 2uy
            let v443 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v442)
            let v444 : string = "v443.await"
            let v445 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v444 
            let v446 : (anyhow_Error -> std_string_String) = method42()
            let v447 : string = "$0.map_err(|x| $1(x))"
            let v448 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v445, v446) v447 
            let v449 : US6 = match v448 with Ok x -> v156 x | Error x -> v157 x
            match v449 with
            | US6_1(v617) -> (* Error *)
                let v618 : unit = ()
                let v619 : (unit -> unit) = closure30(v617)
                let v620 : unit = (fun () -> v619 (); v618) ()
                let v733 : uint8 = 3uy
                let v734 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v733)
                let v735 : string = "v734.await"
                let v736 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v735 
                let v737 : (anyhow_Error -> std_string_String) = method42()
                let v738 : string = "$0.map_err(|x| $1(x))"
                let v739 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v736, v737) v738 
                let v740 : US6 = match v739 with Ok x -> v156 x | Error x -> v157 x
                match v740 with
                | US6_1(v908) -> (* Error *)
                    let v909 : unit = ()
                    let v910 : (unit -> unit) = closure31(v908)
                    let v911 : unit = (fun () -> v910 (); v909) ()
                    let v1024 : uint8 = 4uy
                    let v1025 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v1024)
                    let v1026 : string = "v1025.await"
                    let v1027 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1026 
                    let v1028 : (anyhow_Error -> std_string_String) = method42()
                    let v1029 : string = "$0.map_err(|x| $1(x))"
                    let v1030 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1027, v1028) v1029 
                    let v1031 : US6 = match v1030 with Ok x -> v156 x | Error x -> v157 x
                    match v1031 with
                    | US6_1(v1199) -> (* Error *)
                        let v1200 : unit = ()
                        let v1201 : (unit -> unit) = closure32(v1199)
                        let v1202 : unit = (fun () -> v1201 (); v1200) ()
                        let v1315 : uint8 = 5uy
                        let v1316 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v1315)
                        let v1317 : string = "v1316.await"
                        let v1318 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1317 
                        let v1319 : (anyhow_Error -> std_string_String) = method42()
                        let v1320 : string = "$0.map_err(|x| $1(x))"
                        let v1321 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1318, v1319) v1320 
                        let v1322 : US6 = match v1321 with Ok x -> v156 x | Error x -> v157 x
                        match v1322 with
                        | US6_1(v1490) -> (* Error *)
                            let v1491 : unit = ()
                            let v1492 : (unit -> unit) = closure33(v1490)
                            let v1493 : unit = (fun () -> v1492 (); v1491) ()
                            let v1606 : uint8 = 6uy
                            let v1607 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v1606)
                            let v1608 : string = "v1607.await"
                            let v1609 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1608 
                            let v1610 : (anyhow_Error -> std_string_String) = method42()
                            let v1611 : string = "$0.map_err(|x| $1(x))"
                            let v1612 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1609, v1610) v1611 
                            let v1613 : US6 = match v1612 with Ok x -> v156 x | Error x -> v157 x
                            match v1613 with
                            | US6_1(v1781) -> (* Error *)
                                let v1782 : unit = ()
                                let v1783 : (unit -> unit) = closure34(v1781)
                                let v1784 : unit = (fun () -> v1783 (); v1782) ()
                                let v1897 : uint8 = 7uy
                                let v1898 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v1897)
                                let v1899 : string = "v1898.await"
                                let v1900 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1899 
                                let v1901 : (anyhow_Error -> std_string_String) = method42()
                                let v1902 : string = "$0.map_err(|x| $1(x))"
                                let v1903 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1900, v1901) v1902 
                                let v1904 : US6 = match v1903 with Ok x -> v156 x | Error x -> v157 x
                                match v1904 with
                                | US6_1(v2072) -> (* Error *)
                                    let v2073 : unit = ()
                                    let v2074 : (unit -> unit) = closure35(v2072)
                                    let v2075 : unit = (fun () -> v2074 (); v2073) ()
                                    let v2188 : uint8 = 8uy
                                    let v2189 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v2188)
                                    let v2190 : string = "v2189.await"
                                    let v2191 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v2190 
                                    let v2192 : (anyhow_Error -> std_string_String) = method42()
                                    let v2193 : string = "$0.map_err(|x| $1(x))"
                                    let v2194 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2191, v2192) v2193 
                                    let v2195 : US6 = match v2194 with Ok x -> v156 x | Error x -> v157 x
                                    match v2195 with
                                    | US6_1(v2363) -> (* Error *)
                                        let v2364 : unit = ()
                                        let v2365 : (unit -> unit) = closure36(v2363)
                                        let v2366 : unit = (fun () -> v2365 (); v2364) ()
                                        let v2479 : uint8 = 9uy
                                        let v2480 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v2479)
                                        let v2481 : string = "v2480.await"
                                        let v2482 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v2481 
                                        let v2483 : (anyhow_Error -> std_string_String) = method42()
                                        let v2484 : string = "$0.map_err(|x| $1(x))"
                                        let v2485 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2482, v2483) v2484 
                                        let v2486 : US6 = match v2485 with Ok x -> v156 x | Error x -> v157 x
                                        match v2486 with
                                        | US6_1(v2654) -> (* Error *)
                                            let v2655 : unit = ()
                                            let v2656 : (unit -> unit) = closure37(v2654)
                                            let v2657 : unit = (fun () -> v2656 (); v2655) ()
                                            let v2770 : uint8 = 10uy
                                            let v2771 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v2770)
                                            let v2772 : string = "v2771.await"
                                            let v2773 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v2772 
                                            let v2774 : (anyhow_Error -> std_string_String) = method42()
                                            let v2775 : string = "$0.map_err(|x| $1(x))"
                                            let v2776 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2773, v2774) v2775 
                                            let v2777 : US6 = match v2776 with Ok x -> v156 x | Error x -> v157 x
                                            match v2777 with
                                            | US6_1(v2945) -> (* Error *)
                                                let v2946 : unit = ()
                                                let v2947 : (unit -> unit) = closure38(v2945)
                                                let v2948 : unit = (fun () -> v2947 (); v2946) ()
                                                let v3061 : uint8 = 11uy
                                                let v3062 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v3061)
                                                let v3063 : string = "v3062.await"
                                                let v3064 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3063 
                                                let v3065 : (anyhow_Error -> std_string_String) = method42()
                                                let v3066 : string = "$0.map_err(|x| $1(x))"
                                                let v3067 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3064, v3065) v3066 
                                                let v3068 : US6 = match v3067 with Ok x -> v156 x | Error x -> v157 x
                                                match v3068 with
                                                | US6_1(v3236) -> (* Error *)
                                                    let v3237 : unit = ()
                                                    let v3238 : (unit -> unit) = closure39(v3236)
                                                    let v3239 : unit = (fun () -> v3238 (); v3237) ()
                                                    let v3352 : uint8 = 12uy
                                                    let v3353 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v3352)
                                                    let v3354 : string = "v3353.await"
                                                    let v3355 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3354 
                                                    let v3356 : (anyhow_Error -> std_string_String) = method42()
                                                    let v3357 : string = "$0.map_err(|x| $1(x))"
                                                    let v3358 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3355, v3356) v3357 
                                                    let v3359 : US6 = match v3358 with Ok x -> v156 x | Error x -> v157 x
                                                    match v3359 with
                                                    | US6_1(v3527) -> (* Error *)
                                                        let v3528 : unit = ()
                                                        let v3529 : (unit -> unit) = closure40(v3527)
                                                        let v3530 : unit = (fun () -> v3529 (); v3528) ()
                                                        let v3643 : uint8 = 13uy
                                                        let v3644 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v3643)
                                                        let v3645 : string = "v3644.await"
                                                        let v3646 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3645 
                                                        let v3647 : (anyhow_Error -> std_string_String) = method42()
                                                        let v3648 : string = "$0.map_err(|x| $1(x))"
                                                        let v3649 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3646, v3647) v3648 
                                                        let v3650 : US6 = match v3649 with Ok x -> v156 x | Error x -> v157 x
                                                        match v3650 with
                                                        | US6_1(v3818) -> (* Error *)
                                                            let v3819 : unit = ()
                                                            let v3820 : (unit -> unit) = closure41(v3818)
                                                            let v3821 : unit = (fun () -> v3820 (); v3819) ()
                                                            let v3934 : uint8 = 14uy
                                                            let v3935 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v3934)
                                                            let v3936 : string = "v3935.await"
                                                            let v3937 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3936 
                                                            let v3938 : (anyhow_Error -> std_string_String) = method42()
                                                            let v3939 : string = "$0.map_err(|x| $1(x))"
                                                            let v3940 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3937, v3938) v3939 
                                                            let v3941 : US6 = match v3940 with Ok x -> v156 x | Error x -> v157 x
                                                            match v3941 with
                                                            | US6_1(v4109) -> (* Error *)
                                                                let v4110 : unit = ()
                                                                let v4111 : (unit -> unit) = closure42(v4109)
                                                                let v4112 : unit = (fun () -> v4111 (); v4110) ()
                                                                let v4225 : uint8 = 15uy
                                                                let v4226 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v4225)
                                                                let v4227 : string = "v4226.await"
                                                                let v4228 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v4227 
                                                                let v4229 : (anyhow_Error -> std_string_String) = method42()
                                                                let v4230 : string = "$0.map_err(|x| $1(x))"
                                                                let v4231 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4228, v4229) v4230 
                                                                let v4232 : US6 = match v4231 with Ok x -> v156 x | Error x -> v157 x
                                                                match v4232 with
                                                                | US6_1(v4400) -> (* Error *)
                                                                    let v4401 : unit = ()
                                                                    let v4402 : (unit -> unit) = closure43(v4400)
                                                                    let v4403 : unit = (fun () -> v4402 (); v4401) ()
                                                                    let v4516 : uint8 = 16uy
                                                                    let v4517 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v4516)
                                                                    let v4518 : string = "v4517.await"
                                                                    let v4519 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v4518 
                                                                    let v4520 : (anyhow_Error -> std_string_String) = method42()
                                                                    let v4521 : string = "$0.map_err(|x| $1(x))"
                                                                    let v4522 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4519, v4520) v4521 
                                                                    let v4523 : US6 = match v4522 with Ok x -> v156 x | Error x -> v157 x
                                                                    match v4523 with
                                                                    | US6_1(v4691) -> (* Error *)
                                                                        let v4692 : unit = ()
                                                                        let v4693 : (unit -> unit) = closure44(v4691)
                                                                        let v4694 : unit = (fun () -> v4693 (); v4692) ()
                                                                        let v4807 : uint8 = 17uy
                                                                        let v4808 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v4807)
                                                                        let v4809 : string = "v4808.await"
                                                                        let v4810 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v4809 
                                                                        let v4811 : (anyhow_Error -> std_string_String) = method42()
                                                                        let v4812 : string = "$0.map_err(|x| $1(x))"
                                                                        let v4813 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4810, v4811) v4812 
                                                                        let v4814 : US6 = match v4813 with Ok x -> v156 x | Error x -> v157 x
                                                                        match v4814 with
                                                                        | US6_1(v4982) -> (* Error *)
                                                                            let v4983 : unit = ()
                                                                            let v4984 : (unit -> unit) = closure45(v4982)
                                                                            let v4985 : unit = (fun () -> v4984 (); v4983) ()
                                                                            let v5098 : uint8 = 18uy
                                                                            let v5099 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v5098)
                                                                            let v5100 : string = "v5099.await"
                                                                            let v5101 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5100 
                                                                            let v5102 : (anyhow_Error -> std_string_String) = method42()
                                                                            let v5103 : string = "$0.map_err(|x| $1(x))"
                                                                            let v5104 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5101, v5102) v5103 
                                                                            let v5105 : US6 = match v5104 with Ok x -> v156 x | Error x -> v157 x
                                                                            match v5105 with
                                                                            | US6_1(v5273) -> (* Error *)
                                                                                let v5274 : unit = ()
                                                                                let v5275 : (unit -> unit) = closure46(v5273)
                                                                                let v5276 : unit = (fun () -> v5275 (); v5274) ()
                                                                                let v5389 : uint8 = 19uy
                                                                                let v5390 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v5389)
                                                                                let v5391 : string = "v5390.await"
                                                                                let v5392 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5391 
                                                                                let v5393 : (anyhow_Error -> std_string_String) = method42()
                                                                                let v5394 : string = "$0.map_err(|x| $1(x))"
                                                                                let v5395 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5392, v5393) v5394 
                                                                                let v5396 : US6 = match v5395 with Ok x -> v156 x | Error x -> v157 x
                                                                                match v5396 with
                                                                                | US6_1(v5564) -> (* Error *)
                                                                                    let v5565 : unit = ()
                                                                                    let v5566 : (unit -> unit) = closure47(v5564)
                                                                                    let v5567 : unit = (fun () -> v5566 (); v5565) ()
                                                                                    let v5680 : uint8 = 20uy
                                                                                    let v5681 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v5680)
                                                                                    let v5682 : string = "v5681.await"
                                                                                    let v5683 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5682 
                                                                                    let v5684 : (anyhow_Error -> std_string_String) = method42()
                                                                                    let v5685 : string = "$0.map_err(|x| $1(x))"
                                                                                    let v5686 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5683, v5684) v5685 
                                                                                    let v5687 : US6 = match v5686 with Ok x -> v156 x | Error x -> v157 x
                                                                                    match v5687 with
                                                                                    | US6_1(v5855) -> (* Error *)
                                                                                        let v5856 : unit = ()
                                                                                        let v5857 : (unit -> unit) = closure48(v5855)
                                                                                        let v5858 : unit = (fun () -> v5857 (); v5856) ()
                                                                                        let v5971 : uint8 = 21uy
                                                                                        let v5972 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v5971)
                                                                                        let v5973 : string = "v5972.await"
                                                                                        let v5974 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5973 
                                                                                        let v5975 : (anyhow_Error -> std_string_String) = method42()
                                                                                        let v5976 : string = "$0.map_err(|x| $1(x))"
                                                                                        let v5977 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5974, v5975) v5976 
                                                                                        let v5978 : US6 = match v5977 with Ok x -> v156 x | Error x -> v157 x
                                                                                        match v5978 with
                                                                                        | US6_1(v6146) -> (* Error *)
                                                                                            let v6147 : unit = ()
                                                                                            let v6148 : (unit -> unit) = closure49(v6146)
                                                                                            let v6149 : unit = (fun () -> v6148 (); v6147) ()
                                                                                            let v6262 : uint8 = 22uy
                                                                                            let v6263 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v6262)
                                                                                            let v6264 : string = "v6263.await"
                                                                                            let v6265 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6264 
                                                                                            let v6266 : (anyhow_Error -> std_string_String) = method42()
                                                                                            let v6267 : string = "$0.map_err(|x| $1(x))"
                                                                                            let v6268 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6265, v6266) v6267 
                                                                                            let v6269 : US6 = match v6268 with Ok x -> v156 x | Error x -> v157 x
                                                                                            match v6269 with
                                                                                            | US6_1(v6437) -> (* Error *)
                                                                                                let v6438 : unit = ()
                                                                                                let v6439 : (unit -> unit) = closure50(v6437)
                                                                                                let v6440 : unit = (fun () -> v6439 (); v6438) ()
                                                                                                let v6553 : uint8 = 23uy
                                                                                                let v6554 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v6553)
                                                                                                let v6555 : string = "v6554.await"
                                                                                                let v6556 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6555 
                                                                                                let v6557 : (anyhow_Error -> std_string_String) = method42()
                                                                                                let v6558 : string = "$0.map_err(|x| $1(x))"
                                                                                                let v6559 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6556, v6557) v6558 
                                                                                                let v6560 : US6 = match v6559 with Ok x -> v156 x | Error x -> v157 x
                                                                                                match v6560 with
                                                                                                | US6_1(v6728) -> (* Error *)
                                                                                                    let v6729 : unit = ()
                                                                                                    let v6730 : (unit -> unit) = closure51(v6728)
                                                                                                    let v6731 : unit = (fun () -> v6730 (); v6729) ()
                                                                                                    let v6844 : uint8 = 24uy
                                                                                                    let v6845 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v6844)
                                                                                                    let v6846 : string = "v6845.await"
                                                                                                    let v6847 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6846 
                                                                                                    let v6848 : (anyhow_Error -> std_string_String) = method42()
                                                                                                    let v6849 : string = "$0.map_err(|x| $1(x))"
                                                                                                    let v6850 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6847, v6848) v6849 
                                                                                                    let v6851 : US6 = match v6850 with Ok x -> v156 x | Error x -> v157 x
                                                                                                    match v6851 with
                                                                                                    | US6_1(v7019) -> (* Error *)
                                                                                                        let v7020 : unit = ()
                                                                                                        let v7021 : (unit -> unit) = closure52(v7019)
                                                                                                        let v7022 : unit = (fun () -> v7021 (); v7020) ()
                                                                                                        let v7135 : uint8 = 25uy
                                                                                                        let v7136 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v7135)
                                                                                                        let v7137 : string = "v7136.await"
                                                                                                        let v7138 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7137 
                                                                                                        let v7139 : (anyhow_Error -> std_string_String) = method42()
                                                                                                        let v7140 : string = "$0.map_err(|x| $1(x))"
                                                                                                        let v7141 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7138, v7139) v7140 
                                                                                                        let v7142 : US6 = match v7141 with Ok x -> v156 x | Error x -> v157 x
                                                                                                        match v7142 with
                                                                                                        | US6_1(v7310) -> (* Error *)
                                                                                                            let v7311 : unit = ()
                                                                                                            let v7312 : (unit -> unit) = closure53(v7310)
                                                                                                            let v7313 : unit = (fun () -> v7312 (); v7311) ()
                                                                                                            let v7426 : uint8 = 26uy
                                                                                                            let v7427 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v7426)
                                                                                                            let v7428 : string = "v7427.await"
                                                                                                            let v7429 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7428 
                                                                                                            let v7430 : (anyhow_Error -> std_string_String) = method42()
                                                                                                            let v7431 : string = "$0.map_err(|x| $1(x))"
                                                                                                            let v7432 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7429, v7430) v7431 
                                                                                                            let v7433 : US6 = match v7432 with Ok x -> v156 x | Error x -> v157 x
                                                                                                            match v7433 with
                                                                                                            | US6_1(v7601) -> (* Error *)
                                                                                                                let v7602 : unit = ()
                                                                                                                let v7603 : (unit -> unit) = closure54(v7601)
                                                                                                                let v7604 : unit = (fun () -> v7603 (); v7602) ()
                                                                                                                let v7717 : uint8 = 27uy
                                                                                                                let v7718 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v7717)
                                                                                                                let v7719 : string = "v7718.await"
                                                                                                                let v7720 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7719 
                                                                                                                let v7721 : (anyhow_Error -> std_string_String) = method42()
                                                                                                                let v7722 : string = "$0.map_err(|x| $1(x))"
                                                                                                                let v7723 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7720, v7721) v7722 
                                                                                                                let v7724 : US6 = match v7723 with Ok x -> v156 x | Error x -> v157 x
                                                                                                                match v7724 with
                                                                                                                | US6_1(v7892) -> (* Error *)
                                                                                                                    let v7893 : unit = ()
                                                                                                                    let v7894 : (unit -> unit) = closure55(v7892)
                                                                                                                    let v7895 : unit = (fun () -> v7894 (); v7893) ()
                                                                                                                    let v8008 : uint8 = 28uy
                                                                                                                    let v8009 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v8008)
                                                                                                                    let v8010 : string = "v8009.await"
                                                                                                                    let v8011 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v8010 
                                                                                                                    let v8012 : (anyhow_Error -> std_string_String) = method42()
                                                                                                                    let v8013 : string = "$0.map_err(|x| $1(x))"
                                                                                                                    let v8014 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8011, v8012) v8013 
                                                                                                                    let v8015 : US6 = match v8014 with Ok x -> v156 x | Error x -> v157 x
                                                                                                                    match v8015 with
                                                                                                                    | US6_1(v8183) -> (* Error *)
                                                                                                                        let v8184 : unit = ()
                                                                                                                        let v8185 : (unit -> unit) = closure56(v8183)
                                                                                                                        let v8186 : unit = (fun () -> v8185 (); v8184) ()
                                                                                                                        let v8299 : uint8 = 29uy
                                                                                                                        let v8300 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v148, v8299)
                                                                                                                        let v8301 : string = "v8300.await"
                                                                                                                        let v8302 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v8301 
                                                                                                                        let v8303 : (anyhow_Error -> std_string_String) = method42()
                                                                                                                        let v8304 : string = "$0.map_err(|x| $1(x))"
                                                                                                                        let v8305 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8302, v8303) v8304 
                                                                                                                        let v8306 : US6 = match v8305 with Ok x -> v156 x | Error x -> v157 x
                                                                                                                        match v8306 with
                                                                                                                        | US6_1(v8474) -> (* Error *)
                                                                                                                            let v8475 : unit = ()
                                                                                                                            let v8476 : (unit -> unit) = closure57(v8474)
                                                                                                                            let v8477 : unit = (fun () -> v8476 (); v8475) ()
                                                                                                                            let v8590 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8591 : bool = Fable.Core.RustInterop.emitRustExpr () v8590 
                                                                                                                            let v8592 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8593 : bool = Fable.Core.RustInterop.emitRustExpr () v8592 
                                                                                                                            let v8594 : uint8 = method46()
                                                                                                                            let v8595 : string = ""
                                                                                                                            let v8596 : string = "}"
                                                                                                                            let v8597 : string = v8595 + v8596 
                                                                                                                            let v8598 : string = "true; v8594 " + v8597 + "); " + v8595 + " // rust.fix_closure'"
                                                                                                                            let v8599 : bool = Fable.Core.RustInterop.emitRustExpr () v8598 
                                                                                                                            let v8600 : string = "__future_init"
                                                                                                                            let v8601 : _ = Fable.Core.RustInterop.emitRustExpr () v8600 
                                                                                                                            let v8602 : string = "v8601"
                                                                                                                            let v8603 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8602 
                                                                                                                            let v8604 : string = "v8603.await"
                                                                                                                            let v8605 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8604 
                                                                                                                            let v8606 : US7 = method47(v8605)
                                                                                                                            let v8607 : string = v8595 + v8596 
                                                                                                                            let v8608 : string = "true; v8606 " + v8607 + "); " + v8595 + " // rust.fix_closure'"
                                                                                                                            let v8609 : bool = Fable.Core.RustInterop.emitRustExpr () v8608 
                                                                                                                            let v8610 : string = "__future_init"
                                                                                                                            let v8611 : _ = Fable.Core.RustInterop.emitRustExpr () v8610 
                                                                                                                            let v8612 : string = "v8611"
                                                                                                                            let v8613 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8612 
                                                                                                                            v8613
                                                                                                                        | US6_0(v8307) -> (* Ok *)
                                                                                                                            match v8307 with
                                                                                                                            | US4_1 -> (* None *)
                                                                                                                                let v8308 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8309 : bool = Fable.Core.RustInterop.emitRustExpr () v8308 
                                                                                                                                let v8310 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8311 : bool = Fable.Core.RustInterop.emitRustExpr () v8310 
                                                                                                                                let v8312 : uint8 = method48()
                                                                                                                                let v8313 : string = ""
                                                                                                                                let v8314 : string = "}"
                                                                                                                                let v8315 : string = v8313 + v8314 
                                                                                                                                let v8316 : string = "true; v8312 " + v8315 + "); " + v8313 + " // rust.fix_closure'"
                                                                                                                                let v8317 : bool = Fable.Core.RustInterop.emitRustExpr () v8316 
                                                                                                                                let v8318 : string = "__future_init"
                                                                                                                                let v8319 : _ = Fable.Core.RustInterop.emitRustExpr () v8318 
                                                                                                                                let v8320 : string = "v8319"
                                                                                                                                let v8321 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8320 
                                                                                                                                let v8322 : string = "v8321.await"
                                                                                                                                let v8323 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8322 
                                                                                                                                let v8324 : US7 = method49(v8323)
                                                                                                                                let v8325 : string = v8313 + v8314 
                                                                                                                                let v8326 : string = "true; v8324 " + v8325 + "); " + v8313 + " // rust.fix_closure'"
                                                                                                                                let v8327 : bool = Fable.Core.RustInterop.emitRustExpr () v8326 
                                                                                                                                let v8328 : string = "__future_init"
                                                                                                                                let v8329 : _ = Fable.Core.RustInterop.emitRustExpr () v8328 
                                                                                                                                let v8330 : string = "v8329"
                                                                                                                                let v8331 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8330 
                                                                                                                                v8331
                                                                                                                            | US4_0(v8332) -> (* Some *)
                                                                                                                                let v8333 : unit = ()
                                                                                                                                let v8334 : (unit -> unit) = closure58(v8332)
                                                                                                                                let v8335 : unit = (fun () -> v8334 (); v8333) ()
                                                                                                                                let v8448 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8449 : bool = Fable.Core.RustInterop.emitRustExpr () v8448 
                                                                                                                                let v8450 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8451 : bool = Fable.Core.RustInterop.emitRustExpr () v8450 
                                                                                                                                let v8452 : uint8 = method48()
                                                                                                                                let v8453 : string = ""
                                                                                                                                let v8454 : string = "}"
                                                                                                                                let v8455 : string = v8453 + v8454 
                                                                                                                                let v8456 : string = "true; v8452 " + v8455 + "); " + v8453 + " // rust.fix_closure'"
                                                                                                                                let v8457 : bool = Fable.Core.RustInterop.emitRustExpr () v8456 
                                                                                                                                let v8458 : string = "__future_init"
                                                                                                                                let v8459 : _ = Fable.Core.RustInterop.emitRustExpr () v8458 
                                                                                                                                let v8460 : string = "v8459"
                                                                                                                                let v8461 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8460 
                                                                                                                                let v8462 : string = "v8461.await"
                                                                                                                                let v8463 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8462 
                                                                                                                                let v8464 : US7 = method47(v8463)
                                                                                                                                let v8465 : string = v8453 + v8454 
                                                                                                                                let v8466 : string = "true; v8464 " + v8465 + "); " + v8453 + " // rust.fix_closure'"
                                                                                                                                let v8467 : bool = Fable.Core.RustInterop.emitRustExpr () v8466 
                                                                                                                                let v8468 : string = "__future_init"
                                                                                                                                let v8469 : _ = Fable.Core.RustInterop.emitRustExpr () v8468 
                                                                                                                                let v8470 : string = "v8469"
                                                                                                                                let v8471 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8470 
                                                                                                                                v8471
                                                                                                                    | US6_0(v8016) -> (* Ok *)
                                                                                                                        match v8016 with
                                                                                                                        | US4_1 -> (* None *)
                                                                                                                            let v8017 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8018 : bool = Fable.Core.RustInterop.emitRustExpr () v8017 
                                                                                                                            let v8019 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8020 : bool = Fable.Core.RustInterop.emitRustExpr () v8019 
                                                                                                                            let v8021 : uint8 = method53()
                                                                                                                            let v8022 : string = ""
                                                                                                                            let v8023 : string = "}"
                                                                                                                            let v8024 : string = v8022 + v8023 
                                                                                                                            let v8025 : string = "true; v8021 " + v8024 + "); " + v8022 + " // rust.fix_closure'"
                                                                                                                            let v8026 : bool = Fable.Core.RustInterop.emitRustExpr () v8025 
                                                                                                                            let v8027 : string = "__future_init"
                                                                                                                            let v8028 : _ = Fable.Core.RustInterop.emitRustExpr () v8027 
                                                                                                                            let v8029 : string = "v8028"
                                                                                                                            let v8030 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8029 
                                                                                                                            let v8031 : string = "v8030.await"
                                                                                                                            let v8032 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8031 
                                                                                                                            let v8033 : US7 = method49(v8032)
                                                                                                                            let v8034 : string = v8022 + v8023 
                                                                                                                            let v8035 : string = "true; v8033 " + v8034 + "); " + v8022 + " // rust.fix_closure'"
                                                                                                                            let v8036 : bool = Fable.Core.RustInterop.emitRustExpr () v8035 
                                                                                                                            let v8037 : string = "__future_init"
                                                                                                                            let v8038 : _ = Fable.Core.RustInterop.emitRustExpr () v8037 
                                                                                                                            let v8039 : string = "v8038"
                                                                                                                            let v8040 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8039 
                                                                                                                            v8040
                                                                                                                        | US4_0(v8041) -> (* Some *)
                                                                                                                            let v8042 : unit = ()
                                                                                                                            let v8043 : (unit -> unit) = closure59(v8041)
                                                                                                                            let v8044 : unit = (fun () -> v8043 (); v8042) ()
                                                                                                                            let v8157 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8158 : bool = Fable.Core.RustInterop.emitRustExpr () v8157 
                                                                                                                            let v8159 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8160 : bool = Fable.Core.RustInterop.emitRustExpr () v8159 
                                                                                                                            let v8161 : uint8 = method53()
                                                                                                                            let v8162 : string = ""
                                                                                                                            let v8163 : string = "}"
                                                                                                                            let v8164 : string = v8162 + v8163 
                                                                                                                            let v8165 : string = "true; v8161 " + v8164 + "); " + v8162 + " // rust.fix_closure'"
                                                                                                                            let v8166 : bool = Fable.Core.RustInterop.emitRustExpr () v8165 
                                                                                                                            let v8167 : string = "__future_init"
                                                                                                                            let v8168 : _ = Fable.Core.RustInterop.emitRustExpr () v8167 
                                                                                                                            let v8169 : string = "v8168"
                                                                                                                            let v8170 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8169 
                                                                                                                            let v8171 : string = "v8170.await"
                                                                                                                            let v8172 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8171 
                                                                                                                            let v8173 : US7 = method47(v8172)
                                                                                                                            let v8174 : string = v8162 + v8163 
                                                                                                                            let v8175 : string = "true; v8173 " + v8174 + "); " + v8162 + " // rust.fix_closure'"
                                                                                                                            let v8176 : bool = Fable.Core.RustInterop.emitRustExpr () v8175 
                                                                                                                            let v8177 : string = "__future_init"
                                                                                                                            let v8178 : _ = Fable.Core.RustInterop.emitRustExpr () v8177 
                                                                                                                            let v8179 : string = "v8178"
                                                                                                                            let v8180 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8179 
                                                                                                                            v8180
                                                                                                                | US6_0(v7725) -> (* Ok *)
                                                                                                                    match v7725 with
                                                                                                                    | US4_1 -> (* None *)
                                                                                                                        let v7726 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v7727 : bool = Fable.Core.RustInterop.emitRustExpr () v7726 
                                                                                                                        let v7728 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v7729 : bool = Fable.Core.RustInterop.emitRustExpr () v7728 
                                                                                                                        let v7730 : uint8 = method54()
                                                                                                                        let v7731 : string = ""
                                                                                                                        let v7732 : string = "}"
                                                                                                                        let v7733 : string = v7731 + v7732 
                                                                                                                        let v7734 : string = "true; v7730 " + v7733 + "); " + v7731 + " // rust.fix_closure'"
                                                                                                                        let v7735 : bool = Fable.Core.RustInterop.emitRustExpr () v7734 
                                                                                                                        let v7736 : string = "__future_init"
                                                                                                                        let v7737 : _ = Fable.Core.RustInterop.emitRustExpr () v7736 
                                                                                                                        let v7738 : string = "v7737"
                                                                                                                        let v7739 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7738 
                                                                                                                        let v7740 : string = "v7739.await"
                                                                                                                        let v7741 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7740 
                                                                                                                        let v7742 : US7 = method49(v7741)
                                                                                                                        let v7743 : string = v7731 + v7732 
                                                                                                                        let v7744 : string = "true; v7742 " + v7743 + "); " + v7731 + " // rust.fix_closure'"
                                                                                                                        let v7745 : bool = Fable.Core.RustInterop.emitRustExpr () v7744 
                                                                                                                        let v7746 : string = "__future_init"
                                                                                                                        let v7747 : _ = Fable.Core.RustInterop.emitRustExpr () v7746 
                                                                                                                        let v7748 : string = "v7747"
                                                                                                                        let v7749 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7748 
                                                                                                                        v7749
                                                                                                                    | US4_0(v7750) -> (* Some *)
                                                                                                                        let v7751 : unit = ()
                                                                                                                        let v7752 : (unit -> unit) = closure60(v7750)
                                                                                                                        let v7753 : unit = (fun () -> v7752 (); v7751) ()
                                                                                                                        let v7866 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v7867 : bool = Fable.Core.RustInterop.emitRustExpr () v7866 
                                                                                                                        let v7868 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v7869 : bool = Fable.Core.RustInterop.emitRustExpr () v7868 
                                                                                                                        let v7870 : uint8 = method54()
                                                                                                                        let v7871 : string = ""
                                                                                                                        let v7872 : string = "}"
                                                                                                                        let v7873 : string = v7871 + v7872 
                                                                                                                        let v7874 : string = "true; v7870 " + v7873 + "); " + v7871 + " // rust.fix_closure'"
                                                                                                                        let v7875 : bool = Fable.Core.RustInterop.emitRustExpr () v7874 
                                                                                                                        let v7876 : string = "__future_init"
                                                                                                                        let v7877 : _ = Fable.Core.RustInterop.emitRustExpr () v7876 
                                                                                                                        let v7878 : string = "v7877"
                                                                                                                        let v7879 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7878 
                                                                                                                        let v7880 : string = "v7879.await"
                                                                                                                        let v7881 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7880 
                                                                                                                        let v7882 : US7 = method47(v7881)
                                                                                                                        let v7883 : string = v7871 + v7872 
                                                                                                                        let v7884 : string = "true; v7882 " + v7883 + "); " + v7871 + " // rust.fix_closure'"
                                                                                                                        let v7885 : bool = Fable.Core.RustInterop.emitRustExpr () v7884 
                                                                                                                        let v7886 : string = "__future_init"
                                                                                                                        let v7887 : _ = Fable.Core.RustInterop.emitRustExpr () v7886 
                                                                                                                        let v7888 : string = "v7887"
                                                                                                                        let v7889 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7888 
                                                                                                                        v7889
                                                                                                            | US6_0(v7434) -> (* Ok *)
                                                                                                                match v7434 with
                                                                                                                | US4_1 -> (* None *)
                                                                                                                    let v7435 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7436 : bool = Fable.Core.RustInterop.emitRustExpr () v7435 
                                                                                                                    let v7437 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7438 : bool = Fable.Core.RustInterop.emitRustExpr () v7437 
                                                                                                                    let v7439 : uint8 = method55()
                                                                                                                    let v7440 : string = ""
                                                                                                                    let v7441 : string = "}"
                                                                                                                    let v7442 : string = v7440 + v7441 
                                                                                                                    let v7443 : string = "true; v7439 " + v7442 + "); " + v7440 + " // rust.fix_closure'"
                                                                                                                    let v7444 : bool = Fable.Core.RustInterop.emitRustExpr () v7443 
                                                                                                                    let v7445 : string = "__future_init"
                                                                                                                    let v7446 : _ = Fable.Core.RustInterop.emitRustExpr () v7445 
                                                                                                                    let v7447 : string = "v7446"
                                                                                                                    let v7448 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7447 
                                                                                                                    let v7449 : string = "v7448.await"
                                                                                                                    let v7450 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7449 
                                                                                                                    let v7451 : US7 = method49(v7450)
                                                                                                                    let v7452 : string = v7440 + v7441 
                                                                                                                    let v7453 : string = "true; v7451 " + v7452 + "); " + v7440 + " // rust.fix_closure'"
                                                                                                                    let v7454 : bool = Fable.Core.RustInterop.emitRustExpr () v7453 
                                                                                                                    let v7455 : string = "__future_init"
                                                                                                                    let v7456 : _ = Fable.Core.RustInterop.emitRustExpr () v7455 
                                                                                                                    let v7457 : string = "v7456"
                                                                                                                    let v7458 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7457 
                                                                                                                    v7458
                                                                                                                | US4_0(v7459) -> (* Some *)
                                                                                                                    let v7460 : unit = ()
                                                                                                                    let v7461 : (unit -> unit) = closure61(v7459)
                                                                                                                    let v7462 : unit = (fun () -> v7461 (); v7460) ()
                                                                                                                    let v7575 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7576 : bool = Fable.Core.RustInterop.emitRustExpr () v7575 
                                                                                                                    let v7577 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7578 : bool = Fable.Core.RustInterop.emitRustExpr () v7577 
                                                                                                                    let v7579 : uint8 = method55()
                                                                                                                    let v7580 : string = ""
                                                                                                                    let v7581 : string = "}"
                                                                                                                    let v7582 : string = v7580 + v7581 
                                                                                                                    let v7583 : string = "true; v7579 " + v7582 + "); " + v7580 + " // rust.fix_closure'"
                                                                                                                    let v7584 : bool = Fable.Core.RustInterop.emitRustExpr () v7583 
                                                                                                                    let v7585 : string = "__future_init"
                                                                                                                    let v7586 : _ = Fable.Core.RustInterop.emitRustExpr () v7585 
                                                                                                                    let v7587 : string = "v7586"
                                                                                                                    let v7588 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7587 
                                                                                                                    let v7589 : string = "v7588.await"
                                                                                                                    let v7590 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7589 
                                                                                                                    let v7591 : US7 = method47(v7590)
                                                                                                                    let v7592 : string = v7580 + v7581 
                                                                                                                    let v7593 : string = "true; v7591 " + v7592 + "); " + v7580 + " // rust.fix_closure'"
                                                                                                                    let v7594 : bool = Fable.Core.RustInterop.emitRustExpr () v7593 
                                                                                                                    let v7595 : string = "__future_init"
                                                                                                                    let v7596 : _ = Fable.Core.RustInterop.emitRustExpr () v7595 
                                                                                                                    let v7597 : string = "v7596"
                                                                                                                    let v7598 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7597 
                                                                                                                    v7598
                                                                                                        | US6_0(v7143) -> (* Ok *)
                                                                                                            match v7143 with
                                                                                                            | US4_1 -> (* None *)
                                                                                                                let v7144 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7145 : bool = Fable.Core.RustInterop.emitRustExpr () v7144 
                                                                                                                let v7146 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7147 : bool = Fable.Core.RustInterop.emitRustExpr () v7146 
                                                                                                                let v7148 : uint8 = method56()
                                                                                                                let v7149 : string = ""
                                                                                                                let v7150 : string = "}"
                                                                                                                let v7151 : string = v7149 + v7150 
                                                                                                                let v7152 : string = "true; v7148 " + v7151 + "); " + v7149 + " // rust.fix_closure'"
                                                                                                                let v7153 : bool = Fable.Core.RustInterop.emitRustExpr () v7152 
                                                                                                                let v7154 : string = "__future_init"
                                                                                                                let v7155 : _ = Fable.Core.RustInterop.emitRustExpr () v7154 
                                                                                                                let v7156 : string = "v7155"
                                                                                                                let v7157 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7156 
                                                                                                                let v7158 : string = "v7157.await"
                                                                                                                let v7159 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7158 
                                                                                                                let v7160 : US7 = method49(v7159)
                                                                                                                let v7161 : string = v7149 + v7150 
                                                                                                                let v7162 : string = "true; v7160 " + v7161 + "); " + v7149 + " // rust.fix_closure'"
                                                                                                                let v7163 : bool = Fable.Core.RustInterop.emitRustExpr () v7162 
                                                                                                                let v7164 : string = "__future_init"
                                                                                                                let v7165 : _ = Fable.Core.RustInterop.emitRustExpr () v7164 
                                                                                                                let v7166 : string = "v7165"
                                                                                                                let v7167 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7166 
                                                                                                                v7167
                                                                                                            | US4_0(v7168) -> (* Some *)
                                                                                                                let v7169 : unit = ()
                                                                                                                let v7170 : (unit -> unit) = closure62(v7168)
                                                                                                                let v7171 : unit = (fun () -> v7170 (); v7169) ()
                                                                                                                let v7284 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7285 : bool = Fable.Core.RustInterop.emitRustExpr () v7284 
                                                                                                                let v7286 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7287 : bool = Fable.Core.RustInterop.emitRustExpr () v7286 
                                                                                                                let v7288 : uint8 = method56()
                                                                                                                let v7289 : string = ""
                                                                                                                let v7290 : string = "}"
                                                                                                                let v7291 : string = v7289 + v7290 
                                                                                                                let v7292 : string = "true; v7288 " + v7291 + "); " + v7289 + " // rust.fix_closure'"
                                                                                                                let v7293 : bool = Fable.Core.RustInterop.emitRustExpr () v7292 
                                                                                                                let v7294 : string = "__future_init"
                                                                                                                let v7295 : _ = Fable.Core.RustInterop.emitRustExpr () v7294 
                                                                                                                let v7296 : string = "v7295"
                                                                                                                let v7297 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7296 
                                                                                                                let v7298 : string = "v7297.await"
                                                                                                                let v7299 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7298 
                                                                                                                let v7300 : US7 = method47(v7299)
                                                                                                                let v7301 : string = v7289 + v7290 
                                                                                                                let v7302 : string = "true; v7300 " + v7301 + "); " + v7289 + " // rust.fix_closure'"
                                                                                                                let v7303 : bool = Fable.Core.RustInterop.emitRustExpr () v7302 
                                                                                                                let v7304 : string = "__future_init"
                                                                                                                let v7305 : _ = Fable.Core.RustInterop.emitRustExpr () v7304 
                                                                                                                let v7306 : string = "v7305"
                                                                                                                let v7307 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7306 
                                                                                                                v7307
                                                                                                    | US6_0(v6852) -> (* Ok *)
                                                                                                        match v6852 with
                                                                                                        | US4_1 -> (* None *)
                                                                                                            let v6853 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v6854 : bool = Fable.Core.RustInterop.emitRustExpr () v6853 
                                                                                                            let v6855 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v6856 : bool = Fable.Core.RustInterop.emitRustExpr () v6855 
                                                                                                            let v6857 : uint8 = method57()
                                                                                                            let v6858 : string = ""
                                                                                                            let v6859 : string = "}"
                                                                                                            let v6860 : string = v6858 + v6859 
                                                                                                            let v6861 : string = "true; v6857 " + v6860 + "); " + v6858 + " // rust.fix_closure'"
                                                                                                            let v6862 : bool = Fable.Core.RustInterop.emitRustExpr () v6861 
                                                                                                            let v6863 : string = "__future_init"
                                                                                                            let v6864 : _ = Fable.Core.RustInterop.emitRustExpr () v6863 
                                                                                                            let v6865 : string = "v6864"
                                                                                                            let v6866 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6865 
                                                                                                            let v6867 : string = "v6866.await"
                                                                                                            let v6868 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6867 
                                                                                                            let v6869 : US7 = method49(v6868)
                                                                                                            let v6870 : string = v6858 + v6859 
                                                                                                            let v6871 : string = "true; v6869 " + v6870 + "); " + v6858 + " // rust.fix_closure'"
                                                                                                            let v6872 : bool = Fable.Core.RustInterop.emitRustExpr () v6871 
                                                                                                            let v6873 : string = "__future_init"
                                                                                                            let v6874 : _ = Fable.Core.RustInterop.emitRustExpr () v6873 
                                                                                                            let v6875 : string = "v6874"
                                                                                                            let v6876 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6875 
                                                                                                            v6876
                                                                                                        | US4_0(v6877) -> (* Some *)
                                                                                                            let v6878 : unit = ()
                                                                                                            let v6879 : (unit -> unit) = closure63(v6877)
                                                                                                            let v6880 : unit = (fun () -> v6879 (); v6878) ()
                                                                                                            let v6993 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v6994 : bool = Fable.Core.RustInterop.emitRustExpr () v6993 
                                                                                                            let v6995 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v6996 : bool = Fable.Core.RustInterop.emitRustExpr () v6995 
                                                                                                            let v6997 : uint8 = method57()
                                                                                                            let v6998 : string = ""
                                                                                                            let v6999 : string = "}"
                                                                                                            let v7000 : string = v6998 + v6999 
                                                                                                            let v7001 : string = "true; v6997 " + v7000 + "); " + v6998 + " // rust.fix_closure'"
                                                                                                            let v7002 : bool = Fable.Core.RustInterop.emitRustExpr () v7001 
                                                                                                            let v7003 : string = "__future_init"
                                                                                                            let v7004 : _ = Fable.Core.RustInterop.emitRustExpr () v7003 
                                                                                                            let v7005 : string = "v7004"
                                                                                                            let v7006 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7005 
                                                                                                            let v7007 : string = "v7006.await"
                                                                                                            let v7008 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7007 
                                                                                                            let v7009 : US7 = method47(v7008)
                                                                                                            let v7010 : string = v6998 + v6999 
                                                                                                            let v7011 : string = "true; v7009 " + v7010 + "); " + v6998 + " // rust.fix_closure'"
                                                                                                            let v7012 : bool = Fable.Core.RustInterop.emitRustExpr () v7011 
                                                                                                            let v7013 : string = "__future_init"
                                                                                                            let v7014 : _ = Fable.Core.RustInterop.emitRustExpr () v7013 
                                                                                                            let v7015 : string = "v7014"
                                                                                                            let v7016 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7015 
                                                                                                            v7016
                                                                                                | US6_0(v6561) -> (* Ok *)
                                                                                                    match v6561 with
                                                                                                    | US4_1 -> (* None *)
                                                                                                        let v6562 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6563 : bool = Fable.Core.RustInterop.emitRustExpr () v6562 
                                                                                                        let v6564 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6565 : bool = Fable.Core.RustInterop.emitRustExpr () v6564 
                                                                                                        let v6566 : uint8 = method58()
                                                                                                        let v6567 : string = ""
                                                                                                        let v6568 : string = "}"
                                                                                                        let v6569 : string = v6567 + v6568 
                                                                                                        let v6570 : string = "true; v6566 " + v6569 + "); " + v6567 + " // rust.fix_closure'"
                                                                                                        let v6571 : bool = Fable.Core.RustInterop.emitRustExpr () v6570 
                                                                                                        let v6572 : string = "__future_init"
                                                                                                        let v6573 : _ = Fable.Core.RustInterop.emitRustExpr () v6572 
                                                                                                        let v6574 : string = "v6573"
                                                                                                        let v6575 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6574 
                                                                                                        let v6576 : string = "v6575.await"
                                                                                                        let v6577 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6576 
                                                                                                        let v6578 : US7 = method49(v6577)
                                                                                                        let v6579 : string = v6567 + v6568 
                                                                                                        let v6580 : string = "true; v6578 " + v6579 + "); " + v6567 + " // rust.fix_closure'"
                                                                                                        let v6581 : bool = Fable.Core.RustInterop.emitRustExpr () v6580 
                                                                                                        let v6582 : string = "__future_init"
                                                                                                        let v6583 : _ = Fable.Core.RustInterop.emitRustExpr () v6582 
                                                                                                        let v6584 : string = "v6583"
                                                                                                        let v6585 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6584 
                                                                                                        v6585
                                                                                                    | US4_0(v6586) -> (* Some *)
                                                                                                        let v6587 : unit = ()
                                                                                                        let v6588 : (unit -> unit) = closure64(v6586)
                                                                                                        let v6589 : unit = (fun () -> v6588 (); v6587) ()
                                                                                                        let v6702 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6703 : bool = Fable.Core.RustInterop.emitRustExpr () v6702 
                                                                                                        let v6704 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6705 : bool = Fable.Core.RustInterop.emitRustExpr () v6704 
                                                                                                        let v6706 : uint8 = method58()
                                                                                                        let v6707 : string = ""
                                                                                                        let v6708 : string = "}"
                                                                                                        let v6709 : string = v6707 + v6708 
                                                                                                        let v6710 : string = "true; v6706 " + v6709 + "); " + v6707 + " // rust.fix_closure'"
                                                                                                        let v6711 : bool = Fable.Core.RustInterop.emitRustExpr () v6710 
                                                                                                        let v6712 : string = "__future_init"
                                                                                                        let v6713 : _ = Fable.Core.RustInterop.emitRustExpr () v6712 
                                                                                                        let v6714 : string = "v6713"
                                                                                                        let v6715 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6714 
                                                                                                        let v6716 : string = "v6715.await"
                                                                                                        let v6717 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6716 
                                                                                                        let v6718 : US7 = method47(v6717)
                                                                                                        let v6719 : string = v6707 + v6708 
                                                                                                        let v6720 : string = "true; v6718 " + v6719 + "); " + v6707 + " // rust.fix_closure'"
                                                                                                        let v6721 : bool = Fable.Core.RustInterop.emitRustExpr () v6720 
                                                                                                        let v6722 : string = "__future_init"
                                                                                                        let v6723 : _ = Fable.Core.RustInterop.emitRustExpr () v6722 
                                                                                                        let v6724 : string = "v6723"
                                                                                                        let v6725 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6724 
                                                                                                        v6725
                                                                                            | US6_0(v6270) -> (* Ok *)
                                                                                                match v6270 with
                                                                                                | US4_1 -> (* None *)
                                                                                                    let v6271 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6272 : bool = Fable.Core.RustInterop.emitRustExpr () v6271 
                                                                                                    let v6273 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6274 : bool = Fable.Core.RustInterop.emitRustExpr () v6273 
                                                                                                    let v6275 : uint8 = method59()
                                                                                                    let v6276 : string = ""
                                                                                                    let v6277 : string = "}"
                                                                                                    let v6278 : string = v6276 + v6277 
                                                                                                    let v6279 : string = "true; v6275 " + v6278 + "); " + v6276 + " // rust.fix_closure'"
                                                                                                    let v6280 : bool = Fable.Core.RustInterop.emitRustExpr () v6279 
                                                                                                    let v6281 : string = "__future_init"
                                                                                                    let v6282 : _ = Fable.Core.RustInterop.emitRustExpr () v6281 
                                                                                                    let v6283 : string = "v6282"
                                                                                                    let v6284 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6283 
                                                                                                    let v6285 : string = "v6284.await"
                                                                                                    let v6286 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6285 
                                                                                                    let v6287 : US7 = method49(v6286)
                                                                                                    let v6288 : string = v6276 + v6277 
                                                                                                    let v6289 : string = "true; v6287 " + v6288 + "); " + v6276 + " // rust.fix_closure'"
                                                                                                    let v6290 : bool = Fable.Core.RustInterop.emitRustExpr () v6289 
                                                                                                    let v6291 : string = "__future_init"
                                                                                                    let v6292 : _ = Fable.Core.RustInterop.emitRustExpr () v6291 
                                                                                                    let v6293 : string = "v6292"
                                                                                                    let v6294 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6293 
                                                                                                    v6294
                                                                                                | US4_0(v6295) -> (* Some *)
                                                                                                    let v6296 : unit = ()
                                                                                                    let v6297 : (unit -> unit) = closure65(v6295)
                                                                                                    let v6298 : unit = (fun () -> v6297 (); v6296) ()
                                                                                                    let v6411 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6412 : bool = Fable.Core.RustInterop.emitRustExpr () v6411 
                                                                                                    let v6413 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6414 : bool = Fable.Core.RustInterop.emitRustExpr () v6413 
                                                                                                    let v6415 : uint8 = method59()
                                                                                                    let v6416 : string = ""
                                                                                                    let v6417 : string = "}"
                                                                                                    let v6418 : string = v6416 + v6417 
                                                                                                    let v6419 : string = "true; v6415 " + v6418 + "); " + v6416 + " // rust.fix_closure'"
                                                                                                    let v6420 : bool = Fable.Core.RustInterop.emitRustExpr () v6419 
                                                                                                    let v6421 : string = "__future_init"
                                                                                                    let v6422 : _ = Fable.Core.RustInterop.emitRustExpr () v6421 
                                                                                                    let v6423 : string = "v6422"
                                                                                                    let v6424 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6423 
                                                                                                    let v6425 : string = "v6424.await"
                                                                                                    let v6426 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6425 
                                                                                                    let v6427 : US7 = method47(v6426)
                                                                                                    let v6428 : string = v6416 + v6417 
                                                                                                    let v6429 : string = "true; v6427 " + v6428 + "); " + v6416 + " // rust.fix_closure'"
                                                                                                    let v6430 : bool = Fable.Core.RustInterop.emitRustExpr () v6429 
                                                                                                    let v6431 : string = "__future_init"
                                                                                                    let v6432 : _ = Fable.Core.RustInterop.emitRustExpr () v6431 
                                                                                                    let v6433 : string = "v6432"
                                                                                                    let v6434 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6433 
                                                                                                    v6434
                                                                                        | US6_0(v5979) -> (* Ok *)
                                                                                            match v5979 with
                                                                                            | US4_1 -> (* None *)
                                                                                                let v5980 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v5981 : bool = Fable.Core.RustInterop.emitRustExpr () v5980 
                                                                                                let v5982 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v5983 : bool = Fable.Core.RustInterop.emitRustExpr () v5982 
                                                                                                let v5984 : uint8 = method60()
                                                                                                let v5985 : string = ""
                                                                                                let v5986 : string = "}"
                                                                                                let v5987 : string = v5985 + v5986 
                                                                                                let v5988 : string = "true; v5984 " + v5987 + "); " + v5985 + " // rust.fix_closure'"
                                                                                                let v5989 : bool = Fable.Core.RustInterop.emitRustExpr () v5988 
                                                                                                let v5990 : string = "__future_init"
                                                                                                let v5991 : _ = Fable.Core.RustInterop.emitRustExpr () v5990 
                                                                                                let v5992 : string = "v5991"
                                                                                                let v5993 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5992 
                                                                                                let v5994 : string = "v5993.await"
                                                                                                let v5995 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5994 
                                                                                                let v5996 : US7 = method49(v5995)
                                                                                                let v5997 : string = v5985 + v5986 
                                                                                                let v5998 : string = "true; v5996 " + v5997 + "); " + v5985 + " // rust.fix_closure'"
                                                                                                let v5999 : bool = Fable.Core.RustInterop.emitRustExpr () v5998 
                                                                                                let v6000 : string = "__future_init"
                                                                                                let v6001 : _ = Fable.Core.RustInterop.emitRustExpr () v6000 
                                                                                                let v6002 : string = "v6001"
                                                                                                let v6003 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6002 
                                                                                                v6003
                                                                                            | US4_0(v6004) -> (* Some *)
                                                                                                let v6005 : unit = ()
                                                                                                let v6006 : (unit -> unit) = closure66(v6004)
                                                                                                let v6007 : unit = (fun () -> v6006 (); v6005) ()
                                                                                                let v6120 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v6121 : bool = Fable.Core.RustInterop.emitRustExpr () v6120 
                                                                                                let v6122 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v6123 : bool = Fable.Core.RustInterop.emitRustExpr () v6122 
                                                                                                let v6124 : uint8 = method60()
                                                                                                let v6125 : string = ""
                                                                                                let v6126 : string = "}"
                                                                                                let v6127 : string = v6125 + v6126 
                                                                                                let v6128 : string = "true; v6124 " + v6127 + "); " + v6125 + " // rust.fix_closure'"
                                                                                                let v6129 : bool = Fable.Core.RustInterop.emitRustExpr () v6128 
                                                                                                let v6130 : string = "__future_init"
                                                                                                let v6131 : _ = Fable.Core.RustInterop.emitRustExpr () v6130 
                                                                                                let v6132 : string = "v6131"
                                                                                                let v6133 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6132 
                                                                                                let v6134 : string = "v6133.await"
                                                                                                let v6135 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6134 
                                                                                                let v6136 : US7 = method47(v6135)
                                                                                                let v6137 : string = v6125 + v6126 
                                                                                                let v6138 : string = "true; v6136 " + v6137 + "); " + v6125 + " // rust.fix_closure'"
                                                                                                let v6139 : bool = Fable.Core.RustInterop.emitRustExpr () v6138 
                                                                                                let v6140 : string = "__future_init"
                                                                                                let v6141 : _ = Fable.Core.RustInterop.emitRustExpr () v6140 
                                                                                                let v6142 : string = "v6141"
                                                                                                let v6143 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6142 
                                                                                                v6143
                                                                                    | US6_0(v5688) -> (* Ok *)
                                                                                        match v5688 with
                                                                                        | US4_1 -> (* None *)
                                                                                            let v5689 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v5690 : bool = Fable.Core.RustInterop.emitRustExpr () v5689 
                                                                                            let v5691 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v5692 : bool = Fable.Core.RustInterop.emitRustExpr () v5691 
                                                                                            let v5693 : uint8 = method61()
                                                                                            let v5694 : string = ""
                                                                                            let v5695 : string = "}"
                                                                                            let v5696 : string = v5694 + v5695 
                                                                                            let v5697 : string = "true; v5693 " + v5696 + "); " + v5694 + " // rust.fix_closure'"
                                                                                            let v5698 : bool = Fable.Core.RustInterop.emitRustExpr () v5697 
                                                                                            let v5699 : string = "__future_init"
                                                                                            let v5700 : _ = Fable.Core.RustInterop.emitRustExpr () v5699 
                                                                                            let v5701 : string = "v5700"
                                                                                            let v5702 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5701 
                                                                                            let v5703 : string = "v5702.await"
                                                                                            let v5704 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5703 
                                                                                            let v5705 : US7 = method49(v5704)
                                                                                            let v5706 : string = v5694 + v5695 
                                                                                            let v5707 : string = "true; v5705 " + v5706 + "); " + v5694 + " // rust.fix_closure'"
                                                                                            let v5708 : bool = Fable.Core.RustInterop.emitRustExpr () v5707 
                                                                                            let v5709 : string = "__future_init"
                                                                                            let v5710 : _ = Fable.Core.RustInterop.emitRustExpr () v5709 
                                                                                            let v5711 : string = "v5710"
                                                                                            let v5712 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5711 
                                                                                            v5712
                                                                                        | US4_0(v5713) -> (* Some *)
                                                                                            let v5714 : unit = ()
                                                                                            let v5715 : (unit -> unit) = closure67(v5713)
                                                                                            let v5716 : unit = (fun () -> v5715 (); v5714) ()
                                                                                            let v5829 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v5830 : bool = Fable.Core.RustInterop.emitRustExpr () v5829 
                                                                                            let v5831 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v5832 : bool = Fable.Core.RustInterop.emitRustExpr () v5831 
                                                                                            let v5833 : uint8 = method61()
                                                                                            let v5834 : string = ""
                                                                                            let v5835 : string = "}"
                                                                                            let v5836 : string = v5834 + v5835 
                                                                                            let v5837 : string = "true; v5833 " + v5836 + "); " + v5834 + " // rust.fix_closure'"
                                                                                            let v5838 : bool = Fable.Core.RustInterop.emitRustExpr () v5837 
                                                                                            let v5839 : string = "__future_init"
                                                                                            let v5840 : _ = Fable.Core.RustInterop.emitRustExpr () v5839 
                                                                                            let v5841 : string = "v5840"
                                                                                            let v5842 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5841 
                                                                                            let v5843 : string = "v5842.await"
                                                                                            let v5844 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5843 
                                                                                            let v5845 : US7 = method47(v5844)
                                                                                            let v5846 : string = v5834 + v5835 
                                                                                            let v5847 : string = "true; v5845 " + v5846 + "); " + v5834 + " // rust.fix_closure'"
                                                                                            let v5848 : bool = Fable.Core.RustInterop.emitRustExpr () v5847 
                                                                                            let v5849 : string = "__future_init"
                                                                                            let v5850 : _ = Fable.Core.RustInterop.emitRustExpr () v5849 
                                                                                            let v5851 : string = "v5850"
                                                                                            let v5852 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5851 
                                                                                            v5852
                                                                                | US6_0(v5397) -> (* Ok *)
                                                                                    match v5397 with
                                                                                    | US4_1 -> (* None *)
                                                                                        let v5398 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5399 : bool = Fable.Core.RustInterop.emitRustExpr () v5398 
                                                                                        let v5400 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5401 : bool = Fable.Core.RustInterop.emitRustExpr () v5400 
                                                                                        let v5402 : uint8 = method62()
                                                                                        let v5403 : string = ""
                                                                                        let v5404 : string = "}"
                                                                                        let v5405 : string = v5403 + v5404 
                                                                                        let v5406 : string = "true; v5402 " + v5405 + "); " + v5403 + " // rust.fix_closure'"
                                                                                        let v5407 : bool = Fable.Core.RustInterop.emitRustExpr () v5406 
                                                                                        let v5408 : string = "__future_init"
                                                                                        let v5409 : _ = Fable.Core.RustInterop.emitRustExpr () v5408 
                                                                                        let v5410 : string = "v5409"
                                                                                        let v5411 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5410 
                                                                                        let v5412 : string = "v5411.await"
                                                                                        let v5413 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5412 
                                                                                        let v5414 : US7 = method49(v5413)
                                                                                        let v5415 : string = v5403 + v5404 
                                                                                        let v5416 : string = "true; v5414 " + v5415 + "); " + v5403 + " // rust.fix_closure'"
                                                                                        let v5417 : bool = Fable.Core.RustInterop.emitRustExpr () v5416 
                                                                                        let v5418 : string = "__future_init"
                                                                                        let v5419 : _ = Fable.Core.RustInterop.emitRustExpr () v5418 
                                                                                        let v5420 : string = "v5419"
                                                                                        let v5421 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5420 
                                                                                        v5421
                                                                                    | US4_0(v5422) -> (* Some *)
                                                                                        let v5423 : unit = ()
                                                                                        let v5424 : (unit -> unit) = closure68(v5422)
                                                                                        let v5425 : unit = (fun () -> v5424 (); v5423) ()
                                                                                        let v5538 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5539 : bool = Fable.Core.RustInterop.emitRustExpr () v5538 
                                                                                        let v5540 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5541 : bool = Fable.Core.RustInterop.emitRustExpr () v5540 
                                                                                        let v5542 : uint8 = method62()
                                                                                        let v5543 : string = ""
                                                                                        let v5544 : string = "}"
                                                                                        let v5545 : string = v5543 + v5544 
                                                                                        let v5546 : string = "true; v5542 " + v5545 + "); " + v5543 + " // rust.fix_closure'"
                                                                                        let v5547 : bool = Fable.Core.RustInterop.emitRustExpr () v5546 
                                                                                        let v5548 : string = "__future_init"
                                                                                        let v5549 : _ = Fable.Core.RustInterop.emitRustExpr () v5548 
                                                                                        let v5550 : string = "v5549"
                                                                                        let v5551 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5550 
                                                                                        let v5552 : string = "v5551.await"
                                                                                        let v5553 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5552 
                                                                                        let v5554 : US7 = method47(v5553)
                                                                                        let v5555 : string = v5543 + v5544 
                                                                                        let v5556 : string = "true; v5554 " + v5555 + "); " + v5543 + " // rust.fix_closure'"
                                                                                        let v5557 : bool = Fable.Core.RustInterop.emitRustExpr () v5556 
                                                                                        let v5558 : string = "__future_init"
                                                                                        let v5559 : _ = Fable.Core.RustInterop.emitRustExpr () v5558 
                                                                                        let v5560 : string = "v5559"
                                                                                        let v5561 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5560 
                                                                                        v5561
                                                                            | US6_0(v5106) -> (* Ok *)
                                                                                match v5106 with
                                                                                | US4_1 -> (* None *)
                                                                                    let v5107 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5108 : bool = Fable.Core.RustInterop.emitRustExpr () v5107 
                                                                                    let v5109 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5110 : bool = Fable.Core.RustInterop.emitRustExpr () v5109 
                                                                                    let v5111 : uint8 = method63()
                                                                                    let v5112 : string = ""
                                                                                    let v5113 : string = "}"
                                                                                    let v5114 : string = v5112 + v5113 
                                                                                    let v5115 : string = "true; v5111 " + v5114 + "); " + v5112 + " // rust.fix_closure'"
                                                                                    let v5116 : bool = Fable.Core.RustInterop.emitRustExpr () v5115 
                                                                                    let v5117 : string = "__future_init"
                                                                                    let v5118 : _ = Fable.Core.RustInterop.emitRustExpr () v5117 
                                                                                    let v5119 : string = "v5118"
                                                                                    let v5120 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5119 
                                                                                    let v5121 : string = "v5120.await"
                                                                                    let v5122 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5121 
                                                                                    let v5123 : US7 = method49(v5122)
                                                                                    let v5124 : string = v5112 + v5113 
                                                                                    let v5125 : string = "true; v5123 " + v5124 + "); " + v5112 + " // rust.fix_closure'"
                                                                                    let v5126 : bool = Fable.Core.RustInterop.emitRustExpr () v5125 
                                                                                    let v5127 : string = "__future_init"
                                                                                    let v5128 : _ = Fable.Core.RustInterop.emitRustExpr () v5127 
                                                                                    let v5129 : string = "v5128"
                                                                                    let v5130 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5129 
                                                                                    v5130
                                                                                | US4_0(v5131) -> (* Some *)
                                                                                    let v5132 : unit = ()
                                                                                    let v5133 : (unit -> unit) = closure69(v5131)
                                                                                    let v5134 : unit = (fun () -> v5133 (); v5132) ()
                                                                                    let v5247 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5248 : bool = Fable.Core.RustInterop.emitRustExpr () v5247 
                                                                                    let v5249 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5250 : bool = Fable.Core.RustInterop.emitRustExpr () v5249 
                                                                                    let v5251 : uint8 = method63()
                                                                                    let v5252 : string = ""
                                                                                    let v5253 : string = "}"
                                                                                    let v5254 : string = v5252 + v5253 
                                                                                    let v5255 : string = "true; v5251 " + v5254 + "); " + v5252 + " // rust.fix_closure'"
                                                                                    let v5256 : bool = Fable.Core.RustInterop.emitRustExpr () v5255 
                                                                                    let v5257 : string = "__future_init"
                                                                                    let v5258 : _ = Fable.Core.RustInterop.emitRustExpr () v5257 
                                                                                    let v5259 : string = "v5258"
                                                                                    let v5260 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5259 
                                                                                    let v5261 : string = "v5260.await"
                                                                                    let v5262 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5261 
                                                                                    let v5263 : US7 = method47(v5262)
                                                                                    let v5264 : string = v5252 + v5253 
                                                                                    let v5265 : string = "true; v5263 " + v5264 + "); " + v5252 + " // rust.fix_closure'"
                                                                                    let v5266 : bool = Fable.Core.RustInterop.emitRustExpr () v5265 
                                                                                    let v5267 : string = "__future_init"
                                                                                    let v5268 : _ = Fable.Core.RustInterop.emitRustExpr () v5267 
                                                                                    let v5269 : string = "v5268"
                                                                                    let v5270 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5269 
                                                                                    v5270
                                                                        | US6_0(v4815) -> (* Ok *)
                                                                            match v4815 with
                                                                            | US4_1 -> (* None *)
                                                                                let v4816 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v4817 : bool = Fable.Core.RustInterop.emitRustExpr () v4816 
                                                                                let v4818 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v4819 : bool = Fable.Core.RustInterop.emitRustExpr () v4818 
                                                                                let v4820 : uint8 = method64()
                                                                                let v4821 : string = ""
                                                                                let v4822 : string = "}"
                                                                                let v4823 : string = v4821 + v4822 
                                                                                let v4824 : string = "true; v4820 " + v4823 + "); " + v4821 + " // rust.fix_closure'"
                                                                                let v4825 : bool = Fable.Core.RustInterop.emitRustExpr () v4824 
                                                                                let v4826 : string = "__future_init"
                                                                                let v4827 : _ = Fable.Core.RustInterop.emitRustExpr () v4826 
                                                                                let v4828 : string = "v4827"
                                                                                let v4829 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4828 
                                                                                let v4830 : string = "v4829.await"
                                                                                let v4831 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4830 
                                                                                let v4832 : US7 = method49(v4831)
                                                                                let v4833 : string = v4821 + v4822 
                                                                                let v4834 : string = "true; v4832 " + v4833 + "); " + v4821 + " // rust.fix_closure'"
                                                                                let v4835 : bool = Fable.Core.RustInterop.emitRustExpr () v4834 
                                                                                let v4836 : string = "__future_init"
                                                                                let v4837 : _ = Fable.Core.RustInterop.emitRustExpr () v4836 
                                                                                let v4838 : string = "v4837"
                                                                                let v4839 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4838 
                                                                                v4839
                                                                            | US4_0(v4840) -> (* Some *)
                                                                                let v4841 : unit = ()
                                                                                let v4842 : (unit -> unit) = closure70(v4840)
                                                                                let v4843 : unit = (fun () -> v4842 (); v4841) ()
                                                                                let v4956 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v4957 : bool = Fable.Core.RustInterop.emitRustExpr () v4956 
                                                                                let v4958 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v4959 : bool = Fable.Core.RustInterop.emitRustExpr () v4958 
                                                                                let v4960 : uint8 = method64()
                                                                                let v4961 : string = ""
                                                                                let v4962 : string = "}"
                                                                                let v4963 : string = v4961 + v4962 
                                                                                let v4964 : string = "true; v4960 " + v4963 + "); " + v4961 + " // rust.fix_closure'"
                                                                                let v4965 : bool = Fable.Core.RustInterop.emitRustExpr () v4964 
                                                                                let v4966 : string = "__future_init"
                                                                                let v4967 : _ = Fable.Core.RustInterop.emitRustExpr () v4966 
                                                                                let v4968 : string = "v4967"
                                                                                let v4969 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4968 
                                                                                let v4970 : string = "v4969.await"
                                                                                let v4971 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4970 
                                                                                let v4972 : US7 = method47(v4971)
                                                                                let v4973 : string = v4961 + v4962 
                                                                                let v4974 : string = "true; v4972 " + v4973 + "); " + v4961 + " // rust.fix_closure'"
                                                                                let v4975 : bool = Fable.Core.RustInterop.emitRustExpr () v4974 
                                                                                let v4976 : string = "__future_init"
                                                                                let v4977 : _ = Fable.Core.RustInterop.emitRustExpr () v4976 
                                                                                let v4978 : string = "v4977"
                                                                                let v4979 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4978 
                                                                                v4979
                                                                    | US6_0(v4524) -> (* Ok *)
                                                                        match v4524 with
                                                                        | US4_1 -> (* None *)
                                                                            let v4525 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4526 : bool = Fable.Core.RustInterop.emitRustExpr () v4525 
                                                                            let v4527 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4528 : bool = Fable.Core.RustInterop.emitRustExpr () v4527 
                                                                            let v4529 : uint8 = method65()
                                                                            let v4530 : string = ""
                                                                            let v4531 : string = "}"
                                                                            let v4532 : string = v4530 + v4531 
                                                                            let v4533 : string = "true; v4529 " + v4532 + "); " + v4530 + " // rust.fix_closure'"
                                                                            let v4534 : bool = Fable.Core.RustInterop.emitRustExpr () v4533 
                                                                            let v4535 : string = "__future_init"
                                                                            let v4536 : _ = Fable.Core.RustInterop.emitRustExpr () v4535 
                                                                            let v4537 : string = "v4536"
                                                                            let v4538 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4537 
                                                                            let v4539 : string = "v4538.await"
                                                                            let v4540 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4539 
                                                                            let v4541 : US7 = method49(v4540)
                                                                            let v4542 : string = v4530 + v4531 
                                                                            let v4543 : string = "true; v4541 " + v4542 + "); " + v4530 + " // rust.fix_closure'"
                                                                            let v4544 : bool = Fable.Core.RustInterop.emitRustExpr () v4543 
                                                                            let v4545 : string = "__future_init"
                                                                            let v4546 : _ = Fable.Core.RustInterop.emitRustExpr () v4545 
                                                                            let v4547 : string = "v4546"
                                                                            let v4548 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4547 
                                                                            v4548
                                                                        | US4_0(v4549) -> (* Some *)
                                                                            let v4550 : unit = ()
                                                                            let v4551 : (unit -> unit) = closure71(v4549)
                                                                            let v4552 : unit = (fun () -> v4551 (); v4550) ()
                                                                            let v4665 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4666 : bool = Fable.Core.RustInterop.emitRustExpr () v4665 
                                                                            let v4667 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4668 : bool = Fable.Core.RustInterop.emitRustExpr () v4667 
                                                                            let v4669 : uint8 = method65()
                                                                            let v4670 : string = ""
                                                                            let v4671 : string = "}"
                                                                            let v4672 : string = v4670 + v4671 
                                                                            let v4673 : string = "true; v4669 " + v4672 + "); " + v4670 + " // rust.fix_closure'"
                                                                            let v4674 : bool = Fable.Core.RustInterop.emitRustExpr () v4673 
                                                                            let v4675 : string = "__future_init"
                                                                            let v4676 : _ = Fable.Core.RustInterop.emitRustExpr () v4675 
                                                                            let v4677 : string = "v4676"
                                                                            let v4678 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4677 
                                                                            let v4679 : string = "v4678.await"
                                                                            let v4680 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4679 
                                                                            let v4681 : US7 = method47(v4680)
                                                                            let v4682 : string = v4670 + v4671 
                                                                            let v4683 : string = "true; v4681 " + v4682 + "); " + v4670 + " // rust.fix_closure'"
                                                                            let v4684 : bool = Fable.Core.RustInterop.emitRustExpr () v4683 
                                                                            let v4685 : string = "__future_init"
                                                                            let v4686 : _ = Fable.Core.RustInterop.emitRustExpr () v4685 
                                                                            let v4687 : string = "v4686"
                                                                            let v4688 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4687 
                                                                            v4688
                                                                | US6_0(v4233) -> (* Ok *)
                                                                    match v4233 with
                                                                    | US4_1 -> (* None *)
                                                                        let v4234 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4235 : bool = Fable.Core.RustInterop.emitRustExpr () v4234 
                                                                        let v4236 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4237 : bool = Fable.Core.RustInterop.emitRustExpr () v4236 
                                                                        let v4238 : uint8 = method66()
                                                                        let v4239 : string = ""
                                                                        let v4240 : string = "}"
                                                                        let v4241 : string = v4239 + v4240 
                                                                        let v4242 : string = "true; v4238 " + v4241 + "); " + v4239 + " // rust.fix_closure'"
                                                                        let v4243 : bool = Fable.Core.RustInterop.emitRustExpr () v4242 
                                                                        let v4244 : string = "__future_init"
                                                                        let v4245 : _ = Fable.Core.RustInterop.emitRustExpr () v4244 
                                                                        let v4246 : string = "v4245"
                                                                        let v4247 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4246 
                                                                        let v4248 : string = "v4247.await"
                                                                        let v4249 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4248 
                                                                        let v4250 : US7 = method49(v4249)
                                                                        let v4251 : string = v4239 + v4240 
                                                                        let v4252 : string = "true; v4250 " + v4251 + "); " + v4239 + " // rust.fix_closure'"
                                                                        let v4253 : bool = Fable.Core.RustInterop.emitRustExpr () v4252 
                                                                        let v4254 : string = "__future_init"
                                                                        let v4255 : _ = Fable.Core.RustInterop.emitRustExpr () v4254 
                                                                        let v4256 : string = "v4255"
                                                                        let v4257 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4256 
                                                                        v4257
                                                                    | US4_0(v4258) -> (* Some *)
                                                                        let v4259 : unit = ()
                                                                        let v4260 : (unit -> unit) = closure72(v4258)
                                                                        let v4261 : unit = (fun () -> v4260 (); v4259) ()
                                                                        let v4374 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4375 : bool = Fable.Core.RustInterop.emitRustExpr () v4374 
                                                                        let v4376 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4377 : bool = Fable.Core.RustInterop.emitRustExpr () v4376 
                                                                        let v4378 : uint8 = method66()
                                                                        let v4379 : string = ""
                                                                        let v4380 : string = "}"
                                                                        let v4381 : string = v4379 + v4380 
                                                                        let v4382 : string = "true; v4378 " + v4381 + "); " + v4379 + " // rust.fix_closure'"
                                                                        let v4383 : bool = Fable.Core.RustInterop.emitRustExpr () v4382 
                                                                        let v4384 : string = "__future_init"
                                                                        let v4385 : _ = Fable.Core.RustInterop.emitRustExpr () v4384 
                                                                        let v4386 : string = "v4385"
                                                                        let v4387 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4386 
                                                                        let v4388 : string = "v4387.await"
                                                                        let v4389 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4388 
                                                                        let v4390 : US7 = method47(v4389)
                                                                        let v4391 : string = v4379 + v4380 
                                                                        let v4392 : string = "true; v4390 " + v4391 + "); " + v4379 + " // rust.fix_closure'"
                                                                        let v4393 : bool = Fable.Core.RustInterop.emitRustExpr () v4392 
                                                                        let v4394 : string = "__future_init"
                                                                        let v4395 : _ = Fable.Core.RustInterop.emitRustExpr () v4394 
                                                                        let v4396 : string = "v4395"
                                                                        let v4397 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4396 
                                                                        v4397
                                                            | US6_0(v3942) -> (* Ok *)
                                                                match v3942 with
                                                                | US4_1 -> (* None *)
                                                                    let v3943 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v3944 : bool = Fable.Core.RustInterop.emitRustExpr () v3943 
                                                                    let v3945 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v3946 : bool = Fable.Core.RustInterop.emitRustExpr () v3945 
                                                                    let v3947 : uint8 = method67()
                                                                    let v3948 : string = ""
                                                                    let v3949 : string = "}"
                                                                    let v3950 : string = v3948 + v3949 
                                                                    let v3951 : string = "true; v3947 " + v3950 + "); " + v3948 + " // rust.fix_closure'"
                                                                    let v3952 : bool = Fable.Core.RustInterop.emitRustExpr () v3951 
                                                                    let v3953 : string = "__future_init"
                                                                    let v3954 : _ = Fable.Core.RustInterop.emitRustExpr () v3953 
                                                                    let v3955 : string = "v3954"
                                                                    let v3956 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3955 
                                                                    let v3957 : string = "v3956.await"
                                                                    let v3958 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3957 
                                                                    let v3959 : US7 = method49(v3958)
                                                                    let v3960 : string = v3948 + v3949 
                                                                    let v3961 : string = "true; v3959 " + v3960 + "); " + v3948 + " // rust.fix_closure'"
                                                                    let v3962 : bool = Fable.Core.RustInterop.emitRustExpr () v3961 
                                                                    let v3963 : string = "__future_init"
                                                                    let v3964 : _ = Fable.Core.RustInterop.emitRustExpr () v3963 
                                                                    let v3965 : string = "v3964"
                                                                    let v3966 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3965 
                                                                    v3966
                                                                | US4_0(v3967) -> (* Some *)
                                                                    let v3968 : unit = ()
                                                                    let v3969 : (unit -> unit) = closure73(v3967)
                                                                    let v3970 : unit = (fun () -> v3969 (); v3968) ()
                                                                    let v4083 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v4084 : bool = Fable.Core.RustInterop.emitRustExpr () v4083 
                                                                    let v4085 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v4086 : bool = Fable.Core.RustInterop.emitRustExpr () v4085 
                                                                    let v4087 : uint8 = method67()
                                                                    let v4088 : string = ""
                                                                    let v4089 : string = "}"
                                                                    let v4090 : string = v4088 + v4089 
                                                                    let v4091 : string = "true; v4087 " + v4090 + "); " + v4088 + " // rust.fix_closure'"
                                                                    let v4092 : bool = Fable.Core.RustInterop.emitRustExpr () v4091 
                                                                    let v4093 : string = "__future_init"
                                                                    let v4094 : _ = Fable.Core.RustInterop.emitRustExpr () v4093 
                                                                    let v4095 : string = "v4094"
                                                                    let v4096 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4095 
                                                                    let v4097 : string = "v4096.await"
                                                                    let v4098 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4097 
                                                                    let v4099 : US7 = method47(v4098)
                                                                    let v4100 : string = v4088 + v4089 
                                                                    let v4101 : string = "true; v4099 " + v4100 + "); " + v4088 + " // rust.fix_closure'"
                                                                    let v4102 : bool = Fable.Core.RustInterop.emitRustExpr () v4101 
                                                                    let v4103 : string = "__future_init"
                                                                    let v4104 : _ = Fable.Core.RustInterop.emitRustExpr () v4103 
                                                                    let v4105 : string = "v4104"
                                                                    let v4106 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4105 
                                                                    v4106
                                                        | US6_0(v3651) -> (* Ok *)
                                                            match v3651 with
                                                            | US4_1 -> (* None *)
                                                                let v3652 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3653 : bool = Fable.Core.RustInterop.emitRustExpr () v3652 
                                                                let v3654 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3655 : bool = Fable.Core.RustInterop.emitRustExpr () v3654 
                                                                let v3656 : uint8 = method68()
                                                                let v3657 : string = ""
                                                                let v3658 : string = "}"
                                                                let v3659 : string = v3657 + v3658 
                                                                let v3660 : string = "true; v3656 " + v3659 + "); " + v3657 + " // rust.fix_closure'"
                                                                let v3661 : bool = Fable.Core.RustInterop.emitRustExpr () v3660 
                                                                let v3662 : string = "__future_init"
                                                                let v3663 : _ = Fable.Core.RustInterop.emitRustExpr () v3662 
                                                                let v3664 : string = "v3663"
                                                                let v3665 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3664 
                                                                let v3666 : string = "v3665.await"
                                                                let v3667 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3666 
                                                                let v3668 : US7 = method49(v3667)
                                                                let v3669 : string = v3657 + v3658 
                                                                let v3670 : string = "true; v3668 " + v3669 + "); " + v3657 + " // rust.fix_closure'"
                                                                let v3671 : bool = Fable.Core.RustInterop.emitRustExpr () v3670 
                                                                let v3672 : string = "__future_init"
                                                                let v3673 : _ = Fable.Core.RustInterop.emitRustExpr () v3672 
                                                                let v3674 : string = "v3673"
                                                                let v3675 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3674 
                                                                v3675
                                                            | US4_0(v3676) -> (* Some *)
                                                                let v3677 : unit = ()
                                                                let v3678 : (unit -> unit) = closure74(v3676)
                                                                let v3679 : unit = (fun () -> v3678 (); v3677) ()
                                                                let v3792 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3793 : bool = Fable.Core.RustInterop.emitRustExpr () v3792 
                                                                let v3794 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3795 : bool = Fable.Core.RustInterop.emitRustExpr () v3794 
                                                                let v3796 : uint8 = method68()
                                                                let v3797 : string = ""
                                                                let v3798 : string = "}"
                                                                let v3799 : string = v3797 + v3798 
                                                                let v3800 : string = "true; v3796 " + v3799 + "); " + v3797 + " // rust.fix_closure'"
                                                                let v3801 : bool = Fable.Core.RustInterop.emitRustExpr () v3800 
                                                                let v3802 : string = "__future_init"
                                                                let v3803 : _ = Fable.Core.RustInterop.emitRustExpr () v3802 
                                                                let v3804 : string = "v3803"
                                                                let v3805 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3804 
                                                                let v3806 : string = "v3805.await"
                                                                let v3807 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3806 
                                                                let v3808 : US7 = method47(v3807)
                                                                let v3809 : string = v3797 + v3798 
                                                                let v3810 : string = "true; v3808 " + v3809 + "); " + v3797 + " // rust.fix_closure'"
                                                                let v3811 : bool = Fable.Core.RustInterop.emitRustExpr () v3810 
                                                                let v3812 : string = "__future_init"
                                                                let v3813 : _ = Fable.Core.RustInterop.emitRustExpr () v3812 
                                                                let v3814 : string = "v3813"
                                                                let v3815 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3814 
                                                                v3815
                                                    | US6_0(v3360) -> (* Ok *)
                                                        match v3360 with
                                                        | US4_1 -> (* None *)
                                                            let v3361 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3362 : bool = Fable.Core.RustInterop.emitRustExpr () v3361 
                                                            let v3363 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3364 : bool = Fable.Core.RustInterop.emitRustExpr () v3363 
                                                            let v3365 : uint8 = method69()
                                                            let v3366 : string = ""
                                                            let v3367 : string = "}"
                                                            let v3368 : string = v3366 + v3367 
                                                            let v3369 : string = "true; v3365 " + v3368 + "); " + v3366 + " // rust.fix_closure'"
                                                            let v3370 : bool = Fable.Core.RustInterop.emitRustExpr () v3369 
                                                            let v3371 : string = "__future_init"
                                                            let v3372 : _ = Fable.Core.RustInterop.emitRustExpr () v3371 
                                                            let v3373 : string = "v3372"
                                                            let v3374 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3373 
                                                            let v3375 : string = "v3374.await"
                                                            let v3376 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3375 
                                                            let v3377 : US7 = method49(v3376)
                                                            let v3378 : string = v3366 + v3367 
                                                            let v3379 : string = "true; v3377 " + v3378 + "); " + v3366 + " // rust.fix_closure'"
                                                            let v3380 : bool = Fable.Core.RustInterop.emitRustExpr () v3379 
                                                            let v3381 : string = "__future_init"
                                                            let v3382 : _ = Fable.Core.RustInterop.emitRustExpr () v3381 
                                                            let v3383 : string = "v3382"
                                                            let v3384 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3383 
                                                            v3384
                                                        | US4_0(v3385) -> (* Some *)
                                                            let v3386 : unit = ()
                                                            let v3387 : (unit -> unit) = closure75(v3385)
                                                            let v3388 : unit = (fun () -> v3387 (); v3386) ()
                                                            let v3501 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3502 : bool = Fable.Core.RustInterop.emitRustExpr () v3501 
                                                            let v3503 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3504 : bool = Fable.Core.RustInterop.emitRustExpr () v3503 
                                                            let v3505 : uint8 = method69()
                                                            let v3506 : string = ""
                                                            let v3507 : string = "}"
                                                            let v3508 : string = v3506 + v3507 
                                                            let v3509 : string = "true; v3505 " + v3508 + "); " + v3506 + " // rust.fix_closure'"
                                                            let v3510 : bool = Fable.Core.RustInterop.emitRustExpr () v3509 
                                                            let v3511 : string = "__future_init"
                                                            let v3512 : _ = Fable.Core.RustInterop.emitRustExpr () v3511 
                                                            let v3513 : string = "v3512"
                                                            let v3514 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3513 
                                                            let v3515 : string = "v3514.await"
                                                            let v3516 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3515 
                                                            let v3517 : US7 = method47(v3516)
                                                            let v3518 : string = v3506 + v3507 
                                                            let v3519 : string = "true; v3517 " + v3518 + "); " + v3506 + " // rust.fix_closure'"
                                                            let v3520 : bool = Fable.Core.RustInterop.emitRustExpr () v3519 
                                                            let v3521 : string = "__future_init"
                                                            let v3522 : _ = Fable.Core.RustInterop.emitRustExpr () v3521 
                                                            let v3523 : string = "v3522"
                                                            let v3524 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3523 
                                                            v3524
                                                | US6_0(v3069) -> (* Ok *)
                                                    match v3069 with
                                                    | US4_1 -> (* None *)
                                                        let v3070 : string = "true; let __future_init = Box::pin(async move { //"
                                                        let v3071 : bool = Fable.Core.RustInterop.emitRustExpr () v3070 
                                                        let v3072 : string = "true; let __future_init = Box::pin(async move { //"
                                                        let v3073 : bool = Fable.Core.RustInterop.emitRustExpr () v3072 
                                                        let v3074 : uint8 = method70()
                                                        let v3075 : string = ""
                                                        let v3076 : string = "}"
                                                        let v3077 : string = v3075 + v3076 
                                                        let v3078 : string = "true; v3074 " + v3077 + "); " + v3075 + " // rust.fix_closure'"
                                                        let v3079 : bool = Fable.Core.RustInterop.emitRustExpr () v3078 
                                                        let v3080 : string = "__future_init"
                                                        let v3081 : _ = Fable.Core.RustInterop.emitRustExpr () v3080 
                                                        let v3082 : string = "v3081"
                                                        let v3083 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3082 
                                                        let v3084 : string = "v3083.await"
                                                        let v3085 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3084 
                                                        let v3086 : US7 = method49(v3085)
                                                        let v3087 : string = v3075 + v3076 
                                                        let v3088 : string = "true; v3086 " + v3087 + "); " + v3075 + " // rust.fix_closure'"
                                                        let v3089 : bool = Fable.Core.RustInterop.emitRustExpr () v3088 
                                                        let v3090 : string = "__future_init"
                                                        let v3091 : _ = Fable.Core.RustInterop.emitRustExpr () v3090 
                                                        let v3092 : string = "v3091"
                                                        let v3093 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3092 
                                                        v3093
                                                    | US4_0(v3094) -> (* Some *)
                                                        let v3095 : unit = ()
                                                        let v3096 : (unit -> unit) = closure76(v3094)
                                                        let v3097 : unit = (fun () -> v3096 (); v3095) ()
                                                        let v3210 : string = "true; let __future_init = Box::pin(async move { //"
                                                        let v3211 : bool = Fable.Core.RustInterop.emitRustExpr () v3210 
                                                        let v3212 : string = "true; let __future_init = Box::pin(async move { //"
                                                        let v3213 : bool = Fable.Core.RustInterop.emitRustExpr () v3212 
                                                        let v3214 : uint8 = method70()
                                                        let v3215 : string = ""
                                                        let v3216 : string = "}"
                                                        let v3217 : string = v3215 + v3216 
                                                        let v3218 : string = "true; v3214 " + v3217 + "); " + v3215 + " // rust.fix_closure'"
                                                        let v3219 : bool = Fable.Core.RustInterop.emitRustExpr () v3218 
                                                        let v3220 : string = "__future_init"
                                                        let v3221 : _ = Fable.Core.RustInterop.emitRustExpr () v3220 
                                                        let v3222 : string = "v3221"
                                                        let v3223 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3222 
                                                        let v3224 : string = "v3223.await"
                                                        let v3225 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3224 
                                                        let v3226 : US7 = method47(v3225)
                                                        let v3227 : string = v3215 + v3216 
                                                        let v3228 : string = "true; v3226 " + v3227 + "); " + v3215 + " // rust.fix_closure'"
                                                        let v3229 : bool = Fable.Core.RustInterop.emitRustExpr () v3228 
                                                        let v3230 : string = "__future_init"
                                                        let v3231 : _ = Fable.Core.RustInterop.emitRustExpr () v3230 
                                                        let v3232 : string = "v3231"
                                                        let v3233 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3232 
                                                        v3233
                                            | US6_0(v2778) -> (* Ok *)
                                                match v2778 with
                                                | US4_1 -> (* None *)
                                                    let v2779 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v2780 : bool = Fable.Core.RustInterop.emitRustExpr () v2779 
                                                    let v2781 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v2782 : bool = Fable.Core.RustInterop.emitRustExpr () v2781 
                                                    let v2783 : uint8 = method71()
                                                    let v2784 : string = ""
                                                    let v2785 : string = "}"
                                                    let v2786 : string = v2784 + v2785 
                                                    let v2787 : string = "true; v2783 " + v2786 + "); " + v2784 + " // rust.fix_closure'"
                                                    let v2788 : bool = Fable.Core.RustInterop.emitRustExpr () v2787 
                                                    let v2789 : string = "__future_init"
                                                    let v2790 : _ = Fable.Core.RustInterop.emitRustExpr () v2789 
                                                    let v2791 : string = "v2790"
                                                    let v2792 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2791 
                                                    let v2793 : string = "v2792.await"
                                                    let v2794 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2793 
                                                    let v2795 : US7 = method49(v2794)
                                                    let v2796 : string = v2784 + v2785 
                                                    let v2797 : string = "true; v2795 " + v2796 + "); " + v2784 + " // rust.fix_closure'"
                                                    let v2798 : bool = Fable.Core.RustInterop.emitRustExpr () v2797 
                                                    let v2799 : string = "__future_init"
                                                    let v2800 : _ = Fable.Core.RustInterop.emitRustExpr () v2799 
                                                    let v2801 : string = "v2800"
                                                    let v2802 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2801 
                                                    v2802
                                                | US4_0(v2803) -> (* Some *)
                                                    let v2804 : unit = ()
                                                    let v2805 : (unit -> unit) = closure77(v2803)
                                                    let v2806 : unit = (fun () -> v2805 (); v2804) ()
                                                    let v2919 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v2920 : bool = Fable.Core.RustInterop.emitRustExpr () v2919 
                                                    let v2921 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v2922 : bool = Fable.Core.RustInterop.emitRustExpr () v2921 
                                                    let v2923 : uint8 = method71()
                                                    let v2924 : string = ""
                                                    let v2925 : string = "}"
                                                    let v2926 : string = v2924 + v2925 
                                                    let v2927 : string = "true; v2923 " + v2926 + "); " + v2924 + " // rust.fix_closure'"
                                                    let v2928 : bool = Fable.Core.RustInterop.emitRustExpr () v2927 
                                                    let v2929 : string = "__future_init"
                                                    let v2930 : _ = Fable.Core.RustInterop.emitRustExpr () v2929 
                                                    let v2931 : string = "v2930"
                                                    let v2932 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2931 
                                                    let v2933 : string = "v2932.await"
                                                    let v2934 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2933 
                                                    let v2935 : US7 = method47(v2934)
                                                    let v2936 : string = v2924 + v2925 
                                                    let v2937 : string = "true; v2935 " + v2936 + "); " + v2924 + " // rust.fix_closure'"
                                                    let v2938 : bool = Fable.Core.RustInterop.emitRustExpr () v2937 
                                                    let v2939 : string = "__future_init"
                                                    let v2940 : _ = Fable.Core.RustInterop.emitRustExpr () v2939 
                                                    let v2941 : string = "v2940"
                                                    let v2942 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2941 
                                                    v2942
                                        | US6_0(v2487) -> (* Ok *)
                                            match v2487 with
                                            | US4_1 -> (* None *)
                                                let v2488 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2489 : bool = Fable.Core.RustInterop.emitRustExpr () v2488 
                                                let v2490 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2491 : bool = Fable.Core.RustInterop.emitRustExpr () v2490 
                                                let v2492 : uint8 = method72()
                                                let v2493 : string = ""
                                                let v2494 : string = "}"
                                                let v2495 : string = v2493 + v2494 
                                                let v2496 : string = "true; v2492 " + v2495 + "); " + v2493 + " // rust.fix_closure'"
                                                let v2497 : bool = Fable.Core.RustInterop.emitRustExpr () v2496 
                                                let v2498 : string = "__future_init"
                                                let v2499 : _ = Fable.Core.RustInterop.emitRustExpr () v2498 
                                                let v2500 : string = "v2499"
                                                let v2501 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2500 
                                                let v2502 : string = "v2501.await"
                                                let v2503 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2502 
                                                let v2504 : US7 = method49(v2503)
                                                let v2505 : string = v2493 + v2494 
                                                let v2506 : string = "true; v2504 " + v2505 + "); " + v2493 + " // rust.fix_closure'"
                                                let v2507 : bool = Fable.Core.RustInterop.emitRustExpr () v2506 
                                                let v2508 : string = "__future_init"
                                                let v2509 : _ = Fable.Core.RustInterop.emitRustExpr () v2508 
                                                let v2510 : string = "v2509"
                                                let v2511 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2510 
                                                v2511
                                            | US4_0(v2512) -> (* Some *)
                                                let v2513 : unit = ()
                                                let v2514 : (unit -> unit) = closure78(v2512)
                                                let v2515 : unit = (fun () -> v2514 (); v2513) ()
                                                let v2628 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2629 : bool = Fable.Core.RustInterop.emitRustExpr () v2628 
                                                let v2630 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2631 : bool = Fable.Core.RustInterop.emitRustExpr () v2630 
                                                let v2632 : uint8 = method72()
                                                let v2633 : string = ""
                                                let v2634 : string = "}"
                                                let v2635 : string = v2633 + v2634 
                                                let v2636 : string = "true; v2632 " + v2635 + "); " + v2633 + " // rust.fix_closure'"
                                                let v2637 : bool = Fable.Core.RustInterop.emitRustExpr () v2636 
                                                let v2638 : string = "__future_init"
                                                let v2639 : _ = Fable.Core.RustInterop.emitRustExpr () v2638 
                                                let v2640 : string = "v2639"
                                                let v2641 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2640 
                                                let v2642 : string = "v2641.await"
                                                let v2643 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2642 
                                                let v2644 : US7 = method47(v2643)
                                                let v2645 : string = v2633 + v2634 
                                                let v2646 : string = "true; v2644 " + v2645 + "); " + v2633 + " // rust.fix_closure'"
                                                let v2647 : bool = Fable.Core.RustInterop.emitRustExpr () v2646 
                                                let v2648 : string = "__future_init"
                                                let v2649 : _ = Fable.Core.RustInterop.emitRustExpr () v2648 
                                                let v2650 : string = "v2649"
                                                let v2651 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2650 
                                                v2651
                                    | US6_0(v2196) -> (* Ok *)
                                        match v2196 with
                                        | US4_1 -> (* None *)
                                            let v2197 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2198 : bool = Fable.Core.RustInterop.emitRustExpr () v2197 
                                            let v2199 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2200 : bool = Fable.Core.RustInterop.emitRustExpr () v2199 
                                            let v2201 : uint8 = method73()
                                            let v2202 : string = ""
                                            let v2203 : string = "}"
                                            let v2204 : string = v2202 + v2203 
                                            let v2205 : string = "true; v2201 " + v2204 + "); " + v2202 + " // rust.fix_closure'"
                                            let v2206 : bool = Fable.Core.RustInterop.emitRustExpr () v2205 
                                            let v2207 : string = "__future_init"
                                            let v2208 : _ = Fable.Core.RustInterop.emitRustExpr () v2207 
                                            let v2209 : string = "v2208"
                                            let v2210 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2209 
                                            let v2211 : string = "v2210.await"
                                            let v2212 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2211 
                                            let v2213 : US7 = method49(v2212)
                                            let v2214 : string = v2202 + v2203 
                                            let v2215 : string = "true; v2213 " + v2214 + "); " + v2202 + " // rust.fix_closure'"
                                            let v2216 : bool = Fable.Core.RustInterop.emitRustExpr () v2215 
                                            let v2217 : string = "__future_init"
                                            let v2218 : _ = Fable.Core.RustInterop.emitRustExpr () v2217 
                                            let v2219 : string = "v2218"
                                            let v2220 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2219 
                                            v2220
                                        | US4_0(v2221) -> (* Some *)
                                            let v2222 : unit = ()
                                            let v2223 : (unit -> unit) = closure79(v2221)
                                            let v2224 : unit = (fun () -> v2223 (); v2222) ()
                                            let v2337 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2338 : bool = Fable.Core.RustInterop.emitRustExpr () v2337 
                                            let v2339 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2340 : bool = Fable.Core.RustInterop.emitRustExpr () v2339 
                                            let v2341 : uint8 = method73()
                                            let v2342 : string = ""
                                            let v2343 : string = "}"
                                            let v2344 : string = v2342 + v2343 
                                            let v2345 : string = "true; v2341 " + v2344 + "); " + v2342 + " // rust.fix_closure'"
                                            let v2346 : bool = Fable.Core.RustInterop.emitRustExpr () v2345 
                                            let v2347 : string = "__future_init"
                                            let v2348 : _ = Fable.Core.RustInterop.emitRustExpr () v2347 
                                            let v2349 : string = "v2348"
                                            let v2350 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2349 
                                            let v2351 : string = "v2350.await"
                                            let v2352 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2351 
                                            let v2353 : US7 = method47(v2352)
                                            let v2354 : string = v2342 + v2343 
                                            let v2355 : string = "true; v2353 " + v2354 + "); " + v2342 + " // rust.fix_closure'"
                                            let v2356 : bool = Fable.Core.RustInterop.emitRustExpr () v2355 
                                            let v2357 : string = "__future_init"
                                            let v2358 : _ = Fable.Core.RustInterop.emitRustExpr () v2357 
                                            let v2359 : string = "v2358"
                                            let v2360 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2359 
                                            v2360
                                | US6_0(v1905) -> (* Ok *)
                                    match v1905 with
                                    | US4_1 -> (* None *)
                                        let v1906 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v1907 : bool = Fable.Core.RustInterop.emitRustExpr () v1906 
                                        let v1908 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v1909 : bool = Fable.Core.RustInterop.emitRustExpr () v1908 
                                        let v1910 : uint8 = method74()
                                        let v1911 : string = ""
                                        let v1912 : string = "}"
                                        let v1913 : string = v1911 + v1912 
                                        let v1914 : string = "true; v1910 " + v1913 + "); " + v1911 + " // rust.fix_closure'"
                                        let v1915 : bool = Fable.Core.RustInterop.emitRustExpr () v1914 
                                        let v1916 : string = "__future_init"
                                        let v1917 : _ = Fable.Core.RustInterop.emitRustExpr () v1916 
                                        let v1918 : string = "v1917"
                                        let v1919 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1918 
                                        let v1920 : string = "v1919.await"
                                        let v1921 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1920 
                                        let v1922 : US7 = method49(v1921)
                                        let v1923 : string = v1911 + v1912 
                                        let v1924 : string = "true; v1922 " + v1923 + "); " + v1911 + " // rust.fix_closure'"
                                        let v1925 : bool = Fable.Core.RustInterop.emitRustExpr () v1924 
                                        let v1926 : string = "__future_init"
                                        let v1927 : _ = Fable.Core.RustInterop.emitRustExpr () v1926 
                                        let v1928 : string = "v1927"
                                        let v1929 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1928 
                                        v1929
                                    | US4_0(v1930) -> (* Some *)
                                        let v1931 : unit = ()
                                        let v1932 : (unit -> unit) = closure80(v1930)
                                        let v1933 : unit = (fun () -> v1932 (); v1931) ()
                                        let v2046 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v2047 : bool = Fable.Core.RustInterop.emitRustExpr () v2046 
                                        let v2048 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v2049 : bool = Fable.Core.RustInterop.emitRustExpr () v2048 
                                        let v2050 : uint8 = method74()
                                        let v2051 : string = ""
                                        let v2052 : string = "}"
                                        let v2053 : string = v2051 + v2052 
                                        let v2054 : string = "true; v2050 " + v2053 + "); " + v2051 + " // rust.fix_closure'"
                                        let v2055 : bool = Fable.Core.RustInterop.emitRustExpr () v2054 
                                        let v2056 : string = "__future_init"
                                        let v2057 : _ = Fable.Core.RustInterop.emitRustExpr () v2056 
                                        let v2058 : string = "v2057"
                                        let v2059 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2058 
                                        let v2060 : string = "v2059.await"
                                        let v2061 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2060 
                                        let v2062 : US7 = method47(v2061)
                                        let v2063 : string = v2051 + v2052 
                                        let v2064 : string = "true; v2062 " + v2063 + "); " + v2051 + " // rust.fix_closure'"
                                        let v2065 : bool = Fable.Core.RustInterop.emitRustExpr () v2064 
                                        let v2066 : string = "__future_init"
                                        let v2067 : _ = Fable.Core.RustInterop.emitRustExpr () v2066 
                                        let v2068 : string = "v2067"
                                        let v2069 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2068 
                                        v2069
                            | US6_0(v1614) -> (* Ok *)
                                match v1614 with
                                | US4_1 -> (* None *)
                                    let v1615 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1616 : bool = Fable.Core.RustInterop.emitRustExpr () v1615 
                                    let v1617 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1618 : bool = Fable.Core.RustInterop.emitRustExpr () v1617 
                                    let v1619 : uint8 = method75()
                                    let v1620 : string = ""
                                    let v1621 : string = "}"
                                    let v1622 : string = v1620 + v1621 
                                    let v1623 : string = "true; v1619 " + v1622 + "); " + v1620 + " // rust.fix_closure'"
                                    let v1624 : bool = Fable.Core.RustInterop.emitRustExpr () v1623 
                                    let v1625 : string = "__future_init"
                                    let v1626 : _ = Fable.Core.RustInterop.emitRustExpr () v1625 
                                    let v1627 : string = "v1626"
                                    let v1628 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1627 
                                    let v1629 : string = "v1628.await"
                                    let v1630 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1629 
                                    let v1631 : US7 = method49(v1630)
                                    let v1632 : string = v1620 + v1621 
                                    let v1633 : string = "true; v1631 " + v1632 + "); " + v1620 + " // rust.fix_closure'"
                                    let v1634 : bool = Fable.Core.RustInterop.emitRustExpr () v1633 
                                    let v1635 : string = "__future_init"
                                    let v1636 : _ = Fable.Core.RustInterop.emitRustExpr () v1635 
                                    let v1637 : string = "v1636"
                                    let v1638 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1637 
                                    v1638
                                | US4_0(v1639) -> (* Some *)
                                    let v1640 : unit = ()
                                    let v1641 : (unit -> unit) = closure81(v1639)
                                    let v1642 : unit = (fun () -> v1641 (); v1640) ()
                                    let v1755 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1756 : bool = Fable.Core.RustInterop.emitRustExpr () v1755 
                                    let v1757 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1758 : bool = Fable.Core.RustInterop.emitRustExpr () v1757 
                                    let v1759 : uint8 = method75()
                                    let v1760 : string = ""
                                    let v1761 : string = "}"
                                    let v1762 : string = v1760 + v1761 
                                    let v1763 : string = "true; v1759 " + v1762 + "); " + v1760 + " // rust.fix_closure'"
                                    let v1764 : bool = Fable.Core.RustInterop.emitRustExpr () v1763 
                                    let v1765 : string = "__future_init"
                                    let v1766 : _ = Fable.Core.RustInterop.emitRustExpr () v1765 
                                    let v1767 : string = "v1766"
                                    let v1768 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1767 
                                    let v1769 : string = "v1768.await"
                                    let v1770 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1769 
                                    let v1771 : US7 = method47(v1770)
                                    let v1772 : string = v1760 + v1761 
                                    let v1773 : string = "true; v1771 " + v1772 + "); " + v1760 + " // rust.fix_closure'"
                                    let v1774 : bool = Fable.Core.RustInterop.emitRustExpr () v1773 
                                    let v1775 : string = "__future_init"
                                    let v1776 : _ = Fable.Core.RustInterop.emitRustExpr () v1775 
                                    let v1777 : string = "v1776"
                                    let v1778 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1777 
                                    v1778
                        | US6_0(v1323) -> (* Ok *)
                            match v1323 with
                            | US4_1 -> (* None *)
                                let v1324 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1325 : bool = Fable.Core.RustInterop.emitRustExpr () v1324 
                                let v1326 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1327 : bool = Fable.Core.RustInterop.emitRustExpr () v1326 
                                let v1328 : uint8 = method76()
                                let v1329 : string = ""
                                let v1330 : string = "}"
                                let v1331 : string = v1329 + v1330 
                                let v1332 : string = "true; v1328 " + v1331 + "); " + v1329 + " // rust.fix_closure'"
                                let v1333 : bool = Fable.Core.RustInterop.emitRustExpr () v1332 
                                let v1334 : string = "__future_init"
                                let v1335 : _ = Fable.Core.RustInterop.emitRustExpr () v1334 
                                let v1336 : string = "v1335"
                                let v1337 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1336 
                                let v1338 : string = "v1337.await"
                                let v1339 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1338 
                                let v1340 : US7 = method49(v1339)
                                let v1341 : string = v1329 + v1330 
                                let v1342 : string = "true; v1340 " + v1341 + "); " + v1329 + " // rust.fix_closure'"
                                let v1343 : bool = Fable.Core.RustInterop.emitRustExpr () v1342 
                                let v1344 : string = "__future_init"
                                let v1345 : _ = Fable.Core.RustInterop.emitRustExpr () v1344 
                                let v1346 : string = "v1345"
                                let v1347 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1346 
                                v1347
                            | US4_0(v1348) -> (* Some *)
                                let v1349 : unit = ()
                                let v1350 : (unit -> unit) = closure82(v1348)
                                let v1351 : unit = (fun () -> v1350 (); v1349) ()
                                let v1464 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1465 : bool = Fable.Core.RustInterop.emitRustExpr () v1464 
                                let v1466 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1467 : bool = Fable.Core.RustInterop.emitRustExpr () v1466 
                                let v1468 : uint8 = method76()
                                let v1469 : string = ""
                                let v1470 : string = "}"
                                let v1471 : string = v1469 + v1470 
                                let v1472 : string = "true; v1468 " + v1471 + "); " + v1469 + " // rust.fix_closure'"
                                let v1473 : bool = Fable.Core.RustInterop.emitRustExpr () v1472 
                                let v1474 : string = "__future_init"
                                let v1475 : _ = Fable.Core.RustInterop.emitRustExpr () v1474 
                                let v1476 : string = "v1475"
                                let v1477 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1476 
                                let v1478 : string = "v1477.await"
                                let v1479 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1478 
                                let v1480 : US7 = method47(v1479)
                                let v1481 : string = v1469 + v1470 
                                let v1482 : string = "true; v1480 " + v1481 + "); " + v1469 + " // rust.fix_closure'"
                                let v1483 : bool = Fable.Core.RustInterop.emitRustExpr () v1482 
                                let v1484 : string = "__future_init"
                                let v1485 : _ = Fable.Core.RustInterop.emitRustExpr () v1484 
                                let v1486 : string = "v1485"
                                let v1487 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1486 
                                v1487
                    | US6_0(v1032) -> (* Ok *)
                        match v1032 with
                        | US4_1 -> (* None *)
                            let v1033 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1034 : bool = Fable.Core.RustInterop.emitRustExpr () v1033 
                            let v1035 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1036 : bool = Fable.Core.RustInterop.emitRustExpr () v1035 
                            let v1037 : uint8 = method77()
                            let v1038 : string = ""
                            let v1039 : string = "}"
                            let v1040 : string = v1038 + v1039 
                            let v1041 : string = "true; v1037 " + v1040 + "); " + v1038 + " // rust.fix_closure'"
                            let v1042 : bool = Fable.Core.RustInterop.emitRustExpr () v1041 
                            let v1043 : string = "__future_init"
                            let v1044 : _ = Fable.Core.RustInterop.emitRustExpr () v1043 
                            let v1045 : string = "v1044"
                            let v1046 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1045 
                            let v1047 : string = "v1046.await"
                            let v1048 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1047 
                            let v1049 : US7 = method49(v1048)
                            let v1050 : string = v1038 + v1039 
                            let v1051 : string = "true; v1049 " + v1050 + "); " + v1038 + " // rust.fix_closure'"
                            let v1052 : bool = Fable.Core.RustInterop.emitRustExpr () v1051 
                            let v1053 : string = "__future_init"
                            let v1054 : _ = Fable.Core.RustInterop.emitRustExpr () v1053 
                            let v1055 : string = "v1054"
                            let v1056 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1055 
                            v1056
                        | US4_0(v1057) -> (* Some *)
                            let v1058 : unit = ()
                            let v1059 : (unit -> unit) = closure83(v1057)
                            let v1060 : unit = (fun () -> v1059 (); v1058) ()
                            let v1173 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1174 : bool = Fable.Core.RustInterop.emitRustExpr () v1173 
                            let v1175 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1176 : bool = Fable.Core.RustInterop.emitRustExpr () v1175 
                            let v1177 : uint8 = method77()
                            let v1178 : string = ""
                            let v1179 : string = "}"
                            let v1180 : string = v1178 + v1179 
                            let v1181 : string = "true; v1177 " + v1180 + "); " + v1178 + " // rust.fix_closure'"
                            let v1182 : bool = Fable.Core.RustInterop.emitRustExpr () v1181 
                            let v1183 : string = "__future_init"
                            let v1184 : _ = Fable.Core.RustInterop.emitRustExpr () v1183 
                            let v1185 : string = "v1184"
                            let v1186 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1185 
                            let v1187 : string = "v1186.await"
                            let v1188 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1187 
                            let v1189 : US7 = method47(v1188)
                            let v1190 : string = v1178 + v1179 
                            let v1191 : string = "true; v1189 " + v1190 + "); " + v1178 + " // rust.fix_closure'"
                            let v1192 : bool = Fable.Core.RustInterop.emitRustExpr () v1191 
                            let v1193 : string = "__future_init"
                            let v1194 : _ = Fable.Core.RustInterop.emitRustExpr () v1193 
                            let v1195 : string = "v1194"
                            let v1196 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1195 
                            v1196
                | US6_0(v741) -> (* Ok *)
                    match v741 with
                    | US4_1 -> (* None *)
                        let v742 : string = "true; let __future_init = Box::pin(async move { //"
                        let v743 : bool = Fable.Core.RustInterop.emitRustExpr () v742 
                        let v744 : string = "true; let __future_init = Box::pin(async move { //"
                        let v745 : bool = Fable.Core.RustInterop.emitRustExpr () v744 
                        let v746 : uint8 = method78()
                        let v747 : string = ""
                        let v748 : string = "}"
                        let v749 : string = v747 + v748 
                        let v750 : string = "true; v746 " + v749 + "); " + v747 + " // rust.fix_closure'"
                        let v751 : bool = Fable.Core.RustInterop.emitRustExpr () v750 
                        let v752 : string = "__future_init"
                        let v753 : _ = Fable.Core.RustInterop.emitRustExpr () v752 
                        let v754 : string = "v753"
                        let v755 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v754 
                        let v756 : string = "v755.await"
                        let v757 : uint8 = Fable.Core.RustInterop.emitRustExpr () v756 
                        let v758 : US7 = method49(v757)
                        let v759 : string = v747 + v748 
                        let v760 : string = "true; v758 " + v759 + "); " + v747 + " // rust.fix_closure'"
                        let v761 : bool = Fable.Core.RustInterop.emitRustExpr () v760 
                        let v762 : string = "__future_init"
                        let v763 : _ = Fable.Core.RustInterop.emitRustExpr () v762 
                        let v764 : string = "v763"
                        let v765 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v764 
                        v765
                    | US4_0(v766) -> (* Some *)
                        let v767 : unit = ()
                        let v768 : (unit -> unit) = closure84(v766)
                        let v769 : unit = (fun () -> v768 (); v767) ()
                        let v882 : string = "true; let __future_init = Box::pin(async move { //"
                        let v883 : bool = Fable.Core.RustInterop.emitRustExpr () v882 
                        let v884 : string = "true; let __future_init = Box::pin(async move { //"
                        let v885 : bool = Fable.Core.RustInterop.emitRustExpr () v884 
                        let v886 : uint8 = method78()
                        let v887 : string = ""
                        let v888 : string = "}"
                        let v889 : string = v887 + v888 
                        let v890 : string = "true; v886 " + v889 + "); " + v887 + " // rust.fix_closure'"
                        let v891 : bool = Fable.Core.RustInterop.emitRustExpr () v890 
                        let v892 : string = "__future_init"
                        let v893 : _ = Fable.Core.RustInterop.emitRustExpr () v892 
                        let v894 : string = "v893"
                        let v895 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v894 
                        let v896 : string = "v895.await"
                        let v897 : uint8 = Fable.Core.RustInterop.emitRustExpr () v896 
                        let v898 : US7 = method47(v897)
                        let v899 : string = v887 + v888 
                        let v900 : string = "true; v898 " + v899 + "); " + v887 + " // rust.fix_closure'"
                        let v901 : bool = Fable.Core.RustInterop.emitRustExpr () v900 
                        let v902 : string = "__future_init"
                        let v903 : _ = Fable.Core.RustInterop.emitRustExpr () v902 
                        let v904 : string = "v903"
                        let v905 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v904 
                        v905
            | US6_0(v450) -> (* Ok *)
                match v450 with
                | US4_1 -> (* None *)
                    let v451 : string = "true; let __future_init = Box::pin(async move { //"
                    let v452 : bool = Fable.Core.RustInterop.emitRustExpr () v451 
                    let v453 : string = "true; let __future_init = Box::pin(async move { //"
                    let v454 : bool = Fable.Core.RustInterop.emitRustExpr () v453 
                    let v455 : uint8 = method79()
                    let v456 : string = ""
                    let v457 : string = "}"
                    let v458 : string = v456 + v457 
                    let v459 : string = "true; v455 " + v458 + "); " + v456 + " // rust.fix_closure'"
                    let v460 : bool = Fable.Core.RustInterop.emitRustExpr () v459 
                    let v461 : string = "__future_init"
                    let v462 : _ = Fable.Core.RustInterop.emitRustExpr () v461 
                    let v463 : string = "v462"
                    let v464 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v463 
                    let v465 : string = "v464.await"
                    let v466 : uint8 = Fable.Core.RustInterop.emitRustExpr () v465 
                    let v467 : US7 = method49(v466)
                    let v468 : string = v456 + v457 
                    let v469 : string = "true; v467 " + v468 + "); " + v456 + " // rust.fix_closure'"
                    let v470 : bool = Fable.Core.RustInterop.emitRustExpr () v469 
                    let v471 : string = "__future_init"
                    let v472 : _ = Fable.Core.RustInterop.emitRustExpr () v471 
                    let v473 : string = "v472"
                    let v474 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v473 
                    v474
                | US4_0(v475) -> (* Some *)
                    let v476 : unit = ()
                    let v477 : (unit -> unit) = closure85(v475)
                    let v478 : unit = (fun () -> v477 (); v476) ()
                    let v591 : string = "true; let __future_init = Box::pin(async move { //"
                    let v592 : bool = Fable.Core.RustInterop.emitRustExpr () v591 
                    let v593 : string = "true; let __future_init = Box::pin(async move { //"
                    let v594 : bool = Fable.Core.RustInterop.emitRustExpr () v593 
                    let v595 : uint8 = method79()
                    let v596 : string = ""
                    let v597 : string = "}"
                    let v598 : string = v596 + v597 
                    let v599 : string = "true; v595 " + v598 + "); " + v596 + " // rust.fix_closure'"
                    let v600 : bool = Fable.Core.RustInterop.emitRustExpr () v599 
                    let v601 : string = "__future_init"
                    let v602 : _ = Fable.Core.RustInterop.emitRustExpr () v601 
                    let v603 : string = "v602"
                    let v604 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v603 
                    let v605 : string = "v604.await"
                    let v606 : uint8 = Fable.Core.RustInterop.emitRustExpr () v605 
                    let v607 : US7 = method47(v606)
                    let v608 : string = v596 + v597 
                    let v609 : string = "true; v607 " + v608 + "); " + v596 + " // rust.fix_closure'"
                    let v610 : bool = Fable.Core.RustInterop.emitRustExpr () v609 
                    let v611 : string = "__future_init"
                    let v612 : _ = Fable.Core.RustInterop.emitRustExpr () v611 
                    let v613 : string = "v612"
                    let v614 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v613 
                    v614
        | US6_0(v159) -> (* Ok *)
            match v159 with
            | US4_1 -> (* None *)
                let v160 : string = "true; let __future_init = Box::pin(async move { //"
                let v161 : bool = Fable.Core.RustInterop.emitRustExpr () v160 
                let v162 : string = "true; let __future_init = Box::pin(async move { //"
                let v163 : bool = Fable.Core.RustInterop.emitRustExpr () v162 
                let v164 : uint8 = method80()
                let v165 : string = ""
                let v166 : string = "}"
                let v167 : string = v165 + v166 
                let v168 : string = "true; v164 " + v167 + "); " + v165 + " // rust.fix_closure'"
                let v169 : bool = Fable.Core.RustInterop.emitRustExpr () v168 
                let v170 : string = "__future_init"
                let v171 : _ = Fable.Core.RustInterop.emitRustExpr () v170 
                let v172 : string = "v171"
                let v173 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v172 
                let v174 : string = "v173.await"
                let v175 : uint8 = Fable.Core.RustInterop.emitRustExpr () v174 
                let v176 : US7 = method49(v175)
                let v177 : string = v165 + v166 
                let v178 : string = "true; v176 " + v177 + "); " + v165 + " // rust.fix_closure'"
                let v179 : bool = Fable.Core.RustInterop.emitRustExpr () v178 
                let v180 : string = "__future_init"
                let v181 : _ = Fable.Core.RustInterop.emitRustExpr () v180 
                let v182 : string = "v181"
                let v183 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v182 
                v183
            | US4_0(v184) -> (* Some *)
                let v185 : unit = ()
                let v186 : (unit -> unit) = closure86(v184)
                let v187 : unit = (fun () -> v186 (); v185) ()
                let v300 : string = "true; let __future_init = Box::pin(async move { //"
                let v301 : bool = Fable.Core.RustInterop.emitRustExpr () v300 
                let v302 : string = "true; let __future_init = Box::pin(async move { //"
                let v303 : bool = Fable.Core.RustInterop.emitRustExpr () v302 
                let v304 : uint8 = method80()
                let v305 : string = ""
                let v306 : string = "}"
                let v307 : string = v305 + v306 
                let v308 : string = "true; v304 " + v307 + "); " + v305 + " // rust.fix_closure'"
                let v309 : bool = Fable.Core.RustInterop.emitRustExpr () v308 
                let v310 : string = "__future_init"
                let v311 : _ = Fable.Core.RustInterop.emitRustExpr () v310 
                let v312 : string = "v311"
                let v313 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v312 
                let v314 : string = "v313.await"
                let v315 : uint8 = Fable.Core.RustInterop.emitRustExpr () v314 
                let v316 : US7 = method47(v315)
                let v317 : string = v305 + v306 
                let v318 : string = "true; v316 " + v317 + "); " + v305 + " // rust.fix_closure'"
                let v319 : bool = Fable.Core.RustInterop.emitRustExpr () v318 
                let v320 : string = "__future_init"
                let v321 : _ = Fable.Core.RustInterop.emitRustExpr () v320 
                let v322 : string = "v321"
                let v323 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v322 
                v323
    let v8672 : string = "v8671.await"
    let v8673 : US7 = Fable.Core.RustInterop.emitRustExpr () v8672 
    let v8674 : unit = ()
    let v8675 : (unit -> unit) = closure87(v8673)
    let v8676 : unit = (fun () -> v8675 (); v8674) ()
    let v8797 : Result<uint8, anyhow_Error> =
        match v8673 with
        | US7_1(v8790) -> (* Error *)
            let v8791 : string = method82(v8790)
            let v8792 : string = "anyhow::anyhow!($0)"
            let v8793 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v8791 v8792 
            let v8794 : string = "Err($0)"
            let v8795 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v8793 v8794 
            v8795
        | US7_0(v8788) -> (* Ok *)
            let v8789 : Result<uint8, anyhow_Error> = Ok v8788 
            v8789
    let v8798 : Result<uint8, anyhow_Error> = method83(v8797)
    let v8799 : string = ""
    let v8800 : string = "}"
    let v8801 : string = v8799 + v8800 
    let v8802 : string = "true; v8798 " + v8801 + "); " + v8799 + " // rust.fix_closure'"
    let v8803 : bool = Fable.Core.RustInterop.emitRustExpr () v8802 
    let v8804 : string = "__future_init"
    let v8805 : _ = Fable.Core.RustInterop.emitRustExpr () v8804 
    let v8806 : string = "v8805"
    let v8807 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v8806 
    v8807
and closure88 () (v0 : uint8) : US8 =
    US8_0(v0)
and method84 () : (uint8 -> US8) =
    closure88()
and closure0 () (v0 : (string [])) : int32 =
    let v1 : clap_Command = method0()
    let v2 : string = "clap::Command::get_matches($0)"
    let v3 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = method1()
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "clap::ArgMatches::get_one(&$0, v6).cloned()"
    let v8 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v3 v7 
    let v9 : (std_string_String -> US0) = method2()
    let v10 : US0 option = v8 |> Option.map v9 
    let v21 : US0 = US0_1
    let v22 : US0 = v10 |> Option.defaultValue v21 
    let v78 : US1 =
        match v22 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v26) -> (* Some *)
            let v27 : string = "fable_library_rust::String_::fromString($0)"
            let v28 : string = Fable.Core.RustInterop.emitRustExpr v26 v27 
            
            
            
            
            
            let v29 : bool = "Verbose" = v28
            let v33 : US2 =
                if v29 then
                    let v30 : US3 = US3_0
                    US2_0(v30)
                else
                    US2_1
            let v74 : US2 =
                match v33 with
                | US2_1 -> (* None *)
                    let v36 : bool = "Debug" = v28
                    let v40 : US2 =
                        if v36 then
                            let v37 : US3 = US3_1
                            US2_0(v37)
                        else
                            US2_1
                    match v40 with
                    | US2_1 -> (* None *)
                        let v43 : bool = "Info" = v28
                        let v47 : US2 =
                            if v43 then
                                let v44 : US3 = US3_2
                                US2_0(v44)
                            else
                                US2_1
                        match v47 with
                        | US2_1 -> (* None *)
                            let v50 : bool = "Warning" = v28
                            let v54 : US2 =
                                if v50 then
                                    let v51 : US3 = US3_3
                                    US2_0(v51)
                                else
                                    US2_1
                            match v54 with
                            | US2_1 -> (* None *)
                                let v57 : bool = "Critical" = v28
                                let v61 : US2 =
                                    if v57 then
                                        let v58 : US3 = US3_4
                                        US2_0(v58)
                                    else
                                        US2_1
                                match v61 with
                                | US2_1 -> (* None *)
                                    US2_1
                                | US2_0(v62) -> (* Some *)
                                    US2_0(v62)
                            | US2_0(v55) -> (* Some *)
                                US2_0(v55)
                        | US2_0(v48) -> (* Some *)
                            US2_0(v48)
                    | US2_0(v41) -> (* Some *)
                        US2_0(v41)
                | US2_0(v34) -> (* Some *)
                    US2_0(v34)
            US1_0(v74)
    let v85 : US2 =
        match v78 with
        | US1_0(v79) -> (* Some *)
            match v79 with
            | US2_0(v80) -> (* Some *)
                US2_0(v80)
            | _ ->
                US2_1
        | _ ->
            US2_1
    let v89 : US3 =
        match v85 with
        | US2_1 -> (* None *)
            US3_0
        | US2_0(v86) -> (* Some *)
            v86
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure2(v89)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
    let v122 : unit = ()
    let v123 : (unit -> unit) = closure5(v0)
    let v124 : unit = (fun () -> v123 (); v122) ()
    let v240 : string = method19()
    let v241 : string = "&*$0"
    let v242 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v240 v241 
    let v243 : string = "clap::ArgMatches::get_flag(&v3, v242)"
    let v244 : bool = Fable.Core.RustInterop.emitRustExpr () v243 
    let v245 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = method20(v3)
    let v246 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v247 : _ = Fable.Core.RustInterop.emitRustExpr () v246 
    let v248 : string = "v247.handle().block_on($0)"
    let v249 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v245 v248 
    let v250 : (anyhow_Error -> std_string_String) = method42()
    let v251 : string = "$0.map_err(|x| $1(x))"
    let v252 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v249, v250) v251 
    let v253 : string = "$0.ok()"
    let v254 : uint8 option = Fable.Core.RustInterop.emitRustExpr v252 v253 
    let v255 : (uint8 -> US8) = method84()
    let v256 : US8 option = v254 |> Option.map v255 
    let v267 : US8 = US8_1
    let v268 : US8 = v256 |> Option.defaultValue v267 
    match v268 with
    | US8_1 -> (* None *)
        if v244 then
            ()
        else
            let v277 : string = "$0.unwrap()"
            let v278 : uint8 = Fable.Core.RustInterop.emitRustExpr v252 v277 
            ()
    | US8_0(v272) -> (* Some *)
        if v244 then
            let v273 : string = "Err($0)"
            let v274 : string = "spiral_wasm.main / exception=true"
            let v275 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v274 v273 
            let v276 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v275 v276 
            ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
