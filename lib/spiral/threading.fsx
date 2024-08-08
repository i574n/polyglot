type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 (v0 : System.Threading.CancellationTokenSource) () : unit =
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
and method0 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure1(v0)
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure1(v0)
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
    let v33 : US0 option = None
    let _v33 = ref v33 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v34 : System.Threading.CancellationToken = x
    let v35 : US0 = US0_0(v34)
    v35 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v33.Value <- x
    let v36 : US0 option = _v33.Value 
    let v47 : US0 = US0_1
    let v48 : US0 = v36 |> Option.defaultValue v47 
    let v58 : System.Threading.CancellationTokenSource =
        match v48 with
        | US0_1 -> (* None *)
            v32
        | US0_0(v52) -> (* Some *)
            let v53 : System.Threading.CancellationToken = v32.Token
            let v54 : (System.Threading.CancellationToken []) = [|v53; v52|]
            let v55 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v55 v54
    let v59 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v60 : (unit -> unit) = method0(v58)
    let v61 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v60 "$0()" )
    let _v59 = v61 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v62 : (unit -> unit) = method0(v58)
    let v63 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v62 "$0()" )
    let _v59 = v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v64 : (unit -> unit) = method0(v58)
    let v65 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v64 "$0()" )
    let _v59 = v65 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v66 : (unit -> unit) = method1(v58)
    let v67 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v66 () }
    let _v59 = v67 
    #endif
#if FABLE_COMPILER_PYTHON
    let v68 : (unit -> unit) = method1(v58)
    let v69 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v68 () }
    let _v59 = v69 
    #endif
#else
    let v70 : (unit -> unit) = method1(v58)
    let v71 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v70 () }
    let _v59 = v71 
    #endif
    let v72 : System.IDisposable = _v59 
    let v76 : System.Threading.CancellationToken = v58.Token
    let _v1 = struct (v76, v72) 
    #endif
    let struct (v77 : System.Threading.CancellationToken, v78 : System.IDisposable) = _v1 
    struct (v77, v78)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
