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
    let v49 : (float * float) = v38, v40 
    let v69 : (bool * (float * float)) = false, v49 
    let v81 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v122 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v123 
    let _run_target_args'_v122 = v124 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v125 : string = "&*$0"
    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v125 
    let _run_target_args'_v122 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v127 : string = "&*$0"
    let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v127 
    let _run_target_args'_v122 = v128 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v137 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v157 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v177 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v177 
    #endif
#else
    let v197 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v197 
    #endif
    let v209 : Ref<Str> = _run_target_args'_v122 
    (* run_target_args'
    let v290 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v291 : string = "String::from($0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v291 
    let _run_target_args'_v290 = v292 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v293 : string = "String::from($0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v293 
    let _run_target_args'_v290 = v294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = "String::from($0)"
    let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v295 
    let _run_target_args'_v290 = v296 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v325 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v345 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v345 
    #endif
#else
    let v365 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v365 
    #endif
    let v377 : std_string_String = _run_target_args'_v290 
    let v418 : string = "std::ffi::CString::new($0).unwrap()"
    let v419 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v377 v418 
    let v420 : string = ""
    (* run_target_args'
    let v461 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v462 : string = "&*$0"
    let v463 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v420 v462 
    let _run_target_args'_v461 = v463 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v464 : string = "&*$0"
    let v465 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v420 v464 
    let _run_target_args'_v461 = v465 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v466 : string = "&*$0"
    let v467 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v420 v466 
    let _run_target_args'_v461 = v467 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v476 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v476 
    #endif
#if FABLE_COMPILER_PYTHON
    let v496 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v496 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v516 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v516 
    #endif
#else
    let v536 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v536 
    #endif
    let v548 : Ref<Str> = _run_target_args'_v461 
    (* run_target_args'
    let v629 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v630 : string = "String::from($0)"
    let v631 : std_string_String = Fable.Core.RustInterop.emitRustExpr v548 v630 
    let _run_target_args'_v629 = v631 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v632 : string = "String::from($0)"
    let v633 : std_string_String = Fable.Core.RustInterop.emitRustExpr v548 v632 
    let _run_target_args'_v629 = v633 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v634 : string = "String::from($0)"
    let v635 : std_string_String = Fable.Core.RustInterop.emitRustExpr v548 v634 
    let _run_target_args'_v629 = v635 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v644 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v644 
    #endif
#if FABLE_COMPILER_PYTHON
    let v664 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v664 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v684 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v684 
    #endif
#else
    let v704 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v704 
    #endif
    let v716 : std_string_String = _run_target_args'_v629 
    let v757 : string = "std::ffi::CString::new($0).unwrap()"
    let v758 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v716 v757 
    let v759 : string = "pyo3::types::PyModule::from_code(v81, &$0, &v758, &v758)"
    let v760 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v419 v759 
    let v761 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v762 : bool = Fable.Core.RustInterop.emitRustExpr v760 v761 
    let v763 : string = "x"
    let v764 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v763 
    (* run_target_args'
    let v805 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v806 : string = "format!(\"{}\", $0)"
    let v807 : std_string_String = Fable.Core.RustInterop.emitRustExpr v764 v806 
    let _run_target_args'_v805 = v807 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v808 : string = "format!(\"{}\", $0)"
    let v809 : std_string_String = Fable.Core.RustInterop.emitRustExpr v764 v808 
    let _run_target_args'_v805 = v809 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v810 : string = "format!(\"{}\", $0)"
    let v811 : std_string_String = Fable.Core.RustInterop.emitRustExpr v764 v810 
    let _run_target_args'_v805 = v811 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v840 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v840 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v860 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v860 
    #endif
#else
    let v880 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v880 
    #endif
    let v892 : std_string_String = _run_target_args'_v805 
    let v933 : string = "true; $0 })"
    let v934 : bool = Fable.Core.RustInterop.emitRustExpr v892 v933 
    let v935 : string = "_result_map_error__"
    let v936 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v935 
    (* run_target_args'
    let v939 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v940 : string = "$0.unwrap()"
    let v941 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v936 v940 
    let _run_target_args'_v939 = v941 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v942 : string = "$0.unwrap()"
    let v943 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v936 v942 
    let _run_target_args'_v939 = v943 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v944 : string = "$0.unwrap()"
    let v945 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v936 v944 
    let _run_target_args'_v939 = v945 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v946 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v946 
    #endif
#if FABLE_COMPILER_PYTHON
    let v947 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v947 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v948 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v948 
    #endif
#else
    let v949 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v949 
    #endif
    let v950 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v939 
    let v953 : string = method8()
    (* run_target_args'
    let v994 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v995 : string = "&*$0"
    let v996 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v953 v995 
    let _run_target_args'_v994 = v996 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v997 : string = "&*$0"
    let v998 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v953 v997 
    let _run_target_args'_v994 = v998 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v999 : string = "&*$0"
    let v1000 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v953 v999 
    let _run_target_args'_v994 = v1000 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1009 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1009 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1029 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1029 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1049 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1049 
    #endif
#else
    let v1069 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1069 
    #endif
    let v1081 : Ref<Str> = _run_target_args'_v994 
    let v1122 : pyo3_Bound<pyo3_types_PyModule> = method9(v950)
    let v1123 : string = "v1122.getattr($0)"
    let v1124 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v1081 v1123 
    let v1125 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v1126 : bool = Fable.Core.RustInterop.emitRustExpr v1124 v1125 
    let v1127 : string = "x"
    let v1128 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v1127 
    (* run_target_args'
    let v1169 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1170 : string = "format!(\"{}\", $0)"
    let v1171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1128 v1170 
    let _run_target_args'_v1169 = v1171 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1172 : string = "format!(\"{}\", $0)"
    let v1173 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1128 v1172 
    let _run_target_args'_v1169 = v1173 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1174 : string = "format!(\"{}\", $0)"
    let v1175 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1128 v1174 
    let _run_target_args'_v1169 = v1175 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1184 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1204 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1204 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1224 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1224 
    #endif
#else
    let v1244 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1244 
    #endif
    let v1256 : std_string_String = _run_target_args'_v1169 
    let v1297 : string = "true; $0 })"
    let v1298 : bool = Fable.Core.RustInterop.emitRustExpr v1256 v1297 
    let v1299 : string = "_result_map_error__"
    let v1300 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1299 
    (* run_target_args'
    let v1303 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1304 : string = "$0.unwrap()"
    let v1305 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1300 v1304 
    let _run_target_args'_v1303 = v1305 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1306 : string = "$0.unwrap()"
    let v1307 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1300 v1306 
    let _run_target_args'_v1303 = v1307 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1308 : string = "$0.unwrap()"
    let v1309 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1300 v1308 
    let _run_target_args'_v1303 = v1309 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1310 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1310 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1311 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1311 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1312 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1312 
    #endif
#else
    let v1313 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1313 
    #endif
    let v1314 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v1303 
    let v1317 : (bool * (float * float)) = method10(v69)
    let v1318 : pyo3_Bound<pyo3_PyAny> = method11(v1314)
    let v1319 : string = "pyo3::prelude::PyAnyMethods::call(&v1318, ((*v1317).0, *(*v1317).1), None)"
    let v1320 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v1319 
    let v1321 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v1322 : bool = Fable.Core.RustInterop.emitRustExpr v1320 v1321 
    let v1323 : string = "x"
    let v1324 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v1323 
    (* run_target_args'
    let v1365 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1366 : string = "format!(\"{}\", $0)"
    let v1367 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1324 v1366 
    let _run_target_args'_v1365 = v1367 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1368 : string = "format!(\"{}\", $0)"
    let v1369 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1324 v1368 
    let _run_target_args'_v1365 = v1369 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1370 : string = "format!(\"{}\", $0)"
    let v1371 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1324 v1370 
    let _run_target_args'_v1365 = v1371 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1380 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1380 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1400 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1400 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1420 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1420 
    #endif
#else
    let v1440 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1440 
    #endif
    let v1452 : std_string_String = _run_target_args'_v1365 
    let v1493 : string = "true; $0 })"
    let v1494 : bool = Fable.Core.RustInterop.emitRustExpr v1452 v1493 
    let v1495 : string = "_result_map_error__"
    let v1496 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1495 
    let v1497 : string = "$0?"
    let v1498 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1496 v1497 
    let v1499 : pyo3_Bound<pyo3_PyAny> = method12(v1498)
    let v1500 : string = "v1499.extract()"
    let v1501 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v1500 
    let v1502 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v1503 : bool = Fable.Core.RustInterop.emitRustExpr v1501 v1502 
    let v1504 : string = "x"
    let v1505 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v1504 
    (* run_target_args'
    let v1546 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1547 : string = "format!(\"{}\", $0)"
    let v1548 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1547 
    let _run_target_args'_v1546 = v1548 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1549 : string = "format!(\"{}\", $0)"
    let v1550 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1549 
    let _run_target_args'_v1546 = v1550 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1551 : string = "format!(\"{}\", $0)"
    let v1552 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1551 
    let _run_target_args'_v1546 = v1552 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1561 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1561 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1581 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1581 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1601 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1601 
    #endif
#else
    let v1621 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1621 
    #endif
    let v1633 : std_string_String = _run_target_args'_v1546 
    let v1674 : string = "true; $0 })"
    let v1675 : bool = Fable.Core.RustInterop.emitRustExpr v1633 v1674 
    let v1676 : string = "_result_map_error__"
    let v1677 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1676 
    let v1678 : string = "$0?"
    let struct (v1679 : float, v1680 : float) = Fable.Core.RustInterop.emitRustExpr v1677 v1678 
    let v1681 : string = "num_complex::Complex::new($0, $1)"
    let v1682 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1679, v1680) v1681 
    let v1691 : Result<num_complex_Complex<float>, std_string_String> = Ok v1682 
    v1691
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
    let v49 : (float * float) = v38, v40 
    let v69 : (bool * (float * float)) = false, v49 
    let v81 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v122 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v123 : string = "&*$0"
    let v124 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v123 
    let _run_target_args'_v122 = v124 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v125 : string = "&*$0"
    let v126 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v125 
    let _run_target_args'_v122 = v126 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v127 : string = "&*$0"
    let v128 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v127 
    let _run_target_args'_v122 = v128 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v137 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v137 
    #endif
#if FABLE_COMPILER_PYTHON
    let v157 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v157 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v177 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v177 
    #endif
#else
    let v197 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v122 = v197 
    #endif
    let v209 : Ref<Str> = _run_target_args'_v122 
    (* run_target_args'
    let v290 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v291 : string = "String::from($0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v291 
    let _run_target_args'_v290 = v292 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v293 : string = "String::from($0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v293 
    let _run_target_args'_v290 = v294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = "String::from($0)"
    let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v209 v295 
    let _run_target_args'_v290 = v296 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v305 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v305 
    #endif
#if FABLE_COMPILER_PYTHON
    let v325 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v325 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v345 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v345 
    #endif
#else
    let v365 : std_string_String = v209 |> unbox<std_string_String>
    let _run_target_args'_v290 = v365 
    #endif
    let v377 : std_string_String = _run_target_args'_v290 
    let v418 : string = "std::ffi::CString::new($0).unwrap()"
    let v419 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v377 v418 
    let v420 : string = ""
    (* run_target_args'
    let v461 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v462 : string = "&*$0"
    let v463 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v420 v462 
    let _run_target_args'_v461 = v463 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v464 : string = "&*$0"
    let v465 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v420 v464 
    let _run_target_args'_v461 = v465 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v466 : string = "&*$0"
    let v467 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v420 v466 
    let _run_target_args'_v461 = v467 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v476 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v476 
    #endif
#if FABLE_COMPILER_PYTHON
    let v496 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v496 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v516 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v516 
    #endif
#else
    let v536 : Ref<Str> = v420 |> unbox<Ref<Str>>
    let _run_target_args'_v461 = v536 
    #endif
    let v548 : Ref<Str> = _run_target_args'_v461 
    (* run_target_args'
    let v629 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v630 : string = "String::from($0)"
    let v631 : std_string_String = Fable.Core.RustInterop.emitRustExpr v548 v630 
    let _run_target_args'_v629 = v631 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v632 : string = "String::from($0)"
    let v633 : std_string_String = Fable.Core.RustInterop.emitRustExpr v548 v632 
    let _run_target_args'_v629 = v633 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v634 : string = "String::from($0)"
    let v635 : std_string_String = Fable.Core.RustInterop.emitRustExpr v548 v634 
    let _run_target_args'_v629 = v635 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v644 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v644 
    #endif
#if FABLE_COMPILER_PYTHON
    let v664 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v664 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v684 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v684 
    #endif
#else
    let v704 : std_string_String = v548 |> unbox<std_string_String>
    let _run_target_args'_v629 = v704 
    #endif
    let v716 : std_string_String = _run_target_args'_v629 
    let v757 : string = "std::ffi::CString::new($0).unwrap()"
    let v758 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v716 v757 
    let v759 : string = "pyo3::types::PyModule::from_code(v81, &$0, &v758, &v758)"
    let v760 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v419 v759 
    let v761 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v762 : bool = Fable.Core.RustInterop.emitRustExpr v760 v761 
    let v763 : string = "x"
    let v764 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v763 
    (* run_target_args'
    let v805 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v806 : string = "format!(\"{}\", $0)"
    let v807 : std_string_String = Fable.Core.RustInterop.emitRustExpr v764 v806 
    let _run_target_args'_v805 = v807 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v808 : string = "format!(\"{}\", $0)"
    let v809 : std_string_String = Fable.Core.RustInterop.emitRustExpr v764 v808 
    let _run_target_args'_v805 = v809 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v810 : string = "format!(\"{}\", $0)"
    let v811 : std_string_String = Fable.Core.RustInterop.emitRustExpr v764 v810 
    let _run_target_args'_v805 = v811 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v820 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v820 
    #endif
#if FABLE_COMPILER_PYTHON
    let v840 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v840 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v860 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v860 
    #endif
#else
    let v880 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v805 = v880 
    #endif
    let v892 : std_string_String = _run_target_args'_v805 
    let v933 : string = "true; $0 })"
    let v934 : bool = Fable.Core.RustInterop.emitRustExpr v892 v933 
    let v935 : string = "_result_map_error__"
    let v936 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v935 
    (* run_target_args'
    let v939 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v940 : string = "$0.unwrap()"
    let v941 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v936 v940 
    let _run_target_args'_v939 = v941 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v942 : string = "$0.unwrap()"
    let v943 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v936 v942 
    let _run_target_args'_v939 = v943 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v944 : string = "$0.unwrap()"
    let v945 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v936 v944 
    let _run_target_args'_v939 = v945 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v946 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v946 
    #endif
#if FABLE_COMPILER_PYTHON
    let v947 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v947 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v948 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v948 
    #endif
#else
    let v949 : pyo3_Bound<pyo3_types_PyModule> = match v936 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v939 = v949 
    #endif
    let v950 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v939 
    let v953 : string = method8()
    (* run_target_args'
    let v994 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v995 : string = "&*$0"
    let v996 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v953 v995 
    let _run_target_args'_v994 = v996 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v997 : string = "&*$0"
    let v998 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v953 v997 
    let _run_target_args'_v994 = v998 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v999 : string = "&*$0"
    let v1000 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v953 v999 
    let _run_target_args'_v994 = v1000 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1009 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1009 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1029 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1029 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1049 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1049 
    #endif
#else
    let v1069 : Ref<Str> = v953 |> unbox<Ref<Str>>
    let _run_target_args'_v994 = v1069 
    #endif
    let v1081 : Ref<Str> = _run_target_args'_v994 
    let v1122 : pyo3_Bound<pyo3_types_PyModule> = method9(v950)
    let v1123 : string = "v1122.getattr($0)"
    let v1124 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v1081 v1123 
    let v1125 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v1126 : bool = Fable.Core.RustInterop.emitRustExpr v1124 v1125 
    let v1127 : string = "x"
    let v1128 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v1127 
    (* run_target_args'
    let v1169 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1170 : string = "format!(\"{}\", $0)"
    let v1171 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1128 v1170 
    let _run_target_args'_v1169 = v1171 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1172 : string = "format!(\"{}\", $0)"
    let v1173 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1128 v1172 
    let _run_target_args'_v1169 = v1173 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1174 : string = "format!(\"{}\", $0)"
    let v1175 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1128 v1174 
    let _run_target_args'_v1169 = v1175 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1184 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1184 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1204 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1204 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1224 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1224 
    #endif
#else
    let v1244 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1169 = v1244 
    #endif
    let v1256 : std_string_String = _run_target_args'_v1169 
    let v1297 : string = "true; $0 })"
    let v1298 : bool = Fable.Core.RustInterop.emitRustExpr v1256 v1297 
    let v1299 : string = "_result_map_error__"
    let v1300 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1299 
    (* run_target_args'
    let v1303 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1304 : string = "$0.unwrap()"
    let v1305 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1300 v1304 
    let _run_target_args'_v1303 = v1305 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1306 : string = "$0.unwrap()"
    let v1307 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1300 v1306 
    let _run_target_args'_v1303 = v1307 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1308 : string = "$0.unwrap()"
    let v1309 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1300 v1308 
    let _run_target_args'_v1303 = v1309 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1310 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1310 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1311 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1311 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1312 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1312 
    #endif
#else
    let v1313 : pyo3_Bound<pyo3_PyAny> = match v1300 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v1303 = v1313 
    #endif
    let v1314 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v1303 
    let v1317 : (bool * (float * float)) = method10(v69)
    let v1318 : pyo3_Bound<pyo3_PyAny> = method11(v1314)
    let v1319 : string = "pyo3::prelude::PyAnyMethods::call(&v1318, ((*v1317).0, *(*v1317).1), None)"
    let v1320 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v1319 
    let v1321 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v1322 : bool = Fable.Core.RustInterop.emitRustExpr v1320 v1321 
    let v1323 : string = "x"
    let v1324 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v1323 
    (* run_target_args'
    let v1365 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1366 : string = "format!(\"{}\", $0)"
    let v1367 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1324 v1366 
    let _run_target_args'_v1365 = v1367 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1368 : string = "format!(\"{}\", $0)"
    let v1369 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1324 v1368 
    let _run_target_args'_v1365 = v1369 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1370 : string = "format!(\"{}\", $0)"
    let v1371 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1324 v1370 
    let _run_target_args'_v1365 = v1371 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1380 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1380 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1400 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1400 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1420 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1420 
    #endif
#else
    let v1440 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1365 = v1440 
    #endif
    let v1452 : std_string_String = _run_target_args'_v1365 
    let v1493 : string = "true; $0 })"
    let v1494 : bool = Fable.Core.RustInterop.emitRustExpr v1452 v1493 
    let v1495 : string = "_result_map_error__"
    let v1496 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1495 
    let v1497 : string = "$0?"
    let v1498 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v1496 v1497 
    let v1499 : pyo3_Bound<pyo3_PyAny> = method12(v1498)
    let v1500 : string = "v1499.extract()"
    let v1501 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v1500 
    let v1502 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v1503 : bool = Fable.Core.RustInterop.emitRustExpr v1501 v1502 
    let v1504 : string = "x"
    let v1505 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v1504 
    (* run_target_args'
    let v1546 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v1547 : string = "format!(\"{}\", $0)"
    let v1548 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1547 
    let _run_target_args'_v1546 = v1548 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v1549 : string = "format!(\"{}\", $0)"
    let v1550 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1549 
    let _run_target_args'_v1546 = v1550 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v1551 : string = "format!(\"{}\", $0)"
    let v1552 : std_string_String = Fable.Core.RustInterop.emitRustExpr v1505 v1551 
    let _run_target_args'_v1546 = v1552 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v1561 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1561 
    #endif
#if FABLE_COMPILER_PYTHON
    let v1581 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1581 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v1601 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1601 
    #endif
#else
    let v1621 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v1546 = v1621 
    #endif
    let v1633 : std_string_String = _run_target_args'_v1546 
    let v1674 : string = "true; $0 })"
    let v1675 : bool = Fable.Core.RustInterop.emitRustExpr v1633 v1674 
    let v1676 : string = "_result_map_error__"
    let v1677 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v1676 
    let v1678 : string = "$0?"
    let struct (v1679 : float, v1680 : float) = Fable.Core.RustInterop.emitRustExpr v1677 v1678 
    let v1681 : string = "num_complex::Complex::new($0, $1)"
    let v1682 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1679, v1680) v1681 
    let v1691 : Result<num_complex_Complex<float>, std_string_String> = Ok v1682 
    v1691
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
            let v29 : (int32 -> float) = float
            let v30 : float = v29 v18
            let v42 : string = "num_complex::Complex::new($0, $1)"
            let v43 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v30, 0.0) v42 
            let v44 : string = "num_complex::Complex::powc($0, $1)"
            let v45 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v1) v44 
            let v46 : string = "$0 / $1"
            let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v45) v46 
            let v48 : string = "$0 + $1"
            let v49 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v47) v48 
            let v50 : int32 = v16 + 1
            v14.l0 <- v50
            v14.l1 <- v49
            ()
        let v51 : num_complex_Complex<float> = v14.l1
        v51
    else
        let v52 : string = "num_complex::Complex::new($0, $1)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v52 
        let v54 : string = "$0 - $1"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v1) v54 
        let v56 : string = $"        s = mpmath.gamma(s)"
        let v57 : num_complex_Complex<float> = method3(v55)
        let v58 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v56, v57)
        (* run_target_args'
        let v61 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v62 : string = "$0.ok()"
        let v63 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v58 v62 
        let _run_target_args'_v61 = v63 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v64 : string = "$0.ok()"
        let v65 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v58 v64 
        let _run_target_args'_v61 = v65 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v66 : string = "$0.ok()"
        let v67 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v58 v66 
        let _run_target_args'_v61 = v67 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v68 : num_complex_Complex<float> option = match v58 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v61 = v68 
        #endif
#if FABLE_COMPILER_PYTHON
        let v69 : num_complex_Complex<float> option = match v58 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v61 = v69 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v70 : num_complex_Complex<float> option = match v58 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v61 = v70 
        #endif
#else
        let v71 : num_complex_Complex<float> option = match v58 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v61 = v71 
        #endif
        let v72 : num_complex_Complex<float> option = _run_target_args'_v61 
        let v98 : (num_complex_Complex<float> -> US0) = method17()
        let v99 : US0 option = v72 |> Option.map v98 
        let v183 : US0 = US0_1
        let v184 : US0 = v99 |> Option.defaultValue v183 
        let v197 : string = "f64::NAN"
        let v198 : float = Fable.Core.RustInterop.emitRustExpr () v197 
        let v199 : string = "f64::NAN"
        let v200 : float = Fable.Core.RustInterop.emitRustExpr () v199 
        let v201 : string = "num_complex::Complex::new($0, $1)"
        let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v198, v200) v201 
        let v205 : num_complex_Complex<float> =
            match v184 with
            | US0_1 -> (* None *)
                v202
            | US0_0(v203) -> (* Some *)
                v203
        let v206 : string = "num_complex::Complex::new($0, $1)"
        let v207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v206 
        let v208 : string = "$0 * $1"
        let v209 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v207, v1) v208 
        let v210 : string = "num_complex::Complex::new($0, $1)"
        let v211 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v210 
        let v212 : string = "$0 / $1"
        let v213 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v209, v211) v212 
        let v214 : string = "$0.sin()"
        let v215 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v213 v214 
        let v216 : string = "$0.re"
        let v217 : float = Fable.Core.RustInterop.emitRustExpr v1 v216 
        let v218 : float = 1.0 - v217
        let v219 : string = "$0.im"
        let v220 : float = Fable.Core.RustInterop.emitRustExpr v1 v219 
        let v221 : float =  -v220
        let v222 : string = "num_complex::Complex::new($0, $1)"
        let v223 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v218, v221) v222 
        let v224 : string = "$0.re"
        let v225 : float = Fable.Core.RustInterop.emitRustExpr v223 v224 
        let v226 : bool = v225 <= 1.0
        let v1201 : num_complex_Complex<float> =
            if v226 then
                let v227 : string = "num_complex::Complex::new($0, $1)"
                let v228 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v227 
                v228
            else
                let v229 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v223) v229 
                let v230 : string = "$0.re"
                let v231 : float = Fable.Core.RustInterop.emitRustExpr v223 v230 
                let v232 : bool = v231 > 1.0
                if v232 then
                    let v233 : string = "num_complex::Complex::new($0, $1)"
                    let v234 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v233 
                    let v235 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v236 : Mut0 = {l0 = 0} : Mut0
                    while method14(v236) do
                        let v238 : int32 = v236.l0
                        v235.[int v238] <- v238
                        let v239 : int32 = v238 + 1
                        v236.l0 <- v239
                        ()
                    let v240 : int32 = v235.Length
                    let v241 : Mut2 = {l0 = 0; l1 = v234} : Mut2
                    while method15(v240, v241) do
                        let v243 : int32 = v241.l0
                        let v244 : num_complex_Complex<float> = v241.l1
                        let v245 : int32 = v235.[int v243]
                        let v246 : string = "num_complex::Complex::new($0, $1)"
                        let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v246 
                        let v256 : (int32 -> float) = float
                        let v257 : float = v256 v245
                        let v269 : string = "num_complex::Complex::new($0, $1)"
                        let v270 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v257, 0.0) v269 
                        let v271 : string = "num_complex::Complex::powc($0, $1)"
                        let v272 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v270, v223) v271 
                        let v273 : string = "$0 / $1"
                        let v274 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v247, v272) v273 
                        let v275 : string = "$0 + $1"
                        let v276 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v244, v274) v275 
                        let v277 : int32 = v243 + 1
                        v241.l0 <- v277
                        v241.l1 <- v276
                        ()
                    let v278 : num_complex_Complex<float> = v241.l1
                    v278
                else
                    let v279 : string = "num_complex::Complex::new($0, $1)"
                    let v280 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v279 
                    let v281 : string = "$0 - $1"
                    let v282 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v280, v223) v281 
                    let v283 : string = $"        s = mpmath.gamma(s)"
                    let v284 : num_complex_Complex<float> = method3(v282)
                    let v285 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v283, v284)
                    (* run_target_args'
                    let v288 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v289 : string = "$0.ok()"
                    let v290 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v285 v289 
                    let _run_target_args'_v288 = v290 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v291 : string = "$0.ok()"
                    let v292 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v285 v291 
                    let _run_target_args'_v288 = v292 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v293 : string = "$0.ok()"
                    let v294 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v285 v293 
                    let _run_target_args'_v288 = v294 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v295 : num_complex_Complex<float> option = match v285 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v288 = v295 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v296 : num_complex_Complex<float> option = match v285 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v288 = v296 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v297 : num_complex_Complex<float> option = match v285 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v288 = v297 
                    #endif
#else
                    let v298 : num_complex_Complex<float> option = match v285 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v288 = v298 
                    #endif
                    let v299 : num_complex_Complex<float> option = _run_target_args'_v288 
                    let v325 : (num_complex_Complex<float> -> US0) = method17()
                    let v326 : US0 option = v299 |> Option.map v325 
                    let v410 : US0 = US0_1
                    let v411 : US0 = v326 |> Option.defaultValue v410 
                    let v424 : string = "f64::NAN"
                    let v425 : float = Fable.Core.RustInterop.emitRustExpr () v424 
                    let v426 : string = "f64::NAN"
                    let v427 : float = Fable.Core.RustInterop.emitRustExpr () v426 
                    let v428 : string = "num_complex::Complex::new($0, $1)"
                    let v429 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v425, v427) v428 
                    let v432 : num_complex_Complex<float> =
                        match v411 with
                        | US0_1 -> (* None *)
                            v429
                        | US0_0(v430) -> (* Some *)
                            v430
                    let v433 : string = "num_complex::Complex::new($0, $1)"
                    let v434 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v433 
                    let v435 : string = "$0 * $1"
                    let v436 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v434, v223) v435 
                    let v437 : string = "num_complex::Complex::new($0, $1)"
                    let v438 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v437 
                    let v439 : string = "$0 / $1"
                    let v440 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v436, v438) v439 
                    let v441 : string = "$0.sin()"
                    let v442 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v440 v441 
                    let v443 : string = "$0.re"
                    let v444 : float = Fable.Core.RustInterop.emitRustExpr v223 v443 
                    let v445 : float = 1.0 - v444
                    let v446 : string = "$0.im"
                    let v447 : float = Fable.Core.RustInterop.emitRustExpr v223 v446 
                    let v448 : float =  -v447
                    let v449 : string = "num_complex::Complex::new($0, $1)"
                    let v450 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v445, v448) v449 
                    let v451 : string = "$0.re"
                    let v452 : float = Fable.Core.RustInterop.emitRustExpr v450 v451 
                    let v453 : bool = v452 <= 1.0
                    let v1185 : num_complex_Complex<float> =
                        if v453 then
                            let v454 : string = "num_complex::Complex::new($0, $1)"
                            let v455 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v454 
                            v455
                        else
                            let v456 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v450) v456 
                            let v457 : string = "$0.re"
                            let v458 : float = Fable.Core.RustInterop.emitRustExpr v450 v457 
                            let v459 : bool = v458 > 1.0
                            if v459 then
                                let v460 : string = "num_complex::Complex::new($0, $1)"
                                let v461 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v460 
                                let v462 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v463 : Mut0 = {l0 = 0} : Mut0
                                while method14(v463) do
                                    let v465 : int32 = v463.l0
                                    v462.[int v465] <- v465
                                    let v466 : int32 = v465 + 1
                                    v463.l0 <- v466
                                    ()
                                let v467 : int32 = v462.Length
                                let v468 : Mut2 = {l0 = 0; l1 = v461} : Mut2
                                while method15(v467, v468) do
                                    let v470 : int32 = v468.l0
                                    let v471 : num_complex_Complex<float> = v468.l1
                                    let v472 : int32 = v462.[int v470]
                                    let v473 : string = "num_complex::Complex::new($0, $1)"
                                    let v474 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v473 
                                    let v483 : (int32 -> float) = float
                                    let v484 : float = v483 v472
                                    let v496 : string = "num_complex::Complex::new($0, $1)"
                                    let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v484, 0.0) v496 
                                    let v498 : string = "num_complex::Complex::powc($0, $1)"
                                    let v499 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v497, v450) v498 
                                    let v500 : string = "$0 / $1"
                                    let v501 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v474, v499) v500 
                                    let v502 : string = "$0 + $1"
                                    let v503 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v471, v501) v502 
                                    let v504 : int32 = v470 + 1
                                    v468.l0 <- v504
                                    v468.l1 <- v503
                                    ()
                                let v505 : num_complex_Complex<float> = v468.l1
                                v505
                            else
                                let v506 : string = "num_complex::Complex::new($0, $1)"
                                let v507 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v506 
                                let v508 : string = "$0 - $1"
                                let v509 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v507, v450) v508 
                                let v510 : string = $"        s = mpmath.gamma(s)"
                                let v511 : num_complex_Complex<float> = method3(v509)
                                let v512 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v510, v511)
                                (* run_target_args'
                                let v515 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v516 : string = "$0.ok()"
                                let v517 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v512 v516 
                                let _run_target_args'_v515 = v517 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v518 : string = "$0.ok()"
                                let v519 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v512 v518 
                                let _run_target_args'_v515 = v519 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v520 : string = "$0.ok()"
                                let v521 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v512 v520 
                                let _run_target_args'_v515 = v521 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v522 : num_complex_Complex<float> option = match v512 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v515 = v522 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v523 : num_complex_Complex<float> option = match v512 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v515 = v523 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v524 : num_complex_Complex<float> option = match v512 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v515 = v524 
                                #endif
#else
                                let v525 : num_complex_Complex<float> option = match v512 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v515 = v525 
                                #endif
                                let v526 : num_complex_Complex<float> option = _run_target_args'_v515 
                                let v552 : (num_complex_Complex<float> -> US0) = method17()
                                let v553 : US0 option = v526 |> Option.map v552 
                                let v637 : US0 = US0_1
                                let v638 : US0 = v553 |> Option.defaultValue v637 
                                let v651 : string = "f64::NAN"
                                let v652 : float = Fable.Core.RustInterop.emitRustExpr () v651 
                                let v653 : string = "f64::NAN"
                                let v654 : float = Fable.Core.RustInterop.emitRustExpr () v653 
                                let v655 : string = "num_complex::Complex::new($0, $1)"
                                let v656 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v652, v654) v655 
                                let v659 : num_complex_Complex<float> =
                                    match v638 with
                                    | US0_1 -> (* None *)
                                        v656
                                    | US0_0(v657) -> (* Some *)
                                        v657
                                let v660 : string = "num_complex::Complex::new($0, $1)"
                                let v661 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v660 
                                let v662 : string = "$0 * $1"
                                let v663 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v661, v450) v662 
                                let v664 : string = "num_complex::Complex::new($0, $1)"
                                let v665 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v664 
                                let v666 : string = "$0 / $1"
                                let v667 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v663, v665) v666 
                                let v668 : string = "$0.sin()"
                                let v669 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v667 v668 
                                let v670 : string = "$0.re"
                                let v671 : float = Fable.Core.RustInterop.emitRustExpr v450 v670 
                                let v672 : float = 1.0 - v671
                                let v673 : string = "$0.im"
                                let v674 : float = Fable.Core.RustInterop.emitRustExpr v450 v673 
                                let v675 : float =  -v674
                                let v676 : string = "num_complex::Complex::new($0, $1)"
                                let v677 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v672, v675) v676 
                                let v678 : string = "$0.re"
                                let v679 : float = Fable.Core.RustInterop.emitRustExpr v677 v678 
                                let v680 : bool = v679 <= 1.0
                                let v1169 : num_complex_Complex<float> =
                                    if v680 then
                                        let v681 : string = "num_complex::Complex::new($0, $1)"
                                        let v682 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v681 
                                        v682
                                    else
                                        let v683 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v677) v683 
                                        let v684 : string = "$0.re"
                                        let v685 : float = Fable.Core.RustInterop.emitRustExpr v677 v684 
                                        let v686 : bool = v685 > 1.0
                                        if v686 then
                                            let v687 : string = "num_complex::Complex::new($0, $1)"
                                            let v688 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v687 
                                            let v689 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v690 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v690) do
                                                let v692 : int32 = v690.l0
                                                v689.[int v692] <- v692
                                                let v693 : int32 = v692 + 1
                                                v690.l0 <- v693
                                                ()
                                            let v694 : int32 = v689.Length
                                            let v695 : Mut2 = {l0 = 0; l1 = v688} : Mut2
                                            while method15(v694, v695) do
                                                let v697 : int32 = v695.l0
                                                let v698 : num_complex_Complex<float> = v695.l1
                                                let v699 : int32 = v689.[int v697]
                                                let v700 : string = "num_complex::Complex::new($0, $1)"
                                                let v701 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v700 
                                                let v710 : (int32 -> float) = float
                                                let v711 : float = v710 v699
                                                let v723 : string = "num_complex::Complex::new($0, $1)"
                                                let v724 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v711, 0.0) v723 
                                                let v725 : string = "num_complex::Complex::powc($0, $1)"
                                                let v726 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v724, v677) v725 
                                                let v727 : string = "$0 / $1"
                                                let v728 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v701, v726) v727 
                                                let v729 : string = "$0 + $1"
                                                let v730 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v698, v728) v729 
                                                let v731 : int32 = v697 + 1
                                                v695.l0 <- v731
                                                v695.l1 <- v730
                                                ()
                                            let v732 : num_complex_Complex<float> = v695.l1
                                            v732
                                        else
                                            let v733 : string = "num_complex::Complex::new($0, $1)"
                                            let v734 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v733 
                                            let v735 : string = "$0 - $1"
                                            let v736 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v734, v677) v735 
                                            let v737 : string = $"        s = mpmath.gamma(s)"
                                            let v738 : num_complex_Complex<float> = method3(v736)
                                            let v739 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v737, v738)
                                            (* run_target_args'
                                            let v742 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v743 : string = "$0.ok()"
                                            let v744 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v739 v743 
                                            let _run_target_args'_v742 = v744 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v745 : string = "$0.ok()"
                                            let v746 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v739 v745 
                                            let _run_target_args'_v742 = v746 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v747 : string = "$0.ok()"
                                            let v748 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v739 v747 
                                            let _run_target_args'_v742 = v748 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v749 : num_complex_Complex<float> option = match v739 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v742 = v749 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v750 : num_complex_Complex<float> option = match v739 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v742 = v750 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v751 : num_complex_Complex<float> option = match v739 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v742 = v751 
                                            #endif
#else
                                            let v752 : num_complex_Complex<float> option = match v739 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v742 = v752 
                                            #endif
                                            let v753 : num_complex_Complex<float> option = _run_target_args'_v742 
                                            let v779 : (num_complex_Complex<float> -> US0) = method17()
                                            let v780 : US0 option = v753 |> Option.map v779 
                                            let v864 : US0 = US0_1
                                            let v865 : US0 = v780 |> Option.defaultValue v864 
                                            let v878 : string = "f64::NAN"
                                            let v879 : float = Fable.Core.RustInterop.emitRustExpr () v878 
                                            let v880 : string = "f64::NAN"
                                            let v881 : float = Fable.Core.RustInterop.emitRustExpr () v880 
                                            let v882 : string = "num_complex::Complex::new($0, $1)"
                                            let v883 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v879, v881) v882 
                                            let v886 : num_complex_Complex<float> =
                                                match v865 with
                                                | US0_1 -> (* None *)
                                                    v883
                                                | US0_0(v884) -> (* Some *)
                                                    v884
                                            let v887 : string = "num_complex::Complex::new($0, $1)"
                                            let v888 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v887 
                                            let v889 : string = "$0 * $1"
                                            let v890 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v888, v677) v889 
                                            let v891 : string = "num_complex::Complex::new($0, $1)"
                                            let v892 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v891 
                                            let v893 : string = "$0 / $1"
                                            let v894 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v890, v892) v893 
                                            let v895 : string = "$0.sin()"
                                            let v896 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v894 v895 
                                            let v897 : string = "$0.re"
                                            let v898 : float = Fable.Core.RustInterop.emitRustExpr v677 v897 
                                            let v899 : float = 1.0 - v898
                                            let v900 : string = "$0.im"
                                            let v901 : float = Fable.Core.RustInterop.emitRustExpr v677 v900 
                                            let v902 : float =  -v901
                                            let v903 : string = "num_complex::Complex::new($0, $1)"
                                            let v904 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v899, v902) v903 
                                            let v905 : string = "$0.re"
                                            let v906 : float = Fable.Core.RustInterop.emitRustExpr v904 v905 
                                            let v907 : bool = v906 <= 1.0
                                            let v1153 : num_complex_Complex<float> =
                                                if v907 then
                                                    let v908 : string = "num_complex::Complex::new($0, $1)"
                                                    let v909 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v908 
                                                    v909
                                                else
                                                    let v910 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v904) v910 
                                                    let v911 : string = "$0.re"
                                                    let v912 : float = Fable.Core.RustInterop.emitRustExpr v904 v911 
                                                    let v913 : bool = v912 > 1.0
                                                    if v913 then
                                                        let v914 : string = "num_complex::Complex::new($0, $1)"
                                                        let v915 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v914 
                                                        let v916 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v917 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v917) do
                                                            let v919 : int32 = v917.l0
                                                            v916.[int v919] <- v919
                                                            let v920 : int32 = v919 + 1
                                                            v917.l0 <- v920
                                                            ()
                                                        let v921 : int32 = v916.Length
                                                        let v922 : Mut2 = {l0 = 0; l1 = v915} : Mut2
                                                        while method15(v921, v922) do
                                                            let v924 : int32 = v922.l0
                                                            let v925 : num_complex_Complex<float> = v922.l1
                                                            let v926 : int32 = v916.[int v924]
                                                            let v927 : string = "num_complex::Complex::new($0, $1)"
                                                            let v928 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v927 
                                                            let v937 : (int32 -> float) = float
                                                            let v938 : float = v937 v926
                                                            let v950 : string = "num_complex::Complex::new($0, $1)"
                                                            let v951 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v938, 0.0) v950 
                                                            let v952 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v953 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v951, v904) v952 
                                                            let v954 : string = "$0 / $1"
                                                            let v955 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v928, v953) v954 
                                                            let v956 : string = "$0 + $1"
                                                            let v957 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v925, v955) v956 
                                                            let v958 : int32 = v924 + 1
                                                            v922.l0 <- v958
                                                            v922.l1 <- v957
                                                            ()
                                                        let v959 : num_complex_Complex<float> = v922.l1
                                                        v959
                                                    else
                                                        let v960 : string = "num_complex::Complex::new($0, $1)"
                                                        let v961 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v960 
                                                        let v962 : string = "$0 - $1"
                                                        let v963 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v961, v904) v962 
                                                        let v964 : string = $"        s = mpmath.gamma(s)"
                                                        let v965 : num_complex_Complex<float> = method3(v963)
                                                        let v966 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v964, v965)
                                                        (* run_target_args'
                                                        let v969 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v970 : string = "$0.ok()"
                                                        let v971 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v966 v970 
                                                        let _run_target_args'_v969 = v971 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v972 : string = "$0.ok()"
                                                        let v973 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v966 v972 
                                                        let _run_target_args'_v969 = v973 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v974 : string = "$0.ok()"
                                                        let v975 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v966 v974 
                                                        let _run_target_args'_v969 = v975 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v976 : num_complex_Complex<float> option = match v966 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v969 = v976 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v977 : num_complex_Complex<float> option = match v966 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v969 = v977 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v978 : num_complex_Complex<float> option = match v966 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v969 = v978 
                                                        #endif
#else
                                                        let v979 : num_complex_Complex<float> option = match v966 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v969 = v979 
                                                        #endif
                                                        let v980 : num_complex_Complex<float> option = _run_target_args'_v969 
                                                        let v1006 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v1007 : US0 option = v980 |> Option.map v1006 
                                                        let v1091 : US0 = US0_1
                                                        let v1092 : US0 = v1007 |> Option.defaultValue v1091 
                                                        let v1105 : string = "f64::NAN"
                                                        let v1106 : float = Fable.Core.RustInterop.emitRustExpr () v1105 
                                                        let v1107 : string = "f64::NAN"
                                                        let v1108 : float = Fable.Core.RustInterop.emitRustExpr () v1107 
                                                        let v1109 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1110 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1106, v1108) v1109 
                                                        let v1113 : num_complex_Complex<float> =
                                                            match v1092 with
                                                            | US0_1 -> (* None *)
                                                                v1110
                                                            | US0_0(v1111) -> (* Some *)
                                                                v1111
                                                        let v1114 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1114 
                                                        let v1116 : string = "$0 * $1"
                                                        let v1117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1115, v904) v1116 
                                                        let v1118 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1119 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1118 
                                                        let v1120 : string = "$0 / $1"
                                                        let v1121 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1117, v1119) v1120 
                                                        let v1122 : string = "$0.sin()"
                                                        let v1123 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v1121 v1122 
                                                        let v1124 : string = "$0.re"
                                                        let v1125 : float = Fable.Core.RustInterop.emitRustExpr v904 v1124 
                                                        let v1126 : float = 1.0 - v1125
                                                        let v1127 : string = "$0.im"
                                                        let v1128 : float = Fable.Core.RustInterop.emitRustExpr v904 v1127 
                                                        let v1129 : float =  -v1128
                                                        let v1130 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1131 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1126, v1129) v1130 
                                                        let v1132 : string = "$0.re"
                                                        let v1133 : float = Fable.Core.RustInterop.emitRustExpr v1131 v1132 
                                                        let v1134 : bool = v1133 <= 1.0
                                                        let v1137 : num_complex_Complex<float> =
                                                            if v1134 then
                                                                let v1135 : string = "num_complex::Complex::new($0, $1)"
                                                                let v1136 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v1135 
                                                                v1136
                                                            else
                                                                v1131
                                                        let v1138 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1139 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1138 
                                                        let v1140 : string = "num_complex::Complex::new($0, $1)"
                                                        let v1141 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1140 
                                                        let v1142 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v1143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1141, v904) v1142 
                                                        let v1144 : string = "$0 * $1"
                                                        let v1145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1139, v1143) v1144 
                                                        let v1146 : string = "$0 * $1"
                                                        let v1147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1145, v1123) v1146 
                                                        let v1148 : string = "$0 * $1"
                                                        let v1149 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1147, v1113) v1148 
                                                        let v1150 : string = "$0 * $1"
                                                        let v1151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1149, v1137) v1150 
                                                        v1151
                                            let v1154 : string = "num_complex::Complex::new($0, $1)"
                                            let v1155 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1154 
                                            let v1156 : string = "num_complex::Complex::new($0, $1)"
                                            let v1157 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1156 
                                            let v1158 : string = "num_complex::Complex::powc($0, $1)"
                                            let v1159 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1157, v677) v1158 
                                            let v1160 : string = "$0 * $1"
                                            let v1161 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1155, v1159) v1160 
                                            let v1162 : string = "$0 * $1"
                                            let v1163 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1161, v896) v1162 
                                            let v1164 : string = "$0 * $1"
                                            let v1165 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1163, v886) v1164 
                                            let v1166 : string = "$0 * $1"
                                            let v1167 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1165, v1153) v1166 
                                            v1167
                                let v1170 : string = "num_complex::Complex::new($0, $1)"
                                let v1171 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1170 
                                let v1172 : string = "num_complex::Complex::new($0, $1)"
                                let v1173 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1172 
                                let v1174 : string = "num_complex::Complex::powc($0, $1)"
                                let v1175 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1173, v450) v1174 
                                let v1176 : string = "$0 * $1"
                                let v1177 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1171, v1175) v1176 
                                let v1178 : string = "$0 * $1"
                                let v1179 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1177, v669) v1178 
                                let v1180 : string = "$0 * $1"
                                let v1181 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1179, v659) v1180 
                                let v1182 : string = "$0 * $1"
                                let v1183 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1181, v1169) v1182 
                                v1183
                    let v1186 : string = "num_complex::Complex::new($0, $1)"
                    let v1187 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1186 
                    let v1188 : string = "num_complex::Complex::new($0, $1)"
                    let v1189 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1188 
                    let v1190 : string = "num_complex::Complex::powc($0, $1)"
                    let v1191 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1189, v223) v1190 
                    let v1192 : string = "$0 * $1"
                    let v1193 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1187, v1191) v1192 
                    let v1194 : string = "$0 * $1"
                    let v1195 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1193, v442) v1194 
                    let v1196 : string = "$0 * $1"
                    let v1197 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1195, v432) v1196 
                    let v1198 : string = "$0 * $1"
                    let v1199 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1197, v1185) v1198 
                    v1199
        let v1202 : string = "num_complex::Complex::new($0, $1)"
        let v1203 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v1202 
        let v1204 : string = "num_complex::Complex::new($0, $1)"
        let v1205 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v1204 
        let v1206 : string = "num_complex::Complex::powc($0, $1)"
        let v1207 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1205, v1) v1206 
        let v1208 : string = "$0 * $1"
        let v1209 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1203, v1207) v1208 
        let v1210 : string = "$0 * $1"
        let v1211 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1209, v215) v1210 
        let v1212 : string = "$0 * $1"
        let v1213 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1211, v205) v1212 
        let v1214 : string = "$0 * $1"
        let v1215 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v1213, v1201) v1214 
        v1215
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v27 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v18 = v27 
        #endif
#else
        let v28 : num_complex_Complex<float> option = match v14 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v18 = v28 
        #endif
        let v29 : num_complex_Complex<float> option = _run_target_args'_v18 
        let v55 : (num_complex_Complex<float> -> US0) = method17()
        let v56 : US0 option = v29 |> Option.map v55 
        let v140 : US0 = US0_1
        let v141 : US0 = v56 |> Option.defaultValue v140 
        let v154 : string = "f64::NAN"
        let v155 : float = Fable.Core.RustInterop.emitRustExpr () v154 
        let v156 : string = "f64::NAN"
        let v157 : float = Fable.Core.RustInterop.emitRustExpr () v156 
        let v158 : string = "num_complex::Complex::new($0, $1)"
        let v159 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v155, v157) v158 
        let v162 : num_complex_Complex<float> =
            match v141 with
            | US0_1 -> (* None *)
                v159
            | US0_0(v160) -> (* Some *)
                v160
        let v163 : string = "$0.im"
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
        let v197 : string =
            if v165 then
                let v193 : float = 0.0
                method19(v193)
            else
                let v195 : float = 0.0
                method26(v164, v195)
        let v200 : string = v181 + v197 
        let v242 : unit = ()
        let v243 : (unit -> unit) = closure2(v200)
        let v244 : unit = (fun () -> v243 (); v242) ()
        let v256 : bool = v167 = false
        if v256 then
            failwith<unit> v200
        let v257 : string = "$0.re"
        let v258 : float = Fable.Core.RustInterop.emitRustExpr v162 v257 
        let v259 : float = v258 - v11
        let v260 : float =  -v259
        let v261 : bool = v259 >= v260
        let v262 : float =
            if v261 then
                v259
            else
                v260
        let v263 : bool = v262 < 0.0001
        let v265 : bool =
            if v263 then
                true
            else
                method18(v263)
        let v270 : string =
            if v263 then
                let v266 : float = 0.0001
                method19(v266)
            else
                let v268 : float = 0.0001
                method26(v262, v268)
        let v275 : string = "__assert_lt"
        let v276 : string = v275 + v180 
        let v292 : string =
            if v263 then
                let v288 : float = 0.0001
                method19(v288)
            else
                let v290 : float = 0.0001
                method26(v262, v290)
        let v295 : string = v276 + v292 
        let v337 : unit = ()
        let v338 : (unit -> unit) = closure2(v295)
        let v339 : unit = (fun () -> v338 (); v337) ()
        let v351 : bool = v265 = false
        if v351 then
            failwith<unit> v295
        let v352 : int32 = v9 + 1
        v7.l0 <- v352
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
#else
    let v19 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v19 
    #endif
    let v20 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v46 : (num_complex_Complex<float> -> US0) = method17()
    let v47 : US0 option = v20 |> Option.map v46 
    let v131 : US0 = US0_1
    let v132 : US0 = v47 |> Option.defaultValue v131 
    let v145 : string = "f64::NAN"
    let v146 : float = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "f64::NAN"
    let v148 : float = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "num_complex::Complex::new($0, $1)"
    let v150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v146, v148) v149 
    let v153 : num_complex_Complex<float> =
        match v132 with
        | US0_1 -> (* None *)
            v150
        | US0_0(v151) -> (* Some *)
            v151
    let v154 : string = "$0.re"
    let v155 : float = Fable.Core.RustInterop.emitRustExpr v153 v154 
    let v156 : float = v155 - 0.8673
    let v157 : float =  -v156
    let v158 : bool = v156 >= v157
    let v159 : float =
        if v158 then
            v156
        else
            v157
    let v160 : bool = v159 < 0.001
    let v162 : bool =
        if v160 then
            true
        else
            method18(v160)
    let v167 : string =
        if v160 then
            let v163 : float = 0.001
            method19(v163)
        else
            let v165 : float = 0.001
            method26(v159, v165)
    let v174 : string = "__assert_lt"
    let v175 : string = " "
    let v176 : string = v174 + v175 
    let v192 : string =
        if v160 then
            let v188 : float = 0.001
            method19(v188)
        else
            let v190 : float = 0.001
            method26(v159, v190)
    let v195 : string = v176 + v192 
    let v237 : unit = ()
    let v238 : (unit -> unit) = closure2(v195)
    let v239 : unit = (fun () -> v238 (); v237) ()
    let v251 : bool = v162 = false
    if v251 then
        failwith<unit> v195
    let v252 : string = "$0.im"
    let v253 : float = Fable.Core.RustInterop.emitRustExpr v153 v252 
    let v254 : float = v253 - 0.275
    let v255 : float =  -v254
    let v256 : bool = v254 >= v255
    let v257 : float =
        if v256 then
            v254
        else
            v255
    let v258 : bool = v257 < 0.001
    let v260 : bool =
        if v258 then
            true
        else
            method18(v258)
    let v265 : string =
        if v258 then
            let v261 : float = 0.001
            method19(v261)
        else
            let v263 : float = 0.001
            method26(v257, v263)
    let v268 : string = v174 + v175 
    let v284 : string =
        if v258 then
            let v280 : float = 0.001
            method19(v280)
        else
            let v282 : float = 0.001
            method26(v257, v282)
    let v287 : string = v268 + v284 
    let v329 : unit = ()
    let v330 : (unit -> unit) = closure2(v287)
    let v331 : unit = (fun () -> v330 (); v329) ()
    let v343 : bool = v260 = false
    if v343 then
        failwith<unit> v287
and method30 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v21 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v21 
        #endif
#else
        let v22 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v22 
        #endif
        let v23 : num_complex_Complex<float> option = _run_target_args'_v12 
        let v49 : (num_complex_Complex<float> -> US0) = method17()
        let v50 : US0 option = v23 |> Option.map v49 
        let v134 : US0 = US0_1
        let v135 : US0 = v50 |> Option.defaultValue v134 
        let v148 : string = "f64::NAN"
        let v149 : float = Fable.Core.RustInterop.emitRustExpr () v148 
        let v150 : string = "f64::NAN"
        let v151 : float = Fable.Core.RustInterop.emitRustExpr () v150 
        let v152 : string = "num_complex::Complex::new($0, $1)"
        let v153 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v149, v151) v152 
        let v156 : num_complex_Complex<float> =
            match v135 with
            | US0_1 -> (* None *)
                v153
            | US0_0(v154) -> (* Some *)
                v154
        let v157 : string = "$0.re"
        let v158 : float = Fable.Core.RustInterop.emitRustExpr v156 v157 
        let v159 : bool = v158 = 0.0
        let v161 : bool =
            if v159 then
                true
            else
                method18(v159)
        let v166 : string =
            if v159 then
                let v162 : float = 0.0
                method19(v162)
            else
                let v164 : float = 0.0
                method26(v158, v164)
        let v173 : string = "__assert_eq"
        let v174 : string = " "
        let v175 : string = v173 + v174 
        let v191 : string =
            if v159 then
                let v187 : float = 0.0
                method19(v187)
            else
                let v189 : float = 0.0
                method26(v158, v189)
        let v194 : string = v175 + v191 
        let v236 : unit = ()
        let v237 : (unit -> unit) = closure2(v194)
        let v238 : unit = (fun () -> v237 (); v236) ()
        let v250 : bool = v161 = false
        if v250 then
            failwith<unit> v194
        let v251 : string = "$0.im"
        let v252 : float = Fable.Core.RustInterop.emitRustExpr v156 v251 
        let v253 : bool = v252 = 0.0
        let v255 : bool =
            if v253 then
                true
            else
                method18(v253)
        let v260 : string =
            if v253 then
                let v256 : float = 0.0
                method19(v256)
            else
                let v258 : float = 0.0
                method26(v252, v258)
        let v263 : string = v173 + v174 
        let v279 : string =
            if v253 then
                let v275 : float = 0.0
                method19(v275)
            else
                let v277 : float = 0.0
                method26(v252, v277)
        let v282 : string = v263 + v279 
        let v324 : unit = ()
        let v325 : (unit -> unit) = closure2(v282)
        let v326 : unit = (fun () -> v325 (); v324) ()
        let v338 : bool = v255 = false
        if v338 then
            failwith<unit> v282
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v34 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v25 = v34 
        #endif
#else
        let v35 : num_complex_Complex<float> option = match v21 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v25 = v35 
        #endif
        let v36 : num_complex_Complex<float> option = _run_target_args'_v25 
        let v62 : (num_complex_Complex<float> -> US0) = method17()
        let v63 : US0 option = v36 |> Option.map v62 
        let v147 : US0 = US0_1
        let v148 : US0 = v63 |> Option.defaultValue v147 
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
        let v172 : float =  -v171
        let v173 : bool = v171 >= v172
        let v174 : float =
            if v173 then
                v171
            else
                v172
        let v175 : bool = v174 < 0.0001
        let v177 : bool =
            if v175 then
                true
            else
                method18(v175)
        let v182 : string =
            if v175 then
                let v178 : float = 0.0001
                method19(v178)
            else
                let v180 : float = 0.0001
                method26(v174, v180)
        let v189 : string = "__assert_lt"
        let v190 : string = " "
        let v191 : string = v189 + v190 
        let v207 : string =
            if v175 then
                let v203 : float = 0.0001
                method19(v203)
            else
                let v205 : float = 0.0001
                method26(v174, v205)
        let v210 : string = v191 + v207 
        let v252 : unit = ()
        let v253 : (unit -> unit) = closure2(v210)
        let v254 : unit = (fun () -> v253 (); v252) ()
        let v266 : bool = v177 = false
        if v266 then
            failwith<unit> v210
        let v267 : string = "$0.im"
        let v268 : float = Fable.Core.RustInterop.emitRustExpr v169 v267 
        let v269 : float =  -v268
        let v270 : bool = v268 >= v269
        let v271 : float =
            if v270 then
                v268
            else
                v269
        let v272 : bool = v271 < 0.0001
        let v274 : bool =
            if v272 then
                true
            else
                method18(v272)
        let v279 : string =
            if v272 then
                let v275 : float = 0.0001
                method19(v275)
            else
                let v277 : float = 0.0001
                method26(v271, v277)
        let v282 : string = v189 + v190 
        let v298 : string =
            if v272 then
                let v294 : float = 0.0001
                method19(v294)
            else
                let v296 : float = 0.0001
                method26(v271, v296)
        let v301 : string = v282 + v298 
        let v343 : unit = ()
        let v344 : (unit -> unit) = closure2(v301)
        let v345 : unit = (fun () -> v344 (); v343) ()
        let v357 : bool = v274 = false
        if v357 then
            failwith<unit> v301
        let v358 : int32 = v17 + 1
        v15.l0 <- v358
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v24 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v24 
        #endif
#else
        let v25 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v25 
        #endif
        let v26 : num_complex_Complex<float> option = _run_target_args'_v15 
        let v52 : (num_complex_Complex<float> -> US0) = method17()
        let v53 : US0 option = v26 |> Option.map v52 
        let v137 : US0 = US0_1
        let v138 : US0 = v53 |> Option.defaultValue v137 
        let v151 : string = "f64::NAN"
        let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
        let v153 : string = "f64::NAN"
        let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
        let v155 : string = "num_complex::Complex::new($0, $1)"
        let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
        let v159 : num_complex_Complex<float> =
            match v138 with
            | US0_1 -> (* None *)
                v156
            | US0_0(v157) -> (* Some *)
                v157
        let v160 : string = "$0.re"
        let v161 : float = Fable.Core.RustInterop.emitRustExpr v159 v160 
        let v162 : bool = v161 > 0.0
        let v164 : bool =
            if v162 then
                true
            else
                method18(v162)
        let v169 : string =
            if v162 then
                let v165 : float = 0.0
                method19(v165)
            else
                let v167 : float = 0.0
                method26(v161, v167)
        let v176 : string = "__assert_gt"
        let v177 : string = " "
        let v178 : string = v176 + v177 
        let v194 : string =
            if v162 then
                let v190 : float = 0.0
                method19(v190)
            else
                let v192 : float = 0.0
                method26(v161, v192)
        let v197 : string = v178 + v194 
        let v239 : unit = ()
        let v240 : (unit -> unit) = closure2(v197)
        let v241 : unit = (fun () -> v240 (); v239) ()
        let v253 : bool = v164 = false
        if v253 then
            failwith<unit> v197
        let v254 : string = "$0.im"
        let v255 : float = Fable.Core.RustInterop.emitRustExpr v159 v254 
        let v256 : bool = v255 = 0.0
        let v258 : bool =
            if v256 then
                true
            else
                method18(v256)
        let v263 : string =
            if v256 then
                let v259 : float = 0.0
                method19(v259)
            else
                let v261 : float = 0.0
                method26(v255, v261)
        let v268 : string = "__assert_eq"
        let v269 : string = v268 + v177 
        let v285 : string =
            if v256 then
                let v281 : float = 0.0
                method19(v281)
            else
                let v283 : float = 0.0
                method26(v255, v283)
        let v288 : string = v269 + v285 
        let v330 : unit = ()
        let v331 : (unit -> unit) = closure2(v288)
        let v332 : unit = (fun () -> v331 (); v330) ()
        let v344 : bool = v258 = false
        if v344 then
            failwith<unit> v288
        let v345 : int32 = v5 + 1
        v3.l0 <- v345
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
#else
    let v19 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v19 
    #endif
    let v20 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v46 : (num_complex_Complex<float> -> US0) = method17()
    let v47 : US0 option = v20 |> Option.map v46 
    let v131 : US0 = US0_1
    let v132 : US0 = v47 |> Option.defaultValue v131 
    let v145 : string = "f64::NAN"
    let v146 : float = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "f64::NAN"
    let v148 : float = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "num_complex::Complex::new($0, $1)"
    let v150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v146, v148) v149 
    let v153 : num_complex_Complex<float> =
        match v132 with
        | US0_1 -> (* None *)
            v150
        | US0_0(v151) -> (* Some *)
            v151
    let v154 : string = "$0.re"
    let v155 : float = Fable.Core.RustInterop.emitRustExpr v153 v154 
    let v156 : bool = v155 = infinity
    let v158 : bool =
        if v156 then
            true
        else
            method18(v156)
    let v163 : string =
        if v156 then
            let v159 : float = infinity
            method19(v159)
        else
            let v161 : float = infinity
            method26(v155, v161)
    let v170 : string = "__assert_eq"
    let v171 : string = " "
    let v172 : string = v170 + v171 
    let v188 : string =
        if v156 then
            let v184 : float = infinity
            method19(v184)
        else
            let v186 : float = infinity
            method26(v155, v186)
    let v191 : string = v172 + v188 
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure2(v191)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v247 : bool = v158 = false
    if v247 then
        failwith<unit> v191
    let v248 : string = "$0.im"
    let v249 : float = Fable.Core.RustInterop.emitRustExpr v153 v248 
    let v250 : bool = v249 = 0.0
    let v252 : bool =
        if v250 then
            true
        else
            method18(v250)
    let v257 : string =
        if v250 then
            let v253 : float = 0.0
            method19(v253)
        else
            let v255 : float = 0.0
            method26(v249, v255)
    let v260 : string = v170 + v171 
    let v276 : string =
        if v250 then
            let v272 : float = 0.0
            method19(v272)
        else
            let v274 : float = 0.0
            method26(v249, v274)
    let v279 : string = v260 + v276 
    let v321 : unit = ()
    let v322 : (unit -> unit) = closure2(v279)
    let v323 : unit = (fun () -> v322 (); v321) ()
    let v335 : bool = v252 = false
    if v335 then
        failwith<unit> v279
and method40 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method41(v3)
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
#else
    let v19 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v19 
    #endif
    let v20 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v46 : (num_complex_Complex<float> -> US0) = method17()
    let v47 : US0 option = v20 |> Option.map v46 
    let v131 : US0 = US0_1
    let v132 : US0 = v47 |> Option.defaultValue v131 
    let v145 : string = "f64::NAN"
    let v146 : float = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "f64::NAN"
    let v148 : float = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "num_complex::Complex::new($0, $1)"
    let v150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v146, v148) v149 
    let v153 : num_complex_Complex<float> =
        match v132 with
        | US0_1 -> (* None *)
            v150
        | US0_0(v151) -> (* Some *)
            v151
    let v154 : string = "$0.re"
    let v155 : float = Fable.Core.RustInterop.emitRustExpr v2 v154 
    let v156 : string = "$0.im"
    let v157 : float = Fable.Core.RustInterop.emitRustExpr v2 v156 
    let v158 : float =  -v157
    let v159 : string = "num_complex::Complex::new($0, $1)"
    let v160 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v155, v158) v159 
    let v161 : string = $"        s = mpmath.zeta(s)"
    let v162 : num_complex_Complex<float> = method3(v160)
    let v163 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v161, v162)
    let v164 : num_complex_Complex<float> = method13(v0, v160)
    (* run_target_args'
    let v167 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v168 : string = "$0.ok()"
    let v169 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v163 v168 
    let _run_target_args'_v167 = v169 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v170 : string = "$0.ok()"
    let v171 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v163 v170 
    let _run_target_args'_v167 = v171 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v172 : string = "$0.ok()"
    let v173 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v163 v172 
    let _run_target_args'_v167 = v173 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v174 : num_complex_Complex<float> option = match v163 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v167 = v174 
    #endif
#if FABLE_COMPILER_PYTHON
    let v175 : num_complex_Complex<float> option = match v163 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v167 = v175 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v176 : num_complex_Complex<float> option = match v163 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v167 = v176 
    #endif
#else
    let v177 : num_complex_Complex<float> option = match v163 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v167 = v177 
    #endif
    let v178 : num_complex_Complex<float> option = _run_target_args'_v167 
    let v204 : (num_complex_Complex<float> -> US0) = method17()
    let v205 : US0 option = v178 |> Option.map v204 
    let v289 : US0 = US0_1
    let v290 : US0 = v205 |> Option.defaultValue v289 
    let v303 : string = "f64::NAN"
    let v304 : float = Fable.Core.RustInterop.emitRustExpr () v303 
    let v305 : string = "f64::NAN"
    let v306 : float = Fable.Core.RustInterop.emitRustExpr () v305 
    let v307 : string = "num_complex::Complex::new($0, $1)"
    let v308 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v304, v306) v307 
    let v311 : num_complex_Complex<float> =
        match v290 with
        | US0_1 -> (* None *)
            v308
        | US0_0(v309) -> (* Some *)
            v309
    let v312 : string = "$0.conj()"
    let v313 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v311 v312 
    let v314 : string = "$0.re"
    let v315 : float = Fable.Core.RustInterop.emitRustExpr v153 v314 
    let v316 : string = "$0.re"
    let v317 : float = Fable.Core.RustInterop.emitRustExpr v313 v316 
    let v318 : bool = v315 = v317
    let v320 : bool =
        if v318 then
            true
        else
            method18(v318)
    let v323 : string =
        if v318 then
            method19(v317)
        else
            method26(v315, v317)
    let v330 : string = "__assert_eq"
    let v331 : string = " "
    let v332 : string = v330 + v331 
    let v346 : string =
        if v318 then
            method19(v317)
        else
            method26(v315, v317)
    let v349 : string = v332 + v346 
    let v391 : unit = ()
    let v392 : (unit -> unit) = closure2(v349)
    let v393 : unit = (fun () -> v392 (); v391) ()
    let v405 : bool = v320 = false
    if v405 then
        failwith<unit> v349
    let v406 : string = "$0.im"
    let v407 : float = Fable.Core.RustInterop.emitRustExpr v153 v406 
    let v408 : string = "$0.im"
    let v409 : float = Fable.Core.RustInterop.emitRustExpr v313 v408 
    let v410 : bool = v407 = v409
    let v412 : bool =
        if v410 then
            true
        else
            method18(v410)
    let v415 : string =
        if v410 then
            method19(v409)
        else
            method26(v407, v409)
    let v418 : string = v330 + v331 
    let v432 : string =
        if v410 then
            method19(v409)
        else
            method26(v407, v409)
    let v435 : string = v418 + v432 
    let v477 : unit = ()
    let v478 : (unit -> unit) = closure2(v435)
    let v479 : unit = (fun () -> v478 (); v477) ()
    let v491 : bool = v412 = false
    if v491 then
        failwith<unit> v435
and method42 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method43(v3)
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v18 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v18 
    #endif
#else
    let v19 : num_complex_Complex<float> option = match v5 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v9 = v19 
    #endif
    let v20 : num_complex_Complex<float> option = _run_target_args'_v9 
    let v46 : (num_complex_Complex<float> -> US0) = method17()
    let v47 : US0 option = v20 |> Option.map v46 
    let v131 : US0 = US0_1
    let v132 : US0 = v47 |> Option.defaultValue v131 
    let v145 : string = "f64::NAN"
    let v146 : float = Fable.Core.RustInterop.emitRustExpr () v145 
    let v147 : string = "f64::NAN"
    let v148 : float = Fable.Core.RustInterop.emitRustExpr () v147 
    let v149 : string = "num_complex::Complex::new($0, $1)"
    let v150 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v146, v148) v149 
    let v153 : num_complex_Complex<float> =
        match v132 with
        | US0_1 -> (* None *)
            v150
        | US0_0(v151) -> (* Some *)
            v151
    let v154 : string = "$0.re"
    let v155 : float = Fable.Core.RustInterop.emitRustExpr v153 v154 
    let v156 : bool = v155 < infinity
    let v158 : bool =
        if v156 then
            true
        else
            method18(v156)
    let v163 : string =
        if v156 then
            let v159 : float = infinity
            method19(v159)
        else
            let v161 : float = infinity
            method26(v155, v161)
    let v170 : string = "__assert_lt"
    let v171 : string = " "
    let v172 : string = v170 + v171 
    let v188 : string =
        if v156 then
            let v184 : float = infinity
            method19(v184)
        else
            let v186 : float = infinity
            method26(v155, v186)
    let v191 : string = v172 + v188 
    let v233 : unit = ()
    let v234 : (unit -> unit) = closure2(v191)
    let v235 : unit = (fun () -> v234 (); v233) ()
    let v247 : bool = v158 = false
    if v247 then
        failwith<unit> v191
    let v248 : string = "$0.im"
    let v249 : float = Fable.Core.RustInterop.emitRustExpr v153 v248 
    let v250 : bool = v249 < infinity
    let v252 : bool =
        if v250 then
            true
        else
            method18(v250)
    let v257 : string =
        if v250 then
            let v253 : float = infinity
            method19(v253)
        else
            let v255 : float = infinity
            method26(v249, v255)
    let v260 : string = v170 + v171 
    let v276 : string =
        if v250 then
            let v272 : float = infinity
            method19(v272)
        else
            let v274 : float = infinity
            method26(v249, v274)
    let v279 : string = v260 + v276 
    let v321 : unit = ()
    let v322 : (unit -> unit) = closure2(v279)
    let v323 : unit = (fun () -> v322 (); v321) ()
    let v335 : bool = v252 = false
    if v335 then
        failwith<unit> v279
and method44 () : unit =
    let v0 : string = "pyo3::Python::initialize()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::attach(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method45(v3)
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v21 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v21 
        #endif
#else
        let v22 : num_complex_Complex<float> option = match v8 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v12 = v22 
        #endif
        let v23 : num_complex_Complex<float> option = _run_target_args'_v12 
        let v49 : (num_complex_Complex<float> -> US0) = method17()
        let v50 : US0 option = v23 |> Option.map v49 
        let v134 : US0 = US0_1
        let v135 : US0 = v50 |> Option.defaultValue v134 
        let v148 : string = "f64::NAN"
        let v149 : float = Fable.Core.RustInterop.emitRustExpr () v148 
        let v150 : string = "f64::NAN"
        let v151 : float = Fable.Core.RustInterop.emitRustExpr () v150 
        let v152 : string = "num_complex::Complex::new($0, $1)"
        let v153 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v149, v151) v152 
        let v156 : num_complex_Complex<float> =
            match v135 with
            | US0_1 -> (* None *)
                v153
            | US0_0(v154) -> (* Some *)
                v154
        let v157 : string = "$0.re"
        let v158 : float = Fable.Core.RustInterop.emitRustExpr v156 v157 
        let v167 : bool = v158 <> 0.0 
        let v180 : bool =
            if v167 then
                true
            else
                method18(v167)
        let v185 : string =
            if v167 then
                let v181 : float = 0.0
                method19(v181)
            else
                let v183 : float = 0.0
                method26(v158, v183)
        let v192 : string = "__assert_ne"
        let v193 : string = " "
        let v194 : string = v192 + v193 
        let v210 : string =
            if v167 then
                let v206 : float = 0.0
                method19(v206)
            else
                let v208 : float = 0.0
                method26(v158, v208)
        let v213 : string = v194 + v210 
        let v255 : unit = ()
        let v256 : (unit -> unit) = closure2(v213)
        let v257 : unit = (fun () -> v256 (); v255) ()
        let v269 : bool = v180 = false
        if v269 then
            failwith<unit> v213
        let v270 : string = "$0.im"
        let v271 : float = Fable.Core.RustInterop.emitRustExpr v156 v270 
        let v280 : bool = v271 <> 0.0 
        let v293 : bool =
            if v280 then
                true
            else
                method18(v280)
        let v298 : string =
            if v280 then
                let v294 : float = 0.0
                method19(v294)
            else
                let v296 : float = 0.0
                method26(v271, v296)
        let v301 : string = v192 + v193 
        let v317 : string =
            if v280 then
                let v313 : float = 0.0
                method19(v313)
            else
                let v315 : float = 0.0
                method26(v271, v315)
        let v320 : string = v301 + v317 
        let v362 : unit = ()
        let v363 : (unit -> unit) = closure2(v320)
        let v364 : unit = (fun () -> v363 (); v362) ()
        let v376 : bool = v293 = false
        if v376 then
            failwith<unit> v320
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v19 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v19 
        #endif
#else
        let v20 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v20 
        #endif
        let v21 : num_complex_Complex<float> option = _run_target_args'_v10 
        let v47 : (num_complex_Complex<float> -> US0) = method17()
        let v48 : US0 option = v21 |> Option.map v47 
        let v132 : US0 = US0_1
        let v133 : US0 = v48 |> Option.defaultValue v132 
        let v146 : string = "f64::NAN"
        let v147 : float = Fable.Core.RustInterop.emitRustExpr () v146 
        let v148 : string = "f64::NAN"
        let v149 : float = Fable.Core.RustInterop.emitRustExpr () v148 
        let v150 : string = "num_complex::Complex::new($0, $1)"
        let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v147, v149) v150 
        let v154 : num_complex_Complex<float> =
            match v133 with
            | US0_1 -> (* None *)
                v151
            | US0_0(v152) -> (* Some *)
                v152
        let v155 : string = "$0.re"
        let v156 : float = Fable.Core.RustInterop.emitRustExpr v154 v155 
        let v165 : bool = v156 <> 0.0 
        let v178 : bool =
            if v165 then
                true
            else
                method18(v165)
        let v183 : string =
            if v165 then
                let v179 : float = 0.0
                method19(v179)
            else
                let v181 : float = 0.0
                method26(v156, v181)
        let v190 : string = "__assert_ne"
        let v191 : string = " "
        let v192 : string = v190 + v191 
        let v208 : string =
            if v165 then
                let v204 : float = 0.0
                method19(v204)
            else
                let v206 : float = 0.0
                method26(v156, v206)
        let v211 : string = v192 + v208 
        let v253 : unit = ()
        let v254 : (unit -> unit) = closure2(v211)
        let v255 : unit = (fun () -> v254 (); v253) ()
        let v267 : bool = v178 = false
        if v267 then
            failwith<unit> v211
        let v268 : string = "$0.im"
        let v269 : float = Fable.Core.RustInterop.emitRustExpr v154 v268 
        let v278 : bool = v269 <> 0.0 
        let v291 : bool =
            if v278 then
                true
            else
                method18(v278)
        let v296 : string =
            if v278 then
                let v292 : float = 0.0
                method19(v292)
            else
                let v294 : float = 0.0
                method26(v269, v294)
        let v299 : string = v190 + v191 
        let v315 : string =
            if v278 then
                let v311 : float = 0.0
                method19(v311)
            else
                let v313 : float = 0.0
                method26(v269, v313)
        let v318 : string = v299 + v315 
        let v360 : unit = ()
        let v361 : (unit -> unit) = closure2(v318)
        let v362 : unit = (fun () -> v361 (); v360) ()
        let v374 : bool = v291 = false
        if v374 then
            failwith<unit> v318
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v19 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v19 
        #endif
#else
        let v20 : num_complex_Complex<float> option = match v6 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v10 = v20 
        #endif
        let v21 : num_complex_Complex<float> option = _run_target_args'_v10 
        let v47 : (num_complex_Complex<float> -> US0) = method17()
        let v48 : US0 option = v21 |> Option.map v47 
        let v132 : US0 = US0_1
        let v133 : US0 = v48 |> Option.defaultValue v132 
        let v146 : string = "f64::NAN"
        let v147 : float = Fable.Core.RustInterop.emitRustExpr () v146 
        let v148 : string = "f64::NAN"
        let v149 : float = Fable.Core.RustInterop.emitRustExpr () v148 
        let v150 : string = "num_complex::Complex::new($0, $1)"
        let v151 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v147, v149) v150 
        let v154 : num_complex_Complex<float> =
            match v133 with
            | US0_1 -> (* None *)
                v151
            | US0_0(v152) -> (* Some *)
                v152
        let v155 : string = "num_complex::Complex::new($0, $1)"
        let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v155 
        let v157 : string = "num_complex::Complex::powc($0, $1)"
        let v158 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v156, v2) v157 
        let v159 : string = "num_complex::Complex::new($0, $1)"
        let v160 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v159 
        let v161 : string = "num_complex::Complex::new($0, $1)"
        let v162 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v161 
        let v163 : string = "$0 - $1"
        let v164 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v162) v163 
        let v165 : string = "num_complex::Complex::powc($0, $1)"
        let v166 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v160, v164) v165 
        let v167 : string = "$0 * $1"
        let v168 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v158, v166) v167 
        let v169 : string = "num_complex::Complex::new($0, $1)"
        let v170 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v169 
        let v171 : string = "$0 * $1"
        let v172 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v170, v2) v171 
        let v173 : string = "num_complex::Complex::new($0, $1)"
        let v174 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v173 
        let v175 : string = "$0 / $1"
        let v176 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v172, v174) v175 
        let v177 : string = "$0.sin()"
        let v178 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v176 v177 
        let v179 : string = "$0 * $1"
        let v180 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v168, v178) v179 
        let v181 : string = "num_complex::Complex::new($0, $1)"
        let v182 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v181 
        let v183 : string = "$0 - $1"
        let v184 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v182, v2) v183 
        let v185 : string = $"        s = mpmath.gamma(s)"
        let v186 : num_complex_Complex<float> = method3(v184)
        let v187 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v185, v186)
        (* run_target_args'
        let v190 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v191 : string = "$0.ok()"
        let v192 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v187 v191 
        let _run_target_args'_v190 = v192 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v193 : string = "$0.ok()"
        let v194 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v187 v193 
        let _run_target_args'_v190 = v194 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v195 : string = "$0.ok()"
        let v196 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v187 v195 
        let _run_target_args'_v190 = v196 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v197 : num_complex_Complex<float> option = match v187 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v190 = v197 
        #endif
#if FABLE_COMPILER_PYTHON
        let v198 : num_complex_Complex<float> option = match v187 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v190 = v198 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v199 : num_complex_Complex<float> option = match v187 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v190 = v199 
        #endif
#else
        let v200 : num_complex_Complex<float> option = match v187 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v190 = v200 
        #endif
        let v201 : num_complex_Complex<float> option = _run_target_args'_v190 
        let v227 : (num_complex_Complex<float> -> US0) = method17()
        let v228 : US0 option = v201 |> Option.map v227 
        let v312 : US0 = US0_1
        let v313 : US0 = v228 |> Option.defaultValue v312 
        let v326 : string = "f64::NAN"
        let v327 : float = Fable.Core.RustInterop.emitRustExpr () v326 
        let v328 : string = "f64::NAN"
        let v329 : float = Fable.Core.RustInterop.emitRustExpr () v328 
        let v330 : string = "num_complex::Complex::new($0, $1)"
        let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v327, v329) v330 
        let v334 : num_complex_Complex<float> =
            match v313 with
            | US0_1 -> (* None *)
                v331
            | US0_0(v332) -> (* Some *)
                v332
        let v335 : string = "$0 * $1"
        let v336 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v180, v334) v335 
        let v337 : string = "$0.re"
        let v338 : float = Fable.Core.RustInterop.emitRustExpr v2 v337 
        let v339 : float = 1.0 - v338
        let v340 : string = "$0.im"
        let v341 : float = Fable.Core.RustInterop.emitRustExpr v2 v340 
        let v342 : float =  -v341
        let v343 : string = "num_complex::Complex::new($0, $1)"
        let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v339, v342) v343 
        let v345 : string = $"        s = mpmath.zeta(s)"
        let v346 : num_complex_Complex<float> = method3(v344)
        let v347 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v345, v346)
        let v348 : num_complex_Complex<float> = method13(v0, v344)
        (* run_target_args'
        let v351 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v352 : string = "$0.ok()"
        let v353 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v347 v352 
        let _run_target_args'_v351 = v353 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v354 : string = "$0.ok()"
        let v355 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v347 v354 
        let _run_target_args'_v351 = v355 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v356 : string = "$0.ok()"
        let v357 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v347 v356 
        let _run_target_args'_v351 = v357 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v358 : num_complex_Complex<float> option = match v347 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v351 = v358 
        #endif
#if FABLE_COMPILER_PYTHON
        let v359 : num_complex_Complex<float> option = match v347 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v351 = v359 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v360 : num_complex_Complex<float> option = match v347 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v351 = v360 
        #endif
#else
        let v361 : num_complex_Complex<float> option = match v347 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v351 = v361 
        #endif
        let v362 : num_complex_Complex<float> option = _run_target_args'_v351 
        let v388 : (num_complex_Complex<float> -> US0) = method17()
        let v389 : US0 option = v362 |> Option.map v388 
        let v473 : US0 = US0_1
        let v474 : US0 = v389 |> Option.defaultValue v473 
        let v487 : string = "f64::NAN"
        let v488 : float = Fable.Core.RustInterop.emitRustExpr () v487 
        let v489 : string = "f64::NAN"
        let v490 : float = Fable.Core.RustInterop.emitRustExpr () v489 
        let v491 : string = "num_complex::Complex::new($0, $1)"
        let v492 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v488, v490) v491 
        let v495 : num_complex_Complex<float> =
            match v474 with
            | US0_1 -> (* None *)
                v492
            | US0_0(v493) -> (* Some *)
                v493
        let v496 : string = "$0 * $1"
        let v497 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v336, v495) v496 
        let v498 : string = "$0.re"
        let v499 : float = Fable.Core.RustInterop.emitRustExpr v154 v498 
        let v500 : string = "$0.re"
        let v501 : float = Fable.Core.RustInterop.emitRustExpr v497 v500 
        let v502 : float = v499 - v501
        let v503 : float =  -v502
        let v504 : bool = v502 >= v503
        let v505 : float =
            if v504 then
                v502
            else
                v503
        let v506 : bool = v505 < 0.0001
        let v508 : bool =
            if v506 then
                true
            else
                method18(v506)
        let v513 : string =
            if v506 then
                let v509 : float = 0.0001
                method19(v509)
            else
                let v511 : float = 0.0001
                method26(v505, v511)
        let v520 : string = "__assert_lt"
        let v521 : string = " "
        let v522 : string = v520 + v521 
        let v538 : string =
            if v506 then
                let v534 : float = 0.0001
                method19(v534)
            else
                let v536 : float = 0.0001
                method26(v505, v536)
        let v541 : string = v522 + v538 
        let v583 : unit = ()
        let v584 : (unit -> unit) = closure2(v541)
        let v585 : unit = (fun () -> v584 (); v583) ()
        let v597 : bool = v508 = false
        if v597 then
            failwith<unit> v541
        let v598 : string = "$0.im"
        let v599 : float = Fable.Core.RustInterop.emitRustExpr v154 v598 
        let v600 : string = "$0.im"
        let v601 : float = Fable.Core.RustInterop.emitRustExpr v497 v600 
        let v602 : float = v599 - v601
        let v603 : float =  -v602
        let v604 : bool = v602 >= v603
        let v605 : float =
            if v604 then
                v602
            else
                v603
        let v606 : bool = v605 < 0.0001
        let v608 : bool =
            if v606 then
                true
            else
                method18(v606)
        let v613 : string =
            if v606 then
                let v609 : float = 0.0001
                method19(v609)
            else
                let v611 : float = 0.0001
                method26(v605, v611)
        let v616 : string = v520 + v521 
        let v632 : string =
            if v606 then
                let v628 : float = 0.0001
                method19(v628)
            else
                let v630 : float = 0.0001
                method26(v605, v630)
        let v635 : string = v616 + v632 
        let v677 : unit = ()
        let v678 : (unit -> unit) = closure2(v635)
        let v679 : unit = (fun () -> v678 (); v677) ()
        let v691 : bool = v608 = false
        if v691 then
            failwith<unit> v635
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v24 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v24 
        #endif
#else
        let v25 : num_complex_Complex<float> option = match v11 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v15 = v25 
        #endif
        let v26 : num_complex_Complex<float> option = _run_target_args'_v15 
        let v52 : (num_complex_Complex<float> -> US0) = method17()
        let v53 : US0 option = v26 |> Option.map v52 
        let v137 : US0 = US0_1
        let v138 : US0 = v53 |> Option.defaultValue v137 
        let v151 : string = "f64::NAN"
        let v152 : float = Fable.Core.RustInterop.emitRustExpr () v151 
        let v153 : string = "f64::NAN"
        let v154 : float = Fable.Core.RustInterop.emitRustExpr () v153 
        let v155 : string = "num_complex::Complex::new($0, $1)"
        let v156 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v152, v154) v155 
        let v159 : num_complex_Complex<float> =
            match v138 with
            | US0_1 -> (* None *)
                v156
            | US0_0(v157) -> (* Some *)
                v157
        let v160 : string = "$0.re"
        let v161 : float = Fable.Core.RustInterop.emitRustExpr v159 v160 
        let v162 : float = v161 - v8
        let v163 : float =  -v162
        let v164 : bool = v162 >= v163
        let v165 : float =
            if v164 then
                v162
            else
                v163
        let v166 : bool = v165 < 0.01
        let v168 : bool =
            if v166 then
                true
            else
                method18(v166)
        let v173 : string =
            if v166 then
                let v169 : float = 0.01
                method19(v169)
            else
                let v171 : float = 0.01
                method26(v165, v171)
        let v180 : string = "__assert_lt"
        let v181 : string = " "
        let v182 : string = v180 + v181 
        let v198 : string =
            if v166 then
                let v194 : float = 0.01
                method19(v194)
            else
                let v196 : float = 0.01
                method26(v165, v196)
        let v201 : string = v182 + v198 
        let v243 : unit = ()
        let v244 : (unit -> unit) = closure2(v201)
        let v245 : unit = (fun () -> v244 (); v243) ()
        let v257 : bool = v168 = false
        if v257 then
            failwith<unit> v201
        let v258 : string = "$0.im"
        let v259 : float = Fable.Core.RustInterop.emitRustExpr v159 v258 
        let v260 : bool = v259 < 0.01
        let v262 : bool =
            if v260 then
                true
            else
                method18(v260)
        let v267 : string =
            if v260 then
                let v263 : float = 0.01
                method19(v263)
            else
                let v265 : float = 0.01
                method26(v259, v265)
        let v270 : string = v180 + v181 
        let v286 : string =
            if v260 then
                let v282 : float = 0.01
                method19(v282)
            else
                let v284 : float = 0.01
                method26(v259, v284)
        let v289 : string = v270 + v286 
        let v331 : unit = ()
        let v332 : (unit -> unit) = closure2(v289)
        let v333 : unit = (fun () -> v332 (); v331) ()
        let v345 : bool = v262 = false
        if v345 then
            failwith<unit> v289
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
    let v12 : Result<unit, pyo3_PyErr> = Ok () 
    let v24 : Result<unit, pyo3_PyErr> = method29(v12)
    let v25 : string = ""
    let v26 : string = "}"
    let v27 : string = v25 + v26 
    let v28 : string = v27 + v26 
    let v29 : string = "{"
    let v30 : string = v25 + v29 
    let x = v24 //
    let v31 : _ = x
    let v32 : unit = ()
    (* run_target_args'
    let v33 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v34 : string = $"true; let _fix_closure_v32 = $0"
    let v35 : bool = Fable.Core.RustInterop.emitRustExpr v31 v34 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v36 : string = $"true; let _fix_closure_v32 = $0"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr v31 v36 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v38 : string = $"true; let _fix_closure_v32 = $0"
    let v39 : bool = Fable.Core.RustInterop.emitRustExpr v31 v38 
    let _run_target_args'_v33 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v33 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v33 = false 
    #endif
#else
    let _run_target_args'_v33 = false 
    #endif
    let v40 : bool = _run_target_args'_v33 
    let v41 : string = $"true; _fix_closure_v32 " + v28 + "); " + v30 + " // rust.fix_closure'"
    let v42 : bool = Fable.Core.RustInterop.emitRustExpr () v41 
    let v43 : string = "__run_test"
    let v44 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v43 
    (* run_target_args'
    let v45 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v46 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v46 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v47 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v47 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v48 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v44 v48 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v44 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    let v32 : unit = ()
    let v33 : (unit -> unit) = closure2(v1)
    let v34 : unit = (fun () -> v33 (); v32) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure3()
let main args = v1 args
()
