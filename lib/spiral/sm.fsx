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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures")>]
#endif
type regex_Captures = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Error")>]
#endif
type regex_Error = class end
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
and method0 (v0 : string) : string =
    v0
and method1 (v0 : string) : string =
    v0
and method2 (v0 : string) : string =
    v0
and method3 (v0 : string) : string =
    v0
and closure15 (v0 : string, v1 : string) (v2 : string) : string =
    let v3 : bool = true
    let mutable _v3 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = method0(v2)
    let v5 : string = method1(v1)
    let v6 : bool = true
    let mutable _v6 : Result<regex_Regex, regex_Error> option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v7 : string = method2(v0)
    let v8 : string = $"regex::Regex::new(&$0)"
    let v9 : Result<regex_Regex, regex_Error> = Fable.Core.RustInterop.emitRustExpr v7 v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v10 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v11 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v11 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v13 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v13 
    #endif
#else
    let v14 : Result<regex_Regex, regex_Error> = null |> unbox<Result<regex_Regex, regex_Error>>
    v14 
    #endif
    |> fun x -> _v6 <- Some x
    let v15 : Result<regex_Regex, regex_Error> = match _v6 with Some x -> x | None -> failwith "base.run_target / _v6=None"
    let v16 : string = "$0.unwrap()"
    let v17 : regex_Regex = Fable.Core.RustInterop.emitRustExpr v15 v16 
    let v18 : string = $"$0.replace_all(&$1, &*$2)"
    let v19 : std_borrow_Cow<Str> = Fable.Core.RustInterop.emitRustExpr struct (v17, v4, v5) v18 
    let v20 : string = "String::from($0)"
    let v21 : std_string_String = Fable.Core.RustInterop.emitRustExpr v19 v20 
    let v22 : string = "fable_library_rust::String_::fromString($0)"
    let v23 : string = Fable.Core.RustInterop.emitRustExpr v21 v22 
    v23 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v24 : string = null |> unbox<string>
    v24 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v25 : string = null |> unbox<string>
    v25 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v26 : string = null |> unbox<string>
    v26 
    #endif
#if FABLE_COMPILER_PYTHON
    let v27 : string = null |> unbox<string>
    v27 
    #endif
#else
    let v28 : string = method3(v1)
    let v29 : string = System.Text.RegularExpressions.Regex.Replace (v2, v0, v28)
    v29 
    #endif
    |> fun x -> _v3 <- Some x
    let v30 : string = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v30
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
and method4 () : string =
    let v0 : string = ""
    v0
and closure22 (v0 : (string [])) (v1 : string) : (string []) =
    let v2 : bool = true
    let mutable _v2 : (string []) option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : ((string []) -> string seq) = Seq.ofArray
    let v4 : string seq = v3 v0
    let v5 : string = method4()
    let v6 : (string -> (string seq -> string)) = String.concat
    let v7 : (string seq -> string) = v6 v5
    let v8 : string = v7 v4
    let v9 : (string []) = v1.Split v8 
    v9 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v10 : ((string []) -> string seq) = Seq.ofArray
    let v11 : string seq = v10 v0
    let v12 : string = method4()
    let v13 : (string -> (string seq -> string)) = String.concat
    let v14 : (string seq -> string) = v13 v12
    let v15 : string = v14 v11
    let v16 : (string []) = v1.Split v15 
    v16 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v17 : ((string []) -> string seq) = Seq.ofArray
    let v18 : string seq = v17 v0
    let v19 : string = method4()
    let v20 : (string -> (string seq -> string)) = String.concat
    let v21 : (string seq -> string) = v20 v19
    let v22 : string = v21 v18
    let v23 : (string []) = v1.Split v22 
    v23 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v24 : ((string []) -> string seq) = Seq.ofArray
    let v25 : string seq = v24 v0
    let v26 : string = method4()
    let v27 : (string -> (string seq -> string)) = String.concat
    let v28 : (string seq -> string) = v27 v26
    let v29 : string = v28 v25
    let v30 : (string []) = v1.Split v29 
    v30 
    #endif
#if FABLE_COMPILER_PYTHON
    let v31 : ((string []) -> string seq) = Seq.ofArray
    let v32 : string seq = v31 v0
    let v33 : string = method4()
    let v34 : (string -> (string seq -> string)) = String.concat
    let v35 : (string seq -> string) = v34 v33
    let v36 : string = v35 v32
    let v37 : (string []) = v1.Split v36 
    v37 
    #endif
#else
    let v38 : (string []) = v1.Split (v0, System.StringSplitOptions.None)
    v38 
    #endif
    |> fun x -> _v2 <- Some x
    let v39 : (string []) = match _v2 with Some x -> x | None -> failwith "base.run_target / _v2=None"
    v39
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
and closure32 (v0 : (char [])) (v1 : string) : string =
    let v2 : string = v1.TrimEnd v0 
    v2
and closure31 () (v0 : (char [])) : (string -> string) =
    closure32(v0)
and closure34 (v0 : (char [])) (v1 : string) : string =
    let v2 : string = v1.TrimStart v0 
    v2
and closure33 () (v0 : (char [])) : (string -> string) =
    closure34(v0)
and closure36 (v0 : int32) (v1 : string) : string =
    let v2 : int32 = v1.Length
    let v3 : bool = v2 <= v0
    if v3 then
        v1
    else
        let v4 : int32 = v0 - 1
        let v5 : string = v1.[int 0..int v4]
        let v6 : string = v5 + "..."
        v6
and closure35 () (v0 : int32) : (string -> string) =
    closure36(v0)
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
        let v22 : ((string []) -> string seq) = Seq.ofArray
        let v23 : string seq = v22 v21
        let v24 : string = method4()
        let v25 : (string -> (string seq -> string)) = String.concat
        let v26 : (string seq -> string) = v25 v24
        v26 v23
and closure38 (v0 : int64) (v1 : string) : string =
    method5(v0, v1)
and closure37 () (v0 : int64) : (string -> string) =
    closure38(v0)
and closure39 () (v0 : exn) : string =
    let v1 : bool = true
    let mutable _v1 : string option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = $"%A{v0}"
    v2 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3 : string = $"%A{v0}"
    v3 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v4 : string = $"%A{v0}"
    v4 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v5 : string = $"%A{v0}"
    v5 
    #endif
#if FABLE_COMPILER_PYTHON
    let v6 : string = $"%A{v0}"
    v6 
    #endif
#else
    let v7 : string = $"{v0.GetType ()}: {v0.Message}"
    v7 
    #endif
    |> fun x -> _v1 <- Some x
    let v8 : string = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
    v8
and method6 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure41 (v0 : string) (v1 : (string [])) : string =
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
and closure40 () (v0 : string) : ((string []) -> string) =
    closure41(v0)
and method7 (v0 : string) : string =
    v0
and closure43 (v0 : string) (v1 : string seq) : string =
    let v2 : string = method7(v0)
    let v3 : (string -> (string seq -> string)) = String.concat
    let v4 : (string seq -> string) = v3 v2
    v4 v1
and closure42 () (v0 : string) : (string seq -> string) =
    closure43(v0)
and closure45 (v0 : string) (v1 : (string [])) : string =
    let v2 : string = System.String.Join (v0, v1)
    v2
and closure44 () (v0 : string) : ((string []) -> string) =
    closure45(v0)
and method8 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and closure46 () (v0 : string) : (char []) =
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
let v15 : ((char []) -> (string -> string)) = closure33()
let trim_start x = v15 x
let v16 : (int32 -> (string -> string)) = closure35()
let ellipsis x = v16 x
let v17 : (int64 -> (string -> string)) = closure37()
let ellipsis_end x = v17 x
let v18 : (exn -> string) = closure39()
let format_exception x = v18 x
let v19 : (string -> ((string []) -> string)) = closure40()
let concat_array_trailing x = v19 x
let v20 : (string -> (string seq -> string)) = closure42()
let concat x = v20 x
let v21 : (string -> ((string []) -> string)) = closure44()
let join' x = v21 x
let v22 : (string -> (char [])) = closure46()
let to_char_array x = v22 x
()
