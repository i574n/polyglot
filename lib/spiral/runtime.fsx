#if FABLE_COMPILER // runtime.types
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
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
    let mutable _v6 = v6
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = null |> unbox<string>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v8 : string = null |> unbox<string>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v9 : string = null |> unbox<string>
    v9 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v10 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v10 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = null |> unbox<string>
    v11 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v12 : string = Unchecked.defaultof<string>
    v12 
    #endif
    |> fun x -> _v6 <- Some x
    let v13 : string = _v6.Value
    let v15 : bool = v13 = "Microsoft.DotNet.Interactive.App"
    let v16 : bool = v15 <> true
    let v22 : US1 =
        if v16 then
            let v17 : System.DateTime = System.DateTime.Now
            let v18 : (System.DateTime -> int64) = _.Ticks
            let v19 : int64 = v18 v17
            US1_0(v19)
        else
            US1_1
    let v27 : int64 option =
        match v22 with
        | US1_1 -> (* None *)
            let v25 : int64 option = None
            v25
        | US1_0(v23) -> (* Some *)
            let v24 : int64 option = Some v23 
            v24
    let v28 : int64 option = method0(v27)
    v28 
    #else
    let v29 : int64 option = None
    let v30 : int64 option = method1(v29)
    v30 
    #endif
    |> fun x -> _v5 <- Some x
    let v31 : int64 option = _v5.Value
    struct (v1, v4, v0, v3, v31)
and closure1 () () : bool =
    let v0 : bool option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : bool = null |> unbox<bool>
    v1 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v4 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v5 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v6 : bool = v5 v4
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
    |> fun x -> _v0 <- Some x
    let v9 : bool = _v0.Value
    v9
and closure2 () () : string =
    let v0 : bool option = None
    let mutable _v0 = v0
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : bool = null |> unbox<bool>
    v1 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : bool = null |> unbox<bool>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v3 : bool = null |> unbox<bool>
    v3 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v4 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v5 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v6 : bool = v5 v4
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
    |> fun x -> _v0 <- Some x
    let v9 : bool = _v0.Value
    if v9 then
        let v10 : string = ".exe"
        v10
    else
        let v11 : string = ""
        v11
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
    let mutable _v9 = v9
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : (int64 -> US5) = method8()
    let v11 : US5 = US5_1
    let v12 : US5 = v8 |> Option.map v10 |> Option.defaultValue v11 
    let v30 : System.DateTime =
        match v12 with
        | US5_1 -> (* None *)
            let v28 : System.DateTime = System.DateTime.Now
            v28
        | US5_0(v13) -> (* Some *)
            let v14 : System.DateTime = System.DateTime.Now
            let v15 : (System.DateTime -> int64) = _.Ticks
            let v16 : int64 = v15 v14
            let v17 : int64 = v16 - v13
            let v18 : System.TimeSpan = System.TimeSpan v17 
            let v19 : (System.TimeSpan -> int32) = _.Hours
            let v20 : int32 = v19 v18
            let v21 : (System.TimeSpan -> int32) = _.Minutes
            let v22 : int32 = v21 v18
            let v23 : (System.TimeSpan -> int32) = _.Seconds
            let v24 : int32 = v23 v18
            let v25 : (System.TimeSpan -> int32) = _.Milliseconds
            let v26 : int32 = v25 v18
            let v27 : System.DateTime = System.DateTime (1, 1, 1, v20, v22, v24, v26)
            v27
    let v31 : string = "hh:mm:ss"
    let v32 : string = v30.ToString v31 
    v32 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v33 : string = method9()
    v33 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v34 : string = method9()
    v34 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v35 : (int64 -> US5) = method8()
    let v36 : US5 = US5_1
    let v37 : US5 = v8 |> Option.map v35 |> Option.defaultValue v36 
    let v55 : System.DateTime =
        match v37 with
        | US5_1 -> (* None *)
            let v53 : System.DateTime = System.DateTime.Now
            v53
        | US5_0(v38) -> (* Some *)
            let v39 : System.DateTime = System.DateTime.Now
            let v40 : (System.DateTime -> int64) = _.Ticks
            let v41 : int64 = v40 v39
            let v42 : int64 = v41 - v38
            let v43 : System.TimeSpan = System.TimeSpan v42 
            let v44 : (System.TimeSpan -> int32) = _.Hours
            let v45 : int32 = v44 v43
            let v46 : (System.TimeSpan -> int32) = _.Minutes
            let v47 : int32 = v46 v43
            let v48 : (System.TimeSpan -> int32) = _.Seconds
            let v49 : int32 = v48 v43
            let v50 : (System.TimeSpan -> int32) = _.Milliseconds
            let v51 : int32 = v50 v43
            let v52 : System.DateTime = System.DateTime (1, 1, 1, v45, v47, v49, v51)
            v52
    let v56 : string = "HH:mm:ss"
    let v57 : string = v55.ToString v56 
    v57 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v58 : string = method9()
    v58 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v59 : string = Unchecked.defaultof<string>
    v59 
    #endif
    |> fun x -> _v9 <- Some x
    let v60 : string = _v9.Value
    let v61 : int64 = v4.l0
    let v71 : string =
        match v0 with
        | US0_4 -> (* Critical *)
            let v66 : string = "Critical"
            v66
        | US0_1 -> (* Debug *)
            let v63 : string = "Debug"
            v63
        | US0_2 -> (* Info *)
            let v64 : string = "Info"
            v64
        | US0_0 -> (* Verbose *)
            let v62 : string = "Verbose"
            v62
        | US0_3 -> (* Warning *)
            let v65 : string = "Warning"
            v65
    let v72 : string = v71.ToLower ()
    let v73 : string option = None
    let mutable _v73 = v73
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v82 : string = "inline_colorization::color_bright_red"
            let v83 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v82
            v83
        | US0_1 -> (* Debug *)
            let v76 : string = "inline_colorization::color_bright_blue"
            let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v76
            v77
        | US0_2 -> (* Info *)
            let v78 : string = "inline_colorization::color_bright_green"
            let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v78
            v79
        | US0_0 -> (* Verbose *)
            let v74 : string = "inline_colorization::color_bright_black"
            let v75 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v74
            v75
        | US0_3 -> (* Warning *)
            let v80 : string = "inline_colorization::color_bright_yellow"
            let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v80
            v81
    let v89 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v90 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v89
    let v91 : string = "inline_colorization::color_reset"
    let v92 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v91
    let v93 : string = "\"{v88}{v90}{v92}\""
    let v94 : string = @$"format!(" + v93 + ")"
    let v95 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : string = "fable_library_rust::String_::fromString($0)"
    let v97 : string = Fable.Core.RustInterop.emitRustExpr v95 v96
    v97 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v112 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v106 : string = "inline_colorization::color_bright_red"
            let v107 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v106
            v107
        | US0_1 -> (* Debug *)
            let v100 : string = "inline_colorization::color_bright_blue"
            let v101 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v100
            v101
        | US0_2 -> (* Info *)
            let v102 : string = "inline_colorization::color_bright_green"
            let v103 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v102
            v103
        | US0_0 -> (* Verbose *)
            let v98 : string = "inline_colorization::color_bright_black"
            let v99 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v98
            v99
        | US0_3 -> (* Warning *)
            let v104 : string = "inline_colorization::color_bright_yellow"
            let v105 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v104
            v105
    let v113 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v114 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v113
    let v115 : string = "inline_colorization::color_reset"
    let v116 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v115
    let v117 : string = "\"{v112}{v114}{v116}\""
    let v118 : string = @$"format!(" + v117 + ")"
    let v119 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "fable_library_rust::String_::fromString($0)"
    let v121 : string = Fable.Core.RustInterop.emitRustExpr v119 v120
    v121 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v136 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v130 : string = "inline_colorization::color_bright_red"
            let v131 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v130
            v131
        | US0_1 -> (* Debug *)
            let v124 : string = "inline_colorization::color_bright_blue"
            let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v124
            v125
        | US0_2 -> (* Info *)
            let v126 : string = "inline_colorization::color_bright_green"
            let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v126
            v127
        | US0_0 -> (* Verbose *)
            let v122 : string = "inline_colorization::color_bright_black"
            let v123 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v122
            v123
        | US0_3 -> (* Warning *)
            let v128 : string = "inline_colorization::color_bright_yellow"
            let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v128
            v129
    let v137 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v138 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v72 v137
    let v139 : string = "inline_colorization::color_reset"
    let v140 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v139
    let v141 : string = "\"{v136}{v138}{v140}\""
    let v142 : string = @$"format!(" + v141 + ")"
    let v143 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : string = "fable_library_rust::String_::fromString($0)"
    let v145 : string = Fable.Core.RustInterop.emitRustExpr v143 v144
    v145 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    v72 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    v72 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v146 : string = Unchecked.defaultof<string>
    v146 
    #endif
    |> fun x -> _v73 <- Some x
    let v147 : string = _v73.Value
    let v148 : string = $"{v60} {v147} #{v61} %s{v1 ()} / %s{v2 ()}"
    let v149 : (char []) = [||]
    let v150 : string = v148.TrimStart v149
    let v151 : (char []) = [|' '; '/'|]
    let v152 : string = v150.TrimEnd v151
    v152
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
        let mutable _v22 = v22
        #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v23 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v23
        () 
        #endif
        #if FABLE_COMPILER_RUST && WASM
        let v24 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v24
        () 
        #endif
        #if FABLE_COMPILER_RUST && CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v21 v25
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
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : Async<unit> option = None
    let mutable _v11 = v11
    async {
    let v12 : string = v6.Data
    let v13 : string = null |> unbox<string>
    let v14 : bool = v12 = v13
    let v15 : bool = v14 <> true
    if v15 then
        let v16 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method10()
        let v17 : US6 = US6_1
        let v18 : US6 = v2 |> Option.map v16 |> Option.defaultValue v17 
        match v18 with
        | US6_1 -> (* None *)
            ()
        | US6_0(v19) -> (* Some *)
            let v20 : int32 = v4.Id
            let v21 : Async<unit> = v19 struct (false, v12, v20)
            do! v21 
            ()
        let v22 : US0 = US0_0
        let v23 : (unit -> string) = closure13(v12)
        let v24 : (unit -> string) = closure8()
        method7(v22, v23, v24)
        let v25 : string = ""
        let v26 : string = $"{v25}{v12}{v25}"
        let v27 : (string -> unit) = v5.Push
        v27 v26
    }
    |> fun x -> _v11 <- Some x
    let v28 : Async<unit> = _v11 |> Option.get
    v28 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v29 : Async<unit> = null |> unbox<Async<unit>>
    v29 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v30 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v30 
    #endif
    |> fun x -> _v7 <- Some x
    let v31 : Async<unit> = _v7.Value
    let v32 : unit option = None
    let mutable _v32 = v32
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
    let v33 : (Async<unit> -> unit) = Async.StartImmediate
    v33 v31
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
    |> fun x -> _v32 <- Some x
    _v32.Value
    ()
and closure14 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
    let v7 : Async<unit> option = None
    let mutable _v7 = v7
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<unit> = null |> unbox<Async<unit>>
    v8 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v9 : Async<unit> = null |> unbox<Async<unit>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<unit> = null |> unbox<Async<unit>>
    v10 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : Async<unit> option = None
    let mutable _v11 = v11
    async {
    let v12 : string = v6.Data
    let v13 : string = null |> unbox<string>
    let v14 : bool = v12 = v13
    let v15 : bool = v14 <> true
    if v15 then
        let v16 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method10()
        let v17 : US6 = US6_1
        let v18 : US6 = v2 |> Option.map v16 |> Option.defaultValue v17 
        match v18 with
        | US6_1 -> (* None *)
            ()
        | US6_0(v19) -> (* Some *)
            let v20 : int32 = v4.Id
            let v21 : Async<unit> = v19 struct (true, v12, v20)
            do! v21 
            ()
        let v22 : US0 = US0_0
        let v23 : (unit -> string) = closure13(v12)
        let v24 : (unit -> string) = closure8()
        method7(v22, v23, v24)
        let v25 : string = "["
        let v26 : string = "]"
        let v27 : string = $"{v25}{v12}{v26}"
        let v28 : (string -> unit) = v5.Push
        v28 v27
    }
    |> fun x -> _v11 <- Some x
    let v29 : Async<unit> = _v11 |> Option.get
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
    let mutable _v33 = v33
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
    let v34 : (Async<unit> -> unit) = Async.StartImmediate
    v34 v32
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
and closure15 () (v0 : System.Threading.CancellationToken) : US7 =
    US7_0(v0)
and method11 () : (System.Threading.CancellationToken -> US7) =
    closure15()
and closure16 (v0 : System.Diagnostics.Process) () : unit =
    let v1 : bool option = None
    let mutable _v1 = v1
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
    let v5 : bool = v0.HasExited
    v5 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v6 : bool = null |> unbox<bool>
    v6 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v7 : bool = Unchecked.defaultof<bool>
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : bool = _v1.Value
    let v9 : bool = v8 = false
    if v9 then
        let v10 : unit option = None
        let mutable _v10 = v10
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
        let v11 : (unit -> unit) = v0.Kill
        v11 ()
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
        |> fun x -> _v10 <- Some x
        _v10.Value
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
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v5 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v6 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> option = None
    let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<struct (int32 * string)> option = None
    let mutable _v12 = v12
    async {
    let struct (v13 : string, v14 : string) = method2()
    let v15 : char seq = v0 |> unbox<char seq>
    let v16 : (char seq -> char list) = Seq.toList
    let v17 : char list = v16 v15
    let v18 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v19 : (char -> (UH0 -> UH0)) = method3()
    let v20 : (char list -> (UH0 -> UH0)) = v18 v19
    let v21 : (UH0 -> UH0) = v20 v17
    let v22 : UH0 = UH0_0
    let v23 : UH0 = v21 v22
    let v24 : US2 = US2_0
    let struct (v25 : string, v26 : string) = method4(v14, v13, v23, v24)
    let v27 : (string -> US4) = method5()
    let v28 : US4 = US4_1
    let v29 : US4 = v3 |> Option.map v27 |> Option.defaultValue v28 
    let v33 : string =
        match v29 with
        | US4_1 -> (* None *)
            let v31 : string = ""
            v31
        | US4_0(v30) -> (* Some *)
            v30
    let v34 : US0 = US0_1
    let v35 : (unit -> string) = closure7(v1, v0, v2, v3)
    let v36 : (unit -> string) = method6()
    method7(v34, v35, v36)
    let v37 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v38 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v26, StandardOutputEncoding = v37, WorkingDirectory = v33, FileName = v25, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v39 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v38)
    use v39 = v39 
    let v40 : System.Diagnostics.Process = v39 
    let v41 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v42 : System.Collections.Concurrent.ConcurrentStack<string> = v41 ()
    let v43 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure11(v1, v0, v2, v3, v40, v42)
    v40.OutputDataReceived.Add v43 
    let v44 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v1, v0, v2, v3, v40, v42)
    v40.ErrorDataReceived.Add v44 
    let v45 : (unit -> bool) = v40.Start
    let v46 : bool = v45 ()
    let v47 : bool = v46 = false
    if v47 then
        let v48 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v48
    let v49 : (unit -> unit) = v40.BeginErrorReadLine
    v49 ()
    let v50 : (unit -> unit) = v40.BeginOutputReadLine
    v50 ()
    let v51 : (System.Threading.CancellationToken -> US7) = method11()
    let v52 : US7 = US7_1
    let v53 : US7 = v1 |> Option.map v51 |> Option.defaultValue v52 
    let v57 : System.Threading.CancellationToken =
        match v53 with
        | US7_1 -> (* None *)
            let v55 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v55
        | US7_0(v54) -> (* Some *)
            v54
    let v58 : Async<System.Threading.CancellationToken> option = None
    let mutable _v58 = v58
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v59 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v59 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v60 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v60 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v61 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v61 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v62 : Async<System.Threading.CancellationToken> option = None
    let mutable _v62 = v62
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v63 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v63 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v64 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v64 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v65 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v65 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v66 : Async<System.Threading.CancellationToken> option = None
    let mutable _v66 = v66
    async {
    let v67 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v67 = v67 
    let v68 : System.Threading.CancellationToken = v67 
    let v69 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v70 : (System.Threading.CancellationToken []) = [|v68; v69; v57|]
    let v71 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v72 : System.Threading.CancellationTokenSource = v71 v70
    let v73 : System.Threading.CancellationToken = v72.Token
    return v73 
    }
    |> fun x -> _v66 <- Some x
    let v74 : Async<System.Threading.CancellationToken> = _v66 |> Option.get
    v74 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v75 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v75 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v76 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v76 
    #endif
    |> fun x -> _v62 <- Some x
    let v77 : Async<System.Threading.CancellationToken> = _v62.Value
    v77 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v78 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v78 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v79 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v79 
    #endif
    |> fun x -> _v58 <- Some x
    let v80 : Async<System.Threading.CancellationToken> = _v58.Value
    let! v80 = v80 
    let v81 : System.Threading.CancellationToken = v80 
    let v82 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v81.Register
    let v83 : (unit -> unit) = closure16(v40)
    let v84 : System.Threading.CancellationTokenRegistration = v82 v83
    use v84 = v84 
    let v85 : System.Threading.CancellationTokenRegistration = v84 
    let v86 : Async<int32> option = None
    let mutable _v86 = v86
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : Async<int32> = null |> unbox<Async<int32>>
    v87 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v88 : Async<int32> = null |> unbox<Async<int32>>
    v88 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v89 : Async<int32> = null |> unbox<Async<int32>>
    v89 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v90 : Async<int32> option = None
    let mutable _v90 = v90
    async {
    try
    let v91 : System.Threading.Tasks.Task = v40.WaitForExitAsync v81 
    let v92 : Async<unit> option = None
    let mutable _v92 = v92
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v93 : Async<unit> = null |> unbox<Async<unit>>
    v93 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v94 : Async<unit> = null |> unbox<Async<unit>>
    v94 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v95 : Async<unit> = null |> unbox<Async<unit>>
    v95 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v96 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v97 : Async<unit> = v96 v91
    v97 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v98 : Async<unit> = null |> unbox<Async<unit>>
    v98 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v99 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v99 
    #endif
    |> fun x -> _v92 <- Some x
    let v100 : Async<unit> = _v92.Value
    do! v100 
    let v101 : int32 = v40.ExitCode
    return v101 
    with ex ->
    let v102 : exn = ex
    let v103 : string option = None
    let mutable _v103 = v103
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v104 : string = $"%A{v102}"
    v104 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v105 : string = $"%A{v102}"
    v105 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = $"%A{v102}"
    v106 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v107 : string = $"{v102.GetType ()}: {v102.Message}"
    v107 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v108 : string = $"%A{v102}"
    v108 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v109 : string = Unchecked.defaultof<string>
    v109 
    #endif
    |> fun x -> _v103 <- Some x
    let v110 : string = _v103.Value
    let v111 : (string -> unit) = v42.Push
    v111 v110
    let v112 : System.Threading.Tasks.TaskCanceledException = v102 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v113 : US0 = US0_3
    let v114 : (unit -> string) = closure17(v112)
    let v115 : (unit -> string) = method6()
    method7(v113, v114, v115)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v90 <- Some x
    let v116 : Async<int32> = _v90 |> Option.get
    v116 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v117 : Async<int32> = null |> unbox<Async<int32>>
    v117 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v118 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v118 
    #endif
    |> fun x -> _v86 <- Some x
    let v119 : Async<int32> = _v86.Value
    let! v119 = v119 
    let v120 : int32 = v119 
    let v121 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v122 : string seq = v121 v42
    let v123 : string = method12()
    let v124 : (string -> (string seq -> string)) = String.concat
    let v125 : (string seq -> string) = v124 v123
    let v126 : string = v125 v122
    let v127 : US0 = US0_1
    let v128 : (unit -> string) = closure18(v120, v126)
    let v129 : (unit -> string) = method6()
    method7(v127, v128, v129)
    return struct (v120, v126) 
    }
    |> fun x -> _v12 <- Some x
    let v130 : Async<struct (int32 * string)> = _v12 |> Option.get
    v130 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v131 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v131 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v132 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v132 
    #endif
    |> fun x -> _v8 <- Some x
    let v133 : Async<struct (int32 * string)> = _v8.Value
    v133 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v134 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v134 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v135 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v135 
    #endif
    |> fun x -> _v4 <- Some x
    let v136 : Async<struct (int32 * string)> = _v4.Value
    v136
and closure19 () struct (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option) : Async<struct (int32 * string)> =
    let v4 : Async<struct (int32 * string)> option = None
    let mutable _v4 = v4
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v5 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v5 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v6 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v7 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v7 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : Async<struct (int32 * string)> option = None
    let mutable _v8 = v8
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v9 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v10 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v10 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v11 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v12 : Async<struct (int32 * string)> option = None
    let mutable _v12 = v12
    async {
    let struct (v13 : string, v14 : string) = method2()
    let v15 : char seq = v1 |> unbox<char seq>
    let v16 : (char seq -> char list) = Seq.toList
    let v17 : char list = v16 v15
    let v18 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v19 : (char -> (UH0 -> UH0)) = method3()
    let v20 : (char list -> (UH0 -> UH0)) = v18 v19
    let v21 : (UH0 -> UH0) = v20 v17
    let v22 : UH0 = UH0_0
    let v23 : UH0 = v21 v22
    let v24 : US2 = US2_0
    let struct (v25 : string, v26 : string) = method4(v14, v13, v23, v24)
    let v27 : (string -> US4) = method5()
    let v28 : US4 = US4_1
    let v29 : US4 = v3 |> Option.map v27 |> Option.defaultValue v28 
    let v33 : string =
        match v29 with
        | US4_1 -> (* None *)
            let v31 : string = ""
            v31
        | US4_0(v30) -> (* Some *)
            v30
    let v34 : US0 = US0_1
    let v35 : (unit -> string) = closure7(v0, v1, v2, v3)
    let v36 : (unit -> string) = method6()
    method7(v34, v35, v36)
    let v37 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v38 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v26, StandardOutputEncoding = v37, WorkingDirectory = v33, FileName = v25, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v39 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v38)
    use v39 = v39 
    let v40 : System.Diagnostics.Process = v39 
    let v41 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v42 : System.Collections.Concurrent.ConcurrentStack<string> = v41 ()
    let v43 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure11(v0, v1, v2, v3, v40, v42)
    v40.OutputDataReceived.Add v43 
    let v44 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure14(v0, v1, v2, v3, v40, v42)
    v40.ErrorDataReceived.Add v44 
    let v45 : (unit -> bool) = v40.Start
    let v46 : bool = v45 ()
    let v47 : bool = v46 = false
    if v47 then
        let v48 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v48
    let v49 : (unit -> unit) = v40.BeginErrorReadLine
    v49 ()
    let v50 : (unit -> unit) = v40.BeginOutputReadLine
    v50 ()
    let v51 : (System.Threading.CancellationToken -> US7) = method11()
    let v52 : US7 = US7_1
    let v53 : US7 = v0 |> Option.map v51 |> Option.defaultValue v52 
    let v57 : System.Threading.CancellationToken =
        match v53 with
        | US7_1 -> (* None *)
            let v55 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v55
        | US7_0(v54) -> (* Some *)
            v54
    let v58 : Async<System.Threading.CancellationToken> option = None
    let mutable _v58 = v58
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v59 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v59 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v60 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v60 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v61 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v61 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v62 : Async<System.Threading.CancellationToken> option = None
    let mutable _v62 = v62
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v63 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v63 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v64 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v64 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v65 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v65 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v66 : Async<System.Threading.CancellationToken> option = None
    let mutable _v66 = v66
    async {
    let v67 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v67 = v67 
    let v68 : System.Threading.CancellationToken = v67 
    let v69 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v70 : (System.Threading.CancellationToken []) = [|v68; v69; v57|]
    let v71 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v72 : System.Threading.CancellationTokenSource = v71 v70
    let v73 : System.Threading.CancellationToken = v72.Token
    return v73 
    }
    |> fun x -> _v66 <- Some x
    let v74 : Async<System.Threading.CancellationToken> = _v66 |> Option.get
    v74 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v75 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v75 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v76 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v76 
    #endif
    |> fun x -> _v62 <- Some x
    let v77 : Async<System.Threading.CancellationToken> = _v62.Value
    v77 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v78 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v78 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v79 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v79 
    #endif
    |> fun x -> _v58 <- Some x
    let v80 : Async<System.Threading.CancellationToken> = _v58.Value
    let! v80 = v80 
    let v81 : System.Threading.CancellationToken = v80 
    let v82 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v81.Register
    let v83 : (unit -> unit) = closure16(v40)
    let v84 : System.Threading.CancellationTokenRegistration = v82 v83
    use v84 = v84 
    let v85 : System.Threading.CancellationTokenRegistration = v84 
    let v86 : Async<int32> option = None
    let mutable _v86 = v86
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v87 : Async<int32> = null |> unbox<Async<int32>>
    v87 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v88 : Async<int32> = null |> unbox<Async<int32>>
    v88 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v89 : Async<int32> = null |> unbox<Async<int32>>
    v89 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v90 : Async<int32> option = None
    let mutable _v90 = v90
    async {
    try
    let v91 : System.Threading.Tasks.Task = v40.WaitForExitAsync v81 
    let v92 : Async<unit> option = None
    let mutable _v92 = v92
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v93 : Async<unit> = null |> unbox<Async<unit>>
    v93 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v94 : Async<unit> = null |> unbox<Async<unit>>
    v94 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v95 : Async<unit> = null |> unbox<Async<unit>>
    v95 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v96 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v97 : Async<unit> = v96 v91
    v97 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v98 : Async<unit> = null |> unbox<Async<unit>>
    v98 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v99 : Async<unit> = Unchecked.defaultof<Async<unit>>
    v99 
    #endif
    |> fun x -> _v92 <- Some x
    let v100 : Async<unit> = _v92.Value
    do! v100 
    let v101 : int32 = v40.ExitCode
    return v101 
    with ex ->
    let v102 : exn = ex
    let v103 : string option = None
    let mutable _v103 = v103
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v104 : string = $"%A{v102}"
    v104 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v105 : string = $"%A{v102}"
    v105 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v106 : string = $"%A{v102}"
    v106 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v107 : string = $"{v102.GetType ()}: {v102.Message}"
    v107 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v108 : string = $"%A{v102}"
    v108 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v109 : string = Unchecked.defaultof<string>
    v109 
    #endif
    |> fun x -> _v103 <- Some x
    let v110 : string = _v103.Value
    let v111 : (string -> unit) = v42.Push
    v111 v110
    let v112 : System.Threading.Tasks.TaskCanceledException = v102 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v113 : US0 = US0_3
    let v114 : (unit -> string) = closure17(v112)
    let v115 : (unit -> string) = method6()
    method7(v113, v114, v115)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v90 <- Some x
    let v116 : Async<int32> = _v90 |> Option.get
    v116 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v117 : Async<int32> = null |> unbox<Async<int32>>
    v117 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v118 : Async<int32> = Unchecked.defaultof<Async<int32>>
    v118 
    #endif
    |> fun x -> _v86 <- Some x
    let v119 : Async<int32> = _v86.Value
    let! v119 = v119 
    let v120 : int32 = v119 
    let v121 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v122 : string seq = v121 v42
    let v123 : string = method12()
    let v124 : (string -> (string seq -> string)) = String.concat
    let v125 : (string seq -> string) = v124 v123
    let v126 : string = v125 v122
    let v127 : US0 = US0_1
    let v128 : (unit -> string) = closure18(v120, v126)
    let v129 : (unit -> string) = method6()
    method7(v127, v128, v129)
    return struct (v120, v126) 
    }
    |> fun x -> _v12 <- Some x
    let v130 : Async<struct (int32 * string)> = _v12 |> Option.get
    v130 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v131 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v131 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v132 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v132 
    #endif
    |> fun x -> _v8 <- Some x
    let v133 : Async<struct (int32 * string)> = _v8.Value
    v133 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v134 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v134 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v135 : Async<struct (int32 * string)> = Unchecked.defaultof<Async<struct (int32 * string)>>
    v135 
    #endif
    |> fun x -> _v4 <- Some x
    let v136 : Async<struct (int32 * string)> = _v4.Value
    v136
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
