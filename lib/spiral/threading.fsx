#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::thread::JoinHandle<$0>")>]
#endif
type std_thread_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>]
#endif
type std_sync_Arc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Mutex<$0>")>]
#endif
type std_sync_Mutex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::MutexGuard<$0>")>]
#endif
type std_sync_MutexGuard<'T> = class end
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 () (v0 : System.Threading.CancellationToken) : US0 =
    US0_0(v0)
and method0 () : (System.Threading.CancellationToken -> US0) =
    closure1()
and closure2 (v0 : System.Threading.CancellationTokenSource) () : unit =
    let v1 : unit option = None
    let v2 : bool = true in let mutable _v1 = v1
    
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
    let v3 : (unit -> unit) = v0.Cancel
    v3 ()
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
    |> fun x -> _v1 <- Some x
    _v1.Value
    ()
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure2(v0)
and closure0 () (v0 : System.Threading.CancellationToken option) : struct (System.Threading.CancellationToken * System.IDisposable) =
    let v1 : struct (System.Threading.CancellationToken * System.IDisposable) option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v3 : System.Threading.CancellationToken, v4 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v3, v4)
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let struct (v5 : System.Threading.CancellationToken, v6 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v5, v6)
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v7 : System.Threading.CancellationToken, v8 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v7, v8)
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v9 : System.Threading.CancellationTokenSource = new System.Threading.CancellationTokenSource ()
    let v10 : (System.Threading.CancellationToken -> US0) = method0()
    let v11 : US0 = US0_1
    let v12 : US0 = v0 |> Option.map v10 |> Option.defaultValue v11 
    let v19 : System.Threading.CancellationTokenSource =
        match v12 with
        | US0_1 -> (* None *)
            v9
        | US0_0(v13) -> (* Some *)
            let v14 : System.Threading.CancellationToken = v9.Token
            let v15 : (System.Threading.CancellationToken []) = [|v14; v13|]
            let v16 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v16 v15
    let v20 : System.IDisposable option = None
    let v21 : bool = true in let mutable _v20 = v20
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v22 : (unit -> unit) = closure2(v19)
    let v23 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v22 "$0()" )
    v23
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v24 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v22 "$0()" )
    v24
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v22 "$0()" )
    v25
#endif
    
#if !FABLE_COMPILER && !WASM && !CONTRACT
    let v26 : (unit -> unit) = method1(v19)
    let v27 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v26 () }
    v27
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v28 : System.IDisposable = null |> unbox<System.IDisposable>
    v28
#endif
    
#if FABLE_COMPILER_PYTHON
    let v29 : System.IDisposable = null |> unbox<System.IDisposable>
    v29
#endif
    |> fun x -> _v20 <- Some x
    let v30 : System.IDisposable = _v20.Value
    let v31 : System.Threading.CancellationToken = v19.Token
    struct (v31, v30)
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v32 : System.Threading.CancellationToken, v33 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v32, v33)
#endif
    
#if FABLE_COMPILER_PYTHON
    let struct (v34 : System.Threading.CancellationToken, v35 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v34, v35)
#endif
    |> fun x -> _v1 <- Some x
    let struct (v36 : System.Threading.CancellationToken, v37 : System.IDisposable) = _v1.Value
    struct (v36, v37)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
