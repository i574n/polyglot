#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

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
type std_string_String = class end
#else
type std_string_String = string
#endif

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
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::types::Gas")>]
#endif
type near_workspaces_types_Gas = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::result::ExecutionFinalResult")>]
#endif
type near_workspaces_result_ExecutionFinalResult = class end
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
type std_io_Error = class end
#else
type std_io_Error = string
#endif

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
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "&*$0"
    let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v67 
    let _v66 = v68 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v69 
    let _v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v65 v71 
    let _v66 = v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : Ref<Str> = v65 |> unbox<Ref<Str>>
    let _v66 = v73 
    #endif
#if FABLE_COMPILER_PYTHON
    let v76 : Ref<Str> = v65 |> unbox<Ref<Str>>
    let _v66 = v76 
    #endif
#else
    let v79 : Ref<Str> = v65 |> unbox<Ref<Str>>
    let _v66 = v79 
    #endif
    let v82 : Ref<Str> = _v66 
    let v87 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : string = "String::from($0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v88 
    let _v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : string = "String::from($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v90 
    let _v87 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = "String::from($0)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v82 v92 
    let _v87 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v94 : std_string_String = v82 |> unbox<std_string_String>
    let _v87 = v94 
    #endif
#if FABLE_COMPILER_PYTHON
    let v97 : std_string_String = v82 |> unbox<std_string_String>
    let _v87 = v97 
    #endif
#else
    let v100 : std_string_String = v82 |> unbox<std_string_String>
    let _v87 = v100 
    #endif
    let v103 : std_string_String = _v87 
    let v108 : string = "Box::new($0)"
    let v109 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v103 v108 
    let v110 : string = "Box::leak($0)"
    let v111 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let v112 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v113 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v111 v112 
    let v114 : string = "true; $0 }).collect::<Vec<_>>()"
    let v115 : bool = Fable.Core.RustInterop.emitRustExpr v113 v114 
    let v116 : string = "_vec_map"
    let v117 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v116 
    let v118 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v119 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v117 v118 
    let v120 : string = "$0.value_parser($1)"
    let v121 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v34, v119) v120 
    let v122 : string = "clap::Command::arg($0, $1)"
    let v123 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v23, v121) v122 
    let v124 : string = "wasm"
    let v125 : string = "r#\"" + v124 + "\"#"
    let v126 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v125 
    let v127 : string = "clap::Arg::new($0)"
    let v128 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v126 v127 
    let v129 : string = "$0.short($1)"
    let v130 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v128, 'w') v129 
    let v131 : string = "r#\"" + v124 + "\"#"
    let v132 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v131 
    let v133 : string = "$0.long($1)"
    let v134 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v130, v132) v133 
    let v135 : string = "$0.required($1)"
    let v136 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v134, true) v135 
    let v137 : string = "clap::Command::arg($0, $1)"
    let v138 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v123, v136) v137 
    v138
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
    let v69 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v70 : string = "String::from($0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v70 
    let _v69 = v71 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v72 : string = "String::from($0)"
    let v73 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v72 
    let _v69 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "String::from($0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v68 v74 
    let _v69 = v75 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v76 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v76 
    #endif
#if FABLE_COMPILER_PYTHON
    let v79 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v79 
    #endif
#else
    let v82 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v82 
    #endif
    let v85 : std_string_String = _v69 
    let v90 : string = "fable_library_rust::String_::fromString($0)"
    let v91 : string = Fable.Core.RustInterop.emitRustExpr v85 v90 
    let _v66 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "env!(\"" + v65 + "\")"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v92 
    let v94 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v95 : string = "String::from($0)"
    let v96 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v95 
    let _v94 = v96 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v97 
    let _v94 = v98 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v99 : string = "String::from($0)"
    let v100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v93 v99 
    let _v94 = v100 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v101 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v101 
    #endif
#if FABLE_COMPILER_PYTHON
    let v104 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v104 
    #endif
#else
    let v107 : std_string_String = v93 |> unbox<std_string_String>
    let _v94 = v107 
    #endif
    let v110 : std_string_String = _v94 
    let v115 : string = "fable_library_rust::String_::fromString($0)"
    let v116 : string = Fable.Core.RustInterop.emitRustExpr v110 v115 
    let _v66 = v116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v117 : string = "env!(\"" + v65 + "\")"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117 
    let v119 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v120 : string = "String::from($0)"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v120 
    let _v119 = v121 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v122 : string = "String::from($0)"
    let v123 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v122 
    let _v119 = v123 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v118 v124 
    let _v119 = v125 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v126 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v126 
    #endif
#if FABLE_COMPILER_PYTHON
    let v129 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v129 
    #endif
#else
    let v132 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v132 
    #endif
    let v135 : std_string_String = _v119 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v135 v140 
    let _v66 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : string = null |> unbox<string>
    let _v66 = v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v145 : string = null |> unbox<string>
    let _v66 = v145 
    #endif
#else
    let v148 : string = null |> unbox<string>
    let _v66 = v148 
    #endif
    let v151 : string = _v66 
    let v156 : string = "True"
    let v157 : bool = v151 <> v156 
    let v166 : US5 =
        if v157 then
            US5_1
        else
            let v161 : string = $"near_sdk::env::block_timestamp()"
            let v162 : uint64 = Fable.Core.RustInterop.emitRustExpr () v161 
            let v163 : (uint64 -> int64) = int64
            let v164 : int64 = v163 v162
            US5_0(v164)
    let v167 : US2 = US2_1
    let _v1 = struct (v167, v166) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : string = method4()
    let v169 : string = method5(v168)
    
    
    
    
    
    let v170 : bool = "Verbose" = v169
    let v174 : US2 =
        if v170 then
            let v171 : US3 = US3_0
            US2_0(v171)
        else
            US2_1
    let v215 : US2 =
        match v174 with
        | US2_1 -> (* None *)
            let v177 : bool = "Debug" = v169
            let v181 : US2 =
                if v177 then
                    let v178 : US3 = US3_1
                    US2_0(v178)
                else
                    US2_1
            match v181 with
            | US2_1 -> (* None *)
                let v184 : bool = "Info" = v169
                let v188 : US2 =
                    if v184 then
                        let v185 : US3 = US3_2
                        US2_0(v185)
                    else
                        US2_1
                match v188 with
                | US2_1 -> (* None *)
                    let v191 : bool = "Warning" = v169
                    let v195 : US2 =
                        if v191 then
                            let v192 : US3 = US3_3
                            US2_0(v192)
                        else
                            US2_1
                    match v195 with
                    | US2_1 -> (* None *)
                        let v198 : bool = "Critical" = v169
                        let v202 : US2 =
                            if v198 then
                                let v199 : US3 = US3_4
                                US2_0(v199)
                            else
                                US2_1
                        match v202 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v203) -> (* Some *)
                            US2_0(v203)
                    | US2_0(v196) -> (* Some *)
                        US2_0(v196)
                | US2_0(v189) -> (* Some *)
                    US2_0(v189)
            | US2_0(v182) -> (* Some *)
                US2_0(v182)
        | US2_0(v175) -> (* Some *)
            US2_0(v175)
    let v216 : string = method8()
    let v217 : string = method5(v216)
    let v218 : bool = v217 = "True"
    let v228 : US5 =
        if v218 then
            let v219 : System.DateTime = System.DateTime.Now
            let v222 : (System.DateTime -> int64) = _.Ticks
            let v223 : int64 = v222 v219
            US5_0(v223)
        else
            US5_1
    let _v1 = struct (v215, v228) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v229 : string = method4()
    let v230 : string = method5(v229)
    
    
    
    
    
    let v231 : bool = "Verbose" = v230
    let v235 : US2 =
        if v231 then
            let v232 : US3 = US3_0
            US2_0(v232)
        else
            US2_1
    let v276 : US2 =
        match v235 with
        | US2_1 -> (* None *)
            let v238 : bool = "Debug" = v230
            let v242 : US2 =
                if v238 then
                    let v239 : US3 = US3_1
                    US2_0(v239)
                else
                    US2_1
            match v242 with
            | US2_1 -> (* None *)
                let v245 : bool = "Info" = v230
                let v249 : US2 =
                    if v245 then
                        let v246 : US3 = US3_2
                        US2_0(v246)
                    else
                        US2_1
                match v249 with
                | US2_1 -> (* None *)
                    let v252 : bool = "Warning" = v230
                    let v256 : US2 =
                        if v252 then
                            let v253 : US3 = US3_3
                            US2_0(v253)
                        else
                            US2_1
                    match v256 with
                    | US2_1 -> (* None *)
                        let v259 : bool = "Critical" = v230
                        let v263 : US2 =
                            if v259 then
                                let v260 : US3 = US3_4
                                US2_0(v260)
                            else
                                US2_1
                        match v263 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v264) -> (* Some *)
                            US2_0(v264)
                    | US2_0(v257) -> (* Some *)
                        US2_0(v257)
                | US2_0(v250) -> (* Some *)
                    US2_0(v250)
            | US2_0(v243) -> (* Some *)
                US2_0(v243)
        | US2_0(v236) -> (* Some *)
            US2_0(v236)
    let v277 : string = method8()
    let v278 : string = method5(v277)
    let v279 : bool = v278 = "True"
    let v289 : US5 =
        if v279 then
            let v280 : System.DateTime = System.DateTime.Now
            let v283 : (System.DateTime -> int64) = _.Ticks
            let v284 : int64 = v283 v280
            US5_0(v284)
        else
            US5_1
    let _v1 = struct (v276, v289) 
    #endif
#else
    let v290 : string = method4()
    let v291 : string = method5(v290)
    
    
    
    
    
    let v292 : bool = "Verbose" = v291
    let v296 : US2 =
        if v292 then
            let v293 : US3 = US3_0
            US2_0(v293)
        else
            US2_1
    let v337 : US2 =
        match v296 with
        | US2_1 -> (* None *)
            let v299 : bool = "Debug" = v291
            let v303 : US2 =
                if v299 then
                    let v300 : US3 = US3_1
                    US2_0(v300)
                else
                    US2_1
            match v303 with
            | US2_1 -> (* None *)
                let v306 : bool = "Info" = v291
                let v310 : US2 =
                    if v306 then
                        let v307 : US3 = US3_2
                        US2_0(v307)
                    else
                        US2_1
                match v310 with
                | US2_1 -> (* None *)
                    let v313 : bool = "Warning" = v291
                    let v317 : US2 =
                        if v313 then
                            let v314 : US3 = US3_3
                            US2_0(v314)
                        else
                            US2_1
                    match v317 with
                    | US2_1 -> (* None *)
                        let v320 : bool = "Critical" = v291
                        let v324 : US2 =
                            if v320 then
                                let v321 : US3 = US3_4
                                US2_0(v321)
                            else
                                US2_1
                        match v324 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v325) -> (* Some *)
                            US2_0(v325)
                    | US2_0(v318) -> (* Some *)
                        US2_0(v318)
                | US2_0(v311) -> (* Some *)
                    US2_0(v311)
            | US2_0(v304) -> (* Some *)
                US2_0(v304)
        | US2_0(v297) -> (* Some *)
            US2_0(v297)
    let v338 : string = method8()
    let v339 : string = method5(v338)
    let v340 : bool = v339 = "True"
    let v350 : US5 =
        if v340 then
            let v341 : System.DateTime = System.DateTime.Now
            let v344 : (System.DateTime -> int64) = _.Ticks
            let v345 : int64 = v344 v341
            US5_0(v345)
        else
            US5_1
    let _v1 = struct (v337, v350) 
    #endif
    let struct (v351 : US2, v352 : US5) = _v1 
    let v416 : Mut0 = {l0 = 1L} : Mut0
    let v417 : (string -> unit) = closure4()
    let v418 : Mut1 = {l0 = v417} : Mut1
    let v419 : Mut2 = {l0 = true} : Mut2
    let v420 : string = ""
    let v421 : Mut3 = {l0 = v420} : Mut3
    let v424 : US3 =
        match v351 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v422) -> (* Some *)
            v422
    let v425 : Mut4 = {l0 = v424} : Mut4
    let v432 : int64 option =
        match v352 with
        | US5_1 -> (* None *)
            let v430 : int64 option = None
            v430
        | US5_0(v426) -> (* Some *)
            let v427 : int64 option = Some v426 
            v427
    struct (v416, v418, v419, v421, v425, v432)
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
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_black"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_black"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[90m"
    let v108 : string = method14()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[90m"
    let v112 : string = method14()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[90m"
    let v116 : string = method14()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
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
    let v26 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v27 
    let _v26 = v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "&*$0"
    let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v29 
    let _v26 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = "&*$0"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v25 v31 
    let _v26 = v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v36 
    #endif
#else
    let v39 : Ref<Str> = v25 |> unbox<Ref<Str>>
    let _v26 = v39 
    #endif
    let v42 : Ref<Str> = _v26 
    let v47 : string = $"$0.chars()"
    let v48 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v42 v47 
    let v49 : string = "$0"
    let v50 : _ = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "$0.collect::<Vec<_>>()"
    let v52 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v54 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v56 : bool = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "x"
    let v58 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : string = "String::from_iter($0)"
    let v60 : std_string_String = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "true; $0 }).collect::<Vec<_>>()"
    let v62 : bool = Fable.Core.RustInterop.emitRustExpr v60 v61 
    let v63 : string = "_vec_map"
    let v64 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "$0.len()"
    let v66 : unativeint = Fable.Core.RustInterop.emitRustExpr v64 v65 
    let v67 : (unativeint -> int32) = int32
    let v68 : int32 = v67 v66
    let v69 : string = ""
    let v70 : bool = v0 <> v69 
    let v74 : bool =
        if v70 then
            let v73 : bool = v68 <= 1
            v73
        else
            false
    if v74 then
        v4.l0 <- v25
        ()
    else
        v4.l0 <- v69
        let v75 : string = "true; $0.into_iter().for_each(|x| { //"
        let v76 : bool = Fable.Core.RustInterop.emitRustExpr v64 v75 
        let v77 : string = "x"
        let v78 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v77 
        let v79 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v80 : bool = Fable.Core.RustInterop.emitRustExpr v78 v79 
        let v81 : string = $"true"
        let v82 : bool = Fable.Core.RustInterop.emitRustExpr () v81 
        let v83 : string = "true; }); //"
        let v84 : bool = Fable.Core.RustInterop.emitRustExpr () v83 
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
    let v85 : (string -> unit) = v2.l0
    v85 v0
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
    
    
    
    
    
    let v0 : string = "Info"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : string = v2.PadLeft (7, ' ')
    let v19 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : string = "inline_colorization::color_bright_green"
    let v21 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v20 
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_green"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_green"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[92m"
    let v108 : string = method14()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[92m"
    let v112 : string = method14()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[92m"
    let v116 : string = method14()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
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
            let v41 : bool = 2 >= v40
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
            let v43 : bool = 2 >= v42
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
    let v245 : string = "near_workspaces::types::Gas::from_tgas(300)"
    let v246 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr () v245 
    let v247 : string = "v244.gas(v246)"
    let v248 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr () v247 
    let v249 : string = "Box::pin(v248.transact())"
    let v250 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v249 
    let v251 : string = "v250.await"
    let v252 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v251 
    let v253 : string = "$0?"
    let v254 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v252 v253 
    let v255 : unit = ()
    let v256 : (unit -> unit) = closure15(v1, v254)
    let v257 : unit = (fun () -> v256 (); v255) ()
    let v369 : string = "v254.logs()"
    let v370 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v369 
    let v371 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v372 : bool = Fable.Core.RustInterop.emitRustExpr v370 v371 
    let v373 : string = "x"
    let v374 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v373 
    let v375 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v376 : string = "String::from($0)"
    let v377 : std_string_String = Fable.Core.RustInterop.emitRustExpr v374 v376 
    let _v375 = v377 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v378 : string = "String::from($0)"
    let v379 : std_string_String = Fable.Core.RustInterop.emitRustExpr v374 v378 
    let _v375 = v379 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v380 : string = "String::from($0)"
    let v381 : std_string_String = Fable.Core.RustInterop.emitRustExpr v374 v380 
    let _v375 = v381 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v382 : std_string_String = v374 |> unbox<std_string_String>
    let _v375 = v382 
    #endif
#if FABLE_COMPILER_PYTHON
    let v385 : std_string_String = v374 |> unbox<std_string_String>
    let _v375 = v385 
    #endif
#else
    let v388 : std_string_String = v374 |> unbox<std_string_String>
    let _v375 = v388 
    #endif
    let v391 : std_string_String = _v375 
    let v396 : string = "true; $0 }).collect::<Vec<_>>()"
    let v397 : bool = Fable.Core.RustInterop.emitRustExpr v391 v396 
    let v398 : string = "_vec_map"
    let v399 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v398 
    let v400 : string = "true; $0.iter().for_each(|x| { $1(x.clone()); }); //"
    let v401 : (std_string_String -> unit) = closure16()
    let v402 : bool = Fable.Core.RustInterop.emitRustExpr struct (v399, v401) v400 
    let v403 : string = "$0.total_gas_burnt"
    let v404 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v254 v403 
    let v405 : string = "$0.as_gas()"
    let v406 : uint64 = Fable.Core.RustInterop.emitRustExpr v404 v405 
    let v407 : (uint64 -> float) = float
    let v408 : float = v407 v406
    let v409 : float = v408 / 10000000000000000.0
    let v410 : float = v409 * 6.68
    let v411 : unit = ()
    let v412 : (unit -> unit) = closure18(v1, v406, v410)
    let v413 : unit = (fun () -> v412 (); v411) ()
    let v525 : string = "$0"
    let v526 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v254 v525 
    let v527 : string = "v526.outcomes()"
    let v528 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v527 
    let v529 : string = "v528.into_iter()"
    let v530 : _ = Fable.Core.RustInterop.emitRustExpr () v529 
    let v531 : string = "v530.cloned()"
    let v532 : _ = Fable.Core.RustInterop.emitRustExpr () v531 
    let v533 : string = "true; v532.for_each(|x| $0(x))"
    let v534 : (near_workspaces_result_ExecutionOutcome -> unit) = closure19()
    let v535 : bool = Fable.Core.RustInterop.emitRustExpr v534 v533 
    let v536 : string = "$0.into_result()"
    let v537 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v254 v536 
    let v538 : unit = ()
    let v539 : (unit -> unit) = closure21(v537)
    let v540 : unit = (fun () -> v539 (); v538) ()
    let v652 : near_workspaces_result_ExecutionFinalResult = method34(v254)
    let v653 : string = "v652.receipt_failures()"
    let v654 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v653 
    let v655 : string = "$0.len()"
    let v656 : unativeint = Fable.Core.RustInterop.emitRustExpr v654 v655 
    let v657 : (unativeint -> int32) = int32
    let v658 : int32 = v657 v656
    let v659 : unit = ()
    let v660 : (unit -> unit) = closure22(v654, v658)
    let v661 : unit = (fun () -> v660 (); v659) ()
    let v773 : near_workspaces_result_ExecutionFinalResult = method36(v254)
    let v774 : string = "v773.receipt_outcomes()"
    let v775 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v774 
    let v776 : string = "v775.into()"
    let v777 : Vec<near_workspaces_result_ExecutionOutcome> = Fable.Core.RustInterop.emitRustExpr () v776 
    let v778 : string = "$0.len()"
    let v779 : unativeint = Fable.Core.RustInterop.emitRustExpr v777 v778 
    let v780 : (unativeint -> int32) = int32
    let v781 : int32 = v780 v779
    let v782 : unit = ()
    let v783 : (unit -> unit) = closure23(v777, v781)
    let v784 : unit = (fun () -> v783 (); v782) ()
    let v896 : string = "$0.json()"
    let v897 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v254 v896 
    let v898 : unit = ()
    let v899 : (unit -> unit) = closure24(v897)
    let v900 : unit = (fun () -> v899 (); v898) ()
    let v1012 : string = "$0.borsh()"
    let v1013 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v254 v1012 
    let v1014 : unit = ()
    let v1015 : (unit -> unit) = closure25(v1013)
    let v1016 : unit = (fun () -> v1015 (); v1014) ()
    let v1128 : string = method40(v654, v781, v1)
    let v1129 : bool = v658 > 0
    let v1151 : Result<US4, anyhow_Error> =
        if v1129 then
            let v1130 : US4 = US4_0(v1128)
            let v1131 : Result<US4, anyhow_Error> = Ok v1130 
            v1131
        else
            let v1132 : bool = v781 > 1
            if v1132 then
                let v1133 : US4 = US4_1
                let v1134 : Result<US4, anyhow_Error> = Ok v1133 
                v1134
            else
                let v1135 : string = "anyhow::anyhow!($0)"
                let v1136 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v1128 v1135 
                let v1137 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v1138 : string = "Err($0)"
                let v1139 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v1136 v1138 
                let _v1137 = v1139 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v1140 : string = "Err($0)"
                let v1141 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v1136 v1140 
                let _v1137 = v1141 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v1142 : string = "Err($0)"
                let v1143 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v1136 v1142 
                let _v1137 = v1143 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v1144 : Result<US4, anyhow_Error> = v1136 |> Error
                let _v1137 = v1144 
                #endif
#if FABLE_COMPILER_PYTHON
                let v1145 : Result<US4, anyhow_Error> = v1136 |> Error
                let _v1137 = v1145 
                #endif
#else
                let v1146 : Result<US4, anyhow_Error> = v1136 |> Error
                let _v1137 = v1146 
                #endif
                let v1147 : Result<US4, anyhow_Error> = _v1137 
                v1147
    let v1152 : Result<US4, anyhow_Error> = method41(v1151)
    let v1153 : string = ""
    let v1154 : string = "}"
    let v1155 : string = v1153 + v1154 
    let v1156 : string = "true; v1152 " + v1155 + "); " + v1153 + " // rust.fix_closure'"
    let v1157 : bool = Fable.Core.RustInterop.emitRustExpr () v1156 
    let v1158 : string = "__future_init"
    let v1159 : _ = Fable.Core.RustInterop.emitRustExpr () v1158 
    let v1160 : string = "v1159"
    let v1161 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v1160 
    v1161
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
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_yellow"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_yellow"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[93m"
    let v108 : string = method14()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[93m"
    let v112 : string = method14()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[93m"
    let v116 : string = method14()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
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
    let v22 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v23 : string = "&*$0"
    let v24 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v23 
    let _v22 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v25 : string = "&*$0"
    let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v25 
    let _v22 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string = "&*$0"
    let v28 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v27 
    let _v22 = v28 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v29 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v29 
    #endif
#if FABLE_COMPILER_PYTHON
    let v32 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v32 
    #endif
#else
    let v35 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v22 = v35 
    #endif
    let v38 : Ref<Str> = _v22 
    let v43 : string = "inline_colorization::color_reset"
    let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43 
    let v45 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v46 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v21, v38, v44) v45 
    let v47 : string = "fable_library_rust::String_::fromString($0)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let _v19 = v48 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v49 : string = "inline_colorization::color_bright_red"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v49 
    let v51 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v52 : string = "&*$0"
    let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v52 
    let _v51 = v53 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v54 
    let _v51 = v55 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v56 
    let _v51 = v57 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v58 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v58 
    #endif
#if FABLE_COMPILER_PYTHON
    let v61 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v61 
    #endif
#else
    let v64 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v51 = v64 
    #endif
    let v67 : Ref<Str> = _v51 
    let v72 : string = "inline_colorization::color_reset"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v50, v67, v73) v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _v19 = v77 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : string = "inline_colorization::color_bright_red"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v81 : string = "&*$0"
    let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v81 
    let _v80 = v82 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : string = "&*$0"
    let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v83 
    let _v80 = v84 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "&*$0"
    let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v5 v85 
    let _v80 = v86 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v90 
    #endif
#else
    let v93 : Ref<Str> = v5 |> unbox<Ref<Str>>
    let _v80 = v93 
    #endif
    let v96 : Ref<Str> = _v80 
    let v101 : string = "inline_colorization::color_reset"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v79, v96, v102) v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    let _v19 = v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v107 : string = "\u001b[91m"
    let v108 : string = method14()
    let v109 : string = v107 + v5 
    let v110 : string = v109 + v108 
    let _v19 = v110 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = "\u001b[91m"
    let v112 : string = method14()
    let v113 : string = v111 + v5 
    let v114 : string = v113 + v112 
    let _v19 = v114 
    #endif
#else
    let v115 : string = "\u001b[91m"
    let v116 : string = method14()
    let v117 : string = v115 + v5 
    let v118 : string = v117 + v116 
    let _v19 = v118 
    #endif
    let v119 : string = _v19 
    v119
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
    let v4 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v5 
    let _v4 = v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v7 : string = "&*$0"
    let v8 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v7 
    let _v4 = v8 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v9 : string = "&*$0"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v9 
    let _v4 = v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Ref<Str> = v3 |> unbox<Ref<Str>>
    let _v4 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Ref<Str> = v3 |> unbox<Ref<Str>>
    let _v4 = v14 
    #endif
#else
    let v17 : Ref<Str> = v3 |> unbox<Ref<Str>>
    let _v4 = v17 
    #endif
    let v20 : Ref<Str> = _v4 
    let v25 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v26 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v0, v20) v25 
    let v27 : (std_string_String -> US0) = method2()
    let v28 : US0 option = v26 |> Option.map v27 
    let v39 : US0 = US0_1
    let v40 : US0 = v28 |> Option.defaultValue v39 
    let v47 : std_string_String =
        match v40 with
        | US0_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US0_0(v44) -> (* Some *)
            v44
    let v48 : string = "fable_library_rust::String_::fromString($0)"
    let v49 : string = Fable.Core.RustInterop.emitRustExpr v47 v48 
    let v50 : unit = ()
    let v51 : (unit -> unit) = closure12(v49)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v164 : string = "std::fs::read(&*$0)"
    let v165 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v49 v164 
    let v166 : string = "$0?"
    let v167 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v165 v166 
    let v168 : uint8 = 1uy
    let v169 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v168)
    let v170 : string = "v169.await"
    let v171 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v170 
    let v172 : (anyhow_Error -> std_string_String) = method42()
    let v173 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v174 : string = "$0.map_err(|x| $1(x))"
    let v175 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v171, v172) v174 
    let _v173 = v175 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v176 : string = "$0.map_err(|x| $1(x))"
    let v177 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v171, v172) v176 
    let _v173 = v177 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v178 : string = "$0.map_err(|x| $1(x))"
    let v179 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v171, v172) v178 
    let _v173 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v180 : Result<US4, std_string_String> = match v171 with Ok x -> Ok x | Error x -> Error (v172 x)
    let _v173 = v180 
    #endif
#if FABLE_COMPILER_PYTHON
    let v181 : Result<US4, std_string_String> = match v171 with Ok x -> Ok x | Error x -> Error (v172 x)
    let _v173 = v181 
    #endif
#else
    let v182 : Result<US4, std_string_String> = match v171 with Ok x -> Ok x | Error x -> Error (v172 x)
    let _v173 = v182 
    #endif
    let v183 : Result<US4, std_string_String> = _v173 
    let v186 : (US4 -> US6) = closure27()
    let v187 : (std_string_String -> US6) = closure28()
    let v188 : US6 = match v183 with Ok x -> v186 x | Error x -> v187 x
    let v9009 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> =
        match v188 with
        | US6_1(v356) -> (* Error *)
            let v357 : unit = ()
            let v358 : (unit -> unit) = closure29(v356)
            let v359 : unit = (fun () -> v358 (); v357) ()
            let v472 : uint8 = 2uy
            let v473 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v472)
            let v474 : string = "v473.await"
            let v475 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v474 
            let v476 : (anyhow_Error -> std_string_String) = method42()
            let v477 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v478 : string = "$0.map_err(|x| $1(x))"
            let v479 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v475, v476) v478 
            let _v477 = v479 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v480 : string = "$0.map_err(|x| $1(x))"
            let v481 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v475, v476) v480 
            let _v477 = v481 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v482 : string = "$0.map_err(|x| $1(x))"
            let v483 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v475, v476) v482 
            let _v477 = v483 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v484 : Result<US4, std_string_String> = match v475 with Ok x -> Ok x | Error x -> Error (v476 x)
            let _v477 = v484 
            #endif
#if FABLE_COMPILER_PYTHON
            let v485 : Result<US4, std_string_String> = match v475 with Ok x -> Ok x | Error x -> Error (v476 x)
            let _v477 = v485 
            #endif
#else
            let v486 : Result<US4, std_string_String> = match v475 with Ok x -> Ok x | Error x -> Error (v476 x)
            let _v477 = v486 
            #endif
            let v487 : Result<US4, std_string_String> = _v477 
            let v490 : US6 = match v487 with Ok x -> v186 x | Error x -> v187 x
            match v490 with
            | US6_1(v658) -> (* Error *)
                let v659 : unit = ()
                let v660 : (unit -> unit) = closure30(v658)
                let v661 : unit = (fun () -> v660 (); v659) ()
                let v774 : uint8 = 3uy
                let v775 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v774)
                let v776 : string = "v775.await"
                let v777 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v776 
                let v778 : (anyhow_Error -> std_string_String) = method42()
                let v779 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v780 : string = "$0.map_err(|x| $1(x))"
                let v781 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v777, v778) v780 
                let _v779 = v781 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v782 : string = "$0.map_err(|x| $1(x))"
                let v783 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v777, v778) v782 
                let _v779 = v783 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v784 : string = "$0.map_err(|x| $1(x))"
                let v785 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v777, v778) v784 
                let _v779 = v785 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v786 : Result<US4, std_string_String> = match v777 with Ok x -> Ok x | Error x -> Error (v778 x)
                let _v779 = v786 
                #endif
#if FABLE_COMPILER_PYTHON
                let v787 : Result<US4, std_string_String> = match v777 with Ok x -> Ok x | Error x -> Error (v778 x)
                let _v779 = v787 
                #endif
#else
                let v788 : Result<US4, std_string_String> = match v777 with Ok x -> Ok x | Error x -> Error (v778 x)
                let _v779 = v788 
                #endif
                let v789 : Result<US4, std_string_String> = _v779 
                let v792 : US6 = match v789 with Ok x -> v186 x | Error x -> v187 x
                match v792 with
                | US6_1(v960) -> (* Error *)
                    let v961 : unit = ()
                    let v962 : (unit -> unit) = closure31(v960)
                    let v963 : unit = (fun () -> v962 (); v961) ()
                    let v1076 : uint8 = 4uy
                    let v1077 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v1076)
                    let v1078 : string = "v1077.await"
                    let v1079 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1078 
                    let v1080 : (anyhow_Error -> std_string_String) = method42()
                    let v1081 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v1082 : string = "$0.map_err(|x| $1(x))"
                    let v1083 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1079, v1080) v1082 
                    let _v1081 = v1083 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v1084 : string = "$0.map_err(|x| $1(x))"
                    let v1085 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1079, v1080) v1084 
                    let _v1081 = v1085 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v1086 : string = "$0.map_err(|x| $1(x))"
                    let v1087 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1079, v1080) v1086 
                    let _v1081 = v1087 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v1088 : Result<US4, std_string_String> = match v1079 with Ok x -> Ok x | Error x -> Error (v1080 x)
                    let _v1081 = v1088 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v1089 : Result<US4, std_string_String> = match v1079 with Ok x -> Ok x | Error x -> Error (v1080 x)
                    let _v1081 = v1089 
                    #endif
#else
                    let v1090 : Result<US4, std_string_String> = match v1079 with Ok x -> Ok x | Error x -> Error (v1080 x)
                    let _v1081 = v1090 
                    #endif
                    let v1091 : Result<US4, std_string_String> = _v1081 
                    let v1094 : US6 = match v1091 with Ok x -> v186 x | Error x -> v187 x
                    match v1094 with
                    | US6_1(v1262) -> (* Error *)
                        let v1263 : unit = ()
                        let v1264 : (unit -> unit) = closure32(v1262)
                        let v1265 : unit = (fun () -> v1264 (); v1263) ()
                        let v1378 : uint8 = 5uy
                        let v1379 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v1378)
                        let v1380 : string = "v1379.await"
                        let v1381 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1380 
                        let v1382 : (anyhow_Error -> std_string_String) = method42()
                        let v1383 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v1384 : string = "$0.map_err(|x| $1(x))"
                        let v1385 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1381, v1382) v1384 
                        let _v1383 = v1385 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v1386 : string = "$0.map_err(|x| $1(x))"
                        let v1387 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1381, v1382) v1386 
                        let _v1383 = v1387 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v1388 : string = "$0.map_err(|x| $1(x))"
                        let v1389 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1381, v1382) v1388 
                        let _v1383 = v1389 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v1390 : Result<US4, std_string_String> = match v1381 with Ok x -> Ok x | Error x -> Error (v1382 x)
                        let _v1383 = v1390 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v1391 : Result<US4, std_string_String> = match v1381 with Ok x -> Ok x | Error x -> Error (v1382 x)
                        let _v1383 = v1391 
                        #endif
#else
                        let v1392 : Result<US4, std_string_String> = match v1381 with Ok x -> Ok x | Error x -> Error (v1382 x)
                        let _v1383 = v1392 
                        #endif
                        let v1393 : Result<US4, std_string_String> = _v1383 
                        let v1396 : US6 = match v1393 with Ok x -> v186 x | Error x -> v187 x
                        match v1396 with
                        | US6_1(v1564) -> (* Error *)
                            let v1565 : unit = ()
                            let v1566 : (unit -> unit) = closure33(v1564)
                            let v1567 : unit = (fun () -> v1566 (); v1565) ()
                            let v1680 : uint8 = 6uy
                            let v1681 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v1680)
                            let v1682 : string = "v1681.await"
                            let v1683 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1682 
                            let v1684 : (anyhow_Error -> std_string_String) = method42()
                            let v1685 : unit = ()
                            
#if FABLE_COMPILER || WASM || CONTRACT
                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                            let v1686 : string = "$0.map_err(|x| $1(x))"
                            let v1687 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1683, v1684) v1686 
                            let _v1685 = v1687 
                            #endif
#if FABLE_COMPILER_RUST && WASM
                            let v1688 : string = "$0.map_err(|x| $1(x))"
                            let v1689 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1683, v1684) v1688 
                            let _v1685 = v1689 
                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                            let v1690 : string = "$0.map_err(|x| $1(x))"
                            let v1691 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1683, v1684) v1690 
                            let _v1685 = v1691 
                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                            let v1692 : Result<US4, std_string_String> = match v1683 with Ok x -> Ok x | Error x -> Error (v1684 x)
                            let _v1685 = v1692 
                            #endif
#if FABLE_COMPILER_PYTHON
                            let v1693 : Result<US4, std_string_String> = match v1683 with Ok x -> Ok x | Error x -> Error (v1684 x)
                            let _v1685 = v1693 
                            #endif
#else
                            let v1694 : Result<US4, std_string_String> = match v1683 with Ok x -> Ok x | Error x -> Error (v1684 x)
                            let _v1685 = v1694 
                            #endif
                            let v1695 : Result<US4, std_string_String> = _v1685 
                            let v1698 : US6 = match v1695 with Ok x -> v186 x | Error x -> v187 x
                            match v1698 with
                            | US6_1(v1866) -> (* Error *)
                                let v1867 : unit = ()
                                let v1868 : (unit -> unit) = closure34(v1866)
                                let v1869 : unit = (fun () -> v1868 (); v1867) ()
                                let v1982 : uint8 = 7uy
                                let v1983 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v1982)
                                let v1984 : string = "v1983.await"
                                let v1985 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v1984 
                                let v1986 : (anyhow_Error -> std_string_String) = method42()
                                let v1987 : unit = ()
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v1988 : string = "$0.map_err(|x| $1(x))"
                                let v1989 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1985, v1986) v1988 
                                let _v1987 = v1989 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v1990 : string = "$0.map_err(|x| $1(x))"
                                let v1991 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1985, v1986) v1990 
                                let _v1987 = v1991 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v1992 : string = "$0.map_err(|x| $1(x))"
                                let v1993 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v1985, v1986) v1992 
                                let _v1987 = v1993 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v1994 : Result<US4, std_string_String> = match v1985 with Ok x -> Ok x | Error x -> Error (v1986 x)
                                let _v1987 = v1994 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v1995 : Result<US4, std_string_String> = match v1985 with Ok x -> Ok x | Error x -> Error (v1986 x)
                                let _v1987 = v1995 
                                #endif
#else
                                let v1996 : Result<US4, std_string_String> = match v1985 with Ok x -> Ok x | Error x -> Error (v1986 x)
                                let _v1987 = v1996 
                                #endif
                                let v1997 : Result<US4, std_string_String> = _v1987 
                                let v2000 : US6 = match v1997 with Ok x -> v186 x | Error x -> v187 x
                                match v2000 with
                                | US6_1(v2168) -> (* Error *)
                                    let v2169 : unit = ()
                                    let v2170 : (unit -> unit) = closure35(v2168)
                                    let v2171 : unit = (fun () -> v2170 (); v2169) ()
                                    let v2284 : uint8 = 8uy
                                    let v2285 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v2284)
                                    let v2286 : string = "v2285.await"
                                    let v2287 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v2286 
                                    let v2288 : (anyhow_Error -> std_string_String) = method42()
                                    let v2289 : unit = ()
                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                    let v2290 : string = "$0.map_err(|x| $1(x))"
                                    let v2291 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2287, v2288) v2290 
                                    let _v2289 = v2291 
                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                    let v2292 : string = "$0.map_err(|x| $1(x))"
                                    let v2293 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2287, v2288) v2292 
                                    let _v2289 = v2293 
                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                    let v2294 : string = "$0.map_err(|x| $1(x))"
                                    let v2295 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2287, v2288) v2294 
                                    let _v2289 = v2295 
                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                    let v2296 : Result<US4, std_string_String> = match v2287 with Ok x -> Ok x | Error x -> Error (v2288 x)
                                    let _v2289 = v2296 
                                    #endif
#if FABLE_COMPILER_PYTHON
                                    let v2297 : Result<US4, std_string_String> = match v2287 with Ok x -> Ok x | Error x -> Error (v2288 x)
                                    let _v2289 = v2297 
                                    #endif
#else
                                    let v2298 : Result<US4, std_string_String> = match v2287 with Ok x -> Ok x | Error x -> Error (v2288 x)
                                    let _v2289 = v2298 
                                    #endif
                                    let v2299 : Result<US4, std_string_String> = _v2289 
                                    let v2302 : US6 = match v2299 with Ok x -> v186 x | Error x -> v187 x
                                    match v2302 with
                                    | US6_1(v2470) -> (* Error *)
                                        let v2471 : unit = ()
                                        let v2472 : (unit -> unit) = closure36(v2470)
                                        let v2473 : unit = (fun () -> v2472 (); v2471) ()
                                        let v2586 : uint8 = 9uy
                                        let v2587 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v2586)
                                        let v2588 : string = "v2587.await"
                                        let v2589 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v2588 
                                        let v2590 : (anyhow_Error -> std_string_String) = method42()
                                        let v2591 : unit = ()
                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                        let v2592 : string = "$0.map_err(|x| $1(x))"
                                        let v2593 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2589, v2590) v2592 
                                        let _v2591 = v2593 
                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                        let v2594 : string = "$0.map_err(|x| $1(x))"
                                        let v2595 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2589, v2590) v2594 
                                        let _v2591 = v2595 
                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                        let v2596 : string = "$0.map_err(|x| $1(x))"
                                        let v2597 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2589, v2590) v2596 
                                        let _v2591 = v2597 
                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                        let v2598 : Result<US4, std_string_String> = match v2589 with Ok x -> Ok x | Error x -> Error (v2590 x)
                                        let _v2591 = v2598 
                                        #endif
#if FABLE_COMPILER_PYTHON
                                        let v2599 : Result<US4, std_string_String> = match v2589 with Ok x -> Ok x | Error x -> Error (v2590 x)
                                        let _v2591 = v2599 
                                        #endif
#else
                                        let v2600 : Result<US4, std_string_String> = match v2589 with Ok x -> Ok x | Error x -> Error (v2590 x)
                                        let _v2591 = v2600 
                                        #endif
                                        let v2601 : Result<US4, std_string_String> = _v2591 
                                        let v2604 : US6 = match v2601 with Ok x -> v186 x | Error x -> v187 x
                                        match v2604 with
                                        | US6_1(v2772) -> (* Error *)
                                            let v2773 : unit = ()
                                            let v2774 : (unit -> unit) = closure37(v2772)
                                            let v2775 : unit = (fun () -> v2774 (); v2773) ()
                                            let v2888 : uint8 = 10uy
                                            let v2889 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v2888)
                                            let v2890 : string = "v2889.await"
                                            let v2891 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v2890 
                                            let v2892 : (anyhow_Error -> std_string_String) = method42()
                                            let v2893 : unit = ()
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v2894 : string = "$0.map_err(|x| $1(x))"
                                            let v2895 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2891, v2892) v2894 
                                            let _v2893 = v2895 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v2896 : string = "$0.map_err(|x| $1(x))"
                                            let v2897 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2891, v2892) v2896 
                                            let _v2893 = v2897 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v2898 : string = "$0.map_err(|x| $1(x))"
                                            let v2899 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v2891, v2892) v2898 
                                            let _v2893 = v2899 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v2900 : Result<US4, std_string_String> = match v2891 with Ok x -> Ok x | Error x -> Error (v2892 x)
                                            let _v2893 = v2900 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v2901 : Result<US4, std_string_String> = match v2891 with Ok x -> Ok x | Error x -> Error (v2892 x)
                                            let _v2893 = v2901 
                                            #endif
#else
                                            let v2902 : Result<US4, std_string_String> = match v2891 with Ok x -> Ok x | Error x -> Error (v2892 x)
                                            let _v2893 = v2902 
                                            #endif
                                            let v2903 : Result<US4, std_string_String> = _v2893 
                                            let v2906 : US6 = match v2903 with Ok x -> v186 x | Error x -> v187 x
                                            match v2906 with
                                            | US6_1(v3074) -> (* Error *)
                                                let v3075 : unit = ()
                                                let v3076 : (unit -> unit) = closure38(v3074)
                                                let v3077 : unit = (fun () -> v3076 (); v3075) ()
                                                let v3190 : uint8 = 11uy
                                                let v3191 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v3190)
                                                let v3192 : string = "v3191.await"
                                                let v3193 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3192 
                                                let v3194 : (anyhow_Error -> std_string_String) = method42()
                                                let v3195 : unit = ()
                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                let v3196 : string = "$0.map_err(|x| $1(x))"
                                                let v3197 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3193, v3194) v3196 
                                                let _v3195 = v3197 
                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                let v3198 : string = "$0.map_err(|x| $1(x))"
                                                let v3199 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3193, v3194) v3198 
                                                let _v3195 = v3199 
                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                let v3200 : string = "$0.map_err(|x| $1(x))"
                                                let v3201 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3193, v3194) v3200 
                                                let _v3195 = v3201 
                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                let v3202 : Result<US4, std_string_String> = match v3193 with Ok x -> Ok x | Error x -> Error (v3194 x)
                                                let _v3195 = v3202 
                                                #endif
#if FABLE_COMPILER_PYTHON
                                                let v3203 : Result<US4, std_string_String> = match v3193 with Ok x -> Ok x | Error x -> Error (v3194 x)
                                                let _v3195 = v3203 
                                                #endif
#else
                                                let v3204 : Result<US4, std_string_String> = match v3193 with Ok x -> Ok x | Error x -> Error (v3194 x)
                                                let _v3195 = v3204 
                                                #endif
                                                let v3205 : Result<US4, std_string_String> = _v3195 
                                                let v3208 : US6 = match v3205 with Ok x -> v186 x | Error x -> v187 x
                                                match v3208 with
                                                | US6_1(v3376) -> (* Error *)
                                                    let v3377 : unit = ()
                                                    let v3378 : (unit -> unit) = closure39(v3376)
                                                    let v3379 : unit = (fun () -> v3378 (); v3377) ()
                                                    let v3492 : uint8 = 12uy
                                                    let v3493 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v3492)
                                                    let v3494 : string = "v3493.await"
                                                    let v3495 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3494 
                                                    let v3496 : (anyhow_Error -> std_string_String) = method42()
                                                    let v3497 : unit = ()
                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                    let v3498 : string = "$0.map_err(|x| $1(x))"
                                                    let v3499 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3495, v3496) v3498 
                                                    let _v3497 = v3499 
                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                    let v3500 : string = "$0.map_err(|x| $1(x))"
                                                    let v3501 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3495, v3496) v3500 
                                                    let _v3497 = v3501 
                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                    let v3502 : string = "$0.map_err(|x| $1(x))"
                                                    let v3503 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3495, v3496) v3502 
                                                    let _v3497 = v3503 
                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                    let v3504 : Result<US4, std_string_String> = match v3495 with Ok x -> Ok x | Error x -> Error (v3496 x)
                                                    let _v3497 = v3504 
                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                    let v3505 : Result<US4, std_string_String> = match v3495 with Ok x -> Ok x | Error x -> Error (v3496 x)
                                                    let _v3497 = v3505 
                                                    #endif
#else
                                                    let v3506 : Result<US4, std_string_String> = match v3495 with Ok x -> Ok x | Error x -> Error (v3496 x)
                                                    let _v3497 = v3506 
                                                    #endif
                                                    let v3507 : Result<US4, std_string_String> = _v3497 
                                                    let v3510 : US6 = match v3507 with Ok x -> v186 x | Error x -> v187 x
                                                    match v3510 with
                                                    | US6_1(v3678) -> (* Error *)
                                                        let v3679 : unit = ()
                                                        let v3680 : (unit -> unit) = closure40(v3678)
                                                        let v3681 : unit = (fun () -> v3680 (); v3679) ()
                                                        let v3794 : uint8 = 13uy
                                                        let v3795 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v3794)
                                                        let v3796 : string = "v3795.await"
                                                        let v3797 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v3796 
                                                        let v3798 : (anyhow_Error -> std_string_String) = method42()
                                                        let v3799 : unit = ()
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v3800 : string = "$0.map_err(|x| $1(x))"
                                                        let v3801 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3797, v3798) v3800 
                                                        let _v3799 = v3801 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v3802 : string = "$0.map_err(|x| $1(x))"
                                                        let v3803 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3797, v3798) v3802 
                                                        let _v3799 = v3803 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v3804 : string = "$0.map_err(|x| $1(x))"
                                                        let v3805 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v3797, v3798) v3804 
                                                        let _v3799 = v3805 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v3806 : Result<US4, std_string_String> = match v3797 with Ok x -> Ok x | Error x -> Error (v3798 x)
                                                        let _v3799 = v3806 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v3807 : Result<US4, std_string_String> = match v3797 with Ok x -> Ok x | Error x -> Error (v3798 x)
                                                        let _v3799 = v3807 
                                                        #endif
#else
                                                        let v3808 : Result<US4, std_string_String> = match v3797 with Ok x -> Ok x | Error x -> Error (v3798 x)
                                                        let _v3799 = v3808 
                                                        #endif
                                                        let v3809 : Result<US4, std_string_String> = _v3799 
                                                        let v3812 : US6 = match v3809 with Ok x -> v186 x | Error x -> v187 x
                                                        match v3812 with
                                                        | US6_1(v3980) -> (* Error *)
                                                            let v3981 : unit = ()
                                                            let v3982 : (unit -> unit) = closure41(v3980)
                                                            let v3983 : unit = (fun () -> v3982 (); v3981) ()
                                                            let v4096 : uint8 = 14uy
                                                            let v4097 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v4096)
                                                            let v4098 : string = "v4097.await"
                                                            let v4099 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v4098 
                                                            let v4100 : (anyhow_Error -> std_string_String) = method42()
                                                            let v4101 : unit = ()
                                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                            let v4102 : string = "$0.map_err(|x| $1(x))"
                                                            let v4103 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4099, v4100) v4102 
                                                            let _v4101 = v4103 
                                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                                            let v4104 : string = "$0.map_err(|x| $1(x))"
                                                            let v4105 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4099, v4100) v4104 
                                                            let _v4101 = v4105 
                                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                            let v4106 : string = "$0.map_err(|x| $1(x))"
                                                            let v4107 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4099, v4100) v4106 
                                                            let _v4101 = v4107 
                                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                            let v4108 : Result<US4, std_string_String> = match v4099 with Ok x -> Ok x | Error x -> Error (v4100 x)
                                                            let _v4101 = v4108 
                                                            #endif
#if FABLE_COMPILER_PYTHON
                                                            let v4109 : Result<US4, std_string_String> = match v4099 with Ok x -> Ok x | Error x -> Error (v4100 x)
                                                            let _v4101 = v4109 
                                                            #endif
#else
                                                            let v4110 : Result<US4, std_string_String> = match v4099 with Ok x -> Ok x | Error x -> Error (v4100 x)
                                                            let _v4101 = v4110 
                                                            #endif
                                                            let v4111 : Result<US4, std_string_String> = _v4101 
                                                            let v4114 : US6 = match v4111 with Ok x -> v186 x | Error x -> v187 x
                                                            match v4114 with
                                                            | US6_1(v4282) -> (* Error *)
                                                                let v4283 : unit = ()
                                                                let v4284 : (unit -> unit) = closure42(v4282)
                                                                let v4285 : unit = (fun () -> v4284 (); v4283) ()
                                                                let v4398 : uint8 = 15uy
                                                                let v4399 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v4398)
                                                                let v4400 : string = "v4399.await"
                                                                let v4401 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v4400 
                                                                let v4402 : (anyhow_Error -> std_string_String) = method42()
                                                                let v4403 : unit = ()
                                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                let v4404 : string = "$0.map_err(|x| $1(x))"
                                                                let v4405 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4401, v4402) v4404 
                                                                let _v4403 = v4405 
                                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                                let v4406 : string = "$0.map_err(|x| $1(x))"
                                                                let v4407 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4401, v4402) v4406 
                                                                let _v4403 = v4407 
                                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                let v4408 : string = "$0.map_err(|x| $1(x))"
                                                                let v4409 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4401, v4402) v4408 
                                                                let _v4403 = v4409 
                                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                let v4410 : Result<US4, std_string_String> = match v4401 with Ok x -> Ok x | Error x -> Error (v4402 x)
                                                                let _v4403 = v4410 
                                                                #endif
#if FABLE_COMPILER_PYTHON
                                                                let v4411 : Result<US4, std_string_String> = match v4401 with Ok x -> Ok x | Error x -> Error (v4402 x)
                                                                let _v4403 = v4411 
                                                                #endif
#else
                                                                let v4412 : Result<US4, std_string_String> = match v4401 with Ok x -> Ok x | Error x -> Error (v4402 x)
                                                                let _v4403 = v4412 
                                                                #endif
                                                                let v4413 : Result<US4, std_string_String> = _v4403 
                                                                let v4416 : US6 = match v4413 with Ok x -> v186 x | Error x -> v187 x
                                                                match v4416 with
                                                                | US6_1(v4584) -> (* Error *)
                                                                    let v4585 : unit = ()
                                                                    let v4586 : (unit -> unit) = closure43(v4584)
                                                                    let v4587 : unit = (fun () -> v4586 (); v4585) ()
                                                                    let v4700 : uint8 = 16uy
                                                                    let v4701 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v4700)
                                                                    let v4702 : string = "v4701.await"
                                                                    let v4703 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v4702 
                                                                    let v4704 : (anyhow_Error -> std_string_String) = method42()
                                                                    let v4705 : unit = ()
                                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                    let v4706 : string = "$0.map_err(|x| $1(x))"
                                                                    let v4707 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4703, v4704) v4706 
                                                                    let _v4705 = v4707 
                                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                                    let v4708 : string = "$0.map_err(|x| $1(x))"
                                                                    let v4709 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4703, v4704) v4708 
                                                                    let _v4705 = v4709 
                                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                    let v4710 : string = "$0.map_err(|x| $1(x))"
                                                                    let v4711 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v4703, v4704) v4710 
                                                                    let _v4705 = v4711 
                                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                    let v4712 : Result<US4, std_string_String> = match v4703 with Ok x -> Ok x | Error x -> Error (v4704 x)
                                                                    let _v4705 = v4712 
                                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                                    let v4713 : Result<US4, std_string_String> = match v4703 with Ok x -> Ok x | Error x -> Error (v4704 x)
                                                                    let _v4705 = v4713 
                                                                    #endif
#else
                                                                    let v4714 : Result<US4, std_string_String> = match v4703 with Ok x -> Ok x | Error x -> Error (v4704 x)
                                                                    let _v4705 = v4714 
                                                                    #endif
                                                                    let v4715 : Result<US4, std_string_String> = _v4705 
                                                                    let v4718 : US6 = match v4715 with Ok x -> v186 x | Error x -> v187 x
                                                                    match v4718 with
                                                                    | US6_1(v4886) -> (* Error *)
                                                                        let v4887 : unit = ()
                                                                        let v4888 : (unit -> unit) = closure44(v4886)
                                                                        let v4889 : unit = (fun () -> v4888 (); v4887) ()
                                                                        let v5002 : uint8 = 17uy
                                                                        let v5003 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v5002)
                                                                        let v5004 : string = "v5003.await"
                                                                        let v5005 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5004 
                                                                        let v5006 : (anyhow_Error -> std_string_String) = method42()
                                                                        let v5007 : unit = ()
                                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                        let v5008 : string = "$0.map_err(|x| $1(x))"
                                                                        let v5009 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5005, v5006) v5008 
                                                                        let _v5007 = v5009 
                                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                                        let v5010 : string = "$0.map_err(|x| $1(x))"
                                                                        let v5011 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5005, v5006) v5010 
                                                                        let _v5007 = v5011 
                                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                        let v5012 : string = "$0.map_err(|x| $1(x))"
                                                                        let v5013 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5005, v5006) v5012 
                                                                        let _v5007 = v5013 
                                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                        let v5014 : Result<US4, std_string_String> = match v5005 with Ok x -> Ok x | Error x -> Error (v5006 x)
                                                                        let _v5007 = v5014 
                                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                                        let v5015 : Result<US4, std_string_String> = match v5005 with Ok x -> Ok x | Error x -> Error (v5006 x)
                                                                        let _v5007 = v5015 
                                                                        #endif
#else
                                                                        let v5016 : Result<US4, std_string_String> = match v5005 with Ok x -> Ok x | Error x -> Error (v5006 x)
                                                                        let _v5007 = v5016 
                                                                        #endif
                                                                        let v5017 : Result<US4, std_string_String> = _v5007 
                                                                        let v5020 : US6 = match v5017 with Ok x -> v186 x | Error x -> v187 x
                                                                        match v5020 with
                                                                        | US6_1(v5188) -> (* Error *)
                                                                            let v5189 : unit = ()
                                                                            let v5190 : (unit -> unit) = closure45(v5188)
                                                                            let v5191 : unit = (fun () -> v5190 (); v5189) ()
                                                                            let v5304 : uint8 = 18uy
                                                                            let v5305 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v5304)
                                                                            let v5306 : string = "v5305.await"
                                                                            let v5307 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5306 
                                                                            let v5308 : (anyhow_Error -> std_string_String) = method42()
                                                                            let v5309 : unit = ()
                                                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                            let v5310 : string = "$0.map_err(|x| $1(x))"
                                                                            let v5311 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5307, v5308) v5310 
                                                                            let _v5309 = v5311 
                                                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                                                            let v5312 : string = "$0.map_err(|x| $1(x))"
                                                                            let v5313 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5307, v5308) v5312 
                                                                            let _v5309 = v5313 
                                                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                            let v5314 : string = "$0.map_err(|x| $1(x))"
                                                                            let v5315 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5307, v5308) v5314 
                                                                            let _v5309 = v5315 
                                                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                            let v5316 : Result<US4, std_string_String> = match v5307 with Ok x -> Ok x | Error x -> Error (v5308 x)
                                                                            let _v5309 = v5316 
                                                                            #endif
#if FABLE_COMPILER_PYTHON
                                                                            let v5317 : Result<US4, std_string_String> = match v5307 with Ok x -> Ok x | Error x -> Error (v5308 x)
                                                                            let _v5309 = v5317 
                                                                            #endif
#else
                                                                            let v5318 : Result<US4, std_string_String> = match v5307 with Ok x -> Ok x | Error x -> Error (v5308 x)
                                                                            let _v5309 = v5318 
                                                                            #endif
                                                                            let v5319 : Result<US4, std_string_String> = _v5309 
                                                                            let v5322 : US6 = match v5319 with Ok x -> v186 x | Error x -> v187 x
                                                                            match v5322 with
                                                                            | US6_1(v5490) -> (* Error *)
                                                                                let v5491 : unit = ()
                                                                                let v5492 : (unit -> unit) = closure46(v5490)
                                                                                let v5493 : unit = (fun () -> v5492 (); v5491) ()
                                                                                let v5606 : uint8 = 19uy
                                                                                let v5607 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v5606)
                                                                                let v5608 : string = "v5607.await"
                                                                                let v5609 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5608 
                                                                                let v5610 : (anyhow_Error -> std_string_String) = method42()
                                                                                let v5611 : unit = ()
                                                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                let v5612 : string = "$0.map_err(|x| $1(x))"
                                                                                let v5613 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5609, v5610) v5612 
                                                                                let _v5611 = v5613 
                                                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                let v5614 : string = "$0.map_err(|x| $1(x))"
                                                                                let v5615 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5609, v5610) v5614 
                                                                                let _v5611 = v5615 
                                                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                let v5616 : string = "$0.map_err(|x| $1(x))"
                                                                                let v5617 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5609, v5610) v5616 
                                                                                let _v5611 = v5617 
                                                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                let v5618 : Result<US4, std_string_String> = match v5609 with Ok x -> Ok x | Error x -> Error (v5610 x)
                                                                                let _v5611 = v5618 
                                                                                #endif
#if FABLE_COMPILER_PYTHON
                                                                                let v5619 : Result<US4, std_string_String> = match v5609 with Ok x -> Ok x | Error x -> Error (v5610 x)
                                                                                let _v5611 = v5619 
                                                                                #endif
#else
                                                                                let v5620 : Result<US4, std_string_String> = match v5609 with Ok x -> Ok x | Error x -> Error (v5610 x)
                                                                                let _v5611 = v5620 
                                                                                #endif
                                                                                let v5621 : Result<US4, std_string_String> = _v5611 
                                                                                let v5624 : US6 = match v5621 with Ok x -> v186 x | Error x -> v187 x
                                                                                match v5624 with
                                                                                | US6_1(v5792) -> (* Error *)
                                                                                    let v5793 : unit = ()
                                                                                    let v5794 : (unit -> unit) = closure47(v5792)
                                                                                    let v5795 : unit = (fun () -> v5794 (); v5793) ()
                                                                                    let v5908 : uint8 = 20uy
                                                                                    let v5909 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v5908)
                                                                                    let v5910 : string = "v5909.await"
                                                                                    let v5911 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5910 
                                                                                    let v5912 : (anyhow_Error -> std_string_String) = method42()
                                                                                    let v5913 : unit = ()
                                                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                    let v5914 : string = "$0.map_err(|x| $1(x))"
                                                                                    let v5915 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5911, v5912) v5914 
                                                                                    let _v5913 = v5915 
                                                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                    let v5916 : string = "$0.map_err(|x| $1(x))"
                                                                                    let v5917 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5911, v5912) v5916 
                                                                                    let _v5913 = v5917 
                                                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                    let v5918 : string = "$0.map_err(|x| $1(x))"
                                                                                    let v5919 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v5911, v5912) v5918 
                                                                                    let _v5913 = v5919 
                                                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                    let v5920 : Result<US4, std_string_String> = match v5911 with Ok x -> Ok x | Error x -> Error (v5912 x)
                                                                                    let _v5913 = v5920 
                                                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                                                    let v5921 : Result<US4, std_string_String> = match v5911 with Ok x -> Ok x | Error x -> Error (v5912 x)
                                                                                    let _v5913 = v5921 
                                                                                    #endif
#else
                                                                                    let v5922 : Result<US4, std_string_String> = match v5911 with Ok x -> Ok x | Error x -> Error (v5912 x)
                                                                                    let _v5913 = v5922 
                                                                                    #endif
                                                                                    let v5923 : Result<US4, std_string_String> = _v5913 
                                                                                    let v5926 : US6 = match v5923 with Ok x -> v186 x | Error x -> v187 x
                                                                                    match v5926 with
                                                                                    | US6_1(v6094) -> (* Error *)
                                                                                        let v6095 : unit = ()
                                                                                        let v6096 : (unit -> unit) = closure48(v6094)
                                                                                        let v6097 : unit = (fun () -> v6096 (); v6095) ()
                                                                                        let v6210 : uint8 = 21uy
                                                                                        let v6211 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v6210)
                                                                                        let v6212 : string = "v6211.await"
                                                                                        let v6213 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6212 
                                                                                        let v6214 : (anyhow_Error -> std_string_String) = method42()
                                                                                        let v6215 : unit = ()
                                                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                        let v6216 : string = "$0.map_err(|x| $1(x))"
                                                                                        let v6217 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6213, v6214) v6216 
                                                                                        let _v6215 = v6217 
                                                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                        let v6218 : string = "$0.map_err(|x| $1(x))"
                                                                                        let v6219 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6213, v6214) v6218 
                                                                                        let _v6215 = v6219 
                                                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                        let v6220 : string = "$0.map_err(|x| $1(x))"
                                                                                        let v6221 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6213, v6214) v6220 
                                                                                        let _v6215 = v6221 
                                                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                        let v6222 : Result<US4, std_string_String> = match v6213 with Ok x -> Ok x | Error x -> Error (v6214 x)
                                                                                        let _v6215 = v6222 
                                                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                                                        let v6223 : Result<US4, std_string_String> = match v6213 with Ok x -> Ok x | Error x -> Error (v6214 x)
                                                                                        let _v6215 = v6223 
                                                                                        #endif
#else
                                                                                        let v6224 : Result<US4, std_string_String> = match v6213 with Ok x -> Ok x | Error x -> Error (v6214 x)
                                                                                        let _v6215 = v6224 
                                                                                        #endif
                                                                                        let v6225 : Result<US4, std_string_String> = _v6215 
                                                                                        let v6228 : US6 = match v6225 with Ok x -> v186 x | Error x -> v187 x
                                                                                        match v6228 with
                                                                                        | US6_1(v6396) -> (* Error *)
                                                                                            let v6397 : unit = ()
                                                                                            let v6398 : (unit -> unit) = closure49(v6396)
                                                                                            let v6399 : unit = (fun () -> v6398 (); v6397) ()
                                                                                            let v6512 : uint8 = 22uy
                                                                                            let v6513 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v6512)
                                                                                            let v6514 : string = "v6513.await"
                                                                                            let v6515 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6514 
                                                                                            let v6516 : (anyhow_Error -> std_string_String) = method42()
                                                                                            let v6517 : unit = ()
                                                                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                            let v6518 : string = "$0.map_err(|x| $1(x))"
                                                                                            let v6519 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6515, v6516) v6518 
                                                                                            let _v6517 = v6519 
                                                                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                            let v6520 : string = "$0.map_err(|x| $1(x))"
                                                                                            let v6521 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6515, v6516) v6520 
                                                                                            let _v6517 = v6521 
                                                                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                            let v6522 : string = "$0.map_err(|x| $1(x))"
                                                                                            let v6523 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6515, v6516) v6522 
                                                                                            let _v6517 = v6523 
                                                                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                            let v6524 : Result<US4, std_string_String> = match v6515 with Ok x -> Ok x | Error x -> Error (v6516 x)
                                                                                            let _v6517 = v6524 
                                                                                            #endif
#if FABLE_COMPILER_PYTHON
                                                                                            let v6525 : Result<US4, std_string_String> = match v6515 with Ok x -> Ok x | Error x -> Error (v6516 x)
                                                                                            let _v6517 = v6525 
                                                                                            #endif
#else
                                                                                            let v6526 : Result<US4, std_string_String> = match v6515 with Ok x -> Ok x | Error x -> Error (v6516 x)
                                                                                            let _v6517 = v6526 
                                                                                            #endif
                                                                                            let v6527 : Result<US4, std_string_String> = _v6517 
                                                                                            let v6530 : US6 = match v6527 with Ok x -> v186 x | Error x -> v187 x
                                                                                            match v6530 with
                                                                                            | US6_1(v6698) -> (* Error *)
                                                                                                let v6699 : unit = ()
                                                                                                let v6700 : (unit -> unit) = closure50(v6698)
                                                                                                let v6701 : unit = (fun () -> v6700 (); v6699) ()
                                                                                                let v6814 : uint8 = 23uy
                                                                                                let v6815 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v6814)
                                                                                                let v6816 : string = "v6815.await"
                                                                                                let v6817 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v6816 
                                                                                                let v6818 : (anyhow_Error -> std_string_String) = method42()
                                                                                                let v6819 : unit = ()
                                                                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                let v6820 : string = "$0.map_err(|x| $1(x))"
                                                                                                let v6821 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6817, v6818) v6820 
                                                                                                let _v6819 = v6821 
                                                                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                let v6822 : string = "$0.map_err(|x| $1(x))"
                                                                                                let v6823 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6817, v6818) v6822 
                                                                                                let _v6819 = v6823 
                                                                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                let v6824 : string = "$0.map_err(|x| $1(x))"
                                                                                                let v6825 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6817, v6818) v6824 
                                                                                                let _v6819 = v6825 
                                                                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                let v6826 : Result<US4, std_string_String> = match v6817 with Ok x -> Ok x | Error x -> Error (v6818 x)
                                                                                                let _v6819 = v6826 
                                                                                                #endif
#if FABLE_COMPILER_PYTHON
                                                                                                let v6827 : Result<US4, std_string_String> = match v6817 with Ok x -> Ok x | Error x -> Error (v6818 x)
                                                                                                let _v6819 = v6827 
                                                                                                #endif
#else
                                                                                                let v6828 : Result<US4, std_string_String> = match v6817 with Ok x -> Ok x | Error x -> Error (v6818 x)
                                                                                                let _v6819 = v6828 
                                                                                                #endif
                                                                                                let v6829 : Result<US4, std_string_String> = _v6819 
                                                                                                let v6832 : US6 = match v6829 with Ok x -> v186 x | Error x -> v187 x
                                                                                                match v6832 with
                                                                                                | US6_1(v7000) -> (* Error *)
                                                                                                    let v7001 : unit = ()
                                                                                                    let v7002 : (unit -> unit) = closure51(v7000)
                                                                                                    let v7003 : unit = (fun () -> v7002 (); v7001) ()
                                                                                                    let v7116 : uint8 = 24uy
                                                                                                    let v7117 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v7116)
                                                                                                    let v7118 : string = "v7117.await"
                                                                                                    let v7119 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7118 
                                                                                                    let v7120 : (anyhow_Error -> std_string_String) = method42()
                                                                                                    let v7121 : unit = ()
                                                                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                    let v7122 : string = "$0.map_err(|x| $1(x))"
                                                                                                    let v7123 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7119, v7120) v7122 
                                                                                                    let _v7121 = v7123 
                                                                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                    let v7124 : string = "$0.map_err(|x| $1(x))"
                                                                                                    let v7125 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7119, v7120) v7124 
                                                                                                    let _v7121 = v7125 
                                                                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                    let v7126 : string = "$0.map_err(|x| $1(x))"
                                                                                                    let v7127 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7119, v7120) v7126 
                                                                                                    let _v7121 = v7127 
                                                                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                    let v7128 : Result<US4, std_string_String> = match v7119 with Ok x -> Ok x | Error x -> Error (v7120 x)
                                                                                                    let _v7121 = v7128 
                                                                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                                                                    let v7129 : Result<US4, std_string_String> = match v7119 with Ok x -> Ok x | Error x -> Error (v7120 x)
                                                                                                    let _v7121 = v7129 
                                                                                                    #endif
#else
                                                                                                    let v7130 : Result<US4, std_string_String> = match v7119 with Ok x -> Ok x | Error x -> Error (v7120 x)
                                                                                                    let _v7121 = v7130 
                                                                                                    #endif
                                                                                                    let v7131 : Result<US4, std_string_String> = _v7121 
                                                                                                    let v7134 : US6 = match v7131 with Ok x -> v186 x | Error x -> v187 x
                                                                                                    match v7134 with
                                                                                                    | US6_1(v7302) -> (* Error *)
                                                                                                        let v7303 : unit = ()
                                                                                                        let v7304 : (unit -> unit) = closure52(v7302)
                                                                                                        let v7305 : unit = (fun () -> v7304 (); v7303) ()
                                                                                                        let v7418 : uint8 = 25uy
                                                                                                        let v7419 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v7418)
                                                                                                        let v7420 : string = "v7419.await"
                                                                                                        let v7421 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7420 
                                                                                                        let v7422 : (anyhow_Error -> std_string_String) = method42()
                                                                                                        let v7423 : unit = ()
                                                                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                        let v7424 : string = "$0.map_err(|x| $1(x))"
                                                                                                        let v7425 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7421, v7422) v7424 
                                                                                                        let _v7423 = v7425 
                                                                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                        let v7426 : string = "$0.map_err(|x| $1(x))"
                                                                                                        let v7427 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7421, v7422) v7426 
                                                                                                        let _v7423 = v7427 
                                                                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                        let v7428 : string = "$0.map_err(|x| $1(x))"
                                                                                                        let v7429 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7421, v7422) v7428 
                                                                                                        let _v7423 = v7429 
                                                                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                        let v7430 : Result<US4, std_string_String> = match v7421 with Ok x -> Ok x | Error x -> Error (v7422 x)
                                                                                                        let _v7423 = v7430 
                                                                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                                                                        let v7431 : Result<US4, std_string_String> = match v7421 with Ok x -> Ok x | Error x -> Error (v7422 x)
                                                                                                        let _v7423 = v7431 
                                                                                                        #endif
#else
                                                                                                        let v7432 : Result<US4, std_string_String> = match v7421 with Ok x -> Ok x | Error x -> Error (v7422 x)
                                                                                                        let _v7423 = v7432 
                                                                                                        #endif
                                                                                                        let v7433 : Result<US4, std_string_String> = _v7423 
                                                                                                        let v7436 : US6 = match v7433 with Ok x -> v186 x | Error x -> v187 x
                                                                                                        match v7436 with
                                                                                                        | US6_1(v7604) -> (* Error *)
                                                                                                            let v7605 : unit = ()
                                                                                                            let v7606 : (unit -> unit) = closure53(v7604)
                                                                                                            let v7607 : unit = (fun () -> v7606 (); v7605) ()
                                                                                                            let v7720 : uint8 = 26uy
                                                                                                            let v7721 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v7720)
                                                                                                            let v7722 : string = "v7721.await"
                                                                                                            let v7723 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7722 
                                                                                                            let v7724 : (anyhow_Error -> std_string_String) = method42()
                                                                                                            let v7725 : unit = ()
                                                                                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                            let v7726 : string = "$0.map_err(|x| $1(x))"
                                                                                                            let v7727 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7723, v7724) v7726 
                                                                                                            let _v7725 = v7727 
                                                                                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                            let v7728 : string = "$0.map_err(|x| $1(x))"
                                                                                                            let v7729 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7723, v7724) v7728 
                                                                                                            let _v7725 = v7729 
                                                                                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                            let v7730 : string = "$0.map_err(|x| $1(x))"
                                                                                                            let v7731 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v7723, v7724) v7730 
                                                                                                            let _v7725 = v7731 
                                                                                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                            let v7732 : Result<US4, std_string_String> = match v7723 with Ok x -> Ok x | Error x -> Error (v7724 x)
                                                                                                            let _v7725 = v7732 
                                                                                                            #endif
#if FABLE_COMPILER_PYTHON
                                                                                                            let v7733 : Result<US4, std_string_String> = match v7723 with Ok x -> Ok x | Error x -> Error (v7724 x)
                                                                                                            let _v7725 = v7733 
                                                                                                            #endif
#else
                                                                                                            let v7734 : Result<US4, std_string_String> = match v7723 with Ok x -> Ok x | Error x -> Error (v7724 x)
                                                                                                            let _v7725 = v7734 
                                                                                                            #endif
                                                                                                            let v7735 : Result<US4, std_string_String> = _v7725 
                                                                                                            let v7738 : US6 = match v7735 with Ok x -> v186 x | Error x -> v187 x
                                                                                                            match v7738 with
                                                                                                            | US6_1(v7906) -> (* Error *)
                                                                                                                let v7907 : unit = ()
                                                                                                                let v7908 : (unit -> unit) = closure54(v7906)
                                                                                                                let v7909 : unit = (fun () -> v7908 (); v7907) ()
                                                                                                                let v8022 : uint8 = 27uy
                                                                                                                let v8023 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v8022)
                                                                                                                let v8024 : string = "v8023.await"
                                                                                                                let v8025 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v8024 
                                                                                                                let v8026 : (anyhow_Error -> std_string_String) = method42()
                                                                                                                let v8027 : unit = ()
                                                                                                                
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                                let v8028 : string = "$0.map_err(|x| $1(x))"
                                                                                                                let v8029 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8025, v8026) v8028 
                                                                                                                let _v8027 = v8029 
                                                                                                                #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                                let v8030 : string = "$0.map_err(|x| $1(x))"
                                                                                                                let v8031 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8025, v8026) v8030 
                                                                                                                let _v8027 = v8031 
                                                                                                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                                let v8032 : string = "$0.map_err(|x| $1(x))"
                                                                                                                let v8033 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8025, v8026) v8032 
                                                                                                                let _v8027 = v8033 
                                                                                                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                                let v8034 : Result<US4, std_string_String> = match v8025 with Ok x -> Ok x | Error x -> Error (v8026 x)
                                                                                                                let _v8027 = v8034 
                                                                                                                #endif
#if FABLE_COMPILER_PYTHON
                                                                                                                let v8035 : Result<US4, std_string_String> = match v8025 with Ok x -> Ok x | Error x -> Error (v8026 x)
                                                                                                                let _v8027 = v8035 
                                                                                                                #endif
#else
                                                                                                                let v8036 : Result<US4, std_string_String> = match v8025 with Ok x -> Ok x | Error x -> Error (v8026 x)
                                                                                                                let _v8027 = v8036 
                                                                                                                #endif
                                                                                                                let v8037 : Result<US4, std_string_String> = _v8027 
                                                                                                                let v8040 : US6 = match v8037 with Ok x -> v186 x | Error x -> v187 x
                                                                                                                match v8040 with
                                                                                                                | US6_1(v8208) -> (* Error *)
                                                                                                                    let v8209 : unit = ()
                                                                                                                    let v8210 : (unit -> unit) = closure55(v8208)
                                                                                                                    let v8211 : unit = (fun () -> v8210 (); v8209) ()
                                                                                                                    let v8324 : uint8 = 28uy
                                                                                                                    let v8325 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v8324)
                                                                                                                    let v8326 : string = "v8325.await"
                                                                                                                    let v8327 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v8326 
                                                                                                                    let v8328 : (anyhow_Error -> std_string_String) = method42()
                                                                                                                    let v8329 : unit = ()
                                                                                                                    
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                                    let v8330 : string = "$0.map_err(|x| $1(x))"
                                                                                                                    let v8331 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8327, v8328) v8330 
                                                                                                                    let _v8329 = v8331 
                                                                                                                    #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                                    let v8332 : string = "$0.map_err(|x| $1(x))"
                                                                                                                    let v8333 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8327, v8328) v8332 
                                                                                                                    let _v8329 = v8333 
                                                                                                                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                                    let v8334 : string = "$0.map_err(|x| $1(x))"
                                                                                                                    let v8335 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8327, v8328) v8334 
                                                                                                                    let _v8329 = v8335 
                                                                                                                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                                    let v8336 : Result<US4, std_string_String> = match v8327 with Ok x -> Ok x | Error x -> Error (v8328 x)
                                                                                                                    let _v8329 = v8336 
                                                                                                                    #endif
#if FABLE_COMPILER_PYTHON
                                                                                                                    let v8337 : Result<US4, std_string_String> = match v8327 with Ok x -> Ok x | Error x -> Error (v8328 x)
                                                                                                                    let _v8329 = v8337 
                                                                                                                    #endif
#else
                                                                                                                    let v8338 : Result<US4, std_string_String> = match v8327 with Ok x -> Ok x | Error x -> Error (v8328 x)
                                                                                                                    let _v8329 = v8338 
                                                                                                                    #endif
                                                                                                                    let v8339 : Result<US4, std_string_String> = _v8329 
                                                                                                                    let v8342 : US6 = match v8339 with Ok x -> v186 x | Error x -> v187 x
                                                                                                                    match v8342 with
                                                                                                                    | US6_1(v8510) -> (* Error *)
                                                                                                                        let v8511 : unit = ()
                                                                                                                        let v8512 : (unit -> unit) = closure56(v8510)
                                                                                                                        let v8513 : unit = (fun () -> v8512 (); v8511) ()
                                                                                                                        let v8626 : uint8 = 29uy
                                                                                                                        let v8627 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method24(v167, v8626)
                                                                                                                        let v8628 : string = "v8627.await"
                                                                                                                        let v8629 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v8628 
                                                                                                                        let v8630 : (anyhow_Error -> std_string_String) = method42()
                                                                                                                        let v8631 : unit = ()
                                                                                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                                                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                                                                                        let v8632 : string = "$0.map_err(|x| $1(x))"
                                                                                                                        let v8633 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8629, v8630) v8632 
                                                                                                                        let _v8631 = v8633 
                                                                                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                                                                                        let v8634 : string = "$0.map_err(|x| $1(x))"
                                                                                                                        let v8635 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8629, v8630) v8634 
                                                                                                                        let _v8631 = v8635 
                                                                                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                                                                                        let v8636 : string = "$0.map_err(|x| $1(x))"
                                                                                                                        let v8637 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v8629, v8630) v8636 
                                                                                                                        let _v8631 = v8637 
                                                                                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                                                                                        let v8638 : Result<US4, std_string_String> = match v8629 with Ok x -> Ok x | Error x -> Error (v8630 x)
                                                                                                                        let _v8631 = v8638 
                                                                                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                                                                                        let v8639 : Result<US4, std_string_String> = match v8629 with Ok x -> Ok x | Error x -> Error (v8630 x)
                                                                                                                        let _v8631 = v8639 
                                                                                                                        #endif
#else
                                                                                                                        let v8640 : Result<US4, std_string_String> = match v8629 with Ok x -> Ok x | Error x -> Error (v8630 x)
                                                                                                                        let _v8631 = v8640 
                                                                                                                        #endif
                                                                                                                        let v8641 : Result<US4, std_string_String> = _v8631 
                                                                                                                        let v8644 : US6 = match v8641 with Ok x -> v186 x | Error x -> v187 x
                                                                                                                        match v8644 with
                                                                                                                        | US6_1(v8812) -> (* Error *)
                                                                                                                            let v8813 : unit = ()
                                                                                                                            let v8814 : (unit -> unit) = closure57(v8812)
                                                                                                                            let v8815 : unit = (fun () -> v8814 (); v8813) ()
                                                                                                                            let v8928 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8929 : bool = Fable.Core.RustInterop.emitRustExpr () v8928 
                                                                                                                            let v8930 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8931 : bool = Fable.Core.RustInterop.emitRustExpr () v8930 
                                                                                                                            let v8932 : uint8 = method46()
                                                                                                                            let v8933 : string = ""
                                                                                                                            let v8934 : string = "}"
                                                                                                                            let v8935 : string = v8933 + v8934 
                                                                                                                            let v8936 : string = "true; v8932 " + v8935 + "); " + v8933 + " // rust.fix_closure'"
                                                                                                                            let v8937 : bool = Fable.Core.RustInterop.emitRustExpr () v8936 
                                                                                                                            let v8938 : string = "__future_init"
                                                                                                                            let v8939 : _ = Fable.Core.RustInterop.emitRustExpr () v8938 
                                                                                                                            let v8940 : string = "v8939"
                                                                                                                            let v8941 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8940 
                                                                                                                            let v8942 : string = "v8941.await"
                                                                                                                            let v8943 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8942 
                                                                                                                            let v8944 : US7 = method47(v8943)
                                                                                                                            let v8945 : string = v8933 + v8934 
                                                                                                                            let v8946 : string = "true; v8944 " + v8945 + "); " + v8933 + " // rust.fix_closure'"
                                                                                                                            let v8947 : bool = Fable.Core.RustInterop.emitRustExpr () v8946 
                                                                                                                            let v8948 : string = "__future_init"
                                                                                                                            let v8949 : _ = Fable.Core.RustInterop.emitRustExpr () v8948 
                                                                                                                            let v8950 : string = "v8949"
                                                                                                                            let v8951 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8950 
                                                                                                                            v8951
                                                                                                                        | US6_0(v8645) -> (* Ok *)
                                                                                                                            match v8645 with
                                                                                                                            | US4_1 -> (* None *)
                                                                                                                                let v8646 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8647 : bool = Fable.Core.RustInterop.emitRustExpr () v8646 
                                                                                                                                let v8648 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8649 : bool = Fable.Core.RustInterop.emitRustExpr () v8648 
                                                                                                                                let v8650 : uint8 = method48()
                                                                                                                                let v8651 : string = ""
                                                                                                                                let v8652 : string = "}"
                                                                                                                                let v8653 : string = v8651 + v8652 
                                                                                                                                let v8654 : string = "true; v8650 " + v8653 + "); " + v8651 + " // rust.fix_closure'"
                                                                                                                                let v8655 : bool = Fable.Core.RustInterop.emitRustExpr () v8654 
                                                                                                                                let v8656 : string = "__future_init"
                                                                                                                                let v8657 : _ = Fable.Core.RustInterop.emitRustExpr () v8656 
                                                                                                                                let v8658 : string = "v8657"
                                                                                                                                let v8659 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8658 
                                                                                                                                let v8660 : string = "v8659.await"
                                                                                                                                let v8661 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8660 
                                                                                                                                let v8662 : US7 = method49(v8661)
                                                                                                                                let v8663 : string = v8651 + v8652 
                                                                                                                                let v8664 : string = "true; v8662 " + v8663 + "); " + v8651 + " // rust.fix_closure'"
                                                                                                                                let v8665 : bool = Fable.Core.RustInterop.emitRustExpr () v8664 
                                                                                                                                let v8666 : string = "__future_init"
                                                                                                                                let v8667 : _ = Fable.Core.RustInterop.emitRustExpr () v8666 
                                                                                                                                let v8668 : string = "v8667"
                                                                                                                                let v8669 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8668 
                                                                                                                                v8669
                                                                                                                            | US4_0(v8670) -> (* Some *)
                                                                                                                                let v8671 : unit = ()
                                                                                                                                let v8672 : (unit -> unit) = closure58(v8670)
                                                                                                                                let v8673 : unit = (fun () -> v8672 (); v8671) ()
                                                                                                                                let v8786 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8787 : bool = Fable.Core.RustInterop.emitRustExpr () v8786 
                                                                                                                                let v8788 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                                let v8789 : bool = Fable.Core.RustInterop.emitRustExpr () v8788 
                                                                                                                                let v8790 : uint8 = method48()
                                                                                                                                let v8791 : string = ""
                                                                                                                                let v8792 : string = "}"
                                                                                                                                let v8793 : string = v8791 + v8792 
                                                                                                                                let v8794 : string = "true; v8790 " + v8793 + "); " + v8791 + " // rust.fix_closure'"
                                                                                                                                let v8795 : bool = Fable.Core.RustInterop.emitRustExpr () v8794 
                                                                                                                                let v8796 : string = "__future_init"
                                                                                                                                let v8797 : _ = Fable.Core.RustInterop.emitRustExpr () v8796 
                                                                                                                                let v8798 : string = "v8797"
                                                                                                                                let v8799 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8798 
                                                                                                                                let v8800 : string = "v8799.await"
                                                                                                                                let v8801 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8800 
                                                                                                                                let v8802 : US7 = method47(v8801)
                                                                                                                                let v8803 : string = v8791 + v8792 
                                                                                                                                let v8804 : string = "true; v8802 " + v8803 + "); " + v8791 + " // rust.fix_closure'"
                                                                                                                                let v8805 : bool = Fable.Core.RustInterop.emitRustExpr () v8804 
                                                                                                                                let v8806 : string = "__future_init"
                                                                                                                                let v8807 : _ = Fable.Core.RustInterop.emitRustExpr () v8806 
                                                                                                                                let v8808 : string = "v8807"
                                                                                                                                let v8809 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8808 
                                                                                                                                v8809
                                                                                                                    | US6_0(v8343) -> (* Ok *)
                                                                                                                        match v8343 with
                                                                                                                        | US4_1 -> (* None *)
                                                                                                                            let v8344 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8345 : bool = Fable.Core.RustInterop.emitRustExpr () v8344 
                                                                                                                            let v8346 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8347 : bool = Fable.Core.RustInterop.emitRustExpr () v8346 
                                                                                                                            let v8348 : uint8 = method53()
                                                                                                                            let v8349 : string = ""
                                                                                                                            let v8350 : string = "}"
                                                                                                                            let v8351 : string = v8349 + v8350 
                                                                                                                            let v8352 : string = "true; v8348 " + v8351 + "); " + v8349 + " // rust.fix_closure'"
                                                                                                                            let v8353 : bool = Fable.Core.RustInterop.emitRustExpr () v8352 
                                                                                                                            let v8354 : string = "__future_init"
                                                                                                                            let v8355 : _ = Fable.Core.RustInterop.emitRustExpr () v8354 
                                                                                                                            let v8356 : string = "v8355"
                                                                                                                            let v8357 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8356 
                                                                                                                            let v8358 : string = "v8357.await"
                                                                                                                            let v8359 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8358 
                                                                                                                            let v8360 : US7 = method49(v8359)
                                                                                                                            let v8361 : string = v8349 + v8350 
                                                                                                                            let v8362 : string = "true; v8360 " + v8361 + "); " + v8349 + " // rust.fix_closure'"
                                                                                                                            let v8363 : bool = Fable.Core.RustInterop.emitRustExpr () v8362 
                                                                                                                            let v8364 : string = "__future_init"
                                                                                                                            let v8365 : _ = Fable.Core.RustInterop.emitRustExpr () v8364 
                                                                                                                            let v8366 : string = "v8365"
                                                                                                                            let v8367 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8366 
                                                                                                                            v8367
                                                                                                                        | US4_0(v8368) -> (* Some *)
                                                                                                                            let v8369 : unit = ()
                                                                                                                            let v8370 : (unit -> unit) = closure59(v8368)
                                                                                                                            let v8371 : unit = (fun () -> v8370 (); v8369) ()
                                                                                                                            let v8484 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8485 : bool = Fable.Core.RustInterop.emitRustExpr () v8484 
                                                                                                                            let v8486 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                            let v8487 : bool = Fable.Core.RustInterop.emitRustExpr () v8486 
                                                                                                                            let v8488 : uint8 = method53()
                                                                                                                            let v8489 : string = ""
                                                                                                                            let v8490 : string = "}"
                                                                                                                            let v8491 : string = v8489 + v8490 
                                                                                                                            let v8492 : string = "true; v8488 " + v8491 + "); " + v8489 + " // rust.fix_closure'"
                                                                                                                            let v8493 : bool = Fable.Core.RustInterop.emitRustExpr () v8492 
                                                                                                                            let v8494 : string = "__future_init"
                                                                                                                            let v8495 : _ = Fable.Core.RustInterop.emitRustExpr () v8494 
                                                                                                                            let v8496 : string = "v8495"
                                                                                                                            let v8497 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8496 
                                                                                                                            let v8498 : string = "v8497.await"
                                                                                                                            let v8499 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8498 
                                                                                                                            let v8500 : US7 = method47(v8499)
                                                                                                                            let v8501 : string = v8489 + v8490 
                                                                                                                            let v8502 : string = "true; v8500 " + v8501 + "); " + v8489 + " // rust.fix_closure'"
                                                                                                                            let v8503 : bool = Fable.Core.RustInterop.emitRustExpr () v8502 
                                                                                                                            let v8504 : string = "__future_init"
                                                                                                                            let v8505 : _ = Fable.Core.RustInterop.emitRustExpr () v8504 
                                                                                                                            let v8506 : string = "v8505"
                                                                                                                            let v8507 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8506 
                                                                                                                            v8507
                                                                                                                | US6_0(v8041) -> (* Ok *)
                                                                                                                    match v8041 with
                                                                                                                    | US4_1 -> (* None *)
                                                                                                                        let v8042 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v8043 : bool = Fable.Core.RustInterop.emitRustExpr () v8042 
                                                                                                                        let v8044 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v8045 : bool = Fable.Core.RustInterop.emitRustExpr () v8044 
                                                                                                                        let v8046 : uint8 = method54()
                                                                                                                        let v8047 : string = ""
                                                                                                                        let v8048 : string = "}"
                                                                                                                        let v8049 : string = v8047 + v8048 
                                                                                                                        let v8050 : string = "true; v8046 " + v8049 + "); " + v8047 + " // rust.fix_closure'"
                                                                                                                        let v8051 : bool = Fable.Core.RustInterop.emitRustExpr () v8050 
                                                                                                                        let v8052 : string = "__future_init"
                                                                                                                        let v8053 : _ = Fable.Core.RustInterop.emitRustExpr () v8052 
                                                                                                                        let v8054 : string = "v8053"
                                                                                                                        let v8055 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8054 
                                                                                                                        let v8056 : string = "v8055.await"
                                                                                                                        let v8057 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8056 
                                                                                                                        let v8058 : US7 = method49(v8057)
                                                                                                                        let v8059 : string = v8047 + v8048 
                                                                                                                        let v8060 : string = "true; v8058 " + v8059 + "); " + v8047 + " // rust.fix_closure'"
                                                                                                                        let v8061 : bool = Fable.Core.RustInterop.emitRustExpr () v8060 
                                                                                                                        let v8062 : string = "__future_init"
                                                                                                                        let v8063 : _ = Fable.Core.RustInterop.emitRustExpr () v8062 
                                                                                                                        let v8064 : string = "v8063"
                                                                                                                        let v8065 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8064 
                                                                                                                        v8065
                                                                                                                    | US4_0(v8066) -> (* Some *)
                                                                                                                        let v8067 : unit = ()
                                                                                                                        let v8068 : (unit -> unit) = closure60(v8066)
                                                                                                                        let v8069 : unit = (fun () -> v8068 (); v8067) ()
                                                                                                                        let v8182 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v8183 : bool = Fable.Core.RustInterop.emitRustExpr () v8182 
                                                                                                                        let v8184 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                        let v8185 : bool = Fable.Core.RustInterop.emitRustExpr () v8184 
                                                                                                                        let v8186 : uint8 = method54()
                                                                                                                        let v8187 : string = ""
                                                                                                                        let v8188 : string = "}"
                                                                                                                        let v8189 : string = v8187 + v8188 
                                                                                                                        let v8190 : string = "true; v8186 " + v8189 + "); " + v8187 + " // rust.fix_closure'"
                                                                                                                        let v8191 : bool = Fable.Core.RustInterop.emitRustExpr () v8190 
                                                                                                                        let v8192 : string = "__future_init"
                                                                                                                        let v8193 : _ = Fable.Core.RustInterop.emitRustExpr () v8192 
                                                                                                                        let v8194 : string = "v8193"
                                                                                                                        let v8195 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v8194 
                                                                                                                        let v8196 : string = "v8195.await"
                                                                                                                        let v8197 : uint8 = Fable.Core.RustInterop.emitRustExpr () v8196 
                                                                                                                        let v8198 : US7 = method47(v8197)
                                                                                                                        let v8199 : string = v8187 + v8188 
                                                                                                                        let v8200 : string = "true; v8198 " + v8199 + "); " + v8187 + " // rust.fix_closure'"
                                                                                                                        let v8201 : bool = Fable.Core.RustInterop.emitRustExpr () v8200 
                                                                                                                        let v8202 : string = "__future_init"
                                                                                                                        let v8203 : _ = Fable.Core.RustInterop.emitRustExpr () v8202 
                                                                                                                        let v8204 : string = "v8203"
                                                                                                                        let v8205 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v8204 
                                                                                                                        v8205
                                                                                                            | US6_0(v7739) -> (* Ok *)
                                                                                                                match v7739 with
                                                                                                                | US4_1 -> (* None *)
                                                                                                                    let v7740 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7741 : bool = Fable.Core.RustInterop.emitRustExpr () v7740 
                                                                                                                    let v7742 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7743 : bool = Fable.Core.RustInterop.emitRustExpr () v7742 
                                                                                                                    let v7744 : uint8 = method55()
                                                                                                                    let v7745 : string = ""
                                                                                                                    let v7746 : string = "}"
                                                                                                                    let v7747 : string = v7745 + v7746 
                                                                                                                    let v7748 : string = "true; v7744 " + v7747 + "); " + v7745 + " // rust.fix_closure'"
                                                                                                                    let v7749 : bool = Fable.Core.RustInterop.emitRustExpr () v7748 
                                                                                                                    let v7750 : string = "__future_init"
                                                                                                                    let v7751 : _ = Fable.Core.RustInterop.emitRustExpr () v7750 
                                                                                                                    let v7752 : string = "v7751"
                                                                                                                    let v7753 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7752 
                                                                                                                    let v7754 : string = "v7753.await"
                                                                                                                    let v7755 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7754 
                                                                                                                    let v7756 : US7 = method49(v7755)
                                                                                                                    let v7757 : string = v7745 + v7746 
                                                                                                                    let v7758 : string = "true; v7756 " + v7757 + "); " + v7745 + " // rust.fix_closure'"
                                                                                                                    let v7759 : bool = Fable.Core.RustInterop.emitRustExpr () v7758 
                                                                                                                    let v7760 : string = "__future_init"
                                                                                                                    let v7761 : _ = Fable.Core.RustInterop.emitRustExpr () v7760 
                                                                                                                    let v7762 : string = "v7761"
                                                                                                                    let v7763 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7762 
                                                                                                                    v7763
                                                                                                                | US4_0(v7764) -> (* Some *)
                                                                                                                    let v7765 : unit = ()
                                                                                                                    let v7766 : (unit -> unit) = closure61(v7764)
                                                                                                                    let v7767 : unit = (fun () -> v7766 (); v7765) ()
                                                                                                                    let v7880 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7881 : bool = Fable.Core.RustInterop.emitRustExpr () v7880 
                                                                                                                    let v7882 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                    let v7883 : bool = Fable.Core.RustInterop.emitRustExpr () v7882 
                                                                                                                    let v7884 : uint8 = method55()
                                                                                                                    let v7885 : string = ""
                                                                                                                    let v7886 : string = "}"
                                                                                                                    let v7887 : string = v7885 + v7886 
                                                                                                                    let v7888 : string = "true; v7884 " + v7887 + "); " + v7885 + " // rust.fix_closure'"
                                                                                                                    let v7889 : bool = Fable.Core.RustInterop.emitRustExpr () v7888 
                                                                                                                    let v7890 : string = "__future_init"
                                                                                                                    let v7891 : _ = Fable.Core.RustInterop.emitRustExpr () v7890 
                                                                                                                    let v7892 : string = "v7891"
                                                                                                                    let v7893 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7892 
                                                                                                                    let v7894 : string = "v7893.await"
                                                                                                                    let v7895 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7894 
                                                                                                                    let v7896 : US7 = method47(v7895)
                                                                                                                    let v7897 : string = v7885 + v7886 
                                                                                                                    let v7898 : string = "true; v7896 " + v7897 + "); " + v7885 + " // rust.fix_closure'"
                                                                                                                    let v7899 : bool = Fable.Core.RustInterop.emitRustExpr () v7898 
                                                                                                                    let v7900 : string = "__future_init"
                                                                                                                    let v7901 : _ = Fable.Core.RustInterop.emitRustExpr () v7900 
                                                                                                                    let v7902 : string = "v7901"
                                                                                                                    let v7903 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7902 
                                                                                                                    v7903
                                                                                                        | US6_0(v7437) -> (* Ok *)
                                                                                                            match v7437 with
                                                                                                            | US4_1 -> (* None *)
                                                                                                                let v7438 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7439 : bool = Fable.Core.RustInterop.emitRustExpr () v7438 
                                                                                                                let v7440 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7441 : bool = Fable.Core.RustInterop.emitRustExpr () v7440 
                                                                                                                let v7442 : uint8 = method56()
                                                                                                                let v7443 : string = ""
                                                                                                                let v7444 : string = "}"
                                                                                                                let v7445 : string = v7443 + v7444 
                                                                                                                let v7446 : string = "true; v7442 " + v7445 + "); " + v7443 + " // rust.fix_closure'"
                                                                                                                let v7447 : bool = Fable.Core.RustInterop.emitRustExpr () v7446 
                                                                                                                let v7448 : string = "__future_init"
                                                                                                                let v7449 : _ = Fable.Core.RustInterop.emitRustExpr () v7448 
                                                                                                                let v7450 : string = "v7449"
                                                                                                                let v7451 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7450 
                                                                                                                let v7452 : string = "v7451.await"
                                                                                                                let v7453 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7452 
                                                                                                                let v7454 : US7 = method49(v7453)
                                                                                                                let v7455 : string = v7443 + v7444 
                                                                                                                let v7456 : string = "true; v7454 " + v7455 + "); " + v7443 + " // rust.fix_closure'"
                                                                                                                let v7457 : bool = Fable.Core.RustInterop.emitRustExpr () v7456 
                                                                                                                let v7458 : string = "__future_init"
                                                                                                                let v7459 : _ = Fable.Core.RustInterop.emitRustExpr () v7458 
                                                                                                                let v7460 : string = "v7459"
                                                                                                                let v7461 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7460 
                                                                                                                v7461
                                                                                                            | US4_0(v7462) -> (* Some *)
                                                                                                                let v7463 : unit = ()
                                                                                                                let v7464 : (unit -> unit) = closure62(v7462)
                                                                                                                let v7465 : unit = (fun () -> v7464 (); v7463) ()
                                                                                                                let v7578 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7579 : bool = Fable.Core.RustInterop.emitRustExpr () v7578 
                                                                                                                let v7580 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                                let v7581 : bool = Fable.Core.RustInterop.emitRustExpr () v7580 
                                                                                                                let v7582 : uint8 = method56()
                                                                                                                let v7583 : string = ""
                                                                                                                let v7584 : string = "}"
                                                                                                                let v7585 : string = v7583 + v7584 
                                                                                                                let v7586 : string = "true; v7582 " + v7585 + "); " + v7583 + " // rust.fix_closure'"
                                                                                                                let v7587 : bool = Fable.Core.RustInterop.emitRustExpr () v7586 
                                                                                                                let v7588 : string = "__future_init"
                                                                                                                let v7589 : _ = Fable.Core.RustInterop.emitRustExpr () v7588 
                                                                                                                let v7590 : string = "v7589"
                                                                                                                let v7591 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7590 
                                                                                                                let v7592 : string = "v7591.await"
                                                                                                                let v7593 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7592 
                                                                                                                let v7594 : US7 = method47(v7593)
                                                                                                                let v7595 : string = v7583 + v7584 
                                                                                                                let v7596 : string = "true; v7594 " + v7595 + "); " + v7583 + " // rust.fix_closure'"
                                                                                                                let v7597 : bool = Fable.Core.RustInterop.emitRustExpr () v7596 
                                                                                                                let v7598 : string = "__future_init"
                                                                                                                let v7599 : _ = Fable.Core.RustInterop.emitRustExpr () v7598 
                                                                                                                let v7600 : string = "v7599"
                                                                                                                let v7601 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7600 
                                                                                                                v7601
                                                                                                    | US6_0(v7135) -> (* Ok *)
                                                                                                        match v7135 with
                                                                                                        | US4_1 -> (* None *)
                                                                                                            let v7136 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v7137 : bool = Fable.Core.RustInterop.emitRustExpr () v7136 
                                                                                                            let v7138 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v7139 : bool = Fable.Core.RustInterop.emitRustExpr () v7138 
                                                                                                            let v7140 : uint8 = method57()
                                                                                                            let v7141 : string = ""
                                                                                                            let v7142 : string = "}"
                                                                                                            let v7143 : string = v7141 + v7142 
                                                                                                            let v7144 : string = "true; v7140 " + v7143 + "); " + v7141 + " // rust.fix_closure'"
                                                                                                            let v7145 : bool = Fable.Core.RustInterop.emitRustExpr () v7144 
                                                                                                            let v7146 : string = "__future_init"
                                                                                                            let v7147 : _ = Fable.Core.RustInterop.emitRustExpr () v7146 
                                                                                                            let v7148 : string = "v7147"
                                                                                                            let v7149 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7148 
                                                                                                            let v7150 : string = "v7149.await"
                                                                                                            let v7151 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7150 
                                                                                                            let v7152 : US7 = method49(v7151)
                                                                                                            let v7153 : string = v7141 + v7142 
                                                                                                            let v7154 : string = "true; v7152 " + v7153 + "); " + v7141 + " // rust.fix_closure'"
                                                                                                            let v7155 : bool = Fable.Core.RustInterop.emitRustExpr () v7154 
                                                                                                            let v7156 : string = "__future_init"
                                                                                                            let v7157 : _ = Fable.Core.RustInterop.emitRustExpr () v7156 
                                                                                                            let v7158 : string = "v7157"
                                                                                                            let v7159 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7158 
                                                                                                            v7159
                                                                                                        | US4_0(v7160) -> (* Some *)
                                                                                                            let v7161 : unit = ()
                                                                                                            let v7162 : (unit -> unit) = closure63(v7160)
                                                                                                            let v7163 : unit = (fun () -> v7162 (); v7161) ()
                                                                                                            let v7276 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v7277 : bool = Fable.Core.RustInterop.emitRustExpr () v7276 
                                                                                                            let v7278 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                            let v7279 : bool = Fable.Core.RustInterop.emitRustExpr () v7278 
                                                                                                            let v7280 : uint8 = method57()
                                                                                                            let v7281 : string = ""
                                                                                                            let v7282 : string = "}"
                                                                                                            let v7283 : string = v7281 + v7282 
                                                                                                            let v7284 : string = "true; v7280 " + v7283 + "); " + v7281 + " // rust.fix_closure'"
                                                                                                            let v7285 : bool = Fable.Core.RustInterop.emitRustExpr () v7284 
                                                                                                            let v7286 : string = "__future_init"
                                                                                                            let v7287 : _ = Fable.Core.RustInterop.emitRustExpr () v7286 
                                                                                                            let v7288 : string = "v7287"
                                                                                                            let v7289 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v7288 
                                                                                                            let v7290 : string = "v7289.await"
                                                                                                            let v7291 : uint8 = Fable.Core.RustInterop.emitRustExpr () v7290 
                                                                                                            let v7292 : US7 = method47(v7291)
                                                                                                            let v7293 : string = v7281 + v7282 
                                                                                                            let v7294 : string = "true; v7292 " + v7293 + "); " + v7281 + " // rust.fix_closure'"
                                                                                                            let v7295 : bool = Fable.Core.RustInterop.emitRustExpr () v7294 
                                                                                                            let v7296 : string = "__future_init"
                                                                                                            let v7297 : _ = Fable.Core.RustInterop.emitRustExpr () v7296 
                                                                                                            let v7298 : string = "v7297"
                                                                                                            let v7299 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v7298 
                                                                                                            v7299
                                                                                                | US6_0(v6833) -> (* Ok *)
                                                                                                    match v6833 with
                                                                                                    | US4_1 -> (* None *)
                                                                                                        let v6834 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6835 : bool = Fable.Core.RustInterop.emitRustExpr () v6834 
                                                                                                        let v6836 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6837 : bool = Fable.Core.RustInterop.emitRustExpr () v6836 
                                                                                                        let v6838 : uint8 = method58()
                                                                                                        let v6839 : string = ""
                                                                                                        let v6840 : string = "}"
                                                                                                        let v6841 : string = v6839 + v6840 
                                                                                                        let v6842 : string = "true; v6838 " + v6841 + "); " + v6839 + " // rust.fix_closure'"
                                                                                                        let v6843 : bool = Fable.Core.RustInterop.emitRustExpr () v6842 
                                                                                                        let v6844 : string = "__future_init"
                                                                                                        let v6845 : _ = Fable.Core.RustInterop.emitRustExpr () v6844 
                                                                                                        let v6846 : string = "v6845"
                                                                                                        let v6847 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6846 
                                                                                                        let v6848 : string = "v6847.await"
                                                                                                        let v6849 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6848 
                                                                                                        let v6850 : US7 = method49(v6849)
                                                                                                        let v6851 : string = v6839 + v6840 
                                                                                                        let v6852 : string = "true; v6850 " + v6851 + "); " + v6839 + " // rust.fix_closure'"
                                                                                                        let v6853 : bool = Fable.Core.RustInterop.emitRustExpr () v6852 
                                                                                                        let v6854 : string = "__future_init"
                                                                                                        let v6855 : _ = Fable.Core.RustInterop.emitRustExpr () v6854 
                                                                                                        let v6856 : string = "v6855"
                                                                                                        let v6857 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6856 
                                                                                                        v6857
                                                                                                    | US4_0(v6858) -> (* Some *)
                                                                                                        let v6859 : unit = ()
                                                                                                        let v6860 : (unit -> unit) = closure64(v6858)
                                                                                                        let v6861 : unit = (fun () -> v6860 (); v6859) ()
                                                                                                        let v6974 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6975 : bool = Fable.Core.RustInterop.emitRustExpr () v6974 
                                                                                                        let v6976 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                        let v6977 : bool = Fable.Core.RustInterop.emitRustExpr () v6976 
                                                                                                        let v6978 : uint8 = method58()
                                                                                                        let v6979 : string = ""
                                                                                                        let v6980 : string = "}"
                                                                                                        let v6981 : string = v6979 + v6980 
                                                                                                        let v6982 : string = "true; v6978 " + v6981 + "); " + v6979 + " // rust.fix_closure'"
                                                                                                        let v6983 : bool = Fable.Core.RustInterop.emitRustExpr () v6982 
                                                                                                        let v6984 : string = "__future_init"
                                                                                                        let v6985 : _ = Fable.Core.RustInterop.emitRustExpr () v6984 
                                                                                                        let v6986 : string = "v6985"
                                                                                                        let v6987 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6986 
                                                                                                        let v6988 : string = "v6987.await"
                                                                                                        let v6989 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6988 
                                                                                                        let v6990 : US7 = method47(v6989)
                                                                                                        let v6991 : string = v6979 + v6980 
                                                                                                        let v6992 : string = "true; v6990 " + v6991 + "); " + v6979 + " // rust.fix_closure'"
                                                                                                        let v6993 : bool = Fable.Core.RustInterop.emitRustExpr () v6992 
                                                                                                        let v6994 : string = "__future_init"
                                                                                                        let v6995 : _ = Fable.Core.RustInterop.emitRustExpr () v6994 
                                                                                                        let v6996 : string = "v6995"
                                                                                                        let v6997 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6996 
                                                                                                        v6997
                                                                                            | US6_0(v6531) -> (* Ok *)
                                                                                                match v6531 with
                                                                                                | US4_1 -> (* None *)
                                                                                                    let v6532 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6533 : bool = Fable.Core.RustInterop.emitRustExpr () v6532 
                                                                                                    let v6534 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6535 : bool = Fable.Core.RustInterop.emitRustExpr () v6534 
                                                                                                    let v6536 : uint8 = method59()
                                                                                                    let v6537 : string = ""
                                                                                                    let v6538 : string = "}"
                                                                                                    let v6539 : string = v6537 + v6538 
                                                                                                    let v6540 : string = "true; v6536 " + v6539 + "); " + v6537 + " // rust.fix_closure'"
                                                                                                    let v6541 : bool = Fable.Core.RustInterop.emitRustExpr () v6540 
                                                                                                    let v6542 : string = "__future_init"
                                                                                                    let v6543 : _ = Fable.Core.RustInterop.emitRustExpr () v6542 
                                                                                                    let v6544 : string = "v6543"
                                                                                                    let v6545 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6544 
                                                                                                    let v6546 : string = "v6545.await"
                                                                                                    let v6547 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6546 
                                                                                                    let v6548 : US7 = method49(v6547)
                                                                                                    let v6549 : string = v6537 + v6538 
                                                                                                    let v6550 : string = "true; v6548 " + v6549 + "); " + v6537 + " // rust.fix_closure'"
                                                                                                    let v6551 : bool = Fable.Core.RustInterop.emitRustExpr () v6550 
                                                                                                    let v6552 : string = "__future_init"
                                                                                                    let v6553 : _ = Fable.Core.RustInterop.emitRustExpr () v6552 
                                                                                                    let v6554 : string = "v6553"
                                                                                                    let v6555 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6554 
                                                                                                    v6555
                                                                                                | US4_0(v6556) -> (* Some *)
                                                                                                    let v6557 : unit = ()
                                                                                                    let v6558 : (unit -> unit) = closure65(v6556)
                                                                                                    let v6559 : unit = (fun () -> v6558 (); v6557) ()
                                                                                                    let v6672 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6673 : bool = Fable.Core.RustInterop.emitRustExpr () v6672 
                                                                                                    let v6674 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                    let v6675 : bool = Fable.Core.RustInterop.emitRustExpr () v6674 
                                                                                                    let v6676 : uint8 = method59()
                                                                                                    let v6677 : string = ""
                                                                                                    let v6678 : string = "}"
                                                                                                    let v6679 : string = v6677 + v6678 
                                                                                                    let v6680 : string = "true; v6676 " + v6679 + "); " + v6677 + " // rust.fix_closure'"
                                                                                                    let v6681 : bool = Fable.Core.RustInterop.emitRustExpr () v6680 
                                                                                                    let v6682 : string = "__future_init"
                                                                                                    let v6683 : _ = Fable.Core.RustInterop.emitRustExpr () v6682 
                                                                                                    let v6684 : string = "v6683"
                                                                                                    let v6685 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6684 
                                                                                                    let v6686 : string = "v6685.await"
                                                                                                    let v6687 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6686 
                                                                                                    let v6688 : US7 = method47(v6687)
                                                                                                    let v6689 : string = v6677 + v6678 
                                                                                                    let v6690 : string = "true; v6688 " + v6689 + "); " + v6677 + " // rust.fix_closure'"
                                                                                                    let v6691 : bool = Fable.Core.RustInterop.emitRustExpr () v6690 
                                                                                                    let v6692 : string = "__future_init"
                                                                                                    let v6693 : _ = Fable.Core.RustInterop.emitRustExpr () v6692 
                                                                                                    let v6694 : string = "v6693"
                                                                                                    let v6695 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6694 
                                                                                                    v6695
                                                                                        | US6_0(v6229) -> (* Ok *)
                                                                                            match v6229 with
                                                                                            | US4_1 -> (* None *)
                                                                                                let v6230 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v6231 : bool = Fable.Core.RustInterop.emitRustExpr () v6230 
                                                                                                let v6232 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v6233 : bool = Fable.Core.RustInterop.emitRustExpr () v6232 
                                                                                                let v6234 : uint8 = method60()
                                                                                                let v6235 : string = ""
                                                                                                let v6236 : string = "}"
                                                                                                let v6237 : string = v6235 + v6236 
                                                                                                let v6238 : string = "true; v6234 " + v6237 + "); " + v6235 + " // rust.fix_closure'"
                                                                                                let v6239 : bool = Fable.Core.RustInterop.emitRustExpr () v6238 
                                                                                                let v6240 : string = "__future_init"
                                                                                                let v6241 : _ = Fable.Core.RustInterop.emitRustExpr () v6240 
                                                                                                let v6242 : string = "v6241"
                                                                                                let v6243 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6242 
                                                                                                let v6244 : string = "v6243.await"
                                                                                                let v6245 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6244 
                                                                                                let v6246 : US7 = method49(v6245)
                                                                                                let v6247 : string = v6235 + v6236 
                                                                                                let v6248 : string = "true; v6246 " + v6247 + "); " + v6235 + " // rust.fix_closure'"
                                                                                                let v6249 : bool = Fable.Core.RustInterop.emitRustExpr () v6248 
                                                                                                let v6250 : string = "__future_init"
                                                                                                let v6251 : _ = Fable.Core.RustInterop.emitRustExpr () v6250 
                                                                                                let v6252 : string = "v6251"
                                                                                                let v6253 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6252 
                                                                                                v6253
                                                                                            | US4_0(v6254) -> (* Some *)
                                                                                                let v6255 : unit = ()
                                                                                                let v6256 : (unit -> unit) = closure66(v6254)
                                                                                                let v6257 : unit = (fun () -> v6256 (); v6255) ()
                                                                                                let v6370 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v6371 : bool = Fable.Core.RustInterop.emitRustExpr () v6370 
                                                                                                let v6372 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                                let v6373 : bool = Fable.Core.RustInterop.emitRustExpr () v6372 
                                                                                                let v6374 : uint8 = method60()
                                                                                                let v6375 : string = ""
                                                                                                let v6376 : string = "}"
                                                                                                let v6377 : string = v6375 + v6376 
                                                                                                let v6378 : string = "true; v6374 " + v6377 + "); " + v6375 + " // rust.fix_closure'"
                                                                                                let v6379 : bool = Fable.Core.RustInterop.emitRustExpr () v6378 
                                                                                                let v6380 : string = "__future_init"
                                                                                                let v6381 : _ = Fable.Core.RustInterop.emitRustExpr () v6380 
                                                                                                let v6382 : string = "v6381"
                                                                                                let v6383 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6382 
                                                                                                let v6384 : string = "v6383.await"
                                                                                                let v6385 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6384 
                                                                                                let v6386 : US7 = method47(v6385)
                                                                                                let v6387 : string = v6375 + v6376 
                                                                                                let v6388 : string = "true; v6386 " + v6387 + "); " + v6375 + " // rust.fix_closure'"
                                                                                                let v6389 : bool = Fable.Core.RustInterop.emitRustExpr () v6388 
                                                                                                let v6390 : string = "__future_init"
                                                                                                let v6391 : _ = Fable.Core.RustInterop.emitRustExpr () v6390 
                                                                                                let v6392 : string = "v6391"
                                                                                                let v6393 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6392 
                                                                                                v6393
                                                                                    | US6_0(v5927) -> (* Ok *)
                                                                                        match v5927 with
                                                                                        | US4_1 -> (* None *)
                                                                                            let v5928 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v5929 : bool = Fable.Core.RustInterop.emitRustExpr () v5928 
                                                                                            let v5930 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v5931 : bool = Fable.Core.RustInterop.emitRustExpr () v5930 
                                                                                            let v5932 : uint8 = method61()
                                                                                            let v5933 : string = ""
                                                                                            let v5934 : string = "}"
                                                                                            let v5935 : string = v5933 + v5934 
                                                                                            let v5936 : string = "true; v5932 " + v5935 + "); " + v5933 + " // rust.fix_closure'"
                                                                                            let v5937 : bool = Fable.Core.RustInterop.emitRustExpr () v5936 
                                                                                            let v5938 : string = "__future_init"
                                                                                            let v5939 : _ = Fable.Core.RustInterop.emitRustExpr () v5938 
                                                                                            let v5940 : string = "v5939"
                                                                                            let v5941 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5940 
                                                                                            let v5942 : string = "v5941.await"
                                                                                            let v5943 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5942 
                                                                                            let v5944 : US7 = method49(v5943)
                                                                                            let v5945 : string = v5933 + v5934 
                                                                                            let v5946 : string = "true; v5944 " + v5945 + "); " + v5933 + " // rust.fix_closure'"
                                                                                            let v5947 : bool = Fable.Core.RustInterop.emitRustExpr () v5946 
                                                                                            let v5948 : string = "__future_init"
                                                                                            let v5949 : _ = Fable.Core.RustInterop.emitRustExpr () v5948 
                                                                                            let v5950 : string = "v5949"
                                                                                            let v5951 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5950 
                                                                                            v5951
                                                                                        | US4_0(v5952) -> (* Some *)
                                                                                            let v5953 : unit = ()
                                                                                            let v5954 : (unit -> unit) = closure67(v5952)
                                                                                            let v5955 : unit = (fun () -> v5954 (); v5953) ()
                                                                                            let v6068 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v6069 : bool = Fable.Core.RustInterop.emitRustExpr () v6068 
                                                                                            let v6070 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                            let v6071 : bool = Fable.Core.RustInterop.emitRustExpr () v6070 
                                                                                            let v6072 : uint8 = method61()
                                                                                            let v6073 : string = ""
                                                                                            let v6074 : string = "}"
                                                                                            let v6075 : string = v6073 + v6074 
                                                                                            let v6076 : string = "true; v6072 " + v6075 + "); " + v6073 + " // rust.fix_closure'"
                                                                                            let v6077 : bool = Fable.Core.RustInterop.emitRustExpr () v6076 
                                                                                            let v6078 : string = "__future_init"
                                                                                            let v6079 : _ = Fable.Core.RustInterop.emitRustExpr () v6078 
                                                                                            let v6080 : string = "v6079"
                                                                                            let v6081 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v6080 
                                                                                            let v6082 : string = "v6081.await"
                                                                                            let v6083 : uint8 = Fable.Core.RustInterop.emitRustExpr () v6082 
                                                                                            let v6084 : US7 = method47(v6083)
                                                                                            let v6085 : string = v6073 + v6074 
                                                                                            let v6086 : string = "true; v6084 " + v6085 + "); " + v6073 + " // rust.fix_closure'"
                                                                                            let v6087 : bool = Fable.Core.RustInterop.emitRustExpr () v6086 
                                                                                            let v6088 : string = "__future_init"
                                                                                            let v6089 : _ = Fable.Core.RustInterop.emitRustExpr () v6088 
                                                                                            let v6090 : string = "v6089"
                                                                                            let v6091 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v6090 
                                                                                            v6091
                                                                                | US6_0(v5625) -> (* Ok *)
                                                                                    match v5625 with
                                                                                    | US4_1 -> (* None *)
                                                                                        let v5626 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5627 : bool = Fable.Core.RustInterop.emitRustExpr () v5626 
                                                                                        let v5628 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5629 : bool = Fable.Core.RustInterop.emitRustExpr () v5628 
                                                                                        let v5630 : uint8 = method62()
                                                                                        let v5631 : string = ""
                                                                                        let v5632 : string = "}"
                                                                                        let v5633 : string = v5631 + v5632 
                                                                                        let v5634 : string = "true; v5630 " + v5633 + "); " + v5631 + " // rust.fix_closure'"
                                                                                        let v5635 : bool = Fable.Core.RustInterop.emitRustExpr () v5634 
                                                                                        let v5636 : string = "__future_init"
                                                                                        let v5637 : _ = Fable.Core.RustInterop.emitRustExpr () v5636 
                                                                                        let v5638 : string = "v5637"
                                                                                        let v5639 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5638 
                                                                                        let v5640 : string = "v5639.await"
                                                                                        let v5641 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5640 
                                                                                        let v5642 : US7 = method49(v5641)
                                                                                        let v5643 : string = v5631 + v5632 
                                                                                        let v5644 : string = "true; v5642 " + v5643 + "); " + v5631 + " // rust.fix_closure'"
                                                                                        let v5645 : bool = Fable.Core.RustInterop.emitRustExpr () v5644 
                                                                                        let v5646 : string = "__future_init"
                                                                                        let v5647 : _ = Fable.Core.RustInterop.emitRustExpr () v5646 
                                                                                        let v5648 : string = "v5647"
                                                                                        let v5649 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5648 
                                                                                        v5649
                                                                                    | US4_0(v5650) -> (* Some *)
                                                                                        let v5651 : unit = ()
                                                                                        let v5652 : (unit -> unit) = closure68(v5650)
                                                                                        let v5653 : unit = (fun () -> v5652 (); v5651) ()
                                                                                        let v5766 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5767 : bool = Fable.Core.RustInterop.emitRustExpr () v5766 
                                                                                        let v5768 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                        let v5769 : bool = Fable.Core.RustInterop.emitRustExpr () v5768 
                                                                                        let v5770 : uint8 = method62()
                                                                                        let v5771 : string = ""
                                                                                        let v5772 : string = "}"
                                                                                        let v5773 : string = v5771 + v5772 
                                                                                        let v5774 : string = "true; v5770 " + v5773 + "); " + v5771 + " // rust.fix_closure'"
                                                                                        let v5775 : bool = Fable.Core.RustInterop.emitRustExpr () v5774 
                                                                                        let v5776 : string = "__future_init"
                                                                                        let v5777 : _ = Fable.Core.RustInterop.emitRustExpr () v5776 
                                                                                        let v5778 : string = "v5777"
                                                                                        let v5779 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5778 
                                                                                        let v5780 : string = "v5779.await"
                                                                                        let v5781 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5780 
                                                                                        let v5782 : US7 = method47(v5781)
                                                                                        let v5783 : string = v5771 + v5772 
                                                                                        let v5784 : string = "true; v5782 " + v5783 + "); " + v5771 + " // rust.fix_closure'"
                                                                                        let v5785 : bool = Fable.Core.RustInterop.emitRustExpr () v5784 
                                                                                        let v5786 : string = "__future_init"
                                                                                        let v5787 : _ = Fable.Core.RustInterop.emitRustExpr () v5786 
                                                                                        let v5788 : string = "v5787"
                                                                                        let v5789 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5788 
                                                                                        v5789
                                                                            | US6_0(v5323) -> (* Ok *)
                                                                                match v5323 with
                                                                                | US4_1 -> (* None *)
                                                                                    let v5324 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5325 : bool = Fable.Core.RustInterop.emitRustExpr () v5324 
                                                                                    let v5326 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5327 : bool = Fable.Core.RustInterop.emitRustExpr () v5326 
                                                                                    let v5328 : uint8 = method63()
                                                                                    let v5329 : string = ""
                                                                                    let v5330 : string = "}"
                                                                                    let v5331 : string = v5329 + v5330 
                                                                                    let v5332 : string = "true; v5328 " + v5331 + "); " + v5329 + " // rust.fix_closure'"
                                                                                    let v5333 : bool = Fable.Core.RustInterop.emitRustExpr () v5332 
                                                                                    let v5334 : string = "__future_init"
                                                                                    let v5335 : _ = Fable.Core.RustInterop.emitRustExpr () v5334 
                                                                                    let v5336 : string = "v5335"
                                                                                    let v5337 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5336 
                                                                                    let v5338 : string = "v5337.await"
                                                                                    let v5339 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5338 
                                                                                    let v5340 : US7 = method49(v5339)
                                                                                    let v5341 : string = v5329 + v5330 
                                                                                    let v5342 : string = "true; v5340 " + v5341 + "); " + v5329 + " // rust.fix_closure'"
                                                                                    let v5343 : bool = Fable.Core.RustInterop.emitRustExpr () v5342 
                                                                                    let v5344 : string = "__future_init"
                                                                                    let v5345 : _ = Fable.Core.RustInterop.emitRustExpr () v5344 
                                                                                    let v5346 : string = "v5345"
                                                                                    let v5347 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5346 
                                                                                    v5347
                                                                                | US4_0(v5348) -> (* Some *)
                                                                                    let v5349 : unit = ()
                                                                                    let v5350 : (unit -> unit) = closure69(v5348)
                                                                                    let v5351 : unit = (fun () -> v5350 (); v5349) ()
                                                                                    let v5464 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5465 : bool = Fable.Core.RustInterop.emitRustExpr () v5464 
                                                                                    let v5466 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                    let v5467 : bool = Fable.Core.RustInterop.emitRustExpr () v5466 
                                                                                    let v5468 : uint8 = method63()
                                                                                    let v5469 : string = ""
                                                                                    let v5470 : string = "}"
                                                                                    let v5471 : string = v5469 + v5470 
                                                                                    let v5472 : string = "true; v5468 " + v5471 + "); " + v5469 + " // rust.fix_closure'"
                                                                                    let v5473 : bool = Fable.Core.RustInterop.emitRustExpr () v5472 
                                                                                    let v5474 : string = "__future_init"
                                                                                    let v5475 : _ = Fable.Core.RustInterop.emitRustExpr () v5474 
                                                                                    let v5476 : string = "v5475"
                                                                                    let v5477 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5476 
                                                                                    let v5478 : string = "v5477.await"
                                                                                    let v5479 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5478 
                                                                                    let v5480 : US7 = method47(v5479)
                                                                                    let v5481 : string = v5469 + v5470 
                                                                                    let v5482 : string = "true; v5480 " + v5481 + "); " + v5469 + " // rust.fix_closure'"
                                                                                    let v5483 : bool = Fable.Core.RustInterop.emitRustExpr () v5482 
                                                                                    let v5484 : string = "__future_init"
                                                                                    let v5485 : _ = Fable.Core.RustInterop.emitRustExpr () v5484 
                                                                                    let v5486 : string = "v5485"
                                                                                    let v5487 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5486 
                                                                                    v5487
                                                                        | US6_0(v5021) -> (* Ok *)
                                                                            match v5021 with
                                                                            | US4_1 -> (* None *)
                                                                                let v5022 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v5023 : bool = Fable.Core.RustInterop.emitRustExpr () v5022 
                                                                                let v5024 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v5025 : bool = Fable.Core.RustInterop.emitRustExpr () v5024 
                                                                                let v5026 : uint8 = method64()
                                                                                let v5027 : string = ""
                                                                                let v5028 : string = "}"
                                                                                let v5029 : string = v5027 + v5028 
                                                                                let v5030 : string = "true; v5026 " + v5029 + "); " + v5027 + " // rust.fix_closure'"
                                                                                let v5031 : bool = Fable.Core.RustInterop.emitRustExpr () v5030 
                                                                                let v5032 : string = "__future_init"
                                                                                let v5033 : _ = Fable.Core.RustInterop.emitRustExpr () v5032 
                                                                                let v5034 : string = "v5033"
                                                                                let v5035 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5034 
                                                                                let v5036 : string = "v5035.await"
                                                                                let v5037 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5036 
                                                                                let v5038 : US7 = method49(v5037)
                                                                                let v5039 : string = v5027 + v5028 
                                                                                let v5040 : string = "true; v5038 " + v5039 + "); " + v5027 + " // rust.fix_closure'"
                                                                                let v5041 : bool = Fable.Core.RustInterop.emitRustExpr () v5040 
                                                                                let v5042 : string = "__future_init"
                                                                                let v5043 : _ = Fable.Core.RustInterop.emitRustExpr () v5042 
                                                                                let v5044 : string = "v5043"
                                                                                let v5045 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5044 
                                                                                v5045
                                                                            | US4_0(v5046) -> (* Some *)
                                                                                let v5047 : unit = ()
                                                                                let v5048 : (unit -> unit) = closure70(v5046)
                                                                                let v5049 : unit = (fun () -> v5048 (); v5047) ()
                                                                                let v5162 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v5163 : bool = Fable.Core.RustInterop.emitRustExpr () v5162 
                                                                                let v5164 : string = "true; let __future_init = Box::pin(async move { //"
                                                                                let v5165 : bool = Fable.Core.RustInterop.emitRustExpr () v5164 
                                                                                let v5166 : uint8 = method64()
                                                                                let v5167 : string = ""
                                                                                let v5168 : string = "}"
                                                                                let v5169 : string = v5167 + v5168 
                                                                                let v5170 : string = "true; v5166 " + v5169 + "); " + v5167 + " // rust.fix_closure'"
                                                                                let v5171 : bool = Fable.Core.RustInterop.emitRustExpr () v5170 
                                                                                let v5172 : string = "__future_init"
                                                                                let v5173 : _ = Fable.Core.RustInterop.emitRustExpr () v5172 
                                                                                let v5174 : string = "v5173"
                                                                                let v5175 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v5174 
                                                                                let v5176 : string = "v5175.await"
                                                                                let v5177 : uint8 = Fable.Core.RustInterop.emitRustExpr () v5176 
                                                                                let v5178 : US7 = method47(v5177)
                                                                                let v5179 : string = v5167 + v5168 
                                                                                let v5180 : string = "true; v5178 " + v5179 + "); " + v5167 + " // rust.fix_closure'"
                                                                                let v5181 : bool = Fable.Core.RustInterop.emitRustExpr () v5180 
                                                                                let v5182 : string = "__future_init"
                                                                                let v5183 : _ = Fable.Core.RustInterop.emitRustExpr () v5182 
                                                                                let v5184 : string = "v5183"
                                                                                let v5185 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v5184 
                                                                                v5185
                                                                    | US6_0(v4719) -> (* Ok *)
                                                                        match v4719 with
                                                                        | US4_1 -> (* None *)
                                                                            let v4720 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4721 : bool = Fable.Core.RustInterop.emitRustExpr () v4720 
                                                                            let v4722 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4723 : bool = Fable.Core.RustInterop.emitRustExpr () v4722 
                                                                            let v4724 : uint8 = method65()
                                                                            let v4725 : string = ""
                                                                            let v4726 : string = "}"
                                                                            let v4727 : string = v4725 + v4726 
                                                                            let v4728 : string = "true; v4724 " + v4727 + "); " + v4725 + " // rust.fix_closure'"
                                                                            let v4729 : bool = Fable.Core.RustInterop.emitRustExpr () v4728 
                                                                            let v4730 : string = "__future_init"
                                                                            let v4731 : _ = Fable.Core.RustInterop.emitRustExpr () v4730 
                                                                            let v4732 : string = "v4731"
                                                                            let v4733 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4732 
                                                                            let v4734 : string = "v4733.await"
                                                                            let v4735 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4734 
                                                                            let v4736 : US7 = method49(v4735)
                                                                            let v4737 : string = v4725 + v4726 
                                                                            let v4738 : string = "true; v4736 " + v4737 + "); " + v4725 + " // rust.fix_closure'"
                                                                            let v4739 : bool = Fable.Core.RustInterop.emitRustExpr () v4738 
                                                                            let v4740 : string = "__future_init"
                                                                            let v4741 : _ = Fable.Core.RustInterop.emitRustExpr () v4740 
                                                                            let v4742 : string = "v4741"
                                                                            let v4743 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4742 
                                                                            v4743
                                                                        | US4_0(v4744) -> (* Some *)
                                                                            let v4745 : unit = ()
                                                                            let v4746 : (unit -> unit) = closure71(v4744)
                                                                            let v4747 : unit = (fun () -> v4746 (); v4745) ()
                                                                            let v4860 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4861 : bool = Fable.Core.RustInterop.emitRustExpr () v4860 
                                                                            let v4862 : string = "true; let __future_init = Box::pin(async move { //"
                                                                            let v4863 : bool = Fable.Core.RustInterop.emitRustExpr () v4862 
                                                                            let v4864 : uint8 = method65()
                                                                            let v4865 : string = ""
                                                                            let v4866 : string = "}"
                                                                            let v4867 : string = v4865 + v4866 
                                                                            let v4868 : string = "true; v4864 " + v4867 + "); " + v4865 + " // rust.fix_closure'"
                                                                            let v4869 : bool = Fable.Core.RustInterop.emitRustExpr () v4868 
                                                                            let v4870 : string = "__future_init"
                                                                            let v4871 : _ = Fable.Core.RustInterop.emitRustExpr () v4870 
                                                                            let v4872 : string = "v4871"
                                                                            let v4873 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4872 
                                                                            let v4874 : string = "v4873.await"
                                                                            let v4875 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4874 
                                                                            let v4876 : US7 = method47(v4875)
                                                                            let v4877 : string = v4865 + v4866 
                                                                            let v4878 : string = "true; v4876 " + v4877 + "); " + v4865 + " // rust.fix_closure'"
                                                                            let v4879 : bool = Fable.Core.RustInterop.emitRustExpr () v4878 
                                                                            let v4880 : string = "__future_init"
                                                                            let v4881 : _ = Fable.Core.RustInterop.emitRustExpr () v4880 
                                                                            let v4882 : string = "v4881"
                                                                            let v4883 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4882 
                                                                            v4883
                                                                | US6_0(v4417) -> (* Ok *)
                                                                    match v4417 with
                                                                    | US4_1 -> (* None *)
                                                                        let v4418 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4419 : bool = Fable.Core.RustInterop.emitRustExpr () v4418 
                                                                        let v4420 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4421 : bool = Fable.Core.RustInterop.emitRustExpr () v4420 
                                                                        let v4422 : uint8 = method66()
                                                                        let v4423 : string = ""
                                                                        let v4424 : string = "}"
                                                                        let v4425 : string = v4423 + v4424 
                                                                        let v4426 : string = "true; v4422 " + v4425 + "); " + v4423 + " // rust.fix_closure'"
                                                                        let v4427 : bool = Fable.Core.RustInterop.emitRustExpr () v4426 
                                                                        let v4428 : string = "__future_init"
                                                                        let v4429 : _ = Fable.Core.RustInterop.emitRustExpr () v4428 
                                                                        let v4430 : string = "v4429"
                                                                        let v4431 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4430 
                                                                        let v4432 : string = "v4431.await"
                                                                        let v4433 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4432 
                                                                        let v4434 : US7 = method49(v4433)
                                                                        let v4435 : string = v4423 + v4424 
                                                                        let v4436 : string = "true; v4434 " + v4435 + "); " + v4423 + " // rust.fix_closure'"
                                                                        let v4437 : bool = Fable.Core.RustInterop.emitRustExpr () v4436 
                                                                        let v4438 : string = "__future_init"
                                                                        let v4439 : _ = Fable.Core.RustInterop.emitRustExpr () v4438 
                                                                        let v4440 : string = "v4439"
                                                                        let v4441 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4440 
                                                                        v4441
                                                                    | US4_0(v4442) -> (* Some *)
                                                                        let v4443 : unit = ()
                                                                        let v4444 : (unit -> unit) = closure72(v4442)
                                                                        let v4445 : unit = (fun () -> v4444 (); v4443) ()
                                                                        let v4558 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4559 : bool = Fable.Core.RustInterop.emitRustExpr () v4558 
                                                                        let v4560 : string = "true; let __future_init = Box::pin(async move { //"
                                                                        let v4561 : bool = Fable.Core.RustInterop.emitRustExpr () v4560 
                                                                        let v4562 : uint8 = method66()
                                                                        let v4563 : string = ""
                                                                        let v4564 : string = "}"
                                                                        let v4565 : string = v4563 + v4564 
                                                                        let v4566 : string = "true; v4562 " + v4565 + "); " + v4563 + " // rust.fix_closure'"
                                                                        let v4567 : bool = Fable.Core.RustInterop.emitRustExpr () v4566 
                                                                        let v4568 : string = "__future_init"
                                                                        let v4569 : _ = Fable.Core.RustInterop.emitRustExpr () v4568 
                                                                        let v4570 : string = "v4569"
                                                                        let v4571 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4570 
                                                                        let v4572 : string = "v4571.await"
                                                                        let v4573 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4572 
                                                                        let v4574 : US7 = method47(v4573)
                                                                        let v4575 : string = v4563 + v4564 
                                                                        let v4576 : string = "true; v4574 " + v4575 + "); " + v4563 + " // rust.fix_closure'"
                                                                        let v4577 : bool = Fable.Core.RustInterop.emitRustExpr () v4576 
                                                                        let v4578 : string = "__future_init"
                                                                        let v4579 : _ = Fable.Core.RustInterop.emitRustExpr () v4578 
                                                                        let v4580 : string = "v4579"
                                                                        let v4581 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4580 
                                                                        v4581
                                                            | US6_0(v4115) -> (* Ok *)
                                                                match v4115 with
                                                                | US4_1 -> (* None *)
                                                                    let v4116 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v4117 : bool = Fable.Core.RustInterop.emitRustExpr () v4116 
                                                                    let v4118 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v4119 : bool = Fable.Core.RustInterop.emitRustExpr () v4118 
                                                                    let v4120 : uint8 = method67()
                                                                    let v4121 : string = ""
                                                                    let v4122 : string = "}"
                                                                    let v4123 : string = v4121 + v4122 
                                                                    let v4124 : string = "true; v4120 " + v4123 + "); " + v4121 + " // rust.fix_closure'"
                                                                    let v4125 : bool = Fable.Core.RustInterop.emitRustExpr () v4124 
                                                                    let v4126 : string = "__future_init"
                                                                    let v4127 : _ = Fable.Core.RustInterop.emitRustExpr () v4126 
                                                                    let v4128 : string = "v4127"
                                                                    let v4129 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4128 
                                                                    let v4130 : string = "v4129.await"
                                                                    let v4131 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4130 
                                                                    let v4132 : US7 = method49(v4131)
                                                                    let v4133 : string = v4121 + v4122 
                                                                    let v4134 : string = "true; v4132 " + v4133 + "); " + v4121 + " // rust.fix_closure'"
                                                                    let v4135 : bool = Fable.Core.RustInterop.emitRustExpr () v4134 
                                                                    let v4136 : string = "__future_init"
                                                                    let v4137 : _ = Fable.Core.RustInterop.emitRustExpr () v4136 
                                                                    let v4138 : string = "v4137"
                                                                    let v4139 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4138 
                                                                    v4139
                                                                | US4_0(v4140) -> (* Some *)
                                                                    let v4141 : unit = ()
                                                                    let v4142 : (unit -> unit) = closure73(v4140)
                                                                    let v4143 : unit = (fun () -> v4142 (); v4141) ()
                                                                    let v4256 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v4257 : bool = Fable.Core.RustInterop.emitRustExpr () v4256 
                                                                    let v4258 : string = "true; let __future_init = Box::pin(async move { //"
                                                                    let v4259 : bool = Fable.Core.RustInterop.emitRustExpr () v4258 
                                                                    let v4260 : uint8 = method67()
                                                                    let v4261 : string = ""
                                                                    let v4262 : string = "}"
                                                                    let v4263 : string = v4261 + v4262 
                                                                    let v4264 : string = "true; v4260 " + v4263 + "); " + v4261 + " // rust.fix_closure'"
                                                                    let v4265 : bool = Fable.Core.RustInterop.emitRustExpr () v4264 
                                                                    let v4266 : string = "__future_init"
                                                                    let v4267 : _ = Fable.Core.RustInterop.emitRustExpr () v4266 
                                                                    let v4268 : string = "v4267"
                                                                    let v4269 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v4268 
                                                                    let v4270 : string = "v4269.await"
                                                                    let v4271 : uint8 = Fable.Core.RustInterop.emitRustExpr () v4270 
                                                                    let v4272 : US7 = method47(v4271)
                                                                    let v4273 : string = v4261 + v4262 
                                                                    let v4274 : string = "true; v4272 " + v4273 + "); " + v4261 + " // rust.fix_closure'"
                                                                    let v4275 : bool = Fable.Core.RustInterop.emitRustExpr () v4274 
                                                                    let v4276 : string = "__future_init"
                                                                    let v4277 : _ = Fable.Core.RustInterop.emitRustExpr () v4276 
                                                                    let v4278 : string = "v4277"
                                                                    let v4279 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v4278 
                                                                    v4279
                                                        | US6_0(v3813) -> (* Ok *)
                                                            match v3813 with
                                                            | US4_1 -> (* None *)
                                                                let v3814 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3815 : bool = Fable.Core.RustInterop.emitRustExpr () v3814 
                                                                let v3816 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3817 : bool = Fable.Core.RustInterop.emitRustExpr () v3816 
                                                                let v3818 : uint8 = method68()
                                                                let v3819 : string = ""
                                                                let v3820 : string = "}"
                                                                let v3821 : string = v3819 + v3820 
                                                                let v3822 : string = "true; v3818 " + v3821 + "); " + v3819 + " // rust.fix_closure'"
                                                                let v3823 : bool = Fable.Core.RustInterop.emitRustExpr () v3822 
                                                                let v3824 : string = "__future_init"
                                                                let v3825 : _ = Fable.Core.RustInterop.emitRustExpr () v3824 
                                                                let v3826 : string = "v3825"
                                                                let v3827 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3826 
                                                                let v3828 : string = "v3827.await"
                                                                let v3829 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3828 
                                                                let v3830 : US7 = method49(v3829)
                                                                let v3831 : string = v3819 + v3820 
                                                                let v3832 : string = "true; v3830 " + v3831 + "); " + v3819 + " // rust.fix_closure'"
                                                                let v3833 : bool = Fable.Core.RustInterop.emitRustExpr () v3832 
                                                                let v3834 : string = "__future_init"
                                                                let v3835 : _ = Fable.Core.RustInterop.emitRustExpr () v3834 
                                                                let v3836 : string = "v3835"
                                                                let v3837 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3836 
                                                                v3837
                                                            | US4_0(v3838) -> (* Some *)
                                                                let v3839 : unit = ()
                                                                let v3840 : (unit -> unit) = closure74(v3838)
                                                                let v3841 : unit = (fun () -> v3840 (); v3839) ()
                                                                let v3954 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3955 : bool = Fable.Core.RustInterop.emitRustExpr () v3954 
                                                                let v3956 : string = "true; let __future_init = Box::pin(async move { //"
                                                                let v3957 : bool = Fable.Core.RustInterop.emitRustExpr () v3956 
                                                                let v3958 : uint8 = method68()
                                                                let v3959 : string = ""
                                                                let v3960 : string = "}"
                                                                let v3961 : string = v3959 + v3960 
                                                                let v3962 : string = "true; v3958 " + v3961 + "); " + v3959 + " // rust.fix_closure'"
                                                                let v3963 : bool = Fable.Core.RustInterop.emitRustExpr () v3962 
                                                                let v3964 : string = "__future_init"
                                                                let v3965 : _ = Fable.Core.RustInterop.emitRustExpr () v3964 
                                                                let v3966 : string = "v3965"
                                                                let v3967 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3966 
                                                                let v3968 : string = "v3967.await"
                                                                let v3969 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3968 
                                                                let v3970 : US7 = method47(v3969)
                                                                let v3971 : string = v3959 + v3960 
                                                                let v3972 : string = "true; v3970 " + v3971 + "); " + v3959 + " // rust.fix_closure'"
                                                                let v3973 : bool = Fable.Core.RustInterop.emitRustExpr () v3972 
                                                                let v3974 : string = "__future_init"
                                                                let v3975 : _ = Fable.Core.RustInterop.emitRustExpr () v3974 
                                                                let v3976 : string = "v3975"
                                                                let v3977 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3976 
                                                                v3977
                                                    | US6_0(v3511) -> (* Ok *)
                                                        match v3511 with
                                                        | US4_1 -> (* None *)
                                                            let v3512 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3513 : bool = Fable.Core.RustInterop.emitRustExpr () v3512 
                                                            let v3514 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3515 : bool = Fable.Core.RustInterop.emitRustExpr () v3514 
                                                            let v3516 : uint8 = method69()
                                                            let v3517 : string = ""
                                                            let v3518 : string = "}"
                                                            let v3519 : string = v3517 + v3518 
                                                            let v3520 : string = "true; v3516 " + v3519 + "); " + v3517 + " // rust.fix_closure'"
                                                            let v3521 : bool = Fable.Core.RustInterop.emitRustExpr () v3520 
                                                            let v3522 : string = "__future_init"
                                                            let v3523 : _ = Fable.Core.RustInterop.emitRustExpr () v3522 
                                                            let v3524 : string = "v3523"
                                                            let v3525 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3524 
                                                            let v3526 : string = "v3525.await"
                                                            let v3527 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3526 
                                                            let v3528 : US7 = method49(v3527)
                                                            let v3529 : string = v3517 + v3518 
                                                            let v3530 : string = "true; v3528 " + v3529 + "); " + v3517 + " // rust.fix_closure'"
                                                            let v3531 : bool = Fable.Core.RustInterop.emitRustExpr () v3530 
                                                            let v3532 : string = "__future_init"
                                                            let v3533 : _ = Fable.Core.RustInterop.emitRustExpr () v3532 
                                                            let v3534 : string = "v3533"
                                                            let v3535 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3534 
                                                            v3535
                                                        | US4_0(v3536) -> (* Some *)
                                                            let v3537 : unit = ()
                                                            let v3538 : (unit -> unit) = closure75(v3536)
                                                            let v3539 : unit = (fun () -> v3538 (); v3537) ()
                                                            let v3652 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3653 : bool = Fable.Core.RustInterop.emitRustExpr () v3652 
                                                            let v3654 : string = "true; let __future_init = Box::pin(async move { //"
                                                            let v3655 : bool = Fable.Core.RustInterop.emitRustExpr () v3654 
                                                            let v3656 : uint8 = method69()
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
                                                            let v3668 : US7 = method47(v3667)
                                                            let v3669 : string = v3657 + v3658 
                                                            let v3670 : string = "true; v3668 " + v3669 + "); " + v3657 + " // rust.fix_closure'"
                                                            let v3671 : bool = Fable.Core.RustInterop.emitRustExpr () v3670 
                                                            let v3672 : string = "__future_init"
                                                            let v3673 : _ = Fable.Core.RustInterop.emitRustExpr () v3672 
                                                            let v3674 : string = "v3673"
                                                            let v3675 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3674 
                                                            v3675
                                                | US6_0(v3209) -> (* Ok *)
                                                    match v3209 with
                                                    | US4_1 -> (* None *)
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
                                                        let v3226 : US7 = method49(v3225)
                                                        let v3227 : string = v3215 + v3216 
                                                        let v3228 : string = "true; v3226 " + v3227 + "); " + v3215 + " // rust.fix_closure'"
                                                        let v3229 : bool = Fable.Core.RustInterop.emitRustExpr () v3228 
                                                        let v3230 : string = "__future_init"
                                                        let v3231 : _ = Fable.Core.RustInterop.emitRustExpr () v3230 
                                                        let v3232 : string = "v3231"
                                                        let v3233 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3232 
                                                        v3233
                                                    | US4_0(v3234) -> (* Some *)
                                                        let v3235 : unit = ()
                                                        let v3236 : (unit -> unit) = closure76(v3234)
                                                        let v3237 : unit = (fun () -> v3236 (); v3235) ()
                                                        let v3350 : string = "true; let __future_init = Box::pin(async move { //"
                                                        let v3351 : bool = Fable.Core.RustInterop.emitRustExpr () v3350 
                                                        let v3352 : string = "true; let __future_init = Box::pin(async move { //"
                                                        let v3353 : bool = Fable.Core.RustInterop.emitRustExpr () v3352 
                                                        let v3354 : uint8 = method70()
                                                        let v3355 : string = ""
                                                        let v3356 : string = "}"
                                                        let v3357 : string = v3355 + v3356 
                                                        let v3358 : string = "true; v3354 " + v3357 + "); " + v3355 + " // rust.fix_closure'"
                                                        let v3359 : bool = Fable.Core.RustInterop.emitRustExpr () v3358 
                                                        let v3360 : string = "__future_init"
                                                        let v3361 : _ = Fable.Core.RustInterop.emitRustExpr () v3360 
                                                        let v3362 : string = "v3361"
                                                        let v3363 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3362 
                                                        let v3364 : string = "v3363.await"
                                                        let v3365 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3364 
                                                        let v3366 : US7 = method47(v3365)
                                                        let v3367 : string = v3355 + v3356 
                                                        let v3368 : string = "true; v3366 " + v3367 + "); " + v3355 + " // rust.fix_closure'"
                                                        let v3369 : bool = Fable.Core.RustInterop.emitRustExpr () v3368 
                                                        let v3370 : string = "__future_init"
                                                        let v3371 : _ = Fable.Core.RustInterop.emitRustExpr () v3370 
                                                        let v3372 : string = "v3371"
                                                        let v3373 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3372 
                                                        v3373
                                            | US6_0(v2907) -> (* Ok *)
                                                match v2907 with
                                                | US4_1 -> (* None *)
                                                    let v2908 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v2909 : bool = Fable.Core.RustInterop.emitRustExpr () v2908 
                                                    let v2910 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v2911 : bool = Fable.Core.RustInterop.emitRustExpr () v2910 
                                                    let v2912 : uint8 = method71()
                                                    let v2913 : string = ""
                                                    let v2914 : string = "}"
                                                    let v2915 : string = v2913 + v2914 
                                                    let v2916 : string = "true; v2912 " + v2915 + "); " + v2913 + " // rust.fix_closure'"
                                                    let v2917 : bool = Fable.Core.RustInterop.emitRustExpr () v2916 
                                                    let v2918 : string = "__future_init"
                                                    let v2919 : _ = Fable.Core.RustInterop.emitRustExpr () v2918 
                                                    let v2920 : string = "v2919"
                                                    let v2921 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2920 
                                                    let v2922 : string = "v2921.await"
                                                    let v2923 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2922 
                                                    let v2924 : US7 = method49(v2923)
                                                    let v2925 : string = v2913 + v2914 
                                                    let v2926 : string = "true; v2924 " + v2925 + "); " + v2913 + " // rust.fix_closure'"
                                                    let v2927 : bool = Fable.Core.RustInterop.emitRustExpr () v2926 
                                                    let v2928 : string = "__future_init"
                                                    let v2929 : _ = Fable.Core.RustInterop.emitRustExpr () v2928 
                                                    let v2930 : string = "v2929"
                                                    let v2931 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2930 
                                                    v2931
                                                | US4_0(v2932) -> (* Some *)
                                                    let v2933 : unit = ()
                                                    let v2934 : (unit -> unit) = closure77(v2932)
                                                    let v2935 : unit = (fun () -> v2934 (); v2933) ()
                                                    let v3048 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v3049 : bool = Fable.Core.RustInterop.emitRustExpr () v3048 
                                                    let v3050 : string = "true; let __future_init = Box::pin(async move { //"
                                                    let v3051 : bool = Fable.Core.RustInterop.emitRustExpr () v3050 
                                                    let v3052 : uint8 = method71()
                                                    let v3053 : string = ""
                                                    let v3054 : string = "}"
                                                    let v3055 : string = v3053 + v3054 
                                                    let v3056 : string = "true; v3052 " + v3055 + "); " + v3053 + " // rust.fix_closure'"
                                                    let v3057 : bool = Fable.Core.RustInterop.emitRustExpr () v3056 
                                                    let v3058 : string = "__future_init"
                                                    let v3059 : _ = Fable.Core.RustInterop.emitRustExpr () v3058 
                                                    let v3060 : string = "v3059"
                                                    let v3061 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v3060 
                                                    let v3062 : string = "v3061.await"
                                                    let v3063 : uint8 = Fable.Core.RustInterop.emitRustExpr () v3062 
                                                    let v3064 : US7 = method47(v3063)
                                                    let v3065 : string = v3053 + v3054 
                                                    let v3066 : string = "true; v3064 " + v3065 + "); " + v3053 + " // rust.fix_closure'"
                                                    let v3067 : bool = Fable.Core.RustInterop.emitRustExpr () v3066 
                                                    let v3068 : string = "__future_init"
                                                    let v3069 : _ = Fable.Core.RustInterop.emitRustExpr () v3068 
                                                    let v3070 : string = "v3069"
                                                    let v3071 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v3070 
                                                    v3071
                                        | US6_0(v2605) -> (* Ok *)
                                            match v2605 with
                                            | US4_1 -> (* None *)
                                                let v2606 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2607 : bool = Fable.Core.RustInterop.emitRustExpr () v2606 
                                                let v2608 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2609 : bool = Fable.Core.RustInterop.emitRustExpr () v2608 
                                                let v2610 : uint8 = method72()
                                                let v2611 : string = ""
                                                let v2612 : string = "}"
                                                let v2613 : string = v2611 + v2612 
                                                let v2614 : string = "true; v2610 " + v2613 + "); " + v2611 + " // rust.fix_closure'"
                                                let v2615 : bool = Fable.Core.RustInterop.emitRustExpr () v2614 
                                                let v2616 : string = "__future_init"
                                                let v2617 : _ = Fable.Core.RustInterop.emitRustExpr () v2616 
                                                let v2618 : string = "v2617"
                                                let v2619 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2618 
                                                let v2620 : string = "v2619.await"
                                                let v2621 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2620 
                                                let v2622 : US7 = method49(v2621)
                                                let v2623 : string = v2611 + v2612 
                                                let v2624 : string = "true; v2622 " + v2623 + "); " + v2611 + " // rust.fix_closure'"
                                                let v2625 : bool = Fable.Core.RustInterop.emitRustExpr () v2624 
                                                let v2626 : string = "__future_init"
                                                let v2627 : _ = Fable.Core.RustInterop.emitRustExpr () v2626 
                                                let v2628 : string = "v2627"
                                                let v2629 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2628 
                                                v2629
                                            | US4_0(v2630) -> (* Some *)
                                                let v2631 : unit = ()
                                                let v2632 : (unit -> unit) = closure78(v2630)
                                                let v2633 : unit = (fun () -> v2632 (); v2631) ()
                                                let v2746 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2747 : bool = Fable.Core.RustInterop.emitRustExpr () v2746 
                                                let v2748 : string = "true; let __future_init = Box::pin(async move { //"
                                                let v2749 : bool = Fable.Core.RustInterop.emitRustExpr () v2748 
                                                let v2750 : uint8 = method72()
                                                let v2751 : string = ""
                                                let v2752 : string = "}"
                                                let v2753 : string = v2751 + v2752 
                                                let v2754 : string = "true; v2750 " + v2753 + "); " + v2751 + " // rust.fix_closure'"
                                                let v2755 : bool = Fable.Core.RustInterop.emitRustExpr () v2754 
                                                let v2756 : string = "__future_init"
                                                let v2757 : _ = Fable.Core.RustInterop.emitRustExpr () v2756 
                                                let v2758 : string = "v2757"
                                                let v2759 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2758 
                                                let v2760 : string = "v2759.await"
                                                let v2761 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2760 
                                                let v2762 : US7 = method47(v2761)
                                                let v2763 : string = v2751 + v2752 
                                                let v2764 : string = "true; v2762 " + v2763 + "); " + v2751 + " // rust.fix_closure'"
                                                let v2765 : bool = Fable.Core.RustInterop.emitRustExpr () v2764 
                                                let v2766 : string = "__future_init"
                                                let v2767 : _ = Fable.Core.RustInterop.emitRustExpr () v2766 
                                                let v2768 : string = "v2767"
                                                let v2769 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2768 
                                                v2769
                                    | US6_0(v2303) -> (* Ok *)
                                        match v2303 with
                                        | US4_1 -> (* None *)
                                            let v2304 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2305 : bool = Fable.Core.RustInterop.emitRustExpr () v2304 
                                            let v2306 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2307 : bool = Fable.Core.RustInterop.emitRustExpr () v2306 
                                            let v2308 : uint8 = method73()
                                            let v2309 : string = ""
                                            let v2310 : string = "}"
                                            let v2311 : string = v2309 + v2310 
                                            let v2312 : string = "true; v2308 " + v2311 + "); " + v2309 + " // rust.fix_closure'"
                                            let v2313 : bool = Fable.Core.RustInterop.emitRustExpr () v2312 
                                            let v2314 : string = "__future_init"
                                            let v2315 : _ = Fable.Core.RustInterop.emitRustExpr () v2314 
                                            let v2316 : string = "v2315"
                                            let v2317 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2316 
                                            let v2318 : string = "v2317.await"
                                            let v2319 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2318 
                                            let v2320 : US7 = method49(v2319)
                                            let v2321 : string = v2309 + v2310 
                                            let v2322 : string = "true; v2320 " + v2321 + "); " + v2309 + " // rust.fix_closure'"
                                            let v2323 : bool = Fable.Core.RustInterop.emitRustExpr () v2322 
                                            let v2324 : string = "__future_init"
                                            let v2325 : _ = Fable.Core.RustInterop.emitRustExpr () v2324 
                                            let v2326 : string = "v2325"
                                            let v2327 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2326 
                                            v2327
                                        | US4_0(v2328) -> (* Some *)
                                            let v2329 : unit = ()
                                            let v2330 : (unit -> unit) = closure79(v2328)
                                            let v2331 : unit = (fun () -> v2330 (); v2329) ()
                                            let v2444 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2445 : bool = Fable.Core.RustInterop.emitRustExpr () v2444 
                                            let v2446 : string = "true; let __future_init = Box::pin(async move { //"
                                            let v2447 : bool = Fable.Core.RustInterop.emitRustExpr () v2446 
                                            let v2448 : uint8 = method73()
                                            let v2449 : string = ""
                                            let v2450 : string = "}"
                                            let v2451 : string = v2449 + v2450 
                                            let v2452 : string = "true; v2448 " + v2451 + "); " + v2449 + " // rust.fix_closure'"
                                            let v2453 : bool = Fable.Core.RustInterop.emitRustExpr () v2452 
                                            let v2454 : string = "__future_init"
                                            let v2455 : _ = Fable.Core.RustInterop.emitRustExpr () v2454 
                                            let v2456 : string = "v2455"
                                            let v2457 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2456 
                                            let v2458 : string = "v2457.await"
                                            let v2459 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2458 
                                            let v2460 : US7 = method47(v2459)
                                            let v2461 : string = v2449 + v2450 
                                            let v2462 : string = "true; v2460 " + v2461 + "); " + v2449 + " // rust.fix_closure'"
                                            let v2463 : bool = Fable.Core.RustInterop.emitRustExpr () v2462 
                                            let v2464 : string = "__future_init"
                                            let v2465 : _ = Fable.Core.RustInterop.emitRustExpr () v2464 
                                            let v2466 : string = "v2465"
                                            let v2467 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2466 
                                            v2467
                                | US6_0(v2001) -> (* Ok *)
                                    match v2001 with
                                    | US4_1 -> (* None *)
                                        let v2002 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v2003 : bool = Fable.Core.RustInterop.emitRustExpr () v2002 
                                        let v2004 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v2005 : bool = Fable.Core.RustInterop.emitRustExpr () v2004 
                                        let v2006 : uint8 = method74()
                                        let v2007 : string = ""
                                        let v2008 : string = "}"
                                        let v2009 : string = v2007 + v2008 
                                        let v2010 : string = "true; v2006 " + v2009 + "); " + v2007 + " // rust.fix_closure'"
                                        let v2011 : bool = Fable.Core.RustInterop.emitRustExpr () v2010 
                                        let v2012 : string = "__future_init"
                                        let v2013 : _ = Fable.Core.RustInterop.emitRustExpr () v2012 
                                        let v2014 : string = "v2013"
                                        let v2015 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2014 
                                        let v2016 : string = "v2015.await"
                                        let v2017 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2016 
                                        let v2018 : US7 = method49(v2017)
                                        let v2019 : string = v2007 + v2008 
                                        let v2020 : string = "true; v2018 " + v2019 + "); " + v2007 + " // rust.fix_closure'"
                                        let v2021 : bool = Fable.Core.RustInterop.emitRustExpr () v2020 
                                        let v2022 : string = "__future_init"
                                        let v2023 : _ = Fable.Core.RustInterop.emitRustExpr () v2022 
                                        let v2024 : string = "v2023"
                                        let v2025 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2024 
                                        v2025
                                    | US4_0(v2026) -> (* Some *)
                                        let v2027 : unit = ()
                                        let v2028 : (unit -> unit) = closure80(v2026)
                                        let v2029 : unit = (fun () -> v2028 (); v2027) ()
                                        let v2142 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v2143 : bool = Fable.Core.RustInterop.emitRustExpr () v2142 
                                        let v2144 : string = "true; let __future_init = Box::pin(async move { //"
                                        let v2145 : bool = Fable.Core.RustInterop.emitRustExpr () v2144 
                                        let v2146 : uint8 = method74()
                                        let v2147 : string = ""
                                        let v2148 : string = "}"
                                        let v2149 : string = v2147 + v2148 
                                        let v2150 : string = "true; v2146 " + v2149 + "); " + v2147 + " // rust.fix_closure'"
                                        let v2151 : bool = Fable.Core.RustInterop.emitRustExpr () v2150 
                                        let v2152 : string = "__future_init"
                                        let v2153 : _ = Fable.Core.RustInterop.emitRustExpr () v2152 
                                        let v2154 : string = "v2153"
                                        let v2155 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v2154 
                                        let v2156 : string = "v2155.await"
                                        let v2157 : uint8 = Fable.Core.RustInterop.emitRustExpr () v2156 
                                        let v2158 : US7 = method47(v2157)
                                        let v2159 : string = v2147 + v2148 
                                        let v2160 : string = "true; v2158 " + v2159 + "); " + v2147 + " // rust.fix_closure'"
                                        let v2161 : bool = Fable.Core.RustInterop.emitRustExpr () v2160 
                                        let v2162 : string = "__future_init"
                                        let v2163 : _ = Fable.Core.RustInterop.emitRustExpr () v2162 
                                        let v2164 : string = "v2163"
                                        let v2165 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v2164 
                                        v2165
                            | US6_0(v1699) -> (* Ok *)
                                match v1699 with
                                | US4_1 -> (* None *)
                                    let v1700 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1701 : bool = Fable.Core.RustInterop.emitRustExpr () v1700 
                                    let v1702 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1703 : bool = Fable.Core.RustInterop.emitRustExpr () v1702 
                                    let v1704 : uint8 = method75()
                                    let v1705 : string = ""
                                    let v1706 : string = "}"
                                    let v1707 : string = v1705 + v1706 
                                    let v1708 : string = "true; v1704 " + v1707 + "); " + v1705 + " // rust.fix_closure'"
                                    let v1709 : bool = Fable.Core.RustInterop.emitRustExpr () v1708 
                                    let v1710 : string = "__future_init"
                                    let v1711 : _ = Fable.Core.RustInterop.emitRustExpr () v1710 
                                    let v1712 : string = "v1711"
                                    let v1713 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1712 
                                    let v1714 : string = "v1713.await"
                                    let v1715 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1714 
                                    let v1716 : US7 = method49(v1715)
                                    let v1717 : string = v1705 + v1706 
                                    let v1718 : string = "true; v1716 " + v1717 + "); " + v1705 + " // rust.fix_closure'"
                                    let v1719 : bool = Fable.Core.RustInterop.emitRustExpr () v1718 
                                    let v1720 : string = "__future_init"
                                    let v1721 : _ = Fable.Core.RustInterop.emitRustExpr () v1720 
                                    let v1722 : string = "v1721"
                                    let v1723 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1722 
                                    v1723
                                | US4_0(v1724) -> (* Some *)
                                    let v1725 : unit = ()
                                    let v1726 : (unit -> unit) = closure81(v1724)
                                    let v1727 : unit = (fun () -> v1726 (); v1725) ()
                                    let v1840 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1841 : bool = Fable.Core.RustInterop.emitRustExpr () v1840 
                                    let v1842 : string = "true; let __future_init = Box::pin(async move { //"
                                    let v1843 : bool = Fable.Core.RustInterop.emitRustExpr () v1842 
                                    let v1844 : uint8 = method75()
                                    let v1845 : string = ""
                                    let v1846 : string = "}"
                                    let v1847 : string = v1845 + v1846 
                                    let v1848 : string = "true; v1844 " + v1847 + "); " + v1845 + " // rust.fix_closure'"
                                    let v1849 : bool = Fable.Core.RustInterop.emitRustExpr () v1848 
                                    let v1850 : string = "__future_init"
                                    let v1851 : _ = Fable.Core.RustInterop.emitRustExpr () v1850 
                                    let v1852 : string = "v1851"
                                    let v1853 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1852 
                                    let v1854 : string = "v1853.await"
                                    let v1855 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1854 
                                    let v1856 : US7 = method47(v1855)
                                    let v1857 : string = v1845 + v1846 
                                    let v1858 : string = "true; v1856 " + v1857 + "); " + v1845 + " // rust.fix_closure'"
                                    let v1859 : bool = Fable.Core.RustInterop.emitRustExpr () v1858 
                                    let v1860 : string = "__future_init"
                                    let v1861 : _ = Fable.Core.RustInterop.emitRustExpr () v1860 
                                    let v1862 : string = "v1861"
                                    let v1863 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1862 
                                    v1863
                        | US6_0(v1397) -> (* Ok *)
                            match v1397 with
                            | US4_1 -> (* None *)
                                let v1398 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1399 : bool = Fable.Core.RustInterop.emitRustExpr () v1398 
                                let v1400 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1401 : bool = Fable.Core.RustInterop.emitRustExpr () v1400 
                                let v1402 : uint8 = method76()
                                let v1403 : string = ""
                                let v1404 : string = "}"
                                let v1405 : string = v1403 + v1404 
                                let v1406 : string = "true; v1402 " + v1405 + "); " + v1403 + " // rust.fix_closure'"
                                let v1407 : bool = Fable.Core.RustInterop.emitRustExpr () v1406 
                                let v1408 : string = "__future_init"
                                let v1409 : _ = Fable.Core.RustInterop.emitRustExpr () v1408 
                                let v1410 : string = "v1409"
                                let v1411 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1410 
                                let v1412 : string = "v1411.await"
                                let v1413 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1412 
                                let v1414 : US7 = method49(v1413)
                                let v1415 : string = v1403 + v1404 
                                let v1416 : string = "true; v1414 " + v1415 + "); " + v1403 + " // rust.fix_closure'"
                                let v1417 : bool = Fable.Core.RustInterop.emitRustExpr () v1416 
                                let v1418 : string = "__future_init"
                                let v1419 : _ = Fable.Core.RustInterop.emitRustExpr () v1418 
                                let v1420 : string = "v1419"
                                let v1421 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1420 
                                v1421
                            | US4_0(v1422) -> (* Some *)
                                let v1423 : unit = ()
                                let v1424 : (unit -> unit) = closure82(v1422)
                                let v1425 : unit = (fun () -> v1424 (); v1423) ()
                                let v1538 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1539 : bool = Fable.Core.RustInterop.emitRustExpr () v1538 
                                let v1540 : string = "true; let __future_init = Box::pin(async move { //"
                                let v1541 : bool = Fable.Core.RustInterop.emitRustExpr () v1540 
                                let v1542 : uint8 = method76()
                                let v1543 : string = ""
                                let v1544 : string = "}"
                                let v1545 : string = v1543 + v1544 
                                let v1546 : string = "true; v1542 " + v1545 + "); " + v1543 + " // rust.fix_closure'"
                                let v1547 : bool = Fable.Core.RustInterop.emitRustExpr () v1546 
                                let v1548 : string = "__future_init"
                                let v1549 : _ = Fable.Core.RustInterop.emitRustExpr () v1548 
                                let v1550 : string = "v1549"
                                let v1551 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1550 
                                let v1552 : string = "v1551.await"
                                let v1553 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1552 
                                let v1554 : US7 = method47(v1553)
                                let v1555 : string = v1543 + v1544 
                                let v1556 : string = "true; v1554 " + v1555 + "); " + v1543 + " // rust.fix_closure'"
                                let v1557 : bool = Fable.Core.RustInterop.emitRustExpr () v1556 
                                let v1558 : string = "__future_init"
                                let v1559 : _ = Fable.Core.RustInterop.emitRustExpr () v1558 
                                let v1560 : string = "v1559"
                                let v1561 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1560 
                                v1561
                    | US6_0(v1095) -> (* Ok *)
                        match v1095 with
                        | US4_1 -> (* None *)
                            let v1096 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1097 : bool = Fable.Core.RustInterop.emitRustExpr () v1096 
                            let v1098 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1099 : bool = Fable.Core.RustInterop.emitRustExpr () v1098 
                            let v1100 : uint8 = method77()
                            let v1101 : string = ""
                            let v1102 : string = "}"
                            let v1103 : string = v1101 + v1102 
                            let v1104 : string = "true; v1100 " + v1103 + "); " + v1101 + " // rust.fix_closure'"
                            let v1105 : bool = Fable.Core.RustInterop.emitRustExpr () v1104 
                            let v1106 : string = "__future_init"
                            let v1107 : _ = Fable.Core.RustInterop.emitRustExpr () v1106 
                            let v1108 : string = "v1107"
                            let v1109 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1108 
                            let v1110 : string = "v1109.await"
                            let v1111 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1110 
                            let v1112 : US7 = method49(v1111)
                            let v1113 : string = v1101 + v1102 
                            let v1114 : string = "true; v1112 " + v1113 + "); " + v1101 + " // rust.fix_closure'"
                            let v1115 : bool = Fable.Core.RustInterop.emitRustExpr () v1114 
                            let v1116 : string = "__future_init"
                            let v1117 : _ = Fable.Core.RustInterop.emitRustExpr () v1116 
                            let v1118 : string = "v1117"
                            let v1119 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1118 
                            v1119
                        | US4_0(v1120) -> (* Some *)
                            let v1121 : unit = ()
                            let v1122 : (unit -> unit) = closure83(v1120)
                            let v1123 : unit = (fun () -> v1122 (); v1121) ()
                            let v1236 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1237 : bool = Fable.Core.RustInterop.emitRustExpr () v1236 
                            let v1238 : string = "true; let __future_init = Box::pin(async move { //"
                            let v1239 : bool = Fable.Core.RustInterop.emitRustExpr () v1238 
                            let v1240 : uint8 = method77()
                            let v1241 : string = ""
                            let v1242 : string = "}"
                            let v1243 : string = v1241 + v1242 
                            let v1244 : string = "true; v1240 " + v1243 + "); " + v1241 + " // rust.fix_closure'"
                            let v1245 : bool = Fable.Core.RustInterop.emitRustExpr () v1244 
                            let v1246 : string = "__future_init"
                            let v1247 : _ = Fable.Core.RustInterop.emitRustExpr () v1246 
                            let v1248 : string = "v1247"
                            let v1249 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v1248 
                            let v1250 : string = "v1249.await"
                            let v1251 : uint8 = Fable.Core.RustInterop.emitRustExpr () v1250 
                            let v1252 : US7 = method47(v1251)
                            let v1253 : string = v1241 + v1242 
                            let v1254 : string = "true; v1252 " + v1253 + "); " + v1241 + " // rust.fix_closure'"
                            let v1255 : bool = Fable.Core.RustInterop.emitRustExpr () v1254 
                            let v1256 : string = "__future_init"
                            let v1257 : _ = Fable.Core.RustInterop.emitRustExpr () v1256 
                            let v1258 : string = "v1257"
                            let v1259 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v1258 
                            v1259
                | US6_0(v793) -> (* Ok *)
                    match v793 with
                    | US4_1 -> (* None *)
                        let v794 : string = "true; let __future_init = Box::pin(async move { //"
                        let v795 : bool = Fable.Core.RustInterop.emitRustExpr () v794 
                        let v796 : string = "true; let __future_init = Box::pin(async move { //"
                        let v797 : bool = Fable.Core.RustInterop.emitRustExpr () v796 
                        let v798 : uint8 = method78()
                        let v799 : string = ""
                        let v800 : string = "}"
                        let v801 : string = v799 + v800 
                        let v802 : string = "true; v798 " + v801 + "); " + v799 + " // rust.fix_closure'"
                        let v803 : bool = Fable.Core.RustInterop.emitRustExpr () v802 
                        let v804 : string = "__future_init"
                        let v805 : _ = Fable.Core.RustInterop.emitRustExpr () v804 
                        let v806 : string = "v805"
                        let v807 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v806 
                        let v808 : string = "v807.await"
                        let v809 : uint8 = Fable.Core.RustInterop.emitRustExpr () v808 
                        let v810 : US7 = method49(v809)
                        let v811 : string = v799 + v800 
                        let v812 : string = "true; v810 " + v811 + "); " + v799 + " // rust.fix_closure'"
                        let v813 : bool = Fable.Core.RustInterop.emitRustExpr () v812 
                        let v814 : string = "__future_init"
                        let v815 : _ = Fable.Core.RustInterop.emitRustExpr () v814 
                        let v816 : string = "v815"
                        let v817 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v816 
                        v817
                    | US4_0(v818) -> (* Some *)
                        let v819 : unit = ()
                        let v820 : (unit -> unit) = closure84(v818)
                        let v821 : unit = (fun () -> v820 (); v819) ()
                        let v934 : string = "true; let __future_init = Box::pin(async move { //"
                        let v935 : bool = Fable.Core.RustInterop.emitRustExpr () v934 
                        let v936 : string = "true; let __future_init = Box::pin(async move { //"
                        let v937 : bool = Fable.Core.RustInterop.emitRustExpr () v936 
                        let v938 : uint8 = method78()
                        let v939 : string = ""
                        let v940 : string = "}"
                        let v941 : string = v939 + v940 
                        let v942 : string = "true; v938 " + v941 + "); " + v939 + " // rust.fix_closure'"
                        let v943 : bool = Fable.Core.RustInterop.emitRustExpr () v942 
                        let v944 : string = "__future_init"
                        let v945 : _ = Fable.Core.RustInterop.emitRustExpr () v944 
                        let v946 : string = "v945"
                        let v947 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v946 
                        let v948 : string = "v947.await"
                        let v949 : uint8 = Fable.Core.RustInterop.emitRustExpr () v948 
                        let v950 : US7 = method47(v949)
                        let v951 : string = v939 + v940 
                        let v952 : string = "true; v950 " + v951 + "); " + v939 + " // rust.fix_closure'"
                        let v953 : bool = Fable.Core.RustInterop.emitRustExpr () v952 
                        let v954 : string = "__future_init"
                        let v955 : _ = Fable.Core.RustInterop.emitRustExpr () v954 
                        let v956 : string = "v955"
                        let v957 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v956 
                        v957
            | US6_0(v491) -> (* Ok *)
                match v491 with
                | US4_1 -> (* None *)
                    let v492 : string = "true; let __future_init = Box::pin(async move { //"
                    let v493 : bool = Fable.Core.RustInterop.emitRustExpr () v492 
                    let v494 : string = "true; let __future_init = Box::pin(async move { //"
                    let v495 : bool = Fable.Core.RustInterop.emitRustExpr () v494 
                    let v496 : uint8 = method79()
                    let v497 : string = ""
                    let v498 : string = "}"
                    let v499 : string = v497 + v498 
                    let v500 : string = "true; v496 " + v499 + "); " + v497 + " // rust.fix_closure'"
                    let v501 : bool = Fable.Core.RustInterop.emitRustExpr () v500 
                    let v502 : string = "__future_init"
                    let v503 : _ = Fable.Core.RustInterop.emitRustExpr () v502 
                    let v504 : string = "v503"
                    let v505 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v504 
                    let v506 : string = "v505.await"
                    let v507 : uint8 = Fable.Core.RustInterop.emitRustExpr () v506 
                    let v508 : US7 = method49(v507)
                    let v509 : string = v497 + v498 
                    let v510 : string = "true; v508 " + v509 + "); " + v497 + " // rust.fix_closure'"
                    let v511 : bool = Fable.Core.RustInterop.emitRustExpr () v510 
                    let v512 : string = "__future_init"
                    let v513 : _ = Fable.Core.RustInterop.emitRustExpr () v512 
                    let v514 : string = "v513"
                    let v515 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v514 
                    v515
                | US4_0(v516) -> (* Some *)
                    let v517 : unit = ()
                    let v518 : (unit -> unit) = closure85(v516)
                    let v519 : unit = (fun () -> v518 (); v517) ()
                    let v632 : string = "true; let __future_init = Box::pin(async move { //"
                    let v633 : bool = Fable.Core.RustInterop.emitRustExpr () v632 
                    let v634 : string = "true; let __future_init = Box::pin(async move { //"
                    let v635 : bool = Fable.Core.RustInterop.emitRustExpr () v634 
                    let v636 : uint8 = method79()
                    let v637 : string = ""
                    let v638 : string = "}"
                    let v639 : string = v637 + v638 
                    let v640 : string = "true; v636 " + v639 + "); " + v637 + " // rust.fix_closure'"
                    let v641 : bool = Fable.Core.RustInterop.emitRustExpr () v640 
                    let v642 : string = "__future_init"
                    let v643 : _ = Fable.Core.RustInterop.emitRustExpr () v642 
                    let v644 : string = "v643"
                    let v645 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v644 
                    let v646 : string = "v645.await"
                    let v647 : uint8 = Fable.Core.RustInterop.emitRustExpr () v646 
                    let v648 : US7 = method47(v647)
                    let v649 : string = v637 + v638 
                    let v650 : string = "true; v648 " + v649 + "); " + v637 + " // rust.fix_closure'"
                    let v651 : bool = Fable.Core.RustInterop.emitRustExpr () v650 
                    let v652 : string = "__future_init"
                    let v653 : _ = Fable.Core.RustInterop.emitRustExpr () v652 
                    let v654 : string = "v653"
                    let v655 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v654 
                    v655
        | US6_0(v189) -> (* Ok *)
            match v189 with
            | US4_1 -> (* None *)
                let v190 : string = "true; let __future_init = Box::pin(async move { //"
                let v191 : bool = Fable.Core.RustInterop.emitRustExpr () v190 
                let v192 : string = "true; let __future_init = Box::pin(async move { //"
                let v193 : bool = Fable.Core.RustInterop.emitRustExpr () v192 
                let v194 : uint8 = method80()
                let v195 : string = ""
                let v196 : string = "}"
                let v197 : string = v195 + v196 
                let v198 : string = "true; v194 " + v197 + "); " + v195 + " // rust.fix_closure'"
                let v199 : bool = Fable.Core.RustInterop.emitRustExpr () v198 
                let v200 : string = "__future_init"
                let v201 : _ = Fable.Core.RustInterop.emitRustExpr () v200 
                let v202 : string = "v201"
                let v203 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v202 
                let v204 : string = "v203.await"
                let v205 : uint8 = Fable.Core.RustInterop.emitRustExpr () v204 
                let v206 : US7 = method49(v205)
                let v207 : string = v195 + v196 
                let v208 : string = "true; v206 " + v207 + "); " + v195 + " // rust.fix_closure'"
                let v209 : bool = Fable.Core.RustInterop.emitRustExpr () v208 
                let v210 : string = "__future_init"
                let v211 : _ = Fable.Core.RustInterop.emitRustExpr () v210 
                let v212 : string = "v211"
                let v213 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v212 
                v213
            | US4_0(v214) -> (* Some *)
                let v215 : unit = ()
                let v216 : (unit -> unit) = closure86(v214)
                let v217 : unit = (fun () -> v216 (); v215) ()
                let v330 : string = "true; let __future_init = Box::pin(async move { //"
                let v331 : bool = Fable.Core.RustInterop.emitRustExpr () v330 
                let v332 : string = "true; let __future_init = Box::pin(async move { //"
                let v333 : bool = Fable.Core.RustInterop.emitRustExpr () v332 
                let v334 : uint8 = method80()
                let v335 : string = ""
                let v336 : string = "}"
                let v337 : string = v335 + v336 
                let v338 : string = "true; v334 " + v337 + "); " + v335 + " // rust.fix_closure'"
                let v339 : bool = Fable.Core.RustInterop.emitRustExpr () v338 
                let v340 : string = "__future_init"
                let v341 : _ = Fable.Core.RustInterop.emitRustExpr () v340 
                let v342 : string = "v341"
                let v343 : std_pin_Pin<Box<Dyn<std_future_Future<uint8>>>> = Fable.Core.RustInterop.emitRustExpr () v342 
                let v344 : string = "v343.await"
                let v345 : uint8 = Fable.Core.RustInterop.emitRustExpr () v344 
                let v346 : US7 = method47(v345)
                let v347 : string = v335 + v336 
                let v348 : string = "true; v346 " + v347 + "); " + v335 + " // rust.fix_closure'"
                let v349 : bool = Fable.Core.RustInterop.emitRustExpr () v348 
                let v350 : string = "__future_init"
                let v351 : _ = Fable.Core.RustInterop.emitRustExpr () v350 
                let v352 : string = "v351"
                let v353 : std_pin_Pin<Box<Dyn<std_future_Future<US7>>>> = Fable.Core.RustInterop.emitRustExpr () v352 
                v353
    let v9010 : string = "v9009.await"
    let v9011 : US7 = Fable.Core.RustInterop.emitRustExpr () v9010 
    let v9012 : unit = ()
    let v9013 : (unit -> unit) = closure87(v9011)
    let v9014 : unit = (fun () -> v9013 (); v9012) ()
    let v9146 : Result<uint8, anyhow_Error> =
        match v9011 with
        | US7_1(v9128) -> (* Error *)
            let v9129 : string = method82(v9128)
            let v9130 : string = "anyhow::anyhow!($0)"
            let v9131 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v9129 v9130 
            let v9132 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v9133 : string = "Err($0)"
            let v9134 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v9131 v9133 
            let _v9132 = v9134 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v9135 : string = "Err($0)"
            let v9136 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v9131 v9135 
            let _v9132 = v9136 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v9137 : string = "Err($0)"
            let v9138 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v9131 v9137 
            let _v9132 = v9138 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v9139 : Result<uint8, anyhow_Error> = v9131 |> Error
            let _v9132 = v9139 
            #endif
#if FABLE_COMPILER_PYTHON
            let v9140 : Result<uint8, anyhow_Error> = v9131 |> Error
            let _v9132 = v9140 
            #endif
#else
            let v9141 : Result<uint8, anyhow_Error> = v9131 |> Error
            let _v9132 = v9141 
            #endif
            let v9142 : Result<uint8, anyhow_Error> = _v9132 
            v9142
        | US7_0(v9126) -> (* Ok *)
            let v9127 : Result<uint8, anyhow_Error> = Ok v9126 
            v9127
    let v9147 : Result<uint8, anyhow_Error> = method83(v9146)
    let v9148 : string = ""
    let v9149 : string = "}"
    let v9150 : string = v9148 + v9149 
    let v9151 : string = "true; v9147 " + v9150 + "); " + v9148 + " // rust.fix_closure'"
    let v9152 : bool = Fable.Core.RustInterop.emitRustExpr () v9151 
    let v9153 : string = "__future_init"
    let v9154 : _ = Fable.Core.RustInterop.emitRustExpr () v9153 
    let v9155 : string = "v9154"
    let v9156 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v9155 
    v9156
and closure88 () (v0 : uint8) : US8 =
    US8_0(v0)
and method84 () : (uint8 -> US8) =
    closure88()
and closure0 () (v0 : (string [])) : int32 =
    let v1 : clap_Command = method0()
    let v2 : string = "clap::Command::get_matches($0)"
    let v3 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = method1()
    let v5 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = "&*$0"
    let v7 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v6 
    let _v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v8 
    let _v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v10 
    let _v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _v5 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _v5 = v15 
    #endif
#else
    let v18 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _v5 = v18 
    #endif
    let v21 : Ref<Str> = _v5 
    let v26 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v27 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v3, v21) v26 
    let v28 : (std_string_String -> US0) = method2()
    let v29 : US0 option = v27 |> Option.map v28 
    let v40 : US0 = US0_1
    let v41 : US0 = v29 |> Option.defaultValue v40 
    let v97 : US1 =
        match v41 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v45) -> (* Some *)
            let v46 : string = "fable_library_rust::String_::fromString($0)"
            let v47 : string = Fable.Core.RustInterop.emitRustExpr v45 v46 
            
            
            
            
            
            let v48 : bool = "Verbose" = v47
            let v52 : US2 =
                if v48 then
                    let v49 : US3 = US3_0
                    US2_0(v49)
                else
                    US2_1
            let v93 : US2 =
                match v52 with
                | US2_1 -> (* None *)
                    let v55 : bool = "Debug" = v47
                    let v59 : US2 =
                        if v55 then
                            let v56 : US3 = US3_1
                            US2_0(v56)
                        else
                            US2_1
                    match v59 with
                    | US2_1 -> (* None *)
                        let v62 : bool = "Info" = v47
                        let v66 : US2 =
                            if v62 then
                                let v63 : US3 = US3_2
                                US2_0(v63)
                            else
                                US2_1
                        match v66 with
                        | US2_1 -> (* None *)
                            let v69 : bool = "Warning" = v47
                            let v73 : US2 =
                                if v69 then
                                    let v70 : US3 = US3_3
                                    US2_0(v70)
                                else
                                    US2_1
                            match v73 with
                            | US2_1 -> (* None *)
                                let v76 : bool = "Critical" = v47
                                let v80 : US2 =
                                    if v76 then
                                        let v77 : US3 = US3_4
                                        US2_0(v77)
                                    else
                                        US2_1
                                match v80 with
                                | US2_1 -> (* None *)
                                    US2_1
                                | US2_0(v81) -> (* Some *)
                                    US2_0(v81)
                            | US2_0(v74) -> (* Some *)
                                US2_0(v74)
                        | US2_0(v67) -> (* Some *)
                            US2_0(v67)
                    | US2_0(v60) -> (* Some *)
                        US2_0(v60)
                | US2_0(v53) -> (* Some *)
                    US2_0(v53)
            US1_0(v93)
    let v104 : US2 =
        match v97 with
        | US1_0(v98) -> (* Some *)
            match v98 with
            | US2_0(v99) -> (* Some *)
                US2_0(v99)
            | _ ->
                US2_1
        | _ ->
            US2_1
    let v108 : US3 =
        match v104 with
        | US2_1 -> (* None *)
            US3_0
        | US2_0(v105) -> (* Some *)
            v105
    let v109 : unit = ()
    let v110 : (unit -> unit) = closure2(v108)
    let v111 : unit = (fun () -> v110 (); v109) ()
    let struct (v123 : Mut0, v124 : Mut1, v125 : Mut2, v126 : Mut3, v127 : Mut4, v128 : int64 option) = TraceState.trace_state.Value
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure5(v0)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v259 : string = method19()
    let v260 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v261 : string = "&*$0"
    let v262 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v259 v261 
    let _v260 = v262 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v263 : string = "&*$0"
    let v264 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v259 v263 
    let _v260 = v264 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v265 : string = "&*$0"
    let v266 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v259 v265 
    let _v260 = v266 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v267 : Ref<Str> = v259 |> unbox<Ref<Str>>
    let _v260 = v267 
    #endif
#if FABLE_COMPILER_PYTHON
    let v270 : Ref<Str> = v259 |> unbox<Ref<Str>>
    let _v260 = v270 
    #endif
#else
    let v273 : Ref<Str> = v259 |> unbox<Ref<Str>>
    let _v260 = v273 
    #endif
    let v276 : Ref<Str> = _v260 
    let v281 : string = "clap::ArgMatches::get_flag(&$0, $1)"
    let v282 : bool = Fable.Core.RustInterop.emitRustExpr struct (v3, v276) v281 
    let v283 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = method20(v3)
    let v284 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v285 : _ = Fable.Core.RustInterop.emitRustExpr () v284 
    let v286 : string = "v285.handle().block_on($0)"
    let v287 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v283 v286 
    let v288 : (anyhow_Error -> std_string_String) = method42()
    let v289 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v290 : string = "$0.map_err(|x| $1(x))"
    let v291 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v287, v288) v290 
    let _v289 = v291 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v292 : string = "$0.map_err(|x| $1(x))"
    let v293 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v287, v288) v292 
    let _v289 = v293 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v294 : string = "$0.map_err(|x| $1(x))"
    let v295 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v287, v288) v294 
    let _v289 = v295 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v296 : Result<uint8, std_string_String> = match v287 with Ok x -> Ok x | Error x -> Error (v288 x)
    let _v289 = v296 
    #endif
#if FABLE_COMPILER_PYTHON
    let v297 : Result<uint8, std_string_String> = match v287 with Ok x -> Ok x | Error x -> Error (v288 x)
    let _v289 = v297 
    #endif
#else
    let v298 : Result<uint8, std_string_String> = match v287 with Ok x -> Ok x | Error x -> Error (v288 x)
    let _v289 = v298 
    #endif
    let v299 : Result<uint8, std_string_String> = _v289 
    let v302 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v303 : string = "$0.ok()"
    let v304 : uint8 option = Fable.Core.RustInterop.emitRustExpr v299 v303 
    let _v302 = v304 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v305 : string = "$0.ok()"
    let v306 : uint8 option = Fable.Core.RustInterop.emitRustExpr v299 v305 
    let _v302 = v306 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v307 : string = "$0.ok()"
    let v308 : uint8 option = Fable.Core.RustInterop.emitRustExpr v299 v307 
    let _v302 = v308 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v309 : uint8 option = match v299 with Ok x -> Some x | Error _ -> None
    let _v302 = v309 
    #endif
#if FABLE_COMPILER_PYTHON
    let v310 : uint8 option = match v299 with Ok x -> Some x | Error _ -> None
    let _v302 = v310 
    #endif
#else
    let v311 : uint8 option = match v299 with Ok x -> Some x | Error _ -> None
    let _v302 = v311 
    #endif
    let v312 : uint8 option = _v302 
    let v315 : (uint8 -> US8) = method84()
    let v316 : US8 option = v312 |> Option.map v315 
    let v327 : US8 = US8_1
    let v328 : US8 = v316 |> Option.defaultValue v327 
    match v328 with
    | US8_1 -> (* None *)
        if v282 then
            ()
        else
            let v351 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v352 : string = "$0.unwrap()"
            let v353 : uint8 = Fable.Core.RustInterop.emitRustExpr v299 v352 
            let _v351 = v353 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v354 : string = "$0.unwrap()"
            let v355 : uint8 = Fable.Core.RustInterop.emitRustExpr v299 v354 
            let _v351 = v355 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v356 : string = "$0.unwrap()"
            let v357 : uint8 = Fable.Core.RustInterop.emitRustExpr v299 v356 
            let _v351 = v357 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v358 : uint8 = match v299 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v351 = v358 
            #endif
#if FABLE_COMPILER_PYTHON
            let v359 : uint8 = match v299 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v351 = v359 
            #endif
#else
            let v360 : uint8 = match v299 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v351 = v360 
            #endif
            let v361 : uint8 = _v351 
            ()
    | US8_0(v332) -> (* Some *)
        if v282 then
            let v333 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v334 : string = "Err($0)"
            let v335 : string = "spiral_wasm.main / exception=true"
            let v336 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v335 v334 
            let _v333 = v336 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v337 : string = "Err($0)"
            let v338 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v335 v337 
            let _v333 = v338 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v339 : string = "Err($0)"
            let v340 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v335 v339 
            let _v333 = v340 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v341 : Result<unit, string> = v335 |> Error
            let _v333 = v341 
            #endif
#if FABLE_COMPILER_PYTHON
            let v342 : Result<unit, string> = v335 |> Error
            let _v333 = v342 
            #endif
#else
            let v343 : Result<unit, string> = v335 |> Error
            let _v333 = v343 
            #endif
            let v344 : Result<unit, string> = _v333 
            let v347 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v348 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v344 v348 
            let _v347 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v349 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v344 v349 
            let _v347 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v350 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v344 v350 
            let _v347 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v347 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v347 = () 
            #endif
#else
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v347 = () 
            #endif
            _v347 
            ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
