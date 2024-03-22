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
and UH0 =
    | UH0_0 of float * UH0
    | UH0_1
and Mut2 = {mutable l0 : int32; mutable l1 : float}
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
and method9 (v0 : (string [])) : (string []) =
    v0
and method11 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method10 (v0 : (string [])) : string =
    let v1 : int32 = v0.Length
    let v2 : string = ""
    let v3 : Mut1 = {l0 = 0; l1 = v2} : Mut1
    while method11(v1, v3) do
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
and method12 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method13 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method14 (v0 : pyo3_Python) : pyo3_Python =
    v0
and method15 (v0 : string) : string =
    v0
and method16 (v0 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> =
    v0
and method17 () : string =
    let v0 : string = "fn"
    v0
and method18 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and method19 (v0 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> =
    v0
and method20 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method21 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method22 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method23 (v0 : Result<struct (float * float), pyo3_PyErr>) : Result<struct (float * float), pyo3_PyErr> =
    v0
and method24 (v0 : float) : float =
    v0
and method25 (v0 : float) : float =
    v0
and method8 (v0 : pyo3_Python, v1 : num_complex_Complex<float>, v2 : string) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    let v3 : string = $"import sys"
    let v4 : string = $"import traceback"
    let v5 : string = $"count = 0"
    let v6 : string = $"def trace_calls(frame, event, arg):"
    let v7 : string = $"  global count"
    let v8 : string = $"  count += 1"
    let v9 : string = $"  if count < 500:"
    let v10 : string = $"    try:"
    let v11 : string = $"      args = {{k: v for k, v in frame.f_locals.items() if k != 'ctx'}}"
    let v12 : string = $"      args_str = ', '.join([f\"{{k}}={{repr(v)}}\" for k, v in args.items()])"
    let v13 : string = "zeta_"
    let v14 : string = $"      print(f'{{event}}({v13}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split('site-packages')[-1]}} / f_back.f_lineno: {{frame.f_back.f_lineno}} / f_back.f_code.co_filename: {{frame.f_back.f_code.co_filename.split('site-packages')[-1]}}', flush=True)"
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
    let v32 : (string []) = [|v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v14; v15; v16; v17; v18; v19; v20; v21; v22; v23; v24; v2; v25; v26; v27; v28; v29; v30; v31|]
    let v33 : (string []) = method9(v32)
    let v34 : string = method10(v33)
    let v35 : num_complex_Complex<float> = method12(v1)
    let v36 : string = "v35.re"
    let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : num_complex_Complex<float> = method13(v1)
    let v39 : string = "v38.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : (float * float) = v37, v40
    let v42 : (bool * (float * float)) = false, v41
    let v43 : pyo3_Python = method14(v0)
    let v44 : string = method15(v34)
    let v45 : string = $"fable_library_rust::String_::LrcStr::as_str(&v44)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = "pyo3::types::PyModule::from_code_bound(v43, v46, \"\", \"\")"
    let v48 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v48)
    let v50 : string = "v49.unwrap()"
    let v51 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : string = method17()
    let v53 : string = $"fable_library_rust::String_::LrcStr::as_str(&v52)"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : pyo3_Bound<pyo3_types_PyModule> = method18(v51)
    let v56 : string = "v55.getattr(v54)"
    let v57 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v57)
    let v59 : string = "v58.unwrap()"
    let v60 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (bool * (float * float)) = method20(v42)
    let v62 : pyo3_Bound<pyo3_PyAny> = method21(v60)
    let v63 : string = "pyo3::prelude::PyAnyMethods::call(&v62, ((*v61).0, *(*v61).1), None)"
    let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v64)
    let v66 : string = "v65.unwrap()"
    let v67 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v66
    let v68 : pyo3_Bound<pyo3_PyAny> = method22(v67)
    let v69 : string = "v68.extract()"
    let v70 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : Result<struct (float * float), pyo3_PyErr> = method23(v70)
    let v72 : string = "v71.unwrap()"
    let struct (v73 : float, v74 : float) = Fable.Core.RustInterop.emitRustExpr () v72
    let v75 : float = method24(v73)
    let v76 : float = method3(v75)
    let v77 : float = method25(v74)
    let v78 : string = "num_complex::Complex::new(v76, v77)"
    let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v79
    v80
and method26 (v0 : Result<num_complex_Complex<float>, pyo3_PyErr>) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    v0
and method27 () : float =
    0.0
and method28 (v0 : bool) : bool =
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
        let v20 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v17, v19)
        let v21 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v20)
        let v22 : string = "v21.unwrap()"
        let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
        let v24 : float = method27()
        let v25 : float = method3(v24)
        let v26 : float = method4()
        let v27 : string = "num_complex::Complex::new(v25, v26)"
        let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : num_complex_Complex<float> = method13(v23)
        let v30 : string = "v29.im"
        let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : bool = v31 = 0.0
        let v34 : bool =
            if v32 then
                true
            else
                method28(v32)
        let v35 : string = $"__expect / actual: %A{v31} / expected: %A{0.0}"
        let v36 : bool = v34 = false
        if v36 then
            failwith<unit> v35
        let v37 : num_complex_Complex<float> = method12(v23)
        let v38 : string = "v37.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : float = v39 - v18
        let v41 : float =  -v40
        let v42 : bool = v40 >= v41
        let v43 : float =
            if v42 then
                v40
            else
                v41
        let v44 : bool = v43 < 0.0001
        let v46 : bool =
            if v44 then
                true
            else
                method28(v44)
        let v47 : string = $"__expect / actual: %A{v43} / expected: %A{0.0001}"
        let v48 : bool = v46 = false
        if v48 then
            failwith<unit> v47
        let v49 : int32 = v16 + 1
        v14.l0 <- v49
        ()
    ()
and method29 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method30 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method33 () : float =
    -2.0
and method32 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method33()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v5, v6)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v7)
    let v9 : string = "v8.unwrap()"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method27()
    let v12 : float = method3(v11)
    let v13 : float = method4()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : num_complex_Complex<float> = method12(v10)
    let v17 : string = "v16.re"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float = v18 - 0.8673
    let v20 : float =  -v19
    let v21 : bool = v19 >= v20
    let v22 : float =
        if v21 then
            v19
        else
            v20
    let v23 : bool = v22 < 0.001
    let v25 : bool =
        if v23 then
            true
        else
            method28(v23)
    let v26 : string = $"__expect / actual: %A{v22} / expected: %A{0.001}"
    let v27 : bool = v25 = false
    if v27 then
        failwith<unit> v26
    let v28 : num_complex_Complex<float> = method13(v10)
    let v29 : string = "v28.im"
    let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : float = v30 - 0.275
    let v32 : float =  -v31
    let v33 : bool = v31 >= v32
    let v34 : float =
        if v33 then
            v31
        else
            v32
    let v35 : bool = v34 < 0.001
    let v37 : bool =
        if v35 then
            true
        else
            method28(v35)
    let v38 : string = $"__expect / actual: %A{v34} / expected: %A{0.001}"
    let v39 : bool = v37 = false
    if v39 then
        failwith<unit> v38
and method31 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method32(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method36 () : UH0 =
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
and method37 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : float = method24(v2)
        let v5 : float = method3(v4)
        let v6 : float = method4()
        let v7 : string = "num_complex::Complex::new(v5, v6)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v7
        let v9 : string = $"    s = mpmath.zeta(s)"
        let v10 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v8, v9)
        let v11 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v10)
        let v12 : string = "v11.unwrap()"
        let v13 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v12
        let v14 : float = method27()
        let v15 : float = method3(v14)
        let v16 : float = method4()
        let v17 : string = "num_complex::Complex::new(v15, v16)"
        let v18 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v17
        let v19 : num_complex_Complex<float> = method12(v13)
        let v20 : string = "v19.re"
        let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20
        let v22 : bool = v21 = 0.0
        let v24 : bool =
            if v22 then
                true
            else
                method28(v22)
        let v25 : string = $"__expect / actual: %A{v21} / expected: %A{0.0}"
        let v26 : bool = v24 = false
        if v26 then
            failwith<unit> v25
        let v27 : num_complex_Complex<float> = method13(v13)
        let v28 : string = "v27.im"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : bool = v29 = 0.0
        let v32 : bool =
            if v30 then
                true
            else
                method28(v30)
        let v33 : string = $"__expect / actual: %A{v29} / expected: %A{0.0}"
        let v34 : bool = v32 = false
        if v34 then
            failwith<unit> v33
        method37(v0, v3)
    | UH0_1 -> (* Nil *)
        ()
and method35 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method36()
    method37(v0, v1)
and method34 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method35(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method40 () : float =
    0.5
and method41 () : float =
    14.134725
and method42 () : float =
    21.02204
and method43 () : float =
    25.010857
and method44 () : float =
    30.424876
and method45 () : float =
    32.935062
and method46 () : float =
    37.586178
and method47 (v0 : (num_complex_Complex<float> [])) : (num_complex_Complex<float> []) =
    v0
and method39 (v0 : pyo3_Python) : unit =
    let v1 : float = method40()
    let v2 : float = method3(v1)
    let v3 : float = method41()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method40()
    let v7 : float = method3(v6)
    let v8 : float = method42()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method40()
    let v12 : float = method3(v11)
    let v13 : float = method43()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method40()
    let v17 : float = method3(v16)
    let v18 : float = method44()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method40()
    let v22 : float = method3(v21)
    let v23 : float = method45()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : float = method40()
    let v27 : float = method3(v26)
    let v28 : float = method46()
    let v29 : string = "num_complex::Complex::new(v27, v28)"
    let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25; v30|]
    let v32 : (num_complex_Complex<float> []) = method47(v31)
    let v33 : int32 = v32.Length
    let v34 : Mut0 = {l0 = 0} : Mut0
    while method7(v33, v34) do
        let v36 : int32 = v34.l0
        let v37 : num_complex_Complex<float> = v32.[int v36]
        let v38 : string = $"    s = mpmath.zeta(s)"
        let v39 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v37, v38)
        let v40 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v39)
        let v41 : string = "v40.unwrap()"
        let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : float = method27()
        let v44 : float = method3(v43)
        let v45 : float = method4()
        let v46 : string = "num_complex::Complex::new(v44, v45)"
        let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v46
        let v48 : num_complex_Complex<float> = method12(v42)
        let v49 : string = "v48.re"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : float =  -v50
        let v52 : bool = v50 >= v51
        let v53 : float =
            if v52 then
                v50
            else
                v51
        let v54 : bool = v53 < 0.0001
        let v56 : bool =
            if v54 then
                true
            else
                method28(v54)
        let v57 : string = $"__expect / actual: %A{v53} / expected: %A{0.0001}"
        let v58 : bool = v56 = false
        if v58 then
            failwith<unit> v57
        let v59 : num_complex_Complex<float> = method13(v42)
        let v60 : string = "v59.im"
        let v61 : float = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : float =  -v61
        let v63 : bool = v61 >= v62
        let v64 : float =
            if v63 then
                v61
            else
                v62
        let v65 : bool = v64 < 0.0001
        let v67 : bool =
            if v65 then
                true
            else
                method28(v65)
        let v68 : string = $"__expect / actual: %A{v64} / expected: %A{0.0001}"
        let v69 : bool = v67 = false
        if v69 then
            failwith<unit> v68
        let v70 : int32 = v36 + 1
        v34.l0 <- v70
        ()
    ()
and method38 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method39(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method50 (v0 : (float [])) : (float []) =
    v0
and method49 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 3.0; 4.0; 5.0; 10.0; 20.0; 50.0|]
    let v2 : (float []) = method50(v1)
    let v3 : int32 = v2.Length
    let v4 : Mut0 = {l0 = 0} : Mut0
    while method7(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : float = v2.[int v6]
        let v8 : float = method24(v7)
        let v9 : float = method3(v8)
        let v10 : float = method4()
        let v11 : string = "num_complex::Complex::new(v9, v10)"
        let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v11
        let v13 : string = $"    s = mpmath.zeta(s)"
        let v14 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v12, v13)
        let v15 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v14)
        let v16 : string = "v15.unwrap()"
        let v17 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v16
        let v18 : float = method27()
        let v19 : float = method3(v18)
        let v20 : float = method4()
        let v21 : string = "num_complex::Complex::new(v19, v20)"
        let v22 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : num_complex_Complex<float> = method12(v17)
        let v24 : string = "v23.re"
        let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
        let v26 : bool = v25 > 0.0
        let v28 : bool =
            if v26 then
                true
            else
                method28(v26)
        let v29 : string = $"__expect / actual: %A{v25} / expected: %A{0.0}"
        let v30 : bool = v28 = false
        if v30 then
            failwith<unit> v29
        let v31 : num_complex_Complex<float> = method13(v17)
        let v32 : string = "v31.im"
        let v33 : float = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : bool = v33 = 0.0
        let v36 : bool =
            if v34 then
                true
            else
                method28(v34)
        let v37 : string = $"__expect / actual: %A{v33} / expected: %A{0.0}"
        let v38 : bool = v36 = false
        if v38 then
            failwith<unit> v37
        let v39 : int32 = v6 + 1
        v4.l0 <- v39
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
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method53 () : float =
    1.0
and method52 (v0 : pyo3_Python) : unit =
    let v1 : float = method53()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v5, v6)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v7)
    let v9 : string = "v8.unwrap()"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method27()
    let v12 : float = method3(v11)
    let v13 : float = method4()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : num_complex_Complex<float> = method12(v10)
    let v17 : string = "v16.re"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : bool = v18 = infinity
    let v21 : bool =
        if v19 then
            true
        else
            method28(v19)
    let v22 : string = $"__expect / actual: %A{v18} / expected: %A{infinity}"
    let v23 : bool = v21 = false
    if v23 then
        failwith<unit> v22
    let v24 : num_complex_Complex<float> = method13(v10)
    let v25 : string = "v24.im"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : bool = v26 = 0.0
    let v29 : bool =
        if v27 then
            true
        else
            method28(v27)
    let v30 : string = $"__expect / actual: %A{v26} / expected: %A{0.0}"
    let v31 : bool = v29 = false
    if v31 then
        failwith<unit> v30
and method51 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method52(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method56 () : float =
    10.0
and method55 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method56()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v5, v6)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v7)
    let v9 : string = "v8.unwrap()"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method27()
    let v12 : float = method3(v11)
    let v13 : float = method4()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : num_complex_Complex<float> = method12(v5)
    let v17 : string = "v16.re"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : num_complex_Complex<float> = method13(v5)
    let v20 : string = "v19.im"
    let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : float =  -v21
    let v23 : float = method24(v18)
    let v24 : float = method3(v23)
    let v25 : float = method25(v22)
    let v26 : string = "num_complex::Complex::new(v24, v25)"
    let v27 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : string = $"    s = mpmath.zeta(s)"
    let v29 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v27, v28)
    let v30 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v29)
    let v31 : string = "v30.unwrap()"
    let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : float = method27()
    let v34 : float = method3(v33)
    let v35 : float = method4()
    let v36 : string = "num_complex::Complex::new(v34, v35)"
    let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : string = "v32.conj()"
    let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : num_complex_Complex<float> = method12(v10)
    let v41 : string = "v40.re"
    let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : num_complex_Complex<float> = method12(v39)
    let v44 : string = "v43.re"
    let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : bool = v42 = v45
    let v48 : bool =
        if v46 then
            true
        else
            method28(v46)
    let v49 : string = $"__expect / actual: %A{v42} / expected: %A{v45}"
    let v50 : bool = v48 = false
    if v50 then
        failwith<unit> v49
    let v51 : num_complex_Complex<float> = method13(v10)
    let v52 : string = "v51.im"
    let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52
    let v54 : num_complex_Complex<float> = method13(v39)
    let v55 : string = "v54.im"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : bool = v53 = v56
    let v59 : bool =
        if v57 then
            true
        else
            method28(v57)
    let v60 : string = $"__expect / actual: %A{v53} / expected: %A{v56}"
    let v61 : bool = v59 = false
    if v61 then
        failwith<unit> v60
and method54 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method55(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method59 () : float =
    0.01
and method60 () : float =
    0.01
and method58 (v0 : pyo3_Python) : unit =
    let v1 : float = method59()
    let v2 : float = method3(v1)
    let v3 : float = method60()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v5, v6)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v7)
    let v9 : string = "v8.unwrap()"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method27()
    let v12 : float = method3(v11)
    let v13 : float = method4()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : num_complex_Complex<float> = method12(v10)
    let v17 : string = "v16.re"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : bool = v18 < infinity
    let v21 : bool =
        if v19 then
            true
        else
            method28(v19)
    let v22 : string = $"__expect / actual: %A{v18} / expected: %A{infinity}"
    let v23 : bool = v21 = false
    if v23 then
        failwith<unit> v22
    let v24 : num_complex_Complex<float> = method13(v10)
    let v25 : string = "v24.im"
    let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
    let v27 : bool = v26 < infinity
    let v29 : bool =
        if v27 then
            true
        else
            method28(v27)
    let v30 : string = $"__expect / actual: %A{v26} / expected: %A{infinity}"
    let v31 : bool = v29 = false
    if v31 then
        failwith<unit> v30
and method57 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method58(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method62 (v0 : pyo3_Python) : unit =
    let v1 : float = method5()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"    s = mpmath.zeta(s)"
    let v7 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v5, v6)
    let v8 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v7)
    let v9 : string = "v8.unwrap()"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method27()
    let v12 : float = method3(v11)
    let v13 : float = method4()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : num_complex_Complex<float> = method12(v10)
    let v17 : string = "v16.re"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float = v18 + 0.08333333333333333
    let v20 : float =  -v19
    let v21 : bool = v19 >= v20
    let v22 : float =
        if v21 then
            v19
        else
            v20
    let v23 : bool = v22 < 0.0001
    let v25 : bool =
        if v23 then
            true
        else
            method28(v23)
    let v26 : string = $"__expect / actual: %A{v22} / expected: %A{0.0001}"
    let v27 : bool = v25 = false
    if v27 then
        failwith<unit> v26
    let v28 : num_complex_Complex<float> = method13(v10)
    let v29 : string = "v28.im"
    let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : bool = v30 = 0.0
    let v33 : bool =
        if v31 then
            true
        else
            method28(v31)
    let v34 : string = $"__expect / actual: %A{v30} / expected: %A{0.0}"
    let v35 : bool = v33 = false
    if v35 then
        failwith<unit> v34
and method61 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method62(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method65 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    let v1 : (float []) = method50(v0)
    v1
and method66 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method64 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = method65()
    let v2 : int32 = v1.Length
    let v3 : Mut0 = {l0 = 0} : Mut0
    while method7(v2, v3) do
        let v5 : int32 = v3.l0
        let v6 : float = v1.[int v5]
        let v7 : float = method27()
        let v8 : float = method3(v7)
        let v9 : float = method25(v6)
        let v10 : string = "num_complex::Complex::new(v8, v9)"
        let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
        let v12 : string = $"    s = mpmath.zeta(s)"
        let v13 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v11, v12)
        let v14 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v13)
        let v15 : string = "v14.unwrap()"
        let v16 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v15
        let v17 : float = method27()
        let v18 : float = method3(v17)
        let v19 : float = method4()
        let v20 : string = "num_complex::Complex::new(v18, v19)"
        let v21 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v20
        let v22 : num_complex_Complex<float> = method12(v16)
        let v23 : string = "v22.re"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : bool = v24 = 0.0
        let v26 : bool = method66(v25)
        let v28 : bool =
            if v26 then
                true
            else
                method28(v26)
        let v29 : string = $"__expect / actual: %A{v24} / expected: %A{0.0}"
        let v30 : bool = v28 = false
        if v30 then
            failwith<unit> v29
        let v31 : num_complex_Complex<float> = method13(v16)
        let v32 : string = "v31.im"
        let v33 : float = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : bool = v33 = 0.0
        let v35 : bool = method66(v34)
        let v37 : bool =
            if v35 then
                true
            else
                method28(v35)
        let v38 : string = $"__expect / actual: %A{v33} / expected: %A{0.0}"
        let v39 : bool = v37 = false
        if v39 then
            failwith<unit> v38
        let v40 : int32 = v5 + 1
        v3.l0 <- v40
        ()
    ()
and method63 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method64(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method69 () : float =
    0.75
and method70 () : float =
    20.5
and method71 () : float =
    1.25
and method72 () : float =
    30.1
and method73 () : float =
    0.25
and method74 () : float =
    40.0
and method75 () : float =
    50.0
and method68 (v0 : pyo3_Python) : unit =
    let v1 : float = method40()
    let v2 : float = method3(v1)
    let v3 : float = method41()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method69()
    let v7 : float = method3(v6)
    let v8 : float = method70()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method71()
    let v12 : float = method3(v11)
    let v13 : float = method72()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method73()
    let v17 : float = method3(v16)
    let v18 : float = method74()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method53()
    let v22 : float = method3(v21)
    let v23 : float = method75()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25|]
    let v27 : (num_complex_Complex<float> []) = method47(v26)
    let v28 : int32 = v27.Length
    let v29 : Mut0 = {l0 = 0} : Mut0
    while method7(v28, v29) do
        let v31 : int32 = v29.l0
        let v32 : num_complex_Complex<float> = v27.[int v31]
        let v33 : string = $"    s = mpmath.zeta(s)"
        let v34 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v32, v33)
        let v35 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v34)
        let v36 : string = "v35.unwrap()"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : float = method27()
        let v39 : float = method3(v38)
        let v40 : float = method4()
        let v41 : string = "num_complex::Complex::new(v39, v40)"
        let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : num_complex_Complex<float> = method12(v37)
        let v44 : string = "v43.re"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : bool = v45 = 0.0
        let v47 : bool = method66(v46)
        let v49 : bool =
            if v47 then
                true
            else
                method28(v47)
        let v50 : string = $"__expect / actual: %A{v45} / expected: %A{0.0}"
        let v51 : bool = v49 = false
        if v51 then
            failwith<unit> v50
        let v52 : num_complex_Complex<float> = method13(v37)
        let v53 : string = "v52.im"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53
        let v55 : bool = v54 = 0.0
        let v56 : bool = method66(v55)
        let v58 : bool =
            if v56 then
                true
            else
                method28(v56)
        let v59 : string = $"__expect / actual: %A{v54} / expected: %A{0.0}"
        let v60 : bool = v58 = false
        if v60 then
            failwith<unit> v59
        let v61 : int32 = v31 + 1
        v29.l0 <- v61
        ()
    ()
and method67 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method68(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method78 () : float =
    3.0
and method79 () : float =
    4.0
and method80 () : float =
    2.5
and method81 () : float =
    -3.5
and method82 () : float =
    1.5
and method83 () : float =
    2.5
and method84 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method85 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method86 () : float =
    3.141592653589793
and method87 (v0 : pyo3_Python, v1 : num_complex_Complex<float>, v2 : string) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    let v3 : string = $"import sys"
    let v4 : string = $"import traceback"
    let v5 : string = $"count = 0"
    let v6 : string = $"def trace_calls(frame, event, arg):"
    let v7 : string = $"  global count"
    let v8 : string = $"  count += 1"
    let v9 : string = $"  if count < 500:"
    let v10 : string = $"    try:"
    let v11 : string = $"      args = {{k: v for k, v in frame.f_locals.items() if k != 'ctx'}}"
    let v12 : string = $"      args_str = ', '.join([f\"{{k}}={{repr(v)}}\" for k, v in args.items()])"
    let v13 : string = "gamma_"
    let v14 : string = $"      print(f'{{event}}({v13}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split('site-packages')[-1]}} / f_back.f_lineno: {{frame.f_back.f_lineno}} / f_back.f_code.co_filename: {{frame.f_back.f_code.co_filename.split('site-packages')[-1]}}', flush=True)"
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
    let v32 : (string []) = [|v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v14; v15; v16; v17; v18; v19; v20; v21; v22; v23; v24; v2; v25; v26; v27; v28; v29; v30; v31|]
    let v33 : (string []) = method9(v32)
    let v34 : string = method10(v33)
    let v35 : num_complex_Complex<float> = method12(v1)
    let v36 : string = "v35.re"
    let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : num_complex_Complex<float> = method13(v1)
    let v39 : string = "v38.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : (float * float) = v37, v40
    let v42 : (bool * (float * float)) = false, v41
    let v43 : pyo3_Python = method14(v0)
    let v44 : string = method15(v34)
    let v45 : string = $"fable_library_rust::String_::LrcStr::as_str(&v44)"
    let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = "pyo3::types::PyModule::from_code_bound(v43, v46, \"\", \"\")"
    let v48 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v48)
    let v50 : string = "v49.unwrap()"
    let v51 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : string = method17()
    let v53 : string = $"fable_library_rust::String_::LrcStr::as_str(&v52)"
    let v54 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v53
    let v55 : pyo3_Bound<pyo3_types_PyModule> = method18(v51)
    let v56 : string = "v55.getattr(v54)"
    let v57 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v56
    let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v57)
    let v59 : string = "v58.unwrap()"
    let v60 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : (bool * (float * float)) = method20(v42)
    let v62 : pyo3_Bound<pyo3_PyAny> = method21(v60)
    let v63 : string = "pyo3::prelude::PyAnyMethods::call(&v62, ((*v61).0, *(*v61).1), None)"
    let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v64)
    let v66 : string = "v65.unwrap()"
    let v67 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v66
    let v68 : pyo3_Bound<pyo3_PyAny> = method22(v67)
    let v69 : string = "v68.extract()"
    let v70 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v69
    let v71 : Result<struct (float * float), pyo3_PyErr> = method23(v70)
    let v72 : string = "v71.unwrap()"
    let struct (v73 : float, v74 : float) = Fable.Core.RustInterop.emitRustExpr () v72
    let v75 : float = method24(v73)
    let v76 : float = method3(v75)
    let v77 : float = method25(v74)
    let v78 : string = "num_complex::Complex::new(v76, v77)"
    let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v79
    v80
and method77 (v0 : pyo3_Python) : unit =
    let v1 : float = method78()
    let v2 : float = method3(v1)
    let v3 : float = method79()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method80()
    let v7 : float = method3(v6)
    let v8 : float = method81()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method82()
    let v12 : float = method3(v11)
    let v13 : float = method83()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method40()
    let v17 : float = method3(v16)
    let v18 : float = method41()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20|]
    let v22 : (num_complex_Complex<float> []) = method47(v21)
    let v23 : int32 = v22.Length
    let v24 : Mut0 = {l0 = 0} : Mut0
    while method7(v23, v24) do
        let v26 : int32 = v24.l0
        let v27 : num_complex_Complex<float> = v22.[int v26]
        let v28 : string = $"    s = mpmath.zeta(s)"
        let v29 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v27, v28)
        let v30 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v29)
        let v31 : string = "v30.unwrap()"
        let v32 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : float = method27()
        let v34 : float = method3(v33)
        let v35 : float = method4()
        let v36 : string = "num_complex::Complex::new(v34, v35)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : float = method2()
        let v39 : float = method3(v38)
        let v40 : float = method4()
        let v41 : string = "num_complex::Complex::new(v39, v40)"
        let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : num_complex_Complex<float> = method84(v42)
        let v44 : num_complex_Complex<float> = method85(v27)
        let v45 : string = "num_complex::Complex::powc(v43, v44)"
        let v46 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : float = method86()
        let v48 : float = method3(v47)
        let v49 : float = method4()
        let v50 : string = "num_complex::Complex::new(v48, v49)"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : float = method53()
        let v53 : float = method3(v52)
        let v54 : float = method4()
        let v55 : string = "num_complex::Complex::new(v53, v54)"
        let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : string = "v27 - v56"
        let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : num_complex_Complex<float> = method84(v51)
        let v60 : num_complex_Complex<float> = method85(v58)
        let v61 : string = "num_complex::Complex::powc(v59, v60)"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : string = "v46 * v62"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : float = method86()
        let v66 : float = method3(v65)
        let v67 : float = method4()
        let v68 : string = "num_complex::Complex::new(v66, v67)"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : string = "v69 * v27"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : float = method2()
        let v73 : float = method3(v72)
        let v74 : float = method4()
        let v75 : string = "num_complex::Complex::new(v73, v74)"
        let v76 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : string = "v71 / v76"
        let v78 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : string = "v78.sin()"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : string = "v64 * v80"
        let v82 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : float = method53()
        let v84 : float = method3(v83)
        let v85 : float = method4()
        let v86 : string = "num_complex::Complex::new(v84, v85)"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v86
        let v88 : string = "v87 - v27"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : string = $"    s = mpmath.gamma(s)"
        let v91 : Result<num_complex_Complex<float>, pyo3_PyErr> = method87(v0, v89, v90)
        let v92 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v91)
        let v93 : string = "v92.unwrap()"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v93
        let v95 : string = "v82 * v94"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v95
        let v97 : num_complex_Complex<float> = method12(v27)
        let v98 : string = "v97.re"
        let v99 : float = Fable.Core.RustInterop.emitRustExpr () v98
        let v100 : float = 1.0 - v99
        let v101 : num_complex_Complex<float> = method13(v27)
        let v102 : string = "v101.im"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102
        let v104 : float =  -v103
        let v105 : float = method24(v100)
        let v106 : float = method3(v105)
        let v107 : float = method25(v104)
        let v108 : string = "num_complex::Complex::new(v106, v107)"
        let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v108
        let v110 : string = $"    s = mpmath.zeta(s)"
        let v111 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v109, v110)
        let v112 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v111)
        let v113 : string = "v112.unwrap()"
        let v114 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v113
        let v115 : float = method27()
        let v116 : float = method3(v115)
        let v117 : float = method4()
        let v118 : string = "num_complex::Complex::new(v116, v117)"
        let v119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v118
        let v120 : string = "v96 * v114"
        let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v120
        let v122 : num_complex_Complex<float> = method12(v32)
        let v123 : string = "v122.re"
        let v124 : float = Fable.Core.RustInterop.emitRustExpr () v123
        let v125 : num_complex_Complex<float> = method12(v121)
        let v126 : string = "v125.re"
        let v127 : float = Fable.Core.RustInterop.emitRustExpr () v126
        let v128 : float = v124 - v127
        let v129 : float =  -v128
        let v130 : bool = v128 >= v129
        let v131 : float =
            if v130 then
                v128
            else
                v129
        let v132 : bool = v131 < 0.0001
        let v134 : bool =
            if v132 then
                true
            else
                method28(v132)
        let v135 : string = $"__expect / actual: %A{v131} / expected: %A{0.0001}"
        let v136 : bool = v134 = false
        if v136 then
            failwith<unit> v135
        let v137 : num_complex_Complex<float> = method13(v32)
        let v138 : string = "v137.im"
        let v139 : float = Fable.Core.RustInterop.emitRustExpr () v138
        let v140 : num_complex_Complex<float> = method13(v121)
        let v141 : string = "v140.im"
        let v142 : float = Fable.Core.RustInterop.emitRustExpr () v141
        let v143 : float = v139 - v142
        let v144 : float =  -v143
        let v145 : bool = v143 >= v144
        let v146 : float =
            if v145 then
                v143
            else
                v144
        let v147 : bool = v146 < 0.0001
        let v149 : bool =
            if v147 then
                true
            else
                method28(v147)
        let v150 : string = $"__expect / actual: %A{v146} / expected: %A{0.0001}"
        let v151 : bool = v149 = false
        if v151 then
            failwith<unit> v150
        let v152 : int32 = v26 + 1
        v24.l0 <- v152
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
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method90 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method89 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0|]
    let v2 : (float []) = method50(v1)
    let v3 : (float []) = [|2.0; 3.0; 5.0; 7.0; 11.0; 13.0; 17.0; 19.0; 23.0; 29.0; 31.0; 37.0; 41.0; 43.0; 47.0; 53.0; 59.0; 61.0; 67.0; 71.0|]
    let v4 : (float []) = method50(v3)
    let v5 : int32 = v2.Length
    let v6 : Mut0 = {l0 = 0} : Mut0
    while method7(v5, v6) do
        let v8 : int32 = v6.l0
        let v9 : float = v2.[int v8]
        let v10 : float = method24(v9)
        let v11 : float = method3(v10)
        let v12 : float = method4()
        let v13 : string = "num_complex::Complex::new(v11, v12)"
        let v14 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : int32 = v4.Length
        let v16 : Mut2 = {l0 = 0; l1 = 1.0} : Mut2
        while method90(v15, v16) do
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
        let v28 : Result<num_complex_Complex<float>, pyo3_PyErr> = method8(v0, v14, v27)
        let v29 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v28)
        let v30 : string = "v29.unwrap()"
        let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : float = method27()
        let v33 : float = method3(v32)
        let v34 : float = method4()
        let v35 : string = "num_complex::Complex::new(v33, v34)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : num_complex_Complex<float> = method12(v31)
        let v38 : string = "v37.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : float = v39 - v26
        let v41 : float =  -v40
        let v42 : bool = v40 >= v41
        let v43 : float =
            if v42 then
                v40
            else
                v41
        let v44 : bool = v43 < 0.01
        let v46 : bool =
            if v44 then
                true
            else
                method28(v44)
        let v47 : string = $"__expect / actual: %A{v43} / expected: %A{0.01}"
        let v48 : bool = v46 = false
        if v48 then
            failwith<unit> v47
        let v49 : num_complex_Complex<float> = method13(v31)
        let v50 : string = "v49.im"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : bool = v51 < 0.01
        let v54 : bool =
            if v52 then
                true
            else
                method28(v52)
        let v55 : string = $"__expect / actual: %A{v51} / expected: %A{0.01}"
        let v56 : bool = v54 = false
        if v56 then
            failwith<unit> v55
        let v57 : int32 = v8 + 1
        v6.l0 <- v57
        ()
    ()
and method88 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method89(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method29(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method30(v9)
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
    method31()
    let v3 : string = "} #[test] fn test_trivial_zero_at_negative_even___() { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    method34()
    let v4 : string = "} #[test] fn test_non_trivial_zero___() { //"
    Fable.Core.RustInterop.emitRustExpr () v4
    method38()
    let v5 : string = "} #[test] fn test_real_part_greater_than_one___() { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    method48()
    let v6 : string = "} #[test] fn test_zeta_at_1___() { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    method51()
    let v7 : string = "} #[test] fn test_symmetry_across_real_axis___() { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    method54()
    let v8 : string = "} #[test] fn test_behavior_near_origin___() { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    method57()
    let v9 : string = "} #[test] fn test_zeta_at_minus_1() { //"
    Fable.Core.RustInterop.emitRustExpr () v9
    method61()
    let v10 : string = "} #[test] fn test_imaginary_axis() { //"
    Fable.Core.RustInterop.emitRustExpr () v10
    method63()
    let v11 : string = "} #[test] fn test_critical_strip() { //"
    Fable.Core.RustInterop.emitRustExpr () v11
    method67()
    let v12 : string = "} #[test] fn test_reflection_formula_for_specific_value() { //"
    Fable.Core.RustInterop.emitRustExpr () v12
    method76()
    let v13 : string = "} #[test] fn test_euler_product_formula() { //"
    Fable.Core.RustInterop.emitRustExpr () v13
    method88()
and closure1 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
