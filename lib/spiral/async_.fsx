#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("async_std::task::JoinHandle<$0>")>]
#endif
type async_std_task_JoinHandle<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::vec::IntoIter<$0>")>]
#endif
type rayon_vec_IntoIter<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("rayon::iter::Map<$0, _>")>]
#endif
type rayon_iter_Map<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures_lite::stream::StreamExt")>]
#endif
type futures_lite_stream_StreamExt = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::Fuse<$0>")>]
#endif
type futures_future_Fuse<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::JoinAll<$0>")>]
#endif
type futures_future_JoinAll<'T> = class end
let rec closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v1 : bool = true
    let mutable _v1 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v6 
    #endif
#else
    let v7 : bool = true
    let mutable _v7 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v8 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v9 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v10 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v10 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v12 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v12 
    #endif
#else
    let v13 : Async<System.Threading.CancellationToken> option = None
    let mutable _v13 = v13
    async {
    let v14 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v14 = v14 
    let v15 : System.Threading.CancellationToken = v14 
    let v16 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v17 : (System.Threading.CancellationToken []) = [|v15; v16; v0|]
    let v18 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v19 : System.Threading.CancellationTokenSource = v18 v17
    let v20 : System.Threading.CancellationToken = v19.Token
    return v20 
    }
    |> fun x -> _v13 <- Some x
    let v21 : Async<System.Threading.CancellationToken> = _v13 |> Option.get
    v21 
    #endif
    |> fun x -> _v7 <- Some x
    let v22 : Async<System.Threading.CancellationToken> = _v7.Value
    v22 
    #endif
    |> fun x -> _v1 <- Some x
    let v23 : Async<System.Threading.CancellationToken> = _v1.Value
    v23
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
