#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
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
#endif
type Str = class end
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
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and [<Struct>] US4 =
    | US4_0 of f0_0 : string * f0_1 : US1
    | US4_1 of f1_0 : string
and [<Struct>] US5 =
    | US5_0 of f0_0 : char * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US5_1 of f1_0 : string
and Mut5 = {mutable l0 : int32}
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and UH1 =
    | UH1_0
    | UH1_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) * UH1
and [<Struct>] US6 =
    | US6_0 of f0_0 : string * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US6_1 of f1_0 : string
and [<Struct>] US7 =
    | US7_0 of f0_0 : char
    | US7_1
and [<Struct>] US8 =
    | US8_0 of f0_0 : string * f0_1 : System.Text.StringBuilder * f0_2 : int32 * f0_3 : int32
    | US8_1 of f1_0 : string
and [<Struct>] US9 =
    | US9_0 of f0_0 : string * f0_1 : US1 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US9_1 of f1_0 : string
and [<Struct>] US10 =
    | US10_0 of f0_0 : US7 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US10_1 of f1_0 : string
and [<Struct>] US11 =
    | US11_0 of f0_0 : US1 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US11_1 of f1_0 : string
and [<Struct>] US12 =
    | US12_0 of f0_0 : (struct (int32 * string * bool) -> Async<unit>)
    | US12_1
and [<Struct>] US13 =
    | US13_0 of f0_0 : System.Threading.CancellationToken
    | US13_1
and Heap0 = {l0 : string; l1 : System.Threading.CancellationToken option; l2 : (struct (string * string) []); l3 : (struct (int32 * string * bool) -> Async<unit>) option; l4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option; l5 : bool; l6 : string option}
and [<Struct>] US14 =
    | US14_0 of f0_0 : (string [])
    | US14_1 of f1_0 : string
and UH2 =
    | UH2_0
    | UH2_1 of string * UH2
and [<Struct>] US15 =
    | US15_0 of f0_0 : UH2 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US15_1 of f1_0 : string
and UH3 =
    | UH3_0
    | UH3_1 of (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) * UH3
let rec method1 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method3 () : string =
    let v0 : string = ""
    v0
and closure1 (v0 : US1 option ref) (v1 : US1 option) : US1 option ref =
    v0.Value <- v1 
    v0
and closure2 (v0 : string option, v1 : (US1 option -> US1 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : string = x
    let v3 : US1 = US1_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
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
    let v64 : US1 option = None
    let _v64 = ref v64 
    let v65 : US1 option ref = _v64 
    let v66 : (US1 option -> US1 option ref) = closure1(v65)
    let v67 : unit = ()
    let v68 : (unit -> unit) = closure2(v61, v66)
    let v69 : unit = (fun () -> v68 (); v67) ()
    let v72 : US1 option = _v64.Value 
    let v83 : US1 = US1_1
    let v84 : US1 = v72 |> Option.defaultValue v83 
    let v91 : string =
        match v84 with
        | US1_1 -> (* None *)
            let v89 : string = ""
            v89
        | US1_0(v88) -> (* Some *)
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
    let v99 : US1 option = None
    let _v99 = ref v99 
    let v100 : US1 option ref = _v99 
    let v101 : (US1 option -> US1 option ref) = closure1(v100)
    let v102 : unit = ()
    let v103 : (unit -> unit) = closure2(v96, v101)
    let v104 : unit = (fun () -> v103 (); v102) ()
    let v107 : US1 option = _v99.Value 
    let v118 : US1 = US1_1
    let v119 : US1 = v107 |> Option.defaultValue v118 
    let v126 : string =
        match v119 with
        | US1_1 -> (* None *)
            let v124 : string = ""
            v124
        | US1_0(v123) -> (* Some *)
            v123
    let _v1 = v126 
    #endif
    let v127 : string = _v1 
    v127
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure3 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) =
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
    let v359 : Mut0 = {l0 = 0L} : Mut0
    let v360 : (string -> unit) = closure3()
    let v361 : Mut1 = {l0 = v360} : Mut1
    let v362 : Mut2 = {l0 = true} : Mut2
    let v363 : string = ""
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v367 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v365) -> (* Some *)
            v365
    let v368 : Mut4 = {l0 = v367} : Mut4
    let v375 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v373 : int64 option = None
            v373
        | US3_0(v369) -> (* Some *)
            let v370 : int64 option = Some v369 
            v370
    struct (v359, v361, v362, v364, v368, v375)
and closure0 () () : unit =
    let v0 : bool = TraceState.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : Mut4, v7 : int64 option) = method0(v1)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * Mut4 * int64 option) option = Some struct (v2, v3, v4, v5, v6, v7) 
        TraceState.trace_state <- v8 
        ()
and closure7 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure8 (v0 : US3 option ref) (v1 : US3 option) : US3 option ref =
    v0.Value <- v1 
    v0
and closure9 (v0 : int64 option, v1 : (US3 option -> US3 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : int64 = x
    let v3 : US3 = US3_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
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
and closure11 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure10 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure11(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and closure6 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 3 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure7(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure8(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure9(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure8(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure9(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
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
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure8(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure9(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure8(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure9(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure8(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure9(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure8(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure9(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Warning"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_yellow"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_yellow"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_yellow"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[93m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[93m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[93m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = "runtime.current_process_kill / exiting... 3"
        let v640 : string = $"{v494} {v629} #{v635} %s{v639} / {v638}"
        let v643 : char list = []
        let v644 : (char list -> (char [])) = List.toArray
        let v645 : (char []) = v644 v643
        let v648 : string = v640.TrimStart v645 
        let v666 : char list = []
        let v667 : char list = '/' :: v666 
        let v670 : char list = ' ' :: v667 
        let v673 : (char list -> (char [])) = List.toArray
        let v674 : (char []) = v673 v670
        let v677 : string = v648.TrimEnd v674 
        let v695 : (string -> unit) = closure10()
        let v696 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v697 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v677 v697 
        let _v696 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v698 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v677 v698 
        let _v696 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v699 : string = v19.l0
        let v700 : bool = v699 = ""
        let v708 : string =
            if v700 then
                v677
            else
                let v701 : bool = v677 = ""
                if v701 then
                    let v702 : string = v19.l0
                    v702
                else
                    let v703 : string = v19.l0
                    let v704 : string = "\n"
                    let v705 : string = v703 + v704 
                    let v706 : string = v705 + v677 
                    v706
        let v709 : string = "&*$0"
        let v710 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v708 v709 
        let v711 : string = $"$0.chars()"
        let v712 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v710 v711 
        let v713 : string = "v712"
        let v714 : _ = Fable.Core.RustInterop.emitRustExpr () v713 
        let v715 : string = "v714.collect::<Vec<_>>()"
        let v716 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v715 
        let v717 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v718 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v716 v717 
        let v719 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v720 : bool = Fable.Core.RustInterop.emitRustExpr v718 v719 
        let v721 : string = "x"
        let v722 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v721 
        let v723 : string = "String::from_iter($0)"
        let v724 : std_string_String = Fable.Core.RustInterop.emitRustExpr v722 v723 
        let v725 : string = "true; $0 }).collect::<Vec<_>>()"
        let v726 : bool = Fable.Core.RustInterop.emitRustExpr v724 v725 
        let v727 : string = "_vec_map"
        let v728 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v727 
        let v729 : string = "$0.len()"
        let v730 : unativeint = Fable.Core.RustInterop.emitRustExpr v728 v729 
        let v731 : (unativeint -> int32) = int32
        let v732 : int32 = v731 v730
        let v733 : string = ""
        let v734 : bool = v677 <> v733 
        let v738 : bool =
            if v734 then
                let v737 : bool = v732 <= 1
                v737
            else
                false
        if v738 then
            v19.l0 <- v708
            ()
        else
            v19.l0 <- v733
            let v739 : string = "true; $0.into_iter().for_each(|x| { //"
            let v740 : bool = Fable.Core.RustInterop.emitRustExpr v728 v739 
            let v741 : string = "x"
            let v742 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v741 
            let v743 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v742 v743 
            let v744 : string = $"true;"
            let v745 : bool = Fable.Core.RustInterop.emitRustExpr () v744 
            let v746 : string = "true; }}); { //"
            let v747 : bool = Fable.Core.RustInterop.emitRustExpr () v746 
            ()
        let _v696 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v695 v677
        let _v696 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v695 v677
        let _v696 = () 
        #endif
#else
        v695 v677
        let _v696 = () 
        #endif
        _v696 
        let v748 : (string -> unit) = v17.l0
        v748 v677
and closure12 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 3 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure7(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure8(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure9(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure8(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure9(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
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
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure8(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure9(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure8(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure9(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure8(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure9(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure8(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure9(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Warning"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_yellow"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_yellow"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_yellow"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[93m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[93m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[93m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = "runtime.current_process_kill / exiting... 2"
        let v640 : string = $"{v494} {v629} #{v635} %s{v639} / {v638}"
        let v643 : char list = []
        let v644 : (char list -> (char [])) = List.toArray
        let v645 : (char []) = v644 v643
        let v648 : string = v640.TrimStart v645 
        let v666 : char list = []
        let v667 : char list = '/' :: v666 
        let v670 : char list = ' ' :: v667 
        let v673 : (char list -> (char [])) = List.toArray
        let v674 : (char []) = v673 v670
        let v677 : string = v648.TrimEnd v674 
        let v695 : (string -> unit) = closure10()
        let v696 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v697 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v677 v697 
        let _v696 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v698 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v677 v698 
        let _v696 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v699 : string = v19.l0
        let v700 : bool = v699 = ""
        let v708 : string =
            if v700 then
                v677
            else
                let v701 : bool = v677 = ""
                if v701 then
                    let v702 : string = v19.l0
                    v702
                else
                    let v703 : string = v19.l0
                    let v704 : string = "\n"
                    let v705 : string = v703 + v704 
                    let v706 : string = v705 + v677 
                    v706
        let v709 : string = "&*$0"
        let v710 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v708 v709 
        let v711 : string = $"$0.chars()"
        let v712 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v710 v711 
        let v713 : string = "v712"
        let v714 : _ = Fable.Core.RustInterop.emitRustExpr () v713 
        let v715 : string = "v714.collect::<Vec<_>>()"
        let v716 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v715 
        let v717 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v718 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v716 v717 
        let v719 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v720 : bool = Fable.Core.RustInterop.emitRustExpr v718 v719 
        let v721 : string = "x"
        let v722 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v721 
        let v723 : string = "String::from_iter($0)"
        let v724 : std_string_String = Fable.Core.RustInterop.emitRustExpr v722 v723 
        let v725 : string = "true; $0 }).collect::<Vec<_>>()"
        let v726 : bool = Fable.Core.RustInterop.emitRustExpr v724 v725 
        let v727 : string = "_vec_map"
        let v728 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v727 
        let v729 : string = "$0.len()"
        let v730 : unativeint = Fable.Core.RustInterop.emitRustExpr v728 v729 
        let v731 : (unativeint -> int32) = int32
        let v732 : int32 = v731 v730
        let v733 : string = ""
        let v734 : bool = v677 <> v733 
        let v738 : bool =
            if v734 then
                let v737 : bool = v732 <= 1
                v737
            else
                false
        if v738 then
            v19.l0 <- v708
            ()
        else
            v19.l0 <- v733
            let v739 : string = "true; $0.into_iter().for_each(|x| { //"
            let v740 : bool = Fable.Core.RustInterop.emitRustExpr v728 v739 
            let v741 : string = "x"
            let v742 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v741 
            let v743 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v742 v743 
            let v744 : string = $"true;"
            let v745 : bool = Fable.Core.RustInterop.emitRustExpr () v744 
            let v746 : string = "true; }}); { //"
            let v747 : bool = Fable.Core.RustInterop.emitRustExpr () v746 
            ()
        let _v696 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v695 v677
        let _v696 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v695 v677
        let _v696 = () 
        #endif
#else
        v695 v677
        let _v696 = () 
        #endif
        _v696 
        let v748 : (string -> unit) = v17.l0
        v748 v677
and closure13 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : unit = ()
    let v35 : unit = (fun () -> v1 (); v34) ()
    let struct (v49 : Mut0, v50 : Mut1, v51 : Mut2, v52 : Mut3, v53 : Mut4, v54 : int64 option) = TraceState.trace_state.Value
    let v67 : US0 = v53.l0
    let v68 : bool = v51.l0
    let v69 : bool = v68 = false
    let v72 : bool =
        if v69 then
            false
        else
            let v70 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v67
            let v71 : bool = 3 >= v70
            v71
    if v72 then
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure7(v16)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        let v111 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v112 : US3 option = None
        let _v112 = ref v112 
        let v113 : US3 option ref = _v112 
        let v114 : (US3 option -> US3 option ref) = closure8(v113)
        let v115 : unit = ()
        let v116 : (unit -> unit) = closure9(v98, v114)
        let v117 : unit = (fun () -> v116 (); v115) ()
        let v120 : US3 option = _v112.Value 
        let v131 : US3 = US3_1
        let v132 : US3 = v120 |> Option.defaultValue v131 
        let v172 : System.DateTime =
            match v132 with
            | US3_1 -> (* None *)
                let v168 : System.DateTime = System.DateTime.Now
                v168
            | US3_0(v136) -> (* Some *)
                let v137 : System.DateTime = System.DateTime.Now
                let v140 : (System.DateTime -> int64) = _.Ticks
                let v141 : int64 = v140 v137
                let v144 : int64 = v141 - v136
                let v145 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v146 : System.TimeSpan = v145 v144
                let v149 : (System.TimeSpan -> int32) = _.Hours
                let v150 : int32 = v149 v146
                let v153 : (System.TimeSpan -> int32) = _.Minutes
                let v154 : int32 = v153 v146
                let v157 : (System.TimeSpan -> int32) = _.Seconds
                let v158 : int32 = v157 v146
                let v161 : (System.TimeSpan -> int32) = _.Milliseconds
                let v162 : int32 = v161 v146
                let v165 : System.DateTime = System.DateTime (1, 1, 1, v150, v154, v158, v162)
                v165
        let v173 : string = method5()
        let v176 : (string -> string) = v172.ToString
        let v177 : string = v176 v173
        let _v111 = v177 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v180 : US3 option = None
        let _v180 = ref v180 
        let v181 : US3 option ref = _v180 
        let v182 : (US3 option -> US3 option ref) = closure8(v181)
        let v183 : unit = ()
        let v184 : (unit -> unit) = closure9(v98, v182)
        let v185 : unit = (fun () -> v184 (); v183) ()
        let v188 : US3 option = _v180.Value 
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
        let _v111 = v245 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v248 : string = $"near_sdk::env::block_timestamp()"
        let v249 : uint64 = Fable.Core.RustInterop.emitRustExpr () v248 
        let v250 : US3 option = None
        let _v250 = ref v250 
        let v251 : US3 option ref = _v250 
        let v252 : (US3 option -> US3 option ref) = closure8(v251)
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure9(v98, v252)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v258 : US3 option = _v250.Value 
        let v269 : US3 = US3_1
        let v270 : US3 = v258 |> Option.defaultValue v269 
        let v279 : uint64 =
            match v270 with
            | US3_1 -> (* None *)
                v249
            | US3_0(v274) -> (* Some *)
                let v275 : (int64 -> uint64) = uint64
                let v276 : uint64 = v275 v274
                let v277 : uint64 = v249 - v276
                v277
        let v280 : uint64 = v279 / 1000000000UL
        let v281 : uint64 = v280 % 60UL
        let v282 : uint64 = v280 / 60UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v280 / 3600UL
        let v285 : uint64 = v284 % 24UL
        let v286 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v287 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v285, v283, v281) v286 
        let v288 : string = "fable_library_rust::String_::fromString($0)"
        let v289 : string = Fable.Core.RustInterop.emitRustExpr v287 v288 
        let _v111 = v289 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v290 : US3 option = None
        let _v290 = ref v290 
        let v291 : US3 option ref = _v290 
        let v292 : (US3 option -> US3 option ref) = closure8(v291)
        let v293 : unit = ()
        let v294 : (unit -> unit) = closure9(v98, v292)
        let v295 : unit = (fun () -> v294 (); v293) ()
        let v298 : US3 option = _v290.Value 
        let v309 : US3 = US3_1
        let v310 : US3 = v298 |> Option.defaultValue v309 
        let v350 : System.DateTime =
            match v310 with
            | US3_1 -> (* None *)
                let v346 : System.DateTime = System.DateTime.Now
                v346
            | US3_0(v314) -> (* Some *)
                let v315 : System.DateTime = System.DateTime.Now
                let v318 : (System.DateTime -> int64) = _.Ticks
                let v319 : int64 = v318 v315
                let v322 : int64 = v319 - v314
                let v323 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v324 : System.TimeSpan = v323 v322
                let v327 : (System.TimeSpan -> int32) = _.Hours
                let v328 : int32 = v327 v324
                let v331 : (System.TimeSpan -> int32) = _.Minutes
                let v332 : int32 = v331 v324
                let v335 : (System.TimeSpan -> int32) = _.Seconds
                let v336 : int32 = v335 v324
                let v339 : (System.TimeSpan -> int32) = _.Milliseconds
                let v340 : int32 = v339 v324
                let v343 : System.DateTime = System.DateTime (1, 1, 1, v328, v332, v336, v340)
                v343
        let v351 : string = method6()
        let v354 : (string -> string) = v350.ToString
        let v355 : string = v354 v351
        let _v111 = v355 
        #endif
#if FABLE_COMPILER_PYTHON
        let v358 : US3 option = None
        let _v358 = ref v358 
        let v359 : US3 option ref = _v358 
        let v360 : (US3 option -> US3 option ref) = closure8(v359)
        let v361 : unit = ()
        let v362 : (unit -> unit) = closure9(v98, v360)
        let v363 : unit = (fun () -> v362 (); v361) ()
        let v366 : US3 option = _v358.Value 
        let v377 : US3 = US3_1
        let v378 : US3 = v366 |> Option.defaultValue v377 
        let v418 : System.DateTime =
            match v378 with
            | US3_1 -> (* None *)
                let v414 : System.DateTime = System.DateTime.Now
                v414
            | US3_0(v382) -> (* Some *)
                let v383 : System.DateTime = System.DateTime.Now
                let v386 : (System.DateTime -> int64) = _.Ticks
                let v387 : int64 = v386 v383
                let v390 : int64 = v387 - v382
                let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v392 : System.TimeSpan = v391 v390
                let v395 : (System.TimeSpan -> int32) = _.Hours
                let v396 : int32 = v395 v392
                let v399 : (System.TimeSpan -> int32) = _.Minutes
                let v400 : int32 = v399 v392
                let v403 : (System.TimeSpan -> int32) = _.Seconds
                let v404 : int32 = v403 v392
                let v407 : (System.TimeSpan -> int32) = _.Milliseconds
                let v408 : int32 = v407 v392
                let v411 : System.DateTime = System.DateTime (1, 1, 1, v396, v400, v404, v408)
                v411
        let v419 : string = method6()
        let v422 : (string -> string) = v418.ToString
        let v423 : string = v422 v419
        let _v111 = v423 
        #endif
#else
        let v426 : US3 option = None
        let _v426 = ref v426 
        let v427 : US3 option ref = _v426 
        let v428 : (US3 option -> US3 option ref) = closure8(v427)
        let v429 : unit = ()
        let v430 : (unit -> unit) = closure9(v98, v428)
        let v431 : unit = (fun () -> v430 (); v429) ()
        let v434 : US3 option = _v426.Value 
        let v445 : US3 = US3_1
        let v446 : US3 = v434 |> Option.defaultValue v445 
        let v486 : System.DateTime =
            match v446 with
            | US3_1 -> (* None *)
                let v482 : System.DateTime = System.DateTime.Now
                v482
            | US3_0(v450) -> (* Some *)
                let v451 : System.DateTime = System.DateTime.Now
                let v454 : (System.DateTime -> int64) = _.Ticks
                let v455 : int64 = v454 v451
                let v458 : int64 = v455 - v450
                let v459 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v460 : System.TimeSpan = v459 v458
                let v463 : (System.TimeSpan -> int32) = _.Hours
                let v464 : int32 = v463 v460
                let v467 : (System.TimeSpan -> int32) = _.Minutes
                let v468 : int32 = v467 v460
                let v471 : (System.TimeSpan -> int32) = _.Seconds
                let v472 : int32 = v471 v460
                let v475 : (System.TimeSpan -> int32) = _.Milliseconds
                let v476 : int32 = v475 v460
                let v479 : System.DateTime = System.DateTime (1, 1, 1, v464, v468, v472, v476)
                v479
        let v487 : string = method6()
        let v490 : (string -> string) = v486.ToString
        let v491 : string = v490 v487
        let _v111 = v491 
        #endif
        let v494 : string = _v111 
        
        
        
        
        
        let v564 : string = "Warning"
        let v565 : (unit -> string) = v564.ToLower
        let v566 : string = v565 ()
        let v569 : string = v566.PadLeft (7, ' ')
        let v583 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v584 : string = "inline_colorization::color_yellow"
        let v585 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v584 
        let v586 : string = "&*$0"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v586 
        let v588 : string = "inline_colorization::color_reset"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v588 
        let v590 : string = "\"{v585}{v587}{v589}\""
        let v591 : string = @$"format!(" + v590 + ")"
        let v592 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "fable_library_rust::String_::fromString($0)"
        let v594 : string = Fable.Core.RustInterop.emitRustExpr v592 v593 
        let _v583 = v594 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v595 : string = "inline_colorization::color_yellow"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "&*$0"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v597 
        let v599 : string = "inline_colorization::color_reset"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v599 
        let v601 : string = "\"{v596}{v598}{v600}\""
        let v602 : string = @$"format!(" + v601 + ")"
        let v603 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "fable_library_rust::String_::fromString($0)"
        let v605 : string = Fable.Core.RustInterop.emitRustExpr v603 v604 
        let _v583 = v605 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v606 : string = "inline_colorization::color_yellow"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "&*$0"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v569 v608 
        let v610 : string = "inline_colorization::color_reset"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v610 
        let v612 : string = "\"{v607}{v609}{v611}\""
        let v613 : string = @$"format!(" + v612 + ")"
        let v614 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "fable_library_rust::String_::fromString($0)"
        let v616 : string = Fable.Core.RustInterop.emitRustExpr v614 v615 
        let _v583 = v616 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v617 : string = "\u001b[93m"
        let v618 : string = method7()
        let v619 : string = v617 + v569 
        let v620 : string = v619 + v618 
        let _v583 = v620 
        #endif
#if FABLE_COMPILER_PYTHON
        let v621 : string = "\u001b[93m"
        let v622 : string = method7()
        let v623 : string = v621 + v569 
        let v624 : string = v623 + v622 
        let _v583 = v624 
        #endif
#else
        let v625 : string = "\u001b[93m"
        let v626 : string = method7()
        let v627 : string = v625 + v569 
        let v628 : string = v627 + v626 
        let _v583 = v628 
        #endif
        let v629 : string = _v583 
        let v635 : int64 = v93.l0
        let v636 : string = method8()
        let v637 : Mut3 = {l0 = v636} : Mut3
        let v638 : string = v637.l0
        let v639 : string = "runtime.current_process_kill / exiting... 1"
        let v640 : string = $"{v494} {v629} #{v635} %s{v639} / {v638}"
        let v643 : char list = []
        let v644 : (char list -> (char [])) = List.toArray
        let v645 : (char []) = v644 v643
        let v648 : string = v640.TrimStart v645 
        let v666 : char list = []
        let v667 : char list = '/' :: v666 
        let v670 : char list = ' ' :: v667 
        let v673 : (char list -> (char [])) = List.toArray
        let v674 : (char []) = v673 v670
        let v677 : string = v648.TrimEnd v674 
        let v695 : (string -> unit) = closure10()
        let v696 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v697 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v677 v697 
        let _v696 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v698 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v677 v698 
        let _v696 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v699 : string = v19.l0
        let v700 : bool = v699 = ""
        let v708 : string =
            if v700 then
                v677
            else
                let v701 : bool = v677 = ""
                if v701 then
                    let v702 : string = v19.l0
                    v702
                else
                    let v703 : string = v19.l0
                    let v704 : string = "\n"
                    let v705 : string = v703 + v704 
                    let v706 : string = v705 + v677 
                    v706
        let v709 : string = "&*$0"
        let v710 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v708 v709 
        let v711 : string = $"$0.chars()"
        let v712 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v710 v711 
        let v713 : string = "v712"
        let v714 : _ = Fable.Core.RustInterop.emitRustExpr () v713 
        let v715 : string = "v714.collect::<Vec<_>>()"
        let v716 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v715 
        let v717 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v718 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v716 v717 
        let v719 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v720 : bool = Fable.Core.RustInterop.emitRustExpr v718 v719 
        let v721 : string = "x"
        let v722 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v721 
        let v723 : string = "String::from_iter($0)"
        let v724 : std_string_String = Fable.Core.RustInterop.emitRustExpr v722 v723 
        let v725 : string = "true; $0 }).collect::<Vec<_>>()"
        let v726 : bool = Fable.Core.RustInterop.emitRustExpr v724 v725 
        let v727 : string = "_vec_map"
        let v728 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v727 
        let v729 : string = "$0.len()"
        let v730 : unativeint = Fable.Core.RustInterop.emitRustExpr v728 v729 
        let v731 : (unativeint -> int32) = int32
        let v732 : int32 = v731 v730
        let v733 : string = ""
        let v734 : bool = v677 <> v733 
        let v738 : bool =
            if v734 then
                let v737 : bool = v732 <= 1
                v737
            else
                false
        if v738 then
            v19.l0 <- v708
            ()
        else
            v19.l0 <- v733
            let v739 : string = "true; $0.into_iter().for_each(|x| { //"
            let v740 : bool = Fable.Core.RustInterop.emitRustExpr v728 v739 
            let v741 : string = "x"
            let v742 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v741 
            let v743 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v742 v743 
            let v744 : string = $"true;"
            let v745 : bool = Fable.Core.RustInterop.emitRustExpr () v744 
            let v746 : string = "true; }}); { //"
            let v747 : bool = Fable.Core.RustInterop.emitRustExpr () v746 
            ()
        let _v696 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v695 v677
        let _v696 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v695 v677
        let _v696 = () 
        #endif
#else
        v695 v677
        let _v696 = () 
        #endif
        _v696 
        let v748 : (string -> unit) = v17.l0
        v748 v677
and closure5 () () : unit =
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
#else
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure6()
    let v3 : unit = (fun () -> v2 (); v1) ()
    System.Threading.Thread.Sleep 300
    let v753 : unit = ()
    let v754 : (unit -> unit) = closure12()
    let v755 : unit = (fun () -> v754 (); v753) ()
    System.Console.Out.Flush ()
    System.Threading.Thread.Sleep 60
    let v1505 : unit = ()
    let v1506 : (unit -> unit) = closure13()
    let v1507 : unit = (fun () -> v1506 (); v1505) ()
    System.Diagnostics.Process.GetCurrentProcess().Kill ()
    let _v0 = () 
    #endif
    _v0 
    ()
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
#else
    let v1 : (unit -> unit) = closure5()
    let v2 : System.Threading.Thread = new System.Threading.Thread (v1)
    let v3 : (System.Threading.Thread -> unit) = _.Start()
    v3 v2
    let _v0 = () 
    #endif
    _v0 
    ()
and method11 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure17 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure16 () (v0 : char) : (UH0 -> UH0) =
    closure17(v0)
and method12 () : (char -> (UH0 -> UH0)) =
    closure16()
and method13 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method13(v5, v19, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure15 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
        US5_1(v5)
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
            while method11(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method12()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method13(v33, v1, v2, v3)
            US5_0(v7, v15, v38, v39, v40)
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
            US5_1(v64)
and closure18 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
    let v4 : bool = "" = v0
    if v4 then
        let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
        US5_1(v5)
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
            while method11(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method12()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method13(v33, v1, v2, v3)
            US5_0(v7, v15, v38, v39, v40)
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
            US5_1(v64)
and method14 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US5 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US5 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US5_1(v13) -> (* Error *)
            method14(v0, v1, v6)
        | US5_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "choice / no parsers succeeded"
        US5_1(v3)
and method15 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 2L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v11 : US7 =
            if v3 then
                US7_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US7_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    US7_1
        let v15 : char =
            match v11 with
            | US7_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US7_0(v12) -> (* Some *)
                v12
        let v16 : bool = v0 = v15
        if v16 then
            true
        else
            let v17 : int64 = v1 + 1L
            method15(v0, v17)
and method16 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v70 : US5 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ''' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : (char list -> (char [])) = List.toArray
            let v14 : (char []) = v13 v10
            let v17 : string = $"parsing.none_of / unexpected end of input / chars: %A{v14} / s: %A{struct (v2, v3, v4)}"
            US5_1(v17)
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
            let v28 : bool = method15(v19, v27)
            let v29 : bool = v28 = false
            if v29 then
                let v30 : (char -> string) = _.ToString()
                let v31 : string = v30 v19
                let v34 : int32 = v31.Length
                let v35 : (char []) = Array.zeroCreate<char> (v34)
                let v36 : Mut5 = {l0 = 0} : Mut5
                while method11(v34, v36) do
                    let v38 : int32 = v36.l0
                    let v39 : char = v31.[int v38]
                    v35.[int v38] <- v39
                    let v40 : int32 = v38 + 1
                    v36.l0 <- v40
                    ()
                let v41 : char list = v35 |> Array.toList
                let v42 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v43 : (char -> (UH0 -> UH0)) = method12()
                let v44 : (char list -> (UH0 -> UH0)) = v42 v43
                let v45 : (UH0 -> UH0) = v44 v41
                let v46 : UH0 = UH0_0
                let v47 : UH0 = v45 v46
                let struct (v52 : System.Text.StringBuilder, v53 : int32, v54 : int32) = method13(v47, v2, v3, v4)
                US5_0(v19, v26, v52, v53, v54)
            else
                let v56 : char list = []
                let v57 : char list = ''' :: v56 
                let v60 : char list = '"' :: v57 
                let v63 : (char list -> (char [])) = List.toArray
                let v64 : (char []) = v63 v60
                let v67 : string = $"parsing.none_of / unexpected char: '{v19}' / chars: %A{v64} / s: %A{struct (v2, v3, v4)}"
                US5_1(v67)
    let v82 : US5 =
        match v70 with
        | US5_1(v79) -> (* Error *)
            US5_1(v79)
        | US5_0(v71, v72, v73, v74, v75) -> (* Ok *)
            let v76 : bool = '\\' = v71
            let v77 : char =
                if v76 then
                    '/'
                else
                    v71
            US5_0(v77, v72, v73, v74, v75)
    match v82 with
    | US5_1(v94) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v83, v84, v85, v86, v87) -> (* Ok *)
        let v88 : (char -> string) = _.ToString()
        let v89 : string = v88 v83
        let v92 : string = v0 + v89 
        method16(v92, v84, v85, v86, v87)
and method17 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US5 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US5 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US5_1(v15) -> (* Error *)
            method17(v0, v1, v2, v3, v8)
        | US5_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US5_1(v5)
and method18 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US7 =
            if v3 then
                US7_0('"')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US7_0(''')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US7_0(' ')
                    else
                        let v11 : int64 = v8 - 1L
                        US7_1
        let v19 : char =
            match v15 with
            | US7_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US7_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method18(v0, v21)
and method19 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v76 : US5 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = ''' :: v7 
            let v13 : char list = '"' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US5_1(v20)
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
            let v31 : bool = method18(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method11(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method12()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method13(v50, v2, v3, v4)
                US5_0(v22, v29, v55, v56, v57)
            else
                let v59 : char list = []
                let v60 : char list = ' ' :: v59 
                let v63 : char list = ''' :: v60 
                let v66 : char list = '"' :: v63 
                let v69 : (char list -> (char [])) = List.toArray
                let v70 : (char []) = v69 v66
                let v73 : string = $"parsing.none_of / unexpected char: '{v22}' / chars: %A{v70} / s: %A{struct (v2, v3, v4)}"
                US5_1(v73)
    let v88 : US5 =
        match v76 with
        | US5_1(v85) -> (* Error *)
            US5_1(v85)
        | US5_0(v77, v78, v79, v80, v81) -> (* Ok *)
            let v82 : bool = '\\' = v77
            let v83 : char =
                if v82 then
                    '/'
                else
                    v77
            US5_0(v83, v78, v79, v80, v81)
    match v88 with
    | US5_1(v100) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v89, v90, v91, v92, v93) -> (* Ok *)
        let v94 : (char -> string) = _.ToString()
        let v95 : string = v94 v89
        let v98 : string = v0 + v95 
        method19(v98, v90, v91, v92, v93)
and method20 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method20(v0, v6)
        else
            v1
and method21 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v42 : US5 =
        if v5 then
            let v6 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
            US5_1(v6)
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
            while method11(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method12()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method13(v33, v2, v3, v4)
            US5_0(v8, v15, v38, v39, v40)
    match v42 with
    | US5_1(v54) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v43, v44, v45, v46, v47) -> (* Ok *)
        let v48 : (char -> string) = _.ToString()
        let v49 : string = v48 v43
        let v52 : string = v0 + v49 
        method21(v52, v44, v45, v46, v47)
and method10 (v0 : string) : US4 =
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
    let v10 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v11 : System.Text.StringBuilder = v10 v6
    let v12 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure15()
    let v13 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure18()
    let v14 : UH1 = UH1_0
    let v15 : UH1 = UH1_1(v13, v14)
    let v16 : UH1 = UH1_1(v12, v15)
    let v17 : US5 = method14(v7, v11, v16)
    let v153 : US6 =
        match v17 with
        | US5_1(v150) -> (* Error *)
            US6_1(v150)
        | US5_0(v18, v19, v20, v21, v22) -> (* Ok *)
            let v23 : bool = "" = v19
            let v88 : US5 =
                if v23 then
                    let v24 : char list = []
                    let v25 : char list = ''' :: v24 
                    let v28 : char list = '"' :: v25 
                    let v31 : (char list -> (char [])) = List.toArray
                    let v32 : (char []) = v31 v28
                    let v35 : string = $"parsing.none_of / unexpected end of input / chars: %A{v32} / s: %A{struct (v20, v21, v22)}"
                    US5_1(v35)
                else
                    let v37 : char = v19.[int 0]
                    let v38 : (string -> int32) = String.length
                    let v39 : int32 = v38 v19
                    let v40 : (int32 -> int32) = int32
                    let v41 : int32 = v40 1
                    let v42 : (int32 -> int32) = int32
                    let v43 : int32 = v42 v39
                    let v44 : string = v19.[int v41..int v43]
                    let v45 : int64 = 0L
                    let v46 : bool = method15(v37, v45)
                    let v47 : bool = v46 = false
                    if v47 then
                        let v48 : (char -> string) = _.ToString()
                        let v49 : string = v48 v37
                        let v52 : int32 = v49.Length
                        let v53 : (char []) = Array.zeroCreate<char> (v52)
                        let v54 : Mut5 = {l0 = 0} : Mut5
                        while method11(v52, v54) do
                            let v56 : int32 = v54.l0
                            let v57 : char = v49.[int v56]
                            v53.[int v56] <- v57
                            let v58 : int32 = v56 + 1
                            v54.l0 <- v58
                            ()
                        let v59 : char list = v53 |> Array.toList
                        let v60 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v61 : (char -> (UH0 -> UH0)) = method12()
                        let v62 : (char list -> (UH0 -> UH0)) = v60 v61
                        let v63 : (UH0 -> UH0) = v62 v59
                        let v64 : UH0 = UH0_0
                        let v65 : UH0 = v63 v64
                        let struct (v70 : System.Text.StringBuilder, v71 : int32, v72 : int32) = method13(v65, v20, v21, v22)
                        US5_0(v37, v44, v70, v71, v72)
                    else
                        let v74 : char list = []
                        let v75 : char list = ''' :: v74 
                        let v78 : char list = '"' :: v75 
                        let v81 : (char list -> (char [])) = List.toArray
                        let v82 : (char []) = v81 v78
                        let v85 : string = $"parsing.none_of / unexpected char: '{v37}' / chars: %A{v82} / s: %A{struct (v20, v21, v22)}"
                        US5_1(v85)
            let v100 : US5 =
                match v88 with
                | US5_1(v97) -> (* Error *)
                    US5_1(v97)
                | US5_0(v89, v90, v91, v92, v93) -> (* Ok *)
                    let v94 : bool = '\\' = v89
                    let v95 : char =
                        if v94 then
                            '/'
                        else
                            v89
                    US5_0(v95, v90, v91, v92, v93)
            let v114 : US6 =
                match v100 with
                | US5_1(v101) -> (* Error *)
                    US6_1(v101)
                | US5_0(v103, v104, v105, v106, v107) -> (* Ok *)
                    let v108 : (char -> string) = _.ToString()
                    let v109 : string = v108 v103
                    method16(v109, v104, v105, v106, v107)
            let v124 : US6 =
                match v114 with
                | US6_1(v121) -> (* Error *)
                    US6_0(v6, v19, v20, v21, v22)
                | US6_0(v115, v116, v117, v118, v119) -> (* Ok *)
                    US6_0(v115, v116, v117, v118, v119)
            match v124 with
            | US6_1(v145) -> (* Error *)
                let v146 : string = "between / expected content"
                US6_1(v146)
            | US6_0(v125, v126, v127, v128, v129) -> (* Ok *)
                let v130 : UH1 = UH1_0
                let v131 : UH1 = UH1_1(v13, v130)
                let v132 : UH1 = UH1_1(v12, v131)
                let v133 : US5 = method17(v126, v127, v128, v129, v132)
                match v133 with
                | US5_1(v140) -> (* Error *)
                    let v141 : string = $"between / expected closing delimiter / e: %A{v140} / input: %A{struct (v7, v11, 1, 1)} / rest1: %A{struct (v19, v20, v21, v22)} / rest2: %A{struct (v126, v127, v128, v129)}"
                    US6_1(v141)
                | US5_0(v134, v135, v136, v137, v138) -> (* Ok *)
                    US6_0(v125, v135, v136, v137, v138)
    let v303 : US6 =
        match v153 with
        | US6_1(v159) -> (* Error *)
            let v160 : bool = "" = v7
            let v233 : US5 =
                if v160 then
                    let v161 : char list = []
                    let v162 : char list = ' ' :: v161 
                    let v165 : char list = ''' :: v162 
                    let v168 : char list = '"' :: v165 
                    let v171 : (char list -> (char [])) = List.toArray
                    let v172 : (char []) = v171 v168
                    let v175 : string = $"parsing.none_of / unexpected end of input / chars: %A{v172} / s: %A{struct (v11, 1, 1)}"
                    US5_1(v175)
                else
                    let v177 : char = v7.[int 0]
                    let v178 : (string -> int32) = String.length
                    let v179 : int32 = v178 v7
                    let v180 : (int32 -> int32) = int32
                    let v181 : int32 = v180 1
                    let v182 : (int32 -> int32) = int32
                    let v183 : int32 = v182 v179
                    let v184 : string = v7.[int v181..int v183]
                    let v185 : int64 = 0L
                    let v186 : bool = method18(v177, v185)
                    let v187 : bool = v186 = false
                    if v187 then
                        let v188 : (char -> string) = _.ToString()
                        let v189 : string = v188 v177
                        let v192 : int32 = v189.Length
                        let v193 : (char []) = Array.zeroCreate<char> (v192)
                        let v194 : Mut5 = {l0 = 0} : Mut5
                        while method11(v192, v194) do
                            let v196 : int32 = v194.l0
                            let v197 : char = v189.[int v196]
                            v193.[int v196] <- v197
                            let v198 : int32 = v196 + 1
                            v194.l0 <- v198
                            ()
                        let v199 : char list = v193 |> Array.toList
                        let v200 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v201 : (char -> (UH0 -> UH0)) = method12()
                        let v202 : (char list -> (UH0 -> UH0)) = v200 v201
                        let v203 : (UH0 -> UH0) = v202 v199
                        let v204 : UH0 = UH0_0
                        let v205 : UH0 = v203 v204
                        let v210 : int32 = 1
                        let v211 : int32 = 1
                        let struct (v212 : System.Text.StringBuilder, v213 : int32, v214 : int32) = method13(v205, v11, v210, v211)
                        US5_0(v177, v184, v212, v213, v214)
                    else
                        let v216 : char list = []
                        let v217 : char list = ' ' :: v216 
                        let v220 : char list = ''' :: v217 
                        let v223 : char list = '"' :: v220 
                        let v226 : (char list -> (char [])) = List.toArray
                        let v227 : (char []) = v226 v223
                        let v230 : string = $"parsing.none_of / unexpected char: '{v177}' / chars: %A{v227} / s: %A{struct (v11, 1, 1)}"
                        US5_1(v230)
            let v245 : US5 =
                match v233 with
                | US5_1(v242) -> (* Error *)
                    US5_1(v242)
                | US5_0(v234, v235, v236, v237, v238) -> (* Ok *)
                    let v239 : bool = '\\' = v234
                    let v240 : char =
                        if v239 then
                            '/'
                        else
                            v234
                    US5_0(v240, v235, v236, v237, v238)
            let v259 : US6 =
                match v245 with
                | US5_1(v246) -> (* Error *)
                    US6_1(v246)
                | US5_0(v248, v249, v250, v251, v252) -> (* Ok *)
                    let v253 : (char -> string) = _.ToString()
                    let v254 : string = v253 v248
                    method19(v254, v249, v250, v251, v252)
            match v259 with
            | US6_1(v265) -> (* Error *)
                let v266 : int32 = v7.Length
                let v267 : bool = v266 = 0
                let v271 : US8 =
                    if v267 then
                        US8_0(v7, v11, 1, 1)
                    else
                        let v269 : string = $"parsing.eof / expected end of input / input: %A{v7}"
                        US8_1(v269)
                let v280 : US6 =
                    match v271 with
                    | US8_1(v277) -> (* Error *)
                        US6_1(v277)
                    | US8_0(v272, v273, v274, v275) -> (* Ok *)
                        US6_0(v6, v272, v273, v274, v275)
                match v280 with
                | US6_1(v296) -> (* Error *)
                    US6_1(v296)
                | US6_0(v281, v282, v283, v284, v285) -> (* Ok *)
                    let v286 : int32 = 0
                    let v287 : int32 = method20(v282, v286)
                    let v288 : (string -> int32) = String.length
                    let v289 : int32 = v288 v282
                    let v290 : (int32 -> int32) = int32
                    let v291 : int32 = v290 v287
                    let v292 : (int32 -> int32) = int32
                    let v293 : int32 = v292 v289
                    let v294 : string = v282.[int v291..int v293]
                    US6_0(v281, v294, v283, v284, v285)
            | US6_0(v260, v261, v262, v263, v264) -> (* Ok *)
                v259
        | US6_0(v154, v155, v156, v157, v158) -> (* Ok *)
            v153
    let v471 : US9 =
        match v303 with
        | US6_1(v468) -> (* Error *)
            US9_1(v468)
        | US6_0(v304, v305, v306, v307, v308) -> (* Ok *)
            let v309 : bool = "" = v305
            let v372 : US5 =
                if v309 then
                    let v310 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v306, v307, v308)}"
                    US5_1(v310)
                else
                    let v312 : char = v305.[int 0]
                    let v313 : bool = v312 = ' '
                    if v313 then
                        let v314 : (string -> int32) = String.length
                        let v315 : int32 = v314 v305
                        let v316 : (int32 -> int32) = int32
                        let v317 : int32 = v316 1
                        let v318 : (int32 -> int32) = int32
                        let v319 : int32 = v318 v315
                        let v320 : string = v305.[int v317..int v319]
                        let v321 : (char -> string) = _.ToString()
                        let v322 : string = v321 v312
                        let v325 : int32 = v322.Length
                        let v326 : (char []) = Array.zeroCreate<char> (v325)
                        let v327 : Mut5 = {l0 = 0} : Mut5
                        while method11(v325, v327) do
                            let v329 : int32 = v327.l0
                            let v330 : char = v322.[int v329]
                            v326.[int v329] <- v330
                            let v331 : int32 = v329 + 1
                            v327.l0 <- v331
                            ()
                        let v332 : char list = v326 |> Array.toList
                        let v333 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v334 : (char -> (UH0 -> UH0)) = method12()
                        let v335 : (char list -> (UH0 -> UH0)) = v333 v334
                        let v336 : (UH0 -> UH0) = v335 v332
                        let v337 : UH0 = UH0_0
                        let v338 : UH0 = v336 v337
                        let struct (v343 : System.Text.StringBuilder, v344 : int32, v345 : int32) = method13(v338, v306, v307, v308)
                        US5_0(v312, v320, v343, v344, v345)
                    else
                        let v347 : (string -> int32) = String.length
                        let v348 : int32 = v347 v305
                        let v349 : string = "\n"
                        let v350 : int32 = v305.IndexOf v349 
                        let v351 : int32 = v350 - 1
                        let v352 : bool = -2 = v351
                        let v353 : int32 =
                            if v352 then
                                v348
                            else
                                v351
                        let v354 : (int32 -> int32) = int32
                        let v355 : int32 = v354 0
                        let v356 : (int32 -> int32) = int32
                        let v357 : int32 = v356 v353
                        let v358 : string = v305.[int v355..int v357]
                        let v359 : string = $"parsing.p_char / expected: '{' '}' / line: {v307} / col: {v308}
{v306}{v358}"
                        let v360 : int32 = v308 - 1
                        let v361 : (int32 -> (string -> string)) = String.replicate
                        let v362 : (string -> string) = v361 v360
                        let v363 : string = " "
                        let v364 : string = v362 v363
                        let v367 : string = "^"
                        let v368 : string = v364 + v367 
                        let v369 : string = $"{v359}
{v368}
"
                        US5_1(v369)
            let v384 : US10 =
                match v372 with
                | US5_1(v380) -> (* Error *)
                    let v381 : US7 = US7_1
                    US10_0(v381, v305, v306, v307, v308)
                | US5_0(v373, v374, v375, v376, v377) -> (* Ok *)
                    let v378 : US7 = US7_0(v373)
                    US10_0(v378, v374, v375, v376, v377)
            let v445 : US6 =
                match v384 with
                | US10_1(v442) -> (* Error *)
                    US6_1(v442)
                | US10_0(v385, v386, v387, v388, v389) -> (* Ok *)
                    let v390 : bool = "" = v386
                    let v427 : US5 =
                        if v390 then
                            let v391 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v387, v388, v389)}"
                            US5_1(v391)
                        else
                            let v393 : char = v386.[int 0]
                            let v394 : (string -> int32) = String.length
                            let v395 : int32 = v394 v386
                            let v396 : (int32 -> int32) = int32
                            let v397 : int32 = v396 1
                            let v398 : (int32 -> int32) = int32
                            let v399 : int32 = v398 v395
                            let v400 : string = v386.[int v397..int v399]
                            let v401 : (char -> string) = _.ToString()
                            let v402 : string = v401 v393
                            let v405 : int32 = v402.Length
                            let v406 : (char []) = Array.zeroCreate<char> (v405)
                            let v407 : Mut5 = {l0 = 0} : Mut5
                            while method11(v405, v407) do
                                let v409 : int32 = v407.l0
                                let v410 : char = v402.[int v409]
                                v406.[int v409] <- v410
                                let v411 : int32 = v409 + 1
                                v407.l0 <- v411
                                ()
                            let v412 : char list = v406 |> Array.toList
                            let v413 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v414 : (char -> (UH0 -> UH0)) = method12()
                            let v415 : (char list -> (UH0 -> UH0)) = v413 v414
                            let v416 : (UH0 -> UH0) = v415 v412
                            let v417 : UH0 = UH0_0
                            let v418 : UH0 = v416 v417
                            let struct (v423 : System.Text.StringBuilder, v424 : int32, v425 : int32) = method13(v418, v387, v388, v389)
                            US5_0(v393, v400, v423, v424, v425)
                    match v427 with
                    | US5_1(v428) -> (* Error *)
                        US6_1(v428)
                    | US5_0(v430, v431, v432, v433, v434) -> (* Ok *)
                        let v435 : (char -> string) = _.ToString()
                        let v436 : string = v435 v430
                        method21(v436, v431, v432, v433, v434)
            let v457 : US11 =
                match v445 with
                | US6_1(v453) -> (* Error *)
                    let v454 : US1 = US1_1
                    US11_0(v454, v305, v306, v307, v308)
                | US6_0(v446, v447, v448, v449, v450) -> (* Ok *)
                    let v451 : US1 = US1_0(v446)
                    US11_0(v451, v447, v448, v449, v450)
            match v457 with
            | US11_1(v464) -> (* Error *)
                US9_1(v464)
            | US11_0(v458, v459, v460, v461, v462) -> (* Ok *)
                US9_0(v304, v458, v459, v460, v461, v462)
    match v471 with
    | US9_1(v479) -> (* Error *)
        US4_1(v479)
    | US9_0(v472, v473, v474, v475, v476, v477) -> (* Ok *)
        US4_0(v472, v473)
and closure20 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure19 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure0()
    let v9 : unit = (fun () -> v8 (); v7) ()
    let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : Mut4, v28 : int64 option) = TraceState.trace_state.Value
    let v41 : unit = ()
    let v42 : unit = (fun () -> v8 (); v41) ()
    let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
    let v74 : US0 = v60.l0
    let v75 : bool = v58.l0
    let v76 : bool = v75 = false
    let v79 : bool =
        if v76 then
            false
        else
            let v77 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v74
            let v78 : bool = 1 >= v77
            v78
    if v79 then
        let v80 : unit = ()
        let v81 : (unit -> unit) = closure7(v23)
        let v82 : unit = (fun () -> v81 (); v80) ()
        let v85 : unit = ()
        let v86 : unit = (fun () -> v8 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        let v118 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v119 : US3 option = None
        let _v119 = ref v119 
        let v120 : US3 option ref = _v119 
        let v121 : (US3 option -> US3 option ref) = closure8(v120)
        let v122 : unit = ()
        let v123 : (unit -> unit) = closure9(v105, v121)
        let v124 : unit = (fun () -> v123 (); v122) ()
        let v127 : US3 option = _v119.Value 
        let v138 : US3 = US3_1
        let v139 : US3 = v127 |> Option.defaultValue v138 
        let v179 : System.DateTime =
            match v139 with
            | US3_1 -> (* None *)
                let v175 : System.DateTime = System.DateTime.Now
                v175
            | US3_0(v143) -> (* Some *)
                let v144 : System.DateTime = System.DateTime.Now
                let v147 : (System.DateTime -> int64) = _.Ticks
                let v148 : int64 = v147 v144
                let v151 : int64 = v148 - v143
                let v152 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v153 : System.TimeSpan = v152 v151
                let v156 : (System.TimeSpan -> int32) = _.Hours
                let v157 : int32 = v156 v153
                let v160 : (System.TimeSpan -> int32) = _.Minutes
                let v161 : int32 = v160 v153
                let v164 : (System.TimeSpan -> int32) = _.Seconds
                let v165 : int32 = v164 v153
                let v168 : (System.TimeSpan -> int32) = _.Milliseconds
                let v169 : int32 = v168 v153
                let v172 : System.DateTime = System.DateTime (1, 1, 1, v157, v161, v165, v169)
                v172
        let v180 : string = method5()
        let v183 : (string -> string) = v179.ToString
        let v184 : string = v183 v180
        let _v118 = v184 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v187 : US3 option = None
        let _v187 = ref v187 
        let v188 : US3 option ref = _v187 
        let v189 : (US3 option -> US3 option ref) = closure8(v188)
        let v190 : unit = ()
        let v191 : (unit -> unit) = closure9(v105, v189)
        let v192 : unit = (fun () -> v191 (); v190) ()
        let v195 : US3 option = _v187.Value 
        let v206 : US3 = US3_1
        let v207 : US3 = v195 |> Option.defaultValue v206 
        let v247 : System.DateTime =
            match v207 with
            | US3_1 -> (* None *)
                let v243 : System.DateTime = System.DateTime.Now
                v243
            | US3_0(v211) -> (* Some *)
                let v212 : System.DateTime = System.DateTime.Now
                let v215 : (System.DateTime -> int64) = _.Ticks
                let v216 : int64 = v215 v212
                let v219 : int64 = v216 - v211
                let v220 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v221 : System.TimeSpan = v220 v219
                let v224 : (System.TimeSpan -> int32) = _.Hours
                let v225 : int32 = v224 v221
                let v228 : (System.TimeSpan -> int32) = _.Minutes
                let v229 : int32 = v228 v221
                let v232 : (System.TimeSpan -> int32) = _.Seconds
                let v233 : int32 = v232 v221
                let v236 : (System.TimeSpan -> int32) = _.Milliseconds
                let v237 : int32 = v236 v221
                let v240 : System.DateTime = System.DateTime (1, 1, 1, v225, v229, v233, v237)
                v240
        let v248 : string = method5()
        let v251 : (string -> string) = v247.ToString
        let v252 : string = v251 v248
        let _v118 = v252 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v255 : string = $"near_sdk::env::block_timestamp()"
        let v256 : uint64 = Fable.Core.RustInterop.emitRustExpr () v255 
        let v257 : US3 option = None
        let _v257 = ref v257 
        let v258 : US3 option ref = _v257 
        let v259 : (US3 option -> US3 option ref) = closure8(v258)
        let v260 : unit = ()
        let v261 : (unit -> unit) = closure9(v105, v259)
        let v262 : unit = (fun () -> v261 (); v260) ()
        let v265 : US3 option = _v257.Value 
        let v276 : US3 = US3_1
        let v277 : US3 = v265 |> Option.defaultValue v276 
        let v286 : uint64 =
            match v277 with
            | US3_1 -> (* None *)
                v256
            | US3_0(v281) -> (* Some *)
                let v282 : (int64 -> uint64) = uint64
                let v283 : uint64 = v282 v281
                let v284 : uint64 = v256 - v283
                v284
        let v287 : uint64 = v286 / 1000000000UL
        let v288 : uint64 = v287 % 60UL
        let v289 : uint64 = v287 / 60UL
        let v290 : uint64 = v289 % 60UL
        let v291 : uint64 = v287 / 3600UL
        let v292 : uint64 = v291 % 24UL
        let v293 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v292, v290, v288) v293 
        let v295 : string = "fable_library_rust::String_::fromString($0)"
        let v296 : string = Fable.Core.RustInterop.emitRustExpr v294 v295 
        let _v118 = v296 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v297 : US3 option = None
        let _v297 = ref v297 
        let v298 : US3 option ref = _v297 
        let v299 : (US3 option -> US3 option ref) = closure8(v298)
        let v300 : unit = ()
        let v301 : (unit -> unit) = closure9(v105, v299)
        let v302 : unit = (fun () -> v301 (); v300) ()
        let v305 : US3 option = _v297.Value 
        let v316 : US3 = US3_1
        let v317 : US3 = v305 |> Option.defaultValue v316 
        let v357 : System.DateTime =
            match v317 with
            | US3_1 -> (* None *)
                let v353 : System.DateTime = System.DateTime.Now
                v353
            | US3_0(v321) -> (* Some *)
                let v322 : System.DateTime = System.DateTime.Now
                let v325 : (System.DateTime -> int64) = _.Ticks
                let v326 : int64 = v325 v322
                let v329 : int64 = v326 - v321
                let v330 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v331 : System.TimeSpan = v330 v329
                let v334 : (System.TimeSpan -> int32) = _.Hours
                let v335 : int32 = v334 v331
                let v338 : (System.TimeSpan -> int32) = _.Minutes
                let v339 : int32 = v338 v331
                let v342 : (System.TimeSpan -> int32) = _.Seconds
                let v343 : int32 = v342 v331
                let v346 : (System.TimeSpan -> int32) = _.Milliseconds
                let v347 : int32 = v346 v331
                let v350 : System.DateTime = System.DateTime (1, 1, 1, v335, v339, v343, v347)
                v350
        let v358 : string = method6()
        let v361 : (string -> string) = v357.ToString
        let v362 : string = v361 v358
        let _v118 = v362 
        #endif
#if FABLE_COMPILER_PYTHON
        let v365 : US3 option = None
        let _v365 = ref v365 
        let v366 : US3 option ref = _v365 
        let v367 : (US3 option -> US3 option ref) = closure8(v366)
        let v368 : unit = ()
        let v369 : (unit -> unit) = closure9(v105, v367)
        let v370 : unit = (fun () -> v369 (); v368) ()
        let v373 : US3 option = _v365.Value 
        let v384 : US3 = US3_1
        let v385 : US3 = v373 |> Option.defaultValue v384 
        let v425 : System.DateTime =
            match v385 with
            | US3_1 -> (* None *)
                let v421 : System.DateTime = System.DateTime.Now
                v421
            | US3_0(v389) -> (* Some *)
                let v390 : System.DateTime = System.DateTime.Now
                let v393 : (System.DateTime -> int64) = _.Ticks
                let v394 : int64 = v393 v390
                let v397 : int64 = v394 - v389
                let v398 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v399 : System.TimeSpan = v398 v397
                let v402 : (System.TimeSpan -> int32) = _.Hours
                let v403 : int32 = v402 v399
                let v406 : (System.TimeSpan -> int32) = _.Minutes
                let v407 : int32 = v406 v399
                let v410 : (System.TimeSpan -> int32) = _.Seconds
                let v411 : int32 = v410 v399
                let v414 : (System.TimeSpan -> int32) = _.Milliseconds
                let v415 : int32 = v414 v399
                let v418 : System.DateTime = System.DateTime (1, 1, 1, v403, v407, v411, v415)
                v418
        let v426 : string = method6()
        let v429 : (string -> string) = v425.ToString
        let v430 : string = v429 v426
        let _v118 = v430 
        #endif
#else
        let v433 : US3 option = None
        let _v433 = ref v433 
        let v434 : US3 option ref = _v433 
        let v435 : (US3 option -> US3 option ref) = closure8(v434)
        let v436 : unit = ()
        let v437 : (unit -> unit) = closure9(v105, v435)
        let v438 : unit = (fun () -> v437 (); v436) ()
        let v441 : US3 option = _v433.Value 
        let v452 : US3 = US3_1
        let v453 : US3 = v441 |> Option.defaultValue v452 
        let v493 : System.DateTime =
            match v453 with
            | US3_1 -> (* None *)
                let v489 : System.DateTime = System.DateTime.Now
                v489
            | US3_0(v457) -> (* Some *)
                let v458 : System.DateTime = System.DateTime.Now
                let v461 : (System.DateTime -> int64) = _.Ticks
                let v462 : int64 = v461 v458
                let v465 : int64 = v462 - v457
                let v466 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v467 : System.TimeSpan = v466 v465
                let v470 : (System.TimeSpan -> int32) = _.Hours
                let v471 : int32 = v470 v467
                let v474 : (System.TimeSpan -> int32) = _.Minutes
                let v475 : int32 = v474 v467
                let v478 : (System.TimeSpan -> int32) = _.Seconds
                let v479 : int32 = v478 v467
                let v482 : (System.TimeSpan -> int32) = _.Milliseconds
                let v483 : int32 = v482 v467
                let v486 : System.DateTime = System.DateTime (1, 1, 1, v471, v475, v479, v483)
                v486
        let v494 : string = method6()
        let v497 : (string -> string) = v493.ToString
        let v498 : string = v497 v494
        let _v118 = v498 
        #endif
        let v501 : string = _v118 
        
        
        
        
        
        let v571 : string = "Debug"
        let v572 : (unit -> string) = v571.ToLower
        let v573 : string = v572 ()
        let v576 : string = v573.PadLeft (7, ' ')
        let v590 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v591 : string = "inline_colorization::color_bright_blue"
        let v592 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v591 
        let v593 : string = "&*$0"
        let v594 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v576 v593 
        let v595 : string = "inline_colorization::color_reset"
        let v596 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v595 
        let v597 : string = "\"{v592}{v594}{v596}\""
        let v598 : string = @$"format!(" + v597 + ")"
        let v599 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "fable_library_rust::String_::fromString($0)"
        let v601 : string = Fable.Core.RustInterop.emitRustExpr v599 v600 
        let _v590 = v601 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v602 : string = "inline_colorization::color_bright_blue"
        let v603 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v602 
        let v604 : string = "&*$0"
        let v605 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v576 v604 
        let v606 : string = "inline_colorization::color_reset"
        let v607 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v606 
        let v608 : string = "\"{v603}{v605}{v607}\""
        let v609 : string = @$"format!(" + v608 + ")"
        let v610 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v609 
        let v611 : string = "fable_library_rust::String_::fromString($0)"
        let v612 : string = Fable.Core.RustInterop.emitRustExpr v610 v611 
        let _v590 = v612 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v613 : string = "inline_colorization::color_bright_blue"
        let v614 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v613 
        let v615 : string = "&*$0"
        let v616 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v576 v615 
        let v617 : string = "inline_colorization::color_reset"
        let v618 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v617 
        let v619 : string = "\"{v614}{v616}{v618}\""
        let v620 : string = @$"format!(" + v619 + ")"
        let v621 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v620 
        let v622 : string = "fable_library_rust::String_::fromString($0)"
        let v623 : string = Fable.Core.RustInterop.emitRustExpr v621 v622 
        let _v590 = v623 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v624 : string = "\u001b[94m"
        let v625 : string = method7()
        let v626 : string = v624 + v576 
        let v627 : string = v626 + v625 
        let _v590 = v627 
        #endif
#if FABLE_COMPILER_PYTHON
        let v628 : string = "\u001b[94m"
        let v629 : string = method7()
        let v630 : string = v628 + v576 
        let v631 : string = v630 + v629 
        let _v590 = v631 
        #endif
#else
        let v632 : string = "\u001b[94m"
        let v633 : string = method7()
        let v634 : string = v632 + v576 
        let v635 : string = v634 + v633 
        let _v590 = v635 
        #endif
        let v636 : string = _v590 
        let v642 : int64 = v100.l0
        let v643 : string = method8()
        let v644 : Mut3 = {l0 = v643} : Mut3
        let v645 : string = "{ "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure20(v644, v646)
        let v651 : unit = (fun () -> v650 (); v649) ()
        let v654 : string = "options"
        let v655 : string = $"{v654}"
        let v658 : unit = ()
        let v659 : (unit -> unit) = closure20(v644, v655)
        let v660 : unit = (fun () -> v659 (); v658) ()
        let v663 : string = " = "
        let v664 : string = $"{v663}"
        let v667 : unit = ()
        let v668 : (unit -> unit) = closure20(v644, v664)
        let v669 : unit = (fun () -> v668 (); v667) ()
        let v672 : string = $"{v645}"
        let v675 : unit = ()
        let v676 : (unit -> unit) = closure20(v644, v672)
        let v677 : unit = (fun () -> v676 (); v675) ()
        let v680 : string = "command"
        let v681 : string = $"{v680}"
        let v684 : unit = ()
        let v685 : (unit -> unit) = closure20(v644, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = $"{v663}"
        let v692 : unit = ()
        let v693 : (unit -> unit) = closure20(v644, v689)
        let v694 : unit = (fun () -> v693 (); v692) ()
        let v697 : string = $"{v0}"
        let v700 : unit = ()
        let v701 : (unit -> unit) = closure20(v644, v697)
        let v702 : unit = (fun () -> v701 (); v700) ()
        let v705 : string = "; "
        let v706 : string = $"{v705}"
        let v709 : unit = ()
        let v710 : (unit -> unit) = closure20(v644, v706)
        let v711 : unit = (fun () -> v710 (); v709) ()
        let v714 : string = "cancellation_token"
        let v715 : string = $"{v714}"
        let v718 : unit = ()
        let v719 : (unit -> unit) = closure20(v644, v715)
        let v720 : unit = (fun () -> v719 (); v718) ()
        let v723 : string = $"{v663}"
        let v726 : unit = ()
        let v727 : (unit -> unit) = closure20(v644, v723)
        let v728 : unit = (fun () -> v727 (); v726) ()
        let v731 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v732 : string = "format!(\"{:#?}\", $0)"
        let v733 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v732 
        let v734 : string = "fable_library_rust::String_::fromString($0)"
        let v735 : string = Fable.Core.RustInterop.emitRustExpr v733 v734 
        let _v731 = v735 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v736 : string = "format!(\"{:#?}\", $0)"
        let v737 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v736 
        let v738 : string = "fable_library_rust::String_::fromString($0)"
        let v739 : string = Fable.Core.RustInterop.emitRustExpr v737 v738 
        let _v731 = v739 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v740 : string = "format!(\"{:#?}\", $0)"
        let v741 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v740 
        let v742 : string = "fable_library_rust::String_::fromString($0)"
        let v743 : string = Fable.Core.RustInterop.emitRustExpr v741 v742 
        let _v731 = v743 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v744 : string = $"%A{v1}"
        let _v731 = v744 
        #endif
#if FABLE_COMPILER_PYTHON
        let v747 : string = $"%A{v1}"
        let _v731 = v747 
        #endif
#else
        let v750 : string = $"%A{v1}"
        let _v731 = v750 
        #endif
        let v753 : string = _v731 
        let v758 : string = $"{v753}"
        let v761 : unit = ()
        let v762 : (unit -> unit) = closure20(v644, v758)
        let v763 : unit = (fun () -> v762 (); v761) ()
        let v766 : string = $"{v705}"
        let v769 : unit = ()
        let v770 : (unit -> unit) = closure20(v644, v766)
        let v771 : unit = (fun () -> v770 (); v769) ()
        let v774 : string = "environment_variables"
        let v775 : string = $"{v774}"
        let v778 : unit = ()
        let v779 : (unit -> unit) = closure20(v644, v775)
        let v780 : unit = (fun () -> v779 (); v778) ()
        let v783 : string = $"{v663}"
        let v786 : unit = ()
        let v787 : (unit -> unit) = closure20(v644, v783)
        let v788 : unit = (fun () -> v787 (); v786) ()
        let v791 : string = $"%A{v2}"
        let v794 : string = $"{v791}"
        let v797 : unit = ()
        let v798 : (unit -> unit) = closure20(v644, v794)
        let v799 : unit = (fun () -> v798 (); v797) ()
        let v802 : string = $"{v705}"
        let v805 : unit = ()
        let v806 : (unit -> unit) = closure20(v644, v802)
        let v807 : unit = (fun () -> v806 (); v805) ()
        let v810 : string = "on_line"
        let v811 : string = $"{v810}"
        let v814 : unit = ()
        let v815 : (unit -> unit) = closure20(v644, v811)
        let v816 : unit = (fun () -> v815 (); v814) ()
        let v819 : string = $"{v663}"
        let v822 : unit = ()
        let v823 : (unit -> unit) = closure20(v644, v819)
        let v824 : unit = (fun () -> v823 (); v822) ()
        let v827 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v828 : string = "format!(\"{:#?}\", $0)"
        let v829 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v828 
        let v830 : string = "fable_library_rust::String_::fromString($0)"
        let v831 : string = Fable.Core.RustInterop.emitRustExpr v829 v830 
        let _v827 = v831 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v832 : string = "format!(\"{:#?}\", $0)"
        let v833 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v832 
        let v834 : string = "fable_library_rust::String_::fromString($0)"
        let v835 : string = Fable.Core.RustInterop.emitRustExpr v833 v834 
        let _v827 = v835 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v836 : string = "format!(\"{:#?}\", $0)"
        let v837 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v836 
        let v838 : string = "fable_library_rust::String_::fromString($0)"
        let v839 : string = Fable.Core.RustInterop.emitRustExpr v837 v838 
        let _v827 = v839 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v840 : string = $"%A{v3}"
        let _v827 = v840 
        #endif
#if FABLE_COMPILER_PYTHON
        let v843 : string = $"%A{v3}"
        let _v827 = v843 
        #endif
#else
        let v846 : string = $"%A{v3}"
        let _v827 = v846 
        #endif
        let v849 : string = _v827 
        let v854 : string = $"{v849}"
        let v857 : unit = ()
        let v858 : (unit -> unit) = closure20(v644, v854)
        let v859 : unit = (fun () -> v858 (); v857) ()
        let v862 : string = $"{v705}"
        let v865 : unit = ()
        let v866 : (unit -> unit) = closure20(v644, v862)
        let v867 : unit = (fun () -> v866 (); v865) ()
        let v870 : string = "stdin"
        let v871 : string = $"{v870}"
        let v874 : unit = ()
        let v875 : (unit -> unit) = closure20(v644, v871)
        let v876 : unit = (fun () -> v875 (); v874) ()
        let v879 : string = $"{v663}"
        let v882 : unit = ()
        let v883 : (unit -> unit) = closure20(v644, v879)
        let v884 : unit = (fun () -> v883 (); v882) ()
        let v887 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v888 : string = "format!(\"{:#?}\", $0)"
        let v889 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v888 
        let v890 : string = "fable_library_rust::String_::fromString($0)"
        let v891 : string = Fable.Core.RustInterop.emitRustExpr v889 v890 
        let _v887 = v891 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v892 : string = "format!(\"{:#?}\", $0)"
        let v893 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v892 
        let v894 : string = "fable_library_rust::String_::fromString($0)"
        let v895 : string = Fable.Core.RustInterop.emitRustExpr v893 v894 
        let _v887 = v895 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v896 : string = "format!(\"{:#?}\", $0)"
        let v897 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v896 
        let v898 : string = "fable_library_rust::String_::fromString($0)"
        let v899 : string = Fable.Core.RustInterop.emitRustExpr v897 v898 
        let _v887 = v899 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v900 : string = $"%A{v4}"
        let _v887 = v900 
        #endif
#if FABLE_COMPILER_PYTHON
        let v903 : string = $"%A{v4}"
        let _v887 = v903 
        #endif
#else
        let v906 : string = $"%A{v4}"
        let _v887 = v906 
        #endif
        let v909 : string = _v887 
        let v914 : string = $"{v909}"
        let v917 : unit = ()
        let v918 : (unit -> unit) = closure20(v644, v914)
        let v919 : unit = (fun () -> v918 (); v917) ()
        let v922 : string = $"{v705}"
        let v925 : unit = ()
        let v926 : (unit -> unit) = closure20(v644, v922)
        let v927 : unit = (fun () -> v926 (); v925) ()
        let v930 : string = "trace"
        let v931 : string = $"{v930}"
        let v934 : unit = ()
        let v935 : (unit -> unit) = closure20(v644, v931)
        let v936 : unit = (fun () -> v935 (); v934) ()
        let v939 : string = $"{v663}"
        let v942 : unit = ()
        let v943 : (unit -> unit) = closure20(v644, v939)
        let v944 : unit = (fun () -> v943 (); v942) ()
        let v949 : string =
            if v5 then
                let v947 : string = "true"
                v947
            else
                let v948 : string = "false"
                v948
        let v950 : string = $"{v949}"
        let v953 : unit = ()
        let v954 : (unit -> unit) = closure20(v644, v950)
        let v955 : unit = (fun () -> v954 (); v953) ()
        let v958 : string = $"{v705}"
        let v961 : unit = ()
        let v962 : (unit -> unit) = closure20(v644, v958)
        let v963 : unit = (fun () -> v962 (); v961) ()
        let v966 : string = "working_directory"
        let v967 : string = $"{v966}"
        let v970 : unit = ()
        let v971 : (unit -> unit) = closure20(v644, v967)
        let v972 : unit = (fun () -> v971 (); v970) ()
        let v975 : string = $"{v663}"
        let v978 : unit = ()
        let v979 : (unit -> unit) = closure20(v644, v975)
        let v980 : unit = (fun () -> v979 (); v978) ()
        let v983 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v984 : string = "format!(\"{:#?}\", $0)"
        let v985 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v984 
        let v986 : string = "fable_library_rust::String_::fromString($0)"
        let v987 : string = Fable.Core.RustInterop.emitRustExpr v985 v986 
        let _v983 = v987 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v988 : string = "format!(\"{:#?}\", $0)"
        let v989 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v988 
        let v990 : string = "fable_library_rust::String_::fromString($0)"
        let v991 : string = Fable.Core.RustInterop.emitRustExpr v989 v990 
        let _v983 = v991 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v992 : string = "format!(\"{:#?}\", $0)"
        let v993 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v992 
        let v994 : string = "fable_library_rust::String_::fromString($0)"
        let v995 : string = Fable.Core.RustInterop.emitRustExpr v993 v994 
        let _v983 = v995 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v996 : string = $"%A{v6}"
        let _v983 = v996 
        #endif
#if FABLE_COMPILER_PYTHON
        let v999 : string = $"%A{v6}"
        let _v983 = v999 
        #endif
#else
        let v1002 : string = $"%A{v6}"
        let _v983 = v1002 
        #endif
        let v1005 : string = _v983 
        let v1010 : string = $"{v1005}"
        let v1013 : unit = ()
        let v1014 : (unit -> unit) = closure20(v644, v1010)
        let v1015 : unit = (fun () -> v1014 (); v1013) ()
        let v1018 : string = " }"
        let v1019 : string = $"{v1018}"
        let v1022 : unit = ()
        let v1023 : (unit -> unit) = closure20(v644, v1019)
        let v1024 : unit = (fun () -> v1023 (); v1022) ()
        let v1027 : string = $"{v1018}"
        let v1030 : unit = ()
        let v1031 : (unit -> unit) = closure20(v644, v1027)
        let v1032 : unit = (fun () -> v1031 (); v1030) ()
        let v1035 : string = v644.l0
        let v1036 : string = $"runtime.execute_with_options_async"
        let v1037 : bool = v1036 = ""
        let v1094 : string =
            if v1037 then
                let v1038 : string = ""
                v1038
            else
                let v1039 : string = $"{v501} {v636} #{v642} %s{v1036} / {v1035}"
                let v1042 : char list = []
                let v1043 : (char list -> (char [])) = List.toArray
                let v1044 : (char []) = v1043 v1042
                let v1047 : string = v1039.TrimStart v1044 
                let v1065 : char list = []
                let v1066 : char list = '/' :: v1065 
                let v1069 : char list = ' ' :: v1066 
                let v1072 : (char list -> (char [])) = List.toArray
                let v1073 : (char []) = v1072 v1069
                let v1076 : string = v1047.TrimEnd v1073 
                v1076
        let v1095 : (string -> unit) = closure10()
        let v1096 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1097 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1094 v1097 
        let _v1096 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1098 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1094 v1098 
        let _v1096 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1099 : string = v26.l0
        let v1100 : bool = v1099 = ""
        let v1108 : string =
            if v1100 then
                v1094
            else
                let v1101 : bool = v1094 = ""
                if v1101 then
                    let v1102 : string = v26.l0
                    v1102
                else
                    let v1103 : string = v26.l0
                    let v1104 : string = "\n"
                    let v1105 : string = v1103 + v1104 
                    let v1106 : string = v1105 + v1094 
                    v1106
        let v1109 : string = "&*$0"
        let v1110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1108 v1109 
        let v1111 : string = $"$0.chars()"
        let v1112 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v1110 v1111 
        let v1113 : string = "v1112"
        let v1114 : _ = Fable.Core.RustInterop.emitRustExpr () v1113 
        let v1115 : string = "v1114.collect::<Vec<_>>()"
        let v1116 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v1115 
        let v1117 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v1118 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v1116 v1117 
        let v1119 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v1120 : bool = Fable.Core.RustInterop.emitRustExpr v1118 v1119 
        let v1121 : string = "x"
        let v1122 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v1121 
        let v1123 : string = "String::from_iter($0)"
        let v1124 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1122 v1123 
        let v1125 : string = "true; $0 }).collect::<Vec<_>>()"
        let v1126 : bool = Fable.Core.RustInterop.emitRustExpr v1124 v1125 
        let v1127 : string = "_vec_map"
        let v1128 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1127 
        let v1129 : string = "$0.len()"
        let v1130 : unativeint = Fable.Core.RustInterop.emitRustExpr v1128 v1129 
        let v1131 : (unativeint -> int32) = int32
        let v1132 : int32 = v1131 v1130
        let v1133 : string = ""
        let v1134 : bool = v1094 <> v1133 
        let v1138 : bool =
            if v1134 then
                let v1137 : bool = v1132 <= 1
                v1137
            else
                false
        if v1138 then
            v26.l0 <- v1108
            ()
        else
            v26.l0 <- v1133
            let v1139 : string = "true; $0.into_iter().for_each(|x| { //"
            let v1140 : bool = Fable.Core.RustInterop.emitRustExpr v1128 v1139 
            let v1141 : string = "x"
            let v1142 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1141 
            let v1143 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v1142 v1143 
            let v1144 : string = $"true;"
            let v1145 : bool = Fable.Core.RustInterop.emitRustExpr () v1144 
            let v1146 : string = "true; }}); { //"
            let v1147 : bool = Fable.Core.RustInterop.emitRustExpr () v1146 
            ()
        let _v1096 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v1095 v1094
        let _v1096 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v1095 v1094
        let _v1096 = () 
        #endif
#else
        v1095 v1094
        let _v1096 = () 
        #endif
        _v1096 
        let v1148 : (string -> unit) = v24.l0
        v1148 v1094
and closure22 (v0 : US12 option ref) (v1 : US12 option) : US12 option ref =
    v0.Value <- v1 
    v0
and closure23 (v0 : (struct (int32 * string * bool) -> Async<unit>) option, v1 : (US12 option -> US12 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : (struct (int32 * string * bool) -> Async<unit>) = x
    let v3 : US12 = US12_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and closure24 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v2 (); v35) ()
    let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
    let v68 : US0 = v54.l0
    let v69 : bool = v52.l0
    let v70 : bool = v69 = false
    let v73 : bool =
        if v70 then
            false
        else
            let v71 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v68
            let v72 : bool = 0 >= v71
            v72
    if v73 then
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure7(v17)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        let v112 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : US3 option = None
        let _v113 = ref v113 
        let v114 : US3 option ref = _v113 
        let v115 : (US3 option -> US3 option ref) = closure8(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure9(v99, v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v121 : US3 option = _v113.Value 
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
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure8(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure9(v99, v183)
        let v186 : unit = (fun () -> v185 (); v184) ()
        let v189 : US3 option = _v181.Value 
        let v200 : US3 = US3_1
        let v201 : US3 = v189 |> Option.defaultValue v200 
        let v241 : System.DateTime =
            match v201 with
            | US3_1 -> (* None *)
                let v237 : System.DateTime = System.DateTime.Now
                v237
            | US3_0(v205) -> (* Some *)
                let v206 : System.DateTime = System.DateTime.Now
                let v209 : (System.DateTime -> int64) = _.Ticks
                let v210 : int64 = v209 v206
                let v213 : int64 = v210 - v205
                let v214 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v215 : System.TimeSpan = v214 v213
                let v218 : (System.TimeSpan -> int32) = _.Hours
                let v219 : int32 = v218 v215
                let v222 : (System.TimeSpan -> int32) = _.Minutes
                let v223 : int32 = v222 v215
                let v226 : (System.TimeSpan -> int32) = _.Seconds
                let v227 : int32 = v226 v215
                let v230 : (System.TimeSpan -> int32) = _.Milliseconds
                let v231 : int32 = v230 v215
                let v234 : System.DateTime = System.DateTime (1, 1, 1, v219, v223, v227, v231)
                v234
        let v242 : string = method5()
        let v245 : (string -> string) = v241.ToString
        let v246 : string = v245 v242
        let _v112 = v246 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v249 : string = $"near_sdk::env::block_timestamp()"
        let v250 : uint64 = Fable.Core.RustInterop.emitRustExpr () v249 
        let v251 : US3 option = None
        let _v251 = ref v251 
        let v252 : US3 option ref = _v251 
        let v253 : (US3 option -> US3 option ref) = closure8(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure9(v99, v253)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v259 : US3 option = _v251.Value 
        let v270 : US3 = US3_1
        let v271 : US3 = v259 |> Option.defaultValue v270 
        let v280 : uint64 =
            match v271 with
            | US3_1 -> (* None *)
                v250
            | US3_0(v275) -> (* Some *)
                let v276 : (int64 -> uint64) = uint64
                let v277 : uint64 = v276 v275
                let v278 : uint64 = v250 - v277
                v278
        let v281 : uint64 = v280 / 1000000000UL
        let v282 : uint64 = v281 % 60UL
        let v283 : uint64 = v281 / 60UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v281 / 3600UL
        let v286 : uint64 = v285 % 24UL
        let v287 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v286, v284, v282) v287 
        let v289 : string = "fable_library_rust::String_::fromString($0)"
        let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
        let _v112 = v290 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v291 : US3 option = None
        let _v291 = ref v291 
        let v292 : US3 option ref = _v291 
        let v293 : (US3 option -> US3 option ref) = closure8(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure9(v99, v293)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v299 : US3 option = _v291.Value 
        let v310 : US3 = US3_1
        let v311 : US3 = v299 |> Option.defaultValue v310 
        let v351 : System.DateTime =
            match v311 with
            | US3_1 -> (* None *)
                let v347 : System.DateTime = System.DateTime.Now
                v347
            | US3_0(v315) -> (* Some *)
                let v316 : System.DateTime = System.DateTime.Now
                let v319 : (System.DateTime -> int64) = _.Ticks
                let v320 : int64 = v319 v316
                let v323 : int64 = v320 - v315
                let v324 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v325 : System.TimeSpan = v324 v323
                let v328 : (System.TimeSpan -> int32) = _.Hours
                let v329 : int32 = v328 v325
                let v332 : (System.TimeSpan -> int32) = _.Minutes
                let v333 : int32 = v332 v325
                let v336 : (System.TimeSpan -> int32) = _.Seconds
                let v337 : int32 = v336 v325
                let v340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v341 : int32 = v340 v325
                let v344 : System.DateTime = System.DateTime (1, 1, 1, v329, v333, v337, v341)
                v344
        let v352 : string = method6()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure8(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure9(v99, v361)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v367 : US3 option = _v359.Value 
        let v378 : US3 = US3_1
        let v379 : US3 = v367 |> Option.defaultValue v378 
        let v419 : System.DateTime =
            match v379 with
            | US3_1 -> (* None *)
                let v415 : System.DateTime = System.DateTime.Now
                v415
            | US3_0(v383) -> (* Some *)
                let v384 : System.DateTime = System.DateTime.Now
                let v387 : (System.DateTime -> int64) = _.Ticks
                let v388 : int64 = v387 v384
                let v391 : int64 = v388 - v383
                let v392 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v393 : System.TimeSpan = v392 v391
                let v396 : (System.TimeSpan -> int32) = _.Hours
                let v397 : int32 = v396 v393
                let v400 : (System.TimeSpan -> int32) = _.Minutes
                let v401 : int32 = v400 v393
                let v404 : (System.TimeSpan -> int32) = _.Seconds
                let v405 : int32 = v404 v393
                let v408 : (System.TimeSpan -> int32) = _.Milliseconds
                let v409 : int32 = v408 v393
                let v412 : System.DateTime = System.DateTime (1, 1, 1, v397, v401, v405, v409)
                v412
        let v420 : string = method6()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure8(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure9(v99, v429)
        let v432 : unit = (fun () -> v431 (); v430) ()
        let v435 : US3 option = _v427.Value 
        let v446 : US3 = US3_1
        let v447 : US3 = v435 |> Option.defaultValue v446 
        let v487 : System.DateTime =
            match v447 with
            | US3_1 -> (* None *)
                let v483 : System.DateTime = System.DateTime.Now
                v483
            | US3_0(v451) -> (* Some *)
                let v452 : System.DateTime = System.DateTime.Now
                let v455 : (System.DateTime -> int64) = _.Ticks
                let v456 : int64 = v455 v452
                let v459 : int64 = v456 - v451
                let v460 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v461 : System.TimeSpan = v460 v459
                let v464 : (System.TimeSpan -> int32) = _.Hours
                let v465 : int32 = v464 v461
                let v468 : (System.TimeSpan -> int32) = _.Minutes
                let v469 : int32 = v468 v461
                let v472 : (System.TimeSpan -> int32) = _.Seconds
                let v473 : int32 = v472 v461
                let v476 : (System.TimeSpan -> int32) = _.Milliseconds
                let v477 : int32 = v476 v461
                let v480 : System.DateTime = System.DateTime (1, 1, 1, v465, v469, v473, v477)
                v480
        let v488 : string = method6()
        let v491 : (string -> string) = v487.ToString
        let v492 : string = v491 v488
        let _v112 = v492 
        #endif
        let v495 : string = _v112 
        
        
        
        
        
        let v565 : string = "Verbose"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_bright_black"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v584 = v595 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v596 : string = "inline_colorization::color_bright_black"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v584 = v606 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v607 : string = "inline_colorization::color_bright_black"
        let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v607 
        let v609 : string = "&*$0"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v609 
        let v611 : string = "inline_colorization::color_reset"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v611 
        let v613 : string = "\"{v608}{v610}{v612}\""
        let v614 : string = @$"format!(" + v613 + ")"
        let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "fable_library_rust::String_::fromString($0)"
        let v617 : string = Fable.Core.RustInterop.emitRustExpr v615 v616 
        let _v584 = v617 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v618 : string = "\u001b[90m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[90m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[90m"
        let v627 : string = method7()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = method8()
        let v638 : Mut3 = {l0 = v637} : Mut3
        let v639 : string = v638.l0
        let v640 : bool = v0 = ""
        let v697 : string =
            if v640 then
                let v641 : string = ""
                v641
            else
                let v642 : string = $"{v495} {v630} #{v636} %s{v0} / {v639}"
                let v645 : char list = []
                let v646 : (char list -> (char [])) = List.toArray
                let v647 : (char []) = v646 v645
                let v650 : string = v642.TrimStart v647 
                let v668 : char list = []
                let v669 : char list = '/' :: v668 
                let v672 : char list = ' ' :: v669 
                let v675 : (char list -> (char [])) = List.toArray
                let v676 : (char []) = v675 v672
                let v679 : string = v650.TrimEnd v676 
                v679
        let v698 : (string -> unit) = closure10()
        let v699 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v700 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v697 v700 
        let _v699 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v701 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v697 v701 
        let _v699 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v702 : string = v20.l0
        let v703 : bool = v702 = ""
        let v711 : string =
            if v703 then
                v697
            else
                let v704 : bool = v697 = ""
                if v704 then
                    let v705 : string = v20.l0
                    v705
                else
                    let v706 : string = v20.l0
                    let v707 : string = "\n"
                    let v708 : string = v706 + v707 
                    let v709 : string = v708 + v697 
                    v709
        let v712 : string = "&*$0"
        let v713 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v711 v712 
        let v714 : string = $"$0.chars()"
        let v715 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v713 v714 
        let v716 : string = "v715"
        let v717 : _ = Fable.Core.RustInterop.emitRustExpr () v716 
        let v718 : string = "v717.collect::<Vec<_>>()"
        let v719 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v718 
        let v720 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v721 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v719 v720 
        let v722 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v723 : bool = Fable.Core.RustInterop.emitRustExpr v721 v722 
        let v724 : string = "x"
        let v725 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v724 
        let v726 : string = "String::from_iter($0)"
        let v727 : std_string_String = Fable.Core.RustInterop.emitRustExpr v725 v726 
        let v728 : string = "true; $0 }).collect::<Vec<_>>()"
        let v729 : bool = Fable.Core.RustInterop.emitRustExpr v727 v728 
        let v730 : string = "_vec_map"
        let v731 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v730 
        let v732 : string = "$0.len()"
        let v733 : unativeint = Fable.Core.RustInterop.emitRustExpr v731 v732 
        let v734 : (unativeint -> int32) = int32
        let v735 : int32 = v734 v733
        let v736 : string = ""
        let v737 : bool = v697 <> v736 
        let v741 : bool =
            if v737 then
                let v740 : bool = v735 <= 1
                v740
            else
                false
        if v741 then
            v20.l0 <- v711
            ()
        else
            v20.l0 <- v736
            let v742 : string = "true; $0.into_iter().for_each(|x| { //"
            let v743 : bool = Fable.Core.RustInterop.emitRustExpr v731 v742 
            let v744 : string = "x"
            let v745 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v744 
            let v746 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v745 v746 
            let v747 : string = $"true;"
            let v748 : bool = Fable.Core.RustInterop.emitRustExpr () v747 
            let v749 : string = "true; }}); { //"
            let v750 : bool = Fable.Core.RustInterop.emitRustExpr () v749 
            ()
        let _v699 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v698 v697
        let _v699 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v698 v697
        let _v699 = () 
        #endif
#else
        v698 v697
        let _v699 = () 
        #endif
        _v699 
        let v751 : (string -> unit) = v18.l0
        v751 v697
and closure21 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
#else
    let v26 : Async<unit> option = None
    let mutable _v26 = v26 
    async {
    let v27 : string = v9.Data
    let v28 : string = null |> unbox<string>
    let v31 : bool = v27 = v28
    let v32 : bool = v31 <> true
    if v32 then
        let v33 : US12 option = None
        let _v33 = ref v33 
        let v34 : US12 option ref = _v33 
        let v35 : (US12 option -> US12 option ref) = closure22(v34)
        let v36 : unit = ()
        let v37 : (unit -> unit) = closure23(v3, v35)
        let v38 : unit = (fun () -> v37 (); v36) ()
        let v41 : US12 option = _v33.Value 
        let v52 : US12 = US12_1
        let v53 : US12 = v41 |> Option.defaultValue v52 
        match v53 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v57) -> (* Some *)
            let v58 : int32 = v7.Id
            let v59 : Async<unit> = v57 struct (v58, v27, false)
            do! v59 
            ()
        let v60 : string = $"> {v27}"
        if v5 then
            let v61 : unit = ()
            let v62 : (unit -> unit) = closure24(v60)
            let v63 : unit = (fun () -> v62 (); v61) ()
            ()
        else
            let v815 : unit = ()
            let v816 : (unit -> unit) = closure11(v60)
            let v817 : unit = (fun () -> v816 (); v815) ()
            ()
        let v819 : string = ""
        let v820 : string = $"{v819}{v27}{v819}"
        let v821 : (string -> unit) = v8.Push
        v821 v820
    ()
    }
    |> fun x -> _v26 <- Some x
    let v822 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v822 
    #endif
    let v823 : Async<unit> = _v10 
    let v828 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v828 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v828 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v828 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v828 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v828 = () 
    #endif
#else
    let v829 : (Async<unit> -> unit) = Async.StartImmediate
    v829 v823
    let _v828 = () 
    #endif
    _v828 
    ()
and closure25 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
#else
    let v26 : Async<unit> option = None
    let mutable _v26 = v26 
    async {
    let v27 : string = v9.Data
    let v28 : string = null |> unbox<string>
    let v31 : bool = v27 = v28
    let v32 : bool = v31 <> true
    if v32 then
        let v33 : US12 option = None
        let _v33 = ref v33 
        let v34 : US12 option ref = _v33 
        let v35 : (US12 option -> US12 option ref) = closure22(v34)
        let v36 : unit = ()
        let v37 : (unit -> unit) = closure23(v3, v35)
        let v38 : unit = (fun () -> v37 (); v36) ()
        let v41 : US12 option = _v33.Value 
        let v52 : US12 = US12_1
        let v53 : US12 = v41 |> Option.defaultValue v52 
        match v53 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v57) -> (* Some *)
            let v58 : int32 = v7.Id
            let v59 : Async<unit> = v57 struct (v58, v27, true)
            do! v59 
            ()
        let v60 : string = $"! {v27}"
        if v5 then
            let v61 : unit = ()
            let v62 : (unit -> unit) = closure24(v60)
            let v63 : unit = (fun () -> v62 (); v61) ()
            ()
        else
            let v815 : unit = ()
            let v816 : (unit -> unit) = closure11(v60)
            let v817 : unit = (fun () -> v816 (); v815) ()
            ()
        let v819 : string = "\u001b[7;4m"
        let v820 : string = "\u001b[0m"
        let v821 : string = $"{v819}{v27}{v820}"
        let v822 : (string -> unit) = v8.Push
        v822 v821
    ()
    }
    |> fun x -> _v26 <- Some x
    let v823 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v823 
    #endif
    let v824 : Async<unit> = _v10 
    let v829 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v829 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v829 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v829 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v829 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v829 = () 
    #endif
#else
    let v830 : (Async<unit> -> unit) = Async.StartImmediate
    v830 v824
    let _v829 = () 
    #endif
    _v829 
    ()
and closure26 (v0 : US13 option ref) (v1 : US13 option) : US13 option ref =
    v0.Value <- v1 
    v0
and closure27 (v0 : System.Threading.CancellationToken option, v1 : (US13 option -> US13 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : System.Threading.CancellationToken = x
    let v3 : US13 = US13_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and closure28 (v0 : System.Diagnostics.Process) () : unit =
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
#else
    let v17 : bool = v0.HasExited
    let _v1 = v17 
    #endif
    let v18 : bool = _v1 
    let v23 : bool = v18 = false
    if v23 then
        let v24 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let _v24 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let _v24 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let _v24 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let _v24 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        let _v24 = () 
        #endif
#else
        let v25 : (unit -> unit) = v0.Kill
        v25 ()
        let _v24 = () 
        #endif
        _v24 
        ()
and closure29 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : unit = ()
    let v36 : unit = (fun () -> v2 (); v35) ()
    let struct (v50 : Mut0, v51 : Mut1, v52 : Mut2, v53 : Mut3, v54 : Mut4, v55 : int64 option) = TraceState.trace_state.Value
    let v68 : US0 = v54.l0
    let v69 : bool = v52.l0
    let v70 : bool = v69 = false
    let v73 : bool =
        if v70 then
            false
        else
            let v71 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v68
            let v72 : bool = 3 >= v71
            v72
    if v73 then
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure7(v17)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v79 : unit = ()
        let v80 : unit = (fun () -> v2 (); v79) ()
        let struct (v94 : Mut0, v95 : Mut1, v96 : Mut2, v97 : Mut3, v98 : Mut4, v99 : int64 option) = TraceState.trace_state.Value
        let v112 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v113 : US3 option = None
        let _v113 = ref v113 
        let v114 : US3 option ref = _v113 
        let v115 : (US3 option -> US3 option ref) = closure8(v114)
        let v116 : unit = ()
        let v117 : (unit -> unit) = closure9(v99, v115)
        let v118 : unit = (fun () -> v117 (); v116) ()
        let v121 : US3 option = _v113.Value 
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
        let _v112 = v178 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v181 : US3 option = None
        let _v181 = ref v181 
        let v182 : US3 option ref = _v181 
        let v183 : (US3 option -> US3 option ref) = closure8(v182)
        let v184 : unit = ()
        let v185 : (unit -> unit) = closure9(v99, v183)
        let v186 : unit = (fun () -> v185 (); v184) ()
        let v189 : US3 option = _v181.Value 
        let v200 : US3 = US3_1
        let v201 : US3 = v189 |> Option.defaultValue v200 
        let v241 : System.DateTime =
            match v201 with
            | US3_1 -> (* None *)
                let v237 : System.DateTime = System.DateTime.Now
                v237
            | US3_0(v205) -> (* Some *)
                let v206 : System.DateTime = System.DateTime.Now
                let v209 : (System.DateTime -> int64) = _.Ticks
                let v210 : int64 = v209 v206
                let v213 : int64 = v210 - v205
                let v214 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v215 : System.TimeSpan = v214 v213
                let v218 : (System.TimeSpan -> int32) = _.Hours
                let v219 : int32 = v218 v215
                let v222 : (System.TimeSpan -> int32) = _.Minutes
                let v223 : int32 = v222 v215
                let v226 : (System.TimeSpan -> int32) = _.Seconds
                let v227 : int32 = v226 v215
                let v230 : (System.TimeSpan -> int32) = _.Milliseconds
                let v231 : int32 = v230 v215
                let v234 : System.DateTime = System.DateTime (1, 1, 1, v219, v223, v227, v231)
                v234
        let v242 : string = method5()
        let v245 : (string -> string) = v241.ToString
        let v246 : string = v245 v242
        let _v112 = v246 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v249 : string = $"near_sdk::env::block_timestamp()"
        let v250 : uint64 = Fable.Core.RustInterop.emitRustExpr () v249 
        let v251 : US3 option = None
        let _v251 = ref v251 
        let v252 : US3 option ref = _v251 
        let v253 : (US3 option -> US3 option ref) = closure8(v252)
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure9(v99, v253)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v259 : US3 option = _v251.Value 
        let v270 : US3 = US3_1
        let v271 : US3 = v259 |> Option.defaultValue v270 
        let v280 : uint64 =
            match v271 with
            | US3_1 -> (* None *)
                v250
            | US3_0(v275) -> (* Some *)
                let v276 : (int64 -> uint64) = uint64
                let v277 : uint64 = v276 v275
                let v278 : uint64 = v250 - v277
                v278
        let v281 : uint64 = v280 / 1000000000UL
        let v282 : uint64 = v281 % 60UL
        let v283 : uint64 = v281 / 60UL
        let v284 : uint64 = v283 % 60UL
        let v285 : uint64 = v281 / 3600UL
        let v286 : uint64 = v285 % 24UL
        let v287 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v288 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v286, v284, v282) v287 
        let v289 : string = "fable_library_rust::String_::fromString($0)"
        let v290 : string = Fable.Core.RustInterop.emitRustExpr v288 v289 
        let _v112 = v290 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v291 : US3 option = None
        let _v291 = ref v291 
        let v292 : US3 option ref = _v291 
        let v293 : (US3 option -> US3 option ref) = closure8(v292)
        let v294 : unit = ()
        let v295 : (unit -> unit) = closure9(v99, v293)
        let v296 : unit = (fun () -> v295 (); v294) ()
        let v299 : US3 option = _v291.Value 
        let v310 : US3 = US3_1
        let v311 : US3 = v299 |> Option.defaultValue v310 
        let v351 : System.DateTime =
            match v311 with
            | US3_1 -> (* None *)
                let v347 : System.DateTime = System.DateTime.Now
                v347
            | US3_0(v315) -> (* Some *)
                let v316 : System.DateTime = System.DateTime.Now
                let v319 : (System.DateTime -> int64) = _.Ticks
                let v320 : int64 = v319 v316
                let v323 : int64 = v320 - v315
                let v324 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v325 : System.TimeSpan = v324 v323
                let v328 : (System.TimeSpan -> int32) = _.Hours
                let v329 : int32 = v328 v325
                let v332 : (System.TimeSpan -> int32) = _.Minutes
                let v333 : int32 = v332 v325
                let v336 : (System.TimeSpan -> int32) = _.Seconds
                let v337 : int32 = v336 v325
                let v340 : (System.TimeSpan -> int32) = _.Milliseconds
                let v341 : int32 = v340 v325
                let v344 : System.DateTime = System.DateTime (1, 1, 1, v329, v333, v337, v341)
                v344
        let v352 : string = method6()
        let v355 : (string -> string) = v351.ToString
        let v356 : string = v355 v352
        let _v112 = v356 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : US3 option = None
        let _v359 = ref v359 
        let v360 : US3 option ref = _v359 
        let v361 : (US3 option -> US3 option ref) = closure8(v360)
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure9(v99, v361)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v367 : US3 option = _v359.Value 
        let v378 : US3 = US3_1
        let v379 : US3 = v367 |> Option.defaultValue v378 
        let v419 : System.DateTime =
            match v379 with
            | US3_1 -> (* None *)
                let v415 : System.DateTime = System.DateTime.Now
                v415
            | US3_0(v383) -> (* Some *)
                let v384 : System.DateTime = System.DateTime.Now
                let v387 : (System.DateTime -> int64) = _.Ticks
                let v388 : int64 = v387 v384
                let v391 : int64 = v388 - v383
                let v392 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v393 : System.TimeSpan = v392 v391
                let v396 : (System.TimeSpan -> int32) = _.Hours
                let v397 : int32 = v396 v393
                let v400 : (System.TimeSpan -> int32) = _.Minutes
                let v401 : int32 = v400 v393
                let v404 : (System.TimeSpan -> int32) = _.Seconds
                let v405 : int32 = v404 v393
                let v408 : (System.TimeSpan -> int32) = _.Milliseconds
                let v409 : int32 = v408 v393
                let v412 : System.DateTime = System.DateTime (1, 1, 1, v397, v401, v405, v409)
                v412
        let v420 : string = method6()
        let v423 : (string -> string) = v419.ToString
        let v424 : string = v423 v420
        let _v112 = v424 
        #endif
#else
        let v427 : US3 option = None
        let _v427 = ref v427 
        let v428 : US3 option ref = _v427 
        let v429 : (US3 option -> US3 option ref) = closure8(v428)
        let v430 : unit = ()
        let v431 : (unit -> unit) = closure9(v99, v429)
        let v432 : unit = (fun () -> v431 (); v430) ()
        let v435 : US3 option = _v427.Value 
        let v446 : US3 = US3_1
        let v447 : US3 = v435 |> Option.defaultValue v446 
        let v487 : System.DateTime =
            match v447 with
            | US3_1 -> (* None *)
                let v483 : System.DateTime = System.DateTime.Now
                v483
            | US3_0(v451) -> (* Some *)
                let v452 : System.DateTime = System.DateTime.Now
                let v455 : (System.DateTime -> int64) = _.Ticks
                let v456 : int64 = v455 v452
                let v459 : int64 = v456 - v451
                let v460 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v461 : System.TimeSpan = v460 v459
                let v464 : (System.TimeSpan -> int32) = _.Hours
                let v465 : int32 = v464 v461
                let v468 : (System.TimeSpan -> int32) = _.Minutes
                let v469 : int32 = v468 v461
                let v472 : (System.TimeSpan -> int32) = _.Seconds
                let v473 : int32 = v472 v461
                let v476 : (System.TimeSpan -> int32) = _.Milliseconds
                let v477 : int32 = v476 v461
                let v480 : System.DateTime = System.DateTime (1, 1, 1, v465, v469, v473, v477)
                v480
        let v488 : string = method6()
        let v491 : (string -> string) = v487.ToString
        let v492 : string = v491 v488
        let _v112 = v492 
        #endif
        let v495 : string = _v112 
        
        
        
        
        
        let v565 : string = "Warning"
        let v566 : (unit -> string) = v565.ToLower
        let v567 : string = v566 ()
        let v570 : string = v567.PadLeft (7, ' ')
        let v584 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v585 : string = "inline_colorization::color_yellow"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v584 = v595 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v596 : string = "inline_colorization::color_yellow"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v584 = v606 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v607 : string = "inline_colorization::color_yellow"
        let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v607 
        let v609 : string = "&*$0"
        let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v570 v609 
        let v611 : string = "inline_colorization::color_reset"
        let v612 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v611 
        let v613 : string = "\"{v608}{v610}{v612}\""
        let v614 : string = @$"format!(" + v613 + ")"
        let v615 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v614 
        let v616 : string = "fable_library_rust::String_::fromString($0)"
        let v617 : string = Fable.Core.RustInterop.emitRustExpr v615 v616 
        let _v584 = v617 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v618 : string = "\u001b[93m"
        let v619 : string = method7()
        let v620 : string = v618 + v570 
        let v621 : string = v620 + v619 
        let _v584 = v621 
        #endif
#if FABLE_COMPILER_PYTHON
        let v622 : string = "\u001b[93m"
        let v623 : string = method7()
        let v624 : string = v622 + v570 
        let v625 : string = v624 + v623 
        let _v584 = v625 
        #endif
#else
        let v626 : string = "\u001b[93m"
        let v627 : string = method7()
        let v628 : string = v626 + v570 
        let v629 : string = v628 + v627 
        let _v584 = v629 
        #endif
        let v630 : string = _v584 
        let v636 : int64 = v94.l0
        let v637 : string = method8()
        let v638 : Mut3 = {l0 = v637} : Mut3
        let v639 : string = "{ "
        let v640 : string = $"{v639}"
        let v643 : unit = ()
        let v644 : (unit -> unit) = closure20(v638, v640)
        let v645 : unit = (fun () -> v644 (); v643) ()
        let v648 : string = "ex"
        let v649 : string = $"{v648}"
        let v652 : unit = ()
        let v653 : (unit -> unit) = closure20(v638, v649)
        let v654 : unit = (fun () -> v653 (); v652) ()
        let v657 : string = " = "
        let v658 : string = $"{v657}"
        let v661 : unit = ()
        let v662 : (unit -> unit) = closure20(v638, v658)
        let v663 : unit = (fun () -> v662 (); v661) ()
        let v666 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v667 : string = "format!(\"{:#?}\", $0)"
        let v668 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v667 
        let v669 : string = "fable_library_rust::String_::fromString($0)"
        let v670 : string = Fable.Core.RustInterop.emitRustExpr v668 v669 
        let _v666 = v670 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v671 : string = "format!(\"{:#?}\", $0)"
        let v672 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v671 
        let v673 : string = "fable_library_rust::String_::fromString($0)"
        let v674 : string = Fable.Core.RustInterop.emitRustExpr v672 v673 
        let _v666 = v674 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v675 : string = "format!(\"{:#?}\", $0)"
        let v676 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v675 
        let v677 : string = "fable_library_rust::String_::fromString($0)"
        let v678 : string = Fable.Core.RustInterop.emitRustExpr v676 v677 
        let _v666 = v678 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v679 : string = $"%A{v0}"
        let _v666 = v679 
        #endif
#if FABLE_COMPILER_PYTHON
        let v682 : string = $"%A{v0}"
        let _v666 = v682 
        #endif
#else
        let v685 : string = $"%A{v0}"
        let _v666 = v685 
        #endif
        let v688 : string = _v666 
        let v693 : string = $"{v688}"
        let v696 : unit = ()
        let v697 : (unit -> unit) = closure20(v638, v693)
        let v698 : unit = (fun () -> v697 (); v696) ()
        let v701 : string = " }"
        let v702 : string = $"{v701}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure20(v638, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = v638.l0
        let v711 : string = $"runtime.execute_with_options_async / WaitForExitAsync"
        let v712 : bool = v711 = ""
        let v769 : string =
            if v712 then
                let v713 : string = ""
                v713
            else
                let v714 : string = $"{v495} {v630} #{v636} %s{v711} / {v710}"
                let v717 : char list = []
                let v718 : (char list -> (char [])) = List.toArray
                let v719 : (char []) = v718 v717
                let v722 : string = v714.TrimStart v719 
                let v740 : char list = []
                let v741 : char list = '/' :: v740 
                let v744 : char list = ' ' :: v741 
                let v747 : (char list -> (char [])) = List.toArray
                let v748 : (char []) = v747 v744
                let v751 : string = v722.TrimEnd v748 
                v751
        let v770 : (string -> unit) = closure10()
        let v771 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v772 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v769 v772 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v773 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v769 v773 
        let _v771 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v774 : string = v20.l0
        let v775 : bool = v774 = ""
        let v783 : string =
            if v775 then
                v769
            else
                let v776 : bool = v769 = ""
                if v776 then
                    let v777 : string = v20.l0
                    v777
                else
                    let v778 : string = v20.l0
                    let v779 : string = "\n"
                    let v780 : string = v778 + v779 
                    let v781 : string = v780 + v769 
                    v781
        let v784 : string = "&*$0"
        let v785 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v783 v784 
        let v786 : string = $"$0.chars()"
        let v787 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v785 v786 
        let v788 : string = "v787"
        let v789 : _ = Fable.Core.RustInterop.emitRustExpr () v788 
        let v790 : string = "v789.collect::<Vec<_>>()"
        let v791 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v790 
        let v792 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v793 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v791 v792 
        let v794 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v795 : bool = Fable.Core.RustInterop.emitRustExpr v793 v794 
        let v796 : string = "x"
        let v797 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v796 
        let v798 : string = "String::from_iter($0)"
        let v799 : std_string_String = Fable.Core.RustInterop.emitRustExpr v797 v798 
        let v800 : string = "true; $0 }).collect::<Vec<_>>()"
        let v801 : bool = Fable.Core.RustInterop.emitRustExpr v799 v800 
        let v802 : string = "_vec_map"
        let v803 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v802 
        let v804 : string = "$0.len()"
        let v805 : unativeint = Fable.Core.RustInterop.emitRustExpr v803 v804 
        let v806 : (unativeint -> int32) = int32
        let v807 : int32 = v806 v805
        let v808 : string = ""
        let v809 : bool = v769 <> v808 
        let v813 : bool =
            if v809 then
                let v812 : bool = v807 <= 1
                v812
            else
                false
        if v813 then
            v20.l0 <- v783
            ()
        else
            v20.l0 <- v808
            let v814 : string = "true; $0.into_iter().for_each(|x| { //"
            let v815 : bool = Fable.Core.RustInterop.emitRustExpr v803 v814 
            let v816 : string = "x"
            let v817 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v816 
            let v818 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v817 v818 
            let v819 : string = $"true;"
            let v820 : bool = Fable.Core.RustInterop.emitRustExpr () v819 
            let v821 : string = "true; }}); { //"
            let v822 : bool = Fable.Core.RustInterop.emitRustExpr () v821 
            ()
        let _v771 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v770 v769
        let _v771 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v770 v769
        let _v771 = () 
        #endif
#else
        v770 v769
        let _v771 = () 
        #endif
        _v771 
        let v823 : (string -> unit) = v18.l0
        v823 v769
and closure30 (v0 : int32, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : unit = ()
    let v37 : unit = (fun () -> v3 (); v36) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : Mut4, v56 : int64 option) = TraceState.trace_state.Value
    let v69 : US0 = v55.l0
    let v70 : bool = v53.l0
    let v71 : bool = v70 = false
    let v74 : bool =
        if v71 then
            false
        else
            let v72 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v69
            let v73 : bool = 1 >= v72
            v73
    if v74 then
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure7(v18)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v80 : unit = ()
        let v81 : unit = (fun () -> v3 (); v80) ()
        let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : Mut4, v100 : int64 option) = TraceState.trace_state.Value
        let v113 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v114 : US3 option = None
        let _v114 = ref v114 
        let v115 : US3 option ref = _v114 
        let v116 : (US3 option -> US3 option ref) = closure8(v115)
        let v117 : unit = ()
        let v118 : (unit -> unit) = closure9(v100, v116)
        let v119 : unit = (fun () -> v118 (); v117) ()
        let v122 : US3 option = _v114.Value 
        let v133 : US3 = US3_1
        let v134 : US3 = v122 |> Option.defaultValue v133 
        let v174 : System.DateTime =
            match v134 with
            | US3_1 -> (* None *)
                let v170 : System.DateTime = System.DateTime.Now
                v170
            | US3_0(v138) -> (* Some *)
                let v139 : System.DateTime = System.DateTime.Now
                let v142 : (System.DateTime -> int64) = _.Ticks
                let v143 : int64 = v142 v139
                let v146 : int64 = v143 - v138
                let v147 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v148 : System.TimeSpan = v147 v146
                let v151 : (System.TimeSpan -> int32) = _.Hours
                let v152 : int32 = v151 v148
                let v155 : (System.TimeSpan -> int32) = _.Minutes
                let v156 : int32 = v155 v148
                let v159 : (System.TimeSpan -> int32) = _.Seconds
                let v160 : int32 = v159 v148
                let v163 : (System.TimeSpan -> int32) = _.Milliseconds
                let v164 : int32 = v163 v148
                let v167 : System.DateTime = System.DateTime (1, 1, 1, v152, v156, v160, v164)
                v167
        let v175 : string = method5()
        let v178 : (string -> string) = v174.ToString
        let v179 : string = v178 v175
        let _v113 = v179 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v182 : US3 option = None
        let _v182 = ref v182 
        let v183 : US3 option ref = _v182 
        let v184 : (US3 option -> US3 option ref) = closure8(v183)
        let v185 : unit = ()
        let v186 : (unit -> unit) = closure9(v100, v184)
        let v187 : unit = (fun () -> v186 (); v185) ()
        let v190 : US3 option = _v182.Value 
        let v201 : US3 = US3_1
        let v202 : US3 = v190 |> Option.defaultValue v201 
        let v242 : System.DateTime =
            match v202 with
            | US3_1 -> (* None *)
                let v238 : System.DateTime = System.DateTime.Now
                v238
            | US3_0(v206) -> (* Some *)
                let v207 : System.DateTime = System.DateTime.Now
                let v210 : (System.DateTime -> int64) = _.Ticks
                let v211 : int64 = v210 v207
                let v214 : int64 = v211 - v206
                let v215 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v216 : System.TimeSpan = v215 v214
                let v219 : (System.TimeSpan -> int32) = _.Hours
                let v220 : int32 = v219 v216
                let v223 : (System.TimeSpan -> int32) = _.Minutes
                let v224 : int32 = v223 v216
                let v227 : (System.TimeSpan -> int32) = _.Seconds
                let v228 : int32 = v227 v216
                let v231 : (System.TimeSpan -> int32) = _.Milliseconds
                let v232 : int32 = v231 v216
                let v235 : System.DateTime = System.DateTime (1, 1, 1, v220, v224, v228, v232)
                v235
        let v243 : string = method5()
        let v246 : (string -> string) = v242.ToString
        let v247 : string = v246 v243
        let _v113 = v247 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v250 : string = $"near_sdk::env::block_timestamp()"
        let v251 : uint64 = Fable.Core.RustInterop.emitRustExpr () v250 
        let v252 : US3 option = None
        let _v252 = ref v252 
        let v253 : US3 option ref = _v252 
        let v254 : (US3 option -> US3 option ref) = closure8(v253)
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure9(v100, v254)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v260 : US3 option = _v252.Value 
        let v271 : US3 = US3_1
        let v272 : US3 = v260 |> Option.defaultValue v271 
        let v281 : uint64 =
            match v272 with
            | US3_1 -> (* None *)
                v251
            | US3_0(v276) -> (* Some *)
                let v277 : (int64 -> uint64) = uint64
                let v278 : uint64 = v277 v276
                let v279 : uint64 = v251 - v278
                v279
        let v282 : uint64 = v281 / 1000000000UL
        let v283 : uint64 = v282 % 60UL
        let v284 : uint64 = v282 / 60UL
        let v285 : uint64 = v284 % 60UL
        let v286 : uint64 = v282 / 3600UL
        let v287 : uint64 = v286 % 24UL
        let v288 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v289 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v287, v285, v283) v288 
        let v290 : string = "fable_library_rust::String_::fromString($0)"
        let v291 : string = Fable.Core.RustInterop.emitRustExpr v289 v290 
        let _v113 = v291 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v292 : US3 option = None
        let _v292 = ref v292 
        let v293 : US3 option ref = _v292 
        let v294 : (US3 option -> US3 option ref) = closure8(v293)
        let v295 : unit = ()
        let v296 : (unit -> unit) = closure9(v100, v294)
        let v297 : unit = (fun () -> v296 (); v295) ()
        let v300 : US3 option = _v292.Value 
        let v311 : US3 = US3_1
        let v312 : US3 = v300 |> Option.defaultValue v311 
        let v352 : System.DateTime =
            match v312 with
            | US3_1 -> (* None *)
                let v348 : System.DateTime = System.DateTime.Now
                v348
            | US3_0(v316) -> (* Some *)
                let v317 : System.DateTime = System.DateTime.Now
                let v320 : (System.DateTime -> int64) = _.Ticks
                let v321 : int64 = v320 v317
                let v324 : int64 = v321 - v316
                let v325 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v326 : System.TimeSpan = v325 v324
                let v329 : (System.TimeSpan -> int32) = _.Hours
                let v330 : int32 = v329 v326
                let v333 : (System.TimeSpan -> int32) = _.Minutes
                let v334 : int32 = v333 v326
                let v337 : (System.TimeSpan -> int32) = _.Seconds
                let v338 : int32 = v337 v326
                let v341 : (System.TimeSpan -> int32) = _.Milliseconds
                let v342 : int32 = v341 v326
                let v345 : System.DateTime = System.DateTime (1, 1, 1, v330, v334, v338, v342)
                v345
        let v353 : string = method6()
        let v356 : (string -> string) = v352.ToString
        let v357 : string = v356 v353
        let _v113 = v357 
        #endif
#if FABLE_COMPILER_PYTHON
        let v360 : US3 option = None
        let _v360 = ref v360 
        let v361 : US3 option ref = _v360 
        let v362 : (US3 option -> US3 option ref) = closure8(v361)
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure9(v100, v362)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v368 : US3 option = _v360.Value 
        let v379 : US3 = US3_1
        let v380 : US3 = v368 |> Option.defaultValue v379 
        let v420 : System.DateTime =
            match v380 with
            | US3_1 -> (* None *)
                let v416 : System.DateTime = System.DateTime.Now
                v416
            | US3_0(v384) -> (* Some *)
                let v385 : System.DateTime = System.DateTime.Now
                let v388 : (System.DateTime -> int64) = _.Ticks
                let v389 : int64 = v388 v385
                let v392 : int64 = v389 - v384
                let v393 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v394 : System.TimeSpan = v393 v392
                let v397 : (System.TimeSpan -> int32) = _.Hours
                let v398 : int32 = v397 v394
                let v401 : (System.TimeSpan -> int32) = _.Minutes
                let v402 : int32 = v401 v394
                let v405 : (System.TimeSpan -> int32) = _.Seconds
                let v406 : int32 = v405 v394
                let v409 : (System.TimeSpan -> int32) = _.Milliseconds
                let v410 : int32 = v409 v394
                let v413 : System.DateTime = System.DateTime (1, 1, 1, v398, v402, v406, v410)
                v413
        let v421 : string = method6()
        let v424 : (string -> string) = v420.ToString
        let v425 : string = v424 v421
        let _v113 = v425 
        #endif
#else
        let v428 : US3 option = None
        let _v428 = ref v428 
        let v429 : US3 option ref = _v428 
        let v430 : (US3 option -> US3 option ref) = closure8(v429)
        let v431 : unit = ()
        let v432 : (unit -> unit) = closure9(v100, v430)
        let v433 : unit = (fun () -> v432 (); v431) ()
        let v436 : US3 option = _v428.Value 
        let v447 : US3 = US3_1
        let v448 : US3 = v436 |> Option.defaultValue v447 
        let v488 : System.DateTime =
            match v448 with
            | US3_1 -> (* None *)
                let v484 : System.DateTime = System.DateTime.Now
                v484
            | US3_0(v452) -> (* Some *)
                let v453 : System.DateTime = System.DateTime.Now
                let v456 : (System.DateTime -> int64) = _.Ticks
                let v457 : int64 = v456 v453
                let v460 : int64 = v457 - v452
                let v461 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v462 : System.TimeSpan = v461 v460
                let v465 : (System.TimeSpan -> int32) = _.Hours
                let v466 : int32 = v465 v462
                let v469 : (System.TimeSpan -> int32) = _.Minutes
                let v470 : int32 = v469 v462
                let v473 : (System.TimeSpan -> int32) = _.Seconds
                let v474 : int32 = v473 v462
                let v477 : (System.TimeSpan -> int32) = _.Milliseconds
                let v478 : int32 = v477 v462
                let v481 : System.DateTime = System.DateTime (1, 1, 1, v466, v470, v474, v478)
                v481
        let v489 : string = method6()
        let v492 : (string -> string) = v488.ToString
        let v493 : string = v492 v489
        let _v113 = v493 
        #endif
        let v496 : string = _v113 
        
        
        
        
        
        let v566 : string = "Debug"
        let v567 : (unit -> string) = v566.ToLower
        let v568 : string = v567 ()
        let v571 : string = v568.PadLeft (7, ' ')
        let v585 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v586 : string = "inline_colorization::color_bright_blue"
        let v587 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "&*$0"
        let v589 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v588 
        let v590 : string = "inline_colorization::color_reset"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "\"{v587}{v589}{v591}\""
        let v593 : string = @$"format!(" + v592 + ")"
        let v594 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v593 
        let v595 : string = "fable_library_rust::String_::fromString($0)"
        let v596 : string = Fable.Core.RustInterop.emitRustExpr v594 v595 
        let _v585 = v596 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v597 : string = "inline_colorization::color_bright_blue"
        let v598 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "&*$0"
        let v600 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v599 
        let v601 : string = "inline_colorization::color_reset"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "\"{v598}{v600}{v602}\""
        let v604 : string = @$"format!(" + v603 + ")"
        let v605 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v604 
        let v606 : string = "fable_library_rust::String_::fromString($0)"
        let v607 : string = Fable.Core.RustInterop.emitRustExpr v605 v606 
        let _v585 = v607 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v608 : string = "inline_colorization::color_bright_blue"
        let v609 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "&*$0"
        let v611 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v571 v610 
        let v612 : string = "inline_colorization::color_reset"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "\"{v609}{v611}{v613}\""
        let v615 : string = @$"format!(" + v614 + ")"
        let v616 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v615 
        let v617 : string = "fable_library_rust::String_::fromString($0)"
        let v618 : string = Fable.Core.RustInterop.emitRustExpr v616 v617 
        let _v585 = v618 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v619 : string = "\u001b[94m"
        let v620 : string = method7()
        let v621 : string = v619 + v571 
        let v622 : string = v621 + v620 
        let _v585 = v622 
        #endif
#if FABLE_COMPILER_PYTHON
        let v623 : string = "\u001b[94m"
        let v624 : string = method7()
        let v625 : string = v623 + v571 
        let v626 : string = v625 + v624 
        let _v585 = v626 
        #endif
#else
        let v627 : string = "\u001b[94m"
        let v628 : string = method7()
        let v629 : string = v627 + v571 
        let v630 : string = v629 + v628 
        let _v585 = v630 
        #endif
        let v631 : string = _v585 
        let v637 : int64 = v95.l0
        let v638 : int32 = v1.Length
        let v639 : string = method8()
        let v640 : Mut3 = {l0 = v639} : Mut3
        let v641 : string = "{ "
        let v642 : string = $"{v641}"
        let v645 : unit = ()
        let v646 : (unit -> unit) = closure20(v640, v642)
        let v647 : unit = (fun () -> v646 (); v645) ()
        let v650 : string = "exit_code"
        let v651 : string = $"{v650}"
        let v654 : unit = ()
        let v655 : (unit -> unit) = closure20(v640, v651)
        let v656 : unit = (fun () -> v655 (); v654) ()
        let v659 : string = " = "
        let v660 : string = $"{v659}"
        let v663 : unit = ()
        let v664 : (unit -> unit) = closure20(v640, v660)
        let v665 : unit = (fun () -> v664 (); v663) ()
        let v668 : string = $"{v0}"
        let v671 : unit = ()
        let v672 : (unit -> unit) = closure20(v640, v668)
        let v673 : unit = (fun () -> v672 (); v671) ()
        let v676 : string = "; "
        let v677 : string = $"{v676}"
        let v680 : unit = ()
        let v681 : (unit -> unit) = closure20(v640, v677)
        let v682 : unit = (fun () -> v681 (); v680) ()
        let v685 : string = "output_length"
        let v686 : string = $"{v685}"
        let v689 : unit = ()
        let v690 : (unit -> unit) = closure20(v640, v686)
        let v691 : unit = (fun () -> v690 (); v689) ()
        let v694 : string = $"{v659}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure20(v640, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = $"{v638}"
        let v705 : unit = ()
        let v706 : (unit -> unit) = closure20(v640, v702)
        let v707 : unit = (fun () -> v706 (); v705) ()
        let v710 : string = " }"
        let v711 : string = $"{v710}"
        let v714 : unit = ()
        let v715 : (unit -> unit) = closure20(v640, v711)
        let v716 : unit = (fun () -> v715 (); v714) ()
        let v719 : string = v640.l0
        let v720 : string = $"runtime.execute_with_options_async"
        let v721 : bool = v720 = ""
        let v778 : string =
            if v721 then
                let v722 : string = ""
                v722
            else
                let v723 : string = $"{v496} {v631} #{v637} %s{v720} / {v719}"
                let v726 : char list = []
                let v727 : (char list -> (char [])) = List.toArray
                let v728 : (char []) = v727 v726
                let v731 : string = v723.TrimStart v728 
                let v749 : char list = []
                let v750 : char list = '/' :: v749 
                let v753 : char list = ' ' :: v750 
                let v756 : (char list -> (char [])) = List.toArray
                let v757 : (char []) = v756 v753
                let v760 : string = v731.TrimEnd v757 
                v760
        let v779 : (string -> unit) = closure10()
        let v780 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v781 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v778 v781 
        let _v780 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v782 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v778 v782 
        let _v780 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v783 : string = v21.l0
        let v784 : bool = v783 = ""
        let v792 : string =
            if v784 then
                v778
            else
                let v785 : bool = v778 = ""
                if v785 then
                    let v786 : string = v21.l0
                    v786
                else
                    let v787 : string = v21.l0
                    let v788 : string = "\n"
                    let v789 : string = v787 + v788 
                    let v790 : string = v789 + v778 
                    v790
        let v793 : string = "&*$0"
        let v794 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v792 v793 
        let v795 : string = $"$0.chars()"
        let v796 : Mut<_> = Fable.Core.RustInterop.emitRustExpr v794 v795 
        let v797 : string = "v796"
        let v798 : _ = Fable.Core.RustInterop.emitRustExpr () v797 
        let v799 : string = "v798.collect::<Vec<_>>()"
        let v800 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v799 
        let v801 : string = "$0.chunks(15000).map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>()).collect::<Vec<_>>()"
        let v802 : Vec<Vec<char>> = Fable.Core.RustInterop.emitRustExpr v800 v801 
        let v803 : string = "true; let _vec_map : Vec<_> = $0.into_iter().map(|x| { //"
        let v804 : bool = Fable.Core.RustInterop.emitRustExpr v802 v803 
        let v805 : string = "x"
        let v806 : Vec<char> = Fable.Core.RustInterop.emitRustExpr () v805 
        let v807 : string = "String::from_iter($0)"
        let v808 : std_string_String = Fable.Core.RustInterop.emitRustExpr v806 v807 
        let v809 : string = "true; $0 }).collect::<Vec<_>>()"
        let v810 : bool = Fable.Core.RustInterop.emitRustExpr v808 v809 
        let v811 : string = "_vec_map"
        let v812 : Vec<std_string_String> = Fable.Core.RustInterop.emitRustExpr () v811 
        let v813 : string = "$0.len()"
        let v814 : unativeint = Fable.Core.RustInterop.emitRustExpr v812 v813 
        let v815 : (unativeint -> int32) = int32
        let v816 : int32 = v815 v814
        let v817 : string = ""
        let v818 : bool = v778 <> v817 
        let v822 : bool =
            if v818 then
                let v821 : bool = v816 <= 1
                v821
            else
                false
        if v822 then
            v21.l0 <- v792
            ()
        else
            v21.l0 <- v817
            let v823 : string = "true; $0.into_iter().for_each(|x| { //"
            let v824 : bool = Fable.Core.RustInterop.emitRustExpr v812 v823 
            let v825 : string = "x"
            let v826 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v825 
            let v827 : string = $"near_sdk::log!(\"{{}}\", $0)"
            Fable.Core.RustInterop.emitRustExpr v826 v827 
            let v828 : string = $"true;"
            let v829 : bool = Fable.Core.RustInterop.emitRustExpr () v828 
            let v830 : string = "true; }}); { //"
            let v831 : bool = Fable.Core.RustInterop.emitRustExpr () v830 
            ()
        let _v780 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        v779 v778
        let _v780 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        v779 v778
        let _v780 = () 
        #endif
#else
        v779 v778
        let _v780 = () 
        #endif
        _v780 
        let v832 : (string -> unit) = v19.l0
        v832 v778
and method9 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
#else
    let v23 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v24 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v23 = v24 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v23 = v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v23 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v23 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    let _v23 = v36 
    #endif
#else
    let v39 : Async<struct (int32 * string)> option = None
    let mutable _v39 = v39 
    async {
    let v40 : US4 = method10(v0)
    let struct (v49 : string, v50 : US1) =
        match v40 with
        | US4_1(v43) -> (* Error *)
            let v44 : string = $"resultm.get / Result value was Error: {v43}"
            failwith<struct (string * US1)> v44
        | US4_0(v41, v42) -> (* Ok *)
            struct (v41, v42)
    let v51 : US1 option = None
    let _v51 = ref v51 
    let v52 : US1 option ref = _v51 
    let v53 : (US1 option -> US1 option ref) = closure1(v52)
    let v54 : unit = ()
    let v55 : (unit -> unit) = closure2(v6, v53)
    let v56 : unit = (fun () -> v55 (); v54) ()
    let v59 : US1 option = _v51.Value 
    let v70 : US1 = US1_1
    let v71 : US1 = v59 |> Option.defaultValue v70 
    let v78 : string =
        match v71 with
        | US1_1 -> (* None *)
            let v76 : string = ""
            v76
        | US1_0(v75) -> (* Some *)
            v75
    let v79 : unit = ()
    let v80 : (unit -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v1224 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v1228 : string =
        match v50 with
        | US1_1 -> (* None *)
            let v1226 : string = ""
            v1226
        | US1_0(v1225) -> (* Some *)
            v1225
    let start_info = System.Diagnostics.ProcessStartInfo (
      Arguments = v1228,
      StandardOutputEncoding = v1224,
      WorkingDirectory = v78,
      FileName = v49,
      CreateNoWindow = true,
      RedirectStandardError = true,
      RedirectStandardOutput = true,
      UseShellExecute = false
    )
    let v1229 : System.Diagnostics.ProcessStartInfo = start_info
    let v1230 : int32 = v2.Length
    let v1231 : Mut5 = {l0 = 0} : Mut5
    while method11(v1230, v1231) do
        let v1233 : int32 = v1231.l0
        let struct (v1234 : string, v1235 : string) = v2.[int v1233]
        v1229.EnvironmentVariables.[v1234] <- v1235 
        let v1236 : int32 = v1233 + 1
        v1231.l0 <- v1236
        ()
    let v1237 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1229)
    use v1237 = v1237 
    let v1238 : System.Diagnostics.Process = v1237 
    let v1239 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v1240 : System.Collections.Concurrent.ConcurrentStack<string> = v1239 ()
    let v1241 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure21(v0, v1, v2, v3, v4, v5, v6, v1238, v1240)
    v1238.OutputDataReceived.Add v1241 
    let v1242 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure25(v0, v1, v2, v3, v4, v5, v6, v1238, v1240)
    v1238.ErrorDataReceived.Add v1242 
    let v1243 : (unit -> bool) = v1238.Start
    let v1244 : bool = v1243 ()
    let v1245 : bool = v1244 = false
    if v1245 then
        let v1246 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v1246
    let v1247 : (unit -> unit) = v1238.BeginErrorReadLine
    v1247 ()
    let v1248 : (unit -> unit) = v1238.BeginOutputReadLine
    v1248 ()
    let v1249 : US13 option = None
    let _v1249 = ref v1249 
    let v1250 : US13 option ref = _v1249 
    let v1251 : (US13 option -> US13 option ref) = closure26(v1250)
    let v1252 : unit = ()
    let v1253 : (unit -> unit) = closure27(v1, v1251)
    let v1254 : unit = (fun () -> v1253 (); v1252) ()
    let v1257 : US13 option = _v1249.Value 
    let v1268 : US13 = US13_1
    let v1269 : US13 = v1257 |> Option.defaultValue v1268 
    let v1276 : System.Threading.CancellationToken =
        match v1269 with
        | US13_1 -> (* None *)
            let v1274 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v1274
        | US13_0(v1273) -> (* Some *)
            v1273
    let v1277 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1278 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1277 = v1278 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1281 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1277 = v1281 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1284 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1277 = v1284 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1287 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1277 = v1287 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1290 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1277 = v1290 
    #endif
#else
    let v1293 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1294 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1293 = v1294 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1297 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1293 = v1297 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1300 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1293 = v1300 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1303 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1293 = v1303 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1306 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1293 = v1306 
    #endif
#else
    let v1309 : Async<System.Threading.CancellationToken> option = None
    let mutable _v1309 = v1309 
    async {
    let v1310 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v1310 = v1310 
    let v1311 : System.Threading.CancellationToken = v1310 
    let v1312 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v1313 : (System.Threading.CancellationToken []) = [|v1311; v1312; v1276|]
    let v1314 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v1315 : System.Threading.CancellationTokenSource = v1314 v1313
    let v1316 : System.Threading.CancellationToken = v1315.Token
    return v1316 
    }
    |> fun x -> _v1309 <- Some x
    let v1317 : Async<System.Threading.CancellationToken> = match _v1309 with Some x -> x | None -> failwith "async.new_async_unit / _v1309=None"
    let _v1293 = v1317 
    #endif
    let v1318 : Async<System.Threading.CancellationToken> = _v1293 
    let _v1277 = v1318 
    #endif
    let v1323 : Async<System.Threading.CancellationToken> = _v1277 
    let! v1323 = v1323 
    let v1328 : System.Threading.CancellationToken = v1323 
    let v1329 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1328.Register
    let v1330 : (unit -> unit) = closure28(v1238)
    let v1331 : System.Threading.CancellationTokenRegistration = v1329 v1330
    use v1331 = v1331 
    let v1332 : System.Threading.CancellationTokenRegistration = v1331 
    let v1333 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1334 : Async<int32> = null |> unbox<Async<int32>>
    let _v1333 = v1334 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1337 : Async<int32> = null |> unbox<Async<int32>>
    let _v1333 = v1337 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1340 : Async<int32> = null |> unbox<Async<int32>>
    let _v1333 = v1340 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1343 : Async<int32> = null |> unbox<Async<int32>>
    let _v1333 = v1343 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1346 : Async<int32> = null |> unbox<Async<int32>>
    let _v1333 = v1346 
    #endif
#else
    let v1349 : Async<int32> option = None
    let mutable _v1349 = v1349 
    async {
    try
    let v1350 : System.Threading.Tasks.Task = v1238.WaitForExitAsync v1328 
    let v1351 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1352 : Async<unit> = null |> unbox<Async<unit>>
    let _v1351 = v1352 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1355 : Async<unit> = null |> unbox<Async<unit>>
    let _v1351 = v1355 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1358 : Async<unit> = null |> unbox<Async<unit>>
    let _v1351 = v1358 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1361 : Async<unit> = null |> unbox<Async<unit>>
    let _v1351 = v1361 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1364 : Async<unit> = null |> unbox<Async<unit>>
    let _v1351 = v1364 
    #endif
#else
    let v1367 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1368 : Async<unit> = v1367 v1350
    let _v1351 = v1368 
    #endif
    let v1369 : Async<unit> = _v1351 
    do! v1369 
    let v1374 : int32 = v1238.ExitCode
    return v1374 
    with ex ->
    let v1375 : exn = ex
    let v1376 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1377 : string = $"%A{v1375}"
    let _v1376 = v1377 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1380 : string = $"%A{v1375}"
    let _v1376 = v1380 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1383 : string = $"%A{v1375}"
    let _v1376 = v1383 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1386 : string = $"%A{v1375}"
    let _v1376 = v1386 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1389 : string = $"%A{v1375}"
    let _v1376 = v1389 
    #endif
#else
    let v1392 : string = $"{v1375.GetType ()}: {v1375.Message}"
    let _v1376 = v1392 
    #endif
    let v1393 : string = _v1376 
    let v1398 : (string -> unit) = v1240.Push
    v1398 v1393
    let v1399 : System.Threading.Tasks.TaskCanceledException = v1375 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v1402 : unit = ()
    let v1403 : (unit -> unit) = closure29(v1399)
    let v1404 : unit = (fun () -> v1403 (); v1402) ()
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v1349 <- Some x
    let v2228 : Async<int32> = match _v1349 with Some x -> x | None -> failwith "async.new_async_unit / _v1349=None"
    let _v1333 = v2228 
    #endif
    let v2229 : Async<int32> = _v1333 
    let! v2229 = v2229 
    let v2234 : int32 = v2229 
    let v2235 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v2236 : string seq = v2235 v1240
    let v2239 : (string -> (string seq -> string)) = String.concat
    let v2240 : string = "\n"
    let v2241 : (string seq -> string) = v2239 v2240
    let v2242 : string = v2241 v2236
    let v2245 : unit = ()
    let v2246 : (unit -> unit) = closure30(v2234, v2242)
    let v2247 : unit = (fun () -> v2246 (); v2245) ()
    return struct (v2234, v2242) 
    }
    |> fun x -> _v39 <- Some x
    let v3078 : Async<struct (int32 * string)> = match _v39 with Some x -> x | None -> failwith "async.new_async_unit / _v39=None"
    let _v23 = v3078 
    #endif
    let v3079 : Async<struct (int32 * string)> = _v23 
    let _v7 = v3079 
    #endif
    let v3084 : Async<struct (int32 * string)> = _v7 
    v3084
and closure14 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method9(v0, v1, v2, v3, v4, v6, v5)
and closure31 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method9(v0, v1, v2, v3, v4, v5, v6)
and closure32 () (v0 : (Heap0 -> Heap0)) : struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) =
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
and method24 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 4L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v19 : US7 =
            if v3 then
                US7_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US7_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US7_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        let v12 : bool = v11 = 0L
                        if v12 then
                            US7_0(' ')
                        else
                            let v14 : int64 = v11 - 1L
                            US7_1
        let v23 : char =
            match v19 with
            | US7_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US7_0(v20) -> (* Some *)
                v20
        let v24 : bool = v0 = v23
        if v24 then
            true
        else
            let v25 : int64 = v1 + 1L
            method24(v0, v25)
and method25 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v82 : US5 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : char list = '`' :: v10 
            let v16 : char list = '\\' :: v13 
            let v19 : (char list -> (char [])) = List.toArray
            let v20 : (char []) = v19 v16
            let v23 : string = $"parsing.none_of / unexpected end of input / chars: %A{v20} / s: %A{struct (v2, v3, v4)}"
            US5_1(v23)
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
            let v34 : bool = method24(v25, v33)
            let v35 : bool = v34 = false
            if v35 then
                let v36 : (char -> string) = _.ToString()
                let v37 : string = v36 v25
                let v40 : int32 = v37.Length
                let v41 : (char []) = Array.zeroCreate<char> (v40)
                let v42 : Mut5 = {l0 = 0} : Mut5
                while method11(v40, v42) do
                    let v44 : int32 = v42.l0
                    let v45 : char = v37.[int v44]
                    v41.[int v44] <- v45
                    let v46 : int32 = v44 + 1
                    v42.l0 <- v46
                    ()
                let v47 : char list = v41 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method12()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v47
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v58 : System.Text.StringBuilder, v59 : int32, v60 : int32) = method13(v53, v2, v3, v4)
                US5_0(v25, v32, v58, v59, v60)
            else
                let v62 : char list = []
                let v63 : char list = ' ' :: v62 
                let v66 : char list = '"' :: v63 
                let v69 : char list = '`' :: v66 
                let v72 : char list = '\\' :: v69 
                let v75 : (char list -> (char [])) = List.toArray
                let v76 : (char []) = v75 v72
                let v79 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v76} / s: %A{struct (v2, v3, v4)}"
                US5_1(v79)
    match v82 with
    | US5_1(v94) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v83, v84, v85, v86, v87) -> (* Ok *)
        let v88 : (char -> string) = _.ToString()
        let v89 : string = v88 v83
        let v92 : string = v0 + v89 
        method25(v92, v84, v85, v86, v87)
and method27 (v0 : char, v1 : int64) : bool =
    let v2 : bool = v1 >= 3L
    if v2 then
        false
    else
        let v3 : bool = v1 = 0L
        let v15 : US7 =
            if v3 then
                US7_0('\\')
            else
                let v5 : int64 = v1 - 1L
                let v6 : bool = v5 = 0L
                if v6 then
                    US7_0('`')
                else
                    let v8 : int64 = v5 - 1L
                    let v9 : bool = v8 = 0L
                    if v9 then
                        US7_0('"')
                    else
                        let v11 : int64 = v8 - 1L
                        US7_1
        let v19 : char =
            match v15 with
            | US7_1 -> (* None *)
                failwith<char> "Option does not have a value."
            | US7_0(v16) -> (* Some *)
                v16
        let v20 : bool = v0 = v19
        if v20 then
            true
        else
            let v21 : int64 = v1 + 1L
            method27(v0, v21)
and closure34 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
    let v4 : bool = "" = v0
    let v67 : US5 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US5_1(v5)
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
                while method11(v20, v22) do
                    let v24 : int32 = v22.l0
                    let v25 : char = v17.[int v24]
                    v21.[int v24] <- v25
                    let v26 : int32 = v24 + 1
                    v22.l0 <- v26
                    ()
                let v27 : char list = v21 |> Array.toList
                let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v29 : (char -> (UH0 -> UH0)) = method12()
                let v30 : (char list -> (UH0 -> UH0)) = v28 v29
                let v31 : (UH0 -> UH0) = v30 v27
                let v32 : UH0 = UH0_0
                let v33 : UH0 = v31 v32
                let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method13(v33, v1, v2, v3)
                US5_0(v7, v15, v38, v39, v40)
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
                US5_1(v64)
    let v114 : US5 =
        match v67 with
        | US5_1(v111) -> (* Error *)
            US5_1(v111)
        | US5_0(v68, v69, v70, v71, v72) -> (* Ok *)
            let v73 : bool = "" = v69
            if v73 then
                let v74 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v70, v71, v72)}"
                US5_1(v74)
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
                while method11(v88, v90) do
                    let v92 : int32 = v90.l0
                    let v93 : char = v85.[int v92]
                    v89.[int v92] <- v93
                    let v94 : int32 = v92 + 1
                    v90.l0 <- v94
                    ()
                let v95 : char list = v89 |> Array.toList
                let v96 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v97 : (char -> (UH0 -> UH0)) = method12()
                let v98 : (char list -> (UH0 -> UH0)) = v96 v97
                let v99 : (UH0 -> UH0) = v98 v95
                let v100 : UH0 = UH0_0
                let v101 : UH0 = v99 v100
                let struct (v106 : System.Text.StringBuilder, v107 : int32, v108 : int32) = method13(v101, v70, v71, v72)
                US5_0(v76, v83, v106, v107, v108)
    match v114 with
    | US5_1(v122) -> (* Error *)
        US6_1(v122)
    | US5_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v120 : string = $"{'\\'}{v115}"
        US6_0(v120, v116, v117, v118, v119)
and closure35 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
    let v4 : bool = "" = v0
    let v67 : US5 =
        if v4 then
            let v5 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v1, v2, v3)}"
            US5_1(v5)
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
                while method11(v20, v22) do
                    let v24 : int32 = v22.l0
                    let v25 : char = v17.[int v24]
                    v21.[int v24] <- v25
                    let v26 : int32 = v24 + 1
                    v22.l0 <- v26
                    ()
                let v27 : char list = v21 |> Array.toList
                let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v29 : (char -> (UH0 -> UH0)) = method12()
                let v30 : (char list -> (UH0 -> UH0)) = v28 v29
                let v31 : (UH0 -> UH0) = v30 v27
                let v32 : UH0 = UH0_0
                let v33 : UH0 = v31 v32
                let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method13(v33, v1, v2, v3)
                US5_0(v7, v15, v38, v39, v40)
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
                US5_1(v64)
    let v114 : US5 =
        match v67 with
        | US5_1(v111) -> (* Error *)
            US5_1(v111)
        | US5_0(v68, v69, v70, v71, v72) -> (* Ok *)
            let v73 : bool = "" = v69
            if v73 then
                let v74 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v70, v71, v72)}"
                US5_1(v74)
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
                while method11(v88, v90) do
                    let v92 : int32 = v90.l0
                    let v93 : char = v85.[int v92]
                    v89.[int v92] <- v93
                    let v94 : int32 = v92 + 1
                    v90.l0 <- v94
                    ()
                let v95 : char list = v89 |> Array.toList
                let v96 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v97 : (char -> (UH0 -> UH0)) = method12()
                let v98 : (char list -> (UH0 -> UH0)) = v96 v97
                let v99 : (UH0 -> UH0) = v98 v95
                let v100 : UH0 = UH0_0
                let v101 : UH0 = v99 v100
                let struct (v106 : System.Text.StringBuilder, v107 : int32, v108 : int32) = method13(v101, v70, v71, v72)
                US5_0(v76, v83, v106, v107, v108)
    match v114 with
    | US5_1(v122) -> (* Error *)
        US6_1(v122)
    | US5_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v120 : string = $"{'`'}{v115}"
        US6_0(v120, v116, v117, v118, v119)
and method28 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US6 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US6 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US6_1(v15) -> (* Error *)
            method28(v0, v1, v2, v3, v8)
        | US6_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US6_1(v5)
and method29 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method29(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method26 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
    let v5 : bool = "" = v1
    let v76 : US5 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v10 : char list = '`' :: v7 
            let v13 : char list = '\\' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US5_1(v20)
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
            let v31 : bool = method27(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method11(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method12()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method13(v50, v2, v3, v4)
                US5_0(v22, v29, v55, v56, v57)
            else
                let v59 : char list = []
                let v60 : char list = '"' :: v59 
                let v63 : char list = '`' :: v60 
                let v66 : char list = '\\' :: v63 
                let v69 : (char list -> (char [])) = List.toArray
                let v70 : (char []) = v69 v66
                let v73 : string = $"parsing.none_of / unexpected char: '{v22}' / chars: %A{v70} / s: %A{struct (v2, v3, v4)}"
                US5_1(v73)
    let v90 : US6 =
        match v76 with
        | US5_1(v87) -> (* Error *)
            US6_1(v87)
        | US5_0(v77, v78, v79, v80, v81) -> (* Ok *)
            let v82 : (char -> string) = _.ToString()
            let v83 : string = v82 v77
            US6_0(v83, v78, v79, v80, v81)
    let v104 : US6 =
        match v90 with
        | US6_1(v96) -> (* Error *)
            let v97 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure34()
            let v98 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure35()
            let v99 : UH3 = UH3_0
            let v100 : UH3 = UH3_1(v98, v99)
            let v101 : UH3 = UH3_1(v97, v100)
            method28(v1, v2, v3, v4, v101)
        | US6_0(v91, v92, v93, v94, v95) -> (* Ok *)
            v90
    match v104 with
    | US6_1(v112) -> (* Error *)
        let v113 : UH2 = UH2_0
        let v114 : UH2 = method29(v0, v113)
        US15_0(v114, v1, v2, v3, v4)
    | US6_0(v105, v106, v107, v108, v109) -> (* Ok *)
        let v110 : UH2 = UH2_1(v105, v0)
        method26(v110, v106, v107, v108, v109)
and method30 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method30(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method31 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
    let v5 : bool = "" = v1
    let v76 : US5 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = '"' :: v6 
            let v10 : char list = '`' :: v7 
            let v13 : char list = '\\' :: v10 
            let v16 : (char list -> (char [])) = List.toArray
            let v17 : (char []) = v16 v13
            let v20 : string = $"parsing.none_of / unexpected end of input / chars: %A{v17} / s: %A{struct (v2, v3, v4)}"
            US5_1(v20)
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
            let v31 : bool = method27(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method11(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method12()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method13(v50, v2, v3, v4)
                US5_0(v22, v29, v55, v56, v57)
            else
                let v59 : char list = []
                let v60 : char list = '"' :: v59 
                let v63 : char list = '`' :: v60 
                let v66 : char list = '\\' :: v63 
                let v69 : (char list -> (char [])) = List.toArray
                let v70 : (char []) = v69 v66
                let v73 : string = $"parsing.none_of / unexpected char: '{v22}' / chars: %A{v70} / s: %A{struct (v2, v3, v4)}"
                US5_1(v73)
    let v90 : US6 =
        match v76 with
        | US5_1(v87) -> (* Error *)
            US6_1(v87)
        | US5_0(v77, v78, v79, v80, v81) -> (* Ok *)
            let v82 : (char -> string) = _.ToString()
            let v83 : string = v82 v77
            US6_0(v83, v78, v79, v80, v81)
    match v90 with
    | US6_1(v98) -> (* Error *)
        let v99 : UH2 = UH2_0
        let v100 : UH2 = method29(v0, v99)
        US15_0(v100, v1, v2, v3, v4)
    | US6_0(v91, v92, v93, v94, v95) -> (* Ok *)
        let v96 : UH2 = UH2_1(v91, v0)
        method31(v96, v92, v93, v94, v95)
and method32 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method32(v0, v6)
        else
            v1
and method23 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
    let v5 : bool = "" = v1
    let v82 : US5 =
        if v5 then
            let v6 : char list = []
            let v7 : char list = ' ' :: v6 
            let v10 : char list = '"' :: v7 
            let v13 : char list = '`' :: v10 
            let v16 : char list = '\\' :: v13 
            let v19 : (char list -> (char [])) = List.toArray
            let v20 : (char []) = v19 v16
            let v23 : string = $"parsing.none_of / unexpected end of input / chars: %A{v20} / s: %A{struct (v2, v3, v4)}"
            US5_1(v23)
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
            let v34 : bool = method24(v25, v33)
            let v35 : bool = v34 = false
            if v35 then
                let v36 : (char -> string) = _.ToString()
                let v37 : string = v36 v25
                let v40 : int32 = v37.Length
                let v41 : (char []) = Array.zeroCreate<char> (v40)
                let v42 : Mut5 = {l0 = 0} : Mut5
                while method11(v40, v42) do
                    let v44 : int32 = v42.l0
                    let v45 : char = v37.[int v44]
                    v41.[int v44] <- v45
                    let v46 : int32 = v44 + 1
                    v42.l0 <- v46
                    ()
                let v47 : char list = v41 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method12()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v47
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v58 : System.Text.StringBuilder, v59 : int32, v60 : int32) = method13(v53, v2, v3, v4)
                US5_0(v25, v32, v58, v59, v60)
            else
                let v62 : char list = []
                let v63 : char list = ' ' :: v62 
                let v66 : char list = '"' :: v63 
                let v69 : char list = '`' :: v66 
                let v72 : char list = '\\' :: v69 
                let v75 : (char list -> (char [])) = List.toArray
                let v76 : (char []) = v75 v72
                let v79 : string = $"parsing.none_of / unexpected char: '{v25}' / chars: %A{v76} / s: %A{struct (v2, v3, v4)}"
                US5_1(v79)
    let v96 : US6 =
        match v82 with
        | US5_1(v83) -> (* Error *)
            US6_1(v83)
        | US5_0(v85, v86, v87, v88, v89) -> (* Ok *)
            let v90 : (char -> string) = _.ToString()
            let v91 : string = v90 v85
            method25(v91, v86, v87, v88, v89)
    let v341 : US6 =
        match v96 with
        | US6_1(v102) -> (* Error *)
            let v165 : US5 =
                if v5 then
                    let v103 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US5_1(v103)
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
                        while method11(v118, v120) do
                            let v122 : int32 = v120.l0
                            let v123 : char = v115.[int v122]
                            v119.[int v122] <- v123
                            let v124 : int32 = v122 + 1
                            v120.l0 <- v124
                            ()
                        let v125 : char list = v119 |> Array.toList
                        let v126 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v127 : (char -> (UH0 -> UH0)) = method12()
                        let v128 : (char list -> (UH0 -> UH0)) = v126 v127
                        let v129 : (UH0 -> UH0) = v128 v125
                        let v130 : UH0 = UH0_0
                        let v131 : UH0 = v129 v130
                        let struct (v136 : System.Text.StringBuilder, v137 : int32, v138 : int32) = method13(v131, v2, v3, v4)
                        US5_0(v105, v113, v136, v137, v138)
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
                        US5_1(v162)
            let v282 : US6 =
                match v165 with
                | US5_1(v279) -> (* Error *)
                    US6_1(v279)
                | US5_0(v166, v167, v168, v169, v170) -> (* Ok *)
                    let v171 : UH2 = UH2_0
                    let v172 : US15 = method26(v171, v167, v168, v169, v170)
                    let v193 : US6 =
                        match v172 with
                        | US15_1(v190) -> (* Error *)
                            US6_1(v190)
                        | US15_0(v173, v174, v175, v176, v177) -> (* Ok *)
                            let v178 : string list = []
                            let v179 : string list = method30(v173, v178)
                            let v180 : string seq = seq { for i = 0 to v179.Length - 1 do yield v179.[i] }
                            let v183 : (string -> (string seq -> string)) = String.concat
                            let v184 : string = ""
                            let v185 : (string seq -> string) = v183 v184
                            let v186 : string = v185 v180
                            US6_0(v186, v174, v175, v176, v177)
                    match v193 with
                    | US6_1(v274) -> (* Error *)
                        let v275 : string = "between / expected content"
                        US6_1(v275)
                    | US6_0(v194, v195, v196, v197, v198) -> (* Ok *)
                        let v199 : bool = "" = v195
                        let v262 : US5 =
                            if v199 then
                                let v200 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v196, v197, v198)}"
                                US5_1(v200)
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
                                    while method11(v215, v217) do
                                        let v219 : int32 = v217.l0
                                        let v220 : char = v212.[int v219]
                                        v216.[int v219] <- v220
                                        let v221 : int32 = v219 + 1
                                        v217.l0 <- v221
                                        ()
                                    let v222 : char list = v216 |> Array.toList
                                    let v223 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v224 : (char -> (UH0 -> UH0)) = method12()
                                    let v225 : (char list -> (UH0 -> UH0)) = v223 v224
                                    let v226 : (UH0 -> UH0) = v225 v222
                                    let v227 : UH0 = UH0_0
                                    let v228 : UH0 = v226 v227
                                    let struct (v233 : System.Text.StringBuilder, v234 : int32, v235 : int32) = method13(v228, v196, v197, v198)
                                    US5_0(v202, v210, v233, v234, v235)
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
                                    US5_1(v259)
                        match v262 with
                        | US5_1(v269) -> (* Error *)
                            let v270 : string = $"between / expected closing delimiter / e: %A{v269} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v167, v168, v169, v170)} / rest2: %A{struct (v195, v196, v197, v198)}"
                            US6_1(v270)
                        | US5_0(v263, v264, v265, v266, v267) -> (* Ok *)
                            US6_0(v194, v264, v265, v266, v267)
            match v282 with
            | US6_1(v288) -> (* Error *)
                let v289 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure34()
                let v290 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure35()
                let v291 : UH3 = UH3_0
                let v292 : UH3 = UH3_1(v290, v291)
                let v293 : UH3 = UH3_1(v289, v292)
                let v294 : US6 = method28(v1, v2, v3, v4, v293)
                let v305 : US6 =
                    match v294 with
                    | US6_1(v302) -> (* Error *)
                        US6_1(v302)
                    | US6_0(v295, v296, v297, v298, v299) -> (* Ok *)
                        let v300 : string = ""
                        US6_0(v300, v296, v297, v298, v299)
                let v316 : US15 =
                    match v305 with
                    | US6_1(v313) -> (* Error *)
                        US15_1(v313)
                    | US6_0(v306, v307, v308, v309, v310) -> (* Ok *)
                        let v311 : UH2 = UH2_0
                        method31(v311, v307, v308, v309, v310)
                match v316 with
                | US15_1(v334) -> (* Error *)
                    US6_1(v334)
                | US15_0(v317, v318, v319, v320, v321) -> (* Ok *)
                    let v322 : string list = []
                    let v323 : string list = method30(v317, v322)
                    let v324 : string seq = seq { for i = 0 to v323.Length - 1 do yield v323.[i] }
                    let v327 : (string -> (string seq -> string)) = String.concat
                    let v328 : string = ""
                    let v329 : (string seq -> string) = v327 v328
                    let v330 : string = v329 v324
                    US6_0(v330, v318, v319, v320, v321)
            | US6_0(v283, v284, v285, v286, v287) -> (* Ok *)
                v282
        | US6_0(v97, v98, v99, v100, v101) -> (* Ok *)
            v96
    match v341 with
    | US6_1(v342) -> (* Error *)
        let v343 : UH2 = UH2_0
        let v344 : UH2 = method29(v0, v343)
        US15_0(v344, v1, v2, v3, v4)
    | US6_0(v346, v347, v348, v349, v350) -> (* Ok *)
        let v351 : int32 = 0
        let v352 : int32 = method32(v347, v351)
        let v353 : bool = 0 = v352
        let v364 : US8 =
            if v353 then
                let v354 : string = "spaces1 / expected at least one space"
                US8_1(v354)
            else
                let v356 : (string -> int32) = String.length
                let v357 : int32 = v356 v347
                let v358 : (int32 -> int32) = int32
                let v359 : int32 = v358 v352
                let v360 : (int32 -> int32) = int32
                let v361 : int32 = v360 v357
                let v362 : string = v347.[int v359..int v361]
                US8_0(v362, v348, v349, v350)
        match v364 with
        | US8_1(v365) -> (* Error *)
            let v366 : UH2 = UH2_0
            let v367 : UH2 = UH2_1(v346, v366)
            let v368 : UH2 = method29(v0, v367)
            US15_0(v368, v347, v348, v349, v350)
        | US8_0(v370, v371, v372, v373) -> (* Ok *)
            let v374 : UH2 = UH2_1(v346, v0)
            method23(v374, v370, v371, v372, v373)
and method22 (v0 : string) : US14 =
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
    let v10 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v11 : System.Text.StringBuilder = v10 v6
    let v12 : UH2 = UH2_0
    let v13 : int32 = 1
    let v14 : int32 = 1
    let v15 : US15 = method23(v12, v7, v11, v13, v14)
    match v15 with
    | US15_1(v28) -> (* Error *)
        US14_1(v28)
    | US15_0(v16, v17, v18, v19, v20) -> (* Ok *)
        let v21 : string list = []
        let v22 : string list = method30(v16, v21)
        let v23 : (string list -> (string [])) = List.toArray
        let v24 : (string []) = v23 v22
        US14_0(v24)
and closure33 () (v0 : string) : Result<(string []), string> =
    let v1 : US14 = method22(v0)
    match v1 with
    | US14_1(v4) -> (* Error *)
        let v5 : Result<(string []), string> = Error v4 
        v5
    | US14_0(v2) -> (* Ok *)
        let v3 : Result<(string []), string> = Ok v2 
        v3
let v0 : unit = ()
let v1 : (unit -> unit) = closure0()
let v2 : unit = (fun () -> v1 (); v0) ()
let v16 : (unit -> unit) = closure4()
let current_process_kill () = v16 ()
let v17 : (string -> Async<struct (int32 * string)>) = closure14()
let execute_async x = v17 x
let v18 : (struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) -> Async<struct (int32 * string)>) = closure31()
let execute_with_options_async x = v18 x
let v19 : ((Heap0 -> Heap0) -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure32()
let execution_options x = v19 x
let v20 : (string -> Result<(string []), string>) = closure33()
let split_args x = v20 x
()
