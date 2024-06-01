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
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::PoisonError<$0>")>]
#endif
type std_sync_PoisonError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Receiver<$0>")>]
#endif
type std_sync_mpsc_Receiver<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::SendError<$0>")>]
#endif
type std_sync_mpsc_SendError<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::mpsc::Sender<$0>")>]
#endif
type std_sync_mpsc_Sender<'T> = class end
type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 (v0 : System.Threading.CancellationTokenSource) () : unit =
    let v1 : bool = true
    let mutable _v1 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v2 : (unit -> unit) = v0.Cancel
    v2 ()
    () 
    #endif
    |> fun x -> _v1 <- Some x
    match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    ()
and method0 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure1(v0)
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure1(v0)
and closure0 () (v0 : System.Threading.CancellationToken option) : struct (System.Threading.CancellationToken * System.IDisposable) =
    let v1 : bool = true
    let mutable _v1 : struct (System.Threading.CancellationToken * System.IDisposable) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
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
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v8 : System.Threading.CancellationToken, v9 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v8, v9) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v10 : System.Threading.CancellationToken, v11 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v10, v11) 
    #endif
#else
    let v12 : System.Threading.CancellationTokenSource = new System.Threading.CancellationTokenSource ()
    let v13 : US0 option = None
    let _v13 = ref v13 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v14 : System.Threading.CancellationToken = x
    let v15 : US0 = US0_0(v14)
    v15 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v13.Value <- x
    let v16 : US0 option = _v13.Value 
    let v17 : US0 = US0_1
    let v18 : US0 = v16 |> Option.defaultValue v17 
    let v25 : System.Threading.CancellationTokenSource =
        match v18 with
        | US0_1 -> (* None *)
            v12
        | US0_0(v19) -> (* Some *)
            let v20 : System.Threading.CancellationToken = v12.Token
            let v21 : (System.Threading.CancellationToken []) = [|v20; v19|]
            let v22 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v22 v21
    let v26 : bool = true
    let mutable _v26 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : (unit -> unit) = method0(v25)
    let v28 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v27 "$0()" )
    v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : (unit -> unit) = method0(v25)
    let v30 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v29 "$0()" )
    v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : (unit -> unit) = method0(v25)
    let v32 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v31 "$0()" )
    v32 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : System.IDisposable = null |> unbox<System.IDisposable>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v34 : System.IDisposable = null |> unbox<System.IDisposable>
    v34 
    #endif
#else
    let v35 : (unit -> unit) = method1(v25)
    let v36 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v35 () }
    v36 
    #endif
    |> fun x -> _v26 <- Some x
    let v37 : System.IDisposable = match _v26 with Some x -> x | None -> failwith "base.run_target / _v26=None"
    let v38 : System.Threading.CancellationToken = v25.Token
    struct (v38, v37) 
    #endif
    |> fun x -> _v1 <- Some x
    let struct (v39 : System.Threading.CancellationToken, v40 : System.IDisposable) = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    struct (v39, v40)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
