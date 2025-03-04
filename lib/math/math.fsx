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
    let v434 : Result<num_complex_Complex<float>, std_string_String> = Ok v433 
    v434
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
    let v434 : Result<num_complex_Complex<float>, std_string_String> = Ok v433 
    v434
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
        let v59 : (num_complex_Complex<float> -> US0) = method17()
        let v60 : US0 option = v55 |> Option.map v59 
        let v73 : US0 = US0_1
        let v74 : US0 = v60 |> Option.defaultValue v73 
        let v78 : string = "f64::NAN"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr () v78 
        let v80 : string = "f64::NAN"
        let v81 : float = Fable.Core.RustInterop.emitRustExpr () v80 
        let v82 : string = "num_complex::Complex::new($0, $1)"
        let v83 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v79, v81) v82 
        let v86 : num_complex_Complex<float> =
            match v74 with
            | US0_1 -> (* None *)
                v83
            | US0_0(v84) -> (* Some *)
                v84
        let v87 : string = "num_complex::Complex::new($0, $1)"
        let v88 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v87 
        let v89 : string = "$0 * $1"
        let v90 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v88, v1) v89 
        let v91 : string = "num_complex::Complex::new($0, $1)"
        let v92 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v91 
        let v93 : string = "$0 / $1"
        let v94 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v90, v92) v93 
        let v95 : string = "$0.sin()"
        let v96 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v94 v95 
        let v97 : string = "$0.re"
        let v98 : float = Fable.Core.RustInterop.emitRustExpr v1 v97 
        let v99 : float = 1.0 - v98
        let v100 : string = "$0.im"
        let v101 : float = Fable.Core.RustInterop.emitRustExpr v1 v100 
        let v102 : float =  -v101
        let v103 : string = "num_complex::Complex::new($0, $1)"
        let v104 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v99, v102) v103 
        let v105 : string = "$0.re"
        let v106 : float = Fable.Core.RustInterop.emitRustExpr v104 v105 
        let v107 : bool = v106 <= 1.0
        let v606 : num_complex_Complex<float> =
            if v107 then
                let v108 : string = "num_complex::Complex::new($0, $1)"
                let v109 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v108 
                v109
            else
                let v110 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                Fable.Core.RustInterop.emitRustExpr struct (1, v104) v110 
                let v111 : string = "$0.re"
                let v112 : float = Fable.Core.RustInterop.emitRustExpr v104 v111 
                let v113 : bool = v112 > 1.0
                if v113 then
                    let v114 : string = "num_complex::Complex::new($0, $1)"
                    let v115 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v114 
                    let v116 : (int32 []) = Array.zeroCreate<int32> (10000)
                    let v117 : Mut0 = {l0 = 0} : Mut0
                    while method14(v117) do
                        let v119 : int32 = v117.l0
                        v116.[int v119] <- v119
                        let v120 : int32 = v119 + 1
                        v117.l0 <- v120
                        ()
                    let v121 : int32 = v116.Length
                    let v122 : Mut2 = {l0 = 0; l1 = v115} : Mut2
                    while method15(v121, v122) do
                        let v124 : int32 = v122.l0
                        let v125 : num_complex_Complex<float> = v122.l1
                        let v126 : int32 = v116.[int v124]
                        let v127 : string = "num_complex::Complex::new($0, $1)"
                        let v128 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v127 
                        let v130 : (int32 -> float) = float
                        let v131 : float = v130 v126
                        let v134 : string = "num_complex::Complex::new($0, $1)"
                        let v135 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v131, 0.0) v134 
                        let v136 : string = "num_complex::Complex::powc($0, $1)"
                        let v137 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v135, v104) v136 
                        let v138 : string = "$0 / $1"
                        let v139 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v128, v137) v138 
                        let v140 : string = "$0 + $1"
                        let v141 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v125, v139) v140 
                        let v142 : int32 = v124 + 1
                        v122.l0 <- v142
                        v122.l1 <- v141
                        ()
                    let v143 : num_complex_Complex<float> = v122.l1
                    v143
                else
                    let v144 : string = "num_complex::Complex::new($0, $1)"
                    let v145 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v144 
                    let v146 : string = "$0 - $1"
                    let v147 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v145, v104) v146 
                    let v148 : string = $"        s = mpmath.gamma(s)"
                    let v149 : num_complex_Complex<float> = method3(v147)
                    let v150 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v148, v149)
                    (* run_target_args'
                    let v152 : unit = ()
                    run_target_args' *)
                    
#if FABLE_COMPILER || WASM || CONTRACT
                    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                    let v153 : string = "$0.ok()"
                    let v154 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v150 v153 
                    let _run_target_args'_v152 = v154 
                    #endif
#if FABLE_COMPILER_RUST && WASM
                    let v155 : string = "$0.ok()"
                    let v156 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v150 v155 
                    let _run_target_args'_v152 = v156 
                    #endif
#if FABLE_COMPILER_RUST && CONTRACT
                    let v157 : string = "$0.ok()"
                    let v158 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v150 v157 
                    let _run_target_args'_v152 = v158 
                    #endif
#if FABLE_COMPILER_TYPESCRIPT
                    let v159 : num_complex_Complex<float> option = match v150 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v152 = v159 
                    #endif
#if FABLE_COMPILER_PYTHON
                    let v160 : num_complex_Complex<float> option = match v150 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v152 = v160 
                    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                    let v161 : num_complex_Complex<float> option = match v150 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v152 = v161 
                    #endif
#else
                    let v162 : num_complex_Complex<float> option = match v150 with Ok x -> Some x | Error _ -> None
                    let _run_target_args'_v152 = v162 
                    #endif
                    let v163 : num_complex_Complex<float> option = _run_target_args'_v152 
                    let v167 : (num_complex_Complex<float> -> US0) = method17()
                    let v168 : US0 option = v163 |> Option.map v167 
                    let v181 : US0 = US0_1
                    let v182 : US0 = v168 |> Option.defaultValue v181 
                    let v186 : string = "f64::NAN"
                    let v187 : float = Fable.Core.RustInterop.emitRustExpr () v186 
                    let v188 : string = "f64::NAN"
                    let v189 : float = Fable.Core.RustInterop.emitRustExpr () v188 
                    let v190 : string = "num_complex::Complex::new($0, $1)"
                    let v191 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v187, v189) v190 
                    let v194 : num_complex_Complex<float> =
                        match v182 with
                        | US0_1 -> (* None *)
                            v191
                        | US0_0(v192) -> (* Some *)
                            v192
                    let v195 : string = "num_complex::Complex::new($0, $1)"
                    let v196 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v195 
                    let v197 : string = "$0 * $1"
                    let v198 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v196, v104) v197 
                    let v199 : string = "num_complex::Complex::new($0, $1)"
                    let v200 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v199 
                    let v201 : string = "$0 / $1"
                    let v202 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v198, v200) v201 
                    let v203 : string = "$0.sin()"
                    let v204 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v202 v203 
                    let v205 : string = "$0.re"
                    let v206 : float = Fable.Core.RustInterop.emitRustExpr v104 v205 
                    let v207 : float = 1.0 - v206
                    let v208 : string = "$0.im"
                    let v209 : float = Fable.Core.RustInterop.emitRustExpr v104 v208 
                    let v210 : float =  -v209
                    let v211 : string = "num_complex::Complex::new($0, $1)"
                    let v212 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v207, v210) v211 
                    let v213 : string = "$0.re"
                    let v214 : float = Fable.Core.RustInterop.emitRustExpr v212 v213 
                    let v215 : bool = v214 <= 1.0
                    let v590 : num_complex_Complex<float> =
                        if v215 then
                            let v216 : string = "num_complex::Complex::new($0, $1)"
                            let v217 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v216 
                            v217
                        else
                            let v218 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                            Fable.Core.RustInterop.emitRustExpr struct (2, v212) v218 
                            let v219 : string = "$0.re"
                            let v220 : float = Fable.Core.RustInterop.emitRustExpr v212 v219 
                            let v221 : bool = v220 > 1.0
                            if v221 then
                                let v222 : string = "num_complex::Complex::new($0, $1)"
                                let v223 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v222 
                                let v224 : (int32 []) = Array.zeroCreate<int32> (10000)
                                let v225 : Mut0 = {l0 = 0} : Mut0
                                while method14(v225) do
                                    let v227 : int32 = v225.l0
                                    v224.[int v227] <- v227
                                    let v228 : int32 = v227 + 1
                                    v225.l0 <- v228
                                    ()
                                let v229 : int32 = v224.Length
                                let v230 : Mut2 = {l0 = 0; l1 = v223} : Mut2
                                while method15(v229, v230) do
                                    let v232 : int32 = v230.l0
                                    let v233 : num_complex_Complex<float> = v230.l1
                                    let v234 : int32 = v224.[int v232]
                                    let v235 : string = "num_complex::Complex::new($0, $1)"
                                    let v236 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v235 
                                    let v238 : (int32 -> float) = float
                                    let v239 : float = v238 v234
                                    let v242 : string = "num_complex::Complex::new($0, $1)"
                                    let v243 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v239, 0.0) v242 
                                    let v244 : string = "num_complex::Complex::powc($0, $1)"
                                    let v245 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v243, v212) v244 
                                    let v246 : string = "$0 / $1"
                                    let v247 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v236, v245) v246 
                                    let v248 : string = "$0 + $1"
                                    let v249 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v233, v247) v248 
                                    let v250 : int32 = v232 + 1
                                    v230.l0 <- v250
                                    v230.l1 <- v249
                                    ()
                                let v251 : num_complex_Complex<float> = v230.l1
                                v251
                            else
                                let v252 : string = "num_complex::Complex::new($0, $1)"
                                let v253 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v252 
                                let v254 : string = "$0 - $1"
                                let v255 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v253, v212) v254 
                                let v256 : string = $"        s = mpmath.gamma(s)"
                                let v257 : num_complex_Complex<float> = method3(v255)
                                let v258 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v256, v257)
                                (* run_target_args'
                                let v260 : unit = ()
                                run_target_args' *)
                                
#if FABLE_COMPILER || WASM || CONTRACT
                                
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                let v261 : string = "$0.ok()"
                                let v262 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v258 v261 
                                let _run_target_args'_v260 = v262 
                                #endif
#if FABLE_COMPILER_RUST && WASM
                                let v263 : string = "$0.ok()"
                                let v264 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v258 v263 
                                let _run_target_args'_v260 = v264 
                                #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                let v265 : string = "$0.ok()"
                                let v266 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v258 v265 
                                let _run_target_args'_v260 = v266 
                                #endif
#if FABLE_COMPILER_TYPESCRIPT
                                let v267 : num_complex_Complex<float> option = match v258 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v260 = v267 
                                #endif
#if FABLE_COMPILER_PYTHON
                                let v268 : num_complex_Complex<float> option = match v258 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v260 = v268 
                                #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                let v269 : num_complex_Complex<float> option = match v258 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v260 = v269 
                                #endif
#else
                                let v270 : num_complex_Complex<float> option = match v258 with Ok x -> Some x | Error _ -> None
                                let _run_target_args'_v260 = v270 
                                #endif
                                let v271 : num_complex_Complex<float> option = _run_target_args'_v260 
                                let v275 : (num_complex_Complex<float> -> US0) = method17()
                                let v276 : US0 option = v271 |> Option.map v275 
                                let v289 : US0 = US0_1
                                let v290 : US0 = v276 |> Option.defaultValue v289 
                                let v294 : string = "f64::NAN"
                                let v295 : float = Fable.Core.RustInterop.emitRustExpr () v294 
                                let v296 : string = "f64::NAN"
                                let v297 : float = Fable.Core.RustInterop.emitRustExpr () v296 
                                let v298 : string = "num_complex::Complex::new($0, $1)"
                                let v299 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v295, v297) v298 
                                let v302 : num_complex_Complex<float> =
                                    match v290 with
                                    | US0_1 -> (* None *)
                                        v299
                                    | US0_0(v300) -> (* Some *)
                                        v300
                                let v303 : string = "num_complex::Complex::new($0, $1)"
                                let v304 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v303 
                                let v305 : string = "$0 * $1"
                                let v306 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v304, v212) v305 
                                let v307 : string = "num_complex::Complex::new($0, $1)"
                                let v308 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v307 
                                let v309 : string = "$0 / $1"
                                let v310 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v306, v308) v309 
                                let v311 : string = "$0.sin()"
                                let v312 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v310 v311 
                                let v313 : string = "$0.re"
                                let v314 : float = Fable.Core.RustInterop.emitRustExpr v212 v313 
                                let v315 : float = 1.0 - v314
                                let v316 : string = "$0.im"
                                let v317 : float = Fable.Core.RustInterop.emitRustExpr v212 v316 
                                let v318 : float =  -v317
                                let v319 : string = "num_complex::Complex::new($0, $1)"
                                let v320 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v315, v318) v319 
                                let v321 : string = "$0.re"
                                let v322 : float = Fable.Core.RustInterop.emitRustExpr v320 v321 
                                let v323 : bool = v322 <= 1.0
                                let v574 : num_complex_Complex<float> =
                                    if v323 then
                                        let v324 : string = "num_complex::Complex::new($0, $1)"
                                        let v325 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v324 
                                        v325
                                    else
                                        let v326 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                        Fable.Core.RustInterop.emitRustExpr struct (3, v320) v326 
                                        let v327 : string = "$0.re"
                                        let v328 : float = Fable.Core.RustInterop.emitRustExpr v320 v327 
                                        let v329 : bool = v328 > 1.0
                                        if v329 then
                                            let v330 : string = "num_complex::Complex::new($0, $1)"
                                            let v331 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v330 
                                            let v332 : (int32 []) = Array.zeroCreate<int32> (10000)
                                            let v333 : Mut0 = {l0 = 0} : Mut0
                                            while method14(v333) do
                                                let v335 : int32 = v333.l0
                                                v332.[int v335] <- v335
                                                let v336 : int32 = v335 + 1
                                                v333.l0 <- v336
                                                ()
                                            let v337 : int32 = v332.Length
                                            let v338 : Mut2 = {l0 = 0; l1 = v331} : Mut2
                                            while method15(v337, v338) do
                                                let v340 : int32 = v338.l0
                                                let v341 : num_complex_Complex<float> = v338.l1
                                                let v342 : int32 = v332.[int v340]
                                                let v343 : string = "num_complex::Complex::new($0, $1)"
                                                let v344 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v343 
                                                let v346 : (int32 -> float) = float
                                                let v347 : float = v346 v342
                                                let v350 : string = "num_complex::Complex::new($0, $1)"
                                                let v351 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v347, 0.0) v350 
                                                let v352 : string = "num_complex::Complex::powc($0, $1)"
                                                let v353 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v351, v320) v352 
                                                let v354 : string = "$0 / $1"
                                                let v355 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v344, v353) v354 
                                                let v356 : string = "$0 + $1"
                                                let v357 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v341, v355) v356 
                                                let v358 : int32 = v340 + 1
                                                v338.l0 <- v358
                                                v338.l1 <- v357
                                                ()
                                            let v359 : num_complex_Complex<float> = v338.l1
                                            v359
                                        else
                                            let v360 : string = "num_complex::Complex::new($0, $1)"
                                            let v361 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v360 
                                            let v362 : string = "$0 - $1"
                                            let v363 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v361, v320) v362 
                                            let v364 : string = $"        s = mpmath.gamma(s)"
                                            let v365 : num_complex_Complex<float> = method3(v363)
                                            let v366 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v364, v365)
                                            (* run_target_args'
                                            let v368 : unit = ()
                                            run_target_args' *)
                                            
#if FABLE_COMPILER || WASM || CONTRACT
                                            
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                            let v369 : string = "$0.ok()"
                                            let v370 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v366 v369 
                                            let _run_target_args'_v368 = v370 
                                            #endif
#if FABLE_COMPILER_RUST && WASM
                                            let v371 : string = "$0.ok()"
                                            let v372 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v366 v371 
                                            let _run_target_args'_v368 = v372 
                                            #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                            let v373 : string = "$0.ok()"
                                            let v374 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v366 v373 
                                            let _run_target_args'_v368 = v374 
                                            #endif
#if FABLE_COMPILER_TYPESCRIPT
                                            let v375 : num_complex_Complex<float> option = match v366 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v368 = v375 
                                            #endif
#if FABLE_COMPILER_PYTHON
                                            let v376 : num_complex_Complex<float> option = match v366 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v368 = v376 
                                            #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                            let v377 : num_complex_Complex<float> option = match v366 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v368 = v377 
                                            #endif
#else
                                            let v378 : num_complex_Complex<float> option = match v366 with Ok x -> Some x | Error _ -> None
                                            let _run_target_args'_v368 = v378 
                                            #endif
                                            let v379 : num_complex_Complex<float> option = _run_target_args'_v368 
                                            let v383 : (num_complex_Complex<float> -> US0) = method17()
                                            let v384 : US0 option = v379 |> Option.map v383 
                                            let v397 : US0 = US0_1
                                            let v398 : US0 = v384 |> Option.defaultValue v397 
                                            let v402 : string = "f64::NAN"
                                            let v403 : float = Fable.Core.RustInterop.emitRustExpr () v402 
                                            let v404 : string = "f64::NAN"
                                            let v405 : float = Fable.Core.RustInterop.emitRustExpr () v404 
                                            let v406 : string = "num_complex::Complex::new($0, $1)"
                                            let v407 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v403, v405) v406 
                                            let v410 : num_complex_Complex<float> =
                                                match v398 with
                                                | US0_1 -> (* None *)
                                                    v407
                                                | US0_0(v408) -> (* Some *)
                                                    v408
                                            let v411 : string = "num_complex::Complex::new($0, $1)"
                                            let v412 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v411 
                                            let v413 : string = "$0 * $1"
                                            let v414 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v412, v320) v413 
                                            let v415 : string = "num_complex::Complex::new($0, $1)"
                                            let v416 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v415 
                                            let v417 : string = "$0 / $1"
                                            let v418 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v414, v416) v417 
                                            let v419 : string = "$0.sin()"
                                            let v420 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v418 v419 
                                            let v421 : string = "$0.re"
                                            let v422 : float = Fable.Core.RustInterop.emitRustExpr v320 v421 
                                            let v423 : float = 1.0 - v422
                                            let v424 : string = "$0.im"
                                            let v425 : float = Fable.Core.RustInterop.emitRustExpr v320 v424 
                                            let v426 : float =  -v425
                                            let v427 : string = "num_complex::Complex::new($0, $1)"
                                            let v428 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v423, v426) v427 
                                            let v429 : string = "$0.re"
                                            let v430 : float = Fable.Core.RustInterop.emitRustExpr v428 v429 
                                            let v431 : bool = v430 <= 1.0
                                            let v558 : num_complex_Complex<float> =
                                                if v431 then
                                                    let v432 : string = "num_complex::Complex::new($0, $1)"
                                                    let v433 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v432 
                                                    v433
                                                else
                                                    let v434 : string = "println!(\"zeta / count: {:?} / s: {:?}\", $0, $1)"
                                                    Fable.Core.RustInterop.emitRustExpr struct (4, v428) v434 
                                                    let v435 : string = "$0.re"
                                                    let v436 : float = Fable.Core.RustInterop.emitRustExpr v428 v435 
                                                    let v437 : bool = v436 > 1.0
                                                    if v437 then
                                                        let v438 : string = "num_complex::Complex::new($0, $1)"
                                                        let v439 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v438 
                                                        let v440 : (int32 []) = Array.zeroCreate<int32> (10000)
                                                        let v441 : Mut0 = {l0 = 0} : Mut0
                                                        while method14(v441) do
                                                            let v443 : int32 = v441.l0
                                                            v440.[int v443] <- v443
                                                            let v444 : int32 = v443 + 1
                                                            v441.l0 <- v444
                                                            ()
                                                        let v445 : int32 = v440.Length
                                                        let v446 : Mut2 = {l0 = 0; l1 = v439} : Mut2
                                                        while method15(v445, v446) do
                                                            let v448 : int32 = v446.l0
                                                            let v449 : num_complex_Complex<float> = v446.l1
                                                            let v450 : int32 = v440.[int v448]
                                                            let v451 : string = "num_complex::Complex::new($0, $1)"
                                                            let v452 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v451 
                                                            let v454 : (int32 -> float) = float
                                                            let v455 : float = v454 v450
                                                            let v458 : string = "num_complex::Complex::new($0, $1)"
                                                            let v459 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v455, 0.0) v458 
                                                            let v460 : string = "num_complex::Complex::powc($0, $1)"
                                                            let v461 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v459, v428) v460 
                                                            let v462 : string = "$0 / $1"
                                                            let v463 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v452, v461) v462 
                                                            let v464 : string = "$0 + $1"
                                                            let v465 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v449, v463) v464 
                                                            let v466 : int32 = v448 + 1
                                                            v446.l0 <- v466
                                                            v446.l1 <- v465
                                                            ()
                                                        let v467 : num_complex_Complex<float> = v446.l1
                                                        v467
                                                    else
                                                        let v468 : string = "num_complex::Complex::new($0, $1)"
                                                        let v469 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v468 
                                                        let v470 : string = "$0 - $1"
                                                        let v471 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v469, v428) v470 
                                                        let v472 : string = $"        s = mpmath.gamma(s)"
                                                        let v473 : num_complex_Complex<float> = method3(v471)
                                                        let v474 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v472, v473)
                                                        (* run_target_args'
                                                        let v476 : unit = ()
                                                        run_target_args' *)
                                                        
#if FABLE_COMPILER || WASM || CONTRACT
                                                        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
                                                        let v477 : string = "$0.ok()"
                                                        let v478 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v474 v477 
                                                        let _run_target_args'_v476 = v478 
                                                        #endif
#if FABLE_COMPILER_RUST && WASM
                                                        let v479 : string = "$0.ok()"
                                                        let v480 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v474 v479 
                                                        let _run_target_args'_v476 = v480 
                                                        #endif
#if FABLE_COMPILER_RUST && CONTRACT
                                                        let v481 : string = "$0.ok()"
                                                        let v482 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v474 v481 
                                                        let _run_target_args'_v476 = v482 
                                                        #endif
#if FABLE_COMPILER_TYPESCRIPT
                                                        let v483 : num_complex_Complex<float> option = match v474 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v476 = v483 
                                                        #endif
#if FABLE_COMPILER_PYTHON
                                                        let v484 : num_complex_Complex<float> option = match v474 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v476 = v484 
                                                        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
                                                        let v485 : num_complex_Complex<float> option = match v474 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v476 = v485 
                                                        #endif
#else
                                                        let v486 : num_complex_Complex<float> option = match v474 with Ok x -> Some x | Error _ -> None
                                                        let _run_target_args'_v476 = v486 
                                                        #endif
                                                        let v487 : num_complex_Complex<float> option = _run_target_args'_v476 
                                                        let v491 : (num_complex_Complex<float> -> US0) = method17()
                                                        let v492 : US0 option = v487 |> Option.map v491 
                                                        let v505 : US0 = US0_1
                                                        let v506 : US0 = v492 |> Option.defaultValue v505 
                                                        let v510 : string = "f64::NAN"
                                                        let v511 : float = Fable.Core.RustInterop.emitRustExpr () v510 
                                                        let v512 : string = "f64::NAN"
                                                        let v513 : float = Fable.Core.RustInterop.emitRustExpr () v512 
                                                        let v514 : string = "num_complex::Complex::new($0, $1)"
                                                        let v515 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v511, v513) v514 
                                                        let v518 : num_complex_Complex<float> =
                                                            match v506 with
                                                            | US0_1 -> (* None *)
                                                                v515
                                                            | US0_0(v516) -> (* Some *)
                                                                v516
                                                        let v519 : string = "num_complex::Complex::new($0, $1)"
                                                        let v520 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v519 
                                                        let v521 : string = "$0 * $1"
                                                        let v522 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v520, v428) v521 
                                                        let v523 : string = "num_complex::Complex::new($0, $1)"
                                                        let v524 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v523 
                                                        let v525 : string = "$0 / $1"
                                                        let v526 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v522, v524) v525 
                                                        let v527 : string = "$0.sin()"
                                                        let v528 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v526 v527 
                                                        let v529 : string = "$0.re"
                                                        let v530 : float = Fable.Core.RustInterop.emitRustExpr v428 v529 
                                                        let v531 : float = 1.0 - v530
                                                        let v532 : string = "$0.im"
                                                        let v533 : float = Fable.Core.RustInterop.emitRustExpr v428 v532 
                                                        let v534 : float =  -v533
                                                        let v535 : string = "num_complex::Complex::new($0, $1)"
                                                        let v536 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v531, v534) v535 
                                                        let v537 : string = "$0.re"
                                                        let v538 : float = Fable.Core.RustInterop.emitRustExpr v536 v537 
                                                        let v539 : bool = v538 <= 1.0
                                                        let v542 : num_complex_Complex<float> =
                                                            if v539 then
                                                                let v540 : string = "num_complex::Complex::new($0, $1)"
                                                                let v541 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (0.0, 0.0) v540 
                                                                v541
                                                            else
                                                                v536
                                                        let v543 : string = "num_complex::Complex::new($0, $1)"
                                                        let v544 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v543 
                                                        let v545 : string = "num_complex::Complex::new($0, $1)"
                                                        let v546 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v545 
                                                        let v547 : string = "num_complex::Complex::powc($0, $1)"
                                                        let v548 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v546, v428) v547 
                                                        let v549 : string = "$0 * $1"
                                                        let v550 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v544, v548) v549 
                                                        let v551 : string = "$0 * $1"
                                                        let v552 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v550, v528) v551 
                                                        let v553 : string = "$0 * $1"
                                                        let v554 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v552, v518) v553 
                                                        let v555 : string = "$0 * $1"
                                                        let v556 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v554, v542) v555 
                                                        v556
                                            let v559 : string = "num_complex::Complex::new($0, $1)"
                                            let v560 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v559 
                                            let v561 : string = "num_complex::Complex::new($0, $1)"
                                            let v562 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v561 
                                            let v563 : string = "num_complex::Complex::powc($0, $1)"
                                            let v564 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v562, v320) v563 
                                            let v565 : string = "$0 * $1"
                                            let v566 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v560, v564) v565 
                                            let v567 : string = "$0 * $1"
                                            let v568 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v566, v420) v567 
                                            let v569 : string = "$0 * $1"
                                            let v570 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v568, v410) v569 
                                            let v571 : string = "$0 * $1"
                                            let v572 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v570, v558) v571 
                                            v572
                                let v575 : string = "num_complex::Complex::new($0, $1)"
                                let v576 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v575 
                                let v577 : string = "num_complex::Complex::new($0, $1)"
                                let v578 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v577 
                                let v579 : string = "num_complex::Complex::powc($0, $1)"
                                let v580 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v578, v212) v579 
                                let v581 : string = "$0 * $1"
                                let v582 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v576, v580) v581 
                                let v583 : string = "$0 * $1"
                                let v584 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v582, v312) v583 
                                let v585 : string = "$0 * $1"
                                let v586 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v584, v302) v585 
                                let v587 : string = "$0 * $1"
                                let v588 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v586, v574) v587 
                                v588
                    let v591 : string = "num_complex::Complex::new($0, $1)"
                    let v592 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v591 
                    let v593 : string = "num_complex::Complex::new($0, $1)"
                    let v594 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v593 
                    let v595 : string = "num_complex::Complex::powc($0, $1)"
                    let v596 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v594, v104) v595 
                    let v597 : string = "$0 * $1"
                    let v598 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v592, v596) v597 
                    let v599 : string = "$0 * $1"
                    let v600 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v598, v204) v599 
                    let v601 : string = "$0 * $1"
                    let v602 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v600, v194) v601 
                    let v603 : string = "$0 * $1"
                    let v604 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v602, v590) v603 
                    v604
        let v607 : string = "num_complex::Complex::new($0, $1)"
        let v608 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v607 
        let v609 : string = "num_complex::Complex::new($0, $1)"
        let v610 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v609 
        let v611 : string = "num_complex::Complex::powc($0, $1)"
        let v612 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v610, v1) v611 
        let v613 : string = "$0 * $1"
        let v614 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v608, v612) v613 
        let v615 : string = "$0 * $1"
        let v616 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v614, v96) v615 
        let v617 : string = "$0 * $1"
        let v618 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v616, v86) v617 
        let v619 : string = "$0 * $1"
        let v620 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v618, v606) v619 
        v620
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
        let v32 : (num_complex_Complex<float> -> US0) = method17()
        let v33 : US0 option = v28 |> Option.map v32 
        let v46 : US0 = US0_1
        let v47 : US0 = v33 |> Option.defaultValue v46 
        let v51 : string = "f64::NAN"
        let v52 : float = Fable.Core.RustInterop.emitRustExpr () v51 
        let v53 : string = "f64::NAN"
        let v54 : float = Fable.Core.RustInterop.emitRustExpr () v53 
        let v55 : string = "num_complex::Complex::new($0, $1)"
        let v56 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v52, v54) v55 
        let v59 : num_complex_Complex<float> =
            match v47 with
            | US0_1 -> (* None *)
                v56
            | US0_0(v57) -> (* Some *)
                v57
        let v60 : string = "$0.im"
        let v61 : float = Fable.Core.RustInterop.emitRustExpr v59 v60 
        let v62 : bool = v61 = 0.0
        let v64 : bool =
            if v62 then
                true
            else
                method18(v62)
        let v69 : string = "__assert_eq"
        let v70 : string = $"{v69} / actual: %A{v61} / expected: %A{0.0}"
        let v73 : unit = ()
        let v74 : (unit -> unit) = closure2(v70)
        let v75 : unit = (fun () -> v74 (); v73) ()
        let v77 : bool = v64 = false
        if v77 then
            failwith<unit> v70
        let v78 : string = "$0.re"
        let v79 : float = Fable.Core.RustInterop.emitRustExpr v59 v78 
        let v80 : float = v79 - v11
        let v81 : float =  -v80
        let v82 : bool = v80 >= v81
        let v83 : float =
            if v82 then
                v80
            else
                v81
        let v84 : bool = v83 < 0.0001
        let v86 : bool =
            if v84 then
                true
            else
                method18(v84)
        let v91 : string = "__assert_lt"
        let v92 : string = $"{v91} / actual: %A{v83} / expected: %A{0.0001}"
        let v95 : unit = ()
        let v96 : (unit -> unit) = closure2(v92)
        let v97 : unit = (fun () -> v96 (); v95) ()
        let v99 : bool = v86 = false
        if v99 then
            failwith<unit> v92
        let v100 : int32 = v9 + 1
        v7.l0 <- v100
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    let v23 : (num_complex_Complex<float> -> US0) = method17()
    let v24 : US0 option = v19 |> Option.map v23 
    let v37 : US0 = US0_1
    let v38 : US0 = v24 |> Option.defaultValue v37 
    let v42 : string = "f64::NAN"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "f64::NAN"
    let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "num_complex::Complex::new($0, $1)"
    let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v46 
    let v50 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v47
        | US0_0(v48) -> (* Some *)
            v48
    let v51 : string = "$0.re"
    let v52 : float = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : float = v52 - 0.8673
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
            method18(v57)
    let v64 : string = "__assert_lt"
    let v65 : string = $"{v64} / actual: %A{v56} / expected: %A{0.001}"
    let v68 : unit = ()
    let v69 : (unit -> unit) = closure2(v65)
    let v70 : unit = (fun () -> v69 (); v68) ()
    let v72 : bool = v59 = false
    if v72 then
        failwith<unit> v65
    let v73 : string = "$0.im"
    let v74 : float = Fable.Core.RustInterop.emitRustExpr v50 v73 
    let v75 : float = v74 - 0.275
    let v76 : float =  -v75
    let v77 : bool = v75 >= v76
    let v78 : float =
        if v77 then
            v75
        else
            v76
    let v79 : bool = v78 < 0.001
    let v81 : bool =
        if v79 then
            true
        else
            method18(v79)
    let v85 : string = $"{v64} / actual: %A{v78} / expected: %A{0.001}"
    let v88 : unit = ()
    let v89 : (unit -> unit) = closure2(v85)
    let v90 : unit = (fun () -> v89 (); v88) ()
    let v92 : bool = v81 = false
    if v92 then
        failwith<unit> v85
and method20 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method21(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v26 : (num_complex_Complex<float> -> US0) = method17()
        let v27 : US0 option = v22 |> Option.map v26 
        let v40 : US0 = US0_1
        let v41 : US0 = v27 |> Option.defaultValue v40 
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
        let v56 : bool = v55 = 0.0
        let v58 : bool =
            if v56 then
                true
            else
                method18(v56)
        let v63 : string = "__assert_eq"
        let v64 : string = $"{v63} / actual: %A{v55} / expected: %A{0.0}"
        let v67 : unit = ()
        let v68 : (unit -> unit) = closure2(v64)
        let v69 : unit = (fun () -> v68 (); v67) ()
        let v71 : bool = v58 = false
        if v71 then
            failwith<unit> v64
        let v72 : string = "$0.im"
        let v73 : float = Fable.Core.RustInterop.emitRustExpr v53 v72 
        let v74 : bool = v73 = 0.0
        let v76 : bool =
            if v74 then
                true
            else
                method18(v74)
        let v80 : string = $"{v63} / actual: %A{v73} / expected: %A{0.0}"
        let v83 : unit = ()
        let v84 : (unit -> unit) = closure2(v80)
        let v85 : unit = (fun () -> v84 (); v83) ()
        let v87 : bool = v76 = false
        if v87 then
            failwith<unit> v80
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v39 : (num_complex_Complex<float> -> US0) = method17()
        let v40 : US0 option = v35 |> Option.map v39 
        let v53 : US0 = US0_1
        let v54 : US0 = v40 |> Option.defaultValue v53 
        let v58 : string = "f64::NAN"
        let v59 : float = Fable.Core.RustInterop.emitRustExpr () v58 
        let v60 : string = "f64::NAN"
        let v61 : float = Fable.Core.RustInterop.emitRustExpr () v60 
        let v62 : string = "num_complex::Complex::new($0, $1)"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v59, v61) v62 
        let v66 : num_complex_Complex<float> =
            match v54 with
            | US0_1 -> (* None *)
                v63
            | US0_0(v64) -> (* Some *)
                v64
        let v67 : string = "$0.re"
        let v68 : float = Fable.Core.RustInterop.emitRustExpr v66 v67 
        let v69 : float =  -v68
        let v70 : bool = v68 >= v69
        let v71 : float =
            if v70 then
                v68
            else
                v69
        let v72 : bool = v71 < 0.0001
        let v74 : bool =
            if v72 then
                true
            else
                method18(v72)
        let v79 : string = "__assert_lt"
        let v80 : string = $"{v79} / actual: %A{v71} / expected: %A{0.0001}"
        let v83 : unit = ()
        let v84 : (unit -> unit) = closure2(v80)
        let v85 : unit = (fun () -> v84 (); v83) ()
        let v87 : bool = v74 = false
        if v87 then
            failwith<unit> v80
        let v88 : string = "$0.im"
        let v89 : float = Fable.Core.RustInterop.emitRustExpr v66 v88 
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
                method18(v93)
        let v99 : string = $"{v79} / actual: %A{v92} / expected: %A{0.0001}"
        let v102 : unit = ()
        let v103 : (unit -> unit) = closure2(v99)
        let v104 : unit = (fun () -> v103 (); v102) ()
        let v106 : bool = v95 = false
        if v106 then
            failwith<unit> v99
        let v107 : int32 = v17 + 1
        v15.l0 <- v107
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v29 : (num_complex_Complex<float> -> US0) = method17()
        let v30 : US0 option = v25 |> Option.map v29 
        let v43 : US0 = US0_1
        let v44 : US0 = v30 |> Option.defaultValue v43 
        let v48 : string = "f64::NAN"
        let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
        let v50 : string = "f64::NAN"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50 
        let v52 : string = "num_complex::Complex::new($0, $1)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v49, v51) v52 
        let v56 : num_complex_Complex<float> =
            match v44 with
            | US0_1 -> (* None *)
                v53
            | US0_0(v54) -> (* Some *)
                v54
        let v57 : string = "$0.re"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr v56 v57 
        let v59 : bool = v58 > 0.0
        let v61 : bool =
            if v59 then
                true
            else
                method18(v59)
        let v66 : string = "__assert_gt"
        let v67 : string = $"{v66} / actual: %A{v58} / expected: %A{0.0}"
        let v70 : unit = ()
        let v71 : (unit -> unit) = closure2(v67)
        let v72 : unit = (fun () -> v71 (); v70) ()
        let v74 : bool = v61 = false
        if v74 then
            failwith<unit> v67
        let v75 : string = "$0.im"
        let v76 : float = Fable.Core.RustInterop.emitRustExpr v56 v75 
        let v77 : bool = v76 = 0.0
        let v79 : bool =
            if v77 then
                true
            else
                method18(v77)
        let v84 : string = "__assert_eq"
        let v85 : string = $"{v84} / actual: %A{v76} / expected: %A{0.0}"
        let v88 : unit = ()
        let v89 : (unit -> unit) = closure2(v85)
        let v90 : unit = (fun () -> v89 (); v88) ()
        let v92 : bool = v79 = false
        if v92 then
            failwith<unit> v85
        let v93 : int32 = v5 + 1
        v3.l0 <- v93
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    let v23 : (num_complex_Complex<float> -> US0) = method17()
    let v24 : US0 option = v19 |> Option.map v23 
    let v37 : US0 = US0_1
    let v38 : US0 = v24 |> Option.defaultValue v37 
    let v42 : string = "f64::NAN"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "f64::NAN"
    let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "num_complex::Complex::new($0, $1)"
    let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v46 
    let v50 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v47
        | US0_0(v48) -> (* Some *)
            v48
    let v51 : string = "$0.re"
    let v52 : float = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : bool = v52 = infinity
    let v55 : bool =
        if v53 then
            true
        else
            method18(v53)
    let v60 : string = "__assert_eq"
    let v61 : string = $"{v60} / actual: %A{v52} / expected: %A{infinity}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure2(v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v68 : bool = v55 = false
    if v68 then
        failwith<unit> v61
    let v69 : string = "$0.im"
    let v70 : float = Fable.Core.RustInterop.emitRustExpr v50 v69 
    let v71 : bool = v70 = 0.0
    let v73 : bool =
        if v71 then
            true
        else
            method18(v71)
    let v77 : string = $"{v60} / actual: %A{v70} / expected: %A{0.0}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure2(v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v84 : bool = v73 = false
    if v84 then
        failwith<unit> v77
and method30 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method31(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    let v23 : (num_complex_Complex<float> -> US0) = method17()
    let v24 : US0 option = v19 |> Option.map v23 
    let v37 : US0 = US0_1
    let v38 : US0 = v24 |> Option.defaultValue v37 
    let v42 : string = "f64::NAN"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "f64::NAN"
    let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "num_complex::Complex::new($0, $1)"
    let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v46 
    let v50 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v47
        | US0_0(v48) -> (* Some *)
            v48
    let v51 : string = "$0.re"
    let v52 : float = Fable.Core.RustInterop.emitRustExpr v2 v51 
    let v53 : string = "$0.im"
    let v54 : float = Fable.Core.RustInterop.emitRustExpr v2 v53 
    let v55 : float =  -v54
    let v56 : string = "num_complex::Complex::new($0, $1)"
    let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v52, v55) v56 
    let v58 : string = $"        s = mpmath.zeta(s)"
    let v59 : num_complex_Complex<float> = method3(v57)
    let v60 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v58, v59)
    let v61 : num_complex_Complex<float> = method13(v0, v57)
    (* run_target_args'
    let v63 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v64 : string = "$0.ok()"
    let v65 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v60 v64 
    let _run_target_args'_v63 = v65 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v66 : string = "$0.ok()"
    let v67 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v60 v66 
    let _run_target_args'_v63 = v67 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v68 : string = "$0.ok()"
    let v69 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v60 v68 
    let _run_target_args'_v63 = v69 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let v70 : num_complex_Complex<float> option = match v60 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v63 = v70 
    #endif
#if FABLE_COMPILER_PYTHON
    let v71 : num_complex_Complex<float> option = match v60 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v63 = v71 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let v72 : num_complex_Complex<float> option = match v60 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v63 = v72 
    #endif
#else
    let v73 : num_complex_Complex<float> option = match v60 with Ok x -> Some x | Error _ -> None
    let _run_target_args'_v63 = v73 
    #endif
    let v74 : num_complex_Complex<float> option = _run_target_args'_v63 
    let v78 : (num_complex_Complex<float> -> US0) = method17()
    let v79 : US0 option = v74 |> Option.map v78 
    let v92 : US0 = US0_1
    let v93 : US0 = v79 |> Option.defaultValue v92 
    let v97 : string = "f64::NAN"
    let v98 : float = Fable.Core.RustInterop.emitRustExpr () v97 
    let v99 : string = "f64::NAN"
    let v100 : float = Fable.Core.RustInterop.emitRustExpr () v99 
    let v101 : string = "num_complex::Complex::new($0, $1)"
    let v102 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v98, v100) v101 
    let v105 : num_complex_Complex<float> =
        match v93 with
        | US0_1 -> (* None *)
            v102
        | US0_0(v103) -> (* Some *)
            v103
    let v106 : string = "$0.conj()"
    let v107 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v105 v106 
    let v108 : string = "$0.re"
    let v109 : float = Fable.Core.RustInterop.emitRustExpr v50 v108 
    let v110 : string = "$0.re"
    let v111 : float = Fable.Core.RustInterop.emitRustExpr v107 v110 
    let v112 : bool = v109 = v111
    let v114 : bool =
        if v112 then
            true
        else
            method18(v112)
    let v119 : string = "__assert_eq"
    let v120 : string = $"{v119} / actual: %A{v109} / expected: %A{v111}"
    let v123 : unit = ()
    let v124 : (unit -> unit) = closure2(v120)
    let v125 : unit = (fun () -> v124 (); v123) ()
    let v127 : bool = v114 = false
    if v127 then
        failwith<unit> v120
    let v128 : string = "$0.im"
    let v129 : float = Fable.Core.RustInterop.emitRustExpr v50 v128 
    let v130 : string = "$0.im"
    let v131 : float = Fable.Core.RustInterop.emitRustExpr v107 v130 
    let v132 : bool = v129 = v131
    let v134 : bool =
        if v132 then
            true
        else
            method18(v132)
    let v138 : string = $"{v119} / actual: %A{v129} / expected: %A{v131}"
    let v141 : unit = ()
    let v142 : (unit -> unit) = closure2(v138)
    let v143 : unit = (fun () -> v142 (); v141) ()
    let v145 : bool = v134 = false
    if v145 then
        failwith<unit> v138
and method32 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method33(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
    let v23 : (num_complex_Complex<float> -> US0) = method17()
    let v24 : US0 option = v19 |> Option.map v23 
    let v37 : US0 = US0_1
    let v38 : US0 = v24 |> Option.defaultValue v37 
    let v42 : string = "f64::NAN"
    let v43 : float = Fable.Core.RustInterop.emitRustExpr () v42 
    let v44 : string = "f64::NAN"
    let v45 : float = Fable.Core.RustInterop.emitRustExpr () v44 
    let v46 : string = "num_complex::Complex::new($0, $1)"
    let v47 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v43, v45) v46 
    let v50 : num_complex_Complex<float> =
        match v38 with
        | US0_1 -> (* None *)
            v47
        | US0_0(v48) -> (* Some *)
            v48
    let v51 : string = "$0.re"
    let v52 : float = Fable.Core.RustInterop.emitRustExpr v50 v51 
    let v53 : bool = v52 < infinity
    let v55 : bool =
        if v53 then
            true
        else
            method18(v53)
    let v60 : string = "__assert_lt"
    let v61 : string = $"{v60} / actual: %A{v52} / expected: %A{infinity}"
    let v64 : unit = ()
    let v65 : (unit -> unit) = closure2(v61)
    let v66 : unit = (fun () -> v65 (); v64) ()
    let v68 : bool = v55 = false
    if v68 then
        failwith<unit> v61
    let v69 : string = "$0.im"
    let v70 : float = Fable.Core.RustInterop.emitRustExpr v50 v69 
    let v71 : bool = v70 < infinity
    let v73 : bool =
        if v71 then
            true
        else
            method18(v71)
    let v77 : string = $"{v60} / actual: %A{v70} / expected: %A{infinity}"
    let v80 : unit = ()
    let v81 : (unit -> unit) = closure2(v77)
    let v82 : unit = (fun () -> v81 (); v80) ()
    let v84 : bool = v73 = false
    if v84 then
        failwith<unit> v77
and method34 () : unit =
    let v0 : string = "pyo3::prepare_freethreaded_python()"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "let __run_test = pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> { //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "py"
    let v3 : pyo3_Python = Fable.Core.RustInterop.emitRustExpr () v2 
    method35(v3)
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v26 : (num_complex_Complex<float> -> US0) = method17()
        let v27 : US0 option = v22 |> Option.map v26 
        let v40 : US0 = US0_1
        let v41 : US0 = v27 |> Option.defaultValue v40 
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v24 : (num_complex_Complex<float> -> US0) = method17()
        let v25 : US0 option = v20 |> Option.map v24 
        let v38 : US0 = US0_1
        let v39 : US0 = v25 |> Option.defaultValue v38 
        let v43 : string = "f64::NAN"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43 
        let v45 : string = "f64::NAN"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45 
        let v47 : string = "num_complex::Complex::new($0, $1)"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v44, v46) v47 
        let v51 : num_complex_Complex<float> =
            match v39 with
            | US0_1 -> (* None *)
                v48
            | US0_0(v49) -> (* Some *)
                v49
        let v52 : string = "$0.re"
        let v53 : float = Fable.Core.RustInterop.emitRustExpr v51 v52 
        let v55 : bool = v53 <> 0.0 
        let v59 : bool =
            if v55 then
                true
            else
                method18(v55)
        let v64 : string = "__assert_ne"
        let v65 : string = $"{v64} / actual: %A{v53} / expected: %A{0.0}"
        let v68 : unit = ()
        let v69 : (unit -> unit) = closure2(v65)
        let v70 : unit = (fun () -> v69 (); v68) ()
        let v72 : bool = v59 = false
        if v72 then
            failwith<unit> v65
        let v73 : string = "$0.im"
        let v74 : float = Fable.Core.RustInterop.emitRustExpr v51 v73 
        let v76 : bool = v74 <> 0.0 
        let v80 : bool =
            if v76 then
                true
            else
                method18(v76)
        let v84 : string = $"{v64} / actual: %A{v74} / expected: %A{0.0}"
        let v87 : unit = ()
        let v88 : (unit -> unit) = closure2(v84)
        let v89 : unit = (fun () -> v88 (); v87) ()
        let v91 : bool = v80 = false
        if v91 then
            failwith<unit> v84
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v24 : (num_complex_Complex<float> -> US0) = method17()
        let v25 : US0 option = v20 |> Option.map v24 
        let v38 : US0 = US0_1
        let v39 : US0 = v25 |> Option.defaultValue v38 
        let v43 : string = "f64::NAN"
        let v44 : float = Fable.Core.RustInterop.emitRustExpr () v43 
        let v45 : string = "f64::NAN"
        let v46 : float = Fable.Core.RustInterop.emitRustExpr () v45 
        let v47 : string = "num_complex::Complex::new($0, $1)"
        let v48 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v44, v46) v47 
        let v51 : num_complex_Complex<float> =
            match v39 with
            | US0_1 -> (* None *)
                v48
            | US0_0(v49) -> (* Some *)
                v49
        let v52 : string = "num_complex::Complex::new($0, $1)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v52 
        let v54 : string = "num_complex::Complex::powc($0, $1)"
        let v55 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v53, v2) v54 
        let v56 : string = "num_complex::Complex::new($0, $1)"
        let v57 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v56 
        let v58 : string = "num_complex::Complex::new($0, $1)"
        let v59 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v58 
        let v60 : string = "$0 - $1"
        let v61 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v2, v59) v60 
        let v62 : string = "num_complex::Complex::powc($0, $1)"
        let v63 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v57, v61) v62 
        let v64 : string = "$0 * $1"
        let v65 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v55, v63) v64 
        let v66 : string = "num_complex::Complex::new($0, $1)"
        let v67 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (3.141592653589793, 0.0) v66 
        let v68 : string = "$0 * $1"
        let v69 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v67, v2) v68 
        let v70 : string = "num_complex::Complex::new($0, $1)"
        let v71 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (2.0, 0.0) v70 
        let v72 : string = "$0 / $1"
        let v73 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v69, v71) v72 
        let v74 : string = "$0.sin()"
        let v75 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr v73 v74 
        let v76 : string = "$0 * $1"
        let v77 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v65, v75) v76 
        let v78 : string = "num_complex::Complex::new($0, $1)"
        let v79 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (1.0, 0.0) v78 
        let v80 : string = "$0 - $1"
        let v81 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v79, v2) v80 
        let v82 : string = $"        s = mpmath.gamma(s)"
        let v83 : num_complex_Complex<float> = method3(v81)
        let v84 : Result<num_complex_Complex<float>, std_string_String> = method16(v0, v82, v83)
        (* run_target_args'
        let v86 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v87 : string = "$0.ok()"
        let v88 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v84 v87 
        let _run_target_args'_v86 = v88 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v89 : string = "$0.ok()"
        let v90 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v84 v89 
        let _run_target_args'_v86 = v90 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v91 : string = "$0.ok()"
        let v92 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v84 v91 
        let _run_target_args'_v86 = v92 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v93 : num_complex_Complex<float> option = match v84 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v86 = v93 
        #endif
#if FABLE_COMPILER_PYTHON
        let v94 : num_complex_Complex<float> option = match v84 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v86 = v94 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v95 : num_complex_Complex<float> option = match v84 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v86 = v95 
        #endif
#else
        let v96 : num_complex_Complex<float> option = match v84 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v86 = v96 
        #endif
        let v97 : num_complex_Complex<float> option = _run_target_args'_v86 
        let v101 : (num_complex_Complex<float> -> US0) = method17()
        let v102 : US0 option = v97 |> Option.map v101 
        let v115 : US0 = US0_1
        let v116 : US0 = v102 |> Option.defaultValue v115 
        let v120 : string = "f64::NAN"
        let v121 : float = Fable.Core.RustInterop.emitRustExpr () v120 
        let v122 : string = "f64::NAN"
        let v123 : float = Fable.Core.RustInterop.emitRustExpr () v122 
        let v124 : string = "num_complex::Complex::new($0, $1)"
        let v125 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v121, v123) v124 
        let v128 : num_complex_Complex<float> =
            match v116 with
            | US0_1 -> (* None *)
                v125
            | US0_0(v126) -> (* Some *)
                v126
        let v129 : string = "$0 * $1"
        let v130 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v77, v128) v129 
        let v131 : string = "$0.re"
        let v132 : float = Fable.Core.RustInterop.emitRustExpr v2 v131 
        let v133 : float = 1.0 - v132
        let v134 : string = "$0.im"
        let v135 : float = Fable.Core.RustInterop.emitRustExpr v2 v134 
        let v136 : float =  -v135
        let v137 : string = "num_complex::Complex::new($0, $1)"
        let v138 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v133, v136) v137 
        let v139 : string = $"        s = mpmath.zeta(s)"
        let v140 : num_complex_Complex<float> = method3(v138)
        let v141 : Result<num_complex_Complex<float>, std_string_String> = method4(v0, v139, v140)
        let v142 : num_complex_Complex<float> = method13(v0, v138)
        (* run_target_args'
        let v144 : unit = ()
        run_target_args' *)
        
#if FABLE_COMPILER || WASM || CONTRACT
        
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
        let v145 : string = "$0.ok()"
        let v146 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v141 v145 
        let _run_target_args'_v144 = v146 
        #endif
#if FABLE_COMPILER_RUST && WASM
        let v147 : string = "$0.ok()"
        let v148 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v141 v147 
        let _run_target_args'_v144 = v148 
        #endif
#if FABLE_COMPILER_RUST && CONTRACT
        let v149 : string = "$0.ok()"
        let v150 : num_complex_Complex<float> option = Fable.Core.RustInterop.emitRustExpr v141 v149 
        let _run_target_args'_v144 = v150 
        #endif
#if FABLE_COMPILER_TYPESCRIPT
        let v151 : num_complex_Complex<float> option = match v141 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v144 = v151 
        #endif
#if FABLE_COMPILER_PYTHON
        let v152 : num_complex_Complex<float> option = match v141 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v144 = v152 
        #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
        let v153 : num_complex_Complex<float> option = match v141 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v144 = v153 
        #endif
#else
        let v154 : num_complex_Complex<float> option = match v141 with Ok x -> Some x | Error _ -> None
        let _run_target_args'_v144 = v154 
        #endif
        let v155 : num_complex_Complex<float> option = _run_target_args'_v144 
        let v159 : (num_complex_Complex<float> -> US0) = method17()
        let v160 : US0 option = v155 |> Option.map v159 
        let v173 : US0 = US0_1
        let v174 : US0 = v160 |> Option.defaultValue v173 
        let v178 : string = "f64::NAN"
        let v179 : float = Fable.Core.RustInterop.emitRustExpr () v178 
        let v180 : string = "f64::NAN"
        let v181 : float = Fable.Core.RustInterop.emitRustExpr () v180 
        let v182 : string = "num_complex::Complex::new($0, $1)"
        let v183 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v179, v181) v182 
        let v186 : num_complex_Complex<float> =
            match v174 with
            | US0_1 -> (* None *)
                v183
            | US0_0(v184) -> (* Some *)
                v184
        let v187 : string = "$0 * $1"
        let v188 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v130, v186) v187 
        let v189 : string = "$0.re"
        let v190 : float = Fable.Core.RustInterop.emitRustExpr v51 v189 
        let v191 : string = "$0.re"
        let v192 : float = Fable.Core.RustInterop.emitRustExpr v188 v191 
        let v193 : float = v190 - v192
        let v194 : float =  -v193
        let v195 : bool = v193 >= v194
        let v196 : float =
            if v195 then
                v193
            else
                v194
        let v197 : bool = v196 < 0.0001
        let v199 : bool =
            if v197 then
                true
            else
                method18(v197)
        let v204 : string = "__assert_lt"
        let v205 : string = $"{v204} / actual: %A{v196} / expected: %A{0.0001}"
        let v208 : unit = ()
        let v209 : (unit -> unit) = closure2(v205)
        let v210 : unit = (fun () -> v209 (); v208) ()
        let v212 : bool = v199 = false
        if v212 then
            failwith<unit> v205
        let v213 : string = "$0.im"
        let v214 : float = Fable.Core.RustInterop.emitRustExpr v51 v213 
        let v215 : string = "$0.im"
        let v216 : float = Fable.Core.RustInterop.emitRustExpr v188 v215 
        let v217 : float = v214 - v216
        let v218 : float =  -v217
        let v219 : bool = v217 >= v218
        let v220 : float =
            if v219 then
                v217
            else
                v218
        let v221 : bool = v220 < 0.0001
        let v223 : bool =
            if v221 then
                true
            else
                method18(v221)
        let v227 : string = $"{v204} / actual: %A{v220} / expected: %A{0.0001}"
        let v230 : unit = ()
        let v231 : (unit -> unit) = closure2(v227)
        let v232 : unit = (fun () -> v231 (); v230) ()
        let v234 : bool = v223 = false
        if v234 then
            failwith<unit> v227
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
        let v29 : (num_complex_Complex<float> -> US0) = method17()
        let v30 : US0 option = v25 |> Option.map v29 
        let v43 : US0 = US0_1
        let v44 : US0 = v30 |> Option.defaultValue v43 
        let v48 : string = "f64::NAN"
        let v49 : float = Fable.Core.RustInterop.emitRustExpr () v48 
        let v50 : string = "f64::NAN"
        let v51 : float = Fable.Core.RustInterop.emitRustExpr () v50 
        let v52 : string = "num_complex::Complex::new($0, $1)"
        let v53 : num_complex_Complex<float> = Fable.Core.RustInterop.emitRustExpr struct (v49, v51) v52 
        let v56 : num_complex_Complex<float> =
            match v44 with
            | US0_1 -> (* None *)
                v53
            | US0_0(v54) -> (* Some *)
                v54
        let v57 : string = "$0.re"
        let v58 : float = Fable.Core.RustInterop.emitRustExpr v56 v57 
        let v59 : float = v58 - v8
        let v60 : float =  -v59
        let v61 : bool = v59 >= v60
        let v62 : float =
            if v61 then
                v59
            else
                v60
        let v63 : bool = v62 < 0.01
        let v65 : bool =
            if v63 then
                true
            else
                method18(v63)
        let v70 : string = "__assert_lt"
        let v71 : string = $"{v70} / actual: %A{v62} / expected: %A{0.01}"
        let v74 : unit = ()
        let v75 : (unit -> unit) = closure2(v71)
        let v76 : unit = (fun () -> v75 (); v74) ()
        let v78 : bool = v65 = false
        if v78 then
            failwith<unit> v71
        let v79 : string = "$0.im"
        let v80 : float = Fable.Core.RustInterop.emitRustExpr v56 v79 
        let v81 : bool = v80 < 0.01
        let v83 : bool =
            if v81 then
                true
            else
                method18(v81)
        let v87 : string = $"{v70} / actual: %A{v80} / expected: %A{0.01}"
        let v90 : unit = ()
        let v91 : (unit -> unit) = closure2(v87)
        let v92 : unit = (fun () -> v91 (); v90) ()
        let v94 : bool = v83 = false
        if v94 then
            failwith<unit> v87
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
    let v4 : Result<unit, pyo3_PyErr> = Ok () 
    let v5 : Result<unit, pyo3_PyErr> = method19(v4)
    let v6 : string = ""
    let v7 : string = "}"
    let v8 : string = v6 + v7 
    let v9 : string = v8 + v7 
    let v10 : string = "{"
    let v11 : string = v6 + v10 
    let x = v5 //
    let v12 : _ = x
    let v13 : unit = ()
    (* run_target_args'
    let v14 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v15 : string = $"true; let _fix_closure_v13 = $0"
    let v16 : bool = Fable.Core.RustInterop.emitRustExpr v12 v15 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v17 : string = $"true; let _fix_closure_v13 = $0"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr v12 v17 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v19 : string = $"true; let _fix_closure_v13 = $0"
    let v20 : bool = Fable.Core.RustInterop.emitRustExpr v12 v19 
    let _run_target_args'_v14 = true 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    let _run_target_args'_v14 = false 
    #endif
#if FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    let _run_target_args'_v14 = false 
    #endif
#else
    let _run_target_args'_v14 = false 
    #endif
    let v21 : bool = _run_target_args'_v14 
    let v23 : string = $"true; _fix_closure_v13 " + v9 + "); " + v11 + " // rust.fix_closure'"
    let v24 : bool = Fable.Core.RustInterop.emitRustExpr () v23 
    let v25 : string = "__run_test"
    let v26 : Result<unit, pyo3_PyErr> = Fable.Core.RustInterop.emitRustExpr () v25 
    (* run_target_args'
    let v27 : unit = ()
    run_target_args' *)
    
#if FABLE_COMPILER || WASM || CONTRACT
    
#if FABLE_COMPILER_RUST && !WASM && !CONTRACT
    let v28 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v28 
    #endif
#if FABLE_COMPILER_RUST && WASM
    let v29 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v29 
    #endif
#if FABLE_COMPILER_RUST && CONTRACT
    let v30 : string = "$0.unwrap()"
    Fable.Core.RustInterop.emitRustExpr v26 v30 
    #endif
#if FABLE_COMPILER_TYPESCRIPT
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#if !FABLE_COMPILER_RUST && !FABLE_COMPILER_TYPESCRIPT && !FABLE_COMPILER_PYTHON
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
    #endif
#else
    match v26 with Ok x -> x | Error e -> failwith $"resultm.unwrap' / e: {e}"
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
