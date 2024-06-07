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
    let v0 : bool = true
    let mutable _v0 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "cfg!(windows)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = "cfg!(windows)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US0 = US0_0
    let v8 : US1 = US1_3(v7)
    let v9 : string = $"platform.is_windows / target: {v8}"
    let v10 : bool = failwith<bool> v9
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US0 = US0_0
    let v12 : US1 = US1_4(v11)
    let v13 : string = $"platform.is_windows / target: {v12}"
    let v14 : bool = failwith<bool> v13
    v14 
    #endif
#else
    let v15 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v16 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v17 : bool = v16 v15
    v17 
    #endif
    |> fun x -> _v0 <- Some x
    let v18 : bool = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    v18
and closure1 () () : string =
    let v0 : bool = true
    let mutable _v0 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1 : string = "cfg!(windows)"
    let v2 : bool = Fable.Core.RustInterop.emitRustExpr () v1 
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    v4 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = "cfg!(windows)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : US0 = US0_0
    let v8 : US1 = US1_3(v7)
    let v9 : string = $"platform.is_windows / target: {v8}"
    let v10 : bool = failwith<bool> v9
    v10 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : US0 = US0_0
    let v12 : US1 = US1_4(v11)
    let v13 : string = $"platform.is_windows / target: {v12}"
    let v14 : bool = failwith<bool> v13
    v14 
    #endif
#else
    let v15 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v16 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v17 : bool = v16 v15
    v17 
    #endif
    |> fun x -> _v0 <- Some x
    let v18 : bool = match _v0 with Some x -> x | None -> failwith "base.run_target / _v0=None"
    if v18 then
        let v19 : string = ".exe"
        v19
    else
        let v20 : string = ""
        v20
let v0 : (unit -> bool) = closure0()
let is_windows () = v0 ()
let v1 : (unit -> string) = closure1()
let get_executable_suffix () = v1 ()
()
