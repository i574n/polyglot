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
    | US4_0 of f0_0 : int64
    | US4_1
and [<Struct>] US5 =
    | US5_0
    | US5_1
    | US5_2
and [<Struct>] US6 =
    | US6_0 of f0_0 : US5
    | US6_1 of f1_0 : US5
    | US6_2 of f2_0 : US5
    | US6_3 of f3_0 : US5
    | US6_4 of f4_0 : US5
and [<Struct>] US7 =
    | US7_0 of f0_0 : string
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint8 * f0_1 : US7
    | US8_1 of f1_0 : uint8 * f1_1 : US7
and [<Struct>] US9 =
    | US9_0 of f0_0 : US7
    | US9_1 of f1_0 : std_string_String
and [<Struct>] US10 =
    | US10_0 of f0_0 : uint8
    | US10_1 of f1_0 : std_string_String
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
    let v13 : unativeint = 0 |> unativeint 
    let v16 : bool = v10 = v13 
    let v24 : clap_builder_ValueRange =
        if v16 then
            let v19 : string = "clap::builder::ValueRange::new($0..)"
            let v20 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr v7 v19 
            v20
        else
            let v21 : string = "="
            let v22 : string = "clap::builder::ValueRange::new($0.." + v21 + "$1)"
            let v23 : clap_builder_ValueRange = Fable.Core.RustInterop.emitRustExpr struct (v7, v10) v22 
            v23
    let v25 : string = "exception"
    let v26 : string = "r#\"" + v25 + "\"#"
    let v27 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "clap::Arg::new($0)"
    let v29 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v27 v28 
    let v30 : string = "$0.short($1)"
    let v31 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v29, 'e') v30 
    let v32 : string = "r#\"" + v25 + "\"#"
    let v33 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "$0.long($1)"
    let v35 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v31, v33) v34 
    let v36 : string = "$0.num_args($1)"
    let v37 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v35, v24) v36 
    let v38 : string = "$0.require_equals($1)"
    let v39 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v37, true) v38 
    let v40 : string = ""
    let v41 : string = "r#\"" + v40 + "\"#"
    let v42 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "$0.default_missing_value($1)"
    let v44 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v39, v42) v43 
    let v45 : string = "clap::Command::arg($0, $1)"
    let v46 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v6, v44) v45 
    let v47 : string = "trace_level"
    let v48 : string = "r#\"" + v47 + "\"#"
    let v49 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "clap::Arg::new($0)"
    let v51 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v49 v50 
    let v52 : string = "$0.short($1)"
    let v53 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v51, 't') v52 
    let v54 : string = "r#\"" + v47 + "\"#"
    let v55 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v54 
    let v56 : string = "$0.long($1)"
    let v57 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v53, v55) v56 
    
    
    
    
    
    let v58 : string list = []
    let v59 : string = "Critical"
    let v60 : string list = v59 :: v58 
    let v63 : string = "Warning"
    let v64 : string list = v63 :: v60 
    let v67 : string = "Info"
    let v68 : string list = v67 :: v64 
    let v71 : string = "Debug"
    let v72 : string list = v71 :: v68 
    let v75 : string = "Verbose"
    let v76 : string list = v75 :: v72 
    let v79 : (string list -> (string [])) = List.toArray
    let v80 : (string []) = v79 v76
    let v83 : string = "$0.to_vec()"
    let v84 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v80 v83 
    let v85 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v86 : bool = Fable.Core.RustInterop.emitRustExpr v84 v85 
    let v87 : string = "x"
    let v88 : string = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : string = "&*$0"
    let v91 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v88 v90 
    let _run_target_args'_v89 = v91 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v92 : string = "&*$0"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v88 v92 
    let _run_target_args'_v89 = v93 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v94 : string = "&*$0"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v88 v94 
    let _run_target_args'_v89 = v95 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v96 : Ref<Str> = v88 |> unbox<Ref<Str>>
    let _run_target_args'_v89 = v96 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : Ref<Str> = v88 |> unbox<Ref<Str>>
    let _run_target_args'_v89 = v99 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v102 : Ref<Str> = v88 |> unbox<Ref<Str>>
    let _run_target_args'_v89 = v102 
    #endif
#else
    let v105 : Ref<Str> = v88 |> unbox<Ref<Str>>
    let _run_target_args'_v89 = v105 
    #endif
    let v108 : Ref<Str> = _run_target_args'_v89 
    let v113 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v114 : string = "String::from($0)"
    let v115 : std_string_String = Fable.Core.RustInterop.emitRustExpr v108 v114 
    let _run_target_args'_v113 = v115 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v116 : string = "String::from($0)"
    let v117 : std_string_String = Fable.Core.RustInterop.emitRustExpr v108 v116 
    let _run_target_args'_v113 = v117 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v118 : string = "String::from($0)"
    let v119 : std_string_String = Fable.Core.RustInterop.emitRustExpr v108 v118 
    let _run_target_args'_v113 = v119 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v120 : std_string_String = v108 |> unbox<std_string_String>
    let _run_target_args'_v113 = v120 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : std_string_String = v108 |> unbox<std_string_String>
    let _run_target_args'_v113 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v126 : std_string_String = v108 |> unbox<std_string_String>
    let _run_target_args'_v113 = v126 
    #endif
#else
    let v129 : std_string_String = v108 |> unbox<std_string_String>
    let _run_target_args'_v113 = v129 
    #endif
    let v132 : std_string_String = _run_target_args'_v113 
    let v137 : string = "Box::new($0)"
    let v138 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v132 v137 
    let v139 : string = "Box::leak($0)"
    let v140 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v138 v139 
    let v141 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v142 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v140 v141 
    let v143 : string = "true; $0 }).collect::<Vec<_>>()"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr v142 v143 
    let v145 : string = "_vec_map"
    let v146 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v148 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v146 v147 
    let v149 : string = "$0.value_parser($1)"
    let v150 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v57, v148) v149 
    let v151 : string = "clap::Command::arg($0, $1)"
    let v152 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v46, v150) v151 
    let v153 : string = "wasm"
    let v154 : string = "r#\"" + v153 + "\"#"
    let v155 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v154 
    let v156 : string = "clap::Arg::new($0)"
    let v157 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v155 v156 
    let v158 : string = "$0.short($1)"
    let v159 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v157, 'w') v158 
    let v160 : string = "r#\"" + v153 + "\"#"
    let v161 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = "$0.long($1)"
    let v163 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v159, v161) v162 
    let v164 : string = "$0.required($1)"
    let v165 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v163, true) v164 
    let v166 : string = "clap::Command::arg($0, $1)"
    let v167 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v152, v165) v166 
    v167
and method1 () : string =
    let v0 : string = "trace_level"
    v0
and closure1 () (v0 : std_string_String) : US0 =
    US0_0(v0)
and method2 () : (std_string_String -> US0) =
    closure1()
and method6 (v0 : string) : string =
    v0
and method7 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US7 =
    US7_0(v0)
and method8 () : (string -> US7) =
    closure3()
and method5 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method6(v0)
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
    let v15 : string = method7()
    let v16 : string = "$0.unwrap_or($1)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr struct (v14, v15) v16 
    let _run_target_args'_v1 = v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : US5 = US5_1
    let v19 : US6 = US6_2(v18)
    let v20 : string = $"env.get_environment_variable / target: {v19} / var: {v0}"
    let v21 : string = failwith<string> v20
    let _run_target_args'_v1 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : US5 = US5_2
    let v23 : US6 = US6_2(v22)
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
    let v43 : (string -> US7) = method8()
    let v44 : US7 option = v40 |> Option.map v43 
    let v55 : US7 = US7_1
    let v56 : US7 = v44 |> Option.defaultValue v55 
    let v63 : string =
        match v56 with
        | US7_1 -> (* None *)
            let v61 : string = ""
            v61
        | US7_0(v60) -> (* Some *)
            v60
    let _run_target_args'_v1 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v64 : US5 = US5_1
    let v65 : US6 = US6_0(v64)
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
    let v75 : (string -> US7) = method8()
    let v76 : US7 option = v72 |> Option.map v75 
    let v87 : US7 = US7_1
    let v88 : US7 = v76 |> Option.defaultValue v87 
    let v95 : string =
        match v88 with
        | US7_1 -> (* None *)
            let v93 : string = ""
            v93
        | US7_0(v92) -> (* Some *)
            v92
    let _run_target_args'_v1 = v95 
    #endif
    let v96 : string = _run_target_args'_v1 
    v96
and method4 () : struct (US2 * US4) =
    let v0 : string = "TRACE_LEVEL"
    let v1 : string = method5(v0)
    
    
    
    
    
    let v2 : bool = "Verbose" = v1
    let v6 : US2 =
        if v2 then
            let v3 : US3 = US3_0
            US2_0(v3)
        else
            US2_1
    let v47 : US2 =
        match v6 with
        | US2_1 -> (* None *)
            let v9 : bool = "Debug" = v1
            let v13 : US2 =
                if v9 then
                    let v10 : US3 = US3_1
                    US2_0(v10)
                else
                    US2_1
            match v13 with
            | US2_1 -> (* None *)
                let v16 : bool = "Info" = v1
                let v20 : US2 =
                    if v16 then
                        let v17 : US3 = US3_2
                        US2_0(v17)
                    else
                        US2_1
                match v20 with
                | US2_1 -> (* None *)
                    let v23 : bool = "Warning" = v1
                    let v27 : US2 =
                        if v23 then
                            let v24 : US3 = US3_3
                            US2_0(v24)
                        else
                            US2_1
                    match v27 with
                    | US2_1 -> (* None *)
                        let v30 : bool = "Critical" = v1
                        let v34 : US2 =
                            if v30 then
                                let v31 : US3 = US3_4
                                US2_0(v31)
                            else
                                US2_1
                        match v34 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v35) -> (* Some *)
                            US2_0(v35)
                    | US2_0(v28) -> (* Some *)
                        US2_0(v28)
                | US2_0(v21) -> (* Some *)
                    US2_0(v21)
            | US2_0(v14) -> (* Some *)
                US2_0(v14)
        | US2_0(v7) -> (* Some *)
            US2_0(v7)
    let v48 : string = "AUTOMATION"
    let v49 : string = method5(v48)
    let v50 : string = "True"
    let v51 : bool = v49 <> v50 
    let v107 : US4 =
        if v51 then
            US4_1
        else
            let v55 : unit = ()
            
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
            let v70 : unit = ()
            
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
            US4_0(v103)
    struct (v47, v107)
and closure4 () (v0 : string) : unit =
    ()
and method3 (v0 : US3) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US2, v3 : US4) = method4()
    let _run_target_args'_v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US2 = US2_1
    let v5 : US4 = US4_1
    let _run_target_args'_v1 = struct (v4, v5) 
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
    let v38 : unit = ()
    
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
    let v66 : unit = ()
    
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
    let v121 : US4 =
        if v110 then
            US4_1
        else
            let v114 : string = $"near_sdk::env::block_timestamp()"
            let v115 : uint64 = Fable.Core.RustInterop.emitRustExpr () v114 
            let v116 : (uint64 -> int64) = int64
            let v117 : int64 = v116 v115
            US4_0(v117)
    let v122 : US2 = US2_1
    let _run_target_args'_v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US2, v124 : US4) = method4()
    let _run_target_args'_v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US2, v126 : US4) = method4()
    let _run_target_args'_v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US2, v128 : US4) = method4()
    let _run_target_args'_v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US2, v130 : US4) = method4()
    let _run_target_args'_v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US2, v132 : US4) = _run_target_args'_v1 
    let v137 : Mut0 = {l0 = 1L} : Mut0
    let v138 : (string -> unit) = closure4()
    let v139 : Mut1 = {l0 = v138} : Mut1
    let v140 : Mut2 = {l0 = true} : Mut2
    let v141 : string = ""
    let v142 : Mut3 = {l0 = v141} : Mut3
    let v145 : US3 =
        match v131 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v143) -> (* Some *)
            v143
    let v146 : Mut4 = {l0 = v145} : Mut4
    let v153 : int64 option =
        match v132 with
        | US4_1 -> (* None *)
            let v151 : int64 option = None
            v151
        | US4_0(v147) -> (* Some *)
            let v148 : int64 option = Some v147 
            v148
    struct (v137, v139, v140, v142, v146, v153)
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
and closure7 () (v0 : int64) : US4 =
    US4_0(v0)
and method11 () : (int64 -> US4) =
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
    let v7 : (int64 -> US4) = method11()
    let v8 : US4 option = v5 |> Option.map v7 
    let v19 : US4 = US4_1
    let v20 : US4 = v8 |> Option.defaultValue v19 
    let v117 : System.DateTime =
        match v20 with
        | US4_1 -> (* None *)
            let v101 : unit = ()
            
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
        | US4_0(v24) -> (* Some *)
            let v25 : unit = ()
            
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
            let v40 : unit = ()
            
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
    let v118 : string = method12()
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
    let v139 : (int64 -> US4) = method11()
    let v140 : US4 option = v5 |> Option.map v139 
    let v151 : US4 = US4_1
    let v152 : US4 = v140 |> Option.defaultValue v151 
    let v249 : System.DateTime =
        match v152 with
        | US4_1 -> (* None *)
            let v233 : unit = ()
            
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
        | US4_0(v156) -> (* Some *)
            let v157 : unit = ()
            
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
            let v172 : unit = ()
            
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
    let v250 : string = method12()
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
    let v273 : (int64 -> US4) = method11()
    let v274 : US4 option = v5 |> Option.map v273 
    let v285 : US4 = US4_1
    let v286 : US4 = v274 |> Option.defaultValue v285 
    let v297 : uint64 =
        match v286 with
        | US4_1 -> (* None *)
            v272
        | US4_0(v290) -> (* Some *)
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
    let v308 : (int64 -> US4) = method11()
    let v309 : US4 option = v5 |> Option.map v308 
    let v320 : US4 = US4_1
    let v321 : US4 = v309 |> Option.defaultValue v320 
    let v418 : System.DateTime =
        match v321 with
        | US4_1 -> (* None *)
            let v402 : unit = ()
            
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
        | US4_0(v325) -> (* Some *)
            let v326 : unit = ()
            
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
            let v341 : unit = ()
            
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
    let v419 : string = method13()
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
    let v440 : (int64 -> US4) = method11()
    let v441 : US4 option = v5 |> Option.map v440 
    let v452 : US4 = US4_1
    let v453 : US4 = v441 |> Option.defaultValue v452 
    let v550 : System.DateTime =
        match v453 with
        | US4_1 -> (* None *)
            let v534 : unit = ()
            
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
        | US4_0(v457) -> (* Some *)
            let v458 : unit = ()
            
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
            let v473 : unit = ()
            
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
    let v551 : string = method13()
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
    let v572 : (int64 -> US4) = method11()
    let v573 : US4 option = v5 |> Option.map v572 
    let v584 : US4 = US4_1
    let v585 : US4 = v573 |> Option.defaultValue v584 
    let v682 : System.DateTime =
        match v585 with
        | US4_1 -> (* None *)
            let v666 : unit = ()
            
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
        | US4_0(v589) -> (* Some *)
            let v590 : unit = ()
            
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
            let v605 : unit = ()
            
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
    let v683 : string = method13()
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
    let v704 : (int64 -> US4) = method11()
    let v705 : US4 option = v5 |> Option.map v704 
    let v716 : US4 = US4_1
    let v717 : US4 = v705 |> Option.defaultValue v716 
    let v814 : System.DateTime =
        match v717 with
        | US4_1 -> (* None *)
            let v798 : unit = ()
            
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
        | US4_0(v721) -> (* Some *)
            let v722 : unit = ()
            
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
            let v737 : unit = ()
            
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
    let v815 : string = method13()
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
    let v42 : unit = ()
    
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
    let v74 : unit = ()
    
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
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
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
    let v30 : char list = []
    let v31 : char list = '/' :: v30 
    let v34 : char list = ' ' :: v31 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v6.TrimEnd v38 
    v41
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
    let v54 : unit = ()
    
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
    let v35 : char list = []
    let v36 : char list = '\\' :: v35 
    let v39 : (char list -> (char [])) = List.toArray
    let v40 : (char []) = v39 v36
    let v43 : string = v11.TrimEnd v40 
    v43
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
and method31 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v2 : near_workspaces_Contract) : string =
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
    let _run_target_args'_v66 = v70 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v71 : string = "format!(\"{:#?}\", $0)"
    let v72 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v71 
    let v73 : string = "fable_library_rust::String_::fromString($0)"
    let v74 : string = Fable.Core.RustInterop.emitRustExpr v72 v73 
    let _run_target_args'_v66 = v74 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : string = "format!(\"{:#?}\", $0)"
    let v76 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v75 
    let v77 : string = "fable_library_rust::String_::fromString($0)"
    let v78 : string = Fable.Core.RustInterop.emitRustExpr v76 v77 
    let _run_target_args'_v66 = v78 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v79 : string = $"%A{v1}"
    let _run_target_args'_v66 = v79 
    #endif
#if FABLE_COMPILER_PYTHON
    let v82 : string = $"%A{v1}"
    let _run_target_args'_v66 = v82 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : string = $"%A{v1}"
    let _run_target_args'_v66 = v85 
    #endif
#else
    let v88 : string = $"%A{v1}"
    let _run_target_args'_v66 = v88 
    #endif
    let v91 : string = _run_target_args'_v66 
    let v96 : string = $"{v91}"
    let v99 : unit = ()
    let v100 : (unit -> unit) = closure8(v4, v96)
    let v101 : unit = (fun () -> v100 (); v99) ()
    let v104 : string = $"{v40}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v4, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = "contract"
    let v113 : string = $"{v112}"
    let v116 : unit = ()
    let v117 : (unit -> unit) = closure8(v4, v113)
    let v118 : unit = (fun () -> v117 (); v116) ()
    let v121 : string = $"{v23}"
    let v124 : unit = ()
    let v125 : (unit -> unit) = closure8(v4, v121)
    let v126 : unit = (fun () -> v125 (); v124) ()
    let v129 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v130 : string = "format!(\"{:#?}\", $0)"
    let v131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v130 
    let v132 : string = "fable_library_rust::String_::fromString($0)"
    let v133 : string = Fable.Core.RustInterop.emitRustExpr v131 v132 
    let _run_target_args'_v129 = v133 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v134 : string = "format!(\"{:#?}\", $0)"
    let v135 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v134 
    let v136 : string = "fable_library_rust::String_::fromString($0)"
    let v137 : string = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let _run_target_args'_v129 = v137 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v138 : string = "format!(\"{:#?}\", $0)"
    let v139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v138 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v139 v140 
    let _run_target_args'_v129 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : string = $"%A{v2}"
    let _run_target_args'_v129 = v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v145 : string = $"%A{v2}"
    let _run_target_args'_v129 = v145 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v148 : string = $"%A{v2}"
    let _run_target_args'_v129 = v148 
    #endif
#else
    let v151 : string = $"%A{v2}"
    let _run_target_args'_v129 = v151 
    #endif
    let v154 : string = _run_target_args'_v129 
    let v159 : string = $"{v154}"
    let v162 : unit = ()
    let v163 : (unit -> unit) = closure8(v4, v159)
    let v164 : unit = (fun () -> v163 (); v162) ()
    let v167 : string = " }"
    let v168 : string = $"{v167}"
    let v171 : unit = ()
    let v172 : (unit -> unit) = closure8(v4, v168)
    let v173 : unit = (fun () -> v172 (); v171) ()
    let v176 : string = v4.l0
    v176
and method30 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v10 : near_workspaces_Contract) : string =
    let v11 : string = method31(v8, v9, v10)
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
        let v41 : string = method30(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method21(v41)
and method33 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) : string =
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
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _run_target_args'_v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _run_target_args'_v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _run_target_args'_v65 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _run_target_args'_v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _run_target_args'_v65 = v87 
    #endif
    let v90 : string = _run_target_args'_v65 
    let v95 : string = $"{v90}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure8(v3, v95)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v103 : string = " }"
    let v104 : string = $"{v103}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v3, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = v3.l0
    v112
and method32 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : near_workspaces_result_ExecutionFinalResult) : string =
    let v10 : string = method33(v8, v9)
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
        let v40 : string = method32(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and closure17 (v0 : std_string_String) () : unit =
    let v1 : (std_string_String -> unit) = System.Console.WriteLine
    v1 v0
and closure16 () (v0 : std_string_String) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure17(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method34 () : unit =
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
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v43 
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
    let v106 : bool = v39 <> v105 
    let v110 : bool =
        if v106 then
            let v109 : bool = v98 <= 1
            v109
        else
            false
    if v110 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v105
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
    v40 v39
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v39
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v39
    #endif
#else
    v40 v39
    #endif
    // run_target_args' is_unit
    let v121 : (string -> unit) = v17.l0
    v121 v39
and closure18 () () : unit =
    let v0 : US3 = US3_2
    let v1 : bool = method9(v0)
    if v1 then
        method34()
and method35 () : string =
    
    
    
    
    
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
    let v40 : string = "inline_colorization::color_bright_green"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
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
    let v72 : string = "inline_colorization::color_bright_green"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
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
    let v104 : string = "\u001b[92m"
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[92m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[92m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[92m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
and method37 (v0 : uint8, v1 : float, v2 : uint64) : string =
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
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : float, v10 : uint64) : string =
    let v11 : string = method37(v8, v9, v10)
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
        let v40 : string = method35()
        let v41 : string = method36(v21, v22, v23, v24, v25, v26, v39, v40, v0, v2, v1)
        method21(v41)
and method39 (v0 : bool, v1 : float, v2 : float, v3 : uint64, v4 : u128) : string =
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
    let _run_target_args'_v170 = v174 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v175 : string = "format!(\"{:#?}\", $0)"
    let v176 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v175 
    let v177 : string = "fable_library_rust::String_::fromString($0)"
    let v178 : string = Fable.Core.RustInterop.emitRustExpr v176 v177 
    let _run_target_args'_v170 = v178 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = "format!(\"{:#?}\", $0)"
    let v180 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v179 
    let v181 : string = "fable_library_rust::String_::fromString($0)"
    let v182 : string = Fable.Core.RustInterop.emitRustExpr v180 v181 
    let _run_target_args'_v170 = v182 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v183 : string = $"%A{v4}"
    let _run_target_args'_v170 = v183 
    #endif
#if FABLE_COMPILER_PYTHON
    let v186 : string = $"%A{v4}"
    let _run_target_args'_v170 = v186 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v189 : string = $"%A{v4}"
    let _run_target_args'_v170 = v189 
    #endif
#else
    let v192 : string = $"%A{v4}"
    let _run_target_args'_v170 = v192 
    #endif
    let v195 : string = _run_target_args'_v170 
    let v200 : string = $"{v195}"
    let v203 : unit = ()
    let v204 : (unit -> unit) = closure8(v6, v200)
    let v205 : unit = (fun () -> v204 (); v203) ()
    let v208 : string = " }"
    let v209 : string = $"{v208}"
    let v212 : unit = ()
    let v213 : (unit -> unit) = closure8(v6, v209)
    let v214 : unit = (fun () -> v213 (); v212) ()
    let v217 : string = v6.l0
    v217
and method38 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : float, v10 : float, v11 : uint64, v12 : u128) : string =
    let v13 : string = method39(v8, v9, v10, v11, v12)
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
        let v42 : string = method35()
        let v43 : string = method38(v23, v24, v25, v26, v27, v28, v41, v42, v0, v2, v4, v1, v3)
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
    let v11 : float = v8 / 10000000000000000.0
    let v12 : float = v11 * 6.68
    let v13 : string = "$0.tokens_burnt"
    let v14 : near_workspaces_types_NearToken = Fable.Core.RustInterop.emitRustExpr v0 v13 
    let v15 : string = "$0.as_yoctonear()"
    let v16 : u128 = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : string = "$0 as f64"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr v16 v17 
    let v19 : float = v18 / 1E+24
    let v20 : float = v19 * 6.68
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure21(v2, v6, v12, v16, v20)
    let v23 : unit = (fun () -> v22 (); v21) ()
    ()
and method41 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
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
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method40 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
    let v9 : string = method41(v8)
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
        let v39 : string = method40(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method42 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method44 (v0 : int32, v1 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
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
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _run_target_args'_v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _run_target_args'_v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _run_target_args'_v65 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _run_target_args'_v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _run_target_args'_v65 = v87 
    #endif
    let v90 : string = _run_target_args'_v65 
    let v95 : string = $"{v90}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure8(v3, v95)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v103 : string = " }"
    let v104 : string = $"{v103}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v3, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = v3.l0
    v112
and method43 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v10 : string = method44(v8, v9)
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
        let v40 : string = method43(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method21(v40)
and method45 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method47 (v0 : int32, v1 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
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
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _run_target_args'_v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _run_target_args'_v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _run_target_args'_v65 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _run_target_args'_v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _run_target_args'_v65 = v87 
    #endif
    let v90 : string = _run_target_args'_v65 
    let v95 : string = $"{v90}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure8(v3, v95)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v103 : string = " }"
    let v104 : string = $"{v103}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v3, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = v3.l0
    v112
and method46 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
    let v10 : string = method47(v8, v9)
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
        let v40 : string = method46(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method21(v40)
and method49 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
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
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method48 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v9 : string = method49(v8)
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
        let v39 : string = method48(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method51 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
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
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method50 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v9 : string = method51(v8)
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
        let v39 : string = method50(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method52 (v0 : int32, v1 : uint8, v2 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
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
    let _run_target_args'_v99 = v103 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _run_target_args'_v99 = v107 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v108 : string = "format!(\"{:#?}\", $0)"
    let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v108 
    let v110 : string = "fable_library_rust::String_::fromString($0)"
    let v111 : string = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let _run_target_args'_v99 = v111 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v112 : string = $"%A{v2}"
    let _run_target_args'_v99 = v112 
    #endif
#if FABLE_COMPILER_PYTHON
    let v115 : string = $"%A{v2}"
    let _run_target_args'_v99 = v115 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : string = $"%A{v2}"
    let _run_target_args'_v99 = v118 
    #endif
#else
    let v121 : string = $"%A{v2}"
    let _run_target_args'_v99 = v121 
    #endif
    let v124 : string = _run_target_args'_v99 
    let v129 : string = $"{v124}"
    let v132 : unit = ()
    let v133 : (unit -> unit) = closure8(v4, v129)
    let v134 : unit = (fun () -> v133 (); v132) ()
    let v137 : string = " }"
    let v138 : string = $"{v137}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure8(v4, v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v146 : string = v4.l0
    v146
and method29 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US7, anyhow_Error>>>>> =
    let v2 : string = "true; let __future_init = Box::pin(/*"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : string = "*/ async move { /*"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : string = "*/ //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "near_workspaces::sandbox().await"
    let v9 : Result<near_workspaces_Worker<near_workspaces_network_Sandbox>, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "$0?"
    let v11 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0"
    let v13 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "Box::pin(v13.dev_deploy(&$0))"
    let v15 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_Contract, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr v0 v14 
    let v16 : string = "v15.await"
    let v17 : Result<near_workspaces_Contract, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v16 
    let v18 : string = "$0?"
    let v19 : near_workspaces_Contract = Fable.Core.RustInterop.emitRustExpr v17 v18 
    let v20 : unit = ()
    let v21 : (unit -> unit) = closure14(v1, v11, v19)
    let v22 : unit = (fun () -> v21 (); v20) ()
    let v62 : string = "$0.call(&*$1)"
    let v63 : string = "state_main"
    let v64 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr struct (v19, v63) v62 
    let v65 : string = "near_workspaces::types::Gas::from_tgas(300)"
    let v66 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr () v65 
    let v67 : string = "v64.gas(v66)"
    let v68 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr () v67 
    let v69 : string = "Box::pin(v68.transact())"
    let v70 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : string = "v70.await"
    let v72 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v71 
    let v73 : string = "$0?"
    let v74 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v72 v73 
    let v75 : unit = ()
    let v76 : (unit -> unit) = closure15(v1, v74)
    let v77 : unit = (fun () -> v76 (); v75) ()
    let v117 : string = "v74.logs()"
    let v118 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v117 
    let v119 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v120 : bool = Fable.Core.RustInterop.emitRustExpr v118 v119 
    let v121 : string = "x"
    let v122 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v121 
    let v123 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v124 : string = "String::from($0)"
    let v125 : std_string_String = Fable.Core.RustInterop.emitRustExpr v122 v124 
    let _run_target_args'_v123 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v126 : string = "String::from($0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v122 v126 
    let _run_target_args'_v123 = v127 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v128 : string = "String::from($0)"
    let v129 : std_string_String = Fable.Core.RustInterop.emitRustExpr v122 v128 
    let _run_target_args'_v123 = v129 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v130 : std_string_String = v122 |> unbox<std_string_String>
    let _run_target_args'_v123 = v130 
    #endif
#if FABLE_COMPILER_PYTHON
    let v133 : std_string_String = v122 |> unbox<std_string_String>
    let _run_target_args'_v123 = v133 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v136 : std_string_String = v122 |> unbox<std_string_String>
    let _run_target_args'_v123 = v136 
    #endif
#else
    let v139 : std_string_String = v122 |> unbox<std_string_String>
    let _run_target_args'_v123 = v139 
    #endif
    let v142 : std_string_String = _run_target_args'_v123 
    let v147 : string = "true; $0 }).collect::<Vec<_>>()"
    let v148 : bool = Fable.Core.RustInterop.emitRustExpr v142 v147 
    let v149 : string = "_vec_map"
    let v150 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v149 
    let v151 : string = "true; $0.iter().for_each(|x| { $1(x.clone()); }); //"
    let v152 : (std_string_String -> unit) = closure16()
    let v153 : bool = Fable.Core.RustInterop.emitRustExpr struct (v150, v152) v151 
    let v154 : unit = ()
    let v155 : (unit -> unit) = closure18()
    let v156 : unit = (fun () -> v155 (); v154) ()
    let v159 : string = "$0.total_gas_burnt"
    let v160 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v74 v159 
    let v161 : string = "$0.as_gas()"
    let v162 : uint64 = Fable.Core.RustInterop.emitRustExpr v160 v161 
    let v163 : (uint64 -> float) = float
    let v164 : float = v163 v162
    let v167 : float = v164 / 10000000000000000.0
    let v168 : float = v167 * 6.68
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure19(v1, v162, v168)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v211 : string = "$0"
    let v212 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v74 v211 
    let v213 : string = "v212.outcomes()"
    let v214 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v213 
    let v215 : string = "v214.into_iter()"
    let v216 : _ = Fable.Core.RustInterop.emitRustExpr () v215 
    let v217 : string = "v216.cloned()"
    let v218 : _ = Fable.Core.RustInterop.emitRustExpr () v217 
    let v219 : string = "true; v218.for_each(|x| $0(x))"
    let v220 : (near_workspaces_result_ExecutionOutcome -> unit) = closure20()
    let v221 : bool = Fable.Core.RustInterop.emitRustExpr v220 v219 
    let v222 : string = "$0.into_result()"
    let v223 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v74 v222 
    let v224 : unit = ()
    let v225 : (unit -> unit) = closure22(v223)
    let v226 : unit = (fun () -> v225 (); v224) ()
    let v266 : near_workspaces_result_ExecutionFinalResult = method42(v74)
    let v267 : string = "v266.receipt_failures()"
    let v268 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v267 
    let v269 : string = "$0.len()"
    let v270 : unativeint = Fable.Core.RustInterop.emitRustExpr v268 v269 
    let v271 : int32 = v270 |> int32 
    let v278 : unit = ()
    let v279 : (unit -> unit) = closure23(v268, v271)
    let v280 : unit = (fun () -> v279 (); v278) ()
    let v320 : near_workspaces_result_ExecutionFinalResult = method45(v74)
    let v321 : string = "v320.receipt_outcomes()"
    let v322 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v321 
    let v323 : string = "v322.into()"
    let v324 : Vec<near_workspaces_result_ExecutionOutcome> = Fable.Core.RustInterop.emitRustExpr () v323 
    let v325 : string = "$0.len()"
    let v326 : unativeint = Fable.Core.RustInterop.emitRustExpr v324 v325 
    let v327 : int32 = v326 |> int32 
    let v334 : unit = ()
    let v335 : (unit -> unit) = closure24(v324, v327)
    let v336 : unit = (fun () -> v335 (); v334) ()
    let v376 : string = "$0.json()"
    let v377 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v74 v376 
    let v378 : unit = ()
    let v379 : (unit -> unit) = closure25(v377)
    let v380 : unit = (fun () -> v379 (); v378) ()
    let v420 : string = "$0.borsh()"
    let v421 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v74 v420 
    let v422 : unit = ()
    let v423 : (unit -> unit) = closure26(v421)
    let v424 : unit = (fun () -> v423 (); v422) ()
    let v464 : string = method52(v327, v1, v268)
    let v465 : bool = v271 > 0
    let v488 : Result<US7, anyhow_Error> =
        if v465 then
            let v466 : US7 = US7_0(v464)
            let v467 : Result<US7, anyhow_Error> = Ok v466 
            v467
        else
            let v468 : bool = v327 > 1
            if v468 then
                let v469 : US7 = US7_1
                let v470 : Result<US7, anyhow_Error> = Ok v469 
                v470
            else
                let v471 : string = "anyhow::anyhow!($0)"
                let v472 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v464 v471 
                let v473 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v474 : string = "Err($0)"
                let v475 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v472 v474 
                let _run_target_args'_v473 = v475 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v476 : string = "Err($0)"
                let v477 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v472 v476 
                let _run_target_args'_v473 = v477 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v478 : string = "Err($0)"
                let v479 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v472 v478 
                let _run_target_args'_v473 = v479 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v480 : Result<US7, anyhow_Error> = v472 |> Error
                let _run_target_args'_v473 = v480 
                #endif
#if FABLE_COMPILER_PYTHON
                let v481 : Result<US7, anyhow_Error> = v472 |> Error
                let _run_target_args'_v473 = v481 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v482 : Result<US7, anyhow_Error> = v472 |> Error
                let _run_target_args'_v473 = v482 
                #endif
#else
                let v483 : Result<US7, anyhow_Error> = v472 |> Error
                let _run_target_args'_v473 = v483 
                #endif
                let v484 : Result<US7, anyhow_Error> = _run_target_args'_v473 
                v484
    let v489 : string = ""
    let v490 : string = "}"
    let v491 : string = v489 + v490 
    let x = v488 //
    let v492 : _ = x
    let v493 : unit = ()
    let v494 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v495 : string = $"true; let _fix_closure_v493 = $0"
    let v496 : bool = Fable.Core.RustInterop.emitRustExpr v492 v495 
    let _run_target_args'_v494 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v497 : string = $"true; let _fix_closure_v493 = $0"
    let v498 : bool = Fable.Core.RustInterop.emitRustExpr v492 v497 
    let _run_target_args'_v494 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v499 : string = $"true; let _fix_closure_v493 = $0"
    let v500 : bool = Fable.Core.RustInterop.emitRustExpr v492 v499 
    let _run_target_args'_v494 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v494 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v494 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v494 = false 
    #endif
#else
    let _run_target_args'_v494 = false 
    #endif
    let v501 : bool = _run_target_args'_v494 
    let v503 : string = $"true; _fix_closure_v493 " + v491 + "); " + v489 + " // rust.fix_closure'"
    let v504 : bool = Fable.Core.RustInterop.emitRustExpr () v503 
    let v505 : string = "__future_init"
    let v506 : _ = Fable.Core.RustInterop.emitRustExpr () v505 
    let v507 : string = "v506"
    let v508 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US7, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v507 
    v508
and closure27 () (v0 : anyhow_Error) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _run_target_args'_v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _run_target_args'_v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1 = v11 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1 = v14 
    #endif
#else
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1 = v17 
    #endif
    let v20 : std_string_String = _run_target_args'_v1 
    v20
and method53 () : (anyhow_Error -> std_string_String) =
    closure27()
and closure28 () (v0 : US7) : US9 =
    US9_0(v0)
and method54 () : (US7 -> US9) =
    closure28()
and closure29 () (v0 : std_string_String) : US9 =
    US9_1(v0)
and method55 () : (std_string_String -> US9) =
    closure29()
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
    let v42 : unit = ()
    
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
    let v74 : unit = ()
    
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
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
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
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v70 : string = "format!(\"{:#?}\", $0)"
    let v71 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v70 
    let v72 : string = "fable_library_rust::String_::fromString($0)"
    let v73 : string = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let _run_target_args'_v65 = v73 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v74 : string = "format!(\"{:#?}\", $0)"
    let v75 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v74 
    let v76 : string = "fable_library_rust::String_::fromString($0)"
    let v77 : string = Fable.Core.RustInterop.emitRustExpr v75 v76 
    let _run_target_args'_v65 = v77 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v78 : string = $"%A{v1}"
    let _run_target_args'_v65 = v78 
    #endif
#if FABLE_COMPILER_PYTHON
    let v81 : string = $"%A{v1}"
    let _run_target_args'_v65 = v81 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _run_target_args'_v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _run_target_args'_v65 = v87 
    #endif
    let v90 : string = _run_target_args'_v65 
    let v95 : string = $"{v90}"
    let v98 : unit = ()
    let v99 : (unit -> unit) = closure8(v3, v95)
    let v100 : unit = (fun () -> v99 (); v98) ()
    let v103 : string = " }"
    let v104 : string = $"{v103}"
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure8(v3, v104)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v112 : string = v3.l0
    v112
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
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v43 : string = @"println!(""{}"", $0)"
    Fable.Core.RustInterop.emitRustExpr v39 v43 
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
    let _run_target_args'_v53 = v55 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v56 
    let _run_target_args'_v53 = v57 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v58 : string = "&*$0"
    let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v52 v58 
    let _run_target_args'_v53 = v59 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v60 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _run_target_args'_v53 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v63 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _run_target_args'_v53 = v63 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _run_target_args'_v53 = v66 
    #endif
#else
    let v69 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _run_target_args'_v53 = v69 
    #endif
    let v72 : Ref<Str> = _run_target_args'_v53 
    let v77 : string = $"$0.chars()"
    let v78 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v72 v77 
    let v79 : string = "$0"
    let v80 : _ = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v81 : string = "$0.collect::<Vec<_>>()"
    let v82 : Vec<char> = Fable.Core.RustInterop.emitRustExpr v80 v81 
    let v83 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
    let v84 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v82 v83 
    let v85 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v86 : bool = Fable.Core.RustInterop.emitRustExpr v84 v85 
    let v87 : string = "x"
    let v88 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v87 
    let v89 : string = "String::from_iter($0)"
    let v90 : std_string_String = Fable.Core.RustInterop.emitRustExpr v88 v89 
    let v91 : string = "true; $0 }).collect::<Vec<_>>()"
    let v92 : bool = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let v93 : string = "_vec_map"
    let v94 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v93 
    let v95 : string = "$0.len()"
    let v96 : unativeint = Fable.Core.RustInterop.emitRustExpr v94 v95 
    let v97 : int32 = v96 |> int32 
    let v104 : string = ""
    let v105 : bool = v39 <> v104 
    let v109 : bool =
        if v105 then
            let v108 : bool = v97 <= 1
            v108
        else
            false
    if v109 then
        v19.l0 <- v52
        ()
    else
        v19.l0 <- v104
        let v110 : string = "true; $0.into_iter().for_each(|x| { //"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr v94 v110 
        let v112 : string = "x"
        let v113 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v115 : bool = Fable.Core.RustInterop.emitRustExpr v113 v114 
        let v116 : string = $"true"
        let v117 : bool = Fable.Core.RustInterop.emitRustExpr () v116 
        let v118 : string = "true; }); //"
        let v119 : bool = Fable.Core.RustInterop.emitRustExpr () v118 
        ()
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    v40 v39
    #endif
#if FABLE_COMPILER_PYTHON
    v40 v39
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    v40 v39
    #endif
#else
    v40 v39
    #endif
    // run_target_args' is_unit
    let v120 : (string -> unit) = v17.l0
    v120 v39
and closure31 () () : unit =
    let v0 : US3 = US3_3
    let v1 : bool = method9(v0)
    if v1 then
        method59()
and closure32 (v0 : uint8, v1 : std_string_String) () : unit =
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
and closure33 () () : unit =
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
    let v40 : string = "inline_colorization::color_bright_red"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40 
    let v42 : unit = ()
    
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
    let v72 : string = "inline_colorization::color_bright_red"
    let v73 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v72 
    let v74 : unit = ()
    
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
    let v104 : string = "\u001b[91m"
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _run_target_args'_v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _run_target_args'_v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _run_target_args'_v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _run_target_args'_v7 = v119 
    #endif
    let v120 : string = _run_target_args'_v7 
    v120
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
and closure34 (v0 : uint8, v1 : string) () : unit =
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
and method28 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> =
    let v2 : string = "true; let __future_init = Box::pin(/*"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : string = "*/ async move { /*"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4 
    let v6 : string = "*/ //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US7, anyhow_Error>>>>> = method29(v0, v1)
    let v9 : string = "v8.await"
    let v10 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v9 
    let v11 : (anyhow_Error -> std_string_String) = method53()
    let v12 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<US7, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v13 
    let _run_target_args'_v12 = v14 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = "$0.map_err(|x| $1(x))"
    let v16 : Result<US7, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v15 
    let _run_target_args'_v12 = v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : string = "$0.map_err(|x| $1(x))"
    let v18 : Result<US7, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v10, v11) v17 
    let _run_target_args'_v12 = v18 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v19 : Result<US7, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _run_target_args'_v12 = v19 
    #endif
#if FABLE_COMPILER_PYTHON
    let v20 : Result<US7, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _run_target_args'_v12 = v20 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : Result<US7, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _run_target_args'_v12 = v21 
    #endif
#else
    let v22 : Result<US7, std_string_String> = match v10 with Ok x -> Ok x | Error x -> Error (v11 x)
    let _run_target_args'_v12 = v22 
    #endif
    let v23 : Result<US7, std_string_String> = _run_target_args'_v12 
    let v26 : (US7 -> US9) = method54()
    let v27 : (std_string_String -> US9) = method55()
    let v28 : US9 = match v23 with Ok x -> v26 x | Error x -> v27 x
    let v270 : US8 =
        match v28 with
        | US9_1(v137) -> (* Error *)
            let v138 : bool = v1 >= 15uy
            if v138 then
                let v139 : unit = ()
                let v140 : (unit -> unit) = closure30(v1, v137)
                let v141 : unit = (fun () -> v140 (); v139) ()
                let v181 : unit = ()
                let v182 : (unit -> unit) = closure31()
                let v183 : unit = (fun () -> v182 (); v181) ()
                let v186 : string = "true; let __future_init = Box::pin(/*"
                let v187 : bool = Fable.Core.RustInterop.emitRustExpr () v186 
                let v188 : string = "*/ async move { /*"
                let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
                let v190 : string = "*/ //"
                let v191 : bool = Fable.Core.RustInterop.emitRustExpr () v190 
                let v192 : string = ""
                let v193 : string = "}"
                let v194 : string = v192 + v193 
                let v195 : US7 = US7_1
                let x = struct (v1, v195) //
                let v196 : _ = x
                let v197 : unit = ()
                let v198 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v199 : string = $"true; let _fix_closure_v197 = $0"
                let v200 : bool = Fable.Core.RustInterop.emitRustExpr v196 v199 
                let _run_target_args'_v198 = true 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v201 : string = $"true; let _fix_closure_v197 = $0"
                let v202 : bool = Fable.Core.RustInterop.emitRustExpr v196 v201 
                let _run_target_args'_v198 = true 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v203 : string = $"true; let _fix_closure_v197 = $0"
                let v204 : bool = Fable.Core.RustInterop.emitRustExpr v196 v203 
                let _run_target_args'_v198 = true 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _run_target_args'_v198 = false 
                #endif
#if FABLE_COMPILER_PYTHON
                let _run_target_args'_v198 = false 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _run_target_args'_v198 = false 
                #endif
#else
                let _run_target_args'_v198 = false 
                #endif
                let v205 : bool = _run_target_args'_v198 
                let v207 : string = $"true; _fix_closure_v197 " + v194 + "); " + v192 + " // rust.fix_closure'"
                let v208 : bool = Fable.Core.RustInterop.emitRustExpr () v207 
                let v209 : string = "__future_init"
                let v210 : _ = Fable.Core.RustInterop.emitRustExpr () v209 
                let v211 : string = "v210"
                let v212 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US7)>>>> = Fable.Core.RustInterop.emitRustExpr () v211 
                let v213 : string = "v212.await"
                let struct (v214 : uint8, v215 : US7) = Fable.Core.RustInterop.emitRustExpr () v213 
                US8_0(v214, v215)
            else
                let v217 : unit = ()
                let v218 : (unit -> unit) = closure32(v1, v137)
                let v219 : unit = (fun () -> v218 (); v217) ()
                let v259 : unit = ()
                let v260 : (unit -> unit) = closure33()
                let v261 : unit = (fun () -> v260 (); v259) ()
                let v264 : uint8 = v1 + 1uy
                let v265 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = method28(v0, v264)
                let v266 : string = "v265.await"
                let v267 : US8 = Fable.Core.RustInterop.emitRustExpr () v266 
                v267
        | US9_0(v29) -> (* Ok *)
            match v29 with
            | US7_1 -> (* None *)
                let v30 : string = "true; let __future_init = Box::pin(/*"
                let v31 : bool = Fable.Core.RustInterop.emitRustExpr () v30 
                let v32 : string = "*/ async move { /*"
                let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
                let v34 : string = "*/ //"
                let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
                let v36 : string = ""
                let v37 : string = "}"
                let v38 : string = v36 + v37 
                let v39 : US7 = US7_1
                let x = struct (v1, v39) //
                let v40 : _ = x
                let v41 : unit = ()
                let v42 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v43 : string = $"true; let _fix_closure_v41 = $0"
                let v44 : bool = Fable.Core.RustInterop.emitRustExpr v40 v43 
                let _run_target_args'_v42 = true 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v45 : string = $"true; let _fix_closure_v41 = $0"
                let v46 : bool = Fable.Core.RustInterop.emitRustExpr v40 v45 
                let _run_target_args'_v42 = true 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v47 : string = $"true; let _fix_closure_v41 = $0"
                let v48 : bool = Fable.Core.RustInterop.emitRustExpr v40 v47 
                let _run_target_args'_v42 = true 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _run_target_args'_v42 = false 
                #endif
#if FABLE_COMPILER_PYTHON
                let _run_target_args'_v42 = false 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _run_target_args'_v42 = false 
                #endif
#else
                let _run_target_args'_v42 = false 
                #endif
                let v49 : bool = _run_target_args'_v42 
                let v51 : string = $"true; _fix_closure_v41 " + v38 + "); " + v36 + " // rust.fix_closure'"
                let v52 : bool = Fable.Core.RustInterop.emitRustExpr () v51 
                let v53 : string = "__future_init"
                let v54 : _ = Fable.Core.RustInterop.emitRustExpr () v53 
                let v55 : string = "v54"
                let v56 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US7)>>>> = Fable.Core.RustInterop.emitRustExpr () v55 
                let v57 : string = "v56.await"
                let struct (v58 : uint8, v59 : US7) = Fable.Core.RustInterop.emitRustExpr () v57 
                US8_0(v58, v59)
            | US7_0(v61) -> (* Some *)
                let v62 : unit = ()
                let v63 : (unit -> unit) = closure34(v1, v61)
                let v64 : unit = (fun () -> v63 (); v62) ()
                let v104 : string = "true; let __future_init = Box::pin(/*"
                let v105 : bool = Fable.Core.RustInterop.emitRustExpr () v104 
                let v106 : string = "*/ async move { /*"
                let v107 : bool = Fable.Core.RustInterop.emitRustExpr () v106 
                let v108 : string = "*/ //"
                let v109 : bool = Fable.Core.RustInterop.emitRustExpr () v108 
                let v110 : string = ""
                let v111 : string = "}"
                let v112 : string = v110 + v111 
                let v113 : US7 = US7_0(v61)
                let x = struct (v1, v113) //
                let v114 : _ = x
                let v115 : unit = ()
                let v116 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v117 : string = $"true; let _fix_closure_v115 = $0"
                let v118 : bool = Fable.Core.RustInterop.emitRustExpr v114 v117 
                let _run_target_args'_v116 = true 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v119 : string = $"true; let _fix_closure_v115 = $0"
                let v120 : bool = Fable.Core.RustInterop.emitRustExpr v114 v119 
                let _run_target_args'_v116 = true 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v121 : string = $"true; let _fix_closure_v115 = $0"
                let v122 : bool = Fable.Core.RustInterop.emitRustExpr v114 v121 
                let _run_target_args'_v116 = true 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let _run_target_args'_v116 = false 
                #endif
#if FABLE_COMPILER_PYTHON
                let _run_target_args'_v116 = false 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let _run_target_args'_v116 = false 
                #endif
#else
                let _run_target_args'_v116 = false 
                #endif
                let v123 : bool = _run_target_args'_v116 
                let v125 : string = $"true; _fix_closure_v115 " + v112 + "); " + v110 + " // rust.fix_closure'"
                let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125 
                let v127 : string = "__future_init"
                let v128 : _ = Fable.Core.RustInterop.emitRustExpr () v127 
                let v129 : string = "v128"
                let v130 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US7)>>>> = Fable.Core.RustInterop.emitRustExpr () v129 
                let v131 : string = "v130.await"
                let struct (v132 : uint8, v133 : US7) = Fable.Core.RustInterop.emitRustExpr () v131 
                US8_1(v132, v133)
    let v271 : string = ""
    let v272 : string = "}"
    let v273 : string = v271 + v272 
    let x = v270 //
    let v274 : _ = x
    let v275 : unit = ()
    let v276 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v277 : string = $"true; let _fix_closure_v275 = $0"
    let v278 : bool = Fable.Core.RustInterop.emitRustExpr v274 v277 
    let _run_target_args'_v276 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v279 : string = $"true; let _fix_closure_v275 = $0"
    let v280 : bool = Fable.Core.RustInterop.emitRustExpr v274 v279 
    let _run_target_args'_v276 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v281 : string = $"true; let _fix_closure_v275 = $0"
    let v282 : bool = Fable.Core.RustInterop.emitRustExpr v274 v281 
    let _run_target_args'_v276 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v276 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v276 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v276 = false 
    #endif
#else
    let _run_target_args'_v276 = false 
    #endif
    let v283 : bool = _run_target_args'_v276 
    let v285 : string = $"true; _fix_closure_v275 " + v273 + "); " + v271 + " // rust.fix_closure'"
    let v286 : bool = Fable.Core.RustInterop.emitRustExpr () v285 
    let v287 : string = "__future_init"
    let v288 : _ = Fable.Core.RustInterop.emitRustExpr () v287 
    let v289 : string = "v288"
    let v290 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = Fable.Core.RustInterop.emitRustExpr () v289 
    v290
and method64 (v0 : US8) : string =
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
and method63 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : US8) : string =
    let v9 : string = method64(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method20(v12)
and closure35 (v0 : US8) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method9(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method10(v19, v20, v21, v22, v23, v24)
        let v38 : string = method14()
        let v39 : string = method63(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method65 (v0 : US8, v1 : US7) : string =
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
and method24 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(/*"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "*/ async move { /*"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let v5 : string = "*/ //"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : string = method25()
    let v8 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "&*$0"
    let v10 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "&*$0"
    let v12 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "&*$0"
    let v14 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v7 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v18 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v8 = v18 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v21 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v8 = v21 
    #endif
#else
    let v24 : Ref<Str> = v7 |> unbox<Ref<Str>>
    let _run_target_args'_v8 = v24 
    #endif
    let v27 : Ref<Str> = _run_target_args'_v8 
    let v32 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v33 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v0, v27) v32 
    let v34 : (std_string_String -> US0) = method2()
    let v35 : US0 option = v33 |> Option.map v34 
    let v46 : US0 = US0_1
    let v47 : US0 = v35 |> Option.defaultValue v46 
    let v54 : std_string_String =
        match v47 with
        | US0_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US0_0(v51) -> (* Some *)
            v51
    let v55 : string = "fable_library_rust::String_::fromString($0)"
    let v56 : string = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : unit = ()
    let v58 : (unit -> unit) = closure13(v56)
    let v59 : unit = (fun () -> v58 (); v57) ()
    let v99 : string = "std::fs::read(&*$0)"
    let v100 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v56 v99 
    let v101 : string = "$0?"
    let v102 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v100 v101 
    let v103 : uint8 = 1uy
    let v104 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = method28(v102, v103)
    let v105 : string = "v104.await"
    let v106 : US8 = Fable.Core.RustInterop.emitRustExpr () v105 
    let v107 : unit = ()
    let v108 : (unit -> unit) = closure35(v106)
    let v109 : unit = (fun () -> v108 (); v107) ()
    let v172 : Result<uint8, anyhow_Error> =
        match v106 with
        | US8_1(v152, v153) -> (* Error *)
            let v154 : string = method65(v106, v153)
            let v155 : string = "anyhow::anyhow!($0)"
            let v156 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v154 v155 
            let v157 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v158 : string = "Err($0)"
            let v159 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v156 v158 
            let _run_target_args'_v157 = v159 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v160 : string = "Err($0)"
            let v161 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v156 v160 
            let _run_target_args'_v157 = v161 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v162 : string = "Err($0)"
            let v163 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v156 v162 
            let _run_target_args'_v157 = v163 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v164 : Result<uint8, anyhow_Error> = v156 |> Error
            let _run_target_args'_v157 = v164 
            #endif
#if FABLE_COMPILER_PYTHON
            let v165 : Result<uint8, anyhow_Error> = v156 |> Error
            let _run_target_args'_v157 = v165 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v166 : Result<uint8, anyhow_Error> = v156 |> Error
            let _run_target_args'_v157 = v166 
            #endif
#else
            let v167 : Result<uint8, anyhow_Error> = v156 |> Error
            let _run_target_args'_v157 = v167 
            #endif
            let v168 : Result<uint8, anyhow_Error> = _run_target_args'_v157 
            v168
        | US8_0(v149, v150) -> (* Ok *)
            let v151 : Result<uint8, anyhow_Error> = Ok v149 
            v151
    let v173 : string = ""
    let v174 : string = "}"
    let v175 : string = v173 + v174 
    let x = v172 //
    let v176 : _ = x
    let v177 : unit = ()
    let v178 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v179 : string = $"true; let _fix_closure_v177 = $0"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v176 v179 
    let _run_target_args'_v178 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v181 : string = $"true; let _fix_closure_v177 = $0"
    let v182 : bool = Fable.Core.RustInterop.emitRustExpr v176 v181 
    let _run_target_args'_v178 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v183 : string = $"true; let _fix_closure_v177 = $0"
    let v184 : bool = Fable.Core.RustInterop.emitRustExpr v176 v183 
    let _run_target_args'_v178 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v178 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v178 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v178 = false 
    #endif
#else
    let _run_target_args'_v178 = false 
    #endif
    let v185 : bool = _run_target_args'_v178 
    let v187 : string = $"true; _fix_closure_v177 " + v175 + "); " + v173 + " // rust.fix_closure'"
    let v188 : bool = Fable.Core.RustInterop.emitRustExpr () v187 
    let v189 : string = "__future_init"
    let v190 : _ = Fable.Core.RustInterop.emitRustExpr () v189 
    let v191 : string = "v190"
    let v192 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v191 
    v192
and closure36 () (v0 : uint8) : US10 =
    US10_0(v0)
and method66 () : (uint8 -> US10) =
    closure36()
and closure37 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and method67 () : (std_string_String -> US10) =
    closure37()
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
    let _run_target_args'_v5 = v7 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v8 : string = "&*$0"
    let v9 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v8 
    let _run_target_args'_v5 = v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = "&*$0"
    let v11 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v10 
    let _run_target_args'_v5 = v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _run_target_args'_v5 = v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v15 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _run_target_args'_v5 = v15 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _run_target_args'_v5 = v18 
    #endif
#else
    let v21 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _run_target_args'_v5 = v21 
    #endif
    let v24 : Ref<Str> = _run_target_args'_v5 
    let v29 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v30 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v3, v24) v29 
    let v31 : (std_string_String -> US0) = method2()
    let v32 : US0 option = v30 |> Option.map v31 
    let v43 : US0 = US0_1
    let v44 : US0 = v32 |> Option.defaultValue v43 
    let v100 : US1 =
        match v44 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v48) -> (* Some *)
            let v49 : string = "fable_library_rust::String_::fromString($0)"
            let v50 : string = Fable.Core.RustInterop.emitRustExpr v48 v49 
            
            
            
            
            
            let v51 : bool = "Verbose" = v50
            let v55 : US2 =
                if v51 then
                    let v52 : US3 = US3_0
                    US2_0(v52)
                else
                    US2_1
            let v96 : US2 =
                match v55 with
                | US2_1 -> (* None *)
                    let v58 : bool = "Debug" = v50
                    let v62 : US2 =
                        if v58 then
                            let v59 : US3 = US3_1
                            US2_0(v59)
                        else
                            US2_1
                    match v62 with
                    | US2_1 -> (* None *)
                        let v65 : bool = "Info" = v50
                        let v69 : US2 =
                            if v65 then
                                let v66 : US3 = US3_2
                                US2_0(v66)
                            else
                                US2_1
                        match v69 with
                        | US2_1 -> (* None *)
                            let v72 : bool = "Warning" = v50
                            let v76 : US2 =
                                if v72 then
                                    let v73 : US3 = US3_3
                                    US2_0(v73)
                                else
                                    US2_1
                            match v76 with
                            | US2_1 -> (* None *)
                                let v79 : bool = "Critical" = v50
                                let v83 : US2 =
                                    if v79 then
                                        let v80 : US3 = US3_4
                                        US2_0(v80)
                                    else
                                        US2_1
                                match v83 with
                                | US2_1 -> (* None *)
                                    US2_1
                                | US2_0(v84) -> (* Some *)
                                    US2_0(v84)
                            | US2_0(v77) -> (* Some *)
                                US2_0(v77)
                        | US2_0(v70) -> (* Some *)
                            US2_0(v70)
                    | US2_0(v63) -> (* Some *)
                        US2_0(v63)
                | US2_0(v56) -> (* Some *)
                    US2_0(v56)
            US1_0(v96)
    let v107 : US2 =
        match v100 with
        | US1_0(v101) -> (* Some *)
            match v101 with
            | US2_0(v102) -> (* Some *)
                US2_0(v102)
            | _ ->
                US2_1
        | _ ->
            US2_1
    let v111 : US3 =
        match v107 with
        | US2_1 -> (* None *)
            US3_0
        | US2_0(v108) -> (* Some *)
            v108
    let v112 : unit = ()
    let v113 : (unit -> unit) = closure2(v111)
    let v114 : unit = (fun () -> v113 (); v112) ()
    let struct (v126 : Mut0, v127 : Mut1, v128 : Mut2, v129 : Mut3, v130 : Mut4, v131 : int64 option) = TraceState.trace_state.Value
    let v144 : unit = ()
    let v145 : (unit -> unit) = closure5(v0)
    let v146 : unit = (fun () -> v145 (); v144) ()
    let v186 : string = method22()
    let v187 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : string = "&*$0"
    let v189 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v188 
    let _run_target_args'_v187 = v189 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = "&*$0"
    let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v190 
    let _run_target_args'_v187 = v191 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v192 : string = "&*$0"
    let v193 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v192 
    let _run_target_args'_v187 = v193 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _run_target_args'_v187 = v194 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _run_target_args'_v187 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v200 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _run_target_args'_v187 = v200 
    #endif
#else
    let v203 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _run_target_args'_v187 = v203 
    #endif
    let v206 : Ref<Str> = _run_target_args'_v187 
    let v211 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v212 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v3, v206) v211 
    let v213 : (std_string_String -> string) = method23()
    let v214 : string option = v212 |> Option.map v213 
    let v290 : (string -> US7) = method8()
    let v291 : US7 option = v214 |> Option.map v290 
    let v302 : US7 = US7_1
    let v303 : US7 = v291 |> Option.defaultValue v302 
    let v307 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = method24(v3)
    let v308 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v309 : _ = Fable.Core.RustInterop.emitRustExpr () v308 
    let v310 : string = "v309.handle().block_on($0)"
    let v311 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v307 v310 
    let v312 : (anyhow_Error -> std_string_String) = method53()
    let v313 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v314 : string = "$0.map_err(|x| $1(x))"
    let v315 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v312) v314 
    let _run_target_args'_v313 = v315 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v316 : string = "$0.map_err(|x| $1(x))"
    let v317 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v312) v316 
    let _run_target_args'_v313 = v317 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v318 : string = "$0.map_err(|x| $1(x))"
    let v319 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v311, v312) v318 
    let _run_target_args'_v313 = v319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v320 : Result<uint8, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v312 x)
    let _run_target_args'_v313 = v320 
    #endif
#if FABLE_COMPILER_PYTHON
    let v321 : Result<uint8, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v312 x)
    let _run_target_args'_v313 = v321 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v322 : Result<uint8, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v312 x)
    let _run_target_args'_v313 = v322 
    #endif
#else
    let v323 : Result<uint8, std_string_String> = match v311 with Ok x -> Ok x | Error x -> Error (v312 x)
    let _run_target_args'_v313 = v323 
    #endif
    let v324 : Result<uint8, std_string_String> = _run_target_args'_v313 
    let v327 : (uint8 -> US10) = method66()
    let v328 : (std_string_String -> US10) = method67()
    let v329 : US10 = match v324 with Ok x -> v327 x | Error x -> v328 x
    match v329 with
    | US10_1(v351) -> (* Error *)
        match v303 with
        | US7_0(v352) -> (* Some *)
            let v353 : bool = "" = v352
            if v353 then
                ()
            else
                let v354 : string = "fable_library_rust::String_::fromString($0)"
                let v355 : string = Fable.Core.RustInterop.emitRustExpr v351 v354 
                let v356 : bool = v355.Contains v352 
                if v356 then
                    ()
                else
                    let v359 : string = $"spiral_wasm.main / exception: '{v352}' / error: {v351}"
                    let v360 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v361 : string = "Err($0)"
                    let v362 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v359 v361 
                    let _run_target_args'_v360 = v362 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v363 : string = "Err($0)"
                    let v364 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v359 v363 
                    let _run_target_args'_v360 = v364 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v365 : string = "Err($0)"
                    let v366 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v359 v365 
                    let _run_target_args'_v360 = v366 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v367 : Result<unit, string> = v359 |> Error
                    let _run_target_args'_v360 = v367 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v368 : Result<unit, string> = v359 |> Error
                    let _run_target_args'_v360 = v368 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v369 : Result<unit, string> = v359 |> Error
                    let _run_target_args'_v360 = v369 
                    #endif
#else
                    let v370 : Result<unit, string> = v359 |> Error
                    let _run_target_args'_v360 = v370 
                    #endif
                    let v371 : Result<unit, string> = _run_target_args'_v360 
                    let v374 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v375 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v371 v375 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v376 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v371 v376 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v377 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v371 v377 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    match v371 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    #endif
#if FABLE_COMPILER_PYTHON
                    match v371 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    match v371 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    #endif
#else
                    match v371 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    #endif
                    // run_target_args' is_unit
                    ()
        | _ ->
            let v378 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v379 : string = "$0.unwrap()"
            let v380 : uint8 = Fable.Core.RustInterop.emitRustExpr v324 v379 
            let _run_target_args'_v378 = v380 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v381 : string = "$0.unwrap()"
            let v382 : uint8 = Fable.Core.RustInterop.emitRustExpr v324 v381 
            let _run_target_args'_v378 = v382 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v383 : string = "$0.unwrap()"
            let v384 : uint8 = Fable.Core.RustInterop.emitRustExpr v324 v383 
            let _run_target_args'_v378 = v384 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v385 : uint8 = match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v378 = v385 
            #endif
#if FABLE_COMPILER_PYTHON
            let v386 : uint8 = match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v378 = v386 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v387 : uint8 = match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v378 = v387 
            #endif
#else
            let v388 : uint8 = match v324 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _run_target_args'_v378 = v388 
            #endif
            let v389 : uint8 = _run_target_args'_v378 
            ()
    | US10_0(v330) -> (* Ok *)
        match v303 with
        | US7_0(v331) -> (* Some *)
            let v332 : string = $"spiral_wasm.main / retries: {v330} / exception: '{v331}'"
            let v333 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v334 : string = "Err($0)"
            let v335 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v332 v334 
            let _run_target_args'_v333 = v335 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v336 : string = "Err($0)"
            let v337 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v332 v336 
            let _run_target_args'_v333 = v337 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v338 : string = "Err($0)"
            let v339 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v332 v338 
            let _run_target_args'_v333 = v339 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v340 : Result<unit, string> = v332 |> Error
            let _run_target_args'_v333 = v340 
            #endif
#if FABLE_COMPILER_PYTHON
            let v341 : Result<unit, string> = v332 |> Error
            let _run_target_args'_v333 = v341 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v342 : Result<unit, string> = v332 |> Error
            let _run_target_args'_v333 = v342 
            #endif
#else
            let v343 : Result<unit, string> = v332 |> Error
            let _run_target_args'_v333 = v343 
            #endif
            let v344 : Result<unit, string> = _run_target_args'_v333 
            let v347 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v348 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v344 v348 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v349 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v344 v349 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v350 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v344 v350 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if FABLE_COMPILER_PYTHON
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
#else
            match v344 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            #endif
            // run_target_args' is_unit
            ()
        | _ ->
            ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
