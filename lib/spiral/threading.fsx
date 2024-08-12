type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 (v0 : US0 option ref) (v1 : US0 option) : US0 option ref =
    v0.Value <- v1 
    v0
and closure2 (v0 : System.Threading.CancellationToken option, v1 : (US0 option -> US0 option ref)) () : unit =
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v2 : System.Threading.CancellationToken = x
    let v3 : US0 = US0_0(v2)
    v3 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> v1 |> ignore
    ()
and closure3 (v0 : System.Threading.CancellationTokenSource) () : unit =
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
    closure3(v0)
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure3(v0)
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
    let v34 : US0 option ref = _v33 
    let v35 : (US0 option -> US0 option ref) = closure1(v34)
    let v36 : unit = ()
    let v37 : (unit -> unit) = closure2(v0, v35)
    let v38 : unit = (fun () -> v37 (); v36) ()
    let v41 : US0 option = _v33.Value 
    let v52 : US0 = US0_1
    let v53 : US0 = v41 |> Option.defaultValue v52 
    let v63 : System.Threading.CancellationTokenSource =
        match v53 with
        | US0_1 -> (* None *)
            v32
        | US0_0(v57) -> (* Some *)
            let v58 : System.Threading.CancellationToken = v32.Token
            let v59 : (System.Threading.CancellationToken []) = [|v58; v57|]
            let v60 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v60 v59
    let v64 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v65 : (unit -> unit) = method0(v63)
    let v66 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v65 "$0()" )
    let _v64 = v66 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v67 : (unit -> unit) = method0(v63)
    let v68 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v67 "$0()" )
    let _v64 = v68 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v69 : (unit -> unit) = method0(v63)
    let v70 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v69 "$0()" )
    let _v64 = v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v71 : (unit -> unit) = method1(v63)
    let v72 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v71 () }
    let _v64 = v72 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : (unit -> unit) = method1(v63)
    let v74 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v73 () }
    let _v64 = v74 
    #endif
#else
    let v75 : (unit -> unit) = method1(v63)
    let v76 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v75 () }
    let _v64 = v76 
    #endif
    let v77 : System.IDisposable = _v64 
    let v81 : System.Threading.CancellationToken = v63.Token
    let _v1 = struct (v81, v77) 
    #endif
    let struct (v82 : System.Threading.CancellationToken, v83 : System.IDisposable) = _v1 
    struct (v82, v83)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
