#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("core::any::Any")>]
#endif
type core_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type core_ops_Try<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>]
#endif
type Func0<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>]
#endif
type Func0<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>]
#endif
type Box<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>]
#endif
type Dyn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Send")>]
#endif
type Send<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>]
#endif
type Fn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>]
#endif
type FnUnit = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>]
#endif
type FnOnce<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0)")>]
#endif
type ActionFn<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>]
#endif
type ActionFn2<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>]
#endif
type Impl<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 + $1")>]
#endif
type LifetimeJoin<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("'static")>]
#endif
type StaticLifetime = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0")>]
#endif
type LifetimeRef<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("$0 $1")>]
#endif
type Lifetime<'T, 'U> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>]
#endif
type MutCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>]
#endif
type std_any_Any = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::borrow::Cow<$0>")>]
#endif
type std_borrow_Cow<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>]
#endif
type std_cell_RefCell<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>]
#endif
type std_pin_Pin<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>]
#endif
type std_rc_Rc<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>]
#endif
type std_rc_Weak<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::HashMap<$0, $1>")>]
#endif
type std_collections_HashMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::collections::BTreeMap<$0, $1>")>]
#endif
type std_collections_BTreeMap<'K, 'V> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>]
#endif
type base64_DecodeError = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>]
#endif
type borsh_io_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("encoding_rs::Encoding")>]
#endif
type encoding_rs_Encoding = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>]
#endif
type js_sys_JsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>]
#endif
type serde_json_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>]
#endif
type serde_json_Value = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>]
#endif
type serde_wasm_bindgen_Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsStr")>]
#endif
type std_ffi_OsStr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::OsString")>]
#endif
type std_ffi_OsString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::fmt::Display<$0>")>]
#endif
type std_fmt_Display<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>]
#endif
type std_str_Utf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::FromUtf8Error")>]
#endif
type std_string_FromUtf8Error = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::slice::Windows<$0>")>]
#endif
type std_slice_Windows<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Regex")>]
#endif
type regex_Regex = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
type UH0 =
    | UH0_0
    | UH0_1 of char * UH0
and Mut0 = {mutable l0 : int32; mutable l1 : string}
and Mut1 = {mutable l0 : int32}
let rec closure1 (v0 : string) (v1 : string) : bool =
    let v4 : bool = v1.Contains v0 
    v4
and closure0 () (v0 : string) : (string -> bool) =
    closure1(v0)
and closure3 (v0 : string) (v1 : string) : bool =
    let v2 : bool = v1.EndsWith v0 
    v2
and closure2 () (v0 : string) : (string -> bool) =
    closure3(v0)
and closure6 (v0 : int32, v1 : char) (v2 : string) : string =
    let v5 : string = v2.PadLeft (v0, v1)
    v5
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
and method0 (v0 : string) : string =
    v0
and method1 (v0 : string) : string =
    v0
and method2 (v0 : string) : string =
    v0
and closure15 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : string = method0(v1)
    let v6 : bool = true
    let mutable _v6 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = method1(v2)
    let v8 : string = $"regex::Regex::new(&$0)"
    let v9 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v0 v8 
    let v10 : string = "$0.unwrap()"
    let v11 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v9 v10 
    let v12 : string = $"$0.replace_all(&$1, &*$2)"
    let v13 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v11, v7, v3) v12 
    let v14 : string = "String::from($0)"
    let v15 : std_string_String = Fable.Core.RustInterop.emitRustExpr v13 v14 
    let v16 : string = "fable_library_rust::String_::fromString($0)"
    let v17 : string = Fable.Core.RustInterop.emitRustExpr v15 v16 
    v17 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = null |> unbox<string>
    v20 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = null |> unbox<string>
    v29 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v38 : string = null |> unbox<string>
    v38 
    #endif
#if FABLE_COMPILER_PYTHON
    let v47 : string = null |> unbox<string>
    v47 
    #endif
#else
    let v54 : string = method2(v0)
    let v55 : string = System.Text.RegularExpressions.Regex.Replace (v2, v54, v3)
    v55 
    #endif
    |> fun x -> _v6 <- Some x
    let v56 : string = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
    v56
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
and method3 () : string =
    let v0 : string = ""
    v0
and closure22 (v0 : (string [])) (v1 : string) : (string []) =
    let v4 : bool = true
    let mutable _v4 : (string []) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string seq = v0 |> Seq.ofArray
    let v14 : string = method3()
    let v17 : (string -> (string seq -> string)) = String.concat
    let v18 : (string seq -> string) = v17 v14
    let v19 : string = v18 v7
    let v26 : (string []) = v1.Split v19 
    v26 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string seq = v0 |> Seq.ofArray
    let v36 : string = method3()
    let v39 : (string -> (string seq -> string)) = String.concat
    let v40 : (string seq -> string) = v39 v36
    let v41 : string = v40 v29
    let v48 : (string []) = v1.Split v41 
    v48 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v51 : string seq = v0 |> Seq.ofArray
    let v58 : string = method3()
    let v61 : (string -> (string seq -> string)) = String.concat
    let v62 : (string seq -> string) = v61 v58
    let v63 : string = v62 v51
    let v70 : (string []) = v1.Split v63 
    v70 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v73 : string seq = v0 |> Seq.ofArray
    let v80 : string = method3()
    let v83 : (string -> (string seq -> string)) = String.concat
    let v84 : (string seq -> string) = v83 v80
    let v85 : string = v84 v73
    let v92 : (string []) = v1.Split v85 
    v92 
    #endif
#if FABLE_COMPILER_PYTHON
    let v95 : string seq = v0 |> Seq.ofArray
    let v102 : string = method3()
    let v105 : (string -> (string seq -> string)) = String.concat
    let v106 : (string seq -> string) = v105 v102
    let v107 : string = v106 v95
    let v114 : (string []) = v1.Split v107 
    v114 
    #endif
#else
    let v115 : (string []) = v1.Split (v0, System.StringSplitOptions.None)
    v115 
    #endif
    |> fun x -> _v4 <- Some x
    let v116 : (string []) = match _v4 with Some x -> x | None -> failwith "base.run_target / _v4=None"
    v116
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
    let v3 : (unit -> string) = v0.ToLower
    v3 ()
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
and method4 () : (char -> (UH0 -> UH0)) =
    closure32()
and method5 (v0 : UH0, v1 : char list) : char list =
    match v0 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : char list = method5(v3, v1)
        let v7 : char list = v2 :: v4 
        v7
    | UH0_0 -> (* Nil *)
        v1
and closure34 (v0 : UH0) (v1 : string) : string =
    let v2 : char list = []
    let v3 : char list = method5(v0, v2)
    let v8 : (char list -> (char [])) = List.toArray
    let v9 : (char []) = v8 v3
    let v16 : string = v1.TrimEnd v9 
    v16
and closure31 () (v0 : (char [])) : (string -> string) =
    let v1 : char list = v0 |> Array.toList
    let v4 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v5 : (char -> (UH0 -> UH0)) = method4()
    let v6 : (char list -> (UH0 -> UH0)) = v4 v5
    let v7 : (UH0 -> UH0) = v6 v1
    let v8 : UH0 = UH0_0
    let v9 : UH0 = v7 v8
    closure34(v9)
and closure36 (v0 : UH0) (v1 : string) : string =
    let v2 : char list = []
    let v3 : char list = method5(v0, v2)
    let v8 : (char list -> (char [])) = List.toArray
    let v9 : (char []) = v8 v3
    let v16 : string = v1.TrimStart v9 
    v16
and closure35 () (v0 : (char [])) : (string -> string) =
    let v1 : char list = v0 |> Array.toList
    let v4 : ((char -> (UH0 -> UH0)) -> (char list -> (UH0 -> UH0))) = List.foldBack
    let v5 : (char -> (UH0 -> UH0)) = method4()
    let v6 : (char list -> (UH0 -> UH0)) = v4 v5
    let v7 : (UH0 -> UH0) = v6 v1
    let v8 : UH0 = UH0_0
    let v9 : UH0 = v7 v8
    closure36(v9)
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
and method6 (v0 : int64, v1 : string) : string =
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
        let v24 : string seq = v21 |> Seq.ofArray
        let v33 : (string -> (string seq -> string)) = String.concat
        let v34 : string = ""
        let v35 : (string seq -> string) = v33 v34
        v35 v24
and closure40 (v0 : int64) (v1 : string) : string =
    method6(v0, v1)
and closure39 () (v0 : int64) : (string -> string) =
    closure40(v0)
and closure41 () (v0 : exn) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v6 : string = $"%A{v0}"
    v6 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v15 : string = $"%A{v0}"
    v15 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v24 : string = $"%A{v0}"
    v24 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v33 : string = $"%A{v0}"
    v33 
    #endif
#if FABLE_COMPILER_PYTHON
    let v42 : string = $"%A{v0}"
    v42 
    #endif
#else
    let v49 : string = $"{v0.GetType ()}: {v0.Message}"
    v49 
    #endif
    |> fun x -> _v3 <- Some x
    let v50 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v50
and method7 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure43 (v0 : string) (v1 : (string [])) : string =
    let v2 : int32 = v1.Length
    let v3 : string = ""
    let v4 : Mut0 = {l0 = 0; l1 = v3} : Mut0
    while method7(v2, v4) do
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
    let v4 : (string -> (string seq -> string)) = String.concat
    let v5 : (string seq -> string) = v4 v0
    v5 v1
and closure44 () (v0 : string) : (string seq -> string) =
    closure45(v0)
and closure47 (v0 : string) (v1 : (string [])) : string =
    let v2 : string = System.String.Join (v0, v1)
    v2
and closure46 () (v0 : string) : ((string []) -> string) =
    closure47(v0)
and method8 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure48 () (v0 : string) : (char []) =
    let v1 : int32 = v0.Length
    let v2 : (char []) = Array.zeroCreate<char> (v1)
    let v3 : Mut1 = {l0 = 0} : Mut1
    while method8(v1, v3) do
        let v5 : int32 = v3.l0
        let v6 : char = v0.[int v5]
        v2.[int v5] <- v6
        let v7 : int32 = v5 + 1
        v3.l0 <- v7
        ()
    v2
let v24 : (string -> (string -> bool)) = closure0()
let contains x = v24 x
let v25 : (string -> (string -> bool)) = closure2()
let ends_with x = v25 x
let v26 : (int32 -> (char -> (string -> string))) = closure4()
let pad_left x = v26 x
let v27 : (int32 -> (char -> (string -> string))) = closure7()
let pad_right x = v27 x
let v28 : (string -> (string -> (string -> string))) = closure10()
let replace x = v28 x
let v29 : (string -> (string -> (string -> string))) = closure13()
let replace_regex x = v29 x
let v30 : (int32 -> (int32 -> (string -> string))) = closure16()
let slice x = v30 x
let v31 : (string -> (string -> (string []))) = closure19()
let split x = v31 x
let v32 : ((string []) -> (string -> (string []))) = closure21()
let split_string x = v32 x
let v33 : (string -> (string -> bool)) = closure23()
let starts_with x = v33 x
let v34 : (int32 -> (int32 -> (string -> string))) = closure25()
let substring x = v34 x
let v35 : (string -> string) = closure28()
let to_lower x = v35 x
let v36 : (string -> string) = closure29()
let to_upper x = v36 x
let v37 : (string -> string) = closure30()
let trim x = v37 x
let v38 : ((char []) -> (string -> string)) = closure31()
let trim_end x = v38 x
let v39 : ((char []) -> (string -> string)) = closure35()
let trim_start x = v39 x
let v40 : (int32 -> (string -> string)) = closure37()
let ellipsis x = v40 x
let v41 : (int64 -> (string -> string)) = closure39()
let ellipsis_end x = v41 x
let v42 : (exn -> string) = closure41()
let format_exception x = v42 x
let v43 : (string -> ((string []) -> string)) = closure42()
let concat_array_trailing x = v43 x
let v44 : (string -> (string seq -> string)) = closure44()
let concat x = v44 x
let v45 : (string -> ((string []) -> string)) = closure46()
let join' x = v45 x
let v46 : (string -> (char [])) = closure48()
let to_char_array x = v46 x
()
