type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 () (v0 : System.Threading.CancellationToken) : US0 =
    US0_0(v0)
and method0 () : (System.Threading.CancellationToken -> US0) =
    closure1()
and closure2 (v0 : System.Threading.CancellationTokenSource) () : unit =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    let _v1 = () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    let _v1 = () 
    #endif
#else
    let v2 : (unit -> unit) = v0.Cancel
    v2 ()
    let _v1 = () 
    #endif
    _v1 
    ()
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure2(v0)
and method2 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure2(v0)
and closure0 () (v0 : System.Threading.CancellationToken option) : struct (System.Threading.CancellationToken * System.IDisposable) =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : System.Threading.CancellationToken, v3 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v8 : System.Threading.CancellationToken, v9 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _v1 = struct (v8, v9) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v14 : System.Threading.CancellationToken, v15 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _v1 = struct (v14, v15) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v20 : System.Threading.CancellationToken, v21 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _v1 = struct (v20, v21) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v26 : System.Threading.CancellationToken, v27 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _v1 = struct (v26, v27) 
    #endif
#else
    let v32 : System.Threading.CancellationTokenSource = new System.Threading.CancellationTokenSource ()
    let v33 : (System.Threading.CancellationToken -> US0) = method0()
    let v34 : US0 option = v0 |> Option.map v33 
    let v45 : US0 = US0_1
    let v46 : US0 = v34 |> Option.defaultValue v45 
    let v56 : System.Threading.CancellationTokenSource =
        match v46 with
        | US0_1 -> (* None *)
            v32
        | US0_0(v50) -> (* Some *)
            let v51 : System.Threading.CancellationToken = v32.Token
            let v52 : (System.Threading.CancellationToken []) = [|v51; v50|]
            let v53 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v53 v52
    let v57 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v58 : (unit -> unit) = method1(v56)
    let v59 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v58 "$0()" )
    let _v57 = v59 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v60 : (unit -> unit) = method1(v56)
    let v61 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v60 "$0()" )
    let _v57 = v61 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v62 : (unit -> unit) = method1(v56)
    let v63 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v62 "$0()" )
    let _v57 = v63 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v64 : (unit -> unit) = method2(v56)
    let v65 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v64 () }
    let _v57 = v65 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : (unit -> unit) = method2(v56)
    let v67 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v66 () }
    let _v57 = v67 
    #endif
#else
    let v68 : (unit -> unit) = method2(v56)
    let v69 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v68 () }
    let _v57 = v69 
    #endif
    let v70 : System.IDisposable = _v57 
    let v74 : System.Threading.CancellationToken = v56.Token
    let _v1 = struct (v74, v70) 
    #endif
    let struct (v75 : System.Threading.CancellationToken, v76 : System.IDisposable) = _v1 
    struct (v75, v76)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
