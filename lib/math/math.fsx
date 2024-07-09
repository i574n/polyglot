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
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("_")>]
#endif
type Slice'<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("Vec<$0>")>]
#endif
type Vec<'T> = class end
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
[<Fable.Core.Erase; Fable.Core.Emit("regex::Captures<$0>")>]
#endif
type regex_Captures<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureMatches")>]
#endif
type regex_CaptureMatches = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::CaptureNames")>]
#endif
type regex_CaptureNames = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("regex::Match")>]
#endif
type regex_Match = class end
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
and UH1 =
    | UH1_0
    | UH1_1 of num_complex_Complex<float> * UH1
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
and method7 (v0 : pyo3_Python) : pyo3_Python =
    v0
and closure1 () (v0 : pyo3_PyErr) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method8 () : (pyo3_PyErr -> std_string_String) =
    closure1()
and method9 () : string =
    let v0 : string = "fn"
    v0
and method10 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and closure2 () (v0 : pyo3_PyErr) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method11 () : (pyo3_PyErr -> std_string_String) =
    closure2()
and method12 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method13 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure3 () (v0 : pyo3_PyErr) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method14 () : (pyo3_PyErr -> std_string_String) =
    closure3()
and method15 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure4 () (v0 : pyo3_PyErr) : std_string_String =
    let v3 : bool = true
    let mutable _v3 : std_string_String option = None 
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    v5 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    v7 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v8 : string = "format!(\"{}\", $0)"
    let v9 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v8 
    v9 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v12 : std_string_String = null |> unbox<std_string_String>
    v12 
    #endif
#if FABLE_COMPILER_PYTHON
    let v21 : std_string_String = null |> unbox<std_string_String>
    v21 
    #endif
#else
    let v30 : std_string_String = null |> unbox<std_string_String>
    v30 
    #endif
    |> fun x -> _v3 <- Some x
    let v37 : std_string_String = match _v3 with Some x -> x | None -> failwith "base.run_target / _v3=None"
    v37
and method16 () : (pyo3_PyErr -> std_string_String) =
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
    let v37 : string = "$0.re"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v2 v37 
    let v39 : string = "$0.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr v2 v39 
    let v41 : (float * float) = v38, v40 
    let v42 : (bool * (float * float)) = false, v41 
    let v43 : pyo3_Python = method7(v0)
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v44 
    let v46 : string = "pyo3::types::PyModule::from_code_bound(v43, v45, \"\", \"\")"
    let v47 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : (pyo3_PyErr -> std_string_String) = method8()
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49 
    let v51 : string = "$0.unwrap()"
    let v52 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = method9()
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v54 
    let v56 : pyo3_Bound<pyo3_types_PyModule> = method10(v52)
    let v57 : string = "v56.getattr(v55)"
    let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : (pyo3_PyErr -> std_string_String) = method11()
    let v60 : string = "$0.map_err(|x| $1(x))"
    let v61 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v58, v59) v60 
    let v62 : string = "$0.unwrap()"
    let v63 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v61 v62 
    let v64 : (bool * (float * float)) = method12(v42)
    let v65 : pyo3_Bound<pyo3_PyAny> = method13(v63)
    let v66 : string = "pyo3::prelude::PyAnyMethods::call(&v65, ((*v64).0, *(*v64).1), None)"
    let v67 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : (pyo3_PyErr -> std_string_String) = method14()
    let v69 : string = "$0.map_err(|x| $1(x))"
    let v70 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v67, v68) v69 
    let v71 : string = "$0?"
    let v72 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let v73 : pyo3_Bound<pyo3_PyAny> = method15(v72)
    let v74 : string = "v73.extract()"
    let v75 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v74 
    let v76 : (pyo3_PyErr -> std_string_String) = method16()
    let v77 : string = "$0.map_err(|x| $1(x))"
    let v78 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v75, v76) v77 
    let v79 : string = "$0?"
    let struct (v80 : float, v81 : float) = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v82 : string = "num_complex::Complex::new($0, $1)"
    let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v80, v81) v82 
    let v84 : Result<num_complex_Complex<float>, std_string_String> = Ok v83 
    v84
and method18 (v0 : Mut0) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 < 10000
    v2
and method19 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method20 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
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
    let v37 : string = "$0.re"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v2 v37 
    let v39 : string = "$0.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr v2 v39 
    let v41 : (float * float) = v38, v40 
    let v42 : (bool * (float * float)) = false, v41 
    let v43 : pyo3_Python = method7(v0)
    let v44 : string = "&*$0"
    let v45 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v44 
    let v46 : string = "pyo3::types::PyModule::from_code_bound(v43, v45, \"\", \"\")"
    let v47 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : (pyo3_PyErr -> std_string_String) = method8()
    let v49 : string = "$0.map_err(|x| $1(x))"
    let v50 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v47, v48) v49 
    let v51 : string = "$0.unwrap()"
    let v52 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : string = method9()
    let v54 : string = "&*$0"
    let v55 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v53 v54 
    let v56 : pyo3_Bound<pyo3_types_PyModule> = method10(v52)
    let v57 : string = "v56.getattr(v55)"
    let v58 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v57 
    let v59 : (pyo3_PyErr -> std_string_String) = method11()
    let v60 : string = "$0.map_err(|x| $1(x))"
    let v61 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v58, v59) v60 
    let v62 : string = "$0.unwrap()"
    let v63 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v61 v62 
    let v64 : (bool * (float * float)) = method12(v42)
    let v65 : pyo3_Bound<pyo3_PyAny> = method13(v63)
    let v66 : string = "pyo3::prelude::PyAnyMethods::call(&v65, ((*v64).0, *(*v64).1), None)"
    let v67 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v66 
    let v68 : (pyo3_PyErr -> std_string_String) = method14()
    let v69 : string = "$0.map_err(|x| $1(x))"
    let v70 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v67, v68) v69 
    let v71 : string = "$0?"
    let v72 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v70 v71 
    let v73 : pyo3_Bound<pyo3_PyAny> = method15(v72)
    let v74 : string = "v73.extract()"
    let v75 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v74 
    let v76 : (pyo3_PyErr -> std_string_String) = method16()
    let v77 : string = "$0.map_err(|x| $1(x))"
    let v78 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr struct (v75, v76) v77 
    let v79 : string = "$0?"
    let struct (v80 : float, v81 : float) = Fable.Core.RustInterop.emitRustExpr v78 v79 
    let v82 : string = "num_complex::Complex::new($0, $1)"
    let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v80, v81) v82 
    let v84 : Result<num_complex_Complex<float>, std_string_String> = Ok v83 
    v84
and method17 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : num_complex_Complex<float> =
    let v2 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
    Fable.Core.RustInterop.emitRustExpr struct (0, v1) v2 
    let v3 : string = "$0.re"
    let v4 : float = Fable.Core.RustInterop.emitRustExpr v1 v3 
    let v5 : bool = v4 > 1.0
    if v5 then
        let v6 : string = "num_complex::Complex::new($0, $1)"
        let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v6 
        let v8 : (int32 []) = Array.zeroCreate<int32> (10000)
        let v9 : Mut0 = {l0 = 0} : Mut0
        while method18(v9) do
            let v11 : int32 = v9.l0
            v8.[int v11] <- v11
            let v12 : int32 = v11 + 1
            v9.l0 <- v12
            ()
        let v13 : int32 = v8.Length
        let v14 : Mut2 = {l0 = 0; l1 = v7} : Mut2
        while method19(v13, v14) do
            let v16 : int32 = v14.l0
            let v17 : num_complex_Complex<float> = v14.l1
            let v18 : int32 = v8.[int v16]
            let v19 : string = "num_complex::Complex::new($0, $1)"
            let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v19 
            let v21 : (int32 -> float) = float
            let v22 : float = v21 v18
            let v23 : string = "num_complex::Complex::new($0, $1)"
            let v24 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v22, 0.0) v23 
            let v25 : string = "num_complex::Complex::powc($0, $1)"
            let v26 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v24, v1) v25 
            let v27 : string = "$0 / $1"
            let v28 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v26) v27 
            let v29 : string = "$0 + $1"
            let v30 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v28) v29 
            let v31 : int32 = v16 + 1
            v14.l0 <- v31
            v14.l1 <- v30
            ()
        let v32 : num_complex_Complex<float> = v14.l1
        v32
    else
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v33 
        let v35 : string = "$0 - $1"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v34, v1) v35 
        let v37 : string = $"        s = mpmath.gamma(s)"
        let v38 : num_complex_Complex<float> = method3(v36)
        let v39 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v37, v38)
        let v40 : string = "v39.ok()"
        let v41 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v40 
        let v44 : US0 option = None
        let _v44 = ref v44 
        match v41 with
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
        let v70 : US0 = US0_1
        let v71 : US0 = v47 |> Option.defaultValue v70 
        let v79 : string = "f64::NAN"
        let v80 : float = Fable.Core.RustInterop.emitRustExpr () v79 
        let v81 : string = "f64::NAN"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr () v81 
        let v83 : string = "num_complex::Complex::new($0, $1)"
        let v84 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v80, v82) v83 
        let v87 : num_complex_Complex<float> =
            match v71 with
            | US0_1 -> (* None *)
                v84
            | US0_0(v85) -> (* Some *)
                v85
        let v88 : string = "num_complex::Complex::new($0, $1)"
        let v89 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v88 
        let v90 : string = "$0 * $1"
        let v91 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v89, v1) v90 
        let v92 : string = "num_complex::Complex::new($0, $1)"
        let v93 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v92 
        let v94 : string = "$0 / $1"
        let v95 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v91, v93) v94 
        let v96 : string = "$0.sin()"
        let v97 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v95 v96 
        let v98 : string = "$0.re"
        let v99 : float = Fable.Core.RustInterop.emitRustExpr v1 v98 
        let v100 : float = 1.0 - v99
        let v101 : string = "$0.im"
        let v102 : float = Fable.Core.RustInterop.emitRustExpr v1 v101 
        let v103 : float =  -v102
        let v104 : string = "num_complex::Complex::new($0, $1)"
        let v105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v100, v103) v104 
        let v106 : string = "$0.re"
        let v107 : float = Fable.Core.RustInterop.emitRustExpr v105 v106 
        let v108 : bool = v107 <= 1.0
        let v611 : num_complex_Complex<float> =
            if v108 then
                let v109 : string = "num_complex::Complex::new($0, $1)"
                let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v109 
                v110
            else
                let v111 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v105) v111 
                let v112 : string = "$0.re"
                let v113 : float = Fable.Core.RustInterop.emitRustExpr v105 v112 
                let v114 : bool = v113 > 1.0
                if v114 then
                    let v115 : string = "num_complex::Complex::new($0, $1)"
                    let v116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v115 
                    let v117 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v118 : Mut0 = {l0 = 0} : Mut0
                    while method18(v118) do
                        let v120 : int32 = v118.l0
                        v117.[int v120] <- v120
                        let v121 : int32 = v120 + 1
                        v118.l0 <- v121
                        ()
                    let v122 : int32 = v117.Length
                    let v123 : Mut2 = {l0 = 0; l1 = v116} : Mut2
                    while method19(v122, v123) do
                        let v125 : int32 = v123.l0
                        let v126 : num_complex_Complex<float> = v123.l1
                        let v127 : int32 = v117.[int v125]
                        let v128 : string = "num_complex::Complex::new($0, $1)"
                        let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v128 
                        let v130 : (int32 -> float) = float
                        let v131 : float = v130 v127
                        let v132 : string = "num_complex::Complex::new($0, $1)"
                        let v133 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v131, 0.0) v132 
                        let v134 : string = "num_complex::Complex::powc($0, $1)"
                        let v135 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v133, v105) v134 
                        let v136 : string = "$0 / $1"
                        let v137 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v129, v135) v136 
                        let v138 : string = "$0 + $1"
                        let v139 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v126, v137) v138 
                        let v140 : int32 = v125 + 1
                        v123.l0 <- v140
                        v123.l1 <- v139
                        ()
                    let v141 : num_complex_Complex<float> = v123.l1
                    v141
                else
                    let v142 : string = "num_complex::Complex::new($0, $1)"
                    let v143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v142 
                    let v144 : string = "$0 - $1"
                    let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v143, v105) v144 
                    let v146 : string = $"        s = mpmath.gamma(s)"
                    let v147 : num_complex_Complex<float> = method3(v145)
                    let v148 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v146, v147)
                    let v149 : string = "v148.ok()"
                    let v150 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v149 
                    let v153 : US0 option = None
                    let _v153 = ref v153 
                    match v150 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v154 : num_complex_Complex<float> = x
                    let v155 : US0 = US0_0(v154)
                    v155 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v153.Value <- x
                    let v156 : US0 option = _v153.Value 
                    let v179 : US0 = US0_1
                    let v180 : US0 = v156 |> Option.defaultValue v179 
                    let v188 : string = "f64::NAN"
                    let v189 : float = Fable.Core.RustInterop.emitRustExpr () v188 
                    let v190 : string = "f64::NAN"
                    let v191 : float = Fable.Core.RustInterop.emitRustExpr () v190 
                    let v192 : string = "num_complex::Complex::new($0, $1)"
                    let v193 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v189, v191) v192 
                    let v196 : num_complex_Complex<float> =
                        match v180 with
                        | US0_1 -> (* None *)
                            v193
                        | US0_0(v194) -> (* Some *)
                            v194
                    let v197 : string = "num_complex::Complex::new($0, $1)"
                    let v198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v197 
                    let v199 : string = "$0 * $1"
                    let v200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v198, v105) v199 
                    let v201 : string = "num_complex::Complex::new($0, $1)"
                    let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v201 
                    let v203 : string = "$0 / $1"
                    let v204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v200, v202) v203 
                    let v205 : string = "$0.sin()"
                    let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v204 v205 
                    let v207 : string = "$0.re"
                    let v208 : float = Fable.Core.RustInterop.emitRustExpr v105 v207 
                    let v209 : float = 1.0 - v208
                    let v210 : string = "$0.im"
                    let v211 : float = Fable.Core.RustInterop.emitRustExpr v105 v210 
                    let v212 : float =  -v211
                    let v213 : string = "num_complex::Complex::new($0, $1)"
                    let v214 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v209, v212) v213 
                    let v215 : string = "$0.re"
                    let v216 : float = Fable.Core.RustInterop.emitRustExpr v214 v215 
                    let v217 : bool = v216 <= 1.0
                    let v595 : num_complex_Complex<float> =
                        if v217 then
                            let v218 : string = "num_complex::Complex::new($0, $1)"
                            let v219 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v218 
                            v219
                        else
                            let v220 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v214) v220 
                            let v221 : string = "$0.re"
                            let v222 : float = Fable.Core.RustInterop.emitRustExpr v214 v221 
                            let v223 : bool = v222 > 1.0
                            if v223 then
                                let v224 : string = "num_complex::Complex::new($0, $1)"
                                let v225 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v224 
                                let v226 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v227 : Mut0 = {l0 = 0} : Mut0
                                while method18(v227) do
                                    let v229 : int32 = v227.l0
                                    v226.[int v229] <- v229
                                    let v230 : int32 = v229 + 1
                                    v227.l0 <- v230
                                    ()
                                let v231 : int32 = v226.Length
                                let v232 : Mut2 = {l0 = 0; l1 = v225} : Mut2
                                while method19(v231, v232) do
                                    let v234 : int32 = v232.l0
                                    let v235 : num_complex_Complex<float> = v232.l1
                                    let v236 : int32 = v226.[int v234]
                                    let v237 : string = "num_complex::Complex::new($0, $1)"
                                    let v238 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v237 
                                    let v239 : (int32 -> float) = float
                                    let v240 : float = v239 v236
                                    let v241 : string = "num_complex::Complex::new($0, $1)"
                                    let v242 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v240, 0.0) v241 
                                    let v243 : string = "num_complex::Complex::powc($0, $1)"
                                    let v244 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v242, v214) v243 
                                    let v245 : string = "$0 / $1"
                                    let v246 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v238, v244) v245 
                                    let v247 : string = "$0 + $1"
                                    let v248 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v235, v246) v247 
                                    let v249 : int32 = v234 + 1
                                    v232.l0 <- v249
                                    v232.l1 <- v248
                                    ()
                                let v250 : num_complex_Complex<float> = v232.l1
                                v250
                            else
                                let v251 : string = "num_complex::Complex::new($0, $1)"
                                let v252 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v251 
                                let v253 : string = "$0 - $1"
                                let v254 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v252, v214) v253 
                                let v255 : string = $"        s = mpmath.gamma(s)"
                                let v256 : num_complex_Complex<float> = method3(v254)
                                let v257 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v255, v256)
                                let v258 : string = "v257.ok()"
                                let v259 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v258 
                                let v262 : US0 option = None
                                let _v262 = ref v262 
                                match v259 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v263 : num_complex_Complex<float> = x
                                let v264 : US0 = US0_0(v263)
                                v264 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v262.Value <- x
                                let v265 : US0 option = _v262.Value 
                                let v288 : US0 = US0_1
                                let v289 : US0 = v265 |> Option.defaultValue v288 
                                let v297 : string = "f64::NAN"
                                let v298 : float = Fable.Core.RustInterop.emitRustExpr () v297 
                                let v299 : string = "f64::NAN"
                                let v300 : float = Fable.Core.RustInterop.emitRustExpr () v299 
                                let v301 : string = "num_complex::Complex::new($0, $1)"
                                let v302 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v298, v300) v301 
                                let v305 : num_complex_Complex<float> =
                                    match v289 with
                                    | US0_1 -> (* None *)
                                        v302
                                    | US0_0(v303) -> (* Some *)
                                        v303
                                let v306 : string = "num_complex::Complex::new($0, $1)"
                                let v307 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v306 
                                let v308 : string = "$0 * $1"
                                let v309 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v307, v214) v308 
                                let v310 : string = "num_complex::Complex::new($0, $1)"
                                let v311 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v310 
                                let v312 : string = "$0 / $1"
                                let v313 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v309, v311) v312 
                                let v314 : string = "$0.sin()"
                                let v315 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v313 v314 
                                let v316 : string = "$0.re"
                                let v317 : float = Fable.Core.RustInterop.emitRustExpr v214 v316 
                                let v318 : float = 1.0 - v317
                                let v319 : string = "$0.im"
                                let v320 : float = Fable.Core.RustInterop.emitRustExpr v214 v319 
                                let v321 : float =  -v320
                                let v322 : string = "num_complex::Complex::new($0, $1)"
                                let v323 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v318, v321) v322 
                                let v324 : string = "$0.re"
                                let v325 : float = Fable.Core.RustInterop.emitRustExpr v323 v324 
                                let v326 : bool = v325 <= 1.0
                                let v579 : num_complex_Complex<float> =
                                    if v326 then
                                        let v327 : string = "num_complex::Complex::new($0, $1)"
                                        let v328 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v327 
                                        v328
                                    else
                                        let v329 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v323) v329 
                                        let v330 : string = "$0.re"
                                        let v331 : float = Fable.Core.RustInterop.emitRustExpr v323 v330 
                                        let v332 : bool = v331 > 1.0
                                        if v332 then
                                            let v333 : string = "num_complex::Complex::new($0, $1)"
                                            let v334 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v333 
                                            let v335 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v336 : Mut0 = {l0 = 0} : Mut0
                                            while method18(v336) do
                                                let v338 : int32 = v336.l0
                                                v335.[int v338] <- v338
                                                let v339 : int32 = v338 + 1
                                                v336.l0 <- v339
                                                ()
                                            let v340 : int32 = v335.Length
                                            let v341 : Mut2 = {l0 = 0; l1 = v334} : Mut2
                                            while method19(v340, v341) do
                                                let v343 : int32 = v341.l0
                                                let v344 : num_complex_Complex<float> = v341.l1
                                                let v345 : int32 = v335.[int v343]
                                                let v346 : string = "num_complex::Complex::new($0, $1)"
                                                let v347 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v346 
                                                let v348 : (int32 -> float) = float
                                                let v349 : float = v348 v345
                                                let v350 : string = "num_complex::Complex::new($0, $1)"
                                                let v351 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v349, 0.0) v350 
                                                let v352 : string = "num_complex::Complex::powc($0, $1)"
                                                let v353 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v351, v323) v352 
                                                let v354 : string = "$0 / $1"
                                                let v355 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v347, v353) v354 
                                                let v356 : string = "$0 + $1"
                                                let v357 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v344, v355) v356 
                                                let v358 : int32 = v343 + 1
                                                v341.l0 <- v358
                                                v341.l1 <- v357
                                                ()
                                            let v359 : num_complex_Complex<float> = v341.l1
                                            v359
                                        else
                                            let v360 : string = "num_complex::Complex::new($0, $1)"
                                            let v361 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v360 
                                            let v362 : string = "$0 - $1"
                                            let v363 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v361, v323) v362 
                                            let v364 : string = $"        s = mpmath.gamma(s)"
                                            let v365 : num_complex_Complex<float> = method3(v363)
                                            let v366 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v364, v365)
                                            let v367 : string = "v366.ok()"
                                            let v368 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v367 
                                            let v371 : US0 option = None
                                            let _v371 = ref v371 
                                            match v368 with
                                            | Some x -> (
                                            (fun () ->
                                            (fun () ->
                                            let v372 : num_complex_Complex<float> = x
                                            let v373 : US0 = US0_0(v372)
                                            v373 
                                            )
                                            |> fun x -> x () |> Some
                                            ) () ) | None -> None
                                            |> fun x -> _v371.Value <- x
                                            let v374 : US0 option = _v371.Value 
                                            let v397 : US0 = US0_1
                                            let v398 : US0 = v374 |> Option.defaultValue v397 
                                            let v406 : string = "f64::NAN"
                                            let v407 : float = Fable.Core.RustInterop.emitRustExpr () v406 
                                            let v408 : string = "f64::NAN"
                                            let v409 : float = Fable.Core.RustInterop.emitRustExpr () v408 
                                            let v410 : string = "num_complex::Complex::new($0, $1)"
                                            let v411 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v407, v409) v410 
                                            let v414 : num_complex_Complex<float> =
                                                match v398 with
                                                | US0_1 -> (* None *)
                                                    v411
                                                | US0_0(v412) -> (* Some *)
                                                    v412
                                            let v415 : string = "num_complex::Complex::new($0, $1)"
                                            let v416 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v415 
                                            let v417 : string = "$0 * $1"
                                            let v418 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v416, v323) v417 
                                            let v419 : string = "num_complex::Complex::new($0, $1)"
                                            let v420 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v419 
                                            let v421 : string = "$0 / $1"
                                            let v422 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v418, v420) v421 
                                            let v423 : string = "$0.sin()"
                                            let v424 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v422 v423 
                                            let v425 : string = "$0.re"
                                            let v426 : float = Fable.Core.RustInterop.emitRustExpr v323 v425 
                                            let v427 : float = 1.0 - v426
                                            let v428 : string = "$0.im"
                                            let v429 : float = Fable.Core.RustInterop.emitRustExpr v323 v428 
                                            let v430 : float =  -v429
                                            let v431 : string = "num_complex::Complex::new($0, $1)"
                                            let v432 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v427, v430) v431 
                                            let v433 : string = "$0.re"
                                            let v434 : float = Fable.Core.RustInterop.emitRustExpr v432 v433 
                                            let v435 : bool = v434 <= 1.0
                                            let v563 : num_complex_Complex<float> =
                                                if v435 then
                                                    let v436 : string = "num_complex::Complex::new($0, $1)"
                                                    let v437 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v436 
                                                    v437
                                                else
                                                    let v438 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v432) v438 
                                                    let v439 : string = "$0.re"
                                                    let v440 : float = Fable.Core.RustInterop.emitRustExpr v432 v439 
                                                    let v441 : bool = v440 > 1.0
                                                    if v441 then
                                                        let v442 : string = "num_complex::Complex::new($0, $1)"
                                                        let v443 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v442 
                                                        let v444 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v445 : Mut0 = {l0 = 0} : Mut0
                                                        while method18(v445) do
                                                            let v447 : int32 = v445.l0
                                                            v444.[int v447] <- v447
                                                            let v448 : int32 = v447 + 1
                                                            v445.l0 <- v448
                                                            ()
                                                        let v449 : int32 = v444.Length
                                                        let v450 : Mut2 = {l0 = 0; l1 = v443} : Mut2
                                                        while method19(v449, v450) do
                                                            let v452 : int32 = v450.l0
                                                            let v453 : num_complex_Complex<float> = v450.l1
                                                            let v454 : int32 = v444.[int v452]
                                                            let v455 : string = "num_complex::Complex::new($0, $1)"
                                                            let v456 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v455 
                                                            let v457 : (int32 -> float) = float
                                                            let v458 : float = v457 v454
                                                            let v459 : string = "num_complex::Complex::new($0, $1)"
                                                            let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v458, 0.0) v459 
                                                            let v461 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v462 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v460, v432) v461 
                                                            let v463 : string = "$0 / $1"
                                                            let v464 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v456, v462) v463 
                                                            let v465 : string = "$0 + $1"
                                                            let v466 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v453, v464) v465 
                                                            let v467 : int32 = v452 + 1
                                                            v450.l0 <- v467
                                                            v450.l1 <- v466
                                                            ()
                                                        let v468 : num_complex_Complex<float> = v450.l1
                                                        v468
                                                    else
                                                        let v469 : string = "num_complex::Complex::new($0, $1)"
                                                        let v470 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v469 
                                                        let v471 : string = "$0 - $1"
                                                        let v472 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v470, v432) v471 
                                                        let v473 : string = $"        s = mpmath.gamma(s)"
                                                        let v474 : num_complex_Complex<float> = method3(v472)
                                                        let v475 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v473, v474)
                                                        let v476 : string = "v475.ok()"
                                                        let v477 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v476 
                                                        let v480 : US0 option = None
                                                        let _v480 = ref v480 
                                                        match v477 with
                                                        | Some x -> (
                                                        (fun () ->
                                                        (fun () ->
                                                        let v481 : num_complex_Complex<float> = x
                                                        let v482 : US0 = US0_0(v481)
                                                        v482 
                                                        )
                                                        |> fun x -> x () |> Some
                                                        ) () ) | None -> None
                                                        |> fun x -> _v480.Value <- x
                                                        let v483 : US0 option = _v480.Value 
                                                        let v506 : US0 = US0_1
                                                        let v507 : US0 = v483 |> Option.defaultValue v506 
                                                        let v515 : string = "f64::NAN"
                                                        let v516 : float = Fable.Core.RustInterop.emitRustExpr () v515 
                                                        let v517 : string = "f64::NAN"
                                                        let v518 : float = Fable.Core.RustInterop.emitRustExpr () v517 
                                                        let v519 : string = "num_complex::Complex::new($0, $1)"
                                                        let v520 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v516, v518) v519 
                                                        let v523 : num_complex_Complex<float> =
                                                            match v507 with
                                                            | US0_1 -> (* None *)
                                                                v520
                                                            | US0_0(v521) -> (* Some *)
                                                                v521
                                                        let v524 : string = "num_complex::Complex::new($0, $1)"
                                                        let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v524 
                                                        let v526 : string = "$0 * $1"
                                                        let v527 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v525, v432) v526 
                                                        let v528 : string = "num_complex::Complex::new($0, $1)"
                                                        let v529 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v528 
                                                        let v530 : string = "$0 / $1"
                                                        let v531 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v527, v529) v530 
                                                        let v532 : string = "$0.sin()"
                                                        let v533 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v531 v532 
                                                        let v534 : string = "$0.re"
                                                        let v535 : float = Fable.Core.RustInterop.emitRustExpr v432 v534 
                                                        let v536 : float = 1.0 - v535
                                                        let v537 : string = "$0.im"
                                                        let v538 : float = Fable.Core.RustInterop.emitRustExpr v432 v537 
                                                        let v539 : float =  -v538
                                                        let v540 : string = "num_complex::Complex::new($0, $1)"
                                                        let v541 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v536, v539) v540 
                                                        let v542 : string = "$0.re"
                                                        let v543 : float = Fable.Core.RustInterop.emitRustExpr v541 v542 
                                                        let v544 : bool = v543 <= 1.0
                                                        let v547 : num_complex_Complex<float> =
                                                            if v544 then
                                                                let v545 : string = "num_complex::Complex::new($0, $1)"
                                                                let v546 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v545 
                                                                v546
                                                            else
                                                                v541
                                                        let v548 : string = "num_complex::Complex::new($0, $1)"
                                                        let v549 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v548 
                                                        let v550 : string = "num_complex::Complex::new($0, $1)"
                                                        let v551 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v550 
                                                        let v552 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v553 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v551, v432) v552 
                                                        let v554 : string = "$0 * $1"
                                                        let v555 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v549, v553) v554 
                                                        let v556 : string = "$0 * $1"
                                                        let v557 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v555, v533) v556 
                                                        let v558 : string = "$0 * $1"
                                                        let v559 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v557, v523) v558 
                                                        let v560 : string = "$0 * $1"
                                                        let v561 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v559, v547) v560 
                                                        v561
                                            let v564 : string = "num_complex::Complex::new($0, $1)"
                                            let v565 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v564 
                                            let v566 : string = "num_complex::Complex::new($0, $1)"
                                            let v567 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v566 
                                            let v568 : string = "num_complex::Complex::powc($0, $1)"
                                            let v569 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v567, v323) v568 
                                            let v570 : string = "$0 * $1"
                                            let v571 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v565, v569) v570 
                                            let v572 : string = "$0 * $1"
                                            let v573 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v571, v424) v572 
                                            let v574 : string = "$0 * $1"
                                            let v575 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v573, v414) v574 
                                            let v576 : string = "$0 * $1"
                                            let v577 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v575, v563) v576 
                                            v577
                                let v580 : string = "num_complex::Complex::new($0, $1)"
                                let v581 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v580 
                                let v582 : string = "num_complex::Complex::new($0, $1)"
                                let v583 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v582 
                                let v584 : string = "num_complex::Complex::powc($0, $1)"
                                let v585 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v583, v214) v584 
                                let v586 : string = "$0 * $1"
                                let v587 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v581, v585) v586 
                                let v588 : string = "$0 * $1"
                                let v589 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v587, v315) v588 
                                let v590 : string = "$0 * $1"
                                let v591 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v589, v305) v590 
                                let v592 : string = "$0 * $1"
                                let v593 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v591, v579) v592 
                                v593
                    let v596 : string = "num_complex::Complex::new($0, $1)"
                    let v597 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v596 
                    let v598 : string = "num_complex::Complex::new($0, $1)"
                    let v599 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v598 
                    let v600 : string = "num_complex::Complex::powc($0, $1)"
                    let v601 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v599, v105) v600 
                    let v602 : string = "$0 * $1"
                    let v603 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v597, v601) v602 
                    let v604 : string = "$0 * $1"
                    let v605 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v603, v206) v604 
                    let v606 : string = "$0 * $1"
                    let v607 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v605, v196) v606 
                    let v608 : string = "$0 * $1"
                    let v609 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v607, v595) v608 
                    v609
        let v612 : string = "num_complex::Complex::new($0, $1)"
        let v613 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v612 
        let v614 : string = "num_complex::Complex::new($0, $1)"
        let v615 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v614 
        let v616 : string = "num_complex::Complex::powc($0, $1)"
        let v617 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v615, v1) v616 
        let v618 : string = "$0 * $1"
        let v619 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v613, v617) v618 
        let v620 : string = "$0 * $1"
        let v621 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v619, v97) v620 
        let v622 : string = "$0 * $1"
        let v623 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v621, v87) v622 
        let v624 : string = "$0 * $1"
        let v625 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v623, v611) v624 
        v625
and method21 (v0 : bool) : bool =
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
        let v15 : num_complex_Complex<float> = method17(v0, v10)
        let v16 : string = "v14.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v16 
        let v20 : US0 option = None
        let _v20 = ref v20 
        match v17 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v21 : num_complex_Complex<float> = x
        let v22 : US0 = US0_0(v21)
        v22 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v20.Value <- x
        let v23 : US0 option = _v20.Value 
        let v46 : US0 = US0_1
        let v47 : US0 = v23 |> Option.defaultValue v46 
        let v55 : string = "f64::NAN"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr () v55 
        let v57 : string = "f64::NAN"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr () v57 
        let v59 : string = "num_complex::Complex::new($0, $1)"
        let v60 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v56, v58) v59 
        let v63 : num_complex_Complex<float> =
            match v47 with
            | US0_1 -> (* None *)
                v60
            | US0_0(v61) -> (* Some *)
                v61
        let v64 : string = "$0.im"
        let v65 : float = Fable.Core.RustInterop.emitRustExpr v63 v64 
        let v66 : bool = v65 = 0.0
        let v68 : bool =
            if v66 then
                true
            else
                method21(v66)
        let v71 : string = "assert_eq"
        let v72 : string = $"{v71} / actual: %A{v65} / expected: %A{0.0}"
        let v81 : (string -> unit) = System.Console.WriteLine
        v81 v72
        let v86 : bool = v68 = false
        if v86 then
            failwith<unit> v72
        let v87 : string = "$0.re"
        let v88 : float = Fable.Core.RustInterop.emitRustExpr v63 v87 
        let v89 : float = v88 - v11
        let v90 : float =  -v89
        let v91 : bool = v89 >= v90
        let v92 : float =
            if v91 then
                v89
            else
                v90
        let v93 : bool = v92 < 0.0001
        let v95 : bool =
            if v93 then
                true
            else
                method21(v93)
        let v98 : string = "assert_lt"
        let v99 : string = $"{v98} / actual: %A{v92} / expected: %A{0.0001}"
        let v108 : (string -> unit) = System.Console.WriteLine
        v108 v99
        let v113 : bool = v95 = false
        if v113 then
            failwith<unit> v99
        let v114 : int32 = v9 + 1
        v7.l0 <- v114
        ()
    ()
and method22 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
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
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method24 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method17(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7 
    let v11 : US0 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : num_complex_Complex<float> = x
    let v13 : US0 = US0_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US0 option = _v11.Value 
    let v37 : US0 = US0_1
    let v38 : US0 = v14 |> Option.defaultValue v37 
    let v46 : string = "f64::NAN"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "f64::NAN"
    let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "num_complex::Complex::new($0, $1)"
    let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v50 
    let v54 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v51
        | US0_0(v52) -> (* Some *)
            v52
    let v55 : string = "$0.re"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : float = v56 - 0.8673
    let v58 : float =  -v57
    let v59 : bool = v57 >= v58
    let v60 : float =
        if v59 then
            v57
        else
            v58
    let v61 : bool = v60 < 0.001
    let v63 : bool =
        if v61 then
            true
        else
            method21(v61)
    let v66 : string = "assert_lt"
    let v67 : string = $"{v66} / actual: %A{v60} / expected: %A{0.001}"
    let v76 : (string -> unit) = System.Console.WriteLine
    v76 v67
    let v81 : bool = v63 = false
    if v81 then
        failwith<unit> v67
    let v82 : string = "$0.im"
    let v83 : float = Fable.Core.RustInterop.emitRustExpr v54 v82 
    let v84 : float = v83 - 0.275
    let v85 : float =  -v84
    let v86 : bool = v84 >= v85
    let v87 : float =
        if v86 then
            v84
        else
            v85
    let v88 : bool = v87 < 0.001
    let v90 : bool =
        if v88 then
            true
        else
            method21(v88)
    let v93 : string = $"{v66} / actual: %A{v87} / expected: %A{0.001}"
    let v102 : (string -> unit) = System.Console.WriteLine
    v102 v93
    let v107 : bool = v90 = false
    if v107 then
        failwith<unit> v93
and method23 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method24(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method27 () : UH0 =
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
and method28 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, 0.0) v4 
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method17(v0, v5)
        let v10 : string = "v8.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10 
        let v14 : US0 option = None
        let _v14 = ref v14 
        match v11 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v15 : num_complex_Complex<float> = x
        let v16 : US0 = US0_0(v15)
        v16 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v14.Value <- x
        let v17 : US0 option = _v14.Value 
        let v40 : US0 = US0_1
        let v41 : US0 = v17 |> Option.defaultValue v40 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "f64::NAN"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51 
        let v53 : string = "num_complex::Complex::new($0, $1)"
        let v54 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v50, v52) v53 
        let v57 : num_complex_Complex<float> =
            match v41 with
            | US0_1 -> (* None *)
                v54
            | US0_0(v55) -> (* Some *)
                v55
        let v58 : string = "$0.re"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr v57 v58 
        let v60 : bool = v59 = 0.0
        let v62 : bool =
            if v60 then
                true
            else
                method21(v60)
        let v65 : string = "assert_eq"
        let v66 : string = $"{v65} / actual: %A{v59} / expected: %A{0.0}"
        let v75 : (string -> unit) = System.Console.WriteLine
        v75 v66
        let v80 : bool = v62 = false
        if v80 then
            failwith<unit> v66
        let v81 : string = "$0.im"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr v57 v81 
        let v83 : bool = v82 = 0.0
        let v85 : bool =
            if v83 then
                true
            else
                method21(v83)
        let v88 : string = $"{v65} / actual: %A{v82} / expected: %A{0.0}"
        let v97 : (string -> unit) = System.Console.WriteLine
        v97 v88
        let v102 : bool = v85 = false
        if v102 then
            failwith<unit> v88
        method28(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method26 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method27()
    method28(v0, v1)
and method25 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method26(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method30 (v0 : pyo3_Python) : unit =
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
        let v22 : num_complex_Complex<float> = method17(v0, v18)
        let v23 : string = "v21.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v23 
        let v27 : US0 option = None
        let _v27 = ref v27 
        match v24 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v28 : num_complex_Complex<float> = x
        let v29 : US0 = US0_0(v28)
        v29 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v27.Value <- x
        let v30 : US0 option = _v27.Value 
        let v53 : US0 = US0_1
        let v54 : US0 = v30 |> Option.defaultValue v53 
        let v62 : string = "f64::NAN"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr () v62 
        let v64 : string = "f64::NAN"
        let v65 : float = Fable.Core.RustInterop.emitRustExpr () v64 
        let v66 : string = "num_complex::Complex::new($0, $1)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v63, v65) v66 
        let v70 : num_complex_Complex<float> =
            match v54 with
            | US0_1 -> (* None *)
                v67
            | US0_0(v68) -> (* Some *)
                v68
        let v71 : string = "$0.re"
        let v72 : float = Fable.Core.RustInterop.emitRustExpr v70 v71 
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
                method21(v76)
        let v81 : string = "assert_lt"
        let v82 : string = $"{v81} / actual: %A{v75} / expected: %A{0.0001}"
        let v91 : (string -> unit) = System.Console.WriteLine
        v91 v82
        let v96 : bool = v78 = false
        if v96 then
            failwith<unit> v82
        let v97 : string = "$0.im"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr v70 v97 
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
                method21(v102)
        let v107 : string = $"{v81} / actual: %A{v101} / expected: %A{0.0001}"
        let v116 : (string -> unit) = System.Console.WriteLine
        v116 v107
        let v121 : bool = v104 = false
        if v121 then
            failwith<unit> v107
        let v122 : int32 = v17 + 1
        v15.l0 <- v122
        ()
    ()
and method29 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method30(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method32 (v0 : pyo3_Python) : unit =
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
        let v12 : num_complex_Complex<float> = method17(v0, v8)
        let v13 : string = "v11.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v13 
        let v17 : US0 option = None
        let _v17 = ref v17 
        match v14 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v18 : num_complex_Complex<float> = x
        let v19 : US0 = US0_0(v18)
        v19 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v17.Value <- x
        let v20 : US0 option = _v17.Value 
        let v43 : US0 = US0_1
        let v44 : US0 = v20 |> Option.defaultValue v43 
        let v52 : string = "f64::NAN"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52 
        let v54 : string = "f64::NAN"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54 
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v55) v56 
        let v60 : num_complex_Complex<float> =
            match v44 with
            | US0_1 -> (* None *)
                v57
            | US0_0(v58) -> (* Some *)
                v58
        let v61 : string = "$0.re"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr v60 v61 
        let v63 : bool = v62 > 0.0
        let v65 : bool =
            if v63 then
                true
            else
                method21(v63)
        let v68 : string = "assert_gt"
        let v69 : string = $"{v68} / actual: %A{v62} / expected: %A{0.0}"
        let v78 : (string -> unit) = System.Console.WriteLine
        v78 v69
        let v83 : bool = v65 = false
        if v83 then
            failwith<unit> v69
        let v84 : string = "$0.im"
        let v85 : float = Fable.Core.RustInterop.emitRustExpr v60 v84 
        let v86 : bool = v85 = 0.0
        let v88 : bool =
            if v86 then
                true
            else
                method21(v86)
        let v91 : string = "assert_eq"
        let v92 : string = $"{v91} / actual: %A{v85} / expected: %A{0.0}"
        let v101 : (string -> unit) = System.Console.WriteLine
        v101 v92
        let v106 : bool = v88 = false
        if v106 then
            failwith<unit> v92
        let v107 : int32 = v5 + 1
        v3.l0 <- v107
        ()
    ()
and method31 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method32(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method17(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7 
    let v11 : US0 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : num_complex_Complex<float> = x
    let v13 : US0 = US0_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US0 option = _v11.Value 
    let v37 : US0 = US0_1
    let v38 : US0 = v14 |> Option.defaultValue v37 
    let v46 : string = "f64::NAN"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "f64::NAN"
    let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "num_complex::Complex::new($0, $1)"
    let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v50 
    let v54 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v51
        | US0_0(v52) -> (* Some *)
            v52
    let v55 : string = "$0.re"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : bool = v56 = infinity
    let v59 : bool =
        if v57 then
            true
        else
            method21(v57)
    let v62 : string = "assert_eq"
    let v63 : string = $"{v62} / actual: %A{v56} / expected: %A{infinity}"
    let v72 : (string -> unit) = System.Console.WriteLine
    v72 v63
    let v77 : bool = v59 = false
    if v77 then
        failwith<unit> v63
    let v78 : string = "$0.im"
    let v79 : float = Fable.Core.RustInterop.emitRustExpr v54 v78 
    let v80 : bool = v79 = 0.0
    let v82 : bool =
        if v80 then
            true
        else
            method21(v80)
    let v85 : string = $"{v62} / actual: %A{v79} / expected: %A{0.0}"
    let v94 : (string -> unit) = System.Console.WriteLine
    v94 v85
    let v99 : bool = v82 = false
    if v99 then
        failwith<unit> v85
and method33 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method34(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method17(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7 
    let v11 : US0 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : num_complex_Complex<float> = x
    let v13 : US0 = US0_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US0 option = _v11.Value 
    let v37 : US0 = US0_1
    let v38 : US0 = v14 |> Option.defaultValue v37 
    let v46 : string = "f64::NAN"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "f64::NAN"
    let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "num_complex::Complex::new($0, $1)"
    let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v50 
    let v54 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v51
        | US0_0(v52) -> (* Some *)
            v52
    let v55 : string = "$0.re"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr v2 v55 
    let v57 : string = "$0.im"
    let v58 : float = Fable.Core.RustInterop.emitRustExpr v2 v57 
    let v59 : float =  -v58
    let v60 : string = "num_complex::Complex::new($0, $1)"
    let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v56, v59) v60 
    let v62 : string = $"        s = mpmath.zeta(s)"
    let v63 : num_complex_Complex<float> = method3(v61)
    let v64 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v62, v63)
    let v65 : num_complex_Complex<float> = method17(v0, v61)
    let v66 : string = "v64.ok()"
    let v67 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v66 
    let v70 : US0 option = None
    let _v70 = ref v70 
    match v67 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v71 : num_complex_Complex<float> = x
    let v72 : US0 = US0_0(v71)
    v72 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v70.Value <- x
    let v73 : US0 option = _v70.Value 
    let v96 : US0 = US0_1
    let v97 : US0 = v73 |> Option.defaultValue v96 
    let v105 : string = "f64::NAN"
    let v106 : float = Fable.Core.RustInterop.emitRustExpr () v105 
    let v107 : string = "f64::NAN"
    let v108 : float = Fable.Core.RustInterop.emitRustExpr () v107 
    let v109 : string = "num_complex::Complex::new($0, $1)"
    let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v106, v108) v109 
    let v113 : num_complex_Complex<float> =
        match v97 with
        | US0_1 -> (* None *)
            v110
        | US0_0(v111) -> (* Some *)
            v111
    let v114 : string = "$0.conj()"
    let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v113 v114 
    let v116 : string = "$0.re"
    let v117 : float = Fable.Core.RustInterop.emitRustExpr v54 v116 
    let v118 : string = "$0.re"
    let v119 : float = Fable.Core.RustInterop.emitRustExpr v115 v118 
    let v120 : bool = v117 = v119
    let v122 : bool =
        if v120 then
            true
        else
            method21(v120)
    let v125 : string = "assert_eq"
    let v126 : string = $"{v125} / actual: %A{v117} / expected: %A{v119}"
    let v135 : (string -> unit) = System.Console.WriteLine
    v135 v126
    let v140 : bool = v122 = false
    if v140 then
        failwith<unit> v126
    let v141 : string = "$0.im"
    let v142 : float = Fable.Core.RustInterop.emitRustExpr v54 v141 
    let v143 : string = "$0.im"
    let v144 : float = Fable.Core.RustInterop.emitRustExpr v115 v143 
    let v145 : bool = v142 = v144
    let v147 : bool =
        if v145 then
            true
        else
            method21(v145)
    let v150 : string = $"{v125} / actual: %A{v142} / expected: %A{v144}"
    let v159 : (string -> unit) = System.Console.WriteLine
    v159 v150
    let v164 : bool = v147 = false
    if v164 then
        failwith<unit> v150
and method35 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method36(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method17(v0, v2)
    let v7 : string = "v5.ok()"
    let v8 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v7 
    let v11 : US0 option = None
    let _v11 = ref v11 
    match v8 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v12 : num_complex_Complex<float> = x
    let v13 : US0 = US0_0(v12)
    v13 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v11.Value <- x
    let v14 : US0 option = _v11.Value 
    let v37 : US0 = US0_1
    let v38 : US0 = v14 |> Option.defaultValue v37 
    let v46 : string = "f64::NAN"
    let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46 
    let v48 : string = "f64::NAN"
    let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : string = "num_complex::Complex::new($0, $1)"
    let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v49) v50 
    let v54 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v51
        | US0_0(v52) -> (* Some *)
            v52
    let v55 : string = "$0.re"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr v54 v55 
    let v57 : bool = v56 < infinity
    let v59 : bool =
        if v57 then
            true
        else
            method21(v57)
    let v62 : string = "assert_lt"
    let v63 : string = $"{v62} / actual: %A{v56} / expected: %A{infinity}"
    let v72 : (string -> unit) = System.Console.WriteLine
    v72 v63
    let v77 : bool = v59 = false
    if v77 then
        failwith<unit> v63
    let v78 : string = "$0.im"
    let v79 : float = Fable.Core.RustInterop.emitRustExpr v54 v78 
    let v80 : bool = v79 < infinity
    let v82 : bool =
        if v80 then
            true
        else
            method21(v80)
    let v85 : string = $"{v62} / actual: %A{v79} / expected: %A{infinity}"
    let v94 : (string -> unit) = System.Console.WriteLine
    v94 v85
    let v99 : bool = v82 = false
    if v99 then
        failwith<unit> v85
and method37 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method38(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method41 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(100.0, v0)
    let v2 : UH0 = UH0_1(90.0, v1)
    let v3 : UH0 = UH0_1(80.0, v2)
    let v4 : UH0 = UH0_1(70.0, v3)
    let v5 : UH0 = UH0_1(60.0, v4)
    let v6 : UH0 = UH0_1(50.0, v5)
    let v7 : UH0 = UH0_1(40.0, v6)
    let v8 : UH0 = UH0_1(30.0, v7)
    let v9 : UH0 = UH0_1(20.0, v8)
    UH0_1(10.0, v9)
and method42 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, v2) v4 
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method17(v0, v5)
        let v10 : string = "v8.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v10 
        let v14 : US0 option = None
        let _v14 = ref v14 
        match v11 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v15 : num_complex_Complex<float> = x
        let v16 : US0 = US0_0(v15)
        v16 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v14.Value <- x
        let v17 : US0 option = _v14.Value 
        let v40 : US0 = US0_1
        let v41 : US0 = v17 |> Option.defaultValue v40 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "f64::NAN"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51 
        let v53 : string = "num_complex::Complex::new($0, $1)"
        let v54 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v50, v52) v53 
        let v57 : num_complex_Complex<float> =
            match v41 with
            | US0_1 -> (* None *)
                v54
            | US0_0(v55) -> (* Some *)
                v55
        let v58 : string = "$0.re"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr v57 v58 
        let v62 : bool = v59 <> 0.0 
        let v70 : bool =
            if v62 then
                true
            else
                method21(v62)
        let v73 : string = "assert_ne"
        let v74 : string = $"{v73} / actual: %A{v59} / expected: %A{0.0}"
        let v83 : (string -> unit) = System.Console.WriteLine
        v83 v74
        let v88 : bool = v70 = false
        if v88 then
            failwith<unit> v74
        let v89 : string = "$0.im"
        let v90 : float = Fable.Core.RustInterop.emitRustExpr v57 v89 
        let v93 : bool = v90 <> 0.0 
        let v101 : bool =
            if v93 then
                true
            else
                method21(v93)
        let v104 : string = $"{v73} / actual: %A{v90} / expected: %A{0.0}"
        let v113 : (string -> unit) = System.Console.WriteLine
        v113 v104
        let v118 : bool = v101 = false
        if v118 then
            failwith<unit> v104
        method42(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method40 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method41()
    method42(v0, v1)
and method39 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method40(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method45 () : UH1 =
    let v0 : string = "num_complex::Complex::new($0, $1)"
    let v1 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 14.134725) v0 
    let v2 : string = "num_complex::Complex::new($0, $1)"
    let v3 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.75, 20.5) v2 
    let v4 : string = "num_complex::Complex::new($0, $1)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.25, 30.1) v4 
    let v6 : string = "num_complex::Complex::new($0, $1)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.25, 40.0) v6 
    let v8 : string = "num_complex::Complex::new($0, $1)"
    let v9 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 50.0) v8 
    let v10 : UH1 = UH1_0
    let v11 : UH1 = UH1_1(v9, v10)
    let v12 : UH1 = UH1_1(v7, v11)
    let v13 : UH1 = UH1_1(v5, v12)
    let v14 : UH1 = UH1_1(v3, v13)
    UH1_1(v1, v14)
and method46 (v0 : pyo3_Python, v1 : UH1) : unit =
    match v1 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string = $"        s = mpmath.zeta(s)"
        let v5 : num_complex_Complex<float> = method3(v2)
        let v6 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4, v5)
        let v7 : num_complex_Complex<float> = method17(v0, v2)
        let v8 : string = "v6.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v8 
        let v12 : US0 option = None
        let _v12 = ref v12 
        match v9 with
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
        let v38 : US0 = US0_1
        let v39 : US0 = v15 |> Option.defaultValue v38 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v50) v51 
        let v55 : num_complex_Complex<float> =
            match v39 with
            | US0_1 -> (* None *)
                v52
            | US0_0(v53) -> (* Some *)
                v53
        let v56 : string = "$0.re"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr v55 v56 
        let v60 : bool = v57 <> 0.0 
        let v68 : bool =
            if v60 then
                true
            else
                method21(v60)
        let v71 : string = "assert_ne"
        let v72 : string = $"{v71} / actual: %A{v57} / expected: %A{0.0}"
        let v81 : (string -> unit) = System.Console.WriteLine
        v81 v72
        let v86 : bool = v68 = false
        if v86 then
            failwith<unit> v72
        let v87 : string = "$0.im"
        let v88 : float = Fable.Core.RustInterop.emitRustExpr v55 v87 
        let v91 : bool = v88 <> 0.0 
        let v99 : bool =
            if v91 then
                true
            else
                method21(v91)
        let v102 : string = $"{v71} / actual: %A{v88} / expected: %A{0.0}"
        let v111 : (string -> unit) = System.Console.WriteLine
        v111 v102
        let v116 : bool = v99 = false
        if v116 then
            failwith<unit> v102
        method46(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method44 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method45()
    method46(v0, v1)
and method43 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method44(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method49 () : UH1 =
    let v0 : string = "num_complex::Complex::new($0, $1)"
    let v1 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.0, 4.0) v0 
    let v2 : string = "num_complex::Complex::new($0, $1)"
    let v3 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.5, -3.5) v2 
    let v4 : string = "num_complex::Complex::new($0, $1)"
    let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.5, 2.5) v4 
    let v6 : string = "num_complex::Complex::new($0, $1)"
    let v7 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.5, 14.134725) v6 
    let v8 : UH1 = UH1_0
    let v9 : UH1 = UH1_1(v7, v8)
    let v10 : UH1 = UH1_1(v5, v9)
    let v11 : UH1 = UH1_1(v3, v10)
    UH1_1(v1, v11)
and method50 (v0 : pyo3_Python, v1 : UH1) : unit =
    match v1 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string = $"        s = mpmath.zeta(s)"
        let v5 : num_complex_Complex<float> = method3(v2)
        let v6 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4, v5)
        let v7 : num_complex_Complex<float> = method17(v0, v2)
        let v8 : string = "v6.ok()"
        let v9 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v8 
        let v12 : US0 option = None
        let _v12 = ref v12 
        match v9 with
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
        let v38 : US0 = US0_1
        let v39 : US0 = v15 |> Option.defaultValue v38 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v50) v51 
        let v55 : num_complex_Complex<float> =
            match v39 with
            | US0_1 -> (* None *)
                v52
            | US0_0(v53) -> (* Some *)
                v53
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v56 
        let v58 : string = "num_complex::Complex::powc($0, $1)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v2) v58 
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v60 
        let v62 : string = "num_complex::Complex::new($0, $1)"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v62 
        let v64 : string = "$0 - $1"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v63) v64 
        let v66 : string = "num_complex::Complex::powc($0, $1)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v61, v65) v66 
        let v68 : string = "$0 * $1"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v59, v67) v68 
        let v70 : string = "num_complex::Complex::new($0, $1)"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v70 
        let v72 : string = "$0 * $1"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v71, v2) v72 
        let v74 : string = "num_complex::Complex::new($0, $1)"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v74 
        let v76 : string = "$0 / $1"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v73, v75) v76 
        let v78 : string = "$0.sin()"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v77 v78 
        let v80 : string = "$0 * $1"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v69, v79) v80 
        let v82 : string = "num_complex::Complex::new($0, $1)"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v82 
        let v84 : string = "$0 - $1"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v83, v2) v84 
        let v86 : string = $"        s = mpmath.gamma(s)"
        let v87 : num_complex_Complex<float> = method3(v85)
        let v88 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v86, v87)
        let v89 : string = "v88.ok()"
        let v90 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v89 
        let v93 : US0 option = None
        let _v93 = ref v93 
        match v90 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v94 : num_complex_Complex<float> = x
        let v95 : US0 = US0_0(v94)
        v95 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v93.Value <- x
        let v96 : US0 option = _v93.Value 
        let v119 : US0 = US0_1
        let v120 : US0 = v96 |> Option.defaultValue v119 
        let v128 : string = "f64::NAN"
        let v129 : float = Fable.Core.RustInterop.emitRustExpr () v128 
        let v130 : string = "f64::NAN"
        let v131 : float = Fable.Core.RustInterop.emitRustExpr () v130 
        let v132 : string = "num_complex::Complex::new($0, $1)"
        let v133 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v129, v131) v132 
        let v136 : num_complex_Complex<float> =
            match v120 with
            | US0_1 -> (* None *)
                v133
            | US0_0(v134) -> (* Some *)
                v134
        let v137 : string = "$0 * $1"
        let v138 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v81, v136) v137 
        let v139 : string = "$0.re"
        let v140 : float = Fable.Core.RustInterop.emitRustExpr v2 v139 
        let v141 : float = 1.0 - v140
        let v142 : string = "$0.im"
        let v143 : float = Fable.Core.RustInterop.emitRustExpr v2 v142 
        let v144 : float =  -v143
        let v145 : string = "num_complex::Complex::new($0, $1)"
        let v146 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v141, v144) v145 
        let v147 : string = $"        s = mpmath.zeta(s)"
        let v148 : num_complex_Complex<float> = method3(v146)
        let v149 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v147, v148)
        let v150 : num_complex_Complex<float> = method17(v0, v146)
        let v151 : string = "v149.ok()"
        let v152 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v151 
        let v155 : US0 option = None
        let _v155 = ref v155 
        match v152 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v156 : num_complex_Complex<float> = x
        let v157 : US0 = US0_0(v156)
        v157 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v155.Value <- x
        let v158 : US0 option = _v155.Value 
        let v181 : US0 = US0_1
        let v182 : US0 = v158 |> Option.defaultValue v181 
        let v190 : string = "f64::NAN"
        let v191 : float = Fable.Core.RustInterop.emitRustExpr () v190 
        let v192 : string = "f64::NAN"
        let v193 : float = Fable.Core.RustInterop.emitRustExpr () v192 
        let v194 : string = "num_complex::Complex::new($0, $1)"
        let v195 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v191, v193) v194 
        let v198 : num_complex_Complex<float> =
            match v182 with
            | US0_1 -> (* None *)
                v195
            | US0_0(v196) -> (* Some *)
                v196
        let v199 : string = "$0 * $1"
        let v200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v138, v198) v199 
        let v201 : string = "$0.re"
        let v202 : float = Fable.Core.RustInterop.emitRustExpr v55 v201 
        let v203 : string = "$0.re"
        let v204 : float = Fable.Core.RustInterop.emitRustExpr v200 v203 
        let v205 : float = v202 - v204
        let v206 : float =  -v205
        let v207 : bool = v205 >= v206
        let v208 : float =
            if v207 then
                v205
            else
                v206
        let v209 : bool = v208 < 0.0001
        let v211 : bool =
            if v209 then
                true
            else
                method21(v209)
        let v214 : string = "assert_lt"
        let v215 : string = $"{v214} / actual: %A{v208} / expected: %A{0.0001}"
        let v224 : (string -> unit) = System.Console.WriteLine
        v224 v215
        let v229 : bool = v211 = false
        if v229 then
            failwith<unit> v215
        let v230 : string = "$0.im"
        let v231 : float = Fable.Core.RustInterop.emitRustExpr v55 v230 
        let v232 : string = "$0.im"
        let v233 : float = Fable.Core.RustInterop.emitRustExpr v200 v232 
        let v234 : float = v231 - v233
        let v235 : float =  -v234
        let v236 : bool = v234 >= v235
        let v237 : float =
            if v236 then
                v234
            else
                v235
        let v238 : bool = v237 < 0.0001
        let v240 : bool =
            if v238 then
                true
            else
                method21(v238)
        let v243 : string = $"{v214} / actual: %A{v237} / expected: %A{0.0001}"
        let v252 : (string -> unit) = System.Console.WriteLine
        v252 v243
        let v257 : bool = v240 = false
        if v257 then
            failwith<unit> v243
        method50(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method48 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method49()
    method50(v0, v1)
and method47 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method48(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
and method53 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(5.0, v0)
    let v2 : UH0 = UH0_1(4.5, v1)
    let v3 : UH0 = UH0_1(4.0, v2)
    let v4 : UH0 = UH0_1(3.5, v3)
    let v5 : UH0 = UH0_1(3.0, v4)
    let v6 : UH0 = UH0_1(2.5, v5)
    UH0_1(2.0, v6)
and method54 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(71.0, v0)
    let v2 : UH0 = UH0_1(67.0, v1)
    let v3 : UH0 = UH0_1(61.0, v2)
    let v4 : UH0 = UH0_1(59.0, v3)
    let v5 : UH0 = UH0_1(53.0, v4)
    let v6 : UH0 = UH0_1(47.0, v5)
    let v7 : UH0 = UH0_1(43.0, v6)
    let v8 : UH0 = UH0_1(41.0, v7)
    let v9 : UH0 = UH0_1(37.0, v8)
    let v10 : UH0 = UH0_1(31.0, v9)
    let v11 : UH0 = UH0_1(29.0, v10)
    let v12 : UH0 = UH0_1(23.0, v11)
    let v13 : UH0 = UH0_1(19.0, v12)
    let v14 : UH0 = UH0_1(17.0, v13)
    let v15 : UH0 = UH0_1(13.0, v14)
    let v16 : UH0 = UH0_1(11.0, v15)
    let v17 : UH0 = UH0_1(7.0, v16)
    let v18 : UH0 = UH0_1(5.0, v17)
    let v19 : UH0 = UH0_1(3.0, v18)
    UH0_1(2.0, v19)
and method56 (v0 : float, v1 : UH0, v2 : float) : float =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : float =  -v0
        let v6 : float = v3 ** v5
        let v7 : float = 1.0 - v6
        let v8 : float = v2 / v7
        method56(v0, v4, v8)
    | UH0_0 -> (* Nil *)
        v2
and method55 (v0 : pyo3_Python, v1 : UH0, v2 : UH0) : unit =
    match v2 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : string = "num_complex::Complex::new($0, $1)"
        let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3, 0.0) v5 
        let v7 : float = 1.0
        let v8 : float = method56(v3, v1, v7)
        let v9 : string = $"        s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method3(v6)
        let v11 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9, v10)
        let v12 : num_complex_Complex<float> = method17(v0, v6)
        let v13 : string = "v11.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v13 
        let v17 : US0 option = None
        let _v17 = ref v17 
        match v14 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v18 : num_complex_Complex<float> = x
        let v19 : US0 = US0_0(v18)
        v19 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v17.Value <- x
        let v20 : US0 option = _v17.Value 
        let v43 : US0 = US0_1
        let v44 : US0 = v20 |> Option.defaultValue v43 
        let v52 : string = "f64::NAN"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52 
        let v54 : string = "f64::NAN"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr () v54 
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v55) v56 
        let v60 : num_complex_Complex<float> =
            match v44 with
            | US0_1 -> (* None *)
                v57
            | US0_0(v58) -> (* Some *)
                v58
        let v61 : string = "$0.re"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr v60 v61 
        let v63 : float = v62 - v8
        let v64 : float =  -v63
        let v65 : bool = v63 >= v64
        let v66 : float =
            if v65 then
                v63
            else
                v64
        let v67 : bool = v66 < 0.01
        let v69 : bool =
            if v67 then
                true
            else
                method21(v67)
        let v72 : string = "assert_lt"
        let v73 : string = $"{v72} / actual: %A{v66} / expected: %A{0.01}"
        let v82 : (string -> unit) = System.Console.WriteLine
        v82 v73
        let v87 : bool = v69 = false
        if v87 then
            failwith<unit> v73
        let v88 : string = "$0.im"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr v60 v88 
        let v90 : bool = v89 < 0.01
        let v92 : bool =
            if v90 then
                true
            else
                method21(v90)
        let v95 : string = $"{v72} / actual: %A{v89} / expected: %A{0.01}"
        let v104 : (string -> unit) = System.Console.WriteLine
        v104 v95
        let v109 : bool = v92 = false
        if v109 then
            failwith<unit> v95
        method55(v0, v1, v4)
    | UH0_0 -> (* Nil *)
        ()
and method52 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method53()
    let v2 : UH0 = method54()
    method55(v0, v2, v1)
and method51 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __result = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method52(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method22(v4)
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
    method23()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    method25()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16 
    method29()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    method31()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    method33()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28 
    method35()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    method37()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    method39()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
    method43()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
    method47()
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
and closure5 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    let v4 : (string -> unit) = System.Console.WriteLine
    v4 v1
    0
let v30 : (unit -> unit) = closure0()
let tests () = v30 ()
let v31 : ((string []) -> int32) = closure5()
let main args = v31 args
()
