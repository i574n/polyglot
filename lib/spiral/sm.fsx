#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

type UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and Mut0 = {mutable l0 : int32; mutable l1 : string}
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
and method1 (v0 : string) : string =
    v0
and method0 (v0 : string, v1 : string, v2 : string) : string =
    let v3 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = $"regex::Regex::new(&$0)"
    let v5 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let v6 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.unwrap()"
    let v8 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let _v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.unwrap()"
    let v10 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.unwrap()"
    let v12 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v14 
    #endif
#else
    let v15 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _v6 = v15 
    #endif
    let v16 : regex_Regex = _v6 
    let v19 : string = method1(v2)
    let v20 : string = $"$0.replace_all(&*$1, &*$2)"
    let v21 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v16, v19, v1) v20 
    let v22 : string = "String::from($0)"
    let v23 : std_string_String = Fable.Core.RustInterop.emitRustExpr v21 v22 
    let v24 : string = "fable_library_rust::String_::fromString($0)"
    let v25 : string = Fable.Core.RustInterop.emitRustExpr v23 v24 
    let _v3 = v25 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v26 : string = null |> unbox<string>
    let _v3 = v26 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = null |> unbox<string>
    let _v3 = v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v32 : string = null |> unbox<string>
    let _v3 = v32 
    #endif
#if FABLE_COMPILER_PYTHON
    let v35 : string = null |> unbox<string>
    let _v3 = v35 
    #endif
#else
    let v38 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _v3 = v38 
    #endif
    let v39 : string = _v3 
    v39
and closure15 (v0 : string, v1 : string) (v2 : string) : string =
    method0(v0, v1, v2)
and closure14 (v0 : string) (v1 : string) : (string -> string) =
    closure15(v0, v1)
and closure13 () (v0 : string) : (string -> (string -> string)) =
    closure14(v0)
and closure18 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.[int v0..int v1]
    v3
and closure17 (v0 : int32) (v1 : int32) : (string -> string) =
    closure18(v0, v1)
and closure16 () (v0 : int32) : (int32 -> (string -> string)) =
    closure17(v0)
and closure20 (v0 : string) (v1 : string) : (string []) =
    let v2 : (string []) = v1.Split v0 
    v2
and closure19 () (v0 : string) : (string -> (string [])) =
    closure20(v0)
and method2 () : string =
    let v0 : string = ""
    v0
and closure22 (v0 : (string [])) (v1 : string) : (string []) =
    let v2 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string seq = v0 |> Seq.ofArray
    let v6 : string = method2()
    let v7 : (string -> (string seq -> string)) = String.concat
    let v8 : (string seq -> string) = v7 v6
    let v9 : string = v8 v3
    let v12 : (string []) = v1.Split v9 
    let _v2 = v12 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string seq = v0 |> Seq.ofArray
    let v18 : string = method2()
    let v19 : (string -> (string seq -> string)) = String.concat
    let v20 : (string seq -> string) = v19 v18
    let v21 : string = v20 v15
    let v24 : (string []) = v1.Split v21 
    let _v2 = v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v27 : string seq = v0 |> Seq.ofArray
    let v30 : string = method2()
    let v31 : (string -> (string seq -> string)) = String.concat
    let v32 : (string seq -> string) = v31 v30
    let v33 : string = v32 v27
    let v36 : (string []) = v1.Split v33 
    let _v2 = v36 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v39 : string seq = v0 |> Seq.ofArray
    let v42 : string = method2()
    let v43 : (string -> (string seq -> string)) = String.concat
    let v44 : (string seq -> string) = v43 v42
    let v45 : string = v44 v39
    let v48 : (string []) = v1.Split v45 
    let _v2 = v48 
    #endif
#if FABLE_COMPILER_PYTHON
    let v51 : string seq = v0 |> Seq.ofArray
    let v54 : string = method2()
    let v55 : (string -> (string seq -> string)) = String.concat
    let v56 : (string seq -> string) = v55 v54
    let v57 : string = v56 v51
    let v60 : (string []) = v1.Split v57 
    let _v2 = v60 
    #endif
#else
    let v63 : (string []) = v1.Split (v0, System.StringSplitOptions.None)
    let _v2 = v63 
    #endif
    let v64 : (string []) = _v2 
    v64
and closure21 () (v0 : (string [])) : (string -> (string [])) =
    closure22(v0)
and closure24 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.StartsWith v0 
    v2
and closure23 () (v0 : string) : (string -> bool) =
    closure24(v0)
and closure27 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.Substring (v0, v1)
    v3
and closure26 (v0 : int32) (v1 : int32) : (string -> string) =
    closure27(v0, v1)
and closure25 () (v0 : int32) : (int32 -> (string -> string)) =
    closure26(v0)
and closure28 () (v0 : string) : string =
    let v1 : (unit -> string) = v0.ToLower
    v1 ()
and closure29 () (v0 : string) : string =
    let v1 : (unit -> string) = v0.ToUpper
    v1 ()
and closure30 () (v0 : string) : string =
    let v1 : (unit -> string) = v0.Trim
    v1 ()
and closure33 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure32 () (v0 : char) : (UH0 -> UH0) =
    closure33(v0)
and method3 () : (char -> (UH0 -> UH0)) =
    closure32()
and method4 (v0 : UH0, v1 : char list) : char list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : char list = method4(v3, v1)
        let v5 : char list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and closure34 (v0 : UH0) (v1 : string) : string =
    let v2 : char list = []
    let v3 : char list = method4(v0, v2)
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v3
    let v8 : string = v1.TrimEnd v5 
    v8
and closure31 () (v0 : (char [])) : (string -> string) =
    let v1 : char list = v0 |> Array.toList
    let v2 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v3 : (char -> (UH0 -> UH0)) = method3()
    let v4 : (char list -> (UH0 -> UH0)) = v2 v3
    let v5 : (UH0 -> UH0) = v4 v1
    let v6 : UH0 = UH0_0
    let v7 : UH0 = v5 v6
    closure34(v7)
and closure36 (v0 : UH0) (v1 : string) : string =
    let v2 : char list = []
    let v3 : char list = method4(v0, v2)
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v3
    let v8 : string = v1.TrimStart v5 
    v8
and closure35 () (v0 : (char [])) : (string -> string) =
    let v1 : char list = v0 |> Array.toList
    let v2 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v3 : (char -> (UH0 -> UH0)) = method3()
    let v4 : (char list -> (UH0 -> UH0)) = v2 v3
    let v5 : (UH0 -> UH0) = v4 v1
    let v6 : UH0 = UH0_0
    let v7 : UH0 = v5 v6
    closure36(v7)
and closure38 (v0 : int32) (v1 : string) : string =
    let v2 : int32 = v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : int32 = v0 - 1
        let v5 : string = v1.[int 0..int v4]
        let v6 : string = v5 + "..."
        v6
and closure37 () (v0 : int32) : (string -> string) =
    closure38(v0)
and method5 (v0 : int64, v1 : string) : string =
    let v2 : int64 = System.Convert.ToInt64 v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : (int64 -> float) = float
        let v5 : float = v4 v0
        let v6 : float = v5 / 2.0
        let v7 : (float -> float) = ceil
        let v8 : float = v7 v6
        let v9 : (float -> int64) = int64
        let v10 : int64 = v9 v8
        let v11 : (float -> float) = floor
        let v12 : float = v11 v6
        let v13 : (float -> int64) = int64
        let v14 : int64 = v13 v12
        let v15 : int64 = v10 - 1L
        let v16 : string = v1.[int 0L..int v15]
        let v17 : int64 = v2 - v14
        let v18 : int64 = v2 - 1L
        let v19 : string = v1.[int v17..int v18]
        let v20 : string = "..."
        let v21 : (string []) = [|v16; v20; v19|]
        let v22 : string seq = v21 |> Seq.ofArray
        let v25 : (string -> (string seq -> string)) = String.concat
        let v26 : string = ""
        let v27 : (string seq -> string) = v25 v26
        v27 v22
and closure40 (v0 : int64) (v1 : string) : string =
    method5(v0, v1)
and closure39 () (v0 : int64) : (string -> string) =
    closure40(v0)
and closure41 () (v0 : exn) : string =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = $"%A{v0}"
    let _v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = $"%A{v0}"
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = $"%A{v0}"
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = $"%A{v0}"
    let _v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : string = $"%A{v0}"
    let _v1 = v14 
    #endif
#else
    let v17 : string = $"{v0.GetType ()}: {v0.Message}"
    let _v1 = v17 
    #endif
    let v18 : string = _v1 
    v18
and method6 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure43 (v0 : string) (v1 : (string [])) : string =
    let v2 : int32 = v1.Length
    let v3 : string = ""
    let v4 : Mut0 = {l0 = 0; l1 = v3} : Mut0
    while method6(v2, v4) do
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
and closure42 () (v0 : string) : ((string []) -> string) =
    closure43(v0)
and closure45 (v0 : string) (v1 : string seq) : string =
    let v2 : (string -> (string seq -> string)) = String.concat
    let v3 : (string seq -> string) = v2 v0
    v3 v1
and closure44 () (v0 : string) : (string seq -> string) =
    closure45(v0)
and closure47 (v0 : string) (v1 : (string [])) : string =
    let v2 : string = System.String.Join (v0, v1)
    v2
and closure46 () (v0 : string) : ((string []) -> string) =
    closure47(v0)
and method7 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure48 () (v0 : string) : (char []) =
    let v1 : int32 = v0.Length
    let v2 : (char []) = Array.zeroCreate<char> (v1)
    let v3 : Mut1 = {l0 = 0} : Mut1
    while method7(v1, v3) do
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
let v5 : (string -> (string -> (string -> string))) = closure13()
let replace_regex x = v5 x
let v6 : (int32 -> (int32 -> (string -> string))) = closure16()
let slice x = v6 x
let v7 : (string -> (string -> (string []))) = closure19()
let split x = v7 x
let v8 : ((string []) -> (string -> (string []))) = closure21()
let split_string x = v8 x
let v9 : (string -> (string -> bool)) = closure23()
let starts_with x = v9 x
let v10 : (int32 -> (int32 -> (string -> string))) = closure25()
let substring x = v10 x
let v11 : (string -> string) = closure28()
let to_lower x = v11 x
let v12 : (string -> string) = closure29()
let to_upper x = v12 x
let v13 : (string -> string) = closure30()
let trim x = v13 x
let v14 : ((char []) -> (string -> string)) = closure31()
let trim_end x = v14 x
let v15 : ((char []) -> (string -> string)) = closure35()
let trim_start x = v15 x
let v16 : (int32 -> (string -> string)) = closure37()
let ellipsis x = v16 x
let v17 : (int64 -> (string -> string)) = closure39()
let ellipsis_end x = v17 x
let v18 : (exn -> string) = closure41()
let format_exception x = v18 x
let v19 : (string -> ((string []) -> string)) = closure42()
let concat_array_trailing x = v19 x
let v20 : (string -> (string seq -> string)) = closure44()
let concat x = v20 x
let v21 : (string -> ((string []) -> string)) = closure46()
let join' x = v21 x
let v22 : (string -> (char [])) = closure48()
let to_char_array x = v22 x
()
