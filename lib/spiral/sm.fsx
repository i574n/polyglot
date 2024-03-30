type Mut0 = {mutable l0 : int32; mutable l1 : string}
and Mut1 = {mutable l0 : int32}
let rec closure1 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.Contains v0
    v2
and closure0 () (v0 : string) : (string -> bool) =
    closure1(v0)
and closure3 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.EndsWith v0
    v2
and closure2 () (v0 : string) : (string -> bool) =
    closure3(v0)
and closure6 (v0 : int32, v1 : char) (v2 : string) : string =
    let v3 : string = v2.PadLeft (v0, v1)
    v3
and closure5 (v0 : int32) (v1 : char) : (string -> string) =
    closure6(v0, v1)
and closure4 () (v0 : int32) : (char -> (string -> string)) =
    closure5(v0)
and closure8 (v0 : int32) (v1 : string) : string =
    let v2 : string = v1.PadRight v0
    v2
and closure7 () (v0 : int32) : (string -> string) =
    closure8(v0)
and closure11 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = v2.Replace (v0, v1)
    v3
and closure10 (v0 : string) (v1 : string) : (string -> string) =
    closure11(v0, v1)
and closure9 () (v0 : string) : (string -> (string -> string)) =
    closure10(v0)
and closure13 (v0 : string) (v1 : string) : (string []) =
    let v2 : (string []) = v1.Split v0
    v2
and closure12 () (v0 : string) : (string -> (string [])) =
    closure13(v0)
and method0 () : string =
    let v0 : string = ""
    v0
and closure15 (v0 : (string [])) (v1 : string) : (string []) =
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    let v2 : ((string []) -> string seq) = Seq.ofArray
    let v3 : string seq = v2 v0
    let v4 : string = method0()
    let v5 : string = v3 |> String.concat v4
    let v6 : (string []) = v1.Split v5
    v6
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v7 : ((string []) -> string seq) = Seq.ofArray
    let v8 : string seq = v7 v0
    let v9 : string = method0()
    let v10 : string = v8 |> String.concat v9
    let v11 : (string []) = v1.Split v10
    v11
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v12 : (string []) = v1.Split (v0, System.StringSplitOptions.None)
    v12
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v13 : ((string []) -> string seq) = Seq.ofArray
    let v14 : string seq = v13 v0
    let v15 : string = method0()
    let v16 : string = v14 |> String.concat v15
    let v17 : (string []) = v1.Split v16
    v17
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v18 : ((string []) -> string seq) = Seq.ofArray
    let v19 : string seq = v18 v0
    let v20 : string = method0()
    let v21 : string = v19 |> String.concat v20
    let v22 : (string []) = v1.Split v21
    v22
    #endif
    |> fun x -> result <- Some x
    let v23 : (string []) = result |> Option.get
    v23
and closure14 () (v0 : (string [])) : (string -> (string [])) =
    closure15(v0)
and closure17 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.StartsWith v0
    v2
and closure16 () (v0 : string) : (string -> bool) =
    closure17(v0)
and closure20 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.Substring (v0, v1)
    v3
and closure19 (v0 : int32) (v1 : int32) : (string -> string) =
    closure20(v0, v1)
and closure18 () (v0 : int32) : (int32 -> (string -> string)) =
    closure19(v0)
and closure21 () (v0 : string) : string =
    let v1 : string = v0.ToLower ()
    v1
and closure22 () (v0 : string) : string =
    let v1 : string = v0.ToUpper ()
    v1
and closure23 () (v0 : string) : string =
    let v1 : string = v0.Trim ()
    v1
and closure25 (v0 : (char [])) (v1 : string) : string =
    let v2 : string = v1.TrimEnd v0
    v2
and closure24 () (v0 : (char [])) : (string -> string) =
    closure25(v0)
and closure27 (v0 : (char [])) (v1 : string) : string =
    let v2 : string = v1.TrimStart v0
    v2
and closure26 () (v0 : (char [])) : (string -> string) =
    closure27(v0)
and closure29 (v0 : int32) (v1 : string) : string =
    let v2 : int32 = v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : string = v1.Substring (0, v0)
        let v5 : string = v4 + "..."
        v5
and closure28 () (v0 : int32) : (string -> string) =
    closure29(v0)
and closure30 () (v0 : exn) : string =
    let mutable result = None
    #if FABLE_COMPILER_RUST && !WASM
    let v1 : string = $"%A{v0}"
    v1
    #endif
    #if FABLE_COMPILER_RUST && WASM
    let v2 : string = $"%A{v0}"
    v2
    #endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v3 : string = $"{v0.GetType ()}: {v0.Message}"
    v3
    #endif
    #if FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM
    let v4 : string = $"%A{v0}"
    v4
    #endif
    #if !FABLE_COMPILER_RUST && WASM
    let v5 : string = $"%A{v0}"
    v5
    #endif
    |> fun x -> result <- Some x
    let v6 : string = result |> Option.get
    v6
and method1 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure32 (v0 : string) (v1 : (string [])) : string =
    let v2 : int32 = v1.Length
    let v3 : string = ""
    let v4 : Mut0 = {l0 = 0; l1 = v3} : Mut0
    while method1(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : string = v4.l1
        let v8 : string = v1.[int v6]
        let v9 : string = v7 + v8 + v0 + ""
        let v10 : int32 = v6 + 1
        v4.l0 <- v10
        v4.l1 <- v9
        ()
    let v11 : string = v4.l1
    v11
and closure31 () (v0 : string) : ((string []) -> string) =
    closure32(v0)
and closure34 (v0 : string) (v1 : string seq) : string =
    let v2 : string = v1 |> String.concat v0
    v2
and closure33 () (v0 : string) : (string seq -> string) =
    closure34(v0)
and closure36 (v0 : string) (v1 : (string [])) : string =
    let v2 : string = System.String.Join (v0, v1)
    v2
and closure35 () (v0 : string) : ((string []) -> string) =
    closure36(v0)
and method2 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure37 () (v0 : string) : (char []) =
    let v1 : int32 = v0.Length
    let v2 : (char []) = Array.zeroCreate<char> (v1)
    let v3 : Mut1 = {l0 = 0} : Mut1
    while method2(v1, v3) do
        let v5 : int32 = v3.l0
        let v6 : char = v0.[int v5]
        v2.[int v5] <- v6
        let v7 : int32 = v5 + 1
        v3.l0 <- v7
        ()
    v2
let v0 : (string -> (string -> bool)) = closure0()
let contains x = v0 x
let v1 : (string -> (string -> bool)) = closure2()
let ends_with x = v1 x
let v2 : (int32 -> (char -> (string -> string))) = closure4()
let pad_left x = v2 x
let v3 : (int32 -> (string -> string)) = closure7()
let pad_right x = v3 x
let v4 : (string -> (string -> (string -> string))) = closure9()
let replace x = v4 x
let v5 : (string -> (string -> (string []))) = closure12()
let split x = v5 x
let v6 : ((string []) -> (string -> (string []))) = closure14()
let split_string x = v6 x
let v7 : (string -> (string -> bool)) = closure16()
let starts_with x = v7 x
let v8 : (int32 -> (int32 -> (string -> string))) = closure18()
let substring x = v8 x
let v9 : (string -> string) = closure21()
let to_lower x = v9 x
let v10 : (string -> string) = closure22()
let to_upper x = v10 x
let v11 : (string -> string) = closure23()
let trim x = v11 x
let v12 : ((char []) -> (string -> string)) = closure24()
let trim_end x = v12 x
let v13 : ((char []) -> (string -> string)) = closure26()
let trim_start x = v13 x
let v14 : (int32 -> (string -> string)) = closure28()
let ellipsis x = v14 x
let v15 : (exn -> string) = closure30()
let format_exception x = v15 x
let v16 : (string -> ((string []) -> string)) = closure31()
let concat_array_trailing x = v16 x
let v17 : (string -> (string seq -> string)) = closure33()
let concat x = v17 x
let v18 : (string -> ((string []) -> string)) = closure35()
let join' x = v18 x
let v19 : (string -> (char [])) = closure37()
let to_char_array x = v19 x
()
