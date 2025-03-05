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
Fable.Core.RustInterop.emitRustExpr () ");
use pyo3::prelude::PyAnyMethods;
//"
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
        let v12 : string = v11 + v10 + v9 + ""
        let v13 : int32 = v5 + 1
        let v14 : string = "\n"
        v3.l0 <- v13
        v3.l1 <- v12
        v3.l2 <- v14
        ()
    let struct (v15 : string, v16 : string) = v3.l1, v3.l2
    v15
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
    let v46 : (bool * (float * float)) = false, v42 
    let v49 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    (* run_target_args'
    let v87 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : string = "String::from($0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v88 
    let _run_target_args'_v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : string = "String::from($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v90 
    let _run_target_args'_v87 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = "String::from($0)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v92 
    let _run_target_args'_v87 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v99 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v103 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v103 
    #endif
#else
    let v107 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v107 
    #endif
    let v110 : std_string_String = _run_target_args'_v87 
    let v116 : string = "std::ffi::CString::new($0).unwrap()"
    let v117 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v110 v116 
    let v118 : string = ""
    (* run_target_args'
    let v123 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v124 : string = "&*$0"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v124 
    let _run_target_args'_v123 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v126 : string = "&*$0"
    let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v126 
    let _run_target_args'_v123 = v127 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v128 : string = "&*$0"
    let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v128 
    let _run_target_args'_v123 = v129 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v135 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v139 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v139 
    #endif
#else
    let v143 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v143 
    #endif
    let v146 : Ref<Str> = _run_target_args'_v123 
    (* run_target_args'
    let v156 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v157 : string = "String::from($0)"
    let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v157 
    let _run_target_args'_v156 = v158 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v159 : string = "String::from($0)"
    let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v159 
    let _run_target_args'_v156 = v160 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v161 : string = "String::from($0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v161 
    let _run_target_args'_v156 = v162 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v168 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v168 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v172 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v172 
    #endif
#else
    let v176 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v176 
    #endif
    let v179 : std_string_String = _run_target_args'_v156 
    let v185 : string = "std::ffi::CString::new($0).unwrap()"
    let v186 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v179 v185 
    let v187 : string = "pyo3::types::PyModule::from_code(v49, &$0, &v186, &v186)"
    let v188 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v117 v187 
    let v189 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v190 : bool = Fable.Core.RustInterop.emitRustExpr v188 v189 
    let v191 : string = "x"
    let v192 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v191 
    (* run_target_args'
    let v197 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : string = "format!(\"{}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v198 
    let _run_target_args'_v197 = v199 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : string = "format!(\"{}\", $0)"
    let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v200 
    let _run_target_args'_v197 = v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = "format!(\"{}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v202 
    let _run_target_args'_v197 = v203 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v205 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v209 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v213 
    #endif
#else
    let v217 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v217 
    #endif
    let v220 : std_string_String = _run_target_args'_v197 
    let v226 : string = "true; $0 })"
    let v227 : bool = Fable.Core.RustInterop.emitRustExpr v220 v226 
    let v228 : string = "_result_map_error__"
    let v229 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v228 
    (* run_target_args'
    let v231 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v232 : string = "$0.unwrap()"
    let v233 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v229 v232 
    let _run_target_args'_v231 = v233 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v234 : string = "$0.unwrap()"
    let v235 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v229 v234 
    let _run_target_args'_v231 = v235 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v236 : string = "$0.unwrap()"
    let v237 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v229 v236 
    let _run_target_args'_v231 = v237 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v238 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v238 
    #endif
#if FABLE_COMPILER_PYTHON
    let v239 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v239 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v240 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v240 
    #endif
#else
    let v241 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v241 
    #endif
    let v242 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v231 
    let v245 : string = method8()
    (* run_target_args'
    let v250 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v251 : string = "&*$0"
    let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v251 
    let _run_target_args'_v250 = v252 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : string = "&*$0"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v253 
    let _run_target_args'_v250 = v254 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v255 : string = "&*$0"
    let v256 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v255 
    let _run_target_args'_v250 = v256 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v258 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v258 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v262 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v266 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v266 
    #endif
#else
    let v270 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v270 
    #endif
    let v273 : Ref<Str> = _run_target_args'_v250 
    let v279 : pyo3_Bound<pyo3_types_PyModule> = method9(v242)
    let v280 : string = "v279.getattr($0)"
    let v281 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v273 v280 
    let v282 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v283 : bool = Fable.Core.RustInterop.emitRustExpr v281 v282 
    let v284 : string = "x"
    let v285 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v284 
    (* run_target_args'
    let v290 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v291 : string = "format!(\"{}\", $0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v285 v291 
    let _run_target_args'_v290 = v292 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v293 : string = "format!(\"{}\", $0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v285 v293 
    let _run_target_args'_v290 = v294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = "format!(\"{}\", $0)"
    let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v285 v295 
    let _run_target_args'_v290 = v296 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v298 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v298 
    #endif
#if FABLE_COMPILER_PYTHON
    let v302 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v302 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v306 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v306 
    #endif
#else
    let v310 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v310 
    #endif
    let v313 : std_string_String = _run_target_args'_v290 
    let v319 : string = "true; $0 })"
    let v320 : bool = Fable.Core.RustInterop.emitRustExpr v313 v319 
    let v321 : string = "_result_map_error__"
    let v322 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v321 
    (* run_target_args'
    let v324 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v325 : string = "$0.unwrap()"
    let v326 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v322 v325 
    let _run_target_args'_v324 = v326 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v327 : string = "$0.unwrap()"
    let v328 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v322 v327 
    let _run_target_args'_v324 = v328 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v329 : string = "$0.unwrap()"
    let v330 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v322 v329 
    let _run_target_args'_v324 = v330 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v331 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v331 
    #endif
#if FABLE_COMPILER_PYTHON
    let v332 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v332 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v333 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v333 
    #endif
#else
    let v334 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v334 
    #endif
    let v335 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v324 
    let v338 : (bool * (float * float)) = method10(v46)
    let v339 : pyo3_Bound<pyo3_PyAny> = method11(v335)
    let v340 : string = "pyo3::prelude::PyAnyMethods::call(&v339, ((*v338).0, *(*v338).1), None)"
    let v341 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v340 
    let v342 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v343 : bool = Fable.Core.RustInterop.emitRustExpr v341 v342 
    let v344 : string = "x"
    let v345 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v344 
    (* run_target_args'
    let v350 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v351 : string = "format!(\"{}\", $0)"
    let v352 : std_string_String = Fable.Core.RustInterop.emitRustExpr v345 v351 
    let _run_target_args'_v350 = v352 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v353 : string = "format!(\"{}\", $0)"
    let v354 : std_string_String = Fable.Core.RustInterop.emitRustExpr v345 v353 
    let _run_target_args'_v350 = v354 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v355 : string = "format!(\"{}\", $0)"
    let v356 : std_string_String = Fable.Core.RustInterop.emitRustExpr v345 v355 
    let _run_target_args'_v350 = v356 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v358 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v358 
    #endif
#if FABLE_COMPILER_PYTHON
    let v362 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v362 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v366 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v366 
    #endif
#else
    let v370 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v370 
    #endif
    let v373 : std_string_String = _run_target_args'_v350 
    let v379 : string = "true; $0 })"
    let v380 : bool = Fable.Core.RustInterop.emitRustExpr v373 v379 
    let v381 : string = "_result_map_error__"
    let v382 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v381 
    let v383 : string = "$0?"
    let v384 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v382 v383 
    let v385 : pyo3_Bound<pyo3_PyAny> = method12(v384)
    let v386 : string = "v385.extract()"
    let v387 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v386 
    let v388 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v389 : bool = Fable.Core.RustInterop.emitRustExpr v387 v388 
    let v390 : string = "x"
    let v391 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v390 
    (* run_target_args'
    let v396 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v397 : string = "format!(\"{}\", $0)"
    let v398 : std_string_String = Fable.Core.RustInterop.emitRustExpr v391 v397 
    let _run_target_args'_v396 = v398 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v399 : string = "format!(\"{}\", $0)"
    let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v391 v399 
    let _run_target_args'_v396 = v400 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v401 : string = "format!(\"{}\", $0)"
    let v402 : std_string_String = Fable.Core.RustInterop.emitRustExpr v391 v401 
    let _run_target_args'_v396 = v402 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v404 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v404 
    #endif
#if FABLE_COMPILER_PYTHON
    let v408 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v408 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v412 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v412 
    #endif
#else
    let v416 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v416 
    #endif
    let v419 : std_string_String = _run_target_args'_v396 
    let v425 : string = "true; $0 })"
    let v426 : bool = Fable.Core.RustInterop.emitRustExpr v419 v425 
    let v427 : string = "_result_map_error__"
    let v428 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v427 
    let v429 : string = "$0?"
    let struct (v430 : float, v431 : float) = Fable.Core.RustInterop.emitRustExpr v428 v429 
    let v432 : string = "num_complex::Complex::new($0, $1)"
    let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v430, v431) v432 
    let v435 : Result<num_complex_Complex<float>, std_string_String> = Ok v433 
    v435
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
    let v46 : (bool * (float * float)) = false, v42 
    let v49 : pyo3_Python = method7(v0)
    (* run_target_args'
    let v54 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v55 : string = "&*$0"
    let v56 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v55 
    let _run_target_args'_v54 = v56 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v57 : string = "&*$0"
    let v58 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v57 
    let _run_target_args'_v54 = v58 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v59 : string = "&*$0"
    let v60 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v36 v59 
    let _run_target_args'_v54 = v60 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v62 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v62 
    #endif
#if FABLE_COMPILER_PYTHON
    let v66 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v66 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v70 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v70 
    #endif
#else
    let v74 : Ref<Str> = v36 |> unbox<Ref<Str>>
    let _run_target_args'_v54 = v74 
    #endif
    let v77 : Ref<Str> = _run_target_args'_v54 
    (* run_target_args'
    let v87 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v88 : string = "String::from($0)"
    let v89 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v88 
    let _run_target_args'_v87 = v89 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v90 : string = "String::from($0)"
    let v91 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v90 
    let _run_target_args'_v87 = v91 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v92 : string = "String::from($0)"
    let v93 : std_string_String = Fable.Core.RustInterop.emitRustExpr v77 v92 
    let _run_target_args'_v87 = v93 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v95 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v95 
    #endif
#if FABLE_COMPILER_PYTHON
    let v99 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v99 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v103 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v103 
    #endif
#else
    let v107 : std_string_String = v77 |> unbox<std_string_String>
    let _run_target_args'_v87 = v107 
    #endif
    let v110 : std_string_String = _run_target_args'_v87 
    let v116 : string = "std::ffi::CString::new($0).unwrap()"
    let v117 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v110 v116 
    let v118 : string = ""
    (* run_target_args'
    let v123 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v124 : string = "&*$0"
    let v125 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v124 
    let _run_target_args'_v123 = v125 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v126 : string = "&*$0"
    let v127 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v126 
    let _run_target_args'_v123 = v127 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v128 : string = "&*$0"
    let v129 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v118 v128 
    let _run_target_args'_v123 = v129 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v131 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v131 
    #endif
#if FABLE_COMPILER_PYTHON
    let v135 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v135 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v139 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v139 
    #endif
#else
    let v143 : Ref<Str> = v118 |> unbox<Ref<Str>>
    let _run_target_args'_v123 = v143 
    #endif
    let v146 : Ref<Str> = _run_target_args'_v123 
    (* run_target_args'
    let v156 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v157 : string = "String::from($0)"
    let v158 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v157 
    let _run_target_args'_v156 = v158 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v159 : string = "String::from($0)"
    let v160 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v159 
    let _run_target_args'_v156 = v160 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v161 : string = "String::from($0)"
    let v162 : std_string_String = Fable.Core.RustInterop.emitRustExpr v146 v161 
    let _run_target_args'_v156 = v162 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v164 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v164 
    #endif
#if FABLE_COMPILER_PYTHON
    let v168 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v168 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v172 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v172 
    #endif
#else
    let v176 : std_string_String = v146 |> unbox<std_string_String>
    let _run_target_args'_v156 = v176 
    #endif
    let v179 : std_string_String = _run_target_args'_v156 
    let v185 : string = "std::ffi::CString::new($0).unwrap()"
    let v186 : std_ffi_CString = Fable.Core.RustInterop.emitRustExpr v179 v185 
    let v187 : string = "pyo3::types::PyModule::from_code(v49, &$0, &v186, &v186)"
    let v188 : Result<pyo3_Bound<pyo3_types_PyModule>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v117 v187 
    let v189 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v190 : bool = Fable.Core.RustInterop.emitRustExpr v188 v189 
    let v191 : string = "x"
    let v192 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v191 
    (* run_target_args'
    let v197 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v198 : string = "format!(\"{}\", $0)"
    let v199 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v198 
    let _run_target_args'_v197 = v199 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v200 : string = "format!(\"{}\", $0)"
    let v201 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v200 
    let _run_target_args'_v197 = v201 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v202 : string = "format!(\"{}\", $0)"
    let v203 : std_string_String = Fable.Core.RustInterop.emitRustExpr v192 v202 
    let _run_target_args'_v197 = v203 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v205 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v205 
    #endif
#if FABLE_COMPILER_PYTHON
    let v209 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v209 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v213 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v213 
    #endif
#else
    let v217 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v197 = v217 
    #endif
    let v220 : std_string_String = _run_target_args'_v197 
    let v226 : string = "true; $0 })"
    let v227 : bool = Fable.Core.RustInterop.emitRustExpr v220 v226 
    let v228 : string = "_result_map_error__"
    let v229 : Result<pyo3_Bound<pyo3_types_PyModule>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v228 
    (* run_target_args'
    let v231 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v232 : string = "$0.unwrap()"
    let v233 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v229 v232 
    let _run_target_args'_v231 = v233 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v234 : string = "$0.unwrap()"
    let v235 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v229 v234 
    let _run_target_args'_v231 = v235 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v236 : string = "$0.unwrap()"
    let v237 : pyo3_Bound<pyo3_types_PyModule> = Fable.Core.RustInterop.emitRustExpr v229 v236 
    let _run_target_args'_v231 = v237 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v238 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v238 
    #endif
#if FABLE_COMPILER_PYTHON
    let v239 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v239 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v240 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v240 
    #endif
#else
    let v241 : pyo3_Bound<pyo3_types_PyModule> = match v229 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v231 = v241 
    #endif
    let v242 : pyo3_Bound<pyo3_types_PyModule> = _run_target_args'_v231 
    let v245 : string = method8()
    (* run_target_args'
    let v250 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v251 : string = "&*$0"
    let v252 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v251 
    let _run_target_args'_v250 = v252 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v253 : string = "&*$0"
    let v254 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v253 
    let _run_target_args'_v250 = v254 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v255 : string = "&*$0"
    let v256 : Ref<Str> = Fable.Core.RustInterop.emitRustExpr v245 v255 
    let _run_target_args'_v250 = v256 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v258 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v258 
    #endif
#if FABLE_COMPILER_PYTHON
    let v262 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v262 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v266 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v266 
    #endif
#else
    let v270 : Ref<Str> = v245 |> unbox<Ref<Str>>
    let _run_target_args'_v250 = v270 
    #endif
    let v273 : Ref<Str> = _run_target_args'_v250 
    let v279 : pyo3_Bound<pyo3_types_PyModule> = method9(v242)
    let v280 : string = "v279.getattr($0)"
    let v281 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr v273 v280 
    let v282 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v283 : bool = Fable.Core.RustInterop.emitRustExpr v281 v282 
    let v284 : string = "x"
    let v285 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v284 
    (* run_target_args'
    let v290 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v291 : string = "format!(\"{}\", $0)"
    let v292 : std_string_String = Fable.Core.RustInterop.emitRustExpr v285 v291 
    let _run_target_args'_v290 = v292 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v293 : string = "format!(\"{}\", $0)"
    let v294 : std_string_String = Fable.Core.RustInterop.emitRustExpr v285 v293 
    let _run_target_args'_v290 = v294 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v295 : string = "format!(\"{}\", $0)"
    let v296 : std_string_String = Fable.Core.RustInterop.emitRustExpr v285 v295 
    let _run_target_args'_v290 = v296 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v298 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v298 
    #endif
#if FABLE_COMPILER_PYTHON
    let v302 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v302 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v306 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v306 
    #endif
#else
    let v310 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v290 = v310 
    #endif
    let v313 : std_string_String = _run_target_args'_v290 
    let v319 : string = "true; $0 })"
    let v320 : bool = Fable.Core.RustInterop.emitRustExpr v313 v319 
    let v321 : string = "_result_map_error__"
    let v322 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v321 
    (* run_target_args'
    let v324 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v325 : string = "$0.unwrap()"
    let v326 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v322 v325 
    let _run_target_args'_v324 = v326 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v327 : string = "$0.unwrap()"
    let v328 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v322 v327 
    let _run_target_args'_v324 = v328 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v329 : string = "$0.unwrap()"
    let v330 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v322 v329 
    let _run_target_args'_v324 = v330 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v331 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v331 
    #endif
#if FABLE_COMPILER_PYTHON
    let v332 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v332 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v333 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v333 
    #endif
#else
    let v334 : pyo3_Bound<pyo3_PyAny> = match v322 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    let _run_target_args'_v324 = v334 
    #endif
    let v335 : pyo3_Bound<pyo3_PyAny> = _run_target_args'_v324 
    let v338 : (bool * (float * float)) = method10(v46)
    let v339 : pyo3_Bound<pyo3_PyAny> = method11(v335)
    let v340 : string = "pyo3::prelude::PyAnyMethods::call(&v339, ((*v338).0, *(*v338).1), None)"
    let v341 : Result<pyo3_Bound<pyo3_PyAny>, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v340 
    let v342 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v343 : bool = Fable.Core.RustInterop.emitRustExpr v341 v342 
    let v344 : string = "x"
    let v345 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v344 
    (* run_target_args'
    let v350 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v351 : string = "format!(\"{}\", $0)"
    let v352 : std_string_String = Fable.Core.RustInterop.emitRustExpr v345 v351 
    let _run_target_args'_v350 = v352 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v353 : string = "format!(\"{}\", $0)"
    let v354 : std_string_String = Fable.Core.RustInterop.emitRustExpr v345 v353 
    let _run_target_args'_v350 = v354 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v355 : string = "format!(\"{}\", $0)"
    let v356 : std_string_String = Fable.Core.RustInterop.emitRustExpr v345 v355 
    let _run_target_args'_v350 = v356 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v358 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v358 
    #endif
#if FABLE_COMPILER_PYTHON
    let v362 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v362 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v366 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v366 
    #endif
#else
    let v370 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v350 = v370 
    #endif
    let v373 : std_string_String = _run_target_args'_v350 
    let v379 : string = "true; $0 })"
    let v380 : bool = Fable.Core.RustInterop.emitRustExpr v373 v379 
    let v381 : string = "_result_map_error__"
    let v382 : Result<pyo3_Bound<pyo3_PyAny>, std_string_String> = Fable.Core.RustInterop.emitRustExpr () v381 
    let v383 : string = "$0?"
    let v384 : pyo3_Bound<pyo3_PyAny> = Fable.Core.RustInterop.emitRustExpr v382 v383 
    let v385 : pyo3_Bound<pyo3_PyAny> = method12(v384)
    let v386 : string = "v385.extract()"
    let v387 : Result<struct (float * float), pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v386 
    let v388 : string = "true; let _result_map_error__ = $0.map_err(|x| { //"
    let v389 : bool = Fable.Core.RustInterop.emitRustExpr v387 v388 
    let v390 : string = "x"
    let v391 : pyo3_PyErr = Fable.Core.RustInterop.emitRustExpr () v390 
    (* run_target_args'
    let v396 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v397 : string = "format!(\"{}\", $0)"
    let v398 : std_string_String = Fable.Core.RustInterop.emitRustExpr v391 v397 
    let _run_target_args'_v396 = v398 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v399 : string = "format!(\"{}\", $0)"
    let v400 : std_string_String = Fable.Core.RustInterop.emitRustExpr v391 v399 
    let _run_target_args'_v396 = v400 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v401 : string = "format!(\"{}\", $0)"
    let v402 : std_string_String = Fable.Core.RustInterop.emitRustExpr v391 v401 
    let _run_target_args'_v396 = v402 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v404 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v404 
    #endif
#if FABLE_COMPILER_PYTHON
    let v408 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v408 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v412 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v412 
    #endif
#else
    let v416 : std_string_String = null |> unbox<std_string_String>
    let _run_target_args'_v396 = v416 
    #endif
    let v419 : std_string_String = _run_target_args'_v396 
    let v425 : string = "true; $0 })"
    let v426 : bool = Fable.Core.RustInterop.emitRustExpr v419 v425 
    let v427 : string = "_result_map_error__"
    let v428 : Result<struct (float * float), std_string_String> = Fable.Core.RustInterop.emitRustExpr () v427 
    let v429 : string = "$0?"
    let struct (v430 : float, v431 : float) = Fable.Core.RustInterop.emitRustExpr v428 v429 
    let v432 : string = "num_complex::Complex::new($0, $1)"
    let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v430, v431) v432 
    let v435 : Result<num_complex_Complex<float>, std_string_String> = Ok v433 
    v435
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
            let v26 : string = "num_complex::Complex::new($0, $1)"
            let v27 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v23, 0.0) v26 
            let v28 : string = "num_complex::Complex::powc($0, $1)"
            let v29 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v27, v1) v28 
            let v30 : string = "$0 / $1"
            let v31 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v20, v29) v30 
            let v32 : string = "$0 + $1"
            let v33 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v17, v31) v32 
            let v34 : int32 = v16 + 1
            v14.l0 <- v34
            v14.l1 <- v33
            ()
        let v35 : num_complex_Complex<float> = v14.l1
        v35
    else
        let v36 : string = "num_complex::Complex::new($0, $1)"
        let v37 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v36 
        let v38 : string = "$0 - $1"
        let v39 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v37, v1) v38 
        let v40 : string = $"        s = mpmath.gamma(s)"
        let v41 : num_complex_Complex<float> = method3(v39)
        let v42 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v40, v41)
        (* run_target_args'
        let v44 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v45 : string = "$0.ok()"
        let v46 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v42 v45 
        let _run_target_args'_v44 = v46 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v47 : string = "$0.ok()"
        let v48 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v42 v47 
        let _run_target_args'_v44 = v48 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v49 : string = "$0.ok()"
        let v50 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v42 v49 
        let _run_target_args'_v44 = v50 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v51 : num_complex_Complex<float> option = match v42 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v44 = v51 
        #endif
#if FABLE_COMPILER_PYTHON
        let v52 : num_complex_Complex<float> option = match v42 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v44 = v52 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v53 : num_complex_Complex<float> option = match v42 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v44 = v53 
        #endif
#else
        let v54 : num_complex_Complex<float> option = match v42 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v44 = v54 
        #endif
        let v55 : num_complex_Complex<float> option = _run_target_args'_v44 
        let v60 : (num_complex_Complex<float> -> US0) = method17()
        let v61 : US0 option = v55 |> Option.map v60 
        let v75 : US0 = US0_1
        let v76 : US0 = v61 |> Option.defaultValue v75 
        let v80 : string = "f64::NAN"
        let v81 : float = Fable.Core.RustInterop.emitRustExpr () v80 
        let v82 : string = "f64::NAN"
        let v83 : float = Fable.Core.RustInterop.emitRustExpr () v82 
        let v84 : string = "num_complex::Complex::new($0, $1)"
        let v85 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v81, v83) v84 
        let v88 : num_complex_Complex<float> =
            match v76 with
            | US0_1 -> (* None *)
                v85
            | US0_0(v86) -> (* Some *)
                v86
        let v89 : string = "num_complex::Complex::new($0, $1)"
        let v90 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v89 
        let v91 : string = "$0 * $1"
        let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v90, v1) v91 
        let v93 : string = "num_complex::Complex::new($0, $1)"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v93 
        let v95 : string = "$0 / $1"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v92, v94) v95 
        let v97 : string = "$0.sin()"
        let v98 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v96 v97 
        let v99 : string = "$0.re"
        let v100 : float = Fable.Core.RustInterop.emitRustExpr v1 v99 
        let v101 : float = 1.0 - v100
        let v102 : string = "$0.im"
        let v103 : float = Fable.Core.RustInterop.emitRustExpr v1 v102 
        let v104 : float =  -v103
        let v105 : string = "num_complex::Complex::new($0, $1)"
        let v106 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v101, v104) v105 
        let v107 : string = "$0.re"
        let v108 : float = Fable.Core.RustInterop.emitRustExpr v106 v107 
        let v109 : bool = v108 <= 1.0
        let v616 : num_complex_Complex<float> =
            if v109 then
                let v110 : string = "num_complex::Complex::new($0, $1)"
                let v111 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v110 
                v111
            else
                let v112 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v106) v112 
                let v113 : string = "$0.re"
                let v114 : float = Fable.Core.RustInterop.emitRustExpr v106 v113 
                let v115 : bool = v114 > 1.0
                if v115 then
                    let v116 : string = "num_complex::Complex::new($0, $1)"
                    let v117 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v116 
                    let v118 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v119 : Mut0 = {l0 = 0} : Mut0
                    while method14(v119) do
                        let v121 : int32 = v119.l0
                        v118.[int v121] <- v121
                        let v122 : int32 = v121 + 1
                        v119.l0 <- v122
                        ()
                    let v123 : int32 = v118.Length
                    let v124 : Mut2 = {l0 = 0; l1 = v117} : Mut2
                    while method15(v123, v124) do
                        let v126 : int32 = v124.l0
                        let v127 : num_complex_Complex<float> = v124.l1
                        let v128 : int32 = v118.[int v126]
                        let v129 : string = "num_complex::Complex::new($0, $1)"
                        let v130 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v129 
                        let v132 : (int32 -> float) = float
                        let v133 : float = v132 v128
                        let v136 : string = "num_complex::Complex::new($0, $1)"
                        let v137 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v133, 0.0) v136 
                        let v138 : string = "num_complex::Complex::powc($0, $1)"
                        let v139 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v137, v106) v138 
                        let v140 : string = "$0 / $1"
                        let v141 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v130, v139) v140 
                        let v142 : string = "$0 + $1"
                        let v143 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v127, v141) v142 
                        let v144 : int32 = v126 + 1
                        v124.l0 <- v144
                        v124.l1 <- v143
                        ()
                    let v145 : num_complex_Complex<float> = v124.l1
                    v145
                else
                    let v146 : string = "num_complex::Complex::new($0, $1)"
                    let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v146 
                    let v148 : string = "$0 - $1"
                    let v149 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v147, v106) v148 
                    let v150 : string = $"        s = mpmath.gamma(s)"
                    let v151 : num_complex_Complex<float> = method3(v149)
                    let v152 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v150, v151)
                    (* run_target_args'
                    let v154 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v155 : string = "$0.ok()"
                    let v156 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v152 v155 
                    let _run_target_args'_v154 = v156 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v157 : string = "$0.ok()"
                    let v158 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v152 v157 
                    let _run_target_args'_v154 = v158 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v159 : string = "$0.ok()"
                    let v160 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v152 v159 
                    let _run_target_args'_v154 = v160 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v161 : num_complex_Complex<float> option = match v152 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v154 = v161 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v162 : num_complex_Complex<float> option = match v152 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v154 = v162 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v163 : num_complex_Complex<float> option = match v152 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v154 = v163 
                    #endif
#else
                    let v164 : num_complex_Complex<float> option = match v152 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v154 = v164 
                    #endif
                    let v165 : num_complex_Complex<float> option = _run_target_args'_v154 
                    let v170 : (num_complex_Complex<float> -> US0) = method17()
                    let v171 : US0 option = v165 |> Option.map v170 
                    let v185 : US0 = US0_1
                    let v186 : US0 = v171 |> Option.defaultValue v185 
                    let v190 : string = "f64::NAN"
                    let v191 : float = Fable.Core.RustInterop.emitRustExpr () v190 
                    let v192 : string = "f64::NAN"
                    let v193 : float = Fable.Core.RustInterop.emitRustExpr () v192 
                    let v194 : string = "num_complex::Complex::new($0, $1)"
                    let v195 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v191, v193) v194 
                    let v198 : num_complex_Complex<float> =
                        match v186 with
                        | US0_1 -> (* None *)
                            v195
                        | US0_0(v196) -> (* Some *)
                            v196
                    let v199 : string = "num_complex::Complex::new($0, $1)"
                    let v200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v199 
                    let v201 : string = "$0 * $1"
                    let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v200, v106) v201 
                    let v203 : string = "num_complex::Complex::new($0, $1)"
                    let v204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v203 
                    let v205 : string = "$0 / $1"
                    let v206 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v202, v204) v205 
                    let v207 : string = "$0.sin()"
                    let v208 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v206 v207 
                    let v209 : string = "$0.re"
                    let v210 : float = Fable.Core.RustInterop.emitRustExpr v106 v209 
                    let v211 : float = 1.0 - v210
                    let v212 : string = "$0.im"
                    let v213 : float = Fable.Core.RustInterop.emitRustExpr v106 v212 
                    let v214 : float =  -v213
                    let v215 : string = "num_complex::Complex::new($0, $1)"
                    let v216 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v211, v214) v215 
                    let v217 : string = "$0.re"
                    let v218 : float = Fable.Core.RustInterop.emitRustExpr v216 v217 
                    let v219 : bool = v218 <= 1.0
                    let v600 : num_complex_Complex<float> =
                        if v219 then
                            let v220 : string = "num_complex::Complex::new($0, $1)"
                            let v221 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v220 
                            v221
                        else
                            let v222 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v216) v222 
                            let v223 : string = "$0.re"
                            let v224 : float = Fable.Core.RustInterop.emitRustExpr v216 v223 
                            let v225 : bool = v224 > 1.0
                            if v225 then
                                let v226 : string = "num_complex::Complex::new($0, $1)"
                                let v227 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v226 
                                let v228 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v229 : Mut0 = {l0 = 0} : Mut0
                                while method14(v229) do
                                    let v231 : int32 = v229.l0
                                    v228.[int v231] <- v231
                                    let v232 : int32 = v231 + 1
                                    v229.l0 <- v232
                                    ()
                                let v233 : int32 = v228.Length
                                let v234 : Mut2 = {l0 = 0; l1 = v227} : Mut2
                                while method15(v233, v234) do
                                    let v236 : int32 = v234.l0
                                    let v237 : num_complex_Complex<float> = v234.l1
                                    let v238 : int32 = v228.[int v236]
                                    let v239 : string = "num_complex::Complex::new($0, $1)"
                                    let v240 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v239 
                                    let v242 : (int32 -> float) = float
                                    let v243 : float = v242 v238
                                    let v246 : string = "num_complex::Complex::new($0, $1)"
                                    let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v243, 0.0) v246 
                                    let v248 : string = "num_complex::Complex::powc($0, $1)"
                                    let v249 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v247, v216) v248 
                                    let v250 : string = "$0 / $1"
                                    let v251 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v240, v249) v250 
                                    let v252 : string = "$0 + $1"
                                    let v253 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v237, v251) v252 
                                    let v254 : int32 = v236 + 1
                                    v234.l0 <- v254
                                    v234.l1 <- v253
                                    ()
                                let v255 : num_complex_Complex<float> = v234.l1
                                v255
                            else
                                let v256 : string = "num_complex::Complex::new($0, $1)"
                                let v257 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v256 
                                let v258 : string = "$0 - $1"
                                let v259 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v257, v216) v258 
                                let v260 : string = $"        s = mpmath.gamma(s)"
                                let v261 : num_complex_Complex<float> = method3(v259)
                                let v262 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v260, v261)
                                (* run_target_args'
                                let v264 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v265 : string = "$0.ok()"
                                let v266 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v262 v265 
                                let _run_target_args'_v264 = v266 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v267 : string = "$0.ok()"
                                let v268 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v262 v267 
                                let _run_target_args'_v264 = v268 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v269 : string = "$0.ok()"
                                let v270 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v262 v269 
                                let _run_target_args'_v264 = v270 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v271 : num_complex_Complex<float> option = match v262 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v264 = v271 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v272 : num_complex_Complex<float> option = match v262 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v264 = v272 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v273 : num_complex_Complex<float> option = match v262 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v264 = v273 
                                #endif
#else
                                let v274 : num_complex_Complex<float> option = match v262 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v264 = v274 
                                #endif
                                let v275 : num_complex_Complex<float> option = _run_target_args'_v264 
                                let v280 : (num_complex_Complex<float> -> US0) = method17()
                                let v281 : US0 option = v275 |> Option.map v280 
                                let v295 : US0 = US0_1
                                let v296 : US0 = v281 |> Option.defaultValue v295 
                                let v300 : string = "f64::NAN"
                                let v301 : float = Fable.Core.RustInterop.emitRustExpr () v300 
                                let v302 : string = "f64::NAN"
                                let v303 : float = Fable.Core.RustInterop.emitRustExpr () v302 
                                let v304 : string = "num_complex::Complex::new($0, $1)"
                                let v305 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v301, v303) v304 
                                let v308 : num_complex_Complex<float> =
                                    match v296 with
                                    | US0_1 -> (* None *)
                                        v305
                                    | US0_0(v306) -> (* Some *)
                                        v306
                                let v309 : string = "num_complex::Complex::new($0, $1)"
                                let v310 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v309 
                                let v311 : string = "$0 * $1"
                                let v312 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v310, v216) v311 
                                let v313 : string = "num_complex::Complex::new($0, $1)"
                                let v314 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v313 
                                let v315 : string = "$0 / $1"
                                let v316 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v312, v314) v315 
                                let v317 : string = "$0.sin()"
                                let v318 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v316 v317 
                                let v319 : string = "$0.re"
                                let v320 : float = Fable.Core.RustInterop.emitRustExpr v216 v319 
                                let v321 : float = 1.0 - v320
                                let v322 : string = "$0.im"
                                let v323 : float = Fable.Core.RustInterop.emitRustExpr v216 v322 
                                let v324 : float =  -v323
                                let v325 : string = "num_complex::Complex::new($0, $1)"
                                let v326 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v321, v324) v325 
                                let v327 : string = "$0.re"
                                let v328 : float = Fable.Core.RustInterop.emitRustExpr v326 v327 
                                let v329 : bool = v328 <= 1.0
                                let v584 : num_complex_Complex<float> =
                                    if v329 then
                                        let v330 : string = "num_complex::Complex::new($0, $1)"
                                        let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v330 
                                        v331
                                    else
                                        let v332 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v326) v332 
                                        let v333 : string = "$0.re"
                                        let v334 : float = Fable.Core.RustInterop.emitRustExpr v326 v333 
                                        let v335 : bool = v334 > 1.0
                                        if v335 then
                                            let v336 : string = "num_complex::Complex::new($0, $1)"
                                            let v337 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v336 
                                            let v338 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v339 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v339) do
                                                let v341 : int32 = v339.l0
                                                v338.[int v341] <- v341
                                                let v342 : int32 = v341 + 1
                                                v339.l0 <- v342
                                                ()
                                            let v343 : int32 = v338.Length
                                            let v344 : Mut2 = {l0 = 0; l1 = v337} : Mut2
                                            while method15(v343, v344) do
                                                let v346 : int32 = v344.l0
                                                let v347 : num_complex_Complex<float> = v344.l1
                                                let v348 : int32 = v338.[int v346]
                                                let v349 : string = "num_complex::Complex::new($0, $1)"
                                                let v350 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v349 
                                                let v352 : (int32 -> float) = float
                                                let v353 : float = v352 v348
                                                let v356 : string = "num_complex::Complex::new($0, $1)"
                                                let v357 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v353, 0.0) v356 
                                                let v358 : string = "num_complex::Complex::powc($0, $1)"
                                                let v359 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v357, v326) v358 
                                                let v360 : string = "$0 / $1"
                                                let v361 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v350, v359) v360 
                                                let v362 : string = "$0 + $1"
                                                let v363 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v347, v361) v362 
                                                let v364 : int32 = v346 + 1
                                                v344.l0 <- v364
                                                v344.l1 <- v363
                                                ()
                                            let v365 : num_complex_Complex<float> = v344.l1
                                            v365
                                        else
                                            let v366 : string = "num_complex::Complex::new($0, $1)"
                                            let v367 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v366 
                                            let v368 : string = "$0 - $1"
                                            let v369 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v367, v326) v368 
                                            let v370 : string = $"        s = mpmath.gamma(s)"
                                            let v371 : num_complex_Complex<float> = method3(v369)
                                            let v372 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v370, v371)
                                            (* run_target_args'
                                            let v374 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v375 : string = "$0.ok()"
                                            let v376 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v372 v375 
                                            let _run_target_args'_v374 = v376 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v377 : string = "$0.ok()"
                                            let v378 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v372 v377 
                                            let _run_target_args'_v374 = v378 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v379 : string = "$0.ok()"
                                            let v380 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v372 v379 
                                            let _run_target_args'_v374 = v380 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v381 : num_complex_Complex<float> option = match v372 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v374 = v381 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v382 : num_complex_Complex<float> option = match v372 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v374 = v382 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v383 : num_complex_Complex<float> option = match v372 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v374 = v383 
                                            #endif
#else
                                            let v384 : num_complex_Complex<float> option = match v372 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v374 = v384 
                                            #endif
                                            let v385 : num_complex_Complex<float> option = _run_target_args'_v374 
                                            let v390 : (num_complex_Complex<float> -> US0) = method17()
                                            let v391 : US0 option = v385 |> Option.map v390 
                                            let v405 : US0 = US0_1
                                            let v406 : US0 = v391 |> Option.defaultValue v405 
                                            let v410 : string = "f64::NAN"
                                            let v411 : float = Fable.Core.RustInterop.emitRustExpr () v410 
                                            let v412 : string = "f64::NAN"
                                            let v413 : float = Fable.Core.RustInterop.emitRustExpr () v412 
                                            let v414 : string = "num_complex::Complex::new($0, $1)"
                                            let v415 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v411, v413) v414 
                                            let v418 : num_complex_Complex<float> =
                                                match v406 with
                                                | US0_1 -> (* None *)
                                                    v415
                                                | US0_0(v416) -> (* Some *)
                                                    v416
                                            let v419 : string = "num_complex::Complex::new($0, $1)"
                                            let v420 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v419 
                                            let v421 : string = "$0 * $1"
                                            let v422 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v420, v326) v421 
                                            let v423 : string = "num_complex::Complex::new($0, $1)"
                                            let v424 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v423 
                                            let v425 : string = "$0 / $1"
                                            let v426 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v422, v424) v425 
                                            let v427 : string = "$0.sin()"
                                            let v428 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v426 v427 
                                            let v429 : string = "$0.re"
                                            let v430 : float = Fable.Core.RustInterop.emitRustExpr v326 v429 
                                            let v431 : float = 1.0 - v430
                                            let v432 : string = "$0.im"
                                            let v433 : float = Fable.Core.RustInterop.emitRustExpr v326 v432 
                                            let v434 : float =  -v433
                                            let v435 : string = "num_complex::Complex::new($0, $1)"
                                            let v436 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v431, v434) v435 
                                            let v437 : string = "$0.re"
                                            let v438 : float = Fable.Core.RustInterop.emitRustExpr v436 v437 
                                            let v439 : bool = v438 <= 1.0
                                            let v568 : num_complex_Complex<float> =
                                                if v439 then
                                                    let v440 : string = "num_complex::Complex::new($0, $1)"
                                                    let v441 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v440 
                                                    v441
                                                else
                                                    let v442 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v436) v442 
                                                    let v443 : string = "$0.re"
                                                    let v444 : float = Fable.Core.RustInterop.emitRustExpr v436 v443 
                                                    let v445 : bool = v444 > 1.0
                                                    if v445 then
                                                        let v446 : string = "num_complex::Complex::new($0, $1)"
                                                        let v447 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v446 
                                                        let v448 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v449 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v449) do
                                                            let v451 : int32 = v449.l0
                                                            v448.[int v451] <- v451
                                                            let v452 : int32 = v451 + 1
                                                            v449.l0 <- v452
                                                            ()
                                                        let v453 : int32 = v448.Length
                                                        let v454 : Mut2 = {l0 = 0; l1 = v447} : Mut2
                                                        while method15(v453, v454) do
                                                            let v456 : int32 = v454.l0
                                                            let v457 : num_complex_Complex<float> = v454.l1
                                                            let v458 : int32 = v448.[int v456]
                                                            let v459 : string = "num_complex::Complex::new($0, $1)"
                                                            let v460 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v459 
                                                            let v462 : (int32 -> float) = float
                                                            let v463 : float = v462 v458
                                                            let v466 : string = "num_complex::Complex::new($0, $1)"
                                                            let v467 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v463, 0.0) v466 
                                                            let v468 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v469 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v467, v436) v468 
                                                            let v470 : string = "$0 / $1"
                                                            let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v460, v469) v470 
                                                            let v472 : string = "$0 + $1"
                                                            let v473 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v457, v471) v472 
                                                            let v474 : int32 = v456 + 1
                                                            v454.l0 <- v474
                                                            v454.l1 <- v473
                                                            ()
                                                        let v475 : num_complex_Complex<float> = v454.l1
                                                        v475
                                                    else
                                                        let v476 : string = "num_complex::Complex::new($0, $1)"
                                                        let v477 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v476 
                                                        let v478 : string = "$0 - $1"
                                                        let v479 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v477, v436) v478 
                                                        let v480 : string = $"        s = mpmath.gamma(s)"
                                                        let v481 : num_complex_Complex<float> = method3(v479)
                                                        let v482 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v480, v481)
                                                        (* run_target_args'
                                                        let v484 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v485 : string = "$0.ok()"
                                                        let v486 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v482 v485 
                                                        let _run_target_args'_v484 = v486 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v487 : string = "$0.ok()"
                                                        let v488 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v482 v487 
                                                        let _run_target_args'_v484 = v488 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v489 : string = "$0.ok()"
                                                        let v490 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v482 v489 
                                                        let _run_target_args'_v484 = v490 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v491 : num_complex_Complex<float> option = match v482 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v484 = v491 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v492 : num_complex_Complex<float> option = match v482 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v484 = v492 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v493 : num_complex_Complex<float> option = match v482 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v484 = v493 
                                                        #endif
#else
                                                        let v494 : num_complex_Complex<float> option = match v482 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v484 = v494 
                                                        #endif
                                                        let v495 : num_complex_Complex<float> option = _run_target_args'_v484 
                                                        let v500 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v501 : US0 option = v495 |> Option.map v500 
                                                        let v515 : US0 = US0_1
                                                        let v516 : US0 = v501 |> Option.defaultValue v515 
                                                        let v520 : string = "f64::NAN"
                                                        let v521 : float = Fable.Core.RustInterop.emitRustExpr () v520 
                                                        let v522 : string = "f64::NAN"
                                                        let v523 : float = Fable.Core.RustInterop.emitRustExpr () v522 
                                                        let v524 : string = "num_complex::Complex::new($0, $1)"
                                                        let v525 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v521, v523) v524 
                                                        let v528 : num_complex_Complex<float> =
                                                            match v516 with
                                                            | US0_1 -> (* None *)
                                                                v525
                                                            | US0_0(v526) -> (* Some *)
                                                                v526
                                                        let v529 : string = "num_complex::Complex::new($0, $1)"
                                                        let v530 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v529 
                                                        let v531 : string = "$0 * $1"
                                                        let v532 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v530, v436) v531 
                                                        let v533 : string = "num_complex::Complex::new($0, $1)"
                                                        let v534 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v533 
                                                        let v535 : string = "$0 / $1"
                                                        let v536 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v532, v534) v535 
                                                        let v537 : string = "$0.sin()"
                                                        let v538 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v536 v537 
                                                        let v539 : string = "$0.re"
                                                        let v540 : float = Fable.Core.RustInterop.emitRustExpr v436 v539 
                                                        let v541 : float = 1.0 - v540
                                                        let v542 : string = "$0.im"
                                                        let v543 : float = Fable.Core.RustInterop.emitRustExpr v436 v542 
                                                        let v544 : float =  -v543
                                                        let v545 : string = "num_complex::Complex::new($0, $1)"
                                                        let v546 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v541, v544) v545 
                                                        let v547 : string = "$0.re"
                                                        let v548 : float = Fable.Core.RustInterop.emitRustExpr v546 v547 
                                                        let v549 : bool = v548 <= 1.0
                                                        let v552 : num_complex_Complex<float> =
                                                            if v549 then
                                                                let v550 : string = "num_complex::Complex::new($0, $1)"
                                                                let v551 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v550 
                                                                v551
                                                            else
                                                                v546
                                                        let v553 : string = "num_complex::Complex::new($0, $1)"
                                                        let v554 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v553 
                                                        let v555 : string = "num_complex::Complex::new($0, $1)"
                                                        let v556 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v555 
                                                        let v557 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v558 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v556, v436) v557 
                                                        let v559 : string = "$0 * $1"
                                                        let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v554, v558) v559 
                                                        let v561 : string = "$0 * $1"
                                                        let v562 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v560, v538) v561 
                                                        let v563 : string = "$0 * $1"
                                                        let v564 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v562, v528) v563 
                                                        let v565 : string = "$0 * $1"
                                                        let v566 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v564, v552) v565 
                                                        v566
                                            let v569 : string = "num_complex::Complex::new($0, $1)"
                                            let v570 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v569 
                                            let v571 : string = "num_complex::Complex::new($0, $1)"
                                            let v572 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v571 
                                            let v573 : string = "num_complex::Complex::powc($0, $1)"
                                            let v574 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v572, v326) v573 
                                            let v575 : string = "$0 * $1"
                                            let v576 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v570, v574) v575 
                                            let v577 : string = "$0 * $1"
                                            let v578 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v576, v428) v577 
                                            let v579 : string = "$0 * $1"
                                            let v580 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v578, v418) v579 
                                            let v581 : string = "$0 * $1"
                                            let v582 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v580, v568) v581 
                                            v582
                                let v585 : string = "num_complex::Complex::new($0, $1)"
                                let v586 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v585 
                                let v587 : string = "num_complex::Complex::new($0, $1)"
                                let v588 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v587 
                                let v589 : string = "num_complex::Complex::powc($0, $1)"
                                let v590 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v588, v216) v589 
                                let v591 : string = "$0 * $1"
                                let v592 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v586, v590) v591 
                                let v593 : string = "$0 * $1"
                                let v594 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v592, v318) v593 
                                let v595 : string = "$0 * $1"
                                let v596 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v594, v308) v595 
                                let v597 : string = "$0 * $1"
                                let v598 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v596, v584) v597 
                                v598
                    let v601 : string = "num_complex::Complex::new($0, $1)"
                    let v602 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v601 
                    let v603 : string = "num_complex::Complex::new($0, $1)"
                    let v604 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v603 
                    let v605 : string = "num_complex::Complex::powc($0, $1)"
                    let v606 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v604, v106) v605 
                    let v607 : string = "$0 * $1"
                    let v608 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v602, v606) v607 
                    let v609 : string = "$0 * $1"
                    let v610 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v608, v208) v609 
                    let v611 : string = "$0 * $1"
                    let v612 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v610, v198) v611 
                    let v613 : string = "$0 * $1"
                    let v614 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v612, v600) v613 
                    v614
        let v617 : string = "num_complex::Complex::new($0, $1)"
        let v618 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v617 
        let v619 : string = "num_complex::Complex::new($0, $1)"
        let v620 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v619 
        let v621 : string = "num_complex::Complex::powc($0, $1)"
        let v622 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v620, v1) v621 
        let v623 : string = "$0 * $1"
        let v624 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v618, v622) v623 
        let v625 : string = "$0 * $1"
        let v626 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v624, v98) v625 
        let v627 : string = "$0 * $1"
        let v628 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v626, v88) v627 
        let v629 : string = "$0 * $1"
        let v630 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v628, v616) v629 
        v630
and method18 (v0 : bool) : bool =
    v0
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
        let v33 : (num_complex_Complex<float> -> US0) = method17()
        let v34 : US0 option = v28 |> Option.map v33 
        let v48 : US0 = US0_1
        let v49 : US0 = v34 |> Option.defaultValue v48 
        let v53 : string = "f64::NAN"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53 
        let v55 : string = "f64::NAN"
        let v56 : float = Fable.Core.RustInterop.emitRustExpr () v55 
        let v57 : string = "num_complex::Complex::new($0, $1)"
        let v58 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v54, v56) v57 
        let v61 : num_complex_Complex<float> =
            match v49 with
            | US0_1 -> (* None *)
                v58
            | US0_0(v59) -> (* Some *)
                v59
        let v62 : string = "$0.im"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr v61 v62 
        let v64 : bool = v63 = 0.0
        let v66 : bool =
            if v64 then
                true
            else
                method18(v64)
        let v71 : string = "__assert_eq"
        let v72 : string = $"{v71} / actual: %A{v63} / expected: %A{0.0}"
        let v75 : unit = ()
        let v76 : (unit -> unit) = closure2(v72)
        let v77 : unit = (fun () -> v76 (); v75) ()
        let v79 : bool = v66 = false
        if v79 then
            failwith<unit> v72
        let v80 : string = "$0.re"
        let v81 : float = Fable.Core.RustInterop.emitRustExpr v61 v80 
        let v82 : float = v81 - v11
        let v83 : float =  -v82
        let v84 : bool = v82 >= v83
        let v85 : float =
            if v84 then
                v82
            else
                v83
        let v86 : bool = v85 < 0.0001
        let v88 : bool =
            if v86 then
                true
            else
                method18(v86)
        let v93 : string = "__assert_lt"
        let v94 : string = $"{v93} / actual: %A{v85} / expected: %A{0.0001}"
        let v97 : unit = ()
        let v98 : (unit -> unit) = closure2(v94)
        let v99 : unit = (fun () -> v98 (); v97) ()
        let v101 : bool = v88 = false
        if v101 then
            failwith<unit> v94
        let v102 : int32 = v9 + 1
        v7.l0 <- v102
        ()
    ()
and method19 (v0 : Result<unit, pyo3_PyErr>) : Result<unit, pyo3_PyErr> =
    v0
and method0 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method1(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method21 (v0 : pyo3_Python) : unit =
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
    let v24 : (num_complex_Complex<float> -> US0) = method17()
    let v25 : US0 option = v19 |> Option.map v24 
    let v39 : US0 = US0_1
    let v40 : US0 = v25 |> Option.defaultValue v39 
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
    let v55 : float = v54 - 0.8673
    let v56 : float =  -v55
    let v57 : bool = v55 >= v56
    let v58 : float =
        if v57 then
            v55
        else
            v56
    let v59 : bool = v58 < 0.001
    let v61 : bool =
        if v59 then
            true
        else
            method18(v59)
    let v66 : string = "__assert_lt"
    let v67 : string = $"{v66} / actual: %A{v58} / expected: %A{0.001}"
    let v70 : unit = ()
    let v71 : (unit -> unit) = closure2(v67)
    let v72 : unit = (fun () -> v71 (); v70) ()
    let v74 : bool = v61 = false
    if v74 then
        failwith<unit> v67
    let v75 : string = "$0.im"
    let v76 : float = Fable.Core.RustInterop.emitRustExpr v52 v75 
    let v77 : float = v76 - 0.275
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
            method18(v81)
    let v87 : string = $"{v66} / actual: %A{v80} / expected: %A{0.001}"
    let v90 : unit = ()
    let v91 : (unit -> unit) = closure2(v87)
    let v92 : unit = (fun () -> v91 (); v90) ()
    let v94 : bool = v83 = false
    if v94 then
        failwith<unit> v87
and method20 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method21(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method24 () : UH0 =
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
and method25 (v0 : pyo3_Python, v1 : UH0) : unit =
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
        let v27 : (num_complex_Complex<float> -> US0) = method17()
        let v28 : US0 option = v22 |> Option.map v27 
        let v42 : US0 = US0_1
        let v43 : US0 = v28 |> Option.defaultValue v42 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v50) v51 
        let v55 : num_complex_Complex<float> =
            match v43 with
            | US0_1 -> (* None *)
                v52
            | US0_0(v53) -> (* Some *)
                v53
        let v56 : string = "$0.re"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr v55 v56 
        let v58 : bool = v57 = 0.0
        let v60 : bool =
            if v58 then
                true
            else
                method18(v58)
        let v65 : string = "__assert_eq"
        let v66 : string = $"{v65} / actual: %A{v57} / expected: %A{0.0}"
        let v69 : unit = ()
        let v70 : (unit -> unit) = closure2(v66)
        let v71 : unit = (fun () -> v70 (); v69) ()
        let v73 : bool = v60 = false
        if v73 then
            failwith<unit> v66
        let v74 : string = "$0.im"
        let v75 : float = Fable.Core.RustInterop.emitRustExpr v55 v74 
        let v76 : bool = v75 = 0.0
        let v78 : bool =
            if v76 then
                true
            else
                method18(v76)
        let v82 : string = $"{v65} / actual: %A{v75} / expected: %A{0.0}"
        let v85 : unit = ()
        let v86 : (unit -> unit) = closure2(v82)
        let v87 : unit = (fun () -> v86 (); v85) ()
        let v89 : bool = v78 = false
        if v89 then
            failwith<unit> v82
        method25(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method23 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method24()
    method25(v0, v1)
and method22 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method23(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method27 (v0 : pyo3_Python) : unit =
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
        let v40 : (num_complex_Complex<float> -> US0) = method17()
        let v41 : US0 option = v35 |> Option.map v40 
        let v55 : US0 = US0_1
        let v56 : US0 = v41 |> Option.defaultValue v55 
        let v60 : string = "f64::NAN"
        let v61 : float = Fable.Core.RustInterop.emitRustExpr () v60 
        let v62 : string = "f64::NAN"
        let v63 : float = Fable.Core.RustInterop.emitRustExpr () v62 
        let v64 : string = "num_complex::Complex::new($0, $1)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v61, v63) v64 
        let v68 : num_complex_Complex<float> =
            match v56 with
            | US0_1 -> (* None *)
                v65
            | US0_0(v66) -> (* Some *)
                v66
        let v69 : string = "$0.re"
        let v70 : float = Fable.Core.RustInterop.emitRustExpr v68 v69 
        let v71 : float =  -v70
        let v72 : bool = v70 >= v71
        let v73 : float =
            if v72 then
                v70
            else
                v71
        let v74 : bool = v73 < 0.0001
        let v76 : bool =
            if v74 then
                true
            else
                method18(v74)
        let v81 : string = "__assert_lt"
        let v82 : string = $"{v81} / actual: %A{v73} / expected: %A{0.0001}"
        let v85 : unit = ()
        let v86 : (unit -> unit) = closure2(v82)
        let v87 : unit = (fun () -> v86 (); v85) ()
        let v89 : bool = v76 = false
        if v89 then
            failwith<unit> v82
        let v90 : string = "$0.im"
        let v91 : float = Fable.Core.RustInterop.emitRustExpr v68 v90 
        let v92 : float =  -v91
        let v93 : bool = v91 >= v92
        let v94 : float =
            if v93 then
                v91
            else
                v92
        let v95 : bool = v94 < 0.0001
        let v97 : bool =
            if v95 then
                true
            else
                method18(v95)
        let v101 : string = $"{v81} / actual: %A{v94} / expected: %A{0.0001}"
        let v104 : unit = ()
        let v105 : (unit -> unit) = closure2(v101)
        let v106 : unit = (fun () -> v105 (); v104) ()
        let v108 : bool = v97 = false
        if v108 then
            failwith<unit> v101
        let v109 : int32 = v17 + 1
        v15.l0 <- v109
        ()
    ()
and method26 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method27(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method29 (v0 : pyo3_Python) : unit =
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
        let v30 : (num_complex_Complex<float> -> US0) = method17()
        let v31 : US0 option = v25 |> Option.map v30 
        let v45 : US0 = US0_1
        let v46 : US0 = v31 |> Option.defaultValue v45 
        let v50 : string = "f64::NAN"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50 
        let v52 : string = "f64::NAN"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52 
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v51, v53) v54 
        let v58 : num_complex_Complex<float> =
            match v46 with
            | US0_1 -> (* None *)
                v55
            | US0_0(v56) -> (* Some *)
                v56
        let v59 : string = "$0.re"
        let v60 : float = Fable.Core.RustInterop.emitRustExpr v58 v59 
        let v61 : bool = v60 > 0.0
        let v63 : bool =
            if v61 then
                true
            else
                method18(v61)
        let v68 : string = "__assert_gt"
        let v69 : string = $"{v68} / actual: %A{v60} / expected: %A{0.0}"
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure2(v69)
        let v74 : unit = (fun () -> v73 (); v72) ()
        let v76 : bool = v63 = false
        if v76 then
            failwith<unit> v69
        let v77 : string = "$0.im"
        let v78 : float = Fable.Core.RustInterop.emitRustExpr v58 v77 
        let v79 : bool = v78 = 0.0
        let v81 : bool =
            if v79 then
                true
            else
                method18(v79)
        let v86 : string = "__assert_eq"
        let v87 : string = $"{v86} / actual: %A{v78} / expected: %A{0.0}"
        let v90 : unit = ()
        let v91 : (unit -> unit) = closure2(v87)
        let v92 : unit = (fun () -> v91 (); v90) ()
        let v94 : bool = v81 = false
        if v94 then
            failwith<unit> v87
        let v95 : int32 = v5 + 1
        v3.l0 <- v95
        ()
    ()
and method28 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method29(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method31 (v0 : pyo3_Python) : unit =
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
    let v24 : (num_complex_Complex<float> -> US0) = method17()
    let v25 : US0 option = v19 |> Option.map v24 
    let v39 : US0 = US0_1
    let v40 : US0 = v25 |> Option.defaultValue v39 
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
    let v55 : bool = v54 = infinity
    let v57 : bool =
        if v55 then
            true
        else
            method18(v55)
    let v62 : string = "__assert_eq"
    let v63 : string = $"{v62} / actual: %A{v54} / expected: %A{infinity}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure2(v63)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v70 : bool = v57 = false
    if v70 then
        failwith<unit> v63
    let v71 : string = "$0.im"
    let v72 : float = Fable.Core.RustInterop.emitRustExpr v52 v71 
    let v73 : bool = v72 = 0.0
    let v75 : bool =
        if v73 then
            true
        else
            method18(v73)
    let v79 : string = $"{v62} / actual: %A{v72} / expected: %A{0.0}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure2(v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v86 : bool = v75 = false
    if v86 then
        failwith<unit> v79
and method30 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method33 (v0 : pyo3_Python) : unit =
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
    let v24 : (num_complex_Complex<float> -> US0) = method17()
    let v25 : US0 option = v19 |> Option.map v24 
    let v39 : US0 = US0_1
    let v40 : US0 = v25 |> Option.defaultValue v39 
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
    let v54 : float = Fable.Core.RustInterop.emitRustExpr v2 v53 
    let v55 : string = "$0.im"
    let v56 : float = Fable.Core.RustInterop.emitRustExpr v2 v55 
    let v57 : float =  -v56
    let v58 : string = "num_complex::Complex::new($0, $1)"
    let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v54, v57) v58 
    let v60 : string = $"        s = mpmath.zeta(s)"
    let v61 : num_complex_Complex<float> = method3(v59)
    let v62 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v60, v61)
    let v63 : num_complex_Complex<float> = method13(v0, v59)
    (* run_target_args'
    let v65 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v66 : string = "$0.ok()"
    let v67 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v62 v66 
    let _run_target_args'_v65 = v67 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v68 : string = "$0.ok()"
    let v69 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v62 v68 
    let _run_target_args'_v65 = v69 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v70 : string = "$0.ok()"
    let v71 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v62 v70 
    let _run_target_args'_v65 = v71 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v72 : num_complex_Complex<float> option = match v62 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v65 = v72 
    #endif
#if FABLE_COMPILER_PYTHON
    let v73 : num_complex_Complex<float> option = match v62 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v65 = v73 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v74 : num_complex_Complex<float> option = match v62 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v65 = v74 
    #endif
#else
    let v75 : num_complex_Complex<float> option = match v62 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v65 = v75 
    #endif
    let v76 : num_complex_Complex<float> option = _run_target_args'_v65 
    let v81 : (num_complex_Complex<float> -> US0) = method17()
    let v82 : US0 option = v76 |> Option.map v81 
    let v96 : US0 = US0_1
    let v97 : US0 = v82 |> Option.defaultValue v96 
    let v101 : string = "f64::NAN"
    let v102 : float = Fable.Core.RustInterop.emitRustExpr () v101 
    let v103 : string = "f64::NAN"
    let v104 : float = Fable.Core.RustInterop.emitRustExpr () v103 
    let v105 : string = "num_complex::Complex::new($0, $1)"
    let v106 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v102, v104) v105 
    let v109 : num_complex_Complex<float> =
        match v97 with
        | US0_1 -> (* None *)
            v106
        | US0_0(v107) -> (* Some *)
            v107
    let v110 : string = "$0.conj()"
    let v111 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v109 v110 
    let v112 : string = "$0.re"
    let v113 : float = Fable.Core.RustInterop.emitRustExpr v52 v112 
    let v114 : string = "$0.re"
    let v115 : float = Fable.Core.RustInterop.emitRustExpr v111 v114 
    let v116 : bool = v113 = v115
    let v118 : bool =
        if v116 then
            true
        else
            method18(v116)
    let v123 : string = "__assert_eq"
    let v124 : string = $"{v123} / actual: %A{v113} / expected: %A{v115}"
    let v127 : unit = ()
    let v128 : (unit -> unit) = closure2(v124)
    let v129 : unit = (fun () -> v128 (); v127) ()
    let v131 : bool = v118 = false
    if v131 then
        failwith<unit> v124
    let v132 : string = "$0.im"
    let v133 : float = Fable.Core.RustInterop.emitRustExpr v52 v132 
    let v134 : string = "$0.im"
    let v135 : float = Fable.Core.RustInterop.emitRustExpr v111 v134 
    let v136 : bool = v133 = v135
    let v138 : bool =
        if v136 then
            true
        else
            method18(v136)
    let v142 : string = $"{v123} / actual: %A{v133} / expected: %A{v135}"
    let v145 : unit = ()
    let v146 : (unit -> unit) = closure2(v142)
    let v147 : unit = (fun () -> v146 (); v145) ()
    let v149 : bool = v138 = false
    if v149 then
        failwith<unit> v142
and method32 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method33(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method35 (v0 : pyo3_Python) : unit =
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
    let v24 : (num_complex_Complex<float> -> US0) = method17()
    let v25 : US0 option = v19 |> Option.map v24 
    let v39 : US0 = US0_1
    let v40 : US0 = v25 |> Option.defaultValue v39 
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
    let v55 : bool = v54 < infinity
    let v57 : bool =
        if v55 then
            true
        else
            method18(v55)
    let v62 : string = "__assert_lt"
    let v63 : string = $"{v62} / actual: %A{v54} / expected: %A{infinity}"
    let v66 : unit = ()
    let v67 : (unit -> unit) = closure2(v63)
    let v68 : unit = (fun () -> v67 (); v66) ()
    let v70 : bool = v57 = false
    if v70 then
        failwith<unit> v63
    let v71 : string = "$0.im"
    let v72 : float = Fable.Core.RustInterop.emitRustExpr v52 v71 
    let v73 : bool = v72 < infinity
    let v75 : bool =
        if v73 then
            true
        else
            method18(v73)
    let v79 : string = $"{v62} / actual: %A{v72} / expected: %A{infinity}"
    let v82 : unit = ()
    let v83 : (unit -> unit) = closure2(v79)
    let v84 : unit = (fun () -> v83 (); v82) ()
    let v86 : bool = v75 = false
    if v86 then
        failwith<unit> v79
and method34 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method35(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method38 () : UH0 =
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
and method39 (v0 : pyo3_Python, v1 : UH0) : unit =
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
        let v27 : (num_complex_Complex<float> -> US0) = method17()
        let v28 : US0 option = v22 |> Option.map v27 
        let v42 : US0 = US0_1
        let v43 : US0 = v28 |> Option.defaultValue v42 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47 
        let v49 : string = "f64::NAN"
        let v50 : float = Fable.Core.RustInterop.emitRustExpr () v49 
        let v51 : string = "num_complex::Complex::new($0, $1)"
        let v52 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v48, v50) v51 
        let v55 : num_complex_Complex<float> =
            match v43 with
            | US0_1 -> (* None *)
                v52
            | US0_0(v53) -> (* Some *)
                v53
        let v56 : string = "$0.re"
        let v57 : float = Fable.Core.RustInterop.emitRustExpr v55 v56 
        let v59 : bool = v57 <> 0.0 
        let v63 : bool =
            if v59 then
                true
            else
                method18(v59)
        let v68 : string = "__assert_ne"
        let v69 : string = $"{v68} / actual: %A{v57} / expected: %A{0.0}"
        let v72 : unit = ()
        let v73 : (unit -> unit) = closure2(v69)
        let v74 : unit = (fun () -> v73 (); v72) ()
        let v76 : bool = v63 = false
        if v76 then
            failwith<unit> v69
        let v77 : string = "$0.im"
        let v78 : float = Fable.Core.RustInterop.emitRustExpr v55 v77 
        let v80 : bool = v78 <> 0.0 
        let v84 : bool =
            if v80 then
                true
            else
                method18(v80)
        let v88 : string = $"{v68} / actual: %A{v78} / expected: %A{0.0}"
        let v91 : unit = ()
        let v92 : (unit -> unit) = closure2(v88)
        let v93 : unit = (fun () -> v92 (); v91) ()
        let v95 : bool = v84 = false
        if v95 then
            failwith<unit> v88
        method39(v0, v3)
    | UH0_0 -> (* Nil *)
        ()
and method37 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method38()
    method39(v0, v1)
and method36 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method37(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method42 () : UH1 =
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
and method43 (v0 : pyo3_Python, v1 : UH1) : unit =
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
        let v25 : (num_complex_Complex<float> -> US0) = method17()
        let v26 : US0 option = v20 |> Option.map v25 
        let v40 : US0 = US0_1
        let v41 : US0 = v26 |> Option.defaultValue v40 
        let v45 : string = "f64::NAN"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47 
        let v49 : string = "num_complex::Complex::new($0, $1)"
        let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v46, v48) v49 
        let v53 : num_complex_Complex<float> =
            match v41 with
            | US0_1 -> (* None *)
                v50
            | US0_0(v51) -> (* Some *)
                v51
        let v54 : string = "$0.re"
        let v55 : float = Fable.Core.RustInterop.emitRustExpr v53 v54 
        let v57 : bool = v55 <> 0.0 
        let v61 : bool =
            if v57 then
                true
            else
                method18(v57)
        let v66 : string = "__assert_ne"
        let v67 : string = $"{v66} / actual: %A{v55} / expected: %A{0.0}"
        let v70 : unit = ()
        let v71 : (unit -> unit) = closure2(v67)
        let v72 : unit = (fun () -> v71 (); v70) ()
        let v74 : bool = v61 = false
        if v74 then
            failwith<unit> v67
        let v75 : string = "$0.im"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr v53 v75 
        let v78 : bool = v76 <> 0.0 
        let v82 : bool =
            if v78 then
                true
            else
                method18(v78)
        let v86 : string = $"{v66} / actual: %A{v76} / expected: %A{0.0}"
        let v89 : unit = ()
        let v90 : (unit -> unit) = closure2(v86)
        let v91 : unit = (fun () -> v90 (); v89) ()
        let v93 : bool = v82 = false
        if v93 then
            failwith<unit> v86
        method43(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method41 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method42()
    method43(v0, v1)
and method40 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method41(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method46 () : UH1 =
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
and method47 (v0 : pyo3_Python, v1 : UH1) : unit =
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
        let v25 : (num_complex_Complex<float> -> US0) = method17()
        let v26 : US0 option = v20 |> Option.map v25 
        let v40 : US0 = US0_1
        let v41 : US0 = v26 |> Option.defaultValue v40 
        let v45 : string = "f64::NAN"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45 
        let v47 : string = "f64::NAN"
        let v48 : float = Fable.Core.RustInterop.emitRustExpr () v47 
        let v49 : string = "num_complex::Complex::new($0, $1)"
        let v50 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v46, v48) v49 
        let v53 : num_complex_Complex<float> =
            match v41 with
            | US0_1 -> (* None *)
                v50
            | US0_0(v51) -> (* Some *)
                v51
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v54 
        let v56 : string = "num_complex::Complex::powc($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v2) v56 
        let v58 : string = "num_complex::Complex::new($0, $1)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v58 
        let v60 : string = "num_complex::Complex::new($0, $1)"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v60 
        let v62 : string = "$0 - $1"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v61) v62 
        let v64 : string = "num_complex::Complex::powc($0, $1)"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v59, v63) v64 
        let v66 : string = "$0 * $1"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v65) v66 
        let v68 : string = "num_complex::Complex::new($0, $1)"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v68 
        let v70 : string = "$0 * $1"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v69, v2) v70 
        let v72 : string = "num_complex::Complex::new($0, $1)"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v72 
        let v74 : string = "$0 / $1"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v71, v73) v74 
        let v76 : string = "$0.sin()"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v75 v76 
        let v78 : string = "$0 * $1"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v67, v77) v78 
        let v80 : string = "num_complex::Complex::new($0, $1)"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v80 
        let v82 : string = "$0 - $1"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v81, v2) v82 
        let v84 : string = $"        s = mpmath.gamma(s)"
        let v85 : num_complex_Complex<float> = method3(v83)
        let v86 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v84, v85)
        (* run_target_args'
        let v88 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v89 : string = "$0.ok()"
        let v90 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v86 v89 
        let _run_target_args'_v88 = v90 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v91 : string = "$0.ok()"
        let v92 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v86 v91 
        let _run_target_args'_v88 = v92 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v93 : string = "$0.ok()"
        let v94 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v86 v93 
        let _run_target_args'_v88 = v94 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v95 : num_complex_Complex<float> option = match v86 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v88 = v95 
        #endif
#if FABLE_COMPILER_PYTHON
        let v96 : num_complex_Complex<float> option = match v86 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v88 = v96 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v97 : num_complex_Complex<float> option = match v86 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v88 = v97 
        #endif
#else
        let v98 : num_complex_Complex<float> option = match v86 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v88 = v98 
        #endif
        let v99 : num_complex_Complex<float> option = _run_target_args'_v88 
        let v104 : (num_complex_Complex<float> -> US0) = method17()
        let v105 : US0 option = v99 |> Option.map v104 
        let v119 : US0 = US0_1
        let v120 : US0 = v105 |> Option.defaultValue v119 
        let v124 : string = "f64::NAN"
        let v125 : float = Fable.Core.RustInterop.emitRustExpr () v124 
        let v126 : string = "f64::NAN"
        let v127 : float = Fable.Core.RustInterop.emitRustExpr () v126 
        let v128 : string = "num_complex::Complex::new($0, $1)"
        let v129 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v125, v127) v128 
        let v132 : num_complex_Complex<float> =
            match v120 with
            | US0_1 -> (* None *)
                v129
            | US0_0(v130) -> (* Some *)
                v130
        let v133 : string = "$0 * $1"
        let v134 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v79, v132) v133 
        let v135 : string = "$0.re"
        let v136 : float = Fable.Core.RustInterop.emitRustExpr v2 v135 
        let v137 : float = 1.0 - v136
        let v138 : string = "$0.im"
        let v139 : float = Fable.Core.RustInterop.emitRustExpr v2 v138 
        let v140 : float =  -v139
        let v141 : string = "num_complex::Complex::new($0, $1)"
        let v142 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v137, v140) v141 
        let v143 : string = $"        s = mpmath.zeta(s)"
        let v144 : num_complex_Complex<float> = method3(v142)
        let v145 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v143, v144)
        let v146 : num_complex_Complex<float> = method13(v0, v142)
        (* run_target_args'
        let v148 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v149 : string = "$0.ok()"
        let v150 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v145 v149 
        let _run_target_args'_v148 = v150 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v151 : string = "$0.ok()"
        let v152 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v145 v151 
        let _run_target_args'_v148 = v152 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v153 : string = "$0.ok()"
        let v154 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v145 v153 
        let _run_target_args'_v148 = v154 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v155 : num_complex_Complex<float> option = match v145 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v148 = v155 
        #endif
#if FABLE_COMPILER_PYTHON
        let v156 : num_complex_Complex<float> option = match v145 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v148 = v156 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v157 : num_complex_Complex<float> option = match v145 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v148 = v157 
        #endif
#else
        let v158 : num_complex_Complex<float> option = match v145 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v148 = v158 
        #endif
        let v159 : num_complex_Complex<float> option = _run_target_args'_v148 
        let v164 : (num_complex_Complex<float> -> US0) = method17()
        let v165 : US0 option = v159 |> Option.map v164 
        let v179 : US0 = US0_1
        let v180 : US0 = v165 |> Option.defaultValue v179 
        let v184 : string = "f64::NAN"
        let v185 : float = Fable.Core.RustInterop.emitRustExpr () v184 
        let v186 : string = "f64::NAN"
        let v187 : float = Fable.Core.RustInterop.emitRustExpr () v186 
        let v188 : string = "num_complex::Complex::new($0, $1)"
        let v189 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v185, v187) v188 
        let v192 : num_complex_Complex<float> =
            match v180 with
            | US0_1 -> (* None *)
                v189
            | US0_0(v190) -> (* Some *)
                v190
        let v193 : string = "$0 * $1"
        let v194 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v134, v192) v193 
        let v195 : string = "$0.re"
        let v196 : float = Fable.Core.RustInterop.emitRustExpr v53 v195 
        let v197 : string = "$0.re"
        let v198 : float = Fable.Core.RustInterop.emitRustExpr v194 v197 
        let v199 : float = v196 - v198
        let v200 : float =  -v199
        let v201 : bool = v199 >= v200
        let v202 : float =
            if v201 then
                v199
            else
                v200
        let v203 : bool = v202 < 0.0001
        let v205 : bool =
            if v203 then
                true
            else
                method18(v203)
        let v210 : string = "__assert_lt"
        let v211 : string = $"{v210} / actual: %A{v202} / expected: %A{0.0001}"
        let v214 : unit = ()
        let v215 : (unit -> unit) = closure2(v211)
        let v216 : unit = (fun () -> v215 (); v214) ()
        let v218 : bool = v205 = false
        if v218 then
            failwith<unit> v211
        let v219 : string = "$0.im"
        let v220 : float = Fable.Core.RustInterop.emitRustExpr v53 v219 
        let v221 : string = "$0.im"
        let v222 : float = Fable.Core.RustInterop.emitRustExpr v194 v221 
        let v223 : float = v220 - v222
        let v224 : float =  -v223
        let v225 : bool = v223 >= v224
        let v226 : float =
            if v225 then
                v223
            else
                v224
        let v227 : bool = v226 < 0.0001
        let v229 : bool =
            if v227 then
                true
            else
                method18(v227)
        let v233 : string = $"{v210} / actual: %A{v226} / expected: %A{0.0001}"
        let v236 : unit = ()
        let v237 : (unit -> unit) = closure2(v233)
        let v238 : unit = (fun () -> v237 (); v236) ()
        let v240 : bool = v229 = false
        if v240 then
            failwith<unit> v233
        method47(v0, v3)
    | UH1_0 -> (* Nil *)
        ()
and method45 (v0 : pyo3_Python) : unit =
    let v1 : UH1 = method46()
    method47(v0, v1)
and method44 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method45(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
    // run_target_args' is_unit
    ()
and method50 () : UH0 =
    let v0 : UH0 = UH0_0
    let v1 : UH0 = UH0_1(5.0, v0)
    let v2 : UH0 = UH0_1(4.5, v1)
    let v3 : UH0 = UH0_1(4.0, v2)
    let v4 : UH0 = UH0_1(3.5, v3)
    let v5 : UH0 = UH0_1(3.0, v4)
    let v6 : UH0 = UH0_1(2.5, v5)
    UH0_1(2.0, v6)
and method51 () : UH0 =
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
and method53 (v0 : float, v1 : UH0, v2 : float) : float =
    match v1 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : float =  -v0
        let v6 : float = v3 ** v5
        let v7 : float = 1.0 - v6
        let v8 : float = v2 / v7
        method53(v0, v4, v8)
    | UH0_0 -> (* Nil *)
        v2
and method52 (v0 : pyo3_Python, v1 : UH0, v2 : UH0) : unit =
    match v2 with
    | UH0_1(v3, v4) -> (* Cons *)
        let v5 : string = "num_complex::Complex::new($0, $1)"
        let v6 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v3, 0.0) v5 
        let v7 : float = 1.0
        let v8 : float = method53(v3, v1, v7)
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
        let v30 : (num_complex_Complex<float> -> US0) = method17()
        let v31 : US0 option = v25 |> Option.map v30 
        let v45 : US0 = US0_1
        let v46 : US0 = v31 |> Option.defaultValue v45 
        let v50 : string = "f64::NAN"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50 
        let v52 : string = "f64::NAN"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr () v52 
        let v54 : string = "num_complex::Complex::new($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v51, v53) v54 
        let v58 : num_complex_Complex<float> =
            match v46 with
            | US0_1 -> (* None *)
                v55
            | US0_0(v56) -> (* Some *)
                v56
        let v59 : string = "$0.re"
        let v60 : float = Fable.Core.RustInterop.emitRustExpr v58 v59 
        let v61 : float = v60 - v8
        let v62 : float =  -v61
        let v63 : bool = v61 >= v62
        let v64 : float =
            if v63 then
                v61
            else
                v62
        let v65 : bool = v64 < 0.01
        let v67 : bool =
            if v65 then
                true
            else
                method18(v65)
        let v72 : string = "__assert_lt"
        let v73 : string = $"{v72} / actual: %A{v64} / expected: %A{0.01}"
        let v76 : unit = ()
        let v77 : (unit -> unit) = closure2(v73)
        let v78 : unit = (fun () -> v77 (); v76) ()
        let v80 : bool = v67 = false
        if v80 then
            failwith<unit> v73
        let v81 : string = "$0.im"
        let v82 : float = Fable.Core.RustInterop.emitRustExpr v58 v81 
        let v83 : bool = v82 < 0.01
        let v85 : bool =
            if v83 then
                true
            else
                method18(v83)
        let v89 : string = $"{v72} / actual: %A{v82} / expected: %A{0.01}"
        let v92 : unit = ()
        let v93 : (unit -> unit) = closure2(v89)
        let v94 : unit = (fun () -> v93 (); v92) ()
        let v96 : bool = v85 = false
        if v96 then
            failwith<unit> v89
        method52(v0, v1, v4)
    | UH0_0 -> (* Nil *)
        ()
and method49 (v0 : pyo3_Python) : unit =
    let v1 : UH0 = method50()
    let v2 : UH0 = method51()
    method52(v0, v2, v1)
and method48 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method49(v3)
    let v5 : Result<unit, pyo3_PyErr> = Ok () 
    let v8 : Result<unit, pyo3_PyErr> = method19(v5)
    let v9 : string = ""
    let v10 : string = "}"
    let v11 : string = v9 + v10 
    let v12 : string = v11 + v10 
    let v13 : string = "{"
    let v14 : string = v9 + v13 
    let x = v8 //
    let v15 : _ = x
    let v16 : unit = ()
    (* run_target_args'
    let v17 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v18 : string = $"true; let _fix_closure_v16 = $0"
    let v19 : bool = Fable.Core.RustInterop.emitRustExpr v15 v18 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v20 : string = $"true; let _fix_closure_v16 = $0"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr v15 v20 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v22 : string = $"true; let _fix_closure_v16 = $0"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr v15 v22 
    let _run_target_args'_v17 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v17 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v17 = false 
    #endif
#else
    let _run_target_args'_v17 = false 
    #endif
    let v24 : bool = _run_target_args'_v17 
    let v26 : string = $"true; _fix_closure_v16 " + v12 + "); " + v14 + " // rust.fix_closure'"
    let v27 : bool = Fable.Core.RustInterop.emitRustExpr () v26 
    let v28 : string = "__run_test"
    let v29 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v28 
    (* run_target_args'
    let v30 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v31 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v31 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v32 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v32 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v33 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v29 v33 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v29 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    method20()
    let v10 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "test_trivial_zero_at_negative_even___"
    let v12 : string = $"*/ #[test] fn " + v11 + "() { //"
    let v13 : bool = Fable.Core.RustInterop.emitRustExpr () v12 
    method22()
    let v14 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "test_non_trivial_zero___"
    let v16 : string = $"*/ #[test] fn " + v15 + "() { //"
    let v17 : bool = Fable.Core.RustInterop.emitRustExpr () v16 
    method26()
    let v18 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "test_real_part_greater_than_one___"
    let v20 : string = $"*/ #[test] fn " + v19 + "() { //"
    let v21 : bool = Fable.Core.RustInterop.emitRustExpr () v20 
    method28()
    let v22 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "test_zeta_at_1___"
    let v24 : string = $"*/ #[test] fn " + v23 + "() { //"
    let v25 : bool = Fable.Core.RustInterop.emitRustExpr () v24 
    method30()
    let v26 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "test_symmetry_across_real_axis___"
    let v28 : string = $"*/ #[test] fn " + v27 + "() { //"
    let v29 : bool = Fable.Core.RustInterop.emitRustExpr () v28 
    method32()
    let v30 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "test_behavior_near_origin___"
    let v32 : string = $"*/ #[test] fn " + v31 + "() { //"
    let v33 : bool = Fable.Core.RustInterop.emitRustExpr () v32 
    method34()
    let v34 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "test_imaginary_axis"
    let v36 : string = $"*/ #[test] fn " + v35 + "() { //"
    let v37 : bool = Fable.Core.RustInterop.emitRustExpr () v36 
    method36()
    let v38 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "test_critical_strip"
    let v40 : string = $"*/ #[test] fn " + v39 + "() { //"
    let v41 : bool = Fable.Core.RustInterop.emitRustExpr () v40 
    method40()
    let v42 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "test_reflection_formula_for_specific_value"
    let v44 : string = $"*/ #[test] fn " + v43 + "() { //"
    let v45 : bool = Fable.Core.RustInterop.emitRustExpr () v44 
    method44()
    let v46 : string = "} /* /*"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = "test_euler_product_formula"
    let v48 : string = $"*/ #[test] fn " + v47 + "() { //"
    let v49 : bool = Fable.Core.RustInterop.emitRustExpr () v48 
    method48()
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
    let v2 : unit = ()
    let v3 : (unit -> unit) = closure2(v1)
    let v4 : unit = (fun () -> v3 (); v2) ()
    0
let v0 : (unit -> unit) = closure0()
let tests () = v0 ()
let v1 : ((string []) -> int32) = closure3()
let main args = v1 args
()
