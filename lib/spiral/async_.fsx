let rec closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v14 
    #endif
#else
    let v17 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v17 = v18 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v21 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v17 = v21 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v17 = v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v27 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v17 = v27 
    #endif
#if FABLE_COMPILER_PYTHON
    let v30 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v17 = v30 
    #endif
#else
    let v33 : Async<System.Threading.CancellationToken> option = None
    let mutable _v33 = v33 
    async {
    let v34 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v34 = v34 
    let v35 : System.Threading.CancellationToken = v34 
    let v36 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v37 : (System.Threading.CancellationToken []) = [|v35; v36; v0|]
    let v38 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v39 : System.Threading.CancellationTokenSource = v38 v37
    let v40 : System.Threading.CancellationToken = v39.Token
    return v40 
    }
    |> fun x -> _v33 <- Some x
    let v41 : Async<System.Threading.CancellationToken> = match _v33 with Some x -> x | None -> failwith "async.new_async_unit / _v33=None"
    let _v17 = v41 
    #endif
    let v42 : Async<System.Threading.CancellationToken> = _v17 
    let _v1 = v42 
    #endif
    let v47 : Async<System.Threading.CancellationToken> = _v1 
    v47
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
