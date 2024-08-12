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
    let v365 : (string -> unit) = closure3()
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
and closure0 () () : unit =
    let v0 : bool = State.trace_state.IsNone
    if v0 then
        let v1 : US0 = US0_0
        let struct (v2 : Mut0, v3 : Mut1, v4 : Mut2, v5 : Mut3, v6 : int64 option) = method0(v1)
        let v7 : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) option = Some struct (v2, v3, v4, v5, v6) 
        State.trace_state <- v7 
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
and closure10 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 3"
    v0
and closure6 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v15 : Mut0, v16 : Mut1, v17 : Mut2, v18 : Mut3, v19 : int64 option) = State.trace_state.Value
    let v30 : unit = ()
    let v31 : unit = (fun () -> v1 (); v30) ()
    let struct (v44 : Mut0, v45 : Mut1, v46 : Mut2, v47 : Mut3, v48 : int64 option) = State.trace_state.Value
    let v59 : US0 = v47.l0
    let v60 : bool = v46.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 3 >= v62
            v63
    if v64 then
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure7(v15)
        let v67 : unit = (fun () -> v66 (); v65) ()
        let v70 : unit = ()
        let v71 : unit = (fun () -> v1 (); v70) ()
        let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = State.trace_state.Value
        let v99 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v100 : US3 option = None
        let _v100 = ref v100 
        let v101 : US3 option ref = _v100 
        let v102 : (US3 option -> US3 option ref) = closure8(v101)
        let v103 : unit = ()
        let v104 : (unit -> unit) = closure9(v88, v102)
        let v105 : unit = (fun () -> v104 (); v103) ()
        let v108 : US3 option = _v100.Value 
        let v119 : US3 = US3_1
        let v120 : US3 = v108 |> Option.defaultValue v119 
        let v160 : System.DateTime =
            match v120 with
            | US3_1 -> (* None *)
                let v156 : System.DateTime = System.DateTime.Now
                v156
            | US3_0(v124) -> (* Some *)
                let v125 : System.DateTime = System.DateTime.Now
                let v128 : (System.DateTime -> int64) = _.Ticks
                let v129 : int64 = v128 v125
                let v132 : int64 = v129 - v124
                let v133 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v134 : System.TimeSpan = v133 v132
                let v137 : (System.TimeSpan -> int32) = _.Hours
                let v138 : int32 = v137 v134
                let v141 : (System.TimeSpan -> int32) = _.Minutes
                let v142 : int32 = v141 v134
                let v145 : (System.TimeSpan -> int32) = _.Seconds
                let v146 : int32 = v145 v134
                let v149 : (System.TimeSpan -> int32) = _.Milliseconds
                let v150 : int32 = v149 v134
                let v153 : System.DateTime = System.DateTime (1, 1, 1, v138, v142, v146, v150)
                v153
        let v161 : string = method5()
        let v164 : (string -> string) = v160.ToString
        let v165 : string = v164 v161
        let _v99 = v165 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v168 : US3 option = None
        let _v168 = ref v168 
        let v169 : US3 option ref = _v168 
        let v170 : (US3 option -> US3 option ref) = closure8(v169)
        let v171 : unit = ()
        let v172 : (unit -> unit) = closure9(v88, v170)
        let v173 : unit = (fun () -> v172 (); v171) ()
        let v176 : US3 option = _v168.Value 
        let v187 : US3 = US3_1
        let v188 : US3 = v176 |> Option.defaultValue v187 
        let v228 : System.DateTime =
            match v188 with
            | US3_1 -> (* None *)
                let v224 : System.DateTime = System.DateTime.Now
                v224
            | US3_0(v192) -> (* Some *)
                let v193 : System.DateTime = System.DateTime.Now
                let v196 : (System.DateTime -> int64) = _.Ticks
                let v197 : int64 = v196 v193
                let v200 : int64 = v197 - v192
                let v201 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v202 : System.TimeSpan = v201 v200
                let v205 : (System.TimeSpan -> int32) = _.Hours
                let v206 : int32 = v205 v202
                let v209 : (System.TimeSpan -> int32) = _.Minutes
                let v210 : int32 = v209 v202
                let v213 : (System.TimeSpan -> int32) = _.Seconds
                let v214 : int32 = v213 v202
                let v217 : (System.TimeSpan -> int32) = _.Milliseconds
                let v218 : int32 = v217 v202
                let v221 : System.DateTime = System.DateTime (1, 1, 1, v206, v210, v214, v218)
                v221
        let v229 : string = method5()
        let v232 : (string -> string) = v228.ToString
        let v233 : string = v232 v229
        let _v99 = v233 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v236 : string = $"near_sdk::env::block_timestamp()"
        let v237 : uint64 = Fable.Core.RustInterop.emitRustExpr () v236 
        let v238 : US3 option = None
        let _v238 = ref v238 
        let v239 : US3 option ref = _v238 
        let v240 : (US3 option -> US3 option ref) = closure8(v239)
        let v241 : unit = ()
        let v242 : (unit -> unit) = closure9(v88, v240)
        let v243 : unit = (fun () -> v242 (); v241) ()
        let v246 : US3 option = _v238.Value 
        let v257 : US3 = US3_1
        let v258 : US3 = v246 |> Option.defaultValue v257 
        let v267 : uint64 =
            match v258 with
            | US3_1 -> (* None *)
                v237
            | US3_0(v262) -> (* Some *)
                let v263 : (int64 -> uint64) = uint64
                let v264 : uint64 = v263 v262
                let v265 : uint64 = v237 - v264
                v265
        let v268 : uint64 = v267 / 1000000000UL
        let v269 : uint64 = v268 % 60UL
        let v270 : uint64 = v268 / 60UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v268 / 3600UL
        let v273 : uint64 = v272 % 24UL
        let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
        let v276 : string = "fable_library_rust::String_::fromString($0)"
        let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
        let _v99 = v277 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v278 : US3 option = None
        let _v278 = ref v278 
        let v279 : US3 option ref = _v278 
        let v280 : (US3 option -> US3 option ref) = closure8(v279)
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure9(v88, v280)
        let v283 : unit = (fun () -> v282 (); v281) ()
        let v286 : US3 option = _v278.Value 
        let v297 : US3 = US3_1
        let v298 : US3 = v286 |> Option.defaultValue v297 
        let v338 : System.DateTime =
            match v298 with
            | US3_1 -> (* None *)
                let v334 : System.DateTime = System.DateTime.Now
                v334
            | US3_0(v302) -> (* Some *)
                let v303 : System.DateTime = System.DateTime.Now
                let v306 : (System.DateTime -> int64) = _.Ticks
                let v307 : int64 = v306 v303
                let v310 : int64 = v307 - v302
                let v311 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v312 : System.TimeSpan = v311 v310
                let v315 : (System.TimeSpan -> int32) = _.Hours
                let v316 : int32 = v315 v312
                let v319 : (System.TimeSpan -> int32) = _.Minutes
                let v320 : int32 = v319 v312
                let v323 : (System.TimeSpan -> int32) = _.Seconds
                let v324 : int32 = v323 v312
                let v327 : (System.TimeSpan -> int32) = _.Milliseconds
                let v328 : int32 = v327 v312
                let v331 : System.DateTime = System.DateTime (1, 1, 1, v316, v320, v324, v328)
                v331
        let v339 : string = method6()
        let v342 : (string -> string) = v338.ToString
        let v343 : string = v342 v339
        let _v99 = v343 
        #endif
#if FABLE_COMPILER_PYTHON
        let v346 : US3 option = None
        let _v346 = ref v346 
        let v347 : US3 option ref = _v346 
        let v348 : (US3 option -> US3 option ref) = closure8(v347)
        let v349 : unit = ()
        let v350 : (unit -> unit) = closure9(v88, v348)
        let v351 : unit = (fun () -> v350 (); v349) ()
        let v354 : US3 option = _v346.Value 
        let v365 : US3 = US3_1
        let v366 : US3 = v354 |> Option.defaultValue v365 
        let v406 : System.DateTime =
            match v366 with
            | US3_1 -> (* None *)
                let v402 : System.DateTime = System.DateTime.Now
                v402
            | US3_0(v370) -> (* Some *)
                let v371 : System.DateTime = System.DateTime.Now
                let v374 : (System.DateTime -> int64) = _.Ticks
                let v375 : int64 = v374 v371
                let v378 : int64 = v375 - v370
                let v379 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v380 : System.TimeSpan = v379 v378
                let v383 : (System.TimeSpan -> int32) = _.Hours
                let v384 : int32 = v383 v380
                let v387 : (System.TimeSpan -> int32) = _.Minutes
                let v388 : int32 = v387 v380
                let v391 : (System.TimeSpan -> int32) = _.Seconds
                let v392 : int32 = v391 v380
                let v395 : (System.TimeSpan -> int32) = _.Milliseconds
                let v396 : int32 = v395 v380
                let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
                v399
        let v407 : string = method6()
        let v410 : (string -> string) = v406.ToString
        let v411 : string = v410 v407
        let _v99 = v411 
        #endif
#else
        let v414 : US3 option = None
        let _v414 = ref v414 
        let v415 : US3 option ref = _v414 
        let v416 : (US3 option -> US3 option ref) = closure8(v415)
        let v417 : unit = ()
        let v418 : (unit -> unit) = closure9(v88, v416)
        let v419 : unit = (fun () -> v418 (); v417) ()
        let v422 : US3 option = _v414.Value 
        let v433 : US3 = US3_1
        let v434 : US3 = v422 |> Option.defaultValue v433 
        let v474 : System.DateTime =
            match v434 with
            | US3_1 -> (* None *)
                let v470 : System.DateTime = System.DateTime.Now
                v470
            | US3_0(v438) -> (* Some *)
                let v439 : System.DateTime = System.DateTime.Now
                let v442 : (System.DateTime -> int64) = _.Ticks
                let v443 : int64 = v442 v439
                let v446 : int64 = v443 - v438
                let v447 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v448 : System.TimeSpan = v447 v446
                let v451 : (System.TimeSpan -> int32) = _.Hours
                let v452 : int32 = v451 v448
                let v455 : (System.TimeSpan -> int32) = _.Minutes
                let v456 : int32 = v455 v448
                let v459 : (System.TimeSpan -> int32) = _.Seconds
                let v460 : int32 = v459 v448
                let v463 : (System.TimeSpan -> int32) = _.Milliseconds
                let v464 : int32 = v463 v448
                let v467 : System.DateTime = System.DateTime (1, 1, 1, v452, v456, v460, v464)
                v467
        let v475 : string = method6()
        let v478 : (string -> string) = v474.ToString
        let v479 : string = v478 v475
        let _v99 = v479 
        #endif
        let v482 : string = _v99 
        let v552 : string = "Warning"
        let v553 : (unit -> string) = v552.ToLower
        let v554 : string = v553 ()
        let v557 : string = v554.PadLeft (7, ' ')
        let v571 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v572 : string = "inline_colorization::color_yellow"
        let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v572 
        let v574 : string = "&*$0"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v574 
        let v576 : string = "inline_colorization::color_reset"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v576 
        let v578 : string = "\"{v573}{v575}{v577}\""
        let v579 : string = @$"format!(" + v578 + ")"
        let v580 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "fable_library_rust::String_::fromString($0)"
        let v582 : string = Fable.Core.RustInterop.emitRustExpr v580 v581 
        let _v571 = v582 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v583 : string = "inline_colorization::color_yellow"
        let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
        let v585 : string = "&*$0"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v585 
        let v587 : string = "inline_colorization::color_reset"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "\"{v584}{v586}{v588}\""
        let v590 : string = @$"format!(" + v589 + ")"
        let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "fable_library_rust::String_::fromString($0)"
        let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
        let _v571 = v593 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v594 : string = "inline_colorization::color_yellow"
        let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "&*$0"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v596 
        let v598 : string = "inline_colorization::color_reset"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "\"{v595}{v597}{v599}\""
        let v601 : string = @$"format!(" + v600 + ")"
        let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "fable_library_rust::String_::fromString($0)"
        let v604 : string = Fable.Core.RustInterop.emitRustExpr v602 v603 
        let _v571 = v604 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v605 : string = "\u001b[93m"
        let v606 : string = method7()
        let v607 : string = v605 + v557 
        let v608 : string = v607 + v606 
        let _v571 = v608 
        #endif
#if FABLE_COMPILER_PYTHON
        let v609 : string = "\u001b[93m"
        let v610 : string = method7()
        let v611 : string = v609 + v557 
        let v612 : string = v611 + v610 
        let _v571 = v612 
        #endif
#else
        let v613 : string = "\u001b[93m"
        let v614 : string = method7()
        let v615 : string = v613 + v557 
        let v616 : string = v615 + v614 
        let _v571 = v616 
        #endif
        let v617 : string = _v571 
        let v623 : int64 = v84.l0
        let v624 : string = method8()
        let v625 : Mut4 = {l0 = v624} : Mut4
        let v626 : string = v625.l0
        let v627 : (unit -> string) = closure10()
        let v628 : string = $"{v482} {v617} #{v623} %s{v627 ()} / {v626}"
        let v631 : char list = []
        let v632 : (char list -> (char [])) = List.toArray
        let v633 : (char []) = v632 v631
        let v636 : string = v628.TrimStart v633 
        let v654 : char list = []
        let v655 : char list = '/' :: v654 
        let v658 : char list = ' ' :: v655 
        let v661 : (char list -> (char [])) = List.toArray
        let v662 : (char []) = v661 v658
        let v665 : string = v636.TrimEnd v662 
        let v683 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v684 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v684 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v685 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v685 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v686 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v686 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
#else
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
        _v683 
        let v687 : (string -> unit) = v16.l0
        v687 v665
and closure12 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 2"
    v0
and closure11 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v15 : Mut0, v16 : Mut1, v17 : Mut2, v18 : Mut3, v19 : int64 option) = State.trace_state.Value
    let v30 : unit = ()
    let v31 : unit = (fun () -> v1 (); v30) ()
    let struct (v44 : Mut0, v45 : Mut1, v46 : Mut2, v47 : Mut3, v48 : int64 option) = State.trace_state.Value
    let v59 : US0 = v47.l0
    let v60 : bool = v46.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 3 >= v62
            v63
    if v64 then
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure7(v15)
        let v67 : unit = (fun () -> v66 (); v65) ()
        let v70 : unit = ()
        let v71 : unit = (fun () -> v1 (); v70) ()
        let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = State.trace_state.Value
        let v99 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v100 : US3 option = None
        let _v100 = ref v100 
        let v101 : US3 option ref = _v100 
        let v102 : (US3 option -> US3 option ref) = closure8(v101)
        let v103 : unit = ()
        let v104 : (unit -> unit) = closure9(v88, v102)
        let v105 : unit = (fun () -> v104 (); v103) ()
        let v108 : US3 option = _v100.Value 
        let v119 : US3 = US3_1
        let v120 : US3 = v108 |> Option.defaultValue v119 
        let v160 : System.DateTime =
            match v120 with
            | US3_1 -> (* None *)
                let v156 : System.DateTime = System.DateTime.Now
                v156
            | US3_0(v124) -> (* Some *)
                let v125 : System.DateTime = System.DateTime.Now
                let v128 : (System.DateTime -> int64) = _.Ticks
                let v129 : int64 = v128 v125
                let v132 : int64 = v129 - v124
                let v133 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v134 : System.TimeSpan = v133 v132
                let v137 : (System.TimeSpan -> int32) = _.Hours
                let v138 : int32 = v137 v134
                let v141 : (System.TimeSpan -> int32) = _.Minutes
                let v142 : int32 = v141 v134
                let v145 : (System.TimeSpan -> int32) = _.Seconds
                let v146 : int32 = v145 v134
                let v149 : (System.TimeSpan -> int32) = _.Milliseconds
                let v150 : int32 = v149 v134
                let v153 : System.DateTime = System.DateTime (1, 1, 1, v138, v142, v146, v150)
                v153
        let v161 : string = method5()
        let v164 : (string -> string) = v160.ToString
        let v165 : string = v164 v161
        let _v99 = v165 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v168 : US3 option = None
        let _v168 = ref v168 
        let v169 : US3 option ref = _v168 
        let v170 : (US3 option -> US3 option ref) = closure8(v169)
        let v171 : unit = ()
        let v172 : (unit -> unit) = closure9(v88, v170)
        let v173 : unit = (fun () -> v172 (); v171) ()
        let v176 : US3 option = _v168.Value 
        let v187 : US3 = US3_1
        let v188 : US3 = v176 |> Option.defaultValue v187 
        let v228 : System.DateTime =
            match v188 with
            | US3_1 -> (* None *)
                let v224 : System.DateTime = System.DateTime.Now
                v224
            | US3_0(v192) -> (* Some *)
                let v193 : System.DateTime = System.DateTime.Now
                let v196 : (System.DateTime -> int64) = _.Ticks
                let v197 : int64 = v196 v193
                let v200 : int64 = v197 - v192
                let v201 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v202 : System.TimeSpan = v201 v200
                let v205 : (System.TimeSpan -> int32) = _.Hours
                let v206 : int32 = v205 v202
                let v209 : (System.TimeSpan -> int32) = _.Minutes
                let v210 : int32 = v209 v202
                let v213 : (System.TimeSpan -> int32) = _.Seconds
                let v214 : int32 = v213 v202
                let v217 : (System.TimeSpan -> int32) = _.Milliseconds
                let v218 : int32 = v217 v202
                let v221 : System.DateTime = System.DateTime (1, 1, 1, v206, v210, v214, v218)
                v221
        let v229 : string = method5()
        let v232 : (string -> string) = v228.ToString
        let v233 : string = v232 v229
        let _v99 = v233 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v236 : string = $"near_sdk::env::block_timestamp()"
        let v237 : uint64 = Fable.Core.RustInterop.emitRustExpr () v236 
        let v238 : US3 option = None
        let _v238 = ref v238 
        let v239 : US3 option ref = _v238 
        let v240 : (US3 option -> US3 option ref) = closure8(v239)
        let v241 : unit = ()
        let v242 : (unit -> unit) = closure9(v88, v240)
        let v243 : unit = (fun () -> v242 (); v241) ()
        let v246 : US3 option = _v238.Value 
        let v257 : US3 = US3_1
        let v258 : US3 = v246 |> Option.defaultValue v257 
        let v267 : uint64 =
            match v258 with
            | US3_1 -> (* None *)
                v237
            | US3_0(v262) -> (* Some *)
                let v263 : (int64 -> uint64) = uint64
                let v264 : uint64 = v263 v262
                let v265 : uint64 = v237 - v264
                v265
        let v268 : uint64 = v267 / 1000000000UL
        let v269 : uint64 = v268 % 60UL
        let v270 : uint64 = v268 / 60UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v268 / 3600UL
        let v273 : uint64 = v272 % 24UL
        let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
        let v276 : string = "fable_library_rust::String_::fromString($0)"
        let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
        let _v99 = v277 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v278 : US3 option = None
        let _v278 = ref v278 
        let v279 : US3 option ref = _v278 
        let v280 : (US3 option -> US3 option ref) = closure8(v279)
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure9(v88, v280)
        let v283 : unit = (fun () -> v282 (); v281) ()
        let v286 : US3 option = _v278.Value 
        let v297 : US3 = US3_1
        let v298 : US3 = v286 |> Option.defaultValue v297 
        let v338 : System.DateTime =
            match v298 with
            | US3_1 -> (* None *)
                let v334 : System.DateTime = System.DateTime.Now
                v334
            | US3_0(v302) -> (* Some *)
                let v303 : System.DateTime = System.DateTime.Now
                let v306 : (System.DateTime -> int64) = _.Ticks
                let v307 : int64 = v306 v303
                let v310 : int64 = v307 - v302
                let v311 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v312 : System.TimeSpan = v311 v310
                let v315 : (System.TimeSpan -> int32) = _.Hours
                let v316 : int32 = v315 v312
                let v319 : (System.TimeSpan -> int32) = _.Minutes
                let v320 : int32 = v319 v312
                let v323 : (System.TimeSpan -> int32) = _.Seconds
                let v324 : int32 = v323 v312
                let v327 : (System.TimeSpan -> int32) = _.Milliseconds
                let v328 : int32 = v327 v312
                let v331 : System.DateTime = System.DateTime (1, 1, 1, v316, v320, v324, v328)
                v331
        let v339 : string = method6()
        let v342 : (string -> string) = v338.ToString
        let v343 : string = v342 v339
        let _v99 = v343 
        #endif
#if FABLE_COMPILER_PYTHON
        let v346 : US3 option = None
        let _v346 = ref v346 
        let v347 : US3 option ref = _v346 
        let v348 : (US3 option -> US3 option ref) = closure8(v347)
        let v349 : unit = ()
        let v350 : (unit -> unit) = closure9(v88, v348)
        let v351 : unit = (fun () -> v350 (); v349) ()
        let v354 : US3 option = _v346.Value 
        let v365 : US3 = US3_1
        let v366 : US3 = v354 |> Option.defaultValue v365 
        let v406 : System.DateTime =
            match v366 with
            | US3_1 -> (* None *)
                let v402 : System.DateTime = System.DateTime.Now
                v402
            | US3_0(v370) -> (* Some *)
                let v371 : System.DateTime = System.DateTime.Now
                let v374 : (System.DateTime -> int64) = _.Ticks
                let v375 : int64 = v374 v371
                let v378 : int64 = v375 - v370
                let v379 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v380 : System.TimeSpan = v379 v378
                let v383 : (System.TimeSpan -> int32) = _.Hours
                let v384 : int32 = v383 v380
                let v387 : (System.TimeSpan -> int32) = _.Minutes
                let v388 : int32 = v387 v380
                let v391 : (System.TimeSpan -> int32) = _.Seconds
                let v392 : int32 = v391 v380
                let v395 : (System.TimeSpan -> int32) = _.Milliseconds
                let v396 : int32 = v395 v380
                let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
                v399
        let v407 : string = method6()
        let v410 : (string -> string) = v406.ToString
        let v411 : string = v410 v407
        let _v99 = v411 
        #endif
#else
        let v414 : US3 option = None
        let _v414 = ref v414 
        let v415 : US3 option ref = _v414 
        let v416 : (US3 option -> US3 option ref) = closure8(v415)
        let v417 : unit = ()
        let v418 : (unit -> unit) = closure9(v88, v416)
        let v419 : unit = (fun () -> v418 (); v417) ()
        let v422 : US3 option = _v414.Value 
        let v433 : US3 = US3_1
        let v434 : US3 = v422 |> Option.defaultValue v433 
        let v474 : System.DateTime =
            match v434 with
            | US3_1 -> (* None *)
                let v470 : System.DateTime = System.DateTime.Now
                v470
            | US3_0(v438) -> (* Some *)
                let v439 : System.DateTime = System.DateTime.Now
                let v442 : (System.DateTime -> int64) = _.Ticks
                let v443 : int64 = v442 v439
                let v446 : int64 = v443 - v438
                let v447 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v448 : System.TimeSpan = v447 v446
                let v451 : (System.TimeSpan -> int32) = _.Hours
                let v452 : int32 = v451 v448
                let v455 : (System.TimeSpan -> int32) = _.Minutes
                let v456 : int32 = v455 v448
                let v459 : (System.TimeSpan -> int32) = _.Seconds
                let v460 : int32 = v459 v448
                let v463 : (System.TimeSpan -> int32) = _.Milliseconds
                let v464 : int32 = v463 v448
                let v467 : System.DateTime = System.DateTime (1, 1, 1, v452, v456, v460, v464)
                v467
        let v475 : string = method6()
        let v478 : (string -> string) = v474.ToString
        let v479 : string = v478 v475
        let _v99 = v479 
        #endif
        let v482 : string = _v99 
        let v552 : string = "Warning"
        let v553 : (unit -> string) = v552.ToLower
        let v554 : string = v553 ()
        let v557 : string = v554.PadLeft (7, ' ')
        let v571 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v572 : string = "inline_colorization::color_yellow"
        let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v572 
        let v574 : string = "&*$0"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v574 
        let v576 : string = "inline_colorization::color_reset"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v576 
        let v578 : string = "\"{v573}{v575}{v577}\""
        let v579 : string = @$"format!(" + v578 + ")"
        let v580 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "fable_library_rust::String_::fromString($0)"
        let v582 : string = Fable.Core.RustInterop.emitRustExpr v580 v581 
        let _v571 = v582 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v583 : string = "inline_colorization::color_yellow"
        let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
        let v585 : string = "&*$0"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v585 
        let v587 : string = "inline_colorization::color_reset"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "\"{v584}{v586}{v588}\""
        let v590 : string = @$"format!(" + v589 + ")"
        let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "fable_library_rust::String_::fromString($0)"
        let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
        let _v571 = v593 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v594 : string = "inline_colorization::color_yellow"
        let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "&*$0"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v596 
        let v598 : string = "inline_colorization::color_reset"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "\"{v595}{v597}{v599}\""
        let v601 : string = @$"format!(" + v600 + ")"
        let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "fable_library_rust::String_::fromString($0)"
        let v604 : string = Fable.Core.RustInterop.emitRustExpr v602 v603 
        let _v571 = v604 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v605 : string = "\u001b[93m"
        let v606 : string = method7()
        let v607 : string = v605 + v557 
        let v608 : string = v607 + v606 
        let _v571 = v608 
        #endif
#if FABLE_COMPILER_PYTHON
        let v609 : string = "\u001b[93m"
        let v610 : string = method7()
        let v611 : string = v609 + v557 
        let v612 : string = v611 + v610 
        let _v571 = v612 
        #endif
#else
        let v613 : string = "\u001b[93m"
        let v614 : string = method7()
        let v615 : string = v613 + v557 
        let v616 : string = v615 + v614 
        let _v571 = v616 
        #endif
        let v617 : string = _v571 
        let v623 : int64 = v84.l0
        let v624 : string = method8()
        let v625 : Mut4 = {l0 = v624} : Mut4
        let v626 : string = v625.l0
        let v627 : (unit -> string) = closure12()
        let v628 : string = $"{v482} {v617} #{v623} %s{v627 ()} / {v626}"
        let v631 : char list = []
        let v632 : (char list -> (char [])) = List.toArray
        let v633 : (char []) = v632 v631
        let v636 : string = v628.TrimStart v633 
        let v654 : char list = []
        let v655 : char list = '/' :: v654 
        let v658 : char list = ' ' :: v655 
        let v661 : (char list -> (char [])) = List.toArray
        let v662 : (char []) = v661 v658
        let v665 : string = v636.TrimEnd v662 
        let v683 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v684 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v684 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v685 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v685 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v686 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v686 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
#else
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
        _v683 
        let v687 : (string -> unit) = v16.l0
        v687 v665
and closure14 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 1"
    v0
and closure13 () () : unit =
    let v0 : unit = ()
    let v1 : (unit -> unit) = closure0()
    let v2 : unit = (fun () -> v1 (); v0) ()
    let struct (v15 : Mut0, v16 : Mut1, v17 : Mut2, v18 : Mut3, v19 : int64 option) = State.trace_state.Value
    let v30 : unit = ()
    let v31 : unit = (fun () -> v1 (); v30) ()
    let struct (v44 : Mut0, v45 : Mut1, v46 : Mut2, v47 : Mut3, v48 : int64 option) = State.trace_state.Value
    let v59 : US0 = v47.l0
    let v60 : bool = v46.l0
    let v61 : bool = v60 = false
    let v64 : bool =
        if v61 then
            false
        else
            let v62 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v59
            let v63 : bool = 3 >= v62
            v63
    if v64 then
        let v65 : unit = ()
        let v66 : (unit -> unit) = closure7(v15)
        let v67 : unit = (fun () -> v66 (); v65) ()
        let v70 : unit = ()
        let v71 : unit = (fun () -> v1 (); v70) ()
        let struct (v84 : Mut0, v85 : Mut1, v86 : Mut2, v87 : Mut3, v88 : int64 option) = State.trace_state.Value
        let v99 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v100 : US3 option = None
        let _v100 = ref v100 
        let v101 : US3 option ref = _v100 
        let v102 : (US3 option -> US3 option ref) = closure8(v101)
        let v103 : unit = ()
        let v104 : (unit -> unit) = closure9(v88, v102)
        let v105 : unit = (fun () -> v104 (); v103) ()
        let v108 : US3 option = _v100.Value 
        let v119 : US3 = US3_1
        let v120 : US3 = v108 |> Option.defaultValue v119 
        let v160 : System.DateTime =
            match v120 with
            | US3_1 -> (* None *)
                let v156 : System.DateTime = System.DateTime.Now
                v156
            | US3_0(v124) -> (* Some *)
                let v125 : System.DateTime = System.DateTime.Now
                let v128 : (System.DateTime -> int64) = _.Ticks
                let v129 : int64 = v128 v125
                let v132 : int64 = v129 - v124
                let v133 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v134 : System.TimeSpan = v133 v132
                let v137 : (System.TimeSpan -> int32) = _.Hours
                let v138 : int32 = v137 v134
                let v141 : (System.TimeSpan -> int32) = _.Minutes
                let v142 : int32 = v141 v134
                let v145 : (System.TimeSpan -> int32) = _.Seconds
                let v146 : int32 = v145 v134
                let v149 : (System.TimeSpan -> int32) = _.Milliseconds
                let v150 : int32 = v149 v134
                let v153 : System.DateTime = System.DateTime (1, 1, 1, v138, v142, v146, v150)
                v153
        let v161 : string = method5()
        let v164 : (string -> string) = v160.ToString
        let v165 : string = v164 v161
        let _v99 = v165 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v168 : US3 option = None
        let _v168 = ref v168 
        let v169 : US3 option ref = _v168 
        let v170 : (US3 option -> US3 option ref) = closure8(v169)
        let v171 : unit = ()
        let v172 : (unit -> unit) = closure9(v88, v170)
        let v173 : unit = (fun () -> v172 (); v171) ()
        let v176 : US3 option = _v168.Value 
        let v187 : US3 = US3_1
        let v188 : US3 = v176 |> Option.defaultValue v187 
        let v228 : System.DateTime =
            match v188 with
            | US3_1 -> (* None *)
                let v224 : System.DateTime = System.DateTime.Now
                v224
            | US3_0(v192) -> (* Some *)
                let v193 : System.DateTime = System.DateTime.Now
                let v196 : (System.DateTime -> int64) = _.Ticks
                let v197 : int64 = v196 v193
                let v200 : int64 = v197 - v192
                let v201 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v202 : System.TimeSpan = v201 v200
                let v205 : (System.TimeSpan -> int32) = _.Hours
                let v206 : int32 = v205 v202
                let v209 : (System.TimeSpan -> int32) = _.Minutes
                let v210 : int32 = v209 v202
                let v213 : (System.TimeSpan -> int32) = _.Seconds
                let v214 : int32 = v213 v202
                let v217 : (System.TimeSpan -> int32) = _.Milliseconds
                let v218 : int32 = v217 v202
                let v221 : System.DateTime = System.DateTime (1, 1, 1, v206, v210, v214, v218)
                v221
        let v229 : string = method5()
        let v232 : (string -> string) = v228.ToString
        let v233 : string = v232 v229
        let _v99 = v233 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v236 : string = $"near_sdk::env::block_timestamp()"
        let v237 : uint64 = Fable.Core.RustInterop.emitRustExpr () v236 
        let v238 : US3 option = None
        let _v238 = ref v238 
        let v239 : US3 option ref = _v238 
        let v240 : (US3 option -> US3 option ref) = closure8(v239)
        let v241 : unit = ()
        let v242 : (unit -> unit) = closure9(v88, v240)
        let v243 : unit = (fun () -> v242 (); v241) ()
        let v246 : US3 option = _v238.Value 
        let v257 : US3 = US3_1
        let v258 : US3 = v246 |> Option.defaultValue v257 
        let v267 : uint64 =
            match v258 with
            | US3_1 -> (* None *)
                v237
            | US3_0(v262) -> (* Some *)
                let v263 : (int64 -> uint64) = uint64
                let v264 : uint64 = v263 v262
                let v265 : uint64 = v237 - v264
                v265
        let v268 : uint64 = v267 / 1000000000UL
        let v269 : uint64 = v268 % 60UL
        let v270 : uint64 = v268 / 60UL
        let v271 : uint64 = v270 % 60UL
        let v272 : uint64 = v268 / 3600UL
        let v273 : uint64 = v272 % 24UL
        let v274 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v275 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v273, v271, v269) v274 
        let v276 : string = "fable_library_rust::String_::fromString($0)"
        let v277 : string = Fable.Core.RustInterop.emitRustExpr v275 v276 
        let _v99 = v277 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v278 : US3 option = None
        let _v278 = ref v278 
        let v279 : US3 option ref = _v278 
        let v280 : (US3 option -> US3 option ref) = closure8(v279)
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure9(v88, v280)
        let v283 : unit = (fun () -> v282 (); v281) ()
        let v286 : US3 option = _v278.Value 
        let v297 : US3 = US3_1
        let v298 : US3 = v286 |> Option.defaultValue v297 
        let v338 : System.DateTime =
            match v298 with
            | US3_1 -> (* None *)
                let v334 : System.DateTime = System.DateTime.Now
                v334
            | US3_0(v302) -> (* Some *)
                let v303 : System.DateTime = System.DateTime.Now
                let v306 : (System.DateTime -> int64) = _.Ticks
                let v307 : int64 = v306 v303
                let v310 : int64 = v307 - v302
                let v311 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v312 : System.TimeSpan = v311 v310
                let v315 : (System.TimeSpan -> int32) = _.Hours
                let v316 : int32 = v315 v312
                let v319 : (System.TimeSpan -> int32) = _.Minutes
                let v320 : int32 = v319 v312
                let v323 : (System.TimeSpan -> int32) = _.Seconds
                let v324 : int32 = v323 v312
                let v327 : (System.TimeSpan -> int32) = _.Milliseconds
                let v328 : int32 = v327 v312
                let v331 : System.DateTime = System.DateTime (1, 1, 1, v316, v320, v324, v328)
                v331
        let v339 : string = method6()
        let v342 : (string -> string) = v338.ToString
        let v343 : string = v342 v339
        let _v99 = v343 
        #endif
#if FABLE_COMPILER_PYTHON
        let v346 : US3 option = None
        let _v346 = ref v346 
        let v347 : US3 option ref = _v346 
        let v348 : (US3 option -> US3 option ref) = closure8(v347)
        let v349 : unit = ()
        let v350 : (unit -> unit) = closure9(v88, v348)
        let v351 : unit = (fun () -> v350 (); v349) ()
        let v354 : US3 option = _v346.Value 
        let v365 : US3 = US3_1
        let v366 : US3 = v354 |> Option.defaultValue v365 
        let v406 : System.DateTime =
            match v366 with
            | US3_1 -> (* None *)
                let v402 : System.DateTime = System.DateTime.Now
                v402
            | US3_0(v370) -> (* Some *)
                let v371 : System.DateTime = System.DateTime.Now
                let v374 : (System.DateTime -> int64) = _.Ticks
                let v375 : int64 = v374 v371
                let v378 : int64 = v375 - v370
                let v379 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v380 : System.TimeSpan = v379 v378
                let v383 : (System.TimeSpan -> int32) = _.Hours
                let v384 : int32 = v383 v380
                let v387 : (System.TimeSpan -> int32) = _.Minutes
                let v388 : int32 = v387 v380
                let v391 : (System.TimeSpan -> int32) = _.Seconds
                let v392 : int32 = v391 v380
                let v395 : (System.TimeSpan -> int32) = _.Milliseconds
                let v396 : int32 = v395 v380
                let v399 : System.DateTime = System.DateTime (1, 1, 1, v384, v388, v392, v396)
                v399
        let v407 : string = method6()
        let v410 : (string -> string) = v406.ToString
        let v411 : string = v410 v407
        let _v99 = v411 
        #endif
#else
        let v414 : US3 option = None
        let _v414 = ref v414 
        let v415 : US3 option ref = _v414 
        let v416 : (US3 option -> US3 option ref) = closure8(v415)
        let v417 : unit = ()
        let v418 : (unit -> unit) = closure9(v88, v416)
        let v419 : unit = (fun () -> v418 (); v417) ()
        let v422 : US3 option = _v414.Value 
        let v433 : US3 = US3_1
        let v434 : US3 = v422 |> Option.defaultValue v433 
        let v474 : System.DateTime =
            match v434 with
            | US3_1 -> (* None *)
                let v470 : System.DateTime = System.DateTime.Now
                v470
            | US3_0(v438) -> (* Some *)
                let v439 : System.DateTime = System.DateTime.Now
                let v442 : (System.DateTime -> int64) = _.Ticks
                let v443 : int64 = v442 v439
                let v446 : int64 = v443 - v438
                let v447 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v448 : System.TimeSpan = v447 v446
                let v451 : (System.TimeSpan -> int32) = _.Hours
                let v452 : int32 = v451 v448
                let v455 : (System.TimeSpan -> int32) = _.Minutes
                let v456 : int32 = v455 v448
                let v459 : (System.TimeSpan -> int32) = _.Seconds
                let v460 : int32 = v459 v448
                let v463 : (System.TimeSpan -> int32) = _.Milliseconds
                let v464 : int32 = v463 v448
                let v467 : System.DateTime = System.DateTime (1, 1, 1, v452, v456, v460, v464)
                v467
        let v475 : string = method6()
        let v478 : (string -> string) = v474.ToString
        let v479 : string = v478 v475
        let _v99 = v479 
        #endif
        let v482 : string = _v99 
        let v552 : string = "Warning"
        let v553 : (unit -> string) = v552.ToLower
        let v554 : string = v553 ()
        let v557 : string = v554.PadLeft (7, ' ')
        let v571 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v572 : string = "inline_colorization::color_yellow"
        let v573 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v572 
        let v574 : string = "&*$0"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v574 
        let v576 : string = "inline_colorization::color_reset"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v576 
        let v578 : string = "\"{v573}{v575}{v577}\""
        let v579 : string = @$"format!(" + v578 + ")"
        let v580 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "fable_library_rust::String_::fromString($0)"
        let v582 : string = Fable.Core.RustInterop.emitRustExpr v580 v581 
        let _v571 = v582 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v583 : string = "inline_colorization::color_yellow"
        let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
        let v585 : string = "&*$0"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v585 
        let v587 : string = "inline_colorization::color_reset"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v587 
        let v589 : string = "\"{v584}{v586}{v588}\""
        let v590 : string = @$"format!(" + v589 + ")"
        let v591 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "fable_library_rust::String_::fromString($0)"
        let v593 : string = Fable.Core.RustInterop.emitRustExpr v591 v592 
        let _v571 = v593 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v594 : string = "inline_colorization::color_yellow"
        let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "&*$0"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v557 v596 
        let v598 : string = "inline_colorization::color_reset"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v598 
        let v600 : string = "\"{v595}{v597}{v599}\""
        let v601 : string = @$"format!(" + v600 + ")"
        let v602 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "fable_library_rust::String_::fromString($0)"
        let v604 : string = Fable.Core.RustInterop.emitRustExpr v602 v603 
        let _v571 = v604 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v605 : string = "\u001b[93m"
        let v606 : string = method7()
        let v607 : string = v605 + v557 
        let v608 : string = v607 + v606 
        let _v571 = v608 
        #endif
#if FABLE_COMPILER_PYTHON
        let v609 : string = "\u001b[93m"
        let v610 : string = method7()
        let v611 : string = v609 + v557 
        let v612 : string = v611 + v610 
        let _v571 = v612 
        #endif
#else
        let v613 : string = "\u001b[93m"
        let v614 : string = method7()
        let v615 : string = v613 + v557 
        let v616 : string = v615 + v614 
        let _v571 = v616 
        #endif
        let v617 : string = _v571 
        let v623 : int64 = v84.l0
        let v624 : string = method8()
        let v625 : Mut4 = {l0 = v624} : Mut4
        let v626 : string = v625.l0
        let v627 : (unit -> string) = closure14()
        let v628 : string = $"{v482} {v617} #{v623} %s{v627 ()} / {v626}"
        let v631 : char list = []
        let v632 : (char list -> (char [])) = List.toArray
        let v633 : (char []) = v632 v631
        let v636 : string = v628.TrimStart v633 
        let v654 : char list = []
        let v655 : char list = '/' :: v654 
        let v658 : char list = ' ' :: v655 
        let v661 : (char list -> (char [])) = List.toArray
        let v662 : (char []) = v661 v658
        let v665 : string = v636.TrimEnd v662 
        let v683 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v684 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v684 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v685 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v685 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v686 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v665 v686 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
#else
        System.Console.WriteLine v665 
        let _v683 = () 
        #endif
        _v683 
        let v687 : (string -> unit) = v16.l0
        v687 v665
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
    let v692 : unit = ()
    let v693 : (unit -> unit) = closure11()
    let v694 : unit = (fun () -> v693 (); v692) ()
    System.Console.Out.Flush ()
    System.Threading.Thread.Sleep 60
    let v1383 : unit = ()
    let v1384 : (unit -> unit) = closure13()
    let v1385 : unit = (fun () -> v1384 (); v1383) ()
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
and closure18 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure17 () (v0 : char) : (UH0 -> UH0) =
    closure18(v0)
and method12 () : (char -> (UH0 -> UH0)) =
    closure17()
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
and closure16 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
and closure19 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
    let v12 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure16()
    let v13 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure19()
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
and closure21 (v0 : Mut4, v1 : string) () : unit =
    let v2 : string = v0.l0
    let v3 : string = v2 + v1 
    v0.l0 <- v3
    ()
and closure22 () () : string =
    let v0 : string = $"runtime.execute_with_options_async"
    v0
and closure20 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : unit =
    let v7 : unit = ()
    let v8 : (unit -> unit) = closure0()
    let v9 : unit = (fun () -> v8 (); v7) ()
    let struct (v22 : Mut0, v23 : Mut1, v24 : Mut2, v25 : Mut3, v26 : int64 option) = State.trace_state.Value
    let v37 : unit = ()
    let v38 : unit = (fun () -> v8 (); v37) ()
    let struct (v51 : Mut0, v52 : Mut1, v53 : Mut2, v54 : Mut3, v55 : int64 option) = State.trace_state.Value
    let v66 : US0 = v54.l0
    let v67 : bool = v53.l0
    let v68 : bool = v67 = false
    let v71 : bool =
        if v68 then
            false
        else
            let v69 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v66
            let v70 : bool = 1 >= v69
            v70
    if v71 then
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure7(v22)
        let v74 : unit = (fun () -> v73 (); v72) ()
        let v77 : unit = ()
        let v78 : unit = (fun () -> v8 (); v77) ()
        let struct (v91 : Mut0, v92 : Mut1, v93 : Mut2, v94 : Mut3, v95 : int64 option) = State.trace_state.Value
        let v106 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v107 : US3 option = None
        let _v107 = ref v107 
        let v108 : US3 option ref = _v107 
        let v109 : (US3 option -> US3 option ref) = closure8(v108)
        let v110 : unit = ()
        let v111 : (unit -> unit) = closure9(v95, v109)
        let v112 : unit = (fun () -> v111 (); v110) ()
        let v115 : US3 option = _v107.Value 
        let v126 : US3 = US3_1
        let v127 : US3 = v115 |> Option.defaultValue v126 
        let v167 : System.DateTime =
            match v127 with
            | US3_1 -> (* None *)
                let v163 : System.DateTime = System.DateTime.Now
                v163
            | US3_0(v131) -> (* Some *)
                let v132 : System.DateTime = System.DateTime.Now
                let v135 : (System.DateTime -> int64) = _.Ticks
                let v136 : int64 = v135 v132
                let v139 : int64 = v136 - v131
                let v140 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v141 : System.TimeSpan = v140 v139
                let v144 : (System.TimeSpan -> int32) = _.Hours
                let v145 : int32 = v144 v141
                let v148 : (System.TimeSpan -> int32) = _.Minutes
                let v149 : int32 = v148 v141
                let v152 : (System.TimeSpan -> int32) = _.Seconds
                let v153 : int32 = v152 v141
                let v156 : (System.TimeSpan -> int32) = _.Milliseconds
                let v157 : int32 = v156 v141
                let v160 : System.DateTime = System.DateTime (1, 1, 1, v145, v149, v153, v157)
                v160
        let v168 : string = method5()
        let v171 : (string -> string) = v167.ToString
        let v172 : string = v171 v168
        let _v106 = v172 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v175 : US3 option = None
        let _v175 = ref v175 
        let v176 : US3 option ref = _v175 
        let v177 : (US3 option -> US3 option ref) = closure8(v176)
        let v178 : unit = ()
        let v179 : (unit -> unit) = closure9(v95, v177)
        let v180 : unit = (fun () -> v179 (); v178) ()
        let v183 : US3 option = _v175.Value 
        let v194 : US3 = US3_1
        let v195 : US3 = v183 |> Option.defaultValue v194 
        let v235 : System.DateTime =
            match v195 with
            | US3_1 -> (* None *)
                let v231 : System.DateTime = System.DateTime.Now
                v231
            | US3_0(v199) -> (* Some *)
                let v200 : System.DateTime = System.DateTime.Now
                let v203 : (System.DateTime -> int64) = _.Ticks
                let v204 : int64 = v203 v200
                let v207 : int64 = v204 - v199
                let v208 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v209 : System.TimeSpan = v208 v207
                let v212 : (System.TimeSpan -> int32) = _.Hours
                let v213 : int32 = v212 v209
                let v216 : (System.TimeSpan -> int32) = _.Minutes
                let v217 : int32 = v216 v209
                let v220 : (System.TimeSpan -> int32) = _.Seconds
                let v221 : int32 = v220 v209
                let v224 : (System.TimeSpan -> int32) = _.Milliseconds
                let v225 : int32 = v224 v209
                let v228 : System.DateTime = System.DateTime (1, 1, 1, v213, v217, v221, v225)
                v228
        let v236 : string = method5()
        let v239 : (string -> string) = v235.ToString
        let v240 : string = v239 v236
        let _v106 = v240 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v243 : string = $"near_sdk::env::block_timestamp()"
        let v244 : uint64 = Fable.Core.RustInterop.emitRustExpr () v243 
        let v245 : US3 option = None
        let _v245 = ref v245 
        let v246 : US3 option ref = _v245 
        let v247 : (US3 option -> US3 option ref) = closure8(v246)
        let v248 : unit = ()
        let v249 : (unit -> unit) = closure9(v95, v247)
        let v250 : unit = (fun () -> v249 (); v248) ()
        let v253 : US3 option = _v245.Value 
        let v264 : US3 = US3_1
        let v265 : US3 = v253 |> Option.defaultValue v264 
        let v274 : uint64 =
            match v265 with
            | US3_1 -> (* None *)
                v244
            | US3_0(v269) -> (* Some *)
                let v270 : (int64 -> uint64) = uint64
                let v271 : uint64 = v270 v269
                let v272 : uint64 = v244 - v271
                v272
        let v275 : uint64 = v274 / 1000000000UL
        let v276 : uint64 = v275 % 60UL
        let v277 : uint64 = v275 / 60UL
        let v278 : uint64 = v277 % 60UL
        let v279 : uint64 = v275 / 3600UL
        let v280 : uint64 = v279 % 24UL
        let v281 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
        let v282 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v280, v278, v276) v281 
        let v283 : string = "fable_library_rust::String_::fromString($0)"
        let v284 : string = Fable.Core.RustInterop.emitRustExpr v282 v283 
        let _v106 = v284 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v285 : US3 option = None
        let _v285 = ref v285 
        let v286 : US3 option ref = _v285 
        let v287 : (US3 option -> US3 option ref) = closure8(v286)
        let v288 : unit = ()
        let v289 : (unit -> unit) = closure9(v95, v287)
        let v290 : unit = (fun () -> v289 (); v288) ()
        let v293 : US3 option = _v285.Value 
        let v304 : US3 = US3_1
        let v305 : US3 = v293 |> Option.defaultValue v304 
        let v345 : System.DateTime =
            match v305 with
            | US3_1 -> (* None *)
                let v341 : System.DateTime = System.DateTime.Now
                v341
            | US3_0(v309) -> (* Some *)
                let v310 : System.DateTime = System.DateTime.Now
                let v313 : (System.DateTime -> int64) = _.Ticks
                let v314 : int64 = v313 v310
                let v317 : int64 = v314 - v309
                let v318 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v319 : System.TimeSpan = v318 v317
                let v322 : (System.TimeSpan -> int32) = _.Hours
                let v323 : int32 = v322 v319
                let v326 : (System.TimeSpan -> int32) = _.Minutes
                let v327 : int32 = v326 v319
                let v330 : (System.TimeSpan -> int32) = _.Seconds
                let v331 : int32 = v330 v319
                let v334 : (System.TimeSpan -> int32) = _.Milliseconds
                let v335 : int32 = v334 v319
                let v338 : System.DateTime = System.DateTime (1, 1, 1, v323, v327, v331, v335)
                v338
        let v346 : string = method6()
        let v349 : (string -> string) = v345.ToString
        let v350 : string = v349 v346
        let _v106 = v350 
        #endif
#if FABLE_COMPILER_PYTHON
        let v353 : US3 option = None
        let _v353 = ref v353 
        let v354 : US3 option ref = _v353 
        let v355 : (US3 option -> US3 option ref) = closure8(v354)
        let v356 : unit = ()
        let v357 : (unit -> unit) = closure9(v95, v355)
        let v358 : unit = (fun () -> v357 (); v356) ()
        let v361 : US3 option = _v353.Value 
        let v372 : US3 = US3_1
        let v373 : US3 = v361 |> Option.defaultValue v372 
        let v413 : System.DateTime =
            match v373 with
            | US3_1 -> (* None *)
                let v409 : System.DateTime = System.DateTime.Now
                v409
            | US3_0(v377) -> (* Some *)
                let v378 : System.DateTime = System.DateTime.Now
                let v381 : (System.DateTime -> int64) = _.Ticks
                let v382 : int64 = v381 v378
                let v385 : int64 = v382 - v377
                let v386 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v387 : System.TimeSpan = v386 v385
                let v390 : (System.TimeSpan -> int32) = _.Hours
                let v391 : int32 = v390 v387
                let v394 : (System.TimeSpan -> int32) = _.Minutes
                let v395 : int32 = v394 v387
                let v398 : (System.TimeSpan -> int32) = _.Seconds
                let v399 : int32 = v398 v387
                let v402 : (System.TimeSpan -> int32) = _.Milliseconds
                let v403 : int32 = v402 v387
                let v406 : System.DateTime = System.DateTime (1, 1, 1, v391, v395, v399, v403)
                v406
        let v414 : string = method6()
        let v417 : (string -> string) = v413.ToString
        let v418 : string = v417 v414
        let _v106 = v418 
        #endif
#else
        let v421 : US3 option = None
        let _v421 = ref v421 
        let v422 : US3 option ref = _v421 
        let v423 : (US3 option -> US3 option ref) = closure8(v422)
        let v424 : unit = ()
        let v425 : (unit -> unit) = closure9(v95, v423)
        let v426 : unit = (fun () -> v425 (); v424) ()
        let v429 : US3 option = _v421.Value 
        let v440 : US3 = US3_1
        let v441 : US3 = v429 |> Option.defaultValue v440 
        let v481 : System.DateTime =
            match v441 with
            | US3_1 -> (* None *)
                let v477 : System.DateTime = System.DateTime.Now
                v477
            | US3_0(v445) -> (* Some *)
                let v446 : System.DateTime = System.DateTime.Now
                let v449 : (System.DateTime -> int64) = _.Ticks
                let v450 : int64 = v449 v446
                let v453 : int64 = v450 - v445
                let v454 : (int64 -> System.TimeSpan) = System.TimeSpan 
                let v455 : System.TimeSpan = v454 v453
                let v458 : (System.TimeSpan -> int32) = _.Hours
                let v459 : int32 = v458 v455
                let v462 : (System.TimeSpan -> int32) = _.Minutes
                let v463 : int32 = v462 v455
                let v466 : (System.TimeSpan -> int32) = _.Seconds
                let v467 : int32 = v466 v455
                let v470 : (System.TimeSpan -> int32) = _.Milliseconds
                let v471 : int32 = v470 v455
                let v474 : System.DateTime = System.DateTime (1, 1, 1, v459, v463, v467, v471)
                v474
        let v482 : string = method6()
        let v485 : (string -> string) = v481.ToString
        let v486 : string = v485 v482
        let _v106 = v486 
        #endif
        let v489 : string = _v106 
        let v559 : string = "Debug"
        let v560 : (unit -> string) = v559.ToLower
        let v561 : string = v560 ()
        let v564 : string = v561.PadLeft (7, ' ')
        let v578 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v579 : string = "inline_colorization::color_bright_blue"
        let v580 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v579 
        let v581 : string = "&*$0"
        let v582 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v564 v581 
        let v583 : string = "inline_colorization::color_reset"
        let v584 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v583 
        let v585 : string = "\"{v580}{v582}{v584}\""
        let v586 : string = @$"format!(" + v585 + ")"
        let v587 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v586 
        let v588 : string = "fable_library_rust::String_::fromString($0)"
        let v589 : string = Fable.Core.RustInterop.emitRustExpr v587 v588 
        let _v578 = v589 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v590 : string = "inline_colorization::color_bright_blue"
        let v591 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v590 
        let v592 : string = "&*$0"
        let v593 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v564 v592 
        let v594 : string = "inline_colorization::color_reset"
        let v595 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v594 
        let v596 : string = "\"{v591}{v593}{v595}\""
        let v597 : string = @$"format!(" + v596 + ")"
        let v598 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v597 
        let v599 : string = "fable_library_rust::String_::fromString($0)"
        let v600 : string = Fable.Core.RustInterop.emitRustExpr v598 v599 
        let _v578 = v600 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v601 : string = "inline_colorization::color_bright_blue"
        let v602 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v601 
        let v603 : string = "&*$0"
        let v604 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v564 v603 
        let v605 : string = "inline_colorization::color_reset"
        let v606 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v605 
        let v607 : string = "\"{v602}{v604}{v606}\""
        let v608 : string = @$"format!(" + v607 + ")"
        let v609 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v608 
        let v610 : string = "fable_library_rust::String_::fromString($0)"
        let v611 : string = Fable.Core.RustInterop.emitRustExpr v609 v610 
        let _v578 = v611 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v612 : string = "\u001b[94m"
        let v613 : string = method7()
        let v614 : string = v612 + v564 
        let v615 : string = v614 + v613 
        let _v578 = v615 
        #endif
#if FABLE_COMPILER_PYTHON
        let v616 : string = "\u001b[94m"
        let v617 : string = method7()
        let v618 : string = v616 + v564 
        let v619 : string = v618 + v617 
        let _v578 = v619 
        #endif
#else
        let v620 : string = "\u001b[94m"
        let v621 : string = method7()
        let v622 : string = v620 + v564 
        let v623 : string = v622 + v621 
        let _v578 = v623 
        #endif
        let v624 : string = _v578 
        let v630 : int64 = v91.l0
        let v631 : string = method8()
        let v632 : Mut4 = {l0 = v631} : Mut4
        let v633 : string = "{ "
        let v634 : string = $"{v633}"
        let v637 : unit = ()
        let v638 : (unit -> unit) = closure21(v632, v634)
        let v639 : unit = (fun () -> v638 (); v637) ()
        let v642 : string = "options"
        let v643 : string = $"{v642}"
        let v646 : unit = ()
        let v647 : (unit -> unit) = closure21(v632, v643)
        let v648 : unit = (fun () -> v647 (); v646) ()
        let v651 : string = " = "
        let v652 : string = $"{v651}"
        let v655 : unit = ()
        let v656 : (unit -> unit) = closure21(v632, v652)
        let v657 : unit = (fun () -> v656 (); v655) ()
        let v660 : string = $"{v633}"
        let v663 : unit = ()
        let v664 : (unit -> unit) = closure21(v632, v660)
        let v665 : unit = (fun () -> v664 (); v663) ()
        let v668 : string = "command"
        let v669 : string = $"{v668}"
        let v672 : unit = ()
        let v673 : (unit -> unit) = closure21(v632, v669)
        let v674 : unit = (fun () -> v673 (); v672) ()
        let v677 : string = $"{v651}"
        let v680 : unit = ()
        let v681 : (unit -> unit) = closure21(v632, v677)
        let v682 : unit = (fun () -> v681 (); v680) ()
        let v685 : string = $"{v0}"
        let v688 : unit = ()
        let v689 : (unit -> unit) = closure21(v632, v685)
        let v690 : unit = (fun () -> v689 (); v688) ()
        let v693 : string = "; "
        let v694 : string = $"{v693}"
        let v697 : unit = ()
        let v698 : (unit -> unit) = closure21(v632, v694)
        let v699 : unit = (fun () -> v698 (); v697) ()
        let v702 : string = "cancellation_token"
        let v703 : string = $"{v702}"
        let v706 : unit = ()
        let v707 : (unit -> unit) = closure21(v632, v703)
        let v708 : unit = (fun () -> v707 (); v706) ()
        let v711 : string = $"{v651}"
        let v714 : unit = ()
        let v715 : (unit -> unit) = closure21(v632, v711)
        let v716 : unit = (fun () -> v715 (); v714) ()
        let v719 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v720 : string = "format!(\"{:#?}\", $0)"
        let v721 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v720 
        let v722 : string = "fable_library_rust::String_::fromString($0)"
        let v723 : string = Fable.Core.RustInterop.emitRustExpr v721 v722 
        let _v719 = v723 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v724 : string = "format!(\"{:#?}\", $0)"
        let v725 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v724 
        let v726 : string = "fable_library_rust::String_::fromString($0)"
        let v727 : string = Fable.Core.RustInterop.emitRustExpr v725 v726 
        let _v719 = v727 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v728 : string = "format!(\"{:#?}\", $0)"
        let v729 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1 v728 
        let v730 : string = "fable_library_rust::String_::fromString($0)"
        let v731 : string = Fable.Core.RustInterop.emitRustExpr v729 v730 
        let _v719 = v731 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v732 : string = $"%A{v1}"
        let _v719 = v732 
        #endif
#if FABLE_COMPILER_PYTHON
        let v735 : string = $"%A{v1}"
        let _v719 = v735 
        #endif
#else
        let v738 : string = $"%A{v1}"
        let _v719 = v738 
        #endif
        let v741 : string = _v719 
        let v746 : string = $"{v741}"
        let v749 : unit = ()
        let v750 : (unit -> unit) = closure21(v632, v746)
        let v751 : unit = (fun () -> v750 (); v749) ()
        let v754 : string = $"{v693}"
        let v757 : unit = ()
        let v758 : (unit -> unit) = closure21(v632, v754)
        let v759 : unit = (fun () -> v758 (); v757) ()
        let v762 : string = "environment_variables"
        let v763 : string = $"{v762}"
        let v766 : unit = ()
        let v767 : (unit -> unit) = closure21(v632, v763)
        let v768 : unit = (fun () -> v767 (); v766) ()
        let v771 : string = $"{v651}"
        let v774 : unit = ()
        let v775 : (unit -> unit) = closure21(v632, v771)
        let v776 : unit = (fun () -> v775 (); v774) ()
        let v779 : string = $"%A{v2}"
        let v782 : string = $"{v779}"
        let v785 : unit = ()
        let v786 : (unit -> unit) = closure21(v632, v782)
        let v787 : unit = (fun () -> v786 (); v785) ()
        let v790 : string = $"{v693}"
        let v793 : unit = ()
        let v794 : (unit -> unit) = closure21(v632, v790)
        let v795 : unit = (fun () -> v794 (); v793) ()
        let v798 : string = "on_line"
        let v799 : string = $"{v798}"
        let v802 : unit = ()
        let v803 : (unit -> unit) = closure21(v632, v799)
        let v804 : unit = (fun () -> v803 (); v802) ()
        let v807 : string = $"{v651}"
        let v810 : unit = ()
        let v811 : (unit -> unit) = closure21(v632, v807)
        let v812 : unit = (fun () -> v811 (); v810) ()
        let v815 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v816 : string = "format!(\"{:#?}\", $0)"
        let v817 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v816 
        let v818 : string = "fable_library_rust::String_::fromString($0)"
        let v819 : string = Fable.Core.RustInterop.emitRustExpr v817 v818 
        let _v815 = v819 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v820 : string = "format!(\"{:#?}\", $0)"
        let v821 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v820 
        let v822 : string = "fable_library_rust::String_::fromString($0)"
        let v823 : string = Fable.Core.RustInterop.emitRustExpr v821 v822 
        let _v815 = v823 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v824 : string = "format!(\"{:#?}\", $0)"
        let v825 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3 v824 
        let v826 : string = "fable_library_rust::String_::fromString($0)"
        let v827 : string = Fable.Core.RustInterop.emitRustExpr v825 v826 
        let _v815 = v827 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v828 : string = $"%A{v3}"
        let _v815 = v828 
        #endif
#if FABLE_COMPILER_PYTHON
        let v831 : string = $"%A{v3}"
        let _v815 = v831 
        #endif
#else
        let v834 : string = $"%A{v3}"
        let _v815 = v834 
        #endif
        let v837 : string = _v815 
        let v842 : string = $"{v837}"
        let v845 : unit = ()
        let v846 : (unit -> unit) = closure21(v632, v842)
        let v847 : unit = (fun () -> v846 (); v845) ()
        let v850 : string = $"{v693}"
        let v853 : unit = ()
        let v854 : (unit -> unit) = closure21(v632, v850)
        let v855 : unit = (fun () -> v854 (); v853) ()
        let v858 : string = "stdin"
        let v859 : string = $"{v858}"
        let v862 : unit = ()
        let v863 : (unit -> unit) = closure21(v632, v859)
        let v864 : unit = (fun () -> v863 (); v862) ()
        let v867 : string = $"{v651}"
        let v870 : unit = ()
        let v871 : (unit -> unit) = closure21(v632, v867)
        let v872 : unit = (fun () -> v871 (); v870) ()
        let v875 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v876 : string = "format!(\"{:#?}\", $0)"
        let v877 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v876 
        let v878 : string = "fable_library_rust::String_::fromString($0)"
        let v879 : string = Fable.Core.RustInterop.emitRustExpr v877 v878 
        let _v875 = v879 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v880 : string = "format!(\"{:#?}\", $0)"
        let v881 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v880 
        let v882 : string = "fable_library_rust::String_::fromString($0)"
        let v883 : string = Fable.Core.RustInterop.emitRustExpr v881 v882 
        let _v875 = v883 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v884 : string = "format!(\"{:#?}\", $0)"
        let v885 : std_string_String = Fable.Core.RustInterop.emitRustExpr v4 v884 
        let v886 : string = "fable_library_rust::String_::fromString($0)"
        let v887 : string = Fable.Core.RustInterop.emitRustExpr v885 v886 
        let _v875 = v887 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v888 : string = $"%A{v4}"
        let _v875 = v888 
        #endif
#if FABLE_COMPILER_PYTHON
        let v891 : string = $"%A{v4}"
        let _v875 = v891 
        #endif
#else
        let v894 : string = $"%A{v4}"
        let _v875 = v894 
        #endif
        let v897 : string = _v875 
        let v902 : string = $"{v897}"
        let v905 : unit = ()
        let v906 : (unit -> unit) = closure21(v632, v902)
        let v907 : unit = (fun () -> v906 (); v905) ()
        let v910 : string = $"{v693}"
        let v913 : unit = ()
        let v914 : (unit -> unit) = closure21(v632, v910)
        let v915 : unit = (fun () -> v914 (); v913) ()
        let v918 : string = "trace"
        let v919 : string = $"{v918}"
        let v922 : unit = ()
        let v923 : (unit -> unit) = closure21(v632, v919)
        let v924 : unit = (fun () -> v923 (); v922) ()
        let v927 : string = $"{v651}"
        let v930 : unit = ()
        let v931 : (unit -> unit) = closure21(v632, v927)
        let v932 : unit = (fun () -> v931 (); v930) ()
        let v937 : string =
            if v5 then
                let v935 : string = "true"
                v935
            else
                let v936 : string = "false"
                v936
        let v938 : string = $"{v937}"
        let v941 : unit = ()
        let v942 : (unit -> unit) = closure21(v632, v938)
        let v943 : unit = (fun () -> v942 (); v941) ()
        let v946 : string = $"{v693}"
        let v949 : unit = ()
        let v950 : (unit -> unit) = closure21(v632, v946)
        let v951 : unit = (fun () -> v950 (); v949) ()
        let v954 : string = "working_directory"
        let v955 : string = $"{v954}"
        let v958 : unit = ()
        let v959 : (unit -> unit) = closure21(v632, v955)
        let v960 : unit = (fun () -> v959 (); v958) ()
        let v963 : string = $"{v651}"
        let v966 : unit = ()
        let v967 : (unit -> unit) = closure21(v632, v963)
        let v968 : unit = (fun () -> v967 (); v966) ()
        let v971 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v972 : string = "format!(\"{:#?}\", $0)"
        let v973 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v972 
        let v974 : string = "fable_library_rust::String_::fromString($0)"
        let v975 : string = Fable.Core.RustInterop.emitRustExpr v973 v974 
        let _v971 = v975 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v976 : string = "format!(\"{:#?}\", $0)"
        let v977 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v976 
        let v978 : string = "fable_library_rust::String_::fromString($0)"
        let v979 : string = Fable.Core.RustInterop.emitRustExpr v977 v978 
        let _v971 = v979 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v980 : string = "format!(\"{:#?}\", $0)"
        let v981 : std_string_String = Fable.Core.RustInterop.emitRustExpr v6 v980 
        let v982 : string = "fable_library_rust::String_::fromString($0)"
        let v983 : string = Fable.Core.RustInterop.emitRustExpr v981 v982 
        let _v971 = v983 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v984 : string = $"%A{v6}"
        let _v971 = v984 
        #endif
#if FABLE_COMPILER_PYTHON
        let v987 : string = $"%A{v6}"
        let _v971 = v987 
        #endif
#else
        let v990 : string = $"%A{v6}"
        let _v971 = v990 
        #endif
        let v993 : string = _v971 
        let v998 : string = $"{v993}"
        let v1001 : unit = ()
        let v1002 : (unit -> unit) = closure21(v632, v998)
        let v1003 : unit = (fun () -> v1002 (); v1001) ()
        let v1006 : string = " }"
        let v1007 : string = $"{v1006}"
        let v1010 : unit = ()
        let v1011 : (unit -> unit) = closure21(v632, v1007)
        let v1012 : unit = (fun () -> v1011 (); v1010) ()
        let v1015 : string = $"{v1006}"
        let v1018 : unit = ()
        let v1019 : (unit -> unit) = closure21(v632, v1015)
        let v1020 : unit = (fun () -> v1019 (); v1018) ()
        let v1023 : string = v632.l0
        let v1024 : (unit -> string) = closure22()
        let v1025 : string = $"{v489} {v624} #{v630} %s{v1024 ()} / {v1023}"
        let v1028 : char list = []
        let v1029 : (char list -> (char [])) = List.toArray
        let v1030 : (char []) = v1029 v1028
        let v1033 : string = v1025.TrimStart v1030 
        let v1051 : char list = []
        let v1052 : char list = '/' :: v1051 
        let v1055 : char list = ' ' :: v1052 
        let v1058 : (char list -> (char [])) = List.toArray
        let v1059 : (char []) = v1058 v1055
        let v1062 : string = v1033.TrimEnd v1059 
        let v1080 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v1081 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1062 v1081 
        let _v1080 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v1082 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v1062 v1082 
        let _v1080 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v1083 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v1062 v1083 
        let _v1080 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v1062 
        let _v1080 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v1062 
        let _v1080 = () 
        #endif
#else
        System.Console.WriteLine v1062 
        let _v1080 = () 
        #endif
        _v1080 
        let v1084 : (string -> unit) = v23.l0
        v1084 v1062
and closure24 (v0 : US12 option ref) (v1 : US12 option) : US12 option ref =
    v0.Value <- v1 
    v0
and closure25 (v0 : (struct (int32 * string * bool) -> Async<unit>) option, v1 : (US12 option -> US12 option ref)) () : unit =
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
and closure27 (v0 : string) () : string =
    v0
and closure26 (v0 : string) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US0 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 0 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure7(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US3 option = None
        let _v101 = ref v101 
        let v102 : US3 option ref = _v101 
        let v103 : (US3 option -> US3 option ref) = closure8(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure9(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US3 option = _v101.Value 
        let v120 : US3 = US3_1
        let v121 : US3 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US3_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US3_0(v125) -> (* Some *)
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
        let v162 : string = method5()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US3 option = None
        let _v169 = ref v169 
        let v170 : US3 option ref = _v169 
        let v171 : (US3 option -> US3 option ref) = closure8(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure9(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US3 option = _v169.Value 
        let v188 : US3 = US3_1
        let v189 : US3 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US3_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US3_0(v193) -> (* Some *)
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
        let v230 : string = method5()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US3 option = None
        let _v239 = ref v239 
        let v240 : US3 option ref = _v239 
        let v241 : (US3 option -> US3 option ref) = closure8(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure9(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US3 option = _v239.Value 
        let v258 : US3 = US3_1
        let v259 : US3 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US3_1 -> (* None *)
                v238
            | US3_0(v263) -> (* Some *)
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
        let v279 : US3 option = None
        let _v279 = ref v279 
        let v280 : US3 option ref = _v279 
        let v281 : (US3 option -> US3 option ref) = closure8(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure9(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US3 option = _v279.Value 
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
        let v340 : string = method6()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US3 option = None
        let _v347 = ref v347 
        let v348 : US3 option ref = _v347 
        let v349 : (US3 option -> US3 option ref) = closure8(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure9(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US3 option = _v347.Value 
        let v366 : US3 = US3_1
        let v367 : US3 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US3_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US3_0(v371) -> (* Some *)
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
        let v408 : string = method6()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US3 option = None
        let _v415 = ref v415 
        let v416 : US3 option ref = _v415 
        let v417 : (US3 option -> US3 option ref) = closure8(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure9(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US3 option = _v415.Value 
        let v434 : US3 = US3_1
        let v435 : US3 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US3_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US3_0(v439) -> (* Some *)
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
        let v476 : string = method6()
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
        let v607 : string = method7()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[90m"
        let v611 : string = method7()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[90m"
        let v615 : string = method7()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method8()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = v626.l0
        let v628 : (unit -> string) = closure27(v0)
        let v629 : string = $"{v483} {v618} #{v624} %s{v628 ()} / {v627}"
        let v632 : char list = []
        let v633 : (char list -> (char [])) = List.toArray
        let v634 : (char []) = v633 v632
        let v637 : string = v629.TrimStart v634 
        let v655 : char list = []
        let v656 : char list = '/' :: v655 
        let v659 : char list = ' ' :: v656 
        let v662 : (char list -> (char [])) = List.toArray
        let v663 : (char []) = v662 v659
        let v666 : string = v637.TrimEnd v663 
        let v684 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v685 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v666 v685 
        let _v684 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v686 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v666 v686 
        let _v684 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v687 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v666 v687 
        let _v684 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v666 
        let _v684 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v666 
        let _v684 = () 
        #endif
#else
        System.Console.WriteLine v666 
        let _v684 = () 
        #endif
        _v684 
        let v688 : (string -> unit) = v17.l0
        v688 v666
and closure28 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
and closure23 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
        let v35 : (US12 option -> US12 option ref) = closure24(v34)
        let v36 : unit = ()
        let v37 : (unit -> unit) = closure25(v3, v35)
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
            let v62 : (unit -> unit) = closure26(v60)
            let v63 : unit = (fun () -> v62 (); v61) ()
            ()
        else
            let v752 : unit = ()
            let v753 : (unit -> unit) = closure28(v60)
            let v754 : unit = (fun () -> v753 (); v752) ()
            ()
        let v756 : string = ""
        let v757 : string = $"{v756}{v27}{v756}"
        let v758 : (string -> unit) = v8.Push
        v758 v757
    ()
    }
    |> fun x -> _v26 <- Some x
    let v759 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v759 
    #endif
    let v760 : Async<unit> = _v10 
    let v765 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v765 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v765 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v765 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v765 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v765 = () 
    #endif
#else
    let v766 : (Async<unit> -> unit) = Async.StartImmediate
    v766 v760
    let _v765 = () 
    #endif
    _v765 
    ()
and closure29 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
        let v35 : (US12 option -> US12 option ref) = closure24(v34)
        let v36 : unit = ()
        let v37 : (unit -> unit) = closure25(v3, v35)
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
            let v62 : (unit -> unit) = closure26(v60)
            let v63 : unit = (fun () -> v62 (); v61) ()
            ()
        else
            let v752 : unit = ()
            let v753 : (unit -> unit) = closure28(v60)
            let v754 : unit = (fun () -> v753 (); v752) ()
            ()
        let v756 : string = "\u001b[7;4m"
        let v757 : string = "\u001b[0m"
        let v758 : string = $"{v756}{v27}{v757}"
        let v759 : (string -> unit) = v8.Push
        v759 v758
    ()
    }
    |> fun x -> _v26 <- Some x
    let v760 : Async<unit> = match _v26 with Some x -> x | None -> failwith "async.new_async_unit / _v26=None"
    let _v10 = v760 
    #endif
    let v761 : Async<unit> = _v10 
    let v766 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v766 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v766 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v766 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v766 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v766 = () 
    #endif
#else
    let v767 : (Async<unit> -> unit) = Async.StartImmediate
    v767 v761
    let _v766 = () 
    #endif
    _v766 
    ()
and closure30 (v0 : US13 option ref) (v1 : US13 option) : US13 option ref =
    v0.Value <- v1 
    v0
and closure31 (v0 : System.Threading.CancellationToken option, v1 : (US13 option -> US13 option ref)) () : unit =
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
and closure32 (v0 : System.Diagnostics.Process) () : unit =
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
and closure34 () () : string =
    let v0 : string = $"runtime.execute_with_options_async / WaitForExitAsync"
    v0
and closure33 (v0 : System.Threading.Tasks.TaskCanceledException) () : unit =
    let v1 : unit = ()
    let v2 : (unit -> unit) = closure0()
    let v3 : unit = (fun () -> v2 (); v1) ()
    let struct (v16 : Mut0, v17 : Mut1, v18 : Mut2, v19 : Mut3, v20 : int64 option) = State.trace_state.Value
    let v31 : unit = ()
    let v32 : unit = (fun () -> v2 (); v31) ()
    let struct (v45 : Mut0, v46 : Mut1, v47 : Mut2, v48 : Mut3, v49 : int64 option) = State.trace_state.Value
    let v60 : US0 = v48.l0
    let v61 : bool = v47.l0
    let v62 : bool = v61 = false
    let v65 : bool =
        if v62 then
            false
        else
            let v63 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v60
            let v64 : bool = 3 >= v63
            v64
    if v65 then
        let v66 : unit = ()
        let v67 : (unit -> unit) = closure7(v16)
        let v68 : unit = (fun () -> v67 (); v66) ()
        let v71 : unit = ()
        let v72 : unit = (fun () -> v2 (); v71) ()
        let struct (v85 : Mut0, v86 : Mut1, v87 : Mut2, v88 : Mut3, v89 : int64 option) = State.trace_state.Value
        let v100 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v101 : US3 option = None
        let _v101 = ref v101 
        let v102 : US3 option ref = _v101 
        let v103 : (US3 option -> US3 option ref) = closure8(v102)
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure9(v89, v103)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v109 : US3 option = _v101.Value 
        let v120 : US3 = US3_1
        let v121 : US3 = v109 |> Option.defaultValue v120 
        let v161 : System.DateTime =
            match v121 with
            | US3_1 -> (* None *)
                let v157 : System.DateTime = System.DateTime.Now
                v157
            | US3_0(v125) -> (* Some *)
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
        let v162 : string = method5()
        let v165 : (string -> string) = v161.ToString
        let v166 : string = v165 v162
        let _v100 = v166 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v169 : US3 option = None
        let _v169 = ref v169 
        let v170 : US3 option ref = _v169 
        let v171 : (US3 option -> US3 option ref) = closure8(v170)
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure9(v89, v171)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v177 : US3 option = _v169.Value 
        let v188 : US3 = US3_1
        let v189 : US3 = v177 |> Option.defaultValue v188 
        let v229 : System.DateTime =
            match v189 with
            | US3_1 -> (* None *)
                let v225 : System.DateTime = System.DateTime.Now
                v225
            | US3_0(v193) -> (* Some *)
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
        let v230 : string = method5()
        let v233 : (string -> string) = v229.ToString
        let v234 : string = v233 v230
        let _v100 = v234 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v237 : string = $"near_sdk::env::block_timestamp()"
        let v238 : uint64 = Fable.Core.RustInterop.emitRustExpr () v237 
        let v239 : US3 option = None
        let _v239 = ref v239 
        let v240 : US3 option ref = _v239 
        let v241 : (US3 option -> US3 option ref) = closure8(v240)
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure9(v89, v241)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v247 : US3 option = _v239.Value 
        let v258 : US3 = US3_1
        let v259 : US3 = v247 |> Option.defaultValue v258 
        let v268 : uint64 =
            match v259 with
            | US3_1 -> (* None *)
                v238
            | US3_0(v263) -> (* Some *)
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
        let v279 : US3 option = None
        let _v279 = ref v279 
        let v280 : US3 option ref = _v279 
        let v281 : (US3 option -> US3 option ref) = closure8(v280)
        let v282 : unit = ()
        let v283 : (unit -> unit) = closure9(v89, v281)
        let v284 : unit = (fun () -> v283 (); v282) ()
        let v287 : US3 option = _v279.Value 
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
        let v340 : string = method6()
        let v343 : (string -> string) = v339.ToString
        let v344 : string = v343 v340
        let _v100 = v344 
        #endif
#if FABLE_COMPILER_PYTHON
        let v347 : US3 option = None
        let _v347 = ref v347 
        let v348 : US3 option ref = _v347 
        let v349 : (US3 option -> US3 option ref) = closure8(v348)
        let v350 : unit = ()
        let v351 : (unit -> unit) = closure9(v89, v349)
        let v352 : unit = (fun () -> v351 (); v350) ()
        let v355 : US3 option = _v347.Value 
        let v366 : US3 = US3_1
        let v367 : US3 = v355 |> Option.defaultValue v366 
        let v407 : System.DateTime =
            match v367 with
            | US3_1 -> (* None *)
                let v403 : System.DateTime = System.DateTime.Now
                v403
            | US3_0(v371) -> (* Some *)
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
        let v408 : string = method6()
        let v411 : (string -> string) = v407.ToString
        let v412 : string = v411 v408
        let _v100 = v412 
        #endif
#else
        let v415 : US3 option = None
        let _v415 = ref v415 
        let v416 : US3 option ref = _v415 
        let v417 : (US3 option -> US3 option ref) = closure8(v416)
        let v418 : unit = ()
        let v419 : (unit -> unit) = closure9(v89, v417)
        let v420 : unit = (fun () -> v419 (); v418) ()
        let v423 : US3 option = _v415.Value 
        let v434 : US3 = US3_1
        let v435 : US3 = v423 |> Option.defaultValue v434 
        let v475 : System.DateTime =
            match v435 with
            | US3_1 -> (* None *)
                let v471 : System.DateTime = System.DateTime.Now
                v471
            | US3_0(v439) -> (* Some *)
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
        let v476 : string = method6()
        let v479 : (string -> string) = v475.ToString
        let v480 : string = v479 v476
        let _v100 = v480 
        #endif
        let v483 : string = _v100 
        let v553 : string = "Warning"
        let v554 : (unit -> string) = v553.ToLower
        let v555 : string = v554 ()
        let v558 : string = v555.PadLeft (7, ' ')
        let v572 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v573 : string = "inline_colorization::color_yellow"
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
        let v584 : string = "inline_colorization::color_yellow"
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
        let v595 : string = "inline_colorization::color_yellow"
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
        let v606 : string = "\u001b[93m"
        let v607 : string = method7()
        let v608 : string = v606 + v558 
        let v609 : string = v608 + v607 
        let _v572 = v609 
        #endif
#if FABLE_COMPILER_PYTHON
        let v610 : string = "\u001b[93m"
        let v611 : string = method7()
        let v612 : string = v610 + v558 
        let v613 : string = v612 + v611 
        let _v572 = v613 
        #endif
#else
        let v614 : string = "\u001b[93m"
        let v615 : string = method7()
        let v616 : string = v614 + v558 
        let v617 : string = v616 + v615 
        let _v572 = v617 
        #endif
        let v618 : string = _v572 
        let v624 : int64 = v85.l0
        let v625 : string = method8()
        let v626 : Mut4 = {l0 = v625} : Mut4
        let v627 : string = "{ "
        let v628 : string = $"{v627}"
        let v631 : unit = ()
        let v632 : (unit -> unit) = closure21(v626, v628)
        let v633 : unit = (fun () -> v632 (); v631) ()
        let v636 : string = "ex"
        let v637 : string = $"{v636}"
        let v640 : unit = ()
        let v641 : (unit -> unit) = closure21(v626, v637)
        let v642 : unit = (fun () -> v641 (); v640) ()
        let v645 : string = " = "
        let v646 : string = $"{v645}"
        let v649 : unit = ()
        let v650 : (unit -> unit) = closure21(v626, v646)
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
        let v685 : (unit -> unit) = closure21(v626, v681)
        let v686 : unit = (fun () -> v685 (); v684) ()
        let v689 : string = " }"
        let v690 : string = $"{v689}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure21(v626, v690)
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
        let v755 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v756 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v756 
        let _v755 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v757 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v757 
        let _v755 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v758 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v737 v758 
        let _v755 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v737 
        let _v755 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v737 
        let _v755 = () 
        #endif
#else
        System.Console.WriteLine v737 
        let _v755 = () 
        #endif
        _v755 
        let v759 : (string -> unit) = v17.l0
        v759 v737
and closure36 () () : string =
    let v0 : string = $"runtime.execute_with_options_async"
    v0
and closure35 (v0 : int32, v1 : string) () : unit =
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure0()
    let v4 : unit = (fun () -> v3 (); v2) ()
    let struct (v17 : Mut0, v18 : Mut1, v19 : Mut2, v20 : Mut3, v21 : int64 option) = State.trace_state.Value
    let v32 : unit = ()
    let v33 : unit = (fun () -> v3 (); v32) ()
    let struct (v46 : Mut0, v47 : Mut1, v48 : Mut2, v49 : Mut3, v50 : int64 option) = State.trace_state.Value
    let v61 : US0 = v49.l0
    let v62 : bool = v48.l0
    let v63 : bool = v62 = false
    let v66 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v65 : bool = 1 >= v64
            v65
    if v66 then
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure7(v17)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v72 : unit = ()
        let v73 : unit = (fun () -> v3 (); v72) ()
        let struct (v86 : Mut0, v87 : Mut1, v88 : Mut2, v89 : Mut3, v90 : int64 option) = State.trace_state.Value
        let v101 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v102 : US3 option = None
        let _v102 = ref v102 
        let v103 : US3 option ref = _v102 
        let v104 : (US3 option -> US3 option ref) = closure8(v103)
        let v105 : unit = ()
        let v106 : (unit -> unit) = closure9(v90, v104)
        let v107 : unit = (fun () -> v106 (); v105) ()
        let v110 : US3 option = _v102.Value 
        let v121 : US3 = US3_1
        let v122 : US3 = v110 |> Option.defaultValue v121 
        let v162 : System.DateTime =
            match v122 with
            | US3_1 -> (* None *)
                let v158 : System.DateTime = System.DateTime.Now
                v158
            | US3_0(v126) -> (* Some *)
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
        let v163 : string = method5()
        let v166 : (string -> string) = v162.ToString
        let v167 : string = v166 v163
        let _v101 = v167 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v170 : US3 option = None
        let _v170 = ref v170 
        let v171 : US3 option ref = _v170 
        let v172 : (US3 option -> US3 option ref) = closure8(v171)
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure9(v90, v172)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v178 : US3 option = _v170.Value 
        let v189 : US3 = US3_1
        let v190 : US3 = v178 |> Option.defaultValue v189 
        let v230 : System.DateTime =
            match v190 with
            | US3_1 -> (* None *)
                let v226 : System.DateTime = System.DateTime.Now
                v226
            | US3_0(v194) -> (* Some *)
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
        let v231 : string = method5()
        let v234 : (string -> string) = v230.ToString
        let v235 : string = v234 v231
        let _v101 = v235 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v238 : string = $"near_sdk::env::block_timestamp()"
        let v239 : uint64 = Fable.Core.RustInterop.emitRustExpr () v238 
        let v240 : US3 option = None
        let _v240 = ref v240 
        let v241 : US3 option ref = _v240 
        let v242 : (US3 option -> US3 option ref) = closure8(v241)
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure9(v90, v242)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v248 : US3 option = _v240.Value 
        let v259 : US3 = US3_1
        let v260 : US3 = v248 |> Option.defaultValue v259 
        let v269 : uint64 =
            match v260 with
            | US3_1 -> (* None *)
                v239
            | US3_0(v264) -> (* Some *)
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
        let v280 : US3 option = None
        let _v280 = ref v280 
        let v281 : US3 option ref = _v280 
        let v282 : (US3 option -> US3 option ref) = closure8(v281)
        let v283 : unit = ()
        let v284 : (unit -> unit) = closure9(v90, v282)
        let v285 : unit = (fun () -> v284 (); v283) ()
        let v288 : US3 option = _v280.Value 
        let v299 : US3 = US3_1
        let v300 : US3 = v288 |> Option.defaultValue v299 
        let v340 : System.DateTime =
            match v300 with
            | US3_1 -> (* None *)
                let v336 : System.DateTime = System.DateTime.Now
                v336
            | US3_0(v304) -> (* Some *)
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
        let v341 : string = method6()
        let v344 : (string -> string) = v340.ToString
        let v345 : string = v344 v341
        let _v101 = v345 
        #endif
#if FABLE_COMPILER_PYTHON
        let v348 : US3 option = None
        let _v348 = ref v348 
        let v349 : US3 option ref = _v348 
        let v350 : (US3 option -> US3 option ref) = closure8(v349)
        let v351 : unit = ()
        let v352 : (unit -> unit) = closure9(v90, v350)
        let v353 : unit = (fun () -> v352 (); v351) ()
        let v356 : US3 option = _v348.Value 
        let v367 : US3 = US3_1
        let v368 : US3 = v356 |> Option.defaultValue v367 
        let v408 : System.DateTime =
            match v368 with
            | US3_1 -> (* None *)
                let v404 : System.DateTime = System.DateTime.Now
                v404
            | US3_0(v372) -> (* Some *)
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
        let v409 : string = method6()
        let v412 : (string -> string) = v408.ToString
        let v413 : string = v412 v409
        let _v101 = v413 
        #endif
#else
        let v416 : US3 option = None
        let _v416 = ref v416 
        let v417 : US3 option ref = _v416 
        let v418 : (US3 option -> US3 option ref) = closure8(v417)
        let v419 : unit = ()
        let v420 : (unit -> unit) = closure9(v90, v418)
        let v421 : unit = (fun () -> v420 (); v419) ()
        let v424 : US3 option = _v416.Value 
        let v435 : US3 = US3_1
        let v436 : US3 = v424 |> Option.defaultValue v435 
        let v476 : System.DateTime =
            match v436 with
            | US3_1 -> (* None *)
                let v472 : System.DateTime = System.DateTime.Now
                v472
            | US3_0(v440) -> (* Some *)
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
        let v477 : string = method6()
        let v480 : (string -> string) = v476.ToString
        let v481 : string = v480 v477
        let _v101 = v481 
        #endif
        let v484 : string = _v101 
        let v554 : string = "Debug"
        let v555 : (unit -> string) = v554.ToLower
        let v556 : string = v555 ()
        let v559 : string = v556.PadLeft (7, ' ')
        let v573 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v574 : string = "inline_colorization::color_bright_blue"
        let v575 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v574 
        let v576 : string = "&*$0"
        let v577 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v576 
        let v578 : string = "inline_colorization::color_reset"
        let v579 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v578 
        let v580 : string = "\"{v575}{v577}{v579}\""
        let v581 : string = @$"format!(" + v580 + ")"
        let v582 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v581 
        let v583 : string = "fable_library_rust::String_::fromString($0)"
        let v584 : string = Fable.Core.RustInterop.emitRustExpr v582 v583 
        let _v573 = v584 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v585 : string = "inline_colorization::color_bright_blue"
        let v586 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v585 
        let v587 : string = "&*$0"
        let v588 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v587 
        let v589 : string = "inline_colorization::color_reset"
        let v590 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v589 
        let v591 : string = "\"{v586}{v588}{v590}\""
        let v592 : string = @$"format!(" + v591 + ")"
        let v593 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v592 
        let v594 : string = "fable_library_rust::String_::fromString($0)"
        let v595 : string = Fable.Core.RustInterop.emitRustExpr v593 v594 
        let _v573 = v595 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v596 : string = "inline_colorization::color_bright_blue"
        let v597 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v596 
        let v598 : string = "&*$0"
        let v599 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v559 v598 
        let v600 : string = "inline_colorization::color_reset"
        let v601 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v600 
        let v602 : string = "\"{v597}{v599}{v601}\""
        let v603 : string = @$"format!(" + v602 + ")"
        let v604 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v603 
        let v605 : string = "fable_library_rust::String_::fromString($0)"
        let v606 : string = Fable.Core.RustInterop.emitRustExpr v604 v605 
        let _v573 = v606 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v607 : string = "\u001b[94m"
        let v608 : string = method7()
        let v609 : string = v607 + v559 
        let v610 : string = v609 + v608 
        let _v573 = v610 
        #endif
#if FABLE_COMPILER_PYTHON
        let v611 : string = "\u001b[94m"
        let v612 : string = method7()
        let v613 : string = v611 + v559 
        let v614 : string = v613 + v612 
        let _v573 = v614 
        #endif
#else
        let v615 : string = "\u001b[94m"
        let v616 : string = method7()
        let v617 : string = v615 + v559 
        let v618 : string = v617 + v616 
        let _v573 = v618 
        #endif
        let v619 : string = _v573 
        let v625 : int64 = v86.l0
        let v626 : int32 = v1.Length
        let v627 : string = method8()
        let v628 : Mut4 = {l0 = v627} : Mut4
        let v629 : string = "{ "
        let v630 : string = $"{v629}"
        let v633 : unit = ()
        let v634 : (unit -> unit) = closure21(v628, v630)
        let v635 : unit = (fun () -> v634 (); v633) ()
        let v638 : string = "exit_code"
        let v639 : string = $"{v638}"
        let v642 : unit = ()
        let v643 : (unit -> unit) = closure21(v628, v639)
        let v644 : unit = (fun () -> v643 (); v642) ()
        let v647 : string = " = "
        let v648 : string = $"{v647}"
        let v651 : unit = ()
        let v652 : (unit -> unit) = closure21(v628, v648)
        let v653 : unit = (fun () -> v652 (); v651) ()
        let v656 : string = $"{v0}"
        let v659 : unit = ()
        let v660 : (unit -> unit) = closure21(v628, v656)
        let v661 : unit = (fun () -> v660 (); v659) ()
        let v664 : string = "; "
        let v665 : string = $"{v664}"
        let v668 : unit = ()
        let v669 : (unit -> unit) = closure21(v628, v665)
        let v670 : unit = (fun () -> v669 (); v668) ()
        let v673 : string = "output_length"
        let v674 : string = $"{v673}"
        let v677 : unit = ()
        let v678 : (unit -> unit) = closure21(v628, v674)
        let v679 : unit = (fun () -> v678 (); v677) ()
        let v682 : string = $"{v647}"
        let v685 : unit = ()
        let v686 : (unit -> unit) = closure21(v628, v682)
        let v687 : unit = (fun () -> v686 (); v685) ()
        let v690 : string = $"{v626}"
        let v693 : unit = ()
        let v694 : (unit -> unit) = closure21(v628, v690)
        let v695 : unit = (fun () -> v694 (); v693) ()
        let v698 : string = " }"
        let v699 : string = $"{v698}"
        let v702 : unit = ()
        let v703 : (unit -> unit) = closure21(v628, v699)
        let v704 : unit = (fun () -> v703 (); v702) ()
        let v707 : string = v628.l0
        let v708 : (unit -> string) = closure36()
        let v709 : string = $"{v484} {v619} #{v625} %s{v708 ()} / {v707}"
        let v712 : char list = []
        let v713 : (char list -> (char [])) = List.toArray
        let v714 : (char []) = v713 v712
        let v717 : string = v709.TrimStart v714 
        let v735 : char list = []
        let v736 : char list = '/' :: v735 
        let v739 : char list = ' ' :: v736 
        let v742 : (char list -> (char [])) = List.toArray
        let v743 : (char []) = v742 v739
        let v746 : string = v717.TrimEnd v743 
        let v764 : unit = ()
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v765 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v746 v765 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v766 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v746 v766 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v767 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v746 v767 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v746 
        let _v764 = () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v746 
        let _v764 = () 
        #endif
#else
        System.Console.WriteLine v746 
        let _v764 = () 
        #endif
        _v764 
        let v768 : (string -> unit) = v18.l0
        v768 v746
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
    let v80 : (unit -> unit) = closure20(v0, v1, v2, v3, v4, v5, v6)
    let v81 : unit = (fun () -> v80 (); v79) ()
    let v1160 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v1164 : string =
        match v50 with
        | US1_1 -> (* None *)
            let v1162 : string = ""
            v1162
        | US1_0(v1161) -> (* Some *)
            v1161
    let start_info = System.Diagnostics.ProcessStartInfo (
      Arguments = v1164,
      StandardOutputEncoding = v1160,
      WorkingDirectory = v78,
      FileName = v49,
      CreateNoWindow = true,
      RedirectStandardError = true,
      RedirectStandardOutput = true,
      UseShellExecute = false
    )
    let v1165 : System.Diagnostics.ProcessStartInfo = start_info
    let v1166 : int32 = v2.Length
    let v1167 : Mut5 = {l0 = 0} : Mut5
    while method11(v1166, v1167) do
        let v1169 : int32 = v1167.l0
        let struct (v1170 : string, v1171 : string) = v2.[int v1169]
        v1165.EnvironmentVariables.[v1170] <- v1171 
        let v1172 : int32 = v1169 + 1
        v1167.l0 <- v1172
        ()
    let v1173 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v1165)
    use v1173 = v1173 
    let v1174 : System.Diagnostics.Process = v1173 
    let v1175 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v1176 : System.Collections.Concurrent.ConcurrentStack<string> = v1175 ()
    let v1177 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure23(v0, v1, v2, v3, v4, v5, v6, v1174, v1176)
    v1174.OutputDataReceived.Add v1177 
    let v1178 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure29(v0, v1, v2, v3, v4, v5, v6, v1174, v1176)
    v1174.ErrorDataReceived.Add v1178 
    let v1179 : (unit -> bool) = v1174.Start
    let v1180 : bool = v1179 ()
    let v1181 : bool = v1180 = false
    if v1181 then
        let v1182 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v1182
    let v1183 : (unit -> unit) = v1174.BeginErrorReadLine
    v1183 ()
    let v1184 : (unit -> unit) = v1174.BeginOutputReadLine
    v1184 ()
    let v1185 : US13 option = None
    let _v1185 = ref v1185 
    let v1186 : US13 option ref = _v1185 
    let v1187 : (US13 option -> US13 option ref) = closure30(v1186)
    let v1188 : unit = ()
    let v1189 : (unit -> unit) = closure31(v1, v1187)
    let v1190 : unit = (fun () -> v1189 (); v1188) ()
    let v1193 : US13 option = _v1185.Value 
    let v1204 : US13 = US13_1
    let v1205 : US13 = v1193 |> Option.defaultValue v1204 
    let v1212 : System.Threading.CancellationToken =
        match v1205 with
        | US13_1 -> (* None *)
            let v1210 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v1210
        | US13_0(v1209) -> (* Some *)
            v1209
    let v1213 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1214 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1213 = v1214 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1217 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1213 = v1217 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1220 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1213 = v1220 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1223 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1213 = v1223 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1226 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1213 = v1226 
    #endif
#else
    let v1229 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1230 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1229 = v1230 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1233 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1229 = v1233 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1236 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1229 = v1236 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1239 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1229 = v1239 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1242 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1229 = v1242 
    #endif
#else
    let v1245 : Async<System.Threading.CancellationToken> option = None
    let mutable _v1245 = v1245 
    async {
    let v1246 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v1246 = v1246 
    let v1247 : System.Threading.CancellationToken = v1246 
    let v1248 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v1249 : (System.Threading.CancellationToken []) = [|v1247; v1248; v1212|]
    let v1250 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v1251 : System.Threading.CancellationTokenSource = v1250 v1249
    let v1252 : System.Threading.CancellationToken = v1251.Token
    return v1252 
    }
    |> fun x -> _v1245 <- Some x
    let v1253 : Async<System.Threading.CancellationToken> = match _v1245 with Some x -> x | None -> failwith "async.new_async_unit / _v1245=None"
    let _v1229 = v1253 
    #endif
    let v1254 : Async<System.Threading.CancellationToken> = _v1229 
    let _v1213 = v1254 
    #endif
    let v1259 : Async<System.Threading.CancellationToken> = _v1213 
    let! v1259 = v1259 
    let v1264 : System.Threading.CancellationToken = v1259 
    let v1265 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v1264.Register
    let v1266 : (unit -> unit) = closure32(v1174)
    let v1267 : System.Threading.CancellationTokenRegistration = v1265 v1266
    use v1267 = v1267 
    let v1268 : System.Threading.CancellationTokenRegistration = v1267 
    let v1269 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1270 : Async<int32> = null |> unbox<Async<int32>>
    let _v1269 = v1270 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1273 : Async<int32> = null |> unbox<Async<int32>>
    let _v1269 = v1273 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1276 : Async<int32> = null |> unbox<Async<int32>>
    let _v1269 = v1276 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1279 : Async<int32> = null |> unbox<Async<int32>>
    let _v1269 = v1279 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1282 : Async<int32> = null |> unbox<Async<int32>>
    let _v1269 = v1282 
    #endif
#else
    let v1285 : Async<int32> option = None
    let mutable _v1285 = v1285 
    async {
    try
    let v1286 : System.Threading.Tasks.Task = v1174.WaitForExitAsync v1264 
    let v1287 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1288 : Async<unit> = null |> unbox<Async<unit>>
    let _v1287 = v1288 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1291 : Async<unit> = null |> unbox<Async<unit>>
    let _v1287 = v1291 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1294 : Async<unit> = null |> unbox<Async<unit>>
    let _v1287 = v1294 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1297 : Async<unit> = null |> unbox<Async<unit>>
    let _v1287 = v1297 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1300 : Async<unit> = null |> unbox<Async<unit>>
    let _v1287 = v1300 
    #endif
#else
    let v1303 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v1304 : Async<unit> = v1303 v1286
    let _v1287 = v1304 
    #endif
    let v1305 : Async<unit> = _v1287 
    do! v1305 
    let v1310 : int32 = v1174.ExitCode
    return v1310 
    with ex ->
    let v1311 : exn = ex
    let v1312 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1313 : string = $"%A{v1311}"
    let _v1312 = v1313 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1316 : string = $"%A{v1311}"
    let _v1312 = v1316 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1319 : string = $"%A{v1311}"
    let _v1312 = v1319 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1322 : string = $"%A{v1311}"
    let _v1312 = v1322 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1325 : string = $"%A{v1311}"
    let _v1312 = v1325 
    #endif
#else
    let v1328 : string = $"{v1311.GetType ()}: {v1311.Message}"
    let _v1312 = v1328 
    #endif
    let v1329 : string = _v1312 
    let v1334 : (string -> unit) = v1176.Push
    v1334 v1329
    let v1335 : System.Threading.Tasks.TaskCanceledException = v1311 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v1338 : unit = ()
    let v1339 : (unit -> unit) = closure33(v1335)
    let v1340 : unit = (fun () -> v1339 (); v1338) ()
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v1285 <- Some x
    let v2100 : Async<int32> = match _v1285 with Some x -> x | None -> failwith "async.new_async_unit / _v1285=None"
    let _v1269 = v2100 
    #endif
    let v2101 : Async<int32> = _v1269 
    let! v2101 = v2101 
    let v2106 : int32 = v2101 
    let v2107 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v2108 : string seq = v2107 v1176
    let v2111 : (string -> (string seq -> string)) = String.concat
    let v2112 : string = "\n"
    let v2113 : (string seq -> string) = v2111 v2112
    let v2114 : string = v2113 v2108
    let v2117 : unit = ()
    let v2118 : (unit -> unit) = closure35(v2106, v2114)
    let v2119 : unit = (fun () -> v2118 (); v2117) ()
    return struct (v2106, v2114) 
    }
    |> fun x -> _v39 <- Some x
    let v2887 : Async<struct (int32 * string)> = match _v39 with Some x -> x | None -> failwith "async.new_async_unit / _v39=None"
    let _v23 = v2887 
    #endif
    let v2888 : Async<struct (int32 * string)> = _v23 
    let _v7 = v2888 
    #endif
    let v2893 : Async<struct (int32 * string)> = _v7 
    v2893
and closure15 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method9(v0, v1, v2, v3, v4, v6, v5)
and closure37 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method9(v0, v1, v2, v3, v4, v5, v6)
and closure38 () (v0 : (Heap0 -> Heap0)) : struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) =
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
and closure40 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
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
and closure41 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
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
            let v97 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure40()
            let v98 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure41()
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
                let v289 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure40()
                let v290 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure41()
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
and closure39 () (v0 : string) : Result<(string []), string> =
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
let v15 : (unit -> unit) = closure4()
let current_process_kill () = v15 ()
let v16 : (string -> Async<struct (int32 * string)>) = closure15()
let execute_async x = v16 x
let v17 : (struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) -> Async<struct (int32 * string)>) = closure37()
let execute_with_options_async x = v17 x
let v18 : ((Heap0 -> Heap0) -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure38()
let execution_options x = v18 x
let v19 : (string -> Result<(string []), string>) = closure39()
let split_args x = v19 x
()
