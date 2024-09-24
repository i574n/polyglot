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
    let v92 : (string -> US1) = method4()
    let v93 : US1 option = v89 |> Option.map v92 
    let v104 : US1 = US1_1
    let v105 : US1 = v93 |> Option.defaultValue v104 
    let v112 : string =
        match v105 with
        | US1_1 -> (* None *)
            let v110 : string = ""
            v110
        | US1_0(v109) -> (* Some *)
            v109
    let _v1 = v112 
    #endif
    let v113 : string = _v1 
    v113
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
    let v50 : string = method5()
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
    let v159 : string = method5()
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
    let v220 : string = method5()
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
    let v281 : string = method5()
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
    let v359 : Mut0 = {l0 = 1L} : Mut0
    let v360 : (string -> unit) = closure2()
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
and closure6 () (v0 : int64) : US3 =
    US3_0(v0)
and method7 () : (int64 -> US3) =
    closure6()
and method8 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method9 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method6 (v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : int64 option) : string =
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : (int64 -> US3) = method7()
    let v8 : US3 option = v5 |> Option.map v7 
    let v19 : US3 = US3_1
    let v20 : US3 = v8 |> Option.defaultValue v19 
    let v60 : System.DateTime =
        match v20 with
        | US3_1 -> (* None *)
            let v56 : System.DateTime = System.DateTime.Now
            v56
        | US3_0(v24) -> (* Some *)
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
    let v61 : string = method8()
    let v64 : (string -> string) = v60.ToString
    let v65 : string = v64 v61
    let _v6 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : (int64 -> US3) = method7()
    let v69 : US3 option = v5 |> Option.map v68 
    let v80 : US3 = US3_1
    let v81 : US3 = v69 |> Option.defaultValue v80 
    let v121 : System.DateTime =
        match v81 with
        | US3_1 -> (* None *)
            let v117 : System.DateTime = System.DateTime.Now
            v117
        | US3_0(v85) -> (* Some *)
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
    let v122 : string = method8()
    let v125 : (string -> string) = v121.ToString
    let v126 : string = v125 v122
    let _v6 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v129 : string = $"near_sdk::env::block_timestamp()"
    let v130 : uint64 = Fable.Core.RustInterop.emitRustExpr () v129 
    let v131 : (int64 -> US3) = method7()
    let v132 : US3 option = v5 |> Option.map v131 
    let v143 : US3 = US3_1
    let v144 : US3 = v132 |> Option.defaultValue v143 
    let v153 : uint64 =
        match v144 with
        | US3_1 -> (* None *)
            v130
        | US3_0(v148) -> (* Some *)
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
    let v164 : (int64 -> US3) = method7()
    let v165 : US3 option = v5 |> Option.map v164 
    let v176 : US3 = US3_1
    let v177 : US3 = v165 |> Option.defaultValue v176 
    let v217 : System.DateTime =
        match v177 with
        | US3_1 -> (* None *)
            let v213 : System.DateTime = System.DateTime.Now
            v213
        | US3_0(v181) -> (* Some *)
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
    let v218 : string = method9()
    let v221 : (string -> string) = v217.ToString
    let v222 : string = v221 v218
    let _v6 = v222 
    #endif
#if FABLE_COMPILER_PYTHON
    let v225 : (int64 -> US3) = method7()
    let v226 : US3 option = v5 |> Option.map v225 
    let v237 : US3 = US3_1
    let v238 : US3 = v226 |> Option.defaultValue v237 
    let v278 : System.DateTime =
        match v238 with
        | US3_1 -> (* None *)
            let v274 : System.DateTime = System.DateTime.Now
            v274
        | US3_0(v242) -> (* Some *)
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
    let v279 : string = method9()
    let v282 : (string -> string) = v278.ToString
    let v283 : string = v282 v279
    let _v6 = v283 
    #endif
#else
    let v286 : (int64 -> US3) = method7()
    let v287 : US3 option = v5 |> Option.map v286 
    let v298 : US3 = US3_1
    let v299 : US3 = v287 |> Option.defaultValue v298 
    let v339 : System.DateTime =
        match v299 with
        | US3_1 -> (* None *)
            let v335 : System.DateTime = System.DateTime.Now
            v335
        | US3_0(v303) -> (* Some *)
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
    let v340 : string = method9()
    let v343 : (string -> string) = v339.ToString
    let v344 : string = v343 v340
    let _v6 = v344 
    #endif
    let v347 : string = _v6 
    v347
and method11 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method10 () : string =
    
    
    
    
    
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
    let v51 : string = method11()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[93m"
    let v55 : string = method11()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[93m"
    let v59 : string = method11()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and method13 () : string =
    let v0 : string = ""
    v0
and method12 () : string =
    let v0 : string = method13()
    let v1 : Mut3 = {l0 = v0} : Mut3
    let v2 : string = v1.l0
    v2
and method14 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "runtime.current_process_kill / exiting... 3"
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
and closure7 (v0 : Mut0) () : unit =
    let v1 : int64 = v0.l0
    let v2 : int64 = v1 + 1L
    v0.l0 <- v2
    ()
and closure9 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure8 () (v0 : string) : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure9(v0)
    let v3 : unit = (fun () -> v2 (); v1) ()
    ()
and method15 (v0 : string, v1 : Mut0, v2 : Mut1, v3 : Mut2, v4 : Mut3, v5 : Mut4, v6 : int64 option) : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure7(v1)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : (string -> unit) = closure8()
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
and closure5 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 3 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method6(v55, v56, v57, v58, v59, v60)
        let v74 : string = method10()
        let v75 : int64 = v55.l0
        let v76 : string = method12()
        let v77 : string = method14(v73, v74, v75, v76)
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        method15(v77, v93, v94, v95, v96, v97, v98)
and method16 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "runtime.current_process_kill / exiting... 2"
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
and closure10 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 3 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method6(v55, v56, v57, v58, v59, v60)
        let v74 : string = method10()
        let v75 : int64 = v55.l0
        let v76 : string = method12()
        let v77 : string = method16(v73, v74, v75, v76)
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        method15(v77, v93, v94, v95, v96, v97, v98)
and method17 (v0 : string, v1 : string, v2 : int64, v3 : string) : string =
    let v4 : string = "runtime.current_process_kill / exiting... 1"
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
and closure11 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : Mut4, v21 : int64 option) = TraceState.trace_state.Value
    let v34 : US0 = v20.l0
    let v35 : bool = v18.l0
    let v36 : bool = v35 = false
    let v39 : bool =
        if v36 then
            false
        else
            let v37 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v34
            let v38 : bool = 3 >= v37
            v38
    if v39 then
        let v40 : unit = ()
        let v41 : unit = (fun () -> v1 (); v40) ()
        let struct (v55 : Mut0, v56 : Mut1, v57 : Mut2, v58 : Mut3, v59 : Mut4, v60 : int64 option) = TraceState.trace_state.Value
        let v73 : string = method6(v55, v56, v57, v58, v59, v60)
        let v74 : string = method10()
        let v75 : int64 = v55.l0
        let v76 : string = method12()
        let v77 : string = method17(v73, v74, v75, v76)
        let v78 : unit = ()
        let v79 : unit = (fun () -> v1 (); v78) ()
        let struct (v93 : Mut0, v94 : Mut1, v95 : Mut2, v96 : Mut3, v97 : Mut4, v98 : int64 option) = TraceState.trace_state.Value
        method15(v77, v93, v94, v95, v96, v97, v98)
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
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure5()
    let v3 : unit = (fun () -> v2 (); v1) ()
    System.Threading.Thread.Sleep 300
    let v115 : unit = ()
    let v116 : (unit -> unit) = closure10()
    let v117 : unit = (fun () -> v116 (); v115) ()
    System.Console.Out.Flush ()
    System.Threading.Thread.Sleep 60
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure11()
    let v231 : unit = (fun () -> v230 (); v229) ()
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
#else
    let v1 : (unit -> unit) = closure4()
    let v2 : System.Threading.Thread = new System.Threading.Thread (v1)
    let v3 : (System.Threading.Thread -> unit) = _.Start()
    v3 v2
    let _v0 = () 
    #endif
    _v0 
    ()
and method20 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure15 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure14 () (v0 : char) : (UH0 -> UH0) =
    closure15(v0)
and method21 () : (char -> (UH0 -> UH0)) =
    closure14()
and method22 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        method22(v5, v19, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure13 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
            while method20(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method21()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method22(v33, v1, v2, v3)
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
and closure16 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
            while method20(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method21()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method22(v33, v1, v2, v3)
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
and method23 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US5 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US5 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US5_1(v13) -> (* Error *)
            method23(v0, v1, v6)
        | US5_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "choice / no parsers succeeded"
        US5_1(v3)
and method24 (v0 : char, v1 : int64) : bool =
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
            method24(v0, v17)
and method25 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
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
            let v28 : bool = method24(v19, v27)
            let v29 : bool = v28 = false
            if v29 then
                let v30 : (char -> string) = _.ToString()
                let v31 : string = v30 v19
                let v34 : int32 = v31.Length
                let v35 : (char []) = Array.zeroCreate<char> (v34)
                let v36 : Mut5 = {l0 = 0} : Mut5
                while method20(v34, v36) do
                    let v38 : int32 = v36.l0
                    let v39 : char = v31.[int v38]
                    v35.[int v38] <- v39
                    let v40 : int32 = v38 + 1
                    v36.l0 <- v40
                    ()
                let v41 : char list = v35 |> Array.toList
                let v42 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v43 : (char -> (UH0 -> UH0)) = method21()
                let v44 : (char list -> (UH0 -> UH0)) = v42 v43
                let v45 : (UH0 -> UH0) = v44 v41
                let v46 : UH0 = UH0_0
                let v47 : UH0 = v45 v46
                let struct (v52 : System.Text.StringBuilder, v53 : int32, v54 : int32) = method22(v47, v2, v3, v4)
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
        method25(v92, v84, v85, v86, v87)
and method26 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US5 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US5 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US5_1(v15) -> (* Error *)
            method26(v0, v1, v2, v3, v8)
        | US5_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US5_1(v5)
and method27 (v0 : char, v1 : int64) : bool =
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
            method27(v0, v21)
and method28 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
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
            let v31 : bool = method27(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method20(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method21()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method22(v50, v2, v3, v4)
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
        method28(v98, v90, v91, v92, v93)
and method29 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method29(v0, v6)
        else
            v1
and method30 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
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
            while method20(v20, v22) do
                let v24 : int32 = v22.l0
                let v25 : char = v17.[int v24]
                v21.[int v24] <- v25
                let v26 : int32 = v24 + 1
                v22.l0 <- v26
                ()
            let v27 : char list = v21 |> Array.toList
            let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v29 : (char -> (UH0 -> UH0)) = method21()
            let v30 : (char list -> (UH0 -> UH0)) = v28 v29
            let v31 : (UH0 -> UH0) = v30 v27
            let v32 : UH0 = UH0_0
            let v33 : UH0 = v31 v32
            let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method22(v33, v2, v3, v4)
            US5_0(v8, v15, v38, v39, v40)
    match v42 with
    | US5_1(v54) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v43, v44, v45, v46, v47) -> (* Ok *)
        let v48 : (char -> string) = _.ToString()
        let v49 : string = v48 v43
        let v52 : string = v0 + v49 
        method30(v52, v44, v45, v46, v47)
and method19 (v0 : string) : US4 =
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
    let v12 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure13()
    let v13 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure16()
    let v14 : UH1 = UH1_0
    let v15 : UH1 = UH1_1(v13, v14)
    let v16 : UH1 = UH1_1(v12, v15)
    let v17 : US5 = method23(v7, v11, v16)
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
                    let v46 : bool = method24(v37, v45)
                    let v47 : bool = v46 = false
                    if v47 then
                        let v48 : (char -> string) = _.ToString()
                        let v49 : string = v48 v37
                        let v52 : int32 = v49.Length
                        let v53 : (char []) = Array.zeroCreate<char> (v52)
                        let v54 : Mut5 = {l0 = 0} : Mut5
                        while method20(v52, v54) do
                            let v56 : int32 = v54.l0
                            let v57 : char = v49.[int v56]
                            v53.[int v56] <- v57
                            let v58 : int32 = v56 + 1
                            v54.l0 <- v58
                            ()
                        let v59 : char list = v53 |> Array.toList
                        let v60 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v61 : (char -> (UH0 -> UH0)) = method21()
                        let v62 : (char list -> (UH0 -> UH0)) = v60 v61
                        let v63 : (UH0 -> UH0) = v62 v59
                        let v64 : UH0 = UH0_0
                        let v65 : UH0 = v63 v64
                        let struct (v70 : System.Text.StringBuilder, v71 : int32, v72 : int32) = method22(v65, v20, v21, v22)
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
                    method25(v109, v104, v105, v106, v107)
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
                let v133 : US5 = method26(v126, v127, v128, v129, v132)
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
                    let v186 : bool = method27(v177, v185)
                    let v187 : bool = v186 = false
                    if v187 then
                        let v188 : (char -> string) = _.ToString()
                        let v189 : string = v188 v177
                        let v192 : int32 = v189.Length
                        let v193 : (char []) = Array.zeroCreate<char> (v192)
                        let v194 : Mut5 = {l0 = 0} : Mut5
                        while method20(v192, v194) do
                            let v196 : int32 = v194.l0
                            let v197 : char = v189.[int v196]
                            v193.[int v196] <- v197
                            let v198 : int32 = v196 + 1
                            v194.l0 <- v198
                            ()
                        let v199 : char list = v193 |> Array.toList
                        let v200 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v201 : (char -> (UH0 -> UH0)) = method21()
                        let v202 : (char list -> (UH0 -> UH0)) = v200 v201
                        let v203 : (UH0 -> UH0) = v202 v199
                        let v204 : UH0 = UH0_0
                        let v205 : UH0 = v203 v204
                        let v210 : int32 = 1
                        let v211 : int32 = 1
                        let struct (v212 : System.Text.StringBuilder, v213 : int32, v214 : int32) = method22(v205, v11, v210, v211)
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
                    method28(v254, v249, v250, v251, v252)
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
                    let v287 : int32 = method29(v282, v286)
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
                        while method20(v325, v327) do
                            let v329 : int32 = v327.l0
                            let v330 : char = v322.[int v329]
                            v326.[int v329] <- v330
                            let v331 : int32 = v329 + 1
                            v327.l0 <- v331
                            ()
                        let v332 : char list = v326 |> Array.toList
                        let v333 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v334 : (char -> (UH0 -> UH0)) = method21()
                        let v335 : (char list -> (UH0 -> UH0)) = v333 v334
                        let v336 : (UH0 -> UH0) = v335 v332
                        let v337 : UH0 = UH0_0
                        let v338 : UH0 = v336 v337
                        let struct (v343 : System.Text.StringBuilder, v344 : int32, v345 : int32) = method22(v338, v306, v307, v308)
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
                            while method20(v405, v407) do
                                let v409 : int32 = v407.l0
                                let v410 : char = v402.[int v409]
                                v406.[int v409] <- v410
                                let v411 : int32 = v409 + 1
                                v407.l0 <- v411
                                ()
                            let v412 : char list = v406 |> Array.toList
                            let v413 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v414 : (char -> (UH0 -> UH0)) = method21()
                            let v415 : (char list -> (UH0 -> UH0)) = v413 v414
                            let v416 : (UH0 -> UH0) = v415 v412
                            let v417 : UH0 = UH0_0
                            let v418 : UH0 = v416 v417
                            let struct (v423 : System.Text.StringBuilder, v424 : int32, v425 : int32) = method22(v418, v387, v388, v389)
                            US5_0(v393, v400, v423, v424, v425)
                    match v427 with
                    | US5_1(v428) -> (* Error *)
                        US6_1(v428)
                    | US5_0(v430, v431, v432, v433, v434) -> (* Ok *)
                        let v435 : (char -> string) = _.ToString()
                        let v436 : string = v435 v430
                        method30(v436, v431, v432, v433, v434)
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
and method31 () : string =
    
    
    
    
    
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
    let v51 : string = method11()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[94m"
    let v55 : string = method11()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[94m"
    let v59 : string = method11()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and closure18 (v0 : Mut3, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and method32 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : string =
    let v7 : string = method13()
    let v8 : Mut3 = {l0 = v7} : Mut3
    let v9 : string = "{ "
    let v10 : string = $"{v9}"
    let v13 : unit = ()
    let v14 : (unit -> unit) = closure18(v8, v10)
    let v15 : unit = (fun () -> v14 (); v13) ()
    let v18 : string = "options"
    let v19 : string = $"{v18}"
    let v22 : unit = ()
    let v23 : (unit -> unit) = closure18(v8, v19)
    let v24 : unit = (fun () -> v23 (); v22) ()
    let v27 : string = " = "
    let v28 : string = $"{v27}"
    let v31 : unit = ()
    let v32 : (unit -> unit) = closure18(v8, v28)
    let v33 : unit = (fun () -> v32 (); v31) ()
    let v36 : string = $"{v9}"
    let v39 : unit = ()
    let v40 : (unit -> unit) = closure18(v8, v36)
    let v41 : unit = (fun () -> v40 (); v39) ()
    let v44 : string = "command"
    let v45 : string = $"{v44}"
    let v48 : unit = ()
    let v49 : (unit -> unit) = closure18(v8, v45)
    let v50 : unit = (fun () -> v49 (); v48) ()
    let v53 : string = $"{v27}"
    let v56 : unit = ()
    let v57 : (unit -> unit) = closure18(v8, v53)
    let v58 : unit = (fun () -> v57 (); v56) ()
    let v61 : string = $"{v0}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure18(v8, v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v69 : string = "; "
    let v70 : string = $"{v69}"
    let v73 : unit = ()
    let v74 : (unit -> unit) = closure18(v8, v70)
    let v75 : unit = (fun () -> v74 (); v73) ()
    let v78 : string = "cancellation_token"
    let v79 : string = $"{v78}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure18(v8, v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v87 : string = $"{v27}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure18(v8, v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v95 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v96 : string = "format!(\"{:#?}\", $0)"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v96 
    let v98 : string = "fable_library_rust::String_::fromString($0)"
    let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98 
    let _v95 = v99 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v100 : string = "format!(\"{:#?}\", $0)"
    let v101 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v100 
    let v102 : string = "fable_library_rust::String_::fromString($0)"
    let v103 : string = Fable.Core.RustInterop.emitRustExpr v101 v102 
    let _v95 = v103 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v104 : string = "format!(\"{:#?}\", $0)"
    let v105 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v104 
    let v106 : string = "fable_library_rust::String_::fromString($0)"
    let v107 : string = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let _v95 = v107 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v108 : string = $"%A{v1}"
    let _v95 = v108 
    #endif
#if FABLE_COMPILER_PYTHON
    let v111 : string = $"%A{v1}"
    let _v95 = v111 
    #endif
#else
    let v114 : string = $"%A{v1}"
    let _v95 = v114 
    #endif
    let v117 : string = _v95 
    let v122 : string = $"{v117}"
    let v125 : unit = ()
    let v126 : (unit -> unit) = closure18(v8, v122)
    let v127 : unit = (fun () -> v126 (); v125) ()
    let v130 : string = $"{v69}"
    let v133 : unit = ()
    let v134 : (unit -> unit) = closure18(v8, v130)
    let v135 : unit = (fun () -> v134 (); v133) ()
    let v138 : string = "environment_variables"
    let v139 : string = $"{v138}"
    let v142 : unit = ()
    let v143 : (unit -> unit) = closure18(v8, v139)
    let v144 : unit = (fun () -> v143 (); v142) ()
    let v147 : string = $"{v27}"
    let v150 : unit = ()
    let v151 : (unit -> unit) = closure18(v8, v147)
    let v152 : unit = (fun () -> v151 (); v150) ()
    let v155 : string = $"%A{v2}"
    let v158 : string = $"{v155}"
    let v161 : unit = ()
    let v162 : (unit -> unit) = closure18(v8, v158)
    let v163 : unit = (fun () -> v162 (); v161) ()
    let v166 : string = $"{v69}"
    let v169 : unit = ()
    let v170 : (unit -> unit) = closure18(v8, v166)
    let v171 : unit = (fun () -> v170 (); v169) ()
    let v174 : string = "on_line"
    let v175 : string = $"{v174}"
    let v178 : unit = ()
    let v179 : (unit -> unit) = closure18(v8, v175)
    let v180 : unit = (fun () -> v179 (); v178) ()
    let v183 : string = $"{v27}"
    let v186 : unit = ()
    let v187 : (unit -> unit) = closure18(v8, v183)
    let v188 : unit = (fun () -> v187 (); v186) ()
    let v191 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v192 : string = "format!(\"{:#?}\", $0)"
    let v193 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v192 
    let v194 : string = "fable_library_rust::String_::fromString($0)"
    let v195 : string = Fable.Core.RustInterop.emitRustExpr v193 v194 
    let _v191 = v195 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v196 : string = "format!(\"{:#?}\", $0)"
    let v197 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v196 
    let v198 : string = "fable_library_rust::String_::fromString($0)"
    let v199 : string = Fable.Core.RustInterop.emitRustExpr v197 v198 
    let _v191 = v199 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v200 : string = "format!(\"{:#?}\", $0)"
    let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v200 
    let v202 : string = "fable_library_rust::String_::fromString($0)"
    let v203 : string = Fable.Core.RustInterop.emitRustExpr v201 v202 
    let _v191 = v203 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v204 : string = $"%A{v3}"
    let _v191 = v204 
    #endif
#if FABLE_COMPILER_PYTHON
    let v207 : string = $"%A{v3}"
    let _v191 = v207 
    #endif
#else
    let v210 : string = $"%A{v3}"
    let _v191 = v210 
    #endif
    let v213 : string = _v191 
    let v218 : string = $"{v213}"
    let v221 : unit = ()
    let v222 : (unit -> unit) = closure18(v8, v218)
    let v223 : unit = (fun () -> v222 (); v221) ()
    let v226 : string = $"{v69}"
    let v229 : unit = ()
    let v230 : (unit -> unit) = closure18(v8, v226)
    let v231 : unit = (fun () -> v230 (); v229) ()
    let v234 : string = "stdin"
    let v235 : string = $"{v234}"
    let v238 : unit = ()
    let v239 : (unit -> unit) = closure18(v8, v235)
    let v240 : unit = (fun () -> v239 (); v238) ()
    let v243 : string = $"{v27}"
    let v246 : unit = ()
    let v247 : (unit -> unit) = closure18(v8, v243)
    let v248 : unit = (fun () -> v247 (); v246) ()
    let v251 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v252 : string = "format!(\"{:#?}\", $0)"
    let v253 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v252 
    let v254 : string = "fable_library_rust::String_::fromString($0)"
    let v255 : string = Fable.Core.RustInterop.emitRustExpr v253 v254 
    let _v251 = v255 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v256 : string = "format!(\"{:#?}\", $0)"
    let v257 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v256 
    let v258 : string = "fable_library_rust::String_::fromString($0)"
    let v259 : string = Fable.Core.RustInterop.emitRustExpr v257 v258 
    let _v251 = v259 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v260 : string = "format!(\"{:#?}\", $0)"
    let v261 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v260 
    let v262 : string = "fable_library_rust::String_::fromString($0)"
    let v263 : string = Fable.Core.RustInterop.emitRustExpr v261 v262 
    let _v251 = v263 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v264 : string = $"%A{v4}"
    let _v251 = v264 
    #endif
#if FABLE_COMPILER_PYTHON
    let v267 : string = $"%A{v4}"
    let _v251 = v267 
    #endif
#else
    let v270 : string = $"%A{v4}"
    let _v251 = v270 
    #endif
    let v273 : string = _v251 
    let v278 : string = $"{v273}"
    let v281 : unit = ()
    let v282 : (unit -> unit) = closure18(v8, v278)
    let v283 : unit = (fun () -> v282 (); v281) ()
    let v286 : string = $"{v69}"
    let v289 : unit = ()
    let v290 : (unit -> unit) = closure18(v8, v286)
    let v291 : unit = (fun () -> v290 (); v289) ()
    let v294 : string = "trace"
    let v295 : string = $"{v294}"
    let v298 : unit = ()
    let v299 : (unit -> unit) = closure18(v8, v295)
    let v300 : unit = (fun () -> v299 (); v298) ()
    let v303 : string = $"{v27}"
    let v306 : unit = ()
    let v307 : (unit -> unit) = closure18(v8, v303)
    let v308 : unit = (fun () -> v307 (); v306) ()
    let v313 : string =
        if v5 then
            let v311 : string = "true"
            v311
        else
            let v312 : string = "false"
            v312
    let v314 : string = $"{v313}"
    let v317 : unit = ()
    let v318 : (unit -> unit) = closure18(v8, v314)
    let v319 : unit = (fun () -> v318 (); v317) ()
    let v322 : string = $"{v69}"
    let v325 : unit = ()
    let v326 : (unit -> unit) = closure18(v8, v322)
    let v327 : unit = (fun () -> v326 (); v325) ()
    let v330 : string = "working_directory"
    let v331 : string = $"{v330}"
    let v334 : unit = ()
    let v335 : (unit -> unit) = closure18(v8, v331)
    let v336 : unit = (fun () -> v335 (); v334) ()
    let v339 : string = $"{v27}"
    let v342 : unit = ()
    let v343 : (unit -> unit) = closure18(v8, v339)
    let v344 : unit = (fun () -> v343 (); v342) ()
    let v347 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v348 : string = "format!(\"{:#?}\", $0)"
    let v349 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v348 
    let v350 : string = "fable_library_rust::String_::fromString($0)"
    let v351 : string = Fable.Core.RustInterop.emitRustExpr v349 v350 
    let _v347 = v351 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v352 : string = "format!(\"{:#?}\", $0)"
    let v353 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v352 
    let v354 : string = "fable_library_rust::String_::fromString($0)"
    let v355 : string = Fable.Core.RustInterop.emitRustExpr v353 v354 
    let _v347 = v355 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v356 : string = "format!(\"{:#?}\", $0)"
    let v357 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v356 
    let v358 : string = "fable_library_rust::String_::fromString($0)"
    let v359 : string = Fable.Core.RustInterop.emitRustExpr v357 v358 
    let _v347 = v359 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v360 : string = $"%A{v6}"
    let _v347 = v360 
    #endif
#if FABLE_COMPILER_PYTHON
    let v363 : string = $"%A{v6}"
    let _v347 = v363 
    #endif
#else
    let v366 : string = $"%A{v6}"
    let _v347 = v366 
    #endif
    let v369 : string = _v347 
    let v374 : string = $"{v369}"
    let v377 : unit = ()
    let v378 : (unit -> unit) = closure18(v8, v374)
    let v379 : unit = (fun () -> v378 (); v377) ()
    let v382 : string = " }"
    let v383 : string = $"{v382}"
    let v386 : unit = ()
    let v387 : (unit -> unit) = closure18(v8, v383)
    let v388 : unit = (fun () -> v387 (); v386) ()
    let v391 : string = $"{v382}"
    let v394 : unit = ()
    let v395 : (unit -> unit) = closure18(v8, v391)
    let v396 : unit = (fun () -> v395 (); v394) ()
    let v399 : string = v8.l0
    v399
and method33 (v0 : string, v1 : string, v2 : string, v3 : int64, v4 : string) : string =
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
and closure17 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure0()
    let v9 : unit = (fun () -> v8 (); v7) ()
    let struct (v23 : Mut0, v24 : Mut1, v25 : Mut2, v26 : Mut3, v27 : Mut4, v28 : int64 option) = TraceState.trace_state.Value
    let v41 : US0 = v27.l0
    let v42 : bool = v25.l0
    let v43 : bool = v42 = false
    let v46 : bool =
        if v43 then
            false
        else
            let v44 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v41
            let v45 : bool = 1 >= v44
            v45
    if v46 then
        let v47 : unit = ()
        let v48 : unit = (fun () -> v8 (); v47) ()
        let struct (v62 : Mut0, v63 : Mut1, v64 : Mut2, v65 : Mut3, v66 : Mut4, v67 : int64 option) = TraceState.trace_state.Value
        let v80 : string = method6(v62, v63, v64, v65, v66, v67)
        let v81 : string = method31()
        let v82 : string = $"runtime.execute_with_options_async"
        let v83 : bool = v82 = ""
        let v88 : string =
            if v83 then
                let v84 : string = ""
                v84
            else
                let v85 : int64 = v62.l0
                let v86 : string = method32(v0, v1, v2, v3, v4, v5, v6)
                method33(v80, v81, v82, v85, v86)
        let v89 : unit = ()
        let v90 : unit = (fun () -> v8 (); v89) ()
        let struct (v104 : Mut0, v105 : Mut1, v106 : Mut2, v107 : Mut3, v108 : Mut4, v109 : int64 option) = TraceState.trace_state.Value
        method15(v88, v104, v105, v106, v107, v108, v109)
and closure20 () (v0 : (struct (int32 * string * bool) -> Async<unit>)) : US12 =
    US12_0(v0)
and method34 () : ((struct (int32 * string * bool) -> Async<unit>) -> US12) =
    closure20()
and method35 () : string =
    
    
    
    
    
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
    let v51 : string = method11()
    let v52 : string = v50 + v5 
    let v53 : string = v52 + v51 
    let _v19 = v53 
    #endif
#if FABLE_COMPILER_PYTHON
    let v54 : string = "\u001b[90m"
    let v55 : string = method11()
    let v56 : string = v54 + v5 
    let v57 : string = v56 + v55 
    let _v19 = v57 
    #endif
#else
    let v58 : string = "\u001b[90m"
    let v59 : string = method11()
    let v60 : string = v58 + v5 
    let v61 : string = v60 + v59 
    let _v19 = v61 
    #endif
    let v62 : string = _v19 
    v62
and closure21 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 0 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method35()
        let v76 : bool = v0 = ""
        let v81 : string =
            if v76 then
                let v77 : string = ""
                v77
            else
                let v78 : int64 = v56.l0
                let v79 : string = method12()
                method33(v74, v75, v0, v78, v79)
        let v82 : unit = ()
        let v83 : unit = (fun () -> v2 (); v82) ()
        let struct (v97 : Mut0, v98 : Mut1, v99 : Mut2, v100 : Mut3, v101 : Mut4, v102 : int64 option) = TraceState.trace_state.Value
        method15(v81, v97, v98, v99, v100, v101, v102)
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
#else
    let v26 : Async<unit> option = None
    let mutable _v26 = v26 
    async {
    let v27 : string = v9.Data
    let v28 : string = null |> unbox<string>
    let v31 : bool = v27 = v28
    let v32 : bool = v31 <> true
    if v32 then
        let v33 : ((struct (int32 * string * bool) -> Async<unit>) -> US12) = method34()
        let v34 : US12 option = v3 |> Option.map v33 
        let v45 : US12 = US12_1
        let v46 : US12 = v34 |> Option.defaultValue v45 
        match v46 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v50) -> (* Some *)
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
            let v171 : unit = ()
            let v172 : (unit -> unit) = closure9(v53)
            let v173 : unit = (fun () -> v172 (); v171) ()
            ()
        let v175 : string = ""
        let v176 : string = $"{v175}{v27}{v175}"
        let v177 : (string -> unit) = v8.Push
        v177 v176
    ()
    }
    |> fun x -> _v26 <- Some x
    let v178 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v178 
    #endif
    let v179 : Async<unit> = _v10 
    let v184 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v184 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v184 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v184 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v184 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v184 = () 
    #endif
#else
    let v185 : (Async<unit> -> unit) = Async.StartImmediate
    v185 v179
    let _v184 = () 
    #endif
    _v184 
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
#else
    let v26 : Async<unit> option = None
    let mutable _v26 = v26 
    async {
    let v27 : string = v9.Data
    let v28 : string = null |> unbox<string>
    let v31 : bool = v27 = v28
    let v32 : bool = v31 <> true
    if v32 then
        let v33 : ((struct (int32 * string * bool) -> Async<unit>) -> US12) = method34()
        let v34 : US12 option = v3 |> Option.map v33 
        let v45 : US12 = US12_1
        let v46 : US12 = v34 |> Option.defaultValue v45 
        match v46 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v50) -> (* Some *)
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
            let v171 : unit = ()
            let v172 : (unit -> unit) = closure9(v53)
            let v173 : unit = (fun () -> v172 (); v171) ()
            ()
        let v175 : string = "\u001b[7;4m"
        let v176 : string = "\u001b[0m"
        let v177 : string = $"{v175}{v27}{v176}"
        let v178 : (string -> unit) = v8.Push
        v178 v177
    ()
    }
    |> fun x -> _v26 <- Some x
    let v179 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v179 
    #endif
    let v180 : Async<unit> = _v10 
    let v185 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v185 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v185 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v185 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v185 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v185 = () 
    #endif
#else
    let v186 : (Async<unit> -> unit) = Async.StartImmediate
    v186 v180
    let _v185 = () 
    #endif
    _v185 
    ()
and closure23 () (v0 : System.Threading.CancellationToken) : US13 =
    US13_0(v0)
and method36 () : (System.Threading.CancellationToken -> US13) =
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
and method37 (v0 : System.Threading.Tasks.TaskCanceledException) : string =
    let v1 : string = method13()
    let v2 : Mut3 = {l0 = v1} : Mut3
    let v3 : string = "{ "
    let v4 : string = $"{v3}"
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure18(v2, v4)
    let v9 : unit = (fun () -> v8 (); v7) ()
    let v12 : string = "ex"
    let v13 : string = $"{v12}"
    let v16 : unit = ()
    let v17 : (unit -> unit) = closure18(v2, v13)
    let v18 : unit = (fun () -> v17 (); v16) ()
    let v21 : string = " = "
    let v22 : string = $"{v21}"
    let v25 : unit = ()
    let v26 : (unit -> unit) = closure18(v2, v22)
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
    let v61 : (unit -> unit) = closure18(v2, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = " }"
    let v66 : string = $"{v65}"
    let v69 : unit = ()
    let v70 : (unit -> unit) = closure18(v2, v66)
    let v71 : unit = (fun () -> v70 (); v69) ()
    let v74 : string = v2.l0
    v74
and closure25 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : Mut4, v22 : int64 option) = TraceState.trace_state.Value
    let v35 : US0 = v21.l0
    let v36 : bool = v19.l0
    let v37 : bool = v36 = false
    let v40 : bool =
        if v37 then
            false
        else
            let v38 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v35
            let v39 : bool = 3 >= v38
            v39
    if v40 then
        let v41 : unit = ()
        let v42 : unit = (fun () -> v2 (); v41) ()
        let struct (v56 : Mut0, v57 : Mut1, v58 : Mut2, v59 : Mut3, v60 : Mut4, v61 : int64 option) = TraceState.trace_state.Value
        let v74 : string = method6(v56, v57, v58, v59, v60, v61)
        let v75 : string = method10()
        let v76 : string = $"runtime.execute_with_options_async / WaitForExitAsync"
        let v77 : bool = v76 = ""
        let v82 : string =
            if v77 then
                let v78 : string = ""
                v78
            else
                let v79 : int64 = v56.l0
                let v80 : string = method37(v0)
                method33(v74, v75, v76, v79, v80)
        let v83 : unit = ()
        let v84 : unit = (fun () -> v2 (); v83) ()
        let struct (v98 : Mut0, v99 : Mut1, v100 : Mut2, v101 : Mut3, v102 : Mut4, v103 : int64 option) = TraceState.trace_state.Value
        method15(v82, v98, v99, v100, v101, v102, v103)
and method38 (v0 : int32, v1 : int32) : string =
    let v2 : string = method13()
    let v3 : Mut3 = {l0 = v2} : Mut3
    let v4 : string = "{ "
    let v5 : string = $"{v4}"
    let v8 : unit = ()
    let v9 : (unit -> unit) = closure18(v3, v5)
    let v10 : unit = (fun () -> v9 (); v8) ()
    let v13 : string = "exit_code"
    let v14 : string = $"{v13}"
    let v17 : unit = ()
    let v18 : (unit -> unit) = closure18(v3, v14)
    let v19 : unit = (fun () -> v18 (); v17) ()
    let v22 : string = " = "
    let v23 : string = $"{v22}"
    let v26 : unit = ()
    let v27 : (unit -> unit) = closure18(v3, v23)
    let v28 : unit = (fun () -> v27 (); v26) ()
    let v31 : string = $"{v0}"
    let v34 : unit = ()
    let v35 : (unit -> unit) = closure18(v3, v31)
    let v36 : unit = (fun () -> v35 (); v34) ()
    let v39 : string = "; "
    let v40 : string = $"{v39}"
    let v43 : unit = ()
    let v44 : (unit -> unit) = closure18(v3, v40)
    let v45 : unit = (fun () -> v44 (); v43) ()
    let v48 : string = "output_length"
    let v49 : string = $"{v48}"
    let v52 : unit = ()
    let v53 : (unit -> unit) = closure18(v3, v49)
    let v54 : unit = (fun () -> v53 (); v52) ()
    let v57 : string = $"{v22}"
    let v60 : unit = ()
    let v61 : (unit -> unit) = closure18(v3, v57)
    let v62 : unit = (fun () -> v61 (); v60) ()
    let v65 : string = $"{v1}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure18(v3, v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v73 : string = " }"
    let v74 : string = $"{v73}"
    let v77 : unit = ()
    let v78 : (unit -> unit) = closure18(v3, v74)
    let v79 : unit = (fun () -> v78 (); v77) ()
    let v82 : string = v3.l0
    v82
and closure26 (v0 : int32, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v18 : Mut0, v19 : Mut1, v20 : Mut2, v21 : Mut3, v22 : Mut4, v23 : int64 option) = TraceState.trace_state.Value
    let v36 : US0 = v22.l0
    let v37 : bool = v20.l0
    let v38 : bool = v37 = false
    let v41 : bool =
        if v38 then
            false
        else
            let v39 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v36
            let v40 : bool = 1 >= v39
            v40
    if v41 then
        let v42 : unit = ()
        let v43 : unit = (fun () -> v3 (); v42) ()
        let struct (v57 : Mut0, v58 : Mut1, v59 : Mut2, v60 : Mut3, v61 : Mut4, v62 : int64 option) = TraceState.trace_state.Value
        let v75 : string = method6(v57, v58, v59, v60, v61, v62)
        let v76 : string = method31()
        let v77 : string = $"runtime.execute_with_options_async"
        let v78 : bool = v77 = ""
        let v84 : string =
            if v78 then
                let v79 : string = ""
                v79
            else
                let v80 : int64 = v57.l0
                let v81 : int32 = v1.Length
                let v82 : string = method38(v0, v81)
                method33(v75, v76, v77, v80, v82)
        let v85 : unit = ()
        let v86 : unit = (fun () -> v3 (); v85) ()
        let struct (v100 : Mut0, v101 : Mut1, v102 : Mut2, v103 : Mut3, v104 : Mut4, v105 : int64 option) = TraceState.trace_state.Value
        method15(v84, v100, v101, v102, v103, v104, v105)
and method18 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
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
    let v40 : US4 = method19(v0)
    let struct (v49 : string, v50 : US1) =
        match v40 with
        | US4_1(v43) -> (* Error *)
            let v44 : string = $"resultm.get / Result value was Error: {v43}"
            failwith<struct (string * US1)> v44
        | US4_0(v41, v42) -> (* Ok *)
            struct (v41, v42)
    let v51 : (string -> US1) = method4()
    let v52 : US1 option = v6 |> Option.map v51 
    let v63 : US1 = US1_1
    let v64 : US1 = v52 |> Option.defaultValue v63 
    let v71 : string =
        match v64 with
        | US1_1 -> (* None *)
            let v69 : string = ""
            v69
        | US1_0(v68) -> (* Some *)
            v68
    let v72 : unit = ()
    let v73 : (unit -> unit) = closure17(v0, v1, v2, v3, v4, v5, v6)
    let v74 : unit = (fun () -> v73 (); v72) ()
    let v190 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v194 : string =
        match v50 with
        | US1_1 -> (* None *)
            let v192 : string = ""
            v192
        | US1_0(v191) -> (* Some *)
            v191
    let start_info = System.Diagnostics.ProcessStartInfo (
      Arguments = v194,
      StandardOutputEncoding = v190,
      WorkingDirectory = v71,
      FileName = v49,
      CreateNoWindow = true,
      RedirectStandardError = true,
      RedirectStandardOutput = true,
      UseShellExecute = false
    )
    let v195 : System.Diagnostics.ProcessStartInfo = start_info
    let v196 : int32 = v2.Length
    let v197 : Mut5 = {l0 = 0} : Mut5
    while method20(v196, v197) do
        let v199 : int32 = v197.l0
        let struct (v200 : string, v201 : string) = v2.[int v199]
        v195.EnvironmentVariables.[v200] <- v201 
        let v202 : int32 = v199 + 1
        v197.l0 <- v202
        ()
    let v203 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v195)
    use v203 = v203 
    let v204 : System.Diagnostics.Process = v203 
    let v205 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v206 : System.Collections.Concurrent.ConcurrentStack<string> = v205 ()
    let v207 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v204, v206)
    v204.OutputDataReceived.Add v207 
    let v208 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure22(v0, v1, v2, v3, v4, v5, v6, v204, v206)
    v204.ErrorDataReceived.Add v208 
    let v209 : (unit -> bool) = v204.Start
    let v210 : bool = v209 ()
    let v211 : bool = v210 = false
    if v211 then
        let v212 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v212
    let v213 : (unit -> unit) = v204.BeginErrorReadLine
    v213 ()
    let v214 : (unit -> unit) = v204.BeginOutputReadLine
    v214 ()
    let v215 : (System.Threading.CancellationToken -> US13) = method36()
    let v216 : US13 option = v1 |> Option.map v215 
    let v227 : US13 = US13_1
    let v228 : US13 = v216 |> Option.defaultValue v227 
    let v235 : System.Threading.CancellationToken =
        match v228 with
        | US13_1 -> (* None *)
            let v233 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v233
        | US13_0(v232) -> (* Some *)
            v232
    let v236 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v237 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v236 = v237 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v240 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v236 = v240 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v243 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v236 = v243 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v246 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v236 = v246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v249 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v236 = v249 
    #endif
#else
    let v252 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v253 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v252 = v253 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v256 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v252 = v256 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v259 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v252 = v259 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v262 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v252 = v262 
    #endif
#if FABLE_COMPILER_PYTHON
    let v265 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v252 = v265 
    #endif
#else
    let v268 : Async<System.Threading.CancellationToken> option = None
    let mutable _v268 = v268 
    async {
    let v269 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v269 = v269 
    let v270 : System.Threading.CancellationToken = v269 
    let v271 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v272 : (System.Threading.CancellationToken []) = [|v270; v271; v235|]
    let v273 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v274 : System.Threading.CancellationTokenSource = v273 v272
    let v275 : System.Threading.CancellationToken = v274.Token
    return v275 
    }
    |> fun x -> _v268 <- Some x
    let v276 : Async<System.Threading.CancellationToken> = match _v268 with Some x -> x | None -> failwith "async.new_async_unit / _v268=None"
    let _v252 = v276 
    #endif
    let v277 : Async<System.Threading.CancellationToken> = _v252 
    let _v236 = v277 
    #endif
    let v282 : Async<System.Threading.CancellationToken> = _v236 
    let! v282 = v282 
    let v287 : System.Threading.CancellationToken = v282 
    let v288 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v287.Register
    let v289 : (unit -> unit) = closure24(v204)
    let v290 : System.Threading.CancellationTokenRegistration = v288 v289
    use v290 = v290 
    let v291 : System.Threading.CancellationTokenRegistration = v290 
    let v292 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v293 : Async<int32> = null |> unbox<Async<int32>>
    let _v292 = v293 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v296 : Async<int32> = null |> unbox<Async<int32>>
    let _v292 = v296 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v299 : Async<int32> = null |> unbox<Async<int32>>
    let _v292 = v299 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v302 : Async<int32> = null |> unbox<Async<int32>>
    let _v292 = v302 
    #endif
#if FABLE_COMPILER_PYTHON
    let v305 : Async<int32> = null |> unbox<Async<int32>>
    let _v292 = v305 
    #endif
#else
    let v308 : Async<int32> option = None
    let mutable _v308 = v308 
    async {
    try
    let v309 : System.Threading.Tasks.Task = v204.WaitForExitAsync v287 
    let v310 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v311 : Async<unit> = null |> unbox<Async<unit>>
    let _v310 = v311 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v314 : Async<unit> = null |> unbox<Async<unit>>
    let _v310 = v314 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v317 : Async<unit> = null |> unbox<Async<unit>>
    let _v310 = v317 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v320 : Async<unit> = null |> unbox<Async<unit>>
    let _v310 = v320 
    #endif
#if FABLE_COMPILER_PYTHON
    let v323 : Async<unit> = null |> unbox<Async<unit>>
    let _v310 = v323 
    #endif
#else
    let v326 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v327 : Async<unit> = v326 v309
    let _v310 = v327 
    #endif
    let v328 : Async<unit> = _v310 
    do! v328 
    let v333 : int32 = v204.ExitCode
    return v333 
    with ex ->
    let v334 : exn = ex
    let v335 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v336 : string = $"%A{v334}"
    let _v335 = v336 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v339 : string = $"%A{v334}"
    let _v335 = v339 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v342 : string = $"%A{v334}"
    let _v335 = v342 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v345 : string = $"%A{v334}"
    let _v335 = v345 
    #endif
#if FABLE_COMPILER_PYTHON
    let v348 : string = $"%A{v334}"
    let _v335 = v348 
    #endif
#else
    let v351 : string = $"{v334.GetType ()}: {v334.Message}"
    let _v335 = v351 
    #endif
    let v352 : string = _v335 
    let v357 : (string -> unit) = v206.Push
    v357 v352
    let v358 : System.Threading.Tasks.TaskCanceledException = v334 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v361 : unit = ()
    let v362 : (unit -> unit) = closure25(v358)
    let v363 : unit = (fun () -> v362 (); v361) ()
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v308 <- Some x
    let v479 : Async<int32> = match _v308 with Some x -> x | None -> failwith "async.new_async_unit / _v308=None"
    let _v292 = v479 
    #endif
    let v480 : Async<int32> = _v292 
    let! v480 = v480 
    let v485 : int32 = v480 
    let v486 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v487 : string seq = v486 v206
    let v490 : (string -> (string seq -> string)) = String.concat
    let v491 : string = "\n"
    let v492 : (string seq -> string) = v490 v491
    let v493 : string = v492 v487
    let v496 : unit = ()
    let v497 : (unit -> unit) = closure26(v485, v493)
    let v498 : unit = (fun () -> v497 (); v496) ()
    return struct (v485, v493) 
    }
    |> fun x -> _v39 <- Some x
    let v615 : Async<struct (int32 * string)> = match _v39 with Some x -> x | None -> failwith "async.new_async_unit / _v39=None"
    let _v23 = v615 
    #endif
    let v616 : Async<struct (int32 * string)> = _v23 
    let _v7 = v616 
    #endif
    let v621 : Async<struct (int32 * string)> = _v7 
    v621
and closure12 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method18(v0, v1, v2, v3, v4, v6, v5)
and closure27 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method18(v0, v1, v2, v3, v4, v5, v6)
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
and method41 (v0 : char, v1 : int64) : bool =
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
            method41(v0, v25)
and method42 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
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
            let v34 : bool = method41(v25, v33)
            let v35 : bool = v34 = false
            if v35 then
                let v36 : (char -> string) = _.ToString()
                let v37 : string = v36 v25
                let v40 : int32 = v37.Length
                let v41 : (char []) = Array.zeroCreate<char> (v40)
                let v42 : Mut5 = {l0 = 0} : Mut5
                while method20(v40, v42) do
                    let v44 : int32 = v42.l0
                    let v45 : char = v37.[int v44]
                    v41.[int v44] <- v45
                    let v46 : int32 = v44 + 1
                    v42.l0 <- v46
                    ()
                let v47 : char list = v41 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method21()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v47
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v58 : System.Text.StringBuilder, v59 : int32, v60 : int32) = method22(v53, v2, v3, v4)
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
        method42(v92, v84, v85, v86, v87)
and method44 (v0 : char, v1 : int64) : bool =
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
            method44(v0, v21)
and closure30 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
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
                while method20(v20, v22) do
                    let v24 : int32 = v22.l0
                    let v25 : char = v17.[int v24]
                    v21.[int v24] <- v25
                    let v26 : int32 = v24 + 1
                    v22.l0 <- v26
                    ()
                let v27 : char list = v21 |> Array.toList
                let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v29 : (char -> (UH0 -> UH0)) = method21()
                let v30 : (char list -> (UH0 -> UH0)) = v28 v29
                let v31 : (UH0 -> UH0) = v30 v27
                let v32 : UH0 = UH0_0
                let v33 : UH0 = v31 v32
                let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method22(v33, v1, v2, v3)
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
                while method20(v88, v90) do
                    let v92 : int32 = v90.l0
                    let v93 : char = v85.[int v92]
                    v89.[int v92] <- v93
                    let v94 : int32 = v92 + 1
                    v90.l0 <- v94
                    ()
                let v95 : char list = v89 |> Array.toList
                let v96 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v97 : (char -> (UH0 -> UH0)) = method21()
                let v98 : (char list -> (UH0 -> UH0)) = v96 v97
                let v99 : (UH0 -> UH0) = v98 v95
                let v100 : UH0 = UH0_0
                let v101 : UH0 = v99 v100
                let struct (v106 : System.Text.StringBuilder, v107 : int32, v108 : int32) = method22(v101, v70, v71, v72)
                US5_0(v76, v83, v106, v107, v108)
    match v114 with
    | US5_1(v122) -> (* Error *)
        US6_1(v122)
    | US5_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v120 : string = $"{'\\'}{v115}"
        US6_0(v120, v116, v117, v118, v119)
and closure31 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
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
                while method20(v20, v22) do
                    let v24 : int32 = v22.l0
                    let v25 : char = v17.[int v24]
                    v21.[int v24] <- v25
                    let v26 : int32 = v24 + 1
                    v22.l0 <- v26
                    ()
                let v27 : char list = v21 |> Array.toList
                let v28 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v29 : (char -> (UH0 -> UH0)) = method21()
                let v30 : (char list -> (UH0 -> UH0)) = v28 v29
                let v31 : (UH0 -> UH0) = v30 v27
                let v32 : UH0 = UH0_0
                let v33 : UH0 = v31 v32
                let struct (v38 : System.Text.StringBuilder, v39 : int32, v40 : int32) = method22(v33, v1, v2, v3)
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
                while method20(v88, v90) do
                    let v92 : int32 = v90.l0
                    let v93 : char = v85.[int v92]
                    v89.[int v92] <- v93
                    let v94 : int32 = v92 + 1
                    v90.l0 <- v94
                    ()
                let v95 : char list = v89 |> Array.toList
                let v96 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v97 : (char -> (UH0 -> UH0)) = method21()
                let v98 : (char list -> (UH0 -> UH0)) = v96 v97
                let v99 : (UH0 -> UH0) = v98 v95
                let v100 : UH0 = UH0_0
                let v101 : UH0 = v99 v100
                let struct (v106 : System.Text.StringBuilder, v107 : int32, v108 : int32) = method22(v101, v70, v71, v72)
                US5_0(v76, v83, v106, v107, v108)
    match v114 with
    | US5_1(v122) -> (* Error *)
        US6_1(v122)
    | US5_0(v115, v116, v117, v118, v119) -> (* Ok *)
        let v120 : string = $"{'`'}{v115}"
        US6_0(v120, v116, v117, v118, v119)
and method45 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH3) : US6 =
    match v4 with
    | UH3_1(v7, v8) -> (* Cons *)
        let v9 : US6 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US6_1(v15) -> (* Error *)
            method45(v0, v1, v2, v3, v8)
        | US6_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH3_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US6_1(v5)
and method46 (v0 : UH2, v1 : UH2) : UH2 =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : UH2 = UH2_1(v2, v1)
        method46(v3, v4)
    | UH2_0 -> (* Nil *)
        v1
and method43 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
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
            let v31 : bool = method44(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method20(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method21()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method22(v50, v2, v3, v4)
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
            let v97 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure30()
            let v98 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure31()
            let v99 : UH3 = UH3_0
            let v100 : UH3 = UH3_1(v98, v99)
            let v101 : UH3 = UH3_1(v97, v100)
            method45(v1, v2, v3, v4, v101)
        | US6_0(v91, v92, v93, v94, v95) -> (* Ok *)
            v90
    match v104 with
    | US6_1(v112) -> (* Error *)
        let v113 : UH2 = UH2_0
        let v114 : UH2 = method46(v0, v113)
        US15_0(v114, v1, v2, v3, v4)
    | US6_0(v105, v106, v107, v108, v109) -> (* Ok *)
        let v110 : UH2 = UH2_1(v105, v0)
        method43(v110, v106, v107, v108, v109)
and method47 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method47(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH2_0 -> (* Nil *)
        v1
and method48 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
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
            let v31 : bool = method44(v22, v30)
            let v32 : bool = v31 = false
            if v32 then
                let v33 : (char -> string) = _.ToString()
                let v34 : string = v33 v22
                let v37 : int32 = v34.Length
                let v38 : (char []) = Array.zeroCreate<char> (v37)
                let v39 : Mut5 = {l0 = 0} : Mut5
                while method20(v37, v39) do
                    let v41 : int32 = v39.l0
                    let v42 : char = v34.[int v41]
                    v38.[int v41] <- v42
                    let v43 : int32 = v41 + 1
                    v39.l0 <- v43
                    ()
                let v44 : char list = v38 |> Array.toList
                let v45 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v46 : (char -> (UH0 -> UH0)) = method21()
                let v47 : (char list -> (UH0 -> UH0)) = v45 v46
                let v48 : (UH0 -> UH0) = v47 v44
                let v49 : UH0 = UH0_0
                let v50 : UH0 = v48 v49
                let struct (v55 : System.Text.StringBuilder, v56 : int32, v57 : int32) = method22(v50, v2, v3, v4)
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
        let v100 : UH2 = method46(v0, v99)
        US15_0(v100, v1, v2, v3, v4)
    | US6_0(v91, v92, v93, v94, v95) -> (* Ok *)
        let v96 : UH2 = UH2_1(v91, v0)
        method48(v96, v92, v93, v94, v95)
and method49 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method49(v0, v6)
        else
            v1
and method40 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
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
            let v34 : bool = method41(v25, v33)
            let v35 : bool = v34 = false
            if v35 then
                let v36 : (char -> string) = _.ToString()
                let v37 : string = v36 v25
                let v40 : int32 = v37.Length
                let v41 : (char []) = Array.zeroCreate<char> (v40)
                let v42 : Mut5 = {l0 = 0} : Mut5
                while method20(v40, v42) do
                    let v44 : int32 = v42.l0
                    let v45 : char = v37.[int v44]
                    v41.[int v44] <- v45
                    let v46 : int32 = v44 + 1
                    v42.l0 <- v46
                    ()
                let v47 : char list = v41 |> Array.toList
                let v48 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v49 : (char -> (UH0 -> UH0)) = method21()
                let v50 : (char list -> (UH0 -> UH0)) = v48 v49
                let v51 : (UH0 -> UH0) = v50 v47
                let v52 : UH0 = UH0_0
                let v53 : UH0 = v51 v52
                let struct (v58 : System.Text.StringBuilder, v59 : int32, v60 : int32) = method22(v53, v2, v3, v4)
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
            method42(v91, v86, v87, v88, v89)
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
                        while method20(v118, v120) do
                            let v122 : int32 = v120.l0
                            let v123 : char = v115.[int v122]
                            v119.[int v122] <- v123
                            let v124 : int32 = v122 + 1
                            v120.l0 <- v124
                            ()
                        let v125 : char list = v119 |> Array.toList
                        let v126 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v127 : (char -> (UH0 -> UH0)) = method21()
                        let v128 : (char list -> (UH0 -> UH0)) = v126 v127
                        let v129 : (UH0 -> UH0) = v128 v125
                        let v130 : UH0 = UH0_0
                        let v131 : UH0 = v129 v130
                        let struct (v136 : System.Text.StringBuilder, v137 : int32, v138 : int32) = method22(v131, v2, v3, v4)
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
                    let v172 : US15 = method43(v171, v167, v168, v169, v170)
                    let v193 : US6 =
                        match v172 with
                        | US15_1(v190) -> (* Error *)
                            US6_1(v190)
                        | US15_0(v173, v174, v175, v176, v177) -> (* Ok *)
                            let v178 : string list = []
                            let v179 : string list = method47(v173, v178)
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
                                    while method20(v215, v217) do
                                        let v219 : int32 = v217.l0
                                        let v220 : char = v212.[int v219]
                                        v216.[int v219] <- v220
                                        let v221 : int32 = v219 + 1
                                        v217.l0 <- v221
                                        ()
                                    let v222 : char list = v216 |> Array.toList
                                    let v223 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v224 : (char -> (UH0 -> UH0)) = method21()
                                    let v225 : (char list -> (UH0 -> UH0)) = v223 v224
                                    let v226 : (UH0 -> UH0) = v225 v222
                                    let v227 : UH0 = UH0_0
                                    let v228 : UH0 = v226 v227
                                    let struct (v233 : System.Text.StringBuilder, v234 : int32, v235 : int32) = method22(v228, v196, v197, v198)
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
                let v289 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure30()
                let v290 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure31()
                let v291 : UH3 = UH3_0
                let v292 : UH3 = UH3_1(v290, v291)
                let v293 : UH3 = UH3_1(v289, v292)
                let v294 : US6 = method45(v1, v2, v3, v4, v293)
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
                        method48(v311, v307, v308, v309, v310)
                match v316 with
                | US15_1(v334) -> (* Error *)
                    US6_1(v334)
                | US15_0(v317, v318, v319, v320, v321) -> (* Ok *)
                    let v322 : string list = []
                    let v323 : string list = method47(v317, v322)
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
        let v344 : UH2 = method46(v0, v343)
        US15_0(v344, v1, v2, v3, v4)
    | US6_0(v346, v347, v348, v349, v350) -> (* Ok *)
        let v351 : int32 = 0
        let v352 : int32 = method49(v347, v351)
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
            let v368 : UH2 = method46(v0, v367)
            US15_0(v368, v347, v348, v349, v350)
        | US8_0(v370, v371, v372, v373) -> (* Ok *)
            let v374 : UH2 = UH2_1(v346, v0)
            method40(v374, v370, v371, v372, v373)
and method39 (v0 : string) : US14 =
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
    let v15 : US15 = method40(v12, v7, v11, v13, v14)
    match v15 with
    | US15_1(v28) -> (* Error *)
        US14_1(v28)
    | US15_0(v16, v17, v18, v19, v20) -> (* Ok *)
        let v21 : string list = []
        let v22 : string list = method47(v16, v21)
        let v23 : (string list -> (string [])) = List.toArray
        let v24 : (string []) = v23 v22
        US14_0(v24)
and closure29 () (v0 : string) : Result<(string []), string> =
    let v1 : US14 = method39(v0)
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
let v16 : (unit -> unit) = closure3()
let current_process_kill () = v16 ()
let v17 : (string -> Async<struct (int32 * string)>) = closure12()
let execute_async x = v17 x
let v18 : (struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) -> Async<struct (int32 * string)>) = closure27()
let execute_with_options_async x = v18 x
let v19 : ((Heap0 -> Heap0) -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure28()
let execution_options x = v19 x
let v20 : (string -> Result<(string []), string>) = closure29()
let split_args x = v20 x
()
