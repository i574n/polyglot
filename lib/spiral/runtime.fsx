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
    | US1_0 of f0_0 : US0
    | US1_1
and [<Struct>] US2 =
    | US2_0 of f0_0 : int64
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : string
    | US3_1
and Mut4 = {mutable l0 : string}
and [<Struct>] US4 =
    | US4_0 of f0_0 : string * f0_1 : US3
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
    | US9_0 of f0_0 : string * f0_1 : US3 * f0_2 : string * f0_3 : System.Text.StringBuilder * f0_4 : int32 * f0_5 : int32
    | US9_1 of f1_0 : string
and [<Struct>] US10 =
    | US10_0 of f0_0 : US7 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
    | US10_1 of f1_0 : string
and [<Struct>] US11 =
    | US11_0 of f0_0 : US3 * f0_1 : string * f0_2 : System.Text.StringBuilder * f0_3 : int32 * f0_4 : int32
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
let rec method0 () : string =
    let v0 : string = "TRACE_LEVEL"
    v0
and method2 () : string =
    let v0 : string = ""
    v0
and method1 (v0 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "std::env::var(&*$0)"
    let v5 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : string = "true; let _result = $0.map(|x| { //"
    let v7 : bool = Fable.Core.RustInterop.emitRustExpr v5 v6 
    let v8 : string = "x"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v8 
    let v10 : string = "fable_library_rust::String_::fromString($0)"
    let v11 : string = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = "true; $0 })"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr v11 v12 
    let v14 : string = "_result"
    let v15 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v14 
    let v16 : string = method2()
    let v17 : string = "$0.unwrap_or($1)"
    let v18 : string = Fable.Core.RustInterop.emitRustExpr struct (v15, v16) v17 
    v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v19 : string = "std::env::var(&*$0)"
    let v20 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v19 
    let v21 : string = "true; let _result = $0.map(|x| { //"
    let v22 : bool = Fable.Core.RustInterop.emitRustExpr v20 v21 
    let v23 : string = "x"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let v27 : string = "true; $0 })"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v26 v27 
    let v29 : string = "_result"
    let v30 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = method2()
    let v32 : string = "$0.unwrap_or($1)"
    let v33 : string = Fable.Core.RustInterop.emitRustExpr struct (v30, v31) v32 
    v33 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = "std::env::var(&*$0)"
    let v35 : Result<std_string_String, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr v0 v34 
    let v36 : string = "true; let _result = $0.map(|x| { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v35 v36 
    let v38 : string = "x"
    let v39 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v38 
    let v40 : string = "fable_library_rust::String_::fromString($0)"
    let v41 : string = Fable.Core.RustInterop.emitRustExpr v39 v40 
    let v42 : string = "true; $0 })"
    let v43 : bool = Fable.Core.RustInterop.emitRustExpr v41 v42 
    let v44 : string = "_result"
    let v45 : Result<string, std_env_VarError> = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = method2()
    let v47 : string = "$0.unwrap_or($1)"
    let v48 : string = Fable.Core.RustInterop.emitRustExpr struct (v45, v46) v47 
    v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v49 : string = "process.env[$0] ?? \"\""
    let v50 : string = Fable.Core.JsInterop.emitJsExpr v0 v49 
    v50 
    #endif
#if FABLE_COMPILER_PYTHON
    let v53 : string = "os"
    let v54 : IOsEnviron = Fable.Core.PyInterop.importAll v53 
    let v55 : string = "v54.environ"
    let v56 : obj = Fable.Core.PyInterop.emitPyExpr () v55 
    let v65 : string = "v56.get($0)"
    let v66 : string = Fable.Core.PyInterop.emitPyExpr v0 v65 
    let mutable _v66 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v75 : (string -> string option) = Option.ofObj
    let v76 : string option = v75 v66
    v76 
    #else
    Some v66 
    #endif
    |> fun x -> _v66 <- Some x
    let v77 : string option = match _v66 with Some x -> x | None -> failwith "optionm'.of_obj / _v66=None"
    let v86 : US3 option = None
    let _v86 = ref v86 
    match v77 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v87 : string = x
    let v88 : US3 = US3_0(v87)
    v88 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v86.Value <- x
    let v89 : US3 option = _v86.Value 
    let v112 : US3 = US3_1
    let v113 : US3 = v89 |> Option.defaultValue v112 
    let v124 : string =
        match v113 with
        | US3_1 -> (* None *)
            let v122 : string = ""
            v122
        | US3_0(v121) -> (* Some *)
            v121
    v124 
    #endif
#else
    let v125 : (string -> string) = System.Environment.GetEnvironmentVariable
    let v126 : string = v125 v0
    let mutable _v126 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v129 : (string -> string option) = Option.ofObj
    let v130 : string option = v129 v126
    v130 
    #else
    Some v126 
    #endif
    |> fun x -> _v126 <- Some x
    let v131 : string option = match _v126 with Some x -> x | None -> failwith "optionm'.of_obj / _v126=None"
    let v140 : US3 option = None
    let _v140 = ref v140 
    match v131 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v141 : string = x
    let v142 : US3 = US3_0(v141)
    v142 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v140.Value <- x
    let v143 : US3 option = _v140.Value 
    let v166 : US3 = US3_1
    let v167 : US3 = v143 |> Option.defaultValue v166 
    let v178 : string =
        match v167 with
        | US3_1 -> (* None *)
            let v176 : string = ""
            v176
        | US3_0(v175) -> (* Some *)
            v175
    v178 
    #endif
    |> fun x -> _v3 <- Some x
    let v179 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v179
and method3 () : string =
    let v0 : string = "AUTOMATION"
    v0
and closure1 () (v0 : string) : unit =
    ()
and closure0 () (v0 : US0) : struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option) =
    let v3 : bool = true
    let mutable _v3 : struct (US1 * US2) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method0()
    let v5 : string = method1(v4)
    let v7 : bool = "Verbose" = v5
    let v11 : US1 =
        if v7 then
            let v8 : US0 = US0_0
            US1_0(v8)
        else
            US1_1
    let v56 : US1 =
        match v11 with
        | US1_1 -> (* None *)
            let v15 : bool = "Debug" = v5
            let v19 : US1 =
                if v15 then
                    let v16 : US0 = US0_1
                    US1_0(v16)
                else
                    US1_1
            match v19 with
            | US1_1 -> (* None *)
                let v23 : bool = "Info" = v5
                let v27 : US1 =
                    if v23 then
                        let v24 : US0 = US0_2
                        US1_0(v24)
                    else
                        US1_1
                match v27 with
                | US1_1 -> (* None *)
                    let v31 : bool = "Warning" = v5
                    let v35 : US1 =
                        if v31 then
                            let v32 : US0 = US0_3
                            US1_0(v32)
                        else
                            US1_1
                    match v35 with
                    | US1_1 -> (* None *)
                        let v39 : bool = "Critical" = v5
                        let v43 : US1 =
                            if v39 then
                                let v40 : US0 = US0_4
                                US1_0(v40)
                            else
                                US1_1
                        match v43 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v44) -> (* Some *)
                            US1_0(v44)
                    | US1_0(v36) -> (* Some *)
                        US1_0(v36)
                | US1_0(v28) -> (* Some *)
                    US1_0(v28)
            | US1_0(v20) -> (* Some *)
                US1_0(v20)
        | US1_0(v12) -> (* Some *)
            US1_0(v12)
    let v57 : string = method3()
    let v58 : string = method1(v57)
    let v60 : bool = v58 = "True"
    let v82 : US2 =
        if v60 then
            let v63 : System.DateTime = System.DateTime.Now
            let v72 : (System.DateTime -> int64) = _.Ticks
            let v73 : int64 = v72 v63
            US2_0(v73)
        else
            US2_1
    struct (v56, v82) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v83 : US1 = US1_1
    let v84 : US2 = US2_1
    struct (v83, v84) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v85 : string = "AUTOMATION"
    let v88 : bool = true
    let mutable _v88 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v89 : string = "env!(\"" + v85 + "\")"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v89 
    let v91 : string = "String::from($0)"
    let v92 : std_string_String = Fable.Core.RustInterop.emitRustExpr v90 v91 
    let v93 : string = "fable_library_rust::String_::fromString($0)"
    let v94 : string = Fable.Core.RustInterop.emitRustExpr v92 v93 
    v94 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v95 : string = "env!(\"" + v85 + "\")"
    let v96 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "String::from($0)"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr v96 v97 
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99 
    v100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v101 : string = "env!(\"" + v85 + "\")"
    let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "String::from($0)"
    let v104 : std_string_String = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : string = "fable_library_rust::String_::fromString($0)"
    let v106 : string = Fable.Core.RustInterop.emitRustExpr v104 v105 
    v106 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v109 : string = null |> unbox<string>
    v109 
    #endif
#if FABLE_COMPILER_PYTHON
    let v118 : string = null |> unbox<string>
    v118 
    #endif
#else
    let v127 : string = null |> unbox<string>
    v127 
    #endif
    |> fun x -> _v88 <- Some x
    let v134 : string = match _v88 with Some x -> x | None -> failwith "base.run_target / _v88=None"
    let v151 : string = "True"
    let v152 : bool = v134 <> v151 
    let v165 : US2 =
        if v152 then
            US2_1
        else
            let v160 : string = $"near_sdk::env::block_timestamp()"
            let v161 : uint64 = Fable.Core.RustInterop.emitRustExpr () v160 
            let v162 : (uint64 -> int64) = int64
            let v163 : int64 = v162 v161
            US2_0(v163)
    let v166 : US1 = US1_1
    struct (v166, v165) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v167 : string = method0()
    let v168 : string = method1(v167)
    let v170 : bool = "Verbose" = v168
    let v174 : US1 =
        if v170 then
            let v171 : US0 = US0_0
            US1_0(v171)
        else
            US1_1
    let v219 : US1 =
        match v174 with
        | US1_1 -> (* None *)
            let v178 : bool = "Debug" = v168
            let v182 : US1 =
                if v178 then
                    let v179 : US0 = US0_1
                    US1_0(v179)
                else
                    US1_1
            match v182 with
            | US1_1 -> (* None *)
                let v186 : bool = "Info" = v168
                let v190 : US1 =
                    if v186 then
                        let v187 : US0 = US0_2
                        US1_0(v187)
                    else
                        US1_1
                match v190 with
                | US1_1 -> (* None *)
                    let v194 : bool = "Warning" = v168
                    let v198 : US1 =
                        if v194 then
                            let v195 : US0 = US0_3
                            US1_0(v195)
                        else
                            US1_1
                    match v198 with
                    | US1_1 -> (* None *)
                        let v202 : bool = "Critical" = v168
                        let v206 : US1 =
                            if v202 then
                                let v203 : US0 = US0_4
                                US1_0(v203)
                            else
                                US1_1
                        match v206 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v207) -> (* Some *)
                            US1_0(v207)
                    | US1_0(v199) -> (* Some *)
                        US1_0(v199)
                | US1_0(v191) -> (* Some *)
                    US1_0(v191)
            | US1_0(v183) -> (* Some *)
                US1_0(v183)
        | US1_0(v175) -> (* Some *)
            US1_0(v175)
    let v220 : string = method3()
    let v221 : string = method1(v220)
    let v222 : bool = v221 = "True"
    let v244 : US2 =
        if v222 then
            let v225 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v225
            US2_0(v235)
        else
            US2_1
    struct (v219, v244) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v245 : string = method0()
    let v246 : string = method1(v245)
    let v248 : bool = "Verbose" = v246
    let v252 : US1 =
        if v248 then
            let v249 : US0 = US0_0
            US1_0(v249)
        else
            US1_1
    let v297 : US1 =
        match v252 with
        | US1_1 -> (* None *)
            let v256 : bool = "Debug" = v246
            let v260 : US1 =
                if v256 then
                    let v257 : US0 = US0_1
                    US1_0(v257)
                else
                    US1_1
            match v260 with
            | US1_1 -> (* None *)
                let v264 : bool = "Info" = v246
                let v268 : US1 =
                    if v264 then
                        let v265 : US0 = US0_2
                        US1_0(v265)
                    else
                        US1_1
                match v268 with
                | US1_1 -> (* None *)
                    let v272 : bool = "Warning" = v246
                    let v276 : US1 =
                        if v272 then
                            let v273 : US0 = US0_3
                            US1_0(v273)
                        else
                            US1_1
                    match v276 with
                    | US1_1 -> (* None *)
                        let v280 : bool = "Critical" = v246
                        let v284 : US1 =
                            if v280 then
                                let v281 : US0 = US0_4
                                US1_0(v281)
                            else
                                US1_1
                        match v284 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v285) -> (* Some *)
                            US1_0(v285)
                    | US1_0(v277) -> (* Some *)
                        US1_0(v277)
                | US1_0(v269) -> (* Some *)
                    US1_0(v269)
            | US1_0(v261) -> (* Some *)
                US1_0(v261)
        | US1_0(v253) -> (* Some *)
            US1_0(v253)
    let v298 : string = method3()
    let v299 : string = method1(v298)
    let v300 : bool = v299 = "True"
    let v322 : US2 =
        if v300 then
            let v303 : System.DateTime = System.DateTime.Now
            let v312 : (System.DateTime -> int64) = _.Ticks
            let v313 : int64 = v312 v303
            US2_0(v313)
        else
            US2_1
    struct (v297, v322) 
    #endif
#else
    let v323 : string = method0()
    let v324 : string = method1(v323)
    let v326 : bool = "Verbose" = v324
    let v330 : US1 =
        if v326 then
            let v327 : US0 = US0_0
            US1_0(v327)
        else
            US1_1
    let v375 : US1 =
        match v330 with
        | US1_1 -> (* None *)
            let v334 : bool = "Debug" = v324
            let v338 : US1 =
                if v334 then
                    let v335 : US0 = US0_1
                    US1_0(v335)
                else
                    US1_1
            match v338 with
            | US1_1 -> (* None *)
                let v342 : bool = "Info" = v324
                let v346 : US1 =
                    if v342 then
                        let v343 : US0 = US0_2
                        US1_0(v343)
                    else
                        US1_1
                match v346 with
                | US1_1 -> (* None *)
                    let v350 : bool = "Warning" = v324
                    let v354 : US1 =
                        if v350 then
                            let v351 : US0 = US0_3
                            US1_0(v351)
                        else
                            US1_1
                    match v354 with
                    | US1_1 -> (* None *)
                        let v358 : bool = "Critical" = v324
                        let v362 : US1 =
                            if v358 then
                                let v359 : US0 = US0_4
                                US1_0(v359)
                            else
                                US1_1
                        match v362 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v363) -> (* Some *)
                            US1_0(v363)
                    | US1_0(v355) -> (* Some *)
                        US1_0(v355)
                | US1_0(v347) -> (* Some *)
                    US1_0(v347)
            | US1_0(v339) -> (* Some *)
                US1_0(v339)
        | US1_0(v331) -> (* Some *)
            US1_0(v331)
    let v376 : string = method3()
    let v377 : string = method1(v376)
    let v378 : bool = v377 = "True"
    let v400 : US2 =
        if v378 then
            let v381 : System.DateTime = System.DateTime.Now
            let v390 : (System.DateTime -> int64) = _.Ticks
            let v391 : int64 = v390 v381
            US2_0(v391)
        else
            US2_1
    struct (v375, v400) 
    #endif
    |> fun x -> _v3 <- Some x
    let struct (v401 : US1, v402 : US2) = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v487 : Mut2 = {l0 = true} : Mut2
    let v488 : Mut0 = {l0 = 0L} : Mut0
    let v491 : US0 =
        match v401 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v489) -> (* Some *)
            v489
    let v492 : Mut3 = {l0 = v491} : Mut3
    let v493 : (string -> unit) = closure1()
    let v494 : Mut1 = {l0 = v493} : Mut1
    let v507 : int64 option =
        match v402 with
        | US2_1 -> (* None *)
            let v505 : int64 option = None
            v505
        | US2_0(v495) -> (* Some *)
            let v498 : int64 option = Some v495 
            v498
    struct (v488, v494, v487, v492, v507)
and closure4 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 3"
    v0
and closure5 () () : unit =
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
and method8 (v0 : Mut4) : unit =
    ()
and closure6 (v0 : US0, v1 : (unit -> string), v2 : (unit -> unit)) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    v2 ()
    let v1215 : string = ""
    let v1216 : Mut4 = {l0 = v1215} : Mut4
    method8(v1216)
    let v1217 : string = v1216.l0
    let v1220 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1217}"
    let v1227 : char list = []
    let v1232 : (char list -> (char [])) = List.toArray
    let v1233 : (char []) = v1232 v1227
    let v1240 : string = v1220.TrimStart v1233 
    let v1279 : char list = []
    let v1282 : char list = '/' :: v1279 
    let v1291 : char list = ' ' :: v1282 
    let v1302 : (char list -> (char [])) = List.toArray
    let v1303 : (char []) = v1302 v1291
    let v1310 : string = v1240.TrimEnd v1303 
    v1310
and method9 (v0 : US0, v1 : (unit -> string)) : unit =
    let v4 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v5 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v5 |> Some
    let struct (v13 : Mut0, v14 : Mut1, v15 : Mut2, v16 : Mut3, v17 : int64 option) = State.trace_state.Value
    let v34 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v4 v34 |> Some
    let struct (v42 : Mut0, v43 : Mut1, v44 : Mut2, v45 : Mut3, v46 : int64 option) = State.trace_state.Value
    let v61 : US0 = v45.l0
    let v62 : bool = v44.l0
    let v63 : bool = v62 = false
    let v67 : bool =
        if v63 then
            false
        else
            let v64 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v65 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v61
            let v66 : bool = v64 >= v65
            v66
    if v67 then
        let v68 : int64 = v13.l0
        let v69 : int64 = v68 + 1L
        v13.l0 <- v69
        let v72 : string = $"%s{v1 ()}"
        let v81 : bool = true
        let mutable _v81 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v82 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v82 
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v83 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v83 
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v84 : string = $"near_sdk::log!(\"{{}}\", $0)"
        Fable.Core.RustInterop.emitRustExpr v72 v84 
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v72 
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v72 
        () 
        #endif
#else
        System.Console.WriteLine v72 
        () 
        #endif
        |> fun x -> _v81 <- Some x
        match _v81 with Some x -> x | None -> failwith "base.run_target / _v81=None"
        let v113 : (string -> unit) = v14.l0
        v113 v72
and method4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> unit)) : unit =
    let v3 : (unit -> string) = closure6(v0, v1, v2)
    method9(v0, v3)
and closure7 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 2"
    v0
and closure8 () () : string =
    let v0 : string = "runtime.current_process_kill / exiting... 1"
    v0
and closure3 () () : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v33 : US0 = US0_3
    let v34 : (unit -> string) = closure4()
    let v35 : (unit -> unit) = closure5()
    method4(v33, v34, v35)
    System.Threading.Thread.Sleep 300
    let v36 : US0 = US0_3
    let v37 : (unit -> string) = closure7()
    method4(v36, v37, v35)
    System.Console.Out.Flush ()
    System.Threading.Thread.Sleep 60
    let v38 : US0 = US0_3
    let v39 : (unit -> string) = closure8()
    method4(v38, v39, v35)
    System.Diagnostics.Process.GetCurrentProcess().Kill ()
    () 
    #endif
    |> fun x -> _v2 <- Some x
    match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    ()
and closure2 () () : unit =
    let v2 : bool = true
    let mutable _v2 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v33 : (unit -> unit) = closure3()
    let v34 : System.Threading.Thread = new System.Threading.Thread (v33)
    let v35 : (System.Threading.Thread -> unit) = _.Start()
    v35 v34
    () 
    #endif
    |> fun x -> _v2 <- Some x
    match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    ()
and method12 (v0 : int32, v1 : Mut5) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure12 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure11 () (v0 : char) : (UH0 -> UH0) =
    closure12(v0)
and method13 () : (char -> (UH0 -> UH0)) =
    closure11()
and method14 (v0 : UH0, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : struct (System.Text.StringBuilder * int32 * int32) =
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
        let v25 : System.Text.StringBuilder =
            if v6 then
                let v11 : (unit -> System.Text.StringBuilder) = v1.Clear
                let v12 : System.Text.StringBuilder = v11 ()
                v1
            else
                let v15 : (char -> string) = _.ToString()
                let v16 : string = v15 v4
                let v23 : (string -> System.Text.StringBuilder) = v1.Append
                let v24 : System.Text.StringBuilder = v23 v16
                v1
        method14(v5, v25, v9, v10)
    | UH0_0 -> (* Nil *)
        struct (v1, v2, v3)
and closure10 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
            let v18 : (char -> string) = _.ToString()
            let v19 : string = v18 v7
            let v26 : int32 = v19.Length
            let v27 : (char []) = Array.zeroCreate<char> (v26)
            let v28 : Mut5 = {l0 = 0} : Mut5
            while method12(v26, v28) do
                let v30 : int32 = v28.l0
                let v31 : char = v19.[int v30]
                v27.[int v30] <- v31
                let v32 : int32 = v30 + 1
                v28.l0 <- v32
                ()
            let v33 : char list = v27 |> Array.toList
            let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v37 : (char -> (UH0 -> UH0)) = method13()
            let v38 : (char list -> (UH0 -> UH0)) = v36 v37
            let v39 : (UH0 -> UH0) = v38 v33
            let v40 : UH0 = UH0_0
            let v41 : UH0 = v39 v40
            let struct (v50 : System.Text.StringBuilder, v51 : int32, v52 : int32) = method14(v41, v1, v2, v3)
            US5_0(v7, v15, v50, v51, v52)
        else
            let v54 : (string -> int32) = String.length
            let v55 : int32 = v54 v0
            let v56 : string = "\n"
            let v57 : int32 = v0.IndexOf v56 
            let v58 : int32 = v57 - 1
            let v59 : bool = -2 = v58
            let v60 : int32 =
                if v59 then
                    v55
                else
                    v58
            let v61 : (int32 -> int32) = int32
            let v62 : int32 = v61 0
            let v63 : (int32 -> int32) = int32
            let v64 : int32 = v63 v60
            let v65 : string = v0.[int v62..int v64]
            let v66 : string = $"parsing.p_char / expected: '{'"'}' / line: {v2} / col: {v3}
{v1}{v65}"
            let v67 : int32 = v3 - 1
            let v70 : (int32 -> (string -> string)) = String.replicate
            let v71 : (string -> string) = v70 v67
            let v72 : string = " "
            let v73 : string = v71 v72
            let v80 : string = "^"
            let v81 : string = v73 + v80 
            let v82 : string = $"{v66}
{v81}
"
            US5_1(v82)
and closure13 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US5 =
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
            let v18 : (char -> string) = _.ToString()
            let v19 : string = v18 v7
            let v26 : int32 = v19.Length
            let v27 : (char []) = Array.zeroCreate<char> (v26)
            let v28 : Mut5 = {l0 = 0} : Mut5
            while method12(v26, v28) do
                let v30 : int32 = v28.l0
                let v31 : char = v19.[int v30]
                v27.[int v30] <- v31
                let v32 : int32 = v30 + 1
                v28.l0 <- v32
                ()
            let v33 : char list = v27 |> Array.toList
            let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v37 : (char -> (UH0 -> UH0)) = method13()
            let v38 : (char list -> (UH0 -> UH0)) = v36 v37
            let v39 : (UH0 -> UH0) = v38 v33
            let v40 : UH0 = UH0_0
            let v41 : UH0 = v39 v40
            let struct (v50 : System.Text.StringBuilder, v51 : int32, v52 : int32) = method14(v41, v1, v2, v3)
            US5_0(v7, v15, v50, v51, v52)
        else
            let v54 : (string -> int32) = String.length
            let v55 : int32 = v54 v0
            let v56 : string = "\n"
            let v57 : int32 = v0.IndexOf v56 
            let v58 : int32 = v57 - 1
            let v59 : bool = -2 = v58
            let v60 : int32 =
                if v59 then
                    v55
                else
                    v58
            let v61 : (int32 -> int32) = int32
            let v62 : int32 = v61 0
            let v63 : (int32 -> int32) = int32
            let v64 : int32 = v63 v60
            let v65 : string = v0.[int v62..int v64]
            let v66 : string = $"parsing.p_char / expected: '{'''}' / line: {v2} / col: {v3}
{v1}{v65}"
            let v67 : int32 = v3 - 1
            let v70 : (int32 -> (string -> string)) = String.replicate
            let v71 : (string -> string) = v70 v67
            let v72 : string = " "
            let v73 : string = v71 v72
            let v80 : string = "^"
            let v81 : string = v73 + v80 
            let v82 : string = $"{v66}
{v81}
"
            US5_1(v82)
and method15 (v0 : string, v1 : System.Text.StringBuilder, v2 : UH1) : US5 =
    match v2 with
    | UH1_1(v5, v6) -> (* Cons *)
        let v7 : US5 = v5 struct (v0, v1, 1, 1)
        match v7 with
        | US5_1(v13) -> (* Error *)
            method15(v0, v1, v6)
        | US5_0(v8, v9, v10, v11, v12) -> (* Ok *)
            v7
    | UH1_0 -> (* Nil *)
        let v3 : string = "choice / no parsers succeeded"
        US5_1(v3)
and method16 (v0 : char, v1 : int64) : bool =
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
            method16(v0, v17)
and method17 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v118 : US5 =
        if v5 then
            let v6 : char list = []
            let v9 : char list = ''' :: v6 
            let v18 : char list = '"' :: v9 
            let v27 : (char list -> (char [])) = List.toArray
            let v28 : (char []) = v27 v18
            let v35 : string = $"parsing.none_of / unexpected end of input / chars: %A{v28} / s: %A{struct (v2, v3, v4)}"
            US5_1(v35)
        else
            let v37 : char = v1.[int 0]
            let v38 : (string -> int32) = String.length
            let v39 : int32 = v38 v1
            let v40 : (int32 -> int32) = int32
            let v41 : int32 = v40 1
            let v42 : (int32 -> int32) = int32
            let v43 : int32 = v42 v39
            let v44 : string = v1.[int v41..int v43]
            let v45 : int64 = 0L
            let v46 : bool = method16(v37, v45)
            let v47 : bool = v46 = false
            if v47 then
                let v50 : (char -> string) = _.ToString()
                let v51 : string = v50 v37
                let v58 : int32 = v51.Length
                let v59 : (char []) = Array.zeroCreate<char> (v58)
                let v60 : Mut5 = {l0 = 0} : Mut5
                while method12(v58, v60) do
                    let v62 : int32 = v60.l0
                    let v63 : char = v51.[int v62]
                    v59.[int v62] <- v63
                    let v64 : int32 = v62 + 1
                    v60.l0 <- v64
                    ()
                let v65 : char list = v59 |> Array.toList
                let v68 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v69 : (char -> (UH0 -> UH0)) = method13()
                let v70 : (char list -> (UH0 -> UH0)) = v68 v69
                let v71 : (UH0 -> UH0) = v70 v65
                let v72 : UH0 = UH0_0
                let v73 : UH0 = v71 v72
                let struct (v82 : System.Text.StringBuilder, v83 : int32, v84 : int32) = method14(v73, v2, v3, v4)
                US5_0(v37, v44, v82, v83, v84)
            else
                let v86 : char list = []
                let v89 : char list = ''' :: v86 
                let v98 : char list = '"' :: v89 
                let v107 : (char list -> (char [])) = List.toArray
                let v108 : (char []) = v107 v98
                let v115 : string = $"parsing.none_of / unexpected char: '{v37}' / chars: %A{v108} / s: %A{struct (v2, v3, v4)}"
                US5_1(v115)
    let v130 : US5 =
        match v118 with
        | US5_1(v127) -> (* Error *)
            US5_1(v127)
        | US5_0(v119, v120, v121, v122, v123) -> (* Ok *)
            let v124 : bool = '\\' = v119
            let v125 : char =
                if v124 then
                    '/'
                else
                    v119
            US5_0(v125, v120, v121, v122, v123)
    match v130 with
    | US5_1(v148) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v131, v132, v133, v134, v135) -> (* Ok *)
        let v138 : (char -> string) = _.ToString()
        let v139 : string = v138 v131
        let v146 : string = v0 + v139 
        method17(v146, v132, v133, v134, v135)
and method18 (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32, v4 : UH1) : US5 =
    match v4 with
    | UH1_1(v7, v8) -> (* Cons *)
        let v9 : US5 = v7 struct (v0, v1, v2, v3)
        match v9 with
        | US5_1(v15) -> (* Error *)
            method18(v0, v1, v2, v3, v8)
        | US5_0(v10, v11, v12, v13, v14) -> (* Ok *)
            v9
    | UH1_0 -> (* Nil *)
        let v5 : string = "choice / no parsers succeeded"
        US5_1(v5)
and method19 (v0 : char, v1 : int64) : bool =
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
            method19(v0, v21)
and method20 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v136 : US5 =
        if v5 then
            let v6 : char list = []
            let v9 : char list = ' ' :: v6 
            let v18 : char list = ''' :: v9 
            let v27 : char list = '"' :: v18 
            let v36 : (char list -> (char [])) = List.toArray
            let v37 : (char []) = v36 v27
            let v44 : string = $"parsing.none_of / unexpected end of input / chars: %A{v37} / s: %A{struct (v2, v3, v4)}"
            US5_1(v44)
        else
            let v46 : char = v1.[int 0]
            let v47 : (string -> int32) = String.length
            let v48 : int32 = v47 v1
            let v49 : (int32 -> int32) = int32
            let v50 : int32 = v49 1
            let v51 : (int32 -> int32) = int32
            let v52 : int32 = v51 v48
            let v53 : string = v1.[int v50..int v52]
            let v54 : int64 = 0L
            let v55 : bool = method19(v46, v54)
            let v56 : bool = v55 = false
            if v56 then
                let v59 : (char -> string) = _.ToString()
                let v60 : string = v59 v46
                let v67 : int32 = v60.Length
                let v68 : (char []) = Array.zeroCreate<char> (v67)
                let v69 : Mut5 = {l0 = 0} : Mut5
                while method12(v67, v69) do
                    let v71 : int32 = v69.l0
                    let v72 : char = v60.[int v71]
                    v68.[int v71] <- v72
                    let v73 : int32 = v71 + 1
                    v69.l0 <- v73
                    ()
                let v74 : char list = v68 |> Array.toList
                let v77 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v78 : (char -> (UH0 -> UH0)) = method13()
                let v79 : (char list -> (UH0 -> UH0)) = v77 v78
                let v80 : (UH0 -> UH0) = v79 v74
                let v81 : UH0 = UH0_0
                let v82 : UH0 = v80 v81
                let struct (v91 : System.Text.StringBuilder, v92 : int32, v93 : int32) = method14(v82, v2, v3, v4)
                US5_0(v46, v53, v91, v92, v93)
            else
                let v95 : char list = []
                let v98 : char list = ' ' :: v95 
                let v107 : char list = ''' :: v98 
                let v116 : char list = '"' :: v107 
                let v125 : (char list -> (char [])) = List.toArray
                let v126 : (char []) = v125 v116
                let v133 : string = $"parsing.none_of / unexpected char: '{v46}' / chars: %A{v126} / s: %A{struct (v2, v3, v4)}"
                US5_1(v133)
    let v148 : US5 =
        match v136 with
        | US5_1(v145) -> (* Error *)
            US5_1(v145)
        | US5_0(v137, v138, v139, v140, v141) -> (* Ok *)
            let v142 : bool = '\\' = v137
            let v143 : char =
                if v142 then
                    '/'
                else
                    v137
            US5_0(v143, v138, v139, v140, v141)
    match v148 with
    | US5_1(v166) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v149, v150, v151, v152, v153) -> (* Ok *)
        let v156 : (char -> string) = _.ToString()
        let v157 : string = v156 v149
        let v164 : string = v0 + v157 
        method20(v164, v150, v151, v152, v153)
and method21 (v0 : string, v1 : int32) : int32 =
    let v2 : int32 = v0.Length
    let v3 : bool = v1 >= v2
    if v3 then
        v1
    else
        let v4 : char = v0.[int v1]
        let v5 : bool = v4 = ' '
        if v5 then
            let v6 : int32 = v1 + 1
            method21(v0, v6)
        else
            v1
and method22 (v0 : string, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US6 =
    let v5 : bool = "" = v1
    let v54 : US5 =
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
            let v18 : (char -> string) = _.ToString()
            let v19 : string = v18 v8
            let v26 : int32 = v19.Length
            let v27 : (char []) = Array.zeroCreate<char> (v26)
            let v28 : Mut5 = {l0 = 0} : Mut5
            while method12(v26, v28) do
                let v30 : int32 = v28.l0
                let v31 : char = v19.[int v30]
                v27.[int v30] <- v31
                let v32 : int32 = v30 + 1
                v28.l0 <- v32
                ()
            let v33 : char list = v27 |> Array.toList
            let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
            let v37 : (char -> (UH0 -> UH0)) = method13()
            let v38 : (char list -> (UH0 -> UH0)) = v36 v37
            let v39 : (UH0 -> UH0) = v38 v33
            let v40 : UH0 = UH0_0
            let v41 : UH0 = v39 v40
            let struct (v50 : System.Text.StringBuilder, v51 : int32, v52 : int32) = method14(v41, v2, v3, v4)
            US5_0(v8, v15, v50, v51, v52)
    match v54 with
    | US5_1(v72) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v55, v56, v57, v58, v59) -> (* Ok *)
        let v62 : (char -> string) = _.ToString()
        let v63 : string = v62 v55
        let v70 : string = v0 + v63 
        method22(v70, v56, v57, v58, v59)
and method11 (v0 : string) : US4 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v3 : (string -> string option) = Option.ofObj
    let v4 : string option = v3 v0
    v4 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v5 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v14 : string = ""
    let v15 : string = v5 |> Option.defaultValue v14 
    let v22 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v23 : System.Text.StringBuilder = v22 v14
    let v24 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure10()
    let v25 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US5) = closure13()
    let v26 : UH1 = UH1_0
    let v27 : UH1 = UH1_1(v25, v26)
    let v28 : UH1 = UH1_1(v24, v27)
    let v29 : US5 = method15(v15, v23, v28)
    let v219 : US6 =
        match v29 with
        | US5_1(v216) -> (* Error *)
            US6_1(v216)
        | US5_0(v30, v31, v32, v33, v34) -> (* Ok *)
            let v35 : bool = "" = v31
            let v148 : US5 =
                if v35 then
                    let v36 : char list = []
                    let v39 : char list = ''' :: v36 
                    let v48 : char list = '"' :: v39 
                    let v57 : (char list -> (char [])) = List.toArray
                    let v58 : (char []) = v57 v48
                    let v65 : string = $"parsing.none_of / unexpected end of input / chars: %A{v58} / s: %A{struct (v32, v33, v34)}"
                    US5_1(v65)
                else
                    let v67 : char = v31.[int 0]
                    let v68 : (string -> int32) = String.length
                    let v69 : int32 = v68 v31
                    let v70 : (int32 -> int32) = int32
                    let v71 : int32 = v70 1
                    let v72 : (int32 -> int32) = int32
                    let v73 : int32 = v72 v69
                    let v74 : string = v31.[int v71..int v73]
                    let v75 : int64 = 0L
                    let v76 : bool = method16(v67, v75)
                    let v77 : bool = v76 = false
                    if v77 then
                        let v80 : (char -> string) = _.ToString()
                        let v81 : string = v80 v67
                        let v88 : int32 = v81.Length
                        let v89 : (char []) = Array.zeroCreate<char> (v88)
                        let v90 : Mut5 = {l0 = 0} : Mut5
                        while method12(v88, v90) do
                            let v92 : int32 = v90.l0
                            let v93 : char = v81.[int v92]
                            v89.[int v92] <- v93
                            let v94 : int32 = v92 + 1
                            v90.l0 <- v94
                            ()
                        let v95 : char list = v89 |> Array.toList
                        let v98 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v99 : (char -> (UH0 -> UH0)) = method13()
                        let v100 : (char list -> (UH0 -> UH0)) = v98 v99
                        let v101 : (UH0 -> UH0) = v100 v95
                        let v102 : UH0 = UH0_0
                        let v103 : UH0 = v101 v102
                        let struct (v112 : System.Text.StringBuilder, v113 : int32, v114 : int32) = method14(v103, v32, v33, v34)
                        US5_0(v67, v74, v112, v113, v114)
                    else
                        let v116 : char list = []
                        let v119 : char list = ''' :: v116 
                        let v128 : char list = '"' :: v119 
                        let v137 : (char list -> (char [])) = List.toArray
                        let v138 : (char []) = v137 v128
                        let v145 : string = $"parsing.none_of / unexpected char: '{v67}' / chars: %A{v138} / s: %A{struct (v32, v33, v34)}"
                        US5_1(v145)
            let v160 : US5 =
                match v148 with
                | US5_1(v157) -> (* Error *)
                    US5_1(v157)
                | US5_0(v149, v150, v151, v152, v153) -> (* Ok *)
                    let v154 : bool = '\\' = v149
                    let v155 : char =
                        if v154 then
                            '/'
                        else
                            v149
                    US5_0(v155, v150, v151, v152, v153)
            let v180 : US6 =
                match v160 with
                | US5_1(v161) -> (* Error *)
                    US6_1(v161)
                | US5_0(v163, v164, v165, v166, v167) -> (* Ok *)
                    let v170 : (char -> string) = _.ToString()
                    let v171 : string = v170 v163
                    method17(v171, v164, v165, v166, v167)
            let v190 : US6 =
                match v180 with
                | US6_1(v187) -> (* Error *)
                    US6_0(v14, v31, v32, v33, v34)
                | US6_0(v181, v182, v183, v184, v185) -> (* Ok *)
                    US6_0(v181, v182, v183, v184, v185)
            match v190 with
            | US6_1(v211) -> (* Error *)
                let v212 : string = "between / expected content"
                US6_1(v212)
            | US6_0(v191, v192, v193, v194, v195) -> (* Ok *)
                let v196 : UH1 = UH1_0
                let v197 : UH1 = UH1_1(v25, v196)
                let v198 : UH1 = UH1_1(v24, v197)
                let v199 : US5 = method18(v192, v193, v194, v195, v198)
                match v199 with
                | US5_1(v206) -> (* Error *)
                    let v207 : string = $"between / expected closing delimiter / e: %A{v206} / input: %A{struct (v15, v23, 1, 1)} / rest1: %A{struct (v31, v32, v33, v34)} / rest2: %A{struct (v192, v193, v194, v195)}"
                    US6_1(v207)
                | US5_0(v200, v201, v202, v203, v204) -> (* Ok *)
                    US6_0(v191, v201, v202, v203, v204)
    let v435 : US6 =
        match v219 with
        | US6_1(v225) -> (* Error *)
            let v226 : bool = "" = v15
            let v359 : US5 =
                if v226 then
                    let v227 : char list = []
                    let v230 : char list = ' ' :: v227 
                    let v239 : char list = ''' :: v230 
                    let v248 : char list = '"' :: v239 
                    let v257 : (char list -> (char [])) = List.toArray
                    let v258 : (char []) = v257 v248
                    let v265 : string = $"parsing.none_of / unexpected end of input / chars: %A{v258} / s: %A{struct (v23, 1, 1)}"
                    US5_1(v265)
                else
                    let v267 : char = v15.[int 0]
                    let v268 : (string -> int32) = String.length
                    let v269 : int32 = v268 v15
                    let v270 : (int32 -> int32) = int32
                    let v271 : int32 = v270 1
                    let v272 : (int32 -> int32) = int32
                    let v273 : int32 = v272 v269
                    let v274 : string = v15.[int v271..int v273]
                    let v275 : int64 = 0L
                    let v276 : bool = method19(v267, v275)
                    let v277 : bool = v276 = false
                    if v277 then
                        let v280 : (char -> string) = _.ToString()
                        let v281 : string = v280 v267
                        let v288 : int32 = v281.Length
                        let v289 : (char []) = Array.zeroCreate<char> (v288)
                        let v290 : Mut5 = {l0 = 0} : Mut5
                        while method12(v288, v290) do
                            let v292 : int32 = v290.l0
                            let v293 : char = v281.[int v292]
                            v289.[int v292] <- v293
                            let v294 : int32 = v292 + 1
                            v290.l0 <- v294
                            ()
                        let v295 : char list = v289 |> Array.toList
                        let v298 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v299 : (char -> (UH0 -> UH0)) = method13()
                        let v300 : (char list -> (UH0 -> UH0)) = v298 v299
                        let v301 : (UH0 -> UH0) = v300 v295
                        let v302 : UH0 = UH0_0
                        let v303 : UH0 = v301 v302
                        let v312 : int32 = 1
                        let v313 : int32 = 1
                        let struct (v314 : System.Text.StringBuilder, v315 : int32, v316 : int32) = method14(v303, v23, v312, v313)
                        US5_0(v267, v274, v314, v315, v316)
                    else
                        let v318 : char list = []
                        let v321 : char list = ' ' :: v318 
                        let v330 : char list = ''' :: v321 
                        let v339 : char list = '"' :: v330 
                        let v348 : (char list -> (char [])) = List.toArray
                        let v349 : (char []) = v348 v339
                        let v356 : string = $"parsing.none_of / unexpected char: '{v267}' / chars: %A{v349} / s: %A{struct (v23, 1, 1)}"
                        US5_1(v356)
            let v371 : US5 =
                match v359 with
                | US5_1(v368) -> (* Error *)
                    US5_1(v368)
                | US5_0(v360, v361, v362, v363, v364) -> (* Ok *)
                    let v365 : bool = '\\' = v360
                    let v366 : char =
                        if v365 then
                            '/'
                        else
                            v360
                    US5_0(v366, v361, v362, v363, v364)
            let v391 : US6 =
                match v371 with
                | US5_1(v372) -> (* Error *)
                    US6_1(v372)
                | US5_0(v374, v375, v376, v377, v378) -> (* Ok *)
                    let v381 : (char -> string) = _.ToString()
                    let v382 : string = v381 v374
                    method20(v382, v375, v376, v377, v378)
            match v391 with
            | US6_1(v397) -> (* Error *)
                let v398 : int32 = v15.Length
                let v399 : bool = v398 = 0
                let v403 : US8 =
                    if v399 then
                        US8_0(v15, v23, 1, 1)
                    else
                        let v401 : string = $"parsing.eof / expected end of input / input: %A{v15}"
                        US8_1(v401)
                let v412 : US6 =
                    match v403 with
                    | US8_1(v409) -> (* Error *)
                        US6_1(v409)
                    | US8_0(v404, v405, v406, v407) -> (* Ok *)
                        US6_0(v14, v404, v405, v406, v407)
                match v412 with
                | US6_1(v428) -> (* Error *)
                    US6_1(v428)
                | US6_0(v413, v414, v415, v416, v417) -> (* Ok *)
                    let v418 : int32 = 0
                    let v419 : int32 = method21(v414, v418)
                    let v420 : (string -> int32) = String.length
                    let v421 : int32 = v420 v414
                    let v422 : (int32 -> int32) = int32
                    let v423 : int32 = v422 v419
                    let v424 : (int32 -> int32) = int32
                    let v425 : int32 = v424 v421
                    let v426 : string = v414.[int v423..int v425]
                    US6_0(v413, v426, v415, v416, v417)
            | US6_0(v392, v393, v394, v395, v396) -> (* Ok *)
                v391
        | US6_0(v220, v221, v222, v223, v224) -> (* Ok *)
            v219
    let v639 : US9 =
        match v435 with
        | US6_1(v636) -> (* Error *)
            US9_1(v636)
        | US6_0(v436, v437, v438, v439, v440) -> (* Ok *)
            let v441 : bool = "" = v437
            let v522 : US5 =
                if v441 then
                    let v442 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v438, v439, v440)}"
                    US5_1(v442)
                else
                    let v444 : char = v437.[int 0]
                    let v445 : bool = v444 = ' '
                    if v445 then
                        let v446 : (string -> int32) = String.length
                        let v447 : int32 = v446 v437
                        let v448 : (int32 -> int32) = int32
                        let v449 : int32 = v448 1
                        let v450 : (int32 -> int32) = int32
                        let v451 : int32 = v450 v447
                        let v452 : string = v437.[int v449..int v451]
                        let v455 : (char -> string) = _.ToString()
                        let v456 : string = v455 v444
                        let v463 : int32 = v456.Length
                        let v464 : (char []) = Array.zeroCreate<char> (v463)
                        let v465 : Mut5 = {l0 = 0} : Mut5
                        while method12(v463, v465) do
                            let v467 : int32 = v465.l0
                            let v468 : char = v456.[int v467]
                            v464.[int v467] <- v468
                            let v469 : int32 = v467 + 1
                            v465.l0 <- v469
                            ()
                        let v470 : char list = v464 |> Array.toList
                        let v473 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v474 : (char -> (UH0 -> UH0)) = method13()
                        let v475 : (char list -> (UH0 -> UH0)) = v473 v474
                        let v476 : (UH0 -> UH0) = v475 v470
                        let v477 : UH0 = UH0_0
                        let v478 : UH0 = v476 v477
                        let struct (v487 : System.Text.StringBuilder, v488 : int32, v489 : int32) = method14(v478, v438, v439, v440)
                        US5_0(v444, v452, v487, v488, v489)
                    else
                        let v491 : (string -> int32) = String.length
                        let v492 : int32 = v491 v437
                        let v493 : string = "\n"
                        let v494 : int32 = v437.IndexOf v493 
                        let v495 : int32 = v494 - 1
                        let v496 : bool = -2 = v495
                        let v497 : int32 =
                            if v496 then
                                v492
                            else
                                v495
                        let v498 : (int32 -> int32) = int32
                        let v499 : int32 = v498 0
                        let v500 : (int32 -> int32) = int32
                        let v501 : int32 = v500 v497
                        let v502 : string = v437.[int v499..int v501]
                        let v503 : string = $"parsing.p_char / expected: '{' '}' / line: {v439} / col: {v440}
{v438}{v502}"
                        let v504 : int32 = v440 - 1
                        let v507 : (int32 -> (string -> string)) = String.replicate
                        let v508 : (string -> string) = v507 v504
                        let v509 : string = " "
                        let v510 : string = v508 v509
                        let v517 : string = "^"
                        let v518 : string = v510 + v517 
                        let v519 : string = $"{v503}
{v518}
"
                        US5_1(v519)
            let v534 : US10 =
                match v522 with
                | US5_1(v530) -> (* Error *)
                    let v531 : US7 = US7_1
                    US10_0(v531, v437, v438, v439, v440)
                | US5_0(v523, v524, v525, v526, v527) -> (* Ok *)
                    let v528 : US7 = US7_0(v523)
                    US10_0(v528, v524, v525, v526, v527)
            let v613 : US6 =
                match v534 with
                | US10_1(v610) -> (* Error *)
                    US6_1(v610)
                | US10_0(v535, v536, v537, v538, v539) -> (* Ok *)
                    let v540 : bool = "" = v536
                    let v589 : US5 =
                        if v540 then
                            let v541 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v537, v538, v539)}"
                            US5_1(v541)
                        else
                            let v543 : char = v536.[int 0]
                            let v544 : (string -> int32) = String.length
                            let v545 : int32 = v544 v536
                            let v546 : (int32 -> int32) = int32
                            let v547 : int32 = v546 1
                            let v548 : (int32 -> int32) = int32
                            let v549 : int32 = v548 v545
                            let v550 : string = v536.[int v547..int v549]
                            let v553 : (char -> string) = _.ToString()
                            let v554 : string = v553 v543
                            let v561 : int32 = v554.Length
                            let v562 : (char []) = Array.zeroCreate<char> (v561)
                            let v563 : Mut5 = {l0 = 0} : Mut5
                            while method12(v561, v563) do
                                let v565 : int32 = v563.l0
                                let v566 : char = v554.[int v565]
                                v562.[int v565] <- v566
                                let v567 : int32 = v565 + 1
                                v563.l0 <- v567
                                ()
                            let v568 : char list = v562 |> Array.toList
                            let v571 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                            let v572 : (char -> (UH0 -> UH0)) = method13()
                            let v573 : (char list -> (UH0 -> UH0)) = v571 v572
                            let v574 : (UH0 -> UH0) = v573 v568
                            let v575 : UH0 = UH0_0
                            let v576 : UH0 = v574 v575
                            let struct (v585 : System.Text.StringBuilder, v586 : int32, v587 : int32) = method14(v576, v537, v538, v539)
                            US5_0(v543, v550, v585, v586, v587)
                    match v589 with
                    | US5_1(v590) -> (* Error *)
                        US6_1(v590)
                    | US5_0(v592, v593, v594, v595, v596) -> (* Ok *)
                        let v599 : (char -> string) = _.ToString()
                        let v600 : string = v599 v592
                        method22(v600, v593, v594, v595, v596)
            let v625 : US11 =
                match v613 with
                | US6_1(v621) -> (* Error *)
                    let v622 : US3 = US3_1
                    US11_0(v622, v437, v438, v439, v440)
                | US6_0(v614, v615, v616, v617, v618) -> (* Ok *)
                    let v619 : US3 = US3_0(v614)
                    US11_0(v619, v615, v616, v617, v618)
            match v625 with
            | US11_1(v632) -> (* Error *)
                US9_1(v632)
            | US11_0(v626, v627, v628, v629, v630) -> (* Ok *)
                US9_0(v436, v626, v627, v628, v629, v630)
    match v639 with
    | US9_1(v647) -> (* Error *)
        US4_1(v647)
    | US9_0(v640, v641, v642, v643, v644, v645) -> (* Ok *)
        US4_0(v640, v641)
and closure14 () () : string =
    let v0 : string = $"runtime.execute_with_options_async"
    v0
and closure15 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) () : struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) =
    struct (v0, v1, v2, v3, v4, v5, v6)
and method25 (v0 : Mut4, v1 : string) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method27 (v0 : Mut4, v1 : System.Threading.CancellationToken option) : unit =
    let v4 : string = $"%A{v1}"
    method25(v0, v4)
and method28 (v0 : Mut4, v1 : (struct (string * string) [])) : unit =
    let v4 : string = $"%A{v1}"
    method25(v0, v4)
and method29 (v0 : Mut4, v1 : (struct (int32 * string * bool) -> Async<unit>) option) : unit =
    let v4 : string = $"%A{v1}"
    method25(v0, v4)
and method30 (v0 : Mut4, v1 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option) : unit =
    let v4 : string = $"%A{v1}"
    method25(v0, v4)
and method31 (v0 : Mut4, v1 : bool) : unit =
    let v4 : string =
        if v1 then
            let v2 : string = "true"
            v2
        else
            let v3 : string = "false"
            v3
    let v7 : string = $"{v4}"
    let v14 : string = v0.l0
    let v15 : string = v14 + v7 
    v0.l0 <- v15
    ()
and method32 (v0 : Mut4, v1 : string option) : unit =
    let v4 : string = $"%A{v1}"
    method25(v0, v4)
and method26 (v0 : Mut4, v1 : string, v2 : System.Threading.CancellationToken option, v3 : (struct (string * string) []), v4 : (struct (int32 * string * bool) -> Async<unit>) option, v5 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v6 : bool, v7 : string option) : unit =
    let v8 : string = "{ "
    method25(v0, v8)
    method8(v0)
    let v9 : string = "command"
    method25(v0, v9)
    let v10 : string = " = "
    method25(v0, v10)
    method25(v0, v1)
    let v11 : string = "; "
    method25(v0, v11)
    let v12 : string = "cancellation_token"
    method25(v0, v12)
    method25(v0, v10)
    method27(v0, v2)
    method25(v0, v11)
    let v13 : string = "environment_variables"
    method25(v0, v13)
    method25(v0, v10)
    method28(v0, v3)
    method25(v0, v11)
    let v14 : string = "on_line"
    method25(v0, v14)
    method25(v0, v10)
    method29(v0, v4)
    method25(v0, v11)
    let v15 : string = "stdin"
    method25(v0, v15)
    method25(v0, v10)
    method30(v0, v5)
    method25(v0, v11)
    let v16 : string = "trace"
    method25(v0, v16)
    method25(v0, v10)
    method31(v0, v6)
    method25(v0, v11)
    let v17 : string = "working_directory"
    method25(v0, v17)
    method25(v0, v10)
    method32(v0, v7)
    let v18 : string = " }"
    method25(v0, v18)
and method24 (v0 : Mut4, v1 : string, v2 : System.Threading.CancellationToken option, v3 : (struct (string * string) []), v4 : (struct (int32 * string * bool) -> Async<unit>) option, v5 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v6 : bool, v7 : string option) : unit =
    let v8 : string = "{ "
    method25(v0, v8)
    method8(v0)
    let v9 : string = "options"
    method25(v0, v9)
    let v10 : string = " = "
    method25(v0, v10)
    method26(v0, v1, v2, v3, v4, v5, v6, v7)
    let v11 : string = " }"
    method25(v0, v11)
and closure16 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : string, v1216 : System.Threading.CancellationToken option, v1217 : (struct (string * string) []), v1218 : (struct (int32 * string * bool) -> Async<unit>) option, v1219 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v1220 : bool, v1221 : string option) = v2 ()
    let v1222 : string = ""
    let v1223 : Mut4 = {l0 = v1222} : Mut4
    method24(v1223, v1215, v1216, v1217, v1218, v1219, v1220, v1221)
    let v1224 : string = v1223.l0
    let v1227 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1224}"
    let v1234 : char list = []
    let v1239 : (char list -> (char [])) = List.toArray
    let v1240 : (char []) = v1239 v1234
    let v1247 : string = v1227.TrimStart v1240 
    let v1286 : char list = []
    let v1289 : char list = '/' :: v1286 
    let v1298 : char list = ' ' :: v1289 
    let v1309 : (char list -> (char [])) = List.toArray
    let v1310 : (char []) = v1309 v1298
    let v1317 : string = v1247.TrimEnd v1310 
    v1317
and method23 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option))) : unit =
    let v3 : (unit -> string) = closure16(v0, v1, v2)
    method9(v0, v3)
and closure18 (v0 : string) () : string =
    v0
and closure17 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v12 : bool = true
    let mutable _v12 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : Async<unit> = null |> unbox<Async<unit>>
    v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v42 : Async<unit> = null |> unbox<Async<unit>>
    v42 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : Async<unit> = null |> unbox<Async<unit>>
    v51 
    #endif
#else
    let v58 : Async<unit> option = None
    let mutable _v58 = v58 
    async {
    let v59 : string = v9.Data
    let v62 : string = null |> unbox<string>
    let v69 : bool = v59 = v62
    let v70 : bool = v69 <> true
    if v70 then
        let v73 : US12 option = None
        let _v73 = ref v73 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v74 : (struct (int32 * string * bool) -> Async<unit>) = x
        let v75 : US12 = US12_0(v74)
        v75 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v73.Value <- x
        let v76 : US12 option = _v73.Value 
        let v99 : US12 = US12_1
        let v100 : US12 = v76 |> Option.defaultValue v99 
        match v100 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v108) -> (* Some *)
            let v109 : int32 = v7.Id
            let v110 : Async<unit> = v108 struct (v109, v59, false)
            do! v110 
            ()
        let v111 : string = $"> {v59}"
        if v5 then
            let v112 : US0 = US0_0
            let v113 : (unit -> string) = closure18(v111)
            let v114 : (unit -> unit) = closure5()
            method4(v112, v113, v114)
        else
            v111 |> System.Console.WriteLine
            ()
        let v121 : string = ""
        let v122 : string = $"{v121}{v59}{v121}"
        let v123 : (string -> unit) = v8.Push
        v123 v122
    }
    |> fun x -> _v58 <- Some x
    let v124 : Async<unit> = match _v58 with Some x -> x | None -> failwith "async.new_async_unit / _v58=None"
    v124 
    #endif
    |> fun x -> _v12 <- Some x
    let v125 : Async<unit> = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
    let v142 : bool = true
    let mutable _v142 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v173 : (Async<unit> -> unit) = Async.StartImmediate
    v173 v125
    () 
    #endif
    |> fun x -> _v142 <- Some x
    match _v142 with Some x -> x | None -> failwith "base.run_target / _v142=None"
    ()
and closure19 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option, v7 : System.Diagnostics.Process, v8 : System.Collections.Concurrent.ConcurrentStack<string>) (v9 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v12 : bool = true
    let mutable _v12 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : Async<unit> = null |> unbox<Async<unit>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : Async<unit> = null |> unbox<Async<unit>>
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : Async<unit> = null |> unbox<Async<unit>>
    v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v42 : Async<unit> = null |> unbox<Async<unit>>
    v42 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : Async<unit> = null |> unbox<Async<unit>>
    v51 
    #endif
#else
    let v58 : Async<unit> option = None
    let mutable _v58 = v58 
    async {
    let v59 : string = v9.Data
    let v62 : string = null |> unbox<string>
    let v69 : bool = v59 = v62
    let v70 : bool = v69 <> true
    if v70 then
        let v73 : US12 option = None
        let _v73 = ref v73 
        match v3 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v74 : (struct (int32 * string * bool) -> Async<unit>) = x
        let v75 : US12 = US12_0(v74)
        v75 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v73.Value <- x
        let v76 : US12 option = _v73.Value 
        let v99 : US12 = US12_1
        let v100 : US12 = v76 |> Option.defaultValue v99 
        match v100 with
        | US12_1 -> (* None *)
            ()
        | US12_0(v108) -> (* Some *)
            let v109 : int32 = v7.Id
            let v110 : Async<unit> = v108 struct (v109, v59, true)
            do! v110 
            ()
        let v111 : string = $"! {v59}"
        if v5 then
            let v112 : US0 = US0_0
            let v113 : (unit -> string) = closure18(v111)
            let v114 : (unit -> unit) = closure5()
            method4(v112, v113, v114)
        else
            v111 |> System.Console.WriteLine
            ()
        let v121 : string = "\u001b[7;4m"
        let v122 : string = "\u001b[0m"
        let v123 : string = $"{v121}{v59}{v122}"
        let v124 : (string -> unit) = v8.Push
        v124 v123
    }
    |> fun x -> _v58 <- Some x
    let v125 : Async<unit> = match _v58 with Some x -> x | None -> failwith "async.new_async_unit / _v58=None"
    v125 
    #endif
    |> fun x -> _v12 <- Some x
    let v126 : Async<unit> = match _v12 with Some x -> x | None -> failwith "base.run_target / _v12=None"
    let v143 : bool = true
    let mutable _v143 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v174 : (Async<unit> -> unit) = Async.StartImmediate
    v174 v126
    () 
    #endif
    |> fun x -> _v143 <- Some x
    match _v143 with Some x -> x | None -> failwith "base.run_target / _v143=None"
    ()
and closure20 (v0 : System.Diagnostics.Process) () : unit =
    let v3 : bool = true
    let mutable _v3 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : bool = null |> unbox<bool>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : bool = null |> unbox<bool>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : bool = null |> unbox<bool>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : bool = null |> unbox<bool>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : bool = null |> unbox<bool>
    v42 
    #endif
#else
    let v49 : bool = v0.HasExited
    v49 
    #endif
    |> fun x -> _v3 <- Some x
    let v50 : bool = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v65 : bool = v50 = false
    if v65 then
        let v68 : bool = true
        let mutable _v68 : unit option = None 
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_RUST && WASM
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        null |> unbox<unit>
        () 
        #endif
#if FABLE_COMPILER_PYTHON
        null |> unbox<unit>
        () 
        #endif
#else
        let v99 : (unit -> unit) = v0.Kill
        v99 ()
        () 
        #endif
        |> fun x -> _v68 <- Some x
        match _v68 with Some x -> x | None -> failwith "base.run_target / _v68=None"
        ()
and closure21 () () : string =
    let v0 : string = $"runtime.execute_with_options_async / WaitForExitAsync"
    v0
and closure22 (v0 : System.Threading.Tasks.TaskCanceledException) () : System.Threading.Tasks.TaskCanceledException =
    v0
and method35 (v0 : Mut4, v1 : System.Threading.Tasks.TaskCanceledException) : unit =
    let v4 : string = $"%A{v1}"
    method25(v0, v4)
and method34 (v0 : Mut4, v1 : System.Threading.Tasks.TaskCanceledException) : unit =
    let v2 : string = "{ "
    method25(v0, v2)
    method8(v0)
    let v3 : string = "ex"
    method25(v0, v3)
    let v4 : string = " = "
    method25(v0, v4)
    method35(v0, v1)
    let v5 : string = " }"
    method25(v0, v5)
and closure23 (v0 : US0, v1 : (unit -> string), v2 : (unit -> System.Threading.Tasks.TaskCanceledException)) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let v1215 : System.Threading.Tasks.TaskCanceledException = v2 ()
    let v1216 : string = ""
    let v1217 : Mut4 = {l0 = v1216} : Mut4
    method34(v1217, v1215)
    let v1218 : string = v1217.l0
    let v1221 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1218}"
    let v1228 : char list = []
    let v1233 : (char list -> (char [])) = List.toArray
    let v1234 : (char []) = v1233 v1228
    let v1241 : string = v1221.TrimStart v1234 
    let v1280 : char list = []
    let v1283 : char list = '/' :: v1280 
    let v1292 : char list = ' ' :: v1283 
    let v1303 : (char list -> (char [])) = List.toArray
    let v1304 : (char []) = v1303 v1292
    let v1311 : string = v1241.TrimEnd v1304 
    v1311
and method33 (v0 : US0, v1 : (unit -> string), v2 : (unit -> System.Threading.Tasks.TaskCanceledException)) : unit =
    let v3 : (unit -> string) = closure23(v0, v1, v2)
    method9(v0, v3)
and closure24 () () : string =
    let v0 : string = $"runtime.execute_with_options_async"
    v0
and closure25 (v0 : int32, v1 : string) () : struct (int32 * int32) =
    let v2 : int32 = v1.Length
    struct (v0, v2)
and method38 (v0 : Mut4, v1 : int32) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and method37 (v0 : Mut4, v1 : int32, v2 : int32) : unit =
    let v3 : string = "{ "
    method25(v0, v3)
    method8(v0)
    let v4 : string = "exit_code"
    method25(v0, v4)
    let v5 : string = " = "
    method25(v0, v5)
    method38(v0, v1)
    let v6 : string = "; "
    method25(v0, v6)
    let v7 : string = "output_length"
    method25(v0, v7)
    method25(v0, v5)
    method38(v0, v2)
    let v8 : string = " }"
    method25(v0, v8)
and closure26 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * int32))) () : string =
    let v5 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
    let v6 : US0 = US0_0
    if State.trace_state.IsNone then State.trace_state <- v5 v6 |> Some
    let struct (v14 : Mut0, v15 : Mut1, v16 : Mut2, v17 : Mut3, v18 : int64 option) = State.trace_state.Value
    let v35 : bool = true
    let mutable _v35 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v38 : US2 option = None
    let _v38 = ref v38 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v39 : int64 = x
    let v40 : US2 = US2_0(v39)
    v40 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v38.Value <- x
    let v41 : US2 option = _v38.Value 
    let v64 : US2 = US2_1
    let v65 : US2 = v41 |> Option.defaultValue v64 
    let v163 : System.DateTime =
        match v65 with
        | US2_1 -> (* None *)
            let v155 : System.DateTime = System.DateTime.Now
            v155
        | US2_0(v73) -> (* Some *)
            let v76 : System.DateTime = System.DateTime.Now
            let v85 : (System.DateTime -> int64) = _.Ticks
            let v86 : int64 = v85 v76
            let v93 : int64 = v86 - v73
            let v96 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v97 : System.TimeSpan = v96 v93
            let v106 : (System.TimeSpan -> int32) = _.Hours
            let v107 : int32 = v106 v97
            let v116 : (System.TimeSpan -> int32) = _.Minutes
            let v117 : int32 = v116 v97
            let v126 : (System.TimeSpan -> int32) = _.Seconds
            let v127 : int32 = v126 v97
            let v136 : (System.TimeSpan -> int32) = _.Milliseconds
            let v137 : int32 = v136 v97
            let v146 : System.DateTime = System.DateTime (1, 1, 1, v107, v117, v127, v137)
            v146
    let v166 : string = method5()
    let v175 : (string -> string) = v163.ToString
    let v176 : string = v175 v166
    v176 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : US2 option = None
    let _v185 = ref v185 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v186 : int64 = x
    let v187 : US2 = US2_0(v186)
    v187 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v185.Value <- x
    let v188 : US2 option = _v185.Value 
    let v211 : US2 = US2_1
    let v212 : US2 = v188 |> Option.defaultValue v211 
    let v310 : System.DateTime =
        match v212 with
        | US2_1 -> (* None *)
            let v302 : System.DateTime = System.DateTime.Now
            v302
        | US2_0(v220) -> (* Some *)
            let v223 : System.DateTime = System.DateTime.Now
            let v232 : (System.DateTime -> int64) = _.Ticks
            let v233 : int64 = v232 v223
            let v240 : int64 = v233 - v220
            let v243 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v244 : System.TimeSpan = v243 v240
            let v253 : (System.TimeSpan -> int32) = _.Hours
            let v254 : int32 = v253 v244
            let v263 : (System.TimeSpan -> int32) = _.Minutes
            let v264 : int32 = v263 v244
            let v273 : (System.TimeSpan -> int32) = _.Seconds
            let v274 : int32 = v273 v244
            let v283 : (System.TimeSpan -> int32) = _.Milliseconds
            let v284 : int32 = v283 v244
            let v293 : System.DateTime = System.DateTime (1, 1, 1, v254, v264, v274, v284)
            v293
    let v313 : string = method5()
    let v322 : (string -> string) = v310.ToString
    let v323 : string = v322 v313
    v323 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v330 : string = $"near_sdk::env::block_timestamp()"
    let v331 : uint64 = Fable.Core.RustInterop.emitRustExpr () v330 
    let v334 : US2 option = None
    let _v334 = ref v334 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v335 : int64 = x
    let v336 : US2 = US2_0(v335)
    v336 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v334.Value <- x
    let v337 : US2 option = _v334.Value 
    let v360 : US2 = US2_1
    let v361 : US2 = v337 |> Option.defaultValue v360 
    let v374 : uint64 =
        match v361 with
        | US2_1 -> (* None *)
            v331
        | US2_0(v369) -> (* Some *)
            let v370 : (int64 -> uint64) = uint64
            let v371 : uint64 = v370 v369
            let v372 : uint64 = v331 - v371
            v372
    let v375 : uint64 = v374 / 1000000000UL
    let v376 : uint64 = v375 % 60UL
    let v377 : uint64 = v375 / 60UL
    let v378 : uint64 = v377 % 60UL
    let v379 : uint64 = v375 / 3600UL
    let v380 : uint64 = v379 % 24UL
    let v381 : string = $"format!(\"{{:02}}:{{:02}}:{{:02}}\", $0, $1, $2)"
    let v382 : std_string_String = Fable.Core.RustInterop.emitRustExpr struct (v380, v378, v376) v381 
    let v383 : string = "fable_library_rust::String_::fromString($0)"
    let v384 : string = Fable.Core.RustInterop.emitRustExpr v382 v383 
    v384 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v387 : US2 option = None
    let _v387 = ref v387 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v388 : int64 = x
    let v389 : US2 = US2_0(v388)
    v389 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v387.Value <- x
    let v390 : US2 option = _v387.Value 
    let v413 : US2 = US2_1
    let v414 : US2 = v390 |> Option.defaultValue v413 
    let v512 : System.DateTime =
        match v414 with
        | US2_1 -> (* None *)
            let v504 : System.DateTime = System.DateTime.Now
            v504
        | US2_0(v422) -> (* Some *)
            let v425 : System.DateTime = System.DateTime.Now
            let v434 : (System.DateTime -> int64) = _.Ticks
            let v435 : int64 = v434 v425
            let v442 : int64 = v435 - v422
            let v445 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v446 : System.TimeSpan = v445 v442
            let v455 : (System.TimeSpan -> int32) = _.Hours
            let v456 : int32 = v455 v446
            let v465 : (System.TimeSpan -> int32) = _.Minutes
            let v466 : int32 = v465 v446
            let v475 : (System.TimeSpan -> int32) = _.Seconds
            let v476 : int32 = v475 v446
            let v485 : (System.TimeSpan -> int32) = _.Milliseconds
            let v486 : int32 = v485 v446
            let v495 : System.DateTime = System.DateTime (1, 1, 1, v456, v466, v476, v486)
            v495
    let v515 : string = method6()
    let v524 : (string -> string) = v512.ToString
    let v525 : string = v524 v515
    v525 
    #endif
#if FABLE_COMPILER_PYTHON
    let v534 : US2 option = None
    let _v534 = ref v534 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v535 : int64 = x
    let v536 : US2 = US2_0(v535)
    v536 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v534.Value <- x
    let v537 : US2 option = _v534.Value 
    let v560 : US2 = US2_1
    let v561 : US2 = v537 |> Option.defaultValue v560 
    let v659 : System.DateTime =
        match v561 with
        | US2_1 -> (* None *)
            let v651 : System.DateTime = System.DateTime.Now
            v651
        | US2_0(v569) -> (* Some *)
            let v572 : System.DateTime = System.DateTime.Now
            let v581 : (System.DateTime -> int64) = _.Ticks
            let v582 : int64 = v581 v572
            let v589 : int64 = v582 - v569
            let v592 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v593 : System.TimeSpan = v592 v589
            let v602 : (System.TimeSpan -> int32) = _.Hours
            let v603 : int32 = v602 v593
            let v612 : (System.TimeSpan -> int32) = _.Minutes
            let v613 : int32 = v612 v593
            let v622 : (System.TimeSpan -> int32) = _.Seconds
            let v623 : int32 = v622 v593
            let v632 : (System.TimeSpan -> int32) = _.Milliseconds
            let v633 : int32 = v632 v593
            let v642 : System.DateTime = System.DateTime (1, 1, 1, v603, v613, v623, v633)
            v642
    let v662 : string = method6()
    let v671 : (string -> string) = v659.ToString
    let v672 : string = v671 v662
    v672 
    #endif
#else
    let v681 : US2 option = None
    let _v681 = ref v681 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v682 : int64 = x
    let v683 : US2 = US2_0(v682)
    v683 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v681.Value <- x
    let v684 : US2 option = _v681.Value 
    let v707 : US2 = US2_1
    let v708 : US2 = v684 |> Option.defaultValue v707 
    let v806 : System.DateTime =
        match v708 with
        | US2_1 -> (* None *)
            let v798 : System.DateTime = System.DateTime.Now
            v798
        | US2_0(v716) -> (* Some *)
            let v719 : System.DateTime = System.DateTime.Now
            let v728 : (System.DateTime -> int64) = _.Ticks
            let v729 : int64 = v728 v719
            let v736 : int64 = v729 - v716
            let v739 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v740 : System.TimeSpan = v739 v736
            let v749 : (System.TimeSpan -> int32) = _.Hours
            let v750 : int32 = v749 v740
            let v759 : (System.TimeSpan -> int32) = _.Minutes
            let v760 : int32 = v759 v740
            let v769 : (System.TimeSpan -> int32) = _.Seconds
            let v770 : int32 = v769 v740
            let v779 : (System.TimeSpan -> int32) = _.Milliseconds
            let v780 : int32 = v779 v740
            let v789 : System.DateTime = System.DateTime (1, 1, 1, v750, v760, v770, v780)
            v789
    let v809 : string = method6()
    let v818 : (string -> string) = v806.ToString
    let v819 : string = v818 v809
    v819 
    #endif
    |> fun x -> _v35 <- Some x
    let v826 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v981 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v985 : US3 =
        if v981 then
            let v982 : string = "Verbose"
            US3_0(v982)
        else
            US3_1
    let v1034 : US3 =
        match v985 with
        | US3_1 -> (* None *)
            let v990 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v994 : US3 =
                if v990 then
                    let v991 : string = "Debug"
                    US3_0(v991)
                else
                    US3_1
            match v994 with
            | US3_1 -> (* None *)
                let v999 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v1003 : US3 =
                    if v999 then
                        let v1000 : string = "Info"
                        US3_0(v1000)
                    else
                        US3_1
                match v1003 with
                | US3_1 -> (* None *)
                    let v1008 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v1012 : US3 =
                        if v1008 then
                            let v1009 : string = "Warning"
                            US3_0(v1009)
                        else
                            US3_1
                    match v1012 with
                    | US3_1 -> (* None *)
                        let v1017 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v1021 : US3 =
                            if v1017 then
                                let v1018 : string = "Critical"
                                US3_0(v1018)
                            else
                                US3_1
                        match v1021 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v1022) -> (* Some *)
                            US3_0(v1022)
                    | US3_0(v1013) -> (* Some *)
                        US3_0(v1013)
                | US3_0(v1004) -> (* Some *)
                    US3_0(v1004)
            | US3_0(v995) -> (* Some *)
                US3_0(v995)
        | US3_0(v986) -> (* Some *)
            US3_0(v986)
    let v1038 : string =
        match v1034 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v1035) -> (* Some *)
            v1035
    let v1041 : (unit -> string) = v1038.ToLower
    let v1042 : string = v1041 ()
    let v1051 : string = v1042.PadLeft (7, ' ')
    let v1083 : bool = true
    let mutable _v1083 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1098 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1092 : string = "inline_colorization::color_bright_red"
            let v1093 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1092 
            v1093
        | US0_1 -> (* Debug *)
            let v1086 : string = "inline_colorization::color_bright_blue"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_2 -> (* Info *)
            let v1088 : string = "inline_colorization::color_bright_green"
            let v1089 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1088 
            v1089
        | US0_0 -> (* Verbose *)
            let v1084 : string = "inline_colorization::color_bright_black"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
        | US0_3 -> (* Warning *)
            let v1090 : string = "inline_colorization::color_yellow"
            let v1091 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1090 
            v1091
    let v1099 : string = "&*$0"
    let v1100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1099 
    let v1101 : string = "inline_colorization::color_reset"
    let v1102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1101 
    let v1103 : string = "\"{v1098}{v1100}{v1102}\""
    let v1104 : string = @$"format!(" + v1103 + ")"
    let v1105 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1104 
    let v1106 : string = "fable_library_rust::String_::fromString($0)"
    let v1107 : string = Fable.Core.RustInterop.emitRustExpr v1105 v1106 
    v1107 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1122 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1116 : string = "inline_colorization::color_bright_red"
            let v1117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1116 
            v1117
        | US0_1 -> (* Debug *)
            let v1110 : string = "inline_colorization::color_bright_blue"
            let v1111 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1110 
            v1111
        | US0_2 -> (* Info *)
            let v1112 : string = "inline_colorization::color_bright_green"
            let v1113 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1112 
            v1113
        | US0_0 -> (* Verbose *)
            let v1108 : string = "inline_colorization::color_bright_black"
            let v1109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1108 
            v1109
        | US0_3 -> (* Warning *)
            let v1114 : string = "inline_colorization::color_yellow"
            let v1115 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1114 
            v1115
    let v1123 : string = "&*$0"
    let v1124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1123 
    let v1125 : string = "inline_colorization::color_reset"
    let v1126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1125 
    let v1127 : string = "\"{v1122}{v1124}{v1126}\""
    let v1128 : string = @$"format!(" + v1127 + ")"
    let v1129 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1128 
    let v1130 : string = "fable_library_rust::String_::fromString($0)"
    let v1131 : string = Fable.Core.RustInterop.emitRustExpr v1129 v1130 
    v1131 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1146 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1140 : string = "inline_colorization::color_bright_red"
            let v1141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1140 
            v1141
        | US0_1 -> (* Debug *)
            let v1134 : string = "inline_colorization::color_bright_blue"
            let v1135 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1134 
            v1135
        | US0_2 -> (* Info *)
            let v1136 : string = "inline_colorization::color_bright_green"
            let v1137 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1136 
            v1137
        | US0_0 -> (* Verbose *)
            let v1132 : string = "inline_colorization::color_bright_black"
            let v1133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1132 
            v1133
        | US0_3 -> (* Warning *)
            let v1138 : string = "inline_colorization::color_yellow"
            let v1139 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1138 
            v1139
    let v1147 : string = "&*$0"
    let v1148 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1051 v1147 
    let v1149 : string = "inline_colorization::color_reset"
    let v1150 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1149 
    let v1151 : string = "\"{v1146}{v1148}{v1150}\""
    let v1152 : string = @$"format!(" + v1151 + ")"
    let v1153 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1152 
    let v1154 : string = "fable_library_rust::String_::fromString($0)"
    let v1155 : string = Fable.Core.RustInterop.emitRustExpr v1153 v1154 
    v1155 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1165 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1160 : string = "\u001b[91m"
            v1160
        | US0_1 -> (* Debug *)
            let v1157 : string = "\u001b[94m"
            v1157
        | US0_2 -> (* Info *)
            let v1158 : string = "\u001b[92m"
            v1158
        | US0_0 -> (* Verbose *)
            let v1156 : string = "\u001b[90m"
            v1156
        | US0_3 -> (* Warning *)
            let v1159 : string = "\u001b[93m"
            v1159
    let v1166 : string = method7()
    let v1167 : string = v1165 + v1051 
    let v1168 : string = v1167 + v1166 
    v1168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1178 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1173 : string = "\u001b[91m"
            v1173
        | US0_1 -> (* Debug *)
            let v1170 : string = "\u001b[94m"
            v1170
        | US0_2 -> (* Info *)
            let v1171 : string = "\u001b[92m"
            v1171
        | US0_0 -> (* Verbose *)
            let v1169 : string = "\u001b[90m"
            v1169
        | US0_3 -> (* Warning *)
            let v1172 : string = "\u001b[93m"
            v1172
    let v1179 : string = method7()
    let v1180 : string = v1178 + v1051 
    let v1181 : string = v1180 + v1179 
    v1181 
    #endif
#else
    let v1191 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1186 : string = "\u001b[91m"
            v1186
        | US0_1 -> (* Debug *)
            let v1183 : string = "\u001b[94m"
            v1183
        | US0_2 -> (* Info *)
            let v1184 : string = "\u001b[92m"
            v1184
        | US0_0 -> (* Verbose *)
            let v1182 : string = "\u001b[90m"
            v1182
        | US0_3 -> (* Warning *)
            let v1185 : string = "\u001b[93m"
            v1185
    let v1192 : string = method7()
    let v1193 : string = v1191 + v1051 
    let v1194 : string = v1193 + v1192 
    v1194 
    #endif
    |> fun x -> _v1083 <- Some x
    let v1195 : string = match _v1083 with Some x -> x | None -> failwith "base.run_target / _v1083=None"
    let v1214 : int64 = v14.l0
    let struct (v1215 : int32, v1216 : int32) = v2 ()
    let v1217 : string = ""
    let v1218 : Mut4 = {l0 = v1217} : Mut4
    method37(v1218, v1215, v1216)
    let v1219 : string = v1218.l0
    let v1222 : string = $"{v826} {v1195} #{v1214} %s{v1 ()} / {v1219}"
    let v1229 : char list = []
    let v1234 : (char list -> (char [])) = List.toArray
    let v1235 : (char []) = v1234 v1229
    let v1242 : string = v1222.TrimStart v1235 
    let v1281 : char list = []
    let v1284 : char list = '/' :: v1281 
    let v1293 : char list = ' ' :: v1284 
    let v1304 : (char list -> (char [])) = List.toArray
    let v1305 : (char []) = v1304 v1293
    let v1312 : string = v1242.TrimEnd v1305 
    v1312
and method36 (v0 : US0, v1 : (unit -> string), v2 : (unit -> struct (int32 * int32))) : unit =
    let v3 : (unit -> string) = closure26(v0, v1, v2)
    method9(v0, v3)
and method10 (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    let v9 : bool = true
    let mutable _v9 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v39 
    #endif
#if FABLE_COMPILER_PYTHON
    let v48 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v48 
    #endif
#else
    let v57 : bool = true
    let mutable _v57 : Async<struct (int32 * string)> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v60 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v69 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v78 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v78 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v87 
    #endif
#if FABLE_COMPILER_PYTHON
    let v96 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v96 
    #endif
#else
    let v103 : Async<struct (int32 * string)> option = None
    let mutable _v103 = v103 
    async {
    let v104 : US4 = method11(v0)
    let struct (v113 : string, v114 : US3) =
        match v104 with
        | US4_1(v107) -> (* Error *)
            let v108 : string = $"resultm.get / Result value was Error: {v107}"
            failwith<struct (string * US3)> v108
        | US4_0(v105, v106) -> (* Ok *)
            struct (v105, v106)
    let v117 : US3 option = None
    let _v117 = ref v117 
    match v6 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v118 : string = x
    let v119 : US3 = US3_0(v118)
    v119 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v117.Value <- x
    let v120 : US3 option = _v117.Value 
    let v143 : US3 = US3_1
    let v144 : US3 = v120 |> Option.defaultValue v143 
    let v155 : string =
        match v144 with
        | US3_1 -> (* None *)
            let v153 : string = ""
            v153
        | US3_0(v152) -> (* Some *)
            v152
    let v156 : US0 = US0_1
    let v157 : (unit -> string) = closure14()
    let v158 : (unit -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure15(v0, v1, v2, v3, v4, v5, v6)
    method23(v156, v157, v158)
    let v159 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v163 : string =
        match v114 with
        | US3_1 -> (* None *)
            let v161 : string = ""
            v161
        | US3_0(v160) -> (* Some *)
            v160
    let start_info = System.Diagnostics.ProcessStartInfo (
      Arguments = v163,
      StandardOutputEncoding = v159,
      WorkingDirectory = v155,
      FileName = v113,
      CreateNoWindow = true,
      RedirectStandardError = true,
      RedirectStandardOutput = true,
      UseShellExecute = false
    )
    let v164 : System.Diagnostics.ProcessStartInfo = start_info
    let v165 : int32 = v2.Length
    let v166 : Mut5 = {l0 = 0} : Mut5
    while method12(v165, v166) do
        let v168 : int32 = v166.l0
        let struct (v169 : string, v170 : string) = v2.[int v168]
        v164.EnvironmentVariables.[v169] <- v170 
        let v171 : int32 = v168 + 1
        v166.l0 <- v171
        ()
    let v172 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v164)
    use v172 = v172 
    let v173 : System.Diagnostics.Process = v172 
    let v174 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v175 : System.Collections.Concurrent.ConcurrentStack<string> = v174 ()
    let v176 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure17(v0, v1, v2, v3, v4, v5, v6, v173, v175)
    v173.OutputDataReceived.Add v176 
    let v177 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure19(v0, v1, v2, v3, v4, v5, v6, v173, v175)
    v173.ErrorDataReceived.Add v177 
    let v178 : (unit -> bool) = v173.Start
    let v179 : bool = v178 ()
    let v180 : bool = v179 = false
    if v180 then
        let v181 : string = $"runtime.execute_with_options_async / process_start error"
        failwith<unit> v181
    let v182 : (unit -> unit) = v173.BeginErrorReadLine
    v182 ()
    let v183 : (unit -> unit) = v173.BeginOutputReadLine
    v183 ()
    let v186 : US13 option = None
    let _v186 = ref v186 
    match v1 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v187 : System.Threading.CancellationToken = x
    let v188 : US13 = US13_0(v187)
    v188 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v186.Value <- x
    let v189 : US13 option = _v186.Value 
    let v212 : US13 = US13_1
    let v213 : US13 = v189 |> Option.defaultValue v212 
    let v224 : System.Threading.CancellationToken =
        match v213 with
        | US13_1 -> (* None *)
            let v222 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v222
        | US13_0(v221) -> (* Some *)
            v221
    let v227 : bool = true
    let mutable _v227 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v230 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v230 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v239 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v239 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v248 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v248 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v257 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v257 
    #endif
#if FABLE_COMPILER_PYTHON
    let v266 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v266 
    #endif
#else
    let v275 : bool = true
    let mutable _v275 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v278 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v278 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v287 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v287 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v296 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v296 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v314 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v314 
    #endif
#else
    let v321 : Async<System.Threading.CancellationToken> option = None
    let mutable _v321 = v321 
    async {
    let v322 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v322 = v322 
    let v323 : System.Threading.CancellationToken = v322 
    let v324 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v325 : (System.Threading.CancellationToken []) = [|v323; v324; v224|]
    let v326 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v327 : System.Threading.CancellationTokenSource = v326 v325
    let v328 : System.Threading.CancellationToken = v327.Token
    return v328 
    }
    |> fun x -> _v321 <- Some x
    let v329 : Async<System.Threading.CancellationToken> = match _v321 with Some x -> x | None -> failwith "async.new_async_unit / _v321=None"
    v329 
    #endif
    |> fun x -> _v275 <- Some x
    let v330 : Async<System.Threading.CancellationToken> = match _v275 with Some x -> x | None -> failwith "base.run_target / _v275=None"
    v330 
    #endif
    |> fun x -> _v227 <- Some x
    let v345 : Async<System.Threading.CancellationToken> = match _v227 with Some x -> x | None -> failwith "base.run_target / _v227=None"
    let! v345 = v345 
    let v360 : System.Threading.CancellationToken = v345 
    let v361 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v360.Register
    let v362 : (unit -> unit) = closure20(v173)
    let v363 : System.Threading.CancellationTokenRegistration = v361 v362
    use v363 = v363 
    let v364 : System.Threading.CancellationTokenRegistration = v363 
    let v367 : bool = true
    let mutable _v367 : Async<int32> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v370 : Async<int32> = null |> unbox<Async<int32>>
    v370 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v379 : Async<int32> = null |> unbox<Async<int32>>
    v379 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v388 : Async<int32> = null |> unbox<Async<int32>>
    v388 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v397 : Async<int32> = null |> unbox<Async<int32>>
    v397 
    #endif
#if FABLE_COMPILER_PYTHON
    let v406 : Async<int32> = null |> unbox<Async<int32>>
    v406 
    #endif
#else
    let v413 : Async<int32> option = None
    let mutable _v413 = v413 
    async {
    try
    let v414 : System.Threading.Tasks.Task = v173.WaitForExitAsync v360 
    let v417 : bool = true
    let mutable _v417 : Async<unit> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v420 : Async<unit> = null |> unbox<Async<unit>>
    v420 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v429 : Async<unit> = null |> unbox<Async<unit>>
    v429 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v438 : Async<unit> = null |> unbox<Async<unit>>
    v438 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v447 : Async<unit> = null |> unbox<Async<unit>>
    v447 
    #endif
#if FABLE_COMPILER_PYTHON
    let v456 : Async<unit> = null |> unbox<Async<unit>>
    v456 
    #endif
#else
    let v463 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v464 : Async<unit> = v463 v414
    v464 
    #endif
    |> fun x -> _v417 <- Some x
    let v465 : Async<unit> = match _v417 with Some x -> x | None -> failwith "base.run_target / _v417=None"
    do! v465 
    let v480 : int32 = v173.ExitCode
    return v480 
    with ex ->
    let v481 : exn = ex
    let v484 : bool = true
    let mutable _v484 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v487 : string = $"%A{v481}"
    v487 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v496 : string = $"%A{v481}"
    v496 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v505 : string = $"%A{v481}"
    v505 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v514 : string = $"%A{v481}"
    v514 
    #endif
#if FABLE_COMPILER_PYTHON
    let v523 : string = $"%A{v481}"
    v523 
    #endif
#else
    let v530 : string = $"{v481.GetType ()}: {v481.Message}"
    v530 
    #endif
    |> fun x -> _v484 <- Some x
    let v531 : string = match _v484 with Some x -> x | None -> failwith "base.run_target / _v484=None"
    let v546 : (string -> unit) = v175.Push
    v546 v531
    let v549 : System.Threading.Tasks.TaskCanceledException = v481 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v556 : US0 = US0_3
    let v557 : (unit -> string) = closure21()
    let v558 : (unit -> System.Threading.Tasks.TaskCanceledException) = closure22(v549)
    method33(v556, v557, v558)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v413 <- Some x
    let v559 : Async<int32> = match _v413 with Some x -> x | None -> failwith "async.new_async_unit / _v413=None"
    v559 
    #endif
    |> fun x -> _v367 <- Some x
    let v560 : Async<int32> = match _v367 with Some x -> x | None -> failwith "base.run_target / _v367=None"
    let! v560 = v560 
    let v575 : int32 = v560 
    let v578 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v579 : string seq = v578 v175
    let v588 : (string -> (string seq -> string)) = String.concat
    let v589 : string = "\n"
    let v590 : (string seq -> string) = v588 v589
    let v591 : string = v590 v579
    let v598 : US0 = US0_1
    let v599 : (unit -> string) = closure24()
    let v600 : (unit -> struct (int32 * int32)) = closure25(v575, v591)
    method36(v598, v599, v600)
    return struct (v575, v591) 
    }
    |> fun x -> _v103 <- Some x
    let v601 : Async<struct (int32 * string)> = match _v103 with Some x -> x | None -> failwith "async.new_async_unit / _v103=None"
    v601 
    #endif
    |> fun x -> _v57 <- Some x
    let v602 : Async<struct (int32 * string)> = match _v57 with Some x -> x | None -> failwith "base.run_target / _v57=None"
    v602 
    #endif
    |> fun x -> _v9 <- Some x
    let v617 : Async<struct (int32 * string)> = match _v9 with Some x -> x | None -> failwith "base.run_target / _v9=None"
    v617
and closure9 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (string * string) []) = [||]
    let v3 : (struct (int32 * string * bool) -> Async<unit>) option = None
    let v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option = None
    let v5 : string option = None
    let v6 : bool = true
    method10(v0, v1, v2, v3, v4, v6, v5)
and closure27 () struct (v0 : string, v1 : System.Threading.CancellationToken option, v2 : (struct (string * string) []), v3 : (struct (int32 * string * bool) -> Async<unit>) option, v4 : (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option, v5 : bool, v6 : string option) : Async<struct (int32 * string)> =
    method10(v0, v1, v2, v3, v4, v5, v6)
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
    let v154 : US5 =
        if v5 then
            let v6 : char list = []
            let v9 : char list = ' ' :: v6 
            let v18 : char list = '"' :: v9 
            let v27 : char list = '`' :: v18 
            let v36 : char list = '\\' :: v27 
            let v45 : (char list -> (char [])) = List.toArray
            let v46 : (char []) = v45 v36
            let v53 : string = $"parsing.none_of / unexpected end of input / chars: %A{v46} / s: %A{struct (v2, v3, v4)}"
            US5_1(v53)
        else
            let v55 : char = v1.[int 0]
            let v56 : (string -> int32) = String.length
            let v57 : int32 = v56 v1
            let v58 : (int32 -> int32) = int32
            let v59 : int32 = v58 1
            let v60 : (int32 -> int32) = int32
            let v61 : int32 = v60 v57
            let v62 : string = v1.[int v59..int v61]
            let v63 : int64 = 0L
            let v64 : bool = method41(v55, v63)
            let v65 : bool = v64 = false
            if v65 then
                let v68 : (char -> string) = _.ToString()
                let v69 : string = v68 v55
                let v76 : int32 = v69.Length
                let v77 : (char []) = Array.zeroCreate<char> (v76)
                let v78 : Mut5 = {l0 = 0} : Mut5
                while method12(v76, v78) do
                    let v80 : int32 = v78.l0
                    let v81 : char = v69.[int v80]
                    v77.[int v80] <- v81
                    let v82 : int32 = v80 + 1
                    v78.l0 <- v82
                    ()
                let v83 : char list = v77 |> Array.toList
                let v86 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v87 : (char -> (UH0 -> UH0)) = method13()
                let v88 : (char list -> (UH0 -> UH0)) = v86 v87
                let v89 : (UH0 -> UH0) = v88 v83
                let v90 : UH0 = UH0_0
                let v91 : UH0 = v89 v90
                let struct (v100 : System.Text.StringBuilder, v101 : int32, v102 : int32) = method14(v91, v2, v3, v4)
                US5_0(v55, v62, v100, v101, v102)
            else
                let v104 : char list = []
                let v107 : char list = ' ' :: v104 
                let v116 : char list = '"' :: v107 
                let v125 : char list = '`' :: v116 
                let v134 : char list = '\\' :: v125 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v134
                let v151 : string = $"parsing.none_of / unexpected char: '{v55}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US5_1(v151)
    match v154 with
    | US5_1(v172) -> (* Error *)
        US6_0(v0, v1, v2, v3, v4)
    | US5_0(v155, v156, v157, v158, v159) -> (* Ok *)
        let v162 : (char -> string) = _.ToString()
        let v163 : string = v162 v155
        let v170 : string = v0 + v163 
        method42(v170, v156, v157, v158, v159)
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
    let v85 : US5 =
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
                let v18 : (char -> string) = _.ToString()
                let v19 : string = v18 v7
                let v26 : int32 = v19.Length
                let v27 : (char []) = Array.zeroCreate<char> (v26)
                let v28 : Mut5 = {l0 = 0} : Mut5
                while method12(v26, v28) do
                    let v30 : int32 = v28.l0
                    let v31 : char = v19.[int v30]
                    v27.[int v30] <- v31
                    let v32 : int32 = v30 + 1
                    v28.l0 <- v32
                    ()
                let v33 : char list = v27 |> Array.toList
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method13()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v33
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v50 : System.Text.StringBuilder, v51 : int32, v52 : int32) = method14(v41, v1, v2, v3)
                US5_0(v7, v15, v50, v51, v52)
            else
                let v54 : (string -> int32) = String.length
                let v55 : int32 = v54 v0
                let v56 : string = "\n"
                let v57 : int32 = v0.IndexOf v56 
                let v58 : int32 = v57 - 1
                let v59 : bool = -2 = v58
                let v60 : int32 =
                    if v59 then
                        v55
                    else
                        v58
                let v61 : (int32 -> int32) = int32
                let v62 : int32 = v61 0
                let v63 : (int32 -> int32) = int32
                let v64 : int32 = v63 v60
                let v65 : string = v0.[int v62..int v64]
                let v66 : string = $"parsing.p_char / expected: '{'\\'}' / line: {v2} / col: {v3}
{v1}{v65}"
                let v67 : int32 = v3 - 1
                let v70 : (int32 -> (string -> string)) = String.replicate
                let v71 : (string -> string) = v70 v67
                let v72 : string = " "
                let v73 : string = v71 v72
                let v80 : string = "^"
                let v81 : string = v73 + v80 
                let v82 : string = $"{v66}
{v81}
"
                US5_1(v82)
    let v144 : US5 =
        match v85 with
        | US5_1(v141) -> (* Error *)
            US5_1(v141)
        | US5_0(v86, v87, v88, v89, v90) -> (* Ok *)
            let v91 : bool = "" = v87
            if v91 then
                let v92 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v88, v89, v90)}"
                US5_1(v92)
            else
                let v94 : char = v87.[int 0]
                let v95 : (string -> int32) = String.length
                let v96 : int32 = v95 v87
                let v97 : (int32 -> int32) = int32
                let v98 : int32 = v97 1
                let v99 : (int32 -> int32) = int32
                let v100 : int32 = v99 v96
                let v101 : string = v87.[int v98..int v100]
                let v104 : (char -> string) = _.ToString()
                let v105 : string = v104 v94
                let v112 : int32 = v105.Length
                let v113 : (char []) = Array.zeroCreate<char> (v112)
                let v114 : Mut5 = {l0 = 0} : Mut5
                while method12(v112, v114) do
                    let v116 : int32 = v114.l0
                    let v117 : char = v105.[int v116]
                    v113.[int v116] <- v117
                    let v118 : int32 = v116 + 1
                    v114.l0 <- v118
                    ()
                let v119 : char list = v113 |> Array.toList
                let v122 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v123 : (char -> (UH0 -> UH0)) = method13()
                let v124 : (char list -> (UH0 -> UH0)) = v122 v123
                let v125 : (UH0 -> UH0) = v124 v119
                let v126 : UH0 = UH0_0
                let v127 : UH0 = v125 v126
                let struct (v136 : System.Text.StringBuilder, v137 : int32, v138 : int32) = method14(v127, v88, v89, v90)
                US5_0(v94, v101, v136, v137, v138)
    match v144 with
    | US5_1(v152) -> (* Error *)
        US6_1(v152)
    | US5_0(v145, v146, v147, v148, v149) -> (* Ok *)
        let v150 : string = $"{'\\'}{v145}"
        US6_0(v150, v146, v147, v148, v149)
and closure31 () struct (v0 : string, v1 : System.Text.StringBuilder, v2 : int32, v3 : int32) : US6 =
    let v4 : bool = "" = v0
    let v85 : US5 =
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
                let v18 : (char -> string) = _.ToString()
                let v19 : string = v18 v7
                let v26 : int32 = v19.Length
                let v27 : (char []) = Array.zeroCreate<char> (v26)
                let v28 : Mut5 = {l0 = 0} : Mut5
                while method12(v26, v28) do
                    let v30 : int32 = v28.l0
                    let v31 : char = v19.[int v30]
                    v27.[int v30] <- v31
                    let v32 : int32 = v30 + 1
                    v28.l0 <- v32
                    ()
                let v33 : char list = v27 |> Array.toList
                let v36 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v37 : (char -> (UH0 -> UH0)) = method13()
                let v38 : (char list -> (UH0 -> UH0)) = v36 v37
                let v39 : (UH0 -> UH0) = v38 v33
                let v40 : UH0 = UH0_0
                let v41 : UH0 = v39 v40
                let struct (v50 : System.Text.StringBuilder, v51 : int32, v52 : int32) = method14(v41, v1, v2, v3)
                US5_0(v7, v15, v50, v51, v52)
            else
                let v54 : (string -> int32) = String.length
                let v55 : int32 = v54 v0
                let v56 : string = "\n"
                let v57 : int32 = v0.IndexOf v56 
                let v58 : int32 = v57 - 1
                let v59 : bool = -2 = v58
                let v60 : int32 =
                    if v59 then
                        v55
                    else
                        v58
                let v61 : (int32 -> int32) = int32
                let v62 : int32 = v61 0
                let v63 : (int32 -> int32) = int32
                let v64 : int32 = v63 v60
                let v65 : string = v0.[int v62..int v64]
                let v66 : string = $"parsing.p_char / expected: '{'`'}' / line: {v2} / col: {v3}
{v1}{v65}"
                let v67 : int32 = v3 - 1
                let v70 : (int32 -> (string -> string)) = String.replicate
                let v71 : (string -> string) = v70 v67
                let v72 : string = " "
                let v73 : string = v71 v72
                let v80 : string = "^"
                let v81 : string = v73 + v80 
                let v82 : string = $"{v66}
{v81}
"
                US5_1(v82)
    let v144 : US5 =
        match v85 with
        | US5_1(v141) -> (* Error *)
            US5_1(v141)
        | US5_0(v86, v87, v88, v89, v90) -> (* Ok *)
            let v91 : bool = "" = v87
            if v91 then
                let v92 : string = $"parsing.any_char / unexpected end of input / s: %A{struct (v88, v89, v90)}"
                US5_1(v92)
            else
                let v94 : char = v87.[int 0]
                let v95 : (string -> int32) = String.length
                let v96 : int32 = v95 v87
                let v97 : (int32 -> int32) = int32
                let v98 : int32 = v97 1
                let v99 : (int32 -> int32) = int32
                let v100 : int32 = v99 v96
                let v101 : string = v87.[int v98..int v100]
                let v104 : (char -> string) = _.ToString()
                let v105 : string = v104 v94
                let v112 : int32 = v105.Length
                let v113 : (char []) = Array.zeroCreate<char> (v112)
                let v114 : Mut5 = {l0 = 0} : Mut5
                while method12(v112, v114) do
                    let v116 : int32 = v114.l0
                    let v117 : char = v105.[int v116]
                    v113.[int v116] <- v117
                    let v118 : int32 = v116 + 1
                    v114.l0 <- v118
                    ()
                let v119 : char list = v113 |> Array.toList
                let v122 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v123 : (char -> (UH0 -> UH0)) = method13()
                let v124 : (char list -> (UH0 -> UH0)) = v122 v123
                let v125 : (UH0 -> UH0) = v124 v119
                let v126 : UH0 = UH0_0
                let v127 : UH0 = v125 v126
                let struct (v136 : System.Text.StringBuilder, v137 : int32, v138 : int32) = method14(v127, v88, v89, v90)
                US5_0(v94, v101, v136, v137, v138)
    match v144 with
    | US5_1(v152) -> (* Error *)
        US6_1(v152)
    | US5_0(v145, v146, v147, v148, v149) -> (* Ok *)
        let v150 : string = $"{'`'}{v145}"
        US6_0(v150, v146, v147, v148, v149)
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
    let v136 : US5 =
        if v5 then
            let v6 : char list = []
            let v9 : char list = '"' :: v6 
            let v18 : char list = '`' :: v9 
            let v27 : char list = '\\' :: v18 
            let v36 : (char list -> (char [])) = List.toArray
            let v37 : (char []) = v36 v27
            let v44 : string = $"parsing.none_of / unexpected end of input / chars: %A{v37} / s: %A{struct (v2, v3, v4)}"
            US5_1(v44)
        else
            let v46 : char = v1.[int 0]
            let v47 : (string -> int32) = String.length
            let v48 : int32 = v47 v1
            let v49 : (int32 -> int32) = int32
            let v50 : int32 = v49 1
            let v51 : (int32 -> int32) = int32
            let v52 : int32 = v51 v48
            let v53 : string = v1.[int v50..int v52]
            let v54 : int64 = 0L
            let v55 : bool = method44(v46, v54)
            let v56 : bool = v55 = false
            if v56 then
                let v59 : (char -> string) = _.ToString()
                let v60 : string = v59 v46
                let v67 : int32 = v60.Length
                let v68 : (char []) = Array.zeroCreate<char> (v67)
                let v69 : Mut5 = {l0 = 0} : Mut5
                while method12(v67, v69) do
                    let v71 : int32 = v69.l0
                    let v72 : char = v60.[int v71]
                    v68.[int v71] <- v72
                    let v73 : int32 = v71 + 1
                    v69.l0 <- v73
                    ()
                let v74 : char list = v68 |> Array.toList
                let v77 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v78 : (char -> (UH0 -> UH0)) = method13()
                let v79 : (char list -> (UH0 -> UH0)) = v77 v78
                let v80 : (UH0 -> UH0) = v79 v74
                let v81 : UH0 = UH0_0
                let v82 : UH0 = v80 v81
                let struct (v91 : System.Text.StringBuilder, v92 : int32, v93 : int32) = method14(v82, v2, v3, v4)
                US5_0(v46, v53, v91, v92, v93)
            else
                let v95 : char list = []
                let v98 : char list = '"' :: v95 
                let v107 : char list = '`' :: v98 
                let v116 : char list = '\\' :: v107 
                let v125 : (char list -> (char [])) = List.toArray
                let v126 : (char []) = v125 v116
                let v133 : string = $"parsing.none_of / unexpected char: '{v46}' / chars: %A{v126} / s: %A{struct (v2, v3, v4)}"
                US5_1(v133)
    let v156 : US6 =
        match v136 with
        | US5_1(v153) -> (* Error *)
            US6_1(v153)
        | US5_0(v137, v138, v139, v140, v141) -> (* Ok *)
            let v144 : (char -> string) = _.ToString()
            let v145 : string = v144 v137
            US6_0(v145, v138, v139, v140, v141)
    let v170 : US6 =
        match v156 with
        | US6_1(v162) -> (* Error *)
            let v163 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure30()
            let v164 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure31()
            let v165 : UH3 = UH3_0
            let v166 : UH3 = UH3_1(v164, v165)
            let v167 : UH3 = UH3_1(v163, v166)
            method45(v1, v2, v3, v4, v167)
        | US6_0(v157, v158, v159, v160, v161) -> (* Ok *)
            v156
    match v170 with
    | US6_1(v178) -> (* Error *)
        let v179 : UH2 = UH2_0
        let v180 : UH2 = method46(v0, v179)
        US15_0(v180, v1, v2, v3, v4)
    | US6_0(v171, v172, v173, v174, v175) -> (* Ok *)
        let v176 : UH2 = UH2_1(v171, v0)
        method43(v176, v172, v173, v174, v175)
and method47 (v0 : UH2, v1 : string list) : string list =
    match v0 with
    | UH2_1(v2, v3) -> (* Cons *)
        let v4 : string list = method47(v3, v1)
        let v7 : string list = v2 :: v4 
        v7
    | UH2_0 -> (* Nil *)
        v1
and method48 (v0 : UH2, v1 : string, v2 : System.Text.StringBuilder, v3 : int32, v4 : int32) : US15 =
    let v5 : bool = "" = v1
    let v136 : US5 =
        if v5 then
            let v6 : char list = []
            let v9 : char list = '"' :: v6 
            let v18 : char list = '`' :: v9 
            let v27 : char list = '\\' :: v18 
            let v36 : (char list -> (char [])) = List.toArray
            let v37 : (char []) = v36 v27
            let v44 : string = $"parsing.none_of / unexpected end of input / chars: %A{v37} / s: %A{struct (v2, v3, v4)}"
            US5_1(v44)
        else
            let v46 : char = v1.[int 0]
            let v47 : (string -> int32) = String.length
            let v48 : int32 = v47 v1
            let v49 : (int32 -> int32) = int32
            let v50 : int32 = v49 1
            let v51 : (int32 -> int32) = int32
            let v52 : int32 = v51 v48
            let v53 : string = v1.[int v50..int v52]
            let v54 : int64 = 0L
            let v55 : bool = method44(v46, v54)
            let v56 : bool = v55 = false
            if v56 then
                let v59 : (char -> string) = _.ToString()
                let v60 : string = v59 v46
                let v67 : int32 = v60.Length
                let v68 : (char []) = Array.zeroCreate<char> (v67)
                let v69 : Mut5 = {l0 = 0} : Mut5
                while method12(v67, v69) do
                    let v71 : int32 = v69.l0
                    let v72 : char = v60.[int v71]
                    v68.[int v71] <- v72
                    let v73 : int32 = v71 + 1
                    v69.l0 <- v73
                    ()
                let v74 : char list = v68 |> Array.toList
                let v77 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v78 : (char -> (UH0 -> UH0)) = method13()
                let v79 : (char list -> (UH0 -> UH0)) = v77 v78
                let v80 : (UH0 -> UH0) = v79 v74
                let v81 : UH0 = UH0_0
                let v82 : UH0 = v80 v81
                let struct (v91 : System.Text.StringBuilder, v92 : int32, v93 : int32) = method14(v82, v2, v3, v4)
                US5_0(v46, v53, v91, v92, v93)
            else
                let v95 : char list = []
                let v98 : char list = '"' :: v95 
                let v107 : char list = '`' :: v98 
                let v116 : char list = '\\' :: v107 
                let v125 : (char list -> (char [])) = List.toArray
                let v126 : (char []) = v125 v116
                let v133 : string = $"parsing.none_of / unexpected char: '{v46}' / chars: %A{v126} / s: %A{struct (v2, v3, v4)}"
                US5_1(v133)
    let v156 : US6 =
        match v136 with
        | US5_1(v153) -> (* Error *)
            US6_1(v153)
        | US5_0(v137, v138, v139, v140, v141) -> (* Ok *)
            let v144 : (char -> string) = _.ToString()
            let v145 : string = v144 v137
            US6_0(v145, v138, v139, v140, v141)
    match v156 with
    | US6_1(v164) -> (* Error *)
        let v165 : UH2 = UH2_0
        let v166 : UH2 = method46(v0, v165)
        US15_0(v166, v1, v2, v3, v4)
    | US6_0(v157, v158, v159, v160, v161) -> (* Ok *)
        let v162 : UH2 = UH2_1(v157, v0)
        method48(v162, v158, v159, v160, v161)
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
    let v154 : US5 =
        if v5 then
            let v6 : char list = []
            let v9 : char list = ' ' :: v6 
            let v18 : char list = '"' :: v9 
            let v27 : char list = '`' :: v18 
            let v36 : char list = '\\' :: v27 
            let v45 : (char list -> (char [])) = List.toArray
            let v46 : (char []) = v45 v36
            let v53 : string = $"parsing.none_of / unexpected end of input / chars: %A{v46} / s: %A{struct (v2, v3, v4)}"
            US5_1(v53)
        else
            let v55 : char = v1.[int 0]
            let v56 : (string -> int32) = String.length
            let v57 : int32 = v56 v1
            let v58 : (int32 -> int32) = int32
            let v59 : int32 = v58 1
            let v60 : (int32 -> int32) = int32
            let v61 : int32 = v60 v57
            let v62 : string = v1.[int v59..int v61]
            let v63 : int64 = 0L
            let v64 : bool = method41(v55, v63)
            let v65 : bool = v64 = false
            if v65 then
                let v68 : (char -> string) = _.ToString()
                let v69 : string = v68 v55
                let v76 : int32 = v69.Length
                let v77 : (char []) = Array.zeroCreate<char> (v76)
                let v78 : Mut5 = {l0 = 0} : Mut5
                while method12(v76, v78) do
                    let v80 : int32 = v78.l0
                    let v81 : char = v69.[int v80]
                    v77.[int v80] <- v81
                    let v82 : int32 = v80 + 1
                    v78.l0 <- v82
                    ()
                let v83 : char list = v77 |> Array.toList
                let v86 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                let v87 : (char -> (UH0 -> UH0)) = method13()
                let v88 : (char list -> (UH0 -> UH0)) = v86 v87
                let v89 : (UH0 -> UH0) = v88 v83
                let v90 : UH0 = UH0_0
                let v91 : UH0 = v89 v90
                let struct (v100 : System.Text.StringBuilder, v101 : int32, v102 : int32) = method14(v91, v2, v3, v4)
                US5_0(v55, v62, v100, v101, v102)
            else
                let v104 : char list = []
                let v107 : char list = ' ' :: v104 
                let v116 : char list = '"' :: v107 
                let v125 : char list = '`' :: v116 
                let v134 : char list = '\\' :: v125 
                let v143 : (char list -> (char [])) = List.toArray
                let v144 : (char []) = v143 v134
                let v151 : string = $"parsing.none_of / unexpected char: '{v55}' / chars: %A{v144} / s: %A{struct (v2, v3, v4)}"
                US5_1(v151)
    let v174 : US6 =
        match v154 with
        | US5_1(v155) -> (* Error *)
            US6_1(v155)
        | US5_0(v157, v158, v159, v160, v161) -> (* Ok *)
            let v164 : (char -> string) = _.ToString()
            let v165 : string = v164 v157
            method42(v165, v158, v159, v160, v161)
    let v479 : US6 =
        match v174 with
        | US6_1(v180) -> (* Error *)
            let v261 : US5 =
                if v5 then
                    let v181 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v2, v3, v4)}"
                    US5_1(v181)
                else
                    let v183 : char = v1.[int 0]
                    let v184 : bool = v183 = '"'
                    if v184 then
                        let v185 : (string -> int32) = String.length
                        let v186 : int32 = v185 v1
                        let v187 : (int32 -> int32) = int32
                        let v188 : int32 = v187 1
                        let v189 : (int32 -> int32) = int32
                        let v190 : int32 = v189 v186
                        let v191 : string = v1.[int v188..int v190]
                        let v194 : (char -> string) = _.ToString()
                        let v195 : string = v194 v183
                        let v202 : int32 = v195.Length
                        let v203 : (char []) = Array.zeroCreate<char> (v202)
                        let v204 : Mut5 = {l0 = 0} : Mut5
                        while method12(v202, v204) do
                            let v206 : int32 = v204.l0
                            let v207 : char = v195.[int v206]
                            v203.[int v206] <- v207
                            let v208 : int32 = v206 + 1
                            v204.l0 <- v208
                            ()
                        let v209 : char list = v203 |> Array.toList
                        let v212 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                        let v213 : (char -> (UH0 -> UH0)) = method13()
                        let v214 : (char list -> (UH0 -> UH0)) = v212 v213
                        let v215 : (UH0 -> UH0) = v214 v209
                        let v216 : UH0 = UH0_0
                        let v217 : UH0 = v215 v216
                        let struct (v226 : System.Text.StringBuilder, v227 : int32, v228 : int32) = method14(v217, v2, v3, v4)
                        US5_0(v183, v191, v226, v227, v228)
                    else
                        let v230 : (string -> int32) = String.length
                        let v231 : int32 = v230 v1
                        let v232 : string = "\n"
                        let v233 : int32 = v1.IndexOf v232 
                        let v234 : int32 = v233 - 1
                        let v235 : bool = -2 = v234
                        let v236 : int32 =
                            if v235 then
                                v231
                            else
                                v234
                        let v237 : (int32 -> int32) = int32
                        let v238 : int32 = v237 0
                        let v239 : (int32 -> int32) = int32
                        let v240 : int32 = v239 v236
                        let v241 : string = v1.[int v238..int v240]
                        let v242 : string = $"parsing.p_char / expected: '{'"'}' / line: {v3} / col: {v4}
{v2}{v241}"
                        let v243 : int32 = v4 - 1
                        let v246 : (int32 -> (string -> string)) = String.replicate
                        let v247 : (string -> string) = v246 v243
                        let v248 : string = " "
                        let v249 : string = v247 v248
                        let v256 : string = "^"
                        let v257 : string = v249 + v256 
                        let v258 : string = $"{v242}
{v257}
"
                        US5_1(v258)
            let v408 : US6 =
                match v261 with
                | US5_1(v405) -> (* Error *)
                    US6_1(v405)
                | US5_0(v262, v263, v264, v265, v266) -> (* Ok *)
                    let v267 : UH2 = UH2_0
                    let v268 : US15 = method43(v267, v263, v264, v265, v266)
                    let v301 : US6 =
                        match v268 with
                        | US15_1(v298) -> (* Error *)
                            US6_1(v298)
                        | US15_0(v269, v270, v271, v272, v273) -> (* Ok *)
                            let v274 : string list = []
                            let v275 : string list = method47(v269, v274)
                            let v278 : string seq = seq { for i = 0 to v275.Length - 1 do yield v275.[i] }
                            let v287 : (string -> (string seq -> string)) = String.concat
                            let v288 : string = ""
                            let v289 : (string seq -> string) = v287 v288
                            let v290 : string = v289 v278
                            US6_0(v290, v270, v271, v272, v273)
                    match v301 with
                    | US6_1(v400) -> (* Error *)
                        let v401 : string = "between / expected content"
                        US6_1(v401)
                    | US6_0(v302, v303, v304, v305, v306) -> (* Ok *)
                        let v307 : bool = "" = v303
                        let v388 : US5 =
                            if v307 then
                                let v308 : string = $"parsing.p_char / unexpected end of input / s: %A{struct (v304, v305, v306)}"
                                US5_1(v308)
                            else
                                let v310 : char = v303.[int 0]
                                let v311 : bool = v310 = '"'
                                if v311 then
                                    let v312 : (string -> int32) = String.length
                                    let v313 : int32 = v312 v303
                                    let v314 : (int32 -> int32) = int32
                                    let v315 : int32 = v314 1
                                    let v316 : (int32 -> int32) = int32
                                    let v317 : int32 = v316 v313
                                    let v318 : string = v303.[int v315..int v317]
                                    let v321 : (char -> string) = _.ToString()
                                    let v322 : string = v321 v310
                                    let v329 : int32 = v322.Length
                                    let v330 : (char []) = Array.zeroCreate<char> (v329)
                                    let v331 : Mut5 = {l0 = 0} : Mut5
                                    while method12(v329, v331) do
                                        let v333 : int32 = v331.l0
                                        let v334 : char = v322.[int v333]
                                        v330.[int v333] <- v334
                                        let v335 : int32 = v333 + 1
                                        v331.l0 <- v335
                                        ()
                                    let v336 : char list = v330 |> Array.toList
                                    let v339 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
                                    let v340 : (char -> (UH0 -> UH0)) = method13()
                                    let v341 : (char list -> (UH0 -> UH0)) = v339 v340
                                    let v342 : (UH0 -> UH0) = v341 v336
                                    let v343 : UH0 = UH0_0
                                    let v344 : UH0 = v342 v343
                                    let struct (v353 : System.Text.StringBuilder, v354 : int32, v355 : int32) = method14(v344, v304, v305, v306)
                                    US5_0(v310, v318, v353, v354, v355)
                                else
                                    let v357 : (string -> int32) = String.length
                                    let v358 : int32 = v357 v303
                                    let v359 : string = "\n"
                                    let v360 : int32 = v303.IndexOf v359 
                                    let v361 : int32 = v360 - 1
                                    let v362 : bool = -2 = v361
                                    let v363 : int32 =
                                        if v362 then
                                            v358
                                        else
                                            v361
                                    let v364 : (int32 -> int32) = int32
                                    let v365 : int32 = v364 0
                                    let v366 : (int32 -> int32) = int32
                                    let v367 : int32 = v366 v363
                                    let v368 : string = v303.[int v365..int v367]
                                    let v369 : string = $"parsing.p_char / expected: '{'"'}' / line: {v305} / col: {v306}
{v304}{v368}"
                                    let v370 : int32 = v306 - 1
                                    let v373 : (int32 -> (string -> string)) = String.replicate
                                    let v374 : (string -> string) = v373 v370
                                    let v375 : string = " "
                                    let v376 : string = v374 v375
                                    let v383 : string = "^"
                                    let v384 : string = v376 + v383 
                                    let v385 : string = $"{v369}
{v384}
"
                                    US5_1(v385)
                        match v388 with
                        | US5_1(v395) -> (* Error *)
                            let v396 : string = $"between / expected closing delimiter / e: %A{v395} / input: %A{struct (v1, v2, v3, v4)} / rest1: %A{struct (v263, v264, v265, v266)} / rest2: %A{struct (v303, v304, v305, v306)}"
                            US6_1(v396)
                        | US5_0(v389, v390, v391, v392, v393) -> (* Ok *)
                            US6_0(v302, v390, v391, v392, v393)
            match v408 with
            | US6_1(v414) -> (* Error *)
                let v415 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure30()
                let v416 : (struct (string * System.Text.StringBuilder * int32 * int32) -> US6) = closure31()
                let v417 : UH3 = UH3_0
                let v418 : UH3 = UH3_1(v416, v417)
                let v419 : UH3 = UH3_1(v415, v418)
                let v420 : US6 = method45(v1, v2, v3, v4, v419)
                let v431 : US6 =
                    match v420 with
                    | US6_1(v428) -> (* Error *)
                        US6_1(v428)
                    | US6_0(v421, v422, v423, v424, v425) -> (* Ok *)
                        let v426 : string = ""
                        US6_0(v426, v422, v423, v424, v425)
                let v442 : US15 =
                    match v431 with
                    | US6_1(v439) -> (* Error *)
                        US15_1(v439)
                    | US6_0(v432, v433, v434, v435, v436) -> (* Ok *)
                        let v437 : UH2 = UH2_0
                        method48(v437, v433, v434, v435, v436)
                match v442 with
                | US15_1(v472) -> (* Error *)
                    US6_1(v472)
                | US15_0(v443, v444, v445, v446, v447) -> (* Ok *)
                    let v448 : string list = []
                    let v449 : string list = method47(v443, v448)
                    let v452 : string seq = seq { for i = 0 to v449.Length - 1 do yield v449.[i] }
                    let v461 : (string -> (string seq -> string)) = String.concat
                    let v462 : string = ""
                    let v463 : (string seq -> string) = v461 v462
                    let v464 : string = v463 v452
                    US6_0(v464, v444, v445, v446, v447)
            | US6_0(v409, v410, v411, v412, v413) -> (* Ok *)
                v408
        | US6_0(v175, v176, v177, v178, v179) -> (* Ok *)
            v174
    match v479 with
    | US6_1(v480) -> (* Error *)
        let v481 : UH2 = UH2_0
        let v482 : UH2 = method46(v0, v481)
        US15_0(v482, v1, v2, v3, v4)
    | US6_0(v484, v485, v486, v487, v488) -> (* Ok *)
        let v489 : int32 = 0
        let v490 : int32 = method49(v485, v489)
        let v491 : bool = 0 = v490
        let v502 : US8 =
            if v491 then
                let v492 : string = "spaces1 / expected at least one space"
                US8_1(v492)
            else
                let v494 : (string -> int32) = String.length
                let v495 : int32 = v494 v485
                let v496 : (int32 -> int32) = int32
                let v497 : int32 = v496 v490
                let v498 : (int32 -> int32) = int32
                let v499 : int32 = v498 v495
                let v500 : string = v485.[int v497..int v499]
                US8_0(v500, v486, v487, v488)
        match v502 with
        | US8_1(v503) -> (* Error *)
            let v504 : UH2 = UH2_0
            let v505 : UH2 = UH2_1(v484, v504)
            let v506 : UH2 = method46(v0, v505)
            US15_0(v506, v485, v486, v487, v488)
        | US8_0(v508, v509, v510, v511) -> (* Ok *)
            let v512 : UH2 = UH2_1(v484, v0)
            method40(v512, v508, v509, v510, v511)
and method39 (v0 : string) : US14 =
    let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v3 : (string -> string option) = Option.ofObj
    let v4 : string option = v3 v0
    v4 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v5 : string option = match _v0 with Some x -> x | None -> failwith "optionm'.of_obj / _v0=None"
    let v14 : string = ""
    let v15 : string = v5 |> Option.defaultValue v14 
    let v22 : (string -> System.Text.StringBuilder) = System.Text.StringBuilder 
    let v23 : System.Text.StringBuilder = v22 v14
    let v24 : UH2 = UH2_0
    let v25 : int32 = 1
    let v26 : int32 = 1
    let v27 : US15 = method40(v24, v15, v23, v25, v26)
    match v27 with
    | US15_1(v46) -> (* Error *)
        US14_1(v46)
    | US15_0(v28, v29, v30, v31, v32) -> (* Ok *)
        let v33 : string list = []
        let v34 : string list = method47(v28, v33)
        let v37 : (string list -> (string [])) = List.toArray
        let v38 : (string []) = v37 v34
        US14_0(v38)
and closure29 () (v0 : string) : Result<(string []), string> =
    let v1 : US14 = method39(v0)
    match v1 with
    | US14_1(v4) -> (* Error *)
        let v5 : Result<(string []), string> = Error v4 
        v5
    | US14_0(v2) -> (* Ok *)
        let v3 : Result<(string []), string> = Ok v2 
        v3
let v2 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
let v3 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v2 v3 |> Some
let v9 : (unit -> unit) = closure2()
let current_process_kill () = v9 ()
let v10 : (string -> Async<struct (int32 * string)>) = closure9()
let execute_async x = v10 x
let v11 : (struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option) -> Async<struct (int32 * string)>) = closure27()
let execute_with_options_async x = v11 x
let v12 : ((Heap0 -> Heap0) -> struct (string * System.Threading.CancellationToken option * (struct (string * string) []) * (struct (int32 * string * bool) -> Async<unit>) option * (std_sync_Arc<std_sync_Mutex<std_process_ChildStdin>> -> unit) option * bool * string option)) = closure28()
let execution_options x = v12 x
let v13 : (string -> Result<(string []), string>) = closure29()
let split_args x = v13 x
()
