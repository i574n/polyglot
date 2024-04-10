type [<Struct>] US0 =
    | US0_0
    | US0_1
and [<Struct>] US1 =
    | US1_0 of f0_0 : US0
    | US1_1
let rec closure0 () (v0 : (unit -> unit)) : System.IDisposable =
    let v1 : System.IDisposable option = None
    let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : System.IDisposable = null |> unbox<System.IDisposable>
    v2 
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : System.IDisposable = null |> unbox<System.IDisposable>
    v3 
    #endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v4 : System.IDisposable = null |> unbox<System.IDisposable>
    v4 
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v5 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v0 () }
    v5 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v6 : System.IDisposable = null |> unbox<System.IDisposable>
    v6 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<System.IDisposable>
    #endif
    |> fun x -> _v1 <- Some x
    let v7 : System.IDisposable = _v1 |> Option.get
    v7
and closure3 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US0 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US0_0
    else
        US0_1
and closure4 () (v0 : US0) : US1 =
    US1_0(v0)
and closure5 (v0 : int32) (v1 : exn) : US1 =
    let v2 : unit option = None
    let mutable _v2 = v2
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
    let v3 : (int32 -> unit) = System.Threading.Thread.Sleep
    v3 1
    () 
    #endif
    #if FABLE_COMPILER_TYPESCRIPT
    () 
    #endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    Unchecked.defaultof<unit>
    #endif
    |> fun x -> _v2 <- Some x
    _v2 |> Option.get
    US1_1
and method0 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US0 =
    let v3 : (unit -> US0) = closure3(v0, v1, v2)
    let v4 : (US0 -> US1) = closure4()
    let v5 : (exn -> US1) = closure5(v2)
    let v6 : US1 = try v3 () |> v4 with ex -> v5 ex 
    match v6 with
    | US1_1 -> (* None *)
        let v8 : int32 = v2 + 1
        method0(v0, v1, v8)
    | US1_0(v7) -> (* Some *)
        v7
and closure2 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US0 = method0(v0, v1, v2)
    match v3 with
    | US0_1 -> (* None *)
        let v5 : unit option = None
        v5
    | US0_0 -> (* Some *)
        let v4 : unit option = Some () 
        v4
and closure1 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure2(v0)
let v0 : ((unit -> unit) -> System.IDisposable) = closure0()
let new_disposable x = v0 x
let v1 : (int32 -> ((unit -> unit) -> unit option)) = closure1()
let retry_fn x = v1 x
()
