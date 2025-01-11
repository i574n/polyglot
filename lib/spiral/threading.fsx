type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 () (v0 : System.Threading.CancellationToken) : US0 =
    US0_0(v0)
and method0 () : (System.Threading.CancellationToken -> US0) =
    closure1()
and closure2 (v0 : System.Threading.CancellationTokenSource) () : unit =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    #endif
#else
    let v2 : (unit -> unit) = v0.Cancel
    v2 ()
    #endif
    // run_target_args' is_unit
    ()
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure2(v0)
and method2 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure2(v0)
and closure0 () (v0 : System.Threading.CancellationToken option) : struct (System.Threading.CancellationToken * System.IDisposable) =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v2 : System.Threading.CancellationToken, v3 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _run_target_args'_v1 = struct (v2, v3) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v8 : System.Threading.CancellationToken, v9 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _run_target_args'_v1 = struct (v8, v9) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v14 : System.Threading.CancellationToken, v15 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _run_target_args'_v1 = struct (v14, v15) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v20 : System.Threading.CancellationToken, v21 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _run_target_args'_v1 = struct (v20, v21) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v26 : System.Threading.CancellationToken, v27 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _run_target_args'_v1 = struct (v26, v27) 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let struct (v32 : System.Threading.CancellationToken, v33 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    let _run_target_args'_v1 = struct (v32, v33) 
    #endif
#else
    let v38 : System.Threading.CancellationTokenSource = new System.Threading.CancellationTokenSource ()
    let v39 : (System.Threading.CancellationToken -> US0) = method0()
    let v40 : US0 option = v0 |> Option.map v39 
    let v51 : US0 = US0_1
    let v52 : US0 = v40 |> Option.defaultValue v51 
    let v62 : System.Threading.CancellationTokenSource =
        match v52 with
        | US0_1 -> (* None *)
            v38
        | US0_0(v56) -> (* Some *)
            let v57 : System.Threading.CancellationToken = v38.Token
            let v58 : (System.Threading.CancellationToken []) = [|v57; v56|]
            let v59 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v59 v58
    (* run_target_args'
    let v63 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : (unit -> unit) = method1(v62)
    let v65 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v64 "$0()" )
    let _run_target_args'_v63 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : (unit -> unit) = method1(v62)
    let v67 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v66 "$0()" )
    let _run_target_args'_v63 = v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v68 : (unit -> unit) = method1(v62)
    let v69 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v68 "$0()" )
    let _run_target_args'_v63 = v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : (unit -> unit) = method2(v62)
    let v71 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v70 () }
    let _run_target_args'_v63 = v71 
    #endif
#if FABLE_COMPILER_PYTHON
    let v72 : (unit -> unit) = method2(v62)
    let v73 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v72 () }
    let _run_target_args'_v63 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v74 : (unit -> unit) = method2(v62)
    let v75 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v74 () }
    let _run_target_args'_v63 = v75 
    #endif
#else
    let v76 : (unit -> unit) = method2(v62)
    let v77 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v76 () }
    let _run_target_args'_v63 = v77 
    #endif
    let v78 : System.IDisposable = _run_target_args'_v63 
    let v82 : System.Threading.CancellationToken = v62.Token
    let _run_target_args'_v1 = struct (v82, v78) 
    #endif
    let struct (v83 : System.Threading.CancellationToken, v84 : System.IDisposable) = _run_target_args'_v1 
    struct (v83, v84)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
