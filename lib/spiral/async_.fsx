let rec method0 (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : Async<System.Threading.CancellationToken> = null |> unbox<Async<System.Threading.CancellationToken>>
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : unit = ()
    let _let'_v11 =
        async {
            (* run_target_args'
            let v14 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v15 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v15 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v18 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v18 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v21 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v21 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v24 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v24 
            #endif
#if FABLE_COMPILER_PYTHON
            let v27 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v27 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v30 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v30 
            #endif
#else
            let v33 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v33 = v33 
            let v34 : System.Threading.CancellationToken = v33 
            let v35 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v36 : (System.Threading.CancellationToken []) = [|v34; v35; v0|]
            let v37 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v38 : System.Threading.CancellationTokenSource = v37 v36
            let v39 : System.Threading.CancellationToken = v38.Token
            return v39 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v246 : Async<System.Threading.CancellationToken> = _let'_v11 
    let _run_target_args'_v1 = v246 
    #endif
#if FABLE_COMPILER_PYTHON
    let v247 : unit = ()
    let _let'_v247 =
        async {
            (* run_target_args'
            let v250 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v251 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v251 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v254 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v254 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v257 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v257 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v260 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v260 
            #endif
#if FABLE_COMPILER_PYTHON
            let v263 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v263 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v266 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v266 
            #endif
#else
            let v269 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v269 = v269 
            let v270 : System.Threading.CancellationToken = v269 
            let v271 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v272 : (System.Threading.CancellationToken []) = [|v270; v271; v0|]
            let v273 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v274 : System.Threading.CancellationTokenSource = v273 v272
            let v275 : System.Threading.CancellationToken = v274.Token
            return v275 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v482 : Async<System.Threading.CancellationToken> = _let'_v247 
    let _run_target_args'_v1 = v482 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v483 : unit = ()
    let _let'_v483 =
        async {
            (* run_target_args'
            let v486 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v487 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v487 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v490 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v490 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v493 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v493 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v496 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v496 
            #endif
#if FABLE_COMPILER_PYTHON
            let v499 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v499 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v502 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v502 
            #endif
#else
            let v505 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v505 = v505 
            let v506 : System.Threading.CancellationToken = v505 
            let v507 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v508 : (System.Threading.CancellationToken []) = [|v506; v507; v0|]
            let v509 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v510 : System.Threading.CancellationTokenSource = v509 v508
            let v511 : System.Threading.CancellationToken = v510.Token
            return v511 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v718 : Async<System.Threading.CancellationToken> = _let'_v483 
    let _run_target_args'_v1 = v718 
    #endif
#else
    let v719 : unit = ()
    let _let'_v719 =
        async {
            (* run_target_args'
            let v722 : unit = ()
            run_target_args' *)
            
#if FABLE_COMPILER || WASM || CONTRACT
            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
            let v723 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v723 
            #endif
#if FABLE_COMPILER_RUST && WASM
            let v726 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v726 
            #endif
#if FABLE_COMPILER_RUST && CONTRACT
            let v729 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v729 
            #endif
#if FABLE_COMPILER_TYPESCRIPT
            let v732 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v732 
            #endif
#if FABLE_COMPILER_PYTHON
            let v735 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v735 
            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
            let v738 : System.Threading.CancellationToken = null |> unbox<System.Threading.CancellationToken>
            return v738 
            #endif
#else
            let v741 : Async<System.Threading.CancellationToken> = Async.CancellationToken
            let! v741 = v741 
            let v742 : System.Threading.CancellationToken = v741 
            let v743 : System.Threading.CancellationToken = Async.DefaultCancellationToken
            let v744 : (System.Threading.CancellationToken []) = [|v742; v743; v0|]
            let v745 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            let v746 : System.Threading.CancellationTokenSource = v745 v744
            let v747 : System.Threading.CancellationToken = v746.Token
            return v747 
            #endif
            // run_target_args' is_unit
            (* indent
            ()
        indent *)
        }
        (* indent
        ()
    indent *)
    let v954 : Async<System.Threading.CancellationToken> = _let'_v719 
    let _run_target_args'_v1 = v954 
    #endif
    let v955 : Async<System.Threading.CancellationToken> = _run_target_args'_v1 
    v955
and closure0 () (v0 : System.Threading.CancellationToken) : Async<System.Threading.CancellationToken> =
    method0(v0)
let v0 : (System.Threading.CancellationToken -> Async<System.Threading.CancellationToken>) = closure0()
let merge_cancellation_token_with_default_async x = v0 x
()
