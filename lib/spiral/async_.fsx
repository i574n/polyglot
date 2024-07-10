let rec closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    let v3 : bool = true
    let mutable _v3 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v42 
    #endif
#else
    let v51 : bool = true
    let mutable _v51 : Async<System.Threading.CancellationToken> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v54 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v54 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v63 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v63 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v72 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v72 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v81 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v81 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    v90 
    #endif
#else
    let v97 : Async<System.Threading.CancellationToken> option = None
    let mutable _v97 = v97 
    async {
    let v98 : Async<System.Threading.CancellationToken> = Async.CancellationToken
    let! v98 = v98 
    let v99 : System.Threading.CancellationToken = v98 
    let v100 : System.Threading.CancellationToken = Async.DefaultCancellationToken
    let v101 : (System.Threading.CancellationToken []) = [|v99; v100; v0|]
    let v102 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
    let v103 : System.Threading.CancellationTokenSource = v102 v101
    let v104 : System.Threading.CancellationToken = v103.Token
    return v104 
    }
    |> fun x -> _v97 <- Some x
    let v105 : Async<System.Threading.CancellationToken> = match _v97 with Some x -> x | None -> failwith "async.new_async_unit / _v97=None"
    v105 
    #endif
    |> fun x -> _v51 <- Some x
    let v106 : Async<System.Threading.CancellationToken> = match _v51 with Some x -> x | None -> failwith "base.run_target / _v51=None"
    v106 
    #endif
    |> fun x -> _v3 <- Some x
    let v121 : Async<System.Threading.CancellationToken> = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v121
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
