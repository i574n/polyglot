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
    | US4_0 of f0_0 : string
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
    | US7_0 of f0_0 : int64
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : uint8 * f0_1 : US4
    | US8_1 of f1_0 : uint8 * f1_1 : US4
and [<Struct>] US9 =
    | US9_0 of f0_0 : US4
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : US5 = US5_1
    let v86 : US6 = US6_0(v85)
    let v87 : string = $"env.get_environment_variable / target: {v86} / var: {v0}"
    let v88 : string = failwith<string> v87
    let _v1 = v88 
    #endif
#else
    let v89 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v90 : string = v89 v0
    let mutable _v90 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v91 : (string -> string option) = Option.ofObj
    let v92 : string option = v91 v90
    v92 
    #else
    Some v90 
    #endif
    |> fun x -> _v90 <- Some x
    let v93 : string option = match _v90 with Some x -> x | None -> failwith "optionm'.of_obj / _v90=None"
    let v96 : (string -> US4) = method7()
    let v97 : US4 option = v93 |> Option.map v96 
    let v108 : US4 = US4_1
    let v109 : US4 = v97 |> Option.defaultValue v108 
    let v116 : string =
        match v109 with
        | US4_1 -> (* None *)
            let v114 : string = ""
            v114
        | US4_0(v113) -> (* Some *)
            v113
    let _v1 = v116 
    #endif
    let v117 : string = _v1 
    v117
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
    let v62 : US7 =
        if v52 then
            let v53 : System.DateTime = System.DateTime.Now
            let v56 : (System.DateTime -> int64) = _.Ticks
            let v57 : int64 = v56 v53
            US7_0(v57)
        else
            US7_1
    let _v1 = struct (v49, v62) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : US2 = US2_1
    let v64 : US7 = US7_1
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v82 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v82 
    #endif
#else
    let v85 : std_string_String = v68 |> unbox<std_string_String>
    let _v69 = v85 
    #endif
    let v88 : std_string_String = _v69 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v88 v93 
    let _v66 = v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = "env!(\"" + v65 + "\")"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v98 : string = "String::from($0)"
    let v99 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v98 
    let _v97 = v99 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v100 : string = "String::from($0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v100 
    let _v97 = v101 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v102 : string = "String::from($0)"
    let v103 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v102 
    let _v97 = v103 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v104 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v104 
    #endif
#if FABLE_COMPILER_PYTHON
    let v107 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v107 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v110 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v110 
    #endif
#else
    let v113 : std_string_String = v96 |> unbox<std_string_String>
    let _v97 = v113 
    #endif
    let v116 : std_string_String = _v97 
    let v121 : string = "fable_library_rust::String_::fromString($0)"
    let v122 : string = Fable.Core.RustInterop.emitRustExpr v116 v121 
    let _v66 = v122 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v123 : string = "env!(\"" + v65 + "\")"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v123 
    let v125 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v126 : string = "String::from($0)"
    let v127 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v126 
    let _v125 = v127 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v128 : string = "String::from($0)"
    let v129 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v128 
    let _v125 = v129 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v130 : string = "String::from($0)"
    let v131 : std_string_String = Fable.Core.RustInterop.emitRustExpr v124 v130 
    let _v125 = v131 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v132 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v132 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v135 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v138 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v138 
    #endif
#else
    let v141 : std_string_String = v124 |> unbox<std_string_String>
    let _v125 = v141 
    #endif
    let v144 : std_string_String = _v125 
    let v149 : string = "fable_library_rust::String_::fromString($0)"
    let v150 : string = Fable.Core.RustInterop.emitRustExpr v144 v149 
    let _v66 = v150 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v151 : string = null |> unbox<string>
    let _v66 = v151 
    #endif
#if FABLE_COMPILER_PYTHON
    let v154 : string = null |> unbox<string>
    let _v66 = v154 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v157 : string = null |> unbox<string>
    let _v66 = v157 
    #endif
#else
    let v160 : string = null |> unbox<string>
    let _v66 = v160 
    #endif
    let v163 : string = _v66 
    let v168 : string = "True"
    let v169 : bool = v163 <> v168 
    let v178 : US7 =
        if v169 then
            US7_1
        else
            let v173 : string = $"near_sdk::env::block_timestamp()"
            let v174 : uint64 = Fable.Core.RustInterop.emitRustExpr () v173 
            let v175 : (uint64 -> int64) = int64
            let v176 : int64 = v175 v174
            US7_0(v176)
    let v179 : US2 = US2_1
    let _v1 = struct (v179, v178) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v180 : string = method4()
    let v181 : string = method5(v180)
    
    
    
    
    
    let v182 : bool = "Verbose" = v181
    let v186 : US2 =
        if v182 then
            let v183 : US3 = US3_0
            US2_0(v183)
        else
            US2_1
    let v227 : US2 =
        match v186 with
        | US2_1 -> (* None *)
            let v189 : bool = "Debug" = v181
            let v193 : US2 =
                if v189 then
                    let v190 : US3 = US3_1
                    US2_0(v190)
                else
                    US2_1
            match v193 with
            | US2_1 -> (* None *)
                let v196 : bool = "Info" = v181
                let v200 : US2 =
                    if v196 then
                        let v197 : US3 = US3_2
                        US2_0(v197)
                    else
                        US2_1
                match v200 with
                | US2_1 -> (* None *)
                    let v203 : bool = "Warning" = v181
                    let v207 : US2 =
                        if v203 then
                            let v204 : US3 = US3_3
                            US2_0(v204)
                        else
                            US2_1
                    match v207 with
                    | US2_1 -> (* None *)
                        let v210 : bool = "Critical" = v181
                        let v214 : US2 =
                            if v210 then
                                let v211 : US3 = US3_4
                                US2_0(v211)
                            else
                                US2_1
                        match v214 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v215) -> (* Some *)
                            US2_0(v215)
                    | US2_0(v208) -> (* Some *)
                        US2_0(v208)
                | US2_0(v201) -> (* Some *)
                    US2_0(v201)
            | US2_0(v194) -> (* Some *)
                US2_0(v194)
        | US2_0(v187) -> (* Some *)
            US2_0(v187)
    let v228 : string = method8()
    let v229 : string = method5(v228)
    let v230 : bool = v229 = "True"
    let v240 : US7 =
        if v230 then
            let v231 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v231
            US7_0(v235)
        else
            US7_1
    let _v1 = struct (v227, v240) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : string = method4()
    let v242 : string = method5(v241)
    
    
    
    
    
    let v243 : bool = "Verbose" = v242
    let v247 : US2 =
        if v243 then
            let v244 : US3 = US3_0
            US2_0(v244)
        else
            US2_1
    let v288 : US2 =
        match v247 with
        | US2_1 -> (* None *)
            let v250 : bool = "Debug" = v242
            let v254 : US2 =
                if v250 then
                    let v251 : US3 = US3_1
                    US2_0(v251)
                else
                    US2_1
            match v254 with
            | US2_1 -> (* None *)
                let v257 : bool = "Info" = v242
                let v261 : US2 =
                    if v257 then
                        let v258 : US3 = US3_2
                        US2_0(v258)
                    else
                        US2_1
                match v261 with
                | US2_1 -> (* None *)
                    let v264 : bool = "Warning" = v242
                    let v268 : US2 =
                        if v264 then
                            let v265 : US3 = US3_3
                            US2_0(v265)
                        else
                            US2_1
                    match v268 with
                    | US2_1 -> (* None *)
                        let v271 : bool = "Critical" = v242
                        let v275 : US2 =
                            if v271 then
                                let v272 : US3 = US3_4
                                US2_0(v272)
                            else
                                US2_1
                        match v275 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v276) -> (* Some *)
                            US2_0(v276)
                    | US2_0(v269) -> (* Some *)
                        US2_0(v269)
                | US2_0(v262) -> (* Some *)
                    US2_0(v262)
            | US2_0(v255) -> (* Some *)
                US2_0(v255)
        | US2_0(v248) -> (* Some *)
            US2_0(v248)
    let v289 : string = method8()
    let v290 : string = method5(v289)
    let v291 : bool = v290 = "True"
    let v301 : US7 =
        if v291 then
            let v292 : System.DateTime = System.DateTime.Now
            let v295 : (System.DateTime -> int64) = _.Ticks
            let v296 : int64 = v295 v292
            US7_0(v296)
        else
            US7_1
    let _v1 = struct (v288, v301) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v302 : string = method4()
    let v303 : string = method5(v302)
    
    
    
    
    
    let v304 : bool = "Verbose" = v303
    let v308 : US2 =
        if v304 then
            let v305 : US3 = US3_0
            US2_0(v305)
        else
            US2_1
    let v349 : US2 =
        match v308 with
        | US2_1 -> (* None *)
            let v311 : bool = "Debug" = v303
            let v315 : US2 =
                if v311 then
                    let v312 : US3 = US3_1
                    US2_0(v312)
                else
                    US2_1
            match v315 with
            | US2_1 -> (* None *)
                let v318 : bool = "Info" = v303
                let v322 : US2 =
                    if v318 then
                        let v319 : US3 = US3_2
                        US2_0(v319)
                    else
                        US2_1
                match v322 with
                | US2_1 -> (* None *)
                    let v325 : bool = "Warning" = v303
                    let v329 : US2 =
                        if v325 then
                            let v326 : US3 = US3_3
                            US2_0(v326)
                        else
                            US2_1
                    match v329 with
                    | US2_1 -> (* None *)
                        let v332 : bool = "Critical" = v303
                        let v336 : US2 =
                            if v332 then
                                let v333 : US3 = US3_4
                                US2_0(v333)
                            else
                                US2_1
                        match v336 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v337) -> (* Some *)
                            US2_0(v337)
                    | US2_0(v330) -> (* Some *)
                        US2_0(v330)
                | US2_0(v323) -> (* Some *)
                    US2_0(v323)
            | US2_0(v316) -> (* Some *)
                US2_0(v316)
        | US2_0(v309) -> (* Some *)
            US2_0(v309)
    let v350 : string = method8()
    let v351 : string = method5(v350)
    let v352 : bool = v351 = "True"
    let v362 : US7 =
        if v352 then
            let v353 : System.DateTime = System.DateTime.Now
            let v356 : (System.DateTime -> int64) = _.Ticks
            let v357 : int64 = v356 v353
            US7_0(v357)
        else
            US7_1
    let _v1 = struct (v349, v362) 
    #endif
#else
    let v363 : string = method4()
    let v364 : string = method5(v363)
    
    
    
    
    
    let v365 : bool = "Verbose" = v364
    let v369 : US2 =
        if v365 then
            let v366 : US3 = US3_0
            US2_0(v366)
        else
            US2_1
    let v410 : US2 =
        match v369 with
        | US2_1 -> (* None *)
            let v372 : bool = "Debug" = v364
            let v376 : US2 =
                if v372 then
                    let v373 : US3 = US3_1
                    US2_0(v373)
                else
                    US2_1
            match v376 with
            | US2_1 -> (* None *)
                let v379 : bool = "Info" = v364
                let v383 : US2 =
                    if v379 then
                        let v380 : US3 = US3_2
                        US2_0(v380)
                    else
                        US2_1
                match v383 with
                | US2_1 -> (* None *)
                    let v386 : bool = "Warning" = v364
                    let v390 : US2 =
                        if v386 then
                            let v387 : US3 = US3_3
                            US2_0(v387)
                        else
                            US2_1
                    match v390 with
                    | US2_1 -> (* None *)
                        let v393 : bool = "Critical" = v364
                        let v397 : US2 =
                            if v393 then
                                let v394 : US3 = US3_4
                                US2_0(v394)
                            else
                                US2_1
                        match v397 with
                        | US2_1 -> (* None *)
                            US2_1
                        | US2_0(v398) -> (* Some *)
                            US2_0(v398)
                    | US2_0(v391) -> (* Some *)
                        US2_0(v391)
                | US2_0(v384) -> (* Some *)
                    US2_0(v384)
            | US2_0(v377) -> (* Some *)
                US2_0(v377)
        | US2_0(v370) -> (* Some *)
            US2_0(v370)
    let v411 : string = method8()
    let v412 : string = method5(v411)
    let v413 : bool = v412 = "True"
    let v423 : US7 =
        if v413 then
            let v414 : System.DateTime = System.DateTime.Now
            let v417 : (System.DateTime -> int64) = _.Ticks
            let v418 : int64 = v417 v414
            US7_0(v418)
        else
            US7_1
    let _v1 = struct (v410, v423) 
    #endif
    let struct (v424 : US2, v425 : US7) = _v1 
    let v489 : Mut0 = {l0 = 1L} : Mut0
    let v490 : (string -> unit) = closure4()
    let v491 : Mut1 = {l0 = v490} : Mut1
    let v492 : Mut2 = {l0 = true} : Mut2
    let v493 : string = ""
    let v494 : Mut3 = {l0 = v493} : Mut3
    let v497 : US3 =
        match v424 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v495) -> (* Some *)
            v495
    let v498 : Mut4 = {l0 = v497} : Mut4
    let v505 : int64 option =
        match v425 with
        | US7_1 -> (* None *)
            let v503 : int64 option = None
            v503
        | US7_0(v499) -> (* Some *)
            let v500 : int64 option = Some v499 
            v500
    struct (v489, v491, v492, v494, v498, v505)
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
and closure7 () (v0 : int64) : US7 =
    US7_0(v0)
and method11 () : (int64 -> US7) =
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
    let v7 : (int64 -> US7) = method11()
    let v8 : US7 option = v5 |> Option.map v7 
    let v19 : US7 = US7_1
    let v20 : US7 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US7_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US7_0(v24) -> (* Some *)
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
    let v68 : (int64 -> US7) = method11()
    let v69 : US7 option = v5 |> Option.map v68 
    let v80 : US7 = US7_1
    let v81 : US7 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US7_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US7_0(v85) -> (* Some *)
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
    let v131 : (int64 -> US7) = method11()
    let v132 : US7 option = v5 |> Option.map v131 
    let v143 : US7 = US7_1
    let v144 : US7 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US7_1 -> (* None *)
            v130
        | US7_0(v148) -> (* Some *)
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
    let v164 : (int64 -> US7) = method11()
    let v165 : US7 option = v5 |> Option.map v164 
    let v176 : US7 = US7_1
    let v177 : US7 = v165 |> Option.defaultValue v176 
    let v217 : System.DateTime =
        match v177 with
        | US7_1 -> (* None *)
            let v213 : System.DateTime = System.DateTime.Now
            v213
        | US7_0(v181) -> (* Some *)
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
    let v225 : (int64 -> US7) = method11()
    let v226 : US7 option = v5 |> Option.map v225 
    let v237 : US7 = US7_1
    let v238 : US7 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US7_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US7_0(v242) -> (* Some *)
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v286 : (int64 -> US7) = method11()
    let v287 : US7 option = v5 |> Option.map v286 
    let v298 : US7 = US7_1
    let v299 : US7 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US7_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US7_0(v303) -> (* Some *)
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
#else
    let v347 : (int64 -> US7) = method11()
    let v348 : US7 option = v5 |> Option.map v347 
    let v359 : US7 = US7_1
    let v360 : US7 = v348 |> Option.defaultValue v359 
    let v400 : System.DateTime =
        match v360 with
        | US7_1 -> (* None *)
            let v396 : System.DateTime = System.DateTime.Now
            v396
        | US7_0(v364) -> (* Some *)
            let v365 : System.DateTime = System.DateTime.Now
            let v368 : (System.DateTime -> int64) = _.Ticks
            let v369 : int64 = v368 v365
            let v372 : int64 = v369 - v364
            let v373 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v374 : System.TimeSpan = v373 v372
            let v377 : (System.TimeSpan -> int32) = _.Hours
            let v378 : int32 = v377 v374
            let v381 : (System.TimeSpan -> int32) = _.Minutes
            let v382 : int32 = v381 v374
            let v385 : (System.TimeSpan -> int32) = _.Seconds
            let v386 : int32 = v385 v374
            let v389 : (System.TimeSpan -> int32) = _.Milliseconds
            let v390 : int32 = v389 v374
            let v393 : System.DateTime = System.DateTime (1, 1, 1, v378, v382, v386, v390)
            v393
    let v401 : string = method13()
    let v404 : (string -> string) = v400.ToString
    let v405 : string = v404 v401
    let _v6 = v405 
    #endif
    let v408 : string = _v6 
    v408
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
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
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
    let v98 : (unativeint -> int32) = int32
    let v99 : int32 = v98 v97
    let v100 : string = ""
    let v101 : bool = v0 <> v100 
    let v105 : bool =
        if v101 then
            let v104 : bool = v99 <= 1
            v104
        else
            false
    if v105 then
        v20.l0 <- v53
        ()
    else
        v20.l0 <- v100
        let v106 : string = "true; $0.into_iter().for_each(|x| { //"
        let v107 : bool = Fable.Core.RustInterop.emitRustExpr v95 v106 
        let v108 : string = "x"
        let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v108 
        let v110 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr v109 v110 
        let v112 : string = $"true"
        let v113 : bool = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "true; }); //"
        let v115 : bool = Fable.Core.RustInterop.emitRustExpr () v114 
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
    let v116 : (string -> unit) = v18.l0
    v116 v0
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
    let v98 : (unativeint -> int32) = int32
    let v99 : int32 = v98 v97
    let v100 : string = ""
    let v101 : bool = v39 <> v100 
    let v105 : bool =
        if v101 then
            let v104 : bool = v99 <= 1
            v104
        else
            false
    if v105 then
        v19.l0 <- v53
        ()
    else
        v19.l0 <- v100
        let v106 : string = "true; $0.into_iter().for_each(|x| { //"
        let v107 : bool = Fable.Core.RustInterop.emitRustExpr v95 v106 
        let v108 : string = "x"
        let v109 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v108 
        let v110 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v111 : bool = Fable.Core.RustInterop.emitRustExpr v109 v110 
        let v112 : string = $"true"
        let v113 : bool = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "true; }); //"
        let v115 : bool = Fable.Core.RustInterop.emitRustExpr () v114 
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
    let v116 : (string -> unit) = v17.l0
    v116 v39
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
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[92m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[92m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[92m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
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
and method53 (v0 : Result<US4, anyhow_Error>) : Result<US4, anyhow_Error> =
    v0
and method29 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> =
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
    let v161 : float = v160 / 10000000000000000.0
    let v162 : float = v161 * 6.68
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure19(v1, v158, v162)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v205 : string = "$0"
    let v206 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v70 v205 
    let v207 : string = "v206.outcomes()"
    let v208 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v207 
    let v209 : string = "v208.into_iter()"
    let v210 : _ = Fable.Core.RustInterop.emitRustExpr () v209 
    let v211 : string = "v210.cloned()"
    let v212 : _ = Fable.Core.RustInterop.emitRustExpr () v211 
    let v213 : string = "true; v212.for_each(|x| $0(x))"
    let v214 : (near_workspaces_result_ExecutionOutcome -> unit) = closure20()
    let v215 : bool = Fable.Core.RustInterop.emitRustExpr v214 v213 
    let v216 : string = "$0.into_result()"
    let v217 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v70 v216 
    let v218 : unit = ()
    let v219 : (unit -> unit) = closure22(v217)
    let v220 : unit = (fun () -> v219 (); v218) ()
    let v260 : near_workspaces_result_ExecutionFinalResult = method42(v70)
    let v261 : string = "v260.receipt_failures()"
    let v262 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "$0.len()"
    let v264 : unativeint = Fable.Core.RustInterop.emitRustExpr v262 v263 
    let v265 : (unativeint -> int32) = int32
    let v266 : int32 = v265 v264
    let v267 : unit = ()
    let v268 : (unit -> unit) = closure23(v262, v266)
    let v269 : unit = (fun () -> v268 (); v267) ()
    let v309 : near_workspaces_result_ExecutionFinalResult = method45(v70)
    let v310 : string = "v309.receipt_outcomes()"
    let v311 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v310 
    let v312 : string = "v311.into()"
    let v313 : Vec<near_workspaces_result_ExecutionOutcome> = Fable.Core.RustInterop.emitRustExpr () v312 
    let v314 : string = "$0.len()"
    let v315 : unativeint = Fable.Core.RustInterop.emitRustExpr v313 v314 
    let v316 : (unativeint -> int32) = int32
    let v317 : int32 = v316 v315
    let v318 : unit = ()
    let v319 : (unit -> unit) = closure24(v313, v317)
    let v320 : unit = (fun () -> v319 (); v318) ()
    let v360 : string = "$0.json()"
    let v361 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v70 v360 
    let v362 : unit = ()
    let v363 : (unit -> unit) = closure25(v361)
    let v364 : unit = (fun () -> v363 (); v362) ()
    let v404 : string = "$0.borsh()"
    let v405 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v70 v404 
    let v406 : unit = ()
    let v407 : (unit -> unit) = closure26(v405)
    let v408 : unit = (fun () -> v407 (); v406) ()
    let v448 : string = method52(v317, v1, v262)
    let v449 : bool = v266 > 0
    let v472 : Result<US4, anyhow_Error> =
        if v449 then
            let v450 : US4 = US4_0(v448)
            let v451 : Result<US4, anyhow_Error> = Ok v450 
            v451
        else
            let v452 : bool = v317 > 1
            if v452 then
                let v453 : US4 = US4_1
                let v454 : Result<US4, anyhow_Error> = Ok v453 
                v454
            else
                let v455 : string = "anyhow::anyhow!($0)"
                let v456 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v448 v455 
                let v457 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v458 : string = "Err($0)"
                let v459 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v456 v458 
                let _v457 = v459 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v460 : string = "Err($0)"
                let v461 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v456 v460 
                let _v457 = v461 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v462 : string = "Err($0)"
                let v463 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v456 v462 
                let _v457 = v463 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v464 : Result<US4, anyhow_Error> = v456 |> Error
                let _v457 = v464 
                #endif
#if FABLE_COMPILER_PYTHON
                let v465 : Result<US4, anyhow_Error> = v456 |> Error
                let _v457 = v465 
                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                let v466 : Result<US4, anyhow_Error> = v456 |> Error
                let _v457 = v466 
                #endif
#else
                let v467 : Result<US4, anyhow_Error> = v456 |> Error
                let _v457 = v467 
                #endif
                let v468 : Result<US4, anyhow_Error> = _v457 
                v468
    let v473 : Result<US4, anyhow_Error> = method53(v472)
    let v474 : string = ""
    let v475 : string = "}"
    let v476 : string = v474 + v475 
    let v477 : _ = v473 
    let v478 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v479 : string = $"true; let v477 = $0"
    let v480 : bool = Fable.Core.RustInterop.emitRustExpr v477 v479 
    let _v478 = v480 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v481 : string = $"true; let v477 = $0"
    let v482 : bool = Fable.Core.RustInterop.emitRustExpr v477 v481 
    let _v478 = v482 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v483 : string = $"true; let v477 = $0"
    let v484 : bool = Fable.Core.RustInterop.emitRustExpr v477 v483 
    let _v478 = v484 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v485 : bool = true
    let _v478 = v485 
    #endif
#if FABLE_COMPILER_PYTHON
    let v486 : bool = true
    let _v478 = v486 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v487 : bool = true
    let _v478 = v487 
    #endif
#else
    let v488 : bool = true
    let _v478 = v488 
    #endif
    let v489 : bool = _v478 
    let v492 : string = $"true; v477 " + v476 + "); " + v474 + " // rust.fix_closure'"
    let v493 : bool = Fable.Core.RustInterop.emitRustExpr () v492 
    let v494 : string = "__future_init"
    let v495 : _ = Fable.Core.RustInterop.emitRustExpr () v494 
    let v496 : string = "v495"
    let v497 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v496 
    v497
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
and method54 () : (anyhow_Error -> std_string_String) =
    closure27()
and closure28 () (v0 : US4) : US9 =
    US9_0(v0)
and closure29 () (v0 : std_string_String) : US9 =
    US9_1(v0)
and method55 () : string =
    
    
    
    
    
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
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method57 (v0 : uint8, v1 : std_string_String) : string =
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
and method56 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : uint8, v9 : std_string_String) : string =
    let v10 : string = method57(v8, v9)
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
        let v39 : string = method55()
        let v40 : string = method56(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and method58 () : unit =
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
    let v97 : (unativeint -> int32) = int32
    let v98 : int32 = v97 v96
    let v99 : string = ""
    let v100 : bool = v39 <> v99 
    let v104 : bool =
        if v100 then
            let v103 : bool = v98 <= 1
            v103
        else
            false
    if v104 then
        v19.l0 <- v52
        ()
    else
        v19.l0 <- v99
        let v105 : string = "true; $0.into_iter().for_each(|x| { //"
        let v106 : bool = Fable.Core.RustInterop.emitRustExpr v94 v105 
        let v107 : string = "x"
        let v108 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v107 
        let v109 : string = $"true; near_sdk::log!(\"{{}}\", $0)"
        let v110 : bool = Fable.Core.RustInterop.emitRustExpr v108 v109 
        let v111 : string = $"true"
        let v112 : bool = Fable.Core.RustInterop.emitRustExpr () v111 
        let v113 : string = "true; }); //"
        let v114 : bool = Fable.Core.RustInterop.emitRustExpr () v113 
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
    let v115 : (string -> unit) = v17.l0
    v115 v39
and closure31 () () : unit =
    let v0 : US3 = US3_3
    let v1 : bool = method9(v0)
    if v1 then
        method58()
and method59 (v0 : uint8) : struct (uint8 * US4) =
    let v1 : US4 = US4_1
    struct (v0, v1)
and closure32 (v0 : uint8, v1 : std_string_String) () : unit =
    let v2 : US3 = US3_3
    let v3 : bool = method9(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure6()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method10(v20, v21, v22, v23, v24, v25)
        let v39 : string = method55()
        let v40 : string = method56(v20, v21, v22, v23, v24, v25, v38, v39, v0, v1)
        method21(v40)
and closure33 () () : unit =
    let v0 : US3 = US3_3
    let v1 : bool = method9(v0)
    if v1 then
        method58()
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
    let v105 : string = method17()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[91m"
    let v109 : string = method17()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[91m"
    let v113 : string = method17()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[91m"
    let v117 : string = method17()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
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
and method63 (v0 : uint8, v1 : string) : struct (uint8 * US4) =
    let v2 : US4 = US4_0(v1)
    struct (v0, v2)
and method64 (v0 : US8) : US8 =
    v0
and method28 (v0 : Vec<uint8>, v1 : uint8) : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> =
    let v2 : string = "true; let __future_init = Box::pin(async move { //"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2 
    let v4 : std_pin_Pin<Box<Dyn<std_future_Future<Result<US4, anyhow_Error>>>>> = method29(v0, v1)
    let v5 : string = "v4.await"
    let v6 : Result<US4, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v5 
    let v7 : (anyhow_Error -> std_string_String) = method54()
    let v8 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.map_err(|x| $1(x))"
    let v10 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v9 
    let _v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.map_err(|x| $1(x))"
    let v12 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v11 
    let _v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.map_err(|x| $1(x))"
    let v14 : Result<US4, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v6, v7) v13 
    let _v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : Result<US4, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : Result<US4, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Result<US4, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v17 
    #endif
#else
    let v18 : Result<US4, std_string_String> = match v6 with Ok x -> Ok x | Error x -> Error (v7 x)
    let _v8 = v18 
    #endif
    let v19 : Result<US4, std_string_String> = _v8 
    let v22 : (US4 -> US9) = closure28()
    let v23 : (std_string_String -> US9) = closure29()
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
                let struct (v186 : uint8, v187 : US4) = method59(v1)
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
                let v211 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US4)>>>> = Fable.Core.RustInterop.emitRustExpr () v210 
                let v212 : string = "v211.await"
                let struct (v213 : uint8, v214 : US4) = Fable.Core.RustInterop.emitRustExpr () v212 
                US8_0(v213, v214)
            else
                let v216 : unit = ()
                let v217 : (unit -> unit) = closure32(v1, v135)
                let v218 : unit = (fun () -> v217 (); v216) ()
                let v258 : unit = ()
                let v259 : (unit -> unit) = closure33()
                let v260 : unit = (fun () -> v259 (); v258) ()
                let v263 : uint8 = v1 + 1uy
                let v264 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = method28(v0, v263)
                let v265 : string = "v264.await"
                let v266 : US8 = Fable.Core.RustInterop.emitRustExpr () v265 
                v266
        | US9_0(v25) -> (* Ok *)
            match v25 with
            | US4_1 -> (* None *)
                let v26 : string = "true; let __future_init = Box::pin(async move { //"
                let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
                let struct (v28 : uint8, v29 : US4) = method59(v1)
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
                let v53 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US4)>>>> = Fable.Core.RustInterop.emitRustExpr () v52 
                let v54 : string = "v53.await"
                let struct (v55 : uint8, v56 : US4) = Fable.Core.RustInterop.emitRustExpr () v54 
                US8_0(v55, v56)
            | US4_0(v58) -> (* Some *)
                let v59 : unit = ()
                let v60 : (unit -> unit) = closure34(v1, v58)
                let v61 : unit = (fun () -> v60 (); v59) ()
                let v101 : string = "true; let __future_init = Box::pin(async move { //"
                let v102 : bool = Fable.Core.RustInterop.emitRustExpr () v101 
                let struct (v103 : uint8, v104 : US4) = method63(v1, v58)
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
                let v128 : std_pin_Pin<Box<Dyn<std_future_Future<struct (uint8 * US4)>>>> = Fable.Core.RustInterop.emitRustExpr () v127 
                let v129 : string = "v128.await"
                let struct (v130 : uint8, v131 : US4) = Fable.Core.RustInterop.emitRustExpr () v129 
                US8_1(v130, v131)
    let v270 : US8 = method64(v269)
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
and method66 (v0 : US8) : string =
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
and method65 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : US8) : string =
    let v9 : string = method66(v8)
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
        let v39 : string = method65(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method21(v39)
and method67 (v0 : US8, v1 : US4) : string =
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
    let v100 : std_pin_Pin<Box<Dyn<std_future_Future<US8>>>> = method28(v98, v99)
    let v101 : string = "v100.await"
    let v102 : US8 = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : unit = ()
    let v104 : (unit -> unit) = closure35(v102)
    let v105 : unit = (fun () -> v104 (); v103) ()
    let v168 : Result<uint8, anyhow_Error> =
        match v102 with
        | US8_1(v148, v149) -> (* Error *)
            let v150 : string = method67(v102, v149)
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
    let v169 : Result<uint8, anyhow_Error> = method68(v168)
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
and closure37 () (v0 : std_string_String) : US10 =
    US10_1(v0)
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
    let v186 : string = method22()
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
    let v213 : (std_string_String -> string) = method23()
    let v214 : string option = v212 |> Option.map v213 
    let v278 : (string -> US4) = method7()
    let v279 : US4 option = v214 |> Option.map v278 
    let v290 : US4 = US4_1
    let v291 : US4 = v279 |> Option.defaultValue v290 
    let v295 : std_pin_Pin<Box<Dyn<std_future_Future<Result<uint8, anyhow_Error>>>>> = method24(v3)
    let v296 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v297 : _ = Fable.Core.RustInterop.emitRustExpr () v296 
    let v298 : string = "v297.handle().block_on($0)"
    let v299 : Result<uint8, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v295 v298 
    let v300 : (anyhow_Error -> std_string_String) = method54()
    let v301 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v302 : string = "$0.map_err(|x| $1(x))"
    let v303 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v299, v300) v302 
    let _v301 = v303 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v304 : string = "$0.map_err(|x| $1(x))"
    let v305 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v299, v300) v304 
    let _v301 = v305 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v306 : string = "$0.map_err(|x| $1(x))"
    let v307 : Result<uint8, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v299, v300) v306 
    let _v301 = v307 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v308 : Result<uint8, std_string_String> = match v299 with Ok x -> Ok x | Error x -> Error (v300 x)
    let _v301 = v308 
    #endif
#if FABLE_COMPILER_PYTHON
    let v309 : Result<uint8, std_string_String> = match v299 with Ok x -> Ok x | Error x -> Error (v300 x)
    let _v301 = v309 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v310 : Result<uint8, std_string_String> = match v299 with Ok x -> Ok x | Error x -> Error (v300 x)
    let _v301 = v310 
    #endif
#else
    let v311 : Result<uint8, std_string_String> = match v299 with Ok x -> Ok x | Error x -> Error (v300 x)
    let _v301 = v311 
    #endif
    let v312 : Result<uint8, std_string_String> = _v301 
    let v315 : (uint8 -> US10) = closure36()
    let v316 : (std_string_String -> US10) = closure37()
    let v317 : US10 = match v312 with Ok x -> v315 x | Error x -> v316 x
    match v317 with
    | US10_1(v339) -> (* Error *)
        match v291 with
        | US4_0(v340) -> (* Some *)
            let v341 : bool = "" = v340
            if v341 then
                ()
            else
                let v342 : string = "fable_library_rust::String_::fromString($0)"
                let v343 : string = Fable.Core.RustInterop.emitRustExpr v339 v342 
                let v344 : bool = v343.Contains v340 
                if v344 then
                    ()
                else
                    let v347 : string = $"spiral_wasm.main / exception: '{v340}' / error: {v339}"
                    let v348 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v349 : string = "Err($0)"
                    let v350 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v347 v349 
                    let _v348 = v350 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v351 : string = "Err($0)"
                    let v352 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v347 v351 
                    let _v348 = v352 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v353 : string = "Err($0)"
                    let v354 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v347 v353 
                    let _v348 = v354 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v355 : Result<unit, string> = v347 |> Error
                    let _v348 = v355 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v356 : Result<unit, string> = v347 |> Error
                    let _v348 = v356 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v357 : Result<unit, string> = v347 |> Error
                    let _v348 = v357 
                    #endif
#else
                    let v358 : Result<unit, string> = v347 |> Error
                    let _v348 = v358 
                    #endif
                    let v359 : Result<unit, string> = _v348 
                    let v362 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v363 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v359 v363 
                    let _v362 = () 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v364 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v359 v364 
                    let _v362 = () 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v365 : string = "$0.unwrap()"
                    Fable.Core.RustInterop.emitRustExpr v359 v365 
                    let _v362 = () 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    match v359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v362 = () 
                    #endif
#if FABLE_COMPILER_PYTHON
                    match v359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v362 = () 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    match v359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v362 = () 
                    #endif
#else
                    match v359 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
                    let _v362 = () 
                    #endif
                    _v362 
                    ()
        | _ ->
            let v366 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v367 : string = "$0.unwrap()"
            let v368 : uint8 = Fable.Core.RustInterop.emitRustExpr v312 v367 
            let _v366 = v368 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v369 : string = "$0.unwrap()"
            let v370 : uint8 = Fable.Core.RustInterop.emitRustExpr v312 v369 
            let _v366 = v370 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v371 : string = "$0.unwrap()"
            let v372 : uint8 = Fable.Core.RustInterop.emitRustExpr v312 v371 
            let _v366 = v372 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v373 : uint8 = match v312 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v366 = v373 
            #endif
#if FABLE_COMPILER_PYTHON
            let v374 : uint8 = match v312 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v366 = v374 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v375 : uint8 = match v312 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v366 = v375 
            #endif
#else
            let v376 : uint8 = match v312 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v366 = v376 
            #endif
            let v377 : uint8 = _v366 
            ()
    | US10_0(v318) -> (* Ok *)
        match v291 with
        | US4_0(v319) -> (* Some *)
            let v320 : string = $"spiral_wasm.main / retries: {v318} / exception: '{v319}'"
            let v321 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v322 : string = "Err($0)"
            let v323 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v320 v322 
            let _v321 = v323 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v324 : string = "Err($0)"
            let v325 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v320 v324 
            let _v321 = v325 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v326 : string = "Err($0)"
            let v327 : Result<unit, string> = Fable.Core.RustInterop.emitRustExpr v320 v326 
            let _v321 = v327 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v328 : Result<unit, string> = v320 |> Error
            let _v321 = v328 
            #endif
#if FABLE_COMPILER_PYTHON
            let v329 : Result<unit, string> = v320 |> Error
            let _v321 = v329 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v330 : Result<unit, string> = v320 |> Error
            let _v321 = v330 
            #endif
#else
            let v331 : Result<unit, string> = v320 |> Error
            let _v321 = v331 
            #endif
            let v332 : Result<unit, string> = _v321 
            let v335 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v336 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v332 v336 
            let _v335 = () 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v337 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v332 v337 
            let _v335 = () 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v338 : string = "$0.unwrap()"
            Fable.Core.RustInterop.emitRustExpr v332 v338 
            let _v335 = () 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            match v332 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v335 = () 
            #endif
#if FABLE_COMPILER_PYTHON
            match v332 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v335 = () 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            match v332 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v335 = () 
            #endif
#else
            match v332 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
            let _v335 = () 
            #endif
            _v335 
            ()
        | _ ->
            ()
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
