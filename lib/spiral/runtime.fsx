let rec closure0 () () : bool =
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
and closure1 () () : string =
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
let v0 : (unit -> bool) = closure0()
let is_windows () = v0 ()
let v1 : (unit -> string) = closure1()
let get_executable_suffix () = v1 ()
()
