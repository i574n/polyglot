#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Python")>]
#endif
type pyo3_Python = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("num_complex::Complex<$0>")>]
#endif
type num_complex_Complex<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyErr")>]
#endif
type pyo3_PyErr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
#endif
type std_string_String = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Bound<$0>")>]
#endif
type pyo3_Bound<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
#endif
type Str = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::types::PyModule")>]
#endif
type pyo3_types_PyModule = class end
Fable.Core.RustInterop.emitRustExpr () ");
use pyo3::prelude::PyAnyMethods;
//"
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyAny")>]
#endif
type pyo3_PyAny = class end
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
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
    let v17 : std_string_String = _v1 
    v17
and method8 () : (pyo3_PyErr -> std_string_String) =
    closure1()
and method9 () : string =
    let v0 : string = "fn"
    v0
and method10 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and closure2 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
    let v17 : std_string_String = _v1 
    v17
and method11 () : (pyo3_PyErr -> std_string_String) =
    closure2()
and method12 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method13 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure3 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
    let v17 : std_string_String = _v1 
    v17
and method14 () : (pyo3_PyErr -> std_string_String) =
    closure3()
and method15 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and closure4 () (v0 : pyo3_PyErr) : std_string_String =
    let v1 : unit = ()
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2 : string = "format!(\"{}\", $0)"
    let v3 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v2 
    let _v1 = v3 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v4 : string = "format!(\"{}\", $0)"
    let v5 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v4 
    let _v1 = v5 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v6 : string = "format!(\"{}\", $0)"
    let v7 : std_string_String = Fable.Core.RustInterop.emitRustExpr v0 v6 
    let _v1 = v7 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v8 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v8 
    #endif
#if FABLE_COMPILER_PYTHON
    let v11 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v11 
    #endif
#else
    let v14 : std_string_String = null |> unbox<std_string_String>
    let _v1 = v14 
    #endif
    let v17 : std_string_String = _v1 
    v17
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
        let v42 : US0 option = None
        let _v42 = ref v42 
        match v41 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v43 : num_complex_Complex<float> = x
        let v44 : US0 = US0_0(v43)
        v44 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v42.Value <- x
        let v45 : US0 option = _v42.Value 
        let v56 : US0 = US0_1
        let v57 : US0 = v45 |> Option.defaultValue v56 
        let v61 : string = "f64::NAN"
        let v62 : float = Fable.Core.RustInterop.emitRustExpr () v61 
        let v63 : string = "f64::NAN"
        let v64 : float = Fable.Core.RustInterop.emitRustExpr () v63 
        let v65 : string = "num_complex::Complex::new($0, $1)"
        let v66 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v62, v64) v65 
        let v69 : num_complex_Complex<float> =
            match v57 with
            | US0_1 -> (* None *)
                v66
            | US0_0(v67) -> (* Some *)
                v67
        let v70 : string = "num_complex::Complex::new($0, $1)"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v70 
        let v72 : string = "$0 * $1"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v71, v1) v72 
        let v74 : string = "num_complex::Complex::new($0, $1)"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v74 
        let v76 : string = "$0 / $1"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v73, v75) v76 
        let v78 : string = "$0.sin()"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v77 v78 
        let v80 : string = "$0.re"
        let v81 : float = Fable.Core.RustInterop.emitRustExpr v1 v80 
        let v82 : float = 1.0 - v81
        let v83 : string = "$0.im"
        let v84 : float = Fable.Core.RustInterop.emitRustExpr v1 v83 
        let v85 : float =  -v84
        let v86 : string = "num_complex::Complex::new($0, $1)"
        let v87 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v82, v85) v86 
        let v88 : string = "$0.re"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr v87 v88 
        let v90 : bool = v89 <= 1.0
        let v521 : num_complex_Complex<float> =
            if v90 then
                let v91 : string = "num_complex::Complex::new($0, $1)"
                let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v91 
                v92
            else
                let v93 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v87) v93 
                let v94 : string = "$0.re"
                let v95 : float = Fable.Core.RustInterop.emitRustExpr v87 v94 
                let v96 : bool = v95 > 1.0
                if v96 then
                    let v97 : string = "num_complex::Complex::new($0, $1)"
                    let v98 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v97 
                    let v99 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v100 : Mut0 = {l0 = 0} : Mut0
                    while method18(v100) do
                        let v102 : int32 = v100.l0
                        v99.[int v102] <- v102
                        let v103 : int32 = v102 + 1
                        v100.l0 <- v103
                        ()
                    let v104 : int32 = v99.Length
                    let v105 : Mut2 = {l0 = 0; l1 = v98} : Mut2
                    while method19(v104, v105) do
                        let v107 : int32 = v105.l0
                        let v108 : num_complex_Complex<float> = v105.l1
                        let v109 : int32 = v99.[int v107]
                        let v110 : string = "num_complex::Complex::new($0, $1)"
                        let v111 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v110 
                        let v112 : (int32 -> float) = float
                        let v113 : float = v112 v109
                        let v114 : string = "num_complex::Complex::new($0, $1)"
                        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v113, 0.0) v114 
                        let v116 : string = "num_complex::Complex::powc($0, $1)"
                        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v115, v87) v116 
                        let v118 : string = "$0 / $1"
                        let v119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v111, v117) v118 
                        let v120 : string = "$0 + $1"
                        let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v108, v119) v120 
                        let v122 : int32 = v107 + 1
                        v105.l0 <- v122
                        v105.l1 <- v121
                        ()
                    let v123 : num_complex_Complex<float> = v105.l1
                    v123
                else
                    let v124 : string = "num_complex::Complex::new($0, $1)"
                    let v125 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v124 
                    let v126 : string = "$0 - $1"
                    let v127 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v125, v87) v126 
                    let v128 : string = $"        s = mpmath.gamma(s)"
                    let v129 : num_complex_Complex<float> = method3(v127)
                    let v130 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v128, v129)
                    let v131 : string = "v130.ok()"
                    let v132 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v131 
                    let v133 : US0 option = None
                    let _v133 = ref v133 
                    match v132 with
                    | Some x -> (
                    (fun () ->
                    (fun () ->
                    let v134 : num_complex_Complex<float> = x
                    let v135 : US0 = US0_0(v134)
                    v135 
                    )
                    |> fun x -> x () |> Some
                    ) () ) | None -> None
                    |> fun x -> _v133.Value <- x
                    let v136 : US0 option = _v133.Value 
                    let v147 : US0 = US0_1
                    let v148 : US0 = v136 |> Option.defaultValue v147 
                    let v152 : string = "f64::NAN"
                    let v153 : float = Fable.Core.RustInterop.emitRustExpr () v152 
                    let v154 : string = "f64::NAN"
                    let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154 
                    let v156 : string = "num_complex::Complex::new($0, $1)"
                    let v157 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v153, v155) v156 
                    let v160 : num_complex_Complex<float> =
                        match v148 with
                        | US0_1 -> (* None *)
                            v157
                        | US0_0(v158) -> (* Some *)
                            v158
                    let v161 : string = "num_complex::Complex::new($0, $1)"
                    let v162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v161 
                    let v163 : string = "$0 * $1"
                    let v164 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v162, v87) v163 
                    let v165 : string = "num_complex::Complex::new($0, $1)"
                    let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v165 
                    let v167 : string = "$0 / $1"
                    let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v164, v166) v167 
                    let v169 : string = "$0.sin()"
                    let v170 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v168 v169 
                    let v171 : string = "$0.re"
                    let v172 : float = Fable.Core.RustInterop.emitRustExpr v87 v171 
                    let v173 : float = 1.0 - v172
                    let v174 : string = "$0.im"
                    let v175 : float = Fable.Core.RustInterop.emitRustExpr v87 v174 
                    let v176 : float =  -v175
                    let v177 : string = "num_complex::Complex::new($0, $1)"
                    let v178 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v173, v176) v177 
                    let v179 : string = "$0.re"
                    let v180 : float = Fable.Core.RustInterop.emitRustExpr v178 v179 
                    let v181 : bool = v180 <= 1.0
                    let v505 : num_complex_Complex<float> =
                        if v181 then
                            let v182 : string = "num_complex::Complex::new($0, $1)"
                            let v183 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v182 
                            v183
                        else
                            let v184 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v178) v184 
                            let v185 : string = "$0.re"
                            let v186 : float = Fable.Core.RustInterop.emitRustExpr v178 v185 
                            let v187 : bool = v186 > 1.0
                            if v187 then
                                let v188 : string = "num_complex::Complex::new($0, $1)"
                                let v189 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v188 
                                let v190 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v191 : Mut0 = {l0 = 0} : Mut0
                                while method18(v191) do
                                    let v193 : int32 = v191.l0
                                    v190.[int v193] <- v193
                                    let v194 : int32 = v193 + 1
                                    v191.l0 <- v194
                                    ()
                                let v195 : int32 = v190.Length
                                let v196 : Mut2 = {l0 = 0; l1 = v189} : Mut2
                                while method19(v195, v196) do
                                    let v198 : int32 = v196.l0
                                    let v199 : num_complex_Complex<float> = v196.l1
                                    let v200 : int32 = v190.[int v198]
                                    let v201 : string = "num_complex::Complex::new($0, $1)"
                                    let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v201 
                                    let v203 : (int32 -> float) = float
                                    let v204 : float = v203 v200
                                    let v205 : string = "num_complex::Complex::new($0, $1)"
                                    let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v204, 0.0) v205 
                                    let v207 : string = "num_complex::Complex::powc($0, $1)"
                                    let v208 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v206, v178) v207 
                                    let v209 : string = "$0 / $1"
                                    let v210 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v202, v208) v209 
                                    let v211 : string = "$0 + $1"
                                    let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v199, v210) v211 
                                    let v213 : int32 = v198 + 1
                                    v196.l0 <- v213
                                    v196.l1 <- v212
                                    ()
                                let v214 : num_complex_Complex<float> = v196.l1
                                v214
                            else
                                let v215 : string = "num_complex::Complex::new($0, $1)"
                                let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v215 
                                let v217 : string = "$0 - $1"
                                let v218 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v216, v178) v217 
                                let v219 : string = $"        s = mpmath.gamma(s)"
                                let v220 : num_complex_Complex<float> = method3(v218)
                                let v221 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v219, v220)
                                let v222 : string = "v221.ok()"
                                let v223 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v222 
                                let v224 : US0 option = None
                                let _v224 = ref v224 
                                match v223 with
                                | Some x -> (
                                (fun () ->
                                (fun () ->
                                let v225 : num_complex_Complex<float> = x
                                let v226 : US0 = US0_0(v225)
                                v226 
                                )
                                |> fun x -> x () |> Some
                                ) () ) | None -> None
                                |> fun x -> _v224.Value <- x
                                let v227 : US0 option = _v224.Value 
                                let v238 : US0 = US0_1
                                let v239 : US0 = v227 |> Option.defaultValue v238 
                                let v243 : string = "f64::NAN"
                                let v244 : float = Fable.Core.RustInterop.emitRustExpr () v243 
                                let v245 : string = "f64::NAN"
                                let v246 : float = Fable.Core.RustInterop.emitRustExpr () v245 
                                let v247 : string = "num_complex::Complex::new($0, $1)"
                                let v248 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v244, v246) v247 
                                let v251 : num_complex_Complex<float> =
                                    match v239 with
                                    | US0_1 -> (* None *)
                                        v248
                                    | US0_0(v249) -> (* Some *)
                                        v249
                                let v252 : string = "num_complex::Complex::new($0, $1)"
                                let v253 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v252 
                                let v254 : string = "$0 * $1"
                                let v255 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v253, v178) v254 
                                let v256 : string = "num_complex::Complex::new($0, $1)"
                                let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v256 
                                let v258 : string = "$0 / $1"
                                let v259 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v255, v257) v258 
                                let v260 : string = "$0.sin()"
                                let v261 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v259 v260 
                                let v262 : string = "$0.re"
                                let v263 : float = Fable.Core.RustInterop.emitRustExpr v178 v262 
                                let v264 : float = 1.0 - v263
                                let v265 : string = "$0.im"
                                let v266 : float = Fable.Core.RustInterop.emitRustExpr v178 v265 
                                let v267 : float =  -v266
                                let v268 : string = "num_complex::Complex::new($0, $1)"
                                let v269 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v264, v267) v268 
                                let v270 : string = "$0.re"
                                let v271 : float = Fable.Core.RustInterop.emitRustExpr v269 v270 
                                let v272 : bool = v271 <= 1.0
                                let v489 : num_complex_Complex<float> =
                                    if v272 then
                                        let v273 : string = "num_complex::Complex::new($0, $1)"
                                        let v274 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v273 
                                        v274
                                    else
                                        let v275 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v269) v275 
                                        let v276 : string = "$0.re"
                                        let v277 : float = Fable.Core.RustInterop.emitRustExpr v269 v276 
                                        let v278 : bool = v277 > 1.0
                                        if v278 then
                                            let v279 : string = "num_complex::Complex::new($0, $1)"
                                            let v280 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v279 
                                            let v281 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v282 : Mut0 = {l0 = 0} : Mut0
                                            while method18(v282) do
                                                let v284 : int32 = v282.l0
                                                v281.[int v284] <- v284
                                                let v285 : int32 = v284 + 1
                                                v282.l0 <- v285
                                                ()
                                            let v286 : int32 = v281.Length
                                            let v287 : Mut2 = {l0 = 0; l1 = v280} : Mut2
                                            while method19(v286, v287) do
                                                let v289 : int32 = v287.l0
                                                let v290 : num_complex_Complex<float> = v287.l1
                                                let v291 : int32 = v281.[int v289]
                                                let v292 : string = "num_complex::Complex::new($0, $1)"
                                                let v293 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v292 
                                                let v294 : (int32 -> float) = float
                                                let v295 : float = v294 v291
                                                let v296 : string = "num_complex::Complex::new($0, $1)"
                                                let v297 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v295, 0.0) v296 
                                                let v298 : string = "num_complex::Complex::powc($0, $1)"
                                                let v299 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v297, v269) v298 
                                                let v300 : string = "$0 / $1"
                                                let v301 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v293, v299) v300 
                                                let v302 : string = "$0 + $1"
                                                let v303 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v290, v301) v302 
                                                let v304 : int32 = v289 + 1
                                                v287.l0 <- v304
                                                v287.l1 <- v303
                                                ()
                                            let v305 : num_complex_Complex<float> = v287.l1
                                            v305
                                        else
                                            let v306 : string = "num_complex::Complex::new($0, $1)"
                                            let v307 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v306 
                                            let v308 : string = "$0 - $1"
                                            let v309 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v307, v269) v308 
                                            let v310 : string = $"        s = mpmath.gamma(s)"
                                            let v311 : num_complex_Complex<float> = method3(v309)
                                            let v312 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v310, v311)
                                            let v313 : string = "v312.ok()"
                                            let v314 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v313 
                                            let v315 : US0 option = None
                                            let _v315 = ref v315 
                                            match v314 with
                                            | Some x -> (
                                            (fun () ->
                                            (fun () ->
                                            let v316 : num_complex_Complex<float> = x
                                            let v317 : US0 = US0_0(v316)
                                            v317 
                                            )
                                            |> fun x -> x () |> Some
                                            ) () ) | None -> None
                                            |> fun x -> _v315.Value <- x
                                            let v318 : US0 option = _v315.Value 
                                            let v329 : US0 = US0_1
                                            let v330 : US0 = v318 |> Option.defaultValue v329 
                                            let v334 : string = "f64::NAN"
                                            let v335 : float = Fable.Core.RustInterop.emitRustExpr () v334 
                                            let v336 : string = "f64::NAN"
                                            let v337 : float = Fable.Core.RustInterop.emitRustExpr () v336 
                                            let v338 : string = "num_complex::Complex::new($0, $1)"
                                            let v339 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v335, v337) v338 
                                            let v342 : num_complex_Complex<float> =
                                                match v330 with
                                                | US0_1 -> (* None *)
                                                    v339
                                                | US0_0(v340) -> (* Some *)
                                                    v340
                                            let v343 : string = "num_complex::Complex::new($0, $1)"
                                            let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v343 
                                            let v345 : string = "$0 * $1"
                                            let v346 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v344, v269) v345 
                                            let v347 : string = "num_complex::Complex::new($0, $1)"
                                            let v348 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v347 
                                            let v349 : string = "$0 / $1"
                                            let v350 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v346, v348) v349 
                                            let v351 : string = "$0.sin()"
                                            let v352 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v350 v351 
                                            let v353 : string = "$0.re"
                                            let v354 : float = Fable.Core.RustInterop.emitRustExpr v269 v353 
                                            let v355 : float = 1.0 - v354
                                            let v356 : string = "$0.im"
                                            let v357 : float = Fable.Core.RustInterop.emitRustExpr v269 v356 
                                            let v358 : float =  -v357
                                            let v359 : string = "num_complex::Complex::new($0, $1)"
                                            let v360 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v355, v358) v359 
                                            let v361 : string = "$0.re"
                                            let v362 : float = Fable.Core.RustInterop.emitRustExpr v360 v361 
                                            let v363 : bool = v362 <= 1.0
                                            let v473 : num_complex_Complex<float> =
                                                if v363 then
                                                    let v364 : string = "num_complex::Complex::new($0, $1)"
                                                    let v365 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v364 
                                                    v365
                                                else
                                                    let v366 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v360) v366 
                                                    let v367 : string = "$0.re"
                                                    let v368 : float = Fable.Core.RustInterop.emitRustExpr v360 v367 
                                                    let v369 : bool = v368 > 1.0
                                                    if v369 then
                                                        let v370 : string = "num_complex::Complex::new($0, $1)"
                                                        let v371 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v370 
                                                        let v372 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v373 : Mut0 = {l0 = 0} : Mut0
                                                        while method18(v373) do
                                                            let v375 : int32 = v373.l0
                                                            v372.[int v375] <- v375
                                                            let v376 : int32 = v375 + 1
                                                            v373.l0 <- v376
                                                            ()
                                                        let v377 : int32 = v372.Length
                                                        let v378 : Mut2 = {l0 = 0; l1 = v371} : Mut2
                                                        while method19(v377, v378) do
                                                            let v380 : int32 = v378.l0
                                                            let v381 : num_complex_Complex<float> = v378.l1
                                                            let v382 : int32 = v372.[int v380]
                                                            let v383 : string = "num_complex::Complex::new($0, $1)"
                                                            let v384 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v383 
                                                            let v385 : (int32 -> float) = float
                                                            let v386 : float = v385 v382
                                                            let v387 : string = "num_complex::Complex::new($0, $1)"
                                                            let v388 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v386, 0.0) v387 
                                                            let v389 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v390 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v388, v360) v389 
                                                            let v391 : string = "$0 / $1"
                                                            let v392 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v384, v390) v391 
                                                            let v393 : string = "$0 + $1"
                                                            let v394 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v381, v392) v393 
                                                            let v395 : int32 = v380 + 1
                                                            v378.l0 <- v395
                                                            v378.l1 <- v394
                                                            ()
                                                        let v396 : num_complex_Complex<float> = v378.l1
                                                        v396
                                                    else
                                                        let v397 : string = "num_complex::Complex::new($0, $1)"
                                                        let v398 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v397 
                                                        let v399 : string = "$0 - $1"
                                                        let v400 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v398, v360) v399 
                                                        let v401 : string = $"        s = mpmath.gamma(s)"
                                                        let v402 : num_complex_Complex<float> = method3(v400)
                                                        let v403 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v401, v402)
                                                        let v404 : string = "v403.ok()"
                                                        let v405 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v404 
                                                        let v406 : US0 option = None
                                                        let _v406 = ref v406 
                                                        match v405 with
                                                        | Some x -> (
                                                        (fun () ->
                                                        (fun () ->
                                                        let v407 : num_complex_Complex<float> = x
                                                        let v408 : US0 = US0_0(v407)
                                                        v408 
                                                        )
                                                        |> fun x -> x () |> Some
                                                        ) () ) | None -> None
                                                        |> fun x -> _v406.Value <- x
                                                        let v409 : US0 option = _v406.Value 
                                                        let v420 : US0 = US0_1
                                                        let v421 : US0 = v409 |> Option.defaultValue v420 
                                                        let v425 : string = "f64::NAN"
                                                        let v426 : float = Fable.Core.RustInterop.emitRustExpr () v425 
                                                        let v427 : string = "f64::NAN"
                                                        let v428 : float = Fable.Core.RustInterop.emitRustExpr () v427 
                                                        let v429 : string = "num_complex::Complex::new($0, $1)"
                                                        let v430 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v426, v428) v429 
                                                        let v433 : num_complex_Complex<float> =
                                                            match v421 with
                                                            | US0_1 -> (* None *)
                                                                v430
                                                            | US0_0(v431) -> (* Some *)
                                                                v431
                                                        let v434 : string = "num_complex::Complex::new($0, $1)"
                                                        let v435 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v434 
                                                        let v436 : string = "$0 * $1"
                                                        let v437 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v435, v360) v436 
                                                        let v438 : string = "num_complex::Complex::new($0, $1)"
                                                        let v439 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v438 
                                                        let v440 : string = "$0 / $1"
                                                        let v441 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v437, v439) v440 
                                                        let v442 : string = "$0.sin()"
                                                        let v443 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v441 v442 
                                                        let v444 : string = "$0.re"
                                                        let v445 : float = Fable.Core.RustInterop.emitRustExpr v360 v444 
                                                        let v446 : float = 1.0 - v445
                                                        let v447 : string = "$0.im"
                                                        let v448 : float = Fable.Core.RustInterop.emitRustExpr v360 v447 
                                                        let v449 : float =  -v448
                                                        let v450 : string = "num_complex::Complex::new($0, $1)"
                                                        let v451 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v446, v449) v450 
                                                        let v452 : string = "$0.re"
                                                        let v453 : float = Fable.Core.RustInterop.emitRustExpr v451 v452 
                                                        let v454 : bool = v453 <= 1.0
                                                        let v457 : num_complex_Complex<float> =
                                                            if v454 then
                                                                let v455 : string = "num_complex::Complex::new($0, $1)"
                                                                let v456 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v455 
                                                                v456
                                                            else
                                                                v451
                                                        let v458 : string = "num_complex::Complex::new($0, $1)"
                                                        let v459 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v458 
                                                        let v460 : string = "num_complex::Complex::new($0, $1)"
                                                        let v461 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v460 
                                                        let v462 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v463 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v461, v360) v462 
                                                        let v464 : string = "$0 * $1"
                                                        let v465 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v459, v463) v464 
                                                        let v466 : string = "$0 * $1"
                                                        let v467 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v465, v443) v466 
                                                        let v468 : string = "$0 * $1"
                                                        let v469 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v467, v433) v468 
                                                        let v470 : string = "$0 * $1"
                                                        let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v469, v457) v470 
                                                        v471
                                            let v474 : string = "num_complex::Complex::new($0, $1)"
                                            let v475 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v474 
                                            let v476 : string = "num_complex::Complex::new($0, $1)"
                                            let v477 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v476 
                                            let v478 : string = "num_complex::Complex::powc($0, $1)"
                                            let v479 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v477, v269) v478 
                                            let v480 : string = "$0 * $1"
                                            let v481 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v475, v479) v480 
                                            let v482 : string = "$0 * $1"
                                            let v483 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v481, v352) v482 
                                            let v484 : string = "$0 * $1"
                                            let v485 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v483, v342) v484 
                                            let v486 : string = "$0 * $1"
                                            let v487 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v485, v473) v486 
                                            v487
                                let v490 : string = "num_complex::Complex::new($0, $1)"
                                let v491 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v490 
                                let v492 : string = "num_complex::Complex::new($0, $1)"
                                let v493 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v492 
                                let v494 : string = "num_complex::Complex::powc($0, $1)"
                                let v495 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v493, v178) v494 
                                let v496 : string = "$0 * $1"
                                let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v491, v495) v496 
                                let v498 : string = "$0 * $1"
                                let v499 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v497, v261) v498 
                                let v500 : string = "$0 * $1"
                                let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v499, v251) v500 
                                let v502 : string = "$0 * $1"
                                let v503 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v501, v489) v502 
                                v503
                    let v506 : string = "num_complex::Complex::new($0, $1)"
                    let v507 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v506 
                    let v508 : string = "num_complex::Complex::new($0, $1)"
                    let v509 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v508 
                    let v510 : string = "num_complex::Complex::powc($0, $1)"
                    let v511 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v509, v87) v510 
                    let v512 : string = "$0 * $1"
                    let v513 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v507, v511) v512 
                    let v514 : string = "$0 * $1"
                    let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v513, v170) v514 
                    let v516 : string = "$0 * $1"
                    let v517 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v515, v160) v516 
                    let v518 : string = "$0 * $1"
                    let v519 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v517, v505) v518 
                    v519
        let v522 : string = "num_complex::Complex::new($0, $1)"
        let v523 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v522 
        let v524 : string = "num_complex::Complex::new($0, $1)"
        let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v524 
        let v526 : string = "num_complex::Complex::powc($0, $1)"
        let v527 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v525, v1) v526 
        let v528 : string = "$0 * $1"
        let v529 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v523, v527) v528 
        let v530 : string = "$0 * $1"
        let v531 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v529, v79) v530 
        let v532 : string = "$0 * $1"
        let v533 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v531, v69) v532 
        let v534 : string = "$0 * $1"
        let v535 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v533, v521) v534 
        v535
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
        let v32 : US0 = US0_1
        let v33 : US0 = v21 |> Option.defaultValue v32 
        let v37 : string = "f64::NAN"
        let v38 : float = Fable.Core.RustInterop.emitRustExpr () v37 
        let v39 : string = "f64::NAN"
        let v40 : float = Fable.Core.RustInterop.emitRustExpr () v39 
        let v41 : string = "num_complex::Complex::new($0, $1)"
        let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v38, v40) v41 
        let v45 : num_complex_Complex<float> =
            match v33 with
            | US0_1 -> (* None *)
                v42
            | US0_0(v43) -> (* Some *)
                v43
        let v46 : string = "$0.im"
        let v47 : float = Fable.Core.RustInterop.emitRustExpr v45 v46 
        let v48 : bool = v47 = 0.0
        let v50 : bool =
            if v48 then
                true
            else
                method21(v48)
        let v51 : string = "__assert_eq"
        let v52 : string = $"{v51} / actual: %A{v47} / expected: %A{0.0}"
        v52 |> System.Console.WriteLine
        let v55 : bool = v50 = false
        if v55 then
            failwith<unit> v52
        let v56 : string = "$0.re"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr v45 v56 
        let v58 : float = v57 - v11
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
                method21(v62)
        let v65 : string = "__assert_lt"
        let v66 : string = $"{v65} / actual: %A{v61} / expected: %A{0.0001}"
        v66 |> System.Console.WriteLine
        let v69 : bool = v64 = false
        if v69 then
            failwith<unit> v66
        let v70 : int32 = v9 + 1
        v7.l0 <- v70
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
    let v23 : US0 = US0_1
    let v24 : US0 = v12 |> Option.defaultValue v23 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "f64::NAN"
    let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "num_complex::Complex::new($0, $1)"
    let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v32 
    let v36 : num_complex_Complex<float> =
        match v24 with
        | US0_1 -> (* None *)
            v33
        | US0_0(v34) -> (* Some *)
            v34
    let v37 : string = "$0.re"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : float = v38 - 0.8673
    let v40 : float =  -v39
    let v41 : bool = v39 >= v40
    let v42 : float =
        if v41 then
            v39
        else
            v40
    let v43 : bool = v42 < 0.001
    let v45 : bool =
        if v43 then
            true
        else
            method21(v43)
    let v46 : string = "__assert_lt"
    let v47 : string = $"{v46} / actual: %A{v42} / expected: %A{0.001}"
    v47 |> System.Console.WriteLine
    let v50 : bool = v45 = false
    if v50 then
        failwith<unit> v47
    let v51 : string = "$0.im"
    let v52 : float = Fable.Core.RustInterop.emitRustExpr v36 v51 
    let v53 : float = v52 - 0.275
    let v54 : float =  -v53
    let v55 : bool = v53 >= v54
    let v56 : float =
        if v55 then
            v53
        else
            v54
    let v57 : bool = v56 < 0.001
    let v59 : bool =
        if v57 then
            true
        else
            method21(v57)
    let v60 : string = $"{v46} / actual: %A{v56} / expected: %A{0.001}"
    v60 |> System.Console.WriteLine
    let v63 : bool = v59 = false
    if v63 then
        failwith<unit> v60
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v26 : US0 = US0_1
        let v27 : US0 = v15 |> Option.defaultValue v26 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "f64::NAN"
        let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33 
        let v35 : string = "num_complex::Complex::new($0, $1)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v32, v34) v35 
        let v39 : num_complex_Complex<float> =
            match v27 with
            | US0_1 -> (* None *)
                v36
            | US0_0(v37) -> (* Some *)
                v37
        let v40 : string = "$0.re"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr v39 v40 
        let v42 : bool = v41 = 0.0
        let v44 : bool =
            if v42 then
                true
            else
                method21(v42)
        let v45 : string = "__assert_eq"
        let v46 : string = $"{v45} / actual: %A{v41} / expected: %A{0.0}"
        v46 |> System.Console.WriteLine
        let v49 : bool = v44 = false
        if v49 then
            failwith<unit> v46
        let v50 : string = "$0.im"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr v39 v50 
        let v52 : bool = v51 = 0.0
        let v54 : bool =
            if v52 then
                true
            else
                method21(v52)
        let v55 : string = $"{v45} / actual: %A{v51} / expected: %A{0.0}"
        v55 |> System.Console.WriteLine
        let v58 : bool = v54 = false
        if v58 then
            failwith<unit> v55
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v39 : US0 = US0_1
        let v40 : US0 = v28 |> Option.defaultValue v39 
        let v44 : string = "f64::NAN"
        let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44 
        let v46 : string = "f64::NAN"
        let v47 : float = Fable.Core.RustInterop.emitRustExpr () v46 
        let v48 : string = "num_complex::Complex::new($0, $1)"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v45, v47) v48 
        let v52 : num_complex_Complex<float> =
            match v40 with
            | US0_1 -> (* None *)
                v49
            | US0_0(v50) -> (* Some *)
                v50
        let v53 : string = "$0.re"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr v52 v53 
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
                method21(v58)
        let v61 : string = "__assert_lt"
        let v62 : string = $"{v61} / actual: %A{v57} / expected: %A{0.0001}"
        v62 |> System.Console.WriteLine
        let v65 : bool = v60 = false
        if v65 then
            failwith<unit> v62
        let v66 : string = "$0.im"
        let v67 : float = Fable.Core.RustInterop.emitRustExpr v52 v66 
        let v68 : float =  -v67
        let v69 : bool = v67 >= v68
        let v70 : float =
            if v69 then
                v67
            else
                v68
        let v71 : bool = v70 < 0.0001
        let v73 : bool =
            if v71 then
                true
            else
                method21(v71)
        let v74 : string = $"{v61} / actual: %A{v70} / expected: %A{0.0001}"
        v74 |> System.Console.WriteLine
        let v77 : bool = v73 = false
        if v77 then
            failwith<unit> v74
        let v78 : int32 = v17 + 1
        v15.l0 <- v78
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v29 : US0 = US0_1
        let v30 : US0 = v18 |> Option.defaultValue v29 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "num_complex::Complex::new($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v35, v37) v38 
        let v42 : num_complex_Complex<float> =
            match v30 with
            | US0_1 -> (* None *)
                v39
            | US0_0(v40) -> (* Some *)
                v40
        let v43 : string = "$0.re"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr v42 v43 
        let v45 : bool = v44 > 0.0
        let v47 : bool =
            if v45 then
                true
            else
                method21(v45)
        let v48 : string = "__assert_gt"
        let v49 : string = $"{v48} / actual: %A{v44} / expected: %A{0.0}"
        v49 |> System.Console.WriteLine
        let v52 : bool = v47 = false
        if v52 then
            failwith<unit> v49
        let v53 : string = "$0.im"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr v42 v53 
        let v55 : bool = v54 = 0.0
        let v57 : bool =
            if v55 then
                true
            else
                method21(v55)
        let v58 : string = "__assert_eq"
        let v59 : string = $"{v58} / actual: %A{v54} / expected: %A{0.0}"
        v59 |> System.Console.WriteLine
        let v62 : bool = v57 = false
        if v62 then
            failwith<unit> v59
        let v63 : int32 = v5 + 1
        v3.l0 <- v63
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
    let v23 : US0 = US0_1
    let v24 : US0 = v12 |> Option.defaultValue v23 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "f64::NAN"
    let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "num_complex::Complex::new($0, $1)"
    let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v32 
    let v36 : num_complex_Complex<float> =
        match v24 with
        | US0_1 -> (* None *)
            v33
        | US0_0(v34) -> (* Some *)
            v34
    let v37 : string = "$0.re"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : bool = v38 = infinity
    let v41 : bool =
        if v39 then
            true
        else
            method21(v39)
    let v42 : string = "__assert_eq"
    let v43 : string = $"{v42} / actual: %A{v38} / expected: %A{infinity}"
    v43 |> System.Console.WriteLine
    let v46 : bool = v41 = false
    if v46 then
        failwith<unit> v43
    let v47 : string = "$0.im"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr v36 v47 
    let v49 : bool = v48 = 0.0
    let v51 : bool =
        if v49 then
            true
        else
            method21(v49)
    let v52 : string = $"{v42} / actual: %A{v48} / expected: %A{0.0}"
    v52 |> System.Console.WriteLine
    let v55 : bool = v51 = false
    if v55 then
        failwith<unit> v52
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
    let v23 : US0 = US0_1
    let v24 : US0 = v12 |> Option.defaultValue v23 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "f64::NAN"
    let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "num_complex::Complex::new($0, $1)"
    let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v32 
    let v36 : num_complex_Complex<float> =
        match v24 with
        | US0_1 -> (* None *)
            v33
        | US0_0(v34) -> (* Some *)
            v34
    let v37 : string = "$0.re"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v2 v37 
    let v39 : string = "$0.im"
    let v40 : float = Fable.Core.RustInterop.emitRustExpr v2 v39 
    let v41 : float =  -v40
    let v42 : string = "num_complex::Complex::new($0, $1)"
    let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v38, v41) v42 
    let v44 : string = $"        s = mpmath.zeta(s)"
    let v45 : num_complex_Complex<float> = method3(v43)
    let v46 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v44, v45)
    let v47 : num_complex_Complex<float> = method17(v0, v43)
    let v48 : string = "v46.ok()"
    let v49 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v48 
    let v50 : US0 option = None
    let _v50 = ref v50 
    match v49 with
    | Some x -> (
    (fun () ->
    (fun () ->
    let v51 : num_complex_Complex<float> = x
    let v52 : US0 = US0_0(v51)
    v52 
    )
    |> fun x -> x () |> Some
    ) () ) | None -> None
    |> fun x -> _v50.Value <- x
    let v53 : US0 option = _v50.Value 
    let v64 : US0 = US0_1
    let v65 : US0 = v53 |> Option.defaultValue v64 
    let v69 : string = "f64::NAN"
    let v70 : float = Fable.Core.RustInterop.emitRustExpr () v69 
    let v71 : string = "f64::NAN"
    let v72 : float = Fable.Core.RustInterop.emitRustExpr () v71 
    let v73 : string = "num_complex::Complex::new($0, $1)"
    let v74 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v70, v72) v73 
    let v77 : num_complex_Complex<float> =
        match v65 with
        | US0_1 -> (* None *)
            v74
        | US0_0(v75) -> (* Some *)
            v75
    let v78 : string = "$0.conj()"
    let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v77 v78 
    let v80 : string = "$0.re"
    let v81 : float = Fable.Core.RustInterop.emitRustExpr v36 v80 
    let v82 : string = "$0.re"
    let v83 : float = Fable.Core.RustInterop.emitRustExpr v79 v82 
    let v84 : bool = v81 = v83
    let v86 : bool =
        if v84 then
            true
        else
            method21(v84)
    let v87 : string = "__assert_eq"
    let v88 : string = $"{v87} / actual: %A{v81} / expected: %A{v83}"
    v88 |> System.Console.WriteLine
    let v91 : bool = v86 = false
    if v91 then
        failwith<unit> v88
    let v92 : string = "$0.im"
    let v93 : float = Fable.Core.RustInterop.emitRustExpr v36 v92 
    let v94 : string = "$0.im"
    let v95 : float = Fable.Core.RustInterop.emitRustExpr v79 v94 
    let v96 : bool = v93 = v95
    let v98 : bool =
        if v96 then
            true
        else
            method21(v96)
    let v99 : string = $"{v87} / actual: %A{v93} / expected: %A{v95}"
    v99 |> System.Console.WriteLine
    let v102 : bool = v98 = false
    if v102 then
        failwith<unit> v99
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
    let v23 : US0 = US0_1
    let v24 : US0 = v12 |> Option.defaultValue v23 
    let v28 : string = "f64::NAN"
    let v29 : float = Fable.Core.RustInterop.emitRustExpr () v28 
    let v30 : string = "f64::NAN"
    let v31 : float = Fable.Core.RustInterop.emitRustExpr () v30 
    let v32 : string = "num_complex::Complex::new($0, $1)"
    let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v29, v31) v32 
    let v36 : num_complex_Complex<float> =
        match v24 with
        | US0_1 -> (* None *)
            v33
        | US0_0(v34) -> (* Some *)
            v34
    let v37 : string = "$0.re"
    let v38 : float = Fable.Core.RustInterop.emitRustExpr v36 v37 
    let v39 : bool = v38 < infinity
    let v41 : bool =
        if v39 then
            true
        else
            method21(v39)
    let v42 : string = "__assert_lt"
    let v43 : string = $"{v42} / actual: %A{v38} / expected: %A{infinity}"
    v43 |> System.Console.WriteLine
    let v46 : bool = v41 = false
    if v46 then
        failwith<unit> v43
    let v47 : string = "$0.im"
    let v48 : float = Fable.Core.RustInterop.emitRustExpr v36 v47 
    let v49 : bool = v48 < infinity
    let v51 : bool =
        if v49 then
            true
        else
            method21(v49)
    let v52 : string = $"{v42} / actual: %A{v48} / expected: %A{infinity}"
    v52 |> System.Console.WriteLine
    let v55 : bool = v51 = false
    if v55 then
        failwith<unit> v52
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v26 : US0 = US0_1
        let v27 : US0 = v15 |> Option.defaultValue v26 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "f64::NAN"
        let v34 : float = Fable.Core.RustInterop.emitRustExpr () v33 
        let v35 : string = "num_complex::Complex::new($0, $1)"
        let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v32, v34) v35 
        let v39 : num_complex_Complex<float> =
            match v27 with
            | US0_1 -> (* None *)
                v36
            | US0_0(v37) -> (* Some *)
                v37
        let v40 : string = "$0.re"
        let v41 : float = Fable.Core.RustInterop.emitRustExpr v39 v40 
        let v42 : bool = v41 <> 0.0 
        let v46 : bool =
            if v42 then
                true
            else
                method21(v42)
        let v47 : string = "__assert_ne"
        let v48 : string = $"{v47} / actual: %A{v41} / expected: %A{0.0}"
        v48 |> System.Console.WriteLine
        let v51 : bool = v46 = false
        if v51 then
            failwith<unit> v48
        let v52 : string = "$0.im"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr v39 v52 
        let v54 : bool = v53 <> 0.0 
        let v58 : bool =
            if v54 then
                true
            else
                method21(v54)
        let v59 : string = $"{v47} / actual: %A{v53} / expected: %A{0.0}"
        v59 |> System.Console.WriteLine
        let v62 : bool = v58 = false
        if v62 then
            failwith<unit> v59
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v10 : US0 option = None
        let _v10 = ref v10 
        match v9 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11 : num_complex_Complex<float> = x
        let v12 : US0 = US0_0(v11)
        v12 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10.Value <- x
        let v13 : US0 option = _v10.Value 
        let v24 : US0 = US0_1
        let v25 : US0 = v13 |> Option.defaultValue v24 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33 
        let v37 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v34
            | US0_0(v35) -> (* Some *)
                v35
        let v38 : string = "$0.re"
        let v39 : float = Fable.Core.RustInterop.emitRustExpr v37 v38 
        let v40 : bool = v39 <> 0.0 
        let v44 : bool =
            if v40 then
                true
            else
                method21(v40)
        let v45 : string = "__assert_ne"
        let v46 : string = $"{v45} / actual: %A{v39} / expected: %A{0.0}"
        v46 |> System.Console.WriteLine
        let v49 : bool = v44 = false
        if v49 then
            failwith<unit> v46
        let v50 : string = "$0.im"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr v37 v50 
        let v52 : bool = v51 <> 0.0 
        let v56 : bool =
            if v52 then
                true
            else
                method21(v52)
        let v57 : string = $"{v45} / actual: %A{v51} / expected: %A{0.0}"
        v57 |> System.Console.WriteLine
        let v60 : bool = v56 = false
        if v60 then
            failwith<unit> v57
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v10 : US0 option = None
        let _v10 = ref v10 
        match v9 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v11 : num_complex_Complex<float> = x
        let v12 : US0 = US0_0(v11)
        v12 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v10.Value <- x
        let v13 : US0 option = _v10.Value 
        let v24 : US0 = US0_1
        let v25 : US0 = v13 |> Option.defaultValue v24 
        let v29 : string = "f64::NAN"
        let v30 : float = Fable.Core.RustInterop.emitRustExpr () v29 
        let v31 : string = "f64::NAN"
        let v32 : float = Fable.Core.RustInterop.emitRustExpr () v31 
        let v33 : string = "num_complex::Complex::new($0, $1)"
        let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, v32) v33 
        let v37 : num_complex_Complex<float> =
            match v25 with
            | US0_1 -> (* None *)
                v34
            | US0_0(v35) -> (* Some *)
                v35
        let v38 : string = "num_complex::Complex::new($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v38 
        let v40 : string = "num_complex::Complex::powc($0, $1)"
        let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v39, v2) v40 
        let v42 : string = "num_complex::Complex::new($0, $1)"
        let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v42 
        let v44 : string = "num_complex::Complex::new($0, $1)"
        let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v44 
        let v46 : string = "$0 - $1"
        let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v45) v46 
        let v48 : string = "num_complex::Complex::powc($0, $1)"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v47) v48 
        let v50 : string = "$0 * $1"
        let v51 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v41, v49) v50 
        let v52 : string = "num_complex::Complex::new($0, $1)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v52 
        let v54 : string = "$0 * $1"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v2) v54 
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v56 
        let v58 : string = "$0 / $1"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v57) v58 
        let v60 : string = "$0.sin()"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v62 : string = "$0 * $1"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v51, v61) v62 
        let v64 : string = "num_complex::Complex::new($0, $1)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v64 
        let v66 : string = "$0 - $1"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v65, v2) v66 
        let v68 : string = $"        s = mpmath.gamma(s)"
        let v69 : num_complex_Complex<float> = method3(v67)
        let v70 : Result<num_complex_Complex<float>, std_string_String> = method20(v0, v68, v69)
        let v71 : string = "v70.ok()"
        let v72 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v71 
        let v73 : US0 option = None
        let _v73 = ref v73 
        match v72 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v74 : num_complex_Complex<float> = x
        let v75 : US0 = US0_0(v74)
        v75 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v73.Value <- x
        let v76 : US0 option = _v73.Value 
        let v87 : US0 = US0_1
        let v88 : US0 = v76 |> Option.defaultValue v87 
        let v92 : string = "f64::NAN"
        let v93 : float = Fable.Core.RustInterop.emitRustExpr () v92 
        let v94 : string = "f64::NAN"
        let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94 
        let v96 : string = "num_complex::Complex::new($0, $1)"
        let v97 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v93, v95) v96 
        let v100 : num_complex_Complex<float> =
            match v88 with
            | US0_1 -> (* None *)
                v97
            | US0_0(v98) -> (* Some *)
                v98
        let v101 : string = "$0 * $1"
        let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v63, v100) v101 
        let v103 : string = "$0.re"
        let v104 : float = Fable.Core.RustInterop.emitRustExpr v2 v103 
        let v105 : float = 1.0 - v104
        let v106 : string = "$0.im"
        let v107 : float = Fable.Core.RustInterop.emitRustExpr v2 v106 
        let v108 : float =  -v107
        let v109 : string = "num_complex::Complex::new($0, $1)"
        let v110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v105, v108) v109 
        let v111 : string = $"        s = mpmath.zeta(s)"
        let v112 : num_complex_Complex<float> = method3(v110)
        let v113 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v111, v112)
        let v114 : num_complex_Complex<float> = method17(v0, v110)
        let v115 : string = "v113.ok()"
        let v116 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr () v115 
        let v117 : US0 option = None
        let _v117 = ref v117 
        match v116 with
        | Some x -> (
        (fun () ->
        (fun () ->
        let v118 : num_complex_Complex<float> = x
        let v119 : US0 = US0_0(v118)
        v119 
        )
        |> fun x -> x () |> Some
        ) () ) | None -> None
        |> fun x -> _v117.Value <- x
        let v120 : US0 option = _v117.Value 
        let v131 : US0 = US0_1
        let v132 : US0 = v120 |> Option.defaultValue v131 
        let v136 : string = "f64::NAN"
        let v137 : float = Fable.Core.RustInterop.emitRustExpr () v136 
        let v138 : string = "f64::NAN"
        let v139 : float = Fable.Core.RustInterop.emitRustExpr () v138 
        let v140 : string = "num_complex::Complex::new($0, $1)"
        let v141 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v137, v139) v140 
        let v144 : num_complex_Complex<float> =
            match v132 with
            | US0_1 -> (* None *)
                v141
            | US0_0(v142) -> (* Some *)
                v142
        let v145 : string = "$0 * $1"
        let v146 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v102, v144) v145 
        let v147 : string = "$0.re"
        let v148 : float = Fable.Core.RustInterop.emitRustExpr v37 v147 
        let v149 : string = "$0.re"
        let v150 : float = Fable.Core.RustInterop.emitRustExpr v146 v149 
        let v151 : float = v148 - v150
        let v152 : float =  -v151
        let v153 : bool = v151 >= v152
        let v154 : float =
            if v153 then
                v151
            else
                v152
        let v155 : bool = v154 < 0.0001
        let v157 : bool =
            if v155 then
                true
            else
                method21(v155)
        let v158 : string = "__assert_lt"
        let v159 : string = $"{v158} / actual: %A{v154} / expected: %A{0.0001}"
        v159 |> System.Console.WriteLine
        let v162 : bool = v157 = false
        if v162 then
            failwith<unit> v159
        let v163 : string = "$0.im"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr v37 v163 
        let v165 : string = "$0.im"
        let v166 : float = Fable.Core.RustInterop.emitRustExpr v146 v165 
        let v167 : float = v164 - v166
        let v168 : float =  -v167
        let v169 : bool = v167 >= v168
        let v170 : float =
            if v169 then
                v167
            else
                v168
        let v171 : bool = v170 < 0.0001
        let v173 : bool =
            if v171 then
                true
            else
                method21(v171)
        let v174 : string = $"{v158} / actual: %A{v170} / expected: %A{0.0001}"
        v174 |> System.Console.WriteLine
        let v177 : bool = v173 = false
        if v177 then
            failwith<unit> v174
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
        let v29 : US0 = US0_1
        let v30 : US0 = v18 |> Option.defaultValue v29 
        let v34 : string = "f64::NAN"
        let v35 : float = Fable.Core.RustInterop.emitRustExpr () v34 
        let v36 : string = "f64::NAN"
        let v37 : float = Fable.Core.RustInterop.emitRustExpr () v36 
        let v38 : string = "num_complex::Complex::new($0, $1)"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v35, v37) v38 
        let v42 : num_complex_Complex<float> =
            match v30 with
            | US0_1 -> (* None *)
                v39
            | US0_0(v40) -> (* Some *)
                v40
        let v43 : string = "$0.re"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr v42 v43 
        let v45 : float = v44 - v8
        let v46 : float =  -v45
        let v47 : bool = v45 >= v46
        let v48 : float =
            if v47 then
                v45
            else
                v46
        let v49 : bool = v48 < 0.01
        let v51 : bool =
            if v49 then
                true
            else
                method21(v49)
        let v52 : string = "__assert_lt"
        let v53 : string = $"{v52} / actual: %A{v48} / expected: %A{0.01}"
        v53 |> System.Console.WriteLine
        let v56 : bool = v51 = false
        if v56 then
            failwith<unit> v53
        let v57 : string = "$0.im"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr v42 v57 
        let v59 : bool = v58 < 0.01
        let v61 : bool =
            if v59 then
                true
            else
                method21(v59)
        let v62 : string = $"{v52} / actual: %A{v58} / expected: %A{0.01}"
        v62 |> System.Console.WriteLine
        let v65 : bool = v61 = false
        if v65 then
            failwith<unit> v62
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
    let v12 : string = "v5 " + v9 + "); " + v11 + " // rust.fix_closure'"
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
    v1 |> System.Console.WriteLine
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure5()
let main args = v1 args
()
