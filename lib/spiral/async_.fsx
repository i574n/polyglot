#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>]
#endif
type std_future_Future<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>]
#endif
type futures_future_TryJoinAll<'T> = class end
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
let rec closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v1 : Async<System.Threading.CancellationToken> option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v3
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v4 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v4
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v5 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v5
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v6 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v6
#endif
    
#if FABLE_COMPILER_PYTHON
    let v7 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v7
#endif
    
#else
    let v8 : Async<System.Threading.CancellationToken> option = None
    let v9 : bool = true in let mutable _v8 = v8
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v10
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v11 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v11
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v12 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v12
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v13
#endif
    
#if FABLE_COMPILER_PYTHON
    let v14 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v14
#endif
    
#else
    let v15 : Async<System.Threading.CancellationToken> option = None
    let mutable _v15 = v15
    async {
    let v16 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v16 = v16 
    let v17 : System.Threading.CancellationToken = v16 
    let v18 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v19 : (System.Threading.CancellationToken []) = [|v17; v18; v0|]
    let v20 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v21 : System.Threading.CancellationTokenSource = v20 v19
    let v22 : System.Threading.CancellationToken = v21.Token
    return v22 
    }
    |> fun x -> _v15 <- Some x
    let v23 : Async<System.Threading.CancellationToken> = _v15 |> Option.get
    v23
#endif
    |> fun x -> _v8 <- Some x
    let v24 : Async<System.Threading.CancellationToken> = _v8.Value
    v24
#endif
    |> fun x -> _v1 <- Some x
    let v25 : Async<System.Threading.CancellationToken> = _v1.Value
    v25
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
