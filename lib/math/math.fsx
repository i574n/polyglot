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
and [<Struct>] US0 =
    | US0_0
    | US0_1 of f1_0 : num_complex_Complex<float>
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
and closure1 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : string = @$"format!(""{{}}"", $0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method17 () : (pyo3_PyErr -> std_string_String) =
    closure1()
and method18 (v0 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> =
    v0
and method19 (v0 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String>) : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> =
    v0
and method20 () : string =
    let v0 : string = "fn"
    v0
and method21 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and closure2 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : string = @$"format!(""{{}}"", $0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method22 () : (pyo3_PyErr -> std_string_String) =
    closure2()
and method23 (v0 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr>) : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> =
    v0
and method24 (v0 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String>) : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> =
    v0
and method25 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method26 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure3 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : string = @$"format!(""{{}}"", $0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method27 () : (pyo3_PyErr -> std_string_String) =
    closure3()
and method28 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure4 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : string = @$"format!(""{{}}"", $0)"
    let v2 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v1
    v2
and method29 () : (pyo3_PyErr -> std_string_String) =
    closure4()
and method30 (v0 : Result<struct (float * float), pyo3_PyErr>) : Result<struct (float * float), pyo3_PyErr> =
    v0
and method31 (v0 : float) : float =
    v0
and method32 (v0 : float) : float =
    v0
and method9 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
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
    let v16 : string = $"            print(f\"{{event}}({v15}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split('site-packages')[-1]}} / f_back.f_lineno: {{ '' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] }} / arg: {{arg}}\", flush=True)"
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
    let v36 : (string []) = method10(v35)
    let v37 : string = method11(v36)
    let v38 : num_complex_Complex<float> = method13(v2)
    let v39 : string = "v38.re"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : num_complex_Complex<float> = method14(v2)
    let v42 : string = "v41.im"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : (float * float) = v40, v43
    let v45 : (bool * (float * float)) = false, v44
    let v46 : pyo3_Python = method15(v0)
    let v47 : string = method16(v37)
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : string = "pyo3::types::PyModule::from_code_bound(v46, v49, \"\", \"\")"
    let v51 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : (pyo3_PyErr -> std_string_String) = method17()
    let v53 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method18(v51)
    let v54 : string = "v53.map_err(|x| v52(x))"
    let v55 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = method19(v55)
    let v57 : string = "v56.unwrap()"
    let v58 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v57
    let v59 : string = method20()
    let v60 : string = $"fable_library_rust::String_::LrcStr::as_str(&v59)"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : pyo3_Bound<pyo3_types_PyModule> = method21(v58)
    let v63 : string = "v62.getattr(v61)"
    let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : (pyo3_PyErr -> std_string_String) = method22()
    let v66 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method23(v64)
    let v67 : string = "v66.map_err(|x| v65(x))"
    let v68 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = method24(v68)
    let v70 : string = "v69.unwrap()"
    let v71 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v70
    let v72 : (bool * (float * float)) = method25(v45)
    let v73 : pyo3_Bound<pyo3_PyAny> = method26(v71)
    let v74 : string = "pyo3::prelude::PyAnyMethods::call(&v73, ((*v72).0, *(*v72).1), None)"
    let v75 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v74
    let v76 : (pyo3_PyErr -> std_string_String) = method27()
    let v77 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method23(v75)
    let v78 : string = "v77.map_err(|x| v76(x))"
    let v79 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : string = "v79?"
    let v81 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v80
    let v82 : pyo3_Bound<pyo3_PyAny> = method28(v81)
    let v83 : string = "v82.extract()"
    let v84 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v83
    let v85 : (pyo3_PyErr -> std_string_String) = method29()
    let v86 : Result<struct (float * float), pyo3_PyErr> = method30(v84)
    let v87 : string = "v86.map_err(|x| v85(x))"
    let v88 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : string = "v88?"
    let struct (v90 : float, v91 : float) = Fable.Core.RustInterop.emitRustExpr () v89
    let v92 : float = method31(v90)
    let v93 : float = method3(v92)
    let v94 : float = method32(v91)
    let v95 : string = "num_complex::Complex::new(v93, v94)"
    let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v95
    let v97 : Result<num_complex_Complex<float>, std_string_String> = Ok v96
    v97
and method34 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method35 () : float =
    0.0
and method36 (v0 : Mut0) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 < 10000
    v2
and method37 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method38 () : float =
    1.0
and method39 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method40 (v0 : num_complex_Complex<float>) : num_complex_Complex<float> =
    v0
and method41 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
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
    let v16 : string = $"            print(f\"{{event}}({v15}) / f_code.co_name: {{frame.f_code.co_name}} / f_locals: {{args_str}} / f_lineno: {{frame.f_lineno}} / f_code.co_filename: {{frame.f_code.co_filename.split('site-packages')[-1]}} / f_back.f_lineno: {{ '' if frame.f_back is None else frame.f_back.f_lineno }} / f_back.f_code.co_filename: {{ '' if frame.f_back is None else frame.f_back.f_code.co_filename.split('site-packages')[-1] }} / arg: {{arg}}\", flush=True)"
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
    let v36 : (string []) = method10(v35)
    let v37 : string = method11(v36)
    let v38 : num_complex_Complex<float> = method13(v2)
    let v39 : string = "v38.re"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
    let v41 : num_complex_Complex<float> = method14(v2)
    let v42 : string = "v41.im"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42
    let v44 : (float * float) = v40, v43
    let v45 : (bool * (float * float)) = false, v44
    let v46 : pyo3_Python = method15(v0)
    let v47 : string = method16(v37)
    let v48 : string = $"fable_library_rust::String_::LrcStr::as_str(&v47)"
    let v49 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v48
    let v50 : string = "pyo3::types::PyModule::from_code_bound(v46, v49, \"\", \"\")"
    let v51 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v50
    let v52 : (pyo3_PyErr -> std_string_String) = method17()
    let v53 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = method18(v51)
    let v54 : string = "v53.map_err(|x| v52(x))"
    let v55 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v54
    let v56 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = method19(v55)
    let v57 : string = "v56.unwrap()"
    let v58 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr () v57
    let v59 : string = method20()
    let v60 : string = $"fable_library_rust::String_::LrcStr::as_str(&v59)"
    let v61 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr () v60
    let v62 : pyo3_Bound<pyo3_types_PyModule> = method21(v58)
    let v63 : string = "v62.getattr(v61)"
    let v64 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v63
    let v65 : (pyo3_PyErr -> std_string_String) = method22()
    let v66 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method23(v64)
    let v67 : string = "v66.map_err(|x| v65(x))"
    let v68 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v67
    let v69 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = method24(v68)
    let v70 : string = "v69.unwrap()"
    let v71 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v70
    let v72 : (bool * (float * float)) = method25(v45)
    let v73 : pyo3_Bound<pyo3_PyAny> = method26(v71)
    let v74 : string = "pyo3::prelude::PyAnyMethods::call(&v73, ((*v72).0, *(*v72).1), None)"
    let v75 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v74
    let v76 : (pyo3_PyErr -> std_string_String) = method27()
    let v77 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = method23(v75)
    let v78 : string = "v77.map_err(|x| v76(x))"
    let v79 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v78
    let v80 : string = "v79?"
    let v81 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr () v80
    let v82 : pyo3_Bound<pyo3_PyAny> = method28(v81)
    let v83 : string = "v82.extract()"
    let v84 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v83
    let v85 : (pyo3_PyErr -> std_string_String) = method29()
    let v86 : Result<struct (float * float), pyo3_PyErr> = method30(v84)
    let v87 : string = "v86.map_err(|x| v85(x))"
    let v88 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v87
    let v89 : string = "v88?"
    let struct (v90 : float, v91 : float) = Fable.Core.RustInterop.emitRustExpr () v89
    let v92 : float = method31(v90)
    let v93 : float = method3(v92)
    let v94 : float = method32(v91)
    let v95 : string = "num_complex::Complex::new(v93, v94)"
    let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v95
    let v97 : Result<num_complex_Complex<float>, std_string_String> = Ok v96
    v97
and closure5 () (v0 : num_complex_Complex<float>) : US0 =
    US0_1(v0)
and method42 () : float =
    3.141592653589793
and method33 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : num_complex_Complex<float> =
    let v2 : num_complex_Complex<float> = method34(v1)
    let v3 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 0, v2)"
    Fable.Core.RustInterop.emitRustExpr () v3
    let v4 : num_complex_Complex<float> = method13(v2)
    let v5 : string = "v4.re"
    let v6 : float = Fable.Core.RustInterop.emitRustExpr () v5
    let v7 : bool = v6 > 1.0
    if v7 then
        let v8 : float = method35()
        let v9 : float = method3(v8)
        let v10 : float = method4()
        let v11 : string = "num_complex::Complex::new(v9, v10)"
        let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v11
        let v13 : (int32 []) = Array.zeroCreate<int32> (10000)
        let v14 : Mut0 = {l0 = 0} : Mut0
        while method36(v14) do
            let v16 : int32 = v14.l0
            v13.[int v16] <- v16
            let v17 : int32 = v16 + 1
            v14.l0 <- v17
            ()
        let v18 : int32 = v13.Length
        let v19 : Mut2 = {l0 = 0; l1 = v12} : Mut2
        while method37(v18, v19) do
            let v21 : int32 = v19.l0
            let v22 : num_complex_Complex<float> = v19.l1
            let v23 : int32 = v13.[int v21]
            let v24 : float = method38()
            let v25 : float = method3(v24)
            let v26 : float = method4()
            let v27 : string = "num_complex::Complex::new(v25, v26)"
            let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v27
            let v29 : float = float v23
            let v30 : float = method31(v29)
            let v31 : float = method3(v30)
            let v32 : float = method4()
            let v33 : string = "num_complex::Complex::new(v31, v32)"
            let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v33
            let v35 : num_complex_Complex<float> = method39(v34)
            let v36 : num_complex_Complex<float> = method40(v2)
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
        let v45 : float = method38()
        let v46 : float = method3(v45)
        let v47 : float = method4()
        let v48 : string = "num_complex::Complex::new(v46, v47)"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v48
        let v50 : string = "v49 - v2"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v50
        let v52 : string = $"        s = mpmath.gamma(s)"
        let v53 : num_complex_Complex<float> = method8(v51)
        let v54 : Result<num_complex_Complex<float>, std_string_String> = method41(v0, v52, v53)
        let v55 : string = "v54.ok()"
        let v56 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : (num_complex_Complex<float> -> US0) = closure5()
        let v58 : US0 = US0_0
        let v59 : US0 = v56 |> Option.map v57 |> Option.defaultValue v58
        let v60 : string = "f64::NAN"
        let v61 : float = Fable.Core.RustInterop.emitRustExpr () v60
        let v62 : string = "f64::NAN"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr () v62
        let v64 : float = method31(v61)
        let v65 : float = method3(v64)
        let v66 : float = method32(v63)
        let v67 : string = "num_complex::Complex::new(v65, v66)"
        let v68 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v67
        let v71 : num_complex_Complex<float> =
            match v59 with
            | US0_0 -> (* None *)
                v68
            | US0_1(v69) -> (* Some *)
                v69
        let v72 : float = method42()
        let v73 : float = method3(v72)
        let v74 : float = method4()
        let v75 : string = "num_complex::Complex::new(v73, v74)"
        let v76 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v75
        let v77 : string = "v76 * v2"
        let v78 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v77
        let v79 : float = method2()
        let v80 : float = method3(v79)
        let v81 : float = method4()
        let v82 : string = "num_complex::Complex::new(v80, v81)"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v82
        let v84 : string = "v78 / v83"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v84
        let v86 : string = "v85.sin()"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v86
        let v88 : num_complex_Complex<float> = method13(v2)
        let v89 : string = "v88.re"
        let v90 : float = Fable.Core.RustInterop.emitRustExpr () v89
        let v91 : float = 1.0 - v90
        let v92 : num_complex_Complex<float> = method14(v2)
        let v93 : string = "v92.im"
        let v94 : float = Fable.Core.RustInterop.emitRustExpr () v93
        let v95 : float =  -v94
        let v96 : float = method31(v91)
        let v97 : float = method3(v96)
        let v98 : float = method32(v95)
        let v99 : string = "num_complex::Complex::new(v97, v98)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : num_complex_Complex<float> = method13(v100)
        let v102 : string = "v101.re"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102
        let v104 : bool = v103 <= 1.0
        let v634 : num_complex_Complex<float> =
            if v104 then
                let v105 : float = method35()
                let v106 : float = method3(v105)
                let v107 : float = method4()
                let v108 : string = "num_complex::Complex::new(v106, v107)"
                let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v108
                v109
            else
                let v110 : num_complex_Complex<float> = method34(v100)
                let v111 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 1, v110)"
                Fable.Core.RustInterop.emitRustExpr () v111
                let v112 : num_complex_Complex<float> = method13(v110)
                let v113 : string = "v112.re"
                let v114 : float = Fable.Core.RustInterop.emitRustExpr () v113
                let v115 : bool = v114 > 1.0
                if v115 then
                    let v116 : float = method35()
                    let v117 : float = method3(v116)
                    let v118 : float = method4()
                    let v119 : string = "num_complex::Complex::new(v117, v118)"
                    let v120 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v119
                    let v121 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v122 : Mut0 = {l0 = 0} : Mut0
                    while method36(v122) do
                        let v124 : int32 = v122.l0
                        v121.[int v124] <- v124
                        let v125 : int32 = v124 + 1
                        v122.l0 <- v125
                        ()
                    let v126 : int32 = v121.Length
                    let v127 : Mut2 = {l0 = 0; l1 = v120} : Mut2
                    while method37(v126, v127) do
                        let v129 : int32 = v127.l0
                        let v130 : num_complex_Complex<float> = v127.l1
                        let v131 : int32 = v121.[int v129]
                        let v132 : float = method38()
                        let v133 : float = method3(v132)
                        let v134 : float = method4()
                        let v135 : string = "num_complex::Complex::new(v133, v134)"
                        let v136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v135
                        let v137 : float = float v131
                        let v138 : float = method31(v137)
                        let v139 : float = method3(v138)
                        let v140 : float = method4()
                        let v141 : string = "num_complex::Complex::new(v139, v140)"
                        let v142 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v141
                        let v143 : num_complex_Complex<float> = method39(v142)
                        let v144 : num_complex_Complex<float> = method40(v110)
                        let v145 : string = "num_complex::Complex::powc(v143, v144)"
                        let v146 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v145
                        let v147 : string = "v136 / v146"
                        let v148 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v147
                        let v149 : string = "v130 + v148"
                        let v150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v149
                        let v151 : int32 = v129 + 1
                        v127.l0 <- v151
                        v127.l1 <- v150
                        ()
                    let v152 : num_complex_Complex<float> = v127.l1
                    v152
                else
                    let v153 : float = method38()
                    let v154 : float = method3(v153)
                    let v155 : float = method4()
                    let v156 : string = "num_complex::Complex::new(v154, v155)"
                    let v157 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v156
                    let v158 : string = "v157 - v110"
                    let v159 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v158
                    let v160 : string = $"        s = mpmath.gamma(s)"
                    let v161 : num_complex_Complex<float> = method8(v159)
                    let v162 : Result<num_complex_Complex<float>, std_string_String> = method41(v0, v160, v161)
                    let v163 : string = "v162.ok()"
                    let v164 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v163
                    let v165 : US0 = US0_0
                    let v166 : US0 = v164 |> Option.map v57 |> Option.defaultValue v165
                    let v167 : string = "f64::NAN"
                    let v168 : float = Fable.Core.RustInterop.emitRustExpr () v167
                    let v169 : string = "f64::NAN"
                    let v170 : float = Fable.Core.RustInterop.emitRustExpr () v169
                    let v171 : float = method31(v168)
                    let v172 : float = method3(v171)
                    let v173 : float = method32(v170)
                    let v174 : string = "num_complex::Complex::new(v172, v173)"
                    let v175 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v174
                    let v178 : num_complex_Complex<float> =
                        match v166 with
                        | US0_0 -> (* None *)
                            v175
                        | US0_1(v176) -> (* Some *)
                            v176
                    let v179 : float = method42()
                    let v180 : float = method3(v179)
                    let v181 : float = method4()
                    let v182 : string = "num_complex::Complex::new(v180, v181)"
                    let v183 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v182
                    let v184 : string = "v183 * v110"
                    let v185 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v184
                    let v186 : float = method2()
                    let v187 : float = method3(v186)
                    let v188 : float = method4()
                    let v189 : string = "num_complex::Complex::new(v187, v188)"
                    let v190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v189
                    let v191 : string = "v185 / v190"
                    let v192 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v191
                    let v193 : string = "v192.sin()"
                    let v194 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v193
                    let v195 : num_complex_Complex<float> = method13(v110)
                    let v196 : string = "v195.re"
                    let v197 : float = Fable.Core.RustInterop.emitRustExpr () v196
                    let v198 : float = 1.0 - v197
                    let v199 : num_complex_Complex<float> = method14(v110)
                    let v200 : string = "v199.im"
                    let v201 : float = Fable.Core.RustInterop.emitRustExpr () v200
                    let v202 : float =  -v201
                    let v203 : float = method31(v198)
                    let v204 : float = method3(v203)
                    let v205 : float = method32(v202)
                    let v206 : string = "num_complex::Complex::new(v204, v205)"
                    let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v206
                    let v208 : num_complex_Complex<float> = method13(v207)
                    let v209 : string = "v208.re"
                    let v210 : float = Fable.Core.RustInterop.emitRustExpr () v209
                    let v211 : bool = v210 <= 1.0
                    let v610 : num_complex_Complex<float> =
                        if v211 then
                            let v212 : float = method35()
                            let v213 : float = method3(v212)
                            let v214 : float = method4()
                            let v215 : string = "num_complex::Complex::new(v213, v214)"
                            let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v215
                            v216
                        else
                            let v217 : num_complex_Complex<float> = method34(v207)
                            let v218 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 2, v217)"
                            Fable.Core.RustInterop.emitRustExpr () v218
                            let v219 : num_complex_Complex<float> = method13(v217)
                            let v220 : string = "v219.re"
                            let v221 : float = Fable.Core.RustInterop.emitRustExpr () v220
                            let v222 : bool = v221 > 1.0
                            if v222 then
                                let v223 : float = method35()
                                let v224 : float = method3(v223)
                                let v225 : float = method4()
                                let v226 : string = "num_complex::Complex::new(v224, v225)"
                                let v227 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v226
                                let v228 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v229 : Mut0 = {l0 = 0} : Mut0
                                while method36(v229) do
                                    let v231 : int32 = v229.l0
                                    v228.[int v231] <- v231
                                    let v232 : int32 = v231 + 1
                                    v229.l0 <- v232
                                    ()
                                let v233 : int32 = v228.Length
                                let v234 : Mut2 = {l0 = 0; l1 = v227} : Mut2
                                while method37(v233, v234) do
                                    let v236 : int32 = v234.l0
                                    let v237 : num_complex_Complex<float> = v234.l1
                                    let v238 : int32 = v228.[int v236]
                                    let v239 : float = method38()
                                    let v240 : float = method3(v239)
                                    let v241 : float = method4()
                                    let v242 : string = "num_complex::Complex::new(v240, v241)"
                                    let v243 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v242
                                    let v244 : float = float v238
                                    let v245 : float = method31(v244)
                                    let v246 : float = method3(v245)
                                    let v247 : float = method4()
                                    let v248 : string = "num_complex::Complex::new(v246, v247)"
                                    let v249 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v248
                                    let v250 : num_complex_Complex<float> = method39(v249)
                                    let v251 : num_complex_Complex<float> = method40(v217)
                                    let v252 : string = "num_complex::Complex::powc(v250, v251)"
                                    let v253 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v252
                                    let v254 : string = "v243 / v253"
                                    let v255 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v254
                                    let v256 : string = "v237 + v255"
                                    let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v256
                                    let v258 : int32 = v236 + 1
                                    v234.l0 <- v258
                                    v234.l1 <- v257
                                    ()
                                let v259 : num_complex_Complex<float> = v234.l1
                                v259
                            else
                                let v260 : float = method38()
                                let v261 : float = method3(v260)
                                let v262 : float = method4()
                                let v263 : string = "num_complex::Complex::new(v261, v262)"
                                let v264 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v263
                                let v265 : string = "v264 - v217"
                                let v266 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v265
                                let v267 : string = $"        s = mpmath.gamma(s)"
                                let v268 : num_complex_Complex<float> = method8(v266)
                                let v269 : Result<num_complex_Complex<float>, std_string_String> = method41(v0, v267, v268)
                                let v270 : string = "v269.ok()"
                                let v271 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v270
                                let v272 : US0 = US0_0
                                let v273 : US0 = v271 |> Option.map v57 |> Option.defaultValue v272
                                let v274 : string = "f64::NAN"
                                let v275 : float = Fable.Core.RustInterop.emitRustExpr () v274
                                let v276 : string = "f64::NAN"
                                let v277 : float = Fable.Core.RustInterop.emitRustExpr () v276
                                let v278 : float = method31(v275)
                                let v279 : float = method3(v278)
                                let v280 : float = method32(v277)
                                let v281 : string = "num_complex::Complex::new(v279, v280)"
                                let v282 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v281
                                let v285 : num_complex_Complex<float> =
                                    match v273 with
                                    | US0_0 -> (* None *)
                                        v282
                                    | US0_1(v283) -> (* Some *)
                                        v283
                                let v286 : float = method42()
                                let v287 : float = method3(v286)
                                let v288 : float = method4()
                                let v289 : string = "num_complex::Complex::new(v287, v288)"
                                let v290 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v289
                                let v291 : string = "v290 * v217"
                                let v292 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v291
                                let v293 : float = method2()
                                let v294 : float = method3(v293)
                                let v295 : float = method4()
                                let v296 : string = "num_complex::Complex::new(v294, v295)"
                                let v297 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v296
                                let v298 : string = "v292 / v297"
                                let v299 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v298
                                let v300 : string = "v299.sin()"
                                let v301 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v300
                                let v302 : num_complex_Complex<float> = method13(v217)
                                let v303 : string = "v302.re"
                                let v304 : float = Fable.Core.RustInterop.emitRustExpr () v303
                                let v305 : float = 1.0 - v304
                                let v306 : num_complex_Complex<float> = method14(v217)
                                let v307 : string = "v306.im"
                                let v308 : float = Fable.Core.RustInterop.emitRustExpr () v307
                                let v309 : float =  -v308
                                let v310 : float = method31(v305)
                                let v311 : float = method3(v310)
                                let v312 : float = method32(v309)
                                let v313 : string = "num_complex::Complex::new(v311, v312)"
                                let v314 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v313
                                let v315 : num_complex_Complex<float> = method13(v314)
                                let v316 : string = "v315.re"
                                let v317 : float = Fable.Core.RustInterop.emitRustExpr () v316
                                let v318 : bool = v317 <= 1.0
                                let v586 : num_complex_Complex<float> =
                                    if v318 then
                                        let v319 : float = method35()
                                        let v320 : float = method3(v319)
                                        let v321 : float = method4()
                                        let v322 : string = "num_complex::Complex::new(v320, v321)"
                                        let v323 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v322
                                        v323
                                    else
                                        let v324 : num_complex_Complex<float> = method34(v314)
                                        let v325 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 3, v324)"
                                        Fable.Core.RustInterop.emitRustExpr () v325
                                        let v326 : num_complex_Complex<float> = method13(v324)
                                        let v327 : string = "v326.re"
                                        let v328 : float = Fable.Core.RustInterop.emitRustExpr () v327
                                        let v329 : bool = v328 > 1.0
                                        if v329 then
                                            let v330 : float = method35()
                                            let v331 : float = method3(v330)
                                            let v332 : float = method4()
                                            let v333 : string = "num_complex::Complex::new(v331, v332)"
                                            let v334 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v333
                                            let v335 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v336 : Mut0 = {l0 = 0} : Mut0
                                            while method36(v336) do
                                                let v338 : int32 = v336.l0
                                                v335.[int v338] <- v338
                                                let v339 : int32 = v338 + 1
                                                v336.l0 <- v339
                                                ()
                                            let v340 : int32 = v335.Length
                                            let v341 : Mut2 = {l0 = 0; l1 = v334} : Mut2
                                            while method37(v340, v341) do
                                                let v343 : int32 = v341.l0
                                                let v344 : num_complex_Complex<float> = v341.l1
                                                let v345 : int32 = v335.[int v343]
                                                let v346 : float = method38()
                                                let v347 : float = method3(v346)
                                                let v348 : float = method4()
                                                let v349 : string = "num_complex::Complex::new(v347, v348)"
                                                let v350 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v349
                                                let v351 : float = float v345
                                                let v352 : float = method31(v351)
                                                let v353 : float = method3(v352)
                                                let v354 : float = method4()
                                                let v355 : string = "num_complex::Complex::new(v353, v354)"
                                                let v356 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v355
                                                let v357 : num_complex_Complex<float> = method39(v356)
                                                let v358 : num_complex_Complex<float> = method40(v324)
                                                let v359 : string = "num_complex::Complex::powc(v357, v358)"
                                                let v360 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v359
                                                let v361 : string = "v350 / v360"
                                                let v362 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v361
                                                let v363 : string = "v344 + v362"
                                                let v364 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v363
                                                let v365 : int32 = v343 + 1
                                                v341.l0 <- v365
                                                v341.l1 <- v364
                                                ()
                                            let v366 : num_complex_Complex<float> = v341.l1
                                            v366
                                        else
                                            let v367 : float = method38()
                                            let v368 : float = method3(v367)
                                            let v369 : float = method4()
                                            let v370 : string = "num_complex::Complex::new(v368, v369)"
                                            let v371 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v370
                                            let v372 : string = "v371 - v324"
                                            let v373 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v372
                                            let v374 : string = $"        s = mpmath.gamma(s)"
                                            let v375 : num_complex_Complex<float> = method8(v373)
                                            let v376 : Result<num_complex_Complex<float>, std_string_String> = method41(v0, v374, v375)
                                            let v377 : string = "v376.ok()"
                                            let v378 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v377
                                            let v379 : US0 = US0_0
                                            let v380 : US0 = v378 |> Option.map v57 |> Option.defaultValue v379
                                            let v381 : string = "f64::NAN"
                                            let v382 : float = Fable.Core.RustInterop.emitRustExpr () v381
                                            let v383 : string = "f64::NAN"
                                            let v384 : float = Fable.Core.RustInterop.emitRustExpr () v383
                                            let v385 : float = method31(v382)
                                            let v386 : float = method3(v385)
                                            let v387 : float = method32(v384)
                                            let v388 : string = "num_complex::Complex::new(v386, v387)"
                                            let v389 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v388
                                            let v392 : num_complex_Complex<float> =
                                                match v380 with
                                                | US0_0 -> (* None *)
                                                    v389
                                                | US0_1(v390) -> (* Some *)
                                                    v390
                                            let v393 : float = method42()
                                            let v394 : float = method3(v393)
                                            let v395 : float = method4()
                                            let v396 : string = "num_complex::Complex::new(v394, v395)"
                                            let v397 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v396
                                            let v398 : string = "v397 * v324"
                                            let v399 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v398
                                            let v400 : float = method2()
                                            let v401 : float = method3(v400)
                                            let v402 : float = method4()
                                            let v403 : string = "num_complex::Complex::new(v401, v402)"
                                            let v404 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v403
                                            let v405 : string = "v399 / v404"
                                            let v406 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v405
                                            let v407 : string = "v406.sin()"
                                            let v408 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v407
                                            let v409 : num_complex_Complex<float> = method13(v324)
                                            let v410 : string = "v409.re"
                                            let v411 : float = Fable.Core.RustInterop.emitRustExpr () v410
                                            let v412 : float = 1.0 - v411
                                            let v413 : num_complex_Complex<float> = method14(v324)
                                            let v414 : string = "v413.im"
                                            let v415 : float = Fable.Core.RustInterop.emitRustExpr () v414
                                            let v416 : float =  -v415
                                            let v417 : float = method31(v412)
                                            let v418 : float = method3(v417)
                                            let v419 : float = method32(v416)
                                            let v420 : string = "num_complex::Complex::new(v418, v419)"
                                            let v421 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v420
                                            let v422 : num_complex_Complex<float> = method13(v421)
                                            let v423 : string = "v422.re"
                                            let v424 : float = Fable.Core.RustInterop.emitRustExpr () v423
                                            let v425 : bool = v424 <= 1.0
                                            let v562 : num_complex_Complex<float> =
                                                if v425 then
                                                    let v426 : float = method35()
                                                    let v427 : float = method3(v426)
                                                    let v428 : float = method4()
                                                    let v429 : string = "num_complex::Complex::new(v427, v428)"
                                                    let v430 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v429
                                                    v430
                                                else
                                                    let v431 : num_complex_Complex<float> = method34(v421)
                                                    let v432 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 4, v431)"
                                                    Fable.Core.RustInterop.emitRustExpr () v432
                                                    let v433 : num_complex_Complex<float> = method13(v431)
                                                    let v434 : string = "v433.re"
                                                    let v435 : float = Fable.Core.RustInterop.emitRustExpr () v434
                                                    let v436 : bool = v435 > 1.0
                                                    if v436 then
                                                        let v437 : float = method35()
                                                        let v438 : float = method3(v437)
                                                        let v439 : float = method4()
                                                        let v440 : string = "num_complex::Complex::new(v438, v439)"
                                                        let v441 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v440
                                                        let v442 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v443 : Mut0 = {l0 = 0} : Mut0
                                                        while method36(v443) do
                                                            let v445 : int32 = v443.l0
                                                            v442.[int v445] <- v445
                                                            let v446 : int32 = v445 + 1
                                                            v443.l0 <- v446
                                                            ()
                                                        let v447 : int32 = v442.Length
                                                        let v448 : Mut2 = {l0 = 0; l1 = v441} : Mut2
                                                        while method37(v447, v448) do
                                                            let v450 : int32 = v448.l0
                                                            let v451 : num_complex_Complex<float> = v448.l1
                                                            let v452 : int32 = v442.[int v450]
                                                            let v453 : float = method38()
                                                            let v454 : float = method3(v453)
                                                            let v455 : float = method4()
                                                            let v456 : string = "num_complex::Complex::new(v454, v455)"
                                                            let v457 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v456
                                                            let v458 : float = float v452
                                                            let v459 : float = method31(v458)
                                                            let v460 : float = method3(v459)
                                                            let v461 : float = method4()
                                                            let v462 : string = "num_complex::Complex::new(v460, v461)"
                                                            let v463 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v462
                                                            let v464 : num_complex_Complex<float> = method39(v463)
                                                            let v465 : num_complex_Complex<float> = method40(v431)
                                                            let v466 : string = "num_complex::Complex::powc(v464, v465)"
                                                            let v467 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v466
                                                            let v468 : string = "v457 / v467"
                                                            let v469 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v468
                                                            let v470 : string = "v451 + v469"
                                                            let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v470
                                                            let v472 : int32 = v450 + 1
                                                            v448.l0 <- v472
                                                            v448.l1 <- v471
                                                            ()
                                                        let v473 : num_complex_Complex<float> = v448.l1
                                                        v473
                                                    else
                                                        let v474 : float = method38()
                                                        let v475 : float = method3(v474)
                                                        let v476 : float = method4()
                                                        let v477 : string = "num_complex::Complex::new(v475, v476)"
                                                        let v478 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v477
                                                        let v479 : string = "v478 - v431"
                                                        let v480 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v479
                                                        let v481 : string = $"        s = mpmath.gamma(s)"
                                                        let v482 : num_complex_Complex<float> = method8(v480)
                                                        let v483 : Result<num_complex_Complex<float>, std_string_String> = method41(v0, v481, v482)
                                                        let v484 : string = "v483.ok()"
                                                        let v485 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v484
                                                        let v486 : US0 = US0_0
                                                        let v487 : US0 = v485 |> Option.map v57 |> Option.defaultValue v486
                                                        let v488 : string = "f64::NAN"
                                                        let v489 : float = Fable.Core.RustInterop.emitRustExpr () v488
                                                        let v490 : string = "f64::NAN"
                                                        let v491 : float = Fable.Core.RustInterop.emitRustExpr () v490
                                                        let v492 : float = method31(v489)
                                                        let v493 : float = method3(v492)
                                                        let v494 : float = method32(v491)
                                                        let v495 : string = "num_complex::Complex::new(v493, v494)"
                                                        let v496 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v495
                                                        let v499 : num_complex_Complex<float> =
                                                            match v487 with
                                                            | US0_0 -> (* None *)
                                                                v496
                                                            | US0_1(v497) -> (* Some *)
                                                                v497
                                                        let v500 : float = method42()
                                                        let v501 : float = method3(v500)
                                                        let v502 : float = method4()
                                                        let v503 : string = "num_complex::Complex::new(v501, v502)"
                                                        let v504 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v503
                                                        let v505 : string = "v504 * v431"
                                                        let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v505
                                                        let v507 : float = method2()
                                                        let v508 : float = method3(v507)
                                                        let v509 : float = method4()
                                                        let v510 : string = "num_complex::Complex::new(v508, v509)"
                                                        let v511 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v510
                                                        let v512 : string = "v506 / v511"
                                                        let v513 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v512
                                                        let v514 : string = "v513.sin()"
                                                        let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v514
                                                        let v516 : num_complex_Complex<float> = method13(v431)
                                                        let v517 : string = "v516.re"
                                                        let v518 : float = Fable.Core.RustInterop.emitRustExpr () v517
                                                        let v519 : float = 1.0 - v518
                                                        let v520 : num_complex_Complex<float> = method14(v431)
                                                        let v521 : string = "v520.im"
                                                        let v522 : float = Fable.Core.RustInterop.emitRustExpr () v521
                                                        let v523 : float =  -v522
                                                        let v524 : float = method31(v519)
                                                        let v525 : float = method3(v524)
                                                        let v526 : float = method32(v523)
                                                        let v527 : string = "num_complex::Complex::new(v525, v526)"
                                                        let v528 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v527
                                                        let v529 : num_complex_Complex<float> = method13(v528)
                                                        let v530 : string = "v529.re"
                                                        let v531 : float = Fable.Core.RustInterop.emitRustExpr () v530
                                                        let v532 : bool = v531 <= 1.0
                                                        let v538 : num_complex_Complex<float> =
                                                            if v532 then
                                                                let v533 : float = method35()
                                                                let v534 : float = method3(v533)
                                                                let v535 : float = method4()
                                                                let v536 : string = "num_complex::Complex::new(v534, v535)"
                                                                let v537 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v536
                                                                v537
                                                            else
                                                                v528
                                                        let v539 : float = method2()
                                                        let v540 : float = method3(v539)
                                                        let v541 : float = method4()
                                                        let v542 : string = "num_complex::Complex::new(v540, v541)"
                                                        let v543 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v542
                                                        let v544 : float = method42()
                                                        let v545 : float = method3(v544)
                                                        let v546 : float = method4()
                                                        let v547 : string = "num_complex::Complex::new(v545, v546)"
                                                        let v548 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v547
                                                        let v549 : num_complex_Complex<float> = method39(v548)
                                                        let v550 : num_complex_Complex<float> = method40(v431)
                                                        let v551 : string = "num_complex::Complex::powc(v549, v550)"
                                                        let v552 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v551
                                                        let v553 : string = "v543 * v552"
                                                        let v554 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v553
                                                        let v555 : string = "v554 * v515"
                                                        let v556 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v555
                                                        let v557 : string = "v556 * v499"
                                                        let v558 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v557
                                                        let v559 : string = "v558 * v538"
                                                        let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v559
                                                        v560
                                            let v563 : float = method2()
                                            let v564 : float = method3(v563)
                                            let v565 : float = method4()
                                            let v566 : string = "num_complex::Complex::new(v564, v565)"
                                            let v567 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v566
                                            let v568 : float = method42()
                                            let v569 : float = method3(v568)
                                            let v570 : float = method4()
                                            let v571 : string = "num_complex::Complex::new(v569, v570)"
                                            let v572 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v571
                                            let v573 : num_complex_Complex<float> = method39(v572)
                                            let v574 : num_complex_Complex<float> = method40(v324)
                                            let v575 : string = "num_complex::Complex::powc(v573, v574)"
                                            let v576 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v575
                                            let v577 : string = "v567 * v576"
                                            let v578 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v577
                                            let v579 : string = "v578 * v408"
                                            let v580 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v579
                                            let v581 : string = "v580 * v392"
                                            let v582 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v581
                                            let v583 : string = "v582 * v562"
                                            let v584 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v583
                                            v584
                                let v587 : float = method2()
                                let v588 : float = method3(v587)
                                let v589 : float = method4()
                                let v590 : string = "num_complex::Complex::new(v588, v589)"
                                let v591 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v590
                                let v592 : float = method42()
                                let v593 : float = method3(v592)
                                let v594 : float = method4()
                                let v595 : string = "num_complex::Complex::new(v593, v594)"
                                let v596 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v595
                                let v597 : num_complex_Complex<float> = method39(v596)
                                let v598 : num_complex_Complex<float> = method40(v217)
                                let v599 : string = "num_complex::Complex::powc(v597, v598)"
                                let v600 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v599
                                let v601 : string = "v591 * v600"
                                let v602 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v601
                                let v603 : string = "v602 * v301"
                                let v604 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v603
                                let v605 : string = "v604 * v285"
                                let v606 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v605
                                let v607 : string = "v606 * v586"
                                let v608 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v607
                                v608
                    let v611 : float = method2()
                    let v612 : float = method3(v611)
                    let v613 : float = method4()
                    let v614 : string = "num_complex::Complex::new(v612, v613)"
                    let v615 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v614
                    let v616 : float = method42()
                    let v617 : float = method3(v616)
                    let v618 : float = method4()
                    let v619 : string = "num_complex::Complex::new(v617, v618)"
                    let v620 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v619
                    let v621 : num_complex_Complex<float> = method39(v620)
                    let v622 : num_complex_Complex<float> = method40(v110)
                    let v623 : string = "num_complex::Complex::powc(v621, v622)"
                    let v624 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v623
                    let v625 : string = "v615 * v624"
                    let v626 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v625
                    let v627 : string = "v626 * v194"
                    let v628 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v627
                    let v629 : string = "v628 * v178"
                    let v630 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v629
                    let v631 : string = "v630 * v610"
                    let v632 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v631
                    v632
        let v635 : float = method2()
        let v636 : float = method3(v635)
        let v637 : float = method4()
        let v638 : string = "num_complex::Complex::new(v636, v637)"
        let v639 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v638
        let v640 : float = method42()
        let v641 : float = method3(v640)
        let v642 : float = method4()
        let v643 : string = "num_complex::Complex::new(v641, v642)"
        let v644 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v643
        let v645 : num_complex_Complex<float> = method39(v644)
        let v646 : num_complex_Complex<float> = method40(v2)
        let v647 : string = "num_complex::Complex::powc(v645, v646)"
        let v648 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v647
        let v649 : string = "v639 * v648"
        let v650 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v649
        let v651 : string = "v650 * v87"
        let v652 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v651
        let v653 : string = "v652 * v71"
        let v654 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v653
        let v655 : string = "v654 * v634"
        let v656 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v655
        v656
and method43 (v0 : bool) : bool =
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
        let v19 : string = $"        s = mpmath.zeta(s)"
        let v20 : num_complex_Complex<float> = method8(v17)
        let v21 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v19, v20)
        let v22 : num_complex_Complex<float> = method33(v0, v17)
        let v23 : string = "v21.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : (num_complex_Complex<float> -> US0) = closure5()
        let v26 : US0 = US0_0
        let v27 : US0 = v24 |> Option.map v25 |> Option.defaultValue v26
        let v28 : string = "f64::NAN"
        let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
        let v30 : string = "f64::NAN"
        let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30
        let v32 : float = method31(v29)
        let v33 : float = method3(v32)
        let v34 : float = method32(v31)
        let v35 : string = "num_complex::Complex::new(v33, v34)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v35
        let v39 : num_complex_Complex<float> =
            match v27 with
            | US0_0 -> (* None *)
                v36
            | US0_1(v37) -> (* Some *)
                v37
        let v40 : num_complex_Complex<float> = method14(v39)
        let v41 : string = "v40.im"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41
        let v43 : bool = v42 = 0.0
        let v45 : bool =
            if v43 then
                true
            else
                method43(v43)
        let v46 : string = $"__expect / actual: %A{v42} / expected: %A{0.0}"
        let v47 : bool = v45 = false
        if v47 then
            failwith<unit> v46
        let v48 : num_complex_Complex<float> = method13(v39)
        let v49 : string = "v48.re"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : float = v50 - v18
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
                method43(v55)
        let v58 : string = $"__expect / actual: %A{v54} / expected: %A{0.0001}"
        let v59 : bool = v57 = false
        if v59 then
            failwith<unit> v58
        let v60 : int32 = v16 + 1
        v14.l0 <- v60
        ()
    ()
and method44 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method45 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method48 () : float =
    -2.0
and method47 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method48()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"        s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v6, v7)
    let v9 : num_complex_Complex<float> = method33(v0, v5)
    let v10 : string = "v8.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (num_complex_Complex<float> -> US0) = closure5()
    let v13 : US0 = US0_0
    let v14 : US0 = v11 |> Option.map v12 |> Option.defaultValue v13
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float = method31(v16)
    let v20 : float = method3(v19)
    let v21 : float = method32(v18)
    let v22 : string = "num_complex::Complex::new(v20, v21)"
    let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
    let v26 : num_complex_Complex<float> =
        match v14 with
        | US0_0 -> (* None *)
            v23
        | US0_1(v24) -> (* Some *)
            v24
    let v27 : num_complex_Complex<float> = method13(v26)
    let v28 : string = "v27.re"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : float = v29 - 0.8673
    let v31 : float =  -v30
    let v32 : bool = v30 >= v31
    let v33 : float =
        if v32 then
            v30
        else
            v31
    let v34 : bool = v33 < 0.001
    let v36 : bool =
        if v34 then
            true
        else
            method43(v34)
    let v37 : string = $"__expect / actual: %A{v33} / expected: %A{0.001}"
    let v38 : bool = v36 = false
    if v38 then
        failwith<unit> v37
    let v39 : num_complex_Complex<float> = method14(v26)
    let v40 : string = "v39.im"
    let v41 : float = Fable.Core.RustInterop.emitRustExpr () v40
    let v42 : float = v41 - 0.275
    let v43 : float =  -v42
    let v44 : bool = v42 >= v43
    let v45 : float =
        if v44 then
            v42
        else
            v43
    let v46 : bool = v45 < 0.001
    let v48 : bool =
        if v46 then
            true
        else
            method43(v46)
    let v49 : string = $"__expect / actual: %A{v45} / expected: %A{0.001}"
    let v50 : bool = v48 = false
    if v50 then
        failwith<unit> v49
and method46 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method47(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method51 () : UH0 =
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
and method52 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_0(v2, v3) -> (* Cons *)
        let v4 : float = method31(v2)
        let v5 : float = method3(v4)
        let v6 : float = method4()
        let v7 : string = "num_complex::Complex::new(v5, v6)"
        let v8 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v7
        let v9 : string = $"        s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method8(v8)
        let v11 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v9, v10)
        let v12 : num_complex_Complex<float> = method33(v0, v8)
        let v13 : string = "v11.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : (num_complex_Complex<float> -> US0) = closure5()
        let v16 : US0 = US0_0
        let v17 : US0 = v14 |> Option.map v15 |> Option.defaultValue v16
        let v18 : string = "f64::NAN"
        let v19 : float = Fable.Core.RustInterop.emitRustExpr () v18
        let v20 : string = "f64::NAN"
        let v21 : float = Fable.Core.RustInterop.emitRustExpr () v20
        let v22 : float = method31(v19)
        let v23 : float = method3(v22)
        let v24 : float = method32(v21)
        let v25 : string = "num_complex::Complex::new(v23, v24)"
        let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v25
        let v29 : num_complex_Complex<float> =
            match v17 with
            | US0_0 -> (* None *)
                v26
            | US0_1(v27) -> (* Some *)
                v27
        let v30 : num_complex_Complex<float> = method13(v29)
        let v31 : string = "v30.re"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : bool = v32 = 0.0
        let v35 : bool =
            if v33 then
                true
            else
                method43(v33)
        let v36 : string = $"__expect / actual: %A{v32} / expected: %A{0.0}"
        let v37 : bool = v35 = false
        if v37 then
            failwith<unit> v36
        let v38 : num_complex_Complex<float> = method14(v29)
        let v39 : string = "v38.im"
        let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : bool = v40 = 0.0
        let v43 : bool =
            if v41 then
                true
            else
                method43(v41)
        let v44 : string = $"__expect / actual: %A{v40} / expected: %A{0.0}"
        let v45 : bool = v43 = false
        if v45 then
            failwith<unit> v44
        method52(v0, v3)
    | UH0_1 -> (* Nil *)
        ()
and method50 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method51()
    method52(v0, v1)
and method49 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method50(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method55 () : float =
    0.5
and method56 () : float =
    14.134725
and method57 () : float =
    21.02204
and method58 () : float =
    25.010857
and method59 () : float =
    30.424876
and method60 () : float =
    32.935062
and method61 () : float =
    37.586178
and method62 (v0 : (num_complex_Complex<float> [])) : (num_complex_Complex<float> []) =
    v0
and method54 (v0 : pyo3_Python) : unit =
    let v1 : float = method55()
    let v2 : float = method3(v1)
    let v3 : float = method56()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method55()
    let v7 : float = method3(v6)
    let v8 : float = method57()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method55()
    let v12 : float = method3(v11)
    let v13 : float = method58()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method55()
    let v17 : float = method3(v16)
    let v18 : float = method59()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method55()
    let v22 : float = method3(v21)
    let v23 : float = method60()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : float = method55()
    let v27 : float = method3(v26)
    let v28 : float = method61()
    let v29 : string = "num_complex::Complex::new(v27, v28)"
    let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
    let v31 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25; v30|]
    let v32 : (num_complex_Complex<float> []) = method62(v31)
    let v33 : int32 = v32.Length
    let v34 : Mut0 = {l0 = 0} : Mut0
    while method7(v33, v34) do
        let v36 : int32 = v34.l0
        let v37 : num_complex_Complex<float> = v32.[int v36]
        let v38 : string = $"        s = mpmath.zeta(s)"
        let v39 : num_complex_Complex<float> = method8(v37)
        let v40 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v38, v39)
        let v41 : num_complex_Complex<float> = method33(v0, v37)
        let v42 : string = "v40.ok()"
        let v43 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : (num_complex_Complex<float> -> US0) = closure5()
        let v45 : US0 = US0_0
        let v46 : US0 = v43 |> Option.map v44 |> Option.defaultValue v45
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : float = method31(v48)
        let v52 : float = method3(v51)
        let v53 : float = method32(v50)
        let v54 : string = "num_complex::Complex::new(v52, v53)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v54
        let v58 : num_complex_Complex<float> =
            match v46 with
            | US0_0 -> (* None *)
                v55
            | US0_1(v56) -> (* Some *)
                v56
        let v59 : num_complex_Complex<float> = method13(v58)
        let v60 : string = "v59.re"
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
                method43(v65)
        let v68 : string = $"__expect / actual: %A{v64} / expected: %A{0.0001}"
        let v69 : bool = v67 = false
        if v69 then
            failwith<unit> v68
        let v70 : num_complex_Complex<float> = method14(v58)
        let v71 : string = "v70.im"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71
        let v73 : float =  -v72
        let v74 : bool = v72 >= v73
        let v75 : float =
            if v74 then
                v72
            else
                v73
        let v76 : bool = v75 < 0.0001
        let v78 : bool =
            if v76 then
                true
            else
                method43(v76)
        let v79 : string = $"__expect / actual: %A{v75} / expected: %A{0.0001}"
        let v80 : bool = v78 = false
        if v80 then
            failwith<unit> v79
        let v81 : int32 = v36 + 1
        v34.l0 <- v81
        ()
    ()
and method53 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method54(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method65 (v0 : (float [])) : (float []) =
    v0
and method64 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 3.0; 4.0; 5.0; 10.0; 20.0; 50.0|]
    let v2 : (float []) = method65(v1)
    let v3 : int32 = v2.Length
    let v4 : Mut0 = {l0 = 0} : Mut0
    while method7(v3, v4) do
        let v6 : int32 = v4.l0
        let v7 : float = v2.[int v6]
        let v8 : float = method31(v7)
        let v9 : float = method3(v8)
        let v10 : float = method4()
        let v11 : string = "num_complex::Complex::new(v9, v10)"
        let v12 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v11
        let v13 : string = $"        s = mpmath.zeta(s)"
        let v14 : num_complex_Complex<float> = method8(v12)
        let v15 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v13, v14)
        let v16 : num_complex_Complex<float> = method33(v0, v12)
        let v17 : string = "v15.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v17
        let v19 : (num_complex_Complex<float> -> US0) = closure5()
        let v20 : US0 = US0_0
        let v21 : US0 = v18 |> Option.map v19 |> Option.defaultValue v20
        let v22 : string = "f64::NAN"
        let v23 : float = Fable.Core.RustInterop.emitRustExpr () v22
        let v24 : string = "f64::NAN"
        let v25 : float = Fable.Core.RustInterop.emitRustExpr () v24
        let v26 : float = method31(v23)
        let v27 : float = method3(v26)
        let v28 : float = method32(v25)
        let v29 : string = "num_complex::Complex::new(v27, v28)"
        let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v29
        let v33 : num_complex_Complex<float> =
            match v21 with
            | US0_0 -> (* None *)
                v30
            | US0_1(v31) -> (* Some *)
                v31
        let v34 : num_complex_Complex<float> = method13(v33)
        let v35 : string = "v34.re"
        let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35
        let v37 : bool = v36 > 0.0
        let v39 : bool =
            if v37 then
                true
            else
                method43(v37)
        let v40 : string = $"__expect / actual: %A{v36} / expected: %A{0.0}"
        let v41 : bool = v39 = false
        if v41 then
            failwith<unit> v40
        let v42 : num_complex_Complex<float> = method14(v33)
        let v43 : string = "v42.im"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : bool = v44 = 0.0
        let v47 : bool =
            if v45 then
                true
            else
                method43(v45)
        let v48 : string = $"__expect / actual: %A{v44} / expected: %A{0.0}"
        let v49 : bool = v47 = false
        if v49 then
            failwith<unit> v48
        let v50 : int32 = v6 + 1
        v4.l0 <- v50
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
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method67 (v0 : pyo3_Python) : unit =
    let v1 : float = method38()
    let v2 : float = method3(v1)
    let v3 : float = method4()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"        s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v6, v7)
    let v9 : num_complex_Complex<float> = method33(v0, v5)
    let v10 : string = "v8.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (num_complex_Complex<float> -> US0) = closure5()
    let v13 : US0 = US0_0
    let v14 : US0 = v11 |> Option.map v12 |> Option.defaultValue v13
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float = method31(v16)
    let v20 : float = method3(v19)
    let v21 : float = method32(v18)
    let v22 : string = "num_complex::Complex::new(v20, v21)"
    let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
    let v26 : num_complex_Complex<float> =
        match v14 with
        | US0_0 -> (* None *)
            v23
        | US0_1(v24) -> (* Some *)
            v24
    let v27 : num_complex_Complex<float> = method13(v26)
    let v28 : string = "v27.re"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : bool = v29 = infinity
    let v32 : bool =
        if v30 then
            true
        else
            method43(v30)
    let v33 : string = $"__expect / actual: %A{v29} / expected: %A{infinity}"
    let v34 : bool = v32 = false
    if v34 then
        failwith<unit> v33
    let v35 : num_complex_Complex<float> = method14(v26)
    let v36 : string = "v35.im"
    let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : bool = v37 = 0.0
    let v40 : bool =
        if v38 then
            true
        else
            method43(v38)
    let v41 : string = $"__expect / actual: %A{v37} / expected: %A{0.0}"
    let v42 : bool = v40 = false
    if v42 then
        failwith<unit> v41
and method66 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method67(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method70 () : float =
    10.0
and method69 (v0 : pyo3_Python) : unit =
    let v1 : float = method2()
    let v2 : float = method3(v1)
    let v3 : float = method70()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"        s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v6, v7)
    let v9 : num_complex_Complex<float> = method33(v0, v5)
    let v10 : string = "v8.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (num_complex_Complex<float> -> US0) = closure5()
    let v13 : US0 = US0_0
    let v14 : US0 = v11 |> Option.map v12 |> Option.defaultValue v13
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float = method31(v16)
    let v20 : float = method3(v19)
    let v21 : float = method32(v18)
    let v22 : string = "num_complex::Complex::new(v20, v21)"
    let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
    let v26 : num_complex_Complex<float> =
        match v14 with
        | US0_0 -> (* None *)
            v23
        | US0_1(v24) -> (* Some *)
            v24
    let v27 : num_complex_Complex<float> = method13(v5)
    let v28 : string = "v27.re"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : num_complex_Complex<float> = method14(v5)
    let v31 : string = "v30.im"
    let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31
    let v33 : float =  -v32
    let v34 : float = method31(v29)
    let v35 : float = method3(v34)
    let v36 : float = method32(v33)
    let v37 : string = "num_complex::Complex::new(v35, v36)"
    let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v37
    let v39 : string = $"        s = mpmath.zeta(s)"
    let v40 : num_complex_Complex<float> = method8(v38)
    let v41 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v39, v40)
    let v42 : num_complex_Complex<float> = method33(v0, v38)
    let v43 : string = "v41.ok()"
    let v44 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v43
    let v45 : US0 = US0_0
    let v46 : US0 = v44 |> Option.map v12 |> Option.defaultValue v45
    let v47 : string = "f64::NAN"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47
    let v49 : string = "f64::NAN"
    let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
    let v51 : float = method31(v48)
    let v52 : float = method3(v51)
    let v53 : float = method32(v50)
    let v54 : string = "num_complex::Complex::new(v52, v53)"
    let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v54
    let v58 : num_complex_Complex<float> =
        match v46 with
        | US0_0 -> (* None *)
            v55
        | US0_1(v56) -> (* Some *)
            v56
    let v59 : string = "v58.conj()"
    let v60 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v59
    let v61 : num_complex_Complex<float> = method13(v26)
    let v62 : string = "v61.re"
    let v63 : float = Fable.Core.RustInterop.emitRustExpr () v62
    let v64 : num_complex_Complex<float> = method13(v60)
    let v65 : string = "v64.re"
    let v66 : float = Fable.Core.RustInterop.emitRustExpr () v65
    let v67 : bool = v63 = v66
    let v69 : bool =
        if v67 then
            true
        else
            method43(v67)
    let v70 : string = $"__expect / actual: %A{v63} / expected: %A{v66}"
    let v71 : bool = v69 = false
    if v71 then
        failwith<unit> v70
    let v72 : num_complex_Complex<float> = method14(v26)
    let v73 : string = "v72.im"
    let v74 : float = Fable.Core.RustInterop.emitRustExpr () v73
    let v75 : num_complex_Complex<float> = method14(v60)
    let v76 : string = "v75.im"
    let v77 : float = Fable.Core.RustInterop.emitRustExpr () v76
    let v78 : bool = v74 = v77
    let v80 : bool =
        if v78 then
            true
        else
            method43(v78)
    let v81 : string = $"__expect / actual: %A{v74} / expected: %A{v77}"
    let v82 : bool = v80 = false
    if v82 then
        failwith<unit> v81
and method68 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method69(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method73 () : float =
    0.01
and method74 () : float =
    0.01
and method72 (v0 : pyo3_Python) : unit =
    let v1 : float = method73()
    let v2 : float = method3(v1)
    let v3 : float = method74()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : string = $"        s = mpmath.zeta(s)"
    let v7 : num_complex_Complex<float> = method8(v5)
    let v8 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v6, v7)
    let v9 : num_complex_Complex<float> = method33(v0, v5)
    let v10 : string = "v8.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10
    let v12 : (num_complex_Complex<float> -> US0) = closure5()
    let v13 : US0 = US0_0
    let v14 : US0 = v11 |> Option.map v12 |> Option.defaultValue v13
    let v15 : string = "f64::NAN"
    let v16 : float = Fable.Core.RustInterop.emitRustExpr () v15
    let v17 : string = "f64::NAN"
    let v18 : float = Fable.Core.RustInterop.emitRustExpr () v17
    let v19 : float = method31(v16)
    let v20 : float = method3(v19)
    let v21 : float = method32(v18)
    let v22 : string = "num_complex::Complex::new(v20, v21)"
    let v23 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v22
    let v26 : num_complex_Complex<float> =
        match v14 with
        | US0_0 -> (* None *)
            v23
        | US0_1(v24) -> (* Some *)
            v24
    let v27 : num_complex_Complex<float> = method13(v26)
    let v28 : string = "v27.re"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28
    let v30 : bool = v29 < infinity
    let v32 : bool =
        if v30 then
            true
        else
            method43(v30)
    let v33 : string = $"__expect / actual: %A{v29} / expected: %A{infinity}"
    let v34 : bool = v32 = false
    if v34 then
        failwith<unit> v33
    let v35 : num_complex_Complex<float> = method14(v26)
    let v36 : string = "v35.im"
    let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
    let v38 : bool = v37 < infinity
    let v40 : bool =
        if v38 then
            true
        else
            method43(v38)
    let v41 : string = $"__expect / actual: %A{v37} / expected: %A{infinity}"
    let v42 : bool = v40 = false
    if v42 then
        failwith<unit> v41
and method71 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method72(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method77 () : (float []) =
    let v0 : (float []) = [|10.0; 20.0; 30.0; 40.0; 50.0; 60.0; 70.0; 80.0; 90.0; 100.0|]
    let v1 : (float []) = method65(v0)
    v1
and method78 (v0 : bool) : bool =
    let v1 : bool = v0 = false
    v1
and method76 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = method77()
    let v2 : int32 = v1.Length
    let v3 : Mut0 = {l0 = 0} : Mut0
    while method7(v2, v3) do
        let v5 : int32 = v3.l0
        let v6 : float = v1.[int v5]
        let v7 : float = method35()
        let v8 : float = method3(v7)
        let v9 : float = method32(v6)
        let v10 : string = "num_complex::Complex::new(v8, v9)"
        let v11 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v10
        let v12 : string = $"        s = mpmath.zeta(s)"
        let v13 : num_complex_Complex<float> = method8(v11)
        let v14 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v12, v13)
        let v15 : num_complex_Complex<float> = method33(v0, v11)
        let v16 : string = "v14.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v16
        let v18 : (num_complex_Complex<float> -> US0) = closure5()
        let v19 : US0 = US0_0
        let v20 : US0 = v17 |> Option.map v18 |> Option.defaultValue v19
        let v21 : string = "f64::NAN"
        let v22 : float = Fable.Core.RustInterop.emitRustExpr () v21
        let v23 : string = "f64::NAN"
        let v24 : float = Fable.Core.RustInterop.emitRustExpr () v23
        let v25 : float = method31(v22)
        let v26 : float = method3(v25)
        let v27 : float = method32(v24)
        let v28 : string = "num_complex::Complex::new(v26, v27)"
        let v29 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v28
        let v32 : num_complex_Complex<float> =
            match v20 with
            | US0_0 -> (* None *)
                v29
            | US0_1(v30) -> (* Some *)
                v30
        let v33 : num_complex_Complex<float> = method13(v32)
        let v34 : string = "v33.re"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34
        let v36 : bool = v35 = 0.0
        let v37 : bool = method78(v36)
        let v39 : bool =
            if v37 then
                true
            else
                method43(v37)
        let v40 : string = $"__expect / actual: %A{v35} / expected: %A{0.0}"
        let v41 : bool = v39 = false
        if v41 then
            failwith<unit> v40
        let v42 : num_complex_Complex<float> = method14(v32)
        let v43 : string = "v42.im"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43
        let v45 : bool = v44 = 0.0
        let v46 : bool = method78(v45)
        let v48 : bool =
            if v46 then
                true
            else
                method43(v46)
        let v49 : string = $"__expect / actual: %A{v44} / expected: %A{0.0}"
        let v50 : bool = v48 = false
        if v50 then
            failwith<unit> v49
        let v51 : int32 = v5 + 1
        v3.l0 <- v51
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
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method81 () : float =
    0.75
and method82 () : float =
    20.5
and method83 () : float =
    1.25
and method84 () : float =
    30.1
and method85 () : float =
    0.25
and method86 () : float =
    40.0
and method87 () : float =
    50.0
and method80 (v0 : pyo3_Python) : unit =
    let v1 : float = method55()
    let v2 : float = method3(v1)
    let v3 : float = method56()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method81()
    let v7 : float = method3(v6)
    let v8 : float = method82()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method83()
    let v12 : float = method3(v11)
    let v13 : float = method84()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method85()
    let v17 : float = method3(v16)
    let v18 : float = method86()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : float = method38()
    let v22 : float = method3(v21)
    let v23 : float = method87()
    let v24 : string = "num_complex::Complex::new(v22, v23)"
    let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v24
    let v26 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20; v25|]
    let v27 : (num_complex_Complex<float> []) = method62(v26)
    let v28 : int32 = v27.Length
    let v29 : Mut0 = {l0 = 0} : Mut0
    while method7(v28, v29) do
        let v31 : int32 = v29.l0
        let v32 : num_complex_Complex<float> = v27.[int v31]
        let v33 : string = $"        s = mpmath.zeta(s)"
        let v34 : num_complex_Complex<float> = method8(v32)
        let v35 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v33, v34)
        let v36 : num_complex_Complex<float> = method33(v0, v32)
        let v37 : string = "v35.ok()"
        let v38 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : (num_complex_Complex<float> -> US0) = closure5()
        let v40 : US0 = US0_0
        let v41 : US0 = v38 |> Option.map v39 |> Option.defaultValue v40
        let v42 : string = "f64::NAN"
        let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42
        let v44 : string = "f64::NAN"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44
        let v46 : float = method31(v43)
        let v47 : float = method3(v46)
        let v48 : float = method32(v45)
        let v49 : string = "num_complex::Complex::new(v47, v48)"
        let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v49
        let v53 : num_complex_Complex<float> =
            match v41 with
            | US0_0 -> (* None *)
                v50
            | US0_1(v51) -> (* Some *)
                v51
        let v54 : num_complex_Complex<float> = method13(v53)
        let v55 : string = "v54.re"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr () v55
        let v57 : bool = v56 = 0.0
        let v58 : bool = method78(v57)
        let v60 : bool =
            if v58 then
                true
            else
                method43(v58)
        let v61 : string = $"__expect / actual: %A{v56} / expected: %A{0.0}"
        let v62 : bool = v60 = false
        if v62 then
            failwith<unit> v61
        let v63 : num_complex_Complex<float> = method14(v53)
        let v64 : string = "v63.im"
        let v65 : float = Fable.Core.RustInterop.emitRustExpr () v64
        let v66 : bool = v65 = 0.0
        let v67 : bool = method78(v66)
        let v69 : bool =
            if v67 then
                true
            else
                method43(v67)
        let v70 : string = $"__expect / actual: %A{v65} / expected: %A{0.0}"
        let v71 : bool = v69 = false
        if v71 then
            failwith<unit> v70
        let v72 : int32 = v31 + 1
        v29.l0 <- v72
        ()
    ()
and method79 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method80(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method90 () : float =
    3.0
and method91 () : float =
    4.0
and method92 () : float =
    2.5
and method93 () : float =
    -3.5
and method94 () : float =
    1.5
and method95 () : float =
    2.5
and method89 (v0 : pyo3_Python) : unit =
    let v1 : float = method90()
    let v2 : float = method3(v1)
    let v3 : float = method91()
    let v4 : string = "num_complex::Complex::new(v2, v3)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v4
    let v6 : float = method92()
    let v7 : float = method3(v6)
    let v8 : float = method93()
    let v9 : string = "num_complex::Complex::new(v7, v8)"
    let v10 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v9
    let v11 : float = method94()
    let v12 : float = method3(v11)
    let v13 : float = method95()
    let v14 : string = "num_complex::Complex::new(v12, v13)"
    let v15 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v14
    let v16 : float = method55()
    let v17 : float = method3(v16)
    let v18 : float = method56()
    let v19 : string = "num_complex::Complex::new(v17, v18)"
    let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v19
    let v21 : (num_complex_Complex<float> []) = [|v5; v10; v15; v20|]
    let v22 : (num_complex_Complex<float> []) = method62(v21)
    let v23 : int32 = v22.Length
    let v24 : Mut0 = {l0 = 0} : Mut0
    while method7(v23, v24) do
        let v26 : int32 = v24.l0
        let v27 : num_complex_Complex<float> = v22.[int v26]
        let v28 : string = $"        s = mpmath.zeta(s)"
        let v29 : num_complex_Complex<float> = method8(v27)
        let v30 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v28, v29)
        let v31 : num_complex_Complex<float> = method33(v0, v27)
        let v32 : string = "v30.ok()"
        let v33 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v32
        let v34 : (num_complex_Complex<float> -> US0) = closure5()
        let v35 : US0 = US0_0
        let v36 : US0 = v33 |> Option.map v34 |> Option.defaultValue v35
        let v37 : string = "f64::NAN"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37
        let v39 : string = "f64::NAN"
        let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39
        let v41 : float = method31(v38)
        let v42 : float = method3(v41)
        let v43 : float = method32(v40)
        let v44 : string = "num_complex::Complex::new(v42, v43)"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v44
        let v48 : num_complex_Complex<float> =
            match v36 with
            | US0_0 -> (* None *)
                v45
            | US0_1(v46) -> (* Some *)
                v46
        let v49 : float = method2()
        let v50 : float = method3(v49)
        let v51 : float = method4()
        let v52 : string = "num_complex::Complex::new(v50, v51)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v52
        let v54 : num_complex_Complex<float> = method39(v53)
        let v55 : num_complex_Complex<float> = method40(v27)
        let v56 : string = "num_complex::Complex::powc(v54, v55)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v56
        let v58 : float = method42()
        let v59 : float = method3(v58)
        let v60 : float = method4()
        let v61 : string = "num_complex::Complex::new(v59, v60)"
        let v62 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : float = method38()
        let v64 : float = method3(v63)
        let v65 : float = method4()
        let v66 : string = "num_complex::Complex::new(v64, v65)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v66
        let v68 : string = "v27 - v67"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v68
        let v70 : num_complex_Complex<float> = method39(v62)
        let v71 : num_complex_Complex<float> = method40(v69)
        let v72 : string = "num_complex::Complex::powc(v70, v71)"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v72
        let v74 : string = "v57 * v73"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v74
        let v76 : float = method42()
        let v77 : float = method3(v76)
        let v78 : float = method4()
        let v79 : string = "num_complex::Complex::new(v77, v78)"
        let v80 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v79
        let v81 : string = "v80 * v27"
        let v82 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v81
        let v83 : float = method2()
        let v84 : float = method3(v83)
        let v85 : float = method4()
        let v86 : string = "num_complex::Complex::new(v84, v85)"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v86
        let v88 : string = "v82 / v87"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v88
        let v90 : string = "v89.sin()"
        let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v90
        let v92 : string = "v75 * v91"
        let v93 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v92
        let v94 : float = method38()
        let v95 : float = method3(v94)
        let v96 : float = method4()
        let v97 : string = "num_complex::Complex::new(v95, v96)"
        let v98 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v97
        let v99 : string = "v98 - v27"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v99
        let v101 : string = $"        s = mpmath.gamma(s)"
        let v102 : num_complex_Complex<float> = method8(v100)
        let v103 : Result<num_complex_Complex<float>, std_string_String> = method41(v0, v101, v102)
        let v104 : string = "v103.ok()"
        let v105 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v104
        let v106 : US0 = US0_0
        let v107 : US0 = v105 |> Option.map v34 |> Option.defaultValue v106
        let v108 : string = "f64::NAN"
        let v109 : float = Fable.Core.RustInterop.emitRustExpr () v108
        let v110 : string = "f64::NAN"
        let v111 : float = Fable.Core.RustInterop.emitRustExpr () v110
        let v112 : float = method31(v109)
        let v113 : float = method3(v112)
        let v114 : float = method32(v111)
        let v115 : string = "num_complex::Complex::new(v113, v114)"
        let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v115
        let v119 : num_complex_Complex<float> =
            match v107 with
            | US0_0 -> (* None *)
                v116
            | US0_1(v117) -> (* Some *)
                v117
        let v120 : string = "v93 * v119"
        let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v120
        let v122 : num_complex_Complex<float> = method13(v27)
        let v123 : string = "v122.re"
        let v124 : float = Fable.Core.RustInterop.emitRustExpr () v123
        let v125 : float = 1.0 - v124
        let v126 : num_complex_Complex<float> = method14(v27)
        let v127 : string = "v126.im"
        let v128 : float = Fable.Core.RustInterop.emitRustExpr () v127
        let v129 : float =  -v128
        let v130 : float = method31(v125)
        let v131 : float = method3(v130)
        let v132 : float = method32(v129)
        let v133 : string = "num_complex::Complex::new(v131, v132)"
        let v134 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v133
        let v135 : string = $"        s = mpmath.zeta(s)"
        let v136 : num_complex_Complex<float> = method8(v134)
        let v137 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v135, v136)
        let v138 : num_complex_Complex<float> = method33(v0, v134)
        let v139 : string = "v137.ok()"
        let v140 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v139
        let v141 : US0 = US0_0
        let v142 : US0 = v140 |> Option.map v34 |> Option.defaultValue v141
        let v143 : string = "f64::NAN"
        let v144 : float = Fable.Core.RustInterop.emitRustExpr () v143
        let v145 : string = "f64::NAN"
        let v146 : float = Fable.Core.RustInterop.emitRustExpr () v145
        let v147 : float = method31(v144)
        let v148 : float = method3(v147)
        let v149 : float = method32(v146)
        let v150 : string = "num_complex::Complex::new(v148, v149)"
        let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v150
        let v154 : num_complex_Complex<float> =
            match v142 with
            | US0_0 -> (* None *)
                v151
            | US0_1(v152) -> (* Some *)
                v152
        let v155 : string = "v121 * v154"
        let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v155
        let v157 : num_complex_Complex<float> = method13(v48)
        let v158 : string = "v157.re"
        let v159 : float = Fable.Core.RustInterop.emitRustExpr () v158
        let v160 : num_complex_Complex<float> = method13(v156)
        let v161 : string = "v160.re"
        let v162 : float = Fable.Core.RustInterop.emitRustExpr () v161
        let v163 : float = v159 - v162
        let v164 : float =  -v163
        let v165 : bool = v163 >= v164
        let v166 : float =
            if v165 then
                v163
            else
                v164
        let v167 : bool = v166 < 0.0001
        let v169 : bool =
            if v167 then
                true
            else
                method43(v167)
        let v170 : string = $"__expect / actual: %A{v166} / expected: %A{0.0001}"
        let v171 : bool = v169 = false
        if v171 then
            failwith<unit> v170
        let v172 : num_complex_Complex<float> = method14(v48)
        let v173 : string = "v172.im"
        let v174 : float = Fable.Core.RustInterop.emitRustExpr () v173
        let v175 : num_complex_Complex<float> = method14(v156)
        let v176 : string = "v175.im"
        let v177 : float = Fable.Core.RustInterop.emitRustExpr () v176
        let v178 : float = v174 - v177
        let v179 : float =  -v178
        let v180 : bool = v178 >= v179
        let v181 : float =
            if v180 then
                v178
            else
                v179
        let v182 : bool = v181 < 0.0001
        let v184 : bool =
            if v182 then
                true
            else
                method43(v182)
        let v185 : string = $"__expect / actual: %A{v181} / expected: %A{0.0001}"
        let v186 : bool = v184 = false
        if v186 then
            failwith<unit> v185
        let v187 : int32 = v26 + 1
        v24.l0 <- v187
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
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
    let v11 : string = "v10.unwrap()"
    Fable.Core.RustInterop.emitRustExpr () v11
    ()
and method98 (v0 : int32, v1 : Mut3) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method97 (v0 : pyo3_Python) : unit =
    let v1 : (float []) = [|2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0|]
    let v2 : (float []) = method65(v1)
    let v3 : (float []) = [|2.0; 3.0; 5.0; 7.0; 11.0; 13.0; 17.0; 19.0; 23.0; 29.0; 31.0; 37.0; 41.0; 43.0; 47.0; 53.0; 59.0; 61.0; 67.0; 71.0|]
    let v4 : (float []) = method65(v3)
    let v5 : int32 = v2.Length
    let v6 : Mut0 = {l0 = 0} : Mut0
    while method7(v5, v6) do
        let v8 : int32 = v6.l0
        let v9 : float = v2.[int v8]
        let v10 : float = method31(v9)
        let v11 : float = method3(v10)
        let v12 : float = method4()
        let v13 : string = "num_complex::Complex::new(v11, v12)"
        let v14 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v13
        let v15 : int32 = v4.Length
        let v16 : Mut3 = {l0 = 0; l1 = 1.0} : Mut3
        while method98(v15, v16) do
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
        let v27 : string = $"        s = mpmath.zeta(s)"
        let v28 : num_complex_Complex<float> = method8(v14)
        let v29 : Result<num_complex_Complex<float>, std_string_String> = method9(v0, v27, v28)
        let v30 : num_complex_Complex<float> = method33(v0, v14)
        let v31 : string = "v29.ok()"
        let v32 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v31
        let v33 : (num_complex_Complex<float> -> US0) = closure5()
        let v34 : US0 = US0_0
        let v35 : US0 = v32 |> Option.map v33 |> Option.defaultValue v34
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36
        let v38 : string = "f64::NAN"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38
        let v40 : float = method31(v37)
        let v41 : float = method3(v40)
        let v42 : float = method32(v39)
        let v43 : string = "num_complex::Complex::new(v41, v42)"
        let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v43
        let v47 : num_complex_Complex<float> =
            match v35 with
            | US0_0 -> (* None *)
                v44
            | US0_1(v45) -> (* Some *)
                v45
        let v48 : num_complex_Complex<float> = method13(v47)
        let v49 : string = "v48.re"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49
        let v51 : float = v50 - v26
        let v52 : float =  -v51
        let v53 : bool = v51 >= v52
        let v54 : float =
            if v53 then
                v51
            else
                v52
        let v55 : bool = v54 < 0.01
        let v57 : bool =
            if v55 then
                true
            else
                method43(v55)
        let v58 : string = $"__expect / actual: %A{v54} / expected: %A{0.01}"
        let v59 : bool = v57 = false
        if v59 then
            failwith<unit> v58
        let v60 : num_complex_Complex<float> = method14(v47)
        let v61 : string = "v60.im"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr () v61
        let v63 : bool = v62 < 0.01
        let v65 : bool =
            if v63 then
                true
            else
                method43(v63)
        let v66 : string = $"__expect / actual: %A{v62} / expected: %A{0.01}"
        let v67 : bool = v65 = false
        if v67 then
            failwith<unit> v66
        let v68 : int32 = v8 + 1
        v6.l0 <- v68
        ()
    ()
and method96 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2
    method97(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok ()
    let v5 : Result<unit, pyo3_PyErr> = method44(v4)
    let v6 : string = "v5 }})"
    Fable.Core.RustInterop.emitRustExpr () v6
    let v7 : string = "{ //"
    Fable.Core.RustInterop.emitRustExpr () v7
    let v8 : string = "__result"
    let v9 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v8
    let v10 : Result<unit, pyo3_PyErr> = method45(v9)
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
    method46()
    let v3 : string = "} #[test] fn test_trivial_zero_at_negative_even___() { //"
    Fable.Core.RustInterop.emitRustExpr () v3
    method49()
    let v4 : string = "} #[test] fn test_non_trivial_zero___() { //"
    Fable.Core.RustInterop.emitRustExpr () v4
    method53()
    let v5 : string = "} #[test] fn test_real_part_greater_than_one___() { //"
    Fable.Core.RustInterop.emitRustExpr () v5
    method63()
    let v6 : string = "} #[test] fn test_zeta_at_1___() { //"
    Fable.Core.RustInterop.emitRustExpr () v6
    method66()
    let v7 : string = "} #[test] fn test_symmetry_across_real_axis___() { //"
    Fable.Core.RustInterop.emitRustExpr () v7
    method68()
    let v8 : string = "} #[test] fn test_behavior_near_origin___() { //"
    Fable.Core.RustInterop.emitRustExpr () v8
    method71()
    let v9 : string = "} #[test] fn test_imaginary_axis() { //"
    Fable.Core.RustInterop.emitRustExpr () v9
    method75()
    let v10 : string = "} #[test] fn test_critical_strip() { //"
    Fable.Core.RustInterop.emitRustExpr () v10
    method79()
    let v11 : string = "} #[test] fn test_reflection_formula_for_specific_value() { //"
    Fable.Core.RustInterop.emitRustExpr () v11
    method88()
    let v12 : string = "} #[test] fn test_euler_product_formula() { //"
    Fable.Core.RustInterop.emitRustExpr () v12
    method96()
and closure6 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    System.Console.WriteLine v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure6()
let main args = v1 args
()
