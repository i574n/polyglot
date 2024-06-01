let rec closure0 () (v0 : string) : System.Guid =
    let v1 : System.Guid = v0 |> System.Guid 
    v1
and closure1 () (v0 : string) : System.Guid =
    let v1 : bool = true
    let mutable _v1 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = v0.PadLeft (32, '0')
    let v3 : System.Guid = System.Guid $"{v2.[0..7]}-{v2.[8..11]}-{v2.[12..15]}-{v2.[16..19]}-{v2.[20..31]}"
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = v0.PadLeft (32, '0')
    let v5 : System.Guid = System.Guid $"{v4.[0..7]}-{v4.[8..11]}-{v4.[12..15]}-{v4.[16..19]}-{v4.[20..31]}"
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : System.Guid = null |> unbox<System.Guid>
    v6 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v7 : string = v0.PadLeft (32, '0')
    let v8 : System.Guid = System.Guid $"{v7.[0..7]}-{v7.[8..11]}-{v7.[12..15]}-{v7.[16..19]}-{v7.[20..31]}"
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : string = v0.PadLeft (32, '0')
    let v10 : System.Guid = System.Guid $"{v9.[0..7]}-{v9.[8..11]}-{v9.[12..15]}-{v9.[16..19]}-{v9.[20..31]}"
    v10 
    #endif
#else
    let v11 : string = v0.PadLeft (32, '0')
    let v12 : System.Guid = System.Guid $"{v11.[0..7]}-{v11.[8..11]}-{v11.[12..15]}-{v11.[16..19]}-{v11.[20..31]}"
    v12 
    #endif
    |> fun x -> _v1 <- Some x
    let v13 : System.Guid = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v13
and closure2 () () : System.Guid =
    let v0 : (unit -> System.Guid) = System.Guid.NewGuid
    v0 ()
let v0 : (string -> System.Guid) = closure0()
let new_guid x = v0 x
let v1 : (string -> System.Guid) = closure1()
let hash_guid x = v1 x
let v2 : (unit -> System.Guid) = closure2()
let new_raw_guid x = v2 x
()
