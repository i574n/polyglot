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
and method8 (v0 : (string [])) : (string []) =
    v0
and method10 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method9 (v0 : (string [])) : string =
    let v1 : int32 = v0.Length
    let v2 : string = ""
    let v3 : Mut1 = {l0 = 0; l1 = v2} : Mut1
    while method10(v1, v3) do
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
and method11 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method12 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method13 (v0 : pyo3_Python) : pyo3_Python =
    v0
and method14 (v0 : string) : string =
    v0
and method15 (v0 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> =
    v0
and method16 () : string =
    let v0 : string = "fn"
    v0
and method17 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and method18 (v0 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> =
    v0
and method19 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method20 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method21 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method22 (v0 : Result<struct (float * float), pyo3_PyErr>) : Result<struct (float * float), pyo3_PyErr> =
    v0
and method23 (v0 : float) : float =
    v0
and method24 (v0 : float) : float =
    v0
and method25 (v0 : Result<num_complex_Complex<float>, pyo3_PyErr>) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    v0
and method26 () : float =
    0.0
and method27 (v0 : bool) : bool =
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
        let v19 : string = "import mpmath"
        let v20 : string = "def fn(log, s):"
        let v21 : string = "    if log:"
        let v22 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v23 : string = "    s = complex(*s)"
        let v24 : string = "    try:"
        let v25 : string = "        s = mpmath.zeta(s)"
        let v26 : string = "    except ValueError as e:"
        let v27 : string = "        if s.real == 1:"
        let v28 : string = "            s = complex(float('inf'), 0)"
        let v29 : string = "    return (s.real, s.imag)"
        let v30 : (string []) = [|v19; v20; v21; v22; v23; v24; v25; v26; v27; v28; v29|]
        let v31 : (string []) = method8(v30)
        let v32 : string = method9(v31)
        let v33 : num_complex_Complex<float> = method11(v17)
        let v34 : string = "v33.re"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
        let v36 : num_complex_Complex<float> = method12(v17)
        let v37 : string = "v36.im"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : (float * float) = v35, v38
        let v40 : (bool * (float * float)) = false, v39
        let v41 : pyo3_Python = method13(v0)
        let v42 : string = method14(v32)
        let v43 : string = $"fable_library_rust::String_::LrcStr::as_str(&v42)"
        let v44 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : string = "pyo3::types::PyModule::from_code_bound(v41, v44, \"\", \"\")"
        let v46 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v46)
        let v48 : string = "v47.unwrap()"
        let v49 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : string = method16()
        let v51 : string = $"fable_library_rust::String_::LrcStr::as_str(&v50)"
        let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : pyo3_Bound<pyo3_types_PyModule> = method17(v49)
        let v54 : string = "v53.getattr(v52)"
        let v55 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v55)
        let v57 : string = "v56.unwrap()"
        let v58 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : (bool * (float * float)) = method19(v40)
        let v60 : pyo3_Bound<pyo3_PyAny> = method20(v58)
        let v61 : string = "pyo3::prelude::PyAnyMethods::call(&v60, ((*v59).0, *(*v59).1), None)"
        let v62 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v62)
        let v64 : string = "v63.unwrap()"
        let v65 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : pyo3_Bound<pyo3_PyAny> = method21(v65)
        let v67 : string = "v66.extract()"
        let v68 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : Result<struct (float * float), pyo3_PyErr> = method22(v68)
        let v70 : string = "v69.unwrap()"
        let struct (v71 : float, v72 : float) = Fable.Core.RustInterop.emitRustExpr () v70
        let v73 : float = method23(v71)
        let v74 : float = method3(v73)
        let v75 : float = method24(v72)
        let v76 : string = "num_complex::Complex::new(v74, v75)"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v77
        let v79 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v78)
        let v80 : string = "v79.unwrap()"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v80
        let v82 : float = method26()
        let v83 : float = method3(v82)
        let v84 : float = method4()
        let v85 : string = "num_complex::Complex::new(v83, v84)"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : num_complex_Complex<float> = method12(v81)
        let v88 : string = "v87.im"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : bool = v89 = 0.0
        let v92 : bool =
            if v90 then
                true
            else
                method27(v90)
        let v93 : string = $"__expect / actual: %A{v89} / expected: %A{0.0}"
        let v94 : bool = v92 = false
        if v94 then
            failwith<unit> v93
        let v95 : num_complex_Complex<float> = method11(v81)
        let v96 : string = "v95.re"
        let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96
        let v98 : float = v97 - v18
        let v99 : float =  -v98
        let v100 : bool = v98 >= v99
        let v101 : float =
            if v100 then
                v98
            else
                v99
        let v102 : bool = v101 < 0.0001
        let v104 : bool =
            if v102 then
                true
            else
                method27(v102)
        let v105 : string = $"__expect / actual: %A{v101} / expected: %A{0.0001}"
        let v106 : bool = v104 = false
        if v106 then
            failwith<unit> v105
        let v107 : int32 = v16 + 1
        v14.l0 <- v107
        ()
    ()
and method28 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method29 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method32 () : float =
    -2.0
and method31 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method32()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "import mpmath"
    let v7 : string = "def fn(log, s):"
    let v8 : string = "    if log:"
    let v9 : string = "        print(f'zeta_ / s: {s}', flush=True)"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method8(v17)
    let v19 : string = method9(v18)
    let v20 : num_complex_Complex<float> = method11(v5)
    let v21 : string = "v20.re"
    let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : num_complex_Complex<float> = method12(v5)
    let v24 : string = "v23.im"
    let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (float * float) = v22, v25
    let v27 : (bool * (float * float)) = false, v26
    let v28 : pyo3_Python = method13(v0)
    let v29 : string = method14(v19)
    let v30 : string = $"fable_library_rust::String_::LrcStr::as_str(&v29)"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "pyo3::types::PyModule::from_code_bound(v28, v31, \"\", \"\")"
    let v33 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v33)
    let v35 : string = "v34.unwrap()"
    let v36 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = method16()
    let v38 : string = $"fable_library_rust::String_::LrcStr::as_str(&v37)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : pyo3_Bound<pyo3_types_PyModule> = method17(v36)
    let v41 : string = "v40.getattr(v39)"
    let v42 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v42)
    let v44 : string = "v43.unwrap()"
    let v45 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : (bool * (float * float)) = method19(v27)
    let v47 : pyo3_Bound<pyo3_PyAny> = method20(v45)
    let v48 : string = "pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None)"
    let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v49)
    let v51 : string = "v50.unwrap()"
    let v52 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : pyo3_Bound<pyo3_PyAny> = method21(v52)
    let v54 : string = "v53.extract()"
    let v55 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<struct (float * float), pyo3_PyErr> = method22(v55)
    let v57 : string = "v56.unwrap()"
    let struct (v58 : float, v59 : float) = Fable.Core.RustInterop.emitRustExpr () v57
    let v60 : float = method23(v58)
    let v61 : float = method3(v60)
    let v62 : float = method24(v59)
    let v63 : string = "num_complex::Complex::new(v61, v62)"
    let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v64
    let v66 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v65)
    let v67 : string = "v66.unwrap()"
    let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : float = method26()
    let v70 : float = method3(v69)
    let v71 : float = method4()
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : num_complex_Complex<float> = method11(v68)
    let v75 : string = "v74.re"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : float = v76 - 0.8673
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
            method27(v81)
    let v84 : string = $"__expect / actual: %A{v80} / expected: %A{0.001}"
    let v85 : bool = v83 = false
    if v85 then
        failwith<unit> v84
    let v86 : num_complex_Complex<float> = method12(v68)
    let v87 : string = "v86.im"
    let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : float = v88 - 0.275
    let v90 : float =  -v89
    let v91 : bool = v89 >= v90
    let v92 : float =
        if v91 then
            v89
        else
            v90
    let v93 : bool = v92 < 0.001
    let v95 : bool =
        if v93 then
            true
        else
            method27(v93)
    let v96 : string = $"__expect / actual: %A{v92} / expected: %A{0.001}"
    let v97 : bool = v95 = false
    if v97 then
        failwith<unit> v96
and method30 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method31(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method35 () : UH0 =
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
and method36 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : float = method23(v2)
        let v5 : float = method3(v4)
        let v6 : float = method4()
        let v7 : string = "num_complex::Complex::new(v5, v6)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v7
        let v9 : string = "import mpmath"
        let v10 : string = "def fn(log, s):"
        let v11 : string = "    if log:"
        let v12 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v13 : string = "    s = complex(*s)"
        let v14 : string = "    try:"
        let v15 : string = "        s = mpmath.zeta(s)"
        let v16 : string = "    except ValueError as e:"
        let v17 : string = "        if s.real == 1:"
        let v18 : string = "            s = complex(float('inf'), 0)"
        let v19 : string = "    return (s.real, s.imag)"
        let v20 : (string []) = [|v9; v10; v11; v12; v13; v14; v15; v16; v17; v18; v19|]
        let v21 : (string []) = method8(v20)
        let v22 : string = method9(v21)
        let v23 : num_complex_Complex<float> = method11(v8)
        let v24 : string = "v23.re"
        let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
        let v26 : num_complex_Complex<float> = method12(v8)
        let v27 : string = "v26.im"
        let v28 : float = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : (float * float) = v25, v28
        let v30 : (bool * (float * float)) = false, v29
        let v31 : pyo3_Python = method13(v0)
        let v32 : string = method14(v22)
        let v33 : string = $"fable_library_rust::String_::LrcStr::as_str(&v32)"
        let v34 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v33
        let v35 : string = "pyo3::types::PyModule::from_code_bound(v31, v34, \"\", \"\")"
        let v36 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v36)
        let v38 : string = "v37.unwrap()"
        let v39 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : string = method16()
        let v41 : string = $"fable_library_rust::String_::LrcStr::as_str(&v40)"
        let v42 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : pyo3_Bound<pyo3_types_PyModule> = method17(v39)
        let v44 : string = "v43.getattr(v42)"
        let v45 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v45)
        let v47 : string = "v46.unwrap()"
        let v48 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : (bool * (float * float)) = method19(v30)
        let v50 : pyo3_Bound<pyo3_PyAny> = method20(v48)
        let v51 : string = "pyo3::prelude::PyAnyMethods::call(&v50, ((*v49).0, *(*v49).1), None)"
        let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v52)
        let v54 : string = "v53.unwrap()"
        let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : pyo3_Bound<pyo3_PyAny> = method21(v55)
        let v57 : string = "v56.extract()"
        let v58 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : Result<struct (float * float), pyo3_PyErr> = method22(v58)
        let v60 : string = "v59.unwrap()"
        let struct (v61 : float, v62 : float) = Fable.Core.RustInterop.emitRustExpr () v60
        let v63 : float = method23(v61)
        let v64 : float = method3(v63)
        let v65 : float = method24(v62)
        let v66 : string = "num_complex::Complex::new(v64, v65)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v67
        let v69 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v68)
        let v70 : string = "v69.unwrap()"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : float = method26()
        let v73 : float = method3(v72)
        let v74 : float = method4()
        let v75 : string = "num_complex::Complex::new(v73, v74)"
        let v76 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : num_complex_Complex<float> = method11(v71)
        let v78 : string = "v77.re"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : bool = v79 = 0.0
        let v82 : bool =
            if v80 then
                true
            else
                method27(v80)
        let v83 : string = $"__expect / actual: %A{v79} / expected: %A{0.0}"
        let v84 : bool = v82 = false
        if v84 then
            failwith<unit> v83
        let v85 : num_complex_Complex<float> = method12(v71)
        let v86 : string = "v85.im"
        let v87 : float = Fable.Core.RustInterop.emitRustExpr () v86
        let v88 : bool = v87 = 0.0
        let v90 : bool =
            if v88 then
                true
            else
                method27(v88)
        let v91 : string = $"__expect / actual: %A{v87} / expected: %A{0.0}"
        let v92 : bool = v90 = false
        if v92 then
            failwith<unit> v91
        method36(v0, v3)
    | UH0_1 -> (* Nil *)
        ()
and method34 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method35()
    method36(v0, v1)
and method33 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method34(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method39 () : float =
    0.5
and method40 () : float =
    14.134725
and method41 () : float =
    21.02204
and method42 () : float =
    25.010857
and method43 () : float =
    30.424876
and method44 () : float =
    32.935062
and method45 () : float =
    37.586178
and method46 (v0 : (num_complex_Complex<float> [])) : (num_complex_Complex<float> []) =
    v0
and method38 (v0 : pyo3_Python) : unit =
    let v1 : float = method39()
    let v2 : float = method3(v1)
    let v3 : float = method40()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method39()
    let v7 : float = method3(v6)
    let v8 : float = method41()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method39()
    let v12 : float = method3(v11)
    let v13 : float = method42()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method39()
    let v17 : float = method3(v16)
    let v18 : float = method43()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method39()
    let v22 : float = method3(v21)
    let v23 : float = method44()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : float = method39()
    let v27 : float = method3(v26)
    let v28 : float = method45()
    let v29 : string = "num_complex::Complex::new(v27, v28)"
    let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25; v30|]
    let v32 : (num_complex_Complex<float> []) = method46(v31)
    let v33 : int32 = v32.Length
    let v34 : Mut0 = {l0 = 0} : Mut0
    while method7(v33, v34) do
        let v36 : int32 = v34.l0
        let v37 : num_complex_Complex<float> = v32.[int v36]
        let v38 : string = "import mpmath"
        let v39 : string = "def fn(log, s):"
        let v40 : string = "    if log:"
        let v41 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v42 : string = "    s = complex(*s)"
        let v43 : string = "    try:"
        let v44 : string = "        s = mpmath.zeta(s)"
        let v45 : string = "    except ValueError as e:"
        let v46 : string = "        if s.real == 1:"
        let v47 : string = "            s = complex(float('inf'), 0)"
        let v48 : string = "    return (s.real, s.imag)"
        let v49 : (string []) = [|v38; v39; v40; v41; v42; v43; v44; v45; v46; v47; v48|]
        let v50 : (string []) = method8(v49)
        let v51 : string = method9(v50)
        let v52 : num_complex_Complex<float> = method11(v37)
        let v53 : string = "v52.re"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53
        let v55 : num_complex_Complex<float> = method12(v37)
        let v56 : string = "v55.im"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr () v56
        let v58 : (float * float) = v54, v57
        let v59 : (bool * (float * float)) = false, v58
        let v60 : pyo3_Python = method13(v0)
        let v61 : string = method14(v51)
        let v62 : string = $"fable_library_rust::String_::LrcStr::as_str(&v61)"
        let v63 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : string = "pyo3::types::PyModule::from_code_bound(v60, v63, \"\", \"\")"
        let v65 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v65)
        let v67 : string = "v66.unwrap()"
        let v68 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : string = method16()
        let v70 : string = $"fable_library_rust::String_::LrcStr::as_str(&v69)"
        let v71 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : pyo3_Bound<pyo3_types_PyModule> = method17(v68)
        let v73 : string = "v72.getattr(v71)"
        let v74 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v74)
        let v76 : string = "v75.unwrap()"
        let v77 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : (bool * (float * float)) = method19(v59)
        let v79 : pyo3_Bound<pyo3_PyAny> = method20(v77)
        let v80 : string = "pyo3::prelude::PyAnyMethods::call(&v79, ((*v78).0, *(*v78).1), None)"
        let v81 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v80
        let v82 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v81)
        let v83 : string = "v82.unwrap()"
        let v84 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : pyo3_Bound<pyo3_PyAny> = method21(v84)
        let v86 : string = "v85.extract()"
        let v87 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v86
        let v88 : Result<struct (float * float), pyo3_PyErr> = method22(v87)
        let v89 : string = "v88.unwrap()"
        let struct (v90 : float, v91 : float) = Fable.Core.RustInterop.emitRustExpr () v89
        let v92 : float = method23(v90)
        let v93 : float = method3(v92)
        let v94 : float = method24(v91)
        let v95 : string = "num_complex::Complex::new(v93, v94)"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v95
        let v97 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v96
        let v98 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v97)
        let v99 : string = "v98.unwrap()"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : float = method26()
        let v102 : float = method3(v101)
        let v103 : float = method4()
        let v104 : string = "num_complex::Complex::new(v102, v103)"
        let v105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v104
        let v106 : num_complex_Complex<float> = method11(v100)
        let v107 : string = "v106.re"
        let v108 : float = Fable.Core.RustInterop.emitRustExpr () v107
        let v109 : float =  -v108
        let v110 : bool = v108 >= v109
        let v111 : float =
            if v110 then
                v108
            else
                v109
        let v112 : bool = v111 < 0.0001
        let v114 : bool =
            if v112 then
                true
            else
                method27(v112)
        let v115 : string = $"__expect / actual: %A{v111} / expected: %A{0.0001}"
        let v116 : bool = v114 = false
        if v116 then
            failwith<unit> v115
        let v117 : num_complex_Complex<float> = method12(v100)
        let v118 : string = "v117.im"
        let v119 : float = Fable.Core.RustInterop.emitRustExpr () v118
        let v120 : float =  -v119
        let v121 : bool = v119 >= v120
        let v122 : float =
            if v121 then
                v119
            else
                v120
        let v123 : bool = v122 < 0.0001
        let v125 : bool =
            if v123 then
                true
            else
                method27(v123)
        let v126 : string = $"__expect / actual: %A{v122} / expected: %A{0.0001}"
        let v127 : bool = v125 = false
        if v127 then
            failwith<unit> v126
        let v128 : int32 = v36 + 1
        v34.l0 <- v128
        ()
    ()
and method37 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method38(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method49 (v0 : (float [])) : (float []) =
    v0
and method48 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 3.0; 4.0; 5.0; 10.0; 20.0; 50.0|]
    let v2 : (float []) = method49(v1)
    let v3 : int32 = v2.Length
    let v4 : Mut0 = {l0 = 0} : Mut0
    while method7(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : float = v2.[int v6]
        let v8 : float = method23(v7)
        let v9 : float = method3(v8)
        let v10 : float = method4()
        let v11 : string = "num_complex::Complex::new(v9, v10)"
        let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v11
        let v13 : string = "import mpmath"
        let v14 : string = "def fn(log, s):"
        let v15 : string = "    if log:"
        let v16 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v17 : string = "    s = complex(*s)"
        let v18 : string = "    try:"
        let v19 : string = "        s = mpmath.zeta(s)"
        let v20 : string = "    except ValueError as e:"
        let v21 : string = "        if s.real == 1:"
        let v22 : string = "            s = complex(float('inf'), 0)"
        let v23 : string = "    return (s.real, s.imag)"
        let v24 : (string []) = [|v13; v14; v15; v16; v17; v18; v19; v20; v21; v22; v23|]
        let v25 : (string []) = method8(v24)
        let v26 : string = method9(v25)
        let v27 : num_complex_Complex<float> = method11(v12)
        let v28 : string = "v27.re"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : num_complex_Complex<float> = method12(v12)
        let v31 : string = "v30.im"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : (float * float) = v29, v32
        let v34 : (bool * (float * float)) = false, v33
        let v35 : pyo3_Python = method13(v0)
        let v36 : string = method14(v26)
        let v37 : string = $"fable_library_rust::String_::LrcStr::as_str(&v36)"
        let v38 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : string = "pyo3::types::PyModule::from_code_bound(v35, v38, \"\", \"\")"
        let v40 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v40)
        let v42 : string = "v41.unwrap()"
        let v43 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : string = method16()
        let v45 : string = $"fable_library_rust::String_::LrcStr::as_str(&v44)"
        let v46 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : pyo3_Bound<pyo3_types_PyModule> = method17(v43)
        let v48 : string = "v47.getattr(v46)"
        let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v49)
        let v51 : string = "v50.unwrap()"
        let v52 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : (bool * (float * float)) = method19(v34)
        let v54 : pyo3_Bound<pyo3_PyAny> = method20(v52)
        let v55 : string = "pyo3::prelude::PyAnyMethods::call(&v54, ((*v53).0, *(*v53).1), None)"
        let v56 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v56)
        let v58 : string = "v57.unwrap()"
        let v59 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : pyo3_Bound<pyo3_PyAny> = method21(v59)
        let v61 : string = "v60.extract()"
        let v62 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : Result<struct (float * float), pyo3_PyErr> = method22(v62)
        let v64 : string = "v63.unwrap()"
        let struct (v65 : float, v66 : float) = Fable.Core.RustInterop.emitRustExpr () v64
        let v67 : float = method23(v65)
        let v68 : float = method3(v67)
        let v69 : float = method24(v66)
        let v70 : string = "num_complex::Complex::new(v68, v69)"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v71
        let v73 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v72)
        let v74 : string = "v73.unwrap()"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : float = method26()
        let v77 : float = method3(v76)
        let v78 : float = method4()
        let v79 : string = "num_complex::Complex::new(v77, v78)"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : num_complex_Complex<float> = method11(v75)
        let v82 : string = "v81.re"
        let v83 : float = Fable.Core.RustInterop.emitRustExpr () v82
        let v84 : bool = v83 > 0.0
        let v86 : bool =
            if v84 then
                true
            else
                method27(v84)
        let v87 : string = $"__expect / actual: %A{v83} / expected: %A{0.0}"
        let v88 : bool = v86 = false
        if v88 then
            failwith<unit> v87
        let v89 : num_complex_Complex<float> = method12(v75)
        let v90 : string = "v89.im"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr () v90
        let v92 : bool = v91 = 0.0
        let v94 : bool =
            if v92 then
                true
            else
                method27(v92)
        let v95 : string = $"__expect / actual: %A{v91} / expected: %A{0.0}"
        let v96 : bool = v94 = false
        if v96 then
            failwith<unit> v95
        let v97 : int32 = v6 + 1
        v4.l0 <- v97
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
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method52 () : float =
    1.0
and method51 (v0 : pyo3_Python) : unit =
    let v1 : float = method52()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "import mpmath"
    let v7 : string = "def fn(log, s):"
    let v8 : string = "    if log:"
    let v9 : string = "        print(f'zeta_ / s: {s}', flush=True)"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method8(v17)
    let v19 : string = method9(v18)
    let v20 : num_complex_Complex<float> = method11(v5)
    let v21 : string = "v20.re"
    let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : num_complex_Complex<float> = method12(v5)
    let v24 : string = "v23.im"
    let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (float * float) = v22, v25
    let v27 : (bool * (float * float)) = false, v26
    let v28 : pyo3_Python = method13(v0)
    let v29 : string = method14(v19)
    let v30 : string = $"fable_library_rust::String_::LrcStr::as_str(&v29)"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "pyo3::types::PyModule::from_code_bound(v28, v31, \"\", \"\")"
    let v33 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v33)
    let v35 : string = "v34.unwrap()"
    let v36 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = method16()
    let v38 : string = $"fable_library_rust::String_::LrcStr::as_str(&v37)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : pyo3_Bound<pyo3_types_PyModule> = method17(v36)
    let v41 : string = "v40.getattr(v39)"
    let v42 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v42)
    let v44 : string = "v43.unwrap()"
    let v45 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : (bool * (float * float)) = method19(v27)
    let v47 : pyo3_Bound<pyo3_PyAny> = method20(v45)
    let v48 : string = "pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None)"
    let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v49)
    let v51 : string = "v50.unwrap()"
    let v52 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : pyo3_Bound<pyo3_PyAny> = method21(v52)
    let v54 : string = "v53.extract()"
    let v55 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<struct (float * float), pyo3_PyErr> = method22(v55)
    let v57 : string = "v56.unwrap()"
    let struct (v58 : float, v59 : float) = Fable.Core.RustInterop.emitRustExpr () v57
    let v60 : float = method23(v58)
    let v61 : float = method3(v60)
    let v62 : float = method24(v59)
    let v63 : string = "num_complex::Complex::new(v61, v62)"
    let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v64
    let v66 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v65)
    let v67 : string = "v66.unwrap()"
    let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : float = method26()
    let v70 : float = method3(v69)
    let v71 : float = method4()
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : num_complex_Complex<float> = method11(v68)
    let v75 : string = "v74.re"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : bool = v76 = infinity
    let v79 : bool =
        if v77 then
            true
        else
            method27(v77)
    let v80 : string = $"__expect / actual: %A{v76} / expected: %A{infinity}"
    let v81 : bool = v79 = false
    if v81 then
        failwith<unit> v80
    let v82 : num_complex_Complex<float> = method12(v68)
    let v83 : string = "v82.im"
    let v84 : float = Fable.Core.RustInterop.emitRustExpr () v83
    let v85 : bool = v84 = 0.0
    let v87 : bool =
        if v85 then
            true
        else
            method27(v85)
    let v88 : string = $"__expect / actual: %A{v84} / expected: %A{0.0}"
    let v89 : bool = v87 = false
    if v89 then
        failwith<unit> v88
and method50 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method51(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method55 () : float =
    10.0
and method54 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method55()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "import mpmath"
    let v7 : string = "def fn(log, s):"
    let v8 : string = "    if log:"
    let v9 : string = "        print(f'zeta_ / s: {s}', flush=True)"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method8(v17)
    let v19 : string = method9(v18)
    let v20 : num_complex_Complex<float> = method11(v5)
    let v21 : string = "v20.re"
    let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : num_complex_Complex<float> = method12(v5)
    let v24 : string = "v23.im"
    let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (float * float) = v22, v25
    let v27 : (bool * (float * float)) = false, v26
    let v28 : pyo3_Python = method13(v0)
    let v29 : string = method14(v19)
    let v30 : string = $"fable_library_rust::String_::LrcStr::as_str(&v29)"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "pyo3::types::PyModule::from_code_bound(v28, v31, \"\", \"\")"
    let v33 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v33)
    let v35 : string = "v34.unwrap()"
    let v36 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = method16()
    let v38 : string = $"fable_library_rust::String_::LrcStr::as_str(&v37)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : pyo3_Bound<pyo3_types_PyModule> = method17(v36)
    let v41 : string = "v40.getattr(v39)"
    let v42 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v42)
    let v44 : string = "v43.unwrap()"
    let v45 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : (bool * (float * float)) = method19(v27)
    let v47 : pyo3_Bound<pyo3_PyAny> = method20(v45)
    let v48 : string = "pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None)"
    let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v49)
    let v51 : string = "v50.unwrap()"
    let v52 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : pyo3_Bound<pyo3_PyAny> = method21(v52)
    let v54 : string = "v53.extract()"
    let v55 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<struct (float * float), pyo3_PyErr> = method22(v55)
    let v57 : string = "v56.unwrap()"
    let struct (v58 : float, v59 : float) = Fable.Core.RustInterop.emitRustExpr () v57
    let v60 : float = method23(v58)
    let v61 : float = method3(v60)
    let v62 : float = method24(v59)
    let v63 : string = "num_complex::Complex::new(v61, v62)"
    let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v64
    let v66 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v65)
    let v67 : string = "v66.unwrap()"
    let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : float = method26()
    let v70 : float = method3(v69)
    let v71 : float = method4()
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : num_complex_Complex<float> = method11(v5)
    let v75 : string = "v74.re"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : num_complex_Complex<float> = method12(v5)
    let v78 : string = "v77.im"
    let v79 : float = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : float =  -v79
    let v81 : float = method23(v76)
    let v82 : float = method3(v81)
    let v83 : float = method24(v80)
    let v84 : string = "num_complex::Complex::new(v82, v83)"
    let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v84
    let v86 : (string []) = [|v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v87 : (string []) = method8(v86)
    let v88 : string = method9(v87)
    let v89 : num_complex_Complex<float> = method11(v85)
    let v90 : string = "v89.re"
    let v91 : float = Fable.Core.RustInterop.emitRustExpr () v90
    let v92 : num_complex_Complex<float> = method12(v85)
    let v93 : string = "v92.im"
    let v94 : float = Fable.Core.RustInterop.emitRustExpr () v93
    let v95 : (float * float) = v91, v94
    let v96 : (bool * (float * float)) = false, v95
    let v97 : pyo3_Python = method13(v0)
    let v98 : string = method14(v88)
    let v99 : string = $"fable_library_rust::String_::LrcStr::as_str(&v98)"
    let v100 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v99
    let v101 : string = "pyo3::types::PyModule::from_code_bound(v97, v100, \"\", \"\")"
    let v102 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v101
    let v103 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v102)
    let v104 : string = "v103.unwrap()"
    let v105 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v104
    let v106 : string = method16()
    let v107 : string = $"fable_library_rust::String_::LrcStr::as_str(&v106)"
    let v108 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v107
    let v109 : pyo3_Bound<pyo3_types_PyModule> = method17(v105)
    let v110 : string = "v109.getattr(v108)"
    let v111 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v110
    let v112 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v111)
    let v113 : string = "v112.unwrap()"
    let v114 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v113
    let v115 : (bool * (float * float)) = method19(v96)
    let v116 : pyo3_Bound<pyo3_PyAny> = method20(v114)
    let v117 : string = "pyo3::prelude::PyAnyMethods::call(&v116, ((*v115).0, *(*v115).1), None)"
    let v118 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v117
    let v119 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v118)
    let v120 : string = "v119.unwrap()"
    let v121 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v120
    let v122 : pyo3_Bound<pyo3_PyAny> = method21(v121)
    let v123 : string = "v122.extract()"
    let v124 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v123
    let v125 : Result<struct (float * float), pyo3_PyErr> = method22(v124)
    let v126 : string = "v125.unwrap()"
    let struct (v127 : float, v128 : float) = Fable.Core.RustInterop.emitRustExpr () v126
    let v129 : float = method23(v127)
    let v130 : float = method3(v129)
    let v131 : float = method24(v128)
    let v132 : string = "num_complex::Complex::new(v130, v131)"
    let v133 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v132
    let v134 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v133
    let v135 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v134)
    let v136 : string = "v135.unwrap()"
    let v137 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v136
    let v138 : float = method26()
    let v139 : float = method3(v138)
    let v140 : float = method4()
    let v141 : string = "num_complex::Complex::new(v139, v140)"
    let v142 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v141
    let v143 : string = "v137.conj()"
    let v144 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v143
    let v145 : num_complex_Complex<float> = method11(v68)
    let v146 : string = "v145.re"
    let v147 : float = Fable.Core.RustInterop.emitRustExpr () v146
    let v148 : num_complex_Complex<float> = method11(v144)
    let v149 : string = "v148.re"
    let v150 : float = Fable.Core.RustInterop.emitRustExpr () v149
    let v151 : bool = v147 = v150
    let v153 : bool =
        if v151 then
            true
        else
            method27(v151)
    let v154 : string = $"__expect / actual: %A{v147} / expected: %A{v150}"
    let v155 : bool = v153 = false
    if v155 then
        failwith<unit> v154
    let v156 : num_complex_Complex<float> = method12(v68)
    let v157 : string = "v156.im"
    let v158 : float = Fable.Core.RustInterop.emitRustExpr () v157
    let v159 : num_complex_Complex<float> = method12(v144)
    let v160 : string = "v159.im"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr () v160
    let v162 : bool = v158 = v161
    let v164 : bool =
        if v162 then
            true
        else
            method27(v162)
    let v165 : string = $"__expect / actual: %A{v158} / expected: %A{v161}"
    let v166 : bool = v164 = false
    if v166 then
        failwith<unit> v165
and method53 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method54(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method58 () : float =
    0.01
and method59 () : float =
    0.01
and method57 (v0 : pyo3_Python) : unit =
    let v1 : float = method58()
    let v2 : float = method3(v1)
    let v3 : float = method59()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "import mpmath"
    let v7 : string = "def fn(log, s):"
    let v8 : string = "    if log:"
    let v9 : string = "        print(f'zeta_ / s: {s}', flush=True)"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method8(v17)
    let v19 : string = method9(v18)
    let v20 : num_complex_Complex<float> = method11(v5)
    let v21 : string = "v20.re"
    let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : num_complex_Complex<float> = method12(v5)
    let v24 : string = "v23.im"
    let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (float * float) = v22, v25
    let v27 : (bool * (float * float)) = false, v26
    let v28 : pyo3_Python = method13(v0)
    let v29 : string = method14(v19)
    let v30 : string = $"fable_library_rust::String_::LrcStr::as_str(&v29)"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "pyo3::types::PyModule::from_code_bound(v28, v31, \"\", \"\")"
    let v33 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v33)
    let v35 : string = "v34.unwrap()"
    let v36 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = method16()
    let v38 : string = $"fable_library_rust::String_::LrcStr::as_str(&v37)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : pyo3_Bound<pyo3_types_PyModule> = method17(v36)
    let v41 : string = "v40.getattr(v39)"
    let v42 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v42)
    let v44 : string = "v43.unwrap()"
    let v45 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : (bool * (float * float)) = method19(v27)
    let v47 : pyo3_Bound<pyo3_PyAny> = method20(v45)
    let v48 : string = "pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None)"
    let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v49)
    let v51 : string = "v50.unwrap()"
    let v52 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : pyo3_Bound<pyo3_PyAny> = method21(v52)
    let v54 : string = "v53.extract()"
    let v55 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<struct (float * float), pyo3_PyErr> = method22(v55)
    let v57 : string = "v56.unwrap()"
    let struct (v58 : float, v59 : float) = Fable.Core.RustInterop.emitRustExpr () v57
    let v60 : float = method23(v58)
    let v61 : float = method3(v60)
    let v62 : float = method24(v59)
    let v63 : string = "num_complex::Complex::new(v61, v62)"
    let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v64
    let v66 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v65)
    let v67 : string = "v66.unwrap()"
    let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : float = method26()
    let v70 : float = method3(v69)
    let v71 : float = method4()
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : num_complex_Complex<float> = method11(v68)
    let v75 : string = "v74.re"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : bool = v76 < infinity
    let v79 : bool =
        if v77 then
            true
        else
            method27(v77)
    let v80 : string = $"__expect / actual: %A{v76} / expected: %A{infinity}"
    let v81 : bool = v79 = false
    if v81 then
        failwith<unit> v80
    let v82 : num_complex_Complex<float> = method12(v68)
    let v83 : string = "v82.im"
    let v84 : float = Fable.Core.RustInterop.emitRustExpr () v83
    let v85 : bool = v84 < infinity
    let v87 : bool =
        if v85 then
            true
        else
            method27(v85)
    let v88 : string = $"__expect / actual: %A{v84} / expected: %A{infinity}"
    let v89 : bool = v87 = false
    if v89 then
        failwith<unit> v88
and method56 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method57(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method61 (v0 : pyo3_Python) : unit =
    let v1 : float = method5()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = "import mpmath"
    let v7 : string = "def fn(log, s):"
    let v8 : string = "    if log:"
    let v9 : string = "        print(f'zeta_ / s: {s}', flush=True)"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v6; v7; v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method8(v17)
    let v19 : string = method9(v18)
    let v20 : num_complex_Complex<float> = method11(v5)
    let v21 : string = "v20.re"
    let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
    let v23 : num_complex_Complex<float> = method12(v5)
    let v24 : string = "v23.im"
    let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (float * float) = v22, v25
    let v27 : (bool * (float * float)) = false, v26
    let v28 : pyo3_Python = method13(v0)
    let v29 : string = method14(v19)
    let v30 : string = $"fable_library_rust::String_::LrcStr::as_str(&v29)"
    let v31 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v30
    let v32 : string = "pyo3::types::PyModule::from_code_bound(v28, v31, \"\", \"\")"
    let v33 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v32
    let v34 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v33)
    let v35 : string = "v34.unwrap()"
    let v36 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v35
    let v37 : string = method16()
    let v38 : string = $"fable_library_rust::String_::LrcStr::as_str(&v37)"
    let v39 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v38
    let v40 : pyo3_Bound<pyo3_types_PyModule> = method17(v36)
    let v41 : string = "v40.getattr(v39)"
    let v42 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v41
    let v43 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v42)
    let v44 : string = "v43.unwrap()"
    let v45 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v44
    let v46 : (bool * (float * float)) = method19(v27)
    let v47 : pyo3_Bound<pyo3_PyAny> = method20(v45)
    let v48 : string = "pyo3::prelude::PyAnyMethods::call(&v47, ((*v46).0, *(*v46).1), None)"
    let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v49)
    let v51 : string = "v50.unwrap()"
    let v52 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : pyo3_Bound<pyo3_PyAny> = method21(v52)
    let v54 : string = "v53.extract()"
    let v55 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<struct (float * float), pyo3_PyErr> = method22(v55)
    let v57 : string = "v56.unwrap()"
    let struct (v58 : float, v59 : float) = Fable.Core.RustInterop.emitRustExpr () v57
    let v60 : float = method23(v58)
    let v61 : float = method3(v60)
    let v62 : float = method24(v59)
    let v63 : string = "num_complex::Complex::new(v61, v62)"
    let v64 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v64
    let v66 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v65)
    let v67 : string = "v66.unwrap()"
    let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : float = method26()
    let v70 : float = method3(v69)
    let v71 : float = method4()
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : num_complex_Complex<float> = method11(v68)
    let v75 : string = "v74.re"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75
    let v77 : float = v76 + 0.08333333333333333
    let v78 : float =  -v77
    let v79 : bool = v77 >= v78
    let v80 : float =
        if v79 then
            v77
        else
            v78
    let v81 : bool = v80 < 0.0001
    let v83 : bool =
        if v81 then
            true
        else
            method27(v81)
    let v84 : string = $"__expect / actual: %A{v80} / expected: %A{0.0001}"
    let v85 : bool = v83 = false
    if v85 then
        failwith<unit> v84
    let v86 : num_complex_Complex<float> = method12(v68)
    let v87 : string = "v86.im"
    let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : bool = v88 = 0.0
    let v91 : bool =
        if v89 then
            true
        else
            method27(v89)
    let v92 : string = $"__expect / actual: %A{v88} / expected: %A{0.0}"
    let v93 : bool = v91 = false
    if v93 then
        failwith<unit> v92
and method60 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method61(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method64 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    let v1 : (float []) = method49(v0)
    v1
and method65 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method63 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = method64()
    let v2 : int32 = v1.Length
    let v3 : Mut0 = {l0 = 0} : Mut0
    while method7(v2, v3) do
        let v5 : int32 = v3.l0
        let v6 : float = v1.[int v5]
        let v7 : float = method26()
        let v8 : float = method3(v7)
        let v9 : float = method24(v6)
        let v10 : string = "num_complex::Complex::new(v8, v9)"
        let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
        let v12 : string = "import mpmath"
        let v13 : string = "def fn(log, s):"
        let v14 : string = "    if log:"
        let v15 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v16 : string = "    s = complex(*s)"
        let v17 : string = "    try:"
        let v18 : string = "        s = mpmath.zeta(s)"
        let v19 : string = "    except ValueError as e:"
        let v20 : string = "        if s.real == 1:"
        let v21 : string = "            s = complex(float('inf'), 0)"
        let v22 : string = "    return (s.real, s.imag)"
        let v23 : (string []) = [|v12; v13; v14; v15; v16; v17; v18; v19; v20; v21; v22|]
        let v24 : (string []) = method8(v23)
        let v25 : string = method9(v24)
        let v26 : num_complex_Complex<float> = method11(v11)
        let v27 : string = "v26.re"
        let v28 : float = Fable.Core.RustInterop.emitRustExpr () v27
        let v29 : num_complex_Complex<float> = method12(v11)
        let v30 : string = "v29.im"
        let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : (float * float) = v28, v31
        let v33 : (bool * (float * float)) = false, v32
        let v34 : pyo3_Python = method13(v0)
        let v35 : string = method14(v25)
        let v36 : string = $"fable_library_rust::String_::LrcStr::as_str(&v35)"
        let v37 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : string = "pyo3::types::PyModule::from_code_bound(v34, v37, \"\", \"\")"
        let v39 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v39)
        let v41 : string = "v40.unwrap()"
        let v42 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : string = method16()
        let v44 : string = $"fable_library_rust::String_::LrcStr::as_str(&v43)"
        let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : pyo3_Bound<pyo3_types_PyModule> = method17(v42)
        let v47 : string = "v46.getattr(v45)"
        let v48 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v48)
        let v50 : string = "v49.unwrap()"
        let v51 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : (bool * (float * float)) = method19(v33)
        let v53 : pyo3_Bound<pyo3_PyAny> = method20(v51)
        let v54 : string = "pyo3::prelude::PyAnyMethods::call(&v53, ((*v52).0, *(*v52).1), None)"
        let v55 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v55)
        let v57 : string = "v56.unwrap()"
        let v58 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : pyo3_Bound<pyo3_PyAny> = method21(v58)
        let v60 : string = "v59.extract()"
        let v61 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : Result<struct (float * float), pyo3_PyErr> = method22(v61)
        let v63 : string = "v62.unwrap()"
        let struct (v64 : float, v65 : float) = Fable.Core.RustInterop.emitRustExpr () v63
        let v66 : float = method23(v64)
        let v67 : float = method3(v66)
        let v68 : float = method24(v65)
        let v69 : string = "num_complex::Complex::new(v67, v68)"
        let v70 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v69
        let v71 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v70
        let v72 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v71)
        let v73 : string = "v72.unwrap()"
        let v74 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : float = method26()
        let v76 : float = method3(v75)
        let v77 : float = method4()
        let v78 : string = "num_complex::Complex::new(v76, v77)"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : num_complex_Complex<float> = method11(v74)
        let v81 : string = "v80.re"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : bool = v82 = 0.0
        let v84 : bool = method65(v83)
        let v86 : bool =
            if v84 then
                true
            else
                method27(v84)
        let v87 : string = $"__expect / actual: %A{v82} / expected: %A{0.0}"
        let v88 : bool = v86 = false
        if v88 then
            failwith<unit> v87
        let v89 : num_complex_Complex<float> = method12(v74)
        let v90 : string = "v89.im"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr () v90
        let v92 : bool = v91 = 0.0
        let v93 : bool = method65(v92)
        let v95 : bool =
            if v93 then
                true
            else
                method27(v93)
        let v96 : string = $"__expect / actual: %A{v91} / expected: %A{0.0}"
        let v97 : bool = v95 = false
        if v97 then
            failwith<unit> v96
        let v98 : int32 = v5 + 1
        v3.l0 <- v98
        ()
    ()
and method62 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method63(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method68 () : float =
    0.75
and method69 () : float =
    20.5
and method70 () : float =
    1.25
and method71 () : float =
    30.1
and method72 () : float =
    0.25
and method73 () : float =
    40.0
and method74 () : float =
    50.0
and method67 (v0 : pyo3_Python) : unit =
    let v1 : float = method39()
    let v2 : float = method3(v1)
    let v3 : float = method40()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method68()
    let v7 : float = method3(v6)
    let v8 : float = method69()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method70()
    let v12 : float = method3(v11)
    let v13 : float = method71()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method72()
    let v17 : float = method3(v16)
    let v18 : float = method73()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method52()
    let v22 : float = method3(v21)
    let v23 : float = method74()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25|]
    let v27 : (num_complex_Complex<float> []) = method46(v26)
    let v28 : int32 = v27.Length
    let v29 : Mut0 = {l0 = 0} : Mut0
    while method7(v28, v29) do
        let v31 : int32 = v29.l0
        let v32 : num_complex_Complex<float> = v27.[int v31]
        let v33 : string = "import mpmath"
        let v34 : string = "def fn(log, s):"
        let v35 : string = "    if log:"
        let v36 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v37 : string = "    s = complex(*s)"
        let v38 : string = "    try:"
        let v39 : string = "        s = mpmath.zeta(s)"
        let v40 : string = "    except ValueError as e:"
        let v41 : string = "        if s.real == 1:"
        let v42 : string = "            s = complex(float('inf'), 0)"
        let v43 : string = "    return (s.real, s.imag)"
        let v44 : (string []) = [|v33; v34; v35; v36; v37; v38; v39; v40; v41; v42; v43|]
        let v45 : (string []) = method8(v44)
        let v46 : string = method9(v45)
        let v47 : num_complex_Complex<float> = method11(v32)
        let v48 : string = "v47.re"
        let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : num_complex_Complex<float> = method12(v32)
        let v51 : string = "v50.im"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : (float * float) = v49, v52
        let v54 : (bool * (float * float)) = false, v53
        let v55 : pyo3_Python = method13(v0)
        let v56 : string = method14(v46)
        let v57 : string = $"fable_library_rust::String_::LrcStr::as_str(&v56)"
        let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : string = "pyo3::types::PyModule::from_code_bound(v55, v58, \"\", \"\")"
        let v60 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v59
        let v61 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v60)
        let v62 : string = "v61.unwrap()"
        let v63 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : string = method16()
        let v65 : string = $"fable_library_rust::String_::LrcStr::as_str(&v64)"
        let v66 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v65
        let v67 : pyo3_Bound<pyo3_types_PyModule> = method17(v63)
        let v68 : string = "v67.getattr(v66)"
        let v69 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v69)
        let v71 : string = "v70.unwrap()"
        let v72 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v71
        let v73 : (bool * (float * float)) = method19(v54)
        let v74 : pyo3_Bound<pyo3_PyAny> = method20(v72)
        let v75 : string = "pyo3::prelude::PyAnyMethods::call(&v74, ((*v73).0, *(*v73).1), None)"
        let v76 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v76)
        let v78 : string = "v77.unwrap()"
        let v79 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : pyo3_Bound<pyo3_PyAny> = method21(v79)
        let v81 : string = "v80.extract()"
        let v82 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : Result<struct (float * float), pyo3_PyErr> = method22(v82)
        let v84 : string = "v83.unwrap()"
        let struct (v85 : float, v86 : float) = Fable.Core.RustInterop.emitRustExpr () v84
        let v87 : float = method23(v85)
        let v88 : float = method3(v87)
        let v89 : float = method24(v86)
        let v90 : string = "num_complex::Complex::new(v88, v89)"
        let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v90
        let v92 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v91
        let v93 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v92)
        let v94 : string = "v93.unwrap()"
        let v95 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v94
        let v96 : float = method26()
        let v97 : float = method3(v96)
        let v98 : float = method4()
        let v99 : string = "num_complex::Complex::new(v97, v98)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : num_complex_Complex<float> = method11(v95)
        let v102 : string = "v101.re"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102
        let v104 : bool = v103 = 0.0
        let v105 : bool = method65(v104)
        let v107 : bool =
            if v105 then
                true
            else
                method27(v105)
        let v108 : string = $"__expect / actual: %A{v103} / expected: %A{0.0}"
        let v109 : bool = v107 = false
        if v109 then
            failwith<unit> v108
        let v110 : num_complex_Complex<float> = method12(v95)
        let v111 : string = "v110.im"
        let v112 : float = Fable.Core.RustInterop.emitRustExpr () v111
        let v113 : bool = v112 = 0.0
        let v114 : bool = method65(v113)
        let v116 : bool =
            if v114 then
                true
            else
                method27(v114)
        let v117 : string = $"__expect / actual: %A{v112} / expected: %A{0.0}"
        let v118 : bool = v116 = false
        if v118 then
            failwith<unit> v117
        let v119 : int32 = v31 + 1
        v29.l0 <- v119
        ()
    ()
and method66 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method67(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method77 () : float =
    3.0
and method78 () : float =
    4.0
and method79 () : float =
    2.5
and method80 () : float =
    -3.5
and method81 () : float =
    1.5
and method82 () : float =
    2.5
and method83 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method84 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method85 () : float =
    3.141592653589793
and method76 (v0 : pyo3_Python) : unit =
    let v1 : float = method77()
    let v2 : float = method3(v1)
    let v3 : float = method78()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method79()
    let v7 : float = method3(v6)
    let v8 : float = method80()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method81()
    let v12 : float = method3(v11)
    let v13 : float = method82()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method39()
    let v17 : float = method3(v16)
    let v18 : float = method40()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20|]
    let v22 : (num_complex_Complex<float> []) = method46(v21)
    let v23 : int32 = v22.Length
    let v24 : Mut0 = {l0 = 0} : Mut0
    while method7(v23, v24) do
        let v26 : int32 = v24.l0
        let v27 : num_complex_Complex<float> = v22.[int v26]
        let v28 : string = "import mpmath"
        let v29 : string = "def fn(log, s):"
        let v30 : string = "    if log:"
        let v31 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v32 : string = "    s = complex(*s)"
        let v33 : string = "    try:"
        let v34 : string = "        s = mpmath.zeta(s)"
        let v35 : string = "    except ValueError as e:"
        let v36 : string = "        if s.real == 1:"
        let v37 : string = "            s = complex(float('inf'), 0)"
        let v38 : string = "    return (s.real, s.imag)"
        let v39 : (string []) = [|v28; v29; v30; v31; v32; v33; v34; v35; v36; v37; v38|]
        let v40 : (string []) = method8(v39)
        let v41 : string = method9(v40)
        let v42 : num_complex_Complex<float> = method11(v27)
        let v43 : string = "v42.re"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : num_complex_Complex<float> = method12(v27)
        let v46 : string = "v45.im"
        let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46
        let v48 : (float * float) = v44, v47
        let v49 : (bool * (float * float)) = false, v48
        let v50 : pyo3_Python = method13(v0)
        let v51 : string = method14(v41)
        let v52 : string = $"fable_library_rust::String_::LrcStr::as_str(&v51)"
        let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : string = "pyo3::types::PyModule::from_code_bound(v50, v53, \"\", \"\")"
        let v55 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v55)
        let v57 : string = "v56.unwrap()"
        let v58 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : string = method16()
        let v60 : string = $"fable_library_rust::String_::LrcStr::as_str(&v59)"
        let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : pyo3_Bound<pyo3_types_PyModule> = method17(v58)
        let v63 : string = "v62.getattr(v61)"
        let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v64)
        let v66 : string = "v65.unwrap()"
        let v67 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : (bool * (float * float)) = method19(v49)
        let v69 : pyo3_Bound<pyo3_PyAny> = method20(v67)
        let v70 : string = "pyo3::prelude::PyAnyMethods::call(&v69, ((*v68).0, *(*v68).1), None)"
        let v71 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v71)
        let v73 : string = "v72.unwrap()"
        let v74 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : pyo3_Bound<pyo3_PyAny> = method21(v74)
        let v76 : string = "v75.extract()"
        let v77 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : Result<struct (float * float), pyo3_PyErr> = method22(v77)
        let v79 : string = "v78.unwrap()"
        let struct (v80 : float, v81 : float) = Fable.Core.RustInterop.emitRustExpr () v79
        let v82 : float = method23(v80)
        let v83 : float = method3(v82)
        let v84 : float = method24(v81)
        let v85 : string = "num_complex::Complex::new(v83, v84)"
        let v86 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v86
        let v88 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v87)
        let v89 : string = "v88.unwrap()"
        let v90 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v89
        let v91 : float = method26()
        let v92 : float = method3(v91)
        let v93 : float = method4()
        let v94 : string = "num_complex::Complex::new(v92, v93)"
        let v95 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v94
        let v96 : float = method2()
        let v97 : float = method3(v96)
        let v98 : float = method4()
        let v99 : string = "num_complex::Complex::new(v97, v98)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : num_complex_Complex<float> = method83(v100)
        let v102 : num_complex_Complex<float> = method84(v27)
        let v103 : string = "num_complex::Complex::powc(v101, v102)"
        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v103
        let v105 : float = method85()
        let v106 : float = method3(v105)
        let v107 : float = method4()
        let v108 : string = "num_complex::Complex::new(v106, v107)"
        let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v108
        let v110 : float = method52()
        let v111 : float = method3(v110)
        let v112 : float = method4()
        let v113 : string = "num_complex::Complex::new(v111, v112)"
        let v114 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v113
        let v115 : string = "v27 - v114"
        let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v115
        let v117 : num_complex_Complex<float> = method83(v109)
        let v118 : num_complex_Complex<float> = method84(v116)
        let v119 : string = "num_complex::Complex::powc(v117, v118)"
        let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v119
        let v121 : string = "v104 * v120"
        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v121
        let v123 : float = method85()
        let v124 : float = method3(v123)
        let v125 : float = method4()
        let v126 : string = "num_complex::Complex::new(v124, v125)"
        let v127 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v126
        let v128 : string = "v127 * v27"
        let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v128
        let v130 : float = method2()
        let v131 : float = method3(v130)
        let v132 : float = method4()
        let v133 : string = "num_complex::Complex::new(v131, v132)"
        let v134 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v133
        let v135 : string = "v129 / v134"
        let v136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v135
        let v137 : string = "v136.sin()"
        let v138 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v137
        let v139 : string = "v122 * v138"
        let v140 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v139
        let v141 : float = method52()
        let v142 : float = method3(v141)
        let v143 : float = method4()
        let v144 : string = "num_complex::Complex::new(v142, v143)"
        let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v144
        let v146 : string = "v145 - v27"
        let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v146
        let v148 : string = "        print(f'gamma_ / s: {s}', flush=True)"
        let v149 : string = "    s = mpmath.gamma(s)"
        let v150 : (string []) = [|v28; v29; v30; v148; v32; v149; v38|]
        let v151 : (string []) = method8(v150)
        let v152 : string = method9(v151)
        let v153 : num_complex_Complex<float> = method11(v147)
        let v154 : string = "v153.re"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154
        let v156 : num_complex_Complex<float> = method12(v147)
        let v157 : string = "v156.im"
        let v158 : float = Fable.Core.RustInterop.emitRustExpr () v157
        let v159 : (float * float) = v155, v158
        let v160 : (bool * (float * float)) = false, v159
        let v161 : pyo3_Python = method13(v0)
        let v162 : string = method14(v152)
        let v163 : string = $"fable_library_rust::String_::LrcStr::as_str(&v162)"
        let v164 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v163
        let v165 : string = "pyo3::types::PyModule::from_code_bound(v161, v164, \"\", \"\")"
        let v166 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v165
        let v167 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v166)
        let v168 : string = "v167.unwrap()"
        let v169 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v168
        let v170 : string = method16()
        let v171 : string = $"fable_library_rust::String_::LrcStr::as_str(&v170)"
        let v172 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v171
        let v173 : pyo3_Bound<pyo3_types_PyModule> = method17(v169)
        let v174 : string = "v173.getattr(v172)"
        let v175 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v174
        let v176 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v175)
        let v177 : string = "v176.unwrap()"
        let v178 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v177
        let v179 : (bool * (float * float)) = method19(v160)
        let v180 : pyo3_Bound<pyo3_PyAny> = method20(v178)
        let v181 : string = "pyo3::prelude::PyAnyMethods::call(&v180, ((*v179).0, *(*v179).1), None)"
        let v182 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v181
        let v183 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v182)
        let v184 : string = "v183.unwrap()"
        let v185 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v184
        let v186 : pyo3_Bound<pyo3_PyAny> = method21(v185)
        let v187 : string = "v186.extract()"
        let v188 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v187
        let v189 : Result<struct (float * float), pyo3_PyErr> = method22(v188)
        let v190 : string = "v189.unwrap()"
        let struct (v191 : float, v192 : float) = Fable.Core.RustInterop.emitRustExpr () v190
        let v193 : float = method23(v191)
        let v194 : float = method3(v193)
        let v195 : float = method24(v192)
        let v196 : string = "num_complex::Complex::new(v194, v195)"
        let v197 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v196
        let v198 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v197
        let v199 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v198)
        let v200 : string = "v199.unwrap()"
        let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v200
        let v202 : string = "v140 * v201"
        let v203 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v202
        let v204 : num_complex_Complex<float> = method11(v27)
        let v205 : string = "v204.re"
        let v206 : float = Fable.Core.RustInterop.emitRustExpr () v205
        let v207 : float = 1.0 - v206
        let v208 : num_complex_Complex<float> = method12(v27)
        let v209 : string = "v208.im"
        let v210 : float = Fable.Core.RustInterop.emitRustExpr () v209
        let v211 : float =  -v210
        let v212 : float = method23(v207)
        let v213 : float = method3(v212)
        let v214 : float = method24(v211)
        let v215 : string = "num_complex::Complex::new(v213, v214)"
        let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v215
        let v217 : (string []) = [|v28; v29; v30; v31; v32; v33; v34; v35; v36; v37; v38|]
        let v218 : (string []) = method8(v217)
        let v219 : string = method9(v218)
        let v220 : num_complex_Complex<float> = method11(v216)
        let v221 : string = "v220.re"
        let v222 : float = Fable.Core.RustInterop.emitRustExpr () v221
        let v223 : num_complex_Complex<float> = method12(v216)
        let v224 : string = "v223.im"
        let v225 : float = Fable.Core.RustInterop.emitRustExpr () v224
        let v226 : (float * float) = v222, v225
        let v227 : (bool * (float * float)) = false, v226
        let v228 : pyo3_Python = method13(v0)
        let v229 : string = method14(v219)
        let v230 : string = $"fable_library_rust::String_::LrcStr::as_str(&v229)"
        let v231 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v230
        let v232 : string = "pyo3::types::PyModule::from_code_bound(v228, v231, \"\", \"\")"
        let v233 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v232
        let v234 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v233)
        let v235 : string = "v234.unwrap()"
        let v236 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v235
        let v237 : string = method16()
        let v238 : string = $"fable_library_rust::String_::LrcStr::as_str(&v237)"
        let v239 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v238
        let v240 : pyo3_Bound<pyo3_types_PyModule> = method17(v236)
        let v241 : string = "v240.getattr(v239)"
        let v242 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v241
        let v243 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v242)
        let v244 : string = "v243.unwrap()"
        let v245 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v244
        let v246 : (bool * (float * float)) = method19(v227)
        let v247 : pyo3_Bound<pyo3_PyAny> = method20(v245)
        let v248 : string = "pyo3::prelude::PyAnyMethods::call(&v247, ((*v246).0, *(*v246).1), None)"
        let v249 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v248
        let v250 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v249)
        let v251 : string = "v250.unwrap()"
        let v252 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v251
        let v253 : pyo3_Bound<pyo3_PyAny> = method21(v252)
        let v254 : string = "v253.extract()"
        let v255 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v254
        let v256 : Result<struct (float * float), pyo3_PyErr> = method22(v255)
        let v257 : string = "v256.unwrap()"
        let struct (v258 : float, v259 : float) = Fable.Core.RustInterop.emitRustExpr () v257
        let v260 : float = method23(v258)
        let v261 : float = method3(v260)
        let v262 : float = method24(v259)
        let v263 : string = "num_complex::Complex::new(v261, v262)"
        let v264 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v263
        let v265 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v264
        let v266 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v265)
        let v267 : string = "v266.unwrap()"
        let v268 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v267
        let v269 : float = method26()
        let v270 : float = method3(v269)
        let v271 : float = method4()
        let v272 : string = "num_complex::Complex::new(v270, v271)"
        let v273 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v272
        let v274 : string = "v203 * v268"
        let v275 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v274
        let v276 : num_complex_Complex<float> = method11(v90)
        let v277 : string = "v276.re"
        let v278 : float = Fable.Core.RustInterop.emitRustExpr () v277
        let v279 : num_complex_Complex<float> = method11(v275)
        let v280 : string = "v279.re"
        let v281 : float = Fable.Core.RustInterop.emitRustExpr () v280
        let v282 : float = v278 - v281
        let v283 : float =  -v282
        let v284 : bool = v282 >= v283
        let v285 : float =
            if v284 then
                v282
            else
                v283
        let v286 : bool = v285 < 0.0001
        let v288 : bool =
            if v286 then
                true
            else
                method27(v286)
        let v289 : string = $"__expect / actual: %A{v285} / expected: %A{0.0001}"
        let v290 : bool = v288 = false
        if v290 then
            failwith<unit> v289
        let v291 : num_complex_Complex<float> = method12(v90)
        let v292 : string = "v291.im"
        let v293 : float = Fable.Core.RustInterop.emitRustExpr () v292
        let v294 : num_complex_Complex<float> = method12(v275)
        let v295 : string = "v294.im"
        let v296 : float = Fable.Core.RustInterop.emitRustExpr () v295
        let v297 : float = v293 - v296
        let v298 : float =  -v297
        let v299 : bool = v297 >= v298
        let v300 : float =
            if v299 then
                v297
            else
                v298
        let v301 : bool = v300 < 0.0001
        let v303 : bool =
            if v301 then
                true
            else
                method27(v301)
        let v304 : string = $"__expect / actual: %A{v300} / expected: %A{0.0001}"
        let v305 : bool = v303 = false
        if v305 then
            failwith<unit> v304
        let v306 : int32 = v26 + 1
        v24.l0 <- v306
        ()
    ()
and method75 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method76(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method88 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method87 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0|]
    let v2 : (float []) = method49(v1)
    let v3 : (float []) = [|2.0; 3.0; 5.0; 7.0; 11.0; 13.0; 17.0; 19.0; 23.0; 29.0; 31.0; 37.0; 41.0; 43.0; 47.0; 53.0; 59.0; 61.0; 67.0; 71.0|]
    let v4 : (float []) = method49(v3)
    let v5 : int32 = v2.Length
    let v6 : Mut0 = {l0 = 0} : Mut0
    while method7(v5, v6) do
        let v8 : int32 = v6.l0
        let v9 : float = v2.[int v8]
        let v10 : float = method23(v9)
        let v11 : float = method3(v10)
        let v12 : float = method4()
        let v13 : string = "num_complex::Complex::new(v11, v12)"
        let v14 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : int32 = v4.Length
        let v16 : Mut2 = {l0 = 0; l1 = 1.0} : Mut2
        while method88(v15, v16) do
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
        let v27 : string = "import mpmath"
        let v28 : string = "def fn(log, s):"
        let v29 : string = "    if log:"
        let v30 : string = "        print(f'zeta_ / s: {s}', flush=True)"
        let v31 : string = "    s = complex(*s)"
        let v32 : string = "    try:"
        let v33 : string = "        s = mpmath.zeta(s)"
        let v34 : string = "    except ValueError as e:"
        let v35 : string = "        if s.real == 1:"
        let v36 : string = "            s = complex(float('inf'), 0)"
        let v37 : string = "    return (s.real, s.imag)"
        let v38 : (string []) = [|v27; v28; v29; v30; v31; v32; v33; v34; v35; v36; v37|]
        let v39 : (string []) = method8(v38)
        let v40 : string = method9(v39)
        let v41 : num_complex_Complex<float> = method11(v14)
        let v42 : string = "v41.re"
        let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : num_complex_Complex<float> = method12(v14)
        let v45 : string = "v44.im"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : (float * float) = v43, v46
        let v48 : (bool * (float * float)) = false, v47
        let v49 : pyo3_Python = method13(v0)
        let v50 : string = method14(v40)
        let v51 : string = $"fable_library_rust::String_::LrcStr::as_str(&v50)"
        let v52 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : string = "pyo3::types::PyModule::from_code_bound(v49, v52, \"\", \"\")"
        let v54 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v53
        let v55 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method15(v54)
        let v56 : string = "v55.unwrap()"
        let v57 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v56
        let v58 : string = method16()
        let v59 : string = $"fable_library_rust::String_::LrcStr::as_str(&v58)"
        let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v59
        let v61 : pyo3_Bound<pyo3_types_PyModule> = method17(v57)
        let v62 : string = "v61.getattr(v60)"
        let v63 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v63)
        let v65 : string = "v64.unwrap()"
        let v66 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v65
        let v67 : (bool * (float * float)) = method19(v48)
        let v68 : pyo3_Bound<pyo3_PyAny> = method20(v66)
        let v69 : string = "pyo3::prelude::PyAnyMethods::call(&v68, ((*v67).0, *(*v67).1), None)"
        let v70 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v69
        let v71 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method18(v70)
        let v72 : string = "v71.unwrap()"
        let v73 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : pyo3_Bound<pyo3_PyAny> = method21(v73)
        let v75 : string = "v74.extract()"
        let v76 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : Result<struct (float * float), pyo3_PyErr> = method22(v76)
        let v78 : string = "v77.unwrap()"
        let struct (v79 : float, v80 : float) = Fable.Core.RustInterop.emitRustExpr () v78
        let v81 : float = method23(v79)
        let v82 : float = method3(v81)
        let v83 : float = method24(v80)
        let v84 : string = "num_complex::Complex::new(v82, v83)"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v84
        let v86 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v85
        let v87 : Result<num_complex_Complex<float>, pyo3_PyErr> = method25(v86)
        let v88 : string = "v87.unwrap()"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : float = method26()
        let v91 : float = method3(v90)
        let v92 : float = method4()
        let v93 : string = "num_complex::Complex::new(v91, v92)"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v93
        let v95 : num_complex_Complex<float> = method11(v89)
        let v96 : string = "v95.re"
        let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96
        let v98 : float = v97 - v26
        let v99 : float =  -v98
        let v100 : bool = v98 >= v99
        let v101 : float =
            if v100 then
                v98
            else
                v99
        let v102 : bool = v101 < 0.01
        let v104 : bool =
            if v102 then
                true
            else
                method27(v102)
        let v105 : string = $"__expect / actual: %A{v101} / expected: %A{0.01}"
        let v106 : bool = v104 = false
        if v106 then
            failwith<unit> v105
        let v107 : num_complex_Complex<float> = method12(v89)
        let v108 : string = "v107.im"
        let v109 : float = Fable.Core.RustInterop.emitRustExpr () v108
        let v110 : bool = v109 < 0.01
        let v112 : bool =
            if v110 then
                true
            else
                method27(v110)
        let v113 : string = $"__expect / actual: %A{v109} / expected: %A{0.01}"
        let v114 : bool = v112 = false
        if v114 then
            failwith<unit> v113
        let v115 : int32 = v8 + 1
        v6.l0 <- v115
        ()
    ()
and method86 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method87(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method28(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method29(v9)
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
    method30()
    let v3 : string = "} #[test] fn test_trivial_zero_at_negative_even___() { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    method33()
    let v4 : string = "} #[test] fn test_non_trivial_zero___() { //"
    Fable.Core.RustInterop.emitRustExpr () v4
    method37()
    let v5 : string = "} #[test] fn test_real_part_greater_than_one___() { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    method47()
    let v6 : string = "} #[test] fn test_zeta_at_1___() { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    method50()
    let v7 : string = "} #[test] fn test_symmetry_across_real_axis___() { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    method53()
    let v8 : string = "} #[test] fn test_behavior_near_origin___() { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    method56()
    let v9 : string = "} #[test] fn test_zeta_at_minus_1() { //"
    Fable.Core.RustInterop.emitRustExpr () v9
    method60()
    let v10 : string = "} #[test] fn test_imaginary_axis() { //"
    Fable.Core.RustInterop.emitRustExpr () v10
    method62()
    let v11 : string = "} #[test] fn test_critical_strip() { //"
    Fable.Core.RustInterop.emitRustExpr () v11
    method66()
    let v12 : string = "} #[test] fn test_reflection_formula_for_specific_value() { //"
    Fable.Core.RustInterop.emitRustExpr () v12
    method75()
    let v13 : string = "} #[test] fn test_euler_product_formula() { //"
    Fable.Core.RustInterop.emitRustExpr () v13
    method86()
and closure1 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
