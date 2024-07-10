type Disposable (f : unit -> unit) = interface System.IDisposable with member _.Dispose () = f ()
type [<Struct>] US0 =
    | US0_0 of f0_0 : System.Threading.CancellationToken
    | US0_1
let rec closure1 (v0 : System.Threading.CancellationTokenSource) () : unit =
    let v3 : bool = true
    let mutable _v3 : unit option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && WASM
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    null |> unbox<unit>
    () 
    #endif
#if FABLE_COMPILER_PYTHON
    null |> unbox<unit>
    () 
    #endif
#else
    let v34 : (unit -> unit) = v0.Cancel
    v34 ()
    () 
    #endif
    |> fun x -> _v3 <- Some x
    match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    ()
and method0 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure1(v0)
and method1 (v0 : System.Threading.CancellationTokenSource) : (unit -> unit) =
    closure1(v0)
and closure0 () (v0 : System.Threading.CancellationToken option) : struct (System.Threading.CancellationToken * System.IDisposable) =
    let v3 : bool = true
    let mutable _v3 : struct (System.Threading.CancellationToken * System.IDisposable) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let struct (v6 : System.Threading.CancellationToken, v7 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v6, v7) 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let struct (v18 : System.Threading.CancellationToken, v19 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v18, v19) 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let struct (v30 : System.Threading.CancellationToken, v31 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v30, v31) 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let struct (v42 : System.Threading.CancellationToken, v43 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v42, v43) 
    #endif
#if FABLE_COMPILER_PYTHON
    let struct (v54 : System.Threading.CancellationToken, v55 : System.IDisposable) = null |> unbox<struct (System.Threading.CancellationToken * System.IDisposable)>
    struct (v54, v55) 
    #endif
#else
    let v64 : System.Threading.CancellationTokenSource = new System.Threading.CancellationTokenSource ()
    let v67 : US0 option = None
    let _v67 = ref v67 
    match v0 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v68 : System.Threading.CancellationToken = x
    let v69 : US0 = US0_0(v68)
    v69 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v67.Value <- x
    let v70 : US0 option = _v67.Value 
    let v93 : US0 = US0_1
    let v94 : US0 = v70 |> Option.defaultValue v93 
    let v108 : System.Threading.CancellationTokenSource =
        match v94 with
        | US0_1 -> (* None *)
            v64
        | US0_0(v102) -> (* Some *)
            let v103 : System.Threading.CancellationToken = v64.Token
            let v104 : (System.Threading.CancellationToken []) = [|v103; v102|]
            let v105 : ((System.Threading.CancellationToken []) -> System.Threading.CancellationTokenSource) = System.Threading.CancellationTokenSource.CreateLinkedTokenSource
            v105 v104
    let v111 : bool = true
    let mutable _v111 : System.IDisposable option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v112 : (unit -> unit) = method0(v108)
    let v113 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v112 "$0()" )
    v113 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v114 : (unit -> unit) = method0(v108)
    let v115 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v114 "$0()" )
    v115 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v116 : (unit -> unit) = method0(v108)
    let v117 : System.IDisposable = new Disposable (fun () -> Fable.Core.RustInterop.emitRustExpr v116 "$0()" )
    v117 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v118 : (unit -> unit) = method1(v108)
    let v119 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v118 () }
    v119 
    #endif
#if FABLE_COMPILER_PYTHON
    let v120 : (unit -> unit) = method1(v108)
    let v121 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v120 () }
    v121 
    #endif
#else
    let v122 : (unit -> unit) = method1(v108)
    let v123 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v122 () }
    v123 
    #endif
    |> fun x -> _v111 <- Some x
    let v124 : System.IDisposable = match _v111 with Some x -> x | None -> failwith "base.run_target / _v111=None"
    let v132 : System.Threading.CancellationToken = v108.Token
    struct (v132, v124) 
    #endif
    |> fun x -> _v3 <- Some x
    let struct (v133 : System.Threading.CancellationToken, v134 : System.IDisposable) = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    struct (v133, v134)
let v0 : (System.Threading.CancellationToken option -> struct (System.Threading.CancellationToken * System.IDisposable)) = closure0()
let new_disposable_token x = v0 x
()
