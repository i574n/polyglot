let rec closure0 () (v0 : string) : System.Guid =
    let v1 : System.Guid = v0 |> System.Guid 
    v1
and method0 (v0 : string) : System.Guid =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = v0.PadLeft (32, '0')
    let v16 : string = $"{v2.[0..7]}-{v2.[8..11]}-{v2.[12..15]}-{v2.[16..19]}-{v2.[20..31]}"
    let v19 : System.Guid = v16 |> System.Guid 
    let _v1 = v19 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v22 : string = v0.PadLeft (32, '0')
    let v36 : string = $"{v22.[0..7]}-{v22.[8..11]}-{v22.[12..15]}-{v22.[16..19]}-{v22.[20..31]}"
    let v39 : System.Guid = v36 |> System.Guid 
    let _v1 = v39 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v42 : System.Guid = null |> unbox<System.Guid>
    let _v1 = v42 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v45 : string = v0.PadLeft (32, '0')
    let v59 : string = $"{v45.[0..7]}-{v45.[8..11]}-{v45.[12..15]}-{v45.[16..19]}-{v45.[20..31]}"
    let v62 : System.Guid = v59 |> System.Guid 
    let _v1 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v65 : string = v0.PadLeft (32, '0')
    let v79 : string = $"{v65.[0..7]}-{v65.[8..11]}-{v65.[12..15]}-{v65.[16..19]}-{v65.[20..31]}"
    let v82 : System.Guid = v79 |> System.Guid 
    let _v1 = v82 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v85 : string = v0.PadLeft (32, '0')
    let v99 : string = $"{v85.[0..7]}-{v85.[8..11]}-{v85.[12..15]}-{v85.[16..19]}-{v85.[20..31]}"
    let v102 : System.Guid = v99 |> System.Guid 
    let _v1 = v102 
    #endif
#else
    let v105 : string = v0.PadLeft (32, '0')
    let v119 : string = $"{v105.[0..7]}-{v105.[8..11]}-{v105.[12..15]}-{v105.[16..19]}-{v105.[20..31]}"
    let v122 : System.Guid = v119 |> System.Guid 
    let _v1 = v122 
    #endif
    let v125 : System.Guid = _v1 
    v125
and closure1 () (v0 : string) : System.Guid =
    method0(v0)
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
