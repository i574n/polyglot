type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1 of f1_0 : US0
    | US1_2 of f2_0 : US0
    | US1_3 of f3_0 : US0
    | US1_4 of f4_0 : US0
let rec closure0 () () : bool =
    (* run_target_args'
    let v0 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "cfg!(windows)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let _run_target_args'_v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let _run_target_args'_v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = "cfg!(windows)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    let _run_target_args'_v0 = v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US0 = US0_0
    let v8 : US1 = US1_3(v7)
    let v9 : string = $"platform.is_windows / target: {v8}"
    let v10 : bool = failwith<bool> v9
    let _run_target_args'_v0 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US0 = US0_0
    let v12 : US1 = US1_4(v11)
    let v13 : string = $"platform.is_windows / target: {v12}"
    let v14 : bool = failwith<bool> v13
    let _run_target_args'_v0 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v16 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v17 : bool = v16 v15
    let _run_target_args'_v0 = v17 
    #endif
#else
    let v18 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v19 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v20 : bool = v19 v18
    let _run_target_args'_v0 = v20 
    #endif
    let v21 : bool = _run_target_args'_v0 
    v21
and closure1 () () : string =
    (* run_target_args'
    let v0 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "cfg!(windows)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    let _run_target_args'_v0 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    let _run_target_args'_v0 = v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = "cfg!(windows)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    let _run_target_args'_v0 = v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US0 = US0_0
    let v8 : US1 = US1_3(v7)
    let v9 : string = $"platform.is_windows / target: {v8}"
    let v10 : bool = failwith<bool> v9
    let _run_target_args'_v0 = v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US0 = US0_0
    let v12 : US1 = US1_4(v11)
    let v13 : string = $"platform.is_windows / target: {v12}"
    let v14 : bool = failwith<bool> v13
    let _run_target_args'_v0 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v16 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v17 : bool = v16 v15
    let _run_target_args'_v0 = v17 
    #endif
#else
    let v18 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v19 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v20 : bool = v19 v18
    let _run_target_args'_v0 = v20 
    #endif
    let v21 : bool = _run_target_args'_v0 
    if v21 then
        let v27 : string = ".exe"
        v27
    else
        let v28 : string = ""
        v28
let v0 : (unit -> bool) = closure0()
let is_windows () = v0 ()
let v1 : (unit -> string) = closure1()
let get_executable_suffix () = v1 ()
()
