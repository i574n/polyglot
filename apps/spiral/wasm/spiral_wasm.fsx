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
type near_token_NearToken = class end
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
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
module State = let mutable trace_state = None
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
and Mut3 = {mutable l0 : US3}
and [<Struct>] US4 =
    | US4_0 of f0_0 : string
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and Mut4 = {mutable l0 : string}
let rec method0 () : clap_Command =
    let v0 : string = "command"
    let v1 : string = "r#\"" + v0 + "\"#"
    let v2 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = "clap::Command::new($0)"
    let v4 : clap_Command = Fable.Core.RustInterop.emitRustExpr v2 v3 
    let v5 : string = "clap::Command::args_override_self($0, true)"
    let v6 : clap_Command = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "trace_level"
    let v8 : string = "r#\"" + v7 + "\"#"
    let v9 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "clap::Arg::new($0)"
    let v11 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "$0.short($1)"
    let v13 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v11, 't') v12 
    let v14 : string = "r#\"" + v7 + "\"#"
    let v15 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = "$0.long($1)"
    let v17 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v16 
    
    
    
    
    
    let v18 : string list = []
    let v19 : string = "Critical"
    let v20 : string list = v19 :: v18 
    let v23 : string = "Warning"
    let v24 : string list = v23 :: v20 
    let v27 : string = "Info"
    let v28 : string list = v27 :: v24 
    let v31 : string = "Debug"
    let v32 : string list = v31 :: v28 
    let v35 : string = "Verbose"
    let v36 : string list = v35 :: v32 
    let v39 : (string list -> (string [])) = List.toArray
    let v40 : (string []) = v39 v36
    let v43 : string = "$0.to_vec()"
    let v44 : Vec<string> = Fable.Core.RustInterop.emitRustExpr v40 v43 
    let v45 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v46 : bool = Fable.Core.RustInterop.emitRustExpr v44 v45 
    let v47 : string = "x"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr () v47 
    let v49 : string = "&*$0"
    let v50 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v48 v49 
    let v51 : string = "String::from($0)"
    let v52 : std_string_String = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = "Box::new($0)"
    let v54 : Box<std_string_String> = Fable.Core.RustInterop.emitRustExpr v52 v53 
    let v55 : string = "Box::leak($0)"
    let v56 : Ref<Lifetime<StaticLifetime, Mut<std_string_String>>> = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : string = "clap::builder::PossibleValue::new(&**$0)"
    let v58 : clap_builder_PossibleValue = Fable.Core.RustInterop.emitRustExpr v56 v57 
    let v59 : string = "true; $0 }).collect::<Vec<_>>()"
    let v60 : bool = Fable.Core.RustInterop.emitRustExpr v58 v59 
    let v61 : string = "_vec_map"
    let v62 : Vec<clap_builder_PossibleValue> = Fable.Core.RustInterop.emitRustExpr () v61 
    let v63 : string = "Into::<clap::builder::ValueParser>::into(clap::builder::PossibleValuesParser::new($0))"
    let v64 : clap_builder_ValueParser = Fable.Core.RustInterop.emitRustExpr v62 v63 
    let v65 : string = "$0.value_parser($1)"
    let v66 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v17, v64) v65 
    let v67 : string = "clap::Command::arg($0, $1)"
    let v68 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v6, v66) v67 
    let v69 : string = "wasm"
    let v70 : string = "r#\"" + v69 + "\"#"
    let v71 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v70 
    let v72 : string = "clap::Arg::new($0)"
    let v73 : clap_Arg = Fable.Core.RustInterop.emitRustExpr v71 v72 
    let v74 : string = "$0.short($1)"
    let v75 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v73, 'w') v74 
    let v76 : string = "r#\"" + v69 + "\"#"
    let v77 : Ref<Lifetime<StaticLifetime, Str>> = Fable.Core.RustInterop.emitRustExpr () v76 
    let v78 : string = "$0.long($1)"
    let v79 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v75, v77) v78 
    let v80 : string = "$0.required($1)"
    let v81 : clap_Arg = Fable.Core.RustInterop.emitRustExpr struct (v79, true) v80 
    let v82 : string = "clap::Command::arg($0, $1)"
    let v83 : clap_Command = Fable.Core.RustInterop.emitRustExpr struct (v68, v81) v82 
    v83
and method1 () : string =
    let v0 : string = "trace_level"
    v0
and closure1 (v0 : US0 option ref) (v1 : US0 option) : US0 option ref =
    v0.Value <- v1 
    v0
and closure2 (v0 : std_string_String option, v1 : (US0 option -> US0 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : std_string_String = x
    let v3 : US0 = US0_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method3 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method5 () : string =
    let v0 : string = ""
    v0
and closure4 (v0 : US4 option ref) (v1 : US4 option) : US4 option ref =
    v0.Value <- v1 
    v0
and closure5 (v0 : string option, v1 : (US4 option -> US4 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : string = x
    let v3 : US4 = US4_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method4 (v0 : string) : string =
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
    let v14 : string = method5()
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
    let v29 : string = method5()
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
    let v44 : string = method5()
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
    let v64 : US4 option = None
    let _v64 = ref v64 
    let v65 : US4 option ref = _v64 
    let v66 : (US4 option -> US4 option ref) = closure4(v65)
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure5(v61, v66)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : US4 option = _v64.Value 
    let v83 : US4 = US4_1
    let v84 : US4 = v72 |> Option.defaultValue v83 
    let v91 : string =
        match v84 with
        | US4_1 -> (* None *)
            let v89 : string = ""
            v89
        | US4_0(v88) -> (* Some *)
            v88
    let _v1 = v91 
    #endif
#else
    let v92 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v93 : string = v92 v0
    let mutable _v93 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v94 : (string -> string option) = Option.ofObj
    let v95 : string option = v94 v93
    v95 
    #else
    Some v93 
    #endif
    |> fun x -> _v93 <- Some x
    let v96 : string option = match _v93 with Some x -> x | None -> failwith "optionm'.of_obj / _v93=None"
    let v99 : US4 option = None
    let _v99 = ref v99 
    let v100 : US4 option ref = _v99 
    let v101 : (US4 option -> US4 option ref) = closure4(v100)
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure5(v96, v101)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : US4 option = _v99.Value 
    let v118 : US4 = US4_1
    let v119 : US4 = v107 |> Option.defaultValue v118 
    let v126 : string =
        match v119 with
        | US4_1 -> (* None *)
            let v124 : string = ""
            v124
        | US4_0(v123) -> (* Some *)
            v123
    let _v1 = v126 
    #endif
    let v127 : string = _v1 
    v127
and method6 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure6 () (v0 : string) : unit =
    ()
and method2 (v0 : US3) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method3()
    let v3 : string = method4(v2)
    
    
    
    
    
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
    let v50 : string = method6()
    let v51 : string = method4(v50)
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
    let v111 : string = method3()
    let v112 : string = method4(v111)
    
    
    
    
    
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
    let v159 : string = method6()
    let v160 : string = method4(v159)
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
    let v172 : string = method3()
    let v173 : string = method4(v172)
    
    
    
    
    
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
    let v220 : string = method6()
    let v221 : string = method4(v220)
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
    let v233 : string = method3()
    let v234 : string = method4(v233)
    
    
    
    
    
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
    let v281 : string = method6()
    let v282 : string = method4(v281)
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
    let v359 : Mut2 = {l0 = true} : Mut2
    let v360 : Mut0 = {l0 = 0L} : Mut0
    let v363 : US3 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v361) -> (* Some *)
            v361
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v365 : (string -> unit) = closure6()
    let v366 : Mut1 = {l0 = v365} : Mut1
    let v373 : int64 option =
        match v295 with
        | US5_1 -> (* None *)
            let v371 : int64 option = None
            v371
        | US5_0(v367) -> (* Some *)
            let v368 : int64 option = Some v367 
            v368
    struct (v360, v366, v359, v364, v373)
and closure3 (v0 : US3) () : unit =
    let v1 : bool = State.trace_state.IsNone
    if v1 then
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method2(v0)
        let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
        State.trace_state <- v7 
        ()
and closure8 () () : unit =
    let v0 : bool = State.trace_state.IsNone
    if v0 then
        let v1 : US3 = US3_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method2(v1)
        let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
        State.trace_state <- v7 
        ()
and closure9 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure10 (v0 : US5 option ref) (v1 : US5 option) : US5 option ref =
    v0.Value <- v1 
    v0
and closure11 (v0 : int64 option, v1 : (US5 option -> US5 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : int64 = x
    let v3 : US5 = US5_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and method7 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method8 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    let v0 : string = ""
    v0
and closure12 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure13 () () : string =
    let v0 : string = $"spiral_wasm.main"
    v0
and closure15 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure14 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure15(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure7 (v0 : (string [])) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "args"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : string = $"%A{v0}"
        let v657 : string = $"{v654}"
        let v660 : unit = ()
        let v661 : (unit -> unit) = closure12(v626, v657)
        let v662 : unit = (fun () -> v661 (); v660) ()
        let v665 : string = " }"
        let v666 : string = $"{v665}"
        let v669 : unit = ()
        let v670 : (unit -> unit) = closure12(v626, v666)
        let v671 : unit = (fun () -> v670 (); v669) ()
        let v674 : string = v626.l0
        let v675 : (unit -> string) = closure13()
        let v676 : string = $"{v483} {v618} #{v624} %s{v675 ()} / {v674}"
        let v679 : char list = []
        let v680 : (char list -> (char [])) = List.toArray
        let v681 : (char []) = v680 v679
        let v684 : string = v676.TrimStart v681 
        let v702 : char list = []
        let v703 : char list = '/' :: v702 
        let v706 : char list = ' ' :: v703 
        let v709 : (char list -> (char [])) = List.toArray
        let v710 : (char []) = v709 v706
        let v713 : string = v684.TrimEnd v710 
        let v731 : (string -> unit) = closure14()
        let v732 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v733 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v713 v733 
        let _v732 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v734 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v713 v734 
        let _v732 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v735 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v713 v735 
        let _v732 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v731 v713
        let _v732 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v731 v713
        let _v732 = () 
        #endif
#else
        v731 v713
        let _v732 = () 
        #endif
        _v732 
        let v736 : (string -> unit) = v17.l0
        v736 v713
and method12 () : string =
    let v0 : string = "wasm"
    v0
and closure17 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure16 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "wasm_path"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : string = $"{v0}"
        let v657 : unit = ()
        let v658 : (unit -> unit) = closure12(v626, v654)
        let v659 : unit = (fun () -> v658 (); v657) ()
        let v662 : string = " }"
        let v663 : string = $"{v662}"
        let v666 : unit = ()
        let v667 : (unit -> unit) = closure12(v626, v663)
        let v668 : unit = (fun () -> v667 (); v666) ()
        let v671 : string = v626.l0
        let v672 : (unit -> string) = closure17()
        let v673 : string = $"{v483} {v618} #{v624} %s{v672 ()} / {v671}"
        let v676 : char list = []
        let v677 : (char list -> (char [])) = List.toArray
        let v678 : (char []) = v677 v676
        let v681 : string = v673.TrimStart v678 
        let v699 : char list = []
        let v700 : char list = '/' :: v699 
        let v703 : char list = ' ' :: v700 
        let v706 : (char list -> (char [])) = List.toArray
        let v707 : (char []) = v706 v703
        let v710 : string = v681.TrimEnd v707 
        let v728 : (string -> unit) = closure14()
        let v729 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v730 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v730 
        let _v729 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v731 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v731 
        let _v729 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v732 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v710 v732 
        let _v729 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v728 v710
        let _v729 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v728 v710
        let _v729 = () 
        #endif
#else
        v728 v710
        let _v729 = () 
        #endif
        _v729 
        let v733 : (string -> unit) = v17.l0
        v733 v710
and closure19 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure18 (v0 : near_workspaces_Worker<near_workspaces_network_Sandbox>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "worker"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure19()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and closure21 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure20 (v0 : near_workspaces_Contract) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "contract"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure21()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and closure23 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure22 (v0 : near_workspaces_result_ExecutionFinalResult) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "result"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure23()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and closure25 (v0 : std_string_String) () : unit =
    let v1 : (std_string_String -> unit) = System.Console.WriteLine
    v1 v0
and closure24 () (v0 : std_string_String) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure25(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method13 () : string =
    let v0 : string = "("
    v0
and method14 () : string =
    let v0 : string = " "
    v0
and closure27 () () : string =
    let v0 : string = "spiral_wasm.print_usd"
    v0
and closure26 (v0 : uint64, v1 : float) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure8()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US3 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure9(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US5 option = None
        let _v102 = ref v102 
        let v103 : US5 option ref = _v102 
        let v104 : (US5 option -> US5 option ref) = closure10(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure11(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US5 option = _v102.Value 
        let v121 : US5 = US5_1
        let v122 : US5 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US5_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US5_0(v126) -> (* Some *)
                let v127 : System.DateTime = System.DateTime.Now
                let v130 : (System.DateTime -> int64) = _.Ticks
                let v131 : int64 = v130 v127
                let v134 : int64 = v131 - v126
                let v135 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v136 : System.TimeSpan = v135 v134
                let v139 : (System.TimeSpan -> int32) = _.Hours
                let v140 : int32 = v139 v136
                let v143 : (System.TimeSpan -> int32) = _.Minutes
                let v144 : int32 = v143 v136
                let v147 : (System.TimeSpan -> int32) = _.Seconds
                let v148 : int32 = v147 v136
                let v151 : (System.TimeSpan -> int32) = _.Milliseconds
                let v152 : int32 = v151 v136
                let v155 : System.DateTime = System.DateTime (1, 1, 1, v140, v144, v148, v152)
                v155
        let v163 : string = method7()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US5 option = None
        let _v170 = ref v170 
        let v171 : US5 option ref = _v170 
        let v172 : (US5 option -> US5 option ref) = closure10(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure11(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US5 option = _v170.Value 
        let v189 : US5 = US5_1
        let v190 : US5 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US5_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US5_0(v194) -> (* Some *)
                let v195 : System.DateTime = System.DateTime.Now
                let v198 : (System.DateTime -> int64) = _.Ticks
                let v199 : int64 = v198 v195
                let v202 : int64 = v199 - v194
                let v203 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v204 : System.TimeSpan = v203 v202
                let v207 : (System.TimeSpan -> int32) = _.Hours
                let v208 : int32 = v207 v204
                let v211 : (System.TimeSpan -> int32) = _.Minutes
                let v212 : int32 = v211 v204
                let v215 : (System.TimeSpan -> int32) = _.Seconds
                let v216 : int32 = v215 v204
                let v219 : (System.TimeSpan -> int32) = _.Milliseconds
                let v220 : int32 = v219 v204
                let v223 : System.DateTime = System.DateTime (1, 1, 1, v208, v212, v216, v220)
                v223
        let v231 : string = method7()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US5 option = None
        let _v240 = ref v240 
        let v241 : US5 option ref = _v240 
        let v242 : (US5 option -> US5 option ref) = closure10(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure11(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US5 option = _v240.Value 
        let v259 : US5 = US5_1
        let v260 : US5 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US5_1 -> (* None *)
                v239
            | US5_0(v264) -> (* Some *)
                let v265 : (int64 -> uint64) = uint64
                let v266 : uint64 = v265 v264
                let v267 : uint64 = v239 - v266
                v267
        let v270 : uint64 = v269 / 1000000000UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v270 / 60UL
        let v273 : uint64 = v272 % 60UL
        let v274 : uint64 = v270 / 3600UL
        let v275 : uint64 = v274 % 24UL
        let v276 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v277 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v275, v273, v271) v276 
        let v278 : string = "fable_library_rust::String_::fromString($0)"
        let v279 : string = Fable.Core.RustInterop.emitRustExpr v277 v278 
        let _v101 = v279 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v280 : US5 option = None
        let _v280 = ref v280 
        let v281 : US5 option ref = _v280 
        let v282 : (US5 option -> US5 option ref) = closure10(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure11(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US5 option = _v280.Value 
        let v299 : US5 = US5_1
        let v300 : US5 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US5_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US5_0(v304) -> (* Some *)
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
        let v341 : string = method8()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US5 option = None
        let _v348 = ref v348 
        let v349 : US5 option ref = _v348 
        let v350 : (US5 option -> US5 option ref) = closure10(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure11(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US5 option = _v348.Value 
        let v367 : US5 = US5_1
        let v368 : US5 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US5_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US5_0(v372) -> (* Some *)
                let v373 : System.DateTime = System.DateTime.Now
                let v376 : (System.DateTime -> int64) = _.Ticks
                let v377 : int64 = v376 v373
                let v380 : int64 = v377 - v372
                let v381 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v382 : System.TimeSpan = v381 v380
                let v385 : (System.TimeSpan -> int32) = _.Hours
                let v386 : int32 = v385 v382
                let v389 : (System.TimeSpan -> int32) = _.Minutes
                let v390 : int32 = v389 v382
                let v393 : (System.TimeSpan -> int32) = _.Seconds
                let v394 : int32 = v393 v382
                let v397 : (System.TimeSpan -> int32) = _.Milliseconds
                let v398 : int32 = v397 v382
                let v401 : System.DateTime = System.DateTime (1, 1, 1, v386, v390, v394, v398)
                v401
        let v409 : string = method8()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US5 option = None
        let _v416 = ref v416 
        let v417 : US5 option ref = _v416 
        let v418 : (US5 option -> US5 option ref) = closure10(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure11(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US5 option = _v416.Value 
        let v435 : US5 = US5_1
        let v436 : US5 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US5_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US5_0(v440) -> (* Some *)
                let v441 : System.DateTime = System.DateTime.Now
                let v444 : (System.DateTime -> int64) = _.Ticks
                let v445 : int64 = v444 v441
                let v448 : int64 = v445 - v440
                let v449 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v450 : System.TimeSpan = v449 v448
                let v453 : (System.TimeSpan -> int32) = _.Hours
                let v454 : int32 = v453 v450
                let v457 : (System.TimeSpan -> int32) = _.Minutes
                let v458 : int32 = v457 v450
                let v461 : (System.TimeSpan -> int32) = _.Seconds
                let v462 : int32 = v461 v450
                let v465 : (System.TimeSpan -> int32) = _.Milliseconds
                let v466 : int32 = v465 v450
                let v469 : System.DateTime = System.DateTime (1, 1, 1, v454, v458, v462, v466)
                v469
        let v477 : string = method8()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        
        
        
        
        
        let v554 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v555 : string = method13()
        let _v554 = v555 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v556 : string = method13()
        let _v554 = v556 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v557 : string = method13()
        let _v554 = v557 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v558 : string = method14()
        let _v554 = v558 
        #endif
#if FABLE_COMPILER_PYTHON
        let v559 : string = method14()
        let _v554 = v559 
        #endif
#else
        let v560 : string = method14()
        let _v554 = v560 
        #endif
        let v561 : string = _v554 
        let v566 : string = method10()
        let v567 : Mut4 = {l0 = v566} : Mut4
        let v568 : US3 = US3_0
        let v569 : string = $"%A{v568}"
        let v573 : string = $"{v569}"
        let v576 : unit = ()
        let v577 : (unit -> unit) = closure12(v567, v573)
        let v578 : unit = (fun () -> v577 (); v576) ()
        let v581 : string = v567.l0
        let v582 : (string []) = v581.Split v561 
        let v585 : string = v582.[int 0]
        let v588 : string = method10()
        let v589 : Mut4 = {l0 = v588} : Mut4
        let v590 : US3 = US3_1
        let v591 : string = $"%A{v590}"
        let v595 : string = $"{v591}"
        let v598 : unit = ()
        let v599 : (unit -> unit) = closure12(v589, v595)
        let v600 : unit = (fun () -> v599 (); v598) ()
        let v603 : string = v589.l0
        let v604 : bool = v603.StartsWith v585 
        let v610 : US4 =
            if v604 then
                let v607 : string = "Verbose"
                US4_0(v607)
            else
                US4_1
        let v616 : US4 =
            match v610 with
            | US4_1 -> (* None *)
                let v613 : string = "Debug"
                US4_0(v613)
            | US4_0(v611) -> (* Some *)
                US4_0(v611)
        let v620 : string =
            match v616 with
            | US4_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US4_0(v617) -> (* Some *)
                v617
        let v621 : (unit -> string) = v620.ToLower
        let v622 : string = v621 ()
        let v625 : string = v622.PadLeft (7, ' ')
        let v639 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v640 : string = "inline_colorization::color_bright_blue"
        let v641 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v640 
        let v642 : string = "&*$0"
        let v643 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v642 
        let v644 : string = "inline_colorization::color_reset"
        let v645 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v644 
        let v646 : string = "\"{v641}{v643}{v645}\""
        let v647 : string = @$"format!(" + v646 + ")"
        let v648 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v647 
        let v649 : string = "fable_library_rust::String_::fromString($0)"
        let v650 : string = Fable.Core.RustInterop.emitRustExpr v648 v649 
        let _v639 = v650 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v651 : string = "inline_colorization::color_bright_blue"
        let v652 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v651 
        let v653 : string = "&*$0"
        let v654 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v653 
        let v655 : string = "inline_colorization::color_reset"
        let v656 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v655 
        let v657 : string = "\"{v652}{v654}{v656}\""
        let v658 : string = @$"format!(" + v657 + ")"
        let v659 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "fable_library_rust::String_::fromString($0)"
        let v661 : string = Fable.Core.RustInterop.emitRustExpr v659 v660 
        let _v639 = v661 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v662 : string = "inline_colorization::color_bright_blue"
        let v663 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v662 
        let v664 : string = "&*$0"
        let v665 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v625 v664 
        let v666 : string = "inline_colorization::color_reset"
        let v667 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v666 
        let v668 : string = "\"{v663}{v665}{v667}\""
        let v669 : string = @$"format!(" + v668 + ")"
        let v670 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v669 
        let v671 : string = "fable_library_rust::String_::fromString($0)"
        let v672 : string = Fable.Core.RustInterop.emitRustExpr v670 v671 
        let _v639 = v672 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v673 : string = "\u001b[94m"
        let v674 : string = method9()
        let v675 : string = v673 + v625 
        let v676 : string = v675 + v674 
        let _v639 = v676 
        #endif
#if FABLE_COMPILER_PYTHON
        let v677 : string = "\u001b[94m"
        let v678 : string = method9()
        let v679 : string = v677 + v625 
        let v680 : string = v679 + v678 
        let _v639 = v680 
        #endif
#else
        let v681 : string = "\u001b[94m"
        let v682 : string = method9()
        let v683 : string = v681 + v625 
        let v684 : string = v683 + v682 
        let _v639 = v684 
        #endif
        let v685 : string = _v639 
        let v691 : int64 = v86.l0
        let v692 : string = method10()
        let v693 : Mut4 = {l0 = v692} : Mut4
        let v694 : string = "{ "
        let v695 : string = $"{v694}"
        let v698 : unit = ()
        let v699 : (unit -> unit) = closure12(v693, v695)
        let v700 : unit = (fun () -> v699 (); v698) ()
        let v703 : string = "total_gas_burnt_usd"
        let v704 : string = $"{v703}"
        let v707 : unit = ()
        let v708 : (unit -> unit) = closure12(v693, v704)
        let v709 : unit = (fun () -> v708 (); v707) ()
        let v712 : string = " = "
        let v713 : string = $"{v712}"
        let v716 : unit = ()
        let v717 : (unit -> unit) = closure12(v693, v713)
        let v718 : unit = (fun () -> v717 (); v716) ()
        let v721 : string = $"%+.6f{v1}"
        let v724 : unit = ()
        let v725 : (unit -> unit) = closure12(v693, v721)
        let v726 : unit = (fun () -> v725 (); v724) ()
        let v729 : string = "; "
        let v730 : string = $"{v729}"
        let v733 : unit = ()
        let v734 : (unit -> unit) = closure12(v693, v730)
        let v735 : unit = (fun () -> v734 (); v733) ()
        let v738 : string = "total_gas_burnt"
        let v739 : string = $"{v738}"
        let v742 : unit = ()
        let v743 : (unit -> unit) = closure12(v693, v739)
        let v744 : unit = (fun () -> v743 (); v742) ()
        let v747 : string = $"{v712}"
        let v750 : unit = ()
        let v751 : (unit -> unit) = closure12(v693, v747)
        let v752 : unit = (fun () -> v751 (); v750) ()
        let v755 : string = $"{v0}"
        let v758 : unit = ()
        let v759 : (unit -> unit) = closure12(v693, v755)
        let v760 : unit = (fun () -> v759 (); v758) ()
        let v763 : string = " }"
        let v764 : string = $"{v763}"
        let v767 : unit = ()
        let v768 : (unit -> unit) = closure12(v693, v764)
        let v769 : unit = (fun () -> v768 (); v767) ()
        let v772 : string = v693.l0
        let v773 : (unit -> string) = closure27()
        let v774 : string = $"{v484} {v685} #{v691} %s{v773 ()} / {v772}"
        let v777 : char list = []
        let v778 : (char list -> (char [])) = List.toArray
        let v779 : (char []) = v778 v777
        let v782 : string = v774.TrimStart v779 
        let v800 : char list = []
        let v801 : char list = '/' :: v800 
        let v804 : char list = ' ' :: v801 
        let v807 : (char list -> (char [])) = List.toArray
        let v808 : (char []) = v807 v804
        let v811 : string = v782.TrimEnd v808 
        let v829 : (string -> unit) = closure14()
        let v830 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v831 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v831 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v832 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v832 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v833 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v811 v833 
        let _v830 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v829 v811
        let _v830 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v829 v811
        let _v830 = () 
        #endif
#else
        v829 v811
        let _v830 = () 
        #endif
        _v830 
        let v834 : (string -> unit) = v18.l0
        v834 v811
and closure30 () () : string =
    let v0 : string = "spiral_wasm.print_usd / outcome"
    v0
and closure29 (v0 : bool, v1 : uint64, v2 : float, v3 : u128, v4 : float) () : unit =
    let v5 : unit = ()
    let v6 : (unit -> unit) = closure8()
    let v7 : unit = (fun () -> v6 (); v5) ()
    let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : int64 option) = State.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v6 (); v35) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : int64 option) = State.trace_state.Value
    let v64 : US3 = v52.l0
    let v65 : bool = v51.l0
    let v66 : bool = v65 = false
    let v69 : bool =
        if v66 then
            false
        else
            let v67 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v64
            let v68 : bool = 1 >= v67
            v68
    if v69 then
        let v70 : unit = ()
        let v71 : (unit -> unit) = closure9(v20)
        let v72 : unit = (fun () -> v71 (); v70) ()
        let v75 : unit = ()
        let v76 : unit = (fun () -> v6 (); v75) ()
        let struct (v89 : Mut0, v90 : Mut1, v91 : Mut2, v92 : Mut3, v93 : int64 option) = State.trace_state.Value
        let v104 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v105 : US5 option = None
        let _v105 = ref v105 
        let v106 : US5 option ref = _v105 
        let v107 : (US5 option -> US5 option ref) = closure10(v106)
        let v108 : unit = ()
        let v109 : (unit -> unit) = closure11(v93, v107)
        let v110 : unit = (fun () -> v109 (); v108) ()
        let v113 : US5 option = _v105.Value 
        let v124 : US5 = US5_1
        let v125 : US5 = v113 |> Option.defaultValue v124 
        let v165 : System.DateTime =
            match v125 with
            | US5_1 -> (* None *)
                let v161 : System.DateTime = System.DateTime.Now
                v161
            | US5_0(v129) -> (* Some *)
                let v130 : System.DateTime = System.DateTime.Now
                let v133 : (System.DateTime -> int64) = _.Ticks
                let v134 : int64 = v133 v130
                let v137 : int64 = v134 - v129
                let v138 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v139 : System.TimeSpan = v138 v137
                let v142 : (System.TimeSpan -> int32) = _.Hours
                let v143 : int32 = v142 v139
                let v146 : (System.TimeSpan -> int32) = _.Minutes
                let v147 : int32 = v146 v139
                let v150 : (System.TimeSpan -> int32) = _.Seconds
                let v151 : int32 = v150 v139
                let v154 : (System.TimeSpan -> int32) = _.Milliseconds
                let v155 : int32 = v154 v139
                let v158 : System.DateTime = System.DateTime (1, 1, 1, v143, v147, v151, v155)
                v158
        let v166 : string = method7()
        let v169 : (string -> string) = v165.ToString
        let v170 : string = v169 v166
        let _v104 = v170 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v173 : US5 option = None
        let _v173 = ref v173 
        let v174 : US5 option ref = _v173 
        let v175 : (US5 option -> US5 option ref) = closure10(v174)
        let v176 : unit = ()
        let v177 : (unit -> unit) = closure11(v93, v175)
        let v178 : unit = (fun () -> v177 (); v176) ()
        let v181 : US5 option = _v173.Value 
        let v192 : US5 = US5_1
        let v193 : US5 = v181 |> Option.defaultValue v192 
        let v233 : System.DateTime =
            match v193 with
            | US5_1 -> (* None *)
                let v229 : System.DateTime = System.DateTime.Now
                v229
            | US5_0(v197) -> (* Some *)
                let v198 : System.DateTime = System.DateTime.Now
                let v201 : (System.DateTime -> int64) = _.Ticks
                let v202 : int64 = v201 v198
                let v205 : int64 = v202 - v197
                let v206 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v207 : System.TimeSpan = v206 v205
                let v210 : (System.TimeSpan -> int32) = _.Hours
                let v211 : int32 = v210 v207
                let v214 : (System.TimeSpan -> int32) = _.Minutes
                let v215 : int32 = v214 v207
                let v218 : (System.TimeSpan -> int32) = _.Seconds
                let v219 : int32 = v218 v207
                let v222 : (System.TimeSpan -> int32) = _.Milliseconds
                let v223 : int32 = v222 v207
                let v226 : System.DateTime = System.DateTime (1, 1, 1, v211, v215, v219, v223)
                v226
        let v234 : string = method7()
        let v237 : (string -> string) = v233.ToString
        let v238 : string = v237 v234
        let _v104 = v238 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v241 : string = $"near_sdk::env::block_timestamp()"
        let v242 : uint64 = Fable.Core.RustInterop.emitRustExpr () v241 
        let v243 : US5 option = None
        let _v243 = ref v243 
        let v244 : US5 option ref = _v243 
        let v245 : (US5 option -> US5 option ref) = closure10(v244)
        let v246 : unit = ()
        let v247 : (unit -> unit) = closure11(v93, v245)
        let v248 : unit = (fun () -> v247 (); v246) ()
        let v251 : US5 option = _v243.Value 
        let v262 : US5 = US5_1
        let v263 : US5 = v251 |> Option.defaultValue v262 
        let v272 : uint64 =
            match v263 with
            | US5_1 -> (* None *)
                v242
            | US5_0(v267) -> (* Some *)
                let v268 : (int64 -> uint64) = uint64
                let v269 : uint64 = v268 v267
                let v270 : uint64 = v242 - v269
                v270
        let v273 : uint64 = v272 / 1000000000UL
        let v274 : uint64 = v273 % 60UL
        let v275 : uint64 = v273 / 60UL
        let v276 : uint64 = v275 % 60UL
        let v277 : uint64 = v273 / 3600UL
        let v278 : uint64 = v277 % 24UL
        let v279 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v280 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v278, v276, v274) v279 
        let v281 : string = "fable_library_rust::String_::fromString($0)"
        let v282 : string = Fable.Core.RustInterop.emitRustExpr v280 v281 
        let _v104 = v282 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v283 : US5 option = None
        let _v283 = ref v283 
        let v284 : US5 option ref = _v283 
        let v285 : (US5 option -> US5 option ref) = closure10(v284)
        let v286 : unit = ()
        let v287 : (unit -> unit) = closure11(v93, v285)
        let v288 : unit = (fun () -> v287 (); v286) ()
        let v291 : US5 option = _v283.Value 
        let v302 : US5 = US5_1
        let v303 : US5 = v291 |> Option.defaultValue v302 
        let v343 : System.DateTime =
            match v303 with
            | US5_1 -> (* None *)
                let v339 : System.DateTime = System.DateTime.Now
                v339
            | US5_0(v307) -> (* Some *)
                let v308 : System.DateTime = System.DateTime.Now
                let v311 : (System.DateTime -> int64) = _.Ticks
                let v312 : int64 = v311 v308
                let v315 : int64 = v312 - v307
                let v316 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v317 : System.TimeSpan = v316 v315
                let v320 : (System.TimeSpan -> int32) = _.Hours
                let v321 : int32 = v320 v317
                let v324 : (System.TimeSpan -> int32) = _.Minutes
                let v325 : int32 = v324 v317
                let v328 : (System.TimeSpan -> int32) = _.Seconds
                let v329 : int32 = v328 v317
                let v332 : (System.TimeSpan -> int32) = _.Milliseconds
                let v333 : int32 = v332 v317
                let v336 : System.DateTime = System.DateTime (1, 1, 1, v321, v325, v329, v333)
                v336
        let v344 : string = method8()
        let v347 : (string -> string) = v343.ToString
        let v348 : string = v347 v344
        let _v104 = v348 
        #endif
#if FABLE_COMPILER_PYTHON
        let v351 : US5 option = None
        let _v351 = ref v351 
        let v352 : US5 option ref = _v351 
        let v353 : (US5 option -> US5 option ref) = closure10(v352)
        let v354 : unit = ()
        let v355 : (unit -> unit) = closure11(v93, v353)
        let v356 : unit = (fun () -> v355 (); v354) ()
        let v359 : US5 option = _v351.Value 
        let v370 : US5 = US5_1
        let v371 : US5 = v359 |> Option.defaultValue v370 
        let v411 : System.DateTime =
            match v371 with
            | US5_1 -> (* None *)
                let v407 : System.DateTime = System.DateTime.Now
                v407
            | US5_0(v375) -> (* Some *)
                let v376 : System.DateTime = System.DateTime.Now
                let v379 : (System.DateTime -> int64) = _.Ticks
                let v380 : int64 = v379 v376
                let v383 : int64 = v380 - v375
                let v384 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v385 : System.TimeSpan = v384 v383
                let v388 : (System.TimeSpan -> int32) = _.Hours
                let v389 : int32 = v388 v385
                let v392 : (System.TimeSpan -> int32) = _.Minutes
                let v393 : int32 = v392 v385
                let v396 : (System.TimeSpan -> int32) = _.Seconds
                let v397 : int32 = v396 v385
                let v400 : (System.TimeSpan -> int32) = _.Milliseconds
                let v401 : int32 = v400 v385
                let v404 : System.DateTime = System.DateTime (1, 1, 1, v389, v393, v397, v401)
                v404
        let v412 : string = method8()
        let v415 : (string -> string) = v411.ToString
        let v416 : string = v415 v412
        let _v104 = v416 
        #endif
#else
        let v419 : US5 option = None
        let _v419 = ref v419 
        let v420 : US5 option ref = _v419 
        let v421 : (US5 option -> US5 option ref) = closure10(v420)
        let v422 : unit = ()
        let v423 : (unit -> unit) = closure11(v93, v421)
        let v424 : unit = (fun () -> v423 (); v422) ()
        let v427 : US5 option = _v419.Value 
        let v438 : US5 = US5_1
        let v439 : US5 = v427 |> Option.defaultValue v438 
        let v479 : System.DateTime =
            match v439 with
            | US5_1 -> (* None *)
                let v475 : System.DateTime = System.DateTime.Now
                v475
            | US5_0(v443) -> (* Some *)
                let v444 : System.DateTime = System.DateTime.Now
                let v447 : (System.DateTime -> int64) = _.Ticks
                let v448 : int64 = v447 v444
                let v451 : int64 = v448 - v443
                let v452 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v453 : System.TimeSpan = v452 v451
                let v456 : (System.TimeSpan -> int32) = _.Hours
                let v457 : int32 = v456 v453
                let v460 : (System.TimeSpan -> int32) = _.Minutes
                let v461 : int32 = v460 v453
                let v464 : (System.TimeSpan -> int32) = _.Seconds
                let v465 : int32 = v464 v453
                let v468 : (System.TimeSpan -> int32) = _.Milliseconds
                let v469 : int32 = v468 v453
                let v472 : System.DateTime = System.DateTime (1, 1, 1, v457, v461, v465, v469)
                v472
        let v480 : string = method8()
        let v483 : (string -> string) = v479.ToString
        let v484 : string = v483 v480
        let _v104 = v484 
        #endif
        let v487 : string = _v104 
        
        
        
        
        
        let v557 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v558 : string = method13()
        let _v557 = v558 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v559 : string = method13()
        let _v557 = v559 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v560 : string = method13()
        let _v557 = v560 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v561 : string = method14()
        let _v557 = v561 
        #endif
#if FABLE_COMPILER_PYTHON
        let v562 : string = method14()
        let _v557 = v562 
        #endif
#else
        let v563 : string = method14()
        let _v557 = v563 
        #endif
        let v564 : string = _v557 
        let v569 : string = method10()
        let v570 : Mut4 = {l0 = v569} : Mut4
        let v571 : US3 = US3_0
        let v572 : string = $"%A{v571}"
        let v576 : string = $"{v572}"
        let v579 : unit = ()
        let v580 : (unit -> unit) = closure12(v570, v576)
        let v581 : unit = (fun () -> v580 (); v579) ()
        let v584 : string = v570.l0
        let v585 : (string []) = v584.Split v564 
        let v588 : string = v585.[int 0]
        let v591 : string = method10()
        let v592 : Mut4 = {l0 = v591} : Mut4
        let v593 : US3 = US3_1
        let v594 : string = $"%A{v593}"
        let v598 : string = $"{v594}"
        let v601 : unit = ()
        let v602 : (unit -> unit) = closure12(v592, v598)
        let v603 : unit = (fun () -> v602 (); v601) ()
        let v606 : string = v592.l0
        let v607 : bool = v606.StartsWith v588 
        let v613 : US4 =
            if v607 then
                let v610 : string = "Verbose"
                US4_0(v610)
            else
                US4_1
        let v619 : US4 =
            match v613 with
            | US4_1 -> (* None *)
                let v616 : string = "Debug"
                US4_0(v616)
            | US4_0(v614) -> (* Some *)
                US4_0(v614)
        let v623 : string =
            match v619 with
            | US4_1 -> (* None *)
                failwith<string> "Option does not have a value."
            | US4_0(v620) -> (* Some *)
                v620
        let v624 : (unit -> string) = v623.ToLower
        let v625 : string = v624 ()
        let v628 : string = v625.PadLeft (7, ' ')
        let v642 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v643 : string = "inline_colorization::color_bright_blue"
        let v644 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v643 
        let v645 : string = "&*$0"
        let v646 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v628 v645 
        let v647 : string = "inline_colorization::color_reset"
        let v648 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v647 
        let v649 : string = "\"{v644}{v646}{v648}\""
        let v650 : string = @$"format!(" + v649 + ")"
        let v651 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v650 
        let v652 : string = "fable_library_rust::String_::fromString($0)"
        let v653 : string = Fable.Core.RustInterop.emitRustExpr v651 v652 
        let _v642 = v653 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v654 : string = "inline_colorization::color_bright_blue"
        let v655 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v654 
        let v656 : string = "&*$0"
        let v657 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v628 v656 
        let v658 : string = "inline_colorization::color_reset"
        let v659 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v658 
        let v660 : string = "\"{v655}{v657}{v659}\""
        let v661 : string = @$"format!(" + v660 + ")"
        let v662 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v661 
        let v663 : string = "fable_library_rust::String_::fromString($0)"
        let v664 : string = Fable.Core.RustInterop.emitRustExpr v662 v663 
        let _v642 = v664 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v665 : string = "inline_colorization::color_bright_blue"
        let v666 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v665 
        let v667 : string = "&*$0"
        let v668 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v628 v667 
        let v669 : string = "inline_colorization::color_reset"
        let v670 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v669 
        let v671 : string = "\"{v666}{v668}{v670}\""
        let v672 : string = @$"format!(" + v671 + ")"
        let v673 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v672 
        let v674 : string = "fable_library_rust::String_::fromString($0)"
        let v675 : string = Fable.Core.RustInterop.emitRustExpr v673 v674 
        let _v642 = v675 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v676 : string = "\u001b[94m"
        let v677 : string = method9()
        let v678 : string = v676 + v628 
        let v679 : string = v678 + v677 
        let _v642 = v679 
        #endif
#if FABLE_COMPILER_PYTHON
        let v680 : string = "\u001b[94m"
        let v681 : string = method9()
        let v682 : string = v680 + v628 
        let v683 : string = v682 + v681 
        let _v642 = v683 
        #endif
#else
        let v684 : string = "\u001b[94m"
        let v685 : string = method9()
        let v686 : string = v684 + v628 
        let v687 : string = v686 + v685 
        let _v642 = v687 
        #endif
        let v688 : string = _v642 
        let v694 : int64 = v89.l0
        let v695 : string = method10()
        let v696 : Mut4 = {l0 = v695} : Mut4
        let v697 : string = "{ "
        let v698 : string = $"{v697}"
        let v701 : unit = ()
        let v702 : (unit -> unit) = closure12(v696, v698)
        let v703 : unit = (fun () -> v702 (); v701) ()
        let v706 : string = "is_success"
        let v707 : string = $"{v706}"
        let v710 : unit = ()
        let v711 : (unit -> unit) = closure12(v696, v707)
        let v712 : unit = (fun () -> v711 (); v710) ()
        let v715 : string = " = "
        let v716 : string = $"{v715}"
        let v719 : unit = ()
        let v720 : (unit -> unit) = closure12(v696, v716)
        let v721 : unit = (fun () -> v720 (); v719) ()
        let v726 : string =
            if v0 then
                let v724 : string = "true"
                v724
            else
                let v725 : string = "false"
                v725
        let v727 : string = $"{v726}"
        let v730 : unit = ()
        let v731 : (unit -> unit) = closure12(v696, v727)
        let v732 : unit = (fun () -> v731 (); v730) ()
        let v735 : string = "; "
        let v736 : string = $"{v735}"
        let v739 : unit = ()
        let v740 : (unit -> unit) = closure12(v696, v736)
        let v741 : unit = (fun () -> v740 (); v739) ()
        let v744 : string = "gas_burnt_usd"
        let v745 : string = $"{v744}"
        let v748 : unit = ()
        let v749 : (unit -> unit) = closure12(v696, v745)
        let v750 : unit = (fun () -> v749 (); v748) ()
        let v753 : string = $"{v715}"
        let v756 : unit = ()
        let v757 : (unit -> unit) = closure12(v696, v753)
        let v758 : unit = (fun () -> v757 (); v756) ()
        let v761 : string = $"%+.6f{v2}"
        let v764 : unit = ()
        let v765 : (unit -> unit) = closure12(v696, v761)
        let v766 : unit = (fun () -> v765 (); v764) ()
        let v769 : string = $"{v735}"
        let v772 : unit = ()
        let v773 : (unit -> unit) = closure12(v696, v769)
        let v774 : unit = (fun () -> v773 (); v772) ()
        let v777 : string = "tokens_burnt_usd"
        let v778 : string = $"{v777}"
        let v781 : unit = ()
        let v782 : (unit -> unit) = closure12(v696, v778)
        let v783 : unit = (fun () -> v782 (); v781) ()
        let v786 : string = $"{v715}"
        let v789 : unit = ()
        let v790 : (unit -> unit) = closure12(v696, v786)
        let v791 : unit = (fun () -> v790 (); v789) ()
        let v794 : string = $"%+.6f{v4}"
        let v797 : unit = ()
        let v798 : (unit -> unit) = closure12(v696, v794)
        let v799 : unit = (fun () -> v798 (); v797) ()
        let v802 : string = $"{v735}"
        let v805 : unit = ()
        let v806 : (unit -> unit) = closure12(v696, v802)
        let v807 : unit = (fun () -> v806 (); v805) ()
        let v810 : string = "gas_burnt"
        let v811 : string = $"{v810}"
        let v814 : unit = ()
        let v815 : (unit -> unit) = closure12(v696, v811)
        let v816 : unit = (fun () -> v815 (); v814) ()
        let v819 : string = $"{v715}"
        let v822 : unit = ()
        let v823 : (unit -> unit) = closure12(v696, v819)
        let v824 : unit = (fun () -> v823 (); v822) ()
        let v827 : string = $"{v1}"
        let v830 : unit = ()
        let v831 : (unit -> unit) = closure12(v696, v827)
        let v832 : unit = (fun () -> v831 (); v830) ()
        let v835 : string = $"{v735}"
        let v838 : unit = ()
        let v839 : (unit -> unit) = closure12(v696, v835)
        let v840 : unit = (fun () -> v839 (); v838) ()
        let v843 : string = "tokens_burnt"
        let v844 : string = $"{v843}"
        let v847 : unit = ()
        let v848 : (unit -> unit) = closure12(v696, v844)
        let v849 : unit = (fun () -> v848 (); v847) ()
        let v852 : string = $"{v715}"
        let v855 : unit = ()
        let v856 : (unit -> unit) = closure12(v696, v852)
        let v857 : unit = (fun () -> v856 (); v855) ()
        let v860 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v861 : string = "format!(\"{:#?}\", $0)"
        let v862 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v861 
        let v863 : string = "fable_library_rust::String_::fromString($0)"
        let v864 : string = Fable.Core.RustInterop.emitRustExpr v862 v863 
        let _v860 = v864 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v865 : string = "format!(\"{:#?}\", $0)"
        let v866 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v865 
        let v867 : string = "fable_library_rust::String_::fromString($0)"
        let v868 : string = Fable.Core.RustInterop.emitRustExpr v866 v867 
        let _v860 = v868 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v869 : string = "format!(\"{:#?}\", $0)"
        let v870 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v869 
        let v871 : string = "fable_library_rust::String_::fromString($0)"
        let v872 : string = Fable.Core.RustInterop.emitRustExpr v870 v871 
        let _v860 = v872 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v873 : string = $"%A{v3}"
        let _v860 = v873 
        #endif
#if FABLE_COMPILER_PYTHON
        let v876 : string = $"%A{v3}"
        let _v860 = v876 
        #endif
#else
        let v879 : string = $"%A{v3}"
        let _v860 = v879 
        #endif
        let v882 : string = _v860 
        let v887 : string = $"{v882}"
        let v890 : unit = ()
        let v891 : (unit -> unit) = closure12(v696, v887)
        let v892 : unit = (fun () -> v891 (); v890) ()
        let v895 : string = " }"
        let v896 : string = $"{v895}"
        let v899 : unit = ()
        let v900 : (unit -> unit) = closure12(v696, v896)
        let v901 : unit = (fun () -> v900 (); v899) ()
        let v904 : string = v696.l0
        let v905 : (unit -> string) = closure30()
        let v906 : string = $"{v487} {v688} #{v694} %s{v905 ()} / {v904}"
        let v909 : char list = []
        let v910 : (char list -> (char [])) = List.toArray
        let v911 : (char []) = v910 v909
        let v914 : string = v906.TrimStart v911 
        let v932 : char list = []
        let v933 : char list = '/' :: v932 
        let v936 : char list = ' ' :: v933 
        let v939 : (char list -> (char [])) = List.toArray
        let v940 : (char []) = v939 v936
        let v943 : string = v914.TrimEnd v940 
        let v961 : (string -> unit) = closure14()
        let v962 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v963 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v943 v963 
        let _v962 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v964 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v943 v964 
        let _v962 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v965 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v943 v965 
        let _v962 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v961 v943
        let _v962 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v961 v943
        let _v962 = () 
        #endif
#else
        v961 v943
        let _v962 = () 
        #endif
        _v962 
        let v966 : (string -> unit) = v21.l0
        v966 v943
and closure28 () (v0 : near_workspaces_result_ExecutionOutcome) : unit =
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
    let v12 : near_token_NearToken = Fable.Core.RustInterop.emitRustExpr v0 v11 
    let v13 : string = "$0.as_yoctonear()"
    let v14 : u128 = Fable.Core.RustInterop.emitRustExpr v12 v13 
    let v15 : string = "$0 as f64"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr v14 v15 
    let v17 : float = v16 / 1E+24
    let v18 : float = v17 * 6.68
    let v19 : unit = ()
    let v20 : (unit -> unit) = closure29(v2, v6, v10, v14, v18)
    let v21 : unit = (fun () -> v20 (); v19) ()
    ()
and closure32 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure31 (v0 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "result2"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure32()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and method15 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and closure34 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure33 (v0 : Vec<Ref<near_workspaces_result_ExecutionOutcome>>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "receipt_failures"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure34()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and method16 (v0 : near_workspaces_result_ExecutionFinalResult) : near_workspaces_result_ExecutionFinalResult =
    v0
and closure36 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure35 (v0 : Ref<Slice<near_workspaces_result_ExecutionOutcome>>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "receipt_outcomes"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure36()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and closure38 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure37 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "json"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure38()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and closure40 () () : string =
    let v0 : string = "spiral_wasm.run"
    v0
and closure39 (v0 : Result<std_string_String, near_workspaces_error_Error>) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure8()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US3 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US3_0, 0; US3_1, 1; US3_2, 2; US3_3, 3; US3_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure9(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US5 option = None
        let _v101 = ref v101 
        let v102 : US5 option ref = _v101 
        let v103 : (US5 option -> US5 option ref) = closure10(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure11(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US5 option = _v101.Value 
        let v120 : US5 = US5_1
        let v121 : US5 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US5_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US5_0(v125) -> (* Some *)
                let v126 : System.DateTime = System.DateTime.Now
                let v129 : (System.DateTime -> int64) = _.Ticks
                let v130 : int64 = v129 v126
                let v133 : int64 = v130 - v125
                let v134 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v135 : System.TimeSpan = v134 v133
                let v138 : (System.TimeSpan -> int32) = _.Hours
                let v139 : int32 = v138 v135
                let v142 : (System.TimeSpan -> int32) = _.Minutes
                let v143 : int32 = v142 v135
                let v146 : (System.TimeSpan -> int32) = _.Seconds
                let v147 : int32 = v146 v135
                let v150 : (System.TimeSpan -> int32) = _.Milliseconds
                let v151 : int32 = v150 v135
                let v154 : System.DateTime = System.DateTime (1, 1, 1, v139, v143, v147, v151)
                v154
        let v162 : string = method7()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US5 option = None
        let _v169 = ref v169 
        let v170 : US5 option ref = _v169 
        let v171 : (US5 option -> US5 option ref) = closure10(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure11(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US5 option = _v169.Value 
        let v188 : US5 = US5_1
        let v189 : US5 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US5_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US5_0(v193) -> (* Some *)
                let v194 : System.DateTime = System.DateTime.Now
                let v197 : (System.DateTime -> int64) = _.Ticks
                let v198 : int64 = v197 v194
                let v201 : int64 = v198 - v193
                let v202 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v203 : System.TimeSpan = v202 v201
                let v206 : (System.TimeSpan -> int32) = _.Hours
                let v207 : int32 = v206 v203
                let v210 : (System.TimeSpan -> int32) = _.Minutes
                let v211 : int32 = v210 v203
                let v214 : (System.TimeSpan -> int32) = _.Seconds
                let v215 : int32 = v214 v203
                let v218 : (System.TimeSpan -> int32) = _.Milliseconds
                let v219 : int32 = v218 v203
                let v222 : System.DateTime = System.DateTime (1, 1, 1, v207, v211, v215, v219)
                v222
        let v230 : string = method7()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US5 option = None
        let _v239 = ref v239 
        let v240 : US5 option ref = _v239 
        let v241 : (US5 option -> US5 option ref) = closure10(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure11(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US5 option = _v239.Value 
        let v258 : US5 = US5_1
        let v259 : US5 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US5_1 -> (* None *)
                v238
            | US5_0(v263) -> (* Some *)
                let v264 : (int64 -> uint64) = uint64
                let v265 : uint64 = v264 v263
                let v266 : uint64 = v238 - v265
                v266
        let v269 : uint64 = v268 / 1000000000UL
        let v270 : uint64 = v269 % 60UL
        let v271 : uint64 = v269 / 60UL
        let v272 : uint64 = v271 % 60UL
        let v273 : uint64 = v269 / 3600UL
        let v274 : uint64 = v273 % 24UL
        let v275 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v276 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v274, v272, v270) v275 
        let v277 : string = "fable_library_rust::String_::fromString($0)"
        let v278 : string = Fable.Core.RustInterop.emitRustExpr v276 v277 
        let _v100 = v278 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v279 : US5 option = None
        let _v279 = ref v279 
        let v280 : US5 option ref = _v279 
        let v281 : (US5 option -> US5 option ref) = closure10(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure11(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US5 option = _v279.Value 
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
        let v340 : string = method8()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US5 option = None
        let _v347 = ref v347 
        let v348 : US5 option ref = _v347 
        let v349 : (US5 option -> US5 option ref) = closure10(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure11(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US5 option = _v347.Value 
        let v366 : US5 = US5_1
        let v367 : US5 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US5_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US5_0(v371) -> (* Some *)
                let v372 : System.DateTime = System.DateTime.Now
                let v375 : (System.DateTime -> int64) = _.Ticks
                let v376 : int64 = v375 v372
                let v379 : int64 = v376 - v371
                let v380 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v381 : System.TimeSpan = v380 v379
                let v384 : (System.TimeSpan -> int32) = _.Hours
                let v385 : int32 = v384 v381
                let v388 : (System.TimeSpan -> int32) = _.Minutes
                let v389 : int32 = v388 v381
                let v392 : (System.TimeSpan -> int32) = _.Seconds
                let v393 : int32 = v392 v381
                let v396 : (System.TimeSpan -> int32) = _.Milliseconds
                let v397 : int32 = v396 v381
                let v400 : System.DateTime = System.DateTime (1, 1, 1, v385, v389, v393, v397)
                v400
        let v408 : string = method8()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US5 option = None
        let _v415 = ref v415 
        let v416 : US5 option ref = _v415 
        let v417 : (US5 option -> US5 option ref) = closure10(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure11(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US5 option = _v415.Value 
        let v434 : US5 = US5_1
        let v435 : US5 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US5_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US5_0(v439) -> (* Some *)
                let v440 : System.DateTime = System.DateTime.Now
                let v443 : (System.DateTime -> int64) = _.Ticks
                let v444 : int64 = v443 v440
                let v447 : int64 = v444 - v439
                let v448 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v449 : System.TimeSpan = v448 v447
                let v452 : (System.TimeSpan -> int32) = _.Hours
                let v453 : int32 = v452 v449
                let v456 : (System.TimeSpan -> int32) = _.Minutes
                let v457 : int32 = v456 v449
                let v460 : (System.TimeSpan -> int32) = _.Seconds
                let v461 : int32 = v460 v449
                let v464 : (System.TimeSpan -> int32) = _.Milliseconds
                let v465 : int32 = v464 v449
                let v468 : System.DateTime = System.DateTime (1, 1, 1, v453, v457, v461, v465)
                v468
        let v476 : string = method8()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        
        
        
        
        
        let v553 : string = "Verbose"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_bright_black"
        let v574 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v573 
        let v575 : string = "&*$0"
        let v576 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v575 
        let v577 : string = "inline_colorization::color_reset"
        let v578 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v577 
        let v579 : string = "\"{v574}{v576}{v578}\""
        let v580 : string = @$"format!(" + v579 + ")"
        let v581 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v580 
        let v582 : string = "fable_library_rust::String_::fromString($0)"
        let v583 : string = Fable.Core.RustInterop.emitRustExpr v581 v582 
        let _v572 = v583 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v584 : string = "inline_colorization::color_bright_black"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v572 = v594 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v595 : string = "inline_colorization::color_bright_black"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v558 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v572 = v605 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v606 : string = "\u001b[90m"
        let v607 : string = method9()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method9()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method9()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method10()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure12(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "borsh"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure12(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure12(v626, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v655 : string = "format!(\"{:#?}\", $0)"
        let v656 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v655 
        let v657 : string = "fable_library_rust::String_::fromString($0)"
        let v658 : string = Fable.Core.RustInterop.emitRustExpr v656 v657 
        let _v654 = v658 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v659 : string = "format!(\"{:#?}\", $0)"
        let v660 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v659 
        let v661 : string = "fable_library_rust::String_::fromString($0)"
        let v662 : string = Fable.Core.RustInterop.emitRustExpr v660 v661 
        let _v654 = v662 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v663 : string = "format!(\"{:#?}\", $0)"
        let v664 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v663 
        let v665 : string = "fable_library_rust::String_::fromString($0)"
        let v666 : string = Fable.Core.RustInterop.emitRustExpr v664 v665 
        let _v654 = v666 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v667 : string = $"%A{v0}"
        let _v654 = v667 
        #endif
#if FABLE_COMPILER_PYTHON
        let v670 : string = $"%A{v0}"
        let _v654 = v670 
        #endif
#else
        let v673 : string = $"%A{v0}"
        let _v654 = v673 
        #endif
        let v676 : string = _v654 
        let v681 : string = $"{v676}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure12(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure12(v626, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = v626.l0
        let v699 : (unit -> string) = closure40()
        let v700 : string = $"{v483} {v618} #{v624} %s{v699 ()} / {v698}"
        let v703 : char list = []
        let v704 : (char list -> (char [])) = List.toArray
        let v705 : (char []) = v704 v703
        let v708 : string = v700.TrimStart v705 
        let v726 : char list = []
        let v727 : char list = '/' :: v726 
        let v730 : char list = ' ' :: v727 
        let v733 : (char list -> (char [])) = List.toArray
        let v734 : (char []) = v733 v730
        let v737 : string = v708.TrimEnd v734 
        let v755 : (string -> unit) = closure14()
        let v756 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v758 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v759 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v759 
        let _v756 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v755 v737
        let _v756 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v755 v737
        let _v756 = () 
        #endif
#else
        v755 v737
        let _v756 = () 
        #endif
        _v756 
        let v760 : (string -> unit) = v17.l0
        v760 v737
and method17 (v0 : Result<unit, anyhow_Error>) : Result<unit, anyhow_Error> =
    v0
and method11 (v0 : clap_ArgMatches) : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> =
    let v1 : string = "true; let __future_init = Box::pin(async move { //"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let v3 : string = method12()
    let v4 : string = "&*$0"
    let v5 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "clap::ArgMatches::get_one(&$0, v5).cloned()"
    let v7 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let v8 : US0 option = None
    let _v8 = ref v8 
    let v9 : US0 option ref = _v8 
    let v10 : (US0 option -> US0 option ref) = closure1(v9)
    let v11 : unit = ()
    let v12 : (unit -> unit) = closure2(v7, v10)
    let v13 : unit = (fun () -> v12 (); v11) ()
    let v16 : US0 option = _v8.Value 
    let v27 : US0 = US0_1
    let v28 : US0 = v16 |> Option.defaultValue v27 
    let v35 : std_string_String =
        match v28 with
        | US0_1 -> (* None *)
            failwith<std_string_String> "Option does not have a value."
        | US0_0(v32) -> (* Some *)
            v32
    let v36 : string = "fable_library_rust::String_::fromString($0)"
    let v37 : string = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : unit = ()
    let v39 : (unit -> unit) = closure16(v37)
    let v40 : unit = (fun () -> v39 (); v38) ()
    let v774 : string = "std::fs::read(&*$0)"
    let v775 : Result<Vec<uint8>, std_io_Error> = Fable.Core.RustInterop.emitRustExpr v37 v774 
    let v776 : string = "$0?"
    let v777 : Vec<uint8> = Fable.Core.RustInterop.emitRustExpr v775 v776 
    let v778 : string = "near_workspaces::sandbox().await"
    let v779 : Result<near_workspaces_Worker<near_workspaces_network_Sandbox>, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v778 
    let v780 : string = "$0?"
    let v781 : near_workspaces_Worker<near_workspaces_network_Sandbox> = Fable.Core.RustInterop.emitRustExpr v779 v780 
    let v782 : unit = ()
    let v783 : (unit -> unit) = closure18(v781)
    let v784 : unit = (fun () -> v783 (); v782) ()
    let v1545 : string = "Box::pin($0.dev_deploy(&v777))"
    let v1546 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_Contract, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr v781 v1545 
    let v1547 : string = "v1546.await"
    let v1548 : Result<near_workspaces_Contract, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v1547 
    let v1549 : string = "$0?"
    let v1550 : near_workspaces_Contract = Fable.Core.RustInterop.emitRustExpr v1548 v1549 
    let v1551 : unit = ()
    let v1552 : (unit -> unit) = closure20(v1550)
    let v1553 : unit = (fun () -> v1552 (); v1551) ()
    let v2314 : string = "$0.call(&*$1)"
    let v2315 : string = "state_main"
    let v2316 : near_workspaces_operations_CallTransaction = Fable.Core.RustInterop.emitRustExpr struct (v1550, v2315) v2314 
    let v2317 : string = "Box::pin(v2316.transact())"
    let v2318 : std_pin_Pin<Box<Dyn<std_future_Future<Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v2317 
    let v2319 : string = "v2318.await"
    let v2320 : Result<near_workspaces_result_ExecutionFinalResult, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr () v2319 
    let v2321 : string = "$0?"
    let v2322 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v2320 v2321 
    let v2323 : unit = ()
    let v2324 : (unit -> unit) = closure22(v2322)
    let v2325 : unit = (fun () -> v2324 (); v2323) ()
    let v3086 : string = "v2322.logs()"
    let v3087 : Vec<Ref<Str>> = Fable.Core.RustInterop.emitRustExpr () v3086 
    let v3088 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
    let v3089 : bool = Fable.Core.RustInterop.emitRustExpr v3087 v3088 
    let v3090 : string = "x"
    let v3091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v3090 
    let v3092 : string = "String::from($0)"
    let v3093 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3091 v3092 
    let v3094 : string = "true; $0 }).collect::<Vec<_>>()"
    let v3095 : bool = Fable.Core.RustInterop.emitRustExpr v3093 v3094 
    let v3096 : string = "_vec_map"
    let v3097 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3096 
    let v3098 : string = "true; $0.iter().for_each(|x| { $1(x.clone()); }); //"
    let v3099 : (std_string_String -> unit) = closure24()
    let v3100 : bool = Fable.Core.RustInterop.emitRustExpr struct (v3097, v3099) v3098 
    let v3101 : string = "$0.total_gas_burnt"
    let v3102 : near_workspaces_types_Gas = Fable.Core.RustInterop.emitRustExpr v2322 v3101 
    let v3103 : string = "$0.as_gas()"
    let v3104 : uint64 = Fable.Core.RustInterop.emitRustExpr v3102 v3103 
    let v3105 : (uint64 -> float) = float
    let v3106 : float = v3105 v3104
    let v3107 : float = v3106 / 10000000000000000.0
    let v3108 : float = v3107 * 6.68
    let v3109 : unit = ()
    let v3110 : (unit -> unit) = closure26(v3104, v3108)
    let v3111 : unit = (fun () -> v3110 (); v3109) ()
    let v3945 : string = "$0"
    let v3946 : near_workspaces_result_ExecutionFinalResult = Fable.Core.RustInterop.emitRustExpr v2322 v3945 
    let v3947 : string = "v3946.outcomes()"
    let v3948 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v3947 
    let v3949 : string = "v3948.into_iter()"
    let v3950 : _ = Fable.Core.RustInterop.emitRustExpr () v3949 
    let v3951 : string = "v3950.cloned()"
    let v3952 : _ = Fable.Core.RustInterop.emitRustExpr () v3951 
    let v3953 : string = "true; v3952.for_each(|x| $0(x))"
    let v3954 : (near_workspaces_result_ExecutionOutcome -> unit) = closure28()
    let v3955 : bool = Fable.Core.RustInterop.emitRustExpr v3954 v3953 
    let v3956 : string = "$0.into_result()"
    let v3957 : Result<near_workspaces_result_ExecutionSuccess, near_workspaces_result_ExecutionFailure> = Fable.Core.RustInterop.emitRustExpr v2322 v3956 
    let v3958 : unit = ()
    let v3959 : (unit -> unit) = closure31(v3957)
    let v3960 : unit = (fun () -> v3959 (); v3958) ()
    let v4721 : near_workspaces_result_ExecutionFinalResult = method15(v2322)
    let v4722 : string = "v4721.receipt_failures()"
    let v4723 : Vec<Ref<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v4722 
    let v4724 : unit = ()
    let v4725 : (unit -> unit) = closure33(v4723)
    let v4726 : unit = (fun () -> v4725 (); v4724) ()
    let v5487 : near_workspaces_result_ExecutionFinalResult = method16(v2322)
    let v5488 : string = "v5487.receipt_outcomes()"
    let v5489 : Ref<Slice<near_workspaces_result_ExecutionOutcome>> = Fable.Core.RustInterop.emitRustExpr () v5488 
    let v5490 : unit = ()
    let v5491 : (unit -> unit) = closure35(v5489)
    let v5492 : unit = (fun () -> v5491 (); v5490) ()
    let v6253 : string = "$0.json()"
    let v6254 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v2322 v6253 
    let v6255 : unit = ()
    let v6256 : (unit -> unit) = closure37(v6254)
    let v6257 : unit = (fun () -> v6256 (); v6255) ()
    let v7018 : string = "$0.borsh()"
    let v7019 : Result<std_string_String, near_workspaces_error_Error> = Fable.Core.RustInterop.emitRustExpr v2322 v7018 
    let v7020 : unit = ()
    let v7021 : (unit -> unit) = closure39(v7019)
    let v7022 : unit = (fun () -> v7021 (); v7020) ()
    let v7783 : string = "$0.len()"
    let v7784 : unativeint = Fable.Core.RustInterop.emitRustExpr v4723 v7783 
    let v7785 : (unativeint -> int32) = int32
    let v7786 : int32 = v7785 v7784
    let v7787 : bool = v7786 = 0
    let v7794 : Result<unit, anyhow_Error> =
        if v7787 then
            let v7788 : Result<unit, anyhow_Error> = Ok () 
            v7788
        else
            let v7789 : string = "anyhow::anyhow!($0)"
            let v7790 : string = "<error>"
            let v7791 : anyhow_Error = Fable.Core.RustInterop.emitRustExpr v7790 v7789 
            let v7792 : string = "Err(v7791)"
            let v7793 : Result<unit, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr () v7792 
            v7793
    let v7795 : Result<unit, anyhow_Error> = method17(v7794)
    let v7796 : string = ""
    let v7797 : string = "}"
    let v7798 : string = v7796 + v7797 
    let v7799 : string = "true; v7795 " + v7798 + "); " + v7796 + " // rust.fix_closure'"
    let v7800 : bool = Fable.Core.RustInterop.emitRustExpr () v7799 
    let v7801 : string = "__future_init"
    let v7802 : _ = Fable.Core.RustInterop.emitRustExpr () v7801 
    let v7803 : string = "v7802"
    let v7804 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> = Fable.Core.RustInterop.emitRustExpr () v7803 
    v7804
and closure0 () (v0 : (string [])) : int32 =
    let v1 : clap_Command = method0()
    let v2 : string = "clap::Command::get_matches($0)"
    let v3 : clap_ArgMatches = Fable.Core.RustInterop.emitRustExpr v1 v2 
    let v4 : string = method1()
    let v5 : string = "&*$0"
    let v6 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v4 v5 
    let v7 : string = "clap::ArgMatches::get_one(&$0, v6).cloned()"
    let v8 : std_string_String option = Fable.Core.RustInterop.emitRustExpr v3 v7 
    let v9 : US0 option = None
    let _v9 = ref v9 
    let v10 : US0 option ref = _v9 
    let v11 : (US0 option -> US0 option ref) = closure1(v10)
    let v12 : unit = ()
    let v13 : (unit -> unit) = closure2(v8, v11)
    let v14 : unit = (fun () -> v13 (); v12) ()
    let v17 : US0 option = _v9.Value 
    let v28 : US0 = US0_1
    let v29 : US0 = v17 |> Option.defaultValue v28 
    let v85 : US1 =
        match v29 with
        | US0_1 -> (* None *)
            US1_1
        | US0_0(v33) -> (* Some *)
            let v34 : string = "fable_library_rust::String_::fromString($0)"
            let v35 : string = Fable.Core.RustInterop.emitRustExpr v33 v34 
            
            
            
            
            
            let v36 : bool = "Verbose" = v35
            let v40 : US2 =
                if v36 then
                    let v37 : US3 = US3_0
                    US2_0(v37)
                else
                    US2_1
            let v81 : US2 =
                match v40 with
                | US2_1 -> (* None *)
                    let v43 : bool = "Debug" = v35
                    let v47 : US2 =
                        if v43 then
                            let v44 : US3 = US3_1
                            US2_0(v44)
                        else
                            US2_1
                    match v47 with
                    | US2_1 -> (* None *)
                        let v50 : bool = "Info" = v35
                        let v54 : US2 =
                            if v50 then
                                let v51 : US3 = US3_2
                                US2_0(v51)
                            else
                                US2_1
                        match v54 with
                        | US2_1 -> (* None *)
                            let v57 : bool = "Warning" = v35
                            let v61 : US2 =
                                if v57 then
                                    let v58 : US3 = US3_3
                                    US2_0(v58)
                                else
                                    US2_1
                            match v61 with
                            | US2_1 -> (* None *)
                                let v64 : bool = "Critical" = v35
                                let v68 : US2 =
                                    if v64 then
                                        let v65 : US3 = US3_4
                                        US2_0(v65)
                                    else
                                        US2_1
                                match v68 with
                                | US2_1 -> (* None *)
                                    US2_1
                                | US2_0(v69) -> (* Some *)
                                    US2_0(v69)
                            | US2_0(v62) -> (* Some *)
                                US2_0(v62)
                        | US2_0(v55) -> (* Some *)
                            US2_0(v55)
                    | US2_0(v48) -> (* Some *)
                        US2_0(v48)
                | US2_0(v41) -> (* Some *)
                    US2_0(v41)
            US1_0(v81)
    let v92 : US2 =
        match v85 with
        | US1_0(v86) -> (* Some *)
            match v86 with
            | US2_0(v87) -> (* Some *)
                US2_0(v87)
            | _ ->
                US2_1
        | _ ->
            US2_1
    let v96 : US3 =
        match v92 with
        | US2_1 -> (* None *)
            US3_0
        | US2_0(v93) -> (* Some *)
            v93
    let v97 : unit = ()
    let v98 : (unit -> unit) = closure3(v96)
    let v99 : unit = (fun () -> v98 (); v97) ()
    let struct (v110 : Mut0, v111 : Mut1, v112 : Mut2, v113 : Mut3, v114 : int64 option) = State.trace_state.Value
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure7(v0)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v864 : std_pin_Pin<Box<Dyn<std_future_Future<Result<unit, anyhow_Error>>>>> = method11(v3)
    let v865 : string = $"tokio::runtime::Builder::new_multi_thread().enable_all().build().unwrap()"
    let v866 : _ = Fable.Core.RustInterop.emitRustExpr () v865 
    let v867 : string = "v866.handle().block_on($0)"
    let v868 : Result<unit, anyhow_Error> = Fable.Core.RustInterop.emitRustExpr v864 v867 
    let v869 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v868 v869 
    0
let v0 : ((string []) -> int32) = closure0()
let main args = v0 args
()
