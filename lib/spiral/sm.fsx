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
and Mut0 = {mutable l0 : int32; mutable l1 : string; mutable l2 : string}
and Mut1 = {mutable l0 : int32}
let rec closure1 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.Contains v0 
    v2
and closure0 () (v0 : string) : (string -> bool) =
    closure1(v0)
and closure3 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.EndsWith (v0, false, null)
    v2
and closure2 () (v0 : string) : (string -> bool) =
    closure3(v0)
and closure7 (v0 : int32, v1 : string, v2 : int32) (v3 : string) : string =
    let v4 : bool = v2 >= v0
    if v4 then
        v3
    else
        let v5 : int32 = v2 + 1
        let v6 : (string -> string) = method0(v0, v1, v5)
        let v7 : string = v3 + v1 
        v6 v7
and method0 (v0 : int32, v1 : string, v2 : int32) : (string -> string) =
    closure7(v0, v1, v2)
and closure6 (v0 : int32, v1 : char) (v2 : string) : string =
    let v3 : (char -> string) = _.ToString()
    let v4 : string = v3 v1
    let v7 : int32 = v2.Length
    let v8 : int32 = v0 - v7
    let v9 : int32 = 0
    let v10 : (string -> string) = method0(v8, v4, v9)
    let v11 : string = ""
    let v12 : string = v10 v11
    let v13 : string = v12 + v2 
    v13
and closure5 (v0 : int32) (v1 : char) : (string -> string) =
    closure6(v0, v1)
and closure4 () (v0 : int32) : (char -> (string -> string)) =
    closure5(v0)
and closure10 (v0 : int32, v1 : char) (v2 : string) : string =
    let v3 : (char -> string) = _.ToString()
    let v4 : string = v3 v1
    let v7 : int32 = v2.Length
    let v8 : int32 = v0 - v7
    let v9 : int32 = 0
    let v10 : (string -> string) = method0(v8, v4, v9)
    let v11 : string = ""
    let v12 : string = v10 v11
    let v13 : string = v2 + v12 
    v13
and closure9 (v0 : int32) (v1 : char) : (string -> string) =
    closure10(v0, v1)
and closure8 () (v0 : int32) : (char -> (string -> string)) =
    closure9(v0)
and closure13 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = v2.Replace (v0, v1)
    v3
and closure12 (v0 : string) (v1 : string) : (string -> string) =
    closure13(v0, v1)
and closure11 () (v0 : string) : (string -> (string -> string)) =
    closure12(v0)
and method2 (v0 : string) : string =
    v0
and method1 (v0 : string, v1 : string, v2 : string) : string =
    (* run_target_args'
    let v3 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = $"regex::Regex::new(&$0)"
    let v5 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v4 
    (* run_target_args'
    let v6 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = "$0.unwrap()"
    let v8 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v7 
    let _run_target_args'_v6 = v8 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v9 : string = "$0.unwrap()"
    let v10 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _run_target_args'_v6 = v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : string = "$0.unwrap()"
    let v12 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _run_target_args'_v6 = v12 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v13 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v6 = v13 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v6 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v15 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v6 = v15 
    #endif
#else
    let v16 : regex_Regex = match v5 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v6 = v16 
    #endif
    let v17 : regex_Regex = _run_target_args'_v6 
    let v20 : string = method2(v2)
    let v21 : string = $"$0.replace_all(&*$1, &*$2)"
    let v22 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v17, v20, v1) v21 
    let v23 : string = "String::from($0)"
    let v24 : std_string_String = Fable.Core.RustInterop.emitRustExpr v22 v23 
    let v25 : string = "fable_library_rust::String_::fromString($0)"
    let v26 : string = Fable.Core.RustInterop.emitRustExpr v24 v25 
    let _run_target_args'_v3 = v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = null |> unbox<string>
    let _run_target_args'_v3 = v27 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = null |> unbox<string>
    let _run_target_args'_v3 = v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = null |> unbox<string>
    let _run_target_args'_v3 = v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v36 : string = null |> unbox<string>
    let _run_target_args'_v3 = v36 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v39 : string = null |> unbox<string>
    let _run_target_args'_v3 = v39 
    #endif
#else
    let v42 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v1)
    let _run_target_args'_v3 = v42 
    #endif
    let v43 : string = _run_target_args'_v3 
    v43
and closure16 (v0 : string, v1 : string) (v2 : string) : string =
    method1(v0, v1, v2)
and closure15 (v0 : string) (v1 : string) : (string -> string) =
    closure16(v0, v1)
and closure14 () (v0 : string) : (string -> (string -> string)) =
    closure15(v0)
and closure19 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.[int v0..int v1]
    v3
and closure18 (v0 : int32) (v1 : int32) : (string -> string) =
    closure19(v0, v1)
and closure17 () (v0 : int32) : (int32 -> (string -> string)) =
    closure18(v0)
and closure21 (v0 : string) (v1 : string) : (string []) =
    let v2 : (string []) = v1.Split v0 
    v2
and closure20 () (v0 : string) : (string -> (string [])) =
    closure21(v0)
and method3 () : string =
    let v0 : string = ""
    v0
and method4 (v0 : string) : string =
    v0
and closure23 (v0 : (string [])) (v1 : string) : (string []) =
    (* run_target_args'
    let v2 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string seq = v0 |> Seq.ofArray
    let v6 : string = method3()
    let v7 : bool = v6 = "\n"
    let v9 : string =
        if v7 then
            method4(v6)
        else
            v6
    let v10 : (string -> (string seq -> string)) = String.concat
    let v11 : (string seq -> string) = v10 v9
    let v12 : string = v11 v3
    let v15 : (string []) = v1.Split v12 
    let _run_target_args'_v2 = v15 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v18 : string seq = v0 |> Seq.ofArray
    let v21 : string = method3()
    let v22 : bool = v21 = "\n"
    let v24 : string =
        if v22 then
            method4(v21)
        else
            v21
    let v25 : (string -> (string seq -> string)) = String.concat
    let v26 : (string seq -> string) = v25 v24
    let v27 : string = v26 v18
    let v30 : (string []) = v1.Split v27 
    let _run_target_args'_v2 = v30 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string seq = v0 |> Seq.ofArray
    let v36 : string = method3()
    let v37 : bool = v36 = "\n"
    let v39 : string =
        if v37 then
            method4(v36)
        else
            v36
    let v40 : (string -> (string seq -> string)) = String.concat
    let v41 : (string seq -> string) = v40 v39
    let v42 : string = v41 v33
    let v45 : (string []) = v1.Split v42 
    let _run_target_args'_v2 = v45 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v48 : string seq = v0 |> Seq.ofArray
    let v51 : string = method3()
    let v52 : bool = v51 = "\n"
    let v54 : string =
        if v52 then
            method4(v51)
        else
            v51
    let v55 : (string -> (string seq -> string)) = String.concat
    let v56 : (string seq -> string) = v55 v54
    let v57 : string = v56 v48
    let v60 : (string []) = v1.Split v57 
    let _run_target_args'_v2 = v60 
    #endif
#if FABLE_COMPILER_PYTHON
    let v63 : string seq = v0 |> Seq.ofArray
    let v66 : string = method3()
    let v67 : bool = v66 = "\n"
    let v69 : string =
        if v67 then
            method4(v66)
        else
            v66
    let v70 : (string -> (string seq -> string)) = String.concat
    let v71 : (string seq -> string) = v70 v69
    let v72 : string = v71 v63
    let v75 : (string []) = v1.Split v72 
    let _run_target_args'_v2 = v75 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v78 : string seq = v0 |> Seq.ofArray
    let v81 : string = method3()
    let v82 : bool = v81 = "\n"
    let v84 : string =
        if v82 then
            method4(v81)
        else
            v81
    let v85 : (string -> (string seq -> string)) = String.concat
    let v86 : (string seq -> string) = v85 v84
    let v87 : string = v86 v78
    let v90 : (string []) = v1.Split v87 
    let _run_target_args'_v2 = v90 
    #endif
#else
    let v93 : (string []) = v1.Split (v0, System.StringSplitOptions.None)
    let _run_target_args'_v2 = v93 
    #endif
    let v94 : (string []) = _run_target_args'_v2 
    v94
and closure22 () (v0 : (string [])) : (string -> (string [])) =
    closure23(v0)
and closure25 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.StartsWith (v0, false, null)
    v2
and closure24 () (v0 : string) : (string -> bool) =
    closure25(v0)
and closure28 (v0 : int32, v1 : int32) (v2 : string) : string =
    let v3 : string = v2.Substring (v0, v1)
    v3
and closure27 (v0 : int32) (v1 : int32) : (string -> string) =
    closure28(v0, v1)
and closure26 () (v0 : int32) : (int32 -> (string -> string)) =
    closure27(v0)
and closure29 () (v0 : string) : string =
    let v1 : (unit -> string) = v0.ToLower
    v1 ()
and closure30 () (v0 : string) : string =
    let v1 : (unit -> string) = v0.ToUpper
    v1 ()
and closure31 () (v0 : string) : string =
    let v1 : (unit -> string) = v0.Trim
    v1 ()
and closure34 (v0 : char) (v1 : UH0) : UH0 =
    UH0_1(v0, v1)
and closure33 () (v0 : char) : (UH0 -> UH0) =
    closure34(v0)
and method5 () : (char -> (UH0 -> UH0)) =
    closure33()
and method6 (v0 : UH0, v1 : char list) : char list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : char list = method6(v3, v1)
        let v5 : char list = v2 :: v4 
        v5
    | UH0_0 -> (* Nil *)
        v1
and closure35 (v0 : UH0) (v1 : string) : string =
    let v2 : char list = []
    let v3 : char list = method6(v0, v2)
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v3
    let v8 : string = v1.TrimEnd v5 
    v8
and closure32 () (v0 : (char [])) : (string -> string) =
    let v1 : char list = v0 |> Array.toList
    let v4 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v5 : (char -> (UH0 -> UH0)) = method5()
    let v6 : (char list -> (UH0 -> UH0)) = v4 v5
    let v7 : (UH0 -> UH0) = v6 v1
    let v8 : UH0 = UH0_0
    let v9 : UH0 = v7 v8
    closure35(v9)
and closure37 (v0 : UH0) (v1 : string) : string =
    let v2 : char list = []
    let v3 : char list = method6(v0, v2)
    let v4 : (char list -> (char [])) = List.toArray
    let v5 : (char []) = v4 v3
    let v8 : string = v1.TrimStart v5 
    v8
and closure36 () (v0 : (char [])) : (string -> string) =
    let v1 : char list = v0 |> Array.toList
    let v4 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v5 : (char -> (UH0 -> UH0)) = method5()
    let v6 : (char list -> (UH0 -> UH0)) = v4 v5
    let v7 : (UH0 -> UH0) = v6 v1
    let v8 : UH0 = UH0_0
    let v9 : UH0 = v7 v8
    closure37(v9)
and closure39 (v0 : int32) (v1 : string) : string =
    let v2 : int32 = v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : int32 = v0 - 1
        let v5 : string = v1.[int 0..int v4]
        let v9 : string = v5 + "..."
        v9
and closure38 () (v0 : int32) : (string -> string) =
    closure39(v0)
and method7 (v0 : int64, v1 : string) : string =
    let v2 : int64 = System.Convert.ToInt64 v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : (int64 -> float) = float
        let v5 : float = v4 v0
        let v8 : float = v5 / 2.0
        let v9 : (float -> float) = ceil
        let v10 : float = v9 v8
        let v11 : (float -> int64) = int64
        let v12 : int64 = v11 v10
        let v15 : (float -> float) = floor
        let v16 : float = v15 v8
        let v17 : (float -> int64) = int64
        let v18 : int64 = v17 v16
        let v21 : int64 = v12 - 1L
        let v22 : string = v1.[int 0L..int v21]
        let v26 : int64 = v2 - v18
        let v27 : int64 = v2 - 1L
        let v28 : string = v1.[int v26..int v27]
        let v32 : string = "..."
        let v33 : (string []) = [|v22; v32; v28|]
        let v34 : string seq = v33 |> Seq.ofArray
        let v37 : (string -> (string seq -> string)) = String.concat
        let v38 : string = ""
        let v39 : (string seq -> string) = v37 v38
        v39 v34
and closure41 (v0 : int64) (v1 : string) : string =
    method7(v0, v1)
and closure40 () (v0 : int64) : (string -> string) =
    closure41(v0)
and closure42 () (v0 : exn) : string =
    (* run_target_args'
    let v1 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = $"%A{v0}"
    let _run_target_args'_v1 = v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = $"%A{v0}"
    let _run_target_args'_v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = $"%A{v0}"
    let _run_target_args'_v1 = v8 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v11 : string = $"%A{v0}"
    let _run_target_args'_v1 = v11 
    #endif
#if FABLE_COMPILER_PYTHON
    let v14 : string = $"%A{v0}"
    let _run_target_args'_v1 = v14 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : string = $"%A{v0}"
    let _run_target_args'_v1 = v17 
    #endif
#else
    let v20 : string = $"{v0.GetType ()}: {v0.Message}"
    let _run_target_args'_v1 = v20 
    #endif
    let v21 : string = _run_target_args'_v1 
    v21
and method8 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure44 (v0 : string) (v1 : (string [])) : string =
    let v2 : int32 = v1.Length
    let v3 : string = ""
    let v4 : Mut0 = {l0 = 0; l1 = v3; l2 = v3} : Mut0
    while method8(v2, v4) do
        let v6 : int32 = v4.l0
        let v7 : int32 =  -v6
        let v8 : int32 = v7 + v2
        let v9 : int32 = v8 - 1
        let struct (v10 : string, v11 : string) = v4.l1, v4.l2
        let v12 : string = v1.[int v9]
        let v13 : string = v12 + v11 + v10 + ""
        let v14 : int32 = v6 + 1
        v4.l0 <- v14
        v4.l1 <- v13
        v4.l2 <- v0
        ()
    let struct (v15 : string, v16 : string) = v4.l1, v4.l2
    v15
and closure43 () (v0 : string) : ((string []) -> string) =
    closure44(v0)
and closure46 (v0 : string) (v1 : string seq) : string =
    let v2 : bool = v0 = "\n"
    let v4 : string =
        if v2 then
            method4(v0)
        else
            v0
    let v5 : (string -> (string seq -> string)) = String.concat
    let v6 : (string seq -> string) = v5 v4
    v6 v1
and closure45 () (v0 : string) : (string seq -> string) =
    closure46(v0)
and closure48 (v0 : string) (v1 : (string [])) : string =
    let v2 : string = System.String.Join (v0, v1)
    v2
and closure47 () (v0 : string) : ((string []) -> string) =
    closure48(v0)
and method9 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure49 () (v0 : string) : (char []) =
    let v1 : int32 = v0.Length
    let v2 : (char []) = Array.zeroCreate<char> (v1)
    let v3 : Mut1 = {l0 = 0} : Mut1
    while method9(v1, v3) do
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
let v3 : (int32 -> (char -> (string -> string))) = closure8()
let pad_right x = v3 x
let v4 : (string -> (string -> (string -> string))) = closure11()
let replace x = v4 x
let v5 : (string -> (string -> (string -> string))) = closure14()
let replace_regex x = v5 x
let v6 : (int32 -> (int32 -> (string -> string))) = closure17()
let slice x = v6 x
let v7 : (string -> (string -> (string []))) = closure20()
let split x = v7 x
let v8 : ((string []) -> (string -> (string []))) = closure22()
let split_string x = v8 x
let v9 : (string -> (string -> bool)) = closure24()
let starts_with x = v9 x
let v10 : (int32 -> (int32 -> (string -> string))) = closure26()
let substring x = v10 x
let v11 : (string -> string) = closure29()
let to_lower x = v11 x
let v12 : (string -> string) = closure30()
let to_upper x = v12 x
let v13 : (string -> string) = closure31()
let trim x = v13 x
let v14 : ((char []) -> (string -> string)) = closure32()
let trim_end x = v14 x
let v15 : ((char []) -> (string -> string)) = closure36()
let trim_start x = v15 x
let v16 : (int32 -> (string -> string)) = closure38()
let ellipsis x = v16 x
let v17 : (int64 -> (string -> string)) = closure40()
let ellipsis_end x = v17 x
let v18 : (exn -> string) = closure42()
let format_exception x = v18 x
let v19 : (string -> ((string []) -> string)) = closure43()
let concat_array x = v19 x
let v20 : (string -> (string seq -> string)) = closure45()
let concat x = v20 x
let v21 : (string -> ((string []) -> string)) = closure47()
let join' x = v21 x
let v22 : (string -> (char [])) = closure49()
let to_char_array x = v22 x
()
