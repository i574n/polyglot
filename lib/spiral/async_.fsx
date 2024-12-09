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
            let v33 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v33 = v33 
            let v34 : System.Threading.CancellationToken = v33 
            let v35 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v36 : (System.Threading.CancellationToken []) = [|v34; v35; v0|]
            let v37 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v38 : System.Threading.CancellationTokenSource = v37 v36
            let v39 : System.Threading.CancellationToken = v38.Token
            return v39 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v89 : Async<System.Threading.CancellationToken> = _v30 
    let _v20 = v89 
    #endif
#if FABLE_COMPILER_PYTHON
    let v90 : unit = ()
    let _v90 =
        async {
            let v93 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v93 = v93 
            let v94 : System.Threading.CancellationToken = v93 
            let v95 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v96 : (System.Threading.CancellationToken []) = [|v94; v95; v0|]
            let v97 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v98 : System.Threading.CancellationTokenSource = v97 v96
            let v99 : System.Threading.CancellationToken = v98.Token
            return v99 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v149 : Async<System.Threading.CancellationToken> = _v90 
    let _v20 = v149 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v150 : unit = ()
    let _v150 =
        async {
            let v153 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v153 = v153 
            let v154 : System.Threading.CancellationToken = v153 
            let v155 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v156 : (System.Threading.CancellationToken []) = [|v154; v155; v0|]
            let v157 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v158 : System.Threading.CancellationTokenSource = v157 v156
            let v159 : System.Threading.CancellationToken = v158.Token
            return v159 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v209 : Async<System.Threading.CancellationToken> = _v150 
    let _v20 = v209 
    #endif
#else
    let v210 : unit = ()
    let _v210 =
        async {
            let v213 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v213 = v213 
            let v214 : System.Threading.CancellationToken = v213 
            let v215 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v216 : (System.Threading.CancellationToken []) = [|v214; v215; v0|]
            let v217 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v218 : System.Threading.CancellationTokenSource = v217 v216
            let v219 : System.Threading.CancellationToken = v218.Token
            return v219 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v269 : Async<System.Threading.CancellationToken> = _v210 
    let _v20 = v269 
    #endif
    let v270 : Async<System.Threading.CancellationToken> = _v20 
    let _v1 = v270 
    #endif
    let v304 : Async<System.Threading.CancellationToken> = _v1 
    v304
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
