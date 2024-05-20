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
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("num_complex::Complex<$0>")>]
#endif
type num_complex_Complex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::types::PyModule")>]
#endif
type pyo3_types_PyModule = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Bound<$0>")>]
#endif
type pyo3_Bound<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Python")>]
#endif
type pyo3_Python = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyAny")>]
#endif
type pyo3_PyAny = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyErr")>]
#endif
type pyo3_PyErr = class end
Fable.Core.RustInterop.emitRustExpr () ");
use pyo3::prelude::PyAnyMethods;
//"
type Mut0 = {mutable l0 : int32}
and Mut1 = {mutable l0 : int32; mutable l1 : string}
and Mut2 = {mutable l0 : int32; mutable l1 : num_complex_Complex<float>}
and [<Struct>] US0 =
    | US0_0 of f0_0 : num_complex_Complex<float>
    | US0_1
and UH0 =
    | UH0_0
    | UH0_1 of float * UH0
and Mut3 = {mutable l0 : int32; mutable l1 : float}
let rec method2 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method3 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method6 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method5 (v0 : (string [])) : string =
    let v1 : int32 = v0.Length
    let v2 : string = ""
    let v3 : Mut1 = {l0 = 0; l1 = v2} : Mut1
    while method6(v1, v3) do
        let v5 : int32 = v3.l0
        let v6 : string = v3.l1
        let v7 : string = v0.[int v5]
        let v8 : string = "\n"
        let v9 : string = v6 + v7 + v8 + ""
        let v10 : int32 = v5 + 1
        v3.l0 <- v10
        v3.l1 <- v9
        ()
    let v11 : string = v3.l1
    v11
and method7 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method8 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method9 (v0 : pyo3_Python) : pyo3_Python =
    v0
and closure1 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method10 () : (pyo3_PyErr -> std_string_String) =
    closure1()
and method11 () : string =
    let v0 : string = "fn"
    v0
and method12 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and closure2 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method13 () : (pyo3_PyErr -> std_string_String) =
    closure2()
and method14 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method15 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure3 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method16 () : (pyo3_PyErr -> std_string_String) =
    closure3()
and method17 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure4 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : bool = true
    let mutable _v1 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2
    v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4
    v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6
    v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9 
    #endif
#else
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10 
    #endif
    |> fun x -> _v1 <- Some x
    let v11 : std_string_String = _v1.Value
    v11
and method18 () : (pyo3_PyErr -> std_string_String) =
    closure4()
and method4 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
    let v3 : string = $"import sys"
    let v4 : string = $"import traceback"
    let v5 : string = $"import re"
    let v6 : string = $"count = 0"
    let v7 : string = $"memory_address_pattern = re.compile(r' at 0x[0-9a-fA-F]+')"
    let v8 : string = $"def trace_calls(frame, event, arg):"
    let v9 : string = $"    global count"
    let v10 : string = $"    count += 1"
    let v11 : string = $"    if count < 200:"
    let v12 : string = $"        try:"
    let v13 : string = $"            args = {{ k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != 'make_mpc' and k not in ['ctx'] and not callable(v) }}"
    let v14 : string = $"            args_str = ', '.join([ f\"{{k}}={{re.sub(memory_address_pattern, ' at 0x<?>', repr(v))}}\" for k, v in args.items() ])"
    let v15 : string = "zeta_"
    let v16 : string = $"            print(f\"{{event}}({v15}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split('site-packages')[-1]}} / f_back.f_lineno: {{ '' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] }} / arg: {{re.sub(memory_address_pattern, ' at 0x<?>', repr(arg))}}\", flush=True)"
    let v17 : string = $"        except ValueError as e:"
    let v18 : string = $"            print(f'{v15} / e: {{e}}', flush=True)"
    let v19 : string = $"        return trace_calls"
    let v20 : string = $"import mpmath"
    let v21 : string = $"def fn(log, s):"
    let v22 : string = $"    global count"
    let v23 : string = $"    if log:"
    let v24 : string = $"        print(f'{v15} / s: {{s}} / count: {{count}}', flush=True)"
    let v25 : string = $"    s = complex(*s)"
    let v26 : string = $"    try:"
    let v27 : string = $"        if log: sys.settrace(trace_calls)"
    let v28 : string = $"        if log:"
    let v29 : string = $"            sys.settrace(None)"
    let v30 : string = $"            print(f'{v15} / result: {{s}} / count: {{count}}', flush=True)"
    let v31 : string = $"    except ValueError as e:"
    let v32 : string = $"        if s.real == 1:"
    let v33 : string = $"            s = complex(float('inf'), 0)"
    let v34 : string = $"    return (s.real, s.imag)"
    let v35 : (string []) = [|v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v13; v14; v16; v17; v18; v19; v20; v21; v22; v23; v24; v25; v26; v27; v1; v28; v29; v30; v31; v32; v33; v34|]
    let v36 : string = method5(v35)
    let v37 : num_complex_Complex<float> = method7(v2)
    let v38 : string = "v37.re"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : num_complex_Complex<float> = method8(v2)
    let v41 : string = "v40.im"
    let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : (float * float) = v39, v42
    let v44 : (bool * (float * float)) = false, v43
    let v45 : pyo3_Python = method9(v0)
    let v46 : string = "&*$0"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v46
    let v48 : string = "pyo3::types::PyModule::from_code_bound(v45, v47, \"\", \"\")"
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : (pyo3_PyErr -> std_string_String) = method10()
    let v51 : string = "$0.map_err(|x| $1(x))"
    let v52 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v49, v50) v51
    let v53 : string = "$0.unwrap()"
    let v54 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = method11()
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : pyo3_Bound<pyo3_types_PyModule> = method12(v54)
    let v59 : string = "v58.getattr(v57)"
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (pyo3_PyErr -> std_string_String) = method13()
    let v62 : string = "$0.map_err(|x| $1(x))"
    let v63 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v60, v61) v62
    let v64 : string = "$0.unwrap()"
    let v65 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : (bool * (float * float)) = method14(v44)
    let v67 : pyo3_Bound<pyo3_PyAny> = method15(v65)
    let v68 : string = "pyo3::prelude::PyAnyMethods::call(&v67, ((*v66).0, *(*v66).1), None)"
    let v69 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v68
    let v70 : (pyo3_PyErr -> std_string_String) = method16()
    let v71 : string = "$0.map_err(|x| $1(x))"
    let v72 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v69, v70) v71
    let v73 : string = "$0?"
    let v74 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v72 v73
    let v75 : pyo3_Bound<pyo3_PyAny> = method17(v74)
    let v76 : string = "v75.extract()"
    let v77 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : (pyo3_PyErr -> std_string_String) = method18()
    let v79 : string = "$0.map_err(|x| $1(x))"
    let v80 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v77, v78) v79
    let v81 : string = "$0?"
    let struct (v82 : float, v83 : float) = Fable.Core.RustInterop.emitRustExpr v80 v81
    let v84 : string = "num_complex::Complex::new($0, $1)"
    let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v82, v83) v84
    let v86 : Result<num_complex_Complex<float>, std_string_String> = Ok v85
    v86
and method20 (v0 : Mut0) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 < 10000
    v2
and method21 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method22 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method23 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method24 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
    let v3 : string = $"import sys"
    let v4 : string = $"import traceback"
    let v5 : string = $"import re"
    let v6 : string = $"count = 0"
    let v7 : string = $"memory_address_pattern = re.compile(r' at 0x[0-9a-fA-F]+')"
    let v8 : string = $"def trace_calls(frame, event, arg):"
    let v9 : string = $"    global count"
    let v10 : string = $"    count += 1"
    let v11 : string = $"    if count < 200:"
    let v12 : string = $"        try:"
    let v13 : string = $"            args = {{ k: v for k, v in frame.f_locals.items() if frame.f_code.co_name != 'make_mpc' and k not in ['ctx'] and not callable(v) }}"
    let v14 : string = $"            args_str = ', '.join([ f\"{{k}}={{re.sub(memory_address_pattern, ' at 0x<?>', repr(v))}}\" for k, v in args.items() ])"
    let v15 : string = "gamma_"
    let v16 : string = $"            print(f\"{{event}}({v15}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split('site-packages')[-1]}} / f_back.f_lineno: {{ '' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] }} / arg: {{re.sub(memory_address_pattern, ' at 0x<?>', repr(arg))}}\", flush=True)"
    let v17 : string = $"        except ValueError as e:"
    let v18 : string = $"            print(f'{v15} / e: {{e}}', flush=True)"
    let v19 : string = $"        return trace_calls"
    let v20 : string = $"import mpmath"
    let v21 : string = $"def fn(log, s):"
    let v22 : string = $"    global count"
    let v23 : string = $"    if log:"
    let v24 : string = $"        print(f'{v15} / s: {{s}} / count: {{count}}', flush=True)"
    let v25 : string = $"    s = complex(*s)"
    let v26 : string = $"    try:"
    let v27 : string = $"        if log: sys.settrace(trace_calls)"
    let v28 : string = $"        if log:"
    let v29 : string = $"            sys.settrace(None)"
    let v30 : string = $"            print(f'{v15} / result: {{s}} / count: {{count}}', flush=True)"
    let v31 : string = $"    except ValueError as e:"
    let v32 : string = $"        if s.real == 1:"
    let v33 : string = $"            s = complex(float('inf'), 0)"
    let v34 : string = $"    return (s.real, s.imag)"
    let v35 : (string []) = [|v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v13; v14; v16; v17; v18; v19; v20; v21; v22; v23; v24; v25; v26; v27; v1; v28; v29; v30; v31; v32; v33; v34|]
    let v36 : string = method5(v35)
    let v37 : num_complex_Complex<float> = method7(v2)
    let v38 : string = "v37.re"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : num_complex_Complex<float> = method8(v2)
    let v41 : string = "v40.im"
    let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : (float * float) = v39, v42
    let v44 : (bool * (float * float)) = false, v43
    let v45 : pyo3_Python = method9(v0)
    let v46 : string = "&*$0"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v46
    let v48 : string = "pyo3::types::PyModule::from_code_bound(v45, v47, \"\", \"\")"
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : (pyo3_PyErr -> std_string_String) = method10()
    let v51 : string = "$0.map_err(|x| $1(x))"
    let v52 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v49, v50) v51
    let v53 : string = "$0.unwrap()"
    let v54 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = method11()
    let v56 : string = "&*$0"
    let v57 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v55 v56
    let v58 : pyo3_Bound<pyo3_types_PyModule> = method12(v54)
    let v59 : string = "v58.getattr(v57)"
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (pyo3_PyErr -> std_string_String) = method13()
    let v62 : string = "$0.map_err(|x| $1(x))"
    let v63 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v60, v61) v62
    let v64 : string = "$0.unwrap()"
    let v65 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v63 v64
    let v66 : (bool * (float * float)) = method14(v44)
    let v67 : pyo3_Bound<pyo3_PyAny> = method15(v65)
    let v68 : string = "pyo3::prelude::PyAnyMethods::call(&v67, ((*v66).0, *(*v66).1), None)"
    let v69 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v68
    let v70 : (pyo3_PyErr -> std_string_String) = method16()
    let v71 : string = "$0.map_err(|x| $1(x))"
    let v72 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v69, v70) v71
    let v73 : string = "$0?"
    let v74 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v72 v73
    let v75 : pyo3_Bound<pyo3_PyAny> = method17(v74)
    let v76 : string = "v75.extract()"
    let v77 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : (pyo3_PyErr -> std_string_String) = method18()
    let v79 : string = "$0.map_err(|x| $1(x))"
    let v80 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v77, v78) v79
    let v81 : string = "$0?"
    let struct (v82 : float, v83 : float) = Fable.Core.RustInterop.emitRustExpr v80 v81
    let v84 : string = "num_complex::Complex::new($0, $1)"
    let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v82, v83) v84
    let v86 : Result<num_complex_Complex<float>, std_string_String> = Ok v85
    v86
and method19 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : num_complex_Complex<float> =
    let v2 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 0, $0)"
    Fable.Core.RustInterop.emitRustExpr v1 v2
    let v3 : num_complex_Complex<float> = method7(v1)
    let v4 : string = "v3.re"
    let v5 : float = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : bool = v5 > 1.0
    if v6 then
        let v7 : string = "num_complex::Complex::new($0, $1)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v7
        let v9 : (int32 []) = Array.zeroCreate<int32> (10000)
        let v10 : Mut0 = {l0 = 0} : Mut0
        while method20(v10) do
            let v12 : int32 = v10.l0
            v9.[int v12] <- v12
            let v13 : int32 = v12 + 1
            v10.l0 <- v13
            ()
        let v14 : int32 = v9.Length
        let v15 : Mut2 = {l0 = 0; l1 = v8} : Mut2
        while method21(v14, v15) do
            let v17 : int32 = v15.l0
            let v18 : num_complex_Complex<float> = v15.l1
            let v19 : int32 = v9.[int v17]
            let v20 : string = "num_complex::Complex::new($0, $1)"
            let v21 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v20
            let v22 : float = float v19
            let v23 : string = "num_complex::Complex::new($0, $1)"
            let v24 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, 0.0) v23
            let v25 : num_complex_Complex<float> = method22(v24)
            let v26 : num_complex_Complex<float> = method23(v1)
            let v27 : string = "num_complex::Complex::powc(v25, v26)"
            let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : string = "v21 / v28"
            let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
            let v31 : string = "v18 + v30"
            let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v31
            let v33 : int32 = v17 + 1
            v15.l0 <- v33
            v15.l1 <- v32
            ()
        let v34 : num_complex_Complex<float> = v15.l1
        v34
    else
        let v35 : string = "num_complex::Complex::new($0, $1)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v35
        let v37 : string = "$0 - $1"
        let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v36, v1) v37
        let v39 : string = $"        s = mpmath.gamma(s)"
        let v40 : num_complex_Complex<float> = method3(v38)
        let v41 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v39, v40)
        let v42 : string = "v41.ok()"
        let v43 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : US0 option = None
        let _v44 = ref v44 
        match v43 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v45 : num_complex_Complex<float> = x
        let v46 : US0 = US0_0(v45)
        v46 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v44.Value <- x
        let v47 : US0 option = _v44.Value 
        let v48 : US0 = US0_1
        let v49 : US0 = v47 |> Option.defaultValue v48 
        let v50 : string = "f64::NAN"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : string = "f64::NAN"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v51, v53) v54
        let v58 : num_complex_Complex<float> =
            match v49 with
            | US0_1 -> (* None *)
                v55
            | US0_0(v56) -> (* Some *)
                v56
        let v59 : string = "num_complex::Complex::new($0, $1)"
        let v60 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v59
        let v61 : string = "$0 * $1"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v60, v1) v61
        let v63 : string = "num_complex::Complex::new($0, $1)"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v63
        let v65 : string = "v62 / v64"
        let v66 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v65
        let v67 : string = "v66.sin()"
        let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : num_complex_Complex<float> = method7(v1)
        let v70 : string = "v69.re"
        let v71 : float = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : float = 1.0 - v71
        let v73 : num_complex_Complex<float> = method8(v1)
        let v74 : string = "v73.im"
        let v75 : float = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : float =  -v75
        let v77 : string = "num_complex::Complex::new($0, $1)"
        let v78 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v72, v76) v77
        let v79 : num_complex_Complex<float> = method7(v78)
        let v80 : string = "v79.re"
        let v81 : float = Fable.Core.RustInterop.emitRustExpr () v80
        let v82 : bool = v81 <= 1.0
        let v489 : num_complex_Complex<float> =
            if v82 then
                let v83 : string = "num_complex::Complex::new($0, $1)"
                let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v83
                v84
            else
                let v85 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 1, $0)"
                Fable.Core.RustInterop.emitRustExpr v78 v85
                let v86 : num_complex_Complex<float> = method7(v78)
                let v87 : string = "v86.re"
                let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
                let v89 : bool = v88 > 1.0
                if v89 then
                    let v90 : string = "num_complex::Complex::new($0, $1)"
                    let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v90
                    let v92 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v93 : Mut0 = {l0 = 0} : Mut0
                    while method20(v93) do
                        let v95 : int32 = v93.l0
                        v92.[int v95] <- v95
                        let v96 : int32 = v95 + 1
                        v93.l0 <- v96
                        ()
                    let v97 : int32 = v92.Length
                    let v98 : Mut2 = {l0 = 0; l1 = v91} : Mut2
                    while method21(v97, v98) do
                        let v100 : int32 = v98.l0
                        let v101 : num_complex_Complex<float> = v98.l1
                        let v102 : int32 = v92.[int v100]
                        let v103 : string = "num_complex::Complex::new($0, $1)"
                        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v103
                        let v105 : float = float v102
                        let v106 : string = "num_complex::Complex::new($0, $1)"
                        let v107 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v105, 0.0) v106
                        let v108 : num_complex_Complex<float> = method22(v107)
                        let v109 : num_complex_Complex<float> = method23(v78)
                        let v110 : string = "num_complex::Complex::powc(v108, v109)"
                        let v111 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v110
                        let v112 : string = "v104 / v111"
                        let v113 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v112
                        let v114 : string = "v101 + v113"
                        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v114
                        let v116 : int32 = v100 + 1
                        v98.l0 <- v116
                        v98.l1 <- v115
                        ()
                    let v117 : num_complex_Complex<float> = v98.l1
                    v117
                else
                    let v118 : string = "num_complex::Complex::new($0, $1)"
                    let v119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v118
                    let v120 : string = "$0 - $1"
                    let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v119, v78) v120
                    let v122 : string = $"        s = mpmath.gamma(s)"
                    let v123 : num_complex_Complex<float> = method3(v121)
                    let v124 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v122, v123)
                    let v125 : string = "v124.ok()"
                    let v126 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v125
                    let v127 : US0 option = None
                    let _v127 = ref v127 
                    match v126 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v128 : num_complex_Complex<float> = x
                    let v129 : US0 = US0_0(v128)
                    v129 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v127.Value <- x
                    let v130 : US0 option = _v127.Value 
                    let v131 : US0 = US0_1
                    let v132 : US0 = v130 |> Option.defaultValue v131 
                    let v133 : string = "f64::NAN"
                    let v134 : float = Fable.Core.RustInterop.emitRustExpr () v133
                    let v135 : string = "f64::NAN"
                    let v136 : float = Fable.Core.RustInterop.emitRustExpr () v135
                    let v137 : string = "num_complex::Complex::new($0, $1)"
                    let v138 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v134, v136) v137
                    let v141 : num_complex_Complex<float> =
                        match v132 with
                        | US0_1 -> (* None *)
                            v138
                        | US0_0(v139) -> (* Some *)
                            v139
                    let v142 : string = "num_complex::Complex::new($0, $1)"
                    let v143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v142
                    let v144 : string = "$0 * $1"
                    let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v143, v78) v144
                    let v146 : string = "num_complex::Complex::new($0, $1)"
                    let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v146
                    let v148 : string = "v145 / v147"
                    let v149 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v148
                    let v150 : string = "v149.sin()"
                    let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v150
                    let v152 : num_complex_Complex<float> = method7(v78)
                    let v153 : string = "v152.re"
                    let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153
                    let v155 : float = 1.0 - v154
                    let v156 : num_complex_Complex<float> = method8(v78)
                    let v157 : string = "v156.im"
                    let v158 : float = Fable.Core.RustInterop.emitRustExpr () v157
                    let v159 : float =  -v158
                    let v160 : string = "num_complex::Complex::new($0, $1)"
                    let v161 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v155, v159) v160
                    let v162 : num_complex_Complex<float> = method7(v161)
                    let v163 : string = "v162.re"
                    let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163
                    let v165 : bool = v164 <= 1.0
                    let v471 : num_complex_Complex<float> =
                        if v165 then
                            let v166 : string = "num_complex::Complex::new($0, $1)"
                            let v167 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v166
                            v167
                        else
                            let v168 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 2, $0)"
                            Fable.Core.RustInterop.emitRustExpr v161 v168
                            let v169 : num_complex_Complex<float> = method7(v161)
                            let v170 : string = "v169.re"
                            let v171 : float = Fable.Core.RustInterop.emitRustExpr () v170
                            let v172 : bool = v171 > 1.0
                            if v172 then
                                let v173 : string = "num_complex::Complex::new($0, $1)"
                                let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v173
                                let v175 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v176 : Mut0 = {l0 = 0} : Mut0
                                while method20(v176) do
                                    let v178 : int32 = v176.l0
                                    v175.[int v178] <- v178
                                    let v179 : int32 = v178 + 1
                                    v176.l0 <- v179
                                    ()
                                let v180 : int32 = v175.Length
                                let v181 : Mut2 = {l0 = 0; l1 = v174} : Mut2
                                while method21(v180, v181) do
                                    let v183 : int32 = v181.l0
                                    let v184 : num_complex_Complex<float> = v181.l1
                                    let v185 : int32 = v175.[int v183]
                                    let v186 : string = "num_complex::Complex::new($0, $1)"
                                    let v187 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v186
                                    let v188 : float = float v185
                                    let v189 : string = "num_complex::Complex::new($0, $1)"
                                    let v190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v188, 0.0) v189
                                    let v191 : num_complex_Complex<float> = method22(v190)
                                    let v192 : num_complex_Complex<float> = method23(v161)
                                    let v193 : string = "num_complex::Complex::powc(v191, v192)"
                                    let v194 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v193
                                    let v195 : string = "v187 / v194"
                                    let v196 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v195
                                    let v197 : string = "v184 + v196"
                                    let v198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v197
                                    let v199 : int32 = v183 + 1
                                    v181.l0 <- v199
                                    v181.l1 <- v198
                                    ()
                                let v200 : num_complex_Complex<float> = v181.l1
                                v200
                            else
                                let v201 : string = "num_complex::Complex::new($0, $1)"
                                let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v201
                                let v203 : string = "$0 - $1"
                                let v204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v202, v161) v203
                                let v205 : string = $"        s = mpmath.gamma(s)"
                                let v206 : num_complex_Complex<float> = method3(v204)
                                let v207 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v205, v206)
                                let v208 : string = "v207.ok()"
                                let v209 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v208
                                let v210 : US0 option = None
                                let _v210 = ref v210 
                                match v209 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v211 : num_complex_Complex<float> = x
                                let v212 : US0 = US0_0(v211)
                                v212 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v210.Value <- x
                                let v213 : US0 option = _v210.Value 
                                let v214 : US0 = US0_1
                                let v215 : US0 = v213 |> Option.defaultValue v214 
                                let v216 : string = "f64::NAN"
                                let v217 : float = Fable.Core.RustInterop.emitRustExpr () v216
                                let v218 : string = "f64::NAN"
                                let v219 : float = Fable.Core.RustInterop.emitRustExpr () v218
                                let v220 : string = "num_complex::Complex::new($0, $1)"
                                let v221 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v217, v219) v220
                                let v224 : num_complex_Complex<float> =
                                    match v215 with
                                    | US0_1 -> (* None *)
                                        v221
                                    | US0_0(v222) -> (* Some *)
                                        v222
                                let v225 : string = "num_complex::Complex::new($0, $1)"
                                let v226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v225
                                let v227 : string = "$0 * $1"
                                let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v226, v161) v227
                                let v229 : string = "num_complex::Complex::new($0, $1)"
                                let v230 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v229
                                let v231 : string = "v228 / v230"
                                let v232 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v231
                                let v233 : string = "v232.sin()"
                                let v234 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v233
                                let v235 : num_complex_Complex<float> = method7(v161)
                                let v236 : string = "v235.re"
                                let v237 : float = Fable.Core.RustInterop.emitRustExpr () v236
                                let v238 : float = 1.0 - v237
                                let v239 : num_complex_Complex<float> = method8(v161)
                                let v240 : string = "v239.im"
                                let v241 : float = Fable.Core.RustInterop.emitRustExpr () v240
                                let v242 : float =  -v241
                                let v243 : string = "num_complex::Complex::new($0, $1)"
                                let v244 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v238, v242) v243
                                let v245 : num_complex_Complex<float> = method7(v244)
                                let v246 : string = "v245.re"
                                let v247 : float = Fable.Core.RustInterop.emitRustExpr () v246
                                let v248 : bool = v247 <= 1.0
                                let v453 : num_complex_Complex<float> =
                                    if v248 then
                                        let v249 : string = "num_complex::Complex::new($0, $1)"
                                        let v250 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v249
                                        v250
                                    else
                                        let v251 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 3, $0)"
                                        Fable.Core.RustInterop.emitRustExpr v244 v251
                                        let v252 : num_complex_Complex<float> = method7(v244)
                                        let v253 : string = "v252.re"
                                        let v254 : float = Fable.Core.RustInterop.emitRustExpr () v253
                                        let v255 : bool = v254 > 1.0
                                        if v255 then
                                            let v256 : string = "num_complex::Complex::new($0, $1)"
                                            let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v256
                                            let v258 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v259 : Mut0 = {l0 = 0} : Mut0
                                            while method20(v259) do
                                                let v261 : int32 = v259.l0
                                                v258.[int v261] <- v261
                                                let v262 : int32 = v261 + 1
                                                v259.l0 <- v262
                                                ()
                                            let v263 : int32 = v258.Length
                                            let v264 : Mut2 = {l0 = 0; l1 = v257} : Mut2
                                            while method21(v263, v264) do
                                                let v266 : int32 = v264.l0
                                                let v267 : num_complex_Complex<float> = v264.l1
                                                let v268 : int32 = v258.[int v266]
                                                let v269 : string = "num_complex::Complex::new($0, $1)"
                                                let v270 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v269
                                                let v271 : float = float v268
                                                let v272 : string = "num_complex::Complex::new($0, $1)"
                                                let v273 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v271, 0.0) v272
                                                let v274 : num_complex_Complex<float> = method22(v273)
                                                let v275 : num_complex_Complex<float> = method23(v244)
                                                let v276 : string = "num_complex::Complex::powc(v274, v275)"
                                                let v277 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v276
                                                let v278 : string = "v270 / v277"
                                                let v279 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v278
                                                let v280 : string = "v267 + v279"
                                                let v281 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v280
                                                let v282 : int32 = v266 + 1
                                                v264.l0 <- v282
                                                v264.l1 <- v281
                                                ()
                                            let v283 : num_complex_Complex<float> = v264.l1
                                            v283
                                        else
                                            let v284 : string = "num_complex::Complex::new($0, $1)"
                                            let v285 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v284
                                            let v286 : string = "$0 - $1"
                                            let v287 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v285, v244) v286
                                            let v288 : string = $"        s = mpmath.gamma(s)"
                                            let v289 : num_complex_Complex<float> = method3(v287)
                                            let v290 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v288, v289)
                                            let v291 : string = "v290.ok()"
                                            let v292 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v291
                                            let v293 : US0 option = None
                                            let _v293 = ref v293 
                                            match v292 with
                                            | Some x -> (
                                            (fun () ->
                                            (fun () ->
                                            let v294 : num_complex_Complex<float> = x
                                            let v295 : US0 = US0_0(v294)
                                            v295 
                                            )
                                            |> fun x -> x () |> Some
                                            ) () ) | None -> None
                                            |> fun x -> _v293.Value <- x
                                            let v296 : US0 option = _v293.Value 
                                            let v297 : US0 = US0_1
                                            let v298 : US0 = v296 |> Option.defaultValue v297 
                                            let v299 : string = "f64::NAN"
                                            let v300 : float = Fable.Core.RustInterop.emitRustExpr () v299
                                            let v301 : string = "f64::NAN"
                                            let v302 : float = Fable.Core.RustInterop.emitRustExpr () v301
                                            let v303 : string = "num_complex::Complex::new($0, $1)"
                                            let v304 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v300, v302) v303
                                            let v307 : num_complex_Complex<float> =
                                                match v298 with
                                                | US0_1 -> (* None *)
                                                    v304
                                                | US0_0(v305) -> (* Some *)
                                                    v305
                                            let v308 : string = "num_complex::Complex::new($0, $1)"
                                            let v309 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v308
                                            let v310 : string = "$0 * $1"
                                            let v311 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v309, v244) v310
                                            let v312 : string = "num_complex::Complex::new($0, $1)"
                                            let v313 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v312
                                            let v314 : string = "v311 / v313"
                                            let v315 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v314
                                            let v316 : string = "v315.sin()"
                                            let v317 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v316
                                            let v318 : num_complex_Complex<float> = method7(v244)
                                            let v319 : string = "v318.re"
                                            let v320 : float = Fable.Core.RustInterop.emitRustExpr () v319
                                            let v321 : float = 1.0 - v320
                                            let v322 : num_complex_Complex<float> = method8(v244)
                                            let v323 : string = "v322.im"
                                            let v324 : float = Fable.Core.RustInterop.emitRustExpr () v323
                                            let v325 : float =  -v324
                                            let v326 : string = "num_complex::Complex::new($0, $1)"
                                            let v327 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v321, v325) v326
                                            let v328 : num_complex_Complex<float> = method7(v327)
                                            let v329 : string = "v328.re"
                                            let v330 : float = Fable.Core.RustInterop.emitRustExpr () v329
                                            let v331 : bool = v330 <= 1.0
                                            let v435 : num_complex_Complex<float> =
                                                if v331 then
                                                    let v332 : string = "num_complex::Complex::new($0, $1)"
                                                    let v333 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v332
                                                    v333
                                                else
                                                    let v334 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 4, $0)"
                                                    Fable.Core.RustInterop.emitRustExpr v327 v334
                                                    let v335 : num_complex_Complex<float> = method7(v327)
                                                    let v336 : string = "v335.re"
                                                    let v337 : float = Fable.Core.RustInterop.emitRustExpr () v336
                                                    let v338 : bool = v337 > 1.0
                                                    if v338 then
                                                        let v339 : string = "num_complex::Complex::new($0, $1)"
                                                        let v340 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v339
                                                        let v341 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v342 : Mut0 = {l0 = 0} : Mut0
                                                        while method20(v342) do
                                                            let v344 : int32 = v342.l0
                                                            v341.[int v344] <- v344
                                                            let v345 : int32 = v344 + 1
                                                            v342.l0 <- v345
                                                            ()
                                                        let v346 : int32 = v341.Length
                                                        let v347 : Mut2 = {l0 = 0; l1 = v340} : Mut2
                                                        while method21(v346, v347) do
                                                            let v349 : int32 = v347.l0
                                                            let v350 : num_complex_Complex<float> = v347.l1
                                                            let v351 : int32 = v341.[int v349]
                                                            let v352 : string = "num_complex::Complex::new($0, $1)"
                                                            let v353 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v352
                                                            let v354 : float = float v351
                                                            let v355 : string = "num_complex::Complex::new($0, $1)"
                                                            let v356 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v354, 0.0) v355
                                                            let v357 : num_complex_Complex<float> = method22(v356)
                                                            let v358 : num_complex_Complex<float> = method23(v327)
                                                            let v359 : string = "num_complex::Complex::powc(v357, v358)"
                                                            let v360 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v359
                                                            let v361 : string = "v353 / v360"
                                                            let v362 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v361
                                                            let v363 : string = "v350 + v362"
                                                            let v364 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v363
                                                            let v365 : int32 = v349 + 1
                                                            v347.l0 <- v365
                                                            v347.l1 <- v364
                                                            ()
                                                        let v366 : num_complex_Complex<float> = v347.l1
                                                        v366
                                                    else
                                                        let v367 : string = "num_complex::Complex::new($0, $1)"
                                                        let v368 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v367
                                                        let v369 : string = "$0 - $1"
                                                        let v370 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v368, v327) v369
                                                        let v371 : string = $"        s = mpmath.gamma(s)"
                                                        let v372 : num_complex_Complex<float> = method3(v370)
                                                        let v373 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v371, v372)
                                                        let v374 : string = "v373.ok()"
                                                        let v375 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v374
                                                        let v376 : US0 option = None
                                                        let _v376 = ref v376 
                                                        match v375 with
                                                        | Some x -> (
                                                        (fun () ->
                                                        (fun () ->
                                                        let v377 : num_complex_Complex<float> = x
                                                        let v378 : US0 = US0_0(v377)
                                                        v378 
                                                        )
                                                        |> fun x -> x () |> Some
                                                        ) () ) | None -> None
                                                        |> fun x -> _v376.Value <- x
                                                        let v379 : US0 option = _v376.Value 
                                                        let v380 : US0 = US0_1
                                                        let v381 : US0 = v379 |> Option.defaultValue v380 
                                                        let v382 : string = "f64::NAN"
                                                        let v383 : float = Fable.Core.RustInterop.emitRustExpr () v382
                                                        let v384 : string = "f64::NAN"
                                                        let v385 : float = Fable.Core.RustInterop.emitRustExpr () v384
                                                        let v386 : string = "num_complex::Complex::new($0, $1)"
                                                        let v387 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v383, v385) v386
                                                        let v390 : num_complex_Complex<float> =
                                                            match v381 with
                                                            | US0_1 -> (* None *)
                                                                v387
                                                            | US0_0(v388) -> (* Some *)
                                                                v388
                                                        let v391 : string = "num_complex::Complex::new($0, $1)"
                                                        let v392 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v391
                                                        let v393 : string = "$0 * $1"
                                                        let v394 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v392, v327) v393
                                                        let v395 : string = "num_complex::Complex::new($0, $1)"
                                                        let v396 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v395
                                                        let v397 : string = "v394 / v396"
                                                        let v398 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v397
                                                        let v399 : string = "v398.sin()"
                                                        let v400 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v399
                                                        let v401 : num_complex_Complex<float> = method7(v327)
                                                        let v402 : string = "v401.re"
                                                        let v403 : float = Fable.Core.RustInterop.emitRustExpr () v402
                                                        let v404 : float = 1.0 - v403
                                                        let v405 : num_complex_Complex<float> = method8(v327)
                                                        let v406 : string = "v405.im"
                                                        let v407 : float = Fable.Core.RustInterop.emitRustExpr () v406
                                                        let v408 : float =  -v407
                                                        let v409 : string = "num_complex::Complex::new($0, $1)"
                                                        let v410 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v404, v408) v409
                                                        let v411 : num_complex_Complex<float> = method7(v410)
                                                        let v412 : string = "v411.re"
                                                        let v413 : float = Fable.Core.RustInterop.emitRustExpr () v412
                                                        let v414 : bool = v413 <= 1.0
                                                        let v417 : num_complex_Complex<float> =
                                                            if v414 then
                                                                let v415 : string = "num_complex::Complex::new($0, $1)"
                                                                let v416 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v415
                                                                v416
                                                            else
                                                                v410
                                                        let v418 : string = "num_complex::Complex::new($0, $1)"
                                                        let v419 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v418
                                                        let v420 : string = "num_complex::Complex::new($0, $1)"
                                                        let v421 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v420
                                                        let v422 : num_complex_Complex<float> = method22(v421)
                                                        let v423 : num_complex_Complex<float> = method23(v327)
                                                        let v424 : string = "num_complex::Complex::powc(v422, v423)"
                                                        let v425 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v424
                                                        let v426 : string = "$0 * $1"
                                                        let v427 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v419, v425) v426
                                                        let v428 : string = "$0 * $1"
                                                        let v429 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v427, v400) v428
                                                        let v430 : string = "$0 * $1"
                                                        let v431 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v429, v390) v430
                                                        let v432 : string = "$0 * $1"
                                                        let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v431, v417) v432
                                                        v433
                                            let v436 : string = "num_complex::Complex::new($0, $1)"
                                            let v437 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v436
                                            let v438 : string = "num_complex::Complex::new($0, $1)"
                                            let v439 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v438
                                            let v440 : num_complex_Complex<float> = method22(v439)
                                            let v441 : num_complex_Complex<float> = method23(v244)
                                            let v442 : string = "num_complex::Complex::powc(v440, v441)"
                                            let v443 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v442
                                            let v444 : string = "$0 * $1"
                                            let v445 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v437, v443) v444
                                            let v446 : string = "$0 * $1"
                                            let v447 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v445, v317) v446
                                            let v448 : string = "$0 * $1"
                                            let v449 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v447, v307) v448
                                            let v450 : string = "$0 * $1"
                                            let v451 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v449, v435) v450
                                            v451
                                let v454 : string = "num_complex::Complex::new($0, $1)"
                                let v455 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v454
                                let v456 : string = "num_complex::Complex::new($0, $1)"
                                let v457 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v456
                                let v458 : num_complex_Complex<float> = method22(v457)
                                let v459 : num_complex_Complex<float> = method23(v161)
                                let v460 : string = "num_complex::Complex::powc(v458, v459)"
                                let v461 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v460
                                let v462 : string = "$0 * $1"
                                let v463 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v455, v461) v462
                                let v464 : string = "$0 * $1"
                                let v465 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v463, v234) v464
                                let v466 : string = "$0 * $1"
                                let v467 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v465, v224) v466
                                let v468 : string = "$0 * $1"
                                let v469 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v467, v453) v468
                                v469
                    let v472 : string = "num_complex::Complex::new($0, $1)"
                    let v473 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v472
                    let v474 : string = "num_complex::Complex::new($0, $1)"
                    let v475 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v474
                    let v476 : num_complex_Complex<float> = method22(v475)
                    let v477 : num_complex_Complex<float> = method23(v78)
                    let v478 : string = "num_complex::Complex::powc(v476, v477)"
                    let v479 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v478
                    let v480 : string = "$0 * $1"
                    let v481 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v473, v479) v480
                    let v482 : string = "$0 * $1"
                    let v483 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v481, v151) v482
                    let v484 : string = "$0 * $1"
                    let v485 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v483, v141) v484
                    let v486 : string = "$0 * $1"
                    let v487 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v485, v471) v486
                    v487
        let v490 : string = "num_complex::Complex::new($0, $1)"
        let v491 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v490
        let v492 : string = "num_complex::Complex::new($0, $1)"
        let v493 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v492
        let v494 : num_complex_Complex<float> = method22(v493)
        let v495 : num_complex_Complex<float> = method23(v1)
        let v496 : string = "num_complex::Complex::powc(v494, v495)"
        let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v496
        let v498 : string = "$0 * $1"
        let v499 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v491, v497) v498
        let v500 : string = "$0 * $1"
        let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v499, v68) v500
        let v502 : string = "$0 * $1"
        let v503 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v501, v58) v502
        let v504 : string = "$0 * $1"
        let v505 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v503, v489) v504
        v505
and method25 (v0 : bool) : bool =
    v0
and method1 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1
    let v3 : string = "num_complex::Complex::new($0, $1)"
    let v4 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (-1.0, 0.0) v3
    let v5 : (struct (num_complex_Complex<float> * float) []) = [|struct (v2, 1.6449340668482264); struct (v4, -0.08333333333333333)|]
    let v6 : int32 = v5.Length
    let v7 : Mut0 = {l0 = 0} : Mut0
    while method2(v6, v7) do
        let v9 : int32 = v7.l0
        let struct (v10 : num_complex_Complex<float>, v11 : float) = v5.[int v9]
        let v12 : string = $"        s = mpmath.zeta(s)"
        let v13 : num_complex_Complex<float> = method3(v10)
        let v14 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v12, v13)
        let v15 : num_complex_Complex<float> = method19(v0, v10)
        let v16 : string = "v14.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v16
        let v18 : US0 option = None
        let _v18 = ref v18 
        match v17 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v19 : num_complex_Complex<float> = x
        let v20 : US0 = US0_0(v19)
        v20 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v18.Value <- x
        let v21 : US0 option = _v18.Value 
        let v22 : US0 = US0_1
        let v23 : US0 = v21 |> Option.defaultValue v22 
        let v24 : string = "f64::NAN"
        let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
        let v26 : string = "f64::NAN"
        let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26
        let v28 : string = "num_complex::Complex::new($0, $1)"
        let v29 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v25, v27) v28
        let v32 : num_complex_Complex<float> =
            match v23 with
            | US0_1 -> (* None *)
                v29
            | US0_0(v30) -> (* Some *)
                v30
        let v33 : num_complex_Complex<float> = method8(v32)
        let v34 : string = "v33.im"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
        let v36 : bool = v35 = 0.0
        let v38 : bool =
            if v36 then
                true
            else
                method25(v36)
        let v39 : string = "assert_eq"
        let v40 : string = $"{v39} / actual: %A{v35} / expected: %A{0.0}"
        System.Console.WriteLine v40
        let v41 : bool = v38 = false
        if v41 then
            failwith<unit> v40
        let v42 : num_complex_Complex<float> = method7(v32)
        let v43 : string = "v42.re"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : float = v44 - v11
        let v46 : float =  -v45
        let v47 : bool = v45 >= v46
        let v48 : float =
            if v47 then
                v45
            else
                v46
        let v49 : bool = v48 < 0.0001
        let v51 : bool =
            if v49 then
                true
            else
                method25(v49)
        let v52 : string = "assert_lt"
        let v53 : string = $"{v52} / actual: %A{v48} / expected: %A{0.0001}"
        System.Console.WriteLine v53
        let v54 : bool = v51 = false
        if v54 then
            failwith<unit> v53
        let v55 : int32 = v9 + 1
        v7.l0 <- v55
        ()
    ()
and method26 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method0 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method1(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method28 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : US0 option = None
    let _v9 = ref v9 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : num_complex_Complex<float> = x
    let v11 : US0 = US0_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US0 option = _v9.Value 
    let v13 : US0 = US0_1
    let v14 : US0 = v12 |> Option.defaultValue v13 
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "num_complex::Complex::new($0, $1)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v19
    let v23 : num_complex_Complex<float> =
        match v14 with
        | US0_1 -> (* None *)
            v20
        | US0_0(v21) -> (* Some *)
            v21
    let v24 : num_complex_Complex<float> = method7(v23)
    let v25 : string = "v24.re"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : float = v26 - 0.8673
    let v28 : float =  -v27
    let v29 : bool = v27 >= v28
    let v30 : float =
        if v29 then
            v27
        else
            v28
    let v31 : bool = v30 < 0.001
    let v33 : bool =
        if v31 then
            true
        else
            method25(v31)
    let v34 : string = "assert_lt"
    let v35 : string = $"{v34} / actual: %A{v30} / expected: %A{0.001}"
    System.Console.WriteLine v35
    let v36 : bool = v33 = false
    if v36 then
        failwith<unit> v35
    let v37 : num_complex_Complex<float> = method8(v23)
    let v38 : string = "v37.im"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : float = v39 - 0.275
    let v41 : float =  -v40
    let v42 : bool = v40 >= v41
    let v43 : float =
        if v42 then
            v40
        else
            v41
    let v44 : bool = v43 < 0.001
    let v46 : bool =
        if v44 then
            true
        else
            method25(v44)
    let v47 : string = $"{v34} / actual: %A{v43} / expected: %A{0.001}"
    System.Console.WriteLine v47
    let v48 : bool = v46 = false
    if v48 then
        failwith<unit> v47
and method27 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method28(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method31 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(-40.0, v0)
    let v2 : UH0 = UH0_1(-38.0, v1)
    let v3 : UH0 = UH0_1(-36.0, v2)
    let v4 : UH0 = UH0_1(-34.0, v3)
    let v5 : UH0 = UH0_1(-32.0, v4)
    let v6 : UH0 = UH0_1(-30.0, v5)
    let v7 : UH0 = UH0_1(-28.0, v6)
    let v8 : UH0 = UH0_1(-26.0, v7)
    let v9 : UH0 = UH0_1(-24.0, v8)
    let v10 : UH0 = UH0_1(-22.0, v9)
    let v11 : UH0 = UH0_1(-20.0, v10)
    let v12 : UH0 = UH0_1(-18.0, v11)
    let v13 : UH0 = UH0_1(-16.0, v12)
    let v14 : UH0 = UH0_1(-14.0, v13)
    let v15 : UH0 = UH0_1(-12.0, v14)
    let v16 : UH0 = UH0_1(-10.0, v15)
    let v17 : UH0 = UH0_1(-8.0, v16)
    let v18 : UH0 = UH0_1(-6.0, v17)
    let v19 : UH0 = UH0_1(-4.0, v18)
    UH0_1(-2.0, v19)
and method32 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, 0.0) v4
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method19(v0, v5)
        let v10 : string = "v8.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10
        let v12 : US0 option = None
        let _v12 = ref v12 
        match v11 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v13 : num_complex_Complex<float> = x
        let v14 : US0 = US0_0(v13)
        v14 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v12.Value <- x
        let v15 : US0 option = _v12.Value 
        let v16 : US0 = US0_1
        let v17 : US0 = v15 |> Option.defaultValue v16 
        let v18 : string = "f64::NAN"
        let v19 : float = Fable.Core.RustInterop.emitRustExpr () v18
        let v20 : string = "f64::NAN"
        let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20
        let v22 : string = "num_complex::Complex::new($0, $1)"
        let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v19, v21) v22
        let v26 : num_complex_Complex<float> =
            match v17 with
            | US0_1 -> (* None *)
                v23
            | US0_0(v24) -> (* Some *)
                v24
        let v27 : num_complex_Complex<float> = method7(v26)
        let v28 : string = "v27.re"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : bool = v29 = 0.0
        let v32 : bool =
            if v30 then
                true
            else
                method25(v30)
        let v33 : string = "assert_eq"
        let v34 : string = $"{v33} / actual: %A{v29} / expected: %A{0.0}"
        System.Console.WriteLine v34
        let v35 : bool = v32 = false
        if v35 then
            failwith<unit> v34
        let v36 : num_complex_Complex<float> = method8(v26)
        let v37 : string = "v36.im"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : bool = v38 = 0.0
        let v41 : bool =
            if v39 then
                true
            else
                method25(v39)
        let v42 : string = $"{v33} / actual: %A{v38} / expected: %A{0.0}"
        System.Console.WriteLine v42
        let v43 : bool = v41 = false
        if v43 then
            failwith<unit> v42
        method32(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method30 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method31()
    method32(v0, v1)
and method29 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method30(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method34 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 14.134725) v1
    let v3 : string = "num_complex::Complex::new($0, $1)"
    let v4 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 21.02204) v3
    let v5 : string = "num_complex::Complex::new($0, $1)"
    let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 25.010857) v5
    let v7 : string = "num_complex::Complex::new($0, $1)"
    let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 30.424876) v7
    let v9 : string = "num_complex::Complex::new($0, $1)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 32.935062) v9
    let v11 : string = "num_complex::Complex::new($0, $1)"
    let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 37.586178) v11
    let v13 : (num_complex_Complex<float> []) = [|v2; v4; v6; v8; v10; v12|]
    let v14 : int32 = v13.Length
    let v15 : Mut0 = {l0 = 0} : Mut0
    while method2(v14, v15) do
        let v17 : int32 = v15.l0
        let v18 : num_complex_Complex<float> = v13.[int v17]
        let v19 : string = $"        s = mpmath.zeta(s)"
        let v20 : num_complex_Complex<float> = method3(v18)
        let v21 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v19, v20)
        let v22 : num_complex_Complex<float> = method19(v0, v18)
        let v23 : string = "v21.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : US0 option = None
        let _v25 = ref v25 
        match v24 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v26 : num_complex_Complex<float> = x
        let v27 : US0 = US0_0(v26)
        v27 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v25.Value <- x
        let v28 : US0 option = _v25.Value 
        let v29 : US0 = US0_1
        let v30 : US0 = v28 |> Option.defaultValue v29 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : string = "f64::NAN"
        let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33
        let v35 : string = "num_complex::Complex::new($0, $1)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v32, v34) v35
        let v39 : num_complex_Complex<float> =
            match v30 with
            | US0_1 -> (* None *)
                v36
            | US0_0(v37) -> (* Some *)
                v37
        let v40 : num_complex_Complex<float> = method7(v39)
        let v41 : string = "v40.re"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : float =  -v42
        let v44 : bool = v42 >= v43
        let v45 : float =
            if v44 then
                v42
            else
                v43
        let v46 : bool = v45 < 0.0001
        let v48 : bool =
            if v46 then
                true
            else
                method25(v46)
        let v49 : string = "assert_lt"
        let v50 : string = $"{v49} / actual: %A{v45} / expected: %A{0.0001}"
        System.Console.WriteLine v50
        let v51 : bool = v48 = false
        if v51 then
            failwith<unit> v50
        let v52 : num_complex_Complex<float> = method8(v39)
        let v53 : string = "v52.im"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53
        let v55 : float =  -v54
        let v56 : bool = v54 >= v55
        let v57 : float =
            if v56 then
                v54
            else
                v55
        let v58 : bool = v57 < 0.0001
        let v60 : bool =
            if v58 then
                true
            else
                method25(v58)
        let v61 : string = $"{v49} / actual: %A{v57} / expected: %A{0.0001}"
        System.Console.WriteLine v61
        let v62 : bool = v60 = false
        if v62 then
            failwith<unit> v61
        let v63 : int32 = v17 + 1
        v15.l0 <- v63
        ()
    ()
and method33 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method34(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method36 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 3.0; 4.0; 5.0; 10.0; 20.0; 50.0|]
    let v2 : int32 = v1.Length
    let v3 : Mut0 = {l0 = 0} : Mut0
    while method2(v2, v3) do
        let v5 : int32 = v3.l0
        let v6 : float = v1.[int v5]
        let v7 : string = "num_complex::Complex::new($0, $1)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v6, 0.0) v7
        let v9 : string = $"        s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method3(v8)
        let v11 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9, v10)
        let v12 : num_complex_Complex<float> = method19(v0, v8)
        let v13 : string = "v11.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : US0 option = None
        let _v15 = ref v15 
        match v14 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v16 : num_complex_Complex<float> = x
        let v17 : US0 = US0_0(v16)
        v17 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v15.Value <- x
        let v18 : US0 option = _v15.Value 
        let v19 : US0 = US0_1
        let v20 : US0 = v18 |> Option.defaultValue v19 
        let v21 : string = "f64::NAN"
        let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : string = "num_complex::Complex::new($0, $1)"
        let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, v24) v25
        let v29 : num_complex_Complex<float> =
            match v20 with
            | US0_1 -> (* None *)
                v26
            | US0_0(v27) -> (* Some *)
                v27
        let v30 : num_complex_Complex<float> = method7(v29)
        let v31 : string = "v30.re"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : bool = v32 > 0.0
        let v35 : bool =
            if v33 then
                true
            else
                method25(v33)
        let v36 : string = "assert_gt"
        let v37 : string = $"{v36} / actual: %A{v32} / expected: %A{0.0}"
        System.Console.WriteLine v37
        let v38 : bool = v35 = false
        if v38 then
            failwith<unit> v37
        let v39 : num_complex_Complex<float> = method8(v29)
        let v40 : string = "v39.im"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : bool = v41 = 0.0
        let v44 : bool =
            if v42 then
                true
            else
                method25(v42)
        let v45 : string = "assert_eq"
        let v46 : string = $"{v45} / actual: %A{v41} / expected: %A{0.0}"
        System.Console.WriteLine v46
        let v47 : bool = v44 = false
        if v47 then
            failwith<unit> v46
        let v48 : int32 = v5 + 1
        v3.l0 <- v48
        ()
    ()
and method35 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method36(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method38 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : US0 option = None
    let _v9 = ref v9 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : num_complex_Complex<float> = x
    let v11 : US0 = US0_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US0 option = _v9.Value 
    let v13 : US0 = US0_1
    let v14 : US0 = v12 |> Option.defaultValue v13 
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "num_complex::Complex::new($0, $1)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v19
    let v23 : num_complex_Complex<float> =
        match v14 with
        | US0_1 -> (* None *)
            v20
        | US0_0(v21) -> (* Some *)
            v21
    let v24 : num_complex_Complex<float> = method7(v23)
    let v25 : string = "v24.re"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : bool = v26 = infinity
    let v29 : bool =
        if v27 then
            true
        else
            method25(v27)
    let v30 : string = "assert_eq"
    let v31 : string = $"{v30} / actual: %A{v26} / expected: %A{infinity}"
    System.Console.WriteLine v31
    let v32 : bool = v29 = false
    if v32 then
        failwith<unit> v31
    let v33 : num_complex_Complex<float> = method8(v23)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : bool = v35 = 0.0
    let v38 : bool =
        if v36 then
            true
        else
            method25(v36)
    let v39 : string = $"{v30} / actual: %A{v35} / expected: %A{0.0}"
    System.Console.WriteLine v39
    let v40 : bool = v38 = false
    if v40 then
        failwith<unit> v39
and method37 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method38(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method40 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : US0 option = None
    let _v9 = ref v9 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : num_complex_Complex<float> = x
    let v11 : US0 = US0_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US0 option = _v9.Value 
    let v13 : US0 = US0_1
    let v14 : US0 = v12 |> Option.defaultValue v13 
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "num_complex::Complex::new($0, $1)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v19
    let v23 : num_complex_Complex<float> =
        match v14 with
        | US0_1 -> (* None *)
            v20
        | US0_0(v21) -> (* Some *)
            v21
    let v24 : num_complex_Complex<float> = method7(v2)
    let v25 : string = "v24.re"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : num_complex_Complex<float> = method8(v2)
    let v28 : string = "v27.im"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : float =  -v29
    let v31 : string = "num_complex::Complex::new($0, $1)"
    let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v26, v30) v31
    let v33 : string = $"        s = mpmath.zeta(s)"
    let v34 : num_complex_Complex<float> = method3(v32)
    let v35 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v33, v34)
    let v36 : num_complex_Complex<float> = method19(v0, v32)
    let v37 : string = "v35.ok()"
    let v38 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v37
    let v39 : US0 option = None
    let _v39 = ref v39 
    match v38 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v40 : num_complex_Complex<float> = x
    let v41 : US0 = US0_0(v40)
    v41 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v39.Value <- x
    let v42 : US0 option = _v39.Value 
    let v43 : US0 = US0_1
    let v44 : US0 = v42 |> Option.defaultValue v43 
    let v45 : string = "f64::NAN"
    let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = "f64::NAN"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : string = "num_complex::Complex::new($0, $1)"
    let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v46, v48) v49
    let v53 : num_complex_Complex<float> =
        match v44 with
        | US0_1 -> (* None *)
            v50
        | US0_0(v51) -> (* Some *)
            v51
    let v54 : string = "v53.conj()"
    let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : num_complex_Complex<float> = method7(v23)
    let v57 : string = "v56.re"
    let v58 : float = Fable.Core.RustInterop.emitRustExpr () v57
    let v59 : num_complex_Complex<float> = method7(v55)
    let v60 : string = "v59.re"
    let v61 : float = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : bool = v58 = v61
    let v64 : bool =
        if v62 then
            true
        else
            method25(v62)
    let v65 : string = "assert_eq"
    let v66 : string = $"{v65} / actual: %A{v58} / expected: %A{v61}"
    System.Console.WriteLine v66
    let v67 : bool = v64 = false
    if v67 then
        failwith<unit> v66
    let v68 : num_complex_Complex<float> = method8(v23)
    let v69 : string = "v68.im"
    let v70 : float = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : num_complex_Complex<float> = method8(v55)
    let v72 : string = "v71.im"
    let v73 : float = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : bool = v70 = v73
    let v76 : bool =
        if v74 then
            true
        else
            method25(v74)
    let v77 : string = $"{v65} / actual: %A{v70} / expected: %A{v73}"
    System.Console.WriteLine v77
    let v78 : bool = v76 = false
    if v78 then
        failwith<unit> v77
and method39 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method40(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method42 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : US0 option = None
    let _v9 = ref v9 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v10 : num_complex_Complex<float> = x
    let v11 : US0 = US0_0(v10)
    v11 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v9.Value <- x
    let v12 : US0 option = _v9.Value 
    let v13 : US0 = US0_1
    let v14 : US0 = v12 |> Option.defaultValue v13 
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : string = "num_complex::Complex::new($0, $1)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v16, v18) v19
    let v23 : num_complex_Complex<float> =
        match v14 with
        | US0_1 -> (* None *)
            v20
        | US0_0(v21) -> (* Some *)
            v21
    let v24 : num_complex_Complex<float> = method7(v23)
    let v25 : string = "v24.re"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : bool = v26 < infinity
    let v29 : bool =
        if v27 then
            true
        else
            method25(v27)
    let v30 : string = "assert_lt"
    let v31 : string = $"{v30} / actual: %A{v26} / expected: %A{infinity}"
    System.Console.WriteLine v31
    let v32 : bool = v29 = false
    if v32 then
        failwith<unit> v31
    let v33 : num_complex_Complex<float> = method8(v23)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : bool = v35 < infinity
    let v38 : bool =
        if v36 then
            true
        else
            method25(v36)
    let v39 : string = $"{v30} / actual: %A{v35} / expected: %A{infinity}"
    System.Console.WriteLine v39
    let v40 : bool = v38 = false
    if v40 then
        failwith<unit> v39
and method41 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method42(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method45 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    v0
and method44 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = method45()
    let v2 : int32 = v1.Length
    let v3 : Mut0 = {l0 = 0} : Mut0
    while method2(v2, v3) do
        let v5 : int32 = v3.l0
        let v6 : float = v1.[int v5]
        let v7 : string = "num_complex::Complex::new($0, $1)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, v6) v7
        let v9 : string = $"        s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method3(v8)
        let v11 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9, v10)
        let v12 : num_complex_Complex<float> = method19(v0, v8)
        let v13 : string = "v11.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : US0 option = None
        let _v15 = ref v15 
        match v14 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v16 : num_complex_Complex<float> = x
        let v17 : US0 = US0_0(v16)
        v17 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v15.Value <- x
        let v18 : US0 option = _v15.Value 
        let v19 : US0 = US0_1
        let v20 : US0 = v18 |> Option.defaultValue v19 
        let v21 : string = "f64::NAN"
        let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : string = "num_complex::Complex::new($0, $1)"
        let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, v24) v25
        let v29 : num_complex_Complex<float> =
            match v20 with
            | US0_1 -> (* None *)
                v26
            | US0_0(v27) -> (* Some *)
                v27
        let v30 : num_complex_Complex<float> = method7(v29)
        let v31 : string = "v30.re"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : bool = v32 <> 0.0
        let v35 : bool =
            if v33 then
                true
            else
                method25(v33)
        let v36 : string = "assert_ne"
        let v37 : string = $"{v36} / actual: %A{v32} / expected: %A{0.0}"
        System.Console.WriteLine v37
        let v38 : bool = v35 = false
        if v38 then
            failwith<unit> v37
        let v39 : num_complex_Complex<float> = method8(v29)
        let v40 : string = "v39.im"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : bool = v41 <> 0.0
        let v44 : bool =
            if v42 then
                true
            else
                method25(v42)
        let v45 : string = $"{v36} / actual: %A{v41} / expected: %A{0.0}"
        System.Console.WriteLine v45
        let v46 : bool = v44 = false
        if v46 then
            failwith<unit> v45
        let v47 : int32 = v5 + 1
        v3.l0 <- v47
        ()
    ()
and method43 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method44(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method47 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 14.134725) v1
    let v3 : string = "num_complex::Complex::new($0, $1)"
    let v4 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.75, 20.5) v3
    let v5 : string = "num_complex::Complex::new($0, $1)"
    let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.25, 30.1) v5
    let v7 : string = "num_complex::Complex::new($0, $1)"
    let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.25, 40.0) v7
    let v9 : string = "num_complex::Complex::new($0, $1)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 50.0) v9
    let v11 : (num_complex_Complex<float> []) = [|v2; v4; v6; v8; v10|]
    let v12 : int32 = v11.Length
    let v13 : Mut0 = {l0 = 0} : Mut0
    while method2(v12, v13) do
        let v15 : int32 = v13.l0
        let v16 : num_complex_Complex<float> = v11.[int v15]
        let v17 : string = $"        s = mpmath.zeta(s)"
        let v18 : num_complex_Complex<float> = method3(v16)
        let v19 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v17, v18)
        let v20 : num_complex_Complex<float> = method19(v0, v16)
        let v21 : string = "v19.ok()"
        let v22 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : US0 option = None
        let _v23 = ref v23 
        match v22 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v24 : num_complex_Complex<float> = x
        let v25 : US0 = US0_0(v24)
        v25 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v23.Value <- x
        let v26 : US0 option = _v23.Value 
        let v27 : US0 = US0_1
        let v28 : US0 = v26 |> Option.defaultValue v27 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33
        let v37 : num_complex_Complex<float> =
            match v28 with
            | US0_1 -> (* None *)
                v34
            | US0_0(v35) -> (* Some *)
                v35
        let v38 : num_complex_Complex<float> = method7(v37)
        let v39 : string = "v38.re"
        let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : bool = v40 <> 0.0
        let v43 : bool =
            if v41 then
                true
            else
                method25(v41)
        let v44 : string = "assert_ne"
        let v45 : string = $"{v44} / actual: %A{v40} / expected: %A{0.0}"
        System.Console.WriteLine v45
        let v46 : bool = v43 = false
        if v46 then
            failwith<unit> v45
        let v47 : num_complex_Complex<float> = method8(v37)
        let v48 : string = "v47.im"
        let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : bool = v49 <> 0.0
        let v52 : bool =
            if v50 then
                true
            else
                method25(v50)
        let v53 : string = $"{v44} / actual: %A{v49} / expected: %A{0.0}"
        System.Console.WriteLine v53
        let v54 : bool = v52 = false
        if v54 then
            failwith<unit> v53
        let v55 : int32 = v15 + 1
        v13.l0 <- v55
        ()
    ()
and method46 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method47(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method49 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.0, 4.0) v1
    let v3 : string = "num_complex::Complex::new($0, $1)"
    let v4 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.5, -3.5) v3
    let v5 : string = "num_complex::Complex::new($0, $1)"
    let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.5, 2.5) v5
    let v7 : string = "num_complex::Complex::new($0, $1)"
    let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 14.134725) v7
    let v9 : (num_complex_Complex<float> []) = [|v2; v4; v6; v8|]
    let v10 : int32 = v9.Length
    let v11 : Mut0 = {l0 = 0} : Mut0
    while method2(v10, v11) do
        let v13 : int32 = v11.l0
        let v14 : num_complex_Complex<float> = v9.[int v13]
        let v15 : string = $"        s = mpmath.zeta(s)"
        let v16 : num_complex_Complex<float> = method3(v14)
        let v17 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v15, v16)
        let v18 : num_complex_Complex<float> = method19(v0, v14)
        let v19 : string = "v17.ok()"
        let v20 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v19
        let v21 : US0 option = None
        let _v21 = ref v21 
        match v20 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v22 : num_complex_Complex<float> = x
        let v23 : US0 = US0_0(v22)
        v23 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v21.Value <- x
        let v24 : US0 option = _v21.Value 
        let v25 : US0 = US0_1
        let v26 : US0 = v24 |> Option.defaultValue v25 
        let v27 : string = "f64::NAN"
        let v28 : float = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : string = "num_complex::Complex::new($0, $1)"
        let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v28, v30) v31
        let v35 : num_complex_Complex<float> =
            match v26 with
            | US0_1 -> (* None *)
                v32
            | US0_0(v33) -> (* Some *)
                v33
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v36
        let v38 : num_complex_Complex<float> = method22(v37)
        let v39 : num_complex_Complex<float> = method23(v14)
        let v40 : string = "num_complex::Complex::powc(v38, v39)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : string = "num_complex::Complex::new($0, $1)"
        let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v42
        let v44 : string = "num_complex::Complex::new($0, $1)"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v44
        let v46 : string = "$0 - $1"
        let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v14, v45) v46
        let v48 : num_complex_Complex<float> = method22(v43)
        let v49 : num_complex_Complex<float> = method23(v47)
        let v50 : string = "num_complex::Complex::powc(v48, v49)"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : string = "$0 * $1"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v41, v51) v52
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v54
        let v56 : string = "$0 * $1"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v14) v56
        let v58 : string = "num_complex::Complex::new($0, $1)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v58
        let v60 : string = "v57 / v59"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : string = "v61.sin()"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : string = "$0 * $1"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v63) v64
        let v66 : string = "num_complex::Complex::new($0, $1)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v66
        let v68 : string = "$0 - $1"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v67, v14) v68
        let v70 : string = $"        s = mpmath.gamma(s)"
        let v71 : num_complex_Complex<float> = method3(v69)
        let v72 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v70, v71)
        let v73 : string = "v72.ok()"
        let v74 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : US0 option = None
        let _v75 = ref v75 
        match v74 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v76 : num_complex_Complex<float> = x
        let v77 : US0 = US0_0(v76)
        v77 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v75.Value <- x
        let v78 : US0 option = _v75.Value 
        let v79 : US0 = US0_1
        let v80 : US0 = v78 |> Option.defaultValue v79 
        let v81 : string = "f64::NAN"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : string = "f64::NAN"
        let v84 : float = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : string = "num_complex::Complex::new($0, $1)"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v82, v84) v85
        let v89 : num_complex_Complex<float> =
            match v80 with
            | US0_1 -> (* None *)
                v86
            | US0_0(v87) -> (* Some *)
                v87
        let v90 : string = "$0 * $1"
        let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v65, v89) v90
        let v92 : num_complex_Complex<float> = method7(v14)
        let v93 : string = "v92.re"
        let v94 : float = Fable.Core.RustInterop.emitRustExpr () v93
        let v95 : float = 1.0 - v94
        let v96 : num_complex_Complex<float> = method8(v14)
        let v97 : string = "v96.im"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr () v97
        let v99 : float =  -v98
        let v100 : string = "num_complex::Complex::new($0, $1)"
        let v101 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v95, v99) v100
        let v102 : string = $"        s = mpmath.zeta(s)"
        let v103 : num_complex_Complex<float> = method3(v101)
        let v104 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v102, v103)
        let v105 : num_complex_Complex<float> = method19(v0, v101)
        let v106 : string = "v104.ok()"
        let v107 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v106
        let v108 : US0 option = None
        let _v108 = ref v108 
        match v107 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v109 : num_complex_Complex<float> = x
        let v110 : US0 = US0_0(v109)
        v110 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v108.Value <- x
        let v111 : US0 option = _v108.Value 
        let v112 : US0 = US0_1
        let v113 : US0 = v111 |> Option.defaultValue v112 
        let v114 : string = "f64::NAN"
        let v115 : float = Fable.Core.RustInterop.emitRustExpr () v114
        let v116 : string = "f64::NAN"
        let v117 : float = Fable.Core.RustInterop.emitRustExpr () v116
        let v118 : string = "num_complex::Complex::new($0, $1)"
        let v119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v115, v117) v118
        let v122 : num_complex_Complex<float> =
            match v113 with
            | US0_1 -> (* None *)
                v119
            | US0_0(v120) -> (* Some *)
                v120
        let v123 : string = "$0 * $1"
        let v124 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v91, v122) v123
        let v125 : num_complex_Complex<float> = method7(v35)
        let v126 : string = "v125.re"
        let v127 : float = Fable.Core.RustInterop.emitRustExpr () v126
        let v128 : num_complex_Complex<float> = method7(v124)
        let v129 : string = "v128.re"
        let v130 : float = Fable.Core.RustInterop.emitRustExpr () v129
        let v131 : float = v127 - v130
        let v132 : float =  -v131
        let v133 : bool = v131 >= v132
        let v134 : float =
            if v133 then
                v131
            else
                v132
        let v135 : bool = v134 < 0.0001
        let v137 : bool =
            if v135 then
                true
            else
                method25(v135)
        let v138 : string = "assert_lt"
        let v139 : string = $"{v138} / actual: %A{v134} / expected: %A{0.0001}"
        System.Console.WriteLine v139
        let v140 : bool = v137 = false
        if v140 then
            failwith<unit> v139
        let v141 : num_complex_Complex<float> = method8(v35)
        let v142 : string = "v141.im"
        let v143 : float = Fable.Core.RustInterop.emitRustExpr () v142
        let v144 : num_complex_Complex<float> = method8(v124)
        let v145 : string = "v144.im"
        let v146 : float = Fable.Core.RustInterop.emitRustExpr () v145
        let v147 : float = v143 - v146
        let v148 : float =  -v147
        let v149 : bool = v147 >= v148
        let v150 : float =
            if v149 then
                v147
            else
                v148
        let v151 : bool = v150 < 0.0001
        let v153 : bool =
            if v151 then
                true
            else
                method25(v151)
        let v154 : string = $"{v138} / actual: %A{v150} / expected: %A{0.0001}"
        System.Console.WriteLine v154
        let v155 : bool = v153 = false
        if v155 then
            failwith<unit> v154
        let v156 : int32 = v13 + 1
        v11.l0 <- v156
        ()
    ()
and method48 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method49(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and method52 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method51 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0|]
    let v2 : (float []) = [|2.0; 3.0; 5.0; 7.0; 11.0; 13.0; 17.0; 19.0; 23.0; 29.0; 31.0; 37.0; 41.0; 43.0; 47.0; 53.0; 59.0; 61.0; 67.0; 71.0|]
    let v3 : int32 = v1.Length
    let v4 : Mut0 = {l0 = 0} : Mut0
    while method2(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : float = v1.[int v6]
        let v8 : string = "num_complex::Complex::new($0, $1)"
        let v9 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v7, 0.0) v8
        let v10 : int32 = v2.Length
        let v11 : Mut3 = {l0 = 0; l1 = 1.0} : Mut3
        while method52(v10, v11) do
            let v13 : int32 = v11.l0
            let v14 : float = v11.l1
            let v15 : float = v2.[int v13]
            let v16 : float =  -v7
            let v17 : float = v15 ** v16
            let v18 : float = 1.0 - v17
            let v19 : float = v14 / v18
            let v20 : int32 = v13 + 1
            v11.l0 <- v20
            v11.l1 <- v19
            ()
        let v21 : float = v11.l1
        let v22 : string = $"        s = mpmath.zeta(s)"
        let v23 : num_complex_Complex<float> = method3(v9)
        let v24 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v22, v23)
        let v25 : num_complex_Complex<float> = method19(v0, v9)
        let v26 : string = "v24.ok()"
        let v27 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v26
        let v28 : US0 option = None
        let _v28 = ref v28 
        match v27 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v29 : num_complex_Complex<float> = x
        let v30 : US0 = US0_0(v29)
        v30 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v28.Value <- x
        let v31 : US0 option = _v28.Value 
        let v32 : US0 = US0_1
        let v33 : US0 = v31 |> Option.defaultValue v32 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : string = "num_complex::Complex::new($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v35, v37) v38
        let v42 : num_complex_Complex<float> =
            match v33 with
            | US0_1 -> (* None *)
                v39
            | US0_0(v40) -> (* Some *)
                v40
        let v43 : num_complex_Complex<float> = method7(v42)
        let v44 : string = "v43.re"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : float = v45 - v21
        let v47 : float =  -v46
        let v48 : bool = v46 >= v47
        let v49 : float =
            if v48 then
                v46
            else
                v47
        let v50 : bool = v49 < 0.01
        let v52 : bool =
            if v50 then
                true
            else
                method25(v50)
        let v53 : string = "assert_lt"
        let v54 : string = $"{v53} / actual: %A{v49} / expected: %A{0.01}"
        System.Console.WriteLine v54
        let v55 : bool = v52 = false
        if v55 then
            failwith<unit> v54
        let v56 : num_complex_Complex<float> = method8(v42)
        let v57 : string = "v56.im"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : bool = v58 < 0.01
        let v61 : bool =
            if v59 then
                true
            else
                method25(v59)
        let v62 : string = $"{v53} / actual: %A{v58} / expected: %A{0.01}"
        System.Console.WriteLine v62
        let v63 : bool = v61 = false
        if v63 then
            failwith<unit> v62
        let v64 : int32 = v6 + 1
        v4.l0 <- v64
        ()
    ()
and method50 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method51(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method26(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7
    let v9 : string = v8 + v7
    let v10 : string = "{"
    let v11 : string = v6 + v10
    let v12 : string = "v5 " + v9 + "); " + v11 + " //"
    Fable.Core.RustInterop.emitRustExpr () v12
    let v13 : string = "__result"
    let v14 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v13
    let v15 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v14 v15
    ()
and closure0 () () : unit =
    let v0 : string = "true; () //"
    let v1 : bool = Fable.Core.RustInterop.emitRustExpr () v0
    let v2 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v2
    let v3 : string = "test_zeta_at_known_values_"
    let v4 : string = $"*/ #[test] fn " + v3 + "() { //"
    let v5 : bool = Fable.Core.RustInterop.emitRustExpr () v4
    method0()
    let v6 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "test_zeta_at_2_minus2"
    let v8 : string = $"*/ #[test] fn " + v7 + "() { //"
    let v9 : bool = Fable.Core.RustInterop.emitRustExpr () v8
    method27()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12
    method29()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16
    method33()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20
    method35()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24
    method37()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28
    method39()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32
    method41()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36
    method43()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40
    method46()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44
    method48()
    let v46 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v46
    let v47 : string = "test_euler_product_formula"
    let v48 : string = $"*/ #[test] fn " + v47 + "() { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48
    method50()
    let v50 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v50
    let v51 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v51
    let v52 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v52
    let v53 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v53
    let v54 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v54
    let v55 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v55
    let v56 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v56
    let v57 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v57
    let v58 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v58
    let v59 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v59
    let v60 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v60
    let v61 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v61
    ()
and closure5 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure5()
let main args = v1 args
()
