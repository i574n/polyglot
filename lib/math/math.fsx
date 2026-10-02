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
        let v27 : string = v14 + v9 
        let v38 : int32 = v5 + 1
        let v39 : string = "\n"
        v3.l0 <- v38
        v3.l1 <- v27
        v3.l2 <- v39
        ()
    let struct (v40 : string, v41 : string) = v3.l1, v3.l2
    v40
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
    let v56 : (bool * (float * float)) = false, v43 
    let v67 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v242 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v243 : string = "&*$0"
    let v244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v243 
    let _run_target_args'_v242 = v244 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v245 : string = "&*$0"
    let v246 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v245 
    let _run_target_args'_v242 = v246 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v247 : string = "&*$0"
    let v248 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v247 
    let _run_target_args'_v242 = v248 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v325 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v242 = v325 
    #endif
#if FABLE_COMPILER_PYTHON
    let v412 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v242 = v412 
    #endif
#else
    let v499 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v242 = v499 
    #endif
    let v510 : Ref<Str> = _run_target_args'_v242 
    (* run_target_args'
    let v859 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v860 : string = "String::from($0)"
    let v861 : std_string_String = Fable.Core.RustInterop.emitRustExpr v510 v860 
    let _run_target_args'_v859 = v861 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v862 : string = "String::from($0)"
    let v863 : std_string_String = Fable.Core.RustInterop.emitRustExpr v510 v862 
    let _run_target_args'_v859 = v863 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v864 : string = "String::from($0)"
    let v865 : std_string_String = Fable.Core.RustInterop.emitRustExpr v510 v864 
    let _run_target_args'_v859 = v865 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v942 : std_string_String = v510 |> unbox<std_string_String>
    let _run_target_args'_v859 = v942 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1029 : std_string_String = v510 |> unbox<std_string_String>
    let _run_target_args'_v859 = v1029 
    #endif
#else
    let v1116 : std_string_String = v510 |> unbox<std_string_String>
    let _run_target_args'_v859 = v1116 
    #endif
    let v1127 : std_string_String = _run_target_args'_v859 
    let v1302 : string = "std::ffi::CString::new($0).unwrap()"
    let v1303 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v1127 v1302 
    let v1304 : string = ""
    (* run_target_args'
    let v1479 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1480 : string = "&*$0"
    let v1481 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1304 v1480 
    let _run_target_args'_v1479 = v1481 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1482 : string = "&*$0"
    let v1483 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1304 v1482 
    let _run_target_args'_v1479 = v1483 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1484 : string = "&*$0"
    let v1485 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1304 v1484 
    let _run_target_args'_v1479 = v1485 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1562 : Ref<Str> = v1304 |> unbox<Ref<Str>>
    let _run_target_args'_v1479 = v1562 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1649 : Ref<Str> = v1304 |> unbox<Ref<Str>>
    let _run_target_args'_v1479 = v1649 
    #endif
#else
    let v1736 : Ref<Str> = v1304 |> unbox<Ref<Str>>
    let _run_target_args'_v1479 = v1736 
    #endif
    let v1747 : Ref<Str> = _run_target_args'_v1479 
    (* run_target_args'
    let v2096 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2097 : string = "String::from($0)"
    let v2098 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1747 v2097 
    let _run_target_args'_v2096 = v2098 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2099 : string = "String::from($0)"
    let v2100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1747 v2099 
    let _run_target_args'_v2096 = v2100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2101 : string = "String::from($0)"
    let v2102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1747 v2101 
    let _run_target_args'_v2096 = v2102 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2179 : std_string_String = v1747 |> unbox<std_string_String>
    let _run_target_args'_v2096 = v2179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2266 : std_string_String = v1747 |> unbox<std_string_String>
    let _run_target_args'_v2096 = v2266 
    #endif
#else
    let v2353 : std_string_String = v1747 |> unbox<std_string_String>
    let _run_target_args'_v2096 = v2353 
    #endif
    let v2364 : std_string_String = _run_target_args'_v2096 
    let v2539 : string = "std::ffi::CString::new($0).unwrap()"
    let v2540 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v2364 v2539 
    let v2541 : string = "pyo3::types::PyModule::from_code(v67, &$0, &v2540, &v2540)"
    let v2542 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v1303 v2541 
    let v2543 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v2544 : bool = Fable.Core.RustInterop.emitRustExpr v2542 v2543 
    let v2545 : string = "x"
    let v2546 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v2545 
    (* run_target_args'
    let v2573 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2574 : string = "format!(\"{}\", $0)"
    let v2575 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2546 v2574 
    let _run_target_args'_v2573 = v2575 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2576 : string = "format!(\"{}\", $0)"
    let v2577 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2546 v2576 
    let _run_target_args'_v2573 = v2577 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2578 : string = "format!(\"{}\", $0)"
    let v2579 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2546 v2578 
    let _run_target_args'_v2573 = v2579 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2582 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2573 = v2582 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2595 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2573 = v2595 
    #endif
#else
    let v2608 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2573 = v2608 
    #endif
    let v2619 : std_string_String = _run_target_args'_v2573 
    let v2646 : string = "true; $0 })"
    let v2647 : bool = Fable.Core.RustInterop.emitRustExpr v2619 v2646 
    let v2648 : string = "_result_map_error__"
    let v2649 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2648 
    let v2650 : string = "$0.unwrap()"
    let v2651 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v2649 v2650 
    let v2652 : string = method8()
    (* run_target_args'
    let v2827 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2828 : string = "&*$0"
    let v2829 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2652 v2828 
    let _run_target_args'_v2827 = v2829 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2830 : string = "&*$0"
    let v2831 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2652 v2830 
    let _run_target_args'_v2827 = v2831 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2832 : string = "&*$0"
    let v2833 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2652 v2832 
    let _run_target_args'_v2827 = v2833 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2910 : Ref<Str> = v2652 |> unbox<Ref<Str>>
    let _run_target_args'_v2827 = v2910 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2997 : Ref<Str> = v2652 |> unbox<Ref<Str>>
    let _run_target_args'_v2827 = v2997 
    #endif
#else
    let v3084 : Ref<Str> = v2652 |> unbox<Ref<Str>>
    let _run_target_args'_v2827 = v3084 
    #endif
    let v3095 : Ref<Str> = _run_target_args'_v2827 
    let v3270 : pyo3_Bound<pyo3_types_PyModule> = method9(v2651)
    let v3271 : string = "v3270.getattr($0)"
    let v3272 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v3095 v3271 
    let v3273 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3274 : bool = Fable.Core.RustInterop.emitRustExpr v3272 v3273 
    let v3275 : string = "x"
    let v3276 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3275 
    (* run_target_args'
    let v3303 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3304 : string = "format!(\"{}\", $0)"
    let v3305 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3276 v3304 
    let _run_target_args'_v3303 = v3305 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3306 : string = "format!(\"{}\", $0)"
    let v3307 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3276 v3306 
    let _run_target_args'_v3303 = v3307 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3308 : string = "format!(\"{}\", $0)"
    let v3309 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3276 v3308 
    let _run_target_args'_v3303 = v3309 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3312 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3303 = v3312 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3325 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3303 = v3325 
    #endif
#else
    let v3338 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3303 = v3338 
    #endif
    let v3349 : std_string_String = _run_target_args'_v3303 
    let v3376 : string = "true; $0 })"
    let v3377 : bool = Fable.Core.RustInterop.emitRustExpr v3349 v3376 
    let v3378 : string = "_result_map_error__"
    let v3379 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3378 
    let v3380 : string = "$0.unwrap()"
    let v3381 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3379 v3380 
    let v3382 : (bool * (float * float)) = method10(v56)
    let v3383 : pyo3_Bound<pyo3_PyAny> = method11(v3381)
    let v3384 : string = "pyo3::prelude::PyAnyMethods::call(&v3383, ((*v3382).0, *(*v3382).1), None)"
    let v3385 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3384 
    let v3386 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3387 : bool = Fable.Core.RustInterop.emitRustExpr v3385 v3386 
    let v3388 : string = "x"
    let v3389 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3388 
    (* run_target_args'
    let v3416 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3417 : string = "format!(\"{}\", $0)"
    let v3418 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3389 v3417 
    let _run_target_args'_v3416 = v3418 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3419 : string = "format!(\"{}\", $0)"
    let v3420 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3389 v3419 
    let _run_target_args'_v3416 = v3420 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3421 : string = "format!(\"{}\", $0)"
    let v3422 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3389 v3421 
    let _run_target_args'_v3416 = v3422 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3425 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3416 = v3425 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3438 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3416 = v3438 
    #endif
#else
    let v3451 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3416 = v3451 
    #endif
    let v3462 : std_string_String = _run_target_args'_v3416 
    let v3489 : string = "true; $0 })"
    let v3490 : bool = Fable.Core.RustInterop.emitRustExpr v3462 v3489 
    let v3491 : string = "_result_map_error__"
    let v3492 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3491 
    let v3493 : string = "$0?"
    let v3494 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3492 v3493 
    let v3495 : pyo3_Bound<pyo3_PyAny> = method12(v3494)
    let v3496 : string = "v3495.extract()"
    let v3497 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3496 
    let v3498 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3499 : bool = Fable.Core.RustInterop.emitRustExpr v3497 v3498 
    let v3500 : string = "x"
    let v3501 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3500 
    (* run_target_args'
    let v3528 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3529 : string = "format!(\"{}\", $0)"
    let v3530 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3501 v3529 
    let _run_target_args'_v3528 = v3530 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3531 : string = "format!(\"{}\", $0)"
    let v3532 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3501 v3531 
    let _run_target_args'_v3528 = v3532 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3533 : string = "format!(\"{}\", $0)"
    let v3534 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3501 v3533 
    let _run_target_args'_v3528 = v3534 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3537 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3528 = v3537 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3550 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3528 = v3550 
    #endif
#else
    let v3563 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3528 = v3563 
    #endif
    let v3574 : std_string_String = _run_target_args'_v3528 
    let v3601 : string = "true; $0 })"
    let v3602 : bool = Fable.Core.RustInterop.emitRustExpr v3574 v3601 
    let v3603 : string = "_result_map_error__"
    let v3604 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3603 
    let v3605 : string = "$0?"
    let struct (v3606 : float, v3607 : float) = Fable.Core.RustInterop.emitRustExpr v3604 v3605 
    let v3608 : string = "num_complex::Complex::new($0, $1)"
    let v3609 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3606, v3607) v3608 
    let v3612 : Result<num_complex_Complex<float>, std_string_String> = Ok v3609 
    v3612
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
    let v56 : (bool * (float * float)) = false, v43 
    let v67 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v242 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v243 : string = "&*$0"
    let v244 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v243 
    let _run_target_args'_v242 = v244 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v245 : string = "&*$0"
    let v246 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v245 
    let _run_target_args'_v242 = v246 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v247 : string = "&*$0"
    let v248 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v247 
    let _run_target_args'_v242 = v248 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v325 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v242 = v325 
    #endif
#if FABLE_COMPILER_PYTHON
    let v412 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v242 = v412 
    #endif
#else
    let v499 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v242 = v499 
    #endif
    let v510 : Ref<Str> = _run_target_args'_v242 
    (* run_target_args'
    let v859 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v860 : string = "String::from($0)"
    let v861 : std_string_String = Fable.Core.RustInterop.emitRustExpr v510 v860 
    let _run_target_args'_v859 = v861 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v862 : string = "String::from($0)"
    let v863 : std_string_String = Fable.Core.RustInterop.emitRustExpr v510 v862 
    let _run_target_args'_v859 = v863 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v864 : string = "String::from($0)"
    let v865 : std_string_String = Fable.Core.RustInterop.emitRustExpr v510 v864 
    let _run_target_args'_v859 = v865 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v942 : std_string_String = v510 |> unbox<std_string_String>
    let _run_target_args'_v859 = v942 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1029 : std_string_String = v510 |> unbox<std_string_String>
    let _run_target_args'_v859 = v1029 
    #endif
#else
    let v1116 : std_string_String = v510 |> unbox<std_string_String>
    let _run_target_args'_v859 = v1116 
    #endif
    let v1127 : std_string_String = _run_target_args'_v859 
    let v1302 : string = "std::ffi::CString::new($0).unwrap()"
    let v1303 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v1127 v1302 
    let v1304 : string = ""
    (* run_target_args'
    let v1479 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1480 : string = "&*$0"
    let v1481 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1304 v1480 
    let _run_target_args'_v1479 = v1481 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1482 : string = "&*$0"
    let v1483 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1304 v1482 
    let _run_target_args'_v1479 = v1483 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1484 : string = "&*$0"
    let v1485 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v1304 v1484 
    let _run_target_args'_v1479 = v1485 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1562 : Ref<Str> = v1304 |> unbox<Ref<Str>>
    let _run_target_args'_v1479 = v1562 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1649 : Ref<Str> = v1304 |> unbox<Ref<Str>>
    let _run_target_args'_v1479 = v1649 
    #endif
#else
    let v1736 : Ref<Str> = v1304 |> unbox<Ref<Str>>
    let _run_target_args'_v1479 = v1736 
    #endif
    let v1747 : Ref<Str> = _run_target_args'_v1479 
    (* run_target_args'
    let v2096 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2097 : string = "String::from($0)"
    let v2098 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1747 v2097 
    let _run_target_args'_v2096 = v2098 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2099 : string = "String::from($0)"
    let v2100 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1747 v2099 
    let _run_target_args'_v2096 = v2100 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2101 : string = "String::from($0)"
    let v2102 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1747 v2101 
    let _run_target_args'_v2096 = v2102 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2179 : std_string_String = v1747 |> unbox<std_string_String>
    let _run_target_args'_v2096 = v2179 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2266 : std_string_String = v1747 |> unbox<std_string_String>
    let _run_target_args'_v2096 = v2266 
    #endif
#else
    let v2353 : std_string_String = v1747 |> unbox<std_string_String>
    let _run_target_args'_v2096 = v2353 
    #endif
    let v2364 : std_string_String = _run_target_args'_v2096 
    let v2539 : string = "std::ffi::CString::new($0).unwrap()"
    let v2540 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v2364 v2539 
    let v2541 : string = "pyo3::types::PyModule::from_code(v67, &$0, &v2540, &v2540)"
    let v2542 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v1303 v2541 
    let v2543 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v2544 : bool = Fable.Core.RustInterop.emitRustExpr v2542 v2543 
    let v2545 : string = "x"
    let v2546 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v2545 
    (* run_target_args'
    let v2573 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2574 : string = "format!(\"{}\", $0)"
    let v2575 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2546 v2574 
    let _run_target_args'_v2573 = v2575 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2576 : string = "format!(\"{}\", $0)"
    let v2577 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2546 v2576 
    let _run_target_args'_v2573 = v2577 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2578 : string = "format!(\"{}\", $0)"
    let v2579 : std_string_String = Fable.Core.RustInterop.emitRustExpr v2546 v2578 
    let _run_target_args'_v2573 = v2579 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2582 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2573 = v2582 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2595 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2573 = v2595 
    #endif
#else
    let v2608 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v2573 = v2608 
    #endif
    let v2619 : std_string_String = _run_target_args'_v2573 
    let v2646 : string = "true; $0 })"
    let v2647 : bool = Fable.Core.RustInterop.emitRustExpr v2619 v2646 
    let v2648 : string = "_result_map_error__"
    let v2649 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v2648 
    let v2650 : string = "$0.unwrap()"
    let v2651 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v2649 v2650 
    let v2652 : string = method8()
    (* run_target_args'
    let v2827 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v2828 : string = "&*$0"
    let v2829 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2652 v2828 
    let _run_target_args'_v2827 = v2829 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v2830 : string = "&*$0"
    let v2831 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2652 v2830 
    let _run_target_args'_v2827 = v2831 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v2832 : string = "&*$0"
    let v2833 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v2652 v2832 
    let _run_target_args'_v2827 = v2833 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v2910 : Ref<Str> = v2652 |> unbox<Ref<Str>>
    let _run_target_args'_v2827 = v2910 
    #endif
#if FABLE_COMPILER_PYTHON
    let v2997 : Ref<Str> = v2652 |> unbox<Ref<Str>>
    let _run_target_args'_v2827 = v2997 
    #endif
#else
    let v3084 : Ref<Str> = v2652 |> unbox<Ref<Str>>
    let _run_target_args'_v2827 = v3084 
    #endif
    let v3095 : Ref<Str> = _run_target_args'_v2827 
    let v3270 : pyo3_Bound<pyo3_types_PyModule> = method9(v2651)
    let v3271 : string = "v3270.getattr($0)"
    let v3272 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v3095 v3271 
    let v3273 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3274 : bool = Fable.Core.RustInterop.emitRustExpr v3272 v3273 
    let v3275 : string = "x"
    let v3276 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3275 
    (* run_target_args'
    let v3303 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3304 : string = "format!(\"{}\", $0)"
    let v3305 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3276 v3304 
    let _run_target_args'_v3303 = v3305 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3306 : string = "format!(\"{}\", $0)"
    let v3307 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3276 v3306 
    let _run_target_args'_v3303 = v3307 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3308 : string = "format!(\"{}\", $0)"
    let v3309 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3276 v3308 
    let _run_target_args'_v3303 = v3309 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3312 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3303 = v3312 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3325 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3303 = v3325 
    #endif
#else
    let v3338 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3303 = v3338 
    #endif
    let v3349 : std_string_String = _run_target_args'_v3303 
    let v3376 : string = "true; $0 })"
    let v3377 : bool = Fable.Core.RustInterop.emitRustExpr v3349 v3376 
    let v3378 : string = "_result_map_error__"
    let v3379 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3378 
    let v3380 : string = "$0.unwrap()"
    let v3381 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3379 v3380 
    let v3382 : (bool * (float * float)) = method10(v56)
    let v3383 : pyo3_Bound<pyo3_PyAny> = method11(v3381)
    let v3384 : string = "pyo3::prelude::PyAnyMethods::call(&v3383, ((*v3382).0, *(*v3382).1), None)"
    let v3385 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3384 
    let v3386 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3387 : bool = Fable.Core.RustInterop.emitRustExpr v3385 v3386 
    let v3388 : string = "x"
    let v3389 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3388 
    (* run_target_args'
    let v3416 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3417 : string = "format!(\"{}\", $0)"
    let v3418 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3389 v3417 
    let _run_target_args'_v3416 = v3418 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3419 : string = "format!(\"{}\", $0)"
    let v3420 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3389 v3419 
    let _run_target_args'_v3416 = v3420 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3421 : string = "format!(\"{}\", $0)"
    let v3422 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3389 v3421 
    let _run_target_args'_v3416 = v3422 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3425 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3416 = v3425 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3438 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3416 = v3438 
    #endif
#else
    let v3451 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3416 = v3451 
    #endif
    let v3462 : std_string_String = _run_target_args'_v3416 
    let v3489 : string = "true; $0 })"
    let v3490 : bool = Fable.Core.RustInterop.emitRustExpr v3462 v3489 
    let v3491 : string = "_result_map_error__"
    let v3492 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3491 
    let v3493 : string = "$0?"
    let v3494 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v3492 v3493 
    let v3495 : pyo3_Bound<pyo3_PyAny> = method12(v3494)
    let v3496 : string = "v3495.extract()"
    let v3497 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v3496 
    let v3498 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v3499 : bool = Fable.Core.RustInterop.emitRustExpr v3497 v3498 
    let v3500 : string = "x"
    let v3501 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v3500 
    (* run_target_args'
    let v3528 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v3529 : string = "format!(\"{}\", $0)"
    let v3530 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3501 v3529 
    let _run_target_args'_v3528 = v3530 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v3531 : string = "format!(\"{}\", $0)"
    let v3532 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3501 v3531 
    let _run_target_args'_v3528 = v3532 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v3533 : string = "format!(\"{}\", $0)"
    let v3534 : std_string_String = Fable.Core.RustInterop.emitRustExpr v3501 v3533 
    let _run_target_args'_v3528 = v3534 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v3537 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3528 = v3537 
    #endif
#if FABLE_COMPILER_PYTHON
    let v3550 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3528 = v3550 
    #endif
#else
    let v3563 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v3528 = v3563 
    #endif
    let v3574 : std_string_String = _run_target_args'_v3528 
    let v3601 : string = "true; $0 })"
    let v3602 : bool = Fable.Core.RustInterop.emitRustExpr v3574 v3601 
    let v3603 : string = "_result_map_error__"
    let v3604 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v3603 
    let v3605 : string = "$0?"
    let struct (v3606 : float, v3607 : float) = Fable.Core.RustInterop.emitRustExpr v3604 v3605 
    let v3608 : string = "num_complex::Complex::new($0, $1)"
    let v3609 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3606, v3607) v3608 
    let v3612 : Result<num_complex_Complex<float>, std_string_String> = Ok v3609 
    v3612
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
            let v35 : string = "num_complex::Complex::new($0, $1)"
            let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v24, 0.0) v35 
            let v37 : string = "num_complex::Complex::powc($0, $1)"
            let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v36, v1) v37 
            let v39 : string = "$0 / $1"
            let v40 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v38) v39 
            let v41 : string = "$0 + $1"
            let v42 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v40) v41 
            let v43 : int32 = v16 + 1
            v14.l0 <- v43
            v14.l1 <- v42
            ()
        let v44 : num_complex_Complex<float> = v14.l1
        v44
    else
        let v45 : string = "num_complex::Complex::new($0, $1)"
        let v46 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v45 
        let v47 : string = "$0 - $1"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v46, v1) v47 
        let v49 : string = $"        s = mpmath.gamma(s)"
        let v50 : num_complex_Complex<float> = method3(v48)
        let v51 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v49, v50)
        (* run_target_args'
        let v54 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v55 : string = "$0.ok()"
        let v56 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v51 v55 
        let _run_target_args'_v54 = v56 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v57 : string = "$0.ok()"
        let v58 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v51 v57 
        let _run_target_args'_v54 = v58 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v59 : string = "$0.ok()"
        let v60 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v51 v59 
        let _run_target_args'_v54 = v60 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v61 : num_complex_Complex<float> option = match v51 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v54 = v61 
        #endif
#if FABLE_COMPILER_PYTHON
        let v62 : num_complex_Complex<float> option = match v51 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v54 = v62 
        #endif
#else
        let v63 : num_complex_Complex<float> option = match v51 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v54 = v63 
        #endif
        let v64 : num_complex_Complex<float> option = _run_target_args'_v54 
        let v125 : (num_complex_Complex<float> -> US0) = method17()
        let v126 : US0 option = v64 |> Option.map v125 
        let v183 : US0 = US0_1
        let v184 : US0 = v126 |> Option.defaultValue v183 
        let v196 : string = "f64::NAN"
        let v197 : float = Fable.Core.RustInterop.emitRustExpr () v196 
        let v198 : string = "f64::NAN"
        let v199 : float = Fable.Core.RustInterop.emitRustExpr () v198 
        let v200 : string = "num_complex::Complex::new($0, $1)"
        let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v197, v199) v200 
        let v204 : num_complex_Complex<float> =
            match v184 with
            | US0_1 -> (* None *)
                v201
            | US0_0(v202) -> (* Some *)
                v202
        let v205 : string = "num_complex::Complex::new($0, $1)"
        let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v205 
        let v207 : string = "$0 * $1"
        let v208 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v206, v1) v207 
        let v209 : string = "num_complex::Complex::new($0, $1)"
        let v210 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v209 
        let v211 : string = "$0 / $1"
        let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v208, v210) v211 
        let v213 : string = "$0.sin()"
        let v214 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v212 v213 
        let v215 : string = "$0.re"
        let v216 : float = Fable.Core.RustInterop.emitRustExpr v1 v215 
        let v217 : float = 1.0 - v216
        let v218 : string = "$0.im"
        let v219 : float = Fable.Core.RustInterop.emitRustExpr v1 v218 
        let v220 : float =  -v219
        let v221 : string = "num_complex::Complex::new($0, $1)"
        let v222 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v217, v220) v221 
        let v223 : string = "$0.re"
        let v224 : float = Fable.Core.RustInterop.emitRustExpr v222 v223 
        let v225 : bool = v224 <= 1.0
        let v1196 : num_complex_Complex<float> =
            if v225 then
                let v226 : string = "num_complex::Complex::new($0, $1)"
                let v227 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v226 
                v227
            else
                let v228 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v222) v228 
                let v229 : string = "$0.re"
                let v230 : float = Fable.Core.RustInterop.emitRustExpr v222 v229 
                let v231 : bool = v230 > 1.0
                if v231 then
                    let v232 : string = "num_complex::Complex::new($0, $1)"
                    let v233 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v232 
                    let v234 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v235 : Mut0 = {l0 = 0} : Mut0
                    while method14(v235) do
                        let v237 : int32 = v235.l0
                        v234.[int v237] <- v237
                        let v238 : int32 = v237 + 1
                        v235.l0 <- v238
                        ()
                    let v239 : int32 = v234.Length
                    let v240 : Mut2 = {l0 = 0; l1 = v233} : Mut2
                    while method15(v239, v240) do
                        let v242 : int32 = v240.l0
                        let v243 : num_complex_Complex<float> = v240.l1
                        let v244 : int32 = v234.[int v242]
                        let v245 : string = "num_complex::Complex::new($0, $1)"
                        let v246 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v245 
                        let v249 : (int32 -> float) = float
                        let v250 : float = v249 v244
                        let v261 : string = "num_complex::Complex::new($0, $1)"
                        let v262 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v250, 0.0) v261 
                        let v263 : string = "num_complex::Complex::powc($0, $1)"
                        let v264 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v262, v222) v263 
                        let v265 : string = "$0 / $1"
                        let v266 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v246, v264) v265 
                        let v267 : string = "$0 + $1"
                        let v268 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v243, v266) v267 
                        let v269 : int32 = v242 + 1
                        v240.l0 <- v269
                        v240.l1 <- v268
                        ()
                    let v270 : num_complex_Complex<float> = v240.l1
                    v270
                else
                    let v271 : string = "num_complex::Complex::new($0, $1)"
                    let v272 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v271 
                    let v273 : string = "$0 - $1"
                    let v274 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v272, v222) v273 
                    let v275 : string = $"        s = mpmath.gamma(s)"
                    let v276 : num_complex_Complex<float> = method3(v274)
                    let v277 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v275, v276)
                    (* run_target_args'
                    let v280 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v281 : string = "$0.ok()"
                    let v282 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v277 v281 
                    let _run_target_args'_v280 = v282 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v283 : string = "$0.ok()"
                    let v284 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v277 v283 
                    let _run_target_args'_v280 = v284 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v285 : string = "$0.ok()"
                    let v286 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v277 v285 
                    let _run_target_args'_v280 = v286 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v287 : num_complex_Complex<float> option = match v277 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v280 = v287 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v288 : num_complex_Complex<float> option = match v277 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v280 = v288 
                    #endif
#else
                    let v289 : num_complex_Complex<float> option = match v277 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v280 = v289 
                    #endif
                    let v290 : num_complex_Complex<float> option = _run_target_args'_v280 
                    let v351 : (num_complex_Complex<float> -> US0) = method17()
                    let v352 : US0 option = v290 |> Option.map v351 
                    let v409 : US0 = US0_1
                    let v410 : US0 = v352 |> Option.defaultValue v409 
                    let v422 : string = "f64::NAN"
                    let v423 : float = Fable.Core.RustInterop.emitRustExpr () v422 
                    let v424 : string = "f64::NAN"
                    let v425 : float = Fable.Core.RustInterop.emitRustExpr () v424 
                    let v426 : string = "num_complex::Complex::new($0, $1)"
                    let v427 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v423, v425) v426 
                    let v430 : num_complex_Complex<float> =
                        match v410 with
                        | US0_1 -> (* None *)
                            v427
                        | US0_0(v428) -> (* Some *)
                            v428
                    let v431 : string = "num_complex::Complex::new($0, $1)"
                    let v432 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v431 
                    let v433 : string = "$0 * $1"
                    let v434 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v432, v222) v433 
                    let v435 : string = "num_complex::Complex::new($0, $1)"
                    let v436 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v435 
                    let v437 : string = "$0 / $1"
                    let v438 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v434, v436) v437 
                    let v439 : string = "$0.sin()"
                    let v440 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v438 v439 
                    let v441 : string = "$0.re"
                    let v442 : float = Fable.Core.RustInterop.emitRustExpr v222 v441 
                    let v443 : float = 1.0 - v442
                    let v444 : string = "$0.im"
                    let v445 : float = Fable.Core.RustInterop.emitRustExpr v222 v444 
                    let v446 : float =  -v445
                    let v447 : string = "num_complex::Complex::new($0, $1)"
                    let v448 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v443, v446) v447 
                    let v449 : string = "$0.re"
                    let v450 : float = Fable.Core.RustInterop.emitRustExpr v448 v449 
                    let v451 : bool = v450 <= 1.0
                    let v1180 : num_complex_Complex<float> =
                        if v451 then
                            let v452 : string = "num_complex::Complex::new($0, $1)"
                            let v453 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v452 
                            v453
                        else
                            let v454 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v448) v454 
                            let v455 : string = "$0.re"
                            let v456 : float = Fable.Core.RustInterop.emitRustExpr v448 v455 
                            let v457 : bool = v456 > 1.0
                            if v457 then
                                let v458 : string = "num_complex::Complex::new($0, $1)"
                                let v459 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v458 
                                let v460 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v461 : Mut0 = {l0 = 0} : Mut0
                                while method14(v461) do
                                    let v463 : int32 = v461.l0
                                    v460.[int v463] <- v463
                                    let v464 : int32 = v463 + 1
                                    v461.l0 <- v464
                                    ()
                                let v465 : int32 = v460.Length
                                let v466 : Mut2 = {l0 = 0; l1 = v459} : Mut2
                                while method15(v465, v466) do
                                    let v468 : int32 = v466.l0
                                    let v469 : num_complex_Complex<float> = v466.l1
                                    let v470 : int32 = v460.[int v468]
                                    let v471 : string = "num_complex::Complex::new($0, $1)"
                                    let v472 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v471 
                                    let v475 : (int32 -> float) = float
                                    let v476 : float = v475 v470
                                    let v487 : string = "num_complex::Complex::new($0, $1)"
                                    let v488 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v476, 0.0) v487 
                                    let v489 : string = "num_complex::Complex::powc($0, $1)"
                                    let v490 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v488, v448) v489 
                                    let v491 : string = "$0 / $1"
                                    let v492 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v472, v490) v491 
                                    let v493 : string = "$0 + $1"
                                    let v494 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v469, v492) v493 
                                    let v495 : int32 = v468 + 1
                                    v466.l0 <- v495
                                    v466.l1 <- v494
                                    ()
                                let v496 : num_complex_Complex<float> = v466.l1
                                v496
                            else
                                let v497 : string = "num_complex::Complex::new($0, $1)"
                                let v498 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v497 
                                let v499 : string = "$0 - $1"
                                let v500 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v498, v448) v499 
                                let v501 : string = $"        s = mpmath.gamma(s)"
                                let v502 : num_complex_Complex<float> = method3(v500)
                                let v503 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v501, v502)
                                (* run_target_args'
                                let v506 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v507 : string = "$0.ok()"
                                let v508 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v503 v507 
                                let _run_target_args'_v506 = v508 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v509 : string = "$0.ok()"
                                let v510 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v503 v509 
                                let _run_target_args'_v506 = v510 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v511 : string = "$0.ok()"
                                let v512 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v503 v511 
                                let _run_target_args'_v506 = v512 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v513 : num_complex_Complex<float> option = match v503 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v506 = v513 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v514 : num_complex_Complex<float> option = match v503 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v506 = v514 
                                #endif
#else
                                let v515 : num_complex_Complex<float> option = match v503 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v506 = v515 
                                #endif
                                let v516 : num_complex_Complex<float> option = _run_target_args'_v506 
                                let v577 : (num_complex_Complex<float> -> US0) = method17()
                                let v578 : US0 option = v516 |> Option.map v577 
                                let v635 : US0 = US0_1
                                let v636 : US0 = v578 |> Option.defaultValue v635 
                                let v648 : string = "f64::NAN"
                                let v649 : float = Fable.Core.RustInterop.emitRustExpr () v648 
                                let v650 : string = "f64::NAN"
                                let v651 : float = Fable.Core.RustInterop.emitRustExpr () v650 
                                let v652 : string = "num_complex::Complex::new($0, $1)"
                                let v653 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v649, v651) v652 
                                let v656 : num_complex_Complex<float> =
                                    match v636 with
                                    | US0_1 -> (* None *)
                                        v653
                                    | US0_0(v654) -> (* Some *)
                                        v654
                                let v657 : string = "num_complex::Complex::new($0, $1)"
                                let v658 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v657 
                                let v659 : string = "$0 * $1"
                                let v660 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v658, v448) v659 
                                let v661 : string = "num_complex::Complex::new($0, $1)"
                                let v662 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v661 
                                let v663 : string = "$0 / $1"
                                let v664 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v660, v662) v663 
                                let v665 : string = "$0.sin()"
                                let v666 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v664 v665 
                                let v667 : string = "$0.re"
                                let v668 : float = Fable.Core.RustInterop.emitRustExpr v448 v667 
                                let v669 : float = 1.0 - v668
                                let v670 : string = "$0.im"
                                let v671 : float = Fable.Core.RustInterop.emitRustExpr v448 v670 
                                let v672 : float =  -v671
                                let v673 : string = "num_complex::Complex::new($0, $1)"
                                let v674 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v669, v672) v673 
                                let v675 : string = "$0.re"
                                let v676 : float = Fable.Core.RustInterop.emitRustExpr v674 v675 
                                let v677 : bool = v676 <= 1.0
                                let v1164 : num_complex_Complex<float> =
                                    if v677 then
                                        let v678 : string = "num_complex::Complex::new($0, $1)"
                                        let v679 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v678 
                                        v679
                                    else
                                        let v680 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v674) v680 
                                        let v681 : string = "$0.re"
                                        let v682 : float = Fable.Core.RustInterop.emitRustExpr v674 v681 
                                        let v683 : bool = v682 > 1.0
                                        if v683 then
                                            let v684 : string = "num_complex::Complex::new($0, $1)"
                                            let v685 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v684 
                                            let v686 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v687 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v687) do
                                                let v689 : int32 = v687.l0
                                                v686.[int v689] <- v689
                                                let v690 : int32 = v689 + 1
                                                v687.l0 <- v690
                                                ()
                                            let v691 : int32 = v686.Length
                                            let v692 : Mut2 = {l0 = 0; l1 = v685} : Mut2
                                            while method15(v691, v692) do
                                                let v694 : int32 = v692.l0
                                                let v695 : num_complex_Complex<float> = v692.l1
                                                let v696 : int32 = v686.[int v694]
                                                let v697 : string = "num_complex::Complex::new($0, $1)"
                                                let v698 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v697 
                                                let v701 : (int32 -> float) = float
                                                let v702 : float = v701 v696
                                                let v713 : string = "num_complex::Complex::new($0, $1)"
                                                let v714 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v702, 0.0) v713 
                                                let v715 : string = "num_complex::Complex::powc($0, $1)"
                                                let v716 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v714, v674) v715 
                                                let v717 : string = "$0 / $1"
                                                let v718 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v698, v716) v717 
                                                let v719 : string = "$0 + $1"
                                                let v720 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v695, v718) v719 
                                                let v721 : int32 = v694 + 1
                                                v692.l0 <- v721
                                                v692.l1 <- v720
                                                ()
                                            let v722 : num_complex_Complex<float> = v692.l1
                                            v722
                                        else
                                            let v723 : string = "num_complex::Complex::new($0, $1)"
                                            let v724 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v723 
                                            let v725 : string = "$0 - $1"
                                            let v726 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v724, v674) v725 
                                            let v727 : string = $"        s = mpmath.gamma(s)"
                                            let v728 : num_complex_Complex<float> = method3(v726)
                                            let v729 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v727, v728)
                                            (* run_target_args'
                                            let v732 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v733 : string = "$0.ok()"
                                            let v734 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v729 v733 
                                            let _run_target_args'_v732 = v734 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v735 : string = "$0.ok()"
                                            let v736 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v729 v735 
                                            let _run_target_args'_v732 = v736 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v737 : string = "$0.ok()"
                                            let v738 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v729 v737 
                                            let _run_target_args'_v732 = v738 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v739 : num_complex_Complex<float> option = match v729 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v732 = v739 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v740 : num_complex_Complex<float> option = match v729 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v732 = v740 
                                            #endif
#else
                                            let v741 : num_complex_Complex<float> option = match v729 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v732 = v741 
                                            #endif
                                            let v742 : num_complex_Complex<float> option = _run_target_args'_v732 
                                            let v803 : (num_complex_Complex<float> -> US0) = method17()
                                            let v804 : US0 option = v742 |> Option.map v803 
                                            let v861 : US0 = US0_1
                                            let v862 : US0 = v804 |> Option.defaultValue v861 
                                            let v874 : string = "f64::NAN"
                                            let v875 : float = Fable.Core.RustInterop.emitRustExpr () v874 
                                            let v876 : string = "f64::NAN"
                                            let v877 : float = Fable.Core.RustInterop.emitRustExpr () v876 
                                            let v878 : string = "num_complex::Complex::new($0, $1)"
                                            let v879 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v875, v877) v878 
                                            let v882 : num_complex_Complex<float> =
                                                match v862 with
                                                | US0_1 -> (* None *)
                                                    v879
                                                | US0_0(v880) -> (* Some *)
                                                    v880
                                            let v883 : string = "num_complex::Complex::new($0, $1)"
                                            let v884 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v883 
                                            let v885 : string = "$0 * $1"
                                            let v886 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v884, v674) v885 
                                            let v887 : string = "num_complex::Complex::new($0, $1)"
                                            let v888 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v887 
                                            let v889 : string = "$0 / $1"
                                            let v890 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v886, v888) v889 
                                            let v891 : string = "$0.sin()"
                                            let v892 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v890 v891 
                                            let v893 : string = "$0.re"
                                            let v894 : float = Fable.Core.RustInterop.emitRustExpr v674 v893 
                                            let v895 : float = 1.0 - v894
                                            let v896 : string = "$0.im"
                                            let v897 : float = Fable.Core.RustInterop.emitRustExpr v674 v896 
                                            let v898 : float =  -v897
                                            let v899 : string = "num_complex::Complex::new($0, $1)"
                                            let v900 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v895, v898) v899 
                                            let v901 : string = "$0.re"
                                            let v902 : float = Fable.Core.RustInterop.emitRustExpr v900 v901 
                                            let v903 : bool = v902 <= 1.0
                                            let v1148 : num_complex_Complex<float> =
                                                if v903 then
                                                    let v904 : string = "num_complex::Complex::new($0, $1)"
                                                    let v905 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v904 
                                                    v905
                                                else
                                                    let v906 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v900) v906 
                                                    let v907 : string = "$0.re"
                                                    let v908 : float = Fable.Core.RustInterop.emitRustExpr v900 v907 
                                                    let v909 : bool = v908 > 1.0
                                                    if v909 then
                                                        let v910 : string = "num_complex::Complex::new($0, $1)"
                                                        let v911 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v910 
                                                        let v912 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v913 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v913) do
                                                            let v915 : int32 = v913.l0
                                                            v912.[int v915] <- v915
                                                            let v916 : int32 = v915 + 1
                                                            v913.l0 <- v916
                                                            ()
                                                        let v917 : int32 = v912.Length
                                                        let v918 : Mut2 = {l0 = 0; l1 = v911} : Mut2
                                                        while method15(v917, v918) do
                                                            let v920 : int32 = v918.l0
                                                            let v921 : num_complex_Complex<float> = v918.l1
                                                            let v922 : int32 = v912.[int v920]
                                                            let v923 : string = "num_complex::Complex::new($0, $1)"
                                                            let v924 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v923 
                                                            let v927 : (int32 -> float) = float
                                                            let v928 : float = v927 v922
                                                            let v939 : string = "num_complex::Complex::new($0, $1)"
                                                            let v940 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v928, 0.0) v939 
                                                            let v941 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v942 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v940, v900) v941 
                                                            let v943 : string = "$0 / $1"
                                                            let v944 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v924, v942) v943 
                                                            let v945 : string = "$0 + $1"
                                                            let v946 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v921, v944) v945 
                                                            let v947 : int32 = v920 + 1
                                                            v918.l0 <- v947
                                                            v918.l1 <- v946
                                                            ()
                                                        let v948 : num_complex_Complex<float> = v918.l1
                                                        v948
                                                    else
                                                        let v949 : string = "num_complex::Complex::new($0, $1)"
                                                        let v950 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v949 
                                                        let v951 : string = "$0 - $1"
                                                        let v952 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v950, v900) v951 
                                                        let v953 : string = $"        s = mpmath.gamma(s)"
                                                        let v954 : num_complex_Complex<float> = method3(v952)
                                                        let v955 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v953, v954)
                                                        (* run_target_args'
                                                        let v958 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v959 : string = "$0.ok()"
                                                        let v960 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v955 v959 
                                                        let _run_target_args'_v958 = v960 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v961 : string = "$0.ok()"
                                                        let v962 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v955 v961 
                                                        let _run_target_args'_v958 = v962 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v963 : string = "$0.ok()"
                                                        let v964 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v955 v963 
                                                        let _run_target_args'_v958 = v964 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v965 : num_complex_Complex<float> option = match v955 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v958 = v965 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v966 : num_complex_Complex<float> option = match v955 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v958 = v966 
                                                        #endif
#else
                                                        let v967 : num_complex_Complex<float> option = match v955 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v958 = v967 
                                                        #endif
                                                        let v968 : num_complex_Complex<float> option = _run_target_args'_v958 
                                                        let v1029 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v1030 : US0 option = v968 |> Option.map v1029 
                                                        let v1087 : US0 = US0_1
                                                        let v1088 : US0 = v1030 |> Option.defaultValue v1087 
                                                        let v1100 : string = "f64::NAN"
                                                        let v1101 : float = Fable.Core.RustInterop.emitRustExpr () v1100 
                                                        let v1102 : string = "f64::NAN"
                                                        let v1103 : float = Fable.Core.RustInterop.emitRustExpr () v1102 
                                                        let v1104 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1101, v1103) v1104 
                                                        let v1108 : num_complex_Complex<float> =
                                                            match v1088 with
                                                            | US0_1 -> (* None *)
                                                                v1105
                                                            | US0_0(v1106) -> (* Some *)
                                                                v1106
                                                        let v1109 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1109 
                                                        let v1111 : string = "$0 * $1"
                                                        let v1112 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1110, v900) v1111 
                                                        let v1113 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1114 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1113 
                                                        let v1115 : string = "$0 / $1"
                                                        let v1116 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1112, v1114) v1115 
                                                        let v1117 : string = "$0.sin()"
                                                        let v1118 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v1116 v1117 
                                                        let v1119 : string = "$0.re"
                                                        let v1120 : float = Fable.Core.RustInterop.emitRustExpr v900 v1119 
                                                        let v1121 : float = 1.0 - v1120
                                                        let v1122 : string = "$0.im"
                                                        let v1123 : float = Fable.Core.RustInterop.emitRustExpr v900 v1122 
                                                        let v1124 : float =  -v1123
                                                        let v1125 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1126 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1121, v1124) v1125 
                                                        let v1127 : string = "$0.re"
                                                        let v1128 : float = Fable.Core.RustInterop.emitRustExpr v1126 v1127 
                                                        let v1129 : bool = v1128 <= 1.0
                                                        let v1132 : num_complex_Complex<float> =
                                                            if v1129 then
                                                                let v1130 : string = "num_complex::Complex::new($0, $1)"
                                                                let v1131 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v1130 
                                                                v1131
                                                            else
                                                                v1126
                                                        let v1133 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1134 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1133 
                                                        let v1135 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1135 
                                                        let v1137 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v1138 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1136, v900) v1137 
                                                        let v1139 : string = "$0 * $1"
                                                        let v1140 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1134, v1138) v1139 
                                                        let v1141 : string = "$0 * $1"
                                                        let v1142 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1140, v1118) v1141 
                                                        let v1143 : string = "$0 * $1"
                                                        let v1144 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1142, v1108) v1143 
                                                        let v1145 : string = "$0 * $1"
                                                        let v1146 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1144, v1132) v1145 
                                                        v1146
                                            let v1149 : string = "num_complex::Complex::new($0, $1)"
                                            let v1150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1149 
                                            let v1151 : string = "num_complex::Complex::new($0, $1)"
                                            let v1152 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1151 
                                            let v1153 : string = "num_complex::Complex::powc($0, $1)"
                                            let v1154 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1152, v674) v1153 
                                            let v1155 : string = "$0 * $1"
                                            let v1156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1150, v1154) v1155 
                                            let v1157 : string = "$0 * $1"
                                            let v1158 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1156, v892) v1157 
                                            let v1159 : string = "$0 * $1"
                                            let v1160 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1158, v882) v1159 
                                            let v1161 : string = "$0 * $1"
                                            let v1162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1160, v1148) v1161 
                                            v1162
                                let v1165 : string = "num_complex::Complex::new($0, $1)"
                                let v1166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1165 
                                let v1167 : string = "num_complex::Complex::new($0, $1)"
                                let v1168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1167 
                                let v1169 : string = "num_complex::Complex::powc($0, $1)"
                                let v1170 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1168, v448) v1169 
                                let v1171 : string = "$0 * $1"
                                let v1172 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1166, v1170) v1171 
                                let v1173 : string = "$0 * $1"
                                let v1174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1172, v666) v1173 
                                let v1175 : string = "$0 * $1"
                                let v1176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1174, v656) v1175 
                                let v1177 : string = "$0 * $1"
                                let v1178 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1176, v1164) v1177 
                                v1178
                    let v1181 : string = "num_complex::Complex::new($0, $1)"
                    let v1182 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1181 
                    let v1183 : string = "num_complex::Complex::new($0, $1)"
                    let v1184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1183 
                    let v1185 : string = "num_complex::Complex::powc($0, $1)"
                    let v1186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1184, v222) v1185 
                    let v1187 : string = "$0 * $1"
                    let v1188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1182, v1186) v1187 
                    let v1189 : string = "$0 * $1"
                    let v1190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1188, v440) v1189 
                    let v1191 : string = "$0 * $1"
                    let v1192 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1190, v430) v1191 
                    let v1193 : string = "$0 * $1"
                    let v1194 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1192, v1180) v1193 
                    v1194
        let v1197 : string = "num_complex::Complex::new($0, $1)"
        let v1198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1197 
        let v1199 : string = "num_complex::Complex::new($0, $1)"
        let v1200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1199 
        let v1201 : string = "num_complex::Complex::powc($0, $1)"
        let v1202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1200, v1) v1201 
        let v1203 : string = "$0 * $1"
        let v1204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1198, v1202) v1203 
        let v1205 : string = "$0 * $1"
        let v1206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1204, v214) v1205 
        let v1207 : string = "$0 * $1"
        let v1208 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1206, v204) v1207 
        let v1209 : string = "$0 * $1"
        let v1210 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1208, v1196) v1209 
        v1210
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
    let v11 : Mut3 = {l0 = v1} : Mut3
    method21(v11)
    method22(v11)
    method23(v11)
    let v383 : string = $"%+.6f{v0}"
    method24(v11, v383)
    method25(v11)
    let v611 : string = v11.l0
    v611
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
    let v12 : Mut3 = {l0 = v2} : Mut3
    method21(v12)
    method27(v12)
    method23(v12)
    let v384 : string = $"%+.6f{v0}"
    method24(v12, v384)
    method28(v12)
    method22(v12)
    method23(v12)
    let v868 : string = $"%+.6f{v1}"
    method24(v12, v868)
    method25(v12)
    let v1096 : string = v12.l0
    v1096
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
        let v89 : (num_complex_Complex<float> -> US0) = method17()
        let v90 : US0 option = v28 |> Option.map v89 
        let v147 : US0 = US0_1
        let v148 : US0 = v90 |> Option.defaultValue v147 
        let v160 : string = "f64::NAN"
        let v161 : float = Fable.Core.RustInterop.emitRustExpr () v160 
        let v162 : string = "f64::NAN"
        let v163 : float = Fable.Core.RustInterop.emitRustExpr () v162 
        let v164 : string = "num_complex::Complex::new($0, $1)"
        let v165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v161, v163) v164 
        let v168 : num_complex_Complex<float> =
            match v148 with
            | US0_1 -> (* None *)
                v165
            | US0_0(v166) -> (* Some *)
                v166
        let v169 : string = "$0.im"
        let v170 : float = Fable.Core.RustInterop.emitRustExpr v168 v169 
        let v171 : bool = v170 = 0.0
        let v173 : bool =
            if v171 then
                true
            else
                method18(v171)
        let v178 : string =
            if v171 then
                let v174 : float = 0.0
                method19(v174)
            else
                let v176 : float = 0.0
                method26(v170, v176)
        let v185 : string = "__assert_eq"
        let v186 : string = " "
        let v187 : string = v185 + v186 
        let v202 : string =
            if v171 then
                let v198 : float = 0.0
                method19(v198)
            else
                let v200 : float = 0.0
                method26(v170, v200)
        let v205 : string = v187 + v202 
        let v218 : unit = ()
        let v219 : (unit -> unit) = closure2(v205)
        let v220 : unit = (fun () -> v219 (); v218) ()
        let v230 : bool = v173 = false
        if v230 then
            failwith<unit> v205
        let v231 : string = "$0.re"
        let v232 : float = Fable.Core.RustInterop.emitRustExpr v168 v231 
        let v233 : float = v232 - v11
        let v234 : float =  -v233
        let v235 : bool = v233 >= v234
        let v236 : float =
            if v235 then
                v233
            else
                v234
        let v237 : bool = v236 < 0.0001
        let v239 : bool =
            if v237 then
                true
            else
                method18(v237)
        let v244 : string =
            if v237 then
                let v240 : float = 0.0001
                method19(v240)
            else
                let v242 : float = 0.0001
                method26(v236, v242)
        let v249 : string = "__assert_lt"
        let v250 : string = v249 + v186 
        let v265 : string =
            if v237 then
                let v261 : float = 0.0001
                method19(v261)
            else
                let v263 : float = 0.0001
                method26(v236, v263)
        let v268 : string = v250 + v265 
        let v281 : unit = ()
        let v282 : (unit -> unit) = closure2(v268)
        let v283 : unit = (fun () -> v282 (); v281) ()
        let v293 : bool = v239 = false
        if v293 then
            failwith<unit> v268
        let v294 : int32 = v9 + 1
        v7.l0 <- v294
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
    let v80 : (num_complex_Complex<float> -> US0) = method17()
    let v81 : US0 option = v19 |> Option.map v80 
    let v138 : US0 = US0_1
    let v139 : US0 = v81 |> Option.defaultValue v138 
    let v151 : string = "f64::NAN"
    let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "f64::NAN"
    let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "num_complex::Complex::new($0, $1)"
    let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
    let v159 : num_complex_Complex<float> =
        match v139 with
        | US0_1 -> (* None *)
            v156
        | US0_0(v157) -> (* Some *)
            v157
    let v160 : string = "$0.re"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr v159 v160 
    let v162 : float = v161 - 0.8673
    let v163 : float =  -v162
    let v164 : bool = v162 >= v163
    let v165 : float =
        if v164 then
            v162
        else
            v163
    let v166 : bool = v165 < 0.001
    let v168 : bool =
        if v166 then
            true
        else
            method18(v166)
    let v173 : string =
        if v166 then
            let v169 : float = 0.001
            method19(v169)
        else
            let v171 : float = 0.001
            method26(v165, v171)
    let v180 : string = "__assert_lt"
    let v181 : string = " "
    let v182 : string = v180 + v181 
    let v197 : string =
        if v166 then
            let v193 : float = 0.001
            method19(v193)
        else
            let v195 : float = 0.001
            method26(v165, v195)
    let v200 : string = v182 + v197 
    let v213 : unit = ()
    let v214 : (unit -> unit) = closure2(v200)
    let v215 : unit = (fun () -> v214 (); v213) ()
    let v225 : bool = v168 = false
    if v225 then
        failwith<unit> v200
    let v226 : string = "$0.im"
    let v227 : float = Fable.Core.RustInterop.emitRustExpr v159 v226 
    let v228 : float = v227 - 0.275
    let v229 : float =  -v228
    let v230 : bool = v228 >= v229
    let v231 : float =
        if v230 then
            v228
        else
            v229
    let v232 : bool = v231 < 0.001
    let v234 : bool =
        if v232 then
            true
        else
            method18(v232)
    let v239 : string =
        if v232 then
            let v235 : float = 0.001
            method19(v235)
        else
            let v237 : float = 0.001
            method26(v231, v237)
    let v242 : string = v180 + v181 
    let v257 : string =
        if v232 then
            let v253 : float = 0.001
            method19(v253)
        else
            let v255 : float = 0.001
            method26(v231, v255)
    let v260 : string = v242 + v257 
    let v273 : unit = ()
    let v274 : (unit -> unit) = closure2(v260)
    let v275 : unit = (fun () -> v274 (); v273) ()
    let v285 : bool = v234 = false
    if v285 then
        failwith<unit> v260
and method30 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v83 : (num_complex_Complex<float> -> US0) = method17()
        let v84 : US0 option = v22 |> Option.map v83 
        let v141 : US0 = US0_1
        let v142 : US0 = v84 |> Option.defaultValue v141 
        let v154 : string = "f64::NAN"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154 
        let v156 : string = "f64::NAN"
        let v157 : float = Fable.Core.RustInterop.emitRustExpr () v156 
        let v158 : string = "num_complex::Complex::new($0, $1)"
        let v159 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v155, v157) v158 
        let v162 : num_complex_Complex<float> =
            match v142 with
            | US0_1 -> (* None *)
                v159
            | US0_0(v160) -> (* Some *)
                v160
        let v163 : string = "$0.re"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr v162 v163 
        let v165 : bool = v164 = 0.0
        let v167 : bool =
            if v165 then
                true
            else
                method18(v165)
        let v172 : string =
            if v165 then
                let v168 : float = 0.0
                method19(v168)
            else
                let v170 : float = 0.0
                method26(v164, v170)
        let v179 : string = "__assert_eq"
        let v180 : string = " "
        let v181 : string = v179 + v180 
        let v196 : string =
            if v165 then
                let v192 : float = 0.0
                method19(v192)
            else
                let v194 : float = 0.0
                method26(v164, v194)
        let v199 : string = v181 + v196 
        let v212 : unit = ()
        let v213 : (unit -> unit) = closure2(v199)
        let v214 : unit = (fun () -> v213 (); v212) ()
        let v224 : bool = v167 = false
        if v224 then
            failwith<unit> v199
        let v225 : string = "$0.im"
        let v226 : float = Fable.Core.RustInterop.emitRustExpr v162 v225 
        let v227 : bool = v226 = 0.0
        let v229 : bool =
            if v227 then
                true
            else
                method18(v227)
        let v234 : string =
            if v227 then
                let v230 : float = 0.0
                method19(v230)
            else
                let v232 : float = 0.0
                method26(v226, v232)
        let v237 : string = v179 + v180 
        let v252 : string =
            if v227 then
                let v248 : float = 0.0
                method19(v248)
            else
                let v250 : float = 0.0
                method26(v226, v250)
        let v255 : string = v237 + v252 
        let v268 : unit = ()
        let v269 : (unit -> unit) = closure2(v255)
        let v270 : unit = (fun () -> v269 (); v268) ()
        let v280 : bool = v229 = false
        if v280 then
            failwith<unit> v255
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v96 : (num_complex_Complex<float> -> US0) = method17()
        let v97 : US0 option = v35 |> Option.map v96 
        let v154 : US0 = US0_1
        let v155 : US0 = v97 |> Option.defaultValue v154 
        let v167 : string = "f64::NAN"
        let v168 : float = Fable.Core.RustInterop.emitRustExpr () v167 
        let v169 : string = "f64::NAN"
        let v170 : float = Fable.Core.RustInterop.emitRustExpr () v169 
        let v171 : string = "num_complex::Complex::new($0, $1)"
        let v172 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v168, v170) v171 
        let v175 : num_complex_Complex<float> =
            match v155 with
            | US0_1 -> (* None *)
                v172
            | US0_0(v173) -> (* Some *)
                v173
        let v176 : string = "$0.re"
        let v177 : float = Fable.Core.RustInterop.emitRustExpr v175 v176 
        let v178 : float =  -v177
        let v179 : bool = v177 >= v178
        let v180 : float =
            if v179 then
                v177
            else
                v178
        let v181 : bool = v180 < 0.0001
        let v183 : bool =
            if v181 then
                true
            else
                method18(v181)
        let v188 : string =
            if v181 then
                let v184 : float = 0.0001
                method19(v184)
            else
                let v186 : float = 0.0001
                method26(v180, v186)
        let v195 : string = "__assert_lt"
        let v196 : string = " "
        let v197 : string = v195 + v196 
        let v212 : string =
            if v181 then
                let v208 : float = 0.0001
                method19(v208)
            else
                let v210 : float = 0.0001
                method26(v180, v210)
        let v215 : string = v197 + v212 
        let v228 : unit = ()
        let v229 : (unit -> unit) = closure2(v215)
        let v230 : unit = (fun () -> v229 (); v228) ()
        let v240 : bool = v183 = false
        if v240 then
            failwith<unit> v215
        let v241 : string = "$0.im"
        let v242 : float = Fable.Core.RustInterop.emitRustExpr v175 v241 
        let v243 : float =  -v242
        let v244 : bool = v242 >= v243
        let v245 : float =
            if v244 then
                v242
            else
                v243
        let v246 : bool = v245 < 0.0001
        let v248 : bool =
            if v246 then
                true
            else
                method18(v246)
        let v253 : string =
            if v246 then
                let v249 : float = 0.0001
                method19(v249)
            else
                let v251 : float = 0.0001
                method26(v245, v251)
        let v256 : string = v195 + v196 
        let v271 : string =
            if v246 then
                let v267 : float = 0.0001
                method19(v267)
            else
                let v269 : float = 0.0001
                method26(v245, v269)
        let v274 : string = v256 + v271 
        let v287 : unit = ()
        let v288 : (unit -> unit) = closure2(v274)
        let v289 : unit = (fun () -> v288 (); v287) ()
        let v299 : bool = v248 = false
        if v299 then
            failwith<unit> v274
        let v300 : int32 = v17 + 1
        v15.l0 <- v300
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v86 : (num_complex_Complex<float> -> US0) = method17()
        let v87 : US0 option = v25 |> Option.map v86 
        let v144 : US0 = US0_1
        let v145 : US0 = v87 |> Option.defaultValue v144 
        let v157 : string = "f64::NAN"
        let v158 : float = Fable.Core.RustInterop.emitRustExpr () v157 
        let v159 : string = "f64::NAN"
        let v160 : float = Fable.Core.RustInterop.emitRustExpr () v159 
        let v161 : string = "num_complex::Complex::new($0, $1)"
        let v162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v158, v160) v161 
        let v165 : num_complex_Complex<float> =
            match v145 with
            | US0_1 -> (* None *)
                v162
            | US0_0(v163) -> (* Some *)
                v163
        let v166 : string = "$0.re"
        let v167 : float = Fable.Core.RustInterop.emitRustExpr v165 v166 
        let v168 : bool = v167 > 0.0
        let v170 : bool =
            if v168 then
                true
            else
                method18(v168)
        let v175 : string =
            if v168 then
                let v171 : float = 0.0
                method19(v171)
            else
                let v173 : float = 0.0
                method26(v167, v173)
        let v182 : string = "__assert_gt"
        let v183 : string = " "
        let v184 : string = v182 + v183 
        let v199 : string =
            if v168 then
                let v195 : float = 0.0
                method19(v195)
            else
                let v197 : float = 0.0
                method26(v167, v197)
        let v202 : string = v184 + v199 
        let v215 : unit = ()
        let v216 : (unit -> unit) = closure2(v202)
        let v217 : unit = (fun () -> v216 (); v215) ()
        let v227 : bool = v170 = false
        if v227 then
            failwith<unit> v202
        let v228 : string = "$0.im"
        let v229 : float = Fable.Core.RustInterop.emitRustExpr v165 v228 
        let v230 : bool = v229 = 0.0
        let v232 : bool =
            if v230 then
                true
            else
                method18(v230)
        let v237 : string =
            if v230 then
                let v233 : float = 0.0
                method19(v233)
            else
                let v235 : float = 0.0
                method26(v229, v235)
        let v242 : string = "__assert_eq"
        let v243 : string = v242 + v183 
        let v258 : string =
            if v230 then
                let v254 : float = 0.0
                method19(v254)
            else
                let v256 : float = 0.0
                method26(v229, v256)
        let v261 : string = v243 + v258 
        let v274 : unit = ()
        let v275 : (unit -> unit) = closure2(v261)
        let v276 : unit = (fun () -> v275 (); v274) ()
        let v286 : bool = v232 = false
        if v286 then
            failwith<unit> v261
        let v287 : int32 = v5 + 1
        v3.l0 <- v287
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
    let v80 : (num_complex_Complex<float> -> US0) = method17()
    let v81 : US0 option = v19 |> Option.map v80 
    let v138 : US0 = US0_1
    let v139 : US0 = v81 |> Option.defaultValue v138 
    let v151 : string = "f64::NAN"
    let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "f64::NAN"
    let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "num_complex::Complex::new($0, $1)"
    let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
    let v159 : num_complex_Complex<float> =
        match v139 with
        | US0_1 -> (* None *)
            v156
        | US0_0(v157) -> (* Some *)
            v157
    let v160 : string = "$0.re"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr v159 v160 
    let v162 : bool = v161 = infinity
    let v164 : bool =
        if v162 then
            true
        else
            method18(v162)
    let v169 : string =
        if v162 then
            let v165 : float = infinity
            method19(v165)
        else
            let v167 : float = infinity
            method26(v161, v167)
    let v176 : string = "__assert_eq"
    let v177 : string = " "
    let v178 : string = v176 + v177 
    let v193 : string =
        if v162 then
            let v189 : float = infinity
            method19(v189)
        else
            let v191 : float = infinity
            method26(v161, v191)
    let v196 : string = v178 + v193 
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure2(v196)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : bool = v164 = false
    if v221 then
        failwith<unit> v196
    let v222 : string = "$0.im"
    let v223 : float = Fable.Core.RustInterop.emitRustExpr v159 v222 
    let v224 : bool = v223 = 0.0
    let v226 : bool =
        if v224 then
            true
        else
            method18(v224)
    let v231 : string =
        if v224 then
            let v227 : float = 0.0
            method19(v227)
        else
            let v229 : float = 0.0
            method26(v223, v229)
    let v234 : string = v176 + v177 
    let v249 : string =
        if v224 then
            let v245 : float = 0.0
            method19(v245)
        else
            let v247 : float = 0.0
            method26(v223, v247)
    let v252 : string = v234 + v249 
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure2(v252)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v277 : bool = v226 = false
    if v277 then
        failwith<unit> v252
and method40 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method41(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
    let v80 : (num_complex_Complex<float> -> US0) = method17()
    let v81 : US0 option = v19 |> Option.map v80 
    let v138 : US0 = US0_1
    let v139 : US0 = v81 |> Option.defaultValue v138 
    let v151 : string = "f64::NAN"
    let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "f64::NAN"
    let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "num_complex::Complex::new($0, $1)"
    let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
    let v159 : num_complex_Complex<float> =
        match v139 with
        | US0_1 -> (* None *)
            v156
        | US0_0(v157) -> (* Some *)
            v157
    let v160 : string = "$0.re"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr v2 v160 
    let v162 : string = "$0.im"
    let v163 : float = Fable.Core.RustInterop.emitRustExpr v2 v162 
    let v164 : float =  -v163
    let v165 : string = "num_complex::Complex::new($0, $1)"
    let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v161, v164) v165 
    let v167 : string = $"        s = mpmath.zeta(s)"
    let v168 : num_complex_Complex<float> = method3(v166)
    let v169 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v167, v168)
    let v170 : num_complex_Complex<float> = method13(v0, v166)
    (* run_target_args'
    let v173 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v174 : string = "$0.ok()"
    let v175 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v169 v174 
    let _run_target_args'_v173 = v175 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v176 : string = "$0.ok()"
    let v177 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v169 v176 
    let _run_target_args'_v173 = v177 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v178 : string = "$0.ok()"
    let v179 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v169 v178 
    let _run_target_args'_v173 = v179 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v180 : num_complex_Complex<float> option = match v169 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v173 = v180 
    #endif
#if FABLE_COMPILER_PYTHON
    let v181 : num_complex_Complex<float> option = match v169 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v173 = v181 
    #endif
#else
    let v182 : num_complex_Complex<float> option = match v169 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v173 = v182 
    #endif
    let v183 : num_complex_Complex<float> option = _run_target_args'_v173 
    let v244 : (num_complex_Complex<float> -> US0) = method17()
    let v245 : US0 option = v183 |> Option.map v244 
    let v302 : US0 = US0_1
    let v303 : US0 = v245 |> Option.defaultValue v302 
    let v315 : string = "f64::NAN"
    let v316 : float = Fable.Core.RustInterop.emitRustExpr () v315 
    let v317 : string = "f64::NAN"
    let v318 : float = Fable.Core.RustInterop.emitRustExpr () v317 
    let v319 : string = "num_complex::Complex::new($0, $1)"
    let v320 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v316, v318) v319 
    let v323 : num_complex_Complex<float> =
        match v303 with
        | US0_1 -> (* None *)
            v320
        | US0_0(v321) -> (* Some *)
            v321
    let v324 : string = "$0.conj()"
    let v325 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v323 v324 
    let v326 : string = "$0.re"
    let v327 : float = Fable.Core.RustInterop.emitRustExpr v159 v326 
    let v328 : string = "$0.re"
    let v329 : float = Fable.Core.RustInterop.emitRustExpr v325 v328 
    let v330 : bool = v327 = v329
    let v332 : bool =
        if v330 then
            true
        else
            method18(v330)
    let v335 : string =
        if v330 then
            method19(v329)
        else
            method26(v327, v329)
    let v342 : string = "__assert_eq"
    let v343 : string = " "
    let v344 : string = v342 + v343 
    let v357 : string =
        if v330 then
            method19(v329)
        else
            method26(v327, v329)
    let v360 : string = v344 + v357 
    let v373 : unit = ()
    let v374 : (unit -> unit) = closure2(v360)
    let v375 : unit = (fun () -> v374 (); v373) ()
    let v385 : bool = v332 = false
    if v385 then
        failwith<unit> v360
    let v386 : string = "$0.im"
    let v387 : float = Fable.Core.RustInterop.emitRustExpr v159 v386 
    let v388 : string = "$0.im"
    let v389 : float = Fable.Core.RustInterop.emitRustExpr v325 v388 
    let v390 : bool = v387 = v389
    let v392 : bool =
        if v390 then
            true
        else
            method18(v390)
    let v395 : string =
        if v390 then
            method19(v389)
        else
            method26(v387, v389)
    let v398 : string = v342 + v343 
    let v411 : string =
        if v390 then
            method19(v389)
        else
            method26(v387, v389)
    let v414 : string = v398 + v411 
    let v427 : unit = ()
    let v428 : (unit -> unit) = closure2(v414)
    let v429 : unit = (fun () -> v428 (); v427) ()
    let v439 : bool = v392 = false
    if v439 then
        failwith<unit> v414
and method42 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method43(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
    let v80 : (num_complex_Complex<float> -> US0) = method17()
    let v81 : US0 option = v19 |> Option.map v80 
    let v138 : US0 = US0_1
    let v139 : US0 = v81 |> Option.defaultValue v138 
    let v151 : string = "f64::NAN"
    let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "f64::NAN"
    let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "num_complex::Complex::new($0, $1)"
    let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
    let v159 : num_complex_Complex<float> =
        match v139 with
        | US0_1 -> (* None *)
            v156
        | US0_0(v157) -> (* Some *)
            v157
    let v160 : string = "$0.re"
    let v161 : float = Fable.Core.RustInterop.emitRustExpr v159 v160 
    let v162 : bool = v161 < infinity
    let v164 : bool =
        if v162 then
            true
        else
            method18(v162)
    let v169 : string =
        if v162 then
            let v165 : float = infinity
            method19(v165)
        else
            let v167 : float = infinity
            method26(v161, v167)
    let v176 : string = "__assert_lt"
    let v177 : string = " "
    let v178 : string = v176 + v177 
    let v193 : string =
        if v162 then
            let v189 : float = infinity
            method19(v189)
        else
            let v191 : float = infinity
            method26(v161, v191)
    let v196 : string = v178 + v193 
    let v209 : unit = ()
    let v210 : (unit -> unit) = closure2(v196)
    let v211 : unit = (fun () -> v210 (); v209) ()
    let v221 : bool = v164 = false
    if v221 then
        failwith<unit> v196
    let v222 : string = "$0.im"
    let v223 : float = Fable.Core.RustInterop.emitRustExpr v159 v222 
    let v224 : bool = v223 < infinity
    let v226 : bool =
        if v224 then
            true
        else
            method18(v224)
    let v231 : string =
        if v224 then
            let v227 : float = infinity
            method19(v227)
        else
            let v229 : float = infinity
            method26(v223, v229)
    let v234 : string = v176 + v177 
    let v249 : string =
        if v224 then
            let v245 : float = infinity
            method19(v245)
        else
            let v247 : float = infinity
            method26(v223, v247)
    let v252 : string = v234 + v249 
    let v265 : unit = ()
    let v266 : (unit -> unit) = closure2(v252)
    let v267 : unit = (fun () -> v266 (); v265) ()
    let v277 : bool = v226 = false
    if v277 then
        failwith<unit> v252
and method44 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method45(v3)
    let v6 : Result<unit, pyo3_PyErr> = Ok () 
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v83 : (num_complex_Complex<float> -> US0) = method17()
        let v84 : US0 option = v22 |> Option.map v83 
        let v141 : US0 = US0_1
        let v142 : US0 = v84 |> Option.defaultValue v141 
        let v154 : string = "f64::NAN"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154 
        let v156 : string = "f64::NAN"
        let v157 : float = Fable.Core.RustInterop.emitRustExpr () v156 
        let v158 : string = "num_complex::Complex::new($0, $1)"
        let v159 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v155, v157) v158 
        let v162 : num_complex_Complex<float> =
            match v142 with
            | US0_1 -> (* None *)
                v159
            | US0_0(v160) -> (* Some *)
                v160
        let v163 : string = "$0.re"
        let v164 : float = Fable.Core.RustInterop.emitRustExpr v162 v163 
        let v167 : bool = v164 <> 0.0 
        let v179 : bool =
            if v167 then
                true
            else
                method18(v167)
        let v184 : string =
            if v167 then
                let v180 : float = 0.0
                method19(v180)
            else
                let v182 : float = 0.0
                method26(v164, v182)
        let v191 : string = "__assert_ne"
        let v192 : string = " "
        let v193 : string = v191 + v192 
        let v208 : string =
            if v167 then
                let v204 : float = 0.0
                method19(v204)
            else
                let v206 : float = 0.0
                method26(v164, v206)
        let v211 : string = v193 + v208 
        let v224 : unit = ()
        let v225 : (unit -> unit) = closure2(v211)
        let v226 : unit = (fun () -> v225 (); v224) ()
        let v236 : bool = v179 = false
        if v236 then
            failwith<unit> v211
        let v237 : string = "$0.im"
        let v238 : float = Fable.Core.RustInterop.emitRustExpr v162 v237 
        let v241 : bool = v238 <> 0.0 
        let v253 : bool =
            if v241 then
                true
            else
                method18(v241)
        let v258 : string =
            if v241 then
                let v254 : float = 0.0
                method19(v254)
            else
                let v256 : float = 0.0
                method26(v238, v256)
        let v261 : string = v191 + v192 
        let v276 : string =
            if v241 then
                let v272 : float = 0.0
                method19(v272)
            else
                let v274 : float = 0.0
                method26(v238, v274)
        let v279 : string = v261 + v276 
        let v292 : unit = ()
        let v293 : (unit -> unit) = closure2(v279)
        let v294 : unit = (fun () -> v293 (); v292) ()
        let v304 : bool = v253 = false
        if v304 then
            failwith<unit> v279
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v81 : (num_complex_Complex<float> -> US0) = method17()
        let v82 : US0 option = v20 |> Option.map v81 
        let v139 : US0 = US0_1
        let v140 : US0 = v82 |> Option.defaultValue v139 
        let v152 : string = "f64::NAN"
        let v153 : float = Fable.Core.RustInterop.emitRustExpr () v152 
        let v154 : string = "f64::NAN"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154 
        let v156 : string = "num_complex::Complex::new($0, $1)"
        let v157 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v153, v155) v156 
        let v160 : num_complex_Complex<float> =
            match v140 with
            | US0_1 -> (* None *)
                v157
            | US0_0(v158) -> (* Some *)
                v158
        let v161 : string = "$0.re"
        let v162 : float = Fable.Core.RustInterop.emitRustExpr v160 v161 
        let v165 : bool = v162 <> 0.0 
        let v177 : bool =
            if v165 then
                true
            else
                method18(v165)
        let v182 : string =
            if v165 then
                let v178 : float = 0.0
                method19(v178)
            else
                let v180 : float = 0.0
                method26(v162, v180)
        let v189 : string = "__assert_ne"
        let v190 : string = " "
        let v191 : string = v189 + v190 
        let v206 : string =
            if v165 then
                let v202 : float = 0.0
                method19(v202)
            else
                let v204 : float = 0.0
                method26(v162, v204)
        let v209 : string = v191 + v206 
        let v222 : unit = ()
        let v223 : (unit -> unit) = closure2(v209)
        let v224 : unit = (fun () -> v223 (); v222) ()
        let v234 : bool = v177 = false
        if v234 then
            failwith<unit> v209
        let v235 : string = "$0.im"
        let v236 : float = Fable.Core.RustInterop.emitRustExpr v160 v235 
        let v239 : bool = v236 <> 0.0 
        let v251 : bool =
            if v239 then
                true
            else
                method18(v239)
        let v256 : string =
            if v239 then
                let v252 : float = 0.0
                method19(v252)
            else
                let v254 : float = 0.0
                method26(v236, v254)
        let v259 : string = v189 + v190 
        let v274 : string =
            if v239 then
                let v270 : float = 0.0
                method19(v270)
            else
                let v272 : float = 0.0
                method26(v236, v272)
        let v277 : string = v259 + v274 
        let v290 : unit = ()
        let v291 : (unit -> unit) = closure2(v277)
        let v292 : unit = (fun () -> v291 (); v290) ()
        let v302 : bool = v251 = false
        if v302 then
            failwith<unit> v277
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v81 : (num_complex_Complex<float> -> US0) = method17()
        let v82 : US0 option = v20 |> Option.map v81 
        let v139 : US0 = US0_1
        let v140 : US0 = v82 |> Option.defaultValue v139 
        let v152 : string = "f64::NAN"
        let v153 : float = Fable.Core.RustInterop.emitRustExpr () v152 
        let v154 : string = "f64::NAN"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154 
        let v156 : string = "num_complex::Complex::new($0, $1)"
        let v157 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v153, v155) v156 
        let v160 : num_complex_Complex<float> =
            match v140 with
            | US0_1 -> (* None *)
                v157
            | US0_0(v158) -> (* Some *)
                v158
        let v161 : string = "num_complex::Complex::new($0, $1)"
        let v162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v161 
        let v163 : string = "num_complex::Complex::powc($0, $1)"
        let v164 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v162, v2) v163 
        let v165 : string = "num_complex::Complex::new($0, $1)"
        let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v165 
        let v167 : string = "num_complex::Complex::new($0, $1)"
        let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v167 
        let v169 : string = "$0 - $1"
        let v170 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v168) v169 
        let v171 : string = "num_complex::Complex::powc($0, $1)"
        let v172 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v166, v170) v171 
        let v173 : string = "$0 * $1"
        let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v164, v172) v173 
        let v175 : string = "num_complex::Complex::new($0, $1)"
        let v176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v175 
        let v177 : string = "$0 * $1"
        let v178 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v176, v2) v177 
        let v179 : string = "num_complex::Complex::new($0, $1)"
        let v180 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v179 
        let v181 : string = "$0 / $1"
        let v182 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v178, v180) v181 
        let v183 : string = "$0.sin()"
        let v184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v182 v183 
        let v185 : string = "$0 * $1"
        let v186 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v174, v184) v185 
        let v187 : string = "num_complex::Complex::new($0, $1)"
        let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v187 
        let v189 : string = "$0 - $1"
        let v190 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v188, v2) v189 
        let v191 : string = $"        s = mpmath.gamma(s)"
        let v192 : num_complex_Complex<float> = method3(v190)
        let v193 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v191, v192)
        (* run_target_args'
        let v196 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v197 : string = "$0.ok()"
        let v198 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v193 v197 
        let _run_target_args'_v196 = v198 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v199 : string = "$0.ok()"
        let v200 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v193 v199 
        let _run_target_args'_v196 = v200 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v201 : string = "$0.ok()"
        let v202 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v193 v201 
        let _run_target_args'_v196 = v202 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v203 : num_complex_Complex<float> option = match v193 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v196 = v203 
        #endif
#if FABLE_COMPILER_PYTHON
        let v204 : num_complex_Complex<float> option = match v193 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v196 = v204 
        #endif
#else
        let v205 : num_complex_Complex<float> option = match v193 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v196 = v205 
        #endif
        let v206 : num_complex_Complex<float> option = _run_target_args'_v196 
        let v267 : (num_complex_Complex<float> -> US0) = method17()
        let v268 : US0 option = v206 |> Option.map v267 
        let v325 : US0 = US0_1
        let v326 : US0 = v268 |> Option.defaultValue v325 
        let v338 : string = "f64::NAN"
        let v339 : float = Fable.Core.RustInterop.emitRustExpr () v338 
        let v340 : string = "f64::NAN"
        let v341 : float = Fable.Core.RustInterop.emitRustExpr () v340 
        let v342 : string = "num_complex::Complex::new($0, $1)"
        let v343 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v339, v341) v342 
        let v346 : num_complex_Complex<float> =
            match v326 with
            | US0_1 -> (* None *)
                v343
            | US0_0(v344) -> (* Some *)
                v344
        let v347 : string = "$0 * $1"
        let v348 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v186, v346) v347 
        let v349 : string = "$0.re"
        let v350 : float = Fable.Core.RustInterop.emitRustExpr v2 v349 
        let v351 : float = 1.0 - v350
        let v352 : string = "$0.im"
        let v353 : float = Fable.Core.RustInterop.emitRustExpr v2 v352 
        let v354 : float =  -v353
        let v355 : string = "num_complex::Complex::new($0, $1)"
        let v356 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v351, v354) v355 
        let v357 : string = $"        s = mpmath.zeta(s)"
        let v358 : num_complex_Complex<float> = method3(v356)
        let v359 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v357, v358)
        let v360 : num_complex_Complex<float> = method13(v0, v356)
        (* run_target_args'
        let v363 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v364 : string = "$0.ok()"
        let v365 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v359 v364 
        let _run_target_args'_v363 = v365 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v366 : string = "$0.ok()"
        let v367 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v359 v366 
        let _run_target_args'_v363 = v367 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v368 : string = "$0.ok()"
        let v369 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v359 v368 
        let _run_target_args'_v363 = v369 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v370 : num_complex_Complex<float> option = match v359 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v363 = v370 
        #endif
#if FABLE_COMPILER_PYTHON
        let v371 : num_complex_Complex<float> option = match v359 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v363 = v371 
        #endif
#else
        let v372 : num_complex_Complex<float> option = match v359 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v363 = v372 
        #endif
        let v373 : num_complex_Complex<float> option = _run_target_args'_v363 
        let v434 : (num_complex_Complex<float> -> US0) = method17()
        let v435 : US0 option = v373 |> Option.map v434 
        let v492 : US0 = US0_1
        let v493 : US0 = v435 |> Option.defaultValue v492 
        let v505 : string = "f64::NAN"
        let v506 : float = Fable.Core.RustInterop.emitRustExpr () v505 
        let v507 : string = "f64::NAN"
        let v508 : float = Fable.Core.RustInterop.emitRustExpr () v507 
        let v509 : string = "num_complex::Complex::new($0, $1)"
        let v510 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v506, v508) v509 
        let v513 : num_complex_Complex<float> =
            match v493 with
            | US0_1 -> (* None *)
                v510
            | US0_0(v511) -> (* Some *)
                v511
        let v514 : string = "$0 * $1"
        let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v348, v513) v514 
        let v516 : string = "$0.re"
        let v517 : float = Fable.Core.RustInterop.emitRustExpr v160 v516 
        let v518 : string = "$0.re"
        let v519 : float = Fable.Core.RustInterop.emitRustExpr v515 v518 
        let v520 : float = v517 - v519
        let v521 : float =  -v520
        let v522 : bool = v520 >= v521
        let v523 : float =
            if v522 then
                v520
            else
                v521
        let v524 : bool = v523 < 0.0001
        let v526 : bool =
            if v524 then
                true
            else
                method18(v524)
        let v531 : string =
            if v524 then
                let v527 : float = 0.0001
                method19(v527)
            else
                let v529 : float = 0.0001
                method26(v523, v529)
        let v538 : string = "__assert_lt"
        let v539 : string = " "
        let v540 : string = v538 + v539 
        let v555 : string =
            if v524 then
                let v551 : float = 0.0001
                method19(v551)
            else
                let v553 : float = 0.0001
                method26(v523, v553)
        let v558 : string = v540 + v555 
        let v571 : unit = ()
        let v572 : (unit -> unit) = closure2(v558)
        let v573 : unit = (fun () -> v572 (); v571) ()
        let v583 : bool = v526 = false
        if v583 then
            failwith<unit> v558
        let v584 : string = "$0.im"
        let v585 : float = Fable.Core.RustInterop.emitRustExpr v160 v584 
        let v586 : string = "$0.im"
        let v587 : float = Fable.Core.RustInterop.emitRustExpr v515 v586 
        let v588 : float = v585 - v587
        let v589 : float =  -v588
        let v590 : bool = v588 >= v589
        let v591 : float =
            if v590 then
                v588
            else
                v589
        let v592 : bool = v591 < 0.0001
        let v594 : bool =
            if v592 then
                true
            else
                method18(v592)
        let v599 : string =
            if v592 then
                let v595 : float = 0.0001
                method19(v595)
            else
                let v597 : float = 0.0001
                method26(v591, v597)
        let v602 : string = v538 + v539 
        let v617 : string =
            if v592 then
                let v613 : float = 0.0001
                method19(v613)
            else
                let v615 : float = 0.0001
                method26(v591, v615)
        let v620 : string = v602 + v617 
        let v633 : unit = ()
        let v634 : (unit -> unit) = closure2(v620)
        let v635 : unit = (fun () -> v634 (); v633) ()
        let v645 : bool = v594 = false
        if v645 then
            failwith<unit> v620
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
        let v86 : (num_complex_Complex<float> -> US0) = method17()
        let v87 : US0 option = v25 |> Option.map v86 
        let v144 : US0 = US0_1
        let v145 : US0 = v87 |> Option.defaultValue v144 
        let v157 : string = "f64::NAN"
        let v158 : float = Fable.Core.RustInterop.emitRustExpr () v157 
        let v159 : string = "f64::NAN"
        let v160 : float = Fable.Core.RustInterop.emitRustExpr () v159 
        let v161 : string = "num_complex::Complex::new($0, $1)"
        let v162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v158, v160) v161 
        let v165 : num_complex_Complex<float> =
            match v145 with
            | US0_1 -> (* None *)
                v162
            | US0_0(v163) -> (* Some *)
                v163
        let v166 : string = "$0.re"
        let v167 : float = Fable.Core.RustInterop.emitRustExpr v165 v166 
        let v168 : float = v167 - v8
        let v169 : float =  -v168
        let v170 : bool = v168 >= v169
        let v171 : float =
            if v170 then
                v168
            else
                v169
        let v172 : bool = v171 < 0.01
        let v174 : bool =
            if v172 then
                true
            else
                method18(v172)
        let v179 : string =
            if v172 then
                let v175 : float = 0.01
                method19(v175)
            else
                let v177 : float = 0.01
                method26(v171, v177)
        let v186 : string = "__assert_lt"
        let v187 : string = " "
        let v188 : string = v186 + v187 
        let v203 : string =
            if v172 then
                let v199 : float = 0.01
                method19(v199)
            else
                let v201 : float = 0.01
                method26(v171, v201)
        let v206 : string = v188 + v203 
        let v219 : unit = ()
        let v220 : (unit -> unit) = closure2(v206)
        let v221 : unit = (fun () -> v220 (); v219) ()
        let v231 : bool = v174 = false
        if v231 then
            failwith<unit> v206
        let v232 : string = "$0.im"
        let v233 : float = Fable.Core.RustInterop.emitRustExpr v165 v232 
        let v234 : bool = v233 < 0.01
        let v236 : bool =
            if v234 then
                true
            else
                method18(v234)
        let v241 : string =
            if v234 then
                let v237 : float = 0.01
                method19(v237)
            else
                let v239 : float = 0.01
                method26(v233, v239)
        let v244 : string = v186 + v187 
        let v259 : string =
            if v234 then
                let v255 : float = 0.01
                method19(v255)
            else
                let v257 : float = 0.01
                method26(v233, v257)
        let v262 : string = v244 + v259 
        let v275 : unit = ()
        let v276 : (unit -> unit) = closure2(v262)
        let v277 : unit = (fun () -> v276 (); v275) ()
        let v287 : bool = v236 = false
        if v287 then
            failwith<unit> v262
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
    let v17 : Result<unit, pyo3_PyErr> = method29(v6)
    let v18 : string = ""
    let v19 : string = "}"
    let v20 : string = v18 + v19 
    let v21 : string = v20 + v19 
    let v22 : string = "{"
    let v23 : string = v18 + v22 
    let x = v17 //
    let v24 : _ = x
    let v25 : unit = ()
    (* run_target_args'
    let v26 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v27 : string = $"true; let _fix_closure_v25 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v24 v27 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = $"true; let _fix_closure_v25 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v24 v29 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v31 : string = $"true; let _fix_closure_v25 = $0"
    let v32 : bool = Fable.Core.RustInterop.emitRustExpr v24 v31 
    let _run_target_args'_v26 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v26 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v26 = false 
    #endif
#else
    let _run_target_args'_v26 = false 
    #endif
    let v33 : bool = _run_target_args'_v26 
    let v34 : string = $"true; _fix_closure_v25 " + v21 + "); " + v23 + " // rust.fix_closure'"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr () v34 
    let v36 : string = "__run_test"
    let v37 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v36 
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v37 v38 
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
    let v4 : unit = ()
    let v5 : (unit -> unit) = closure2(v1)
    let v6 : unit = (fun () -> v5 (); v4) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure3()
let main args = v1 args
()
