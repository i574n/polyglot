#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::env::VarError")>]
#endif
type std_env_VarError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>]
#endif
type Func0<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>]
#endif
type Func0<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>]
#endif
type Fn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>]
#endif
type FnUnit = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>]
#endif
type FnOnce<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>]
#endif
type ActionFn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>]
#endif
type ActionFn2<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>]
#endif
type Impl<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>]
#endif
type std_cell_RefCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>]
#endif
type std_rc_Rc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>]
#endif
type std_rc_Weak<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>]
#endif
type base64_DecodeError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>]
#endif
type borsh_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>]
#endif
type js_sys_JsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>]
#endif
type serde_json_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>]
#endif
type serde_json_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>]
#endif
type serde_wasm_bindgen_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fmt::Display<$0>")>]
#endif
type std_fmt_Display<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::slice::Windows<$0>")>]
#endif
type std_slice_Windows<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
module State = let mutable trace_state = None
type IOsEnviron = abstract environ: x: unit -> obj
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
    let v85 : US1 = US1_1
    let v86 : US2 = US2_1
    struct (v85, v86) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v87 : string = method0()
    let v88 : string = method1(v87)
    let v90 : bool = "Verbose" = v88
    let v94 : US1 =
        if v90 then
            let v91 : US0 = US0_0
            US1_0(v91)
        else
            US1_1
    let v139 : US1 =
        match v94 with
        | US1_1 -> (* None *)
            let v98 : bool = "Debug" = v88
            let v102 : US1 =
                if v98 then
                    let v99 : US0 = US0_1
                    US1_0(v99)
                else
                    US1_1
            match v102 with
            | US1_1 -> (* None *)
                let v106 : bool = "Info" = v88
                let v110 : US1 =
                    if v106 then
                        let v107 : US0 = US0_2
                        US1_0(v107)
                    else
                        US1_1
                match v110 with
                | US1_1 -> (* None *)
                    let v114 : bool = "Warning" = v88
                    let v118 : US1 =
                        if v114 then
                            let v115 : US0 = US0_3
                            US1_0(v115)
                        else
                            US1_1
                    match v118 with
                    | US1_1 -> (* None *)
                        let v122 : bool = "Critical" = v88
                        let v126 : US1 =
                            if v122 then
                                let v123 : US0 = US0_4
                                US1_0(v123)
                            else
                                US1_1
                        match v126 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v127) -> (* Some *)
                            US1_0(v127)
                    | US1_0(v119) -> (* Some *)
                        US1_0(v119)
                | US1_0(v111) -> (* Some *)
                    US1_0(v111)
            | US1_0(v103) -> (* Some *)
                US1_0(v103)
        | US1_0(v95) -> (* Some *)
            US1_0(v95)
    let v140 : string = method3()
    let v141 : string = method1(v140)
    let v143 : bool = v141 = "True"
    let v165 : US2 =
        if v143 then
            let v146 : System.DateTime = System.DateTime.Now
            let v155 : (System.DateTime -> int64) = _.Ticks
            let v156 : int64 = v155 v146
            US2_0(v156)
        else
            US2_1
    struct (v139, v165) 
    #endif
#if FABLE_COMPILER_PYTHON
    let v166 : string = method0()
    let v167 : string = method1(v166)
    let v169 : bool = "Verbose" = v167
    let v173 : US1 =
        if v169 then
            let v170 : US0 = US0_0
            US1_0(v170)
        else
            US1_1
    let v218 : US1 =
        match v173 with
        | US1_1 -> (* None *)
            let v177 : bool = "Debug" = v167
            let v181 : US1 =
                if v177 then
                    let v178 : US0 = US0_1
                    US1_0(v178)
                else
                    US1_1
            match v181 with
            | US1_1 -> (* None *)
                let v185 : bool = "Info" = v167
                let v189 : US1 =
                    if v185 then
                        let v186 : US0 = US0_2
                        US1_0(v186)
                    else
                        US1_1
                match v189 with
                | US1_1 -> (* None *)
                    let v193 : bool = "Warning" = v167
                    let v197 : US1 =
                        if v193 then
                            let v194 : US0 = US0_3
                            US1_0(v194)
                        else
                            US1_1
                    match v197 with
                    | US1_1 -> (* None *)
                        let v201 : bool = "Critical" = v167
                        let v205 : US1 =
                            if v201 then
                                let v202 : US0 = US0_4
                                US1_0(v202)
                            else
                                US1_1
                        match v205 with
                        | US1_1 -> (* None *)
                            US1_1
                        | US1_0(v206) -> (* Some *)
                            US1_0(v206)
                    | US1_0(v198) -> (* Some *)
                        US1_0(v198)
                | US1_0(v190) -> (* Some *)
                    US1_0(v190)
            | US1_0(v182) -> (* Some *)
                US1_0(v182)
        | US1_0(v174) -> (* Some *)
            US1_0(v174)
    let v219 : string = method3()
    let v220 : string = method1(v219)
    let v222 : bool = v220 = "True"
    let v244 : US2 =
        if v222 then
            let v225 : System.DateTime = System.DateTime.Now
            let v234 : (System.DateTime -> int64) = _.Ticks
            let v235 : int64 = v234 v225
            US2_0(v235)
        else
            US2_1
    struct (v218, v244) 
    #endif
#else
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
    let v301 : bool = v299 = "True"
    let v323 : US2 =
        if v301 then
            let v304 : System.DateTime = System.DateTime.Now
            let v313 : (System.DateTime -> int64) = _.Ticks
            let v314 : int64 = v313 v304
            US2_0(v314)
        else
            US2_1
    struct (v297, v323) 
    #endif
    |> fun x -> _v3 <- Some x
    let struct (v324 : US1, v325 : US2) = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    let v411 : Mut2 = {l0 = true} : Mut2
    let v412 : Mut0 = {l0 = 0L} : Mut0
    let v415 : US0 =
        match v324 with
        | US1_1 -> (* None *)
            v0
        | US1_0(v413) -> (* Some *)
            v413
    let v416 : Mut3 = {l0 = v415} : Mut3
    let v417 : (string -> unit) = closure1()
    let v418 : Mut1 = {l0 = v417} : Mut1
    let v431 : int64 option =
        match v325 with
        | US2_1 -> (* None *)
            let v429 : int64 option = None
            v429
        | US2_0(v419) -> (* Some *)
            let v422 : int64 option = Some v419 
            v422
    struct (v412, v418, v411, v416, v431)
and method5 () : string =
    let v0 : string = "hh:mm:ss"
    v0
and method6 () : string =
    let v0 : string = ""
    v0
and method7 () : string =
    let v0 : string = "HH:mm:ss"
    v0
and method8 () : string =
    let v0 : string = "\u001b[0m"
    v0
and method9 (v0 : Mut4, v1 : string) : unit =
    let v4 : string = $"{v1}"
    let v11 : string = v0.l0
    let v12 : string = v11 + v4 
    v0.l0 <- v12
    ()
and closure5 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
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
    let v330 : string = method6()
    v330 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v333 : US2 option = None
    let _v333 = ref v333 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v334 : int64 = x
    let v335 : US2 = US2_0(v334)
    v335 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v333.Value <- x
    let v336 : US2 option = _v333.Value 
    let v359 : US2 = US2_1
    let v360 : US2 = v336 |> Option.defaultValue v359 
    let v458 : System.DateTime =
        match v360 with
        | US2_1 -> (* None *)
            let v450 : System.DateTime = System.DateTime.Now
            v450
        | US2_0(v368) -> (* Some *)
            let v371 : System.DateTime = System.DateTime.Now
            let v380 : (System.DateTime -> int64) = _.Ticks
            let v381 : int64 = v380 v371
            let v388 : int64 = v381 - v368
            let v391 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v392 : System.TimeSpan = v391 v388
            let v401 : (System.TimeSpan -> int32) = _.Hours
            let v402 : int32 = v401 v392
            let v411 : (System.TimeSpan -> int32) = _.Minutes
            let v412 : int32 = v411 v392
            let v421 : (System.TimeSpan -> int32) = _.Seconds
            let v422 : int32 = v421 v392
            let v431 : (System.TimeSpan -> int32) = _.Milliseconds
            let v432 : int32 = v431 v392
            let v441 : System.DateTime = System.DateTime (1, 1, 1, v402, v412, v422, v432)
            v441
    let v461 : string = method7()
    let v470 : (string -> string) = v458.ToString
    let v471 : string = v470 v461
    v471 
    #endif
#if FABLE_COMPILER_PYTHON
    let v480 : US2 option = None
    let _v480 = ref v480 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v481 : int64 = x
    let v482 : US2 = US2_0(v481)
    v482 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v480.Value <- x
    let v483 : US2 option = _v480.Value 
    let v506 : US2 = US2_1
    let v507 : US2 = v483 |> Option.defaultValue v506 
    let v605 : System.DateTime =
        match v507 with
        | US2_1 -> (* None *)
            let v597 : System.DateTime = System.DateTime.Now
            v597
        | US2_0(v515) -> (* Some *)
            let v518 : System.DateTime = System.DateTime.Now
            let v527 : (System.DateTime -> int64) = _.Ticks
            let v528 : int64 = v527 v518
            let v535 : int64 = v528 - v515
            let v538 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v539 : System.TimeSpan = v538 v535
            let v548 : (System.TimeSpan -> int32) = _.Hours
            let v549 : int32 = v548 v539
            let v558 : (System.TimeSpan -> int32) = _.Minutes
            let v559 : int32 = v558 v539
            let v568 : (System.TimeSpan -> int32) = _.Seconds
            let v569 : int32 = v568 v539
            let v578 : (System.TimeSpan -> int32) = _.Milliseconds
            let v579 : int32 = v578 v539
            let v588 : System.DateTime = System.DateTime (1, 1, 1, v549, v559, v569, v579)
            v588
    let v608 : string = method7()
    let v617 : (string -> string) = v605.ToString
    let v618 : string = v617 v608
    v618 
    #endif
#else
    let v627 : US2 option = None
    let _v627 = ref v627 
    match v18 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v628 : int64 = x
    let v629 : US2 = US2_0(v628)
    v629 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v627.Value <- x
    let v630 : US2 option = _v627.Value 
    let v653 : US2 = US2_1
    let v654 : US2 = v630 |> Option.defaultValue v653 
    let v752 : System.DateTime =
        match v654 with
        | US2_1 -> (* None *)
            let v744 : System.DateTime = System.DateTime.Now
            v744
        | US2_0(v662) -> (* Some *)
            let v665 : System.DateTime = System.DateTime.Now
            let v674 : (System.DateTime -> int64) = _.Ticks
            let v675 : int64 = v674 v665
            let v682 : int64 = v675 - v662
            let v685 : (int64 -> System.TimeSpan) = System.TimeSpan 
            let v686 : System.TimeSpan = v685 v682
            let v695 : (System.TimeSpan -> int32) = _.Hours
            let v696 : int32 = v695 v686
            let v705 : (System.TimeSpan -> int32) = _.Minutes
            let v706 : int32 = v705 v686
            let v715 : (System.TimeSpan -> int32) = _.Seconds
            let v716 : int32 = v715 v686
            let v725 : (System.TimeSpan -> int32) = _.Milliseconds
            let v726 : int32 = v725 v686
            let v735 : System.DateTime = System.DateTime (1, 1, 1, v696, v706, v716, v726)
            v735
    let v755 : string = method7()
    let v764 : (string -> string) = v752.ToString
    let v765 : string = v764 v755
    v765 
    #endif
    |> fun x -> _v35 <- Some x
    let v772 : string = match _v35 with Some x -> x | None -> failwith "base.run_target / _v35=None"
    let v927 : bool =
        match v0 with
        | US0_0 -> (* Verbose *)
            true
        | _ ->
            false
    let v931 : US3 =
        if v927 then
            let v928 : string = "Verbose"
            US3_0(v928)
        else
            US3_1
    let v980 : US3 =
        match v931 with
        | US3_1 -> (* None *)
            let v936 : bool =
                match v0 with
                | US0_1 -> (* Debug *)
                    true
                | _ ->
                    false
            let v940 : US3 =
                if v936 then
                    let v937 : string = "Debug"
                    US3_0(v937)
                else
                    US3_1
            match v940 with
            | US3_1 -> (* None *)
                let v945 : bool =
                    match v0 with
                    | US0_2 -> (* Info *)
                        true
                    | _ ->
                        false
                let v949 : US3 =
                    if v945 then
                        let v946 : string = "Info"
                        US3_0(v946)
                    else
                        US3_1
                match v949 with
                | US3_1 -> (* None *)
                    let v954 : bool =
                        match v0 with
                        | US0_3 -> (* Warning *)
                            true
                        | _ ->
                            false
                    let v958 : US3 =
                        if v954 then
                            let v955 : string = "Warning"
                            US3_0(v955)
                        else
                            US3_1
                    match v958 with
                    | US3_1 -> (* None *)
                        let v963 : bool =
                            match v0 with
                            | US0_4 -> (* Critical *)
                                true
                            | _ ->
                                false
                        let v967 : US3 =
                            if v963 then
                                let v964 : string = "Critical"
                                US3_0(v964)
                            else
                                US3_1
                        match v967 with
                        | US3_1 -> (* None *)
                            US3_1
                        | US3_0(v968) -> (* Some *)
                            US3_0(v968)
                    | US3_0(v959) -> (* Some *)
                        US3_0(v959)
                | US3_0(v950) -> (* Some *)
                    US3_0(v950)
            | US3_0(v941) -> (* Some *)
                US3_0(v941)
        | US3_0(v932) -> (* Some *)
            US3_0(v932)
    let v984 : string =
        match v980 with
        | US3_1 -> (* None *)
            failwith<string> "Option does not have a value."
        | US3_0(v981) -> (* Some *)
            v981
    let v987 : (unit -> string) = v984.ToLower
    let v988 : string = v987 ()
    let v997 : string = v988.PadLeft (7, ' ')
    let v1029 : bool = true
    let mutable _v1029 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1044 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1038 : string = "inline_colorization::color_bright_red"
            let v1039 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1038 
            v1039
        | US0_1 -> (* Debug *)
            let v1032 : string = "inline_colorization::color_bright_blue"
            let v1033 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1032 
            v1033
        | US0_2 -> (* Info *)
            let v1034 : string = "inline_colorization::color_bright_green"
            let v1035 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1034 
            v1035
        | US0_0 -> (* Verbose *)
            let v1030 : string = "inline_colorization::color_bright_black"
            let v1031 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1030 
            v1031
        | US0_3 -> (* Warning *)
            let v1036 : string = "inline_colorization::color_yellow"
            let v1037 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1036 
            v1037
    let v1045 : string = "&*$0"
    let v1046 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v997 v1045 
    let v1047 : string = "inline_colorization::color_reset"
    let v1048 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1047 
    let v1049 : string = "\"{v1044}{v1046}{v1048}\""
    let v1050 : string = @$"format!(" + v1049 + ")"
    let v1051 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1050 
    let v1052 : string = "fable_library_rust::String_::fromString($0)"
    let v1053 : string = Fable.Core.RustInterop.emitRustExpr v1051 v1052 
    v1053 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1068 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1062 : string = "inline_colorization::color_bright_red"
            let v1063 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1062 
            v1063
        | US0_1 -> (* Debug *)
            let v1056 : string = "inline_colorization::color_bright_blue"
            let v1057 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1056 
            v1057
        | US0_2 -> (* Info *)
            let v1058 : string = "inline_colorization::color_bright_green"
            let v1059 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1058 
            v1059
        | US0_0 -> (* Verbose *)
            let v1054 : string = "inline_colorization::color_bright_black"
            let v1055 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1054 
            v1055
        | US0_3 -> (* Warning *)
            let v1060 : string = "inline_colorization::color_yellow"
            let v1061 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1060 
            v1061
    let v1069 : string = "&*$0"
    let v1070 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v997 v1069 
    let v1071 : string = "inline_colorization::color_reset"
    let v1072 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1071 
    let v1073 : string = "\"{v1068}{v1070}{v1072}\""
    let v1074 : string = @$"format!(" + v1073 + ")"
    let v1075 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1074 
    let v1076 : string = "fable_library_rust::String_::fromString($0)"
    let v1077 : string = Fable.Core.RustInterop.emitRustExpr v1075 v1076 
    v1077 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1092 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1086 : string = "inline_colorization::color_bright_red"
            let v1087 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1086 
            v1087
        | US0_1 -> (* Debug *)
            let v1080 : string = "inline_colorization::color_bright_blue"
            let v1081 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1080 
            v1081
        | US0_2 -> (* Info *)
            let v1082 : string = "inline_colorization::color_bright_green"
            let v1083 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1082 
            v1083
        | US0_0 -> (* Verbose *)
            let v1078 : string = "inline_colorization::color_bright_black"
            let v1079 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1078 
            v1079
        | US0_3 -> (* Warning *)
            let v1084 : string = "inline_colorization::color_yellow"
            let v1085 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1084 
            v1085
    let v1093 : string = "&*$0"
    let v1094 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v997 v1093 
    let v1095 : string = "inline_colorization::color_reset"
    let v1096 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v1095 
    let v1097 : string = "\"{v1092}{v1094}{v1096}\""
    let v1098 : string = @$"format!(" + v1097 + ")"
    let v1099 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v1098 
    let v1100 : string = "fable_library_rust::String_::fromString($0)"
    let v1101 : string = Fable.Core.RustInterop.emitRustExpr v1099 v1100 
    v1101 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1111 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1106 : string = "\u001b[91m"
            v1106
        | US0_1 -> (* Debug *)
            let v1103 : string = "\u001b[94m"
            v1103
        | US0_2 -> (* Info *)
            let v1104 : string = "\u001b[92m"
            v1104
        | US0_0 -> (* Verbose *)
            let v1102 : string = "\u001b[90m"
            v1102
        | US0_3 -> (* Warning *)
            let v1105 : string = "\u001b[93m"
            v1105
    let v1112 : string = method8()
    let v1113 : string = v1111 + v997 
    let v1114 : string = v1113 + v1112 
    v1114 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1124 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1119 : string = "\u001b[91m"
            v1119
        | US0_1 -> (* Debug *)
            let v1116 : string = "\u001b[94m"
            v1116
        | US0_2 -> (* Info *)
            let v1117 : string = "\u001b[92m"
            v1117
        | US0_0 -> (* Verbose *)
            let v1115 : string = "\u001b[90m"
            v1115
        | US0_3 -> (* Warning *)
            let v1118 : string = "\u001b[93m"
            v1118
    let v1125 : string = method8()
    let v1126 : string = v1124 + v997 
    let v1127 : string = v1126 + v1125 
    v1127 
    #endif
#else
    let v1137 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v1132 : string = "\u001b[91m"
            v1132
        | US0_1 -> (* Debug *)
            let v1129 : string = "\u001b[94m"
            v1129
        | US0_2 -> (* Info *)
            let v1130 : string = "\u001b[92m"
            v1130
        | US0_0 -> (* Verbose *)
            let v1128 : string = "\u001b[90m"
            v1128
        | US0_3 -> (* Warning *)
            let v1131 : string = "\u001b[93m"
            v1131
    let v1138 : string = method8()
    let v1139 : string = v1137 + v997 
    let v1140 : string = v1139 + v1138 
    v1140 
    #endif
    |> fun x -> _v1029 <- Some x
    let v1141 : string = match _v1029 with Some x -> x | None -> failwith "base.run_target / _v1029=None"
    let v1160 : int64 = v14.l0
    let v1161 : string = v2 ()
    let v1162 : string = ""
    let v1163 : Mut4 = {l0 = v1162} : Mut4
    method9(v1163, v1161)
    let v1164 : string = v1163.l0
    let v1167 : string = $"{v772} {v1141} #{v1160} %s{v1 ()} / {v1164}"
    let v1174 : char list = []
    let v1179 : (char list -> (char [])) = List.toArray
    let v1180 : (char []) = v1179 v1174
    let v1187 : string = v1167.TrimStart v1180 
    let v1226 : char list = []
    let v1229 : char list = '/' :: v1226 
    let v1238 : char list = ' ' :: v1229 
    let v1249 : (char list -> (char [])) = List.toArray
    let v1250 : (char []) = v1249 v1238
    let v1257 : string = v1187.TrimEnd v1250 
    v1257
and method10 (v0 : US0, v1 : (unit -> string)) : unit =
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
        let v84 : string = @"println!(""{}"", $0)"
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
and method4 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure5(v0, v1, v2)
    method10(v0, v3)
and closure4 (v0 : US0, v1 : (unit -> string)) (v2 : (unit -> string)) : unit =
    method4(v0, v1, v2)
and closure3 (v0 : US0) (v1 : (unit -> string)) : ((unit -> string) -> unit) =
    closure4(v0, v1)
and closure2 () (v0 : US0) : ((unit -> string) -> ((unit -> string) -> unit)) =
    closure3(v0)
let v44 : (US0 -> struct (Mut0 * Mut1 * Mut2 * Mut3 * int64 option)) = closure0()
let v45 : US0 = US0_0
if State.trace_state.IsNone then State.trace_state <- v44 v45 |> Some
let v51 : (US0 -> ((unit -> string) -> ((unit -> string) -> unit))) = closure2()
let trace x = v51 x
()
