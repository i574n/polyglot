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
    let v2 : bool = true
    let mutable _v2 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "cfg!(windows)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "cfg!(windows)"
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr () v7 
    v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : US0 = US0_0
    let v10 : US1 = US1_3(v9)
    let v11 : string = $"platform.is_windows / target: {v10}"
    let v12 : bool = failwith<bool> v11
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : US0 = US0_0
    let v14 : US1 = US1_4(v13)
    let v15 : string = $"platform.is_windows / target: {v14}"
    let v16 : bool = failwith<bool> v15
    v16 
    #endif
#else
    let v17 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v18 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v19 : bool = v18 v17
    v19 
    #endif
    |> fun x -> _v2 <- Some x
    let v20 : bool = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v20
and closure1 () () : string =
    let v2 : bool = true
    let mutable _v2 : bool option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = "cfg!(windows)"
    let v4 : bool = Fable.Core.RustInterop.emitRustExpr () v3 
    v4 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = "cfg!(windows)"
    let v6 : bool = Fable.Core.RustInterop.emitRustExpr () v5 
    v6 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = "cfg!(windows)"
    let v8 : bool = Fable.Core.RustInterop.emitRustExpr () v7 
    v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : US0 = US0_0
    let v10 : US1 = US1_3(v9)
    let v11 : string = $"platform.is_windows / target: {v10}"
    let v12 : bool = failwith<bool> v11
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : US0 = US0_0
    let v14 : US1 = US1_4(v13)
    let v15 : string = $"platform.is_windows / target: {v14}"
    let v16 : bool = failwith<bool> v15
    v16 
    #endif
#else
    let v17 : System.Runtime.InteropServices.OSPlatform = System.Runtime.InteropServices.OSPlatform.Windows
    let v18 : (System.Runtime.InteropServices.OSPlatform -> bool) = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
    let v19 : bool = v18 v17
    v19 
    #endif
    |> fun x -> _v2 <- Some x
    let v20 : bool = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    if v20 then
        let v30 : string = ".exe"
        v30
    else
        let v31 : string = ""
        v31
let v0 : (unit -> bool) = closure0()
let is_windows () = v0 ()
let v1 : (unit -> string) = closure1()
let get_executable_suffix () = v1 ()
()
