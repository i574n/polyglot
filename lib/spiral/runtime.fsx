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
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0
    | US2_1
    | US2_2
and [<Struct>] US3 =
    | US3_0 of f0_0 : US2
    | US3_1 of f1_0 : US2
    | US3_2 of f2_0 : US2
    | US3_3 of f3_0 : US2
    | US3_4 of f4_0 : US2
and [<Struct>] US4 =
    | US4_0 of f0_0 : US0
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : string * f0_1 : US1
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
    | US11_0 of f0_0 : string * f0_1 : US1 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US11_1 of f1_0 : string
and [<Struct>] US12 =
    | US12_0 of f0_0 : US9 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US12_1 of f1_0 : string
and [<Struct>] US13 =
    | US13_0 of f0_0 : US1 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
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
let rec method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and closure1 () (v0 : string) : US1 =
    US1_0(v0)
and method4 () : (string -> US1) =
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
    let v29 : string = method3()
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
    let v64 : (string -> US1) = method4()
    let v65 : US1 option = v61 |> Option.map v64 
    let v76 : US1 = US1_1
    let v77 : US1 = v65 |> Option.defaultValue v76 
    let v84 : string =
        match v77 with
        | US1_1 -> (* None *)
            let v82 : string = ""
            v82
        | US1_0(v81) -> (* Some *)
            v81
    let _v1 = v84 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : US2 = US2_1
    let v86 : US3 = US3_0(v85)
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
    let v96 : (string -> US1) = method4()
    let v97 : US1 option = v93 |> Option.map v96 
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
and method5 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure2 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = method1()
    let v3 : string = method2(v2)
    
    
    
    
    
    let v4 : bool = "Verbose" = v3
    let v8 : US4 =
        if v4 then
            let v5 : US0 = US0_0
            US4_0(v5)
        else
            US4_1
    let v49 : US4 =
        match v8 with
        | US4_1 -> (* None *)
            let v11 : bool = "Debug" = v3
            let v15 : US4 =
                if v11 then
                    let v12 : US0 = US0_1
                    US4_0(v12)
                else
                    US4_1
            match v15 with
            | US4_1 -> (* None *)
                let v18 : bool = "Info" = v3
                let v22 : US4 =
                    if v18 then
                        let v19 : US0 = US0_2
                        US4_0(v19)
                    else
                        US4_1
                match v22 with
                | US4_1 -> (* None *)
                    let v25 : bool = "Warning" = v3
                    let v29 : US4 =
                        if v25 then
                            let v26 : US0 = US0_3
                            US4_0(v26)
                        else
                            US4_1
                    match v29 with
                    | US4_1 -> (* None *)
                        let v32 : bool = "Critical" = v3
                        let v36 : US4 =
                            if v32 then
                                let v33 : US0 = US0_4
                                US4_0(v33)
                            else
                                US4_1
                        match v36 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v37) -> (* Some *)
                            US4_0(v37)
                    | US4_0(v30) -> (* Some *)
                        US4_0(v30)
                | US4_0(v23) -> (* Some *)
                    US4_0(v23)
            | US4_0(v16) -> (* Some *)
                US4_0(v16)
        | US4_0(v9) -> (* Some *)
            US4_0(v9)
    let v50 : string = method5()
    let v51 : string = method2(v50)
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
    let v63 : US4 = US4_1
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
    let v178 : US5 =
        if v169 then
            US5_1
        else
            let v173 : string = $"near_sdk::env::block_timestamp()"
            let v174 : uint64 = Fable.Core.RustInterop.emitRustExpr () v173 
            let v175 : (uint64 -> int64) = int64
            let v176 : int64 = v175 v174
            US5_0(v176)
    let v179 : US4 = US4_1
    let _v1 = struct (v179, v178) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v180 : string = method1()
    let v181 : string = method2(v180)
    
    
    
    
    
    let v182 : bool = "Verbose" = v181
    let v186 : US4 =
        if v182 then
            let v183 : US0 = US0_0
            US4_0(v183)
        else
            US4_1
    let v227 : US4 =
        match v186 with
        | US4_1 -> (* None *)
            let v189 : bool = "Debug" = v181
            let v193 : US4 =
                if v189 then
                    let v190 : US0 = US0_1
                    US4_0(v190)
                else
                    US4_1
            match v193 with
            | US4_1 -> (* None *)
                let v196 : bool = "Info" = v181
                let v200 : US4 =
                    if v196 then
                        let v197 : US0 = US0_2
                        US4_0(v197)
                    else
                        US4_1
                match v200 with
                | US4_1 -> (* None *)
                    let v203 : bool = "Warning" = v181
                    let v207 : US4 =
                        if v203 then
                            let v204 : US0 = US0_3
                            US4_0(v204)
                        else
                            US4_1
                    match v207 with
                    | US4_1 -> (* None *)
                        let v210 : bool = "Critical" = v181
                        let v214 : US4 =
                            if v210 then
                                let v211 : US0 = US0_4
                                US4_0(v211)
                            else
                                US4_1
                        match v214 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v215) -> (* Some *)
                            US4_0(v215)
                    | US4_0(v208) -> (* Some *)
                        US4_0(v208)
                | US4_0(v201) -> (* Some *)
                    US4_0(v201)
            | US4_0(v194) -> (* Some *)
                US4_0(v194)
        | US4_0(v187) -> (* Some *)
            US4_0(v187)
    let v228 : string = method5()
    let v229 : string = method2(v228)
    let v230 : bool = v229 = "True"
    let v240 : US5 =
        if v230 then
            let v231 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v231
            US5_0(v235)
        else
            US5_1
    let _v1 = struct (v227, v240) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v241 : string = method1()
    let v242 : string = method2(v241)
    
    
    
    
    
    let v243 : bool = "Verbose" = v242
    let v247 : US4 =
        if v243 then
            let v244 : US0 = US0_0
            US4_0(v244)
        else
            US4_1
    let v288 : US4 =
        match v247 with
        | US4_1 -> (* None *)
            let v250 : bool = "Debug" = v242
            let v254 : US4 =
                if v250 then
                    let v251 : US0 = US0_1
                    US4_0(v251)
                else
                    US4_1
            match v254 with
            | US4_1 -> (* None *)
                let v257 : bool = "Info" = v242
                let v261 : US4 =
                    if v257 then
                        let v258 : US0 = US0_2
                        US4_0(v258)
                    else
                        US4_1
                match v261 with
                | US4_1 -> (* None *)
                    let v264 : bool = "Warning" = v242
                    let v268 : US4 =
                        if v264 then
                            let v265 : US0 = US0_3
                            US4_0(v265)
                        else
                            US4_1
                    match v268 with
                    | US4_1 -> (* None *)
                        let v271 : bool = "Critical" = v242
                        let v275 : US4 =
                            if v271 then
                                let v272 : US0 = US0_4
                                US4_0(v272)
                            else
                                US4_1
                        match v275 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v276) -> (* Some *)
                            US4_0(v276)
                    | US4_0(v269) -> (* Some *)
                        US4_0(v269)
                | US4_0(v262) -> (* Some *)
                    US4_0(v262)
            | US4_0(v255) -> (* Some *)
                US4_0(v255)
        | US4_0(v248) -> (* Some *)
            US4_0(v248)
    let v289 : string = method5()
    let v290 : string = method2(v289)
    let v291 : bool = v290 = "True"
    let v301 : US5 =
        if v291 then
            let v292 : System.DateTime = System.DateTime.Now
            let v295 : (System.DateTime -> int64) = _.Ticks
            let v296 : int64 = v295 v292
            US5_0(v296)
        else
            US5_1
    let _v1 = struct (v288, v301) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v302 : string = method1()
    let v303 : string = method2(v302)
    
    
    
    
    
    let v304 : bool = "Verbose" = v303
    let v308 : US4 =
        if v304 then
            let v305 : US0 = US0_0
            US4_0(v305)
        else
            US4_1
    let v349 : US4 =
        match v308 with
        | US4_1 -> (* None *)
            let v311 : bool = "Debug" = v303
            let v315 : US4 =
                if v311 then
                    let v312 : US0 = US0_1
                    US4_0(v312)
                else
                    US4_1
            match v315 with
            | US4_1 -> (* None *)
                let v318 : bool = "Info" = v303
                let v322 : US4 =
                    if v318 then
                        let v319 : US0 = US0_2
                        US4_0(v319)
                    else
                        US4_1
                match v322 with
                | US4_1 -> (* None *)
                    let v325 : bool = "Warning" = v303
                    let v329 : US4 =
                        if v325 then
                            let v326 : US0 = US0_3
                            US4_0(v326)
                        else
                            US4_1
                    match v329 with
                    | US4_1 -> (* None *)
                        let v332 : bool = "Critical" = v303
                        let v336 : US4 =
                            if v332 then
                                let v333 : US0 = US0_4
                                US4_0(v333)
                            else
                                US4_1
                        match v336 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v337) -> (* Some *)
                            US4_0(v337)
                    | US4_0(v330) -> (* Some *)
                        US4_0(v330)
                | US4_0(v323) -> (* Some *)
                    US4_0(v323)
            | US4_0(v316) -> (* Some *)
                US4_0(v316)
        | US4_0(v309) -> (* Some *)
            US4_0(v309)
    let v350 : string = method5()
    let v351 : string = method2(v350)
    let v352 : bool = v351 = "True"
    let v362 : US5 =
        if v352 then
            let v353 : System.DateTime = System.DateTime.Now
            let v356 : (System.DateTime -> int64) = _.Ticks
            let v357 : int64 = v356 v353
            US5_0(v357)
        else
            US5_1
    let _v1 = struct (v349, v362) 
    #endif
#else
    let v363 : string = method1()
    let v364 : string = method2(v363)
    
    
    
    
    
    let v365 : bool = "Verbose" = v364
    let v369 : US4 =
        if v365 then
            let v366 : US0 = US0_0
            US4_0(v366)
        else
            US4_1
    let v410 : US4 =
        match v369 with
        | US4_1 -> (* None *)
            let v372 : bool = "Debug" = v364
            let v376 : US4 =
                if v372 then
                    let v373 : US0 = US0_1
                    US4_0(v373)
                else
                    US4_1
            match v376 with
            | US4_1 -> (* None *)
                let v379 : bool = "Info" = v364
                let v383 : US4 =
                    if v379 then
                        let v380 : US0 = US0_2
                        US4_0(v380)
                    else
                        US4_1
                match v383 with
                | US4_1 -> (* None *)
                    let v386 : bool = "Warning" = v364
                    let v390 : US4 =
                        if v386 then
                            let v387 : US0 = US0_3
                            US4_0(v387)
                        else
                            US4_1
                    match v390 with
                    | US4_1 -> (* None *)
                        let v393 : bool = "Critical" = v364
                        let v397 : US4 =
                            if v393 then
                                let v394 : US0 = US0_4
                                US4_0(v394)
                            else
                                US4_1
                        match v397 with
                        | US4_1 -> (* None *)
                            US4_1
                        | US4_0(v398) -> (* Some *)
                            US4_0(v398)
                    | US4_0(v391) -> (* Some *)
                        US4_0(v391)
                | US4_0(v384) -> (* Some *)
                    US4_0(v384)
            | US4_0(v377) -> (* Some *)
                US4_0(v377)
        | US4_0(v370) -> (* Some *)
            US4_0(v370)
    let v411 : string = method5()
    let v412 : string = method2(v411)
    let v413 : bool = v412 = "True"
    let v423 : US5 =
        if v413 then
            let v414 : System.DateTime = System.DateTime.Now
            let v417 : (System.DateTime -> int64) = _.Ticks
            let v418 : int64 = v417 v414
            US5_0(v418)
        else
            US5_1
    let _v1 = struct (v410, v423) 
    #endif
    let struct (v424 : US4, v425 : US5) = _v1 
    let v489 : Mut0 = {l0 = 1L} : Mut0
    let v490 : (string -> unit) = closure2()
    let v491 : Mut1 = {l0 = v490} : Mut1
    let v492 : Mut2 = {l0 = true} : Mut2
    let v493 : string = ""
    let v494 : Mut3 = {l0 = v493} : Mut3
    let v497 : US0 =
        match v424 with
        | US4_1 -> (* None *)
            v0
        | US4_0(v495) -> (* Some *)
            v495
    let v498 : Mut4 = {l0 = v497} : Mut4
    let v505 : int64 option =
        match v425 with
        | US5_1 -> (* None *)
            let v503 : int64 option = None
            v503
        | US5_0(v499) -> (* Some *)
            let v500 : int64 option = Some v499 
            v500
    struct (v489, v491, v492, v494, v498, v505)
and closure0 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and method6 (v0 : US0) : bool =
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
and closure6 () (v0 : int64) : US5 =
    US5_0(v0)
and method8 () : (int64 -> US5) =
    closure6()
and method9 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method10 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method7 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US5) = method8()
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
    let v61 : string = method9()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US5) = method8()
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
    let v122 : string = method9()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US5) = method8()
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
    let v164 : (int64 -> US5) = method8()
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
    let v218 : string = method10()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US5) = method8()
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
    let v279 : string = method10()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v286 : (int64 -> US5) = method8()
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
    let v340 : string = method10()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
#else
    let v347 : (int64 -> US5) = method8()
    let v348 : US5 option = v5 |> Option.map v347 
    let v359 : US5 = US5_1
    let v360 : US5 = v348 |> Option.defaultValue v359 
    let v400 : System.DateTime =
        match v360 with
        | US5_1 -> (* None *)
            let v396 : System.DateTime = System.DateTime.Now
            v396
        | US5_0(v364) -> (* Some *)
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
    let v401 : string = method10()
    let v404 : (string -> string) = v400.ToString
    let v405 : string = v404 v401
    let _v6 = v405 
    #endif
    let v408 : string = _v6 
    v408
and method13 () : string =
    let v0 : string = ""
    v0
and closure7 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method12 (v0 : char) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = $"{v0}"
    let v6 : unit = ()
    let v7 : (unit -> unit) = closure7(v2, v3)
    let v8 : unit = (fun () -> v7 (); v6) ()
    let v11 : string = v2.l0
    v11
and method14 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method11 () : string =
    
    
    
    
    
    let v0 : string = "Warning"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[93m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[93m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[93m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method16 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method17 (v0 : string) : string =
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
and method15 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method16()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 3"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
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
and method18 (v0 : string) : unit =
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
and closure5 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method15(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and method19 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method16()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 2"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
and closure11 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method19(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
and method20 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string) : string =
    let v8 : string = method16()
    let v9 : int64 = v0.l0
    let v10 : string = "runtime.current_process_kill / exiting... 1"
    let v11 : string = $"{v6} {v7} #{v9} %s{v10} / {v8}"
    method17(v11)
and closure12 () () : unit =
    let v0 : US0 = US0_3
    let v1 : bool = method6(v0)
    if v1 then
        let v2 : unit = ()
        let v3 : (unit -> unit) = closure0()
        let v4 : unit = (fun () -> v3 (); v2) ()
        let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
        let v36 : string = method7(v18, v19, v20, v21, v22, v23)
        let v37 : string = method11()
        let v38 : string = method20(v18, v19, v20, v21, v22, v23, v36, v37)
        method18(v38)
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
and method23 () : string =
    let v0 : string = ""
    v0
and method24 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure16 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure15 () (v0 : char) : (UH0 -> UH0) =
    closure16(v0)
and method25 () : (char -> (UH0 -> UH0)) =
    closure15()
and method26 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        let v19 : System.Text.StringBuilder =
            if v6 then
                let v11 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v12 : System.Text.StringBuilder = v11 ()
                v1
            else
                let v13 : (char -> string) = _.ToString()
                let v14 : string = v13 v4
                let v17 : (string -> System.Text.StringBuilder) = v1.Append
                let v18 : System.Text.StringBuilder = v17 v14
                v1
        method26(v5, v19, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure14 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US7 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
        US7_1(v5)
    else
        let v7 : char = v0.[int 0]
        let v8 : bool = v7 = '"'
        if v8 then
            let v9 : (string -> int32) = String.length
            let v10 : int32 = v9 v0
            let v11 : (int32 -> int32) = int32
            let v12 : int32 = v11 1
            let v13 : (int32 -> int32) = int32
            let v14 : int32 = v13 v10
            let v15 : string = v0.[int v12..int v14]
            let v16 : (char -> string) = _.ToString()
            let v17 : string = v16 v7
            let v20 : int32 = v17.Length
            let v21 : (char []) = Array.zeroCreate<char> (v20)
            let v22 : Mut5 = {l0 = 0} : Mut5
            while method24(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method25()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method26(v33, v1, v2, v3)
            US7_0(v7, v15, v38, v39, v40)
        else
            let v42 : (string -> int32) = String.length
            let v43 : int32 = v42 v0
            let v44 : string = "\n"
            let v45 : int32 = v0.IndexOf v44 
            let v46 : int32 = v45 - 1
            let v47 : bool = -2 = v46
            let v48 : int32 =
                if v47 then
                    v43
                else
                    v46
            let v49 : (int32 -> int32) = int32
            let v50 : int32 = v49 0
            let v51 : (int32 -> int32) = int32
            let v52 : int32 = v51 v48
            let v53 : string = v0.[int v50..int v52]
            let v54 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v53}"
            let v55 : int32 = v3 - 1
            let v56 : (int32 -> (string -> string)) = String.replicate
            let v57 : (string -> string) = v56 v55
            let v58 : string = " "
            let v59 : string = v57 v58
            let v62 : string = "^"
            let v63 : string = v59 + v62 
            let v64 : string = $"{v54}
{v63}
"
            US7_1(v64)
and closure17 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US7 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
        US7_1(v5)
    else
        let v7 : char = v0.[int 0]
        let v8 : bool = v7 = '''
        if v8 then
            let v9 : (string -> int32) = String.length
            let v10 : int32 = v9 v0
            let v11 : (int32 -> int32) = int32
            let v12 : int32 = v11 1
            let v13 : (int32 -> int32) = int32
            let v14 : int32 = v13 v10
            let v15 : string = v0.[int v12..int v14]
            let v16 : (char -> string) = _.ToString()
            let v17 : string = v16 v7
            let v20 : int32 = v17.Length
            let v21 : (char []) = Array.zeroCreate<char> (v20)
            let v22 : Mut5 = {l0 = 0} : Mut5
            while method24(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method25()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method26(v33, v1, v2, v3)
            US7_0(v7, v15, v38, v39, v40)
        else
            let v42 : (string -> int32) = String.length
            let v43 : int32 = v42 v0
            let v44 : string = "\n"
            let v45 : int32 = v0.IndexOf v44 
            let v46 : int32 = v45 - 1
            let v47 : bool = -2 = v46
            let v48 : int32 =
                if v47 then
                    v43
                else
                    v46
            let v49 : (int32 -> int32) = int32
            let v50 : int32 = v49 0
            let v51 : (int32 -> int32) = int32
            let v52 : int32 = v51 v48
            let v53 : string = v0.[int v50..int v52]
            let v54 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v53}"
            let v55 : int32 = v3 - 1
            let v56 : (int32 -> (string -> string)) = String.replicate
            let v57 : (string -> string) = v56 v55
            let v58 : string = " "
            let v59 : string = v57 v58
            let v62 : string = "^"
            let v63 : string = v59 + v62 
            let v64 : string = $"{v54}
{v63}
"
            US7_1(v64)
and method27 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US7 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US7 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US7_1(v13) -> (* Error *)
            method27(v0, v1, v6)
        | US7_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "choice / no parsers succeeded"
        US7_1(v3)
and method28 (v0 : char, v1 : int64) : bool =
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
            method28(v0, v17)
and method29 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US8 =
    let v5 : bool = "" = v1
    let v70 : US7 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ''' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : (char list -> (char [])) = List.toArray
            let v14 : (char []) = v13 v10
            let v17 : string = $"parsing.none_of / unexpected end of input / chars: %A{v14} / s: %A{struct (v2, v3, v4)}"
            US7_1(v17)
        else
            let v19 : char = v1.[int 0]
            let v20 : (string -> int32) = String.length
            let v21 : int32 = v20 v1
            let v22 : (int32 -> int32) = int32
            let v23 : int32 = v22 1
            let v24 : (int32 -> int32) = int32
            let v25 : int32 = v24 v21
            let v26 : string = v1.[int v23..int v25]
            let v27 : int64 = 0L
            let v28 : bool = method28(v19, v27)
            let v29 : bool = v28 = false
            if v29 then
                let v30 : (char -> string) = _.ToString()
                let v31 : string = v30 v19
                let v34 : int32 = v31.Length
                let v35 : (char []) = Array.zeroCreate<char> (v34)
                let v36 : Mut5 = {l0 = 0} : Mut5
                while method24(v34, v36) do
                    let v38 : int32 = v36.l0
                    let v39 : char = v31.[int v38]
                    v35.[int v38] <- v39
                    let v40 : int32 = v38 + 1
                    v36.l0 <- v40
                    ()
                let v41 : char list = v35 |> Array.toList
                let v42 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v43 : (char -> (UH0 -> UH0)) = method25()
                let v44 : (char list -> (UH0 -> UH0)) = v42 v43
                let v45 : (UH0 -> UH0) = v44 v41
                let v46 : UH0 = UH0_0
                let v47 : UH0 = v45 v46
                let struct (v52 : System.Text.StringBuilder, v53 : int32, v54 : int32) = method26(v47, v2, v3, v4)
                US7_0(v19, v26, v52, v53, v54)
            else
                let v56 : char list = []
                let v57 : char list = ''' :: v56 
                let v60 : char list = '"' :: v57 
                let v63 : (char list -> (char [])) = List.toArray
                let v64 : (char []) = v63 v60
                let v67 : string = $"parsing.none_of / unexpected char: '{v19}' / chars: %A{v64} / s: %A{struct (v2, v3, v4)}"
                US7_1(v67)
    let v82 : US7 =
        match v70 with
        | US7_1(v79) -> (* Error *)
            US7_1(v79)
        | US7_0(v71, v72, v73, v74, v75) -> (* Ok *)
            let v76 : bool = '\\' = v71
            let v77 : char =
                if v76 then
                    '/'
                else
                    v71
            US7_0(v77, v72, v73, v74, v75)
    match v82 with
    | US7_1(v94) -> (* Error *)
        US8_0(v0, v1, v2, v3, v4)
    | US7_0(v83, v84, v85, v86, v87) -> (* Ok *)
        let v88 : (char -> string) = _.ToString()
        let v89 : string = v88 v83
        let v92 : string = v0 + v89 
        method29(v92, v84, v85, v86, v87)
and method30 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US7 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US7 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US7_1(v15) -> (* Error *)
            method30(v0, v1, v2, v3, v8)
        | US7_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US7_1(v5)
and method31 (v0 : char, v1 : int64) : bool =
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
            method31(v0, v21)
and method32 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US8 =
    let v5 : bool = "" = v1
    let v76 : US7 =
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
            let v22 : char = v1.[int 0]
            let v23 : (string -> int32) = String.length
            let v24 : int32 = v23 v1
            let v25 : (int32 -> int32) = int32
            let v26 : int32 = v25 1
            let v27 : (int32 -> int32) = int32
            let v28 : int32 = v27 v24
            let v29 : string = v1.[int v26..int v28]
            let v30 : int64 = 0L
            let v31 : bool = method31(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method24(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method25()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method26(v50, v2, v3, v4)
                US7_0(v22, v29, v55, v56, v57)
            else
                let v59 : char list = []
                let v60 : char list = ' ' :: v59 
                let v63 : char list = ''' :: v60 
                let v66 : char list = '"' :: v63 
                let v69 : (char list -> (char [])) = List.toArray
                let v70 : (char []) = v69 v66
                let v73 : string = $"parsing.none_of / unexpected char: '{v22}' / chars: %A{v70} / s: %A{struct (v2, v3, v4)}"
                US7_1(v73)
    let v88 : US7 =
        match v76 with
        | US7_1(v85) -> (* Error *)
            US7_1(v85)
        | US7_0(v77, v78, v79, v80, v81) -> (* Ok *)
            let v82 : bool = '\\' = v77
            let v83 : char =
                if v82 then
                    '/'
                else
                    v77
            US7_0(v83, v78, v79, v80, v81)
    match v88 with
    | US7_1(v100) -> (* Error *)
        US8_0(v0, v1, v2, v3, v4)
    | US7_0(v89, v90, v91, v92, v93) -> (* Ok *)
        let v94 : (char -> string) = _.ToString()
        let v95 : string = v94 v89
        let v98 : string = v0 + v95 
        method32(v98, v90, v91, v92, v93)
and method33 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method33(v0, v6)
        else
            v1
and method34 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US8 =
    let v5 : bool = "" = v1
    let v42 : US7 =
        if v5 then
            let v6 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US7_1(v6)
        else
            let v8 : char = v1.[int 0]
            let v9 : (string -> int32) = String.length
            let v10 : int32 = v9 v1
            let v11 : (int32 -> int32) = int32
            let v12 : int32 = v11 1
            let v13 : (int32 -> int32) = int32
            let v14 : int32 = v13 v10
            let v15 : string = v1.[int v12..int v14]
            let v16 : (char -> string) = _.ToString()
            let v17 : string = v16 v8
            let v20 : int32 = v17.Length
            let v21 : (char []) = Array.zeroCreate<char> (v20)
            let v22 : Mut5 = {l0 = 0} : Mut5
            while method24(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method25()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method26(v33, v2, v3, v4)
            US7_0(v8, v15, v38, v39, v40)
    match v42 with
    | US7_1(v54) -> (* Error *)
        US8_0(v0, v1, v2, v3, v4)
    | US7_0(v43, v44, v45, v46, v47) -> (* Ok *)
        let v48 : (char -> string) = _.ToString()
        let v49 : string = v48 v43
        let v52 : string = v0 + v49 
        method34(v52, v44, v45, v46, v47)
and method22 (v0 : string) : US6 =
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
    let v10 : string = method23()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v13 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure14()
    let v14 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US7) = closure17()
    let v15 : UH1 = UH1_0
    let v16 : UH1 = UH1_1(v14, v15)
    let v17 : UH1 = UH1_1(v13, v16)
    let v18 : US7 = method27(v7, v12, v17)
    let v154 : US8 =
        match v18 with
        | US7_1(v151) -> (* Error *)
            US8_1(v151)
        | US7_0(v19, v20, v21, v22, v23) -> (* Ok *)
            let v24 : bool = "" = v20
            let v89 : US7 =
                if v24 then
                    let v25 : char list = []
                    let v26 : char list = ''' :: v25 
                    let v29 : char list = '"' :: v26 
                    let v32 : (char list -> (char [])) = List.toArray
                    let v33 : (char []) = v32 v29
                    let v36 : string = $"parsing.none_of / unexpected end of input / chars: %A{v33} / s: %A{struct (v21, v22, v23)}"
                    US7_1(v36)
                else
                    let v38 : char = v20.[int 0]
                    let v39 : (string -> int32) = String.length
                    let v40 : int32 = v39 v20
                    let v41 : (int32 -> int32) = int32
                    let v42 : int32 = v41 1
                    let v43 : (int32 -> int32) = int32
                    let v44 : int32 = v43 v40
                    let v45 : string = v20.[int v42..int v44]
                    let v46 : int64 = 0L
                    let v47 : bool = method28(v38, v46)
                    let v48 : bool = v47 = false
                    if v48 then
                        let v49 : (char -> string) = _.ToString()
                        let v50 : string = v49 v38
                        let v53 : int32 = v50.Length
                        let v54 : (char []) = Array.zeroCreate<char> (v53)
                        let v55 : Mut5 = {l0 = 0} : Mut5
                        while method24(v53, v55) do
                            let v57 : int32 = v55.l0
                            let v58 : char = v50.[int v57]
                            v54.[int v57] <- v58
                            let v59 : int32 = v57 + 1
                            v55.l0 <- v59
                            ()
                        let v60 : char list = v54 |> Array.toList
                        let v61 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v62 : (char -> (UH0 -> UH0)) = method25()
                        let v63 : (char list -> (UH0 -> UH0)) = v61 v62
                        let v64 : (UH0 -> UH0) = v63 v60
                        let v65 : UH0 = UH0_0
                        let v66 : UH0 = v64 v65
                        let struct (v71 : System.Text.StringBuilder, v72 : int32, v73 : int32) = method26(v66, v21, v22, v23)
                        US7_0(v38, v45, v71, v72, v73)
                    else
                        let v75 : char list = []
                        let v76 : char list = ''' :: v75 
                        let v79 : char list = '"' :: v76 
                        let v82 : (char list -> (char [])) = List.toArray
                        let v83 : (char []) = v82 v79
                        let v86 : string = $"parsing.none_of / unexpected char: '{v38}' / chars: %A{v83} / s: %A{struct (v21, v22, v23)}"
                        US7_1(v86)
            let v101 : US7 =
                match v89 with
                | US7_1(v98) -> (* Error *)
                    US7_1(v98)
                | US7_0(v90, v91, v92, v93, v94) -> (* Ok *)
                    let v95 : bool = '\\' = v90
                    let v96 : char =
                        if v95 then
                            '/'
                        else
                            v90
                    US7_0(v96, v91, v92, v93, v94)
            let v115 : US8 =
                match v101 with
                | US7_1(v102) -> (* Error *)
                    US8_1(v102)
                | US7_0(v104, v105, v106, v107, v108) -> (* Ok *)
                    let v109 : (char -> string) = _.ToString()
                    let v110 : string = v109 v104
                    method29(v110, v105, v106, v107, v108)
            let v125 : US8 =
                match v115 with
                | US8_1(v122) -> (* Error *)
                    US8_0(v6, v20, v21, v22, v23)
                | US8_0(v116, v117, v118, v119, v120) -> (* Ok *)
                    US8_0(v116, v117, v118, v119, v120)
            match v125 with
            | US8_1(v146) -> (* Error *)
                let v147 : string = "between / expected content"
                US8_1(v147)
            | US8_0(v126, v127, v128, v129, v130) -> (* Ok *)
                let v131 : UH1 = UH1_0
                let v132 : UH1 = UH1_1(v14, v131)
                let v133 : UH1 = UH1_1(v13, v132)
                let v134 : US7 = method30(v127, v128, v129, v130, v133)
                match v134 with
                | US7_1(v141) -> (* Error *)
                    let v142 : string = $"between / expected closing delimiter / e: %A{v141} / input: %A{struct (v7, v12, 1, 1)} / rest1: %A{struct (v20, v21, v22, v23)} / rest2: %A{struct (v127, v128, v129, v130)}"
                    US8_1(v142)
                | US7_0(v135, v136, v137, v138, v139) -> (* Ok *)
                    US8_0(v126, v136, v137, v138, v139)
    let v304 : US8 =
        match v154 with
        | US8_1(v160) -> (* Error *)
            let v161 : bool = "" = v7
            let v234 : US7 =
                if v161 then
                    let v162 : char list = []
                    let v163 : char list = ' ' :: v162 
                    let v166 : char list = ''' :: v163 
                    let v169 : char list = '"' :: v166 
                    let v172 : (char list -> (char [])) = List.toArray
                    let v173 : (char []) = v172 v169
                    let v176 : string = $"parsing.none_of / unexpected end of input / chars: %A{v173} / s: %A{struct (v12, 1, 1)}"
                    US7_1(v176)
                else
                    let v178 : char = v7.[int 0]
                    let v179 : (string -> int32) = String.length
                    let v180 : int32 = v179 v7
                    let v181 : (int32 -> int32) = int32
                    let v182 : int32 = v181 1
                    let v183 : (int32 -> int32) = int32
                    let v184 : int32 = v183 v180
                    let v185 : string = v7.[int v182..int v184]
                    let v186 : int64 = 0L
                    let v187 : bool = method31(v178, v186)
                    let v188 : bool = v187 = false
                    if v188 then
                        let v189 : (char -> string) = _.ToString()
                        let v190 : string = v189 v178
                        let v193 : int32 = v190.Length
                        let v194 : (char []) = Array.zeroCreate<char> (v193)
                        let v195 : Mut5 = {l0 = 0} : Mut5
                        while method24(v193, v195) do
                            let v197 : int32 = v195.l0
                            let v198 : char = v190.[int v197]
                            v194.[int v197] <- v198
                            let v199 : int32 = v197 + 1
                            v195.l0 <- v199
                            ()
                        let v200 : char list = v194 |> Array.toList
                        let v201 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v202 : (char -> (UH0 -> UH0)) = method25()
                        let v203 : (char list -> (UH0 -> UH0)) = v201 v202
                        let v204 : (UH0 -> UH0) = v203 v200
                        let v205 : UH0 = UH0_0
                        let v206 : UH0 = v204 v205
                        let v211 : int32 = 1
                        let v212 : int32 = 1
                        let struct (v213 : System.Text.StringBuilder, v214 : int32, v215 : int32) = method26(v206, v12, v211, v212)
                        US7_0(v178, v185, v213, v214, v215)
                    else
                        let v217 : char list = []
                        let v218 : char list = ' ' :: v217 
                        let v221 : char list = ''' :: v218 
                        let v224 : char list = '"' :: v221 
                        let v227 : (char list -> (char [])) = List.toArray
                        let v228 : (char []) = v227 v224
                        let v231 : string = $"parsing.none_of / unexpected char: '{v178}' / chars: %A{v228} / s: %A{struct (v12, 1, 1)}"
                        US7_1(v231)
            let v246 : US7 =
                match v234 with
                | US7_1(v243) -> (* Error *)
                    US7_1(v243)
                | US7_0(v235, v236, v237, v238, v239) -> (* Ok *)
                    let v240 : bool = '\\' = v235
                    let v241 : char =
                        if v240 then
                            '/'
                        else
                            v235
                    US7_0(v241, v236, v237, v238, v239)
            let v260 : US8 =
                match v246 with
                | US7_1(v247) -> (* Error *)
                    US8_1(v247)
                | US7_0(v249, v250, v251, v252, v253) -> (* Ok *)
                    let v254 : (char -> string) = _.ToString()
                    let v255 : string = v254 v249
                    method32(v255, v250, v251, v252, v253)
            match v260 with
            | US8_1(v266) -> (* Error *)
                let v267 : int32 = v7.Length
                let v268 : bool = v267 = 0
                let v272 : US10 =
                    if v268 then
                        US10_0(v7, v12, 1, 1)
                    else
                        let v270 : string = $"parsing.eof / expected end of input / input: %A{v7}"
                        US10_1(v270)
                let v281 : US8 =
                    match v272 with
                    | US10_1(v278) -> (* Error *)
                        US8_1(v278)
                    | US10_0(v273, v274, v275, v276) -> (* Ok *)
                        US8_0(v6, v273, v274, v275, v276)
                match v281 with
                | US8_1(v297) -> (* Error *)
                    US8_1(v297)
                | US8_0(v282, v283, v284, v285, v286) -> (* Ok *)
                    let v287 : int32 = 0
                    let v288 : int32 = method33(v283, v287)
                    let v289 : (string -> int32) = String.length
                    let v290 : int32 = v289 v283
                    let v291 : (int32 -> int32) = int32
                    let v292 : int32 = v291 v288
                    let v293 : (int32 -> int32) = int32
                    let v294 : int32 = v293 v290
                    let v295 : string = v283.[int v292..int v294]
                    US8_0(v282, v295, v284, v285, v286)
            | US8_0(v261, v262, v263, v264, v265) -> (* Ok *)
                v260
        | US8_0(v155, v156, v157, v158, v159) -> (* Ok *)
            v154
    let v472 : US11 =
        match v304 with
        | US8_1(v469) -> (* Error *)
            US11_1(v469)
        | US8_0(v305, v306, v307, v308, v309) -> (* Ok *)
            let v310 : bool = "" = v306
            let v373 : US7 =
                if v310 then
                    let v311 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v307, v308, v309)}"
                    US7_1(v311)
                else
                    let v313 : char = v306.[int 0]
                    let v314 : bool = v313 = ' '
                    if v314 then
                        let v315 : (string -> int32) = String.length
                        let v316 : int32 = v315 v306
                        let v317 : (int32 -> int32) = int32
                        let v318 : int32 = v317 1
                        let v319 : (int32 -> int32) = int32
                        let v320 : int32 = v319 v316
                        let v321 : string = v306.[int v318..int v320]
                        let v322 : (char -> string) = _.ToString()
                        let v323 : string = v322 v313
                        let v326 : int32 = v323.Length
                        let v327 : (char []) = Array.zeroCreate<char> (v326)
                        let v328 : Mut5 = {l0 = 0} : Mut5
                        while method24(v326, v328) do
                            let v330 : int32 = v328.l0
                            let v331 : char = v323.[int v330]
                            v327.[int v330] <- v331
                            let v332 : int32 = v330 + 1
                            v328.l0 <- v332
                            ()
                        let v333 : char list = v327 |> Array.toList
                        let v334 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v335 : (char -> (UH0 -> UH0)) = method25()
                        let v336 : (char list -> (UH0 -> UH0)) = v334 v335
                        let v337 : (UH0 -> UH0) = v336 v333
                        let v338 : UH0 = UH0_0
                        let v339 : UH0 = v337 v338
                        let struct (v344 : System.Text.StringBuilder, v345 : int32, v346 : int32) = method26(v339, v307, v308, v309)
                        US7_0(v313, v321, v344, v345, v346)
                    else
                        let v348 : (string -> int32) = String.length
                        let v349 : int32 = v348 v306
                        let v350 : string = "\n"
                        let v351 : int32 = v306.IndexOf v350 
                        let v352 : int32 = v351 - 1
                        let v353 : bool = -2 = v352
                        let v354 : int32 =
                            if v353 then
                                v349
                            else
                                v352
                        let v355 : (int32 -> int32) = int32
                        let v356 : int32 = v355 0
                        let v357 : (int32 -> int32) = int32
                        let v358 : int32 = v357 v354
                        let v359 : string = v306.[int v356..int v358]
                        let v360 : string = $"parsing.p_char / expected: '{' '}' / line: {v308} / col: {v309}
{v307}{v359}"
                        let v361 : int32 = v309 - 1
                        let v362 : (int32 -> (string -> string)) = String.replicate
                        let v363 : (string -> string) = v362 v361
                        let v364 : string = " "
                        let v365 : string = v363 v364
                        let v368 : string = "^"
                        let v369 : string = v365 + v368 
                        let v370 : string = $"{v360}
{v369}
"
                        US7_1(v370)
            let v385 : US12 =
                match v373 with
                | US7_1(v381) -> (* Error *)
                    let v382 : US9 = US9_1
                    US12_0(v382, v306, v307, v308, v309)
                | US7_0(v374, v375, v376, v377, v378) -> (* Ok *)
                    let v379 : US9 = US9_0(v374)
                    US12_0(v379, v375, v376, v377, v378)
            let v446 : US8 =
                match v385 with
                | US12_1(v443) -> (* Error *)
                    US8_1(v443)
                | US12_0(v386, v387, v388, v389, v390) -> (* Ok *)
                    let v391 : bool = "" = v387
                    let v428 : US7 =
                        if v391 then
                            let v392 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v388, v389, v390)}"
                            US7_1(v392)
                        else
                            let v394 : char = v387.[int 0]
                            let v395 : (string -> int32) = String.length
                            let v396 : int32 = v395 v387
                            let v397 : (int32 -> int32) = int32
                            let v398 : int32 = v397 1
                            let v399 : (int32 -> int32) = int32
                            let v400 : int32 = v399 v396
                            let v401 : string = v387.[int v398..int v400]
                            let v402 : (char -> string) = _.ToString()
                            let v403 : string = v402 v394
                            let v406 : int32 = v403.Length
                            let v407 : (char []) = Array.zeroCreate<char> (v406)
                            let v408 : Mut5 = {l0 = 0} : Mut5
                            while method24(v406, v408) do
                                let v410 : int32 = v408.l0
                                let v411 : char = v403.[int v410]
                                v407.[int v410] <- v411
                                let v412 : int32 = v410 + 1
                                v408.l0 <- v412
                                ()
                            let v413 : char list = v407 |> Array.toList
                            let v414 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v415 : (char -> (UH0 -> UH0)) = method25()
                            let v416 : (char list -> (UH0 -> UH0)) = v414 v415
                            let v417 : (UH0 -> UH0) = v416 v413
                            let v418 : UH0 = UH0_0
                            let v419 : UH0 = v417 v418
                            let struct (v424 : System.Text.StringBuilder, v425 : int32, v426 : int32) = method26(v419, v388, v389, v390)
                            US7_0(v394, v401, v424, v425, v426)
                    match v428 with
                    | US7_1(v429) -> (* Error *)
                        US8_1(v429)
                    | US7_0(v431, v432, v433, v434, v435) -> (* Ok *)
                        let v436 : (char -> string) = _.ToString()
                        let v437 : string = v436 v431
                        method34(v437, v432, v433, v434, v435)
            let v458 : US13 =
                match v446 with
                | US8_1(v454) -> (* Error *)
                    let v455 : US1 = US1_1
                    US13_0(v455, v306, v307, v308, v309)
                | US8_0(v447, v448, v449, v450, v451) -> (* Ok *)
                    let v452 : US1 = US1_0(v447)
                    US13_0(v452, v448, v449, v450, v451)
            match v458 with
            | US13_1(v465) -> (* Error *)
                US11_1(v465)
            | US13_0(v459, v460, v461, v462, v463) -> (* Ok *)
                US11_0(v305, v459, v460, v461, v462, v463)
    match v472 with
    | US11_1(v480) -> (* Error *)
        US6_1(v480)
    | US11_0(v473, v474, v475, v476, v477, v478) -> (* Ok *)
        US6_0(v473, v474)
and method35 () : string =
    
    
    
    
    
    let v0 : string = "Debug"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[94m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[94m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[94m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method37 (v0 : string, v1 : US1, v2 : string, v3 : System.Threading.CancellationToken option, v4 : (struct (string * string) []), v5 : (struct (int32 * string * bool) -> Async<unit>) option, v6 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v7 : bool, v8 : string option) : string =
    let v9 : string = method13()
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
and method36 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string, v9 : US1, v10 : string, v11 : System.Threading.CancellationToken option, v12 : (struct (string * string) []), v13 : (struct (int32 * string * bool) -> Async<unit>) option, v14 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v15 : bool, v16 : string option) : string =
    let v17 : string = method37(v8, v9, v10, v11, v12, v13, v14, v15, v16)
    let v18 : int64 = v0.l0
    let v19 : string = "runtime.execute_with_options_async"
    let v20 : string = $"{v6} {v7} #{v18} %s{v19} / {v17}"
    method17(v20)
and closure18 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : US1, v8 : string) () : unit =
    let v9 : US0 = US0_1
    let v10 : bool = method6(v9)
    if v10 then
        let v11 : unit = ()
        let v12 : (unit -> unit) = closure0()
        let v13 : unit = (fun () -> v12 (); v11) ()
        let struct (v27 : Mut0, v28 : Mut1, v29 : Mut2, v30 : Mut3, v31 : Mut4, v32 : int64 option) = TraceState.trace_state.Value
        let v45 : string = method7(v27, v28, v29, v30, v31, v32)
        let v46 : string = method35()
        let v47 : string = method36(v27, v28, v29, v30, v31, v32, v45, v46, v8, v7, v0, v1, v2, v3, v4, v5, v6)
        method18(v47)
and method38 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : (struct (string * string) []) =
    v2
and closure20 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US14 =
    US14_0(v0)
and method39 () : ((struct (int32 * string * bool) -> Async<unit>) -> US14) =
    closure20()
and method40 () : string =
    
    
    
    
    
    let v0 : string = "Verbose"
    let v1 : (unit -> string) = v0.ToLower
    let v2 : string = v1 ()
    let v5 : char = v2.[int 0]
    let v6 : string = method12(v5)
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
    let v105 : string = method14()
    let v106 : string = v104 + v6 
    let v107 : string = v106 + v105 
    let _v7 = v107 
    #endif
#if FABLE_COMPILER_PYTHON
    let v108 : string = "\u001b[90m"
    let v109 : string = method14()
    let v110 : string = v108 + v6 
    let v111 : string = v110 + v109 
    let _v7 = v111 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v112 : string = "\u001b[90m"
    let v113 : string = method14()
    let v114 : string = v112 + v6 
    let v115 : string = v114 + v113 
    let _v7 = v115 
    #endif
#else
    let v116 : string = "\u001b[90m"
    let v117 : string = method14()
    let v118 : string = v116 + v6 
    let v119 : string = v118 + v117 
    let _v7 = v119 
    #endif
    let v120 : string = _v7 
    v120
and method41 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : string) : string =
    let v9 : string = method16()
    let v10 : int64 = v0.l0
    let v11 : string = $"{v6} {v7} #{v10} %s{v8} / {v9}"
    method17(v11)
and closure21 (v0 : string) () : unit =
    let v1 : US0 = US0_0
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method40()
        let v39 : bool = v0 = ""
        let v42 : string =
            if v39 then
                let v40 : string = ""
                v40
            else
                method41(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v42)
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
    let v20 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : unit = ()
    let _v26 =
        async {
            let v27 : string = v9.Data
            let v28 : string = null |> unbox<string>
            let v31 : bool = v27 = v28
            let v32 : bool = v31 <> true
            if v32 then
                let v33 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v34 : US14 option = v3 |> Option.map v33 
                let v45 : US14 = US14_1
                let v46 : US14 = v34 |> Option.defaultValue v45 
                match v46 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v50) -> (* Some *)
                    let v51 : int32 = v7.Id
                    let v52 : Async<unit> = v50 struct (v51, v27, false)
                    do! v52 
                    ()
                let v53 : string = $"> {v27}"
                if v5 then
                    let v54 : unit = ()
                    let v55 : (unit -> unit) = closure21(v53)
                    let v56 : unit = (fun () -> v55 (); v54) ()
                    ()
                else
                    let v99 : unit = ()
                    let v100 : (unit -> unit) = closure10(v53)
                    let v101 : unit = (fun () -> v100 (); v99) ()
                    ()
                let v103 : string = ""
                let v104 : string = $"{v103}{v27}{v103}"
                let v105 : (string -> unit) = v8.Push
                v105 v104
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v106 : Async<unit> = _v26 
    let _v10 = v106 
    #endif
#else
    let v107 : unit = ()
    let _v107 =
        async {
            let v108 : string = v9.Data
            let v109 : string = null |> unbox<string>
            let v112 : bool = v108 = v109
            let v113 : bool = v112 <> true
            if v113 then
                let v114 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v115 : US14 option = v3 |> Option.map v114 
                let v126 : US14 = US14_1
                let v127 : US14 = v115 |> Option.defaultValue v126 
                match v127 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v131) -> (* Some *)
                    let v132 : int32 = v7.Id
                    let v133 : Async<unit> = v131 struct (v132, v108, false)
                    do! v133 
                    ()
                let v134 : string = $"> {v108}"
                if v5 then
                    let v135 : unit = ()
                    let v136 : (unit -> unit) = closure21(v134)
                    let v137 : unit = (fun () -> v136 (); v135) ()
                    ()
                else
                    let v180 : unit = ()
                    let v181 : (unit -> unit) = closure10(v134)
                    let v182 : unit = (fun () -> v181 (); v180) ()
                    ()
                let v184 : string = ""
                let v185 : string = $"{v184}{v108}{v184}"
                let v186 : (string -> unit) = v8.Push
                v186 v185
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v187 : Async<unit> = _v107 
    let _v10 = v187 
    #endif
    let v188 : Async<unit> = _v10 
    let v193 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v193 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v193 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v193 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v193 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v193 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v194 : (Async<unit> -> unit) = Async.StartImmediate
    v194 v188
    let _v193 = () 
    #endif
#else
    let v195 : (Async<unit> -> unit) = Async.StartImmediate
    v195 v188
    let _v193 = () 
    #endif
    _v193 
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
    let v20 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v20 
    #endif
#if FABLE_COMPILER_PYTHON
    let v23 : Async<unit> = null |> unbox<Async<unit>>
    let _v10 = v23 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v26 : unit = ()
    let _v26 =
        async {
            let v27 : string = v9.Data
            let v28 : string = null |> unbox<string>
            let v31 : bool = v27 = v28
            let v32 : bool = v31 <> true
            if v32 then
                let v33 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v34 : US14 option = v3 |> Option.map v33 
                let v45 : US14 = US14_1
                let v46 : US14 = v34 |> Option.defaultValue v45 
                match v46 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v50) -> (* Some *)
                    let v51 : int32 = v7.Id
                    let v52 : Async<unit> = v50 struct (v51, v27, true)
                    do! v52 
                    ()
                let v53 : string = $"! {v27}"
                if v5 then
                    let v54 : unit = ()
                    let v55 : (unit -> unit) = closure21(v53)
                    let v56 : unit = (fun () -> v55 (); v54) ()
                    ()
                else
                    let v99 : unit = ()
                    let v100 : (unit -> unit) = closure10(v53)
                    let v101 : unit = (fun () -> v100 (); v99) ()
                    ()
                let v103 : string = "\u001b[7;4m"
                let v104 : string = "\u001b[0m"
                let v105 : string = $"{v103}{v27}{v104}"
                let v106 : (string -> unit) = v8.Push
                v106 v105
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v107 : Async<unit> = _v26 
    let _v10 = v107 
    #endif
#else
    let v108 : unit = ()
    let _v108 =
        async {
            let v109 : string = v9.Data
            let v110 : string = null |> unbox<string>
            let v113 : bool = v109 = v110
            let v114 : bool = v113 <> true
            if v114 then
                let v115 : ((struct (int32 * string * bool) -> Async<unit>) -> US14) = method39()
                let v116 : US14 option = v3 |> Option.map v115 
                let v127 : US14 = US14_1
                let v128 : US14 = v116 |> Option.defaultValue v127 
                match v128 with
                | US14_1 -> (* None *)
                    ()
                | US14_0(v132) -> (* Some *)
                    let v133 : int32 = v7.Id
                    let v134 : Async<unit> = v132 struct (v133, v109, true)
                    do! v134 
                    ()
                let v135 : string = $"! {v109}"
                if v5 then
                    let v136 : unit = ()
                    let v137 : (unit -> unit) = closure21(v135)
                    let v138 : unit = (fun () -> v137 (); v136) ()
                    ()
                else
                    let v181 : unit = ()
                    let v182 : (unit -> unit) = closure10(v135)
                    let v183 : unit = (fun () -> v182 (); v181) ()
                    ()
                let v185 : string = "\u001b[7;4m"
                let v186 : string = "\u001b[0m"
                let v187 : string = $"{v185}{v109}{v186}"
                let v188 : (string -> unit) = v8.Push
                v188 v187
            ()
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v189 : Async<unit> = _v108 
    let _v10 = v189 
    #endif
    let v190 : Async<unit> = _v10 
    let v195 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v195 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v195 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v195 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v195 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v195 = () 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v196 : (Async<unit> -> unit) = Async.StartImmediate
    v196 v190
    let _v195 = () 
    #endif
#else
    let v197 : (Async<unit> -> unit) = Async.StartImmediate
    v197 v190
    let _v195 = () 
    #endif
    _v195 
    ()
and closure23 () (v0 : System.Threading.CancellationToken) : US15 =
    US15_0(v0)
and method42 () : (System.Threading.CancellationToken -> US15) =
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
and method44 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method13()
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
and method43 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : System.Threading.Tasks.TaskCanceledException) : string =
    let v9 : string = method44(v8)
    let v10 : int64 = v0.l0
    let v11 : string = "runtime.execute_with_options_async / WaitForExitAsync"
    let v12 : string = $"{v6} {v7} #{v10} %s{v11} / {v9}"
    method17(v12)
and closure25 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : US0 = US0_3
    let v2 : bool = method6(v1)
    if v2 then
        let v3 : unit = ()
        let v4 : (unit -> unit) = closure0()
        let v5 : unit = (fun () -> v4 (); v3) ()
        let struct (v19 : Mut0, v20 : Mut1, v21 : Mut2, v22 : Mut3, v23 : Mut4, v24 : int64 option) = TraceState.trace_state.Value
        let v37 : string = method7(v19, v20, v21, v22, v23, v24)
        let v38 : string = method11()
        let v39 : string = method43(v19, v20, v21, v22, v23, v24, v37, v38, v0)
        method18(v39)
and method45 () : string =
    let v0 : string = "\n"
    v0
and method47 (v0 : int32, v1 : int32) : string =
    let v2 : string = method13()
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
and method46 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option, v6 : string, v7 : string, v8 : int32, v9 : int32) : string =
    let v10 : string = method47(v8, v9)
    let v11 : int64 = v0.l0
    let v12 : string = "runtime.execute_with_options_async"
    let v13 : string = $"{v6} {v7} #{v11} %s{v12} / {v10}"
    method17(v13)
and closure26 (v0 : int32, v1 : string) () : unit =
    let v2 : US0 = US0_1
    let v3 : bool = method6(v2)
    if v3 then
        let v4 : unit = ()
        let v5 : (unit -> unit) = closure0()
        let v6 : unit = (fun () -> v5 (); v4) ()
        let struct (v20 : Mut0, v21 : Mut1, v22 : Mut2, v23 : Mut3, v24 : Mut4, v25 : int64 option) = TraceState.trace_state.Value
        let v38 : string = method7(v20, v21, v22, v23, v24, v25)
        let v39 : string = method35()
        let v40 : int32 = v1.Length
        let v41 : string = method46(v20, v21, v22, v23, v24, v25, v38, v39, v0, v40)
        method18(v41)
and method21 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
    let v36 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v36 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v26 = v39 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v42 : unit = ()
    let _v42 =
        async {
            let v43 : US6 = method22(v0)
            let struct (v52 : string, v53 : US1) =
                match v43 with
                | US6_1(v46) -> (* Error *)
                    let v47 : string = $"resultm.get / Result value was Error: {v46}"
                    failwith<struct (string * US1)> v47
                | US6_0(v44, v45) -> (* Ok *)
                    struct (v44, v45)
            let v54 : (string -> US1) = method4()
            let v55 : US1 option = v6 |> Option.map v54 
            let v66 : US1 = US1_1
            let v67 : US1 = v55 |> Option.defaultValue v66 
            let v74 : string =
                match v67 with
                | US1_1 -> (* None *)
                    let v72 : string = ""
                    v72
                | US1_0(v71) -> (* Some *)
                    v71
            let v75 : unit = ()
            let v76 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v53, v52)
            let v77 : unit = (fun () -> v76 (); v75) ()
            let v117 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v121 : string =
                match v53 with
                | US1_1 -> (* None *)
                    let v119 : string = ""
                    v119
                | US1_0(v118) -> (* Some *)
                    v118
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v121,
              StandardOutputEncoding = v117,
              WorkingDirectory = v74,
              FileName = v52,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v122 : System.Diagnostics.ProcessStartInfo = start_info
            let v123 : (struct (string * string) []) = method38(v0, v1, v2, v3, v4, v5, v6)
            let v124 : int32 = v123.Length
            let v125 : Mut5 = {l0 = 0} : Mut5
            while method24(v124, v125) do
                let v127 : int32 = v125.l0
                let struct (v128 : string, v129 : string) = v123.[int v127]
                v122.EnvironmentVariables.[v128] <- v129 
                let v130 : int32 = v127 + 1
                v125.l0 <- v130
                ()
            let v131 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v122)
            use v131 = v131 
            let v132 : System.Diagnostics.Process = v131 
            let v133 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v134 : System.Collections.Concurrent.ConcurrentStack<string> = v133 ()
            let v135 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v132, v134)
            v132.OutputDataReceived.Add v135 
            let v136 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v132, v134)
            v132.ErrorDataReceived.Add v136 
            let v137 : (unit -> bool) = v132.Start
            let v138 : bool = v137 ()
            let v139 : bool = v138 = false
            if v139 then
                let v140 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v140
            let v141 : (unit -> unit) = v132.BeginErrorReadLine
            v141 ()
            let v142 : (unit -> unit) = v132.BeginOutputReadLine
            v142 ()
            let v143 : (System.Threading.CancellationToken -> US15) = method42()
            let v144 : US15 option = v1 |> Option.map v143 
            let v155 : US15 = US15_1
            let v156 : US15 = v144 |> Option.defaultValue v155 
            let v163 : System.Threading.CancellationToken =
                match v156 with
                | US15_1 -> (* None *)
                    let v161 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v161
                | US15_0(v160) -> (* Some *)
                    v160
            let v164 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v165 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v164 = v165 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v168 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v164 = v168 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v171 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v164 = v171 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v174 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v164 = v174 
            #endif
#if FABLE_COMPILER_PYTHON
            let v177 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v164 = v177 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v180 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v164 = v180 
            #endif
#else
            let v183 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v184 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v183 = v184 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v187 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v183 = v187 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v190 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v183 = v190 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v193 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v183 = v193 
            #endif
#if FABLE_COMPILER_PYTHON
            let v196 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v183 = v196 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v199 : unit = ()
            let _v199 =
                async {
                    let v200 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v200 = v200 
                    let v201 : System.Threading.CancellationToken = v200 
                    let v202 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v203 : (System.Threading.CancellationToken []) = [|v201; v202; v163|]
                    let v204 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v205 : System.Threading.CancellationTokenSource = v204 v203
                    let v206 : System.Threading.CancellationToken = v205.Token
                    return v206 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v207 : Async<System.Threading.CancellationToken> = _v199 
            let _v183 = v207 
            #endif
#else
            let v208 : unit = ()
            let _v208 =
                async {
                    let v209 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v209 = v209 
                    let v210 : System.Threading.CancellationToken = v209 
                    let v211 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v212 : (System.Threading.CancellationToken []) = [|v210; v211; v163|]
                    let v213 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v214 : System.Threading.CancellationTokenSource = v213 v212
                    let v215 : System.Threading.CancellationToken = v214.Token
                    return v215 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v216 : Async<System.Threading.CancellationToken> = _v208 
            let _v183 = v216 
            #endif
            let v217 : Async<System.Threading.CancellationToken> = _v183 
            let _v164 = v217 
            #endif
            let v222 : Async<System.Threading.CancellationToken> = _v164 
            let! v222 = v222 
            let v227 : System.Threading.CancellationToken = v222 
            let v228 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v227.Register
            let v229 : (unit -> unit) = closure24(v132)
            let v230 : System.Threading.CancellationTokenRegistration = v228 v229
            use v230 = v230 
            let v231 : System.Threading.CancellationTokenRegistration = v230 
            let v232 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v233 : Async<int32> = null |> unbox<Async<int32>>
            let _v232 = v233 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v236 : Async<int32> = null |> unbox<Async<int32>>
            let _v232 = v236 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v239 : Async<int32> = null |> unbox<Async<int32>>
            let _v232 = v239 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v242 : Async<int32> = null |> unbox<Async<int32>>
            let _v232 = v242 
            #endif
#if FABLE_COMPILER_PYTHON
            let v245 : Async<int32> = null |> unbox<Async<int32>>
            let _v232 = v245 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v248 : unit = ()
            let _v248 =
                async {
                    try
                    let v249 : System.Threading.Tasks.Task = v132.WaitForExitAsync v227 
                    let v250 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v251 : Async<unit> = null |> unbox<Async<unit>>
                    let _v250 = v251 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v254 : Async<unit> = null |> unbox<Async<unit>>
                    let _v250 = v254 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v257 : Async<unit> = null |> unbox<Async<unit>>
                    let _v250 = v257 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v260 : Async<unit> = null |> unbox<Async<unit>>
                    let _v250 = v260 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v263 : Async<unit> = null |> unbox<Async<unit>>
                    let _v250 = v263 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v266 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v267 : Async<unit> = v266 v249
                    let _v250 = v267 
                    #endif
#else
                    let v268 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v269 : Async<unit> = v268 v249
                    let _v250 = v269 
                    #endif
                    let v270 : Async<unit> = _v250 
                    do! v270 
                    let v275 : int32 = v132.ExitCode
                    return v275 
                    with ex ->
                        let v276 : exn = ex
                        let v277 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v278 : string = $"%A{v276}"
                        let _v277 = v278 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v281 : string = $"%A{v276}"
                        let _v277 = v281 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v284 : string = $"%A{v276}"
                        let _v277 = v284 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v287 : string = $"%A{v276}"
                        let _v277 = v287 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v290 : string = $"%A{v276}"
                        let _v277 = v290 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v293 : string = $"%A{v276}"
                        let _v277 = v293 
                        #endif
#else
                        let v296 : string = $"{v276.GetType ()}: {v276.Message}"
                        let _v277 = v296 
                        #endif
                        let v297 : string = _v277 
                        let v302 : (string -> unit) = v134.Push
                        v302 v297
                        let v303 : System.Threading.Tasks.TaskCanceledException = v276 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v306 : unit = ()
                        let v307 : (unit -> unit) = closure25(v303)
                        let v308 : unit = (fun () -> v307 (); v306) ()
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
            let v348 : Async<int32> = _v248 
            let _v232 = v348 
            #endif
#else
            let v349 : unit = ()
            let _v349 =
                async {
                    try
                    let v350 : System.Threading.Tasks.Task = v132.WaitForExitAsync v227 
                    let v351 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v352 : Async<unit> = null |> unbox<Async<unit>>
                    let _v351 = v352 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v355 : Async<unit> = null |> unbox<Async<unit>>
                    let _v351 = v355 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v358 : Async<unit> = null |> unbox<Async<unit>>
                    let _v351 = v358 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v361 : Async<unit> = null |> unbox<Async<unit>>
                    let _v351 = v361 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v364 : Async<unit> = null |> unbox<Async<unit>>
                    let _v351 = v364 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v367 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v368 : Async<unit> = v367 v350
                    let _v351 = v368 
                    #endif
#else
                    let v369 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v370 : Async<unit> = v369 v350
                    let _v351 = v370 
                    #endif
                    let v371 : Async<unit> = _v351 
                    do! v371 
                    let v376 : int32 = v132.ExitCode
                    return v376 
                    with ex ->
                        let v377 : exn = ex
                        let v378 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v379 : string = $"%A{v377}"
                        let _v378 = v379 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v382 : string = $"%A{v377}"
                        let _v378 = v382 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v385 : string = $"%A{v377}"
                        let _v378 = v385 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v388 : string = $"%A{v377}"
                        let _v378 = v388 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v391 : string = $"%A{v377}"
                        let _v378 = v391 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v394 : string = $"%A{v377}"
                        let _v378 = v394 
                        #endif
#else
                        let v397 : string = $"{v377.GetType ()}: {v377.Message}"
                        let _v378 = v397 
                        #endif
                        let v398 : string = _v378 
                        let v403 : (string -> unit) = v134.Push
                        v403 v398
                        let v404 : System.Threading.Tasks.TaskCanceledException = v377 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v407 : unit = ()
                        let v408 : (unit -> unit) = closure25(v404)
                        let v409 : unit = (fun () -> v408 (); v407) ()
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
            let v449 : Async<int32> = _v349 
            let _v232 = v449 
            #endif
            let v450 : Async<int32> = _v232 
            let! v450 = v450 
            let v455 : int32 = v450 
            let v456 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v457 : string seq = v456 v134
            let v460 : string = method45()
            let v461 : (string -> (string seq -> string)) = String.concat
            let v462 : (string seq -> string) = v461 v460
            let v463 : string = v462 v457
            let v467 : unit = ()
            let v468 : (unit -> unit) = closure26(v455, v463)
            let v469 : unit = (fun () -> v468 (); v467) ()
            return struct (v455, v463) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v510 : Async<struct (int32 * string)> = _v42 
    let _v26 = v510 
    #endif
#else
    let v511 : unit = ()
    let _v511 =
        async {
            let v512 : US6 = method22(v0)
            let struct (v521 : string, v522 : US1) =
                match v512 with
                | US6_1(v515) -> (* Error *)
                    let v516 : string = $"resultm.get / Result value was Error: {v515}"
                    failwith<struct (string * US1)> v516
                | US6_0(v513, v514) -> (* Ok *)
                    struct (v513, v514)
            let v523 : (string -> US1) = method4()
            let v524 : US1 option = v6 |> Option.map v523 
            let v535 : US1 = US1_1
            let v536 : US1 = v524 |> Option.defaultValue v535 
            let v543 : string =
                match v536 with
                | US1_1 -> (* None *)
                    let v541 : string = ""
                    v541
                | US1_0(v540) -> (* Some *)
                    v540
            let v544 : unit = ()
            let v545 : (unit -> unit) = closure18(v0, v1, v2, v3, v4, v5, v6, v522, v521)
            let v546 : unit = (fun () -> v545 (); v544) ()
            let v586 : System.Text.Encoding = System.Text.Encoding.UTF8
            let v590 : string =
                match v522 with
                | US1_1 -> (* None *)
                    let v588 : string = ""
                    v588
                | US1_0(v587) -> (* Some *)
                    v587
            let start_info = System.Diagnostics.ProcessStartInfo (
              Arguments = v590,
              StandardOutputEncoding = v586,
              WorkingDirectory = v543,
              FileName = v521,
              CreateNoWindow = true,
              RedirectStandardError = true,
              RedirectStandardOutput = true,
              UseShellExecute = false
            )
            let v591 : System.Diagnostics.ProcessStartInfo = start_info
            let v592 : (struct (string * string) []) = method38(v0, v1, v2, v3, v4, v5, v6)
            let v593 : int32 = v592.Length
            let v594 : Mut5 = {l0 = 0} : Mut5
            while method24(v593, v594) do
                let v596 : int32 = v594.l0
                let struct (v597 : string, v598 : string) = v592.[int v596]
                v591.EnvironmentVariables.[v597] <- v598 
                let v599 : int32 = v596 + 1
                v594.l0 <- v599
                ()
            let v600 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v591)
            use v600 = v600 
            let v601 : System.Diagnostics.Process = v600 
            let v602 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
            let v603 : System.Collections.Concurrent.ConcurrentStack<string> = v602 ()
            let v604 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v601, v603)
            v601.OutputDataReceived.Add v604 
            let v605 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v601, v603)
            v601.ErrorDataReceived.Add v605 
            let v606 : (unit -> bool) = v601.Start
            let v607 : bool = v606 ()
            let v608 : bool = v607 = false
            if v608 then
                let v609 : string = $"runtime.execute_with_options_async / process_start error"
                failwith<unit> v609
            let v610 : (unit -> unit) = v601.BeginErrorReadLine
            v610 ()
            let v611 : (unit -> unit) = v601.BeginOutputReadLine
            v611 ()
            let v612 : (System.Threading.CancellationToken -> US15) = method42()
            let v613 : US15 option = v1 |> Option.map v612 
            let v624 : US15 = US15_1
            let v625 : US15 = v613 |> Option.defaultValue v624 
            let v632 : System.Threading.CancellationToken =
                match v625 with
                | US15_1 -> (* None *)
                    let v630 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
                    v630
                | US15_0(v629) -> (* Some *)
                    v629
            let v633 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v634 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v633 = v634 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v637 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v633 = v637 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v640 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v633 = v640 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v643 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v633 = v643 
            #endif
#if FABLE_COMPILER_PYTHON
            let v646 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v633 = v646 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v649 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v633 = v649 
            #endif
#else
            let v652 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v653 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v652 = v653 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v656 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v652 = v656 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v659 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v652 = v659 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v662 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v652 = v662 
            #endif
#if FABLE_COMPILER_PYTHON
            let v665 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
            let _v652 = v665 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v668 : unit = ()
            let _v668 =
                async {
                    let v669 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v669 = v669 
                    let v670 : System.Threading.CancellationToken = v669 
                    let v671 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v672 : (System.Threading.CancellationToken []) = [|v670; v671; v632|]
                    let v673 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v674 : System.Threading.CancellationTokenSource = v673 v672
                    let v675 : System.Threading.CancellationToken = v674.Token
                    return v675 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v676 : Async<System.Threading.CancellationToken> = _v668 
            let _v652 = v676 
            #endif
#else
            let v677 : unit = ()
            let _v677 =
                async {
                    let v678 : Async<System.Threading.CancellationToken> = Async.CancellationToken
                    let! v678 = v678 
                    let v679 : System.Threading.CancellationToken = v678 
                    let v680 : System.Threading.CancellationToken = Async.DefaultCancellationToken
                    let v681 : (System.Threading.CancellationToken []) = [|v679; v680; v632|]
                    let v682 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
                    let v683 : System.Threading.CancellationTokenSource = v682 v681
                    let v684 : System.Threading.CancellationToken = v683.Token
                    return v684 
                    (*
                    ()
                *)
                }
                (*
                ()
            *)
            let v685 : Async<System.Threading.CancellationToken> = _v677 
            let _v652 = v685 
            #endif
            let v686 : Async<System.Threading.CancellationToken> = _v652 
            let _v633 = v686 
            #endif
            let v691 : Async<System.Threading.CancellationToken> = _v633 
            let! v691 = v691 
            let v696 : System.Threading.CancellationToken = v691 
            let v697 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v696.Register
            let v698 : (unit -> unit) = closure24(v601)
            let v699 : System.Threading.CancellationTokenRegistration = v697 v698
            use v699 = v699 
            let v700 : System.Threading.CancellationTokenRegistration = v699 
            let v701 : unit = ()
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v702 : Async<int32> = null |> unbox<Async<int32>>
            let _v701 = v702 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v705 : Async<int32> = null |> unbox<Async<int32>>
            let _v701 = v705 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v708 : Async<int32> = null |> unbox<Async<int32>>
            let _v701 = v708 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v711 : Async<int32> = null |> unbox<Async<int32>>
            let _v701 = v711 
            #endif
#if FABLE_COMPILER_PYTHON
            let v714 : Async<int32> = null |> unbox<Async<int32>>
            let _v701 = v714 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v717 : unit = ()
            let _v717 =
                async {
                    try
                    let v718 : System.Threading.Tasks.Task = v601.WaitForExitAsync v696 
                    let v719 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v720 : Async<unit> = null |> unbox<Async<unit>>
                    let _v719 = v720 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v723 : Async<unit> = null |> unbox<Async<unit>>
                    let _v719 = v723 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v726 : Async<unit> = null |> unbox<Async<unit>>
                    let _v719 = v726 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v729 : Async<unit> = null |> unbox<Async<unit>>
                    let _v719 = v729 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v732 : Async<unit> = null |> unbox<Async<unit>>
                    let _v719 = v732 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v735 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v736 : Async<unit> = v735 v718
                    let _v719 = v736 
                    #endif
#else
                    let v737 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v738 : Async<unit> = v737 v718
                    let _v719 = v738 
                    #endif
                    let v739 : Async<unit> = _v719 
                    do! v739 
                    let v744 : int32 = v601.ExitCode
                    return v744 
                    with ex ->
                        let v745 : exn = ex
                        let v746 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v747 : string = $"%A{v745}"
                        let _v746 = v747 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v750 : string = $"%A{v745}"
                        let _v746 = v750 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v753 : string = $"%A{v745}"
                        let _v746 = v753 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v756 : string = $"%A{v745}"
                        let _v746 = v756 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v759 : string = $"%A{v745}"
                        let _v746 = v759 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v762 : string = $"%A{v745}"
                        let _v746 = v762 
                        #endif
#else
                        let v765 : string = $"{v745.GetType ()}: {v745.Message}"
                        let _v746 = v765 
                        #endif
                        let v766 : string = _v746 
                        let v771 : (string -> unit) = v603.Push
                        v771 v766
                        let v772 : System.Threading.Tasks.TaskCanceledException = v745 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v775 : unit = ()
                        let v776 : (unit -> unit) = closure25(v772)
                        let v777 : unit = (fun () -> v776 (); v775) ()
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
            let v817 : Async<int32> = _v717 
            let _v701 = v817 
            #endif
#else
            let v818 : unit = ()
            let _v818 =
                async {
                    try
                    let v819 : System.Threading.Tasks.Task = v601.WaitForExitAsync v696 
                    let v820 : unit = ()
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v821 : Async<unit> = null |> unbox<Async<unit>>
                    let _v820 = v821 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v824 : Async<unit> = null |> unbox<Async<unit>>
                    let _v820 = v824 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v827 : Async<unit> = null |> unbox<Async<unit>>
                    let _v820 = v827 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v830 : Async<unit> = null |> unbox<Async<unit>>
                    let _v820 = v830 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v833 : Async<unit> = null |> unbox<Async<unit>>
                    let _v820 = v833 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v836 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v837 : Async<unit> = v836 v819
                    let _v820 = v837 
                    #endif
#else
                    let v838 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
                    let v839 : Async<unit> = v838 v819
                    let _v820 = v839 
                    #endif
                    let v840 : Async<unit> = _v820 
                    do! v840 
                    let v845 : int32 = v601.ExitCode
                    return v845 
                    with ex ->
                        let v846 : exn = ex
                        let v847 : unit = ()
                        
#if FABLE_COMPILER || WASM || CONTRACT
                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                        let v848 : string = $"%A{v846}"
                        let _v847 = v848 
                        #endif
#if FABLE_COMPILER_RUST && WASM
                        let v851 : string = $"%A{v846}"
                        let _v847 = v851 
                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                        let v854 : string = $"%A{v846}"
                        let _v847 = v854 
                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                        let v857 : string = $"%A{v846}"
                        let _v847 = v857 
                        #endif
#if FABLE_COMPILER_PYTHON
                        let v860 : string = $"%A{v846}"
                        let _v847 = v860 
                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                        let v863 : string = $"%A{v846}"
                        let _v847 = v863 
                        #endif
#else
                        let v866 : string = $"{v846.GetType ()}: {v846.Message}"
                        let _v847 = v866 
                        #endif
                        let v867 : string = _v847 
                        let v872 : (string -> unit) = v603.Push
                        v872 v867
                        let v873 : System.Threading.Tasks.TaskCanceledException = v846 |> unbox<System.Threading.Tasks.TaskCanceledException>
                        let v876 : unit = ()
                        let v877 : (unit -> unit) = closure25(v873)
                        let v878 : unit = (fun () -> v877 (); v876) ()
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
            let v918 : Async<int32> = _v818 
            let _v701 = v918 
            #endif
            let v919 : Async<int32> = _v701 
            let! v919 = v919 
            let v924 : int32 = v919 
            let v925 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
            let v926 : string seq = v925 v603
            let v929 : string = method45()
            let v930 : (string -> (string seq -> string)) = String.concat
            let v931 : (string seq -> string) = v930 v929
            let v932 : string = v931 v926
            let v936 : unit = ()
            let v937 : (unit -> unit) = closure26(v924, v932)
            let v938 : unit = (fun () -> v937 (); v936) ()
            return struct (v924, v932) 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v979 : Async<struct (int32 * string)> = _v511 
    let _v26 = v979 
    #endif
    let v980 : Async<struct (int32 * string)> = _v26 
    let _v7 = v980 
    #endif
    let v985 : Async<struct (int32 * string)> = _v7 
    v985
and closure13 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method21(v0, v1, v2, v3, v4, v6, v5)
and closure27 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method21(v0, v1, v2, v3, v4, v5, v6)
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
and method50 (v0 : char, v1 : int64) : bool =
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
            method50(v0, v25)
and method51 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US8 =
    let v5 : bool = "" = v1
    let v82 : US7 =
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
            let v25 : char = v1.[int 0]
            let v26 : (string -> int32) = String.length
            let v27 : int32 = v26 v1
            let v28 : (int32 -> int32) = int32
            let v29 : int32 = v28 1
            let v30 : (int32 -> int32) = int32
            let v31 : int32 = v30 v27
            let v32 : string = v1.[int v29..int v31]
            let v33 : int64 = 0L
            let v34 : bool = method50(v25, v33)
            let v35 : bool = v34 = false
            if v35 then
                let v36 : (char -> string) = _.ToString()
                let v37 : string = v36 v25
                let v40 : int32 = v37.Length
                let v41 : (char []) = Array.zeroCreate<char> (v40)
                let v42 : Mut5 = {l0 = 0} : Mut5
                while method24(v40, v42) do
                    let v44 : int32 = v42.l0
                    let v45 : char = v37.[int v44]
                    v41.[int v44] <- v45
                    let v46 : int32 = v44 + 1
                    v42.l0 <- v46
                    ()
                let v47 : char list = v41 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method25()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v47
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v58 : System.Text.StringBuilder, v59 : int32, v60 : int32) = method26(v53, v2, v3, v4)
                US7_0(v25, v32, v58, v59, v60)
            else
                let v62 : char list = []
                let v63 : char list = ' ' :: v62 
                let v66 : char list = '"' :: v63 
                let v69 : char list = '`' :: v66 
                let v72 : char list = '\\' :: v69 
                let v75 : (char list -> (char [])) = List.toArray
                let v76 : (char []) = v75 v72
                let v79 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v76} / s: %A{struct (v2, v3, v4)}"
                US7_1(v79)
    match v82 with
    | US7_1(v94) -> (* Error *)
        US8_0(v0, v1, v2, v3, v4)
    | US7_0(v83, v84, v85, v86, v87) -> (* Ok *)
        let v88 : (char -> string) = _.ToString()
        let v89 : string = v88 v83
        let v92 : string = v0 + v89 
        method51(v92, v84, v85, v86, v87)
and method53 (v0 : char, v1 : int64) : bool =
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
            method53(v0, v21)
and closure30 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US8 =
    let v4 : bool = "" = v0
    let v67 : US7 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US7_1(v5)
        else
            let v7 : char = v0.[int 0]
            let v8 : bool = v7 = '\\'
            if v8 then
                let v9 : (string -> int32) = String.length
                let v10 : int32 = v9 v0
                let v11 : (int32 -> int32) = int32
                let v12 : int32 = v11 1
                let v13 : (int32 -> int32) = int32
                let v14 : int32 = v13 v10
                let v15 : string = v0.[int v12..int v14]
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v7
                let v20 : int32 = v17.Length
                let v21 : (char []) = Array.zeroCreate<char> (v20)
                let v22 : Mut5 = {l0 = 0} : Mut5
                while method24(v20, v22) do
                    let v24 : int32 = v22.l0
                    let v25 : char = v17.[int v24]
                    v21.[int v24] <- v25
                    let v26 : int32 = v24 + 1
                    v22.l0 <- v26
                    ()
                let v27 : char list = v21 |> Array.toList
                let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v29 : (char -> (UH0 -> UH0)) = method25()
                let v30 : (char list -> (UH0 -> UH0)) = v28 v29
                let v31 : (UH0 -> UH0) = v30 v27
                let v32 : UH0 = UH0_0
                let v33 : UH0 = v31 v32
                let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method26(v33, v1, v2, v3)
                US7_0(v7, v15, v38, v39, v40)
            else
                let v42 : (string -> int32) = String.length
                let v43 : int32 = v42 v0
                let v44 : string = "\n"
                let v45 : int32 = v0.IndexOf v44 
                let v46 : int32 = v45 - 1
                let v47 : bool = -2 = v46
                let v48 : int32 =
                    if v47 then
                        v43
                    else
                        v46
                let v49 : (int32 -> int32) = int32
                let v50 : int32 = v49 0
                let v51 : (int32 -> int32) = int32
                let v52 : int32 = v51 v48
                let v53 : string = v0.[int v50..int v52]
                let v54 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v53}"
                let v55 : int32 = v3 - 1
                let v56 : (int32 -> (string -> string)) = String.replicate
                let v57 : (string -> string) = v56 v55
                let v58 : string = " "
                let v59 : string = v57 v58
                let v62 : string = "^"
                let v63 : string = v59 + v62 
                let v64 : string = $"{v54}
{v63}
"
                US7_1(v64)
    let v114 : US7 =
        match v67 with
        | US7_1(v111) -> (* Error *)
            US7_1(v111)
        | US7_0(v68, v69, v70, v71, v72) -> (* Ok *)
            let v73 : bool = "" = v69
            if v73 then
                let v74 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v70, v71, v72)}"
                US7_1(v74)
            else
                let v76 : char = v69.[int 0]
                let v77 : (string -> int32) = String.length
                let v78 : int32 = v77 v69
                let v79 : (int32 -> int32) = int32
                let v80 : int32 = v79 1
                let v81 : (int32 -> int32) = int32
                let v82 : int32 = v81 v78
                let v83 : string = v69.[int v80..int v82]
                let v84 : (char -> string) = _.ToString()
                let v85 : string = v84 v76
                let v88 : int32 = v85.Length
                let v89 : (char []) = Array.zeroCreate<char> (v88)
                let v90 : Mut5 = {l0 = 0} : Mut5
                while method24(v88, v90) do
                    let v92 : int32 = v90.l0
                    let v93 : char = v85.[int v92]
                    v89.[int v92] <- v93
                    let v94 : int32 = v92 + 1
                    v90.l0 <- v94
                    ()
                let v95 : char list = v89 |> Array.toList
                let v96 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v97 : (char -> (UH0 -> UH0)) = method25()
                let v98 : (char list -> (UH0 -> UH0)) = v96 v97
                let v99 : (UH0 -> UH0) = v98 v95
                let v100 : UH0 = UH0_0
                let v101 : UH0 = v99 v100
                let struct (v106 : System.Text.StringBuilder, v107 : int32, v108 : int32) = method26(v101, v70, v71, v72)
                US7_0(v76, v83, v106, v107, v108)
    match v114 with
    | US7_1(v122) -> (* Error *)
        US8_1(v122)
    | US7_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v120 : string = $"{'\\'}{v115}"
        US8_0(v120, v116, v117, v118, v119)
and closure31 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US8 =
    let v4 : bool = "" = v0
    let v67 : US7 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US7_1(v5)
        else
            let v7 : char = v0.[int 0]
            let v8 : bool = v7 = '`'
            if v8 then
                let v9 : (string -> int32) = String.length
                let v10 : int32 = v9 v0
                let v11 : (int32 -> int32) = int32
                let v12 : int32 = v11 1
                let v13 : (int32 -> int32) = int32
                let v14 : int32 = v13 v10
                let v15 : string = v0.[int v12..int v14]
                let v16 : (char -> string) = _.ToString()
                let v17 : string = v16 v7
                let v20 : int32 = v17.Length
                let v21 : (char []) = Array.zeroCreate<char> (v20)
                let v22 : Mut5 = {l0 = 0} : Mut5
                while method24(v20, v22) do
                    let v24 : int32 = v22.l0
                    let v25 : char = v17.[int v24]
                    v21.[int v24] <- v25
                    let v26 : int32 = v24 + 1
                    v22.l0 <- v26
                    ()
                let v27 : char list = v21 |> Array.toList
                let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v29 : (char -> (UH0 -> UH0)) = method25()
                let v30 : (char list -> (UH0 -> UH0)) = v28 v29
                let v31 : (UH0 -> UH0) = v30 v27
                let v32 : UH0 = UH0_0
                let v33 : UH0 = v31 v32
                let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method26(v33, v1, v2, v3)
                US7_0(v7, v15, v38, v39, v40)
            else
                let v42 : (string -> int32) = String.length
                let v43 : int32 = v42 v0
                let v44 : string = "\n"
                let v45 : int32 = v0.IndexOf v44 
                let v46 : int32 = v45 - 1
                let v47 : bool = -2 = v46
                let v48 : int32 =
                    if v47 then
                        v43
                    else
                        v46
                let v49 : (int32 -> int32) = int32
                let v50 : int32 = v49 0
                let v51 : (int32 -> int32) = int32
                let v52 : int32 = v51 v48
                let v53 : string = v0.[int v50..int v52]
                let v54 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v53}"
                let v55 : int32 = v3 - 1
                let v56 : (int32 -> (string -> string)) = String.replicate
                let v57 : (string -> string) = v56 v55
                let v58 : string = " "
                let v59 : string = v57 v58
                let v62 : string = "^"
                let v63 : string = v59 + v62 
                let v64 : string = $"{v54}
{v63}
"
                US7_1(v64)
    let v114 : US7 =
        match v67 with
        | US7_1(v111) -> (* Error *)
            US7_1(v111)
        | US7_0(v68, v69, v70, v71, v72) -> (* Ok *)
            let v73 : bool = "" = v69
            if v73 then
                let v74 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v70, v71, v72)}"
                US7_1(v74)
            else
                let v76 : char = v69.[int 0]
                let v77 : (string -> int32) = String.length
                let v78 : int32 = v77 v69
                let v79 : (int32 -> int32) = int32
                let v80 : int32 = v79 1
                let v81 : (int32 -> int32) = int32
                let v82 : int32 = v81 v78
                let v83 : string = v69.[int v80..int v82]
                let v84 : (char -> string) = _.ToString()
                let v85 : string = v84 v76
                let v88 : int32 = v85.Length
                let v89 : (char []) = Array.zeroCreate<char> (v88)
                let v90 : Mut5 = {l0 = 0} : Mut5
                while method24(v88, v90) do
                    let v92 : int32 = v90.l0
                    let v93 : char = v85.[int v92]
                    v89.[int v92] <- v93
                    let v94 : int32 = v92 + 1
                    v90.l0 <- v94
                    ()
                let v95 : char list = v89 |> Array.toList
                let v96 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v97 : (char -> (UH0 -> UH0)) = method25()
                let v98 : (char list -> (UH0 -> UH0)) = v96 v97
                let v99 : (UH0 -> UH0) = v98 v95
                let v100 : UH0 = UH0_0
                let v101 : UH0 = v99 v100
                let struct (v106 : System.Text.StringBuilder, v107 : int32, v108 : int32) = method26(v101, v70, v71, v72)
                US7_0(v76, v83, v106, v107, v108)
    match v114 with
    | US7_1(v122) -> (* Error *)
        US8_1(v122)
    | US7_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v120 : string = $"{'`'}{v115}"
        US8_0(v120, v116, v117, v118, v119)
and method54 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US8 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US8 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US8_1(v15) -> (* Error *)
            method54(v0, v1, v2, v3, v8)
        | US8_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US8_1(v5)
and method55 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method55(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method52 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v76 : US7 =
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
            let v22 : char = v1.[int 0]
            let v23 : (string -> int32) = String.length
            let v24 : int32 = v23 v1
            let v25 : (int32 -> int32) = int32
            let v26 : int32 = v25 1
            let v27 : (int32 -> int32) = int32
            let v28 : int32 = v27 v24
            let v29 : string = v1.[int v26..int v28]
            let v30 : int64 = 0L
            let v31 : bool = method53(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method24(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method25()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method26(v50, v2, v3, v4)
                US7_0(v22, v29, v55, v56, v57)
            else
                let v59 : char list = []
                let v60 : char list = '"' :: v59 
                let v63 : char list = '`' :: v60 
                let v66 : char list = '\\' :: v63 
                let v69 : (char list -> (char [])) = List.toArray
                let v70 : (char []) = v69 v66
                let v73 : string = $"parsing.none_of / unexpected char: '{v22}' / chars: %A{v70} / s: %A{struct (v2, v3, v4)}"
                US7_1(v73)
    let v90 : US8 =
        match v76 with
        | US7_1(v87) -> (* Error *)
            US8_1(v87)
        | US7_0(v77, v78, v79, v80, v81) -> (* Ok *)
            let v82 : (char -> string) = _.ToString()
            let v83 : string = v82 v77
            US8_0(v83, v78, v79, v80, v81)
    let v104 : US8 =
        match v90 with
        | US8_1(v96) -> (* Error *)
            let v97 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure30()
            let v98 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure31()
            let v99 : UH3 = UH3_0
            let v100 : UH3 = UH3_1(v98, v99)
            let v101 : UH3 = UH3_1(v97, v100)
            method54(v1, v2, v3, v4, v101)
        | US8_0(v91, v92, v93, v94, v95) -> (* Ok *)
            v90
    match v104 with
    | US8_1(v112) -> (* Error *)
        let v113 : UH2 = UH2_0
        let v114 : UH2 = method55(v0, v113)
        US17_0(v114, v1, v2, v3, v4)
    | US8_0(v105, v106, v107, v108, v109) -> (* Ok *)
        let v110 : UH2 = UH2_1(v105, v0)
        method52(v110, v106, v107, v108, v109)
and method56 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method56(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method57 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v76 : US7 =
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
            let v22 : char = v1.[int 0]
            let v23 : (string -> int32) = String.length
            let v24 : int32 = v23 v1
            let v25 : (int32 -> int32) = int32
            let v26 : int32 = v25 1
            let v27 : (int32 -> int32) = int32
            let v28 : int32 = v27 v24
            let v29 : string = v1.[int v26..int v28]
            let v30 : int64 = 0L
            let v31 : bool = method53(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method24(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method25()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method26(v50, v2, v3, v4)
                US7_0(v22, v29, v55, v56, v57)
            else
                let v59 : char list = []
                let v60 : char list = '"' :: v59 
                let v63 : char list = '`' :: v60 
                let v66 : char list = '\\' :: v63 
                let v69 : (char list -> (char [])) = List.toArray
                let v70 : (char []) = v69 v66
                let v73 : string = $"parsing.none_of / unexpected char: '{v22}' / chars: %A{v70} / s: %A{struct (v2, v3, v4)}"
                US7_1(v73)
    let v90 : US8 =
        match v76 with
        | US7_1(v87) -> (* Error *)
            US8_1(v87)
        | US7_0(v77, v78, v79, v80, v81) -> (* Ok *)
            let v82 : (char -> string) = _.ToString()
            let v83 : string = v82 v77
            US8_0(v83, v78, v79, v80, v81)
    match v90 with
    | US8_1(v98) -> (* Error *)
        let v99 : UH2 = UH2_0
        let v100 : UH2 = method55(v0, v99)
        US17_0(v100, v1, v2, v3, v4)
    | US8_0(v91, v92, v93, v94, v95) -> (* Ok *)
        let v96 : UH2 = UH2_1(v91, v0)
        method57(v96, v92, v93, v94, v95)
and method58 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method58(v0, v6)
        else
            v1
and method49 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US17 =
    let v5 : bool = "" = v1
    let v82 : US7 =
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
            let v25 : char = v1.[int 0]
            let v26 : (string -> int32) = String.length
            let v27 : int32 = v26 v1
            let v28 : (int32 -> int32) = int32
            let v29 : int32 = v28 1
            let v30 : (int32 -> int32) = int32
            let v31 : int32 = v30 v27
            let v32 : string = v1.[int v29..int v31]
            let v33 : int64 = 0L
            let v34 : bool = method50(v25, v33)
            let v35 : bool = v34 = false
            if v35 then
                let v36 : (char -> string) = _.ToString()
                let v37 : string = v36 v25
                let v40 : int32 = v37.Length
                let v41 : (char []) = Array.zeroCreate<char> (v40)
                let v42 : Mut5 = {l0 = 0} : Mut5
                while method24(v40, v42) do
                    let v44 : int32 = v42.l0
                    let v45 : char = v37.[int v44]
                    v41.[int v44] <- v45
                    let v46 : int32 = v44 + 1
                    v42.l0 <- v46
                    ()
                let v47 : char list = v41 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method25()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v47
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v58 : System.Text.StringBuilder, v59 : int32, v60 : int32) = method26(v53, v2, v3, v4)
                US7_0(v25, v32, v58, v59, v60)
            else
                let v62 : char list = []
                let v63 : char list = ' ' :: v62 
                let v66 : char list = '"' :: v63 
                let v69 : char list = '`' :: v66 
                let v72 : char list = '\\' :: v69 
                let v75 : (char list -> (char [])) = List.toArray
                let v76 : (char []) = v75 v72
                let v79 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v76} / s: %A{struct (v2, v3, v4)}"
                US7_1(v79)
    let v96 : US8 =
        match v82 with
        | US7_1(v83) -> (* Error *)
            US8_1(v83)
        | US7_0(v85, v86, v87, v88, v89) -> (* Ok *)
            let v90 : (char -> string) = _.ToString()
            let v91 : string = v90 v85
            method51(v91, v86, v87, v88, v89)
    let v341 : US8 =
        match v96 with
        | US8_1(v102) -> (* Error *)
            let v165 : US7 =
                if v5 then
                    let v103 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US7_1(v103)
                else
                    let v105 : char = v1.[int 0]
                    let v106 : bool = v105 = '"'
                    if v106 then
                        let v107 : (string -> int32) = String.length
                        let v108 : int32 = v107 v1
                        let v109 : (int32 -> int32) = int32
                        let v110 : int32 = v109 1
                        let v111 : (int32 -> int32) = int32
                        let v112 : int32 = v111 v108
                        let v113 : string = v1.[int v110..int v112]
                        let v114 : (char -> string) = _.ToString()
                        let v115 : string = v114 v105
                        let v118 : int32 = v115.Length
                        let v119 : (char []) = Array.zeroCreate<char> (v118)
                        let v120 : Mut5 = {l0 = 0} : Mut5
                        while method24(v118, v120) do
                            let v122 : int32 = v120.l0
                            let v123 : char = v115.[int v122]
                            v119.[int v122] <- v123
                            let v124 : int32 = v122 + 1
                            v120.l0 <- v124
                            ()
                        let v125 : char list = v119 |> Array.toList
                        let v126 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v127 : (char -> (UH0 -> UH0)) = method25()
                        let v128 : (char list -> (UH0 -> UH0)) = v126 v127
                        let v129 : (UH0 -> UH0) = v128 v125
                        let v130 : UH0 = UH0_0
                        let v131 : UH0 = v129 v130
                        let struct (v136 : System.Text.StringBuilder, v137 : int32, v138 : int32) = method26(v131, v2, v3, v4)
                        US7_0(v105, v113, v136, v137, v138)
                    else
                        let v140 : (string -> int32) = String.length
                        let v141 : int32 = v140 v1
                        let v142 : string = "\n"
                        let v143 : int32 = v1.IndexOf v142 
                        let v144 : int32 = v143 - 1
                        let v145 : bool = -2 = v144
                        let v146 : int32 =
                            if v145 then
                                v141
                            else
                                v144
                        let v147 : (int32 -> int32) = int32
                        let v148 : int32 = v147 0
                        let v149 : (int32 -> int32) = int32
                        let v150 : int32 = v149 v146
                        let v151 : string = v1.[int v148..int v150]
                        let v152 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v151}"
                        let v153 : int32 = v4 - 1
                        let v154 : (int32 -> (string -> string)) = String.replicate
                        let v155 : (string -> string) = v154 v153
                        let v156 : string = " "
                        let v157 : string = v155 v156
                        let v160 : string = "^"
                        let v161 : string = v157 + v160 
                        let v162 : string = $"{v152}
{v161}
"
                        US7_1(v162)
            let v282 : US8 =
                match v165 with
                | US7_1(v279) -> (* Error *)
                    US8_1(v279)
                | US7_0(v166, v167, v168, v169, v170) -> (* Ok *)
                    let v171 : UH2 = UH2_0
                    let v172 : US17 = method52(v171, v167, v168, v169, v170)
                    let v193 : US8 =
                        match v172 with
                        | US17_1(v190) -> (* Error *)
                            US8_1(v190)
                        | US17_0(v173, v174, v175, v176, v177) -> (* Ok *)
                            let v178 : string list = []
                            let v179 : string list = method56(v173, v178)
                            let v180 : string seq = seq { for i = 0 to v179.Length - 1 do yield v179.[i] }
                            let v183 : (string -> (string seq -> string)) = String.concat
                            let v184 : string = ""
                            let v185 : (string seq -> string) = v183 v184
                            let v186 : string = v185 v180
                            US8_0(v186, v174, v175, v176, v177)
                    match v193 with
                    | US8_1(v274) -> (* Error *)
                        let v275 : string = "between / expected content"
                        US8_1(v275)
                    | US8_0(v194, v195, v196, v197, v198) -> (* Ok *)
                        let v199 : bool = "" = v195
                        let v262 : US7 =
                            if v199 then
                                let v200 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v196, v197, v198)}"
                                US7_1(v200)
                            else
                                let v202 : char = v195.[int 0]
                                let v203 : bool = v202 = '"'
                                if v203 then
                                    let v204 : (string -> int32) = String.length
                                    let v205 : int32 = v204 v195
                                    let v206 : (int32 -> int32) = int32
                                    let v207 : int32 = v206 1
                                    let v208 : (int32 -> int32) = int32
                                    let v209 : int32 = v208 v205
                                    let v210 : string = v195.[int v207..int v209]
                                    let v211 : (char -> string) = _.ToString()
                                    let v212 : string = v211 v202
                                    let v215 : int32 = v212.Length
                                    let v216 : (char []) = Array.zeroCreate<char> (v215)
                                    let v217 : Mut5 = {l0 = 0} : Mut5
                                    while method24(v215, v217) do
                                        let v219 : int32 = v217.l0
                                        let v220 : char = v212.[int v219]
                                        v216.[int v219] <- v220
                                        let v221 : int32 = v219 + 1
                                        v217.l0 <- v221
                                        ()
                                    let v222 : char list = v216 |> Array.toList
                                    let v223 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v224 : (char -> (UH0 -> UH0)) = method25()
                                    let v225 : (char list -> (UH0 -> UH0)) = v223 v224
                                    let v226 : (UH0 -> UH0) = v225 v222
                                    let v227 : UH0 = UH0_0
                                    let v228 : UH0 = v226 v227
                                    let struct (v233 : System.Text.StringBuilder, v234 : int32, v235 : int32) = method26(v228, v196, v197, v198)
                                    US7_0(v202, v210, v233, v234, v235)
                                else
                                    let v237 : (string -> int32) = String.length
                                    let v238 : int32 = v237 v195
                                    let v239 : string = "\n"
                                    let v240 : int32 = v195.IndexOf v239 
                                    let v241 : int32 = v240 - 1
                                    let v242 : bool = -2 = v241
                                    let v243 : int32 =
                                        if v242 then
                                            v238
                                        else
                                            v241
                                    let v244 : (int32 -> int32) = int32
                                    let v245 : int32 = v244 0
                                    let v246 : (int32 -> int32) = int32
                                    let v247 : int32 = v246 v243
                                    let v248 : string = v195.[int v245..int v247]
                                    let v249 : string = $"parsing.p_char / expected: '{'"'}' / line: {v197} / col: {v198}
{v196}{v248}"
                                    let v250 : int32 = v198 - 1
                                    let v251 : (int32 -> (string -> string)) = String.replicate
                                    let v252 : (string -> string) = v251 v250
                                    let v253 : string = " "
                                    let v254 : string = v252 v253
                                    let v257 : string = "^"
                                    let v258 : string = v254 + v257 
                                    let v259 : string = $"{v249}
{v258}
"
                                    US7_1(v259)
                        match v262 with
                        | US7_1(v269) -> (* Error *)
                            let v270 : string = $"between / expected closing delimiter / e: %A{v269} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v167, v168, v169, v170)} / rest2: %A{struct (v195, v196, v197, v198)}"
                            US8_1(v270)
                        | US7_0(v263, v264, v265, v266, v267) -> (* Ok *)
                            US8_0(v194, v264, v265, v266, v267)
            match v282 with
            | US8_1(v288) -> (* Error *)
                let v289 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure30()
                let v290 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US8) = closure31()
                let v291 : UH3 = UH3_0
                let v292 : UH3 = UH3_1(v290, v291)
                let v293 : UH3 = UH3_1(v289, v292)
                let v294 : US8 = method54(v1, v2, v3, v4, v293)
                let v305 : US8 =
                    match v294 with
                    | US8_1(v302) -> (* Error *)
                        US8_1(v302)
                    | US8_0(v295, v296, v297, v298, v299) -> (* Ok *)
                        let v300 : string = ""
                        US8_0(v300, v296, v297, v298, v299)
                let v316 : US17 =
                    match v305 with
                    | US8_1(v313) -> (* Error *)
                        US17_1(v313)
                    | US8_0(v306, v307, v308, v309, v310) -> (* Ok *)
                        let v311 : UH2 = UH2_0
                        method57(v311, v307, v308, v309, v310)
                match v316 with
                | US17_1(v334) -> (* Error *)
                    US8_1(v334)
                | US17_0(v317, v318, v319, v320, v321) -> (* Ok *)
                    let v322 : string list = []
                    let v323 : string list = method56(v317, v322)
                    let v324 : string seq = seq { for i = 0 to v323.Length - 1 do yield v323.[i] }
                    let v327 : (string -> (string seq -> string)) = String.concat
                    let v328 : string = ""
                    let v329 : (string seq -> string) = v327 v328
                    let v330 : string = v329 v324
                    US8_0(v330, v318, v319, v320, v321)
            | US8_0(v283, v284, v285, v286, v287) -> (* Ok *)
                v282
        | US8_0(v97, v98, v99, v100, v101) -> (* Ok *)
            v96
    match v341 with
    | US8_1(v342) -> (* Error *)
        let v343 : UH2 = UH2_0
        let v344 : UH2 = method55(v0, v343)
        US17_0(v344, v1, v2, v3, v4)
    | US8_0(v346, v347, v348, v349, v350) -> (* Ok *)
        let v351 : int32 = 0
        let v352 : int32 = method58(v347, v351)
        let v353 : bool = 0 = v352
        let v364 : US10 =
            if v353 then
                let v354 : string = "spaces1 / expected at least one space"
                US10_1(v354)
            else
                let v356 : (string -> int32) = String.length
                let v357 : int32 = v356 v347
                let v358 : (int32 -> int32) = int32
                let v359 : int32 = v358 v352
                let v360 : (int32 -> int32) = int32
                let v361 : int32 = v360 v357
                let v362 : string = v347.[int v359..int v361]
                US10_0(v362, v348, v349, v350)
        match v364 with
        | US10_1(v365) -> (* Error *)
            let v366 : UH2 = UH2_0
            let v367 : UH2 = UH2_1(v346, v366)
            let v368 : UH2 = method55(v0, v367)
            US17_0(v368, v347, v348, v349, v350)
        | US10_0(v370, v371, v372, v373) -> (* Ok *)
            let v374 : UH2 = UH2_1(v346, v0)
            method49(v374, v370, v371, v372, v373)
and method48 (v0 : string) : US16 =
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
    let v10 : string = method23()
    let v11 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v12 : System.Text.StringBuilder = v11 v10
    let v13 : UH2 = UH2_0
    let v14 : int32 = 1
    let v15 : int32 = 1
    let v16 : US17 = method49(v13, v7, v12, v14, v15)
    match v16 with
    | US17_1(v29) -> (* Error *)
        US16_1(v29)
    | US17_0(v17, v18, v19, v20, v21) -> (* Ok *)
        let v22 : string list = []
        let v23 : string list = method56(v17, v22)
        let v24 : (string list -> (string [])) = List.toArray
        let v25 : (string []) = v24 v23
        US16_0(v25)
and closure29 () (v0 : string) : Result<(string []), string> =
    let v1 : US16 = method48(v0)
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
