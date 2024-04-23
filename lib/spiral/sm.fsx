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
and closure9 (v0 : int32, v1 : char) (v2 : string) : string =
    let v3 : string = v2.PadRight (v0, v1)
    v3
and closure8 (v0 : int32) (v1 : char) : (string -> string) =
    closure9(v0, v1)
and closure7 () (v0 : int32) : (char -> (string -> string)) =
    closure8(v0)
and closure12 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = v2.Replace (v0, v1)
    v3
and closure11 (v0 : string) (v1 : string) : (string -> string) =
    closure12(v0, v1)
and closure10 () (v0 : string) : (string -> (string -> string)) =
    closure11(v0)
and closure15 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.[int v0..int v1]
    v3
and closure14 (v0 : int32) (v1 : int32) : (string -> string) =
    closure15(v0, v1)
and closure13 () (v0 : int32) : (int32 -> (string -> string)) =
    closure14(v0)
and closure17 (v0 : string) (v1 : string) : (string []) =
    let v2 : (string []) = v1.Split v0
    v2
and closure16 () (v0 : string) : (string -> (string [])) =
    closure17(v0)
and method0 () : string =
    let v0 : string = ""
    v0
and closure19 (v0 : (string [])) (v1 : string) : (string []) =
    let v2 : (string []) option = None
    let v3 : bool = true in let mutable _v2 = v2
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : ((string []) -> string seq) = Seq.ofArray
    let v5 : string seq = v4 v0
    let v6 : string = method0()
    let v7 : (string -> (string seq -> string)) = String.concat
    let v8 : (string seq -> string) = v7 v6
    let v9 : string = v8 v5
    let v10 : (string []) = v1.Split v9
    v10
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v11 : ((string []) -> string seq) = Seq.ofArray
    let v12 : string seq = v11 v0
    let v13 : string = method0()
    let v14 : (string -> (string seq -> string)) = String.concat
    let v15 : (string seq -> string) = v14 v13
    let v16 : string = v15 v12
    let v17 : (string []) = v1.Split v16
    v17
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v18 : ((string []) -> string seq) = Seq.ofArray
    let v19 : string seq = v18 v0
    let v20 : string = method0()
    let v21 : (string -> (string seq -> string)) = String.concat
    let v22 : (string seq -> string) = v21 v20
    let v23 : string = v22 v19
    let v24 : (string []) = v1.Split v23
    v24
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v25 : (string []) = v1.Split (v0, System.StringSplitOptions.None)
    v25
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v26 : ((string []) -> string seq) = Seq.ofArray
    let v27 : string seq = v26 v0
    let v28 : string = method0()
    let v29 : (string -> (string seq -> string)) = String.concat
    let v30 : (string seq -> string) = v29 v28
    let v31 : string = v30 v27
    let v32 : (string []) = v1.Split v31
    v32
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v33 : (string []) = Unchecked.defaultof<(string [])>
    v33
#endif
    |> fun x -> _v2 <- Some x
    let v34 : (string []) = _v2.Value
    v34
and closure18 () (v0 : (string [])) : (string -> (string [])) =
    closure19(v0)
and closure21 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.StartsWith v0
    v2
and closure20 () (v0 : string) : (string -> bool) =
    closure21(v0)
and closure24 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.Substring (v0, v1)
    v3
and closure23 (v0 : int32) (v1 : int32) : (string -> string) =
    closure24(v0, v1)
and closure22 () (v0 : int32) : (int32 -> (string -> string)) =
    closure23(v0)
and closure25 () (v0 : string) : string =
    let v1 : string = v0.ToLower ()
    v1
and closure26 () (v0 : string) : string =
    let v1 : string = v0.ToUpper ()
    v1
and closure27 () (v0 : string) : string =
    let v1 : string = v0.Trim ()
    v1
and closure29 (v0 : (char [])) (v1 : string) : string =
    let v2 : string = v1.TrimEnd v0
    v2
and closure28 () (v0 : (char [])) : (string -> string) =
    closure29(v0)
and closure31 (v0 : (char [])) (v1 : string) : string =
    let v2 : string = v1.TrimStart v0
    v2
and closure30 () (v0 : (char [])) : (string -> string) =
    closure31(v0)
and closure33 (v0 : int32) (v1 : string) : string =
    let v2 : int32 = v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : int32 = v0 - 1
        let v5 : string = v1.[int 0..int v4]
        let v6 : string = v5 + "..."
        v6
and closure32 () (v0 : int32) : (string -> string) =
    closure33(v0)
and closure35 (v0 : int64) (v1 : string) : string =
    let v2 : int64 = System.Convert.ToInt64 v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : float = float v0
        let v5 : float = v4 / 2.0
        let v6 : (float -> float) = ceil
        let v7 : float = v6 v5
        let v8 : int64 = int64 v7
        let v9 : (float -> float) = floor
        let v10 : float = v9 v5
        let v11 : int64 = int64 v10
        let v12 : int64 = v8 - 1L
        let v13 : string = v1.[int 0L..int v12]
        let v14 : int64 = v2 - v11
        let v15 : int64 = v2 - 1L
        let v16 : string = v1.[int v14..int v15]
        let v17 : string = "..."
        let v18 : (string []) = [|v13; v17; v16|]
        let v19 : ((string []) -> string seq) = Seq.ofArray
        let v20 : string seq = v19 v18
        let v21 : string = method0()
        let v22 : (string -> (string seq -> string)) = String.concat
        let v23 : (string seq -> string) = v22 v21
        v23 v20
and closure34 () (v0 : int64) : (string -> string) =
    closure35(v0)
and closure36 () (v0 : exn) : string =
    let v1 : string option = None
    let v2 : bool = true in let mutable _v1 = v1
    #if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = $"%A{v0}"
    v3
#endif
    #if FABLE_COMPILER_RUST && WASM
    let v4 : string = $"%A{v0}"
    v4
#endif
    #if FABLE_COMPILER_RUST && CONTRACT
    let v5 : string = $"%A{v0}"
    v5
#endif
    #if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !WASM && !CONTRACT
    let v6 : string = $"{v0.GetType ()}: {v0.Message}"
    v6
#endif
    #if FABLE_COMPILER_TYPESCRIPT
    let v7 : string = $"%A{v0}"
    v7
#endif
    #if FABLE_COMPILER_PYTHON || FABLE_COMPILER_PHP || FABLE_COMPILER_DART
    let v8 : string = Unchecked.defaultof<string>
    v8
#endif
    |> fun x -> _v1 <- Some x
    let v9 : string = _v1.Value
    v9
and method1 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure38 (v0 : string) (v1 : (string [])) : string =
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
and closure37 () (v0 : string) : ((string []) -> string) =
    closure38(v0)
and method2 (v0 : string) : string =
    v0
and closure40 (v0 : string) (v1 : string seq) : string =
    let v2 : string = method2(v0)
    let v3 : (string -> (string seq -> string)) = String.concat
    let v4 : (string seq -> string) = v3 v2
    v4 v1
and closure39 () (v0 : string) : (string seq -> string) =
    closure40(v0)
and closure42 (v0 : string) (v1 : (string [])) : string =
    let v2 : string = System.String.Join (v0, v1)
    v2
and closure41 () (v0 : string) : ((string []) -> string) =
    closure42(v0)
and method3 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure43 () (v0 : string) : (char []) =
    let v1 : int32 = v0.Length
    let v2 : (char []) = Array.zeroCreate<char> (v1)
    let v3 : Mut1 = {l0 = 0} : Mut1
    while method3(v1, v3) do
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
let v3 : (int32 -> (char -> (string -> string))) = closure7()
let pad_right x = v3 x
let v4 : (string -> (string -> (string -> string))) = closure10()
let replace x = v4 x
let v5 : (int32 -> (int32 -> (string -> string))) = closure13()
let slice x = v5 x
let v6 : (string -> (string -> (string []))) = closure16()
let split x = v6 x
let v7 : ((string []) -> (string -> (string []))) = closure18()
let split_string x = v7 x
let v8 : (string -> (string -> bool)) = closure20()
let starts_with x = v8 x
let v9 : (int32 -> (int32 -> (string -> string))) = closure22()
let substring x = v9 x
let v10 : (string -> string) = closure25()
let to_lower x = v10 x
let v11 : (string -> string) = closure26()
let to_upper x = v11 x
let v12 : (string -> string) = closure27()
let trim x = v12 x
let v13 : ((char []) -> (string -> string)) = closure28()
let trim_end x = v13 x
let v14 : ((char []) -> (string -> string)) = closure30()
let trim_start x = v14 x
let v15 : (int32 -> (string -> string)) = closure32()
let ellipsis x = v15 x
let v16 : (int64 -> (string -> string)) = closure34()
let ellipsis_end x = v16 x
let v17 : (exn -> string) = closure36()
let format_exception x = v17 x
let v18 : (string -> ((string []) -> string)) = closure37()
let concat_array_trailing x = v18 x
let v19 : (string -> (string seq -> string)) = closure39()
let concat x = v19 x
let v20 : (string -> ((string []) -> string)) = closure41()
let join' x = v20 x
let v21 : (string -> (char [])) = closure43()
let to_char_array x = v21 x
()
