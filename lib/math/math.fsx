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
type Ref<'T> = class end
#else
type Ref<'T> = 'T
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::string::String")>]
type std_string_String = class end
#else
type std_string_String = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("std::ffi::CString")>]
#endif
type std_ffi_CString = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyErr")>]
#endif
type pyo3_PyErr = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::Bound<$0>")>]
#endif
type pyo3_Bound<'T> = class end
Fable.Core.RustInterop.emitRustExpr () ");
use pyo3::prelude::PyAnyMethods;
//"
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("str")>]
type Str = class end
#else
type Str = string
#endif

#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::types::PyModule")>]
#endif
type pyo3_types_PyModule = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("pyo3::PyAny")>]
#endif
type pyo3_PyAny = class end
type Mut0 = {mutable l0 : int32}
and Mut1 = {mutable l0 : int32; mutable l1 : string; mutable l2 : string}
and Mut2 = {mutable l0 : int32; mutable l1 : num_complex_Complex<float>}
and [<Struct>] US0 =
    | US0_0 of f0_0 : num_complex_Complex<float>
    | US0_1
and Mut3 = {mutable l0 : string}
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
    let v3 : Mut1 = {l0 = 0; l1 = v2; l2 = v2} : Mut1
    while method6(v1, v3) do
        let v5 : int32 = v3.l0
        let v6 : int32 =  -v5
        let v7 : int32 = v6 + v1
        let v8 : int32 = v7 - 1
        let struct (v9 : string, v10 : string) = v3.l1, v3.l2
        let v11 : string = v0.[int v8]
        let v14 : string = v11 + v10 
        let v28 : string = v14 + v9 
        let v40 : int32 = v5 + 1
        let v41 : string = "\n"
        v3.l0 <- v40
        v3.l1 <- v28
        v3.l2 <- v41
        ()
    let struct (v42 : string, v43 : string) = v3.l1, v3.l2
    v42
and method7 (v0 : pyo3_Python) : pyo3_Python =
    v0
and method8 () : string =
    let v0 : string = "fn"
    v0
and method9 (v0 : pyo3_Bound<pyo3_types_PyModule>) : pyo3_Bound<pyo3_types_PyModule> =
    v0
and method10 (v0 : (bool * (float * float))) : (bool * (float * float)) =
    v0
and method11 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
and method12 (v0 : pyo3_Bound<pyo3_PyAny>) : pyo3_Bound<pyo3_PyAny> =
    v0
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
    let v43 : (float * float) = v38, v40 
    let v57 : (bool * (float * float)) = false, v43 
    let v69 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v252 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v253 : string = "&*$0"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v253 
    let _run_target_args'_v252 = v254 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v255 : string = "&*$0"
    let v256 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v255 
    let _run_target_args'_v252 = v256 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v257 : string = "&*$0"
    let v258 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v257 
    let _run_target_args'_v252 = v258 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v338 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v252 = v338 
    #endif
#if FABLE_COMPILER_PYTHON
    let v429 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v252 = v429 
    #endif
#else
    let v520 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v252 = v520 
    #endif
    let v532 : Ref<Str> = _run_target_args'_v252 
    (* run_target_args'
    let v897 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v898 : string = "String::from($0)"
    let v899 : std_string_String = Fable.Core.RustInterop.emitRustExpr v532 v898 
    let _run_target_args'_v897 = v899 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v900 : string = "String::from($0)"
    let v901 : std_string_String = Fable.Core.RustInterop.emitRustExpr v532 v900 
    let _run_target_args'_v897 = v901 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v902 : string = "String::from($0)"
    let v903 : std_string_String = Fable.Core.RustInterop.emitRustExpr v532 v902 
    let _run_target_args'_v897 = v903 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v983 : std_string_String = v532 |> unbox<std_string_String>
    let _run_target_args'_v897 = v983 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1074 : std_string_String = v532 |> unbox<std_string_String>
    let _run_target_args'_v897 = v1074 
    #endif
#else
    let v1165 : std_string_String = v532 |> unbox<std_string_String>
    let _run_target_args'_v897 = v1165 
    #endif
    let v1177 : std_string_String = _run_target_args'_v897 
    let v1360 : string = "std::ffi::CString::new($0).unwrap()"
    let v1361 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v1177 v1360 
    let v1362 : string = ""
    (* run_target_args'
    let v1545 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1546 : string = "&*$0"
    let v1547 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1362 v1546 
    let _run_target_args'_v1545 = v1547 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1548 : string = "&*$0"
    let v1549 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1362 v1548 
    let _run_target_args'_v1545 = v1549 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1550 : string = "&*$0"
    let v1551 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1362 v1550 
    let _run_target_args'_v1545 = v1551 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1631 : Ref<Str> = v1362 |> unbox<Ref<Str>>
    let _run_target_args'_v1545 = v1631 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1722 : Ref<Str> = v1362 |> unbox<Ref<Str>>
    let _run_target_args'_v1545 = v1722 
    #endif
#else
    let v1813 : Ref<Str> = v1362 |> unbox<Ref<Str>>
    let _run_target_args'_v1545 = v1813 
    #endif
    let v1825 : Ref<Str> = _run_target_args'_v1545 
    (* run_target_args'
    let v2190 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2191 : string = "String::from($0)"
    let v2192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1825 v2191 
    let _run_target_args'_v2190 = v2192 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2193 : string = "String::from($0)"
    let v2194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1825 v2193 
    let _run_target_args'_v2190 = v2194 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2195 : string = "String::from($0)"
    let v2196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1825 v2195 
    let _run_target_args'_v2190 = v2196 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2276 : std_string_String = v1825 |> unbox<std_string_String>
    let _run_target_args'_v2190 = v2276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2367 : std_string_String = v1825 |> unbox<std_string_String>
    let _run_target_args'_v2190 = v2367 
    #endif
#else
    let v2458 : std_string_String = v1825 |> unbox<std_string_String>
    let _run_target_args'_v2190 = v2458 
    #endif
    let v2470 : std_string_String = _run_target_args'_v2190 
    let v2653 : string = "std::ffi::CString::new($0).unwrap()"
    let v2654 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v2470 v2653 
    let v2655 : string = "pyo3::types::PyModule::from_code(v69, &$0, &v2654, &v2654)"
    let v2656 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v1361 v2655 
    let v2657 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v2658 : bool = Fable.Core.RustInterop.emitRustExpr v2656 v2657 
    let v2659 : string = "x"
    let v2660 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v2659 
    (* run_target_args'
    let v2689 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2690 : string = "format!(\"{}\", $0)"
    let v2691 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2660 v2690 
    let _run_target_args'_v2689 = v2691 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2692 : string = "format!(\"{}\", $0)"
    let v2693 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2660 v2692 
    let _run_target_args'_v2689 = v2693 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2694 : string = "format!(\"{}\", $0)"
    let v2695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2660 v2694 
    let _run_target_args'_v2689 = v2695 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2698 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2689 = v2698 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2712 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2689 = v2712 
    #endif
#else
    let v2726 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2689 = v2726 
    #endif
    let v2738 : std_string_String = _run_target_args'_v2689 
    let v2767 : string = "true; $0 })"
    let v2768 : bool = Fable.Core.RustInterop.emitRustExpr v2738 v2767 
    let v2769 : string = "_result_map_error__"
    let v2770 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2769 
    let v2771 : string = "$0.unwrap()"
    let v2772 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v2770 v2771 
    let v2773 : string = method8()
    (* run_target_args'
    let v2956 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2957 : string = "&*$0"
    let v2958 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2773 v2957 
    let _run_target_args'_v2956 = v2958 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2959 : string = "&*$0"
    let v2960 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2773 v2959 
    let _run_target_args'_v2956 = v2960 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2961 : string = "&*$0"
    let v2962 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2773 v2961 
    let _run_target_args'_v2956 = v2962 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3042 : Ref<Str> = v2773 |> unbox<Ref<Str>>
    let _run_target_args'_v2956 = v3042 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3133 : Ref<Str> = v2773 |> unbox<Ref<Str>>
    let _run_target_args'_v2956 = v3133 
    #endif
#else
    let v3224 : Ref<Str> = v2773 |> unbox<Ref<Str>>
    let _run_target_args'_v2956 = v3224 
    #endif
    let v3236 : Ref<Str> = _run_target_args'_v2956 
    let v3419 : pyo3_Bound<pyo3_types_PyModule> = method9(v2772)
    let v3420 : string = "v3419.getattr($0)"
    let v3421 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v3236 v3420 
    let v3422 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3423 : bool = Fable.Core.RustInterop.emitRustExpr v3421 v3422 
    let v3424 : string = "x"
    let v3425 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3424 
    (* run_target_args'
    let v3454 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3455 : string = "format!(\"{}\", $0)"
    let v3456 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3425 v3455 
    let _run_target_args'_v3454 = v3456 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3457 : string = "format!(\"{}\", $0)"
    let v3458 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3425 v3457 
    let _run_target_args'_v3454 = v3458 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3459 : string = "format!(\"{}\", $0)"
    let v3460 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3425 v3459 
    let _run_target_args'_v3454 = v3460 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3463 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3454 = v3463 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3477 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3454 = v3477 
    #endif
#else
    let v3491 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3454 = v3491 
    #endif
    let v3503 : std_string_String = _run_target_args'_v3454 
    let v3532 : string = "true; $0 })"
    let v3533 : bool = Fable.Core.RustInterop.emitRustExpr v3503 v3532 
    let v3534 : string = "_result_map_error__"
    let v3535 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3534 
    let v3536 : string = "$0.unwrap()"
    let v3537 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3535 v3536 
    let v3538 : (bool * (float * float)) = method10(v57)
    let v3539 : pyo3_Bound<pyo3_PyAny> = method11(v3537)
    let v3540 : string = "pyo3::prelude::PyAnyMethods::call(&v3539, ((*v3538).0, *(*v3538).1), None)"
    let v3541 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3540 
    let v3542 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3543 : bool = Fable.Core.RustInterop.emitRustExpr v3541 v3542 
    let v3544 : string = "x"
    let v3545 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3544 
    (* run_target_args'
    let v3574 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3575 : string = "format!(\"{}\", $0)"
    let v3576 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3545 v3575 
    let _run_target_args'_v3574 = v3576 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3577 : string = "format!(\"{}\", $0)"
    let v3578 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3545 v3577 
    let _run_target_args'_v3574 = v3578 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3579 : string = "format!(\"{}\", $0)"
    let v3580 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3545 v3579 
    let _run_target_args'_v3574 = v3580 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3583 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3574 = v3583 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3597 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3574 = v3597 
    #endif
#else
    let v3611 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3574 = v3611 
    #endif
    let v3623 : std_string_String = _run_target_args'_v3574 
    let v3652 : string = "true; $0 })"
    let v3653 : bool = Fable.Core.RustInterop.emitRustExpr v3623 v3652 
    let v3654 : string = "_result_map_error__"
    let v3655 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3654 
    let v3656 : string = "$0?"
    let v3657 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3655 v3656 
    let v3658 : pyo3_Bound<pyo3_PyAny> = method12(v3657)
    let v3659 : string = "v3658.extract()"
    let v3660 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3659 
    let v3661 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3662 : bool = Fable.Core.RustInterop.emitRustExpr v3660 v3661 
    let v3663 : string = "x"
    let v3664 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3663 
    (* run_target_args'
    let v3693 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3694 : string = "format!(\"{}\", $0)"
    let v3695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3664 v3694 
    let _run_target_args'_v3693 = v3695 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3696 : string = "format!(\"{}\", $0)"
    let v3697 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3664 v3696 
    let _run_target_args'_v3693 = v3697 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3698 : string = "format!(\"{}\", $0)"
    let v3699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3664 v3698 
    let _run_target_args'_v3693 = v3699 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3702 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3693 = v3702 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3716 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3693 = v3716 
    #endif
#else
    let v3730 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3693 = v3730 
    #endif
    let v3742 : std_string_String = _run_target_args'_v3693 
    let v3771 : string = "true; $0 })"
    let v3772 : bool = Fable.Core.RustInterop.emitRustExpr v3742 v3771 
    let v3773 : string = "_result_map_error__"
    let v3774 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3773 
    let v3775 : string = "$0?"
    let struct (v3776 : float, v3777 : float) = Fable.Core.RustInterop.emitRustExpr v3774 v3775 
    let v3778 : string = "num_complex::Complex::new($0, $1)"
    let v3779 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3776, v3777) v3778 
    let v3782 : Result<num_complex_Complex<float>, std_string_String> = Ok v3779 
    v3782
and method14 (v0 : Mut0) : bool =
    let v1 : int32 = v0.l0
    let v2 : bool = v1 < 10000
    v2
and method15 (v0 : int32, v1 : Mut2) : bool =
    let v2 : int32 = v1.l0
    let v3 : bool = v2 < v0
    v3
and method16 (v0 : pyo3_Python, v1 : string, v2 : num_complex_Complex<float>) : Result<num_complex_Complex<float>, std_string_String> =
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
    let v43 : (float * float) = v38, v40 
    let v57 : (bool * (float * float)) = false, v43 
    let v69 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v252 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v253 : string = "&*$0"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v253 
    let _run_target_args'_v252 = v254 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v255 : string = "&*$0"
    let v256 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v255 
    let _run_target_args'_v252 = v256 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v257 : string = "&*$0"
    let v258 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v257 
    let _run_target_args'_v252 = v258 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v338 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v252 = v338 
    #endif
#if FABLE_COMPILER_PYTHON
    let v429 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v252 = v429 
    #endif
#else
    let v520 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v252 = v520 
    #endif
    let v532 : Ref<Str> = _run_target_args'_v252 
    (* run_target_args'
    let v897 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v898 : string = "String::from($0)"
    let v899 : std_string_String = Fable.Core.RustInterop.emitRustExpr v532 v898 
    let _run_target_args'_v897 = v899 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v900 : string = "String::from($0)"
    let v901 : std_string_String = Fable.Core.RustInterop.emitRustExpr v532 v900 
    let _run_target_args'_v897 = v901 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v902 : string = "String::from($0)"
    let v903 : std_string_String = Fable.Core.RustInterop.emitRustExpr v532 v902 
    let _run_target_args'_v897 = v903 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v983 : std_string_String = v532 |> unbox<std_string_String>
    let _run_target_args'_v897 = v983 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1074 : std_string_String = v532 |> unbox<std_string_String>
    let _run_target_args'_v897 = v1074 
    #endif
#else
    let v1165 : std_string_String = v532 |> unbox<std_string_String>
    let _run_target_args'_v897 = v1165 
    #endif
    let v1177 : std_string_String = _run_target_args'_v897 
    let v1360 : string = "std::ffi::CString::new($0).unwrap()"
    let v1361 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v1177 v1360 
    let v1362 : string = ""
    (* run_target_args'
    let v1545 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1546 : string = "&*$0"
    let v1547 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1362 v1546 
    let _run_target_args'_v1545 = v1547 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1548 : string = "&*$0"
    let v1549 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1362 v1548 
    let _run_target_args'_v1545 = v1549 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1550 : string = "&*$0"
    let v1551 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1362 v1550 
    let _run_target_args'_v1545 = v1551 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1631 : Ref<Str> = v1362 |> unbox<Ref<Str>>
    let _run_target_args'_v1545 = v1631 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1722 : Ref<Str> = v1362 |> unbox<Ref<Str>>
    let _run_target_args'_v1545 = v1722 
    #endif
#else
    let v1813 : Ref<Str> = v1362 |> unbox<Ref<Str>>
    let _run_target_args'_v1545 = v1813 
    #endif
    let v1825 : Ref<Str> = _run_target_args'_v1545 
    (* run_target_args'
    let v2190 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2191 : string = "String::from($0)"
    let v2192 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1825 v2191 
    let _run_target_args'_v2190 = v2192 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2193 : string = "String::from($0)"
    let v2194 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1825 v2193 
    let _run_target_args'_v2190 = v2194 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2195 : string = "String::from($0)"
    let v2196 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1825 v2195 
    let _run_target_args'_v2190 = v2196 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2276 : std_string_String = v1825 |> unbox<std_string_String>
    let _run_target_args'_v2190 = v2276 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2367 : std_string_String = v1825 |> unbox<std_string_String>
    let _run_target_args'_v2190 = v2367 
    #endif
#else
    let v2458 : std_string_String = v1825 |> unbox<std_string_String>
    let _run_target_args'_v2190 = v2458 
    #endif
    let v2470 : std_string_String = _run_target_args'_v2190 
    let v2653 : string = "std::ffi::CString::new($0).unwrap()"
    let v2654 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v2470 v2653 
    let v2655 : string = "pyo3::types::PyModule::from_code(v69, &$0, &v2654, &v2654)"
    let v2656 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v1361 v2655 
    let v2657 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v2658 : bool = Fable.Core.RustInterop.emitRustExpr v2656 v2657 
    let v2659 : string = "x"
    let v2660 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v2659 
    (* run_target_args'
    let v2689 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2690 : string = "format!(\"{}\", $0)"
    let v2691 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2660 v2690 
    let _run_target_args'_v2689 = v2691 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2692 : string = "format!(\"{}\", $0)"
    let v2693 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2660 v2692 
    let _run_target_args'_v2689 = v2693 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2694 : string = "format!(\"{}\", $0)"
    let v2695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2660 v2694 
    let _run_target_args'_v2689 = v2695 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2698 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2689 = v2698 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2712 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2689 = v2712 
    #endif
#else
    let v2726 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2689 = v2726 
    #endif
    let v2738 : std_string_String = _run_target_args'_v2689 
    let v2767 : string = "true; $0 })"
    let v2768 : bool = Fable.Core.RustInterop.emitRustExpr v2738 v2767 
    let v2769 : string = "_result_map_error__"
    let v2770 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2769 
    let v2771 : string = "$0.unwrap()"
    let v2772 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v2770 v2771 
    let v2773 : string = method8()
    (* run_target_args'
    let v2956 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2957 : string = "&*$0"
    let v2958 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2773 v2957 
    let _run_target_args'_v2956 = v2958 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2959 : string = "&*$0"
    let v2960 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2773 v2959 
    let _run_target_args'_v2956 = v2960 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2961 : string = "&*$0"
    let v2962 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2773 v2961 
    let _run_target_args'_v2956 = v2962 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3042 : Ref<Str> = v2773 |> unbox<Ref<Str>>
    let _run_target_args'_v2956 = v3042 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3133 : Ref<Str> = v2773 |> unbox<Ref<Str>>
    let _run_target_args'_v2956 = v3133 
    #endif
#else
    let v3224 : Ref<Str> = v2773 |> unbox<Ref<Str>>
    let _run_target_args'_v2956 = v3224 
    #endif
    let v3236 : Ref<Str> = _run_target_args'_v2956 
    let v3419 : pyo3_Bound<pyo3_types_PyModule> = method9(v2772)
    let v3420 : string = "v3419.getattr($0)"
    let v3421 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v3236 v3420 
    let v3422 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3423 : bool = Fable.Core.RustInterop.emitRustExpr v3421 v3422 
    let v3424 : string = "x"
    let v3425 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3424 
    (* run_target_args'
    let v3454 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3455 : string = "format!(\"{}\", $0)"
    let v3456 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3425 v3455 
    let _run_target_args'_v3454 = v3456 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3457 : string = "format!(\"{}\", $0)"
    let v3458 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3425 v3457 
    let _run_target_args'_v3454 = v3458 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3459 : string = "format!(\"{}\", $0)"
    let v3460 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3425 v3459 
    let _run_target_args'_v3454 = v3460 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3463 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3454 = v3463 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3477 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3454 = v3477 
    #endif
#else
    let v3491 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3454 = v3491 
    #endif
    let v3503 : std_string_String = _run_target_args'_v3454 
    let v3532 : string = "true; $0 })"
    let v3533 : bool = Fable.Core.RustInterop.emitRustExpr v3503 v3532 
    let v3534 : string = "_result_map_error__"
    let v3535 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3534 
    let v3536 : string = "$0.unwrap()"
    let v3537 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3535 v3536 
    let v3538 : (bool * (float * float)) = method10(v57)
    let v3539 : pyo3_Bound<pyo3_PyAny> = method11(v3537)
    let v3540 : string = "pyo3::prelude::PyAnyMethods::call(&v3539, ((*v3538).0, *(*v3538).1), None)"
    let v3541 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3540 
    let v3542 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3543 : bool = Fable.Core.RustInterop.emitRustExpr v3541 v3542 
    let v3544 : string = "x"
    let v3545 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3544 
    (* run_target_args'
    let v3574 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3575 : string = "format!(\"{}\", $0)"
    let v3576 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3545 v3575 
    let _run_target_args'_v3574 = v3576 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3577 : string = "format!(\"{}\", $0)"
    let v3578 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3545 v3577 
    let _run_target_args'_v3574 = v3578 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3579 : string = "format!(\"{}\", $0)"
    let v3580 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3545 v3579 
    let _run_target_args'_v3574 = v3580 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3583 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3574 = v3583 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3597 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3574 = v3597 
    #endif
#else
    let v3611 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3574 = v3611 
    #endif
    let v3623 : std_string_String = _run_target_args'_v3574 
    let v3652 : string = "true; $0 })"
    let v3653 : bool = Fable.Core.RustInterop.emitRustExpr v3623 v3652 
    let v3654 : string = "_result_map_error__"
    let v3655 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3654 
    let v3656 : string = "$0?"
    let v3657 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3655 v3656 
    let v3658 : pyo3_Bound<pyo3_PyAny> = method12(v3657)
    let v3659 : string = "v3658.extract()"
    let v3660 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3659 
    let v3661 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3662 : bool = Fable.Core.RustInterop.emitRustExpr v3660 v3661 
    let v3663 : string = "x"
    let v3664 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3663 
    (* run_target_args'
    let v3693 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3694 : string = "format!(\"{}\", $0)"
    let v3695 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3664 v3694 
    let _run_target_args'_v3693 = v3695 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3696 : string = "format!(\"{}\", $0)"
    let v3697 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3664 v3696 
    let _run_target_args'_v3693 = v3697 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3698 : string = "format!(\"{}\", $0)"
    let v3699 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3664 v3698 
    let _run_target_args'_v3693 = v3699 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3702 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3693 = v3702 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3716 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3693 = v3716 
    #endif
#else
    let v3730 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3693 = v3730 
    #endif
    let v3742 : std_string_String = _run_target_args'_v3693 
    let v3771 : string = "true; $0 })"
    let v3772 : bool = Fable.Core.RustInterop.emitRustExpr v3742 v3771 
    let v3773 : string = "_result_map_error__"
    let v3774 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3773 
    let v3775 : string = "$0?"
    let struct (v3776 : float, v3777 : float) = Fable.Core.RustInterop.emitRustExpr v3774 v3775 
    let v3778 : string = "num_complex::Complex::new($0, $1)"
    let v3779 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3776, v3777) v3778 
    let v3782 : Result<num_complex_Complex<float>, std_string_String> = Ok v3779 
    v3782
and closure1 () (v0 : num_complex_Complex<float>) : US0 =
    US0_0(v0)
and method17 () : (num_complex_Complex<float> -> US0) =
    closure1()
and method13 (v0 : pyo3_Python, v1 : num_complex_Complex<float>) : num_complex_Complex<float> =
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
        while method14(v9) do
            let v11 : int32 = v9.l0
            v8.[int v11] <- v11
            let v12 : int32 = v11 + 1
            v9.l0 <- v12
            ()
        let v13 : int32 = v8.Length
        let v14 : Mut2 = {l0 = 0; l1 = v7} : Mut2
        while method15(v13, v14) do
            let v16 : int32 = v14.l0
            let v17 : num_complex_Complex<float> = v14.l1
            let v18 : int32 = v8.[int v16]
            let v19 : string = "num_complex::Complex::new($0, $1)"
            let v20 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v19 
            let v23 : (int32 -> float) = float
            let v24 : float = v23 v18
            let v36 : string = "num_complex::Complex::new($0, $1)"
            let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v24, 0.0) v36 
            let v38 : string = "num_complex::Complex::powc($0, $1)"
            let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v1) v38 
            let v40 : string = "$0 / $1"
            let v41 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v39) v40 
            let v42 : string = "$0 + $1"
            let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v41) v42 
            let v44 : int32 = v16 + 1
            v14.l0 <- v44
            v14.l1 <- v43
            ()
        let v45 : num_complex_Complex<float> = v14.l1
        v45
    else
        let v46 : string = "num_complex::Complex::new($0, $1)"
        let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v46 
        let v48 : string = "$0 - $1"
        let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v47, v1) v48 
        let v50 : string = $"        s = mpmath.gamma(s)"
        let v51 : num_complex_Complex<float> = method3(v49)
        let v52 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v50, v51)
        (* run_target_args'
        let v55 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v56 : string = "$0.ok()"
        let v57 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v52 v56 
        let _run_target_args'_v55 = v57 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v58 : string = "$0.ok()"
        let v59 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v52 v58 
        let _run_target_args'_v55 = v59 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v60 : string = "$0.ok()"
        let v61 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v52 v60 
        let _run_target_args'_v55 = v61 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v62 : num_complex_Complex<float> option = match v52 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v55 = v62 
        #endif
#if FABLE_COMPILER_PYTHON
        let v63 : num_complex_Complex<float> option = match v52 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v55 = v63 
        #endif
#else
        let v64 : num_complex_Complex<float> option = match v52 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v55 = v64 
        #endif
        let v65 : num_complex_Complex<float> option = _run_target_args'_v55 
        let v130 : (num_complex_Complex<float> -> US0) = method17()
        let v131 : US0 option = v65 |> Option.map v130 
        let v192 : US0 = US0_1
        let v193 : US0 = v131 |> Option.defaultValue v192 
        let v206 : string = "f64::NAN"
        let v207 : float = Fable.Core.RustInterop.emitRustExpr () v206 
        let v208 : string = "f64::NAN"
        let v209 : float = Fable.Core.RustInterop.emitRustExpr () v208 
        let v210 : string = "num_complex::Complex::new($0, $1)"
        let v211 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v207, v209) v210 
        let v214 : num_complex_Complex<float> =
            match v193 with
            | US0_1 -> (* None *)
                v211
            | US0_0(v212) -> (* Some *)
                v212
        let v215 : string = "num_complex::Complex::new($0, $1)"
        let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v215 
        let v217 : string = "$0 * $1"
        let v218 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v216, v1) v217 
        let v219 : string = "num_complex::Complex::new($0, $1)"
        let v220 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v219 
        let v221 : string = "$0 / $1"
        let v222 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v218, v220) v221 
        let v223 : string = "$0.sin()"
        let v224 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v222 v223 
        let v225 : string = "$0.re"
        let v226 : float = Fable.Core.RustInterop.emitRustExpr v1 v225 
        let v227 : float = 1.0 - v226
        let v228 : string = "$0.im"
        let v229 : float = Fable.Core.RustInterop.emitRustExpr v1 v228 
        let v230 : float =  -v229
        let v231 : string = "num_complex::Complex::new($0, $1)"
        let v232 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v227, v230) v231 
        let v233 : string = "$0.re"
        let v234 : float = Fable.Core.RustInterop.emitRustExpr v232 v233 
        let v235 : bool = v234 <= 1.0
        let v1246 : num_complex_Complex<float> =
            if v235 then
                let v236 : string = "num_complex::Complex::new($0, $1)"
                let v237 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v236 
                v237
            else
                let v238 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v232) v238 
                let v239 : string = "$0.re"
                let v240 : float = Fable.Core.RustInterop.emitRustExpr v232 v239 
                let v241 : bool = v240 > 1.0
                if v241 then
                    let v242 : string = "num_complex::Complex::new($0, $1)"
                    let v243 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v242 
                    let v244 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v245 : Mut0 = {l0 = 0} : Mut0
                    while method14(v245) do
                        let v247 : int32 = v245.l0
                        v244.[int v247] <- v247
                        let v248 : int32 = v247 + 1
                        v245.l0 <- v248
                        ()
                    let v249 : int32 = v244.Length
                    let v250 : Mut2 = {l0 = 0; l1 = v243} : Mut2
                    while method15(v249, v250) do
                        let v252 : int32 = v250.l0
                        let v253 : num_complex_Complex<float> = v250.l1
                        let v254 : int32 = v244.[int v252]
                        let v255 : string = "num_complex::Complex::new($0, $1)"
                        let v256 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v255 
                        let v259 : (int32 -> float) = float
                        let v260 : float = v259 v254
                        let v272 : string = "num_complex::Complex::new($0, $1)"
                        let v273 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v260, 0.0) v272 
                        let v274 : string = "num_complex::Complex::powc($0, $1)"
                        let v275 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v273, v232) v274 
                        let v276 : string = "$0 / $1"
                        let v277 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v256, v275) v276 
                        let v278 : string = "$0 + $1"
                        let v279 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v253, v277) v278 
                        let v280 : int32 = v252 + 1
                        v250.l0 <- v280
                        v250.l1 <- v279
                        ()
                    let v281 : num_complex_Complex<float> = v250.l1
                    v281
                else
                    let v282 : string = "num_complex::Complex::new($0, $1)"
                    let v283 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v282 
                    let v284 : string = "$0 - $1"
                    let v285 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v283, v232) v284 
                    let v286 : string = $"        s = mpmath.gamma(s)"
                    let v287 : num_complex_Complex<float> = method3(v285)
                    let v288 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v286, v287)
                    (* run_target_args'
                    let v291 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v292 : string = "$0.ok()"
                    let v293 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v288 v292 
                    let _run_target_args'_v291 = v293 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v294 : string = "$0.ok()"
                    let v295 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v288 v294 
                    let _run_target_args'_v291 = v295 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v296 : string = "$0.ok()"
                    let v297 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v288 v296 
                    let _run_target_args'_v291 = v297 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v298 : num_complex_Complex<float> option = match v288 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v291 = v298 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v299 : num_complex_Complex<float> option = match v288 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v291 = v299 
                    #endif
#else
                    let v300 : num_complex_Complex<float> option = match v288 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v291 = v300 
                    #endif
                    let v301 : num_complex_Complex<float> option = _run_target_args'_v291 
                    let v366 : (num_complex_Complex<float> -> US0) = method17()
                    let v367 : US0 option = v301 |> Option.map v366 
                    let v428 : US0 = US0_1
                    let v429 : US0 = v367 |> Option.defaultValue v428 
                    let v442 : string = "f64::NAN"
                    let v443 : float = Fable.Core.RustInterop.emitRustExpr () v442 
                    let v444 : string = "f64::NAN"
                    let v445 : float = Fable.Core.RustInterop.emitRustExpr () v444 
                    let v446 : string = "num_complex::Complex::new($0, $1)"
                    let v447 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v443, v445) v446 
                    let v450 : num_complex_Complex<float> =
                        match v429 with
                        | US0_1 -> (* None *)
                            v447
                        | US0_0(v448) -> (* Some *)
                            v448
                    let v451 : string = "num_complex::Complex::new($0, $1)"
                    let v452 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v451 
                    let v453 : string = "$0 * $1"
                    let v454 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v452, v232) v453 
                    let v455 : string = "num_complex::Complex::new($0, $1)"
                    let v456 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v455 
                    let v457 : string = "$0 / $1"
                    let v458 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v454, v456) v457 
                    let v459 : string = "$0.sin()"
                    let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v458 v459 
                    let v461 : string = "$0.re"
                    let v462 : float = Fable.Core.RustInterop.emitRustExpr v232 v461 
                    let v463 : float = 1.0 - v462
                    let v464 : string = "$0.im"
                    let v465 : float = Fable.Core.RustInterop.emitRustExpr v232 v464 
                    let v466 : float =  -v465
                    let v467 : string = "num_complex::Complex::new($0, $1)"
                    let v468 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v463, v466) v467 
                    let v469 : string = "$0.re"
                    let v470 : float = Fable.Core.RustInterop.emitRustExpr v468 v469 
                    let v471 : bool = v470 <= 1.0
                    let v1230 : num_complex_Complex<float> =
                        if v471 then
                            let v472 : string = "num_complex::Complex::new($0, $1)"
                            let v473 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v472 
                            v473
                        else
                            let v474 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v468) v474 
                            let v475 : string = "$0.re"
                            let v476 : float = Fable.Core.RustInterop.emitRustExpr v468 v475 
                            let v477 : bool = v476 > 1.0
                            if v477 then
                                let v478 : string = "num_complex::Complex::new($0, $1)"
                                let v479 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v478 
                                let v480 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v481 : Mut0 = {l0 = 0} : Mut0
                                while method14(v481) do
                                    let v483 : int32 = v481.l0
                                    v480.[int v483] <- v483
                                    let v484 : int32 = v483 + 1
                                    v481.l0 <- v484
                                    ()
                                let v485 : int32 = v480.Length
                                let v486 : Mut2 = {l0 = 0; l1 = v479} : Mut2
                                while method15(v485, v486) do
                                    let v488 : int32 = v486.l0
                                    let v489 : num_complex_Complex<float> = v486.l1
                                    let v490 : int32 = v480.[int v488]
                                    let v491 : string = "num_complex::Complex::new($0, $1)"
                                    let v492 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v491 
                                    let v495 : (int32 -> float) = float
                                    let v496 : float = v495 v490
                                    let v508 : string = "num_complex::Complex::new($0, $1)"
                                    let v509 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v496, 0.0) v508 
                                    let v510 : string = "num_complex::Complex::powc($0, $1)"
                                    let v511 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v509, v468) v510 
                                    let v512 : string = "$0 / $1"
                                    let v513 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v492, v511) v512 
                                    let v514 : string = "$0 + $1"
                                    let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v489, v513) v514 
                                    let v516 : int32 = v488 + 1
                                    v486.l0 <- v516
                                    v486.l1 <- v515
                                    ()
                                let v517 : num_complex_Complex<float> = v486.l1
                                v517
                            else
                                let v518 : string = "num_complex::Complex::new($0, $1)"
                                let v519 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v518 
                                let v520 : string = "$0 - $1"
                                let v521 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v519, v468) v520 
                                let v522 : string = $"        s = mpmath.gamma(s)"
                                let v523 : num_complex_Complex<float> = method3(v521)
                                let v524 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v522, v523)
                                (* run_target_args'
                                let v527 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v528 : string = "$0.ok()"
                                let v529 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v524 v528 
                                let _run_target_args'_v527 = v529 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v530 : string = "$0.ok()"
                                let v531 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v524 v530 
                                let _run_target_args'_v527 = v531 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v532 : string = "$0.ok()"
                                let v533 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v524 v532 
                                let _run_target_args'_v527 = v533 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v534 : num_complex_Complex<float> option = match v524 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v527 = v534 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v535 : num_complex_Complex<float> option = match v524 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v527 = v535 
                                #endif
#else
                                let v536 : num_complex_Complex<float> option = match v524 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v527 = v536 
                                #endif
                                let v537 : num_complex_Complex<float> option = _run_target_args'_v527 
                                let v602 : (num_complex_Complex<float> -> US0) = method17()
                                let v603 : US0 option = v537 |> Option.map v602 
                                let v664 : US0 = US0_1
                                let v665 : US0 = v603 |> Option.defaultValue v664 
                                let v678 : string = "f64::NAN"
                                let v679 : float = Fable.Core.RustInterop.emitRustExpr () v678 
                                let v680 : string = "f64::NAN"
                                let v681 : float = Fable.Core.RustInterop.emitRustExpr () v680 
                                let v682 : string = "num_complex::Complex::new($0, $1)"
                                let v683 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v679, v681) v682 
                                let v686 : num_complex_Complex<float> =
                                    match v665 with
                                    | US0_1 -> (* None *)
                                        v683
                                    | US0_0(v684) -> (* Some *)
                                        v684
                                let v687 : string = "num_complex::Complex::new($0, $1)"
                                let v688 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v687 
                                let v689 : string = "$0 * $1"
                                let v690 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v688, v468) v689 
                                let v691 : string = "num_complex::Complex::new($0, $1)"
                                let v692 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v691 
                                let v693 : string = "$0 / $1"
                                let v694 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v690, v692) v693 
                                let v695 : string = "$0.sin()"
                                let v696 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v694 v695 
                                let v697 : string = "$0.re"
                                let v698 : float = Fable.Core.RustInterop.emitRustExpr v468 v697 
                                let v699 : float = 1.0 - v698
                                let v700 : string = "$0.im"
                                let v701 : float = Fable.Core.RustInterop.emitRustExpr v468 v700 
                                let v702 : float =  -v701
                                let v703 : string = "num_complex::Complex::new($0, $1)"
                                let v704 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v699, v702) v703 
                                let v705 : string = "$0.re"
                                let v706 : float = Fable.Core.RustInterop.emitRustExpr v704 v705 
                                let v707 : bool = v706 <= 1.0
                                let v1214 : num_complex_Complex<float> =
                                    if v707 then
                                        let v708 : string = "num_complex::Complex::new($0, $1)"
                                        let v709 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v708 
                                        v709
                                    else
                                        let v710 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v704) v710 
                                        let v711 : string = "$0.re"
                                        let v712 : float = Fable.Core.RustInterop.emitRustExpr v704 v711 
                                        let v713 : bool = v712 > 1.0
                                        if v713 then
                                            let v714 : string = "num_complex::Complex::new($0, $1)"
                                            let v715 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v714 
                                            let v716 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v717 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v717) do
                                                let v719 : int32 = v717.l0
                                                v716.[int v719] <- v719
                                                let v720 : int32 = v719 + 1
                                                v717.l0 <- v720
                                                ()
                                            let v721 : int32 = v716.Length
                                            let v722 : Mut2 = {l0 = 0; l1 = v715} : Mut2
                                            while method15(v721, v722) do
                                                let v724 : int32 = v722.l0
                                                let v725 : num_complex_Complex<float> = v722.l1
                                                let v726 : int32 = v716.[int v724]
                                                let v727 : string = "num_complex::Complex::new($0, $1)"
                                                let v728 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v727 
                                                let v731 : (int32 -> float) = float
                                                let v732 : float = v731 v726
                                                let v744 : string = "num_complex::Complex::new($0, $1)"
                                                let v745 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v732, 0.0) v744 
                                                let v746 : string = "num_complex::Complex::powc($0, $1)"
                                                let v747 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v745, v704) v746 
                                                let v748 : string = "$0 / $1"
                                                let v749 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v728, v747) v748 
                                                let v750 : string = "$0 + $1"
                                                let v751 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v725, v749) v750 
                                                let v752 : int32 = v724 + 1
                                                v722.l0 <- v752
                                                v722.l1 <- v751
                                                ()
                                            let v753 : num_complex_Complex<float> = v722.l1
                                            v753
                                        else
                                            let v754 : string = "num_complex::Complex::new($0, $1)"
                                            let v755 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v754 
                                            let v756 : string = "$0 - $1"
                                            let v757 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v755, v704) v756 
                                            let v758 : string = $"        s = mpmath.gamma(s)"
                                            let v759 : num_complex_Complex<float> = method3(v757)
                                            let v760 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v758, v759)
                                            (* run_target_args'
                                            let v763 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v764 : string = "$0.ok()"
                                            let v765 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v760 v764 
                                            let _run_target_args'_v763 = v765 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v766 : string = "$0.ok()"
                                            let v767 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v760 v766 
                                            let _run_target_args'_v763 = v767 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v768 : string = "$0.ok()"
                                            let v769 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v760 v768 
                                            let _run_target_args'_v763 = v769 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v770 : num_complex_Complex<float> option = match v760 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v763 = v770 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v771 : num_complex_Complex<float> option = match v760 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v763 = v771 
                                            #endif
#else
                                            let v772 : num_complex_Complex<float> option = match v760 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v763 = v772 
                                            #endif
                                            let v773 : num_complex_Complex<float> option = _run_target_args'_v763 
                                            let v838 : (num_complex_Complex<float> -> US0) = method17()
                                            let v839 : US0 option = v773 |> Option.map v838 
                                            let v900 : US0 = US0_1
                                            let v901 : US0 = v839 |> Option.defaultValue v900 
                                            let v914 : string = "f64::NAN"
                                            let v915 : float = Fable.Core.RustInterop.emitRustExpr () v914 
                                            let v916 : string = "f64::NAN"
                                            let v917 : float = Fable.Core.RustInterop.emitRustExpr () v916 
                                            let v918 : string = "num_complex::Complex::new($0, $1)"
                                            let v919 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v915, v917) v918 
                                            let v922 : num_complex_Complex<float> =
                                                match v901 with
                                                | US0_1 -> (* None *)
                                                    v919
                                                | US0_0(v920) -> (* Some *)
                                                    v920
                                            let v923 : string = "num_complex::Complex::new($0, $1)"
                                            let v924 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v923 
                                            let v925 : string = "$0 * $1"
                                            let v926 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v924, v704) v925 
                                            let v927 : string = "num_complex::Complex::new($0, $1)"
                                            let v928 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v927 
                                            let v929 : string = "$0 / $1"
                                            let v930 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v926, v928) v929 
                                            let v931 : string = "$0.sin()"
                                            let v932 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v930 v931 
                                            let v933 : string = "$0.re"
                                            let v934 : float = Fable.Core.RustInterop.emitRustExpr v704 v933 
                                            let v935 : float = 1.0 - v934
                                            let v936 : string = "$0.im"
                                            let v937 : float = Fable.Core.RustInterop.emitRustExpr v704 v936 
                                            let v938 : float =  -v937
                                            let v939 : string = "num_complex::Complex::new($0, $1)"
                                            let v940 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v935, v938) v939 
                                            let v941 : string = "$0.re"
                                            let v942 : float = Fable.Core.RustInterop.emitRustExpr v940 v941 
                                            let v943 : bool = v942 <= 1.0
                                            let v1198 : num_complex_Complex<float> =
                                                if v943 then
                                                    let v944 : string = "num_complex::Complex::new($0, $1)"
                                                    let v945 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v944 
                                                    v945
                                                else
                                                    let v946 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v940) v946 
                                                    let v947 : string = "$0.re"
                                                    let v948 : float = Fable.Core.RustInterop.emitRustExpr v940 v947 
                                                    let v949 : bool = v948 > 1.0
                                                    if v949 then
                                                        let v950 : string = "num_complex::Complex::new($0, $1)"
                                                        let v951 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v950 
                                                        let v952 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v953 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v953) do
                                                            let v955 : int32 = v953.l0
                                                            v952.[int v955] <- v955
                                                            let v956 : int32 = v955 + 1
                                                            v953.l0 <- v956
                                                            ()
                                                        let v957 : int32 = v952.Length
                                                        let v958 : Mut2 = {l0 = 0; l1 = v951} : Mut2
                                                        while method15(v957, v958) do
                                                            let v960 : int32 = v958.l0
                                                            let v961 : num_complex_Complex<float> = v958.l1
                                                            let v962 : int32 = v952.[int v960]
                                                            let v963 : string = "num_complex::Complex::new($0, $1)"
                                                            let v964 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v963 
                                                            let v967 : (int32 -> float) = float
                                                            let v968 : float = v967 v962
                                                            let v980 : string = "num_complex::Complex::new($0, $1)"
                                                            let v981 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v968, 0.0) v980 
                                                            let v982 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v983 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v981, v940) v982 
                                                            let v984 : string = "$0 / $1"
                                                            let v985 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v964, v983) v984 
                                                            let v986 : string = "$0 + $1"
                                                            let v987 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v961, v985) v986 
                                                            let v988 : int32 = v960 + 1
                                                            v958.l0 <- v988
                                                            v958.l1 <- v987
                                                            ()
                                                        let v989 : num_complex_Complex<float> = v958.l1
                                                        v989
                                                    else
                                                        let v990 : string = "num_complex::Complex::new($0, $1)"
                                                        let v991 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v990 
                                                        let v992 : string = "$0 - $1"
                                                        let v993 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v991, v940) v992 
                                                        let v994 : string = $"        s = mpmath.gamma(s)"
                                                        let v995 : num_complex_Complex<float> = method3(v993)
                                                        let v996 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v994, v995)
                                                        (* run_target_args'
                                                        let v999 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v1000 : string = "$0.ok()"
                                                        let v1001 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v996 v1000 
                                                        let _run_target_args'_v999 = v1001 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v1002 : string = "$0.ok()"
                                                        let v1003 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v996 v1002 
                                                        let _run_target_args'_v999 = v1003 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v1004 : string = "$0.ok()"
                                                        let v1005 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v996 v1004 
                                                        let _run_target_args'_v999 = v1005 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v1006 : num_complex_Complex<float> option = match v996 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v999 = v1006 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v1007 : num_complex_Complex<float> option = match v996 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v999 = v1007 
                                                        #endif
#else
                                                        let v1008 : num_complex_Complex<float> option = match v996 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v999 = v1008 
                                                        #endif
                                                        let v1009 : num_complex_Complex<float> option = _run_target_args'_v999 
                                                        let v1074 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v1075 : US0 option = v1009 |> Option.map v1074 
                                                        let v1136 : US0 = US0_1
                                                        let v1137 : US0 = v1075 |> Option.defaultValue v1136 
                                                        let v1150 : string = "f64::NAN"
                                                        let v1151 : float = Fable.Core.RustInterop.emitRustExpr () v1150 
                                                        let v1152 : string = "f64::NAN"
                                                        let v1153 : float = Fable.Core.RustInterop.emitRustExpr () v1152 
                                                        let v1154 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1155 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1151, v1153) v1154 
                                                        let v1158 : num_complex_Complex<float> =
                                                            match v1137 with
                                                            | US0_1 -> (* None *)
                                                                v1155
                                                            | US0_0(v1156) -> (* Some *)
                                                                v1156
                                                        let v1159 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1160 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1159 
                                                        let v1161 : string = "$0 * $1"
                                                        let v1162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1160, v940) v1161 
                                                        let v1163 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1164 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1163 
                                                        let v1165 : string = "$0 / $1"
                                                        let v1166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1162, v1164) v1165 
                                                        let v1167 : string = "$0.sin()"
                                                        let v1168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v1166 v1167 
                                                        let v1169 : string = "$0.re"
                                                        let v1170 : float = Fable.Core.RustInterop.emitRustExpr v940 v1169 
                                                        let v1171 : float = 1.0 - v1170
                                                        let v1172 : string = "$0.im"
                                                        let v1173 : float = Fable.Core.RustInterop.emitRustExpr v940 v1172 
                                                        let v1174 : float =  -v1173
                                                        let v1175 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1171, v1174) v1175 
                                                        let v1177 : string = "$0.re"
                                                        let v1178 : float = Fable.Core.RustInterop.emitRustExpr v1176 v1177 
                                                        let v1179 : bool = v1178 <= 1.0
                                                        let v1182 : num_complex_Complex<float> =
                                                            if v1179 then
                                                                let v1180 : string = "num_complex::Complex::new($0, $1)"
                                                                let v1181 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v1180 
                                                                v1181
                                                            else
                                                                v1176
                                                        let v1183 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1183 
                                                        let v1185 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1185 
                                                        let v1187 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v1188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1186, v940) v1187 
                                                        let v1189 : string = "$0 * $1"
                                                        let v1190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1184, v1188) v1189 
                                                        let v1191 : string = "$0 * $1"
                                                        let v1192 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1190, v1168) v1191 
                                                        let v1193 : string = "$0 * $1"
                                                        let v1194 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1192, v1158) v1193 
                                                        let v1195 : string = "$0 * $1"
                                                        let v1196 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1194, v1182) v1195 
                                                        v1196
                                            let v1199 : string = "num_complex::Complex::new($0, $1)"
                                            let v1200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1199 
                                            let v1201 : string = "num_complex::Complex::new($0, $1)"
                                            let v1202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1201 
                                            let v1203 : string = "num_complex::Complex::powc($0, $1)"
                                            let v1204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1202, v704) v1203 
                                            let v1205 : string = "$0 * $1"
                                            let v1206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1200, v1204) v1205 
                                            let v1207 : string = "$0 * $1"
                                            let v1208 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1206, v932) v1207 
                                            let v1209 : string = "$0 * $1"
                                            let v1210 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1208, v922) v1209 
                                            let v1211 : string = "$0 * $1"
                                            let v1212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1210, v1198) v1211 
                                            v1212
                                let v1215 : string = "num_complex::Complex::new($0, $1)"
                                let v1216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1215 
                                let v1217 : string = "num_complex::Complex::new($0, $1)"
                                let v1218 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1217 
                                let v1219 : string = "num_complex::Complex::powc($0, $1)"
                                let v1220 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1218, v468) v1219 
                                let v1221 : string = "$0 * $1"
                                let v1222 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1216, v1220) v1221 
                                let v1223 : string = "$0 * $1"
                                let v1224 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1222, v696) v1223 
                                let v1225 : string = "$0 * $1"
                                let v1226 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1224, v686) v1225 
                                let v1227 : string = "$0 * $1"
                                let v1228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1226, v1214) v1227 
                                v1228
                    let v1231 : string = "num_complex::Complex::new($0, $1)"
                    let v1232 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1231 
                    let v1233 : string = "num_complex::Complex::new($0, $1)"
                    let v1234 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1233 
                    let v1235 : string = "num_complex::Complex::powc($0, $1)"
                    let v1236 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1234, v232) v1235 
                    let v1237 : string = "$0 * $1"
                    let v1238 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1232, v1236) v1237 
                    let v1239 : string = "$0 * $1"
                    let v1240 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1238, v460) v1239 
                    let v1241 : string = "$0 * $1"
                    let v1242 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1240, v450) v1241 
                    let v1243 : string = "$0 * $1"
                    let v1244 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1242, v1230) v1243 
                    v1244
        let v1247 : string = "num_complex::Complex::new($0, $1)"
        let v1248 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1247 
        let v1249 : string = "num_complex::Complex::new($0, $1)"
        let v1250 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1249 
        let v1251 : string = "num_complex::Complex::powc($0, $1)"
        let v1252 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1250, v1) v1251 
        let v1253 : string = "$0 * $1"
        let v1254 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1248, v1252) v1253 
        let v1255 : string = "$0 * $1"
        let v1256 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1254, v224) v1255 
        let v1257 : string = "$0 * $1"
        let v1258 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1256, v214) v1257 
        let v1259 : string = "$0 * $1"
        let v1260 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1258, v1246) v1259 
        v1260
and method18 (v0 : bool) : bool =
    v0
and method20 () : string =
    let v0 : string = ""
    v0
and method21 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "{ "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method22 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "expected"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method23 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = " = "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method24 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v5 : string = v2 + v1 
    v0.l0 <- v5
    ()
and method25 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = " }"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method19 (v0 : float) : string =
    let v1 : string = method20()
    let v12 : Mut3 = {l0 = v1} : Mut3
    method21(v12)
    method22(v12)
    method23(v12)
    let v416 : string = $"%+.6f{v0}"
    method24(v12, v416)
    method25(v12)
    let v664 : string = v12.l0
    v664
and method27 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "actual"
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method28 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v6 : string = "; "
    let v7 : string = v1 + v6 
    v0.l0 <- v7
    ()
and method26 (v0 : float, v1 : float) : string =
    let v2 : string = method20()
    let v13 : Mut3 = {l0 = v2} : Mut3
    method21(v13)
    method27(v13)
    method23(v13)
    let v417 : string = $"%+.6f{v0}"
    method24(v13, v417)
    method28(v13)
    method22(v13)
    method23(v13)
    let v943 : string = $"%+.6f{v1}"
    method24(v13, v943)
    method25(v13)
    let v1191 : string = v13.l0
    v1191
and closure2 (v0 : string) () : unit =
    let v1 : (string -> unit) = System.Console.WriteLine
    v1 v0
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
        let v15 : num_complex_Complex<float> = method13(v0, v10)
        (* run_target_args'
        let v18 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v19 : string = "$0.ok()"
        let v20 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v19 
        let _run_target_args'_v18 = v20 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v21 : string = "$0.ok()"
        let v22 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v21 
        let _run_target_args'_v18 = v22 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v23 : string = "$0.ok()"
        let v24 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v23 
        let _run_target_args'_v18 = v24 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v25 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v18 = v25 
        #endif
#if FABLE_COMPILER_PYTHON
        let v26 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v18 = v26 
        #endif
#else
        let v27 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v18 = v27 
        #endif
        let v28 : num_complex_Complex<float> option = _run_target_args'_v18 
        let v93 : (num_complex_Complex<float> -> US0) = method17()
        let v94 : US0 option = v28 |> Option.map v93 
        let v155 : US0 = US0_1
        let v156 : US0 = v94 |> Option.defaultValue v155 
        let v169 : string = "f64::NAN"
        let v170 : float = Fable.Core.RustInterop.emitRustExpr () v169 
        let v171 : string = "f64::NAN"
        let v172 : float = Fable.Core.RustInterop.emitRustExpr () v171 
        let v173 : string = "num_complex::Complex::new($0, $1)"
        let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v170, v172) v173 
        let v177 : num_complex_Complex<float> =
            match v156 with
            | US0_1 -> (* None *)
                v174
            | US0_0(v175) -> (* Some *)
                v175
        let v178 : string = "$0.im"
        let v179 : float = Fable.Core.RustInterop.emitRustExpr v177 v178 
        let v180 : bool = v179 = 0.0
        let v182 : bool =
            if v180 then
                true
            else
                method18(v180)
        let v187 : string =
            if v180 then
                let v183 : float = 0.0
                method19(v183)
            else
                let v185 : float = 0.0
                method26(v179, v185)
        let v194 : string = "__assert_eq"
        let v195 : string = " "
        let v196 : string = v194 + v195 
        let v212 : string =
            if v180 then
                let v208 : float = 0.0
                method19(v208)
            else
                let v210 : float = 0.0
                method26(v179, v210)
        let v215 : string = v196 + v212 
        let v257 : unit = ()
        let v258 : (unit -> unit) = closure2(v215)
        let v259 : unit = (fun () -> v258 (); v257) ()
        let v271 : bool = v182 = false
        if v271 then
            failwith<unit> v215
        let v272 : string = "$0.re"
        let v273 : float = Fable.Core.RustInterop.emitRustExpr v177 v272 
        let v274 : float = v273 - v11
        let v275 : float =  -v274
        let v276 : bool = v274 >= v275
        let v277 : float =
            if v276 then
                v274
            else
                v275
        let v278 : bool = v277 < 0.0001
        let v280 : bool =
            if v278 then
                true
            else
                method18(v278)
        let v285 : string =
            if v278 then
                let v281 : float = 0.0001
                method19(v281)
            else
                let v283 : float = 0.0001
                method26(v277, v283)
        let v290 : string = "__assert_lt"
        let v291 : string = v290 + v195 
        let v307 : string =
            if v278 then
                let v303 : float = 0.0001
                method19(v303)
            else
                let v305 : float = 0.0001
                method26(v277, v305)
        let v310 : string = v291 + v307 
        let v352 : unit = ()
        let v353 : (unit -> unit) = closure2(v310)
        let v354 : unit = (fun () -> v353 (); v352) ()
        let v366 : bool = v280 = false
        if v366 then
            failwith<unit> v310
        let v367 : int32 = v9 + 1
        v7.l0 <- v367
        ()
    ()
and method29 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method0 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method1(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method31 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v9 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _run_target_args'_v9 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _run_target_args'_v9 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : string = "$0.ok()"
    let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v14 
    let _run_target_args'_v9 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v84 : (num_complex_Complex<float> -> US0) = method17()
    let v85 : US0 option = v19 |> Option.map v84 
    let v146 : US0 = US0_1
    let v147 : US0 = v85 |> Option.defaultValue v146 
    let v160 : string = "f64::NAN"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = "f64::NAN"
    let v163 : float = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "num_complex::Complex::new($0, $1)"
    let v165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v164 
    let v168 : num_complex_Complex<float> =
        match v147 with
        | US0_1 -> (* None *)
            v165
        | US0_0(v166) -> (* Some *)
            v166
    let v169 : string = "$0.re"
    let v170 : float = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let v171 : float = v170 - 0.8673
    let v172 : float =  -v171
    let v173 : bool = v171 >= v172
    let v174 : float =
        if v173 then
            v171
        else
            v172
    let v175 : bool = v174 < 0.001
    let v177 : bool =
        if v175 then
            true
        else
            method18(v175)
    let v182 : string =
        if v175 then
            let v178 : float = 0.001
            method19(v178)
        else
            let v180 : float = 0.001
            method26(v174, v180)
    let v189 : string = "__assert_lt"
    let v190 : string = " "
    let v191 : string = v189 + v190 
    let v207 : string =
        if v175 then
            let v203 : float = 0.001
            method19(v203)
        else
            let v205 : float = 0.001
            method26(v174, v205)
    let v210 : string = v191 + v207 
    let v252 : unit = ()
    let v253 : (unit -> unit) = closure2(v210)
    let v254 : unit = (fun () -> v253 (); v252) ()
    let v266 : bool = v177 = false
    if v266 then
        failwith<unit> v210
    let v267 : string = "$0.im"
    let v268 : float = Fable.Core.RustInterop.emitRustExpr v168 v267 
    let v269 : float = v268 - 0.275
    let v270 : float =  -v269
    let v271 : bool = v269 >= v270
    let v272 : float =
        if v271 then
            v269
        else
            v270
    let v273 : bool = v272 < 0.001
    let v275 : bool =
        if v273 then
            true
        else
            method18(v273)
    let v280 : string =
        if v273 then
            let v276 : float = 0.001
            method19(v276)
        else
            let v278 : float = 0.001
            method26(v272, v278)
    let v283 : string = v189 + v190 
    let v299 : string =
        if v273 then
            let v295 : float = 0.001
            method19(v295)
        else
            let v297 : float = 0.001
            method26(v272, v297)
    let v302 : string = v283 + v299 
    let v344 : unit = ()
    let v345 : (unit -> unit) = closure2(v302)
    let v346 : unit = (fun () -> v345 (); v344) ()
    let v358 : bool = v275 = false
    if v358 then
        failwith<unit> v302
and method30 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method34 () : UH0 =
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
and method35 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, 0.0) v4 
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method13(v0, v5)
        (* run_target_args'
        let v12 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v13 
        let _run_target_args'_v12 = v14 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v15 
        let _run_target_args'_v12 = v16 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v17 
        let _run_target_args'_v12 = v18 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v19 
        #endif
#if FABLE_COMPILER_PYTHON
        let v20 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v20 
        #endif
#else
        let v21 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v21 
        #endif
        let v22 : num_complex_Complex<float> option = _run_target_args'_v12 
        let v87 : (num_complex_Complex<float> -> US0) = method17()
        let v88 : US0 option = v22 |> Option.map v87 
        let v149 : US0 = US0_1
        let v150 : US0 = v88 |> Option.defaultValue v149 
        let v163 : string = "f64::NAN"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = "f64::NAN"
        let v166 : float = Fable.Core.RustInterop.emitRustExpr () v165 
        let v167 : string = "num_complex::Complex::new($0, $1)"
        let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v164, v166) v167 
        let v171 : num_complex_Complex<float> =
            match v150 with
            | US0_1 -> (* None *)
                v168
            | US0_0(v169) -> (* Some *)
                v169
        let v172 : string = "$0.re"
        let v173 : float = Fable.Core.RustInterop.emitRustExpr v171 v172 
        let v174 : bool = v173 = 0.0
        let v176 : bool =
            if v174 then
                true
            else
                method18(v174)
        let v181 : string =
            if v174 then
                let v177 : float = 0.0
                method19(v177)
            else
                let v179 : float = 0.0
                method26(v173, v179)
        let v188 : string = "__assert_eq"
        let v189 : string = " "
        let v190 : string = v188 + v189 
        let v206 : string =
            if v174 then
                let v202 : float = 0.0
                method19(v202)
            else
                let v204 : float = 0.0
                method26(v173, v204)
        let v209 : string = v190 + v206 
        let v251 : unit = ()
        let v252 : (unit -> unit) = closure2(v209)
        let v253 : unit = (fun () -> v252 (); v251) ()
        let v265 : bool = v176 = false
        if v265 then
            failwith<unit> v209
        let v266 : string = "$0.im"
        let v267 : float = Fable.Core.RustInterop.emitRustExpr v171 v266 
        let v268 : bool = v267 = 0.0
        let v270 : bool =
            if v268 then
                true
            else
                method18(v268)
        let v275 : string =
            if v268 then
                let v271 : float = 0.0
                method19(v271)
            else
                let v273 : float = 0.0
                method26(v267, v273)
        let v278 : string = v188 + v189 
        let v294 : string =
            if v268 then
                let v290 : float = 0.0
                method19(v290)
            else
                let v292 : float = 0.0
                method26(v267, v292)
        let v297 : string = v278 + v294 
        let v339 : unit = ()
        let v340 : (unit -> unit) = closure2(v297)
        let v341 : unit = (fun () -> v340 (); v339) ()
        let v353 : bool = v270 = false
        if v353 then
            failwith<unit> v297
        method35(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method33 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method34()
    method35(v0, v1)
and method32 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method33(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method37 (v0 : pyo3_Python) : unit =
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
        let v22 : num_complex_Complex<float> = method13(v0, v18)
        (* run_target_args'
        let v25 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v26 : string = "$0.ok()"
        let v27 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v26 
        let _run_target_args'_v25 = v27 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v28 : string = "$0.ok()"
        let v29 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v28 
        let _run_target_args'_v25 = v29 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v30 : string = "$0.ok()"
        let v31 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v30 
        let _run_target_args'_v25 = v31 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v32 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v25 = v32 
        #endif
#if FABLE_COMPILER_PYTHON
        let v33 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v25 = v33 
        #endif
#else
        let v34 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v25 = v34 
        #endif
        let v35 : num_complex_Complex<float> option = _run_target_args'_v25 
        let v100 : (num_complex_Complex<float> -> US0) = method17()
        let v101 : US0 option = v35 |> Option.map v100 
        let v162 : US0 = US0_1
        let v163 : US0 = v101 |> Option.defaultValue v162 
        let v176 : string = "f64::NAN"
        let v177 : float = Fable.Core.RustInterop.emitRustExpr () v176 
        let v178 : string = "f64::NAN"
        let v179 : float = Fable.Core.RustInterop.emitRustExpr () v178 
        let v180 : string = "num_complex::Complex::new($0, $1)"
        let v181 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v177, v179) v180 
        let v184 : num_complex_Complex<float> =
            match v163 with
            | US0_1 -> (* None *)
                v181
            | US0_0(v182) -> (* Some *)
                v182
        let v185 : string = "$0.re"
        let v186 : float = Fable.Core.RustInterop.emitRustExpr v184 v185 
        let v187 : float =  -v186
        let v188 : bool = v186 >= v187
        let v189 : float =
            if v188 then
                v186
            else
                v187
        let v190 : bool = v189 < 0.0001
        let v192 : bool =
            if v190 then
                true
            else
                method18(v190)
        let v197 : string =
            if v190 then
                let v193 : float = 0.0001
                method19(v193)
            else
                let v195 : float = 0.0001
                method26(v189, v195)
        let v204 : string = "__assert_lt"
        let v205 : string = " "
        let v206 : string = v204 + v205 
        let v222 : string =
            if v190 then
                let v218 : float = 0.0001
                method19(v218)
            else
                let v220 : float = 0.0001
                method26(v189, v220)
        let v225 : string = v206 + v222 
        let v267 : unit = ()
        let v268 : (unit -> unit) = closure2(v225)
        let v269 : unit = (fun () -> v268 (); v267) ()
        let v281 : bool = v192 = false
        if v281 then
            failwith<unit> v225
        let v282 : string = "$0.im"
        let v283 : float = Fable.Core.RustInterop.emitRustExpr v184 v282 
        let v284 : float =  -v283
        let v285 : bool = v283 >= v284
        let v286 : float =
            if v285 then
                v283
            else
                v284
        let v287 : bool = v286 < 0.0001
        let v289 : bool =
            if v287 then
                true
            else
                method18(v287)
        let v294 : string =
            if v287 then
                let v290 : float = 0.0001
                method19(v290)
            else
                let v292 : float = 0.0001
                method26(v286, v292)
        let v297 : string = v204 + v205 
        let v313 : string =
            if v287 then
                let v309 : float = 0.0001
                method19(v309)
            else
                let v311 : float = 0.0001
                method26(v286, v311)
        let v316 : string = v297 + v313 
        let v358 : unit = ()
        let v359 : (unit -> unit) = closure2(v316)
        let v360 : unit = (fun () -> v359 (); v358) ()
        let v372 : bool = v289 = false
        if v372 then
            failwith<unit> v316
        let v373 : int32 = v17 + 1
        v15.l0 <- v373
        ()
    ()
and method36 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method37(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method39 (v0 : pyo3_Python) : unit =
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
        let v12 : num_complex_Complex<float> = method13(v0, v8)
        (* run_target_args'
        let v15 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v16 
        let _run_target_args'_v15 = v17 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v18 : string = "$0.ok()"
        let v19 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v18 
        let _run_target_args'_v15 = v19 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v20 : string = "$0.ok()"
        let v21 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v20 
        let _run_target_args'_v15 = v21 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v22 
        #endif
#if FABLE_COMPILER_PYTHON
        let v23 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v23 
        #endif
#else
        let v24 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v24 
        #endif
        let v25 : num_complex_Complex<float> option = _run_target_args'_v15 
        let v90 : (num_complex_Complex<float> -> US0) = method17()
        let v91 : US0 option = v25 |> Option.map v90 
        let v152 : US0 = US0_1
        let v153 : US0 = v91 |> Option.defaultValue v152 
        let v166 : string = "f64::NAN"
        let v167 : float = Fable.Core.RustInterop.emitRustExpr () v166 
        let v168 : string = "f64::NAN"
        let v169 : float = Fable.Core.RustInterop.emitRustExpr () v168 
        let v170 : string = "num_complex::Complex::new($0, $1)"
        let v171 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v167, v169) v170 
        let v174 : num_complex_Complex<float> =
            match v153 with
            | US0_1 -> (* None *)
                v171
            | US0_0(v172) -> (* Some *)
                v172
        let v175 : string = "$0.re"
        let v176 : float = Fable.Core.RustInterop.emitRustExpr v174 v175 
        let v177 : bool = v176 > 0.0
        let v179 : bool =
            if v177 then
                true
            else
                method18(v177)
        let v184 : string =
            if v177 then
                let v180 : float = 0.0
                method19(v180)
            else
                let v182 : float = 0.0
                method26(v176, v182)
        let v191 : string = "__assert_gt"
        let v192 : string = " "
        let v193 : string = v191 + v192 
        let v209 : string =
            if v177 then
                let v205 : float = 0.0
                method19(v205)
            else
                let v207 : float = 0.0
                method26(v176, v207)
        let v212 : string = v193 + v209 
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure2(v212)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v268 : bool = v179 = false
        if v268 then
            failwith<unit> v212
        let v269 : string = "$0.im"
        let v270 : float = Fable.Core.RustInterop.emitRustExpr v174 v269 
        let v271 : bool = v270 = 0.0
        let v273 : bool =
            if v271 then
                true
            else
                method18(v271)
        let v278 : string =
            if v271 then
                let v274 : float = 0.0
                method19(v274)
            else
                let v276 : float = 0.0
                method26(v270, v276)
        let v283 : string = "__assert_eq"
        let v284 : string = v283 + v192 
        let v300 : string =
            if v271 then
                let v296 : float = 0.0
                method19(v296)
            else
                let v298 : float = 0.0
                method26(v270, v298)
        let v303 : string = v284 + v300 
        let v345 : unit = ()
        let v346 : (unit -> unit) = closure2(v303)
        let v347 : unit = (fun () -> v346 (); v345) ()
        let v359 : bool = v273 = false
        if v359 then
            failwith<unit> v303
        let v360 : int32 = v5 + 1
        v3.l0 <- v360
        ()
    ()
and method38 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method39(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method41 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v9 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _run_target_args'_v9 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _run_target_args'_v9 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : string = "$0.ok()"
    let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v14 
    let _run_target_args'_v9 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v84 : (num_complex_Complex<float> -> US0) = method17()
    let v85 : US0 option = v19 |> Option.map v84 
    let v146 : US0 = US0_1
    let v147 : US0 = v85 |> Option.defaultValue v146 
    let v160 : string = "f64::NAN"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = "f64::NAN"
    let v163 : float = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "num_complex::Complex::new($0, $1)"
    let v165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v164 
    let v168 : num_complex_Complex<float> =
        match v147 with
        | US0_1 -> (* None *)
            v165
        | US0_0(v166) -> (* Some *)
            v166
    let v169 : string = "$0.re"
    let v170 : float = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let v171 : bool = v170 = infinity
    let v173 : bool =
        if v171 then
            true
        else
            method18(v171)
    let v178 : string =
        if v171 then
            let v174 : float = infinity
            method19(v174)
        else
            let v176 : float = infinity
            method26(v170, v176)
    let v185 : string = "__assert_eq"
    let v186 : string = " "
    let v187 : string = v185 + v186 
    let v203 : string =
        if v171 then
            let v199 : float = infinity
            method19(v199)
        else
            let v201 : float = infinity
            method26(v170, v201)
    let v206 : string = v187 + v203 
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure2(v206)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v262 : bool = v173 = false
    if v262 then
        failwith<unit> v206
    let v263 : string = "$0.im"
    let v264 : float = Fable.Core.RustInterop.emitRustExpr v168 v263 
    let v265 : bool = v264 = 0.0
    let v267 : bool =
        if v265 then
            true
        else
            method18(v265)
    let v272 : string =
        if v265 then
            let v268 : float = 0.0
            method19(v268)
        else
            let v270 : float = 0.0
            method26(v264, v270)
    let v275 : string = v185 + v186 
    let v291 : string =
        if v265 then
            let v287 : float = 0.0
            method19(v287)
        else
            let v289 : float = 0.0
            method26(v264, v289)
    let v294 : string = v275 + v291 
    let v336 : unit = ()
    let v337 : (unit -> unit) = closure2(v294)
    let v338 : unit = (fun () -> v337 (); v336) ()
    let v350 : bool = v267 = false
    if v350 then
        failwith<unit> v294
and method40 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method41(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method43 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v9 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _run_target_args'_v9 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _run_target_args'_v9 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : string = "$0.ok()"
    let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v14 
    let _run_target_args'_v9 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v84 : (num_complex_Complex<float> -> US0) = method17()
    let v85 : US0 option = v19 |> Option.map v84 
    let v146 : US0 = US0_1
    let v147 : US0 = v85 |> Option.defaultValue v146 
    let v160 : string = "f64::NAN"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = "f64::NAN"
    let v163 : float = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "num_complex::Complex::new($0, $1)"
    let v165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v164 
    let v168 : num_complex_Complex<float> =
        match v147 with
        | US0_1 -> (* None *)
            v165
        | US0_0(v166) -> (* Some *)
            v166
    let v169 : string = "$0.re"
    let v170 : float = Fable.Core.RustInterop.emitRustExpr v2 v169 
    let v171 : string = "$0.im"
    let v172 : float = Fable.Core.RustInterop.emitRustExpr v2 v171 
    let v173 : float =  -v172
    let v174 : string = "num_complex::Complex::new($0, $1)"
    let v175 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v170, v173) v174 
    let v176 : string = $"        s = mpmath.zeta(s)"
    let v177 : num_complex_Complex<float> = method3(v175)
    let v178 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v176, v177)
    let v179 : num_complex_Complex<float> = method13(v0, v175)
    (* run_target_args'
    let v182 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v183 : string = "$0.ok()"
    let v184 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v178 v183 
    let _run_target_args'_v182 = v184 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v185 : string = "$0.ok()"
    let v186 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v178 v185 
    let _run_target_args'_v182 = v186 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v187 : string = "$0.ok()"
    let v188 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v178 v187 
    let _run_target_args'_v182 = v188 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v189 : num_complex_Complex<float> option = match v178 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v182 = v189 
    #endif
#if FABLE_COMPILER_PYTHON
    let v190 : num_complex_Complex<float> option = match v178 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v182 = v190 
    #endif
#else
    let v191 : num_complex_Complex<float> option = match v178 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v182 = v191 
    #endif
    let v192 : num_complex_Complex<float> option = _run_target_args'_v182 
    let v257 : (num_complex_Complex<float> -> US0) = method17()
    let v258 : US0 option = v192 |> Option.map v257 
    let v319 : US0 = US0_1
    let v320 : US0 = v258 |> Option.defaultValue v319 
    let v333 : string = "f64::NAN"
    let v334 : float = Fable.Core.RustInterop.emitRustExpr () v333 
    let v335 : string = "f64::NAN"
    let v336 : float = Fable.Core.RustInterop.emitRustExpr () v335 
    let v337 : string = "num_complex::Complex::new($0, $1)"
    let v338 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v334, v336) v337 
    let v341 : num_complex_Complex<float> =
        match v320 with
        | US0_1 -> (* None *)
            v338
        | US0_0(v339) -> (* Some *)
            v339
    let v342 : string = "$0.conj()"
    let v343 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v341 v342 
    let v344 : string = "$0.re"
    let v345 : float = Fable.Core.RustInterop.emitRustExpr v168 v344 
    let v346 : string = "$0.re"
    let v347 : float = Fable.Core.RustInterop.emitRustExpr v343 v346 
    let v348 : bool = v345 = v347
    let v350 : bool =
        if v348 then
            true
        else
            method18(v348)
    let v353 : string =
        if v348 then
            method19(v347)
        else
            method26(v345, v347)
    let v360 : string = "__assert_eq"
    let v361 : string = " "
    let v362 : string = v360 + v361 
    let v376 : string =
        if v348 then
            method19(v347)
        else
            method26(v345, v347)
    let v379 : string = v362 + v376 
    let v421 : unit = ()
    let v422 : (unit -> unit) = closure2(v379)
    let v423 : unit = (fun () -> v422 (); v421) ()
    let v435 : bool = v350 = false
    if v435 then
        failwith<unit> v379
    let v436 : string = "$0.im"
    let v437 : float = Fable.Core.RustInterop.emitRustExpr v168 v436 
    let v438 : string = "$0.im"
    let v439 : float = Fable.Core.RustInterop.emitRustExpr v343 v438 
    let v440 : bool = v437 = v439
    let v442 : bool =
        if v440 then
            true
        else
            method18(v440)
    let v445 : string =
        if v440 then
            method19(v439)
        else
            method26(v437, v439)
    let v448 : string = v360 + v361 
    let v462 : string =
        if v440 then
            method19(v439)
        else
            method26(v437, v439)
    let v465 : string = v448 + v462 
    let v507 : unit = ()
    let v508 : (unit -> unit) = closure2(v465)
    let v509 : unit = (fun () -> v508 (); v507) ()
    let v521 : bool = v442 = false
    if v521 then
        failwith<unit> v465
and method42 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method43(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method45 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v9 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v10 : string = "$0.ok()"
    let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v10 
    let _run_target_args'_v9 = v11 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v12 : string = "$0.ok()"
    let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v12 
    let _run_target_args'_v9 = v13 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v14 : string = "$0.ok()"
    let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v14 
    let _run_target_args'_v9 = v15 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v16 
    #endif
#if FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v84 : (num_complex_Complex<float> -> US0) = method17()
    let v85 : US0 option = v19 |> Option.map v84 
    let v146 : US0 = US0_1
    let v147 : US0 = v85 |> Option.defaultValue v146 
    let v160 : string = "f64::NAN"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr () v160 
    let v162 : string = "f64::NAN"
    let v163 : float = Fable.Core.RustInterop.emitRustExpr () v162 
    let v164 : string = "num_complex::Complex::new($0, $1)"
    let v165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v164 
    let v168 : num_complex_Complex<float> =
        match v147 with
        | US0_1 -> (* None *)
            v165
        | US0_0(v166) -> (* Some *)
            v166
    let v169 : string = "$0.re"
    let v170 : float = Fable.Core.RustInterop.emitRustExpr v168 v169 
    let v171 : bool = v170 < infinity
    let v173 : bool =
        if v171 then
            true
        else
            method18(v171)
    let v178 : string =
        if v171 then
            let v174 : float = infinity
            method19(v174)
        else
            let v176 : float = infinity
            method26(v170, v176)
    let v185 : string = "__assert_lt"
    let v186 : string = " "
    let v187 : string = v185 + v186 
    let v203 : string =
        if v171 then
            let v199 : float = infinity
            method19(v199)
        else
            let v201 : float = infinity
            method26(v170, v201)
    let v206 : string = v187 + v203 
    let v248 : unit = ()
    let v249 : (unit -> unit) = closure2(v206)
    let v250 : unit = (fun () -> v249 (); v248) ()
    let v262 : bool = v173 = false
    if v262 then
        failwith<unit> v206
    let v263 : string = "$0.im"
    let v264 : float = Fable.Core.RustInterop.emitRustExpr v168 v263 
    let v265 : bool = v264 < infinity
    let v267 : bool =
        if v265 then
            true
        else
            method18(v265)
    let v272 : string =
        if v265 then
            let v268 : float = infinity
            method19(v268)
        else
            let v270 : float = infinity
            method26(v264, v270)
    let v275 : string = v185 + v186 
    let v291 : string =
        if v265 then
            let v287 : float = infinity
            method19(v287)
        else
            let v289 : float = infinity
            method26(v264, v289)
    let v294 : string = v275 + v291 
    let v336 : unit = ()
    let v337 : (unit -> unit) = closure2(v294)
    let v338 : unit = (fun () -> v337 (); v336) ()
    let v350 : bool = v267 = false
    if v350 then
        failwith<unit> v294
and method44 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method45(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method48 () : UH0 =
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
and method49 (v0 : pyo3_Python, v1 : UH0) : unit =
    match v1 with
    | UH0_1(v2, v3) -> (* Cons *)
        let v4 : string = "num_complex::Complex::new($0, $1)"
        let v5 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, v2) v4 
        let v6 : string = $"        s = mpmath.zeta(s)"
        let v7 : num_complex_Complex<float> = method3(v5)
        let v8 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v6, v7)
        let v9 : num_complex_Complex<float> = method13(v0, v5)
        (* run_target_args'
        let v12 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v13 
        let _run_target_args'_v12 = v14 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v15 
        let _run_target_args'_v12 = v16 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v17 
        let _run_target_args'_v12 = v18 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v19 
        #endif
#if FABLE_COMPILER_PYTHON
        let v20 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v20 
        #endif
#else
        let v21 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v21 
        #endif
        let v22 : num_complex_Complex<float> option = _run_target_args'_v12 
        let v87 : (num_complex_Complex<float> -> US0) = method17()
        let v88 : US0 option = v22 |> Option.map v87 
        let v149 : US0 = US0_1
        let v150 : US0 = v88 |> Option.defaultValue v149 
        let v163 : string = "f64::NAN"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = "f64::NAN"
        let v166 : float = Fable.Core.RustInterop.emitRustExpr () v165 
        let v167 : string = "num_complex::Complex::new($0, $1)"
        let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v164, v166) v167 
        let v171 : num_complex_Complex<float> =
            match v150 with
            | US0_1 -> (* None *)
                v168
            | US0_0(v169) -> (* Some *)
                v169
        let v172 : string = "$0.re"
        let v173 : float = Fable.Core.RustInterop.emitRustExpr v171 v172 
        let v176 : bool = v173 <> 0.0 
        let v189 : bool =
            if v176 then
                true
            else
                method18(v176)
        let v194 : string =
            if v176 then
                let v190 : float = 0.0
                method19(v190)
            else
                let v192 : float = 0.0
                method26(v173, v192)
        let v201 : string = "__assert_ne"
        let v202 : string = " "
        let v203 : string = v201 + v202 
        let v219 : string =
            if v176 then
                let v215 : float = 0.0
                method19(v215)
            else
                let v217 : float = 0.0
                method26(v173, v217)
        let v222 : string = v203 + v219 
        let v264 : unit = ()
        let v265 : (unit -> unit) = closure2(v222)
        let v266 : unit = (fun () -> v265 (); v264) ()
        let v278 : bool = v189 = false
        if v278 then
            failwith<unit> v222
        let v279 : string = "$0.im"
        let v280 : float = Fable.Core.RustInterop.emitRustExpr v171 v279 
        let v283 : bool = v280 <> 0.0 
        let v296 : bool =
            if v283 then
                true
            else
                method18(v283)
        let v301 : string =
            if v283 then
                let v297 : float = 0.0
                method19(v297)
            else
                let v299 : float = 0.0
                method26(v280, v299)
        let v304 : string = v201 + v202 
        let v320 : string =
            if v283 then
                let v316 : float = 0.0
                method19(v316)
            else
                let v318 : float = 0.0
                method26(v280, v318)
        let v323 : string = v304 + v320 
        let v365 : unit = ()
        let v366 : (unit -> unit) = closure2(v323)
        let v367 : unit = (fun () -> v366 (); v365) ()
        let v379 : bool = v296 = false
        if v379 then
            failwith<unit> v323
        method49(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method47 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method48()
    method49(v0, v1)
and method46 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method47(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method52 () : UH1 =
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
and method53 (v0 : pyo3_Python, v1 : UH1) : unit =
    match v1 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string = $"        s = mpmath.zeta(s)"
        let v5 : num_complex_Complex<float> = method3(v2)
        let v6 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4, v5)
        let v7 : num_complex_Complex<float> = method13(v0, v2)
        (* run_target_args'
        let v10 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11 : string = "$0.ok()"
        let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v11 
        let _run_target_args'_v10 = v12 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v13 
        let _run_target_args'_v10 = v14 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v15 
        let _run_target_args'_v10 = v16 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v17 
        #endif
#if FABLE_COMPILER_PYTHON
        let v18 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v18 
        #endif
#else
        let v19 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v19 
        #endif
        let v20 : num_complex_Complex<float> option = _run_target_args'_v10 
        let v85 : (num_complex_Complex<float> -> US0) = method17()
        let v86 : US0 option = v20 |> Option.map v85 
        let v147 : US0 = US0_1
        let v148 : US0 = v86 |> Option.defaultValue v147 
        let v161 : string = "f64::NAN"
        let v162 : float = Fable.Core.RustInterop.emitRustExpr () v161 
        let v163 : string = "f64::NAN"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = "num_complex::Complex::new($0, $1)"
        let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v162, v164) v165 
        let v169 : num_complex_Complex<float> =
            match v148 with
            | US0_1 -> (* None *)
                v166
            | US0_0(v167) -> (* Some *)
                v167
        let v170 : string = "$0.re"
        let v171 : float = Fable.Core.RustInterop.emitRustExpr v169 v170 
        let v174 : bool = v171 <> 0.0 
        let v187 : bool =
            if v174 then
                true
            else
                method18(v174)
        let v192 : string =
            if v174 then
                let v188 : float = 0.0
                method19(v188)
            else
                let v190 : float = 0.0
                method26(v171, v190)
        let v199 : string = "__assert_ne"
        let v200 : string = " "
        let v201 : string = v199 + v200 
        let v217 : string =
            if v174 then
                let v213 : float = 0.0
                method19(v213)
            else
                let v215 : float = 0.0
                method26(v171, v215)
        let v220 : string = v201 + v217 
        let v262 : unit = ()
        let v263 : (unit -> unit) = closure2(v220)
        let v264 : unit = (fun () -> v263 (); v262) ()
        let v276 : bool = v187 = false
        if v276 then
            failwith<unit> v220
        let v277 : string = "$0.im"
        let v278 : float = Fable.Core.RustInterop.emitRustExpr v169 v277 
        let v281 : bool = v278 <> 0.0 
        let v294 : bool =
            if v281 then
                true
            else
                method18(v281)
        let v299 : string =
            if v281 then
                let v295 : float = 0.0
                method19(v295)
            else
                let v297 : float = 0.0
                method26(v278, v297)
        let v302 : string = v199 + v200 
        let v318 : string =
            if v281 then
                let v314 : float = 0.0
                method19(v314)
            else
                let v316 : float = 0.0
                method26(v278, v316)
        let v321 : string = v302 + v318 
        let v363 : unit = ()
        let v364 : (unit -> unit) = closure2(v321)
        let v365 : unit = (fun () -> v364 (); v363) ()
        let v377 : bool = v294 = false
        if v377 then
            failwith<unit> v321
        method53(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method51 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method52()
    method53(v0, v1)
and method50 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method51(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method56 () : UH1 =
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
and method57 (v0 : pyo3_Python, v1 : UH1) : unit =
    match v1 with
    | UH1_1(v2, v3) -> (* Cons *)
        let v4 : string = $"        s = mpmath.zeta(s)"
        let v5 : num_complex_Complex<float> = method3(v2)
        let v6 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v4, v5)
        let v7 : num_complex_Complex<float> = method13(v0, v2)
        (* run_target_args'
        let v10 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v11 : string = "$0.ok()"
        let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v11 
        let _run_target_args'_v10 = v12 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v13 : string = "$0.ok()"
        let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v13 
        let _run_target_args'_v10 = v14 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v15 
        let _run_target_args'_v10 = v16 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v17 
        #endif
#if FABLE_COMPILER_PYTHON
        let v18 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v18 
        #endif
#else
        let v19 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v19 
        #endif
        let v20 : num_complex_Complex<float> option = _run_target_args'_v10 
        let v85 : (num_complex_Complex<float> -> US0) = method17()
        let v86 : US0 option = v20 |> Option.map v85 
        let v147 : US0 = US0_1
        let v148 : US0 = v86 |> Option.defaultValue v147 
        let v161 : string = "f64::NAN"
        let v162 : float = Fable.Core.RustInterop.emitRustExpr () v161 
        let v163 : string = "f64::NAN"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr () v163 
        let v165 : string = "num_complex::Complex::new($0, $1)"
        let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v162, v164) v165 
        let v169 : num_complex_Complex<float> =
            match v148 with
            | US0_1 -> (* None *)
                v166
            | US0_0(v167) -> (* Some *)
                v167
        let v170 : string = "num_complex::Complex::new($0, $1)"
        let v171 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v170 
        let v172 : string = "num_complex::Complex::powc($0, $1)"
        let v173 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v171, v2) v172 
        let v174 : string = "num_complex::Complex::new($0, $1)"
        let v175 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v174 
        let v176 : string = "num_complex::Complex::new($0, $1)"
        let v177 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v176 
        let v178 : string = "$0 - $1"
        let v179 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v177) v178 
        let v180 : string = "num_complex::Complex::powc($0, $1)"
        let v181 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v175, v179) v180 
        let v182 : string = "$0 * $1"
        let v183 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v173, v181) v182 
        let v184 : string = "num_complex::Complex::new($0, $1)"
        let v185 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v184 
        let v186 : string = "$0 * $1"
        let v187 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v185, v2) v186 
        let v188 : string = "num_complex::Complex::new($0, $1)"
        let v189 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v188 
        let v190 : string = "$0 / $1"
        let v191 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v187, v189) v190 
        let v192 : string = "$0.sin()"
        let v193 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v191 v192 
        let v194 : string = "$0 * $1"
        let v195 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v183, v193) v194 
        let v196 : string = "num_complex::Complex::new($0, $1)"
        let v197 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v196 
        let v198 : string = "$0 - $1"
        let v199 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v197, v2) v198 
        let v200 : string = $"        s = mpmath.gamma(s)"
        let v201 : num_complex_Complex<float> = method3(v199)
        let v202 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v200, v201)
        (* run_target_args'
        let v205 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v206 : string = "$0.ok()"
        let v207 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v202 v206 
        let _run_target_args'_v205 = v207 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v208 : string = "$0.ok()"
        let v209 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v202 v208 
        let _run_target_args'_v205 = v209 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v210 : string = "$0.ok()"
        let v211 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v202 v210 
        let _run_target_args'_v205 = v211 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v212 : num_complex_Complex<float> option = match v202 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v205 = v212 
        #endif
#if FABLE_COMPILER_PYTHON
        let v213 : num_complex_Complex<float> option = match v202 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v205 = v213 
        #endif
#else
        let v214 : num_complex_Complex<float> option = match v202 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v205 = v214 
        #endif
        let v215 : num_complex_Complex<float> option = _run_target_args'_v205 
        let v280 : (num_complex_Complex<float> -> US0) = method17()
        let v281 : US0 option = v215 |> Option.map v280 
        let v342 : US0 = US0_1
        let v343 : US0 = v281 |> Option.defaultValue v342 
        let v356 : string = "f64::NAN"
        let v357 : float = Fable.Core.RustInterop.emitRustExpr () v356 
        let v358 : string = "f64::NAN"
        let v359 : float = Fable.Core.RustInterop.emitRustExpr () v358 
        let v360 : string = "num_complex::Complex::new($0, $1)"
        let v361 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v357, v359) v360 
        let v364 : num_complex_Complex<float> =
            match v343 with
            | US0_1 -> (* None *)
                v361
            | US0_0(v362) -> (* Some *)
                v362
        let v365 : string = "$0 * $1"
        let v366 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v195, v364) v365 
        let v367 : string = "$0.re"
        let v368 : float = Fable.Core.RustInterop.emitRustExpr v2 v367 
        let v369 : float = 1.0 - v368
        let v370 : string = "$0.im"
        let v371 : float = Fable.Core.RustInterop.emitRustExpr v2 v370 
        let v372 : float =  -v371
        let v373 : string = "num_complex::Complex::new($0, $1)"
        let v374 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v369, v372) v373 
        let v375 : string = $"        s = mpmath.zeta(s)"
        let v376 : num_complex_Complex<float> = method3(v374)
        let v377 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v375, v376)
        let v378 : num_complex_Complex<float> = method13(v0, v374)
        (* run_target_args'
        let v381 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v382 : string = "$0.ok()"
        let v383 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v377 v382 
        let _run_target_args'_v381 = v383 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v384 : string = "$0.ok()"
        let v385 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v377 v384 
        let _run_target_args'_v381 = v385 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v386 : string = "$0.ok()"
        let v387 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v377 v386 
        let _run_target_args'_v381 = v387 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v388 : num_complex_Complex<float> option = match v377 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v381 = v388 
        #endif
#if FABLE_COMPILER_PYTHON
        let v389 : num_complex_Complex<float> option = match v377 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v381 = v389 
        #endif
#else
        let v390 : num_complex_Complex<float> option = match v377 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v381 = v390 
        #endif
        let v391 : num_complex_Complex<float> option = _run_target_args'_v381 
        let v456 : (num_complex_Complex<float> -> US0) = method17()
        let v457 : US0 option = v391 |> Option.map v456 
        let v518 : US0 = US0_1
        let v519 : US0 = v457 |> Option.defaultValue v518 
        let v532 : string = "f64::NAN"
        let v533 : float = Fable.Core.RustInterop.emitRustExpr () v532 
        let v534 : string = "f64::NAN"
        let v535 : float = Fable.Core.RustInterop.emitRustExpr () v534 
        let v536 : string = "num_complex::Complex::new($0, $1)"
        let v537 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v533, v535) v536 
        let v540 : num_complex_Complex<float> =
            match v519 with
            | US0_1 -> (* None *)
                v537
            | US0_0(v538) -> (* Some *)
                v538
        let v541 : string = "$0 * $1"
        let v542 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v366, v540) v541 
        let v543 : string = "$0.re"
        let v544 : float = Fable.Core.RustInterop.emitRustExpr v169 v543 
        let v545 : string = "$0.re"
        let v546 : float = Fable.Core.RustInterop.emitRustExpr v542 v545 
        let v547 : float = v544 - v546
        let v548 : float =  -v547
        let v549 : bool = v547 >= v548
        let v550 : float =
            if v549 then
                v547
            else
                v548
        let v551 : bool = v550 < 0.0001
        let v553 : bool =
            if v551 then
                true
            else
                method18(v551)
        let v558 : string =
            if v551 then
                let v554 : float = 0.0001
                method19(v554)
            else
                let v556 : float = 0.0001
                method26(v550, v556)
        let v565 : string = "__assert_lt"
        let v566 : string = " "
        let v567 : string = v565 + v566 
        let v583 : string =
            if v551 then
                let v579 : float = 0.0001
                method19(v579)
            else
                let v581 : float = 0.0001
                method26(v550, v581)
        let v586 : string = v567 + v583 
        let v628 : unit = ()
        let v629 : (unit -> unit) = closure2(v586)
        let v630 : unit = (fun () -> v629 (); v628) ()
        let v642 : bool = v553 = false
        if v642 then
            failwith<unit> v586
        let v643 : string = "$0.im"
        let v644 : float = Fable.Core.RustInterop.emitRustExpr v169 v643 
        let v645 : string = "$0.im"
        let v646 : float = Fable.Core.RustInterop.emitRustExpr v542 v645 
        let v647 : float = v644 - v646
        let v648 : float =  -v647
        let v649 : bool = v647 >= v648
        let v650 : float =
            if v649 then
                v647
            else
                v648
        let v651 : bool = v650 < 0.0001
        let v653 : bool =
            if v651 then
                true
            else
                method18(v651)
        let v658 : string =
            if v651 then
                let v654 : float = 0.0001
                method19(v654)
            else
                let v656 : float = 0.0001
                method26(v650, v656)
        let v661 : string = v565 + v566 
        let v677 : string =
            if v651 then
                let v673 : float = 0.0001
                method19(v673)
            else
                let v675 : float = 0.0001
                method26(v650, v675)
        let v680 : string = v661 + v677 
        let v722 : unit = ()
        let v723 : (unit -> unit) = closure2(v680)
        let v724 : unit = (fun () -> v723 (); v722) ()
        let v736 : bool = v653 = false
        if v736 then
            failwith<unit> v680
        method57(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method55 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method56()
    method57(v0, v1)
and method54 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method55(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
    ()
and method60 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(5.0, v0)
    let v2 : UH0 = UH0_1(4.5, v1)
    let v3 : UH0 = UH0_1(4.0, v2)
    let v4 : UH0 = UH0_1(3.5, v3)
    let v5 : UH0 = UH0_1(3.0, v4)
    let v6 : UH0 = UH0_1(2.5, v5)
    UH0_1(2.0, v6)
and method61 () : UH0 =
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
and method63 (v0 : float, v1 : UH0, v2 : float) : float =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : float =  -v0
        let v6 : float = v3 ** v5
        let v7 : float = 1.0 - v6
        let v8 : float = v2 / v7
        method63(v0, v4, v8)
    | UH0_0 -> (* Nil *)
        v2
and method62 (v0 : pyo3_Python, v1 : UH0, v2 : UH0) : unit =
    match v2 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : string = "num_complex::Complex::new($0, $1)"
        let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3, 0.0) v5 
        let v7 : float = 1.0
        let v8 : float = method63(v3, v1, v7)
        let v9 : string = $"        s = mpmath.zeta(s)"
        let v10 : num_complex_Complex<float> = method3(v6)
        let v11 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v9, v10)
        let v12 : num_complex_Complex<float> = method13(v0, v6)
        (* run_target_args'
        let v15 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v16 
        let _run_target_args'_v15 = v17 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v18 : string = "$0.ok()"
        let v19 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v18 
        let _run_target_args'_v15 = v19 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v20 : string = "$0.ok()"
        let v21 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v20 
        let _run_target_args'_v15 = v21 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v22 
        #endif
#if FABLE_COMPILER_PYTHON
        let v23 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v23 
        #endif
#else
        let v24 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v24 
        #endif
        let v25 : num_complex_Complex<float> option = _run_target_args'_v15 
        let v90 : (num_complex_Complex<float> -> US0) = method17()
        let v91 : US0 option = v25 |> Option.map v90 
        let v152 : US0 = US0_1
        let v153 : US0 = v91 |> Option.defaultValue v152 
        let v166 : string = "f64::NAN"
        let v167 : float = Fable.Core.RustInterop.emitRustExpr () v166 
        let v168 : string = "f64::NAN"
        let v169 : float = Fable.Core.RustInterop.emitRustExpr () v168 
        let v170 : string = "num_complex::Complex::new($0, $1)"
        let v171 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v167, v169) v170 
        let v174 : num_complex_Complex<float> =
            match v153 with
            | US0_1 -> (* None *)
                v171
            | US0_0(v172) -> (* Some *)
                v172
        let v175 : string = "$0.re"
        let v176 : float = Fable.Core.RustInterop.emitRustExpr v174 v175 
        let v177 : float = v176 - v8
        let v178 : float =  -v177
        let v179 : bool = v177 >= v178
        let v180 : float =
            if v179 then
                v177
            else
                v178
        let v181 : bool = v180 < 0.01
        let v183 : bool =
            if v181 then
                true
            else
                method18(v181)
        let v188 : string =
            if v181 then
                let v184 : float = 0.01
                method19(v184)
            else
                let v186 : float = 0.01
                method26(v180, v186)
        let v195 : string = "__assert_lt"
        let v196 : string = " "
        let v197 : string = v195 + v196 
        let v213 : string =
            if v181 then
                let v209 : float = 0.01
                method19(v209)
            else
                let v211 : float = 0.01
                method26(v180, v211)
        let v216 : string = v197 + v213 
        let v258 : unit = ()
        let v259 : (unit -> unit) = closure2(v216)
        let v260 : unit = (fun () -> v259 (); v258) ()
        let v272 : bool = v183 = false
        if v272 then
            failwith<unit> v216
        let v273 : string = "$0.im"
        let v274 : float = Fable.Core.RustInterop.emitRustExpr v174 v273 
        let v275 : bool = v274 < 0.01
        let v277 : bool =
            if v275 then
                true
            else
                method18(v275)
        let v282 : string =
            if v275 then
                let v278 : float = 0.01
                method19(v278)
            else
                let v280 : float = 0.01
                method26(v274, v280)
        let v285 : string = v195 + v196 
        let v301 : string =
            if v275 then
                let v297 : float = 0.01
                method19(v297)
            else
                let v299 : float = 0.01
                method26(v274, v299)
        let v304 : string = v285 + v301 
        let v346 : unit = ()
        let v347 : (unit -> unit) = closure2(v304)
        let v348 : unit = (fun () -> v347 (); v346) ()
        let v360 : bool = v277 = false
        if v360 then
            failwith<unit> v304
        method62(v0, v1, v4)
    | UH0_0 -> (* Nil *)
        ()
and method59 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method60()
    let v2 : UH0 = method61()
    method62(v0, v2, v1)
and method58 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method59(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v18 : Result<unit, pyo3_PyErr> = method29(v6)
    let v19 : string = ""
    let v20 : string = "}"
    let v21 : string = v19 + v20 
    let v22 : string = v21 + v20 
    let v23 : string = "{"
    let v24 : string = v19 + v23 
    let x = v18 //
    let v25 : _ = x
    let v26 : unit = ()
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = $"true; let _fix_closure_v26 = $0"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr v25 v28 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v30 : string = $"true; let _fix_closure_v26 = $0"
    let v31 : bool = Fable.Core.RustInterop.emitRustExpr v25 v30 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v32 : string = $"true; let _fix_closure_v26 = $0"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr v25 v32 
    let _run_target_args'_v27 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v27 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v27 = false 
    #endif
#else
    let _run_target_args'_v27 = false 
    #endif
    let v34 : bool = _run_target_args'_v27 
    let v35 : string = $"true; _fix_closure_v26 " + v22 + "); " + v24 + " // rust.fix_closure'"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "__run_test"
    let v38 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v37 
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v38 v39 
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
    method30()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    method32()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16 
    method36()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    method38()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    method40()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28 
    method42()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    method44()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    method46()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
    method50()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
    method54()
    let v46 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "test_euler_product_formula"
    let v48 : string = $"*/ #[test] fn " + v47 + "() { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    method58()
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
and closure3 () (v0 : (string [])) : int32 =
    let v1 : string = $"value: {1}"
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure2(v1)
    let v34 : unit = (fun () -> v33 (); v32) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure3()
let main args = v1 args
()
