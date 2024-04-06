type [<Struct>] US0 =
    | US0_0
    | US0_1
    | US0_2
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1 of f1_0 : US0
    | US1_2 of f2_0 : US0
and [<Struct>] US2 =
    | US2_0
    | US2_1
and [<Struct>] US3 =
    | US3_0 of f0_0 : US2
    | US3_1
let rec closure0 () (v0 : (unit -> unit)) : System.IDisposable =
    let v1 : System.IDisposable option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : US0 = US0_0
    let v3 : US1 = US1_0(v2)
    let v4 : string = $"new_disposable / target: {v3}"
    let v5 : System.IDisposable = failwith<System.IDisposable> v4
    v5 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v6 : US0 = US0_1
    let v7 : US1 = US1_0(v6)
    let v8 : string = $"new_disposable / target: {v7}"
    let v9 : System.IDisposable = failwith<System.IDisposable> v8
    v9 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v10 : US0 = US0_2
    let v11 : US1 = US1_0(v10)
    let v12 : string = $"new_disposable / target: {v11}"
    let v13 : System.IDisposable = failwith<System.IDisposable> v12
    v13 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v14 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v0 () }
    v14 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v15 : US0 = US0_0
    let v16 : US1 = US1_2(v15)
    let v17 : string = $"new_disposable / target: {v16}"
    let v18 : System.IDisposable = failwith<System.IDisposable> v17
    v18 
    #endif
    |> fun x -> _v1 <- Some x
    let v19 : System.IDisposable = _v1 |> Option.get
    v19
and closure3 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US2 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US2_0
    else
        US2_1
and closure4 () (v0 : US2) : US3 =
    US3_0(v0)
and closure5 () (v0 : exn) : unit =
    let v1 : unit option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    () 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    () 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    () 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v2 : (int32 -> unit) = System.Threading.Thread.Sleep
    v2 1
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    () 
    #endif
    |> fun x -> _v1 <- Some x
    _v1 |> Option.get
    ()
and method0 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US2 =
    let v3 : (unit -> US2) = closure3(v0, v1, v2)
    let v4 : (US2 -> US3) = closure4()
    let v5 : (exn -> unit) = closure5()
    let v6 : US3 = US3_1
    let v7 : US3 = try v3 () |> v4 with ex -> v5 ex; v6 
    match v7 with
    | US3_1 -> (* None *)
        let v9 : int32 = v2 + 1
        method0(v0, v1, v9)
    | US3_0(v8) -> (* Some *)
        v8
and closure2 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US2 = method0(v0, v1, v2)
    match v3 with
    | US2_1 -> (* None *)
        let v5 : unit option = None
        v5
    | US2_0 -> (* Some *)
        let v4 : unit option = Some () 
        v4
and closure1 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure2(v0)
let v0 : ((unit -> unit) -> System.IDisposable) = closure0()
let new_disposable x = v0 x
let v1 : (int32 -> ((unit -> unit) -> unit option)) = closure1()
let retry_fn x = v1 x
()
