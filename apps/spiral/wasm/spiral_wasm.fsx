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
[<Fable.Core.Erase; Fable.Core.Emit("clap::builder::ValueRange")>]
#endif
type clap_builder_ValueRange = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_workspaces::Worker<$0>")>]
#endif
type near_workspaces_Worker<'T> = class end
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
    | US6_0 of f0_0 : uint8 * f0_1 : US4
    | US6_1 of f1_0 : uint8 * f1_1 : US4
and [<Struct>] US7 =
    | US7_0 of f0_0 : US4
    | US7_1 of f1_0 : std_string_String
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint8
    | US8_1 of f1_0 : std_string_String
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "clap::Command::args_override_self($0, true)"
    let v6 : clap_Command = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : unativeint = 0 |> unativeint 
    let v10 : unativeint = 1 |> unativeint 
    let v13 : bool = v10 = v7 
    let v21 : clap_builder_ValueRange =
        if v13 then
            let v16 : string = "clap::builder::ValueRange::new($0..)"
            let v17 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr v7 v16 
            v17
        else
            let v18 : string = "="
            let v19 : string = "clap::builder::ValueRange::new($0.." + v18 + "$1)"
            let v20 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr struct (v7, v10) v19 
            v20
    let v22 : string = "exception"
    let v23 : string = "r#\"" + v22 + "\"#"
    let v24 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "clap::Arg::new($0)"
    let v26 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "$0.short($1)"
    let v28 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v26, 'e') v27 
    let v29 : string = "r#\"" + v22 + "\"#"
    let v30 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = "$0.long($1)"
    let v32 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v28, v30) v31 
    let v33 : string = "$0.num_args($1)"
    let v34 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v32, v21) v33 
    let v35 : string = "$0.require_equals($1)"
    let v36 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v34, true) v35 
    let v37 : string = ""
    let v38 : string = "r#\"" + v37 + "\"#"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "$0.default_missing_value($1)"
    let v41 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v36, v39) v40 
    let v42 : string = "clap::Command::arg($0, $1)"
    let v43 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v6, v41) v42 
    let v44 : string = "trace_level"
    let v45 : string = "r#\"" + v44 + "\"#"
    let v46 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v45 
    let v47 : string = "clap::Arg::new($0)"
    let v48 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v46 v47 
    let v49 : string = "$0.short($1)"
    let v50 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v48, 't') v49 
    let v51 : string = "r#\"" + v44 + "\"#"
    let v52 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v51 
    let v53 : string = "$0.long($1)"
    let v54 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v50, v52) v53 
    
    
    
    
    
    let v55 : string list = []
    let v56 : string = "Critical"
    let v57 : string list = v56 :: v55 
    let v60 : string = "Warning"
    let v61 : string list = v60 :: v57 
    let v64 : string = "Info"
    let v65 : string list = v64 :: v61 
    let v68 : string = "Debug"
    let v69 : string list = v68 :: v65 
    let v72 : string = "Verbose"
    let v73 : string list = v72 :: v69 
    let v76 : (string list -> (string [])) = List.toArray
    let v77 : (string []) = v76 v73
    let v80 : string = "$0.to_vec()"
    let v81 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v77 v80 
    let v82 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v83 : bool = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "x"
    let v85 : string = Fable.Core.RustInterop.emitRustExpr () v84 
    let v86 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : string = "&*$0"
    let v88 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v85 v87 
    let _v86 = v88 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v89 : string = "&*$0"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v85 v89 
    let _v86 = v90 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v91 : string = "&*$0"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v85 v91 
    let _v86 = v92 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v93 : Ref<Str> = v85 |> unbox<Ref<Str>>
    let _v86 = v93 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : Ref<Str> = v85 |> unbox<Ref<Str>>
    let _v86 = v96 
    #endif
#else
    let v99 : Ref<Str> = v85 |> unbox<Ref<Str>>
    let _v86 = v99 
    #endif
    let v102 : Ref<Str> = _v86 
    let v107 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v108 : string = "String::from($0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v108 
    let _v107 = v109 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v110 : string = "String::from($0)"
    let v111 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v110 
    let _v107 = v111 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v112 : string = "String::from($0)"
    let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v112 
    let _v107 = v113 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v114 : std_string_String = v102 |> unbox<std_string_String>
    let _v107 = v114 
    #endif
#if FABLE_COMPILER_PYTHON
    let v117 : std_string_String = v102 |> unbox<std_string_String>
    let _v107 = v117 
    #endif
#else
    let v120 : std_string_String = v102 |> unbox<std_string_String>
    let _v107 = v120 
    #endif
    let v123 : std_string_String = _v107 
    let v128 : string = "Box::new($0)"
    let v129 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v123 v128 
    let v130 : string = "Box::leak($0)"
    let v131 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v129 v130 
    let v132 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v133 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let v134 : string = "true; $0 }).collect::<Vec<_>>()"
    let v135 : bool = Fable.Core.RustInterop.emitRustExpr v133 v134 
    let v136 : string = "_vec_map"
    let v137 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v136 
    let v138 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v139 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let v140 : string = "$0.value_parser($1)"
    let v141 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, v139) v140 
    let v142 : string = "clap::Command::arg($0, $1)"
    let v143 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v43, v141) v142 
    let v144 : string = "wasm"
    let v145 : string = "r#\"" + v144 + "\"#"
    let v146 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "clap::Arg::new($0)"
    let v148 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v146 v147 
    let v149 : string = "$0.short($1)"
    let v150 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v148, 'w') v149 
    let v151 : string = "r#\"" + v144 + "\"#"
    let v152 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "$0.long($1)"
    let v154 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v150, v152) v153 
    let v155 : string = "$0.required($1)"
    let v156 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v154, true) v155 
    let v157 : string = "clap::Command::arg($0, $1)"
    let v158 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v143, v156) v157 
    v158
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
and method9 (v0 : US3) : bool =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US3 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    if v37 then
        false
    else
        let v38 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v0
        let v39 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v35
        let v40 : bool = v38 >= v39
        v40
and closure7 () (v0 : int64) : US5 =
    US5_0(v0)
and method11 () : (int64 -> US5) =
    closure7()
and method12 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method13 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method10 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US5) = method11()
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
    let v61 : string = method12()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US5) = method11()
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
    let v122 : string = method12()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US5) = method11()
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
    let v164 : (int64 -> US5) = method11()
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
    let v218 : string = method13()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US5) = method11()
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
    let v279 : string = method13()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US5) = method11()
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
    let v340 : string = method13()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method16 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method15 (v0 : char) : string =
    let v1 : string = method16()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method17 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method14 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method15(v5)
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
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_bright_black"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_bright_black"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[90m"
    let v96 : string = method17()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[90m"
    let v100 : string = method17()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[90m"
    let v104 : string = method17()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method19 (v0 : (string [])) : string =
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
and method20 (v0 : string) : string =
    let v1 : char list = []
    let v2 : (char list -> (char [])) = List.toArray
    let v3 : (char []) = v2 v1
    let v6 : string = v0.TrimStart v3 
    let v24 : char list = []
    let v25 : char list = '/' :: v24 
    let v28 : char list = ' ' :: v25 
    let v31 : (char list -> (char [])) = List.toArray
    let v32 : (char []) = v31 v28
    let v35 : string = v6.TrimEnd v32 
    v35
and method18 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method19(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
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
and method21 (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
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
#else
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
    let v70 : Ref<Str> = _v54 
    let v75 : string = $"$0.chars()"
    let v76 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v70 v75 
    let v77 : string = "$0"
    let v78 : _ = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "$0.collect::<Vec<_>>()"
    let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v82 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "x"
    let v86 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v85 
    let v87 : string = "String::from_iter($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : string = "true; $0 }).collect::<Vec<_>>()"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "_vec_map"
    let v92 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "$0.len()"
    let v94 : unativeint = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : (unativeint -> int32) = int32
    let v96 : int32 = v95 v94
    let v97 : string = ""
    let v98 : bool = v0 <> v97 
    let v102 : bool =
        if v98 then
            let v101 : bool = v96 <= 1
            v101
        else
            false
    if v102 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v97
        let v103 : string = "true; $0.into_iter().for_each(|x| { //"
        let v104 : bool = Fable.Core.RustInterop.emitRustExpr v92 v103 
        let v105 : string = "x"
        let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v105 
        let v107 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
        let v109 : string = $"true"
        let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
        let v111 : string = "true; }); //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
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
#else
    v40 v0
    let _v41 = () 
    #endif
    _v41 
    let v113 : (string -> unit) = v18.l0
    v113 v0
and closure5 (v0 : (string [])) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method18(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method22 () : string =
    let v0 : string = "exception"
    v0
and closure12 () (v0 : std_string_String) : string =
    let v1 : string = "fable_library_rust::String_::fromString($0)"
    let v2 : string = Fable.Core.RustInterop.emitRustExpr v0 v1 
    let v3 : char list = []
    let v4 : char list = '\\' :: v3 
    let v7 : (char list -> (char [])) = List.toArray
    let v8 : (char []) = v7 v4
    let v11 : string = v2.TrimStart v8 
    let v29 : char list = []
    let v30 : char list = '\\' :: v29 
    let v33 : (char list -> (char [])) = List.toArray
    let v34 : (char []) = v33 v30
    let v37 : string = v11.TrimEnd v34 
    v37
and method23 () : (std_string_String -> string) =
    closure12()
and method25 () : string =
    let v0 : string = "wasm"
    v0
and method27 (v0 : string) : string =
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
and method26 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method27(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
and closure13 (v0 : string) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method26(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method29 (v0 : uint8) : struct (uint8 * US4) =
    let v1 : US4 = US4_1
    struct (v0, v1)
and method32 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v2 : near_workspaces_Contract) : string =
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
    let v49 : string = "worker"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : string = "format!(\"{:#?}\", $0)"
    let v68 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v67 
    let v69 : string = "fable_library_rust::String_::fromString($0)"
    let v70 : string = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let _v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "format!(\"{:#?}\", $0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v71 
    let v73 : string = "fable_library_rust::String_::fromString($0)"
    let v74 : string = Fable.Core.RustInterop.emitRustExpr v72 v73 
    let _v66 = v74 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : string = "format!(\"{:#?}\", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let _v66 = v78 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v79 : string = $"%A{v1}"
    let _v66 = v79 
    #endif
#if FABLE_COMPILER_PYTHON
    let v82 : string = $"%A{v1}"
    let _v66 = v82 
    #endif
#else
    let v85 : string = $"%A{v1}"
    let _v66 = v85 
    #endif
    let v88 : string = _v66 
    let v93 : string = $"{v88}"
    let v96 : unit = ()
    let v97 : (unit -> unit) = closure8(v4, v93)
    let v98 : unit = (fun () -> v97 (); v96) ()
    let v101 : string = $"{v40}"
    let v104 : unit = ()
    let v105 : (unit -> unit) = closure8(v4, v101)
    let v106 : unit = (fun () -> v105 (); v104) ()
    let v109 : string = "contract"
    let v110 : string = $"{v109}"
    let v113 : unit = ()
    let v114 : (unit -> unit) = closure8(v4, v110)
    let v115 : unit = (fun () -> v114 (); v113) ()
    let v118 : string = $"{v23}"
    let v121 : unit = ()
    let v122 : (unit -> unit) = closure8(v4, v118)
    let v123 : unit = (fun () -> v122 (); v121) ()
    let v126 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v127 : string = "format!(\"{:#?}\", $0)"
    let v128 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v127 
    let v129 : string = "fable_library_rust::String_::fromString($0)"
    let v130 : string = Fable.Core.RustInterop.emitRustExpr v128 v129 
    let _v126 = v130 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v131 : string = "format!(\"{:#?}\", $0)"
    let v132 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v131 
    let v133 : string = "fable_library_rust::String_::fromString($0)"
    let v134 : string = Fable.Core.RustInterop.emitRustExpr v132 v133 
    let _v126 = v134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v135 : string = "format!(\"{:#?}\", $0)"
    let v136 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v135 
    let v137 : string = "fable_library_rust::String_::fromString($0)"
    let v138 : string = Fable.Core.RustInterop.emitRustExpr v136 v137 
    let _v126 = v138 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v139 : string = $"%A{v2}"
    let _v126 = v139 
    #endif
#if FABLE_COMPILER_PYTHON
    let v142 : string = $"%A{v2}"
    let _v126 = v142 
    #endif
#else
    let v145 : string = $"%A{v2}"
    let _v126 = v145 
    #endif
    let v148 : string = _v126 
    let v153 : string = $"{v148}"
    let v156 : unit = ()
    let v157 : (unit -> unit) = closure8(v4, v153)
    let v158 : unit = (fun () -> v157 (); v156) ()
    let v161 : string = " }"
    let v162 : string = $"{v161}"
    let v165 : unit = ()
    let v166 : (unit -> unit) = closure8(v4, v162)
    let v167 : unit = (fun () -> v166 (); v165) ()
    let v170 : string = v4.l0
    v170
and method31 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v10 : near_workspaces_Contract) : string =
    let v11 : string = method32(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "spiral_wasm.run"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method20(v14)
and closure14 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v2 : near_workspaces_Contract) () : unit =
    let v3 : US3 = US3_0
    let v4 : bool = method9(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method10(v21, v22, v23, v24, v25, v26)
        let v40 : string = method14()
        let v41 : string = method31(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method21(v41)
and method34 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) : string =
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
and method33 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : near_workspaces_result_ExecutionFinalResult) : string =
    let v10 : string = method34(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method20(v13)
and closure15 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) () : unit =
    let v2 : US3 = US3_0
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method14()
        let v40 : string = method33(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and closure17 (v0 : std_string_String) () : unit =
    let v1 : (std_string_String -> unit) = System.Console.WriteLine
    v1 v0
and closure16 () (v0 : std_string_String) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure17(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method35 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure6()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure9(v16)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = " "
    let v40 : (string -> unit) = closure10()
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
#else
    let v67 : Ref<Str> = v53 |> unbox<Ref<Str>>
    let _v54 = v67 
    #endif
    let v70 : Ref<Str> = _v54 
    let v75 : string = $"$0.chars()"
    let v76 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v70 v75 
    let v77 : string = "$0"
    let v78 : _ = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let v79 : string = "$0.collect::<Vec<_>>()"
    let v80 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v82 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v84 : bool = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "x"
    let v86 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v85 
    let v87 : string = "String::from_iter($0)"
    let v88 : std_string_String = Fable.Core.RustInterop.emitRustExpr v86 v87 
    let v89 : string = "true; $0 }).collect::<Vec<_>>()"
    let v90 : bool = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "_vec_map"
    let v92 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v91 
    let v93 : string = "$0.len()"
    let v94 : unativeint = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let v95 : (unativeint -> int32) = int32
    let v96 : int32 = v95 v94
    let v97 : string = ""
    let v98 : bool = v39 <> v97 
    let v102 : bool =
        if v98 then
            let v101 : bool = v96 <= 1
            v101
        else
            false
    if v102 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v97
        let v103 : string = "true; $0.into_iter().for_each(|x| { //"
        let v104 : bool = Fable.Core.RustInterop.emitRustExpr v92 v103 
        let v105 : string = "x"
        let v106 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v105 
        let v107 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v108 : bool = Fable.Core.RustInterop.emitRustExpr v106 v107 
        let v109 : string = $"true"
        let v110 : bool = Fable.Core.RustInterop.emitRustExpr () v109 
        let v111 : string = "true; }); //"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
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
#else
    v40 v39
    let _v41 = () 
    #endif
    _v41 
    let v113 : (string -> unit) = v17.l0
    v113 v39
and closure18 () () : unit =
    let v0 : US3 = US3_2
    let v1 : bool = method9(v0)
    if v1 then
        method35()
and method36 () : string =
    
    
    
    
    
    let v0 : string = "Info"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method15(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_green"
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
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_bright_green"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_bright_green"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[92m"
    let v96 : string = method17()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[92m"
    let v100 : string = method17()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[92m"
    let v104 : string = method17()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method38 (v0 : uint8, v1 : float, v2 : uint64) : string =
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
and method37 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : float, v10 : uint64) : string =
    let v11 : string = method38(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "near_workspaces.print_usd"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method20(v14)
and closure19 (v0 : uint8, v1 : uint64, v2 : float) () : unit =
    let v3 : US3 = US3_2
    let v4 : bool = method9(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method10(v21, v22, v23, v24, v25, v26)
        let v40 : string = method36()
        let v41 : string = method37(v21, v22, v23, v24, v25, v26, v39, v40, v0, v2, v1)
        method21(v41)
and method40 (v0 : bool, v1 : float, v2 : float, v3 : uint64, v4 : u128) : string =
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
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : float, v10 : float, v11 : uint64, v12 : u128) : string =
    let v13 : string = method40(v8, v9, v10, v11, v12)
    let v14 : int64 = v0.l0
    let v15 : string = "near_workspaces.print_usd / outcome"
    let v16 : string = $"{v6} {v7} #{v14} %s{v15} / {v13}"
    method20(v16)
and closure21 (v0 : bool, v1 : uint64, v2 : float, v3 : u128, v4 : float) () : unit =
    let v5 : US3 = US3_2
    let v6 : bool = method9(v5)
    if v6 then
        let v7 : unit = ()
        let v8 : (unit -> unit) = closure6()
        let v9 : unit = (fun () -> v8 (); v7) ()
        let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : Mut4, v28 : int64 option) = TraceState.trace_state.Value
        let v41 : string = method10(v23, v24, v25, v26, v27, v28)
        let v42 : string = method36()
        let v43 : string = method39(v23, v24, v25, v26, v27, v28, v41, v42, v0, v2, v4, v1, v3)
        method21(v43)
and closure20 () (v0 : near_workspaces_result_ExecutionOutcome) : unit =
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
    let v20 : (unit -> unit) = closure21(v2, v6, v10, v14, v18)
    let v21 : unit = (fun () -> v20 (); v19) ()
    ()
and method42 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
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
and method41 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
    let v9 : string = method42(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
and closure22 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method41(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method43 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method45 (v0 : int32, v1 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
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
and method44 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v10 : string = method45(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method20(v13)
and closure23 (v0 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>, v1 : int32) () : unit =
    let v2 : US3 = US3_0
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method14()
        let v40 : string = method44(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method21(v40)
and method46 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method48 (v0 : int32, v1 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
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
and method47 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
    let v10 : string = method48(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method20(v13)
and closure24 (v0 : Vec<near_workspaces_result_ExecutionOutcome>, v1 : int32) () : unit =
    let v2 : US3 = US3_0
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method14()
        let v40 : string = method47(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method21(v40)
and method50 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
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
and method49 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v9 : string = method50(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
and closure25 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method49(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method52 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
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
and method51 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v9 : string = method52(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
and closure26 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method51(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method53 (v0 : int32, v1 : uint8, v2 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v3 : string = method16()
    let v4 : Mut3 = {l0 = v3} : Mut3
    let v5 : string = "{ "
    let v6 : string = $"{v5}"
    let v9 : unit = ()
    let v10 : (unit -> unit) = closure8(v4, v6)
    let v11 : unit = (fun () -> v10 (); v9) ()
    let v14 : string = "receipt_outcomes_len"
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
    let v49 : string = "retry"
    let v50 : string = $"{v49}"
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure8(v4, v50)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v58 : string = $"{v23}"
    let v61 : unit = ()
    let v62 : (unit -> unit) = closure8(v4, v58)
    let v63 : unit = (fun () -> v62 (); v61) ()
    let v66 : string = $"{v1}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure8(v4, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = $"{v40}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure8(v4, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = "receipt_failures"
    let v83 : string = $"{v82}"
    let v86 : unit = ()
    let v87 : (unit -> unit) = closure8(v4, v83)
    let v88 : unit = (fun () -> v87 (); v86) ()
    let v91 : string = $"{v23}"
    let v94 : unit = ()
    let v95 : (unit -> unit) = closure8(v4, v91)
    let v96 : unit = (fun () -> v95 (); v94) ()
    let v99 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v99 = v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{:#?}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v108 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let _v99 = v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : string = $"%A{v2}"
    let _v99 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : string = $"%A{v2}"
    let _v99 = v115 
    #endif
#else
    let v118 : string = $"%A{v2}"
    let _v99 = v118 
    #endif
    let v121 : string = _v99 
    let v126 : string = $"{v121}"
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
and method54 (v0 : Result<US4, anyhow_Error>) : Result<US4, anyhow_Error> =
    v0
and method30 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> =
    let v2 : string = "true; let __future_init = Box::pin(async move { //"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : string = "near_workspaces::sandbox().await"
    let v5 : Result<near_workspaces_Worker<near_workspaces_network_Sandbox>, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : string = "$0?"
    let v7 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "$0"
    let v9 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "Box::pin(v9.dev_deploy(&$0))"
    let v11 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_Contract, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr v0 v10 
    let v12 : string = "v11.await"
    let v13 : Result<near_workspaces_Contract, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = "$0?"
    let v15 : near_workspaces_Contract = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure14(v1, v7, v15)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v58 : string = "$0.call(&*$1)"
    let v59 : string = "state_main"
    let v60 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr struct (v15, v59) v58 
    let v61 : string = "near_workspaces::types::Gas::from_tgas(300)"
    let v62 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr () v61 
    let v63 : string = "v60.gas(v62)"
    let v64 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr () v63 
    let v65 : string = "Box::pin(v64.transact())"
    let v66 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v65 
    let v67 : string = "v66.await"
    let v68 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "$0?"
    let v70 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v68 v69 
    let v71 : unit = ()
    let v72 : (unit -> unit) = closure15(v1, v70)
    let v73 : unit = (fun () -> v72 (); v71) ()
    let v113 : string = "v70.logs()"
    let v114 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v113 
    let v115 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v116 : bool = Fable.Core.RustInterop.emitRustExpr v114 v115 
    let v117 : string = "x"
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
    let v140 : string = "true; $0 }).collect::<Vec<_>>()"
    let v141 : bool = Fable.Core.RustInterop.emitRustExpr v135 v140 
    let v142 : string = "_vec_map"
    let v143 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v142 
    let v144 : string = "true; $0.iter().for_each(|x| { $1(x.clone()); }); //"
    let v145 : (std_string_String -> unit) = closure16()
    let v146 : bool = Fable.Core.RustInterop.emitRustExpr struct (v143, v145) v144 
    let v147 : unit = ()
    let v148 : (unit -> unit) = closure18()
    let v149 : unit = (fun () -> v148 (); v147) ()
    let v152 : string = "$0.total_gas_burnt"
    let v153 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v70 v152 
    let v154 : string = "$0.as_gas()"
    let v155 : uint64 = Fable.Core.RustInterop.emitRustExpr v153 v154 
    let v156 : (uint64 -> float) = float
    let v157 : float = v156 v155
    let v158 : float = v157 / 10000000000000000.0
    let v159 : float = v158 * 6.68
    let v160 : unit = ()
    let v161 : (unit -> unit) = closure19(v1, v155, v159)
    let v162 : unit = (fun () -> v161 (); v160) ()
    let v202 : string = "$0"
    let v203 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v70 v202 
    let v204 : string = "v203.outcomes()"
    let v205 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v204 
    let v206 : string = "v205.into_iter()"
    let v207 : _ = Fable.Core.RustInterop.emitRustExpr () v206 
    let v208 : string = "v207.cloned()"
    let v209 : _ = Fable.Core.RustInterop.emitRustExpr () v208 
    let v210 : string = "true; v209.for_each(|x| $0(x))"
    let v211 : (near_workspaces_result_ExecutionOutcome -> unit) = closure20()
    let v212 : bool = Fable.Core.RustInterop.emitRustExpr v211 v210 
    let v213 : string = "$0.into_result()"
    let v214 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v70 v213 
    let v215 : unit = ()
    let v216 : (unit -> unit) = closure22(v214)
    let v217 : unit = (fun () -> v216 (); v215) ()
    let v257 : near_workspaces_result_ExecutionFinalResult = method43(v70)
    let v258 : string = "v257.receipt_failures()"
    let v259 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v258 
    let v260 : string = "$0.len()"
    let v261 : unativeint = Fable.Core.RustInterop.emitRustExpr v259 v260 
    let v262 : (unativeint -> int32) = int32
    let v263 : int32 = v262 v261
    let v264 : unit = ()
    let v265 : (unit -> unit) = closure23(v259, v263)
    let v266 : unit = (fun () -> v265 (); v264) ()
    let v306 : near_workspaces_result_ExecutionFinalResult = method46(v70)
    let v307 : string = "v306.receipt_outcomes()"
    let v308 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v307 
    let v309 : string = "v308.into()"
    let v310 : Vec<near_workspaces_result_ExecutionOutcome> = Fable.Core.RustInterop.emitRustExpr () v309 
    let v311 : string = "$0.len()"
    let v312 : unativeint = Fable.Core.RustInterop.emitRustExpr v310 v311 
    let v313 : (unativeint -> int32) = int32
    let v314 : int32 = v313 v312
    let v315 : unit = ()
    let v316 : (unit -> unit) = closure24(v310, v314)
    let v317 : unit = (fun () -> v316 (); v315) ()
    let v357 : string = "$0.json()"
    let v358 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v70 v357 
    let v359 : unit = ()
    let v360 : (unit -> unit) = closure25(v358)
    let v361 : unit = (fun () -> v360 (); v359) ()
    let v401 : string = "$0.borsh()"
    let v402 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v70 v401 
    let v403 : unit = ()
    let v404 : (unit -> unit) = closure26(v402)
    let v405 : unit = (fun () -> v404 (); v403) ()
    let v445 : string = method53(v314, v1, v259)
    let v446 : bool = v263 > 0
    let v468 : Result<US4, anyhow_Error> =
        if v446 then
            let v447 : US4 = US4_0(v445)
            let v448 : Result<US4, anyhow_Error> = Ok v447 
            v448
        else
            let v449 : bool = v314 > 1
            if v449 then
                let v450 : US4 = US4_1
                let v451 : Result<US4, anyhow_Error> = Ok v450 
                v451
            else
                let v452 : string = "anyhow::anyhow!($0)"
                let v453 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v445 v452 
                let v454 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v455 : string = "Err($0)"
                let v456 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v453 v455 
                let _v454 = v456 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v457 : string = "Err($0)"
                let v458 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v453 v457 
                let _v454 = v458 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v459 : string = "Err($0)"
                let v460 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v453 v459 
                let _v454 = v460 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v461 : Result<US4, anyhow_Error> = v453 |> Error
                let _v454 = v461 
                #endif
#if FABLE_COMPILER_PYTHON
                let v462 : Result<US4, anyhow_Error> = v453 |> Error
                let _v454 = v462 
                #endif
#else
                let v463 : Result<US4, anyhow_Error> = v453 |> Error
                let _v454 = v463 
                #endif
                let v464 : Result<US4, anyhow_Error> = _v454 
                v464
    let v469 : Result<US4, anyhow_Error> = method54(v468)
    let v470 : string = ""
    let v471 : string = "}"
    let v472 : string = v470 + v471 
    let v473 : _ = v469 
    let v474 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v475 : string = $"true; let v473 = $0"
    let v476 : bool = Fable.Core.RustInterop.emitRustExpr v473 v475 
    let _v474 = v476 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v477 : string = $"true; let v473 = $0"
    let v478 : bool = Fable.Core.RustInterop.emitRustExpr v473 v477 
    let _v474 = v478 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v479 : string = $"true; let v473 = $0"
    let v480 : bool = Fable.Core.RustInterop.emitRustExpr v473 v479 
    let _v474 = v480 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v481 : bool = true
    let _v474 = v481 
    #endif
#if FABLE_COMPILER_PYTHON
    let v482 : bool = true
    let _v474 = v482 
    #endif
#else
    let v483 : bool = true
    let _v474 = v483 
    #endif
    let v484 : bool = _v474 
    let v487 : string = $"true; v473 " + v472 + "); " + v470 + " // rust.fix_closure'"
    let v488 : bool = Fable.Core.RustInterop.emitRustExpr () v487 
    let v489 : string = "__future_init"
    let v490 : _ = Fable.Core.RustInterop.emitRustExpr () v489 
    let v491 : string = "v490"
    let v492 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v491 
    v492
and closure27 () (v0 : anyhow_Error) : std_string_String =
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
and method55 () : (anyhow_Error -> std_string_String) =
    closure27()
and closure28 () (v0 : US4) : US7 =
    US7_0(v0)
and closure29 () (v0 : std_string_String) : US7 =
    US7_1(v0)
and method56 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method15(v5)
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
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_yellow"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_yellow"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[93m"
    let v96 : string = method17()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[93m"
    let v100 : string = method17()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[93m"
    let v104 : string = method17()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method58 (v0 : uint8, v1 : std_string_String) : string =
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
and method57 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : std_string_String) : string =
    let v10 : string = method58(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run / Error error"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method20(v13)
and closure30 (v0 : uint8, v1 : std_string_String) () : unit =
    let v2 : US3 = US3_3
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method56()
        let v40 : string = method57(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and method59 () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure6()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure9(v16)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "\n"
    let v40 : (string -> unit) = closure10()
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
    let v52 : string =
        if v45 then
            v39
        else
            let v46 : bool = v39 = ""
            if v46 then
                let v47 : string = v19.l0
                v47
            else
                let v48 : string = v19.l0
                let v49 : string = v48 + v39 
                let v50 : string = v49 + v39 
                v50
    let v53 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v54 
    let _v53 = v55 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v56 
    let _v53 = v57 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v58 : string = "&*$0"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v58 
    let _v53 = v59 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _v53 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v63 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _v53 = v63 
    #endif
#else
    let v66 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _v53 = v66 
    #endif
    let v69 : Ref<Str> = _v53 
    let v74 : string = $"$0.chars()"
    let v75 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v69 v74 
    let v76 : string = "$0"
    let v77 : _ = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let v78 : string = "$0.collect::<Vec<_>>()"
    let v79 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let v80 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v81 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v79 v80 
    let v82 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v83 : bool = Fable.Core.RustInterop.emitRustExpr v81 v82 
    let v84 : string = "x"
    let v85 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v84 
    let v86 : string = "String::from_iter($0)"
    let v87 : std_string_String = Fable.Core.RustInterop.emitRustExpr v85 v86 
    let v88 : string = "true; $0 }).collect::<Vec<_>>()"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr v87 v88 
    let v90 : string = "_vec_map"
    let v91 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = "$0.len()"
    let v93 : unativeint = Fable.Core.RustInterop.emitRustExpr v91 v92 
    let v94 : (unativeint -> int32) = int32
    let v95 : int32 = v94 v93
    let v96 : string = ""
    let v97 : bool = v39 <> v96 
    let v101 : bool =
        if v97 then
            let v100 : bool = v95 <= 1
            v100
        else
            false
    if v101 then
        v19.l0 <- v52
        ()
    else
        v19.l0 <- v96
        let v102 : string = "true; $0.into_iter().for_each(|x| { //"
        let v103 : bool = Fable.Core.RustInterop.emitRustExpr v91 v102 
        let v104 : string = "x"
        let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v104 
        let v106 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v107 : bool = Fable.Core.RustInterop.emitRustExpr v105 v106 
        let v108 : string = $"true"
        let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108 
        let v110 : string = "true; }); //"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr () v110 
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
#else
    v40 v39
    let _v41 = () 
    #endif
    _v41 
    let v112 : (string -> unit) = v17.l0
    v112 v39
and closure31 () () : unit =
    let v0 : US3 = US3_3
    let v1 : bool = method9(v0)
    if v1 then
        method59()
and method60 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method15(v5)
    let v7 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = "inline_colorization::color_bright_red"
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
#else
    let v23 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v10 = v23 
    #endif
    let v26 : Ref<Str> = _v10 
    let v31 : string = "inline_colorization::color_reset"
    let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31 
    let v33 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v34 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v9, v26, v32) v33 
    let v35 : string = "fable_library_rust::String_::fromString($0)"
    let v36 : string = Fable.Core.RustInterop.emitRustExpr v34 v35 
    let _v7 = v36 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v37 : string = "inline_colorization::color_bright_red"
    let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v40 : string = "&*$0"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v40 
    let _v39 = v41 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v42 : string = "&*$0"
    let v43 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v42 
    let _v39 = v43 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v44 
    let _v39 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v46 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v46 
    #endif
#if FABLE_COMPILER_PYTHON
    let v49 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v49 
    #endif
#else
    let v52 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v39 = v52 
    #endif
    let v55 : Ref<Str> = _v39 
    let v60 : string = "inline_colorization::color_reset"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60 
    let v62 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v63 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v38, v55, v61) v62 
    let v64 : string = "fable_library_rust::String_::fromString($0)"
    let v65 : string = Fable.Core.RustInterop.emitRustExpr v63 v64 
    let _v7 = v65 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v66 : string = "inline_colorization::color_bright_red"
    let v67 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v69 : string = "&*$0"
    let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v69 
    let _v68 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "&*$0"
    let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v71 
    let _v68 = v72 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v73 : string = "&*$0"
    let v74 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v6 v73 
    let _v68 = v74 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v75 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v75 
    #endif
#if FABLE_COMPILER_PYTHON
    let v78 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v78 
    #endif
#else
    let v81 : Ref<Str> = v6 |> unbox<Ref<Str>>
    let _v68 = v81 
    #endif
    let v84 : Ref<Str> = _v68 
    let v89 : string = "inline_colorization::color_reset"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = $"format!(\"{{}}{{}}{{}}\", $0, $1, $2)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v67, v84, v90) v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    let _v7 = v94 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : string = "\u001b[91m"
    let v96 : string = method17()
    let v97 : string = v95 + v6 
    let v98 : string = v97 + v96 
    let _v7 = v98 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : string = "\u001b[91m"
    let v100 : string = method17()
    let v101 : string = v99 + v6 
    let v102 : string = v101 + v100 
    let _v7 = v102 
    #endif
#else
    let v103 : string = "\u001b[91m"
    let v104 : string = method17()
    let v105 : string = v103 + v6 
    let v106 : string = v105 + v104 
    let _v7 = v106 
    #endif
    let v107 : string = _v7 
    v107
and method62 (v0 : uint8, v1 : string) : string =
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
and method61 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : string) : string =
    let v10 : string = method62(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run / Ok (Some error)"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method20(v13)
and closure32 (v0 : uint8, v1 : string) () : unit =
    let v2 : US3 = US3_4
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method60()
        let v40 : string = method61(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and method63 (v0 : uint8, v1 : string) : struct (uint8 * US4) =
    let v2 : US4 = US4_0(v1)
    struct (v0, v2)
and method64 (v0 : US6) : US6 =
    v0
and method28 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<US6>>>> =
    let v2 : string = "true; let __future_init = Box::pin(async move { //"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : bool = v1 >= 30uy
    let v218 : US6 =
        if v4 then
            let v5 : string = "true; let __future_init = Box::pin(async move { //"
            let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
            let struct (v7 : uint8, v8 : US4) = method29(v1)
            let v9 : string = ""
            let v10 : string = "}"
            let v11 : string = v9 + v10 
            let v12 : _ = struct (v7, v8) 
            let v13 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v14 : string = $"true; let v12 = $0"
            let v15 : bool = Fable.Core.RustInterop.emitRustExpr v12 v14 
            let _v13 = v15 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v16 : string = $"true; let v12 = $0"
            let v17 : bool = Fable.Core.RustInterop.emitRustExpr v12 v16 
            let _v13 = v17 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v18 : string = $"true; let v12 = $0"
            let v19 : bool = Fable.Core.RustInterop.emitRustExpr v12 v18 
            let _v13 = v19 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v20 : bool = true
            let _v13 = v20 
            #endif
#if FABLE_COMPILER_PYTHON
            let v21 : bool = true
            let _v13 = v21 
            #endif
#else
            let v22 : bool = true
            let _v13 = v22 
            #endif
            let v23 : bool = _v13 
            let v26 : string = $"true; v12 " + v11 + "); " + v9 + " // rust.fix_closure'"
            let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
            let v28 : string = "__future_init"
            let v29 : _ = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "v29"
            let v31 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US4)>>>> = Fable.Core.RustInterop.emitRustExpr () v30 
            let v32 : string = "v31.await"
            let struct (v33 : uint8, v34 : US4) = Fable.Core.RustInterop.emitRustExpr () v32 
            US6_1(v33, v34)
        else
            let v36 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method30(v0, v1)
            let v37 : string = "v36.await"
            let v38 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v37 
            let v39 : (anyhow_Error -> std_string_String) = method55()
            let v40 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v41 : string = "$0.map_err(|x| $1(x))"
            let v42 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v38, v39) v41 
            let _v40 = v42 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v43 : string = "$0.map_err(|x| $1(x))"
            let v44 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v38, v39) v43 
            let _v40 = v44 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v45 : string = "$0.map_err(|x| $1(x))"
            let v46 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v38, v39) v45 
            let _v40 = v46 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v47 : Result<US4, std_string_String> = match v38 with Ok x -> Ok x | Error x -> Error (v39 x)
            let _v40 = v47 
            #endif
#if FABLE_COMPILER_PYTHON
            let v48 : Result<US4, std_string_String> = match v38 with Ok x -> Ok x | Error x -> Error (v39 x)
            let _v40 = v48 
            #endif
#else
            let v49 : Result<US4, std_string_String> = match v38 with Ok x -> Ok x | Error x -> Error (v39 x)
            let _v40 = v49 
            #endif
            let v50 : Result<US4, std_string_String> = _v40 
            let v53 : (US4 -> US7) = closure28()
            let v54 : (std_string_String -> US7) = closure29()
            let v55 : US7 = match v50 with Ok x -> v53 x | Error x -> v54 x
            match v55 with
            | US7_1(v164) -> (* Error *)
                let v165 : unit = ()
                let v166 : (unit -> unit) = closure30(v1, v164)
                let v167 : unit = (fun () -> v166 (); v165) ()
                let v207 : unit = ()
                let v208 : (unit -> unit) = closure31()
                let v209 : unit = (fun () -> v208 (); v207) ()
                let v212 : uint8 = v1 + 1uy
                let v213 : std_pin_Pin<Box<Dyn<std_future_Future<US6>>>> = method28(v0, v212)
                let v214 : string = "v213.await"
                let v215 : US6 = Fable.Core.RustInterop.emitRustExpr () v214 
                v215
            | US7_0(v56) -> (* Ok *)
                match v56 with
                | US4_1 -> (* None *)
                    let v57 : string = "true; let __future_init = Box::pin(async move { //"
                    let v58 : bool = Fable.Core.RustInterop.emitRustExpr () v57 
                    let struct (v59 : uint8, v60 : US4) = method29(v1)
                    let v61 : string = ""
                    let v62 : string = "}"
                    let v63 : string = v61 + v62 
                    let v64 : _ = struct (v59, v60) 
                    let v65 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v66 : string = $"true; let v64 = $0"
                    let v67 : bool = Fable.Core.RustInterop.emitRustExpr v64 v66 
                    let _v65 = v67 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v68 : string = $"true; let v64 = $0"
                    let v69 : bool = Fable.Core.RustInterop.emitRustExpr v64 v68 
                    let _v65 = v69 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v70 : string = $"true; let v64 = $0"
                    let v71 : bool = Fable.Core.RustInterop.emitRustExpr v64 v70 
                    let _v65 = v71 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v72 : bool = true
                    let _v65 = v72 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v73 : bool = true
                    let _v65 = v73 
                    #endif
#else
                    let v74 : bool = true
                    let _v65 = v74 
                    #endif
                    let v75 : bool = _v65 
                    let v78 : string = $"true; v64 " + v63 + "); " + v61 + " // rust.fix_closure'"
                    let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78 
                    let v80 : string = "__future_init"
                    let v81 : _ = Fable.Core.RustInterop.emitRustExpr () v80 
                    let v82 : string = "v81"
                    let v83 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US4)>>>> = Fable.Core.RustInterop.emitRustExpr () v82 
                    let v84 : string = "v83.await"
                    let struct (v85 : uint8, v86 : US4) = Fable.Core.RustInterop.emitRustExpr () v84 
                    US6_0(v85, v86)
                | US4_0(v88) -> (* Some *)
                    let v89 : unit = ()
                    let v90 : (unit -> unit) = closure32(v1, v88)
                    let v91 : unit = (fun () -> v90 (); v89) ()
                    let v131 : string = "true; let __future_init = Box::pin(async move { //"
                    let v132 : bool = Fable.Core.RustInterop.emitRustExpr () v131 
                    let struct (v133 : uint8, v134 : US4) = method63(v1, v88)
                    let v135 : string = ""
                    let v136 : string = "}"
                    let v137 : string = v135 + v136 
                    let v138 : _ = struct (v133, v134) 
                    let v139 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v140 : string = $"true; let v138 = $0"
                    let v141 : bool = Fable.Core.RustInterop.emitRustExpr v138 v140 
                    let _v139 = v141 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v142 : string = $"true; let v138 = $0"
                    let v143 : bool = Fable.Core.RustInterop.emitRustExpr v138 v142 
                    let _v139 = v143 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v144 : string = $"true; let v138 = $0"
                    let v145 : bool = Fable.Core.RustInterop.emitRustExpr v138 v144 
                    let _v139 = v145 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v146 : bool = true
                    let _v139 = v146 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v147 : bool = true
                    let _v139 = v147 
                    #endif
#else
                    let v148 : bool = true
                    let _v139 = v148 
                    #endif
                    let v149 : bool = _v139 
                    let v152 : string = $"true; v138 " + v137 + "); " + v135 + " // rust.fix_closure'"
                    let v153 : bool = Fable.Core.RustInterop.emitRustExpr () v152 
                    let v154 : string = "__future_init"
                    let v155 : _ = Fable.Core.RustInterop.emitRustExpr () v154 
                    let v156 : string = "v155"
                    let v157 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US4)>>>> = Fable.Core.RustInterop.emitRustExpr () v156 
                    let v158 : string = "v157.await"
                    let struct (v159 : uint8, v160 : US4) = Fable.Core.RustInterop.emitRustExpr () v158 
                    US6_1(v159, v160)
    let v219 : US6 = method64(v218)
    let v220 : string = ""
    let v221 : string = "}"
    let v222 : string = v220 + v221 
    let v223 : _ = v219 
    let v224 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v225 : string = $"true; let v223 = $0"
    let v226 : bool = Fable.Core.RustInterop.emitRustExpr v223 v225 
    let _v224 = v226 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v227 : string = $"true; let v223 = $0"
    let v228 : bool = Fable.Core.RustInterop.emitRustExpr v223 v227 
    let _v224 = v228 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v229 : string = $"true; let v223 = $0"
    let v230 : bool = Fable.Core.RustInterop.emitRustExpr v223 v229 
    let _v224 = v230 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v231 : bool = true
    let _v224 = v231 
    #endif
#if FABLE_COMPILER_PYTHON
    let v232 : bool = true
    let _v224 = v232 
    #endif
#else
    let v233 : bool = true
    let _v224 = v233 
    #endif
    let v234 : bool = _v224 
    let v237 : string = $"true; v223 " + v222 + "); " + v220 + " // rust.fix_closure'"
    let v238 : bool = Fable.Core.RustInterop.emitRustExpr () v237 
    let v239 : string = "__future_init"
    let v240 : _ = Fable.Core.RustInterop.emitRustExpr () v239 
    let v241 : string = "v240"
    let v242 : std_pin_Pin<Box<Dyn<std_future_Future<US6>>>> = Fable.Core.RustInterop.emitRustExpr () v241 
    v242
and method66 (v0 : US6) : string =
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
and method65 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : US6) : string =
    let v9 : string = method66(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
and closure33 (v0 : US6) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method65(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method67 (v0 : US6, v1 : US4) : string =
    let v2 : string = method16()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure8(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "retries"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure8(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure8(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"%A{v0}"
    let v34 : string = $"{v31}"
    let v37 : unit = ()
    let v38 : (unit -> unit) = closure8(v3, v34)
    let v39 : unit = (fun () -> v38 (); v37) ()
    let v42 : string = "; "
    let v43 : string = $"{v42}"
    let v46 : unit = ()
    let v47 : (unit -> unit) = closure8(v3, v43)
    let v48 : unit = (fun () -> v47 (); v46) ()
    let v51 : string = "error"
    let v52 : string = $"{v51}"
    let v55 : unit = ()
    let v56 : (unit -> unit) = closure8(v3, v52)
    let v57 : unit = (fun () -> v56 (); v55) ()
    let v60 : string = $"{v22}"
    let v63 : unit = ()
    let v64 : (unit -> unit) = closure8(v3, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = $"%A{v1}"
    let v71 : string = $"{v68}"
    let v74 : unit = ()
    let v75 : (unit -> unit) = closure8(v3, v71)
    let v76 : unit = (fun () -> v75 (); v74) ()
    let v79 : string = " }"
    let v80 : string = $"{v79}"
    let v83 : unit = ()
    let v84 : (unit -> unit) = closure8(v3, v80)
    let v85 : unit = (fun () -> v84 (); v83) ()
    let v88 : string = v3.l0
    v88
and method68 (v0 : Result<uint8, anyhow_Error>) : Result<uint8, anyhow_Error> =
    v0
and method24 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(async move { //"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = method25()
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
    let v51 : (unit -> unit) = closure13(v49)
    let v52 : unit = (fun () -> v51 (); v50) ()
    let v92 : string = "std::fs::read(&*$0)"
    let v93 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v49 v92 
    let v94 : string = "$0?"
    let v95 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v93 v94 
    let v96 : uint8 = 1uy
    let v97 : std_pin_Pin<Box<Dyn<std_future_Future<US6>>>> = method28(v95, v96)
    let v98 : string = "v97.await"
    let v99 : US6 = Fable.Core.RustInterop.emitRustExpr () v98 
    let v100 : unit = ()
    let v101 : (unit -> unit) = closure33(v99)
    let v102 : unit = (fun () -> v101 (); v100) ()
    let v164 : Result<uint8, anyhow_Error> =
        match v99 with
        | US6_1(v145, v146) -> (* Error *)
            let v147 : string = method67(v99, v146)
            let v148 : string = "anyhow::anyhow!($0)"
            let v149 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v147 v148 
            let v150 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v151 : string = "Err($0)"
            let v152 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v149 v151 
            let _v150 = v152 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v153 : string = "Err($0)"
            let v154 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v149 v153 
            let _v150 = v154 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v155 : string = "Err($0)"
            let v156 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v149 v155 
            let _v150 = v156 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v157 : Result<uint8, anyhow_Error> = v149 |> Error
            let _v150 = v157 
            #endif
#if FABLE_COMPILER_PYTHON
            let v158 : Result<uint8, anyhow_Error> = v149 |> Error
            let _v150 = v158 
            #endif
#else
            let v159 : Result<uint8, anyhow_Error> = v149 |> Error
            let _v150 = v159 
            #endif
            let v160 : Result<uint8, anyhow_Error> = _v150 
            v160
        | US6_0(v142, v143) -> (* Ok *)
            let v144 : Result<uint8, anyhow_Error> = Ok v142 
            v144
    let v165 : Result<uint8, anyhow_Error> = method68(v164)
    let v166 : string = ""
    let v167 : string = "}"
    let v168 : string = v166 + v167 
    let v169 : _ = v165 
    let v170 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v171 : string = $"true; let v169 = $0"
    let v172 : bool = Fable.Core.RustInterop.emitRustExpr v169 v171 
    let _v170 = v172 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v173 : string = $"true; let v169 = $0"
    let v174 : bool = Fable.Core.RustInterop.emitRustExpr v169 v173 
    let _v170 = v174 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v175 : string = $"true; let v169 = $0"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr v169 v175 
    let _v170 = v176 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v177 : bool = true
    let _v170 = v177 
    #endif
#if FABLE_COMPILER_PYTHON
    let v178 : bool = true
    let _v170 = v178 
    #endif
#else
    let v179 : bool = true
    let _v170 = v179 
    #endif
    let v180 : bool = _v170 
    let v183 : string = $"true; v169 " + v168 + "); " + v166 + " // rust.fix_closure'"
    let v184 : bool = Fable.Core.RustInterop.emitRustExpr () v183 
    let v185 : string = "__future_init"
    let v186 : _ = Fable.Core.RustInterop.emitRustExpr () v185 
    let v187 : string = "v186"
    let v188 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v187 
    v188
and closure34 () (v0 : uint8) : US8 =
    US8_0(v0)
and closure35 () (v0 : std_string_String) : US8 =
    US8_1(v0)
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
    let v183 : string = method22()
    let v184 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v185 : string = "&*$0"
    let v186 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v183 v185 
    let _v184 = v186 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v187 : string = "&*$0"
    let v188 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v183 v187 
    let _v184 = v188 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v189 : string = "&*$0"
    let v190 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v183 v189 
    let _v184 = v190 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v191 : Ref<Str> = v183 |> unbox<Ref<Str>>
    let _v184 = v191 
    #endif
#if FABLE_COMPILER_PYTHON
    let v194 : Ref<Str> = v183 |> unbox<Ref<Str>>
    let _v184 = v194 
    #endif
#else
    let v197 : Ref<Str> = v183 |> unbox<Ref<Str>>
    let _v184 = v197 
    #endif
    let v200 : Ref<Str> = _v184 
    let v205 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v206 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v3, v200) v205 
    let v207 : (std_string_String -> string) = method23()
    let v208 : string option = v206 |> Option.map v207 
    let v272 : (string -> US4) = method7()
    let v273 : US4 option = v208 |> Option.map v272 
    let v284 : US4 = US4_1
    let v285 : US4 = v273 |> Option.defaultValue v284 
    let v289 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = method24(v3)
    let v290 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v291 : _ = Fable.Core.RustInterop.emitRustExpr () v290 
    let v292 : string = "v291.handle().block_on($0)"
    let v293 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v289 v292 
    let v294 : (anyhow_Error -> std_string_String) = method55()
    let v295 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v296 : string = "$0.map_err(|x| $1(x))"
    let v297 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v293, v294) v296 
    let _v295 = v297 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v298 : string = "$0.map_err(|x| $1(x))"
    let v299 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v293, v294) v298 
    let _v295 = v299 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v300 : string = "$0.map_err(|x| $1(x))"
    let v301 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v293, v294) v300 
    let _v295 = v301 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v302 : Result<uint8, std_string_String> = match v293 with Ok x -> Ok x | Error x -> Error (v294 x)
    let _v295 = v302 
    #endif
#if FABLE_COMPILER_PYTHON
    let v303 : Result<uint8, std_string_String> = match v293 with Ok x -> Ok x | Error x -> Error (v294 x)
    let _v295 = v303 
    #endif
#else
    let v304 : Result<uint8, std_string_String> = match v293 with Ok x -> Ok x | Error x -> Error (v294 x)
    let _v295 = v304 
    #endif
    let v305 : Result<uint8, std_string_String> = _v295 
    let v308 : (uint8 -> US8) = closure34()
    let v309 : (std_string_String -> US8) = closure35()
    let v310 : US8 = match v305 with Ok x -> v308 x | Error x -> v309 x
    match v310 with
    | US8_1(v331) -> (* Error *)
        match v285 with
        | US4_0(v332) -> (* Some *)
            let v333 : bool = "" = v332
            if v333 then
                ()
            else
                let v334 : string = "fable_library_rust::String_::fromString($0)"
                let v335 : string = Fable.Core.RustInterop.emitRustExpr v331 v334 
                let v336 : bool = v335.Contains v332 
                if v336 then
                    ()
                else
                    let v339 : string = $"spiral_wasm.main / exception: '{v332}' / error: {v331}"
                    let v340 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v341 : string = "Err($0)"
                    let v342 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v339 v341 
                    let _v340 = v342 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v343 : string = "Err($0)"
                    let v344 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v339 v343 
                    let _v340 = v344 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v345 : string = "Err($0)"
                    let v346 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v339 v345 
                    let _v340 = v346 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v347 : Result<unit, string> = v339 |> Error
                    let _v340 = v347 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v348 : Result<unit, string> = v339 |> Error
                    let _v340 = v348 
                    #endif
#else
                    let v349 : Result<unit, string> = v339 |> Error
                    let _v340 = v349 
                    #endif
                    let v350 : Result<unit, string> = _v340 
                    let v353 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v354 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v350 v354 
                    let _v353 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v355 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v350 v355 
                    let _v353 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v356 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v350 v356 
                    let _v353 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    match v350 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v353 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    match v350 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v353 = () 
                    #endif
#else
                    match v350 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v353 = () 
                    #endif
                    _v353 
                    ()
        | _ ->
            let v357 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v358 : string = "$0.unwrap()"
            let v359 : uint8 = Fable.Core.RustInterop.emitRustExpr v305 v358 
            let _v357 = v359 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v360 : string = "$0.unwrap()"
            let v361 : uint8 = Fable.Core.RustInterop.emitRustExpr v305 v360 
            let _v357 = v361 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v362 : string = "$0.unwrap()"
            let v363 : uint8 = Fable.Core.RustInterop.emitRustExpr v305 v362 
            let _v357 = v363 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v364 : uint8 = match v305 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v357 = v364 
            #endif
#if FABLE_COMPILER_PYTHON
            let v365 : uint8 = match v305 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v357 = v365 
            #endif
#else
            let v366 : uint8 = match v305 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v357 = v366 
            #endif
            let v367 : uint8 = _v357 
            ()
    | US8_0(v311) -> (* Ok *)
        match v285 with
        | US4_0(v312) -> (* Some *)
            let v313 : string = $"spiral_wasm.main / retries: {v311} / exception: '{v312}'"
            let v314 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v315 : string = "Err($0)"
            let v316 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v313 v315 
            let _v314 = v316 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v317 : string = "Err($0)"
            let v318 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v313 v317 
            let _v314 = v318 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v319 : string = "Err($0)"
            let v320 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v313 v319 
            let _v314 = v320 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v321 : Result<unit, string> = v313 |> Error
            let _v314 = v321 
            #endif
#if FABLE_COMPILER_PYTHON
            let v322 : Result<unit, string> = v313 |> Error
            let _v314 = v322 
            #endif
#else
            let v323 : Result<unit, string> = v313 |> Error
            let _v314 = v323 
            #endif
            let v324 : Result<unit, string> = _v314 
            let v327 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v328 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v324 v328 
            let _v327 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v329 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v324 v329 
            let _v327 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v330 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v324 v330 
            let _v327 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v327 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v327 = () 
            #endif
#else
            match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v327 = () 
            #endif
            _v327 
            ()
        | _ ->
            ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
