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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>]
#endif
type StaticRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0; $1]")>]
#endif
type Slice'<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures_lite::stream::StreamExt")>]
#endif
type futures_lite_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::iter::Fuse<$0>")>]
#endif
type core_iter_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Arg")>]
#endif
type clap_Arg = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::Command")>]
#endif
type clap_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("clap::ArgMatches")>]
#endif
type clap_ArgMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Error")>]
#endif
type std_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::Lines<$0>")>]
#endif
type std_io_Lines<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::io::BufReader<$0>")>]
#endif
type async_std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::io::BufReader<$0>")>]
#endif
type std_io_BufReader<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Child")>]
#endif
type std_process_Child = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStderr")>]
#endif
type std_process_ChildStderr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::ChildStdout")>]
#endif
type std_process_ChildStdout = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Command")>]
#endif
type std_process_Command = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Output")>]
#endif
type std_process_Output = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::process::Stdio")>]
#endif
type std_process_Stdio = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
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
and Mut3 = {mutable l0 : (string -> unit)}
and [<Struct>] US1 =
    | US1_0 of f0_0 : int64
    | US1_1
and Mut4 = {mutable l0 : int32}
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
and UH1 =
    | UH1_0
    | UH1_1 of string * UH1
and [<Struct>] US8 =
    | US8_0
    | US8_1 of f1_0 : char
    | US8_2 of f2_0 : uint8
let rec closure1 () (v0 : string) : unit =
    ()
and method0 (v0 : int64 option) : int64 option =
    v0
and method1 (v0 : int64 option) : int64 option =
    v0
and closure0 () () : struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3) =
    let v0 : Mut1 = {l0 = true} : Mut1
    let v1 : Mut0 = {l0 = 0L} : Mut0
    let v2 : US0 = US0_0
    let v3 : Mut2 = {l0 = v2} : Mut2
    let v4 : (string -> unit) = closure1()
    let v5 : Mut3 = {l0 = v4} : Mut3
    let v6 : int64 option option = None
    let mutable _v6 = v6
    #if INTERACTIVE || !FABLE_COMPILER
    let v7 : string option = None
    let v8 : bool = true in let mutable _v7 = v7
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "env!(\"CARGO_PKG_NAME\").into()"
    let v10 : string = Fable.Core.RustInterop.emitRustExpr () v9
    v10
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = null |> unbox<string>
    v11
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : string = null |> unbox<string>
    v12
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v13 : string = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    v13
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v14 : string = null |> unbox<string>
    v14
#endif
    
#if FABLE_COMPILER_PYTHON
    let v15 : string = null |> unbox<string>
    v15
#endif
    |> fun x -> _v7 <- Some x
    let v16 : string = _v7.Value
    let v18 : bool = v16 = "Microsoft.DotNet.Interactive.App"
    let v19 : bool = v18 <> true
    let v25 : US1 =
        if v19 then
            let v20 : System.DateTime = System.DateTime.Now
            let v21 : (System.DateTime -> int64) = _.Ticks
            let v22 : int64 = v21 v20
            US1_0(v22)
        else
            US1_1
    let v30 : int64 option =
        match v25 with
        | US1_1 -> (* None *)
            let v28 : int64 option = None
            v28
        | US1_0(v26) -> (* Some *)
            let v27 : int64 option = Some v26 
            v27
    let v31 : int64 option = method0(v30)
    v31 
    #else
    let v32 : int64 option = None
    let v33 : int64 option = method1(v32)
    v33 
    #endif
    |> fun x -> _v6 <- Some x
    let v34 : int64 option = _v6.Value
    struct (v1, v0, v3, v34, v5)
and closure2 () () : bool =
    let v0 : bool option = None
    let v1 : bool = true in let mutable _v0 = v0
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "cfg!(windows)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v7 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v8 : bool = v7 v6
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : bool = null |> unbox<bool>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : bool = null |> unbox<bool>
    v10
#endif
    |> fun x -> _v0 <- Some x
    let v11 : bool = _v0.Value
    v11
and closure3 () () : string =
    let v0 : bool option = None
    let v1 : bool = true in let mutable _v0 = v0
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "cfg!(windows)"
    let v3 : bool = Fable.Core.RustInterop.emitRustExpr () v2
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v7 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v8 : bool = v7 v6
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : bool = null |> unbox<bool>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : bool = null |> unbox<bool>
    v10
#endif
    |> fun x -> _v0 <- Some x
    let v11 : bool = _v0.Value
    if v11 then
        let v12 : string = ".exe"
        v12
    else
        let v13 : string = ""
        v13
and method2 () : struct (string * string) =
    let v0 : string = ""
    struct (v0, v0)
and method3 (v0 : int32, v1 : Mut4) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure6 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure5 () (v0 : char) : (UH0 -> UH0) =
    closure6(v0)
and method4 () : (char -> (UH0 -> UH0)) =
    closure5()
and method5 (v0 : string, v1 : string, v2 : UH0, v3 : US2) : struct (string * string) =
    match v2 with
    | UH0_1(v4, v5) -> (* Cons *)
        let v6 : bool = '"' = v4
        if v6 then
            let v8 : bool = v1 = ""
            if v8 then
                let v9 : US3 = US3_0
                let v10 : US2 = US2_1(v9)
                method5(v0, v1, v5, v10)
            else
                match v3 with
                | US2_2 -> (* Arguments *)
                    let v38 : string = $"{v0}{v4}"
                    let v39 : US2 = US2_2
                    method5(v38, v1, v5, v39)
                | US2_1(v13) -> (* Path *)
                    match v13 with
                    | US3_0 -> (* Quoted *)
                        let v14 : US3 = US3_1
                        let v15 : US2 = US2_1(v14)
                        method5(v0, v1, v5, v15)
                    | _ ->
                        let v18 : bool = ' ' = v4
                        if v18 then
                            let v19 : US2 = US2_2
                            method5(v0, v1, v5, v19)
                        else
                            let v22 : string = $"{v1}{v4}"
                            method5(v0, v22, v5, v3)
                | US2_0 -> (* Start *)
                    let v29 : bool = ' ' = v4
                    if v29 then
                        let v30 : US2 = US2_2
                        method5(v0, v1, v5, v30)
                    else
                        let v33 : string = $"{v1}{v4}"
                        method5(v0, v33, v5, v3)
        else
            let v50 : bool = ''' = v4
            if v50 then
                let v52 : bool = v1 = ""
                if v52 then
                    let v53 : US3 = US3_0
                    let v54 : US2 = US2_1(v53)
                    method5(v0, v1, v5, v54)
                else
                    match v3 with
                    | US2_2 -> (* Arguments *)
                        let v82 : string = $"{v0}{v4}"
                        let v83 : US2 = US2_2
                        method5(v82, v1, v5, v83)
                    | US2_1(v57) -> (* Path *)
                        match v57 with
                        | US3_0 -> (* Quoted *)
                            let v58 : US3 = US3_1
                            let v59 : US2 = US2_1(v58)
                            method5(v0, v1, v5, v59)
                        | _ ->
                            let v62 : bool = ' ' = v4
                            if v62 then
                                let v63 : US2 = US2_2
                                method5(v0, v1, v5, v63)
                            else
                                let v66 : string = $"{v1}{v4}"
                                method5(v0, v66, v5, v3)
                    | US2_0 -> (* Start *)
                        let v73 : bool = ' ' = v4
                        if v73 then
                            let v74 : US2 = US2_2
                            method5(v0, v1, v5, v74)
                        else
                            let v77 : string = $"{v1}{v4}"
                            method5(v0, v77, v5, v3)
            else
                match v3 with
                | US2_2 -> (* Arguments *)
                    let v126 : string = $"{v0}{v4}"
                    let v127 : US2 = US2_2
                    method5(v126, v1, v5, v127)
                | US2_1(v94) -> (* Path *)
                    match v94 with
                    | US3_0 -> (* Quoted *)
                        let v95 : bool = ' ' = v4
                        if v95 then
                            let v96 : string = $"{v1} "
                            let v97 : US3 = US3_0
                            let v98 : US2 = US2_1(v97)
                            method5(v0, v96, v5, v98)
                        else
                            let v101 : string = $"{v1}{v4}"
                            method5(v0, v101, v5, v3)
                    | _ ->
                        let v106 : bool = ' ' = v4
                        if v106 then
                            let v107 : US2 = US2_2
                            method5(v0, v1, v5, v107)
                        else
                            let v110 : string = $"{v1}{v4}"
                            method5(v0, v110, v5, v3)
                | US2_0 -> (* Start *)
                    let v117 : bool = ' ' = v4
                    if v117 then
                        let v118 : US2 = US2_2
                        method5(v0, v1, v5, v118)
                    else
                        let v121 : string = $"{v1}{v4}"
                        method5(v0, v121, v5, v3)
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
and closure7 () (v0 : string) : US4 =
    US4_0(v0)
and method6 () : (string -> US4) =
    closure7()
and closure8 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option) () : string =
    let v4 : string = $"execute_with_options_async / options: %A{struct (v0, v1, v2, v3)}"
    v4
and closure9 () () : string =
    let v0 : string = ""
    v0
and method7 () : (unit -> string) =
    closure9()
and closure11 () (v0 : int64) : US5 =
    US5_0(v0)
and method9 () : (int64 -> US5) =
    closure11()
and method10 () : string =
    let v0 : string = ""
    v0
and closure10 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) () : string =
    let v3 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v3 () |> Some
    let struct (v4 : Mut0, v5 : Mut1, v6 : Mut2, v7 : int64 option, v8 : Mut3) = State.trace_state.Value
    let v9 : string option = None
    let v10 : bool = true in let mutable _v9 = v9
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v11 : (int64 -> US5) = method9()
    let v12 : US5 = US5_1
    let v13 : US5 = v7 |> Option.map v11 |> Option.defaultValue v12 
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
    let v34 : string = method10()
    v34
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v35 : string = method10()
    v35
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : (int64 -> US5) = method9()
    let v37 : US5 = US5_1
    let v38 : US5 = v7 |> Option.map v36 |> Option.defaultValue v37 
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
    let v59 : string = method10()
    v59
#endif
    
#if FABLE_COMPILER_PYTHON
    let v60 : string = method10()
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
    let v74 : string = v73.PadRight (7, ' ')
    let v75 : string option = None
    let v76 : bool = true in let mutable _v75 = v75
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v91 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v85 : string = "inline_colorization::color_bright_red"
            let v86 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v85
            v86
        | US0_1 -> (* Debug *)
            let v79 : string = "inline_colorization::color_bright_blue"
            let v80 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v79
            v80
        | US0_2 -> (* Info *)
            let v81 : string = "inline_colorization::color_bright_green"
            let v82 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v81
            v82
        | US0_0 -> (* Verbose *)
            let v77 : string = "inline_colorization::color_bright_black"
            let v78 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v77
            v78
        | US0_3 -> (* Warning *)
            let v83 : string = "inline_colorization::color_bright_yellow"
            let v84 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v83
            v84
    let v92 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v93 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v92
    let v94 : string = "inline_colorization::color_reset"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : string = "\"{v91}{v93}{v95}\""
    let v97 : string = @$"format!(" + v96 + ")"
    let v98 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v97
    let v99 : string = "fable_library_rust::String_::fromString($0)"
    let v100 : string = Fable.Core.RustInterop.emitRustExpr v98 v99
    v100
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v115 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v109 : string = "inline_colorization::color_bright_red"
            let v110 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v109
            v110
        | US0_1 -> (* Debug *)
            let v103 : string = "inline_colorization::color_bright_blue"
            let v104 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v103
            v104
        | US0_2 -> (* Info *)
            let v105 : string = "inline_colorization::color_bright_green"
            let v106 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v105
            v106
        | US0_0 -> (* Verbose *)
            let v101 : string = "inline_colorization::color_bright_black"
            let v102 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v101
            v102
        | US0_3 -> (* Warning *)
            let v107 : string = "inline_colorization::color_bright_yellow"
            let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107
            v108
    let v116 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v117 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v116
    let v118 : string = "inline_colorization::color_reset"
    let v119 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v118
    let v120 : string = "\"{v115}{v117}{v119}\""
    let v121 : string = @$"format!(" + v120 + ")"
    let v122 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v121
    let v123 : string = "fable_library_rust::String_::fromString($0)"
    let v124 : string = Fable.Core.RustInterop.emitRustExpr v122 v123
    v124
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v139 : Ref<Str> =
        match v0 with
        | US0_4 -> (* Critical *)
            let v133 : string = "inline_colorization::color_bright_red"
            let v134 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v133
            v134
        | US0_1 -> (* Debug *)
            let v127 : string = "inline_colorization::color_bright_blue"
            let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v127
            v128
        | US0_2 -> (* Info *)
            let v129 : string = "inline_colorization::color_bright_green"
            let v130 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v129
            v130
        | US0_0 -> (* Verbose *)
            let v125 : string = "inline_colorization::color_bright_black"
            let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v125
            v126
        | US0_3 -> (* Warning *)
            let v131 : string = "inline_colorization::color_bright_yellow"
            let v132 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v131
            v132
    let v140 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v141 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v74 v140
    let v142 : string = "inline_colorization::color_reset"
    let v143 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v142
    let v144 : string = "\"{v139}{v141}{v143}\""
    let v145 : string = @$"format!(" + v144 + ")"
    let v146 : std_string_String = Fable.Core.RustInterop.emitRustExpr () v145
    let v147 : string = "fable_library_rust::String_::fromString($0)"
    let v148 : string = Fable.Core.RustInterop.emitRustExpr v146 v147
    v148
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    v74
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    v74
#endif
    
#if FABLE_COMPILER_PYTHON
    v74
#endif
    |> fun x -> _v75 <- Some x
    let v149 : string = _v75.Value
    let v150 : string = v1 ()
    let v151 : string = $"{v61} {v149} #{v62} %s{v150} / %s{v2 ()}"
    let v152 : (char []) = [||]
    let v153 : string = v151.TrimStart v152
    let v154 : (char []) = [|' '; '/'|]
    let v155 : string = v153.TrimEnd v154
    v155
and method11 (v0 : US0, v1 : (unit -> string)) : unit =
    let v2 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v3 : Mut0, v4 : Mut1, v5 : Mut2, v6 : int64 option, v7 : Mut3) = State.trace_state.Value
    if State.trace_state.IsNone then State.trace_state <- v2 () |> Some
    let struct (v8 : Mut0, v9 : Mut1, v10 : Mut2, v11 : int64 option, v12 : Mut3) = State.trace_state.Value
    let v13 : US0 = v10.l0
    let v14 : bool = v9.l0
    let v15 : bool = v14 = false
    let v19 : bool =
        if v15 then
            false
        else
            let v16 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v0
            let v17 : int32 = [ US0_0, 0; US0_1, 1; US0_2, 2; US0_3, 3; US0_4, 4 ] |> Map |> Map.find v13
            let v18 : bool = v16 >= v17
            v18
    if v19 then
        let v20 : int64 = v3.l0
        let v21 : int64 = v20 + 1L
        v3.l0 <- v21
        let v22 : string = $"%s{v1 ()}"
        let v23 : unit option = None
        let v24 : bool = true in let mutable _v23 = v23
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v25 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v25
        ()
#endif
        
#if FABLE_COMPILER_RUST && WASM
        let v26 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v26
        ()
#endif
        
#if FABLE_COMPILER_RUST && CONTRACT
        let v27 : string = @"println!(""{}"", $0)"
        Fable.Core.RustInterop.emitRustExpr v22 v27
        ()
#endif
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        System.Console.WriteLine v22 
        ()
#endif
        
#if FABLE_COMPILER_TYPESCRIPT
        System.Console.WriteLine v22 
        ()
#endif
        
#if FABLE_COMPILER_PYTHON
        System.Console.WriteLine v22 
        ()
#endif
        |> fun x -> _v23 <- Some x
        _v23.Value
        let v28 : (string -> unit) = v7.l0
        v28 v22
and method8 (v0 : US0, v1 : (unit -> string), v2 : (unit -> string)) : unit =
    let v3 : (unit -> string) = closure10(v0, v1, v2)
    method11(v0, v3)
and closure13 () (v0 : (struct (bool * string * int32) -> Async<unit>)) : US6 =
    US6_0(v0)
and method12 () : ((struct (bool * string * int32) -> Async<unit>) -> US6) =
    closure13()
and closure14 (v0 : string) () : string =
    let v1 : string = $"> {v0}"
    v1
and closure12 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method12()
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
        let v24 : (unit -> string) = closure14(v13)
        let v25 : (unit -> string) = closure9()
        method8(v23, v24, v25)
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
    
#if FABLE_COMPILER_PYTHON
    let v31 : Async<unit> = null |> unbox<Async<unit>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v35 : (Async<unit> -> unit) = Async.StartImmediate
    v35 v32
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
    |> fun x -> _v33 <- Some x
    _v33.Value
    ()
and closure15 (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option, v4 : System.Diagnostics.Process, v5 : System.Collections.Concurrent.ConcurrentStack<string>) (v6 : System.Diagnostics.DataReceivedEventArgs) : unit =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v12 : Async<unit> option = None
    let mutable _v12 = v12
    async {
    let v13 : string = v6.Data
    let v14 : string = null |> unbox<string>
    let v15 : bool = v13 = v14
    let v16 : bool = v15 <> true
    if v16 then
        let v17 : ((struct (bool * string * int32) -> Async<unit>) -> US6) = method12()
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
        let v24 : (unit -> string) = closure14(v13)
        let v25 : (unit -> string) = closure9()
        method8(v23, v24, v25)
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
    
#if FABLE_COMPILER_PYTHON
    let v32 : Async<unit> = null |> unbox<Async<unit>>
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v36 : (Async<unit> -> unit) = Async.StartImmediate
    v36 v33
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
    |> fun x -> _v34 <- Some x
    _v34.Value
    ()
and closure16 () (v0 : System.Threading.CancellationToken) : US7 =
    US7_0(v0)
and method13 () : (System.Threading.CancellationToken -> US7) =
    closure16()
and closure17 (v0 : System.Diagnostics.Process) () : unit =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v6 : bool = v0.HasExited
    v6
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : bool = null |> unbox<bool>
    v7
#endif
    
#if FABLE_COMPILER_PYTHON
    let v8 : bool = null |> unbox<bool>
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
        
#if !FABLE_COMPILER && !WASM && !CONTRACT
        let v13 : (unit -> unit) = v0.Kill
        v13 ()
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
        |> fun x -> _v11 <- Some x
        _v11.Value
        ()
and closure18 (v0 : System.Threading.Tasks.TaskCanceledException) () : string =
    let v1 : string = $"execute_with_options_async / WaitForExitAsync / ex: %A{v0}"
    v1
and method14 () : string =
    let v0 : string = "\n"
    v0
and closure19 (v0 : int32, v1 : string) () : string =
    let v2 : string = $"execute_with_options_async / exit_code: {v0} / output.Length: {v1.Length}"
    v2
and closure4 () (v0 : string) : Async<struct (int32 * string)> =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> option = None
    let mutable _v14 = v14
    async {
    let struct (v15 : string, v16 : string) = method2()
    let v17 : int32 = v0.Length
    let v18 : (char []) = Array.zeroCreate<char> (v17)
    let v19 : Mut4 = {l0 = 0} : Mut4
    while method3(v17, v19) do
        let v21 : int32 = v19.l0
        let v22 : char = v0.[int v21]
        v18.[int v21] <- v22
        let v23 : int32 = v21 + 1
        v19.l0 <- v23
        ()
    let v24 : ((char []) -> char list) = Array.toList
    let v25 : char list = v24 v18
    let v26 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v27 : (char -> (UH0 -> UH0)) = method4()
    let v28 : (char list -> (UH0 -> UH0)) = v26 v27
    let v29 : (UH0 -> UH0) = v28 v25
    let v30 : UH0 = UH0_0
    let v31 : UH0 = v29 v30
    let v32 : US2 = US2_0
    let struct (v33 : string, v34 : string) = method5(v16, v15, v31, v32)
    let v35 : (string -> US4) = method6()
    let v36 : US4 = US4_1
    let v37 : US4 = v3 |> Option.map v35 |> Option.defaultValue v36 
    let v41 : string =
        match v37 with
        | US4_1 -> (* None *)
            let v39 : string = ""
            v39
        | US4_0(v38) -> (* Some *)
            v38
    let v42 : US0 = US0_1
    let v43 : (unit -> string) = closure8(v1, v0, v2, v3)
    let v44 : (unit -> string) = method7()
    method8(v42, v43, v44)
    let v45 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v46 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v34, StandardOutputEncoding = v45, WorkingDirectory = v41, FileName = v33, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v47 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v46)
    use v47 = v47 
    let v48 : System.Diagnostics.Process = v47 
    let v49 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v50 : System.Collections.Concurrent.ConcurrentStack<string> = v49 ()
    let v51 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure12(v1, v0, v2, v3, v48, v50)
    v48.OutputDataReceived.Add v51 
    let v52 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure15(v1, v0, v2, v3, v48, v50)
    v48.ErrorDataReceived.Add v52 
    let v53 : (unit -> bool) = v48.Start
    let v54 : bool = v53 ()
    let v55 : bool = v54 = false
    if v55 then
        let v56 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v56
    let v57 : (unit -> unit) = v48.BeginErrorReadLine
    v57 ()
    let v58 : (unit -> unit) = v48.BeginOutputReadLine
    v58 ()
    let v59 : (System.Threading.CancellationToken -> US7) = method13()
    let v60 : US7 = US7_1
    let v61 : US7 = v1 |> Option.map v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US7_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US7_0(v62) -> (* Some *)
            v62
    let v66 : Async<System.Threading.CancellationToken> option = None
    let v67 : bool = true in let mutable _v66 = v66
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v68
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v69 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v69
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v70
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v71 : Async<System.Threading.CancellationToken> option = None
    let v72 : bool = true in let mutable _v71 = v71
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v73
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v74 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v74
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v75
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v76 : Async<System.Threading.CancellationToken> option = None
    let mutable _v76 = v76
    async {
    let v77 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v77 = v77 
    let v78 : System.Threading.CancellationToken = v77 
    let v79 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v80 : (System.Threading.CancellationToken []) = [|v78; v79; v65|]
    let v81 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v82 : System.Threading.CancellationTokenSource = v81 v80
    let v83 : System.Threading.CancellationToken = v82.Token
    return v83 
    }
    |> fun x -> _v76 <- Some x
    let v84 : Async<System.Threading.CancellationToken> = _v76 |> Option.get
    v84
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v85
#endif
    
#if FABLE_COMPILER_PYTHON
    let v86 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v86
#endif
    |> fun x -> _v71 <- Some x
    let v87 : Async<System.Threading.CancellationToken> = _v71.Value
    v87
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v88
#endif
    
#if FABLE_COMPILER_PYTHON
    let v89 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v89
#endif
    |> fun x -> _v66 <- Some x
    let v90 : Async<System.Threading.CancellationToken> = _v66.Value
    let! v90 = v90 
    let v91 : System.Threading.CancellationToken = v90 
    let v92 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v91.Register
    let v93 : (unit -> unit) = closure17(v48)
    let v94 : System.Threading.CancellationTokenRegistration = v92 v93
    use v94 = v94 
    let v95 : System.Threading.CancellationTokenRegistration = v94 
    let v96 : Async<int32> option = None
    let v97 : bool = true in let mutable _v96 = v96
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v98 : Async<int32> = null |> unbox<Async<int32>>
    v98
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v99 : Async<int32> = null |> unbox<Async<int32>>
    v99
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : Async<int32> = null |> unbox<Async<int32>>
    v100
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v101 : Async<int32> option = None
    let mutable _v101 = v101
    async {
    try
    let v102 : System.Threading.Tasks.Task = v48.WaitForExitAsync v91 
    let v103 : Async<unit> option = None
    let v104 : bool = true in let mutable _v103 = v103
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : Async<unit> = null |> unbox<Async<unit>>
    v105
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v106 : Async<unit> = null |> unbox<Async<unit>>
    v106
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : Async<unit> = null |> unbox<Async<unit>>
    v107
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v108 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v109 : Async<unit> = v108 v102
    v109
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Async<unit> = null |> unbox<Async<unit>>
    v110
#endif
    
#if FABLE_COMPILER_PYTHON
    let v111 : Async<unit> = null |> unbox<Async<unit>>
    v111
#endif
    |> fun x -> _v103 <- Some x
    let v112 : Async<unit> = _v103.Value
    do! v112 
    let v113 : int32 = v48.ExitCode
    return v113 
    with ex ->
    let v114 : exn = ex
    let v115 : string option = None
    let v116 : bool = true in let mutable _v115 = v115
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : string = $"%A{v114}"
    v117
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v118 : string = $"%A{v114}"
    v118
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v119 : string = $"%A{v114}"
    v119
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v120 : string = $"{v114.GetType ()}: {v114.Message}"
    v120
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : string = $"%A{v114}"
    v121
#endif
    
#if FABLE_COMPILER_PYTHON
    let v122 : string = $"%A{v114}"
    v122
#endif
    |> fun x -> _v115 <- Some x
    let v123 : string = _v115.Value
    let v124 : (string -> unit) = v50.Push
    v124 v123
    let v125 : System.Threading.Tasks.TaskCanceledException = v114 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v126 : US0 = US0_3
    let v127 : (unit -> string) = closure18(v125)
    let v128 : (unit -> string) = method7()
    method8(v126, v127, v128)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v101 <- Some x
    let v129 : Async<int32> = _v101 |> Option.get
    v129
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v130 : Async<int32> = null |> unbox<Async<int32>>
    v130
#endif
    
#if FABLE_COMPILER_PYTHON
    let v131 : Async<int32> = null |> unbox<Async<int32>>
    v131
#endif
    |> fun x -> _v96 <- Some x
    let v132 : Async<int32> = _v96.Value
    let! v132 = v132 
    let v133 : int32 = v132 
    let v134 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v135 : string seq = v134 v50
    let v136 : string = method14()
    let v137 : (string -> (string seq -> string)) = String.concat
    let v138 : (string seq -> string) = v137 v136
    let v139 : string = v138 v135
    let v140 : US0 = US0_1
    let v141 : (unit -> string) = closure19(v133, v139)
    let v142 : (unit -> string) = method7()
    method8(v140, v141, v142)
    return struct (v133, v139) 
    }
    |> fun x -> _v14 <- Some x
    let v143 : Async<struct (int32 * string)> = _v14 |> Option.get
    v143
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v144
#endif
    
#if FABLE_COMPILER_PYTHON
    let v145 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v145
#endif
    |> fun x -> _v9 <- Some x
    let v146 : Async<struct (int32 * string)> = _v9.Value
    v146
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v147
#endif
    
#if FABLE_COMPILER_PYTHON
    let v148 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v148
#endif
    |> fun x -> _v4 <- Some x
    let v149 : Async<struct (int32 * string)> = _v4.Value
    v149
and closure20 () struct (v0 : System.Threading.CancellationToken option, v1 : string, v2 : (struct (bool * string * int32) -> Async<unit>) option, v3 : string option) : Async<struct (int32 * string)> =
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
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
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v14 : Async<struct (int32 * string)> option = None
    let mutable _v14 = v14
    async {
    let struct (v15 : string, v16 : string) = method2()
    let v17 : int32 = v1.Length
    let v18 : (char []) = Array.zeroCreate<char> (v17)
    let v19 : Mut4 = {l0 = 0} : Mut4
    while method3(v17, v19) do
        let v21 : int32 = v19.l0
        let v22 : char = v1.[int v21]
        v18.[int v21] <- v22
        let v23 : int32 = v21 + 1
        v19.l0 <- v23
        ()
    let v24 : ((char []) -> char list) = Array.toList
    let v25 : char list = v24 v18
    let v26 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v27 : (char -> (UH0 -> UH0)) = method4()
    let v28 : (char list -> (UH0 -> UH0)) = v26 v27
    let v29 : (UH0 -> UH0) = v28 v25
    let v30 : UH0 = UH0_0
    let v31 : UH0 = v29 v30
    let v32 : US2 = US2_0
    let struct (v33 : string, v34 : string) = method5(v16, v15, v31, v32)
    let v35 : (string -> US4) = method6()
    let v36 : US4 = US4_1
    let v37 : US4 = v3 |> Option.map v35 |> Option.defaultValue v36 
    let v41 : string =
        match v37 with
        | US4_1 -> (* None *)
            let v39 : string = ""
            v39
        | US4_0(v38) -> (* Some *)
            v38
    let v42 : US0 = US0_1
    let v43 : (unit -> string) = closure8(v0, v1, v2, v3)
    let v44 : (unit -> string) = method7()
    method8(v42, v43, v44)
    let v45 : System.Text.Encoding = System.Text.Encoding.UTF8
    let v46 : System.Diagnostics.ProcessStartInfo = System.Diagnostics.ProcessStartInfo (Arguments = v34, StandardOutputEncoding = v45, WorkingDirectory = v41, FileName = v33, CreateNoWindow = true, RedirectStandardError = true, RedirectStandardOutput = true, UseShellExecute = false)
    let v47 : System.Diagnostics.Process = new System.Diagnostics.Process (StartInfo = v46)
    use v47 = v47 
    let v48 : System.Diagnostics.Process = v47 
    let v49 : (unit -> System.Collections.Concurrent.ConcurrentStack<string>) = System.Collections.Concurrent.ConcurrentStack<string>
    let v50 : System.Collections.Concurrent.ConcurrentStack<string> = v49 ()
    let v51 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure12(v0, v1, v2, v3, v48, v50)
    v48.OutputDataReceived.Add v51 
    let v52 : (System.Diagnostics.DataReceivedEventArgs -> unit) = closure15(v0, v1, v2, v3, v48, v50)
    v48.ErrorDataReceived.Add v52 
    let v53 : (unit -> bool) = v48.Start
    let v54 : bool = v53 ()
    let v55 : bool = v54 = false
    if v55 then
        let v56 : string = $"execute_with_options_async / process_start error"
        failwith<unit> v56
    let v57 : (unit -> unit) = v48.BeginErrorReadLine
    v57 ()
    let v58 : (unit -> unit) = v48.BeginOutputReadLine
    v58 ()
    let v59 : (System.Threading.CancellationToken -> US7) = method13()
    let v60 : US7 = US7_1
    let v61 : US7 = v0 |> Option.map v59 |> Option.defaultValue v60 
    let v65 : System.Threading.CancellationToken =
        match v61 with
        | US7_1 -> (* None *)
            let v63 : System.Threading.CancellationToken = System.Threading.CancellationToken.None
            v63
        | US7_0(v62) -> (* Some *)
            v62
    let v66 : Async<System.Threading.CancellationToken> option = None
    let v67 : bool = true in let mutable _v66 = v66
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v68 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v68
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v69 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v69
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v70
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v71 : Async<System.Threading.CancellationToken> option = None
    let v72 : bool = true in let mutable _v71 = v71
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v73 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v73
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v74 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v74
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v75 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v75
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v76 : Async<System.Threading.CancellationToken> option = None
    let mutable _v76 = v76
    async {
    let v77 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v77 = v77 
    let v78 : System.Threading.CancellationToken = v77 
    let v79 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v80 : (System.Threading.CancellationToken []) = [|v78; v79; v65|]
    let v81 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v82 : System.Threading.CancellationTokenSource = v81 v80
    let v83 : System.Threading.CancellationToken = v82.Token
    return v83 
    }
    |> fun x -> _v76 <- Some x
    let v84 : Async<System.Threading.CancellationToken> = _v76 |> Option.get
    v84
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v85 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v85
#endif
    
#if FABLE_COMPILER_PYTHON
    let v86 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v86
#endif
    |> fun x -> _v71 <- Some x
    let v87 : Async<System.Threading.CancellationToken> = _v71.Value
    v87
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v88 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v88
#endif
    
#if FABLE_COMPILER_PYTHON
    let v89 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v89
#endif
    |> fun x -> _v66 <- Some x
    let v90 : Async<System.Threading.CancellationToken> = _v66.Value
    let! v90 = v90 
    let v91 : System.Threading.CancellationToken = v90 
    let v92 : ((unit -> unit) -> System.Threading.CancellationTokenRegistration) = v91.Register
    let v93 : (unit -> unit) = closure17(v48)
    let v94 : System.Threading.CancellationTokenRegistration = v92 v93
    use v94 = v94 
    let v95 : System.Threading.CancellationTokenRegistration = v94 
    let v96 : Async<int32> option = None
    let v97 : bool = true in let mutable _v96 = v96
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v98 : Async<int32> = null |> unbox<Async<int32>>
    v98
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v99 : Async<int32> = null |> unbox<Async<int32>>
    v99
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v100 : Async<int32> = null |> unbox<Async<int32>>
    v100
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v101 : Async<int32> option = None
    let mutable _v101 = v101
    async {
    try
    let v102 : System.Threading.Tasks.Task = v48.WaitForExitAsync v91 
    let v103 : Async<unit> option = None
    let v104 : bool = true in let mutable _v103 = v103
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v105 : Async<unit> = null |> unbox<Async<unit>>
    v105
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v106 : Async<unit> = null |> unbox<Async<unit>>
    v106
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v107 : Async<unit> = null |> unbox<Async<unit>>
    v107
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v108 : (System.Threading.Tasks.Task -> Async<unit>) = Async.AwaitTask
    let v109 : Async<unit> = v108 v102
    v109
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v110 : Async<unit> = null |> unbox<Async<unit>>
    v110
#endif
    
#if FABLE_COMPILER_PYTHON
    let v111 : Async<unit> = null |> unbox<Async<unit>>
    v111
#endif
    |> fun x -> _v103 <- Some x
    let v112 : Async<unit> = _v103.Value
    do! v112 
    let v113 : int32 = v48.ExitCode
    return v113 
    with ex ->
    let v114 : exn = ex
    let v115 : string option = None
    let v116 : bool = true in let mutable _v115 = v115
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v117 : string = $"%A{v114}"
    v117
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v118 : string = $"%A{v114}"
    v118
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v119 : string = $"%A{v114}"
    v119
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v120 : string = $"{v114.GetType ()}: {v114.Message}"
    v120
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v121 : string = $"%A{v114}"
    v121
#endif
    
#if FABLE_COMPILER_PYTHON
    let v122 : string = $"%A{v114}"
    v122
#endif
    |> fun x -> _v115 <- Some x
    let v123 : string = _v115.Value
    let v124 : (string -> unit) = v50.Push
    v124 v123
    let v125 : System.Threading.Tasks.TaskCanceledException = v114 |> unbox<System.Threading.Tasks.TaskCanceledException>
    let v126 : US0 = US0_3
    let v127 : (unit -> string) = closure18(v125)
    let v128 : (unit -> string) = method7()
    method8(v126, v127, v128)
    return -2147483648 
    (*
    *)
    }
    |> fun x -> _v101 <- Some x
    let v129 : Async<int32> = _v101 |> Option.get
    v129
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v130 : Async<int32> = null |> unbox<Async<int32>>
    v130
#endif
    
#if FABLE_COMPILER_PYTHON
    let v131 : Async<int32> = null |> unbox<Async<int32>>
    v131
#endif
    |> fun x -> _v96 <- Some x
    let v132 : Async<int32> = _v96.Value
    let! v132 = v132 
    let v133 : int32 = v132 
    let v134 : (System.Collections.Concurrent.ConcurrentStack<string> -> string seq) = Seq.rev
    let v135 : string seq = v134 v50
    let v136 : string = method14()
    let v137 : (string -> (string seq -> string)) = String.concat
    let v138 : (string seq -> string) = v137 v136
    let v139 : string = v138 v135
    let v140 : US0 = US0_1
    let v141 : (unit -> string) = closure19(v133, v139)
    let v142 : (unit -> string) = method7()
    method8(v140, v141, v142)
    return struct (v133, v139) 
    }
    |> fun x -> _v14 <- Some x
    let v143 : Async<struct (int32 * string)> = _v14 |> Option.get
    v143
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v144 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v144
#endif
    
#if FABLE_COMPILER_PYTHON
    let v145 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v145
#endif
    |> fun x -> _v9 <- Some x
    let v146 : Async<struct (int32 * string)> = _v9.Value
    v146
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v147 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v147
#endif
    
#if FABLE_COMPILER_PYTHON
    let v148 : Async<struct (int32 * string)> = null |> unbox<Async<struct (int32 * string)>>
    v148
#endif
    |> fun x -> _v4 <- Some x
    let v149 : Async<struct (int32 * string)> = _v4.Value
    v149
and method18 (v0 : UH1, v1 : UH1) : UH1 =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : UH1 = method18(v3, v1)
        UH1_1(v2, v4)
    | UH1_0 -> (* Nil *)
        v1
and method17 (v0 : string, v1 : UH1, v2 : UH0, v3 : US8) : struct (UH1 * string) =
    match v3 with
    | US8_2(v44) -> (* Escaped *)
        match v2 with
        | UH0_1(v45, v46) -> (* Cons *)
            let v47 : bool = '\\' = v45
            if v47 then
                let v48 : char = '\\'
                let v49 : US8 = US8_1(v48)
                method16(v0, v1, v46, v3, v49)
            else
                let v52 : bool = '"' = v45
                if v52 then
                    let v54 : bool =
                        match v3 with
                        | US8_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v54 then
                        method17(v0, v1, v46, v3)
                    else
                        let v57 : string = $"{v0}\""
                        let v58 : US8 = US8_2(v44)
                        method16(v57, v1, v46, v3, v58)
                else
                    let v63 : bool = ' ' = v45
                    if v63 then
                        let v64 : string = $"{v0} "
                        method17(v64, v1, v46, v3)
                    else
                        let v67 : bool = 1uy = v44
                        if v67 then
                            let v68 : bool = v3 <> v3
                            if v68 then
                                let v69 : string = $"{v0}\{v45}"
                                method17(v69, v1, v46, v3)
                            else
                                let v72 : string = $"{v0}{v45}"
                                method17(v72, v1, v46, v3)
                        else
                            let v77 : string = $"{v0}{v45}"
                            method17(v77, v1, v46, v3)
        | _ ->
            let v88 : bool = 1uy = v44
            if v88 then
                let v90 : bool = v0 = ""
                let v94 : UH1 =
                    if v90 then
                        v1
                    else
                        let v91 : UH1 = UH1_0
                        let v92 : UH1 = UH1_1(v0, v91)
                        method18(v1, v92)
                struct (v94, v0)
            else
                let v96 : bool = v0 = ""
                let v100 : UH1 =
                    if v96 then
                        v1
                    else
                        let v97 : UH1 = UH1_0
                        let v98 : UH1 = UH1_1(v0, v97)
                        method18(v1, v98)
                struct (v100, v0)
    | US8_1(v105) -> (* Quoted *)
        let v106 : bool = '"' = v105
        if v106 then
            match v2 with
            | UH0_1(v107, v108) -> (* Cons *)
                let v109 : bool = '"' = v107
                if v109 then
                    let v110 : US8 = US8_1('\\')
                    let v111 : bool = v3 = v110
                    if v111 then
                        let v112 : US8 = US8_0
                        method16(v0, v1, v108, v3, v112)
                    else
                        let v115 : bool = '\\' = v105
                        if v115 then
                            let v116 : US8 = US8_2(0uy)
                            let v117 : bool = v3 <> v116
                            if v117 then
                                let v118 : string = $"{v0}\""
                                let v119 : char = '"'
                                let v120 : US8 = US8_1(v119)
                                method16(v118, v1, v108, v3, v120)
                            else
                                let v123 : US8 = US8_1('\\')
                                let v124 : bool = v3 = v123
                                if v124 then
                                    let v125 : string = $"{v0}\""
                                    let v126 : char = '"'
                                    let v127 : US8 = US8_1(v126)
                                    method16(v125, v1, v108, v3, v127)
                                else
                                    let v130 : US8 = US8_0
                                    method16(v0, v1, v108, v3, v130)
                        else
                            let v137 : bool = '\\' = v107
                            if v137 then
                                let v138 : uint8 = 1uy
                                let v139 : US8 = US8_2(v138)
                                method16(v0, v1, v108, v3, v139)
                            else
                                let v142 : US8 = US8_2(0uy)
                                let v143 : bool = v3 = v142
                                if v143 then
                                    let v144 : string = $"{v0}\""
                                    let v145 : char = '"'
                                    let v146 : US8 = US8_1(v145)
                                    method16(v144, v1, v108, v3, v146)
                                else
                                    let v149 : UH1 = UH1_0
                                    let v150 : UH1 = UH1_1(v0, v149)
                                    let v151 : UH1 = method18(v1, v150)
                                    let v152 : string = ""
                                    let v153 : US8 = US8_0
                                    method16(v152, v151, v108, v3, v153)
                else
                    let v164 : bool = '\\' = v105
                    if v164 then
                        let v165 : bool = '\\' = v107
                        if v165 then
                            let v166 : uint8 = 1uy
                            let v167 : US8 = US8_2(v166)
                            method16(v0, v1, v108, v3, v167)
                        else
                            let v170 : bool = ' ' = v107
                            if v170 then
                                let v171 : string = $"{v0} "
                                method17(v171, v1, v108, v3)
                            else
                                let v174 : string = $"{v0}{v107}"
                                method17(v174, v1, v108, v3)
                    else
                        let v181 : bool = '\\' = v107
                        if v181 then
                            let v182 : uint8 = 1uy
                            let v183 : US8 = US8_2(v182)
                            method16(v0, v1, v108, v3, v183)
                        else
                            let v186 : bool = ' ' = v107
                            if v186 then
                                let v187 : string = $"{v0} "
                                method17(v187, v1, v108, v3)
                            else
                                let v190 : string = $"{v0}{v107}"
                                method17(v190, v1, v108, v3)
            | _ ->
                let v201 : bool = '\\' = v105
                if v201 then
                    let v203 : bool = v0 = ""
                    let v207 : UH1 =
                        if v203 then
                            v1
                        else
                            let v204 : UH1 = UH1_0
                            let v205 : UH1 = UH1_1(v0, v204)
                            method18(v1, v205)
                    struct (v207, v0)
                else
                    let v209 : bool = v0 = ""
                    let v213 : UH1 =
                        if v209 then
                            v1
                        else
                            let v210 : UH1 = UH1_0
                            let v211 : UH1 = UH1_1(v0, v210)
                            method18(v1, v211)
                    struct (v213, v0)
        else
            let v218 : bool = '\\' = v105
            if v218 then
                match v2 with
                | UH0_1(v219, v220) -> (* Cons *)
                    let v221 : bool = '"' = v219
                    if v221 then
                        let v222 : US8 = US8_2(0uy)
                        let v223 : bool = v3 <> v222
                        if v223 then
                            let v224 : string = $"{v0}\""
                            let v225 : char = '"'
                            let v226 : US8 = US8_1(v225)
                            method16(v224, v1, v220, v3, v226)
                        else
                            let v229 : US8 = US8_1('\\')
                            let v230 : bool = v3 = v229
                            if v230 then
                                let v231 : string = $"{v0}\""
                                let v232 : char = '"'
                                let v233 : US8 = US8_1(v232)
                                method16(v231, v1, v220, v3, v233)
                            else
                                let v236 : US8 = US8_0
                                method16(v0, v1, v220, v3, v236)
                    else
                        let v243 : bool = '\\' = v219
                        if v243 then
                            let v244 : uint8 = 1uy
                            let v245 : US8 = US8_2(v244)
                            method16(v0, v1, v220, v3, v245)
                        else
                            let v248 : bool = ' ' = v219
                            if v248 then
                                let v249 : string = $"{v0} "
                                method17(v249, v1, v220, v3)
                            else
                                let v252 : string = $"{v0}{v219}"
                                method17(v252, v1, v220, v3)
                | _ ->
                    let v262 : bool = v0 = ""
                    let v266 : UH1 =
                        if v262 then
                            v1
                        else
                            let v263 : UH1 = UH1_0
                            let v264 : UH1 = UH1_1(v0, v263)
                            method18(v1, v264)
                    struct (v266, v0)
            else
                match v2 with
                | UH0_1(v269, v270) -> (* Cons *)
                    let v271 : bool = '\\' = v269
                    if v271 then
                        let v272 : uint8 = 1uy
                        let v273 : US8 = US8_2(v272)
                        method16(v0, v1, v270, v3, v273)
                    else
                        let v276 : bool = '"' = v269
                        if v276 then
                            let v277 : US8 = US8_2(0uy)
                            let v278 : bool = v3 = v277
                            if v278 then
                                let v279 : string = $"{v0}\""
                                let v280 : char = '"'
                                let v281 : US8 = US8_1(v280)
                                method16(v279, v1, v270, v3, v281)
                            else
                                let v284 : UH1 = UH1_0
                                let v285 : UH1 = UH1_1(v0, v284)
                                let v286 : UH1 = method18(v1, v285)
                                let v287 : string = ""
                                let v288 : US8 = US8_0
                                method16(v287, v286, v270, v3, v288)
                        else
                            let v293 : bool = ' ' = v269
                            if v293 then
                                let v294 : string = $"{v0} "
                                method17(v294, v1, v270, v3)
                            else
                                let v297 : string = $"{v0}{v269}"
                                method17(v297, v1, v270, v3)
                | _ ->
                    let v307 : bool = v0 = ""
                    let v311 : UH1 =
                        if v307 then
                            v1
                        else
                            let v308 : UH1 = UH1_0
                            let v309 : UH1 = UH1_1(v0, v308)
                            method18(v1, v309)
                    struct (v311, v0)
    | US8_0 -> (* Start *)
        match v2 with
        | UH0_1(v4, v5) -> (* Cons *)
            let v6 : bool = '"' = v4
            if v6 then
                let v7 : string = ""
                let v8 : char = '"'
                let v9 : US8 = US8_1(v8)
                method16(v7, v1, v5, v3, v9)
            else
                let v12 : bool = '\\' = v4
                if v12 then
                    let v13 : uint8 = 0uy
                    let v14 : US8 = US8_2(v13)
                    method16(v0, v1, v5, v3, v14)
                else
                    let v17 : bool = ' ' = v4
                    if v17 then
                        let v19 : bool = v0 = ""
                        let v23 : UH1 =
                            if v19 then
                                v1
                            else
                                let v20 : UH1 = UH1_0
                                let v21 : UH1 = UH1_1(v0, v20)
                                method18(v1, v21)
                        let v24 : string = ""
                        method17(v24, v23, v5, v3)
                    else
                        let v27 : string = $"{v0}{v4}"
                        method17(v27, v1, v5, v3)
        | _ ->
            let v37 : bool = v0 = ""
            let v41 : UH1 =
                if v37 then
                    v1
                else
                    let v38 : UH1 = UH1_0
                    let v39 : UH1 = UH1_1(v0, v38)
                    method18(v1, v39)
            struct (v41, v0)
and method16 (v0 : string, v1 : UH1, v2 : UH0, v3 : US8, v4 : US8) : struct (UH1 * string) =
    match v4 with
    | US8_2(v45) -> (* Escaped *)
        match v2 with
        | UH0_1(v46, v47) -> (* Cons *)
            let v48 : bool = '\\' = v46
            if v48 then
                let v49 : char = '\\'
                let v50 : US8 = US8_1(v49)
                method16(v0, v1, v47, v4, v50)
            else
                let v53 : bool = '"' = v46
                if v53 then
                    let v55 : bool =
                        match v3 with
                        | US8_0 -> (* Start *)
                            true
                        | _ ->
                            false
                    if v55 then
                        method17(v0, v1, v47, v4)
                    else
                        let v58 : string = $"{v0}\""
                        let v59 : US8 = US8_2(v45)
                        method16(v58, v1, v47, v4, v59)
                else
                    let v64 : bool = ' ' = v46
                    if v64 then
                        let v65 : string = $"{v0} "
                        method17(v65, v1, v47, v4)
                    else
                        let v68 : bool = 1uy = v45
                        if v68 then
                            let v69 : bool = v3 <> v4
                            if v69 then
                                let v70 : string = $"{v0}\{v46}"
                                method16(v70, v1, v47, v4, v3)
                            else
                                let v73 : string = $"{v0}{v46}"
                                method17(v73, v1, v47, v4)
                        else
                            let v78 : string = $"{v0}{v46}"
                            method17(v78, v1, v47, v4)
        | _ ->
            let v89 : bool = 1uy = v45
            if v89 then
                let v91 : bool = v0 = ""
                let v95 : UH1 =
                    if v91 then
                        v1
                    else
                        let v92 : UH1 = UH1_0
                        let v93 : UH1 = UH1_1(v0, v92)
                        method18(v1, v93)
                struct (v95, v0)
            else
                let v97 : bool = v0 = ""
                let v101 : UH1 =
                    if v97 then
                        v1
                    else
                        let v98 : UH1 = UH1_0
                        let v99 : UH1 = UH1_1(v0, v98)
                        method18(v1, v99)
                struct (v101, v0)
    | US8_1(v106) -> (* Quoted *)
        let v107 : bool = '"' = v106
        if v107 then
            match v2 with
            | UH0_1(v108, v109) -> (* Cons *)
                let v110 : bool = '"' = v108
                if v110 then
                    let v111 : US8 = US8_1('\\')
                    let v112 : bool = v3 = v111
                    if v112 then
                        let v113 : US8 = US8_0
                        method16(v0, v1, v109, v4, v113)
                    else
                        let v116 : bool = '\\' = v106
                        if v116 then
                            let v117 : US8 = US8_2(0uy)
                            let v118 : bool = v3 <> v117
                            if v118 then
                                let v119 : string = $"{v0}\""
                                let v120 : char = '"'
                                let v121 : US8 = US8_1(v120)
                                method16(v119, v1, v109, v4, v121)
                            else
                                let v124 : US8 = US8_1('\\')
                                let v125 : bool = v3 = v124
                                if v125 then
                                    let v126 : string = $"{v0}\""
                                    let v127 : char = '"'
                                    let v128 : US8 = US8_1(v127)
                                    method16(v126, v1, v109, v4, v128)
                                else
                                    let v131 : US8 = US8_0
                                    method16(v0, v1, v109, v4, v131)
                        else
                            let v138 : bool = '\\' = v108
                            if v138 then
                                let v139 : uint8 = 1uy
                                let v140 : US8 = US8_2(v139)
                                method16(v0, v1, v109, v4, v140)
                            else
                                let v143 : US8 = US8_2(0uy)
                                let v144 : bool = v3 = v143
                                if v144 then
                                    let v145 : string = $"{v0}\""
                                    let v146 : char = '"'
                                    let v147 : US8 = US8_1(v146)
                                    method16(v145, v1, v109, v4, v147)
                                else
                                    let v150 : UH1 = UH1_0
                                    let v151 : UH1 = UH1_1(v0, v150)
                                    let v152 : UH1 = method18(v1, v151)
                                    let v153 : string = ""
                                    let v154 : US8 = US8_0
                                    method16(v153, v152, v109, v4, v154)
                else
                    let v165 : bool = '\\' = v106
                    if v165 then
                        let v166 : bool = '\\' = v108
                        if v166 then
                            let v167 : uint8 = 1uy
                            let v168 : US8 = US8_2(v167)
                            method16(v0, v1, v109, v4, v168)
                        else
                            let v171 : bool = ' ' = v108
                            if v171 then
                                let v172 : string = $"{v0} "
                                method17(v172, v1, v109, v4)
                            else
                                let v175 : string = $"{v0}{v108}"
                                method17(v175, v1, v109, v4)
                    else
                        let v182 : bool = '\\' = v108
                        if v182 then
                            let v183 : uint8 = 1uy
                            let v184 : US8 = US8_2(v183)
                            method16(v0, v1, v109, v4, v184)
                        else
                            let v187 : bool = ' ' = v108
                            if v187 then
                                let v188 : string = $"{v0} "
                                method17(v188, v1, v109, v4)
                            else
                                let v191 : string = $"{v0}{v108}"
                                method17(v191, v1, v109, v4)
            | _ ->
                let v202 : bool = '\\' = v106
                if v202 then
                    let v204 : bool = v0 = ""
                    let v208 : UH1 =
                        if v204 then
                            v1
                        else
                            let v205 : UH1 = UH1_0
                            let v206 : UH1 = UH1_1(v0, v205)
                            method18(v1, v206)
                    struct (v208, v0)
                else
                    let v210 : bool = v0 = ""
                    let v214 : UH1 =
                        if v210 then
                            v1
                        else
                            let v211 : UH1 = UH1_0
                            let v212 : UH1 = UH1_1(v0, v211)
                            method18(v1, v212)
                    struct (v214, v0)
        else
            let v219 : bool = '\\' = v106
            if v219 then
                match v2 with
                | UH0_1(v220, v221) -> (* Cons *)
                    let v222 : bool = '"' = v220
                    if v222 then
                        let v223 : US8 = US8_2(0uy)
                        let v224 : bool = v3 <> v223
                        if v224 then
                            let v225 : string = $"{v0}\""
                            let v226 : char = '"'
                            let v227 : US8 = US8_1(v226)
                            method16(v225, v1, v221, v4, v227)
                        else
                            let v230 : US8 = US8_1('\\')
                            let v231 : bool = v3 = v230
                            if v231 then
                                let v232 : string = $"{v0}\""
                                let v233 : char = '"'
                                let v234 : US8 = US8_1(v233)
                                method16(v232, v1, v221, v4, v234)
                            else
                                let v237 : US8 = US8_0
                                method16(v0, v1, v221, v4, v237)
                    else
                        let v244 : bool = '\\' = v220
                        if v244 then
                            let v245 : uint8 = 1uy
                            let v246 : US8 = US8_2(v245)
                            method16(v0, v1, v221, v4, v246)
                        else
                            let v249 : bool = ' ' = v220
                            if v249 then
                                let v250 : string = $"{v0} "
                                method17(v250, v1, v221, v4)
                            else
                                let v253 : string = $"{v0}{v220}"
                                method17(v253, v1, v221, v4)
                | _ ->
                    let v263 : bool = v0 = ""
                    let v267 : UH1 =
                        if v263 then
                            v1
                        else
                            let v264 : UH1 = UH1_0
                            let v265 : UH1 = UH1_1(v0, v264)
                            method18(v1, v265)
                    struct (v267, v0)
            else
                match v2 with
                | UH0_1(v270, v271) -> (* Cons *)
                    let v272 : bool = '\\' = v270
                    if v272 then
                        let v273 : uint8 = 1uy
                        let v274 : US8 = US8_2(v273)
                        method16(v0, v1, v271, v4, v274)
                    else
                        let v277 : bool = '"' = v270
                        if v277 then
                            let v278 : US8 = US8_2(0uy)
                            let v279 : bool = v3 = v278
                            if v279 then
                                let v280 : string = $"{v0}\""
                                let v281 : char = '"'
                                let v282 : US8 = US8_1(v281)
                                method16(v280, v1, v271, v4, v282)
                            else
                                let v285 : UH1 = UH1_0
                                let v286 : UH1 = UH1_1(v0, v285)
                                let v287 : UH1 = method18(v1, v286)
                                let v288 : string = ""
                                let v289 : US8 = US8_0
                                method16(v288, v287, v271, v4, v289)
                        else
                            let v294 : bool = ' ' = v270
                            if v294 then
                                let v295 : string = $"{v0} "
                                method17(v295, v1, v271, v4)
                            else
                                let v298 : string = $"{v0}{v270}"
                                method17(v298, v1, v271, v4)
                | _ ->
                    let v308 : bool = v0 = ""
                    let v312 : UH1 =
                        if v308 then
                            v1
                        else
                            let v309 : UH1 = UH1_0
                            let v310 : UH1 = UH1_1(v0, v309)
                            method18(v1, v310)
                    struct (v312, v0)
    | US8_0 -> (* Start *)
        match v2 with
        | UH0_1(v5, v6) -> (* Cons *)
            let v7 : bool = '"' = v5
            if v7 then
                let v8 : string = ""
                let v9 : char = '"'
                let v10 : US8 = US8_1(v9)
                method16(v8, v1, v6, v4, v10)
            else
                let v13 : bool = '\\' = v5
                if v13 then
                    let v14 : uint8 = 0uy
                    let v15 : US8 = US8_2(v14)
                    method16(v0, v1, v6, v4, v15)
                else
                    let v18 : bool = ' ' = v5
                    if v18 then
                        let v20 : bool = v0 = ""
                        let v24 : UH1 =
                            if v20 then
                                v1
                            else
                                let v21 : UH1 = UH1_0
                                let v22 : UH1 = UH1_1(v0, v21)
                                method18(v1, v22)
                        let v25 : string = ""
                        method17(v25, v24, v6, v4)
                    else
                        let v28 : string = $"{v0}{v5}"
                        method17(v28, v1, v6, v4)
        | _ ->
            let v38 : bool = v0 = ""
            let v42 : UH1 =
                if v38 then
                    v1
                else
                    let v39 : UH1 = UH1_0
                    let v40 : UH1 = UH1_1(v0, v39)
                    method18(v1, v40)
            struct (v42, v0)
and method19 (v0 : UH1, v1 : string list) : string list =
    match v0 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string list = method19(v3, v1)
        let v5 : string list = v2 :: v4 
        v5
    | UH1_0 -> (* Nil *)
        v1
and method15 (v0 : string) : (string []) =
    let v1 : UH1 = UH1_0
    let v2 : string = ""
    let v3 : bool = true in let mutable _v0 = None
    #if !FABLE_COMPILER && !WASM && !CONTRACT
    let v4 : (string -> string option) = Option.ofObj
    let v5 : string option = v4 v0
    v5 
    #else
    Some v0 
    #endif
    |> fun x -> _v0 <- Some x
    let v6 : string option = _v0.Value
    let v7 : (string -> US4) = method6()
    let v8 : US4 = US4_1
    let v9 : US4 = v6 |> Option.map v7 |> Option.defaultValue v8 
    let v12 : string =
        match v9 with
        | US4_1 -> (* None *)
            v2
        | US4_0(v10) -> (* Some *)
            v10
    let v13 : int32 = v12.Length
    let v14 : (char []) = Array.zeroCreate<char> (v13)
    let v15 : Mut4 = {l0 = 0} : Mut4
    while method3(v13, v15) do
        let v17 : int32 = v15.l0
        let v18 : char = v12.[int v17]
        v14.[int v17] <- v18
        let v19 : int32 = v17 + 1
        v15.l0 <- v19
        ()
    let v20 : ((char []) -> char list) = Array.toList
    let v21 : char list = v20 v14
    let v22 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v23 : (char -> (UH0 -> UH0)) = method4()
    let v24 : (char list -> (UH0 -> UH0)) = v22 v23
    let v25 : (UH0 -> UH0) = v24 v21
    let v26 : UH0 = UH0_0
    let v27 : UH0 = v25 v26
    let v28 : US8 = US8_0
    let v29 : US8 = US8_0
    let struct (v30 : UH1, v31 : string) = method16(v2, v1, v27, v29, v28)
    let v32 : string list = []
    let v33 : string list = method19(v30, v32)
    let v34 : (string list -> (string [])) = List.toArray
    let v35 : (string []) = v34 v33
    v35
and closure21 () (v0 : string) : (string []) =
    method15(v0)
let v0 : (unit -> struct (Mut0 * Mut1 * Mut2 * int64 option * Mut3)) = closure0()
if State.trace_state.IsNone then State.trace_state <- v0 () |> Some
let v1 : (unit -> bool) = closure2()
let is_windows () = v1 ()
let v2 : (unit -> string) = closure3()
let get_executable_suffix () = v2 ()
let v3 : (string -> Async<struct (int32 * string)>) = closure4()
let execute_async x = v3 x
let v4 : (struct (System.Threading.CancellationToken option * string * (struct (bool * string * int32) -> Async<unit>) option * string option) -> Async<struct (int32 * string)>) = closure20()
let execute_with_options_async x = v4 x
let v5 : (string -> (string [])) = closure21()
let split_args x = v5 x
()
