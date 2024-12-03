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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v99 : Ref<Str> = v85 |> unbox<Ref<Str>>
    let _v86 = v99 
    #endif
#else
    let v102 : Ref<Str> = v85 |> unbox<Ref<Str>>
    let _v86 = v102 
    #endif
    let v105 : Ref<Str> = _v86 
    let v110 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = "String::from($0)"
    let v112 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v111 
    let _v110 = v112 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v113 : string = "String::from($0)"
    let v114 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v113 
    let _v110 = v114 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v115 : string = "String::from($0)"
    let v116 : std_string_String = Fable.Core.RustInterop.emitRustExpr v105 v115 
    let _v110 = v116 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v117 : std_string_String = v105 |> unbox<std_string_String>
    let _v110 = v117 
    #endif
#if FABLE_COMPILER_PYTHON
    let v120 : std_string_String = v105 |> unbox<std_string_String>
    let _v110 = v120 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v123 : std_string_String = v105 |> unbox<std_string_String>
    let _v110 = v123 
    #endif
#else
    let v126 : std_string_String = v105 |> unbox<std_string_String>
    let _v110 = v126 
    #endif
    let v129 : std_string_String = _v110 
    let v134 : string = "Box::new($0)"
    let v135 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v129 v134 
    let v136 : string = "Box::leak($0)"
    let v137 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let v138 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v139 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v137 v138 
    let v140 : string = "true; $0 }).collect::<Vec<_>>()"
    let v141 : bool = Fable.Core.RustInterop.emitRustExpr v139 v140 
    let v142 : string = "_vec_map"
    let v143 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v142 
    let v144 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v145 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v143 v144 
    let v146 : string = "$0.value_parser($1)"
    let v147 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v54, v145) v146 
    let v148 : string = "clap::Command::arg($0, $1)"
    let v149 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v43, v147) v148 
    let v150 : string = "wasm"
    let v151 : string = "r#\"" + v150 + "\"#"
    let v152 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "clap::Arg::new($0)"
    let v154 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v152 v153 
    let v155 : string = "$0.short($1)"
    let v156 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v154, 'w') v155 
    let v157 : string = "r#\"" + v150 + "\"#"
    let v158 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v157 
    let v159 : string = "$0.long($1)"
    let v160 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v156, v158) v159 
    let v161 : string = "$0.required($1)"
    let v162 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v160, true) v161 
    let v163 : string = "clap::Command::arg($0, $1)"
    let v164 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v149, v162) v163 
    v164
and method1 () : string =
    let v0 : string = "trace_level"
    v0
and closure1 () (v0 : std_string_String) : US0 =
    US0_0(v0)
and method2 () : (std_string_String -> US0) =
    closure1()
and method6 () : string =
    let v0 : string = ""
    v0
and closure3 () (v0 : string) : US7 =
    US7_0(v0)
and method7 () : (string -> US7) =
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
    let v17 : US5 = US5_1
    let v18 : US6 = US6_2(v17)
    let v19 : string = $"env.get_environment_variable / target: {v18} / var: {v0}"
    let v20 : string = failwith<string> v19
    let _v1 = v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v21 : US5 = US5_2
    let v22 : US6 = US6_2(v21)
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
    let v42 : (string -> US7) = method7()
    let v43 : US7 option = v39 |> Option.map v42 
    let v54 : US7 = US7_1
    let v55 : US7 = v43 |> Option.defaultValue v54 
    let v62 : string =
        match v55 with
        | US7_1 -> (* None *)
            let v60 : string = ""
            v60
        | US7_0(v59) -> (* Some *)
            v59
    let _v1 = v62 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v63 : US5 = US5_1
    let v64 : US6 = US6_0(v63)
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
    let v74 : (string -> US7) = method7()
    let v75 : US7 option = v71 |> Option.map v74 
    let v86 : US7 = US7_1
    let v87 : US7 = v75 |> Option.defaultValue v86 
    let v94 : string =
        match v87 with
        | US7_1 -> (* None *)
            let v92 : string = ""
            v92
        | US7_0(v91) -> (* Some *)
            v91
    let _v1 = v94 
    #endif
    let v95 : string = _v1 
    v95
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
            US4_0(v103)
    struct (v47, v107)
and closure4 () (v0 : string) : unit =
    ()
and method3 (v0 : US3) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : US2, v3 : US4) = method4()
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : US2 = US2_1
    let v5 : US4 = US4_1
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
    let _v1 = struct (v122, v121) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v123 : US2, v124 : US4) = method4()
    let _v1 = struct (v123, v124) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v125 : US2, v126 : US4) = method4()
    let _v1 = struct (v125, v126) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v127 : US2, v128 : US4) = method4()
    let _v1 = struct (v127, v128) 
    #endif
#else
    let struct (v129 : US2, v130 : US4) = method4()
    let _v1 = struct (v129, v130) 
    #endif
    let struct (v131 : US2, v132 : US4) = _v1 
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
and method8 (v0 : US3) : bool =
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
and method10 () : (int64 -> US4) =
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
    let v7 : (int64 -> US4) = method10()
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
        | US4_0(v24) -> (* Some *)
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
    let v118 : string = method11()
    let v121 : (string -> string) = v117.ToString
    let v122 : string = v121 v118
    let _v6 = v122 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v129 : (int64 -> US4) = method10()
    let v130 : US4 option = v5 |> Option.map v129 
    let v141 : US4 = US4_1
    let v142 : US4 = v130 |> Option.defaultValue v141 
    let v239 : System.DateTime =
        match v142 with
        | US4_1 -> (* None *)
            let v223 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v224 : System.DateTime = System.DateTime.Now
            let _v223 = v224 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v225 : System.DateTime = System.DateTime.Now
            let _v223 = v225 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v226 : System.DateTime = null |> unbox<System.DateTime>
            let _v223 = v226 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v229 : System.DateTime = System.DateTime.Now
            let _v223 = v229 
            #endif
#if FABLE_COMPILER_PYTHON
            let v230 : System.DateTime = System.DateTime.Now
            let _v223 = v230 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v231 : System.DateTime = System.DateTime.Now
            let _v223 = v231 
            #endif
#else
            let v232 : System.DateTime = System.DateTime.Now
            let _v223 = v232 
            #endif
            let v233 : System.DateTime = _v223 
            v233
        | US4_0(v146) -> (* Some *)
            let v147 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v148 : System.DateTime = System.DateTime.Now
            let _v147 = v148 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v149 : System.DateTime = System.DateTime.Now
            let _v147 = v149 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v150 : System.DateTime = null |> unbox<System.DateTime>
            let _v147 = v150 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v153 : System.DateTime = System.DateTime.Now
            let _v147 = v153 
            #endif
#if FABLE_COMPILER_PYTHON
            let v154 : System.DateTime = System.DateTime.Now
            let _v147 = v154 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v155 : System.DateTime = System.DateTime.Now
            let _v147 = v155 
            #endif
#else
            let v156 : System.DateTime = System.DateTime.Now
            let _v147 = v156 
            #endif
            let v157 : System.DateTime = _v147 
            let v162 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v163 : (System.DateTime -> int64) = _.Ticks
            let v164 : int64 = v163 v157
            let _v162 = v164 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v165 : (System.DateTime -> int64) = _.Ticks
            let v166 : int64 = v165 v157
            let _v162 = v166 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v167 : int64 = null |> unbox<int64>
            let _v162 = v167 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v170 : (System.DateTime -> int64) = _.Ticks
            let v171 : int64 = v170 v157
            let _v162 = v171 
            #endif
#if FABLE_COMPILER_PYTHON
            let v172 : (System.DateTime -> int64) = _.Ticks
            let v173 : int64 = v172 v157
            let _v162 = v173 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v174 : (System.DateTime -> int64) = _.Ticks
            let v175 : int64 = v174 v157
            let _v162 = v175 
            #endif
#else
            let v176 : (System.DateTime -> int64) = _.Ticks
            let v177 : int64 = v176 v157
            let _v162 = v177 
            #endif
            let v178 : int64 = _v162 
            let v195 : int64 = v178 |> int64 
            let v198 : int64 = v195 - v146
            let v199 : System.TimeSpan = v198 |> System.TimeSpan 
            let v204 : (System.TimeSpan -> int32) = _.Hours
            let v205 : int32 = v204 v199
            let v208 : (System.TimeSpan -> int32) = _.Minutes
            let v209 : int32 = v208 v199
            let v212 : (System.TimeSpan -> int32) = _.Seconds
            let v213 : int32 = v212 v199
            let v216 : (System.TimeSpan -> int32) = _.Milliseconds
            let v217 : int32 = v216 v199
            let v220 : System.DateTime = System.DateTime (1, 1, 1, v205, v209, v213, v217)
            v220
    let v240 : string = method11()
    let v243 : (string -> string) = v239.ToString
    let v244 : string = v243 v240
    let _v6 = v244 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v251 : string = $"near_sdk::env::block_timestamp()"
    let v252 : uint64 = Fable.Core.RustInterop.emitRustExpr () v251 
    let v253 : (int64 -> US4) = method10()
    let v254 : US4 option = v5 |> Option.map v253 
    let v265 : US4 = US4_1
    let v266 : US4 = v254 |> Option.defaultValue v265 
    let v277 : uint64 =
        match v266 with
        | US4_1 -> (* None *)
            v252
        | US4_0(v270) -> (* Some *)
            let v271 : (int64 -> uint64) = uint64
            let v272 : uint64 = v271 v270
            let v275 : uint64 = v252 - v272
            v275
    let v278 : uint64 = v277 / 1000000000UL
    let v279 : uint64 = v278 % 60UL
    let v280 : uint64 = v278 / 60UL
    let v281 : uint64 = v280 % 60UL
    let v282 : uint64 = v278 / 3600UL
    let v283 : uint64 = v282 % 24UL
    let v284 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v285 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v283, v281, v279) v284 
    let v286 : string = "fable_library_rust::String_::fromString($0)"
    let v287 : string = Fable.Core.RustInterop.emitRustExpr v285 v286 
    let _v6 = v287 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v288 : (int64 -> US4) = method10()
    let v289 : US4 option = v5 |> Option.map v288 
    let v300 : US4 = US4_1
    let v301 : US4 = v289 |> Option.defaultValue v300 
    let v398 : System.DateTime =
        match v301 with
        | US4_1 -> (* None *)
            let v382 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v383 : System.DateTime = System.DateTime.Now
            let _v382 = v383 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v384 : System.DateTime = System.DateTime.Now
            let _v382 = v384 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v385 : System.DateTime = null |> unbox<System.DateTime>
            let _v382 = v385 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v388 : System.DateTime = System.DateTime.Now
            let _v382 = v388 
            #endif
#if FABLE_COMPILER_PYTHON
            let v389 : System.DateTime = System.DateTime.Now
            let _v382 = v389 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v390 : System.DateTime = System.DateTime.Now
            let _v382 = v390 
            #endif
#else
            let v391 : System.DateTime = System.DateTime.Now
            let _v382 = v391 
            #endif
            let v392 : System.DateTime = _v382 
            v392
        | US4_0(v305) -> (* Some *)
            let v306 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v307 : System.DateTime = System.DateTime.Now
            let _v306 = v307 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v308 : System.DateTime = System.DateTime.Now
            let _v306 = v308 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v309 : System.DateTime = null |> unbox<System.DateTime>
            let _v306 = v309 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v312 : System.DateTime = System.DateTime.Now
            let _v306 = v312 
            #endif
#if FABLE_COMPILER_PYTHON
            let v313 : System.DateTime = System.DateTime.Now
            let _v306 = v313 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v314 : System.DateTime = System.DateTime.Now
            let _v306 = v314 
            #endif
#else
            let v315 : System.DateTime = System.DateTime.Now
            let _v306 = v315 
            #endif
            let v316 : System.DateTime = _v306 
            let v321 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v322 : (System.DateTime -> int64) = _.Ticks
            let v323 : int64 = v322 v316
            let _v321 = v323 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v324 : (System.DateTime -> int64) = _.Ticks
            let v325 : int64 = v324 v316
            let _v321 = v325 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v326 : int64 = null |> unbox<int64>
            let _v321 = v326 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v329 : (System.DateTime -> int64) = _.Ticks
            let v330 : int64 = v329 v316
            let _v321 = v330 
            #endif
#if FABLE_COMPILER_PYTHON
            let v331 : (System.DateTime -> int64) = _.Ticks
            let v332 : int64 = v331 v316
            let _v321 = v332 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v333 : (System.DateTime -> int64) = _.Ticks
            let v334 : int64 = v333 v316
            let _v321 = v334 
            #endif
#else
            let v335 : (System.DateTime -> int64) = _.Ticks
            let v336 : int64 = v335 v316
            let _v321 = v336 
            #endif
            let v337 : int64 = _v321 
            let v354 : int64 = v337 |> int64 
            let v357 : int64 = v354 - v305
            let v358 : System.TimeSpan = v357 |> System.TimeSpan 
            let v363 : (System.TimeSpan -> int32) = _.Hours
            let v364 : int32 = v363 v358
            let v367 : (System.TimeSpan -> int32) = _.Minutes
            let v368 : int32 = v367 v358
            let v371 : (System.TimeSpan -> int32) = _.Seconds
            let v372 : int32 = v371 v358
            let v375 : (System.TimeSpan -> int32) = _.Milliseconds
            let v376 : int32 = v375 v358
            let v379 : System.DateTime = System.DateTime (1, 1, 1, v364, v368, v372, v376)
            v379
    let v399 : string = method12()
    let v402 : (string -> string) = v398.ToString
    let v403 : string = v402 v399
    let _v6 = v403 
    #endif
#if FABLE_COMPILER_PYTHON
    let v410 : (int64 -> US4) = method10()
    let v411 : US4 option = v5 |> Option.map v410 
    let v422 : US4 = US4_1
    let v423 : US4 = v411 |> Option.defaultValue v422 
    let v520 : System.DateTime =
        match v423 with
        | US4_1 -> (* None *)
            let v504 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v505 : System.DateTime = System.DateTime.Now
            let _v504 = v505 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v506 : System.DateTime = System.DateTime.Now
            let _v504 = v506 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v507 : System.DateTime = null |> unbox<System.DateTime>
            let _v504 = v507 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v510 : System.DateTime = System.DateTime.Now
            let _v504 = v510 
            #endif
#if FABLE_COMPILER_PYTHON
            let v511 : System.DateTime = System.DateTime.Now
            let _v504 = v511 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v512 : System.DateTime = System.DateTime.Now
            let _v504 = v512 
            #endif
#else
            let v513 : System.DateTime = System.DateTime.Now
            let _v504 = v513 
            #endif
            let v514 : System.DateTime = _v504 
            v514
        | US4_0(v427) -> (* Some *)
            let v428 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v429 : System.DateTime = System.DateTime.Now
            let _v428 = v429 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v430 : System.DateTime = System.DateTime.Now
            let _v428 = v430 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v431 : System.DateTime = null |> unbox<System.DateTime>
            let _v428 = v431 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v434 : System.DateTime = System.DateTime.Now
            let _v428 = v434 
            #endif
#if FABLE_COMPILER_PYTHON
            let v435 : System.DateTime = System.DateTime.Now
            let _v428 = v435 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v436 : System.DateTime = System.DateTime.Now
            let _v428 = v436 
            #endif
#else
            let v437 : System.DateTime = System.DateTime.Now
            let _v428 = v437 
            #endif
            let v438 : System.DateTime = _v428 
            let v443 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v444 : (System.DateTime -> int64) = _.Ticks
            let v445 : int64 = v444 v438
            let _v443 = v445 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v446 : (System.DateTime -> int64) = _.Ticks
            let v447 : int64 = v446 v438
            let _v443 = v447 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v448 : int64 = null |> unbox<int64>
            let _v443 = v448 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v451 : (System.DateTime -> int64) = _.Ticks
            let v452 : int64 = v451 v438
            let _v443 = v452 
            #endif
#if FABLE_COMPILER_PYTHON
            let v453 : (System.DateTime -> int64) = _.Ticks
            let v454 : int64 = v453 v438
            let _v443 = v454 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v455 : (System.DateTime -> int64) = _.Ticks
            let v456 : int64 = v455 v438
            let _v443 = v456 
            #endif
#else
            let v457 : (System.DateTime -> int64) = _.Ticks
            let v458 : int64 = v457 v438
            let _v443 = v458 
            #endif
            let v459 : int64 = _v443 
            let v476 : int64 = v459 |> int64 
            let v479 : int64 = v476 - v427
            let v480 : System.TimeSpan = v479 |> System.TimeSpan 
            let v485 : (System.TimeSpan -> int32) = _.Hours
            let v486 : int32 = v485 v480
            let v489 : (System.TimeSpan -> int32) = _.Minutes
            let v490 : int32 = v489 v480
            let v493 : (System.TimeSpan -> int32) = _.Seconds
            let v494 : int32 = v493 v480
            let v497 : (System.TimeSpan -> int32) = _.Milliseconds
            let v498 : int32 = v497 v480
            let v501 : System.DateTime = System.DateTime (1, 1, 1, v486, v490, v494, v498)
            v501
    let v521 : string = method12()
    let v524 : (string -> string) = v520.ToString
    let v525 : string = v524 v521
    let _v6 = v525 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v532 : (int64 -> US4) = method10()
    let v533 : US4 option = v5 |> Option.map v532 
    let v544 : US4 = US4_1
    let v545 : US4 = v533 |> Option.defaultValue v544 
    let v642 : System.DateTime =
        match v545 with
        | US4_1 -> (* None *)
            let v626 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v627 : System.DateTime = System.DateTime.Now
            let _v626 = v627 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v628 : System.DateTime = System.DateTime.Now
            let _v626 = v628 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v629 : System.DateTime = null |> unbox<System.DateTime>
            let _v626 = v629 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v632 : System.DateTime = System.DateTime.Now
            let _v626 = v632 
            #endif
#if FABLE_COMPILER_PYTHON
            let v633 : System.DateTime = System.DateTime.Now
            let _v626 = v633 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v634 : System.DateTime = System.DateTime.Now
            let _v626 = v634 
            #endif
#else
            let v635 : System.DateTime = System.DateTime.Now
            let _v626 = v635 
            #endif
            let v636 : System.DateTime = _v626 
            v636
        | US4_0(v549) -> (* Some *)
            let v550 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v551 : System.DateTime = System.DateTime.Now
            let _v550 = v551 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v552 : System.DateTime = System.DateTime.Now
            let _v550 = v552 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v553 : System.DateTime = null |> unbox<System.DateTime>
            let _v550 = v553 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v556 : System.DateTime = System.DateTime.Now
            let _v550 = v556 
            #endif
#if FABLE_COMPILER_PYTHON
            let v557 : System.DateTime = System.DateTime.Now
            let _v550 = v557 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v558 : System.DateTime = System.DateTime.Now
            let _v550 = v558 
            #endif
#else
            let v559 : System.DateTime = System.DateTime.Now
            let _v550 = v559 
            #endif
            let v560 : System.DateTime = _v550 
            let v565 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v566 : (System.DateTime -> int64) = _.Ticks
            let v567 : int64 = v566 v560
            let _v565 = v567 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v568 : (System.DateTime -> int64) = _.Ticks
            let v569 : int64 = v568 v560
            let _v565 = v569 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v570 : int64 = null |> unbox<int64>
            let _v565 = v570 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v573 : (System.DateTime -> int64) = _.Ticks
            let v574 : int64 = v573 v560
            let _v565 = v574 
            #endif
#if FABLE_COMPILER_PYTHON
            let v575 : (System.DateTime -> int64) = _.Ticks
            let v576 : int64 = v575 v560
            let _v565 = v576 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v577 : (System.DateTime -> int64) = _.Ticks
            let v578 : int64 = v577 v560
            let _v565 = v578 
            #endif
#else
            let v579 : (System.DateTime -> int64) = _.Ticks
            let v580 : int64 = v579 v560
            let _v565 = v580 
            #endif
            let v581 : int64 = _v565 
            let v598 : int64 = v581 |> int64 
            let v601 : int64 = v598 - v549
            let v602 : System.TimeSpan = v601 |> System.TimeSpan 
            let v607 : (System.TimeSpan -> int32) = _.Hours
            let v608 : int32 = v607 v602
            let v611 : (System.TimeSpan -> int32) = _.Minutes
            let v612 : int32 = v611 v602
            let v615 : (System.TimeSpan -> int32) = _.Seconds
            let v616 : int32 = v615 v602
            let v619 : (System.TimeSpan -> int32) = _.Milliseconds
            let v620 : int32 = v619 v602
            let v623 : System.DateTime = System.DateTime (1, 1, 1, v608, v612, v616, v620)
            v623
    let v643 : string = method12()
    let v646 : (string -> string) = v642.ToString
    let v647 : string = v646 v643
    let _v6 = v647 
    #endif
#else
    let v654 : (int64 -> US4) = method10()
    let v655 : US4 option = v5 |> Option.map v654 
    let v666 : US4 = US4_1
    let v667 : US4 = v655 |> Option.defaultValue v666 
    let v764 : System.DateTime =
        match v667 with
        | US4_1 -> (* None *)
            let v748 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v749 : System.DateTime = System.DateTime.Now
            let _v748 = v749 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v750 : System.DateTime = System.DateTime.Now
            let _v748 = v750 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v751 : System.DateTime = null |> unbox<System.DateTime>
            let _v748 = v751 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v754 : System.DateTime = System.DateTime.Now
            let _v748 = v754 
            #endif
#if FABLE_COMPILER_PYTHON
            let v755 : System.DateTime = System.DateTime.Now
            let _v748 = v755 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v756 : System.DateTime = System.DateTime.Now
            let _v748 = v756 
            #endif
#else
            let v757 : System.DateTime = System.DateTime.Now
            let _v748 = v757 
            #endif
            let v758 : System.DateTime = _v748 
            v758
        | US4_0(v671) -> (* Some *)
            let v672 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v673 : System.DateTime = System.DateTime.Now
            let _v672 = v673 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v674 : System.DateTime = System.DateTime.Now
            let _v672 = v674 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v675 : System.DateTime = null |> unbox<System.DateTime>
            let _v672 = v675 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v678 : System.DateTime = System.DateTime.Now
            let _v672 = v678 
            #endif
#if FABLE_COMPILER_PYTHON
            let v679 : System.DateTime = System.DateTime.Now
            let _v672 = v679 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v680 : System.DateTime = System.DateTime.Now
            let _v672 = v680 
            #endif
#else
            let v681 : System.DateTime = System.DateTime.Now
            let _v672 = v681 
            #endif
            let v682 : System.DateTime = _v672 
            let v687 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v688 : (System.DateTime -> int64) = _.Ticks
            let v689 : int64 = v688 v682
            let _v687 = v689 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v690 : (System.DateTime -> int64) = _.Ticks
            let v691 : int64 = v690 v682
            let _v687 = v691 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v692 : int64 = null |> unbox<int64>
            let _v687 = v692 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v695 : (System.DateTime -> int64) = _.Ticks
            let v696 : int64 = v695 v682
            let _v687 = v696 
            #endif
#if FABLE_COMPILER_PYTHON
            let v697 : (System.DateTime -> int64) = _.Ticks
            let v698 : int64 = v697 v682
            let _v687 = v698 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v699 : (System.DateTime -> int64) = _.Ticks
            let v700 : int64 = v699 v682
            let _v687 = v700 
            #endif
#else
            let v701 : (System.DateTime -> int64) = _.Ticks
            let v702 : int64 = v701 v682
            let _v687 = v702 
            #endif
            let v703 : int64 = _v687 
            let v720 : int64 = v703 |> int64 
            let v723 : int64 = v720 - v671
            let v724 : System.TimeSpan = v723 |> System.TimeSpan 
            let v729 : (System.TimeSpan -> int32) = _.Hours
            let v730 : int32 = v729 v724
            let v733 : (System.TimeSpan -> int32) = _.Minutes
            let v734 : int32 = v733 v724
            let v737 : (System.TimeSpan -> int32) = _.Seconds
            let v738 : int32 = v737 v724
            let v741 : (System.TimeSpan -> int32) = _.Milliseconds
            let v742 : int32 = v741 v724
            let v745 : System.DateTime = System.DateTime (1, 1, 1, v730, v734, v738, v742)
            v745
    let v765 : string = method12()
    let v768 : (string -> string) = v764.ToString
    let v769 : string = v768 v765
    let _v6 = v769 
    #endif
    let v776 : string = _v6 
    v776
and method15 () : string =
    let v0 : string = ""
    v0
and closure8 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method14 (v0 : char) : string =
    let v1 : string = method15()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure8(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method16 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method13 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
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
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method18 (v0 : (string [])) : string =
    let v1 : string = method15()
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
and method19 (v0 : string) : string =
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
and method17 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : (string [])) : string =
    let v9 : string = method18(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.main"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
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
and method20 (v0 : string) : unit =
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
and closure5 (v0 : (string [])) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method17(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method21 () : string =
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
    let v33 : char list = []
    let v34 : char list = '\\' :: v33 
    let v37 : (char list -> (char [])) = List.toArray
    let v38 : (char []) = v37 v34
    let v41 : string = v11.TrimEnd v38 
    v41
and method22 () : (std_string_String -> string) =
    closure12()
and method24 () : string =
    let v0 : string = "wasm"
    v0
and method26 (v0 : string) : string =
    let v1 : string = method15()
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
and method25 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method26(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
and closure13 (v0 : string) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method25(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method30 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v2 : near_workspaces_Contract) : string =
    let v3 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : string = $"%A{v1}"
    let _v66 = v85 
    #endif
#else
    let v88 : string = $"%A{v1}"
    let _v66 = v88 
    #endif
    let v91 : string = _v66 
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
    let _v129 = v133 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v134 : string = "format!(\"{:#?}\", $0)"
    let v135 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v134 
    let v136 : string = "fable_library_rust::String_::fromString($0)"
    let v137 : string = Fable.Core.RustInterop.emitRustExpr v135 v136 
    let _v129 = v137 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v138 : string = "format!(\"{:#?}\", $0)"
    let v139 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2 v138 
    let v140 : string = "fable_library_rust::String_::fromString($0)"
    let v141 : string = Fable.Core.RustInterop.emitRustExpr v139 v140 
    let _v129 = v141 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v142 : string = $"%A{v2}"
    let _v129 = v142 
    #endif
#if FABLE_COMPILER_PYTHON
    let v145 : string = $"%A{v2}"
    let _v129 = v145 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v148 : string = $"%A{v2}"
    let _v129 = v148 
    #endif
#else
    let v151 : string = $"%A{v2}"
    let _v129 = v151 
    #endif
    let v154 : string = _v129 
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
and method29 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v10 : near_workspaces_Contract) : string =
    let v11 : string = method30(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "spiral_wasm.run"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method19(v14)
and closure14 (v0 : uint8, v1 : near_workspaces_Worker<near_workspaces_network_Sandbox>, v2 : near_workspaces_Contract) () : unit =
    let v3 : US3 = US3_0
    let v4 : bool = method8(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method9(v21, v22, v23, v24, v25, v26)
        let v40 : string = method13()
        let v41 : string = method29(v21, v22, v23, v24, v25, v26, v39, v40, v0, v1, v2)
        method20(v41)
and method32 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) : string =
    let v2 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _v65 = v87 
    #endif
    let v90 : string = _v65 
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
and method31 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : near_workspaces_result_ExecutionFinalResult) : string =
    let v10 : string = method32(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
and closure15 (v0 : uint8, v1 : near_workspaces_result_ExecutionFinalResult) () : unit =
    let v2 : US3 = US3_0
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method13()
        let v40 : string = method31(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method20(v40)
and closure17 (v0 : std_string_String) () : unit =
    let v1 : (std_string_String -> unit) = System.Console.WriteLine
    v1 v0
and closure16 () (v0 : std_string_String) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure17(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method33 () : unit =
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
    let v121 : (string -> unit) = v17.l0
    v121 v39
and closure18 () () : unit =
    let v0 : US3 = US3_2
    let v1 : bool = method8(v0)
    if v1 then
        method33()
and method34 () : string =
    
    
    
    
    
    let v0 : string = "Info"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
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
    let v40 : string = "inline_colorization::color_bright_green"
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
    let v72 : string = "inline_colorization::color_bright_green"
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
    let v104 : string = "\u001b[92m"
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[92m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[92m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[92m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method36 (v0 : uint8, v1 : float, v2 : uint64) : string =
    let v3 : string = method15()
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
and method35 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : float, v10 : uint64) : string =
    let v11 : string = method36(v8, v9, v10)
    let v12 : int64 = v0.l0
    let v13 : string = "near_workspaces.print_usd"
    let v14 : string = $"{v6} {v7} #{v12} %s{v13} / {v11}"
    method19(v14)
and closure19 (v0 : uint8, v1 : uint64, v2 : float) () : unit =
    let v3 : US3 = US3_2
    let v4 : bool = method8(v3)
    if v4 then
        let v5 : unit = ()
        let v6 : (unit -> unit) = closure6()
        let v7 : unit = (fun () -> v6 (); v5) ()
        let struct (v21 : Mut0, v22 : Mut1, v23 : Mut2, v24 : Mut3, v25 : Mut4, v26 : int64 option) = TraceState.trace_state.Value
        let v39 : string = method9(v21, v22, v23, v24, v25, v26)
        let v40 : string = method34()
        let v41 : string = method35(v21, v22, v23, v24, v25, v26, v39, v40, v0, v2, v1)
        method20(v41)
and method38 (v0 : bool, v1 : float, v2 : float, v3 : uint64, v4 : u128) : string =
    let v5 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v189 : string = $"%A{v4}"
    let _v170 = v189 
    #endif
#else
    let v192 : string = $"%A{v4}"
    let _v170 = v192 
    #endif
    let v195 : string = _v170 
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
and method37 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : bool, v9 : float, v10 : float, v11 : uint64, v12 : u128) : string =
    let v13 : string = method38(v8, v9, v10, v11, v12)
    let v14 : int64 = v0.l0
    let v15 : string = "near_workspaces.print_usd / outcome"
    let v16 : string = $"{v6} {v7} #{v14} %s{v15} / {v13}"
    method19(v16)
and closure21 (v0 : bool, v1 : uint64, v2 : float, v3 : u128, v4 : float) () : unit =
    let v5 : US3 = US3_2
    let v6 : bool = method8(v5)
    if v6 then
        let v7 : unit = ()
        let v8 : (unit -> unit) = closure6()
        let v9 : unit = (fun () -> v8 (); v7) ()
        let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : Mut4, v28 : int64 option) = TraceState.trace_state.Value
        let v41 : string = method9(v23, v24, v25, v26, v27, v28)
        let v42 : string = method34()
        let v43 : string = method37(v23, v24, v25, v26, v27, v28, v41, v42, v0, v2, v4, v1, v3)
        method20(v43)
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
and method40 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
    let v1 : string = method15()
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
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method39 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) : string =
    let v9 : string = method40(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
and closure22 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method39(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method41 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method43 (v0 : int32, v1 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v2 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _v65 = v87 
    #endif
    let v90 : string = _v65 
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
and method42 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v10 : string = method43(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
and closure23 (v0 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>, v1 : int32) () : unit =
    let v2 : US3 = US3_0
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method13()
        let v40 : string = method42(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method20(v40)
and method44 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and method46 (v0 : int32, v1 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
    let v2 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _v65 = v87 
    #endif
    let v90 : string = _v65 
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
and method45 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : Vec<near_workspaces_result_ExecutionOutcome>) : string =
    let v10 : string = method46(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
and closure24 (v0 : Vec<near_workspaces_result_ExecutionOutcome>, v1 : int32) () : unit =
    let v2 : US3 = US3_0
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method13()
        let v40 : string = method45(v20, v21, v22, v23, v24, v25, v38, v39, v1, v0)
        method20(v40)
and method48 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v1 : string = method15()
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
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method47 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v9 : string = method48(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
and closure25 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method47(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method50 (v0 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v1 : string = method15()
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
    let v64 : (unit -> unit) = closure8(v2, v60)
    let v65 : unit = (fun () -> v64 (); v63) ()
    let v68 : string = " }"
    let v69 : string = $"{v68}"
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure8(v2, v69)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v77 : string = v2.l0
    v77
and method49 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : Result<std_string_String, near_workspaces_error_Error>) : string =
    let v9 : string = method50(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
and closure26 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method49(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method51 (v0 : int32, v1 : uint8, v2 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) : string =
    let v3 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v118 : string = $"%A{v2}"
    let _v99 = v118 
    #endif
#else
    let v121 : string = $"%A{v2}"
    let _v99 = v121 
    #endif
    let v124 : string = _v99 
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
and method52 (v0 : Result<US7, anyhow_Error>) : Result<US7, anyhow_Error> =
    v0
and method28 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US7, anyhow_Error>>>>> =
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v132 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v132 
    #endif
#else
    let v135 : std_string_String = v118 |> unbox<std_string_String>
    let _v119 = v135 
    #endif
    let v138 : std_string_String = _v119 
    let v143 : string = "true; $0 }).collect::<Vec<_>>()"
    let v144 : bool = Fable.Core.RustInterop.emitRustExpr v138 v143 
    let v145 : string = "_vec_map"
    let v146 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "true; $0.iter().for_each(|x| { $1(x.clone()); }); //"
    let v148 : (std_string_String -> unit) = closure16()
    let v149 : bool = Fable.Core.RustInterop.emitRustExpr struct (v146, v148) v147 
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure18()
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v155 : string = "$0.total_gas_burnt"
    let v156 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v70 v155 
    let v157 : string = "$0.as_gas()"
    let v158 : uint64 = Fable.Core.RustInterop.emitRustExpr v156 v157 
    let v159 : (uint64 -> float) = float
    let v160 : float = v159 v158
    let v163 : float = v160 / 10000000000000000.0
    let v164 : float = v163 * 6.68
    let v165 : unit = ()
    let v166 : (unit -> unit) = closure19(v1, v158, v164)
    let v167 : unit = (fun () -> v166 (); v165) ()
    let v207 : string = "$0"
    let v208 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v70 v207 
    let v209 : string = "v208.outcomes()"
    let v210 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v209 
    let v211 : string = "v210.into_iter()"
    let v212 : _ = Fable.Core.RustInterop.emitRustExpr () v211 
    let v213 : string = "v212.cloned()"
    let v214 : _ = Fable.Core.RustInterop.emitRustExpr () v213 
    let v215 : string = "true; v214.for_each(|x| $0(x))"
    let v216 : (near_workspaces_result_ExecutionOutcome -> unit) = closure20()
    let v217 : bool = Fable.Core.RustInterop.emitRustExpr v216 v215 
    let v218 : string = "$0.into_result()"
    let v219 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v70 v218 
    let v220 : unit = ()
    let v221 : (unit -> unit) = closure22(v219)
    let v222 : unit = (fun () -> v221 (); v220) ()
    let v262 : near_workspaces_result_ExecutionFinalResult = method41(v70)
    let v263 : string = "v262.receipt_failures()"
    let v264 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : string = "$0.len()"
    let v266 : unativeint = Fable.Core.RustInterop.emitRustExpr v264 v265 
    let v267 : int32 = v266 |> int32 
    let v274 : unit = ()
    let v275 : (unit -> unit) = closure23(v264, v267)
    let v276 : unit = (fun () -> v275 (); v274) ()
    let v316 : near_workspaces_result_ExecutionFinalResult = method44(v70)
    let v317 : string = "v316.receipt_outcomes()"
    let v318 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v317 
    let v319 : string = "v318.into()"
    let v320 : Vec<near_workspaces_result_ExecutionOutcome> = Fable.Core.RustInterop.emitRustExpr () v319 
    let v321 : string = "$0.len()"
    let v322 : unativeint = Fable.Core.RustInterop.emitRustExpr v320 v321 
    let v323 : int32 = v322 |> int32 
    let v330 : unit = ()
    let v331 : (unit -> unit) = closure24(v320, v323)
    let v332 : unit = (fun () -> v331 (); v330) ()
    let v372 : string = "$0.json()"
    let v373 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v70 v372 
    let v374 : unit = ()
    let v375 : (unit -> unit) = closure25(v373)
    let v376 : unit = (fun () -> v375 (); v374) ()
    let v416 : string = "$0.borsh()"
    let v417 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v70 v416 
    let v418 : unit = ()
    let v419 : (unit -> unit) = closure26(v417)
    let v420 : unit = (fun () -> v419 (); v418) ()
    let v460 : string = method51(v323, v1, v264)
    let v461 : bool = v267 > 0
    let v484 : Result<US7, anyhow_Error> =
        if v461 then
            let v462 : US7 = US7_0(v460)
            let v463 : Result<US7, anyhow_Error> = Ok v462 
            v463
        else
            let v464 : bool = v323 > 1
            if v464 then
                let v465 : US7 = US7_1
                let v466 : Result<US7, anyhow_Error> = Ok v465 
                v466
            else
                let v467 : string = "anyhow::anyhow!($0)"
                let v468 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v460 v467 
                let v469 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v470 : string = "Err($0)"
                let v471 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v468 v470 
                let _v469 = v471 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v472 : string = "Err($0)"
                let v473 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v468 v472 
                let _v469 = v473 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v474 : string = "Err($0)"
                let v475 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v468 v474 
                let _v469 = v475 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v476 : Result<US7, anyhow_Error> = v468 |> Error
                let _v469 = v476 
                #endif
#if FABLE_COMPILER_PYTHON
                let v477 : Result<US7, anyhow_Error> = v468 |> Error
                let _v469 = v477 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v478 : Result<US7, anyhow_Error> = v468 |> Error
                let _v469 = v478 
                #endif
#else
                let v479 : Result<US7, anyhow_Error> = v468 |> Error
                let _v469 = v479 
                #endif
                let v480 : Result<US7, anyhow_Error> = _v469 
                v480
    let v485 : Result<US7, anyhow_Error> = method52(v484)
    let v486 : string = ""
    let v487 : string = "}"
    let v488 : string = v486 + v487 
    let v489 : _ = v485 
    let v490 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v491 : string = $"true; let v489 = $0"
    let v492 : bool = Fable.Core.RustInterop.emitRustExpr v489 v491 
    let _v490 = v492 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v493 : string = $"true; let v489 = $0"
    let v494 : bool = Fable.Core.RustInterop.emitRustExpr v489 v493 
    let _v490 = v494 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v495 : string = $"true; let v489 = $0"
    let v496 : bool = Fable.Core.RustInterop.emitRustExpr v489 v495 
    let _v490 = v496 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v497 : bool = true
    let _v490 = v497 
    #endif
#if FABLE_COMPILER_PYTHON
    let v498 : bool = true
    let _v490 = v498 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v499 : bool = true
    let _v490 = v499 
    #endif
#else
    let v500 : bool = true
    let _v490 = v500 
    #endif
    let v501 : bool = _v490 
    let v504 : string = $"true; v489 " + v488 + "); " + v486 + " // rust.fix_closure'"
    let v505 : bool = Fable.Core.RustInterop.emitRustExpr () v504 
    let v506 : string = "__future_init"
    let v507 : _ = Fable.Core.RustInterop.emitRustExpr () v506 
    let v508 : string = "v507"
    let v509 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US7, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v508 
    v509
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
#else
    let v17 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v17 
    #endif
    let v20 : std_string_String = _v1 
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
    let v6 : string = method14(v5)
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
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method58 (v0 : uint8, v1 : std_string_String) : string =
    let v2 : string = method15()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v84 : string = $"%A{v1}"
    let _v65 = v84 
    #endif
#else
    let v87 : string = $"%A{v1}"
    let _v65 = v87 
    #endif
    let v90 : string = _v65 
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
    method19(v13)
and closure30 (v0 : uint8, v1 : std_string_String) () : unit =
    let v2 : US3 = US3_3
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method56()
        let v40 : string = method57(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method20(v40)
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _v53 = v66 
    #endif
#else
    let v69 : Ref<Str> = v52 |> unbox<Ref<Str>>
    let _v53 = v69 
    #endif
    let v72 : Ref<Str> = _v53 
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
and closure31 () () : unit =
    let v0 : US3 = US3_3
    let v1 : bool = method8(v0)
    if v1 then
        method59()
and method60 (v0 : uint8) : struct (uint8 * US7) =
    let v1 : US7 = US7_1
    struct (v0, v1)
and closure32 (v0 : uint8, v1 : std_string_String) () : unit =
    let v2 : US3 = US3_3
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method56()
        let v40 : string = method57(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method20(v40)
and closure33 () () : unit =
    let v0 : US3 = US3_3
    let v1 : bool = method8(v0)
    if v1 then
        method59()
and method61 () : string =
    
    
    
    
    
    let v0 : string = "Critical"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method14(v5)
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
    let v40 : string = "inline_colorization::color_bright_red"
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
    let v72 : string = "inline_colorization::color_bright_red"
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
    let v104 : string = "\u001b[91m"
    let v105 : string = method16()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method16()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method16()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method16()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method63 (v0 : uint8, v1 : string) : string =
    let v2 : string = method15()
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
and method62 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : string) : string =
    let v10 : string = method63(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "spiral_wasm.run / Ok (Some error)"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method19(v13)
and closure34 (v0 : uint8, v1 : string) () : unit =
    let v2 : US3 = US3_4
    let v3 : bool = method8(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method9(v20, v21, v22, v23, v24, v25)
        let v39 : string = method61()
        let v40 : string = method62(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method20(v40)
and method64 (v0 : uint8, v1 : string) : struct (uint8 * US7) =
    let v2 : US7 = US7_0(v1)
    struct (v0, v2)
and method65 (v0 : US8) : US8 =
    v0
and method27 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> =
    let v2 : string = "true; let __future_init = Box::pin(async move { //"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US7, anyhow_Error>>>>> = method28(v0, v1)
    let v5 : string = "v4.await"
    let v6 : Result<US7, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (anyhow_Error -> std_string_String) = method53()
    let v8 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.map_err(|x| $1(x))"
    let v10 : Result<US7, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v9 
    let _v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.map_err(|x| $1(x))"
    let v12 : Result<US7, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v11 
    let _v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<US7, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v13 
    let _v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Result<US7, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Result<US7, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Result<US7, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v17 
    #endif
#else
    let v18 : Result<US7, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v18 
    #endif
    let v19 : Result<US7, std_string_String> = _v8 
    let v22 : (US7 -> US9) = method54()
    let v23 : (std_string_String -> US9) = method55()
    let v24 : US9 = match v19 with Ok x -> v22 x | Error x -> v23 x
    let v269 : US8 =
        match v24 with
        | US9_1(v135) -> (* Error *)
            let v136 : bool = v1 >= 15uy
            if v136 then
                let v137 : unit = ()
                let v138 : (unit -> unit) = closure30(v1, v135)
                let v139 : unit = (fun () -> v138 (); v137) ()
                let v179 : unit = ()
                let v180 : (unit -> unit) = closure31()
                let v181 : unit = (fun () -> v180 (); v179) ()
                let v184 : string = "true; let __future_init = Box::pin(async move { //"
                let v185 : bool = Fable.Core.RustInterop.emitRustExpr () v184 
                let struct (v186 : uint8, v187 : US7) = method60(v1)
                let v188 : string = ""
                let v189 : string = "}"
                let v190 : string = v188 + v189 
                let v191 : _ = struct (v186, v187) 
                let v192 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v193 : string = $"true; let v191 = $0"
                let v194 : bool = Fable.Core.RustInterop.emitRustExpr v191 v193 
                let _v192 = v194 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v195 : string = $"true; let v191 = $0"
                let v196 : bool = Fable.Core.RustInterop.emitRustExpr v191 v195 
                let _v192 = v196 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v197 : string = $"true; let v191 = $0"
                let v198 : bool = Fable.Core.RustInterop.emitRustExpr v191 v197 
                let _v192 = v198 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v199 : bool = true
                let _v192 = v199 
                #endif
#if FABLE_COMPILER_PYTHON
                let v200 : bool = true
                let _v192 = v200 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v201 : bool = true
                let _v192 = v201 
                #endif
#else
                let v202 : bool = true
                let _v192 = v202 
                #endif
                let v203 : bool = _v192 
                let v206 : string = $"true; v191 " + v190 + "); " + v188 + " // rust.fix_closure'"
                let v207 : bool = Fable.Core.RustInterop.emitRustExpr () v206 
                let v208 : string = "__future_init"
                let v209 : _ = Fable.Core.RustInterop.emitRustExpr () v208 
                let v210 : string = "v209"
                let v211 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US7)>>>> = Fable.Core.RustInterop.emitRustExpr () v210 
                let v212 : string = "v211.await"
                let struct (v213 : uint8, v214 : US7) = Fable.Core.RustInterop.emitRustExpr () v212 
                US8_0(v213, v214)
            else
                let v216 : unit = ()
                let v217 : (unit -> unit) = closure32(v1, v135)
                let v218 : unit = (fun () -> v217 (); v216) ()
                let v258 : unit = ()
                let v259 : (unit -> unit) = closure33()
                let v260 : unit = (fun () -> v259 (); v258) ()
                let v263 : uint8 = v1 + 1uy
                let v264 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = method27(v0, v263)
                let v265 : string = "v264.await"
                let v266 : US8 = Fable.Core.RustInterop.emitRustExpr () v265 
                v266
        | US9_0(v25) -> (* Ok *)
            match v25 with
            | US7_1 -> (* None *)
                let v26 : string = "true; let __future_init = Box::pin(async move { //"
                let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
                let struct (v28 : uint8, v29 : US7) = method60(v1)
                let v30 : string = ""
                let v31 : string = "}"
                let v32 : string = v30 + v31 
                let v33 : _ = struct (v28, v29) 
                let v34 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v35 : string = $"true; let v33 = $0"
                let v36 : bool = Fable.Core.RustInterop.emitRustExpr v33 v35 
                let _v34 = v36 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v37 : string = $"true; let v33 = $0"
                let v38 : bool = Fable.Core.RustInterop.emitRustExpr v33 v37 
                let _v34 = v38 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v39 : string = $"true; let v33 = $0"
                let v40 : bool = Fable.Core.RustInterop.emitRustExpr v33 v39 
                let _v34 = v40 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v41 : bool = true
                let _v34 = v41 
                #endif
#if FABLE_COMPILER_PYTHON
                let v42 : bool = true
                let _v34 = v42 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v43 : bool = true
                let _v34 = v43 
                #endif
#else
                let v44 : bool = true
                let _v34 = v44 
                #endif
                let v45 : bool = _v34 
                let v48 : string = $"true; v33 " + v32 + "); " + v30 + " // rust.fix_closure'"
                let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
                let v50 : string = "__future_init"
                let v51 : _ = Fable.Core.RustInterop.emitRustExpr () v50 
                let v52 : string = "v51"
                let v53 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US7)>>>> = Fable.Core.RustInterop.emitRustExpr () v52 
                let v54 : string = "v53.await"
                let struct (v55 : uint8, v56 : US7) = Fable.Core.RustInterop.emitRustExpr () v54 
                US8_0(v55, v56)
            | US7_0(v58) -> (* Some *)
                let v59 : unit = ()
                let v60 : (unit -> unit) = closure34(v1, v58)
                let v61 : unit = (fun () -> v60 (); v59) ()
                let v101 : string = "true; let __future_init = Box::pin(async move { //"
                let v102 : bool = Fable.Core.RustInterop.emitRustExpr () v101 
                let struct (v103 : uint8, v104 : US7) = method64(v1, v58)
                let v105 : string = ""
                let v106 : string = "}"
                let v107 : string = v105 + v106 
                let v108 : _ = struct (v103, v104) 
                let v109 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v110 : string = $"true; let v108 = $0"
                let v111 : bool = Fable.Core.RustInterop.emitRustExpr v108 v110 
                let _v109 = v111 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v112 : string = $"true; let v108 = $0"
                let v113 : bool = Fable.Core.RustInterop.emitRustExpr v108 v112 
                let _v109 = v113 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v114 : string = $"true; let v108 = $0"
                let v115 : bool = Fable.Core.RustInterop.emitRustExpr v108 v114 
                let _v109 = v115 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v116 : bool = true
                let _v109 = v116 
                #endif
#if FABLE_COMPILER_PYTHON
                let v117 : bool = true
                let _v109 = v117 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v118 : bool = true
                let _v109 = v118 
                #endif
#else
                let v119 : bool = true
                let _v109 = v119 
                #endif
                let v120 : bool = _v109 
                let v123 : string = $"true; v108 " + v107 + "); " + v105 + " // rust.fix_closure'"
                let v124 : bool = Fable.Core.RustInterop.emitRustExpr () v123 
                let v125 : string = "__future_init"
                let v126 : _ = Fable.Core.RustInterop.emitRustExpr () v125 
                let v127 : string = "v126"
                let v128 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US7)>>>> = Fable.Core.RustInterop.emitRustExpr () v127 
                let v129 : string = "v128.await"
                let struct (v130 : uint8, v131 : US7) = Fable.Core.RustInterop.emitRustExpr () v129 
                US8_1(v130, v131)
    let v270 : US8 = method65(v269)
    let v271 : string = ""
    let v272 : string = "}"
    let v273 : string = v271 + v272 
    let v274 : _ = v270 
    let v275 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v276 : string = $"true; let v274 = $0"
    let v277 : bool = Fable.Core.RustInterop.emitRustExpr v274 v276 
    let _v275 = v277 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v278 : string = $"true; let v274 = $0"
    let v279 : bool = Fable.Core.RustInterop.emitRustExpr v274 v278 
    let _v275 = v279 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v280 : string = $"true; let v274 = $0"
    let v281 : bool = Fable.Core.RustInterop.emitRustExpr v274 v280 
    let _v275 = v281 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v282 : bool = true
    let _v275 = v282 
    #endif
#if FABLE_COMPILER_PYTHON
    let v283 : bool = true
    let _v275 = v283 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v284 : bool = true
    let _v275 = v284 
    #endif
#else
    let v285 : bool = true
    let _v275 = v285 
    #endif
    let v286 : bool = _v275 
    let v289 : string = $"true; v274 " + v273 + "); " + v271 + " // rust.fix_closure'"
    let v290 : bool = Fable.Core.RustInterop.emitRustExpr () v289 
    let v291 : string = "__future_init"
    let v292 : _ = Fable.Core.RustInterop.emitRustExpr () v291 
    let v293 : string = "v292"
    let v294 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = Fable.Core.RustInterop.emitRustExpr () v293 
    v294
and method67 (v0 : US8) : string =
    let v1 : string = method15()
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
and method66 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : US8) : string =
    let v9 : string = method67(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "spiral_wasm.run"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method19(v12)
and closure35 (v0 : US8) () : unit =
    let v1 : US3 = US3_0
    let v2 : bool = method8(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure6()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method9(v19, v20, v21, v22, v23, v24)
        let v38 : string = method13()
        let v39 : string = method66(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method20(v39)
and method68 (v0 : US8, v1 : US7) : string =
    let v2 : string = method15()
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
and method69 (v0 : Result<uint8, anyhow_Error>) : Result<uint8, anyhow_Error> =
    v0
and method23 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(async move { //"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = method24()
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Ref<Str> = v3 |> unbox<Ref<Str>>
    let _v4 = v17 
    #endif
#else
    let v20 : Ref<Str> = v3 |> unbox<Ref<Str>>
    let _v4 = v20 
    #endif
    let v23 : Ref<Str> = _v4 
    let v28 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v29 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v0, v23) v28 
    let v30 : (std_string_String -> US0) = method2()
    let v31 : US0 option = v29 |> Option.map v30 
    let v42 : US0 = US0_1
    let v43 : US0 = v31 |> Option.defaultValue v42 
    let v50 : std_string_String =
        match v43 with
        | US0_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US0_0(v47) -> (* Some *)
            v47
    let v51 : string = "fable_library_rust::String_::fromString($0)"
    let v52 : string = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : unit = ()
    let v54 : (unit -> unit) = closure13(v52)
    let v55 : unit = (fun () -> v54 (); v53) ()
    let v95 : string = "std::fs::read(&*$0)"
    let v96 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v52 v95 
    let v97 : string = "$0?"
    let v98 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : uint8 = 1uy
    let v100 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = method27(v98, v99)
    let v101 : string = "v100.await"
    let v102 : US8 = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure35(v102)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v168 : Result<uint8, anyhow_Error> =
        match v102 with
        | US8_1(v148, v149) -> (* Error *)
            let v150 : string = method68(v102, v149)
            let v151 : string = "anyhow::anyhow!($0)"
            let v152 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v150 v151 
            let v153 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v154 : string = "Err($0)"
            let v155 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v152 v154 
            let _v153 = v155 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v156 : string = "Err($0)"
            let v157 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v152 v156 
            let _v153 = v157 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v158 : string = "Err($0)"
            let v159 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v152 v158 
            let _v153 = v159 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v160 : Result<uint8, anyhow_Error> = v152 |> Error
            let _v153 = v160 
            #endif
#if FABLE_COMPILER_PYTHON
            let v161 : Result<uint8, anyhow_Error> = v152 |> Error
            let _v153 = v161 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v162 : Result<uint8, anyhow_Error> = v152 |> Error
            let _v153 = v162 
            #endif
#else
            let v163 : Result<uint8, anyhow_Error> = v152 |> Error
            let _v153 = v163 
            #endif
            let v164 : Result<uint8, anyhow_Error> = _v153 
            v164
        | US8_0(v145, v146) -> (* Ok *)
            let v147 : Result<uint8, anyhow_Error> = Ok v145 
            v147
    let v169 : Result<uint8, anyhow_Error> = method69(v168)
    let v170 : string = ""
    let v171 : string = "}"
    let v172 : string = v170 + v171 
    let v173 : _ = v169 
    let v174 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v175 : string = $"true; let v173 = $0"
    let v176 : bool = Fable.Core.RustInterop.emitRustExpr v173 v175 
    let _v174 = v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v177 : string = $"true; let v173 = $0"
    let v178 : bool = Fable.Core.RustInterop.emitRustExpr v173 v177 
    let _v174 = v178 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v179 : string = $"true; let v173 = $0"
    let v180 : bool = Fable.Core.RustInterop.emitRustExpr v173 v179 
    let _v174 = v180 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v181 : bool = true
    let _v174 = v181 
    #endif
#if FABLE_COMPILER_PYTHON
    let v182 : bool = true
    let _v174 = v182 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v183 : bool = true
    let _v174 = v183 
    #endif
#else
    let v184 : bool = true
    let _v174 = v184 
    #endif
    let v185 : bool = _v174 
    let v188 : string = $"true; v173 " + v172 + "); " + v170 + " // rust.fix_closure'"
    let v189 : bool = Fable.Core.RustInterop.emitRustExpr () v188 
    let v190 : string = "__future_init"
    let v191 : _ = Fable.Core.RustInterop.emitRustExpr () v190 
    let v192 : string = "v191"
    let v193 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v192 
    v193
and closure36 () (v0 : uint8) : US10 =
    US10_0(v0)
and method70 () : (uint8 -> US10) =
    closure36()
and closure37 () (v0 : std_string_String) : US10 =
    US10_1(v0)
and method71 () : (std_string_String -> US10) =
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _v5 = v18 
    #endif
#else
    let v21 : Ref<Str> = v4 |> unbox<Ref<Str>>
    let _v5 = v21 
    #endif
    let v24 : Ref<Str> = _v5 
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
    let v186 : string = method21()
    let v187 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v188 : string = "&*$0"
    let v189 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v188 
    let _v187 = v189 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v190 : string = "&*$0"
    let v191 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v190 
    let _v187 = v191 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v192 : string = "&*$0"
    let v193 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v186 v192 
    let _v187 = v193 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v194 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _v187 = v194 
    #endif
#if FABLE_COMPILER_PYTHON
    let v197 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _v187 = v197 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v200 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _v187 = v200 
    #endif
#else
    let v203 : Ref<Str> = v186 |> unbox<Ref<Str>>
    let _v187 = v203 
    #endif
    let v206 : Ref<Str> = _v187 
    let v211 : string = "clap::ArgMatches::get_one(&$0, $1).cloned()"
    let v212 : std_string_String option = Fable.Core.RustInterop.emitRustExpr struct (v3, v206) v211 
    let v213 : (std_string_String -> string) = method22()
    let v214 : string option = v212 |> Option.map v213 
    let v286 : (string -> US7) = method7()
    let v287 : US7 option = v214 |> Option.map v286 
    let v298 : US7 = US7_1
    let v299 : US7 = v287 |> Option.defaultValue v298 
    let v303 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = method23(v3)
    let v304 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v305 : _ = Fable.Core.RustInterop.emitRustExpr () v304 
    let v306 : string = "v305.handle().block_on($0)"
    let v307 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v303 v306 
    let v308 : (anyhow_Error -> std_string_String) = method53()
    let v309 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v310 : string = "$0.map_err(|x| $1(x))"
    let v311 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v307, v308) v310 
    let _v309 = v311 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v312 : string = "$0.map_err(|x| $1(x))"
    let v313 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v307, v308) v312 
    let _v309 = v313 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v314 : string = "$0.map_err(|x| $1(x))"
    let v315 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v307, v308) v314 
    let _v309 = v315 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v316 : Result<uint8, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
    let _v309 = v316 
    #endif
#if FABLE_COMPILER_PYTHON
    let v317 : Result<uint8, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
    let _v309 = v317 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v318 : Result<uint8, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
    let _v309 = v318 
    #endif
#else
    let v319 : Result<uint8, std_string_String> = match v307 with Ok x -> Ok x | Error x -> Error (v308 x)
    let _v309 = v319 
    #endif
    let v320 : Result<uint8, std_string_String> = _v309 
    let v323 : (uint8 -> US10) = method70()
    let v324 : (std_string_String -> US10) = method71()
    let v325 : US10 = match v320 with Ok x -> v323 x | Error x -> v324 x
    match v325 with
    | US10_1(v347) -> (* Error *)
        match v299 with
        | US7_0(v348) -> (* Some *)
            let v349 : bool = "" = v348
            if v349 then
                ()
            else
                let v350 : string = "fable_library_rust::String_::fromString($0)"
                let v351 : string = Fable.Core.RustInterop.emitRustExpr v347 v350 
                let v352 : bool = v351.Contains v348 
                if v352 then
                    ()
                else
                    let v355 : string = $"spiral_wasm.main / exception: '{v348}' / error: {v347}"
                    let v356 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v357 : string = "Err($0)"
                    let v358 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v355 v357 
                    let _v356 = v358 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v359 : string = "Err($0)"
                    let v360 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v355 v359 
                    let _v356 = v360 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v361 : string = "Err($0)"
                    let v362 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v355 v361 
                    let _v356 = v362 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v363 : Result<unit, string> = v355 |> Error
                    let _v356 = v363 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v364 : Result<unit, string> = v355 |> Error
                    let _v356 = v364 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v365 : Result<unit, string> = v355 |> Error
                    let _v356 = v365 
                    #endif
#else
                    let v366 : Result<unit, string> = v355 |> Error
                    let _v356 = v366 
                    #endif
                    let v367 : Result<unit, string> = _v356 
                    let v370 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v371 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v367 v371 
                    let _v370 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v372 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v367 v372 
                    let _v370 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v373 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v367 v373 
                    let _v370 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    match v367 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    match v367 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = () 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    match v367 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = () 
                    #endif
#else
                    match v367 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v370 = () 
                    #endif
                    _v370 
                    ()
        | _ ->
            let v374 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v375 : string = "$0.unwrap()"
            let v376 : uint8 = Fable.Core.RustInterop.emitRustExpr v320 v375 
            let _v374 = v376 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v377 : string = "$0.unwrap()"
            let v378 : uint8 = Fable.Core.RustInterop.emitRustExpr v320 v377 
            let _v374 = v378 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v379 : string = "$0.unwrap()"
            let v380 : uint8 = Fable.Core.RustInterop.emitRustExpr v320 v379 
            let _v374 = v380 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v381 : uint8 = match v320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v374 = v381 
            #endif
#if FABLE_COMPILER_PYTHON
            let v382 : uint8 = match v320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v374 = v382 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v383 : uint8 = match v320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v374 = v383 
            #endif
#else
            let v384 : uint8 = match v320 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v374 = v384 
            #endif
            let v385 : uint8 = _v374 
            ()
    | US10_0(v326) -> (* Ok *)
        match v299 with
        | US7_0(v327) -> (* Some *)
            let v328 : string = $"spiral_wasm.main / retries: {v326} / exception: '{v327}'"
            let v329 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v330 : string = "Err($0)"
            let v331 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v328 v330 
            let _v329 = v331 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v332 : string = "Err($0)"
            let v333 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v328 v332 
            let _v329 = v333 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v334 : string = "Err($0)"
            let v335 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v328 v334 
            let _v329 = v335 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v336 : Result<unit, string> = v328 |> Error
            let _v329 = v336 
            #endif
#if FABLE_COMPILER_PYTHON
            let v337 : Result<unit, string> = v328 |> Error
            let _v329 = v337 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v338 : Result<unit, string> = v328 |> Error
            let _v329 = v338 
            #endif
#else
            let v339 : Result<unit, string> = v328 |> Error
            let _v329 = v339 
            #endif
            let v340 : Result<unit, string> = _v329 
            let v343 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v344 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v340 v344 
            let _v343 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v345 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v340 v345 
            let _v343 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v346 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v340 v346 
            let _v343 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v340 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v343 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            match v340 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v343 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v340 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v343 = () 
            #endif
#else
            match v340 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v343 = () 
            #endif
            _v343 
            ()
        | _ ->
            ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
