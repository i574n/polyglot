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
        let v13 : string = v11 + v10 
        let v24 : string = v13 + v9 
        let v34 : int32 = v5 + 1
        let v35 : string = "\n"
        v3.l0 <- v34
        v3.l1 <- v24
        v3.l2 <- v35
        ()
    let struct (v36 : string, v37 : string) = v3.l1, v3.l2
    v36
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
    let v42 : (float * float) = v38, v40 
    let v53 : (bool * (float * float)) = false, v42 
    let v63 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v75 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v76 
    let _run_target_args'_v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v78 
    let _run_target_args'_v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v80 
    let _run_target_args'_v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v105 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v105 
    #endif
#else
    let v116 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v116 
    #endif
    let v126 : Ref<Str> = _run_target_args'_v75 
    (* run_target_args'
    let v160 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v161 : string = "String::from($0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v161 
    let _run_target_args'_v160 = v162 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163 : string = "String::from($0)"
    let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v163 
    let _run_target_args'_v160 = v164 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v165 : string = "String::from($0)"
    let v166 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v165 
    let _run_target_args'_v160 = v166 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v179 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v179 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v190 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v190 
    #endif
#else
    let v201 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v201 
    #endif
    let v211 : std_string_String = _run_target_args'_v160 
    let v234 : string = "std::ffi::CString::new($0).unwrap()"
    let v235 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v211 v234 
    let v236 : string = ""
    (* run_target_args'
    let v248 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v249 : string = "&*$0"
    let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v236 v249 
    let _run_target_args'_v248 = v250 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v251 : string = "&*$0"
    let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v236 v251 
    let _run_target_args'_v248 = v252 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v253 : string = "&*$0"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v236 v253 
    let _run_target_args'_v248 = v254 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v256 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v256 
    #endif
#if FABLE_COMPILER_PYTHON
    let v267 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v267 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v278 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v278 
    #endif
#else
    let v289 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v289 
    #endif
    let v299 : Ref<Str> = _run_target_args'_v248 
    (* run_target_args'
    let v333 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v334 : string = "String::from($0)"
    let v335 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v334 
    let _run_target_args'_v333 = v335 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v336 : string = "String::from($0)"
    let v337 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v336 
    let _run_target_args'_v333 = v337 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v338 : string = "String::from($0)"
    let v339 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v338 
    let _run_target_args'_v333 = v339 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v341 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v352 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v352 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v363 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v363 
    #endif
#else
    let v374 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v374 
    #endif
    let v384 : std_string_String = _run_target_args'_v333 
    let v407 : string = "std::ffi::CString::new($0).unwrap()"
    let v408 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v384 v407 
    let v409 : string = "pyo3::types::PyModule::from_code(v63, &$0, &v408, &v408)"
    let v410 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v235 v409 
    let v411 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v412 : bool = Fable.Core.RustInterop.emitRustExpr v410 v411 
    let v413 : string = "x"
    let v414 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v413 
    (* run_target_args'
    let v426 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v427 : string = "format!(\"{}\", $0)"
    let v428 : std_string_String = Fable.Core.RustInterop.emitRustExpr v414 v427 
    let _run_target_args'_v426 = v428 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v429 : string = "format!(\"{}\", $0)"
    let v430 : std_string_String = Fable.Core.RustInterop.emitRustExpr v414 v429 
    let _run_target_args'_v426 = v430 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v431 : string = "format!(\"{}\", $0)"
    let v432 : std_string_String = Fable.Core.RustInterop.emitRustExpr v414 v431 
    let _run_target_args'_v426 = v432 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v434 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v434 
    #endif
#if FABLE_COMPILER_PYTHON
    let v445 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v445 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v456 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v456 
    #endif
#else
    let v467 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v467 
    #endif
    let v477 : std_string_String = _run_target_args'_v426 
    let v500 : string = "true; $0 })"
    let v501 : bool = Fable.Core.RustInterop.emitRustExpr v477 v500 
    let v502 : string = "_result_map_error__"
    let v503 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v502 
    (* run_target_args'
    let v505 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v506 : string = "$0.unwrap()"
    let v507 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v503 v506 
    let _run_target_args'_v505 = v507 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v508 : string = "$0.unwrap()"
    let v509 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v503 v508 
    let _run_target_args'_v505 = v509 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v510 : string = "$0.unwrap()"
    let v511 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v503 v510 
    let _run_target_args'_v505 = v511 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v512 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v512 
    #endif
#if FABLE_COMPILER_PYTHON
    let v513 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v513 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v514 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v514 
    #endif
#else
    let v515 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v515 
    #endif
    let v516 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v505 
    let v519 : string = method8()
    (* run_target_args'
    let v531 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v532 : string = "&*$0"
    let v533 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v532 
    let _run_target_args'_v531 = v533 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v534 : string = "&*$0"
    let v535 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v534 
    let _run_target_args'_v531 = v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v536 : string = "&*$0"
    let v537 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v536 
    let _run_target_args'_v531 = v537 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v539 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v539 
    #endif
#if FABLE_COMPILER_PYTHON
    let v550 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v550 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v561 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v561 
    #endif
#else
    let v572 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v572 
    #endif
    let v582 : Ref<Str> = _run_target_args'_v531 
    let v605 : pyo3_Bound<pyo3_types_PyModule> = method9(v516)
    let v606 : string = "v605.getattr($0)"
    let v607 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v582 v606 
    let v608 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v609 : bool = Fable.Core.RustInterop.emitRustExpr v607 v608 
    let v610 : string = "x"
    let v611 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v610 
    (* run_target_args'
    let v623 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v624 : string = "format!(\"{}\", $0)"
    let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v624 
    let _run_target_args'_v623 = v625 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v626 : string = "format!(\"{}\", $0)"
    let v627 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v626 
    let _run_target_args'_v623 = v627 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v628 : string = "format!(\"{}\", $0)"
    let v629 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v628 
    let _run_target_args'_v623 = v629 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v631 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v631 
    #endif
#if FABLE_COMPILER_PYTHON
    let v642 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v642 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v653 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v653 
    #endif
#else
    let v664 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v664 
    #endif
    let v674 : std_string_String = _run_target_args'_v623 
    let v697 : string = "true; $0 })"
    let v698 : bool = Fable.Core.RustInterop.emitRustExpr v674 v697 
    let v699 : string = "_result_map_error__"
    let v700 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v699 
    (* run_target_args'
    let v702 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v703 : string = "$0.unwrap()"
    let v704 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v700 v703 
    let _run_target_args'_v702 = v704 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v705 : string = "$0.unwrap()"
    let v706 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v700 v705 
    let _run_target_args'_v702 = v706 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v707 : string = "$0.unwrap()"
    let v708 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v700 v707 
    let _run_target_args'_v702 = v708 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v709 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v709 
    #endif
#if FABLE_COMPILER_PYTHON
    let v710 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v710 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v711 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v711 
    #endif
#else
    let v712 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v712 
    #endif
    let v713 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v702 
    let v716 : (bool * (float * float)) = method10(v53)
    let v717 : pyo3_Bound<pyo3_PyAny> = method11(v713)
    let v718 : string = "pyo3::prelude::PyAnyMethods::call(&v717, ((*v716).0, *(*v716).1), None)"
    let v719 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v718 
    let v720 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v721 : bool = Fable.Core.RustInterop.emitRustExpr v719 v720 
    let v722 : string = "x"
    let v723 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v722 
    (* run_target_args'
    let v735 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v736 : string = "format!(\"{}\", $0)"
    let v737 : std_string_String = Fable.Core.RustInterop.emitRustExpr v723 v736 
    let _run_target_args'_v735 = v737 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v738 : string = "format!(\"{}\", $0)"
    let v739 : std_string_String = Fable.Core.RustInterop.emitRustExpr v723 v738 
    let _run_target_args'_v735 = v739 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v740 : string = "format!(\"{}\", $0)"
    let v741 : std_string_String = Fable.Core.RustInterop.emitRustExpr v723 v740 
    let _run_target_args'_v735 = v741 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v743 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v743 
    #endif
#if FABLE_COMPILER_PYTHON
    let v754 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v754 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v765 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v765 
    #endif
#else
    let v776 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v776 
    #endif
    let v786 : std_string_String = _run_target_args'_v735 
    let v809 : string = "true; $0 })"
    let v810 : bool = Fable.Core.RustInterop.emitRustExpr v786 v809 
    let v811 : string = "_result_map_error__"
    let v812 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v811 
    let v813 : string = "$0?"
    let v814 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v812 v813 
    let v815 : pyo3_Bound<pyo3_PyAny> = method12(v814)
    let v816 : string = "v815.extract()"
    let v817 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v816 
    let v818 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v819 : bool = Fable.Core.RustInterop.emitRustExpr v817 v818 
    let v820 : string = "x"
    let v821 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v820 
    (* run_target_args'
    let v833 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v834 : string = "format!(\"{}\", $0)"
    let v835 : std_string_String = Fable.Core.RustInterop.emitRustExpr v821 v834 
    let _run_target_args'_v833 = v835 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v836 : string = "format!(\"{}\", $0)"
    let v837 : std_string_String = Fable.Core.RustInterop.emitRustExpr v821 v836 
    let _run_target_args'_v833 = v837 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v838 : string = "format!(\"{}\", $0)"
    let v839 : std_string_String = Fable.Core.RustInterop.emitRustExpr v821 v838 
    let _run_target_args'_v833 = v839 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v841 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v841 
    #endif
#if FABLE_COMPILER_PYTHON
    let v852 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v852 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v863 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v863 
    #endif
#else
    let v874 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v874 
    #endif
    let v884 : std_string_String = _run_target_args'_v833 
    let v907 : string = "true; $0 })"
    let v908 : bool = Fable.Core.RustInterop.emitRustExpr v884 v907 
    let v909 : string = "_result_map_error__"
    let v910 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v909 
    let v911 : string = "$0?"
    let struct (v912 : float, v913 : float) = Fable.Core.RustInterop.emitRustExpr v910 v911 
    let v914 : string = "num_complex::Complex::new($0, $1)"
    let v915 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v912, v913) v914 
    let v917 : Result<num_complex_Complex<float>, std_string_String> = Ok v915 
    v917
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
    let v42 : (float * float) = v38, v40 
    let v53 : (bool * (float * float)) = false, v42 
    let v63 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v75 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v76 : string = "&*$0"
    let v77 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v76 
    let _run_target_args'_v75 = v77 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v78 : string = "&*$0"
    let v79 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v78 
    let _run_target_args'_v75 = v79 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v80 : string = "&*$0"
    let v81 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v80 
    let _run_target_args'_v75 = v81 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v83 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v83 
    #endif
#if FABLE_COMPILER_PYTHON
    let v94 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v94 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v105 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v105 
    #endif
#else
    let v116 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v75 = v116 
    #endif
    let v126 : Ref<Str> = _run_target_args'_v75 
    (* run_target_args'
    let v160 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v161 : string = "String::from($0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v161 
    let _run_target_args'_v160 = v162 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v163 : string = "String::from($0)"
    let v164 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v163 
    let _run_target_args'_v160 = v164 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v165 : string = "String::from($0)"
    let v166 : std_string_String = Fable.Core.RustInterop.emitRustExpr v126 v165 
    let _run_target_args'_v160 = v166 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v168 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v168 
    #endif
#if FABLE_COMPILER_PYTHON
    let v179 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v179 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v190 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v190 
    #endif
#else
    let v201 : std_string_String = v126 |> unbox<std_string_String>
    let _run_target_args'_v160 = v201 
    #endif
    let v211 : std_string_String = _run_target_args'_v160 
    let v234 : string = "std::ffi::CString::new($0).unwrap()"
    let v235 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v211 v234 
    let v236 : string = ""
    (* run_target_args'
    let v248 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v249 : string = "&*$0"
    let v250 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v236 v249 
    let _run_target_args'_v248 = v250 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v251 : string = "&*$0"
    let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v236 v251 
    let _run_target_args'_v248 = v252 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v253 : string = "&*$0"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v236 v253 
    let _run_target_args'_v248 = v254 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v256 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v256 
    #endif
#if FABLE_COMPILER_PYTHON
    let v267 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v267 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v278 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v278 
    #endif
#else
    let v289 : Ref<Str> = v236 |> unbox<Ref<Str>>
    let _run_target_args'_v248 = v289 
    #endif
    let v299 : Ref<Str> = _run_target_args'_v248 
    (* run_target_args'
    let v333 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v334 : string = "String::from($0)"
    let v335 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v334 
    let _run_target_args'_v333 = v335 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v336 : string = "String::from($0)"
    let v337 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v336 
    let _run_target_args'_v333 = v337 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v338 : string = "String::from($0)"
    let v339 : std_string_String = Fable.Core.RustInterop.emitRustExpr v299 v338 
    let _run_target_args'_v333 = v339 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v341 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v341 
    #endif
#if FABLE_COMPILER_PYTHON
    let v352 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v352 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v363 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v363 
    #endif
#else
    let v374 : std_string_String = v299 |> unbox<std_string_String>
    let _run_target_args'_v333 = v374 
    #endif
    let v384 : std_string_String = _run_target_args'_v333 
    let v407 : string = "std::ffi::CString::new($0).unwrap()"
    let v408 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v384 v407 
    let v409 : string = "pyo3::types::PyModule::from_code(v63, &$0, &v408, &v408)"
    let v410 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v235 v409 
    let v411 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v412 : bool = Fable.Core.RustInterop.emitRustExpr v410 v411 
    let v413 : string = "x"
    let v414 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v413 
    (* run_target_args'
    let v426 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v427 : string = "format!(\"{}\", $0)"
    let v428 : std_string_String = Fable.Core.RustInterop.emitRustExpr v414 v427 
    let _run_target_args'_v426 = v428 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v429 : string = "format!(\"{}\", $0)"
    let v430 : std_string_String = Fable.Core.RustInterop.emitRustExpr v414 v429 
    let _run_target_args'_v426 = v430 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v431 : string = "format!(\"{}\", $0)"
    let v432 : std_string_String = Fable.Core.RustInterop.emitRustExpr v414 v431 
    let _run_target_args'_v426 = v432 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v434 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v434 
    #endif
#if FABLE_COMPILER_PYTHON
    let v445 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v445 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v456 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v456 
    #endif
#else
    let v467 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v426 = v467 
    #endif
    let v477 : std_string_String = _run_target_args'_v426 
    let v500 : string = "true; $0 })"
    let v501 : bool = Fable.Core.RustInterop.emitRustExpr v477 v500 
    let v502 : string = "_result_map_error__"
    let v503 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v502 
    (* run_target_args'
    let v505 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v506 : string = "$0.unwrap()"
    let v507 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v503 v506 
    let _run_target_args'_v505 = v507 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v508 : string = "$0.unwrap()"
    let v509 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v503 v508 
    let _run_target_args'_v505 = v509 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v510 : string = "$0.unwrap()"
    let v511 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v503 v510 
    let _run_target_args'_v505 = v511 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v512 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v512 
    #endif
#if FABLE_COMPILER_PYTHON
    let v513 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v513 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v514 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v514 
    #endif
#else
    let v515 : pyo3_Bound<pyo3_types_PyModule> = match v503 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v505 = v515 
    #endif
    let v516 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v505 
    let v519 : string = method8()
    (* run_target_args'
    let v531 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v532 : string = "&*$0"
    let v533 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v532 
    let _run_target_args'_v531 = v533 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v534 : string = "&*$0"
    let v535 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v534 
    let _run_target_args'_v531 = v535 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v536 : string = "&*$0"
    let v537 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v519 v536 
    let _run_target_args'_v531 = v537 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v539 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v539 
    #endif
#if FABLE_COMPILER_PYTHON
    let v550 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v550 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v561 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v561 
    #endif
#else
    let v572 : Ref<Str> = v519 |> unbox<Ref<Str>>
    let _run_target_args'_v531 = v572 
    #endif
    let v582 : Ref<Str> = _run_target_args'_v531 
    let v605 : pyo3_Bound<pyo3_types_PyModule> = method9(v516)
    let v606 : string = "v605.getattr($0)"
    let v607 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v582 v606 
    let v608 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v609 : bool = Fable.Core.RustInterop.emitRustExpr v607 v608 
    let v610 : string = "x"
    let v611 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v610 
    (* run_target_args'
    let v623 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v624 : string = "format!(\"{}\", $0)"
    let v625 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v624 
    let _run_target_args'_v623 = v625 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v626 : string = "format!(\"{}\", $0)"
    let v627 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v626 
    let _run_target_args'_v623 = v627 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v628 : string = "format!(\"{}\", $0)"
    let v629 : std_string_String = Fable.Core.RustInterop.emitRustExpr v611 v628 
    let _run_target_args'_v623 = v629 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v631 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v631 
    #endif
#if FABLE_COMPILER_PYTHON
    let v642 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v642 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v653 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v653 
    #endif
#else
    let v664 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v623 = v664 
    #endif
    let v674 : std_string_String = _run_target_args'_v623 
    let v697 : string = "true; $0 })"
    let v698 : bool = Fable.Core.RustInterop.emitRustExpr v674 v697 
    let v699 : string = "_result_map_error__"
    let v700 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v699 
    (* run_target_args'
    let v702 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v703 : string = "$0.unwrap()"
    let v704 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v700 v703 
    let _run_target_args'_v702 = v704 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v705 : string = "$0.unwrap()"
    let v706 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v700 v705 
    let _run_target_args'_v702 = v706 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v707 : string = "$0.unwrap()"
    let v708 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v700 v707 
    let _run_target_args'_v702 = v708 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v709 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v709 
    #endif
#if FABLE_COMPILER_PYTHON
    let v710 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v710 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v711 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v711 
    #endif
#else
    let v712 : pyo3_Bound<pyo3_PyAny> = match v700 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v702 = v712 
    #endif
    let v713 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v702 
    let v716 : (bool * (float * float)) = method10(v53)
    let v717 : pyo3_Bound<pyo3_PyAny> = method11(v713)
    let v718 : string = "pyo3::prelude::PyAnyMethods::call(&v717, ((*v716).0, *(*v716).1), None)"
    let v719 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v718 
    let v720 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v721 : bool = Fable.Core.RustInterop.emitRustExpr v719 v720 
    let v722 : string = "x"
    let v723 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v722 
    (* run_target_args'
    let v735 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v736 : string = "format!(\"{}\", $0)"
    let v737 : std_string_String = Fable.Core.RustInterop.emitRustExpr v723 v736 
    let _run_target_args'_v735 = v737 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v738 : string = "format!(\"{}\", $0)"
    let v739 : std_string_String = Fable.Core.RustInterop.emitRustExpr v723 v738 
    let _run_target_args'_v735 = v739 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v740 : string = "format!(\"{}\", $0)"
    let v741 : std_string_String = Fable.Core.RustInterop.emitRustExpr v723 v740 
    let _run_target_args'_v735 = v741 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v743 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v743 
    #endif
#if FABLE_COMPILER_PYTHON
    let v754 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v754 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v765 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v765 
    #endif
#else
    let v776 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v735 = v776 
    #endif
    let v786 : std_string_String = _run_target_args'_v735 
    let v809 : string = "true; $0 })"
    let v810 : bool = Fable.Core.RustInterop.emitRustExpr v786 v809 
    let v811 : string = "_result_map_error__"
    let v812 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v811 
    let v813 : string = "$0?"
    let v814 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v812 v813 
    let v815 : pyo3_Bound<pyo3_PyAny> = method12(v814)
    let v816 : string = "v815.extract()"
    let v817 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v816 
    let v818 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v819 : bool = Fable.Core.RustInterop.emitRustExpr v817 v818 
    let v820 : string = "x"
    let v821 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v820 
    (* run_target_args'
    let v833 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v834 : string = "format!(\"{}\", $0)"
    let v835 : std_string_String = Fable.Core.RustInterop.emitRustExpr v821 v834 
    let _run_target_args'_v833 = v835 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v836 : string = "format!(\"{}\", $0)"
    let v837 : std_string_String = Fable.Core.RustInterop.emitRustExpr v821 v836 
    let _run_target_args'_v833 = v837 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v838 : string = "format!(\"{}\", $0)"
    let v839 : std_string_String = Fable.Core.RustInterop.emitRustExpr v821 v838 
    let _run_target_args'_v833 = v839 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v841 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v841 
    #endif
#if FABLE_COMPILER_PYTHON
    let v852 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v852 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v863 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v863 
    #endif
#else
    let v874 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v833 = v874 
    #endif
    let v884 : std_string_String = _run_target_args'_v833 
    let v907 : string = "true; $0 })"
    let v908 : bool = Fable.Core.RustInterop.emitRustExpr v884 v907 
    let v909 : string = "_result_map_error__"
    let v910 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v909 
    let v911 : string = "$0?"
    let struct (v912 : float, v913 : float) = Fable.Core.RustInterop.emitRustExpr v910 v911 
    let v914 : string = "num_complex::Complex::new($0, $1)"
    let v915 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v912, v913) v914 
    let v917 : Result<num_complex_Complex<float>, std_string_String> = Ok v915 
    v917
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
            let v22 : (int32 -> float) = float
            let v23 : float = v22 v18
            let v33 : string = "num_complex::Complex::new($0, $1)"
            let v34 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v23, 0.0) v33 
            let v35 : string = "num_complex::Complex::powc($0, $1)"
            let v36 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v34, v1) v35 
            let v37 : string = "$0 / $1"
            let v38 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v36) v37 
            let v39 : string = "$0 + $1"
            let v40 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v38) v39 
            let v41 : int32 = v16 + 1
            v14.l0 <- v41
            v14.l1 <- v40
            ()
        let v42 : num_complex_Complex<float> = v14.l1
        v42
    else
        let v43 : string = "num_complex::Complex::new($0, $1)"
        let v44 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v43 
        let v45 : string = "$0 - $1"
        let v46 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v44, v1) v45 
        let v47 : string = $"        s = mpmath.gamma(s)"
        let v48 : num_complex_Complex<float> = method3(v46)
        let v49 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v47, v48)
        (* run_target_args'
        let v51 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v52 : string = "$0.ok()"
        let v53 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v49 v52 
        let _run_target_args'_v51 = v53 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v54 : string = "$0.ok()"
        let v55 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v49 v54 
        let _run_target_args'_v51 = v55 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v56 : string = "$0.ok()"
        let v57 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v49 v56 
        let _run_target_args'_v51 = v57 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v58 : num_complex_Complex<float> option = match v49 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v51 = v58 
        #endif
#if FABLE_COMPILER_PYTHON
        let v59 : num_complex_Complex<float> option = match v49 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v51 = v59 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v60 : num_complex_Complex<float> option = match v49 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v51 = v60 
        #endif
#else
        let v61 : num_complex_Complex<float> option = match v49 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v51 = v61 
        #endif
        let v62 : num_complex_Complex<float> option = _run_target_args'_v51 
        let v76 : (num_complex_Complex<float> -> US0) = method17()
        let v77 : US0 option = v62 |> Option.map v76 
        let v125 : US0 = US0_1
        let v126 : US0 = v77 |> Option.defaultValue v125 
        let v137 : string = "f64::NAN"
        let v138 : float = Fable.Core.RustInterop.emitRustExpr () v137 
        let v139 : string = "f64::NAN"
        let v140 : float = Fable.Core.RustInterop.emitRustExpr () v139 
        let v141 : string = "num_complex::Complex::new($0, $1)"
        let v142 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v138, v140) v141 
        let v145 : num_complex_Complex<float> =
            match v126 with
            | US0_1 -> (* None *)
                v142
            | US0_0(v143) -> (* Some *)
                v143
        let v146 : string = "num_complex::Complex::new($0, $1)"
        let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v146 
        let v148 : string = "$0 * $1"
        let v149 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v147, v1) v148 
        let v150 : string = "num_complex::Complex::new($0, $1)"
        let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v150 
        let v152 : string = "$0 / $1"
        let v153 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v149, v151) v152 
        let v154 : string = "$0.sin()"
        let v155 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v153 v154 
        let v156 : string = "$0.re"
        let v157 : float = Fable.Core.RustInterop.emitRustExpr v1 v156 
        let v158 : float = 1.0 - v157
        let v159 : string = "$0.im"
        let v160 : float = Fable.Core.RustInterop.emitRustExpr v1 v159 
        let v161 : float =  -v160
        let v162 : string = "num_complex::Complex::new($0, $1)"
        let v163 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v158, v161) v162 
        let v164 : string = "$0.re"
        let v165 : float = Fable.Core.RustInterop.emitRustExpr v163 v164 
        let v166 : bool = v165 <= 1.0
        let v901 : num_complex_Complex<float> =
            if v166 then
                let v167 : string = "num_complex::Complex::new($0, $1)"
                let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v167 
                v168
            else
                let v169 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v163) v169 
                let v170 : string = "$0.re"
                let v171 : float = Fable.Core.RustInterop.emitRustExpr v163 v170 
                let v172 : bool = v171 > 1.0
                if v172 then
                    let v173 : string = "num_complex::Complex::new($0, $1)"
                    let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v173 
                    let v175 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v176 : Mut0 = {l0 = 0} : Mut0
                    while method14(v176) do
                        let v178 : int32 = v176.l0
                        v175.[int v178] <- v178
                        let v179 : int32 = v178 + 1
                        v176.l0 <- v179
                        ()
                    let v180 : int32 = v175.Length
                    let v181 : Mut2 = {l0 = 0; l1 = v174} : Mut2
                    while method15(v180, v181) do
                        let v183 : int32 = v181.l0
                        let v184 : num_complex_Complex<float> = v181.l1
                        let v185 : int32 = v175.[int v183]
                        let v186 : string = "num_complex::Complex::new($0, $1)"
                        let v187 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v186 
                        let v189 : (int32 -> float) = float
                        let v190 : float = v189 v185
                        let v200 : string = "num_complex::Complex::new($0, $1)"
                        let v201 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v190, 0.0) v200 
                        let v202 : string = "num_complex::Complex::powc($0, $1)"
                        let v203 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v201, v163) v202 
                        let v204 : string = "$0 / $1"
                        let v205 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v187, v203) v204 
                        let v206 : string = "$0 + $1"
                        let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v184, v205) v206 
                        let v208 : int32 = v183 + 1
                        v181.l0 <- v208
                        v181.l1 <- v207
                        ()
                    let v209 : num_complex_Complex<float> = v181.l1
                    v209
                else
                    let v210 : string = "num_complex::Complex::new($0, $1)"
                    let v211 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v210 
                    let v212 : string = "$0 - $1"
                    let v213 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v211, v163) v212 
                    let v214 : string = $"        s = mpmath.gamma(s)"
                    let v215 : num_complex_Complex<float> = method3(v213)
                    let v216 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v214, v215)
                    (* run_target_args'
                    let v218 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v219 : string = "$0.ok()"
                    let v220 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v216 v219 
                    let _run_target_args'_v218 = v220 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v221 : string = "$0.ok()"
                    let v222 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v216 v221 
                    let _run_target_args'_v218 = v222 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v223 : string = "$0.ok()"
                    let v224 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v216 v223 
                    let _run_target_args'_v218 = v224 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v225 : num_complex_Complex<float> option = match v216 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v218 = v225 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v226 : num_complex_Complex<float> option = match v216 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v218 = v226 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v227 : num_complex_Complex<float> option = match v216 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v218 = v227 
                    #endif
#else
                    let v228 : num_complex_Complex<float> option = match v216 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v218 = v228 
                    #endif
                    let v229 : num_complex_Complex<float> option = _run_target_args'_v218 
                    let v243 : (num_complex_Complex<float> -> US0) = method17()
                    let v244 : US0 option = v229 |> Option.map v243 
                    let v292 : US0 = US0_1
                    let v293 : US0 = v244 |> Option.defaultValue v292 
                    let v304 : string = "f64::NAN"
                    let v305 : float = Fable.Core.RustInterop.emitRustExpr () v304 
                    let v306 : string = "f64::NAN"
                    let v307 : float = Fable.Core.RustInterop.emitRustExpr () v306 
                    let v308 : string = "num_complex::Complex::new($0, $1)"
                    let v309 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v305, v307) v308 
                    let v312 : num_complex_Complex<float> =
                        match v293 with
                        | US0_1 -> (* None *)
                            v309
                        | US0_0(v310) -> (* Some *)
                            v310
                    let v313 : string = "num_complex::Complex::new($0, $1)"
                    let v314 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v313 
                    let v315 : string = "$0 * $1"
                    let v316 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v314, v163) v315 
                    let v317 : string = "num_complex::Complex::new($0, $1)"
                    let v318 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v317 
                    let v319 : string = "$0 / $1"
                    let v320 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v316, v318) v319 
                    let v321 : string = "$0.sin()"
                    let v322 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v320 v321 
                    let v323 : string = "$0.re"
                    let v324 : float = Fable.Core.RustInterop.emitRustExpr v163 v323 
                    let v325 : float = 1.0 - v324
                    let v326 : string = "$0.im"
                    let v327 : float = Fable.Core.RustInterop.emitRustExpr v163 v326 
                    let v328 : float =  -v327
                    let v329 : string = "num_complex::Complex::new($0, $1)"
                    let v330 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v325, v328) v329 
                    let v331 : string = "$0.re"
                    let v332 : float = Fable.Core.RustInterop.emitRustExpr v330 v331 
                    let v333 : bool = v332 <= 1.0
                    let v885 : num_complex_Complex<float> =
                        if v333 then
                            let v334 : string = "num_complex::Complex::new($0, $1)"
                            let v335 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v334 
                            v335
                        else
                            let v336 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v330) v336 
                            let v337 : string = "$0.re"
                            let v338 : float = Fable.Core.RustInterop.emitRustExpr v330 v337 
                            let v339 : bool = v338 > 1.0
                            if v339 then
                                let v340 : string = "num_complex::Complex::new($0, $1)"
                                let v341 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v340 
                                let v342 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v343 : Mut0 = {l0 = 0} : Mut0
                                while method14(v343) do
                                    let v345 : int32 = v343.l0
                                    v342.[int v345] <- v345
                                    let v346 : int32 = v345 + 1
                                    v343.l0 <- v346
                                    ()
                                let v347 : int32 = v342.Length
                                let v348 : Mut2 = {l0 = 0; l1 = v341} : Mut2
                                while method15(v347, v348) do
                                    let v350 : int32 = v348.l0
                                    let v351 : num_complex_Complex<float> = v348.l1
                                    let v352 : int32 = v342.[int v350]
                                    let v353 : string = "num_complex::Complex::new($0, $1)"
                                    let v354 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v353 
                                    let v356 : (int32 -> float) = float
                                    let v357 : float = v356 v352
                                    let v367 : string = "num_complex::Complex::new($0, $1)"
                                    let v368 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v357, 0.0) v367 
                                    let v369 : string = "num_complex::Complex::powc($0, $1)"
                                    let v370 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v368, v330) v369 
                                    let v371 : string = "$0 / $1"
                                    let v372 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v354, v370) v371 
                                    let v373 : string = "$0 + $1"
                                    let v374 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v351, v372) v373 
                                    let v375 : int32 = v350 + 1
                                    v348.l0 <- v375
                                    v348.l1 <- v374
                                    ()
                                let v376 : num_complex_Complex<float> = v348.l1
                                v376
                            else
                                let v377 : string = "num_complex::Complex::new($0, $1)"
                                let v378 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v377 
                                let v379 : string = "$0 - $1"
                                let v380 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v378, v330) v379 
                                let v381 : string = $"        s = mpmath.gamma(s)"
                                let v382 : num_complex_Complex<float> = method3(v380)
                                let v383 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v381, v382)
                                (* run_target_args'
                                let v385 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v386 : string = "$0.ok()"
                                let v387 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v383 v386 
                                let _run_target_args'_v385 = v387 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v388 : string = "$0.ok()"
                                let v389 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v383 v388 
                                let _run_target_args'_v385 = v389 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v390 : string = "$0.ok()"
                                let v391 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v383 v390 
                                let _run_target_args'_v385 = v391 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v392 : num_complex_Complex<float> option = match v383 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v385 = v392 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v393 : num_complex_Complex<float> option = match v383 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v385 = v393 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v394 : num_complex_Complex<float> option = match v383 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v385 = v394 
                                #endif
#else
                                let v395 : num_complex_Complex<float> option = match v383 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v385 = v395 
                                #endif
                                let v396 : num_complex_Complex<float> option = _run_target_args'_v385 
                                let v410 : (num_complex_Complex<float> -> US0) = method17()
                                let v411 : US0 option = v396 |> Option.map v410 
                                let v459 : US0 = US0_1
                                let v460 : US0 = v411 |> Option.defaultValue v459 
                                let v471 : string = "f64::NAN"
                                let v472 : float = Fable.Core.RustInterop.emitRustExpr () v471 
                                let v473 : string = "f64::NAN"
                                let v474 : float = Fable.Core.RustInterop.emitRustExpr () v473 
                                let v475 : string = "num_complex::Complex::new($0, $1)"
                                let v476 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v472, v474) v475 
                                let v479 : num_complex_Complex<float> =
                                    match v460 with
                                    | US0_1 -> (* None *)
                                        v476
                                    | US0_0(v477) -> (* Some *)
                                        v477
                                let v480 : string = "num_complex::Complex::new($0, $1)"
                                let v481 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v480 
                                let v482 : string = "$0 * $1"
                                let v483 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v481, v330) v482 
                                let v484 : string = "num_complex::Complex::new($0, $1)"
                                let v485 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v484 
                                let v486 : string = "$0 / $1"
                                let v487 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v483, v485) v486 
                                let v488 : string = "$0.sin()"
                                let v489 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v487 v488 
                                let v490 : string = "$0.re"
                                let v491 : float = Fable.Core.RustInterop.emitRustExpr v330 v490 
                                let v492 : float = 1.0 - v491
                                let v493 : string = "$0.im"
                                let v494 : float = Fable.Core.RustInterop.emitRustExpr v330 v493 
                                let v495 : float =  -v494
                                let v496 : string = "num_complex::Complex::new($0, $1)"
                                let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v492, v495) v496 
                                let v498 : string = "$0.re"
                                let v499 : float = Fable.Core.RustInterop.emitRustExpr v497 v498 
                                let v500 : bool = v499 <= 1.0
                                let v869 : num_complex_Complex<float> =
                                    if v500 then
                                        let v501 : string = "num_complex::Complex::new($0, $1)"
                                        let v502 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v501 
                                        v502
                                    else
                                        let v503 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v497) v503 
                                        let v504 : string = "$0.re"
                                        let v505 : float = Fable.Core.RustInterop.emitRustExpr v497 v504 
                                        let v506 : bool = v505 > 1.0
                                        if v506 then
                                            let v507 : string = "num_complex::Complex::new($0, $1)"
                                            let v508 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v507 
                                            let v509 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v510 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v510) do
                                                let v512 : int32 = v510.l0
                                                v509.[int v512] <- v512
                                                let v513 : int32 = v512 + 1
                                                v510.l0 <- v513
                                                ()
                                            let v514 : int32 = v509.Length
                                            let v515 : Mut2 = {l0 = 0; l1 = v508} : Mut2
                                            while method15(v514, v515) do
                                                let v517 : int32 = v515.l0
                                                let v518 : num_complex_Complex<float> = v515.l1
                                                let v519 : int32 = v509.[int v517]
                                                let v520 : string = "num_complex::Complex::new($0, $1)"
                                                let v521 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v520 
                                                let v523 : (int32 -> float) = float
                                                let v524 : float = v523 v519
                                                let v534 : string = "num_complex::Complex::new($0, $1)"
                                                let v535 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v524, 0.0) v534 
                                                let v536 : string = "num_complex::Complex::powc($0, $1)"
                                                let v537 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v535, v497) v536 
                                                let v538 : string = "$0 / $1"
                                                let v539 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v521, v537) v538 
                                                let v540 : string = "$0 + $1"
                                                let v541 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v518, v539) v540 
                                                let v542 : int32 = v517 + 1
                                                v515.l0 <- v542
                                                v515.l1 <- v541
                                                ()
                                            let v543 : num_complex_Complex<float> = v515.l1
                                            v543
                                        else
                                            let v544 : string = "num_complex::Complex::new($0, $1)"
                                            let v545 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v544 
                                            let v546 : string = "$0 - $1"
                                            let v547 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v545, v497) v546 
                                            let v548 : string = $"        s = mpmath.gamma(s)"
                                            let v549 : num_complex_Complex<float> = method3(v547)
                                            let v550 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v548, v549)
                                            (* run_target_args'
                                            let v552 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v553 : string = "$0.ok()"
                                            let v554 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v550 v553 
                                            let _run_target_args'_v552 = v554 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v555 : string = "$0.ok()"
                                            let v556 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v550 v555 
                                            let _run_target_args'_v552 = v556 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v557 : string = "$0.ok()"
                                            let v558 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v550 v557 
                                            let _run_target_args'_v552 = v558 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v559 : num_complex_Complex<float> option = match v550 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v552 = v559 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v560 : num_complex_Complex<float> option = match v550 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v552 = v560 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v561 : num_complex_Complex<float> option = match v550 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v552 = v561 
                                            #endif
#else
                                            let v562 : num_complex_Complex<float> option = match v550 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v552 = v562 
                                            #endif
                                            let v563 : num_complex_Complex<float> option = _run_target_args'_v552 
                                            let v577 : (num_complex_Complex<float> -> US0) = method17()
                                            let v578 : US0 option = v563 |> Option.map v577 
                                            let v626 : US0 = US0_1
                                            let v627 : US0 = v578 |> Option.defaultValue v626 
                                            let v638 : string = "f64::NAN"
                                            let v639 : float = Fable.Core.RustInterop.emitRustExpr () v638 
                                            let v640 : string = "f64::NAN"
                                            let v641 : float = Fable.Core.RustInterop.emitRustExpr () v640 
                                            let v642 : string = "num_complex::Complex::new($0, $1)"
                                            let v643 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v639, v641) v642 
                                            let v646 : num_complex_Complex<float> =
                                                match v627 with
                                                | US0_1 -> (* None *)
                                                    v643
                                                | US0_0(v644) -> (* Some *)
                                                    v644
                                            let v647 : string = "num_complex::Complex::new($0, $1)"
                                            let v648 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v647 
                                            let v649 : string = "$0 * $1"
                                            let v650 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v648, v497) v649 
                                            let v651 : string = "num_complex::Complex::new($0, $1)"
                                            let v652 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v651 
                                            let v653 : string = "$0 / $1"
                                            let v654 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v650, v652) v653 
                                            let v655 : string = "$0.sin()"
                                            let v656 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v654 v655 
                                            let v657 : string = "$0.re"
                                            let v658 : float = Fable.Core.RustInterop.emitRustExpr v497 v657 
                                            let v659 : float = 1.0 - v658
                                            let v660 : string = "$0.im"
                                            let v661 : float = Fable.Core.RustInterop.emitRustExpr v497 v660 
                                            let v662 : float =  -v661
                                            let v663 : string = "num_complex::Complex::new($0, $1)"
                                            let v664 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v659, v662) v663 
                                            let v665 : string = "$0.re"
                                            let v666 : float = Fable.Core.RustInterop.emitRustExpr v664 v665 
                                            let v667 : bool = v666 <= 1.0
                                            let v853 : num_complex_Complex<float> =
                                                if v667 then
                                                    let v668 : string = "num_complex::Complex::new($0, $1)"
                                                    let v669 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v668 
                                                    v669
                                                else
                                                    let v670 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v664) v670 
                                                    let v671 : string = "$0.re"
                                                    let v672 : float = Fable.Core.RustInterop.emitRustExpr v664 v671 
                                                    let v673 : bool = v672 > 1.0
                                                    if v673 then
                                                        let v674 : string = "num_complex::Complex::new($0, $1)"
                                                        let v675 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v674 
                                                        let v676 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v677 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v677) do
                                                            let v679 : int32 = v677.l0
                                                            v676.[int v679] <- v679
                                                            let v680 : int32 = v679 + 1
                                                            v677.l0 <- v680
                                                            ()
                                                        let v681 : int32 = v676.Length
                                                        let v682 : Mut2 = {l0 = 0; l1 = v675} : Mut2
                                                        while method15(v681, v682) do
                                                            let v684 : int32 = v682.l0
                                                            let v685 : num_complex_Complex<float> = v682.l1
                                                            let v686 : int32 = v676.[int v684]
                                                            let v687 : string = "num_complex::Complex::new($0, $1)"
                                                            let v688 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v687 
                                                            let v690 : (int32 -> float) = float
                                                            let v691 : float = v690 v686
                                                            let v701 : string = "num_complex::Complex::new($0, $1)"
                                                            let v702 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v691, 0.0) v701 
                                                            let v703 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v704 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v702, v664) v703 
                                                            let v705 : string = "$0 / $1"
                                                            let v706 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v688, v704) v705 
                                                            let v707 : string = "$0 + $1"
                                                            let v708 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v685, v706) v707 
                                                            let v709 : int32 = v684 + 1
                                                            v682.l0 <- v709
                                                            v682.l1 <- v708
                                                            ()
                                                        let v710 : num_complex_Complex<float> = v682.l1
                                                        v710
                                                    else
                                                        let v711 : string = "num_complex::Complex::new($0, $1)"
                                                        let v712 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v711 
                                                        let v713 : string = "$0 - $1"
                                                        let v714 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v712, v664) v713 
                                                        let v715 : string = $"        s = mpmath.gamma(s)"
                                                        let v716 : num_complex_Complex<float> = method3(v714)
                                                        let v717 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v715, v716)
                                                        (* run_target_args'
                                                        let v719 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v720 : string = "$0.ok()"
                                                        let v721 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v717 v720 
                                                        let _run_target_args'_v719 = v721 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v722 : string = "$0.ok()"
                                                        let v723 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v717 v722 
                                                        let _run_target_args'_v719 = v723 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v724 : string = "$0.ok()"
                                                        let v725 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v717 v724 
                                                        let _run_target_args'_v719 = v725 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v726 : num_complex_Complex<float> option = match v717 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v719 = v726 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v727 : num_complex_Complex<float> option = match v717 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v719 = v727 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v728 : num_complex_Complex<float> option = match v717 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v719 = v728 
                                                        #endif
#else
                                                        let v729 : num_complex_Complex<float> option = match v717 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v719 = v729 
                                                        #endif
                                                        let v730 : num_complex_Complex<float> option = _run_target_args'_v719 
                                                        let v744 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v745 : US0 option = v730 |> Option.map v744 
                                                        let v793 : US0 = US0_1
                                                        let v794 : US0 = v745 |> Option.defaultValue v793 
                                                        let v805 : string = "f64::NAN"
                                                        let v806 : float = Fable.Core.RustInterop.emitRustExpr () v805 
                                                        let v807 : string = "f64::NAN"
                                                        let v808 : float = Fable.Core.RustInterop.emitRustExpr () v807 
                                                        let v809 : string = "num_complex::Complex::new($0, $1)"
                                                        let v810 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v806, v808) v809 
                                                        let v813 : num_complex_Complex<float> =
                                                            match v794 with
                                                            | US0_1 -> (* None *)
                                                                v810
                                                            | US0_0(v811) -> (* Some *)
                                                                v811
                                                        let v814 : string = "num_complex::Complex::new($0, $1)"
                                                        let v815 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v814 
                                                        let v816 : string = "$0 * $1"
                                                        let v817 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v815, v664) v816 
                                                        let v818 : string = "num_complex::Complex::new($0, $1)"
                                                        let v819 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v818 
                                                        let v820 : string = "$0 / $1"
                                                        let v821 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v817, v819) v820 
                                                        let v822 : string = "$0.sin()"
                                                        let v823 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v821 v822 
                                                        let v824 : string = "$0.re"
                                                        let v825 : float = Fable.Core.RustInterop.emitRustExpr v664 v824 
                                                        let v826 : float = 1.0 - v825
                                                        let v827 : string = "$0.im"
                                                        let v828 : float = Fable.Core.RustInterop.emitRustExpr v664 v827 
                                                        let v829 : float =  -v828
                                                        let v830 : string = "num_complex::Complex::new($0, $1)"
                                                        let v831 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v826, v829) v830 
                                                        let v832 : string = "$0.re"
                                                        let v833 : float = Fable.Core.RustInterop.emitRustExpr v831 v832 
                                                        let v834 : bool = v833 <= 1.0
                                                        let v837 : num_complex_Complex<float> =
                                                            if v834 then
                                                                let v835 : string = "num_complex::Complex::new($0, $1)"
                                                                let v836 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v835 
                                                                v836
                                                            else
                                                                v831
                                                        let v838 : string = "num_complex::Complex::new($0, $1)"
                                                        let v839 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v838 
                                                        let v840 : string = "num_complex::Complex::new($0, $1)"
                                                        let v841 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v840 
                                                        let v842 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v843 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v841, v664) v842 
                                                        let v844 : string = "$0 * $1"
                                                        let v845 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v839, v843) v844 
                                                        let v846 : string = "$0 * $1"
                                                        let v847 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v845, v823) v846 
                                                        let v848 : string = "$0 * $1"
                                                        let v849 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v847, v813) v848 
                                                        let v850 : string = "$0 * $1"
                                                        let v851 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v849, v837) v850 
                                                        v851
                                            let v854 : string = "num_complex::Complex::new($0, $1)"
                                            let v855 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v854 
                                            let v856 : string = "num_complex::Complex::new($0, $1)"
                                            let v857 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v856 
                                            let v858 : string = "num_complex::Complex::powc($0, $1)"
                                            let v859 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v857, v497) v858 
                                            let v860 : string = "$0 * $1"
                                            let v861 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v855, v859) v860 
                                            let v862 : string = "$0 * $1"
                                            let v863 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v861, v656) v862 
                                            let v864 : string = "$0 * $1"
                                            let v865 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v863, v646) v864 
                                            let v866 : string = "$0 * $1"
                                            let v867 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v865, v853) v866 
                                            v867
                                let v870 : string = "num_complex::Complex::new($0, $1)"
                                let v871 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v870 
                                let v872 : string = "num_complex::Complex::new($0, $1)"
                                let v873 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v872 
                                let v874 : string = "num_complex::Complex::powc($0, $1)"
                                let v875 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v873, v330) v874 
                                let v876 : string = "$0 * $1"
                                let v877 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v871, v875) v876 
                                let v878 : string = "$0 * $1"
                                let v879 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v877, v489) v878 
                                let v880 : string = "$0 * $1"
                                let v881 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v879, v479) v880 
                                let v882 : string = "$0 * $1"
                                let v883 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v881, v869) v882 
                                v883
                    let v886 : string = "num_complex::Complex::new($0, $1)"
                    let v887 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v886 
                    let v888 : string = "num_complex::Complex::new($0, $1)"
                    let v889 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v888 
                    let v890 : string = "num_complex::Complex::powc($0, $1)"
                    let v891 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v889, v163) v890 
                    let v892 : string = "$0 * $1"
                    let v893 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v887, v891) v892 
                    let v894 : string = "$0 * $1"
                    let v895 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v893, v322) v894 
                    let v896 : string = "$0 * $1"
                    let v897 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v895, v312) v896 
                    let v898 : string = "$0 * $1"
                    let v899 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v897, v885) v898 
                    v899
        let v902 : string = "num_complex::Complex::new($0, $1)"
        let v903 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v902 
        let v904 : string = "num_complex::Complex::new($0, $1)"
        let v905 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v904 
        let v906 : string = "num_complex::Complex::powc($0, $1)"
        let v907 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v905, v1) v906 
        let v908 : string = "$0 * $1"
        let v909 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v903, v907) v908 
        let v910 : string = "$0 * $1"
        let v911 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v909, v155) v910 
        let v912 : string = "$0 * $1"
        let v913 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v911, v145) v912 
        let v914 : string = "$0 * $1"
        let v915 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v913, v901) v914 
        v915
and method18 (v0 : bool) : bool =
    v0
and method20 () : string =
    let v0 : string = ""
    v0
and method21 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "{ "
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method22 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "expected"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method23 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = " = "
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method24 (v0 : Mut3, v1 : string) : unit =
    let v2 : string = v0.l0
    let v4 : string = v2 + v1 
    v0.l0 <- v4
    ()
and method25 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = " }"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method19 (v0 : float) : string =
    let v1 : string = method20()
    let v10 : Mut3 = {l0 = v1} : Mut3
    method21(v10)
    method22(v10)
    method23(v10)
    let v154 : string = $"%+.6f{v0}"
    method24(v10, v154)
    method25(v10)
    let v243 : string = v10.l0
    v243
and method27 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "actual"
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method28 (v0 : Mut3) : unit =
    let v1 : string = v0.l0
    let v4 : string = "; "
    let v5 : string = v1 + v4 
    v0.l0 <- v5
    ()
and method26 (v0 : float, v1 : float) : string =
    let v2 : string = method20()
    let v11 : Mut3 = {l0 = v2} : Mut3
    method21(v11)
    method27(v11)
    method23(v11)
    let v155 : string = $"%+.6f{v0}"
    method24(v11, v155)
    method28(v11)
    method22(v11)
    method23(v11)
    let v343 : string = $"%+.6f{v1}"
    method24(v11, v343)
    method25(v11)
    let v432 : string = v11.l0
    v432
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
        let v17 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v18 : string = "$0.ok()"
        let v19 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v18 
        let _run_target_args'_v17 = v19 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v20 : string = "$0.ok()"
        let v21 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v20 
        let _run_target_args'_v17 = v21 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v22 : string = "$0.ok()"
        let v23 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v14 v22 
        let _run_target_args'_v17 = v23 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v24 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v17 = v24 
        #endif
#if FABLE_COMPILER_PYTHON
        let v25 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v17 = v25 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v26 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v17 = v26 
        #endif
#else
        let v27 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v17 = v27 
        #endif
        let v28 : num_complex_Complex<float> option = _run_target_args'_v17 
        let v42 : (num_complex_Complex<float> -> US0) = method17()
        let v43 : US0 option = v28 |> Option.map v42 
        let v91 : US0 = US0_1
        let v92 : US0 = v43 |> Option.defaultValue v91 
        let v103 : string = "f64::NAN"
        let v104 : float = Fable.Core.RustInterop.emitRustExpr () v103 
        let v105 : string = "f64::NAN"
        let v106 : float = Fable.Core.RustInterop.emitRustExpr () v105 
        let v107 : string = "num_complex::Complex::new($0, $1)"
        let v108 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v104, v106) v107 
        let v111 : num_complex_Complex<float> =
            match v92 with
            | US0_1 -> (* None *)
                v108
            | US0_0(v109) -> (* Some *)
                v109
        let v112 : string = "$0.im"
        let v113 : float = Fable.Core.RustInterop.emitRustExpr v111 v112 
        let v114 : bool = v113 = 0.0
        let v116 : bool =
            if v114 then
                true
            else
                method18(v114)
        let v121 : string =
            if v114 then
                let v117 : float = 0.0
                method19(v117)
            else
                let v119 : float = 0.0
                method26(v113, v119)
        let v125 : string = "__assert_eq"
        let v126 : string = " "
        let v127 : string = v125 + v126 
        let v141 : string =
            if v114 then
                let v137 : float = 0.0
                method19(v137)
            else
                let v139 : float = 0.0
                method26(v113, v139)
        let v143 : string = v127 + v141 
        let v172 : unit = ()
        let v173 : (unit -> unit) = closure2(v143)
        let v174 : unit = (fun () -> v173 (); v172) ()
        let v184 : bool = v116 = false
        if v184 then
            failwith<unit> v143
        let v185 : string = "$0.re"
        let v186 : float = Fable.Core.RustInterop.emitRustExpr v111 v185 
        let v187 : float = v186 - v11
        let v188 : float =  -v187
        let v189 : bool = v187 >= v188
        let v190 : float =
            if v189 then
                v187
            else
                v188
        let v191 : bool = v190 < 0.0001
        let v193 : bool =
            if v191 then
                true
            else
                method18(v191)
        let v198 : string =
            if v191 then
                let v194 : float = 0.0001
                method19(v194)
            else
                let v196 : float = 0.0001
                method26(v190, v196)
        let v201 : string = "__assert_lt"
        let v202 : string = v201 + v126 
        let v216 : string =
            if v191 then
                let v212 : float = 0.0001
                method19(v212)
            else
                let v214 : float = 0.0001
                method26(v190, v214)
        let v218 : string = v202 + v216 
        let v247 : unit = ()
        let v248 : (unit -> unit) = closure2(v218)
        let v249 : unit = (fun () -> v248 (); v247) ()
        let v259 : bool = v193 = false
        if v259 then
            failwith<unit> v218
        let v260 : int32 = v9 + 1
        v7.l0 <- v260
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method31 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, -2.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.ok()"
    let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v8 
    let v33 : (num_complex_Complex<float> -> US0) = method17()
    let v34 : US0 option = v19 |> Option.map v33 
    let v82 : US0 = US0_1
    let v83 : US0 = v34 |> Option.defaultValue v82 
    let v94 : string = "f64::NAN"
    let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "f64::NAN"
    let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96 
    let v98 : string = "num_complex::Complex::new($0, $1)"
    let v99 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v95, v97) v98 
    let v102 : num_complex_Complex<float> =
        match v83 with
        | US0_1 -> (* None *)
            v99
        | US0_0(v100) -> (* Some *)
            v100
    let v103 : string = "$0.re"
    let v104 : float = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : float = v104 - 0.8673
    let v106 : float =  -v105
    let v107 : bool = v105 >= v106
    let v108 : float =
        if v107 then
            v105
        else
            v106
    let v109 : bool = v108 < 0.001
    let v111 : bool =
        if v109 then
            true
        else
            method18(v109)
    let v116 : string =
        if v109 then
            let v112 : float = 0.001
            method19(v112)
        else
            let v114 : float = 0.001
            method26(v108, v114)
    let v120 : string = "__assert_lt"
    let v121 : string = " "
    let v122 : string = v120 + v121 
    let v136 : string =
        if v109 then
            let v132 : float = 0.001
            method19(v132)
        else
            let v134 : float = 0.001
            method26(v108, v134)
    let v138 : string = v122 + v136 
    let v167 : unit = ()
    let v168 : (unit -> unit) = closure2(v138)
    let v169 : unit = (fun () -> v168 (); v167) ()
    let v179 : bool = v111 = false
    if v179 then
        failwith<unit> v138
    let v180 : string = "$0.im"
    let v181 : float = Fable.Core.RustInterop.emitRustExpr v102 v180 
    let v182 : float = v181 - 0.275
    let v183 : float =  -v182
    let v184 : bool = v182 >= v183
    let v185 : float =
        if v184 then
            v182
        else
            v183
    let v186 : bool = v185 < 0.001
    let v188 : bool =
        if v186 then
            true
        else
            method18(v186)
    let v193 : string =
        if v186 then
            let v189 : float = 0.001
            method19(v189)
        else
            let v191 : float = 0.001
            method26(v185, v191)
    let v195 : string = v120 + v121 
    let v209 : string =
        if v186 then
            let v205 : float = 0.001
            method19(v205)
        else
            let v207 : float = 0.001
            method26(v185, v207)
    let v211 : string = v195 + v209 
    let v240 : unit = ()
    let v241 : (unit -> unit) = closure2(v211)
    let v242 : unit = (fun () -> v241 (); v240) ()
    let v252 : bool = v188 = false
    if v252 then
        failwith<unit> v211
and method30 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v11 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v12 
        let _run_target_args'_v11 = v13 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v14 
        let _run_target_args'_v11 = v15 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v16 
        let _run_target_args'_v11 = v17 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v18 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v18 
        #endif
#if FABLE_COMPILER_PYTHON
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v19 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v20 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v20 
        #endif
#else
        let v21 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v21 
        #endif
        let v22 : num_complex_Complex<float> option = _run_target_args'_v11 
        let v36 : (num_complex_Complex<float> -> US0) = method17()
        let v37 : US0 option = v22 |> Option.map v36 
        let v85 : US0 = US0_1
        let v86 : US0 = v37 |> Option.defaultValue v85 
        let v97 : string = "f64::NAN"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr () v97 
        let v99 : string = "f64::NAN"
        let v100 : float = Fable.Core.RustInterop.emitRustExpr () v99 
        let v101 : string = "num_complex::Complex::new($0, $1)"
        let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v98, v100) v101 
        let v105 : num_complex_Complex<float> =
            match v86 with
            | US0_1 -> (* None *)
                v102
            | US0_0(v103) -> (* Some *)
                v103
        let v106 : string = "$0.re"
        let v107 : float = Fable.Core.RustInterop.emitRustExpr v105 v106 
        let v108 : bool = v107 = 0.0
        let v110 : bool =
            if v108 then
                true
            else
                method18(v108)
        let v115 : string =
            if v108 then
                let v111 : float = 0.0
                method19(v111)
            else
                let v113 : float = 0.0
                method26(v107, v113)
        let v119 : string = "__assert_eq"
        let v120 : string = " "
        let v121 : string = v119 + v120 
        let v135 : string =
            if v108 then
                let v131 : float = 0.0
                method19(v131)
            else
                let v133 : float = 0.0
                method26(v107, v133)
        let v137 : string = v121 + v135 
        let v166 : unit = ()
        let v167 : (unit -> unit) = closure2(v137)
        let v168 : unit = (fun () -> v167 (); v166) ()
        let v178 : bool = v110 = false
        if v178 then
            failwith<unit> v137
        let v179 : string = "$0.im"
        let v180 : float = Fable.Core.RustInterop.emitRustExpr v105 v179 
        let v181 : bool = v180 = 0.0
        let v183 : bool =
            if v181 then
                true
            else
                method18(v181)
        let v188 : string =
            if v181 then
                let v184 : float = 0.0
                method19(v184)
            else
                let v186 : float = 0.0
                method26(v180, v186)
        let v190 : string = v119 + v120 
        let v204 : string =
            if v181 then
                let v200 : float = 0.0
                method19(v200)
            else
                let v202 : float = 0.0
                method26(v180, v202)
        let v206 : string = v190 + v204 
        let v235 : unit = ()
        let v236 : (unit -> unit) = closure2(v206)
        let v237 : unit = (fun () -> v236 (); v235) ()
        let v247 : bool = v183 = false
        if v247 then
            failwith<unit> v206
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v24 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v25 : string = "$0.ok()"
        let v26 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v25 
        let _run_target_args'_v24 = v26 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v27 : string = "$0.ok()"
        let v28 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v27 
        let _run_target_args'_v24 = v28 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v29 : string = "$0.ok()"
        let v30 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v21 v29 
        let _run_target_args'_v24 = v30 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v31 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v24 = v31 
        #endif
#if FABLE_COMPILER_PYTHON
        let v32 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v24 = v32 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v33 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v24 = v33 
        #endif
#else
        let v34 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v24 = v34 
        #endif
        let v35 : num_complex_Complex<float> option = _run_target_args'_v24 
        let v49 : (num_complex_Complex<float> -> US0) = method17()
        let v50 : US0 option = v35 |> Option.map v49 
        let v98 : US0 = US0_1
        let v99 : US0 = v50 |> Option.defaultValue v98 
        let v110 : string = "f64::NAN"
        let v111 : float = Fable.Core.RustInterop.emitRustExpr () v110 
        let v112 : string = "f64::NAN"
        let v113 : float = Fable.Core.RustInterop.emitRustExpr () v112 
        let v114 : string = "num_complex::Complex::new($0, $1)"
        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v111, v113) v114 
        let v118 : num_complex_Complex<float> =
            match v99 with
            | US0_1 -> (* None *)
                v115
            | US0_0(v116) -> (* Some *)
                v116
        let v119 : string = "$0.re"
        let v120 : float = Fable.Core.RustInterop.emitRustExpr v118 v119 
        let v121 : float =  -v120
        let v122 : bool = v120 >= v121
        let v123 : float =
            if v122 then
                v120
            else
                v121
        let v124 : bool = v123 < 0.0001
        let v126 : bool =
            if v124 then
                true
            else
                method18(v124)
        let v131 : string =
            if v124 then
                let v127 : float = 0.0001
                method19(v127)
            else
                let v129 : float = 0.0001
                method26(v123, v129)
        let v135 : string = "__assert_lt"
        let v136 : string = " "
        let v137 : string = v135 + v136 
        let v151 : string =
            if v124 then
                let v147 : float = 0.0001
                method19(v147)
            else
                let v149 : float = 0.0001
                method26(v123, v149)
        let v153 : string = v137 + v151 
        let v182 : unit = ()
        let v183 : (unit -> unit) = closure2(v153)
        let v184 : unit = (fun () -> v183 (); v182) ()
        let v194 : bool = v126 = false
        if v194 then
            failwith<unit> v153
        let v195 : string = "$0.im"
        let v196 : float = Fable.Core.RustInterop.emitRustExpr v118 v195 
        let v197 : float =  -v196
        let v198 : bool = v196 >= v197
        let v199 : float =
            if v198 then
                v196
            else
                v197
        let v200 : bool = v199 < 0.0001
        let v202 : bool =
            if v200 then
                true
            else
                method18(v200)
        let v207 : string =
            if v200 then
                let v203 : float = 0.0001
                method19(v203)
            else
                let v205 : float = 0.0001
                method26(v199, v205)
        let v209 : string = v135 + v136 
        let v223 : string =
            if v200 then
                let v219 : float = 0.0001
                method19(v219)
            else
                let v221 : float = 0.0001
                method26(v199, v221)
        let v225 : string = v209 + v223 
        let v254 : unit = ()
        let v255 : (unit -> unit) = closure2(v225)
        let v256 : unit = (fun () -> v255 (); v254) ()
        let v266 : bool = v202 = false
        if v266 then
            failwith<unit> v225
        let v267 : int32 = v17 + 1
        v15.l0 <- v267
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v14 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v15 
        let _run_target_args'_v14 = v16 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v17 
        let _run_target_args'_v14 = v18 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v19 : string = "$0.ok()"
        let v20 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v19 
        let _run_target_args'_v14 = v20 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v21 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v21 
        #endif
#if FABLE_COMPILER_PYTHON
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v22 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v23 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v23 
        #endif
#else
        let v24 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v24 
        #endif
        let v25 : num_complex_Complex<float> option = _run_target_args'_v14 
        let v39 : (num_complex_Complex<float> -> US0) = method17()
        let v40 : US0 option = v25 |> Option.map v39 
        let v88 : US0 = US0_1
        let v89 : US0 = v40 |> Option.defaultValue v88 
        let v100 : string = "f64::NAN"
        let v101 : float = Fable.Core.RustInterop.emitRustExpr () v100 
        let v102 : string = "f64::NAN"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102 
        let v104 : string = "num_complex::Complex::new($0, $1)"
        let v105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v101, v103) v104 
        let v108 : num_complex_Complex<float> =
            match v89 with
            | US0_1 -> (* None *)
                v105
            | US0_0(v106) -> (* Some *)
                v106
        let v109 : string = "$0.re"
        let v110 : float = Fable.Core.RustInterop.emitRustExpr v108 v109 
        let v111 : bool = v110 > 0.0
        let v113 : bool =
            if v111 then
                true
            else
                method18(v111)
        let v118 : string =
            if v111 then
                let v114 : float = 0.0
                method19(v114)
            else
                let v116 : float = 0.0
                method26(v110, v116)
        let v122 : string = "__assert_gt"
        let v123 : string = " "
        let v124 : string = v122 + v123 
        let v138 : string =
            if v111 then
                let v134 : float = 0.0
                method19(v134)
            else
                let v136 : float = 0.0
                method26(v110, v136)
        let v140 : string = v124 + v138 
        let v169 : unit = ()
        let v170 : (unit -> unit) = closure2(v140)
        let v171 : unit = (fun () -> v170 (); v169) ()
        let v181 : bool = v113 = false
        if v181 then
            failwith<unit> v140
        let v182 : string = "$0.im"
        let v183 : float = Fable.Core.RustInterop.emitRustExpr v108 v182 
        let v184 : bool = v183 = 0.0
        let v186 : bool =
            if v184 then
                true
            else
                method18(v184)
        let v191 : string =
            if v184 then
                let v187 : float = 0.0
                method19(v187)
            else
                let v189 : float = 0.0
                method26(v183, v189)
        let v194 : string = "__assert_eq"
        let v195 : string = v194 + v123 
        let v209 : string =
            if v184 then
                let v205 : float = 0.0
                method19(v205)
            else
                let v207 : float = 0.0
                method26(v183, v207)
        let v211 : string = v195 + v209 
        let v240 : unit = ()
        let v241 : (unit -> unit) = closure2(v211)
        let v242 : unit = (fun () -> v241 (); v240) ()
        let v252 : bool = v186 = false
        if v252 then
            failwith<unit> v211
        let v253 : int32 = v5 + 1
        v3.l0 <- v253
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method41 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.ok()"
    let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v8 
    let v33 : (num_complex_Complex<float> -> US0) = method17()
    let v34 : US0 option = v19 |> Option.map v33 
    let v82 : US0 = US0_1
    let v83 : US0 = v34 |> Option.defaultValue v82 
    let v94 : string = "f64::NAN"
    let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "f64::NAN"
    let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96 
    let v98 : string = "num_complex::Complex::new($0, $1)"
    let v99 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v95, v97) v98 
    let v102 : num_complex_Complex<float> =
        match v83 with
        | US0_1 -> (* None *)
            v99
        | US0_0(v100) -> (* Some *)
            v100
    let v103 : string = "$0.re"
    let v104 : float = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : bool = v104 = infinity
    let v107 : bool =
        if v105 then
            true
        else
            method18(v105)
    let v112 : string =
        if v105 then
            let v108 : float = infinity
            method19(v108)
        else
            let v110 : float = infinity
            method26(v104, v110)
    let v116 : string = "__assert_eq"
    let v117 : string = " "
    let v118 : string = v116 + v117 
    let v132 : string =
        if v105 then
            let v128 : float = infinity
            method19(v128)
        else
            let v130 : float = infinity
            method26(v104, v130)
    let v134 : string = v118 + v132 
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure2(v134)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v175 : bool = v107 = false
    if v175 then
        failwith<unit> v134
    let v176 : string = "$0.im"
    let v177 : float = Fable.Core.RustInterop.emitRustExpr v102 v176 
    let v178 : bool = v177 = 0.0
    let v180 : bool =
        if v178 then
            true
        else
            method18(v178)
    let v185 : string =
        if v178 then
            let v181 : float = 0.0
            method19(v181)
        else
            let v183 : float = 0.0
            method26(v177, v183)
    let v187 : string = v116 + v117 
    let v201 : string =
        if v178 then
            let v197 : float = 0.0
            method19(v197)
        else
            let v199 : float = 0.0
            method26(v177, v199)
    let v203 : string = v187 + v201 
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure2(v203)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v244 : bool = v180 = false
    if v244 then
        failwith<unit> v203
and method40 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method41(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method43 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 10.0) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.ok()"
    let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v8 
    let v33 : (num_complex_Complex<float> -> US0) = method17()
    let v34 : US0 option = v19 |> Option.map v33 
    let v82 : US0 = US0_1
    let v83 : US0 = v34 |> Option.defaultValue v82 
    let v94 : string = "f64::NAN"
    let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "f64::NAN"
    let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96 
    let v98 : string = "num_complex::Complex::new($0, $1)"
    let v99 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v95, v97) v98 
    let v102 : num_complex_Complex<float> =
        match v83 with
        | US0_1 -> (* None *)
            v99
        | US0_0(v100) -> (* Some *)
            v100
    let v103 : string = "$0.re"
    let v104 : float = Fable.Core.RustInterop.emitRustExpr v2 v103 
    let v105 : string = "$0.im"
    let v106 : float = Fable.Core.RustInterop.emitRustExpr v2 v105 
    let v107 : float =  -v106
    let v108 : string = "num_complex::Complex::new($0, $1)"
    let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v104, v107) v108 
    let v110 : string = $"        s = mpmath.zeta(s)"
    let v111 : num_complex_Complex<float> = method3(v109)
    let v112 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v110, v111)
    let v113 : num_complex_Complex<float> = method13(v0, v109)
    (* run_target_args'
    let v115 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v116 : string = "$0.ok()"
    let v117 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v112 v116 
    let _run_target_args'_v115 = v117 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v118 : string = "$0.ok()"
    let v119 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v112 v118 
    let _run_target_args'_v115 = v119 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v120 : string = "$0.ok()"
    let v121 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v112 v120 
    let _run_target_args'_v115 = v121 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v122 : num_complex_Complex<float> option = match v112 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v115 = v122 
    #endif
#if FABLE_COMPILER_PYTHON
    let v123 : num_complex_Complex<float> option = match v112 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v115 = v123 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v124 : num_complex_Complex<float> option = match v112 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v115 = v124 
    #endif
#else
    let v125 : num_complex_Complex<float> option = match v112 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v115 = v125 
    #endif
    let v126 : num_complex_Complex<float> option = _run_target_args'_v115 
    let v140 : (num_complex_Complex<float> -> US0) = method17()
    let v141 : US0 option = v126 |> Option.map v140 
    let v189 : US0 = US0_1
    let v190 : US0 = v141 |> Option.defaultValue v189 
    let v201 : string = "f64::NAN"
    let v202 : float = Fable.Core.RustInterop.emitRustExpr () v201 
    let v203 : string = "f64::NAN"
    let v204 : float = Fable.Core.RustInterop.emitRustExpr () v203 
    let v205 : string = "num_complex::Complex::new($0, $1)"
    let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v202, v204) v205 
    let v209 : num_complex_Complex<float> =
        match v190 with
        | US0_1 -> (* None *)
            v206
        | US0_0(v207) -> (* Some *)
            v207
    let v210 : string = "$0.conj()"
    let v211 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v209 v210 
    let v212 : string = "$0.re"
    let v213 : float = Fable.Core.RustInterop.emitRustExpr v102 v212 
    let v214 : string = "$0.re"
    let v215 : float = Fable.Core.RustInterop.emitRustExpr v211 v214 
    let v216 : bool = v213 = v215
    let v218 : bool =
        if v216 then
            true
        else
            method18(v216)
    let v221 : string =
        if v216 then
            method19(v215)
        else
            method26(v213, v215)
    let v225 : string = "__assert_eq"
    let v226 : string = " "
    let v227 : string = v225 + v226 
    let v239 : string =
        if v216 then
            method19(v215)
        else
            method26(v213, v215)
    let v241 : string = v227 + v239 
    let v270 : unit = ()
    let v271 : (unit -> unit) = closure2(v241)
    let v272 : unit = (fun () -> v271 (); v270) ()
    let v282 : bool = v218 = false
    if v282 then
        failwith<unit> v241
    let v283 : string = "$0.im"
    let v284 : float = Fable.Core.RustInterop.emitRustExpr v102 v283 
    let v285 : string = "$0.im"
    let v286 : float = Fable.Core.RustInterop.emitRustExpr v211 v285 
    let v287 : bool = v284 = v286
    let v289 : bool =
        if v287 then
            true
        else
            method18(v287)
    let v292 : string =
        if v287 then
            method19(v286)
        else
            method26(v284, v286)
    let v294 : string = v225 + v226 
    let v306 : string =
        if v287 then
            method19(v286)
        else
            method26(v284, v286)
    let v308 : string = v294 + v306 
    let v337 : unit = ()
    let v338 : (unit -> unit) = closure2(v308)
    let v339 : unit = (fun () -> v338 (); v337) ()
    let v349 : bool = v289 = false
    if v349 then
        failwith<unit> v308
and method42 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method43(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method45 (v0 : pyo3_Python) : unit =
    let v1 : string = "num_complex::Complex::new($0, $1)"
    let v2 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.01, 0.01) v1 
    let v3 : string = $"        s = mpmath.zeta(s)"
    let v4 : num_complex_Complex<float> = method3(v2)
    let v5 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v3, v4)
    let v6 : num_complex_Complex<float> = method13(v0, v2)
    (* run_target_args'
    let v8 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v9 : string = "$0.ok()"
    let v10 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v9 
    let _run_target_args'_v8 = v10 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v11 : string = "$0.ok()"
    let v12 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v11 
    let _run_target_args'_v8 = v12 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v13 : string = "$0.ok()"
    let v14 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v5 v13 
    let _run_target_args'_v8 = v14 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v15 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v15 
    #endif
#if FABLE_COMPILER_PYTHON
    let v16 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v16 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v17 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v17 
    #endif
#else
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v8 = v18 
    #endif
    let v19 : num_complex_Complex<float> option = _run_target_args'_v8 
    let v33 : (num_complex_Complex<float> -> US0) = method17()
    let v34 : US0 option = v19 |> Option.map v33 
    let v82 : US0 = US0_1
    let v83 : US0 = v34 |> Option.defaultValue v82 
    let v94 : string = "f64::NAN"
    let v95 : float = Fable.Core.RustInterop.emitRustExpr () v94 
    let v96 : string = "f64::NAN"
    let v97 : float = Fable.Core.RustInterop.emitRustExpr () v96 
    let v98 : string = "num_complex::Complex::new($0, $1)"
    let v99 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v95, v97) v98 
    let v102 : num_complex_Complex<float> =
        match v83 with
        | US0_1 -> (* None *)
            v99
        | US0_0(v100) -> (* Some *)
            v100
    let v103 : string = "$0.re"
    let v104 : float = Fable.Core.RustInterop.emitRustExpr v102 v103 
    let v105 : bool = v104 < infinity
    let v107 : bool =
        if v105 then
            true
        else
            method18(v105)
    let v112 : string =
        if v105 then
            let v108 : float = infinity
            method19(v108)
        else
            let v110 : float = infinity
            method26(v104, v110)
    let v116 : string = "__assert_lt"
    let v117 : string = " "
    let v118 : string = v116 + v117 
    let v132 : string =
        if v105 then
            let v128 : float = infinity
            method19(v128)
        else
            let v130 : float = infinity
            method26(v104, v130)
    let v134 : string = v118 + v132 
    let v163 : unit = ()
    let v164 : (unit -> unit) = closure2(v134)
    let v165 : unit = (fun () -> v164 (); v163) ()
    let v175 : bool = v107 = false
    if v175 then
        failwith<unit> v134
    let v176 : string = "$0.im"
    let v177 : float = Fable.Core.RustInterop.emitRustExpr v102 v176 
    let v178 : bool = v177 < infinity
    let v180 : bool =
        if v178 then
            true
        else
            method18(v178)
    let v185 : string =
        if v178 then
            let v181 : float = infinity
            method19(v181)
        else
            let v183 : float = infinity
            method26(v177, v183)
    let v187 : string = v116 + v117 
    let v201 : string =
        if v178 then
            let v197 : float = infinity
            method19(v197)
        else
            let v199 : float = infinity
            method26(v177, v199)
    let v203 : string = v187 + v201 
    let v232 : unit = ()
    let v233 : (unit -> unit) = closure2(v203)
    let v234 : unit = (fun () -> v233 (); v232) ()
    let v244 : bool = v180 = false
    if v244 then
        failwith<unit> v203
and method44 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method45(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v11 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v12 
        let _run_target_args'_v11 = v13 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v14 
        let _run_target_args'_v11 = v15 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v16 : string = "$0.ok()"
        let v17 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v8 v16 
        let _run_target_args'_v11 = v17 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v18 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v18 
        #endif
#if FABLE_COMPILER_PYTHON
        let v19 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v19 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v20 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v20 
        #endif
#else
        let v21 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v11 = v21 
        #endif
        let v22 : num_complex_Complex<float> option = _run_target_args'_v11 
        let v36 : (num_complex_Complex<float> -> US0) = method17()
        let v37 : US0 option = v22 |> Option.map v36 
        let v85 : US0 = US0_1
        let v86 : US0 = v37 |> Option.defaultValue v85 
        let v97 : string = "f64::NAN"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr () v97 
        let v99 : string = "f64::NAN"
        let v100 : float = Fable.Core.RustInterop.emitRustExpr () v99 
        let v101 : string = "num_complex::Complex::new($0, $1)"
        let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v98, v100) v101 
        let v105 : num_complex_Complex<float> =
            match v86 with
            | US0_1 -> (* None *)
                v102
            | US0_0(v103) -> (* Some *)
                v103
        let v106 : string = "$0.re"
        let v107 : float = Fable.Core.RustInterop.emitRustExpr v105 v106 
        let v109 : bool = v107 <> 0.0 
        let v120 : bool =
            if v109 then
                true
            else
                method18(v109)
        let v125 : string =
            if v109 then
                let v121 : float = 0.0
                method19(v121)
            else
                let v123 : float = 0.0
                method26(v107, v123)
        let v129 : string = "__assert_ne"
        let v130 : string = " "
        let v131 : string = v129 + v130 
        let v145 : string =
            if v109 then
                let v141 : float = 0.0
                method19(v141)
            else
                let v143 : float = 0.0
                method26(v107, v143)
        let v147 : string = v131 + v145 
        let v176 : unit = ()
        let v177 : (unit -> unit) = closure2(v147)
        let v178 : unit = (fun () -> v177 (); v176) ()
        let v188 : bool = v120 = false
        if v188 then
            failwith<unit> v147
        let v189 : string = "$0.im"
        let v190 : float = Fable.Core.RustInterop.emitRustExpr v105 v189 
        let v192 : bool = v190 <> 0.0 
        let v203 : bool =
            if v192 then
                true
            else
                method18(v192)
        let v208 : string =
            if v192 then
                let v204 : float = 0.0
                method19(v204)
            else
                let v206 : float = 0.0
                method26(v190, v206)
        let v210 : string = v129 + v130 
        let v224 : string =
            if v192 then
                let v220 : float = 0.0
                method19(v220)
            else
                let v222 : float = 0.0
                method26(v190, v222)
        let v226 : string = v210 + v224 
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure2(v226)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v267 : bool = v203 = false
        if v267 then
            failwith<unit> v226
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v9 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v10 
        let _run_target_args'_v9 = v11 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v12 
        let _run_target_args'_v9 = v13 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v14 
        let _run_target_args'_v9 = v15 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v16 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v16 
        #endif
#if FABLE_COMPILER_PYTHON
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v17 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v18 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v18 
        #endif
#else
        let v19 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v19 
        #endif
        let v20 : num_complex_Complex<float> option = _run_target_args'_v9 
        let v34 : (num_complex_Complex<float> -> US0) = method17()
        let v35 : US0 option = v20 |> Option.map v34 
        let v83 : US0 = US0_1
        let v84 : US0 = v35 |> Option.defaultValue v83 
        let v95 : string = "f64::NAN"
        let v96 : float = Fable.Core.RustInterop.emitRustExpr () v95 
        let v97 : string = "f64::NAN"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr () v97 
        let v99 : string = "num_complex::Complex::new($0, $1)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v96, v98) v99 
        let v103 : num_complex_Complex<float> =
            match v84 with
            | US0_1 -> (* None *)
                v100
            | US0_0(v101) -> (* Some *)
                v101
        let v104 : string = "$0.re"
        let v105 : float = Fable.Core.RustInterop.emitRustExpr v103 v104 
        let v107 : bool = v105 <> 0.0 
        let v118 : bool =
            if v107 then
                true
            else
                method18(v107)
        let v123 : string =
            if v107 then
                let v119 : float = 0.0
                method19(v119)
            else
                let v121 : float = 0.0
                method26(v105, v121)
        let v127 : string = "__assert_ne"
        let v128 : string = " "
        let v129 : string = v127 + v128 
        let v143 : string =
            if v107 then
                let v139 : float = 0.0
                method19(v139)
            else
                let v141 : float = 0.0
                method26(v105, v141)
        let v145 : string = v129 + v143 
        let v174 : unit = ()
        let v175 : (unit -> unit) = closure2(v145)
        let v176 : unit = (fun () -> v175 (); v174) ()
        let v186 : bool = v118 = false
        if v186 then
            failwith<unit> v145
        let v187 : string = "$0.im"
        let v188 : float = Fable.Core.RustInterop.emitRustExpr v103 v187 
        let v190 : bool = v188 <> 0.0 
        let v201 : bool =
            if v190 then
                true
            else
                method18(v190)
        let v206 : string =
            if v190 then
                let v202 : float = 0.0
                method19(v202)
            else
                let v204 : float = 0.0
                method26(v188, v204)
        let v208 : string = v127 + v128 
        let v222 : string =
            if v190 then
                let v218 : float = 0.0
                method19(v218)
            else
                let v220 : float = 0.0
                method26(v188, v220)
        let v224 : string = v208 + v222 
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure2(v224)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v265 : bool = v201 = false
        if v265 then
            failwith<unit> v224
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v9 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v10 : string = "$0.ok()"
        let v11 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v10 
        let _run_target_args'_v9 = v11 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v12 : string = "$0.ok()"
        let v13 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v12 
        let _run_target_args'_v9 = v13 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v14 : string = "$0.ok()"
        let v15 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v6 v14 
        let _run_target_args'_v9 = v15 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v16 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v16 
        #endif
#if FABLE_COMPILER_PYTHON
        let v17 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v17 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v18 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v18 
        #endif
#else
        let v19 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v9 = v19 
        #endif
        let v20 : num_complex_Complex<float> option = _run_target_args'_v9 
        let v34 : (num_complex_Complex<float> -> US0) = method17()
        let v35 : US0 option = v20 |> Option.map v34 
        let v83 : US0 = US0_1
        let v84 : US0 = v35 |> Option.defaultValue v83 
        let v95 : string = "f64::NAN"
        let v96 : float = Fable.Core.RustInterop.emitRustExpr () v95 
        let v97 : string = "f64::NAN"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr () v97 
        let v99 : string = "num_complex::Complex::new($0, $1)"
        let v100 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v96, v98) v99 
        let v103 : num_complex_Complex<float> =
            match v84 with
            | US0_1 -> (* None *)
                v100
            | US0_0(v101) -> (* Some *)
                v101
        let v104 : string = "num_complex::Complex::new($0, $1)"
        let v105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v104 
        let v106 : string = "num_complex::Complex::powc($0, $1)"
        let v107 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v105, v2) v106 
        let v108 : string = "num_complex::Complex::new($0, $1)"
        let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v108 
        let v110 : string = "num_complex::Complex::new($0, $1)"
        let v111 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v110 
        let v112 : string = "$0 - $1"
        let v113 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v111) v112 
        let v114 : string = "num_complex::Complex::powc($0, $1)"
        let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v109, v113) v114 
        let v116 : string = "$0 * $1"
        let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v107, v115) v116 
        let v118 : string = "num_complex::Complex::new($0, $1)"
        let v119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v118 
        let v120 : string = "$0 * $1"
        let v121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v119, v2) v120 
        let v122 : string = "num_complex::Complex::new($0, $1)"
        let v123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v122 
        let v124 : string = "$0 / $1"
        let v125 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v121, v123) v124 
        let v126 : string = "$0.sin()"
        let v127 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v125 v126 
        let v128 : string = "$0 * $1"
        let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v117, v127) v128 
        let v130 : string = "num_complex::Complex::new($0, $1)"
        let v131 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v130 
        let v132 : string = "$0 - $1"
        let v133 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v131, v2) v132 
        let v134 : string = $"        s = mpmath.gamma(s)"
        let v135 : num_complex_Complex<float> = method3(v133)
        let v136 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v134, v135)
        (* run_target_args'
        let v138 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v139 : string = "$0.ok()"
        let v140 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v136 v139 
        let _run_target_args'_v138 = v140 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v141 : string = "$0.ok()"
        let v142 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v136 v141 
        let _run_target_args'_v138 = v142 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v143 : string = "$0.ok()"
        let v144 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v136 v143 
        let _run_target_args'_v138 = v144 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v145 : num_complex_Complex<float> option = match v136 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v138 = v145 
        #endif
#if FABLE_COMPILER_PYTHON
        let v146 : num_complex_Complex<float> option = match v136 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v138 = v146 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v147 : num_complex_Complex<float> option = match v136 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v138 = v147 
        #endif
#else
        let v148 : num_complex_Complex<float> option = match v136 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v138 = v148 
        #endif
        let v149 : num_complex_Complex<float> option = _run_target_args'_v138 
        let v163 : (num_complex_Complex<float> -> US0) = method17()
        let v164 : US0 option = v149 |> Option.map v163 
        let v212 : US0 = US0_1
        let v213 : US0 = v164 |> Option.defaultValue v212 
        let v224 : string = "f64::NAN"
        let v225 : float = Fable.Core.RustInterop.emitRustExpr () v224 
        let v226 : string = "f64::NAN"
        let v227 : float = Fable.Core.RustInterop.emitRustExpr () v226 
        let v228 : string = "num_complex::Complex::new($0, $1)"
        let v229 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v225, v227) v228 
        let v232 : num_complex_Complex<float> =
            match v213 with
            | US0_1 -> (* None *)
                v229
            | US0_0(v230) -> (* Some *)
                v230
        let v233 : string = "$0 * $1"
        let v234 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v129, v232) v233 
        let v235 : string = "$0.re"
        let v236 : float = Fable.Core.RustInterop.emitRustExpr v2 v235 
        let v237 : float = 1.0 - v236
        let v238 : string = "$0.im"
        let v239 : float = Fable.Core.RustInterop.emitRustExpr v2 v238 
        let v240 : float =  -v239
        let v241 : string = "num_complex::Complex::new($0, $1)"
        let v242 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v237, v240) v241 
        let v243 : string = $"        s = mpmath.zeta(s)"
        let v244 : num_complex_Complex<float> = method3(v242)
        let v245 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v243, v244)
        let v246 : num_complex_Complex<float> = method13(v0, v242)
        (* run_target_args'
        let v248 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v249 : string = "$0.ok()"
        let v250 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v245 v249 
        let _run_target_args'_v248 = v250 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v251 : string = "$0.ok()"
        let v252 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v245 v251 
        let _run_target_args'_v248 = v252 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v253 : string = "$0.ok()"
        let v254 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v245 v253 
        let _run_target_args'_v248 = v254 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v255 : num_complex_Complex<float> option = match v245 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v248 = v255 
        #endif
#if FABLE_COMPILER_PYTHON
        let v256 : num_complex_Complex<float> option = match v245 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v248 = v256 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v257 : num_complex_Complex<float> option = match v245 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v248 = v257 
        #endif
#else
        let v258 : num_complex_Complex<float> option = match v245 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v248 = v258 
        #endif
        let v259 : num_complex_Complex<float> option = _run_target_args'_v248 
        let v273 : (num_complex_Complex<float> -> US0) = method17()
        let v274 : US0 option = v259 |> Option.map v273 
        let v322 : US0 = US0_1
        let v323 : US0 = v274 |> Option.defaultValue v322 
        let v334 : string = "f64::NAN"
        let v335 : float = Fable.Core.RustInterop.emitRustExpr () v334 
        let v336 : string = "f64::NAN"
        let v337 : float = Fable.Core.RustInterop.emitRustExpr () v336 
        let v338 : string = "num_complex::Complex::new($0, $1)"
        let v339 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v335, v337) v338 
        let v342 : num_complex_Complex<float> =
            match v323 with
            | US0_1 -> (* None *)
                v339
            | US0_0(v340) -> (* Some *)
                v340
        let v343 : string = "$0 * $1"
        let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v234, v342) v343 
        let v345 : string = "$0.re"
        let v346 : float = Fable.Core.RustInterop.emitRustExpr v103 v345 
        let v347 : string = "$0.re"
        let v348 : float = Fable.Core.RustInterop.emitRustExpr v344 v347 
        let v349 : float = v346 - v348
        let v350 : float =  -v349
        let v351 : bool = v349 >= v350
        let v352 : float =
            if v351 then
                v349
            else
                v350
        let v353 : bool = v352 < 0.0001
        let v355 : bool =
            if v353 then
                true
            else
                method18(v353)
        let v360 : string =
            if v353 then
                let v356 : float = 0.0001
                method19(v356)
            else
                let v358 : float = 0.0001
                method26(v352, v358)
        let v364 : string = "__assert_lt"
        let v365 : string = " "
        let v366 : string = v364 + v365 
        let v380 : string =
            if v353 then
                let v376 : float = 0.0001
                method19(v376)
            else
                let v378 : float = 0.0001
                method26(v352, v378)
        let v382 : string = v366 + v380 
        let v411 : unit = ()
        let v412 : (unit -> unit) = closure2(v382)
        let v413 : unit = (fun () -> v412 (); v411) ()
        let v423 : bool = v355 = false
        if v423 then
            failwith<unit> v382
        let v424 : string = "$0.im"
        let v425 : float = Fable.Core.RustInterop.emitRustExpr v103 v424 
        let v426 : string = "$0.im"
        let v427 : float = Fable.Core.RustInterop.emitRustExpr v344 v426 
        let v428 : float = v425 - v427
        let v429 : float =  -v428
        let v430 : bool = v428 >= v429
        let v431 : float =
            if v430 then
                v428
            else
                v429
        let v432 : bool = v431 < 0.0001
        let v434 : bool =
            if v432 then
                true
            else
                method18(v432)
        let v439 : string =
            if v432 then
                let v435 : float = 0.0001
                method19(v435)
            else
                let v437 : float = 0.0001
                method26(v431, v437)
        let v441 : string = v364 + v365 
        let v455 : string =
            if v432 then
                let v451 : float = 0.0001
                method19(v451)
            else
                let v453 : float = 0.0001
                method26(v431, v453)
        let v457 : string = v441 + v455 
        let v486 : unit = ()
        let v487 : (unit -> unit) = closure2(v457)
        let v488 : unit = (fun () -> v487 (); v486) ()
        let v498 : bool = v434 = false
        if v498 then
            failwith<unit> v457
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
        let v14 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v15 : string = "$0.ok()"
        let v16 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v15 
        let _run_target_args'_v14 = v16 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v17 : string = "$0.ok()"
        let v18 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v17 
        let _run_target_args'_v14 = v18 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v19 : string = "$0.ok()"
        let v20 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v11 v19 
        let _run_target_args'_v14 = v20 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v21 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v21 
        #endif
#if FABLE_COMPILER_PYTHON
        let v22 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v22 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v23 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v23 
        #endif
#else
        let v24 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v14 = v24 
        #endif
        let v25 : num_complex_Complex<float> option = _run_target_args'_v14 
        let v39 : (num_complex_Complex<float> -> US0) = method17()
        let v40 : US0 option = v25 |> Option.map v39 
        let v88 : US0 = US0_1
        let v89 : US0 = v40 |> Option.defaultValue v88 
        let v100 : string = "f64::NAN"
        let v101 : float = Fable.Core.RustInterop.emitRustExpr () v100 
        let v102 : string = "f64::NAN"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr () v102 
        let v104 : string = "num_complex::Complex::new($0, $1)"
        let v105 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v101, v103) v104 
        let v108 : num_complex_Complex<float> =
            match v89 with
            | US0_1 -> (* None *)
                v105
            | US0_0(v106) -> (* Some *)
                v106
        let v109 : string = "$0.re"
        let v110 : float = Fable.Core.RustInterop.emitRustExpr v108 v109 
        let v111 : float = v110 - v8
        let v112 : float =  -v111
        let v113 : bool = v111 >= v112
        let v114 : float =
            if v113 then
                v111
            else
                v112
        let v115 : bool = v114 < 0.01
        let v117 : bool =
            if v115 then
                true
            else
                method18(v115)
        let v122 : string =
            if v115 then
                let v118 : float = 0.01
                method19(v118)
            else
                let v120 : float = 0.01
                method26(v114, v120)
        let v126 : string = "__assert_lt"
        let v127 : string = " "
        let v128 : string = v126 + v127 
        let v142 : string =
            if v115 then
                let v138 : float = 0.01
                method19(v138)
            else
                let v140 : float = 0.01
                method26(v114, v140)
        let v144 : string = v128 + v142 
        let v173 : unit = ()
        let v174 : (unit -> unit) = closure2(v144)
        let v175 : unit = (fun () -> v174 (); v173) ()
        let v185 : bool = v117 = false
        if v185 then
            failwith<unit> v144
        let v186 : string = "$0.im"
        let v187 : float = Fable.Core.RustInterop.emitRustExpr v108 v186 
        let v188 : bool = v187 < 0.01
        let v190 : bool =
            if v188 then
                true
            else
                method18(v188)
        let v195 : string =
            if v188 then
                let v191 : float = 0.01
                method19(v191)
            else
                let v193 : float = 0.01
                method26(v187, v193)
        let v197 : string = v126 + v127 
        let v211 : string =
            if v188 then
                let v207 : float = 0.01
                method19(v207)
            else
                let v209 : float = 0.01
                method26(v187, v209)
        let v213 : string = v197 + v211 
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure2(v213)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v254 : bool = v190 = false
        if v254 then
            failwith<unit> v213
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
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v15 : Result<unit, pyo3_PyErr> = method29(v5)
    let v16 : string = ""
    let v17 : string = "}"
    let v18 : string = v16 + v17 
    let v19 : string = v18 + v17 
    let v20 : string = "{"
    let v21 : string = v16 + v20 
    let x = v15 //
    let v22 : _ = x
    let v23 : unit = ()
    (* run_target_args'
    let v24 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v25 : string = $"true; let _fix_closure_v23 = $0"
    let v26 : bool = Fable.Core.RustInterop.emitRustExpr v22 v25 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v27 : string = $"true; let _fix_closure_v23 = $0"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr v22 v27 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v29 : string = $"true; let _fix_closure_v23 = $0"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr v22 v29 
    let _run_target_args'_v24 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v24 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v24 = false 
    #endif
#else
    let _run_target_args'_v24 = false 
    #endif
    let v31 : bool = _run_target_args'_v24 
    let v32 : string = $"true; _fix_closure_v23 " + v19 + "); " + v21 + " // rust.fix_closure'"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    let v34 : string = "__run_test"
    let v35 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v34 
    (* run_target_args'
    let v36 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v37 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v37 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v38 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v38 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v39 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v35 v39 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v35 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
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
    let v21 : unit = ()
    let v22 : (unit -> unit) = closure2(v1)
    let v23 : unit = (fun () -> v22 (); v21) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure3()
let main args = v1 args
()
