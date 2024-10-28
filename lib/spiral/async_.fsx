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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v1 = v17 
    #endif
#else
    let v20 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v21 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v20 = v21 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v20 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v20 = v27 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v30 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v20 = v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v33 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _v20 = v33 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v36 : unit = ()
    let _v36 =
        async {
            let v37 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v37 = v37 
            let v38 : System.Threading.CancellationToken = v37 
            let v39 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v40 : (System.Threading.CancellationToken []) = [|v38; v39; v0|]
            let v41 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v42 : System.Threading.CancellationTokenSource = v41 v40
            let v43 : System.Threading.CancellationToken = v42.Token
            return v43 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v44 : Async<System.Threading.CancellationToken> = _v36 
    let _v20 = v44 
    #endif
#else
    let v45 : unit = ()
    let _v45 =
        async {
            let v46 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v46 = v46 
            let v47 : System.Threading.CancellationToken = v46 
            let v48 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v49 : (System.Threading.CancellationToken []) = [|v47; v48; v0|]
            let v50 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v51 : System.Threading.CancellationTokenSource = v50 v49
            let v52 : System.Threading.CancellationToken = v51.Token
            return v52 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v53 : Async<System.Threading.CancellationToken> = _v45 
    let _v20 = v53 
    #endif
    let v54 : Async<System.Threading.CancellationToken> = _v20 
    let _v1 = v54 
    #endif
    let v59 : Async<System.Threading.CancellationToken> = _v1 
    v59
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
