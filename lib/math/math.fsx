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
let rec method1 () : float =
    2.0
and method2 () : float =
    0.0
and method3 () : float =
    -1.0
and method4 (v0 : (struct (num_complex_Complex<float> * float) [])) : (struct (num_complex_Complex<float> * float) []) =
    v0
and method5 (v0 : int32, v1 : Mut0) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method6 (v0 : (string [])) : (string []) =
    v0
and method7 (v0 : int32, v1 : Mut1) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method8 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method9 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method10 (v0 : pyo3_Python) : pyo3_Python =
    v0
and method11 (v0 : string) : string =
    v0
and method12 (v0 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> =
    v0
and method13 () : string =
    let v0 : string = "fn"
    v0
and method14 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and method15 (v0 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> =
    v0
and method16 (v0 : ((float * float) * unit)) : ((float * float) * unit) =
    v0
and method17 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method18 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method19 (v0 : Result<struct (float * float), pyo3_PyErr>) : Result<struct (float * float), pyo3_PyErr> =
    v0
and method20 (v0 : float) : float =
    v0
and method21 (v0 : float) : float =
    v0
and method22 (v0 : Result<num_complex_Complex<float>, pyo3_PyErr>) : Result<num_complex_Complex<float>, pyo3_PyErr> =
    v0
and method23 (v0 : bool) : bool =
    v0
and method24 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method25 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method0 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method1()
    let v5 : float = method2()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : float = method3()
    let v9 : float = method2()
    let v10 : string = "num_complex::Complex::new(v8, v9)"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (struct (num_complex_Complex<float> * float) []) = [|struct (v7, 1.6449340668482264); struct (v11, -0.08333333333333333)|]
    let v13 : (struct (num_complex_Complex<float> * float) []) = method4(v12)
    let v14 : int32 = v13.Length
    let v15 : Mut0 = {l0 = 0} : Mut0
    while method5(v14, v15) do
        let v17 : int32 = v15.l0
        let struct (v18 : num_complex_Complex<float>, v19 : float) = v13.[int v17]
        let v20 : string = "import mpmath"
        let v21 : string = "def fn(s, _):"
        let v22 : string = "    s = complex(*s)"
        let v23 : string = "    try:"
        let v24 : string = "        s = mpmath.zeta(s)"
        let v25 : string = "    except ValueError as e:"
        let v26 : string = "        if s.real == 1:"
        let v27 : string = "            s = complex(float('inf'), 0)"
        let v28 : string = "    return (s.real, s.imag)"
        let v29 : (string []) = [|v20; v21; v22; v23; v24; v25; v26; v27; v28|]
        let v30 : (string []) = method6(v29)
        let v31 : int32 = v30.Length
        let v32 : string = ""
        let v33 : Mut1 = {l0 = 0; l1 = v32} : Mut1
        while method7(v31, v33) do
            let v35 : int32 = v33.l0
            let v36 : string = v33.l1
            let v37 : string = v30.[int v35]
            let v38 : string = "\n"
            let v39 : string = v36 + v37 + v38 + ""
            let v40 : int32 = v35 + 1
            v33.l0 <- v40
            v33.l1 <- v39
            ()
        let v41 : string = v33.l1
        let v42 : num_complex_Complex<float> = method8(v18)
        let v43 : string = "v42.re"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : num_complex_Complex<float> = method9(v18)
        let v46 : string = "v45.im"
        let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46
        let v48 : (float * float) = v44, v47
        let v49 : ((float * float) * unit) = v48, ()
        let v50 : pyo3_Python = method10(v3)
        let v51 : string = method11(v41)
        let v52 : string = $"fable_library_rust::String_::LrcStr::as_str(&v51)"
        let v53 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : string = "pyo3::types::PyModule::from_code_bound(v50, v53, \"\", \"\")"
        let v55 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v55)
        let v57 : string = "v56.unwrap()"
        let v58 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : string = method13()
        let v60 : string = $"fable_library_rust::String_::LrcStr::as_str(&v59)"
        let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : pyo3_Bound<pyo3_types_PyModule> = method14(v58)
        let v63 : string = "v62.getattr(v61)"
        let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v64)
        let v66 : string = "v65.unwrap()"
        let v67 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : ((float * float) * unit) = method16(v49)
        let v69 : pyo3_Bound<pyo3_PyAny> = method17(v67)
        let v70 : string = "pyo3::prelude::PyAnyMethods::call(&v69, (*(*v68).0, ()), None)"
        let v71 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v71)
        let v73 : string = "v72.unwrap()"
        let v74 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : pyo3_Bound<pyo3_PyAny> = method18(v74)
        let v76 : string = "v75.extract()"
        let v77 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : Result<struct (float * float), pyo3_PyErr> = method19(v77)
        let v79 : string = "v78.unwrap()"
        let struct (v80 : float, v81 : float) = Fable.Core.RustInterop.emitRustExpr () v79
        let v82 : float = method20(v80)
        let v83 : float = method21(v81)
        let v84 : string = "num_complex::Complex::new(v82, v83)"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v84
        let v86 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v85
        let v87 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v86)
        let v88 : string = "v87.unwrap()"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : num_complex_Complex<float> = method9(v89)
        let v91 : string = "v90.im"
        let v92 : float = Fable.Core.RustInterop.emitRustExpr () v91
        let v93 : bool = v92 = 0.0
        let v95 : bool =
            if v93 then
                true
            else
                method23(v93)
        let v96 : string = $"__expect / actual: %A{v92} / expected: %A{0.0}"
        let v97 : bool = v95 = false
        if v97 then
            failwith<unit> v96
        let v98 : num_complex_Complex<float> = method8(v89)
        let v99 : string = "v98.re"
        let v100 : float = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : float = v100 - v19
        let v102 : float =  -v101
        let v103 : bool = v101 >= v102
        let v104 : float =
            if v103 then
                v101
            else
                v102
        let v105 : bool = v104 < 0.0001
        let v107 : bool =
            if v105 then
                true
            else
                method23(v105)
        let v108 : string = $"__expect / actual: %A{v104} / expected: %A{0.0001}"
        let v109 : bool = v107 = false
        if v109 then
            failwith<unit> v108
        let v110 : int32 = v17 + 1
        v15.l0 <- v110
        ()
    let v111 : Result<unit, pyo3_PyErr> = Ok ()
    let v112 : Result<unit, pyo3_PyErr> = method24(v111)
    let v113 : string = "v112 }}})"
    Fable.Core.RustInterop.emitRustExpr () v113
    let v114 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v114
    let v115 : string = "__result"
    let v116 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v115
    let v117 : Result<unit, pyo3_PyErr> = method25(v116)
    let v118 : string = "v117.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v118
    ()
and method27 () : float =
    -2.0
and method26 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method1()
    let v5 : float = method27()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "import mpmath"
    let v9 : string = "def fn(s, _):"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method6(v17)
    let v19 : int32 = v18.Length
    let v20 : string = ""
    let v21 : Mut1 = {l0 = 0; l1 = v20} : Mut1
    while method7(v19, v21) do
        let v23 : int32 = v21.l0
        let v24 : string = v21.l1
        let v25 : string = v18.[int v23]
        let v26 : string = "\n"
        let v27 : string = v24 + v25 + v26 + ""
        let v28 : int32 = v23 + 1
        v21.l0 <- v28
        v21.l1 <- v27
        ()
    let v29 : string = v21.l1
    let v30 : num_complex_Complex<float> = method8(v7)
    let v31 : string = "v30.re"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : num_complex_Complex<float> = method9(v7)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (float * float) = v32, v35
    let v37 : ((float * float) * unit) = v36, ()
    let v38 : pyo3_Python = method10(v3)
    let v39 : string = method11(v29)
    let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
    let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v43)
    let v45 : string = "v44.unwrap()"
    let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = method13()
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : pyo3_Bound<pyo3_types_PyModule> = method14(v46)
    let v51 : string = "v50.getattr(v49)"
    let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v52)
    let v54 : string = "v53.unwrap()"
    let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : ((float * float) * unit) = method16(v37)
    let v57 : pyo3_Bound<pyo3_PyAny> = method17(v55)
    let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None)"
    let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
    let v61 : string = "v60.unwrap()"
    let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
    let v63 : pyo3_Bound<pyo3_PyAny> = method18(v62)
    let v64 : string = "v63.extract()"
    let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : Result<struct (float * float), pyo3_PyErr> = method19(v65)
    let v67 : string = "v66.unwrap()"
    let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
    let v70 : float = method20(v68)
    let v71 : float = method21(v69)
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
    let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v74)
    let v76 : string = "v75.unwrap()"
    let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : num_complex_Complex<float> = method8(v77)
    let v79 : string = "v78.re"
    let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
    let v81 : float = v80 - 0.8673
    let v82 : float =  -v81
    let v83 : bool = v81 >= v82
    let v84 : float =
        if v83 then
            v81
        else
            v82
    let v85 : bool = v84 < 0.001
    let v87 : bool =
        if v85 then
            true
        else
            method23(v85)
    let v88 : string = $"__expect / actual: %A{v84} / expected: %A{0.001}"
    let v89 : bool = v87 = false
    if v89 then
        failwith<unit> v88
    let v90 : num_complex_Complex<float> = method9(v77)
    let v91 : string = "v90.im"
    let v92 : float = Fable.Core.RustInterop.emitRustExpr () v91
    let v93 : float = v92 - 0.275
    let v94 : float =  -v93
    let v95 : bool = v93 >= v94
    let v96 : float =
        if v95 then
            v93
        else
            v94
    let v97 : bool = v96 < 0.001
    let v99 : bool =
        if v97 then
            true
        else
            method23(v97)
    let v100 : string = $"__expect / actual: %A{v96} / expected: %A{0.001}"
    let v101 : bool = v99 = false
    if v101 then
        failwith<unit> v100
    let v102 : Result<unit, pyo3_PyErr> = Ok ()
    let v103 : Result<unit, pyo3_PyErr> = method24(v102)
    let v104 : string = "v103 }}}}})"
    Fable.Core.RustInterop.emitRustExpr () v104
    let v105 : string = " {{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v105
    let v106 : string = "__result"
    let v107 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v106
    let v108 : Result<unit, pyo3_PyErr> = method25(v107)
    let v109 : string = "v108.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v109
    ()
and method29 () : UH0 =
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
and method30 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : float = method20(v2)
        let v5 : float = method2()
        let v6 : string = "num_complex::Complex::new(v4, v5)"
        let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
        let v8 : string = "import mpmath"
        let v9 : string = "def fn(s, _):"
        let v10 : string = "    s = complex(*s)"
        let v11 : string = "    try:"
        let v12 : string = "        s = mpmath.zeta(s)"
        let v13 : string = "    except ValueError as e:"
        let v14 : string = "        if s.real == 1:"
        let v15 : string = "            s = complex(float('inf'), 0)"
        let v16 : string = "    return (s.real, s.imag)"
        let v17 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
        let v18 : (string []) = method6(v17)
        let v19 : int32 = v18.Length
        let v20 : string = ""
        let v21 : Mut1 = {l0 = 0; l1 = v20} : Mut1
        while method7(v19, v21) do
            let v23 : int32 = v21.l0
            let v24 : string = v21.l1
            let v25 : string = v18.[int v23]
            let v26 : string = "\n"
            let v27 : string = v24 + v25 + v26 + ""
            let v28 : int32 = v23 + 1
            v21.l0 <- v28
            v21.l1 <- v27
            ()
        let v29 : string = v21.l1
        let v30 : num_complex_Complex<float> = method8(v7)
        let v31 : string = "v30.re"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : num_complex_Complex<float> = method9(v7)
        let v34 : string = "v33.im"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
        let v36 : (float * float) = v32, v35
        let v37 : ((float * float) * unit) = v36, ()
        let v38 : pyo3_Python = method10(v0)
        let v39 : string = method11(v29)
        let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
        let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
        let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v43)
        let v45 : string = "v44.unwrap()"
        let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
        let v47 : string = method13()
        let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
        let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : pyo3_Bound<pyo3_types_PyModule> = method14(v46)
        let v51 : string = "v50.getattr(v49)"
        let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v52)
        let v54 : string = "v53.unwrap()"
        let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : ((float * float) * unit) = method16(v37)
        let v57 : pyo3_Bound<pyo3_PyAny> = method17(v55)
        let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None)"
        let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
        let v61 : string = "v60.unwrap()"
        let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : pyo3_Bound<pyo3_PyAny> = method18(v62)
        let v64 : string = "v63.extract()"
        let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : Result<struct (float * float), pyo3_PyErr> = method19(v65)
        let v67 : string = "v66.unwrap()"
        let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
        let v70 : float = method20(v68)
        let v71 : float = method21(v69)
        let v72 : string = "num_complex::Complex::new(v70, v71)"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
        let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v74)
        let v76 : string = "v75.unwrap()"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
        let v78 : num_complex_Complex<float> = method8(v77)
        let v79 : string = "v78.re"
        let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : bool = v80 = 0.0
        let v83 : bool =
            if v81 then
                true
            else
                method23(v81)
        let v84 : string = $"__expect / actual: %A{v80} / expected: %A{0.0}"
        let v85 : bool = v83 = false
        if v85 then
            failwith<unit> v84
        let v86 : num_complex_Complex<float> = method9(v77)
        let v87 : string = "v86.im"
        let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
        let v89 : bool = v88 = 0.0
        let v91 : bool =
            if v89 then
                true
            else
                method23(v89)
        let v92 : string = $"__expect / actual: %A{v88} / expected: %A{0.0}"
        let v93 : bool = v91 = false
        if v93 then
            failwith<unit> v92
        method30(v0, v3)
    | UH0_1 -> (* Nil *)
        ()
and method28 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : UH0 = method29()
    method30(v3, v4)
    let v5 : Result<unit, pyo3_PyErr> = Ok ()
    let v6 : Result<unit, pyo3_PyErr> = method24(v5)
    let v7 : string = "v6 }})"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = " { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    let v9 : string = "__result"
    let v10 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : Result<unit, pyo3_PyErr> = method25(v10)
    let v12 : string = "v11.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v12
    ()
and method32 () : float =
    0.5
and method33 () : float =
    14.134725
and method34 () : float =
    21.02204
and method35 () : float =
    25.010857
and method36 () : float =
    30.424876
and method37 () : float =
    32.935062
and method38 () : float =
    37.586178
and method39 (v0 : (num_complex_Complex<float> [])) : (num_complex_Complex<float> []) =
    v0
and method31 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method32()
    let v5 : float = method33()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : float = method32()
    let v9 : float = method34()
    let v10 : string = "num_complex::Complex::new(v8, v9)"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : float = method32()
    let v13 : float = method35()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method32()
    let v17 : float = method36()
    let v18 : string = "num_complex::Complex::new(v16, v17)"
    let v19 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : float = method32()
    let v21 : float = method37()
    let v22 : string = "num_complex::Complex::new(v20, v21)"
    let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : float = method32()
    let v25 : float = method38()
    let v26 : string = "num_complex::Complex::new(v24, v25)"
    let v27 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v26
    let v28 : (num_complex_Complex<float> []) = [|v7; v11; v15; v19; v23; v27|]
    let v29 : (num_complex_Complex<float> []) = method39(v28)
    let v30 : int32 = v29.Length
    let v31 : Mut0 = {l0 = 0} : Mut0
    while method5(v30, v31) do
        let v33 : int32 = v31.l0
        let v34 : num_complex_Complex<float> = v29.[int v33]
        let v35 : string = "import mpmath"
        let v36 : string = "def fn(s, _):"
        let v37 : string = "    s = complex(*s)"
        let v38 : string = "    try:"
        let v39 : string = "        s = mpmath.zeta(s)"
        let v40 : string = "    except ValueError as e:"
        let v41 : string = "        if s.real == 1:"
        let v42 : string = "            s = complex(float('inf'), 0)"
        let v43 : string = "    return (s.real, s.imag)"
        let v44 : (string []) = [|v35; v36; v37; v38; v39; v40; v41; v42; v43|]
        let v45 : (string []) = method6(v44)
        let v46 : int32 = v45.Length
        let v47 : string = ""
        let v48 : Mut1 = {l0 = 0; l1 = v47} : Mut1
        while method7(v46, v48) do
            let v50 : int32 = v48.l0
            let v51 : string = v48.l1
            let v52 : string = v45.[int v50]
            let v53 : string = "\n"
            let v54 : string = v51 + v52 + v53 + ""
            let v55 : int32 = v50 + 1
            v48.l0 <- v55
            v48.l1 <- v54
            ()
        let v56 : string = v48.l1
        let v57 : num_complex_Complex<float> = method8(v34)
        let v58 : string = "v57.re"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : num_complex_Complex<float> = method9(v34)
        let v61 : string = "v60.im"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : (float * float) = v59, v62
        let v64 : ((float * float) * unit) = v63, ()
        let v65 : pyo3_Python = method10(v3)
        let v66 : string = method11(v56)
        let v67 : string = $"fable_library_rust::String_::LrcStr::as_str(&v66)"
        let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : string = "pyo3::types::PyModule::from_code_bound(v65, v68, \"\", \"\")"
        let v70 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v69
        let v71 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v70)
        let v72 : string = "v71.unwrap()"
        let v73 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : string = method13()
        let v75 : string = $"fable_library_rust::String_::LrcStr::as_str(&v74)"
        let v76 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : pyo3_Bound<pyo3_types_PyModule> = method14(v73)
        let v78 : string = "v77.getattr(v76)"
        let v79 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v79)
        let v81 : string = "v80.unwrap()"
        let v82 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : ((float * float) * unit) = method16(v64)
        let v84 : pyo3_Bound<pyo3_PyAny> = method17(v82)
        let v85 : string = "pyo3::prelude::PyAnyMethods::call(&v84, (*(*v83).0, ()), None)"
        let v86 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v86)
        let v88 : string = "v87.unwrap()"
        let v89 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : pyo3_Bound<pyo3_PyAny> = method18(v89)
        let v91 : string = "v90.extract()"
        let v92 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v91
        let v93 : Result<struct (float * float), pyo3_PyErr> = method19(v92)
        let v94 : string = "v93.unwrap()"
        let struct (v95 : float, v96 : float) = Fable.Core.RustInterop.emitRustExpr () v94
        let v97 : float = method20(v95)
        let v98 : float = method21(v96)
        let v99 : string = "num_complex::Complex::new(v97, v98)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v100
        let v102 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v101)
        let v103 : string = "v102.unwrap()"
        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v103
        let v105 : num_complex_Complex<float> = method8(v104)
        let v106 : string = "v105.re"
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
                method23(v111)
        let v114 : string = $"__expect / actual: %A{v110} / expected: %A{0.0001}"
        let v115 : bool = v113 = false
        if v115 then
            failwith<unit> v114
        let v116 : num_complex_Complex<float> = method9(v104)
        let v117 : string = "v116.im"
        let v118 : float = Fable.Core.RustInterop.emitRustExpr () v117
        let v119 : float =  -v118
        let v120 : bool = v118 >= v119
        let v121 : float =
            if v120 then
                v118
            else
                v119
        let v122 : bool = v121 < 0.0001
        let v124 : bool =
            if v122 then
                true
            else
                method23(v122)
        let v125 : string = $"__expect / actual: %A{v121} / expected: %A{0.0001}"
        let v126 : bool = v124 = false
        if v126 then
            failwith<unit> v125
        let v127 : int32 = v33 + 1
        v31.l0 <- v127
        ()
    let v128 : Result<unit, pyo3_PyErr> = Ok ()
    let v129 : Result<unit, pyo3_PyErr> = method24(v128)
    let v130 : string = "v129 }}})"
    Fable.Core.RustInterop.emitRustExpr () v130
    let v131 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v131
    let v132 : string = "__result"
    let v133 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v132
    let v134 : Result<unit, pyo3_PyErr> = method25(v133)
    let v135 : string = "v134.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v135
    ()
and method41 (v0 : (float [])) : (float []) =
    v0
and method40 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : (float []) = [|2.0; 3.0; 4.0; 5.0; 10.0; 20.0; 50.0|]
    let v5 : (float []) = method41(v4)
    let v6 : int32 = v5.Length
    let v7 : Mut0 = {l0 = 0} : Mut0
    while method5(v6, v7) do
        let v9 : int32 = v7.l0
        let v10 : float = v5.[int v9]
        let v11 : float = method20(v10)
        let v12 : float = method2()
        let v13 : string = "num_complex::Complex::new(v11, v12)"
        let v14 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : string = "import mpmath"
        let v16 : string = "def fn(s, _):"
        let v17 : string = "    s = complex(*s)"
        let v18 : string = "    try:"
        let v19 : string = "        s = mpmath.zeta(s)"
        let v20 : string = "    except ValueError as e:"
        let v21 : string = "        if s.real == 1:"
        let v22 : string = "            s = complex(float('inf'), 0)"
        let v23 : string = "    return (s.real, s.imag)"
        let v24 : (string []) = [|v15; v16; v17; v18; v19; v20; v21; v22; v23|]
        let v25 : (string []) = method6(v24)
        let v26 : int32 = v25.Length
        let v27 : string = ""
        let v28 : Mut1 = {l0 = 0; l1 = v27} : Mut1
        while method7(v26, v28) do
            let v30 : int32 = v28.l0
            let v31 : string = v28.l1
            let v32 : string = v25.[int v30]
            let v33 : string = "\n"
            let v34 : string = v31 + v32 + v33 + ""
            let v35 : int32 = v30 + 1
            v28.l0 <- v35
            v28.l1 <- v34
            ()
        let v36 : string = v28.l1
        let v37 : num_complex_Complex<float> = method8(v14)
        let v38 : string = "v37.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : num_complex_Complex<float> = method9(v14)
        let v41 : string = "v40.im"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : (float * float) = v39, v42
        let v44 : ((float * float) * unit) = v43, ()
        let v45 : pyo3_Python = method10(v3)
        let v46 : string = method11(v36)
        let v47 : string = $"fable_library_rust::String_::LrcStr::as_str(&v46)"
        let v48 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : string = "pyo3::types::PyModule::from_code_bound(v45, v48, \"\", \"\")"
        let v50 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v50)
        let v52 : string = "v51.unwrap()"
        let v53 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : string = method13()
        let v55 : string = $"fable_library_rust::String_::LrcStr::as_str(&v54)"
        let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : pyo3_Bound<pyo3_types_PyModule> = method14(v53)
        let v58 : string = "v57.getattr(v56)"
        let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
        let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
        let v61 : string = "v60.unwrap()"
        let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : ((float * float) * unit) = method16(v44)
        let v64 : pyo3_Bound<pyo3_PyAny> = method17(v62)
        let v65 : string = "pyo3::prelude::PyAnyMethods::call(&v64, (*(*v63).0, ()), None)"
        let v66 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v65
        let v67 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v66)
        let v68 : string = "v67.unwrap()"
        let v69 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : pyo3_Bound<pyo3_PyAny> = method18(v69)
        let v71 : string = "v70.extract()"
        let v72 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v71
        let v73 : Result<struct (float * float), pyo3_PyErr> = method19(v72)
        let v74 : string = "v73.unwrap()"
        let struct (v75 : float, v76 : float) = Fable.Core.RustInterop.emitRustExpr () v74
        let v77 : float = method20(v75)
        let v78 : float = method21(v76)
        let v79 : string = "num_complex::Complex::new(v77, v78)"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v80
        let v82 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v81)
        let v83 : string = "v82.unwrap()"
        let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : num_complex_Complex<float> = method8(v84)
        let v86 : string = "v85.re"
        let v87 : float = Fable.Core.RustInterop.emitRustExpr () v86
        let v88 : bool = v87 > 0.0
        let v90 : bool =
            if v88 then
                true
            else
                method23(v88)
        let v91 : string = $"__expect / actual: %A{v87} / expected: %A{0.0}"
        let v92 : bool = v90 = false
        if v92 then
            failwith<unit> v91
        let v93 : num_complex_Complex<float> = method9(v84)
        let v94 : string = "v93.im"
        let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94
        let v96 : bool = v95 = 0.0
        let v98 : bool =
            if v96 then
                true
            else
                method23(v96)
        let v99 : string = $"__expect / actual: %A{v95} / expected: %A{0.0}"
        let v100 : bool = v98 = false
        if v100 then
            failwith<unit> v99
        let v101 : int32 = v9 + 1
        v7.l0 <- v101
        ()
    let v102 : Result<unit, pyo3_PyErr> = Ok ()
    let v103 : Result<unit, pyo3_PyErr> = method24(v102)
    let v104 : string = "v103 }}})"
    Fable.Core.RustInterop.emitRustExpr () v104
    let v105 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v105
    let v106 : string = "__result"
    let v107 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v106
    let v108 : Result<unit, pyo3_PyErr> = method25(v107)
    let v109 : string = "v108.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v109
    ()
and method43 () : float =
    1.0
and method42 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method43()
    let v5 : float = method2()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "import mpmath"
    let v9 : string = "def fn(s, _):"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method6(v17)
    let v19 : int32 = v18.Length
    let v20 : string = ""
    let v21 : Mut1 = {l0 = 0; l1 = v20} : Mut1
    while method7(v19, v21) do
        let v23 : int32 = v21.l0
        let v24 : string = v21.l1
        let v25 : string = v18.[int v23]
        let v26 : string = "\n"
        let v27 : string = v24 + v25 + v26 + ""
        let v28 : int32 = v23 + 1
        v21.l0 <- v28
        v21.l1 <- v27
        ()
    let v29 : string = v21.l1
    let v30 : num_complex_Complex<float> = method8(v7)
    let v31 : string = "v30.re"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : num_complex_Complex<float> = method9(v7)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (float * float) = v32, v35
    let v37 : ((float * float) * unit) = v36, ()
    let v38 : pyo3_Python = method10(v3)
    let v39 : string = method11(v29)
    let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
    let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v43)
    let v45 : string = "v44.unwrap()"
    let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = method13()
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : pyo3_Bound<pyo3_types_PyModule> = method14(v46)
    let v51 : string = "v50.getattr(v49)"
    let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v52)
    let v54 : string = "v53.unwrap()"
    let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : ((float * float) * unit) = method16(v37)
    let v57 : pyo3_Bound<pyo3_PyAny> = method17(v55)
    let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None)"
    let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
    let v61 : string = "v60.unwrap()"
    let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
    let v63 : pyo3_Bound<pyo3_PyAny> = method18(v62)
    let v64 : string = "v63.extract()"
    let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : Result<struct (float * float), pyo3_PyErr> = method19(v65)
    let v67 : string = "v66.unwrap()"
    let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
    let v70 : float = method20(v68)
    let v71 : float = method21(v69)
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
    let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v74)
    let v76 : string = "v75.unwrap()"
    let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : num_complex_Complex<float> = method8(v77)
    let v79 : string = "v78.re"
    let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
    let v81 : bool = v80 = infinity
    let v83 : bool =
        if v81 then
            true
        else
            method23(v81)
    let v84 : string = $"__expect / actual: %A{v80} / expected: %A{infinity}"
    let v85 : bool = v83 = false
    if v85 then
        failwith<unit> v84
    let v86 : num_complex_Complex<float> = method9(v77)
    let v87 : string = "v86.im"
    let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : bool = v88 = 0.0
    let v91 : bool =
        if v89 then
            true
        else
            method23(v89)
    let v92 : string = $"__expect / actual: %A{v88} / expected: %A{0.0}"
    let v93 : bool = v91 = false
    if v93 then
        failwith<unit> v92
    let v94 : Result<unit, pyo3_PyErr> = Ok ()
    let v95 : Result<unit, pyo3_PyErr> = method24(v94)
    let v96 : string = "v95 }}}}})"
    Fable.Core.RustInterop.emitRustExpr () v96
    let v97 : string = " {{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v97
    let v98 : string = "__result"
    let v99 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v98
    let v100 : Result<unit, pyo3_PyErr> = method25(v99)
    let v101 : string = "v100.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v101
    ()
and method45 () : float =
    10.0
and method44 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method1()
    let v5 : float = method45()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "import mpmath"
    let v9 : string = "def fn(s, _):"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method6(v17)
    let v19 : int32 = v18.Length
    let v20 : string = ""
    let v21 : Mut1 = {l0 = 0; l1 = v20} : Mut1
    while method7(v19, v21) do
        let v23 : int32 = v21.l0
        let v24 : string = v21.l1
        let v25 : string = v18.[int v23]
        let v26 : string = "\n"
        let v27 : string = v24 + v25 + v26 + ""
        let v28 : int32 = v23 + 1
        v21.l0 <- v28
        v21.l1 <- v27
        ()
    let v29 : string = v21.l1
    let v30 : num_complex_Complex<float> = method8(v7)
    let v31 : string = "v30.re"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : num_complex_Complex<float> = method9(v7)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (float * float) = v32, v35
    let v37 : ((float * float) * unit) = v36, ()
    let v38 : pyo3_Python = method10(v3)
    let v39 : string = method11(v29)
    let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
    let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v43)
    let v45 : string = "v44.unwrap()"
    let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = method13()
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : pyo3_Bound<pyo3_types_PyModule> = method14(v46)
    let v51 : string = "v50.getattr(v49)"
    let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v52)
    let v54 : string = "v53.unwrap()"
    let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : ((float * float) * unit) = method16(v37)
    let v57 : pyo3_Bound<pyo3_PyAny> = method17(v55)
    let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None)"
    let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
    let v61 : string = "v60.unwrap()"
    let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
    let v63 : pyo3_Bound<pyo3_PyAny> = method18(v62)
    let v64 : string = "v63.extract()"
    let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : Result<struct (float * float), pyo3_PyErr> = method19(v65)
    let v67 : string = "v66.unwrap()"
    let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
    let v70 : float = method20(v68)
    let v71 : float = method21(v69)
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
    let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v74)
    let v76 : string = "v75.unwrap()"
    let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : num_complex_Complex<float> = method8(v7)
    let v79 : string = "v78.re"
    let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
    let v81 : num_complex_Complex<float> = method9(v7)
    let v82 : string = "v81.im"
    let v83 : float = Fable.Core.RustInterop.emitRustExpr () v82
    let v84 : float =  -v83
    let v85 : float = method20(v80)
    let v86 : float = method21(v84)
    let v87 : string = "num_complex::Complex::new(v85, v86)"
    let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v90 : (string []) = method6(v89)
    let v91 : int32 = v90.Length
    let v92 : Mut1 = {l0 = 0; l1 = v20} : Mut1
    while method7(v91, v92) do
        let v94 : int32 = v92.l0
        let v95 : string = v92.l1
        let v96 : string = v90.[int v94]
        let v97 : string = "\n"
        let v98 : string = v95 + v96 + v97 + ""
        let v99 : int32 = v94 + 1
        v92.l0 <- v99
        v92.l1 <- v98
        ()
    let v100 : string = v92.l1
    let v101 : num_complex_Complex<float> = method8(v88)
    let v102 : string = "v101.re"
    let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102
    let v104 : num_complex_Complex<float> = method9(v88)
    let v105 : string = "v104.im"
    let v106 : float = Fable.Core.RustInterop.emitRustExpr () v105
    let v107 : (float * float) = v103, v106
    let v108 : ((float * float) * unit) = v107, ()
    let v109 : pyo3_Python = method10(v3)
    let v110 : string = method11(v100)
    let v111 : string = $"fable_library_rust::String_::LrcStr::as_str(&v110)"
    let v112 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v111
    let v113 : string = "pyo3::types::PyModule::from_code_bound(v109, v112, \"\", \"\")"
    let v114 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v113
    let v115 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v114)
    let v116 : string = "v115.unwrap()"
    let v117 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v116
    let v118 : string = method13()
    let v119 : string = $"fable_library_rust::String_::LrcStr::as_str(&v118)"
    let v120 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v119
    let v121 : pyo3_Bound<pyo3_types_PyModule> = method14(v117)
    let v122 : string = "v121.getattr(v120)"
    let v123 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v122
    let v124 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v123)
    let v125 : string = "v124.unwrap()"
    let v126 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v125
    let v127 : ((float * float) * unit) = method16(v108)
    let v128 : pyo3_Bound<pyo3_PyAny> = method17(v126)
    let v129 : string = "pyo3::prelude::PyAnyMethods::call(&v128, (*(*v127).0, ()), None)"
    let v130 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v129
    let v131 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v130)
    let v132 : string = "v131.unwrap()"
    let v133 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v132
    let v134 : pyo3_Bound<pyo3_PyAny> = method18(v133)
    let v135 : string = "v134.extract()"
    let v136 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v135
    let v137 : Result<struct (float * float), pyo3_PyErr> = method19(v136)
    let v138 : string = "v137.unwrap()"
    let struct (v139 : float, v140 : float) = Fable.Core.RustInterop.emitRustExpr () v138
    let v141 : float = method20(v139)
    let v142 : float = method21(v140)
    let v143 : string = "num_complex::Complex::new(v141, v142)"
    let v144 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v143
    let v145 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v144
    let v146 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v145)
    let v147 : string = "v146.unwrap()"
    let v148 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v147
    let v149 : string = "v148.conj()"
    let v150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v149
    let v151 : num_complex_Complex<float> = method8(v77)
    let v152 : string = "v151.re"
    let v153 : float = Fable.Core.RustInterop.emitRustExpr () v152
    let v154 : num_complex_Complex<float> = method8(v150)
    let v155 : string = "v154.re"
    let v156 : float = Fable.Core.RustInterop.emitRustExpr () v155
    let v157 : bool = v153 = v156
    let v159 : bool =
        if v157 then
            true
        else
            method23(v157)
    let v160 : string = $"__expect / actual: %A{v153} / expected: %A{v156}"
    let v161 : bool = v159 = false
    if v161 then
        failwith<unit> v160
    let v162 : num_complex_Complex<float> = method9(v77)
    let v163 : string = "v162.im"
    let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163
    let v165 : num_complex_Complex<float> = method9(v150)
    let v166 : string = "v165.im"
    let v167 : float = Fable.Core.RustInterop.emitRustExpr () v166
    let v168 : bool = v164 = v167
    let v170 : bool =
        if v168 then
            true
        else
            method23(v168)
    let v171 : string = $"__expect / actual: %A{v164} / expected: %A{v167}"
    let v172 : bool = v170 = false
    if v172 then
        failwith<unit> v171
    let v173 : Result<unit, pyo3_PyErr> = Ok ()
    let v174 : Result<unit, pyo3_PyErr> = method24(v173)
    let v175 : string = "v174 }}}}}})"
    Fable.Core.RustInterop.emitRustExpr () v175
    let v176 : string = " {{{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v176
    let v177 : string = "__result"
    let v178 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v177
    let v179 : Result<unit, pyo3_PyErr> = method25(v178)
    let v180 : string = "v179.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v180
    ()
and method47 () : float =
    0.01
and method48 () : float =
    0.01
and method46 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method47()
    let v5 : float = method48()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "import mpmath"
    let v9 : string = "def fn(s, _):"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method6(v17)
    let v19 : int32 = v18.Length
    let v20 : string = ""
    let v21 : Mut1 = {l0 = 0; l1 = v20} : Mut1
    while method7(v19, v21) do
        let v23 : int32 = v21.l0
        let v24 : string = v21.l1
        let v25 : string = v18.[int v23]
        let v26 : string = "\n"
        let v27 : string = v24 + v25 + v26 + ""
        let v28 : int32 = v23 + 1
        v21.l0 <- v28
        v21.l1 <- v27
        ()
    let v29 : string = v21.l1
    let v30 : num_complex_Complex<float> = method8(v7)
    let v31 : string = "v30.re"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : num_complex_Complex<float> = method9(v7)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (float * float) = v32, v35
    let v37 : ((float * float) * unit) = v36, ()
    let v38 : pyo3_Python = method10(v3)
    let v39 : string = method11(v29)
    let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
    let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v43)
    let v45 : string = "v44.unwrap()"
    let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = method13()
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : pyo3_Bound<pyo3_types_PyModule> = method14(v46)
    let v51 : string = "v50.getattr(v49)"
    let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v52)
    let v54 : string = "v53.unwrap()"
    let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : ((float * float) * unit) = method16(v37)
    let v57 : pyo3_Bound<pyo3_PyAny> = method17(v55)
    let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None)"
    let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
    let v61 : string = "v60.unwrap()"
    let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
    let v63 : pyo3_Bound<pyo3_PyAny> = method18(v62)
    let v64 : string = "v63.extract()"
    let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : Result<struct (float * float), pyo3_PyErr> = method19(v65)
    let v67 : string = "v66.unwrap()"
    let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
    let v70 : float = method20(v68)
    let v71 : float = method21(v69)
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
    let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v74)
    let v76 : string = "v75.unwrap()"
    let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : num_complex_Complex<float> = method8(v77)
    let v79 : string = "v78.re"
    let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
    let v81 : bool = v80 < infinity
    let v83 : bool =
        if v81 then
            true
        else
            method23(v81)
    let v84 : string = $"__expect / actual: %A{v80} / expected: %A{infinity}"
    let v85 : bool = v83 = false
    if v85 then
        failwith<unit> v84
    let v86 : num_complex_Complex<float> = method9(v77)
    let v87 : string = "v86.im"
    let v88 : float = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : bool = v88 < infinity
    let v91 : bool =
        if v89 then
            true
        else
            method23(v89)
    let v92 : string = $"__expect / actual: %A{v88} / expected: %A{infinity}"
    let v93 : bool = v91 = false
    if v93 then
        failwith<unit> v92
    let v94 : Result<unit, pyo3_PyErr> = Ok ()
    let v95 : Result<unit, pyo3_PyErr> = method24(v94)
    let v96 : string = "v95 }}}}})"
    Fable.Core.RustInterop.emitRustExpr () v96
    let v97 : string = " {{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v97
    let v98 : string = "__result"
    let v99 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v98
    let v100 : Result<unit, pyo3_PyErr> = method25(v99)
    let v101 : string = "v100.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v101
    ()
and method49 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method3()
    let v5 : float = method2()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : string = "import mpmath"
    let v9 : string = "def fn(s, _):"
    let v10 : string = "    s = complex(*s)"
    let v11 : string = "    try:"
    let v12 : string = "        s = mpmath.zeta(s)"
    let v13 : string = "    except ValueError as e:"
    let v14 : string = "        if s.real == 1:"
    let v15 : string = "            s = complex(float('inf'), 0)"
    let v16 : string = "    return (s.real, s.imag)"
    let v17 : (string []) = [|v8; v9; v10; v11; v12; v13; v14; v15; v16|]
    let v18 : (string []) = method6(v17)
    let v19 : int32 = v18.Length
    let v20 : string = ""
    let v21 : Mut1 = {l0 = 0; l1 = v20} : Mut1
    while method7(v19, v21) do
        let v23 : int32 = v21.l0
        let v24 : string = v21.l1
        let v25 : string = v18.[int v23]
        let v26 : string = "\n"
        let v27 : string = v24 + v25 + v26 + ""
        let v28 : int32 = v23 + 1
        v21.l0 <- v28
        v21.l1 <- v27
        ()
    let v29 : string = v21.l1
    let v30 : num_complex_Complex<float> = method8(v7)
    let v31 : string = "v30.re"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : num_complex_Complex<float> = method9(v7)
    let v34 : string = "v33.im"
    let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
    let v36 : (float * float) = v32, v35
    let v37 : ((float * float) * unit) = v36, ()
    let v38 : pyo3_Python = method10(v3)
    let v39 : string = method11(v29)
    let v40 : string = $"fable_library_rust::String_::LrcStr::as_str(&v39)"
    let v41 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : string = "pyo3::types::PyModule::from_code_bound(v38, v41, \"\", \"\")"
    let v43 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v43)
    let v45 : string = "v44.unwrap()"
    let v46 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v45
    let v47 : string = method13()
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : pyo3_Bound<pyo3_types_PyModule> = method14(v46)
    let v51 : string = "v50.getattr(v49)"
    let v52 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v51
    let v53 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v52)
    let v54 : string = "v53.unwrap()"
    let v55 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : ((float * float) * unit) = method16(v37)
    let v57 : pyo3_Bound<pyo3_PyAny> = method17(v55)
    let v58 : string = "pyo3::prelude::PyAnyMethods::call(&v57, (*(*v56).0, ()), None)"
    let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v58
    let v60 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v59)
    let v61 : string = "v60.unwrap()"
    let v62 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v61
    let v63 : pyo3_Bound<pyo3_PyAny> = method18(v62)
    let v64 : string = "v63.extract()"
    let v65 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
    let v66 : Result<struct (float * float), pyo3_PyErr> = method19(v65)
    let v67 : string = "v66.unwrap()"
    let struct (v68 : float, v69 : float) = Fable.Core.RustInterop.emitRustExpr () v67
    let v70 : float = method20(v68)
    let v71 : float = method21(v69)
    let v72 : string = "num_complex::Complex::new(v70, v71)"
    let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
    let v74 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v73
    let v75 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v74)
    let v76 : string = "v75.unwrap()"
    let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : num_complex_Complex<float> = method8(v77)
    let v79 : string = "v78.re"
    let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79
    let v81 : float = v80 + 0.08333333333333333
    let v82 : float =  -v81
    let v83 : bool = v81 >= v82
    let v84 : float =
        if v83 then
            v81
        else
            v82
    let v85 : bool = v84 < 0.0001
    let v87 : bool =
        if v85 then
            true
        else
            method23(v85)
    let v88 : string = $"__expect / actual: %A{v84} / expected: %A{0.0001}"
    let v89 : bool = v87 = false
    if v89 then
        failwith<unit> v88
    let v90 : num_complex_Complex<float> = method9(v77)
    let v91 : string = "v90.im"
    let v92 : float = Fable.Core.RustInterop.emitRustExpr () v91
    let v93 : bool = v92 = 0.0
    let v95 : bool =
        if v93 then
            true
        else
            method23(v93)
    let v96 : string = $"__expect / actual: %A{v92} / expected: %A{0.0}"
    let v97 : bool = v95 = false
    if v97 then
        failwith<unit> v96
    let v98 : Result<unit, pyo3_PyErr> = Ok ()
    let v99 : Result<unit, pyo3_PyErr> = method24(v98)
    let v100 : string = "v99 }}}}})"
    Fable.Core.RustInterop.emitRustExpr () v100
    let v101 : string = " {{{{ //"
    Fable.Core.RustInterop.emitRustExpr () v101
    let v102 : string = "__result"
    let v103 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v102
    let v104 : Result<unit, pyo3_PyErr> = method25(v103)
    let v105 : string = "v104.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v105
    ()
and method51 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    let v1 : (float []) = method41(v0)
    v1
and method52 () : float =
    0.0
and method53 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method50 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : (float []) = method51()
    let v5 : int32 = v4.Length
    let v6 : Mut0 = {l0 = 0} : Mut0
    while method5(v5, v6) do
        let v8 : int32 = v6.l0
        let v9 : float = v4.[int v8]
        let v10 : float = method52()
        let v11 : float = method21(v9)
        let v12 : string = "num_complex::Complex::new(v10, v11)"
        let v13 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v12
        let v14 : string = "import mpmath"
        let v15 : string = "def fn(s, _):"
        let v16 : string = "    s = complex(*s)"
        let v17 : string = "    try:"
        let v18 : string = "        s = mpmath.zeta(s)"
        let v19 : string = "    except ValueError as e:"
        let v20 : string = "        if s.real == 1:"
        let v21 : string = "            s = complex(float('inf'), 0)"
        let v22 : string = "    return (s.real, s.imag)"
        let v23 : (string []) = [|v14; v15; v16; v17; v18; v19; v20; v21; v22|]
        let v24 : (string []) = method6(v23)
        let v25 : int32 = v24.Length
        let v26 : string = ""
        let v27 : Mut1 = {l0 = 0; l1 = v26} : Mut1
        while method7(v25, v27) do
            let v29 : int32 = v27.l0
            let v30 : string = v27.l1
            let v31 : string = v24.[int v29]
            let v32 : string = "\n"
            let v33 : string = v30 + v31 + v32 + ""
            let v34 : int32 = v29 + 1
            v27.l0 <- v34
            v27.l1 <- v33
            ()
        let v35 : string = v27.l1
        let v36 : num_complex_Complex<float> = method8(v13)
        let v37 : string = "v36.re"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : num_complex_Complex<float> = method9(v13)
        let v40 : string = "v39.im"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40
        let v42 : (float * float) = v38, v41
        let v43 : ((float * float) * unit) = v42, ()
        let v44 : pyo3_Python = method10(v3)
        let v45 : string = method11(v35)
        let v46 : string = $"fable_library_rust::String_::LrcStr::as_str(&v45)"
        let v47 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v46
        let v48 : string = "pyo3::types::PyModule::from_code_bound(v44, v47, \"\", \"\")"
        let v49 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v49)
        let v51 : string = "v50.unwrap()"
        let v52 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v51
        let v53 : string = method13()
        let v54 : string = $"fable_library_rust::String_::LrcStr::as_str(&v53)"
        let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : pyo3_Bound<pyo3_types_PyModule> = method14(v52)
        let v57 : string = "v56.getattr(v55)"
        let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v58)
        let v60 : string = "v59.unwrap()"
        let v61 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : ((float * float) * unit) = method16(v43)
        let v63 : pyo3_Bound<pyo3_PyAny> = method17(v61)
        let v64 : string = "pyo3::prelude::PyAnyMethods::call(&v63, (*(*v62).0, ()), None)"
        let v65 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v65)
        let v67 : string = "v66.unwrap()"
        let v68 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : pyo3_Bound<pyo3_PyAny> = method18(v68)
        let v70 : string = "v69.extract()"
        let v71 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : Result<struct (float * float), pyo3_PyErr> = method19(v71)
        let v73 : string = "v72.unwrap()"
        let struct (v74 : float, v75 : float) = Fable.Core.RustInterop.emitRustExpr () v73
        let v76 : float = method20(v74)
        let v77 : float = method21(v75)
        let v78 : string = "num_complex::Complex::new(v76, v77)"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v78
        let v80 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v79
        let v81 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v80)
        let v82 : string = "v81.unwrap()"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v82
        let v84 : num_complex_Complex<float> = method8(v83)
        let v85 : string = "v84.re"
        let v86 : float = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : bool = v86 = 0.0
        let v88 : bool = method53(v87)
        let v90 : bool =
            if v88 then
                true
            else
                method23(v88)
        let v91 : string = $"__expect / actual: %A{v86} / expected: %A{0.0}"
        let v92 : bool = v90 = false
        if v92 then
            failwith<unit> v91
        let v93 : num_complex_Complex<float> = method9(v83)
        let v94 : string = "v93.im"
        let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94
        let v96 : bool = v95 = 0.0
        let v97 : bool = method53(v96)
        let v99 : bool =
            if v97 then
                true
            else
                method23(v97)
        let v100 : string = $"__expect / actual: %A{v95} / expected: %A{0.0}"
        let v101 : bool = v99 = false
        if v101 then
            failwith<unit> v100
        let v102 : int32 = v8 + 1
        v6.l0 <- v102
        ()
    let v103 : Result<unit, pyo3_PyErr> = Ok ()
    let v104 : Result<unit, pyo3_PyErr> = method24(v103)
    let v105 : string = "v104 }}})"
    Fable.Core.RustInterop.emitRustExpr () v105
    let v106 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v106
    let v107 : string = "__result"
    let v108 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v107
    let v109 : Result<unit, pyo3_PyErr> = method25(v108)
    let v110 : string = "v109.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v110
    ()
and method55 () : float =
    0.75
and method56 () : float =
    20.5
and method57 () : float =
    1.25
and method58 () : float =
    30.1
and method59 () : float =
    0.25
and method60 () : float =
    40.0
and method61 () : float =
    50.0
and method54 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method32()
    let v5 : float = method33()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : float = method55()
    let v9 : float = method56()
    let v10 : string = "num_complex::Complex::new(v8, v9)"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : float = method57()
    let v13 : float = method58()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method59()
    let v17 : float = method60()
    let v18 : string = "num_complex::Complex::new(v16, v17)"
    let v19 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : float = method43()
    let v21 : float = method61()
    let v22 : string = "num_complex::Complex::new(v20, v21)"
    let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
    let v24 : (num_complex_Complex<float> []) = [|v7; v11; v15; v19; v23|]
    let v25 : (num_complex_Complex<float> []) = method39(v24)
    let v26 : int32 = v25.Length
    let v27 : Mut0 = {l0 = 0} : Mut0
    while method5(v26, v27) do
        let v29 : int32 = v27.l0
        let v30 : num_complex_Complex<float> = v25.[int v29]
        let v31 : string = "import mpmath"
        let v32 : string = "def fn(s, _):"
        let v33 : string = "    s = complex(*s)"
        let v34 : string = "    try:"
        let v35 : string = "        s = mpmath.zeta(s)"
        let v36 : string = "    except ValueError as e:"
        let v37 : string = "        if s.real == 1:"
        let v38 : string = "            s = complex(float('inf'), 0)"
        let v39 : string = "    return (s.real, s.imag)"
        let v40 : (string []) = [|v31; v32; v33; v34; v35; v36; v37; v38; v39|]
        let v41 : (string []) = method6(v40)
        let v42 : int32 = v41.Length
        let v43 : string = ""
        let v44 : Mut1 = {l0 = 0; l1 = v43} : Mut1
        while method7(v42, v44) do
            let v46 : int32 = v44.l0
            let v47 : string = v44.l1
            let v48 : string = v41.[int v46]
            let v49 : string = "\n"
            let v50 : string = v47 + v48 + v49 + ""
            let v51 : int32 = v46 + 1
            v44.l0 <- v51
            v44.l1 <- v50
            ()
        let v52 : string = v44.l1
        let v53 : num_complex_Complex<float> = method8(v30)
        let v54 : string = "v53.re"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54
        let v56 : num_complex_Complex<float> = method9(v30)
        let v57 : string = "v56.im"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr () v57
        let v59 : (float * float) = v55, v58
        let v60 : ((float * float) * unit) = v59, ()
        let v61 : pyo3_Python = method10(v3)
        let v62 : string = method11(v52)
        let v63 : string = $"fable_library_rust::String_::LrcStr::as_str(&v62)"
        let v64 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : string = "pyo3::types::PyModule::from_code_bound(v61, v64, \"\", \"\")"
        let v66 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v65
        let v67 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v66)
        let v68 : string = "v67.unwrap()"
        let v69 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : string = method13()
        let v71 : string = $"fable_library_rust::String_::LrcStr::as_str(&v70)"
        let v72 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v71
        let v73 : pyo3_Bound<pyo3_types_PyModule> = method14(v69)
        let v74 : string = "v73.getattr(v72)"
        let v75 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v75)
        let v77 : string = "v76.unwrap()"
        let v78 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : ((float * float) * unit) = method16(v60)
        let v80 : pyo3_Bound<pyo3_PyAny> = method17(v78)
        let v81 : string = "pyo3::prelude::PyAnyMethods::call(&v80, (*(*v79).0, ()), None)"
        let v82 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v82)
        let v84 : string = "v83.unwrap()"
        let v85 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v84
        let v86 : pyo3_Bound<pyo3_PyAny> = method18(v85)
        let v87 : string = "v86.extract()"
        let v88 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v87
        let v89 : Result<struct (float * float), pyo3_PyErr> = method19(v88)
        let v90 : string = "v89.unwrap()"
        let struct (v91 : float, v92 : float) = Fable.Core.RustInterop.emitRustExpr () v90
        let v93 : float = method20(v91)
        let v94 : float = method21(v92)
        let v95 : string = "num_complex::Complex::new(v93, v94)"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v95
        let v97 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v96
        let v98 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v97)
        let v99 : string = "v98.unwrap()"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : num_complex_Complex<float> = method8(v100)
        let v102 : string = "v101.re"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102
        let v104 : bool = v103 = 0.0
        let v105 : bool = method53(v104)
        let v107 : bool =
            if v105 then
                true
            else
                method23(v105)
        let v108 : string = $"__expect / actual: %A{v103} / expected: %A{0.0}"
        let v109 : bool = v107 = false
        if v109 then
            failwith<unit> v108
        let v110 : num_complex_Complex<float> = method9(v100)
        let v111 : string = "v110.im"
        let v112 : float = Fable.Core.RustInterop.emitRustExpr () v111
        let v113 : bool = v112 = 0.0
        let v114 : bool = method53(v113)
        let v116 : bool =
            if v114 then
                true
            else
                method23(v114)
        let v117 : string = $"__expect / actual: %A{v112} / expected: %A{0.0}"
        let v118 : bool = v116 = false
        if v118 then
            failwith<unit> v117
        let v119 : int32 = v29 + 1
        v27.l0 <- v119
        ()
    let v120 : Result<unit, pyo3_PyErr> = Ok ()
    let v121 : Result<unit, pyo3_PyErr> = method24(v120)
    let v122 : string = "v121 }}})"
    Fable.Core.RustInterop.emitRustExpr () v122
    let v123 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v123
    let v124 : string = "__result"
    let v125 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v124
    let v126 : Result<unit, pyo3_PyErr> = method25(v125)
    let v127 : string = "v126.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v127
    ()
and method63 () : float =
    3.0
and method64 () : float =
    4.0
and method65 () : float =
    2.5
and method66 () : float =
    -3.5
and method67 () : float =
    1.5
and method68 () : float =
    2.5
and method69 () : float =
    3.141592653589793
and method62 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : float = method63()
    let v5 : float = method64()
    let v6 : string = "num_complex::Complex::new(v4, v5)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v6
    let v8 : float = method65()
    let v9 : float = method66()
    let v10 : string = "num_complex::Complex::new(v8, v9)"
    let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : float = method67()
    let v13 : float = method68()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method32()
    let v17 : float = method33()
    let v18 : string = "num_complex::Complex::new(v16, v17)"
    let v19 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v18
    let v20 : (num_complex_Complex<float> []) = [|v7; v11; v15; v19|]
    let v21 : (num_complex_Complex<float> []) = method39(v20)
    let v22 : int32 = v21.Length
    let v23 : Mut0 = {l0 = 0} : Mut0
    while method5(v22, v23) do
        let v25 : int32 = v23.l0
        let v26 : num_complex_Complex<float> = v21.[int v25]
        let v27 : string = "import mpmath"
        let v28 : string = "def fn(s, _):"
        let v29 : string = "    s = complex(*s)"
        let v30 : string = "    try:"
        let v31 : string = "        s = mpmath.zeta(s)"
        let v32 : string = "    except ValueError as e:"
        let v33 : string = "        if s.real == 1:"
        let v34 : string = "            s = complex(float('inf'), 0)"
        let v35 : string = "    return (s.real, s.imag)"
        let v36 : (string []) = [|v27; v28; v29; v30; v31; v32; v33; v34; v35|]
        let v37 : (string []) = method6(v36)
        let v38 : int32 = v37.Length
        let v39 : string = ""
        let v40 : Mut1 = {l0 = 0; l1 = v39} : Mut1
        while method7(v38, v40) do
            let v42 : int32 = v40.l0
            let v43 : string = v40.l1
            let v44 : string = v37.[int v42]
            let v45 : string = "\n"
            let v46 : string = v43 + v44 + v45 + ""
            let v47 : int32 = v42 + 1
            v40.l0 <- v47
            v40.l1 <- v46
            ()
        let v48 : string = v40.l1
        let v49 : num_complex_Complex<float> = method8(v26)
        let v50 : string = "v49.re"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : num_complex_Complex<float> = method9(v26)
        let v53 : string = "v52.im"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53
        let v55 : (float * float) = v51, v54
        let v56 : ((float * float) * unit) = v55, ()
        let v57 : pyo3_Python = method10(v3)
        let v58 : string = method11(v48)
        let v59 : string = $"fable_library_rust::String_::LrcStr::as_str(&v58)"
        let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v59
        let v61 : string = "pyo3::types::PyModule::from_code_bound(v57, v60, \"\", \"\")"
        let v62 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v62)
        let v64 : string = "v63.unwrap()"
        let v65 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : string = method13()
        let v67 : string = $"fable_library_rust::String_::LrcStr::as_str(&v66)"
        let v68 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v67
        let v69 : pyo3_Bound<pyo3_types_PyModule> = method14(v65)
        let v70 : string = "v69.getattr(v68)"
        let v71 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v70
        let v72 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v71)
        let v73 : string = "v72.unwrap()"
        let v74 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v73
        let v75 : ((float * float) * unit) = method16(v56)
        let v76 : pyo3_Bound<pyo3_PyAny> = method17(v74)
        let v77 : string = "pyo3::prelude::PyAnyMethods::call(&v76, (*(*v75).0, ()), None)"
        let v78 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v78)
        let v80 : string = "v79.unwrap()"
        let v81 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v80
        let v82 : pyo3_Bound<pyo3_PyAny> = method18(v81)
        let v83 : string = "v82.extract()"
        let v84 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v83
        let v85 : Result<struct (float * float), pyo3_PyErr> = method19(v84)
        let v86 : string = "v85.unwrap()"
        let struct (v87 : float, v88 : float) = Fable.Core.RustInterop.emitRustExpr () v86
        let v89 : float = method20(v87)
        let v90 : float = method21(v88)
        let v91 : string = "num_complex::Complex::new(v89, v90)"
        let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v91
        let v93 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v92
        let v94 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v93)
        let v95 : string = "v94.unwrap()"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v95
        let v97 : float = method1()
        let v98 : float = method2()
        let v99 : string = "num_complex::Complex::new(v97, v98)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : string = "num_complex::Complex::powc(v100, v26)"
        let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v101
        let v103 : float = method69()
        let v104 : float = method2()
        let v105 : string = "num_complex::Complex::new(v103, v104)"
        let v106 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v105
        let v107 : float = method43()
        let v108 : float = method2()
        let v109 : string = "num_complex::Complex::new(v107, v108)"
        let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v109
        let v111 : string = "v26 - v110"
        let v112 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v111
        let v113 : string = "num_complex::Complex::powc(v106, v112)"
        let v114 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v113
        let v115 : string = "v102 * v114"
        let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v115
        let v117 : float = method69()
        let v118 : float = method2()
        let v119 : string = "num_complex::Complex::new(v117, v118)"
        let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v119
        let v121 : string = "v120 * v26"
        let v122 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v121
        let v123 : float = method1()
        let v124 : float = method2()
        let v125 : string = "num_complex::Complex::new(v123, v124)"
        let v126 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v125
        let v127 : string = "v122 / v126"
        let v128 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v127
        let v129 : string = "v128.sin()"
        let v130 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v129
        let v131 : string = "v116 * v130"
        let v132 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v131
        let v133 : float = method43()
        let v134 : float = method2()
        let v135 : string = "num_complex::Complex::new(v133, v134)"
        let v136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v135
        let v137 : string = "v136 - v26"
        let v138 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v137
        let v139 : string = "    s = mpmath.gamma(s)"
        let v140 : (string []) = [|v27; v28; v29; v139; v35|]
        let v141 : (string []) = method6(v140)
        let v142 : int32 = v141.Length
        let v143 : Mut1 = {l0 = 0; l1 = v39} : Mut1
        while method7(v142, v143) do
            let v145 : int32 = v143.l0
            let v146 : string = v143.l1
            let v147 : string = v141.[int v145]
            let v148 : string = "\n"
            let v149 : string = v146 + v147 + v148 + ""
            let v150 : int32 = v145 + 1
            v143.l0 <- v150
            v143.l1 <- v149
            ()
        let v151 : string = v143.l1
        let v152 : num_complex_Complex<float> = method8(v138)
        let v153 : string = "v152.re"
        let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153
        let v155 : num_complex_Complex<float> = method9(v138)
        let v156 : string = "v155.im"
        let v157 : float = Fable.Core.RustInterop.emitRustExpr () v156
        let v158 : (float * float) = v154, v157
        let v159 : ((float * float) * unit) = v158, ()
        let v160 : pyo3_Python = method10(v3)
        let v161 : string = method11(v151)
        let v162 : string = $"fable_library_rust::String_::LrcStr::as_str(&v161)"
        let v163 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v162
        let v164 : string = "pyo3::types::PyModule::from_code_bound(v160, v163, \"\", \"\")"
        let v165 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v164
        let v166 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v165)
        let v167 : string = "v166.unwrap()"
        let v168 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v167
        let v169 : string = method13()
        let v170 : string = $"fable_library_rust::String_::LrcStr::as_str(&v169)"
        let v171 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v170
        let v172 : pyo3_Bound<pyo3_types_PyModule> = method14(v168)
        let v173 : string = "v172.getattr(v171)"
        let v174 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v173
        let v175 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v174)
        let v176 : string = "v175.unwrap()"
        let v177 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v176
        let v178 : ((float * float) * unit) = method16(v159)
        let v179 : pyo3_Bound<pyo3_PyAny> = method17(v177)
        let v180 : string = "pyo3::prelude::PyAnyMethods::call(&v179, (*(*v178).0, ()), None)"
        let v181 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v180
        let v182 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v181)
        let v183 : string = "v182.unwrap()"
        let v184 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v183
        let v185 : pyo3_Bound<pyo3_PyAny> = method18(v184)
        let v186 : string = "v185.extract()"
        let v187 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v186
        let v188 : Result<struct (float * float), pyo3_PyErr> = method19(v187)
        let v189 : string = "v188.unwrap()"
        let struct (v190 : float, v191 : float) = Fable.Core.RustInterop.emitRustExpr () v189
        let v192 : float = method20(v190)
        let v193 : float = method21(v191)
        let v194 : string = "num_complex::Complex::new(v192, v193)"
        let v195 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v194
        let v196 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v195
        let v197 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v196)
        let v198 : string = "v197.unwrap()"
        let v199 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v198
        let v200 : string = "v132 * v199"
        let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v200
        let v202 : num_complex_Complex<float> = method8(v26)
        let v203 : string = "v202.re"
        let v204 : float = Fable.Core.RustInterop.emitRustExpr () v203
        let v205 : float = 1.0 - v204
        let v206 : num_complex_Complex<float> = method9(v26)
        let v207 : string = "v206.im"
        let v208 : float = Fable.Core.RustInterop.emitRustExpr () v207
        let v209 : float =  -v208
        let v210 : float = method20(v205)
        let v211 : float = method21(v209)
        let v212 : string = "num_complex::Complex::new(v210, v211)"
        let v213 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v212
        let v214 : (string []) = [|v27; v28; v29; v30; v31; v32; v33; v34; v35|]
        let v215 : (string []) = method6(v214)
        let v216 : int32 = v215.Length
        let v217 : Mut1 = {l0 = 0; l1 = v39} : Mut1
        while method7(v216, v217) do
            let v219 : int32 = v217.l0
            let v220 : string = v217.l1
            let v221 : string = v215.[int v219]
            let v222 : string = "\n"
            let v223 : string = v220 + v221 + v222 + ""
            let v224 : int32 = v219 + 1
            v217.l0 <- v224
            v217.l1 <- v223
            ()
        let v225 : string = v217.l1
        let v226 : num_complex_Complex<float> = method8(v213)
        let v227 : string = "v226.re"
        let v228 : float = Fable.Core.RustInterop.emitRustExpr () v227
        let v229 : num_complex_Complex<float> = method9(v213)
        let v230 : string = "v229.im"
        let v231 : float = Fable.Core.RustInterop.emitRustExpr () v230
        let v232 : (float * float) = v228, v231
        let v233 : ((float * float) * unit) = v232, ()
        let v234 : pyo3_Python = method10(v3)
        let v235 : string = method11(v225)
        let v236 : string = $"fable_library_rust::String_::LrcStr::as_str(&v235)"
        let v237 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v236
        let v238 : string = "pyo3::types::PyModule::from_code_bound(v234, v237, \"\", \"\")"
        let v239 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v238
        let v240 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v239)
        let v241 : string = "v240.unwrap()"
        let v242 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v241
        let v243 : string = method13()
        let v244 : string = $"fable_library_rust::String_::LrcStr::as_str(&v243)"
        let v245 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v244
        let v246 : pyo3_Bound<pyo3_types_PyModule> = method14(v242)
        let v247 : string = "v246.getattr(v245)"
        let v248 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v247
        let v249 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v248)
        let v250 : string = "v249.unwrap()"
        let v251 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v250
        let v252 : ((float * float) * unit) = method16(v233)
        let v253 : pyo3_Bound<pyo3_PyAny> = method17(v251)
        let v254 : string = "pyo3::prelude::PyAnyMethods::call(&v253, (*(*v252).0, ()), None)"
        let v255 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v254
        let v256 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v255)
        let v257 : string = "v256.unwrap()"
        let v258 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v257
        let v259 : pyo3_Bound<pyo3_PyAny> = method18(v258)
        let v260 : string = "v259.extract()"
        let v261 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v260
        let v262 : Result<struct (float * float), pyo3_PyErr> = method19(v261)
        let v263 : string = "v262.unwrap()"
        let struct (v264 : float, v265 : float) = Fable.Core.RustInterop.emitRustExpr () v263
        let v266 : float = method20(v264)
        let v267 : float = method21(v265)
        let v268 : string = "num_complex::Complex::new(v266, v267)"
        let v269 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v268
        let v270 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v269
        let v271 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v270)
        let v272 : string = "v271.unwrap()"
        let v273 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v272
        let v274 : string = "v201 * v273"
        let v275 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v274
        let v276 : num_complex_Complex<float> = method8(v96)
        let v277 : string = "v276.re"
        let v278 : float = Fable.Core.RustInterop.emitRustExpr () v277
        let v279 : num_complex_Complex<float> = method8(v275)
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
                method23(v286)
        let v289 : string = $"__expect / actual: %A{v285} / expected: %A{0.0001}"
        let v290 : bool = v288 = false
        if v290 then
            failwith<unit> v289
        let v291 : num_complex_Complex<float> = method9(v96)
        let v292 : string = "v291.im"
        let v293 : float = Fable.Core.RustInterop.emitRustExpr () v292
        let v294 : num_complex_Complex<float> = method9(v275)
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
                method23(v301)
        let v304 : string = $"__expect / actual: %A{v300} / expected: %A{0.0001}"
        let v305 : bool = v303 = false
        if v305 then
            failwith<unit> v304
        let v306 : int32 = v25 + 1
        v23.l0 <- v306
        ()
    let v307 : Result<unit, pyo3_PyErr> = Ok ()
    let v308 : Result<unit, pyo3_PyErr> = method24(v307)
    let v309 : string = "v308 }}})"
    Fable.Core.RustInterop.emitRustExpr () v309
    let v310 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v310
    let v311 : string = "__result"
    let v312 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v311
    let v313 : Result<unit, pyo3_PyErr> = method25(v312)
    let v314 : string = "v313.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v314
    ()
and method71 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method70 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    let v4 : (float []) = [|2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0|]
    let v5 : (float []) = method41(v4)
    let v6 : (float []) = [|2.0; 3.0; 5.0; 7.0; 11.0; 13.0; 17.0; 19.0; 23.0; 29.0; 31.0; 37.0; 41.0; 43.0; 47.0; 53.0; 59.0; 61.0; 67.0; 71.0|]
    let v7 : (float []) = method41(v6)
    let v8 : int32 = v5.Length
    let v9 : Mut0 = {l0 = 0} : Mut0
    while method5(v8, v9) do
        let v11 : int32 = v9.l0
        let v12 : float = v5.[int v11]
        let v13 : float = method20(v12)
        let v14 : float = method2()
        let v15 : string = "num_complex::Complex::new(v13, v14)"
        let v16 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v15
        let v17 : int32 = v7.Length
        let v18 : Mut2 = {l0 = 0; l1 = 1.0} : Mut2
        while method71(v17, v18) do
            let v20 : int32 = v18.l0
            let v21 : float = v18.l1
            let v22 : float = v7.[int v20]
            let v23 : float =  -v12
            let v24 : float = v22 ** v23
            let v25 : float = 1.0 - v24
            let v26 : float = v21 / v25
            let v27 : int32 = v20 + 1
            v18.l0 <- v27
            v18.l1 <- v26
            ()
        let v28 : float = v18.l1
        let v29 : string = "import mpmath"
        let v30 : string = "def fn(s, _):"
        let v31 : string = "    s = complex(*s)"
        let v32 : string = "    try:"
        let v33 : string = "        s = mpmath.zeta(s)"
        let v34 : string = "    except ValueError as e:"
        let v35 : string = "        if s.real == 1:"
        let v36 : string = "            s = complex(float('inf'), 0)"
        let v37 : string = "    return (s.real, s.imag)"
        let v38 : (string []) = [|v29; v30; v31; v32; v33; v34; v35; v36; v37|]
        let v39 : (string []) = method6(v38)
        let v40 : int32 = v39.Length
        let v41 : string = ""
        let v42 : Mut1 = {l0 = 0; l1 = v41} : Mut1
        while method7(v40, v42) do
            let v44 : int32 = v42.l0
            let v45 : string = v42.l1
            let v46 : string = v39.[int v44]
            let v47 : string = "\n"
            let v48 : string = v45 + v46 + v47 + ""
            let v49 : int32 = v44 + 1
            v42.l0 <- v49
            v42.l1 <- v48
            ()
        let v50 : string = v42.l1
        let v51 : num_complex_Complex<float> = method8(v16)
        let v52 : string = "v51.re"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : num_complex_Complex<float> = method9(v16)
        let v55 : string = "v54.im"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : (float * float) = v53, v56
        let v58 : ((float * float) * unit) = v57, ()
        let v59 : pyo3_Python = method10(v3)
        let v60 : string = method11(v50)
        let v61 : string = $"fable_library_rust::String_::LrcStr::as_str(&v60)"
        let v62 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : string = "pyo3::types::PyModule::from_code_bound(v59, v62, \"\", \"\")"
        let v64 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
        let v65 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method12(v64)
        let v66 : string = "v65.unwrap()"
        let v67 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : string = method13()
        let v69 : string = $"fable_library_rust::String_::LrcStr::as_str(&v68)"
        let v70 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v69
        let v71 : pyo3_Bound<pyo3_types_PyModule> = method14(v67)
        let v72 : string = "v71.getattr(v70)"
        let v73 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v73)
        let v75 : string = "v74.unwrap()"
        let v76 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : ((float * float) * unit) = method16(v58)
        let v78 : pyo3_Bound<pyo3_PyAny> = method17(v76)
        let v79 : string = "pyo3::prelude::PyAnyMethods::call(&v78, (*(*v77).0, ()), None)"
        let v80 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method15(v80)
        let v82 : string = "v81.unwrap()"
        let v83 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v82
        let v84 : pyo3_Bound<pyo3_PyAny> = method18(v83)
        let v85 : string = "v84.extract()"
        let v86 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v85
        let v87 : Result<struct (float * float), pyo3_PyErr> = method19(v86)
        let v88 : string = "v87.unwrap()"
        let struct (v89 : float, v90 : float) = Fable.Core.RustInterop.emitRustExpr () v88
        let v91 : float = method20(v89)
        let v92 : float = method21(v90)
        let v93 : string = "num_complex::Complex::new(v91, v92)"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v93
        let v95 : Result<num_complex_Complex<float>, pyo3_PyErr> = Ok v94
        let v96 : Result<num_complex_Complex<float>, pyo3_PyErr> = method22(v95)
        let v97 : string = "v96.unwrap()"
        let v98 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v97
        let v99 : num_complex_Complex<float> = method8(v98)
        let v100 : string = "v99.re"
        let v101 : float = Fable.Core.RustInterop.emitRustExpr () v100
        let v102 : float = v101 - v28
        let v103 : float =  -v102
        let v104 : bool = v102 >= v103
        let v105 : float =
            if v104 then
                v102
            else
                v103
        let v106 : bool = v105 < 0.01
        let v108 : bool =
            if v106 then
                true
            else
                method23(v106)
        let v109 : string = $"__expect / actual: %A{v105} / expected: %A{0.01}"
        let v110 : bool = v108 = false
        if v110 then
            failwith<unit> v109
        let v111 : num_complex_Complex<float> = method9(v98)
        let v112 : string = "v111.im"
        let v113 : float = Fable.Core.RustInterop.emitRustExpr () v112
        let v114 : bool = v113 < 0.01
        let v116 : bool =
            if v114 then
                true
            else
                method23(v114)
        let v117 : string = $"__expect / actual: %A{v113} / expected: %A{0.01}"
        let v118 : bool = v116 = false
        if v118 then
            failwith<unit> v117
        let v119 : int32 = v11 + 1
        v9.l0 <- v119
        ()
    let v120 : Result<unit, pyo3_PyErr> = Ok ()
    let v121 : Result<unit, pyo3_PyErr> = method24(v120)
    let v122 : string = "v121 }}})"
    Fable.Core.RustInterop.emitRustExpr () v122
    let v123 : string = " {{ //"
    Fable.Core.RustInterop.emitRustExpr () v123
    let v124 : string = "__result"
    let v125 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v124
    let v126 : Result<unit, pyo3_PyErr> = method25(v125)
    let v127 : string = "v126.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v127
    ()
and closure0 () () : unit =
    let v0 : string = "}//"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "#[test] fn test_zeta_at_known_values_() { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    method0()
    let v2 : string = "} #[test] fn test_zeta_at_2_minus2() { //"
    Fable.Core.RustInterop.emitRustExpr () v2
    method26()
    let v3 : string = "} #[test] fn test_trivial_zero_at_negative_even___() { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    method28()
    let v4 : string = "} #[test] fn test_non_trivial_zero___() { //"
    Fable.Core.RustInterop.emitRustExpr () v4
    method31()
    let v5 : string = "} #[test] fn test_real_part_greater_than_one___() { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    method40()
    let v6 : string = "} #[test] fn test_zeta_at_1___() { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    method42()
    let v7 : string = "} #[test] fn test_symmetry_across_real_axis___() { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    method44()
    let v8 : string = "} #[test] fn test_behavior_near_origin___() { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    method46()
    let v9 : string = "} #[test] fn test_zeta_at_minus_1() { //"
    Fable.Core.RustInterop.emitRustExpr () v9
    method49()
    let v10 : string = "} #[test] fn test_imaginary_axis() { //"
    Fable.Core.RustInterop.emitRustExpr () v10
    method50()
    let v11 : string = "} #[test] fn test_critical_strip() { //"
    Fable.Core.RustInterop.emitRustExpr () v11
    method54()
    let v12 : string = "} #[test] fn test_reflection_formula_for_specific_value() { //"
    Fable.Core.RustInterop.emitRustExpr () v12
    method62()
    let v13 : string = "} #[test] fn test_euler_product_formula() { //"
    Fable.Core.RustInterop.emitRustExpr () v13
    method70()
and closure1 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure1()
let main args = v1 args
()
