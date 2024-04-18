#if FABLE_COMPILER // runtime.types
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>] type Send<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>] type ActionFn2<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>] type Mut<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>] type StaticRef<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>] type MutCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>] type std_any_Any = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>] type std_cell_RefCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>] type std_rc_Weak<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>] type base64_DecodeError = class end
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>] type borsh_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>] type js_sys_JsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>] type serde_json_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>] type serde_wasm_bindgen_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>] type std_ffi_OsStr = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>] type std_ffi_OsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>] type std_str_Utf8Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>] type clap_Arg = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>] type clap_Command = class end
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>] type clap_ArgMatches = class end
#endif // runtime.types
module State = let mutable trace_state = None
#if FABLE_COMPILER
[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module System =
 module Diagnostics =
  type Process = unit
  type DataReceivedEventArgs = unit
#endif
type Mut0 = {mutable l0 : int64}
and Mut1 = {mutable l0 : bool}
and [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
    | US0_3
    | US0_4
and Mut2 = {mutable l0 : US0}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and [<Struct>] US3 =
    | US3_0
    | US3_1
and [<Struct>] US2 =
    | US2_0
    | US2_1 of f1_0 : US3
    | US2_2
and [<Struct>] US4 =
    | US4_0 of f0_0 : string
    | US4_1
and [<Struct>] US5 =
    | US5_0 of f0_0 : int64
    | US5_1
and [<Struct>] US6 =
    | US6_0 of f0_0 : (struct (bool * string * int32) -> Async<unit>)
    | US6_1
and [<Struct>] US7 =
    | US7_0 of f0_0 : System.Threading.CancellationToken
    | US7_1
let rec method0 (v0 : int64 option) : int64 option =
    v0
and method1 (v0 : int64 option) : int64 option =
    v0
and closure0 () () : struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : Mut1 = {l0 = false} : Mut1
    let v5 : int64 option option = None
    let mutable _v5 = v5
    #if INTERACTIVE || !FABLE_COMPILER
    let v6 : string option = None
    let v7 : bool = true in let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : string = null |> unbox<string>
    v8
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : string = null |> unbox<string>
    v9
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : string = null |> unbox<string>
    v10
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v11
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v12 : string = null |> unbox<string>
    v12
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v13 : string = Unchecked.defaultof<string>
    v13
#endif
    |> fun x -> _v6 <- Some x
    let v14 : string = _v6.Value
    let v16 : bool = v14 = "Microsoft.DotNet.Interactive.App"
    let v17 : bool = v16 <> true
    let v23 : US1 =
        if v17 then
            let v18 : System.DateTime = System.DateTime.Now
            let v19 : (System.DateTime -> int64) = _.Ticks
            let v20 : int64 = v19 v18
            US1_0(v20)
        else
            US1_1
    let v28 : int64 option =
        match v23 with
        | US1_1 -> (* None *)
            let v26 : int64 option = None
            v26
        | US1_0(v24) -> (* Some *)
            let v25 : int64 option = Some v24 
            v25
    let v29 : int64 option = method0(v28)
    v29 
    #else
    let v30 : int64 option = None
    let v31 : int64 option = method1(v30)
    v31 
    #endif
    |> fun x -> _v5 <- Some x
    let v32 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v32)
and closure1 () () : bool =
    let v0 : bool option = None
    let v1 : bool = true in let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    v2
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : bool = null |> unbox<bool>
    v3
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : bool = null |> unbox<bool>
    v4
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v6 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v7 : bool = v6 v5
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : bool = null |> unbox<bool>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : bool = Unchecked.defaultof<bool>
    v9
#endif
    |> fun x -> _v0 <- Some x
    let v10 : bool = _v0.Value
    v10
and closure2 () () : string =
    let v0 : bool option = None
    let v1 : bool = true in let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : bool = null |> unbox<bool>
    v2
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : bool = null |> unbox<bool>
    v3
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : bool = null |> unbox<bool>
    v4
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v6 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v7 : bool = v6 v5
    v7
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v8 : bool = null |> unbox<bool>
    v8
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v9 : bool = Unchecked.defaultof<bool>
    v9
#endif
    |> fun x -> _v0 <- Some x
    let v10 : bool = _v0.Value
    if v10 then
        let v11 : string = ".exe"
        v11
    else
        let v12 : string = ""
        v12
and method2 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and closure5 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure4 () (v0 : char) : (UH0 -> UH0) =
    closure5(v0)
and method3 () : (char -> (UH0 -> UH0)) =
    closure4()
and method4 (v0 : string, v1 : string, v2 : UH0, v3 : US2) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US3 = US3_0
                let v10 : US2 = US2_1(v9)
                method4(v0, v1, v5, v10)
            else
                match v3 with
                | US2_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US2 = US2_2
                    method4(v38, v1, v5, v39)
                | US2_1(v13) -> (* Path *)
                    match v13 with
                    | US3_0 -> (* Quoted *)
                        let v14 : US3 = US3_1
                        let v15 : US2 = US2_1(v14)
                        method4(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US2 = US2_2
                            method4(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method4(v0, v22, v5, v3)
                | US2_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US2 = US2_2
                        method4(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method4(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US3 = US3_0
                    let v54 : US2 = US2_1(v53)
                    method4(v0, v1, v5, v54)
                else
                    match v3 with
                    | US2_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US2 = US2_2
                        method4(v82, v1, v5, v83)
                    | US2_1(v57) -> (* Path *)
                        match v57 with
                        | US3_0 -> (* Quoted *)
                            let v58 : US3 = US3_1
                            let v59 : US2 = US2_1(v58)
                            method4(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US2 = US2_2
                                method4(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method4(v0, v66, v5, v3)
                    | US2_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US2 = US2_2
                            method4(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method4(v0, v77, v5, v3)
            else
                match v3 with
                | US2_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US2 = US2_2
                    method4(v126, v1, v5, v127)
                | US2_1(v94) -> (* Path *)
                    match v94 with
                    | US3_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US3 = US3_0
                            let v98 : US2 = US2_1(v97)
                            method4(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method4(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US2 = US2_2
                            method4(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method4(v0, v110, v5, v3)
                | US2_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US2 = US2_2
                        method4(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method4(v0, v121, v5, v3)
    | _ ->
        match v3 with
        | US2_2 -> (* Arguments *)
            let v152 : string = "\\"
            let v153 : string = "/"
            let v154 : string = v1.Replace (v152, v153)
            struct (v154, v0)
        | US2_1(v140) -> (* Path *)
            match v140 with
            | US3_0 -> (* Quoted *)
                let v141 : string = "\\"
                let v142 : string = "/"
                let v143 : string = v1.Replace (v141, v142)
                struct (v143, v0)
            | _ ->
                let v144 : string = "\\"
                let v145 : string = "/"
                let v146 : string = v1.Replace (v144, v145)
                struct (v146, v0)
        | US2_0 -> (* Start *)
            let v149 : string = "\\"
            let v150 : string = "/"
            let v151 : string = v1.Replace (v149, v150)
            struct (v151, v0)
and closure6 () (v0 : string) : US4 =
    US4_0(v0)
and method5 () : (string -> US4) =
    closure6()
and closure7 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option) () : string =
    let v4 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3)}"
    v4
and closure8 () () : string =
    let v0 : string = ""
    v0
and method6 () : (unit -> string) =
    closure8()
and closure10 () (v0 : int64) : US5 =
    US5_0(v0)
and method8 () : (int64 -> US5) =
    closure10()
and method9 () : string =
    let v0 : string = ""
    v0
and closure9 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US5) = method8()
    let v12 : US5 = US5_1
    let v13 : US5 = v8 |> Option.map v11 |> Option.defaultValue v12 
    let v31 : System.DateTime =
        match v13 with
        | US5_1 -> (* None *)
            let v29 : System.DateTime = System.DateTime.Now
            v29
        | US5_0(v14) -> (* Some *)
            let v15 : System.DateTime = System.DateTime.Now
            let v16 : (System.DateTime -> int64) = _.Ticks
            let v17 : int64 = v16 v15
            let v18 : int64 = v17 - v14
            let v19 : System.TimeSpan = System.TimeSpan v18 
            let v20 : (System.TimeSpan -> int32) = _.Hours
            let v21 : int32 = v20 v19
            let v22 : (System.TimeSpan -> int32) = _.Minutes
            let v23 : int32 = v22 v19
            let v24 : (System.TimeSpan -> int32) = _.Seconds
            let v25 : int32 = v24 v19
            let v26 : (System.TimeSpan -> int32) = _.Milliseconds
            let v27 : int32 = v26 v19
            let v28 : System.DateTime = System.DateTime (1, 1, 1, v21, v23, v25, v27)
            v28
    let v32 : string = "hh:mm:ss"
    let v33 : string = v31.ToString v32 
    v33
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v34 : string = method9()
    v34
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method9()
    v35
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (int64 -> US5) = method8()
    let v37 : US5 = US5_1
    let v38 : US5 = v8 |> Option.map v36 |> Option.defaultValue v37 
    let v56 : System.DateTime =
        match v38 with
        | US5_1 -> (* None *)
            let v54 : System.DateTime = System.DateTime.Now
            v54
        | US5_0(v39) -> (* Some *)
            let v40 : System.DateTime = System.DateTime.Now
            let v41 : (System.DateTime -> int64) = _.Ticks
            let v42 : int64 = v41 v40
            let v43 : int64 = v42 - v39
            let v44 : System.TimeSpan = System.TimeSpan v43 
            let v45 : (System.TimeSpan -> int32) = _.Hours
            let v46 : int32 = v45 v44
            let v47 : (System.TimeSpan -> int32) = _.Minutes
            let v48 : int32 = v47 v44
            let v49 : (System.TimeSpan -> int32) = _.Seconds
            let v50 : int32 = v49 v44
            let v51 : (System.TimeSpan -> int32) = _.Milliseconds
            let v52 : int32 = v51 v44
            let v53 : System.DateTime = System.DateTime (1, 1, 1, v46, v48, v50, v52)
            v53
    let v57 : string = "HH:mm:ss"
    let v58 : string = v56.ToString v57 
    v58
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v59 : string = method9()
    v59
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v60 : string = Unchecked.defaultof<string>
    v60
#endif
    |> fun x -> _v9 <- Some x
    let v61 : string = _v9.Value
    let v62 : int64 = v4.l0
    let v72 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v67 : string = "Critical"
            v67
        | US0_1 -> (* Debug *)
            let v64 : string = "Debug"
            v64
        | US0_2 -> (* Info *)
            let v65 : string = "Info"
            v65
        | US0_0 -> (* Verbose *)
            let v63 : string = "Verbose"
            v63
        | US0_3 -> (* Warning *)
            let v66 : string = "Warning"
            v66
    let v73 : string = v72.ToLower ()
    let v74 : string option = None
    let v75 : bool = true in let mutable _v74 = v74
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v90 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v84 : string = "inline_colorization::color_bright_red"
            let v85 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v84
            v85
        | US0_1 -> (* Debug *)
            let v78 : string = "inline_colorization::color_bright_blue"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US0_2 -> (* Info *)
            let v80 : string = "inline_colorization::color_bright_green"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
        | US0_0 -> (* Verbose *)
            let v76 : string = "inline_colorization::color_bright_black"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US0_3 -> (* Warning *)
            let v82 : string = "inline_colorization::color_bright_yellow"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
    let v91 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v91
    let v93 : string = "inline_colorization::color_reset"
    let v94 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v93
    let v95 : string = "\"{v90}{v92}{v94}\""
    let v96 : string = @$"format!(" + v95 + ")"
    let v97 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v96
    let v98 : string = "fable_library_rust::String_::fromString($0)"
    let v99 : string = Fable.Core.RustInterop.emitRustExpr v97 v98
    v99
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v114 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v108 : string = "inline_colorization::color_bright_red"
            let v109 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v108
            v109
        | US0_1 -> (* Debug *)
            let v102 : string = "inline_colorization::color_bright_blue"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US0_2 -> (* Info *)
            let v104 : string = "inline_colorization::color_bright_green"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
        | US0_0 -> (* Verbose *)
            let v100 : string = "inline_colorization::color_bright_black"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US0_3 -> (* Warning *)
            let v106 : string = "inline_colorization::color_bright_yellow"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
    let v115 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v115
    let v117 : string = "inline_colorization::color_reset"
    let v118 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v117
    let v119 : string = "\"{v114}{v116}{v118}\""
    let v120 : string = @$"format!(" + v119 + ")"
    let v121 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v120
    let v122 : string = "fable_library_rust::String_::fromString($0)"
    let v123 : string = Fable.Core.RustInterop.emitRustExpr v121 v122
    v123
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v138 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v132 : string = "inline_colorization::color_bright_red"
            let v133 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v132
            v133
        | US0_1 -> (* Debug *)
            let v126 : string = "inline_colorization::color_bright_blue"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US0_2 -> (* Info *)
            let v128 : string = "inline_colorization::color_bright_green"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
        | US0_0 -> (* Verbose *)
            let v124 : string = "inline_colorization::color_bright_black"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US0_3 -> (* Warning *)
            let v130 : string = "inline_colorization::color_bright_yellow"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
    let v139 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v73 v139
    let v141 : string = "inline_colorization::color_reset"
    let v142 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v141
    let v143 : string = "\"{v138}{v140}{v142}\""
    let v144 : string = @$"format!(" + v143 + ")"
    let v145 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v144
    let v146 : string = "fable_library_rust::String_::fromString($0)"
    let v147 : string = Fable.Core.RustInterop.emitRustExpr v145 v146
    v147
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v73
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    v73
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v148 : string = Unchecked.defaultof<string>
    v148
#endif
    |> fun x -> _v74 <- Some x
    let v149 : string = _v74.Value
    let v150 : string = $"{v61} {v149} #{v62} %s{v1 ()} / %s{v2 ()}"
    let v151 : (char []) = [||]
    let v152 : string = v150.TrimStart v151
    let v153 : (char []) = [|' '; '/'|]
    let v154 : string = v152.TrimEnd v153
    v154
and method7 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut1, v7 : Mut2, v8 : int64 option) = State.trace_state.Value
    if State.trace_state = None then State.trace_state <- v3 () |> Some
    let struct (v9 : Mut0, v10 : Mut1, v11 : Mut1, v12 : Mut2, v13 : int64 option) = State.trace_state.Value
    let v14 : US0 = v12.l0
    let v15 : bool = v11.l0
    let v17 : bool =
        if v15 then
            let v16 : bool = v0 >= v14 
            v16
        else
            false
    if v17 then
        let v18 : int64 = v4.l0
        let v19 : int64 = v18 + 1L
        v4.l0 <- v19
        let v20 : (unit -> string) = closure9(v0, v1, v2)
        let v21 : string = $"%s{v20 ()}"
        let v22 : unit option = None
        let v23 : bool = true in let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        ()
#endif
        #if FABLE_COMPILER_RUST && WASM
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
        ()
#endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v26
        ()
#endif
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        System.Console.WriteLine v21 
        ()
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v21 
        ()
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        ()
#endif
        |> fun x -> _v22 <- Some x
        _v22.Value
        ()
and closure12 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US6 =
    US6_0(v0)
and method10 () : ((struct (bool * string * int32) -> Async<unit>) -> US6) =
    closure12()
and closure13 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure11 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v7 : Async<unit> option = None
    let v8 : bool = true in let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method10()
        let v18 : US6 = US6_1
        let v19 : US6 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US6_1 -> (* None *)
            ()
        | US6_0(v20) -> (* Some *)
            let v21 : int32 = v4.Id
            let v22 : Async<unit> = v20 struct (false, v13, v21)
            do! v22 
            ()
        let v23 : US0 = US0_0
        let v24 : (unit -> string) = closure13(v13)
        let v25 : (unit -> string) = closure8()
        method7(v23, v24, v25)
        let v26 : string = ""
        let v27 : string = $"{v26}{v13}{v26}"
        let v28 : (string -> unit) = v5.Push
        v28 v27
    }
    |> fun x -> _v12 <- Some x
    let v29 : Async<unit> = _v12 |> Option.get
    v29
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<unit> = null |> unbox<Async<unit>>
    v30
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v31 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v31
#endif
    |> fun x -> _v7 <- Some x
    let v32 : Async<unit> = _v7.Value
    let v33 : unit option = None
    let v34 : bool = true in let mutable _v33 = v33
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (Async<unit> -> unit) = Async.StartImmediate
    v35 v32
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v33 <- Some x
    _v33.Value
    ()
and closure14 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v7 : Async<unit> option = None
    let v8 : bool = true in let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<unit> = null |> unbox<Async<unit>>
    v11
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method10()
        let v18 : US6 = US6_1
        let v19 : US6 = v2 |> Option.map v17 |> Option.defaultValue v18 
        match v19 with
        | US6_1 -> (* None *)
            ()
        | US6_0(v20) -> (* Some *)
            let v21 : int32 = v4.Id
            let v22 : Async<unit> = v20 struct (true, v13, v21)
            do! v22 
            ()
        let v23 : US0 = US0_0
        let v24 : (unit -> string) = closure13(v13)
        let v25 : (unit -> string) = closure8()
        method7(v23, v24, v25)
        let v26 : string = "["
        let v27 : string = "]"
        let v28 : string = $"{v26}{v13}{v27}"
        let v29 : (string -> unit) = v5.Push
        v29 v28
    }
    |> fun x -> _v12 <- Some x
    let v30 : Async<unit> = _v12 |> Option.get
    v30
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v31 : Async<unit> = null |> unbox<Async<unit>>
    v31
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v32 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v32
#endif
    |> fun x -> _v7 <- Some x
    let v33 : Async<unit> = _v7.Value
    let v34 : unit option = None
    let v35 : bool = true in let mutable _v34 = v34
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v36 : (Async<unit> -> unit) = Async.StartImmediate
    v36 v33
    ()
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    ()
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    ()
#endif
    |> fun x -> _v34 <- Some x
    _v34.Value
    ()
and closure15 () (v0 : System.Threading.CancellationToken) : US7 =
    US7_0(v0)
and method11 () : (System.Threading.CancellationToken -> US7) =
    closure15()
and closure16 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : bool = null |> unbox<bool>
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : bool = null |> unbox<bool>
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : bool = v0.HasExited
    v6
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : bool = null |> unbox<bool>
    v7
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : bool = Unchecked.defaultof<bool>
    v8
#endif
    |> fun x -> _v1 <- Some x
    let v9 : bool = _v1.Value
    let v10 : bool = v9 = false
    if v10 then
        let v11 : unit option = None
        let v12 : bool = true in let mutable _v11 = v11
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
        #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
        let v13 : (unit -> unit) = v0.Kill
        v13 ()
        ()
#endif
        #if FABLE_COMPILER_TYPESCRIPT
        null |> unbox<unit>
        ()
#endif
        #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
        Unchecked.defaultof<unit>
        ()
#endif
        |> fun x -> _v11 <- Some x
        _v11.Value
        ()
and closure17 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and method12 () : string =
    let v0 : string = "\n"
    v0
and closure18 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and closure3 () (v0 : string) : Async<struct (int32 * string)> =
    let v1 : System.Threading.CancellationToken option = None
    let v2 : (struct (bool * string * int32) -> Async<unit>) option = None
    let v3 : string option = None
    let v4 : Async<struct (int32 * string)> option = None
    let v5 : bool = true in let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v6
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<struct (int32 * string)> option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v13
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> option = None
    let mutable _v14 = v14
    async {
    let struct (v15 : string, v16 : string) = method2()
    let v17 : char seq = v0 |> unbox<char seq>
    let v18 : (char seq -> char list) = Seq.toList
    let v19 : char list = v18 v17
    let v20 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v21 : (char -> (UH0 -> UH0)) = method3()
    let v22 : (char list -> (UH0 -> UH0)) = v20 v21
    let v23 : (UH0 -> UH0) = v22 v19
    let v24 : UH0 = UH0_0
    let v25 : UH0 = v23 v24
    let v26 : US2 = US2_0
    let struct (v27 : string, v28 : string) = method4(v16, v15, v25, v26)
    let v29 : (string -> US4) = method5()
    let v30 : US4 = US4_1
    let v31 : US4 = v3 |> Option.map v29 |> Option.defaultValue v30 
    let v35 : string =
        match v31 with
        | US4_1 -> (* None *)
            let v33 : string = ""
            v33
        | US4_0(v32) -> (* Some *)
            v32
    let v36 : US0 = US0_1
    let v37 : (unit -> string) = closure7(v1, v0, v2, v3)
    let v38 : (unit -> string) = method6()
    method7(v36, v37, v38)
    let v39 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v40 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v28, StandardOutputEncoding = v39, WorkingDirectory = v35, FileName = v27, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v41 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v40)
    use v41 = v41 
    let v42 : System.Diagnostics.Process = v41 
    let v43 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v44 : System.Collections.Concurrent.ConcurrentStack<string> = v43 ()
    let v45 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure11(v1, v0, v2, v3, v42, v44)
    v42.OutputDataReceived.Add v45 
    let v46 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v1, v0, v2, v3, v42, v44)
    v42.ErrorDataReceived.Add v46 
    let v47 : (unit -> bool) = v42.Start
    let v48 : bool = v47 ()
    let v49 : bool = v48 = false
    if v49 then
        let v50 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v50
    let v51 : (unit -> unit) = v42.BeginErrorReadLine
    v51 ()
    let v52 : (unit -> unit) = v42.BeginOutputReadLine
    v52 ()
    let v53 : (System.Threading.CancellationToken -> US7) = method11()
    let v54 : US7 = US7_1
    let v55 : US7 = v1 |> Option.map v53 |> Option.defaultValue v54 
    let v59 : System.Threading.CancellationToken =
        match v55 with
        | US7_1 -> (* None *)
            let v57 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v57
        | US7_0(v56) -> (* Some *)
            v56
    let v60 : Async<System.Threading.CancellationToken> option = None
    let v61 : bool = true in let mutable _v60 = v60
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v62
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v63 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v63
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v64 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v64
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v65 : Async<System.Threading.CancellationToken> option = None
    let v66 : bool = true in let mutable _v65 = v65
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v67
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v68 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v68
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v69 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v69
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v70 : Async<System.Threading.CancellationToken> option = None
    let mutable _v70 = v70
    async {
    let v71 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v71 = v71 
    let v72 : System.Threading.CancellationToken = v71 
    let v73 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v74 : (System.Threading.CancellationToken []) = [|v72; v73; v59|]
    let v75 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v76 : System.Threading.CancellationTokenSource = v75 v74
    let v77 : System.Threading.CancellationToken = v76.Token
    return v77 
    }
    |> fun x -> _v70 <- Some x
    let v78 : Async<System.Threading.CancellationToken> = _v70 |> Option.get
    v78
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v79 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v79
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v80 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v80
#endif
    |> fun x -> _v65 <- Some x
    let v81 : Async<System.Threading.CancellationToken> = _v65.Value
    v81
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v82 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v82
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v83 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v83
#endif
    |> fun x -> _v60 <- Some x
    let v84 : Async<System.Threading.CancellationToken> = _v60.Value
    let! v84 = v84 
    let v85 : System.Threading.CancellationToken = v84 
    let v86 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v85.Register
    let v87 : (unit -> unit) = closure16(v42)
    let v88 : System.Threading.CancellationTokenRegistration = v86 v87
    use v88 = v88 
    let v89 : System.Threading.CancellationTokenRegistration = v88 
    let v90 : Async<int32> option = None
    let v91 : bool = true in let mutable _v90 = v90
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v92 : Async<int32> = null |> unbox<Async<int32>>
    v92
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v93 : Async<int32> = null |> unbox<Async<int32>>
    v93
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v94 : Async<int32> = null |> unbox<Async<int32>>
    v94
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v95 : Async<int32> option = None
    let mutable _v95 = v95
    async {
    try
    let v96 : System.Threading.Tasks.Task = v42.WaitForExitAsync v85 
    let v97 : Async<unit> option = None
    let v98 : bool = true in let mutable _v97 = v97
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : Async<unit> = null |> unbox<Async<unit>>
    v99
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v100 : Async<unit> = null |> unbox<Async<unit>>
    v100
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v101 : Async<unit> = null |> unbox<Async<unit>>
    v101
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v102 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v103 : Async<unit> = v102 v96
    v103
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v104 : Async<unit> = null |> unbox<Async<unit>>
    v104
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v105 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v105
#endif
    |> fun x -> _v97 <- Some x
    let v106 : Async<unit> = _v97.Value
    do! v106 
    let v107 : int32 = v42.ExitCode
    return v107 
    with ex ->
    let v108 : exn = ex
    let v109 : string option = None
    let v110 : bool = true in let mutable _v109 = v109
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = $"%A{v108}"
    v111
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v112 : string = $"%A{v108}"
    v112
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v113 : string = $"%A{v108}"
    v113
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v114 : string = $"{v108.GetType ()}: {v108.Message}"
    v114
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v115 : string = $"%A{v108}"
    v115
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v116 : string = Unchecked.defaultof<string>
    v116
#endif
    |> fun x -> _v109 <- Some x
    let v117 : string = _v109.Value
    let v118 : (string -> unit) = v44.Push
    v118 v117
    let v119 : System.Threading.Tasks.TaskCanceledException = v108 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v120 : US0 = US0_3
    let v121 : (unit -> string) = closure17(v119)
    let v122 : (unit -> string) = method6()
    method7(v120, v121, v122)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v95 <- Some x
    let v123 : Async<int32> = _v95 |> Option.get
    v123
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v124 : Async<int32> = null |> unbox<Async<int32>>
    v124
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v125 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v125
#endif
    |> fun x -> _v90 <- Some x
    let v126 : Async<int32> = _v90.Value
    let! v126 = v126 
    let v127 : int32 = v126 
    let v128 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v129 : string seq = v128 v44
    let v130 : string = method12()
    let v131 : (string -> (string seq -> string)) = String.concat
    let v132 : (string seq -> string) = v131 v130
    let v133 : string = v132 v129
    let v134 : US0 = US0_1
    let v135 : (unit -> string) = closure18(v127, v133)
    let v136 : (unit -> string) = method6()
    method7(v134, v135, v136)
    return struct (v127, v133) 
    }
    |> fun x -> _v14 <- Some x
    let v137 : Async<struct (int32 * string)> = _v14 |> Option.get
    v137
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v138 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v138
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v139 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v139
#endif
    |> fun x -> _v9 <- Some x
    let v140 : Async<struct (int32 * string)> = _v9.Value
    v140
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v141
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v142 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v142
#endif
    |> fun x -> _v4 <- Some x
    let v143 : Async<struct (int32 * string)> = _v4.Value
    v143
and closure19 () struct (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option) : Async<struct (int32 * string)> =
    let v4 : Async<struct (int32 * string)> option = None
    let v5 : bool = true in let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v6
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v8
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<struct (int32 * string)> option = None
    let v10 : bool = true in let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v12 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v12
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v13 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v13
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> option = None
    let mutable _v14 = v14
    async {
    let struct (v15 : string, v16 : string) = method2()
    let v17 : char seq = v1 |> unbox<char seq>
    let v18 : (char seq -> char list) = Seq.toList
    let v19 : char list = v18 v17
    let v20 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v21 : (char -> (UH0 -> UH0)) = method3()
    let v22 : (char list -> (UH0 -> UH0)) = v20 v21
    let v23 : (UH0 -> UH0) = v22 v19
    let v24 : UH0 = UH0_0
    let v25 : UH0 = v23 v24
    let v26 : US2 = US2_0
    let struct (v27 : string, v28 : string) = method4(v16, v15, v25, v26)
    let v29 : (string -> US4) = method5()
    let v30 : US4 = US4_1
    let v31 : US4 = v3 |> Option.map v29 |> Option.defaultValue v30 
    let v35 : string =
        match v31 with
        | US4_1 -> (* None *)
            let v33 : string = ""
            v33
        | US4_0(v32) -> (* Some *)
            v32
    let v36 : US0 = US0_1
    let v37 : (unit -> string) = closure7(v0, v1, v2, v3)
    let v38 : (unit -> string) = method6()
    method7(v36, v37, v38)
    let v39 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v40 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v28, StandardOutputEncoding = v39, WorkingDirectory = v35, FileName = v27, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v41 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v40)
    use v41 = v41 
    let v42 : System.Diagnostics.Process = v41 
    let v43 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v44 : System.Collections.Concurrent.ConcurrentStack<string> = v43 ()
    let v45 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure11(v0, v1, v2, v3, v42, v44)
    v42.OutputDataReceived.Add v45 
    let v46 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v0, v1, v2, v3, v42, v44)
    v42.ErrorDataReceived.Add v46 
    let v47 : (unit -> bool) = v42.Start
    let v48 : bool = v47 ()
    let v49 : bool = v48 = false
    if v49 then
        let v50 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v50
    let v51 : (unit -> unit) = v42.BeginErrorReadLine
    v51 ()
    let v52 : (unit -> unit) = v42.BeginOutputReadLine
    v52 ()
    let v53 : (System.Threading.CancellationToken -> US7) = method11()
    let v54 : US7 = US7_1
    let v55 : US7 = v0 |> Option.map v53 |> Option.defaultValue v54 
    let v59 : System.Threading.CancellationToken =
        match v55 with
        | US7_1 -> (* None *)
            let v57 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v57
        | US7_0(v56) -> (* Some *)
            v56
    let v60 : Async<System.Threading.CancellationToken> option = None
    let v61 : bool = true in let mutable _v60 = v60
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v62 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v62
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v63 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v63
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v64 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v64
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v65 : Async<System.Threading.CancellationToken> option = None
    let v66 : bool = true in let mutable _v65 = v65
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v67 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v67
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v68 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v68
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v69 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v69
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v70 : Async<System.Threading.CancellationToken> option = None
    let mutable _v70 = v70
    async {
    let v71 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v71 = v71 
    let v72 : System.Threading.CancellationToken = v71 
    let v73 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v74 : (System.Threading.CancellationToken []) = [|v72; v73; v59|]
    let v75 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v76 : System.Threading.CancellationTokenSource = v75 v74
    let v77 : System.Threading.CancellationToken = v76.Token
    return v77 
    }
    |> fun x -> _v70 <- Some x
    let v78 : Async<System.Threading.CancellationToken> = _v70 |> Option.get
    v78
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v79 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v79
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v80 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v80
#endif
    |> fun x -> _v65 <- Some x
    let v81 : Async<System.Threading.CancellationToken> = _v65.Value
    v81
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v82 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v82
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v83 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v83
#endif
    |> fun x -> _v60 <- Some x
    let v84 : Async<System.Threading.CancellationToken> = _v60.Value
    let! v84 = v84 
    let v85 : System.Threading.CancellationToken = v84 
    let v86 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v85.Register
    let v87 : (unit -> unit) = closure16(v42)
    let v88 : System.Threading.CancellationTokenRegistration = v86 v87
    use v88 = v88 
    let v89 : System.Threading.CancellationTokenRegistration = v88 
    let v90 : Async<int32> option = None
    let v91 : bool = true in let mutable _v90 = v90
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v92 : Async<int32> = null |> unbox<Async<int32>>
    v92
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v93 : Async<int32> = null |> unbox<Async<int32>>
    v93
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v94 : Async<int32> = null |> unbox<Async<int32>>
    v94
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v95 : Async<int32> option = None
    let mutable _v95 = v95
    async {
    try
    let v96 : System.Threading.Tasks.Task = v42.WaitForExitAsync v85 
    let v97 : Async<unit> option = None
    let v98 : bool = true in let mutable _v97 = v97
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v99 : Async<unit> = null |> unbox<Async<unit>>
    v99
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v100 : Async<unit> = null |> unbox<Async<unit>>
    v100
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v101 : Async<unit> = null |> unbox<Async<unit>>
    v101
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v102 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v103 : Async<unit> = v102 v96
    v103
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v104 : Async<unit> = null |> unbox<Async<unit>>
    v104
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v105 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v105
#endif
    |> fun x -> _v97 <- Some x
    let v106 : Async<unit> = _v97.Value
    do! v106 
    let v107 : int32 = v42.ExitCode
    return v107 
    with ex ->
    let v108 : exn = ex
    let v109 : string option = None
    let v110 : bool = true in let mutable _v109 = v109
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v111 : string = $"%A{v108}"
    v111
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v112 : string = $"%A{v108}"
    v112
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v113 : string = $"%A{v108}"
    v113
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v114 : string = $"{v108.GetType ()}: {v108.Message}"
    v114
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v115 : string = $"%A{v108}"
    v115
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v116 : string = Unchecked.defaultof<string>
    v116
#endif
    |> fun x -> _v109 <- Some x
    let v117 : string = _v109.Value
    let v118 : (string -> unit) = v44.Push
    v118 v117
    let v119 : System.Threading.Tasks.TaskCanceledException = v108 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v120 : US0 = US0_3
    let v121 : (unit -> string) = closure17(v119)
    let v122 : (unit -> string) = method6()
    method7(v120, v121, v122)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v95 <- Some x
    let v123 : Async<int32> = _v95 |> Option.get
    v123
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v124 : Async<int32> = null |> unbox<Async<int32>>
    v124
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v125 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v125
#endif
    |> fun x -> _v90 <- Some x
    let v126 : Async<int32> = _v90.Value
    let! v126 = v126 
    let v127 : int32 = v126 
    let v128 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v129 : string seq = v128 v44
    let v130 : string = method12()
    let v131 : (string -> (string seq -> string)) = String.concat
    let v132 : (string seq -> string) = v131 v130
    let v133 : string = v132 v129
    let v134 : US0 = US0_1
    let v135 : (unit -> string) = closure18(v127, v133)
    let v136 : (unit -> string) = method6()
    method7(v134, v135, v136)
    return struct (v127, v133) 
    }
    |> fun x -> _v14 <- Some x
    let v137 : Async<struct (int32 * string)> = _v14 |> Option.get
    v137
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v138 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v138
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v139 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v139
#endif
    |> fun x -> _v9 <- Some x
    let v140 : Async<struct (int32 * string)> = _v9.Value
    v140
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v141 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v141
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v142 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v142
#endif
    |> fun x -> _v4 <- Some x
    let v143 : Async<struct (int32 * string)> = _v4.Value
    v143
let v0 : (unit -> struct (Mut0 * Mut1 * Mut1 * Mut2 * int64 option)) = closure0()
if State.trace_state = None then State.trace_state <- v0 () |> Some
let v1 : (unit -> bool) = closure1()
let is_windows () = v1 ()
let v2 : (unit -> string) = closure2()
let get_executable_suffix () = v2 ()
let v3 : (string -> Async<struct (int32 * string)>) = closure3()
let execute_async x = v3 x
let v4 : (struct (System.Threading.CancellationToken option * string * (struct (bool * string * int32) -> Async<unit>) option * string option) -> Async<struct (int32 * string)>) = closure19()
let execute_with_options_async x = v4 x
()
