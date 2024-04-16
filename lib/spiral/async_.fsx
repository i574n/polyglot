#if FABLE_COMPILER // async.types
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>] type Future<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>] type TryJoinAll<'T> = class end
#endif // async.types
let rec closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v1 : Async<System.Threading.CancellationToken> option = None
    let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : Async<System.Threading.CancellationToken> option = None
    let mutable _v5 = v5
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v6 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v7 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v8 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v9 : Async<System.Threading.CancellationToken> option = None
    let mutable _v9 = v9
    async {
    let v10 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v10 = v10 
    let v11 : System.Threading.CancellationToken = v10 
    let v12 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v13 : (System.Threading.CancellationToken []) = [|v11; v12; v0|]
    let v14 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v15 : System.Threading.CancellationTokenSource = v14 v13
    let v16 : System.Threading.CancellationToken = v15.Token
    return v16 
    }
    |> fun x -> _v9 <- Some x
    let v17 : Async<System.Threading.CancellationToken> = _v9 |> Option.get
    v17 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v18 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v18 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v19 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v19 
    #endif
    |> fun x -> _v5 <- Some x
    let v20 : Async<System.Threading.CancellationToken> = _v5.Value
    v20 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v21 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v21 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v22 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v22 
    #endif
    |> fun x -> _v1 <- Some x
    let v23 : Async<System.Threading.CancellationToken> = _v1.Value
    v23
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
