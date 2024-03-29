type [<Struct>] US0 =
    | US0_0
    | US0_1
and [<Struct>] US1 =
    | US1_0
    | US1_1 of f1_0 : US0
let rec method0 (v0 : (unit -> unit)) : (unit -> unit) =
    v0
and closure0 () (v0 : (unit -> unit)) : System.IDisposable =
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    let v1 : (unit -> unit) = method0(v0)
    let v2 : System.IDisposable = { new System.IDisposable with member _.Dispose () = Fable.Core.RustInterop.emitRustExpr () "v1()" }
    v2
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v3 : (unit -> unit) = method0(v0)
    let v4 : System.IDisposable = { new System.IDisposable with member _.Dispose () = Fable.Core.RustInterop.emitRustExpr () "v3()" }
    v4
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v5 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v0 () }
    v5
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v6 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v0 () }
    v6
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v7 : System.IDisposable = { new System.IDisposable with member _.Dispose () = v0 () }
    v7
    #endif
    |> fun x -> result <- Some x
    let v8 : System.IDisposable = result |> Option.get
    v8
and closure3 (v0 : int32, v1 : (unit -> unit), v2 : int32) () : US0 =
    let v3 : bool = v2 < v0
    if v3 then
        v1 ()
        US0_1
    else
        US0_0
and closure4 () (v0 : US0) : US1 =
    US1_1(v0)
and closure5 () (v0 : exn) : unit =
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    ()
    #endif
    #if FABLE_COMPILER_RUST && WASM
    ()
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v1 : (int32 -> unit) = System.Threading.Thread.Sleep
    v1 1
    ()
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    ()
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    ()
    #endif
    |> fun x -> result <- Some x
    result |> Option.get
    ()
and method1 (v0 : int32, v1 : (unit -> unit), v2 : int32) : US0 =
    let v3 : (unit -> US0) = closure3(v0, v1, v2)
    let v4 : (US0 -> US1) = closure4()
    let v5 : (exn -> unit) = closure5()
    let v6 : US1 = US1_0
    let v7 : US1 = try v3 () |> v4 with ex -> v5 ex; v6 
    match v7 with
    | US1_0 -> (* None *)
        let v9 : int32 = v2 + 1
        method1(v0, v1, v9)
    | US1_1(v8) -> (* Some *)
        v8
and closure2 (v0 : int32) (v1 : (unit -> unit)) : unit option =
    let v2 : int32 = 0
    let v3 : US0 = method1(v0, v1, v2)
    match v3 with
    | US0_0 -> (* None *)
        let v5 : unit option = None
        v5
    | US0_1 -> (* Some *)
        let v4 : unit option = Some ()
        v4
and closure1 () (v0 : int32) : ((unit -> unit) -> unit option) =
    closure2(v0)
let v0 : ((unit -> unit) -> System.IDisposable) = closure0()
let new_disposable x = v0 x
let v1 : (int32 -> ((unit -> unit) -> unit option)) = closure1()
let retry_fn x = v1 x
()
