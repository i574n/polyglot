#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
module State = let mutable trace_state = None
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
and Mut3 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : string
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : US0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : int64
    | US3_1
and Mut4 = {mutable l0 : string}
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
and method2 (v0 : string) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "std::env::var(&*$0)"
    let v3 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let v4 : string = "true; let _result = $0.map(|x| { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr v3 v4 
    let v6 : string = "x"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v6 
    let v8 : string = "fable_library_rust::String_::fromString($0)"
    let v9 : string = Fable.Core.RustInterop.emitRustExpr v7 v8 
    let v10 : string = "true; $0 })"
    let v11 : bool = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "_result"
    let v13 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v12 
    let v14 : string = method3()
    let v15 : string = "$0.unwrap_or($1)"
    let v16 : string = Fable.Core.RustInterop.emitRustExpr struct (v13, v14) v15 
    let _v1 = v16 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = "std::env::var(&*$0)"
    let v18 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v17 
    let v19 : string = "true; let _result = $0.map(|x| { //"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v18 v19 
    let v21 : string = "x"
    let v22 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v21 
    let v23 : string = "fable_library_rust::String_::fromString($0)"
    let v24 : string = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "true; $0 })"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "_result"
    let v28 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = method3()
    let v30 : string = "$0.unwrap_or($1)"
    let v31 : string = Fable.Core.RustInterop.emitRustExpr struct (v28, v29) v30 
    let _v1 = v31 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = "std::env::var(&*$0)"
    let v33 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v32 
    let v34 : string = "true; let _result = $0.map(|x| { //"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v33 v34 
    let v36 : string = "x"
    let v37 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "fable_library_rust::String_::fromString($0)"
    let v39 : string = Fable.Core.RustInterop.emitRustExpr v37 v38 
    let v40 : string = "true; $0 })"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "_result"
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
    match v61 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v65 : string = x
    let v66 : US1 = US1_0(v65)
    v66 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v64.Value <- x
    let v67 : US1 option = _v64.Value 
    let v78 : US1 = US1_1
    let v79 : US1 = v67 |> Option.defaultValue v78 
    let v86 : string =
        match v79 with
        | US1_1 -> (* None *)
            let v84 : string = ""
            v84
        | US1_0(v83) -> (* Some *)
            v83
    let _v1 = v86 
    #endif
#else
    let v87 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v88 : string = v87 v0
    let mutable _v88 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v89 : (string -> string option) = Option.ofObj
    let v90 : string option = v89 v88
    v90 
    #else
    Some v88 
    #endif
    |> fun x -> _v88 <- Some x
    let v91 : string option = match _v88 with Some x -> x | None -> failwith "optionm'.of_obj / _v88=None"
    let v94 : US1 option = None
    let _v94 = ref v94 
    match v91 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v95 : string = x
    let v96 : US1 = US1_0(v95)
    v96 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v94.Value <- x
    let v97 : US1 option = _v94.Value 
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
and method4 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure0 () (v0 : string) : unit =
    ()
and method0 (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
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
    let v359 : Mut2 = {l0 = true} : Mut2
    let v360 : Mut0 = {l0 = 0L} : Mut0
    let v363 : US0 =
        match v294 with
        | US2_1 -> (* None *)
            v0
        | US2_0(v361) -> (* Some *)
            v361
    let v364 : Mut3 = {l0 = v363} : Mut3
    let v365 : (string -> unit) = closure0()
    let v366 : Mut1 = {l0 = v365} : Mut1
    let v373 : int64 option =
        match v295 with
        | US3_1 -> (* None *)
            let v371 : int64 option = None
            v371
        | US3_0(v367) -> (* Some *)
            let v368 : int64 option = Some v367 
            v368
    struct (v360, v366, v359, v364, v373)
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
and closure3 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 3"
    v0
and closure4 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 2"
    v0
and closure5 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 1"
    v0
and closure2 () () : unit =
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
    let v1 : bool = State.trace_state.IsNone
    if v1 then
        let v2 : US0 = US0_0
        let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : Mut3, v7 : int64 option) = method0(v2)
        let v8 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v3, v4, v5, v6, v7) 
        State.trace_state <- v8 
        ()
    let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = State.trace_state.Value
    let v28 : bool = State.trace_state.IsNone
    if v28 then
        let v29 : US0 = US0_0
        let struct (v30 : Mut0, v31 : Mut1, v32 : Mut2, v33 : Mut3, v34 : int64 option) = method0(v29)
        let v35 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v30, v31, v32, v33, v34) 
        State.trace_state <- v35 
        ()
    let struct (v40 : Mut0, v41 : Mut1, v42 : Mut2, v43 : Mut3, v44 : int64 option) = State.trace_state.Value
    let v55 : US0 = v43.l0
    let v56 : bool = v42.l0
    let v57 : bool = v56 = false
    let v60 : bool =
        if v57 then
            false
        else
            let v58 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v55
            let v59 : bool = 3 >= v58
            v59
    if v60 then
        let v61 : int64 = v13.l0
        let v62 : int64 = v61 + 1L
        v13.l0 <- v62
        let v63 : bool = State.trace_state.IsNone
        if v63 then
            let v64 : US0 = US0_0
            let struct (v65 : Mut0, v66 : Mut1, v67 : Mut2, v68 : Mut3, v69 : int64 option) = method0(v64)
            let v70 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v65, v66, v67, v68, v69) 
            State.trace_state <- v70 
            ()
        let struct (v75 : Mut0, v76 : Mut1, v77 : Mut2, v78 : Mut3, v79 : int64 option) = State.trace_state.Value
        let v90 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v91 : US3 option = None
        let _v91 = ref v91 
        match v79 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v92 : int64 = x
        let v93 : US3 = US3_0(v92)
        v93 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v91.Value <- x
        let v94 : US3 option = _v91.Value 
        let v105 : US3 = US3_1
        let v106 : US3 = v94 |> Option.defaultValue v105 
        let v146 : System.DateTime =
            match v106 with
            | US3_1 -> (* None *)
                let v142 : System.DateTime = System.DateTime.Now
                v142
            | US3_0(v110) -> (* Some *)
                let v111 : System.DateTime = System.DateTime.Now
                let v114 : (System.DateTime -> int64) = _.Ticks
                let v115 : int64 = v114 v111
                let v118 : int64 = v115 - v110
                let v119 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v120 : System.TimeSpan = v119 v118
                let v123 : (System.TimeSpan -> int32) = _.Hours
                let v124 : int32 = v123 v120
                let v127 : (System.TimeSpan -> int32) = _.Minutes
                let v128 : int32 = v127 v120
                let v131 : (System.TimeSpan -> int32) = _.Seconds
                let v132 : int32 = v131 v120
                let v135 : (System.TimeSpan -> int32) = _.Milliseconds
                let v136 : int32 = v135 v120
                let v139 : System.DateTime = System.DateTime (1, 1, 1, v124, v128, v132, v136)
                v139
        let v147 : string = method5()
        let v150 : (string -> string) = v146.ToString
        let v151 : string = v150 v147
        let _v90 = v151 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v154 : US3 option = None
        let _v154 = ref v154 
        match v79 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v155 : int64 = x
        let v156 : US3 = US3_0(v155)
        v156 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v154.Value <- x
        let v157 : US3 option = _v154.Value 
        let v168 : US3 = US3_1
        let v169 : US3 = v157 |> Option.defaultValue v168 
        let v209 : System.DateTime =
            match v169 with
            | US3_1 -> (* None *)
                let v205 : System.DateTime = System.DateTime.Now
                v205
            | US3_0(v173) -> (* Some *)
                let v174 : System.DateTime = System.DateTime.Now
                let v177 : (System.DateTime -> int64) = _.Ticks
                let v178 : int64 = v177 v174
                let v181 : int64 = v178 - v173
                let v182 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v183 : System.TimeSpan = v182 v181
                let v186 : (System.TimeSpan -> int32) = _.Hours
                let v187 : int32 = v186 v183
                let v190 : (System.TimeSpan -> int32) = _.Minutes
                let v191 : int32 = v190 v183
                let v194 : (System.TimeSpan -> int32) = _.Seconds
                let v195 : int32 = v194 v183
                let v198 : (System.TimeSpan -> int32) = _.Milliseconds
                let v199 : int32 = v198 v183
                let v202 : System.DateTime = System.DateTime (1, 1, 1, v187, v191, v195, v199)
                v202
        let v210 : string = method5()
        let v213 : (string -> string) = v209.ToString
        let v214 : string = v213 v210
        let _v90 = v214 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v217 : string = $"near_sdk::env::block_timestamp()"
        let v218 : uint64 = Fable.Core.RustInterop.emitRustExpr () v217 
        let v219 : US3 option = None
        let _v219 = ref v219 
        match v79 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v220 : int64 = x
        let v221 : US3 = US3_0(v220)
        v221 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v219.Value <- x
        let v222 : US3 option = _v219.Value 
        let v233 : US3 = US3_1
        let v234 : US3 = v222 |> Option.defaultValue v233 
        let v243 : uint64 =
            match v234 with
            | US3_1 -> (* None *)
                v218
            | US3_0(v238) -> (* Some *)
                let v239 : (int64 -> uint64) = uint64
                let v240 : uint64 = v239 v238
                let v241 : uint64 = v218 - v240
                v241
        let v244 : uint64 = v243 / 1000000000UL
        let v245 : uint64 = v244 % 60UL
        let v246 : uint64 = v244 / 60UL
        let v247 : uint64 = v246 % 60UL
        let v248 : uint64 = v244 / 3600UL
        let v249 : uint64 = v248 % 24UL
        let v250 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v251 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v249, v247, v245) v250 
        let v252 : string = "fable_library_rust::String_::fromString($0)"
        let v253 : string = Fable.Core.RustInterop.emitRustExpr v251 v252 
        let _v90 = v253 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v254 : US3 option = None
        let _v254 = ref v254 
        match v79 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v255 : int64 = x
        let v256 : US3 = US3_0(v255)
        v256 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v254.Value <- x
        let v257 : US3 option = _v254.Value 
        let v268 : US3 = US3_1
        let v269 : US3 = v257 |> Option.defaultValue v268 
        let v309 : System.DateTime =
            match v269 with
            | US3_1 -> (* None *)
                let v305 : System.DateTime = System.DateTime.Now
                v305
            | US3_0(v273) -> (* Some *)
                let v274 : System.DateTime = System.DateTime.Now
                let v277 : (System.DateTime -> int64) = _.Ticks
                let v278 : int64 = v277 v274
                let v281 : int64 = v278 - v273
                let v282 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v283 : System.TimeSpan = v282 v281
                let v286 : (System.TimeSpan -> int32) = _.Hours
                let v287 : int32 = v286 v283
                let v290 : (System.TimeSpan -> int32) = _.Minutes
                let v291 : int32 = v290 v283
                let v294 : (System.TimeSpan -> int32) = _.Seconds
                let v295 : int32 = v294 v283
                let v298 : (System.TimeSpan -> int32) = _.Milliseconds
                let v299 : int32 = v298 v283
                let v302 : System.DateTime = System.DateTime (1, 1, 1, v287, v291, v295, v299)
                v302
        let v310 : string = method6()
        let v313 : (string -> string) = v309.ToString
        let v314 : string = v313 v310
        let _v90 = v314 
        #endif
#if FABLE_COMPILER_PYTHON
        let v317 : US3 option = None
        let _v317 = ref v317 
        match v79 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v318 : int64 = x
        let v319 : US3 = US3_0(v318)
        v319 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v317.Value <- x
        let v320 : US3 option = _v317.Value 
        let v331 : US3 = US3_1
        let v332 : US3 = v320 |> Option.defaultValue v331 
        let v372 : System.DateTime =
            match v332 with
            | US3_1 -> (* None *)
                let v368 : System.DateTime = System.DateTime.Now
                v368
            | US3_0(v336) -> (* Some *)
                let v337 : System.DateTime = System.DateTime.Now
                let v340 : (System.DateTime -> int64) = _.Ticks
                let v341 : int64 = v340 v337
                let v344 : int64 = v341 - v336
                let v345 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v346 : System.TimeSpan = v345 v344
                let v349 : (System.TimeSpan -> int32) = _.Hours
                let v350 : int32 = v349 v346
                let v353 : (System.TimeSpan -> int32) = _.Minutes
                let v354 : int32 = v353 v346
                let v357 : (System.TimeSpan -> int32) = _.Seconds
                let v358 : int32 = v357 v346
                let v361 : (System.TimeSpan -> int32) = _.Milliseconds
                let v362 : int32 = v361 v346
                let v365 : System.DateTime = System.DateTime (1, 1, 1, v350, v354, v358, v362)
                v365
        let v373 : string = method6()
        let v376 : (string -> string) = v372.ToString
        let v377 : string = v376 v373
        let _v90 = v377 
        #endif
#else
        let v380 : US3 option = None
        let _v380 = ref v380 
        match v79 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v381 : int64 = x
        let v382 : US3 = US3_0(v381)
        v382 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v380.Value <- x
        let v383 : US3 option = _v380.Value 
        let v394 : US3 = US3_1
        let v395 : US3 = v383 |> Option.defaultValue v394 
        let v435 : System.DateTime =
            match v395 with
            | US3_1 -> (* None *)
                let v431 : System.DateTime = System.DateTime.Now
                v431
            | US3_0(v399) -> (* Some *)
                let v400 : System.DateTime = System.DateTime.Now
                let v403 : (System.DateTime -> int64) = _.Ticks
                let v404 : int64 = v403 v400
                let v407 : int64 = v404 - v399
                let v408 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v409 : System.TimeSpan = v408 v407
                let v412 : (System.TimeSpan -> int32) = _.Hours
                let v413 : int32 = v412 v409
                let v416 : (System.TimeSpan -> int32) = _.Minutes
                let v417 : int32 = v416 v409
                let v420 : (System.TimeSpan -> int32) = _.Seconds
                let v421 : int32 = v420 v409
                let v424 : (System.TimeSpan -> int32) = _.Milliseconds
                let v425 : int32 = v424 v409
                let v428 : System.DateTime = System.DateTime (1, 1, 1, v413, v417, v421, v425)
                v428
        let v436 : string = method6()
        let v439 : (string -> string) = v435.ToString
        let v440 : string = v439 v436
        let _v90 = v440 
        #endif
        let v443 : string = _v90 
        let v508 : string = "Warning"
        let v509 : (unit -> string) = v508.ToLower
        let v510 : string = v509 ()
        let v513 : string = v510.PadLeft (7, ' ')
        let v527 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v528 : string = "inline_colorization::color_yellow"
        let v529 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v528 
        let v530 : string = "&*$0"
        let v531 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v513 v530 
        let v532 : string = "inline_colorization::color_reset"
        let v533 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v532 
        let v534 : string = "\"{v529}{v531}{v533}\""
        let v535 : string = @$"format!(" + v534 + ")"
        let v536 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v535 
        let v537 : string = "fable_library_rust::String_::fromString($0)"
        let v538 : string = Fable.Core.RustInterop.emitRustExpr v536 v537 
        let _v527 = v538 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v539 : string = "inline_colorization::color_yellow"
        let v540 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v539 
        let v541 : string = "&*$0"
        let v542 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v513 v541 
        let v543 : string = "inline_colorization::color_reset"
        let v544 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v543 
        let v545 : string = "\"{v540}{v542}{v544}\""
        let v546 : string = @$"format!(" + v545 + ")"
        let v547 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v546 
        let v548 : string = "fable_library_rust::String_::fromString($0)"
        let v549 : string = Fable.Core.RustInterop.emitRustExpr v547 v548 
        let _v527 = v549 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v550 : string = "inline_colorization::color_yellow"
        let v551 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v550 
        let v552 : string = "&*$0"
        let v553 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v513 v552 
        let v554 : string = "inline_colorization::color_reset"
        let v555 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v554 
        let v556 : string = "\"{v551}{v553}{v555}\""
        let v557 : string = @$"format!(" + v556 + ")"
        let v558 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v557 
        let v559 : string = "fable_library_rust::String_::fromString($0)"
        let v560 : string = Fable.Core.RustInterop.emitRustExpr v558 v559 
        let _v527 = v560 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v561 : string = "\u001b[93m"
        let v562 : string = method7()
        let v563 : string = v561 + v513 
        let v564 : string = v563 + v562 
        let _v527 = v564 
        #endif
#if FABLE_COMPILER_PYTHON
        let v565 : string = "\u001b[93m"
        let v566 : string = method7()
        let v567 : string = v565 + v513 
        let v568 : string = v567 + v566 
        let _v527 = v568 
        #endif
#else
        let v569 : string = "\u001b[93m"
        let v570 : string = method7()
        let v571 : string = v569 + v513 
        let v572 : string = v571 + v570 
        let _v527 = v572 
        #endif
        let v573 : string = _v527 
        let v579 : int64 = v75.l0
        let v580 : string = method8()
        let v581 : Mut4 = {l0 = v580} : Mut4
        let v582 : string = v581.l0
        let v583 : (unit -> string) = closure3()
        let v584 : string = $"{v443} {v573} #{v579} %s{v583 ()} / {v582}"
        let v587 : char list = []
        let v588 : (char list -> (char [])) = List.toArray
        let v589 : (char []) = v588 v587
        let v592 : string = v584.TrimStart v589 
        let v610 : char list = []
        let v611 : char list = '/' :: v610 
        let v614 : char list = ' ' :: v611 
        let v617 : (char list -> (char [])) = List.toArray
        let v618 : (char []) = v617 v614
        let v621 : string = v592.TrimEnd v618 
        let v639 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v640 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v621 v640 
        let _v639 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v641 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v621 v641 
        let _v639 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v642 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v621 v642 
        let _v639 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v621 
        let _v639 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v621 
        let _v639 = () 
        #endif
#else
        System.Console.WriteLine v621 
        let _v639 = () 
        #endif
        _v639 
        let v643 : (string -> unit) = v14.l0
        v643 v621
    System.Threading.Thread.Sleep 300
    let v644 : bool = State.trace_state.IsNone
    if v644 then
        let v645 : US0 = US0_0
        let struct (v646 : Mut0, v647 : Mut1, v648 : Mut2, v649 : Mut3, v650 : int64 option) = method0(v645)
        let v651 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v646, v647, v648, v649, v650) 
        State.trace_state <- v651 
        ()
    let struct (v656 : Mut0, v657 : Mut1, v658 : Mut2, v659 : Mut3, v660 : int64 option) = State.trace_state.Value
    let v671 : bool = State.trace_state.IsNone
    if v671 then
        let v672 : US0 = US0_0
        let struct (v673 : Mut0, v674 : Mut1, v675 : Mut2, v676 : Mut3, v677 : int64 option) = method0(v672)
        let v678 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v673, v674, v675, v676, v677) 
        State.trace_state <- v678 
        ()
    let struct (v683 : Mut0, v684 : Mut1, v685 : Mut2, v686 : Mut3, v687 : int64 option) = State.trace_state.Value
    let v698 : US0 = v686.l0
    let v699 : bool = v685.l0
    let v700 : bool = v699 = false
    let v703 : bool =
        if v700 then
            false
        else
            let v701 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v698
            let v702 : bool = 3 >= v701
            v702
    if v703 then
        let v704 : int64 = v656.l0
        let v705 : int64 = v704 + 1L
        v656.l0 <- v705
        let v706 : bool = State.trace_state.IsNone
        if v706 then
            let v707 : US0 = US0_0
            let struct (v708 : Mut0, v709 : Mut1, v710 : Mut2, v711 : Mut3, v712 : int64 option) = method0(v707)
            let v713 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v708, v709, v710, v711, v712) 
            State.trace_state <- v713 
            ()
        let struct (v718 : Mut0, v719 : Mut1, v720 : Mut2, v721 : Mut3, v722 : int64 option) = State.trace_state.Value
        let v733 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v734 : US3 option = None
        let _v734 = ref v734 
        match v722 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v735 : int64 = x
        let v736 : US3 = US3_0(v735)
        v736 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v734.Value <- x
        let v737 : US3 option = _v734.Value 
        let v748 : US3 = US3_1
        let v749 : US3 = v737 |> Option.defaultValue v748 
        let v789 : System.DateTime =
            match v749 with
            | US3_1 -> (* None *)
                let v785 : System.DateTime = System.DateTime.Now
                v785
            | US3_0(v753) -> (* Some *)
                let v754 : System.DateTime = System.DateTime.Now
                let v757 : (System.DateTime -> int64) = _.Ticks
                let v758 : int64 = v757 v754
                let v761 : int64 = v758 - v753
                let v762 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v763 : System.TimeSpan = v762 v761
                let v766 : (System.TimeSpan -> int32) = _.Hours
                let v767 : int32 = v766 v763
                let v770 : (System.TimeSpan -> int32) = _.Minutes
                let v771 : int32 = v770 v763
                let v774 : (System.TimeSpan -> int32) = _.Seconds
                let v775 : int32 = v774 v763
                let v778 : (System.TimeSpan -> int32) = _.Milliseconds
                let v779 : int32 = v778 v763
                let v782 : System.DateTime = System.DateTime (1, 1, 1, v767, v771, v775, v779)
                v782
        let v790 : string = method5()
        let v793 : (string -> string) = v789.ToString
        let v794 : string = v793 v790
        let _v733 = v794 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v797 : US3 option = None
        let _v797 = ref v797 
        match v722 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v798 : int64 = x
        let v799 : US3 = US3_0(v798)
        v799 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v797.Value <- x
        let v800 : US3 option = _v797.Value 
        let v811 : US3 = US3_1
        let v812 : US3 = v800 |> Option.defaultValue v811 
        let v852 : System.DateTime =
            match v812 with
            | US3_1 -> (* None *)
                let v848 : System.DateTime = System.DateTime.Now
                v848
            | US3_0(v816) -> (* Some *)
                let v817 : System.DateTime = System.DateTime.Now
                let v820 : (System.DateTime -> int64) = _.Ticks
                let v821 : int64 = v820 v817
                let v824 : int64 = v821 - v816
                let v825 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v826 : System.TimeSpan = v825 v824
                let v829 : (System.TimeSpan -> int32) = _.Hours
                let v830 : int32 = v829 v826
                let v833 : (System.TimeSpan -> int32) = _.Minutes
                let v834 : int32 = v833 v826
                let v837 : (System.TimeSpan -> int32) = _.Seconds
                let v838 : int32 = v837 v826
                let v841 : (System.TimeSpan -> int32) = _.Milliseconds
                let v842 : int32 = v841 v826
                let v845 : System.DateTime = System.DateTime (1, 1, 1, v830, v834, v838, v842)
                v845
        let v853 : string = method5()
        let v856 : (string -> string) = v852.ToString
        let v857 : string = v856 v853
        let _v733 = v857 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v860 : string = $"near_sdk::env::block_timestamp()"
        let v861 : uint64 = Fable.Core.RustInterop.emitRustExpr () v860 
        let v862 : US3 option = None
        let _v862 = ref v862 
        match v722 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v863 : int64 = x
        let v864 : US3 = US3_0(v863)
        v864 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v862.Value <- x
        let v865 : US3 option = _v862.Value 
        let v876 : US3 = US3_1
        let v877 : US3 = v865 |> Option.defaultValue v876 
        let v886 : uint64 =
            match v877 with
            | US3_1 -> (* None *)
                v861
            | US3_0(v881) -> (* Some *)
                let v882 : (int64 -> uint64) = uint64
                let v883 : uint64 = v882 v881
                let v884 : uint64 = v861 - v883
                v884
        let v887 : uint64 = v886 / 1000000000UL
        let v888 : uint64 = v887 % 60UL
        let v889 : uint64 = v887 / 60UL
        let v890 : uint64 = v889 % 60UL
        let v891 : uint64 = v887 / 3600UL
        let v892 : uint64 = v891 % 24UL
        let v893 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v894 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v892, v890, v888) v893 
        let v895 : string = "fable_library_rust::String_::fromString($0)"
        let v896 : string = Fable.Core.RustInterop.emitRustExpr v894 v895 
        let _v733 = v896 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v897 : US3 option = None
        let _v897 = ref v897 
        match v722 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v898 : int64 = x
        let v899 : US3 = US3_0(v898)
        v899 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v897.Value <- x
        let v900 : US3 option = _v897.Value 
        let v911 : US3 = US3_1
        let v912 : US3 = v900 |> Option.defaultValue v911 
        let v952 : System.DateTime =
            match v912 with
            | US3_1 -> (* None *)
                let v948 : System.DateTime = System.DateTime.Now
                v948
            | US3_0(v916) -> (* Some *)
                let v917 : System.DateTime = System.DateTime.Now
                let v920 : (System.DateTime -> int64) = _.Ticks
                let v921 : int64 = v920 v917
                let v924 : int64 = v921 - v916
                let v925 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v926 : System.TimeSpan = v925 v924
                let v929 : (System.TimeSpan -> int32) = _.Hours
                let v930 : int32 = v929 v926
                let v933 : (System.TimeSpan -> int32) = _.Minutes
                let v934 : int32 = v933 v926
                let v937 : (System.TimeSpan -> int32) = _.Seconds
                let v938 : int32 = v937 v926
                let v941 : (System.TimeSpan -> int32) = _.Milliseconds
                let v942 : int32 = v941 v926
                let v945 : System.DateTime = System.DateTime (1, 1, 1, v930, v934, v938, v942)
                v945
        let v953 : string = method6()
        let v956 : (string -> string) = v952.ToString
        let v957 : string = v956 v953
        let _v733 = v957 
        #endif
#if FABLE_COMPILER_PYTHON
        let v960 : US3 option = None
        let _v960 = ref v960 
        match v722 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v961 : int64 = x
        let v962 : US3 = US3_0(v961)
        v962 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v960.Value <- x
        let v963 : US3 option = _v960.Value 
        let v974 : US3 = US3_1
        let v975 : US3 = v963 |> Option.defaultValue v974 
        let v1015 : System.DateTime =
            match v975 with
            | US3_1 -> (* None *)
                let v1011 : System.DateTime = System.DateTime.Now
                v1011
            | US3_0(v979) -> (* Some *)
                let v980 : System.DateTime = System.DateTime.Now
                let v983 : (System.DateTime -> int64) = _.Ticks
                let v984 : int64 = v983 v980
                let v987 : int64 = v984 - v979
                let v988 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v989 : System.TimeSpan = v988 v987
                let v992 : (System.TimeSpan -> int32) = _.Hours
                let v993 : int32 = v992 v989
                let v996 : (System.TimeSpan -> int32) = _.Minutes
                let v997 : int32 = v996 v989
                let v1000 : (System.TimeSpan -> int32) = _.Seconds
                let v1001 : int32 = v1000 v989
                let v1004 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1005 : int32 = v1004 v989
                let v1008 : System.DateTime = System.DateTime (1, 1, 1, v993, v997, v1001, v1005)
                v1008
        let v1016 : string = method6()
        let v1019 : (string -> string) = v1015.ToString
        let v1020 : string = v1019 v1016
        let _v733 = v1020 
        #endif
#else
        let v1023 : US3 option = None
        let _v1023 = ref v1023 
        match v722 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1024 : int64 = x
        let v1025 : US3 = US3_0(v1024)
        v1025 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1023.Value <- x
        let v1026 : US3 option = _v1023.Value 
        let v1037 : US3 = US3_1
        let v1038 : US3 = v1026 |> Option.defaultValue v1037 
        let v1078 : System.DateTime =
            match v1038 with
            | US3_1 -> (* None *)
                let v1074 : System.DateTime = System.DateTime.Now
                v1074
            | US3_0(v1042) -> (* Some *)
                let v1043 : System.DateTime = System.DateTime.Now
                let v1046 : (System.DateTime -> int64) = _.Ticks
                let v1047 : int64 = v1046 v1043
                let v1050 : int64 = v1047 - v1042
                let v1051 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1052 : System.TimeSpan = v1051 v1050
                let v1055 : (System.TimeSpan -> int32) = _.Hours
                let v1056 : int32 = v1055 v1052
                let v1059 : (System.TimeSpan -> int32) = _.Minutes
                let v1060 : int32 = v1059 v1052
                let v1063 : (System.TimeSpan -> int32) = _.Seconds
                let v1064 : int32 = v1063 v1052
                let v1067 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1068 : int32 = v1067 v1052
                let v1071 : System.DateTime = System.DateTime (1, 1, 1, v1056, v1060, v1064, v1068)
                v1071
        let v1079 : string = method6()
        let v1082 : (string -> string) = v1078.ToString
        let v1083 : string = v1082 v1079
        let _v733 = v1083 
        #endif
        let v1086 : string = _v733 
        let v1151 : string = "Warning"
        let v1152 : (unit -> string) = v1151.ToLower
        let v1153 : string = v1152 ()
        let v1156 : string = v1153.PadLeft (7, ' ')
        let v1170 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1171 : string = "inline_colorization::color_yellow"
        let v1172 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1171 
        let v1173 : string = "&*$0"
        let v1174 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1156 v1173 
        let v1175 : string = "inline_colorization::color_reset"
        let v1176 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1175 
        let v1177 : string = "\"{v1172}{v1174}{v1176}\""
        let v1178 : string = @$"format!(" + v1177 + ")"
        let v1179 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1178 
        let v1180 : string = "fable_library_rust::String_::fromString($0)"
        let v1181 : string = Fable.Core.RustInterop.emitRustExpr v1179 v1180 
        let _v1170 = v1181 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1182 : string = "inline_colorization::color_yellow"
        let v1183 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1182 
        let v1184 : string = "&*$0"
        let v1185 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1156 v1184 
        let v1186 : string = "inline_colorization::color_reset"
        let v1187 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1186 
        let v1188 : string = "\"{v1183}{v1185}{v1187}\""
        let v1189 : string = @$"format!(" + v1188 + ")"
        let v1190 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1189 
        let v1191 : string = "fable_library_rust::String_::fromString($0)"
        let v1192 : string = Fable.Core.RustInterop.emitRustExpr v1190 v1191 
        let _v1170 = v1192 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1193 : string = "inline_colorization::color_yellow"
        let v1194 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1193 
        let v1195 : string = "&*$0"
        let v1196 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1156 v1195 
        let v1197 : string = "inline_colorization::color_reset"
        let v1198 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1197 
        let v1199 : string = "\"{v1194}{v1196}{v1198}\""
        let v1200 : string = @$"format!(" + v1199 + ")"
        let v1201 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1200 
        let v1202 : string = "fable_library_rust::String_::fromString($0)"
        let v1203 : string = Fable.Core.RustInterop.emitRustExpr v1201 v1202 
        let _v1170 = v1203 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1204 : string = "\u001b[93m"
        let v1205 : string = method7()
        let v1206 : string = v1204 + v1156 
        let v1207 : string = v1206 + v1205 
        let _v1170 = v1207 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1208 : string = "\u001b[93m"
        let v1209 : string = method7()
        let v1210 : string = v1208 + v1156 
        let v1211 : string = v1210 + v1209 
        let _v1170 = v1211 
        #endif
#else
        let v1212 : string = "\u001b[93m"
        let v1213 : string = method7()
        let v1214 : string = v1212 + v1156 
        let v1215 : string = v1214 + v1213 
        let _v1170 = v1215 
        #endif
        let v1216 : string = _v1170 
        let v1222 : int64 = v718.l0
        let v1223 : string = method8()
        let v1224 : Mut4 = {l0 = v1223} : Mut4
        let v1225 : string = v1224.l0
        let v1226 : (unit -> string) = closure4()
        let v1227 : string = $"{v1086} {v1216} #{v1222} %s{v1226 ()} / {v1225}"
        let v1230 : char list = []
        let v1231 : (char list -> (char [])) = List.toArray
        let v1232 : (char []) = v1231 v1230
        let v1235 : string = v1227.TrimStart v1232 
        let v1253 : char list = []
        let v1254 : char list = '/' :: v1253 
        let v1257 : char list = ' ' :: v1254 
        let v1260 : (char list -> (char [])) = List.toArray
        let v1261 : (char []) = v1260 v1257
        let v1264 : string = v1235.TrimEnd v1261 
        let v1282 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1283 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1264 v1283 
        let _v1282 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1284 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1264 v1284 
        let _v1282 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1285 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1264 v1285 
        let _v1282 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1264 
        let _v1282 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1264 
        let _v1282 = () 
        #endif
#else
        System.Console.WriteLine v1264 
        let _v1282 = () 
        #endif
        _v1282 
        let v1286 : (string -> unit) = v657.l0
        v1286 v1264
    System.Console.Out.Flush ()
    System.Threading.Thread.Sleep 60
    let v1287 : bool = State.trace_state.IsNone
    if v1287 then
        let v1288 : US0 = US0_0
        let struct (v1289 : Mut0, v1290 : Mut1, v1291 : Mut2, v1292 : Mut3, v1293 : int64 option) = method0(v1288)
        let v1294 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1289, v1290, v1291, v1292, v1293) 
        State.trace_state <- v1294 
        ()
    let struct (v1299 : Mut0, v1300 : Mut1, v1301 : Mut2, v1302 : Mut3, v1303 : int64 option) = State.trace_state.Value
    let v1314 : bool = State.trace_state.IsNone
    if v1314 then
        let v1315 : US0 = US0_0
        let struct (v1316 : Mut0, v1317 : Mut1, v1318 : Mut2, v1319 : Mut3, v1320 : int64 option) = method0(v1315)
        let v1321 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1316, v1317, v1318, v1319, v1320) 
        State.trace_state <- v1321 
        ()
    let struct (v1326 : Mut0, v1327 : Mut1, v1328 : Mut2, v1329 : Mut3, v1330 : int64 option) = State.trace_state.Value
    let v1341 : US0 = v1329.l0
    let v1342 : bool = v1328.l0
    let v1343 : bool = v1342 = false
    let v1346 : bool =
        if v1343 then
            false
        else
            let v1344 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1341
            let v1345 : bool = 3 >= v1344
            v1345
    if v1346 then
        let v1347 : int64 = v1299.l0
        let v1348 : int64 = v1347 + 1L
        v1299.l0 <- v1348
        let v1349 : bool = State.trace_state.IsNone
        if v1349 then
            let v1350 : US0 = US0_0
            let struct (v1351 : Mut0, v1352 : Mut1, v1353 : Mut2, v1354 : Mut3, v1355 : int64 option) = method0(v1350)
            let v1356 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1351, v1352, v1353, v1354, v1355) 
            State.trace_state <- v1356 
            ()
        let struct (v1361 : Mut0, v1362 : Mut1, v1363 : Mut2, v1364 : Mut3, v1365 : int64 option) = State.trace_state.Value
        let v1376 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1377 : US3 option = None
        let _v1377 = ref v1377 
        match v1365 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1378 : int64 = x
        let v1379 : US3 = US3_0(v1378)
        v1379 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1377.Value <- x
        let v1380 : US3 option = _v1377.Value 
        let v1391 : US3 = US3_1
        let v1392 : US3 = v1380 |> Option.defaultValue v1391 
        let v1432 : System.DateTime =
            match v1392 with
            | US3_1 -> (* None *)
                let v1428 : System.DateTime = System.DateTime.Now
                v1428
            | US3_0(v1396) -> (* Some *)
                let v1397 : System.DateTime = System.DateTime.Now
                let v1400 : (System.DateTime -> int64) = _.Ticks
                let v1401 : int64 = v1400 v1397
                let v1404 : int64 = v1401 - v1396
                let v1405 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1406 : System.TimeSpan = v1405 v1404
                let v1409 : (System.TimeSpan -> int32) = _.Hours
                let v1410 : int32 = v1409 v1406
                let v1413 : (System.TimeSpan -> int32) = _.Minutes
                let v1414 : int32 = v1413 v1406
                let v1417 : (System.TimeSpan -> int32) = _.Seconds
                let v1418 : int32 = v1417 v1406
                let v1421 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1422 : int32 = v1421 v1406
                let v1425 : System.DateTime = System.DateTime (1, 1, 1, v1410, v1414, v1418, v1422)
                v1425
        let v1433 : string = method5()
        let v1436 : (string -> string) = v1432.ToString
        let v1437 : string = v1436 v1433
        let _v1376 = v1437 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1440 : US3 option = None
        let _v1440 = ref v1440 
        match v1365 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1441 : int64 = x
        let v1442 : US3 = US3_0(v1441)
        v1442 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1440.Value <- x
        let v1443 : US3 option = _v1440.Value 
        let v1454 : US3 = US3_1
        let v1455 : US3 = v1443 |> Option.defaultValue v1454 
        let v1495 : System.DateTime =
            match v1455 with
            | US3_1 -> (* None *)
                let v1491 : System.DateTime = System.DateTime.Now
                v1491
            | US3_0(v1459) -> (* Some *)
                let v1460 : System.DateTime = System.DateTime.Now
                let v1463 : (System.DateTime -> int64) = _.Ticks
                let v1464 : int64 = v1463 v1460
                let v1467 : int64 = v1464 - v1459
                let v1468 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1469 : System.TimeSpan = v1468 v1467
                let v1472 : (System.TimeSpan -> int32) = _.Hours
                let v1473 : int32 = v1472 v1469
                let v1476 : (System.TimeSpan -> int32) = _.Minutes
                let v1477 : int32 = v1476 v1469
                let v1480 : (System.TimeSpan -> int32) = _.Seconds
                let v1481 : int32 = v1480 v1469
                let v1484 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1485 : int32 = v1484 v1469
                let v1488 : System.DateTime = System.DateTime (1, 1, 1, v1473, v1477, v1481, v1485)
                v1488
        let v1496 : string = method5()
        let v1499 : (string -> string) = v1495.ToString
        let v1500 : string = v1499 v1496
        let _v1376 = v1500 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1503 : string = $"near_sdk::env::block_timestamp()"
        let v1504 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1503 
        let v1505 : US3 option = None
        let _v1505 = ref v1505 
        match v1365 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1506 : int64 = x
        let v1507 : US3 = US3_0(v1506)
        v1507 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1505.Value <- x
        let v1508 : US3 option = _v1505.Value 
        let v1519 : US3 = US3_1
        let v1520 : US3 = v1508 |> Option.defaultValue v1519 
        let v1529 : uint64 =
            match v1520 with
            | US3_1 -> (* None *)
                v1504
            | US3_0(v1524) -> (* Some *)
                let v1525 : (int64 -> uint64) = uint64
                let v1526 : uint64 = v1525 v1524
                let v1527 : uint64 = v1504 - v1526
                v1527
        let v1530 : uint64 = v1529 / 1000000000UL
        let v1531 : uint64 = v1530 % 60UL
        let v1532 : uint64 = v1530 / 60UL
        let v1533 : uint64 = v1532 % 60UL
        let v1534 : uint64 = v1530 / 3600UL
        let v1535 : uint64 = v1534 % 24UL
        let v1536 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v1537 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1535, v1533, v1531) v1536 
        let v1538 : string = "fable_library_rust::String_::fromString($0)"
        let v1539 : string = Fable.Core.RustInterop.emitRustExpr v1537 v1538 
        let _v1376 = v1539 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1540 : US3 option = None
        let _v1540 = ref v1540 
        match v1365 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1541 : int64 = x
        let v1542 : US3 = US3_0(v1541)
        v1542 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1540.Value <- x
        let v1543 : US3 option = _v1540.Value 
        let v1554 : US3 = US3_1
        let v1555 : US3 = v1543 |> Option.defaultValue v1554 
        let v1595 : System.DateTime =
            match v1555 with
            | US3_1 -> (* None *)
                let v1591 : System.DateTime = System.DateTime.Now
                v1591
            | US3_0(v1559) -> (* Some *)
                let v1560 : System.DateTime = System.DateTime.Now
                let v1563 : (System.DateTime -> int64) = _.Ticks
                let v1564 : int64 = v1563 v1560
                let v1567 : int64 = v1564 - v1559
                let v1568 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1569 : System.TimeSpan = v1568 v1567
                let v1572 : (System.TimeSpan -> int32) = _.Hours
                let v1573 : int32 = v1572 v1569
                let v1576 : (System.TimeSpan -> int32) = _.Minutes
                let v1577 : int32 = v1576 v1569
                let v1580 : (System.TimeSpan -> int32) = _.Seconds
                let v1581 : int32 = v1580 v1569
                let v1584 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1585 : int32 = v1584 v1569
                let v1588 : System.DateTime = System.DateTime (1, 1, 1, v1573, v1577, v1581, v1585)
                v1588
        let v1596 : string = method6()
        let v1599 : (string -> string) = v1595.ToString
        let v1600 : string = v1599 v1596
        let _v1376 = v1600 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1603 : US3 option = None
        let _v1603 = ref v1603 
        match v1365 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1604 : int64 = x
        let v1605 : US3 = US3_0(v1604)
        v1605 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1603.Value <- x
        let v1606 : US3 option = _v1603.Value 
        let v1617 : US3 = US3_1
        let v1618 : US3 = v1606 |> Option.defaultValue v1617 
        let v1658 : System.DateTime =
            match v1618 with
            | US3_1 -> (* None *)
                let v1654 : System.DateTime = System.DateTime.Now
                v1654
            | US3_0(v1622) -> (* Some *)
                let v1623 : System.DateTime = System.DateTime.Now
                let v1626 : (System.DateTime -> int64) = _.Ticks
                let v1627 : int64 = v1626 v1623
                let v1630 : int64 = v1627 - v1622
                let v1631 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1632 : System.TimeSpan = v1631 v1630
                let v1635 : (System.TimeSpan -> int32) = _.Hours
                let v1636 : int32 = v1635 v1632
                let v1639 : (System.TimeSpan -> int32) = _.Minutes
                let v1640 : int32 = v1639 v1632
                let v1643 : (System.TimeSpan -> int32) = _.Seconds
                let v1644 : int32 = v1643 v1632
                let v1647 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1648 : int32 = v1647 v1632
                let v1651 : System.DateTime = System.DateTime (1, 1, 1, v1636, v1640, v1644, v1648)
                v1651
        let v1659 : string = method6()
        let v1662 : (string -> string) = v1658.ToString
        let v1663 : string = v1662 v1659
        let _v1376 = v1663 
        #endif
#else
        let v1666 : US3 option = None
        let _v1666 = ref v1666 
        match v1365 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1667 : int64 = x
        let v1668 : US3 = US3_0(v1667)
        v1668 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1666.Value <- x
        let v1669 : US3 option = _v1666.Value 
        let v1680 : US3 = US3_1
        let v1681 : US3 = v1669 |> Option.defaultValue v1680 
        let v1721 : System.DateTime =
            match v1681 with
            | US3_1 -> (* None *)
                let v1717 : System.DateTime = System.DateTime.Now
                v1717
            | US3_0(v1685) -> (* Some *)
                let v1686 : System.DateTime = System.DateTime.Now
                let v1689 : (System.DateTime -> int64) = _.Ticks
                let v1690 : int64 = v1689 v1686
                let v1693 : int64 = v1690 - v1685
                let v1694 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1695 : System.TimeSpan = v1694 v1693
                let v1698 : (System.TimeSpan -> int32) = _.Hours
                let v1699 : int32 = v1698 v1695
                let v1702 : (System.TimeSpan -> int32) = _.Minutes
                let v1703 : int32 = v1702 v1695
                let v1706 : (System.TimeSpan -> int32) = _.Seconds
                let v1707 : int32 = v1706 v1695
                let v1710 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1711 : int32 = v1710 v1695
                let v1714 : System.DateTime = System.DateTime (1, 1, 1, v1699, v1703, v1707, v1711)
                v1714
        let v1722 : string = method6()
        let v1725 : (string -> string) = v1721.ToString
        let v1726 : string = v1725 v1722
        let _v1376 = v1726 
        #endif
        let v1729 : string = _v1376 
        let v1794 : string = "Warning"
        let v1795 : (unit -> string) = v1794.ToLower
        let v1796 : string = v1795 ()
        let v1799 : string = v1796.PadLeft (7, ' ')
        let v1813 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1814 : string = "inline_colorization::color_yellow"
        let v1815 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1814 
        let v1816 : string = "&*$0"
        let v1817 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1799 v1816 
        let v1818 : string = "inline_colorization::color_reset"
        let v1819 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1818 
        let v1820 : string = "\"{v1815}{v1817}{v1819}\""
        let v1821 : string = @$"format!(" + v1820 + ")"
        let v1822 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1821 
        let v1823 : string = "fable_library_rust::String_::fromString($0)"
        let v1824 : string = Fable.Core.RustInterop.emitRustExpr v1822 v1823 
        let _v1813 = v1824 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1825 : string = "inline_colorization::color_yellow"
        let v1826 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1825 
        let v1827 : string = "&*$0"
        let v1828 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1799 v1827 
        let v1829 : string = "inline_colorization::color_reset"
        let v1830 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1829 
        let v1831 : string = "\"{v1826}{v1828}{v1830}\""
        let v1832 : string = @$"format!(" + v1831 + ")"
        let v1833 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1832 
        let v1834 : string = "fable_library_rust::String_::fromString($0)"
        let v1835 : string = Fable.Core.RustInterop.emitRustExpr v1833 v1834 
        let _v1813 = v1835 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1836 : string = "inline_colorization::color_yellow"
        let v1837 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1836 
        let v1838 : string = "&*$0"
        let v1839 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1799 v1838 
        let v1840 : string = "inline_colorization::color_reset"
        let v1841 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1840 
        let v1842 : string = "\"{v1837}{v1839}{v1841}\""
        let v1843 : string = @$"format!(" + v1842 + ")"
        let v1844 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1843 
        let v1845 : string = "fable_library_rust::String_::fromString($0)"
        let v1846 : string = Fable.Core.RustInterop.emitRustExpr v1844 v1845 
        let _v1813 = v1846 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1847 : string = "\u001b[93m"
        let v1848 : string = method7()
        let v1849 : string = v1847 + v1799 
        let v1850 : string = v1849 + v1848 
        let _v1813 = v1850 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1851 : string = "\u001b[93m"
        let v1852 : string = method7()
        let v1853 : string = v1851 + v1799 
        let v1854 : string = v1853 + v1852 
        let _v1813 = v1854 
        #endif
#else
        let v1855 : string = "\u001b[93m"
        let v1856 : string = method7()
        let v1857 : string = v1855 + v1799 
        let v1858 : string = v1857 + v1856 
        let _v1813 = v1858 
        #endif
        let v1859 : string = _v1813 
        let v1865 : int64 = v1361.l0
        let v1866 : string = method8()
        let v1867 : Mut4 = {l0 = v1866} : Mut4
        let v1868 : string = v1867.l0
        let v1869 : (unit -> string) = closure5()
        let v1870 : string = $"{v1729} {v1859} #{v1865} %s{v1869 ()} / {v1868}"
        let v1873 : char list = []
        let v1874 : (char list -> (char [])) = List.toArray
        let v1875 : (char []) = v1874 v1873
        let v1878 : string = v1870.TrimStart v1875 
        let v1896 : char list = []
        let v1897 : char list = '/' :: v1896 
        let v1900 : char list = ' ' :: v1897 
        let v1903 : (char list -> (char [])) = List.toArray
        let v1904 : (char []) = v1903 v1900
        let v1907 : string = v1878.TrimEnd v1904 
        let v1925 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1926 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1907 v1926 
        let _v1925 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1927 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1907 v1927 
        let _v1925 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1928 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1907 v1928 
        let _v1925 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1907 
        let _v1925 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1907 
        let _v1925 = () 
        #endif
#else
        System.Console.WriteLine v1907 
        let _v1925 = () 
        #endif
        _v1925 
        let v1929 : (string -> unit) = v1300.l0
        v1929 v1907
    System.Diagnostics.Process.GetCurrentProcess().Kill ()
    let _v0 = () 
    #endif
    _v0 
    ()
and closure1 () () : unit =
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
    let v1 : (unit -> unit) = closure2()
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
and closure9 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure8 () (v0 : char) : (UH0 -> UH0) =
    closure9(v0)
and method12 () : (char -> (UH0 -> UH0)) =
    closure8()
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
and closure7 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
and closure10 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
    let v12 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure7()
    let v13 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure10()
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
and closure11 () () : string =
    let v0 : string = $"runtime.execute_with_options_async"
    v0
and closure13 (v0 : string) () : string =
    v0
and closure12 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v34 : (struct (int32 * string * bool) -> Async<unit>) = x
        let v35 : US12 = US12_0(v34)
        v35 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v33.Value <- x
        let v36 : US12 option = _v33.Value 
        let v47 : US12 = US12_1
        let v48 : US12 = v36 |> Option.defaultValue v47 
        match v48 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v52) -> (* Some *)
            let v53 : int32 = v7.Id
            let v54 : Async<unit> = v52 struct (v53, v27, false)
            do! v54 
            ()
        let v55 : string = $"> {v27}"
        if v5 then
            let v56 : bool = State.trace_state.IsNone
            if v56 then
                let v57 : US0 = US0_0
                let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : int64 option) = method0(v57)
                let v63 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v58, v59, v60, v61, v62) 
                State.trace_state <- v63 
                ()
            let struct (v68 : Mut0, v69 : Mut1, v70 : Mut2, v71 : Mut3, v72 : int64 option) = State.trace_state.Value
            let v83 : bool = State.trace_state.IsNone
            if v83 then
                let v84 : US0 = US0_0
                let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = method0(v84)
                let v90 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v85, v86, v87, v88, v89) 
                State.trace_state <- v90 
                ()
            let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : int64 option) = State.trace_state.Value
            let v110 : US0 = v98.l0
            let v111 : bool = v97.l0
            let v112 : bool = v111 = false
            let v115 : bool =
                if v112 then
                    false
                else
                    let v113 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v110
                    let v114 : bool = 0 >= v113
                    v114
            if v115 then
                let v116 : int64 = v68.l0
                let v117 : int64 = v116 + 1L
                v68.l0 <- v117
                let v118 : bool = State.trace_state.IsNone
                if v118 then
                    let v119 : US0 = US0_0
                    let struct (v120 : Mut0, v121 : Mut1, v122 : Mut2, v123 : Mut3, v124 : int64 option) = method0(v119)
                    let v125 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v120, v121, v122, v123, v124) 
                    State.trace_state <- v125 
                    ()
                let struct (v130 : Mut0, v131 : Mut1, v132 : Mut2, v133 : Mut3, v134 : int64 option) = State.trace_state.Value
                let v145 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v146 : US3 option = None
                let _v146 = ref v146 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v147 : int64 = x
                let v148 : US3 = US3_0(v147)
                v148 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v146.Value <- x
                let v149 : US3 option = _v146.Value 
                let v160 : US3 = US3_1
                let v161 : US3 = v149 |> Option.defaultValue v160 
                let v201 : System.DateTime =
                    match v161 with
                    | US3_1 -> (* None *)
                        let v197 : System.DateTime = System.DateTime.Now
                        v197
                    | US3_0(v165) -> (* Some *)
                        let v166 : System.DateTime = System.DateTime.Now
                        let v169 : (System.DateTime -> int64) = _.Ticks
                        let v170 : int64 = v169 v166
                        let v173 : int64 = v170 - v165
                        let v174 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v175 : System.TimeSpan = v174 v173
                        let v178 : (System.TimeSpan -> int32) = _.Hours
                        let v179 : int32 = v178 v175
                        let v182 : (System.TimeSpan -> int32) = _.Minutes
                        let v183 : int32 = v182 v175
                        let v186 : (System.TimeSpan -> int32) = _.Seconds
                        let v187 : int32 = v186 v175
                        let v190 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v191 : int32 = v190 v175
                        let v194 : System.DateTime = System.DateTime (1, 1, 1, v179, v183, v187, v191)
                        v194
                let v202 : string = method5()
                let v205 : (string -> string) = v201.ToString
                let v206 : string = v205 v202
                let _v145 = v206 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v209 : US3 option = None
                let _v209 = ref v209 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v210 : int64 = x
                let v211 : US3 = US3_0(v210)
                v211 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v209.Value <- x
                let v212 : US3 option = _v209.Value 
                let v223 : US3 = US3_1
                let v224 : US3 = v212 |> Option.defaultValue v223 
                let v264 : System.DateTime =
                    match v224 with
                    | US3_1 -> (* None *)
                        let v260 : System.DateTime = System.DateTime.Now
                        v260
                    | US3_0(v228) -> (* Some *)
                        let v229 : System.DateTime = System.DateTime.Now
                        let v232 : (System.DateTime -> int64) = _.Ticks
                        let v233 : int64 = v232 v229
                        let v236 : int64 = v233 - v228
                        let v237 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v238 : System.TimeSpan = v237 v236
                        let v241 : (System.TimeSpan -> int32) = _.Hours
                        let v242 : int32 = v241 v238
                        let v245 : (System.TimeSpan -> int32) = _.Minutes
                        let v246 : int32 = v245 v238
                        let v249 : (System.TimeSpan -> int32) = _.Seconds
                        let v250 : int32 = v249 v238
                        let v253 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v254 : int32 = v253 v238
                        let v257 : System.DateTime = System.DateTime (1, 1, 1, v242, v246, v250, v254)
                        v257
                let v265 : string = method5()
                let v268 : (string -> string) = v264.ToString
                let v269 : string = v268 v265
                let _v145 = v269 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v272 : string = $"near_sdk::env::block_timestamp()"
                let v273 : uint64 = Fable.Core.RustInterop.emitRustExpr () v272 
                let v274 : US3 option = None
                let _v274 = ref v274 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v275 : int64 = x
                let v276 : US3 = US3_0(v275)
                v276 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v274.Value <- x
                let v277 : US3 option = _v274.Value 
                let v288 : US3 = US3_1
                let v289 : US3 = v277 |> Option.defaultValue v288 
                let v298 : uint64 =
                    match v289 with
                    | US3_1 -> (* None *)
                        v273
                    | US3_0(v293) -> (* Some *)
                        let v294 : (int64 -> uint64) = uint64
                        let v295 : uint64 = v294 v293
                        let v296 : uint64 = v273 - v295
                        v296
                let v299 : uint64 = v298 / 1000000000UL
                let v300 : uint64 = v299 % 60UL
                let v301 : uint64 = v299 / 60UL
                let v302 : uint64 = v301 % 60UL
                let v303 : uint64 = v299 / 3600UL
                let v304 : uint64 = v303 % 24UL
                let v305 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v306 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v304, v302, v300) v305 
                let v307 : string = "fable_library_rust::String_::fromString($0)"
                let v308 : string = Fable.Core.RustInterop.emitRustExpr v306 v307 
                let _v145 = v308 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v309 : US3 option = None
                let _v309 = ref v309 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v310 : int64 = x
                let v311 : US3 = US3_0(v310)
                v311 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v309.Value <- x
                let v312 : US3 option = _v309.Value 
                let v323 : US3 = US3_1
                let v324 : US3 = v312 |> Option.defaultValue v323 
                let v364 : System.DateTime =
                    match v324 with
                    | US3_1 -> (* None *)
                        let v360 : System.DateTime = System.DateTime.Now
                        v360
                    | US3_0(v328) -> (* Some *)
                        let v329 : System.DateTime = System.DateTime.Now
                        let v332 : (System.DateTime -> int64) = _.Ticks
                        let v333 : int64 = v332 v329
                        let v336 : int64 = v333 - v328
                        let v337 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v338 : System.TimeSpan = v337 v336
                        let v341 : (System.TimeSpan -> int32) = _.Hours
                        let v342 : int32 = v341 v338
                        let v345 : (System.TimeSpan -> int32) = _.Minutes
                        let v346 : int32 = v345 v338
                        let v349 : (System.TimeSpan -> int32) = _.Seconds
                        let v350 : int32 = v349 v338
                        let v353 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v354 : int32 = v353 v338
                        let v357 : System.DateTime = System.DateTime (1, 1, 1, v342, v346, v350, v354)
                        v357
                let v365 : string = method6()
                let v368 : (string -> string) = v364.ToString
                let v369 : string = v368 v365
                let _v145 = v369 
                #endif
#if FABLE_COMPILER_PYTHON
                let v372 : US3 option = None
                let _v372 = ref v372 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v373 : int64 = x
                let v374 : US3 = US3_0(v373)
                v374 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v372.Value <- x
                let v375 : US3 option = _v372.Value 
                let v386 : US3 = US3_1
                let v387 : US3 = v375 |> Option.defaultValue v386 
                let v427 : System.DateTime =
                    match v387 with
                    | US3_1 -> (* None *)
                        let v423 : System.DateTime = System.DateTime.Now
                        v423
                    | US3_0(v391) -> (* Some *)
                        let v392 : System.DateTime = System.DateTime.Now
                        let v395 : (System.DateTime -> int64) = _.Ticks
                        let v396 : int64 = v395 v392
                        let v399 : int64 = v396 - v391
                        let v400 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v401 : System.TimeSpan = v400 v399
                        let v404 : (System.TimeSpan -> int32) = _.Hours
                        let v405 : int32 = v404 v401
                        let v408 : (System.TimeSpan -> int32) = _.Minutes
                        let v409 : int32 = v408 v401
                        let v412 : (System.TimeSpan -> int32) = _.Seconds
                        let v413 : int32 = v412 v401
                        let v416 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v417 : int32 = v416 v401
                        let v420 : System.DateTime = System.DateTime (1, 1, 1, v405, v409, v413, v417)
                        v420
                let v428 : string = method6()
                let v431 : (string -> string) = v427.ToString
                let v432 : string = v431 v428
                let _v145 = v432 
                #endif
#else
                let v435 : US3 option = None
                let _v435 = ref v435 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v436 : int64 = x
                let v437 : US3 = US3_0(v436)
                v437 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v435.Value <- x
                let v438 : US3 option = _v435.Value 
                let v449 : US3 = US3_1
                let v450 : US3 = v438 |> Option.defaultValue v449 
                let v490 : System.DateTime =
                    match v450 with
                    | US3_1 -> (* None *)
                        let v486 : System.DateTime = System.DateTime.Now
                        v486
                    | US3_0(v454) -> (* Some *)
                        let v455 : System.DateTime = System.DateTime.Now
                        let v458 : (System.DateTime -> int64) = _.Ticks
                        let v459 : int64 = v458 v455
                        let v462 : int64 = v459 - v454
                        let v463 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v464 : System.TimeSpan = v463 v462
                        let v467 : (System.TimeSpan -> int32) = _.Hours
                        let v468 : int32 = v467 v464
                        let v471 : (System.TimeSpan -> int32) = _.Minutes
                        let v472 : int32 = v471 v464
                        let v475 : (System.TimeSpan -> int32) = _.Seconds
                        let v476 : int32 = v475 v464
                        let v479 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v480 : int32 = v479 v464
                        let v483 : System.DateTime = System.DateTime (1, 1, 1, v468, v472, v476, v480)
                        v483
                let v491 : string = method6()
                let v494 : (string -> string) = v490.ToString
                let v495 : string = v494 v491
                let _v145 = v495 
                #endif
                let v498 : string = _v145 
                let v563 : string = "Verbose"
                let v564 : (unit -> string) = v563.ToLower
                let v565 : string = v564 ()
                let v568 : string = v565.PadLeft (7, ' ')
                let v582 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v583 : string = "inline_colorization::color_bright_black"
                let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
                let v585 : string = "&*$0"
                let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v568 v585 
                let v587 : string = "inline_colorization::color_reset"
                let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
                let v589 : string = "\"{v584}{v586}{v588}\""
                let v590 : string = @$"format!(" + v589 + ")"
                let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v590 
                let v592 : string = "fable_library_rust::String_::fromString($0)"
                let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
                let _v582 = v593 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v594 : string = "inline_colorization::color_bright_black"
                let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
                let v596 : string = "&*$0"
                let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v568 v596 
                let v598 : string = "inline_colorization::color_reset"
                let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
                let v600 : string = "\"{v595}{v597}{v599}\""
                let v601 : string = @$"format!(" + v600 + ")"
                let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v601 
                let v603 : string = "fable_library_rust::String_::fromString($0)"
                let v604 : string = Fable.Core.RustInterop.emitRustExpr v602 v603 
                let _v582 = v604 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v605 : string = "inline_colorization::color_bright_black"
                let v606 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v605 
                let v607 : string = "&*$0"
                let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v568 v607 
                let v609 : string = "inline_colorization::color_reset"
                let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
                let v611 : string = "\"{v606}{v608}{v610}\""
                let v612 : string = @$"format!(" + v611 + ")"
                let v613 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v612 
                let v614 : string = "fable_library_rust::String_::fromString($0)"
                let v615 : string = Fable.Core.RustInterop.emitRustExpr v613 v614 
                let _v582 = v615 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v616 : string = "\u001b[90m"
                let v617 : string = method7()
                let v618 : string = v616 + v568 
                let v619 : string = v618 + v617 
                let _v582 = v619 
                #endif
#if FABLE_COMPILER_PYTHON
                let v620 : string = "\u001b[90m"
                let v621 : string = method7()
                let v622 : string = v620 + v568 
                let v623 : string = v622 + v621 
                let _v582 = v623 
                #endif
#else
                let v624 : string = "\u001b[90m"
                let v625 : string = method7()
                let v626 : string = v624 + v568 
                let v627 : string = v626 + v625 
                let _v582 = v627 
                #endif
                let v628 : string = _v582 
                let v634 : int64 = v130.l0
                let v635 : string = method8()
                let v636 : Mut4 = {l0 = v635} : Mut4
                let v637 : string = v636.l0
                let v638 : (unit -> string) = closure13(v55)
                let v639 : string = $"{v498} {v628} #{v634} %s{v638 ()} / {v637}"
                let v642 : char list = []
                let v643 : (char list -> (char [])) = List.toArray
                let v644 : (char []) = v643 v642
                let v647 : string = v639.TrimStart v644 
                let v665 : char list = []
                let v666 : char list = '/' :: v665 
                let v669 : char list = ' ' :: v666 
                let v672 : (char list -> (char [])) = List.toArray
                let v673 : (char []) = v672 v669
                let v676 : string = v647.TrimEnd v673 
                let v694 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v695 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v676 v695 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v696 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v676 v696 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v697 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v676 v697 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v676 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v676 
                let _v694 = () 
                #endif
#else
                System.Console.WriteLine v676 
                let _v694 = () 
                #endif
                _v694 
                let v698 : (string -> unit) = v69.l0
                v698 v676
        else
            v55 |> System.Console.WriteLine
            ()
        let v699 : string = ""
        let v700 : string = $"{v699}{v27}{v699}"
        let v701 : (string -> unit) = v8.Push
        v701 v700
    }
    |> fun x -> _v26 <- Some x
    let v702 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v702 
    #endif
    let v703 : Async<unit> = _v10 
    let v708 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v708 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v708 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v708 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v708 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v708 = () 
    #endif
#else
    let v709 : (Async<unit> -> unit) = Async.StartImmediate
    v709 v703
    let _v708 = () 
    #endif
    _v708 
    ()
and closure14 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v34 : (struct (int32 * string * bool) -> Async<unit>) = x
        let v35 : US12 = US12_0(v34)
        v35 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v33.Value <- x
        let v36 : US12 option = _v33.Value 
        let v47 : US12 = US12_1
        let v48 : US12 = v36 |> Option.defaultValue v47 
        match v48 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v52) -> (* Some *)
            let v53 : int32 = v7.Id
            let v54 : Async<unit> = v52 struct (v53, v27, true)
            do! v54 
            ()
        let v55 : string = $"! {v27}"
        if v5 then
            let v56 : bool = State.trace_state.IsNone
            if v56 then
                let v57 : US0 = US0_0
                let struct (v58 : Mut0, v59 : Mut1, v60 : Mut2, v61 : Mut3, v62 : int64 option) = method0(v57)
                let v63 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v58, v59, v60, v61, v62) 
                State.trace_state <- v63 
                ()
            let struct (v68 : Mut0, v69 : Mut1, v70 : Mut2, v71 : Mut3, v72 : int64 option) = State.trace_state.Value
            let v83 : bool = State.trace_state.IsNone
            if v83 then
                let v84 : US0 = US0_0
                let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = method0(v84)
                let v90 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v85, v86, v87, v88, v89) 
                State.trace_state <- v90 
                ()
            let struct (v95 : Mut0, v96 : Mut1, v97 : Mut2, v98 : Mut3, v99 : int64 option) = State.trace_state.Value
            let v110 : US0 = v98.l0
            let v111 : bool = v97.l0
            let v112 : bool = v111 = false
            let v115 : bool =
                if v112 then
                    false
                else
                    let v113 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v110
                    let v114 : bool = 0 >= v113
                    v114
            if v115 then
                let v116 : int64 = v68.l0
                let v117 : int64 = v116 + 1L
                v68.l0 <- v117
                let v118 : bool = State.trace_state.IsNone
                if v118 then
                    let v119 : US0 = US0_0
                    let struct (v120 : Mut0, v121 : Mut1, v122 : Mut2, v123 : Mut3, v124 : int64 option) = method0(v119)
                    let v125 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v120, v121, v122, v123, v124) 
                    State.trace_state <- v125 
                    ()
                let struct (v130 : Mut0, v131 : Mut1, v132 : Mut2, v133 : Mut3, v134 : int64 option) = State.trace_state.Value
                let v145 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v146 : US3 option = None
                let _v146 = ref v146 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v147 : int64 = x
                let v148 : US3 = US3_0(v147)
                v148 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v146.Value <- x
                let v149 : US3 option = _v146.Value 
                let v160 : US3 = US3_1
                let v161 : US3 = v149 |> Option.defaultValue v160 
                let v201 : System.DateTime =
                    match v161 with
                    | US3_1 -> (* None *)
                        let v197 : System.DateTime = System.DateTime.Now
                        v197
                    | US3_0(v165) -> (* Some *)
                        let v166 : System.DateTime = System.DateTime.Now
                        let v169 : (System.DateTime -> int64) = _.Ticks
                        let v170 : int64 = v169 v166
                        let v173 : int64 = v170 - v165
                        let v174 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v175 : System.TimeSpan = v174 v173
                        let v178 : (System.TimeSpan -> int32) = _.Hours
                        let v179 : int32 = v178 v175
                        let v182 : (System.TimeSpan -> int32) = _.Minutes
                        let v183 : int32 = v182 v175
                        let v186 : (System.TimeSpan -> int32) = _.Seconds
                        let v187 : int32 = v186 v175
                        let v190 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v191 : int32 = v190 v175
                        let v194 : System.DateTime = System.DateTime (1, 1, 1, v179, v183, v187, v191)
                        v194
                let v202 : string = method5()
                let v205 : (string -> string) = v201.ToString
                let v206 : string = v205 v202
                let _v145 = v206 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v209 : US3 option = None
                let _v209 = ref v209 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v210 : int64 = x
                let v211 : US3 = US3_0(v210)
                v211 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v209.Value <- x
                let v212 : US3 option = _v209.Value 
                let v223 : US3 = US3_1
                let v224 : US3 = v212 |> Option.defaultValue v223 
                let v264 : System.DateTime =
                    match v224 with
                    | US3_1 -> (* None *)
                        let v260 : System.DateTime = System.DateTime.Now
                        v260
                    | US3_0(v228) -> (* Some *)
                        let v229 : System.DateTime = System.DateTime.Now
                        let v232 : (System.DateTime -> int64) = _.Ticks
                        let v233 : int64 = v232 v229
                        let v236 : int64 = v233 - v228
                        let v237 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v238 : System.TimeSpan = v237 v236
                        let v241 : (System.TimeSpan -> int32) = _.Hours
                        let v242 : int32 = v241 v238
                        let v245 : (System.TimeSpan -> int32) = _.Minutes
                        let v246 : int32 = v245 v238
                        let v249 : (System.TimeSpan -> int32) = _.Seconds
                        let v250 : int32 = v249 v238
                        let v253 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v254 : int32 = v253 v238
                        let v257 : System.DateTime = System.DateTime (1, 1, 1, v242, v246, v250, v254)
                        v257
                let v265 : string = method5()
                let v268 : (string -> string) = v264.ToString
                let v269 : string = v268 v265
                let _v145 = v269 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v272 : string = $"near_sdk::env::block_timestamp()"
                let v273 : uint64 = Fable.Core.RustInterop.emitRustExpr () v272 
                let v274 : US3 option = None
                let _v274 = ref v274 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v275 : int64 = x
                let v276 : US3 = US3_0(v275)
                v276 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v274.Value <- x
                let v277 : US3 option = _v274.Value 
                let v288 : US3 = US3_1
                let v289 : US3 = v277 |> Option.defaultValue v288 
                let v298 : uint64 =
                    match v289 with
                    | US3_1 -> (* None *)
                        v273
                    | US3_0(v293) -> (* Some *)
                        let v294 : (int64 -> uint64) = uint64
                        let v295 : uint64 = v294 v293
                        let v296 : uint64 = v273 - v295
                        v296
                let v299 : uint64 = v298 / 1000000000UL
                let v300 : uint64 = v299 % 60UL
                let v301 : uint64 = v299 / 60UL
                let v302 : uint64 = v301 % 60UL
                let v303 : uint64 = v299 / 3600UL
                let v304 : uint64 = v303 % 24UL
                let v305 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
                let v306 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v304, v302, v300) v305 
                let v307 : string = "fable_library_rust::String_::fromString($0)"
                let v308 : string = Fable.Core.RustInterop.emitRustExpr v306 v307 
                let _v145 = v308 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v309 : US3 option = None
                let _v309 = ref v309 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v310 : int64 = x
                let v311 : US3 = US3_0(v310)
                v311 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v309.Value <- x
                let v312 : US3 option = _v309.Value 
                let v323 : US3 = US3_1
                let v324 : US3 = v312 |> Option.defaultValue v323 
                let v364 : System.DateTime =
                    match v324 with
                    | US3_1 -> (* None *)
                        let v360 : System.DateTime = System.DateTime.Now
                        v360
                    | US3_0(v328) -> (* Some *)
                        let v329 : System.DateTime = System.DateTime.Now
                        let v332 : (System.DateTime -> int64) = _.Ticks
                        let v333 : int64 = v332 v329
                        let v336 : int64 = v333 - v328
                        let v337 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v338 : System.TimeSpan = v337 v336
                        let v341 : (System.TimeSpan -> int32) = _.Hours
                        let v342 : int32 = v341 v338
                        let v345 : (System.TimeSpan -> int32) = _.Minutes
                        let v346 : int32 = v345 v338
                        let v349 : (System.TimeSpan -> int32) = _.Seconds
                        let v350 : int32 = v349 v338
                        let v353 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v354 : int32 = v353 v338
                        let v357 : System.DateTime = System.DateTime (1, 1, 1, v342, v346, v350, v354)
                        v357
                let v365 : string = method6()
                let v368 : (string -> string) = v364.ToString
                let v369 : string = v368 v365
                let _v145 = v369 
                #endif
#if FABLE_COMPILER_PYTHON
                let v372 : US3 option = None
                let _v372 = ref v372 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v373 : int64 = x
                let v374 : US3 = US3_0(v373)
                v374 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v372.Value <- x
                let v375 : US3 option = _v372.Value 
                let v386 : US3 = US3_1
                let v387 : US3 = v375 |> Option.defaultValue v386 
                let v427 : System.DateTime =
                    match v387 with
                    | US3_1 -> (* None *)
                        let v423 : System.DateTime = System.DateTime.Now
                        v423
                    | US3_0(v391) -> (* Some *)
                        let v392 : System.DateTime = System.DateTime.Now
                        let v395 : (System.DateTime -> int64) = _.Ticks
                        let v396 : int64 = v395 v392
                        let v399 : int64 = v396 - v391
                        let v400 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v401 : System.TimeSpan = v400 v399
                        let v404 : (System.TimeSpan -> int32) = _.Hours
                        let v405 : int32 = v404 v401
                        let v408 : (System.TimeSpan -> int32) = _.Minutes
                        let v409 : int32 = v408 v401
                        let v412 : (System.TimeSpan -> int32) = _.Seconds
                        let v413 : int32 = v412 v401
                        let v416 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v417 : int32 = v416 v401
                        let v420 : System.DateTime = System.DateTime (1, 1, 1, v405, v409, v413, v417)
                        v420
                let v428 : string = method6()
                let v431 : (string -> string) = v427.ToString
                let v432 : string = v431 v428
                let _v145 = v432 
                #endif
#else
                let v435 : US3 option = None
                let _v435 = ref v435 
                match v134 with
                | Some x -> (
                (fun () ->
                (fun () ->
                let v436 : int64 = x
                let v437 : US3 = US3_0(v436)
                v437 
                )
                |> fun x -> x () |> Some
                ) () ) | None -> None
                |> fun x -> _v435.Value <- x
                let v438 : US3 option = _v435.Value 
                let v449 : US3 = US3_1
                let v450 : US3 = v438 |> Option.defaultValue v449 
                let v490 : System.DateTime =
                    match v450 with
                    | US3_1 -> (* None *)
                        let v486 : System.DateTime = System.DateTime.Now
                        v486
                    | US3_0(v454) -> (* Some *)
                        let v455 : System.DateTime = System.DateTime.Now
                        let v458 : (System.DateTime -> int64) = _.Ticks
                        let v459 : int64 = v458 v455
                        let v462 : int64 = v459 - v454
                        let v463 : (int64 -> System.TimeSpan) = System.TimeSpan 
                        let v464 : System.TimeSpan = v463 v462
                        let v467 : (System.TimeSpan -> int32) = _.Hours
                        let v468 : int32 = v467 v464
                        let v471 : (System.TimeSpan -> int32) = _.Minutes
                        let v472 : int32 = v471 v464
                        let v475 : (System.TimeSpan -> int32) = _.Seconds
                        let v476 : int32 = v475 v464
                        let v479 : (System.TimeSpan -> int32) = _.Milliseconds
                        let v480 : int32 = v479 v464
                        let v483 : System.DateTime = System.DateTime (1, 1, 1, v468, v472, v476, v480)
                        v483
                let v491 : string = method6()
                let v494 : (string -> string) = v490.ToString
                let v495 : string = v494 v491
                let _v145 = v495 
                #endif
                let v498 : string = _v145 
                let v563 : string = "Verbose"
                let v564 : (unit -> string) = v563.ToLower
                let v565 : string = v564 ()
                let v568 : string = v565.PadLeft (7, ' ')
                let v582 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v583 : string = "inline_colorization::color_bright_black"
                let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
                let v585 : string = "&*$0"
                let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v568 v585 
                let v587 : string = "inline_colorization::color_reset"
                let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
                let v589 : string = "\"{v584}{v586}{v588}\""
                let v590 : string = @$"format!(" + v589 + ")"
                let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v590 
                let v592 : string = "fable_library_rust::String_::fromString($0)"
                let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
                let _v582 = v593 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v594 : string = "inline_colorization::color_bright_black"
                let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
                let v596 : string = "&*$0"
                let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v568 v596 
                let v598 : string = "inline_colorization::color_reset"
                let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
                let v600 : string = "\"{v595}{v597}{v599}\""
                let v601 : string = @$"format!(" + v600 + ")"
                let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v601 
                let v603 : string = "fable_library_rust::String_::fromString($0)"
                let v604 : string = Fable.Core.RustInterop.emitRustExpr v602 v603 
                let _v582 = v604 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v605 : string = "inline_colorization::color_bright_black"
                let v606 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v605 
                let v607 : string = "&*$0"
                let v608 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v568 v607 
                let v609 : string = "inline_colorization::color_reset"
                let v610 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v609 
                let v611 : string = "\"{v606}{v608}{v610}\""
                let v612 : string = @$"format!(" + v611 + ")"
                let v613 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v612 
                let v614 : string = "fable_library_rust::String_::fromString($0)"
                let v615 : string = Fable.Core.RustInterop.emitRustExpr v613 v614 
                let _v582 = v615 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                let v616 : string = "\u001b[90m"
                let v617 : string = method7()
                let v618 : string = v616 + v568 
                let v619 : string = v618 + v617 
                let _v582 = v619 
                #endif
#if FABLE_COMPILER_PYTHON
                let v620 : string = "\u001b[90m"
                let v621 : string = method7()
                let v622 : string = v620 + v568 
                let v623 : string = v622 + v621 
                let _v582 = v623 
                #endif
#else
                let v624 : string = "\u001b[90m"
                let v625 : string = method7()
                let v626 : string = v624 + v568 
                let v627 : string = v626 + v625 
                let _v582 = v627 
                #endif
                let v628 : string = _v582 
                let v634 : int64 = v130.l0
                let v635 : string = method8()
                let v636 : Mut4 = {l0 = v635} : Mut4
                let v637 : string = v636.l0
                let v638 : (unit -> string) = closure13(v55)
                let v639 : string = $"{v498} {v628} #{v634} %s{v638 ()} / {v637}"
                let v642 : char list = []
                let v643 : (char list -> (char [])) = List.toArray
                let v644 : (char []) = v643 v642
                let v647 : string = v639.TrimStart v644 
                let v665 : char list = []
                let v666 : char list = '/' :: v665 
                let v669 : char list = ' ' :: v666 
                let v672 : (char list -> (char [])) = List.toArray
                let v673 : (char []) = v672 v669
                let v676 : string = v647.TrimEnd v673 
                let v694 : unit = ()
                
#if FABLE_COMPILER || WASM || CONTRACT
                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                let v695 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v676 v695 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_RUST && WASM
                let v696 : string = @"println!(""{}"", $0)"
                Fable.Core.RustInterop.emitRustExpr v676 v696 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                let v697 : string = $"near_sdk::log!(\"{{}}\", $0)"
                Fable.Core.RustInterop.emitRustExpr v676 v697 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_TYPESCRIPT
                System.Console.WriteLine v676 
                let _v694 = () 
                #endif
#if FABLE_COMPILER_PYTHON
                System.Console.WriteLine v676 
                let _v694 = () 
                #endif
#else
                System.Console.WriteLine v676 
                let _v694 = () 
                #endif
                _v694 
                let v698 : (string -> unit) = v69.l0
                v698 v676
        else
            v55 |> System.Console.WriteLine
            ()
        let v699 : string = "\u001b[7;4m"
        let v700 : string = "\u001b[0m"
        let v701 : string = $"{v699}{v27}{v700}"
        let v702 : (string -> unit) = v8.Push
        v702 v701
    }
    |> fun x -> _v26 <- Some x
    let v703 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v703 
    #endif
    let v704 : Async<unit> = _v10 
    let v709 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v709 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v709 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v709 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v709 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v709 = () 
    #endif
#else
    let v710 : (Async<unit> -> unit) = Async.StartImmediate
    v710 v704
    let _v709 = () 
    #endif
    _v709 
    ()
and closure15 (v0 : System.Diagnostics.Process) () : unit =
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
and closure16 () () : string =
    let v0 : string = $"runtime.execute_with_options_async / WaitForExitAsync"
    v0
and closure17 () () : string =
    let v0 : string = $"runtime.execute_with_options_async"
    v0
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
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v52 : string = x
    let v53 : US1 = US1_0(v52)
    v53 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v51.Value <- x
    let v54 : US1 option = _v51.Value 
    let v65 : US1 = US1_1
    let v66 : US1 = v54 |> Option.defaultValue v65 
    let v73 : string =
        match v66 with
        | US1_1 -> (* None *)
            let v71 : string = ""
            v71
        | US1_0(v70) -> (* Some *)
            v70
    let v74 : bool = State.trace_state.IsNone
    if v74 then
        let v75 : US0 = US0_0
        let struct (v76 : Mut0, v77 : Mut1, v78 : Mut2, v79 : Mut3, v80 : int64 option) = method0(v75)
        let v81 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v76, v77, v78, v79, v80) 
        State.trace_state <- v81 
        ()
    let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
    let v101 : bool = State.trace_state.IsNone
    if v101 then
        let v102 : US0 = US0_0
        let struct (v103 : Mut0, v104 : Mut1, v105 : Mut2, v106 : Mut3, v107 : int64 option) = method0(v102)
        let v108 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v103, v104, v105, v106, v107) 
        State.trace_state <- v108 
        ()
    let struct (v113 : Mut0, v114 : Mut1, v115 : Mut2, v116 : Mut3, v117 : int64 option) = State.trace_state.Value
    let v128 : US0 = v116.l0
    let v129 : bool = v115.l0
    let v130 : bool = v129 = false
    let v133 : bool =
        if v130 then
            false
        else
            let v131 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v128
            let v132 : bool = 1 >= v131
            v132
    if v133 then
        let v134 : int64 = v86.l0
        let v135 : int64 = v134 + 1L
        v86.l0 <- v135
        let v136 : bool = State.trace_state.IsNone
        if v136 then
            let v137 : US0 = US0_0
            let struct (v138 : Mut0, v139 : Mut1, v140 : Mut2, v141 : Mut3, v142 : int64 option) = method0(v137)
            let v143 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v138, v139, v140, v141, v142) 
            State.trace_state <- v143 
            ()
        let struct (v148 : Mut0, v149 : Mut1, v150 : Mut2, v151 : Mut3, v152 : int64 option) = State.trace_state.Value
        let v163 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v164 : US3 option = None
        let _v164 = ref v164 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v165 : int64 = x
        let v166 : US3 = US3_0(v165)
        v166 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v164.Value <- x
        let v167 : US3 option = _v164.Value 
        let v178 : US3 = US3_1
        let v179 : US3 = v167 |> Option.defaultValue v178 
        let v219 : System.DateTime =
            match v179 with
            | US3_1 -> (* None *)
                let v215 : System.DateTime = System.DateTime.Now
                v215
            | US3_0(v183) -> (* Some *)
                let v184 : System.DateTime = System.DateTime.Now
                let v187 : (System.DateTime -> int64) = _.Ticks
                let v188 : int64 = v187 v184
                let v191 : int64 = v188 - v183
                let v192 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v193 : System.TimeSpan = v192 v191
                let v196 : (System.TimeSpan -> int32) = _.Hours
                let v197 : int32 = v196 v193
                let v200 : (System.TimeSpan -> int32) = _.Minutes
                let v201 : int32 = v200 v193
                let v204 : (System.TimeSpan -> int32) = _.Seconds
                let v205 : int32 = v204 v193
                let v208 : (System.TimeSpan -> int32) = _.Milliseconds
                let v209 : int32 = v208 v193
                let v212 : System.DateTime = System.DateTime (1, 1, 1, v197, v201, v205, v209)
                v212
        let v220 : string = method5()
        let v223 : (string -> string) = v219.ToString
        let v224 : string = v223 v220
        let _v163 = v224 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v227 : US3 option = None
        let _v227 = ref v227 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v228 : int64 = x
        let v229 : US3 = US3_0(v228)
        v229 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v227.Value <- x
        let v230 : US3 option = _v227.Value 
        let v241 : US3 = US3_1
        let v242 : US3 = v230 |> Option.defaultValue v241 
        let v282 : System.DateTime =
            match v242 with
            | US3_1 -> (* None *)
                let v278 : System.DateTime = System.DateTime.Now
                v278
            | US3_0(v246) -> (* Some *)
                let v247 : System.DateTime = System.DateTime.Now
                let v250 : (System.DateTime -> int64) = _.Ticks
                let v251 : int64 = v250 v247
                let v254 : int64 = v251 - v246
                let v255 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v256 : System.TimeSpan = v255 v254
                let v259 : (System.TimeSpan -> int32) = _.Hours
                let v260 : int32 = v259 v256
                let v263 : (System.TimeSpan -> int32) = _.Minutes
                let v264 : int32 = v263 v256
                let v267 : (System.TimeSpan -> int32) = _.Seconds
                let v268 : int32 = v267 v256
                let v271 : (System.TimeSpan -> int32) = _.Milliseconds
                let v272 : int32 = v271 v256
                let v275 : System.DateTime = System.DateTime (1, 1, 1, v260, v264, v268, v272)
                v275
        let v283 : string = method5()
        let v286 : (string -> string) = v282.ToString
        let v287 : string = v286 v283
        let _v163 = v287 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v290 : string = $"near_sdk::env::block_timestamp()"
        let v291 : uint64 = Fable.Core.RustInterop.emitRustExpr () v290 
        let v292 : US3 option = None
        let _v292 = ref v292 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v293 : int64 = x
        let v294 : US3 = US3_0(v293)
        v294 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v292.Value <- x
        let v295 : US3 option = _v292.Value 
        let v306 : US3 = US3_1
        let v307 : US3 = v295 |> Option.defaultValue v306 
        let v316 : uint64 =
            match v307 with
            | US3_1 -> (* None *)
                v291
            | US3_0(v311) -> (* Some *)
                let v312 : (int64 -> uint64) = uint64
                let v313 : uint64 = v312 v311
                let v314 : uint64 = v291 - v313
                v314
        let v317 : uint64 = v316 / 1000000000UL
        let v318 : uint64 = v317 % 60UL
        let v319 : uint64 = v317 / 60UL
        let v320 : uint64 = v319 % 60UL
        let v321 : uint64 = v317 / 3600UL
        let v322 : uint64 = v321 % 24UL
        let v323 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v324 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v322, v320, v318) v323 
        let v325 : string = "fable_library_rust::String_::fromString($0)"
        let v326 : string = Fable.Core.RustInterop.emitRustExpr v324 v325 
        let _v163 = v326 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v327 : US3 option = None
        let _v327 = ref v327 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v328 : int64 = x
        let v329 : US3 = US3_0(v328)
        v329 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v327.Value <- x
        let v330 : US3 option = _v327.Value 
        let v341 : US3 = US3_1
        let v342 : US3 = v330 |> Option.defaultValue v341 
        let v382 : System.DateTime =
            match v342 with
            | US3_1 -> (* None *)
                let v378 : System.DateTime = System.DateTime.Now
                v378
            | US3_0(v346) -> (* Some *)
                let v347 : System.DateTime = System.DateTime.Now
                let v350 : (System.DateTime -> int64) = _.Ticks
                let v351 : int64 = v350 v347
                let v354 : int64 = v351 - v346
                let v355 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v356 : System.TimeSpan = v355 v354
                let v359 : (System.TimeSpan -> int32) = _.Hours
                let v360 : int32 = v359 v356
                let v363 : (System.TimeSpan -> int32) = _.Minutes
                let v364 : int32 = v363 v356
                let v367 : (System.TimeSpan -> int32) = _.Seconds
                let v368 : int32 = v367 v356
                let v371 : (System.TimeSpan -> int32) = _.Milliseconds
                let v372 : int32 = v371 v356
                let v375 : System.DateTime = System.DateTime (1, 1, 1, v360, v364, v368, v372)
                v375
        let v383 : string = method6()
        let v386 : (string -> string) = v382.ToString
        let v387 : string = v386 v383
        let _v163 = v387 
        #endif
#if FABLE_COMPILER_PYTHON
        let v390 : US3 option = None
        let _v390 = ref v390 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v391 : int64 = x
        let v392 : US3 = US3_0(v391)
        v392 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v390.Value <- x
        let v393 : US3 option = _v390.Value 
        let v404 : US3 = US3_1
        let v405 : US3 = v393 |> Option.defaultValue v404 
        let v445 : System.DateTime =
            match v405 with
            | US3_1 -> (* None *)
                let v441 : System.DateTime = System.DateTime.Now
                v441
            | US3_0(v409) -> (* Some *)
                let v410 : System.DateTime = System.DateTime.Now
                let v413 : (System.DateTime -> int64) = _.Ticks
                let v414 : int64 = v413 v410
                let v417 : int64 = v414 - v409
                let v418 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v419 : System.TimeSpan = v418 v417
                let v422 : (System.TimeSpan -> int32) = _.Hours
                let v423 : int32 = v422 v419
                let v426 : (System.TimeSpan -> int32) = _.Minutes
                let v427 : int32 = v426 v419
                let v430 : (System.TimeSpan -> int32) = _.Seconds
                let v431 : int32 = v430 v419
                let v434 : (System.TimeSpan -> int32) = _.Milliseconds
                let v435 : int32 = v434 v419
                let v438 : System.DateTime = System.DateTime (1, 1, 1, v423, v427, v431, v435)
                v438
        let v446 : string = method6()
        let v449 : (string -> string) = v445.ToString
        let v450 : string = v449 v446
        let _v163 = v450 
        #endif
#else
        let v453 : US3 option = None
        let _v453 = ref v453 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v454 : int64 = x
        let v455 : US3 = US3_0(v454)
        v455 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v453.Value <- x
        let v456 : US3 option = _v453.Value 
        let v467 : US3 = US3_1
        let v468 : US3 = v456 |> Option.defaultValue v467 
        let v508 : System.DateTime =
            match v468 with
            | US3_1 -> (* None *)
                let v504 : System.DateTime = System.DateTime.Now
                v504
            | US3_0(v472) -> (* Some *)
                let v473 : System.DateTime = System.DateTime.Now
                let v476 : (System.DateTime -> int64) = _.Ticks
                let v477 : int64 = v476 v473
                let v480 : int64 = v477 - v472
                let v481 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v482 : System.TimeSpan = v481 v480
                let v485 : (System.TimeSpan -> int32) = _.Hours
                let v486 : int32 = v485 v482
                let v489 : (System.TimeSpan -> int32) = _.Minutes
                let v490 : int32 = v489 v482
                let v493 : (System.TimeSpan -> int32) = _.Seconds
                let v494 : int32 = v493 v482
                let v497 : (System.TimeSpan -> int32) = _.Milliseconds
                let v498 : int32 = v497 v482
                let v501 : System.DateTime = System.DateTime (1, 1, 1, v486, v490, v494, v498)
                v501
        let v509 : string = method6()
        let v512 : (string -> string) = v508.ToString
        let v513 : string = v512 v509
        let _v163 = v513 
        #endif
        let v516 : string = _v163 
        let v581 : string = "Debug"
        let v582 : (unit -> string) = v581.ToLower
        let v583 : string = v582 ()
        let v586 : string = v583.PadLeft (7, ' ')
        let v600 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v601 : string = "inline_colorization::color_bright_blue"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "&*$0"
        let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v586 v603 
        let v605 : string = "inline_colorization::color_reset"
        let v606 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "\"{v602}{v604}{v606}\""
        let v608 : string = @$"format!(" + v607 + ")"
        let v609 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "fable_library_rust::String_::fromString($0)"
        let v611 : string = Fable.Core.RustInterop.emitRustExpr v609 v610 
        let _v600 = v611 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v612 : string = "inline_colorization::color_bright_blue"
        let v613 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v612 
        let v614 : string = "&*$0"
        let v615 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v586 v614 
        let v616 : string = "inline_colorization::color_reset"
        let v617 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v616 
        let v618 : string = "\"{v613}{v615}{v617}\""
        let v619 : string = @$"format!(" + v618 + ")"
        let v620 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v619 
        let v621 : string = "fable_library_rust::String_::fromString($0)"
        let v622 : string = Fable.Core.RustInterop.emitRustExpr v620 v621 
        let _v600 = v622 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v623 : string = "inline_colorization::color_bright_blue"
        let v624 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v623 
        let v625 : string = "&*$0"
        let v626 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v586 v625 
        let v627 : string = "inline_colorization::color_reset"
        let v628 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v627 
        let v629 : string = "\"{v624}{v626}{v628}\""
        let v630 : string = @$"format!(" + v629 + ")"
        let v631 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v630 
        let v632 : string = "fable_library_rust::String_::fromString($0)"
        let v633 : string = Fable.Core.RustInterop.emitRustExpr v631 v632 
        let _v600 = v633 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v634 : string = "\u001b[94m"
        let v635 : string = method7()
        let v636 : string = v634 + v586 
        let v637 : string = v636 + v635 
        let _v600 = v637 
        #endif
#if FABLE_COMPILER_PYTHON
        let v638 : string = "\u001b[94m"
        let v639 : string = method7()
        let v640 : string = v638 + v586 
        let v641 : string = v640 + v639 
        let _v600 = v641 
        #endif
#else
        let v642 : string = "\u001b[94m"
        let v643 : string = method7()
        let v644 : string = v642 + v586 
        let v645 : string = v644 + v643 
        let _v600 = v645 
        #endif
        let v646 : string = _v600 
        let v652 : int64 = v148.l0
        let v653 : string = method8()
        let v654 : Mut4 = {l0 = v653} : Mut4
        let v655 : string = "{ "
        let v656 : string = $"{v655}"
        let v659 : string = v654.l0
        let v660 : string = v659 + v656 
        v654.l0 <- v660
        let v661 : string = "options"
        let v662 : string = $"{v661}"
        let v665 : string = v654.l0
        let v666 : string = v665 + v662 
        v654.l0 <- v666
        let v667 : string = " = "
        let v668 : string = $"{v667}"
        let v671 : string = v654.l0
        let v672 : string = v671 + v668 
        v654.l0 <- v672
        let v673 : string = $"{v655}"
        let v676 : string = v654.l0
        let v677 : string = v676 + v673 
        v654.l0 <- v677
        let v678 : string = "command"
        let v679 : string = $"{v678}"
        let v682 : string = v654.l0
        let v683 : string = v682 + v679 
        v654.l0 <- v683
        let v684 : string = $"{v667}"
        let v687 : string = v654.l0
        let v688 : string = v687 + v684 
        v654.l0 <- v688
        let v689 : string = $"{v0}"
        let v692 : string = v654.l0
        let v693 : string = v692 + v689 
        v654.l0 <- v693
        let v694 : string = "; "
        let v695 : string = $"{v694}"
        let v698 : string = v654.l0
        let v699 : string = v698 + v695 
        v654.l0 <- v699
        let v700 : string = "cancellation_token"
        let v701 : string = $"{v700}"
        let v704 : string = v654.l0
        let v705 : string = v704 + v701 
        v654.l0 <- v705
        let v706 : string = $"{v667}"
        let v709 : string = v654.l0
        let v710 : string = v709 + v706 
        v654.l0 <- v710
        let v711 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v712 : string = "format!(\"{:#?}\", $0)"
        let v713 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v712 
        let v714 : string = "fable_library_rust::String_::fromString($0)"
        let v715 : string = Fable.Core.RustInterop.emitRustExpr v713 v714 
        let _v711 = v715 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v716 : string = "format!(\"{:#?}\", $0)"
        let v717 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v716 
        let v718 : string = "fable_library_rust::String_::fromString($0)"
        let v719 : string = Fable.Core.RustInterop.emitRustExpr v717 v718 
        let _v711 = v719 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v720 : string = "format!(\"{:#?}\", $0)"
        let v721 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v720 
        let v722 : string = "fable_library_rust::String_::fromString($0)"
        let v723 : string = Fable.Core.RustInterop.emitRustExpr v721 v722 
        let _v711 = v723 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v724 : string = $"%A{v1}"
        let _v711 = v724 
        #endif
#if FABLE_COMPILER_PYTHON
        let v727 : string = $"%A{v1}"
        let _v711 = v727 
        #endif
#else
        let v730 : string = $"%A{v1}"
        let _v711 = v730 
        #endif
        let v733 : string = _v711 
        let v738 : string = $"{v733}"
        let v741 : string = v654.l0
        let v742 : string = v741 + v738 
        v654.l0 <- v742
        let v743 : string = $"{v694}"
        let v746 : string = v654.l0
        let v747 : string = v746 + v743 
        v654.l0 <- v747
        let v748 : string = "environment_variables"
        let v749 : string = $"{v748}"
        let v752 : string = v654.l0
        let v753 : string = v752 + v749 
        v654.l0 <- v753
        let v754 : string = $"{v667}"
        let v757 : string = v654.l0
        let v758 : string = v757 + v754 
        v654.l0 <- v758
        let v759 : string = $"%A{v2}"
        let v762 : string = $"{v759}"
        let v765 : string = v654.l0
        let v766 : string = v765 + v762 
        v654.l0 <- v766
        let v767 : string = $"{v694}"
        let v770 : string = v654.l0
        let v771 : string = v770 + v767 
        v654.l0 <- v771
        let v772 : string = "on_line"
        let v773 : string = $"{v772}"
        let v776 : string = v654.l0
        let v777 : string = v776 + v773 
        v654.l0 <- v777
        let v778 : string = $"{v667}"
        let v781 : string = v654.l0
        let v782 : string = v781 + v778 
        v654.l0 <- v782
        let v783 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v784 : string = "format!(\"{:#?}\", $0)"
        let v785 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v784 
        let v786 : string = "fable_library_rust::String_::fromString($0)"
        let v787 : string = Fable.Core.RustInterop.emitRustExpr v785 v786 
        let _v783 = v787 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v788 : string = "format!(\"{:#?}\", $0)"
        let v789 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v788 
        let v790 : string = "fable_library_rust::String_::fromString($0)"
        let v791 : string = Fable.Core.RustInterop.emitRustExpr v789 v790 
        let _v783 = v791 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v792 : string = "format!(\"{:#?}\", $0)"
        let v793 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v792 
        let v794 : string = "fable_library_rust::String_::fromString($0)"
        let v795 : string = Fable.Core.RustInterop.emitRustExpr v793 v794 
        let _v783 = v795 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v796 : string = $"%A{v3}"
        let _v783 = v796 
        #endif
#if FABLE_COMPILER_PYTHON
        let v799 : string = $"%A{v3}"
        let _v783 = v799 
        #endif
#else
        let v802 : string = $"%A{v3}"
        let _v783 = v802 
        #endif
        let v805 : string = _v783 
        let v810 : string = $"{v805}"
        let v813 : string = v654.l0
        let v814 : string = v813 + v810 
        v654.l0 <- v814
        let v815 : string = $"{v694}"
        let v818 : string = v654.l0
        let v819 : string = v818 + v815 
        v654.l0 <- v819
        let v820 : string = "stdin"
        let v821 : string = $"{v820}"
        let v824 : string = v654.l0
        let v825 : string = v824 + v821 
        v654.l0 <- v825
        let v826 : string = $"{v667}"
        let v829 : string = v654.l0
        let v830 : string = v829 + v826 
        v654.l0 <- v830
        let v831 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v832 : string = "format!(\"{:#?}\", $0)"
        let v833 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v832 
        let v834 : string = "fable_library_rust::String_::fromString($0)"
        let v835 : string = Fable.Core.RustInterop.emitRustExpr v833 v834 
        let _v831 = v835 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v836 : string = "format!(\"{:#?}\", $0)"
        let v837 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v836 
        let v838 : string = "fable_library_rust::String_::fromString($0)"
        let v839 : string = Fable.Core.RustInterop.emitRustExpr v837 v838 
        let _v831 = v839 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v840 : string = "format!(\"{:#?}\", $0)"
        let v841 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v840 
        let v842 : string = "fable_library_rust::String_::fromString($0)"
        let v843 : string = Fable.Core.RustInterop.emitRustExpr v841 v842 
        let _v831 = v843 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v844 : string = $"%A{v4}"
        let _v831 = v844 
        #endif
#if FABLE_COMPILER_PYTHON
        let v847 : string = $"%A{v4}"
        let _v831 = v847 
        #endif
#else
        let v850 : string = $"%A{v4}"
        let _v831 = v850 
        #endif
        let v853 : string = _v831 
        let v858 : string = $"{v853}"
        let v861 : string = v654.l0
        let v862 : string = v861 + v858 
        v654.l0 <- v862
        let v863 : string = $"{v694}"
        let v866 : string = v654.l0
        let v867 : string = v866 + v863 
        v654.l0 <- v867
        let v868 : string = "trace"
        let v869 : string = $"{v868}"
        let v872 : string = v654.l0
        let v873 : string = v872 + v869 
        v654.l0 <- v873
        let v874 : string = $"{v667}"
        let v877 : string = v654.l0
        let v878 : string = v877 + v874 
        v654.l0 <- v878
        let v881 : string =
            if v5 then
                let v879 : string = "true"
                v879
            else
                let v880 : string = "false"
                v880
        let v882 : string = $"{v881}"
        let v885 : string = v654.l0
        let v886 : string = v885 + v882 
        v654.l0 <- v886
        let v887 : string = $"{v694}"
        let v890 : string = v654.l0
        let v891 : string = v890 + v887 
        v654.l0 <- v891
        let v892 : string = "working_directory"
        let v893 : string = $"{v892}"
        let v896 : string = v654.l0
        let v897 : string = v896 + v893 
        v654.l0 <- v897
        let v898 : string = $"{v667}"
        let v901 : string = v654.l0
        let v902 : string = v901 + v898 
        v654.l0 <- v902
        let v903 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v904 : string = "format!(\"{:#?}\", $0)"
        let v905 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v904 
        let v906 : string = "fable_library_rust::String_::fromString($0)"
        let v907 : string = Fable.Core.RustInterop.emitRustExpr v905 v906 
        let _v903 = v907 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v908 : string = "format!(\"{:#?}\", $0)"
        let v909 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v908 
        let v910 : string = "fable_library_rust::String_::fromString($0)"
        let v911 : string = Fable.Core.RustInterop.emitRustExpr v909 v910 
        let _v903 = v911 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v912 : string = "format!(\"{:#?}\", $0)"
        let v913 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v912 
        let v914 : string = "fable_library_rust::String_::fromString($0)"
        let v915 : string = Fable.Core.RustInterop.emitRustExpr v913 v914 
        let _v903 = v915 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v916 : string = $"%A{v6}"
        let _v903 = v916 
        #endif
#if FABLE_COMPILER_PYTHON
        let v919 : string = $"%A{v6}"
        let _v903 = v919 
        #endif
#else
        let v922 : string = $"%A{v6}"
        let _v903 = v922 
        #endif
        let v925 : string = _v903 
        let v930 : string = $"{v925}"
        let v933 : string = v654.l0
        let v934 : string = v933 + v930 
        v654.l0 <- v934
        let v935 : string = " }"
        let v936 : string = $"{v935}"
        let v939 : string = v654.l0
        let v940 : string = v939 + v936 
        v654.l0 <- v940
        let v941 : string = $"{v935}"
        let v944 : string = v654.l0
        let v945 : string = v944 + v941 
        v654.l0 <- v945
        let v946 : string = v654.l0
        let v947 : (unit -> string) = closure11()
        let v948 : string = $"{v516} {v646} #{v652} %s{v947 ()} / {v946}"
        let v951 : char list = []
        let v952 : (char list -> (char [])) = List.toArray
        let v953 : (char []) = v952 v951
        let v956 : string = v948.TrimStart v953 
        let v974 : char list = []
        let v975 : char list = '/' :: v974 
        let v978 : char list = ' ' :: v975 
        let v981 : (char list -> (char [])) = List.toArray
        let v982 : (char []) = v981 v978
        let v985 : string = v956.TrimEnd v982 
        let v1003 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1004 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v985 v1004 
        let _v1003 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1005 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v985 v1005 
        let _v1003 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1006 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v985 v1006 
        let _v1003 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v985 
        let _v1003 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v985 
        let _v1003 = () 
        #endif
#else
        System.Console.WriteLine v985 
        let _v1003 = () 
        #endif
        _v1003 
        let v1007 : (string -> unit) = v87.l0
        v1007 v985
    let v1008 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v1012 : string =
        match v50 with
        | US1_1 -> (* None *)
            let v1010 : string = ""
            v1010
        | US1_0(v1009) -> (* Some *)
            v1009
    let start_info = System.Diagnostics.ProcessStartInfo (
      Arguments = v1012,
      StandardOutputEncoding = v1008,
      WorkingDirectory = v73,
      FileName = v49,
      CreateNoWindow = true,
      RedirectStandardError = true,
      RedirectStandardOutput = true,
      UseShellExecute = false
    )
    let v1013 : System.Diagnostics.ProcessStartInfo = start_info
    let v1014 : int32 = v2.Length
    let v1015 : Mut5 = {l0 = 0} : Mut5
    while method11(v1014, v1015) do
        let v1017 : int32 = v1015.l0
        let struct (v1018 : string, v1019 : string) = v2.[int v1017]
        v1013.EnvironmentVariables.[v1018] <- v1019 
        let v1020 : int32 = v1017 + 1
        v1015.l0 <- v1020
        ()
    let v1021 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1013)
    use v1021 = v1021 
    let v1022 : System.Diagnostics.Process = v1021 
    let v1023 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v1024 : System.Collections.Concurrent.ConcurrentStack<string> = v1023 ()
    let v1025 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure12(v0, v1, v2, v3, v4, v5, v6, v1022, v1024)
    v1022.OutputDataReceived.Add v1025 
    let v1026 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v0, v1, v2, v3, v4, v5, v6, v1022, v1024)
    v1022.ErrorDataReceived.Add v1026 
    let v1027 : (unit -> bool) = v1022.Start
    let v1028 : bool = v1027 ()
    let v1029 : bool = v1028 = false
    if v1029 then
        let v1030 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v1030
    let v1031 : (unit -> unit) = v1022.BeginErrorReadLine
    v1031 ()
    let v1032 : (unit -> unit) = v1022.BeginOutputReadLine
    v1032 ()
    let v1033 : US13 option = None
    let _v1033 = ref v1033 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v1034 : System.Threading.CancellationToken = x
    let v1035 : US13 = US13_0(v1034)
    v1035 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v1033.Value <- x
    let v1036 : US13 option = _v1033.Value 
    let v1047 : US13 = US13_1
    let v1048 : US13 = v1036 |> Option.defaultValue v1047 
    let v1055 : System.Threading.CancellationToken =
        match v1048 with
        | US13_1 -> (* None *)
            let v1053 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v1053
        | US13_0(v1052) -> (* Some *)
            v1052
    let v1056 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1057 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1056 = v1057 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1060 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1056 = v1060 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1063 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1056 = v1063 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1066 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1056 = v1066 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1069 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1056 = v1069 
    #endif
#else
    let v1072 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1073 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1072 = v1073 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1076 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1072 = v1076 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1079 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1072 = v1079 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1082 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1072 = v1082 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1085 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1072 = v1085 
    #endif
#else
    let v1088 : Async<System.Threading.CancellationToken> option = None
    let mutable _v1088 = v1088 
    async {
    let v1089 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v1089 = v1089 
    let v1090 : System.Threading.CancellationToken = v1089 
    let v1091 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v1092 : (System.Threading.CancellationToken []) = [|v1090; v1091; v1055|]
    let v1093 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v1094 : System.Threading.CancellationTokenSource = v1093 v1092
    let v1095 : System.Threading.CancellationToken = v1094.Token
    return v1095 
    }
    |> fun x -> _v1088 <- Some x
    let v1096 : Async<System.Threading.CancellationToken> = match _v1088 with Some x -> x | None -> failwith "async.new_async_unit / _v1088=None"
    let _v1072 = v1096 
    #endif
    let v1097 : Async<System.Threading.CancellationToken> = _v1072 
    let _v1056 = v1097 
    #endif
    let v1102 : Async<System.Threading.CancellationToken> = _v1056 
    let! v1102 = v1102 
    let v1107 : System.Threading.CancellationToken = v1102 
    let v1108 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1107.Register
    let v1109 : (unit -> unit) = closure15(v1022)
    let v1110 : System.Threading.CancellationTokenRegistration = v1108 v1109
    use v1110 = v1110 
    let v1111 : System.Threading.CancellationTokenRegistration = v1110 
    let v1112 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1113 : Async<int32> = null |> unbox<Async<int32>>
    let _v1112 = v1113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1116 : Async<int32> = null |> unbox<Async<int32>>
    let _v1112 = v1116 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1119 : Async<int32> = null |> unbox<Async<int32>>
    let _v1112 = v1119 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1122 : Async<int32> = null |> unbox<Async<int32>>
    let _v1112 = v1122 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1125 : Async<int32> = null |> unbox<Async<int32>>
    let _v1112 = v1125 
    #endif
#else
    let v1128 : Async<int32> option = None
    let mutable _v1128 = v1128 
    async {
    try
    let v1129 : System.Threading.Tasks.Task = v1022.WaitForExitAsync v1107 
    let v1130 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1131 : Async<unit> = null |> unbox<Async<unit>>
    let _v1130 = v1131 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1134 : Async<unit> = null |> unbox<Async<unit>>
    let _v1130 = v1134 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1137 : Async<unit> = null |> unbox<Async<unit>>
    let _v1130 = v1137 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1140 : Async<unit> = null |> unbox<Async<unit>>
    let _v1130 = v1140 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1143 : Async<unit> = null |> unbox<Async<unit>>
    let _v1130 = v1143 
    #endif
#else
    let v1146 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1147 : Async<unit> = v1146 v1129
    let _v1130 = v1147 
    #endif
    let v1148 : Async<unit> = _v1130 
    do! v1148 
    let v1153 : int32 = v1022.ExitCode
    return v1153 
    with ex ->
    let v1154 : exn = ex
    let v1155 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1156 : string = $"%A{v1154}"
    let _v1155 = v1156 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1159 : string = $"%A{v1154}"
    let _v1155 = v1159 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1162 : string = $"%A{v1154}"
    let _v1155 = v1162 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string = $"%A{v1154}"
    let _v1155 = v1165 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1168 : string = $"%A{v1154}"
    let _v1155 = v1168 
    #endif
#else
    let v1171 : string = $"{v1154.GetType ()}: {v1154.Message}"
    let _v1155 = v1171 
    #endif
    let v1172 : string = _v1155 
    let v1177 : (string -> unit) = v1024.Push
    v1177 v1172
    let v1178 : System.Threading.Tasks.TaskCanceledException = v1154 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v1181 : bool = State.trace_state.IsNone
    if v1181 then
        let v1182 : US0 = US0_0
        let struct (v1183 : Mut0, v1184 : Mut1, v1185 : Mut2, v1186 : Mut3, v1187 : int64 option) = method0(v1182)
        let v1188 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1183, v1184, v1185, v1186, v1187) 
        State.trace_state <- v1188 
        ()
    let struct (v1193 : Mut0, v1194 : Mut1, v1195 : Mut2, v1196 : Mut3, v1197 : int64 option) = State.trace_state.Value
    let v1208 : bool = State.trace_state.IsNone
    if v1208 then
        let v1209 : US0 = US0_0
        let struct (v1210 : Mut0, v1211 : Mut1, v1212 : Mut2, v1213 : Mut3, v1214 : int64 option) = method0(v1209)
        let v1215 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1210, v1211, v1212, v1213, v1214) 
        State.trace_state <- v1215 
        ()
    let struct (v1220 : Mut0, v1221 : Mut1, v1222 : Mut2, v1223 : Mut3, v1224 : int64 option) = State.trace_state.Value
    let v1235 : US0 = v1223.l0
    let v1236 : bool = v1222.l0
    let v1237 : bool = v1236 = false
    let v1240 : bool =
        if v1237 then
            false
        else
            let v1238 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1235
            let v1239 : bool = 3 >= v1238
            v1239
    if v1240 then
        let v1241 : int64 = v1193.l0
        let v1242 : int64 = v1241 + 1L
        v1193.l0 <- v1242
        let v1243 : bool = State.trace_state.IsNone
        if v1243 then
            let v1244 : US0 = US0_0
            let struct (v1245 : Mut0, v1246 : Mut1, v1247 : Mut2, v1248 : Mut3, v1249 : int64 option) = method0(v1244)
            let v1250 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1245, v1246, v1247, v1248, v1249) 
            State.trace_state <- v1250 
            ()
        let struct (v1255 : Mut0, v1256 : Mut1, v1257 : Mut2, v1258 : Mut3, v1259 : int64 option) = State.trace_state.Value
        let v1270 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1271 : US3 option = None
        let _v1271 = ref v1271 
        match v1259 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1272 : int64 = x
        let v1273 : US3 = US3_0(v1272)
        v1273 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1271.Value <- x
        let v1274 : US3 option = _v1271.Value 
        let v1285 : US3 = US3_1
        let v1286 : US3 = v1274 |> Option.defaultValue v1285 
        let v1326 : System.DateTime =
            match v1286 with
            | US3_1 -> (* None *)
                let v1322 : System.DateTime = System.DateTime.Now
                v1322
            | US3_0(v1290) -> (* Some *)
                let v1291 : System.DateTime = System.DateTime.Now
                let v1294 : (System.DateTime -> int64) = _.Ticks
                let v1295 : int64 = v1294 v1291
                let v1298 : int64 = v1295 - v1290
                let v1299 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1300 : System.TimeSpan = v1299 v1298
                let v1303 : (System.TimeSpan -> int32) = _.Hours
                let v1304 : int32 = v1303 v1300
                let v1307 : (System.TimeSpan -> int32) = _.Minutes
                let v1308 : int32 = v1307 v1300
                let v1311 : (System.TimeSpan -> int32) = _.Seconds
                let v1312 : int32 = v1311 v1300
                let v1315 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1316 : int32 = v1315 v1300
                let v1319 : System.DateTime = System.DateTime (1, 1, 1, v1304, v1308, v1312, v1316)
                v1319
        let v1327 : string = method5()
        let v1330 : (string -> string) = v1326.ToString
        let v1331 : string = v1330 v1327
        let _v1270 = v1331 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1334 : US3 option = None
        let _v1334 = ref v1334 
        match v1259 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1335 : int64 = x
        let v1336 : US3 = US3_0(v1335)
        v1336 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1334.Value <- x
        let v1337 : US3 option = _v1334.Value 
        let v1348 : US3 = US3_1
        let v1349 : US3 = v1337 |> Option.defaultValue v1348 
        let v1389 : System.DateTime =
            match v1349 with
            | US3_1 -> (* None *)
                let v1385 : System.DateTime = System.DateTime.Now
                v1385
            | US3_0(v1353) -> (* Some *)
                let v1354 : System.DateTime = System.DateTime.Now
                let v1357 : (System.DateTime -> int64) = _.Ticks
                let v1358 : int64 = v1357 v1354
                let v1361 : int64 = v1358 - v1353
                let v1362 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1363 : System.TimeSpan = v1362 v1361
                let v1366 : (System.TimeSpan -> int32) = _.Hours
                let v1367 : int32 = v1366 v1363
                let v1370 : (System.TimeSpan -> int32) = _.Minutes
                let v1371 : int32 = v1370 v1363
                let v1374 : (System.TimeSpan -> int32) = _.Seconds
                let v1375 : int32 = v1374 v1363
                let v1378 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1379 : int32 = v1378 v1363
                let v1382 : System.DateTime = System.DateTime (1, 1, 1, v1367, v1371, v1375, v1379)
                v1382
        let v1390 : string = method5()
        let v1393 : (string -> string) = v1389.ToString
        let v1394 : string = v1393 v1390
        let _v1270 = v1394 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1397 : string = $"near_sdk::env::block_timestamp()"
        let v1398 : uint64 = Fable.Core.RustInterop.emitRustExpr () v1397 
        let v1399 : US3 option = None
        let _v1399 = ref v1399 
        match v1259 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1400 : int64 = x
        let v1401 : US3 = US3_0(v1400)
        v1401 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1399.Value <- x
        let v1402 : US3 option = _v1399.Value 
        let v1413 : US3 = US3_1
        let v1414 : US3 = v1402 |> Option.defaultValue v1413 
        let v1423 : uint64 =
            match v1414 with
            | US3_1 -> (* None *)
                v1398
            | US3_0(v1418) -> (* Some *)
                let v1419 : (int64 -> uint64) = uint64
                let v1420 : uint64 = v1419 v1418
                let v1421 : uint64 = v1398 - v1420
                v1421
        let v1424 : uint64 = v1423 / 1000000000UL
        let v1425 : uint64 = v1424 % 60UL
        let v1426 : uint64 = v1424 / 60UL
        let v1427 : uint64 = v1426 % 60UL
        let v1428 : uint64 = v1424 / 3600UL
        let v1429 : uint64 = v1428 % 24UL
        let v1430 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v1431 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v1429, v1427, v1425) v1430 
        let v1432 : string = "fable_library_rust::String_::fromString($0)"
        let v1433 : string = Fable.Core.RustInterop.emitRustExpr v1431 v1432 
        let _v1270 = v1433 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1434 : US3 option = None
        let _v1434 = ref v1434 
        match v1259 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1435 : int64 = x
        let v1436 : US3 = US3_0(v1435)
        v1436 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1434.Value <- x
        let v1437 : US3 option = _v1434.Value 
        let v1448 : US3 = US3_1
        let v1449 : US3 = v1437 |> Option.defaultValue v1448 
        let v1489 : System.DateTime =
            match v1449 with
            | US3_1 -> (* None *)
                let v1485 : System.DateTime = System.DateTime.Now
                v1485
            | US3_0(v1453) -> (* Some *)
                let v1454 : System.DateTime = System.DateTime.Now
                let v1457 : (System.DateTime -> int64) = _.Ticks
                let v1458 : int64 = v1457 v1454
                let v1461 : int64 = v1458 - v1453
                let v1462 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1463 : System.TimeSpan = v1462 v1461
                let v1466 : (System.TimeSpan -> int32) = _.Hours
                let v1467 : int32 = v1466 v1463
                let v1470 : (System.TimeSpan -> int32) = _.Minutes
                let v1471 : int32 = v1470 v1463
                let v1474 : (System.TimeSpan -> int32) = _.Seconds
                let v1475 : int32 = v1474 v1463
                let v1478 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1479 : int32 = v1478 v1463
                let v1482 : System.DateTime = System.DateTime (1, 1, 1, v1467, v1471, v1475, v1479)
                v1482
        let v1490 : string = method6()
        let v1493 : (string -> string) = v1489.ToString
        let v1494 : string = v1493 v1490
        let _v1270 = v1494 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1497 : US3 option = None
        let _v1497 = ref v1497 
        match v1259 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1498 : int64 = x
        let v1499 : US3 = US3_0(v1498)
        v1499 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1497.Value <- x
        let v1500 : US3 option = _v1497.Value 
        let v1511 : US3 = US3_1
        let v1512 : US3 = v1500 |> Option.defaultValue v1511 
        let v1552 : System.DateTime =
            match v1512 with
            | US3_1 -> (* None *)
                let v1548 : System.DateTime = System.DateTime.Now
                v1548
            | US3_0(v1516) -> (* Some *)
                let v1517 : System.DateTime = System.DateTime.Now
                let v1520 : (System.DateTime -> int64) = _.Ticks
                let v1521 : int64 = v1520 v1517
                let v1524 : int64 = v1521 - v1516
                let v1525 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1526 : System.TimeSpan = v1525 v1524
                let v1529 : (System.TimeSpan -> int32) = _.Hours
                let v1530 : int32 = v1529 v1526
                let v1533 : (System.TimeSpan -> int32) = _.Minutes
                let v1534 : int32 = v1533 v1526
                let v1537 : (System.TimeSpan -> int32) = _.Seconds
                let v1538 : int32 = v1537 v1526
                let v1541 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1542 : int32 = v1541 v1526
                let v1545 : System.DateTime = System.DateTime (1, 1, 1, v1530, v1534, v1538, v1542)
                v1545
        let v1553 : string = method6()
        let v1556 : (string -> string) = v1552.ToString
        let v1557 : string = v1556 v1553
        let _v1270 = v1557 
        #endif
#else
        let v1560 : US3 option = None
        let _v1560 = ref v1560 
        match v1259 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1561 : int64 = x
        let v1562 : US3 = US3_0(v1561)
        v1562 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1560.Value <- x
        let v1563 : US3 option = _v1560.Value 
        let v1574 : US3 = US3_1
        let v1575 : US3 = v1563 |> Option.defaultValue v1574 
        let v1615 : System.DateTime =
            match v1575 with
            | US3_1 -> (* None *)
                let v1611 : System.DateTime = System.DateTime.Now
                v1611
            | US3_0(v1579) -> (* Some *)
                let v1580 : System.DateTime = System.DateTime.Now
                let v1583 : (System.DateTime -> int64) = _.Ticks
                let v1584 : int64 = v1583 v1580
                let v1587 : int64 = v1584 - v1579
                let v1588 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v1589 : System.TimeSpan = v1588 v1587
                let v1592 : (System.TimeSpan -> int32) = _.Hours
                let v1593 : int32 = v1592 v1589
                let v1596 : (System.TimeSpan -> int32) = _.Minutes
                let v1597 : int32 = v1596 v1589
                let v1600 : (System.TimeSpan -> int32) = _.Seconds
                let v1601 : int32 = v1600 v1589
                let v1604 : (System.TimeSpan -> int32) = _.Milliseconds
                let v1605 : int32 = v1604 v1589
                let v1608 : System.DateTime = System.DateTime (1, 1, 1, v1593, v1597, v1601, v1605)
                v1608
        let v1616 : string = method6()
        let v1619 : (string -> string) = v1615.ToString
        let v1620 : string = v1619 v1616
        let _v1270 = v1620 
        #endif
        let v1623 : string = _v1270 
        let v1688 : string = "Warning"
        let v1689 : (unit -> string) = v1688.ToLower
        let v1690 : string = v1689 ()
        let v1693 : string = v1690.PadLeft (7, ' ')
        let v1707 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1708 : string = "inline_colorization::color_yellow"
        let v1709 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1708 
        let v1710 : string = "&*$0"
        let v1711 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1693 v1710 
        let v1712 : string = "inline_colorization::color_reset"
        let v1713 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1712 
        let v1714 : string = "\"{v1709}{v1711}{v1713}\""
        let v1715 : string = @$"format!(" + v1714 + ")"
        let v1716 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1715 
        let v1717 : string = "fable_library_rust::String_::fromString($0)"
        let v1718 : string = Fable.Core.RustInterop.emitRustExpr v1716 v1717 
        let _v1707 = v1718 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1719 : string = "inline_colorization::color_yellow"
        let v1720 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1719 
        let v1721 : string = "&*$0"
        let v1722 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1693 v1721 
        let v1723 : string = "inline_colorization::color_reset"
        let v1724 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1723 
        let v1725 : string = "\"{v1720}{v1722}{v1724}\""
        let v1726 : string = @$"format!(" + v1725 + ")"
        let v1727 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1726 
        let v1728 : string = "fable_library_rust::String_::fromString($0)"
        let v1729 : string = Fable.Core.RustInterop.emitRustExpr v1727 v1728 
        let _v1707 = v1729 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1730 : string = "inline_colorization::color_yellow"
        let v1731 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1730 
        let v1732 : string = "&*$0"
        let v1733 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1693 v1732 
        let v1734 : string = "inline_colorization::color_reset"
        let v1735 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1734 
        let v1736 : string = "\"{v1731}{v1733}{v1735}\""
        let v1737 : string = @$"format!(" + v1736 + ")"
        let v1738 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1737 
        let v1739 : string = "fable_library_rust::String_::fromString($0)"
        let v1740 : string = Fable.Core.RustInterop.emitRustExpr v1738 v1739 
        let _v1707 = v1740 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1741 : string = "\u001b[93m"
        let v1742 : string = method7()
        let v1743 : string = v1741 + v1693 
        let v1744 : string = v1743 + v1742 
        let _v1707 = v1744 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1745 : string = "\u001b[93m"
        let v1746 : string = method7()
        let v1747 : string = v1745 + v1693 
        let v1748 : string = v1747 + v1746 
        let _v1707 = v1748 
        #endif
#else
        let v1749 : string = "\u001b[93m"
        let v1750 : string = method7()
        let v1751 : string = v1749 + v1693 
        let v1752 : string = v1751 + v1750 
        let _v1707 = v1752 
        #endif
        let v1753 : string = _v1707 
        let v1759 : int64 = v1255.l0
        let v1760 : string = method8()
        let v1761 : Mut4 = {l0 = v1760} : Mut4
        let v1762 : string = "{ "
        let v1763 : string = $"{v1762}"
        let v1766 : string = v1761.l0
        let v1767 : string = v1766 + v1763 
        v1761.l0 <- v1767
        let v1768 : string = "ex"
        let v1769 : string = $"{v1768}"
        let v1772 : string = v1761.l0
        let v1773 : string = v1772 + v1769 
        v1761.l0 <- v1773
        let v1774 : string = " = "
        let v1775 : string = $"{v1774}"
        let v1778 : string = v1761.l0
        let v1779 : string = v1778 + v1775 
        v1761.l0 <- v1779
        let v1780 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1781 : string = "format!(\"{:#?}\", $0)"
        let v1782 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1178 v1781 
        let v1783 : string = "fable_library_rust::String_::fromString($0)"
        let v1784 : string = Fable.Core.RustInterop.emitRustExpr v1782 v1783 
        let _v1780 = v1784 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1785 : string = "format!(\"{:#?}\", $0)"
        let v1786 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1178 v1785 
        let v1787 : string = "fable_library_rust::String_::fromString($0)"
        let v1788 : string = Fable.Core.RustInterop.emitRustExpr v1786 v1787 
        let _v1780 = v1788 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1789 : string = "format!(\"{:#?}\", $0)"
        let v1790 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1178 v1789 
        let v1791 : string = "fable_library_rust::String_::fromString($0)"
        let v1792 : string = Fable.Core.RustInterop.emitRustExpr v1790 v1791 
        let _v1780 = v1792 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v1793 : string = $"%A{v1178}"
        let _v1780 = v1793 
        #endif
#if FABLE_COMPILER_PYTHON
        let v1796 : string = $"%A{v1178}"
        let _v1780 = v1796 
        #endif
#else
        let v1799 : string = $"%A{v1178}"
        let _v1780 = v1799 
        #endif
        let v1802 : string = _v1780 
        let v1807 : string = $"{v1802}"
        let v1810 : string = v1761.l0
        let v1811 : string = v1810 + v1807 
        v1761.l0 <- v1811
        let v1812 : string = " }"
        let v1813 : string = $"{v1812}"
        let v1816 : string = v1761.l0
        let v1817 : string = v1816 + v1813 
        v1761.l0 <- v1817
        let v1818 : string = v1761.l0
        let v1819 : (unit -> string) = closure16()
        let v1820 : string = $"{v1623} {v1753} #{v1759} %s{v1819 ()} / {v1818}"
        let v1823 : char list = []
        let v1824 : (char list -> (char [])) = List.toArray
        let v1825 : (char []) = v1824 v1823
        let v1828 : string = v1820.TrimStart v1825 
        let v1846 : char list = []
        let v1847 : char list = '/' :: v1846 
        let v1850 : char list = ' ' :: v1847 
        let v1853 : (char list -> (char [])) = List.toArray
        let v1854 : (char []) = v1853 v1850
        let v1857 : string = v1828.TrimEnd v1854 
        let v1875 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1876 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1857 v1876 
        let _v1875 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1877 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1857 v1877 
        let _v1875 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1878 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1857 v1878 
        let _v1875 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1857 
        let _v1875 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1857 
        let _v1875 = () 
        #endif
#else
        System.Console.WriteLine v1857 
        let _v1875 = () 
        #endif
        _v1875 
        let v1879 : (string -> unit) = v1194.l0
        v1879 v1857
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v1128 <- Some x
    let v1880 : Async<int32> = match _v1128 with Some x -> x | None -> failwith "async.new_async_unit / _v1128=None"
    let _v1112 = v1880 
    #endif
    let v1881 : Async<int32> = _v1112 
    let! v1881 = v1881 
    let v1886 : int32 = v1881 
    let v1887 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v1888 : string seq = v1887 v1024
    let v1891 : (string -> (string seq -> string)) = String.concat
    let v1892 : string = "\n"
    let v1893 : (string seq -> string) = v1891 v1892
    let v1894 : string = v1893 v1888
    let v1897 : bool = State.trace_state.IsNone
    if v1897 then
        let v1898 : US0 = US0_0
        let struct (v1899 : Mut0, v1900 : Mut1, v1901 : Mut2, v1902 : Mut3, v1903 : int64 option) = method0(v1898)
        let v1904 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1899, v1900, v1901, v1902, v1903) 
        State.trace_state <- v1904 
        ()
    let struct (v1909 : Mut0, v1910 : Mut1, v1911 : Mut2, v1912 : Mut3, v1913 : int64 option) = State.trace_state.Value
    let v1924 : bool = State.trace_state.IsNone
    if v1924 then
        let v1925 : US0 = US0_0
        let struct (v1926 : Mut0, v1927 : Mut1, v1928 : Mut2, v1929 : Mut3, v1930 : int64 option) = method0(v1925)
        let v1931 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1926, v1927, v1928, v1929, v1930) 
        State.trace_state <- v1931 
        ()
    let struct (v1936 : Mut0, v1937 : Mut1, v1938 : Mut2, v1939 : Mut3, v1940 : int64 option) = State.trace_state.Value
    let v1951 : US0 = v1939.l0
    let v1952 : bool = v1938.l0
    let v1953 : bool = v1952 = false
    let v1956 : bool =
        if v1953 then
            false
        else
            let v1954 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v1951
            let v1955 : bool = 1 >= v1954
            v1955
    if v1956 then
        let v1957 : int64 = v1909.l0
        let v1958 : int64 = v1957 + 1L
        v1909.l0 <- v1958
        let v1959 : bool = State.trace_state.IsNone
        if v1959 then
            let v1960 : US0 = US0_0
            let struct (v1961 : Mut0, v1962 : Mut1, v1963 : Mut2, v1964 : Mut3, v1965 : int64 option) = method0(v1960)
            let v1966 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v1961, v1962, v1963, v1964, v1965) 
            State.trace_state <- v1966 
            ()
        let struct (v1971 : Mut0, v1972 : Mut1, v1973 : Mut2, v1974 : Mut3, v1975 : int64 option) = State.trace_state.Value
        let v1986 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1987 : US3 option = None
        let _v1987 = ref v1987 
        match v1975 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v1988 : int64 = x
        let v1989 : US3 = US3_0(v1988)
        v1989 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v1987.Value <- x
        let v1990 : US3 option = _v1987.Value 
        let v2001 : US3 = US3_1
        let v2002 : US3 = v1990 |> Option.defaultValue v2001 
        let v2042 : System.DateTime =
            match v2002 with
            | US3_1 -> (* None *)
                let v2038 : System.DateTime = System.DateTime.Now
                v2038
            | US3_0(v2006) -> (* Some *)
                let v2007 : System.DateTime = System.DateTime.Now
                let v2010 : (System.DateTime -> int64) = _.Ticks
                let v2011 : int64 = v2010 v2007
                let v2014 : int64 = v2011 - v2006
                let v2015 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2016 : System.TimeSpan = v2015 v2014
                let v2019 : (System.TimeSpan -> int32) = _.Hours
                let v2020 : int32 = v2019 v2016
                let v2023 : (System.TimeSpan -> int32) = _.Minutes
                let v2024 : int32 = v2023 v2016
                let v2027 : (System.TimeSpan -> int32) = _.Seconds
                let v2028 : int32 = v2027 v2016
                let v2031 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2032 : int32 = v2031 v2016
                let v2035 : System.DateTime = System.DateTime (1, 1, 1, v2020, v2024, v2028, v2032)
                v2035
        let v2043 : string = method5()
        let v2046 : (string -> string) = v2042.ToString
        let v2047 : string = v2046 v2043
        let _v1986 = v2047 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2050 : US3 option = None
        let _v2050 = ref v2050 
        match v1975 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2051 : int64 = x
        let v2052 : US3 = US3_0(v2051)
        v2052 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2050.Value <- x
        let v2053 : US3 option = _v2050.Value 
        let v2064 : US3 = US3_1
        let v2065 : US3 = v2053 |> Option.defaultValue v2064 
        let v2105 : System.DateTime =
            match v2065 with
            | US3_1 -> (* None *)
                let v2101 : System.DateTime = System.DateTime.Now
                v2101
            | US3_0(v2069) -> (* Some *)
                let v2070 : System.DateTime = System.DateTime.Now
                let v2073 : (System.DateTime -> int64) = _.Ticks
                let v2074 : int64 = v2073 v2070
                let v2077 : int64 = v2074 - v2069
                let v2078 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2079 : System.TimeSpan = v2078 v2077
                let v2082 : (System.TimeSpan -> int32) = _.Hours
                let v2083 : int32 = v2082 v2079
                let v2086 : (System.TimeSpan -> int32) = _.Minutes
                let v2087 : int32 = v2086 v2079
                let v2090 : (System.TimeSpan -> int32) = _.Seconds
                let v2091 : int32 = v2090 v2079
                let v2094 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2095 : int32 = v2094 v2079
                let v2098 : System.DateTime = System.DateTime (1, 1, 1, v2083, v2087, v2091, v2095)
                v2098
        let v2106 : string = method5()
        let v2109 : (string -> string) = v2105.ToString
        let v2110 : string = v2109 v2106
        let _v1986 = v2110 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2113 : string = $"near_sdk::env::block_timestamp()"
        let v2114 : uint64 = Fable.Core.RustInterop.emitRustExpr () v2113 
        let v2115 : US3 option = None
        let _v2115 = ref v2115 
        match v1975 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2116 : int64 = x
        let v2117 : US3 = US3_0(v2116)
        v2117 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2115.Value <- x
        let v2118 : US3 option = _v2115.Value 
        let v2129 : US3 = US3_1
        let v2130 : US3 = v2118 |> Option.defaultValue v2129 
        let v2139 : uint64 =
            match v2130 with
            | US3_1 -> (* None *)
                v2114
            | US3_0(v2134) -> (* Some *)
                let v2135 : (int64 -> uint64) = uint64
                let v2136 : uint64 = v2135 v2134
                let v2137 : uint64 = v2114 - v2136
                v2137
        let v2140 : uint64 = v2139 / 1000000000UL
        let v2141 : uint64 = v2140 % 60UL
        let v2142 : uint64 = v2140 / 60UL
        let v2143 : uint64 = v2142 % 60UL
        let v2144 : uint64 = v2140 / 3600UL
        let v2145 : uint64 = v2144 % 24UL
        let v2146 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v2147 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v2145, v2143, v2141) v2146 
        let v2148 : string = "fable_library_rust::String_::fromString($0)"
        let v2149 : string = Fable.Core.RustInterop.emitRustExpr v2147 v2148 
        let _v1986 = v2149 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2150 : US3 option = None
        let _v2150 = ref v2150 
        match v1975 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2151 : int64 = x
        let v2152 : US3 = US3_0(v2151)
        v2152 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2150.Value <- x
        let v2153 : US3 option = _v2150.Value 
        let v2164 : US3 = US3_1
        let v2165 : US3 = v2153 |> Option.defaultValue v2164 
        let v2205 : System.DateTime =
            match v2165 with
            | US3_1 -> (* None *)
                let v2201 : System.DateTime = System.DateTime.Now
                v2201
            | US3_0(v2169) -> (* Some *)
                let v2170 : System.DateTime = System.DateTime.Now
                let v2173 : (System.DateTime -> int64) = _.Ticks
                let v2174 : int64 = v2173 v2170
                let v2177 : int64 = v2174 - v2169
                let v2178 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2179 : System.TimeSpan = v2178 v2177
                let v2182 : (System.TimeSpan -> int32) = _.Hours
                let v2183 : int32 = v2182 v2179
                let v2186 : (System.TimeSpan -> int32) = _.Minutes
                let v2187 : int32 = v2186 v2179
                let v2190 : (System.TimeSpan -> int32) = _.Seconds
                let v2191 : int32 = v2190 v2179
                let v2194 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2195 : int32 = v2194 v2179
                let v2198 : System.DateTime = System.DateTime (1, 1, 1, v2183, v2187, v2191, v2195)
                v2198
        let v2206 : string = method6()
        let v2209 : (string -> string) = v2205.ToString
        let v2210 : string = v2209 v2206
        let _v1986 = v2210 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2213 : US3 option = None
        let _v2213 = ref v2213 
        match v1975 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2214 : int64 = x
        let v2215 : US3 = US3_0(v2214)
        v2215 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2213.Value <- x
        let v2216 : US3 option = _v2213.Value 
        let v2227 : US3 = US3_1
        let v2228 : US3 = v2216 |> Option.defaultValue v2227 
        let v2268 : System.DateTime =
            match v2228 with
            | US3_1 -> (* None *)
                let v2264 : System.DateTime = System.DateTime.Now
                v2264
            | US3_0(v2232) -> (* Some *)
                let v2233 : System.DateTime = System.DateTime.Now
                let v2236 : (System.DateTime -> int64) = _.Ticks
                let v2237 : int64 = v2236 v2233
                let v2240 : int64 = v2237 - v2232
                let v2241 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2242 : System.TimeSpan = v2241 v2240
                let v2245 : (System.TimeSpan -> int32) = _.Hours
                let v2246 : int32 = v2245 v2242
                let v2249 : (System.TimeSpan -> int32) = _.Minutes
                let v2250 : int32 = v2249 v2242
                let v2253 : (System.TimeSpan -> int32) = _.Seconds
                let v2254 : int32 = v2253 v2242
                let v2257 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2258 : int32 = v2257 v2242
                let v2261 : System.DateTime = System.DateTime (1, 1, 1, v2246, v2250, v2254, v2258)
                v2261
        let v2269 : string = method6()
        let v2272 : (string -> string) = v2268.ToString
        let v2273 : string = v2272 v2269
        let _v1986 = v2273 
        #endif
#else
        let v2276 : US3 option = None
        let _v2276 = ref v2276 
        match v1975 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v2277 : int64 = x
        let v2278 : US3 = US3_0(v2277)
        v2278 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v2276.Value <- x
        let v2279 : US3 option = _v2276.Value 
        let v2290 : US3 = US3_1
        let v2291 : US3 = v2279 |> Option.defaultValue v2290 
        let v2331 : System.DateTime =
            match v2291 with
            | US3_1 -> (* None *)
                let v2327 : System.DateTime = System.DateTime.Now
                v2327
            | US3_0(v2295) -> (* Some *)
                let v2296 : System.DateTime = System.DateTime.Now
                let v2299 : (System.DateTime -> int64) = _.Ticks
                let v2300 : int64 = v2299 v2296
                let v2303 : int64 = v2300 - v2295
                let v2304 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v2305 : System.TimeSpan = v2304 v2303
                let v2308 : (System.TimeSpan -> int32) = _.Hours
                let v2309 : int32 = v2308 v2305
                let v2312 : (System.TimeSpan -> int32) = _.Minutes
                let v2313 : int32 = v2312 v2305
                let v2316 : (System.TimeSpan -> int32) = _.Seconds
                let v2317 : int32 = v2316 v2305
                let v2320 : (System.TimeSpan -> int32) = _.Milliseconds
                let v2321 : int32 = v2320 v2305
                let v2324 : System.DateTime = System.DateTime (1, 1, 1, v2309, v2313, v2317, v2321)
                v2324
        let v2332 : string = method6()
        let v2335 : (string -> string) = v2331.ToString
        let v2336 : string = v2335 v2332
        let _v1986 = v2336 
        #endif
        let v2339 : string = _v1986 
        let v2404 : string = "Debug"
        let v2405 : (unit -> string) = v2404.ToLower
        let v2406 : string = v2405 ()
        let v2409 : string = v2406.PadLeft (7, ' ')
        let v2423 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2424 : string = "inline_colorization::color_bright_blue"
        let v2425 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2424 
        let v2426 : string = "&*$0"
        let v2427 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2409 v2426 
        let v2428 : string = "inline_colorization::color_reset"
        let v2429 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2428 
        let v2430 : string = "\"{v2425}{v2427}{v2429}\""
        let v2431 : string = @$"format!(" + v2430 + ")"
        let v2432 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2431 
        let v2433 : string = "fable_library_rust::String_::fromString($0)"
        let v2434 : string = Fable.Core.RustInterop.emitRustExpr v2432 v2433 
        let _v2423 = v2434 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2435 : string = "inline_colorization::color_bright_blue"
        let v2436 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2435 
        let v2437 : string = "&*$0"
        let v2438 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2409 v2437 
        let v2439 : string = "inline_colorization::color_reset"
        let v2440 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2439 
        let v2441 : string = "\"{v2436}{v2438}{v2440}\""
        let v2442 : string = @$"format!(" + v2441 + ")"
        let v2443 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2442 
        let v2444 : string = "fable_library_rust::String_::fromString($0)"
        let v2445 : string = Fable.Core.RustInterop.emitRustExpr v2443 v2444 
        let _v2423 = v2445 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2446 : string = "inline_colorization::color_bright_blue"
        let v2447 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2446 
        let v2448 : string = "&*$0"
        let v2449 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2409 v2448 
        let v2450 : string = "inline_colorization::color_reset"
        let v2451 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v2450 
        let v2452 : string = "\"{v2447}{v2449}{v2451}\""
        let v2453 : string = @$"format!(" + v2452 + ")"
        let v2454 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v2453 
        let v2455 : string = "fable_library_rust::String_::fromString($0)"
        let v2456 : string = Fable.Core.RustInterop.emitRustExpr v2454 v2455 
        let _v2423 = v2456 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v2457 : string = "\u001b[94m"
        let v2458 : string = method7()
        let v2459 : string = v2457 + v2409 
        let v2460 : string = v2459 + v2458 
        let _v2423 = v2460 
        #endif
#if FABLE_COMPILER_PYTHON
        let v2461 : string = "\u001b[94m"
        let v2462 : string = method7()
        let v2463 : string = v2461 + v2409 
        let v2464 : string = v2463 + v2462 
        let _v2423 = v2464 
        #endif
#else
        let v2465 : string = "\u001b[94m"
        let v2466 : string = method7()
        let v2467 : string = v2465 + v2409 
        let v2468 : string = v2467 + v2466 
        let _v2423 = v2468 
        #endif
        let v2469 : string = _v2423 
        let v2475 : int64 = v1971.l0
        let v2476 : int32 = v1894.Length
        let v2477 : string = method8()
        let v2478 : Mut4 = {l0 = v2477} : Mut4
        let v2479 : string = "{ "
        let v2480 : string = $"{v2479}"
        let v2483 : string = v2478.l0
        let v2484 : string = v2483 + v2480 
        v2478.l0 <- v2484
        let v2485 : string = "exit_code"
        let v2486 : string = $"{v2485}"
        let v2489 : string = v2478.l0
        let v2490 : string = v2489 + v2486 
        v2478.l0 <- v2490
        let v2491 : string = " = "
        let v2492 : string = $"{v2491}"
        let v2495 : string = v2478.l0
        let v2496 : string = v2495 + v2492 
        v2478.l0 <- v2496
        let v2497 : string = $"{v1886}"
        let v2500 : string = v2478.l0
        let v2501 : string = v2500 + v2497 
        v2478.l0 <- v2501
        let v2502 : string = "; "
        let v2503 : string = $"{v2502}"
        let v2506 : string = v2478.l0
        let v2507 : string = v2506 + v2503 
        v2478.l0 <- v2507
        let v2508 : string = "output_length"
        let v2509 : string = $"{v2508}"
        let v2512 : string = v2478.l0
        let v2513 : string = v2512 + v2509 
        v2478.l0 <- v2513
        let v2514 : string = $"{v2491}"
        let v2517 : string = v2478.l0
        let v2518 : string = v2517 + v2514 
        v2478.l0 <- v2518
        let v2519 : string = $"{v2476}"
        let v2522 : string = v2478.l0
        let v2523 : string = v2522 + v2519 
        v2478.l0 <- v2523
        let v2524 : string = " }"
        let v2525 : string = $"{v2524}"
        let v2528 : string = v2478.l0
        let v2529 : string = v2528 + v2525 
        v2478.l0 <- v2529
        let v2530 : string = v2478.l0
        let v2531 : (unit -> string) = closure17()
        let v2532 : string = $"{v2339} {v2469} #{v2475} %s{v2531 ()} / {v2530}"
        let v2535 : char list = []
        let v2536 : (char list -> (char [])) = List.toArray
        let v2537 : (char []) = v2536 v2535
        let v2540 : string = v2532.TrimStart v2537 
        let v2558 : char list = []
        let v2559 : char list = '/' :: v2558 
        let v2562 : char list = ' ' :: v2559 
        let v2565 : (char list -> (char [])) = List.toArray
        let v2566 : (char []) = v2565 v2562
        let v2569 : string = v2540.TrimEnd v2566 
        let v2587 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v2588 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2569 v2588 
        let _v2587 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v2589 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v2569 v2589 
        let _v2587 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v2590 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v2569 v2590 
        let _v2587 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v2569 
        let _v2587 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v2569 
        let _v2587 = () 
        #endif
#else
        System.Console.WriteLine v2569 
        let _v2587 = () 
        #endif
        _v2587 
        let v2591 : (string -> unit) = v1910.l0
        v2591 v2569
    return struct (v1886, v1894) 
    }
    |> fun x -> _v39 <- Some x
    let v2592 : Async<struct (int32 * string)> = match _v39 with Some x -> x | None -> failwith "async.new_async_unit / _v39=None"
    let _v23 = v2592 
    #endif
    let v2593 : Async<struct (int32 * string)> = _v23 
    let _v7 = v2593 
    #endif
    let v2598 : Async<struct (int32 * string)> = _v7 
    v2598
and closure6 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method9(v0, v1, v2, v3, v4, v6, v5)
and closure18 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method9(v0, v1, v2, v3, v4, v5, v6)
and closure19 () (v0 : (Heap0 -> Heap0)) : struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) =
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
and closure21 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
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
and closure22 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
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
            let v97 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure21()
            let v98 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure22()
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
                let v289 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure21()
                let v290 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure22()
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
and closure20 () (v0 : string) : Result<(string []), string> =
    let v1 : US14 = method22(v0)
    match v1 with
    | US14_1(v4) -> (* Error *)
        let v5 : Result<(string []), string> = Error v4 
        v5
    | US14_0(v2) -> (* Ok *)
        let v3 : Result<(string []), string> = Ok v2 
        v3
let v0 : bool = State.trace_state.IsNone
if v0 then
    let v1 : US0 = US0_0
    let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
    let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
    State.trace_state <- v7 
    ()
let v12 : (unit -> unit) = closure1()
let current_process_kill () = v12 ()
let v13 : (string -> Async<struct (int32 * string)>) = closure6()
let execute_async x = v13 x
let v14 : (struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) -> Async<struct (int32 * string)>) = closure18()
let execute_with_options_async x = v14 x
let v15 : ((Heap0 -> Heap0) -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure19()
let execution_options x = v15 x
let v16 : (string -> Result<(string []), string>) = closure20()
let split_args x = v16 x
()
