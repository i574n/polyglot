#if FABLE_COMPILER // async.types
[<Fable.Core.Erase; Fable.Core.Emit("std::future::Future<Output = $0>")>] type Future<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("futures::future::TryJoinAll<$0>")>] type TryJoinAll<'T> = class end
#endif // async.types
let rec closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v1 : Async<System.Threading.CancellationToken> option = None
    let v2 : bool = true in let mutable _v1 = v1
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : Async<System.Threading.CancellationToken> option = None
    let v7 : bool = true in let mutable _v6 = v6
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
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v11 : Async<System.Threading.CancellationToken> option = None
    let mutable _v11 = v11
    async {
    let v12 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v12 = v12 
    let v13 : System.Threading.CancellationToken = v12 
    let v14 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v15 : (System.Threading.CancellationToken []) = [|v13; v14; v0|]
    let v16 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v17 : System.Threading.CancellationTokenSource = v16 v15
    let v18 : System.Threading.CancellationToken = v17.Token
    return v18 
    }
    |> fun x -> _v11 <- Some x
    let v19 : Async<System.Threading.CancellationToken> = _v11 |> Option.get
    v19
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v20 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v20
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v21 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v21
#endif
    |> fun x -> _v6 <- Some x
    let v22 : Async<System.Threading.CancellationToken> = _v6.Value
    v22
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v23 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v23
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v24 : Async<System.Threading.CancellationToken> = Unchecked.defaultof<Async<System.Threading.CancellationToken>>
    v24
#endif
    |> fun x -> _v1 <- Some x
    let v25 : Async<System.Threading.CancellationToken> = _v1.Value
    v25
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
