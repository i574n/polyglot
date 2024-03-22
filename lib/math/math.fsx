[<Fable.Core.Erase; Fable.Core.Emit("Func0<$0>")>] type Func0<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Func1<$0, $1>")>] type Func0<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Box<$0>")>] type Box<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("dyn $0")>] type Dyn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn() -> $0")>] type Fn<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn()")>] type FnUnit = class end
[<Fable.Core.Erase; Fable.Core.Emit("FnOnce() -> $0")>] type FnOnce<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("Fn($0, $1)")>] type ActionFn2<'T, 'U> = class end
[<Fable.Core.Erase; Fable.Core.Emit("impl $0")>] type Impl<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>] type Mut<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>] type Ref<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("&'static $0")>] type StaticRef<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("MutCell<$0>")>] type MutCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::any::Any")>] type std_any_Any = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::cell::RefCell<$0>")>] type std_cell_RefCell<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::pin::Pin<$0>")>] type std_pin_Pin<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Rc<$0>")>] type std_rc_Rc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::rc::Weak<$0>")>] type std_rc_Weak<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::sync::Arc<$0>")>] type std_sync_Arc<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("str")>] type Str = class end
[<Fable.Core.Erase; Fable.Core.Emit("base64::DecodeError")>] type base64_DecodeError = class end
[<Fable.Core.Erase; Fable.Core.Emit("borsh::io::Error")>] type borsh_io_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("js_sys::JsString")>] type js_sys_JsString = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Error")>] type serde_json_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_json::Value")>] type serde_json_Value = class end
[<Fable.Core.Erase; Fable.Core.Emit("serde_wasm_bindgen::Error")>] type serde_wasm_bindgen_Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::str::Utf8Error")>] type std_str_Utf8Error = class end
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>] type std_string_String = class end
[<Fable.Core.Erase; Fable.Core.Emit("num_complex::Complex<$0>")>] type num_complex_Complex<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::types::PyModule")>] type pyo3_types_PyModule = class end
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Bound<$0>")>] type pyo3_Bound<'T> = class end
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Python")>] type pyo3_Python = class end
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyAny")>] type pyo3_PyAny = class end
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyErr")>] type pyo3_PyErr = class end
Fable.Core.RustInterop.emitRustExpr () ");
use pyo3::prelude::PyAnyMethods;
//"
type Mut0 = {mutable l0 : int32}
and Mut1 = {mutable l0 : int32; mutable l1 : string}
and Mut2 = {mutable l0 : int32; mutable l1 : num_complex_Complex<float>}
and UH0 =
    | UH0_0 of float * UH0
    | UH0_1
and Mut3 = {mutable l0 : int32; mutable l1 : float}
let rec method2 () : float =
    2.0
and method3 (v0 : float) : float =
    v0
and method4 () : float =
    0.0
and method5 () : float =
    -1.0
and method6 (v0 : (struct (num_complex_Complex<float> * float) [])) : (struct (num_complex_Complex<float> * float) []) =
    v0
and method7 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method8 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method10 (v0 : (string [])) : (string []) =
    v0
and method12 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method11 (v0 : (string [])) : string =
    let v1 : int32 = v0.Length
    let v2 : string = ""
    let v3 : Mut1 = {l0 = 0; l1 = v2} : Mut1
    while method12(v1, v3) do
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
and method13 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method14 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method15 (v0 : pyo3_Python) : pyo3_Python =
    v0
and method16 (v0 : string) : string =
    v0
and method17 (v0 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> =
    v0
and method18 () : string =
    let v0 : string = "fn"
    v0
and method19 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and method20 (v0 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> =
    v0
and method21 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method22 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method23 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method24 (v0 : Result<struct (float * float), pyo3_PyErr>) : Result<struct (float * float), pyo3_PyErr> =
    v0
and method25 (v0 : float) : float =
    v0
and method26 (v0 : float) : float =
    v0
and method9 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    let v3 : string = $"import sys"
    let v4 : string = $"import traceback"
    let v5 : string = $"count = 0"
    let v6 : string = $"def trace_calls(frame, event, arg):"
    let v7 : string = $"  global count"
    let v8 : string = $"  count += 1"
    let v9 : string = $"  if count < 300:"
    let v10 : string = $"    try:"
    let v11 : string = $"      args = {{k: v for k, v in frame.f_locals.items() if k != 'ctx'}}"
    let v12 : string = $"      args_str = ', '.join([f\"{{k}}={{repr(v)}}\" for k, v in args.items()])"
    let v13 : string = "zeta_"
    let v14 : string = $"      print(f'{{event}}({v13}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{\'\' if frame.f_back is None else frame.f_back.f_lineno}} / f_back.f_code.co_filename: {{\'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1]}}', flush=True)"
    let v15 : string = $"    except ValueError as e:"
    let v16 : string = $"      print(f'{v13} / e: {{e}}', flush=True)"
    let v17 : string = $"import mpmath"
    let v18 : string = $"def fn(log, s):"
    let v19 : string = $"  global count"
    let v20 : string = $"  if log:"
    let v21 : string = $"    print(f'{v13} / s: {{s}} / count: {{count}}', flush=True)"
    let v22 : string = $"  s = complex(*s)"
    let v23 : string = $"  try:"
    let v24 : string = $"    if log: sys.settrace(trace_calls)"
    let v25 : string = $"    if log:"
    let v26 : string = $"      sys.settrace(None)"
    let v27 : string = $"      print(f'{v13} / result: {{s}} / count: {{count}}', flush=True)"
    let v28 : string = $"  except ValueError as e:"
    let v29 : string = $"    if s.real == 1:"
    let v30 : string = $"      s = complex(float('inf'), 0)"
    let v31 : string = $"  return (s.real, s.imag)"
    let v32 : (string []) = [|v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v14; v15; v16; v17; v18; v19; v20; v21; v22; v23; v24; v1; v25; v26; v27; v28; v29; v30; v31|]
    let v33 : (string []) = method10(v32)
    let v34 : string = method11(v33)
    let v35 : num_complex_Complex<float> = method13(v2)
    let v36 : string = "v35.re"
    let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : num_complex_Complex<float> = method14(v2)
    let v39 : string = "v38.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : (float * float) = v37, v40
    let v42 : (bool * (float * float)) = false, v41
    let v43 : pyo3_Python = method15(v0)
    let v44 : string = method16(v34)
    let v45 : string = $"fable_library_rust::String_::LrcStr::as_str(&v44)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = "pyo3::types::PyModule::from_code_bound(v43, v46, \"\", \"\")"
    let v48 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method17(v48)
    let v50 : string = "v49.unwrap()"
    let v51 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : string = method18()
    let v53 : string = $"fable_library_rust::String_::LrcStr::as_str(&v52)"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : pyo3_Bound<pyo3_types_PyModule> = method19(v51)
    let v56 : string = "v55.getattr(v54)"
    let v57 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method20(v57)
    let v59 : string = "v58.unwrap()"
    let v60 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (bool * (float * float)) = method21(v42)
    let v62 : pyo3_Bound<pyo3_PyAny> = method22(v60)
    let v63 : string = "pyo3::prelude::PyAnyMethods::call(&v62, ((*v61).0, *(*v61).1), None)"
    let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method20(v64)
    let v66 : string = "v65.unwrap()"
    let v67 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v66
    let v68 : pyo3_Bound<pyo3_PyAny> = method23(v67)
    let v69 : string = "v68.extract()"
    let v70 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : Result<struct (float * float), pyo3_PyErr> = method24(v70)
    let v72 : string = "v71.unwrap()"
    let struct (v73 : float, v74 : float) = Fable.Core.RustInterop.emitRustExpr () v72
    let v75 : float = method25(v73)
    let v76 : float = method3(v75)
    let v77 : float = method26(v74)
    let v78 : string = "num_complex::Complex::new(v76, v77)"
    let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v79
    v80
and method27 (v0 : Result<num_complex_Complex<float>, pyo3_PyErr>) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    v0
and method29 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method30 () : float =
    0.0
and method31 (v0 : Mut0) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 < 10000
    v2
and method32 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method33 () : float =
    1.0
and method34 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method35 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method36 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    let v3 : string = $"import sys"
    let v4 : string = $"import traceback"
    let v5 : string = $"count = 0"
    let v6 : string = $"def trace_calls(frame, event, arg):"
    let v7 : string = $"  global count"
    let v8 : string = $"  count += 1"
    let v9 : string = $"  if count < 300:"
    let v10 : string = $"    try:"
    let v11 : string = $"      args = {{k: v for k, v in frame.f_locals.items() if k != 'ctx'}}"
    let v12 : string = $"      args_str = ', '.join([f\"{{k}}={{repr(v)}}\" for k, v in args.items()])"
    let v13 : string = "gamma_"
    let v14 : string = $"      print(f'{{event}}({v13}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split(\'site-packages\')[-1]}} / f_back.f_lineno: {{\'\' if frame.f_back is None else frame.f_back.f_lineno}} / f_back.f_code.co_filename: {{\'\' if frame.f_back is None else frame.f_back.f_code.co_filename.split(\'site-packages\')[-1]}}', flush=True)"
    let v15 : string = $"    except ValueError as e:"
    let v16 : string = $"      print(f'{v13} / e: {{e}}', flush=True)"
    let v17 : string = $"import mpmath"
    let v18 : string = $"def fn(log, s):"
    let v19 : string = $"  global count"
    let v20 : string = $"  if log:"
    let v21 : string = $"    print(f'{v13} / s: {{s}} / count: {{count}}', flush=True)"
    let v22 : string = $"  s = complex(*s)"
    let v23 : string = $"  try:"
    let v24 : string = $"    if log: sys.settrace(trace_calls)"
    let v25 : string = $"    if log:"
    let v26 : string = $"      sys.settrace(None)"
    let v27 : string = $"      print(f'{v13} / result: {{s}} / count: {{count}}', flush=True)"
    let v28 : string = $"  except ValueError as e:"
    let v29 : string = $"    if s.real == 1:"
    let v30 : string = $"      s = complex(float('inf'), 0)"
    let v31 : string = $"  return (s.real, s.imag)"
    let v32 : (string []) = [|v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v14; v15; v16; v17; v18; v19; v20; v21; v22; v23; v24; v1; v25; v26; v27; v28; v29; v30; v31|]
    let v33 : (string []) = method10(v32)
    let v34 : string = method11(v33)
    let v35 : num_complex_Complex<float> = method13(v2)
    let v36 : string = "v35.re"
    let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : num_complex_Complex<float> = method14(v2)
    let v39 : string = "v38.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : (float * float) = v37, v40
    let v42 : (bool * (float * float)) = false, v41
    let v43 : pyo3_Python = method15(v0)
    let v44 : string = method16(v34)
    let v45 : string = $"fable_library_rust::String_::LrcStr::as_str(&v44)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = "pyo3::types::PyModule::from_code_bound(v43, v46, \"\", \"\")"
    let v48 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method17(v48)
    let v50 : string = "v49.unwrap()"
    let v51 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : string = method18()
    let v53 : string = $"fable_library_rust::String_::LrcStr::as_str(&v52)"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : pyo3_Bound<pyo3_types_PyModule> = method19(v51)
    let v56 : string = "v55.getattr(v54)"
    let v57 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method20(v57)
    let v59 : string = "v58.unwrap()"
    let v60 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (bool * (float * float)) = method21(v42)
    let v62 : pyo3_Bound<pyo3_PyAny> = method22(v60)
    let v63 : string = "pyo3::prelude::PyAnyMethods::call(&v62, ((*v61).0, *(*v61).1), None)"
    let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method20(v64)
    let v66 : string = "v65.unwrap()"
    let v67 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v66
    let v68 : pyo3_Bound<pyo3_PyAny> = method23(v67)
    let v69 : string = "v68.extract()"
    let v70 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : Result<struct (float * float), pyo3_PyErr> = method24(v70)
    let v72 : string = "v71.unwrap()"
    let struct (v73 : float, v74 : float) = Fable.Core.RustInterop.emitRustExpr () v72
    let v75 : float = method25(v73)
    let v76 : float = method3(v75)
    let v77 : float = method26(v74)
    let v78 : string = "num_complex::Complex::new(v76, v77)"
    let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v79
    v80
and method37 () : float =
    3.141592653589793
and method28 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : num_complex_Complex<float> =
    let v2 : num_complex_Complex<float> = method29(v1)
    let v3 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 0, v2)"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : num_complex_Complex<float> = method13(v2)
    let v5 : string = "v4.re"
    let v6 : float = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : bool = v6 > 1.0
    if v7 then
        let v8 : float = method30()
        let v9 : float = method3(v8)
        let v10 : float = method4()
        let v11 : string = "num_complex::Complex::new(v9, v10)"
        let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v11
        let v13 : (int32 []) = Array.zeroCreate<int32> (10000)
        let v14 : Mut0 = {l0 = 0} : Mut0
        while method31(v14) do
            let v16 : int32 = v14.l0
            v13.[int v16] <- v16
            let v17 : int32 = v16 + 1
            v14.l0 <- v17
            ()
        let v18 : int32 = v13.Length
        let v19 : Mut2 = {l0 = 0; l1 = v12} : Mut2
        while method32(v18, v19) do
            let v21 : int32 = v19.l0
            let v22 : num_complex_Complex<float> = v19.l1
            let v23 : int32 = v13.[int v21]
            let v24 : float = method33()
            let v25 : float = method3(v24)
            let v26 : float = method4()
            let v27 : string = "num_complex::Complex::new(v25, v26)"
            let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : float = float v23
            let v30 : float = method25(v29)
            let v31 : float = method3(v30)
            let v32 : float = method4()
            let v33 : string = "num_complex::Complex::new(v31, v32)"
            let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v33
            let v35 : num_complex_Complex<float> = method34(v34)
            let v36 : num_complex_Complex<float> = method35(v2)
            let v37 : string = "num_complex::Complex::powc(v35, v36)"
            let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v37
            let v39 : string = "v28 / v38"
            let v40 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v39
            let v41 : string = "v22 + v40"
            let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v41
            let v43 : int32 = v21 + 1
            v19.l0 <- v43
            v19.l1 <- v42
            ()
        let v44 : num_complex_Complex<float> = v19.l1
        v44
    else
        let v45 : float = method33()
        let v46 : float = method3(v45)
        let v47 : float = method4()
        let v48 : string = "num_complex::Complex::new(v46, v47)"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : string = "v49 - v2"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : string = $"    s = mpmath.gamma(s)"
        let v53 : num_complex_Complex<float> = method8(v51)
        let v54 : Result<num_complex_Complex<float>, pyo3_PyErr> = method36(v0, v52, v53)
        let v55 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v54)
        let v56 : string = "v55.unwrap()"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v56
        let v58 : float = method37()
        let v59 : float = method3(v58)
        let v60 : float = method4()
        let v61 : string = "num_complex::Complex::new(v59, v60)"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : string = "v62 * v2"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : float = method2()
        let v66 : float = method3(v65)
        let v67 : float = method4()
        let v68 : string = "num_complex::Complex::new(v66, v67)"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : string = "v64 / v69"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : string = "v71.sin()"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : num_complex_Complex<float> = method13(v2)
        let v75 : string = "v74.re"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : float = 1.0 - v76
        let v78 : num_complex_Complex<float> = method14(v2)
        let v79 : string = "v78.im"
        let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : float =  -v80
        let v82 : float = method25(v77)
        let v83 : float = method3(v82)
        let v84 : float = method26(v81)
        let v85 : string = "num_complex::Complex::new(v83, v84)"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : num_complex_Complex<float> = method13(v86)
        let v88 : string = "v87.re"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : bool = v89 <= 1.0
        let v568 : num_complex_Complex<float> =
            if v90 then
                let v91 : float = method30()
                let v92 : float = method3(v91)
                let v93 : float = method4()
                let v94 : string = "num_complex::Complex::new(v92, v93)"
                let v95 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v94
                v95
            else
                let v96 : num_complex_Complex<float> = method29(v86)
                let v97 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 1, v96)"
                Fable.Core.RustInterop.emitRustExpr () v97
                let v98 : num_complex_Complex<float> = method13(v96)
                let v99 : string = "v98.re"
                let v100 : float = Fable.Core.RustInterop.emitRustExpr () v99
                let v101 : bool = v100 > 1.0
                if v101 then
                    let v102 : float = method30()
                    let v103 : float = method3(v102)
                    let v104 : float = method4()
                    let v105 : string = "num_complex::Complex::new(v103, v104)"
                    let v106 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v105
                    let v107 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v108 : Mut0 = {l0 = 0} : Mut0
                    while method31(v108) do
                        let v110 : int32 = v108.l0
                        v107.[int v110] <- v110
                        let v111 : int32 = v110 + 1
                        v108.l0 <- v111
                        ()
                    let v112 : int32 = v107.Length
                    let v113 : Mut2 = {l0 = 0; l1 = v106} : Mut2
                    while method32(v112, v113) do
                        let v115 : int32 = v113.l0
                        let v116 : num_complex_Complex<float> = v113.l1
                        let v117 : int32 = v107.[int v115]
                        let v118 : float = method33()
                        let v119 : float = method3(v118)
                        let v120 : float = method4()
                        let v121 : string = "num_complex::Complex::new(v119, v120)"
                        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v121
                        let v123 : float = float v117
                        let v124 : float = method25(v123)
                        let v125 : float = method3(v124)
                        let v126 : float = method4()
                        let v127 : string = "num_complex::Complex::new(v125, v126)"
                        let v128 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v127
                        let v129 : num_complex_Complex<float> = method34(v128)
                        let v130 : num_complex_Complex<float> = method35(v96)
                        let v131 : string = "num_complex::Complex::powc(v129, v130)"
                        let v132 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v131
                        let v133 : string = "v122 / v132"
                        let v134 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v133
                        let v135 : string = "v116 + v134"
                        let v136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v135
                        let v137 : int32 = v115 + 1
                        v113.l0 <- v137
                        v113.l1 <- v136
                        ()
                    let v138 : num_complex_Complex<float> = v113.l1
                    v138
                else
                    let v139 : float = method33()
                    let v140 : float = method3(v139)
                    let v141 : float = method4()
                    let v142 : string = "num_complex::Complex::new(v140, v141)"
                    let v143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v142
                    let v144 : string = "v143 - v96"
                    let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v144
                    let v146 : string = $"    s = mpmath.gamma(s)"
                    let v147 : num_complex_Complex<float> = method8(v145)
                    let v148 : Result<num_complex_Complex<float>, pyo3_PyErr> = method36(v0, v146, v147)
                    let v149 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v148)
                    let v150 : string = "v149.unwrap()"
                    let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v150
                    let v152 : float = method37()
                    let v153 : float = method3(v152)
                    let v154 : float = method4()
                    let v155 : string = "num_complex::Complex::new(v153, v154)"
                    let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v155
                    let v157 : string = "v156 * v96"
                    let v158 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v157
                    let v159 : float = method2()
                    let v160 : float = method3(v159)
                    let v161 : float = method4()
                    let v162 : string = "num_complex::Complex::new(v160, v161)"
                    let v163 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v162
                    let v164 : string = "v158 / v163"
                    let v165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v164
                    let v166 : string = "v165.sin()"
                    let v167 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v166
                    let v168 : num_complex_Complex<float> = method13(v96)
                    let v169 : string = "v168.re"
                    let v170 : float = Fable.Core.RustInterop.emitRustExpr () v169
                    let v171 : float = 1.0 - v170
                    let v172 : num_complex_Complex<float> = method14(v96)
                    let v173 : string = "v172.im"
                    let v174 : float = Fable.Core.RustInterop.emitRustExpr () v173
                    let v175 : float =  -v174
                    let v176 : float = method25(v171)
                    let v177 : float = method3(v176)
                    let v178 : float = method26(v175)
                    let v179 : string = "num_complex::Complex::new(v177, v178)"
                    let v180 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v179
                    let v181 : num_complex_Complex<float> = method13(v180)
                    let v182 : string = "v181.re"
                    let v183 : float = Fable.Core.RustInterop.emitRustExpr () v182
                    let v184 : bool = v183 <= 1.0
                    let v544 : num_complex_Complex<float> =
                        if v184 then
                            let v185 : float = method30()
                            let v186 : float = method3(v185)
                            let v187 : float = method4()
                            let v188 : string = "num_complex::Complex::new(v186, v187)"
                            let v189 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v188
                            v189
                        else
                            let v190 : num_complex_Complex<float> = method29(v180)
                            let v191 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 2, v190)"
                            Fable.Core.RustInterop.emitRustExpr () v191
                            let v192 : num_complex_Complex<float> = method13(v190)
                            let v193 : string = "v192.re"
                            let v194 : float = Fable.Core.RustInterop.emitRustExpr () v193
                            let v195 : bool = v194 > 1.0
                            if v195 then
                                let v196 : float = method30()
                                let v197 : float = method3(v196)
                                let v198 : float = method4()
                                let v199 : string = "num_complex::Complex::new(v197, v198)"
                                let v200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v199
                                let v201 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v202 : Mut0 = {l0 = 0} : Mut0
                                while method31(v202) do
                                    let v204 : int32 = v202.l0
                                    v201.[int v204] <- v204
                                    let v205 : int32 = v204 + 1
                                    v202.l0 <- v205
                                    ()
                                let v206 : int32 = v201.Length
                                let v207 : Mut2 = {l0 = 0; l1 = v200} : Mut2
                                while method32(v206, v207) do
                                    let v209 : int32 = v207.l0
                                    let v210 : num_complex_Complex<float> = v207.l1
                                    let v211 : int32 = v201.[int v209]
                                    let v212 : float = method33()
                                    let v213 : float = method3(v212)
                                    let v214 : float = method4()
                                    let v215 : string = "num_complex::Complex::new(v213, v214)"
                                    let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v215
                                    let v217 : float = float v211
                                    let v218 : float = method25(v217)
                                    let v219 : float = method3(v218)
                                    let v220 : float = method4()
                                    let v221 : string = "num_complex::Complex::new(v219, v220)"
                                    let v222 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v221
                                    let v223 : num_complex_Complex<float> = method34(v222)
                                    let v224 : num_complex_Complex<float> = method35(v190)
                                    let v225 : string = "num_complex::Complex::powc(v223, v224)"
                                    let v226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v225
                                    let v227 : string = "v216 / v226"
                                    let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v227
                                    let v229 : string = "v210 + v228"
                                    let v230 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v229
                                    let v231 : int32 = v209 + 1
                                    v207.l0 <- v231
                                    v207.l1 <- v230
                                    ()
                                let v232 : num_complex_Complex<float> = v207.l1
                                v232
                            else
                                let v233 : float = method33()
                                let v234 : float = method3(v233)
                                let v235 : float = method4()
                                let v236 : string = "num_complex::Complex::new(v234, v235)"
                                let v237 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v236
                                let v238 : string = "v237 - v190"
                                let v239 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v238
                                let v240 : string = $"    s = mpmath.gamma(s)"
                                let v241 : num_complex_Complex<float> = method8(v239)
                                let v242 : Result<num_complex_Complex<float>, pyo3_PyErr> = method36(v0, v240, v241)
                                let v243 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v242)
                                let v244 : string = "v243.unwrap()"
                                let v245 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v244
                                let v246 : float = method37()
                                let v247 : float = method3(v246)
                                let v248 : float = method4()
                                let v249 : string = "num_complex::Complex::new(v247, v248)"
                                let v250 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v249
                                let v251 : string = "v250 * v190"
                                let v252 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v251
                                let v253 : float = method2()
                                let v254 : float = method3(v253)
                                let v255 : float = method4()
                                let v256 : string = "num_complex::Complex::new(v254, v255)"
                                let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v256
                                let v258 : string = "v252 / v257"
                                let v259 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v258
                                let v260 : string = "v259.sin()"
                                let v261 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v260
                                let v262 : num_complex_Complex<float> = method13(v190)
                                let v263 : string = "v262.re"
                                let v264 : float = Fable.Core.RustInterop.emitRustExpr () v263
                                let v265 : float = 1.0 - v264
                                let v266 : num_complex_Complex<float> = method14(v190)
                                let v267 : string = "v266.im"
                                let v268 : float = Fable.Core.RustInterop.emitRustExpr () v267
                                let v269 : float =  -v268
                                let v270 : float = method25(v265)
                                let v271 : float = method3(v270)
                                let v272 : float = method26(v269)
                                let v273 : string = "num_complex::Complex::new(v271, v272)"
                                let v274 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v273
                                let v275 : num_complex_Complex<float> = method13(v274)
                                let v276 : string = "v275.re"
                                let v277 : float = Fable.Core.RustInterop.emitRustExpr () v276
                                let v278 : bool = v277 <= 1.0
                                let v520 : num_complex_Complex<float> =
                                    if v278 then
                                        let v279 : float = method30()
                                        let v280 : float = method3(v279)
                                        let v281 : float = method4()
                                        let v282 : string = "num_complex::Complex::new(v280, v281)"
                                        let v283 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v282
                                        v283
                                    else
                                        let v284 : num_complex_Complex<float> = method29(v274)
                                        let v285 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 3, v284)"
                                        Fable.Core.RustInterop.emitRustExpr () v285
                                        let v286 : num_complex_Complex<float> = method13(v284)
                                        let v287 : string = "v286.re"
                                        let v288 : float = Fable.Core.RustInterop.emitRustExpr () v287
                                        let v289 : bool = v288 > 1.0
                                        if v289 then
                                            let v290 : float = method30()
                                            let v291 : float = method3(v290)
                                            let v292 : float = method4()
                                            let v293 : string = "num_complex::Complex::new(v291, v292)"
                                            let v294 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v293
                                            let v295 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v296 : Mut0 = {l0 = 0} : Mut0
                                            while method31(v296) do
                                                let v298 : int32 = v296.l0
                                                v295.[int v298] <- v298
                                                let v299 : int32 = v298 + 1
                                                v296.l0 <- v299
                                                ()
                                            let v300 : int32 = v295.Length
                                            let v301 : Mut2 = {l0 = 0; l1 = v294} : Mut2
                                            while method32(v300, v301) do
                                                let v303 : int32 = v301.l0
                                                let v304 : num_complex_Complex<float> = v301.l1
                                                let v305 : int32 = v295.[int v303]
                                                let v306 : float = method33()
                                                let v307 : float = method3(v306)
                                                let v308 : float = method4()
                                                let v309 : string = "num_complex::Complex::new(v307, v308)"
                                                let v310 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v309
                                                let v311 : float = float v305
                                                let v312 : float = method25(v311)
                                                let v313 : float = method3(v312)
                                                let v314 : float = method4()
                                                let v315 : string = "num_complex::Complex::new(v313, v314)"
                                                let v316 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v315
                                                let v317 : num_complex_Complex<float> = method34(v316)
                                                let v318 : num_complex_Complex<float> = method35(v284)
                                                let v319 : string = "num_complex::Complex::powc(v317, v318)"
                                                let v320 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v319
                                                let v321 : string = "v310 / v320"
                                                let v322 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v321
                                                let v323 : string = "v304 + v322"
                                                let v324 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v323
                                                let v325 : int32 = v303 + 1
                                                v301.l0 <- v325
                                                v301.l1 <- v324
                                                ()
                                            let v326 : num_complex_Complex<float> = v301.l1
                                            v326
                                        else
                                            let v327 : float = method33()
                                            let v328 : float = method3(v327)
                                            let v329 : float = method4()
                                            let v330 : string = "num_complex::Complex::new(v328, v329)"
                                            let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v330
                                            let v332 : string = "v331 - v284"
                                            let v333 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v332
                                            let v334 : string = $"    s = mpmath.gamma(s)"
                                            let v335 : num_complex_Complex<float> = method8(v333)
                                            let v336 : Result<num_complex_Complex<float>, pyo3_PyErr> = method36(v0, v334, v335)
                                            let v337 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v336)
                                            let v338 : string = "v337.unwrap()"
                                            let v339 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v338
                                            let v340 : float = method37()
                                            let v341 : float = method3(v340)
                                            let v342 : float = method4()
                                            let v343 : string = "num_complex::Complex::new(v341, v342)"
                                            let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v343
                                            let v345 : string = "v344 * v284"
                                            let v346 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v345
                                            let v347 : float = method2()
                                            let v348 : float = method3(v347)
                                            let v349 : float = method4()
                                            let v350 : string = "num_complex::Complex::new(v348, v349)"
                                            let v351 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v350
                                            let v352 : string = "v346 / v351"
                                            let v353 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v352
                                            let v354 : string = "v353.sin()"
                                            let v355 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v354
                                            let v356 : num_complex_Complex<float> = method13(v284)
                                            let v357 : string = "v356.re"
                                            let v358 : float = Fable.Core.RustInterop.emitRustExpr () v357
                                            let v359 : float = 1.0 - v358
                                            let v360 : num_complex_Complex<float> = method14(v284)
                                            let v361 : string = "v360.im"
                                            let v362 : float = Fable.Core.RustInterop.emitRustExpr () v361
                                            let v363 : float =  -v362
                                            let v364 : float = method25(v359)
                                            let v365 : float = method3(v364)
                                            let v366 : float = method26(v363)
                                            let v367 : string = "num_complex::Complex::new(v365, v366)"
                                            let v368 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v367
                                            let v369 : num_complex_Complex<float> = method13(v368)
                                            let v370 : string = "v369.re"
                                            let v371 : float = Fable.Core.RustInterop.emitRustExpr () v370
                                            let v372 : bool = v371 <= 1.0
                                            let v496 : num_complex_Complex<float> =
                                                if v372 then
                                                    let v373 : float = method30()
                                                    let v374 : float = method3(v373)
                                                    let v375 : float = method4()
                                                    let v376 : string = "num_complex::Complex::new(v374, v375)"
                                                    let v377 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v376
                                                    v377
                                                else
                                                    let v378 : num_complex_Complex<float> = method29(v368)
                                                    let v379 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 4, v378)"
                                                    Fable.Core.RustInterop.emitRustExpr () v379
                                                    let v380 : num_complex_Complex<float> = method13(v378)
                                                    let v381 : string = "v380.re"
                                                    let v382 : float = Fable.Core.RustInterop.emitRustExpr () v381
                                                    let v383 : bool = v382 > 1.0
                                                    if v383 then
                                                        let v384 : float = method30()
                                                        let v385 : float = method3(v384)
                                                        let v386 : float = method4()
                                                        let v387 : string = "num_complex::Complex::new(v385, v386)"
                                                        let v388 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v387
                                                        let v389 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v390 : Mut0 = {l0 = 0} : Mut0
                                                        while method31(v390) do
                                                            let v392 : int32 = v390.l0
                                                            v389.[int v392] <- v392
                                                            let v393 : int32 = v392 + 1
                                                            v390.l0 <- v393
                                                            ()
                                                        let v394 : int32 = v389.Length
                                                        let v395 : Mut2 = {l0 = 0; l1 = v388} : Mut2
                                                        while method32(v394, v395) do
                                                            let v397 : int32 = v395.l0
                                                            let v398 : num_complex_Complex<float> = v395.l1
                                                            let v399 : int32 = v389.[int v397]
                                                            let v400 : float = method33()
                                                            let v401 : float = method3(v400)
                                                            let v402 : float = method4()
                                                            let v403 : string = "num_complex::Complex::new(v401, v402)"
                                                            let v404 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v403
                                                            let v405 : float = float v399
                                                            let v406 : float = method25(v405)
                                                            let v407 : float = method3(v406)
                                                            let v408 : float = method4()
                                                            let v409 : string = "num_complex::Complex::new(v407, v408)"
                                                            let v410 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v409
                                                            let v411 : num_complex_Complex<float> = method34(v410)
                                                            let v412 : num_complex_Complex<float> = method35(v378)
                                                            let v413 : string = "num_complex::Complex::powc(v411, v412)"
                                                            let v414 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v413
                                                            let v415 : string = "v404 / v414"
                                                            let v416 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v415
                                                            let v417 : string = "v398 + v416"
                                                            let v418 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v417
                                                            let v419 : int32 = v397 + 1
                                                            v395.l0 <- v419
                                                            v395.l1 <- v418
                                                            ()
                                                        let v420 : num_complex_Complex<float> = v395.l1
                                                        v420
                                                    else
                                                        let v421 : float = method33()
                                                        let v422 : float = method3(v421)
                                                        let v423 : float = method4()
                                                        let v424 : string = "num_complex::Complex::new(v422, v423)"
                                                        let v425 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v424
                                                        let v426 : string = "v425 - v378"
                                                        let v427 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v426
                                                        let v428 : string = $"    s = mpmath.gamma(s)"
                                                        let v429 : num_complex_Complex<float> = method8(v427)
                                                        let v430 : Result<num_complex_Complex<float>, pyo3_PyErr> = method36(v0, v428, v429)
                                                        let v431 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v430)
                                                        let v432 : string = "v431.unwrap()"
                                                        let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v432
                                                        let v434 : float = method37()
                                                        let v435 : float = method3(v434)
                                                        let v436 : float = method4()
                                                        let v437 : string = "num_complex::Complex::new(v435, v436)"
                                                        let v438 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v437
                                                        let v439 : string = "v438 * v378"
                                                        let v440 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v439
                                                        let v441 : float = method2()
                                                        let v442 : float = method3(v441)
                                                        let v443 : float = method4()
                                                        let v444 : string = "num_complex::Complex::new(v442, v443)"
                                                        let v445 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v444
                                                        let v446 : string = "v440 / v445"
                                                        let v447 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v446
                                                        let v448 : string = "v447.sin()"
                                                        let v449 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v448
                                                        let v450 : num_complex_Complex<float> = method13(v378)
                                                        let v451 : string = "v450.re"
                                                        let v452 : float = Fable.Core.RustInterop.emitRustExpr () v451
                                                        let v453 : float = 1.0 - v452
                                                        let v454 : num_complex_Complex<float> = method14(v378)
                                                        let v455 : string = "v454.im"
                                                        let v456 : float = Fable.Core.RustInterop.emitRustExpr () v455
                                                        let v457 : float =  -v456
                                                        let v458 : float = method25(v453)
                                                        let v459 : float = method3(v458)
                                                        let v460 : float = method26(v457)
                                                        let v461 : string = "num_complex::Complex::new(v459, v460)"
                                                        let v462 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v461
                                                        let v463 : num_complex_Complex<float> = method13(v462)
                                                        let v464 : string = "v463.re"
                                                        let v465 : float = Fable.Core.RustInterop.emitRustExpr () v464
                                                        let v466 : bool = v465 <= 1.0
                                                        let v472 : num_complex_Complex<float> =
                                                            if v466 then
                                                                let v467 : float = method30()
                                                                let v468 : float = method3(v467)
                                                                let v469 : float = method4()
                                                                let v470 : string = "num_complex::Complex::new(v468, v469)"
                                                                let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v470
                                                                v471
                                                            else
                                                                v462
                                                        let v473 : float = method2()
                                                        let v474 : float = method3(v473)
                                                        let v475 : float = method4()
                                                        let v476 : string = "num_complex::Complex::new(v474, v475)"
                                                        let v477 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v476
                                                        let v478 : float = method37()
                                                        let v479 : float = method3(v478)
                                                        let v480 : float = method4()
                                                        let v481 : string = "num_complex::Complex::new(v479, v480)"
                                                        let v482 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v481
                                                        let v483 : num_complex_Complex<float> = method34(v482)
                                                        let v484 : num_complex_Complex<float> = method35(v378)
                                                        let v485 : string = "num_complex::Complex::powc(v483, v484)"
                                                        let v486 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v485
                                                        let v487 : string = "v477 * v486"
                                                        let v488 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v487
                                                        let v489 : string = "v488 * v449"
                                                        let v490 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v489
                                                        let v491 : string = "v490 * v433"
                                                        let v492 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v491
                                                        let v493 : string = "v492 * v472"
                                                        let v494 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v493
                                                        v494
                                            let v497 : float = method2()
                                            let v498 : float = method3(v497)
                                            let v499 : float = method4()
                                            let v500 : string = "num_complex::Complex::new(v498, v499)"
                                            let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v500
                                            let v502 : float = method37()
                                            let v503 : float = method3(v502)
                                            let v504 : float = method4()
                                            let v505 : string = "num_complex::Complex::new(v503, v504)"
                                            let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v505
                                            let v507 : num_complex_Complex<float> = method34(v506)
                                            let v508 : num_complex_Complex<float> = method35(v284)
                                            let v509 : string = "num_complex::Complex::powc(v507, v508)"
                                            let v510 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v509
                                            let v511 : string = "v501 * v510"
                                            let v512 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v511
                                            let v513 : string = "v512 * v355"
                                            let v514 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v513
                                            let v515 : string = "v514 * v339"
                                            let v516 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v515
                                            let v517 : string = "v516 * v496"
                                            let v518 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v517
                                            v518
                                let v521 : float = method2()
                                let v522 : float = method3(v521)
                                let v523 : float = method4()
                                let v524 : string = "num_complex::Complex::new(v522, v523)"
                                let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v524
                                let v526 : float = method37()
                                let v527 : float = method3(v526)
                                let v528 : float = method4()
                                let v529 : string = "num_complex::Complex::new(v527, v528)"
                                let v530 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v529
                                let v531 : num_complex_Complex<float> = method34(v530)
                                let v532 : num_complex_Complex<float> = method35(v190)
                                let v533 : string = "num_complex::Complex::powc(v531, v532)"
                                let v534 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v533
                                let v535 : string = "v525 * v534"
                                let v536 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v535
                                let v537 : string = "v536 * v261"
                                let v538 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v537
                                let v539 : string = "v538 * v245"
                                let v540 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v539
                                let v541 : string = "v540 * v520"
                                let v542 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v541
                                v542
                    let v545 : float = method2()
                    let v546 : float = method3(v545)
                    let v547 : float = method4()
                    let v548 : string = "num_complex::Complex::new(v546, v547)"
                    let v549 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v548
                    let v550 : float = method37()
                    let v551 : float = method3(v550)
                    let v552 : float = method4()
                    let v553 : string = "num_complex::Complex::new(v551, v552)"
                    let v554 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v553
                    let v555 : num_complex_Complex<float> = method34(v554)
                    let v556 : num_complex_Complex<float> = method35(v96)
                    let v557 : string = "num_complex::Complex::powc(v555, v556)"
                    let v558 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v557
                    let v559 : string = "v549 * v558"
                    let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v559
                    let v561 : string = "v560 * v167"
                    let v562 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v561
                    let v563 : string = "v562 * v151"
                    let v564 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v563
                    let v565 : string = "v564 * v544"
                    let v566 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v565
                    v566
        let v569 : float = method2()
        let v570 : float = method3(v569)
        let v571 : float = method4()
        let v572 : string = "num_complex::Complex::new(v570, v571)"
        let v573 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v572
        let v574 : float = method37()
        let v575 : float = method3(v574)
        let v576 : float = method4()
        let v577 : string = "num_complex::Complex::new(v575, v576)"
        let v578 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v577
        let v579 : num_complex_Complex<float> = method34(v578)
        let v580 : num_complex_Complex<float> = method35(v2)
        let v581 : string = "num_complex::Complex::powc(v579, v580)"
        let v582 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v581
        let v583 : string = "v573 * v582"
        let v584 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v583
        let v585 : string = "v584 * v73"
        let v586 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v585
        let v587 : string = "v586 * v57"
        let v588 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v587
        let v589 : string = "v588 * v568"
        let v590 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v589
        v590
and method38 (v0 : bool) : bool =
    v0
and method1 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method5()
    let v7 : float = method3(v6)
    let v8 : float = method4()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : (struct (num_complex_Complex<float> * float) []) = [|struct (v5, 1.6449340668482264); struct (v10, -0.08333333333333333)|]
    let v12 : (struct (num_complex_Complex<float> * float) []) = method6(v11)
    let v13 : int32 = v12.Length
    let v14 : Mut0 = {l0 = 0} : Mut0
    while method7(v13, v14) do
        let v16 : int32 = v14.l0
        let struct (v17 : num_complex_Complex<float>, v18 : float) = v12.[int v16]
        let v19 : string = $"    s = mpmath.zeta(s)"
        let v20 : num_complex_Complex<float> = method8(v17)
        let v21 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v19, v20)
        let v22 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v21)
        let v23 : string = "v22.unwrap()"
        let v24 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : num_complex_Complex<float> = method28(v0, v17)
        let v26 : num_complex_Complex<float> = method14(v24)
        let v27 : string = "v26.im"
        let v28 : float = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : bool = v28 = 0.0
        let v31 : bool =
            if v29 then
                true
            else
                method38(v29)
        let v32 : string = $"__expect / actual: %A{v28} / expected: %A{0.0}"
        let v33 : bool = v31 = false
        if v33 then
            failwith<unit> v32
        let v34 : num_complex_Complex<float> = method13(v24)
        let v35 : string = "v34.re"
        let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : float = v36 - v18
        let v38 : float =  -v37
        let v39 : bool = v37 >= v38
        let v40 : float =
            if v39 then
                v37
            else
                v38
        let v41 : bool = v40 < 0.0001
        let v43 : bool =
            if v41 then
                true
            else
                method38(v41)
        let v44 : string = $"__expect / actual: %A{v40} / expected: %A{0.0001}"
        let v45 : bool = v43 = false
        if v45 then
            failwith<unit> v44
        let v46 : int32 = v16 + 1
        v14.l0 <- v46
        ()
    ()
and method39 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method40 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method43 () : float =
    -2.0
and method42 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method43()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v6, v7)
    let v9 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v8)
    let v10 : string = "v9.unwrap()"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : num_complex_Complex<float> = method28(v0, v5)
    let v13 : num_complex_Complex<float> = method13(v11)
    let v14 : string = "v13.re"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = v15 - 0.8673
    let v17 : float =  -v16
    let v18 : bool = v16 >= v17
    let v19 : float =
        if v18 then
            v16
        else
            v17
    let v20 : bool = v19 < 0.001
    let v22 : bool =
        if v20 then
            true
        else
            method38(v20)
    let v23 : string = $"__expect / actual: %A{v19} / expected: %A{0.001}"
    let v24 : bool = v22 = false
    if v24 then
        failwith<unit> v23
    let v25 : num_complex_Complex<float> = method14(v11)
    let v26 : string = "v25.im"
    let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : float = v27 - 0.275
    let v29 : float =  -v28
    let v30 : bool = v28 >= v29
    let v31 : float =
        if v30 then
            v28
        else
            v29
    let v32 : bool = v31 < 0.001
    let v34 : bool =
        if v32 then
            true
        else
            method38(v32)
    let v35 : string = $"__expect / actual: %A{v31} / expected: %A{0.001}"
    let v36 : bool = v34 = false
    if v36 then
        failwith<unit> v35
and method41 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method42(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method46 () : UH0 =
    let v0 : UH0 = UH0_1
    let v1 : UH0 = UH0_0(-40.0, v0)
    let v2 : UH0 = UH0_0(-38.0, v1)
    let v3 : UH0 = UH0_0(-36.0, v2)
    let v4 : UH0 = UH0_0(-34.0, v3)
    let v5 : UH0 = UH0_0(-32.0, v4)
    let v6 : UH0 = UH0_0(-30.0, v5)
    let v7 : UH0 = UH0_0(-28.0, v6)
    let v8 : UH0 = UH0_0(-26.0, v7)
    let v9 : UH0 = UH0_0(-24.0, v8)
    let v10 : UH0 = UH0_0(-22.0, v9)
    let v11 : UH0 = UH0_0(-20.0, v10)
    let v12 : UH0 = UH0_0(-18.0, v11)
    let v13 : UH0 = UH0_0(-16.0, v12)
    let v14 : UH0 = UH0_0(-14.0, v13)
    let v15 : UH0 = UH0_0(-12.0, v14)
    let v16 : UH0 = UH0_0(-10.0, v15)
    let v17 : UH0 = UH0_0(-8.0, v16)
    let v18 : UH0 = UH0_0(-6.0, v17)
    let v19 : UH0 = UH0_0(-4.0, v18)
    UH0_0(-2.0, v19)
and method47 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : float = method25(v2)
        let v5 : float = method3(v4)
        let v6 : float = method4()
        let v7 : string = "num_complex::Complex::new(v5, v6)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v7
        let v9 : string = $"    s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method8(v8)
        let v11 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v9, v10)
        let v12 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v11)
        let v13 : string = "v12.unwrap()"
        let v14 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : num_complex_Complex<float> = method28(v0, v8)
        let v16 : num_complex_Complex<float> = method13(v14)
        let v17 : string = "v16.re"
        let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
        let v19 : bool = v18 = 0.0
        let v21 : bool =
            if v19 then
                true
            else
                method38(v19)
        let v22 : string = $"__expect / actual: %A{v18} / expected: %A{0.0}"
        let v23 : bool = v21 = false
        if v23 then
            failwith<unit> v22
        let v24 : num_complex_Complex<float> = method14(v14)
        let v25 : string = "v24.im"
        let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
        let v27 : bool = v26 = 0.0
        let v29 : bool =
            if v27 then
                true
            else
                method38(v27)
        let v30 : string = $"__expect / actual: %A{v26} / expected: %A{0.0}"
        let v31 : bool = v29 = false
        if v31 then
            failwith<unit> v30
        method47(v0, v3)
    | UH0_1 -> (* Nil *)
        ()
and method45 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method46()
    method47(v0, v1)
and method44 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method45(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method50 () : float =
    0.5
and method51 () : float =
    14.134725
and method52 () : float =
    21.02204
and method53 () : float =
    25.010857
and method54 () : float =
    30.424876
and method55 () : float =
    32.935062
and method56 () : float =
    37.586178
and method57 (v0 : (num_complex_Complex<float> [])) : (num_complex_Complex<float> []) =
    v0
and method49 (v0 : pyo3_Python) : unit =
    let v1 : float = method50()
    let v2 : float = method3(v1)
    let v3 : float = method51()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method50()
    let v7 : float = method3(v6)
    let v8 : float = method52()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method50()
    let v12 : float = method3(v11)
    let v13 : float = method53()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method50()
    let v17 : float = method3(v16)
    let v18 : float = method54()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method50()
    let v22 : float = method3(v21)
    let v23 : float = method55()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : float = method50()
    let v27 : float = method3(v26)
    let v28 : float = method56()
    let v29 : string = "num_complex::Complex::new(v27, v28)"
    let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25; v30|]
    let v32 : (num_complex_Complex<float> []) = method57(v31)
    let v33 : int32 = v32.Length
    let v34 : Mut0 = {l0 = 0} : Mut0
    while method7(v33, v34) do
        let v36 : int32 = v34.l0
        let v37 : num_complex_Complex<float> = v32.[int v36]
        let v38 : string = $"    s = mpmath.zeta(s)"
        let v39 : num_complex_Complex<float> = method8(v37)
        let v40 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v38, v39)
        let v41 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v40)
        let v42 : string = "v41.unwrap()"
        let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : num_complex_Complex<float> = method28(v0, v37)
        let v45 : num_complex_Complex<float> = method13(v43)
        let v46 : string = "v45.re"
        let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46
        let v48 : float =  -v47
        let v49 : bool = v47 >= v48
        let v50 : float =
            if v49 then
                v47
            else
                v48
        let v51 : bool = v50 < 0.0001
        let v53 : bool =
            if v51 then
                true
            else
                method38(v51)
        let v54 : string = $"__expect / actual: %A{v50} / expected: %A{0.0001}"
        let v55 : bool = v53 = false
        if v55 then
            failwith<unit> v54
        let v56 : num_complex_Complex<float> = method14(v43)
        let v57 : string = "v56.im"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : float =  -v58
        let v60 : bool = v58 >= v59
        let v61 : float =
            if v60 then
                v58
            else
                v59
        let v62 : bool = v61 < 0.0001
        let v64 : bool =
            if v62 then
                true
            else
                method38(v62)
        let v65 : string = $"__expect / actual: %A{v61} / expected: %A{0.0001}"
        let v66 : bool = v64 = false
        if v66 then
            failwith<unit> v65
        let v67 : int32 = v36 + 1
        v34.l0 <- v67
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
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method60 (v0 : (float [])) : (float []) =
    v0
and method59 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 3.0; 4.0; 5.0; 10.0; 20.0; 50.0|]
    let v2 : (float []) = method60(v1)
    let v3 : int32 = v2.Length
    let v4 : Mut0 = {l0 = 0} : Mut0
    while method7(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : float = v2.[int v6]
        let v8 : float = method25(v7)
        let v9 : float = method3(v8)
        let v10 : float = method4()
        let v11 : string = "num_complex::Complex::new(v9, v10)"
        let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v11
        let v13 : string = $"    s = mpmath.zeta(s)"
        let v14 : num_complex_Complex<float> = method8(v12)
        let v15 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v13, v14)
        let v16 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v15)
        let v17 : string = "v16.unwrap()"
        let v18 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v17
        let v19 : num_complex_Complex<float> = method28(v0, v12)
        let v20 : num_complex_Complex<float> = method13(v18)
        let v21 : string = "v20.re"
        let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : bool = v22 > 0.0
        let v25 : bool =
            if v23 then
                true
            else
                method38(v23)
        let v26 : string = $"__expect / actual: %A{v22} / expected: %A{0.0}"
        let v27 : bool = v25 = false
        if v27 then
            failwith<unit> v26
        let v28 : num_complex_Complex<float> = method14(v18)
        let v29 : string = "v28.im"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : bool = v30 = 0.0
        let v33 : bool =
            if v31 then
                true
            else
                method38(v31)
        let v34 : string = $"__expect / actual: %A{v30} / expected: %A{0.0}"
        let v35 : bool = v33 = false
        if v35 then
            failwith<unit> v34
        let v36 : int32 = v6 + 1
        v4.l0 <- v36
        ()
    ()
and method58 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method59(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method62 (v0 : pyo3_Python) : unit =
    let v1 : float = method33()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v6, v7)
    let v9 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v8)
    let v10 : string = "v9.unwrap()"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : num_complex_Complex<float> = method28(v0, v5)
    let v13 : num_complex_Complex<float> = method13(v11)
    let v14 : string = "v13.re"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : bool = v15 = infinity
    let v18 : bool =
        if v16 then
            true
        else
            method38(v16)
    let v19 : string = $"__expect / actual: %A{v15} / expected: %A{infinity}"
    let v20 : bool = v18 = false
    if v20 then
        failwith<unit> v19
    let v21 : num_complex_Complex<float> = method14(v11)
    let v22 : string = "v21.im"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : bool = v23 = 0.0
    let v26 : bool =
        if v24 then
            true
        else
            method38(v24)
    let v27 : string = $"__expect / actual: %A{v23} / expected: %A{0.0}"
    let v28 : bool = v26 = false
    if v28 then
        failwith<unit> v27
and method61 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method62(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method65 () : float =
    10.0
and method64 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method65()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v6, v7)
    let v9 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v8)
    let v10 : string = "v9.unwrap()"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : num_complex_Complex<float> = method28(v0, v5)
    let v13 : num_complex_Complex<float> = method13(v5)
    let v14 : string = "v13.re"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : num_complex_Complex<float> = method14(v5)
    let v17 : string = "v16.im"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float =  -v18
    let v20 : float = method25(v15)
    let v21 : float = method3(v20)
    let v22 : float = method26(v19)
    let v23 : string = "num_complex::Complex::new(v21, v22)"
    let v24 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = $"    s = mpmath.zeta(s)"
    let v26 : num_complex_Complex<float> = method8(v24)
    let v27 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v25, v26)
    let v28 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v27)
    let v29 : string = "v28.unwrap()"
    let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : num_complex_Complex<float> = method28(v0, v24)
    let v32 : string = "v30.conj()"
    let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : num_complex_Complex<float> = method13(v11)
    let v35 : string = "v34.re"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : num_complex_Complex<float> = method13(v33)
    let v38 : string = "v37.re"
    let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : bool = v36 = v39
    let v42 : bool =
        if v40 then
            true
        else
            method38(v40)
    let v43 : string = $"__expect / actual: %A{v36} / expected: %A{v39}"
    let v44 : bool = v42 = false
    if v44 then
        failwith<unit> v43
    let v45 : num_complex_Complex<float> = method14(v11)
    let v46 : string = "v45.im"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46
    let v48 : num_complex_Complex<float> = method14(v33)
    let v49 : string = "v48.im"
    let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : bool = v47 = v50
    let v53 : bool =
        if v51 then
            true
        else
            method38(v51)
    let v54 : string = $"__expect / actual: %A{v47} / expected: %A{v50}"
    let v55 : bool = v53 = false
    if v55 then
        failwith<unit> v54
and method63 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method64(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method68 () : float =
    0.01
and method69 () : float =
    0.01
and method67 (v0 : pyo3_Python) : unit =
    let v1 : float = method68()
    let v2 : float = method3(v1)
    let v3 : float = method69()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v6, v7)
    let v9 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v8)
    let v10 : string = "v9.unwrap()"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : num_complex_Complex<float> = method28(v0, v5)
    let v13 : num_complex_Complex<float> = method13(v11)
    let v14 : string = "v13.re"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : bool = v15 < infinity
    let v18 : bool =
        if v16 then
            true
        else
            method38(v16)
    let v19 : string = $"__expect / actual: %A{v15} / expected: %A{infinity}"
    let v20 : bool = v18 = false
    if v20 then
        failwith<unit> v19
    let v21 : num_complex_Complex<float> = method14(v11)
    let v22 : string = "v21.im"
    let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : bool = v23 < infinity
    let v26 : bool =
        if v24 then
            true
        else
            method38(v24)
    let v27 : string = $"__expect / actual: %A{v23} / expected: %A{infinity}"
    let v28 : bool = v26 = false
    if v28 then
        failwith<unit> v27
and method66 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method67(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method71 (v0 : pyo3_Python) : unit =
    let v1 : float = method5()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v6, v7)
    let v9 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v8)
    let v10 : string = "v9.unwrap()"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : num_complex_Complex<float> = method28(v0, v5)
    let v13 : num_complex_Complex<float> = method13(v11)
    let v14 : string = "v13.re"
    let v15 : float = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = v15 + 0.08333333333333333
    let v17 : float =  -v16
    let v18 : bool = v16 >= v17
    let v19 : float =
        if v18 then
            v16
        else
            v17
    let v20 : bool = v19 < 0.0001
    let v22 : bool =
        if v20 then
            true
        else
            method38(v20)
    let v23 : string = $"__expect / actual: %A{v19} / expected: %A{0.0001}"
    let v24 : bool = v22 = false
    if v24 then
        failwith<unit> v23
    let v25 : num_complex_Complex<float> = method14(v11)
    let v26 : string = "v25.im"
    let v27 : float = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : bool = v27 = 0.0
    let v30 : bool =
        if v28 then
            true
        else
            method38(v28)
    let v31 : string = $"__expect / actual: %A{v27} / expected: %A{0.0}"
    let v32 : bool = v30 = false
    if v32 then
        failwith<unit> v31
and method70 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method71(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method74 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    let v1 : (float []) = method60(v0)
    v1
and method75 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method73 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = method74()
    let v2 : int32 = v1.Length
    let v3 : Mut0 = {l0 = 0} : Mut0
    while method7(v2, v3) do
        let v5 : int32 = v3.l0
        let v6 : float = v1.[int v5]
        let v7 : float = method30()
        let v8 : float = method3(v7)
        let v9 : float = method26(v6)
        let v10 : string = "num_complex::Complex::new(v8, v9)"
        let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
        let v12 : string = $"    s = mpmath.zeta(s)"
        let v13 : num_complex_Complex<float> = method8(v11)
        let v14 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v12, v13)
        let v15 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v14)
        let v16 : string = "v15.unwrap()"
        let v17 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v16
        let v18 : num_complex_Complex<float> = method28(v0, v11)
        let v19 : num_complex_Complex<float> = method13(v17)
        let v20 : string = "v19.re"
        let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20
        let v22 : bool = v21 = 0.0
        let v23 : bool = method75(v22)
        let v25 : bool =
            if v23 then
                true
            else
                method38(v23)
        let v26 : string = $"__expect / actual: %A{v21} / expected: %A{0.0}"
        let v27 : bool = v25 = false
        if v27 then
            failwith<unit> v26
        let v28 : num_complex_Complex<float> = method14(v17)
        let v29 : string = "v28.im"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : bool = v30 = 0.0
        let v32 : bool = method75(v31)
        let v34 : bool =
            if v32 then
                true
            else
                method38(v32)
        let v35 : string = $"__expect / actual: %A{v30} / expected: %A{0.0}"
        let v36 : bool = v34 = false
        if v36 then
            failwith<unit> v35
        let v37 : int32 = v5 + 1
        v3.l0 <- v37
        ()
    ()
and method72 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method73(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method78 () : float =
    0.75
and method79 () : float =
    20.5
and method80 () : float =
    1.25
and method81 () : float =
    30.1
and method82 () : float =
    0.25
and method83 () : float =
    40.0
and method84 () : float =
    50.0
and method77 (v0 : pyo3_Python) : unit =
    let v1 : float = method50()
    let v2 : float = method3(v1)
    let v3 : float = method51()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method78()
    let v7 : float = method3(v6)
    let v8 : float = method79()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method80()
    let v12 : float = method3(v11)
    let v13 : float = method81()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method82()
    let v17 : float = method3(v16)
    let v18 : float = method83()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method33()
    let v22 : float = method3(v21)
    let v23 : float = method84()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25|]
    let v27 : (num_complex_Complex<float> []) = method57(v26)
    let v28 : int32 = v27.Length
    let v29 : Mut0 = {l0 = 0} : Mut0
    while method7(v28, v29) do
        let v31 : int32 = v29.l0
        let v32 : num_complex_Complex<float> = v27.[int v31]
        let v33 : string = $"    s = mpmath.zeta(s)"
        let v34 : num_complex_Complex<float> = method8(v32)
        let v35 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v33, v34)
        let v36 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v35)
        let v37 : string = "v36.unwrap()"
        let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : num_complex_Complex<float> = method28(v0, v32)
        let v40 : num_complex_Complex<float> = method13(v38)
        let v41 : string = "v40.re"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : bool = v42 = 0.0
        let v44 : bool = method75(v43)
        let v46 : bool =
            if v44 then
                true
            else
                method38(v44)
        let v47 : string = $"__expect / actual: %A{v42} / expected: %A{0.0}"
        let v48 : bool = v46 = false
        if v48 then
            failwith<unit> v47
        let v49 : num_complex_Complex<float> = method14(v38)
        let v50 : string = "v49.im"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : bool = v51 = 0.0
        let v53 : bool = method75(v52)
        let v55 : bool =
            if v53 then
                true
            else
                method38(v53)
        let v56 : string = $"__expect / actual: %A{v51} / expected: %A{0.0}"
        let v57 : bool = v55 = false
        if v57 then
            failwith<unit> v56
        let v58 : int32 = v31 + 1
        v29.l0 <- v58
        ()
    ()
and method76 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method77(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method87 () : float =
    3.0
and method88 () : float =
    4.0
and method89 () : float =
    2.5
and method90 () : float =
    -3.5
and method91 () : float =
    1.5
and method92 () : float =
    2.5
and method86 (v0 : pyo3_Python) : unit =
    let v1 : float = method87()
    let v2 : float = method3(v1)
    let v3 : float = method88()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method89()
    let v7 : float = method3(v6)
    let v8 : float = method90()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method91()
    let v12 : float = method3(v11)
    let v13 : float = method92()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method50()
    let v17 : float = method3(v16)
    let v18 : float = method51()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20|]
    let v22 : (num_complex_Complex<float> []) = method57(v21)
    let v23 : int32 = v22.Length
    let v24 : Mut0 = {l0 = 0} : Mut0
    while method7(v23, v24) do
        let v26 : int32 = v24.l0
        let v27 : num_complex_Complex<float> = v22.[int v26]
        let v28 : string = $"    s = mpmath.zeta(s)"
        let v29 : num_complex_Complex<float> = method8(v27)
        let v30 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v28, v29)
        let v31 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v30)
        let v32 : string = "v31.unwrap()"
        let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : num_complex_Complex<float> = method28(v0, v27)
        let v35 : float = method2()
        let v36 : float = method3(v35)
        let v37 : float = method4()
        let v38 : string = "num_complex::Complex::new(v36, v37)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : num_complex_Complex<float> = method34(v39)
        let v41 : num_complex_Complex<float> = method35(v27)
        let v42 : string = "num_complex::Complex::powc(v40, v41)"
        let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : float = method37()
        let v45 : float = method3(v44)
        let v46 : float = method4()
        let v47 : string = "num_complex::Complex::new(v45, v46)"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : float = method33()
        let v50 : float = method3(v49)
        let v51 : float = method4()
        let v52 : string = "num_complex::Complex::new(v50, v51)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : string = "v27 - v53"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : num_complex_Complex<float> = method34(v48)
        let v57 : num_complex_Complex<float> = method35(v55)
        let v58 : string = "num_complex::Complex::powc(v56, v57)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : string = "v43 * v59"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : float = method37()
        let v63 : float = method3(v62)
        let v64 : float = method4()
        let v65 : string = "num_complex::Complex::new(v63, v64)"
        let v66 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v65
        let v67 : string = "v66 * v27"
        let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : float = method2()
        let v70 : float = method3(v69)
        let v71 : float = method4()
        let v72 : string = "num_complex::Complex::new(v70, v71)"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : string = "v68 / v73"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : string = "v75.sin()"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : string = "v61 * v77"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : float = method33()
        let v81 : float = method3(v80)
        let v82 : float = method4()
        let v83 : string = "num_complex::Complex::new(v81, v82)"
        let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : string = "v84 - v27"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : string = $"    s = mpmath.gamma(s)"
        let v88 : num_complex_Complex<float> = method8(v86)
        let v89 : Result<num_complex_Complex<float>, pyo3_PyErr> = method36(v0, v87, v88)
        let v90 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v89)
        let v91 : string = "v90.unwrap()"
        let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v91
        let v93 : string = "v79 * v92"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v93
        let v95 : num_complex_Complex<float> = method13(v27)
        let v96 : string = "v95.re"
        let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96
        let v98 : float = 1.0 - v97
        let v99 : num_complex_Complex<float> = method14(v27)
        let v100 : string = "v99.im"
        let v101 : float = Fable.Core.RustInterop.emitRustExpr () v100
        let v102 : float =  -v101
        let v103 : float = method25(v98)
        let v104 : float = method3(v103)
        let v105 : float = method26(v102)
        let v106 : string = "num_complex::Complex::new(v104, v105)"
        let v107 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v106
        let v108 : string = $"    s = mpmath.zeta(s)"
        let v109 : num_complex_Complex<float> = method8(v107)
        let v110 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v108, v109)
        let v111 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v110)
        let v112 : string = "v111.unwrap()"
        let v113 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v112
        let v114 : num_complex_Complex<float> = method28(v0, v107)
        let v115 : string = "v94 * v113"
        let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v115
        let v117 : num_complex_Complex<float> = method13(v33)
        let v118 : string = "v117.re"
        let v119 : float = Fable.Core.RustInterop.emitRustExpr () v118
        let v120 : num_complex_Complex<float> = method13(v116)
        let v121 : string = "v120.re"
        let v122 : float = Fable.Core.RustInterop.emitRustExpr () v121
        let v123 : float = v119 - v122
        let v124 : float =  -v123
        let v125 : bool = v123 >= v124
        let v126 : float =
            if v125 then
                v123
            else
                v124
        let v127 : bool = v126 < 0.0001
        let v129 : bool =
            if v127 then
                true
            else
                method38(v127)
        let v130 : string = $"__expect / actual: %A{v126} / expected: %A{0.0001}"
        let v131 : bool = v129 = false
        if v131 then
            failwith<unit> v130
        let v132 : num_complex_Complex<float> = method14(v33)
        let v133 : string = "v132.im"
        let v134 : float = Fable.Core.RustInterop.emitRustExpr () v133
        let v135 : num_complex_Complex<float> = method14(v116)
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
                method38(v142)
        let v145 : string = $"__expect / actual: %A{v141} / expected: %A{0.0001}"
        let v146 : bool = v144 = false
        if v146 then
            failwith<unit> v145
        let v147 : int32 = v26 + 1
        v24.l0 <- v147
        ()
    ()
and method85 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method86(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method95 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method94 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0|]
    let v2 : (float []) = method60(v1)
    let v3 : (float []) = [|2.0; 3.0; 5.0; 7.0; 11.0; 13.0; 17.0; 19.0; 23.0; 29.0; 31.0; 37.0; 41.0; 43.0; 47.0; 53.0; 59.0; 61.0; 67.0; 71.0|]
    let v4 : (float []) = method60(v3)
    let v5 : int32 = v2.Length
    let v6 : Mut0 = {l0 = 0} : Mut0
    while method7(v5, v6) do
        let v8 : int32 = v6.l0
        let v9 : float = v2.[int v8]
        let v10 : float = method25(v9)
        let v11 : float = method3(v10)
        let v12 : float = method4()
        let v13 : string = "num_complex::Complex::new(v11, v12)"
        let v14 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : int32 = v4.Length
        let v16 : Mut3 = {l0 = 0; l1 = 1.0} : Mut3
        while method95(v15, v16) do
            let v18 : int32 = v16.l0
            let v19 : float = v16.l1
            let v20 : float = v4.[int v18]
            let v21 : float =  -v9
            let v22 : float = v20 ** v21
            let v23 : float = 1.0 - v22
            let v24 : float = v19 / v23
            let v25 : int32 = v18 + 1
            v16.l0 <- v25
            v16.l1 <- v24
            ()
        let v26 : float = v16.l1
        let v27 : string = $"    s = mpmath.zeta(s)"
        let v28 : num_complex_Complex<float> = method8(v14)
        let v29 : Result<num_complex_Complex<float>, pyo3_PyErr> = method9(v0, v27, v28)
        let v30 : Result<num_complex_Complex<float>, pyo3_PyErr> = method27(v29)
        let v31 : string = "v30.unwrap()"
        let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : num_complex_Complex<float> = method28(v0, v14)
        let v34 : num_complex_Complex<float> = method13(v32)
        let v35 : string = "v34.re"
        let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : float = v36 - v26
        let v38 : float =  -v37
        let v39 : bool = v37 >= v38
        let v40 : float =
            if v39 then
                v37
            else
                v38
        let v41 : bool = v40 < 0.01
        let v43 : bool =
            if v41 then
                true
            else
                method38(v41)
        let v44 : string = $"__expect / actual: %A{v40} / expected: %A{0.01}"
        let v45 : bool = v43 = false
        if v45 then
            failwith<unit> v44
        let v46 : num_complex_Complex<float> = method14(v32)
        let v47 : string = "v46.im"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : bool = v48 < 0.01
        let v51 : bool =
            if v49 then
                true
            else
                method38(v49)
        let v52 : string = $"__expect / actual: %A{v48} / expected: %A{0.01}"
        let v53 : bool = v51 = false
        if v53 then
            failwith<unit> v52
        let v54 : int32 = v8 + 1
        v6.l0 <- v54
        ()
    ()
and method93 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method94(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method39(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method40(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and closure0 () () : unit =
    let v0 : string = "}//"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "#[test] fn test_zeta_at_known_values_() { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    method0()
    let v2 : string = "} #[test] fn test_zeta_at_2_minus2() { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    method41()
    let v3 : string = "} #[test] fn test_trivial_zero_at_negative_even___() { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    method44()
    let v4 : string = "} #[test] fn test_non_trivial_zero___() { //"
    Fable.Core.RustInterop.emitRustExpr () v4
    method48()
    let v5 : string = "} #[test] fn test_real_part_greater_than_one___() { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    method58()
    let v6 : string = "} #[test] fn test_zeta_at_1___() { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    method61()
    let v7 : string = "} #[test] fn test_symmetry_across_real_axis___() { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    method63()
    let v8 : string = "} #[test] fn test_behavior_near_origin___() { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    method66()
    let v9 : string = "} #[test] fn test_zeta_at_minus_1() { //"
    Fable.Core.RustInterop.emitRustExpr () v9
    method70()
    let v10 : string = "} #[test] fn test_imaginary_axis() { //"
    Fable.Core.RustInterop.emitRustExpr () v10
    method72()
    let v11 : string = "} #[test] fn test_critical_strip() { //"
    Fable.Core.RustInterop.emitRustExpr () v11
    method76()
    let v12 : string = "} #[test] fn test_reflection_formula_for_specific_value() { //"
    Fable.Core.RustInterop.emitRustExpr () v12
    method85()
    let v13 : string = "} #[test] fn test_euler_product_formula() { //"
    Fable.Core.RustInterop.emitRustExpr () v13
    method93()
and closure1 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
