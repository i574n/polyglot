let rec closure0 () (v0 : string) : System.Guid =
    let v3 : System.Guid = v0 |> System.Guid 
    v3
and method0 (v0 : string) : System.Guid =
    let v3 : bool = true
    let mutable _v3 : System.Guid option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = v0.PadLeft (32, '0')
    let v38 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..19]}-{v6.[20..31]}"
    v38 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = v0.PadLeft (32, '0')
    let v79 : System.Guid = System.Guid $"{v47.[0..7]}-{v47.[8..11]}-{v47.[12..15]}-{v47.[16..19]}-{v47.[20..31]}"
    v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v88 : System.Guid = null |> unbox<System.Guid>
    v88 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v97 : string = v0.PadLeft (32, '0')
    let v129 : System.Guid = System.Guid $"{v97.[0..7]}-{v97.[8..11]}-{v97.[12..15]}-{v97.[16..19]}-{v97.[20..31]}"
    v129 
    #endif
#if FABLE_COMPILER_PYTHON
    let v138 : string = v0.PadLeft (32, '0')
    let v170 : System.Guid = System.Guid $"{v138.[0..7]}-{v138.[8..11]}-{v138.[12..15]}-{v138.[16..19]}-{v138.[20..31]}"
    v170 
    #endif
#else
    let v179 : string = v0.PadLeft (32, '0')
    let v211 : System.Guid = System.Guid $"{v179.[0..7]}-{v179.[8..11]}-{v179.[12..15]}-{v179.[16..19]}-{v179.[20..31]}"
    v211 
    #endif
    |> fun x -> _v3 <- Some x
    let v218 : System.Guid = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v218
and closure1 () (v0 : string) : System.Guid =
    method0(v0)
and closure2 () () : System.Guid =
    let v2 : (unit -> System.Guid) = System.Guid.NewGuid
    v2 ()
let v0 : (string -> System.Guid) = closure0()
let new_guid x = v0 x
let v1 : (string -> System.Guid) = closure1()
let hash_guid x = v1 x
let v2 : (unit -> System.Guid) = closure2()
let new_raw_guid x = v2 x
()
