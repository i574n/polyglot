let rec closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    let v2 : string = v0.ToString ()
    let v3 : string = v1.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v4 : System.Guid = System.Guid $"{v3}{v2.[v3.Length..]}"
    v4
and closure0 () (v0 : System.Guid) : (System.DateTime -> System.Guid) =
    closure1(v0)
and closure5 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = v2.Replace (v0, v1)
    v3
and closure4 (v0 : string) (v1 : string) : (string -> string) =
    closure5(v0, v1)
and closure3 () (v0 : string) : (string -> (string -> string)) =
    closure4(v0)
and method0 () : (string -> (string -> (string -> string))) =
    closure3()
and closure2 () (v0 : System.Guid) : System.DateTime =
    let v1 : string = v0.ToString ()
    let v2 : (string -> (string -> (string -> string))) = method0()
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    let v3 : System.DateTime = System.DateTime.Parse (v1.[..24] |> v2 "-" "")
    v3
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : System.DateTime = System.DateTime.Parse (v1.[..24] |> v2 "-" "")
    v4
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v5 : System.DateTime = System.DateTime.ParseExact (v1.[..24] |> v2 "-" "", "yyyyMMddHHmmssfffffff", null)
    v5
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v6 : System.DateTime = System.DateTime.ParseExact (v1.[..24] |> v2 "-" "", "yyyyMMddHHmmssfffffff", null)
    v6
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v7 : System.DateTime = System.DateTime.ParseExact (v1.[..24] |> v2 "-" "", "yyyyMMddHHmmssfffffff", null)
    v7
    #endif
    |> fun x -> result <- Some x
    let v8 : System.DateTime = result |> Option.get
    v8
and closure7 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : string = v0.ToString ()
    let v3 : string = v1.ToString ()
    let v4 : string = v3.PadLeft (18, '0')
    let v5 : System.Guid = System.Guid $"{v4.[0..7]}-{v4.[8..11]}-{v4.[12..15]}-{v4.[16..17]}{v2.[21..]}"
    v5
and closure6 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure7(v0)
and closure8 () (v0 : System.Guid) : int64 =
    let v1 : string = v0.ToString ()
    let v2 : int64 = int64 $"{v1.[0..7]}{v1.[9..12]}{v1.[14..17]}{v1.[19..20]}"
    v2
and closure9 () (v0 : System.DateTime) : System.Guid =
    let v1 : System.Guid = System.Guid.NewGuid ()
    let v2 : string = v1.ToString ()
    let v3 : string = v0.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v4 : System.Guid = System.Guid $"{v3}{v2.[v3.Length..]}"
    v4
and closure10 () (v0 : int64) : System.Guid =
    let v1 : System.Guid = System.Guid.NewGuid ()
    let v2 : string = v1.ToString ()
    let v3 : string = v0.ToString ()
    let v4 : string = v3.PadLeft (18, '0')
    let v5 : System.Guid = System.Guid $"{v4.[0..7]}-{v4.[8..11]}-{v4.[12..15]}-{v4.[16..17]}{v2.[21..]}"
    v5
let v0 : (System.Guid -> (System.DateTime -> System.Guid)) = closure0()
let date_time_guid_from_date_time x = v0 x
let v1 : (System.Guid -> System.DateTime) = closure2()
let date_time_from_guid x = v1 x
let v2 : (System.Guid -> (int64 -> System.Guid)) = closure6()
let ticks_guid_from_ticks x = v2 x
let v3 : (System.Guid -> int64) = closure8()
let ticks_from_guid x = v3 x
let v4 : (System.DateTime -> System.Guid) = closure9()
let new_guid_from_date_time x = v4 x
let v5 : (int64 -> System.Guid) = closure10()
let new_guid_from_ticks x = v5 x
()
