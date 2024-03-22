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
and method8 () : (string []) =
    let v0 : string = "import sys"
    let v1 : string = "import traceback"
    let v2 : string = "def trace_calls(frame, event, arg):"
    let v3 : string = "    if event != 'call':"
    let v4 : string = "        return"
    let v5 : string = "    co = frame.f_code"
    let v6 : string = "    func_name = co.co_name"
    let v7 : string = "    func_line_no = frame.f_lineno"
    let v8 : string = "    func_filename = co.co_filename"
    let v9 : string = "    caller = frame.f_back"
    let v10 : string = "    caller_line_no = caller.f_lineno"
    let v11 : string = "    caller_filename = caller.f_code.co_filename"
    let v12 : string = "    args = frame.f_locals"
    let v13 : string = "    args_str = ', '.join([f\"{k}={v}\" for k, v in args.items() if k != 'ctx'])"
    let v14 : string = "zeta_"
    let v15 : string = $"    print(f'{v14} / Call to {{func_name}}({{args_str}}) on line {{func_line_no}} of {{func_filename}} from line {{caller_line_no}} of {{caller_filename}}', flush=True)"
    let v16 : string = "def start_trace():"
    let v17 : string = "    sys.settrace(trace_calls)"
    let v18 : string = "def stop_trace():"
    let v19 : string = "    sys.settrace(None)"
    let v20 : string = "import mpmath"
    let v21 : string = "def fn(log, s):"
    let v22 : string = "    if log:"
    let v23 : string = $"        print(f'{v14} / s: {{s}}', flush=True)"
    let v24 : string = "    s = complex(*s)"
    let v25 : string = "    try:"
    let v26 : string = "        if log: start_trace()"
    let v27 : string = "        s = mpmath.zeta(s)"
    let v28 : string = "        if log: stop_trace()"
    let v29 : string = "    except ValueError as e:"
    let v30 : string = "        if s.real == 1:"
    let v31 : string = "            s = complex(float('inf'), 0)"
    let v32 : string = "    return (s.real, s.imag)"
    let v33 : (string []) = [|v0; v1; v2; v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v13; v15; v16; v17; v18; v19; v20; v21; v22; v23; v24; v25; v26; v27; v28; v29; v30; v31; v32|]
    method9(v33)
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
        let v19 : (string []) = method8()
        let v20 : string = method10(v19)
        let v21 : num_complex_Complex<float> = method12(v17)
        let v22 : string = "v21.re"
        let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
        let v24 : num_complex_Complex<float> = method13(v17)
        let v25 : string = "v24.im"
        let v26 : float = Fable.Core.RustInterop.emitRustExpr () v25
        let v27 : (float * float) = v23, v26
        let v28 : (bool * (float * float)) = false, v27
        let v29 : pyo3_Python = method14(v0)
        let v30 : string = method15(v20)
        let v31 : string = $"fable_library_rust::String_::LrcStr::as_str(&v30)"
        let v32 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : string = "pyo3::types::PyModule::from_code_bound(v29, v32, \"\", \"\")"
        let v34 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v33
        let v35 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v34)
        let v36 : string = "v35.unwrap()"
        let v37 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : string = method17()
        let v39 : string = $"fable_library_rust::String_::LrcStr::as_str(&v38)"
        let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : pyo3_Bound<pyo3_types_PyModule> = method18(v37)
        let v42 : string = "v41.getattr(v40)"
        let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v43)
        let v45 : string = "v44.unwrap()"
        let v46 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : (bool * (float * float)) = method20(v28)
        let v48 : pyo3_Bound<pyo3_PyAny> = method21(v46)
        let v49 : string = "pyo3::prelude::PyAnyMethods::call(&v48, ((*v47).0, *(*v47).1), None)"
        let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v50)
        let v52 : string = "v51.unwrap()"
        let v53 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : pyo3_Bound<pyo3_PyAny> = method22(v53)
        let v55 : string = "v54.extract()"
        let v56 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : Result<struct (float * float), pyo3_PyErr> = method23(v56)
        let v58 : string = "v57.unwrap()"
        let struct (v59 : float, v60 : float) = Fable.Core.RustInterop.emitRustExpr () v58
        let v61 : float = method24(v59)
        let v62 : float = method3(v61)
        let v63 : float = method25(v60)
        let v64 : string = "num_complex::Complex::new(v62, v63)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v65
        let v67 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v66)
        let v68 : string = "v67.unwrap()"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : float = method27()
        let v71 : float = method3(v70)
        let v72 : float = method4()
        let v73 : string = "num_complex::Complex::new(v71, v72)"
        let v74 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : num_complex_Complex<float> = method13(v69)
        let v76 : string = "v75.im"
        let v77 : float = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : bool = v77 = 0.0
        let v80 : bool =
            if v78 then
                true
            else
                method28(v78)
        let v81 : string = $"__expect / actual: %A{v77} / expected: %A{0.0}"
        let v82 : bool = v80 = false
        if v82 then
            failwith<unit> v81
        let v83 : num_complex_Complex<float> = method12(v69)
        let v84 : string = "v83.re"
        let v85 : float = Fable.Core.RustInterop.emitRustExpr () v84
        let v86 : float = v85 - v18
        let v87 : float =  -v86
        let v88 : bool = v86 >= v87
        let v89 : float =
            if v88 then
                v86
            else
                v87
        let v90 : bool = v89 < 0.0001
        let v92 : bool =
            if v90 then
                true
            else
                method28(v90)
        let v93 : string = $"__expect / actual: %A{v89} / expected: %A{0.0001}"
        let v94 : bool = v92 = false
        if v94 then
            failwith<unit> v93
        let v95 : int32 = v16 + 1
        v14.l0 <- v95
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
    let v6 : (string []) = method8()
    let v7 : string = method10(v6)
    let v8 : num_complex_Complex<float> = method12(v5)
    let v9 : string = "v8.re"
    let v10 : float = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : num_complex_Complex<float> = method13(v5)
    let v12 : string = "v11.im"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : (float * float) = v10, v13
    let v15 : (bool * (float * float)) = false, v14
    let v16 : pyo3_Python = method14(v0)
    let v17 : string = method15(v7)
    let v18 : string = $"fable_library_rust::String_::LrcStr::as_str(&v17)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "pyo3::types::PyModule::from_code_bound(v16, v19, \"\", \"\")"
    let v21 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v21)
    let v23 : string = "v22.unwrap()"
    let v24 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = method17()
    let v26 : string = $"fable_library_rust::String_::LrcStr::as_str(&v25)"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : pyo3_Bound<pyo3_types_PyModule> = method18(v24)
    let v29 : string = "v28.getattr(v27)"
    let v30 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v30)
    let v32 : string = "v31.unwrap()"
    let v33 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : (bool * (float * float)) = method20(v15)
    let v35 : pyo3_Bound<pyo3_PyAny> = method21(v33)
    let v36 : string = "pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None)"
    let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v37)
    let v39 : string = "v38.unwrap()"
    let v40 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : pyo3_Bound<pyo3_PyAny> = method22(v40)
    let v42 : string = "v41.extract()"
    let v43 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<struct (float * float), pyo3_PyErr> = method23(v43)
    let v45 : string = "v44.unwrap()"
    let struct (v46 : float, v47 : float) = Fable.Core.RustInterop.emitRustExpr () v45
    let v48 : float = method24(v46)
    let v49 : float = method3(v48)
    let v50 : float = method25(v47)
    let v51 : string = "num_complex::Complex::new(v49, v50)"
    let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v52
    let v54 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v53)
    let v55 : string = "v54.unwrap()"
    let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : float = method27()
    let v58 : float = method3(v57)
    let v59 : float = method4()
    let v60 : string = "num_complex::Complex::new(v58, v59)"
    let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : num_complex_Complex<float> = method12(v56)
    let v63 : string = "v62.re"
    let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : float = v64 - 0.8673
    let v66 : float =  -v65
    let v67 : bool = v65 >= v66
    let v68 : float =
        if v67 then
            v65
        else
            v66
    let v69 : bool = v68 < 0.001
    let v71 : bool =
        if v69 then
            true
        else
            method28(v69)
    let v72 : string = $"__expect / actual: %A{v68} / expected: %A{0.001}"
    let v73 : bool = v71 = false
    if v73 then
        failwith<unit> v72
    let v74 : num_complex_Complex<float> = method13(v56)
    let v75 : string = "v74.im"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : float = v76 - 0.275
    let v78 : float =  -v77
    let v79 : bool = v77 >= v78
    let v80 : float =
        if v79 then
            v77
        else
            v78
    let v81 : bool = v80 < 0.001
    let v83 : bool =
        if v81 then
            true
        else
            method28(v81)
    let v84 : string = $"__expect / actual: %A{v80} / expected: %A{0.001}"
    let v85 : bool = v83 = false
    if v85 then
        failwith<unit> v84
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
        let v9 : (string []) = method8()
        let v10 : string = method10(v9)
        let v11 : num_complex_Complex<float> = method12(v8)
        let v12 : string = "v11.re"
        let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
        let v14 : num_complex_Complex<float> = method13(v8)
        let v15 : string = "v14.im"
        let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
        let v17 : (float * float) = v13, v16
        let v18 : (bool * (float * float)) = false, v17
        let v19 : pyo3_Python = method14(v0)
        let v20 : string = method15(v10)
        let v21 : string = $"fable_library_rust::String_::LrcStr::as_str(&v20)"
        let v22 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "pyo3::types::PyModule::from_code_bound(v19, v22, \"\", \"\")"
        let v24 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v24)
        let v26 : string = "v25.unwrap()"
        let v27 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v26
        let v28 : string = method17()
        let v29 : string = $"fable_library_rust::String_::LrcStr::as_str(&v28)"
        let v30 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : pyo3_Bound<pyo3_types_PyModule> = method18(v27)
        let v32 : string = "v31.getattr(v30)"
        let v33 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v33)
        let v35 : string = "v34.unwrap()"
        let v36 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : (bool * (float * float)) = method20(v18)
        let v38 : pyo3_Bound<pyo3_PyAny> = method21(v36)
        let v39 : string = "pyo3::prelude::PyAnyMethods::call(&v38, ((*v37).0, *(*v37).1), None)"
        let v40 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v40)
        let v42 : string = "v41.unwrap()"
        let v43 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : pyo3_Bound<pyo3_PyAny> = method22(v43)
        let v45 : string = "v44.extract()"
        let v46 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : Result<struct (float * float), pyo3_PyErr> = method23(v46)
        let v48 : string = "v47.unwrap()"
        let struct (v49 : float, v50 : float) = Fable.Core.RustInterop.emitRustExpr () v48
        let v51 : float = method24(v49)
        let v52 : float = method3(v51)
        let v53 : float = method25(v50)
        let v54 : string = "num_complex::Complex::new(v52, v53)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v55
        let v57 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v56)
        let v58 : string = "v57.unwrap()"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : float = method27()
        let v61 : float = method3(v60)
        let v62 : float = method4()
        let v63 : string = "num_complex::Complex::new(v61, v62)"
        let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : num_complex_Complex<float> = method12(v59)
        let v66 : string = "v65.re"
        let v67 : float = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : bool = v67 = 0.0
        let v70 : bool =
            if v68 then
                true
            else
                method28(v68)
        let v71 : string = $"__expect / actual: %A{v67} / expected: %A{0.0}"
        let v72 : bool = v70 = false
        if v72 then
            failwith<unit> v71
        let v73 : num_complex_Complex<float> = method13(v59)
        let v74 : string = "v73.im"
        let v75 : float = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : bool = v75 = 0.0
        let v78 : bool =
            if v76 then
                true
            else
                method28(v76)
        let v79 : string = $"__expect / actual: %A{v75} / expected: %A{0.0}"
        let v80 : bool = v78 = false
        if v80 then
            failwith<unit> v79
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
        let v38 : (string []) = method8()
        let v39 : string = method10(v38)
        let v40 : num_complex_Complex<float> = method12(v37)
        let v41 : string = "v40.re"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : num_complex_Complex<float> = method13(v37)
        let v44 : string = "v43.im"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : (float * float) = v42, v45
        let v47 : (bool * (float * float)) = false, v46
        let v48 : pyo3_Python = method14(v0)
        let v49 : string = method15(v39)
        let v50 : string = $"fable_library_rust::String_::LrcStr::as_str(&v49)"
        let v51 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : string = "pyo3::types::PyModule::from_code_bound(v48, v51, \"\", \"\")"
        let v53 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v53)
        let v55 : string = "v54.unwrap()"
        let v56 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : string = method17()
        let v58 : string = $"fable_library_rust::String_::LrcStr::as_str(&v57)"
        let v59 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : pyo3_Bound<pyo3_types_PyModule> = method18(v56)
        let v61 : string = "v60.getattr(v59)"
        let v62 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v62)
        let v64 : string = "v63.unwrap()"
        let v65 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : (bool * (float * float)) = method20(v47)
        let v67 : pyo3_Bound<pyo3_PyAny> = method21(v65)
        let v68 : string = "pyo3::prelude::PyAnyMethods::call(&v67, ((*v66).0, *(*v66).1), None)"
        let v69 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v69)
        let v71 : string = "v70.unwrap()"
        let v72 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v71
        let v73 : pyo3_Bound<pyo3_PyAny> = method22(v72)
        let v74 : string = "v73.extract()"
        let v75 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : Result<struct (float * float), pyo3_PyErr> = method23(v75)
        let v77 : string = "v76.unwrap()"
        let struct (v78 : float, v79 : float) = Fable.Core.RustInterop.emitRustExpr () v77
        let v80 : float = method24(v78)
        let v81 : float = method3(v80)
        let v82 : float = method25(v79)
        let v83 : string = "num_complex::Complex::new(v81, v82)"
        let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v84
        let v86 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v85)
        let v87 : string = "v86.unwrap()"
        let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v87
        let v89 : float = method27()
        let v90 : float = method3(v89)
        let v91 : float = method4()
        let v92 : string = "num_complex::Complex::new(v90, v91)"
        let v93 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v92
        let v94 : num_complex_Complex<float> = method12(v88)
        let v95 : string = "v94.re"
        let v96 : float = Fable.Core.RustInterop.emitRustExpr () v95
        let v97 : float =  -v96
        let v98 : bool = v96 >= v97
        let v99 : float =
            if v98 then
                v96
            else
                v97
        let v100 : bool = v99 < 0.0001
        let v102 : bool =
            if v100 then
                true
            else
                method28(v100)
        let v103 : string = $"__expect / actual: %A{v99} / expected: %A{0.0001}"
        let v104 : bool = v102 = false
        if v104 then
            failwith<unit> v103
        let v105 : num_complex_Complex<float> = method13(v88)
        let v106 : string = "v105.im"
        let v107 : float = Fable.Core.RustInterop.emitRustExpr () v106
        let v108 : float =  -v107
        let v109 : bool = v107 >= v108
        let v110 : float =
            if v109 then
                v107
            else
                v108
        let v111 : bool = v110 < 0.0001
        let v113 : bool =
            if v111 then
                true
            else
                method28(v111)
        let v114 : string = $"__expect / actual: %A{v110} / expected: %A{0.0001}"
        let v115 : bool = v113 = false
        if v115 then
            failwith<unit> v114
        let v116 : int32 = v36 + 1
        v34.l0 <- v116
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
        let v13 : (string []) = method8()
        let v14 : string = method10(v13)
        let v15 : num_complex_Complex<float> = method12(v12)
        let v16 : string = "v15.re"
        let v17 : float = Fable.Core.RustInterop.emitRustExpr () v16
        let v18 : num_complex_Complex<float> = method13(v12)
        let v19 : string = "v18.im"
        let v20 : float = Fable.Core.RustInterop.emitRustExpr () v19
        let v21 : (float * float) = v17, v20
        let v22 : (bool * (float * float)) = false, v21
        let v23 : pyo3_Python = method14(v0)
        let v24 : string = method15(v14)
        let v25 : string = $"fable_library_rust::String_::LrcStr::as_str(&v24)"
        let v26 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v25
        let v27 : string = "pyo3::types::PyModule::from_code_bound(v23, v26, \"\", \"\")"
        let v28 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v28)
        let v30 : string = "v29.unwrap()"
        let v31 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : string = method17()
        let v33 : string = $"fable_library_rust::String_::LrcStr::as_str(&v32)"
        let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v33
        let v35 : pyo3_Bound<pyo3_types_PyModule> = method18(v31)
        let v36 : string = "v35.getattr(v34)"
        let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v37)
        let v39 : string = "v38.unwrap()"
        let v40 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : (bool * (float * float)) = method20(v22)
        let v42 : pyo3_Bound<pyo3_PyAny> = method21(v40)
        let v43 : string = "pyo3::prelude::PyAnyMethods::call(&v42, ((*v41).0, *(*v41).1), None)"
        let v44 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v44)
        let v46 : string = "v45.unwrap()"
        let v47 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v46
        let v48 : pyo3_Bound<pyo3_PyAny> = method22(v47)
        let v49 : string = "v48.extract()"
        let v50 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : Result<struct (float * float), pyo3_PyErr> = method23(v50)
        let v52 : string = "v51.unwrap()"
        let struct (v53 : float, v54 : float) = Fable.Core.RustInterop.emitRustExpr () v52
        let v55 : float = method24(v53)
        let v56 : float = method3(v55)
        let v57 : float = method25(v54)
        let v58 : string = "num_complex::Complex::new(v56, v57)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v59
        let v61 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v60)
        let v62 : string = "v61.unwrap()"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : float = method27()
        let v65 : float = method3(v64)
        let v66 : float = method4()
        let v67 : string = "num_complex::Complex::new(v65, v66)"
        let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : num_complex_Complex<float> = method12(v63)
        let v70 : string = "v69.re"
        let v71 : float = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : bool = v71 > 0.0
        let v74 : bool =
            if v72 then
                true
            else
                method28(v72)
        let v75 : string = $"__expect / actual: %A{v71} / expected: %A{0.0}"
        let v76 : bool = v74 = false
        if v76 then
            failwith<unit> v75
        let v77 : num_complex_Complex<float> = method13(v63)
        let v78 : string = "v77.im"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : bool = v79 = 0.0
        let v82 : bool =
            if v80 then
                true
            else
                method28(v80)
        let v83 : string = $"__expect / actual: %A{v79} / expected: %A{0.0}"
        let v84 : bool = v82 = false
        if v84 then
            failwith<unit> v83
        let v85 : int32 = v6 + 1
        v4.l0 <- v85
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
    let v6 : (string []) = method8()
    let v7 : string = method10(v6)
    let v8 : num_complex_Complex<float> = method12(v5)
    let v9 : string = "v8.re"
    let v10 : float = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : num_complex_Complex<float> = method13(v5)
    let v12 : string = "v11.im"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : (float * float) = v10, v13
    let v15 : (bool * (float * float)) = false, v14
    let v16 : pyo3_Python = method14(v0)
    let v17 : string = method15(v7)
    let v18 : string = $"fable_library_rust::String_::LrcStr::as_str(&v17)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "pyo3::types::PyModule::from_code_bound(v16, v19, \"\", \"\")"
    let v21 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v21)
    let v23 : string = "v22.unwrap()"
    let v24 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = method17()
    let v26 : string = $"fable_library_rust::String_::LrcStr::as_str(&v25)"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : pyo3_Bound<pyo3_types_PyModule> = method18(v24)
    let v29 : string = "v28.getattr(v27)"
    let v30 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v30)
    let v32 : string = "v31.unwrap()"
    let v33 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : (bool * (float * float)) = method20(v15)
    let v35 : pyo3_Bound<pyo3_PyAny> = method21(v33)
    let v36 : string = "pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None)"
    let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v37)
    let v39 : string = "v38.unwrap()"
    let v40 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : pyo3_Bound<pyo3_PyAny> = method22(v40)
    let v42 : string = "v41.extract()"
    let v43 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<struct (float * float), pyo3_PyErr> = method23(v43)
    let v45 : string = "v44.unwrap()"
    let struct (v46 : float, v47 : float) = Fable.Core.RustInterop.emitRustExpr () v45
    let v48 : float = method24(v46)
    let v49 : float = method3(v48)
    let v50 : float = method25(v47)
    let v51 : string = "num_complex::Complex::new(v49, v50)"
    let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v52
    let v54 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v53)
    let v55 : string = "v54.unwrap()"
    let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : float = method27()
    let v58 : float = method3(v57)
    let v59 : float = method4()
    let v60 : string = "num_complex::Complex::new(v58, v59)"
    let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : num_complex_Complex<float> = method12(v56)
    let v63 : string = "v62.re"
    let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : bool = v64 = infinity
    let v67 : bool =
        if v65 then
            true
        else
            method28(v65)
    let v68 : string = $"__expect / actual: %A{v64} / expected: %A{infinity}"
    let v69 : bool = v67 = false
    if v69 then
        failwith<unit> v68
    let v70 : num_complex_Complex<float> = method13(v56)
    let v71 : string = "v70.im"
    let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71
    let v73 : bool = v72 = 0.0
    let v75 : bool =
        if v73 then
            true
        else
            method28(v73)
    let v76 : string = $"__expect / actual: %A{v72} / expected: %A{0.0}"
    let v77 : bool = v75 = false
    if v77 then
        failwith<unit> v76
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
    let v6 : (string []) = method8()
    let v7 : string = method10(v6)
    let v8 : num_complex_Complex<float> = method12(v5)
    let v9 : string = "v8.re"
    let v10 : float = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : num_complex_Complex<float> = method13(v5)
    let v12 : string = "v11.im"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : (float * float) = v10, v13
    let v15 : (bool * (float * float)) = false, v14
    let v16 : pyo3_Python = method14(v0)
    let v17 : string = method15(v7)
    let v18 : string = $"fable_library_rust::String_::LrcStr::as_str(&v17)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "pyo3::types::PyModule::from_code_bound(v16, v19, \"\", \"\")"
    let v21 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v21)
    let v23 : string = "v22.unwrap()"
    let v24 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = method17()
    let v26 : string = $"fable_library_rust::String_::LrcStr::as_str(&v25)"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : pyo3_Bound<pyo3_types_PyModule> = method18(v24)
    let v29 : string = "v28.getattr(v27)"
    let v30 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v30)
    let v32 : string = "v31.unwrap()"
    let v33 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : (bool * (float * float)) = method20(v15)
    let v35 : pyo3_Bound<pyo3_PyAny> = method21(v33)
    let v36 : string = "pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None)"
    let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v37)
    let v39 : string = "v38.unwrap()"
    let v40 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : pyo3_Bound<pyo3_PyAny> = method22(v40)
    let v42 : string = "v41.extract()"
    let v43 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<struct (float * float), pyo3_PyErr> = method23(v43)
    let v45 : string = "v44.unwrap()"
    let struct (v46 : float, v47 : float) = Fable.Core.RustInterop.emitRustExpr () v45
    let v48 : float = method24(v46)
    let v49 : float = method3(v48)
    let v50 : float = method25(v47)
    let v51 : string = "num_complex::Complex::new(v49, v50)"
    let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v52
    let v54 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v53)
    let v55 : string = "v54.unwrap()"
    let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : float = method27()
    let v58 : float = method3(v57)
    let v59 : float = method4()
    let v60 : string = "num_complex::Complex::new(v58, v59)"
    let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : num_complex_Complex<float> = method12(v5)
    let v63 : string = "v62.re"
    let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : num_complex_Complex<float> = method13(v5)
    let v66 : string = "v65.im"
    let v67 : float = Fable.Core.RustInterop.emitRustExpr () v66
    let v68 : float =  -v67
    let v69 : float = method24(v64)
    let v70 : float = method3(v69)
    let v71 : float = method25(v68)
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : (string []) = method8()
    let v75 : string = method10(v74)
    let v76 : num_complex_Complex<float> = method12(v73)
    let v77 : string = "v76.re"
    let v78 : float = Fable.Core.RustInterop.emitRustExpr () v77
    let v79 : num_complex_Complex<float> = method13(v73)
    let v80 : string = "v79.im"
    let v81 : float = Fable.Core.RustInterop.emitRustExpr () v80
    let v82 : (float * float) = v78, v81
    let v83 : (bool * (float * float)) = false, v82
    let v84 : pyo3_Python = method14(v0)
    let v85 : string = method15(v75)
    let v86 : string = $"fable_library_rust::String_::LrcStr::as_str(&v85)"
    let v87 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v86
    let v88 : string = "pyo3::types::PyModule::from_code_bound(v84, v87, \"\", \"\")"
    let v89 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v88
    let v90 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v89)
    let v91 : string = "v90.unwrap()"
    let v92 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v91
    let v93 : string = method17()
    let v94 : string = $"fable_library_rust::String_::LrcStr::as_str(&v93)"
    let v95 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v94
    let v96 : pyo3_Bound<pyo3_types_PyModule> = method18(v92)
    let v97 : string = "v96.getattr(v95)"
    let v98 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v97
    let v99 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v98)
    let v100 : string = "v99.unwrap()"
    let v101 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v100
    let v102 : (bool * (float * float)) = method20(v83)
    let v103 : pyo3_Bound<pyo3_PyAny> = method21(v101)
    let v104 : string = "pyo3::prelude::PyAnyMethods::call(&v103, ((*v102).0, *(*v102).1), None)"
    let v105 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v104
    let v106 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v105)
    let v107 : string = "v106.unwrap()"
    let v108 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v107
    let v109 : pyo3_Bound<pyo3_PyAny> = method22(v108)
    let v110 : string = "v109.extract()"
    let v111 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v110
    let v112 : Result<struct (float * float), pyo3_PyErr> = method23(v111)
    let v113 : string = "v112.unwrap()"
    let struct (v114 : float, v115 : float) = Fable.Core.RustInterop.emitRustExpr () v113
    let v116 : float = method24(v114)
    let v117 : float = method3(v116)
    let v118 : float = method25(v115)
    let v119 : string = "num_complex::Complex::new(v117, v118)"
    let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v119
    let v121 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v120
    let v122 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v121)
    let v123 : string = "v122.unwrap()"
    let v124 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v123
    let v125 : float = method27()
    let v126 : float = method3(v125)
    let v127 : float = method4()
    let v128 : string = "num_complex::Complex::new(v126, v127)"
    let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v128
    let v130 : string = "v124.conj()"
    let v131 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v130
    let v132 : num_complex_Complex<float> = method12(v56)
    let v133 : string = "v132.re"
    let v134 : float = Fable.Core.RustInterop.emitRustExpr () v133
    let v135 : num_complex_Complex<float> = method12(v131)
    let v136 : string = "v135.re"
    let v137 : float = Fable.Core.RustInterop.emitRustExpr () v136
    let v138 : bool = v134 = v137
    let v140 : bool =
        if v138 then
            true
        else
            method28(v138)
    let v141 : string = $"__expect / actual: %A{v134} / expected: %A{v137}"
    let v142 : bool = v140 = false
    if v142 then
        failwith<unit> v141
    let v143 : num_complex_Complex<float> = method13(v56)
    let v144 : string = "v143.im"
    let v145 : float = Fable.Core.RustInterop.emitRustExpr () v144
    let v146 : num_complex_Complex<float> = method13(v131)
    let v147 : string = "v146.im"
    let v148 : float = Fable.Core.RustInterop.emitRustExpr () v147
    let v149 : bool = v145 = v148
    let v151 : bool =
        if v149 then
            true
        else
            method28(v149)
    let v152 : string = $"__expect / actual: %A{v145} / expected: %A{v148}"
    let v153 : bool = v151 = false
    if v153 then
        failwith<unit> v152
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
    let v6 : (string []) = method8()
    let v7 : string = method10(v6)
    let v8 : num_complex_Complex<float> = method12(v5)
    let v9 : string = "v8.re"
    let v10 : float = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : num_complex_Complex<float> = method13(v5)
    let v12 : string = "v11.im"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : (float * float) = v10, v13
    let v15 : (bool * (float * float)) = false, v14
    let v16 : pyo3_Python = method14(v0)
    let v17 : string = method15(v7)
    let v18 : string = $"fable_library_rust::String_::LrcStr::as_str(&v17)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "pyo3::types::PyModule::from_code_bound(v16, v19, \"\", \"\")"
    let v21 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v21)
    let v23 : string = "v22.unwrap()"
    let v24 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = method17()
    let v26 : string = $"fable_library_rust::String_::LrcStr::as_str(&v25)"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : pyo3_Bound<pyo3_types_PyModule> = method18(v24)
    let v29 : string = "v28.getattr(v27)"
    let v30 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v30)
    let v32 : string = "v31.unwrap()"
    let v33 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : (bool * (float * float)) = method20(v15)
    let v35 : pyo3_Bound<pyo3_PyAny> = method21(v33)
    let v36 : string = "pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None)"
    let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v37)
    let v39 : string = "v38.unwrap()"
    let v40 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : pyo3_Bound<pyo3_PyAny> = method22(v40)
    let v42 : string = "v41.extract()"
    let v43 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<struct (float * float), pyo3_PyErr> = method23(v43)
    let v45 : string = "v44.unwrap()"
    let struct (v46 : float, v47 : float) = Fable.Core.RustInterop.emitRustExpr () v45
    let v48 : float = method24(v46)
    let v49 : float = method3(v48)
    let v50 : float = method25(v47)
    let v51 : string = "num_complex::Complex::new(v49, v50)"
    let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v52
    let v54 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v53)
    let v55 : string = "v54.unwrap()"
    let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : float = method27()
    let v58 : float = method3(v57)
    let v59 : float = method4()
    let v60 : string = "num_complex::Complex::new(v58, v59)"
    let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : num_complex_Complex<float> = method12(v56)
    let v63 : string = "v62.re"
    let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : bool = v64 < infinity
    let v67 : bool =
        if v65 then
            true
        else
            method28(v65)
    let v68 : string = $"__expect / actual: %A{v64} / expected: %A{infinity}"
    let v69 : bool = v67 = false
    if v69 then
        failwith<unit> v68
    let v70 : num_complex_Complex<float> = method13(v56)
    let v71 : string = "v70.im"
    let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71
    let v73 : bool = v72 < infinity
    let v75 : bool =
        if v73 then
            true
        else
            method28(v73)
    let v76 : string = $"__expect / actual: %A{v72} / expected: %A{infinity}"
    let v77 : bool = v75 = false
    if v77 then
        failwith<unit> v76
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
    let v6 : (string []) = method8()
    let v7 : string = method10(v6)
    let v8 : num_complex_Complex<float> = method12(v5)
    let v9 : string = "v8.re"
    let v10 : float = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : num_complex_Complex<float> = method13(v5)
    let v12 : string = "v11.im"
    let v13 : float = Fable.Core.RustInterop.emitRustExpr () v12
    let v14 : (float * float) = v10, v13
    let v15 : (bool * (float * float)) = false, v14
    let v16 : pyo3_Python = method14(v0)
    let v17 : string = method15(v7)
    let v18 : string = $"fable_library_rust::String_::LrcStr::as_str(&v17)"
    let v19 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : string = "pyo3::types::PyModule::from_code_bound(v16, v19, \"\", \"\")"
    let v21 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v20
    let v22 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v21)
    let v23 : string = "v22.unwrap()"
    let v24 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v23
    let v25 : string = method17()
    let v26 : string = $"fable_library_rust::String_::LrcStr::as_str(&v25)"
    let v27 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : pyo3_Bound<pyo3_types_PyModule> = method18(v24)
    let v29 : string = "v28.getattr(v27)"
    let v30 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v30)
    let v32 : string = "v31.unwrap()"
    let v33 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : (bool * (float * float)) = method20(v15)
    let v35 : pyo3_Bound<pyo3_PyAny> = method21(v33)
    let v36 : string = "pyo3::prelude::PyAnyMethods::call(&v35, ((*v34).0, *(*v34).1), None)"
    let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v37)
    let v39 : string = "v38.unwrap()"
    let v40 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : pyo3_Bound<pyo3_PyAny> = method22(v40)
    let v42 : string = "v41.extract()"
    let v43 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<struct (float * float), pyo3_PyErr> = method23(v43)
    let v45 : string = "v44.unwrap()"
    let struct (v46 : float, v47 : float) = Fable.Core.RustInterop.emitRustExpr () v45
    let v48 : float = method24(v46)
    let v49 : float = method3(v48)
    let v50 : float = method25(v47)
    let v51 : string = "num_complex::Complex::new(v49, v50)"
    let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v52
    let v54 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v53)
    let v55 : string = "v54.unwrap()"
    let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v55
    let v57 : float = method27()
    let v58 : float = method3(v57)
    let v59 : float = method4()
    let v60 : string = "num_complex::Complex::new(v58, v59)"
    let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : num_complex_Complex<float> = method12(v56)
    let v63 : string = "v62.re"
    let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : float = v64 + 0.08333333333333333
    let v66 : float =  -v65
    let v67 : bool = v65 >= v66
    let v68 : float =
        if v67 then
            v65
        else
            v66
    let v69 : bool = v68 < 0.0001
    let v71 : bool =
        if v69 then
            true
        else
            method28(v69)
    let v72 : string = $"__expect / actual: %A{v68} / expected: %A{0.0001}"
    let v73 : bool = v71 = false
    if v73 then
        failwith<unit> v72
    let v74 : num_complex_Complex<float> = method13(v56)
    let v75 : string = "v74.im"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : bool = v76 = 0.0
    let v79 : bool =
        if v77 then
            true
        else
            method28(v77)
    let v80 : string = $"__expect / actual: %A{v76} / expected: %A{0.0}"
    let v81 : bool = v79 = false
    if v81 then
        failwith<unit> v80
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
        let v12 : (string []) = method8()
        let v13 : string = method10(v12)
        let v14 : num_complex_Complex<float> = method12(v11)
        let v15 : string = "v14.re"
        let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
        let v17 : num_complex_Complex<float> = method13(v11)
        let v18 : string = "v17.im"
        let v19 : float = Fable.Core.RustInterop.emitRustExpr () v18
        let v20 : (float * float) = v16, v19
        let v21 : (bool * (float * float)) = false, v20
        let v22 : pyo3_Python = method14(v0)
        let v23 : string = method15(v13)
        let v24 : string = $"fable_library_rust::String_::LrcStr::as_str(&v23)"
        let v25 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v24
        let v26 : string = "pyo3::types::PyModule::from_code_bound(v22, v25, \"\", \"\")"
        let v27 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v26
        let v28 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v27)
        let v29 : string = "v28.unwrap()"
        let v30 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v29
        let v31 : string = method17()
        let v32 : string = $"fable_library_rust::String_::LrcStr::as_str(&v31)"
        let v33 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : pyo3_Bound<pyo3_types_PyModule> = method18(v30)
        let v35 : string = "v34.getattr(v33)"
        let v36 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v36)
        let v38 : string = "v37.unwrap()"
        let v39 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : (bool * (float * float)) = method20(v21)
        let v41 : pyo3_Bound<pyo3_PyAny> = method21(v39)
        let v42 : string = "pyo3::prelude::PyAnyMethods::call(&v41, ((*v40).0, *(*v40).1), None)"
        let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v43)
        let v45 : string = "v44.unwrap()"
        let v46 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : pyo3_Bound<pyo3_PyAny> = method22(v46)
        let v48 : string = "v47.extract()"
        let v49 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : Result<struct (float * float), pyo3_PyErr> = method23(v49)
        let v51 : string = "v50.unwrap()"
        let struct (v52 : float, v53 : float) = Fable.Core.RustInterop.emitRustExpr () v51
        let v54 : float = method24(v52)
        let v55 : float = method3(v54)
        let v56 : float = method25(v53)
        let v57 : string = "num_complex::Complex::new(v55, v56)"
        let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v58
        let v60 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v59)
        let v61 : string = "v60.unwrap()"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : float = method27()
        let v64 : float = method3(v63)
        let v65 : float = method4()
        let v66 : string = "num_complex::Complex::new(v64, v65)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : num_complex_Complex<float> = method12(v62)
        let v69 : string = "v68.re"
        let v70 : float = Fable.Core.RustInterop.emitRustExpr () v69
        let v71 : bool = v70 = 0.0
        let v72 : bool = method66(v71)
        let v74 : bool =
            if v72 then
                true
            else
                method28(v72)
        let v75 : string = $"__expect / actual: %A{v70} / expected: %A{0.0}"
        let v76 : bool = v74 = false
        if v76 then
            failwith<unit> v75
        let v77 : num_complex_Complex<float> = method13(v62)
        let v78 : string = "v77.im"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : bool = v79 = 0.0
        let v81 : bool = method66(v80)
        let v83 : bool =
            if v81 then
                true
            else
                method28(v81)
        let v84 : string = $"__expect / actual: %A{v79} / expected: %A{0.0}"
        let v85 : bool = v83 = false
        if v85 then
            failwith<unit> v84
        let v86 : int32 = v5 + 1
        v3.l0 <- v86
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
        let v33 : (string []) = method8()
        let v34 : string = method10(v33)
        let v35 : num_complex_Complex<float> = method12(v32)
        let v36 : string = "v35.re"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : num_complex_Complex<float> = method13(v32)
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
        let v81 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v80)
        let v82 : string = "v81.unwrap()"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v82
        let v84 : float = method27()
        let v85 : float = method3(v84)
        let v86 : float = method4()
        let v87 : string = "num_complex::Complex::new(v85, v86)"
        let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v87
        let v89 : num_complex_Complex<float> = method12(v83)
        let v90 : string = "v89.re"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr () v90
        let v92 : bool = v91 = 0.0
        let v93 : bool = method66(v92)
        let v95 : bool =
            if v93 then
                true
            else
                method28(v93)
        let v96 : string = $"__expect / actual: %A{v91} / expected: %A{0.0}"
        let v97 : bool = v95 = false
        if v97 then
            failwith<unit> v96
        let v98 : num_complex_Complex<float> = method13(v83)
        let v99 : string = "v98.im"
        let v100 : float = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : bool = v100 = 0.0
        let v102 : bool = method66(v101)
        let v104 : bool =
            if v102 then
                true
            else
                method28(v102)
        let v105 : string = $"__expect / actual: %A{v100} / expected: %A{0.0}"
        let v106 : bool = v104 = false
        if v106 then
            failwith<unit> v105
        let v107 : int32 = v31 + 1
        v29.l0 <- v107
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
and method87 () : (string []) =
    let v0 : string = "import sys"
    let v1 : string = "import traceback"
    let v2 : string = "def trace_calls(frame, event, arg):"
    let v3 : string = "    if event != 'call':"
    let v4 : string = "        return"
    let v5 : string = "    co = frame.f_code"
    let v6 : string = "    func_name = co.co_name"
    let v7 : string = "    func_line_no = frame.f_lineno"
    let v8 : string = "    func_filename = co.co_filename"
    let v9 : string = "    caller = frame.f_back"
    let v10 : string = "    caller_line_no = caller.f_lineno"
    let v11 : string = "    caller_filename = caller.f_code.co_filename"
    let v12 : string = "    args = frame.f_locals"
    let v13 : string = "    args_str = ', '.join([f\"{k}={v}\" for k, v in args.items() if k != 'ctx'])"
    let v14 : string = "gamma_"
    let v15 : string = $"    print(f'{v14} / Call to {{func_name}}({{args_str}}) on line {{func_line_no}} of {{func_filename}} from line {{caller_line_no}} of {{caller_filename}}', flush=True)"
    let v16 : string = "def start_trace():"
    let v17 : string = "    sys.settrace(trace_calls)"
    let v18 : string = "def stop_trace():"
    let v19 : string = "    sys.settrace(None)"
    let v20 : string = "import mpmath"
    let v21 : string = "def fn(log, s):"
    let v22 : string = "    if log:"
    let v23 : string = $"        print(f'{v14} / s: {{s}}', flush=True)"
    let v24 : string = "    s = complex(*s)"
    let v25 : string = "    try:"
    let v26 : string = "        if log: start_trace()"
    let v27 : string = "        s = mpmath.gamma(s)"
    let v28 : string = "        if log: stop_trace()"
    let v29 : string = "    except ValueError as e:"
    let v30 : string = "        if s.real == 1:"
    let v31 : string = "            s = complex(float('inf'), 0)"
    let v32 : string = "    return (s.real, s.imag)"
    let v33 : (string []) = [|v0; v1; v2; v3; v4; v5; v6; v7; v8; v9; v10; v11; v12; v13; v15; v16; v17; v18; v19; v20; v21; v22; v23; v24; v25; v26; v27; v28; v29; v30; v31; v32|]
    method9(v33)
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
        let v28 : (string []) = method8()
        let v29 : string = method10(v28)
        let v30 : num_complex_Complex<float> = method12(v27)
        let v31 : string = "v30.re"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : num_complex_Complex<float> = method13(v27)
        let v34 : string = "v33.im"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
        let v36 : (float * float) = v32, v35
        let v37 : (bool * (float * float)) = false, v36
        let v38 : pyo3_Python = method14(v0)
        let v39 : string = method15(v29)
        let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
        let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
        let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v43)
        let v45 : string = "v44.unwrap()"
        let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : string = method17()
        let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
        let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : pyo3_Bound<pyo3_types_PyModule> = method18(v46)
        let v51 : string = "v50.getattr(v49)"
        let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v52)
        let v54 : string = "v53.unwrap()"
        let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : (bool * (float * float)) = method20(v37)
        let v57 : pyo3_Bound<pyo3_PyAny> = method21(v55)
        let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, ((*v56).0, *(*v56).1), None)"
        let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v59)
        let v61 : string = "v60.unwrap()"
        let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : pyo3_Bound<pyo3_PyAny> = method22(v62)
        let v64 : string = "v63.extract()"
        let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : Result<struct (float * float), pyo3_PyErr> = method23(v65)
        let v67 : string = "v66.unwrap()"
        let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
        let v70 : float = method24(v68)
        let v71 : float = method3(v70)
        let v72 : float = method25(v69)
        let v73 : string = "num_complex::Complex::new(v71, v72)"
        let v74 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v74
        let v76 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v75)
        let v77 : string = "v76.unwrap()"
        let v78 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : float = method27()
        let v80 : float = method3(v79)
        let v81 : float = method4()
        let v82 : string = "num_complex::Complex::new(v80, v81)"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v82
        let v84 : float = method2()
        let v85 : float = method3(v84)
        let v86 : float = method4()
        let v87 : string = "num_complex::Complex::new(v85, v86)"
        let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v87
        let v89 : num_complex_Complex<float> = method84(v88)
        let v90 : num_complex_Complex<float> = method85(v27)
        let v91 : string = "num_complex::Complex::powc(v89, v90)"
        let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v91
        let v93 : float = method86()
        let v94 : float = method3(v93)
        let v95 : float = method4()
        let v96 : string = "num_complex::Complex::new(v94, v95)"
        let v97 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v96
        let v98 : float = method53()
        let v99 : float = method3(v98)
        let v100 : float = method4()
        let v101 : string = "num_complex::Complex::new(v99, v100)"
        let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v101
        let v103 : string = "v27 - v102"
        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v103
        let v105 : num_complex_Complex<float> = method84(v97)
        let v106 : num_complex_Complex<float> = method85(v104)
        let v107 : string = "num_complex::Complex::powc(v105, v106)"
        let v108 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v107
        let v109 : string = "v92 * v108"
        let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v109
        let v111 : float = method86()
        let v112 : float = method3(v111)
        let v113 : float = method4()
        let v114 : string = "num_complex::Complex::new(v112, v113)"
        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v114
        let v116 : string = "v115 * v27"
        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v116
        let v118 : float = method2()
        let v119 : float = method3(v118)
        let v120 : float = method4()
        let v121 : string = "num_complex::Complex::new(v119, v120)"
        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v121
        let v123 : string = "v117 / v122"
        let v124 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v123
        let v125 : string = "v124.sin()"
        let v126 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v125
        let v127 : string = "v110 * v126"
        let v128 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v127
        let v129 : float = method53()
        let v130 : float = method3(v129)
        let v131 : float = method4()
        let v132 : string = "num_complex::Complex::new(v130, v131)"
        let v133 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v132
        let v134 : string = "v133 - v27"
        let v135 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v134
        let v136 : (string []) = method87()
        let v137 : string = method10(v136)
        let v138 : num_complex_Complex<float> = method12(v135)
        let v139 : string = "v138.re"
        let v140 : float = Fable.Core.RustInterop.emitRustExpr () v139
        let v141 : num_complex_Complex<float> = method13(v135)
        let v142 : string = "v141.im"
        let v143 : float = Fable.Core.RustInterop.emitRustExpr () v142
        let v144 : (float * float) = v140, v143
        let v145 : (bool * (float * float)) = false, v144
        let v146 : pyo3_Python = method14(v0)
        let v147 : string = method15(v137)
        let v148 : string = $"fable_library_rust::String_::LrcStr::as_str(&v147)"
        let v149 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v148
        let v150 : string = "pyo3::types::PyModule::from_code_bound(v146, v149, \"\", \"\")"
        let v151 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v150
        let v152 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v151)
        let v153 : string = "v152.unwrap()"
        let v154 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v153
        let v155 : string = method17()
        let v156 : string = $"fable_library_rust::String_::LrcStr::as_str(&v155)"
        let v157 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v156
        let v158 : pyo3_Bound<pyo3_types_PyModule> = method18(v154)
        let v159 : string = "v158.getattr(v157)"
        let v160 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v159
        let v161 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v160)
        let v162 : string = "v161.unwrap()"
        let v163 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v162
        let v164 : (bool * (float * float)) = method20(v145)
        let v165 : pyo3_Bound<pyo3_PyAny> = method21(v163)
        let v166 : string = "pyo3::prelude::PyAnyMethods::call(&v165, ((*v164).0, *(*v164).1), None)"
        let v167 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v166
        let v168 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v167)
        let v169 : string = "v168.unwrap()"
        let v170 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v169
        let v171 : pyo3_Bound<pyo3_PyAny> = method22(v170)
        let v172 : string = "v171.extract()"
        let v173 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v172
        let v174 : Result<struct (float * float), pyo3_PyErr> = method23(v173)
        let v175 : string = "v174.unwrap()"
        let struct (v176 : float, v177 : float) = Fable.Core.RustInterop.emitRustExpr () v175
        let v178 : float = method24(v176)
        let v179 : float = method3(v178)
        let v180 : float = method25(v177)
        let v181 : string = "num_complex::Complex::new(v179, v180)"
        let v182 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v181
        let v183 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v182
        let v184 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v183)
        let v185 : string = "v184.unwrap()"
        let v186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v185
        let v187 : string = "v128 * v186"
        let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v187
        let v189 : num_complex_Complex<float> = method12(v27)
        let v190 : string = "v189.re"
        let v191 : float = Fable.Core.RustInterop.emitRustExpr () v190
        let v192 : float = 1.0 - v191
        let v193 : num_complex_Complex<float> = method13(v27)
        let v194 : string = "v193.im"
        let v195 : float = Fable.Core.RustInterop.emitRustExpr () v194
        let v196 : float =  -v195
        let v197 : float = method24(v192)
        let v198 : float = method3(v197)
        let v199 : float = method25(v196)
        let v200 : string = "num_complex::Complex::new(v198, v199)"
        let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v200
        let v202 : (string []) = method8()
        let v203 : string = method10(v202)
        let v204 : num_complex_Complex<float> = method12(v201)
        let v205 : string = "v204.re"
        let v206 : float = Fable.Core.RustInterop.emitRustExpr () v205
        let v207 : num_complex_Complex<float> = method13(v201)
        let v208 : string = "v207.im"
        let v209 : float = Fable.Core.RustInterop.emitRustExpr () v208
        let v210 : (float * float) = v206, v209
        let v211 : (bool * (float * float)) = false, v210
        let v212 : pyo3_Python = method14(v0)
        let v213 : string = method15(v203)
        let v214 : string = $"fable_library_rust::String_::LrcStr::as_str(&v213)"
        let v215 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v214
        let v216 : string = "pyo3::types::PyModule::from_code_bound(v212, v215, \"\", \"\")"
        let v217 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v216
        let v218 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v217)
        let v219 : string = "v218.unwrap()"
        let v220 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v219
        let v221 : string = method17()
        let v222 : string = $"fable_library_rust::String_::LrcStr::as_str(&v221)"
        let v223 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v222
        let v224 : pyo3_Bound<pyo3_types_PyModule> = method18(v220)
        let v225 : string = "v224.getattr(v223)"
        let v226 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v225
        let v227 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v226)
        let v228 : string = "v227.unwrap()"
        let v229 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v228
        let v230 : (bool * (float * float)) = method20(v211)
        let v231 : pyo3_Bound<pyo3_PyAny> = method21(v229)
        let v232 : string = "pyo3::prelude::PyAnyMethods::call(&v231, ((*v230).0, *(*v230).1), None)"
        let v233 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v232
        let v234 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v233)
        let v235 : string = "v234.unwrap()"
        let v236 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v235
        let v237 : pyo3_Bound<pyo3_PyAny> = method22(v236)
        let v238 : string = "v237.extract()"
        let v239 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v238
        let v240 : Result<struct (float * float), pyo3_PyErr> = method23(v239)
        let v241 : string = "v240.unwrap()"
        let struct (v242 : float, v243 : float) = Fable.Core.RustInterop.emitRustExpr () v241
        let v244 : float = method24(v242)
        let v245 : float = method3(v244)
        let v246 : float = method25(v243)
        let v247 : string = "num_complex::Complex::new(v245, v246)"
        let v248 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v247
        let v249 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v248
        let v250 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v249)
        let v251 : string = "v250.unwrap()"
        let v252 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v251
        let v253 : float = method27()
        let v254 : float = method3(v253)
        let v255 : float = method4()
        let v256 : string = "num_complex::Complex::new(v254, v255)"
        let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v256
        let v258 : string = "v188 * v252"
        let v259 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v258
        let v260 : num_complex_Complex<float> = method12(v78)
        let v261 : string = "v260.re"
        let v262 : float = Fable.Core.RustInterop.emitRustExpr () v261
        let v263 : num_complex_Complex<float> = method12(v259)
        let v264 : string = "v263.re"
        let v265 : float = Fable.Core.RustInterop.emitRustExpr () v264
        let v266 : float = v262 - v265
        let v267 : float =  -v266
        let v268 : bool = v266 >= v267
        let v269 : float =
            if v268 then
                v266
            else
                v267
        let v270 : bool = v269 < 0.0001
        let v272 : bool =
            if v270 then
                true
            else
                method28(v270)
        let v273 : string = $"__expect / actual: %A{v269} / expected: %A{0.0001}"
        let v274 : bool = v272 = false
        if v274 then
            failwith<unit> v273
        let v275 : num_complex_Complex<float> = method13(v78)
        let v276 : string = "v275.im"
        let v277 : float = Fable.Core.RustInterop.emitRustExpr () v276
        let v278 : num_complex_Complex<float> = method13(v259)
        let v279 : string = "v278.im"
        let v280 : float = Fable.Core.RustInterop.emitRustExpr () v279
        let v281 : float = v277 - v280
        let v282 : float =  -v281
        let v283 : bool = v281 >= v282
        let v284 : float =
            if v283 then
                v281
            else
                v282
        let v285 : bool = v284 < 0.0001
        let v287 : bool =
            if v285 then
                true
            else
                method28(v285)
        let v288 : string = $"__expect / actual: %A{v284} / expected: %A{0.0001}"
        let v289 : bool = v287 = false
        if v289 then
            failwith<unit> v288
        let v290 : int32 = v26 + 1
        v24.l0 <- v290
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
        let v27 : (string []) = method8()
        let v28 : string = method10(v27)
        let v29 : num_complex_Complex<float> = method12(v14)
        let v30 : string = "v29.re"
        let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : num_complex_Complex<float> = method13(v14)
        let v33 : string = "v32.im"
        let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33
        let v35 : (float * float) = v31, v34
        let v36 : (bool * (float * float)) = false, v35
        let v37 : pyo3_Python = method14(v0)
        let v38 : string = method15(v28)
        let v39 : string = $"fable_library_rust::String_::LrcStr::as_str(&v38)"
        let v40 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : string = "pyo3::types::PyModule::from_code_bound(v37, v40, \"\", \"\")"
        let v42 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method16(v42)
        let v44 : string = "v43.unwrap()"
        let v45 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : string = method17()
        let v47 : string = $"fable_library_rust::String_::LrcStr::as_str(&v46)"
        let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : pyo3_Bound<pyo3_types_PyModule> = method18(v45)
        let v50 : string = "v49.getattr(v48)"
        let v51 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v51)
        let v53 : string = "v52.unwrap()"
        let v54 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v53
        let v55 : (bool * (float * float)) = method20(v36)
        let v56 : pyo3_Bound<pyo3_PyAny> = method21(v54)
        let v57 : string = "pyo3::prelude::PyAnyMethods::call(&v56, ((*v55).0, *(*v55).1), None)"
        let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method19(v58)
        let v60 : string = "v59.unwrap()"
        let v61 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : pyo3_Bound<pyo3_PyAny> = method22(v61)
        let v63 : string = "v62.extract()"
        let v64 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : Result<struct (float * float), pyo3_PyErr> = method23(v64)
        let v66 : string = "v65.unwrap()"
        let struct (v67 : float, v68 : float) = Fable.Core.RustInterop.emitRustExpr () v66
        let v69 : float = method24(v67)
        let v70 : float = method3(v69)
        let v71 : float = method25(v68)
        let v72 : string = "num_complex::Complex::new(v70, v71)"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
        let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method26(v74)
        let v76 : string = "v75.unwrap()"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : float = method27()
        let v79 : float = method3(v78)
        let v80 : float = method4()
        let v81 : string = "num_complex::Complex::new(v79, v80)"
        let v82 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : num_complex_Complex<float> = method12(v77)
        let v84 : string = "v83.re"
        let v85 : float = Fable.Core.RustInterop.emitRustExpr () v84
        let v86 : float = v85 - v26
        let v87 : float =  -v86
        let v88 : bool = v86 >= v87
        let v89 : float =
            if v88 then
                v86
            else
                v87
        let v90 : bool = v89 < 0.01
        let v92 : bool =
            if v90 then
                true
            else
                method28(v90)
        let v93 : string = $"__expect / actual: %A{v89} / expected: %A{0.01}"
        let v94 : bool = v92 = false
        if v94 then
            failwith<unit> v93
        let v95 : num_complex_Complex<float> = method13(v77)
        let v96 : string = "v95.im"
        let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96
        let v98 : bool = v97 < 0.01
        let v100 : bool =
            if v98 then
                true
            else
                method28(v98)
        let v101 : string = $"__expect / actual: %A{v97} / expected: %A{0.01}"
        let v102 : bool = v100 = false
        if v102 then
            failwith<unit> v101
        let v103 : int32 = v8 + 1
        v6.l0 <- v103
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
