type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 () (v0 : System.Threading.CancellationToken) : US0 =
    US0_0(v0)
and method0 () : (System.Threading.CancellationToken -> US0) =
    closure1()
and closure2 (v0 : System.Threading.CancellationTokenSource) () : unit =
    let v1 : unit option = None
    let mutable _v1 = v1
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
    let v2 : (unit -> unit) = v0.Cancel
    v2 ()
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
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and closure0 () (v0 : System.Threading.CancellationToken option) : struct (System.Threading.CancellationToken * System.IDisposable) =
    let v1 : struct (System.Threading.CancellationToken * System.IDisposable) option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : System.Threading.CancellationToken, v3 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v2, v3) 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let struct (v4 : System.Threading.CancellationToken, v5 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v4, v5) 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let struct (v6 : System.Threading.CancellationToken, v7 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v6, v7) 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v8 : System.Threading.CancellationTokenSource = new System.Threading.CancellationTokenSource ()
    let v9 : (System.Threading.CancellationToken -> US0) = method0()
    let v10 : US0 = US0_1
    let v11 : US0 = v0 |> Option.map v9 |> Option.defaultValue v10 
    let v18 : System.Threading.CancellationTokenSource =
        match v11 with
        | US0_1 -> (* None *)
            v8
        | US0_0(v12) -> (* Some *)
            let v13 : System.Threading.CancellationToken = v8.Token
            let v14 : (System.Threading.CancellationToken []) = [|v13; v12|]
            let v15 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v15 v14
    let v19 : System.IDisposable option = None
    let mutable _v19 = v19
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v20 : System.IDisposable = null |> unbox<System.IDisposable>
    v20 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v21 : System.IDisposable = null |> unbox<System.IDisposable>
    v21 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v22 : System.IDisposable = null |> unbox<System.IDisposable>
    v22 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v23 : (unit -> unit) = closure2(v18)
    let v24 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v23 () }
    v24 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v25 : System.IDisposable = null |> unbox<System.IDisposable>
    v25 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v26 : System.IDisposable = Unchecked.defaultof<System.IDisposable>
    v26 
    #endif
    |> fun x -> _v19 <- Some x
    let v27 : System.IDisposable = _v19.Value
    let v28 : System.Threading.CancellationToken = v18.Token
    struct (v28, v27) 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let struct (v29 : System.Threading.CancellationToken, v30 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v29, v30) 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let struct (v31 : System.Threading.CancellationToken, v32 : System.IDisposable) = Unchecked.defaultof<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v31, v32) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v33 : System.Threading.CancellationToken, v34 : System.IDisposable) = _v1.Value
    struct (v33, v34)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
