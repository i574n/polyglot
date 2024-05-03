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
[<Fable.Core.Erase; Fable.Core.Emit("$0 + Send")>]
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
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>]
#endif
type StaticRef<'T> = class end
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
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method10 () : (pyo3_PyErr -> std_string_String) =
    closure1()
and method11 () : string =
    let v0 : string = "fn"
    v0
and method12 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and closure2 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method13 () : (pyo3_PyErr -> std_string_String) =
    closure2()
and method14 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method15 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure3 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
and method16 () : (pyo3_PyErr -> std_string_String) =
    closure3()
and method17 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure4 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : std_string_String option = None
    let v2 : bool = true in let mutable _v1 = v1
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3 : string = @$"format!(""{{}}"", $0)"
    let v4 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v3
    v4
#endif
    
#if FABLE_COMPILER_RUST && WASM
    let v5 : string = @$"format!(""{{}}"", $0)"
    let v6 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v5
    v6
#endif
    
#if FABLE_COMPILER_RUST && CONTRACT
    let v7 : string = @$"format!(""{{}}"", $0)"
    let v8 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v7
    v8
#endif
    
#if FABLE_COMPILER_TYPESCRIPT
    let v9 : std_string_String = null |> unbox<std_string_String>
    v9
#endif
    
#if FABLE_COMPILER_PYTHON
    let v10 : std_string_String = null |> unbox<std_string_String>
    v10
#endif
    
#else
    let v11 : std_string_String = null |> unbox<std_string_String>
    v11
#endif
    |> fun x -> _v1 <- Some x
    let v12 : std_string_String = _v1.Value
    v12
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
    let v46 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v46
    let v48 : string = "pyo3::types::PyModule::from_code_bound(v45, v47, \"\", \"\")"
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : (pyo3_PyErr -> std_string_String) = method10()
    let v51 : string = "$0.map_err(|x| $1(x))"
    let v52 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v49, v50) v51
    let v53 : string = "$0.unwrap()"
    let v54 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = method11()
    let v56 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
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
    let v46 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
    let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v46
    let v48 : string = "pyo3::types::PyModule::from_code_bound(v45, v47, \"\", \"\")"
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : (pyo3_PyErr -> std_string_String) = method10()
    let v51 : string = "$0.map_err(|x| $1(x))"
    let v52 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v49, v50) v51
    let v53 : string = "$0.unwrap()"
    let v54 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v52 v53
    let v55 : string = method11()
    let v56 : string = "fable_library_rust::String_::LrcStr::as_str(&$0)"
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
and closure5 () (v0 : num_complex_Complex<float>) : US0 =
    US0_0(v0)
and method25 () : (num_complex_Complex<float> -> US0) =
    closure5()
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
        let v44 : (num_complex_Complex<float> -> US0) = method25()
        let v45 : US0 = US0_1
        let v46 : US0 = v43 |> Option.map v44 |> Option.defaultValue v45 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v50) v51
        let v55 : num_complex_Complex<float> =
            match v46 with
            | US0_1 -> (* None *)
                v52
            | US0_0(v53) -> (* Some *)
                v53
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v56
        let v58 : string = "$0 * $1"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v1) v58
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v60
        let v62 : string = "v59 / v61"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : string = "v63.sin()"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : num_complex_Complex<float> = method7(v1)
        let v67 : string = "v66.re"
        let v68 : float = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : float = 1.0 - v68
        let v70 : num_complex_Complex<float> = method8(v1)
        let v71 : string = "v70.im"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71
        let v73 : float =  -v72
        let v74 : string = "num_complex::Complex::new($0, $1)"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v69, v73) v74
        let v76 : num_complex_Complex<float> = method7(v75)
        let v77 : string = "v76.re"
        let v78 : float = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : bool = v78 <= 1.0
        let v474 : num_complex_Complex<float> =
            if v79 then
                let v80 : string = "num_complex::Complex::new($0, $1)"
                let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v80
                v81
            else
                let v82 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 1, $0)"
                Fable.Core.RustInterop.emitRustExpr v75 v82
                let v83 : num_complex_Complex<float> = method7(v75)
                let v84 : string = "v83.re"
                let v85 : float = Fable.Core.RustInterop.emitRustExpr () v84
                let v86 : bool = v85 > 1.0
                if v86 then
                    let v87 : string = "num_complex::Complex::new($0, $1)"
                    let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v87
                    let v89 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v90 : Mut0 = {l0 = 0} : Mut0
                    while method20(v90) do
                        let v92 : int32 = v90.l0
                        v89.[int v92] <- v92
                        let v93 : int32 = v92 + 1
                        v90.l0 <- v93
                        ()
                    let v94 : int32 = v89.Length
                    let v95 : Mut2 = {l0 = 0; l1 = v88} : Mut2
                    while method21(v94, v95) do
                        let v97 : int32 = v95.l0
                        let v98 : num_complex_Complex<float> = v95.l1
                        let v99 : int32 = v89.[int v97]
                        let v100 : string = "num_complex::Complex::new($0, $1)"
                        let v101 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v100
                        let v102 : float = float v99
                        let v103 : string = "num_complex::Complex::new($0, $1)"
                        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v102, 0.0) v103
                        let v105 : num_complex_Complex<float> = method22(v104)
                        let v106 : num_complex_Complex<float> = method23(v75)
                        let v107 : string = "num_complex::Complex::powc(v105, v106)"
                        let v108 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v107
                        let v109 : string = "v101 / v108"
                        let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v109
                        let v111 : string = "v98 + v110"
                        let v112 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v111
                        let v113 : int32 = v97 + 1
                        v95.l0 <- v113
                        v95.l1 <- v112
                        ()
                    let v114 : num_complex_Complex<float> = v95.l1
                    v114
                else
                    let v115 : string = "num_complex::Complex::new($0, $1)"
                    let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v115
                    let v117 : string = "$0 - $1"
                    let v118 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v116, v75) v117
                    let v119 : string = $"        s = mpmath.gamma(s)"
                    let v120 : num_complex_Complex<float> = method3(v118)
                    let v121 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v119, v120)
                    let v122 : string = "v121.ok()"
                    let v123 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v122
                    let v124 : (num_complex_Complex<float> -> US0) = method25()
                    let v125 : US0 = US0_1
                    let v126 : US0 = v123 |> Option.map v124 |> Option.defaultValue v125 
                    let v127 : string = "f64::NAN"
                    let v128 : float = Fable.Core.RustInterop.emitRustExpr () v127
                    let v129 : string = "f64::NAN"
                    let v130 : float = Fable.Core.RustInterop.emitRustExpr () v129
                    let v131 : string = "num_complex::Complex::new($0, $1)"
                    let v132 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v128, v130) v131
                    let v135 : num_complex_Complex<float> =
                        match v126 with
                        | US0_1 -> (* None *)
                            v132
                        | US0_0(v133) -> (* Some *)
                            v133
                    let v136 : string = "num_complex::Complex::new($0, $1)"
                    let v137 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v136
                    let v138 : string = "$0 * $1"
                    let v139 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v137, v75) v138
                    let v140 : string = "num_complex::Complex::new($0, $1)"
                    let v141 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v140
                    let v142 : string = "v139 / v141"
                    let v143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v142
                    let v144 : string = "v143.sin()"
                    let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v144
                    let v146 : num_complex_Complex<float> = method7(v75)
                    let v147 : string = "v146.re"
                    let v148 : float = Fable.Core.RustInterop.emitRustExpr () v147
                    let v149 : float = 1.0 - v148
                    let v150 : num_complex_Complex<float> = method8(v75)
                    let v151 : string = "v150.im"
                    let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151
                    let v153 : float =  -v152
                    let v154 : string = "num_complex::Complex::new($0, $1)"
                    let v155 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v149, v153) v154
                    let v156 : num_complex_Complex<float> = method7(v155)
                    let v157 : string = "v156.re"
                    let v158 : float = Fable.Core.RustInterop.emitRustExpr () v157
                    let v159 : bool = v158 <= 1.0
                    let v456 : num_complex_Complex<float> =
                        if v159 then
                            let v160 : string = "num_complex::Complex::new($0, $1)"
                            let v161 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v160
                            v161
                        else
                            let v162 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 2, $0)"
                            Fable.Core.RustInterop.emitRustExpr v155 v162
                            let v163 : num_complex_Complex<float> = method7(v155)
                            let v164 : string = "v163.re"
                            let v165 : float = Fable.Core.RustInterop.emitRustExpr () v164
                            let v166 : bool = v165 > 1.0
                            if v166 then
                                let v167 : string = "num_complex::Complex::new($0, $1)"
                                let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v167
                                let v169 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v170 : Mut0 = {l0 = 0} : Mut0
                                while method20(v170) do
                                    let v172 : int32 = v170.l0
                                    v169.[int v172] <- v172
                                    let v173 : int32 = v172 + 1
                                    v170.l0 <- v173
                                    ()
                                let v174 : int32 = v169.Length
                                let v175 : Mut2 = {l0 = 0; l1 = v168} : Mut2
                                while method21(v174, v175) do
                                    let v177 : int32 = v175.l0
                                    let v178 : num_complex_Complex<float> = v175.l1
                                    let v179 : int32 = v169.[int v177]
                                    let v180 : string = "num_complex::Complex::new($0, $1)"
                                    let v181 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v180
                                    let v182 : float = float v179
                                    let v183 : string = "num_complex::Complex::new($0, $1)"
                                    let v184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v182, 0.0) v183
                                    let v185 : num_complex_Complex<float> = method22(v184)
                                    let v186 : num_complex_Complex<float> = method23(v155)
                                    let v187 : string = "num_complex::Complex::powc(v185, v186)"
                                    let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v187
                                    let v189 : string = "v181 / v188"
                                    let v190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v189
                                    let v191 : string = "v178 + v190"
                                    let v192 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v191
                                    let v193 : int32 = v177 + 1
                                    v175.l0 <- v193
                                    v175.l1 <- v192
                                    ()
                                let v194 : num_complex_Complex<float> = v175.l1
                                v194
                            else
                                let v195 : string = "num_complex::Complex::new($0, $1)"
                                let v196 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v195
                                let v197 : string = "$0 - $1"
                                let v198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v196, v155) v197
                                let v199 : string = $"        s = mpmath.gamma(s)"
                                let v200 : num_complex_Complex<float> = method3(v198)
                                let v201 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v199, v200)
                                let v202 : string = "v201.ok()"
                                let v203 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v202
                                let v204 : (num_complex_Complex<float> -> US0) = method25()
                                let v205 : US0 = US0_1
                                let v206 : US0 = v203 |> Option.map v204 |> Option.defaultValue v205 
                                let v207 : string = "f64::NAN"
                                let v208 : float = Fable.Core.RustInterop.emitRustExpr () v207
                                let v209 : string = "f64::NAN"
                                let v210 : float = Fable.Core.RustInterop.emitRustExpr () v209
                                let v211 : string = "num_complex::Complex::new($0, $1)"
                                let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v208, v210) v211
                                let v215 : num_complex_Complex<float> =
                                    match v206 with
                                    | US0_1 -> (* None *)
                                        v212
                                    | US0_0(v213) -> (* Some *)
                                        v213
                                let v216 : string = "num_complex::Complex::new($0, $1)"
                                let v217 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v216
                                let v218 : string = "$0 * $1"
                                let v219 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v217, v155) v218
                                let v220 : string = "num_complex::Complex::new($0, $1)"
                                let v221 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v220
                                let v222 : string = "v219 / v221"
                                let v223 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v222
                                let v224 : string = "v223.sin()"
                                let v225 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v224
                                let v226 : num_complex_Complex<float> = method7(v155)
                                let v227 : string = "v226.re"
                                let v228 : float = Fable.Core.RustInterop.emitRustExpr () v227
                                let v229 : float = 1.0 - v228
                                let v230 : num_complex_Complex<float> = method8(v155)
                                let v231 : string = "v230.im"
                                let v232 : float = Fable.Core.RustInterop.emitRustExpr () v231
                                let v233 : float =  -v232
                                let v234 : string = "num_complex::Complex::new($0, $1)"
                                let v235 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v229, v233) v234
                                let v236 : num_complex_Complex<float> = method7(v235)
                                let v237 : string = "v236.re"
                                let v238 : float = Fable.Core.RustInterop.emitRustExpr () v237
                                let v239 : bool = v238 <= 1.0
                                let v438 : num_complex_Complex<float> =
                                    if v239 then
                                        let v240 : string = "num_complex::Complex::new($0, $1)"
                                        let v241 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v240
                                        v241
                                    else
                                        let v242 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 3, $0)"
                                        Fable.Core.RustInterop.emitRustExpr v235 v242
                                        let v243 : num_complex_Complex<float> = method7(v235)
                                        let v244 : string = "v243.re"
                                        let v245 : float = Fable.Core.RustInterop.emitRustExpr () v244
                                        let v246 : bool = v245 > 1.0
                                        if v246 then
                                            let v247 : string = "num_complex::Complex::new($0, $1)"
                                            let v248 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v247
                                            let v249 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v250 : Mut0 = {l0 = 0} : Mut0
                                            while method20(v250) do
                                                let v252 : int32 = v250.l0
                                                v249.[int v252] <- v252
                                                let v253 : int32 = v252 + 1
                                                v250.l0 <- v253
                                                ()
                                            let v254 : int32 = v249.Length
                                            let v255 : Mut2 = {l0 = 0; l1 = v248} : Mut2
                                            while method21(v254, v255) do
                                                let v257 : int32 = v255.l0
                                                let v258 : num_complex_Complex<float> = v255.l1
                                                let v259 : int32 = v249.[int v257]
                                                let v260 : string = "num_complex::Complex::new($0, $1)"
                                                let v261 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v260
                                                let v262 : float = float v259
                                                let v263 : string = "num_complex::Complex::new($0, $1)"
                                                let v264 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v262, 0.0) v263
                                                let v265 : num_complex_Complex<float> = method22(v264)
                                                let v266 : num_complex_Complex<float> = method23(v235)
                                                let v267 : string = "num_complex::Complex::powc(v265, v266)"
                                                let v268 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v267
                                                let v269 : string = "v261 / v268"
                                                let v270 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v269
                                                let v271 : string = "v258 + v270"
                                                let v272 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v271
                                                let v273 : int32 = v257 + 1
                                                v255.l0 <- v273
                                                v255.l1 <- v272
                                                ()
                                            let v274 : num_complex_Complex<float> = v255.l1
                                            v274
                                        else
                                            let v275 : string = "num_complex::Complex::new($0, $1)"
                                            let v276 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v275
                                            let v277 : string = "$0 - $1"
                                            let v278 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v276, v235) v277
                                            let v279 : string = $"        s = mpmath.gamma(s)"
                                            let v280 : num_complex_Complex<float> = method3(v278)
                                            let v281 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v279, v280)
                                            let v282 : string = "v281.ok()"
                                            let v283 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v282
                                            let v284 : (num_complex_Complex<float> -> US0) = method25()
                                            let v285 : US0 = US0_1
                                            let v286 : US0 = v283 |> Option.map v284 |> Option.defaultValue v285 
                                            let v287 : string = "f64::NAN"
                                            let v288 : float = Fable.Core.RustInterop.emitRustExpr () v287
                                            let v289 : string = "f64::NAN"
                                            let v290 : float = Fable.Core.RustInterop.emitRustExpr () v289
                                            let v291 : string = "num_complex::Complex::new($0, $1)"
                                            let v292 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v288, v290) v291
                                            let v295 : num_complex_Complex<float> =
                                                match v286 with
                                                | US0_1 -> (* None *)
                                                    v292
                                                | US0_0(v293) -> (* Some *)
                                                    v293
                                            let v296 : string = "num_complex::Complex::new($0, $1)"
                                            let v297 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v296
                                            let v298 : string = "$0 * $1"
                                            let v299 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v297, v235) v298
                                            let v300 : string = "num_complex::Complex::new($0, $1)"
                                            let v301 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v300
                                            let v302 : string = "v299 / v301"
                                            let v303 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v302
                                            let v304 : string = "v303.sin()"
                                            let v305 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v304
                                            let v306 : num_complex_Complex<float> = method7(v235)
                                            let v307 : string = "v306.re"
                                            let v308 : float = Fable.Core.RustInterop.emitRustExpr () v307
                                            let v309 : float = 1.0 - v308
                                            let v310 : num_complex_Complex<float> = method8(v235)
                                            let v311 : string = "v310.im"
                                            let v312 : float = Fable.Core.RustInterop.emitRustExpr () v311
                                            let v313 : float =  -v312
                                            let v314 : string = "num_complex::Complex::new($0, $1)"
                                            let v315 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v309, v313) v314
                                            let v316 : num_complex_Complex<float> = method7(v315)
                                            let v317 : string = "v316.re"
                                            let v318 : float = Fable.Core.RustInterop.emitRustExpr () v317
                                            let v319 : bool = v318 <= 1.0
                                            let v420 : num_complex_Complex<float> =
                                                if v319 then
                                                    let v320 : string = "num_complex::Complex::new($0, $1)"
                                                    let v321 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v320
                                                    v321
                                                else
                                                    let v322 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 4, $0)"
                                                    Fable.Core.RustInterop.emitRustExpr v315 v322
                                                    let v323 : num_complex_Complex<float> = method7(v315)
                                                    let v324 : string = "v323.re"
                                                    let v325 : float = Fable.Core.RustInterop.emitRustExpr () v324
                                                    let v326 : bool = v325 > 1.0
                                                    if v326 then
                                                        let v327 : string = "num_complex::Complex::new($0, $1)"
                                                        let v328 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v327
                                                        let v329 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v330 : Mut0 = {l0 = 0} : Mut0
                                                        while method20(v330) do
                                                            let v332 : int32 = v330.l0
                                                            v329.[int v332] <- v332
                                                            let v333 : int32 = v332 + 1
                                                            v330.l0 <- v333
                                                            ()
                                                        let v334 : int32 = v329.Length
                                                        let v335 : Mut2 = {l0 = 0; l1 = v328} : Mut2
                                                        while method21(v334, v335) do
                                                            let v337 : int32 = v335.l0
                                                            let v338 : num_complex_Complex<float> = v335.l1
                                                            let v339 : int32 = v329.[int v337]
                                                            let v340 : string = "num_complex::Complex::new($0, $1)"
                                                            let v341 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v340
                                                            let v342 : float = float v339
                                                            let v343 : string = "num_complex::Complex::new($0, $1)"
                                                            let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v342, 0.0) v343
                                                            let v345 : num_complex_Complex<float> = method22(v344)
                                                            let v346 : num_complex_Complex<float> = method23(v315)
                                                            let v347 : string = "num_complex::Complex::powc(v345, v346)"
                                                            let v348 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v347
                                                            let v349 : string = "v341 / v348"
                                                            let v350 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v349
                                                            let v351 : string = "v338 + v350"
                                                            let v352 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v351
                                                            let v353 : int32 = v337 + 1
                                                            v335.l0 <- v353
                                                            v335.l1 <- v352
                                                            ()
                                                        let v354 : num_complex_Complex<float> = v335.l1
                                                        v354
                                                    else
                                                        let v355 : string = "num_complex::Complex::new($0, $1)"
                                                        let v356 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v355
                                                        let v357 : string = "$0 - $1"
                                                        let v358 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v356, v315) v357
                                                        let v359 : string = $"        s = mpmath.gamma(s)"
                                                        let v360 : num_complex_Complex<float> = method3(v358)
                                                        let v361 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v359, v360)
                                                        let v362 : string = "v361.ok()"
                                                        let v363 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v362
                                                        let v364 : (num_complex_Complex<float> -> US0) = method25()
                                                        let v365 : US0 = US0_1
                                                        let v366 : US0 = v363 |> Option.map v364 |> Option.defaultValue v365 
                                                        let v367 : string = "f64::NAN"
                                                        let v368 : float = Fable.Core.RustInterop.emitRustExpr () v367
                                                        let v369 : string = "f64::NAN"
                                                        let v370 : float = Fable.Core.RustInterop.emitRustExpr () v369
                                                        let v371 : string = "num_complex::Complex::new($0, $1)"
                                                        let v372 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v368, v370) v371
                                                        let v375 : num_complex_Complex<float> =
                                                            match v366 with
                                                            | US0_1 -> (* None *)
                                                                v372
                                                            | US0_0(v373) -> (* Some *)
                                                                v373
                                                        let v376 : string = "num_complex::Complex::new($0, $1)"
                                                        let v377 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v376
                                                        let v378 : string = "$0 * $1"
                                                        let v379 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v377, v315) v378
                                                        let v380 : string = "num_complex::Complex::new($0, $1)"
                                                        let v381 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v380
                                                        let v382 : string = "v379 / v381"
                                                        let v383 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v382
                                                        let v384 : string = "v383.sin()"
                                                        let v385 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v384
                                                        let v386 : num_complex_Complex<float> = method7(v315)
                                                        let v387 : string = "v386.re"
                                                        let v388 : float = Fable.Core.RustInterop.emitRustExpr () v387
                                                        let v389 : float = 1.0 - v388
                                                        let v390 : num_complex_Complex<float> = method8(v315)
                                                        let v391 : string = "v390.im"
                                                        let v392 : float = Fable.Core.RustInterop.emitRustExpr () v391
                                                        let v393 : float =  -v392
                                                        let v394 : string = "num_complex::Complex::new($0, $1)"
                                                        let v395 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v389, v393) v394
                                                        let v396 : num_complex_Complex<float> = method7(v395)
                                                        let v397 : string = "v396.re"
                                                        let v398 : float = Fable.Core.RustInterop.emitRustExpr () v397
                                                        let v399 : bool = v398 <= 1.0
                                                        let v402 : num_complex_Complex<float> =
                                                            if v399 then
                                                                let v400 : string = "num_complex::Complex::new($0, $1)"
                                                                let v401 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v400
                                                                v401
                                                            else
                                                                v395
                                                        let v403 : string = "num_complex::Complex::new($0, $1)"
                                                        let v404 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v403
                                                        let v405 : string = "num_complex::Complex::new($0, $1)"
                                                        let v406 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v405
                                                        let v407 : num_complex_Complex<float> = method22(v406)
                                                        let v408 : num_complex_Complex<float> = method23(v315)
                                                        let v409 : string = "num_complex::Complex::powc(v407, v408)"
                                                        let v410 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v409
                                                        let v411 : string = "$0 * $1"
                                                        let v412 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v404, v410) v411
                                                        let v413 : string = "$0 * $1"
                                                        let v414 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v412, v385) v413
                                                        let v415 : string = "$0 * $1"
                                                        let v416 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v414, v375) v415
                                                        let v417 : string = "$0 * $1"
                                                        let v418 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v416, v402) v417
                                                        v418
                                            let v421 : string = "num_complex::Complex::new($0, $1)"
                                            let v422 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v421
                                            let v423 : string = "num_complex::Complex::new($0, $1)"
                                            let v424 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v423
                                            let v425 : num_complex_Complex<float> = method22(v424)
                                            let v426 : num_complex_Complex<float> = method23(v235)
                                            let v427 : string = "num_complex::Complex::powc(v425, v426)"
                                            let v428 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v427
                                            let v429 : string = "$0 * $1"
                                            let v430 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v422, v428) v429
                                            let v431 : string = "$0 * $1"
                                            let v432 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v430, v305) v431
                                            let v433 : string = "$0 * $1"
                                            let v434 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v432, v295) v433
                                            let v435 : string = "$0 * $1"
                                            let v436 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v434, v420) v435
                                            v436
                                let v439 : string = "num_complex::Complex::new($0, $1)"
                                let v440 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v439
                                let v441 : string = "num_complex::Complex::new($0, $1)"
                                let v442 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v441
                                let v443 : num_complex_Complex<float> = method22(v442)
                                let v444 : num_complex_Complex<float> = method23(v155)
                                let v445 : string = "num_complex::Complex::powc(v443, v444)"
                                let v446 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v445
                                let v447 : string = "$0 * $1"
                                let v448 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v440, v446) v447
                                let v449 : string = "$0 * $1"
                                let v450 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v448, v225) v449
                                let v451 : string = "$0 * $1"
                                let v452 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v450, v215) v451
                                let v453 : string = "$0 * $1"
                                let v454 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v452, v438) v453
                                v454
                    let v457 : string = "num_complex::Complex::new($0, $1)"
                    let v458 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v457
                    let v459 : string = "num_complex::Complex::new($0, $1)"
                    let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v459
                    let v461 : num_complex_Complex<float> = method22(v460)
                    let v462 : num_complex_Complex<float> = method23(v75)
                    let v463 : string = "num_complex::Complex::powc(v461, v462)"
                    let v464 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v463
                    let v465 : string = "$0 * $1"
                    let v466 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v458, v464) v465
                    let v467 : string = "$0 * $1"
                    let v468 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v466, v145) v467
                    let v469 : string = "$0 * $1"
                    let v470 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v468, v135) v469
                    let v471 : string = "$0 * $1"
                    let v472 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v470, v456) v471
                    v472
        let v475 : string = "num_complex::Complex::new($0, $1)"
        let v476 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v475
        let v477 : string = "num_complex::Complex::new($0, $1)"
        let v478 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v477
        let v479 : num_complex_Complex<float> = method22(v478)
        let v480 : num_complex_Complex<float> = method23(v1)
        let v481 : string = "num_complex::Complex::powc(v479, v480)"
        let v482 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v481
        let v483 : string = "$0 * $1"
        let v484 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v476, v482) v483
        let v485 : string = "$0 * $1"
        let v486 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v484, v65) v485
        let v487 : string = "$0 * $1"
        let v488 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v486, v55) v487
        let v489 : string = "$0 * $1"
        let v490 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v488, v474) v489
        v490
and method26 (v0 : bool) : bool =
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
        let v18 : (num_complex_Complex<float> -> US0) = method25()
        let v19 : US0 = US0_1
        let v20 : US0 = v17 |> Option.map v18 |> Option.defaultValue v19 
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
        let v30 : num_complex_Complex<float> = method8(v29)
        let v31 : string = "v30.im"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : bool = v32 = 0.0
        let v35 : bool =
            if v33 then
                true
            else
                method26(v33)
        let v36 : string = "assert_eq"
        let v37 : string = $"{v36} / actual: %A{v32} / expected: %A{0.0}"
        System.Console.WriteLine v37
        let v38 : bool = v35 = false
        if v38 then
            failwith<unit> v37
        let v39 : num_complex_Complex<float> = method7(v29)
        let v40 : string = "v39.re"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : float = v41 - v11
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
                method26(v46)
        let v49 : string = "assert_lt"
        let v50 : string = $"{v49} / actual: %A{v45} / expected: %A{0.0001}"
        System.Console.WriteLine v50
        let v51 : bool = v48 = false
        if v51 then
            failwith<unit> v50
        let v52 : int32 = v9 + 1
        v7.l0 <- v52
        ()
    ()
and method27 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method29 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : (num_complex_Complex<float> -> US0) = method25()
    let v10 : US0 = US0_1
    let v11 : US0 = v8 |> Option.map v9 |> Option.defaultValue v10 
    let v12 : string = "f64::NAN"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "f64::NAN"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "num_complex::Complex::new($0, $1)"
    let v17 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v16
    let v20 : num_complex_Complex<float> =
        match v11 with
        | US0_1 -> (* None *)
            v17
        | US0_0(v18) -> (* Some *)
            v18
    let v21 : num_complex_Complex<float> = method7(v20)
    let v22 : string = "v21.re"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : float = v23 - 0.8673
    let v25 : float =  -v24
    let v26 : bool = v24 >= v25
    let v27 : float =
        if v26 then
            v24
        else
            v25
    let v28 : bool = v27 < 0.001
    let v30 : bool =
        if v28 then
            true
        else
            method26(v28)
    let v31 : string = "assert_lt"
    let v32 : string = $"{v31} / actual: %A{v27} / expected: %A{0.001}"
    System.Console.WriteLine v32
    let v33 : bool = v30 = false
    if v33 then
        failwith<unit> v32
    let v34 : num_complex_Complex<float> = method8(v20)
    let v35 : string = "v34.im"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : float = v36 - 0.275
    let v38 : float =  -v37
    let v39 : bool = v37 >= v38
    let v40 : float =
        if v39 then
            v37
        else
            v38
    let v41 : bool = v40 < 0.001
    let v43 : bool =
        if v41 then
            true
        else
            method26(v41)
    let v44 : string = $"{v31} / actual: %A{v40} / expected: %A{0.001}"
    System.Console.WriteLine v44
    let v45 : bool = v43 = false
    if v45 then
        failwith<unit> v44
and method28 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method29(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method32 () : UH0 =
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
and method33 (v0 : pyo3_Python, v1 : UH0) : unit =
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
        let v12 : (num_complex_Complex<float> -> US0) = method25()
        let v13 : US0 = US0_1
        let v14 : US0 = v11 |> Option.map v12 |> Option.defaultValue v13 
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
        let v27 : bool = v26 = 0.0
        let v29 : bool =
            if v27 then
                true
            else
                method26(v27)
        let v30 : string = "assert_eq"
        let v31 : string = $"{v30} / actual: %A{v26} / expected: %A{0.0}"
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
                method26(v36)
        let v39 : string = $"{v30} / actual: %A{v35} / expected: %A{0.0}"
        System.Console.WriteLine v39
        let v40 : bool = v38 = false
        if v40 then
            failwith<unit> v39
        method33(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method31 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method32()
    method33(v0, v1)
and method30 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method31(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method35 (v0 : pyo3_Python) : unit =
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
        let v25 : (num_complex_Complex<float> -> US0) = method25()
        let v26 : US0 = US0_1
        let v27 : US0 = v24 |> Option.map v25 |> Option.defaultValue v26 
        let v28 : string = "f64::NAN"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : string = "f64::NAN"
        let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : string = "num_complex::Complex::new($0, $1)"
        let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v32
        let v36 : num_complex_Complex<float> =
            match v27 with
            | US0_1 -> (* None *)
                v33
            | US0_0(v34) -> (* Some *)
                v34
        let v37 : num_complex_Complex<float> = method7(v36)
        let v38 : string = "v37.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : float =  -v39
        let v41 : bool = v39 >= v40
        let v42 : float =
            if v41 then
                v39
            else
                v40
        let v43 : bool = v42 < 0.0001
        let v45 : bool =
            if v43 then
                true
            else
                method26(v43)
        let v46 : string = "assert_lt"
        let v47 : string = $"{v46} / actual: %A{v42} / expected: %A{0.0001}"
        System.Console.WriteLine v47
        let v48 : bool = v45 = false
        if v48 then
            failwith<unit> v47
        let v49 : num_complex_Complex<float> = method8(v36)
        let v50 : string = "v49.im"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : float =  -v51
        let v53 : bool = v51 >= v52
        let v54 : float =
            if v53 then
                v51
            else
                v52
        let v55 : bool = v54 < 0.0001
        let v57 : bool =
            if v55 then
                true
            else
                method26(v55)
        let v58 : string = $"{v46} / actual: %A{v54} / expected: %A{0.0001}"
        System.Console.WriteLine v58
        let v59 : bool = v57 = false
        if v59 then
            failwith<unit> v58
        let v60 : int32 = v17 + 1
        v15.l0 <- v60
        ()
    ()
and method34 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method35(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method37 (v0 : pyo3_Python) : unit =
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
        let v15 : (num_complex_Complex<float> -> US0) = method25()
        let v16 : US0 = US0_1
        let v17 : US0 = v14 |> Option.map v15 |> Option.defaultValue v16 
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
        let v30 : bool = v29 > 0.0
        let v32 : bool =
            if v30 then
                true
            else
                method26(v30)
        let v33 : string = "assert_gt"
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
                method26(v39)
        let v42 : string = "assert_eq"
        let v43 : string = $"{v42} / actual: %A{v38} / expected: %A{0.0}"
        System.Console.WriteLine v43
        let v44 : bool = v41 = false
        if v44 then
            failwith<unit> v43
        let v45 : int32 = v5 + 1
        v3.l0 <- v45
        ()
    ()
and method36 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method37(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method39 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : (num_complex_Complex<float> -> US0) = method25()
    let v10 : US0 = US0_1
    let v11 : US0 = v8 |> Option.map v9 |> Option.defaultValue v10 
    let v12 : string = "f64::NAN"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "f64::NAN"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "num_complex::Complex::new($0, $1)"
    let v17 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v16
    let v20 : num_complex_Complex<float> =
        match v11 with
        | US0_1 -> (* None *)
            v17
        | US0_0(v18) -> (* Some *)
            v18
    let v21 : num_complex_Complex<float> = method7(v20)
    let v22 : string = "v21.re"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : bool = v23 = infinity
    let v26 : bool =
        if v24 then
            true
        else
            method26(v24)
    let v27 : string = "assert_eq"
    let v28 : string = $"{v27} / actual: %A{v23} / expected: %A{infinity}"
    System.Console.WriteLine v28
    let v29 : bool = v26 = false
    if v29 then
        failwith<unit> v28
    let v30 : num_complex_Complex<float> = method8(v20)
    let v31 : string = "v30.im"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : bool = v32 = 0.0
    let v35 : bool =
        if v33 then
            true
        else
            method26(v33)
    let v36 : string = $"{v27} / actual: %A{v32} / expected: %A{0.0}"
    System.Console.WriteLine v36
    let v37 : bool = v35 = false
    if v37 then
        failwith<unit> v36
and method38 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method39(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method41 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : (num_complex_Complex<float> -> US0) = method25()
    let v10 : US0 = US0_1
    let v11 : US0 = v8 |> Option.map v9 |> Option.defaultValue v10 
    let v12 : string = "f64::NAN"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "f64::NAN"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "num_complex::Complex::new($0, $1)"
    let v17 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v16
    let v20 : num_complex_Complex<float> =
        match v11 with
        | US0_1 -> (* None *)
            v17
        | US0_0(v18) -> (* Some *)
            v18
    let v21 : num_complex_Complex<float> = method7(v2)
    let v22 : string = "v21.re"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : num_complex_Complex<float> = method8(v2)
    let v25 : string = "v24.im"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : float =  -v26
    let v28 : string = "num_complex::Complex::new($0, $1)"
    let v29 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v23, v27) v28
    let v30 : string = $"        s = mpmath.zeta(s)"
    let v31 : num_complex_Complex<float> = method3(v29)
    let v32 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v30, v31)
    let v33 : num_complex_Complex<float> = method19(v0, v29)
    let v34 : string = "v32.ok()"
    let v35 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (num_complex_Complex<float> -> US0) = method25()
    let v37 : US0 = US0_1
    let v38 : US0 = v35 |> Option.map v36 |> Option.defaultValue v37 
    let v39 : string = "f64::NAN"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : string = "f64::NAN"
    let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : string = "num_complex::Complex::new($0, $1)"
    let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v40, v42) v43
    let v47 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v44
        | US0_0(v45) -> (* Some *)
            v45
    let v48 : string = "v47.conj()"
    let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : num_complex_Complex<float> = method7(v20)
    let v51 : string = "v50.re"
    let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : num_complex_Complex<float> = method7(v49)
    let v54 : string = "v53.re"
    let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : bool = v52 = v55
    let v58 : bool =
        if v56 then
            true
        else
            method26(v56)
    let v59 : string = "assert_eq"
    let v60 : string = $"{v59} / actual: %A{v52} / expected: %A{v55}"
    System.Console.WriteLine v60
    let v61 : bool = v58 = false
    if v61 then
        failwith<unit> v60
    let v62 : num_complex_Complex<float> = method8(v20)
    let v63 : string = "v62.im"
    let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : num_complex_Complex<float> = method8(v49)
    let v66 : string = "v65.im"
    let v67 : float = Fable.Core.RustInterop.emitRustExpr () v66
    let v68 : bool = v64 = v67
    let v70 : bool =
        if v68 then
            true
        else
            method26(v68)
    let v71 : string = $"{v59} / actual: %A{v64} / expected: %A{v67}"
    System.Console.WriteLine v71
    let v72 : bool = v70 = false
    if v72 then
        failwith<unit> v71
and method40 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method41(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method43 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method19(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7
    let v9 : (num_complex_Complex<float> -> US0) = method25()
    let v10 : US0 = US0_1
    let v11 : US0 = v8 |> Option.map v9 |> Option.defaultValue v10 
    let v12 : string = "f64::NAN"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : string = "f64::NAN"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : string = "num_complex::Complex::new($0, $1)"
    let v17 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v13, v15) v16
    let v20 : num_complex_Complex<float> =
        match v11 with
        | US0_1 -> (* None *)
            v17
        | US0_0(v18) -> (* Some *)
            v18
    let v21 : num_complex_Complex<float> = method7(v20)
    let v22 : string = "v21.re"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : bool = v23 < infinity
    let v26 : bool =
        if v24 then
            true
        else
            method26(v24)
    let v27 : string = "assert_lt"
    let v28 : string = $"{v27} / actual: %A{v23} / expected: %A{infinity}"
    System.Console.WriteLine v28
    let v29 : bool = v26 = false
    if v29 then
        failwith<unit> v28
    let v30 : num_complex_Complex<float> = method8(v20)
    let v31 : string = "v30.im"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : bool = v32 < infinity
    let v35 : bool =
        if v33 then
            true
        else
            method26(v33)
    let v36 : string = $"{v27} / actual: %A{v32} / expected: %A{infinity}"
    System.Console.WriteLine v36
    let v37 : bool = v35 = false
    if v37 then
        failwith<unit> v36
and method42 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method43(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method46 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    v0
and method45 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = method46()
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
        let v15 : (num_complex_Complex<float> -> US0) = method25()
        let v16 : US0 = US0_1
        let v17 : US0 = v14 |> Option.map v15 |> Option.defaultValue v16 
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
        let v30 : bool = v29 <> 0.0
        let v32 : bool =
            if v30 then
                true
            else
                method26(v30)
        let v33 : string = "assert_ne"
        let v34 : string = $"{v33} / actual: %A{v29} / expected: %A{0.0}"
        System.Console.WriteLine v34
        let v35 : bool = v32 = false
        if v35 then
            failwith<unit> v34
        let v36 : num_complex_Complex<float> = method8(v26)
        let v37 : string = "v36.im"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : bool = v38 <> 0.0
        let v41 : bool =
            if v39 then
                true
            else
                method26(v39)
        let v42 : string = $"{v33} / actual: %A{v38} / expected: %A{0.0}"
        System.Console.WriteLine v42
        let v43 : bool = v41 = false
        if v43 then
            failwith<unit> v42
        let v44 : int32 = v5 + 1
        v3.l0 <- v44
        ()
    ()
and method44 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method45(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method48 (v0 : pyo3_Python) : unit =
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
        let v23 : (num_complex_Complex<float> -> US0) = method25()
        let v24 : US0 = US0_1
        let v25 : US0 = v22 |> Option.map v23 |> Option.defaultValue v24 
        let v26 : string = "f64::NAN"
        let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26
        let v28 : string = "f64::NAN"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : string = "num_complex::Complex::new($0, $1)"
        let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v29) v30
        let v34 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v31
            | US0_0(v32) -> (* Some *)
                v32
        let v35 : num_complex_Complex<float> = method7(v34)
        let v36 : string = "v35.re"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : bool = v37 <> 0.0
        let v40 : bool =
            if v38 then
                true
            else
                method26(v38)
        let v41 : string = "assert_ne"
        let v42 : string = $"{v41} / actual: %A{v37} / expected: %A{0.0}"
        System.Console.WriteLine v42
        let v43 : bool = v40 = false
        if v43 then
            failwith<unit> v42
        let v44 : num_complex_Complex<float> = method8(v34)
        let v45 : string = "v44.im"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : bool = v46 <> 0.0
        let v49 : bool =
            if v47 then
                true
            else
                method26(v47)
        let v50 : string = $"{v41} / actual: %A{v46} / expected: %A{0.0}"
        System.Console.WriteLine v50
        let v51 : bool = v49 = false
        if v51 then
            failwith<unit> v50
        let v52 : int32 = v15 + 1
        v13.l0 <- v52
        ()
    ()
and method47 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method48(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method50 (v0 : pyo3_Python) : unit =
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
        let v21 : (num_complex_Complex<float> -> US0) = method25()
        let v22 : US0 = US0_1
        let v23 : US0 = v20 |> Option.map v21 |> Option.defaultValue v22 
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
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v33
        let v35 : num_complex_Complex<float> = method22(v34)
        let v36 : num_complex_Complex<float> = method23(v14)
        let v37 : string = "num_complex::Complex::powc(v35, v36)"
        let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : string = "num_complex::Complex::new($0, $1)"
        let v40 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v39
        let v41 : string = "num_complex::Complex::new($0, $1)"
        let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v41
        let v43 : string = "$0 - $1"
        let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v14, v42) v43
        let v45 : num_complex_Complex<float> = method22(v40)
        let v46 : num_complex_Complex<float> = method23(v44)
        let v47 : string = "num_complex::Complex::powc(v45, v46)"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : string = "$0 * $1"
        let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v38, v48) v49
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v51
        let v53 : string = "$0 * $1"
        let v54 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v52, v14) v53
        let v55 : string = "num_complex::Complex::new($0, $1)"
        let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v55
        let v57 : string = "v54 / v56"
        let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : string = "v58.sin()"
        let v60 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v59
        let v61 : string = "$0 * $1"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v50, v60) v61
        let v63 : string = "num_complex::Complex::new($0, $1)"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v63
        let v65 : string = "$0 - $1"
        let v66 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v64, v14) v65
        let v67 : string = $"        s = mpmath.gamma(s)"
        let v68 : num_complex_Complex<float> = method3(v66)
        let v69 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v67, v68)
        let v70 : string = "v69.ok()"
        let v71 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : (num_complex_Complex<float> -> US0) = method25()
        let v73 : US0 = US0_1
        let v74 : US0 = v71 |> Option.map v72 |> Option.defaultValue v73 
        let v75 : string = "f64::NAN"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : string = "f64::NAN"
        let v78 : float = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : string = "num_complex::Complex::new($0, $1)"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v76, v78) v79
        let v83 : num_complex_Complex<float> =
            match v74 with
            | US0_1 -> (* None *)
                v80
            | US0_0(v81) -> (* Some *)
                v81
        let v84 : string = "$0 * $1"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v62, v83) v84
        let v86 : num_complex_Complex<float> = method7(v14)
        let v87 : string = "v86.re"
        let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
        let v89 : float = 1.0 - v88
        let v90 : num_complex_Complex<float> = method8(v14)
        let v91 : string = "v90.im"
        let v92 : float = Fable.Core.RustInterop.emitRustExpr () v91
        let v93 : float =  -v92
        let v94 : string = "num_complex::Complex::new($0, $1)"
        let v95 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v89, v93) v94
        let v96 : string = $"        s = mpmath.zeta(s)"
        let v97 : num_complex_Complex<float> = method3(v95)
        let v98 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v96, v97)
        let v99 : num_complex_Complex<float> = method19(v0, v95)
        let v100 : string = "v98.ok()"
        let v101 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v100
        let v102 : (num_complex_Complex<float> -> US0) = method25()
        let v103 : US0 = US0_1
        let v104 : US0 = v101 |> Option.map v102 |> Option.defaultValue v103 
        let v105 : string = "f64::NAN"
        let v106 : float = Fable.Core.RustInterop.emitRustExpr () v105
        let v107 : string = "f64::NAN"
        let v108 : float = Fable.Core.RustInterop.emitRustExpr () v107
        let v109 : string = "num_complex::Complex::new($0, $1)"
        let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v106, v108) v109
        let v113 : num_complex_Complex<float> =
            match v104 with
            | US0_1 -> (* None *)
                v110
            | US0_0(v111) -> (* Some *)
                v111
        let v114 : string = "$0 * $1"
        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v85, v113) v114
        let v116 : num_complex_Complex<float> = method7(v32)
        let v117 : string = "v116.re"
        let v118 : float = Fable.Core.RustInterop.emitRustExpr () v117
        let v119 : num_complex_Complex<float> = method7(v115)
        let v120 : string = "v119.re"
        let v121 : float = Fable.Core.RustInterop.emitRustExpr () v120
        let v122 : float = v118 - v121
        let v123 : float =  -v122
        let v124 : bool = v122 >= v123
        let v125 : float =
            if v124 then
                v122
            else
                v123
        let v126 : bool = v125 < 0.0001
        let v128 : bool =
            if v126 then
                true
            else
                method26(v126)
        let v129 : string = "assert_lt"
        let v130 : string = $"{v129} / actual: %A{v125} / expected: %A{0.0001}"
        System.Console.WriteLine v130
        let v131 : bool = v128 = false
        if v131 then
            failwith<unit> v130
        let v132 : num_complex_Complex<float> = method8(v32)
        let v133 : string = "v132.im"
        let v134 : float = Fable.Core.RustInterop.emitRustExpr () v133
        let v135 : num_complex_Complex<float> = method8(v115)
        let v136 : string = "v135.im"
        let v137 : float = Fable.Core.RustInterop.emitRustExpr () v136
        let v138 : float = v134 - v137
        let v139 : float =  -v138
        let v140 : bool = v138 >= v139
        let v141 : float =
            if v140 then
                v138
            else
                v139
        let v142 : bool = v141 < 0.0001
        let v144 : bool =
            if v142 then
                true
            else
                method26(v142)
        let v145 : string = $"{v129} / actual: %A{v141} / expected: %A{0.0001}"
        System.Console.WriteLine v145
        let v146 : bool = v144 = false
        if v146 then
            failwith<unit> v145
        let v147 : int32 = v13 + 1
        v11.l0 <- v147
        ()
    ()
and method49 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method50(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
    ()
and method53 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method52 (v0 : pyo3_Python) : unit =
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
        while method53(v10, v11) do
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
        let v28 : (num_complex_Complex<float> -> US0) = method25()
        let v29 : US0 = US0_1
        let v30 : US0 = v27 |> Option.map v28 |> Option.defaultValue v29 
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
        let v43 : float = v42 - v21
        let v44 : float =  -v43
        let v45 : bool = v43 >= v44
        let v46 : float =
            if v45 then
                v43
            else
                v44
        let v47 : bool = v46 < 0.01
        let v49 : bool =
            if v47 then
                true
            else
                method26(v47)
        let v50 : string = "assert_lt"
        let v51 : string = $"{v50} / actual: %A{v46} / expected: %A{0.01}"
        System.Console.WriteLine v51
        let v52 : bool = v49 = false
        if v52 then
            failwith<unit> v51
        let v53 : num_complex_Complex<float> = method8(v39)
        let v54 : string = "v53.im"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : bool = v55 < 0.01
        let v58 : bool =
            if v56 then
                true
            else
                method26(v56)
        let v59 : string = $"{v50} / actual: %A{v55} / expected: %A{0.01}"
        System.Console.WriteLine v59
        let v60 : bool = v58 = false
        if v60 then
            failwith<unit> v59
        let v61 : int32 = v6 + 1
        v4.l0 <- v61
        ()
    ()
and method51 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method52(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method27(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v9 v10
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
    method28()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12
    method30()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16
    method34()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20
    method36()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24
    method38()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28
    method40()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32
    method42()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36
    method44()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40
    method47()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44
    method49()
    let v46 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v46
    let v47 : string = "test_euler_product_formula"
    let v48 : string = $"*/ #[test] fn " + v47 + "() { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48
    method51()
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
and closure6 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure6()
let main args = v1 args
()
