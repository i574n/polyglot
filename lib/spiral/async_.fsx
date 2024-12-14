let rec method0 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
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
    let v11 : unit = ()
    let _v11 =
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
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v70 : Async<System.Threading.CancellationToken> = _v11 
    let _v1 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : unit = ()
    let _v71 =
        async {
            let v74 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v74 = v74 
            let v75 : System.Threading.CancellationToken = v74 
            let v76 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v77 : (System.Threading.CancellationToken []) = [|v75; v76; v0|]
            let v78 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v79 : System.Threading.CancellationTokenSource = v78 v77
            let v80 : System.Threading.CancellationToken = v79.Token
            return v80 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v130 : Async<System.Threading.CancellationToken> = _v71 
    let _v1 = v130 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v131 : unit = ()
    let _v131 =
        async {
            let v134 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v134 = v134 
            let v135 : System.Threading.CancellationToken = v134 
            let v136 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v137 : (System.Threading.CancellationToken []) = [|v135; v136; v0|]
            let v138 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v139 : System.Threading.CancellationTokenSource = v138 v137
            let v140 : System.Threading.CancellationToken = v139.Token
            return v140 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v190 : Async<System.Threading.CancellationToken> = _v131 
    let _v1 = v190 
    #endif
#else
    let v191 : unit = ()
    let _v191 =
        async {
            let v194 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v194 = v194 
            let v195 : System.Threading.CancellationToken = v194 
            let v196 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v197 : (System.Threading.CancellationToken []) = [|v195; v196; v0|]
            let v198 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v199 : System.Threading.CancellationTokenSource = v198 v197
            let v200 : System.Threading.CancellationToken = v199.Token
            return v200 
            (*
            ()
        *)
        }
        (*
        ()
    *)
    let v250 : Async<System.Threading.CancellationToken> = _v191 
    let _v1 = v250 
    #endif
    let v251 : Async<System.Threading.CancellationToken> = _v1 
    v251
and closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
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
    let v20 : Async<System.Threading.CancellationToken> = method0(v0)
    let _v1 = v20 
    #endif
    let v21 : Async<System.Threading.CancellationToken> = _v1 
    v21
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
