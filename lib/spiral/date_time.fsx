let rec closure1 (v0 : System.Guid) (v1 : System.DateTime) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v4 : string = v1.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v5 : System.Guid = System.Guid $"{v4}{v3.[v4.Length..]}"
    v5
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
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v3 : (string -> (string -> (string -> string))) = method0()
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    let v4 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v4
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v5 : System.DateTime = System.DateTime.Parse (v2.[..24] |> v3 "-" "")
    v5
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v6 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v6
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v7 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v7
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v8 : System.DateTime = System.DateTime.ParseExact (v2.[..24] |> v3 "-" "", "yyyyMMddHHmmssfffffff", null)
    v8
    #endif
    |> fun x -> result <- Some x
    let v9 : System.DateTime = result |> Option.get
    v9
and closure7 (v0 : System.Guid) (v1 : int64) : System.Guid =
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v0
    let v4 : (int64 -> string) = _.ToString()
    let v5 : string = v4 v1
    let v6 : string = v5.PadLeft (18, '0')
    let v7 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..17]}{v3.[21..]}"
    v7
and closure6 () (v0 : System.Guid) : (int64 -> System.Guid) =
    closure7(v0)
and closure8 () (v0 : System.Guid) : int64 =
    let v1 : (System.Guid -> string) = _.ToString()
    let v2 : string = v1 v0
    let v3 : int64 = int64 $"{v2.[0..7]}{v2.[9..12]}{v2.[14..17]}{v2.[19..20]}"
    v3
and closure9 () (v0 : System.DateTime) : System.Guid =
    let v1 : System.Guid = System.Guid.NewGuid ()
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : string = v0.ToString "yyyyMMdd-HHmm-ssff-ffff-f"
    let v5 : System.Guid = System.Guid $"{v4}{v3.[v4.Length..]}"
    v5
and closure10 () (v0 : int64) : System.Guid =
    let v1 : System.Guid = System.Guid.NewGuid ()
    let v2 : (System.Guid -> string) = _.ToString()
    let v3 : string = v2 v1
    let v4 : (int64 -> string) = _.ToString()
    let v5 : string = v4 v0
    let v6 : string = v5.PadLeft (18, '0')
    let v7 : System.Guid = System.Guid $"{v6.[0..7]}-{v6.[8..11]}-{v6.[12..15]}-{v6.[16..17]}{v3.[21..]}"
    v7
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
