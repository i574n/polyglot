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
    let v30 : unit = ()
    let _v30 =
        async {
            let v31 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v31 = v31 
            let v32 : System.Threading.CancellationToken = v31 
            let v33 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v34 : (System.Threading.CancellationToken []) = [|v32; v33; v0|]
            let v35 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v36 : System.Threading.CancellationTokenSource = v35 v34
            let v37 : System.Threading.CancellationToken = v36.Token
            return v37 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v38 : Async<System.Threading.CancellationToken> = _v30 
    let _v20 = v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v39 : unit = ()
    let _v39 =
        async {
            let v40 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v40 = v40 
            let v41 : System.Threading.CancellationToken = v40 
            let v42 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v43 : (System.Threading.CancellationToken []) = [|v41; v42; v0|]
            let v44 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v45 : System.Threading.CancellationTokenSource = v44 v43
            let v46 : System.Threading.CancellationToken = v45.Token
            return v46 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v47 : Async<System.Threading.CancellationToken> = _v39 
    let _v20 = v47 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v48 : unit = ()
    let _v48 =
        async {
            let v49 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v49 = v49 
            let v50 : System.Threading.CancellationToken = v49 
            let v51 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v52 : (System.Threading.CancellationToken []) = [|v50; v51; v0|]
            let v53 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v54 : System.Threading.CancellationTokenSource = v53 v52
            let v55 : System.Threading.CancellationToken = v54.Token
            return v55 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v56 : Async<System.Threading.CancellationToken> = _v48 
    let _v20 = v56 
    #endif
#else
    let v57 : unit = ()
    let _v57 =
        async {
            let v58 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v58 = v58 
            let v59 : System.Threading.CancellationToken = v58 
            let v60 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v61 : (System.Threading.CancellationToken []) = [|v59; v60; v0|]
            let v62 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v63 : System.Threading.CancellationTokenSource = v62 v61
            let v64 : System.Threading.CancellationToken = v63.Token
            return v64 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v65 : Async<System.Threading.CancellationToken> = _v57 
    let _v20 = v65 
    #endif
    let v66 : Async<System.Threading.CancellationToken> = _v20 
    let _v1 = v66 
    #endif
    let v71 : Async<System.Threading.CancellationToken> = _v1 
    v71
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
