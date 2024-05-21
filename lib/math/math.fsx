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
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
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
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
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
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
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
    let v11 : std_string_String = match _v1 with Some x -> x | None -> failwith "base.run_target / _v1=None"
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
            let v22 : (int32 -> float) = float
            let v23 : float = v22 v19
            let v24 : string = "num_complex::Complex::new($0, $1)"
            let v25 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v23, 0.0) v24 
            let v26 : num_complex_Complex<float> = method22(v25)
            let v27 : num_complex_Complex<float> = method23(v1)
            let v28 : string = "num_complex::Complex::powc(v26, v27)"
            let v29 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v28 
            let v30 : string = "v21 / v29"
            let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v30 
            let v32 : string = "v18 + v31"
            let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v32 
            let v34 : int32 = v17 + 1
            v15.l0 <- v34
            v15.l1 <- v33
            ()
        let v35 : num_complex_Complex<float> = v15.l1
        v35
    else
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v36 
        let v38 : string = "$0 - $1"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v1) v38 
        let v40 : string = $"        s = mpmath.gamma(s)"
        let v41 : num_complex_Complex<float> = method3(v39)
        let v42 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v40, v41)
        let v43 : string = "v42.ok()"
        let v44 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v43 
        let v45 : US0 option = None
        let _v45 = ref v45 
        match v44 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v46 : num_complex_Complex<float> = x
        let v47 : US0 = US0_0(v46)
        v47 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v45.Value <- x
        let v48 : US0 option = _v45.Value 
        let v49 : US0 = US0_1
        let v50 : US0 = v48 |> Option.defaultValue v49 
        let v51 : string = "f64::NAN"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51 
        let v53 : string = "f64::NAN"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53 
        let v55 : string = "num_complex::Complex::new($0, $1)"
        let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v52, v54) v55 
        let v59 : num_complex_Complex<float> =
            match v50 with
            | US0_1 -> (* None *)
                v56
            | US0_0(v57) -> (* Some *)
                v57
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v60 
        let v62 : string = "$0 * $1"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v61, v1) v62 
        let v64 : string = "num_complex::Complex::new($0, $1)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v64 
        let v66 : string = "v63 / v65"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v66 
        let v68 : string = "v67.sin()"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v68 
        let v70 : num_complex_Complex<float> = method7(v1)
        let v71 : string = "v70.re"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71 
        let v73 : float = 1.0 - v72
        let v74 : num_complex_Complex<float> = method8(v1)
        let v75 : string = "v74.im"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr () v75 
        let v77 : float =  -v76
        let v78 : string = "num_complex::Complex::new($0, $1)"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v73, v77) v78 
        let v80 : num_complex_Complex<float> = method7(v79)
        let v81 : string = "v80.re"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr () v81 
        let v83 : bool = v82 <= 1.0
        let v494 : num_complex_Complex<float> =
            if v83 then
                let v84 : string = "num_complex::Complex::new($0, $1)"
                let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v84 
                v85
            else
                let v86 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 1, $0)"
                Fable.Core.RustInterop.emitRustExpr v79 v86 
                let v87 : num_complex_Complex<float> = method7(v79)
                let v88 : string = "v87.re"
                let v89 : float = Fable.Core.RustInterop.emitRustExpr () v88 
                let v90 : bool = v89 > 1.0
                if v90 then
                    let v91 : string = "num_complex::Complex::new($0, $1)"
                    let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v91 
                    let v93 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v94 : Mut0 = {l0 = 0} : Mut0
                    while method20(v94) do
                        let v96 : int32 = v94.l0
                        v93.[int v96] <- v96
                        let v97 : int32 = v96 + 1
                        v94.l0 <- v97
                        ()
                    let v98 : int32 = v93.Length
                    let v99 : Mut2 = {l0 = 0; l1 = v92} : Mut2
                    while method21(v98, v99) do
                        let v101 : int32 = v99.l0
                        let v102 : num_complex_Complex<float> = v99.l1
                        let v103 : int32 = v93.[int v101]
                        let v104 : string = "num_complex::Complex::new($0, $1)"
                        let v105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v104 
                        let v106 : (int32 -> float) = float
                        let v107 : float = v106 v103
                        let v108 : string = "num_complex::Complex::new($0, $1)"
                        let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v107, 0.0) v108 
                        let v110 : num_complex_Complex<float> = method22(v109)
                        let v111 : num_complex_Complex<float> = method23(v79)
                        let v112 : string = "num_complex::Complex::powc(v110, v111)"
                        let v113 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v112 
                        let v114 : string = "v105 / v113"
                        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v114 
                        let v116 : string = "v102 + v115"
                        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v116 
                        let v118 : int32 = v101 + 1
                        v99.l0 <- v118
                        v99.l1 <- v117
                        ()
                    let v119 : num_complex_Complex<float> = v99.l1
                    v119
                else
                    let v120 : string = "num_complex::Complex::new($0, $1)"
                    let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v120 
                    let v122 : string = "$0 - $1"
                    let v123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v121, v79) v122 
                    let v124 : string = $"        s = mpmath.gamma(s)"
                    let v125 : num_complex_Complex<float> = method3(v123)
                    let v126 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v124, v125)
                    let v127 : string = "v126.ok()"
                    let v128 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v127 
                    let v129 : US0 option = None
                    let _v129 = ref v129 
                    match v128 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v130 : num_complex_Complex<float> = x
                    let v131 : US0 = US0_0(v130)
                    v131 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v129.Value <- x
                    let v132 : US0 option = _v129.Value 
                    let v133 : US0 = US0_1
                    let v134 : US0 = v132 |> Option.defaultValue v133 
                    let v135 : string = "f64::NAN"
                    let v136 : float = Fable.Core.RustInterop.emitRustExpr () v135 
                    let v137 : string = "f64::NAN"
                    let v138 : float = Fable.Core.RustInterop.emitRustExpr () v137 
                    let v139 : string = "num_complex::Complex::new($0, $1)"
                    let v140 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v136, v138) v139 
                    let v143 : num_complex_Complex<float> =
                        match v134 with
                        | US0_1 -> (* None *)
                            v140
                        | US0_0(v141) -> (* Some *)
                            v141
                    let v144 : string = "num_complex::Complex::new($0, $1)"
                    let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v144 
                    let v146 : string = "$0 * $1"
                    let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v145, v79) v146 
                    let v148 : string = "num_complex::Complex::new($0, $1)"
                    let v149 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v148 
                    let v150 : string = "v147 / v149"
                    let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v150 
                    let v152 : string = "v151.sin()"
                    let v153 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v152 
                    let v154 : num_complex_Complex<float> = method7(v79)
                    let v155 : string = "v154.re"
                    let v156 : float = Fable.Core.RustInterop.emitRustExpr () v155 
                    let v157 : float = 1.0 - v156
                    let v158 : num_complex_Complex<float> = method8(v79)
                    let v159 : string = "v158.im"
                    let v160 : float = Fable.Core.RustInterop.emitRustExpr () v159 
                    let v161 : float =  -v160
                    let v162 : string = "num_complex::Complex::new($0, $1)"
                    let v163 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v157, v161) v162 
                    let v164 : num_complex_Complex<float> = method7(v163)
                    let v165 : string = "v164.re"
                    let v166 : float = Fable.Core.RustInterop.emitRustExpr () v165 
                    let v167 : bool = v166 <= 1.0
                    let v476 : num_complex_Complex<float> =
                        if v167 then
                            let v168 : string = "num_complex::Complex::new($0, $1)"
                            let v169 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v168 
                            v169
                        else
                            let v170 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 2, $0)"
                            Fable.Core.RustInterop.emitRustExpr v163 v170 
                            let v171 : num_complex_Complex<float> = method7(v163)
                            let v172 : string = "v171.re"
                            let v173 : float = Fable.Core.RustInterop.emitRustExpr () v172 
                            let v174 : bool = v173 > 1.0
                            if v174 then
                                let v175 : string = "num_complex::Complex::new($0, $1)"
                                let v176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v175 
                                let v177 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v178 : Mut0 = {l0 = 0} : Mut0
                                while method20(v178) do
                                    let v180 : int32 = v178.l0
                                    v177.[int v180] <- v180
                                    let v181 : int32 = v180 + 1
                                    v178.l0 <- v181
                                    ()
                                let v182 : int32 = v177.Length
                                let v183 : Mut2 = {l0 = 0; l1 = v176} : Mut2
                                while method21(v182, v183) do
                                    let v185 : int32 = v183.l0
                                    let v186 : num_complex_Complex<float> = v183.l1
                                    let v187 : int32 = v177.[int v185]
                                    let v188 : string = "num_complex::Complex::new($0, $1)"
                                    let v189 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v188 
                                    let v190 : (int32 -> float) = float
                                    let v191 : float = v190 v187
                                    let v192 : string = "num_complex::Complex::new($0, $1)"
                                    let v193 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v191, 0.0) v192 
                                    let v194 : num_complex_Complex<float> = method22(v193)
                                    let v195 : num_complex_Complex<float> = method23(v163)
                                    let v196 : string = "num_complex::Complex::powc(v194, v195)"
                                    let v197 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v196 
                                    let v198 : string = "v189 / v197"
                                    let v199 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v198 
                                    let v200 : string = "v186 + v199"
                                    let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v200 
                                    let v202 : int32 = v185 + 1
                                    v183.l0 <- v202
                                    v183.l1 <- v201
                                    ()
                                let v203 : num_complex_Complex<float> = v183.l1
                                v203
                            else
                                let v204 : string = "num_complex::Complex::new($0, $1)"
                                let v205 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v204 
                                let v206 : string = "$0 - $1"
                                let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v205, v163) v206 
                                let v208 : string = $"        s = mpmath.gamma(s)"
                                let v209 : num_complex_Complex<float> = method3(v207)
                                let v210 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v208, v209)
                                let v211 : string = "v210.ok()"
                                let v212 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v211 
                                let v213 : US0 option = None
                                let _v213 = ref v213 
                                match v212 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v214 : num_complex_Complex<float> = x
                                let v215 : US0 = US0_0(v214)
                                v215 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v213.Value <- x
                                let v216 : US0 option = _v213.Value 
                                let v217 : US0 = US0_1
                                let v218 : US0 = v216 |> Option.defaultValue v217 
                                let v219 : string = "f64::NAN"
                                let v220 : float = Fable.Core.RustInterop.emitRustExpr () v219 
                                let v221 : string = "f64::NAN"
                                let v222 : float = Fable.Core.RustInterop.emitRustExpr () v221 
                                let v223 : string = "num_complex::Complex::new($0, $1)"
                                let v224 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v220, v222) v223 
                                let v227 : num_complex_Complex<float> =
                                    match v218 with
                                    | US0_1 -> (* None *)
                                        v224
                                    | US0_0(v225) -> (* Some *)
                                        v225
                                let v228 : string = "num_complex::Complex::new($0, $1)"
                                let v229 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v228 
                                let v230 : string = "$0 * $1"
                                let v231 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v229, v163) v230 
                                let v232 : string = "num_complex::Complex::new($0, $1)"
                                let v233 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v232 
                                let v234 : string = "v231 / v233"
                                let v235 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v234 
                                let v236 : string = "v235.sin()"
                                let v237 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v236 
                                let v238 : num_complex_Complex<float> = method7(v163)
                                let v239 : string = "v238.re"
                                let v240 : float = Fable.Core.RustInterop.emitRustExpr () v239 
                                let v241 : float = 1.0 - v240
                                let v242 : num_complex_Complex<float> = method8(v163)
                                let v243 : string = "v242.im"
                                let v244 : float = Fable.Core.RustInterop.emitRustExpr () v243 
                                let v245 : float =  -v244
                                let v246 : string = "num_complex::Complex::new($0, $1)"
                                let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v241, v245) v246 
                                let v248 : num_complex_Complex<float> = method7(v247)
                                let v249 : string = "v248.re"
                                let v250 : float = Fable.Core.RustInterop.emitRustExpr () v249 
                                let v251 : bool = v250 <= 1.0
                                let v458 : num_complex_Complex<float> =
                                    if v251 then
                                        let v252 : string = "num_complex::Complex::new($0, $1)"
                                        let v253 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v252 
                                        v253
                                    else
                                        let v254 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 3, $0)"
                                        Fable.Core.RustInterop.emitRustExpr v247 v254 
                                        let v255 : num_complex_Complex<float> = method7(v247)
                                        let v256 : string = "v255.re"
                                        let v257 : float = Fable.Core.RustInterop.emitRustExpr () v256 
                                        let v258 : bool = v257 > 1.0
                                        if v258 then
                                            let v259 : string = "num_complex::Complex::new($0, $1)"
                                            let v260 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v259 
                                            let v261 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v262 : Mut0 = {l0 = 0} : Mut0
                                            while method20(v262) do
                                                let v264 : int32 = v262.l0
                                                v261.[int v264] <- v264
                                                let v265 : int32 = v264 + 1
                                                v262.l0 <- v265
                                                ()
                                            let v266 : int32 = v261.Length
                                            let v267 : Mut2 = {l0 = 0; l1 = v260} : Mut2
                                            while method21(v266, v267) do
                                                let v269 : int32 = v267.l0
                                                let v270 : num_complex_Complex<float> = v267.l1
                                                let v271 : int32 = v261.[int v269]
                                                let v272 : string = "num_complex::Complex::new($0, $1)"
                                                let v273 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v272 
                                                let v274 : (int32 -> float) = float
                                                let v275 : float = v274 v271
                                                let v276 : string = "num_complex::Complex::new($0, $1)"
                                                let v277 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v275, 0.0) v276 
                                                let v278 : num_complex_Complex<float> = method22(v277)
                                                let v279 : num_complex_Complex<float> = method23(v247)
                                                let v280 : string = "num_complex::Complex::powc(v278, v279)"
                                                let v281 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v280 
                                                let v282 : string = "v273 / v281"
                                                let v283 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v282 
                                                let v284 : string = "v270 + v283"
                                                let v285 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v284 
                                                let v286 : int32 = v269 + 1
                                                v267.l0 <- v286
                                                v267.l1 <- v285
                                                ()
                                            let v287 : num_complex_Complex<float> = v267.l1
                                            v287
                                        else
                                            let v288 : string = "num_complex::Complex::new($0, $1)"
                                            let v289 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v288 
                                            let v290 : string = "$0 - $1"
                                            let v291 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v289, v247) v290 
                                            let v292 : string = $"        s = mpmath.gamma(s)"
                                            let v293 : num_complex_Complex<float> = method3(v291)
                                            let v294 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v292, v293)
                                            let v295 : string = "v294.ok()"
                                            let v296 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v295 
                                            let v297 : US0 option = None
                                            let _v297 = ref v297 
                                            match v296 with
                                            | Some x -> (
                                            (fun () ->
                                            (fun () ->
                                            let v298 : num_complex_Complex<float> = x
                                            let v299 : US0 = US0_0(v298)
                                            v299 
                                            )
                                            |> fun x -> x () |> Some
                                            ) () ) | None -> None
                                            |> fun x -> _v297.Value <- x
                                            let v300 : US0 option = _v297.Value 
                                            let v301 : US0 = US0_1
                                            let v302 : US0 = v300 |> Option.defaultValue v301 
                                            let v303 : string = "f64::NAN"
                                            let v304 : float = Fable.Core.RustInterop.emitRustExpr () v303 
                                            let v305 : string = "f64::NAN"
                                            let v306 : float = Fable.Core.RustInterop.emitRustExpr () v305 
                                            let v307 : string = "num_complex::Complex::new($0, $1)"
                                            let v308 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v304, v306) v307 
                                            let v311 : num_complex_Complex<float> =
                                                match v302 with
                                                | US0_1 -> (* None *)
                                                    v308
                                                | US0_0(v309) -> (* Some *)
                                                    v309
                                            let v312 : string = "num_complex::Complex::new($0, $1)"
                                            let v313 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v312 
                                            let v314 : string = "$0 * $1"
                                            let v315 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v313, v247) v314 
                                            let v316 : string = "num_complex::Complex::new($0, $1)"
                                            let v317 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v316 
                                            let v318 : string = "v315 / v317"
                                            let v319 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v318 
                                            let v320 : string = "v319.sin()"
                                            let v321 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v320 
                                            let v322 : num_complex_Complex<float> = method7(v247)
                                            let v323 : string = "v322.re"
                                            let v324 : float = Fable.Core.RustInterop.emitRustExpr () v323 
                                            let v325 : float = 1.0 - v324
                                            let v326 : num_complex_Complex<float> = method8(v247)
                                            let v327 : string = "v326.im"
                                            let v328 : float = Fable.Core.RustInterop.emitRustExpr () v327 
                                            let v329 : float =  -v328
                                            let v330 : string = "num_complex::Complex::new($0, $1)"
                                            let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v325, v329) v330 
                                            let v332 : num_complex_Complex<float> = method7(v331)
                                            let v333 : string = "v332.re"
                                            let v334 : float = Fable.Core.RustInterop.emitRustExpr () v333 
                                            let v335 : bool = v334 <= 1.0
                                            let v440 : num_complex_Complex<float> =
                                                if v335 then
                                                    let v336 : string = "num_complex::Complex::new($0, $1)"
                                                    let v337 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v336 
                                                    v337
                                                else
                                                    let v338 : string = "println!(\"zeta / count: {:?} / s: {:?}\", 4, $0)"
                                                    Fable.Core.RustInterop.emitRustExpr v331 v338 
                                                    let v339 : num_complex_Complex<float> = method7(v331)
                                                    let v340 : string = "v339.re"
                                                    let v341 : float = Fable.Core.RustInterop.emitRustExpr () v340 
                                                    let v342 : bool = v341 > 1.0
                                                    if v342 then
                                                        let v343 : string = "num_complex::Complex::new($0, $1)"
                                                        let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v343 
                                                        let v345 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v346 : Mut0 = {l0 = 0} : Mut0
                                                        while method20(v346) do
                                                            let v348 : int32 = v346.l0
                                                            v345.[int v348] <- v348
                                                            let v349 : int32 = v348 + 1
                                                            v346.l0 <- v349
                                                            ()
                                                        let v350 : int32 = v345.Length
                                                        let v351 : Mut2 = {l0 = 0; l1 = v344} : Mut2
                                                        while method21(v350, v351) do
                                                            let v353 : int32 = v351.l0
                                                            let v354 : num_complex_Complex<float> = v351.l1
                                                            let v355 : int32 = v345.[int v353]
                                                            let v356 : string = "num_complex::Complex::new($0, $1)"
                                                            let v357 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v356 
                                                            let v358 : (int32 -> float) = float
                                                            let v359 : float = v358 v355
                                                            let v360 : string = "num_complex::Complex::new($0, $1)"
                                                            let v361 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v359, 0.0) v360 
                                                            let v362 : num_complex_Complex<float> = method22(v361)
                                                            let v363 : num_complex_Complex<float> = method23(v331)
                                                            let v364 : string = "num_complex::Complex::powc(v362, v363)"
                                                            let v365 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v364 
                                                            let v366 : string = "v357 / v365"
                                                            let v367 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v366 
                                                            let v368 : string = "v354 + v367"
                                                            let v369 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v368 
                                                            let v370 : int32 = v353 + 1
                                                            v351.l0 <- v370
                                                            v351.l1 <- v369
                                                            ()
                                                        let v371 : num_complex_Complex<float> = v351.l1
                                                        v371
                                                    else
                                                        let v372 : string = "num_complex::Complex::new($0, $1)"
                                                        let v373 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v372 
                                                        let v374 : string = "$0 - $1"
                                                        let v375 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v373, v331) v374 
                                                        let v376 : string = $"        s = mpmath.gamma(s)"
                                                        let v377 : num_complex_Complex<float> = method3(v375)
                                                        let v378 : Result<num_complex_Complex<float>, std_string_String> = method24(v0, v376, v377)
                                                        let v379 : string = "v378.ok()"
                                                        let v380 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v379 
                                                        let v381 : US0 option = None
                                                        let _v381 = ref v381 
                                                        match v380 with
                                                        | Some x -> (
                                                        (fun () ->
                                                        (fun () ->
                                                        let v382 : num_complex_Complex<float> = x
                                                        let v383 : US0 = US0_0(v382)
                                                        v383 
                                                        )
                                                        |> fun x -> x () |> Some
                                                        ) () ) | None -> None
                                                        |> fun x -> _v381.Value <- x
                                                        let v384 : US0 option = _v381.Value 
                                                        let v385 : US0 = US0_1
                                                        let v386 : US0 = v384 |> Option.defaultValue v385 
                                                        let v387 : string = "f64::NAN"
                                                        let v388 : float = Fable.Core.RustInterop.emitRustExpr () v387 
                                                        let v389 : string = "f64::NAN"
                                                        let v390 : float = Fable.Core.RustInterop.emitRustExpr () v389 
                                                        let v391 : string = "num_complex::Complex::new($0, $1)"
                                                        let v392 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v388, v390) v391 
                                                        let v395 : num_complex_Complex<float> =
                                                            match v386 with
                                                            | US0_1 -> (* None *)
                                                                v392
                                                            | US0_0(v393) -> (* Some *)
                                                                v393
                                                        let v396 : string = "num_complex::Complex::new($0, $1)"
                                                        let v397 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v396 
                                                        let v398 : string = "$0 * $1"
                                                        let v399 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v397, v331) v398 
                                                        let v400 : string = "num_complex::Complex::new($0, $1)"
                                                        let v401 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v400 
                                                        let v402 : string = "v399 / v401"
                                                        let v403 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v402 
                                                        let v404 : string = "v403.sin()"
                                                        let v405 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v404 
                                                        let v406 : num_complex_Complex<float> = method7(v331)
                                                        let v407 : string = "v406.re"
                                                        let v408 : float = Fable.Core.RustInterop.emitRustExpr () v407 
                                                        let v409 : float = 1.0 - v408
                                                        let v410 : num_complex_Complex<float> = method8(v331)
                                                        let v411 : string = "v410.im"
                                                        let v412 : float = Fable.Core.RustInterop.emitRustExpr () v411 
                                                        let v413 : float =  -v412
                                                        let v414 : string = "num_complex::Complex::new($0, $1)"
                                                        let v415 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v409, v413) v414 
                                                        let v416 : num_complex_Complex<float> = method7(v415)
                                                        let v417 : string = "v416.re"
                                                        let v418 : float = Fable.Core.RustInterop.emitRustExpr () v417 
                                                        let v419 : bool = v418 <= 1.0
                                                        let v422 : num_complex_Complex<float> =
                                                            if v419 then
                                                                let v420 : string = "num_complex::Complex::new($0, $1)"
                                                                let v421 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v420 
                                                                v421
                                                            else
                                                                v415
                                                        let v423 : string = "num_complex::Complex::new($0, $1)"
                                                        let v424 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v423 
                                                        let v425 : string = "num_complex::Complex::new($0, $1)"
                                                        let v426 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v425 
                                                        let v427 : num_complex_Complex<float> = method22(v426)
                                                        let v428 : num_complex_Complex<float> = method23(v331)
                                                        let v429 : string = "num_complex::Complex::powc(v427, v428)"
                                                        let v430 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v429 
                                                        let v431 : string = "$0 * $1"
                                                        let v432 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v424, v430) v431 
                                                        let v433 : string = "$0 * $1"
                                                        let v434 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v432, v405) v433 
                                                        let v435 : string = "$0 * $1"
                                                        let v436 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v434, v395) v435 
                                                        let v437 : string = "$0 * $1"
                                                        let v438 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v436, v422) v437 
                                                        v438
                                            let v441 : string = "num_complex::Complex::new($0, $1)"
                                            let v442 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v441 
                                            let v443 : string = "num_complex::Complex::new($0, $1)"
                                            let v444 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v443 
                                            let v445 : num_complex_Complex<float> = method22(v444)
                                            let v446 : num_complex_Complex<float> = method23(v247)
                                            let v447 : string = "num_complex::Complex::powc(v445, v446)"
                                            let v448 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v447 
                                            let v449 : string = "$0 * $1"
                                            let v450 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v442, v448) v449 
                                            let v451 : string = "$0 * $1"
                                            let v452 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v450, v321) v451 
                                            let v453 : string = "$0 * $1"
                                            let v454 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v452, v311) v453 
                                            let v455 : string = "$0 * $1"
                                            let v456 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v454, v440) v455 
                                            v456
                                let v459 : string = "num_complex::Complex::new($0, $1)"
                                let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v459 
                                let v461 : string = "num_complex::Complex::new($0, $1)"
                                let v462 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v461 
                                let v463 : num_complex_Complex<float> = method22(v462)
                                let v464 : num_complex_Complex<float> = method23(v163)
                                let v465 : string = "num_complex::Complex::powc(v463, v464)"
                                let v466 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v465 
                                let v467 : string = "$0 * $1"
                                let v468 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v460, v466) v467 
                                let v469 : string = "$0 * $1"
                                let v470 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v468, v237) v469 
                                let v471 : string = "$0 * $1"
                                let v472 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v470, v227) v471 
                                let v473 : string = "$0 * $1"
                                let v474 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v472, v458) v473 
                                v474
                    let v477 : string = "num_complex::Complex::new($0, $1)"
                    let v478 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v477 
                    let v479 : string = "num_complex::Complex::new($0, $1)"
                    let v480 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v479 
                    let v481 : num_complex_Complex<float> = method22(v480)
                    let v482 : num_complex_Complex<float> = method23(v79)
                    let v483 : string = "num_complex::Complex::powc(v481, v482)"
                    let v484 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v483 
                    let v485 : string = "$0 * $1"
                    let v486 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v478, v484) v485 
                    let v487 : string = "$0 * $1"
                    let v488 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v486, v153) v487 
                    let v489 : string = "$0 * $1"
                    let v490 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v488, v143) v489 
                    let v491 : string = "$0 * $1"
                    let v492 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v490, v476) v491 
                    v492
        let v495 : string = "num_complex::Complex::new($0, $1)"
        let v496 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v495 
        let v497 : string = "num_complex::Complex::new($0, $1)"
        let v498 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v497 
        let v499 : num_complex_Complex<float> = method22(v498)
        let v500 : num_complex_Complex<float> = method23(v1)
        let v501 : string = "num_complex::Complex::powc(v499, v500)"
        let v502 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr () v501 
        let v503 : string = "$0 * $1"
        let v504 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v496, v502) v503 
        let v505 : string = "$0 * $1"
        let v506 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v504, v69) v505 
        let v507 : string = "$0 * $1"
        let v508 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v506, v59) v507 
        let v509 : string = "$0 * $1"
        let v510 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v508, v494) v509 
        v510
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
        let v41 : (string -> unit) = System.Console.WriteLine
        v41 v40
        let v42 : bool = v38 = false
        if v42 then
            failwith<unit> v40
        let v43 : num_complex_Complex<float> = method7(v32)
        let v44 : string = "v43.re"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44 
        let v46 : float = v45 - v11
        let v47 : float =  -v46
        let v48 : bool = v46 >= v47
        let v49 : float =
            if v48 then
                v46
            else
                v47
        let v50 : bool = v49 < 0.0001
        let v52 : bool =
            if v50 then
                true
            else
                method25(v50)
        let v53 : string = "assert_lt"
        let v54 : string = $"{v53} / actual: %A{v49} / expected: %A{0.0001}"
        let v55 : (string -> unit) = System.Console.WriteLine
        v55 v54
        let v56 : bool = v52 = false
        if v56 then
            failwith<unit> v54
        let v57 : int32 = v9 + 1
        v7.l0 <- v57
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
    let v36 : (string -> unit) = System.Console.WriteLine
    v36 v35
    let v37 : bool = v33 = false
    if v37 then
        failwith<unit> v35
    let v38 : num_complex_Complex<float> = method8(v23)
    let v39 : string = "v38.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39 
    let v41 : float = v40 - 0.275
    let v42 : float =  -v41
    let v43 : bool = v41 >= v42
    let v44 : float =
        if v43 then
            v41
        else
            v42
    let v45 : bool = v44 < 0.001
    let v47 : bool =
        if v45 then
            true
        else
            method25(v45)
    let v48 : string = $"{v34} / actual: %A{v44} / expected: %A{0.001}"
    let v49 : (string -> unit) = System.Console.WriteLine
    v49 v48
    let v50 : bool = v47 = false
    if v50 then
        failwith<unit> v48
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
        let v35 : (string -> unit) = System.Console.WriteLine
        v35 v34
        let v36 : bool = v32 = false
        if v36 then
            failwith<unit> v34
        let v37 : num_complex_Complex<float> = method8(v26)
        let v38 : string = "v37.im"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr () v38 
        let v40 : bool = v39 = 0.0
        let v42 : bool =
            if v40 then
                true
            else
                method25(v40)
        let v43 : string = $"{v33} / actual: %A{v39} / expected: %A{0.0}"
        let v44 : (string -> unit) = System.Console.WriteLine
        v44 v43
        let v45 : bool = v42 = false
        if v45 then
            failwith<unit> v43
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
        let v51 : (string -> unit) = System.Console.WriteLine
        v51 v50
        let v52 : bool = v48 = false
        if v52 then
            failwith<unit> v50
        let v53 : num_complex_Complex<float> = method8(v39)
        let v54 : string = "v53.im"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54 
        let v56 : float =  -v55
        let v57 : bool = v55 >= v56
        let v58 : float =
            if v57 then
                v55
            else
                v56
        let v59 : bool = v58 < 0.0001
        let v61 : bool =
            if v59 then
                true
            else
                method25(v59)
        let v62 : string = $"{v49} / actual: %A{v58} / expected: %A{0.0001}"
        let v63 : (string -> unit) = System.Console.WriteLine
        v63 v62
        let v64 : bool = v61 = false
        if v64 then
            failwith<unit> v62
        let v65 : int32 = v17 + 1
        v15.l0 <- v65
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
        let v38 : (string -> unit) = System.Console.WriteLine
        v38 v37
        let v39 : bool = v35 = false
        if v39 then
            failwith<unit> v37
        let v40 : num_complex_Complex<float> = method8(v29)
        let v41 : string = "v40.im"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41 
        let v43 : bool = v42 = 0.0
        let v45 : bool =
            if v43 then
                true
            else
                method25(v43)
        let v46 : string = "assert_eq"
        let v47 : string = $"{v46} / actual: %A{v42} / expected: %A{0.0}"
        let v48 : (string -> unit) = System.Console.WriteLine
        v48 v47
        let v49 : bool = v45 = false
        if v49 then
            failwith<unit> v47
        let v50 : int32 = v5 + 1
        v3.l0 <- v50
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
    let v32 : (string -> unit) = System.Console.WriteLine
    v32 v31
    let v33 : bool = v29 = false
    if v33 then
        failwith<unit> v31
    let v34 : num_complex_Complex<float> = method8(v23)
    let v35 : string = "v34.im"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : bool = v36 = 0.0
    let v39 : bool =
        if v37 then
            true
        else
            method25(v37)
    let v40 : string = $"{v30} / actual: %A{v36} / expected: %A{0.0}"
    let v41 : (string -> unit) = System.Console.WriteLine
    v41 v40
    let v42 : bool = v39 = false
    if v42 then
        failwith<unit> v40
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
    let v67 : (string -> unit) = System.Console.WriteLine
    v67 v66
    let v68 : bool = v64 = false
    if v68 then
        failwith<unit> v66
    let v69 : num_complex_Complex<float> = method8(v23)
    let v70 : string = "v69.im"
    let v71 : float = Fable.Core.RustInterop.emitRustExpr () v70 
    let v72 : num_complex_Complex<float> = method8(v55)
    let v73 : string = "v72.im"
    let v74 : float = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : bool = v71 = v74
    let v77 : bool =
        if v75 then
            true
        else
            method25(v75)
    let v78 : string = $"{v65} / actual: %A{v71} / expected: %A{v74}"
    let v79 : (string -> unit) = System.Console.WriteLine
    v79 v78
    let v80 : bool = v77 = false
    if v80 then
        failwith<unit> v78
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
    let v32 : (string -> unit) = System.Console.WriteLine
    v32 v31
    let v33 : bool = v29 = false
    if v33 then
        failwith<unit> v31
    let v34 : num_complex_Complex<float> = method8(v23)
    let v35 : string = "v34.im"
    let v36 : float = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : bool = v36 < infinity
    let v39 : bool =
        if v37 then
            true
        else
            method25(v37)
    let v40 : string = $"{v30} / actual: %A{v36} / expected: %A{infinity}"
    let v41 : (string -> unit) = System.Console.WriteLine
    v41 v40
    let v42 : bool = v39 = false
    if v42 then
        failwith<unit> v40
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
        let v38 : (string -> unit) = System.Console.WriteLine
        v38 v37
        let v39 : bool = v35 = false
        if v39 then
            failwith<unit> v37
        let v40 : num_complex_Complex<float> = method8(v29)
        let v41 : string = "v40.im"
        let v42 : float = Fable.Core.RustInterop.emitRustExpr () v41 
        let v43 : bool = v42 <> 0.0 
        let v45 : bool =
            if v43 then
                true
            else
                method25(v43)
        let v46 : string = $"{v36} / actual: %A{v42} / expected: %A{0.0}"
        let v47 : (string -> unit) = System.Console.WriteLine
        v47 v46
        let v48 : bool = v45 = false
        if v48 then
            failwith<unit> v46
        let v49 : int32 = v5 + 1
        v3.l0 <- v49
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
        let v46 : (string -> unit) = System.Console.WriteLine
        v46 v45
        let v47 : bool = v43 = false
        if v47 then
            failwith<unit> v45
        let v48 : num_complex_Complex<float> = method8(v37)
        let v49 : string = "v48.im"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : bool = v50 <> 0.0 
        let v53 : bool =
            if v51 then
                true
            else
                method25(v51)
        let v54 : string = $"{v44} / actual: %A{v50} / expected: %A{0.0}"
        let v55 : (string -> unit) = System.Console.WriteLine
        v55 v54
        let v56 : bool = v53 = false
        if v56 then
            failwith<unit> v54
        let v57 : int32 = v15 + 1
        v13.l0 <- v57
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
        let v140 : (string -> unit) = System.Console.WriteLine
        v140 v139
        let v141 : bool = v137 = false
        if v141 then
            failwith<unit> v139
        let v142 : num_complex_Complex<float> = method8(v35)
        let v143 : string = "v142.im"
        let v144 : float = Fable.Core.RustInterop.emitRustExpr () v143 
        let v145 : num_complex_Complex<float> = method8(v124)
        let v146 : string = "v145.im"
        let v147 : float = Fable.Core.RustInterop.emitRustExpr () v146 
        let v148 : float = v144 - v147
        let v149 : float =  -v148
        let v150 : bool = v148 >= v149
        let v151 : float =
            if v150 then
                v148
            else
                v149
        let v152 : bool = v151 < 0.0001
        let v154 : bool =
            if v152 then
                true
            else
                method25(v152)
        let v155 : string = $"{v138} / actual: %A{v151} / expected: %A{0.0001}"
        let v156 : (string -> unit) = System.Console.WriteLine
        v156 v155
        let v157 : bool = v154 = false
        if v157 then
            failwith<unit> v155
        let v158 : int32 = v13 + 1
        v11.l0 <- v158
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
        let v55 : (string -> unit) = System.Console.WriteLine
        v55 v54
        let v56 : bool = v52 = false
        if v56 then
            failwith<unit> v54
        let v57 : num_complex_Complex<float> = method8(v42)
        let v58 : string = "v57.im"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : bool = v59 < 0.01
        let v62 : bool =
            if v60 then
                true
            else
                method25(v60)
        let v63 : string = $"{v53} / actual: %A{v59} / expected: %A{0.01}"
        let v64 : (string -> unit) = System.Console.WriteLine
        v64 v63
        let v65 : bool = v62 = false
        if v65 then
            failwith<unit> v63
        let v66 : int32 = v6 + 1
        v4.l0 <- v66
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
    let v2 : (string -> unit) = System.Console.WriteLine
    v2 v1
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure5()
let main args = v1 args
()
